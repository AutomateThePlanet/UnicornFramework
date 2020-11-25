using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public class Span : Element
    {
        public string InnerText => WrappedElement.Text;
        public string InnerHtml => WrappedElement.GetAttribute("innerHTML");
    }
}
