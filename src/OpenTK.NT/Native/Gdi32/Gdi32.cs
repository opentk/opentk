using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.NT.Native
{
    public static class Gdi32
    {
        [DllImport("gdi32.dll")]
        internal static extern int ChoosePixelFormat(IntPtr dc, ref PixelFormatDescriptor pfd);

        [DllImport("gdi32.dll")]
        internal static extern int DescribePixelFormat(IntPtr deviceContext, int pixel, int pfdSize,
            ref PixelFormatDescriptor pixelFormat);

        /// <summary>
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="format"></param>
        /// <param name="pfd"></param>
        /// <returns></returns>
        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetPixelFormat(IntPtr dc, int format, ref PixelFormatDescriptor pfd);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SwapBuffers(IntPtr dc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetDeviceCaps(IntPtr hDC, DeviceCaps nIndex);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr GetStockObject(StockObjects fnObject);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern bool DeleteObject([In] IntPtr hObject);
    }
}
