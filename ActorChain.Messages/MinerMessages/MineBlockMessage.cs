using System.Collections.Generic;

namespace ActorChain.Messages.MinerMessages
{
	public class MineBlockMessage
	{
		public IReadOnlyList<Transaction> Transactions { get; }
		public long Nonce { get; }
		public long Timestamp { get; }
		public string PreviousBlockHash { get; }

		public MineBlockMessage(IReadOnlyList<Transaction> transactions, long nonce, long timestamp, string previousBlockHash)
		{
			Transactions = transactions;
			Nonce = nonce;
			Timestamp = timestamp;
			PreviousBlockHash = previousBlockHash;
		}
	}
}