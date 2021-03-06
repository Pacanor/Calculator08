﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatZScoreTests
    {
        [TestMethod()]
        public void ZScoreIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int score = 4;
            var zScore = StatZScore.ZScore(score, values);
            Assert.AreEqual(0.70711, Helpers.Rounding.RoundFiveDecimals(zScore));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            double[] values = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double score = 2.2;
            var zScore = StatZScore.ZScore(score, values);
            Assert.AreEqual(-0.76089, Helpers.Rounding.RoundFiveDecimals(zScore));
        }
    }
}