using System;
using Akka.Actor;
using Akka.Configuration;

namespace ActorChain.Transactionist
{
	class Program
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

			using (var system = ActorSystem.Create("TransactionistsActor", config))
			{
				var seedNode = system.ActorOf(Props.Create<TransactionistActor>());
				seedNode.Tell("hello from transactionist");

				Console.Read();
			}
		}
	}
}
