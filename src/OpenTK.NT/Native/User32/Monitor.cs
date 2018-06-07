using System.Runtime.InteropServices;

using HMONITOR = System.IntPtr;
using HWND = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Monitor
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetMonitorInfo([In] HMONITOR hMonitor, [Out] out MonitorInfo lpmi);

            [DllImport("user32.dll")]
            public static extern HMONITOR MonitorFromPoint([In] POINT pt, [In] MonitorFrom dwFlags);

            [DllImport("user32.dll")]
            public static extern HMONITOR MonitorFromWindow([In] HWND hwnd, [In] MonitorFrom dwFlags);
        }
    }
}
