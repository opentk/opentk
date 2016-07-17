// #region License
//
// Cgl.cs
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
// #endregion
using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    using CGLPixelFormat = IntPtr;
    using CGLContext = IntPtr;

    static class Cgl
    {
        internal enum PixelFormatBool
        {
            None = 0,
            AllRenderers = 1,
            Doublebuffer = 5,
            Stereo = 6,
            AuxBuffers = 7,
            MinimumPolicy = 51,
            MaximumPolicy = 52,
            Offscreen = 53,
            AuxDepthStencil = 57,
            ColorFloat = 58,
            Multisample = 59,
            Supersample = 60,
            SampleALpha = 61,
            SingleRenderer = 71,
            NoRecovery = 72,
            Accelerated = 73,
            ClosestPolicy = 74,
            BackingStore = 76,
            Window = 80,
            Compliant = 83,
            PBuffer = 90,
            RemotePBuffer = 91,
        }

        internal enum PixelFormatInt
        {
            ColorSize = 8,
            AlphaSize = 11,
            DepthSize = 12,
            StencilSize = 13,
            AccumSize = 14,
            SampleBuffers = 55,
            Samples = 56,
            RendererID = 70,
            DisplayMask = 84,
            OpenGLProfile = 99,
            VScreenCount = 128,
        }

        internal enum OpenGLProfileVersion
        {
            Legacy = 0x100,
            Core3_2 = 0x3200,
        }

        internal enum ParameterNames
        {
            SwapInterval = 222,
        }

        internal enum Error
        {
            None = 0x000,
        }

        const string cgl = "/System/Library/Frameworks/OpenGL.framework/Versions/Current/OpenGL";
        const string cgs = "/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon";

        [DllImport(cgl, EntryPoint = "CGLGetError")]
        internal static extern Error GetError();
        [DllImport(cgl, EntryPoint = "CGLErrorString")]
        private static extern IntPtr CGLErrorString(Error code);
        internal static string ErrorString(Error code)
        {
            return Marshal.PtrToStringAnsi(CGLErrorString(code));
        }

        [DllImport(cgl, EntryPoint = "CGLChoosePixelFormat")]
        internal static extern Error ChoosePixelFormat(int []attribs, ref CGLPixelFormat format, ref int numPixelFormats);
        [DllImport(cgl, EntryPoint = "CGLDescribePixelFormat")]
        internal static extern Error DescribePixelFormat(CGLPixelFormat pix, int pix_num, PixelFormatInt attrib, out int value);
        [DllImport(cgl, EntryPoint = "CGLDescribePixelFormat")]
        internal static extern Error DescribePixelFormat(CGLPixelFormat pix, int pix_num, PixelFormatBool attrib, out bool value);
        [DllImport(cgl, EntryPoint = "CGLGetPixelFormat")]
        internal static extern CGLPixelFormat GetPixelFormat(CGLContext context);
        [DllImport(cgl, EntryPoint = "CGLCreateContext")]
        internal static extern Error CreateContext(CGLPixelFormat format, CGLContext share, ref CGLContext context);
        [DllImport(cgl, EntryPoint = "CGLDestroyPixelFormat")]
        internal static extern Error DestroyPixelFormat(CGLPixelFormat format);
        [DllImport(cgl, EntryPoint = "CGLGetCurrentContext")]
        internal static extern CGLContext GetCurrentContext();
        [DllImport(cgl, EntryPoint = "CGLSetCurrentContext")]
        internal static extern Error SetCurrentContext(CGLContext context);
        [DllImport(cgl, EntryPoint = "CGLDestroyContext")]
        internal static extern Error DestroyContext(CGLContext context);
        [DllImport(cgl, EntryPoint = "CGLSetParameter")]
        internal static extern Error SetParameter(CGLContext context, int parameter, ref int value);
        [DllImport(cgl, EntryPoint = "CGLFlushDrawable")]
        internal static extern Error FlushDrawable(CGLContext context);

        [DllImport(cgl, EntryPoint = "CGLSetSurface")]
        internal static extern Error SetSurface(CGLContext context, int conId, int winId, int surfId);
        [DllImport(cgl, EntryPoint = "CGLUpdateContext")]
        internal static extern Error UpdateContext(CGLContext context);

        [DllImport(cgs, EntryPoint = "CGSMainConnectionID")]
        internal static extern int MainConnectionID();
        [DllImport(cgs, EntryPoint = "CGSGetSurfaceCount")]
        internal static extern Error GetSurfaceCount(int conId, int winId, ref int count);
        [DllImport(cgs, EntryPoint = "CGSGetSurfaceList")]
        internal static extern Error GetSurfaceList(int conId, int winId, int count, ref int ids, ref int filled);
    }
}
