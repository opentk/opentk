using System;
using System.Runtime.InteropServices;

using HINSTANCE = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class WindowClass
        {
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetClassInfoEx(
                [In] [Optional] HINSTANCE hinst,
                [MarshalAs(UnmanagedType.LPTStr)] string lpszClass,
                [Out] out WindowClassEx lpwcx
            );

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetClassInfoEx(
                [In] HINSTANCE hinst,
                [In] IntPtr lpszClass,
                [Out] out WindowClassEx lpwcx
            );

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            internal static extern ushort RegisterClass([In] ref Native.WindowClass lpWndClass);

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            internal static extern ushort RegisterClassEx([In] ref WindowClassEx lpwcx);

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool UnregisterClass(
                [In] [MarshalAs(UnmanagedType.LPTStr)] string lpClassName,
                [In] [Optional] HINSTANCE hInstance
            );

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool UnregisterClass(
                [In] IntPtr lpClassName,
                [In] [Optional] HINSTANCE hInstance
            );
        }
    }
}
