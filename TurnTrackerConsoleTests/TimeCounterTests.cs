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
    public class TimeCounterTests
    {
        [TestMethod()]
        public void DecrementCounterTest()
        {
            var testTime = new TimeCounter()
            {
                Count = 7
            };

            testTime.DecrementCounter();
            if (testTime.Count != 1)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void IncrementCounterTest()
        {
            var testTime = new TimeCounter()
            {
                Count = 1
            };

            testTime.IncrementCounter();
            if (testTime.Count != 7)
            {
                Assert.Fail();
            }
        }
    }
}