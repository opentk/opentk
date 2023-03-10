using System;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenTK.Platform.Native.X11
{
    internal static unsafe class XFixes
    {
        private const string X11 = "XFixes";

        static XFixes()
        {
            DllResolver.InitLoader();
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XFixesQueryExtension(XDisplayPtr dpy, out int event_base_return, out int error_base_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XFixesQueryVersion (XDisplayPtr dpy, ref int major_version_return, ref int minor_version_return);

        internal unsafe struct XFixesCursorImage {
            public short x, y;
            public ushort width, height;
            public ushort xhot, yhot;
            public ulong cursor_serial;
            public ulong* pixels;
            // FIXME: Special struct for v2+?
//#if XFIXES_MAJOR >= 2
            public XAtom atom;		    /* Version >= 2 only */
            public char* name;		    /* Version >= 2 only */
//#endif
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XFixesCursorImage* XFixesGetCursorImage (XDisplayPtr dpy);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XID /* PointerBarrier */ XFixesCreatePointerBarrier(
            XDisplayPtr dpy, 
            XWindow w, 
            int x1, int y1,
            int x2, int y2, 
            BarrierDirection directions,
            int num_devices, 
            IntPtr devices);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFixesDestroyPointerBarrier(XDisplayPtr dpy, XID /* PointerBarrier */ b);
    }
}