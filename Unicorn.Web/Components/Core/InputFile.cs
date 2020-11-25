using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public class InputFile : Element
    {
        public void Upload(string file)
        {
            WrappedElement.SendKeys(file);
        }
    }
}
