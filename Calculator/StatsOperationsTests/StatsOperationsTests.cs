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
    }
}