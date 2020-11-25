using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.SystemTests.Pages.Sections;
using Unicorn.SystemTests.Pages.Sections.SearchSection;
using Unicorn.SystemTests.Pages.Sections.ViewCartSection;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages
{
    public abstract class NavigatableShopPage : NavigatablePage
    {
        public MenuSection MainMenu => new MenuSection();
        public SearchSection SearchProduct => new SearchSection();
        public ViewCartSection ViewCart => new ViewCartSection();
    }
}
