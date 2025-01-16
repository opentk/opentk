using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
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
        internal static extern int /* Status */ XFixesQueryVersion(XDisplayPtr dpy, ref int major_version_return, ref int minor_version_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFixesVersion();

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFixesChangeSaveSet(XDisplayPtr dpy, XWindow win, int mode, int target, int map);

        internal enum SelectionEvent
        {
            SetSelectionOwner,
            SelectionWindowDestroy,
            SelectionClientClose,
        }

        internal enum SelectionEventMask : ulong
        {
            SetSelectionOwnerNotifyMask = 1L << SelectionEvent.SetSelectionOwner,
            SelectionWindowDestroyNotifyMask = 1L << SelectionEvent.SelectionWindowDestroy,
            SelectionClientCloseNotifyMask = 1L << SelectionEvent.SelectionClientClose,
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFixesSelectSelectionInput(XDisplayPtr dpy, XWindow win, XAtom selection, SelectionEventMask eventMask);

        internal struct XFixesSelectionNotifyEvent
        {
            public XEventType type;      /* FocusIn or FocusOut */
            public ulong serial;         /* # of last request processed by server */
            public int send_event;       /* true if this came from a SendEvent request */
            public XDisplayPtr display;  /* Display the event was read from */
            public XWindow window;       /* window of event */
            public int subtype;
            public XWindow owner;
            public XAtom selection;
            public XTime timestamp;
            public XTime selection_timestamp;
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFixesSelectCursorInput(XDisplayPtr dpy, XWindow win, ulong eventMask);

        internal unsafe struct XFixesCursorImage
        {

            public short x, y;
            public ushort width, height;
            public ushort xhot, yhot;
            public ulong cursor_serial;
            public ulong* pixels;
            // FIXME: Special struct for v2+?
            //#if XFIXES_MAJOR >= 2
            public XAtom atom;		    /* Version >= 2 only */
            public char* name;          /* Version >= 2 only */
            //#endif
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XFixesCursorImage* XFixesGetCursorImage(XDisplayPtr dpy);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XPointerBarrier XFixesCreatePointerBarrier(
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
#pragma warning restore CS0649 // Field '' is never assigned to, and will always have its default value 0
}
