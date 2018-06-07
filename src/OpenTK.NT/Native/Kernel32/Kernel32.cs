using System;
using System.Runtime.InteropServices;
using System.Security;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public static class Kernel32
    {
        private const string Lib = "kernel32.dll";

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceFrequency(ref long PerformanceFrequency);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceCounter(ref long PerformanceCount);

        [DllImport(Lib)]
        public static extern IntPtr GetProcAddress(IntPtr handle, string funcname);

        [DllImport(Lib)]
        public static extern IntPtr GetProcAddress(IntPtr handle, IntPtr funcname);

        [DllImport(Lib)]
        public static extern void SetLastError(DWORD dwErrCode);

        [DllImport(Lib)]
        public static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPTStr)] string module_name);

        [DllImport(Lib, SetLastError = true)]
        public static extern IntPtr LoadLibrary(string dllName);

        [DllImport(Lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr handle);
    }
}
