using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public class Rounding
    {
        public static double RoundToTwoDecimalPlaces(double value,int numberOfDecimalPlaces=2)
        {
            return Math.Round(value, numberOfDecimalPlaces, MidpointRounding.ToEven);
        }
    }
}
