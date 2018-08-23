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

        public static ICounter TurnCounter(int count, string name)
        {
            var turnCounter = new TurnCounter()
            {
                Count = count,
                Name = name
            };
            return turnCounter;
        }

        public static ICounter TimeCounter(int count, string name)
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
