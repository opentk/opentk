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
            CL.GetDeviceIDs(platform, DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties() { ContextPlatform = platform };
            context = CL.CreateContext(properties, new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = CL.CreateCommandQueueWithProperties(context, device, new CLCommandQueueProperties(), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            CL.ReleaseContext(context);
            CL.ReleaseCommandQueue(commandQueue);
        }

        [TestMethod]
        public void SVMAlloc()
        {
            // Create a SVM buffer
            var buffer = CL.SvmAlloc(context, SvmMemoryFlags.ReadWrite, 1, 1);
            Assert.AreNotEqual(CLBuffer.Zero, buffer);

            CL.SvmFree(context, buffer);
        }

        [TestMethod]
        public void SVMFree()
        {
            // Create and free a SVM buffer, there's no easy way to test that this is successful
            var buffer = CL.SvmAlloc(context, SvmMemoryFlags.ReadWrite, 1, 1);
            CL.SvmFree(context, buffer);
        }

        [TestMethod]
        public void EnqueueSVMFree()
        {
            // Create a SVM buffer
            var buffer = CL.SvmAlloc(context, SvmMemoryFlags.ReadWrite, 1, 1);
            var resultCode = CL.EnqueueSvmFree(commandQueue, new[] { buffer }, null, IntPtr.Zero, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void EnqueueSvmMemoryCopy()
        {
            // Create a source SVM buffer with data
            var source = CL.SvmAlloc(context, SvmMemoryFlags.ReadWrite, 4, sizeof(int));
            Marshal.Copy(new int[] { 1 }, 0, source, 1);

            // Create a destination SVM buffer
            var destination = CL.SvmAlloc(context, SvmMemoryFlags.ReadWrite, 4, 4);

            // Copy from source to destination
            var resultCode = CL.EnqueueSvmMemoryCopy(commandQueue, true, destination, source, 4, null, out CLEvent ev);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.WaitForEvents(new[] { ev });

            // Read destination buffer
            var output = new int[1];
            Marshal.Copy(destination.Handle, output, 0, 1);
            Assert.AreEqual((int)1, output[0]);

            CL.SvmFree(context, destination);
            CL.SvmFree(context, source);
        }

        [TestMethod]
        public void EnqueueSvmMemoryFill()
        {
            // Create a SVM buffer
            var buffer = CL.SvmAlloc(context, SvmMemoryFlags.ReadWrite, 2 * sizeof(int), 0);

            // Fill buffer with data
            var pattern = new int[] { 1 };
            var resultCode = CL.EnqueueSvmMemoryFill(commandQueue, buffer, pattern, 2 * sizeof(int), null, out CLEvent ev);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.WaitForEvents(new[] { ev });

            // Read buffer
            var output = new int[2];
            Marshal.Copy(buffer.Handle, output, 0, 2);
            Assert.AreEqual((int)1, output[1]);

            CL.SvmFree(context, buffer);
        }

        [TestMethod]
        public void EnqueueSvmMap()
        {
            // Create a SVM buffer
            var buffer = CL.SvmAlloc(context, SvmMemoryFlags.ReadWrite, 1 * sizeof(int), 0);
            Marshal.Copy(new int[] { 1 }, 0, buffer, 1);

            // Map buffer to local pointer
            var resultCode = CL.EnqueueSvmMap(commandQueue, true, MapFlags.Read, buffer, 1 * sizeof(int), null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify map contents
            var output = new int[1];
            Marshal.Copy(buffer, output, 0, 1);
            Assert.AreEqual(1, output[0]);

            CL.SvmFree(context, buffer);
        }

        [TestMethod]
        public void EnqueueSVMUnmap()
        {
            // Create a SVM buffer
            var buffer = CL.SvmAlloc(context, SvmMemoryFlags.ReadOnly, 1 * sizeof(int), 0);

            // Map buffer to local pointer
            CL.EnqueueSvmMap(commandQueue, true, MapFlags.Write, buffer, 1 * sizeof(int), null, out _);
            Marshal.Copy(new int[] { 1 }, 0, buffer, 1);
            var resultCode = CL.EnqueueSvmUnmap(commandQueue, buffer, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify map contents
            var output = new int[1];
            Marshal.Copy(buffer, output, 0, 1);
            Assert.AreEqual(1, output[0]);

            CL.SvmFree(context, buffer);
        }

        [TestMethod]
        public void EnqueueSvmMigrateMemory()
        {
            // Create a SVM buffer
            var buffer = CL.SvmAlloc(context, SvmMemoryFlags.ReadOnly, 1 * sizeof(int), 0);

            // Migrate memory object
            var resultCode = CL.EnqueueSvmMigrateMemory(commandQueue, new[] { buffer }, null, MemoryMigrationFlags.Host, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Difficult to test if this has succeeded
            CL.SvmFree(context, buffer);
        }
    }
}
