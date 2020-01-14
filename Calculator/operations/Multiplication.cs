namespace operations
{
    public static  class Multiplication
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            var c = a * b;
            return Helpers.Rounding.RoundToTwoDecimalPlaces(c);
        }


    }
}
