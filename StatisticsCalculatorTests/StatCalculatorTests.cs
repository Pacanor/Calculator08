using Microsoft.VisualStudio.TestTools.UnitTesting;

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