using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class ANGLE
    {
        public unsafe static partial class DepthTexture
        {
        }
        public unsafe static partial class FramebufferBlit
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlitFramebufferANGLE")]
            public static extern void GlBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
            
        }
        public unsafe static partial class FramebufferMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleANGLE")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
        }
        public unsafe static partial class InstancedArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedANGLE")]
            public static extern void GlDrawArraysInstanced(uint mode, int first, int count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedANGLE")]
            public static extern void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribDivisorANGLE")]
            public static extern void GlVertexAttribDivisor(uint index, uint divisor);
            
        }
        public unsafe static partial class PackReverseRowOrder
        {
        }
        public unsafe static partial class ProgramBinary
        {
        }
        public unsafe static partial class TextureCompressionDxt3
        {
        }
        public unsafe static partial class TextureCompressionDxt5
        {
        }
        public unsafe static partial class TextureUsage
        {
        }
        public unsafe static partial class TranslatedShaderSource
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetTranslatedShaderSourceANGLE")]
            public static extern void GlGetTranslatedShaderSource(uint shader, int bufSize, int* length, char* source);
            
        }
    }
}
