using operations;
namespace Multiply
{

    public interface IMultiply
    {
        public dynamic Multiply(dynamic a, dynamic b);
    }
    public class Multiplying : IMultiply
    {
        public dynamic Multiply(dynamic a, dynamic b)
        {
            return Multiplication.Multiply(a, b);
        }
    }
}
