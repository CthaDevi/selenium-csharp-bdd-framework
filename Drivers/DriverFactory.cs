using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpBDDFramework.Drivers
{
    public class DriverFactory
    {
        public IWebDriver InitDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}
