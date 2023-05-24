﻿using System;
using CSharpCalculator;

namespace Calculator_Tests
{
    [TestClass]
    public class IsNegativeTests
	{
        [TestMethod]
        public void IsNegativeValidResult()
        {
            // Arrange
            double param = 20;
            Calculator calc = new Calculator();

            // Assert
            Assert.IsFalse(calc.isNegative(param));
        }

        [TestMethod]
        public void IsNegativeValidResult2()
        {
            // Arrange
            double param = -20;
            Calculator calc = new Calculator();

            // Assert
            Assert.IsTrue(calc.isNegative(param));
        }
    }
}
