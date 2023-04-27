using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    public class BaseTest
    {
        protected WebDriver ChromeDriver { get; set; }
        public StartPage StartPage { get; set; }
        protected string Login { get; set; } = "ming_rao@904.68.sharelane.com";
        protected string Password { get; set; } = "1111";


        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
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
