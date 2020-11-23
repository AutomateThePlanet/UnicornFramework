using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public interface IBrowserService
    {
        void WaitForAjax();
        void WaitUntilPageLoadsCompletely();

        // TODO: probably we will move them to seperate service.
        ////void Start(Browser browser);
        ////void Quit();
    }
}
