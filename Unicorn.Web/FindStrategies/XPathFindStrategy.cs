using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public class XPathFindStrategy : FindStrategy
    {
        public XPathFindStrategy(string value)
            : base(value)
        {
        }

        public override By Convert() => By.XPath(Value);
    }
}
