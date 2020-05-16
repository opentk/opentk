using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES1.Extensions
{
    public static partial class NV
    {
        public unsafe static partial class Fence
        {
            [DllImport("opengl32.dll", EntryPoint = "glDeleteFencesNV")]
            public static extern void GlDeleteFences(int n, uint* fences);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenFencesNV")]
            public static extern void GlGenFences(int n, uint* fences);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsFenceNV")]
            public static extern byte GlIsFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glTestFenceNV")]
            public static extern byte GlTestFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFenceivNV")]
            public static extern void GlGetFenceiv(uint fence, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFinishFenceNV")]
            public static extern void GlFinishFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glSetFenceNV")]
            public static extern void GlSetFence(uint fence, uint condition);
            
        }
    }
}
