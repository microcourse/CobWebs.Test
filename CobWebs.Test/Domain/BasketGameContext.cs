using System.Collections.Generic;

namespace CobWebs.Test.Domain
{
    public class BasketGameContext
    {
        public int BasketWeight { get; private set; }
        public ICollection<int> WeightHistory { get; set; }
    }
}