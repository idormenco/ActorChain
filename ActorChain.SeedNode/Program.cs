using System;
using Akka.Actor;
using Akka.Configuration;

namespace ActorChain.SeedNode
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

			using (var system = ActorSystem.Create("SeedNodeSystem", config))
			{
				var seedNode = system.ActorOf(Props.Create<SeedNodeActor>());
				seedNode.Tell("hello from seed node");

				Console.Read();
			}

		}
	}
}