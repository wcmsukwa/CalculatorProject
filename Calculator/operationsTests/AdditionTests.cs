using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {

        private int a;
        private int b;
        private double c;
        private double d;
        private double[] arrayA;
        private int[] arrayB;

        [TestInitialize]
        public void SetUp()
        {
            Randomizer rand = new Randomizer();
            // common Arrange
            c = rand.getDouble();
            d = rand.getDouble();
            a = rand.getInt();
            b = rand.getInt();

            arrayA = rand.getDoubleArray();
            arrayB = rand.getIntArray();
        }

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(27, Addition.Sum(a, d));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(46, Addition.Sum(c, d));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(623, Addition.Sum(arrayA));
        }


        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(295, Addition.Sum(arrayB));
        }
    }
}

namespace operationsTests
{
    class AdditionTests
    {
    }
}
