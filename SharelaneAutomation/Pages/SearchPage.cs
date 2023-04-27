using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class SearchPage : HeaderPage
    {
        By searchTitleLocator = By.XPath($"//p[.='Search']");
        By addToCartButtonLocator = By.XPath($"//img[@src='../images/add_to_cart.gif']");

        public SearchPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckSearchPagePresented());
        }

        public bool CheckSearchPagePresented()
        {
            return ChromeDriver.FindElement(searchTitleLocator).Displayed;
        }

        public bool IsProductFound(string keyword)
        {
            return ChromeDriver.FindElement(By.XPath($"//p[.='{keyword} ']")).Displayed;
        }

        public AddToCartPage ClickAddToCard()
        {
            ChromeDriver.FindElement(addToCartButtonLocator).Click();
            return new AddToCartPage(ChromeDriver);
        }
    }
}
