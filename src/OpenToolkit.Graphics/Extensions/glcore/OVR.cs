using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLCORE.Extensions
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
    }
}
