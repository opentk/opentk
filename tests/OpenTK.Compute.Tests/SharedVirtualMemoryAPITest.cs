using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class SharedVirtualMemoryAPITest
    {
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
        public void SVMAlloc()
        {
            // Create a SVM buffer
            var buffer = context.SvmAlloc(SvmMemoryFlags.ReadWrite, 1, 1);
            Assert.AreNotEqual(CLBuffer.Zero, buffer);

            context.SvmFree(buffer);
        }

        [TestMethod]
        public void SVMFree()
        {
            // Create and free a SVM buffer, there's no easy way to test that this is successful
            var buffer = context.SvmAlloc(SvmMemoryFlags.ReadWrite, 1, 1);
            context.SvmFree(buffer);
        }

        [TestMethod]
        public void EnqueueSVMFree()
        {
            // Create a SVM buffer
            var buffer = context.SvmAlloc(SvmMemoryFlags.ReadWrite, 1, 1);
            var resultCode = commandQueue.EnqueueSvmFree(new[] { buffer }, null, IntPtr.Zero, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void EnqueueSvmMemoryCopy()
        {
            // Create a source SVM buffer with data
            var source = context.SvmAlloc(SvmMemoryFlags.ReadWrite, 4, sizeof(int));
            Marshal.Copy(new int[] { 1 }, 0, source, 1);

            // Create a destination SVM buffer
            var destination = context.SvmAlloc(SvmMemoryFlags.ReadWrite, 4, 4);

            // Copy from source to destination
            var resultCode = commandQueue.EnqueueSvmMemoryCopy(true, destination, source, 4, null, out CLEvent ev);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.WaitForEvents(new[] { ev });

            // Read destination buffer
            var output = new int[1];
            Marshal.Copy(destination.Handle, output, 0, 1);
            Assert.AreEqual((int)1, output[0]);

            context.SvmFree(destination);
            context.SvmFree(source);
        }

        [TestMethod]
        public void EnqueueSvmMemoryFill()
        {
            // Create a SVM buffer
            var buffer = context.SvmAlloc(SvmMemoryFlags.ReadWrite, 2 * sizeof(int), 0);

            // Fill buffer with data
            var pattern = new int[] { 1 };
            var resultCode = commandQueue.EnqueueSvmMemoryFill(buffer, pattern, 2 * sizeof(int), null, out CLEvent ev);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.WaitForEvents(new[] { ev });

            // Read buffer
            var output = new int[2];
            Marshal.Copy(buffer.Handle, output, 0, 2);
            Assert.AreEqual((int)1, output[1]);

            context.SvmFree(buffer);
        }

        [TestMethod]
        public void EnqueueSvmMap()
        {
            // Create a SVM buffer
            var buffer = context.SvmAlloc(SvmMemoryFlags.ReadWrite, 1 * sizeof(int), 0);
            Marshal.Copy(new int[] { 1 }, 0, buffer, 1);

            // Map buffer to local pointer
            var resultCode = commandQueue.EnqueueSvmMap(true, MapFlags.Read, buffer, 1 * sizeof(int), null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify map contents
            var output = new int[1];
            Marshal.Copy(buffer, output, 0, 1);
            Assert.AreEqual(1, output[0]);

            context.SvmFree(buffer);
        }

        [TestMethod]
        public void EnqueueSVMUnmap()
        {
            // Create a SVM buffer
            var buffer = context.SvmAlloc(SvmMemoryFlags.ReadOnly, 1 * sizeof(int), 0);

            // Map buffer to local pointer
            commandQueue.EnqueueSvmMap(true, MapFlags.Write, buffer, 1 * sizeof(int), null, out _);
            Marshal.Copy(new int[] { 1 }, 0, buffer, 1);
            var resultCode = commandQueue.EnqueueSvmUnmap(buffer, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify map contents
            var output = new int[1];
            Marshal.Copy(buffer, output, 0, 1);
            Assert.AreEqual(1, output[0]);

            context.SvmFree(buffer);
        }

        [TestMethod]
        public void EnqueueSvmMigrateMemory()
        {
            // Create a SVM buffer
            var buffer = context.SvmAlloc(SvmMemoryFlags.ReadOnly, 1 * sizeof(int), 0);

            // Migrate memory object
            var resultCode = commandQueue.EnqueueSvmMigrateMemory(new[] { buffer }, null, MemoryMigrationFlags.Host, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Difficult to test if this has succeeded
            context.SvmFree(buffer);
        }
    }
}
