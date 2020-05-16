using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class OVR
    {
        public unsafe static partial class Multiview
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureMultiviewOVR")]
            public static extern void GlFramebufferTextureMultiview(uint target, uint attachment, uint texture, int level, int baseViewIndex, int numViews);
            
        }
        public unsafe static partial class Multiview2
        {
        }
        public unsafe static partial class MultiviewMultisampledRenderToTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureMultisampleMultiviewOVR")]
            public static extern void GlFramebufferTextureMultisampleMultiview(uint target, uint attachment, uint texture, int level, int samples, int baseViewIndex, int numViews);
            
        }
    }
}
