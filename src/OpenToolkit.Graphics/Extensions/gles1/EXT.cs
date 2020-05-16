using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES1.Extensions
{
    public static partial class EXT
    {
        public unsafe static partial class BlendMinmax
        {
        }
        public unsafe static partial class DebugMarker
        {
            [DllImport("opengl32.dll", EntryPoint = "glInsertEventMarkerEXT")]
            public static extern void GlInsertEventMarker(int length, char* marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glPushGroupMarkerEXT")]
            public static extern void GlPushGroupMarker(int length, char* marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glPopGroupMarkerEXT")]
            public static extern void GlPopGroupMarker();
            
        }
        public unsafe static partial class DiscardFramebuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glDiscardFramebufferEXT")]
            public static extern void GlDiscardFramebuffer(uint target, int numAttachments, uint* attachments);
            
        }
        public unsafe static partial class MapBufferRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glMapBufferRangeEXT")]
            public static extern void* GlMapBufferRange(uint target, IntPtr offset, IntPtr length, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushMappedBufferRangeEXT")]
            public static extern void GlFlushMappedBufferRange(uint target, IntPtr offset, IntPtr length);
            
        }
        public unsafe static partial class MultiDrawArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysEXT")]
            public static extern void GlMultiDrawArrays(uint mode, int* first, int* count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern void GlMultiDrawElements(uint mode, int* count, uint type, void** indices, int primcount);
            
        }
        public unsafe static partial class MultisampledRenderToTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleEXT")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            public static extern void GlFramebufferTexture2DMultisample(uint target, uint attachment, uint textarget, uint texture, int level, int samples);
            
        }
        public unsafe static partial class ReadFormatBgra
        {
        }
        public unsafe static partial class Robustness
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetGraphicsResetStatusEXT")]
            public static extern uint GlGetGraphicsResetStatus();
            
            [DllImport("opengl32.dll", EntryPoint = "glReadnPixelsEXT")]
            public static extern void GlReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformfvEXT")]
            public static extern void GlGetnUniformfv(uint program, int location, int bufSize, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformivEXT")]
            public static extern void GlGetnUniformiv(uint program, int location, int bufSize, int* parameters);
            
        }
        public unsafe static partial class Srgb
        {
        }
        public unsafe static partial class TextureCompressionDxt1
        {
        }
        public unsafe static partial class TextureFilterAnisotropic
        {
        }
        public unsafe static partial class TextureFormatBgra8888
        {
        }
        public unsafe static partial class TextureLodBias
        {
        }
        public unsafe static partial class TextureStorage
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage1DEXT")]
            public static extern void GlTexStorage1D(uint target, int levels, uint internalformat, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage2DEXT")]
            public static extern void GlTexStorage2D(uint target, int levels, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage3DEXT")]
            public static extern void GlTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage1DEXT")]
            public static extern void GlTextureStorage1D(uint texture, uint target, int levels, uint internalformat, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage2DEXT")]
            public static extern void GlTextureStorage2D(uint texture, uint target, int levels, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage3DEXT")]
            public static extern void GlTextureStorage3D(uint texture, uint target, int levels, uint internalformat, int width, int height, int depth);
            
        }
    }
}
