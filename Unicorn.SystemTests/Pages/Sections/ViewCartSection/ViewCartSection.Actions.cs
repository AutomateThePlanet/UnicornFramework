using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.Sections.ViewCartSection
{
    public partial class ViewCartSection : Page
    {
        public string GetCurrentAmount()
        {
            return CartAmount.InnerText;
        }

        public void OpenCart()
        {
            CartIcon.Click();
        }
    }
}
