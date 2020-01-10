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
            double step1 = StatMean.Mean(values);
            double[] step2 = new double[Helpers.Array.Length(values)]; ;
            int i = 0;
            
            foreach(int a in values)
            {
                step2[i] = Sq.Squared(Subtraction.Difference(a, step1));
                i++;
            }
            double step3 = Addition.Sum(step2);
            double step4 = Division.Quotient(step3, Helpers.Array.Length(values));
            standDev = SqRt.Root(step4);
            
            return standDev;
        }
    }
}
