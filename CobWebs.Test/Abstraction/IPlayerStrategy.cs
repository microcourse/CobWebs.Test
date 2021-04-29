using CobWebs.Test.Domain;

namespace CobWebs.Test.Abstraction
{
    public interface IPlayerStrategy 
    {
        int GetAnswer(BasketGameContext spec);
    }
}