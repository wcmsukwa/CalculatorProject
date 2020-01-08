using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private int intA;
        private int intB;
        private double doubleA;
        private double doubleB;
        private int intC;

        [TestInitialize]
        public void SetUp()
        {
            Randomizer rand = new Randomizer();
            // common Arrange
            doubleA = rand.getDouble();
            doubleB = rand.getDouble();
            intC = 0;
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
            Assert.AreEqual(1.0909090909090908, Division.Quotient(doubleA, doubleB));
        }

        [TestMethod()]
        public void DivideByZeroTest()
        {

            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(10, 0));
        }



    }
}