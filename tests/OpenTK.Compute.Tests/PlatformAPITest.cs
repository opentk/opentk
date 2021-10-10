using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Text;

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

        [TestMethod]
        public void GetExtensionFunctionAddressForPlatform()
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            foreach (var platform in platformIds)
            {
                CL.GetPlatformInfo(platform, PlatformInfo.Extensions, out byte[] bytes);
                var extensions = Encoding.ASCII.GetString(bytes).Split(" ");
                int extensionsFound = 0;
                for (int i = 0; i< extensions.Length -1; i++)
                {
                    platform.SupportsPlatformExtension(extensions[i], out bool success);
                    var address = platform.GetExtensionFunctionAddressForPlatform(extensions[i]);
                    // Only returns a valid address for non-core extensions
                    if (address != IntPtr.Zero) extensionsFound++;
                }

                if (extensionsFound == 0)
                    Assert.Inconclusive("No non-core extension addresses found amongst: "+ Encoding.ASCII.GetString(bytes));
            }
        }
    }
}
