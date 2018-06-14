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
        public WORD nSize;
        public WORD nVersion;
        public PixelFormatDescriptorFlags dwFlags;
        public PixelFormatDescriptorPixelTypes iPixelType;
        public BYTE cColorBits;
        public BYTE cRedBits;
        public BYTE cRedShift;
        public BYTE cGreenBits;
        public BYTE cGreenShift;
        public BYTE cBlueBits;
        public BYTE cBlueShift;
        public BYTE cAlphaBits;
        public BYTE cAlphaShift;
        public BYTE cAccumBits;
        public BYTE cAccumRedBits;
        public BYTE cAccumGreenBits;
        public BYTE cAccumBlueBits;
        public BYTE cAccumAlphaBits;
        public BYTE cDepthBits;
        public BYTE cStencilBits;
        public BYTE cAuxBuffers;
        public PixelFormatDescriptorLayerTypes iLayerType;
        public BYTE bReserved;
        public DWORD dwLayerMask;
        public DWORD dwVisibleMask;
        public DWORD dwDamageMask;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<PixelFormatDescriptor>();
    }
}
