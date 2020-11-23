using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public class InnerTextContainsFindStrategy : FindStrategy
    {
        public InnerTextContainsFindStrategy(string value)
            : base(value)
        {
        }

        public override By Convert() => By.XPath($"//*[contains(text(), '{Value}')]");
    }
}
