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
            Assert.AreEqual(1, a.ArrayMinValue(arr));
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
            Assert.AreEqual(7, a.ArrayMaxValue(arr));
        }

        [Test, Description("Tan Method Testing")]
        public void TanTesting()
        {
            double tan_of_angle = a.Tan(30);
            Assert.That(tan_of_angle, Is.EqualTo(0.57735), "Tan of 180 degree is equal to 0");
        }

        [Test, Description("ATan Method Testing")]
        public void ATanTesting()
        {
            double tan_of_angle = a.Atan(a.Sqrt(3));
            Assert.That(tan_of_angle, Is.EqualTo(60), "Tan of square root of 3 is equal to 60");
        }


        [Test, Description("Testing of Sqrt Method")]
        public void SqrtTesting()
        {
            Assert.That(a.Sqrt(25), Is.EqualTo(5), "Square root of 25 to be equal to 5");
        }

        [Test, Description("Assert.Positive Testing")]
        public void SqrtTesting2()
        {
            Assert.That(a.Sqrt(25), Is.Positive, "Square root of should be positive");
        }

        [Test, Description("Assert.Greater Testing")]
        public void SqrtTesting3()
        {
            Assert.Greater(a.Sqrt(25), 0, "Actual Result should be Greater than 0");
        }

        [Test, Description("Pow Method Testing")]
        public void PowTesting()
        {
            Assert.AreEqual(25, a.Pow(5, 2), "5^2 should be equal to 25");
        }

        [Test, Description("Assert.Positive Testing")]
        public void PowTesting2()
        {
            Assert.That(a.Pow(2, -8), Is.Positive, "2^(-8) should be positive");
        }
        [Test, Ignore("Test should be ignored")]
        public void IgnoringOfPowTesting()
        {
            Assert.That(a.Pow(-2, 6), Is.EqualTo(-64));
        }

        [Test]
        public void ModTesting()
        {
            Assert.That(a.Mod(25, 7), Is.EqualTo(4));
        }

        [Test, Description("Assert.Less Testing")]
        public void ModTesting2()
        {
            Assert.Less(a.Mod(25, 7), 5, "25 % 7 should be less than 5");
        }
        [Test]
        public void PercentTesting()
        {
            Assert.AreEqual(2.5, a.Percent(50, 5), "5 pecent of 50 is 2.5");
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
        {
            Assert.Pass("Test passed");
        }

        [Test]
        public void TestFailed()
        {
            Assert.Fail("Test Failed");
        }  
    }
 }


