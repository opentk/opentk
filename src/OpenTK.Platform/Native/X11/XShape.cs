using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    internal static class XShape
    {
        private const string X11 = "XScreenSaver";

        internal enum Operation : int
        {
            
            ShapeSet = 0,
            ShapeUnion = 1,
            ShapeIntersect = 2,
            ShapeSubtract = 3,
            ShapeInvert = 4,
        }

        internal enum ShapeKind : int
        {
            ShapeBounding = 0,
            ShapeClip = 1,
            ShapeInput = 2,
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XShapeQueryExtension(XDisplayPtr display, out int event_base, out int error_base);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XShapeQueryVersion(XDisplayPtr display, out int major_version, out int minor_version);
        
        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XShapeCombineRegion(XDisplayPtr display, XWindow dest, ShapeKind dest_kind, int x_off, int y_off, XRegion region, Operation op);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XShapeCombineRectangles(XDisplayPtr display, XWindow dest, ShapeKind dest_kind, int x_off, int y_off, XRectangle* rectangles, int n_rects, Operation op, XOrdering ordering);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XShapeCombineMask(XDisplayPtr display, XWindow dest, ShapeKind dest_kind, int x_off, int y_off, XPixmap src, Operation op);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XShapeCombineShape(XDisplayPtr display, XWindow dest, ShapeKind dest_kind, int x_off, int y_off, XWindow src, ShapeKind src_kind, Operation op);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XShapeOffsetShape(XDisplayPtr display, XWindow dest, ShapeKind dest_kind, int x_off, int y_off);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XShapeQueryExtents(XDisplayPtr display, XWindow window, out bool bounding_shaped, out int x_bounding, out int y_bounding, out uint w_bounding, out uint h_bounding, out bool clip_shaped, out int x_clip, out int y_clip, out uint w_clip, out uint h_clip);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XShapeSelectInput(XDisplayPtr display, XWindow window, ulong mask);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong XShapeInputSelected(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XRectangle* XShapeGetRectangles(XDisplayPtr display, XWindow window, ShapeKind kind, out int count, out XOrdering ordering);
    }
}

