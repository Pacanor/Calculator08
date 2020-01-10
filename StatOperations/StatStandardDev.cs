using Operations;

namespace StatOperations
{
    public class StatStandardDev
    {
        public static double StandDev(dynamic values)
        {
            double variance = StatVariance.Variance(values);
            double standDev = SqRt.Root(variance);

            return standDev;
        }
    }
}