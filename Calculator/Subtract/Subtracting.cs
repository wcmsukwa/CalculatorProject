using operations;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Subtract(dynamic a, dynamic b);
    }
    public class Subtracting
    {
        public dynamic Subtract(dynamic a, dynamic b)
        {
            return Subtraction.Subtract(a, b);
        }
    }
}
