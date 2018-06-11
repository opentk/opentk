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
        internal WORD nSize;
        internal WORD nVersion;
        internal PixelFormatDescriptorFlags dwFlags;
        internal PixelFormatDescriptorPixelType iPixelType;
        internal BYTE cColorBits;
        internal BYTE cRedBits;
        internal BYTE cRedShift;
        internal BYTE cGreenBits;
        internal BYTE cGreenShift;
        internal BYTE cBlueBits;
        internal BYTE cBlueShift;
        internal BYTE cAlphaBits;
        internal BYTE cAlphaShift;
        internal BYTE cAccumBits;
        internal BYTE cAccumRedBits;
        internal BYTE cAccumGreenBits;
        internal BYTE cAccumBlueBits;
        internal BYTE cAccumAlphaBits;
        internal BYTE cDepthBits;
        internal BYTE cStencilBits;
        internal BYTE cAuxBuffers;
        internal BYTE iLayerType;
        internal BYTE bReserved;
        internal DWORD dwLayerMask;
        internal DWORD dwVisibleMask;
        internal DWORD dwDamageMask;
    }
}
