using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;

namespace OpenTK.Compute.Tests
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
        [DataRow(CLPlatform.Info.Profile)]
        [DataRow(CLPlatform.Info.Version)]
        [DataRow(CLPlatform.Info.Name)]
        [DataRow(CLPlatform.Info.Vendor)]
        [DataRow(CLPlatform.Info.Extensions)]
        [DataRow(CLPlatform.Info.HostTimerResolution)]
        [DataRow(CLPlatform.Info.NumericVersion)]
        [DataRow(CLPlatform.Info.ExtensionsWithVersion)]
        [DataRow(CLPlatform.Info.PlatformIcdSuffix)]
        public void GetPlatformInfo(CLPlatform.Info paramName)
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);

            foreach(var platform in platformIds){
                var resultCode = CL.GetPlatformInfo(platform, paramName, out byte[] paramValue);

                Assert.AreEqual(CLResultCode.Success, resultCode);
                Assert.IsTrue(paramValue.Length > 0);
            }
        }

        [TestMethod]
        public void GetExtensionFunctionAddressForPlatform()
        {
            Assert.Inconclusive();
        }
    }
}
