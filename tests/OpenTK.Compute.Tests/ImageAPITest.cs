using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
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
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            var platform = platformIds[0];
            platform.GetDeviceIds(DeviceType.Default, out CLDevice[] devices);
            device = devices[0];
            var properties = new CLContextProperties(platform, false);
            context = properties.CreateContext(new[] { device }, null, IntPtr.Zero, out _);
            commandQueue = context.CreateCommandQueueWithProperties(device, new CLCommandQueueProperties(), out _);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            commandQueue.ReleaseCommandQueue();
            context.ReleaseContext();
        }

        [TestMethod]
        public void CreateImage1D()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var image = context.CreateImage(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, data, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateImage1DArray()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1DArray(1, 1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateImage1DBuffer()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1DBuffer(1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateImage2D()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create2D(1, 1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateImage2DArray()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create2DArray(1, 1, 1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
        }

        [TestMethod]
        public void CreateImage3D()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create3D(1, 1, 1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out CLResultCode resultCode);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
        }

        [TestMethod]
        public void RetainMemoryObject()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = image.RetainMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
            resultCode = image.ReleaseMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = image.ReleaseMemoryObject();
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseMemoryObject()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = image.ReleaseMemoryObject();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = image.ReleaseMemoryObject();
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
            var resultCode = context.GetSupportedImageFormats(MemoryFlags.ReadWrite, paramName, out _);
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
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = image.GetMemObjectInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            if (paramName != MemoryObjectInfo.Properties)
                Assert.IsTrue(bytes.Length > 0);
            image.ReleaseMemoryObject();
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
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            CLResultCode resultCode = image.GetImageInfo(paramName, out byte[] bytes);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(bytes.Length > 0);
            image.ReleaseMemoryObject();
        }

        [TestMethod]
        public void SetMemoryObjectDestructorCallback()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(1);
            var image = context.CreateImage(MemoryFlags.ReadWrite, ref imageFormat, ref imageDesc, CLImage.Zero, out _);

            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }
            var resultCode = image.SetMemoryObjectDestructorCallback(callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            image.ReleaseMemoryObject();
            Assert.IsTrue(callBackMade);
        }

        [TestMethod]
        public void EnqueueWriteImage()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var image = context.CreateImage(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, data, out CLResultCode result);
            Assert.AreEqual(CLResultCode.Success, result);
            var resultCode = commandQueue.EnqueueWriteImage(image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, data, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void EnqueueReadImage()
        {
            CLImageFormat imageFormat = new CLImageFormat(ChannelOrder.R, ChannelType.UnsignedInteger32);
            CLImageDescription imageDesc = CLImageDescription.Create1D(3);
            var data = new uint[] { 1, 2, 3 };
            var image = context.CreateImage(MemoryFlags.ReadWrite | MemoryFlags.CopyHostPtr, ref imageFormat, ref imageDesc, data, out _);
            var output = new uint[3];
            var resultCode = commandQueue.EnqueueReadImage(image, true, new nuint[] { 0, 0, 0 }, new nuint[] { 3, 1, 1 }, 0, 0, output, null, out _);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Console.WriteLine(data[0]);
        }

        [TestMethod]
        public void EnqueueFillImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyImageToBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueCopyBufferToImage()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueMapBuffer()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void EnqueueMapImage()
        {
            Assert.Inconclusive();
        }
    }
}
