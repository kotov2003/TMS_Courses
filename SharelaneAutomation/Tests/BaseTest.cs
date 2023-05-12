using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SharelaneAutomation.Pages;
using Core.Utilities;
using Core.Selenium;

namespace SharelaneAutomation.Tests
{
    public class BaseTest
    {
        public StartPage StartPage { get; set; }
        public User StandartUser { get; set; } = UserBuilder.GetStandartUser;

        [SetUp]
        public void Setup()
        {
            StartPage = new StartPage();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}
