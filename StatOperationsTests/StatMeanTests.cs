using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatMeanTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = StatMean.Mean(values);
            Assert.AreEqual(3, mean);
        }
    }
}