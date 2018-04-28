using System;
using Calculator;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Description("String Assert Testting")]

    public class StringTesting
    {
        [Test]
        public void AssertStringContain()
        {
            Assert.That("the best", Does.Contain("the best"), "If you want to be the best...");
        }

        [Test]
        public void AssertStringEnd()
        {
            Assert.That("the best", Does.EndWith("st"), "If you want to be the best...");
        }

        [Test]
        public void AssertStringStart()
        {
            Assert.That("the best", Does.StartWith("th"), "If you want to be the best...");
        }

        [Test]
        public void AssertIgnore()
        {
            StringAssert.AreEqualIgnoringCase("The Best", "the best", "If you want to be the best...");
        }
    }
}
