using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomation.Pages
{
    public abstract class BasePage
    {
        By logoutLinkLocator = By.XPath($"//a[@href=\"./log_out.py\"]");

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
