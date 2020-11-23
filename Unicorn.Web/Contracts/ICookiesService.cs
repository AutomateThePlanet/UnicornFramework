using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unicorn.Web
{
    public interface ICookiesService
    {
        void AddCookie(string cookieName, string cookieValue, string path = "/");

        void DeleteAllCookies();

        void DeleteCookie(string cookieName);

        List<Cookie> GetAllCookies();

        string GetCookie(string cookieName);
    }
}
