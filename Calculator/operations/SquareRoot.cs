using System;

namespace operations
{
    public static class SquareRoot
    {
        public static double Squareroot(double a)
        {
            var c = Math.Sqrt(a);
            return Helpers.Rounding.RoundToTwoDecimalPlaces(c);
        }


    }
}
