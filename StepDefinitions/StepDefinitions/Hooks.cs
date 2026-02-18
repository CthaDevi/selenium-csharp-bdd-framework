using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumCSharpBDDFramework.Drivers;
using SeleniumCSharpBDDFramework.Utilities;

namespace SeleniumCSharpBDDFramework.StepDefinitions
{
    [Binding]
public class Hooks
{
    public IWebDriver Driver { get; private set; }
    private DriverFactory _driverFactory;
    private readonly ScenarioContext _scenarioContext;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void Setup()
    {
        _driverFactory = new DriverFactory();
        Driver = _driverFactory.InitDriver();
    }

    [AfterScenario]
    public void TearDown()
    {
        if (_scenarioContext.TestError != null)
        {
            ScreenshotHelper.CaptureScreenshot(Driver, _scenarioContext.ScenarioInfo.Title);
        }

        Driver?.Quit();
    }
}

}
