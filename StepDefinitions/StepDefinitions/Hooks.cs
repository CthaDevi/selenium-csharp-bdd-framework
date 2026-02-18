using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumCSharpBDDFramework.Drivers;

namespace SeleniumCSharpBDDFramework
{
    [Binding]
    public class Hooks
    {
        public IWebDriver Driver;
        private DriverFactory _driverFactory;

        [BeforeScenario]
        public void Setup()
        {
            _driverFactory = new DriverFactory();
            Driver = _driverFactory.InitDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
