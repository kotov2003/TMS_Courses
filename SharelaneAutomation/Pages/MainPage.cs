using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class MainPage : HeaderPage
    {
        private By logoutButtonLocator = By.XPath("//a[@href='./log_out.py']");

        public MainPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckMainPagePresented());
        }

        private bool CheckMainPagePresented()
        {
            return ChromeDriver.FindElement(logoutButtonLocator).Displayed;
        }
    }
}
