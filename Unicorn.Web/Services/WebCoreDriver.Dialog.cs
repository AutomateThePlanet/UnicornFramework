using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : IDialogService
    {
        public void Handle(Action<IAlert> action = null, DialogButton dialogButton = DialogButton.Ok) => throw new NotImplementedException();
    }
}
