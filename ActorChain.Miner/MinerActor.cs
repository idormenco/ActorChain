using Akka.Actor;

namespace ActorChain.Miner
{
	public class MinerActor: ReceiveActor
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");

		public MinerActor()
		{
			Receive<object>(m =>
			{
				_system.Tell(m);
			});
		}
	}
}