using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
#pragma warning disable SA1516 // Elements should be separated by blank line
#pragma warning disable SA1401 // Fields should be private
    internal static class Wgl
    {
        [DllImport("opengl32.dll", EntryPoint = "wglCreateContext", SetLastError = true)]
        internal static extern IntPtr CreateContext(IntPtr hdc);

        [DllImport("opengl32.dll", EntryPoint = "wglDeleteContext", SetLastError = true)]
        internal static extern bool DeleteContext(IntPtr hglrc);

        [DllImport("opengl32.dll", EntryPoint = "wglMakeCurrent", SetLastError = true)]
        internal static extern bool MakeCurrent(IntPtr hdc, IntPtr hglrc);

        [DllImport("opengl32.dll", EntryPoint = "wglGetCurrentContext", SetLastError = true)]
        internal static extern IntPtr GetCurrentContext();

        [DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress", SetLastError = true)]
        internal static extern unsafe void* GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procName);

        internal static unsafe void* GetAnyProcAddress(string procName)
        {
            void* p = GetProcAddress(procName);
            if (p == (void*)0 ||
              (p == (void*)0x1) || (p == (void*)0x2) || (p == (void*)0x3) ||
              (p == (void*)-1))
            {
                // FIXME: Make this only load this once?
                IntPtr module = Win32.LoadLibrary("opengl32.dll");
                p = (void*)Win32.GetProcAddress(module, procName);
            }

            return p;
        }

        //BOOL wglGetPixelFormatAttribivARB(HDC hdc, int iPixelFormat ,int iLayerPlane, UINT nAttributes, const int* piAttributes, int* piValues);

        internal static unsafe delegate* unmanaged<IntPtr, byte*> _GetExtensionsStringARB__fnptr = &GetExtensionsStringARB__Lazy;
        public static unsafe byte* GetExtensionsStringARB_(IntPtr hdc) => _GetExtensionsStringARB__fnptr(hdc);
        [UnmanagedCallersOnly]
        private static unsafe byte* GetExtensionsStringARB__Lazy(IntPtr hdc)
        {
            _GetExtensionsStringARB__fnptr = (delegate* unmanaged<IntPtr, byte*>)GetProcAddress("wglGetExtensionsStringARB");
            return _GetExtensionsStringARB__fnptr(hdc);
        }
        public static unsafe string? GetExtensionsStringARB(IntPtr hdc)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetExtensionsStringARB_(hdc);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }

        internal static unsafe delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int> _GetPixelFormatAttribivARB__fnptr = &GetPixelFormatAttribivARB__Lazy;
        public static unsafe int GetPixelFormatAttribivARB_(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues) => _GetPixelFormatAttribivARB__fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
        [UnmanagedCallersOnly]
        private static unsafe int GetPixelFormatAttribivARB__Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues)
        {
            _GetPixelFormatAttribivARB__fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)GetProcAddress("wglGetPixelFormatAttribivARB");
            return _GetPixelFormatAttribivARB__fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
        }
        public static unsafe bool GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes, ReadOnlySpan<WGLPixelFormatAttribute> attributes, Span<int> values)
        {
            fixed (WGLPixelFormatAttribute* piAttributes = attributes)
            fixed (int* piValues = values)
            {
                unchecked
                {
                    return GetPixelFormatAttribivARB_(hdc, iPixelFormat, iLayerPlane, (uint)nAttributes, (int*)piAttributes, piValues) != 0;
                }
            }
        }

        /*    BOOL wglChoosePixelFormatARB(HDC hdc,
                                 const int *piAttribIList,
                                 const FLOAT *pfAttribFList,
                                 UINT nMaxFormats,
                                 int *piFormats,
                                 UINT *nNumFormats);
        */

        internal static unsafe delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int> _ChoosePixelFormatARB__fnptr = &ChoosePixelFormatARB__Lazy;
        public static unsafe int ChoosePixelFormatARB_(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats) => _ChoosePixelFormatARB__fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        [UnmanagedCallersOnly]
        private static unsafe int ChoosePixelFormatARB__Lazy(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats)
        {
            _ChoosePixelFormatARB__fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)GetProcAddress("wglChoosePixelFormatARB");
            return _ChoosePixelFormatARB__fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        }
        public static unsafe bool ChoosePixelFormatARB(IntPtr hdc, Span<int> attribIList, Span<float> attribFList, int nMaxFormats, Span<int> formats, out int numFormats)
        {
            fixed (int* piAttribIList = attribIList)
            fixed (float* pfAttribFList = attribFList)
            fixed (int* piFormats = formats)
            fixed (int* nNumFormats = &numFormats)
            {
                unchecked
                {
                    return ChoosePixelFormatARB_(hdc, piAttribIList, pfAttribFList, (uint)nMaxFormats, piFormats, (uint*)nNumFormats) != 0;
                }
            }
        }

        internal static unsafe delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr> _CreateContextAttribsARB__fnptr = &CreateContextAttribsARB__Lazy;
        public static unsafe IntPtr CreateContextAttribsARB_(IntPtr hdc, IntPtr hglrc, int* attribList) => _CreateContextAttribsARB__fnptr(hdc, hglrc, attribList);
        [UnmanagedCallersOnly]
        private static unsafe IntPtr CreateContextAttribsARB__Lazy(IntPtr hdc, IntPtr hglrc, int* attribList)
        {
            _CreateContextAttribsARB__fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)GetProcAddress("wglCreateContextAttribsARB");
            return _CreateContextAttribsARB__fnptr(hdc, hglrc, attribList);
        }
        public static unsafe IntPtr CreateContextAttribsARB(IntPtr hdc, IntPtr hglrc, Span<int> attribList)
        {
            fixed (int* attribPtr = attribList)
            {
                return CreateContextAttribsARB_(hdc, hglrc, attribPtr);
            }
        }

        internal static unsafe delegate* unmanaged<int, void> _SwapIntervalEXT__fnptr = &SwapIntervalEXT__Lazy;
        public static unsafe void SwapIntervalEXT(int interval) => _SwapIntervalEXT__fnptr(interval);
        [UnmanagedCallersOnly]
        private static unsafe void SwapIntervalEXT__Lazy(int interval)
        {
            _SwapIntervalEXT__fnptr = (delegate* unmanaged<int, void>)GetProcAddress("wglSwapIntervalEXT");
            _SwapIntervalEXT__fnptr(interval);
        }

        internal static unsafe delegate* unmanaged<int> _GetSwapIntervalEXT__fnptr = &GetSwapIntervalEXT__Lazy;
        public static unsafe int GetSwapIntervalEXT() => _GetSwapIntervalEXT__fnptr();
        [UnmanagedCallersOnly]
        private static unsafe int GetSwapIntervalEXT__Lazy()
        {
            _GetSwapIntervalEXT__fnptr = (delegate* unmanaged<int>)GetProcAddress("wglGetSwapIntervalEXT");
            return _GetSwapIntervalEXT__fnptr();
        }
    }
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1516 // Elements should be separated by blank line
}
