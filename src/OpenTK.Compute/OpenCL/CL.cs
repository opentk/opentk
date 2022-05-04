﻿using System;
using System.Runtime.InteropServices;
using OpenTK.Compute.Native;

namespace OpenTK.Compute.OpenCL
{
    public static class CL
    {
        static CL()
        {
            CLLoader.RegisterDllResolver();
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
        public static extern CLResultCode GetPlatformIDs(
            [In] uint numberOfEntries,
            [Out] CLPlatform[] platforms,
            [Out] out uint numberOfPlatforms);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        /// <param name="platformIds">returns a list of OpenCL platforms found. The CLPlatform values returned in platforms can be used to identify a specific OpenCL platform.</param>
        /// <returns>returns Success if the function is executed successfully. Otherwise, it returns one of the following errors:
        /// -InvalidValue if numberOfEntries is equal to zero and platforms is not NULL or if both numberOfPlatforms and platforms are NULL.
        /// -OutOfHostMemory if there is a failure to allocate resources required by the OpenCL implementation on the host.</returns>
        public static CLResultCode GetPlatformIDs(out CLPlatform[] platformIds)
        {
            var resultCode = GetPlatformIDs(0, null, out uint sizeReturned);
            platformIds = new CLPlatform[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetPlatformIDs(sizeReturned, platformIds, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetPlatformInfo")]
        public static extern CLResultCode GetPlatformInfo(
            [In] CLPlatform platform,
            [In] PlatformInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetPlatformInfo(
            CLPlatform platform,
            PlatformInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetPlatformInfo(platform, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetPlatformInfo(platform, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        public static extern IntPtr GetExtensionFunctionAddressForPlatform(
            [In] CLPlatform platform,
            [In] string functionName);

        #endregion

        #region Device API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceIDs")]
        public static extern CLResultCode GetDeviceIDs(
            [In] CLPlatform platform,
            [In] DeviceType deviceType,
            [In] uint numberOfEntries,
            [Out] CLDevice[] devices,
            [Out] out uint numberOfsizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetDeviceIDs(
            CLPlatform platform,
            DeviceType deviceType,
            out CLDevice[] deviceIds)
        {
            var resultCode = GetDeviceIDs(platform, deviceType, 0, null, out uint sizeReturned);
            deviceIds = new CLDevice[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetDeviceIDs(platform, deviceType, sizeReturned, deviceIds, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceInfo")]
        public static extern CLResultCode GetDeviceInfo(
            [In] CLDevice device,
            [In] DeviceInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetDeviceInfo(
            CLDevice device,
            DeviceInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetDeviceInfo(device, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetDeviceInfo(device, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSubDevices")]
        public static extern CLResultCode CreateSubDevices(
            [In] CLDevice inDevice,
            [In] IntPtr[] properties,
            [In] uint numberOfDevices,
            [Out] CLDevice[] outDevices,
            [Out] out uint sizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode CreateSubDevices(
            CLDevice inDevice,
            CLDevicePartitionProperties properties,
            out CLDevice[] outDevices)
        {
            var props = properties.CreatePropertyArray();
            var resultCode = CreateSubDevices(inDevice, props, 0, null, out uint sizeReturned);
            outDevices = new CLDevice[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return CreateSubDevices(inDevice, props, sizeReturned, outDevices, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainDevice")]
        public static extern CLResultCode RetainDevice([In] CLDevice device);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseDevice")]
        public static extern CLResultCode ReleaseDevice([In] CLDevice device);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetDeviceAndHostTimer")]
        public static extern CLResultCode GetDeviceAndHostTimer(
            [In] CLDevice device,
            [Out] out nuint deviceTimestamp,
            [Out] out nuint hostTimestamp);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetHostTimer")]
        public static extern CLResultCode GetHostTimer(
            [In] CLDevice device,
            [Out] out nuint hostTimestamp);

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
            CLContextProperties properties,
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
            [In] DeviceType deviceType,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLContext CreateContextFromType(
            CLContextProperties properties,
            DeviceType deviceType,
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
        public static extern CLResultCode RetainContext([In] CLContext context);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseContext")]
        public static extern CLResultCode ReleaseContext([In] CLContext context);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetContextInfo")]
        public static extern CLResultCode GetContextInfo(
            [In] CLContext context,
            [In] ContextInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);


        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetContextInfo(
            CLContext context,
            ContextInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetContextInfo(context, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetContextInfo(context, paramName, sizeReturned, paramValue, out _);
        }


        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetContextDestructorCallback")]
        public static extern CLResultCode SetContextDestructorCallback(
            [In] CLContext context,
            [In] IntPtr callback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static CLResultCode SetContextDestructorCallback(
            CLContext context,
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
            [In] CLContext context,
            [In] CLDevice device,
            [In] ulong[] properties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLCommandQueue CreateCommandQueueWithProperties(
            CLContext context,
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
        public static extern CLResultCode RetainCommandQueue([In] CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseCommandQueue")]
        public static extern CLResultCode ReleaseCommandQueue([In] CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetCommandQueueInfo")]
        public static extern CLResultCode GetCommandQueueInfo(
            [In] CLCommandQueue commandQueue,
            [In] CommandQueueInfo paramName,
            [In] nuint paramSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetCommandQueueInfo(
           CLCommandQueue queue,
            CommandQueueInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetCommandQueueInfo(queue, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetCommandQueueInfo(queue, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetDefaultDeviceCommandQueue")]
        public static extern CLResultCode SetDefaultDeviceCommandQueue(
            [In] CLContext context,
            [In] CLDevice device,
            [In] CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clFlush")]
        public static extern CLResultCode Flush([In] CLCommandQueue commandQueue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clFinish")]
        public static extern CLResultCode Finish([In] CLCommandQueue commandQueue);

        #endregion

        #region Buffer Objects APIs

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateBuffer")]
        public static extern CLBuffer CreateBuffer(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] nuint size,
            [In] IntPtr hostPtr,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLBuffer CreateBuffer<T>(
           CLContext context,
            MemoryFlags flags,
            T[] array,
            out CLResultCode resultCode) where T : unmanaged
        {
            fixed (T* b = array)
            {
                return CreateBuffer(context, flags, (nuint)(array.Length * sizeof(T)), (IntPtr)b, out resultCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLBuffer CreateBuffer<T>(
            CLContext context,
            MemoryFlags flags,
            Span<T> span,
            out CLResultCode resultCode) where T : unmanaged
        {
            fixed (T* b = span)
            {
                return CreateBuffer(context, flags, (nuint)(span.Length * sizeof(T)), (IntPtr)b, out resultCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSubBuffer")]
        public static extern CLBuffer CreateSubBuffer(
            [In] CLBuffer buffer,
            [In] MemoryFlags flags,
            [In] BufferCreateType bufferCreateType,
            [In] ref CLBufferRegion bufferCreateInfo,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateBufferWithProperties")]
        public static extern CLBuffer CreateBufferWithProperties(
            [In] CLContext context,
            [In] ulong[] properties,
            [In] MemoryFlags flags,
            [In] nuint size,
            [In] IntPtr hostPtr,
            [Out] out CLResultCode errorCode);

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static unsafe CLBuffer CreateBufferWithProperties<T>(
            CLContext context,
            CLBufferProperties properties,
            MemoryFlags flags,
            T[] array,
            out CLResultCode errorCode)
            where T : unmanaged
        {
            fixed (T* b = array)
            {
                return CreateBufferWithProperties(context, properties.CreatePropertyArray(), flags, (nuint)(array.Length * sizeof(T)), (IntPtr)b,
                    out errorCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static unsafe CLBuffer CreateBufferWithProperties<T>(
            CLContext context,
            CLBufferProperties properties,
            MemoryFlags flags,
            Span<T> span,
            out CLResultCode errorCode)
            where T : unmanaged
        {
            fixed (T* b = span)
            {
                return CreateBufferWithProperties(context, properties.CreatePropertyArray(), flags, (nuint)(span.Length * sizeof(T)), (IntPtr)b,
                    out errorCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] CLBuffer buffer);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] CLBuffer buffer);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] CLBuffer buffer,
            [In] MemoryObjectInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
           CLBuffer buffer,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(buffer, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetMemObjectInfo(buffer, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
        public static extern CLResultCode SetMemoryObjectDestructorCallback(
            [In] CLBuffer buffer,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode SetMemoryObjectDestructorCallback(
            CLBuffer buffer,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetMemoryObjectDestructorCallback(buffer, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMapBuffer")]
        public static extern IntPtr EnqueueMapBuffer(
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingMap,
            [In] MapFlags flags,
            [In] nuint offset,
            [In] nuint size,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static IntPtr EnqueueMapBuffer(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingMap,
            MapFlags flags,
            nuint offset,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event,
            out CLResultCode resultCode)
        {
            return EnqueueMapBuffer(commandQueue, buffer, blockingMap, flags, offset, size,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
        public static extern CLResultCode EnqueueUnmapMemoryObject(
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer memoryObject,
            [In] IntPtr mapperPtr,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueUnmapMemoryObject(
            CLCommandQueue commandQueue,
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
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadBuffer")]
        public static extern CLResultCode EnqueueReadBuffer(
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingRead,
            [In] nuint offset,
            [In] nuint size,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBuffer<T>(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            nuint offset,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent eventHandle)
            where T : unmanaged
        {
            fixed (T* b = array)
            {
                return EnqueueReadBuffer(commandQueue, buffer, blockingRead, offset,
                                         (nuint)(array.Length * sizeof(T)), (IntPtr)b,
                                         (uint)(eventWaitList?.Length ?? 0), eventWaitList, out eventHandle);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBuffer<T>(
           CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            nuint offset,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent eventHandle)
            where T : unmanaged
        {
            fixed (T* b = span)
            {
                return EnqueueReadBuffer(commandQueue, buffer, blockingRead, offset,
                    (nuint)(span.Length * sizeof(T)), (IntPtr)b, (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out eventHandle);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadBufferRect")]
        public static extern CLResultCode EnqueueReadBufferRect(
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingRead,
            [In] nuint[] bufferOffset,
            [In] nuint[] hostOffset,
            [In] nuint[] region,
            [In] nuint bufferRowPitch,
            [In] nuint bufferSlicePitch,
            [In] nuint hostRowPitch,
            [In] nuint hostSlicePitch,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBufferRect<T>(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            nuint[] bufferOffset,
            nuint[] hostOffset,
            nuint[] region,
            nuint bufferRowPitch,
            nuint bufferSlicePitch,
            nuint hostRowPitch,
            nuint hostSlicePitch,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = array)
            {
                return EnqueueReadBufferRect(commandQueue, buffer, blockingRead, bufferOffset, hostOffset, region,
                                             bufferRowPitch, bufferSlicePitch, hostRowPitch, hostSlicePitch, (IntPtr)a,
                                             (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static unsafe CLResultCode EnqueueReadBufferRect<T>(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingRead,
            nuint[] bufferOffset,
            nuint[] hostOffset,
            nuint[] region,
            nuint bufferRowPitch,
            nuint bufferSlicePitch,
            nuint hostRowPitch,
            nuint hostSlicePitch,
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
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingWrite,
            [In] nuint offset,
            [In] nuint size,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteBuffer<T>(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingWrite,
            nuint offset,
            T[] array,
            CLEvent[] eventWaitList,
            out CLEvent @event) where T : unmanaged
        {
            fixed (T* a = array)
            {
                return EnqueueWriteBuffer(commandQueue, buffer, blockingWrite, offset,
                    (nuint)(array.Length * sizeof(T)), (IntPtr)a, (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteBuffer<T>(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingWrite,
            nuint offset,
            Span<T> span,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = span)
            {
                return EnqueueWriteBuffer(commandQueue, buffer, blockingWrite, offset,
                    (nuint)(span.Length * sizeof(T)), (IntPtr)a, (uint)(eventWaitList?.Length ?? 0),
                    eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueWriteBufferRect")]
        public static extern CLResultCode EnqueueWriteBufferRect(
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] bool blockingWrite,
            [In] nuint[] bufferOffset,
            [In] nuint[] hostOffset,
            [In] nuint[] region,
            [In] nuint bufferRowPitch,
            [In] nuint bufferSlicePitch,
            [In] nuint hostRowPitch,
            [In] nuint hostSlicePitch,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteBufferRect<T>(
            CLCommandQueue commandQueue, CLBuffer buffer,
            bool blockingWrite,
            nuint[] bufferOffset,
            nuint[] hostOffset,
            nuint[] region,
            nuint bufferRowPitch,
            nuint bufferSlicePitch,
            nuint hostRowPitch,
            nuint hostSlicePitch,
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
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            bool blockingWrite,
            nuint[] bufferOffset,
            nuint[] hostOffset,
            nuint[] region,
            nuint bufferRowPitch,
            nuint bufferSlicePitch,
            nuint hostRowPitch,
            nuint hostSlicePitch,
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
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer buffer,
            [In] IntPtr pattern,
            [In] nuint patternSize,
            [In] nuint offset,
            [In] nuint size,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);


        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static unsafe CLResultCode EnqueueFillBuffer<T>(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            T[] pattern,
            nuint offset,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* p = pattern)
            {
                return EnqueueFillBuffer(commandQueue, buffer, (IntPtr)p, (nuint)(pattern.Length * sizeof(T)), offset,
                    size, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }


        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static unsafe CLResultCode EnqueueFillBuffer<T>(
            CLCommandQueue commandQueue,
            CLBuffer buffer,
            Span<T> pattern,
            nuint offset,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* p = pattern)
            {
                return EnqueueFillBuffer(commandQueue, buffer, (IntPtr)p, (nuint)(pattern.Length * sizeof(T)), offset,
                    size, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBuffer")]
        public static extern CLResultCode EnqueueCopyBuffer(
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer srcBuffer,
            [In] CLBuffer dstBuffer,
            [In] nuint srcOffset,
            [In] nuint dstOffset,
            [In] nuint size,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyBuffer(
           CLCommandQueue commandQueue,
            CLBuffer srcBuffer,
            CLBuffer dstBuffer,
            nuint srcOffset,
            nuint dstOffset,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyBuffer(commandQueue, srcBuffer, dstBuffer, srcOffset, dstOffset,
                size, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyBufferRect")]
        public static extern CLResultCode EnqueueCopyBufferRect(
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer srcBuffer,
            [In] CLBuffer dstBuffer,
            [In] nuint[] srcOrigin,
            [In] nuint[] dstOrigin,
            [In] nuint[] region,
            [In] nuint srcRowPitch,
            [In] nuint srcSlicePitch,
            [In] nuint dstRowPitch,
            [In] nuint dstSlicePitch,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static CLResultCode EnqueueCopyBufferRect(
            CLCommandQueue commandQueue,
            CLBuffer srcBuffer,
            CLBuffer dstBuffer,
            nuint[] srcOrigin,
            nuint[] dstOrigin,
            nuint[] region,
            nuint srcRowPitch,
            nuint srcSlicePitch,
            nuint dstRowPitch,
            nuint dstSlicePitch,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyBufferRect(commandQueue, srcBuffer, dstBuffer, srcOrigin, dstOrigin, region, srcRowPitch,
                srcSlicePitch, dstRowPitch, dstSlicePitch, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        #endregion

        #region Image Objects API

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage")]
        public static extern CLImage CreateImage(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] ref CLImageFormat imageFormat,
            [In] ref CLImageDescription imageDesc,
            [In] IntPtr hostPtr,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static unsafe CLImage CreateImage<T>(
            CLContext context,
            MemoryFlags flags,
            ref CLImageFormat imageFormat,
            ref CLImageDescription imageDesc,
            T[] array,
            out CLResultCode resultCode)
            where T : unmanaged
        {
            fixed (T* b = array)
            {
                return CreateImage(context, flags, ref imageFormat, ref imageDesc, (IntPtr)b, out resultCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static unsafe CLImage CreateImage<T>(
            CLContext context,
            MemoryFlags flags,
            ref CLImageFormat imageFormat,
            ref CLImageDescription imageDesc,
            Span<T> span,
            out CLResultCode resultCode)
            where T : unmanaged
        {
            fixed (T* b = span)
            {
                return CreateImage(context, flags, ref imageFormat, ref imageDesc, (IntPtr)b, out resultCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage")]
        public static extern CLImage CreateImage(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] ref CLImageFormat imageFormat,
            [In] ref CLImageDescription imageDesc,
            [In] CLBuffer hostPtr,
            [Out] out CLResultCode resultCode);


        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage")]
        public static extern CLImage CreateImage(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] ref CLImageFormat imageFormat,
            [In] ref CLImageDescription imageDesc,
            [In] CLImage hostPtr,
            [Out] out CLResultCode resultCode);


        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImageWithProperties")]
        public static extern CLImage CreateImageWithProperties(
            [In] CLContext context,
            [In] ulong[] properties,
            [In] MemoryFlags flags,
            [In] ref CLImageFormat imageFormat,
            [In] ref CLImageDescription imageDesc,
            [In] IntPtr hostPtr,
            [Out] out CLResultCode errorCode);

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static CLImage CreateImageWithProperties(
            CLContext context,
            CLImageProperties properties,
            MemoryFlags flags,
            ref CLImageFormat imageFormat,
            ref CLImageDescription imageDesc,
            CLImage hostPtr,
            out CLResultCode errorCode)
        {
            return CreateImageWithProperties(context, properties.CreatePropertyArray(), flags, ref imageFormat, ref imageDesc, hostPtr, out errorCode);
        }

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static CLImage CreateImageWithProperties(
            CLContext context,
            CLImageProperties properties,
            MemoryFlags flags,
            ref CLImageFormat imageFormat,
            ref CLImageDescription imageDesc,
            CLBuffer hostPtr,
            out CLResultCode errorCode)
        {
            return CreateImageWithProperties(context, properties.CreatePropertyArray(), flags, ref imageFormat, ref imageDesc, hostPtr, out errorCode);
        }

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static unsafe CLImage CreateImageWithProperties<T>(
            CLContext context,
            CLImageProperties properties,
            MemoryFlags flags,
            ref CLImageFormat imageFormat,
            ref CLImageDescription imageDesc,
            T[] array,
            out CLResultCode errorCode)
            where T : unmanaged
        {
            fixed (T* b = array)
            {
                return CreateImageWithProperties(context, properties.CreatePropertyArray(), flags, ref imageFormat, ref imageDesc, (IntPtr)b, out errorCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 3.0
        /// </summary>
        public static unsafe CLImage CreateImageWithProperties<T>(
            CLContext context,
            CLImageProperties properties,
            MemoryFlags flags,
            ref CLImageFormat imageFormat,
            ref CLImageDescription imageDesc,
            Span<T> span,
            out CLResultCode errorCode)
            where T : unmanaged
        {
            fixed (T* b = span)
            {
                return CreateImageWithProperties(context, properties.CreatePropertyArray(), flags, ref imageFormat, ref imageDesc, (IntPtr)b, out errorCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] CLImage image);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] CLImage image);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetSupportedImageFormats")]
        public static extern CLResultCode GetSupportedImageFormats(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] MemoryObjectType imageType,
            [In] uint numberOfEntries,
            [Out] [MarshalAs(UnmanagedType.LPArray)]
            CLImageFormat[] imageFormats,
            [Out] out uint numberOfImageFormats);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetSupportedImageFormats(
            CLContext context,
            MemoryFlags flags,
            MemoryObjectType imageType,
            out CLImageFormat[] imageFormats)
        {
            var resultCode = GetSupportedImageFormats(context, flags, imageType, 0, null, out uint sizeReturned);
            imageFormats = new CLImageFormat[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetSupportedImageFormats(context, flags, imageType, sizeReturned, imageFormats, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] CLImage image,
            [In] MemoryObjectInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
            CLImage image,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(image, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetMemObjectInfo(image, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetImageInfo")]
        public static extern CLResultCode GetImageInfo(
            [In] CLImage image,
            [In] ImageInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetImageInfo(
            CLImage image,
            ImageInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetImageInfo(image, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetImageInfo(image, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
        public static extern CLResultCode SetMemoryObjectDestructorCallback(
            [In] CLImage image,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode SetMemoryObjectDestructorCallback(
            CLImage image,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetMemoryObjectDestructorCallback(image, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueReadImage")]
        public static extern CLResultCode EnqueueReadImage(
            [In] CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] bool blockingRead,
            [In] nuint[] origin,
            [In] nuint[] region,
            [In] nuint rowPitch,
            [In] nuint slicePitch,
            [In] IntPtr hostBuffer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueReadImage<T>(
           CLCommandQueue commandQueue,
            CLImage image,
            bool blockingRead,
            nuint[] origin,
            nuint[] region,
            nuint rowPitch,
            nuint slicePitch,
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
           CLCommandQueue commandQueue,
            CLImage image,
            bool blockingRead,
            nuint[] origin,
            nuint[] region,
            nuint rowPitch,
            nuint slicePitch,
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
            [In] CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] bool blockingWrite,
            [In] nuint[] origin,
            [In] nuint[] region,
            [In] nuint inputRowPitch,
            [In] nuint inputSlicePitch,
            [In] IntPtr pointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode EnqueueWriteImage<T>(
           CLCommandQueue commandQueue,
            CLImage image,
            bool blockingWrite,
            nuint[] origin,
            nuint[] region,
            nuint inputRowPitch,
            nuint inputSlicePitch,
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
            CLCommandQueue commandQueue,
            CLImage image,
            bool blockingWrite,
            nuint[] origin,
            nuint[] region,
            nuint inputRowPitch,
            nuint inputSlicePitch,
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
            [In] CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] IntPtr fillColor,
            [In] nuint[] origin,
            [In] nuint[] region,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static unsafe CLResultCode EnqueueFillImage<T>(
            CLCommandQueue commandQueue,
            CLImage image,
            T[] fillColor,
            nuint[] origin,
            nuint[] region,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = fillColor)
            {
                return EnqueueFillImage(commandQueue, image, (IntPtr)a, origin, region,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static unsafe CLResultCode EnqueueFillImage<T>(
            CLCommandQueue commandQueue,
            CLImage image,
            Span<T> fillColor,
            nuint[] origin,
            nuint[] region,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* a = fillColor)
            {
                return EnqueueFillImage(commandQueue, image, (IntPtr)a, origin, region,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueCopyImage")]
        public static extern CLResultCode EnqueueCopyImage(
            [In] CLCommandQueue commandQueue,
            [In] CLImage srcImage,
            [In] CLImage dstImage,
            [In] nuint[] srcOrigin,
            [In] nuint[] dstOrigin,
            [In] nuint[] region,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyImage(
            CLCommandQueue commandQueue,
            CLImage srcImage,
            CLImage dstImage,
            nuint[] srcOrigin,
            nuint[] dstOrigin,
            nuint[] region,
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
            [In] CLCommandQueue commandQueue,
            [In] CLImage srcImage,
            [In] CLBuffer dstBuffer,
            [In] nuint[] srcOrigin,
            [In] nuint[] region,
            [In] nuint dstOffset,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyImageToBuffer(
            CLCommandQueue commandQueue,
            CLImage srcImage,
            CLBuffer dstBuffer,
            nuint[] srcOrigin,
            nuint[] region,
            nuint dstOffset,
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
            [In] CLCommandQueue commandQueue,
            [In] CLBuffer srcBuffer,
            [In] CLImage dstImage,
            [In] nuint srcOffset,
            [In] nuint[] dstOrigin,
            [In] nuint[] region,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueCopyBufferToImage(
           CLCommandQueue commandQueue,
            CLBuffer srcBuffer,
            CLImage dstImage,
            nuint srcOffset,
            nuint[] dstOrigin,
            nuint[] region,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueCopyBufferToImage(commandQueue, srcBuffer, dstImage, srcOffset, dstOrigin, region,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMapImage")]
        public static extern IntPtr EnqueueMapImage(
            [In] CLCommandQueue commandQueue,
            [In] CLImage image,
            [In] bool blockingMap,
            [In] MapFlags flags,
            [In] nuint[] origin,
            [In] nuint[] region,
            [In] nuint rowPitch,
            [In] nuint slicePitch,
            [In] nuint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static IntPtr EnqueueMapImage(
           CLCommandQueue commandQueue,
            CLImage image,
            bool blockingMap,
            MapFlags flags,
            nuint[] origin,
            nuint[] region,
            nuint rowPitch,
            nuint slicePitch,
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
            [In] CLCommandQueue commandQueue,
            [In] CLImage memoryObject,
            [In] IntPtr mapperPtr,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueUnmapMemoryObject(
            CLCommandQueue commandQueue,
            CLImage memoryObject,
            IntPtr mapperPtr,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueUnmapMemoryObject(commandQueue, memoryObject, mapperPtr,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        #endregion

        #region Pipes API

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreatePipe")]
        public static extern CLPipe CreatePipe(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] uint pipePacketSize,
            [In] uint pipeMaxPackets,
            [In] IntPtr[] properties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLPipe CreatePipe(
            CLContext context,
            MemoryFlags flags,
            uint pipePacketSize,
            uint pipeMaxPackets,
            CLPipeProperties properties,
            out CLResultCode resultCode)
        {
            return CreatePipe(context, flags, pipePacketSize, pipeMaxPackets, properties.CreatePropertyArray(), out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] CLPipe pipe);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] CLPipe pipe);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] CLPipe pipe,
            [In] MemoryObjectInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
            CLPipe pipe,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(pipe, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetMemObjectInfo(pipe, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetPipeInfo")]
        public static extern CLResultCode GetPipeInfo(
            [In] CLPipe pipe,
            [In] PipeInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode GetPipeInfo(
            CLPipe pipe,
            PipeInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetPipeInfo(pipe, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetPipeInfo(pipe, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetMemObjectDestructorCallback")]
        public static extern CLResultCode SetMemoryObjectDestructorCallback(
            [In] CLPipe pipe,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode SetMemoryObjectDestructorCallback(
           CLPipe pipe,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetMemoryObjectDestructorCallback(pipe, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        #endregion

        #region Memory Objects API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainMemObject")]
        public static extern CLResultCode RetainMemoryObject([In] IntPtr memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseMemObject")]
        public static extern CLResultCode ReleaseMemoryObject([In] IntPtr memoryObject);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetMemObjectInfo")]
        public static extern CLResultCode GetMemObjectInfo(
            [In] IntPtr memoryObject,
            [In] MemoryObjectInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetMemObjectInfo(
            IntPtr memoryObject,
            MemoryObjectInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetMemObjectInfo(memoryObject, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetMemObjectInfo(memoryObject, paramName, sizeReturned, paramValue, out _);
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
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueUnmapMemObject")]
        public static extern CLResultCode EnqueueUnmapMemoryObject(
            [In] CLCommandQueue commandQueue,
            [In] IntPtr memoryObject,
            [In] IntPtr mapperPtr,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueUnmapMemoryObject(
            CLCommandQueue commandQueue,
            IntPtr memoryObject,
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
            [In] CLCommandQueue commandQueue,
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
            CLCommandQueue commandQueue,
            IntPtr[] memoryObjects,
            MemoryMigrationFlags flags,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueMigrateMemoryObjects(commandQueue, (uint)(memoryObjects?.Length ?? 0), memoryObjects, flags,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueMarkerWithWaitList")]
        public static extern CLResultCode EnqueueMarkerWithWaitList(
            [In] CLCommandQueue commandQueue,
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
           CLCommandQueue commandQueue,
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
            [In] CLCommandQueue commandQueue,
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
            CLCommandQueue commandQueue,
            IntPtr[] memoryObjects,
            IntPtr argumentsMemoryLocation,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueBarrierWithWaitList(commandQueue, (uint)(memoryObjects?.Length ?? 0), memoryObjects, argumentsMemoryLocation,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        #endregion

        #region Shared Virtual Memory API

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSVMAlloc")]
        public static extern SvmBuffer SvmAlloc(
            [In] CLContext context,
            [In] SvmMemoryFlags flags,
            [In] nuint size,
            [In] uint alignment);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSVMFree")]
        public static extern void SvmFree(
            [In] CLContext context,
            [In] SvmBuffer svmPointer);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMFree")]
        public static extern CLResultCode EnqueueSvmFree(
            [In] CLCommandQueue commandQueue,
            [In] uint numberOfSvmPointers,
            [In] SvmBuffer[] svmPointers,
            [In] IntPtr svmFreePointersCallback,
            [In] IntPtr userData,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSvmFree(
            CLCommandQueue commandQueue,
            SvmBuffer[] svmPointers,
            ClEventCallback callback,
            IntPtr userData,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmFree(commandQueue, (uint)(svmPointers?.Length ?? 0), svmPointers, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMemcpy")]
        public static extern CLResultCode EnqueueSvmMemoryCopy(
            [In] CLCommandQueue commandQueue,
            [In] bool blockingCopy,
            [In] SvmBuffer dstPointer,
            [In] SvmBuffer srcPointer,
            [In] nuint size,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSvmMemoryCopy(
           CLCommandQueue commandQueue,
            bool blockingCopy,
            SvmBuffer dstPointer,
            SvmBuffer srcPointer,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmMemoryCopy(commandQueue, blockingCopy, dstPointer, srcPointer, size,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMemFill")]
        public static extern CLResultCode EnqueueSvmMemoryFill(
            [In] CLCommandQueue commandQueue,
            [In] SvmBuffer svmPointer,
            [In] IntPtr pattern,
            [In] nuint patternSize,
            [In] nuint size,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static unsafe CLResultCode EnqueueSvmMemoryFill<T>(
            CLCommandQueue commandQueue,
            SvmBuffer svmPointer,
            T[] pattern,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* p = pattern)
            {
                return EnqueueSvmMemoryFill(commandQueue, svmPointer, (IntPtr)p, (nuint)(pattern.Length * sizeof(T)),
                    size, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static unsafe CLResultCode EnqueueSvmMemoryFill<T>(
            CLCommandQueue commandQueue,
            SvmBuffer svmPointer,
            Span<T> pattern,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event)
            where T : unmanaged
        {
            fixed (T* p = pattern)
            {
                return EnqueueSvmMemoryFill(commandQueue, svmPointer, (IntPtr)p, (nuint)(pattern.Length * sizeof(T)),
                    size, (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMap")]
        public static extern CLResultCode EnqueueSvmMap(
            [In] CLCommandQueue commandQueue,
            [In] bool blockingMap,
            [In] MapFlags mapFlag,
            [In] SvmBuffer svmPointer,
            [In] nuint size,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSvmMap(
            CLCommandQueue commandQueue,
            bool blockingMap,
            MapFlags mapFlag,
            SvmBuffer svmPointer,
            nuint size,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmMap(commandQueue, blockingMap, mapFlag, svmPointer, size,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMUnmap")]
        public static extern CLResultCode EnqueueSvmUnmap(
            [In] CLCommandQueue commandQueue,
            [In] SvmBuffer svmPointer,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLResultCode EnqueueSvmUnmap(
            CLCommandQueue commandQueue,
            SvmBuffer svmPointer,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmUnmap(commandQueue, svmPointer,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueSVMMigrateMem")]
        public static extern CLResultCode EnqueueSvmMigrateMemory(
            [In] CLCommandQueue commandQueue,
            [In] uint numberOfSvmPointers,
            [In] SvmBuffer[] svmPointers,
            [In] nuint[] sizes,
            [In] MemoryMigrationFlags memoryMigrationFlags,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        public static CLResultCode EnqueueSvmMigrateMemory(
            CLCommandQueue commandQueue,
            SvmBuffer[] svmPointers,
            nuint[] sizes,
            MemoryMigrationFlags memoryMigrationFlags,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueSvmMigrateMemory(commandQueue, (uint)(svmPointers?.Length ?? 0), svmPointers, sizes, memoryMigrationFlags,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
        }

        #endregion

        #region Sampler API

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSamplerWithProperties")]
        public static extern CLSampler CreateSamplerWithProperties(
            [In] CLContext context,
            [In] ulong[] samplerProperties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        public static CLSampler CreateSamplerWithProperties(
            CLContext context,
            CLSamplerProperties properties,
            out CLResultCode resultCode)
        {
            return CreateSamplerWithProperties(context, properties.CreatePropertyArray(), out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainSampler")]
        public static extern CLResultCode RetainSampler([In] CLSampler sampler);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseSampler")]
        public static extern CLResultCode ReleaseSampler([In] CLSampler sampler);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetSamplerInfo")]
        public static extern CLResultCode GetSamplerInfo(
            [In] CLSampler sampler,
            [In] SamplerInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetSamplerInfo(
            CLSampler sampler,
            SamplerInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetSamplerInfo(sampler, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
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
            [In] CLContext context,
            [In] uint count,
            [In] string[] strings,
            [In] nuint[] lengths,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLProgram CreateProgramWithSource(
            CLContext context,
            string source,
            out CLResultCode resultCode)
        {
            return CreateProgramWithSource(context, 1, new[] { source }, new[] { (nuint)source.Length }, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLProgram CreateProgramWithSource(
            CLContext context,
            string[] strings,
            out CLResultCode resultCode)
        {
            var sourceLengths = new nuint[strings.Length];
            for (int i = 0; i < strings.Length; i++)
                sourceLengths[i] = (nuint)strings[i].Length;
            return CreateProgramWithSource(context, (uint)strings.Length, strings, sourceLengths, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithBinary")]
        public static extern CLProgram CreateProgramWithBinary(
            [In] CLContext context,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] nuint[] lengths,
            [In] IntPtr[] binaries,
            [Out] out CLResultCode[] binaryStatus,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLProgram CreateProgramWithBinary(
            CLContext context,
            CLDevice[] deviceList,
            nuint[] lengths,
            IntPtr[] binaries,
            out CLResultCode[] binaryStatus,
            out CLResultCode resultCode)
        {
            return CreateProgramWithBinary(context, (uint)deviceList.Length, deviceList, lengths, binaries, out binaryStatus, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLProgram CreateProgramWithBinary(
            CLContext context,
            CLDevice[] deviceList,
            byte[] binaries,
            out CLResultCode[] binaryStatus,
            out CLResultCode resultCode)
        {
            fixed (byte* p = binaries)
            {
                return CreateProgramWithBinary(context, (uint)deviceList.Length, deviceList, new[] { (nuint)binaries.Length }, new[] { (IntPtr)p }, out binaryStatus, out resultCode);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLProgram CreateProgramWithBinary(
            CLContext context,
            CLDevice[] deviceList,
            byte[][] binaries,
            out CLResultCode[] binaryStatus,
            out CLResultCode resultCode)
        {
            var lengths = new nuint[binaries.Length];
            var binaryPointers = new IntPtr[binaries.Length];
            for (int i = 0; i < binaries.Length; i++)
            {
                fixed (byte* p = binaries[i])
                {
                    lengths[i] = (nuint)binaries[i].Length;
                    binaryPointers[i] = (IntPtr)p;
                }
            }

            return CreateProgramWithBinary(context, (uint)deviceList.Length, deviceList, lengths, binaryPointers, out binaryStatus, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithBuiltInKernels")]
        public static extern CLProgram CreateProgramWithBuiltInKernels(
            [In] CLContext context,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] string kernelNames,
            [Out] out CLResultCode resultCode);


        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLProgram CreateProgramWithBuiltInKernels(
            CLContext context,
            CLDevice[] deviceList,
            string kernelNames,
            out CLResultCode resultCode)
        {
            return CreateProgramWithBuiltInKernels(context, (uint)deviceList.Length, deviceList, kernelNames, out resultCode);
        }


        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLProgram CreateProgramWithBuiltInKernels(
            CLContext context,
            CLDevice[] deviceList,
            string[] kernelNames,
            out CLResultCode resultCode)
        {
            return CreateProgramWithBuiltInKernels(context, (uint)deviceList.Length, deviceList, string.Join(";", kernelNames), out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateProgramWithIL")]
        public static extern CLProgram CreateProgramWithIL(
            [In] CLContext context,
            [In] IntPtr il,
            [In] nuint length,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainProgram")]
        public static extern CLResultCode RetainProgram([In] CLProgram program);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseProgram")]
        public static extern CLResultCode ReleaseProgram([In] CLProgram program);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clBuildProgram")]
        public static extern CLResultCode BuildProgram(
            [In] CLProgram program,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] string options,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode BuildProgram(
            CLProgram program,
            CLDevice[] deviceList,
            string options,
            ClEventCallback callback,
            IntPtr userData)
        {
            return BuildProgram(program, (uint)(deviceList?.Length ?? 0), deviceList, options,
                callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode BuildProgram(CLProgram program)
        {
            return BuildProgram(program, null, null, null, IntPtr.Zero);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCompileProgram")]
        public static extern CLResultCode CompileProgram(
            [In] CLProgram program,
            [In] uint numberOfDevices,
            [In] CLDevice[] deviceList,
            [In] string options,
            [In] uint numberOfInputDevices,
            [In] CLProgram[] inputHeaders,
            [In] string[] headerIncludeNames,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode CompileProgram(
           CLProgram program,
            CLDevice[] deviceList,
            string options,
            CLProgram[] inputHeaders,
            string[] headerIncludeNames,
            ClEventCallback callback,
            IntPtr userData)
        {
            return CompileProgram(program, (uint)(deviceList?.Length ?? 0), deviceList, options, (uint)(inputHeaders?.Length ?? 0), inputHeaders,
               headerIncludeNames, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clLinkProgram")]
        public static extern CLProgram LinkProgram(
            [In] CLContext context,
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
            CLContext context,
            CLDevice[] deviceList,
            string options,
            CLProgram[] inputPrograms,
            ClEventCallback callback,
            IntPtr userData,
            out CLResultCode resultCode)
        {
            return LinkProgram(context, (uint)(deviceList?.Length ?? 0), deviceList, options, (uint)(inputPrograms?.Length ?? 0), inputPrograms,
               callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData, out resultCode);
        }

        /// <summary>
        /// Introduced in OpenCL 2.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetProgramSpecializationConstant")]
        public static extern CLResultCode SetProgramSpecializationConstant(
            [In] CLProgram program,
            [In] uint specId,
            [In] nuint specSize,
            [In] IntPtr specValue);

        /// <summary>
        /// Introduced in OpenCL 2.2
        /// </summary>
        public static unsafe CLResultCode SetProgramSpecializationConstant<T>(
            CLProgram program,
            uint specId,
            in T specValue)
            where T : unmanaged
        {
            fixed (T* arg = &specValue)
            {
                var specSize = (nuint)sizeof(T);
                if (specValue is bool)
                    specSize = 1;
                return SetProgramSpecializationConstant(program, specId, specSize, (IntPtr)arg);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clUnloadPlatformCompiler")]
        public static extern CLResultCode UnloadPlatformCompiler([In] CLPlatform platform);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetProgramInfo")]
        public static extern CLResultCode GetProgramInfo(
            [In] CLProgram program,
            [In] ProgramInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetProgramInfo(
           CLProgram program,
            ProgramInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetProgramInfo(program, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetProgramInfo(program, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetProgramBuildInfo")]
        public static extern CLResultCode GetProgramBuildInfo(
            [In] CLProgram program,
            [In] CLDevice device,
            [In] ProgramBuildInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetProgramBuildInfo(
            CLProgram program,
            CLDevice device,
            ProgramBuildInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetProgramBuildInfo(program, device, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
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
            [In] CLProgram program,
            [In] string name,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateKernelsInProgram")]
        public static extern CLResultCode CreateKernelsInProgram(
            [In] CLProgram program,
            [In] uint numberOfKernels,
            [In] CLKernel[] kernels,
            [Out] out uint numberOfKernelsReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode CreateKernelsInProgram(
            CLProgram program,
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
            [In] CLKernel sourceKernel,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainKernel")]
        public static extern CLResultCode RetainKernel([In] CLKernel kernel);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseKernel")]
        public static extern CLResultCode ReleaseKernel([In] CLKernel kernel);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelArg")]
        public static extern CLResultCode SetKernelArg(
            [In] CLKernel kernel,
            [In] uint argumentIndex,
            [In] nuint argumentSize,
            [In] IntPtr argumentValuePointer);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode SetKernelArg<T>(
            CLKernel kernel,
            uint argumentIndex,
            in T argument) where T : unmanaged
        {
            fixed (T* arg = &argument)
            {
                return SetKernelArg(kernel, argumentIndex, (nuint)sizeof(T), (IntPtr)arg);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode SetKernelArg<T>(
            CLKernel kernel,
            uint argumentIndex,
            T[] array) where T : unmanaged
        {
            fixed (T* b = array)
            {
                return SetKernelArg(kernel, argumentIndex, (nuint)(sizeof(T) * array.Length), (IntPtr)b);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static unsafe CLResultCode SetKernelArg<T>(
            CLKernel kernel,
            uint argumentIndex,
            Span<T> array) where T : unmanaged
        {
            fixed (T* b = array)
            {
                return SetKernelArg(kernel, argumentIndex, (nuint)(sizeof(T) * array.Length), (IntPtr)b);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelArgSVMPointer")]
        public static extern CLResultCode SetKernelArgSVMPointer(
            [In] CLKernel kernel,
            [In] uint argumentIndex,
            [In] IntPtr argumentValuePointer);

        /// <summary>
        /// Introduced in OpenCL 2.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetKernelExecInfo")]
        public static extern CLResultCode SetKernelExecInfo(
            [In] CLKernel kernel,
            [In] KernelExecInfo paramName,
            [In] uint paramValueSize,
            [In] IntPtr paramValue);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelInfo")]
        public static extern CLResultCode GetKernelInfo(
            [In] CLKernel kernel,
            [In] KernelInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetKernelInfo(
            CLKernel kernel,
            KernelInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetKernelInfo(kernel, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetKernelInfo(kernel, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelArgInfo")]
        public static extern CLResultCode GetKernelArgInfo(
            [In] CLKernel kernel,
            [In] uint argumentIndex,
            [In] KernelArgInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.2
        /// </summary>
        public static CLResultCode GetKernelArgInfo(
           CLKernel kernel,
            uint argumentIndex,
            KernelArgInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetKernelArgInfo(kernel, argumentIndex, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetKernelArgInfo(kernel, argumentIndex, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelWorkGroupInfo")]
        public static extern CLResultCode GetKernelWorkGroupInfo(
            [In] CLKernel kernel,
            [In] CLDevice device,
            [In] KernelWorkGroupInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetKernelWorkGroupInfo(
            CLKernel kernel,
            CLDevice device,
            KernelWorkGroupInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetKernelWorkGroupInfo(kernel, device, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetKernelWorkGroupInfo(kernel, device, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetKernelSubGroupInfo")]
        public static unsafe extern CLResultCode GetKernelSubGroupInfo(
            [In] CLKernel kernel,
            [In] CLDevice device,
            [In] KernelSubGroupInfo paramName,
            [In] nuint inputValueSize,
            [In] void* inputValue,
            [In] nuint paramValueSize,
            [Out] nuint[] paramValue,
            [Out] out nuint paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>s
        public static unsafe CLResultCode GetKernelSubGroupInfo(
            CLKernel kernel,
            CLDevice device,
            KernelSubGroupInfo paramName,
            nuint val,
            out nuint[] paramValue)
        {
            var resultCode = GetKernelSubGroupInfo(kernel, device, paramName, (nuint)sizeof(nuint), &val, 0, null, out nuint sizeReturned);
            paramValue = new nuint[sizeReturned / (nuint)sizeof(nuint)];
            if (sizeReturned == 0)
                return resultCode;
            return GetKernelSubGroupInfo(kernel, device, paramName, (nuint)(sizeof(nuint)), &val, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>s
        public static unsafe CLResultCode GetKernelSubGroupInfo(
            CLKernel kernel,
            CLDevice device,
            KernelSubGroupInfo paramName,
            nuint[] array,
            out nuint[] paramValue)
        {
            fixed (void* b = array)
            {
                var resultCode = GetKernelSubGroupInfo(kernel, device, paramName, (nuint)(array.Length * sizeof(nuint)), (void*)b, 0, null, out nuint sizeReturned);
                paramValue = new nuint[sizeReturned / (nuint)sizeof(nuint)];
                if (sizeReturned == 0)
                    return resultCode;
                return GetKernelSubGroupInfo(kernel, device, paramName, (nuint)(array.Length * sizeof(nuint)), (void*)b, sizeReturned, paramValue, out _);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 2.1
        /// </summary>
        public static unsafe CLResultCode GetKernelSubGroupInfo(
            CLKernel kernel,
            CLDevice device,
            KernelSubGroupInfo paramName,
            Span<nuint> span,
            out nuint[] paramValue)
        {
            fixed (UIntPtr* b = span)
            {
                var resultCode = GetKernelSubGroupInfo(kernel, device, paramName, (uint)(span.Length * sizeof(UIntPtr)), (void*)b, 0, null, out nuint sizeReturned);
                paramValue = new UIntPtr[sizeReturned / (nuint)sizeof(UIntPtr)];
                if (sizeReturned == 0)
                    return resultCode;
                return GetKernelSubGroupInfo(kernel, device, paramName, (uint)(span.Length * sizeof(UIntPtr)), (void*)b, sizeReturned, paramValue, out _);
            }
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clEnqueueNDRangeKernel")]
        public static extern CLResultCode EnqueueNDRangeKernel(
            [In] CLCommandQueue commandQueue,
            [In] CLKernel kernel,
            [In] uint workDimension,
            [In] nuint[] globalWorkOffset,
            [In] nuint[] globalWorkSize,
            [In] nuint[] localWorkSize,
            [In] uint numberOfEventsInWaitList,
            [In] CLEvent[] eventWaitList,
            [Out] out CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode EnqueueNDRangeKernel(
            CLCommandQueue commandQueue,
            CLKernel kernel,
            uint workDimension,
            nuint[] globalWorkOffset,
            nuint[] globalWorkSize,
            nuint[] localWorkSize,
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
            [In] CLCommandQueue commandQueue,
            [In] IntPtr userFunction,
            [In] IntPtr[] arguments,
            [In] nuint argumentSize,
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
            CLCommandQueue commandQueue,
            IntPtr userFunction,
            IntPtr[] arguments,
            nuint argumentSize,
            IntPtr[] memoryObjects,
            IntPtr argumentsMemoryLocation,
            CLEvent[] eventWaitList,
            out CLEvent @event)
        {
            return EnqueueNativeKernel(commandQueue, userFunction, arguments, argumentSize, (uint)(memoryObjects?.Length ?? 0), memoryObjects, argumentsMemoryLocation,
                (uint)(eventWaitList?.Length ?? 0), eventWaitList, out @event);
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
        public static CLResultCode WaitForEvents(CLEvent[] eventList)
        {
            return WaitForEvents((uint)eventList.Length, eventList);
        }

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetEventInfo")]
        public static extern CLResultCode GetEventInfo(
            [In] CLEvent @event,
            [In] EventInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetEventInfo(
            CLEvent @event,
            EventInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetEventInfo(@event, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetEventInfo(@event, paramName, sizeReturned, paramValue, out _);
        }

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateUserEvent")]
        public static extern CLEvent CreateUserEvent(
            [In] CLContext context,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clRetainEvent")]
        public static extern CLResultCode RetainEvent([In] CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clReleaseEvent")]
        public static extern CLResultCode ReleaseEvent([In] CLEvent @event);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetUserEventStatus")]
        public static extern CLResultCode SetUserEventStatus(
            [In] CLEvent @event,
            [In] CommandExecutionStatus executionStatus);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetEventCallback")]
        public static extern CLResultCode SetEventCallback(
            [In] CLEvent eventHandle,
            [In] CommandExecutionStatus commandExecCallbackType,
            [In] IntPtr notifyCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 1.1
        /// </summary>
        public static CLResultCode SetEventCallback(
            CLEvent eventHandle,
            CommandExecutionStatus callbackType,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetEventCallback(eventHandle, callbackType,
                callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        #endregion

        #region Profiling API

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clGetEventProfilingInfo")]
        public static extern CLResultCode GetEventProfilingInfo(
            [In] CLEvent @event,
            [In] ProfilingInfo paramName,
            [In] nuint paramValueSize,
            [Out] byte[] paramValue,
            [Out] out nuint paramValueSizeReturned);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        public static CLResultCode GetEventProfilingInfo(
            CLEvent @event,
            ProfilingInfo paramName,
            out byte[] paramValue)
        {
            var resultCode = GetEventProfilingInfo(@event, paramName, 0, null, out nuint sizeReturned);
            paramValue = new byte[sizeReturned];
            if (sizeReturned == 0)
                return resultCode;
            return GetEventProfilingInfo(@event, paramName, sizeReturned, paramValue, out _);
        }

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
            [In] ref CLImageFormat imageFormat,
            [In] nuint imageWidth,
            [In] nuint imageHeight,
            [In] nuint imageRowPitch,
            [In] IntPtr hostPtr,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated method, use CreateImage instead")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateImage3D")]
        public static extern CLImage CreateImage3D(
            [In] CLContext context,
            [In] MemoryFlags flags,
            [In] ref CLImageFormat imageFormat,
            [In] nuint imageWidth,
            [In] nuint imageHeight,
            [In] nuint imageDepth,
            [In] nuint imageRowPitch,
            [In] nuint imageSlicePitch,
            [In] IntPtr hostPtr,
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
            [In] CommandQueueProperties properties,
            [Out] out CLResultCode resultCode);

        /// <summary>
        /// Introduced in OpenCL 1.0
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clCreateSampler")]
        public static extern CLSampler CreateSampler(
            [In] CLContext context,
            [In] bool normalizedCoordinates,
            [In] SamplerAddressingMode addressingMode,
            [In] SamplerFilterMode filterMode,
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

        /// <summary>
        /// Introduced in OpenCL 2.2
        /// </summary>
        [Obsolete("Deprecated in OpenCL 3.0")]
        [DllImport(LibName, CallingConvention = CallingConvention, EntryPoint = "clSetProgramReleaseCallback")]
        public static extern CLResultCode SetProgramReleaseCallback(
            [In] CLProgram program,
            [In] IntPtr notificationCallback,
            [In] IntPtr userData);

        /// <summary>
        /// Introduced in OpenCL 2.2
        /// </summary>
        [Obsolete("Deprecated in OpenCL 3.0")]
        public static CLResultCode SetProgramReleaseCallback(
           CLProgram program,
            ClEventCallback callback,
            IntPtr userData)
        {
            return SetProgramReleaseCallback(program, callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback), userData);
        }

        #endregion
    }
}
