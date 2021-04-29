using System;
using CobWebs.Test.Domain;
using CobWebs.Test.Domain.Strategy;

namespace CobWebs.Test.Abstraction
{
    public class PlayerFactory: IPlayerFactory
    {
       public IPlayer Create(string playerName, PlayerStrategyType strategyType, BasketGameConfig config)
        {
            switch (strategyType)
            {
                case PlayerStrategyType.Random:
                    return new BasketGamePlayer(new RandomPlayerStrategy(config), playerName);

                case PlayerStrategyType.Memory:
                    return new BasketGamePlayer(new MemoryPlayerStrategy(config), playerName);

                case PlayerStrategyType.Thorough:
                    return new BasketGamePlayer(new ThoroughPlayerStrategy(config), playerName);

                case PlayerStrategyType.Cheater:
                    return new BasketGamePlayer(new CheaterPlayerStrategy(config), playerName);

                case PlayerStrategyType.ThoroughCheater:
                    return new BasketGamePlayer(new ThoroughCheaterPlayerStrategy(config), playerName);

                default:
                    throw new ArgumentOutOfRangeException(nameof(strategyType), strategyType, null);
            }
        }
    }
}