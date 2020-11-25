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
            Assert.AreEqual(TotalSpan.InnerText, expectedTotal);
        }

        public void AssertMessageNotification(string expectedMessage)
        {
            Assert.AreEqual(MessageAlert.InnerText, expectedMessage);
        }

        public void AssertCouponAppliedSuccessfully()
        {
            Assert.AreEqual("Coupon code applied successfully.", MessageAlert.InnerText);
        }
    }
}
