namespace operations
{
    public static class Division
    {
       

        public static double Quotient(double a, double b)
        {
            var c = a / b;
            return Helpers.Rounding.RoundToTwoDecimalPlaces(c);
        }
    }
}
