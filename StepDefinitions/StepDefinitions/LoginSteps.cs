using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumCSharpBDDFramework.Pages;

namespace SeleniumCSharpBDDFramework.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginSteps(Hooks hooks)
        {
            _driver = hooks.Driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"the user enters username ""(.*)""")]
        public void WhenTheUserEntersUsername(string username)
        {
            _loginPage.EnterUsername(username);
        }

        [When(@"the user enters password ""(.*)""")]
        public void WhenTheUserEntersPassword(string password)
        {
            _loginPage.EnterPassword(password);
        }

        [When(@"the user clicks on the login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            _loginPage.ClickLogin();
        }

        [Then(@"the user should be redirected to the inventory page")]
        public void ThenTheUserShouldBeRedirectedToTheInventoryPage()
        {
            Assert.IsTrue(_loginPage.IsLoginSuccessful(),
                "Login failed - Inventory page not displayed");
        }

        [Then(@"an authentication error message should be displayed")]
        public void ThenAnAuthenticationErrorMessageShouldBeDisplayed()
        {
            Assert.IsTrue(_loginPage.IsErrorMessageDisplayed(),
                "Expected error message was not displayed");
        }
    }
}
