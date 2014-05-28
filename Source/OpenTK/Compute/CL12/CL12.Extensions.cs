//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
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

namespace OpenTK.Compute.CL12
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines extension methods to simply ComputeContextHandle usage.
    /// </summary>
    public static partial class ComputeContextHandleExtensions
    {
        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, IntPtr host_ptr, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, IntPtr host_ptr, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[] host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[] host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,] host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,] host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,,] host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] T3[,,] host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] ref T3 host_ptr, [OutAttribute] out ErrorCode errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, ref host_ptr, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="size"></param>
        /// <param name="host_ptr"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateBuffer<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, IntPtr size, [InAttribute, OutAttribute] ref T3 host_ptr, [OutAttribute] ErrorCode* errcode_ret)
            where T3 : struct
        {
            return CL.CreateBuffer(context, flags, size, ref host_ptr, errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="device"></param>
        /// <param name="properties"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static CommandQueue CreateCommandQueue(this ComputeContextHandle context, ComputeDevice device, CommandQueueFlags properties, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateCommandQueue(context, device, properties, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="device"></param>
        /// <param name="properties"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe CommandQueue CreateCommandQueue(this ComputeContextHandle context, ComputeDevice device, CommandQueueFlags properties, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateCommandQueue(context, device, properties, errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, ImageDescriptor[] image_desc, ImageFormat[] image_format)
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, ImageDescriptor[] image_desc, ImageFormat[] image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, ImageDescriptor[] image_desc, ImageFormat[] image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, ImageDescriptor[] image_desc, ImageFormat[] image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, ImageDescriptor[] image_desc, ImageFormat[] image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, ref host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, ref ImageDescriptor image_desc, ref ImageFormat image_format)
        {
            return CL.CreateImage(context, out errcode_ret, flags, host_ptr, ref image_desc, ref image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, ref ImageDescriptor image_desc, ref ImageFormat image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, out errcode_ret, flags, host_ptr, ref image_desc, ref image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, ref ImageDescriptor image_desc, ref ImageFormat image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, out errcode_ret, flags, host_ptr, ref image_desc, ref image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, ref ImageDescriptor image_desc, ref ImageFormat image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, out errcode_ret, flags, host_ptr, ref image_desc, ref image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, ref ImageDescriptor image_desc, ref ImageFormat image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, out errcode_ret, flags, ref host_ptr, ref image_desc, ref image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, ImageDescriptor* image_desc, ImageFormat* image_format)
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, ImageDescriptor* image_desc, ImageFormat* image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, ImageDescriptor* image_desc, ImageFormat* image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, ImageDescriptor* image_desc, ImageFormat* image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_desc"></param>
        /// <param name="image_format"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, ImageDescriptor* image_desc, ImageFormat* image_format)
            where T3 : struct
        {
            return CL.CreateImage(context, errcode_ret, flags, ref host_ptr, image_desc, image_format);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, ref host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
        {
            return CL.CreateImage2D(context, out errcode_ret, flags, host_ptr, ref image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, out errcode_ret, flags, host_ptr, ref image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, out errcode_ret, flags, host_ptr, ref image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, out errcode_ret, flags, host_ptr, ref image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, out errcode_ret, flags, ref host_ptr, ref image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage2D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage2D(context, errcode_ret, flags, ref host_ptr, image_format, image_height, image_row_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, IntPtr image_depth, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, IntPtr image_depth, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, IntPtr image_depth, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, IntPtr image_depth, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, IntPtr image_depth, ImageFormat[] image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, ref host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, IntPtr image_depth, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
        {
            return CL.CreateImage3D(context, out errcode_ret, flags, host_ptr, image_depth, ref image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, IntPtr image_depth, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, out errcode_ret, flags, host_ptr, image_depth, ref image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, IntPtr image_depth, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, out errcode_ret, flags, host_ptr, image_depth, ref image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, IntPtr image_depth, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, out errcode_ret, flags, host_ptr, image_depth, ref image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, IntPtr image_depth, ref ImageFormat image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, out errcode_ret, flags, ref host_ptr, image_depth, ref image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, IntPtr host_ptr, IntPtr image_depth, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[] host_ptr, IntPtr image_depth, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,] host_ptr, IntPtr image_depth, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] T3[,,] host_ptr, IntPtr image_depth, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="flags"></param>
        /// <param name="host_ptr"></param>
        /// <param name="image_depth"></param>
        /// <param name="image_format"></param>
        /// <param name="image_height"></param>
        /// <param name="image_row_pitch"></param>
        /// <param name="image_slice_pitch"></param>
        /// <param name="image_width"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeMemory CreateImage3D<T3>(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret, OpenTK.Compute.CL12.MemFlags flags, [InAttribute, OutAttribute] ref T3 host_ptr, IntPtr image_depth, ImageFormat* image_format, IntPtr image_height, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr image_width)
            where T3 : struct
        {
            return CL.CreateImage3D(context, errcode_ret, flags, ref host_ptr, image_depth, image_format, image_height, image_row_pitch, image_slice_pitch, image_width);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="device_list"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="kernel_names"></param>
        /// <param name="num_devices"></param>
        [CLSCompliant(false)]
        public static ComputeProgram CreateProgramWithBuiltInKernels(this ComputeContextHandle context, ComputeDevice[] device_list, [OutAttribute] Int32[] errcode_ret, String kernel_names, Int32 num_devices)
        {
            return CL.CreateProgramWithBuiltInKernels(context, device_list, errcode_ret, kernel_names, num_devices);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="device_list"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="kernel_names"></param>
        /// <param name="num_devices"></param>
        [CLSCompliant(false)]
        public static ComputeProgram CreateProgramWithBuiltInKernels(this ComputeContextHandle context, ref ComputeDevice device_list, [OutAttribute] out Int32 errcode_ret, String kernel_names, Int32 num_devices)
        {
            return CL.CreateProgramWithBuiltInKernels(context, ref device_list, out errcode_ret, kernel_names, num_devices);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="device_list"></param>
        /// <param name="errcode_ret"></param>
        /// <param name="kernel_names"></param>
        /// <param name="num_devices"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeProgram CreateProgramWithBuiltInKernels(this ComputeContextHandle context, ComputeDevice* device_list, [OutAttribute] Int32* errcode_ret, String kernel_names, Int32 num_devices)
        {
            return CL.CreateProgramWithBuiltInKernels(context, device_list, errcode_ret, kernel_names, num_devices);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="count"></param>
        /// <param name="strings"></param>
        /// <param name="lengths"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeProgram CreateProgramWithSource(this ComputeContextHandle context, UInt32 count, IntPtr strings, IntPtr* lengths, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="count"></param>
        /// <param name="strings"></param>
        /// <param name="lengths"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeProgram CreateProgramWithSource(this ComputeContextHandle context, Int32 count, IntPtr strings, IntPtr* lengths, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateProgramWithSource(context, count, strings, lengths, errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="count"></param>
        /// <param name="strings"></param>
        /// <param name="lengths"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeProgram CreateProgramWithSource(this ComputeContextHandle context, Int32 count, String[] strings, IntPtr[] lengths, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateProgramWithSource(context, count, strings, lengths, out errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="count"></param>
        /// <param name="strings"></param>
        /// <param name="lengths"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeProgram CreateProgramWithSource(this ComputeContextHandle context, Int32 count, ref String strings, ref IntPtr lengths, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateProgramWithSource(context, count, ref strings, ref lengths, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="normalized_coords"></param>
        /// <param name="addressing_mode"></param>
        /// <param name="filter_mode"></param>
        /// <param name="errcode_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ComputeSampler CreateSampler(this ComputeContextHandle context, bool normalized_coords, OpenTK.Compute.CL12.AddressingMode addressing_mode, OpenTK.Compute.CL12.FilterMode filter_mode, [OutAttribute] out Int32 errcode_ret)
        {
            return CL.CreateSampler(context, normalized_coords, addressing_mode, filter_mode, out errcode_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="normalized_coords"></param>
        /// <param name="addressing_mode"></param>
        /// <param name="filter_mode"></param>
        /// <param name="errcode_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ComputeSampler CreateSampler(this ComputeContextHandle context, bool normalized_coords, OpenTK.Compute.CL12.AddressingMode addressing_mode, OpenTK.Compute.CL12.FilterMode filter_mode, [OutAttribute] Int32* errcode_ret)
        {
            return CL.CreateSampler(context, normalized_coords, addressing_mode, filter_mode, errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeEvent CreateUserEvent(this ComputeContextHandle context, [OutAttribute] Int32[] errcode_ret)
        {
            return CL.CreateUserEvent(context, errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeEvent CreateUserEvent(this ComputeContextHandle context, [OutAttribute] out Int32 errcode_ret)
        {
            return CL.CreateUserEvent(context, out errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeEvent CreateUserEvent(this ComputeContextHandle context, [OutAttribute] Int32* errcode_ret)
        {
            return CL.CreateUserEvent(context, errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        public static ErrorCode RetainContext(this ComputeContextHandle context)
        {
            return CL.RetainContext(context);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        public static ErrorCode ReleaseContext(this ComputeContextHandle context)
        {
            return CL.ReleaseContext(context);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, ref param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="context"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetContextInfo<T3>(this ComputeContextHandle context, OpenTK.Compute.CL12.ContextInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetContextInfo(context, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] T3[,,] param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, ref param_value, out param_value_size_ret);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="device"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size_ret">[length: 1]</param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetDeviceInfo<T3>(this ComputeDevice device, OpenTK.Compute.CL12.DeviceInfo param_name, IntPtr param_value_size, [InAttribute, OutAttribute] ref T3 param_value, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetDeviceInfo(device, param_name, param_value_size, ref param_value, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_formats"></param>
        /// <param name="image_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="num_image_formats"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetSupportedImageFormats(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, ImageFormat[] image_formats, OpenTK.Compute.CL12.MemObjectType image_type, Int32 num_entries, Int32[] num_image_formats)
        {
            return CL.GetSupportedImageFormats(context, flags, image_formats, image_type, num_entries, num_image_formats);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_formats"></param>
        /// <param name="image_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="num_image_formats"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetSupportedImageFormats(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, ref ImageFormat image_formats, OpenTK.Compute.CL12.MemObjectType image_type, Int32 num_entries, ref Int32 num_image_formats)
        {
            return CL.GetSupportedImageFormats(context, flags, ref image_formats, image_type, num_entries, ref num_image_formats);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="flags"></param>
        /// <param name="image_formats"></param>
        /// <param name="image_type"></param>
        /// <param name="num_entries"></param>
        /// <param name="num_image_formats"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetSupportedImageFormats(this ComputeContextHandle context, OpenTK.Compute.CL12.MemFlags flags, ImageFormat* image_formats, OpenTK.Compute.CL12.MemObjectType image_type, Int32 num_entries, Int32* num_image_formats)
        {
            return CL.GetSupportedImageFormats(context, flags, image_formats, image_type, num_entries, num_image_formats);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="num_input_programs"></param>
        /// <param name="input_programs"></param>
        /// <param name="notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode LinkProgram(this ComputeContextHandle context, Int32 num_devices, ComputeDevice[] device_list, String options, Int32 num_input_programs, ComputeProgram[] input_programs, ProgramNotifyDelegate notify, IntPtr user_data)
        {
            return CL.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="num_input_programs"></param>
        /// <param name="input_programs"></param>
        /// <param name="notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode LinkProgram(this ComputeContextHandle context, Int32 num_devices, ref ComputeDevice device_list, String options, Int32 num_input_programs, ref ComputeProgram input_programs, ProgramNotifyDelegate notify, IntPtr user_data)
        {
            return CL.LinkProgram(context, num_devices, ref device_list, options, num_input_programs, ref input_programs, notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="context"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="num_input_programs"></param>
        /// <param name="input_programs"></param>
        /// <param name="notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode LinkProgram(this ComputeContextHandle context, Int32 num_devices, ComputeDevice* device_list, String options, Int32 num_input_programs, ComputeProgram* input_programs, ProgramNotifyDelegate notify, IntPtr user_data)
        {
            return CL.LinkProgram(context, num_devices, device_list, options, num_input_programs, input_programs, notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="memobj"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        public static ErrorCode SetMemObjectDestructorCallback(this ComputeMemory memobj, MemObjectNotifyDelegate pfn_notify, IntPtr user_data)
        {
            return CL.SetMemObjectDestructorCallback(memobj, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="memobj"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetMemObjectDestructorCallback<T2>(this ComputeMemory memobj, MemObjectNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T2[] user_data)
            where T2 : struct
        {
            return CL.SetMemObjectDestructorCallback(memobj, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="memobj"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetMemObjectDestructorCallback<T2>(this ComputeMemory memobj, MemObjectNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T2[,] user_data)
            where T2 : struct
        {
            return CL.SetMemObjectDestructorCallback(memobj, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="memobj"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetMemObjectDestructorCallback<T2>(this ComputeMemory memobj, MemObjectNotifyDelegate pfn_notify, [InAttribute, OutAttribute] T2[,,] user_data)
            where T2 : struct
        {
            return CL.SetMemObjectDestructorCallback(memobj, pfn_notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="memobj"></param>
        /// <param name="pfn_notify"></param>
        /// <param name="user_data"></param>
        public static ErrorCode SetMemObjectDestructorCallback<T2>(this ComputeMemory memobj, MemObjectNotifyDelegate pfn_notify, [InAttribute, OutAttribute] ref T2 user_data)
            where T2 : struct
        {
            return CL.SetMemObjectDestructorCallback(memobj, pfn_notify, ref user_data);
        }

    }
    /// <summary>
    /// Defines extension methods to simply ComputeKernel usage.
    /// </summary>
    public static partial class ComputeKernelExtensions
    {
        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, IntPtr param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, IntPtr param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, IntPtr param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[] param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[] param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[] param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[,] param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[,,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[,,] param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] T2[,,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] ref T2 param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, ref param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] ref T2 param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, ref param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelInfo<T2>(this ComputeKernel kernel, OpenTK.Compute.CL12.KernelInfo param_name, [InAttribute, OutAttribute] ref T2 param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T2 : struct
        {
            return CL.GetKernelInfo(kernel, param_name, ref param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, IntPtr param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, IntPtr param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, IntPtr param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[] param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[] param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[] param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[,] param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[,,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[,,] param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] T3[,,] param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] ref T3 param_value, IntPtr param_value_size, [OutAttribute] IntPtr[] param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, ref param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] ref T3 param_value, IntPtr param_value_size, [OutAttribute] out IntPtr param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, ref param_value, param_value_size, out param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="device"></param>
        /// <param name="kernel"></param>
        /// <param name="param_name"></param>
        /// <param name="param_value"></param>
        /// <param name="param_value_size"></param>
        /// <param name="param_value_size_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode GetKernelWorkGroupInfo<T3>(this ComputeDevice device, ComputeKernel kernel, OpenTK.Compute.CL12.KernelWorkGroupInfo param_name, [InAttribute, OutAttribute] ref T3 param_value, IntPtr param_value_size, [OutAttribute] IntPtr* param_value_size_ret)
            where T3 : struct
        {
            return CL.GetKernelWorkGroupInfo(device, kernel, param_name, ref param_value, param_value_size, param_value_size_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        public static ErrorCode ReleaseKernel(this ComputeKernel kernel)
        {
            return CL.ReleaseKernel(kernel);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="kernel"></param>
        public static ErrorCode RetainKernel(this ComputeKernel kernel)
        {
            return CL.RetainKernel(kernel);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        /// <param name="kernel"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg(this UInt32 arg_index, IntPtr arg_size, IntPtr arg_value, ComputeKernel kernel)
        {
            return CL.SetKernelArg(arg_index, arg_size, arg_value, kernel);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        /// <param name="kernel"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg(this Int32 arg_index, IntPtr arg_size, IntPtr arg_value, ComputeKernel kernel)
        {
            return CL.SetKernelArg(arg_index, arg_size, arg_value, kernel);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        /// <param name="kernel"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg<T2>(this Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] T2[] arg_value, ComputeKernel kernel)
            where T2 : struct
        {
            return CL.SetKernelArg(arg_index, arg_size, arg_value, kernel);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        /// <param name="kernel"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg<T2>(this Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] T2[,] arg_value, ComputeKernel kernel)
            where T2 : struct
        {
            return CL.SetKernelArg(arg_index, arg_size, arg_value, kernel);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        /// <param name="kernel"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg<T2>(this Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] T2[,,] arg_value, ComputeKernel kernel)
            where T2 : struct
        {
            return CL.SetKernelArg(arg_index, arg_size, arg_value, kernel);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="arg_index"></param>
        /// <param name="arg_size"></param>
        /// <param name="arg_value"></param>
        /// <param name="kernel"></param>
        [CLSCompliant(false)]
        public static ErrorCode SetKernelArg<T2>(this Int32 arg_index, IntPtr arg_size, [InAttribute, OutAttribute] ref T2 arg_value, ComputeKernel kernel)
            where T2 : struct
        {
            return CL.SetKernelArg(arg_index, arg_size, ref arg_value, kernel);
        }

    }
    /// <summary>
    /// Defines extension methods to simply ComputeProgram usage.
    /// </summary>
    public static partial class ComputeProgramExtensions
    {
        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram(this ComputeProgram program, Int32 num_devices, ComputeDevice[] device_list, String options, ProgramNotifyDelegate notify, IntPtr user_data)
        {
            return CL.BuildProgram(program, num_devices, device_list, options, notify, user_data);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static ErrorCode BuildProgram(this ComputeProgram program, Int32 num_devices, ref ComputeDevice device_list, String options, ProgramNotifyDelegate notify, IntPtr user_data)
        {
            return CL.BuildProgram(program, num_devices, ref device_list, options, notify, user_data);
        }

        /// <summary>[requires: v1.0 or ]</summary>
        /// <param name="program"></param>
        /// <param name="num_devices"></param>
        /// <param name="device_list"></param>
        /// <param name="options"></param>
        /// <param name="notify"></param>
        /// <param name="user_data"></param>
        [CLSCompliant(false)]
        public static unsafe ErrorCode BuildProgram(this ComputeProgram program, Int32 num_devices, ComputeDevice* device_list, String options, ProgramNotifyDelegate notify, IntPtr user_data)
        {
            return CL.BuildProgram(program, num_devices, device_list, options, notify, user_data);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="program"></param>
        /// <param name="kernel_name"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static ComputeKernel CreateKernel(this ComputeProgram program, String kernel_name, [OutAttribute] out ErrorCode errcode_ret)
        {
            return CL.CreateKernel(program, kernel_name, out errcode_ret);
        }

        /// <summary>[requires: v1.2 or ]</summary>
        /// <param name="program"></param>
        /// <param name="kernel_name"></param>
        /// <param name="errcode_ret"></param>
        [CLSCompliant(false)]
        public static unsafe ComputeKernel CreateKernel(this ComputeProgram program, String kernel_name, [OutAttribute] ErrorCode* errcode_ret)
        {
            return CL.CreateKernel(program, kernel_name, errcode_ret);
        }

    }
}
