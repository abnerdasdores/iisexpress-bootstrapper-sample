using IISExpressBootstrapper;
using OpenQA.Selenium;

namespace IISExpressBootstrapperSample.Web.Tests
{
    public static class TestContext
    {
        public static IISExpressHost Host { get; set; }

        public static IWebDriver WebDriver { get; set; }
    }
}
