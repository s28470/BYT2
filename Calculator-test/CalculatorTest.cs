using System;
using Calculator;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator
{

    [TestFixture]
    [TestOf(typeof(Calculator))]
    public class CalculatorTest
    {

        private Calculator _calculator;

        [Test]
        public void TestAddition()
        {
            _calculator = new Calculator(3, 2, "+");
            var result = _calculator.Calculate();
            Assert.AreEqual(result, 5);
        }

	   
        public void TestSubtraction()
        {
            _calculator = new Calculator(5, 2, "-");
            var result = _calculator.Calculate();
            Assert.AreEqual(result, 3);
        }

        public void TestMultiplication()
        {
            _calculator = new Calculator(3, 3, "*");
            var result = _calculator.Calculate();
            Assert.AreEqual(result, 9);
        }

        public void TestDivision()
        {
            _calculator = new Calculator(9, 3, "/");
            var result = _calculator.Calculate();
            Assert.AreEqual(result, 3);
        }

        public void TestZeroDivision()
        {
            _calculator = new Calculator(100, 0, "/");
            Assert.Throws<DivideByZeroException>(() => _calculator.Calculate());
        }
    }
}