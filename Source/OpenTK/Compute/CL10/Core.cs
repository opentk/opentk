#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

namespace OpenTK.Compute.CL10
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class CL
    {

        internal static partial class Core
        {

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clBuildProgram", ExactSpelling = true)]
            internal extern static unsafe int BuildProgram(IntPtr program, uint num_devices, IntPtr* device_list, String options, IntPtr pfn_notify, IntPtr user_data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateBuffer", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateBuffer(IntPtr context, MemFlags flags, IntPtr size, IntPtr host_ptr, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateCommandQueue", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueFlags properties, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateContext", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateContext(IntPtr* properties, uint num_devices, IntPtr* devices, IntPtr pfn_notify, IntPtr user_data, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateContextFromType", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateContextFromType(IntPtr* properties, DeviceTypeFlags device_type, IntPtr pfn_notify, IntPtr user_data, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateImage2D", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateImage2D(IntPtr context, MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, IntPtr host_ptr, [OutAttribute] int* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateImage3D", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateImage3D(IntPtr context, MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr host_ptr, [OutAttribute] int* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateKernel", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateKernel(IntPtr program, String kernel_name, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateKernelsInProgram", ExactSpelling = true)]
            internal extern static unsafe int CreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr* kernels, [OutAttribute] uint* num_kernels_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateProgramWithBinary", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr* device_list, IntPtr* lengths, byte** binaries, int* binary_status, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateProgramWithSource", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateProgramWithSource(IntPtr context, uint count, String[] strings, IntPtr* lengths, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clCreateSampler", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateSampler(IntPtr context, bool normalized_coords, AddressingMode addressing_mode, FilterMode filter_mode, [OutAttribute] int* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueBarrier", ExactSpelling = true)]
            internal extern static int EnqueueBarrier(IntPtr command_queue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueCopyBuffer", ExactSpelling = true)]
            internal extern static unsafe int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, IntPtr src_offset, IntPtr dst_offset, IntPtr cb, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueCopyBufferToImage", ExactSpelling = true)]
            internal extern static unsafe int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, IntPtr src_offset, IntPtr** dst_origin, IntPtr** region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueCopyImage", ExactSpelling = true)]
            internal extern static unsafe int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, IntPtr** src_origin, IntPtr** dst_origin, IntPtr** region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueCopyImageToBuffer", ExactSpelling = true)]
            internal extern static unsafe int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, IntPtr** src_origin, IntPtr** region, IntPtr dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueMapBuffer", ExactSpelling = true)]
            internal extern static unsafe System.IntPtr EnqueueMapBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_map, MapFlags map_flags, IntPtr offset, IntPtr cb, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, [OutAttribute] int* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueMapImage", ExactSpelling = true)]
            internal extern static unsafe System.IntPtr EnqueueMapImage(IntPtr command_queue, IntPtr image, bool blocking_map, MapFlags map_flags, IntPtr** origin, IntPtr** region, IntPtr* image_row_pitch, IntPtr* image_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, [OutAttribute] int* errcode_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueMarker", ExactSpelling = true)]
            internal extern static unsafe int EnqueueMarker(IntPtr command_queue, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueNativeKernel", ExactSpelling = true)]
            internal extern static unsafe int EnqueueNativeKernel(IntPtr command_queue, IntPtr user_func, IntPtr args, IntPtr cb_args, uint num_mem_objects, IntPtr* mem_list, IntPtr args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueNDRangeKernel", ExactSpelling = true)]
            internal extern static unsafe int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, IntPtr* global_work_offset, IntPtr* global_work_size, IntPtr* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueReadBuffer", ExactSpelling = true)]
            internal extern static unsafe int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, IntPtr offset, IntPtr cb, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueReadImage", ExactSpelling = true)]
            internal extern static unsafe int EnqueueReadImage(IntPtr command_queue, IntPtr image, bool blocking_read, IntPtr** origin, IntPtr** region, IntPtr row_pitch, IntPtr slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueTask", ExactSpelling = true)]
            internal extern static unsafe int EnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueUnmapMemObject", ExactSpelling = true)]
            internal extern static unsafe int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueWaitForEvents", ExactSpelling = true)]
            internal extern static unsafe int EnqueueWaitForEvents(IntPtr command_queue, uint num_events, IntPtr* event_list);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueWriteBuffer", ExactSpelling = true)]
            internal extern static unsafe int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, IntPtr offset, IntPtr cb, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clEnqueueWriteImage", ExactSpelling = true)]
            internal extern static unsafe int EnqueueWriteImage(IntPtr command_queue, IntPtr image, bool blocking_write, IntPtr** origin, IntPtr** region, IntPtr input_row_pitch, IntPtr input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clFinish", ExactSpelling = true)]
            internal extern static int Finish(IntPtr command_queue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clFlush", ExactSpelling = true)]
            internal extern static int Flush(IntPtr command_queue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetCommandQueueInfo", ExactSpelling = true)]
            internal extern static unsafe int GetCommandQueueInfo(IntPtr command_queue, CommandQueueInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetContextInfo", ExactSpelling = true)]
            internal extern static unsafe int GetContextInfo(IntPtr context, ContextInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetDeviceIDs", ExactSpelling = true)]
            internal extern static unsafe int GetDeviceIDs(IntPtr platform, DeviceTypeFlags device_type, uint num_entries, IntPtr* devices, uint* num_devices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetDeviceInfo", ExactSpelling = true)]
            internal extern static unsafe int GetDeviceInfo(IntPtr device, DeviceInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetEventInfo", ExactSpelling = true)]
            internal extern static unsafe int GetEventInfo(IntPtr @event, EventInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetEventProfilingInfo", ExactSpelling = true)]
            internal extern static unsafe int GetEventProfilingInfo(IntPtr @event, ProfilingInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetImageInfo", ExactSpelling = true)]
            internal extern static unsafe int GetImageInfo(IntPtr image, ImageInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetKernelInfo", ExactSpelling = true)]
            internal extern static unsafe int GetKernelInfo(IntPtr kernel, KernelInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetKernelWorkGroupInfo", ExactSpelling = true)]
            internal extern static unsafe int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetMemObjectInfo", ExactSpelling = true)]
            internal extern static unsafe int GetMemObjectInfo(IntPtr memobj, MemInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetPlatformIDs", ExactSpelling = true)]
            internal extern static unsafe int GetPlatformIDs(uint num_entries, IntPtr* platforms, uint* num_platforms);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetPlatformInfo", ExactSpelling = true)]
            internal extern static unsafe int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetProgramBuildInfo", ExactSpelling = true)]
            internal extern static unsafe int GetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetProgramInfo", ExactSpelling = true)]
            internal extern static unsafe int GetProgramInfo(IntPtr program, ProgramInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetSamplerInfo", ExactSpelling = true)]
            internal extern static unsafe int GetSamplerInfo(IntPtr sampler, SamplerInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clGetSupportedImageFormats", ExactSpelling = true)]
            internal extern static unsafe int GetSupportedImageFormats(IntPtr context, MemFlags flags, MemObjectType image_type, uint num_entries, ImageFormat* image_formats, uint* num_image_formats);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clReleaseCommandQueue", ExactSpelling = true)]
            internal extern static int ReleaseCommandQueue(IntPtr command_queue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clReleaseContext", ExactSpelling = true)]
            internal extern static int ReleaseContext(IntPtr context);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clReleaseEvent", ExactSpelling = true)]
            internal extern static int ReleaseEvent(IntPtr @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clReleaseKernel", ExactSpelling = true)]
            internal extern static int ReleaseKernel(IntPtr kernel);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clReleaseMemObject", ExactSpelling = true)]
            internal extern static int ReleaseMemObject(IntPtr memobj);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clReleaseProgram", ExactSpelling = true)]
            internal extern static int ReleaseProgram(IntPtr program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clReleaseSampler", ExactSpelling = true)]
            internal extern static int ReleaseSampler(IntPtr sampler);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clRetainCommandQueue", ExactSpelling = true)]
            internal extern static int RetainCommandQueue(IntPtr command_queue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clRetainContext", ExactSpelling = true)]
            internal extern static int RetainContext(IntPtr context);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clRetainEvent", ExactSpelling = true)]
            internal extern static int RetainEvent(IntPtr @event);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clRetainKernel", ExactSpelling = true)]
            internal extern static int RetainKernel(IntPtr kernel);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clRetainMemObject", ExactSpelling = true)]
            internal extern static int RetainMemObject(IntPtr memobj);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clRetainProgram", ExactSpelling = true)]
            internal extern static int RetainProgram(IntPtr program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clRetainSampler", ExactSpelling = true)]
            internal extern static int RetainSampler(IntPtr sampler);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clSetCommandQueueProperty", ExactSpelling = true)]
            internal extern static unsafe int SetCommandQueueProperty(IntPtr command_queue, CommandQueueFlags properties, bool enable, CommandQueueFlags* old_properties);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clSetKernelArg", ExactSpelling = true)]
            internal extern static int SetKernelArg(IntPtr kernel, uint arg_index, IntPtr arg_size, IntPtr arg_value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clUnloadCompiler", ExactSpelling = true)]
            internal extern static int UnloadCompiler();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(CL.Library, EntryPoint = "clWaitForEvents", ExactSpelling = true)]
            internal extern static unsafe int WaitForEvents(uint num_events, IntPtr* event_list);
        }
    }
}
