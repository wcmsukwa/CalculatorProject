using System;

namespace operations
{
    public class Addition
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Sum(double[] arrayA)
        {
            double a = 0.0;
            foreach(double b in arrayA){
                a = Sum(a,b);
            }
            return a;
        }

        public static int Sum(int[] arrayA)
        {
            int a = 0;
            foreach (int b in arrayA)
            {
                a = Sum(a, b);
            }
            return a;
        }
    }
}
