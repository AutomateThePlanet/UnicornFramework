using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.FindStrategies;

namespace Unicorn.Web.Services
{
    public class LoggingDriverDecorator : BaseDriverDecorator
    {
        public LoggingDriverDecorator(IDriver driver)
            : base(driver)
        {
        }

        public void AddCookie(string cookieName, string cookieValue, string path = "/")
        {
            Console.WriteLine("call AddCookie");
            base.AddCookie(cookieName, cookieValue, path);
        }

        public IInteractionsService ClickAndHold(Element element)
        {
            Console.WriteLine("call AddCookie");
            return base.ClickAndHold(element);
        }

        public List<TElement> CreateAll<TElement>(FindStrategy findStrategy)
            where TElement : Element
        {
            Console.WriteLine("call CreateAll");
            return base.CreateAll<TElement>(findStrategy);
        }

        public void DeleteAllCookies()
        {
            base.DeleteAllCookies();
        }

        public void DeleteCookie(string cookieName)
        {
            base.DeleteCookie(cookieName);
        }

        public IInteractionsService DoubleClick(Element element)
        {
            return base.DoubleClick(element);
        }

        public IInteractionsService DragAndDrop(Element sourceElement, Element destinationElement)
        {
            return base.DragAndDrop(sourceElement, destinationElement);
        }

        public object Execute(string script)
        {
            return base.Execute(script);
        }

        public List<Cookie> GetAllCookies()
        {
            return base.GetAllCookies();
        }

        public string GetCookie(string cookieName)
        {
            return base.GetCookie(cookieName);
        }

        public void GoToUrl(string url)
        {
            base.GetCookie(url);
        }

        public void Handle(Action<IAlert> action = null, DialogButton dialogButton = DialogButton.Ok)
        {
            base.Handle(action, dialogButton);
        }

        public IInteractionsService MoveToElement(Element element)
        {
            return base.MoveToElement(element);
        }

        public void Perform()
        {
            base.Perform();
        }

        public IInteractionsService Release()
        {
            return base.Release();
        }

        public void WaitForAjax()
        {
            base.WaitForAjax();
        }

        public void WaitUntilPageLoadsCompletely()
        {
            base.WaitUntilPageLoadsCompletely();
        }
    }
}
