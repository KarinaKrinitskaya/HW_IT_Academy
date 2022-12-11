using System;
using CSharpCalculator;

namespace CalculatorNUnit
{
    [TestFixture]
    [Parallelizable]
    public class IsPositiveTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(1000)]
        [TestCase(-12)]
        [TestCase("-400000.9")]
        [TestCase(0)]
        public void IsPositiveValidResTest(double inputA)
        {
            bool actualRes = calculator.isPositive(inputA);
            Assert.IsTrue(actualRes);
        }

        [TestCase(1000)]
        [TestCase(-12)]
        [TestCase("-400000.9")]
        [TestCase(0)]
        public void IsPositiveValidResTest2(double inputA)
        {
            bool actualRes = calculator.isPositive(inputA);
            Assert.IsFalse(actualRes);
        }
    }
}

