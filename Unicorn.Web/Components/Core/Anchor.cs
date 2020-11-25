using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public class Anchor : Element
    {
        public string InnerText => WrappedElement.Text;
        public string Href => WrappedElement.GetAttribute("href");
        public bool IsDisabled => !WrappedElement.Enabled;

        public void Click()
        {
            WrappedElement.Click();
        }
    }
}
