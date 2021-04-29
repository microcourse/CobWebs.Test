using System;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{

    public class MemoryPlayerStrategy : PlayerStrategyBase
    {
        public MemoryPlayerStrategy(BasketGameConfig config) : base(config)
        {
        }

        protected override int OnGetAnswer(BasketGameContext spec)
        {
            throw new NotImplementedException();
        }
    }
}