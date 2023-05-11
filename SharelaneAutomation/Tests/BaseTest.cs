using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SharelaneAutomation.Pages;
using Core.Utilities;
using Core.Configuration;

namespace SharelaneAutomation.Tests
{
    public class BaseTest
    {
        protected WebDriver ChromeDriver { get; set; }
        public StartPage StartPage { get; set; }
        public User StandartUser { get; set; } = UserBuilder.GetStandartUser;

        [SetUp]
        public void Setup()
        {
            string browser = TestContext.Parameters.Get("Browser");
            bool headless = Configuration.Browser.Headless;

            switch (browser)
            {
                case "headless":
                    ChromeOptions options= new ChromeOptions();
                    options.AddArguments("--headless");
                    ChromeDriver = new ChromeDriver(options);
                    break;
                default:
                    ChromeDriver = new ChromeDriver();
                    break;
            }
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            StartPage = new StartPage(ChromeDriver);
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
