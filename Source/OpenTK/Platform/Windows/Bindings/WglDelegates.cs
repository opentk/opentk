#region License
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
#endregion

namespace OpenTK.Platform.Windows
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class Wgl
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);
            internal unsafe static CreateContextAttribsARB wglCreateContextAttribsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringARB(IntPtr hdc);
            internal static GetExtensionsStringARB wglGetExtensionsStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivARB wglGetPixelFormatAttribivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvARB wglGetPixelFormatAttribfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats);
            internal unsafe static ChoosePixelFormatARB wglChoosePixelFormatARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentARB wglMakeContextCurrentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCARB();
            internal static GetCurrentReadDCARB wglGetCurrentReadDCARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferARB wglCreatePbufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCARB(IntPtr hPbuffer);
            internal static GetPbufferDCARB wglGetPbufferDCARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCARB wglReleasePbufferDCARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferARB(IntPtr hPbuffer);
            internal static DestroyPbufferARB wglDestroyPbufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);
            internal unsafe static QueryPbufferARB wglQueryPbufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static BindTexImageARB wglBindTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static ReleaseTexImageARB wglReleaseTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
            internal unsafe static SetPbufferAttribARB wglSetPbufferAttribARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringEXT();
            internal static GetExtensionsStringEXT wglGetExtensionsStringEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapIntervalEXT(int interval);
            internal static SwapIntervalEXT wglSwapIntervalEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetSwapIntervalEXT();
            internal static GetSwapIntervalEXT wglGetSwapIntervalEXT;
        }
    }
}
