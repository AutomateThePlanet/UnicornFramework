using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : IJavaScriptService
    {
        public object Execute(string script)
        {
            return ((IJavaScriptExecutor)_webDriver).ExecuteScript(script);
        }
    }
}
