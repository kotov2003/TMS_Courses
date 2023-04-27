using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    [TestFixture]
    public class LoginTests : SharelaneBaseTest
    {
        [Test]
        public void LoginPositiveTest()
        {
            var mainPage = StartPage.Login(Login, Password);
            mainPage.Logout();
        }

        [Test]
        public void LoginWithWrongPasswordTest()
        {
            var loginPage = StartPage.LoginInvalid(Login, "wrongPassword");
            Assert.AreEqual("Oops, error. Email and/or password don't match our records", loginPage.GetErrorMessage().Text);
        }
    }
}