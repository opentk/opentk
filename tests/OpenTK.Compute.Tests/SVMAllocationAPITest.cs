using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class SVMAllocationAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void SVMAlloc()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SVMFree()
        {
            Assert.Inconclusive();
        }
    }
}
