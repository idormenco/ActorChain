using Akka.Actor;

namespace ActorChain.SeedNode
{
	public class SeedNodeActor : ReceiveActor
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");
		
		public SeedNodeActor()
		{
			Receive<object>((m) =>
			{
				_system.Tell(m);
			});
		}
	}
}