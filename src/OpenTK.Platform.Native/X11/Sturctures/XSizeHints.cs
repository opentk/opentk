namespace OpenTK.Platform.Native.X11
{
    public struct XSizeHints
    {
        public XSizeHintFlags Flags;
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int MinWidth;
        public int MinHeight;
        public int MaxWidth;
        public int MaxHeight;
        public int WidthIncrement;
        public int HeightIncrement;
        public int MinAspectNumerator;
        public int MinAspectDenominator;
        public int MaxAspectNumerator;
        public int MaxAspectDenominator;
        public int BaseWidth;
        public int BaseHeight;
        public int WindowGravity;
    }
}