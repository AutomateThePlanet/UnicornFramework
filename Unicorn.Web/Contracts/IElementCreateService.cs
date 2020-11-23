using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.FindStrategies;

namespace Unicorn.Web
{
    public interface IElementCreateService
    {
        Element CreateById(string id);
        Element CreateByXPath(string xpath);
        Element CreateByTag(string tag);
        Element CreateByClass(string cssClass);
        Element CreateByCss(string css);
        Element CreateByLinkText(string linkText);
        List<Element> CreateAllById(string id);
        List<Element> CreateAllByXPath(string xpath);
        List<Element> CreateAllByTag(string tag);
        List<Element> CreateAllByClass(string cssClass);
        List<Element> CreateAllByCss(string css);
        List<Element> CreateAllByLinkText(string linkText);

        List<Element> CreateAll(FindStrategy findStrategy);
        Element Find(FindStrategy findStrategy);
    }
}
