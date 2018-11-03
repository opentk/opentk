using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with icons.
        /// </summary>
        public static class Icon
        {
            /// <summary>
            /// Creates an icon or cursor from an <see cref="IconInfo"/> structure.
            /// </summary>
            /// <param name="iconInfo">
            /// An <see cref="IconInfo"/> structure the function uses to create the icon or cursor.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the icon or cursor that is created.<para/>
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern IntPtr CreateIconIndirect([In] ref IconInfo iconInfo);

            /// <summary>
            /// Destroys an icon and frees any memory the icon occupied.
            /// </summary>
            /// <param name="icon">A handle to the icon to be destroyed. The icon must not be in use.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DestroyIcon([In] IntPtr icon);

            /// <summary>
            /// Retrieves information about the specified icon or cursor.
            /// </summary>
            /// <param name="icon">A handle to the icon or cursor.</param>
            /// <param name="iconInfo">
            /// A pointer to an <see cref="IconInfo"/> structure. The function fills in the structure's members.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true and the function
            /// fills in the members of the specified <see cref="IconInfo"/> structure.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetIconInfo([In] IntPtr icon, [Out] out IconInfo iconInfo);

            /// <summary>
            /// Retrieves information about the specified pre-defined cursor.
            /// </summary>
            /// <param name="cursorName">One of the pre-defined cursors.</param>
            /// <param name="iconInfo">
            /// A pointer to an <see cref="IconInfo"/> structure. The function fills in the structure's members.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true and the function
            /// fills in the members of the specified <see cref="IconInfo"/> structure.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static bool GetIconInfo(CursorName cursorName, out IconInfo iconInfo)
            {
                return GetIconInfo(new IntPtr((int)cursorName), out iconInfo);
            }

            /// <summary>
            /// Retrieves information about the specified pre-defined icon.
            /// </summary>
            /// <param name="iconName">One of the pre-defined cursors.</param>
            /// <param name="iconInfo">
            /// A pointer to an <see cref="IconInfo"/> structure. The function fills in the structure's members.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true and the function
            /// fills in the members of the specified <see cref="IconInfo"/> structure.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static bool GetIconInfo(IconName iconName, out IconInfo iconInfo)
            {
                return GetIconInfo(new IntPtr((int)iconName), out iconInfo);
            }

            /// <summary>
            /// Loads the specified icon resource from the executable (.exe)
            /// file associated with an application instance.
            /// </summary>
            /// <param name="moduleInstance">
            /// A handle to an instance of the module whose executable file contains the icon to be loaded.
            /// This parameter must be <see cref="IntPtr.Zero"/> when a standard icon is being loaded.
            /// </param>
            /// <param name="iconName">The name of the icon resource to be loaded.</param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the newly loaded icon.<para/>
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern IntPtr LoadIcon([In] [Optional] IntPtr moduleInstance, [In] string iconName);

            /// <summary>
            /// Loads the specified icon resource from the executable (.exe)
            /// file associated with an application instance.
            /// </summary>
            /// <param name="moduleInstance">
            /// A handle to an instance of the module whose executable file contains the icon to be loaded.
            /// This parameter must be <see cref="IntPtr.Zero"/> when a standard icon is being loaded.
            /// </param>
            /// <param name="iconName">A pointer to a string with the name of the icon resource to be loaded.</param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the newly loaded icon.<para/>
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern IntPtr LoadIcon([In] [Optional] IntPtr moduleInstance, [In] IntPtr iconName);

            /// <summary>
            /// Loads the specified icon resource from the executable (.exe)
            /// file associated with an application instance.
            /// </summary>
            /// <param name="cursorName">One of the pre-defined cursors to be loaded.</param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the newly loaded icon.<para/>
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static IntPtr LoadIcon(CursorName cursorName)
            {
                return LoadIcon(IntPtr.Zero, new IntPtr((int)cursorName));
            }

            /// <summary>
            /// Loads the specified icon resource from the executable (.exe)
            /// file associated with an application instance.
            /// </summary>
            /// <param name="iconName">One of the pre-defined icons to be loaded.</param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the newly loaded icon.<para/>
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static IntPtr LoadIcon(IconName iconName)
            {
                return LoadIcon(IntPtr.Zero, new IntPtr((int)iconName));
            }
        }
    }
}
