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
            CL.GetDeviceIDs(platform, DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            context = CL.CreateContext(new CLContextProperties() { ContextPlatform = platform }, new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties() { Properties = CommandQueueProperties.ProfilingEnable }, out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CL.ReleaseContext(context);
            CL.ReleaseCommandQueue(commandQueue);
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
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, new uint[3], null, out CLEvent eventObj);
            var resultCode = CL.GetEventProfilingInfo(eventObj, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            CL.ReleaseMemoryObject(buffer);
        }
    }
}
