using System;
using Unicorn.NUnit;

namespace Unicorn.Web
{
    public class WebTest : BaseTest
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
