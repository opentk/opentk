using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    // FIXME: Some way of relaying the actually chosen values to the user.
    public class ContextSettings
    {
        public bool DoubleBuffer { get; set; }

        public bool sRGBFramebuffer { get; set; }

        public bool Multisample { get; set; }

        public int Samples { get; set; }

        public int RedBits { get; set; } = 8;

        public int GreenBits { get; set; } = 8;

        public int BlueBits { get; set; } = 8;

        public int AlphaBits { get; set; } = 8;

        public ContextDepthBits DepthBits { get; set; } = ContextDepthBits.Depth24;

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

    public enum ContextDepthBits
    {
        None,
        Depth24,
        Depth32,
    }

    public enum ContextStencilBits
    {
        None,
        Stencil1,
        Stencil8,
    }
}
