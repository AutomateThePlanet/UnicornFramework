﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Components.Core
{
    public class Div : Element
    {
        public string InnerText => WrappedElement.Text;
        public string InnerHtml => WrappedElement.GetAttribute("innerHTML");
    }
}