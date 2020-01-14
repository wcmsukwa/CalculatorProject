namespace operations
{
    public static class Square
    {
        public static int Squared(int a)
        {
            return a * a;
        }

        public static double Squared(double a)
        {
            var c = a * a;
            return Helpers.Rounding.RoundToTwoDecimalPlaces(c);
        }

    }
}
