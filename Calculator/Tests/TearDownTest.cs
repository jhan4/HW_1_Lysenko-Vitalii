using System;
using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Description("SetUp and TearDown Testing")]
    public class TearDownTest
    {
        ScientificCalculator a;
        [SetUp]
        public void Construct()
        {
            a = new ScientificCalculator();
        }

        [Test]
        public void SqrtTesting4()
        {
            double d = 16;
            double actual = a.Sqrt(d);
            Assert.AreEqual(actual, 4);
        }

        [Test]
        public void LogarithmTesting()
        {
            double log = a.Logarithm(25, 5);
            Assert.That(log, Is.EqualTo(2));
        }

        [Test]
        public void DecimalLogarithmTesting()
        {
            double d = a.Decimal_Logarithm(100);
            Assert.That(d, Is.EqualTo(2));
        }

        [TearDown]
        public void CleanUp()
        {
            a = null;
        }
    }
}
