using System;
using System.Linq;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{
    public class CheaterPlayerStrategy : RandomPlayerStrategy
    {
        public CheaterPlayerStrategy(BasketGameConfig config) : base(config)
        {
        }

        protected override int OnGetAnswer(BasketPlayerContext spec)
        {
            int weight;

            do
            {
                weight = base.OnGetAnswer(spec);
            }
            while (spec.History.Contains(weight));

            return weight;
        }
    }
}