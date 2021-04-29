using CobWebs.Test.Domain;

namespace CobWebs.Test.Abstraction
{
    public interface IPlayerStrategyFactory
    {
        IPlayerStrategy Create();
    }
}