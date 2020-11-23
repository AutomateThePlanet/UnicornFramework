using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web.Services
{
    public partial class WebCoreDriver : ICookiesService
    {
        public void AddCookie(string cookieName, string cookieValue, string path = "/") => throw new NotImplementedException();
        public void DeleteAllCookies() => throw new NotImplementedException();
        public void DeleteCookie(string cookieName) => throw new NotImplementedException();
        public List<Cookie> GetAllCookies() => throw new NotImplementedException();
        public string GetCookie(string cookieName) => throw new NotImplementedException();
    }
}
