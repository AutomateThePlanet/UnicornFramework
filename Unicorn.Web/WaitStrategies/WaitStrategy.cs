using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public abstract class WaitStrategy
    {
        private const int DEFAULT_TIMEOUT = 30;

        protected WaitStrategy(int? timeoutIntervalSeconds = null, int? sleepIntervalSeconds = null)
        {
            TimeoutInterval = TimeSpan.FromSeconds(timeoutIntervalSeconds ?? DEFAULT_TIMEOUT);
            SleepInterval = TimeSpan.FromSeconds(sleepIntervalSeconds ?? ConfigurationService.GetSection<TimeoutSettings>().SleepInterval);
        }

        protected TimeSpan TimeoutInterval { get; set; }
        protected TimeSpan SleepInterval { get; set; }

        public abstract void WaitUntil(ISearchContext searchContext, IWebDriver driver, By by);

        protected void WaitUntil(Func<ISearchContext, bool> waitCondition, IWebDriver driver)
        {
            var webDriverWait = new WebDriverWait(new SystemClock(), driver, TimeoutInterval, SleepInterval);
            webDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            webDriverWait.Until(waitCondition);
        }
    }
}
