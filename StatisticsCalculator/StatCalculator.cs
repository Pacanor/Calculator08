using BasicCalculator;
using StatMean;
using StatStandardDev;
using StatVariance;
using StatZScore;

namespace StatisticsCalculator
{
    public class StatCalculator : Calculator, IFindMean, IFindStandDev, IFindVariance, IFindZScore
    {
        private readonly FindMean mean = new FindMean();
        private readonly FindStandDev standDev = new FindStandDev();
        private readonly FindVariance var = new FindVariance();
        private readonly FindZScore z = new FindZScore();

        public dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }

        public double Variance(dynamic values)
        {
            return var.Variance(values);
        }

        public double StandDev(dynamic values)
        {
            return standDev.StandDev(values);
        }

        public double ZScore(dynamic score, dynamic values)
        {
            return z.ZScore(score, values);
        }
    }
}