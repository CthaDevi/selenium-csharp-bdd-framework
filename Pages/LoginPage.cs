using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace SeleniumCSharpBDDFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // Locators
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement UsernameField;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement PasswordField;

        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement LoginButton;

        [FindsBy(How = How.CssSelector, Using = ".inventory_list")]
        private IWebElement InventoryContainer;

        // Actions
        public void EnterUsername(string username)
        {
            UsernameField.Clear();
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }

        public bool IsLoginSuccessful()
        {
            return InventoryContainer.Displayed;
        }
    }
}
