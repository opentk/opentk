using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class SamplerAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateSamplerWithProperties()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainSampler()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseSampler()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetSamplerInfo()
        {
            Assert.Inconclusive();
        }
    }
}
