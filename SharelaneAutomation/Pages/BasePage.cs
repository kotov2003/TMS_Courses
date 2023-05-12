using Core.Selenium;
using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public abstract class BasePage
    {
        By logoutLinkLocator = By.XPath("//a[@href='./log_out.py']");
        protected string cellLocatorTemplate = "//td[.='{0}']";

        protected IWebDriver ChromeDriver { get; set; }

        public BasePage()
        {
            ChromeDriver = Browser.Instance.Driver;
        }

        public LogOutPage Logout()
        {
            ChromeDriver.FindElement(logoutLinkLocator).Click();
            return new LogOutPage();
        }
    }
}
