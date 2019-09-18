using System;
using Akka.Actor;
using Akka.Configuration;

namespace ActorChain.System
{
	public class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Starting ActorChainNetwork");
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

			using (var system = ActorSystem.Create("ActorCoinNetwork", config))
			{
				var actorRef = system.ActorOf(Props.Create(() => new SystemActor()), "SystemSupervisor");
				
				Console.ReadLine();
			}
		}

	}
}
