using System;
using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Description("Unit Tests for Simple Calculator")]
    public class SimpleCalcTests
    {
        SimpleCalculator a = new SimpleCalculator();
        [Test, Ignore("Negative Test")]
        public void NotEqual1Testing()
        {
            int x = 8;
            int y = 5;
            int expected = 14;
            int actual = a.Addition(x, y);
            Assert.AreNotEqual(expected, actual);
        }
        [Test, Order(3)]
        public void AdditiongTesting()
        {
            int x = 8;
            int y = 5;
            int expected = 13;
            int actual = a.Addition(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test, Order(4)]
        public void SubstractionTesting()
        {
            int x = 8;
            int y = 5;
            int expected = 3;
            int actual = a.Substraction(x, y);
            Assert.AreEqual(expected, actual);
        }
        [Test, Order(1)]
        public void MultiplicationTesting()
        {
            int x = 2;
            int y = 6;
            int expected = 12;
            int actual = a.Multiplication(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test, Description("Assert.Zero Testing")]
        public void MultiplicationTesting3()
        {
            int num1 = 2;
            int num2 = 0;
            int actual = a.Multiplication(num1, num2);
            Assert.Zero(actual, "Actual Result should be equal to 0");
        }
        [Test, Order(2)]
        public void DivideTesting()
        {
            int x = 12;
            int y = 4;
            int expected = 3;
            int actual = a.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test, Description ("Assert.Negative Testing")]
        public void DivideTesting3()
        {
            int x = 12;
            int y = -4;
            int actual = a.Divide(x, y);
            Assert.Negative(actual, "Actual Result should be negative");
        }

        [Test (ExpectedResult=4)]
        public int DivideTesting2()
        {
            return 12 / 3;         
        }

        [Test(ExpectedResult = -8)]
        public int MultiplicationTesting2()
        {
            return -2 * 4;
        }

        [Test (ExpectedResult =-10)]
        public int SubstractionTesting2()
        {
            return -7 - 3;
        }
    }
}
