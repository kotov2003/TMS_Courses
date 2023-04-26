using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomation.Pages
{
    public class SignUpPage : BasePage
    {
        const string SignUpUrl_1 = "https://sharelane.com/cgi-bin/register.py";

        By signupTitleLocator = By.XPath($"//b[.=\"Sign Up\"]");
        By zipcodeInputLocator = By.XPath($"//input[@name=\"zip_code\"]");
        By continueButtonLocator = By.XPath($"//input[@value=\"Continue\"]");

        By firstNameInputLocator = By.XPath($"//input[@name=\"first_name\"]");
        By lastNameInputLocator = By.XPath($"//input[@name=\"last_name\"]");
        By emailInputLocator = By.XPath($"//input[@name=\"email\"]");
        By password1InputLocator = By.XPath($"//input[@name=\"password1\"]");
        By password2InputLocator = By.XPath($"//input[@name=\"password2\"]");
        By registerButtonLocator = By.XPath($"//input[@value=\"Register\"]");

        By accountIsCreatedMessageLocator = By.XPath($"//*[@class=\"confirmation_message\"]");
        By emailGeneratedLocator = By.XPath($"//td[preceding-sibling::td=\"Email\"]");
        By passwordGeneratedLocator = By.XPath($"//td[preceding-sibling::td=\"Password\"]");
        By toMainPageLinkLocator = By.XPath($"//a[@href=\"./main.py\"]");

        public SignUpPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckSignUpPagePresented());
            Assert.AreEqual(SignUpUrl_1, ChromeDriver.Url);
        }

        public bool CheckSignUpPagePresented()
        {
            return ChromeDriver.FindElement(signupTitleLocator).Displayed;
        }

        public void SetZipCode(string zipCodeValue)
        {
            ChromeDriver.FindElement(zipcodeInputLocator).SendKeys(zipCodeValue);
        }

        public void ClickContinueButton()
        {
            ChromeDriver.FindElement(continueButtonLocator).Click();
        }

        public void SetFirstName(string firstNameValue)
        {
            ChromeDriver.FindElement(firstNameInputLocator).SendKeys(firstNameValue);
        }

        public void SetLastName(string lastNameValue)
        {
            ChromeDriver.FindElement(lastNameInputLocator).SendKeys(lastNameValue);
        }

        public void SetEmail(string emailValue)
        {
            ChromeDriver.FindElement(emailInputLocator).SendKeys(emailValue);
        }

        public void SetPassword1(string password1Value)
        {
            ChromeDriver.FindElement(password1InputLocator).SendKeys(password1Value);
        }

        public void SetPassword2(string password2Value)
        {
            ChromeDriver.FindElement(password2InputLocator).SendKeys(password2Value);
        }

        public void ClickRegisterButton()
        {
            ChromeDriver.FindElement(registerButtonLocator).Click();
        }

        public IWebElement GetAccountCreatedMessage()
        {
            return ChromeDriver.FindElement(accountIsCreatedMessageLocator);
        }

        public IWebElement GetEmailGeneratedValue()
        {
            return ChromeDriver.FindElement(emailGeneratedLocator);
        }

        public IWebElement GetPasswordlGeneratedValue()
        {
            return ChromeDriver.FindElement(passwordGeneratedLocator);
        }

        public MainPage ClickToMainPageLink()
        {
            ChromeDriver.FindElement(toMainPageLinkLocator).Click();
            return new MainPage(ChromeDriver);
        }
    }
}
