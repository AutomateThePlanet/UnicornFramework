using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public class IdFindStrategy : FindStrategy
    {
        public IdFindStrategy(string value)
            : base(value)
        {
        }

        public override By Convert() => By.Id(Value);
    }
}
