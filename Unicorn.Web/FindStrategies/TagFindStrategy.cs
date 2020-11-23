using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public class TagFindStrategy : FindStrategy
    {
        public TagFindStrategy(string value)
            : base(value)
        {
        }

        public override By Convert() => By.TagName(Value);
    }
}
