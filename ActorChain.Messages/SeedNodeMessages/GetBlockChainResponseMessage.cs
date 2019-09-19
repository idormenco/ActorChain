using System.Collections.Generic;

namespace ActorChain.Messages.SeedNodeMessages
{
    public class GetBlockChainResponseMessage
    {
        public IReadOnlyList<Block> Blockchain { get; }

        public GetBlockChainResponseMessage(IReadOnlyList<Block> blockChain)
        {
            Blockchain = blockChain;
        }
    }
}