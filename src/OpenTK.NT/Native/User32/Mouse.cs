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

            /// <summary>
            /// Retrieves a history of up to 64 previous coordinates of the mouse or pen.
            /// </summary>
            /// <param name="cbSize">The size, in bytes, of the <see cref="MouseMovePoint"/> structure.</param>
            /// <param name="pointsIn">
            /// A pointer to a <see cref="MouseMovePoint"/> structure containing valid mouse
            /// coordinates (in screen coordinates). It may also contain a time
            /// stamp.
            /// </param>
            /// <param name="pointsBufferOut">
            /// A pointer to a buffer that will receive the points. It should be at
            /// least cbSize * nBufPoints in size.
            /// </param>
            /// <param name="nBufPoints">The number of points to be retrieved.</param>
            /// <param name="resolution">
            /// The resolution desired. This parameter can <see cref="GetMouseMovePointsResolution.UseDisplayPoints"/>
            /// or <see cref="GetMouseMovePointsResolution.UseHighResolutionPoints"/>.
            /// </param>
            /// <returns></returns>
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
