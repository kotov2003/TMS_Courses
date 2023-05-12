using Core.Selenium;

namespace SharelaneAutomation.Tests
{
    public class SharelaneBaseTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Browser.Instance.NavigateToUrl("https://sharelane.com/cgi-bin/main.py");
        }
    }
}
