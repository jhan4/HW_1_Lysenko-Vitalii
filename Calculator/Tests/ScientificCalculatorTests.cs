using System;
using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Description ("Unit Tests for Scientific Calculator")]
    public class ScientificCalculatorTests
    {
        ScientificCalculator a = new ScientificCalculator();

        [Test, Retry(3)]
        public void ArrayMinValueTesting()
        {
            int[] arr = { 4, 5, 2, 1, 7 };
            int expected = 1;
            int actual = a.ArrayMinValue(arr);
            Assert.AreEqual(expected, actual);
        }

        [Test, Description("Verify Array is not empty")]
        public void ArrayIsNotEmptyTesting()
        {
            int[] arr = { 4, 5, 2, 1, 7 };

            Assert.IsNotEmpty(arr);
        }

        [Test ]
        public void ComparisonArrayTesting()
        {
            int[] MaxOfAarray = { 4, 5, 7 };
            int[] MinOfAarray = { -3, 1, 2 };
            Assert.That(MinOfAarray, Is.Not.EquivalentTo(MaxOfAarray));
        }

        [Test]
        public void ComparisonArrayTesting2()
        {
            int[] MaxOfAarray = { 4, 5, 7 };
            int[] MinOfAarray = { 4, 5, 7 };
            Assert.That(MinOfAarray, Is.EquivalentTo(MaxOfAarray));
        }

        [Test]
        public void ComparisonArrayTesting3()
        {
            int[] MinOfAarray = { 4, 5, 7 };
            Assert.That(MinOfAarray, Is.All.InRange(3, 8));
        }

        [Test, Description("Verify Array is empty")]
        public void ArrayIsEmptyTesting()
        {
            int[] arr = { };

            Assert.IsEmpty(arr);
        }

        [Test, Repeat(2)]
        public void ArrayMaxValueTesting()
        {
            int[] arr = { 2, 4, 7, 1 };
            int expected = 7;
            int actual = a.ArrayMaxValue(arr);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SmallerValueTesting()
        {
            int arg1 = 2;
            int arg2 = 3;
            bool actual = a.Compare(arg1, arg2);
            Assert.True(actual);
        }

        [Test]
        public void EqualityTesting()
        {
            int arg1 = 1;
            int arg2 = 1;
            bool actual = a.Compare(arg1, arg2);
            Assert.True(actual);
        }


        [Test]
        public void BiggerValueTesting()
        {
            int arg1 = 3;
            int arg2 = 2;
            bool actual = a.Compare(arg1, arg2);
            Assert.True(actual);
        }
        [Test, Description("Testing of Sqrt Method")]
        public void SqrtTesting()
        {
            double d = 25;
            double expected = 5;
            double actual = a.Sqrt(d);
            Assert.AreEqual(expected, actual, "Square root from 25 to be equal to 5");
        }

        [Test, Description("Assert.Positive Testing")]
        public void SqrtTesting2()
        {
            double d = 25;
            double actual = a.Sqrt(d);
            Assert.Positive(actual, "Actual Result should be positive");
        }

        [Test, Description("Assert.Greater Testing")]
        public void SqrtTesting3()
        {
            double d = 25;
            double actual = a.Sqrt(d);
            Assert.Greater(actual, 0, "Actual Result should be Greater than 0");
        }

        [Test, Description("Pow Method Testing")]
        public void PowTesting()
        {
            double x = 5;
            double y = 2;
            double expected = 25;
            double actual = a.Pow(x, y);
            Assert.AreEqual(expected, actual, "5^2 should be equal to 25");
        }

        [Test, Description("Assert.Positive Testing")]
        public void PowTesting2()
        {
            double actual = a.Pow(2, -8);
            Assert.That(actual, Is.Positive, "Actual Result should be positive");
        }
        [Test, Ignore("Test should be ignored")]
        public void IgnoringOfPowTesting()
        {
            double x = -2;
            double y = 6;
            double expected = -64;
            double actual = a.Pow(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModTesting()
        {
            int x = 25;
            int y = 7;
            int expected = 4;
            ScientificCalculator a = new ScientificCalculator();
            int actual = a.Mod(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test, Description("Assert.Less Testing")]
        public void ModTesting2()
        {
            int x = 25;
            int y = 7;
            ScientificCalculator a = new ScientificCalculator();
            int actual = a.Mod(x, y);
            Assert.Less(actual, 5, "Actual result should be less than 5");
        }
        [Test]
        public void PercentTesting()
        {
            double x = 50;
            double y = 5;
            double expected = 2.5;
            double actual = a.Percent(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test(ExpectedResult = 2.5)]
        public double PercentTesting2()
        {
            return a.Percent(50, 5);
        }

        [TestCase(32, 8)]
        [TestCase(16, 4)]
        [TestCase(-24, -6)]
        public void DivideTests(int a, int b)
        {
            Assert.GreaterOrEqual(a / b, 4);
        }

        [TestCase(3, 9, 3)]
        [TestCase(3, 18, 6)]
        [TestCase(3, -24, 8)]
        public void Divide2Tests(int expected, int a, int b)
        {

            Assert.AreNotEqual(expected, (a / b) * 2);
        }

        [Test]
        public void TestPassed()
        { Assert.Pass("Test passed"); }

        [Test]
        public void TestFailed()
        { Assert.Fail("Test Failed"); }  
    }


    
 }


