using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.SystemTests.Pages.Sections;
using Unicorn.SystemTests.Pages.Sections.SearchSection;
using Unicorn.SystemTests.Pages.Sections.ViewCartSection;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.MainPage
{
    public partial class MainPage : NavigatableShopPage
    {
        public override string Url => "http://demos.bellatrix.solutions/";

        public override void WaitForPageToLoad()
        {
            AddToCartFalcon9.ToExists().WaitToBe();
        }

        public void AddRocketToShoppingCart(string rocketName)
        {
            Open();
            GetProductBoxByName(rocketName).Click();
            BrowserService.WaitForAjax();
            ViewCartButton.Click();
        }
    }
}
