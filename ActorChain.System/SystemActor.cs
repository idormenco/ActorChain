using System;
using Akka.Actor;

namespace ActorChain.System
{
	public class SystemActor: ReceiveActor
	{
		public SystemActor()
		{
			Receive<object>(m => { Console.WriteLine(m); });
		}
	}
}