using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;
namespace BasicCalculatorTests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 10;
        private readonly int b = 4;
        private readonly int c = 0;
        

        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(14, calculator.Add(a, b) );
            Assert.AreEqual(14, calculator.result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(2, calculator.Divide(a, b));
            Assert.AreEqual(2, calculator.result);
            Assert.ThrowsException<DivideByZeroException>( () => calculator.Divide(a, c) );
        }
    }
}