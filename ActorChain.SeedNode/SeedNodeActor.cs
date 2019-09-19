using ActorChain.Messages.SeedNodeMessages;
using Akka.Actor;

namespace ActorChain.SeedNode
{
	public class SeedNodeActor : ReceiveActor, IHandle<AddTransactionMessage>, IHandle<GetTransactionsMessage>, IHandle<ClearTransactionsMessage>, IHandle<GetLastTransactionHashMessage>
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");

		public SeedNodeActor()
		{
			Receive<AddTransactionMessage>(Handle);
			Receive<GetTransactionsMessage>(Handle);
			Receive<ClearTransactionsMessage>(Handle);
			Receive<GetLastTransactionHashMessage>(Handle);
		}
		public void Handle(AddTransactionMessage message)
		{
			throw new System.NotImplementedException();
		}

		public void Handle(GetTransactionsMessage message)
		{
			throw new System.NotImplementedException();
		}

		public void Handle(ClearTransactionsMessage message)
		{
			throw new System.NotImplementedException();
		}

		public void Handle(GetLastTransactionHashMessage message)
		{
			throw new System.NotImplementedException();
		}
	}
}