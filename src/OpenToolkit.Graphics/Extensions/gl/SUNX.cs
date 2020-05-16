using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class SUNX
    {
        public unsafe static partial class ConstantData
        {
            [DllImport("opengl32.dll", EntryPoint = "glFinishTextureSUNX")]
            public static extern void GlFinishTexture();
            
        }
    }
}
