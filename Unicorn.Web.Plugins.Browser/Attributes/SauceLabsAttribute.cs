using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.Enums;
using Unicorn.Web.Model;

namespace Unicorn.Web.Plugins
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class SauceLabsAttribute : ExecutionBrowserAttribute
    {
        public SauceLabsAttribute(Web.Browser browser, string browserVersion, string platform, bool recordVideo, bool recordScreenshot, string screenResolution, BrowserBehavior browserBehavior)
            : base(browser, browserBehavior)
        {
            BrowserConfiguration.ExecutionType = ExecutionType.SauceLabs;
            BrowserVersion = browserVersion;
            Platform = platform;
            RecordVideo = recordVideo;
            RecordScreenshot = recordScreenshot;
            ScreenResolution = screenResolution;
        }

        public string BrowserVersion { get; }

        public string Platform { get; }

        public bool RecordVideo { get; set; }

        public bool RecordScreenshot { get; set; }

        public string ScreenResolution { get; set; }
    }
}
