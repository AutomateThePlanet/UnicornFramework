using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.SystemTests.Pages.Sections;
using Unicorn.SystemTests.Pages.Sections.SearchSection;
using Unicorn.SystemTests.Pages.Sections.ViewCartSection;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.CheckoutPage
{
    public partial class CheckoutPage : NavigatableShopPage
    {
        public override string Url => "http://demos.bellatrix.solutions/cart/";

        public override void WaitForPageToLoad()
        {
            BillingFirstName.ToExists().WaitToBe();
        }

        public BreadcrumbSection Breadcrumb => new BreadcrumbSection();

        public void FillBillingInfo(PurchaseInfo purchaseInfo)
        {
            BillingFirstName.TypeText(purchaseInfo.FirstName);
            BillingLastName.TypeText(purchaseInfo.LastName);
            BillingCompany.TypeText(purchaseInfo.Company);
            BillingCountryWrapper.Click();
            BillingCountryFilter.TypeText(purchaseInfo.Country);
            GetCountryOptionByName(purchaseInfo.Country).Click();
            BillingAddress1.TypeText(purchaseInfo.Address1);
            BillingAddress2.TypeText(purchaseInfo.Address2);
            BillingCity.TypeText(purchaseInfo.City);
            BillingZip.TypeText(purchaseInfo.Zip);
            BillingPhone.TypeText(purchaseInfo.Phone);
            BillingEmail.TypeText(purchaseInfo.Email);
            if (purchaseInfo.ShouldCreateAccount)
            {
                CreateAccountCheckBox.Check();
            }

            if (purchaseInfo.ShouldCheckPayment)
            {
                CheckPaymentsRadioButton.Click();
            }

            PlaceOrderButton.Click();
            BrowserService.WaitForAjax();
        }
    }
}
