using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{


    [TestClass()]
    public class SquareRootTests
    {
        private double doubleA;
        private int intA;

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
            Assert.AreEqual(4.898979485566356, SquareRoot.Squareroot(doubleA));
        }
    }
}