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

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.Platform.Windows
{
#pragma warning disable 3019
#pragma warning disable 1591

    static partial class Wgl
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglCreateContext", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr CreateContext(IntPtr hDc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglDeleteContext", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean DeleteContext(IntPtr oldContext);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetCurrentContext", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetCurrentContext();
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglChoosePixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static unsafe int ChoosePixelFormat(IntPtr hDc, ref PixelFormatDescriptor pPfd);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglDescribePixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, int cjpfd, ref PixelFormatDescriptor ppfd);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetCurrentDC", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetCurrentDC();
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetProcAddress(String lpszProc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetProcAddress(IntPtr lpszProc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetPixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static int GetPixelFormat(IntPtr hdc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglSetPixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean SetPixelFormat(IntPtr hdc, int ipfd, ref PixelFormatDescriptor ppfd);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglSwapBuffers", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean SwapBuffers(IntPtr hdc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglShareLists", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);

        public static partial class Arb
        {
            [CLSCompliant(false)]
            unsafe public static
            IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int* attribList)
            {
                return Delegates.wglCreateContextAttribsARB((IntPtr)hDC, (IntPtr)hShareContext, (int*)attribList);
            }

            public static
            IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, ref int attribList)
            {
                unsafe
                {
                    fixed (int* attribList_ptr = &attribList)
                    {
                        return Delegates.wglCreateContextAttribsARB((IntPtr)hDC, (IntPtr)hShareContext, (int*)attribList_ptr);
                    }
                }
            }

            public static
            IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int[] attribList)
            {
                unsafe
                {
                    fixed (int* attribList_ptr = attribList)
                    {
                        return Delegates.wglCreateContextAttribsARB((IntPtr)hDC, (IntPtr)hShareContext, (int*)attribList_ptr);
                    }
                }
            }

            public static
            string GetExtensionsString(IntPtr hdc)
            {
                unsafe
                {
                    return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.wglGetExtensionsStringARB((IntPtr)hdc));
                }
            }

            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int[] piAttributes, [Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        return Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                    }
                }
            }

            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out int piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }

            public static
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] int* piValues)
            {
                return Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues);
            }

            [System.CLSCompliant(false)]
            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, [Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        return Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                    }
                }
            }

            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int[] piAttributes, [Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        return Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                    }
                }
            }

            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out Single pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] Single* pfValues)
            {
                return Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues);
            }

            public static
            Boolean ChoosePixelFormat(IntPtr hdc, int[] piAttribIList, Single[] pfAttribFList, Int32 nMaxFormats, [Out] int[] piFormats, out int nNumFormats)
            {
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    fixed (Int32* nNumFormats_ptr = &nNumFormats)
                    {
                        return Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                    }
                }
            }

            public static
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] out Int32 nNumFormats)
            {
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    fixed (Int32* nNumFormats_ptr = &nNumFormats)
                    {
                        Boolean retval = Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                        piFormats = *piFormats_ptr;
                        nNumFormats = *nNumFormats_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32* nNumFormats)
            {
                return Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32*)nNumFormats);
            }

            public static
            Boolean MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
            {
                return Delegates.wglMakeContextCurrentARB((IntPtr)hDrawDC, (IntPtr)hReadDC, (IntPtr)hglrc);
            }

            public static
            IntPtr GetCurrentReadDC()
            {
                return Delegates.wglGetCurrentReadDCARB();
            }

            public static
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        return Delegates.wglCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                    }
                }
            }

            public static
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        return Delegates.wglCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static
            unsafe IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
            {
                return Delegates.wglCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList);
            }

            public static
            IntPtr GetPbufferDC(IntPtr hPbuffer)
            {
                return Delegates.wglGetPbufferDCARB((IntPtr)hPbuffer);
            }

            public static
            int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
            {
                return Delegates.wglReleasePbufferDCARB((IntPtr)hPbuffer, (IntPtr)hDC);
            }

            public static
            Boolean DestroyPbuffer(IntPtr hPbuffer)
            {
                return Delegates.wglDestroyPbufferARB((IntPtr)hPbuffer);
            }

            public static
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        return Delegates.wglQueryPbufferARB((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            public static
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] out int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.wglQueryPbufferARB((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue_ptr);
                        piValue = *piValue_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static
            unsafe Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int* piValue)
            {
                return Delegates.wglQueryPbufferARB((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue);
            }

            public static
            Boolean BindTexImage(IntPtr hPbuffer, int iBuffer)
            {
                return Delegates.wglBindTexImageARB((IntPtr)hPbuffer, (int)iBuffer);
            }

            public static
            Boolean ReleaseTexImage(IntPtr hPbuffer, int iBuffer)
            {
                return Delegates.wglReleaseTexImageARB((IntPtr)hPbuffer, (int)iBuffer);
            }

            public static
            Boolean SetPbufferAttrib(IntPtr hPbuffer, int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        return Delegates.wglSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList_ptr);
                    }
                }
            }

            public static
            Boolean SetPbufferAttrib(IntPtr hPbuffer, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        return Delegates.wglSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static
            unsafe Boolean SetPbufferAttrib(IntPtr hPbuffer, int* piAttribList)
            {
                return Delegates.wglSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList);
            }
        }

        public static partial class Ext
        {
            public static
            string GetExtensionsString()
            {
                unsafe
                {
                    return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.wglGetExtensionsStringEXT());
                }
            }

            public static
            Boolean SwapInterval(int interval)
            {
                return Delegates.wglSwapIntervalEXT((int)interval);
            }

            public static
            int GetSwapInterval()
            {
                return Delegates.wglGetSwapIntervalEXT();
            }

        }
    }
}
