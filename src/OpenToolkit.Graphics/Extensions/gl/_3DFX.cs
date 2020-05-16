using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class _3DFX
    {
        public unsafe static partial class Multisample
        {
        }
        public unsafe static partial class Tbuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glTbufferMask3DFX")]
            public static extern void GlTbufferMask(uint mask);
            
        }
        public unsafe static partial class TextureCompressionFxt1
        {
        }
    }
}
