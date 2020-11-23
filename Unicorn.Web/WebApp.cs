using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.App;

namespace Unicorn.Web
{
    public class WebApp : BaseApp
    {
        // TODO: add properties to all Driver interfaces - browserService, cookiesService, navigationService.
        public void AddBrowserOptions<TOption>()
            where TOption : class
        {
        }

        public TPage Create<TPage>()
            where TPage : class
        {
            return default;
        }

        public TPage GoTo<TPage>()
           where TPage : class
        {
            return default;
        }
    }
}
