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
            Assert.AreNotEqual(14, a.Addition(8, 5));
        }

        [Test, Order(3)]
        public void AdditiongTesting()
        {
            Assert.AreEqual(13, a.Addition(8, 5));
        }

        [Test, Order(4)]
        public void SubstractionTesting()
        {
            Assert.AreEqual(3, a.Substraction(8, 5));
        }
        [Test, Order(1)]
        public void MultiplicationTesting()
        {
            Assert.AreEqual(12, a.Multiplication(2, 6));
        }

        [Test, Description("Assert.Zero Testing")]
        public void MultiplicationTesting3()
        {
            Assert.Zero(a.Multiplication(2, 0), "Actual Result should be equal to 0");
        }
        [Test, Order(2)]
        public void DivideTesting()
        {
            Assert.AreEqual(3, a.Divide(12, 4));
        }

        [Test, Description ("Assert.Negative Testing")]
        public void DivideTesting3()
        {
            Assert.Negative(a.Divide(12, -4), "Actual Result should be negative");
        }

        [Test (ExpectedResult=4)]
        public double DivideTesting2()
        {
            return a.Divide(12, 3);         
        }

        [Test(ExpectedResult = -8)]
        public double MultiplicationTesting2()
        {
            return a.Multiplication(- 2, 4);
        }

        [Test (ExpectedResult =-10)]
        public int SubstractionTesting2()
        {
            return a.Substraction(- 7, 3);
        }
    }
}
