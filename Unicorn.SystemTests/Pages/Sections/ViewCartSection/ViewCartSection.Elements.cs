using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.Sections.ViewCartSection
{
    public partial class ViewCartSection : Page
    {
        public Web.Span CartAmount => ElementCreateService.CreateByClass<Web.Span>("amount");
        public Anchor CartIcon => ElementCreateService.CreateByClass<Anchor>("cart-contents");
    }
}
