using System;
using CobWebs.Test.Abstraction;

namespace CobWebs.Test.Domain
{
    public class BasketGamePlayer: IPlayer
    {
        private readonly IPlayerStrategy _strategy;
        protected BasketGamePlayer(IPlayerStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public int GetAnswer(BasketGameContext spec)
        {
            return _strategy.GetAnswer(spec);
        }
    }
}