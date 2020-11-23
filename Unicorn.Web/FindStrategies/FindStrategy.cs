using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.FindStrategies
{
    public abstract class FindStrategy
    {
        protected FindStrategy(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public abstract OpenQA.Selenium.By Convert();
    }
}
