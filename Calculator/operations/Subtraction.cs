namespace operations
{
    public static class Subtraction
    {
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static double Subtract(double a, double b)
        {
            var c = a - b;
            return Helpers.Rounding.RoundToTwoDecimalPlaces(c);
        }

    }
}
