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
            platform.GetDeviceIDs(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            context = new CLContextProperties(platform, false).CreateContext(new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            context.ReleaseContext();
            commandQueue.ReleaseCommandQueue();
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
            // Create buffer with starting data
            var buffer = context.CreateBufferWithProperties(new CLBufferProperties(), MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Check that buffer size matches starting data
            buffer.GetMemObjectInfo(MemoryObjectInfo.Size, out byte[] bytes);
            Assert.AreEqual(16, BitConverter.ToInt32(bytes));

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateSubBuffer()
        {
            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Create sub
            var bufferRegion = new CLBufferRegion(0, 4);
            var subBuffer = buffer.CreateSubBuffer(MemoryFlags.ReadWrite, BufferCreateType.Region, ref bufferRegion, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Check size to ensure it has been created properly
            subBuffer.GetMemObjectInfo(MemoryObjectInfo.Size, out byte[] bytes);
            Assert.AreEqual(4, BitConverter.ToInt32(bytes));

            subBuffer.ReleaseMemoryObject();
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Increment memobj reference count
            CLResultCode resultCode = buffer.RetainMemoryObject();
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
            CLResultCode resultCode = buffer.ReleaseMemoryObject();
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
            CLResultCode resultCode = buffer.GetMemObjectInfo(paramName, out byte[] bytes);
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
            var resultCode = buffer.SetMemoryObjectDestructorCallback(callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify destructor is called
            buffer.ReleaseMemoryObject();
            Assert.IsTrue(callBackMade);
        }

        [TestMethod]
        public void EnqueueMapBuffer()
        {
            // Create buffer
            var buffer = context.CreateBuffer(MemoryFlags.UseHostPtr, new uint[] { 1, 2, 3, 4 }, out _);

            // Map buffer to local pointer
            var map = commandQueue.EnqueueMapBuffer(buffer, true, MapFlags.Read, 0, 3, null, out _, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify map contents
            var output = new int[3];
            Marshal.Copy(map, output, 0, 3);
            Assert.AreEqual(2, output[1]);

            buffer.ReleaseMemoryObject();

        }

        [TestMethod]
        public void EnqueueUnmapMemoryObject()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = commandQueue.EnqueueMapBuffer(buffer, true, MapFlags.Write, 0, 3, null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into buffer
            var resultCode = commandQueue.EnqueueUnmapMemoryObject(buffer, map, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer to confirm values have been set
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueReadBuffer()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Read buffer
            var output = new uint[3];
            var resultCode = commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.AreEqual((uint)2, output[1]);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueReadBufferRect()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);

            // Read buffer - region width is in bytes, height in rows, depth in slices
            var output = new uint[3];
            var resultCode = commandQueue.EnqueueReadBufferRect(buffer, true, new nuint[] { 0, 0, 0 }, new nuint[] { 0, 0, 0 },
                new nuint[] { 3 * sizeof(uint), 1, 1 }, 0, 0, 0, 0, output, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.AreEqual((uint)2, output[1]);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueWriteBuffer()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Write to buffer
            var data = new uint[] { 1, 2, 3 };
            var resultCode = commandQueue.EnqueueWriteBuffer(buffer, true, 0, data, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueWriteBufferRect()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Write to buffer
            var data = new uint[] { 1, 2, 3 };
            var resultCode = commandQueue.EnqueueWriteBufferRect(buffer, true, new nuint[] { 0, 0, 0 }, new nuint[] { 0, 0, 0 },
                new nuint[] { 3 * sizeof(uint), 1, 1 }, 0, 0, 0, 0, data, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueFillBuffer()
        {
            // Create buffer with data values
            var buffer = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            // Read initial buffer state
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)0, output[1]);

            // Fill to buffer
            var data = new uint[] { 1 };
            var resultCode = commandQueue.EnqueueFillBuffer(buffer, data, 0, 3 * sizeof(uint), null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            commandQueue.EnqueueReadBuffer(buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)1, output[1]);

            buffer.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueCopyBuffer()
        {
            // Create buffer with data values
            var bufferSrc = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);
            var bufferDest = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            var resultCode = commandQueue.EnqueueCopyBuffer(bufferSrc, bufferDest, 0, 0, 3 * sizeof(uint), null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(bufferDest, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            bufferSrc.ReleaseMemoryObject();
            bufferDest.ReleaseMemoryObject();
        }

        [TestMethod]
        public void EnqueueCopyBufferRect()
        {
            // Create buffer with data values
            var bufferSrc = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[] { 1, 2, 3 }, out _);
            var bufferDest = context.CreateBuffer(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);

            var resultCode = commandQueue.EnqueueCopyBufferRect(bufferSrc, bufferDest, new nuint[] { 0, 0, 0 }, new nuint[] { 0, 0, 0 },
                new nuint[] { 3 * sizeof(uint), 1, 1 }, 0, 0, 0, 0, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read buffer
            var output = new uint[3];
            commandQueue.EnqueueReadBuffer(bufferDest, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);

            bufferSrc.ReleaseMemoryObject();
            bufferDest.ReleaseMemoryObject();
        }
    }
}
