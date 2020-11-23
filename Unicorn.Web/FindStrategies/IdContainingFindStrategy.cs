using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public class IdContainingFindStrategy : FindStrategy
    {
        public IdContainingFindStrategy(string value)
            : base(value)
        {
        }

        public override By Convert() => By.CssSelector($"[id*='{Value}']");
    }
}
