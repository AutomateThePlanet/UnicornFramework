using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.SystemTests.Pages.CheckoutPage
{
    public partial class CheckoutPage
    {
        public void AssertOrderReceived()
        {
            Assert.AreEqual(ReceivedMessage.InnerText, "Order received");
        }
    }
}
