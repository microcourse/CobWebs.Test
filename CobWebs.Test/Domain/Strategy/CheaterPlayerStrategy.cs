using System;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{
    public class CheaterPlayerStrategy : PlayerStrategyBase
    {
        public CheaterPlayerStrategy(BasketGameConfig config) : base(config)
        {
        }

        protected override int OnGetAnswer(BasketGameContext spec)
        {
            throw new NotImplementedException();
        }
    }
}