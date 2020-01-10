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
        private readonly int k = 225;
        private readonly double l = 57.76;
        private readonly int m = 0;

        private readonly Calculator calc = new Calculator();

        [TestMethod()]
        public void SumIntTest()
        {
            Assert.AreEqual(18, calc.Sum(a, b));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(40, calc.Sum(f));
        }

        [TestMethod()]
        public void DifferenceIntTest()
        {
            Assert.AreEqual(12, calc.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceIntArrayTest()
        {
            Assert.AreEqual(-40, calc.Difference(f));
        }

        [TestMethod()]
        public void TimesIntTest()
        {
            Assert.AreEqual(45, calc.Times(a, b));
        }

        [TestMethod()]
        public void TimesIntArrayTest()
        {
            Assert.AreEqual(900, calc.Times(f));
        }

        [TestMethod()]
        public void QuotientIntTest()
        {
            Assert.AreEqual(5, calc.Quotient(a, b));
        }

        [TestMethod()]
        public void QuotientIntArrayTest()
        {
            Assert.AreEqual(1, calc.Quotient(h));
        }

        [TestMethod()]
        public void SquaredIntTest()
        {
            int y = a * a;
            int z = calc.Squared(a);
            Assert.AreEqual(y, z);
        }

        [TestMethod()]
        public void CubedIntTest()
        {
            int y = a * a * a;
            int z = calc.Cubed(a);
            Assert.AreEqual(y, z);
        }

        [TestMethod()]
        public void RootIntTest()
        {
            Assert.AreEqual(15, calc.Root(k));
        }

        [TestMethod()]
        public void SquaredIntArrayTest()
        {
            int[] x = new int[f.Length];
            int[] y = calc.Squared(f);
            int i = 0;
            foreach (int a in f)
            {
                x[i] = calc.Squared(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void CubedIntArrayTest()
        {
            int[] x = new int[f.Length];
            int[] y = calc.Cubed(f);
            int i = 0;
            foreach (int a in f)
            {
                x[i] = calc.Cubed(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void RootIntArrayTest()
        {
            double[] x = new double[f.Length];
            double[] y = calc.Root(f);
            int i = 0;
            foreach (int a in f)
            {
                x[i] = calc.Root(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        //Doubles
        [TestMethod()]
        public void SumDoublesTest()
        {
            Assert.AreEqual(10.9, calc.Sum(c, d));
        }

        [TestMethod()]
        public void SumDoublesArrayTest()
        {
            Assert.AreEqual(10.2, calc.Sum(e));
        }

        [TestMethod()]
        public void DifferenceDoublesTest()
        {
            Assert.AreEqual(4.1, calc.Difference(c, d));
        }

        [TestMethod()]
        public void DifferenceDoublesArrayTest()
        {
            Assert.AreEqual(-10.2, calc.Difference(e));
        }

        [TestMethod()]
        public void TimesDoublesTest()
        {
            Assert.AreEqual(25.5, calc.Times(c, d));
        }

        [TestMethod()]
        public void TimesDoublesArrayTest()
        {
            Assert.AreEqual(23.25, calc.Times(e));
        }

        [TestMethod()]
        public void QuotientDoublesTest()
        {
            Assert.AreEqual(2, calc.Quotient(i, j));
        }

        [TestMethod()]
        public void QuotientDoublesArrayTest()
        {
            Assert.AreEqual(1.5, calc.Quotient(g));
        }

        [TestMethod()]
        public void SquaredDoublesTest()
        {
            double y = c * c;
            double z = calc.Squared(c);
            Assert.AreEqual(y, z);
        }

        [TestMethod()]
        public void CubedDoublesTest()
        {
            double y = c * c * c;
            double z = calc.Cubed(c);
            Assert.AreEqual(y, z);
        }

        [TestMethod()]
        public void RootDoublesTest()
        {
            Assert.AreEqual(7.6, calc.Root(l));
        }

        [TestMethod()]
        public void SquaredDoublesArrayTest()
        {
            double[] x = new double[e.Length];
            double[] y = calc.Squared(e);
            int i = 0;
            foreach (double a in e)
            {
                x[i] = calc.Squared(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void CubedDoublesArrayTest()
        {
            double[] x = new double[e.Length];
            double[] y = calc.Cubed(e);
            int i = 0;
            foreach (double a in e)
            {
                x[i] = calc.Cubed(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void RootDoublesArrayTest()
        {
            double[] x = new double[e.Length];
            double[] y = calc.Root(e);
            int i = 0;
            foreach (double a in e)
            {
                x[i] = calc.Root(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<System.DivideByZeroException>(() => calc.Quotient(a, m));
        }
    }
}