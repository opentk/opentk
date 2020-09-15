using System;
using System.Runtime.InteropServices;
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
		private const CallingConvention CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;

		public delegate void ClEventCallback(IntPtr waitEvent, IntPtr userData);

		#region Platform API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// See more: https://www.khronos.org/registry/OpenCL/sdk/2.2/docs/man/html/clGetPlatformIDs.html
		/// </summary>
		/// <param name="numberOfEntries">number of <see cref="CLPlatform"/> entries that can be added to platforms. If platforms is not NULL, numberOfEntries must be greater than zero.</param>
		/// <param name="platforms">returns a list of OpenCL platforms found. The CLPlatform values returned in platforms can be used to identify a specific OpenCL platform. If platforms is NULL, this argument is ignored. The number of OpenCL platforms returned is the minimum of the value specified by numberOfEntries or the number of OpenCL platforms available.</param>
		/// <param name="numberOfPlatforms">returns the number of OpenCL platforms available. If numberOfPlatforms is NULL, this argument is ignored.</param>
		/// <returns>returns <see cref="CLResultCode.Success"/> if the function is executed successfully. Otherwise, it returns one of the following errors:
		/// -InvalidValue if numberOfEntries is equal to zero and platforms is not NULL or if both numberOfPlatforms and platforms are NULL.
		/// -OutOfHostMemory if there is a failure to allocate resources required by the OpenCL implementation on the host.</returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetPlatformIDs")]
		public static extern CLResultCode GetPlatformIds([In] uint numberOfEntries, [Out] CLPlatform[] platforms,
			[Out] out uint numberOfPlatforms);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="platformIds">returns a list of OpenCL platforms found. The CLPlatform values returned in platforms can be used to identify a specific OpenCL platform.</param>
		/// <returns>returns Success if the function is executed successfully. Otherwise, it returns one of the following errors:
		/// -InvalidValue if numberOfEntries is equal to zero and platforms is not NULL or if both numberOfPlatforms and platforms are NULL.
		/// -OutOfHostMemory if there is a failure to allocate resources required by the OpenCL implementation on the host.</returns>
		public static CLResultCode GetPlatformIds(out CLPlatform[] platformIds)
		{
			GetPlatformIds(0, null, out uint platformCount);
			platformIds = new CLPlatform[platformCount];
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetPlatformInfo")]
		public static extern CLResultCode GetPlatformInfo([In] CLPlatform platform, [In] PlatformInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetPlatformInfo(CLPlatform platform, PlatformInfo paramName, out byte[] paramValue)
		{
			GetPlatformInfo(platform, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
			paramValue = new byte[sizeReturned.ToUInt64()];
			return GetPlatformInfo(platform, paramName, sizeReturned, paramValue, out _);
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceIDs")]
		public static extern CLResultCode GetDeviceIds([In] CLPlatform platform, [In] DeviceType deviceType,
			[In] uint numberOfEntries,
			[Out] CLDevice[] devices, [Out] out uint numberOfDevicesReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetDeviceIds(CLPlatform platform, DeviceType deviceType, out CLDevice[] deviceIds)
		{
			GetDeviceIds(platform, deviceType, 0, null, out uint deviceCount);
			deviceIds = new CLDevice[deviceCount];
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceInfo")]
		public static extern CLResultCode GetDeviceInfo([In] CLDevice device, [In] DeviceInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetDeviceInfo(CLDevice device, DeviceInfo paramName, out byte[] paramValue)
		{
			GetDeviceInfo(device, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
			paramValue = new byte[sizeReturned.ToUInt64()];
			return GetDeviceInfo(device, paramName, sizeReturned, paramValue, out _);
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSubDevices")]
		public static extern CLResultCode CreateSubDevices([In] CLDevice inDevice, [In] IntPtr[] properties,
			[In] uint numberOfDevices,
			[Out] CLDevice[] outDevices, [Out] out uint devicesReturned);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="device"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainDevice")]
		public static extern CLResultCode RetainDevice([In] CLDevice device);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="device"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseDevice")]
		public static extern CLResultCode ReleaseDevice([In] CLDevice device);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="context"></param>
		/// <param name="device"></param>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetDefaultDeviceCommandQueue")]
		public static extern CLResultCode SetDefaultDeviceCommandQueue([In] CLContext context, [In] CLDevice device,
			[In] CLCommandQueue commandQueue);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="device"></param>
		/// <param name="deviceTimestamp"></param>
		/// <param name="hostTimestamp"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceAndHostTimer")]
		public static extern CLResultCode GetDeviceAndHostTimer([In] CLDevice device, IntPtr deviceTimestamp,
			IntPtr hostTimestamp);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="device"></param>
		/// <param name="hostTimestamp"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetHostTimer")]
		public static extern CLResultCode GetHostTimer([In] CLDevice device, IntPtr hostTimestamp);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateContext")]
		public static extern CLContext CreateContext([In] IntPtr properties, [In] uint numberOfDevices,
			[In] CLDevice[] devices,
			[In] IntPtr notificationCallback, [In] IntPtr userData, [Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLContext CreateContext([In] IntPtr properties, [In] CLDevice[] devices,
			IntPtr notificationCallback,
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateContextFromType")]
		public static extern CLContext CreateContextFromType([In] IntPtr properties, [In] DeviceType deviceType,
			[In] IntPtr notificationCallback, [In] IntPtr userData, [Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainContext")]
		public static extern CLResultCode RetainContext([In] CLContext context);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseContext")]
		public static extern CLResultCode ReleaseContext([In] CLContext context);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetContextInfo")]
		public static extern CLResultCode GetContextInfo([In] CLContext context, [In] ContextInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);


		public static CLResultCode GetContextInfo(CLContext context, ContextInfo paramName, out byte[] paramValue)
		{
			GetContextInfo(context, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
			paramValue = new byte[sizeReturned.ToUInt64()];
			return GetContextInfo(context, paramName, sizeReturned, paramValue, out _);
		}

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateCommandQueueWithProperties")]
		public static extern IntPtr CreateCommandQueueWithProperties([In] CLContext context, [In] IntPtr device,
			[In] IntPtr properties,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainCommandQueue")]
		public static extern CLResultCode RetainCommandQueue([In] CLCommandQueue commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseCommandQueue")]
		public static extern CLResultCode ReleaseCommandQueue([In] CLCommandQueue commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="paramName"></param>
		/// <param name="paramSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetCommandQueueInfo")]
		public static extern CLResultCode GetCommandQueueInfo([In] CLCommandQueue commandQueue,
			[In] CommandQueueInfo paramName,
			[In] UIntPtr paramSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		public static CLResultCode GetCommandQueueInfo(CLCommandQueue queue, CommandQueueInfo paramName,
			out byte[] paramValue)
		{
			GetCommandQueueInfo(queue, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
			paramValue = new byte[sizeReturned.ToUInt64()];
			return GetCommandQueueInfo(queue, paramName, sizeReturned, paramValue, out _);
		}

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateBuffer")]
		public static extern CLBuffer CreateBuffer([In] CLContext context, [In] MemoryFlags flags, [In] UIntPtr size,
			[In] IntPtr hostPtr,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static unsafe CLBuffer CreateBuffer<T>(CLContext context, MemoryFlags flags, T[] array,
			out CLResultCode errorCode) where T : unmanaged
		{
			fixed (T* b = array)
			{
				IntPtr buffer = CreateBuffer(context, flags, (UIntPtr)(sizeof(T) * array.Length), (IntPtr)b,
					out errorCode);
				return new CLBuffer(buffer);
			}
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static unsafe CLBuffer CreateBuffer<T>(CLContext context, MemoryFlags flags, Span<T> span,
			out CLResultCode errorCode) where T : unmanaged
		{
			fixed (T* b = span)
			{
				IntPtr buffer = CreateBuffer(context, flags, (UIntPtr)(sizeof(T) * span.Length), (IntPtr)b,
					out errorCode);
				return new CLBuffer(buffer);
			}
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSubBuffer")]
		public static extern CLBuffer CreateSubBuffer([In] CLBuffer buffer, [In] MemoryFlags flags,
			[In] BufferCreateType bufferCreateType,
			[In] IntPtr bufferCreateInfo, [Out] out CLResultCode errorCode);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage")]
		public static extern CLImage CreateImage([In] CLContext context, [In] MemoryFlags flags,
			[In] ImageFormat imageFormat,
			[In] ImageDescription imageDesc, [In] IntPtr hostPointer, [Out] out CLResultCode errorCode);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreatePipe")]
		public static extern CLPipe CreatePipe([In] CLContext context, [In] MemoryFlags flags, [In] uint pipePacketSize,
			[In] uint pipeMaxPackets, [In] IntPtr[] properties, [Out] out CLResultCode errorCode);


//TODO Add those 2 opencl 3.0 methods
/*
[ClVersion(3,0)]
[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateBufferWithProperties")]
public static extern IntPtr CreateBufferWithProperties(CLContext context, IntPtr[] properties, MemoryFlags flags, UIntPtr size, IntPtr hostPointer, out CLResultCode errorCode);
//const cl_mem_properties * properties,

[ClVersion(3,0)]
[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImageWithProperties")]
public static extern IntPtr CreateImageWithProperties(CLContext context, IntPtr[] properties, MemoryFlags flags, IntPtr imageFormat, IntPtr imageDesc, IntPtr hostPointer, out CLResultCode errorCode);
//const cl_mem_properties * properties,
*/

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="memoryObject"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
		public static extern CLResultCode RetainMemoryObject([In] IntPtr memoryObject);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
		public static extern CLResultCode RetainMemoryObject([In] CLBuffer memoryObject);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
		public static extern CLResultCode RetainMemoryObject([In] CLImage memoryObject);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
		public static extern CLResultCode RetainMemoryObject([In] CLPipe memoryObject);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="memoryObject"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
		public static extern CLResultCode ReleaseMemoryObject([In] IntPtr memoryObject);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
		public static extern CLResultCode ReleaseMemoryObject([In] CLBuffer memoryObject);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
		public static extern CLResultCode ReleaseMemoryObject([In] CLImage memoryObject);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
		public static extern CLResultCode ReleaseMemoryObject([In] CLPipe memoryObject);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetSupportedImageFormats")]
		public static extern CLResultCode GetSupportedImageFormats([In] CLContext context, [In] MemoryFlags flags,
			[In] MemoryObjectType imageType, [In] uint numberOfEntries, [Out] [MarshalAs(UnmanagedType.LPArray)]
			ImageFormat[] imageFormats,
			[Out] out uint numberOfImageFormats);

		/// <summary>
		/// Not sure if it works
		/// </summary>
		public static CLResultCode GetSupportedImageFormats(CLContext context, MemoryFlags flags,
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
		public static extern CLResultCode GetMemObjectInfo([In] IntPtr memoryObject, [In] MemoryObjectInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
		public static extern CLResultCode GetMemObjectInfo([In] CLBuffer memoryObject, [In] MemoryObjectInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
		public static extern CLResultCode GetMemObjectInfo([In] CLImage memoryObject, [In] MemoryObjectInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
		public static extern CLResultCode GetMemObjectInfo([In] CLPipe memoryObject, [In] MemoryObjectInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetMemObjectInfo(IntPtr memoryObject, MemoryObjectInfo paramName,
			out byte[] paramValue)
		{
			GetMemObjectInfo(memoryObject, paramName, UIntPtr.Zero, null, out UIntPtr size);
			paramValue = new byte[size.ToUInt64()];
			return GetMemObjectInfo(memoryObject, paramName, size, paramValue, out _);
		}

		public static CLResultCode GetMemObjectInfo(CLBuffer memoryObject, MemoryObjectInfo paramName,
			out byte[] paramValue)
		{
			return GetMemObjectInfo(memoryObject.Handle, paramName, out paramValue);
		}

		public static CLResultCode GetMemObjectInfo(CLImage memoryObject, MemoryObjectInfo paramName,
			out byte[] paramValue)
		{
			return GetMemObjectInfo(memoryObject.Handle, paramName, out paramValue);
		}

		public static CLResultCode GetMemObjectInfo(CLPipe memoryObject, MemoryObjectInfo paramName,
			out byte[] paramValue)
		{
			return GetMemObjectInfo(memoryObject.Handle, paramName, out paramValue);
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetImageInfo")]
		public static extern CLResultCode GetImageInfo([In] CLImage image, [In] ImageInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetImageInfo(CLImage image, ImageInfo paramName, out byte[] paramValue)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetPipeInfo")]
		public static extern CLResultCode GetPipeInfo([In] CLPipe pipe, [In] PipeInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		public static CLResultCode GetPipeInfo(CLPipe pipe, PipeInfo paramName, out byte[] paramValue)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
		public static extern CLResultCode SetMemoryObjectDestructorCallback([In] IntPtr memoryObject,
			[In] IntPtr notificationCallback, [In] IntPtr userData);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
		public static extern CLResultCode SetMemoryObjectDestructorCallback([In] CLBuffer memoryObject,
			[In] IntPtr notificationCallback, [In] IntPtr userData);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
		public static extern CLResultCode SetMemoryObjectDestructorCallback([In] CLImage memoryObject,
			[In] IntPtr notificationCallback, [In] IntPtr userData);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
		public static extern CLResultCode SetMemoryObjectDestructorCallback([In] CLPipe memoryObject,
			[In] IntPtr notificationCallback, [In] IntPtr userData);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSVMAlloc")]
		public static extern IntPtr SVMAlloc([In] CLContext context, [In] SvmMemoryFlags flags, [In] UIntPtr size,
			[In] uint alignment);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="svmPointer"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSVMFree")]
		public static extern IntPtr SVMFree([In] CLContext context, [In] IntPtr svmPointer);

		#endregion

		#region Sampler API

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="samplerProperties"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSamplerWithProperties")]
		public static extern CLSampler CreateSamplerWithProperties([In] CLContext context,
			[In] IntPtr samplerProperties,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="sampler"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainSampler")]
		public static extern CLResultCode RetainSampler([In] CLSampler sampler);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="sampler"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseSampler")]
		public static extern CLResultCode ReleaseSampler([In] CLSampler sampler);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="sampler"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetSamplerInfo")]
		public static extern CLResultCode GetSamplerInfo([In] CLSampler sampler, [In] SamplerInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetSamplerInfo(CLSampler sampler, SamplerInfo paramName, out byte[] paramValue)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithSource")]
		public static extern CLProgram CreateProgramWithSource([In] CLContext context, [In] uint count,
			[In] IntPtr[] strings,
			[In] uint[] lengths, [Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLProgram CreateProgramWithSource(CLContext context, string source, out CLResultCode errorCode)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithBinary")]
		public static extern CLProgram CreateProgramWithBinary([In] CLContext context, [In] uint numberOfDevices,
			[In] IntPtr[] deviceList,
			[In] UIntPtr[] lengths, [In] IntPtr[] binaries, [Out] out CLResultCode[] binaryStatus,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="context"></param>
		/// <param name="numberOfDevices"></param>
		/// <param name="deviceList"></param>
		/// <param name="kernelNames"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithBuiltInKernels")]
		public static extern CLProgram CreateProgramWithBuiltInKernels([In] CLContext context,
			[In] uint numberOfDevices,
			[In] IntPtr[] deviceList, [In] string kernelNames, [Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="context"></param>
		/// <param name="il"></param>
		/// <param name="length"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithIL")]
		public static extern CLProgram CreateProgramWithIL([In] CLContext context, [In] IntPtr il, [In] UIntPtr length,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainProgram")]
		public static extern CLResultCode RetainProgram([In] CLProgram program);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseProgram")]
		public static extern CLResultCode ReleaseProgram([In] CLProgram program);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clBuildProgram")]
		public static extern CLResultCode BuildProgram([In] CLProgram program, [In] uint numberOfDevices,
			[In] CLDevice[] deviceList,
			[In] string options, [In] IntPtr notificationCallback, [In] IntPtr userData);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCompileProgram")]
		public static extern CLResultCode CompileProgram([In] CLProgram program, [In] uint numberOfDevices,
			[In] CLDevice[] deviceList,
			[In] string options, [In] uint numberOfInputDevices, [In] IntPtr[] inputHeaders,
			[Out] out IntPtr headerIncludeNames,
			[In] IntPtr notificationCallback, [In] IntPtr userData);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clLinkProgram")]
		public static extern CLProgram LinkProgram([In] CLContext context, [In] uint numberOfDevices,
			[In] CLDevice[] deviceList,
			[In] string options, [In] uint numberOfPrograms, [In] CLProgram[] inputPrograms,
			[In] IntPtr notificationCallback, [In] IntPtr userData,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 2.2
		/// </summary>
		/// <param name="program"></param>
		/// <param name="notificationCallback"></param>
		/// <param name="userData"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetProgramReleaseCallback")]
		public static extern CLResultCode SetProgramReleaseCallback([In] CLProgram program,
			[In] IntPtr notificationCallback,
			[In] IntPtr userData);

		/// <summary>
		/// Introduced in OpenCL 2.2
		/// </summary>
		/// <param name="program"></param>
		/// <param name="specId"></param>
		/// <param name="specSize"></param>
		/// <param name="specValue"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetProgramSpecializationConstant")]
		public static extern CLResultCode SetProgramSpecializationConstant([In] CLProgram program, [In] uint specId,
			[In] UIntPtr specSize, [In, Out] IntPtr specValue);
//WARN Not sure if it's supposed to be an in or an out

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="platform"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clUnloadPlatformCompiler")]
		public static extern CLResultCode UnloadPlatformCompiler([In] CLPlatform platform);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramValueSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetProgramInfo")]
		public static extern CLResultCode GetProgramInfo([In] CLProgram program, [In] ProgramInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetProgramInfo(CLProgram program, ProgramInfo paramName, out byte[] paramValue)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetProgramBuildInfo")]
		public static extern CLResultCode GetProgramBuildInfo([In] CLProgram program, [In] CLDevice device,
			[In] ProgramBuildInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetProgramBuildInfo(CLProgram program, CLDevice device, ProgramBuildInfo paramName,
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateKernel")]
		public static extern CLKernel CreateKernel([In] CLProgram program, [In] string name,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="program"></param>
		/// <param name="numberOfKernels"></param>
		/// <param name="kernels"></param>
		/// <param name="numberOfKernelsReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateKernelsInProgram")]
		public static extern CLResultCode CreateKernelsInProgram([In] CLProgram program, [In] uint numberOfKernels,
			[In] CLKernel[] kernels,
			[Out] out uint numberOfKernelsReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode CreateKernelsInProgram(CLProgram program, out CLKernel[] kernels)
		{
			CreateKernelsInProgram(program, 0, null, out uint count);
			kernels = new CLKernel[count];
			return CreateKernelsInProgram(program, count, kernels, out _);
		}


		/// <summary>
		/// Introduced in OpenCL 2.1
		/// </summary>
		/// <param name="sourceKernel"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCloneKernel")]
		public static extern CLKernel CloneKernel([In] CLKernel sourceKernel, [Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainKernel")]
		public static extern CLResultCode RetainKernel([In] CLKernel kernel);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseKernel")]
		public static extern CLResultCode ReleaseKernel([In] CLKernel kernel);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="argumentIndex"></param>
		/// <param name="argumentSize"></param>
		/// <param name="argumentValuePointer"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelArg")]
		public static extern CLResultCode SetKernelArg([In] CLKernel kernel, [In] uint argumentIndex,
			[In] UIntPtr argumentSize,
			[In] IntPtr argumentValuePointer);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="argumentIndex"></param>
		/// <param name="argumentValuePointer"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelArgSVMPointer")]
		public static extern CLResultCode SetKernelArgSVMPointer([In] CLKernel kernel, [In] uint argumentIndex,
			[In] IntPtr argumentValuePointer);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelExecInfo")]
		public static extern CLResultCode SetKernelExecInfo([In] CLKernel kernel, [In] KernelExecInfo paramName,
			[In] UIntPtr paramValueSize, [In] IntPtr paramValue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="kernel"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelInfo")]
		public static extern CLResultCode GetKernelInfo([In] CLKernel kernel, [In] KernelInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetKernelInfo(CLKernel kernel, KernelInfo paramName, out byte[] paramValue)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelArgInfo")]
		public static extern CLResultCode GetKernelArgInfo([In] CLKernel kernel, [In] uint argumentIndex,
			[In] KernelArgInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		public static CLResultCode GetKernelArgInfo(CLKernel kernel, uint argumentIndex, KernelArgInfo paramName,
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelWorkGroupInfo")]
		public static extern CLResultCode GetKernelWorkGroupInfo([In] CLKernel kernel, [In] CLDevice device,
			[In] KernelWorkGroupInfo paramName, [In] UIntPtr paramValueSize, [Out] byte[] paramValue,
			[Out] out UIntPtr paramSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetKernelWorkGroupInfo(CLKernel kernel, CLDevice device,
			KernelWorkGroupInfo paramName,
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelSubGroupInfo")]
		public static extern CLResultCode GetKernelSubGroupInfo([In] CLKernel kernel, [In] CLDevice device,
			[In] KernelSubGroupInfo paramName, [In] UIntPtr inputValueSize, [In] IntPtr inputValue,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramSizeReturned);

		#endregion

		#region Event Object API

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="numberOfEvents"></param>
		/// <param name="eventList"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clWaitForEvents")]
		public static extern CLResultCode WaitForEvents([In] uint numberOfEvents, [In] CLEvent[] eventList);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="event"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValueSize"></param>
		/// <param name="paramValue"></param>
		/// <param name="paramSizeReturned"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetEventInfo")]
		public static extern CLResultCode GetEventInfo([In] CLEvent @event, [In] EventInfo paramName,
			[In] UIntPtr paramValueSize,
			[Out] byte[] paramValue, [Out] out UIntPtr paramSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetEventInfo(CLEvent @event, EventInfo paramName, out byte[] paramValue)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateUserEvent")]
		public static extern CLEvent CreateUserEvent([In] CLContext context, [Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainEvent")]
		public static extern CLResultCode RetainEvent([In] CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseEvent")]
		public static extern CLResultCode ReleaseEvent([In] CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="event"></param>
		/// <param name="executionStatus"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetUserEventStatus")]
		public static extern CLResultCode SetUserEventStatus([In] CLEvent @event, [In] int executionStatus);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		/// <param name="eventHandle"></param>
		/// <param name="commandExecCallbackType"></param>
		/// <param name="notifyCallback"></param>
		/// <param name="userData"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetEventCallback")]
		public static extern CLResultCode SetEventCallback([In] CLEvent eventHandle, [In] int commandExecCallbackType,
			[In] IntPtr notifyCallback, [In] IntPtr userData);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		public static CLResultCode SetEventCallback(CLEvent eventHandle, int callbackType,
			ClEventCallback notifyCallback)
		{
			return SetEventCallback(eventHandle, callbackType,
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetEventProfilingInfo")]
		public static extern CLResultCode GetEventProfilingInfo([In] CLEvent @event, [In] ProfilingInfo paramName,
			[In] UIntPtr paramValueSize, [Out] byte[] paramValue, [Out] out UIntPtr paramValueSizeReturned);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static CLResultCode GetEventProfilingInfo(CLEvent @event, ProfilingInfo paramName, out byte[] paramValue)
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clFlush")]
		public static extern CLResultCode Flush([In] CLCommandQueue commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clFinish")]
		public static extern CLResultCode Finish([In] CLCommandQueue commandQueue);

		#endregion

		#region Enqueued Commands API

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadBuffer")]
		public static extern CLResultCode EnqueueReadBuffer([In] CLCommandQueue commandQueue, [In] CLBuffer buffer,
			[In] uint blockingRead,
			[In] UIntPtr offset, [In] UIntPtr size, [In] IntPtr pointer, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static unsafe CLResultCode EnqueueReadBuffer<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingRead,
			UIntPtr offset, int length, out T[] array, CLEvent[] eventWaitList, out CLEvent eventHandle)
			where T : unmanaged
		{
			array = new T[length];
			fixed (T* b = array)
			{
				CLResultCode resultCode = EnqueueReadBuffer(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), offset,
					(UIntPtr)(length*sizeof(T)), (IntPtr)b, (uint)(eventWaitList?.Length ?? 0),
					eventWaitList,
					out eventHandle);
				return resultCode;
			}
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static unsafe CLResultCode EnqueueReadBuffer<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingRead,
			UIntPtr offset, int length, out Span<T> array, CLEvent[] eventWaitList, out CLEvent eventHandle)
			where T : unmanaged
		{
			array = new T[length];
			fixed (T* b = array)
			{
				CLResultCode resultCode = EnqueueReadBuffer(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), offset,
					(UIntPtr)(length * sizeof(T)), (IntPtr)b, (uint)(eventWaitList?.Length ?? 0),
					eventWaitList, out eventHandle);
				return resultCode;
			}
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadBufferRect")]
		public static extern CLResultCode EnqueueReadBufferRect([In] CLCommandQueue commandQueue, [In] CLBuffer buffer,
			[In] uint blockingRead,
			[In] UIntPtr[] bufferOffset, [In] UIntPtr[] hostOffset, [In] UIntPtr[] region, [In] UIntPtr bufferRowPitch,
			[In] UIntPtr bufferSlicePitch, [In] UIntPtr hostRowPitch, [In] UIntPtr hostSlicePitch, [In] IntPtr pointer,
			[In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		public static unsafe CLResultCode EnqueueReadBufferRect<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingRead,
			UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch,
			UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, T[] array,
			CLEvent[] eventWaitList, out CLEvent @event) where T : unmanaged
		{
			fixed (T* a = array)
			{
				return EnqueueReadBufferRect(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), bufferOffset,
					hostOffset, region,
					bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
					(uint)(eventWaitList?.Length ?? 0),
					eventWaitList, out @event);
			}
		}

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		public static unsafe CLResultCode EnqueueReadBufferRect<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingRead,
			UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch,
			UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, Span<T> span,
			CLEvent[] eventWaitList, out CLEvent @event) where T : unmanaged
		{
			fixed (T* a = span)
			{
				return EnqueueReadBufferRect(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), bufferOffset,
					hostOffset, region,
					bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
					(uint)(uint)(eventWaitList?.Length ?? 0),
					eventWaitList, out @event);
			}
		}

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWriteBuffer")]
		public static extern CLResultCode EnqueueWriteBuffer([In] CLCommandQueue commandQueue, [In] CLBuffer buffer,
			[In] uint blockingWrite,
			[In] UIntPtr offset, [In] UIntPtr size, [In] IntPtr pointer, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static unsafe CLResultCode EnqueueWriteBuffer<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingRead,
			UIntPtr offset, int size, T[] array, CLEvent[] eventWaitList,
			out CLEvent @event) where T : unmanaged
		{
			fixed (T* a = array)
			{
				CLResultCode resultCode = EnqueueWriteBuffer(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), offset,
					(UIntPtr)size, (IntPtr)a, (uint)(eventWaitList?.Length ?? 0),
					eventWaitList, out @event);

				return resultCode;
			}
		}

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		public static unsafe CLResultCode EnqueueWriteBuffer<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingRead,
			UIntPtr offset, int size, Span<T> span, CLEvent[] eventWaitList,
			out CLEvent @event) where T : unmanaged
		{
			fixed (T* a = span)
			{
				CLResultCode resultCode = EnqueueWriteBuffer(commandQueue, buffer, (uint)(blockingRead ? 1 : 0), offset,
					(UIntPtr)size, (IntPtr)a, (uint)(eventWaitList?.Length ?? 0),
					eventWaitList, out @event);

				return resultCode;
			}
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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWriteBufferRect")]
		public static extern CLResultCode EnqueueWriteBufferRect([In] CLCommandQueue commandQueue, [In] CLBuffer buffer,
			[In] uint blockingWrite,
			[In] UIntPtr[] bufferOffset, [In] UIntPtr[] hostOffset, [In] UIntPtr[] region, [In] UIntPtr bufferRowPitch,
			[In] UIntPtr bufferSlicePitch, [In] UIntPtr hostRowPitch, [In] UIntPtr hostSlicePitch, [In] IntPtr pointer,
			[In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		public static unsafe CLResultCode EnqueueWriteBufferRect<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingWrite,
			UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch,
			UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, T[] array,
			CLEvent[] eventWaitList, out CLEvent @event) where T : unmanaged
		{
			fixed (T* a = array)
			{
				return EnqueueWriteBufferRect(commandQueue, buffer, (uint)(blockingWrite ? 1 : 0), bufferOffset,
					hostOffset, region,
					bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
					(uint)(eventWaitList?.Length ?? 0),
					eventWaitList, out @event);
			}
		}

		/// <summary>
		/// Introduced in OpenCL 1.1
		/// </summary>
		public static unsafe CLResultCode EnqueueWriteBufferRect<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			bool blockingWrite,
			UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch,
			UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, Span<T> span,
			CLEvent[] eventWaitList, out CLEvent @event) where T : unmanaged
		{
			fixed (T* a = span)
			{
				return EnqueueWriteBufferRect(commandQueue, buffer, (uint)(blockingWrite ? 1 : 0), bufferOffset,
					hostOffset, region,
					bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
					(uint)(eventWaitList?.Length ?? 0),
					eventWaitList, out @event);
			}
		}

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueFillBuffer")]
		public static extern CLResultCode EnqueueFillBuffer([In] CLCommandQueue commandQueue, [In] CLBuffer buffer,
			[In] IntPtr pattern,
			[In] UIntPtr patternSize, [In] UIntPtr offset, [In] UIntPtr size, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// !!!Overload not implemented!!!
		/// </summary>
		/// TODO IMPLEMENT THIS
		public static unsafe CLResultCode EnqueueFillBuffer<T>(CLCommandQueue commandQueue, CLBuffer buffer,
			T[] pattern,
			UIntPtr patternSize, UIntPtr offset, UIntPtr size, uint numberOfEventsInWaitList, CLEvent[] eventWaitList,
			out CLEvent @event) where T : unmanaged
		{
			throw new NotImplementedException();
		}

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBuffer")]
		public static extern CLResultCode EnqueueCopyBuffer(CLCommandQueue commandQueue, CLBuffer srcBuffer,
			CLBuffer dstBuffer,
			UIntPtr srcOffset, UIntPtr dstOffset, UIntPtr size, uint numberOfEventsInWaitList, CLEvent[] eventWaitList,
			out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBufferRect")]
		public static extern CLResultCode EnqueueCopyBufferRect([In] CLCommandQueue commandQueue,
			[In] CLBuffer srcBuffer, [In] CLBuffer dstBuffer,
			[In] UIntPtr[] srcOrigin, [In] UIntPtr[] dstOrigin, [In] UIntPtr[] region, [In] UIntPtr srcRowPitch,
			[In] UIntPtr srcSlicePitch,
			[In] UIntPtr dstRowPitch, [In] UIntPtr dstSlicePitch, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadImage")]
		public static extern CLResultCode EnqueueReadImage([In] CLCommandQueue commandQueue, [In] CLImage image,
			[In] uint blockingRead,
			[In] UIntPtr[] origin, [In] UIntPtr[] region, [In] UIntPtr rowPitch, [In] UIntPtr slicePitch,
			[In] IntPtr pointer,
			[In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWriteImage")]
		public static extern CLResultCode EnqueueWriteImage([In] CLCommandQueue commandQueue, [In] CLImage image,
			[In] uint blockingWrite,
			[In] UIntPtr[] origin, [In] UIntPtr[] region, [In] UIntPtr inputRowPitch, [In] UIntPtr inputSlicePitch,
			[In] IntPtr pointer,
			[In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueFillImage")]
		public static extern CLResultCode EnqueueFillImage([In] CLCommandQueue commandQueue, [In] CLImage image,
			[In] IntPtr fillColor,
			[In] UIntPtr[] origin, [In] UIntPtr[] region, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyImage")]
		public static extern CLResultCode EnqueueCopyImage([In] CLCommandQueue commandQueue, [In] CLImage srcImage,
			[In] CLImage dstImage,
			[In] UIntPtr[] srcOrigin, [In] UIntPtr[] dstOrigin, [In] UIntPtr[] region,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

//Introduced in OpenCL 1.0
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyImageToBuffer")]
		public static extern CLResultCode EnqueueCopyImageToBuffer([In] CLCommandQueue commandQueue,
			[In] CLImage srcImage,
			[In] CLBuffer dstBuffer, [In] UIntPtr[] srcOrigin, [In] UIntPtr[] region, [In] UIntPtr dstOffset,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBufferToImage")]
		public static extern CLResultCode EnqueueCopyBufferToImage([In] CLCommandQueue commandQueue,
			[In] CLBuffer srcBuffer,
			[In] CLImage dstImage, [In] UIntPtr srcOffset, [In] UIntPtr[] dstOrigin, [In] UIntPtr[] region,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMapBuffer")]
		public static extern IntPtr EnqueueMapBuffer([In] CLCommandQueue commandQueue, [In] CLBuffer buffer,
			[In] uint blockingMap,
			[In] MapFlags flags, [In] UIntPtr offset, [In] UIntPtr size, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event, [Out] out CLResultCode errorCode);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMapImage")]
		public static extern IntPtr EnqueueMapImage([In] CLCommandQueue commandQueue, [In] CLImage image,
			[In] uint blockingMap, [In] MapFlags flags,
			[In] UIntPtr[] origin, [In] UIntPtr[] region, [In] UIntPtr rowPitch, [In] UIntPtr slicePitch,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event, [Out] out CLResultCode errorCode);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
		public static extern CLResultCode EnqueueUnmapMemoryObject([In] CLCommandQueue commandQueue,
			[In] IntPtr memoryObject,
			[In] IntPtr mapperPtr, [In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
		public static extern CLResultCode EnqueueUnmapMemoryObject([In] CLCommandQueue commandQueue,
			[In] CLBuffer memoryObject,
			[In] IntPtr mapperPtr, [In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
		public static extern CLResultCode EnqueueUnmapMemoryObject([In] CLCommandQueue commandQueue,
			[In] CLImage memoryObject,
			[In] IntPtr mapperPtr, [In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMigrateMemObjects")]
		public static extern CLResultCode EnqueueMigrateMemoryObjects([In] CLCommandQueue commandQueue,
			[In] uint numberOfMemoryObjects,
			[In] IntPtr[] memoryObjects, [In] MemoryMigrationFlags flags, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueNDRangeKernel")]
		public static extern CLResultCode EnqueueNDRangeKernel([In] CLCommandQueue commandQueue, [In] CLKernel kernel,
			[In] uint workDimension,
			[In] UIntPtr[] globalWorkOffset, [In] UIntPtr[] globalWorkSize, [In] UIntPtr[] localWorkSize,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueNativeKernel")]
		public static extern CLResultCode EnqueueNativeKernel([In] CLCommandQueue commandQueue,
			[In] IntPtr userFunction,
			[In] IntPtr[] arguments, [In] UIntPtr argumentSize, [In] uint numberOfMemoryObjects,
			[In] IntPtr[] memoryObjects,
			[In] IntPtr argumentsMemoryLocation, [In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMarkerWithWaitList")]
		public static extern CLResultCode EnqueueMarkerWithWaitList([In] CLCommandQueue commandQueue,
			[In] uint numberOfMemoryObjects,
			[In] IntPtr[] memoryObjects, [In] IntPtr argumentsMemoryLocation, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueBarrierWithWaitList")]
		public static extern CLResultCode EnqueueBarrierWithWaitList([In] CLCommandQueue commandQueue,
			[In] uint numberOfMemoryObjects,
			[In] IntPtr[] memoryObjects, [In] IntPtr argumentsMemoryLocation, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMFree")]
		public static extern CLResultCode EnqueueSVMFree([In] CLCommandQueue commandQueue,
			[In] uint numberOfSvmPointers,
			[In] IntPtr[] svmPointers, [In] IntPtr svmFreePointersCallback, [In] IntPtr userData,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMemcpy")]
		public static extern CLResultCode EnqueueSvmMemoryCopy([In] CLCommandQueue commandQueue, [In] uint blockingCopy,
			[In] IntPtr dstPointer, [In] IntPtr srcPointer, [In] UIntPtr size, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMemFill")]
		public static extern CLResultCode EnqueueSvmMemoryFill([In] CLCommandQueue commandQueue, [In] IntPtr svmPointer,
			[In] IntPtr pattern,
			[In] UIntPtr patternSize, [In] UIntPtr size, [In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMap")]
		public static extern CLResultCode EnqueueSvmMap([In] CLCommandQueue commandQueue, [In] uint blockingMap,
			[In] MapFlags mapFlag,
			[In] IntPtr svmPointer, [In] UIntPtr size, [In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList,
			[Out] out CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 2.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="svmPointer"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventWaitList"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMUnmap")]
		public static extern CLResultCode EnqueueSVMUnmap([In] CLCommandQueue commandQueue, [In] IntPtr svmPointer,
			[In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMigrateMem")]
		public static extern CLResultCode EnqueueSvmMigrateMemory([In] CLCommandQueue commandQueue,
			[In] uint numberOfSvmPointers,
			[In] IntPtr[] svmPointers, [In] UIntPtr[] sizes, [In] MemoryMigrationFlags memoryMigrationFlags,
			[In] uint numberOfEventsInWaitList, [In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

		#endregion

		#region Extension function access

		/// <summary>
		/// Introduced in OpenCL 1.2
		/// </summary>
		/// <param name="platform"></param>
		/// <param name="functionName"></param>
		/// <returns></returns>
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
		public static extern IntPtr GetExtensionFunctionAddressForPlatform([In] CLPlatform platform,
			[In] string functionName);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage2D")]
		public static extern IntPtr CreateImage2D([In] CLContext context, [In] MemoryFlags flags,
			[In] ImageFormat imageFormat,
			[In] UIntPtr imageWidth, [In] UIntPtr imageHeight, [In] UIntPtr imageRowPitch, [In] IntPtr hostPointer,
			[Out] out CLResultCode errorCode);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage3D")]
		public static extern IntPtr CreateImage3D([In] CLContext context, [In] MemoryFlags flags,
			[In] ImageFormat imageFormat,
			[In] UIntPtr imageWidth, [In] UIntPtr imageHeight, [In] UIntPtr imageDepth, [In] UIntPtr imageRowPitch,
			[In] UIntPtr imageSlicePitch,
			[In] IntPtr hostPointer, [Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="event"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use EnqueueMarkerWithWaitList.")]
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMarker")]
		public static extern CLResultCode EnqueueMarker([In] CLCommandQueue commandQueue, [In] CLEvent @event);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <param name="numberOfEventsInWaitList"></param>
		/// <param name="eventList"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use EnqueueMarkerWithWaitList.")]
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWaitForEvents")]
		public static extern CLResultCode EnqueueWaitForEvents([In] CLCommandQueue commandQueue,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventList);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="commandQueue"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use EnqueueBarrierWithWaitList.")]
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueBarrier")]
		public static extern CLResultCode EnqueueBarrier([In] CLCommandQueue commandQueue);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.1, use UnloadPlatformCompiler.")]
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clUnloadCompiler")]
		public static extern CLResultCode UnloadCompiler();

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="funcName"></param>
		/// <returns></returns>
		[Obsolete("Deprecated method")]
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetExtensionFunctionAddress")]
		public static extern CLResultCode GetExtensionFunctionAddress([In] string funcName);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="device"></param>
		/// <param name="properties"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.2, use CreateCommandQueueWithProperties.")]
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateCommandQueue")]
		public static extern IntPtr CreateCommandQueue([In] CLContext context, [In] CLDevice device,
			[In] CommandQueueProperty properties,
			[Out] out CLResultCode errorCode);

		/// <summary>
		/// Introduced in OpenCL 1.0
		/// </summary>
		/// <param name="context"></param>
		/// <param name="normalizedCoordinates"></param>
		/// <param name="addressingMode"></param>
		/// <param name="filterMode"></param>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		[Obsolete("Deprecated in OpenCL 1.2")]
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSampler")]
		public static extern CLSampler CreateSampler([In] CLContext context, [In] uint normalizedCoordinates,
			[In] AddressingMode addressingMode, [In] FilterMode filterMode, [Out] out CLResultCode errorCode);

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
		[DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueTask")]
		public static extern CLResultCode EnqueueTask([In] CLCommandQueue commandQueue, [In] CLKernel kernel,
			[In] uint numberOfEventsInWaitList,
			[In] CLEvent[] eventWaitList, [Out] out CLEvent @event);

		#endregion
	}
}
