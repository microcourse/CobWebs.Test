using System;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{
    public class RandomPlayerStrategy : PlayerStrategyBase
    {
        public RandomPlayerStrategy(BasketGameConfig config) : base(config)
        {
        }

        protected override int OnGetAnswer(BasketGameContext spec)
        {
            Random r = new Random();
            return r.Next(_config.MinWeight, _config.MaxWeight);
        }
    }
}