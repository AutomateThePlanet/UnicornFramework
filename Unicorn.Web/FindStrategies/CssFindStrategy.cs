using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public class CssFindStrategy : FindStrategy
    {
        public CssFindStrategy(string value)
            : base(value)
        {
        }

        public override By Convert() => By.CssSelector(Value);
    }
}
