using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class APPLE
    {
        public unsafe static partial class AuxDepthStencil
        {
        }
        public unsafe static partial class ClientStorage
        {
        }
        public unsafe static partial class ElementArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glElementPointerAPPLE")]
            public static extern void GlElementPointer(uint type, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementArrayAPPLE")]
            public static extern void GlDrawElementArray(uint mode, int first, int count);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementArrayAPPLE")]
            public static extern void GlDrawRangeElementArray(uint mode, uint start, uint end, int first, int count);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementArrayAPPLE")]
            public static extern void GlMultiDrawElementArray(uint mode, int* first, int* count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
            public static extern void GlMultiDrawRangeElementArray(uint mode, uint start, uint end, int* first, int* count, int primcount);
            
        }
        public unsafe static partial class Fence
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenFencesAPPLE")]
            public static extern void GlGenFences(int n, uint* fences);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteFencesAPPLE")]
            public static extern void GlDeleteFences(int n, uint* fences);
            
            [DllImport("opengl32.dll", EntryPoint = "glSetFenceAPPLE")]
            public static extern void GlSetFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsFenceAPPLE")]
            public static extern byte GlIsFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glTestFenceAPPLE")]
            public static extern byte GlTestFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glFinishFenceAPPLE")]
            public static extern void GlFinishFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glTestObjectAPPLE")]
            public static extern byte GlTestObject(uint obj, uint name);
            
            [DllImport("opengl32.dll", EntryPoint = "glFinishObjectAPPLE")]
            public static extern void GlFinishObject(uint obj, int name);
            
        }
        public unsafe static partial class FloatPixels
        {
        }
        public unsafe static partial class FlushBufferRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glBufferParameteriAPPLE")]
            public static extern void GlBufferParameteri(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushMappedBufferRangeAPPLE")]
            public static extern void GlFlushMappedBufferRange(uint target, IntPtr offset, IntPtr size);
            
        }
        public unsafe static partial class ObjectPurgeable
        {
            [DllImport("opengl32.dll", EntryPoint = "glObjectPurgeableAPPLE")]
            public static extern uint GlObjectPurgeable(uint objectType, uint name, uint option);
            
            [DllImport("opengl32.dll", EntryPoint = "glObjectUnpurgeableAPPLE")]
            public static extern uint GlObjectUnpurgeable(uint objectType, uint name, uint option);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetObjectParameterivAPPLE")]
            public static extern void GlGetObjectParameteriv(uint objectType, uint name, uint pname, int* parameters);
            
        }
        public unsafe static partial class Rgb422
        {
        }
        public unsafe static partial class RowBytes
        {
        }
        public unsafe static partial class SpecularVector
        {
        }
        public unsafe static partial class TextureRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureRangeAPPLE")]
            public static extern void GlTextureRange(uint target, int length, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterPointervAPPLE")]
            public static extern void GlGetTexParameterPointerv(uint target, uint pname, void** parameters);
            
        }
        public unsafe static partial class TransformHint
        {
        }
        public unsafe static partial class VertexArrayObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindVertexArrayAPPLE")]
            public static extern void GlBindVertexArray(uint array);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteVertexArraysAPPLE")]
            public static extern void GlDeleteVertexArrays(int n, uint* arrays);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenVertexArraysAPPLE")]
            public static extern void GlGenVertexArrays(int n, uint* arrays);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsVertexArrayAPPLE")]
            public static extern byte GlIsVertexArray(uint array);
            
        }
        public unsafe static partial class VertexArrayRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayRangeAPPLE")]
            public static extern void GlVertexArrayRange(int length, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushVertexArrayRangeAPPLE")]
            public static extern void GlFlushVertexArrayRange(int length, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayParameteriAPPLE")]
            public static extern void GlVertexArrayParameteri(uint pname, int param);
            
        }
        public unsafe static partial class VertexProgramEvaluators
        {
            [DllImport("opengl32.dll", EntryPoint = "glEnableVertexAttribAPPLE")]
            public static extern void GlEnableVertexAttrib(uint index, uint pname);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableVertexAttribAPPLE")]
            public static extern void GlDisableVertexAttrib(uint index, uint pname);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsVertexAttribEnabledAPPLE")]
            public static extern byte GlIsVertexAttribEnabled(uint index, uint pname);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapVertexAttrib1dAPPLE")]
            public static extern void GlMapVertexAttrib1d(uint index, uint size, double u1, double u2, int stride, int order, double* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapVertexAttrib1fAPPLE")]
            public static extern void GlMapVertexAttrib1f(uint index, uint size, float u1, float u2, int stride, int order, float* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapVertexAttrib2dAPPLE")]
            public static extern void GlMapVertexAttrib2d(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapVertexAttrib2fAPPLE")]
            public static extern void GlMapVertexAttrib2f(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
            
        }
        public unsafe static partial class Ycbcr422
        {
        }
    }
}
