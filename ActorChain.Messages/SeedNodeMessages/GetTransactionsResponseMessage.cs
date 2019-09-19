using System.Collections.Generic;

namespace ActorChain.Messages.SeedNodeMessages
{
    public class GetTransactionsResponseMessage
    {
        public List<Transaction> Transactions { get; }

        public GetTransactionsResponseMessage (List<Transaction> transactions)
        {
			Transactions = transactions;
        }
    }
}