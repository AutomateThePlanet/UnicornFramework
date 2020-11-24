using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.Enums;
using Unicorn.Web.Model;

namespace Unicorn.Web.Plugins
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class ExecutionBrowserAttribute : Attribute
    {
        public ExecutionBrowserAttribute(Web.Browser browser, BrowserBehavior browserBehavior)
        {
            BrowserConfiguration = new BrowserConfiguration(browser, browserBehavior);
        }

        public BrowserConfiguration BrowserConfiguration { get; set; }
    }
}
