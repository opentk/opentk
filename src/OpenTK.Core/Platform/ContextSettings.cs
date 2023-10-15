using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    // FIXME: Some way of relaying the actually chosen values to the user.

    /// <summary>
    /// Settings for creating OpenGL contexts.
    /// </summary>
    public class ContextSettings
    {
        /// <summary>
        /// If double buffering should be enabled.
        /// </summary>
        public bool DoubleBuffer { get; set; }

        /// <summary>
        /// If sRGB default framebuffer should be enabled.
        /// </summary>
        public bool sRGBFramebuffer { get; set; }

        /// <summary>
        /// If the backbuffer should support multisample.
        /// </summary>
        public bool Multisample { get; set; }

        /// <summary>
        /// How many samples the backbuffer should have if it supports multisampling.
        /// </summary>
        public int Samples { get; set; }

        /// <summary>
        /// The number of bits to represent the red channel.
        /// </summary>
        public int RedBits { get; set; } = 8;

        /// <summary>
        /// The number of bits to represent the green channel.
        /// </summary>
        public int GreenBits { get; set; } = 8;

        /// <summary>
        /// The number of bits to represent the blue channel.
        /// </summary>
        public int BlueBits { get; set; } = 8;

        /// <summary>
        /// The number of bits to represent the alpha channel.
        /// </summary>
        public int AlphaBits { get; set; } = 8;

        /// <summary>
        /// The number of bits to represent the depth backbuffer.
        /// </summary>
        public ContextDepthBits DepthBits { get; set; } = ContextDepthBits.Depth24;

        /// <summary>
        /// The number of bits to represent the stencil backbuffer.
        /// </summary>
        public ContextStencilBits StencilBits { get; set; } = ContextStencilBits.Stencil8;
    }

    public struct ContextValues
    {
        public int RedBits;
        public int GreenBits;
        public int BlueBits;
        public int AlphaBits;
        public int DepthBits;
        public int StencilBits;
        public bool DoubleBuffered;
        public bool SRGBFramebuffer;
        public bool Multisample;
        public int Samples;
    }

    /// <summary>
    /// Represents the number of depth bits of the context depth backbuffer.
    /// </summary>
    public enum ContextDepthBits
    {
        /// <summary>
        /// No depth buffer.
        /// </summary>
        None = 0,

        /// <summary>
        /// 24-bit depth buffer.
        /// </summary>
        Depth24 = 24,

        /// <summary>
        /// 32-bit depth buffer.
        /// </summary>
        Depth32 = 32,
    }

    /// <summary>
    /// Represents the number of depth bits of the context stencil backbuffer.
    /// </summary>
    public enum ContextStencilBits
    {
        /// <summary>
        /// No stencil bits needed.
        /// </summary>
        None = 0,

        /// <summary>
        /// 1-bit stencil buffer.
        /// </summary>
        Stencil1 = 1,

        /// <summary>
        /// 8-bit stencil buffer.
        /// </summary>
        Stencil8 = 8,
    }
}
