using System;

namespace OpenTK.Platform.Native.X11
{
    public struct XVisual
    {
        public IntPtr ExtensionData;
        public XVisualId VisualID;
        public int CClass;
        public ulong RedMask;
        public ulong GreenMask;
        public ulong BlueMask;
        public int BitsPerRgb;
        public int MapEntries;
    }
}
