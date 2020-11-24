using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.Plugins;
using Unicorn.Web.Plugins.Browser;
using Unicorn.Web.Services;

namespace Unicorn.SystemTests
{
    [SetUpFixture]
    public class TestsInitialize
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            // Adding different plugins here. We can create extensions methods for improving readability.
            ServiceContainer.RegisterType<BaseTestExecutionPluginObserver, BrowserLaunchPluginObserver>(Guid.NewGuid().ToString());
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            var driverFactory = ServiceContainer.Resolve<DriverFactory>();
            driverFactory.Dispose();
        }
    }
}
