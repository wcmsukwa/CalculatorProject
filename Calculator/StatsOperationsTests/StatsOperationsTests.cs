using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations.Tests
{
    [TestClass()]
    public class StatsOperationsTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            double[] a = { 10.45, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual( 15.31,StatsOperations.Mean(a));
        }

        [TestMethod()]
        public void MedianTest()
        {
            double[] a = { 10.45, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual(3, StatsOperations.Median(a));
        }

        [TestMethod()]
        public void StandardDeviationTest()
        {
            double[] a = { 10.45, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual(4.51, StatsOperations.StandardDeviation(a));
        }

        [TestMethod()]
        public void ZSquareTest()
        {
            double[] a = { 10.45, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual(1.15, StatsOperations.ZSquare(20.5,a));
        }


        [TestMethod()]
        public void ModeTest()
        {
            double[] a = { 15.50, 20.5, 10, 20.1, 15.5 };
            Assert.AreEqual(15.5, StatsOperations.Mode(a));
        }
    }
}