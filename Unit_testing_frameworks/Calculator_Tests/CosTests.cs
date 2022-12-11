using System;
using CSharpCalculator;

namespace Calculator_Tests
{
    [TestClass]
	public class CosTests
	{
        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void CosWrongInputMassage()
        {
            // Arrange
            string param = "90d";
            Calculator calc = new Calculator();

            // Act
            calc.Cos(param);
        }
    }
}

