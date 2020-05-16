using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLCORE.Extensions
{
    public static partial class KHR
    {
        public unsafe static partial class BlendEquationAdvanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendBarrierKHR")]
            public static extern void GlBlendBarrier();
            
        }
        public unsafe static partial class BlendEquationAdvancedCoherent
        {
        }
        public unsafe static partial class ContextFlushControl
        {
        }
        public unsafe static partial class Debug
        {
        }
        public unsafe static partial class NoError
        {
        }
        public unsafe static partial class RobustBufferAccessBehavior
        {
        }
        public unsafe static partial class Robustness
        {
        }
        public unsafe static partial class ShaderSubgroup
        {
        }
        public unsafe static partial class TextureCompressionAstcHdr
        {
        }
        public unsafe static partial class TextureCompressionAstcLdr
        {
        }
        public unsafe static partial class TextureCompressionAstcSliced3d
        {
        }
        public unsafe static partial class ParallelShaderCompile
        {
            [DllImport("opengl32.dll", EntryPoint = "glMaxShaderCompilerThreadsKHR")]
            public static extern void GlMaxShaderCompilerThreads(uint count);
            
        }
    }
}
