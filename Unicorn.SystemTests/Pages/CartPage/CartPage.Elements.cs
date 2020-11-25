using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;

namespace Unicorn.SystemTests.Pages.CartPage
{
    public partial class CartPage
    {
        public TextField CouponCodeTextField => ElementCreateService.CreateById<TextField>("coupon_code");
        public Button ApplyCouponButton => ElementCreateService.CreateByCss<Button>("[value*='Apply coupon']");
        public TextField QuantityBox => ElementCreateService.CreateByCss<TextField>("[class*='input-text qty text']");
        public Button UpdateCart => ElementCreateService.CreateByCss<Button>("[value*='Update cart']");
        public Div MessageAlert => ElementCreateService.CreateByCss<Div>("[class*='woocommerce-message']");
        public Span TotalSpan => ElementCreateService.CreateByXPath<Span>("//*[@class='order-total']//span");
        public Button ProceedToCheckout => ElementCreateService.CreateByCss<Button>("[class*='checkout-button button alt wc-forward']");
    }
}
