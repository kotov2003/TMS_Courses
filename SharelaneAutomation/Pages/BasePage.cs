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

        By keywordInputLocator = By.XPath($"//input[@name=\"keyword\"]");

        By searchButtonLocator = By.XPath($"//input[@value=\"Search\"]");

        By searchTitleLocator = By.XPath($"//b[.=\"Search\"]");//??

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
