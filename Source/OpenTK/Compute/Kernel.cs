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
    using cl_device_id = IntPtr;
    using cl_kernel = IntPtr;
    using cl_program = IntPtr;

    #region Flat API

    partial class CL
    {
        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateKernel")]
        public static extern cl_kernel CreateKernel(cl_program program,
            string kernel_name,
            out int errcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateKernelsInProgram")]
        public static extern int CreateKernels(cl_program program,
            int num_kernels,
            cl_kernel[] kernels,
            out int num_kernels_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clRetainKernel")]
        public static extern int RetainKernel(cl_kernel kernel);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clReleaseKernel")]
        public static extern int ReleaseKernel(cl_kernel kernel);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clSetKernelArg")]
        public static extern int SetKernelArg(cl_kernel kernel,
            int arg_index,
            /* size_t */ IntPtr arg_size,
            /* const void * */ IntPtr arg_value);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetKernelInfo")]
        public static extern int GetKernelInfo(cl_kernel kernel,
            KernelInfo param_name,
            /* size_t */ IntPtr param_value_size,
            /* void * */ IntPtr param_value,
            /* size_t * */ IntPtr param_value_size_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetKernelWorkGroupInfo")]
        public static extern int GetKernelWorkGroupInfo(cl_kernel kernel,
            cl_device_id device,
            KernelWorkGroupInfo param_name,
            /* size_t */ IntPtr param_value_size,
            /* void * */ IntPtr param_value,
            /* size_t * */ out IntPtr param_value_size_ret);
    }

    #endregion
}
