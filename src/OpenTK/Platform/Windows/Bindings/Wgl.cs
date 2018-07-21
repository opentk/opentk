//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos
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

using OpenTK.NT.Native;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.Platform.Windows
{
#pragma warning disable 3019
#pragma warning disable 1591

    internal partial class Wgl
    {
        static Wgl()
        {
            EntryPointNames = new[]
            {
                "wglCreateContextAttribsARB",
                "wglGetExtensionsStringARB",
                "wglGetPixelFormatAttribivARB",
                "wglGetPixelFormatAttribfvARB",
                "wglChoosePixelFormatARB",
                "wglMakeContextCurrentARB",
                "wglGetCurrentReadDCARB",
                "wglCreatePbufferARB",
                "wglGetPbufferDCARB",
                "wglReleasePbufferDCARB",
                "wglDestroyPbufferARB",
                "wglQueryPbufferARB",
                "wglBindTexImageARB",
                "wglReleaseTexImageARB",
                "wglSetPbufferAttribARB",
                "wglGetExtensionsStringEXT",
                "wglSwapIntervalEXT",
                "wglGetSwapIntervalEXT"
            };
            EntryPoints = new IntPtr[EntryPointNames.Length];
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglCreateContext", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr CreateContext(IntPtr hDc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglDeleteContext", ExactSpelling = true, SetLastError = true)]
        internal static extern bool DeleteContext(IntPtr oldContext);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglGetCurrentContext", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetCurrentContext();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true, SetLastError = true)]
        internal static extern bool MakeCurrent(IntPtr hDc, IntPtr newContext);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglChoosePixelFormat", ExactSpelling = true, SetLastError = true)]
        internal static extern int ChoosePixelFormat(IntPtr hDc, ref PixelFormatDescriptor pPfd);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglDescribePixelFormat", ExactSpelling = true, SetLastError = true)]
        internal static extern int DescribePixelFormat(IntPtr hdc, int ipfd, int cjpfd, ref PixelFormatDescriptor ppfd);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglGetCurrentDC", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetCurrentDC();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetProcAddress(string lpszProc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetProcAddress(IntPtr lpszProc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglGetPixelFormat", ExactSpelling = true, SetLastError = true)]
        internal static extern int GetPixelFormat(IntPtr hdc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglSetPixelFormat", ExactSpelling = true, SetLastError = true)]
        internal static extern bool SetPixelFormat(IntPtr hdc, int ipfd, ref PixelFormatDescriptor ppfd);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglSwapBuffers", ExactSpelling = true, SetLastError = true)]
        internal static extern bool SwapBuffers(IntPtr hdc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, EntryPoint = "wglShareLists", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);

        [Slot(0)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern unsafe IntPtr wglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext,
            int* attribList);

        [Slot(1)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr wglGetExtensionsStringARB(IntPtr hdc);

        [Slot(2)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern unsafe bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane,
            uint nAttributes, int* piAttributes, [Out] int* piValues);

        [Slot(3)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern unsafe bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane,
            uint nAttributes, int* piAttributes, [Out] float* pfValues);

        [Slot(4)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern unsafe bool wglChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, float* pfAttribFList,
            uint nMaxFormats, [Out] int* piFormats, [Out] uint* nNumFormats);

        [Slot(5)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool wglMakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);

        [Slot(6)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr wglGetCurrentReadDCARB();

        [Slot(7)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern unsafe IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight,
            int* piAttribList);

        [Slot(8)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);

        [Slot(9)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);

        [Slot(10)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool wglDestroyPbufferARB(IntPtr hPbuffer);

        [Slot(11)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern unsafe bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);

        [Slot(12)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer);

        [Slot(13)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);

        [Slot(14)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern unsafe bool wglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);

        [Slot(15)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr wglGetExtensionsStringEXT();

        [Slot(16)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool wglSwapIntervalEXT(int interval);

        [Slot(17)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern int wglGetSwapIntervalEXT();

        public static class Arb
        {
            [AutoGenerated(EntryPoint = "wglCreateContextAttribsARB")]
            public static
                IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int[] attribList)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetExtensionsStringARB")]
            public static
                string GetExtensionsString(IntPtr hdc)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribivARB")]
            public static
                bool GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                    int[] piAttributes, [Out] int[] piValues)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribivARB")]
            public static
                bool GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                    ref int piAttributes, [Out] out int piValues)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribfvARB")]
            public static
                bool GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                    int[] piAttributes, [Out] float[] pfValues)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribfvARB")]
            public static
                bool GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                    ref int piAttributes, [Out] out float pfValues)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglChoosePixelFormatARB")]
            public static
                bool ChoosePixelFormat(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, int nMaxFormats,
                    [Out] int[] piFormats, out int nNumFormats)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglChoosePixelFormatARB")]
            public static
                bool ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref float pfAttribFList, int nMaxFormats,
                    [Out] out int piFormats, [Out] out int nNumFormats)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglMakeContextCurrentARB")]
            public static
                bool MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetCurrentReadDCARB")]
            public static
                IntPtr GetCurrentReadDC()
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglCreatePbufferARB")]
            public static
                IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglCreatePbufferARB")]
            public static
                IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetPbufferDCARB")]
            public static
                IntPtr GetPbufferDC(IntPtr hPbuffer)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglReleasePbufferDCARB")]
            public static
                int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglDestroyPbufferARB")]
            public static
                bool DestroyPbuffer(IntPtr hPbuffer)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglQueryPbufferARB")]
            public static
                bool QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int[] piValue)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglQueryPbufferARB")]
            public static
                bool QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] out int piValue)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglBindTexImageARB")]
            public static
                bool BindTexImage(IntPtr hPbuffer, int iBuffer)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglReleaseTexImageARB")]
            public static
                bool ReleaseTexImage(IntPtr hPbuffer, int iBuffer)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglSetPbufferAttribARB")]
            public static
                bool SetPbufferAttrib(IntPtr hPbuffer, int[] piAttribList)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglSetPbufferAttribARB")]
            public static
                bool SetPbufferAttrib(IntPtr hPbuffer, ref int piAttribList)
            {
                throw new BindingsNotRewrittenException();
            }
        }

        public static class Ext
        {
            [AutoGenerated(EntryPoint = "wglGetExtensionsStringEXT")]
            public static
                string GetExtensionsString()
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglSwapIntervalEXT")]
            public static
                bool SwapInterval(int interval)
            {
                throw new BindingsNotRewrittenException();
            }

            [AutoGenerated(EntryPoint = "wglGetSwapIntervalEXT")]
            public static
                int GetSwapInterval()
            {
                throw new BindingsNotRewrittenException();
            }
        }
    }
}