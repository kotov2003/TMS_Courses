using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomation.Pages
{
    public class StartPage : BasePage
    {
        By signUpLinkLocator = By.XPath($"//a[.=\"Sign up\"]");
        private By emaiilInputLocator = By.Name("email");
        private By passwordInputLocator = By.Name("password");
        private By loginButtonLocator = By.XPath($"//input[@value=\"Login\"]");

        public StartPage(WebDriver driver) : base(driver) { }

        public bool CheckStartPagePresented()
        {
            return ChromeDriver.FindElement(signUpLinkLocator).Displayed;
        }

        private void SetEmail(string email)
        {
            ChromeDriver.FindElement(emaiilInputLocator).SendKeys(email);
        }

        private void SetPassword(string password)
        {
            ChromeDriver.FindElement(passwordInputLocator).SendKeys(password);
        }

        private void ClickLoginButton()
        {
            ChromeDriver.FindElement(loginButtonLocator).Click();
        }

        public MainPage Login(string username = "", string password = "")
        {
            SetEmail(username);
            SetPassword(password);
            ClickLoginButton();
            return new MainPage(ChromeDriver);
        }

        public SignUpPage SignUp()
        {
            ChromeDriver.FindElement(signUpLinkLocator).Click();
            return new SignUpPage(ChromeDriver);
        }
    }
}
