using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
    internal static unsafe class LibXcursor
    {
        private const string Xcursor = "Xcursor";

        static LibXcursor()
        {
            DllResolver.InitLoader();
        }


        internal struct XcursorImage
        {
            public uint version;     /* version of the image data */
            public uint size;        /* nominal size for matching */
            public uint width;       /* actual width */
            public uint height;      /* actual height */
            public uint xhot;        /* hot spot x (must be inside image) */
            public uint yhot;        /* hot spot y (must be inside image) */
            public uint delay;       /* animation delay to next frame (ms) */
            public uint* pixels;      /* pointer to pixels */
        }

        [DllImport(Xcursor)]
        internal static extern XcursorImage* XcursorImageCreate(int width, int height);

        [DllImport(Xcursor)]
        internal static extern void XcursorImageDestroy(XcursorImage* image);

        [DllImport(Xcursor)]
        internal static extern XCursor XcursorImageLoadCursor(XDisplayPtr dpy, XcursorImage* image);
    }
#pragma warning restore CS0649 // Field '' is never assigned to, and will always have its default value 0
}
