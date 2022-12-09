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
            calc.Sqrt(param);

            // Assert
            double actual = calc.Sqrt(param);
            Assert.AreEqual(expectedRes, actual);
        }
    }
}

