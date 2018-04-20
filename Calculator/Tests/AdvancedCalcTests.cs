using System;
using AdvancedCalculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AdvancedCalcTests
    {
        [Test]

        public void ArrayMinValueTesting()
        {
            int[] arr = { 4, 5, 2, 1, 7 };
            int expected = 1;
            ScientificCalculator a = new ScientificCalculator();
            int actual = a.ArrayMinValue(arr);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayMaxValueTesting()
        {
            int[] arr = { 2, 4, 7, 1 };
            int expected = 7;
            ScientificCalculator a = new ScientificCalculator();
            int actual = a.ArrayMaxValue(arr);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SmallerValueTesting()
        {
            int arg1 = 2;
            int arg2 = 3;
            ScientificCalculator a = new ScientificCalculator();
            bool actual = a.compare(arg1, arg2);
            Assert.True(actual);
        }

        [Test]
        public void EqualityTesting()
        {
            int arg1 = 1;
            int arg2 = 1;
            ScientificCalculator a = new ScientificCalculator();
            bool actual = a.compare(arg1, arg2);
            Assert.True(actual);
        }


        [Test]
        public void BiggerValueTesting()
        {
            int arg1 = 3;
            int arg2 = 2;
            ScientificCalculator a = new ScientificCalculator();
            bool actual = a.compare(arg1, arg2);
            Assert.True(actual);
        }
        [Test]
        public void SqrtTesting()
        {
            double d = 25;
            double expected = 5;
            double actual = ScientificCalculator.Sqrt(d);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PowTesting()
        {
            double x = 5;
            double y = 2;
            double expected = 25;
            double actual = ScientificCalculator.Pow(x, y);
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
        [Test]
        public void PercentTesting()
        {
            double x = 50;
            double y = 5;
            double expected = 2.5;

            double actual = ScientificCalculator.Percent(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
