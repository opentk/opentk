namespace OpenTK.Platform.Native.X11
{
    public struct XSetWindowAttributes
    {
        public XPixmap BackgroundPixmap;
        public ulong BackgroundPixel;
        public XPixmap BorderPixmap;
        public ulong BorderPixel;
        public int BitGravity;
        public int WindowGravity;
        public int BackingStore;
        public ulong BackingPlanes;
        public ulong BackingPixel;
        public int SaveUnder;
        public XEventMask EventMask;
        public XEventMask DoNotPropagateMask;
        public int OverrideRedirect;
        public XColorMap ColorMap;
        public XCursor Cursor;
    }
}
