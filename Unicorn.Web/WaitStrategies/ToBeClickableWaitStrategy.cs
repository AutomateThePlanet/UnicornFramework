using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.WaitStrategies
{
    public class ToBeClickableWaitStrategy : WaitStrategy
    {
        public ToBeClickableWaitStrategy(int? timeoutIntervalSeconds = null, int? sleepIntervalSeconds = null)
            : base(timeoutIntervalSeconds, sleepIntervalSeconds)
        {
            int timeoutSeconds = timeoutIntervalSeconds ?? ConfigurationService.GetSection<TimeoutSettings>().ElementToBeClickableTimeout;
            TimeoutInterval = TimeSpan.FromSeconds(timeoutSeconds);
        }

        public override void WaitUntil(ISearchContext searchContext, IWebDriver driver, By by)
        {
            WaitUntil(s => IsElementClickable(searchContext, by), driver);
        }

        private bool IsElementClickable(ISearchContext searchContext, By by)
        {
            var element = searchContext.FindElement(by);
            return element != null && element.Enabled;
        }
    }
}
