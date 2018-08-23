using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurnTrackerConsole;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole.Tests
{
    [TestClass()]
    public class CounterControllerTests
    {
        static int turnInt = 10;
        static int timeInt = 30;
        private readonly TurnCounter _turnCounter = new TurnCounter(){Count = turnInt, Name = "A"};
        private readonly TimeCounter _timeCounter = new TimeCounter(){Count = timeInt, Name = "B"};

        [TestMethod()]
        public void NextTurnTest()
        {
            var counters = new List<ICounter>
            {
                _turnCounter,
                _timeCounter
            };

            CounterController.NextTurn(counters);
            var first = counters.ElementAt(0);
            var second = counters.ElementAt(1);

            if (first.Count != turnInt - 1)
            {
                Assert.Fail();
            }

            if (second.Count != timeInt - 6)
            {
                Assert.Fail();
            }
        }
    }
}