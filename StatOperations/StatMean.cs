using Operations;

namespace StatOperations
{
    public class StatMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Sum(values);
            var valueCount = Helpers.Array.Length(values);
            var mean = Division.Quotient(sum, valueCount);
            return mean;
        }
    }
}