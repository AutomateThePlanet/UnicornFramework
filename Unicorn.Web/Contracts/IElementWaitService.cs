using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public interface IElementWaitService
    {
        void Wait(Element element, WaitStrategy waitStrategy);
    }
}
