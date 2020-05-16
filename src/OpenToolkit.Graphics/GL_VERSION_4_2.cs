using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.GL42
{
    public unsafe static partial class GL
    {
        [DllImport("opengl32.dll", EntryPoint = "glCullFace")]
        public static extern void CullFace(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glFrontFace")]
        public static extern void FrontFace(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glHint")]
        public static extern void Hint(uint target, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glLineWidth")]
        public static extern void LineWidth(float width);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointSize")]
        public static extern void PointSize(float size);
        
        [DllImport("opengl32.dll", EntryPoint = "glPolygonMode")]
        public static extern void PolygonMode(uint face, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glScissor")]
        public static extern void Scissor(int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterf")]
        public static extern void TexParameterf(uint target, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterfv")]
        public static extern void TexParameterfv(uint target, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteri")]
        public static extern void TexParameteri(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameteriv")]
        public static extern void TexParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage1D")]
        public static extern void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage2D")]
        public static extern void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawBuffer")]
        public static extern void DrawBuffer(uint buf);
        
        [DllImport("opengl32.dll", EntryPoint = "glClear")]
        public static extern void Clear(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearColor")]
        public static extern void ClearColor(float red, float green, float blue, float alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearStencil")]
        public static extern void ClearStencil(int s);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearDepth")]
        public static extern void ClearDepth(double depth);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorMask")]
        public static extern void ColorMask(byte red, byte green, byte blue, byte alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(byte flag);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisable")]
        public static extern void Disable(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnable")]
        public static extern void Enable(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glFinish")]
        public static extern void Finish();
        
        [DllImport("opengl32.dll", EntryPoint = "glFlush")]
        public static extern void Flush();
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(uint sfactor, uint dfactor);
        
        [DllImport("opengl32.dll", EntryPoint = "glLogicOp")]
        public static extern void LogicOp(uint opcode);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(uint func, int reference, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilOp")]
        public static extern void StencilOp(uint fail, uint zfail, uint zpass);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(uint func);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelStoref")]
        public static extern void PixelStoref(uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStorei(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glReadBuffer")]
        public static extern void ReadBuffer(uint src);
        
        [DllImport("opengl32.dll", EntryPoint = "glReadPixels")]
        public static extern void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBooleanv(uint pname, byte* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetDoublev")]
        public static extern void GetDoublev(uint pname, double* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetError")]
        public static extern uint GetError();
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFloatv")]
        public static extern void GetFloatv(uint pname, float* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetIntegerv")]
        public static extern void GetIntegerv(uint pname, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetString")]
        public static extern byte* GetString(uint name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexImage")]
        public static extern void GetTexImage(uint target, int level, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameterfv(uint target, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexLevelParameterfv")]
        public static extern void GetTexLevelParameterfv(uint target, int level, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexLevelParameteriv")]
        public static extern void GetTexLevelParameteriv(uint target, int level, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsEnabled")]
        public static extern byte IsEnabled(uint cap);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthRange")]
        public static extern void DepthRange(double n, double f);
        
        [DllImport("opengl32.dll", EntryPoint = "glViewport")]
        public static extern void Viewport(int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glNewList")]
        public static extern void NewList(uint list, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glEndList")]
        public static extern void EndList();
        
        [DllImport("opengl32.dll", EntryPoint = "glCallList")]
        public static extern void CallList(uint list);
        
        [DllImport("opengl32.dll", EntryPoint = "glCallLists")]
        public static extern void CallLists(int n, uint type, void* lists);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteLists")]
        public static extern void DeleteLists(uint list, int range);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenLists")]
        public static extern uint GenLists(int range);
        
        [DllImport("opengl32.dll", EntryPoint = "glListBase")]
        public static extern void ListBase(uint @base);
        
        [DllImport("opengl32.dll", EntryPoint = "glBegin")]
        public static extern void Begin(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glBitmap")]
        public static extern void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3b")]
        public static extern void Color3b(sbyte red, sbyte green, sbyte blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3bv")]
        public static extern void Color3bv(sbyte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3d")]
        public static extern void Color3d(double red, double green, double blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3dv")]
        public static extern void Color3dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3f")]
        public static extern void Color3f(float red, float green, float blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3fv")]
        public static extern void Color3fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3i")]
        public static extern void Color3i(int red, int green, int blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3iv")]
        public static extern void Color3iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3s")]
        public static extern void Color3s(short red, short green, short blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3sv")]
        public static extern void Color3sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3ub")]
        public static extern void Color3ub(byte red, byte green, byte blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3ubv")]
        public static extern void Color3ubv(byte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3ui")]
        public static extern void Color3ui(uint red, uint green, uint blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3uiv")]
        public static extern void Color3uiv(uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3us")]
        public static extern void Color3us(ushort red, ushort green, ushort blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor3usv")]
        public static extern void Color3usv(ushort* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4b")]
        public static extern void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4bv")]
        public static extern void Color4bv(sbyte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4d")]
        public static extern void Color4d(double red, double green, double blue, double alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4dv")]
        public static extern void Color4dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4f")]
        public static extern void Color4f(float red, float green, float blue, float alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4fv")]
        public static extern void Color4fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4i")]
        public static extern void Color4i(int red, int green, int blue, int alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4iv")]
        public static extern void Color4iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4s")]
        public static extern void Color4s(short red, short green, short blue, short alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4sv")]
        public static extern void Color4sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4ub")]
        public static extern void Color4ub(byte red, byte green, byte blue, byte alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4ubv")]
        public static extern void Color4ubv(byte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4ui")]
        public static extern void Color4ui(uint red, uint green, uint blue, uint alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4uiv")]
        public static extern void Color4uiv(uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4us")]
        public static extern void Color4us(ushort red, ushort green, ushort blue, ushort alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glColor4usv")]
        public static extern void Color4usv(ushort* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlag")]
        public static extern void EdgeFlag(byte flag);
        
        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlagv")]
        public static extern void EdgeFlagv(byte* flag);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnd")]
        public static extern void End();
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexd")]
        public static extern void Indexd(double c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexdv")]
        public static extern void Indexdv(double* c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexf")]
        public static extern void Indexf(float c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexfv")]
        public static extern void Indexfv(float* c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexi")]
        public static extern void Indexi(int c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexiv")]
        public static extern void Indexiv(int* c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexs")]
        public static extern void Indexs(short c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexsv")]
        public static extern void Indexsv(short* c);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3b")]
        public static extern void Normal3b(sbyte nx, sbyte ny, sbyte nz);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3bv")]
        public static extern void Normal3bv(sbyte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3d")]
        public static extern void Normal3d(double nx, double ny, double nz);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3dv")]
        public static extern void Normal3dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3f")]
        public static extern void Normal3f(float nx, float ny, float nz);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3fv")]
        public static extern void Normal3fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3i")]
        public static extern void Normal3i(int nx, int ny, int nz);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3iv")]
        public static extern void Normal3iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3s")]
        public static extern void Normal3s(short nx, short ny, short nz);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormal3sv")]
        public static extern void Normal3sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2d")]
        public static extern void RasterPos2d(double x, double y);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2dv")]
        public static extern void RasterPos2dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2f")]
        public static extern void RasterPos2f(float x, float y);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2fv")]
        public static extern void RasterPos2fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2i")]
        public static extern void RasterPos2i(int x, int y);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2iv")]
        public static extern void RasterPos2iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2s")]
        public static extern void RasterPos2s(short x, short y);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos2sv")]
        public static extern void RasterPos2sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3d")]
        public static extern void RasterPos3d(double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3dv")]
        public static extern void RasterPos3dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3f")]
        public static extern void RasterPos3f(float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3fv")]
        public static extern void RasterPos3fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3i")]
        public static extern void RasterPos3i(int x, int y, int z);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3iv")]
        public static extern void RasterPos3iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3s")]
        public static extern void RasterPos3s(short x, short y, short z);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos3sv")]
        public static extern void RasterPos3sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4d")]
        public static extern void RasterPos4d(double x, double y, double z, double w);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4dv")]
        public static extern void RasterPos4dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4f")]
        public static extern void RasterPos4f(float x, float y, float z, float w);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4fv")]
        public static extern void RasterPos4fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4i")]
        public static extern void RasterPos4i(int x, int y, int z, int w);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4iv")]
        public static extern void RasterPos4iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4s")]
        public static extern void RasterPos4s(short x, short y, short z, short w);
        
        [DllImport("opengl32.dll", EntryPoint = "glRasterPos4sv")]
        public static extern void RasterPos4sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glRectd")]
        public static extern void Rectd(double x1, double y1, double x2, double y2);
        
        [DllImport("opengl32.dll", EntryPoint = "glRectdv")]
        public static extern void Rectdv(double* v1, double* v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glRectf")]
        public static extern void Rectf(float x1, float y1, float x2, float y2);
        
        [DllImport("opengl32.dll", EntryPoint = "glRectfv")]
        public static extern void Rectfv(float* v1, float* v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glRecti")]
        public static extern void Recti(int x1, int y1, int x2, int y2);
        
        [DllImport("opengl32.dll", EntryPoint = "glRectiv")]
        public static extern void Rectiv(int* v1, int* v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glRects")]
        public static extern void Rects(short x1, short y1, short x2, short y2);
        
        [DllImport("opengl32.dll", EntryPoint = "glRectsv")]
        public static extern void Rectsv(short* v1, short* v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1d")]
        public static extern void TexCoord1d(double s);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1dv")]
        public static extern void TexCoord1dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1f")]
        public static extern void TexCoord1f(float s);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1fv")]
        public static extern void TexCoord1fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1i")]
        public static extern void TexCoord1i(int s);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1iv")]
        public static extern void TexCoord1iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1s")]
        public static extern void TexCoord1s(short s);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord1sv")]
        public static extern void TexCoord1sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2d")]
        public static extern void TexCoord2d(double s, double t);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2dv")]
        public static extern void TexCoord2dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2f")]
        public static extern void TexCoord2f(float s, float t);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2fv")]
        public static extern void TexCoord2fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2i")]
        public static extern void TexCoord2i(int s, int t);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2iv")]
        public static extern void TexCoord2iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2s")]
        public static extern void TexCoord2s(short s, short t);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord2sv")]
        public static extern void TexCoord2sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3d")]
        public static extern void TexCoord3d(double s, double t, double r);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3dv")]
        public static extern void TexCoord3dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3f")]
        public static extern void TexCoord3f(float s, float t, float r);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3fv")]
        public static extern void TexCoord3fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3i")]
        public static extern void TexCoord3i(int s, int t, int r);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3iv")]
        public static extern void TexCoord3iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3s")]
        public static extern void TexCoord3s(short s, short t, short r);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord3sv")]
        public static extern void TexCoord3sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4d")]
        public static extern void TexCoord4d(double s, double t, double r, double q);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4dv")]
        public static extern void TexCoord4dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4f")]
        public static extern void TexCoord4f(float s, float t, float r, float q);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4fv")]
        public static extern void TexCoord4fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4i")]
        public static extern void TexCoord4i(int s, int t, int r, int q);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4iv")]
        public static extern void TexCoord4iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4s")]
        public static extern void TexCoord4s(short s, short t, short r, short q);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoord4sv")]
        public static extern void TexCoord4sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2d")]
        public static extern void Vertex2d(double x, double y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2dv")]
        public static extern void Vertex2dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2f")]
        public static extern void Vertex2f(float x, float y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2fv")]
        public static extern void Vertex2fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2i")]
        public static extern void Vertex2i(int x, int y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2iv")]
        public static extern void Vertex2iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2s")]
        public static extern void Vertex2s(short x, short y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex2sv")]
        public static extern void Vertex2sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3d")]
        public static extern void Vertex3d(double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3dv")]
        public static extern void Vertex3dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3f")]
        public static extern void Vertex3f(float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3fv")]
        public static extern void Vertex3fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3i")]
        public static extern void Vertex3i(int x, int y, int z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3iv")]
        public static extern void Vertex3iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3s")]
        public static extern void Vertex3s(short x, short y, short z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex3sv")]
        public static extern void Vertex3sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4d")]
        public static extern void Vertex4d(double x, double y, double z, double w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4dv")]
        public static extern void Vertex4dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4f")]
        public static extern void Vertex4f(float x, float y, float z, float w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4fv")]
        public static extern void Vertex4fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4i")]
        public static extern void Vertex4i(int x, int y, int z, int w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4iv")]
        public static extern void Vertex4iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4s")]
        public static extern void Vertex4s(short x, short y, short z, short w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertex4sv")]
        public static extern void Vertex4sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glClipPlane")]
        public static extern void ClipPlane(uint plane, double* equation);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorMaterial")]
        public static extern void ColorMaterial(uint face, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogf")]
        public static extern void Fogf(uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogfv")]
        public static extern void Fogfv(uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogi")]
        public static extern void Fogi(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogiv")]
        public static extern void Fogiv(uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightf")]
        public static extern void Lightf(uint light, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightfv")]
        public static extern void Lightfv(uint light, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glLighti")]
        public static extern void Lighti(uint light, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightiv")]
        public static extern void Lightiv(uint light, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightModelf")]
        public static extern void LightModelf(uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightModelfv")]
        public static extern void LightModelfv(uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightModeli")]
        public static extern void LightModeli(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glLightModeliv")]
        public static extern void LightModeliv(uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glLineStipple")]
        public static extern void LineStipple(int factor, ushort pattern);
        
        [DllImport("opengl32.dll", EntryPoint = "glMaterialf")]
        public static extern void Materialf(uint face, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glMaterialfv")]
        public static extern void Materialfv(uint face, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glMateriali")]
        public static extern void Materiali(uint face, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glMaterialiv")]
        public static extern void Materialiv(uint face, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glPolygonStipple")]
        public static extern void PolygonStipple(byte* mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glShadeModel")]
        public static extern void ShadeModel(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvf")]
        public static extern void TexEnvf(uint target, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvfv")]
        public static extern void TexEnvfv(uint target, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnvi")]
        public static extern void TexEnvi(uint target, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexEnviv")]
        public static extern void TexEnviv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexGend")]
        public static extern void TexGend(uint coord, uint pname, double param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexGendv")]
        public static extern void TexGendv(uint coord, uint pname, double* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexGenf")]
        public static extern void TexGenf(uint coord, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexGenfv")]
        public static extern void TexGenfv(uint coord, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexGeni")]
        public static extern void TexGeni(uint coord, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexGeniv")]
        public static extern void TexGeniv(uint coord, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glFeedbackBuffer")]
        public static extern void FeedbackBuffer(int size, uint type, float* buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glSelectBuffer")]
        public static extern void SelectBuffer(int size, uint* buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glRenderMode")]
        public static extern int RenderMode(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glInitNames")]
        public static extern void InitNames();
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadName")]
        public static extern void LoadName(uint name);
        
        [DllImport("opengl32.dll", EntryPoint = "glPassThrough")]
        public static extern void PassThrough(float token);
        
        [DllImport("opengl32.dll", EntryPoint = "glPopName")]
        public static extern void PopName();
        
        [DllImport("opengl32.dll", EntryPoint = "glPushName")]
        public static extern void PushName(uint name);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearAccum")]
        public static extern void ClearAccum(float red, float green, float blue, float alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearIndex")]
        public static extern void ClearIndex(float c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexMask")]
        public static extern void IndexMask(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glAccum")]
        public static extern void Accum(uint op, float value);
        
        [DllImport("opengl32.dll", EntryPoint = "glPopAttrib")]
        public static extern void PopAttrib();
        
        [DllImport("opengl32.dll", EntryPoint = "glPushAttrib")]
        public static extern void PushAttrib(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glMap1d")]
        public static extern void Map1d(uint target, double u1, double u2, int stride, int order, double* points);
        
        [DllImport("opengl32.dll", EntryPoint = "glMap1f")]
        public static extern void Map1f(uint target, float u1, float u2, int stride, int order, float* points);
        
        [DllImport("opengl32.dll", EntryPoint = "glMap2d")]
        public static extern void Map2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
        
        [DllImport("opengl32.dll", EntryPoint = "glMap2f")]
        public static extern void Map2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
        
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1d")]
        public static extern void MapGrid1d(int un, double u1, double u2);
        
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid1f")]
        public static extern void MapGrid1f(int un, float u1, float u2);
        
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2d")]
        public static extern void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glMapGrid2f")]
        public static extern void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1d")]
        public static extern void EvalCoord1d(double u);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1dv")]
        public static extern void EvalCoord1dv(double* u);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1f")]
        public static extern void EvalCoord1f(float u);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord1fv")]
        public static extern void EvalCoord1fv(float* u);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2d")]
        public static extern void EvalCoord2d(double u, double v);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2dv")]
        public static extern void EvalCoord2dv(double* u);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2f")]
        public static extern void EvalCoord2f(float u, float v);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalCoord2fv")]
        public static extern void EvalCoord2fv(float* u);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalMesh1")]
        public static extern void EvalMesh1(uint mode, int i1, int i2);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint1")]
        public static extern void EvalPoint1(int i);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalMesh2")]
        public static extern void EvalMesh2(uint mode, int i1, int i2, int j1, int j2);
        
        [DllImport("opengl32.dll", EntryPoint = "glEvalPoint2")]
        public static extern void EvalPoint2(int i, int j);
        
        [DllImport("opengl32.dll", EntryPoint = "glAlphaFunc")]
        public static extern void AlphaFunc(uint func, float reference);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelZoom")]
        public static extern void PixelZoom(float xfactor, float yfactor);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferf")]
        public static extern void PixelTransferf(uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelTransferi")]
        public static extern void PixelTransferi(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelMapfv")]
        public static extern void PixelMapfv(uint map, int mapsize, float* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelMapuiv")]
        public static extern void PixelMapuiv(uint map, int mapsize, uint* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glPixelMapusv")]
        public static extern void PixelMapusv(uint map, int mapsize, ushort* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyPixels")]
        public static extern void CopyPixels(int x, int y, int width, int height, uint type);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawPixels")]
        public static extern void DrawPixels(int width, int height, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetClipPlane")]
        public static extern void GetClipPlane(uint plane, double* equation);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetLightfv")]
        public static extern void GetLightfv(uint light, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetLightiv")]
        public static extern void GetLightiv(uint light, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMapdv")]
        public static extern void GetMapdv(uint target, uint query, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMapfv")]
        public static extern void GetMapfv(uint target, uint query, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMapiv")]
        public static extern void GetMapiv(uint target, uint query, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMaterialfv")]
        public static extern void GetMaterialfv(uint face, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMaterialiv")]
        public static extern void GetMaterialiv(uint face, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetPixelMapfv")]
        public static extern void GetPixelMapfv(uint map, float* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetPixelMapuiv")]
        public static extern void GetPixelMapuiv(uint map, uint* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetPixelMapusv")]
        public static extern void GetPixelMapusv(uint map, ushort* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetPolygonStipple")]
        public static extern void GetPolygonStipple(byte* mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexEnvfv")]
        public static extern void GetTexEnvfv(uint target, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexEnviv")]
        public static extern void GetTexEnviv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexGendv")]
        public static extern void GetTexGendv(uint coord, uint pname, double* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexGenfv")]
        public static extern void GetTexGenfv(uint coord, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexGeniv")]
        public static extern void GetTexGeniv(uint coord, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsList")]
        public static extern byte IsList(uint list);
        
        [DllImport("opengl32.dll", EntryPoint = "glFrustum")]
        public static extern void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadIdentity")]
        public static extern void LoadIdentity();
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixf")]
        public static extern void LoadMatrixf(float* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadMatrixd")]
        public static extern void LoadMatrixd(double* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glMatrixMode")]
        public static extern void MatrixMode(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixf")]
        public static extern void MultMatrixf(float* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultMatrixd")]
        public static extern void MultMatrixd(double* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glOrtho")]
        public static extern void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);
        
        [DllImport("opengl32.dll", EntryPoint = "glPopMatrix")]
        public static extern void PopMatrix();
        
        [DllImport("opengl32.dll", EntryPoint = "glPushMatrix")]
        public static extern void PushMatrix();
        
        [DllImport("opengl32.dll", EntryPoint = "glRotated")]
        public static extern void Rotated(double angle, double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glRotatef")]
        public static extern void Rotatef(float angle, float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glScaled")]
        public static extern void Scaled(double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glScalef")]
        public static extern void Scalef(float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glTranslated")]
        public static extern void Translated(double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glTranslatef")]
        public static extern void Translatef(float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(uint mode, int first, int count);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElements")]
        public static extern void DrawElements(uint mode, int count, uint type, void* indices);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetPointerv")]
        public static extern void GetPointerv(uint pname, void** parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glPolygonOffset")]
        public static extern void PolygonOffset(float factor, float units);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage1D")]
        public static extern void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexImage2D")]
        public static extern void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage1D")]
        public static extern void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage2D")]
        public static extern void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage1D")]
        public static extern void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage2D")]
        public static extern void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(uint target, uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(int n, uint* textures);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(int n, uint* textures);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsTexture")]
        public static extern byte IsTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glArrayElement")]
        public static extern void ArrayElement(int i);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorPointer")]
        public static extern void ColorPointer(int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisableClientState")]
        public static extern void DisableClientState(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glEdgeFlagPointer")]
        public static extern void EdgeFlagPointer(int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnableClientState")]
        public static extern void EnableClientState(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexPointer")]
        public static extern void IndexPointer(uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glInterleavedArrays")]
        public static extern void InterleavedArrays(uint format, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormalPointer")]
        public static extern void NormalPointer(uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordPointer")]
        public static extern void TexCoordPointer(int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexPointer")]
        public static extern void VertexPointer(int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glAreTexturesResident")]
        public static extern byte AreTexturesResident(int n, uint* textures, byte* residences);
        
        [DllImport("opengl32.dll", EntryPoint = "glPrioritizeTextures")]
        public static extern void PrioritizeTextures(int n, uint* textures, float* priorities);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexub")]
        public static extern void Indexub(byte c);
        
        [DllImport("opengl32.dll", EntryPoint = "glIndexubv")]
        public static extern void Indexubv(byte* c);
        
        [DllImport("opengl32.dll", EntryPoint = "glPopClientAttrib")]
        public static extern void PopClientAttrib();
        
        [DllImport("opengl32.dll", EntryPoint = "glPushClientAttrib")]
        public static extern void PushClientAttrib(uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElements")]
        public static extern void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage3D")]
        public static extern void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexSubImage3D")]
        public static extern void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyTexSubImage3D")]
        public static extern void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glSampleCoverage")]
        public static extern void SampleCoverage(float value, byte invert);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexImage3D")]
        public static extern void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexImage2D")]
        public static extern void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexImage1D")]
        public static extern void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage3D")]
        public static extern void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompressedTexSubImage1D")]
        public static extern void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetCompressedTexImage")]
        public static extern void GetCompressedTexImage(uint target, int level, void* img);
        
        [DllImport("opengl32.dll", EntryPoint = "glClientActiveTexture")]
        public static extern void ClientActiveTexture(uint texture);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1d")]
        public static extern void MultiTexCoord1d(uint target, double s);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1dv")]
        public static extern void MultiTexCoord1dv(uint target, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1f")]
        public static extern void MultiTexCoord1f(uint target, float s);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1fv")]
        public static extern void MultiTexCoord1fv(uint target, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1i")]
        public static extern void MultiTexCoord1i(uint target, int s);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1iv")]
        public static extern void MultiTexCoord1iv(uint target, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1s")]
        public static extern void MultiTexCoord1s(uint target, short s);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1sv")]
        public static extern void MultiTexCoord1sv(uint target, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2d")]
        public static extern void MultiTexCoord2d(uint target, double s, double t);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2dv")]
        public static extern void MultiTexCoord2dv(uint target, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2f")]
        public static extern void MultiTexCoord2f(uint target, float s, float t);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2fv")]
        public static extern void MultiTexCoord2fv(uint target, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2i")]
        public static extern void MultiTexCoord2i(uint target, int s, int t);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2iv")]
        public static extern void MultiTexCoord2iv(uint target, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2s")]
        public static extern void MultiTexCoord2s(uint target, short s, short t);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2sv")]
        public static extern void MultiTexCoord2sv(uint target, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3d")]
        public static extern void MultiTexCoord3d(uint target, double s, double t, double r);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3dv")]
        public static extern void MultiTexCoord3dv(uint target, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3f")]
        public static extern void MultiTexCoord3f(uint target, float s, float t, float r);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3fv")]
        public static extern void MultiTexCoord3fv(uint target, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3i")]
        public static extern void MultiTexCoord3i(uint target, int s, int t, int r);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3iv")]
        public static extern void MultiTexCoord3iv(uint target, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3s")]
        public static extern void MultiTexCoord3s(uint target, short s, short t, short r);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3sv")]
        public static extern void MultiTexCoord3sv(uint target, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4d")]
        public static extern void MultiTexCoord4d(uint target, double s, double t, double r, double q);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4dv")]
        public static extern void MultiTexCoord4dv(uint target, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4f")]
        public static extern void MultiTexCoord4f(uint target, float s, float t, float r, float q);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4fv")]
        public static extern void MultiTexCoord4fv(uint target, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4i")]
        public static extern void MultiTexCoord4i(uint target, int s, int t, int r, int q);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4iv")]
        public static extern void MultiTexCoord4iv(uint target, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4s")]
        public static extern void MultiTexCoord4s(uint target, short s, short t, short r, short q);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4sv")]
        public static extern void MultiTexCoord4sv(uint target, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadTransposeMatrixf")]
        public static extern void LoadTransposeMatrixf(float* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glLoadTransposeMatrixd")]
        public static extern void LoadTransposeMatrixd(double* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultTransposeMatrixf")]
        public static extern void MultTransposeMatrixf(float* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultTransposeMatrixd")]
        public static extern void MultTransposeMatrixd(double* m);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparate")]
        public static extern void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArrays")]
        public static extern void MultiDrawArrays(uint mode, int* first, int* count, int drawcount);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElements")]
        public static extern void MultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointParameterf")]
        public static extern void PointParameterf(uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointParameterfv")]
        public static extern void PointParameterfv(uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointParameteri")]
        public static extern void PointParameteri(uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glPointParameteriv")]
        public static extern void PointParameteriv(uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogCoordf")]
        public static extern void FogCoordf(float coord);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogCoordfv")]
        public static extern void FogCoordfv(float* coord);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogCoordd")]
        public static extern void FogCoordd(double coord);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogCoorddv")]
        public static extern void FogCoorddv(double* coord);
        
        [DllImport("opengl32.dll", EntryPoint = "glFogCoordPointer")]
        public static extern void FogCoordPointer(uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3b")]
        public static extern void SecondaryColor3b(sbyte red, sbyte green, sbyte blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3bv")]
        public static extern void SecondaryColor3bv(sbyte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3d")]
        public static extern void SecondaryColor3d(double red, double green, double blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3dv")]
        public static extern void SecondaryColor3dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3f")]
        public static extern void SecondaryColor3f(float red, float green, float blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3fv")]
        public static extern void SecondaryColor3fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3i")]
        public static extern void SecondaryColor3i(int red, int green, int blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3iv")]
        public static extern void SecondaryColor3iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3s")]
        public static extern void SecondaryColor3s(short red, short green, short blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3sv")]
        public static extern void SecondaryColor3sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3ub")]
        public static extern void SecondaryColor3ub(byte red, byte green, byte blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3ubv")]
        public static extern void SecondaryColor3ubv(byte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3ui")]
        public static extern void SecondaryColor3ui(uint red, uint green, uint blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3uiv")]
        public static extern void SecondaryColor3uiv(uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3us")]
        public static extern void SecondaryColor3us(ushort red, ushort green, ushort blue);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3usv")]
        public static extern void SecondaryColor3usv(ushort* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColorPointer")]
        public static extern void SecondaryColorPointer(int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2d")]
        public static extern void WindowPos2d(double x, double y);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2dv")]
        public static extern void WindowPos2dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2f")]
        public static extern void WindowPos2f(float x, float y);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2fv")]
        public static extern void WindowPos2fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2i")]
        public static extern void WindowPos2i(int x, int y);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2iv")]
        public static extern void WindowPos2iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2s")]
        public static extern void WindowPos2s(short x, short y);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos2sv")]
        public static extern void WindowPos2sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3d")]
        public static extern void WindowPos3d(double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3dv")]
        public static extern void WindowPos3dv(double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3f")]
        public static extern void WindowPos3f(float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3fv")]
        public static extern void WindowPos3fv(float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3i")]
        public static extern void WindowPos3i(int x, int y, int z);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3iv")]
        public static extern void WindowPos3iv(int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3s")]
        public static extern void WindowPos3s(short x, short y, short z);
        
        [DllImport("opengl32.dll", EntryPoint = "glWindowPos3sv")]
        public static extern void WindowPos3sv(short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendColor")]
        public static extern void BlendColor(float red, float green, float blue, float alpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquation")]
        public static extern void BlendEquation(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenQueries")]
        public static extern void GenQueries(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteQueries")]
        public static extern void DeleteQueries(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsQuery")]
        public static extern byte IsQuery(uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glBeginQuery")]
        public static extern void BeginQuery(uint target, uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glEndQuery")]
        public static extern void EndQuery(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryiv")]
        public static extern void GetQueryiv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectiv")]
        public static extern void GetQueryObjectiv(uint id, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectuiv")]
        public static extern void GetQueryObjectuiv(uint id, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(uint target, uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(int n, uint* buffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(int n, uint* buffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsBuffer")]
        public static extern byte IsBuffer(uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(uint target, IntPtr size, void* data, uint usage);
        
        [DllImport("opengl32.dll", EntryPoint = "glBufferSubData")]
        public static extern void BufferSubData(uint target, IntPtr offset, IntPtr size, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferSubData")]
        public static extern void GetBufferSubData(uint target, IntPtr offset, IntPtr size, void* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glMapBuffer")]
        public static extern void* MapBuffer(uint target, uint access);
        
        [DllImport("opengl32.dll", EntryPoint = "glUnmapBuffer")]
        public static extern byte UnmapBuffer(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferParameteriv")]
        public static extern void GetBufferParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferPointerv")]
        public static extern void GetBufferPointerv(uint target, uint pname, void** parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparate")]
        public static extern void BlendEquationSeparate(uint modeRGB, uint modeAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawBuffers")]
        public static extern void DrawBuffers(int n, uint* bufs);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilOpSeparate")]
        public static extern void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilFuncSeparate")]
        public static extern void StencilFuncSeparate(uint face, uint func, int reference, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glStencilMaskSeparate")]
        public static extern void StencilMaskSeparate(uint face, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glAttachShader")]
        public static extern void AttachShader(uint program, uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindAttribLocation")]
        public static extern void BindAttribLocation(uint program, uint index, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glCompileShader")]
        public static extern void CompileShader(uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glCreateProgram")]
        public static extern uint CreateProgram();
        
        [DllImport("opengl32.dll", EntryPoint = "glCreateShader")]
        public static extern uint CreateShader(uint type);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteProgram")]
        public static extern void DeleteProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteShader")]
        public static extern void DeleteShader(uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glDetachShader")]
        public static extern void DetachShader(uint program, uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisableVertexAttribArray")]
        public static extern void DisableVertexAttribArray(uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnableVertexAttribArray")]
        public static extern void EnableVertexAttribArray(uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetAttachedShaders")]
        public static extern void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetAttribLocation")]
        public static extern int GetAttribLocation(uint program, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramiv")]
        public static extern void GetProgramiv(uint program, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramInfoLog")]
        public static extern void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderiv")]
        public static extern void GetShaderiv(uint shader, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderInfoLog")]
        public static extern void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderSource")]
        public static extern void GetShaderSource(uint shader, int bufSize, int* length, char* source);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformLocation")]
        public static extern int GetUniformLocation(uint program, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformfv")]
        public static extern void GetUniformfv(uint program, int location, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformiv")]
        public static extern void GetUniformiv(uint program, int location, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribdv")]
        public static extern void GetVertexAttribdv(uint index, uint pname, double* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttribfv(uint index, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttribiv(uint index, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribPointerv")]
        public static extern void GetVertexAttribPointerv(uint index, uint pname, void** pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsProgram")]
        public static extern byte IsProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsShader")]
        public static extern byte IsShader(uint shader);
        
        [DllImport("opengl32.dll", EntryPoint = "glLinkProgram")]
        public static extern void LinkProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(uint shader, int count, char** str, int* length);
        
        [DllImport("opengl32.dll", EntryPoint = "glUseProgram")]
        public static extern void UseProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1f")]
        public static extern void Uniform1f(int location, float v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2f")]
        public static extern void Uniform2f(int location, float v0, float v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3f")]
        public static extern void Uniform3f(int location, float v0, float v1, float v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4f")]
        public static extern void Uniform4f(int location, float v0, float v1, float v2, float v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1i")]
        public static extern void Uniform1i(int location, int v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2i")]
        public static extern void Uniform2i(int location, int v0, int v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3i")]
        public static extern void Uniform3i(int location, int v0, int v1, int v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4i")]
        public static extern void Uniform4i(int location, int v0, int v1, int v2, int v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1fv")]
        public static extern void Uniform1fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2fv")]
        public static extern void Uniform2fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3fv")]
        public static extern void Uniform3fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4fv")]
        public static extern void Uniform4fv(int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1iv")]
        public static extern void Uniform1iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2iv")]
        public static extern void Uniform2iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3iv")]
        public static extern void Uniform3iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4iv")]
        public static extern void Uniform4iv(int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2fv")]
        public static extern void UniformMatrix2fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3fv")]
        public static extern void UniformMatrix3fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4fv")]
        public static extern void UniformMatrix4fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glValidateProgram")]
        public static extern void ValidateProgram(uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1d")]
        public static extern void VertexAttrib1d(uint index, double x);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1dv")]
        public static extern void VertexAttrib1dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1f")]
        public static extern void VertexAttrib1f(uint index, float x);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1fv")]
        public static extern void VertexAttrib1fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1s")]
        public static extern void VertexAttrib1s(uint index, short x);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1sv")]
        public static extern void VertexAttrib1sv(uint index, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2d")]
        public static extern void VertexAttrib2d(uint index, double x, double y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2dv")]
        public static extern void VertexAttrib2dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2f")]
        public static extern void VertexAttrib2f(uint index, float x, float y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2fv")]
        public static extern void VertexAttrib2fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2s")]
        public static extern void VertexAttrib2s(uint index, short x, short y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2sv")]
        public static extern void VertexAttrib2sv(uint index, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3d")]
        public static extern void VertexAttrib3d(uint index, double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3dv")]
        public static extern void VertexAttrib3dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3f")]
        public static extern void VertexAttrib3f(uint index, float x, float y, float z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3fv")]
        public static extern void VertexAttrib3fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3s")]
        public static extern void VertexAttrib3s(uint index, short x, short y, short z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3sv")]
        public static extern void VertexAttrib3sv(uint index, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4Nbv")]
        public static extern void VertexAttrib4Nbv(uint index, sbyte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4Niv")]
        public static extern void VertexAttrib4Niv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4Nsv")]
        public static extern void VertexAttrib4Nsv(uint index, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4Nub")]
        public static extern void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4Nubv")]
        public static extern void VertexAttrib4Nubv(uint index, byte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4Nuiv")]
        public static extern void VertexAttrib4Nuiv(uint index, uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4Nusv")]
        public static extern void VertexAttrib4Nusv(uint index, ushort* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4bv")]
        public static extern void VertexAttrib4bv(uint index, sbyte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4d")]
        public static extern void VertexAttrib4d(uint index, double x, double y, double z, double w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4dv")]
        public static extern void VertexAttrib4dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4f")]
        public static extern void VertexAttrib4f(uint index, float x, float y, float z, float w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4fv")]
        public static extern void VertexAttrib4fv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4iv")]
        public static extern void VertexAttrib4iv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4s")]
        public static extern void VertexAttrib4s(uint index, short x, short y, short z, short w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4sv")]
        public static extern void VertexAttrib4sv(uint index, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4ubv")]
        public static extern void VertexAttrib4ubv(uint index, byte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4uiv")]
        public static extern void VertexAttrib4uiv(uint index, uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4usv")]
        public static extern void VertexAttrib4usv(uint index, ushort* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribPointer")]
        public static extern void VertexAttribPointer(uint index, int size, uint type, byte normalized, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x3fv")]
        public static extern void UniformMatrix2x3fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x2fv")]
        public static extern void UniformMatrix3x2fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x4fv")]
        public static extern void UniformMatrix2x4fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x2fv")]
        public static extern void UniformMatrix4x2fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x4fv")]
        public static extern void UniformMatrix3x4fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x3fv")]
        public static extern void UniformMatrix4x3fv(int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorMaski")]
        public static extern void ColorMaski(uint index, byte r, byte g, byte b, byte a);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBooleani_v")]
        public static extern void GetBooleani_v(uint target, uint index, byte* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetIntegeri_v")]
        public static extern void GetIntegeri_v(uint target, uint index, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glEnablei")]
        public static extern void Enablei(uint target, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glDisablei")]
        public static extern void Disablei(uint target, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsEnabledi")]
        public static extern byte IsEnabledi(uint target, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glBeginTransformFeedback")]
        public static extern void BeginTransformFeedback(uint primitiveMode);
        
        [DllImport("opengl32.dll", EntryPoint = "glEndTransformFeedback")]
        public static extern void EndTransformFeedback();
        
        [DllImport("opengl32.dll", EntryPoint = "glBindBufferRange")]
        public static extern void BindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindBufferBase")]
        public static extern void BindBufferBase(uint target, uint index, uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackVaryings")]
        public static extern void TransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTransformFeedbackVarying")]
        public static extern void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glClampColor")]
        public static extern void ClampColor(uint target, uint clamp);
        
        [DllImport("opengl32.dll", EntryPoint = "glBeginConditionalRender")]
        public static extern void BeginConditionalRender(uint id, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glEndConditionalRender")]
        public static extern void EndConditionalRender();
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribIPointer")]
        public static extern void VertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribIiv")]
        public static extern void GetVertexAttribIiv(uint index, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribIuiv")]
        public static extern void GetVertexAttribIuiv(uint index, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1i")]
        public static extern void VertexAttribI1i(uint index, int x);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2i")]
        public static extern void VertexAttribI2i(uint index, int x, int y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3i")]
        public static extern void VertexAttribI3i(uint index, int x, int y, int z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4i")]
        public static extern void VertexAttribI4i(uint index, int x, int y, int z, int w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1ui")]
        public static extern void VertexAttribI1ui(uint index, uint x);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2ui")]
        public static extern void VertexAttribI2ui(uint index, uint x, uint y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3ui")]
        public static extern void VertexAttribI3ui(uint index, uint x, uint y, uint z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4ui")]
        public static extern void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1iv")]
        public static extern void VertexAttribI1iv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2iv")]
        public static extern void VertexAttribI2iv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3iv")]
        public static extern void VertexAttribI3iv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4iv")]
        public static extern void VertexAttribI4iv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1uiv")]
        public static extern void VertexAttribI1uiv(uint index, uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2uiv")]
        public static extern void VertexAttribI2uiv(uint index, uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3uiv")]
        public static extern void VertexAttribI3uiv(uint index, uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4uiv")]
        public static extern void VertexAttribI4uiv(uint index, uint* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4bv")]
        public static extern void VertexAttribI4bv(uint index, sbyte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4sv")]
        public static extern void VertexAttribI4sv(uint index, short* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4ubv")]
        public static extern void VertexAttribI4ubv(uint index, byte* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4usv")]
        public static extern void VertexAttribI4usv(uint index, ushort* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformuiv")]
        public static extern void GetUniformuiv(uint program, int location, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindFragDataLocation")]
        public static extern void BindFragDataLocation(uint program, uint color, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFragDataLocation")]
        public static extern int GetFragDataLocation(uint program, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1ui")]
        public static extern void Uniform1ui(int location, uint v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2ui")]
        public static extern void Uniform2ui(int location, uint v0, uint v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3ui")]
        public static extern void Uniform3ui(int location, uint v0, uint v1, uint v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4ui")]
        public static extern void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1uiv")]
        public static extern void Uniform1uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2uiv")]
        public static extern void Uniform2uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3uiv")]
        public static extern void Uniform3uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4uiv")]
        public static extern void Uniform4uiv(int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterIiv")]
        public static extern void TexParameterIiv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexParameterIuiv")]
        public static extern void TexParameterIuiv(uint target, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIiv")]
        public static extern void GetTexParameterIiv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIuiv")]
        public static extern void GetTexParameterIuiv(uint target, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferiv")]
        public static extern void ClearBufferiv(uint buffer, int drawbuffer, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferuiv")]
        public static extern void ClearBufferuiv(uint buffer, int drawbuffer, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferfv")]
        public static extern void ClearBufferfv(uint buffer, int drawbuffer, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearBufferfi")]
        public static extern void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetStringi")]
        public static extern byte* GetStringi(uint name, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsRenderbuffer")]
        public static extern byte IsRenderbuffer(uint renderbuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindRenderbuffer")]
        public static extern void BindRenderbuffer(uint target, uint renderbuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffers(int n, uint* renderbuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(int n, uint* renderbuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorage")]
        public static extern void RenderbufferStorage(uint target, uint internalformat, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameteriv(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsFramebuffer")]
        public static extern byte IsFramebuffer(uint framebuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindFramebuffer")]
        public static extern void BindFramebuffer(uint target, uint framebuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffers(int n, uint* framebuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(int n, uint* framebuffers);
        
        [DllImport("opengl32.dll", EntryPoint = "glCheckFramebufferStatus")]
        public static extern uint CheckFramebufferStatus(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture1D")]
        public static extern void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2D")]
        public static extern void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture3D")]
        public static extern void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferRenderbuffer")]
        public static extern void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenerateMipmap")]
        public static extern void GenerateMipmap(uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlitFramebuffer")]
        public static extern void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        
        [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisample")]
        public static extern void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureLayer")]
        public static extern void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);
        
        [DllImport("opengl32.dll", EntryPoint = "glMapBufferRange")]
        public static extern void* MapBufferRange(uint target, IntPtr offset, IntPtr length, uint access);
        
        [DllImport("opengl32.dll", EntryPoint = "glFlushMappedBufferRange")]
        public static extern void FlushMappedBufferRange(uint target, IntPtr offset, IntPtr length);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindVertexArray")]
        public static extern void BindVertexArray(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteVertexArrays")]
        public static extern void DeleteVertexArrays(int n, uint* arrays);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenVertexArrays")]
        public static extern void GenVertexArrays(int n, uint* arrays);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsVertexArray")]
        public static extern byte IsVertexArray(uint array);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstanced")]
        public static extern void DrawArraysInstanced(uint mode, int first, int count, int instancecount);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstanced")]
        public static extern void DrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexBuffer")]
        public static extern void TexBuffer(uint target, uint internalformat, uint buffer);
        
        [DllImport("opengl32.dll", EntryPoint = "glPrimitiveRestartIndex")]
        public static extern void PrimitiveRestartIndex(uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glCopyBufferSubData")]
        public static extern void CopyBufferSubData(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformIndices")]
        public static extern void GetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformsiv")]
        public static extern void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformName")]
        public static extern void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformBlockIndex")]
        public static extern uint GetUniformBlockIndex(uint program, char* uniformBlockName);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformBlockiv")]
        public static extern void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformBlockName")]
        public static extern void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformBlockBinding")]
        public static extern void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsBaseVertex")]
        public static extern void DrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementsBaseVertex")]
        public static extern void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public static extern void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsBaseVertex")]
        public static extern void MultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex);
        
        [DllImport("opengl32.dll", EntryPoint = "glProvokingVertex")]
        public static extern void ProvokingVertex(uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glFenceSync")]
        public static extern GLsync* FenceSync(uint condition, uint flags);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsSync")]
        public static extern byte IsSync(GLsync* sync);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteSync")]
        public static extern void DeleteSync(GLsync* sync);
        
        [DllImport("opengl32.dll", EntryPoint = "glClientWaitSync")]
        public static extern uint ClientWaitSync(GLsync* sync, uint flags, uint timeout);
        
        [DllImport("opengl32.dll", EntryPoint = "glWaitSync")]
        public static extern void WaitSync(GLsync* sync, uint flags, uint timeout);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetInteger64v")]
        public static extern void GetInteger64v(uint pname, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSynciv")]
        public static extern void GetSynciv(GLsync* sync, uint pname, int count, int* length, int* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetInteger64i_v")]
        public static extern void GetInteger64i_v(uint target, uint index, int* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetBufferParameteri64v")]
        public static extern void GetBufferParameteri64v(uint target, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture")]
        public static extern void FramebufferTexture(uint target, uint attachment, uint texture, int level);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage2DMultisample")]
        public static extern void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexImage3DMultisample")]
        public static extern void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetMultisamplefv")]
        public static extern void GetMultisamplefv(uint pname, uint index, float* val);
        
        [DllImport("opengl32.dll", EntryPoint = "glSampleMaski")]
        public static extern void SampleMaski(uint maskNumber, uint mask);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindFragDataLocationIndexed")]
        public static extern void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFragDataIndex")]
        public static extern int GetFragDataIndex(uint program, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenSamplers")]
        public static extern void GenSamplers(int count, uint* samplers);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteSamplers")]
        public static extern void DeleteSamplers(int count, uint* samplers);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsSampler")]
        public static extern byte IsSampler(uint sampler);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindSampler")]
        public static extern void BindSampler(uint unit, uint sampler);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameteri")]
        public static extern void SamplerParameteri(uint sampler, uint pname, int param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameteriv")]
        public static extern void SamplerParameteriv(uint sampler, uint pname, int* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterf")]
        public static extern void SamplerParameterf(uint sampler, uint pname, float param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterfv")]
        public static extern void SamplerParameterfv(uint sampler, uint pname, float* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIiv")]
        public static extern void SamplerParameterIiv(uint sampler, uint pname, int* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIuiv")]
        public static extern void SamplerParameterIuiv(uint sampler, uint pname, uint* param);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameteriv")]
        public static extern void GetSamplerParameteriv(uint sampler, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIiv")]
        public static extern void GetSamplerParameterIiv(uint sampler, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterfv")]
        public static extern void GetSamplerParameterfv(uint sampler, uint pname, float* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIuiv")]
        public static extern void GetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glQueryCounter")]
        public static extern void QueryCounter(uint id, uint target);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjecti64v")]
        public static extern void GetQueryObjecti64v(uint id, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectui64v")]
        public static extern void GetQueryObjectui64v(uint id, uint pname, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribDivisor")]
        public static extern void VertexAttribDivisor(uint index, uint divisor);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP1ui")]
        public static extern void VertexAttribP1ui(uint index, uint type, byte normalized, uint value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP1uiv")]
        public static extern void VertexAttribP1uiv(uint index, uint type, byte normalized, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP2ui")]
        public static extern void VertexAttribP2ui(uint index, uint type, byte normalized, uint value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP2uiv")]
        public static extern void VertexAttribP2uiv(uint index, uint type, byte normalized, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP3ui")]
        public static extern void VertexAttribP3ui(uint index, uint type, byte normalized, uint value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP3uiv")]
        public static extern void VertexAttribP3uiv(uint index, uint type, byte normalized, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP4ui")]
        public static extern void VertexAttribP4ui(uint index, uint type, byte normalized, uint value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP4uiv")]
        public static extern void VertexAttribP4uiv(uint index, uint type, byte normalized, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexP2ui")]
        public static extern void VertexP2ui(uint type, uint value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexP2uiv")]
        public static extern void VertexP2uiv(uint type, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexP3ui")]
        public static extern void VertexP3ui(uint type, uint value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexP3uiv")]
        public static extern void VertexP3uiv(uint type, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexP4ui")]
        public static extern void VertexP4ui(uint type, uint value);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexP4uiv")]
        public static extern void VertexP4uiv(uint type, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP1ui")]
        public static extern void TexCoordP1ui(uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP1uiv")]
        public static extern void TexCoordP1uiv(uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP2ui")]
        public static extern void TexCoordP2ui(uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP2uiv")]
        public static extern void TexCoordP2uiv(uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP3ui")]
        public static extern void TexCoordP3ui(uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP3uiv")]
        public static extern void TexCoordP3uiv(uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP4ui")]
        public static extern void TexCoordP4ui(uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexCoordP4uiv")]
        public static extern void TexCoordP4uiv(uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP1ui")]
        public static extern void MultiTexCoordP1ui(uint texture, uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP1uiv")]
        public static extern void MultiTexCoordP1uiv(uint texture, uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP2ui")]
        public static extern void MultiTexCoordP2ui(uint texture, uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP2uiv")]
        public static extern void MultiTexCoordP2uiv(uint texture, uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP3ui")]
        public static extern void MultiTexCoordP3ui(uint texture, uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP3uiv")]
        public static extern void MultiTexCoordP3uiv(uint texture, uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP4ui")]
        public static extern void MultiTexCoordP4ui(uint texture, uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoordP4uiv")]
        public static extern void MultiTexCoordP4uiv(uint texture, uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormalP3ui")]
        public static extern void NormalP3ui(uint type, uint coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glNormalP3uiv")]
        public static extern void NormalP3uiv(uint type, uint* coords);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorP3ui")]
        public static extern void ColorP3ui(uint type, uint color);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorP3uiv")]
        public static extern void ColorP3uiv(uint type, uint* color);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorP4ui")]
        public static extern void ColorP4ui(uint type, uint color);
        
        [DllImport("opengl32.dll", EntryPoint = "glColorP4uiv")]
        public static extern void ColorP4uiv(uint type, uint* color);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColorP3ui")]
        public static extern void SecondaryColorP3ui(uint type, uint color);
        
        [DllImport("opengl32.dll", EntryPoint = "glSecondaryColorP3uiv")]
        public static extern void SecondaryColorP3uiv(uint type, uint* color);
        
        [DllImport("opengl32.dll", EntryPoint = "glMinSampleShading")]
        public static extern void MinSampleShading(float value);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquationi")]
        public static extern void BlendEquationi(uint buf, uint mode);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparatei")]
        public static extern void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFunci")]
        public static extern void BlendFunci(uint buf, uint src, uint dst);
        
        [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparatei")]
        public static extern void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArraysIndirect")]
        public static extern void DrawArraysIndirect(uint mode, void* indirect);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsIndirect")]
        public static extern void DrawElementsIndirect(uint mode, uint type, void* indirect);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1d")]
        public static extern void Uniform1d(int location, double x);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2d")]
        public static extern void Uniform2d(int location, double x, double y);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3d")]
        public static extern void Uniform3d(int location, double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4d")]
        public static extern void Uniform4d(int location, double x, double y, double z, double w);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform1dv")]
        public static extern void Uniform1dv(int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform2dv")]
        public static extern void Uniform2dv(int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform3dv")]
        public static extern void Uniform3dv(int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniform4dv")]
        public static extern void Uniform4dv(int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2dv")]
        public static extern void UniformMatrix2dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3dv")]
        public static extern void UniformMatrix3dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4dv")]
        public static extern void UniformMatrix4dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x3dv")]
        public static extern void UniformMatrix2x3dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x4dv")]
        public static extern void UniformMatrix2x4dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x2dv")]
        public static extern void UniformMatrix3x2dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x4dv")]
        public static extern void UniformMatrix3x4dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x2dv")]
        public static extern void UniformMatrix4x2dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x3dv")]
        public static extern void UniformMatrix4x3dv(int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformdv")]
        public static extern void GetUniformdv(uint program, int location, double* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSubroutineUniformLocation")]
        public static extern int GetSubroutineUniformLocation(uint program, uint shadertype, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetSubroutineIndex")]
        public static extern uint GetSubroutineIndex(uint program, uint shadertype, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveSubroutineUniformiv")]
        public static extern void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveSubroutineUniformName")]
        public static extern void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveSubroutineName")]
        public static extern void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name);
        
        [DllImport("opengl32.dll", EntryPoint = "glUniformSubroutinesuiv")]
        public static extern void UniformSubroutinesuiv(uint shadertype, int count, uint* indices);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetUniformSubroutineuiv")]
        public static extern void GetUniformSubroutineuiv(uint shadertype, int location, uint* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramStageiv")]
        public static extern void GetProgramStageiv(uint program, uint shadertype, uint pname, int* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glPatchParameteri")]
        public static extern void PatchParameteri(uint pname, int value);
        
        [DllImport("opengl32.dll", EntryPoint = "glPatchParameterfv")]
        public static extern void PatchParameterfv(uint pname, float* values);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindTransformFeedback")]
        public static extern void BindTransformFeedback(uint target, uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteTransformFeedbacks")]
        public static extern void DeleteTransformFeedbacks(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenTransformFeedbacks")]
        public static extern void GenTransformFeedbacks(int n, uint* ids);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsTransformFeedback")]
        public static extern byte IsTransformFeedback(uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glPauseTransformFeedback")]
        public static extern void PauseTransformFeedback();
        
        [DllImport("opengl32.dll", EntryPoint = "glResumeTransformFeedback")]
        public static extern void ResumeTransformFeedback();
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedback")]
        public static extern void DrawTransformFeedback(uint mode, uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackStream")]
        public static extern void DrawTransformFeedbackStream(uint mode, uint id, uint stream);
        
        [DllImport("opengl32.dll", EntryPoint = "glBeginQueryIndexed")]
        public static extern void BeginQueryIndexed(uint target, uint index, uint id);
        
        [DllImport("opengl32.dll", EntryPoint = "glEndQueryIndexed")]
        public static extern void EndQueryIndexed(uint target, uint index);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetQueryIndexediv")]
        public static extern void GetQueryIndexediv(uint target, uint index, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glReleaseShaderCompiler")]
        public static extern void ReleaseShaderCompiler();
        
        [DllImport("opengl32.dll", EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthRangef")]
        public static extern void DepthRangef(float n, float f);
        
        [DllImport("opengl32.dll", EntryPoint = "glClearDepthf")]
        public static extern void ClearDepthf(float d);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramBinary")]
        public static extern void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramBinary")]
        public static extern void ProgramBinary(uint program, uint binaryFormat, void* binary, int length);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramParameteri")]
        public static extern void ProgramParameteri(uint program, uint pname, int value);
        
        [DllImport("opengl32.dll", EntryPoint = "glUseProgramStages")]
        public static extern void UseProgramStages(uint pipeline, uint stages, uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glActiveShaderProgram")]
        public static extern void ActiveShaderProgram(uint pipeline, uint program);
        
        [DllImport("opengl32.dll", EntryPoint = "glCreateShaderProgramv")]
        public static extern uint CreateShaderProgramv(uint type, int count, char** strings);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindProgramPipeline")]
        public static extern void BindProgramPipeline(uint pipeline);
        
        [DllImport("opengl32.dll", EntryPoint = "glDeleteProgramPipelines")]
        public static extern void DeleteProgramPipelines(int n, uint* pipelines);
        
        [DllImport("opengl32.dll", EntryPoint = "glGenProgramPipelines")]
        public static extern void GenProgramPipelines(int n, uint* pipelines);
        
        [DllImport("opengl32.dll", EntryPoint = "glIsProgramPipeline")]
        public static extern byte IsProgramPipeline(uint pipeline);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineiv")]
        public static extern void GetProgramPipelineiv(uint pipeline, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i")]
        public static extern void ProgramUniform1i(uint program, int location, int v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1iv")]
        public static extern void ProgramUniform1iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1f")]
        public static extern void ProgramUniform1f(uint program, int location, float v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1fv")]
        public static extern void ProgramUniform1fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1d")]
        public static extern void ProgramUniform1d(uint program, int location, double v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1dv")]
        public static extern void ProgramUniform1dv(uint program, int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui")]
        public static extern void ProgramUniform1ui(uint program, int location, uint v0);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1uiv")]
        public static extern void ProgramUniform1uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i")]
        public static extern void ProgramUniform2i(uint program, int location, int v0, int v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2iv")]
        public static extern void ProgramUniform2iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2f")]
        public static extern void ProgramUniform2f(uint program, int location, float v0, float v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2fv")]
        public static extern void ProgramUniform2fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2d")]
        public static extern void ProgramUniform2d(uint program, int location, double v0, double v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2dv")]
        public static extern void ProgramUniform2dv(uint program, int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui")]
        public static extern void ProgramUniform2ui(uint program, int location, uint v0, uint v1);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2uiv")]
        public static extern void ProgramUniform2uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i")]
        public static extern void ProgramUniform3i(uint program, int location, int v0, int v1, int v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3iv")]
        public static extern void ProgramUniform3iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3f")]
        public static extern void ProgramUniform3f(uint program, int location, float v0, float v1, float v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3fv")]
        public static extern void ProgramUniform3fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3d")]
        public static extern void ProgramUniform3d(uint program, int location, double v0, double v1, double v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3dv")]
        public static extern void ProgramUniform3dv(uint program, int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui")]
        public static extern void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3uiv")]
        public static extern void ProgramUniform3uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i")]
        public static extern void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4iv")]
        public static extern void ProgramUniform4iv(uint program, int location, int count, int* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4f")]
        public static extern void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4fv")]
        public static extern void ProgramUniform4fv(uint program, int location, int count, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4d")]
        public static extern void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4dv")]
        public static extern void ProgramUniform4dv(uint program, int location, int count, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui")]
        public static extern void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4uiv")]
        public static extern void ProgramUniform4uiv(uint program, int location, int count, uint* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2fv")]
        public static extern void ProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3fv")]
        public static extern void ProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4fv")]
        public static extern void ProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2dv")]
        public static extern void ProgramUniformMatrix2dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3dv")]
        public static extern void ProgramUniformMatrix3dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4dv")]
        public static extern void ProgramUniformMatrix4dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3fv")]
        public static extern void ProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2fv")]
        public static extern void ProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4fv")]
        public static extern void ProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2fv")]
        public static extern void ProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4fv")]
        public static extern void ProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3fv")]
        public static extern void ProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3dv")]
        public static extern void ProgramUniformMatrix2x3dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2dv")]
        public static extern void ProgramUniformMatrix3x2dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4dv")]
        public static extern void ProgramUniformMatrix2x4dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2dv")]
        public static extern void ProgramUniformMatrix4x2dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4dv")]
        public static extern void ProgramUniformMatrix3x4dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3dv")]
        public static extern void ProgramUniformMatrix4x3dv(uint program, int location, int count, byte transpose, double* value);
        
        [DllImport("opengl32.dll", EntryPoint = "glValidateProgramPipeline")]
        public static extern void ValidateProgramPipeline(uint pipeline);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineInfoLog")]
        public static extern void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1d")]
        public static extern void VertexAttribL1d(uint index, double x);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2d")]
        public static extern void VertexAttribL2d(uint index, double x, double y);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3d")]
        public static extern void VertexAttribL3d(uint index, double x, double y, double z);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4d")]
        public static extern void VertexAttribL4d(uint index, double x, double y, double z, double w);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1dv")]
        public static extern void VertexAttribL1dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2dv")]
        public static extern void VertexAttribL2dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3dv")]
        public static extern void VertexAttribL3dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4dv")]
        public static extern void VertexAttribL4dv(uint index, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glVertexAttribLPointer")]
        public static extern void VertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribLdv")]
        public static extern void GetVertexAttribLdv(uint index, uint pname, double* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glViewportArrayv")]
        public static extern void ViewportArrayv(uint first, int count, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedf")]
        public static extern void ViewportIndexedf(uint index, float x, float y, float w, float h);
        
        [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedfv")]
        public static extern void ViewportIndexedfv(uint index, float* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glScissorArrayv")]
        public static extern void ScissorArrayv(uint first, int count, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glScissorIndexed")]
        public static extern void ScissorIndexed(uint index, int left, int bottom, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glScissorIndexedv")]
        public static extern void ScissorIndexedv(uint index, int* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthRangeArrayv")]
        public static extern void DepthRangeArrayv(uint first, int count, double* v);
        
        [DllImport("opengl32.dll", EntryPoint = "glDepthRangeIndexed")]
        public static extern void DepthRangeIndexed(uint index, double n, double f);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetFloati_v")]
        public static extern void GetFloati_v(uint target, uint index, float* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetDoublei_v")]
        public static extern void GetDoublei_v(uint target, uint index, double* data);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public static extern void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public static extern void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public static extern void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetInternalformativ")]
        public static extern void GetInternalformativ(uint target, uint internalformat, uint pname, int count, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public static extern void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* parameters);
        
        [DllImport("opengl32.dll", EntryPoint = "glBindImageTexture")]
        public static extern void BindImageTexture(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format);
        
        [DllImport("opengl32.dll", EntryPoint = "glMemoryBarrier")]
        public static extern void MemoryBarrier(uint barriers);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage1D")]
        public static extern void TexStorage1D(uint target, int levels, uint internalformat, int width);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage2D")]
        public static extern void TexStorage2D(uint target, int levels, uint internalformat, int width, int height);
        
        [DllImport("opengl32.dll", EntryPoint = "glTexStorage3D")]
        public static extern void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackInstanced")]
        public static extern void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);
        
        [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public static extern void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount);
        
    }
}
