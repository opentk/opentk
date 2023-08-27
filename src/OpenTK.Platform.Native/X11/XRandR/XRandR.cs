using System;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11.XRandR
{
    /// <summary>
    /// Library class for the X Resize and Rotate Extension.
    /// </summary>
    internal static class XRandR
    {
        private const string xrandr = "Xrandr";

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XRRQueryExtension(XDisplayPtr display, out int eventBase, out int errorBase);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XRRQueryVersion(XDisplayPtr display, ref int major, ref int minor);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XRRScreenConfiguration XRRGetScreenInfo(XDisplayPtr display, XDrawable drawable);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XRRFreeScreenConfigInfo(XRRScreenConfiguration config);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XRRSelectInput(XDisplayPtr display, XWindow window, RRSelectMask mask);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XRRUpdateConfiguration(in XEvent @event);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XRRGetScreenSizeRange(
            XDisplayPtr display,
            XWindow window,
            out int minWidth,
            out int minHeight,
            out int maxWidth,
            out int maxHeight);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe XRRScreenResources* XRRGetScreenResources(XDisplayPtr display, XWindow window);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void XRRFreeScreenResources(XRRScreenResources* resources);

        internal static unsafe Span<XAtom> XRRListOutputProperties(XDisplayPtr display, RROutput output, out int nprop)
        {
            XAtom* atoms = XRRListOutputProperties(display, output, out nprop);

            return new Span<XAtom>(atoms, nprop);

            [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
            static unsafe extern XAtom* XRRListOutputProperties(XDisplayPtr display, RROutput output, out int nprop);
        }

        internal unsafe struct XRROutputInfo
        {
            internal XTime timestamp;
            internal RRCrtc crtc;
            internal byte* name;
            internal int nameLen;
            internal ulong mm_width;
            internal ulong mm_height;
            internal Connection connection;
            internal SubpixelOrder subpixel_order;
            internal int ncrtc;
            internal RRCrtc* crtcs;
            internal int nclone;
            internal RROutput* clones;
            internal int nmode;
            internal int npreferred;
            internal RRMode* modes;
        }

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XRROutputInfo* XRRGetOutputInfo(XDisplayPtr display, XRRScreenResources* resources, RROutput output);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XRRFreeOutputInfo(XRROutputInfo* outputInfo);

        internal unsafe struct XRRCrtcInfo
        {
            internal XTime timestamp;
            internal int x, y;
            internal uint width, height;
            internal RRMode mode;
            internal Rotation rotation;
            internal int noutput;
            internal RROutput* outputs;
            internal Rotation rotations;
            internal int npossible;
            internal RROutput* possible;
        }

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XRRCrtcInfo* XRRGetCrtcInfo(XDisplayPtr display, XRRScreenResources* resources, RRCrtc crtc);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XRRFreeCrtcInfo(XRRCrtcInfo* crtcInfo);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XRRGetOutputProperty(
            XDisplayPtr display,
            RROutput output,
            XAtom property,
            long offset, long length,
            [MarshalAs(UnmanagedType.I1)] bool _delete,
            [MarshalAs(UnmanagedType.I1)] bool pending,
            XAtom req_type,
            out XAtom actual_type,
            out int actual_format,
            out long nitems,
            out long bytes_after,
            out IntPtr prop);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        internal static extern RROutput XRRGetOutputPrimary(XDisplayPtr dpy, XWindow window);
    }
}
