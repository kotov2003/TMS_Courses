using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    [TestFixture]
    public class E2ETests : SharelaneBaseTest
    {
        private MainPage mainPage;

        [Test]
        public void E2E_BookOrderingTest()
        {
            var author = "W.Somerset Maugham";
            var title = "The Moon and Sixpence";
            var quantity = "1";
            var price = "10.00";
            var discountPct = "7";
            var discountUsd = "0.7";
            var totalUsd = "10.70";
            var cardType = "MasterCard";
            var cardNumber = "2222222222223642";


            mainPage = StartPage.Login(Login, Password);
            mainPage.SetKeyword(title);
            var searchPage = mainPage.ClickSearchButton();

            Assert.IsTrue(searchPage.IsProductFound(title));
            var addToCartPage = searchPage.ClickAddToCard();

            Assert.AreEqual("Book was added to the Shopping Cart", addToCartPage.GetbookWasAddedMessage().Text);
            Assert.IsTrue(addToCartPage.GetbookWasAddedMessage().Displayed);

            var shoppingCartPage = addToCartPage.ClickShoppingCartLink();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(shoppingCartPage.CheckAuthorPresented(author));
                Assert.IsTrue(shoppingCartPage.CheckTitlePresented(title));
                Assert.IsTrue(shoppingCartPage.CheckQuantityPresented(quantity));
                Assert.IsTrue(shoppingCartPage.CheckPricePresented(price));
                Assert.IsTrue(shoppingCartPage.CheckDiscountPCTPresented(discountPct));
                Assert.IsTrue(shoppingCartPage.CheckDiscountUSDPresented(discountUsd));
                Assert.IsTrue(shoppingCartPage.CheckTotalUSDPresented(totalUsd));
            });

            shoppingCartPage.ClickUpdateButton();
            Assert.AreEqual("Cart Updated", shoppingCartPage.GetCardUpdatedMessage().Text);

            var checkoutPage = shoppingCartPage.ClickpProceedToCheckouButton();
            Assert.Multiple(() =>
            {
                Assert.IsTrue(checkoutPage.CheckAuthorPresented(author));
                Assert.IsTrue(checkoutPage.CheckTitlePresented(title));
                Assert.IsTrue(checkoutPage.CheckQuantityPresented(quantity));
                Assert.IsTrue(checkoutPage.CheckTotalUSDPresented(totalUsd));
            });

            checkoutPage.SelectCardType(cardType);
            checkoutPage.SetCardNumber(cardNumber);
            checkoutPage.ClickMakePaymentButton();
            Assert.IsTrue(checkoutPage.CheckOrderIsSuccessful());

            var orderId = checkoutPage.GetOrderId().Replace("Order id: ", "");
            Assert.IsNotEmpty(orderId);
        }

        [Test]
        public void E2E_BookOrdering_UserLoggedOutTest()
        {
            var author = "W.Somerset Maugham";
            var title = "The Moon and Sixpence";
            var quantity = "1";
            var price = "10.00";
            var discountPct = "7";
            var discountUsd = "0.7";
            var totalUsd = "10.70";

            StartPage.SetKeyword(title);
            var searchPage = StartPage.ClickSearchButton();

            Assert.IsTrue(searchPage.IsProductFound(title));
            var addToCartPage = searchPage.ClickAddToCard();

            Assert.AreEqual("Oops, error. You must log in", addToCartPage.GetErrorMustLoginMessage().Text);
        }
    }
}