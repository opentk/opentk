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
    using cl_context = IntPtr;
    using cl_device_id = IntPtr;
    using cl_program = IntPtr;

    #region Flat API

    partial class CL
    {
        public delegate void NotifyProgram(cl_program program, IntPtr user_data);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateProgramWithSource")]
        public static extern cl_program CreateProgramWithSource(cl_context context,
            int count,
            string[] strings,
            IntPtr[] lengths,
            out int errcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateProgramWithBinary")]
        public static extern cl_program CreateProgramWithBinary(cl_context context,
        int num_devices,
        cl_device_id[] device_list,
        IntPtr[] lengths,
        byte[][] binaries,
        out int binary_status,
        out int errcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clRetainProgram")]
        public static extern int RetainProgram(cl_program program);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clReleaseProgram")]
        public static extern int ReleaseProgram(cl_program program);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clBuildProgram")]
        public static extern int BuildProgram(cl_program program,
            int num_devices,
            cl_device_id[] device_list,
            string options,
            NotifyProgram pfn_notify,
            IntPtr user_data);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clUnloadCompiler")]
        public static extern int UnloadCompiler();

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetProgramInfo")]
        public static extern int GetProgramInfo(cl_program program,
            ProgramInfo param_name,
            IntPtr param_value_size,
            IntPtr param_value,
            out IntPtr param_value_size_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetProgramBuildInfo")]
        public static extern int GetProgramBuildInfo(cl_program program,
            cl_device_id device,
            ProgramBuildInfo param_name,
            IntPtr param_value_size,
            IntPtr param_value,
            out IntPtr param_value_size_ret);
    }

    #endregion
}
