using Operations;

namespace StatOperations
{
    public class StatVariance
    {
        public static double Variance(dynamic values)
        {
            double mean = StatMean.Mean(values);
            double[] squaredDeviation = new double[Helpers.Array.Length(values)]; ;
            int i = 0;

            foreach (int a in values)
            {
                squaredDeviation[i] = Sq.Squared(Subtraction.Difference(a, mean));
                i++;
            }
            double variance = StatMean.Mean(squaredDeviation);
            return variance;
        }
    }
}