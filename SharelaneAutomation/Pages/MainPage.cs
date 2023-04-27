using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class MainPage : HeaderPage
    {
        By logoutButtonLocator = By.XPath($"//a[@href=\"./log_out.py\"]");

        public MainPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckMainPagePresented());
        }

        public bool CheckMainPagePresented()
        {
            return ChromeDriver.FindElement(logoutButtonLocator).Displayed;
        }
    }
}
