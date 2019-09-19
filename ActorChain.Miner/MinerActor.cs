using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ActorChain.Messages;
using ActorChain.Messages.MinerMessages;
using ActorChain.Messages.SeedNodeMessages;
using Akka.Actor;
using Newtonsoft.Json;

namespace ActorChain.Miner
{
	public class MinerActor : ReceiveActor,IHandle<ValidateBlockMessage>, IHandle<MineBlockMessage>
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");
		private readonly ActorSelection _seedNode = Context.ActorSelection("akka.tcp://SeedNodeSystem@localhost:8082/user/SeedNode");

		public MinerActor()
		{
			Receive<ValidateBlockMessage>(Handle);
			Receive<MineBlockMessage>(Handle);
		}

		public void Handle(ValidateBlockMessage message)
		{
			var blockForMining = new BlockForMining
			{
				Transactions = message.Transactions.ToArray(),
				PreviousBlockHash = message.PreviousBlockHash,
				Nonce= message.Nonce,
				Timestamp= message.Timestamp
			};

			var serializedBlock = JsonConvert.SerializeObject(blockForMining);

			var previousHash = _seedNode.Ask<string>(new GetLastTransactionHashMessage(), TimeSpan.FromSeconds(10)).Result;

			if (message.PreviousBlockHash!= previousHash)
			{
				Sender.Tell(false);
			}

			var blockHash = ToSha256(serializedBlock);
			if (blockHash != message.Hash)
			{
				Sender.Tell(false);
			}

			if (!blockHash.StartsWith("00"))
			{
				Sender.Tell(false);
			}

			Sender.Tell(true);

		}

		public void Handle(MineBlockMessage message)
		{
			var block = new BlockForMining
			{
				Transactions = message.Transactions.ToArray(),
				PreviousBlockHash = message.PreviousBlockHash,
				Nonce = 0,
				Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
			};

			while (true)
			{
				var serializedBlock = JsonConvert.SerializeObject(block);

				var blockHash = ToSha256(serializedBlock);
				if (blockHash.StartsWith("00"))
				{

					var chainBlock = new Block()
					{
						Hash = blockHash,
						Nonce = block.Nonce,
						Transactions = block.Transactions,
						PreviousBlockHash = block.PreviousBlockHash,
						Timestamp = block.Timestamp
					};

					var serializedChainBlock = JsonConvert.SerializeObject(chainBlock);
					_system.Tell(serializedChainBlock);

					return;
				}

				++block.Nonce;
			}

		}

		private string ToSha256(string serializedBlock)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// ComputeHash - returns byte array  
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(serializedBlock));

				// Convert byte array to a string   
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
	}
}