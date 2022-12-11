using System;
using CSharpCalculator;

namespace CalculatorNUnit
{
    [TestFixture]
    [Parallelizable]
    public class AddTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddValidResTest()
        {
            double inputA = 1000;
            double inputB = 308;
            double expRes = 1308;

            double actualRes = calculator.Add(inputA, inputB);

            Assert.That(actualRes, Is.EqualTo(expRes));
        }
    }
}

