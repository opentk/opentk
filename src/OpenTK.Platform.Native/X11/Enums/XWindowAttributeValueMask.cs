using System;

namespace OpenTK.Platform.Native.X11
{
    [Flags]
    public enum XWindowAttributeValueMask : long
    {
        BackPixmap = 1 << 0,
        BackPixel = 1 << 1,
        BorderPixmap = 1 << 2,
        BorderPixel = 1 << 3,
        BitGravity = 1 << 4,
        WindowGravity = 1 << 5,
        BackingStore = 1 << 6,
        BackingPlanes = 1 << 7,
        BackingPixel =  1 << 8,
        OverrideRedirect =  1 << 9,
        SaveUnder =  1 << 10,
        EventMask =  1 << 11,
        DontPropagate =  1 << 12,
        Colormap =  1 << 13,
        Cursor = 1 << 14
    }
}
