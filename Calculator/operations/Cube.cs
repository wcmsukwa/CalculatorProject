namespace operations
{
    public static class Cube
    {
        public static int Cubed(int a)
        {
            
            return a * a * a;
        }

        public static double Cubed(double a)
        {
            var c = a * a * a;
            return Helpers.Rounding.RoundToTwoDecimalPlaces(c);
        }

    }
}
