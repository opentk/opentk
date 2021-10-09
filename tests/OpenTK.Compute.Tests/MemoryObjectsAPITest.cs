using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class MemoryObjectsAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateSubBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreatePipe()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateBufferWithProperties()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateImageWithProperties()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainMemoryObject_CLBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainMemoryObject_CLImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainMemoryObject_CLPipe()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseMemoryObject_CLBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseMemoryObject_CLImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseMemoryObject_CLPipe()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetSupportedImageFormats()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetMemObjectInfo_CLBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetMemObjectInfo_CLImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetMemObjectInfo_CLPipe()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetImageInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetPipeInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback_CLBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback_CLImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback_CLPipe()
        {
            Assert.Inconclusive();
        }
    }
}
