using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Unicorn.Plugins
{
    public class TestExecutionSubject
    {
        private readonly List<BaseTestExecutionPluginObserver> _testExecutionPlugins;

        public TestExecutionSubject()
        {
            _testExecutionPlugins = new List<BaseTestExecutionPluginObserver>();
        }

        public void Attach(BaseTestExecutionPluginObserver observer)
        {
            _testExecutionPlugins.Add(observer);
        }

        public void Detach(BaseTestExecutionPluginObserver observer)
        {
            _testExecutionPlugins.Remove(observer);
        }

        public void PostTestCleanup(TestOutcome testOutcome, MemberInfo memberInfo)
        {
            _testExecutionPlugins.ForEach(p => p.PostTestCleanup(testOutcome, memberInfo));
        }

        public void PostTestInit(MemberInfo memberInfo)
        {
            _testExecutionPlugins.ForEach(p => p.PostTestInit(memberInfo));
        }

        public void PreTestCleanup(TestOutcome testOutcome, MemberInfo memberInfo)
        {
            _testExecutionPlugins.ForEach(p => p.PreTestCleanup(testOutcome, memberInfo));
        }

        public void PreTestInit(MemberInfo memberInfo)
        {
            _testExecutionPlugins.ForEach(p => p.PreTestInit(memberInfo));
        }

        public void TestInstantiated(MemberInfo memberInfo)
        {
            _testExecutionPlugins.ForEach(p => p.PreTestInit(memberInfo));
        }
    }
}
