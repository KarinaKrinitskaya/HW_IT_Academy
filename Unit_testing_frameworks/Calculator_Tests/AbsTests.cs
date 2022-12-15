namespace Calculator_Tests
{
    [TestClass]
    public class AbsTests
    {
        private Calculator calc;
        private double param;
        private double expectedRes;

        [TestInitialize]
        public void TestInitialize()
        {
            param = 123;
            expectedRes = 123;
            Calculator calc = new Calculator();
        }

        [TestMethod]
        public void AbsValidResult()
        {
            // Act
            var actual = calc.Abs(param);

            // Assert
            Assert.AreEqual(expectedRes, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void AbsThrowsException()
        {
            // Arrange
            object param = "ten";
            Calculator calc = new Calculator();

            // Act
            calc.Abs(param);
        }
    }
}
