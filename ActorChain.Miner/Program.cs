using System;
using System.Collections.Generic;
using ActorChain.Messages;
using ActorChain.Messages.MinerMessages;
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
				var result = seedNode.Ask<bool>(new ValidateBlockMessage(new List<Transaction>().AsReadOnly(), 0, DateTimeOffset.UtcNow.ToUnixTimeSeconds(), null, "02002")).Result;

				seedNode.Tell(new MineBlockMessage(new List<Transaction>().AsReadOnly(),"0202020" ));

				Console.WriteLine(result);

				Console.Read();
			}

		}
	}
}