using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Text;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class PipeAPITest
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
        public void CreatePipe()
        {
            var pipe = context.CreatePipe(MemoryFlags.ReadWrite, 8, 64, new CLPipeProperties(), out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            pipe.ReleaseMemoryObject();
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            var pipe = context.CreatePipe(MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = pipe.RetainMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            pipe.ReleaseMemoryObject();
            resultCode = pipe.ReleaseMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = pipe.ReleaseMemoryObject();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseMemoryObject()
        {
            var pipe = context.CreatePipe(MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = pipe.ReleaseMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = pipe.ReleaseMemoryObject();
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
            var pipe = context.CreatePipe(MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = pipe.GetMemObjectInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != MemoryObjectInfo.Properties)
                Assert.IsTrue(bytes.Length > 0);
            pipe.ReleaseMemoryObject();
        }

        [TestMethod]
        [DataRow(PipeInfo.MaximumNumberOfPackets)]
        [DataRow(PipeInfo.PacketSize)]
        [DataRow(PipeInfo.Properties)]
        public void GetPipeInfo(PipeInfo paramName)
        {
            var pipe = context.CreatePipe(MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = pipe.GetPipeInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != PipeInfo.Properties)
                Assert.IsTrue(bytes.Length > 0);
            pipe.ReleaseMemoryObject();
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback()
        {
            var pipe = context.CreatePipe(MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }
            var resultCode = pipe.SetMemoryObjectDestructorCallback(callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            pipe.ReleaseMemoryObject();
            Assert.IsTrue(callBackMade);
        }
    }
}
