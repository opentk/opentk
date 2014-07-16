#region License
//
// CL20.Helper.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Compute.CL20
{
    public sealed partial class CL : ComputeBindingsBase
    {
        const string Library = "OpenCL";
        static readonly byte[] EntryPointNames;
        static readonly int[] EntryPointNameOffsets;
        static readonly IntPtr[] EntryPoints;
        static readonly object sync_root = new object();

        protected override object SyncRoot
        {
            get
            {
                return sync_root;
            }
        }
    }

    /// <summary>
    /// Defines the callback prototype for
    /// <see cref="CL.CreateContext"/> or
    /// <see cref="CL.CreateContextFromType"/>
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void ContextNotifyDelegate([MarshalAs(UnmanagedType.LPStr)] string errinfo, IntPtr private_info, IntPtr cb, IntPtr user_data);

    /// <summary>
    /// Defines the callback prototype for <see cref="ComputeEvent"/> methods.
    /// </summary>
    /// <param name="e">
    /// The <see cref="ComputeEvent"/> that generated this callback.
    /// </param>
    /// <param name="status">
    /// A bitwise combination of <see cref="CommandExecutionStatusFlags"/>
    /// indicating the cause of this callback.
    /// </param>
    /// <param name="user_data">
    /// A user-defined data pointer.
    /// </param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void EventNotifyDelegate(ComputeEvent e, CommandExecutionStatusFlags status, IntPtr user_data);

    /// <summary>
    /// Defines the callback prototype for <see cref="ComputeMemory"/> functions
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void MemObjectNotifyDelegate(ComputeMemory memobj, IntPtr user_data);

    /// <summary>
    /// Defines the callback prototype for <see cref="ComputeProgram"/> functions
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void ProgramNotifyDelegate(ComputeProgram program, IntPtr user_data);

    /// <summary>
    /// Defines the callback prototype for SVM memory functions
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void SVMFreeDelegate();

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageDescriptor
    {
        public MemObjectType ImageType;
        public IntPtr Width;
        public IntPtr Height;
        public IntPtr ArraySize;
        public IntPtr RowPitch;
        public IntPtr SlicePitch;
        public int NumMipLevels;
        public int NumSamples;
        public ComputeMemory Buffer;

        /// <summary>
        /// Gets or sets the <see cref="ComputeMemory"/> object for this instance.
        /// This is an alias to <see cref="ImageDescriptor.Buffer"/>
        /// </summary>
        public ComputeMemory MemObject
        {
            get { return Buffer; }
            set { Buffer = value; }
        }
    }

    /// <summary>
    /// Defines the data structure for
    /// <see cref="CL.CreateImage2D"/> and
    /// <see cref="CL.CreateImage3D"/>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageFormat
    {
        /// <summary>
        /// Specifies the <see cref="ChannelOrder"/>
        /// of the image data channels.
        /// </summary>
        public ChannelOrder ChannelOrder;

        /// <summary>
        /// Specifies the <see cref="ChannelType"/>
        /// of each data channel.
        /// </summary>
        public ChannelType ChannelDataType;
    }

    public static partial class CommandQueueExtensions
    {
        public static ErrorCode EnqueueNDRangeKernel(this CommandQueue command_queue, ComputeKernel kernel,
            ref IntPtr global_work_offset, ref IntPtr global_work_size, out ComputeEvent wait_event)
        {
            int length = 1;

            unsafe
            {
                fixed (IntPtr* pgoffset = &global_work_offset)
                fixed (IntPtr* pgsize = &global_work_size)
                fixed (ComputeEvent* pwait = &wait_event)
                {
                    return command_queue.EnqueueNDRangeKernel(kernel, length, pgoffset, pgsize, (IntPtr*)null,
                        0, (ComputeEvent*)null, pwait);
                }
            }
        }

        public static ErrorCode EnqueueNDRangeKernel(this CommandQueue command_queue, ComputeKernel kernel,
            ref IntPtr global_work_offset, ref IntPtr global_work_size, ref IntPtr local_work_size,
            out ComputeEvent wait_event)
        {
            int length = 1;

            unsafe
            {
                fixed (IntPtr* pgoffset = &global_work_offset)
                fixed (IntPtr* pgsize = &global_work_size)
                fixed (IntPtr* ploffset = &local_work_size)
                fixed (ComputeEvent* pwait = &wait_event)
                {
                    return command_queue.EnqueueNDRangeKernel(kernel, length, pgoffset, pgsize, ploffset,
                        0, (ComputeEvent*)null, pwait);
                }
            }
        }

        public static ErrorCode EnqueueNDRangeKernel(this CommandQueue command_queue, ComputeKernel kernel,
            IntPtr[] global_work_offset, IntPtr[] global_work_size, IntPtr[] local_work_size,
            out ComputeEvent wait_event)
        {
            int length =
                (global_work_offset == null || global_work_size == null || local_work_size == null) ?
                0 : global_work_offset.Length;

            return command_queue.EnqueueNDRangeKernel(kernel, length, global_work_offset, global_work_size, local_work_size,
                0, (ComputeEvent[])null, out wait_event);
        }
    }

    public partial struct ComputeContext
    {
        #region Helper Overloads

        static void EnsureNullTerminated(ref ContextProperty[] properties)
        {
            // The property array must always be terminated with ContextProperty.Zero
            if (properties != null)
            {
                if (properties[properties.Length - 1] != ContextProperty.Zero)
                {
                    Array.Resize(ref properties, properties.Length + 1);
                    properties[properties.Length - 1] = ContextProperty.Zero;
                }
            }
        }

        public static implicit operator OpenTK.Compute.ComputeContextHandle(ComputeContext context)
        {
            return new ComputeContextHandle
            {
                Handle = context.Value
            };
        }

        public static ComputeContext CreateContext(ContextProperty[] properties, ComputeDevice[] devices, ContextNotifyDelegate pfn_notify, [InAttribute, OutAttribute] IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
        {
            EnsureNullTerminated(ref properties);
            int device_length = devices != null ? devices.Length : 0;

            unsafe
            {
                fixed (void* pproperties = properties)
                fixed (void* pdevices = devices)
                fixed (ErrorCode* perr = &errcode_ret)
                {
                    return CreateContext((IntPtr*)pproperties, device_length, (ComputeDevice*)pdevices, pfn_notify, user_data, perr);
                }
            }
        }

        public static ComputeContext CreateContextFromType(ContextProperty[] properties, DeviceTypeFlags device_type, ContextNotifyDelegate pfn_notify, [InAttribute, OutAttribute] IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
        {
            EnsureNullTerminated(ref properties);

            unsafe
            {
                fixed (void* p = properties)
                fixed (ErrorCode* perr = &errcode_ret)
                {
                    return CreateContextFromType((IntPtr*)p, device_type, pfn_notify, user_data, perr);
                }
            }
        }

        #endregion
    }

    public static partial class ComputeContextExtensions
    {
        public static ComputeProgram CreateProgramWithSource(this ComputeContext context, string source, out ErrorCode error)
        {
            if (source == null)
            {
                throw new ArgumentException();
            }

            IntPtr zero = IntPtr.Zero; // use null-terminated strings
            return context.CreateProgramWithSource(1, ref source, ref zero, out error);
        }

        public static ComputeProgram CreateProgramWithSource(this ComputeContext context, string[] source, out ErrorCode error)
        {
            if (source == null || source.Length == 0)
            {
                throw new ArgumentException();
            }

            var lengths = new IntPtr[source.Length]; // use null-terminated strings
            return context.CreateProgramWithSource(source.Length, source, lengths, out error);
        }
    }

    public partial struct ComputeEvent
    {
        public static implicit operator OpenTK.Compute.ComputeEventHandle(ComputeEvent context)
        {
            return new ComputeEventHandle
            {
                Handle = context.Value
            };
        }
    }

    public partial struct ContextProperty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTK.Compute.CL12.ContextProperty"/> struct.
        /// </summary>
        /// <param name="platform">Platform.</param>
        public ContextProperty(ComputePlatform platform)
        {
            Property = (IntPtr)ContextProperties.ContextPlatform;
            Value = platform.Value;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="OpenTK.Compute.CL12.ContextProperty"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="OpenTK.Compute.CL12.ContextProperty"/>.</returns>
        public override string ToString()
        {
            return string.Format("[ContextProperty: {0}:{1}]", (ContextProperties)Property, Value);
        }
    }
}
