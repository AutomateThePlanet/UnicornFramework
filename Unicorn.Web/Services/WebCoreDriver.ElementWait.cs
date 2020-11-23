using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : IElementWaitService
    {
        public void Wait(Element element, WaitStrategy waitStrategy) => throw new NotImplementedException();
    }
}
