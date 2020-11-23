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

        public List<Element> CreateAll(FindStrategy findStrategy)
        {
            return Driver?.CreateAll(findStrategy);
        }

        public List<Element> CreateAllByClass(string cssClass)
        {
            return Driver?.CreateAllByClass(cssClass);
        }

        public List<Element> CreateAllByCss(string css)
        {
            return Driver?.CreateAllByCss(css);
        }

        public List<Element> CreateAllById(string id)
        {
            return Driver?.CreateAllById(id);
        }

        public List<Element> CreateAllByLinkText(string linkText)
        {
            return Driver?.CreateAllByLinkText(linkText);
        }

        public List<Element> CreateAllByTag(string tag)
        {
            return Driver?.CreateAllByTag(tag);
        }

        public List<Element> CreateAllByXPath(string xpath)
        {
            return Driver?.CreateAllByXPath(xpath);
        }

        public Element CreateByClass(string cssClass)
        {
            return Driver?.CreateByClass(cssClass);
        }

        public Element CreateByCss(string css)
        {
            return Driver?.CreateByCss(css);
        }

        public Element CreateById(string id)
        {
            return Driver?.CreateById(id);
        }

        public Element CreateByLinkText(string linkText)
        {
            return Driver?.CreateByLinkText(linkText);
        }

        public Element CreateByTag(string tag)
        {
            return Driver?.CreateByTag(tag);
        }

        public Element CreateByXPath(string xpath)
        {
            return Driver?.CreateByXPath(xpath);
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

        public Element Find(FindStrategy findStrategy)
        {
            return Driver?.Find(findStrategy);
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

        public void Wait(Element element, WaitStrategy waitStrategy)
        {
            Driver?.Wait(element, waitStrategy);
        }

        public void WaitForAjax()
        {
            Driver?.WaitForAjax();
        }

        public void WaitUntilPageLoadsCompletely()
        {
            Driver?.WaitUntilPageLoadsCompletely();
        }
    }
}
