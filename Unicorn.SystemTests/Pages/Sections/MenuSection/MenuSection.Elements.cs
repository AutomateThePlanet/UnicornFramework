using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.Sections
{
    public partial class MenuSection : Page
    {
        public Anchor HomeLink => ElementCreateService.CreateByLinkText<Anchor>("Home");
        public Anchor BlogLink => ElementCreateService.CreateByLinkText<Anchor>("Blog");
        public Anchor CartLink => ElementCreateService.CreateByLinkText<Anchor>("Cart");
        public Anchor CheckoutLink => ElementCreateService.CreateByLinkText<Anchor>("Checkout");
        public Anchor MyAccountLink => ElementCreateService.CreateByLinkText<Anchor>("My Account");
        public Anchor PromotionsLink => ElementCreateService.CreateByLinkText<Anchor>("Promotions");
    }
}
