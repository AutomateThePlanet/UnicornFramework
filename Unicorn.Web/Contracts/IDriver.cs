using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public interface IDriver : INavigationService, IBrowserService, ICookiesService, IElementCreateService, IDialogService, IElementWaitService, IJavaScriptService, IInteractionsService
    {
    }
}
