using System;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenTK.Platform.Native.X11
{
    internal static class XScreenSaver
    {
        private const string X11 = "XScreenSaver";

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XScreenSaverQueryExtension(XDisplayPtr dpy, out int event_base_return, out int error_base_return);
        
        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XScreenSaverQueryVersion(XDisplayPtr dpy, out int major_version_return, out int minor_version_return);

        /// <summary>Available in XScreenSaver 1.1 and later.</summary>
        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XScreenSaverSuspend(XDisplayPtr dpy, bool suspend);
    }
}
