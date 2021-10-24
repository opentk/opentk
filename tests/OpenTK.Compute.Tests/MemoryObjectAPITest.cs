using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class MemoryObjectAPITest
    {
        CLPlatform platform;
        CLContext context;
        CLDevice device;
        CLCommandQueue commandQueue;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            platform = platformIds[0];
            platform.GetDeviceIDs(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            context = new CLContextProperties(platform).CreateContext(new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            context.ReleaseContext();
            commandQueue.ReleaseCommandQueue();
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Increment memobj reference count
            var resultCode = CL.RetainMemoryObject(buffer.Handle);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            buffer.ReleaseMemoryObject();
            resultCode = buffer.ReleaseMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = buffer.ReleaseMemoryObject();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseMemoryObject()
        {
            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Decrement memobj ref count 
            CLResultCode resultCode = CL.ReleaseMemoryObject(buffer.Handle);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
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
            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Check that paramName is valid
            CLResultCode resultCode = CL.GetMemObjectInfo(buffer.Handle, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != MemoryObjectInfo.Properties)
                // No valid properties for buffers in OpenCL 3.0
                Assert.IsTrue(bytes.Length > 0);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback()
        {
            // Setup callback
            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }

            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Set destructor
            var resultCode = CL.SetMemoryObjectDestructorCallback(buffer.Handle, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify destructor is called
            buffer.ReleaseMemoryObject();
            Assert.IsTrue(callBackMade);
        }

        [TestMethod]
        public void EnqueueUnmapMemoryObject()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = commandQueue.EnqueueMapBuffer(buffer, true, MapFlags.Write, 0, 3 * sizeof(uint), null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into buffer
            var resultCode = commandQueue.EnqueueUnmapMemoryObject(buffer.Handle, map, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueMigrateMemoryObjects()
        {
            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[1], out _);
            buffer.GetMemObjectInfo(MemoryObjectInfo.HostPointer, out byte[] hostOrigin);

            // Migrate memory object
            var resultCode = commandQueue.EnqueueMigrateMemoryObjects(new[] { buffer.Handle }, MemoryMigrationFlags.Host, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Confirm that host poiner has changed
            buffer.GetMemObjectInfo(MemoryObjectInfo.HostPointer, out byte[] hostDest);
            Assert.IsFalse(hostOrigin == hostDest);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueMarkerWithWaitList()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = commandQueue.EnqueueMapBuffer(buffer, true, MapFlags.Write, 0, 3 * sizeof(uint), null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into buffer
            //var resultCode = commandQueue.EnqueueMarkerWithWaitList(buffer.Handle, map, null, out _);
            //Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueBarrierWithWaitList()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = commandQueue.EnqueueMapBuffer(buffer, true, MapFlags.Write, 0, 3 * sizeof(uint), null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into buffer
            //var resultCode = commandQueue.EnqueueBarrierWithWaitList(buffer.Handle, map, null, out _);
            //Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            buffer.ReleaseMemoryObject();
        }

    }
}
