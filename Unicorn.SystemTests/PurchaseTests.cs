using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Unicorn.Web;
using Unicorn.Web.Components.Core;
using Unicorn.Web.Enums;
using Unicorn.Web.Plugins;

namespace Unicorn.SystemTests
{
    [TestFixture]
    [ExecutionBrowser(Browser.Chrome, BrowserBehavior.RestartEveryTime)]
    public class PurchaseTests : WebTest
    {
        public override void ClassInit()
        {
            ChromeOptions chromeOptions = new ();
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            App.AddBrowserOptions(chromeOptions);

            System.Console.WriteLine("Once per class.");
        }

        public override void TestInit()
        {
            System.Console.WriteLine("Once per test.");
        }

        [Test]
        public void CreateTestPurchase()
        {
            App.NavigationService.GoToUrl("http://demos.bellatrix.solutions/");
            ////Button button = App.ElementCreateService.CreateById<Button>("myId").ToExists().ToBeClickable();
            ////button.Click();

            Assert.Pass();
        }
    }
}