using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : IInteractionsService
    {
        public IInteractionsService ClickAndHold(Element element) => throw new NotImplementedException();
        public IInteractionsService DoubleClick(Element element) => throw new NotImplementedException();
        public IInteractionsService DragAndDrop(Element sourceElement, Element destinationElement) => throw new NotImplementedException();
        public IInteractionsService MoveToElement(Element element) => throw new NotImplementedException();
        public void Perform() => throw new NotImplementedException();
        public IInteractionsService Release() => throw new NotImplementedException();
    }
}
