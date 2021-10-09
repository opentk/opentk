using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
	[TestClass]
	public class ContextAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup(){
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateContext()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateContextFromType()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainContext()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseContext()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetContextInfo()
        {
            Assert.Inconclusive();
        }
    }
}
