
using Akka.Actor;
using Akka.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ActorChain.Dashboard
{

	public delegate IActorRef DashboardActorProvider();

	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
				{
					builder.AllowAnyOrigin()
						   .AllowAnyMethod()
						   .AllowAnyHeader();
				}));

			services.AddSignalR();
			var config = ConfigurationFactory.ParseString(@"
			akka {  
			    actor {
			        provider = remote
			    }
			    remote {
			        dot-netty.tcp {
			            port = 8081
			            hostname = 0.0.0.0
			            public-hostname = localhost
			        }
			    }
			}
			");


			services.AddSingleton(_ => ActorSystem.Create("ActorCoinDashboard", config));

			services.AddSingleton<DashboardActorProvider>(provider =>
			{
				System.Diagnostics.Debugger.Log(1,"--","create actor");
				var actorSystem = provider.GetService<ActorSystem>();
				var hub = provider.GetService<IHubContext<DataHub, IDataHub>>();
				var dashboardActor = actorSystem.ActorOf(Props.Create(() => new DashboardActor(hub)));
				return () => dashboardActor;
			});

			services.AddControllersWithViews();
			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/dist";
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
		{

			lifetime.ApplicationStarted.Register(() =>
			{
				app.ApplicationServices.GetService<ActorSystem>(); // start Akka.NET
			});
			lifetime.ApplicationStopping.Register(() =>
			{
				app.ApplicationServices.GetService<ActorSystem>().Terminate().Wait();
			});

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseRouting();
			app.UseHttpsRedirection();
			app.UseCors("MyPolicy");

			app.UseEndpoints(ep =>
			{
				ep.MapHub<DataHub>("/data");
			});


			app.UseStaticFiles();
			if (!env.IsDevelopment())
			{
				app.UseSpaStaticFiles();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller}/{action=Index}/{id?}");
			});

			app.UseSpa(spa =>
			{
				// To learn more about options for serving an Angular SPA from ASP.NET Core,
				// see https://go.microsoft.com/fwlink/?linkid=864501

				spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment())
				{
					spa.UseAngularCliServer(npmScript: "start");
				}
			});
		}
	}
}
