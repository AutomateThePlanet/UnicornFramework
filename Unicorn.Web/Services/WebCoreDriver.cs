using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : IDriver
    {
        private readonly IWebDriver _webDriver;
        private readonly WebDriverWait _webDriverWait;

        public WebCoreDriver(IWebDriver wrappedDriver)
        {
            _webDriver = wrappedDriver;
            var timeoutSettings = ConfigurationService.GetSection<TimeoutSettings>();
            _webDriverWait = new WebDriverWait(wrappedDriver, TimeSpan.FromSeconds(timeoutSettings.WaitForAjaxTimeout));
        }
    }
}
