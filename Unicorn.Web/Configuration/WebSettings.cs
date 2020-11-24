using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Configuration
{
    public class WebSettings
    {
        public TimeoutSettings TimeoutSettings { get; set; }
        public BrowserSettings Chrome { get; set; }
        public BrowserSettings Firefox { get; set; }
        public BrowserSettings Edge { get; set; }
        public BrowserSettings Safari { get; set; }
    }
}
