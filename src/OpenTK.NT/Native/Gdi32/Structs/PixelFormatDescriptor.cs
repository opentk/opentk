using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Describes the pixel format of a drawing surface.
    /// </summary>
    /// <remarks>
    /// Please notice carefully that certain pixel format properties are not supported in the current generic
    /// implementation. The generic implementation is the Microsoft GDI software implementation of OpenGL.
    /// Hardware manufacturers may enhance parts of OpenGL, and may support some pixel format properties
    /// not supported by the generic implementation.
    /// </remarks>
    public struct PixelFormatDescriptor
    {
        /// <summary>
        /// Specifies the size of this data structure. This value should be set to <see cref="SizeInBytes"/>.
        /// </summary>
        public ushort Size;

        /// <summary>
        /// Specifies the version of this data structure. This value should be set to 1.
        /// </summary>
        public ushort Version;

        /// <summary>
        /// A set of bit flags that specify properties of the pixel buffer. The properties are generally
        /// not mutually exclusive; you can set any combination of bit flags, with the exceptions noted.
        /// <seealso cref="PixelFormatDescriptorFlags"/>
        /// </summary>
        public PixelFormatDescriptorFlags Flags;

        /// <summary>
        /// Specifies the type of pixel data.
        /// <seealso cref="PixelFormatDescriptorPixelTypes"/>
        /// </summary>
        public PixelFormatDescriptorPixelTypes PixelType;

        /// <summary>
        /// Specifies the number of color bitplanes in each color buffer. For RGBA pixel types, it is the size of the
        /// color buffer, excluding the alpha bitplanes.
        /// For color-index pixels, it is the size of the color-index buffer.
        /// </summary>
        public byte ColorBits;

        /// <summary>
        /// Specifies the number of red bitplanes in each RGBA color buffer.
        /// </summary>
        public byte RedBits;

        /// <summary>
        /// Specifies the shift count for red bitplanes in each RGBA color buffer.
        /// </summary>
        public byte RedShift;

        /// <summary>
        /// Specifies the number of green bitplanes in each RGBA color buffer.
        /// </summary>
        public byte GreenBits;

        /// <summary>
        /// Specifies the shift count for green bitplanes in each RGBA color buffer.
        /// </summary>
        public byte GreenShift;

        /// <summary>
        /// Specifies the number of blue bitplanes in each RGBA color buffer.
        /// </summary>
        public byte BlueBits;

        /// <summary>
        /// Specifies the shift count for blue bitplanes in each RGBA color buffer.
        /// </summary>
        public byte BlueShift;

        /// <summary>
        /// Specifies the number of alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
        /// </summary>
        public byte AlphaBits;

        /// <summary>
        /// Specifies the shift count for alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
        /// </summary>
        public byte AlphaShift;

        /// <summary>
        /// Specifies the total number of bitplanes in the accumulation buffer.
        /// </summary>
        public byte AccumBits;

        /// <summary>
        /// Specifies the number of red bitplanes in the accumulation buffer.
        /// </summary>
        public byte AccumRedBits;

        /// <summary>
        /// Specifies the number of green bitplanes in the accumulation buffer.
        /// </summary>
        public byte AccumGreenBits;

        /// <summary>
        /// Specifies the number of blue bitplanes in the accumulation buffer.
        /// </summary>
        public byte AccumBlueBits;

        /// <summary>
        /// Specifies the number of alpha bitplanes in the accumulation buffer.
        /// </summary>
        public byte AccumAlphaBits;

        /// <summary>
        /// Specifies the depth of the depth (z-axis) buffer.
        /// </summary>
        public byte DepthBits;

        /// <summary>
        /// Specifies the depth of the stencil buffer.
        /// </summary>
        public byte StencilBits;

        /// <summary>
        /// Specifies the number of auxiliary buffers. Auxiliary buffers are not supported.
        /// </summary>
        public byte AuxBuffers;

        /// <summary>
        /// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
        /// </summary>
        public PixelFormatDescriptorLayerTypes LayerType;

        /// <summary>
        /// Specifies the number of overlay and underlay planes. Bits 0 through 3 specify up to 15 overlay planes
        /// and bits 4 through 7 specify up to 15 underlay planes.
        /// </summary>
        public byte Reserved;

        /// <summary>
        /// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
        /// </summary>
        public uint LayerMask;

        /// <summary>
        /// Specifies the transparent color or index of an underlay plane. When the pixel type is RGBA,
        /// <see cref="VisibleMask"/> is a transparent RGB color value. When the pixel type is color index,
        /// it is a transparent index value.
        /// </summary>
        public uint VisibleMask;

        /// <summary>
        /// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
        /// </summary>
        public uint DamageMask;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<PixelFormatDescriptor>();
    }
}
