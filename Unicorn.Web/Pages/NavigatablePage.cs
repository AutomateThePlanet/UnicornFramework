using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Pages
{
    public abstract class NavigatablePage : Page
    {
        public NavigatablePage()
        {
            NavigationService = ServiceContainer.Resolve<IDriver>();
        }

        protected INavigationService NavigationService { get; }

        public abstract string Url { get; }

        public void Open()
        {
            NavigationService.GoToUrl(Url);
            WaitForPageToLoad();
        }

        public abstract void WaitForPageToLoad();
    }
}
