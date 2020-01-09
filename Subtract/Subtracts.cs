using Operations;

namespace Subtract
{
    public class Subtracts : ISubtracts
    {
        public dynamic result;

        public dynamic Difference(dynamic a, dynamic b)
        {
            result = Subtraction.Difference(a, b);
            return result;
        }

        public dynamic Difference(dynamic a)
        {
            result = Subtraction.Difference(a);
            return result;
        }
    }
}