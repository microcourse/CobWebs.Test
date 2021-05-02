using System;
using System.Collections.Generic;
using System.Linq;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{

    public class RandomMemoryPlayerStrategy : RandomPlayerStrategy
    {
        private readonly HashSet<int> history = new HashSet<int>();
        public RandomMemoryPlayerStrategy(BasketGameConfig config) : base(config)
        {
        }

        protected override int OnGetAnswer(BasketGameContext spec)
        {
            int weight;

            do
            {
                weight = base.OnGetAnswer(spec);
            } 
            while (!history.Contains(weight));

            history.Add(weight);

            return weight;
        }
    }
}