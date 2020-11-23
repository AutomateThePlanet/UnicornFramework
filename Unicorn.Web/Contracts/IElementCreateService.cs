using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Web.FindStrategies;

namespace Unicorn.Web
{
    public interface IElementCreateService
    {
        TElement CreateById<TElement>(string id)
            where TElement : Element;
        TElement CreateByXPath<TElement>(string xpath)
            where TElement : Element;
        TElement CreateByTag<TElement>(string tag)
            where TElement : Element;
        TElement CreateByClass<TElement>(string cssClass)
            where TElement : Element;
        TElement CreateByCss<TElement>(string css)
            where TElement : Element;
        TElement CreateByLinkText<TElement>(string linkText)
            where TElement : Element;
        List<TElement> CreateAllById<TElement>(string id)
            where TElement : Element;
        List<TElement> CreateAllByXPath<TElement>(string xpath)
            where TElement : Element;
        List<TElement> CreateAllByTag<TElement>(string tag)
            where TElement : Element;
        List<TElement> CreateAllByClass<TElement>(string cssClass)
            where TElement : Element;
        List<TElement> CreateAllByCss<TElement>(string css)
            where TElement : Element;
        List<TElement> CreateAllByLinkText<TElement>(string linkText)
            where TElement : Element;

        List<TElement> CreateAll<TElement>(FindStrategy findStrategy)
            where TElement : Element;
        TElement Create<TElement>(FindStrategy findStrategy)
            where TElement : Element;
    }
}
