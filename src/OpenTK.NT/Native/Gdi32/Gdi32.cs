using System;
using System.Runtime.InteropServices;
using System.Security;

using BOOL = System.Boolean;
using HDC = System.IntPtr;
using HGDIOBJ = System.IntPtr;
using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    public static class Gdi32
    {
        private const string Lib = "gdi32.dll";

        [DllImport(Lib, SetLastError = true)]
        internal static extern int ChoosePixelFormat(HDC hdc, ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport(Lib, SetLastError = true)]
        internal static extern int DescribePixelFormat(
            HDC hdc,
            int iPixelFormat,
            UINT nBytes,
            ref PIXELFORMATDESCRIPTOR ppfd
        );

        [DllImport(Lib, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL SetPixelFormat(
            HDC hdc,
            int iPixelFormat,
            ref PIXELFORMATDESCRIPTOR ppfd
        );

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Lib, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL SwapBuffers(HDC hdc);

        [DllImport(Lib, CharSet = CharSet.Auto)]
        public static extern int GetDeviceCaps([In] HDC hdc, [In] GetDeviceCapsIndex nIndex);

        [DllImport(Lib)]
        internal static extern HGDIOBJ GetStockObject(GetStockObjectType fnObject);

        [DllImport(Lib)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL DeleteObject([In] HGDIOBJ hObject);
    }
}
