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

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Compute
{
    using cl_command_queue = IntPtr;
    using cl_context = IntPtr;
    using cl_device_id = IntPtr;
    using cl_event = IntPtr;
    using cl_mem = IntPtr;

    #region Flat API

    public partial class CL
    {
        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateCommandQueue")]
        public static extern cl_command_queue CreateCommandQueue(cl_context context,
            cl_device_id device,
            CommandQueueProperties properties,
            out ErrorCode errorcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clRetainCommandQueue")]
        public static extern int RetainCommandQueue(cl_command_queue command_queue);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clReleaseCommandQueue")]
        public static extern int ReleaseCommandQueue(cl_command_queue command_queue);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetCommandQueueInfo")]
        public static extern int GetCommandQueueInfo(cl_command_queue command_queue,
            CommandQueueInfo param_name,
            /* size_t */ IntPtr param_value_size,
            /* void * */ IntPtr param_value,
            /* size_t * */ out IntPtr param_value_size_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clSetCommandQueueProperty")]
        public static extern int SetCommandQueueProperty(cl_command_queue command_queue,
           CommandQueueProperties properties,
           bool enable,
           out CommandQueueProperties old_properties);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueReadBuffer")]
        public static extern int EnqueueReadBuffer(cl_command_queue command_queue,
           cl_mem buffer,
           bool blocking_read,
            /* size_t */ IntPtr offset,
            /* size_t */ IntPtr cb,
           /* void * */ IntPtr ptr,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueWriteBuffer")]
        public static extern int EnqueueWriteBuffer(cl_command_queue command_queue,
           cl_mem buffer,
           bool blocking_write,
            /* size_t */ IntPtr offset,
            /* size_t */ IntPtr cb,
           /* void * */ IntPtr ptr,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyBuffer")]
        public static extern int EnqueueCopyBuffer(cl_command_queue command_queue,
           cl_mem src_buffer,
           cl_mem dst_buffer,
            /* size_t */ IntPtr src_offset,
            /* size_t */ IntPtr dst_offset,
            /* size_t */ IntPtr cb,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueReadImage")]
        public static extern int EnqueueReadImage(cl_command_queue command_queue,
          cl_mem image,
          bool blocking_read,
          [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] origin,
          [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
            /* size_t */ IntPtr row_pitch,
            /* size_t */ IntPtr slice_pitch,
          /* void * */ IntPtr ptr,
          int num_events_in_wait_list,
          cl_event[] event_wait_list,
          ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueWriteImage")]
        public static extern int EnqueueWriteImage(cl_command_queue command_queue,
          cl_mem image,
          bool blocking_write,
          [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] origin,
          [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
            /* size_t */ IntPtr input_row_pitch,
            /* size_t */ IntPtr input_slice_pitch,
            /* void * */ IntPtr ptr,
          int num_events_in_wait_list,
          cl_event[] event_wait_list,
          ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyImage")]
        public static extern int EnqueueCopyImage(cl_command_queue command_queue,
           cl_mem src_image,
           cl_mem dst_image,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] src_origin,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] dst_origin,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyImageToBuffer")]
        public static extern int EnqueueCopyImageToBuffer(cl_command_queue command_queue,
           cl_mem src_image,
           cl_mem dst_buffer,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] src_origin,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
            /* size_t */ IntPtr dst_offset,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyBufferToImage")]
        public static extern int EnqueueCopyBufferToImage(cl_command_queue command_queue,
           cl_mem src_buffer,
           cl_mem dst_image,
            /* size_t */ IntPtr src_offset,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] dst_origin,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueMapBuffer")]
        public static extern IntPtr EnqueueMapBuffer(cl_command_queue command_queue,
           cl_mem buffer,
           bool blocking_map,
           MapFlags map_flags,
            /* size_t */ IntPtr offset,
            /* size_t */ IntPtr cb,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event,
           out ErrorCode errorcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clEnqueueMapImage")]
        public static extern IntPtr EnqueueMapImage(cl_command_queue command_queue,
           cl_mem image,
           bool blocking_map,
           MapFlags map_flags,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] origin,
           [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
            /* size_t * */ out IntPtr image_row_pitch,
            /* size_t * */ out IntPtr image_slice_pitch,
           int num_events_in_wait_list,
           cl_event[] event_wait_list,
           ref cl_event @event,
           out ErrorCode errorcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clFlush")]
        public static extern int Flush(cl_command_queue command_queue);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clFinish")]
        public static extern int Finish(cl_command_queue command_queue);
    }

    #endregion
}
