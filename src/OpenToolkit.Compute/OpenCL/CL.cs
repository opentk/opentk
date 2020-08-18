using System;
using System.Runtime.InteropServices;
using OpenToolkit.Compute.Native;

namespace OpenToolkit.Compute.OpenCL
{
	[Api(LibName, typeof(OpenClLibraryNameContainer))]
	public class CL : ApiContainer<CL>
	{
		static CL()
		{
			// We need to trigger the static constructor of ApiContainer<CL>.
			_ = ApiContainer<CL>.StaticConstructorTrigger;
		}

		private const string LibName = "libOpenCL";

		#region Platform API

		[ClVersion(1, 0)]
        [DllImport(LibName, EntryPoint = "clGetPlatformIDs")]
		public static extern CLResultCode GetPlatformIds(uint numberOfEntries, IntPtr[] platforms, out uint numberOfPlatforms);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetPlatformInfo")]
		public static extern CLResultCode GetPlatformInfo(IntPtr platform, PlatformInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		#endregion

		#region Device API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetDeviceIDs")]
		public static extern CLResultCode GetDeviceIds(IntPtr platform, DeviceType deviceType, uint numberOfEntries, IntPtr[] devices, out uint numberOfDevicesReturned);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetDeviceInfo")]
		public static extern CLResultCode GetDeviceInfo(IntPtr device, DeviceInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clCreateSubDevices")]
		public static extern CLResultCode CreateSubDevices(IntPtr inDevice, IntPtr[] properties, uint numberOfDevices, IntPtr[] outDevices, out uint devicesReturned);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clRetainDevice")]
		public static extern CLResultCode RetainDevice(IntPtr device);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clReleaseDevice")]
		public static extern CLResultCode ReleaseDevice(IntPtr device);

		[ClVersion(2, 1)]
		[DllImport(LibName, EntryPoint = "clSetDefaultDeviceCommandQueue")]
		public static extern CLResultCode SetDefaultDeviceCommandQueue(IntPtr context, IntPtr device, IntPtr commandQueue);

		[ClVersion(2, 1)]
		[DllImport(LibName, EntryPoint = "clGetDeviceAndHostTimer")]
		public static extern CLResultCode GetDeviceAndHostTimer(IntPtr device, IntPtr deviceTimestamp, IntPtr hostTimestamp);

		[ClVersion(2, 1)]
		[DllImport("OpenCL", EntryPoint = "clGetHostTimer")]
		public static extern CLResultCode GetHostTimer(IntPtr device, IntPtr hostTimestamp);

		#endregion

		#region Context API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clCreateContext")]
		public static extern IntPtr CreateContext(IntPtr properties, uint numberOfDevices, IntPtr[] devices, IntPtr notificationCallback, IntPtr userData, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clCreateContextFromType")]
		public static extern IntPtr CreateContextFromType(IntPtr properties, DeviceType deviceType, IntPtr notificationCallback, IntPtr userData, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clRetainContext")]
		public static extern CLResultCode RetainContext(IntPtr context);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clReleseContext")]
		public static extern CLResultCode ReleaseContext(IntPtr context);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetContextInfo")]
		public static extern CLResultCode GetContextInfo(IntPtr context, ContextInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		#endregion

		#region CommandQueue API

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clCreateCommandQueueWithProperties")]
		public static extern IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, IntPtr properties, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clRetainCommandQueue")]
		public static extern CLResultCode RetainCommandQueue(IntPtr commandQueue);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clReleaseCommandQueue")]
		public static extern CLResultCode ReleaseCommandQueue(IntPtr commandQueue);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetCommandQueueInfo")]
		public static extern CLResultCode GetCommandQueueInfo(IntPtr commandQueue, CommandQueueInfo paramName, UIntPtr paramSize, byte[] paramValue, UIntPtr paramValueSizeReturned);

		#endregion

		#region Memory Objects APIs

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clCreateBuffer")]
		public static extern IntPtr CreateBuffer(IntPtr context, MemoryFlags flags, UIntPtr size, IntPtr hostPtr, out CLResultCode errorCode);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clCreateSubBuffer")]
		public static extern IntPtr CreateSubBuffer(IntPtr buffer, MemoryFlags flags, BufferCreateType bufferCreateType, IntPtr bufferCreateInfo, out CLResultCode errorCode);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clCreateImage")]
		public static extern IntPtr CreateImage(IntPtr context, MemoryFlags flags, ImageFormat imageFormat, ImageDescription imageDesc, IntPtr hostPointer, out CLResultCode errorCode);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clCreatePipe")]
		public static extern IntPtr CreatePipe(IntPtr context, MemoryFlags flags, uint pipePacketSize, uint pipeMaxPackets, IntPtr[] properties, out CLResultCode errorCode);


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

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clRetainMemObject")]
		public static extern CLResultCode RetainMemObject(IntPtr memoryObject);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clReleaseMemObject")]
		public static extern CLResultCode ReleaseMemObject(IntPtr memoryObject);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetSupportedImageFormats")]
		public static extern CLResultCode GetSupportedImageFormats(IntPtr context, MemoryFlags flags, MemoryObjectType imageType, uint numberOfEntries, ImageFormat[] imageFormats, out uint numberOfImageFormats);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetMemObjectInfo")]
		public static extern CLResultCode GetMemObjectInfo(IntPtr memoryObject, MemoryObjectInfo paramName, UIntPtr paramValueSize, byte[] paramValue, ImageFormat[] imageFormats, out UIntPtr paramValueSizeReturned);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetImageInfo")]
		public static extern CLResultCode GetImageInfo(IntPtr image, ImageInfo paramName, UIntPtr paramValueSize, byte[] paramValue, ImageFormat[] imageFormats, out UIntPtr paramValueSizeReturned);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clGetPipeInfo")]
		public static extern CLResultCode GetPipeInfo(IntPtr pipe, PipeInfo paramName, UIntPtr paramValueSize, byte[] paramValue, ImageFormat[] imageFormats, out UIntPtr paramValueSizeReturned);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clSetMemObjectDestructorCallback")]
		public static extern CLResultCode SetMemObjectDestructorCallback(IntPtr memoryObject, IntPtr notificationCallback, IntPtr userData);

		#endregion

		#region SVM Allocation API

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clSVMAlloc")]
		public static extern IntPtr SVMAlloc(IntPtr context, SvmMemoryFlags flags, UIntPtr size, uint alignment);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clSVMFree")]
		public static extern IntPtr SVMFree(IntPtr context, IntPtr svmPointer);

		#endregion

		#region Sampler API

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clCreateSamplerWithProperties")]
		public static extern IntPtr CreateSamplerWithProperties(IntPtr context, IntPtr samplerProperties, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clRetainSampler")]
		public static extern CLResultCode RetainSampler(IntPtr sampler);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clReleaseSampler")]
		public static extern CLResultCode ReleaseSampler(IntPtr sampler);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetSamplerInfo")]
		public static extern CLResultCode GetSamplerInfo(IntPtr sampler, SamplerInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		#endregion

		#region Program Object API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clCreateProgramWithSource")]
		public static extern IntPtr CreateProgramWithSource(IntPtr context, uint count, IntPtr[] strings, uint[] lengths, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clCreateProgramWithBinary")]
		public static extern IntPtr CreateProgramWithBinary(IntPtr context, uint numberOfDevices, IntPtr[] deviceList, UIntPtr[] lengths, IntPtr[] binaries, out CLResultCode binaryStatus, out CLResultCode errorCode);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clCreateProgramWithBuiltInKernels")]
		public static extern IntPtr CreateProgramWithBuiltInKernels(IntPtr context, uint numberOfDevices, IntPtr[] deviceList, string kernelNames, out CLResultCode errorCode);

		[ClVersion(2, 1)]
		[DllImport(LibName, EntryPoint = "clCreateProgramWithIL")]
		public static extern IntPtr CreateProgramWithIL(IntPtr context, IntPtr il, UIntPtr length, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clRetainProgram")]
		public static extern CLResultCode RetainProgram(IntPtr program);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clReleaseProgram")]
		public static extern CLResultCode ReleaseProgram(IntPtr program);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clBuildProgram")]
		public static extern CLResultCode BuildProgram(IntPtr program, uint numberOfDevices, IntPtr[] deviceList, string options, IntPtr notificationCallback, IntPtr userData);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clCompileProgram")]
		public static extern CLResultCode CompileProgram(IntPtr program, uint numberOfDevices, IntPtr[] deviceList, string options, uint numberOfInputDevices, IntPtr[] inputHeaders, out IntPtr headerIncludeNames, IntPtr notificationCallback, IntPtr userData);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clLinkProgram")]
		public static extern IntPtr LinkProgram(IntPtr context, uint numberOfDevices, IntPtr[] deviceList, string options, uint numberOfPrograms, IntPtr[] inputPrograms, IntPtr notificationCallback, IntPtr userData, out CLResultCode errorCode);

		[ClVersion(2, 2)]
		[DllImport(LibName, EntryPoint = "clSetProgramReleaseCallback")]
		public static extern CLResultCode SetProgramReleaseCallback(IntPtr program, IntPtr notificationCallback, IntPtr userData);

		[ClVersion(2, 2)]
		[DllImport(LibName, EntryPoint = "clSetProgramSpecializationConstant")]
		public static extern CLResultCode SetProgramSpecializationConstant(IntPtr program, uint specId, UIntPtr specSize, IntPtr specValue);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clUnloadPlatformCompiler")]
		public static extern CLResultCode UnloadPlatformCompiler(IntPtr platform);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetProgramInfo")]
		public static extern CLResultCode GetProgramInfo(IntPtr program, ProgramInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetProgramBuildInfo")]
		public static extern CLResultCode GetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		#endregion

		#region Kernel Object API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clCreateKernel")]
		public static extern IntPtr CreateKernel(IntPtr program, string name, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clCreateKernelsInProgram")]
		public static extern CLResultCode CreateKernelsInProgram(IntPtr program, uint numberOfKernels, IntPtr[] kernels, out uint numberOfKernelsReturned);

		[ClVersion(2, 1)]
		[DllImport(LibName, EntryPoint = "clCloneKernel")]
		public static extern IntPtr CloneKernel(IntPtr sourceKernel, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clRetainKernel")]
		public static extern CLResultCode RetainKernel(IntPtr kernel);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clReleaseKernel")]
		public static extern CLResultCode ReleaseKernel(IntPtr kernel);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clSetKernelArg")]
		public static extern CLResultCode SetKernelArg(IntPtr kernel, uint argumentIndex, UIntPtr argumentSize, IntPtr argumentValuePointer);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clSetKernelArgSVMPointer")]
		public static extern CLResultCode SetKernelArgSVMPointer(IntPtr kernel, uint argumentIndex, IntPtr argumentValuePointer);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clSetKernelExecInfo")]
		public static extern CLResultCode SetKernelExecInfo(IntPtr kernel, KernelExecInfo paramName, UIntPtr paramValueSize, IntPtr paramValue);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetKernelInfo")]
		public static extern CLResultCode GetKernelInfo(IntPtr kernel, KernelInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramSizeReturned);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clGetKernelArgInfo")]
		public static extern CLResultCode GetKernelArgInfo(IntPtr kernel, uint argumentIndex, KernelArgInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramSizeReturned);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetKernelWorkGroupInfo")]
		public static extern CLResultCode GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramSizeReturned);

		[ClVersion(2, 1)]
		[DllImport(LibName, EntryPoint = "clGetKernelSubGroupInfo")]
		public static extern CLResultCode GetKernelSubGroupInfo(IntPtr kernel, IntPtr device, KernelSubGroupInfo paramName, UIntPtr inputValueSize, IntPtr inputValue, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramSizeReturned);

		#endregion

		#region Event Object API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clWaitForEvents")]
		public static extern CLResultCode WaitForEvents(uint numberOfEvents, IntPtr[] eventList);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetEventInfo")]
		public static extern CLResultCode GetEventInfo(IntPtr @event, EventInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramSizeReturned);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clCreateUserEvent")]
		public static extern IntPtr CreateUserEvent(IntPtr context, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clRetainEvent")]
		public static extern CLResultCode RetainEvent(IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clReleaseEvent")]
		public static extern CLResultCode ReleaseEvent(IntPtr @event);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clSetUserEventStatus")]
		public static extern CLResultCode SetUserEventStatus(IntPtr @event, int executionStatus);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clSetEventCallback")]
		public static extern CLResultCode SetEventCallback(IntPtr @event, int commandExecCallbackType, IntPtr notifyCallback, IntPtr userData);

		#endregion

		#region Profiling API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clGetEventProfilingInfo")]
		public static extern CLResultCode GetEventProfilingInfo(IntPtr @event, ProfilingInfo paramName, UIntPtr paramValueSize, byte[] paramValue, out UIntPtr paramValueSizeReturned);

		#endregion

		#region Flush and Finish API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clFlush")]
		public static extern CLResultCode Flush(IntPtr commandQueue);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clFinish")]
		public static extern CLResultCode Finish(IntPtr commandQueue);

		#endregion

		#region Enqueued Commands API

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueReadBuffer")]
		public static extern CLResultCode EnqueueReadBuffer(IntPtr commandQueue, IntPtr buffer, uint blockingRead, UIntPtr offset, UIntPtr size, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clEnqueueReadBufferRect")]
		public static extern CLResultCode EnqueueReadBufferRect(IntPtr commandQueue, IntPtr buffer, uint blockingRead, UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch, UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueWriteBuffer")]
		public static extern CLResultCode EnqueueWriteBuffer(IntPtr commandQueue, IntPtr buffer, uint blockingWrite, UIntPtr offset, UIntPtr size, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clEnqueueWriteBufferRect")]
		public static extern CLResultCode EnqueueWriteBufferRect(IntPtr commandQueue, IntPtr buffer, uint blockingWrite, UIntPtr[] bufferOffset, UIntPtr[] hostOffset, UIntPtr[] region, UIntPtr bufferRowPitch, UIntPtr bufferSlicePitch, UIntPtr hostRowPitch, UIntPtr hostSlicePitch, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clEnqueueFillBuffer")]
		public static extern CLResultCode EnqueueFillBuffer(IntPtr commandQueue, IntPtr buffer, IntPtr pattern, UIntPtr patternSize, UIntPtr offset, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueCopyBuffer")]
		public static extern CLResultCode EnqueueCopyBuffer(IntPtr commandQueue, IntPtr srcBuffer, IntPtr dstBuffer, UIntPtr srcOffset, UIntPtr dstOffset, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 1)]
		[DllImport(LibName, EntryPoint = "clEnqueueCopyBufferRect")]
		public static extern CLResultCode EnqueueCopyBufferRect(IntPtr commandQueue, IntPtr srcBuffer, IntPtr dstBuffer, UIntPtr[] srcOrigin, UIntPtr[] dstOrigin, UIntPtr[] region, UIntPtr srcRowPitch, UIntPtr srcSlicePitch, UIntPtr dstRowPitch, UIntPtr dstSlicePitch, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueReadImage")]
		public static extern CLResultCode EnqueueReadImage(IntPtr commandQueue, IntPtr image, uint blockingRead, UIntPtr[] origin, UIntPtr[] region, UIntPtr rowPitch, UIntPtr slicePitch, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueWriteImage")]
		public static extern CLResultCode EnqueueWriteImage(IntPtr commandQueue, IntPtr image, uint blockingWrite, UIntPtr[] origin, UIntPtr[] region, UIntPtr inputRowPitch, UIntPtr inputSlicePitch, IntPtr pointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clEnqueueFillImage")]
		public static extern CLResultCode EnqueueFillImage(IntPtr commandQueue, IntPtr image, IntPtr fillColor, UIntPtr[] origin, UIntPtr[] region, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueCopyImage")]
		public static extern CLResultCode EnqueueCopyImage(IntPtr commandQueue, IntPtr srcImage, IntPtr dstImage, UIntPtr[] srcOrigin, UIntPtr[] dstOrigin, UIntPtr[] region, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueCopyImageToBuffer")]
		public static extern CLResultCode EnqueueCopyImageToBuffer(IntPtr commandQueue, IntPtr srcImage, IntPtr dstBuffer, UIntPtr[] srcOrigin, UIntPtr[] region, UIntPtr dstOffset, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueCopyBufferToImage")]
		public static extern CLResultCode EnqueueCopyBufferToImage(IntPtr commandQueue, IntPtr srcBuffer, IntPtr dstImage, UIntPtr srcOffset, UIntPtr[] dstOrigin, UIntPtr[] region, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueMapBuffer")]
		public static extern IntPtr EnqueueMapBuffer(IntPtr commandQueue, IntPtr buffer, uint blockingMap, MapFlags flags, UIntPtr offset, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueMapImage")]
		public static extern IntPtr EnqueueMapImage(IntPtr commandQueue, IntPtr image, uint blockingMap, MapFlags flags, UIntPtr[] origin, UIntPtr[] region, UIntPtr rowPitch, UIntPtr slicePitch, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueUnmapMemObject")]
		public static extern CLResultCode EnqueueUnmapMemObject(IntPtr commandQueue, IntPtr memoryObject, IntPtr mapperPtr, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clEnqueueMigrateMemObjects")]
		public static extern CLResultCode EnqueueMigrateMemObjects(IntPtr commandQueue, uint numberOfMemoryObjects, IntPtr[] memoryObjects, MemoryMigrationFlags flags, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueNDRangeKernel")]
		public static extern CLResultCode EnqueueNDRangeKernel(IntPtr commandQueue, IntPtr kernel, uint workDimension, IntPtr[] globalWorkOffset, IntPtr[] globalWorkSize, IntPtr[] localWorkSize, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueNativeKernel")]
		public static extern CLResultCode EnqueueNativeKernel(IntPtr commandQueue, IntPtr userFunction, IntPtr[] arguments, UIntPtr argumentSize, uint numberOfMemoryObjects, IntPtr[] memoryObjects, IntPtr argumentsMemoryLocation, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clEnqueueMarkerWithWaitList")]
		public static extern CLResultCode EnqueueMarkerWithWaitList(IntPtr commandQueue, uint numberOfMemoryObjects, IntPtr[] memoryObjects, IntPtr argumentsMemoryLocation, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clEnqueueBarrierWithWaitList")]
		public static extern CLResultCode EnqueueBarrierWithWaitList(IntPtr commandQueue, uint numberOfMemoryObjects, IntPtr[] memoryObjects, IntPtr argumentsMemoryLocation, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueSVMFree")]
		public static extern CLResultCode EnqueueSVMFree(IntPtr commandQueue, uint numberOfSvmPointers, IntPtr[] svmPointers, IntPtr svmFreePointersCallback, IntPtr userData, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMemcpy")]
		public static extern CLResultCode EnqueueSvmMemoryCopy(IntPtr commandQueue, uint blockingCopy, IntPtr dstPointer, IntPtr srcPointer, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMemFill")]
		public static extern CLResultCode EnqueueSvmMemoryFill(IntPtr commandQueue, IntPtr svmPointer, IntPtr pattern, UIntPtr patternSize, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMap")]
		public static extern CLResultCode EnqueueSvmMap(IntPtr commandQueue, uint blockingMap, MapFlags mapFlag, IntPtr svmPointer, UIntPtr size, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(2, 0)]
		[DllImport(LibName, EntryPoint = "clEnqueueSVMUnmap")]
		public static extern CLResultCode EnqueueSVMUnmap(IntPtr commandQueue, IntPtr svmPointer, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		[ClVersion(2, 1)]
		[DllImport(LibName, EntryPoint = "clEnqueueSVMMigrateMem")]
		public static extern CLResultCode EnqueueSvmMigrateMemory(IntPtr commandQueue, uint numberOfSvmPointers, IntPtr[] svmPointers, UIntPtr[] sizes, MemoryMigrationFlags memoryMigrationFlags, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		#endregion

		#region Extension function access

		[ClVersion(1, 2)]
		[DllImport(LibName, EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
		public static extern IntPtr GetExtensionFunctionAddressForPlatform(IntPtr platform, string functionName);

		#endregion

		#region Deprecated OpenCL API

		[ClVersion(1, 0)]
		[Obsolete("Deprecated method")]
		[DllImport(LibName, EntryPoint = "clCreateImage2D")]
		public static extern IntPtr CreateImage2D(IntPtr context, MemoryFlags flags, ImageFormat imageFormat, UIntPtr imageWidth, UIntPtr imageHeight, UIntPtr imageRowPitch, IntPtr hostPointer, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated method")]
		[DllImport(LibName, EntryPoint = "clCreateImage3D")]
		public static extern IntPtr CreateImage3D(IntPtr context, MemoryFlags flags, ImageFormat imageFormat, UIntPtr imageWidth, UIntPtr imageHeight, UIntPtr imageDepth, UIntPtr imageRowPitch, UIntPtr imageSlicePitch, IntPtr hostPointer, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated OpenCL 1.1 method, use EnqueueMarkerWithWaitList.")]
		[DllImport(LibName, EntryPoint = "clEnqueueMarker")]

		public static extern CLResultCode EnqueueMarker(IntPtr commandQueue, IntPtr @event);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated OpenCL 1.1 method, use EnqueueMarkerWithWaitList.")]
		[DllImport(LibName, EntryPoint = "clEnqueueWaitForEvents")]
		public static extern CLResultCode EnqueueWaitForEvents(IntPtr commandQueue, uint numberOfEventsInWaitList, IntPtr[] eventList);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated OpenCL 1.1 method, use EnqueueBarrierWithWaitList.")]
		[DllImport(LibName, EntryPoint = "clEnqueueBarrier")]
		public static extern CLResultCode EnqueueBarrier(IntPtr commandQueue);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated OpenCL 1.1 method, use UnloadPlatformCompiler.")]
		[DllImport(LibName, EntryPoint = "clUnloadCompiler")]
		public static extern CLResultCode UnloadCompiler();

		[ClVersion(1, 0)]
		[Obsolete("Deprecated method")]
		[DllImport(LibName, EntryPoint = "clGetExtensionFunctionAddress")]
		public static extern CLResultCode GetExtensionFunctionAddress(string funcName);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated OpenCL 1.2 method, use CreateCommandQueueWithProperties.")]
		[DllImport(LibName, EntryPoint = "clCreateCommandQueue")]
		public static extern IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperty properties, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated OpenCL 1.2 method, use CreateImage.")]
		[DllImport(LibName, EntryPoint = "clCreateSampler")]
		public static extern IntPtr CreateSampler(IntPtr context, uint normalizedCoordinates, AddressingMode addressingMode, FilterMode filterMode, out CLResultCode errorCode);

		[ClVersion(1, 0)]
		[Obsolete("Deprecated OpenCL 1.2 method.")]
		[DllImport(LibName, EntryPoint = "clEnqueueBarrier")]
		public static extern CLResultCode EnqueueTask(IntPtr commandQueue, IntPtr kernel, uint numberOfEventsInWaitList, IntPtr[] eventWaitList, out IntPtr @event);

		#endregion
	}
}
