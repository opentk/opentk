using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;

namespace OpenTK.Compute.Tests
{
	[TestClass]
	public class EventAPITest
    {
        CLPlatform platform;
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
            var properties = new CLContextProperties(platform, false);
            context = properties.CreateContext(new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(CommandQueueProperties.ProfilingEnable), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            context.ReleaseContext();
            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void WaitForEvents()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            commandQueue.EnqueueReadBuffer(buffer, true, 0, new uint[3], null, out CLEvent eventObj);
            var resultCode = CL.WaitForEvents(1, new[] { eventObj });
            Assert.AreEqual(CLResultCode.Success, resultCode);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        [DataRow(EventInfo.CommandQueue)]
        [DataRow(EventInfo.CommandType)]
        [DataRow(EventInfo.ReferenceCount)]
        [DataRow(EventInfo.CommandExecutionStatus)]
        [DataRow(EventInfo.Context)]
        public void GetEventInfo(EventInfo paramValue)
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            commandQueue.EnqueueReadBuffer(buffer, true, 0, new uint[3], null, out CLEvent eventObj);
            var resultCode = eventObj.GetEventInfo(paramValue, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            eventObj.ReleaseEvent();
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateUserEvent()
        {
            var eventObj = context.CreateUserEvent(out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            eventObj.ReleaseEvent();
        }

        [TestMethod]
        public void RetainEvent()
        {
            var eventObj = context.CreateUserEvent(out _);
            var resultCode = eventObj.RetainEvent();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            eventObj.ReleaseEvent();
            resultCode = eventObj.ReleaseEvent();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = eventObj.ReleaseEvent();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseEvent()
        {
            var eventObj = context.CreateUserEvent(out _);
            var resultCode = eventObj.ReleaseEvent();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            
            resultCode = eventObj.ReleaseEvent();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void SetUserEventStatus()
        {
            var eventObj = context.CreateUserEvent(out _);
            var resultCode = eventObj.SetUserEventStatus(CommandExecutionStatus.Complete);
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void SetEventCallback()
        {
            // Setup callback
            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }

            // Create event and set callback
            var eventObj = context.CreateUserEvent(out _);
            var resultCode = eventObj.SetEventCallback(CommandExecutionStatus.Complete, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Set event status and validate callback
            eventObj.SetUserEventStatus(CommandExecutionStatus.Complete);
            Assert.IsTrue(callBackMade);
        }
    }
}
