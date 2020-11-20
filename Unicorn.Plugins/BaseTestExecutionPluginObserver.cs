using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Unicorn.Plugins
{
    public class BaseTestExecutionPluginObserver
    {
        private readonly TestExecutionSubject _testExecutionSubject;

        public BaseTestExecutionPluginObserver(TestExecutionSubject testExecutionSubject)
        {
            _testExecutionSubject = testExecutionSubject;
            _testExecutionSubject.Attach(this);
        }

        public virtual void PostTestCleanup(TestOutcome testOutcome, MemberInfo memberInfo)
        {
        }

        public virtual void PostTestInit(MemberInfo memberInfo)
        {
        }

        public virtual void PreTestCleanup(TestOutcome testOutcome, MemberInfo memberInfo)
        {
        }

        public virtual void PreTestInit(MemberInfo memberInfo)
        {
        }

        public virtual void TestInstantiated(MemberInfo memberInfo)
        {
        }
    }
}
