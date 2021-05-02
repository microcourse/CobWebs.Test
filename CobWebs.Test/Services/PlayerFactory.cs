using System;
using CobWebs.Test.Domain;
using CobWebs.Test.Domain.Strategy;

namespace CobWebs.Test.Abstraction
{
    public class PlayerFactory: IPlayerFactory
    {
       public IPlayer Create(
           string playerName, 
           PlayerStrategyType strategyType, 
           BasketGameConfig config)
        {
            IPlayerStrategy strategy;

            switch (strategyType)
            {
                case PlayerStrategyType.Random:
                    strategy = new RandomPlayerStrategy(config);
                    break;

                case PlayerStrategyType.Memory:
                    strategy = new RandomMemoryPlayerStrategy(config);
                    break;

                case PlayerStrategyType.Thorough:
                    strategy = new ThoroughPlayerStrategy(config);
                    break;

                case PlayerStrategyType.Cheater:
                    strategy = new CheaterPlayerStrategy(config);
                    break;

                case PlayerStrategyType.ThoroughCheater:
                    strategy = new ThoroughCheaterPlayerStrategy(config);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(strategyType), strategyType, null);
            }

            return new BasketGamePlayer(strategy, playerName);
        }
    }
}