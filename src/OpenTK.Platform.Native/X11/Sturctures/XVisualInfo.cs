namespace OpenTK.Platform.Native.X11
{
    public struct XVisualInfo
    {
        public unsafe XVisual* VisualPtr;
        public XVisualId VisualId;
        public int Screen;
        public int Depth;
        public int CClass;
        public ulong RedMask;
        public ulong GreenMask;
        public ulong BlueMask;
        public int ColorMapSize;
        public int BitsPerRGB;
    }
}
