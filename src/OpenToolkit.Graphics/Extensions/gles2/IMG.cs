using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class IMG
    {
        public unsafe static partial class BindlessTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureHandleIMG")]
            public static extern uint GlGetTextureHandle(uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureSamplerHandleIMG")]
            public static extern uint GlGetTextureSamplerHandle(uint texture, uint sampler);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformHandleui64IMG")]
            public static extern void GlUniformHandleui64(int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformHandleui64vIMG")]
            public static extern void GlUniformHandleui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformHandleui64IMG")]
            public static extern void GlProgramUniformHandleui64(uint program, int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformHandleui64vIMG")]
            public static extern void GlProgramUniformHandleui64v(uint program, int location, int count, uint* values);
            
        }
        public unsafe static partial class FramebufferDownsample
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2DDownsampleIMG")]
            public static extern void GlFramebufferTexture2DDownsample(uint target, uint attachment, uint textarget, uint texture, int level, int xscale, int yscale);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureLayerDownsampleIMG")]
            public static extern void GlFramebufferTextureLayerDownsample(uint target, uint attachment, uint texture, int level, int layer, int xscale, int yscale);
            
        }
        public unsafe static partial class MultisampledRenderToTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleIMG")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            public static extern void GlFramebufferTexture2DMultisample(uint target, uint attachment, uint textarget, uint texture, int level, int samples);
            
        }
        public unsafe static partial class ProgramBinary
        {
        }
        public unsafe static partial class ReadFormat
        {
        }
        public unsafe static partial class ShaderBinary
        {
        }
        public unsafe static partial class TextureCompressionPvrtc
        {
        }
        public unsafe static partial class TextureCompressionPvrtc2
        {
        }
        public unsafe static partial class TextureFilterCubic
        {
        }
    }
}
