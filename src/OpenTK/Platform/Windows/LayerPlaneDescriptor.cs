using System.Runtime.InteropServices;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Describes the pixel format of a drawing surface.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct LayerPlaneDescriptor
    {
        internal static readonly short Size = (short)Marshal.SizeOf(typeof(LayerPlaneDescriptor));
        internal short Version;
        internal int Flags;
        internal byte PixelType;
        internal byte ColorBits;
        internal byte RedBits;
        internal byte RedShift;
        internal byte GreenBits;
        internal byte GreenShift;
        internal byte BlueBits;
        internal byte BlueShift;
        internal byte AlphaBits;
        internal byte AlphaShift;
        internal byte AccumBits;
        internal byte AccumRedBits;
        internal byte AccumGreenBits;
        internal byte AccumBlueBits;
        internal byte AccumAlphaBits;
        internal byte DepthBits;
        internal byte StencilBits;
        internal byte AuxBuffers;
        internal byte LayerPlane;
        private readonly byte Reserved;
        internal int crTransparent;
    }
}
