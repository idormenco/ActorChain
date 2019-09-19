using System.Collections.Generic;

namespace ActorChain.Messages
{
	public class BlockForMining
	{
		public IReadOnlyList<Transaction> Transactions { get; set; }
		public long Nonce { get; set; }
		public long Timestamp { get; set; }
		public string PreviousBlockHash { get; set; }
	}
}