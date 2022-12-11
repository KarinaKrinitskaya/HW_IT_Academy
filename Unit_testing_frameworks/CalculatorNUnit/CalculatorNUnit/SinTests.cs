using System;
using CSharpCalculator;

namespace CalculatorNUnit
{
    public class SinTests
    {
        [TestFixture]
        [Parallelizable]
        public class SinNegativeTests
        {
            private Calculator calculator;

            [SetUp]
            public void Setup()
            {
                calculator = new Calculator();
            }

            [TestCase(Math.PI, 1.2246467991473532E-16d)]
            [TestCase(double.PositiveInfinity, double.NaN)]
            public void SubValidResTest(double inputA, double expRes)
            {
                double actualRes = calculator.Sin(inputA);
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
}

