using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.Wgl {

    [Flags]
    public enum PixelFormatDescriptorFlags : int
    {
        // PixelFormatDescriptor flags
        DOUBLEBUFFER = 0x01,
        STEREO = 0x02,
        DRAW_TO_WINDOW = 0x04,
        DRAW_TO_BITMAP = 0x08,
        SUPPORT_GDI = 0x10,
        SUPPORT_OPENGL = 0x20,
        GENERIC_FORMAT = 0x40,
        NEED_PALETTE = 0x80,
        NEED_SYSTEM_PALETTE = 0x100,
        SWAP_EXCHANGE = 0x200,
        SWAP_COPY = 0x400,
        SWAP_LAYER_BUFFERS = 0x800,
        GENERIC_ACCELERATED = 0x1000,
        SUPPORT_DIRECTDRAW = 0x2000,
        SUPPORT_COMPOSITION = 0x8000,

        // PixelFormatDescriptor flags for use in ChoosePixelFormat only
        DEPTH_DONTCARE = unchecked((int)0x20000000),
        DOUBLEBUFFER_DONTCARE = unchecked((int)0x40000000),
        STEREO_DONTCARE = unchecked((int)0x80000000)
    }

    public enum PixelType : byte
    {
        RGBA = 0,
        INDEXED = 1
    }

    /// <summary>
    /// Describes a pixel format. It is used when interfacing with the WINAPI to create a new Context.
    /// Found in WinGDI.h
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormatDescriptor
    {
        public short Size;
        public short Version;
        public PixelFormatDescriptorFlags Flags;
        public PixelType PixelType;
        public byte ColorBits;
        public byte RedBits;
        public byte RedShift;
        public byte GreenBits;
        public byte GreenShift;
        public byte BlueBits;
        public byte BlueShift;
        public byte AlphaBits;
        public byte AlphaShift;
        public byte AccumBits;
        public byte AccumRedBits;
        public byte AccumGreenBits;
        public byte AccumBlueBits;
        public byte AccumAlphaBits;
        public byte DepthBits;
        public byte StencilBits;
        public byte AuxBuffers;
        public byte LayerType;
        public byte Reserved;
        public int LayerMask;
        public int VisibleMask;
        public int DamageMask;
    }

}
