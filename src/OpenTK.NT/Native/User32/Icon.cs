using System.Runtime.InteropServices;

using HICON = System.IntPtr;
using HINSTANCE = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Icon
        {
            /// <summary>
            /// Creates an icon or cursor from an IconInfo structure.
            /// </summary>
            /// <param name="iconInfo">
            /// A pointer to an IconInfo structure the function uses to create the
            /// icon or cursor.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the icon
            /// or cursor that is created.
            /// If the function fails, the return value is null. To get extended
            /// error information, call Marshal.GetLastWin32Error.
            /// </returns>
            /// <remarks>
            /// The system copies the bitmaps in the IconInfo structure before
            /// creating the icon or cursor. Because the system may temporarily
            /// select the bitmaps in a device context, the hbmMask and hbmColor
            /// members of the IconInfo structure should not already be selected
            /// into a device context. The application must continue to manage the
            /// original bitmaps and delete them when they are no longer necessary.
            /// When you are finished using the icon, destroy it using the
            /// DestroyIcon function.
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern HICON CreateIconIndirect([In] ref IconInfo iconInfo);

            /// <summary>
            /// Destroys an icon and frees any memory the icon occupied.
            /// </summary>
            /// <param name="hIcon">
            /// A handle to the icon to be destroyed. The icon must not be in use.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero. To get extended
            /// error information, call Marshal.GetLastWin32Error.
            /// </returns>
            /// <remarks>
            /// It is only necessary to call DestroyIcon for icons and cursors
            /// created with the following functions: CreateIconFromResourceEx
            /// (if called without the LR_SHARED flag), CreateIconIndirect, and
            /// CopyIcon. Do not use this function to destroy a shared icon. A
            /// shared icon is valid as long as the module from which it was loaded
            /// remains in memory. The following functions obtain a shared icon.
            /// LoadIcon
            /// LoadImage (if you use the LR_SHARED flag)
            /// CopyImage (if you use the LR_COPYRETURNORG flag and the hImage parameter is a shared icon)
            /// CreateIconFromResource
            /// CreateIconFromResourceEx (if you use the LR_SHARED flag)
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DestroyIcon([In] HICON hIcon);

            /// <summary>
            /// Retrieves information about the specified icon or cursor.
            /// </summary>
            /// <param name="hIcon">A handle to the icon or cursor.</param>
            /// <param name="pIconInfo">
            /// A pointer to an IconInfo structure. The function fills in the
            /// structure's members.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero and the
            /// function fills in the members of the specified IconInfo structure.
            /// If the function fails, the return value is zero. To get extended
            /// error information, call Marshal.GetLastWin32Error.
            /// </returns>
            /// <remarks>
            /// GetIconInfo creates bitmaps for the hbmMask and hbmColor members
            /// of IconInfo. The calling application must manage these bitmaps and
            /// delete them when they are no longer necessary.
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetIconInfo([In] HICON hIcon, [Out] out IconInfo pIconInfo);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern HICON LoadIcon
            (
                [In] [Optional] HINSTANCE hInstance,
                [In] string lpIconName
            );
        }
    }
}
