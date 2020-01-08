namespace Square
{
    public interface ISquare
    {
        public dynamic Squared(dynamic a);
    }
    public class Squaring : ISquare
    {
        public dynamic Squared(dynamic a)
        {
            return operations.Square.Squared(a);
        }
    }
}
