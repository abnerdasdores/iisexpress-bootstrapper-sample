using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace IISExpressBootstrapperSample.Web.Tests
{
    [TestFixture]
    public class HomeControllerTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = TestContext.WebDriver;
        }

        [Test]
        public void ShouldNavigateToHome()
        {
            driver.Navigate().GoToUrl("http://localhost:8080");

            driver.PageSource.Should().Contain("ASP.NET is a free web framework");
        }
    }
}
