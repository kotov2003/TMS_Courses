using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class ShoppingCartPage : HeaderPage
    {
        By shoppingCartTitleLocator = By.XPath($"//p[.=\"Shopping Cart\"]");
        By confirmationMessageLocator = By.XPath($"//*[@class=\"confirmation_message\"]");
        By updateButtonLocator = By.XPath("//input[@value='Update']");
        By proceedToCheckoutLocator = By.XPath("//input[@value='Proceed to Checkout']");

        public ShoppingCartPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckShoppingCartPagePresented());
        }

        public bool CheckShoppingCartPagePresented()
        {
            return ChromeDriver.FindElement(shoppingCartTitleLocator).Displayed;
        }

        public IWebElement GetCardUpdatedMessage()
        {
            return ChromeDriver.FindElement(confirmationMessageLocator);
        }

        public bool CheckAuthorPresented(string author)
        {
            return ChromeDriver.FindElement(By.XPath($"//td[.='{author}']")).Displayed;
        }

        public bool CheckTitlePresented(string title)
        {
            return ChromeDriver.FindElement(By.XPath($"//td[.='{title}']")).Displayed;
        }

        public bool CheckQuantityPresented(string quantity)
        {
            return quantity == ChromeDriver.FindElement(By.XPath($"//input[@name='q']")).GetAttribute("value");
        }

        public bool CheckPricePresented(string price)
        {
            return ChromeDriver.FindElement(By.XPath($"//td[.='{price}']")).Displayed;
        }

        public bool CheckDiscountPCTPresented(string discountPCT)
        {
            return ChromeDriver.FindElement(By.XPath($"//td[.='{discountPCT}']")).Displayed;
        }

        public bool CheckDiscountUSDPresented(string discountUSD)
        {
            return ChromeDriver.FindElement(By.XPath($"//td[.='{discountUSD}']")).Displayed;
        }

        public bool CheckTotalUSDPresented(string totalUSD)
        {
            return ChromeDriver.FindElement(By.XPath($"//td[.='{totalUSD}']")).Displayed;
        }

        public void ClickUpdateButton()
        {
            ChromeDriver.FindElement(updateButtonLocator).Click();
        }
        public CheckoutPage ClickpProceedToCheckouButton()
        {
            ChromeDriver.FindElement(proceedToCheckoutLocator).Click();
            return new CheckoutPage(ChromeDriver);
        }
    }
}
