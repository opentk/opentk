using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
	[TestClass]
	public class KernelAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup(){
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateKernel()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateKernelsInProgram()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CloneKernel()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainKernel()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseKernel()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetKernelArg()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetKernelArgSVMPointer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetKernelExecInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetKernelInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetKernelArgInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetKernelWorkGroupInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetKernelSubGroupInfo()
        {
            Assert.Inconclusive();
        }
    }
}
