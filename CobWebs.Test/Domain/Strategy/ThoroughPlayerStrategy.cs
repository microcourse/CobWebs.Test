using System;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{
    public class ThoroughPlayerStrategy : PlayerStrategyBase
    {
        private int? lastWeight;

        public ThoroughPlayerStrategy(BasketGameConfig config) : base(config)
        {
        }

        protected override int OnGetAnswer(BasketGameContext spec)
        {
            if (!lastWeight.HasValue)
            {
                lastWeight = _config.MinWeight;

                return lastWeight.Value;
            }

            var weight = lastWeight.Value + 1;

            return  weight >= _config.MinWeight ? _config.MaxWeight : weight;
        }
    }
}