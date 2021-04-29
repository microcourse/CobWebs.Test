using System.Diagnostics;

namespace CobWebs.Test.Abstraction
{
    public enum PlayerStrategyType
    {
        Random,
        Memory,
        Thorough,
        Cheater,
        ThoroughCheater
    }

    public interface IPlayerFactory
    {
        IPlayer Create(PlayerStrategyType strategyType);
    }
}