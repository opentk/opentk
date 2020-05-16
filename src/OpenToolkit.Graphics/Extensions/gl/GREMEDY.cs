using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class GREMEDY
    {
        public unsafe static partial class FrameTerminator
        {
            [DllImport("opengl32.dll", EntryPoint = "glFrameTerminatorGREMEDY")]
            public static extern void GlFrameTerminator();
            
        }
        public unsafe static partial class StringMarker
        {
            [DllImport("opengl32.dll", EntryPoint = "glStringMarkerGREMEDY")]
            public static extern void GlStringMarker(int len, void* str);
            
        }
    }
}
