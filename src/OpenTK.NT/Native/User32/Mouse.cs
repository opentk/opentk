using System.Runtime.InteropServices;

using HWND = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Mouse
        {
            [DllImport("user32.dll")]
            public static extern HWND GetCapture();

            [DllImport("user32.dll")]
            public static extern HWND SetCapture(HWND hWnd);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ReleaseCapture();

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool TrackMouseEvent([In] [Out] ref TrackMouseEvent lpEventTrack);

            [DllImport("user32", SetLastError = true)]
            public static extern int GetMouseMovePointsEx
            (
                [In] uint cbSize,
                [In] ref MouseMovePoint lppt,
                [Out] out MouseMovePoint lpptBuf,
                [In] int nBufPoints,
                [In] GetMouseMovePointsResolution resolution
            );

            [DllImport("user32", SetLastError = true)]
            public static unsafe extern int GetMouseMovePointsEx
            (
                [In] uint cbSize,
                [In] ref MouseMovePoint lppt,
                [Out] MouseMovePoint* lpptBuf,
                [In] int nBufPoints,
                [In] GetMouseMovePointsResolution resolution
            );
        }
    }
}
