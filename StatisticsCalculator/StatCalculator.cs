using BasicCalculator;
using StatMean;
using StatStandardDev;

namespace StatisticsCalculator
{
    public class StatCalculator : Calculator, IFindMean, IFindStandDev
    {
        private readonly FindMean mean = new FindMean();
        private readonly FindStandDev standDev = new FindStandDev();

        public dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }

        public double StandDev(dynamic values)
        {
            return standDev.StandDev(values);
        }
    }
}