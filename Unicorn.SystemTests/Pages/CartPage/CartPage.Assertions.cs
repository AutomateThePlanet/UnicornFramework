using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.SystemTests.Pages.CartPage
{
    public partial class CartPage
    {
        public void AssertTotalPrice(string expectedTotal)
        {
            BrowserService.WaitForAjax();
            Assert.AreEqual(TotalSpan.InnerText, expectedTotal);
        }

        public void AssertMessageNotification(string expectedMessage)
        {
            BrowserService.WaitForAjax();
            Assert.AreEqual(MessageAlert.InnerText, expectedMessage);
        }

        public void AssertCouponAppliedSuccessfully()
        {
            BrowserService.WaitForAjax();
            Assert.AreEqual("Coupon code applied successfully.", MessageAlert.InnerText);
        }
    }
}
