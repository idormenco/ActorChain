using Akka.Actor;

namespace ActorChain.Transactionist
{
	public class TransactionistActor : ReceiveActor
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");


		public TransactionistActor()
		{
			Receive<object>(m => _system.Tell(m));
		}
	}
}