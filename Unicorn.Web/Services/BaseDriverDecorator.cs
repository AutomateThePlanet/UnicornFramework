using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.FindStrategies;

namespace Unicorn.Web.Services
{
    public class BaseDriverDecorator : IDriver
    {
        protected readonly IDriver Driver;

        public BaseDriverDecorator(IDriver driver)
        {
            Driver = driver;
        }

        public Uri Url => Driver?.Url;

        public void AddCookie(string cookieName, string cookieValue, string path = "/")
        {
            Driver?.AddCookie(cookieName, cookieValue, path);
        }

        public IInteractionsService ClickAndHold(Element element)
        {
            return Driver?.ClickAndHold(element);
        }

        public void DeleteAllCookies()
        {
            Driver?.DeleteAllCookies();
        }

        public void DeleteCookie(string cookieName)
        {
            Driver?.DeleteCookie(cookieName);
        }

        public IInteractionsService DoubleClick(Element element)
        {
            return Driver?.DoubleClick(element);
        }

        public IInteractionsService DragAndDrop(Element sourceElement, Element destinationElement)
        {
            return Driver?.DragAndDrop(sourceElement, destinationElement);
        }

        public object Execute(string script)
        {
            return Driver?.Execute(script);
        }

        public List<Cookie> GetAllCookies()
        {
            return Driver?.GetAllCookies();
        }

        public string GetCookie(string cookieName)
        {
            return Driver?.GetCookie(cookieName);
        }

        public void GoToUrl(string url)
        {
            Driver?.GetCookie(url);
        }

        public void Handle(Action<IAlert> action = null, DialogButton dialogButton = DialogButton.Ok)
        {
            Driver?.Handle(action, dialogButton);
        }

        public IInteractionsService MoveToElement(Element element)
        {
            return Driver?.MoveToElement(element);
        }

        public void Perform()
        {
            Driver?.Perform();
        }

        public IInteractionsService Release()
        {
            return Driver?.Release();
        }

        public void WaitForAjax()
        {
            Driver?.WaitForAjax();
        }

        public void WaitUntilPageLoadsCompletely()
        {
            Driver?.WaitUntilPageLoadsCompletely();
        }

        public TElement CreateById<TElement>(string id)
            where TElement : Element
            => Driver?.CreateById<TElement>(id);

        public TElement CreateByXPath<TElement>(string xpath)
            where TElement : Element
            => Driver?.CreateByXPath<TElement>(xpath);

        public TElement CreateByTag<TElement>(string tag)
            where TElement : Element
            => Driver?.CreateByTag<TElement>(tag);

        public TElement CreateByClass<TElement>(string cssClass)
            where TElement : Element
            => Driver?.CreateByClass<TElement>(cssClass);

        public TElement CreateByCss<TElement>(string css)
            where TElement : Element
            => Driver?.CreateByCss<TElement>(css);

        public TElement CreateByLinkText<TElement>(string linkText)
            where TElement : Element
            => Driver?.CreateByLinkText<TElement>(linkText);

        public List<TElement> CreateAllById<TElement>(string id)
            where TElement : Element
            => Driver?.CreateAllById<TElement>(id);

        public List<TElement> CreateAllByXPath<TElement>(string xpath)
            where TElement : Element
            => Driver?.CreateAllByXPath<TElement>(xpath);

        public List<TElement> CreateAllByTag<TElement>(string tag)
            where TElement : Element
            => Driver?.CreateAllByTag<TElement>(tag);

        public List<TElement> CreateAllByClass<TElement>(string cssClass)
            where TElement : Element
            => Driver?.CreateAllByClass<TElement>(cssClass);

        public List<TElement> CreateAllByCss<TElement>(string css)
            where TElement : Element
            => Driver?.CreateAllByCss<TElement>(css);

        public List<TElement> CreateAllByLinkText<TElement>(string linkText)
            where TElement : Element
            => Driver?.CreateAllByLinkText<TElement>(linkText);

        public List<TElement> CreateAll<TElement>(FindStrategy findStrategy)
            where TElement : Element
            => Driver?.CreateAll<TElement>(findStrategy);

        public TElement Create<TElement>(FindStrategy findStrategy)
            where TElement : Element
             => Driver?.Create<TElement>(findStrategy);
    }
}
