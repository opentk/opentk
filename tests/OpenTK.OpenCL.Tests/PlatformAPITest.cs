using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;

namespace OpenTK.OpenCL.Tests
{
	[TestClass]
	public class PlatformAPITest
    {
        [TestMethod]
        public void GetPlatformIds()
        {
            var resultCode = CL.GetPlatformIds(out CLPlatform[] platformIds);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(platformIds.Length > 0);
        }

        [TestMethod]
        [DataRow(PlatformInfo.Profile)]
        [DataRow(PlatformInfo.Version)]
        [DataRow(PlatformInfo.Name)]
        [DataRow(PlatformInfo.Vendor)]
        [DataRow(PlatformInfo.Extensions)]
        [DataRow(PlatformInfo.HostTimerResolution)]
        [DataRow(PlatformInfo.NumericVersion)]
        [DataRow(PlatformInfo.ExtensionsWithVersion)]
        [DataRow(PlatformInfo.PlatformIcdSuffix)]
        public void GetPlatformInfo(PlatformInfo paramName)
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);

            foreach(var platform in platformIds){
                var resultCode = CL.GetPlatformInfo(platform, paramName, out byte[] paramValue);

                Assert.AreEqual(CLResultCode.Success, resultCode);
                Assert.IsTrue(paramValue.Length > 0);
            }
        }
    }
}
