using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Enums
{
    public enum BrowserBehavior
    {
        NotSet = 0,
        ReuseIfStarted = 1,
        RestartEveryTime = 2,
        RestartOnFail = 3,
    }
}
