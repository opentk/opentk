using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class ImageAPITest
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
            CL.ReleaseCommandQueue(commandQueue);
            CL.ReleaseContext(context);
        }

        [TestMethod]
        public void CreateImage1D()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, data, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void CreateImage1DArray()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1DArray(1, 1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void CreateImage1DBuffer()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1DBuffer(1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void CreateImage2D()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create2D(1, 1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void CreateImage2DArray()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create2DArray(1, 1, 1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void CreateImage3D()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create3D(1, 1, 1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = CL.RetainMemoryObject(image);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
            resultCode = CL.ReleaseMemoryObject(image);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = CL.ReleaseMemoryObject(image);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseMemoryObject()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = CL.ReleaseMemoryObject(image);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = CL.ReleaseMemoryObject(image);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        [DataRow(MemoryObjectType.Image1D)]
        [DataRow(MemoryObjectType.Image1DArray)]
        [DataRow(MemoryObjectType.Image1DBuffer)]
        [DataRow(MemoryObjectType.Image2D)]
        [DataRow(MemoryObjectType.Image2DArray)]
        [DataRow(MemoryObjectType.Image3D)]
        public void GetSupportedImageFormats(MemoryObjectType paramName)
        {
            var resultCode = CL.GetSupportedImageFormats(context, MemoryFlags.ReadWrite, paramName, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
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
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = CL.GetMemObjectInfo(image, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != MemoryObjectInfo.Properties)
                Assert.IsTrue(bytes.Length > 0);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        [DataRow(ImageInfo.ArraySize)]
        [DataRow(ImageInfo.Buffer)]
        [DataRow(ImageInfo.Depth)]
        [DataRow(ImageInfo.ElementSize)]
        [DataRow(ImageInfo.Format)]
        [DataRow(ImageInfo.Height)]
        [DataRow(ImageInfo.NumberOfMipLevels)]
        [DataRow(ImageInfo.NumberOfSamples)]
        [DataRow(ImageInfo.RowPitch)]
        [DataRow(ImageInfo.SlicePitch)]
        [DataRow(ImageInfo.Width)]
        public void GetImageInfo(ImageInfo paramName)
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = CL.GetImageInfo(image, paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }
            var resultCode = CL.SetMemoryObjectDestructorCallback(image, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
            Assert.IsTrue(callBackMade);
        }

        [TestMethod]
        public void EnqueueReadImage()
        {
            // Create an pre populated image
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, data, out _);

            // Read image
            var output = new uint[3];
            var resultCode = CL.EnqueueReadImage(commandQueue, image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, output, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.AreEqual((uint)2, output[1]);

            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void EnqueueWriteImage()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, new uint[3], out CLResultCode result);
            Assert.AreEqual(CLResultCode.Success, result);
            var resultCode = CL.EnqueueWriteImage(commandQueue, image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, data, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void EnqueueFillImage()
        {
            // Create Image
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.Depth, ChannelType.Float);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, new float[3], out _);

            // Read initial image state
            var output = new float[3];
            CL.EnqueueReadImage(commandQueue, image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, output, null, out _);
            Assert.AreNotEqual((float)1, output[1]);

            // Fill Image
            var resultCode = CL.EnqueueFillImage(commandQueue, image, new float[] { 1 }, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read resultant image state
            CL.EnqueueReadImage(commandQueue, image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, output, null, out _);
            Assert.AreEqual((float)1, output[1]);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void EnqueueCopyImage()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var imageSource = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, data, out _);
            var imageDest = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, new uint[3], out _);
            var resultCode = CL.EnqueueCopyImage(commandQueue, imageSource, imageDest, new nuint[] { 0, 0, 0 }, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            var output = new uint[3];
            CL.EnqueueReadImage(commandQueue, imageDest, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);
            CL.ReleaseMemoryObject(imageSource);
            CL.ReleaseMemoryObject(imageDest);
        }

        [TestMethod]
        public void EnqueueCopyImageToBuffer()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, data, out _);
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, new uint[3], out _);
            var resultCode = CL.EnqueueCopyImageToBuffer(commandQueue, image, buffer, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            var output = new uint[3];
            CL.EnqueueReadBuffer(commandQueue, buffer, true, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);
            CL.ReleaseMemoryObject(buffer);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void EnqueueCopyBufferToImage()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var buffer = CL.CreateBuffer(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, data, out _);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, new uint[3], out _);
            var resultCode = CL.EnqueueCopyBufferToImage(commandQueue, buffer, image, 0, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            var output = new uint[3];
            CL.EnqueueReadImage(commandQueue, image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, output, null, out _);
            Assert.AreEqual((uint)2, output[1]);
            CL.ReleaseMemoryObject(buffer);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void EnqueueMapImage()
        {
            // Create image with data values
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.SignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, new int[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = CL.EnqueueMapImage(commandQueue, image, true, MapFlags.Read, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, null, out _, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read map to confirm values have been set
            var output = new int[3];
            Marshal.Copy(map, output, 0, 3);
            Assert.AreEqual(2, output[1]);
            CL.ReleaseMemoryObject(image);
        }

        [TestMethod]
        public void EnqueueUnmapMemoryObject()
        {
            // Create image with data values
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var image = CL.CreateImage(context, MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, new uint[] { 1, 2, 3 }, out _);

            // Map an area of the image to host memory
            var map = CL.EnqueueMapImage(commandQueue, image, true, MapFlags.Write, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, null, out _, out _);

            // Write data to the mapped host memory
            var input = new int[3] { 4, 4, 4 };
            Marshal.Copy(input, 0, map, 3);

            // Unmap host memory back into image
            var resultCode = CL.EnqueueUnmapMemoryObject(commandQueue, image, map, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Read image to confirm values have been set
            var output = new uint[3];
            CL.EnqueueReadImage(commandQueue, image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, output, null, out _);
            Assert.AreEqual((uint)4, output[1]);
            CL.ReleaseMemoryObject(image);
        }
    }
}
