using Microsoft.VisualStudio.TestTools.UnitTesting;

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