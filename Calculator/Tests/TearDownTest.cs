using System;
using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Description("SetUp and TearDown Testing")]
    public class TearDownTest
    {
        ScientificCalculator b;
        [SetUp]
        public void Construct()
        {
            b = new ScientificCalculator();
        }
        [TearDown]
        public void CleanUp()
        {
            b = null;
        }

        [Test]
        public void SinTesting()
        {
            Assert.That(b.Sin(30), Is.EqualTo(0.5), "Sin of 30 degree is equal to 0.5");
        }

        [Test]
        public void CosTesting()
        {
            Assert.That(b.Cos(60), Is.EqualTo(0.5), "Cos of 60 degree is equal to 0.5");
        }

        [Test]
        public void SqrtTesting4()
        {
            Assert.That(b.Sqrt(16), Is.EqualTo(4), "Square root of 16 is equal to 4");
        }

        [Test]
        public void LogarithmTesting()
        {
            Assert.That(b.Logarithm(25, 5), Is.EqualTo(2));
        }

        [Test]
        public void DecimalLogarithmTesting()
        {
            Assert.That(b.Decimal_Logarithm(100), Is.EqualTo(2));
        }
    }
}
