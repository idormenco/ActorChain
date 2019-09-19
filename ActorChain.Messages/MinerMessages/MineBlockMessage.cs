using System.Collections.Generic;

namespace ActorChain.Messages.MinerMessages
{
	public class MineBlockMessage
	{
		public IReadOnlyList<Transaction> Transactions { get; }
		public string PreviousBlockHash { get; }

		public MineBlockMessage(IReadOnlyList<Transaction> transactions, string previousBlockHash)
		{
			Transactions = transactions;
			PreviousBlockHash = previousBlockHash;
		}
	}
}