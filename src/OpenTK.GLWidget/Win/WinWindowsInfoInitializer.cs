using System;
using System.Runtime.InteropServices;
using System.Security;
using OpenTK.Platform;

namespace OpenTK.Win
{
    /// <summary>
    /// Handler class for initializing <see cref="IWindowInfo"/> objects under the Windows platform for both GTK2 and
    /// GTK3.
    /// </summary>
    public static class WinWindowsInfoInitializer
    {
#if GTK3
        private const string WinLibGDKName = "libgdk-3-0.dll";
#else
        private const string WinLibGDKName = "libgdk-win32-2.0-0.dll";
#endif

        /// <summary>
        /// Initializes an <see cref="IWindowInfo"/> under the Windows platform.
        /// </summary>
        /// <param name="gdkWindowHandle"></param>
        public static IWindowInfo Initialize(IntPtr gdkWindowHandle)
        {
#if GTK3
            IntPtr windowHandle = gdk_win32_window_get_handle(gdkWindowHandle);
#else
            IntPtr windowHandle = gdk_win32_drawable_get_handle(gdkWindowHandle);
#endif
            return Utilities.CreateWindowsWindowInfo(windowHandle);
        }

#if GTK3
        [SuppressUnmanagedCodeSecurity, DllImport(WinLibGDKName, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr gdk_win32_window_get_handle(IntPtr w);
#else
        [SuppressUnmanagedCodeSecurity, DllImport(WinLibGDKName, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr gdk_win32_drawable_get_handle(IntPtr d);
#endif

    }
}