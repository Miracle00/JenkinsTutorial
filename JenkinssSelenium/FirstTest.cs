using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [Test]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Quit();
        }
    }
}
