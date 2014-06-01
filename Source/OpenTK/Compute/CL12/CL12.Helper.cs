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

namespace OpenTK.Compute.CL12
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

        public static ComputeContextHandle CreateContext(ContextProperty[] properties, ComputeDevice[] devices, ContextNotifyDelegate pfn_notify, [InAttribute, OutAttribute] IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
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

        public static ComputeContextHandle CreateContextFromType(ContextProperty[] properties, DeviceTypeFlags device_type, ContextNotifyDelegate pfn_notify, [InAttribute, OutAttribute] IntPtr user_data, [OutAttribute] out ErrorCode errcode_ret)
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

    /// <summary>
    /// Defines the callback prototype for
    /// <see cref="CL.CreateContext"/> or
    /// <see cref="CL.CreateContextFromType"/>
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void ContextNotifyDelegate([MarshalAs(UnmanagedType.LPStr)] string errinfo, IntPtr private_info, IntPtr cb, IntPtr user_data);

    /// <summary>
    /// Defines the callback prototype for <see cref="OpenTK.Compute.ComputeEvent"/> functions
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void EventNotifyDelegate();

    /// <summary>
    /// Defines the callback prototype for <see cref="OpenTK.Compute.ComputeMemory"/> functions
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void MemObjectNotifyDelegate();

    /// <summary>
    /// Defines the callback prototype for <see cref="OpenTK.Compute.ComputeProgram"/> functions
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void ProgramNotifyDelegate();

    // <summary>
    // Defines the callback prototype for <see cref="OpenTK.Compute.ComputeProgram"/> functions
    // </summary>
    //[UnmanagedFunctionPointer(CallingConvention.Winapi)]
    //public delegate void UserNotifyDelegate();

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageDescriptor
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageFormat
    {
    }

    public partial struct ComputeContext
    {
        public static implicit operator OpenTK.Compute.ComputeContextHandle(ComputeContext context)
        {
            return new ComputeContextHandle
            {
                Handle = context.Value
            };
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

