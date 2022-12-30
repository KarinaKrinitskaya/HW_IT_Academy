using System;
using CSharpCalculator;

namespace CalculatorNUnit
{
    [TestFixture]
    [Parallelizable]
    public class DivideTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void DivideValidResTest()
        {
            double inputA = 9;
            double inputB = 3;
            double expRes = 3;

            double actualRes = calculator.Divide(inputA, inputB);

            Assert.That(actualRes, Is.EqualTo(expRes));
        }

        [Test]
        public void DivideValidResNegativeTest()
        {
            double inputA = 9;
            double inputB = Math.Log(-100, 10);
            double expRes = double.NaN; // в output "не число

            double actualRes = calculator.Divide(inputA, inputB);

            Assert.That(actualRes, Is.EqualTo(expRes));
        }

        [Test]
        public void DivideByZeroNegativeTest()
        {
            double inputA = 9;
            double inputB = 0;
            double expRes = double.PositiveInfinity;

            double actualRes = calculator.Divide(inputA, inputB);

            Assert.That(actualRes, Is.EqualTo(expRes));
        }
    }
}

