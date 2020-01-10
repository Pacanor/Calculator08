namespace StatStandardDev
{
    public class FindStandDev : IFindStandDev
    {
        public static dynamic result;

        public double StandDev(dynamic arrayA)
        {
            result = StatOperations.StatStandardDev.StandDev(arrayA);
            return result;
        }
    }
}