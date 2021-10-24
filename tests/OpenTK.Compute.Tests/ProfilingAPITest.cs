using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class ProfilingAPITest
    {
        CLDevice device;
        CLContext context;
        CLCommandQueue commandQueue;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            var platform = platformIds[0];
            platform.GetDeviceIDs(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            context = new CLContextProperties(platform, false).CreateContext(new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(CommandQueueProperties.ProfilingEnable), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            context.ReleaseContext();
            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        [DataRow(ProfilingInfo.CommandQueued)]
        [DataRow(ProfilingInfo.CommandSubmit)]
        [DataRow(ProfilingInfo.CommandStart)]
        [DataRow(ProfilingInfo.CommandEnd)]
        [DataRow(ProfilingInfo.CommandComplete)]
        public void GetEventProfilingInfo(ProfilingInfo paramName)
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            commandQueue.EnqueueReadBuffer(buffer, true, 0, new uint[3], null, out CLEvent eventObj);
            var resultCode = eventObj.GetEventProfilingInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            buffer.ReleaseMemoryObject();
        }
    }
}
