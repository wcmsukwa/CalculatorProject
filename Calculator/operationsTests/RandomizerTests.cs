﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;

namespace operations.Tests
{
    [TestClass()]
    public class RandomizerTests
    {

        [TestMethod()]
        public void getIntTest()
        {
            Randomizer aa = new Randomizer();
            int a = aa.getInt();
            int b = aa.getInt();

            Assert.AreNotEqual(a, b);
        }

        [TestMethod()]
        public void getDoubleTest()
        {
            double a = (new Randomizer()).getDouble();
            double b = (new Randomizer()).getDouble();

            Assert.AreEqual(a, b);
        }
    }
}