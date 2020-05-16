using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class HP
    {
        public unsafe static partial class ConvolutionBorderModes
        {
        }
        public unsafe static partial class ImageTransform
        {
            [DllImport("opengl32.dll", EntryPoint = "glImageTransformParameteriHP")]
            public static extern void GlImageTransformParameteri(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glImageTransformParameterfHP")]
            public static extern void GlImageTransformParameterf(uint target, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glImageTransformParameterivHP")]
            public static extern void GlImageTransformParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glImageTransformParameterfvHP")]
            public static extern void GlImageTransformParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetImageTransformParameterivHP")]
            public static extern void GlGetImageTransformParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetImageTransformParameterfvHP")]
            public static extern void GlGetImageTransformParameterfv(uint target, uint pname, float* parameters);
            
        }
        public unsafe static partial class OcclusionTest
        {
        }
        public unsafe static partial class TextureLighting
        {
        }
    }
}
