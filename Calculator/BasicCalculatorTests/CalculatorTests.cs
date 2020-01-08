using BasicCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace BasicCalculatorTests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 10;
        private readonly int b = 4;
        private readonly int c = 0;
        private readonly double d = 81.00;
        private readonly int[] intArray = { 1, 29, 30, 78, 4, 19, 23, 40, 58 };
        private readonly double[] doubleArray = { 105, 29.5, 30.9, 78.5, 4.1, 19.03, 23.1, 40, 58 };


        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(14, calculator.Add(a, b));
            Assert.AreEqual(14, calculator.result);

            Assert.AreEqual(282, calculator.Add(intArray));
            Assert.AreEqual(282, calculator.result);

            Assert.AreEqual(388.13, calculator.Add(doubleArray));
            Assert.AreEqual(388.13, calculator.result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(6, calculator.Subtract(a, b));
            Assert.AreEqual(6, calculator.result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(40, calculator.Multiply(a, b));
            Assert.AreEqual(40, calculator.result);
        }

        [TestMethod()]
        public void CubedTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(1000, calculator.Cubed(a));
            Assert.AreEqual(1000, calculator.result);
        }


        [TestMethod()]
        public void SquaredTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(16, calculator.Squared(b));
            Assert.AreEqual(16, calculator.result);
        }


        [TestMethod()]
        public void SquareRootTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(9, calculator.Squareroot(d));
            Assert.AreEqual(9, calculator.result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(2, calculator.Divide(a, b));
            Assert.AreEqual(2, calculator.result);
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(a, c));
        }
    }
}