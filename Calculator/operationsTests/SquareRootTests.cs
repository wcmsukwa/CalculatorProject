using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{

    
    [TestClass()]
    public class SquareRootTests
    {
        private  double doubleA;
        private  int intA ;

        [TestInitialize]
        public void SetUp()
        {
            Randomizer rand = new Randomizer();
            // common Arrange
            doubleA = rand.getDouble();
            intA = rand.getInt();
        }

        [TestMethod()]
        public void SquarerootTest()
        {
            Assert.AreEqual(2.449489742783178, SquareRoot.Squareroot(intA));
        }

        [TestMethod()]
        public void SquarerootDoubleTest()
        {
            Assert.AreEqual(4.795831523312719, SquareRoot.Squareroot(doubleA));
        }
    }
}