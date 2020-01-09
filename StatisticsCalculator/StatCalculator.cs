using System;
using BasicCalculator;
using StatMean;
using StatOperations;

namespace StatisticsCalculator
{
    public class StatCalculator : Calculator, IFindMean
    {
        private readonly FindMean mean = new FindMean();
        public dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }

    }
}
