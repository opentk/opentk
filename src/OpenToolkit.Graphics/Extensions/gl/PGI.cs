using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class PGI
    {
        public unsafe static partial class MiscHints
        {
            [DllImport("opengl32.dll", EntryPoint = "glHintPGI")]
            public static extern void GlHint(uint target, int mode);
            
        }
        public unsafe static partial class VertexHints
        {
        }
    }
}
