using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatCalculatorTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatCalculator statCalc = new StatCalculator();
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = statCalc.Mean(values);
            Assert.AreEqual(3, mean);
        }
    }
}