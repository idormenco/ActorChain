using System.Collections.Generic;
using System.Linq;
using ActorChain.Messages;
using ActorChain.Messages.SeedNodeMessages;
using Akka.Actor;

namespace ActorChain.SeedNode
{
	public class SeedNodeActor : ReceiveActor, IHandle<AddTransactionMessage>, IHandle<GetTransactionsMessage>, IHandle<ClearTransactionsMessage>, IHandle<GetLastTransactionHashMessage>
	{
		private readonly ActorSelection _system = Context.ActorSelection("akka.tcp://ActorCoinNetwork@localhost:8081/user/SystemSupervisor");
		private readonly Queue<Transaction> _transactions = new Queue<Transaction>();
		private string LastBlockHash = string.Empty;

		public SeedNodeActor()
		{
			Receive<AddTransactionMessage>(Handle);
			Receive<GetTransactionsMessage>(Handle);
			Receive<ClearTransactionsMessage>(Handle);
			Receive<GetLastTransactionHashMessage>(Handle);
		}
		public void Handle(AddTransactionMessage message)
		{
			_transactions.Enqueue(new Transaction(message.Sender, message.Receiver, message.Amount));
		}

		public void Handle(GetTransactionsMessage message)
		{
            var transactions = _transactions.ToList();

			Sender.Tell(new GetTransactionsResponseMessage(transactions));
		}

		public void Handle(ClearTransactionsMessage message)
		{
			_transactions.Clear();
		}

		public void Handle(GetLastTransactionHashMessage message)
		{
			Sender.Tell(LastBlockHash);
		}
	}
}