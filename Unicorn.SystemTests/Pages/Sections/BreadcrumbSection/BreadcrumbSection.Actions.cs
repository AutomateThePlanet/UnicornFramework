using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.Sections
{
    public partial class BreadcrumbSection : Page
    {
        public void OpenBreadcrumbItem(string itemToOpen)
        {
            Breadcrumb.CreateByLinkText<Anchor>(itemToOpen).Click();
        }
    }
}
