using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class LoginPage : HeaderPage
    {
        By errorMessageLocator = By.XPath("//*[@class='error_message']");

        public LoginPage() : base() { }

        public IWebElement GetErrorMessage()
        {
            return ChromeDriver.FindElement(errorMessageLocator);
        }
    }
}
