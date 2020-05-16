using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES1.Extensions
{
    public static partial class IMG
    {
        public unsafe static partial class MultisampledRenderToTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleIMG")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            public static extern void GlFramebufferTexture2DMultisample(uint target, uint attachment, uint textarget, uint texture, int level, int samples);
            
        }
        public unsafe static partial class ReadFormat
        {
        }
        public unsafe static partial class TextureCompressionPvrtc
        {
        }
        public unsafe static partial class TextureEnvEnhancedFixedFunction
        {
        }
        public unsafe static partial class UserClipPlane
        {
            [DllImport("opengl32.dll", EntryPoint = "glClipPlanefIMG")]
            public static extern void GlClipPlanef(uint p, float* eqn);
            
            [DllImport("opengl32.dll", EntryPoint = "glClipPlanexIMG")]
            public static extern void GlClipPlanex(uint p, int* eqn);
            
        }
    }
}
