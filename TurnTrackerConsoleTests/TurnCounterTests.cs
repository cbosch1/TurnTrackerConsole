using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurnTrackerConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole.Tests
{
    [TestClass()]
    public class TurnCounterTests
    {
        [TestMethod()]
        public void DecrementCounterTest()
        {
            var testTurn = new TurnCounter()
            {
                Count = 2
            };
            testTurn.DecrementCounter();
            if (testTurn.Count != 1)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void IncrementCounterTest()
        {
            var testTurn = new TurnCounter()
            {
                Count = 1
            };
            testTurn.IncrementCounter();
            if (testTurn.Count != 2)
            {
                Assert.Fail();
            }
        }
    }
}