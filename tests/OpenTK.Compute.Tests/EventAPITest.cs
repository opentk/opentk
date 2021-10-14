using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
	[TestClass]
	public class EventAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup(){
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void WaitForEvents()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetEventInfo()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateUserEvent()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void RetainEvent()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ReleaseEvent()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetUserEventStatus()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetEventCallback()
        {
            Assert.Inconclusive();
        }
    }
}
