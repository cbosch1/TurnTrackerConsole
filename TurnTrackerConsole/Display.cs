using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole
{
    public static class Display
    {
        /*Simplifies displaying current counters to avoid repeat code*/

        public static void Counters(List<ICounter> displayCounters)
        {
            string stringCounters = "Counters -> ";
            foreach (ICounter counter in displayCounters)
            {
                stringCounters += counter.Name + " : " + counter.Count + " -> ";
            }
            Console.WriteLine(stringCounters);
        }
    }
}
