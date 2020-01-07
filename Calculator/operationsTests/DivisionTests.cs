using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private  int intA;
        private  int intB;
        private  double doubleA ;
        private  double doubleB;
        private  double doubleC;

        [TestInitialize]
        public void SetUp()
        {
            Randomizer rand = new Randomizer();
            // common Arrange
            doubleA = rand.getDouble();
            doubleB = rand.getDouble();
            doubleC = 0;
            intA = rand.getInt();
            intB = rand.getInt();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(0, Division.Quotient(intA, intB));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(1.0952380952380953, Division.Quotient(doubleA, doubleB));
        }

        [TestMethod()]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>( () => Division.Quotient(doubleA, doubleC));
        }



    }
}