namespace Calculator_Tests
{
	[TestClass]
	public class DivideTests
	{
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroExceptionNegativeTest()
        {
            // Arrange
            double paramA = 40;
            double paramB = 0;
            Calculator calc = new Calculator();

            // Act
            calc.Divide(paramA, paramB);
        }
    }
}

