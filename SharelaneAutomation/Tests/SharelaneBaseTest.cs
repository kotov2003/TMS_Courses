namespace SharelaneAutomation.Tests
{
    public class SharelaneBaseTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            ChromeDriver.Navigate().GoToUrl("https://sharelane.com/cgi-bin/main.py");
        }
    }
}
