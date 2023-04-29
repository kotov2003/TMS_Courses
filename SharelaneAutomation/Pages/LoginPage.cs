using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class LoginPage : HeaderPage
    {
        By errorMessageLocator = By.XPath("//*[@class='error_message']");

        public LoginPage(WebDriver driver) : base(driver) { }

        public IWebElement GetErrorMessage()
        {
            return ChromeDriver.FindElement(errorMessageLocator);
        }
    }
}
