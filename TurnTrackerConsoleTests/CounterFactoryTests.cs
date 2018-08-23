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
    public class CounterFactoryTests
    {
        [TestMethod()]
        public void TurnCounterTest()
        {
            var turnCounter = new TurnCounter();
            var counter = CounterFactory.TurnCounter(1, "A");

            Assert.IsInstanceOfType(counter, typeof(TurnCounter));
            Assert.IsTrue(counter.Count == 1);
            Assert.IsTrue(counter.Name == "A");
        }

        [TestMethod()]
        public void TimeCounterTest()
        {
            var timeCounter = new TimeCounter();
            var counter = CounterFactory.TimeCounter(1, "A");

            Assert.IsInstanceOfType(counter, typeof(TimeCounter));
            Assert.IsTrue(counter.Count == 1);
            Assert.IsTrue(counter.Name == "A");
        }
    }
}