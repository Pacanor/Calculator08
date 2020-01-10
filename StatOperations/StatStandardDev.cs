using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatOperations
{
    public class StatStandardDev
    {
        public static double StandDev(dynamic values)
        {
            double standDev;
            double variance = StatVariance.Variance(values);
            standDev = SqRt.Root(variance);
            
            return standDev;
        }
    }
}
