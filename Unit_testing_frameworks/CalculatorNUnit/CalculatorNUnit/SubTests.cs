using System;
using CSharpCalculator;

namespace CalculatorNUnit
{
    [TestFixture]
    [Parallelizable]
    public class SubTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(1000, 200, 800)]
        [TestCase(-12, -20, 8)]
        [TestCase(Math.PI, 0, Math.PI)]
        public void SubValidResTest(double inputA, double inputB, double expRes)
        {
            double actualRes = calculator.Sub(inputA, inputB);
            Assert.That(actualRes, Is.EqualTo(expRes));
        }

        [TestCase(0, Double.NegativeInfinity, Double.PositiveInfinity)]
        [TestCase("10", 45, -35)]
        public void SubNegativeTest(double inputA, double inputB, double expRes)
        {
            double actualRes = calculator.Sub(inputA, inputB);
            Assert.That(actualRes, Is.EqualTo(expRes));
        }
    }
}

