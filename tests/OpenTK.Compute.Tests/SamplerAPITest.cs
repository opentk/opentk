using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class SamplerAPITest
    {
        CLContext context;
        CLDevice device;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            var platform = platformIds[0];
            platform.GetDeviceIDs(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = properties.CreateContext(new[] { device }, null, IntPtr.Zero, out _);
        }

        [TestMethod]
        public void CreateSamplerWithProperties()
        {
            var sampler = context.CreateSamplerWithProperties(new CLSamplerProperties(), out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            sampler.ReleaseSampler();
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
