using System;
using BasicCalculator;
using Helpers;
using Operations;

namespace StatOperations
{
    public class StatMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Sum(values);
            var valueCount = Helpers.Array.Length(values);
            return Division.Quotient(sum, valueCount);
        }
    }
}
