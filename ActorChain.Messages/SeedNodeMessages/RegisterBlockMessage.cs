using System.Collections.Generic;

namespace ActorChain.Messages.SeedNodeMessages
{
    public class RegisterBlockMessage
    {
        public IReadOnlyList<Transaction> Transactions { get; }
        public long Nonce { get; }
        public long Timestamp { get; }
        public string PreviousBlockHash { get; }
        public string Hash { get; }

        public RegisterBlockMessage(IReadOnlyList<Transaction> transactions, long nonce, long timestamp, string previousBlockHash, string hash)
        {
            Transactions = transactions;
            Nonce = nonce;
            Timestamp = timestamp;
            PreviousBlockHash = previousBlockHash;
            Hash = hash;
        }
    }
}