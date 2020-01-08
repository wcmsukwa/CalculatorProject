using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private int intA = 10;
        private int intB = 20;
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
        public void SubtractTest()
        {
            Assert.AreEqual(-7, Subtraction.Subtract(intA, intB));
        }

        [TestMethod()]
        public void SubtractDoubleTest()
        {
            Assert.AreEqual(2, Subtraction.Subtract(doubleA, doubleB));
        }
    }
}