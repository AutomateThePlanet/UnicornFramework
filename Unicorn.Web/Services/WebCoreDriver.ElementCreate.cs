using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.FindStrategies;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : IElementCreateService
    {
        public List<Element> CreateAll(FindStrategy findStrategy) => throw new NotImplementedException();
        public List<Element> CreateAllByClass(string cssClass) => throw new NotImplementedException();
        public List<Element> CreateAllByCss(string css) => throw new NotImplementedException();
        public List<Element> CreateAllById(string id) => throw new NotImplementedException();
        public List<Element> CreateAllByLinkText(string linkText) => throw new NotImplementedException();
        public List<Element> CreateAllByTag(string tag) => throw new NotImplementedException();
        public List<Element> CreateAllByXPath(string xpath) => throw new NotImplementedException();
        public Element CreateByClass(string cssClass) => throw new NotImplementedException();
        public Element CreateByCss(string css) => throw new NotImplementedException();
        public Element CreateById(string id) => throw new NotImplementedException();
        public Element CreateByLinkText(string linkText) => throw new NotImplementedException();
        public Element CreateByTag(string tag) => throw new NotImplementedException();
        public Element CreateByXPath(string xpath) => throw new NotImplementedException();
        public Element Find(FindStrategy findStrategy) => throw new NotImplementedException();
    }
}
