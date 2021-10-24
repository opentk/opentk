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
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            var platform = platformIds[0];
            platform.GetDeviceIDs(DeviceType.Default, out CLDevice[] devices);
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
            // Create command queue with properties
            var properties = new CLCommandQueueProperties(CommandQueueProperties.OnDevice | CommandQueueProperties.OutOfOrderExecModeEnable, 1 * sizeof(uint));
            var commandQueue = context.CreateCommandQueueWithProperties(device, properties, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void RetainCommandQueue()
        {
            // Create command queue
            var commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);

            // Increment memobj ref count
            CLResultCode resultCode = commandQueue.RetainCommandQueue();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            commandQueue.ReleaseCommandQueue();
            resultCode = commandQueue.ReleaseCommandQueue();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = commandQueue.ReleaseCommandQueue();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseCommandQueue()
        {
            // Create command queue
            var commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);

            // Decrement memobj ref count 
            CLResultCode resultCode = commandQueue.ReleaseCommandQueue();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
            resultCode = commandQueue.ReleaseCommandQueue();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        [DataRow(CommandQueueInfo.PropertiesArray)]
        [DataRow(CommandQueueInfo.Context)]
        [DataRow(CommandQueueInfo.Device)]
        [DataRow(CommandQueueInfo.DeviceDefault)]
        [DataRow(CommandQueueInfo.Properties)]
        [DataRow(CommandQueueInfo.Size)]
        [DataRow(CommandQueueInfo.ReferenceCount)]
        public void GetCommandQueueInfo(CommandQueueInfo paramName)
        {
            // Create command queue
            var commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(CommandQueueProperties.OutOfOrderExecModeEnable | CommandQueueProperties.OnDevice, 1), out _);

            // Check that paramName is valid
            CLResultCode resultCode = commandQueue.GetCommandQueueInfo(paramName, out byte[] paramValue);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(paramValue.Length > 0);

            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void SetDefaultDeviceCommandQueue()
        {
            // Create two command queues
            var commandQueue1 = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);
            var commandQueue2 = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(CommandQueueProperties.OutOfOrderExecModeEnable | CommandQueueProperties.OnDevice | CommandQueueProperties.OnDeviceDefault, null), out _);

            // Set command queue 2 as default
            var resultCode = context.SetDefaultDeviceCommandQueue(device, commandQueue2);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            commandQueue1.ReleaseCommandQueue();
            commandQueue2.ReleaseCommandQueue();
        }

        [TestMethod]
        public void Flush()
        {
            // Create command queue
            var commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);

            // Flush queue
            CLResultCode resultCode = commandQueue.Flush();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void Finish()
        {
            // Create command queue
            var commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);

            // Finish queue
            CLResultCode resultCode = commandQueue.Finish();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            commandQueue.ReleaseCommandQueue();
        }
    }
}
