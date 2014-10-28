using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator _calc;
        public CalculatorTests()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void AddMethodExists()
        {
            var result = _calc.Add("5");
        }

        [TestMethod]
        public void EmptyStringReturnsZero()
        {
            var result = _calc.Add("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void StringWithOneNumberReturnsNumber()
        {
            var result = _calc.Add("5");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void StringWithOneandTwoReturnsThree()
        {
            var result = _calc.Add("1,2");
            Assert.AreEqual(3, result);
        }

        public void TestTemplate()
        {
            //Arrange
            // var calc = new Calculator();
            //Act
            var result = _calc.Add("1,2");
            //Assert
            Assert.AreEqual(3, result);
        }

        public void TestTemplate2()
        {
            //Given - A calulator should add two numbers, 1 and 2.
            // var calc = new Calculator();
            // int number1 = 1;
            // int number2 = 2;
            //When
            var result = _calc.Add("1,2");
            //Then
            Assert.AreEqual(3, result);
        }


    }
}
