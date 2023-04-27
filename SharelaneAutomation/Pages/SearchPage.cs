using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class SearchPage : HeaderPage
    {
        By searchTitleLocator = By.XPath($"//p[.='Search']");
        By addToCartButtonLocator = By.XPath($"//img[@src='../images/add_to_cart.gif']");
        By bookCover = By.XPath($"//img[@src='../images/product_8_large.jpg']");

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

        public bool CheckAuthorPresented(string author)
        {
            return ChromeDriver.FindElement(By.XPath($"//p[.='{author}']")).Displayed;
        }

        public bool CheckTitlePresented(string title)
        {
            return ChromeDriver.FindElement(By.XPath($"//p[.='{title} ']")).Displayed;
        }

        public bool CheckPricePresented(string price)
        {
            return ChromeDriver.FindElement(By.XPath($"//p[.='Price: ${price}']")).Displayed;
        }

        public bool CheckBookCoverPresented()
        {
            return ChromeDriver.FindElement(bookCover).Displayed;
        }

        //<img src="../images/product_8_large.jpg">


        public AddToCartPage ClickAddToCard()
        {
            ChromeDriver.FindElement(addToCartButtonLocator).Click();
            return new AddToCartPage(ChromeDriver);
        }
    }
}
