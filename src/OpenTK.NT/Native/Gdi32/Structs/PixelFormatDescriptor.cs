using System.Runtime.InteropServices;

using BYTE = System.Byte;
using DWORD= System.UInt32;
using WORD = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Describes a pixel format. It is used when interfacing with the WINAPI to create a new Context.
    /// Found in WinGDI.h
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormatDescriptor
    {
        public WORD Size;
        public WORD Version;
        public PixelFormatDescriptorFlags Flags;
        public PixelFormatDescriptorPixelTypes PixelType;
        public BYTE ColorBits;
        public BYTE RedBits;
        public BYTE RedShift;
        public BYTE GreenBits;
        public BYTE GreenShift;
        public BYTE BlueBits;
        public BYTE BlueShift;
        public BYTE AlphaBits;
        public BYTE AlphaShift;
        public BYTE AccumBits;
        public BYTE AccumRedBits;
        public BYTE AccumGreenBits;
        public BYTE AccumBlueBits;
        public BYTE AccumAlphaBits;
        public BYTE DepthBits;
        public BYTE StencilBits;
        public BYTE AuxBuffers;
        public PixelFormatDescriptorLayerTypes LayerType;
        public BYTE Reserved;
        public DWORD LayerMask;
        public DWORD VisibleMask;
        public DWORD DamageMask;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<PixelFormatDescriptor>();
    }
}
