using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.App;
using Unicorn.Web.Pages;
using Unicorn.Web.Services;

namespace Unicorn.Web
{
    public class WebApp : BaseApp
    {
        private IDriver _driver;

        public WebApp()
        {
            var webCoreDriver = ServiceContainer.Resolve<WebCoreDriver>();
            _driver = new LoggingDriverDecorator(webCoreDriver);
        }

        public IElementCreateService ElementCreateService => _driver;
        public IBrowserService BrowserService => _driver;
        public INavigationService NavigationService => _driver;
        public ICookiesService CookiesService => _driver;
        public IDialogService DialogService => _driver;
        public IInteractionsService InteractionsService => _driver;
        public IJavaScriptService JavaScriptService => _driver;

        public void AddBrowserOptions<TOption>(TOption customOptions)
            where TOption : class
        {
            // TODO: change guid with full test class name.
            ServiceContainer.RegisterInstance(customOptions, Guid.NewGuid().ToString());
        }

        public TPage Create<TPage>()
            where TPage : Page
        {
            return ServiceContainer.Resolve<TPage>();
        }

        public TPage GoTo<TPage>()
           where TPage : NavigatablePage
        {
            var page = ServiceContainer.Resolve<TPage>();
            page.Open();
            return page;
        }
    }
}
