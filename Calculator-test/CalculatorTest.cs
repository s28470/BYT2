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

        [Test]
        public void TestSubtraction()
        {
            _calculator = new Calculator(5, 2, "-");
            var result = _calculator.Calculate();
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestMultiplication()
        {
            _calculator = new Calculator(3, 3, "*");
            var result = _calculator.Calculate();
            Assert.AreEqual(result, 9);
        }

        [Test]
        public void TestDivision()
        {
            _calculator = new Calculator(9, 3, "/");
            var result = _calculator.Calculate();
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestZeroDivision()
        {
            _calculator = new Calculator(100, 0, "/");
            Assert.Throws<DivideByZeroException>(() => _calculator.Calculate());
        }

        [Test]
        public void TestNoOperation()
        {
            _calculator = new Calculator(0, 0, "");
            Assert.Throws<ArgumentException>(() => _calculator.Calculate());
        }

        [Test]
        public void TestBadFormat()
        {
            Assert.Throws<FormatException>(() =>
            {
                _calculator = new Calculator("a", '3', "+"); });
        }
        
        [Test]
        public void TestNullArgument()
        {
            Assert.Throws<ArgumentNullException>((() =>
            {
                _calculator = new Calculator(null, 0, "-");
            }));
        }

        [Test]
        public void TestOverflowArgument()
        {
            Assert.Throws<OverflowException>((() =>
            {
                _calculator =
                    new Calculator("12312312321312312312312312312312312312312312312312312312312123123139999999999",
                        Math.Pow(999999, 9999999999999999), "+");
            }));
        }


        [Test]
        public void TestIntegerCalculator()
        {
            Assert.DoesNotThrow((() => _calculator = new Calculator(1,1, "+")));
        }

        [Test]
        public void TestDoubleCalculator()
        {
            Assert.DoesNotThrow((() => _calculator = new Calculator(1.1, 1.2, "-")));
        }

        [Test]
        public void TestStringCalculator()
        {
            Assert.DoesNotThrow(()=> _calculator = new Calculator("123", "343", "+"));
        }



        
    }
}