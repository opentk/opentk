using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES1.Extensions
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
        public unsafe static partial class BlendEquationSeparate
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparateOES")]
            public static extern void GlBlendEquationSeparate(uint modeRGB, uint modeAlpha);
            
        }
        public unsafe static partial class BlendFuncSeparate
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparateOES")]
            public static extern void GlBlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
            
        }
        public unsafe static partial class BlendSubtract
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationOES")]
            public static extern void GlBlendEquation(uint mode);
            
        }
        public unsafe static partial class ByteCoordinates
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
        public unsafe static partial class Depth24
        {
        }
        public unsafe static partial class Depth32
        {
        }
        public unsafe static partial class DrawTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexsOES")]
            public static extern void GlDrawTexs(short x, short y, short z, short width, short height);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexiOES")]
            public static extern void GlDrawTexi(int x, int y, int z, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexxOES")]
            public static extern void GlDrawTexx(int x, int y, int z, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexsvOES")]
            public static extern void GlDrawTexsv(short* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexivOES")]
            public static extern void GlDrawTexiv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexxvOES")]
            public static extern void GlDrawTexxv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexfOES")]
            public static extern void GlDrawTexf(float x, float y, float z, float width, float height);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTexfvOES")]
            public static extern void GlDrawTexfv(float* coords);
            
        }
        public unsafe static partial class ElementIndexUint
        {
        }
        public unsafe static partial class ExtendedMatrixPalette
        {
        }
        public unsafe static partial class FboRenderMipmap
        {
        }
        public unsafe static partial class FixedPoint
        {
            [DllImport("opengl32.dll", EntryPoint = "glAlphaFuncxOES")]
            public static extern void GlAlphaFuncx(uint func, int reference);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearColorxOES")]
            public static extern void GlClearColorx(int red, int green, int blue, int alpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearDepthxOES")]
            public static extern void GlClearDepthx(int depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glClipPlanexOES")]
            public static extern void GlClipPlanex(uint plane, int* equation);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4xOES")]
            public static extern void GlColor4x(int red, int green, int blue, int alpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangexOES")]
            public static extern void GlDepthRangex(int n, int f);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogxOES")]
            public static extern void GlFogx(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogxvOES")]
            public static extern void GlFogxv(uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFrustumxOES")]
            public static extern void GlFrustumx(int l, int r, int b, int t, int n, int f);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetClipPlanexOES")]
            public static extern void GlGetClipPlanex(uint plane, int* equation);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFixedvOES")]
            public static extern void GlGetFixedv(uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexEnvxvOES")]
            public static extern void GlGetTexEnvxv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterxvOES")]
            public static extern void GlGetTexParameterxv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glLightModelxOES")]
            public static extern void GlLightModelx(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glLightModelxvOES")]
            public static extern void GlLightModelxv(uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glLightxOES")]
            public static extern void GlLightx(uint light, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glLightxvOES")]
            public static extern void GlLightxv(uint light, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glLineWidthxOES")]
            public static extern void GlLineWidthx(int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixxOES")]
            public static extern void GlLoadMatrixx(int* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMaterialxOES")]
            public static extern void GlMaterialx(uint face, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMaterialxvOES")]
            public static extern void GlMaterialxv(uint face, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultMatrixxOES")]
            public static extern void GlMultMatrixx(int* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4xOES")]
            public static extern void GlMultiTexCoord4x(uint texture, int s, int t, int r, int q);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormal3xOES")]
            public static extern void GlNormal3x(int nx, int ny, int nz);
            
            [DllImport("opengl32.dll", EntryPoint = "glOrthoxOES")]
            public static extern void GlOrthox(int l, int r, int b, int t, int n, int f);
            
            [DllImport("opengl32.dll", EntryPoint = "glPointParameterxvOES")]
            public static extern void GlPointParameterxv(uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glPointSizexOES")]
            public static extern void GlPointSizex(int size);
            
            [DllImport("opengl32.dll", EntryPoint = "glPolygonOffsetxOES")]
            public static extern void GlPolygonOffsetx(int factor, int units);
            
            [DllImport("opengl32.dll", EntryPoint = "glRotatexOES")]
            public static extern void GlRotatex(int angle, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glScalexOES")]
            public static extern void GlScalex(int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexEnvxOES")]
            public static extern void GlTexEnvx(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexEnvxvOES")]
            public static extern void GlTexEnvxv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterxOES")]
            public static extern void GlTexParameterx(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterxvOES")]
            public static extern void GlTexParameterxv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTranslatexOES")]
            public static extern void GlTranslatex(int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetLightxvOES")]
            public static extern void GlGetLightxv(uint light, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMaterialxvOES")]
            public static extern void GlGetMaterialxv(uint face, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glPointParameterxOES")]
            public static extern void GlPointParameterx(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSampleCoveragexOES")]
            public static extern void GlSampleCoveragex(int value, byte invert);
            
        }
        public unsafe static partial class FramebufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glIsRenderbufferOES")]
            public static extern byte GlIsRenderbuffer(uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindRenderbufferOES")]
            public static extern void GlBindRenderbuffer(uint target, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteRenderbuffersOES")]
            public static extern void GlDeleteRenderbuffers(int n, uint* renderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenRenderbuffersOES")]
            public static extern void GlGenRenderbuffers(int n, uint* renderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageOES")]
            public static extern void GlRenderbufferStorage(uint target, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetRenderbufferParameterivOES")]
            public static extern void GlGetRenderbufferParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsFramebufferOES")]
            public static extern byte GlIsFramebuffer(uint framebuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindFramebufferOES")]
            public static extern void GlBindFramebuffer(uint target, uint framebuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteFramebuffersOES")]
            public static extern void GlDeleteFramebuffers(int n, uint* framebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenFramebuffersOES")]
            public static extern void GlGenFramebuffers(int n, uint* framebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glCheckFramebufferStatusOES")]
            public static extern uint GlCheckFramebufferStatus(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferRenderbufferOES")]
            public static extern void GlFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2DOES")]
            public static extern void GlFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferAttachmentParameterivOES")]
            public static extern void GlGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenerateMipmapOES")]
            public static extern void GlGenerateMipmap(uint target);
            
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
        public unsafe static partial class MatrixGet
        {
        }
        public unsafe static partial class MatrixPalette
        {
            [DllImport("opengl32.dll", EntryPoint = "glCurrentPaletteMatrixOES")]
            public static extern void GlCurrentPaletteMatrix(uint matrixpaletteindex);
            
            [DllImport("opengl32.dll", EntryPoint = "glLoadPaletteFromModelViewMatrixOES")]
            public static extern void GlLoadPaletteFromModelViewMatrix();
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixIndexPointerOES")]
            public static extern void GlMatrixIndexPointer(int size, uint type, int stride, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glWeightPointerOES")]
            public static extern void GlWeightPointer(int size, uint type, int stride, void* pointer);
            
        }
        public unsafe static partial class PackedDepthStencil
        {
        }
        public unsafe static partial class PointSizeArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glPointSizePointerOES")]
            public static extern void GlPointSizePointer(uint type, int stride, void* pointer);
            
        }
        public unsafe static partial class PointSprite
        {
        }
        public unsafe static partial class QueryMatrix
        {
            [DllImport("opengl32.dll", EntryPoint = "glQueryMatrixxOES")]
            public static extern uint GlQueryMatrixx(int* mantissa, int* exponent);
            
        }
        public unsafe static partial class ReadFormat
        {
        }
        public unsafe static partial class RequiredInternalformat
        {
        }
        public unsafe static partial class Rgb8Rgba8
        {
        }
        public unsafe static partial class SinglePrecision
        {
            [DllImport("opengl32.dll", EntryPoint = "glClearDepthfOES")]
            public static extern void GlClearDepthf(float depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glClipPlanefOES")]
            public static extern void GlClipPlanef(uint plane, float* equation);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangefOES")]
            public static extern void GlDepthRangef(float n, float f);
            
            [DllImport("opengl32.dll", EntryPoint = "glFrustumfOES")]
            public static extern void GlFrustumf(float l, float r, float b, float t, float n, float f);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetClipPlanefOES")]
            public static extern void GlGetClipPlanef(uint plane, float* equation);
            
            [DllImport("opengl32.dll", EntryPoint = "glOrthofOES")]
            public static extern void GlOrthof(float l, float r, float b, float t, float n, float f);
            
        }
        public unsafe static partial class Stencil1
        {
        }
        public unsafe static partial class Stencil4
        {
        }
        public unsafe static partial class Stencil8
        {
        }
        public unsafe static partial class StencilWrap
        {
        }
        public unsafe static partial class SurfacelessContext
        {
        }
        public unsafe static partial class TextureCubeMap
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexGenfOES")]
            public static extern void GlTexGenf(uint coord, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexGenfvOES")]
            public static extern void GlTexGenfv(uint coord, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexGeniOES")]
            public static extern void GlTexGeni(uint coord, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexGenivOES")]
            public static extern void GlTexGeniv(uint coord, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexGenxOES")]
            public static extern void GlTexGenx(uint coord, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexGenxvOES")]
            public static extern void GlTexGenxv(uint coord, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexGenfvOES")]
            public static extern void GlGetTexGenfv(uint coord, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexGenivOES")]
            public static extern void GlGetTexGeniv(uint coord, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexGenxvOES")]
            public static extern void GlGetTexGenxv(uint coord, uint pname, int* parameters);
            
        }
        public unsafe static partial class TextureEnvCrossbar
        {
        }
        public unsafe static partial class TextureMirroredRepeat
        {
        }
        public unsafe static partial class TextureNpot
        {
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
    }
}
