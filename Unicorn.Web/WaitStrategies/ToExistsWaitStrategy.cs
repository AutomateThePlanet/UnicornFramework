using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.WaitStrategies
{
    public class ToExistsWaitStrategy : WaitStrategy
    {
        public ToExistsWaitStrategy(int? timeoutIntervalSeconds = null, int? sleepIntervalSeconds = null)
            : base(timeoutIntervalSeconds, sleepIntervalSeconds)
        {
            int timeoutSeconds = timeoutIntervalSeconds ?? ConfigurationService.GetSection<WebSettings>().TimeoutSettings.ElementToExistTimeout;
            TimeoutInterval = TimeSpan.FromSeconds(timeoutSeconds);
        }

        public override void WaitUntil(ISearchContext searchContext, IWebDriver driver, By by)
        {
            WaitUntil(s => DoesElementExists(searchContext, by), driver);
        }

        private bool DoesElementExists(ISearchContext searchContext, By by)
        {
            return searchContext.FindElement(by) != null;
        }
    }
}
