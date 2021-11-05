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
            CL.GetDeviceIDs(platform, DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = CL.CreateContext(properties, new[] { device }, null, IntPtr.Zero, out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CL.ReleaseContext(context);
        }

        [TestMethod]
        public void CreateCommandQueueWithProperties()
        {
            // Create command queue with properties
            var properties = new CLCommandQueueProperties(CommandQueueProperties.OnDevice | CommandQueueProperties.OutOfOrderExecModeEnable, 1 * sizeof(uint));
            var commandQueue = CL.CreateCommandQueueWithProperties(context, device, properties, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseCommandQueue(commandQueue);
        }

        [TestMethod]
        public void RetainCommandQueue()
        {
            // Create command queue
            var commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);

            // Increment memobj ref count
            CLResultCode resultCode = CL.RetainCommandQueue(commandQueue);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            CL.ReleaseCommandQueue(commandQueue);
            resultCode = CL.ReleaseCommandQueue(commandQueue);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = CL.ReleaseCommandQueue(commandQueue);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseCommandQueue()
        {
            // Create command queue
            var commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);

            // Decrement memobj ref count 
            CLResultCode resultCode = CL.ReleaseCommandQueue(commandQueue);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
            resultCode = CL.ReleaseCommandQueue(commandQueue);
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
            var commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(CommandQueueProperties.OutOfOrderExecModeEnable | CommandQueueProperties.OnDevice, 1), out _);

            // Check that paramName is valid
            CLResultCode resultCode = CL.GetCommandQueueInfo(commandQueue, paramName, out byte[] paramValue);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(paramValue.Length > 0);

            CL.ReleaseCommandQueue(commandQueue);
        }

        [TestMethod]
        public void SetDefaultDeviceCommandQueue()
        {
            // Create two command queues
            var commandQueue1 = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);
            var commandQueue2 = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(CommandQueueProperties.OutOfOrderExecModeEnable | CommandQueueProperties.OnDevice | CommandQueueProperties.OnDeviceDefault, null), out _);

            // Set command queue 2 as default
            var resultCode = CL.SetDefaultDeviceCommandQueue(context, device, commandQueue2);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseCommandQueue(commandQueue1);
            CL.ReleaseCommandQueue(commandQueue2);
        }

        [TestMethod]
        public void Flush()
        {
            // Create command queue
            var commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);

            // Flush queue
            CLResultCode resultCode = CL.Flush(commandQueue);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseCommandQueue(commandQueue);
        }

        [TestMethod]
        public void Finish()
        {
            // Create command queue
            var commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);

            // Finish queue
            CLResultCode resultCode = CL.Finish(commandQueue);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseCommandQueue(commandQueue);
        }
    }
}
