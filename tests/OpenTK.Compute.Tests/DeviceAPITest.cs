using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK.Compute.OpenCL;
using System.Linq;

namespace OpenTK.Compute.Tests
{
	[TestClass]
	public class DeviceAPITest
    {
        CLPlatform platform;

        [TestInitialize()]
        public void Starup(){
            CL.GetPlatformIds(out CLPlatform[] platformIds);
            platform = platformIds[0];
        }

        [TestMethod]
        public void GetDeviceIDs()
        {
            var resultCode = platform.GetDeviceIds(CLDevice.Type.All, out CLDevice[] deviceIds);

            Assert.AreEqual(CLResultCode.Success, resultCode);
            Assert.IsTrue(deviceIds.Length > 0);
        }

        [TestMethod]
        [DataRow(CLDevice.Type.Accelerator)]
        [DataRow(CLDevice.Type.Cpu)]
        [DataRow(CLDevice.Type.Default)]
        [DataRow(CLDevice.Type.Gpu)]
        public void GetDeviceIds_DistinctType(CLDevice.Type paramName)
        {
            var resultCode = platform.GetDeviceIds(paramName, out _);

            Assert.IsTrue(new []{CLResultCode.Success, CLResultCode.DeviceNotFound}.Contains(resultCode));
        }


        [TestMethod]
        [DataRow(CLDevice.Info.Type)]
        [DataRow(CLDevice.Info.VendorId)]
        [DataRow(CLDevice.Info.MaximumComputeUnits)]
        [DataRow(CLDevice.Info.MaximumWorkItemDimensions)]
        [DataRow(CLDevice.Info.MaximumWorkGroupSize)]
        [DataRow(CLDevice.Info.MaximumWorkItemSizes)]
        [DataRow(CLDevice.Info.PreferredVectorWidthChar)]
        [DataRow(CLDevice.Info.PreferredVectorWidthShort)]
        [DataRow(CLDevice.Info.PreferredVectorWidthInt)]
        [DataRow(CLDevice.Info.PreferredVectorWidthLong)]
        [DataRow(CLDevice.Info.PreferredVectorWidthFloat)]
        [DataRow(CLDevice.Info.PreferredVectorWidthDouble)]
        [DataRow(CLDevice.Info.MaximumClockFrequency)]
        [DataRow(CLDevice.Info.AddressBits)]
        [DataRow(CLDevice.Info.MaximumReadImageArguments)]
        [DataRow(CLDevice.Info.MaximumWriteImageArguments)]
        [DataRow(CLDevice.Info.MaximumMemoryAllocationSize)]
        [DataRow(CLDevice.Info.Image2DMaximumWidth)]
        [DataRow(CLDevice.Info.Image2DMaximumHeight)]
        [DataRow(CLDevice.Info.Image3DMaximumWidth)]
        [DataRow(CLDevice.Info.Image3DMaximumHeight)]
        [DataRow(CLDevice.Info.Image3DMaximumDepth)]
        [DataRow(CLDevice.Info.ImageSupport)]
        [DataRow(CLDevice.Info.MaximumParameterSize)]
        [DataRow(CLDevice.Info.MaximumSamplers)]
        [DataRow(CLDevice.Info.MemoryBaseAddressAlignment)]
        [DataRow(CLDevice.Info.SingleFloatingPointConfiguration)]
        [DataRow(CLDevice.Info.GlobalMemoryCacheType)]
        [DataRow(CLDevice.Info.GlobalMemoryCachelineSize)]
        [DataRow(CLDevice.Info.GlobalMemoryCacheSize)]
        [DataRow(CLDevice.Info.GlobalMemorySize)]
        [DataRow(CLDevice.Info.MaximumConstantBufferSize)]
        [DataRow(CLDevice.Info.MaximumConstantArguments)]
        [DataRow(CLDevice.Info.LocalMemoryType)]
        [DataRow(CLDevice.Info.LocalMemorySize)]
        [DataRow(CLDevice.Info.ErrorCorrectionSupport)]
        [DataRow(CLDevice.Info.ProfilingTimerResolution)]
        [DataRow(CLDevice.Info.EndianLittle)]
        [DataRow(CLDevice.Info.Available)]
        [DataRow(CLDevice.Info.CompilerAvailable)]
        [DataRow(CLDevice.Info.ExecutionCapabilities)]
        [DataRow(CLDevice.Info.QueueOnHostProperties)]
        [DataRow(CLDevice.Info.Name)]
        [DataRow(CLDevice.Info.Vendor)]
        [DataRow(CLDevice.Info.DriverVersion)]
        [DataRow(CLDevice.Info.Profile)]
        [DataRow(CLDevice.Info.Version)]
        [DataRow(CLDevice.Info.Extensions)]
        [DataRow(CLDevice.Info.Platform)]
        [DataRow(CLDevice.Info.DoubleFloatingPointConfiguration)]
        [DataRow(CLDevice.Info.HalfFloatingPointConfiguration)]
        [DataRow(CLDevice.Info.PreferredVectorWidthHalf)]
        [DataRow(CLDevice.Info.NativeVectorWidthChar)]
        [DataRow(CLDevice.Info.NativeVectorWidthShort)]
        [DataRow(CLDevice.Info.NativeVectorWidthInt)]
        [DataRow(CLDevice.Info.NativeVectorWidthLong)]
        [DataRow(CLDevice.Info.NativeVectorWidthFloat)]
        [DataRow(CLDevice.Info.NativeVectorWidthDouble)]
        [DataRow(CLDevice.Info.NativeVectorWidthHalf)]
        [DataRow(CLDevice.Info.OpenClCVersion)]
        [DataRow(CLDevice.Info.LinkerAvailable)]
        [DataRow(CLDevice.Info.BuiltInKernels)]
        [DataRow(CLDevice.Info.ImageMaximumBufferSize)]
        [DataRow(CLDevice.Info.ImageMaximumArraySize)]
        [DataRow(CLDevice.Info.ParentDevice)]
        [DataRow(CLDevice.Info.PartitionMaximumSubDevices)]
        [DataRow(CLDevice.Info.PartitionProperties)]
        [DataRow(CLDevice.Info.PartitionAffinityDomain)]
        [DataRow(CLDevice.Info.PartitionType)]
        [DataRow(CLDevice.Info.ReferenceCount)]
        [DataRow(CLDevice.Info.PreferredInteropUserSync)]
        [DataRow(CLDevice.Info.PrintfBufferSize)]
        [DataRow(CLDevice.Info.ImagePitchAlignment)]
        [DataRow(CLDevice.Info.ImageBaseAddressAlignment)]
        [DataRow(CLDevice.Info.MaximumReadWriteImageArguments)]
        [DataRow(CLDevice.Info.MaximumGlobalVariableSize)]
        [DataRow(CLDevice.Info.QueueOnDeviceProperties)]
        [DataRow(CLDevice.Info.QueueOnDevicePreferredSize)]
        [DataRow(CLDevice.Info.QueueOnDeviceMaximumSize)]
        [DataRow(CLDevice.Info.MaximumOnDeviceQueues)]
        [DataRow(CLDevice.Info.MaximumOnDeviceEvents)]
        [DataRow(CLDevice.Info.SvmCapabilities)]
        [DataRow(CLDevice.Info.GlobalVariablePreferredTotalSize)]
        [DataRow(CLDevice.Info.MaximumPipeArguments)]
        [DataRow(CLDevice.Info.PipeMaximumActiveReservations)]
        [DataRow(CLDevice.Info.PipeMaximumPacketSize)]
        [DataRow(CLDevice.Info.PreferredPlatformAtomicAlignment)]
        [DataRow(CLDevice.Info.PreferredGlobalAtomicAlignment)]
        [DataRow(CLDevice.Info.PreferredLocalAtomicAlignment)]
        [DataRow(CLDevice.Info.IntermediateLanguageVersion)]
        [DataRow(CLDevice.Info.MaximumNumberOfSubGroups)]
        [DataRow(CLDevice.Info.SubGroupIndependentForwardProgress)]
        [DataRow(CLDevice.Info.DeviceNumericVersion)]
        [DataRow(CLDevice.Info.DeviceExtensionsWithVersion)]
        [DataRow(CLDevice.Info.DeviceIlsWithVersion)]
        [DataRow(CLDevice.Info.DeviceBuiltInKernelsWithVersion)]
        [DataRow(CLDevice.Info.DeviceAtomicMemoryCapabilities)]
        [DataRow(CLDevice.Info.DeviceAtomicFenceCapabilities)]
        [DataRow(CLDevice.Info.DeviceNonUniformWorkGroupSupport)]
        [DataRow(CLDevice.Info.DeviceOpenCLCAllVersions)]
        [DataRow(CLDevice.Info.DevicePreferredWorkGroupSizeMultiple)]
        [DataRow(CLDevice.Info.DeviceWorkGroupCollectiveFunctionsSupport)]
        [DataRow(CLDevice.Info.DeviceGenericAddressSpaceSupport)]
        [DataRow(CLDevice.Info.DeviceOpenCLCFeatures)]
        [DataRow(CLDevice.Info.DeviceDeviceEnqueueCapabilities)]
        [DataRow(CLDevice.Info.DevicePipeSupport)]
        [DataRow(CLDevice.Info.DeviceLatestConformanceVersionPassed)]
        [DataRow(CLDevice.Info.SpirVersion)]
        public void GetDeviceInfo(CLDevice.Info paramName)
        {
            platform.GetDeviceIds(CLDevice.Type.All, out CLDevice[] deviceIds);

            foreach (var device in deviceIds)
            {
                var resultCode = device.GetDeviceInfo(paramName, out byte[] paramValue);
                Assert.AreEqual(CLResultCode.Success, resultCode);
                Assert.IsTrue(paramValue.Length > 0);
            }
        }
    }
}
