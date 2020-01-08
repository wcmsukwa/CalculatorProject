using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{


    [TestClass()]
    public class MultiplicationTests
    {
        private int intA;
        private int intB;
        private double doubleA;
        private double doubleB;

        [TestInitialize]
        public void SetUp()
        {
            Randomizer rand = new Randomizer();
            // common Arrange
            doubleA = rand.getDouble();
            doubleB = rand.getDouble();
            intA = rand.getInt();
            intB = rand.getInt();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(60, Multiplication.Multiply(intA, intB));
        }

        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(528, Multiplication.Multiply(doubleA, doubleB));
        }
    }
}