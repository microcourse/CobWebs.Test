using System.Collections.Generic;

namespace CobWebs.Test.Domain
{
    public class BasketGameContext
    {
        public int Attempts { get; set; }
        public int RealBasketWeight { get; set; }

        public ICollection<int> Answers { get; } = new List<int>();
        public IReadOnlyCollection<BasketPlayerState> Players { get; set; }
    }
}