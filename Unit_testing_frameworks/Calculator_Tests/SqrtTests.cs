using System;
using CSharpCalculator;

namespace Calculator_Tests
{
	[TestClass]
	public class SqrtTests
	{
        [TestMethod]
        public void SqrtNegativeNumber()
        {
            // Arrange
            double param = -100;
            double expectedRes = double.NaN;
            Calculator calc = new Calculator();

            // Act
            double actual = calc.Sqrt(param);

            // Assert
            Assert.AreEqual(expectedRes, actual);
        }
    }
}

