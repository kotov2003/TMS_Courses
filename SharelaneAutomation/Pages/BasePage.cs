using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public abstract class BasePage
    {
        By logoutLinkLocator = By.XPath("//a[@href='./log_out.py']");
        protected string cellLocatorTemplate = "//td[.='{0}']";

        protected WebDriver ChromeDriver { get; set; }

        public BasePage(WebDriver driver)
        {
            ChromeDriver = driver;
        }

        public LogOutPage Logout()
        {
            ChromeDriver.FindElement(logoutLinkLocator).Click();
            return new LogOutPage(ChromeDriver);
        }
    }
}
