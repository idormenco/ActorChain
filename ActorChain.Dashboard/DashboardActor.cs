using Akka.Actor;
using Microsoft.AspNetCore.SignalR;

namespace ActorChain.Dashboard
{
	public class DashboardActor : ReceiveActor, IHandle<FetchDataMessage>
	{
		private readonly IHubContext<DataHub, IDataHub> hub;

		public DashboardActor(IHubContext<DataHub, IDataHub> hub)
		{
			this.hub = hub;
			Receive<FetchDataMessage>(Handle);
		}


		public void Handle(FetchDataMessage message)
		{
			System.Diagnostics.Debugger.Launch();
			hub.Clients.All.TransferTransactions("ododododood");
		}
	}
}
