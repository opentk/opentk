using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class EventAPITest
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
            var properties = new CLContextProperties() { ContextPlatform = platform };
            context = CL.CreateContext(properties, new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties() { Properties = CommandQueueProperties.ProfilingEnable }, out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CL.ReleaseContext(context);
            CL.ReleaseCommandQueue(commandQueue);
        }

        [TestMethod]
        public void WaitForEvents()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, new uint[3], null, out CLEvent eventObj);
            var resultCode = CL.WaitForEvents(1, new[] { eventObj });
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseMemoryObject(buffer);
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
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, new uint[3], null, out CLEvent eventObj);
            var resultCode = CL.GetEventInfo(eventObj, paramValue, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);

            CL.ReleaseEvent(eventObj);
            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void CreateUserEvent()
        {
            var eventObj = CL.CreateUserEvent(context, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseEvent(eventObj);
        }

        [TestMethod]
        public void RetainEvent()
        {
            var eventObj = CL.CreateUserEvent(context, out _);
            var resultCode = CL.RetainEvent(eventObj);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseEvent(eventObj);
            resultCode = CL.ReleaseEvent(eventObj);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = CL.ReleaseEvent(eventObj);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseEvent()
        {
            var eventObj = CL.CreateUserEvent(context, out _);
            var resultCode = CL.ReleaseEvent(eventObj);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            resultCode = CL.ReleaseEvent(eventObj);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void SetUserEventStatus()
        {
            var eventObj = CL.CreateUserEvent(context, out _);
            var resultCode = CL.SetUserEventStatus(eventObj, CommandExecutionStatus.Complete);
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void SetEventCallback()
        {
            // Setup callback
            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }

            // Create event and set callback
            var eventObj = CL.CreateUserEvent(context, out _);
            var resultCode = CL.SetEventCallback(eventObj, CommandExecutionStatus.Complete, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Set event status and validate callback
            CL.SetUserEventStatus(eventObj, CommandExecutionStatus.Complete);
            Assert.IsTrue(callBackMade);
        }
    }
}
