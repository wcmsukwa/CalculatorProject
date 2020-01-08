namespace Cube
{
    public interface ICube
    {
        public dynamic Cubed(dynamic a);
    }
    public class Cubing
    {
        public dynamic Cubed(dynamic a)
        {
            return operations.Cube.Cubed(a);
        }
    }
}
