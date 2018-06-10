using System;
using System.Runtime.InteropServices;
using System.Security;

using BOOL = System.Boolean;
using DWORD = System.UInt32;
using FARPROC = System.IntPtr;
using HMODULE = System.IntPtr;
using LARGE_INTEGER = System.Int64;
using LPCSTR = System.String;
using LPCTSTR = System.String;

namespace OpenTK.NT.Native
{
    public static class Kernel32
    {
        private const string Lib = "kernel32.dll";

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL QueryPerformanceFrequency([Out] out LARGE_INTEGER lpFrequency);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL QueryPerformanceCounter([Out] out LARGE_INTEGER lpPerformanceCount);

        [DllImport(Lib, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern FARPROC GetProcAddress(
            [In] HMODULE hModule,
            [In] [MarshalAs(UnmanagedType.LPTStr)] LPCSTR lpProcName
        );

        [DllImport(Lib, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern FARPROC GetProcAddress([In] HMODULE hModule, [In] IntPtr lpProcName);

        [DllImport(Lib)]
        public static extern void SetLastError(DWORD dwErrCode);

        [DllImport(Lib)]
        public static extern HMODULE GetModuleHandle(
            [In] [Optional] [MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpModuleName
        );

        [DllImport(Lib, SetLastError = true)]
        public static extern HMODULE LoadLibrary([In] LPCTSTR lpFileName);

        [DllImport(Lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL FreeLibrary([In] HMODULE hModule);
    }
}
