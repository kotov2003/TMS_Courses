using NUnit.Framework;
using SharelaneAutomation.Pages;

namespace SharelaneAutomation.Tests
{
    [TestFixture]
    public class SearchTests : SharelaneBaseTest
    {
        private MainPage mainPage;

        [Test]
        public void SearchBookTest()
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

            Assert.Multiple(() =>
            {
                Assert.IsTrue(searchPage.CheckAuthorPresented(author));
                Assert.IsTrue(searchPage.CheckTitlePresented(title));
                Assert.IsTrue(searchPage.CheckPricePresented(price));
                Assert.IsTrue(searchPage.CheckBookCoverPresented());

            });

        }

        [Ignore("bla")]
        [Test]
        public void SearchUserLoggedOutTest()
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