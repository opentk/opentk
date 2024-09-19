using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    public static unsafe class LibXcb
    {
        private const string XCB = "XCB";

        private const string X11XCB = "X11XCB";

        [DllImport(X11XCB, CallingConvention = CallingConvention.Cdecl)]
        internal static extern xcb_connection_t* XGetXCBConnection(XDisplayPtr dpy);
    }
}

