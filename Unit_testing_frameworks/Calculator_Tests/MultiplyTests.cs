﻿using System;
using CSharpCalculator;

namespace Calculator_Tests
{
	[TestClass]
	public class MultiplyTests
	{
        [TestMethod]
        public void MultiplyNegativeTestInfinity()
        {
            // Arrange
            double paramA = double.MaxValue;
            double paramB = double.MaxValue;
            double expectedRes = double.PositiveInfinity;
            Calculator calc = new Calculator();

            // Act
            double actual = calc.Pow(paramA, paramB);

            // Assert
            Assert.AreEqual(expectedRes, actual);
        }

        [DataTestMethod]
        [DataRow(400, 5, 2000)]
        [DataRow(0.8, 100, 80)]
        [DataRow(-8, 8, -64)]
        public void MultiplyDataRowTest(double inputA, double inputB, double expectedRes)
        {
            // Arrange
            Calculator calc = new Calculator();

            //Act
            var actualRes = calc.Multiply(inputA, inputB);

            // Assert
            Assert.AreEqual(expectedRes, actualRes);
        }
    }
}

