using ActorChain.Messages.SeedNodeMessages;
using ActorChain.Messages.Transactionist;
using Akka.Actor;

namespace ActorChain.Transactionist {
	public class TransactionistActor : ReceiveActor, IHandle<CreateTransactionMessage> {
		private readonly ActorSelection _system = Context.ActorSelection ("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");
		private readonly ActorSelection _seedNode = Context.ActorSelection ("akka.tcp://SeedNodeSystem@localhost:8082/user/SeedNode");

		public TransactionistActor () {
			Receive<CreateTransactionMessage> (Handle);
		}

		public void Handle (CreateTransactionMessage message) {
			_seedNode.Tell (new AddTransactionMessage (message.Sender, message.Receiver, message.Amount));
		}
	}
}