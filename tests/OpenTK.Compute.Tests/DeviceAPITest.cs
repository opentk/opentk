using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System;
using System.Linq;
using System.Text;

namespace OpenTK.Compute.Tests
{
    [TestClass]
    public class DeviceAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup()
        {
            CL.GetPlatformIDs(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void GetDeviceIds()
        {
            var resultCode = CL.GetDeviceIDs(platform, DeviceType.All, out CLDevice[] deviceIds);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(deviceIds.Length > 0);
        }

        [TestMethod]
        [DataRow(DeviceType.Accelerator)]
        [DataRow(DeviceType.Cpu)]
        [DataRow(DeviceType.Default)]
        [DataRow(DeviceType.Gpu)]
        public void GetDeviceIds_DistinctType(DeviceType paramName)
        {
            var resultCode = CL.GetDeviceIDs(platform, paramName, out _);

            Assert.IsTrue(new[] { CLResultCode.Success, CLResultCode.DeviceNotFound }.Contains(resultCode));
        }


        [TestMethod]
        [DataRow(DeviceInfo.Type)]
        [DataRow(DeviceInfo.VendorId)]
        [DataRow(DeviceInfo.MaximumComputeUnits)]
        [DataRow(DeviceInfo.MaximumWorkItemDimensions)]
        [DataRow(DeviceInfo.MaximumWorkGroupSize)]
        [DataRow(DeviceInfo.MaximumWorkItemSizes)]
        [DataRow(DeviceInfo.PreferredVectorWidthChar)]
        [DataRow(DeviceInfo.PreferredVectorWidthShort)]
        [DataRow(DeviceInfo.PreferredVectorWidthInt)]
        [DataRow(DeviceInfo.PreferredVectorWidthLong)]
        [DataRow(DeviceInfo.PreferredVectorWidthFloat)]
        [DataRow(DeviceInfo.PreferredVectorWidthDouble)]
        [DataRow(DeviceInfo.MaximumClockFrequency)]
        [DataRow(DeviceInfo.AddressBits)]
        [DataRow(DeviceInfo.MaximumReadImageArguments)]
        [DataRow(DeviceInfo.MaximumWriteImageArguments)]
        [DataRow(DeviceInfo.MaximumMemoryAllocationSize)]
        [DataRow(DeviceInfo.Image2DMaximumWidth)]
        [DataRow(DeviceInfo.Image2DMaximumHeight)]
        [DataRow(DeviceInfo.Image3DMaximumWidth)]
        [DataRow(DeviceInfo.Image3DMaximumHeight)]
        [DataRow(DeviceInfo.Image3DMaximumDepth)]
        [DataRow(DeviceInfo.ImageSupport)]
        [DataRow(DeviceInfo.MaximumParameterSize)]
        [DataRow(DeviceInfo.MaximumSamplers)]
        [DataRow(DeviceInfo.MemoryBaseAddressAlignment)]
        [DataRow(DeviceInfo.SingleFloatingPointConfiguration)]
        [DataRow(DeviceInfo.GlobalMemoryCacheType)]
        [DataRow(DeviceInfo.GlobalMemoryCachelineSize)]
        [DataRow(DeviceInfo.GlobalMemoryCacheSize)]
        [DataRow(DeviceInfo.GlobalMemorySize)]
        [DataRow(DeviceInfo.MaximumConstantBufferSize)]
        [DataRow(DeviceInfo.MaximumConstantArguments)]
        [DataRow(DeviceInfo.LocalMemoryType)]
        [DataRow(DeviceInfo.LocalMemorySize)]
        [DataRow(DeviceInfo.ErrorCorrectionSupport)]
        [DataRow(DeviceInfo.ProfilingTimerResolution)]
        [DataRow(DeviceInfo.EndianLittle)]
        [DataRow(DeviceInfo.Available)]
        [DataRow(DeviceInfo.CompilerAvailable)]
        [DataRow(DeviceInfo.ExecutionCapabilities)]
        [DataRow(DeviceInfo.QueueOnHostProperties)]
        [DataRow(DeviceInfo.Name)]
        [DataRow(DeviceInfo.Vendor)]
        [DataRow(DeviceInfo.DriverVersion)]
        [DataRow(DeviceInfo.Profile)]
        [DataRow(DeviceInfo.Version)]
        [DataRow(DeviceInfo.Extensions)]
        [DataRow(DeviceInfo.Platform)]
        [DataRow(DeviceInfo.DoubleFloatingPointConfiguration)]
        [DataRow(DeviceInfo.HalfFloatingPointConfiguration)]
        [DataRow(DeviceInfo.PreferredVectorWidthHalf)]
        [DataRow(DeviceInfo.NativeVectorWidthChar)]
        [DataRow(DeviceInfo.NativeVectorWidthShort)]
        [DataRow(DeviceInfo.NativeVectorWidthInt)]
        [DataRow(DeviceInfo.NativeVectorWidthLong)]
        [DataRow(DeviceInfo.NativeVectorWidthFloat)]
        [DataRow(DeviceInfo.NativeVectorWidthDouble)]
        [DataRow(DeviceInfo.NativeVectorWidthHalf)]
        [DataRow(DeviceInfo.LinkerAvailable)]
        [DataRow(DeviceInfo.BuiltInKernels)]
        [DataRow(DeviceInfo.ImageMaximumBufferSize)]
        [DataRow(DeviceInfo.ImageMaximumArraySize)]
        [DataRow(DeviceInfo.ParentDevice)]
        [DataRow(DeviceInfo.PartitionMaximumSubDevices)]
        [DataRow(DeviceInfo.PartitionProperties)]
        [DataRow(DeviceInfo.PartitionAffinityDomain)]
        [DataRow(DeviceInfo.PartitionType)]
        [DataRow(DeviceInfo.ReferenceCount)]
        [DataRow(DeviceInfo.PreferredInteropUserSync)]
        [DataRow(DeviceInfo.PrintfBufferSize)]
        [DataRow(DeviceInfo.ImagePitchAlignment)]
        [DataRow(DeviceInfo.ImageBaseAddressAlignment)]
        [DataRow(DeviceInfo.MaximumReadWriteImageArguments)]
        [DataRow(DeviceInfo.MaximumGlobalVariableSize)]
        [DataRow(DeviceInfo.QueueOnDeviceProperties)]
        [DataRow(DeviceInfo.QueueOnDevicePreferredSize)]
        [DataRow(DeviceInfo.QueueOnDeviceMaximumSize)]
        [DataRow(DeviceInfo.MaximumOnDeviceQueues)]
        [DataRow(DeviceInfo.MaximumOnDeviceEvents)]
        [DataRow(DeviceInfo.SvmCapabilities)]
        [DataRow(DeviceInfo.GlobalVariablePreferredTotalSize)]
        [DataRow(DeviceInfo.MaximumPipeArguments)]
        [DataRow(DeviceInfo.PipeMaximumActiveReservations)]
        [DataRow(DeviceInfo.PipeMaximumPacketSize)]
        [DataRow(DeviceInfo.PreferredPlatformAtomicAlignment)]
        [DataRow(DeviceInfo.PreferredGlobalAtomicAlignment)]
        [DataRow(DeviceInfo.PreferredLocalAtomicAlignment)]
        [DataRow(DeviceInfo.IntermediateLanguageVersion)]
        [DataRow(DeviceInfo.MaximumNumberOfSubGroups)]
        [DataRow(DeviceInfo.SubGroupIndependentForwardProgress)]
        [DataRow(DeviceInfo.DeviceNumericVersion)]
        [DataRow(DeviceInfo.DeviceExtensionsWithVersion)]
        [DataRow(DeviceInfo.DeviceIlsWithVersion)]
        [DataRow(DeviceInfo.DeviceBuiltInKernelsWithVersion)]
        [DataRow(DeviceInfo.DeviceAtomicMemoryCapabilities)]
        [DataRow(DeviceInfo.DeviceAtomicFenceCapabilities)]
        [DataRow(DeviceInfo.DeviceNonUniformWorkGroupSupport)]
        [DataRow(DeviceInfo.DeviceOpenCLCAllVersions)]
        [DataRow(DeviceInfo.DevicePreferredWorkGroupSizeMultiple)]
        [DataRow(DeviceInfo.DeviceWorkGroupCollectiveFunctionsSupport)]
        [DataRow(DeviceInfo.DeviceGenericAddressSpaceSupport)]
        [DataRow(DeviceInfo.DeviceOpenCLCFeatures)]
        [DataRow(DeviceInfo.DeviceDeviceEnqueueCapabilities)]
        [DataRow(DeviceInfo.DevicePipeSupport)]
        [DataRow(DeviceInfo.DeviceLatestConformanceVersionPassed)]
        [DataRow(DeviceInfo.SpirVersion)]
        public void GetDeviceInfo(DeviceInfo paramName)
        {
            CL.GetDeviceIDs(platform, DeviceType.All, out CLDevice[] deviceIds);

            foreach (var device in deviceIds)
            {
                var resultCode = CL.GetDeviceInfo(device, paramName, out byte[] paramValue);
                Assert.AreEqual(CLResultCode.Success, resultCode);
                Assert.IsTrue(paramValue.Length > 0);
            }
        }

        [TestMethod]
        public void CreateSubDevices()
        {
            CL.GetDeviceIDs(platform, DeviceType.Cpu, out CLDevice[] deviceIds);
            if (deviceIds.Length == 0)
            {
                Assert.Inconclusive("Sub devices can only be created on CPUs");
                return;
            }
            var properties = new CLDevicePartitionProperties() { Equally = 1, ByCounts = new uint[0] };

            var resultCode = CL.CreateSubDevices(deviceIds[0], properties, out CLDevice[] subDevices);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(subDevices.Length > 0);
        }

        [TestMethod]
        public void RetainDevice()
        {
            CL.GetDeviceIDs(platform, DeviceType.Cpu, out CLDevice[] deviceIds);
            if (deviceIds.Length == 0)
            {
                Assert.Inconclusive("Sub devices can only be created on CPUs. Only Sub devices can be retained");
                return;
            }
            var properties = new CLDevicePartitionProperties() { Equally = 1, ByCounts = new uint[0] };

            CL.CreateSubDevices(deviceIds[0], properties, out CLDevice[] subDevices);
            var device = subDevices[0];
            var resultCode = CL.RetainDevice(device);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            CL.ReleaseDevice(device);
            resultCode = CL.ReleaseDevice(device);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = CL.ReleaseDevice(device);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void ReleaseDevice()
        {
            CL.GetDeviceIDs(platform, DeviceType.Cpu, out CLDevice[] deviceIds);
            if (deviceIds.Length == 0)
            {
                Assert.Inconclusive("Sub devices can only be created on CPUs. Only Sub devices can be released");
                return;
            }
            var properties = new CLDevicePartitionProperties() { Equally = 1, ByCounts = new uint[0] };

            CL.CreateSubDevices(deviceIds[0], properties, out CLDevice[] subDevices);
            var device = subDevices[0];
            var resultCode = CL.ReleaseDevice(device);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            resultCode = CL.ReleaseDevice(device);
            Assert.AreNotEqual(CLResultCode.Success, resultCode);
        }

        [TestMethod]
        public void GetDeviceAndHostTimer()
        {
            CL.GetDeviceIDs(platform, DeviceType.All, out CLDevice[] deviceIds);
            var resultCode = CL.GetDeviceAndHostTimer(deviceIds[0], out nuint deviceTimestamp, out nuint hostTimestamp);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(deviceTimestamp > 0);
            Assert.IsTrue(hostTimestamp > 0);
        }

        [TestMethod]
        public void GetHostTimer()
        {
            CL.GetDeviceIDs(platform, DeviceType.All, out CLDevice[] deviceIds);
            var resultCode = CL.GetHostTimer(deviceIds[0], out nuint hostTimestamp);
            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(hostTimestamp > 0);
        }
    }
}