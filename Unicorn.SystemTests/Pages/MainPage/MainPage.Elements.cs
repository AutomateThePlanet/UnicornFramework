using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.MainPage
{
    public partial class MainPage
    {
        public Anchor AddToCartFalcon9 => ElementCreateService.CreateByCss<Anchor>("[data-product_id='28']");

        public Button ViewCartButton => ElementCreateService.CreateByCss<Button>("[class*='added_to_cart wc-forward']");

        public Anchor GetProductBoxByName(string name)
        {
            return ElementCreateService.CreateByXPath<Anchor>($"//h2[text()='{name}']/parent::a[1]");
        }
    }
}
