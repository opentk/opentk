using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Text;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class BufferAPITest
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
        public void CreateBuffer()
        {
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateBufferWithProperties()
        {
            var buffer = context.CreateBufferWithProperties(new CLBufferProperties(), MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            buffer.GetMemObjectInfo(MemoryObjectInfo.Size, out byte[] bytes);
            Assert.AreEqual(16, BitConverter.ToInt32(bytes));
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateSubBuffer()
        {
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);
            var bufferRegion = new CLBufferRegion(0, 4);
            var subBuffer = buffer.CreateSubBuffer(MemoryFlags.ReadWrite, BufferCreateType.Region, ref bufferRegion, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            subBuffer.GetMemObjectInfo(MemoryObjectInfo.Size, out byte[] bytes);
            Assert.AreEqual(4, BitConverter.ToInt32(bytes));
            subBuffer.ReleaseMemoryObject();
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            CLResultCode resultCode = buffer.RetainMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            buffer.ReleaseMemoryObject();
            resultCode = buffer.ReleaseMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = buffer.ReleaseMemoryObject();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseMemoryObject()
        {
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            CLResultCode resultCode = buffer.ReleaseMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = buffer.ReleaseMemoryObject();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        [DataRow(MemoryObjectInfo.Type)]
        [DataRow(MemoryObjectInfo.Flags)]
        [DataRow(MemoryObjectInfo.Size)]
        [DataRow(MemoryObjectInfo.HostPointer)]
        [DataRow(MemoryObjectInfo.MapCount)]
        [DataRow(MemoryObjectInfo.ReferenceCount)]
        [DataRow(MemoryObjectInfo.Context)]
        [DataRow(MemoryObjectInfo.AssociatedMemoryObject)]
        [DataRow(MemoryObjectInfo.Offset)]
        [DataRow(MemoryObjectInfo.UsesSvmPointer)]
        [DataRow(MemoryObjectInfo.Properties)]
        public void GetMemObjectInfo(MemoryObjectInfo paramName)
        {
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            CLResultCode resultCode = buffer.GetMemObjectInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != MemoryObjectInfo.Properties)
                Assert.IsTrue(bytes.Length > 0);
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback()
        {
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }
            var resultCode = buffer.SetMemoryObjectDestructorCallback(callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            buffer.ReleaseMemoryObject();
            Assert.IsTrue(callBackMade);
        }

        [TestMethod]
        public void EnqueueMapBuffer()
        {
            Assert.Inconclusive();
        }
    }
}
