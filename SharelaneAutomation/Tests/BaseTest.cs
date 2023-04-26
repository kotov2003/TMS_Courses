using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    public class BaseTest
    {
        protected WebDriver ChromeDriver { get; set; }
        public StartPage StartPage { get; set; }



        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            StartPage = new StartPage(ChromeDriver);
        }

        [TearDown]
        public void TearDwn()
        {
            ChromeDriver.Quit();
        }
    }
}
