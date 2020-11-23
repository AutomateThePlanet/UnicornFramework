using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public interface IDialogService
    {
        void Handle(Action<IAlert> action = null, DialogButton dialogButton = DialogButton.Ok);
    }
}
