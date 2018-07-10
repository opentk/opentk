using System.Runtime.InteropServices;

using DEVMODE = System.IntPtr;
using HDC = System.IntPtr;
using HWND = System.IntPtr;
using LPVOID = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class DeviceContext
        {
            [DllImport("user32.dll")]
            public static extern HDC GetDC([In] HWND hWnd);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ReleaseDC([In] HWND hWnd, [In] HDC dc);

            [DllImport("user32.dll")]
            public static extern ChangeDisplaySettingsResult ChangeDisplaySettings
            (
                [In] ref DeviceMode lpDevMode,
                [In] ChangeDisplaySettingsFlags dwflags
            );

            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            public static extern ChangeDisplaySettingsResult ChangeDisplaySettingsEx
            (
                [In] string lpszDeviceName,
                [In] DEVMODE lpDevMode,
                HWND hwnd,
                [In] ChangeDisplaySettingsFlags dwflags,
                [In] LPVOID lParam
            );

            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumDisplaySettings
            (
                [In] string lpszDeviceName,
                [In] DisplayModeSettingsEnum iModeNum,
                [Out] out DeviceMode lpDevMode
            );

            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumDisplaySettingsEx
            (
                [In] string lpszDeviceName,
                [In] DisplayModeSettingsEnum iModeNum,
                [Out] out DeviceMode lpDevMode,
                [In] int dwFlags
            );

            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumDisplayDevices
            (
                [In] string lpDevice,
                [In] int iDevNum,
                [Out] out DisplayDevice lpDisplayDevice,
                [In] int dwFlags
            );
        }
    }
}
