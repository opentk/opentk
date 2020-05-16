using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class IBM
    {
        public unsafe static partial class CullVertex
        {
        }
        public unsafe static partial class MultimodeDrawArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiModeDrawArraysIBM")]
            public static extern void GlMultiModeDrawArrays(uint* mode, int* first, int* count, int primcount, int modestride);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiModeDrawElementsIBM")]
            public static extern void GlMultiModeDrawElements(uint* mode, int* count, uint type, void** indices, int primcount, int modestride);
            
        }
        public unsafe static partial class RasterposClip
        {
        }
        public unsafe static partial class StaticData
        {
            [DllImport("opengl32.dll", EntryPoint = "glFlushStaticDataIBM")]
            public static extern void GlFlushStaticData(uint target);
            
        }
        public unsafe static partial class TextureMirroredRepeat
        {
        }
        public unsafe static partial class VertexArrayLists
        {
            [DllImport("opengl32.dll", EntryPoint = "glColorPointerListIBM")]
            public static extern void GlColorPointerList(int size, uint type, int stride, void** pointer, int ptrstride);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColorPointerListIBM")]
            public static extern void GlSecondaryColorPointerList(int size, uint type, int stride, void** pointer, int ptrstride);
            
            [DllImport("opengl32.dll", EntryPoint = "glEdgeFlagPointerListIBM")]
            public static extern void GlEdgeFlagPointerList(int stride, byte** pointer, int ptrstride);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoordPointerListIBM")]
            public static extern void GlFogCoordPointerList(uint type, int stride, void** pointer, int ptrstride);
            
            [DllImport("opengl32.dll", EntryPoint = "glIndexPointerListIBM")]
            public static extern void GlIndexPointerList(uint type, int stride, void** pointer, int ptrstride);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalPointerListIBM")]
            public static extern void GlNormalPointerList(uint type, int stride, void** pointer, int ptrstride);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoordPointerListIBM")]
            public static extern void GlTexCoordPointerList(int size, uint type, int stride, void** pointer, int ptrstride);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexPointerListIBM")]
            public static extern void GlVertexPointerList(int size, uint type, int stride, void** pointer, int ptrstride);
            
        }
    }
}
