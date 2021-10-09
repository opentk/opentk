using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class CommandQueueAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateCommandQueueWithProperties()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainCommandQueue()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseCommandQueue()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetCommandQueueInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Flush()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Finish()
        {
            Assert.Inconclusive();
        }
    }
}
