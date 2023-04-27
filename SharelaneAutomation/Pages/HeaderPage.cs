using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomation.Pages
{
    public class HeaderPage : BasePage
    {
        By keywordInputLocator = By.XPath($"//input[@name=\"keyword\"]");
        By searchButtonLocator = By.XPath($"//input[@value=\"Search\"]");

        public HeaderPage(WebDriver driver) : base(driver) { }

        public void SetKeyword(string keyword)
        {
            ChromeDriver.FindElement(keywordInputLocator).SendKeys(keyword);
        }

        public SearchPage ClickSearchButton()
        {
            ChromeDriver.FindElement(searchButtonLocator).Click();
            return new SearchPage(ChromeDriver);
        }

    }
}
