using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {

        [SetUp]
        public void Setup()
        {
            ChromeDriver.Navigate().GoToUrl("https://sharelane.com/cgi-bin/main.py");
        }

        [Test]
        public void LoginPositiveTest()
        {
            string username = "anitha_chen@997.27.sharelane.com";
            string password = "1111";

            StartPage.Login(username, password).Logout();
        }
    }
}