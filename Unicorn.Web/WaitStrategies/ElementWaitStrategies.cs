using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web;
using Unicorn.Web.WaitStrategies;

namespace Unicorn
{
    public static class ElementWaitStrategies
    {
        public static TElement ToExists<TElement>(
            this TElement element,
            int? timeoutInterval = null,
            int? sleepInterval = null)
            where TElement : Element
        {
            var toExistWaitStrategy = new ToExistsWaitStrategy(timeoutInterval, sleepInterval);
            element.EnsureState(toExistWaitStrategy);
            return element;
        }

        public static TElement ToBeVisible<TElement>(
            this TElement element,
            int? timeoutInterval = null,
            int? sleepInterval = null)
            where TElement : Element
        {
            var toBeVisibleWaitStrategy = new ToBeVisibleWaitStrategy(timeoutInterval, sleepInterval);
            element.EnsureState(toBeVisibleWaitStrategy);
            return element;
        }

        public static TElement ToBeClickable<TElement>(
           this TElement element,
           int? timeoutInterval = null,
           int? sleepInterval = null)
           where TElement : Element
        {
            var toBeClickableWaitStrategy = new ToBeClickableWaitStrategy(timeoutInterval, sleepInterval);
            element.EnsureState(toBeClickableWaitStrategy);
            return element;
        }
    }
}
