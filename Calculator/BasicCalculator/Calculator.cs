using System;
using operations;

namespace BasicCalculator
{
    public class Calculator
    {
        public int result;

        public int Add( int  a, int b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public int Divide(int a, int b)
        {
            result = Division.Quotient(a, b);
            return result;
        }
    }
}
