namespace BasicCalculator
{
    public interface ICalculator
    {
        public dynamic Sum(dynamic a, dynamic b);

        public dynamic Sum(dynamic a);

        public dynamic Difference(dynamic a, dynamic b);

        public dynamic Difference(dynamic a);

        public dynamic Times(dynamic a, dynamic b);

        public dynamic Times(dynamic a);

        public dynamic Quotient(dynamic a, dynamic b);

        public dynamic Quotient(dynamic a);

        public dynamic Squared(dynamic a);

        public dynamic Root(dynamic a);

        public dynamic Cubed(dynamic a);
    }
}