using System;
using Akka.Actor;
using Akka.Configuration;

namespace ActorChain.Miner
{
	public class Program
	{
		static void Main(string[] args)
		{

			var config = ConfigurationFactory.ParseString(@"
			akka {  
			    actor {
			        provider = remote
			    }
			    remote {
			        dot-netty.tcp {
					    port = 0
					    hostname = localhost
			        }
			    }
			}
			");

			using (var system = ActorSystem.Create("MinerSystem", config))
			{
				var seedNode = system.ActorOf(Props.Create<MinerActor>());
				seedNode.Tell("hello from miner");

				Console.Read();
			}

		}
	}
}