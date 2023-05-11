using Core.Utilities;
using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    [TestFixture]
    public class LoginTests : SharelaneBaseTest
    {
        [Test]
        public void EnvVariablesExample()
        {
            Environment.SetEnvironmentVariable("Test1", "Value1");
            var value = Environment.GetEnvironmentVariable("Test1");

            // Now retrieve it.
            value = Environment.GetEnvironmentVariable("Browser", EnvironmentVariableTarget.Machine);

        }
        [Test]
        public void LoginPositiveTest()
        {
            var user = UserBuilder.GetStandartUser;
            var mainPage = StartPage.Login(user);
            mainPage.Logout();
        }

        [Test]
        public void LoginWithWrongPasswordTest()
        {
            var user = UserBuilder.GetInvalidWrongPasswordUser;
            var loginPage = StartPage.LoginInvalid(user);
            Assert.AreEqual("Oops, error. Email and/or password don't match our records", loginPage.GetErrorMessage().Text);
        }
    }
}