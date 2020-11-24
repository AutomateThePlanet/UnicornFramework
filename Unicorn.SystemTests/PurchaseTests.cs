using NUnit.Framework;
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