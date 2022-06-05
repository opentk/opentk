using System;

namespace OpenTK.Platform.Native.X11
{
    public struct XWindowAttributes
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int BorderWidth;
        public int Depth;
        public unsafe XVisual* Visual;
        public XWindow Root;
        public int CClass;
        public int BitGravity;
        public int WindowGravity;
        public int BackingStore;
        public ulong BackingPlanes;
        public ulong BackingPixel;
        public int SaveUnder;
        public XColorMap Colormap;
        public int MapInstalled;
        public int MapState;
        public XEventMask AllEventMasks;
        public XEventMask YourEventMasks;
        public XEventMask DoNotPropagateMask;
        public int OverrideRedirect;
        public IntPtr Screen; // TODO: replace with screen structure.
    }
}
