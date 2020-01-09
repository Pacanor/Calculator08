using System;
using BasicCalculator;
using Operations;

namespace StatOperations
{
    public class StatMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Sum(values);
            var valueCount = values.Length;
            return Division.Quotient(sum, valueCount);
        }
    }
}
