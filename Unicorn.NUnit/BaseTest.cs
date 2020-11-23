using NUnit.Framework;
using System;
using Unicorn.Plugins;

namespace Unicorn.NUnit
{
    [TestFixture]
    public class BaseTest
    {
        private readonly TestExecutionSubject _testExecutionSubject;

        public BaseTest()
        {
            _testExecutionSubject = new TestExecutionSubject();
        }

        public TestContext TestContext { get; set; }

        public string TestName => TestContext.CurrentContext.Test.FullName;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var memberInfo = GetType().GetMethod(TestContext.CurrentContext.Test.FullName);
            _testExecutionSubject.PreClassInit(memberInfo);
            ClassInit();
            _testExecutionSubject.PostClassInit(memberInfo);
        }

        [SetUp]
        public void SetUp()
        {
            var memberInfo = GetType().GetMethod(TestContext.CurrentContext.Test.FullName);
            _testExecutionSubject.PreTestInit(memberInfo);
            TestInit();
            _testExecutionSubject.PostTestInit(memberInfo);
        }

        [TearDown]
        public void TearDown()
        {
            var memberInfo = GetType().GetMethod(TestContext.CurrentContext.Test.FullName);
            var outcome = (TestOutcome)TestContext.CurrentContext.Result.Outcome.Status;
            _testExecutionSubject.PreTestCleanup(outcome, memberInfo);
            TestCleanup();
            _testExecutionSubject.PostTestCleanup(outcome, memberInfo);
        }

        public virtual void ClassInit()
        {
        }

        public virtual void TestInit()
        {
        }

        public virtual void TestCleanup()
        {
        }
    }
}
