using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Compute.Native;

namespace OpenTK.Compute.OpenCL
{
    public static class CL
    {
        static CL()
        {
            CLBase.RegisterOpenCLResolver();
        }

        private const string LibName = "opencl";
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
        public static extern CLResultCode GetPlatformIds(
            [In] uint numberOfEntries,
            [Out] CLPlatform[] platforms,
            [Out] out UIntPtr numberOfPlatforms);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        /// <param name="platformIds">returns a list of OpenCL platforms found. The CLPlatform values returned in platforms can be used to identify a specific OpenCL platform.</param>
        /// <returns>returns Success if the function is executed successfully. Otherwise, it returns one of the following errors:
        /// -InvalidValue if numberOfEntries is equal to zero and platforms is not NULL or if both numberOfPlatforms and platforms are NULL.
        /// -OutOfHostMemory if there is a failure to allocate resources required by the OpenCL implementation on the host.</returns>
        public static CLResultCode GetPlatformIds(out CLPlatform[] platformIds)
        {
            var resultCode = GetPlatformIds(0, null, out UIntPtr sizeReturned);
            platformIds = new CLPlatform[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetPlatformIds(sizeReturned.ToUInt32(), platformIds, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetPlatformInfo")]
        public static extern CLResultCode GetPlatformInfo(
            [In] this CLPlatform platform,
            [In] CLPlatform.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetPlatformInfo(
            this CLPlatform platform,
            CLPlatform.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetPlatformInfo(platform, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt64()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;            
            return GetPlatformInfo(platform, paramName, sizeReturned, paramValue, out _);
        }

        public static CLResultCode SupportsPlatformExtension(
            this CLPlatform platform,
            string extension,
            out bool extensionSupported)
        {
            extensionSupported = false;
            var resultCode = GetPlatformInfo(platform, CLPlatform.Info.Extensions, out byte[] bytes);
            var extensions = Encoding.ASCII.GetString(bytes).Split(" ");
            foreach (var supportedExtension in extensions)
            {
                if (supportedExtension == extension)
                    extensionSupported = true;
            }

            return resultCode;
        }

        #endregion

        #region Device API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceIDs")]
        public static extern CLResultCode GetDeviceIds(
            [In] this CLPlatform platform,
            [In] CLDevice.Type deviceType,
            [In] uint numberOfEntries,
            [Out] CLDevice[] devices,
            [Out] out uint numberOfsizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetDeviceIds(
            this CLPlatform platform,
            CLDevice.Type deviceType,
            out CLDevice[] deviceIds)
        {
            var resultCode = GetDeviceIds(platform, deviceType, 0, null, out uint sizeReturned);
            deviceIds = new CLDevice[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetDeviceIds(platform, deviceType, sizeReturned, deviceIds, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceInfo")]
        public static extern CLResultCode GetDeviceInfo(
            [In] this CLDevice device,
            [In] CLDevice.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetDeviceInfo(
            this CLDevice device,
            CLDevice.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetDeviceInfo(device, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;      
            return GetDeviceInfo(device, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSubDevices")]
        public static extern CLResultCode CreateSubDevices(
            [In] this CLDevice inDevice,
            [In] IntPtr[] properties,
            [In] uint numberOfDevices,
            [Out] CLDevice[] outDevices,
            [Out] out uint sizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode CreateSubDevices(
            this CLDevice inDevice,
            CLDevicePartitionProperties properties,
            out CLDevice[] outDevices)
        {
            var resultCode = CreateSubDevices(inDevice, properties.CreatePropertyArray(), 0, null, out uint sizeReturned);
            outDevices = new CLDevice[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return CreateSubDevices(inDevice, properties.CreatePropertyArray(), sizeReturned, outDevices, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainDevice")]
        public static extern CLResultCode RetainDevice([In] this CLDevice device);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseDevice")]
        public static extern CLResultCode ReleaseDevice([In] this CLDevice device);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetDefaultDeviceCommandQueue")]
        public static extern CLResultCode SetDefaultDeviceCommandQueue(
            [In] this CLContext context,
            [In] CLDevice device,
            [In] CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceAndHostTimer")]
        public static extern CLResultCode GetDeviceAndHostTimer(
            [In] this CLDevice device,
            [In] IntPtr deviceTimestamp,
            [In] IntPtr hostTimestamp);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetHostTimer")]
        public static extern CLResultCode GetHostTimer(
            [In] this CLDevice device,
            [In] IntPtr hostTimestamp);

        #endregion

        #region Context API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateContext")]
        public static extern CLContext CreateContext(
            [In] IntPtr[] properties,
            [In] uint numberOfDevices,
            [In] CLDevice[] devices,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLContext CreateContext(
            this CLContextProperties properties,
            CLDevice[] devices,
            ClEventCallback callback,
            IntPtr userData,
            out CLResultCode resultCode)
        {
            return CreateContext(properties.CreatePropertyArray(), (uint)devices.Length, devices, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData,
                out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateContextFromType")]
        public static extern CLContext CreateContextFromType(
            [In] IntPtr[] properties,
            [In] CLDevice.Type deviceType,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLContext CreateContextFromType(
            this CLContextProperties properties,
            CLDevice.Type deviceType,
            ClEventCallback callback,
            IntPtr userData,
            out CLResultCode resultCode)
        {
            return CreateContextFromType(properties.CreatePropertyArray(), deviceType, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData,
                out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainContext")]
        public static extern CLResultCode RetainContext([In] this CLContext context);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseContext")]
        public static extern CLResultCode ReleaseContext([In] this CLContext context);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetContextInfo")]
        public static extern CLResultCode GetContextInfo(
            [In] this CLContext context,
            [In] CLContext.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);


        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetContextInfo(
            this CLContext context,
            CLContext.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetContextInfo(context, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetContextInfo(context, paramName, sizeReturned, paramValue, out _);
        }


        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetContextDestructorCallback")]
        public static extern CLResultCode SetContextDestructorCallback(
            [In] this CLContext context,
            [In] IntPtr callback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static CLResultCode SetContextDestructorCallback(
            this CLContext context,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetContextDestructorCallback(context, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        #endregion

        #region CommandQueue API

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateCommandQueueWithProperties")]
        public static extern CLCommandQueue CreateCommandQueueWithProperties(
            [In] this CLContext context,
            [In] CLDevice device,
            [In] IntPtr[] properties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLCommandQueue CreateCommandQueueWithProperties(
            this CLContext context,
            CLDevice device,
            CLCommandQueueProperties properties,
            out CLResultCode resultCode)
        {
            return CreateCommandQueueWithProperties(context, device, properties.CreatePropertyArray(), out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainCommandQueue")]
        public static extern CLResultCode RetainCommandQueue([In] this CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseCommandQueue")]
        public static extern CLResultCode ReleaseCommandQueue([In] this CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetCommandQueueInfo")]
        public static extern CLResultCode GetCommandQueueInfo(
            [In] this CLCommandQueue commandQueue,
            [In] CLCommandQueue.Info paramName,
            [In] UIntPtr paramSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetCommandQueueInfo(
           this CLCommandQueue queue,
            CLCommandQueue.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetCommandQueueInfo(queue, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetCommandQueueInfo(queue, paramName, sizeReturned, paramValue, out _);
        }

        #endregion

        #region Memory Objects APIs

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateBuffer")]
        public static extern CLBuffer CreateBuffer(
            [In] this CLContext context,
            [In] MemoryFlags flags,
            [In] UIntPtr sizeReturned,
            [In] IntPtr hostPtr,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLBuffer CreateBuffer<T>(
           this CLContext context,
            MemoryFlags flags,
            T[] array,
            out CLResultCode resultCode) where T : unmanaged
        {
            fixed (T* b = array)
            {
                IntPtr buffer = CreateBuffer(context, flags, (UIntPtr)(sizeof(T) * array.Length), (IntPtr)b,
                    out resultCode);
                return new CLBuffer(buffer);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLBuffer CreateBuffer<T>(
            this CLContext context,
            MemoryFlags flags,
            Span<T> span,
            out CLResultCode resultCode) where T : unmanaged
        {
            fixed (T* b = span)
            {
                IntPtr buffer = CreateBuffer(context, flags, (UIntPtr)(sizeof(T) * span.Length), (IntPtr)b,
                    out resultCode);
                return new CLBuffer(buffer);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSubBuffer")]
        public static extern CLBuffer CreateSubBuffer(
            [In] this CLBuffer buffer,
            [In] MemoryFlags flags,
            [In] CLBuffer.CreateType bufferCreateType,
            [In] IntPtr bufferCreateInfo,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage")]
        public static extern CLImage CreateImage(
            [In] this CLContext context,
            [In] MemoryFlags flags,
            [In] ref ImageFormat imageFormat,
            [In] ref ImageDescription imageDesc,
            [In] IntPtr hostPointer,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreatePipe")]
        public static extern CLPipe CreatePipe(
            [In] this CLContext context,
            [In] MemoryFlags flags,
            [In] uint pipePacketSize,
            [In] uint pipeMaxPackets,
            [In] IntPtr[] properties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLPipe CreatePipe(
            this CLContext context,
            MemoryFlags flags,
            uint pipePacketSize,
            uint pipeMaxPackets,
            CLPipeProperties properties,
            out CLResultCode resultCode)
        {
            return CreatePipe(context, flags, pipePacketSize, pipeMaxPackets, properties.CreatePropertyArray(), out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateBufferWithProperties")]
        public static extern CLBuffer CreateBufferWithProperties(
            [In] this CLContext context,
            [In] IntPtr[] properties,
            [In] MemoryFlags flags,
            [In] UIntPtr sizeReturned,
            [In] IntPtr hostPointer,
            [Out] out CLResultCode errorCode);

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static unsafe CLBuffer CreateBufferWithProperties<T>(
            this CLContext context,
            CLBufferProperties properties,
            MemoryFlags flags,
            T[] array,
            out CLResultCode errorCode)
            where T : unmanaged
        {
            fixed (T* b = array)
            {
                return CreateBufferWithProperties(context, properties.CreatePropertyArray(), flags, (UIntPtr)(sizeof(T) * array.Length), (IntPtr)b,
                    out errorCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static unsafe CLBuffer CreateBufferWithProperties<T>(
            this CLContext context,
            CLBufferProperties properties,
            MemoryFlags flags,
            Span<T> span,
            out CLResultCode errorCode)
            where T : unmanaged
        {
            fixed (T* b = span)
            {
                return CreateBufferWithProperties(context, properties.CreatePropertyArray(), flags, (UIntPtr)(sizeof(T) * span.Length), (IntPtr)b,
                    out errorCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImageWithProperties")]
        public static extern CLImage CreateImageWithProperties(
            [In] this CLContext context,
            [In] IntPtr[] properties,
            [In] MemoryFlags flags,
            [In] IntPtr imageFormat,
            [In] IntPtr imageDesc,
            [In] IntPtr hostPointer,
            [Out] out CLResultCode errorCode);

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static CLImage CreateImageWithProperties(
            this CLContext context,
            CLImageProperties properties,
            MemoryFlags flags,
            IntPtr imageFormat,
            IntPtr imageDesc,
            IntPtr hostPointer,
            out CLResultCode errorCode)
        {
            return CreateImageWithProperties(context, properties.CreatePropertyArray(), flags, imageFormat, imageDesc, hostPointer, out errorCode);
        }


        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] IntPtr memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] this CLBuffer memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] this CLImage memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] this CLPipe memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] IntPtr memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] this CLBuffer memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] this CLImage memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] this CLPipe memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetSupportedImageFormats")]
        public static extern CLResultCode GetSupportedImageFormats(
            [In] this CLContext context,
            [In] MemoryFlags flags,
            [In] MemoryObjectType imageType,
            [In] uint numberOfEntries,
            [Out] [MarshalAs(UnmanagedType.LPArray)]
            ImageFormat[] imageFormats,
            [Out] out uint numberOfImageFormats);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetSupportedImageFormats(
            this CLContext context,
            MemoryFlags flags,
            MemoryObjectType imageType,
            out ImageFormat[] imageFormats)
        {
            var resultCode = GetSupportedImageFormats(context, flags, imageType, 0, null, out uint sizeReturned);
            imageFormats = new ImageFormat[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetSupportedImageFormats(context, flags, imageType, sizeReturned, imageFormats, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] IntPtr memoryObject,
            [In] MemoryObjectInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
            IntPtr memoryObject,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(memoryObject, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetMemObjectInfo(memoryObject, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] this CLBuffer memoryObject,
            [In] MemoryObjectInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
           this CLBuffer memoryObject,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(memoryObject, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetMemObjectInfo(memoryObject, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] this CLImage memoryObject,
            [In] MemoryObjectInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
           this CLImage memoryObject,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(memoryObject, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetMemObjectInfo(memoryObject, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] this CLPipe memoryObject,
            [In] MemoryObjectInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
           this CLPipe memoryObject,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(memoryObject, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetMemObjectInfo(memoryObject, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetImageInfo")]
        public static extern CLResultCode GetImageInfo(
            [In] this CLImage image,
            [In] CLImage.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetImageInfo(
           this CLImage image,
            CLImage.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetImageInfo(image, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt64()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetImageInfo(image, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetPipeInfo")]
        public static extern CLResultCode GetPipeInfo(
            [In] this CLPipe pipe,
            [In] CLPipe.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode GetPipeInfo(
            CLPipe pipe,
            CLPipe.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetPipeInfo(pipe, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetPipeInfo(pipe, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
        public static extern CLResultCode SetMemoryObjectDestructorCallback(
            [In] IntPtr memoryObject,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static CLResultCode SetMemoryObjectDestructorCallback(
            IntPtr memoryObject,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetMemoryObjectDestructorCallback(memoryObject, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
        public static extern CLResultCode SetMemoryObjectDestructorCallback(
            [In] this CLBuffer memoryObject,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode SetMemoryObjectDestructorCallback(
            this CLBuffer memoryObject,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetMemoryObjectDestructorCallback(memoryObject, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
        public static extern CLResultCode SetMemoryObjectDestructorCallback(
            [In] this CLImage memoryObject,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode SetMemoryObjectDestructorCallback(
            this CLImage memoryObject,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetMemoryObjectDestructorCallback(memoryObject, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
        public static extern CLResultCode SetMemoryObjectDestructorCallback(
            [In] this CLPipe memoryObject,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode SetMemoryObjectDestructorCallback(
           this CLPipe memoryObject,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetMemoryObjectDestructorCallback(memoryObject, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        #endregion

        #region SVM Allocation API

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSVMAlloc")]
        public static extern IntPtr SVMAlloc(
            [In] this CLContext context,
            [In] SvmMemoryFlags flags,
            [In] UIntPtr sizeReturned,
            [In] uint alignment);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSVMFree")]
        public static extern IntPtr SVMFree(
            [In] this CLContext context,
            [In] IntPtr svmPointer);

        #endregion

        #region Sampler API

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSamplerWithProperties")]
        public static extern CLSampler CreateSamplerWithProperties(
            [In] this CLContext context,
            [In] IntPtr[] samplerProperties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLSampler CreateSamplerWithProperties(
            this CLContext context,
            CLSamplerProperties properties,
            out CLResultCode resultCode)
        {
            return CreateSamplerWithProperties(context, properties.CreatePropertyArray(), out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainSampler")]
        public static extern CLResultCode RetainSampler([In] this CLSampler sampler);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseSampler")]
        public static extern CLResultCode ReleaseSampler([In] this CLSampler sampler);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetSamplerInfo")]
        public static extern CLResultCode GetSamplerInfo(
            [In] this CLSampler sampler,
            [In] CLSampler.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetSamplerInfo(
            this CLSampler sampler,
            CLSampler.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetSamplerInfo(sampler, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetSamplerInfo(sampler, paramName, sizeReturned, paramValue, out _);
        }

        #endregion

        #region Program Object API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithSource")]
        public static extern CLProgram CreateProgramWithSource(
            [In] this CLContext context,
            [In] uint sizeReturned,
            [In] IntPtr[] strings,
            [In] uint[] lengths,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLProgram CreateProgramWithSource(
            this CLContext context,
            string source,
            out CLResultCode resultCode)
        {
            IntPtr[] sourceList = { Marshal.StringToHGlobalAnsi(source) };
            uint[] sourceLengths = { (uint)source.Length };
            return CreateProgramWithSource(context, 1, sourceList, sourceLengths, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithBinary")]
        public static extern CLProgram CreateProgramWithBinary(
            [In] this CLContext context,
            [In] uint numberOfDevices,
            [In] IntPtr[] deviceList,
            [In] UIntPtr[] lengths,
            [In] IntPtr[] binaries,
            [Out] out CLResultCode[] binaryStatus,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithBuiltInKernels")]
        public static extern CLProgram CreateProgramWithBuiltInKernels(
            [In] this CLContext context,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] string kernelNames,
            [Out] out CLResultCode resultCode);


        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLProgram CreateProgramWithBuiltInKernels(
            this CLContext context,
            CLDevice[] deviceList,
            string kernelNames,
            out CLResultCode resultCode)
        {
            return CreateProgramWithBuiltInKernels(context, (uint)deviceList.Length, deviceList, kernelNames, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithIL")]
        public static extern CLProgram CreateProgramWithIL(
            [In] this CLContext context,
            [In] IntPtr il,
            [In] UIntPtr length,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainProgram")]
        public static extern CLResultCode RetainProgram([In] this CLProgram program);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseProgram")]
        public static extern CLResultCode ReleaseProgram([In] this CLProgram program);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clBuildProgram")]
        public static extern CLResultCode BuildProgram(
            [In] this CLProgram program,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] string options,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode BuildProgram(
            this CLProgram program,
            CLDevice[] deviceList,
            string options,
            ClEventCallback callback,
            IntPtr userData)
        {
            return BuildProgram(program, (uint)deviceList.Length, deviceList, options,
                Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCompileProgram")]
        public static extern CLResultCode CompileProgram(
            [In] this CLProgram program,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] string options,
            [In] uint numberOfInputDevices,
            [In] IntPtr[] inputHeaders,
            [Out] out IntPtr headerIncludeNames,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode CompileProgram(
           this CLProgram program,
            CLDevice[] deviceList,
            string options,
            IntPtr[] inputHeaders,
            out IntPtr headerIncludeNames,
            ClEventCallback callback,
            IntPtr userData)
        {
            return CompileProgram(program, (uint)deviceList.Length, deviceList, options, (uint)inputHeaders.Length, inputHeaders,
               out headerIncludeNames, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clLinkProgram")]
        public static extern CLProgram LinkProgram(
            [In] this CLContext context,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] string options,
            [In] uint numberOfPrograms,
            [In] CLProgram[] inputPrograms,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLProgram LinkProgram(
            this CLContext context,
            CLDevice[] deviceList,
            string options,
            CLProgram[] inputPrograms,
            ClEventCallback callback,
            IntPtr userData,
            out CLResultCode resultCode)
        {
            return LinkProgram(context, (uint)deviceList.Length, deviceList, options, (uint)inputPrograms.Length, inputPrograms,
               Marshal.GetFunctionPointerForDelegate(callback), userData, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 2.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetProgramReleaseCallback")]
        public static extern CLResultCode SetProgramReleaseCallback(
            [In] this CLProgram program,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 2.2
        /// </summary>
        public static CLResultCode SetProgramReleaseCallback(
           this CLProgram program,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetProgramReleaseCallback(program, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 2.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetProgramSpecializationConstant")]
        public static extern CLResultCode SetProgramSpecializationConstant(
            [In] this CLProgram program,
            [In] uint specId,
            [In] UIntPtr specSize,
            [In] IntPtr specValue);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clUnloadPlatformCompiler")]
        public static extern CLResultCode UnloadPlatformCompiler([In] this CLPlatform platform);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetProgramInfo")]
        public static extern CLResultCode GetProgramInfo(
            [In] this CLProgram program,
            [In] CLProgram.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetProgramInfo(
           this CLProgram program,
            CLProgram.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetProgramInfo(program, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetProgramInfo(program, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetProgramBuildInfo")]
        public static extern CLResultCode GetProgramBuildInfo(
            [In] this CLProgram program,
            [In] CLDevice device,
            [In] CLProgram.BuildInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetProgramBuildInfo(
            this CLProgram program,
            CLDevice device,
            CLProgram.BuildInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetProgramBuildInfo(program, device, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetProgramBuildInfo(program, device, paramName, sizeReturned, paramValue, out _);
        }

        #endregion

        #region Kernel Object API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateKernel")]
        public static extern CLKernel CreateKernel(
            [In] this CLProgram program,
            [In] string name,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateKernelsInProgram")]
        public static extern CLResultCode CreateKernelsInProgram(
            [In] this CLProgram program,
            [In] uint numberOfKernels,
            [In] CLKernel[] kernels,
            [Out] out uint numberOfKernelsReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode CreateKernelsInProgram(
            this CLProgram program,
            out CLKernel[] kernels)
        {
            var resultCode = CreateKernelsInProgram(program, 0, null, out uint sizeReturned);
            kernels = new CLKernel[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return CreateKernelsInProgram(program, sizeReturned, kernels, out _);
        }


        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCloneKernel")]
        public static extern CLKernel CloneKernel(
            [In] this CLKernel sourceKernel,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainKernel")]
        public static extern CLResultCode RetainKernel([In] this CLKernel kernel);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseKernel")]
        public static extern CLResultCode ReleaseKernel([In] this CLKernel kernel);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelArg")]
        public static extern CLResultCode SetKernelArg(
            [In] this CLKernel kernel,
            [In] uint argumentIndex,
            [In] UIntPtr argumentSize,
            [In] IntPtr argumentValuePointer);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode SetKernelArg<T>(
            this CLKernel kernel,
            uint argumentIndex,
            in T argument) where T : unmanaged
        {
            fixed (T* arg = &argument)
            {
                return SetKernelArg(kernel, argumentIndex, (UIntPtr)sizeof(T), (IntPtr)arg);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelArgSVMPointer")]
        public static extern CLResultCode SetKernelArgSVMPointer(
            [In] this CLKernel kernel,
            [In] uint argumentIndex,
            [In] IntPtr argumentValuePointer);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelExecInfo")]
        public static extern CLResultCode SetKernelExecInfo(
            [In] this CLKernel kernel,
            [In] CLKernel.ExecInfo paramName,
            [In] UIntPtr paramValueSize,
            [In] IntPtr paramValue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelInfo")]
        public static extern CLResultCode GetKernelInfo(
            [In] this CLKernel kernel,
            [In] CLKernel.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetKernelInfo(
            this CLKernel kernel,
            CLKernel.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetKernelInfo(kernel, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetKernelInfo(kernel, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelArgInfo")]
        public static extern CLResultCode GetKernelArgInfo(
            [In] this CLKernel kernel,
            [In] uint argumentIndex,
            [In] CLKernel.ArgInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode GetKernelArgInfo(
           this CLKernel kernel,
            uint argumentIndex,
            CLKernel.ArgInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetKernelArgInfo(kernel, argumentIndex, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetKernelArgInfo(kernel, argumentIndex, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelWorkGroupInfo")]
        public static extern CLResultCode GetKernelWorkGroupInfo(
            [In] this CLKernel kernel,
            [In] CLDevice device,
            [In] CLKernel.WorkGroupInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetKernelWorkGroupInfo(
            this CLKernel kernel,
            CLDevice device,
            CLKernel.WorkGroupInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetKernelWorkGroupInfo(kernel, device, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetKernelWorkGroupInfo(kernel, device, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelSubGroupInfo")]
        public static extern CLResultCode GetKernelSubGroupInfo(
            [In] this CLKernel kernel,
            [In] CLDevice device,
            [In] CLKernel.SubGroupInfo paramName,
            [In] UIntPtr inputValueSize,
            [In] IntPtr inputValue,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        public static unsafe CLResultCode GetKernelSubGroupInfo<T>(
            this CLKernel kernel,
            CLDevice device,
            CLKernel.SubGroupInfo paramName,
            T[] array,
            out byte[] paramValue)
            where T : unmanaged
        {
            fixed (T* b = array)
            {
                var resultCode = GetKernelSubGroupInfo(kernel, device, paramName, (UIntPtr)(array.Length * sizeof(float)), (IntPtr)b, UIntPtr.Zero, null, out UIntPtr sizeReturned);
                paramValue = new byte[sizeReturned.ToUInt32()];
                if (sizeReturned.ToUInt32() == 0)
                    return resultCode;
                return GetKernelSubGroupInfo(kernel, device, paramName, (UIntPtr)(array.Length * sizeof(float)), (IntPtr)b, sizeReturned, paramValue, out _);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        public static unsafe CLResultCode GetKernelSubGroupInfo<T>(
            this CLKernel kernel,
            CLDevice device,
            CLKernel.SubGroupInfo paramName,
            Span<T> span,
            out byte[] paramValue)
            where T : unmanaged
        {
            fixed (T* b = span)
            {
                var resultCode = GetKernelSubGroupInfo(kernel, device, paramName, (UIntPtr)(span.Length * sizeof(float)), (IntPtr)b, UIntPtr.Zero, null, out UIntPtr sizeReturned);
                paramValue = new byte[sizeReturned.ToUInt32()];
                if (sizeReturned.ToUInt32() == 0)
                    return resultCode;
                return GetKernelSubGroupInfo(kernel, device, paramName, (UIntPtr)(span.Length * sizeof(float)), (IntPtr)b, sizeReturned, paramValue, out _);
            }
        }

        #endregion

        #region Event Object API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clWaitForEvents")]
        public static extern CLResultCode WaitForEvents(
            [In] uint numberOfEvents,
            [In] CLEvent[] eventList);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode WaitForEvents(this CLEvent[] eventList)
        {
            return WaitForEvents((uint)eventList.Length, eventList);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetEventInfo")]
        public static extern CLResultCode GetEventInfo(
            [In] this CLEvent @event,
            [In] CLEvent.Info paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetEventInfo(
            this CLEvent @event,
            CLEvent.Info paramName,
            out byte[] paramValue)
        {
            var resultCode = GetEventInfo(@event, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetEventInfo(@event, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateUserEvent")]
        public static extern CLEvent CreateUserEvent(
            [In] this CLContext context,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainEvent")]
        public static extern CLResultCode RetainEvent([In] this CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseEvent")]
        public static extern CLResultCode ReleaseEvent([In] this CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetUserEventStatus")]
        public static extern CLResultCode SetUserEventStatus(
            [In] this CLEvent @event,
            [In] int executionStatus);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetEventCallback")]
        public static extern CLResultCode SetEventCallback(
            [In] this CLEvent eventHandle,
            [In] int commandExecCallbackType,
            [In] IntPtr notifyCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static CLResultCode SetEventCallback(
            this CLEvent eventHandle,
            int callbackType,
            ClEventCallback notifyCallback,
            IntPtr userData)
        {
            return SetEventCallback(eventHandle, callbackType,
                Marshal.GetFunctionPointerForDelegate(notifyCallback), userData);
        }

        #endregion

        #region Profiling API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetEventProfilingInfo")]
        public static extern CLResultCode GetEventProfilingInfo(
            [In] this CLEvent @event,
            [In] ProfilingInfo paramName,
            [In] UIntPtr paramValueSize,
            [Out] byte[] paramValue,
            [Out] out UIntPtr paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetEventProfilingInfo(
            this CLEvent @event,
            ProfilingInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetEventProfilingInfo(@event, paramName, UIntPtr.Zero, null, out UIntPtr sizeReturned);
            paramValue = new byte[sizeReturned.ToUInt32()];
            if (sizeReturned.ToUInt32() == 0)
                return resultCode;
            return GetEventProfilingInfo(@event, paramName, sizeReturned, paramValue, out _);
        }

        #endregion

        #region Flush and Finish API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clFlush")]
        public static extern CLResultCode Flush([In] this CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clFinish")]
        public static extern CLResultCode Finish([In] this CLCommandQueue commandQueue);

        #endregion

        #region Enqueued Commands API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadBuffer")]
        public static extern CLResultCode EnqueueReadBuffer(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingRead,
            [In] UIntPtr offset,
            [In] UIntPtr sizeReturned,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBuffer<T>(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            UIntPtr offset,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent eventHandle)
            where T : unmanaged
        {
            fixed (T* b = array)
            {
                return EnqueueReadBuffer(commandQueue, buffer, blockingRead, offset,
                    (UIntPtr)(array.Length * sizeof(float)), (IntPtr)b, (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList,
                    out eventHandle);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBuffer<T>(
           this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            UIntPtr offset,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent eventHandle)
            where T : unmanaged
        {
            fixed (T* b = span)
            {
                CLResultCode resultCode = EnqueueReadBuffer(commandQueue, buffer, blockingRead, offset,
                    (UIntPtr)(span.Length * sizeof(T)), (IntPtr)b, (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out eventHandle);
                return resultCode;
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadBufferRect")]
        public static extern CLResultCode EnqueueReadBufferRect(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingRead,
            [In] UIntPtr[] bufferOffset,
            [In] UIntPtr[] hostOffset,
            [In] UIntPtr[] region,
            [In] UIntPtr bufferRowPitch,
            [In] UIntPtr bufferSlicePitch,
            [In] UIntPtr hostRowPitch,
            [In] UIntPtr hostSlicePitch,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBufferRect<T>(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            UIntPtr[] bufferOffset,
            UIntPtr[] hostOffset,
            UIntPtr[] region,
            UIntPtr bufferRowPitch,
            UIntPtr bufferSlicePitch,
            UIntPtr hostRowPitch,
            UIntPtr hostSlicePitch,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = array)
            {
                return EnqueueReadBufferRect(commandQueue, buffer, blockingRead, bufferOffset,
                    hostOffset, region,
                    bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
                    (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBufferRect<T>(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            UIntPtr[] bufferOffset,
            UIntPtr[] hostOffset,
            UIntPtr[] region,
            UIntPtr bufferRowPitch,
            UIntPtr bufferSlicePitch,
            UIntPtr hostRowPitch,
            UIntPtr hostSlicePitch,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = span)
            {
                return EnqueueReadBufferRect(commandQueue, buffer, blockingRead, bufferOffset,
                    hostOffset, region,
                    bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
                    (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWriteBuffer")]
        public static extern CLResultCode EnqueueWriteBuffer(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingWrite,
            [In] UIntPtr offset,
            [In] UIntPtr sizeReturned,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteBuffer<T>(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingWrite,
            UIntPtr offset,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent @event) where T : unmanaged
        {
            fixed (T* a = array)
            {
                CLResultCode resultCode = EnqueueWriteBuffer(commandQueue, buffer, blockingWrite, offset,
                    (UIntPtr)(array.Length * sizeof(T)), (IntPtr)a, (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);

                return resultCode;
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteBuffer<T>(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingWrite,
            UIntPtr offset,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = span)
            {
                CLResultCode resultCode = EnqueueWriteBuffer(commandQueue, buffer, blockingWrite, offset,
                    (UIntPtr)(span.Length * sizeof(T)), (IntPtr)a, (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);

                return resultCode;
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWriteBufferRect")]
        public static extern CLResultCode EnqueueWriteBufferRect(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingWrite,
            [In] UIntPtr[] bufferOffset,
            [In] UIntPtr[] hostOffset,
            [In] UIntPtr[] region,
            [In] UIntPtr bufferRowPitch,
            [In] UIntPtr bufferSlicePitch,
            [In] UIntPtr hostRowPitch,
            [In] UIntPtr hostSlicePitch,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteBufferRect<T>(
            this CLCommandQueue commandQueue, CLBuffer buffer,
            bool blockingWrite,
            UIntPtr[] bufferOffset,
            UIntPtr[] hostOffset,
            UIntPtr[] region,
            UIntPtr bufferRowPitch,
            UIntPtr bufferSlicePitch,
            UIntPtr hostRowPitch,
            UIntPtr hostSlicePitch,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = array)
            {
                return EnqueueWriteBufferRect(commandQueue, buffer, blockingWrite, bufferOffset,
                    hostOffset, region,
                    bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
                    (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteBufferRect<T>(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingWrite,
            UIntPtr[] bufferOffset,
            UIntPtr[] hostOffset,
            UIntPtr[] region,
            UIntPtr bufferRowPitch,
            UIntPtr bufferSlicePitch,
            UIntPtr hostRowPitch,
            UIntPtr hostSlicePitch,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = span)
            {
                return EnqueueWriteBufferRect(commandQueue, buffer, blockingWrite, bufferOffset,
                    hostOffset, region,
                    bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
                    (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueFillBuffer")]
        public static extern CLResultCode EnqueueFillBuffer(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] IntPtr pattern,
            [In] UIntPtr patternSize,
            [In] UIntPtr offset,
            [In] UIntPtr sizeReturned,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);


        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static unsafe CLResultCode EnqueueFillBuffer<T>(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            T[] pattern,
            UIntPtr offset,
            UIntPtr sizeReturned,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* p = pattern)
            {
                return EnqueueFillBuffer(commandQueue, buffer, (IntPtr)p, (UIntPtr)(pattern.Length * sizeof(T)), offset,
                    sizeReturned, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBuffer")]
        public static extern CLResultCode EnqueueCopyBuffer(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer srcBuffer,
            [In] CLBuffer dstBuffer,
            [In] UIntPtr srcOffset,
            [In] UIntPtr dstOffset,
            [In] UIntPtr sizeReturned,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyBuffer(
           this CLCommandQueue commandQueue,
            CLBuffer srcBuffer,
            CLBuffer dstBuffer,
            UIntPtr srcOffset,
            UIntPtr dstOffset,
            UIntPtr sizeReturned,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyBuffer(commandQueue, srcBuffer, dstBuffer, srcOffset, dstOffset,
                sizeReturned, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBufferRect")]
        public static extern CLResultCode EnqueueCopyBufferRect(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer srcBuffer,
            [In] CLBuffer dstBuffer,
            [In] UIntPtr[] srcOrigin,
            [In] UIntPtr[] dstOrigin,
            [In] UIntPtr[] region,
            [In] UIntPtr srcRowPitch,
            [In] UIntPtr srcSlicePitch,
            [In] UIntPtr dstRowPitch,
            [In] UIntPtr dstSlicePitch,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static CLResultCode EnqueueCopyBufferRect(
            this CLCommandQueue commandQueue,
            CLBuffer srcBuffer,
            CLBuffer dstBuffer,
            UIntPtr[] srcOrigin,
            UIntPtr[] dstOrigin,
            UIntPtr[] region,
            UIntPtr srcRowPitch,
            UIntPtr srcSlicePitch,
            UIntPtr dstRowPitch,
            UIntPtr dstSlicePitch,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyBufferRect(commandQueue, srcBuffer, dstBuffer, srcOrigin, dstOrigin, region, srcRowPitch,
                srcSlicePitch, dstRowPitch, dstSlicePitch, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadImage")]
        public static extern CLResultCode EnqueueReadImage(
            [In] this CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] bool blockingRead,
            [In] UIntPtr[] origin,
            [In] UIntPtr[] region,
            [In] UIntPtr rowPitch,
            [In] UIntPtr slicePitch,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueReadImage<T>(
           this CLCommandQueue commandQueue,
            CLImage image,
            bool blockingRead,
            UIntPtr[] origin,
            UIntPtr[] region,
            UIntPtr rowPitch,
            UIntPtr slicePitch,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = array)
            {
                return EnqueueReadImage(commandQueue, image, blockingRead, origin, region, rowPitch,
                slicePitch, (IntPtr)a, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueReadImage<T>(
           this CLCommandQueue commandQueue,
            CLImage image,
            bool blockingRead,
            UIntPtr[] origin,
            UIntPtr[] region,
            UIntPtr rowPitch,
            UIntPtr slicePitch,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = span)
            {
                return EnqueueReadImage(commandQueue, image, blockingRead, origin, region, rowPitch,
                slicePitch, (IntPtr)a, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWriteImage")]
        public static extern CLResultCode EnqueueWriteImage(
            [In] this CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] bool blockingWrite,
            [In] UIntPtr[] origin,
            [In] UIntPtr[] region,
            [In] UIntPtr inputRowPitch,
            [In] UIntPtr inputSlicePitch,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteImage<T>(
           this CLCommandQueue commandQueue,
            CLImage image,
            bool blockingWrite,
            UIntPtr[] origin,
            UIntPtr[] region,
            UIntPtr inputRowPitch,
            UIntPtr inputSlicePitch,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = array)
            {
                return EnqueueWriteImage(commandQueue, image, blockingWrite, origin, region, inputRowPitch,
                inputSlicePitch, (IntPtr)a, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteImage<T>(
            this CLCommandQueue commandQueue,
            CLImage image,
            bool blockingWrite,
            UIntPtr[] origin,
            UIntPtr[] region,
            UIntPtr inputRowPitch,
            UIntPtr inputSlicePitch,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = span)
            {
                return EnqueueWriteImage(commandQueue, image, blockingWrite, origin, region, inputRowPitch,
                inputSlicePitch, (IntPtr)a, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueFillImage")]
        public static extern CLResultCode EnqueueFillImage(
            [In] this CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] IntPtr fillColor,
            [In] UIntPtr[] origin,
            [In] UIntPtr[] region,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode EnqueueFillImage(
            this CLCommandQueue commandQueue,
            CLImage image,
            IntPtr fillColor,
            UIntPtr[] origin,
            UIntPtr[] region,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueFillImage(commandQueue, image, fillColor, origin, region,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyImage")]
        public static extern CLResultCode EnqueueCopyImage(
            [In] this CLCommandQueue commandQueue,
            [In] CLImage srcImage,
            [In] CLImage dstImage,
            [In] UIntPtr[] srcOrigin,
            [In] UIntPtr[] dstOrigin,
            [In] UIntPtr[] region,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyImage(
            this CLCommandQueue commandQueue,
            CLImage srcImage,
            CLImage dstImage,
            UIntPtr[] srcOrigin,
            UIntPtr[] dstOrigin,
            UIntPtr[] region,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyImage(commandQueue, srcImage, dstImage, srcOrigin, dstOrigin, region,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyImageToBuffer")]
        public static extern CLResultCode EnqueueCopyImageToBuffer(
            [In] this CLCommandQueue commandQueue,
            [In] CLImage srcImage,
            [In] CLBuffer dstBuffer,
            [In] UIntPtr[] srcOrigin,
            [In] UIntPtr[] region,
            [In] UIntPtr dstOffset,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyImageToBuffer(
            this CLCommandQueue commandQueue,
            CLImage srcImage,
            CLBuffer dstBuffer,
            UIntPtr[] srcOrigin,
            UIntPtr[] region,
            UIntPtr dstOffset,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyImageToBuffer(commandQueue, srcImage, dstBuffer, srcOrigin, region, dstOffset,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBufferToImage")]
        public static extern CLResultCode EnqueueCopyBufferToImage(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer srcBuffer,
            [In] CLImage dstImage,
            [In] UIntPtr srcOffset,
            [In] UIntPtr[] dstOrigin,
            [In] UIntPtr[] region,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyBufferToImage(
           this CLCommandQueue commandQueue,
            CLBuffer srcBuffer,
            CLImage dstImage,
            UIntPtr srcOffset,
            UIntPtr[] dstOrigin,
            UIntPtr[] region,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyBufferToImage(commandQueue, srcBuffer, dstImage, srcOffset, dstOrigin, region,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMapBuffer")]
        public static extern IntPtr EnqueueMapBuffer(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingMap,
            [In] MapFlags flags,
            [In] UIntPtr offset,
            [In] UIntPtr sizeReturned,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static IntPtr EnqueueMapBuffer(
            this CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingMap,
            MapFlags flags,
            UIntPtr offset,
            UIntPtr sizeReturned,
            CLEvent[] eventWaitList,
            out CLEvent @event,
            out CLResultCode resultCode)
        {
            return EnqueueMapBuffer(commandQueue, buffer, blockingMap, flags, offset, sizeReturned,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMapImage")]
        public static extern IntPtr EnqueueMapImage(
            [In] this CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] bool blockingMap,
            [In] MapFlags flags,
            [In] UIntPtr[] origin,
            [In] UIntPtr[] region,
            [In] UIntPtr rowPitch,
            [In] UIntPtr slicePitch,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static IntPtr EnqueueMapImage(
           this CLCommandQueue commandQueue,
            CLImage image,
            bool blockingMap,
            MapFlags flags,
            UIntPtr[] origin,
            UIntPtr[] region,
            UIntPtr rowPitch,
            UIntPtr slicePitch,
            CLEvent[] eventWaitList,
            out CLEvent @event,
            out CLResultCode resultCode)
        {
            return EnqueueMapImage(commandQueue, image, blockingMap, flags, origin, region, rowPitch, slicePitch,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
        public static extern CLResultCode EnqueueUnmapMemoryObject(
            [In] this CLCommandQueue commandQueue,
            [In] IntPtr memoryObject,
            [In] IntPtr mapperPtr,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueUnmapMemoryObject(
            this CLCommandQueue commandQueue,
            IntPtr memoryObject,
            IntPtr mapperPtr,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueUnmapMemoryObject(commandQueue, memoryObject, mapperPtr,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
        public static extern CLResultCode EnqueueUnmapMemoryObject(
            [In] this CLCommandQueue commandQueue,
            [In] CLBuffer memoryObject,
            [In] IntPtr mapperPtr,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueUnmapMemoryObject(
            this CLCommandQueue commandQueue,
            CLBuffer memoryObject,
            IntPtr mapperPtr,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueUnmapMemoryObject(commandQueue, memoryObject, mapperPtr,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
        public static extern CLResultCode EnqueueUnmapMemoryObject(
            [In] this CLCommandQueue commandQueue,
            [In] CLImage memoryObject,
            [In] IntPtr mapperPtr,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueUnmapMemoryObject(
            this CLCommandQueue commandQueue,
            CLImage memoryObject,
            IntPtr mapperPtr,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueUnmapMemoryObject(commandQueue, memoryObject, mapperPtr,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMigrateMemObjects")]
        public static extern CLResultCode EnqueueMigrateMemoryObjects(
            [In] this CLCommandQueue commandQueue,
            [In] uint numberOfMemoryObjects,
            [In] IntPtr[] memoryObjects,
            [In] MemoryMigrationFlags flags,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode EnqueueMigrateMemoryObjects(
            this CLCommandQueue commandQueue,
            IntPtr[] memoryObjects,
            MemoryMigrationFlags flags,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueMigrateMemoryObjects(commandQueue, (uint)(memoryObjects?.Length ?? 0), memoryObjects, flags,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueNDRangeKernel")]
        public static extern CLResultCode EnqueueNDRangeKernel(
            [In] this CLCommandQueue commandQueue,
            [In] CLKernel kernel,
            [In] uint workDimension,
            [In] UIntPtr[] globalWorkOffset,
            [In] UIntPtr[] globalWorkSize,
            [In] UIntPtr[] localWorkSize,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueNDRangeKernel(
            this CLCommandQueue commandQueue,
            CLKernel kernel,
            uint workDimension,
            UIntPtr[] globalWorkOffset,
            UIntPtr[] globalWorkSize,
            UIntPtr[] localWorkSize,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueNDRangeKernel(commandQueue, kernel, workDimension, globalWorkOffset, globalWorkSize, localWorkSize,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueNativeKernel")]
        public static extern CLResultCode EnqueueNativeKernel(
            [In] this CLCommandQueue commandQueue,
            [In] IntPtr userFunction,
            [In] IntPtr[] arguments,
            [In] UIntPtr argumentSize,
            [In] uint numberOfMemoryObjects,
            [In] IntPtr[] memoryObjects,
            [In] IntPtr argumentsMemoryLocation,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueNativeKernel(
            this CLCommandQueue commandQueue,
            IntPtr userFunction,
            IntPtr[] arguments,
            UIntPtr argumentSize,
            IntPtr[] memoryObjects,
            IntPtr argumentsMemoryLocation,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueNativeKernel(commandQueue, userFunction, arguments, argumentSize, (uint)(memoryObjects?.Length ?? 0), memoryObjects, argumentsMemoryLocation,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMarkerWithWaitList")]
        public static extern CLResultCode EnqueueMarkerWithWaitList(
            [In] this CLCommandQueue commandQueue,
            [In] uint numberOfMemoryObjects,
            [In] IntPtr[] memoryObjects,
            [In] IntPtr argumentsMemoryLocation,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode EnqueueMarkerWithWaitList(
           this CLCommandQueue commandQueue,
            IntPtr[] memoryObjects,
            IntPtr argumentsMemoryLocation,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueMarkerWithWaitList(commandQueue, (uint)(memoryObjects?.Length ?? 0), memoryObjects, argumentsMemoryLocation,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueBarrierWithWaitList")]
        public static extern CLResultCode EnqueueBarrierWithWaitList(
            [In] this CLCommandQueue commandQueue,
            [In] uint numberOfMemoryObjects,
            [In] IntPtr[] memoryObjects,
            [In] IntPtr argumentsMemoryLocation,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode EnqueueBarrierWithWaitList(
            this CLCommandQueue commandQueue,
            IntPtr[] memoryObjects,
            IntPtr argumentsMemoryLocation,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueBarrierWithWaitList(commandQueue, (uint)(memoryObjects?.Length ?? 0), memoryObjects, argumentsMemoryLocation,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMFree")]
        public static extern CLResultCode EnqueueSVMFree(
            [In] this CLCommandQueue commandQueue,
            [In] uint numberOfSvmPointers,
            [In] IntPtr[] svmPointers,
            [In] IntPtr svmFreePointersCallback,
            [In] IntPtr userData,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSVMFree(
            this CLCommandQueue commandQueue,
            IntPtr[] svmPointers,
            ClEventCallback svmFreePointersCallback,
            IntPtr userData,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSVMFree(commandQueue, (uint)(svmPointers?.Length ?? 0), svmPointers, Marshal.GetFunctionPointerForDelegate(svmFreePointersCallback), userData,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMemcpy")]
        public static extern CLResultCode EnqueueSvmMemoryCopy(
            [In] this CLCommandQueue commandQueue,
            [In] bool blockingCopy,
            [In] IntPtr dstPointer,
            [In] IntPtr srcPointer,
            [In] UIntPtr sizeReturned,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSvmMemoryCopy(
           this CLCommandQueue commandQueue,
            bool blockingCopy,
            IntPtr dstPointer,
            IntPtr srcPointer,
            UIntPtr sizeReturned,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmMemoryCopy(commandQueue, blockingCopy, dstPointer, srcPointer, sizeReturned,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMemFill")]
        public static extern CLResultCode EnqueueSvmMemoryFill(
            [In] this CLCommandQueue commandQueue,
            [In] IntPtr svmPointer,
            [In] IntPtr pattern,
            [In] UIntPtr patternSize,
            [In] UIntPtr sizeReturned,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static unsafe CLResultCode EnqueueSvmMemoryFill<T>(
            this CLCommandQueue commandQueue,
            IntPtr svmPointer,
            T[] pattern,
            UIntPtr sizeReturned,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* p = pattern)
            {
                return EnqueueSvmMemoryFill(commandQueue, svmPointer, (IntPtr)p, (UIntPtr)(pattern.Length * sizeof(T)),
                    sizeReturned, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static unsafe CLResultCode EnqueueSvmMemoryFill<T>(
            this CLCommandQueue commandQueue,
            IntPtr svmPointer,
            Span<T> pattern,
            UIntPtr sizeReturned,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* p = pattern)
            {
                return EnqueueSvmMemoryFill(commandQueue, svmPointer, (IntPtr)p, (UIntPtr)(pattern.Length * sizeof(T)),
                    sizeReturned, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMap")]
        public static extern CLResultCode EnqueueSvmMap(
            [In] this CLCommandQueue commandQueue,
            [In] bool blockingMap,
            [In] MapFlags mapFlag,
            [In] IntPtr svmPointer,
            [In] UIntPtr sizeReturned,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSvmMap(
            this CLCommandQueue commandQueue,
            bool blockingMap,
            MapFlags mapFlag,
            IntPtr svmPointer,
            UIntPtr sizeReturned,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmMap(commandQueue, blockingMap, mapFlag, svmPointer, sizeReturned,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMUnmap")]
        public static extern CLResultCode EnqueueSVMUnmap(
            [In] this CLCommandQueue commandQueue,
            [In] IntPtr svmPointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSVMUnmap(
            this CLCommandQueue commandQueue,
            IntPtr svmPointer,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSVMUnmap(commandQueue, svmPointer,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMigrateMem")]
        public static extern CLResultCode EnqueueSvmMigrateMemory(
            [In] this CLCommandQueue commandQueue,
            [In] uint numberOfSvmPointers,
            [In] IntPtr[] svmPointers,
            [In] UIntPtr[] sizes,
            [In] MemoryMigrationFlags memoryMigrationFlags,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        public static CLResultCode EnqueueSvmMigrateMemory(
            [In] this CLCommandQueue commandQueue,
            IntPtr[] svmPointers,
            UIntPtr[] sizes,
            MemoryMigrationFlags memoryMigrationFlags,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmMigrateMemory(commandQueue, (uint)(svmPointers?.Length ?? 0), svmPointers, sizes, memoryMigrationFlags,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        #endregion

        #region Extension function access

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        public static extern IntPtr GetExtensionFunctionAddressForPlatform(
            [In] this CLPlatform platform,
            [In] string functionName);

        #endregion

        #region Deprecated OpenCL API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated method, use CreateImage instead")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage2D")]
        public static extern CLImage CreateImage2D(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] ref ImageFormat imageFormat,
            [In] UIntPtr imageWidth,
            [In] UIntPtr imageHeight,
            [In] UIntPtr imageRowPitch,
            [In] IntPtr hostPointer,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated method, use CreateImage instead")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage3D")]
        public static extern CLImage CreateImage3D(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] ref ImageFormat imageFormat,
            [In] UIntPtr imageWidth,
            [In] UIntPtr imageHeight,
            [In] UIntPtr imageDepth,
            [In] UIntPtr imageRowPitch,
            [In] UIntPtr imageSlicePitch,
            [In] IntPtr hostPointer,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.1, use EnqueueMarkerWithWaitList.")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMarker")]
        public static extern CLResultCode EnqueueMarker(
            [In] CLCommandQueue commandQueue,
            [In] CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.1, use EnqueueMarkerWithWaitList.")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWaitForEvents")]
        public static extern CLResultCode EnqueueWaitForEvents(
            [In] CLCommandQueue commandQueue,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventList);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.1, use EnqueueMarkerWithWaitList.")]
        public static CLResultCode EnqueueWaitForEvents(
            CLCommandQueue commandQueue,
            CLEvent[] eventList)
        {
            return EnqueueWaitForEvents(commandQueue, (uint)(eventList?.Length ?? 0), eventList);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.1, use EnqueueBarrierWithWaitList.")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueBarrier")]
        public static extern CLResultCode EnqueueBarrier([In] CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.1, use UnloadPlatformCompiler.")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clUnloadCompiler")]
        public static extern CLResultCode UnloadCompiler();

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated method")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetExtensionFunctionAddress")]
        public static extern CLResultCode GetExtensionFunctionAddress([In] string funcName);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2, use CreateCommandQueueWithProperties.")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateCommandQueue")]
        public static extern CLCommandQueue CreateCommandQueue(
            [In] CLContext context,
            [In] CLDevice device,
            [In] CLCommandQueue.Properties properties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSampler")]
        public static extern CLSampler CreateSampler(
            [In] CLContext context,
            [In] uint normalizedCoordinates,
            [In] CLSampler.AddressingMode addressingMode,
            [In] CLSampler.FilterMode filterMode,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueTask")]
        public static extern CLResultCode EnqueueTask(
            [In] CLCommandQueue commandQueue,
            [In] CLKernel kernel,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2")]
        public static CLResultCode EnqueueTask(
            CLCommandQueue commandQueue,
            CLKernel kernel,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueTask(commandQueue, kernel, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        #endregion
    }
}
