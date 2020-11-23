using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public class LinkTextFindStrategy : FindStrategy
    {
        public LinkTextFindStrategy(string value)
            : base(value)
        {
        }

        public override By Convert() => By.LinkText(Value);
    }
}
