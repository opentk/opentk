using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
	[TestClass]
	public class EnqueuedCommandsAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup(){
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void EnqueueReadBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueReadBufferRect()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueWriteBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueWriteBufferRect()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueFillBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyBufferRect()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueReadImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueWriteImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueFillImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyImageToBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyBufferToImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueMapBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueMapImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueUnmapMemoryObject_CLBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueUnmapMemoryObject_CLImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueMigrateMemoryObjects()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueNDRangeKernel()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueNativeKernel()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueMarkerWithWaitList()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueBarrierWithWaitList()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueSVMFree()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueSvmMemoryCopy()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueSvmMemoryFill()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueSvmMap()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueSVMUnmap()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueSvmMigrateMemory()
        {
            Assert.Inconclusive();
        }
    }
}
