using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.WaitStrategies
{
    public class ToBeVisibleWaitStrategy : WaitStrategy
    {
        public ToBeVisibleWaitStrategy(int? timeoutIntervalSeconds = null, int? sleepIntervalSeconds = null)
            : base(timeoutIntervalSeconds, sleepIntervalSeconds)
        {
            int timeoutSeconds = timeoutIntervalSeconds ?? ConfigurationService.GetSection<WebSettings>().TimeoutSettings.ElementToBeVisibleTimeout;
            TimeoutInterval = TimeSpan.FromSeconds(timeoutSeconds);
        }

        public override void WaitUntil(ISearchContext searchContext, IWebDriver driver, By by)
        {
            WaitUntil(s => IsElementVisible(searchContext, by), driver);
        }

        private bool IsElementVisible(ISearchContext searchContext, By by)
        {
            var element = searchContext.FindElement(by);
            return element != null && element.Displayed;
        }
    }
}
