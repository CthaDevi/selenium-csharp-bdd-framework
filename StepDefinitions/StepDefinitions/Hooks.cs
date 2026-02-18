using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumCSharpBDDFramework.Drivers;

namespace SeleniumCSharpBDDFramework.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        public IWebDriver Driver { get; private set; }
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
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
            }
    }
}
