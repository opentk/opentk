using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;

namespace OpenTK.Compute.Tests
{
	[TestClass]
	public class ContextAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup(){
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateContext()
        {
            var properties = new CLContextProperties(platform, false);
            platform.GetDeviceIds(DeviceType.All, out CLDevice[] devices);
            var context = properties.CreateContext(devices, null, IntPtr.Zero, out CLResultCode resultCode);
            context.ReleaseContext();
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void CreateContextFromType()
        {
            var properties = new CLContextProperties(platform, false);
            var context = properties.CreateContextFromType(DeviceType.Default, null, IntPtr.Zero, out CLResultCode resultCode);
            context.ReleaseContext();
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void RetainContext()
        {
            var properties = new CLContextProperties(platform, false);
            var context = properties.CreateContextFromType(DeviceType.Default, null, IntPtr.Zero, out _);
            var resultCode = context.RetainContext();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            context.ReleaseContext();
            resultCode = context.ReleaseContext();
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseContext()
        {
            var properties = new CLContextProperties(platform, false);
            var context = properties.CreateContextFromType(DeviceType.Default, null, IntPtr.Zero, out _);
            var resultCode = context.ReleaseContext();
            Assert.AreEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        [DataRow(ContextInfo.Devices)]
        [DataRow(ContextInfo.NumberOfDevices)]
        [DataRow(ContextInfo.ReferenceCount)]
        [DataRow(ContextInfo.Properties)]
        public void GetContextInfo(ContextInfo param)
        {
            var properties = new CLContextProperties(platform, false);
            var context = properties.CreateContextFromType(DeviceType.Default, null, IntPtr.Zero, out _);
            var resultCode = context.GetContextInfo(param, out byte[] paramValue);
            context.ReleaseContext();
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(paramValue.Length > 0);
        }

        [TestMethod]
        public void SetContextDestructorCallback()
        {
            var properties = new CLContextProperties(platform, false);
            var context = properties.CreateContextFromType(DeviceType.Default, null, IntPtr.Zero, out _);
            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData){ callBackMade = true; }
            var resultCode = context.SetContextDestructorCallback(callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            context.ReleaseContext();
            Assert.IsTrue(callBackMade);
        }
    }
}
