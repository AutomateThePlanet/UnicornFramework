using System;
using Unicorn.NUnit;

namespace Unicorn.Web
{
    public class WebTest : BaseTest
    {
        public WebApp App => new WebApp();
    }
}
