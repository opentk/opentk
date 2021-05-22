using JetBrains.Annotations;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

[assembly: TestFramework("OpenTK.UnitTests.Setup.TestFrameworkDiscovererFactory", "OpenTK.UnitTests")]

namespace OpenTK.UnitTests.Setup
{
    [UsedImplicitly]
    internal sealed class TestFrameworkDiscovererFactory : XunitTestFramework
    {
        public TestFrameworkDiscovererFactory(IMessageSink messageSink)
            : base(messageSink)
        {
        }

        protected override ITestFrameworkDiscoverer CreateDiscoverer(
            IAssemblyInfo assemblyInfo)
            => new TestFrameworkDiscoverer(assemblyInfo, SourceInformationProvider, DiagnosticMessageSink);
    }
}
