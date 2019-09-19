using System;
namespace ActorChain.Messages.SeedNodeMessages
{
	public class AddTransactionMessage
	{
		public string Sender { get; }
		public string Receiver { get; }
		public decimal Amount { get; }

		public AddTransactionMessage(string sender, string receiver, decimal amount)
		{
			Sender = sender;
			Receiver = receiver;
			Amount = amount;
		}
	}
}