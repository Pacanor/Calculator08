using System;

namespace StatVariance
{
    public class FindVariance
    {
        public static dynamic result;
        public double Variance(dynamic arrayA)
        {
            result = StatOperations.StatVariance.Variance(arrayA);
            return result;
        }
    }
}
