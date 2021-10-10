using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class CommandQueueAPITest
    {
        CLContext context;
        CLDevice device;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            var platform = platformIds[0];
            platform.GetDeviceIds(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = properties.CreateContext(new[] { device }, null, IntPtr.Zero, out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            context.ReleaseContext();
        }

        [TestMethod]
        public void CreateCommandQueueWithProperties()
        {
            var properties = new CLCommandQueueProperties(CommandQueueProperties.OnDevice & CommandQueueProperties.OutOfOrderExecModeEnable, 1);
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void RetainCommandQueue()
        {
            var properties = new CLCommandQueueProperties();
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out _);
            CLResultCode resultCode = commandQueue.RetainCommandQueue();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            commandQueue.ReleaseCommandQueue();
            resultCode = commandQueue.ReleaseCommandQueue();
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseCommandQueue()
        {
            var properties = new CLCommandQueueProperties();
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out _);
            CLResultCode resultCode = commandQueue.ReleaseCommandQueue();
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        [DataRow(CommandQueueInfo.PropertiesArray)]
        [DataRow(CommandQueueInfo.Context)]
        [DataRow(CommandQueueInfo.Device)]
        [DataRow(CommandQueueInfo.DeviceDefault)]
        [DataRow(CommandQueueInfo.Properties)]
        [DataRow(CommandQueueInfo.Size)]
        [DataRow(CommandQueueInfo.ReferenceCount)]
        public void GetCommandQueueInfo(CommandQueueInfo param)
        {
            // Size is only valid if command queue is OnDevice
            var properties = new CLCommandQueueProperties(CommandQueueProperties.OutOfOrderExecModeEnable | CommandQueueProperties.OnDevice, null);
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out _);
            CLResultCode resultCode = commandQueue.GetCommandQueueInfo(param, out byte[] paramValue);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(paramValue.Length > 0);
            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void SetDefaultDeviceCommandQueue()
        {
            var properties = new CLCommandQueueProperties();
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out _);
            var commandQueue2 = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(CommandQueueProperties.OutOfOrderExecModeEnable | CommandQueueProperties.OnDevice | CommandQueueProperties.OnDeviceDefault, null), out _);
            var resultCode = context.SetDefaultDeviceCommandQueue(device, commandQueue2);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            commandQueue.ReleaseCommandQueue();
            commandQueue2.ReleaseCommandQueue();
        }

        [TestMethod]
        public void Flush()
        {
            var properties = new CLCommandQueueProperties();
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out _);
            CLResultCode resultCode = commandQueue.Flush();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void Finish()
        {
            var properties = new CLCommandQueueProperties();
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out _);
            CLResultCode resultCode = commandQueue.Finish();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            commandQueue.ReleaseCommandQueue();
        }
    }
}
