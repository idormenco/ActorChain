using System.Collections.ObjectModel;

namespace ActorChain.Messages.MinerMessages
{
	public class ValidateBlockMessage
	{
		public ReadOnlyCollection<Transaction> Transactions { get; }
		public long Nonce { get; }
		public long Timestamp { get; }
		public string PreviousBlockHash { get; }
		public string Hash { get; }

		public ValidateBlockMessage(ReadOnlyCollection<Transaction> transactions, long nonce, long timestamp, string previousBlockHash, string hash)
		{
			Transactions = transactions;
			Nonce = nonce;
			Timestamp = timestamp;
			PreviousBlockHash = previousBlockHash;
			Hash = hash;
		}
	}
}