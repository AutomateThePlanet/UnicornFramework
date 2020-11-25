using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.Sections.SearchSection
{
    public partial class SearchSection : Page
    {
        public void Search(string searchFor)
        {
            SearchField.TypeText(searchFor);
        }
    }
}
