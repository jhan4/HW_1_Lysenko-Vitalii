using System;
using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SimpleCalcTests
    {
        [Test]
        public void NotEqual1Testing()
        {
            int x = 8;
            int y = 5;
            int expected = 14;

            SimpleCalculator a = new SimpleCalculator();
            int actual = a.Addition(x, y);
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void AdditiongTesting()
        {
            int x = 8;
            int y = 5;
            int expected = 13;

            SimpleCalculator a = new SimpleCalculator();
                int actual = a.Addition(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstractionTesting()
        {
            int x = 8;
            int y = 5;
            int expected = 3;

            SimpleCalculator a = new SimpleCalculator();
            int actual = a.Substraction(x, y);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplicationTesting()
        {
            int x = 2;
            int y = 6;
            int expected = 12;

            SimpleCalculator a = new SimpleCalculator();
            int actual = a.Multiplication(x, y);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivideTesting()
        {
            int x = 12;
            int y = 4;
            int expected = 3;

            SimpleCalculator a = new SimpleCalculator();
            int actual = a.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
