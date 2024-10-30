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

        internal struct XScreenSaverInfo
        {
            public XWindow window;         /* screen saver window */
            public ScreenSaverState state; /* ScreenSaver{Off,On,Disabled} */
            public int kind;               /* ScreenSaver{Blanked,Internal,External}*/
            public ulong til_or_since;     /* milliseconds */
            public ulong idle;             /* milliseconds */
            public ulong eventMask;        /* events */
        }

        internal enum ScreenSaverState : int
        {
            Off = 0,
            On = 1,
            Disabled = 3,
        }

        internal enum ScreenSaverKind : int
        {
            Blanked = 0,
            Internal = 1,
            External = 2,
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XScreenSaverInfo* XScreenSaverAllocInfo();

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XStatus XScreenSaverQueryInfo(XDisplayPtr dpy, XDrawable drawable, XScreenSaverInfo* saver_info);

        /// <summary>Available in XScreenSaver 1.1 and later.</summary>
        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XScreenSaverSuspend(XDisplayPtr dpy, bool suspend);
    }
}
