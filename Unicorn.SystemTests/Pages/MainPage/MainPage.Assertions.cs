using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.SystemTests.Pages.Sections;
using Unicorn.SystemTests.Pages.Sections.SearchSection;
using Unicorn.SystemTests.Pages.Sections.ViewCartSection;
using Unicorn.Web.Pages;

namespace Unicorn.SystemTests.Pages.MainPage
{
    public partial class MainPage
    {
        public void AssertProductBoxLink(string name, string expectedLink)
        {
            string actualLink = GetProductBoxByName(name).GetAttribute("href");
            Assert.AreEqual(expectedLink, actualLink);
        }
    }
}
