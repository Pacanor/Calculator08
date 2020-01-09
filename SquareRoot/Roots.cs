using Operations;

namespace SquareRoot
{
    public class Roots : IRoots
    {
        public dynamic result;

        public dynamic Root(dynamic a)
        {
            result = SqRt.Root(a);
            return result;
        }
    }
}