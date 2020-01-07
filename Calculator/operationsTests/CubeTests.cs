using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
  

    [TestClass()]
    public class CubeTests
    {
        private  int intA ;
        private  double doubleA ;

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
            Assert.AreEqual(12167, Cube.Cubed(doubleA));
        }
    }
}