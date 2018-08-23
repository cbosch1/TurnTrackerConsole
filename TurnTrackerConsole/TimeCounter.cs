using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole
{
    public class TimeCounter : ICounter
    {   
        /*Counter type object that counts time. 
        Turn based modifications should be made to the degree of 6 seconds but
        you should be able to set minutes within the app.*/
    
        public string Name { get; set; }
        public int Count { get; set; }

        public void DecrementCounter()
        {
            this.Count -= 6;
        }

        public void IncrementCounter()
        {
            this.Count += 6;
        }
    }
}
