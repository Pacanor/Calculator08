using Operations;

namespace Cube
{
    public class Cubes : ICubes
    {
        public dynamic result;

        public dynamic Cubed(dynamic a)
        {
            result = Cb.Cubed(a);
            return result;
        }
    }
}