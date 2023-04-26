using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    [TestFixture]
    public class SignUpTest : BaseTest
    {

        [SetUp]
        public void Setup()
        {
            ChromeDriver.Navigate().GoToUrl("https://sharelane.com/cgi-bin/main.py");
        }

        [Test]
        public void SignUpPositiveTest()
        {
            string mainPageUrl = "https://sharelane.com/cgi-bin/main.py";
            string zipCodeValue = "220082";
            string expectedSignupUrl_2 = $"https://sharelane.com/cgi-bin/register.py?page=1&zip_code={zipCodeValue}";

            string firstNameValue = "Alex";
            string lastNameValue = "Alexov";
            string emailValue = "alex@tut.by";
            string password1Value = "alexalex";
            string password2Value = "alexalex";


            var signUpPage = StartPage.SignUp();
            signUpPage.SetZipCode(zipCodeValue);
            signUpPage.ClickContinueButton();

            signUpPage.SetFirstName(firstNameValue);
            signUpPage.SetLastName(lastNameValue);
            signUpPage.SetEmail(emailValue);
            signUpPage.SetPassword1(password1Value);
            signUpPage.SetPassword2(password2Value);
            signUpPage.ClickRegisterButton();

            var emailGeneratedValue = signUpPage.GetEmailGeneratedValue().Text;
            var passwordGeneratedValue = signUpPage.GetPasswordlGeneratedValue().Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Account is created!", signUpPage.GetAccountCreatedMessage().Text);
                Assert.IsTrue(signUpPage.GetAccountCreatedMessage().Displayed);
                Assert.IsTrue(signUpPage.GetEmailGeneratedValue().Text.Contains('@'));
                Assert.AreEqual("1111", signUpPage.GetPasswordlGeneratedValue().Text);
            });

            var mainPage = signUpPage.ClickToMainPageLink();
            Assert.AreEqual(mainPageUrl, ChromeDriver.Url);

            StartPage.Login(emailGeneratedValue, passwordGeneratedValue).Logout(); ;          
        }

    }
}
