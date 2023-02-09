using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Library class for the X Resize and Rotate Extension.
    /// </summary>
    public static class XRandR
    {
        private const string xrandr = "Xrandr";

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRRQueryExtension(XDisplayPtr display, ref int eventBase, ref int errorBase);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRRQueryVersion(XDisplayPtr display, out int major, out int minor);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe XRRScreenConfiguration* XRRGetScreenInfo(XDisplayPtr display, XDrawable drawable);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void XRRFreeScreenConfigInfo(XRRScreenConfiguration* config);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XRRSelectInput(XDisplayPtr display, XWindow window, XEventMask mask);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRRUpdateConfiguration(in XEvent @event);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XRRGetScreenSizeRange(
            XDisplayPtr display,
            XWindow window,
            out int minWidth,
            out int minHeight,
            out int maxWidth,
            out int maxHeight);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe XRRScreenResources* XRRGetScreenResources(XDisplayPtr display, XWindow window);

        [DllImport(xrandr, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void XRRFreeScreenResources(XRRScreenResources* resources);
    }
}
