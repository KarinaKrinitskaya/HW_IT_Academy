using System;
using CSharpCalculator;

namespace Calculator_Tests
{
    [TestClass]
    public class PowTests
	{
        [DataTestMethod]
        [DataRow(20, 2, 400)]
        [DataRow(20,-2, 0.0025)]
        public void PowValidResultDataRowTest(int inputA, double inputB, double expectedRes)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Assert
            var actualRes = calc.Pow(inputA, inputB);
            Assert.AreEqual(expectedRes, actualRes);
        }
    }
}

