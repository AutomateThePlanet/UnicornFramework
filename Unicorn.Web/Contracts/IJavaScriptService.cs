using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public interface IJavaScriptService
    {
        object Execute(string script);
    }
}
