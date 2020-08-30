using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Compute.Native;

namespace OpenTK.Compute.OpenCL
{
	public class CL : CLBase
	{
		static CL()
		{
			CLBase.RegisterOpenCLResolver();
		}

		private const string LibName = "libOpenCL";

		#region Platform API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="numberOfEntries"></param>
		/// <param name="platforms"></param>
		/// <param name="numberOfPlatforms"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetPlatformIDs")]
		public static extern CLResultCode GetPlatformIds(uint numberOfEntries, IntPtr[] platforms,
			out uint numberOfPlatforms);

		public static CLResultCode GetPlatformIds(out IntPtr[] platformIds)
		{
			GetPlatformIds(0, null, out uint platformCount);
			platformIds = new IntPtr[platformCount];
			return GetPlatformIds(platformCount, platformIds, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="platform"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetPlatformInfo")]
		public static extern CLResultCode GetPlatformInfo(IntPtr platform, PlatformInfo paramName,
			UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetPlatformInfo(IntPtr platform, PlatformInfo paramName, out byte[] paramValue)
		{
			GetPlatformInfo(platform, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
			paramValue = new byte[sizeReturned.ToUInt64()];
			return GetPlatformInfo(platform, paramName, sizeReturned, paramValue, out _);
		}

		/// <summary>
		/// Helper method not present in official OpenCL specs
		/// </summary>
		public static string GetPlatformInfoAsString(IntPtr platform, PlatformInfo paramName, out CLResultCode result)
		{
			result = GetPlatformInfo(platform, paramName, out byte[] raw);
			return Encoding.ASCII.GetString(raw);
		}

		#endregion

		#region Device API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="platform"></param>
		/// <param name="deviceType"></param>
		/// <param name="numberOfEntries"></param>
		/// <param name="devices"></param>
		/// <param name="numberOfDevicesReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetDeviceIDs")]
		public static extern CLResultCode GetDeviceIds(IntPtr platform, DeviceType deviceType, uint numberOfEntries,
			IntPtr[] devices, out uint numberOfDevicesReturned);

		public static CLResultCode GetDeviceIds(IntPtr platform, DeviceType deviceType, out IntPtr[] deviceIds)
		{
			GetDeviceIds(platform, deviceType, 0, null, out uint deviceCount);
			deviceIds = new IntPtr[deviceCount];
			return GetDeviceIds(platform, deviceType, deviceCount, deviceIds, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="device"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetDeviceInfo")]
		public static extern CLResultCode GetDeviceInfo(IntPtr device, DeviceInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetDeviceInfo(IntPtr device, DeviceInfo paramName, out byte[] paramValue)
		{
			GetDeviceInfo(device, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
			paramValue = new byte[sizeReturned.ToUInt64()];
			return GetDeviceInfo(device, paramName, sizeReturned, paramValue, out _);
		}

		/// <summary>
		/// Helper method not present in official OpenCL specs
		/// </summary>
		public static string GetDeviceInfoAsString(IntPtr device, DeviceInfo paramName, out CLResultCode result)
		{
			result = GetDeviceInfo(device, paramName, out byte[] raw);
			return Encoding.ASCII.GetString(raw);
		}

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="inDevice"></param>
		/// <param name="properties"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="outDevices"></param>
		/// <param name="devicesReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateSubDevices")]
		public static extern CLResultCode CreateSubDevices(IntPtr inDevice, IntPtr[] properties, uint numberOfDevices,
			IntPtr[] outDevices, out uint devicesReturned);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="device"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainDevice")]
		public static extern CLResultCode RetainDevice(IntPtr device);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="device"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseDevice")]
		public static extern CLResultCode ReleaseDevice(IntPtr device);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="context"></param>
		/// <param name="device"></param>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetDefaultDeviceCommandQueue")]
		public static extern CLResultCode SetDefaultDeviceCommandQueue(IntPtr context, IntPtr device,
			IntPtr commandQueue);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="device"></param>
		/// <param name="deviceTimestamp"></param>
		/// <param name="hostTimestamp"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetDeviceAndHostTimer")]
		public static extern CLResultCode GetDeviceAndHostTimer(IntPtr device, IntPtr deviceTimestamp,
			IntPtr hostTimestamp);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="device"></param>
		/// <param name="hostTimestamp"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetHostTimer")]
		public static extern CLResultCode GetHostTimer(IntPtr device, IntPtr hostTimestamp);

		#endregion

		#region Context API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="properties"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="devices"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateContext")]
		public static extern IntPtr CreateContext(IntPtr properties, uint numberOfDevices, IntPtr[] devices,
			IntPtr notificationCallback, IntPtr userData, out CLResultCode errorCode);

		public static IntPtr CreateContext(IntPtr properties, IntPtr[] devices, IntPtr notificationCallback,
			IntPtr userData, out CLResultCode errorCode)
		{
			return CreateContext(properties, (uint)devices.Length, devices, notificationCallback, userData,
				out errorCode);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="properties"></param>
		/// <param name="deviceType"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateContextFromType")]
		public static extern IntPtr CreateContextFromType(IntPtr properties, DeviceType deviceType,
			IntPtr notificationCallback, IntPtr userData, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainContext")]
		public static extern CLResultCode RetainContext(IntPtr context);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseContext")]
		public static extern CLResultCode ReleaseContext(IntPtr context);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetContextInfo")]
		public static extern CLResultCode GetContextInfo(IntPtr context, ContextInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramValueSizeReturned);

		#endregion

		#region CommandQueue API

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="device"></param>
		/// <param name="properties"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateCommandQueueWithProperties")]
		public static extern IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, IntPtr properties,
			out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainCommandQueue")]
		public static extern CLResultCode RetainCommandQueue(IntPtr commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseCommandQueue")]
		public static extern CLResultCode ReleaseCommandQueue(IntPtr commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="paramName"></param>
		/// <param name="paramSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetCommandQueueInfo")]
		public static extern CLResultCode GetCommandQueueInfo(IntPtr commandQueue, CommandQueueInfo paramName,
			UIntPtr paramSize, byte[] paramValue, UIntPtr paramValueSizeReturned);

		#endregion

		#region Memory Objects APIs

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="flags"></param>
		/// <param name="size"></param>
		/// <param name="hostPtr"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateBuffer")]
		public static extern IntPtr CreateBuffer(IntPtr context, MemoryFlags flags, UIntPtr size, IntPtr hostPtr,
			out CLResultCode errorCode);

		public static IntPtr CreateBuffer<T>(IntPtr context, MemoryFlags flags, T[] array, out CLResultCode errorCode)
		{
			GCHandle handle = GCHandle.Alloc(array, GCHandleType.Pinned);
			IntPtr buffer = CreateBuffer(context, flags, (UIntPtr)(Marshal.SizeOf<T>() * array.Length),
				handle.AddrOfPinnedObject(), out errorCode);
			handle.Free();
			return buffer;
		}

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="flags"></param>
		/// <param name="bufferCreateType"></param>
		/// <param name="bufferCreateInfo"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateSubBuffer")]
		public static extern IntPtr CreateSubBuffer(IntPtr buffer, MemoryFlags flags, BufferCreateType bufferCreateType,
			IntPtr bufferCreateInfo, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="context"></param>
		/// <param name="flags"></param>
		/// <param name="imageFormat"></param>
		/// <param name="imageDesc"></param>
		/// <param name="hostPointer"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateImage")]
		public static extern IntPtr CreateImage(IntPtr context, MemoryFlags flags, ImageFormat imageFormat,
			ImageDescription imageDesc, IntPtr hostPointer, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="flags"></param>
		/// <param name="pipePacketSize"></param>
		/// <param name="pipeMaxPackets"></param>
		/// <param name="properties"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreatePipe")]
		public static extern IntPtr CreatePipe(IntPtr context, MemoryFlags flags, uint pipePacketSize,
			uint pipeMaxPackets, IntPtr[] properties, out CLResultCode errorCode);


//TODO Add those 2 opencl 3.0 methods
/*
[ClVersion(3,0)]
[DllImport(LibName, EntryPoint = "clCreateBufferWithProperties")]
public static extern IntPtr CreateBufferWithProperties(IntPtr context, IntPtr[] properties, MemoryFlags flags, UIntPtr size, IntPtr hostPointer, out CLResultCode errorCode);
//const cl_mem_properties * properties,

[ClVersion(3,0)]
[DllImport(LibName, EntryPoint = "clCreateImageWithProperties")]
public static extern IntPtr CreateImageWithProperties(IntPtr context, IntPtr[] properties, MemoryFlags flags, IntPtr imageFormat, IntPtr imageDesc, IntPtr hostPointer, out CLResultCode errorCode);
//const cl_mem_properties * properties,
*/

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="memoryObject"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainMemObject")]
		public static extern CLResultCode RetainMemObject(IntPtr memoryObject);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="memoryObject"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseMemObject")]
		public static extern CLResultCode ReleaseMemObject(IntPtr memoryObject);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="flags"></param>
		/// <param name="imageType"></param>
		/// <param name="numberOfEntries"></param>
		/// <param name="imageFormats"></param>
		/// <param name="numberOfImageFormats"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetSupportedImageFormats")]
		public static extern CLResultCode GetSupportedImageFormats(IntPtr context, MemoryFlags flags,
			MemoryObjectType imageType, uint numberOfEntries, ImageFormat[] imageFormats,
			out uint numberOfImageFormats);

		public static CLResultCode GetSupportedImageFormats(IntPtr context, MemoryFlags flags,
			MemoryObjectType imageType, out ImageFormat[] imageFormats)
		{
			GetSupportedImageFormats(context, flags, imageType, 0, null, out uint count);
			imageFormats = new ImageFormat[count];
			return GetSupportedImageFormats(context, flags, imageType, count, imageFormats, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="memoryObject"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetMemObjectInfo")]
		public static extern CLResultCode GetMemObjectInfo(IntPtr memoryObject, MemoryObjectInfo paramName,
			UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetMemObjectInfo(IntPtr memoryObject, MemoryObjectInfo paramName,
			out byte[] paramValue)
		{
			GetMemObjectInfo(memoryObject, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetMemObjectInfo(memoryObject, paramName, size, paramValue, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="image"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetImageInfo")]
		public static extern CLResultCode GetImageInfo(IntPtr image, ImageInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetImageInfo(IntPtr image, ImageInfo paramName, out byte[] paramValue)
		{
			GetImageInfo(image, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetImageInfo(image, paramName, size, paramValue, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="pipe"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetPipeInfo")]
		public static extern CLResultCode GetPipeInfo(IntPtr pipe, PipeInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetPipeInfo(IntPtr pipe, PipeInfo paramName, out byte[] paramValue)
		{
			GetPipeInfo(pipe, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetPipeInfo(pipe, paramName, size, paramValue, out _);
		}


		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="memoryObject"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetMemObjectDestructorCallback")]
		public static extern CLResultCode SetMemObjectDestructorCallback(IntPtr memoryObject,
			IntPtr notificationCallback, IntPtr userData);

		#endregion

		#region SVM Allocation API

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="flags"></param>
		/// <param name="size"></param>
		/// <param name="alignment"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSVMAlloc")]
		public static extern IntPtr SVMAlloc(IntPtr context, SvmMemoryFlags flags, UIntPtr size, uint alignment);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="svmPointer"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSVMFree")]
		public static extern IntPtr SVMFree(IntPtr context, IntPtr svmPointer);

		#endregion

		#region Sampler API

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="samplerProperties"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateSamplerWithProperties")]
		public static extern IntPtr CreateSamplerWithProperties(IntPtr context, IntPtr samplerProperties,
			out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="sampler"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainSampler")]
		public static extern CLResultCode RetainSampler(IntPtr sampler);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="sampler"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseSampler")]
		public static extern CLResultCode ReleaseSampler(IntPtr sampler);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="sampler"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetSamplerInfo")]
		public static extern CLResultCode GetSamplerInfo(IntPtr sampler, SamplerInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetSamplerInfo(IntPtr sampler, SamplerInfo paramName, out byte[] paramValue)
		{
			GetSamplerInfo(sampler, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetSamplerInfo(sampler, paramName, size, paramValue, out _);
		}


		#endregion

		#region Program Object API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="count"></param>
		/// <param name="strings"></param>
		/// <param name="lengths"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateProgramWithSource")]
		public static extern IntPtr CreateProgramWithSource(IntPtr context, uint count, IntPtr[] strings,
			uint[] lengths, out CLResultCode errorCode);

		public static IntPtr CreateProgramWithSource(IntPtr context, string source, out CLResultCode errorCode)
		{
			IntPtr[] sourceList = {Marshal.StringToHGlobalAnsi(source)};
			uint[] sourceLengths = {(uint)source.Length};
			return CreateProgramWithSource(context, 1, sourceList, sourceLengths, out errorCode);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="deviceList"></param>
		/// <param name="lengths"></param>
		/// <param name="binaries"></param>
		/// <param name="binaryStatus"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateProgramWithBinary")]
		public static extern IntPtr CreateProgramWithBinary(IntPtr context, uint numberOfDevices, IntPtr[] deviceList,
			UIntPtr[] lengths, IntPtr[] binaries, out CLResultCode binaryStatus, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="context"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="deviceList"></param>
		/// <param name="kernelNames"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateProgramWithBuiltInKernels")]
		public static extern IntPtr CreateProgramWithBuiltInKernels(IntPtr context, uint numberOfDevices,
			IntPtr[] deviceList, string kernelNames, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="context"></param>
		/// <param name="il"></param>
		/// <param name="length"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateProgramWithIL")]
		public static extern IntPtr CreateProgramWithIL(IntPtr context, IntPtr il, UIntPtr length,
			out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainProgram")]
		public static extern CLResultCode RetainProgram(IntPtr program);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseProgram")]
		public static extern CLResultCode ReleaseProgram(IntPtr program);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="deviceList"></param>
		/// <param name="options"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clBuildProgram")]
		public static extern CLResultCode BuildProgram(IntPtr program, uint numberOfDevices, IntPtr[] deviceList,
			string options, IntPtr notificationCallback, IntPtr userData);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="program"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="deviceList"></param>
		/// <param name="options"></param>
		/// <param name="numberOfInputDevices"></param>
		/// <param name="inputHeaders"></param>
		/// <param name="headerIncludeNames"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCompileProgram")]
		public static extern CLResultCode CompileProgram(IntPtr program, uint numberOfDevices, IntPtr[] deviceList,
			string options, uint numberOfInputDevices, IntPtr[] inputHeaders, out IntPtr headerIncludeNames,
			IntPtr notificationCallback, IntPtr userData);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="context"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="deviceList"></param>
		/// <param name="options"></param>
		/// <param name="numberOfPrograms"></param>
		/// <param name="inputPrograms"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clLinkProgram")]
		public static extern IntPtr LinkProgram(IntPtr context, uint numberOfDevices, IntPtr[] deviceList,
			string options, uint numberOfPrograms, IntPtr[] inputPrograms, IntPtr notificationCallback, IntPtr userData,
			out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 2.2
		/// </summary>
		/// <param name="program"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetProgramReleaseCallback")]
		public static extern CLResultCode SetProgramReleaseCallback(IntPtr program, IntPtr notificationCallback,
			IntPtr userData);

		/// <summary>
		/// Introduced in OpenCL 2.2
		/// </summary>
		/// <param name="program"></param>
		/// <param name="specId"></param>
		/// <param name="specSize"></param>
		/// <param name="specValue"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetProgramSpecializationConstant")]
		public static extern CLResultCode SetProgramSpecializationConstant(IntPtr program, uint specId,
			UIntPtr specSize, IntPtr specValue);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="platform"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clUnloadPlatformCompiler")]
		public static extern CLResultCode UnloadPlatformCompiler(IntPtr platform);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetProgramInfo")]
		public static extern CLResultCode GetProgramInfo(IntPtr program, ProgramInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetProgramInfo(IntPtr program, ProgramInfo paramName, out byte[] paramValue)
		{
			GetProgramInfo(program, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetProgramInfo(program, paramName, size, paramValue, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <param name="device"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetProgramBuildInfo")]
		public static extern CLResultCode GetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo paramName,
			UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo paramName,
			out byte[] paramValue)
		{
			GetProgramBuildInfo(program, device, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetProgramBuildInfo(program, device, paramName, size, paramValue, out _);
		}

		#endregion

		#region Kernel Object API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <param name="name"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateKernel")]
		public static extern IntPtr CreateKernel(IntPtr program, string name, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <param name="numberOfKernels"></param>
		/// <param name="kernels"></param>
		/// <param name="numberOfKernelsReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateKernelsInProgram")]
		public static extern CLResultCode CreateKernelsInProgram(IntPtr program, uint numberOfKernels, IntPtr[] kernels,
			out uint numberOfKernelsReturned);

		public static CLResultCode CreateKernelsInProgram(IntPtr program, out IntPtr[] kernels)
		{
			CreateKernelsInProgram(program, 0, null, out uint count);
			kernels = new IntPtr[count];
			return CreateKernelsInProgram(program, count, kernels, out _);
		}


		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="sourceKernel"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCloneKernel")]
		public static extern IntPtr CloneKernel(IntPtr sourceKernel, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainKernel")]
		public static extern CLResultCode RetainKernel(IntPtr kernel);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseKernel")]
		public static extern CLResultCode ReleaseKernel(IntPtr kernel);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="argumentIndex"></param>
		/// <param name="argumentSize"></param>
		/// <param name="argumentValuePointer"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetKernelArg")]
		public static extern CLResultCode SetKernelArg(IntPtr kernel, uint argumentIndex, UIntPtr argumentSize,
			IntPtr argumentValuePointer);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="argumentIndex"></param>
		/// <param name="argumentValuePointer"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetKernelArgSVMPointer")]
		public static extern CLResultCode SetKernelArgSVMPointer(IntPtr kernel, uint argumentIndex,
			IntPtr argumentValuePointer);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetKernelExecInfo")]
		public static extern CLResultCode SetKernelExecInfo(IntPtr kernel, KernelExecInfo paramName,
			UIntPtr paramValueSize, IntPtr paramValue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetKernelInfo")]
		public static extern CLResultCode GetKernelInfo(IntPtr kernel, KernelInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramSizeReturned);

		public static CLResultCode GetKernelInfo(IntPtr kernel, KernelInfo paramName, out byte[] paramValue)
		{
			GetKernelInfo(kernel, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetKernelInfo(kernel, paramName, size, paramValue, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="argumentIndex"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetKernelArgInfo")]
		public static extern CLResultCode GetKernelArgInfo(IntPtr kernel, uint argumentIndex, KernelArgInfo paramName,
			UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramSizeReturned);

		public static CLResultCode GetKernelArgInfo(IntPtr kernel, uint argumentIndex, KernelArgInfo paramName,
			out byte[] paramValue)
		{
			GetKernelArgInfo(kernel, argumentIndex, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetKernelArgInfo(kernel, argumentIndex, paramName, size, paramValue, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="device"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetKernelWorkGroupInfo")]
		public static extern CLResultCode GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device,
			KernelWorkGroupInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramSizeReturned);

		public static CLResultCode GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo paramName,
			out byte[] paramValue)
		{
			GetKernelWorkGroupInfo(kernel, device, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetKernelWorkGroupInfo(kernel, device, paramName, size, paramValue, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="device"></param>
		/// <param name="paramName"></param>
		/// <param name="inputValueSize"></param>
		/// <param name="inputValue"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetKernelSubGroupInfo")]
		public static extern CLResultCode GetKernelSubGroupInfo(IntPtr kernel, IntPtr device,
			KernelSubGroupInfo paramName, UIntPtr inputValueSize, IntPtr inputValue, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramSizeReturned);

		#endregion

		#region Event Object API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="numberOfEvents"></param>
		/// <param name="eventList"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clWaitForEvents")]
		public static extern CLResultCode WaitForEvents(uint numberOfEvents, IntPtr[] eventList);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="event"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetEventInfo")]
		public static extern CLResultCode GetEventInfo(IntPtr @event, EventInfo paramName, UIntPtr paramValueSize,
			byte[] paramValue, out UIntPtr paramSizeReturned);

		public static CLResultCode GetEventInfo(IntPtr @event, EventInfo paramName, out byte[] paramValue)
		{
			GetEventInfo(@event, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetEventInfo(@event, paramName, size, paramValue, out _);
		}

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="context"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clCreateUserEvent")]
		public static extern IntPtr CreateUserEvent(IntPtr context, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clRetainEvent")]
		public static extern CLResultCode RetainEvent(IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clReleaseEvent")]
		public static extern CLResultCode ReleaseEvent(IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="event"></param>
		/// <param name="executionStatus"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetUserEventStatus")]
		public static extern CLResultCode SetUserEventStatus(IntPtr @event, int executionStatus);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="eventHandle"></param>
		/// <param name="commandExecCallbackType"></param>
		/// <param name="notifyCallback"></param>
		/// <param name="userData"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clSetEventCallback")]
		public static extern CLResultCode SetEventCallback(IntPtr eventHandle, int commandExecCallbackType,
			IntPtr notifyCallback, IntPtr userData);

		public static CLResultCode SetEventCallback(IntPtr eventHandle, CommandExecutionStatus commandExecCallbackType,
			ClEventCallback notifyCallback)
		{
			return SetEventCallback(eventHandle, (int)commandExecCallbackType,
				Marshal.GetFunctionPointerForDelegate(notifyCallback), IntPtr.Zero);
		}

		#endregion

		#region Profiling API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="event"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetEventProfilingInfo")]
		public static extern CLResultCode GetEventProfilingInfo(IntPtr @event, ProfilingInfo paramName,
			UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetEventProfilingInfo(IntPtr @event, ProfilingInfo paramName, out byte[] paramValue)
		{
			GetEventProfilingInfo(@event, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetEventProfilingInfo(@event, paramName, size, paramValue, out _);
		}

		#endregion

		#region Flush and Finish API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clFlush")]
		public static extern CLResultCode Flush(IntPtr commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clFinish")]
		public static extern CLResultCode Finish(IntPtr commandQueue);

		#endregion

		#region Enqueued Commands API

		public delegate void ClEventCallback(IntPtr waitEvent, IntPtr userData);


		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="buffer"></param>
		/// <param name="blockingRead"></param>
		/// <param name="offset"></param>
		/// <param name="size"></param>
		/// <param name="pointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueReadBuffer")]
		public static extern CLResultCode EnqueueReadBuffer(IntPtr commandQueue, IntPtr buffer, uint blockingRead,
			UIntPtr offset, UIntPtr size, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		public static CLResultCode EnqueueReadBuffer<T>(IntPtr commandQueue, IntPtr buffer, bool blockingRead,
			UIntPtr offset, int size, out T[] array, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr eventHandle)
		{
			array = new T[size];
			GCHandle handle = GCHandle.Alloc(array, GCHandleType.Pinned);

			CLResultCode resultCode = EnqueueReadBuffer(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), offset,
				(UIntPtr)(size * Marshal.SizeOf<T>()), handle.AddrOfPinnedObject(), numberOfEventsInWaitList,
				eventWaitList,
				out eventHandle);

			return resultCode;
		}

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="buffer"></param>
		/// <param name="blockingRead"></param>
		/// <param name="bufferOffset"></param>
		/// <param name="hostOffset"></param>
		/// <param name="region"></param>
		/// <param name="bufferRowPitch"></param>
		/// <param name="bufferSlicePitch"></param>
		/// <param name="hostRowPitch"></param>
		/// <param name="hostSlicePitch"></param>
		/// <param name="pointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueReadBufferRect")]
		public static extern CLResultCode EnqueueReadBufferRect(IntPtr commandQueue, IntPtr buffer, uint blockingRead,
			UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch,
			UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, IntPtr pointer,
			uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="buffer"></param>
		/// <param name="blockingWrite"></param>
		/// <param name="offset"></param>
		/// <param name="size"></param>
		/// <param name="pointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueWriteBuffer")]
		public static extern CLResultCode EnqueueWriteBuffer(IntPtr commandQueue, IntPtr buffer, uint blockingWrite,
			UIntPtr offset, UIntPtr size, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		public static CLResultCode EnqueueWriteBuffer<T>(IntPtr commandQueue, IntPtr buffer, bool blockingRead,
			UIntPtr offset, int size, T[] array, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event)
		{
			GCHandle handle = GCHandle.Alloc(array, GCHandleType.Pinned);

			CLResultCode resultCode = EnqueueWriteBuffer(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), offset,
				(UIntPtr)(size * Marshal.SizeOf<T>()), handle.AddrOfPinnedObject(), numberOfEventsInWaitList,
				eventWaitList, out @event);

			return resultCode;
		}

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="buffer"></param>
		/// <param name="blockingWrite"></param>
		/// <param name="bufferOffset"></param>
		/// <param name="hostOffset"></param>
		/// <param name="region"></param>
		/// <param name="bufferRowPitch"></param>
		/// <param name="bufferSlicePitch"></param>
		/// <param name="hostRowPitch"></param>
		/// <param name="hostSlicePitch"></param>
		/// <param name="pointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueWriteBufferRect")]
		public static extern CLResultCode EnqueueWriteBufferRect(IntPtr commandQueue, IntPtr buffer, uint blockingWrite,
			UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch,
			UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, IntPtr pointer,
			uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="buffer"></param>
		/// <param name="pattern"></param>
		/// <param name="patternSize"></param>
		/// <param name="offset"></param>
		/// <param name="size"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueFillBuffer")]
		public static extern CLResultCode EnqueueFillBuffer(IntPtr commandQueue, IntPtr buffer, IntPtr pattern,
			UIntPtr patternSize, UIntPtr offset, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="srcBuffer"></param>
		/// <param name="dstBuffer"></param>
		/// <param name="srcOffset"></param>
		/// <param name="dstOffset"></param>
		/// <param name="size"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueCopyBuffer")]
		public static extern CLResultCode EnqueueCopyBuffer(IntPtr commandQueue, IntPtr srcBuffer, IntPtr dstBuffer,
			UIntPtr srcOffset, UIntPtr dstOffset, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="srcBuffer"></param>
		/// <param name="dstBuffer"></param>
		/// <param name="srcOrigin"></param>
		/// <param name="dstOrigin"></param>
		/// <param name="region"></param>
		/// <param name="srcRowPitch"></param>
		/// <param name="srcSlicePitch"></param>
		/// <param name="dstRowPitch"></param>
		/// <param name="dstSlicePitch"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueCopyBufferRect")]
		public static extern CLResultCode EnqueueCopyBufferRect(IntPtr commandQueue, IntPtr srcBuffer, IntPtr dstBuffer,
			UIntPtr[] srcOrigin, UIntPtr[] dstOrigin, UIntPtr[] region, UIntPtr srcRowPitch, UIntPtr srcSlicePitch,
			UIntPtr dstRowPitch, UIntPtr dstSlicePitch, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="image"></param>
		/// <param name="blockingRead"></param>
		/// <param name="origin"></param>
		/// <param name="region"></param>
		/// <param name="rowPitch"></param>
		/// <param name="slicePitch"></param>
		/// <param name="pointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueReadImage")]
		public static extern CLResultCode EnqueueReadImage(IntPtr commandQueue, IntPtr image, uint blockingRead,
			UIntPtr[] origin, UIntPtr[] region, UIntPtr rowPitch, UIntPtr slicePitch, IntPtr pointer,
			uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="image"></param>
		/// <param name="blockingWrite"></param>
		/// <param name="origin"></param>
		/// <param name="region"></param>
		/// <param name="inputRowPitch"></param>
		/// <param name="inputSlicePitch"></param>
		/// <param name="pointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueWriteImage")]
		public static extern CLResultCode EnqueueWriteImage(IntPtr commandQueue, IntPtr image, uint blockingWrite,
			UIntPtr[] origin, UIntPtr[] region, UIntPtr inputRowPitch, UIntPtr inputSlicePitch, IntPtr pointer,
			uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="image"></param>
		/// <param name="fillColor"></param>
		/// <param name="origin"></param>
		/// <param name="region"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueFillImage")]
		public static extern CLResultCode EnqueueFillImage(IntPtr commandQueue, IntPtr image, IntPtr fillColor,
			UIntPtr[] origin, UIntPtr[] region, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="srcImage"></param>
		/// <param name="dstImage"></param>
		/// <param name="srcOrigin"></param>
		/// <param name="dstOrigin"></param>
		/// <param name="region"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueCopyImage")]
		public static extern CLResultCode EnqueueCopyImage(IntPtr commandQueue, IntPtr srcImage, IntPtr dstImage,
			UIntPtr[] srcOrigin, UIntPtr[] dstOrigin, UIntPtr[] region, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

//Introduced in OpenCL 1.0
		[DllImport(LibName, EntryPoint = "clEnqueueCopyImageToBuffer")]
		public static extern CLResultCode EnqueueCopyImageToBuffer(IntPtr commandQueue, IntPtr srcImage,
			IntPtr dstBuffer, UIntPtr[] srcOrigin, UIntPtr[] region, UIntPtr dstOffset, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="srcBuffer"></param>
		/// <param name="dstImage"></param>
		/// <param name="srcOffset"></param>
		/// <param name="dstOrigin"></param>
		/// <param name="region"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueCopyBufferToImage")]
		public static extern CLResultCode EnqueueCopyBufferToImage(IntPtr commandQueue, IntPtr srcBuffer,
			IntPtr dstImage, UIntPtr srcOffset, UIntPtr[] dstOrigin, UIntPtr[] region, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="buffer"></param>
		/// <param name="blockingMap"></param>
		/// <param name="flags"></param>
		/// <param name="offset"></param>
		/// <param name="size"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueMapBuffer")]
		public static extern IntPtr EnqueueMapBuffer(IntPtr commandQueue, IntPtr buffer, uint blockingMap,
			MapFlags flags, UIntPtr offset, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="image"></param>
		/// <param name="blockingMap"></param>
		/// <param name="flags"></param>
		/// <param name="origin"></param>
		/// <param name="region"></param>
		/// <param name="rowPitch"></param>
		/// <param name="slicePitch"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueMapImage")]
		public static extern IntPtr EnqueueMapImage(IntPtr commandQueue, IntPtr image, uint blockingMap, MapFlags flags,
			UIntPtr[] origin, UIntPtr[] region, UIntPtr rowPitch, UIntPtr slicePitch, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="memoryObject"></param>
		/// <param name="mapperPtr"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueUnmapMemObject")]
		public static extern CLResultCode EnqueueUnmapMemObject(IntPtr commandQueue, IntPtr memoryObject,
			IntPtr mapperPtr, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="numberOfMemoryObjects"></param>
		/// <param name="memoryObjects"></param>
		/// <param name="flags"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueMigrateMemObjects")]
		public static extern CLResultCode EnqueueMigrateMemObjects(IntPtr commandQueue, uint numberOfMemoryObjects,
			IntPtr[] memoryObjects, MemoryMigrationFlags flags, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="kernel"></param>
		/// <param name="workDimension"></param>
		/// <param name="globalWorkOffset"></param>
		/// <param name="globalWorkSize"></param>
		/// <param name="localWorkSize"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueNDRangeKernel")]
		public static extern CLResultCode EnqueueNDRangeKernel(IntPtr commandQueue, IntPtr kernel, uint workDimension,
			IntPtr[] globalWorkOffset, IntPtr[] globalWorkSize, IntPtr[] localWorkSize, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="userFunction"></param>
		/// <param name="arguments"></param>
		/// <param name="argumentSize"></param>
		/// <param name="numberOfMemoryObjects"></param>
		/// <param name="memoryObjects"></param>
		/// <param name="argumentsMemoryLocation"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueNativeKernel")]
		public static extern CLResultCode EnqueueNativeKernel(IntPtr commandQueue, IntPtr userFunction,
			IntPtr[] arguments, UIntPtr argumentSize, uint numberOfMemoryObjects, IntPtr[] memoryObjects,
			IntPtr argumentsMemoryLocation, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="numberOfMemoryObjects"></param>
		/// <param name="memoryObjects"></param>
		/// <param name="argumentsMemoryLocation"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueMarkerWithWaitList")]
		public static extern CLResultCode EnqueueMarkerWithWaitList(IntPtr commandQueue, uint numberOfMemoryObjects,
			IntPtr[] memoryObjects, IntPtr argumentsMemoryLocation, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="numberOfMemoryObjects"></param>
		/// <param name="memoryObjects"></param>
		/// <param name="argumentsMemoryLocation"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueBarrierWithWaitList")]
		public static extern CLResultCode EnqueueBarrierWithWaitList(IntPtr commandQueue, uint numberOfMemoryObjects,
			IntPtr[] memoryObjects, IntPtr argumentsMemoryLocation, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="numberOfSvmPointers"></param>
		/// <param name="svmPointers"></param>
		/// <param name="svmFreePointersCallback"></param>
		/// <param name="userData"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueSVMFree")]
		public static extern CLResultCode EnqueueSVMFree(IntPtr commandQueue, uint numberOfSvmPointers,
			IntPtr[] svmPointers, IntPtr svmFreePointersCallback, IntPtr userData, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="blockingCopy"></param>
		/// <param name="dstPointer"></param>
		/// <param name="srcPointer"></param>
		/// <param name="size"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMemcpy")]
		public static extern CLResultCode EnqueueSvmMemoryCopy(IntPtr commandQueue, uint blockingCopy,
			IntPtr dstPointer, IntPtr srcPointer, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="svmPointer"></param>
		/// <param name="pattern"></param>
		/// <param name="patternSize"></param>
		/// <param name="size"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMemFill")]
		public static extern CLResultCode EnqueueSvmMemoryFill(IntPtr commandQueue, IntPtr svmPointer, IntPtr pattern,
			UIntPtr patternSize, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList,
			out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="blockingMap"></param>
		/// <param name="mapFlag"></param>
		/// <param name="svmPointer"></param>
		/// <param name="size"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMap")]
		public static extern CLResultCode EnqueueSvmMap(IntPtr commandQueue, uint blockingMap, MapFlags mapFlag,
			IntPtr svmPointer, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="svmPointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueSVMUnmap")]
		public static extern CLResultCode EnqueueSVMUnmap(IntPtr commandQueue, IntPtr svmPointer,
			uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="numberOfSvmPointers"></param>
		/// <param name="svmPointers"></param>
		/// <param name="sizes"></param>
		/// <param name="memoryMigrationFlags"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMigrateMem")]
		public static extern CLResultCode EnqueueSvmMigrateMemory(IntPtr commandQueue, uint numberOfSvmPointers,
			IntPtr[] svmPointers, UIntPtr[] sizes, MemoryMigrationFlags memoryMigrationFlags,
			uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		#endregion

		#region Extension function access

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="platform"></param>
		/// <param name="functionName"></param>
		/// <returns></returns>
		[DllImport(LibName, EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
		public static extern IntPtr GetExtensionFunctionAddressForPlatform(IntPtr platform, string functionName);

		#endregion

		#region Deprecated OpenCL API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="flags"></param>
		/// <param name="imageFormat"></param>
		/// <param name="imageWidth"></param>
		/// <param name="imageHeight"></param>
		/// <param name="imageRowPitch"></param>
		/// <param name="hostPointer"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[Obsolete("Deprecated method")]
		[DllImport(LibName, EntryPoint = "clCreateImage2D")]
		public static extern IntPtr CreateImage2D(IntPtr context, MemoryFlags flags, ImageFormat imageFormat,
			UIntPtr imageWidth, UIntPtr imageHeight, UIntPtr imageRowPitch, IntPtr hostPointer,
			out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="flags"></param>
		/// <param name="imageFormat"></param>
		/// <param name="imageWidth"></param>
		/// <param name="imageHeight"></param>
		/// <param name="imageDepth"></param>
		/// <param name="imageRowPitch"></param>
		/// <param name="imageSlicePitch"></param>
		/// <param name="hostPointer"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[Obsolete("Deprecated method")]
		[DllImport(LibName, EntryPoint = "clCreateImage3D")]
		public static extern IntPtr CreateImage3D(IntPtr context, MemoryFlags flags, ImageFormat imageFormat,
			UIntPtr imageWidth, UIntPtr imageHeight, UIntPtr imageDepth, UIntPtr imageRowPitch, UIntPtr imageSlicePitch,
			IntPtr hostPointer, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use EnqueueMarkerWithWaitList.")]
		[DllImport(LibName, EntryPoint = "clEnqueueMarker")]

		public static extern CLResultCode EnqueueMarker(IntPtr commandQueue, IntPtr @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventList"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use EnqueueMarkerWithWaitList.")]
		[DllImport(LibName, EntryPoint = "clEnqueueWaitForEvents")]
		public static extern CLResultCode EnqueueWaitForEvents(IntPtr commandQueue, uint numberOfEventsInWaitList,
			IntPtr[] eventList);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use EnqueueBarrierWithWaitList.")]
		[DllImport(LibName, EntryPoint = "clEnqueueBarrier")]
		public static extern CLResultCode EnqueueBarrier(IntPtr commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use UnloadPlatformCompiler.")]
		[DllImport(LibName, EntryPoint = "clUnloadCompiler")]
		public static extern CLResultCode UnloadCompiler();

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="funcName"></param>
		/// <returns></returns>
		[Obsolete("Deprecated method")]
		[DllImport(LibName, EntryPoint = "clGetExtensionFunctionAddress")]
		public static extern CLResultCode GetExtensionFunctionAddress(string funcName);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="device"></param>
		/// <param name="properties"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.2, use CreateCommandQueueWithProperties.")]
		[DllImport(LibName, EntryPoint = "clCreateCommandQueue")]
		public static extern IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperty properties,
			out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="normalizedCoordinates"></param>
		/// <param name="addressingMode"></param>
		/// <param name="filterMode"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.2, use CreateImage.")]
		[DllImport(LibName, EntryPoint = "clCreateSampler")]
		public static extern IntPtr CreateSampler(IntPtr context, uint normalizedCoordinates,
			AddressingMode addressingMode, FilterMode filterMode, out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="kernel"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.2")]
		[DllImport(LibName, EntryPoint = "clEnqueueBarrier")]
		public static extern CLResultCode EnqueueTask(IntPtr commandQueue, IntPtr kernel, uint numberOfEventsInWaitList,
			IntPtr[] eventWaitList, out IntPtr @event);

		#endregion
	}
}
