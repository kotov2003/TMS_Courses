using OpenQA.Selenium;
using System.Diagnostics;

namespace SharelaneAutomation.Pages
{
    public class ShoppingCartPage : HeaderPage
    {
        By shoppingCartTitleLocator = By.XPath("//p[.='Shopping Cart']");
        By confirmationMessageLocator = By.XPath("//*[@class='confirmation_message']");
        By updateButtonLocator = By.XPath("//input[@value='Update']");
        By proceedToCheckoutLocator = By.XPath("//input[@value='Proceed to Checkout']");
        By quantityCellLocator = By.XPath("//input[@name='q']");

        public ShoppingCartPage() : base()
        {
            Assert.IsTrue(CheckShoppingCartPagePresented());
        }

        public bool CheckShoppingCartPagePresented()
        {
            return ChromeDriver.FindElement(shoppingCartTitleLocator).Displayed;
        }

        public bool CheckCellValueDisplayed(string value)
        {
            return ChromeDriver.FindElement(LocatorByTemplateMaker(cellLocatorTemplate, value)).Displayed;
        }

        private By LocatorByTemplateMaker(string locatorTemplate, string value)
        {
            return By.XPath(string.Format(locatorTemplate, value));
        }


        public IWebElement GetCardUpdatedMessage()
        {
            return ChromeDriver.FindElement(confirmationMessageLocator);
        }

        public bool CheckAuthorPresented(string author)
        {
            return CheckCellValueDisplayed(author);
        }

        public bool CheckTitlePresented(string title)
        {
            return CheckCellValueDisplayed(title);
        }

        public bool CheckQuantityPresented(string quantity)
        {
            return quantity == ChromeDriver.FindElement(quantityCellLocator).GetAttribute("value");
        }

        public bool CheckPricePresented(string price)
        {
            return CheckCellValueDisplayed(price);
        }

        public bool CheckDiscountPCTPresented(string discountPCT)
        {
            return CheckCellValueDisplayed(discountPCT);
        }

        public bool CheckDiscountUSDPresented(string discountUSD)
        {
            return CheckCellValueDisplayed(discountUSD);
        }

        public bool CheckTotalUSDPresented(string totalUSD)
        {
            return CheckCellValueDisplayed(totalUSD);
        }

        public void ClickUpdateButton()
        {
            ChromeDriver.FindElement(updateButtonLocator).Click();
        }
        public CheckoutPage ClickpProceedToCheckouButton()
        {
            ChromeDriver.FindElement(proceedToCheckoutLocator).Click();
            return new CheckoutPage();
        }
    }
}
