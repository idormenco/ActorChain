using ActorChain.Messages.MinerMessages;
using Akka.Actor;

namespace ActorChain.Miner
{
	public class MinerActor : ReceiveActor, IHandle<ValidateBlockMessage>, IHandle<MineBlockMessage>
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");

		public MinerActor()
		{
			Receive<ValidateBlockMessage>(Handle);
			Receive<MineBlockMessage>(Handle);
		}

		public void Handle(ValidateBlockMessage message)
		{
			throw new System.NotImplementedException();
		}

		public void Handle(MineBlockMessage message)
		{
			throw new System.NotImplementedException();
		}
	}
}