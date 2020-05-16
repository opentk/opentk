using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class OES
    {
        public unsafe static partial class EglImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glEGLImageTargetTexture2DOES")]
            public static extern void GlEGLImageTargetTexture2D(uint target, void* image);
            
            [DllImport("opengl32.dll", EntryPoint = "glEGLImageTargetRenderbufferStorageOES")]
            public static extern void GlEGLImageTargetRenderbufferStorage(uint target, void* image);
            
        }
        public unsafe static partial class EglImageExternal
        {
        }
        public unsafe static partial class EglImageExternalEssl3
        {
        }
        public unsafe static partial class CompressedEtc1Rgb8SubTexture
        {
        }
        public unsafe static partial class CompressedEtc1Rgb8Texture
        {
        }
        public unsafe static partial class CompressedPalettedTexture
        {
        }
        public unsafe static partial class CopyImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyImageSubDataOES")]
            public static extern void GlCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
            
        }
        public unsafe static partial class Depth24
        {
        }
        public unsafe static partial class Depth32
        {
        }
        public unsafe static partial class DepthTexture
        {
        }
        public unsafe static partial class DrawBuffersIndexed
        {
            [DllImport("opengl32.dll", EntryPoint = "glEnableiOES")]
            public static extern void GlEnablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableiOES")]
            public static extern void GlDisablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationiOES")]
            public static extern void GlBlendEquationi(uint buf, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparateiOES")]
            public static extern void GlBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendFunciOES")]
            public static extern void GlBlendFunci(uint buf, uint src, uint dst);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparateiOES")]
            public static extern void GlBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorMaskiOES")]
            public static extern void GlColorMaski(uint index, byte r, byte g, byte b, byte a);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsEnablediOES")]
            public static extern byte GlIsEnabledi(uint target, uint index);
            
        }
        public unsafe static partial class DrawElementsBaseVertex
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsBaseVertexOES")]
            public static extern void GlDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementsBaseVertexOES")]
            public static extern void GlDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertexOES")]
            public static extern void GlDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
            public static extern void GlMultiDrawElementsBaseVertexEXT(uint mode, int* count, uint type, void** indices, int primcount, int* basevertex);
            
        }
        public unsafe static partial class ElementIndexUint
        {
        }
        public unsafe static partial class FboRenderMipmap
        {
        }
        public unsafe static partial class FragmentPrecisionHigh
        {
        }
        public unsafe static partial class GeometryPointSize
        {
        }
        public unsafe static partial class GeometryShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureOES")]
            public static extern void GlFramebufferTexture(uint target, uint attachment, uint texture, int level);
            
        }
        public unsafe static partial class GetProgramBinary
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramBinaryOES")]
            public static extern void GlGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramBinaryOES")]
            public static extern void GlProgramBinary(uint program, uint binaryFormat, void* binary, int length);
            
        }
        public unsafe static partial class GpuShader5
        {
        }
        public unsafe static partial class Mapbuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glMapBufferOES")]
            public static extern void* GlMapBuffer(uint target, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glUnmapBufferOES")]
            public static extern byte GlUnmapBuffer(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetBufferPointervOES")]
            public static extern void GlGetBufferPointerv(uint target, uint pname, void** parameters);
            
        }
        public unsafe static partial class PackedDepthStencil
        {
        }
        public unsafe static partial class PrimitiveBoundingBox
        {
            [DllImport("opengl32.dll", EntryPoint = "glPrimitiveBoundingBoxOES")]
            public static extern void GlPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
            
        }
        public unsafe static partial class RequiredInternalformat
        {
        }
        public unsafe static partial class Rgb8Rgba8
        {
        }
        public unsafe static partial class SampleShading
        {
            [DllImport("opengl32.dll", EntryPoint = "glMinSampleShadingOES")]
            public static extern void GlMinSampleShading(float value);
            
        }
        public unsafe static partial class SampleVariables
        {
        }
        public unsafe static partial class ShaderImageAtomic
        {
        }
        public unsafe static partial class ShaderIoBlocks
        {
        }
        public unsafe static partial class ShaderMultisampleInterpolation
        {
        }
        public unsafe static partial class StandardDerivatives
        {
        }
        public unsafe static partial class Stencil1
        {
        }
        public unsafe static partial class Stencil4
        {
        }
        public unsafe static partial class SurfacelessContext
        {
        }
        public unsafe static partial class TessellationPointSize
        {
        }
        public unsafe static partial class TessellationShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glPatchParameteriOES")]
            public static extern void GlPatchParameteri(uint pname, int value);
            
        }
        public unsafe static partial class Texture3d
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexImage3DOES")]
            public static extern void GlTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexSubImage3DOES")]
            public static extern void GlTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage3DOES")]
            public static extern void GlCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTexImage3DOES")]
            public static extern void GlCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage3DOES")]
            public static extern void GlCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture3DOES")]
            public static extern void GlFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
            
        }
        public unsafe static partial class TextureBorderClamp
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterIivOES")]
            public static extern void GlTexParameterIiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterIuivOES")]
            public static extern void GlTexParameterIuiv(uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIivOES")]
            public static extern void GlGetTexParameterIiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIuivOES")]
            public static extern void GlGetTexParameterIuiv(uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIivOES")]
            public static extern void GlSamplerParameterIiv(uint sampler, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIuivOES")]
            public static extern void GlSamplerParameterIuiv(uint sampler, uint pname, uint* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIivOES")]
            public static extern void GlGetSamplerParameterIiv(uint sampler, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIuivOES")]
            public static extern void GlGetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters);
            
        }
        public unsafe static partial class TextureBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexBufferOES")]
            public static extern void GlTexBuffer(uint target, uint internalformat, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexBufferRangeOES")]
            public static extern void GlTexBufferRange(uint target, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
            
        }
        public unsafe static partial class TextureCompressionAstc
        {
        }
        public unsafe static partial class TextureCubeMapArray
        {
        }
        public unsafe static partial class TextureFloat
        {
        }
        public unsafe static partial class TextureFloatLinear
        {
        }
        public unsafe static partial class TextureHalfFloat
        {
        }
        public unsafe static partial class TextureHalfFloatLinear
        {
        }
        public unsafe static partial class TextureNpot
        {
        }
        public unsafe static partial class TextureStencil8
        {
        }
        public unsafe static partial class TextureStorageMultisample2dArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage3DMultisampleOES")]
            public static extern void GlTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
            
        }
        public unsafe static partial class TextureView
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureViewOES")]
            public static extern void GlTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
            
        }
        public unsafe static partial class VertexArrayObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindVertexArrayOES")]
            public static extern void GlBindVertexArray(uint array);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteVertexArraysOES")]
            public static extern void GlDeleteVertexArrays(int n, uint* arrays);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenVertexArraysOES")]
            public static extern void GlGenVertexArrays(int n, uint* arrays);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsVertexArrayOES")]
            public static extern byte GlIsVertexArray(uint array);
            
        }
        public unsafe static partial class VertexHalfFloat
        {
        }
        public unsafe static partial class VertexType1010102
        {
        }
        public unsafe static partial class ViewportArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glViewportArrayvOES")]
            public static extern void GlViewportArrayv(uint first, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedfOES")]
            public static extern void GlViewportIndexedf(uint index, float x, float y, float w, float h);
            
            [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedfvOES")]
            public static extern void GlViewportIndexedfv(uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorArrayvOES")]
            public static extern void GlScissorArrayv(uint first, int count, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorIndexedOES")]
            public static extern void GlScissorIndexed(uint index, int left, int bottom, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorIndexedvOES")]
            public static extern void GlScissorIndexedv(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeArrayfvOES")]
            public static extern void GlDepthRangeArrayfv(uint first, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeIndexedfOES")]
            public static extern void GlDepthRangeIndexedf(uint index, float n, float f);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFloati_vOES")]
            public static extern void GlGetFloati_v(uint target, uint index, float* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableiOES")]
            public static extern void GlEnablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableiOES")]
            public static extern void GlDisablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsEnablediOES")]
            public static extern byte GlIsEnabledi(uint target, uint index);
            
        }
    }
}
