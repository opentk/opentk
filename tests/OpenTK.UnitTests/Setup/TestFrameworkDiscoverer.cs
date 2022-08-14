using System;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace OpenTK.UnitTests.Setup
{
    internal sealed class TestFrameworkDiscoverer : XunitTestFrameworkDiscoverer
    {
        public TestFrameworkDiscoverer(
            IAssemblyInfo assemblyInfo,
            ISourceInformationProvider sourceProvider,
            IMessageSink diagnosticMessageSink,
            IXunitTestCollectionFactory collectionFactory = null)
            : base(assemblyInfo, sourceProvider, diagnosticMessageSink, collectionFactory)
        {
        }

        protected override bool IsValidTestClass(ITypeInfo type)
            => base.IsValidTestClass(type) && CanRunOnLocalMachine(type);

        private static bool CanRunOnLocalMachine(ITypeInfo type)
        {
            var ci = Environment.GetEnvironmentVariable("CI"); // "true" on appveyor & github actions
            var isRunningOnGithubActionsOrAppveyor = !string.IsNullOrEmpty(ci) && ci.ToLower() == "true";
            return !isRunningOnGithubActionsOrAppveyor;
        }
    }
}
