using NUnit.Framework;
using Unicorn.Web;
using Unicorn.Web.Components.Core;

namespace Unicorn.SystemTests
{
    [TestFixture]
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
        public void Test1()
        {
            Button button = App.ElementCreateService.CreateById<Button>("myId");
            button.Click();

            Assert.Pass();
        }
    }
}