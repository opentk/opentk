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
        public void CreatePipe()
        {
            var pipe = CL.CreatePipe(context, MemoryFlags.ReadWrite, 8, 64, new CLPipeProperties(), out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(pipe);
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            var pipe = CL.CreatePipe(context, MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = CL.RetainMemoryObject(pipe);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(pipe);
            resultCode = CL.ReleaseMemoryObject(pipe);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = CL.ReleaseMemoryObject(pipe);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseMemoryObject()
        {
            var pipe = CL.CreatePipe(context, MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = CL.ReleaseMemoryObject(pipe);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = CL.ReleaseMemoryObject(pipe);
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
            var pipe = CL.CreatePipe(context, MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = CL.GetMemObjectInfo(pipe, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != MemoryObjectInfo.Properties)
                Assert.IsTrue(bytes.Length > 0);
            CL.ReleaseMemoryObject(pipe);
        }

        [TestMethod]
        [DataRow(PipeInfo.MaximumNumberOfPackets)]
        [DataRow(PipeInfo.PacketSize)]
        [DataRow(PipeInfo.Properties)]
        public void GetPipeInfo(PipeInfo paramName)
        {
            var pipe = CL.CreatePipe(context, MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            CLResultCode resultCode = CL.GetPipeInfo(pipe, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != PipeInfo.Properties)
                Assert.IsTrue(bytes.Length > 0);
            CL.ReleaseMemoryObject(pipe);
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback()
        {
            var pipe = CL.CreatePipe(context, MemoryFlags.ReadWrite, 1, 1, new CLPipeProperties(), out _);

            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }
            var resultCode = CL.SetMemoryObjectDestructorCallback(pipe, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(pipe);
            Assert.IsTrue(callBackMade);
        }
    }
}
