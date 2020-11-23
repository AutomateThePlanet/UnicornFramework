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

        public List<Element> CreateAll(FindStrategy findStrategy)
        {
            Console.WriteLine("call CreateAll");
            return base.CreateAll(findStrategy);
        }

        public List<Element> CreateAllByClass(string cssClass)
        {
            Console.WriteLine($"call {nameof(CreateAllByClass)}");
            return base.CreateAllByClass(cssClass);
        }

        public List<Element> CreateAllByCss(string css)
        {
            Console.WriteLine($"call {nameof(CreateAllByCss)}");
            return base.CreateAllByCss(css);
        }

        public List<Element> CreateAllById(string id)
        {
            Console.WriteLine($"call {nameof(CreateAllById)}");
            return base.CreateAllById(id);
        }

        public List<Element> CreateAllByLinkText(string linkText)
        {
            Console.WriteLine($"call {nameof(CreateAllByLinkText)}");
            return base.CreateAllByLinkText(linkText);
        }

        public List<Element> CreateAllByTag(string tag)
        {
            Console.WriteLine($"call {nameof(CreateAllByTag)}");
            return base.CreateAllByTag(tag);
        }

        public List<Element> CreateAllByXPath(string xpath)
        {
            Console.WriteLine($"call {nameof(CreateAllByXPath)}");
            return base.CreateAllByXPath(xpath);
        }

        public Element CreateByClass(string cssClass)
        {
            Console.WriteLine($"call {nameof(CreateByClass)}");
            return base.CreateByClass(cssClass);
        }

        public Element CreateByCss(string css)
        {
            Console.WriteLine($"call {nameof(CreateByCss)}");
            return base.CreateByCss(css);
        }

        public Element CreateById(string id)
        {
            Console.WriteLine($"call {nameof(CreateById)}");
            return base.CreateById(id);
        }

        public Element CreateByLinkText(string linkText)
        {
            Console.WriteLine($"call {nameof(CreateByLinkText)}");
            return base.CreateByLinkText(linkText);
        }

        public Element CreateByTag(string tag)
        {
            Console.WriteLine($"call {nameof(CreateByTag)}");
            return base.CreateByTag(tag);
        }

        public Element CreateByXPath(string xpath)
        {
            return base.CreateByXPath(xpath);
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

        public Element Find(FindStrategy findStrategy)
        {
            return base.Create(findStrategy);
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

        public void Wait(Element element, WaitStrategy waitStrategy)
        {
            base.Wait(element, waitStrategy);
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
