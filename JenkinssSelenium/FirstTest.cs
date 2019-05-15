using NUnit.Framework;
using System;

namespace JenkinssSelenium
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void TestMethod1()
        {
            Assert.True(2 > 1);
        }
    }
}
