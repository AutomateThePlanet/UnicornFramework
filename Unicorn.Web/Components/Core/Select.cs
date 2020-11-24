using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Components.Core
{
    public class Select : Element
    {
        public string Value => WrappedElement.GetAttribute("value");
        public bool IsDisabled => !WrappedElement.Enabled;

        public void SelectByText(string text)
        {
            new SelectElement(WrappedElement).SelectByText(text);
        }

        public void SelectByValue(string value)
        {
            new SelectElement(WrappedElement).SelectByValue(value);
        }

        public void SelectByIndex(int index)
        {
            new SelectElement(WrappedElement).SelectByIndex(index);
        }
    }
}
