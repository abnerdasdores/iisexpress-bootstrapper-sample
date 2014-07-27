using IISExpressBootstrapper;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace IISExpressBootstrapperSample.Web.Tests
{
    [SetUpFixture]
    public class AssemblyInitialize
    {
        [SetUp]
        public void SetUpTestContext()
        {
            TestContext.Host = new IISExpressHost("IISExpressBootstrapperSample.Web", 8080);

            TestContext.WebDriver = new FirefoxDriver();
            TestContext.WebDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownTestContext()
        {
            TestContext.Host.Dispose();

            TestContext.WebDriver.Dispose();
        }
    }
}
