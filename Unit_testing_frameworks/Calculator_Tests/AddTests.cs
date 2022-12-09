using System;
using CSharpCalculator;

namespace Calculator_Tests
{
    [TestClass]
    public class AddTests
	{
        [DataTestMethod]
        [DataRow(4, 5, 9)]
        [DataRow(0.8, 100, 100.8)]
        [DataRow(-8, 8, 0)]
        public void AddValidResultDataRowTest(double inputA, double inputB, double expectedRes)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Assert
            var actualRes = calc.Add(inputA, inputB);
            Assert.AreEqual(expectedRes, actualRes);
        }
    }
}

