using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Components.Core
{
    public class InputFile : Element
    {
        public void Upload(string file)
        {
            WrappedElement.SendKeys(file);
        }
    }
}
