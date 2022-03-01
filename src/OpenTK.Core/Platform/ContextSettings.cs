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

        // FIXME: Color depth bits??

        public ContextDepthBits DepthBits { get; set; }

        public ContextStencilBits StencilBits { get; set; }
    }

    public struct ContextValues
    {
        public int ColorBits;
        public int DepthBits;
        public int StencilBits;
        public bool DoubleBuffered;
        public bool SRGBFramebuffer;
        public bool Multisample;
        public int Samples;
    }

    public enum ContextDepthBits
    {
        Depth24,
        Depth32,
    }

    public enum ContextStencilBits
    {
        Stencil1,
        Stencil8,
    }
}
