using BYTE = System.Byte;

namespace OpenTK.NT.Native
{
    public enum PixelFormatDescriptorLayerTypes : BYTE
    {
        MainPlane = 0,
        OverlayPlane = 1,
        UnderlayPlane = unchecked((BYTE)(-1))
    }
}
