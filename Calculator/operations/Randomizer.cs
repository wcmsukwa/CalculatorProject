using System;

namespace operations
{
    public class Randomizer
    {
        private readonly Random rand = new Random(5);
        public int getInt()
        {
            return rand.Next(1, 20);
        }

        public int getDouble()
        {
            return (rand.Next(111, 499) / 10);
        }


        public int[] getIntArray()
        {
            int[] a = new int[8];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(30, 50);
            }

            return a;
        }

        public double[] getDoubleArray()
        {
            Double[] a = new double[8];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (rand.Next(500, 999) / 10);
            }

            return a;
        }

    }
}
