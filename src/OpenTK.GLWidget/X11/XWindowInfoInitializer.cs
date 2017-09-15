using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Platform.X11;

namespace OpenTK.X11
{
    /// <summary>
    /// Handler class for initializing <see cref="IWindowInfo"/> objects under the X11 platform for both GTK2 and GTK3.
    /// </summary>
    public static class XWindowInfoInitializer
    {

#if GTK3
        private const string UnixLibGdkName = "libgdk-3.so.0";
#else
        const string UnixLibGdkName = "libgdk-x11-2.0.so.0";
#endif
        /// <summary>
        /// Initializes an <see cref="IWindowInfo"/> under the X11 platform.
        /// </summary>
        /// <param name="displayHandle"></param>
        /// <param name="screenNumber"></param>
        /// <param name="gdkWindowHandle"></param>
        /// <param name="gdkRootWindowHandle"></param>
        /// <returns></returns>
        public static IWindowInfo Initialize(IntPtr displayHandle, int screenNumber, IntPtr gdkWindowHandle, IntPtr gdkRootWindowHandle)
        {
            IntPtr display = gdk_x11_display_get_xdisplay(displayHandle);

#if GTK3
            IntPtr windowXid = gdk_x11_window_get_xid(gdkWindowHandle);
            IntPtr rootWindowXid = gdk_x11_window_get_xid(gdkRootWindowHandle);
#else
            IntPtr windowXid = gdk_x11_drawable_get_xid(gdkWindowHandle);
            IntPtr rootWindowXid = gdk_x11_drawable_get_xid(gdkRootWindowHandle);
#endif

            // No visual needs to be passed here, since we're piggybacking on the GdkGLContext from the base GLArea
            IWindowInfo retval = Utilities.CreateX11WindowInfo(display, screenNumber, windowXid, rootWindowXid, IntPtr.Zero);

            return retval;
        }

#if GTK3
        /// <summary> Returns the X resource (window or pixmap) belonging to a GdkWindow. </summary>
        /// <remarks> XID gdk_x11_window_get_xid(GdkWindow *drawable); </remarks>
        /// <param name="gdkDisplay"> The GdkDrawable. </param>
        /// <returns> The ID of window's X resource. </returns>
        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
        private static extern IntPtr gdk_x11_window_get_xid(IntPtr gdkDisplay);
#else
        /// <summary> Returns the X resource (window or pixmap) belonging to a GdkDrawable. </summary>
        /// <remarks> XID gdk_x11_drawable_get_xid(GdkDrawable *drawable); </remarks>
        /// <param name="gdkDisplay"> The GdkDrawable. </param>
        /// <returns> The ID of drawable's X resource. </returns>
        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
        static extern IntPtr gdk_x11_drawable_get_xid(IntPtr gdkDisplay);
#endif
        /// <summary> Returns the X display of a GdkDisplay. </summary>
        /// <remarks> Display* gdk_x11_display_get_xdisplay(GdkDisplay *display); </remarks>
        /// <param name="gdkDisplay"> The GdkDrawable. </param>
        /// <returns> The X Display of the GdkDisplay. </returns>
        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
        private static extern IntPtr gdk_x11_display_get_xdisplay(IntPtr gdkDisplay);
    }
}