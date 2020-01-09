using System;
using BasicCalculator;
using StatOperations;

namespace StatisticsCalculator
{
    public class StatCalculator : Calculator
    {
        public dynamic Mean(dynamic values)
        {
            return StatOperations.StatMean.Mean(values);
        }

    }
}
