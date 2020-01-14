using System;
using BasicCalculator;
namespace StatsOperations
{
    public class StatsOperations
    {
        
        public static dynamic Mean(dynamic values)
        {
            Calculator basicCalculator = new Calculator();
            var sum = basicCalculator.Add(values);
            var valueCount = Helpers.Array.Length(values);
            var result = basicCalculator.Divide(sum, valueCount);
            return result;
        }

        public static dynamic StandardDeviation(dynamic values)
        {
            Calculator basicCalculator = new Calculator();
            //number of data points
            int numberOfDataPoints = Helpers.Array.Length(values);
            double[] dataPointsArray = new double[numberOfDataPoints];
            //step 1 - find the mean
            var mean = Mean( values );
            //step 2 - For each data point, find the square of its distance to the mean
            foreach ( dynamic dataPoint in values)
            {
                var distanceToMean = mean - dataPoint;
                var squareDistanceToMean = basicCalculator.Squared(distanceToMean);
                dataPointsArray[--numberOfDataPoints] = squareDistanceToMean;
            }
            //Step 3 - Sum the values from Step 2
            //Step 4 - Divide by the number of data points.
            var resultOfStep3and4 = Mean(dataPointsArray);
            //Step 5 - Take the square root.
            var result = basicCalculator.Squareroot(resultOfStep3and4);
            return result;
        }

        public static dynamic ZSquare(dynamic dataPoint,dynamic values)
        {
           
            var mean = Mean(values);
            var standardDeviation = StandardDeviation(values);

            var result = ZSquare(dataPoint, mean, standardDeviation);
            return result;
        }

        public static dynamic ZSquare(dynamic dataPoint, dynamic mean,dynamic standardDeviation)
        {
            Calculator basicCalculator = new Calculator();
            var difference = basicCalculator.Subtract(dataPoint,mean);
            var result = basicCalculator.Divide(difference, standardDeviation);
            return result;
        }
    }
}
