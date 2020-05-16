using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class ATI
    {
        public unsafe static partial class DrawBuffers
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawBuffersATI")]
            public static extern void GlDrawBuffers(int n, uint* bufs);
            
        }
        public unsafe static partial class ElementArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glElementPointerATI")]
            public static extern void GlElementPointer(uint type, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementArrayATI")]
            public static extern void GlDrawElementArray(uint mode, int count);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementArrayATI")]
            public static extern void GlDrawRangeElementArray(uint mode, uint start, uint end, int count);
            
        }
        public unsafe static partial class EnvmapBumpmap
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexBumpParameterivATI")]
            public static extern void GlTexBumpParameteriv(uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexBumpParameterfvATI")]
            public static extern void GlTexBumpParameterfv(uint pname, float* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexBumpParameterivATI")]
            public static extern void GlGetTexBumpParameteriv(uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexBumpParameterfvATI")]
            public static extern void GlGetTexBumpParameterfv(uint pname, float* param);
            
        }
        public unsafe static partial class FragmentShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenFragmentShadersATI")]
            public static extern uint GlGenFragmentShaders(uint range);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindFragmentShaderATI")]
            public static extern void GlBindFragmentShader(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteFragmentShaderATI")]
            public static extern void GlDeleteFragmentShader(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glBeginFragmentShaderATI")]
            public static extern void GlBeginFragmentShader();
            
            [DllImport("opengl32.dll", EntryPoint = "glEndFragmentShaderATI")]
            public static extern void GlEndFragmentShader();
            
            [DllImport("opengl32.dll", EntryPoint = "glPassTexCoordATI")]
            public static extern void GlPassTexCoord(uint dst, uint coord, uint swizzle);
            
            [DllImport("opengl32.dll", EntryPoint = "glSampleMapATI")]
            public static extern void GlSampleMap(uint dst, uint interp, uint swizzle);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorFragmentOp1ATI")]
            public static extern void GlColorFragmentOp1(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorFragmentOp2ATI")]
            public static extern void GlColorFragmentOp2(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorFragmentOp3ATI")]
            public static extern void GlColorFragmentOp3(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
            
            [DllImport("opengl32.dll", EntryPoint = "glAlphaFragmentOp1ATI")]
            public static extern void GlAlphaFragmentOp1(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
            
            [DllImport("opengl32.dll", EntryPoint = "glAlphaFragmentOp2ATI")]
            public static extern void GlAlphaFragmentOp2(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
            
            [DllImport("opengl32.dll", EntryPoint = "glAlphaFragmentOp3ATI")]
            public static extern void GlAlphaFragmentOp3(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
            
            [DllImport("opengl32.dll", EntryPoint = "glSetFragmentShaderConstantATI")]
            public static extern void GlSetFragmentShaderConstant(uint dst, float* value);
            
        }
        public unsafe static partial class MapObjectBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glMapObjectBufferATI")]
            public static extern void* GlMapObjectBuffer(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glUnmapObjectBufferATI")]
            public static extern void GlUnmapObjectBuffer(uint buffer);
            
        }
        public unsafe static partial class Meminfo
        {
        }
        public unsafe static partial class PixelFormatFloat
        {
        }
        public unsafe static partial class PnTriangles
        {
            [DllImport("opengl32.dll", EntryPoint = "glPNTrianglesiATI")]
            public static extern void GlPNTrianglesi(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPNTrianglesfATI")]
            public static extern void GlPNTrianglesf(uint pname, float param);
            
        }
        public unsafe static partial class SeparateStencil
        {
            [DllImport("opengl32.dll", EntryPoint = "glStencilOpSeparateATI")]
            public static extern void GlStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilFuncSeparateATI")]
            public static extern void GlStencilFuncSeparate(uint frontfunc, uint backfunc, int reference, uint mask);
            
        }
        public unsafe static partial class TextFragmentShader
        {
        }
        public unsafe static partial class TextureEnvCombine3
        {
        }
        public unsafe static partial class TextureFloat
        {
        }
        public unsafe static partial class TextureMirrorOnce
        {
        }
        public unsafe static partial class VertexArrayObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glNewObjectBufferATI")]
            public static extern uint GlNewObjectBuffer(int size, void* pointer, uint usage);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsObjectBufferATI")]
            public static extern byte GlIsObjectBuffer(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glUpdateObjectBufferATI")]
            public static extern void GlUpdateObjectBuffer(uint buffer, uint offset, int size, void* pointer, uint preserve);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetObjectBufferfvATI")]
            public static extern void GlGetObjectBufferfv(uint buffer, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetObjectBufferivATI")]
            public static extern void GlGetObjectBufferiv(uint buffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFreeObjectBufferATI")]
            public static extern void GlFreeObjectBuffer(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glArrayObjectATI")]
            public static extern void GlArrayObject(uint array, int size, uint type, int stride, uint buffer, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetArrayObjectfvATI")]
            public static extern void GlGetArrayObjectfv(uint array, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetArrayObjectivATI")]
            public static extern void GlGetArrayObjectiv(uint array, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glVariantArrayObjectATI")]
            public static extern void GlVariantArrayObject(uint id, uint type, int stride, uint buffer, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVariantArrayObjectfvATI")]
            public static extern void GlGetVariantArrayObjectfv(uint id, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVariantArrayObjectivATI")]
            public static extern void GlGetVariantArrayObjectiv(uint id, uint pname, int* parameters);
            
        }
        public unsafe static partial class VertexAttribArrayObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribArrayObjectATI")]
            public static extern void GlVertexAttribArrayObject(uint index, int size, uint type, byte normalized, int stride, uint buffer, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribArrayObjectfvATI")]
            public static extern void GlGetVertexAttribArrayObjectfv(uint index, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribArrayObjectivATI")]
            public static extern void GlGetVertexAttribArrayObjectiv(uint index, uint pname, int* parameters);
            
        }
        public unsafe static partial class VertexStreams
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1sATI")]
            public static extern void GlVertexStream1s(uint stream, short x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1svATI")]
            public static extern void GlVertexStream1sv(uint stream, short* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1iATI")]
            public static extern void GlVertexStream1i(uint stream, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1ivATI")]
            public static extern void GlVertexStream1iv(uint stream, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1fATI")]
            public static extern void GlVertexStream1f(uint stream, float x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1fvATI")]
            public static extern void GlVertexStream1fv(uint stream, float* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1dATI")]
            public static extern void GlVertexStream1d(uint stream, double x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream1dvATI")]
            public static extern void GlVertexStream1dv(uint stream, double* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2sATI")]
            public static extern void GlVertexStream2s(uint stream, short x, short y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2svATI")]
            public static extern void GlVertexStream2sv(uint stream, short* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2iATI")]
            public static extern void GlVertexStream2i(uint stream, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2ivATI")]
            public static extern void GlVertexStream2iv(uint stream, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2fATI")]
            public static extern void GlVertexStream2f(uint stream, float x, float y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2fvATI")]
            public static extern void GlVertexStream2fv(uint stream, float* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2dATI")]
            public static extern void GlVertexStream2d(uint stream, double x, double y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream2dvATI")]
            public static extern void GlVertexStream2dv(uint stream, double* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3sATI")]
            public static extern void GlVertexStream3s(uint stream, short x, short y, short z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3svATI")]
            public static extern void GlVertexStream3sv(uint stream, short* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3iATI")]
            public static extern void GlVertexStream3i(uint stream, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3ivATI")]
            public static extern void GlVertexStream3iv(uint stream, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3fATI")]
            public static extern void GlVertexStream3f(uint stream, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3fvATI")]
            public static extern void GlVertexStream3fv(uint stream, float* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3dATI")]
            public static extern void GlVertexStream3d(uint stream, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream3dvATI")]
            public static extern void GlVertexStream3dv(uint stream, double* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4sATI")]
            public static extern void GlVertexStream4s(uint stream, short x, short y, short z, short w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4svATI")]
            public static extern void GlVertexStream4sv(uint stream, short* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4iATI")]
            public static extern void GlVertexStream4i(uint stream, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4ivATI")]
            public static extern void GlVertexStream4iv(uint stream, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4fATI")]
            public static extern void GlVertexStream4f(uint stream, float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4fvATI")]
            public static extern void GlVertexStream4fv(uint stream, float* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4dATI")]
            public static extern void GlVertexStream4d(uint stream, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexStream4dvATI")]
            public static extern void GlVertexStream4dv(uint stream, double* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3bATI")]
            public static extern void GlNormalStream3b(uint stream, sbyte nx, sbyte ny, sbyte nz);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3bvATI")]
            public static extern void GlNormalStream3bv(uint stream, sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3sATI")]
            public static extern void GlNormalStream3s(uint stream, short nx, short ny, short nz);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3svATI")]
            public static extern void GlNormalStream3sv(uint stream, short* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3iATI")]
            public static extern void GlNormalStream3i(uint stream, int nx, int ny, int nz);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3ivATI")]
            public static extern void GlNormalStream3iv(uint stream, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3fATI")]
            public static extern void GlNormalStream3f(uint stream, float nx, float ny, float nz);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3fvATI")]
            public static extern void GlNormalStream3fv(uint stream, float* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3dATI")]
            public static extern void GlNormalStream3d(uint stream, double nx, double ny, double nz);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalStream3dvATI")]
            public static extern void GlNormalStream3dv(uint stream, double* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glClientActiveVertexStreamATI")]
            public static extern void GlClientActiveVertexStream(uint stream);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexBlendEnviATI")]
            public static extern void GlVertexBlendEnvi(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexBlendEnvfATI")]
            public static extern void GlVertexBlendEnvf(uint pname, float param);
            
        }
    }
}
