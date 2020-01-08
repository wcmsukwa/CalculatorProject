using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{


    [TestClass()]
    public class CubeTests
    {
        private int intA;
        private double doubleA;

        [TestInitialize]
        public void SetUp()
        {
            Randomizer rand = new Randomizer();
            // common Arrange
            doubleA = rand.getDouble();
            intA = rand.getInt();
        }

        [TestMethod()]
        public void CubedTest()
        {


            Assert.AreEqual(216, Cube.Cubed(intA));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(13824, Cube.Cubed(doubleA));
        }
    }
}