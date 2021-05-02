using System;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain.Strategy
{
    public abstract class PlayerStrategyBase : IPlayerStrategy
    {
        protected readonly BasketGameConfig _config;

        protected PlayerStrategyBase(BasketGameConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public int GetAnswer(BasketGameContext spec)
        {
            return this.OnGetAnswer(spec);
        }

        protected abstract int OnGetAnswer(BasketGameContext spec);
    }
}