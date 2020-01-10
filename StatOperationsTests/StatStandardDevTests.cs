using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatStandardDevTests
    {
        [TestMethod()]
        public void StandDevIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var standDev = StatStandardDev.StandDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundFiveDecimals(standDev));
        }
    }
}