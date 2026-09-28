// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using OpenTK.Compute2;

namespace OpenTK.Compute2.OpenCL
{
    /// <summary>A collection of all function pointers to all OpenCL entry points.</summary>
    public static unsafe partial class CLPointers
    {
        /// <summary><b>[entry point: <c>clBuildProgram</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int> _clBuildProgram_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clBuildProgram_Lazy(IntPtr program, uint num_devices, IntPtr* device_list, byte* options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data)
        {
            if (_clBuildProgram_fnptr == null)
                _clBuildProgram_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int>)CLLoader.BindingsContext.GetProcAddress("clBuildProgram");
            return _clBuildProgram_fnptr(program, num_devices, device_list, options, pfn_notify, user_data);
        }
        
        /// <summary><b>[entry point: <c>clCancelCommandsIMG</c>]</b></summary>
        public static delegate* unmanaged<IntPtr*, nuint, int> _clCancelCommandsIMG_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCancelCommandsIMG_Lazy(IntPtr* event_list, nuint num_events_in_list)
        {
            if (_clCancelCommandsIMG_fnptr == null)
                _clCancelCommandsIMG_fnptr = (delegate* unmanaged<IntPtr*, nuint, int>)CLLoader.BindingsContext.GetProcAddress("clCancelCommandsIMG");
            return _clCancelCommandsIMG_fnptr(event_list, num_events_in_list);
        }
        
        /// <summary><b>[entry point: <c>clCloneKernel</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, IntPtr> _clCloneKernel_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCloneKernel_Lazy(IntPtr source_kernel, int* errcode_ret)
        {
            if (_clCloneKernel_fnptr == null)
                _clCloneKernel_fnptr = (delegate* unmanaged<IntPtr, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCloneKernel");
            return _clCloneKernel_fnptr(source_kernel, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCommandBarrierWithWaitListKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, uint, uint*, uint*, IntPtr*, int> _clCommandBarrierWithWaitListKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandBarrierWithWaitListKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandBarrierWithWaitListKHR_fnptr == null)
                _clCommandBarrierWithWaitListKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandBarrierWithWaitListKHR");
            return _clCommandBarrierWithWaitListKHR_fnptr(command_buffer, command_queue, properties, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandCopyBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*, int> _clCommandCopyBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandCopyBufferKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandCopyBufferKHR_fnptr == null)
                _clCommandCopyBufferKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandCopyBufferKHR");
            return _clCommandCopyBufferKHR_fnptr(command_buffer, command_queue, properties, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandCopyBufferRectKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*, int> _clCommandCopyBufferRectKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandCopyBufferRectKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_buffer, IntPtr dst_buffer, nuint* src_origin, nuint* dst_origin, nuint* region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandCopyBufferRectKHR_fnptr == null)
                _clCommandCopyBufferRectKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandCopyBufferRectKHR");
            return _clCommandCopyBufferRectKHR_fnptr(command_buffer, command_queue, properties, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandCopyBufferToImageKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int> _clCommandCopyBufferToImageKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandCopyBufferToImageKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint* dst_origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandCopyBufferToImageKHR_fnptr == null)
                _clCommandCopyBufferToImageKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandCopyBufferToImageKHR");
            return _clCommandCopyBufferToImageKHR_fnptr(command_buffer, command_queue, properties, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandCopyImageKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int> _clCommandCopyImageKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandCopyImageKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_image, IntPtr dst_image, nuint* src_origin, nuint* dst_origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandCopyImageKHR_fnptr == null)
                _clCommandCopyImageKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandCopyImageKHR");
            return _clCommandCopyImageKHR_fnptr(command_buffer, command_queue, properties, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandCopyImageToBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, uint*, uint*, IntPtr*, int> _clCommandCopyImageToBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandCopyImageToBufferKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_image, IntPtr dst_buffer, nuint* src_origin, nuint* region, nuint dst_offset, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandCopyImageToBufferKHR_fnptr == null)
                _clCommandCopyImageToBufferKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandCopyImageToBufferKHR");
            return _clCommandCopyImageToBufferKHR_fnptr(command_buffer, command_queue, properties, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandFillBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*, int> _clCommandFillBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandFillBufferKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr buffer, void* pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandFillBufferKHR_fnptr == null)
                _clCommandFillBufferKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandFillBufferKHR");
            return _clCommandFillBufferKHR_fnptr(command_buffer, command_queue, properties, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandFillImageKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int> _clCommandFillImageKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandFillImageKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr image, void* fill_color, nuint* origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandFillImageKHR_fnptr == null)
                _clCommandFillImageKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandFillImageKHR");
            return _clCommandFillImageKHR_fnptr(command_buffer, command_queue, properties, image, fill_color, origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandNDRangeKernelKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, uint, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int> _clCommandNDRangeKernelKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandNDRangeKernelKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* local_work_size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandNDRangeKernelKHR_fnptr == null)
                _clCommandNDRangeKernelKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, IntPtr, uint, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandNDRangeKernelKHR");
            return _clCommandNDRangeKernelKHR_fnptr(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandSVMMemcpyKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*, int> _clCommandSVMMemcpyKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandSVMMemcpyKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, void* dst_ptr, void* src_ptr, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandSVMMemcpyKHR_fnptr == null)
                _clCommandSVMMemcpyKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandSVMMemcpyKHR");
            return _clCommandSVMMemcpyKHR_fnptr(command_buffer, command_queue, properties, dst_ptr, src_ptr, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCommandSVMMemFillKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*, int> _clCommandSVMMemFillKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCommandSVMMemFillKHR_Lazy(IntPtr command_buffer, IntPtr command_queue, ulong* properties, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle)
        {
            if (_clCommandSVMMemFillKHR_fnptr == null)
                _clCommandSVMMemFillKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clCommandSVMMemFillKHR");
            return _clCommandSVMMemFillKHR_fnptr(command_buffer, command_queue, properties, svm_ptr, pattern, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }
        
        /// <summary><b>[entry point: <c>clCompileProgram</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int> _clCompileProgram_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCompileProgram_Lazy(IntPtr program, uint num_devices, IntPtr* device_list, byte* options, uint num_input_headers, IntPtr* input_headers, byte** header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data)
        {
            if (_clCompileProgram_fnptr == null)
                _clCompileProgram_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int>)CLLoader.BindingsContext.GetProcAddress("clCompileProgram");
            return _clCompileProgram_fnptr(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        }
        
        /// <summary><b>[entry point: <c>clCreateAcceleratorINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, int*, IntPtr> _clCreateAcceleratorINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateAcceleratorINTEL_Lazy(IntPtr context, uint accelerator_type, nuint descriptor_size, void* descriptor, int* errcode_ret)
        {
            if (_clCreateAcceleratorINTEL_fnptr == null)
                _clCreateAcceleratorINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateAcceleratorINTEL");
            return _clCreateAcceleratorINTEL_fnptr(context, accelerator_type, descriptor_size, descriptor, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, nuint, void*, int*, IntPtr> _clCreateBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateBuffer_Lazy(IntPtr context, ulong flags, nuint size, void* host_ptr, int* errcode_ret)
        {
            if (_clCreateBuffer_fnptr == null)
                _clCreateBuffer_fnptr = (delegate* unmanaged<IntPtr, ulong, nuint, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateBuffer");
            return _clCreateBuffer_fnptr(context, flags, size, host_ptr, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateBufferWithProperties</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, ulong, nuint, void*, int*, IntPtr> _clCreateBufferWithProperties_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateBufferWithProperties_Lazy(IntPtr context, ulong* properties, ulong flags, nuint size, void* host_ptr, int* errcode_ret)
        {
            if (_clCreateBufferWithProperties_fnptr == null)
                _clCreateBufferWithProperties_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong, nuint, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateBufferWithProperties");
            return _clCreateBufferWithProperties_fnptr(context, properties, flags, size, host_ptr, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateBufferWithPropertiesINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, ulong, nuint, void*, int*, IntPtr> _clCreateBufferWithPropertiesINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateBufferWithPropertiesINTEL_Lazy(IntPtr context, ulong* properties, ulong flags, nuint size, void* host_ptr, int* errcode_ret)
        {
            if (_clCreateBufferWithPropertiesINTEL_fnptr == null)
                _clCreateBufferWithPropertiesINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong, nuint, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateBufferWithPropertiesINTEL");
            return _clCreateBufferWithPropertiesINTEL_fnptr(context, properties, flags, size, host_ptr, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateCommandBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr*, ulong*, int*, IntPtr> _clCreateCommandBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateCommandBufferKHR_Lazy(uint num_queues, IntPtr* queues, ulong* properties, int* errcode_ret)
        {
            if (_clCreateCommandBufferKHR_fnptr == null)
                _clCreateCommandBufferKHR_fnptr = (delegate* unmanaged<uint, IntPtr*, ulong*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateCommandBufferKHR");
            return _clCreateCommandBufferKHR_fnptr(num_queues, queues, properties, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateCommandQueue</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong, int*, IntPtr> _clCreateCommandQueue_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateCommandQueue_Lazy(IntPtr context, IntPtr device, ulong properties, int* errcode_ret)
        {
            if (_clCreateCommandQueue_fnptr == null)
                _clCreateCommandQueue_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateCommandQueue");
            return _clCreateCommandQueue_fnptr(context, device, properties, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateCommandQueueWithProperties</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, int*, IntPtr> _clCreateCommandQueueWithProperties_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateCommandQueueWithProperties_Lazy(IntPtr context, IntPtr device, ulong* properties, int* errcode_ret)
        {
            if (_clCreateCommandQueueWithProperties_fnptr == null)
                _clCreateCommandQueueWithProperties_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateCommandQueueWithProperties");
            return _clCreateCommandQueueWithProperties_fnptr(context, device, properties, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateCommandQueueWithPropertiesKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, int*, IntPtr> _clCreateCommandQueueWithPropertiesKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateCommandQueueWithPropertiesKHR_Lazy(IntPtr context, IntPtr device, ulong* properties, int* errcode_ret)
        {
            if (_clCreateCommandQueueWithPropertiesKHR_fnptr == null)
                _clCreateCommandQueueWithPropertiesKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateCommandQueueWithPropertiesKHR");
            return _clCreateCommandQueueWithPropertiesKHR_fnptr(context, device, properties, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*, IntPtr> _clCreateContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateContext_Lazy(IntPtr* properties, uint num_devices, IntPtr* devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, void* user_data, int* errcode_ret)
        {
            if (_clCreateContext_fnptr == null)
                _clCreateContext_fnptr = (delegate* unmanaged<IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateContext");
            return _clCreateContext_fnptr(properties, num_devices, devices, pfn_notify, user_data, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateContextFromType</c>]</b></summary>
        public static delegate* unmanaged<IntPtr*, ulong, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*, IntPtr> _clCreateContextFromType_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateContextFromType_Lazy(IntPtr* properties, ulong device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, void* user_data, int* errcode_ret)
        {
            if (_clCreateContextFromType_fnptr == null)
                _clCreateContextFromType_fnptr = (delegate* unmanaged<IntPtr*, ulong, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateContextFromType");
            return _clCreateContextFromType_fnptr(properties, device_type, pfn_notify, user_data, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateEventFromEGLSyncKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, void*, int*, IntPtr> _clCreateEventFromEGLSyncKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateEventFromEGLSyncKHR_Lazy(IntPtr context, void* sync, void* display, int* errcode_ret)
        {
            if (_clCreateEventFromEGLSyncKHR_fnptr == null)
                _clCreateEventFromEGLSyncKHR_fnptr = (delegate* unmanaged<IntPtr, void*, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateEventFromEGLSyncKHR");
            return _clCreateEventFromEGLSyncKHR_fnptr(context, sync, display, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateEventFromGLsyncKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr> _clCreateEventFromGLsyncKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateEventFromGLsyncKHR_Lazy(IntPtr context, IntPtr sync, int* errcode_ret)
        {
            if (_clCreateEventFromGLsyncKHR_fnptr == null)
                _clCreateEventFromGLsyncKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateEventFromGLsyncKHR");
            return _clCreateEventFromGLsyncKHR_fnptr(context, sync, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromD3D10BufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, int*, IntPtr> _clCreateFromD3D10BufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromD3D10BufferKHR_Lazy(IntPtr context, ulong flags, IntPtr* resource, int* errcode_ret)
        {
            if (_clCreateFromD3D10BufferKHR_fnptr == null)
                _clCreateFromD3D10BufferKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromD3D10BufferKHR");
            return _clCreateFromD3D10BufferKHR_fnptr(context, flags, resource, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromD3D10Texture2DKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr> _clCreateFromD3D10Texture2DKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromD3D10Texture2DKHR_Lazy(IntPtr context, ulong flags, IntPtr* resource, uint subresource, int* errcode_ret)
        {
            if (_clCreateFromD3D10Texture2DKHR_fnptr == null)
                _clCreateFromD3D10Texture2DKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromD3D10Texture2DKHR");
            return _clCreateFromD3D10Texture2DKHR_fnptr(context, flags, resource, subresource, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromD3D10Texture3DKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr> _clCreateFromD3D10Texture3DKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromD3D10Texture3DKHR_Lazy(IntPtr context, ulong flags, IntPtr* resource, uint subresource, int* errcode_ret)
        {
            if (_clCreateFromD3D10Texture3DKHR_fnptr == null)
                _clCreateFromD3D10Texture3DKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromD3D10Texture3DKHR");
            return _clCreateFromD3D10Texture3DKHR_fnptr(context, flags, resource, subresource, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromD3D11BufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, int*, IntPtr> _clCreateFromD3D11BufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromD3D11BufferKHR_Lazy(IntPtr context, ulong flags, IntPtr* resource, int* errcode_ret)
        {
            if (_clCreateFromD3D11BufferKHR_fnptr == null)
                _clCreateFromD3D11BufferKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromD3D11BufferKHR");
            return _clCreateFromD3D11BufferKHR_fnptr(context, flags, resource, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromD3D11Texture2DKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr> _clCreateFromD3D11Texture2DKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromD3D11Texture2DKHR_Lazy(IntPtr context, ulong flags, IntPtr* resource, uint subresource, int* errcode_ret)
        {
            if (_clCreateFromD3D11Texture2DKHR_fnptr == null)
                _clCreateFromD3D11Texture2DKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromD3D11Texture2DKHR");
            return _clCreateFromD3D11Texture2DKHR_fnptr(context, flags, resource, subresource, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromD3D11Texture3DKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr> _clCreateFromD3D11Texture3DKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromD3D11Texture3DKHR_Lazy(IntPtr context, ulong flags, IntPtr* resource, uint subresource, int* errcode_ret)
        {
            if (_clCreateFromD3D11Texture3DKHR_fnptr == null)
                _clCreateFromD3D11Texture3DKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromD3D11Texture3DKHR");
            return _clCreateFromD3D11Texture3DKHR_fnptr(context, flags, resource, subresource, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromDX9MediaSurfaceINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, IntPtr, uint, int*, IntPtr> _clCreateFromDX9MediaSurfaceINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromDX9MediaSurfaceINTEL_Lazy(IntPtr context, ulong flags, IntPtr* resource, IntPtr sharedHandle, uint plane, int* errcode_ret)
        {
            if (_clCreateFromDX9MediaSurfaceINTEL_fnptr == null)
                _clCreateFromDX9MediaSurfaceINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, IntPtr, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromDX9MediaSurfaceINTEL");
            return _clCreateFromDX9MediaSurfaceINTEL_fnptr(context, flags, resource, sharedHandle, plane, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromDX9MediaSurfaceKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, void*, uint, int*, IntPtr> _clCreateFromDX9MediaSurfaceKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromDX9MediaSurfaceKHR_Lazy(IntPtr context, ulong flags, uint adapter_type, void* surface_info, uint plane, int* errcode_ret)
        {
            if (_clCreateFromDX9MediaSurfaceKHR_fnptr == null)
                _clCreateFromDX9MediaSurfaceKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, void*, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromDX9MediaSurfaceKHR");
            return _clCreateFromDX9MediaSurfaceKHR_fnptr(context, flags, adapter_type, surface_info, plane, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromEGLImageKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, void*, ulong, IntPtr*, int*, IntPtr> _clCreateFromEGLImageKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromEGLImageKHR_Lazy(IntPtr context, void* egldisplay, void* eglimage, ulong flags, IntPtr* properties, int* errcode_ret)
        {
            if (_clCreateFromEGLImageKHR_fnptr == null)
                _clCreateFromEGLImageKHR_fnptr = (delegate* unmanaged<IntPtr, void*, void*, ulong, IntPtr*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromEGLImageKHR");
            return _clCreateFromEGLImageKHR_fnptr(context, egldisplay, eglimage, flags, properties, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromGLBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, int*, IntPtr> _clCreateFromGLBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromGLBuffer_Lazy(IntPtr context, ulong flags, uint bufobj, int* errcode_ret)
        {
            if (_clCreateFromGLBuffer_fnptr == null)
                _clCreateFromGLBuffer_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromGLBuffer");
            return _clCreateFromGLBuffer_fnptr(context, flags, bufobj, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromGLRenderbuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, int*, IntPtr> _clCreateFromGLRenderbuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromGLRenderbuffer_Lazy(IntPtr context, ulong flags, uint renderbuffer, int* errcode_ret)
        {
            if (_clCreateFromGLRenderbuffer_fnptr == null)
                _clCreateFromGLRenderbuffer_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromGLRenderbuffer");
            return _clCreateFromGLRenderbuffer_fnptr(context, flags, renderbuffer, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromGLTexture</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, int, uint, int*, IntPtr> _clCreateFromGLTexture_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromGLTexture_Lazy(IntPtr context, ulong flags, uint target, int miplevel, uint texture, int* errcode_ret)
        {
            if (_clCreateFromGLTexture_fnptr == null)
                _clCreateFromGLTexture_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, int, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromGLTexture");
            return _clCreateFromGLTexture_fnptr(context, flags, target, miplevel, texture, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromGLTexture2D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, int, uint, int*, IntPtr> _clCreateFromGLTexture2D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromGLTexture2D_Lazy(IntPtr context, ulong flags, uint target, int miplevel, uint texture, int* errcode_ret)
        {
            if (_clCreateFromGLTexture2D_fnptr == null)
                _clCreateFromGLTexture2D_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, int, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromGLTexture2D");
            return _clCreateFromGLTexture2D_fnptr(context, flags, target, miplevel, texture, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromGLTexture3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, int, uint, int*, IntPtr> _clCreateFromGLTexture3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromGLTexture3D_Lazy(IntPtr context, ulong flags, uint target, int miplevel, uint texture, int* errcode_ret)
        {
            if (_clCreateFromGLTexture3D_fnptr == null)
                _clCreateFromGLTexture3D_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, int, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromGLTexture3D");
            return _clCreateFromGLTexture3D_fnptr(context, flags, target, miplevel, texture, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateFromVA_APIMediaSurfaceINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint*, uint, int*, IntPtr> _clCreateFromVA_APIMediaSurfaceINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateFromVA_APIMediaSurfaceINTEL_Lazy(IntPtr context, ulong flags, uint* surface, uint plane, int* errcode_ret)
        {
            if (_clCreateFromVA_APIMediaSurfaceINTEL_fnptr == null)
                _clCreateFromVA_APIMediaSurfaceINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong, uint*, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateFromVA_APIMediaSurfaceINTEL");
            return _clCreateFromVA_APIMediaSurfaceINTEL_fnptr(context, flags, surface, plane, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, cl_image_format*, cl_image_desc*, void*, int*, IntPtr> _clCreateImage_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateImage_Lazy(IntPtr context, ulong flags, cl_image_format* image_format, cl_image_desc* image_desc, void* host_ptr, int* errcode_ret)
        {
            if (_clCreateImage_fnptr == null)
                _clCreateImage_fnptr = (delegate* unmanaged<IntPtr, ulong, cl_image_format*, cl_image_desc*, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateImage");
            return _clCreateImage_fnptr(context, flags, image_format, image_desc, host_ptr, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateImage2D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, cl_image_format*, nuint, nuint, nuint, void*, int*, IntPtr> _clCreateImage2D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateImage2D_Lazy(IntPtr context, ulong flags, cl_image_format* image_format, nuint image_width, nuint image_height, nuint image_row_pitch, void* host_ptr, int* errcode_ret)
        {
            if (_clCreateImage2D_fnptr == null)
                _clCreateImage2D_fnptr = (delegate* unmanaged<IntPtr, ulong, cl_image_format*, nuint, nuint, nuint, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateImage2D");
            return _clCreateImage2D_fnptr(context, flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateImage3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*, IntPtr> _clCreateImage3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateImage3D_Lazy(IntPtr context, ulong flags, cl_image_format* image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, void* host_ptr, int* errcode_ret)
        {
            if (_clCreateImage3D_fnptr == null)
                _clCreateImage3D_fnptr = (delegate* unmanaged<IntPtr, ulong, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateImage3D");
            return _clCreateImage3D_fnptr(context, flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateImageWithProperties</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, ulong, cl_image_format*, cl_image_desc*, void*, int*, IntPtr> _clCreateImageWithProperties_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateImageWithProperties_Lazy(IntPtr context, ulong* properties, ulong flags, cl_image_format* image_format, cl_image_desc* image_desc, void* host_ptr, int* errcode_ret)
        {
            if (_clCreateImageWithProperties_fnptr == null)
                _clCreateImageWithProperties_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong, cl_image_format*, cl_image_desc*, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateImageWithProperties");
            return _clCreateImageWithProperties_fnptr(context, properties, flags, image_format, image_desc, host_ptr, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateKernel</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, int*, IntPtr> _clCreateKernel_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateKernel_Lazy(IntPtr program, byte* kernel_name, int* errcode_ret)
        {
            if (_clCreateKernel_fnptr == null)
                _clCreateKernel_fnptr = (delegate* unmanaged<IntPtr, byte*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateKernel");
            return _clCreateKernel_fnptr(program, kernel_name, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateKernelsInProgram</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint*, int> _clCreateKernelsInProgram_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCreateKernelsInProgram_Lazy(IntPtr program, uint num_kernels, IntPtr* kernels, uint* num_kernels_ret)
        {
            if (_clCreateKernelsInProgram_fnptr == null)
                _clCreateKernelsInProgram_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clCreateKernelsInProgram");
            return _clCreateKernelsInProgram_fnptr(program, num_kernels, kernels, num_kernels_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreatePipe</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, uint, IntPtr*, int*, IntPtr> _clCreatePipe_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreatePipe_Lazy(IntPtr context, ulong flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr* properties, int* errcode_ret)
        {
            if (_clCreatePipe_fnptr == null)
                _clCreatePipe_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, uint, IntPtr*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreatePipe");
            return _clCreatePipe_fnptr(context, flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateProgramWithBinary</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, nuint*, byte**, int*, int*, IntPtr> _clCreateProgramWithBinary_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateProgramWithBinary_Lazy(IntPtr context, uint num_devices, IntPtr* device_list, nuint* lengths, byte** binaries, int* binary_status, int* errcode_ret)
        {
            if (_clCreateProgramWithBinary_fnptr == null)
                _clCreateProgramWithBinary_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, nuint*, byte**, int*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateProgramWithBinary");
            return _clCreateProgramWithBinary_fnptr(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateProgramWithBuiltInKernels</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, int*, IntPtr> _clCreateProgramWithBuiltInKernels_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateProgramWithBuiltInKernels_Lazy(IntPtr context, uint num_devices, IntPtr* device_list, byte* kernel_names, int* errcode_ret)
        {
            if (_clCreateProgramWithBuiltInKernels_fnptr == null)
                _clCreateProgramWithBuiltInKernels_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateProgramWithBuiltInKernels");
            return _clCreateProgramWithBuiltInKernels_fnptr(context, num_devices, device_list, kernel_names, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateProgramWithIL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, nuint, int*, IntPtr> _clCreateProgramWithIL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateProgramWithIL_Lazy(IntPtr context, void* il, nuint length, int* errcode_ret)
        {
            if (_clCreateProgramWithIL_fnptr == null)
                _clCreateProgramWithIL_fnptr = (delegate* unmanaged<IntPtr, void*, nuint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateProgramWithIL");
            return _clCreateProgramWithIL_fnptr(context, il, length, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateProgramWithILKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, nuint, int*, IntPtr> _clCreateProgramWithILKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateProgramWithILKHR_Lazy(IntPtr context, void* il, nuint length, int* errcode_ret)
        {
            if (_clCreateProgramWithILKHR_fnptr == null)
                _clCreateProgramWithILKHR_fnptr = (delegate* unmanaged<IntPtr, void*, nuint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateProgramWithILKHR");
            return _clCreateProgramWithILKHR_fnptr(context, il, length, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateProgramWithSource</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, byte**, nuint*, int*, IntPtr> _clCreateProgramWithSource_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateProgramWithSource_Lazy(IntPtr context, uint count, byte** strings, nuint* lengths, int* errcode_ret)
        {
            if (_clCreateProgramWithSource_fnptr == null)
                _clCreateProgramWithSource_fnptr = (delegate* unmanaged<IntPtr, uint, byte**, nuint*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateProgramWithSource");
            return _clCreateProgramWithSource_fnptr(context, count, strings, lengths, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateSampler</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, uint, int*, IntPtr> _clCreateSampler_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateSampler_Lazy(IntPtr context, uint normalized_coords, uint addressing_mode, uint filter_mode, int* errcode_ret)
        {
            if (_clCreateSampler_fnptr == null)
                _clCreateSampler_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateSampler");
            return _clCreateSampler_fnptr(context, normalized_coords, addressing_mode, filter_mode, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateSamplerWithProperties</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, int*, IntPtr> _clCreateSamplerWithProperties_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateSamplerWithProperties_Lazy(IntPtr context, ulong* sampler_properties, int* errcode_ret)
        {
            if (_clCreateSamplerWithProperties_fnptr == null)
                _clCreateSamplerWithProperties_fnptr = (delegate* unmanaged<IntPtr, ulong*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateSamplerWithProperties");
            return _clCreateSamplerWithProperties_fnptr(context, sampler_properties, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateSemaphoreWithPropertiesKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, int*, IntPtr> _clCreateSemaphoreWithPropertiesKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateSemaphoreWithPropertiesKHR_Lazy(IntPtr context, ulong* sema_props, int* errcode_ret)
        {
            if (_clCreateSemaphoreWithPropertiesKHR_fnptr == null)
                _clCreateSemaphoreWithPropertiesKHR_fnptr = (delegate* unmanaged<IntPtr, ulong*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateSemaphoreWithPropertiesKHR");
            return _clCreateSemaphoreWithPropertiesKHR_fnptr(context, sema_props, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateSubBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, void*, int*, IntPtr> _clCreateSubBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateSubBuffer_Lazy(IntPtr buffer, ulong flags, uint buffer_create_type, void* buffer_create_info, int* errcode_ret)
        {
            if (_clCreateSubBuffer_fnptr == null)
                _clCreateSubBuffer_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateSubBuffer");
            return _clCreateSubBuffer_fnptr(buffer, flags, buffer_create_type, buffer_create_info, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateSubDevices</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, uint, IntPtr*, uint*, int> _clCreateSubDevices_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCreateSubDevices_Lazy(IntPtr in_device, IntPtr* properties, uint num_devices, IntPtr* out_devices, uint* num_devices_ret)
        {
            if (_clCreateSubDevices_fnptr == null)
                _clCreateSubDevices_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clCreateSubDevices");
            return _clCreateSubDevices_fnptr(in_device, properties, num_devices, out_devices, num_devices_ret);
        }
        
        /// <summary><b>[entry point: <c>clCreateSubDevicesEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, uint, IntPtr*, uint*, int> _clCreateSubDevicesEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clCreateSubDevicesEXT_Lazy(IntPtr in_device, ulong* properties, uint num_entries, IntPtr* out_devices, uint* num_devices)
        {
            if (_clCreateSubDevicesEXT_fnptr == null)
                _clCreateSubDevicesEXT_fnptr = (delegate* unmanaged<IntPtr, ulong*, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clCreateSubDevicesEXT");
            return _clCreateSubDevicesEXT_fnptr(in_device, properties, num_entries, out_devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>clCreateUserEvent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, IntPtr> _clCreateUserEvent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clCreateUserEvent_Lazy(IntPtr context, int* errcode_ret)
        {
            if (_clCreateUserEvent_fnptr == null)
                _clCreateUserEvent_fnptr = (delegate* unmanaged<IntPtr, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clCreateUserEvent");
            return _clCreateUserEvent_fnptr(context, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clDeinitLayer</c>]</b></summary>
        public static delegate* unmanaged<int> _clDeinitLayer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clDeinitLayer_Lazy()
        {
            if (_clDeinitLayer_fnptr == null)
                _clDeinitLayer_fnptr = (delegate* unmanaged<int>)CLLoader.BindingsContext.GetProcAddress("clDeinitLayer");
            return _clDeinitLayer_fnptr();
        }
        
        /// <summary><b>[entry point: <c>clDeviceMemAllocINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, nuint, uint, int*, void*> _clDeviceMemAllocINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clDeviceMemAllocINTEL_Lazy(IntPtr context, IntPtr device, ulong* properties, nuint size, uint alignment, int* errcode_ret)
        {
            if (_clDeviceMemAllocINTEL_fnptr == null)
                _clDeviceMemAllocINTEL_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, nuint, uint, int*, void*>)CLLoader.BindingsContext.GetProcAddress("clDeviceMemAllocINTEL");
            return _clDeviceMemAllocINTEL_fnptr(context, device, properties, size, alignment, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireD3D10ObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireD3D10ObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireD3D10ObjectsKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireD3D10ObjectsKHR_fnptr == null)
                _clEnqueueAcquireD3D10ObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireD3D10ObjectsKHR");
            return _clEnqueueAcquireD3D10ObjectsKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireD3D11ObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireD3D11ObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireD3D11ObjectsKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireD3D11ObjectsKHR_fnptr == null)
                _clEnqueueAcquireD3D11ObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireD3D11ObjectsKHR");
            return _clEnqueueAcquireD3D11ObjectsKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireDX9MediaSurfacesKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireDX9MediaSurfacesKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireDX9MediaSurfacesKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireDX9MediaSurfacesKHR_fnptr == null)
                _clEnqueueAcquireDX9MediaSurfacesKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireDX9MediaSurfacesKHR");
            return _clEnqueueAcquireDX9MediaSurfacesKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireDX9ObjectsINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireDX9ObjectsINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireDX9ObjectsINTEL_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireDX9ObjectsINTEL_fnptr == null)
                _clEnqueueAcquireDX9ObjectsINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireDX9ObjectsINTEL");
            return _clEnqueueAcquireDX9ObjectsINTEL_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireEGLObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireEGLObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireEGLObjectsKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireEGLObjectsKHR_fnptr == null)
                _clEnqueueAcquireEGLObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireEGLObjectsKHR");
            return _clEnqueueAcquireEGLObjectsKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireExternalMemObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireExternalMemObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireExternalMemObjectsKHR_Lazy(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireExternalMemObjectsKHR_fnptr == null)
                _clEnqueueAcquireExternalMemObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireExternalMemObjectsKHR");
            return _clEnqueueAcquireExternalMemObjectsKHR_fnptr(command_queue, num_mem_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireGLObjects</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireGLObjects_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireGLObjects_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireGLObjects_fnptr == null)
                _clEnqueueAcquireGLObjects_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireGLObjects");
            return _clEnqueueAcquireGLObjects_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireGrallocObjectsIMG</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireGrallocObjectsIMG_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireGrallocObjectsIMG_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireGrallocObjectsIMG_fnptr == null)
                _clEnqueueAcquireGrallocObjectsIMG_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireGrallocObjectsIMG");
            return _clEnqueueAcquireGrallocObjectsIMG_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueAcquireVA_APIMediaSurfacesINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueAcquireVA_APIMediaSurfacesINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueAcquireVA_APIMediaSurfacesINTEL_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueAcquireVA_APIMediaSurfacesINTEL_fnptr == null)
                _clEnqueueAcquireVA_APIMediaSurfacesINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueAcquireVA_APIMediaSurfacesINTEL");
            return _clEnqueueAcquireVA_APIMediaSurfacesINTEL_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueBarrier</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clEnqueueBarrier_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueBarrier_Lazy(IntPtr command_queue)
        {
            if (_clEnqueueBarrier_fnptr == null)
                _clEnqueueBarrier_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueBarrier");
            return _clEnqueueBarrier_fnptr(command_queue);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueBarrierWithWaitList</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr*, int> _clEnqueueBarrierWithWaitList_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueBarrierWithWaitList_Lazy(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueBarrierWithWaitList_fnptr == null)
                _clEnqueueBarrierWithWaitList_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueBarrierWithWaitList");
            return _clEnqueueBarrierWithWaitList_fnptr(command_queue, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueCommandBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr*, IntPtr, uint, IntPtr*, IntPtr*, int> _clEnqueueCommandBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueCommandBufferKHR_Lazy(uint num_queues, IntPtr* queues, IntPtr command_buffer, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueCommandBufferKHR_fnptr == null)
                _clEnqueueCommandBufferKHR_fnptr = (delegate* unmanaged<uint, IntPtr*, IntPtr, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueCommandBufferKHR");
            return _clEnqueueCommandBufferKHR_fnptr(num_queues, queues, command_buffer, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueCopyBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint, nuint, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueCopyBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueCopyBuffer_Lazy(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueCopyBuffer_fnptr == null)
                _clEnqueueCopyBuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint, nuint, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueCopyBuffer");
            return _clEnqueueCopyBuffer_fnptr(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueCopyBufferRect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueCopyBufferRect_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueCopyBufferRect_Lazy(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint* src_origin, nuint* dst_origin, nuint* region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueCopyBufferRect_fnptr == null)
                _clEnqueueCopyBufferRect_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueCopyBufferRect");
            return _clEnqueueCopyBufferRect_fnptr(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueCopyBufferToImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, IntPtr*, IntPtr*, int> _clEnqueueCopyBufferToImage_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueCopyBufferToImage_Lazy(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint* dst_origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueCopyBufferToImage_fnptr == null)
                _clEnqueueCopyBufferToImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueCopyBufferToImage");
            return _clEnqueueCopyBufferToImage_fnptr(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueCopyImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int> _clEnqueueCopyImage_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueCopyImage_Lazy(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, nuint* src_origin, nuint* dst_origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueCopyImage_fnptr == null)
                _clEnqueueCopyImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueCopyImage");
            return _clEnqueueCopyImage_fnptr(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueCopyImageToBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueCopyImageToBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueCopyImageToBuffer_Lazy(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, nuint* src_origin, nuint* region, nuint dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueCopyImageToBuffer_fnptr == null)
                _clEnqueueCopyImageToBuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueCopyImageToBuffer");
            return _clEnqueueCopyImageToBuffer_fnptr(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueFillBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueFillBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueFillBuffer_Lazy(IntPtr command_queue, IntPtr buffer, void* pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueFillBuffer_fnptr == null)
                _clEnqueueFillBuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueFillBuffer");
            return _clEnqueueFillBuffer_fnptr(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueFillImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int> _clEnqueueFillImage_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueFillImage_Lazy(IntPtr command_queue, IntPtr image, void* fill_color, nuint* origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueFillImage_fnptr == null)
                _clEnqueueFillImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueFillImage");
            return _clEnqueueFillImage_fnptr(command_queue, image, fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueGenerateMipmapIMG</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, nuint*, nuint*, uint, IntPtr*, IntPtr*, int> _clEnqueueGenerateMipmapIMG_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueGenerateMipmapIMG_Lazy(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, uint mipmap_filter_mode, nuint* array_region, nuint* mip_region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueGenerateMipmapIMG_fnptr == null)
                _clEnqueueGenerateMipmapIMG_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, nuint*, nuint*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueGenerateMipmapIMG");
            return _clEnqueueGenerateMipmapIMG_fnptr(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMapBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, ulong, nuint, nuint, uint, IntPtr*, IntPtr*, int*, void*> _clEnqueueMapBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clEnqueueMapBuffer_Lazy(IntPtr command_queue, IntPtr buffer, uint blocking_map, ulong map_flags, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, int* errcode_ret)
        {
            if (_clEnqueueMapBuffer_fnptr == null)
                _clEnqueueMapBuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, ulong, nuint, nuint, uint, IntPtr*, IntPtr*, int*, void*>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMapBuffer");
            return _clEnqueueMapBuffer_fnptr(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMapImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, ulong, nuint*, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int*, void*> _clEnqueueMapImage_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clEnqueueMapImage_Lazy(IntPtr command_queue, IntPtr image, uint blocking_map, ulong map_flags, nuint* origin, nuint* region, nuint* image_row_pitch, nuint* image_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, int* errcode_ret)
        {
            if (_clEnqueueMapImage_fnptr == null)
                _clEnqueueMapImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, ulong, nuint*, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int*, void*>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMapImage");
            return _clEnqueueMapImage_fnptr(command_queue, image, blocking_map, map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMarker</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int> _clEnqueueMarker_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMarker_Lazy(IntPtr command_queue, IntPtr* @event)
        {
            if (_clEnqueueMarker_fnptr == null)
                _clEnqueueMarker_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMarker");
            return _clEnqueueMarker_fnptr(command_queue, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMarkerWithWaitList</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr*, int> _clEnqueueMarkerWithWaitList_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMarkerWithWaitList_Lazy(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMarkerWithWaitList_fnptr == null)
                _clEnqueueMarkerWithWaitList_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMarkerWithWaitList");
            return _clEnqueueMarkerWithWaitList_fnptr(command_queue, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMemAdviseINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*, int> _clEnqueueMemAdviseINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMemAdviseINTEL_Lazy(IntPtr command_queue, void* ptr, nuint size, uint advice, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMemAdviseINTEL_fnptr == null)
                _clEnqueueMemAdviseINTEL_fnptr = (delegate* unmanaged<IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMemAdviseINTEL");
            return _clEnqueueMemAdviseINTEL_fnptr(command_queue, ptr, size, advice, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMemcpyINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, void*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueMemcpyINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMemcpyINTEL_Lazy(IntPtr command_queue, uint blocking, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMemcpyINTEL_fnptr == null)
                _clEnqueueMemcpyINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, void*, void*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMemcpyINTEL");
            return _clEnqueueMemcpyINTEL_fnptr(command_queue, blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMemFillINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueMemFillINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMemFillINTEL_Lazy(IntPtr command_queue, void* dst_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMemFillINTEL_fnptr == null)
                _clEnqueueMemFillINTEL_fnptr = (delegate* unmanaged<IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMemFillINTEL");
            return _clEnqueueMemFillINTEL_fnptr(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMemsetINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueMemsetINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMemsetINTEL_Lazy(IntPtr command_queue, void* dst_ptr, int value, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMemsetINTEL_fnptr == null)
                _clEnqueueMemsetINTEL_fnptr = (delegate* unmanaged<IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMemsetINTEL");
            return _clEnqueueMemsetINTEL_fnptr(command_queue, dst_ptr, value, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMigrateMemINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, nuint, ulong, uint, IntPtr*, IntPtr*, int> _clEnqueueMigrateMemINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMigrateMemINTEL_Lazy(IntPtr command_queue, void* ptr, nuint size, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMigrateMemINTEL_fnptr == null)
                _clEnqueueMigrateMemINTEL_fnptr = (delegate* unmanaged<IntPtr, void*, nuint, ulong, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMigrateMemINTEL");
            return _clEnqueueMigrateMemINTEL_fnptr(command_queue, ptr, size, flags, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMigrateMemObjectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, ulong, uint, IntPtr*, IntPtr*, int> _clEnqueueMigrateMemObjectEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMigrateMemObjectEXT_Lazy(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMigrateMemObjectEXT_fnptr == null)
                _clEnqueueMigrateMemObjectEXT_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, ulong, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMigrateMemObjectEXT");
            return _clEnqueueMigrateMemObjectEXT_fnptr(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueMigrateMemObjects</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, ulong, uint, IntPtr*, IntPtr*, int> _clEnqueueMigrateMemObjects_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueMigrateMemObjects_Lazy(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueMigrateMemObjects_fnptr == null)
                _clEnqueueMigrateMemObjects_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, ulong, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueMigrateMemObjects");
            return _clEnqueueMigrateMemObjects_fnptr(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueNativeKernel</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*, int> _clEnqueueNativeKernel_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueNativeKernel_Lazy(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, void* args, nuint cb_args, uint num_mem_objects, IntPtr* mem_list, void** args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueNativeKernel_fnptr == null)
                _clEnqueueNativeKernel_fnptr = (delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueNativeKernel");
            return _clEnqueueNativeKernel_fnptr(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueNDRangeKernel</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int> _clEnqueueNDRangeKernel_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueNDRangeKernel_Lazy(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueNDRangeKernel_fnptr == null)
                _clEnqueueNDRangeKernel_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueNDRangeKernel");
            return _clEnqueueNDRangeKernel_fnptr(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReadBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueReadBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReadBuffer_Lazy(IntPtr command_queue, IntPtr buffer, uint blocking_read, nuint offset, nuint size, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReadBuffer_fnptr == null)
                _clEnqueueReadBuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReadBuffer");
            return _clEnqueueReadBuffer_fnptr(command_queue, buffer, blocking_read, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReadBufferRect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueReadBufferRect_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReadBufferRect_Lazy(IntPtr command_queue, IntPtr buffer, uint blocking_read, nuint* buffer_origin, nuint* host_origin, nuint* region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReadBufferRect_fnptr == null)
                _clEnqueueReadBufferRect_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReadBufferRect");
            return _clEnqueueReadBufferRect_fnptr(command_queue, buffer, blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReadHostPipeINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, byte*, uint, void*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueReadHostPipeINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReadHostPipeINTEL_Lazy(IntPtr command_queue, IntPtr program, byte* pipe_symbol, uint blocking_read, void* ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReadHostPipeINTEL_fnptr == null)
                _clEnqueueReadHostPipeINTEL_fnptr = (delegate* unmanaged<IntPtr, IntPtr, byte*, uint, void*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReadHostPipeINTEL");
            return _clEnqueueReadHostPipeINTEL_fnptr(command_queue, program, pipe_symbol, blocking_read, ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReadImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueReadImage_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReadImage_Lazy(IntPtr command_queue, IntPtr image, uint blocking_read, nuint* origin, nuint* region, nuint row_pitch, nuint slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReadImage_fnptr == null)
                _clEnqueueReadImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReadImage");
            return _clEnqueueReadImage_fnptr(command_queue, image, blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseD3D10ObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseD3D10ObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseD3D10ObjectsKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseD3D10ObjectsKHR_fnptr == null)
                _clEnqueueReleaseD3D10ObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseD3D10ObjectsKHR");
            return _clEnqueueReleaseD3D10ObjectsKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseD3D11ObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseD3D11ObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseD3D11ObjectsKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseD3D11ObjectsKHR_fnptr == null)
                _clEnqueueReleaseD3D11ObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseD3D11ObjectsKHR");
            return _clEnqueueReleaseD3D11ObjectsKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseDX9MediaSurfacesKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseDX9MediaSurfacesKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseDX9MediaSurfacesKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseDX9MediaSurfacesKHR_fnptr == null)
                _clEnqueueReleaseDX9MediaSurfacesKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseDX9MediaSurfacesKHR");
            return _clEnqueueReleaseDX9MediaSurfacesKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseDX9ObjectsINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseDX9ObjectsINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseDX9ObjectsINTEL_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseDX9ObjectsINTEL_fnptr == null)
                _clEnqueueReleaseDX9ObjectsINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseDX9ObjectsINTEL");
            return _clEnqueueReleaseDX9ObjectsINTEL_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseEGLObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseEGLObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseEGLObjectsKHR_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseEGLObjectsKHR_fnptr == null)
                _clEnqueueReleaseEGLObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseEGLObjectsKHR");
            return _clEnqueueReleaseEGLObjectsKHR_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseExternalMemObjectsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseExternalMemObjectsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseExternalMemObjectsKHR_Lazy(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseExternalMemObjectsKHR_fnptr == null)
                _clEnqueueReleaseExternalMemObjectsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseExternalMemObjectsKHR");
            return _clEnqueueReleaseExternalMemObjectsKHR_fnptr(command_queue, num_mem_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseGLObjects</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseGLObjects_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseGLObjects_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseGLObjects_fnptr == null)
                _clEnqueueReleaseGLObjects_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseGLObjects");
            return _clEnqueueReleaseGLObjects_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseGrallocObjectsIMG</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseGrallocObjectsIMG_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseGrallocObjectsIMG_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseGrallocObjectsIMG_fnptr == null)
                _clEnqueueReleaseGrallocObjectsIMG_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseGrallocObjectsIMG");
            return _clEnqueueReleaseGrallocObjectsIMG_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueReleaseVA_APIMediaSurfacesINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int> _clEnqueueReleaseVA_APIMediaSurfacesINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueReleaseVA_APIMediaSurfacesINTEL_Lazy(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueReleaseVA_APIMediaSurfacesINTEL_fnptr == null)
                _clEnqueueReleaseVA_APIMediaSurfacesINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueReleaseVA_APIMediaSurfacesINTEL");
            return _clEnqueueReleaseVA_APIMediaSurfacesINTEL_fnptr(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSignalSemaphoresKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*, int> _clEnqueueSignalSemaphoresKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSignalSemaphoresKHR_Lazy(IntPtr command_queue, uint num_sema_objects, IntPtr* sema_objects, ulong* sema_payload_list, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSignalSemaphoresKHR_fnptr == null)
                _clEnqueueSignalSemaphoresKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSignalSemaphoresKHR");
            return _clEnqueueSignalSemaphoresKHR_fnptr(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMFree</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMFree_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMFree_Lazy(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, void* user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMFree_fnptr == null)
                _clEnqueueSVMFree_fnptr = (delegate* unmanaged<IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMFree");
            return _clEnqueueSVMFree_fnptr(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMFreeARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMFreeARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMFreeARM_Lazy(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, void* user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMFreeARM_fnptr == null)
                _clEnqueueSVMFreeARM_fnptr = (delegate* unmanaged<IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMFreeARM");
            return _clEnqueueSVMFreeARM_fnptr(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMMap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, ulong, void*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMMap_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMMap_Lazy(IntPtr command_queue, uint blocking_map, ulong flags, void* svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMMap_fnptr == null)
                _clEnqueueSVMMap_fnptr = (delegate* unmanaged<IntPtr, uint, ulong, void*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMMap");
            return _clEnqueueSVMMap_fnptr(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMMapARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, ulong, void*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMMapARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMMapARM_Lazy(IntPtr command_queue, uint blocking_map, ulong flags, void* svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMMapARM_fnptr == null)
                _clEnqueueSVMMapARM_fnptr = (delegate* unmanaged<IntPtr, uint, ulong, void*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMMapARM");
            return _clEnqueueSVMMapARM_fnptr(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMMemcpy</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, void*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMMemcpy_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMMemcpy_Lazy(IntPtr command_queue, uint blocking_copy, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMMemcpy_fnptr == null)
                _clEnqueueSVMMemcpy_fnptr = (delegate* unmanaged<IntPtr, uint, void*, void*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMMemcpy");
            return _clEnqueueSVMMemcpy_fnptr(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMMemcpyARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, void*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMMemcpyARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMMemcpyARM_Lazy(IntPtr command_queue, uint blocking_copy, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMMemcpyARM_fnptr == null)
                _clEnqueueSVMMemcpyARM_fnptr = (delegate* unmanaged<IntPtr, uint, void*, void*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMMemcpyARM");
            return _clEnqueueSVMMemcpyARM_fnptr(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMMemFill</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMMemFill_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMMemFill_Lazy(IntPtr command_queue, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMMemFill_fnptr == null)
                _clEnqueueSVMMemFill_fnptr = (delegate* unmanaged<IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMMemFill");
            return _clEnqueueSVMMemFill_fnptr(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMMemFillARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMMemFillARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMMemFillARM_Lazy(IntPtr command_queue, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMMemFillARM_fnptr == null)
                _clEnqueueSVMMemFillARM_fnptr = (delegate* unmanaged<IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMMemFillARM");
            return _clEnqueueSVMMemFillARM_fnptr(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMMigrateMem</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void**, nuint*, ulong, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMMigrateMem_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMMigrateMem_Lazy(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, nuint* sizes, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMMigrateMem_fnptr == null)
                _clEnqueueSVMMigrateMem_fnptr = (delegate* unmanaged<IntPtr, uint, void**, nuint*, ulong, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMMigrateMem");
            return _clEnqueueSVMMigrateMem_fnptr(command_queue, num_svm_pointers, svm_pointers, sizes, flags, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMUnmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMUnmap_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMUnmap_Lazy(IntPtr command_queue, void* svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMUnmap_fnptr == null)
                _clEnqueueSVMUnmap_fnptr = (delegate* unmanaged<IntPtr, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMUnmap");
            return _clEnqueueSVMUnmap_fnptr(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueSVMUnmapARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueSVMUnmapARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueSVMUnmapARM_Lazy(IntPtr command_queue, void* svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueSVMUnmapARM_fnptr == null)
                _clEnqueueSVMUnmapARM_fnptr = (delegate* unmanaged<IntPtr, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueSVMUnmapARM");
            return _clEnqueueSVMUnmapARM_fnptr(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueTask</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr*, IntPtr*, int> _clEnqueueTask_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueTask_Lazy(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueTask_fnptr == null)
                _clEnqueueTask_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueTask");
            return _clEnqueueTask_fnptr(command_queue, kernel, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueUnmapMemObject</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueUnmapMemObject_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueUnmapMemObject_Lazy(IntPtr command_queue, IntPtr memobj, void* mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueUnmapMemObject_fnptr == null)
                _clEnqueueUnmapMemObject_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueUnmapMemObject");
            return _clEnqueueUnmapMemObject_fnptr(command_queue, memobj, mapped_ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueWaitForEvents</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, int> _clEnqueueWaitForEvents_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueWaitForEvents_Lazy(IntPtr command_queue, uint num_events, IntPtr* event_list)
        {
            if (_clEnqueueWaitForEvents_fnptr == null)
                _clEnqueueWaitForEvents_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueWaitForEvents");
            return _clEnqueueWaitForEvents_fnptr(command_queue, num_events, event_list);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueWaitSemaphoresKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*, int> _clEnqueueWaitSemaphoresKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueWaitSemaphoresKHR_Lazy(IntPtr command_queue, uint num_sema_objects, IntPtr* sema_objects, ulong* sema_payload_list, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueWaitSemaphoresKHR_fnptr == null)
                _clEnqueueWaitSemaphoresKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueWaitSemaphoresKHR");
            return _clEnqueueWaitSemaphoresKHR_fnptr(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueWriteBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueWriteBuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueWriteBuffer_Lazy(IntPtr command_queue, IntPtr buffer, uint blocking_write, nuint offset, nuint size, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueWriteBuffer_fnptr == null)
                _clEnqueueWriteBuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueWriteBuffer");
            return _clEnqueueWriteBuffer_fnptr(command_queue, buffer, blocking_write, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueWriteBufferRect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueWriteBufferRect_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueWriteBufferRect_Lazy(IntPtr command_queue, IntPtr buffer, uint blocking_write, nuint* buffer_origin, nuint* host_origin, nuint* region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueWriteBufferRect_fnptr == null)
                _clEnqueueWriteBufferRect_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueWriteBufferRect");
            return _clEnqueueWriteBufferRect_fnptr(command_queue, buffer, blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueWriteHostPipeINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, byte*, uint, void*, nuint, uint, IntPtr*, IntPtr*, int> _clEnqueueWriteHostPipeINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueWriteHostPipeINTEL_Lazy(IntPtr command_queue, IntPtr program, byte* pipe_symbol, uint blocking_write, void* ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueWriteHostPipeINTEL_fnptr == null)
                _clEnqueueWriteHostPipeINTEL_fnptr = (delegate* unmanaged<IntPtr, IntPtr, byte*, uint, void*, nuint, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueWriteHostPipeINTEL");
            return _clEnqueueWriteHostPipeINTEL_fnptr(command_queue, program, pipe_symbol, blocking_write, ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clEnqueueWriteImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int> _clEnqueueWriteImage_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clEnqueueWriteImage_Lazy(IntPtr command_queue, IntPtr image, uint blocking_write, nuint* origin, nuint* region, nuint input_row_pitch, nuint input_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event)
        {
            if (_clEnqueueWriteImage_fnptr == null)
                _clEnqueueWriteImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clEnqueueWriteImage");
            return _clEnqueueWriteImage_fnptr(command_queue, image, blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        }
        
        /// <summary><b>[entry point: <c>clFinalizeCommandBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clFinalizeCommandBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clFinalizeCommandBufferKHR_Lazy(IntPtr command_buffer)
        {
            if (_clFinalizeCommandBufferKHR_fnptr == null)
                _clFinalizeCommandBufferKHR_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clFinalizeCommandBufferKHR");
            return _clFinalizeCommandBufferKHR_fnptr(command_buffer);
        }
        
        /// <summary><b>[entry point: <c>clFinish</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clFinish_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clFinish_Lazy(IntPtr command_queue)
        {
            if (_clFinish_fnptr == null)
                _clFinish_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clFinish");
            return _clFinish_fnptr(command_queue);
        }
        
        /// <summary><b>[entry point: <c>clFlush</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clFlush_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clFlush_Lazy(IntPtr command_queue)
        {
            if (_clFlush_fnptr == null)
                _clFlush_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clFlush");
            return _clFlush_fnptr(command_queue);
        }
        
        /// <summary><b>[entry point: <c>clGetAcceleratorInfoINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetAcceleratorInfoINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetAcceleratorInfoINTEL_Lazy(IntPtr accelerator, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetAcceleratorInfoINTEL_fnptr == null)
                _clGetAcceleratorInfoINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetAcceleratorInfoINTEL");
            return _clGetAcceleratorInfoINTEL_fnptr(accelerator, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetCommandBufferInfoKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetCommandBufferInfoKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetCommandBufferInfoKHR_Lazy(IntPtr command_buffer, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetCommandBufferInfoKHR_fnptr == null)
                _clGetCommandBufferInfoKHR_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetCommandBufferInfoKHR");
            return _clGetCommandBufferInfoKHR_fnptr(command_buffer, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetCommandQueueInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetCommandQueueInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetCommandQueueInfo_Lazy(IntPtr command_queue, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetCommandQueueInfo_fnptr == null)
                _clGetCommandQueueInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetCommandQueueInfo");
            return _clGetCommandQueueInfo_fnptr(command_queue, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetContextInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetContextInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetContextInfo_Lazy(IntPtr context, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetContextInfo_fnptr == null)
                _clGetContextInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetContextInfo");
            return _clGetContextInfo_fnptr(context, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceAndHostTimer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, ulong*, int> _clGetDeviceAndHostTimer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceAndHostTimer_Lazy(IntPtr device, ulong* device_timestamp, ulong* host_timestamp)
        {
            if (_clGetDeviceAndHostTimer_fnptr == null)
                _clGetDeviceAndHostTimer_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceAndHostTimer");
            return _clGetDeviceAndHostTimer_fnptr(device, device_timestamp, host_timestamp);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceIDs</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, IntPtr*, uint*, int> _clGetDeviceIDs_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceIDs_Lazy(IntPtr platform, ulong device_type, uint num_entries, IntPtr* devices, uint* num_devices)
        {
            if (_clGetDeviceIDs_fnptr == null)
                _clGetDeviceIDs_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceIDs");
            return _clGetDeviceIDs_fnptr(platform, device_type, num_entries, devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceIDsFromD3D10KHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int> _clGetDeviceIDsFromD3D10KHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceIDsFromD3D10KHR_Lazy(IntPtr platform, uint d3d_device_source, void* d3d_object, uint d3d_device_set, uint num_entries, IntPtr* devices, uint* num_devices)
        {
            if (_clGetDeviceIDsFromD3D10KHR_fnptr == null)
                _clGetDeviceIDsFromD3D10KHR_fnptr = (delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceIDsFromD3D10KHR");
            return _clGetDeviceIDsFromD3D10KHR_fnptr(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceIDsFromD3D11KHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int> _clGetDeviceIDsFromD3D11KHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceIDsFromD3D11KHR_Lazy(IntPtr platform, uint d3d_device_source, void* d3d_object, uint d3d_device_set, uint num_entries, IntPtr* devices, uint* num_devices)
        {
            if (_clGetDeviceIDsFromD3D11KHR_fnptr == null)
                _clGetDeviceIDsFromD3D11KHR_fnptr = (delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceIDsFromD3D11KHR");
            return _clGetDeviceIDsFromD3D11KHR_fnptr(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceIDsFromDX9INTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int> _clGetDeviceIDsFromDX9INTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceIDsFromDX9INTEL_Lazy(IntPtr platform, uint dx9_device_source, void* dx9_object, uint dx9_device_set, uint num_entries, IntPtr* devices, uint* num_devices)
        {
            if (_clGetDeviceIDsFromDX9INTEL_fnptr == null)
                _clGetDeviceIDsFromDX9INTEL_fnptr = (delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceIDsFromDX9INTEL");
            return _clGetDeviceIDsFromDX9INTEL_fnptr(platform, dx9_device_source, dx9_object, dx9_device_set, num_entries, devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceIDsFromDX9MediaAdapterKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*, int> _clGetDeviceIDsFromDX9MediaAdapterKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceIDsFromDX9MediaAdapterKHR_Lazy(IntPtr platform, uint num_media_adapters, uint* media_adapter_type, void* media_adapters, uint media_adapter_set, uint num_entries, IntPtr* devices, uint* num_devices)
        {
            if (_clGetDeviceIDsFromDX9MediaAdapterKHR_fnptr == null)
                _clGetDeviceIDsFromDX9MediaAdapterKHR_fnptr = (delegate* unmanaged<IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceIDsFromDX9MediaAdapterKHR");
            return _clGetDeviceIDsFromDX9MediaAdapterKHR_fnptr(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceIDsFromVA_APIMediaAdapterINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int> _clGetDeviceIDsFromVA_APIMediaAdapterINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceIDsFromVA_APIMediaAdapterINTEL_Lazy(IntPtr platform, uint media_adapter_type, void* media_adapter, uint media_adapter_set, uint num_entries, IntPtr* devices, uint* num_devices)
        {
            if (_clGetDeviceIDsFromVA_APIMediaAdapterINTEL_fnptr == null)
                _clGetDeviceIDsFromVA_APIMediaAdapterINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, void*, uint, uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceIDsFromVA_APIMediaAdapterINTEL");
            return _clGetDeviceIDsFromVA_APIMediaAdapterINTEL_fnptr(platform, media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceImageInfoQCOM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*, int> _clGetDeviceImageInfoQCOM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceImageInfoQCOM_Lazy(IntPtr device, nuint image_width, nuint image_height, cl_image_format* image_format, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetDeviceImageInfoQCOM_fnptr == null)
                _clGetDeviceImageInfoQCOM_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceImageInfoQCOM");
            return _clGetDeviceImageInfoQCOM_fnptr(device, image_width, image_height, image_format, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetDeviceInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetDeviceInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetDeviceInfo_Lazy(IntPtr device, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetDeviceInfo_fnptr == null)
                _clGetDeviceInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetDeviceInfo");
            return _clGetDeviceInfo_fnptr(device, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetEventInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetEventInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetEventInfo_Lazy(IntPtr @event, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetEventInfo_fnptr == null)
                _clGetEventInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetEventInfo");
            return _clGetEventInfo_fnptr(@event, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetEventProfilingInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetEventProfilingInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetEventProfilingInfo_Lazy(IntPtr @event, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetEventProfilingInfo_fnptr == null)
                _clGetEventProfilingInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetEventProfilingInfo");
            return _clGetEventProfilingInfo_fnptr(@event, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetExtensionFunctionAddress</c>]</b></summary>
        public static delegate* unmanaged<byte*, void*> _clGetExtensionFunctionAddress_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clGetExtensionFunctionAddress_Lazy(byte* func_name)
        {
            if (_clGetExtensionFunctionAddress_fnptr == null)
                _clGetExtensionFunctionAddress_fnptr = (delegate* unmanaged<byte*, void*>)CLLoader.BindingsContext.GetProcAddress("clGetExtensionFunctionAddress");
            return _clGetExtensionFunctionAddress_fnptr(func_name);
        }
        
        /// <summary><b>[entry point: <c>clGetExtensionFunctionAddressForPlatform</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, void*> _clGetExtensionFunctionAddressForPlatform_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clGetExtensionFunctionAddressForPlatform_Lazy(IntPtr platform, byte* func_name)
        {
            if (_clGetExtensionFunctionAddressForPlatform_fnptr == null)
                _clGetExtensionFunctionAddressForPlatform_fnptr = (delegate* unmanaged<IntPtr, byte*, void*>)CLLoader.BindingsContext.GetProcAddress("clGetExtensionFunctionAddressForPlatform");
            return _clGetExtensionFunctionAddressForPlatform_fnptr(platform, func_name);
        }
        
        /// <summary><b>[entry point: <c>clGetGLContextInfoKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr*, uint, nuint, void*, nuint*, int> _clGetGLContextInfoKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetGLContextInfoKHR_Lazy(IntPtr* properties, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetGLContextInfoKHR_fnptr == null)
                _clGetGLContextInfoKHR_fnptr = (delegate* unmanaged<IntPtr*, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetGLContextInfoKHR");
            return _clGetGLContextInfoKHR_fnptr(properties, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetGLObjectInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, uint*, int> _clGetGLObjectInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetGLObjectInfo_Lazy(IntPtr memobj, uint* gl_object_type, uint* gl_object_name)
        {
            if (_clGetGLObjectInfo_fnptr == null)
                _clGetGLObjectInfo_fnptr = (delegate* unmanaged<IntPtr, uint*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetGLObjectInfo");
            return _clGetGLObjectInfo_fnptr(memobj, gl_object_type, gl_object_name);
        }
        
        /// <summary><b>[entry point: <c>clGetGLTextureInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetGLTextureInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetGLTextureInfo_Lazy(IntPtr memobj, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetGLTextureInfo_fnptr == null)
                _clGetGLTextureInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetGLTextureInfo");
            return _clGetGLTextureInfo_fnptr(memobj, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetHostTimer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, int> _clGetHostTimer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetHostTimer_Lazy(IntPtr device, ulong* host_timestamp)
        {
            if (_clGetHostTimer_fnptr == null)
                _clGetHostTimer_fnptr = (delegate* unmanaged<IntPtr, ulong*, int>)CLLoader.BindingsContext.GetProcAddress("clGetHostTimer");
            return _clGetHostTimer_fnptr(device, host_timestamp);
        }
        
        /// <summary><b>[entry point: <c>clGetICDLoaderInfoOCLICD</c>]</b></summary>
        public static delegate* unmanaged<uint, nuint, void*, nuint*, int> _clGetICDLoaderInfoOCLICD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetICDLoaderInfoOCLICD_Lazy(uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetICDLoaderInfoOCLICD_fnptr == null)
                _clGetICDLoaderInfoOCLICD_fnptr = (delegate* unmanaged<uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetICDLoaderInfoOCLICD");
            return _clGetICDLoaderInfoOCLICD_fnptr(param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetImageInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetImageInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetImageInfo_Lazy(IntPtr image, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetImageInfo_fnptr == null)
                _clGetImageInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetImageInfo");
            return _clGetImageInfo_fnptr(image, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetImageRequirementsInfoEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, ulong, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*, int> _clGetImageRequirementsInfoEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetImageRequirementsInfoEXT_Lazy(IntPtr context, ulong* properties, ulong flags, cl_image_format* image_format, cl_image_desc* image_desc, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetImageRequirementsInfoEXT_fnptr == null)
                _clGetImageRequirementsInfoEXT_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetImageRequirementsInfoEXT");
            return _clGetImageRequirementsInfoEXT_fnptr(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetKernelArgInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, nuint, void*, nuint*, int> _clGetKernelArgInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetKernelArgInfo_Lazy(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetKernelArgInfo_fnptr == null)
                _clGetKernelArgInfo_fnptr = (delegate* unmanaged<IntPtr, uint, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetKernelArgInfo");
            return _clGetKernelArgInfo_fnptr(kernel, arg_index, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetKernelInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetKernelInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetKernelInfo_Lazy(IntPtr kernel, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetKernelInfo_fnptr == null)
                _clGetKernelInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetKernelInfo");
            return _clGetKernelInfo_fnptr(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetKernelSubGroupInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*, int> _clGetKernelSubGroupInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetKernelSubGroupInfo_Lazy(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, void* input_value, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetKernelSubGroupInfo_fnptr == null)
                _clGetKernelSubGroupInfo_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetKernelSubGroupInfo");
            return _clGetKernelSubGroupInfo_fnptr(kernel, device, param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetKernelSubGroupInfoKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*, int> _clGetKernelSubGroupInfoKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetKernelSubGroupInfoKHR_Lazy(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, void* input_value, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetKernelSubGroupInfoKHR_fnptr == null)
                _clGetKernelSubGroupInfoKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetKernelSubGroupInfoKHR");
            return _clGetKernelSubGroupInfoKHR_fnptr(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetKernelSuggestedLocalWorkSize</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, int> _clGetKernelSuggestedLocalWorkSize_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetKernelSuggestedLocalWorkSize_Lazy(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* suggested_local_work_size)
        {
            if (_clGetKernelSuggestedLocalWorkSize_fnptr == null)
                _clGetKernelSuggestedLocalWorkSize_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetKernelSuggestedLocalWorkSize");
            return _clGetKernelSuggestedLocalWorkSize_fnptr(command_queue, kernel, work_dim, global_work_offset, global_work_size, suggested_local_work_size);
        }
        
        /// <summary><b>[entry point: <c>clGetKernelSuggestedLocalWorkSizeKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, int> _clGetKernelSuggestedLocalWorkSizeKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetKernelSuggestedLocalWorkSizeKHR_Lazy(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* suggested_local_work_size)
        {
            if (_clGetKernelSuggestedLocalWorkSizeKHR_fnptr == null)
                _clGetKernelSuggestedLocalWorkSizeKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetKernelSuggestedLocalWorkSizeKHR");
            return _clGetKernelSuggestedLocalWorkSizeKHR_fnptr(command_queue, kernel, work_dim, global_work_offset, global_work_size, suggested_local_work_size);
        }
        
        /// <summary><b>[entry point: <c>clGetKernelWorkGroupInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint*, int> _clGetKernelWorkGroupInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetKernelWorkGroupInfo_Lazy(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetKernelWorkGroupInfo_fnptr == null)
                _clGetKernelWorkGroupInfo_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetKernelWorkGroupInfo");
            return _clGetKernelWorkGroupInfo_fnptr(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetLayerInfo</c>]</b></summary>
        public static delegate* unmanaged<uint, nuint, void*, nuint*, int> _clGetLayerInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetLayerInfo_Lazy(uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetLayerInfo_fnptr == null)
                _clGetLayerInfo_fnptr = (delegate* unmanaged<uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetLayerInfo");
            return _clGetLayerInfo_fnptr(param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetMemAllocInfoINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, uint, nuint, void*, nuint*, int> _clGetMemAllocInfoINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetMemAllocInfoINTEL_Lazy(IntPtr context, void* ptr, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetMemAllocInfoINTEL_fnptr == null)
                _clGetMemAllocInfoINTEL_fnptr = (delegate* unmanaged<IntPtr, void*, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetMemAllocInfoINTEL");
            return _clGetMemAllocInfoINTEL_fnptr(context, ptr, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetMemObjectInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetMemObjectInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetMemObjectInfo_Lazy(IntPtr memobj, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetMemObjectInfo_fnptr == null)
                _clGetMemObjectInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetMemObjectInfo");
            return _clGetMemObjectInfo_fnptr(memobj, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetMutableCommandInfoKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetMutableCommandInfoKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetMutableCommandInfoKHR_Lazy(IntPtr command, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetMutableCommandInfoKHR_fnptr == null)
                _clGetMutableCommandInfoKHR_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetMutableCommandInfoKHR");
            return _clGetMutableCommandInfoKHR_fnptr(command, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetPipeInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetPipeInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetPipeInfo_Lazy(IntPtr pipe, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetPipeInfo_fnptr == null)
                _clGetPipeInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetPipeInfo");
            return _clGetPipeInfo_fnptr(pipe, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetPlatformIDs</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr*, uint*, int> _clGetPlatformIDs_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetPlatformIDs_Lazy(uint num_entries, IntPtr* platforms, uint* num_platforms)
        {
            if (_clGetPlatformIDs_fnptr == null)
                _clGetPlatformIDs_fnptr = (delegate* unmanaged<uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetPlatformIDs");
            return _clGetPlatformIDs_fnptr(num_entries, platforms, num_platforms);
        }
        
        /// <summary><b>[entry point: <c>clGetPlatformInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetPlatformInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetPlatformInfo_Lazy(IntPtr platform, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetPlatformInfo_fnptr == null)
                _clGetPlatformInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetPlatformInfo");
            return _clGetPlatformInfo_fnptr(platform, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetProgramBuildInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint*, int> _clGetProgramBuildInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetProgramBuildInfo_Lazy(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetProgramBuildInfo_fnptr == null)
                _clGetProgramBuildInfo_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetProgramBuildInfo");
            return _clGetProgramBuildInfo_fnptr(program, device, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetProgramInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetProgramInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetProgramInfo_Lazy(IntPtr program, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetProgramInfo_fnptr == null)
                _clGetProgramInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetProgramInfo");
            return _clGetProgramInfo_fnptr(program, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetSamplerInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetSamplerInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSamplerInfo_Lazy(IntPtr sampler, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetSamplerInfo_fnptr == null)
                _clGetSamplerInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSamplerInfo");
            return _clGetSamplerInfo_fnptr(sampler, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetSemaphoreHandleForTypeKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint*, int> _clGetSemaphoreHandleForTypeKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSemaphoreHandleForTypeKHR_Lazy(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, void* handle_ptr, nuint* handle_size_ret)
        {
            if (_clGetSemaphoreHandleForTypeKHR_fnptr == null)
                _clGetSemaphoreHandleForTypeKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSemaphoreHandleForTypeKHR");
            return _clGetSemaphoreHandleForTypeKHR_fnptr(sema_object, device, handle_type, handle_size, handle_ptr, handle_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetSemaphoreInfoKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int> _clGetSemaphoreInfoKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSemaphoreInfoKHR_Lazy(IntPtr sema_object, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetSemaphoreInfoKHR_fnptr == null)
                _clGetSemaphoreInfoKHR_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSemaphoreInfoKHR");
            return _clGetSemaphoreInfoKHR_fnptr(sema_object, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetSupportedD3D10TextureFormatsINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, uint, uint*, uint*, int> _clGetSupportedD3D10TextureFormatsINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSupportedD3D10TextureFormatsINTEL_Lazy(IntPtr context, ulong flags, uint image_type, uint num_entries, uint* d3d10_formats, uint* num_texture_formats)
        {
            if (_clGetSupportedD3D10TextureFormatsINTEL_fnptr == null)
                _clGetSupportedD3D10TextureFormatsINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, uint, uint*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSupportedD3D10TextureFormatsINTEL");
            return _clGetSupportedD3D10TextureFormatsINTEL_fnptr(context, flags, image_type, num_entries, d3d10_formats, num_texture_formats);
        }
        
        /// <summary><b>[entry point: <c>clGetSupportedD3D11TextureFormatsINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, uint, uint, uint*, uint*, int> _clGetSupportedD3D11TextureFormatsINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSupportedD3D11TextureFormatsINTEL_Lazy(IntPtr context, ulong flags, uint image_type, uint plane, uint num_entries, uint* d3d11_formats, uint* num_texture_formats)
        {
            if (_clGetSupportedD3D11TextureFormatsINTEL_fnptr == null)
                _clGetSupportedD3D11TextureFormatsINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, uint, uint, uint*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSupportedD3D11TextureFormatsINTEL");
            return _clGetSupportedD3D11TextureFormatsINTEL_fnptr(context, flags, image_type, plane, num_entries, d3d11_formats, num_texture_formats);
        }
        
        /// <summary><b>[entry point: <c>clGetSupportedDX9MediaSurfaceFormatsINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, uint, uint, uint*, uint*, int> _clGetSupportedDX9MediaSurfaceFormatsINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSupportedDX9MediaSurfaceFormatsINTEL_Lazy(IntPtr context, ulong flags, uint image_type, uint plane, uint num_entries, uint* dx9_formats, uint* num_surface_formats)
        {
            if (_clGetSupportedDX9MediaSurfaceFormatsINTEL_fnptr == null)
                _clGetSupportedDX9MediaSurfaceFormatsINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, uint, uint, uint*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSupportedDX9MediaSurfaceFormatsINTEL");
            return _clGetSupportedDX9MediaSurfaceFormatsINTEL_fnptr(context, flags, image_type, plane, num_entries, dx9_formats, num_surface_formats);
        }
        
        /// <summary><b>[entry point: <c>clGetSupportedGLTextureFormatsINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, uint, uint*, uint*, int> _clGetSupportedGLTextureFormatsINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSupportedGLTextureFormatsINTEL_Lazy(IntPtr context, ulong flags, uint image_type, uint num_entries, uint* gl_formats, uint* num_texture_formats)
        {
            if (_clGetSupportedGLTextureFormatsINTEL_fnptr == null)
                _clGetSupportedGLTextureFormatsINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, uint, uint*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSupportedGLTextureFormatsINTEL");
            return _clGetSupportedGLTextureFormatsINTEL_fnptr(context, flags, image_type, num_entries, gl_formats, num_texture_formats);
        }
        
        /// <summary><b>[entry point: <c>clGetSupportedImageFormats</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, uint, cl_image_format*, uint*, int> _clGetSupportedImageFormats_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSupportedImageFormats_Lazy(IntPtr context, ulong flags, uint image_type, uint num_entries, cl_image_format* image_formats, uint* num_image_formats)
        {
            if (_clGetSupportedImageFormats_fnptr == null)
                _clGetSupportedImageFormats_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, uint, cl_image_format*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSupportedImageFormats");
            return _clGetSupportedImageFormats_fnptr(context, flags, image_type, num_entries, image_formats, num_image_formats);
        }
        
        /// <summary><b>[entry point: <c>clGetSupportedVA_APIMediaSurfaceFormatsINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, uint, uint, VAImageFormat*, uint*, int> _clGetSupportedVA_APIMediaSurfaceFormatsINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSupportedVA_APIMediaSurfaceFormatsINTEL_Lazy(IntPtr context, ulong flags, uint image_type, uint plane, uint num_entries, VAImageFormat* va_api_formats, uint* num_surface_formats)
        {
            if (_clGetSupportedVA_APIMediaSurfaceFormatsINTEL_fnptr == null)
                _clGetSupportedVA_APIMediaSurfaceFormatsINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, uint, uint, VAImageFormat*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSupportedVA_APIMediaSurfaceFormatsINTEL");
            return _clGetSupportedVA_APIMediaSurfaceFormatsINTEL_fnptr(context, flags, image_type, plane, num_entries, va_api_formats, num_surface_formats);
        }
        
        /// <summary><b>[entry point: <c>clGetSVMPointerInfoKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, uint, nuint, void*, nuint*, int> _clGetSVMPointerInfoKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSVMPointerInfoKHR_Lazy(IntPtr context, IntPtr device, void* ptr, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret)
        {
            if (_clGetSVMPointerInfoKHR_fnptr == null)
                _clGetSVMPointerInfoKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, uint, nuint, void*, nuint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSVMPointerInfoKHR");
            return _clGetSVMPointerInfoKHR_fnptr(context, device, ptr, param_name, param_value_size, param_value, param_value_size_ret);
        }
        
        /// <summary><b>[entry point: <c>clGetSVMSuggestedTypeIndexKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, ulong, ulong*, nuint, uint*, int> _clGetSVMSuggestedTypeIndexKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clGetSVMSuggestedTypeIndexKHR_Lazy(IntPtr context, ulong required_capabilities, ulong desired_capabilities, ulong* properties, nuint size, uint* suggested_svm_type_index)
        {
            if (_clGetSVMSuggestedTypeIndexKHR_fnptr == null)
                _clGetSVMSuggestedTypeIndexKHR_fnptr = (delegate* unmanaged<IntPtr, ulong, ulong, ulong*, nuint, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clGetSVMSuggestedTypeIndexKHR");
            return _clGetSVMSuggestedTypeIndexKHR_fnptr(context, required_capabilities, desired_capabilities, properties, size, suggested_svm_type_index);
        }
        
        /// <summary><b>[entry point: <c>clHostMemAllocINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, nuint, uint, int*, void*> _clHostMemAllocINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clHostMemAllocINTEL_Lazy(IntPtr context, ulong* properties, nuint size, uint alignment, int* errcode_ret)
        {
            if (_clHostMemAllocINTEL_fnptr == null)
                _clHostMemAllocINTEL_fnptr = (delegate* unmanaged<IntPtr, ulong*, nuint, uint, int*, void*>)CLLoader.BindingsContext.GetProcAddress("clHostMemAllocINTEL");
            return _clHostMemAllocINTEL_fnptr(context, properties, size, alignment, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clIcdGetFunctionAddressForPlatformKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, void*> _clIcdGetFunctionAddressForPlatformKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clIcdGetFunctionAddressForPlatformKHR_Lazy(IntPtr platform, byte* func_name)
        {
            if (_clIcdGetFunctionAddressForPlatformKHR_fnptr == null)
                _clIcdGetFunctionAddressForPlatformKHR_fnptr = (delegate* unmanaged<IntPtr, byte*, void*>)CLLoader.BindingsContext.GetProcAddress("clIcdGetFunctionAddressForPlatformKHR");
            return _clIcdGetFunctionAddressForPlatformKHR_fnptr(platform, func_name);
        }
        
        /// <summary><b>[entry point: <c>clIcdGetPlatformIDsKHR</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr*, uint*, int> _clIcdGetPlatformIDsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clIcdGetPlatformIDsKHR_Lazy(uint num_entries, IntPtr* platforms, uint* num_platforms)
        {
            if (_clIcdGetPlatformIDsKHR_fnptr == null)
                _clIcdGetPlatformIDsKHR_fnptr = (delegate* unmanaged<uint, IntPtr*, uint*, int>)CLLoader.BindingsContext.GetProcAddress("clIcdGetPlatformIDsKHR");
            return _clIcdGetPlatformIDsKHR_fnptr(num_entries, platforms, num_platforms);
        }
        
        /// <summary><b>[entry point: <c>clIcdSetPlatformDispatchDataKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, int> _clIcdSetPlatformDispatchDataKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clIcdSetPlatformDispatchDataKHR_Lazy(IntPtr platform, void* dispatch_data)
        {
            if (_clIcdSetPlatformDispatchDataKHR_fnptr == null)
                _clIcdSetPlatformDispatchDataKHR_fnptr = (delegate* unmanaged<IntPtr, void*, int>)CLLoader.BindingsContext.GetProcAddress("clIcdSetPlatformDispatchDataKHR");
            return _clIcdSetPlatformDispatchDataKHR_fnptr(platform, dispatch_data);
        }
        
        /// <summary><b>[entry point: <c>clImportMemoryARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, IntPtr*, void*, nuint, int*, IntPtr> _clImportMemoryARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clImportMemoryARM_Lazy(IntPtr context, ulong flags, IntPtr* properties, void* memory, nuint size, int* errcode_ret)
        {
            if (_clImportMemoryARM_fnptr == null)
                _clImportMemoryARM_fnptr = (delegate* unmanaged<IntPtr, ulong, IntPtr*, void*, nuint, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clImportMemoryARM");
            return _clImportMemoryARM_fnptr(context, flags, properties, memory, size, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clInitLayer</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, uint*, IntPtr*, int> _clInitLayer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clInitLayer_Lazy(uint num_entries, IntPtr target_dispatch, uint* num_entries_ret, IntPtr* layer_dispatch_ret)
        {
            if (_clInitLayer_fnptr == null)
                _clInitLayer_fnptr = (delegate* unmanaged<uint, IntPtr, uint*, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clInitLayer");
            return _clInitLayer_fnptr(num_entries, target_dispatch, num_entries_ret, layer_dispatch_ret);
        }
        
        /// <summary><b>[entry point: <c>clInitLayerWithProperties</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, uint*, IntPtr*, ulong*, int> _clInitLayerWithProperties_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clInitLayerWithProperties_Lazy(uint num_entries, IntPtr target_dispatch, uint* num_entries_ret, IntPtr* layer_dispatch_ret, ulong* properties)
        {
            if (_clInitLayerWithProperties_fnptr == null)
                _clInitLayerWithProperties_fnptr = (delegate* unmanaged<uint, IntPtr, uint*, IntPtr*, ulong*, int>)CLLoader.BindingsContext.GetProcAddress("clInitLayerWithProperties");
            return _clInitLayerWithProperties_fnptr(num_entries, target_dispatch, num_entries_ret, layer_dispatch_ret, properties);
        }
        
        /// <summary><b>[entry point: <c>clLinkProgram</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*, IntPtr> _clLinkProgram_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clLinkProgram_Lazy(IntPtr context, uint num_devices, IntPtr* device_list, byte* options, uint num_input_programs, IntPtr* input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data, int* errcode_ret)
        {
            if (_clLinkProgram_fnptr == null)
                _clLinkProgram_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clLinkProgram");
            return _clLinkProgram_fnptr(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clLogMessagesToStderrAPPLE</c>]</b></summary>
        public static delegate* unmanaged<byte*, void*, nuint, void*, void> _clLogMessagesToStderrAPPLE_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void clLogMessagesToStderrAPPLE_Lazy(byte* errstr, void* private_info, nuint cb, void* user_data)
        {
            if (_clLogMessagesToStderrAPPLE_fnptr == null)
                _clLogMessagesToStderrAPPLE_fnptr = (delegate* unmanaged<byte*, void*, nuint, void*, void>)CLLoader.BindingsContext.GetProcAddress("clLogMessagesToStderrAPPLE");
            _clLogMessagesToStderrAPPLE_fnptr(errstr, private_info, cb, user_data);
        }
        
        /// <summary><b>[entry point: <c>clLogMessagesToStdoutAPPLE</c>]</b></summary>
        public static delegate* unmanaged<byte*, void*, nuint, void*, void> _clLogMessagesToStdoutAPPLE_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void clLogMessagesToStdoutAPPLE_Lazy(byte* errstr, void* private_info, nuint cb, void* user_data)
        {
            if (_clLogMessagesToStdoutAPPLE_fnptr == null)
                _clLogMessagesToStdoutAPPLE_fnptr = (delegate* unmanaged<byte*, void*, nuint, void*, void>)CLLoader.BindingsContext.GetProcAddress("clLogMessagesToStdoutAPPLE");
            _clLogMessagesToStdoutAPPLE_fnptr(errstr, private_info, cb, user_data);
        }
        
        /// <summary><b>[entry point: <c>clLogMessagesToSystemLogAPPLE</c>]</b></summary>
        public static delegate* unmanaged<byte*, void*, nuint, void*, void> _clLogMessagesToSystemLogAPPLE_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void clLogMessagesToSystemLogAPPLE_Lazy(byte* errstr, void* private_info, nuint cb, void* user_data)
        {
            if (_clLogMessagesToSystemLogAPPLE_fnptr == null)
                _clLogMessagesToSystemLogAPPLE_fnptr = (delegate* unmanaged<byte*, void*, nuint, void*, void>)CLLoader.BindingsContext.GetProcAddress("clLogMessagesToSystemLogAPPLE");
            _clLogMessagesToSystemLogAPPLE_fnptr(errstr, private_info, cb, user_data);
        }
        
        /// <summary><b>[entry point: <c>clMemBlockingFreeINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, int> _clMemBlockingFreeINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clMemBlockingFreeINTEL_Lazy(IntPtr context, void* ptr)
        {
            if (_clMemBlockingFreeINTEL_fnptr == null)
                _clMemBlockingFreeINTEL_fnptr = (delegate* unmanaged<IntPtr, void*, int>)CLLoader.BindingsContext.GetProcAddress("clMemBlockingFreeINTEL");
            return _clMemBlockingFreeINTEL_fnptr(context, ptr);
        }
        
        /// <summary><b>[entry point: <c>clMemFreeINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, int> _clMemFreeINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clMemFreeINTEL_Lazy(IntPtr context, void* ptr)
        {
            if (_clMemFreeINTEL_fnptr == null)
                _clMemFreeINTEL_fnptr = (delegate* unmanaged<IntPtr, void*, int>)CLLoader.BindingsContext.GetProcAddress("clMemFreeINTEL");
            return _clMemFreeINTEL_fnptr(context, ptr);
        }
        
        /// <summary><b>[entry point: <c>clReImportSemaphoreSyncFdKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, int, int> _clReImportSemaphoreSyncFdKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReImportSemaphoreSyncFdKHR_Lazy(IntPtr sema_object, ulong* reimport_props, int fd)
        {
            if (_clReImportSemaphoreSyncFdKHR_fnptr == null)
                _clReImportSemaphoreSyncFdKHR_fnptr = (delegate* unmanaged<IntPtr, ulong*, int, int>)CLLoader.BindingsContext.GetProcAddress("clReImportSemaphoreSyncFdKHR");
            return _clReImportSemaphoreSyncFdKHR_fnptr(sema_object, reimport_props, fd);
        }
        
        /// <summary><b>[entry point: <c>clReleaseAcceleratorINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseAcceleratorINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseAcceleratorINTEL_Lazy(IntPtr accelerator)
        {
            if (_clReleaseAcceleratorINTEL_fnptr == null)
                _clReleaseAcceleratorINTEL_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseAcceleratorINTEL");
            return _clReleaseAcceleratorINTEL_fnptr(accelerator);
        }
        
        /// <summary><b>[entry point: <c>clReleaseCommandBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseCommandBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseCommandBufferKHR_Lazy(IntPtr command_buffer)
        {
            if (_clReleaseCommandBufferKHR_fnptr == null)
                _clReleaseCommandBufferKHR_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseCommandBufferKHR");
            return _clReleaseCommandBufferKHR_fnptr(command_buffer);
        }
        
        /// <summary><b>[entry point: <c>clReleaseCommandQueue</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseCommandQueue_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseCommandQueue_Lazy(IntPtr command_queue)
        {
            if (_clReleaseCommandQueue_fnptr == null)
                _clReleaseCommandQueue_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseCommandQueue");
            return _clReleaseCommandQueue_fnptr(command_queue);
        }
        
        /// <summary><b>[entry point: <c>clReleaseContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseContext_Lazy(IntPtr context)
        {
            if (_clReleaseContext_fnptr == null)
                _clReleaseContext_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseContext");
            return _clReleaseContext_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>clReleaseDevice</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseDevice_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseDevice_Lazy(IntPtr device)
        {
            if (_clReleaseDevice_fnptr == null)
                _clReleaseDevice_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseDevice");
            return _clReleaseDevice_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>clReleaseDeviceEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseDeviceEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseDeviceEXT_Lazy(IntPtr device)
        {
            if (_clReleaseDeviceEXT_fnptr == null)
                _clReleaseDeviceEXT_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseDeviceEXT");
            return _clReleaseDeviceEXT_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>clReleaseEvent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseEvent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseEvent_Lazy(IntPtr @event)
        {
            if (_clReleaseEvent_fnptr == null)
                _clReleaseEvent_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseEvent");
            return _clReleaseEvent_fnptr(@event);
        }
        
        /// <summary><b>[entry point: <c>clReleaseKernel</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseKernel_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseKernel_Lazy(IntPtr kernel)
        {
            if (_clReleaseKernel_fnptr == null)
                _clReleaseKernel_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseKernel");
            return _clReleaseKernel_fnptr(kernel);
        }
        
        /// <summary><b>[entry point: <c>clReleaseMemObject</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseMemObject_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseMemObject_Lazy(IntPtr memobj)
        {
            if (_clReleaseMemObject_fnptr == null)
                _clReleaseMemObject_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseMemObject");
            return _clReleaseMemObject_fnptr(memobj);
        }
        
        /// <summary><b>[entry point: <c>clReleaseProgram</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseProgram_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseProgram_Lazy(IntPtr program)
        {
            if (_clReleaseProgram_fnptr == null)
                _clReleaseProgram_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseProgram");
            return _clReleaseProgram_fnptr(program);
        }
        
        /// <summary><b>[entry point: <c>clReleaseSampler</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseSampler_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseSampler_Lazy(IntPtr sampler)
        {
            if (_clReleaseSampler_fnptr == null)
                _clReleaseSampler_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseSampler");
            return _clReleaseSampler_fnptr(sampler);
        }
        
        /// <summary><b>[entry point: <c>clReleaseSemaphoreKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clReleaseSemaphoreKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clReleaseSemaphoreKHR_Lazy(IntPtr sema_object)
        {
            if (_clReleaseSemaphoreKHR_fnptr == null)
                _clReleaseSemaphoreKHR_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clReleaseSemaphoreKHR");
            return _clReleaseSemaphoreKHR_fnptr(sema_object);
        }
        
        /// <summary><b>[entry point: <c>clRemapCommandBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, IntPtr*, uint, IntPtr*, IntPtr*, int*, IntPtr> _clRemapCommandBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr clRemapCommandBufferKHR_Lazy(IntPtr command_buffer, uint automatic, uint num_queues, IntPtr* queues, uint num_handles, IntPtr* handles, IntPtr* handles_ret, int* errcode_ret)
        {
            if (_clRemapCommandBufferKHR_fnptr == null)
                _clRemapCommandBufferKHR_fnptr = (delegate* unmanaged<IntPtr, uint, uint, IntPtr*, uint, IntPtr*, IntPtr*, int*, IntPtr>)CLLoader.BindingsContext.GetProcAddress("clRemapCommandBufferKHR");
            return _clRemapCommandBufferKHR_fnptr(command_buffer, automatic, num_queues, queues, num_handles, handles, handles_ret, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clRetainAcceleratorINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainAcceleratorINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainAcceleratorINTEL_Lazy(IntPtr accelerator)
        {
            if (_clRetainAcceleratorINTEL_fnptr == null)
                _clRetainAcceleratorINTEL_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainAcceleratorINTEL");
            return _clRetainAcceleratorINTEL_fnptr(accelerator);
        }
        
        /// <summary><b>[entry point: <c>clRetainCommandBufferKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainCommandBufferKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainCommandBufferKHR_Lazy(IntPtr command_buffer)
        {
            if (_clRetainCommandBufferKHR_fnptr == null)
                _clRetainCommandBufferKHR_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainCommandBufferKHR");
            return _clRetainCommandBufferKHR_fnptr(command_buffer);
        }
        
        /// <summary><b>[entry point: <c>clRetainCommandQueue</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainCommandQueue_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainCommandQueue_Lazy(IntPtr command_queue)
        {
            if (_clRetainCommandQueue_fnptr == null)
                _clRetainCommandQueue_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainCommandQueue");
            return _clRetainCommandQueue_fnptr(command_queue);
        }
        
        /// <summary><b>[entry point: <c>clRetainContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainContext_Lazy(IntPtr context)
        {
            if (_clRetainContext_fnptr == null)
                _clRetainContext_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainContext");
            return _clRetainContext_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>clRetainDevice</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainDevice_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainDevice_Lazy(IntPtr device)
        {
            if (_clRetainDevice_fnptr == null)
                _clRetainDevice_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainDevice");
            return _clRetainDevice_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>clRetainDeviceEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainDeviceEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainDeviceEXT_Lazy(IntPtr device)
        {
            if (_clRetainDeviceEXT_fnptr == null)
                _clRetainDeviceEXT_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainDeviceEXT");
            return _clRetainDeviceEXT_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>clRetainEvent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainEvent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainEvent_Lazy(IntPtr @event)
        {
            if (_clRetainEvent_fnptr == null)
                _clRetainEvent_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainEvent");
            return _clRetainEvent_fnptr(@event);
        }
        
        /// <summary><b>[entry point: <c>clRetainKernel</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainKernel_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainKernel_Lazy(IntPtr kernel)
        {
            if (_clRetainKernel_fnptr == null)
                _clRetainKernel_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainKernel");
            return _clRetainKernel_fnptr(kernel);
        }
        
        /// <summary><b>[entry point: <c>clRetainMemObject</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainMemObject_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainMemObject_Lazy(IntPtr memobj)
        {
            if (_clRetainMemObject_fnptr == null)
                _clRetainMemObject_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainMemObject");
            return _clRetainMemObject_fnptr(memobj);
        }
        
        /// <summary><b>[entry point: <c>clRetainProgram</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainProgram_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainProgram_Lazy(IntPtr program)
        {
            if (_clRetainProgram_fnptr == null)
                _clRetainProgram_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainProgram");
            return _clRetainProgram_fnptr(program);
        }
        
        /// <summary><b>[entry point: <c>clRetainSampler</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainSampler_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainSampler_Lazy(IntPtr sampler)
        {
            if (_clRetainSampler_fnptr == null)
                _clRetainSampler_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainSampler");
            return _clRetainSampler_fnptr(sampler);
        }
        
        /// <summary><b>[entry point: <c>clRetainSemaphoreKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clRetainSemaphoreKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clRetainSemaphoreKHR_Lazy(IntPtr sema_object)
        {
            if (_clRetainSemaphoreKHR_fnptr == null)
                _clRetainSemaphoreKHR_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clRetainSemaphoreKHR");
            return _clRetainSemaphoreKHR_fnptr(sema_object);
        }
        
        /// <summary><b>[entry point: <c>clSetCommandQueueProperty</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, uint, ulong*, int> _clSetCommandQueueProperty_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetCommandQueueProperty_Lazy(IntPtr command_queue, ulong properties, uint enable, ulong* old_properties)
        {
            if (_clSetCommandQueueProperty_fnptr == null)
                _clSetCommandQueueProperty_fnptr = (delegate* unmanaged<IntPtr, ulong, uint, ulong*, int>)CLLoader.BindingsContext.GetProcAddress("clSetCommandQueueProperty");
            return _clSetCommandQueueProperty_fnptr(command_queue, properties, enable, old_properties);
        }
        
        /// <summary><b>[entry point: <c>clSetContentSizeBufferPoCL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _clSetContentSizeBufferPoCL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetContentSizeBufferPoCL_Lazy(IntPtr buffer, IntPtr content_size_buffer)
        {
            if (_clSetContentSizeBufferPoCL_fnptr == null)
                _clSetContentSizeBufferPoCL_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clSetContentSizeBufferPoCL");
            return _clSetContentSizeBufferPoCL_fnptr(buffer, content_size_buffer);
        }
        
        /// <summary><b>[entry point: <c>clSetContextDestructorCallback</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int> _clSetContextDestructorCallback_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetContextDestructorCallback_Lazy(IntPtr context, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data)
        {
            if (_clSetContextDestructorCallback_fnptr == null)
                _clSetContextDestructorCallback_fnptr = (delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetContextDestructorCallback");
            return _clSetContextDestructorCallback_fnptr(context, pfn_notify, user_data);
        }
        
        /// <summary><b>[entry point: <c>clSetDefaultDeviceCommandQueue</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int> _clSetDefaultDeviceCommandQueue_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetDefaultDeviceCommandQueue_Lazy(IntPtr context, IntPtr device, IntPtr command_queue)
        {
            if (_clSetDefaultDeviceCommandQueue_fnptr == null)
                _clSetDefaultDeviceCommandQueue_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clSetDefaultDeviceCommandQueue");
            return _clSetDefaultDeviceCommandQueue_fnptr(context, device, command_queue);
        }
        
        /// <summary><b>[entry point: <c>clSetEventCallback</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void>, void*, int> _clSetEventCallback_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetEventCallback_Lazy(IntPtr @event, int command_exec_callback_type, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void> pfn_notify, void* user_data)
        {
            if (_clSetEventCallback_fnptr == null)
                _clSetEventCallback_fnptr = (delegate* unmanaged<IntPtr, int, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void>, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetEventCallback");
            return _clSetEventCallback_fnptr(@event, command_exec_callback_type, pfn_notify, user_data);
        }
        
        /// <summary><b>[entry point: <c>clSetKernelArg</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, int> _clSetKernelArg_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetKernelArg_Lazy(IntPtr kernel, uint arg_index, nuint arg_size, void* arg_value)
        {
            if (_clSetKernelArg_fnptr == null)
                _clSetKernelArg_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetKernelArg");
            return _clSetKernelArg_fnptr(kernel, arg_index, arg_size, arg_value);
        }
        
        /// <summary><b>[entry point: <c>clSetKernelArgDevicePointerEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, ulong, int> _clSetKernelArgDevicePointerEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetKernelArgDevicePointerEXT_Lazy(IntPtr kernel, uint arg_index, ulong arg_value)
        {
            if (_clSetKernelArgDevicePointerEXT_fnptr == null)
                _clSetKernelArgDevicePointerEXT_fnptr = (delegate* unmanaged<IntPtr, uint, ulong, int>)CLLoader.BindingsContext.GetProcAddress("clSetKernelArgDevicePointerEXT");
            return _clSetKernelArgDevicePointerEXT_fnptr(kernel, arg_index, arg_value);
        }
        
        /// <summary><b>[entry point: <c>clSetKernelArgMemPointerINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, int> _clSetKernelArgMemPointerINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetKernelArgMemPointerINTEL_Lazy(IntPtr kernel, uint arg_index, void* arg_value)
        {
            if (_clSetKernelArgMemPointerINTEL_fnptr == null)
                _clSetKernelArgMemPointerINTEL_fnptr = (delegate* unmanaged<IntPtr, uint, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetKernelArgMemPointerINTEL");
            return _clSetKernelArgMemPointerINTEL_fnptr(kernel, arg_index, arg_value);
        }
        
        /// <summary><b>[entry point: <c>clSetKernelArgSVMPointer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, int> _clSetKernelArgSVMPointer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetKernelArgSVMPointer_Lazy(IntPtr kernel, uint arg_index, void* arg_value)
        {
            if (_clSetKernelArgSVMPointer_fnptr == null)
                _clSetKernelArgSVMPointer_fnptr = (delegate* unmanaged<IntPtr, uint, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetKernelArgSVMPointer");
            return _clSetKernelArgSVMPointer_fnptr(kernel, arg_index, arg_value);
        }
        
        /// <summary><b>[entry point: <c>clSetKernelArgSVMPointerARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, void*, int> _clSetKernelArgSVMPointerARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetKernelArgSVMPointerARM_Lazy(IntPtr kernel, uint arg_index, void* arg_value)
        {
            if (_clSetKernelArgSVMPointerARM_fnptr == null)
                _clSetKernelArgSVMPointerARM_fnptr = (delegate* unmanaged<IntPtr, uint, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetKernelArgSVMPointerARM");
            return _clSetKernelArgSVMPointerARM_fnptr(kernel, arg_index, arg_value);
        }
        
        /// <summary><b>[entry point: <c>clSetKernelExecInfo</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, int> _clSetKernelExecInfo_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetKernelExecInfo_Lazy(IntPtr kernel, uint param_name, nuint param_value_size, void* param_value)
        {
            if (_clSetKernelExecInfo_fnptr == null)
                _clSetKernelExecInfo_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetKernelExecInfo");
            return _clSetKernelExecInfo_fnptr(kernel, param_name, param_value_size, param_value);
        }
        
        /// <summary><b>[entry point: <c>clSetKernelExecInfoARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, int> _clSetKernelExecInfoARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetKernelExecInfoARM_Lazy(IntPtr kernel, uint param_name, nuint param_value_size, void* param_value)
        {
            if (_clSetKernelExecInfoARM_fnptr == null)
                _clSetKernelExecInfoARM_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetKernelExecInfoARM");
            return _clSetKernelExecInfoARM_fnptr(kernel, param_name, param_value_size, param_value);
        }
        
        /// <summary><b>[entry point: <c>clSetMemObjectDestructorAPPLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int> _clSetMemObjectDestructorAPPLE_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetMemObjectDestructorAPPLE_Lazy(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data)
        {
            if (_clSetMemObjectDestructorAPPLE_fnptr == null)
                _clSetMemObjectDestructorAPPLE_fnptr = (delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetMemObjectDestructorAPPLE");
            return _clSetMemObjectDestructorAPPLE_fnptr(memobj, pfn_notify, user_data);
        }
        
        /// <summary><b>[entry point: <c>clSetMemObjectDestructorCallback</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int> _clSetMemObjectDestructorCallback_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetMemObjectDestructorCallback_Lazy(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data)
        {
            if (_clSetMemObjectDestructorCallback_fnptr == null)
                _clSetMemObjectDestructorCallback_fnptr = (delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetMemObjectDestructorCallback");
            return _clSetMemObjectDestructorCallback_fnptr(memobj, pfn_notify, user_data);
        }
        
        /// <summary><b>[entry point: <c>clSetPerfHintQCOM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _clSetPerfHintQCOM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetPerfHintQCOM_Lazy(IntPtr context, uint perf_hint)
        {
            if (_clSetPerfHintQCOM_fnptr == null)
                _clSetPerfHintQCOM_fnptr = (delegate* unmanaged<IntPtr, uint, int>)CLLoader.BindingsContext.GetProcAddress("clSetPerfHintQCOM");
            return _clSetPerfHintQCOM_fnptr(context, perf_hint);
        }
        
        /// <summary><b>[entry point: <c>clSetProgramReleaseCallback</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int> _clSetProgramReleaseCallback_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetProgramReleaseCallback_Lazy(IntPtr program, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data)
        {
            if (_clSetProgramReleaseCallback_fnptr == null)
                _clSetProgramReleaseCallback_fnptr = (delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetProgramReleaseCallback");
            return _clSetProgramReleaseCallback_fnptr(program, pfn_notify, user_data);
        }
        
        /// <summary><b>[entry point: <c>clSetProgramSpecializationConstant</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, void*, int> _clSetProgramSpecializationConstant_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetProgramSpecializationConstant_Lazy(IntPtr program, uint spec_id, nuint spec_size, void* spec_value)
        {
            if (_clSetProgramSpecializationConstant_fnptr == null)
                _clSetProgramSpecializationConstant_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSetProgramSpecializationConstant");
            return _clSetProgramSpecializationConstant_fnptr(program, spec_id, spec_size, spec_value);
        }
        
        /// <summary><b>[entry point: <c>clSetUserEventStatus</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _clSetUserEventStatus_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSetUserEventStatus_Lazy(IntPtr @event, int execution_status)
        {
            if (_clSetUserEventStatus_fnptr == null)
                _clSetUserEventStatus_fnptr = (delegate* unmanaged<IntPtr, int, int>)CLLoader.BindingsContext.GetProcAddress("clSetUserEventStatus");
            return _clSetUserEventStatus_fnptr(@event, execution_status);
        }
        
        /// <summary><b>[entry point: <c>clSharedMemAllocINTEL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, nuint, uint, int*, void*> _clSharedMemAllocINTEL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clSharedMemAllocINTEL_Lazy(IntPtr context, IntPtr device, ulong* properties, nuint size, uint alignment, int* errcode_ret)
        {
            if (_clSharedMemAllocINTEL_fnptr == null)
                _clSharedMemAllocINTEL_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, nuint, uint, int*, void*>)CLLoader.BindingsContext.GetProcAddress("clSharedMemAllocINTEL");
            return _clSharedMemAllocINTEL_fnptr(context, device, properties, size, alignment, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clSVMAlloc</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, nuint, uint, void*> _clSVMAlloc_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clSVMAlloc_Lazy(IntPtr context, ulong flags, nuint size, uint alignment)
        {
            if (_clSVMAlloc_fnptr == null)
                _clSVMAlloc_fnptr = (delegate* unmanaged<IntPtr, ulong, nuint, uint, void*>)CLLoader.BindingsContext.GetProcAddress("clSVMAlloc");
            return _clSVMAlloc_fnptr(context, flags, size, alignment);
        }
        
        /// <summary><b>[entry point: <c>clSVMAllocARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong, nuint, uint, void*> _clSVMAllocARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clSVMAllocARM_Lazy(IntPtr context, ulong flags, nuint size, uint alignment)
        {
            if (_clSVMAllocARM_fnptr == null)
                _clSVMAllocARM_fnptr = (delegate* unmanaged<IntPtr, ulong, nuint, uint, void*>)CLLoader.BindingsContext.GetProcAddress("clSVMAllocARM");
            return _clSVMAllocARM_fnptr(context, flags, size, alignment);
        }
        
        /// <summary><b>[entry point: <c>clSVMAllocWithPropertiesKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, uint, nuint, int*, void*> _clSVMAllocWithPropertiesKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* clSVMAllocWithPropertiesKHR_Lazy(IntPtr context, ulong* properties, uint svm_type_index, nuint size, int* errcode_ret)
        {
            if (_clSVMAllocWithPropertiesKHR_fnptr == null)
                _clSVMAllocWithPropertiesKHR_fnptr = (delegate* unmanaged<IntPtr, ulong*, uint, nuint, int*, void*>)CLLoader.BindingsContext.GetProcAddress("clSVMAllocWithPropertiesKHR");
            return _clSVMAllocWithPropertiesKHR_fnptr(context, properties, svm_type_index, size, errcode_ret);
        }
        
        /// <summary><b>[entry point: <c>clSVMFree</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, void> _clSVMFree_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void clSVMFree_Lazy(IntPtr context, void* svm_pointer)
        {
            if (_clSVMFree_fnptr == null)
                _clSVMFree_fnptr = (delegate* unmanaged<IntPtr, void*, void>)CLLoader.BindingsContext.GetProcAddress("clSVMFree");
            _clSVMFree_fnptr(context, svm_pointer);
        }
        
        /// <summary><b>[entry point: <c>clSVMFreeARM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, void> _clSVMFreeARM_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void clSVMFreeARM_Lazy(IntPtr context, void* svm_pointer)
        {
            if (_clSVMFreeARM_fnptr == null)
                _clSVMFreeARM_fnptr = (delegate* unmanaged<IntPtr, void*, void>)CLLoader.BindingsContext.GetProcAddress("clSVMFreeARM");
            _clSVMFreeARM_fnptr(context, svm_pointer);
        }
        
        /// <summary><b>[entry point: <c>clSVMFreeWithPropertiesKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, ulong, void*, int> _clSVMFreeWithPropertiesKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clSVMFreeWithPropertiesKHR_Lazy(IntPtr context, ulong* properties, ulong flags, void* ptr)
        {
            if (_clSVMFreeWithPropertiesKHR_fnptr == null)
                _clSVMFreeWithPropertiesKHR_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong, void*, int>)CLLoader.BindingsContext.GetProcAddress("clSVMFreeWithPropertiesKHR");
            return _clSVMFreeWithPropertiesKHR_fnptr(context, properties, flags, ptr);
        }
        
        /// <summary><b>[entry point: <c>clTerminateContextKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clTerminateContextKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clTerminateContextKHR_Lazy(IntPtr context)
        {
            if (_clTerminateContextKHR_fnptr == null)
                _clTerminateContextKHR_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clTerminateContextKHR");
            return _clTerminateContextKHR_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>clUnloadCompiler</c>]</b></summary>
        public static delegate* unmanaged<int> _clUnloadCompiler_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clUnloadCompiler_Lazy()
        {
            if (_clUnloadCompiler_fnptr == null)
                _clUnloadCompiler_fnptr = (delegate* unmanaged<int>)CLLoader.BindingsContext.GetProcAddress("clUnloadCompiler");
            return _clUnloadCompiler_fnptr();
        }
        
        /// <summary><b>[entry point: <c>clUnloadPlatformCompiler</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _clUnloadPlatformCompiler_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clUnloadPlatformCompiler_Lazy(IntPtr platform)
        {
            if (_clUnloadPlatformCompiler_fnptr == null)
                _clUnloadPlatformCompiler_fnptr = (delegate* unmanaged<IntPtr, int>)CLLoader.BindingsContext.GetProcAddress("clUnloadPlatformCompiler");
            return _clUnloadPlatformCompiler_fnptr(platform);
        }
        
        /// <summary><b>[entry point: <c>clUpdateMutableCommandsKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint*, void**, int> _clUpdateMutableCommandsKHR_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clUpdateMutableCommandsKHR_Lazy(IntPtr command_buffer, uint num_configs, uint* config_types, void** configs)
        {
            if (_clUpdateMutableCommandsKHR_fnptr == null)
                _clUpdateMutableCommandsKHR_fnptr = (delegate* unmanaged<IntPtr, uint, uint*, void**, int>)CLLoader.BindingsContext.GetProcAddress("clUpdateMutableCommandsKHR");
            return _clUpdateMutableCommandsKHR_fnptr(command_buffer, num_configs, config_types, configs);
        }
        
        /// <summary><b>[entry point: <c>clWaitForEvents</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr*, int> _clWaitForEvents_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int clWaitForEvents_Lazy(uint num_events, IntPtr* event_list)
        {
            if (_clWaitForEvents_fnptr == null)
                _clWaitForEvents_fnptr = (delegate* unmanaged<uint, IntPtr*, int>)CLLoader.BindingsContext.GetProcAddress("clWaitForEvents");
            return _clWaitForEvents_fnptr(num_events, event_list);
        }
        
    }
}
