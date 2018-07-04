using System.Runtime.InteropServices;
using System.Security;

using BOOL = System.Boolean;
using HDC = System.IntPtr;
using HGDIOBJ = System.IntPtr;
using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Provides a subset of functions from the Windows API, specifically those that are imported from gdi32.dll.
    /// </summary>
    public static class Gdi32
    {
        private const string Library = "gdi32.dll";

        /// <summary>
        /// Attempts to match an appropriate pixel format supported by a device context to a given pixel format specification.
        /// </summary>
        /// <param name="hdc">Specifies the device context that the function examines to determine the best match for the pixel format descriptor pointed to by <paramref name="ppfd"/>.</param>
        /// <param name="ppfd">Pointer to a <see cref="PixelFormatDescriptor"/> structure that specifies the requested pixel format.</param>
        /// <returns>If the function succeeds, the return value is a pixel format index (one-based) that is the closest match to the given pixel format descriptor.<para/>
        /// If the function fails, the return value is zero.To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [DllImport(Library, SetLastError = true)]
        public static extern int ChoosePixelFormat(HDC hdc, ref PixelFormatDescriptor ppfd);

        /// <summary>
        /// Obtains information about the pixel format identified by <paramref name="iPixelFormat"/> of the device associated with <paramref name="hdc"/>. The function sets the members of the <see cref="PixelFormatDescriptor"/> structure pointed to by <paramref name="ppfd"/> with that pixel format data.
        /// </summary>
        /// <param name="hdc">Specifies the device context.</param>
        /// <param name="iPixelFormat">Index that specifies the pixel format. The pixel formats that a device context supports are identified by positive one-based integer indexes.</param>
        /// <param name="nBytes">The size, in bytes, of the structure pointed to by <paramref name="ppfd"/>. The <see cref="DescribePixelFormat(HDC, int, UINT, ref PixelFormatDescriptor)"/> function stores no more than <paramref name="nBytes"/> bytes of data to that structure. Set this value to <see cref="PixelFormatDescriptor.SizeInBytes"/>.</param>
        /// <param name="ppfd">Pointer to a <see cref="PixelFormatDescriptor"/> structure whose members the function sets with pixel format data. The function stores the number of bytes copied to the structure in the structure's <see cref="PixelFormatDescriptor.Size"/> member. If, upon entry, <paramref name="ppfd"/> is NULL, the function writes no data to the structure. This is useful when you only want to obtain the maximum pixel format index of a device context.</param>
        /// <returns>If the function succeeds, the return value is the maximum pixel format index of the device context. In addition, the function sets the members of the <see cref="PixelFormatDescriptor"/> structure pointed to by <paramref name="ppfd"/> according to the specified pixel format.<para/>
        /// If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [DllImport(Library, SetLastError = true)]
        public static extern int DescribePixelFormat
        (
            HDC hdc,
            int iPixelFormat,
            UINT nBytes,
            ref PixelFormatDescriptor ppfd
        );

        /// <summary>
        /// Sets the pixel format of the specified device context to the format specified by the <paramref name="iPixelFormat"/> index.
        /// </summary>
        /// <param name="hdc">Specifies the device context whose pixel format the function attempts to set.</param>
        /// <param name="iPixelFormat">Index that specifies the pixel format. The pixel formats that a device context supports are identified by positive one-based integer indexes.</param>
        /// <param name="ppfd">Pointer to a <see cref="PixelFormatDescriptor"/> structure that contains the logical pixel format specification. The system's metafile component uses this structure to record the logical pixel format specification. The structure has no other effect upon the behavior of the <see cref="SetPixelFormat(HDC, int, ref PixelFormatDescriptor)"/> function.</param>
        /// <returns>If the function succeeds, the return value is true.<para/>
        /// If the function fails, the return value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [DllImport(Library, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL SetPixelFormat
        (
            HDC hdc,
            int iPixelFormat,
            ref PixelFormatDescriptor ppfd
        );

        /// <summary>
        /// Exchanges the front and back buffers if the current pixel format for the window referenced by the specified device context includes a back buffer.
        /// </summary>
        /// <param name="hdc">Specifies the device context.</param>
        /// <returns>If the function succeeds, the return value is true.<para/>
        /// If the function fails, the return value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL SwapBuffers(HDC hdc);

        /// <summary>
        /// Retrieves device-specific information for the specified device.
        /// </summary>
        /// <param name="hdc">Specifies the device context.</param>
        /// <param name="nIndex"></param>
        /// <returns>The return value specifies the value of the desired item.<para/>
        /// When <paramref name="nIndex"/> is <see cref="GetDeviceCapsIndex.BitsPerPixel"/> and the device has 15bpp or 16bpp, the return value is 16.</returns>
        [DllImport(Library, CharSet = CharSet.Auto)]
        public static extern int GetDeviceCaps([In] HDC hdc, [In] GetDeviceCapsIndex nIndex);

        /// <summary>
        /// Retrieves a handle to one of the stock pens, brushes, fonts, or palettes.
        /// </summary>
        /// <param name="fnObject"></param>
        /// <returns>If the function succeeds, the return value is a handle to the requested logical object.<para/>
        /// If the function fails, the return value is null.</returns>
        [DllImport(Library)]
        public static extern HGDIOBJ GetStockObject(GetStockObjectType fnObject);

        /// <summary>
        /// Deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated with the object. After the object is deleted, the specified handle is no longer valid.
        /// </summary>
        /// <param name="hObject"></param>
        /// <returns>If the function succeeds, the return value is true.<para/>
        /// If the specified handle is not valid or is currently selected into a DC, the return value is false.</returns>
        /// <remarks>Do not delete a drawing object (pen or brush) while it is still selected into a DC.<para/>
        /// When a pattern brush is deleted, the bitmap associated with the brush is not deleted.The bitmap must be deleted independently.</remarks>
        [DllImport(Library)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL DeleteObject([In] HGDIOBJ hObject);
    }
}
