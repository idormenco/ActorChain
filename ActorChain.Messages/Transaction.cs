namespace ActorChain.Messages
{
	public class Transaction
	{
		public string Sender { get; }
		public string Receiver { get; }
		public decimal Amount { get; }

		public Transaction(string sender, string receiver, decimal amount)
		{
			Sender = sender;
			Receiver = receiver;
			Amount = amount;
		}
	}
}