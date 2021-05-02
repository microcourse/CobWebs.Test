using System.Collections.Generic;

namespace CobWebs.Test.Domain
{
    public class BasketGameContext
    {
        public IReadOnlyCollection<int> History { get; private set; }

        public BasketGameContext(IEnumerable<int> history)
        {
            History = new HashSet<int>(history);
        }
    }
}