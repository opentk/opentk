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
    using cl_sampler = IntPtr;

    #region Flat API

    partial class CL
    {
        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clCreateSampler")]
        public static extern cl_sampler CreateSampler(cl_context context,
            bool normalized_coords,
            AddressingMode addressing_mode,
            FilterMode filter_mode,
            out int errcode_ret);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clRetainSampler")]
        public static extern int RetainSampler(cl_sampler sampler);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clReleaseSampler")]
        public static extern int ReleaseSampler(cl_sampler sampler);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetSamplerInfo")]
        public static extern int GetSamplerInfo(cl_sampler sampler,
            SamplerInfo param_name,
            IntPtr param_value_size,
            IntPtr param_value,
            out IntPtr param_value_size_ret);
    }

    #endregion

}
