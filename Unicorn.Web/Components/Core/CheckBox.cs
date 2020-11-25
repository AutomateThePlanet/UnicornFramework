using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public class CheckBox : Element
    {
        public bool IsChecked => WrappedElement.Selected;
        public string Value => WrappedElement.GetAttribute("value");
        public bool IsDisabled => !WrappedElement.Enabled;

        public void Check(bool isChecked = true)
        {
            if (isChecked && !WrappedElement.Selected || !isChecked && WrappedElement.Selected)
            {
                WrappedElement.Click();
            }
        }

        public void Uncheck()
        {
            Check(false);
        }
    }
}
