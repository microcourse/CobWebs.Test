using System;
using CobWebs.Test.Domain;

namespace CobWebs.Test.Abstraction
{
    public class PlayerFactory: IPlayerFactory
    {
       public IPlayer Create(
           string playerName, 
           PlayerStrategyType strategyType, 
           BasketGameConfig config)
        {
            throw new NotImplementedException();


            switch (strategyType)
            {
                case PlayerStrategyType.Random:
                    break;
                case PlayerStrategyType.Memory:
                    break;
                case PlayerStrategyType.Thorough:
                    break;
                case PlayerStrategyType.Cheater:
                    break;
                case PlayerStrategyType.ThoroughCheater:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(strategyType), strategyType, null);
            }
        }
    }
}