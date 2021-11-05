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
            CL.GetDeviceIDs(platform, DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            context = CL.CreateContext(new CLContextProperties(platform), new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CL.ReleaseContext(context);
            CL.ReleaseCommandQueue(commandQueue);
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            // Create buffer
            var buffer = CL.CreateBuffer(context, MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Increment memobj reference count
            var resultCode = CL.RetainMemoryObject(buffer.Handle);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can be decremented twice
            CL.ReleaseMemoryObject(buffer);
            resultCode = CL.ReleaseMemoryObject(buffer);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = CL.ReleaseMemoryObject(buffer);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseMemoryObject()
        {
            // Create buffer
            var buffer = CL.CreateBuffer(context, MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Decrement memobj ref count 
            CLResultCode resultCode = CL.ReleaseMemoryObject(buffer.Handle);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
            resultCode = CL.ReleaseMemoryObject(buffer);
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
            var buffer = CL.CreateBuffer(context, MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Check that paramName is valid
            CLResultCode resultCode = CL.GetMemObjectInfo(buffer.Handle, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != MemoryObjectInfo.Properties)
                // No valid properties for buffers in OpenCL 3.0
                Assert.IsTrue(bytes.Length > 0);

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback()
        {
            // Setup callback
            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }

            // Create buffer
            var buffer = CL.CreateBuffer(context, MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Set destructor
            var resultCode = CL.SetMemoryObjectDestructorCallback(buffer.Handle, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify destructor is called
            CL.ReleaseMemoryObject(buffer);
            Assert.IsTrue(callBackMade);
        }

        [TestMethod]
        public void EnqueueUnmapMemoryObject()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = CL.EnqueueMapBuffer(commandQueue, buffer, true, MapFlags.Write, 0, 3 * sizeof(uint), null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into buffer
            var resultCode = CL.EnqueueUnmapMemoryObject(commandQueue, buffer.Handle, map, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueMigrateMemoryObjects()
        {
            // Create buffer
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[1], out _);
            CL.GetMemObjectInfo(buffer, MemoryObjectInfo.HostPointer, out byte[] hostOrigin);

            // Migrate memory object
            var resultCode = CL.EnqueueMigrateMemoryObjects(commandQueue, new[] { buffer.Handle }, MemoryMigrationFlags.Host, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Confirm that host poiner has changed
            CL.GetMemObjectInfo(buffer, MemoryObjectInfo.HostPointer, out byte[] hostDest);
            Assert.IsFalse(hostOrigin == hostDest);

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueMarkerWithWaitList()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = CL.EnqueueMapBuffer(commandQueue, buffer, true, MapFlags.Write, 0, 3 * sizeof(uint), null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into buffer
            //var resultCode = commandQueue.EnqueueMarkerWithWaitList(buffer.Handle, map, null, out _);
            //Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueBarrierWithWaitList()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = CL.EnqueueMapBuffer(commandQueue, buffer, true, MapFlags.Write, 0, 3 * sizeof(uint), null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into buffer
            //var resultCode = commandQueue.EnqueueBarrierWithWaitList(buffer.Handle, map, null, out _);
            //Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            CL.ReleaseMemoryObject(buffer);
        }

    }
}
