using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatisticsCalculatorTests
    {
        StatisticsCalculator statsCal = new StatisticsCalculator();
        int[] values = { 1, 2, 5, 3, 9 };
        
        [TestMethod()]
        public void MeanTest()
        {
           
            var mean = statsCal.Mean(values);
            Assert.AreEqual(4,mean);
        }

        [TestMethod()]
        public void StandardDeviationTest()
        {
           
            var stdDeviation = statsCal.StandardDeviation(values);
            Assert.AreEqual(2.83, stdDeviation);
        }

        [TestMethod()]
        public void ZSquareTest()
        {   
           
            var zsquare = statsCal.ZSquare(9,values);
            Assert.AreEqual(1.77, zsquare);
        }

        [TestMethod()]
        public void ZSquare2Test()
        {
            
            var zsquare = statsCal.ZSquare(92,82,4.0);
            Assert.AreEqual(2.5, zsquare);
        }
    }
}