using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Components.Core
{
    public class Button : Element
    {
        public string InnerText => WrappedElement.Text;
        public string Value => WrappedElement.GetAttribute("value");
        public bool IsDisabled => !WrappedElement.Enabled;

        public void Click()
        {
            WrappedElement.Click();
        }
    }
}
