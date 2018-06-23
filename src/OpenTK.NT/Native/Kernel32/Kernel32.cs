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
        private const string Library = "kernel32.dll";

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL QueryPerformanceFrequency([Out] out LARGE_INTEGER lpFrequency);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL QueryPerformanceCounter([Out] out LARGE_INTEGER lpPerformanceCount);

        [DllImport(Library, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern FARPROC GetProcAddress
        (
            [In] HMODULE hModule,
            [In] [MarshalAs(UnmanagedType.LPTStr)] LPCSTR lpProcName
        );

        [DllImport(Library, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern FARPROC GetProcAddress([In] HMODULE hModule, [In] IntPtr lpProcName);

        [DllImport(Library)]
        public static extern void SetLastError(DWORD dwErrCode);

        [DllImport(Library)]
        public static extern HMODULE GetModuleHandle
        (
            [In] [Optional] [MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpModuleName
        );

        [DllImport(Library, SetLastError = true)]
        public static extern HMODULE LoadLibrary([In] LPCTSTR lpFileName);

        [DllImport(Library)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL FreeLibrary([In] HMODULE hModule);
    }
}
