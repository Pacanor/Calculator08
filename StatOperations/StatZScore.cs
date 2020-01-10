using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatOperations
{
    public class StatZScore
    {
        public static double ZScore(dynamic score, dynamic values)
        {
            double mean = StatMean.Mean(values);
            double standDev = StatStandardDev.StandDev(values);
            double zScore = Division.Quotient(Subtraction.Difference(score, mean), standDev);
            return zScore;
        }
    }
}
