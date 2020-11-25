using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.Sections.SearchSection
{
    public partial class SearchSection : Page
    {
        public TextField SearchField => ElementCreateService.CreateById<TextField>("woocommerce-product-search-field-0");
    }
}
