using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class AddToCartPage : HeaderPage
    {
        By signupTitleLocator = By.XPath($"//p[.='Add to Shopping Cart']");
        By bookWasAddedMessageLocator = By.XPath($"//*[@class='confirmation_message']");
        By shoppingCartLinkLocator = By.XPath($"//a[@href='./shopping_cart.py']");
        By errorMustLoginMessageLocator = By.XPath($"//*[@class='error_message']");

        public AddToCartPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckAddToCartPagePresented());
        }

        public bool CheckAddToCartPagePresented()
        {
            return ChromeDriver.FindElement(signupTitleLocator).Displayed;
        }

        public IWebElement GetbookWasAddedMessage()
        {
            return ChromeDriver.FindElement(bookWasAddedMessageLocator);
        }

        public IWebElement GetErrorMustLoginMessage()
        {
            return ChromeDriver.FindElement(errorMustLoginMessageLocator);
        }


        public ShoppingCartPage ClickShoppingCartLink()
        {
            ChromeDriver.FindElement(shoppingCartLinkLocator).Click();
            return new ShoppingCartPage(ChromeDriver);
        }
    }
}
