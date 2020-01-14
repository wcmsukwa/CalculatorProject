using System;
using BasicCalculator;

namespace StatisticsCalculator
{
    public class StatisticsCalculator :Calculator
    {
        public dynamic Mean(dynamic values)
        {
            result = StatsOperations.StatsOperations.Mean(values);
            return result;
        }

        public dynamic StandardDeviation(dynamic values)
        {
            result = StatsOperations.StatsOperations.StandardDeviation(values);
            return result;
        }

        public dynamic ZSquare(dynamic dataPoint,dynamic values)
        {
            result = StatsOperations.StatsOperations.ZSquare(dataPoint, values);
            return result;
        }

        public dynamic ZSquare(dynamic dataPoint, dynamic mean, dynamic standardDeviation)
        {
            result = StatsOperations.StatsOperations.ZSquare(dataPoint, mean, standardDeviation);
            return result;
        }
    }
}
