using operations;

namespace Add
{
    

    public class Adding : IAdd
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return Addition.Sum(a, b);
        }

        public dynamic Add(dynamic a)
        {
            return Addition.Sum(a);
        }
    }
}
