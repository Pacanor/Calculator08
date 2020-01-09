using System;

namespace Helpers
{
    public class Rounding
    {
        public static dynamic RoundTwoDecimals(dynamic a)
        {
            return Math.Round(a, 2, MidpointRounding.ToEven);
        }

        public static dynamic RoundFourDecimals(dynamic a)
        {
            return Math.Round(a, 4, MidpointRounding.ToEven);
        }

        public static dynamic RoundFiveDecimals(dynamic a)
        {
            return Math.Round(a, 5, MidpointRounding.ToEven);
        }
    }
}