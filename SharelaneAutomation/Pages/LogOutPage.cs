using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class LogOutPage : BasePage
    {
        const string LogoutMessage = "You've been logged out";
        By logoutTitleLocator = By.XPath($"//b[.=\"Log out\"]");
        By logOutMessageLocator = By.XPath($"//*[@class=\"confirmation_message\"]");

        public LogOutPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckLogOutPagePresented());
            Assert.AreEqual(LogoutMessage, GetLogOutMessageValue());
        }

        public bool CheckLogOutPagePresented()
        {
            return ChromeDriver.FindElement(logoutTitleLocator).Displayed;
        }

        public string GetLogOutMessageValue()
        {
            return ChromeDriver.FindElement(logOutMessageLocator).Text;
        }
    }
}
