using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class BufferAPITest
    {
        CLContext context;
        CLDevice device;
        CLCommandQueue commandQueue;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            var platform = platformIds[0];
            CL.GetDeviceIDs(platform, DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            context = CL.CreateContext(new CLContextProperties() { ContextPlatform = platform }, new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CL.ReleaseContext(context);
            CL.ReleaseCommandQueue(commandQueue);
        }

        [TestMethod]
        public void CreateBuffer()
        {
            var buffer = CL.CreateBuffer(context, MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void CreateBufferWithProperties()
        {
            // Create buffer with starting data
            var buffer = CL.CreateBufferWithProperties(context, new CLBufferProperties(), MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Check that buffer size matches starting data
            CL.GetMemObjectInfo(buffer, MemoryObjectInfo.Size, out byte[] bytes);
            Assert.AreEqual(16, BitConverter.ToInt32(bytes));

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void CreateSubBuffer()
        {
            // Create buffer
            var buffer = CL.CreateBuffer(context, MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Create sub
            var bufferRegion = new CLBufferRegion(0, 4);
            var subBuffer = CL.CreateSubBuffer(buffer, MemoryFlags.ReadWrite, BufferCreateType.Region, ref bufferRegion, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Check size to ensure it has been created properly
            CL.GetMemObjectInfo(subBuffer, MemoryObjectInfo.Size, out byte[] bytes);
            Assert.AreEqual(4, BitConverter.ToInt32(bytes));

            CL.ReleaseMemoryObject(subBuffer);
            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            // Create buffer
            var buffer = CL.CreateBuffer(context, MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Increment memobj reference count
            CLResultCode resultCode = CL.RetainMemoryObject(buffer);
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
            CLResultCode resultCode = CL.ReleaseMemoryObject(buffer);
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
            CLResultCode resultCode = CL.GetMemObjectInfo(buffer, paramName, out byte[] bytes);
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
            var resultCode = CL.SetMemoryObjectDestructorCallback(buffer, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify destructor is called
            CL.ReleaseMemoryObject(buffer);
            Assert.IsTrue(callBackMade);
        }

        [TestMethod]
        public void EnqueueMapBuffer()
        {
            // Create buffer
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map buffer to local pointer
            var map = CL.EnqueueMapBuffer(commandQueue, buffer, true, MapFlags.Read, 0, 3 * sizeof(uint), null, out _, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify map contents
            var output = new int[3];
            Marshal.Copy(map, output, 0, 3);
            Assert.AreEqual(2, output[1]);

            CL.ReleaseMemoryObject(buffer);
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
            var resultCode = CL.EnqueueUnmapMemoryObject(commandQueue, buffer, map, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueReadBuffer()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Read buffer
            var output = new uint[3];
            var resultCode = CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.AreEqual((uint)2, output[1]);

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueReadBufferRect()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Read buffer - region width is in bytes, height in rows, depth in slices
            var output = new uint[3];
            var resultCode = CL.EnqueueReadBufferRect(commandQueue, buffer, true, new nuint[] { 0, 0, 0 }, new nuint[] { 0, 0, 0 }, new nuint[] { 3 * sizeof(uint), 1, 1 }, 0, 0, 0, 0, output, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.AreEqual((uint)2, output[1]);

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueWriteBuffer()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Write to buffer
            var data = new uint[] { 1, 2, 3 };
            var resultCode = CL.EnqueueWriteBuffer(commandQueue, buffer, true, 0, data, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueWriteBufferRect()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Write to buffer
            var data = new uint[] { 1, 2, 3 };
            var resultCode = CL.EnqueueWriteBufferRect(commandQueue, buffer, true, new nuint[] { 0, 0, 0 }, new nuint[] { 0, 0, 0 }, new nuint[] { 3 * sizeof(uint), 1, 1 }, 0, 0, 0, 0, data, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueFillBuffer()
        {
            // Create buffer with data values
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)0, output[1]);

            // Fill to buffer
            var pattern = new uint[] { 1 };
            var resultCode = CL.EnqueueFillBuffer(commandQueue, buffer, pattern, 0, 3 * sizeof(uint), null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)1, output[1]);

            CL.ReleaseMemoryObject(buffer);
        }

        [TestMethod]
        public void EnqueueCopyBuffer()
        {
            // Create buffer with data values
            var bufferSrc = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);
            var bufferDest = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            var resultCode = CL.EnqueueCopyBuffer(commandQueue, bufferSrc, bufferDest, 0, 0, 3 * sizeof(uint), null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, bufferDest, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            CL.ReleaseMemoryObject(bufferSrc);
            CL.ReleaseMemoryObject(bufferDest);
        }

        [TestMethod]
        public void EnqueueCopyBufferRect()
        {
            // Create buffer with data values
            var bufferSrc = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);
            var bufferDest = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            var resultCode = CL.EnqueueCopyBufferRect(commandQueue, bufferSrc, bufferDest, new nuint[] { 0, 0, 0 }, new nuint[] { 0, 0, 0 }, new nuint[] { 3 * sizeof(uint), 1, 1 }, 0, 0, 0, 0, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, bufferDest, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            CL.ReleaseMemoryObject(bufferSrc);
            CL.ReleaseMemoryObject(bufferDest);
        }
    }
}
