using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class SGIS
    {
        public unsafe static partial class DetailTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glDetailTexFuncSGIS")]
            public static extern void GlDetailTexFunc(uint target, int n, float* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDetailTexFuncSGIS")]
            public static extern void GlGetDetailTexFunc(uint target, float* points);
            
        }
        public unsafe static partial class FogFunction
        {
            [DllImport("opengl32.dll", EntryPoint = "glFogFuncSGIS")]
            public static extern void GlFogFunc(int n, float* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFogFuncSGIS")]
            public static extern void GlGetFogFunc(float* points);
            
        }
        public unsafe static partial class GenerateMipmap
        {
        }
        public unsafe static partial class Multisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glSampleMaskSGIS")]
            public static extern void GlSampleMask(float value, byte invert);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplePatternSGIS")]
            public static extern void GlSamplePattern(uint pattern);
            
        }
        public unsafe static partial class PixelTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glPixelTexGenParameteriSGIS")]
            public static extern void GlPixelTexGenParameteri(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelTexGenParameterivSGIS")]
            public static extern void GlPixelTexGenParameteriv(uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelTexGenParameterfSGIS")]
            public static extern void GlPixelTexGenParameterf(uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelTexGenParameterfvSGIS")]
            public static extern void GlPixelTexGenParameterfv(uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPixelTexGenParameterivSGIS")]
            public static extern void GlGetPixelTexGenParameteriv(uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPixelTexGenParameterfvSGIS")]
            public static extern void GlGetPixelTexGenParameterfv(uint pname, float* parameters);
            
        }
        public unsafe static partial class PointLineTexgen
        {
        }
        public unsafe static partial class PointParameters
        {
            [DllImport("opengl32.dll", EntryPoint = "glPointParameterfSGIS")]
            public static extern void GlPointParameterf(uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPointParameterfvSGIS")]
            public static extern void GlPointParameterfv(uint pname, float* parameters);
            
        }
        public unsafe static partial class SharpenTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glSharpenTexFuncSGIS")]
            public static extern void GlSharpenTexFunc(uint target, int n, float* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSharpenTexFuncSGIS")]
            public static extern void GlGetSharpenTexFunc(uint target, float* points);
            
        }
        public unsafe static partial class Texture4d
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexImage4DSGIS")]
            public static extern void GlTexImage4D(uint target, int level, uint internalformat, int width, int height, int depth, int size4d, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexSubImage4DSGIS")]
            public static extern void GlTexSubImage4D(uint target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, uint format, uint type, void* pixels);
            
        }
        public unsafe static partial class TextureBorderClamp
        {
        }
        public unsafe static partial class TextureColorMask
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureColorMaskSGIS")]
            public static extern void GlTextureColorMask(byte red, byte green, byte blue, byte alpha);
            
        }
        public unsafe static partial class TextureEdgeClamp
        {
        }
        public unsafe static partial class TextureFilter4
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetTexFilterFuncSGIS")]
            public static extern void GlGetTexFilterFunc(uint target, uint filter, float* weights);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexFilterFuncSGIS")]
            public static extern void GlTexFilterFunc(uint target, uint filter, int n, float* weights);
            
        }
        public unsafe static partial class TextureLod
        {
        }
        public unsafe static partial class TextureSelect
        {
        }
    }
}
