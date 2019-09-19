using ActorChain.Messages.Transactionist;
using Akka.Actor;

namespace ActorChain.Transactionist
{
	public class TransactionistActor : ReceiveActor, IHandle<CreateTransactionMessage>
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");


		public TransactionistActor()
		{
			Receive<CreateTransactionMessage>(Handle);
		}

		public void Handle(CreateTransactionMessage message)
		{
			throw new System.NotImplementedException();
		}
	}
}