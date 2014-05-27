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

namespace OpenTK.Compute.CL10
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

    public delegate void ContextNotifyDelegate();
    public delegate void EventNotifyDelegate();
    public delegate void MemObjectNotifyDelegate();
    public delegate void ProgramNotifyDelegate();
    public delegate void SvmFreeDelegate();
    public delegate void UserNotifyDelegate();

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageDescriptor
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageFormat
    {
    }
}

