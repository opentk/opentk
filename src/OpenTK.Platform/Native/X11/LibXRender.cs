using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    internal struct XRenderDirectFormat
    {
        public short red;
        public short redMask;
        public short green;
        public short greenMask;
        public short blue;
        public short blueMask;
        public short alpha;
        public short alphaMask;
    }

    internal struct XRenderPictFormat
    {
        public IntPtr /* PictFormat */ id;
        public int type;
        public int depth;
        public XRenderDirectFormat direct;
        public XColorMap colormap;
    }

    internal static unsafe class LibXRender
    {
        public const string XRender = "Xrender";

        [DllImport(XRender)]
        internal static extern bool XRenderQueryExtension(XDisplayPtr dpy, out int event_basep, out int error_basep);

        [DllImport(XRender)]
        internal static extern XStatus XRenderQueryVersion(XDisplayPtr dpy, out int major_versionp, out int minor_versionp);

        [DllImport(XRender)]
        internal static extern XRenderPictFormat* XRenderFindVisualFormat(XDisplayPtr dpy, XVisual* visual);
    }
}

