namespace ActorChain.Messages.Transactionist
{
	public class CreateTransactionMessage
	{
		public string Sender { get; }
		public string Receiver { get; }
		public decimal Amount { get; }

		public CreateTransactionMessage(string sender, string receiver, decimal amount)
		{
			Sender = sender;
			Receiver = receiver;
			Amount = amount;
		}
	}
}