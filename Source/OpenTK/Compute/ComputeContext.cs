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
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenTK.Compute
{
    using cl_context = IntPtr;
    using cl_device_id = IntPtr;

    #region Flat API

    partial class CL
    {
        // OpenCL 1.0
        public delegate void NotifyContext(string errinfo,
            /* const void * */ IntPtr private_info,
            /* size_t */ IntPtr cb,
            /* void * */ IntPtr user_data);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateContext")]
        public static extern cl_context CreateContext(
           IntPtr[] properties,
           int num_devices,
           cl_device_id[] devices,
           [MarshalAs(UnmanagedType.FunctionPtr)] NotifyContext pfn_notify,
           IntPtr user_data, // void*
           out ErrorCode errorcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateContextFromType")]
        public static extern cl_context CreateContextFromType(
           IntPtr[] properties,
           DeviceType device_type,
           int num_devices,
           cl_device_id[] devices,
           [MarshalAs(UnmanagedType.FunctionPtr)] NotifyContext pfn_notify,
            /* void * */ IntPtr user_data,
           out ErrorCode errorcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clRetainContext")]
        public static extern int RetainContext(cl_context context);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clReleaseContext")]
        public static extern int ReleaseContext(cl_context context);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetContextInfo")]
        public static extern int GetContextInfo(cl_context context,
            ContextInfo param_name,
            /* size_t */ IntPtr param_value_size,
            /* void * */ IntPtr param_value,
            /* size_t * */ out IntPtr param_value_size_ret);
    }

    #endregion
}
