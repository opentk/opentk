// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Compute2;

namespace OpenTK.Compute2.OpenCL
{
    public static unsafe partial class CL
    {
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clBuildProgram</c>]</b><br/>  </summary>
        public static int BuildProgram(IntPtr program, uint num_devices, IntPtr* device_list, byte* options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clBuildProgram_Lazy(program, num_devices, device_list, options, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clCloneKernel</c>]</b><br/>  </summary>
        public static IntPtr CloneKernel(IntPtr source_kernel, int* errcode_ret) => CLPointers.clCloneKernel_Lazy(source_kernel, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCompileProgram</c>]</b><br/>  </summary>
        public static int CompileProgram(IntPtr program, uint num_devices, IntPtr* device_list, byte* options, uint num_input_headers, IntPtr* input_headers, byte** header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clCompileProgram_Lazy(program, num_devices, device_list, options, num_input_headers, input_headers, header_include_names, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateBuffer</c>]</b><br/>  </summary>
        public static IntPtr CreateBuffer(IntPtr context, MemFlags flags, nuint size, void* host_ptr, int* errcode_ret) => CLPointers.clCreateBuffer_Lazy(context, (ulong)flags, size, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>clCreateBufferWithProperties</c>]</b><br/>  </summary>
        public static IntPtr CreateBufferWithProperties(IntPtr context, ulong* properties, MemFlags flags, nuint size, void* host_ptr, int* errcode_ret) => CLPointers.clCreateBufferWithProperties_Lazy(context, properties, (ulong)flags, size, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateCommandQueue</c>]</b><br/>  </summary>
        public static IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperties properties, int* errcode_ret) => CLPointers.clCreateCommandQueue_Lazy(context, device, (ulong)properties, errcode_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clCreateCommandQueueWithProperties</c>]</b><br/>  </summary>
        public static IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, ulong* properties, int* errcode_ret) => CLPointers.clCreateCommandQueueWithProperties_Lazy(context, device, properties, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateContext</c>]</b><br/>  </summary>
        public static IntPtr CreateContext(IntPtr* properties, uint num_devices, IntPtr* devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, void* user_data, int* errcode_ret) => CLPointers.clCreateContext_Lazy(properties, num_devices, devices, pfn_notify, user_data, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateContextFromType</c>]</b><br/>  </summary>
        public static IntPtr CreateContextFromType(IntPtr* properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, void* user_data, int* errcode_ret) => CLPointers.clCreateContextFromType_Lazy(properties, (ulong)device_type, pfn_notify, user_data, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCreateImage</c>]</b><br/>  </summary>
        public static IntPtr CreateImage(IntPtr context, MemFlags flags, cl_image_format* image_format, cl_image_desc* image_desc, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImage_Lazy(context, (ulong)flags, image_format, image_desc, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateImage2D</c>]</b><br/>  </summary>
        public static IntPtr CreateImage2D(IntPtr context, MemFlags flags, cl_image_format* image_format, nuint image_width, nuint image_height, nuint image_row_pitch, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImage2D_Lazy(context, (ulong)flags, image_format, image_width, image_height, image_row_pitch, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateImage3D</c>]</b><br/>  </summary>
        public static IntPtr CreateImage3D(IntPtr context, MemFlags flags, cl_image_format* image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImage3D_Lazy(context, (ulong)flags, image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>clCreateImageWithProperties</c>]</b><br/>  </summary>
        public static IntPtr CreateImageWithProperties(IntPtr context, ulong* properties, MemFlags flags, cl_image_format* image_format, cl_image_desc* image_desc, void* host_ptr, int* errcode_ret) => CLPointers.clCreateImageWithProperties_Lazy(context, properties, (ulong)flags, image_format, image_desc, host_ptr, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateKernel</c>]</b><br/>  </summary>
        public static IntPtr CreateKernel(IntPtr program, byte* kernel_name, int* errcode_ret) => CLPointers.clCreateKernel_Lazy(program, kernel_name, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateKernelsInProgram</c>]</b><br/>  </summary>
        public static int CreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr* kernels, uint* num_kernels_ret) => CLPointers.clCreateKernelsInProgram_Lazy(program, num_kernels, kernels, num_kernels_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clCreatePipe</c>]</b><br/>  </summary>
        public static IntPtr CreatePipe(IntPtr context, MemFlags flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr* properties, int* errcode_ret) => CLPointers.clCreatePipe_Lazy(context, (ulong)flags, pipe_packet_size, pipe_max_packets, properties, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateProgramWithBinary</c>]</b><br/>  </summary>
        public static IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr* device_list, nuint* lengths, byte** binaries, int* binary_status, int* errcode_ret) => CLPointers.clCreateProgramWithBinary_Lazy(context, num_devices, device_list, lengths, binaries, binary_status, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCreateProgramWithBuiltInKernels</c>]</b><br/>  </summary>
        public static IntPtr CreateProgramWithBuiltInKernels(IntPtr context, uint num_devices, IntPtr* device_list, byte* kernel_names, int* errcode_ret) => CLPointers.clCreateProgramWithBuiltInKernels_Lazy(context, num_devices, device_list, kernel_names, errcode_ret);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clCreateProgramWithIL</c>]</b><br/>  </summary>
        public static IntPtr CreateProgramWithIL(IntPtr context, void* il, nuint length, int* errcode_ret) => CLPointers.clCreateProgramWithIL_Lazy(context, il, length, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateProgramWithSource</c>]</b><br/>  </summary>
        public static IntPtr CreateProgramWithSource(IntPtr context, uint count, byte** strings, nuint* lengths, int* errcode_ret) => CLPointers.clCreateProgramWithSource_Lazy(context, count, strings, lengths, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clCreateSampler</c>]</b><br/>  </summary>
        public static IntPtr CreateSampler(IntPtr context, Bool normalized_coords, uint addressing_mode, uint filter_mode, int* errcode_ret) => CLPointers.clCreateSampler_Lazy(context, (uint)normalized_coords, addressing_mode, filter_mode, errcode_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clCreateSamplerWithProperties</c>]</b><br/>  </summary>
        public static IntPtr CreateSamplerWithProperties(IntPtr context, ulong* sampler_properties, int* errcode_ret) => CLPointers.clCreateSamplerWithProperties_Lazy(context, sampler_properties, errcode_ret);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clCreateSubBuffer</c>]</b><br/>  </summary>
        public static IntPtr CreateSubBuffer(IntPtr buffer, MemFlags flags, uint buffer_create_type, void* buffer_create_info, int* errcode_ret) => CLPointers.clCreateSubBuffer_Lazy(buffer, (ulong)flags, buffer_create_type, buffer_create_info, errcode_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clCreateSubDevices</c>]</b><br/>  </summary>
        public static int CreateSubDevices(IntPtr in_device, IntPtr* properties, uint num_devices, IntPtr* out_devices, uint* num_devices_ret) => CLPointers.clCreateSubDevices_Lazy(in_device, properties, num_devices, out_devices, num_devices_ret);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clCreateUserEvent</c>]</b><br/>  </summary>
        public static IntPtr CreateUserEvent(IntPtr context, int* errcode_ret) => CLPointers.clCreateUserEvent_Lazy(context, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueBarrier</c>]</b><br/>  </summary>
        public static int EnqueueBarrier(IntPtr command_queue) => CLPointers.clEnqueueBarrier_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueBarrierWithWaitList</c>]</b><br/>  </summary>
        public static int EnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueBarrierWithWaitList_Lazy(command_queue, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyBuffer</c>]</b><br/>  </summary>
        public static int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyBuffer_Lazy(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clEnqueueCopyBufferRect</c>]</b><br/>  </summary>
        public static int EnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint* src_origin, nuint* dst_origin, nuint* region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyBufferRect_Lazy(command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyBufferToImage</c>]</b><br/>  </summary>
        public static int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint* dst_origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyBufferToImage_Lazy(command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyImage</c>]</b><br/>  </summary>
        public static int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, nuint* src_origin, nuint* dst_origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyImage_Lazy(command_queue, src_image, dst_image, src_origin, dst_origin, region, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueCopyImageToBuffer</c>]</b><br/>  </summary>
        public static int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, nuint* src_origin, nuint* region, nuint dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCopyImageToBuffer_Lazy(command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueFillBuffer</c>]</b><br/>  </summary>
        public static int EnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, void* pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueFillBuffer_Lazy(command_queue, buffer, pattern, pattern_size, offset, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueFillImage</c>]</b><br/>  </summary>
        public static int EnqueueFillImage(IntPtr command_queue, IntPtr image, void* fill_color, nuint* origin, nuint* region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueFillImage_Lazy(command_queue, image, fill_color, origin, region, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueMapBuffer</c>]</b><br/>  </summary>
        public static void* EnqueueMapBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_map, MapFlags map_flags, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, int* errcode_ret) => CLPointers.clEnqueueMapBuffer_Lazy(command_queue, buffer, (uint)blocking_map, (ulong)map_flags, offset, size, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueMapImage</c>]</b><br/>  </summary>
        public static void* EnqueueMapImage(IntPtr command_queue, IntPtr image, Bool blocking_map, MapFlags map_flags, nuint* origin, nuint* region, nuint* image_row_pitch, nuint* image_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, int* errcode_ret) => CLPointers.clEnqueueMapImage_Lazy(command_queue, image, (uint)blocking_map, (ulong)map_flags, origin, region, image_row_pitch, image_slice_pitch, num_events_in_wait_list, event_wait_list, @event, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueMarker</c>]</b><br/>  </summary>
        public static int EnqueueMarker(IntPtr command_queue, IntPtr* @event) => CLPointers.clEnqueueMarker_Lazy(command_queue, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueMarkerWithWaitList</c>]</b><br/>  </summary>
        public static int EnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMarkerWithWaitList_Lazy(command_queue, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clEnqueueMigrateMemObjects</c>]</b><br/>  </summary>
        public static int EnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMigrateMemObjects_Lazy(command_queue, num_mem_objects, mem_objects, (ulong)flags, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueNativeKernel</c>]</b><br/>  </summary>
        public static int EnqueueNativeKernel(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, void* args, nuint cb_args, uint num_mem_objects, IntPtr* mem_list, void** args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueNativeKernel_Lazy(command_queue, user_func, args, cb_args, num_mem_objects, mem_list, args_mem_loc, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueNDRangeKernel</c>]</b><br/>  </summary>
        public static int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueNDRangeKernel_Lazy(command_queue, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueReadBuffer</c>]</b><br/>  </summary>
        public static int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadBuffer_Lazy(command_queue, buffer, (uint)blocking_read, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clEnqueueReadBufferRect</c>]</b><br/>  </summary>
        public static int EnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint* buffer_origin, nuint* host_origin, nuint* region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadBufferRect_Lazy(command_queue, buffer, (uint)blocking_read, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueReadImage</c>]</b><br/>  </summary>
        public static int EnqueueReadImage(IntPtr command_queue, IntPtr image, Bool blocking_read, nuint* origin, nuint* region, nuint row_pitch, nuint slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadImage_Lazy(command_queue, image, (uint)blocking_read, origin, region, row_pitch, slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMFree</c>]</b><br/>  </summary>
        public static int EnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, void* user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMFree_Lazy(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMMap</c>]</b><br/>  </summary>
        public static int EnqueueSVMMap(IntPtr command_queue, Bool blocking_map, MapFlags flags, void* svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMap_Lazy(command_queue, (uint)blocking_map, (ulong)flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMMemcpy</c>]</b><br/>  </summary>
        public static int EnqueueSVMMemcpy(IntPtr command_queue, Bool blocking_copy, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemcpy_Lazy(command_queue, (uint)blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMMemFill</c>]</b><br/>  </summary>
        public static int EnqueueSVMMemFill(IntPtr command_queue, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemFill_Lazy(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clEnqueueSVMMigrateMem</c>]</b><br/>  </summary>
        public static int EnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, nuint* sizes, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMigrateMem_Lazy(command_queue, num_svm_pointers, svm_pointers, sizes, (ulong)flags, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clEnqueueSVMUnmap</c>]</b><br/>  </summary>
        public static int EnqueueSVMUnmap(IntPtr command_queue, void* svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMUnmap_Lazy(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueTask</c>]</b><br/>  </summary>
        public static int EnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueTask_Lazy(command_queue, kernel, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueUnmapMemObject</c>]</b><br/>  </summary>
        public static int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, void* mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueUnmapMemObject_Lazy(command_queue, memobj, mapped_ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueWaitForEvents</c>]</b><br/>  </summary>
        public static int EnqueueWaitForEvents(IntPtr command_queue, uint num_events, IntPtr* event_list) => CLPointers.clEnqueueWaitForEvents_Lazy(command_queue, num_events, event_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueWriteBuffer</c>]</b><br/>  </summary>
        public static int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteBuffer_Lazy(command_queue, buffer, (uint)blocking_write, offset, size, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clEnqueueWriteBufferRect</c>]</b><br/>  </summary>
        public static int EnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint* buffer_origin, nuint* host_origin, nuint* region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteBufferRect_Lazy(command_queue, buffer, (uint)blocking_write, buffer_origin, host_origin, region, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clEnqueueWriteImage</c>]</b><br/>  </summary>
        public static int EnqueueWriteImage(IntPtr command_queue, IntPtr image, Bool blocking_write, nuint* origin, nuint* region, nuint input_row_pitch, nuint input_slice_pitch, void* ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteImage_Lazy(command_queue, image, (uint)blocking_write, origin, region, input_row_pitch, input_slice_pitch, ptr, num_events_in_wait_list, event_wait_list, @event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clFinish</c>]</b><br/>  </summary>
        public static int Finish(IntPtr command_queue) => CLPointers.clFinish_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clFlush</c>]</b><br/>  </summary>
        public static int Flush(IntPtr command_queue) => CLPointers.clFlush_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetCommandQueueInfo</c>]</b><br/>  </summary>
        public static int GetCommandQueueInfo(IntPtr command_queue, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetCommandQueueInfo_Lazy(command_queue, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetContextInfo</c>]</b><br/>  </summary>
        public static int GetContextInfo(IntPtr context, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetContextInfo_Lazy(context, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clGetDeviceAndHostTimer</c>]</b><br/>  </summary>
        public static int GetDeviceAndHostTimer(IntPtr device, ulong* device_timestamp, ulong* host_timestamp) => CLPointers.clGetDeviceAndHostTimer_Lazy(device, device_timestamp, host_timestamp);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetDeviceIDs</c>]</b><br/>  </summary>
        public static int GetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDs_Lazy(platform, (ulong)device_type, num_entries, devices, num_devices);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetDeviceInfo</c>]</b><br/>  </summary>
        public static int GetDeviceInfo(IntPtr device, DeviceInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetDeviceInfo_Lazy(device, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetEventInfo</c>]</b><br/>  </summary>
        public static int GetEventInfo(IntPtr @event, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetEventInfo_Lazy(@event, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetEventProfilingInfo</c>]</b><br/>  </summary>
        public static int GetEventProfilingInfo(IntPtr @event, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetEventProfilingInfo_Lazy(@event, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetExtensionFunctionAddress</c>]</b><br/>  </summary>
        public static void* GetExtensionFunctionAddress(byte* func_name) => CLPointers.clGetExtensionFunctionAddress_Lazy(func_name);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clGetExtensionFunctionAddressForPlatform</c>]</b><br/>  </summary>
        public static void* GetExtensionFunctionAddressForPlatform(IntPtr platform, byte* func_name) => CLPointers.clGetExtensionFunctionAddressForPlatform_Lazy(platform, func_name);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clGetHostTimer</c>]</b><br/>  </summary>
        public static int GetHostTimer(IntPtr device, ulong* host_timestamp) => CLPointers.clGetHostTimer_Lazy(device, host_timestamp);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetImageInfo</c>]</b><br/>  </summary>
        public static int GetImageInfo(IntPtr image, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetImageInfo_Lazy(image, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clGetKernelArgInfo</c>]</b><br/>  </summary>
        public static int GetKernelArgInfo(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelArgInfo_Lazy(kernel, arg_index, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetKernelInfo</c>]</b><br/>  </summary>
        public static int GetKernelInfo(IntPtr kernel, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelInfo_Lazy(kernel, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clGetKernelSubGroupInfo</c>]</b><br/>  </summary>
        public static int GetKernelSubGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, void* input_value, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelSubGroupInfo_Lazy(kernel, device, param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v3.1]</b> <b>[entry point: <c>clGetKernelSuggestedLocalWorkSize</c>]</b><br/>  </summary>
        public static int GetKernelSuggestedLocalWorkSize(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* suggested_local_work_size) => CLPointers.clGetKernelSuggestedLocalWorkSize_Lazy(command_queue, kernel, work_dim, global_work_offset, global_work_size, suggested_local_work_size);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetKernelWorkGroupInfo</c>]</b><br/>  </summary>
        public static int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelWorkGroupInfo_Lazy(kernel, device, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetMemObjectInfo</c>]</b><br/>  </summary>
        public static int GetMemObjectInfo(IntPtr memobj, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetMemObjectInfo_Lazy(memobj, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clGetPipeInfo</c>]</b><br/>  </summary>
        public static int GetPipeInfo(IntPtr pipe, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetPipeInfo_Lazy(pipe, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetPlatformIDs</c>]</b><br/>  </summary>
        public static int GetPlatformIDs(uint num_entries, IntPtr* platforms, uint* num_platforms) => CLPointers.clGetPlatformIDs_Lazy(num_entries, platforms, num_platforms);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetPlatformInfo</c>]</b><br/>  </summary>
        public static int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetPlatformInfo_Lazy(platform, (uint)param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetProgramBuildInfo</c>]</b><br/>  </summary>
        public static int GetProgramBuildInfo(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetProgramBuildInfo_Lazy(program, device, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetProgramInfo</c>]</b><br/>  </summary>
        public static int GetProgramInfo(IntPtr program, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetProgramInfo_Lazy(program, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetSamplerInfo</c>]</b><br/>  </summary>
        public static int GetSamplerInfo(IntPtr sampler, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetSamplerInfo_Lazy(sampler, param_name, param_value_size, param_value, param_value_size_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clGetSupportedImageFormats</c>]</b><br/>  </summary>
        public static int GetSupportedImageFormats(IntPtr context, MemFlags flags, uint image_type, uint num_entries, cl_image_format* image_formats, uint* num_image_formats) => CLPointers.clGetSupportedImageFormats_Lazy(context, (ulong)flags, image_type, num_entries, image_formats, num_image_formats);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clLinkProgram</c>]</b><br/>  </summary>
        public static IntPtr LinkProgram(IntPtr context, uint num_devices, IntPtr* device_list, byte* options, uint num_input_programs, IntPtr* input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data, int* errcode_ret) => CLPointers.clLinkProgram_Lazy(context, num_devices, device_list, options, num_input_programs, input_programs, pfn_notify, user_data, errcode_ret);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseCommandQueue</c>]</b><br/>  </summary>
        public static int ReleaseCommandQueue(IntPtr command_queue) => CLPointers.clReleaseCommandQueue_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseContext</c>]</b><br/>  </summary>
        public static int ReleaseContext(IntPtr context) => CLPointers.clReleaseContext_Lazy(context);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clReleaseDevice</c>]</b><br/>  </summary>
        public static int ReleaseDevice(IntPtr device) => CLPointers.clReleaseDevice_Lazy(device);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseEvent</c>]</b><br/>  </summary>
        public static int ReleaseEvent(IntPtr @event) => CLPointers.clReleaseEvent_Lazy(@event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseKernel</c>]</b><br/>  </summary>
        public static int ReleaseKernel(IntPtr kernel) => CLPointers.clReleaseKernel_Lazy(kernel);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseMemObject</c>]</b><br/>  </summary>
        public static int ReleaseMemObject(IntPtr memobj) => CLPointers.clReleaseMemObject_Lazy(memobj);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseProgram</c>]</b><br/>  </summary>
        public static int ReleaseProgram(IntPtr program) => CLPointers.clReleaseProgram_Lazy(program);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clReleaseSampler</c>]</b><br/>  </summary>
        public static int ReleaseSampler(IntPtr sampler) => CLPointers.clReleaseSampler_Lazy(sampler);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainCommandQueue</c>]</b><br/>  </summary>
        public static int RetainCommandQueue(IntPtr command_queue) => CLPointers.clRetainCommandQueue_Lazy(command_queue);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainContext</c>]</b><br/>  </summary>
        public static int RetainContext(IntPtr context) => CLPointers.clRetainContext_Lazy(context);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clRetainDevice</c>]</b><br/>  </summary>
        public static int RetainDevice(IntPtr device) => CLPointers.clRetainDevice_Lazy(device);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainEvent</c>]</b><br/>  </summary>
        public static int RetainEvent(IntPtr @event) => CLPointers.clRetainEvent_Lazy(@event);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainKernel</c>]</b><br/>  </summary>
        public static int RetainKernel(IntPtr kernel) => CLPointers.clRetainKernel_Lazy(kernel);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainMemObject</c>]</b><br/>  </summary>
        public static int RetainMemObject(IntPtr memobj) => CLPointers.clRetainMemObject_Lazy(memobj);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainProgram</c>]</b><br/>  </summary>
        public static int RetainProgram(IntPtr program) => CLPointers.clRetainProgram_Lazy(program);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clRetainSampler</c>]</b><br/>  </summary>
        public static int RetainSampler(IntPtr sampler) => CLPointers.clRetainSampler_Lazy(sampler);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clSetCommandQueueProperty</c>]</b><br/>  </summary>
        public static int SetCommandQueueProperty(IntPtr command_queue, CommandQueueProperties properties, Bool enable, CommandQueueProperties* old_properties) => CLPointers.clSetCommandQueueProperty_Lazy(command_queue, (ulong)properties, (uint)enable, (ulong*)old_properties);
        
        /// <summary> <b>[requires: v3.0]</b> <b>[entry point: <c>clSetContextDestructorCallback</c>]</b><br/>  </summary>
        public static int SetContextDestructorCallback(IntPtr context, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetContextDestructorCallback_Lazy(context, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.1]</b> <b>[entry point: <c>clSetDefaultDeviceCommandQueue</c>]</b><br/>  </summary>
        public static int SetDefaultDeviceCommandQueue(IntPtr context, IntPtr device, IntPtr command_queue) => CLPointers.clSetDefaultDeviceCommandQueue_Lazy(context, device, command_queue);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clSetEventCallback</c>]</b><br/>  </summary>
        public static int SetEventCallback(IntPtr @event, int command_exec_callback_type, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void> pfn_notify, void* user_data) => CLPointers.clSetEventCallback_Lazy(@event, command_exec_callback_type, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clSetKernelArg</c>]</b><br/>  </summary>
        public static int SetKernelArg(IntPtr kernel, uint arg_index, nuint arg_size, void* arg_value) => CLPointers.clSetKernelArg_Lazy(kernel, arg_index, arg_size, arg_value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSetKernelArgSVMPointer</c>]</b><br/>  </summary>
        public static int SetKernelArgSVMPointer(IntPtr kernel, uint arg_index, void* arg_value) => CLPointers.clSetKernelArgSVMPointer_Lazy(kernel, arg_index, arg_value);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSetKernelExecInfo</c>]</b><br/>  </summary>
        public static int SetKernelExecInfo(IntPtr kernel, uint param_name, nuint param_value_size, void* param_value) => CLPointers.clSetKernelExecInfo_Lazy(kernel, param_name, param_value_size, param_value);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clSetMemObjectDestructorCallback</c>]</b><br/>  </summary>
        public static int SetMemObjectDestructorCallback(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetMemObjectDestructorCallback_Lazy(memobj, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.2]</b> <b>[entry point: <c>clSetProgramReleaseCallback</c>]</b><br/>  </summary>
        public static int SetProgramReleaseCallback(IntPtr program, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetProgramReleaseCallback_Lazy(program, pfn_notify, user_data);
        
        /// <summary> <b>[requires: v2.2]</b> <b>[entry point: <c>clSetProgramSpecializationConstant</c>]</b><br/>  </summary>
        public static int SetProgramSpecializationConstant(IntPtr program, uint spec_id, nuint spec_size, void* spec_value) => CLPointers.clSetProgramSpecializationConstant_Lazy(program, spec_id, spec_size, spec_value);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>clSetUserEventStatus</c>]</b><br/>  </summary>
        public static int SetUserEventStatus(IntPtr @event, int execution_status) => CLPointers.clSetUserEventStatus_Lazy(@event, execution_status);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSVMAlloc</c>]</b><br/>  </summary>
        public static void* SVMAlloc(IntPtr context, ulong flags, nuint size, uint alignment) => CLPointers.clSVMAlloc_Lazy(context, flags, size, alignment);
        
        /// <summary> <b>[requires: v2.0]</b> <b>[entry point: <c>clSVMFree</c>]</b><br/>  </summary>
        public static void SVMFree(IntPtr context, void* svm_pointer) => CLPointers.clSVMFree_Lazy(context, svm_pointer);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clUnloadCompiler</c>]</b><br/>  </summary>
        public static int UnloadCompiler() => CLPointers.clUnloadCompiler_Lazy();
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>clUnloadPlatformCompiler</c>]</b><br/>  </summary>
        public static int UnloadPlatformCompiler(IntPtr platform) => CLPointers.clUnloadPlatformCompiler_Lazy(platform);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>clWaitForEvents</c>]</b><br/>  </summary>
        public static int WaitForEvents(uint num_events, IntPtr* event_list) => CLPointers.clWaitForEvents_Lazy(num_events, event_list);
        
        /// <summary>APPLE extensions.</summary>
        public static unsafe partial class APPLE
        {
            /// <summary> <b>[requires: cl_APPLE_ContextLoggingFunctions]</b> <b>[entry point: <c>clLogMessagesToStderrAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">APPLE_ContextLoggingFunctions.txt</see></remarks>
            public static void LogMessagesToStderrAPPLE(byte* errstr, void* private_info, nuint cb, void* user_data) => CLPointers.clLogMessagesToStderrAPPLE_Lazy(errstr, private_info, cb, user_data);
            
            /// <summary> <b>[requires: cl_APPLE_ContextLoggingFunctions]</b> <b>[entry point: <c>clLogMessagesToStdoutAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">APPLE_ContextLoggingFunctions.txt</see></remarks>
            public static void LogMessagesToStdoutAPPLE(byte* errstr, void* private_info, nuint cb, void* user_data) => CLPointers.clLogMessagesToStdoutAPPLE_Lazy(errstr, private_info, cb, user_data);
            
            /// <summary> <b>[requires: cl_APPLE_ContextLoggingFunctions]</b> <b>[entry point: <c>clLogMessagesToSystemLogAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">APPLE_ContextLoggingFunctions.txt</see></remarks>
            public static void LogMessagesToSystemLogAPPLE(byte* errstr, void* private_info, nuint cb, void* user_data) => CLPointers.clLogMessagesToSystemLogAPPLE_Lazy(errstr, private_info, cb, user_data);
            
            /// <summary> <b>[requires: cl_APPLE_SetMemObjectDestructor]</b> <b>[entry point: <c>clSetMemObjectDestructorAPPLE</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">APPLE_SetMemObjectDestructor.txt</see></remarks>
            public static int SetMemObjectDestructorAPPLE(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, void* user_data) => CLPointers.clSetMemObjectDestructorAPPLE_Lazy(memobj, pfn_notify, user_data);
            
        }
        /// <summary>arm extensions.</summary>
        public static unsafe partial class arm
        {
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMFreeARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMFreeARM(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, void* user_data, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMFreeARM_Lazy(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMMapARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMMapARM(IntPtr command_queue, Bool blocking_map, MapFlags flags, void* svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMapARM_Lazy(command_queue, (uint)blocking_map, (ulong)flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMMemcpyARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMMemcpyARM(IntPtr command_queue, Bool blocking_copy, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemcpyARM_Lazy(command_queue, (uint)blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMMemFillARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMMemFillARM(IntPtr command_queue, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMMemFillARM_Lazy(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clEnqueueSVMUnmapARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static int EnqueueSVMUnmapARM(IntPtr command_queue, void* svm_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSVMUnmapARM_Lazy(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_arm_import_memory]</b> <b>[entry point: <c>clImportMemoryARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_import_memory.txt</see></remarks>
            public static IntPtr ImportMemoryARM(IntPtr context, MemFlags flags, IntPtr* properties, void* memory, nuint size, int* errcode_ret) => CLPointers.clImportMemoryARM_Lazy(context, (ulong)flags, properties, memory, size, errcode_ret);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSetKernelArgSVMPointerARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static int SetKernelArgSVMPointerARM(IntPtr kernel, uint arg_index, void* arg_value) => CLPointers.clSetKernelArgSVMPointerARM_Lazy(kernel, arg_index, arg_value);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSetKernelExecInfoARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static int SetKernelExecInfoARM(IntPtr kernel, uint param_name, nuint param_value_size, void* param_value) => CLPointers.clSetKernelExecInfoARM_Lazy(kernel, param_name, param_value_size, param_value);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSVMAllocARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static void* SVMAllocARM(IntPtr context, ulong flags, nuint size, uint alignment) => CLPointers.clSVMAllocARM_Lazy(context, flags, size, alignment);
            
            /// <summary> <b>[requires: cl_arm_shared_virtual_memory]</b> <b>[entry point: <c>clSVMFreeARM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">arm_shared_virtual_memory.txt</see></remarks>
            public static void SVMFreeARM(IntPtr context, void* svm_pointer) => CLPointers.clSVMFreeARM_Lazy(context, svm_pointer);
            
        }
        /// <summary>ext extensions.</summary>
        public static unsafe partial class ext
        {
            /// <summary> <b>[requires: cl_ext_device_fission]</b> <b>[entry point: <c>clCreateSubDevicesEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">ext_device_fission.txt</see></remarks>
            public static int CreateSubDevicesEXT(IntPtr in_device, ulong* properties, uint num_entries, IntPtr* out_devices, uint* num_devices) => CLPointers.clCreateSubDevicesEXT_Lazy(in_device, properties, num_entries, out_devices, num_devices);
            
            /// <summary> <b>[requires: cl_ext_migrate_memobject]</b> <b>[entry point: <c>clEnqueueMigrateMemObjectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">ext_migrate_memobject.txt</see></remarks>
            public static int EnqueueMigrateMemObjectEXT(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMigrateMemObjectEXT_Lazy(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_ext_image_requirements_info]</b> <b>[entry point: <c>clGetImageRequirementsInfoEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">ext_image_requirements_info.txt</see></remarks>
            public static int GetImageRequirementsInfoEXT(IntPtr context, ulong* properties, MemFlags flags, cl_image_format* image_format, cl_image_desc* image_desc, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetImageRequirementsInfoEXT_Lazy(context, properties, (ulong)flags, image_format, image_desc, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_ext_device_fission]</b> <b>[entry point: <c>clReleaseDeviceEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">ext_device_fission.txt</see></remarks>
            public static int ReleaseDeviceEXT(IntPtr device) => CLPointers.clReleaseDeviceEXT_Lazy(device);
            
            /// <summary> <b>[requires: cl_ext_device_fission]</b> <b>[entry point: <c>clRetainDeviceEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">ext_device_fission.txt</see></remarks>
            public static int RetainDeviceEXT(IntPtr device) => CLPointers.clRetainDeviceEXT_Lazy(device);
            
            /// <summary> <b>[requires: cl_ext_buffer_device_address]</b> <b>[entry point: <c>clSetKernelArgDevicePointerEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">ext_buffer_device_address.txt</see></remarks>
            public static int SetKernelArgDevicePointerEXT(IntPtr kernel, uint arg_index, ulong arg_value) => CLPointers.clSetKernelArgDevicePointerEXT_Lazy(kernel, arg_index, arg_value);
            
        }
        /// <summary>img extensions.</summary>
        public static unsafe partial class img
        {
            /// <summary> <b>[requires: cl_img_cancel_command]</b> <b>[entry point: <c>clCancelCommandsIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">img_cancel_command.txt</see></remarks>
            public static int CancelCommandsIMG(IntPtr* event_list, nuint num_events_in_list) => CLPointers.clCancelCommandsIMG_Lazy(event_list, num_events_in_list);
            
            /// <summary> <b>[requires: cl_img_use_gralloc_ptr]</b> <b>[entry point: <c>clEnqueueAcquireGrallocObjectsIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">img_use_gralloc_ptr.txt</see></remarks>
            public static int EnqueueAcquireGrallocObjectsIMG(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireGrallocObjectsIMG_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_img_generate_mipmap]</b> <b>[entry point: <c>clEnqueueGenerateMipmapIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">img_generate_mipmap.txt</see></remarks>
            public static int EnqueueGenerateMipmapIMG(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, MipmapFilterModeImg mipmap_filter_mode, nuint* array_region, nuint* mip_region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueGenerateMipmapIMG_Lazy(command_queue, src_image, dst_image, (uint)mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_img_use_gralloc_ptr]</b> <b>[entry point: <c>clEnqueueReleaseGrallocObjectsIMG</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">img_use_gralloc_ptr.txt</see></remarks>
            public static int EnqueueReleaseGrallocObjectsIMG(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseGrallocObjectsIMG_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
        }
        /// <summary>intel extensions.</summary>
        public static unsafe partial class intel
        {
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clCreateAcceleratorINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_accelerator.txt</see></remarks>
            public static IntPtr CreateAcceleratorINTEL(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, void* descriptor, int* errcode_ret) => CLPointers.clCreateAcceleratorINTEL_Lazy(context, (uint)accelerator_type, descriptor_size, descriptor, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_create_buffer_with_properties]</b> <b>[entry point: <c>clCreateBufferWithPropertiesINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_create_buffer_with_properties.txt</see></remarks>
            public static IntPtr CreateBufferWithPropertiesINTEL(IntPtr context, ulong* properties, MemFlags flags, nuint size, void* host_ptr, int* errcode_ret) => CLPointers.clCreateBufferWithPropertiesINTEL_Lazy(context, properties, (ulong)flags, size, host_ptr, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clCreateFromDX9MediaSurfaceINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_dx9_media_sharing.txt</see></remarks>
            public static IntPtr CreateFromDX9MediaSurfaceINTEL(IntPtr context, MemFlags flags, IntPtr* resource, IntPtr sharedHandle, uint plane, int* errcode_ret) => CLPointers.clCreateFromDX9MediaSurfaceINTEL_Lazy(context, (ulong)flags, resource, sharedHandle, plane, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clCreateFromVA_APIMediaSurfaceINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_va_api_media_sharing.txt</see></remarks>
            public static IntPtr CreateFromVA_APIMediaSurfaceINTEL(IntPtr context, MemFlags flags, uint* surface, uint plane, int* errcode_ret) => CLPointers.clCreateFromVA_APIMediaSurfaceINTEL_Lazy(context, (ulong)flags, surface, plane, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clDeviceMemAllocINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static void* DeviceMemAllocINTEL(IntPtr context, IntPtr device, ulong* properties, nuint size, uint alignment, int* errcode_ret) => CLPointers.clDeviceMemAllocINTEL_Lazy(context, device, properties, size, alignment, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueAcquireDX9ObjectsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueAcquireDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireDX9ObjectsINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clEnqueueAcquireVA_APIMediaSurfacesINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_va_api_media_sharing.txt</see></remarks>
            public static int EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireVA_APIMediaSurfacesINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemAdviseINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemAdviseINTEL(IntPtr command_queue, void* ptr, nuint size, uint advice, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemAdviseINTEL_Lazy(command_queue, ptr, size, advice, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemcpyINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemcpyINTEL(IntPtr command_queue, Bool blocking, void* dst_ptr, void* src_ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemcpyINTEL_Lazy(command_queue, (uint)blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemFillINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemFillINTEL(IntPtr command_queue, void* dst_ptr, void* pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemFillINTEL_Lazy(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMemsetINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMemsetINTEL(IntPtr command_queue, void* dst_ptr, int value, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMemsetINTEL_Lazy(command_queue, dst_ptr, value, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clEnqueueMigrateMemINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int EnqueueMigrateMemINTEL(IntPtr command_queue, void* ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueMigrateMemINTEL_Lazy(command_queue, ptr, size, (ulong)flags, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_program_scope_host_pipe]</b> <b>[entry point: <c>clEnqueueReadHostPipeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_program_scope_host_pipe.txt</see></remarks>
            public static int EnqueueReadHostPipeINTEL(IntPtr command_queue, IntPtr program, byte* pipe_symbol, Bool blocking_read, void* ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReadHostPipeINTEL_Lazy(command_queue, program, pipe_symbol, (uint)blocking_read, ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueReleaseDX9ObjectsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueReleaseDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseDX9ObjectsINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clEnqueueReleaseVA_APIMediaSurfacesINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_va_api_media_sharing.txt</see></remarks>
            public static int EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseVA_APIMediaSurfacesINTEL_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_program_scope_host_pipe]</b> <b>[entry point: <c>clEnqueueWriteHostPipeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_program_scope_host_pipe.txt</see></remarks>
            public static int EnqueueWriteHostPipeINTEL(IntPtr command_queue, IntPtr program, byte* pipe_symbol, Bool blocking_write, void* ptr, nuint size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWriteHostPipeINTEL_Lazy(command_queue, program, pipe_symbol, (uint)blocking_write, ptr, size, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clGetAcceleratorInfoINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_accelerator.txt</see></remarks>
            public static int GetAcceleratorInfoINTEL(IntPtr accelerator, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetAcceleratorInfoINTEL_Lazy(accelerator, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_intel_dx9_media_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromDX9INTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_dx9_media_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromDX9INTEL(IntPtr platform, uint dx9_device_source, void* dx9_object, uint dx9_device_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromDX9INTEL_Lazy(platform, dx9_device_source, dx9_object, dx9_device_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_intel_va_api_media_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromVA_APIMediaAdapterINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_va_api_media_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr platform, uint media_adapter_type, void* media_adapter, uint media_adapter_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromVA_APIMediaAdapterINTEL_Lazy(platform, media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clGetMemAllocInfoINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int GetMemAllocInfoINTEL(IntPtr context, void* ptr, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetMemAllocInfoINTEL_Lazy(context, ptr, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_d3d10]</b> <b>[entry point: <c>clGetSupportedD3D10TextureFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_sharing_format_query_d3d10.txt</see></remarks>
            public static int GetSupportedD3D10TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, uint* d3d10_formats, uint* num_texture_formats) => CLPointers.clGetSupportedD3D10TextureFormatsINTEL_Lazy(context, (ulong)flags, image_type, num_entries, d3d10_formats, num_texture_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_d3d11]</b> <b>[entry point: <c>clGetSupportedD3D11TextureFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_sharing_format_query_d3d11.txt</see></remarks>
            public static int GetSupportedD3D11TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, uint* d3d11_formats, uint* num_texture_formats) => CLPointers.clGetSupportedD3D11TextureFormatsINTEL_Lazy(context, (ulong)flags, image_type, plane, num_entries, d3d11_formats, num_texture_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_dx9]</b> <b>[entry point: <c>clGetSupportedDX9MediaSurfaceFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_sharing_format_query_dx9.txt</see></remarks>
            public static int GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, uint* dx9_formats, uint* num_surface_formats) => CLPointers.clGetSupportedDX9MediaSurfaceFormatsINTEL_Lazy(context, (ulong)flags, image_type, plane, num_entries, dx9_formats, num_surface_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_gl]</b> <b>[entry point: <c>clGetSupportedGLTextureFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_sharing_format_query_gl.txt</see></remarks>
            public static int GetSupportedGLTextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, uint* gl_formats, uint* num_texture_formats) => CLPointers.clGetSupportedGLTextureFormatsINTEL_Lazy(context, (ulong)flags, image_type, num_entries, gl_formats, num_texture_formats);
            
            /// <summary> <b>[requires: cl_intel_sharing_format_query_va_api]</b> <b>[entry point: <c>clGetSupportedVA_APIMediaSurfaceFormatsINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_sharing_format_query_va_api.txt</see></remarks>
            public static int GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, VAImageFormat* va_api_formats, uint* num_surface_formats) => CLPointers.clGetSupportedVA_APIMediaSurfaceFormatsINTEL_Lazy(context, (ulong)flags, image_type, plane, num_entries, va_api_formats, num_surface_formats);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clHostMemAllocINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static void* HostMemAllocINTEL(IntPtr context, ulong* properties, nuint size, uint alignment, int* errcode_ret) => CLPointers.clHostMemAllocINTEL_Lazy(context, properties, size, alignment, errcode_ret);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clMemBlockingFreeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int MemBlockingFreeINTEL(IntPtr context, void* ptr) => CLPointers.clMemBlockingFreeINTEL_Lazy(context, ptr);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clMemFreeINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int MemFreeINTEL(IntPtr context, void* ptr) => CLPointers.clMemFreeINTEL_Lazy(context, ptr);
            
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clReleaseAcceleratorINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_accelerator.txt</see></remarks>
            public static int ReleaseAcceleratorINTEL(IntPtr accelerator) => CLPointers.clReleaseAcceleratorINTEL_Lazy(accelerator);
            
            /// <summary> <b>[requires: cl_intel_accelerator]</b> <b>[entry point: <c>clRetainAcceleratorINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_accelerator.txt</see></remarks>
            public static int RetainAcceleratorINTEL(IntPtr accelerator) => CLPointers.clRetainAcceleratorINTEL_Lazy(accelerator);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clSetKernelArgMemPointerINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static int SetKernelArgMemPointerINTEL(IntPtr kernel, uint arg_index, void* arg_value) => CLPointers.clSetKernelArgMemPointerINTEL_Lazy(kernel, arg_index, arg_value);
            
            /// <summary> <b>[requires: cl_intel_unified_shared_memory]</b> <b>[entry point: <c>clSharedMemAllocINTEL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">intel_unified_shared_memory.txt</see></remarks>
            public static void* SharedMemAllocINTEL(IntPtr context, IntPtr device, ulong* properties, nuint size, uint alignment, int* errcode_ret) => CLPointers.clSharedMemAllocINTEL_Lazy(context, device, properties, size, alignment, errcode_ret);
            
        }
        /// <summary>khr extensions.</summary>
        public static unsafe partial class khr
        {
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandBarrierWithWaitListKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandBarrierWithWaitListKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandBarrierWithWaitListKHR_Lazy(command_buffer, command_queue, properties, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyBufferKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyBufferKHR_Lazy(command_buffer, command_queue, properties, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyBufferRectKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyBufferRectKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_buffer, IntPtr dst_buffer, nuint* src_origin, nuint* dst_origin, nuint* region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyBufferRectKHR_Lazy(command_buffer, command_queue, properties, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyBufferToImageKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyBufferToImageKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint* dst_origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyBufferToImageKHR_Lazy(command_buffer, command_queue, properties, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyImageKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyImageKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_image, IntPtr dst_image, nuint* src_origin, nuint* dst_origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyImageKHR_Lazy(command_buffer, command_queue, properties, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandCopyImageToBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandCopyImageToBufferKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr src_image, IntPtr dst_buffer, nuint* src_origin, nuint* region, nuint dst_offset, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandCopyImageToBufferKHR_Lazy(command_buffer, command_queue, properties, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandFillBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandFillBufferKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr buffer, void* pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandFillBufferKHR_Lazy(command_buffer, command_queue, properties, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandFillImageKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandFillImageKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr image, void* fill_color, nuint* origin, nuint* region, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandFillImageKHR_Lazy(command_buffer, command_queue, properties, image, fill_color, origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandNDRangeKernelKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandNDRangeKernelKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* local_work_size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandNDRangeKernelKHR_Lazy(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandSVMMemcpyKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandSVMMemcpyKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, void* dst_ptr, void* src_ptr, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandSVMMemcpyKHR_Lazy(command_buffer, command_queue, properties, dst_ptr, src_ptr, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCommandSVMMemFillKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int CommandSVMMemFillKHR(IntPtr command_buffer, IntPtr command_queue, ulong* properties, void* svm_ptr, void* pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, uint* sync_point_wait_list, uint* sync_point, IntPtr* mutable_handle) => CLPointers.clCommandSVMMemFillKHR_Lazy(command_buffer, command_queue, properties, svm_ptr, pattern, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clCreateCommandBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static IntPtr CreateCommandBufferKHR(uint num_queues, IntPtr* queues, ulong* properties, int* errcode_ret) => CLPointers.clCreateCommandBufferKHR_Lazy(num_queues, queues, properties, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_create_command_queue]</b> <b>[entry point: <c>clCreateCommandQueueWithPropertiesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_create_command_queue.txt</see></remarks>
            public static IntPtr CreateCommandQueueWithPropertiesKHR(IntPtr context, IntPtr device, ulong* properties, int* errcode_ret) => CLPointers.clCreateCommandQueueWithPropertiesKHR_Lazy(context, device, properties, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_egl_event]</b> <b>[entry point: <c>clCreateEventFromEGLSyncKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_egl_event.txt</see></remarks>
            public static IntPtr CreateEventFromEGLSyncKHR(IntPtr context, void* sync, void* display, int* errcode_ret) => CLPointers.clCreateEventFromEGLSyncKHR_Lazy(context, sync, display, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_event]</b> <b>[entry point: <c>clCreateEventFromGLsyncKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_event.txt</see></remarks>
            public static IntPtr CreateEventFromGLsyncKHR(IntPtr context, IntPtr sync, int* errcode_ret) => CLPointers.clCreateEventFromGLsyncKHR_Lazy(context, sync, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clCreateFromD3D10BufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d10_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D10BufferKHR(IntPtr context, MemFlags flags, IntPtr* resource, int* errcode_ret) => CLPointers.clCreateFromD3D10BufferKHR_Lazy(context, (ulong)flags, resource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clCreateFromD3D10Texture2DKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d10_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D10Texture2DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D10Texture2DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clCreateFromD3D10Texture3DKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d10_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D10Texture3DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D10Texture3DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clCreateFromD3D11BufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d11_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D11BufferKHR(IntPtr context, MemFlags flags, IntPtr* resource, int* errcode_ret) => CLPointers.clCreateFromD3D11BufferKHR_Lazy(context, (ulong)flags, resource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clCreateFromD3D11Texture2DKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d11_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D11Texture2DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D11Texture2DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clCreateFromD3D11Texture3DKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d11_sharing.txt</see></remarks>
            public static IntPtr CreateFromD3D11Texture3DKHR(IntPtr context, MemFlags flags, IntPtr* resource, uint subresource, int* errcode_ret) => CLPointers.clCreateFromD3D11Texture3DKHR_Lazy(context, (ulong)flags, resource, subresource, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clCreateFromDX9MediaSurfaceKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_dx9_media_sharing.txt</see></remarks>
            public static IntPtr CreateFromDX9MediaSurfaceKHR(IntPtr context, MemFlags flags, uint adapter_type, void* surface_info, uint plane, int* errcode_ret) => CLPointers.clCreateFromDX9MediaSurfaceKHR_Lazy(context, (ulong)flags, adapter_type, surface_info, plane, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_egl_image]</b> <b>[entry point: <c>clCreateFromEGLImageKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_egl_image.txt</see></remarks>
            public static IntPtr CreateFromEGLImageKHR(IntPtr context, void* egldisplay, void* eglimage, MemFlags flags, IntPtr* properties, int* errcode_ret) => CLPointers.clCreateFromEGLImageKHR_Lazy(context, egldisplay, eglimage, (ulong)flags, properties, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLBuffer</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLBuffer(IntPtr context, MemFlags flags, uint bufobj, int* errcode_ret) => CLPointers.clCreateFromGLBuffer_Lazy(context, (ulong)flags, bufobj, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLRenderbuffer</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLRenderbuffer(IntPtr context, MemFlags flags, uint renderbuffer, int* errcode_ret) => CLPointers.clCreateFromGLRenderbuffer_Lazy(context, (ulong)flags, renderbuffer, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLTexture</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLTexture(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int* errcode_ret) => CLPointers.clCreateFromGLTexture_Lazy(context, (ulong)flags, target, miplevel, texture, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLTexture2D</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLTexture2D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int* errcode_ret) => CLPointers.clCreateFromGLTexture2D_Lazy(context, (ulong)flags, target, miplevel, texture, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clCreateFromGLTexture3D</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static IntPtr CreateFromGLTexture3D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int* errcode_ret) => CLPointers.clCreateFromGLTexture3D_Lazy(context, (ulong)flags, target, miplevel, texture, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_il_program]</b> <b>[entry point: <c>clCreateProgramWithILKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_il_program.txt</see></remarks>
            public static IntPtr CreateProgramWithILKHR(IntPtr context, void* il, nuint length, int* errcode_ret) => CLPointers.clCreateProgramWithILKHR_Lazy(context, il, length, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clCreateSemaphoreWithPropertiesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_semaphore.txt</see></remarks>
            public static IntPtr CreateSemaphoreWithPropertiesKHR(IntPtr context, ulong* sema_props, int* errcode_ret) => CLPointers.clCreateSemaphoreWithPropertiesKHR_Lazy(context, sema_props, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clEnqueueAcquireD3D10ObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d10_sharing.txt</see></remarks>
            public static int EnqueueAcquireD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireD3D10ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clEnqueueAcquireD3D11ObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d11_sharing.txt</see></remarks>
            public static int EnqueueAcquireD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireD3D11ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueAcquireDX9MediaSurfacesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueAcquireDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireDX9MediaSurfacesKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_egl_image]</b> <b>[entry point: <c>clEnqueueAcquireEGLObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_egl_image.txt</see></remarks>
            public static int EnqueueAcquireEGLObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireEGLObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_external_memory]</b> <b>[entry point: <c>clEnqueueAcquireExternalMemObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_external_memory.txt</see></remarks>
            public static int EnqueueAcquireExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireExternalMemObjectsKHR_Lazy(command_queue, num_mem_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clEnqueueAcquireGLObjects</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static int EnqueueAcquireGLObjects(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueAcquireGLObjects_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clEnqueueCommandBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int EnqueueCommandBufferKHR(uint num_queues, IntPtr* queues, IntPtr command_buffer, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueCommandBufferKHR_Lazy(num_queues, queues, command_buffer, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clEnqueueReleaseD3D10ObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d10_sharing.txt</see></remarks>
            public static int EnqueueReleaseD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseD3D10ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clEnqueueReleaseD3D11ObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d11_sharing.txt</see></remarks>
            public static int EnqueueReleaseD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseD3D11ObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clEnqueueReleaseDX9MediaSurfacesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_dx9_media_sharing.txt</see></remarks>
            public static int EnqueueReleaseDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseDX9MediaSurfacesKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_egl_image]</b> <b>[entry point: <c>clEnqueueReleaseEGLObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_egl_image.txt</see></remarks>
            public static int EnqueueReleaseEGLObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseEGLObjectsKHR_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_external_memory]</b> <b>[entry point: <c>clEnqueueReleaseExternalMemObjectsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_external_memory.txt</see></remarks>
            public static int EnqueueReleaseExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseExternalMemObjectsKHR_Lazy(command_queue, num_mem_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clEnqueueReleaseGLObjects</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static int EnqueueReleaseGLObjects(IntPtr command_queue, uint num_objects, IntPtr* mem_objects, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueReleaseGLObjects_Lazy(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clEnqueueSignalSemaphoresKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_semaphore.txt</see></remarks>
            public static int EnqueueSignalSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, IntPtr* sema_objects, ulong* sema_payload_list, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueSignalSemaphoresKHR_Lazy(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clEnqueueWaitSemaphoresKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_semaphore.txt</see></remarks>
            public static int EnqueueWaitSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, IntPtr* sema_objects, ulong* sema_payload_list, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event) => CLPointers.clEnqueueWaitSemaphoresKHR_Lazy(command_queue, num_sema_objects, sema_objects, sema_payload_list, num_events_in_wait_list, event_wait_list, @event);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clFinalizeCommandBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int FinalizeCommandBufferKHR(IntPtr command_buffer) => CLPointers.clFinalizeCommandBufferKHR_Lazy(command_buffer);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clGetCommandBufferInfoKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int GetCommandBufferInfoKHR(IntPtr command_buffer, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetCommandBufferInfoKHR_Lazy(command_buffer, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_d3d10_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromD3D10KHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d10_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromD3D10KHR(IntPtr platform, uint d3d_device_source, void* d3d_object, uint d3d_device_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromD3D10KHR_Lazy(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_khr_d3d11_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromD3D11KHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_d3d11_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromD3D11KHR(IntPtr platform, uint d3d_device_source, void* d3d_object, uint d3d_device_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromD3D11KHR_Lazy(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_khr_dx9_media_sharing]</b> <b>[entry point: <c>clGetDeviceIDsFromDX9MediaAdapterKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_dx9_media_sharing.txt</see></remarks>
            public static int GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr platform, uint num_media_adapters, uint* media_adapter_type, void* media_adapters, uint media_adapter_set, uint num_entries, IntPtr* devices, uint* num_devices) => CLPointers.clGetDeviceIDsFromDX9MediaAdapterKHR_Lazy(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, devices, num_devices);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clGetGLContextInfoKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static int GetGLContextInfoKHR(IntPtr* properties, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetGLContextInfoKHR_Lazy(properties, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clGetGLObjectInfo</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static int GetGLObjectInfo(IntPtr memobj, uint* gl_object_type, uint* gl_object_name) => CLPointers.clGetGLObjectInfo_Lazy(memobj, gl_object_type, gl_object_name);
            
            /// <summary> <b>[requires: cl_khr_gl_sharing]</b> <b>[entry point: <c>clGetGLTextureInfo</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_gl_sharing.txt</see></remarks>
            public static int GetGLTextureInfo(IntPtr memobj, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetGLTextureInfo_Lazy(memobj, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_subgroups]</b> <b>[entry point: <c>clGetKernelSubGroupInfoKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_subgroups.txt</see></remarks>
            public static int GetKernelSubGroupInfoKHR(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, void* input_value, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetKernelSubGroupInfoKHR_Lazy(in_kernel, in_device, param_name, input_value_size, input_value, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_suggested_local_work_size]</b> <b>[entry point: <c>clGetKernelSuggestedLocalWorkSizeKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_suggested_local_work_size.txt</see></remarks>
            public static int GetKernelSuggestedLocalWorkSizeKHR(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint* global_work_offset, nuint* global_work_size, nuint* suggested_local_work_size) => CLPointers.clGetKernelSuggestedLocalWorkSizeKHR_Lazy(command_queue, kernel, work_dim, global_work_offset, global_work_size, suggested_local_work_size);
            
            /// <summary> <b>[requires: cl_khr_command_buffer_mutable_dispatch]</b> <b>[entry point: <c>clGetMutableCommandInfoKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer_mutable_dispatch.txt</see></remarks>
            public static int GetMutableCommandInfoKHR(IntPtr command, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetMutableCommandInfoKHR_Lazy(command, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_external_semaphore]</b> <b>[entry point: <c>clGetSemaphoreHandleForTypeKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_external_semaphore.txt</see></remarks>
            public static int GetSemaphoreHandleForTypeKHR(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, void* handle_ptr, nuint* handle_size_ret) => CLPointers.clGetSemaphoreHandleForTypeKHR_Lazy(sema_object, device, handle_type, handle_size, handle_ptr, handle_size_ret);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clGetSemaphoreInfoKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_semaphore.txt</see></remarks>
            public static int GetSemaphoreInfoKHR(IntPtr sema_object, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetSemaphoreInfoKHR_Lazy(sema_object, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clGetSVMPointerInfoKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_unified_svm.txt</see></remarks>
            public static int GetSVMPointerInfoKHR(IntPtr context, IntPtr device, void* ptr, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetSVMPointerInfoKHR_Lazy(context, device, ptr, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clGetSVMSuggestedTypeIndexKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_unified_svm.txt</see></remarks>
            public static int GetSVMSuggestedTypeIndexKHR(IntPtr context, SvmCapabilitiesKhr required_capabilities, SvmCapabilitiesKhr desired_capabilities, ulong* properties, nuint size, uint* suggested_svm_type_index) => CLPointers.clGetSVMSuggestedTypeIndexKHR_Lazy(context, (ulong)required_capabilities, (ulong)desired_capabilities, properties, size, suggested_svm_type_index);
            
            /// <summary> <b>[requires: cl_khr_icd]</b> <b>[entry point: <c>clIcdGetFunctionAddressForPlatformKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_icd.txt</see></remarks>
            public static void* IcdGetFunctionAddressForPlatformKHR(IntPtr platform, byte* func_name) => CLPointers.clIcdGetFunctionAddressForPlatformKHR_Lazy(platform, func_name);
            
            /// <summary> <b>[requires: cl_khr_icd]</b> <b>[entry point: <c>clIcdGetPlatformIDsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_icd.txt</see></remarks>
            public static int IcdGetPlatformIDsKHR(uint num_entries, IntPtr* platforms, uint* num_platforms) => CLPointers.clIcdGetPlatformIDsKHR_Lazy(num_entries, platforms, num_platforms);
            
            /// <summary> <b>[requires: cl_khr_icd]</b> <b>[entry point: <c>clIcdSetPlatformDispatchDataKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_icd.txt</see></remarks>
            public static int IcdSetPlatformDispatchDataKHR(IntPtr platform, void* dispatch_data) => CLPointers.clIcdSetPlatformDispatchDataKHR_Lazy(platform, dispatch_data);
            
            /// <summary> <b>[requires: cl_khr_external_semaphore_sync_fd]</b> <b>[entry point: <c>clReImportSemaphoreSyncFdKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_external_semaphore_sync_fd.txt</see></remarks>
            public static int ReImportSemaphoreSyncFdKHR(IntPtr sema_object, ulong* reimport_props, int fd) => CLPointers.clReImportSemaphoreSyncFdKHR_Lazy(sema_object, reimport_props, fd);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clReleaseCommandBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int ReleaseCommandBufferKHR(IntPtr command_buffer) => CLPointers.clReleaseCommandBufferKHR_Lazy(command_buffer);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clReleaseSemaphoreKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_semaphore.txt</see></remarks>
            public static int ReleaseSemaphoreKHR(IntPtr sema_object) => CLPointers.clReleaseSemaphoreKHR_Lazy(sema_object);
            
            /// <summary> <b>[requires: cl_khr_command_buffer_multi_device]</b> <b>[entry point: <c>clRemapCommandBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer_multi_device.txt</see></remarks>
            public static IntPtr RemapCommandBufferKHR(IntPtr command_buffer, Bool automatic, uint num_queues, IntPtr* queues, uint num_handles, IntPtr* handles, IntPtr* handles_ret, int* errcode_ret) => CLPointers.clRemapCommandBufferKHR_Lazy(command_buffer, (uint)automatic, num_queues, queues, num_handles, handles, handles_ret, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_command_buffer]</b> <b>[entry point: <c>clRetainCommandBufferKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer.txt</see></remarks>
            public static int RetainCommandBufferKHR(IntPtr command_buffer) => CLPointers.clRetainCommandBufferKHR_Lazy(command_buffer);
            
            /// <summary> <b>[requires: cl_khr_semaphore]</b> <b>[entry point: <c>clRetainSemaphoreKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_semaphore.txt</see></remarks>
            public static int RetainSemaphoreKHR(IntPtr sema_object) => CLPointers.clRetainSemaphoreKHR_Lazy(sema_object);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clSVMAllocWithPropertiesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_unified_svm.txt</see></remarks>
            public static void* SVMAllocWithPropertiesKHR(IntPtr context, ulong* properties, uint svm_type_index, nuint size, int* errcode_ret) => CLPointers.clSVMAllocWithPropertiesKHR_Lazy(context, properties, svm_type_index, size, errcode_ret);
            
            /// <summary> <b>[requires: cl_khr_unified_svm]</b> <b>[entry point: <c>clSVMFreeWithPropertiesKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_unified_svm.txt</see></remarks>
            public static int SVMFreeWithPropertiesKHR(IntPtr context, ulong* properties, ulong flags, void* ptr) => CLPointers.clSVMFreeWithPropertiesKHR_Lazy(context, properties, flags, ptr);
            
            /// <summary> <b>[requires: cl_khr_terminate_context]</b> <b>[entry point: <c>clTerminateContextKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_terminate_context.txt</see></remarks>
            public static int TerminateContextKHR(IntPtr context) => CLPointers.clTerminateContextKHR_Lazy(context);
            
            /// <summary> <b>[requires: cl_khr_command_buffer_mutable_dispatch]</b> <b>[entry point: <c>clUpdateMutableCommandsKHR</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">khr_command_buffer_mutable_dispatch.txt</see></remarks>
            public static int UpdateMutableCommandsKHR(IntPtr command_buffer, uint num_configs, CommandBufferUpdateTypeKhr* config_types, void** configs) => CLPointers.clUpdateMutableCommandsKHR_Lazy(command_buffer, num_configs, (uint*)config_types, configs);
            
        }
        /// <summary>loader extensions.</summary>
        public static unsafe partial class loader
        {
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clDeinitLayer</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">loader_layers.txt</see></remarks>
            public static int DeinitLayer() => CLPointers.clDeinitLayer_Lazy();
            
            /// <summary> <b>[requires: cl_loader_info]</b> <b>[entry point: <c>clGetICDLoaderInfoOCLICD</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">loader_info.txt</see></remarks>
            public static int GetICDLoaderInfoOCLICD(IcdlInfo param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetICDLoaderInfoOCLICD_Lazy((uint)param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clGetLayerInfo</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">loader_layers.txt</see></remarks>
            public static int GetLayerInfo(uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetLayerInfo_Lazy(param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clInitLayer</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">loader_layers.txt</see></remarks>
            public static int InitLayer(uint num_entries, IntPtr target_dispatch, uint* num_entries_ret, IntPtr* layer_dispatch_ret) => CLPointers.clInitLayer_Lazy(num_entries, target_dispatch, num_entries_ret, layer_dispatch_ret);
            
            /// <summary> <b>[requires: cl_loader_layers]</b> <b>[entry point: <c>clInitLayerWithProperties</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">loader_layers.txt</see></remarks>
            public static int InitLayerWithProperties(uint num_entries, IntPtr target_dispatch, uint* num_entries_ret, IntPtr* layer_dispatch_ret, ulong* properties) => CLPointers.clInitLayerWithProperties_Lazy(num_entries, target_dispatch, num_entries_ret, layer_dispatch_ret, properties);
            
        }
        /// <summary>pocl extensions.</summary>
        public static unsafe partial class pocl
        {
            /// <summary> <b>[requires: cl_pocl_content_size]</b> <b>[entry point: <c>clSetContentSizeBufferPoCL</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">pocl_content_size.txt</see></remarks>
            public static int SetContentSizeBufferPoCL(IntPtr buffer, IntPtr content_size_buffer) => CLPointers.clSetContentSizeBufferPoCL_Lazy(buffer, content_size_buffer);
            
        }
        /// <summary>qcom extensions.</summary>
        public static unsafe partial class qcom
        {
            /// <summary> <b>[requires: cl_qcom_ext_host_ptr]</b> <b>[entry point: <c>clGetDeviceImageInfoQCOM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">qcom_ext_host_ptr.txt</see></remarks>
            public static int GetDeviceImageInfoQCOM(IntPtr device, nuint image_width, nuint image_height, cl_image_format* image_format, uint param_name, nuint param_value_size, void* param_value, nuint* param_value_size_ret) => CLPointers.clGetDeviceImageInfoQCOM_Lazy(device, image_width, image_height, image_format, param_name, param_value_size, param_value, param_value_size_ret);
            
            /// <summary> <b>[requires: cl_qcom_perf_hint]</b> <b>[entry point: <c>clSetPerfHintQCOM</c>]</b><br/>  </summary>
            /// <remarks><see href="TODO: Proper link">qcom_perf_hint.txt</see></remarks>
            public static int SetPerfHintQCOM(IntPtr context, uint perf_hint) => CLPointers.clSetPerfHintQCOM_Lazy(context, perf_hint);
            
        }
    }
}
