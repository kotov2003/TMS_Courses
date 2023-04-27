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

        [Test]
        public void SearchBookPartialTitleTest()
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
            mainPage.SetKeyword(title.Substring(4,4));
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

        [Test]
        public void SearchNonExistentBookTest()
        {
            var title = "GULAG";

            mainPage = StartPage.Login(Login, Password);
            mainPage.SetKeyword(title);
            var searchPage = mainPage.ClickSearchButton();

            Assert.AreEqual("Nothing is found :(", searchPage.GetWarningMessage().Text);
        }
    }
}