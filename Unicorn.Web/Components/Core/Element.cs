using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.FindStrategies;

namespace Unicorn.Web
{
    // TODO: implement IElementCreateService here.
    public abstract class Element : IElementCreateService
    {
        protected IWebDriver Driver;

        public Element()
        {
            Driver = ServiceContainer.Resolve<IWebDriver>();
        }

        public By By { get; set; }
        public IWebElement WrappedElement { get; set; }

        public TElement Create<TElement>(FindStrategy findStrategy)
            where TElement : Element
        {
            TElement element = Activator.CreateInstance<TElement>();
            element.By = findStrategy.Convert();
            element.WrappedElement = WrappedElement;

            return element;
        }

        public List<TElement> CreateAll<TElement>(FindStrategy findStrategy)
            where TElement : Element => throw new NotImplementedException();

        public List<TElement> CreateAllByClass<TElement>(string cssClass)
            where TElement : Element => throw new NotImplementedException();

        public List<TElement> CreateAllByCss<TElement>(string css)
            where TElement : Element => throw new NotImplementedException();

        public List<TElement> CreateAllById<TElement>(string id)
            where TElement : Element => throw new NotImplementedException();

        public List<TElement> CreateAllByLinkText<TElement>(string linkText)
            where TElement : Element => throw new NotImplementedException();
        public List<TElement> CreateAllByTag<TElement>(string tag)
            where TElement : Element => throw new NotImplementedException();

        public List<TElement> CreateAllByXPath<TElement>(string xpath)
            where TElement : Element => throw new NotImplementedException();

        public TElement CreateByClass<TElement>(string cssClass)
            where TElement : Element
        {
            return Create<TElement>(new ClassFindStrategy(cssClass));
        }

        public TElement CreateByCss<TElement>(string css)
            where TElement : Element
        {
            return Create<TElement>(new CssFindStrategy(css));
        }

        public TElement CreateById<TElement>(string id)
            where TElement : Element
        {
            return Create<TElement>(new IdFindStrategy(id));
        }

        public TElement CreateByLinkText<TElement>(string linkText)
            where TElement : Element
        {
            return Create<TElement>(new LinkTextFindStrategy(linkText));
        }

        public TElement CreateByTag<TElement>(string tag)
            where TElement : Element
        {
            return Create<TElement>(new TagFindStrategy(tag));
        }

        public TElement CreateByXPath<TElement>(string xpath)
            where TElement : Element
        {
            return Create<TElement>(new XPathFindStrategy(xpath));
        }
    }
}
