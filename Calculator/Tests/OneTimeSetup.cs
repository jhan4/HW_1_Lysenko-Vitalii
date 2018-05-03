using System;
using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class OneTimeSetup
    {
        string phrase;
        string Words;
        [OneTimeSetUp]
        public void OneTime()
        {

            phrase = "the best";
            Words = "If you want to be the best...";
        }

        [OneTimeTearDown]
        public void OnetimeTeardown()
        {
            phrase = null;

        }

        [Test]
        public void AssertStringContain2()
        {
            Assert.That(phrase, Does.Contain(phrase), Words);
        }

        [Test]
        public void AssertStringEnd2()
        {
            Assert.That(phrase, Does.EndWith("st"), Words);
        }

        [Test]
        public void AssertStringStart2()
        {
            Assert.That(phrase, Does.StartWith("th"), Words);
        }

        [Test]
        public void AssertIgnore2()
        {
            StringAssert.AreEqualIgnoringCase("The Best", phrase, Words);
        }
    }
}
