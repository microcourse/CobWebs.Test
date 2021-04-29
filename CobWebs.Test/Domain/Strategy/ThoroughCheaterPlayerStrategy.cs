using System;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{
    public class ThoroughCheaterPlayerStrategy : PlayerStrategyBase
    {
        public ThoroughCheaterPlayerStrategy(BasketGameConfig config) : base(config)
        {
        }

        protected override int OnGetAnswer(BasketGameContext spec)
        {
            throw new NotImplementedException();
        }
    }
}