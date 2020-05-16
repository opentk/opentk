using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class OES
    {
        public unsafe static partial class ByteCoordinates
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1bOES")]
            public static extern void GlMultiTexCoord1b(uint texture, sbyte s);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1bvOES")]
            public static extern void GlMultiTexCoord1bv(uint texture, sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2bOES")]
            public static extern void GlMultiTexCoord2b(uint texture, sbyte s, sbyte t);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2bvOES")]
            public static extern void GlMultiTexCoord2bv(uint texture, sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3bOES")]
            public static extern void GlMultiTexCoord3b(uint texture, sbyte s, sbyte t, sbyte r);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3bvOES")]
            public static extern void GlMultiTexCoord3bv(uint texture, sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4bOES")]
            public static extern void GlMultiTexCoord4b(uint texture, sbyte s, sbyte t, sbyte r, sbyte q);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4bvOES")]
            public static extern void GlMultiTexCoord4bv(uint texture, sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord1bOES")]
            public static extern void GlTexCoord1b(sbyte s);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord1bvOES")]
            public static extern void GlTexCoord1bv(sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2bOES")]
            public static extern void GlTexCoord2b(sbyte s, sbyte t);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2bvOES")]
            public static extern void GlTexCoord2bv(sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord3bOES")]
            public static extern void GlTexCoord3b(sbyte s, sbyte t, sbyte r);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord3bvOES")]
            public static extern void GlTexCoord3bv(sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4bOES")]
            public static extern void GlTexCoord4b(sbyte s, sbyte t, sbyte r, sbyte q);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4bvOES")]
            public static extern void GlTexCoord4bv(sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex2bOES")]
            public static extern void GlVertex2b(sbyte x, sbyte y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex2bvOES")]
            public static extern void GlVertex2bv(sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex3bOES")]
            public static extern void GlVertex3b(sbyte x, sbyte y, sbyte z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex3bvOES")]
            public static extern void GlVertex3bv(sbyte* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex4bOES")]
            public static extern void GlVertex4b(sbyte x, sbyte y, sbyte z, sbyte w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex4bvOES")]
            public static extern void GlVertex4bv(sbyte* coords);
            
        }
        public unsafe static partial class CompressedPalettedTexture
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
            
            [DllImport("opengl32.dll", EntryPoint = "glAccumxOES")]
            public static extern void GlAccumx(uint op, int value);
            
            [DllImport("opengl32.dll", EntryPoint = "glBitmapxOES")]
            public static extern void GlBitmapx(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendColorxOES")]
            public static extern void GlBlendColorx(int red, int green, int blue, int alpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearAccumxOES")]
            public static extern void GlClearAccumx(int red, int green, int blue, int alpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor3xOES")]
            public static extern void GlColor3x(int red, int green, int blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor3xvOES")]
            public static extern void GlColor3xv(int* components);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4xvOES")]
            public static extern void GlColor4xv(int* components);
            
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionParameterxOES")]
            public static extern void GlConvolutionParameterx(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glConvolutionParameterxvOES")]
            public static extern void GlConvolutionParameterxv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1xOES")]
            public static extern void GlEvalCoord1x(int u);
            
            [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1xvOES")]
            public static extern void GlEvalCoord1xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2xOES")]
            public static extern void GlEvalCoord2x(int u, int v);
            
            [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2xvOES")]
            public static extern void GlEvalCoord2xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glFeedbackBufferxOES")]
            public static extern void GlFeedbackBufferx(int n, uint type, int* buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetConvolutionParameterxvOES")]
            public static extern void GlGetConvolutionParameterxv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetHistogramParameterxvOES")]
            public static extern void GlGetHistogramParameterxv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetLightxOES")]
            public static extern void GlGetLightx(uint light, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMapxvOES")]
            public static extern void GlGetMapxv(uint target, uint query, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMaterialxOES")]
            public static extern void GlGetMaterialx(uint face, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPixelMapxv")]
            public static extern void GlGetPixelMapxv(uint map, int size, int* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexGenxvOES")]
            public static extern void GlGetTexGenxv(uint coord, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexLevelParameterxvOES")]
            public static extern void GlGetTexLevelParameterxv(uint target, int level, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glIndexxOES")]
            public static extern void GlIndexx(int component);
            
            [DllImport("opengl32.dll", EntryPoint = "glIndexxvOES")]
            public static extern void GlIndexxv(int* component);
            
            [DllImport("opengl32.dll", EntryPoint = "glLoadTransposeMatrixxOES")]
            public static extern void GlLoadTransposeMatrixx(int* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMap1xOES")]
            public static extern void GlMap1x(uint target, int u1, int u2, int stride, int order, int points);
            
            [DllImport("opengl32.dll", EntryPoint = "glMap2xOES")]
            public static extern void GlMap2x(uint target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapGrid1xOES")]
            public static extern void GlMapGrid1x(int n, int u1, int u2);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapGrid2xOES")]
            public static extern void GlMapGrid2x(int n, int u1, int u2, int v1, int v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultTransposeMatrixxOES")]
            public static extern void GlMultTransposeMatrixx(int* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1xOES")]
            public static extern void GlMultiTexCoord1x(uint texture, int s);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1xvOES")]
            public static extern void GlMultiTexCoord1xv(uint texture, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2xOES")]
            public static extern void GlMultiTexCoord2x(uint texture, int s, int t);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2xvOES")]
            public static extern void GlMultiTexCoord2xv(uint texture, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3xOES")]
            public static extern void GlMultiTexCoord3x(uint texture, int s, int t, int r);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3xvOES")]
            public static extern void GlMultiTexCoord3xv(uint texture, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4xvOES")]
            public static extern void GlMultiTexCoord4xv(uint texture, int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormal3xvOES")]
            public static extern void GlNormal3xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glPassThroughxOES")]
            public static extern void GlPassThroughx(int token);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelMapx")]
            public static extern void GlPixelMapx(uint map, int size, int* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelStorex")]
            public static extern void GlPixelStorex(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelTransferxOES")]
            public static extern void GlPixelTransferx(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPixelZoomxOES")]
            public static extern void GlPixelZoomx(int xfactor, int yfactor);
            
            [DllImport("opengl32.dll", EntryPoint = "glPrioritizeTexturesxOES")]
            public static extern void GlPrioritizeTexturesx(int n, uint* textures, int* priorities);
            
            [DllImport("opengl32.dll", EntryPoint = "glRasterPos2xOES")]
            public static extern void GlRasterPos2x(int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glRasterPos2xvOES")]
            public static extern void GlRasterPos2xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glRasterPos3xOES")]
            public static extern void GlRasterPos3x(int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glRasterPos3xvOES")]
            public static extern void GlRasterPos3xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glRasterPos4xOES")]
            public static extern void GlRasterPos4x(int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glRasterPos4xvOES")]
            public static extern void GlRasterPos4xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glRectxOES")]
            public static extern void GlRectx(int x1, int y1, int x2, int y2);
            
            [DllImport("opengl32.dll", EntryPoint = "glRectxvOES")]
            public static extern void GlRectxv(int* v1, int* v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord1xOES")]
            public static extern void GlTexCoord1x(int s);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord1xvOES")]
            public static extern void GlTexCoord1xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2xOES")]
            public static extern void GlTexCoord2x(int s, int t);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2xvOES")]
            public static extern void GlTexCoord2xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord3xOES")]
            public static extern void GlTexCoord3x(int s, int t, int r);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord3xvOES")]
            public static extern void GlTexCoord3xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4xOES")]
            public static extern void GlTexCoord4x(int s, int t, int r, int q);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4xvOES")]
            public static extern void GlTexCoord4xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexGenxOES")]
            public static extern void GlTexGenx(uint coord, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexGenxvOES")]
            public static extern void GlTexGenxv(uint coord, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex2xOES")]
            public static extern void GlVertex2x(int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex2xvOES")]
            public static extern void GlVertex2xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex3xOES")]
            public static extern void GlVertex3x(int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex3xvOES")]
            public static extern void GlVertex3xv(int* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex4xOES")]
            public static extern void GlVertex4x(int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex4xvOES")]
            public static extern void GlVertex4xv(int* coords);
            
        }
        public unsafe static partial class QueryMatrix
        {
            [DllImport("opengl32.dll", EntryPoint = "glQueryMatrixxOES")]
            public static extern uint GlQueryMatrixx(int* mantissa, int* exponent);
            
        }
        public unsafe static partial class ReadFormat
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
    }
}
