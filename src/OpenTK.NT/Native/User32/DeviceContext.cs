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
            public static extern bool ReleaseDC([In] HWND hWnd, [In] HDC DC);

            /// <summary>
            /// The ChangeDisplaySettings function changes the settings of the default display device to the specified graphics
            /// mode.
            /// </summary>
            /// <param name="lpDevMode">
            /// [in] Pointer to a DEVMODE structure that describes the new graphics mode. If lpDevMode is
            /// NULL, all the values currently in the registry will be used for the display setting. Passing NULL for the lpDevMode
            /// parameter and 0 for the dwFlags parameter is the easiest way to return to the default mode after a dynamic mode
            /// change.
            /// </param>
            /// <param name="dwflags">[in] Indicates how the graphics mode should be changed.</param>
            /// <returns></returns>
            /// <remarks>
            /// To change the settings of a specified display device, use the ChangeDisplaySettingsEx function.
            ///  <para>
            /// To ensure that the DEVMODE structure passed to ChangeDisplaySettings is valid and contains only values
            /// supported by the display driver, use the DEVMODE returned by the EnumDisplaySettings function.
            ///  </para>
            ///  <para>
            /// When the display mode is changed dynamically, the WM_DISPLAYCHANGE message is sent to all running
            /// applications.
            ///  </para>
            /// </remarks>
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
