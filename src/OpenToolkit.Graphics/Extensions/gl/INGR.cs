using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class INGR
    {
        public unsafe static partial class BlendFuncSeparate
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparateINGR")]
            public static extern void GlBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
            
        }
        public unsafe static partial class ColorClamp
        {
        }
        public unsafe static partial class InterlaceRead
        {
        }
    }
}
