using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatVarianceTests
    {
        [TestMethod()]
        public void VarianceIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var variance = StatVariance.Variance(values);
            Assert.AreEqual(2, Helpers.Rounding.RoundFiveDecimals(variance));
        }
    }
}