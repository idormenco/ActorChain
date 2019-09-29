using Akka.Actor;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ActorChain.Dashboard
{
	public class DataHub : Hub<IDataHub>
	{
		private readonly IActorRef _actorRef;

		public DataHub(DashboardActorProvider actorProvider)
		{
			this._actorRef = actorProvider();
		}

		public async Task TransferTransactions(string user)
		{
			await Clients.All.TransferTransactions(user);
		}

		public async Task GetData()
		{
			_actorRef.Tell(new FetchDataMessage());
			await Clients.All.TransferTransactions("GetData");
			
		}
	}

	public interface IDataHub
	{
		Task TransferTransactions(string user);
		Task GetData();
	}
}