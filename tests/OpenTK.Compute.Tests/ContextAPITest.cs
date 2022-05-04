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
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void CreateContext()
        {
            // Create context from all devices
            CL.GetDeviceIDs(platform, DeviceType.All, out CLDevice[] devices);
            var context = CL.CreateContext(new CLContextProperties() { ContextPlatform = platform }, devices, null, IntPtr.Zero, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseContext(context);
        }

        [TestMethod]
        public void CreateContextFromType()
        {
            // Create context from default device
            var context = CL.CreateContextFromType(new CLContextProperties() { ContextPlatform = platform }, DeviceType.Default, null, IntPtr.Zero, out CLResultCode resultCode);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            CL.ReleaseContext(context);
        }

        [TestMethod]
        public void RetainContext()
        {
            // Create context
            var context = CL.CreateContextFromType(new CLContextProperties() { ContextPlatform = platform }, DeviceType.Default, null, IntPtr.Zero, out _);


            // Increment memobj reference count
            var resultCode = CL.RetainContext(context);
            Assert.AreEqual(CLResultCode.Success, resultCode);


            // Verify that memobj ref count can be decremented twice
            CL.ReleaseContext(context);
            resultCode = CL.ReleaseContext(context);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify that memobj ref count can't be decremented a third time
            resultCode = CL.ReleaseContext(context);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseContext()
        {
            // Create context
            var context = CL.CreateContextFromType(new CLContextProperties() { ContextPlatform = platform }, DeviceType.Default, null, IntPtr.Zero, out _);

            // Decrement memobj ref count 
            var resultCode = CL.ReleaseContext(context);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify memobj ref count can't be decremented a second time
            resultCode = CL.ReleaseContext(context);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        [DataRow(ContextInfo.Devices)]
        [DataRow(ContextInfo.NumberOfDevices)]
        [DataRow(ContextInfo.ReferenceCount)]
        [DataRow(ContextInfo.Properties)]
        public void GetContextInfo(ContextInfo paramName)
        {
            // Create context
            var context = CL.CreateContextFromType(new CLContextProperties() { ContextPlatform = platform }, DeviceType.Default, null, IntPtr.Zero, out _);

            // Check that paramName is valid
            var resultCode = CL.GetContextInfo(context, paramName, out byte[] paramValue);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(paramValue.Length > 0);

            CL.ReleaseContext(context);
        }

        [TestMethod]
        public void SetContextDestructorCallback()
        {
            // Setup callback
            bool callBackMade = false;
            void callBack(IntPtr waitEvent, IntPtr userData) { callBackMade = true; }

            // Create context
            var context = CL.CreateContextFromType(new CLContextProperties() { ContextPlatform = platform }, DeviceType.Default, null, IntPtr.Zero, out _);

            // Set destructor
            var resultCode = CL.SetContextDestructorCallback(context, callBack, IntPtr.Zero);
            Assert.AreEqual(CLResultCode.Success, resultCode);

            // Verify destructor is called
            CL.ReleaseContext(context);
            Assert.IsTrue(callBackMade);
        }
    }
}
