using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 15;
        private readonly int b = 3;
        private readonly double c = 7.5;
        private readonly double d = 3.4;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };
        private readonly double[] g = { 23.25, 2.5, 6.2 };
        private readonly int[] h = { 30, 3, 2, 5 };
        private readonly double i = 6.8;
        private readonly double j = 3.4;

        private readonly Calculator calc = new Calculator();

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(18, calc.Sum(a, b));
            Assert.AreEqual(10.9, calc.Sum(c, d));
        }

        [TestMethod()]
        public void SumArrayTest()
        {
            Assert.AreEqual(10.2, calc.Sum(e));
            Assert.AreEqual(40, calc.Sum(f));
        }

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(12, calc.Difference(a, b));
            Assert.AreEqual(4.1, calc.Difference(c, d));
        }

        [TestMethod()]
        public void DifferenceArrayTest()
        {
            Assert.AreEqual(-10.2, calc.Difference(e));
            Assert.AreEqual(-40, calc.Difference(f));
        }

        [TestMethod()]
        public void TimesTest()
        {
            Assert.AreEqual(45, calc.Times(a, b));
            Assert.AreEqual(25.5, calc.Times(c, d));
        }

        [TestMethod()]
        public void TimesArrayTest()
        {
            Assert.AreEqual(23.25, calc.Times(e));
            Assert.AreEqual(900, calc.Times(f));
        }

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(5, calc.Quotient(a, b));
            Assert.AreEqual(2, calc.Quotient(i, j));
        }

        [TestMethod()]
        public void QuotientTest1()
        {
            Assert.AreEqual(1.5, calc.Quotient(g));
            Assert.AreEqual(1, calc.Quotient(h));
        }

        [TestMethod()]
        public void SquaredTest()
        {
            /*
            int[] x = new int[f.Length];
            int[] y = Sq.Squared(f);
            int i = 0;
            foreach (int a in f)
            {
                x[i] = Sq.Squared(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
            */
            int y = a * a;
            int z = calc.Squared(a);
            Assert.AreEqual(y, z);
            //Assert.AreEqual(57.76, calc.Squared(c));
        }

        /*
                [TestMethod()]
                public void RootTest()
                {
                    Assert.Fail();
                }

                [TestMethod()]
                public void CubedTest()
                {
                    Assert.Fail();
                }
        */
    }
}