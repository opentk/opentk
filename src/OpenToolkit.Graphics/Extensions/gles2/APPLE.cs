using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class APPLE
    {
        public unsafe static partial class ClipDistance
        {
        }
        public unsafe static partial class ColorBufferPackedFloat
        {
        }
        public unsafe static partial class CopyTextureLevels
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureLevelsAPPLE")]
            public static extern void GlCopyTextureLevels(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount);
            
        }
        public unsafe static partial class FramebufferMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleAPPLE")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glResolveMultisampleFramebufferAPPLE")]
            public static extern void GlResolveMultisampleFramebuffer();
            
        }
        public unsafe static partial class Rgb422
        {
        }
        public unsafe static partial class Sync
        {
            [DllImport("opengl32.dll", EntryPoint = "glFenceSyncAPPLE")]
            public static extern GLsync* GlFenceSync(uint condition, uint flags);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsSyncAPPLE")]
            public static extern byte GlIsSync(GLsync* sync);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteSyncAPPLE")]
            public static extern void GlDeleteSync(GLsync* sync);
            
            [DllImport("opengl32.dll", EntryPoint = "glClientWaitSyncAPPLE")]
            public static extern uint GlClientWaitSync(GLsync* sync, uint flags, uint timeout);
            
            [DllImport("opengl32.dll", EntryPoint = "glWaitSyncAPPLE")]
            public static extern void GlWaitSync(GLsync* sync, uint flags, uint timeout);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetInteger64vAPPLE")]
            public static extern void GlGetInteger64v(uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSyncivAPPLE")]
            public static extern void GlGetSynciv(GLsync* sync, uint pname, int count, int* length, int* values);
            
        }
        public unsafe static partial class TextureFormatBgra8888
        {
        }
        public unsafe static partial class TextureMaxLevel
        {
        }
        public unsafe static partial class TexturePackedFloat
        {
        }
    }
}
