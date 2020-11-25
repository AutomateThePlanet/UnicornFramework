using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;

namespace Unicorn.SystemTests.Pages.CheckoutPage
{
    public partial class CheckoutPage
    {
        public TextField BillingFirstName => ElementCreateService.CreateById<TextField>("billing_first_name");
        public TextField BillingLastName => ElementCreateService.CreateById<TextField>("billing_last_name");
        public TextField BillingCompany => ElementCreateService.CreateById<TextField>("billing_company");
        public Button BillingCountryWrapper => ElementCreateService.CreateById<Button>("select2-billing_country-container");
        public TextField BillingCountryFilter => ElementCreateService.CreateByClass<TextField>("select2-search__field");
        public TextField BillingAddress1 => ElementCreateService.CreateById<TextField>("billing_address_1");
        public TextField BillingAddress2 => ElementCreateService.CreateById<TextField>("billing_address_2");
        public TextField BillingCity => ElementCreateService.CreateById<TextField>("billing_city");
        public TextField BillingZip => ElementCreateService.CreateById<TextField>("billing_postcode");
        public TextField BillingPhone => ElementCreateService.CreateById<TextField>("billing_phone");
        public TextField BillingEmail => ElementCreateService.CreateById<TextField>("billing_email");
        public CheckBox CreateAccountCheckBox => ElementCreateService.CreateById<CheckBox>("createaccount");
        public RadioButton CheckPaymentsRadioButton => ElementCreateService.CreateByCss<RadioButton>("[for*='payment_method_cheque']");
        public Button PlaceOrderButton => ElementCreateService.CreateById<Button>("place_order");
        public Span ReceivedMessage => ElementCreateService.CreateByXPath<Span>("place_order");

        public Button GetCountryOptionByName(string countryName)
        {
            return ElementCreateService.CreateByXPath<Button>($"//*[contains(text(),'{countryName}')]");
        }
    }
}
