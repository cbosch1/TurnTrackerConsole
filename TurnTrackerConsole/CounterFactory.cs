using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole
{
    public static class CounterFactory
    {
        /* Creates Counter objects based on User-Input */

        public static ICounter Counter(bool type, int count, string name)
        {
            if (type)
            {
                var turnCounter = new TurnCounter()
                {
                    Count = count,
                    Name = name
                };
                return turnCounter;
            }
            else
            {
                var timeCounter = new TimeCounter()
                {
                    Count = count,
                    Name = name
                };
                return timeCounter;
            }
        }
    }
}
