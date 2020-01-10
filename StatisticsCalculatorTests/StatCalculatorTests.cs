using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatCalculatorTests
    {
        private readonly StatCalculator statCalc = new StatCalculator();
        private readonly int[] values = { 1, 2, 3, 4, 5 };

        [TestMethod()]
        public void MeanTest()
        {
            
            var mean = statCalc.Mean(values);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void StandDevTest()
        {
            var standDev = statCalc.StandDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundFiveDecimals(standDev));
        }
    }
}