using operations;
namespace Divide
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }
    public class Dividing
    {
        public dynamic Divide(dynamic a, dynamic b)
        {
            return Division.Quotient(a, b);
        }
    }
}
