using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    [TestFixture]
    public class LoginTests : SharelaneBaseTest
    {
        [Test]
        public void LoginPositiveTest()
        {
            StartPage.Login(Login, Password).Logout();
        }
    }
}