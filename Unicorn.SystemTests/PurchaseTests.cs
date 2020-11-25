using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Unicorn.SystemTests.Pages.CartPage;
using Unicorn.SystemTests.Pages.CheckoutPage;
using Unicorn.SystemTests.Pages.MainPage;
using Unicorn.Web;
using Unicorn.Web;
using Unicorn.Web.Enums;
using Unicorn.Web.Plugins;

namespace Unicorn.SystemTests
{
    [TestFixture]
    [ExecutionBrowser(Browser.Chrome, BrowserBehavior.RestartEveryTime)]
    public class PurchaseTests : WebTest
    {
        private static MainPage _mainPage;
        private static CartPage _cartPage;
        private static CheckoutPage _checkoutPage;
        private static PurchaseFacade _purchaseFacade;

        public override void ClassInit()
        {
            ////ChromeOptions chromeOptions = new ();
            ////chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            ////App.AddBrowserOptions(chromeOptions);
        }

        public override void TestInit()
        {
            _mainPage = App.Create<MainPage>();
            _cartPage = App.Create<CartPage>();
            _checkoutPage = App.Create<CheckoutPage>();
            _purchaseFacade = new PurchaseFacade(_mainPage, _cartPage, _checkoutPage);
        }

        [Test]
        public void PurchaseFalcon9WithoutFacade()
        {
            App.GoTo<MainPage>();
            _mainPage.AddRocketToShoppingCart("Falcon 9");
            _cartPage.ApplyCoupon("happybirthday");
            _cartPage.AssertCouponAppliedSuccessfully();
            _cartPage.IncreaseProductQuantity(2);
            _cartPage.AssertTotalPrice("114.00ˆ");
            _cartPage.ClickProceedToCheckout();

            var purchaseInfo = new PurchaseInfo()
            {
                Email = "info@berlinspaceflowers.com",
                FirstName = "Anton",
                LastName = "Angelov",
                Company = "Space Flowers",
                Country = "Germany",
                Address1 = "1 Willi Brandt Avenue Tiergarten",
                Address2 = "Lützowplatz 17",
                City = "Berlin",
                Zip = "10115",
                Phone = "+00498888999281",
            };
            _checkoutPage.FillBillingInfo(purchaseInfo);
            _checkoutPage.AssertOrderReceived();
        }

        [Test]
        public void PurchaseSaturnVWithoutFacade()
        {
            App.GoTo<MainPage>();
            _mainPage.AddRocketToShoppingCart("Saturn V");
            _cartPage.ApplyCoupon("happybirthday");
            _cartPage.AssertCouponAppliedSuccessfully();
            _cartPage.IncreaseProductQuantity(3);
            _cartPage.AssertTotalPrice("355.00ˆ");
            _cartPage.ClickProceedToCheckout();

            var purchaseInfo = new PurchaseInfo()
            {
                Email = "info@berlinspaceflowers.com",
                FirstName = "John",
                LastName = "Atanasov",
                Company = "Space Flowers",
                Country = "Germany",
                Address1 = "1 Willi Brandt Avenue Tiergarten",
                Address2 = "Lützowplatz 17",
                City = "Berlin",
                Zip = "10115",
                Phone = "+00498888999281",
            };
            _checkoutPage.FillBillingInfo(purchaseInfo);
            _checkoutPage.AssertOrderReceived();
        }

        [Test]
        public void PurchaseFalcon9WithFacade()
        {
            var purchaseInfo = new PurchaseInfo()
            {
                Email = "info@berlinspaceflowers.com",
                FirstName = "Anton",
                LastName = "Angelov",
                Company = "Space Flowers",
                Country = "Germany",
                Address1 = "1 Willi Brandt Avenue Tiergarten",
                Address2 = "Lützowplatz 17",
                City = "Berlin",
                Zip = "10115",
                Phone = "+00498888999281",
            };

            _purchaseFacade.PurchaseItem("Falcon 9", "happybirthday", 2, "114.00ˆ", purchaseInfo);
        }

        [Test]
        public void PurchaseSaturnVWithFacade()
        {
            var purchaseInfo = new PurchaseInfo()
            {
                Email = "info@berlinspaceflowers.com",
                FirstName = "John",
                LastName = "Atanasov",
                Company = "Space Flowers",
                Country = "Germany",
                Address1 = "1 Willi Brandt Avenue Tiergarten",
                Address2 = "Lützowplatz 17",
                City = "Berlin",
                Zip = "10115",
                Phone = "+00498888999281",
            };

            _purchaseFacade.PurchaseItem("Saturn V", "happybirthday", 3, "355.00ˆ", purchaseInfo);
        }
    }
}