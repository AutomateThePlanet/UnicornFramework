using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Pages
{
    public abstract class Page
    {
        public Page()
        {
            var driver = ServiceContainer.Resolve<IDriver>();
            ElementCreateService = driver;
            BrowserService = driver;
        }

        protected IElementCreateService ElementCreateService { get; }
        protected IBrowserService BrowserService { get; }
    }
}
