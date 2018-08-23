using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole
{
    public interface ICounter //Framework for a counter type object
    {
        string Name { get; set; }
        int Count { get; set; }

        void DecrementCounter();
        void IncrementCounter();
    }
}
