using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole
{
    public static class CounterController
    {
        /* Modifies Counter values as well as alerts.
         Also governs the Turn action that knows if a count reaches 0 */

        public static void NextTurn(List<ICounter> counters)
        {
            foreach (ICounter currentCounter in counters.ToList())
            {
                if (currentCounter.GetType() == typeof(TurnCounter))
                {
                    currentCounter.Count -= 1;
                }
                else if (currentCounter.GetType() == typeof(TimeCounter))
                {
                    currentCounter.Count -= 6;
                }
                else
                {
                    throw new Exception("List contains unknown object");
                }

                if (currentCounter.Count <= 0)
                {
                    counters.Remove(currentCounter);
                }
            }
        }
    }
}
