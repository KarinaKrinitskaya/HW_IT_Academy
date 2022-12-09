using System;

namespace Calculator_Tests;

using System.Security.Principal;
using CSharpCalculator;

[TestClass]
public class AbsTests
{
    [TestMethod]
    public void AbsValidResult()
    {
        // Arrange
        double param = 123;
        double expectedRes = 123;
        Calculator calc = new Calculator();

        // Act
        calc.Abs(param);

        // Assert
        double actual = calc.Abs(param);
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
