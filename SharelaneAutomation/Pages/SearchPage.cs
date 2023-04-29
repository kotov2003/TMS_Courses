using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class SearchPage : HeaderPage
    {
        By searchTitleLocator = By.XPath($"//p[.='Search']");
        By addToCartButtonLocator = By.XPath("//img[@src='../images/add_to_cart.gif']");
        By bookCover = By.XPath("//img[@src='../images/product_8_large.jpg']");
        By confirmationMessageLocator = By.XPath($"//*[@class='confirmation_message']");
        string bookDataLocatorTemplate = "//p[.='{0}']";
        string priceLocatorTemplate = "//p[.='Price: ${0}']";

        public SearchPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckSearchPagePresented());
        }

        public bool CheckSearchPagePresented()
        {
            return ChromeDriver.FindElement(searchTitleLocator).Displayed;
        }

        public bool CheckBookDataValueDisplayed(string value)
        {
            return ChromeDriver.FindElement(LocatorByTemplateMaker(bookDataLocatorTemplate, value)).Displayed;
        }

        private By LocatorByTemplateMaker(string locatorTemplate, string value)
        {
            return By.XPath(string.Format(locatorTemplate, value));
        }


        public bool IsProductFound(string keyword)
        {
            return CheckBookDataValueDisplayed(keyword + " ");
        }

        public bool CheckAuthorPresented(string author)
        {
            return CheckBookDataValueDisplayed(author);
        }

        public bool CheckTitlePresented(string title)
        {
            return CheckBookDataValueDisplayed(title + " ");
        }

        public bool CheckPricePresented(string price)
        {
            var priceLocator = LocatorByTemplateMaker(priceLocatorTemplate, price);
            return ChromeDriver.FindElement(priceLocator).Displayed;
        }

        public bool CheckBookCoverPresented()
        {
            return ChromeDriver.FindElement(bookCover).Displayed;
        }

        public IWebElement GetWarningMessage()
        {
            return ChromeDriver.FindElement(confirmationMessageLocator);
        }

        public AddToCartPage ClickAddToCard()
        {
            ChromeDriver.FindElement(addToCartButtonLocator).Click();
            return new AddToCartPage(ChromeDriver);
        }
    }
}
