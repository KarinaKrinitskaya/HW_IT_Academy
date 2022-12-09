using System;
using CSharpCalculator;

namespace CalculatorNUnit
{
    [TestFixture]
    public class PowTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void PowValidResTest()
        {
            int inputA = 3;
            double inputB = 2;
            double expRes = 9;

            double actualRes = calculator.Pow(inputA, inputB);

            Assert.That(actualRes, Is.EqualTo(expRes));
        }

        [Test]
        public void PowNegativeResTest()
        {
            int inputA = 2;
            double inputB = 4.55;
            double expRes = 9;
            calculator = null;

            Assert.Throws<NullReferenceException>(() => calculator.Pow(inputA,inputB));
        }

    }
}

