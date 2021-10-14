using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class ProgramAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateProgramWithSource()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateProgramWithBinary()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateProgramWithBuiltInKernels()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateProgramWithIL()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainProgram()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseProgram()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void BuildProgram()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CompileProgram()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void LinkProgram()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetProgramReleaseCallback()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetProgramSpecializationConstant()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UnloadPlatformCompiler()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetProgramInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetProgramBuildInfo()
        {
            Assert.Inconclusive();
        }
    }
}
