using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
  

    [TestClass()]
    public class SquareTests
    {
        private  int intA;
        private  double doubleA;

        [TestInitialize]
        public void SetUp()
        {
            Randomizer rand = new Randomizer();
            // common Arrange
            doubleA = rand.getDouble();
            intA = rand.getInt();
        }

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(36, Square.Squared(intA));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(529, Square.Squared(doubleA));
        }
    }
}