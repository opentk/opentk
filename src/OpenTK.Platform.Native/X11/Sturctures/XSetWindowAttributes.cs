namespace OpenTK.Platform.Native.X11
{
    public struct XSetWindowAttributes
    {
        public XPixMap BackgroundPixmap;
        public ulong BackgroundPixel;
        public XPixMap BorderPixmap;
        public ulong BorderPixel;
        public int BitGravity;
        public int WindowGravity;
        public int BackingStore;
        public ulong BackingPlanes;
        public ulong BackingPixel;
        public int SaveUnder;
        public long EventMask;
        public long DoNotPropagateMask;
        public int OverrideRedirect;
        public XColorMap ColorMap;
        public XCursor Cursor;
    }
}