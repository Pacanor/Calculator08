using Add;
using Cube;
using Divide;
using Multiply;
using Square;
using SquareRoot;
using Subtract;

namespace BasicCalculator
{
    public class Calculator : ISubtracts, IMultiplies, IDivides, ISquares, IRoots, ICubes, ICalculator, IAdds
    {
        private readonly Adds add = new Adds();
        private readonly Subtracts subtract = new Subtracts();
        private readonly Multiplies multiply = new Multiplies();
        private readonly Divides divide = new Divides();
        private readonly Squares square = new Squares();
        private readonly Roots root = new Roots();
        private readonly Cubes cube = new Cubes();

        private dynamic result;

        public dynamic Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        public dynamic Sum(dynamic a, dynamic b)
        {
            result = add.Sum(a, b);
            return result;
        }

        public dynamic Sum(dynamic a)
        {
            result = add.Sum(a);
            return result;
        }

        public dynamic Difference(dynamic a, dynamic b)
        {
            result = subtract.Difference(a, b);
            return result;
        }

        public dynamic Difference(dynamic a)
        {
            result = subtract.Difference(a);
            return result;
        }

        public dynamic Times(dynamic a, dynamic b)
        {
            result = multiply.Times(a, b);
            return result;
        }

        public dynamic Times(dynamic a)
        {
            result = multiply.Times(a);
            return result;
        }

        public dynamic Quotient(dynamic a, dynamic b)
        {
            result = divide.Quotient(a, b);
            return result;
        }

        public dynamic Quotient(dynamic a)
        {
            result = divide.Quotient(a);
            return result;
        }

        public dynamic Squared(dynamic a)
        {
            result = square.Squared(a);
            return result;
        }

        public dynamic Root(dynamic a)
        {
            result = root.Root(a);
            return result;
        }

        public dynamic Cubed(dynamic a)
        {
            result = cube.Cubed(a);
            return result;
        }
    }
}