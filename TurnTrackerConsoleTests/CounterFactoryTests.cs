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
        public void CounterTest()
        {
            var turnCounter = CounterFactory.Counter(true, 1, "A");

            Assert.IsInstanceOfType(turnCounter, typeof(TurnCounter));
            Assert.IsTrue(turnCounter.Count == 1);
            Assert.IsTrue(turnCounter.Name == "A");

            var timeCounter = CounterFactory.Counter(false, 1, "A");

            Assert.IsInstanceOfType(timeCounter, typeof(TimeCounter));
            Assert.IsTrue(timeCounter.Count == 1);
            Assert.IsTrue(timeCounter.Name == "A");
        }
    }
}