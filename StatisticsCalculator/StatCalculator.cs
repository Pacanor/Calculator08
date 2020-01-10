using BasicCalculator;
using StatMean;
using StatStandardDev;
using StatVariance;

namespace StatisticsCalculator
{
    public class StatCalculator : Calculator, IFindMean, IFindStandDev, IFindVariance
    {
        private readonly FindMean mean = new FindMean();
        private readonly FindStandDev standDev = new FindStandDev();
        private readonly FindVariance var = new FindVariance();

        public dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }

        public double StandDev(dynamic values)
        {
            return standDev.StandDev(values);
        }

        public double Variance(dynamic values)
        {
            return var.Variance(values);
        }
    }
}