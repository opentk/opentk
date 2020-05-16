using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class SGI
    {
        public unsafe static partial class ColorMatrix
        {
        }
        public unsafe static partial class ColorTable
        {
            [DllImport("opengl32.dll", EntryPoint = "glColorTableSGI")]
            public static extern void GlColorTable(uint target, uint internalformat, int width, uint format, uint type, void* table);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorTableParameterfvSGI")]
            public static extern void GlColorTableParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorTableParameterivSGI")]
            public static extern void GlColorTableParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyColorTableSGI")]
            public static extern void GlCopyColorTable(uint target, uint internalformat, int x, int y, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetColorTableSGI")]
            public static extern void GlGetColorTable(uint target, uint format, uint type, void* table);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetColorTableParameterfvSGI")]
            public static extern void GlGetColorTableParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetColorTableParameterivSGI")]
            public static extern void GlGetColorTableParameteriv(uint target, uint pname, int* parameters);
            
        }
        public unsafe static partial class TextureColorTable
        {
        }
    }
}
