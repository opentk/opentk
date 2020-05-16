using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class MESA
    {
        public unsafe static partial class FramebufferFlipX
        {
        }
        public unsafe static partial class FramebufferFlipY
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferParameteriMESA")]
            public static extern void GlFramebufferParameteri(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferParameterivMESA")]
            public static extern void GlGetFramebufferParameteriv(uint target, uint pname, int* parameters);
            
        }
        public unsafe static partial class FramebufferSwapXy
        {
        }
        public unsafe static partial class ProgramBinaryFormats
        {
        }
        public unsafe static partial class ShaderIntegerFunctions
        {
        }
    }
}
