using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Components.Core
{
    public class Image : Element
    {
        public string Src => WrappedElement.GetAttribute("src");

        public void Click()
        {
            WrappedElement.Click();
        }
    }
}
