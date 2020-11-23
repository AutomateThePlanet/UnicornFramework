using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : INavigationService
    {
        public Uri Url => throw new NotImplementedException();

        public void GoToUrl(string url) => throw new NotImplementedException();
    }
}
