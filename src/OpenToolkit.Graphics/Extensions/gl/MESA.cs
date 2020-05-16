using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class MESA
    {
        public unsafe static partial class FramebufferFlipX
        {
        }
        public unsafe static partial class FramebufferFlipY
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferParameteriMESA")]
            public static extern void GlFramebufferParameteri(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferParameterivMESA")]
            public static extern void GlGetFramebufferParameteriv(uint target, uint pname, int* parameters);
            
        }
        public unsafe static partial class FramebufferSwapXy
        {
        }
        public unsafe static partial class PackInvert
        {
        }
        public unsafe static partial class ProgramBinaryFormats
        {
        }
        public unsafe static partial class ResizeBuffers
        {
            [DllImport("opengl32.dll", EntryPoint = "glResizeBuffersMESA")]
            public static extern void GlResizeBuffers();
            
        }
        public unsafe static partial class ShaderIntegerFunctions
        {
        }
        public unsafe static partial class TileRasterOrder
        {
        }
        public unsafe static partial class WindowPos
        {
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2dMESA")]
            public static extern void GlWindowPos2d(double x, double y);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2dvMESA")]
            public static extern void GlWindowPos2dv(double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2fMESA")]
            public static extern void GlWindowPos2f(float x, float y);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2fvMESA")]
            public static extern void GlWindowPos2fv(float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2iMESA")]
            public static extern void GlWindowPos2i(int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2ivMESA")]
            public static extern void GlWindowPos2iv(int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2sMESA")]
            public static extern void GlWindowPos2s(short x, short y);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos2svMESA")]
            public static extern void GlWindowPos2sv(short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3dMESA")]
            public static extern void GlWindowPos3d(double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3dvMESA")]
            public static extern void GlWindowPos3dv(double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3fMESA")]
            public static extern void GlWindowPos3f(float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3fvMESA")]
            public static extern void GlWindowPos3fv(float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3iMESA")]
            public static extern void GlWindowPos3i(int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3ivMESA")]
            public static extern void GlWindowPos3iv(int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3sMESA")]
            public static extern void GlWindowPos3s(short x, short y, short z);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos3svMESA")]
            public static extern void GlWindowPos3sv(short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4dMESA")]
            public static extern void GlWindowPos4d(double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4dvMESA")]
            public static extern void GlWindowPos4dv(double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4fMESA")]
            public static extern void GlWindowPos4f(float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4fvMESA")]
            public static extern void GlWindowPos4fv(float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4iMESA")]
            public static extern void GlWindowPos4i(int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4ivMESA")]
            public static extern void GlWindowPos4iv(int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4sMESA")]
            public static extern void GlWindowPos4s(short x, short y, short z, short w);
            
            [DllImport("opengl32.dll", EntryPoint = "glWindowPos4svMESA")]
            public static extern void GlWindowPos4sv(short* v);
            
        }
        public unsafe static partial class YcbcrTexture
        {
        }
    }
}
