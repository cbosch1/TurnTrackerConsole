using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole
{
    public class TurnCounter : ICounter
    {
        /*Turn based counter object, fairly straight forward.
         Should count numerically in increments of one.
         Turns should remove one from the counter*/

        public string Name { get; set; }
        public int Count { get; set; }

        public void DecrementCounter()
        {
            --this.Count;
        }

        public void IncrementCounter()
        {
            ++this.Count;
        }
    }
}
