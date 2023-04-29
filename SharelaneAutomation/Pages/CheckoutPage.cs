using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SharelaneAutomation.Pages
{
    public class CheckoutPage : HeaderPage
    {
        By checkoutTitleLocator = By.XPath("//p[.='Checkout']");
        By errorMustLoginMessageLocator = By.XPath("//*[@class='error_message']");
        By cardUpdatedMessageLocator = By.XPath("//*[@class='confirmation_message']");
        By makePaymentButtonLocator = By.XPath("//input[@value='Make Payment']");
        By cardTypeComboboxLocator = By.XPath("//select[@name='card_type_id']");
        By cardNumberLocator = By.XPath("//input[@name='card_number']");
        By thankYouMessageLocator = By.XPath("//p[.='Thank you for your order!!!']");
        By orderIdLocator = By.XPath("//p[contains(text(), 'Order id:')]");
        By quantityCellLocator = By.XPath("//input[@name='q']");

        public CheckoutPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckCheckoutPagePresented());
        }

        public bool CheckCheckoutPagePresented()
        {
            return ChromeDriver.FindElement(checkoutTitleLocator).Displayed;
        }

        public bool CheckCellValueDisplayed(string value)
        {
            return ChromeDriver.FindElement(LocatorByTemplateMaker(cellLocatorTemplate, value)).Displayed;
        }

        private By LocatorByTemplateMaker(string locatorTemplate, string value)
        {
            return By.XPath(string.Format(locatorTemplate, value));
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

        public bool CheckTotalUSDPresented(string totalUSD)
        {
            return CheckCellValueDisplayed(totalUSD);
        }

        public void ClickUpdateButton()
        {
            ChromeDriver.FindElement(makePaymentButtonLocator).Click();
        }

        public void SelectCardType(string selection)
        {
            var combobox = ChromeDriver.FindElement(cardTypeComboboxLocator);
            var selectElement = new SelectElement(combobox);
            selectElement.SelectByText(selection);
        }

        public void SetCardNumber(string cardNumber)
        {
            ChromeDriver.FindElement(cardNumberLocator).SendKeys(cardNumber);
        }

        public void ClickMakePaymentButton()
        {
            ChromeDriver.FindElement(makePaymentButtonLocator).Click();
        }

        public bool CheckOrderIsSuccessful()
        {
            return ChromeDriver.FindElement(thankYouMessageLocator).Displayed;
        }

        public string GetOrderId()
        {
            var orderId = ChromeDriver.FindElement(orderIdLocator).Text;

            return orderId;
        }
    }
}
