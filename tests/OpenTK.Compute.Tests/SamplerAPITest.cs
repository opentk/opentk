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
            CL.GetDeviceIDs(platform, DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = CL.CreateContext(properties, new[] { device }, null, IntPtr.Zero, out _);
        }

        [TestMethod]
        public void CreateSamplerWithProperties()
        {
            var sampler = CL.CreateSamplerWithProperties(context, new CLSamplerProperties(), out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseSampler(sampler);
        }

        [TestMethod]
        public void RetainSampler()
        {
            // Create sampler
            var sampler = CL.CreateSamplerWithProperties(context, new CLSamplerProperties(), out _);

            // Increment memobj reference count
            CLResultCode resultCode = CL.RetainSampler(sampler);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            CL.ReleaseSampler(sampler);
            resultCode = CL.ReleaseSampler(sampler);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = CL.ReleaseSampler(sampler);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseSampler()
        {
            // Create sampler
            var sampler = CL.CreateSamplerWithProperties(context, new CLSamplerProperties(), out _);

            // Verify that memobj ref count can be decremented twice
            CLResultCode resultCode = CL.ReleaseSampler(sampler);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = CL.ReleaseSampler(sampler);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        [DataRow(SamplerInfo.ReferenceCount)]
        [DataRow(SamplerInfo.Context)]
        [DataRow(SamplerInfo.NormalizedCoords)]
        [DataRow(SamplerInfo.AddressingMode)]
        [DataRow(SamplerInfo.FilterMode)]
        [DataRow(SamplerInfo.MipFilterModeKHR)]
        [DataRow(SamplerInfo.LodMinKHR)]
        [DataRow(SamplerInfo.LodMaxKHR)]
        [DataRow(SamplerInfo.Properties)]
        public void GetSamplerInfo(SamplerInfo paramName)
        {
            // Create sampler
            var sampler = CL.CreateSamplerWithProperties(context, new CLSamplerProperties(true, null, null), out _);

            CLResultCode resultCode = CL.GetSamplerInfo(sampler, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            CL.ReleaseSampler(sampler);
        }
    }
}
