// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGL.Compatibility
{
    public static unsafe partial class GL
    {
        public static void CullFace(TriangleFace mode) => GLPointers._glCullFace_fnptr((uint)mode);
        
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._glFrontFace_fnptr((uint)mode);
        
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._glHint_fnptr((uint)target, (uint)mode);
        
        public static void LineWidth(float width) => GLPointers._glLineWidth_fnptr(width);
        
        public static void PointSize(float size) => GLPointers._glPointSize_fnptr(size);
        
        public static void PolygonMode(TriangleFace face, PolygonMode mode) => GLPointers._glPolygonMode_fnptr((uint)face, (uint)mode);
        
        public static void Scissor(int x, int y, int width, int height) => GLPointers._glScissor_fnptr(x, y, width, height);
        
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._glTexParameterf_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._glTexParameteri_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage1D_fnptr((uint)target, level, (int)internalformat, width, border, (uint)format, (uint)type, pixels);
        
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage2D_fnptr((uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
        
        public static void DrawBuffer(DrawBufferMode buf) => GLPointers._glDrawBuffer_fnptr((uint)buf);
        
        public static void Clear(ClearBufferMask mask) => GLPointers._glClear_fnptr((uint)mask);
        
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._glClearColor_fnptr(red, green, blue, alpha);
        
        public static void ClearStencil(int s) => GLPointers._glClearStencil_fnptr(s);
        
        public static void ClearDepth(double depth) => GLPointers._glClearDepth_fnptr(depth);
        
        public static void StencilMask(uint mask) => GLPointers._glStencilMask_fnptr(mask);
        
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => GLPointers._glColorMask_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
        
        public static void DepthMask(bool flag) => GLPointers._glDepthMask_fnptr((byte)(flag ? 1 : 0));
        
        public static void Disable(EnableCap cap) => GLPointers._glDisable_fnptr((uint)cap);
        
        public static void Enable(EnableCap cap) => GLPointers._glEnable_fnptr((uint)cap);
        
        public static void Finish() => GLPointers._glFinish_fnptr();
        
        public static void Flush() => GLPointers._glFlush_fnptr();
        
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._glBlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        public static void LogicOp(LogicOp opcode) => GLPointers._glLogicOp_fnptr((uint)opcode);
        
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._glStencilFunc_fnptr((uint)func, reference, mask);
        
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._glStencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        public static void DepthFunc(DepthFunction func) => GLPointers._glDepthFunc_fnptr((uint)func);
        
        public static void PixelStoref(PixelStoreParameter pname, float param) => GLPointers._glPixelStoref_fnptr((uint)pname, param);
        
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._glPixelStorei_fnptr((uint)pname, param);
        
        public static void ReadBuffer(ReadBufferMode src) => GLPointers._glReadBuffer_fnptr((uint)src);
        
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        public static void GetBooleanv(GetPName pname, bool* data) => GLPointers._glGetBooleanv_fnptr((uint)pname, (byte*)data);
        
        public static void GetDoublev(GetPName pname, double* data) => GLPointers._glGetDoublev_fnptr((uint)pname, data);
        
        public static ErrorCode GetError() => (ErrorCode) GLPointers._glGetError_fnptr();
        
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._glGetFloatv_fnptr((uint)pname, data);
        
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._glGetIntegerv_fnptr((uint)pname, data);
        
        public static byte* GetString_(StringName name) => GLPointers._glGetString_fnptr((uint)name);
        
        public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, void* pixels) => GLPointers._glGetTexImage_fnptr((uint)target, level, (uint)format, (uint)type, pixels);
        
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexLevelParameterfv_fnptr((uint)target, level, (uint)pname, parameters);
        
        public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexLevelParameteriv_fnptr((uint)target, level, (uint)pname, parameters);
        
        public static bool IsEnabled(EnableCap cap) => GLPointers._glIsEnabled_fnptr((uint)cap) != 0;
        
        public static void DepthRange(double n, double f) => GLPointers._glDepthRange_fnptr(n, f);
        
        public static void Viewport(int x, int y, int width, int height) => GLPointers._glViewport_fnptr(x, y, width, height);
        
        public static void NewList(int list, ListMode mode) => GLPointers._glNewList_fnptr(list, (uint)mode);
        
        public static void EndList() => GLPointers._glEndList_fnptr();
        
        public static void CallList(int list) => GLPointers._glCallList_fnptr(list);
        
        public static void CallLists(int n, ListNameType type, void* lists) => GLPointers._glCallLists_fnptr(n, (uint)type, lists);
        
        public static void DeleteLists(int list, int range) => GLPointers._glDeleteLists_fnptr(list, range);
        
        public static int GenLists(int range) => GLPointers._glGenLists_fnptr(range);
        
        public static void ListBase(int @base) => GLPointers._glListBase_fnptr(@base);
        
        public static void Begin(PrimitiveType mode) => GLPointers._glBegin_fnptr((uint)mode);
        
        public static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap) => GLPointers._glBitmap_fnptr(width, height, xorig, yorig, xmove, ymove, bitmap);
        
        public static void Color3b(sbyte red, sbyte green, sbyte blue) => GLPointers._glColor3b_fnptr(red, green, blue);
        
        public static void Color3bv(sbyte* v) => GLPointers._glColor3bv_fnptr(v);
        
        public static void Color3d(double red, double green, double blue) => GLPointers._glColor3d_fnptr(red, green, blue);
        
        public static void Color3dv(double* v) => GLPointers._glColor3dv_fnptr(v);
        
        public static void Color3f(float red, float green, float blue) => GLPointers._glColor3f_fnptr(red, green, blue);
        
        public static void Color3fv(float* v) => GLPointers._glColor3fv_fnptr(v);
        
        public static void Color3i(int red, int green, int blue) => GLPointers._glColor3i_fnptr(red, green, blue);
        
        public static void Color3iv(int* v) => GLPointers._glColor3iv_fnptr(v);
        
        public static void Color3s(short red, short green, short blue) => GLPointers._glColor3s_fnptr(red, green, blue);
        
        public static void Color3sv(short* v) => GLPointers._glColor3sv_fnptr(v);
        
        public static void Color3ub(byte red, byte green, byte blue) => GLPointers._glColor3ub_fnptr(red, green, blue);
        
        public static void Color3ubv(byte* v) => GLPointers._glColor3ubv_fnptr(v);
        
        public static void Color3ui(uint red, uint green, uint blue) => GLPointers._glColor3ui_fnptr(red, green, blue);
        
        public static void Color3uiv(uint* v) => GLPointers._glColor3uiv_fnptr(v);
        
        public static void Color3us(ushort red, ushort green, ushort blue) => GLPointers._glColor3us_fnptr(red, green, blue);
        
        public static void Color3usv(ushort* v) => GLPointers._glColor3usv_fnptr(v);
        
        public static void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) => GLPointers._glColor4b_fnptr(red, green, blue, alpha);
        
        public static void Color4bv(sbyte* v) => GLPointers._glColor4bv_fnptr(v);
        
        public static void Color4d(double red, double green, double blue, double alpha) => GLPointers._glColor4d_fnptr(red, green, blue, alpha);
        
        public static void Color4dv(double* v) => GLPointers._glColor4dv_fnptr(v);
        
        public static void Color4f(float red, float green, float blue, float alpha) => GLPointers._glColor4f_fnptr(red, green, blue, alpha);
        
        public static void Color4fv(float* v) => GLPointers._glColor4fv_fnptr(v);
        
        public static void Color4i(int red, int green, int blue, int alpha) => GLPointers._glColor4i_fnptr(red, green, blue, alpha);
        
        public static void Color4iv(int* v) => GLPointers._glColor4iv_fnptr(v);
        
        public static void Color4s(short red, short green, short blue, short alpha) => GLPointers._glColor4s_fnptr(red, green, blue, alpha);
        
        public static void Color4sv(short* v) => GLPointers._glColor4sv_fnptr(v);
        
        public static void Color4ub(byte red, byte green, byte blue, byte alpha) => GLPointers._glColor4ub_fnptr(red, green, blue, alpha);
        
        public static void Color4ubv(byte* v) => GLPointers._glColor4ubv_fnptr(v);
        
        public static void Color4ui(uint red, uint green, uint blue, uint alpha) => GLPointers._glColor4ui_fnptr(red, green, blue, alpha);
        
        public static void Color4uiv(uint* v) => GLPointers._glColor4uiv_fnptr(v);
        
        public static void Color4us(ushort red, ushort green, ushort blue, ushort alpha) => GLPointers._glColor4us_fnptr(red, green, blue, alpha);
        
        public static void Color4usv(ushort* v) => GLPointers._glColor4usv_fnptr(v);
        
        public static void EdgeFlag(bool flag) => GLPointers._glEdgeFlag_fnptr((byte)(flag ? 1 : 0));
        
        public static void EdgeFlagv(bool* flag) => GLPointers._glEdgeFlagv_fnptr((byte*)flag);
        
        public static void End() => GLPointers._glEnd_fnptr();
        
        public static void Indexd(double c) => GLPointers._glIndexd_fnptr(c);
        
        public static void Indexdv(double* c) => GLPointers._glIndexdv_fnptr(c);
        
        public static void Indexf(float c) => GLPointers._glIndexf_fnptr(c);
        
        public static void Indexfv(float* c) => GLPointers._glIndexfv_fnptr(c);
        
        public static void Indexi(int c) => GLPointers._glIndexi_fnptr(c);
        
        public static void Indexiv(int* c) => GLPointers._glIndexiv_fnptr(c);
        
        public static void Indexs(short c) => GLPointers._glIndexs_fnptr(c);
        
        public static void Indexsv(short* c) => GLPointers._glIndexsv_fnptr(c);
        
        public static void Normal3b(sbyte nx, sbyte ny, sbyte nz) => GLPointers._glNormal3b_fnptr(nx, ny, nz);
        
        public static void Normal3bv(sbyte* v) => GLPointers._glNormal3bv_fnptr(v);
        
        public static void Normal3d(double nx, double ny, double nz) => GLPointers._glNormal3d_fnptr(nx, ny, nz);
        
        public static void Normal3dv(double* v) => GLPointers._glNormal3dv_fnptr(v);
        
        public static void Normal3f(float nx, float ny, float nz) => GLPointers._glNormal3f_fnptr(nx, ny, nz);
        
        public static void Normal3fv(float* v) => GLPointers._glNormal3fv_fnptr(v);
        
        public static void Normal3i(int nx, int ny, int nz) => GLPointers._glNormal3i_fnptr(nx, ny, nz);
        
        public static void Normal3iv(int* v) => GLPointers._glNormal3iv_fnptr(v);
        
        public static void Normal3s(short nx, short ny, short nz) => GLPointers._glNormal3s_fnptr(nx, ny, nz);
        
        public static void Normal3sv(short* v) => GLPointers._glNormal3sv_fnptr(v);
        
        public static void RasterPos2d(double x, double y) => GLPointers._glRasterPos2d_fnptr(x, y);
        
        public static void RasterPos2dv(double* v) => GLPointers._glRasterPos2dv_fnptr(v);
        
        public static void RasterPos2f(float x, float y) => GLPointers._glRasterPos2f_fnptr(x, y);
        
        public static void RasterPos2fv(float* v) => GLPointers._glRasterPos2fv_fnptr(v);
        
        public static void RasterPos2i(int x, int y) => GLPointers._glRasterPos2i_fnptr(x, y);
        
        public static void RasterPos2iv(int* v) => GLPointers._glRasterPos2iv_fnptr(v);
        
        public static void RasterPos2s(short x, short y) => GLPointers._glRasterPos2s_fnptr(x, y);
        
        public static void RasterPos2sv(short* v) => GLPointers._glRasterPos2sv_fnptr(v);
        
        public static void RasterPos3d(double x, double y, double z) => GLPointers._glRasterPos3d_fnptr(x, y, z);
        
        public static void RasterPos3dv(double* v) => GLPointers._glRasterPos3dv_fnptr(v);
        
        public static void RasterPos3f(float x, float y, float z) => GLPointers._glRasterPos3f_fnptr(x, y, z);
        
        public static void RasterPos3fv(float* v) => GLPointers._glRasterPos3fv_fnptr(v);
        
        public static void RasterPos3i(int x, int y, int z) => GLPointers._glRasterPos3i_fnptr(x, y, z);
        
        public static void RasterPos3iv(int* v) => GLPointers._glRasterPos3iv_fnptr(v);
        
        public static void RasterPos3s(short x, short y, short z) => GLPointers._glRasterPos3s_fnptr(x, y, z);
        
        public static void RasterPos3sv(short* v) => GLPointers._glRasterPos3sv_fnptr(v);
        
        public static void RasterPos4d(double x, double y, double z, double w) => GLPointers._glRasterPos4d_fnptr(x, y, z, w);
        
        public static void RasterPos4dv(double* v) => GLPointers._glRasterPos4dv_fnptr(v);
        
        public static void RasterPos4f(float x, float y, float z, float w) => GLPointers._glRasterPos4f_fnptr(x, y, z, w);
        
        public static void RasterPos4fv(float* v) => GLPointers._glRasterPos4fv_fnptr(v);
        
        public static void RasterPos4i(int x, int y, int z, int w) => GLPointers._glRasterPos4i_fnptr(x, y, z, w);
        
        public static void RasterPos4iv(int* v) => GLPointers._glRasterPos4iv_fnptr(v);
        
        public static void RasterPos4s(short x, short y, short z, short w) => GLPointers._glRasterPos4s_fnptr(x, y, z, w);
        
        public static void RasterPos4sv(short* v) => GLPointers._glRasterPos4sv_fnptr(v);
        
        public static void Rectd(double x1, double y1, double x2, double y2) => GLPointers._glRectd_fnptr(x1, y1, x2, y2);
        
        public static void Rectdv(double* v1, double* v2) => GLPointers._glRectdv_fnptr(v1, v2);
        
        public static void Rectf(float x1, float y1, float x2, float y2) => GLPointers._glRectf_fnptr(x1, y1, x2, y2);
        
        public static void Rectfv(float* v1, float* v2) => GLPointers._glRectfv_fnptr(v1, v2);
        
        public static void Recti(int x1, int y1, int x2, int y2) => GLPointers._glRecti_fnptr(x1, y1, x2, y2);
        
        public static void Rectiv(int* v1, int* v2) => GLPointers._glRectiv_fnptr(v1, v2);
        
        public static void Rects(short x1, short y1, short x2, short y2) => GLPointers._glRects_fnptr(x1, y1, x2, y2);
        
        public static void Rectsv(short* v1, short* v2) => GLPointers._glRectsv_fnptr(v1, v2);
        
        public static void TexCoord1d(double s) => GLPointers._glTexCoord1d_fnptr(s);
        
        public static void TexCoord1dv(double* v) => GLPointers._glTexCoord1dv_fnptr(v);
        
        public static void TexCoord1f(float s) => GLPointers._glTexCoord1f_fnptr(s);
        
        public static void TexCoord1fv(float* v) => GLPointers._glTexCoord1fv_fnptr(v);
        
        public static void TexCoord1i(int s) => GLPointers._glTexCoord1i_fnptr(s);
        
        public static void TexCoord1iv(int* v) => GLPointers._glTexCoord1iv_fnptr(v);
        
        public static void TexCoord1s(short s) => GLPointers._glTexCoord1s_fnptr(s);
        
        public static void TexCoord1sv(short* v) => GLPointers._glTexCoord1sv_fnptr(v);
        
        public static void TexCoord2d(double s, double t) => GLPointers._glTexCoord2d_fnptr(s, t);
        
        public static void TexCoord2dv(double* v) => GLPointers._glTexCoord2dv_fnptr(v);
        
        public static void TexCoord2f(float s, float t) => GLPointers._glTexCoord2f_fnptr(s, t);
        
        public static void TexCoord2fv(float* v) => GLPointers._glTexCoord2fv_fnptr(v);
        
        public static void TexCoord2i(int s, int t) => GLPointers._glTexCoord2i_fnptr(s, t);
        
        public static void TexCoord2iv(int* v) => GLPointers._glTexCoord2iv_fnptr(v);
        
        public static void TexCoord2s(short s, short t) => GLPointers._glTexCoord2s_fnptr(s, t);
        
        public static void TexCoord2sv(short* v) => GLPointers._glTexCoord2sv_fnptr(v);
        
        public static void TexCoord3d(double s, double t, double r) => GLPointers._glTexCoord3d_fnptr(s, t, r);
        
        public static void TexCoord3dv(double* v) => GLPointers._glTexCoord3dv_fnptr(v);
        
        public static void TexCoord3f(float s, float t, float r) => GLPointers._glTexCoord3f_fnptr(s, t, r);
        
        public static void TexCoord3fv(float* v) => GLPointers._glTexCoord3fv_fnptr(v);
        
        public static void TexCoord3i(int s, int t, int r) => GLPointers._glTexCoord3i_fnptr(s, t, r);
        
        public static void TexCoord3iv(int* v) => GLPointers._glTexCoord3iv_fnptr(v);
        
        public static void TexCoord3s(short s, short t, short r) => GLPointers._glTexCoord3s_fnptr(s, t, r);
        
        public static void TexCoord3sv(short* v) => GLPointers._glTexCoord3sv_fnptr(v);
        
        public static void TexCoord4d(double s, double t, double r, double q) => GLPointers._glTexCoord4d_fnptr(s, t, r, q);
        
        public static void TexCoord4dv(double* v) => GLPointers._glTexCoord4dv_fnptr(v);
        
        public static void TexCoord4f(float s, float t, float r, float q) => GLPointers._glTexCoord4f_fnptr(s, t, r, q);
        
        public static void TexCoord4fv(float* v) => GLPointers._glTexCoord4fv_fnptr(v);
        
        public static void TexCoord4i(int s, int t, int r, int q) => GLPointers._glTexCoord4i_fnptr(s, t, r, q);
        
        public static void TexCoord4iv(int* v) => GLPointers._glTexCoord4iv_fnptr(v);
        
        public static void TexCoord4s(short s, short t, short r, short q) => GLPointers._glTexCoord4s_fnptr(s, t, r, q);
        
        public static void TexCoord4sv(short* v) => GLPointers._glTexCoord4sv_fnptr(v);
        
        public static void Vertex2d(double x, double y) => GLPointers._glVertex2d_fnptr(x, y);
        
        public static void Vertex2dv(double* v) => GLPointers._glVertex2dv_fnptr(v);
        
        public static void Vertex2f(float x, float y) => GLPointers._glVertex2f_fnptr(x, y);
        
        public static void Vertex2fv(float* v) => GLPointers._glVertex2fv_fnptr(v);
        
        public static void Vertex2i(int x, int y) => GLPointers._glVertex2i_fnptr(x, y);
        
        public static void Vertex2iv(int* v) => GLPointers._glVertex2iv_fnptr(v);
        
        public static void Vertex2s(short x, short y) => GLPointers._glVertex2s_fnptr(x, y);
        
        public static void Vertex2sv(short* v) => GLPointers._glVertex2sv_fnptr(v);
        
        public static void Vertex3d(double x, double y, double z) => GLPointers._glVertex3d_fnptr(x, y, z);
        
        public static void Vertex3dv(double* v) => GLPointers._glVertex3dv_fnptr(v);
        
        public static void Vertex3f(float x, float y, float z) => GLPointers._glVertex3f_fnptr(x, y, z);
        
        public static void Vertex3fv(float* v) => GLPointers._glVertex3fv_fnptr(v);
        
        public static void Vertex3i(int x, int y, int z) => GLPointers._glVertex3i_fnptr(x, y, z);
        
        public static void Vertex3iv(int* v) => GLPointers._glVertex3iv_fnptr(v);
        
        public static void Vertex3s(short x, short y, short z) => GLPointers._glVertex3s_fnptr(x, y, z);
        
        public static void Vertex3sv(short* v) => GLPointers._glVertex3sv_fnptr(v);
        
        public static void Vertex4d(double x, double y, double z, double w) => GLPointers._glVertex4d_fnptr(x, y, z, w);
        
        public static void Vertex4dv(double* v) => GLPointers._glVertex4dv_fnptr(v);
        
        public static void Vertex4f(float x, float y, float z, float w) => GLPointers._glVertex4f_fnptr(x, y, z, w);
        
        public static void Vertex4fv(float* v) => GLPointers._glVertex4fv_fnptr(v);
        
        public static void Vertex4i(int x, int y, int z, int w) => GLPointers._glVertex4i_fnptr(x, y, z, w);
        
        public static void Vertex4iv(int* v) => GLPointers._glVertex4iv_fnptr(v);
        
        public static void Vertex4s(short x, short y, short z, short w) => GLPointers._glVertex4s_fnptr(x, y, z, w);
        
        public static void Vertex4sv(short* v) => GLPointers._glVertex4sv_fnptr(v);
        
        public static void ClipPlane(ClipPlaneName plane, double* equation) => GLPointers._glClipPlane_fnptr((uint)plane, equation);
        
        public static void ColorMaterial(TriangleFace face, ColorMaterialParameter mode) => GLPointers._glColorMaterial_fnptr((uint)face, (uint)mode);
        
        public static void Fogf(FogParameter pname, float param) => GLPointers._glFogf_fnptr((uint)pname, param);
        
        public static void Fogfv(FogParameter pname, float* parameters) => GLPointers._glFogfv_fnptr((uint)pname, parameters);
        
        public static void Fogi(FogParameter pname, int param) => GLPointers._glFogi_fnptr((uint)pname, param);
        
        public static void Fogiv(FogParameter pname, int* parameters) => GLPointers._glFogiv_fnptr((uint)pname, parameters);
        
        public static void Lightf(LightName light, LightParameter pname, float param) => GLPointers._glLightf_fnptr((uint)light, (uint)pname, param);
        
        public static void Lightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._glLightfv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void Lighti(LightName light, LightParameter pname, int param) => GLPointers._glLighti_fnptr((uint)light, (uint)pname, param);
        
        public static void Lightiv(LightName light, LightParameter pname, int* parameters) => GLPointers._glLightiv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void LightModelf(LightModelParameter pname, float param) => GLPointers._glLightModelf_fnptr((uint)pname, param);
        
        public static void LightModelfv(LightModelParameter pname, float* parameters) => GLPointers._glLightModelfv_fnptr((uint)pname, parameters);
        
        public static void LightModeli(LightModelParameter pname, int param) => GLPointers._glLightModeli_fnptr((uint)pname, param);
        
        public static void LightModeliv(LightModelParameter pname, int* parameters) => GLPointers._glLightModeliv_fnptr((uint)pname, parameters);
        
        public static void LineStipple(int factor, ushort pattern) => GLPointers._glLineStipple_fnptr(factor, pattern);
        
        public static void Materialf(TriangleFace face, MaterialParameter pname, float param) => GLPointers._glMaterialf_fnptr((uint)face, (uint)pname, param);
        
        public static void Materialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glMaterialfv_fnptr((uint)face, (uint)pname, parameters);
        
        public static void Materiali(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glMateriali_fnptr((uint)face, (uint)pname, param);
        
        public static void Materialiv(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glMaterialiv_fnptr((uint)face, (uint)pname, parameters);
        
        public static void PolygonStipple(byte* mask) => GLPointers._glPolygonStipple_fnptr(mask);
        
        public static void ShadeModel(ShadingModel mode) => GLPointers._glShadeModel_fnptr((uint)mode);
        
        public static void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => GLPointers._glTexEnvf_fnptr((uint)target, (uint)pname, param);
        
        public static void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glTexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvi_fnptr((uint)target, (uint)pname, param);
        
        public static void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexGend(TextureCoordName coord, TextureGenParameter pname, double param) => GLPointers._glTexGend_fnptr((uint)coord, (uint)pname, param);
        
        public static void TexGendv(TextureCoordName coord, TextureGenParameter pname, double* parameters) => GLPointers._glTexGendv_fnptr((uint)coord, (uint)pname, parameters);
        
        public static void TexGenf(TextureCoordName coord, TextureGenParameter pname, float param) => GLPointers._glTexGenf_fnptr((uint)coord, (uint)pname, param);
        
        public static void TexGenfv(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glTexGenfv_fnptr((uint)coord, (uint)pname, parameters);
        
        public static void TexGeni(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._glTexGeni_fnptr((uint)coord, (uint)pname, param);
        
        public static void TexGeniv(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glTexGeniv_fnptr((uint)coord, (uint)pname, parameters);
        
        public static void FeedbackBuffer(int size, FeedbackType type, float* buffer) => GLPointers._glFeedbackBuffer_fnptr(size, (uint)type, buffer);
        
        public static void SelectBuffer(int size, uint* buffer) => GLPointers._glSelectBuffer_fnptr(size, buffer);
        
        public static int RenderMode(RenderingMode mode) => GLPointers._glRenderMode_fnptr((uint)mode);
        
        public static void InitNames() => GLPointers._glInitNames_fnptr();
        
        public static void LoadName(uint name) => GLPointers._glLoadName_fnptr(name);
        
        public static void PassThrough(float token) => GLPointers._glPassThrough_fnptr(token);
        
        public static void PopName() => GLPointers._glPopName_fnptr();
        
        public static void PushName(uint name) => GLPointers._glPushName_fnptr(name);
        
        public static void ClearAccum(float red, float green, float blue, float alpha) => GLPointers._glClearAccum_fnptr(red, green, blue, alpha);
        
        public static void ClearIndex(float c) => GLPointers._glClearIndex_fnptr(c);
        
        public static void IndexMask(uint mask) => GLPointers._glIndexMask_fnptr(mask);
        
        public static void Accum(AccumOp op, float value) => GLPointers._glAccum_fnptr((uint)op, value);
        
        public static void PopAttrib() => GLPointers._glPopAttrib_fnptr();
        
        public static void PushAttrib(AttribMask mask) => GLPointers._glPushAttrib_fnptr((uint)mask);
        
        public static void Map1d(MapTarget target, double u1, double u2, int stride, int order, double* points) => GLPointers._glMap1d_fnptr((uint)target, u1, u2, stride, order, points);
        
        public static void Map1f(MapTarget target, float u1, float u2, int stride, int order, float* points) => GLPointers._glMap1f_fnptr((uint)target, u1, u2, stride, order, points);
        
        public static void Map2d(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points) => GLPointers._glMap2d_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        
        public static void Map2f(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points) => GLPointers._glMap2f_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        
        public static void MapGrid1d(int un, double u1, double u2) => GLPointers._glMapGrid1d_fnptr(un, u1, u2);
        
        public static void MapGrid1f(int un, float u1, float u2) => GLPointers._glMapGrid1f_fnptr(un, u1, u2);
        
        public static void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) => GLPointers._glMapGrid2d_fnptr(un, u1, u2, vn, v1, v2);
        
        public static void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) => GLPointers._glMapGrid2f_fnptr(un, u1, u2, vn, v1, v2);
        
        public static void EvalCoord1d(double u) => GLPointers._glEvalCoord1d_fnptr(u);
        
        public static void EvalCoord1dv(double* u) => GLPointers._glEvalCoord1dv_fnptr(u);
        
        public static void EvalCoord1f(float u) => GLPointers._glEvalCoord1f_fnptr(u);
        
        public static void EvalCoord1fv(float* u) => GLPointers._glEvalCoord1fv_fnptr(u);
        
        public static void EvalCoord2d(double u, double v) => GLPointers._glEvalCoord2d_fnptr(u, v);
        
        public static void EvalCoord2dv(double* u) => GLPointers._glEvalCoord2dv_fnptr(u);
        
        public static void EvalCoord2f(float u, float v) => GLPointers._glEvalCoord2f_fnptr(u, v);
        
        public static void EvalCoord2fv(float* u) => GLPointers._glEvalCoord2fv_fnptr(u);
        
        public static void EvalMesh1(MeshMode1 mode, int i1, int i2) => GLPointers._glEvalMesh1_fnptr((uint)mode, i1, i2);
        
        public static void EvalPoint1(int i) => GLPointers._glEvalPoint1_fnptr(i);
        
        public static void EvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2) => GLPointers._glEvalMesh2_fnptr((uint)mode, i1, i2, j1, j2);
        
        public static void EvalPoint2(int i, int j) => GLPointers._glEvalPoint2_fnptr(i, j);
        
        public static void AlphaFunc(AlphaFunction func, float reference) => GLPointers._glAlphaFunc_fnptr((uint)func, reference);
        
        public static void PixelZoom(float xfactor, float yfactor) => GLPointers._glPixelZoom_fnptr(xfactor, yfactor);
        
        public static void PixelTransferf(PixelTransferParameter pname, float param) => GLPointers._glPixelTransferf_fnptr((uint)pname, param);
        
        public static void PixelTransferi(PixelTransferParameter pname, int param) => GLPointers._glPixelTransferi_fnptr((uint)pname, param);
        
        public static void PixelMapfv(PixelMap map, int mapsize, float* values) => GLPointers._glPixelMapfv_fnptr((uint)map, mapsize, values);
        
        public static void PixelMapuiv(PixelMap map, int mapsize, uint* values) => GLPointers._glPixelMapuiv_fnptr((uint)map, mapsize, values);
        
        public static void PixelMapusv(PixelMap map, int mapsize, ushort* values) => GLPointers._glPixelMapusv_fnptr((uint)map, mapsize, values);
        
        public static void CopyPixels(int x, int y, int width, int height, PixelCopyType type) => GLPointers._glCopyPixels_fnptr(x, y, width, height, (uint)type);
        
        public static void DrawPixels(int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glDrawPixels_fnptr(width, height, (uint)format, (uint)type, pixels);
        
        public static void GetClipPlane(ClipPlaneName plane, double* equation) => GLPointers._glGetClipPlane_fnptr((uint)plane, equation);
        
        public static void GetLightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._glGetLightfv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void GetLightiv(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightiv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void GetMapdv(MapTarget target, GetMapQuery query, double* v) => GLPointers._glGetMapdv_fnptr((uint)target, (uint)query, v);
        
        public static void GetMapfv(MapTarget target, GetMapQuery query, float* v) => GLPointers._glGetMapfv_fnptr((uint)target, (uint)query, v);
        
        public static void GetMapiv(MapTarget target, GetMapQuery query, int* v) => GLPointers._glGetMapiv_fnptr((uint)target, (uint)query, v);
        
        public static void GetMaterialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glGetMaterialfv_fnptr((uint)face, (uint)pname, parameters);
        
        public static void GetMaterialiv(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glGetMaterialiv_fnptr((uint)face, (uint)pname, parameters);
        
        public static void GetPixelMapfv(PixelMap map, float* values) => GLPointers._glGetPixelMapfv_fnptr((uint)map, values);
        
        public static void GetPixelMapuiv(PixelMap map, uint* values) => GLPointers._glGetPixelMapuiv_fnptr((uint)map, values);
        
        public static void GetPixelMapusv(PixelMap map, ushort* values) => GLPointers._glGetPixelMapusv_fnptr((uint)map, values);
        
        public static void GetPolygonStipple(byte* mask) => GLPointers._glGetPolygonStipple_fnptr(mask);
        
        public static void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glGetTexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexGendv(TextureCoordName coord, TextureGenParameter pname, double* parameters) => GLPointers._glGetTexGendv_fnptr((uint)coord, (uint)pname, parameters);
        
        public static void GetTexGenfv(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glGetTexGenfv_fnptr((uint)coord, (uint)pname, parameters);
        
        public static void GetTexGeniv(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glGetTexGeniv_fnptr((uint)coord, (uint)pname, parameters);
        
        public static bool IsList(int list) => GLPointers._glIsList_fnptr(list) != 0;
        
        public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glFrustum_fnptr(left, right, bottom, top, zNear, zFar);
        
        public static void LoadIdentity() => GLPointers._glLoadIdentity_fnptr();
        
        public static void LoadMatrixf(float* m) => GLPointers._glLoadMatrixf_fnptr(m);
        
        public static void LoadMatrixd(double* m) => GLPointers._glLoadMatrixd_fnptr(m);
        
        public static void MatrixMode(MatrixMode mode) => GLPointers._glMatrixMode_fnptr((uint)mode);
        
        public static void MultMatrixf(float* m) => GLPointers._glMultMatrixf_fnptr(m);
        
        public static void MultMatrixd(double* m) => GLPointers._glMultMatrixd_fnptr(m);
        
        public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glOrtho_fnptr(left, right, bottom, top, zNear, zFar);
        
        public static void PopMatrix() => GLPointers._glPopMatrix_fnptr();
        
        public static void PushMatrix() => GLPointers._glPushMatrix_fnptr();
        
        public static void Rotated(double angle, double x, double y, double z) => GLPointers._glRotated_fnptr(angle, x, y, z);
        
        public static void Rotatef(float angle, float x, float y, float z) => GLPointers._glRotatef_fnptr(angle, x, y, z);
        
        public static void Scaled(double x, double y, double z) => GLPointers._glScaled_fnptr(x, y, z);
        
        public static void Scalef(float x, float y, float z) => GLPointers._glScalef_fnptr(x, y, z);
        
        public static void Translated(double x, double y, double z) => GLPointers._glTranslated_fnptr(x, y, z);
        
        public static void Translatef(float x, float y, float z) => GLPointers._glTranslatef_fnptr(x, y, z);
        
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._glDrawArrays_fnptr((uint)mode, first, count);
        
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._glDrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
        
        public static void PolygonOffset(float factor, float units) => GLPointers._glPolygonOffset_fnptr(factor, units);
        
        public static void CopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border) => GLPointers._glCopyTexImage1D_fnptr((uint)target, level, (uint)internalformat, x, y, width, border);
        
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyTexImage2D_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
        
        public static void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width) => GLPointers._glCopyTexSubImage1D_fnptr((uint)target, level, xoffset, x, y, width);
        
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
        
        public static void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage1D_fnptr((uint)target, level, xoffset, width, (uint)format, (uint)type, pixels);
        
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        public static void BindTexture(TextureTarget target, int texture) => GLPointers._glBindTexture_fnptr((uint)target, texture);
        
        public static void DeleteTextures(int n, int* textures) => GLPointers._glDeleteTextures_fnptr(n, textures);
        
        public static void GenTextures(int n, int* textures) => GLPointers._glGenTextures_fnptr(n, textures);
        
        public static bool IsTexture(int texture) => GLPointers._glIsTexture_fnptr(texture) != 0;
        
        public static void ArrayElement(int i) => GLPointers._glArrayElement_fnptr(i);
        
        public static void ColorPointer(int size, ColorPointerType type, int stride, void* pointer) => GLPointers._glColorPointer_fnptr(size, (uint)type, stride, pointer);
        
        public static void DisableClientState(EnableCap array) => GLPointers._glDisableClientState_fnptr((uint)array);
        
        public static void EdgeFlagPointer(int stride, void* pointer) => GLPointers._glEdgeFlagPointer_fnptr(stride, pointer);
        
        public static void EnableClientState(EnableCap array) => GLPointers._glEnableClientState_fnptr((uint)array);
        
        public static void IndexPointer(IndexPointerType type, int stride, void* pointer) => GLPointers._glIndexPointer_fnptr((uint)type, stride, pointer);
        
        public static void InterleavedArrays(InterleavedArrayFormat format, int stride, void* pointer) => GLPointers._glInterleavedArrays_fnptr((uint)format, stride, pointer);
        
        public static void NormalPointer(NormalPointerType type, int stride, void* pointer) => GLPointers._glNormalPointer_fnptr((uint)type, stride, pointer);
        
        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer) => GLPointers._glTexCoordPointer_fnptr(size, (uint)type, stride, pointer);
        
        public static void VertexPointer(int size, VertexPointerType type, int stride, void* pointer) => GLPointers._glVertexPointer_fnptr(size, (uint)type, stride, pointer);
        
        public static bool AreTexturesResident(int n, int* textures, bool* residences) => GLPointers._glAreTexturesResident_fnptr(n, textures, (byte*)residences) != 0;
        
        public static void PrioritizeTextures(int n, int* textures, float* priorities) => GLPointers._glPrioritizeTextures_fnptr(n, textures, priorities);
        
        public static void Indexub(byte c) => GLPointers._glIndexub_fnptr(c);
        
        public static void Indexubv(byte* c) => GLPointers._glIndexubv_fnptr(c);
        
        public static void PopClientAttrib() => GLPointers._glPopClientAttrib_fnptr();
        
        public static void PushClientAttrib(ClientAttribMask mask) => GLPointers._glPushClientAttrib_fnptr((uint)mask);
        
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => GLPointers._glDrawRangeElements_fnptr((uint)mode, start, end, count, (uint)type, indices);
        
        public static void TexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage3D_fnptr((uint)target, level, (int)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
        
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
        
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        public static void ActiveTexture(TextureUnit texture) => GLPointers._glActiveTexture_fnptr((uint)texture);
        
        public static void SampleCoverage(float value, bool invert) => GLPointers._glSampleCoverage_fnptr(value, (byte)(invert ? 1 : 0));
        
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage3D_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
        
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage2D_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
        
        public static void CompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage1D_fnptr((uint)target, level, (uint)internalformat, width, border, imageSize, data);
        
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
        
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage1D_fnptr((uint)target, level, xoffset, width, (uint)format, imageSize, data);
        
        public static void GetCompressedTexImage(TextureTarget target, int level, void* img) => GLPointers._glGetCompressedTexImage_fnptr((uint)target, level, img);
        
        public static void ClientActiveTexture(TextureUnit texture) => GLPointers._glClientActiveTexture_fnptr((uint)texture);
        
        public static void MultiTexCoord1d(TextureUnit target, double s) => GLPointers._glMultiTexCoord1d_fnptr((uint)target, s);
        
        public static void MultiTexCoord1dv(TextureUnit target, double* v) => GLPointers._glMultiTexCoord1dv_fnptr((uint)target, v);
        
        public static void MultiTexCoord1f(TextureUnit target, float s) => GLPointers._glMultiTexCoord1f_fnptr((uint)target, s);
        
        public static void MultiTexCoord1fv(TextureUnit target, float* v) => GLPointers._glMultiTexCoord1fv_fnptr((uint)target, v);
        
        public static void MultiTexCoord1i(TextureUnit target, int s) => GLPointers._glMultiTexCoord1i_fnptr((uint)target, s);
        
        public static void MultiTexCoord1iv(TextureUnit target, int* v) => GLPointers._glMultiTexCoord1iv_fnptr((uint)target, v);
        
        public static void MultiTexCoord1s(TextureUnit target, short s) => GLPointers._glMultiTexCoord1s_fnptr((uint)target, s);
        
        public static void MultiTexCoord1sv(TextureUnit target, short* v) => GLPointers._glMultiTexCoord1sv_fnptr((uint)target, v);
        
        public static void MultiTexCoord2d(TextureUnit target, double s, double t) => GLPointers._glMultiTexCoord2d_fnptr((uint)target, s, t);
        
        public static void MultiTexCoord2dv(TextureUnit target, double* v) => GLPointers._glMultiTexCoord2dv_fnptr((uint)target, v);
        
        public static void MultiTexCoord2f(TextureUnit target, float s, float t) => GLPointers._glMultiTexCoord2f_fnptr((uint)target, s, t);
        
        public static void MultiTexCoord2fv(TextureUnit target, float* v) => GLPointers._glMultiTexCoord2fv_fnptr((uint)target, v);
        
        public static void MultiTexCoord2i(TextureUnit target, int s, int t) => GLPointers._glMultiTexCoord2i_fnptr((uint)target, s, t);
        
        public static void MultiTexCoord2iv(TextureUnit target, int* v) => GLPointers._glMultiTexCoord2iv_fnptr((uint)target, v);
        
        public static void MultiTexCoord2s(TextureUnit target, short s, short t) => GLPointers._glMultiTexCoord2s_fnptr((uint)target, s, t);
        
        public static void MultiTexCoord2sv(TextureUnit target, short* v) => GLPointers._glMultiTexCoord2sv_fnptr((uint)target, v);
        
        public static void MultiTexCoord3d(TextureUnit target, double s, double t, double r) => GLPointers._glMultiTexCoord3d_fnptr((uint)target, s, t, r);
        
        public static void MultiTexCoord3dv(TextureUnit target, double* v) => GLPointers._glMultiTexCoord3dv_fnptr((uint)target, v);
        
        public static void MultiTexCoord3f(TextureUnit target, float s, float t, float r) => GLPointers._glMultiTexCoord3f_fnptr((uint)target, s, t, r);
        
        public static void MultiTexCoord3fv(TextureUnit target, float* v) => GLPointers._glMultiTexCoord3fv_fnptr((uint)target, v);
        
        public static void MultiTexCoord3i(TextureUnit target, int s, int t, int r) => GLPointers._glMultiTexCoord3i_fnptr((uint)target, s, t, r);
        
        public static void MultiTexCoord3iv(TextureUnit target, int* v) => GLPointers._glMultiTexCoord3iv_fnptr((uint)target, v);
        
        public static void MultiTexCoord3s(TextureUnit target, short s, short t, short r) => GLPointers._glMultiTexCoord3s_fnptr((uint)target, s, t, r);
        
        public static void MultiTexCoord3sv(TextureUnit target, short* v) => GLPointers._glMultiTexCoord3sv_fnptr((uint)target, v);
        
        public static void MultiTexCoord4d(TextureUnit target, double s, double t, double r, double q) => GLPointers._glMultiTexCoord4d_fnptr((uint)target, s, t, r, q);
        
        public static void MultiTexCoord4dv(TextureUnit target, double* v) => GLPointers._glMultiTexCoord4dv_fnptr((uint)target, v);
        
        public static void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => GLPointers._glMultiTexCoord4f_fnptr((uint)target, s, t, r, q);
        
        public static void MultiTexCoord4fv(TextureUnit target, float* v) => GLPointers._glMultiTexCoord4fv_fnptr((uint)target, v);
        
        public static void MultiTexCoord4i(TextureUnit target, int s, int t, int r, int q) => GLPointers._glMultiTexCoord4i_fnptr((uint)target, s, t, r, q);
        
        public static void MultiTexCoord4iv(TextureUnit target, int* v) => GLPointers._glMultiTexCoord4iv_fnptr((uint)target, v);
        
        public static void MultiTexCoord4s(TextureUnit target, short s, short t, short r, short q) => GLPointers._glMultiTexCoord4s_fnptr((uint)target, s, t, r, q);
        
        public static void MultiTexCoord4sv(TextureUnit target, short* v) => GLPointers._glMultiTexCoord4sv_fnptr((uint)target, v);
        
        public static void LoadTransposeMatrixf(float* m) => GLPointers._glLoadTransposeMatrixf_fnptr(m);
        
        public static void LoadTransposeMatrixd(double* m) => GLPointers._glLoadTransposeMatrixd_fnptr(m);
        
        public static void MultTransposeMatrixf(float* m) => GLPointers._glMultTransposeMatrixf_fnptr(m);
        
        public static void MultTransposeMatrixd(double* m) => GLPointers._glMultTransposeMatrixd_fnptr(m);
        
        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => GLPointers._glBlendFuncSeparate_fnptr((uint)sfactorRGB, (uint)dfactorRGB, (uint)sfactorAlpha, (uint)dfactorAlpha);
        
        public static void MultiDrawArrays(PrimitiveType mode, int* first, int* count, int drawcount) => GLPointers._glMultiDrawArrays_fnptr((uint)mode, first, count, drawcount);
        
        public static void MultiDrawElements(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount) => GLPointers._glMultiDrawElements_fnptr((uint)mode, count, (uint)type, indices, drawcount);
        
        public static void PointParameterf(PointParameterNameARB pname, float param) => GLPointers._glPointParameterf_fnptr((uint)pname, param);
        
        public static void PointParameterfv(PointParameterNameARB pname, float* parameters) => GLPointers._glPointParameterfv_fnptr((uint)pname, parameters);
        
        public static void PointParameteri(PointParameterNameARB pname, int param) => GLPointers._glPointParameteri_fnptr((uint)pname, param);
        
        public static void PointParameteriv(PointParameterNameARB pname, int* parameters) => GLPointers._glPointParameteriv_fnptr((uint)pname, parameters);
        
        public static void FogCoordf(float coord) => GLPointers._glFogCoordf_fnptr(coord);
        
        public static void FogCoordfv(float* coord) => GLPointers._glFogCoordfv_fnptr(coord);
        
        public static void FogCoordd(double coord) => GLPointers._glFogCoordd_fnptr(coord);
        
        public static void FogCoorddv(double* coord) => GLPointers._glFogCoorddv_fnptr(coord);
        
        public static void FogCoordPointer(FogPointerTypeEXT type, int stride, void* pointer) => GLPointers._glFogCoordPointer_fnptr((uint)type, stride, pointer);
        
        public static void SecondaryColor3b(sbyte red, sbyte green, sbyte blue) => GLPointers._glSecondaryColor3b_fnptr(red, green, blue);
        
        public static void SecondaryColor3bv(sbyte* v) => GLPointers._glSecondaryColor3bv_fnptr(v);
        
        public static void SecondaryColor3d(double red, double green, double blue) => GLPointers._glSecondaryColor3d_fnptr(red, green, blue);
        
        public static void SecondaryColor3dv(double* v) => GLPointers._glSecondaryColor3dv_fnptr(v);
        
        public static void SecondaryColor3f(float red, float green, float blue) => GLPointers._glSecondaryColor3f_fnptr(red, green, blue);
        
        public static void SecondaryColor3fv(float* v) => GLPointers._glSecondaryColor3fv_fnptr(v);
        
        public static void SecondaryColor3i(int red, int green, int blue) => GLPointers._glSecondaryColor3i_fnptr(red, green, blue);
        
        public static void SecondaryColor3iv(int* v) => GLPointers._glSecondaryColor3iv_fnptr(v);
        
        public static void SecondaryColor3s(short red, short green, short blue) => GLPointers._glSecondaryColor3s_fnptr(red, green, blue);
        
        public static void SecondaryColor3sv(short* v) => GLPointers._glSecondaryColor3sv_fnptr(v);
        
        public static void SecondaryColor3ub(byte red, byte green, byte blue) => GLPointers._glSecondaryColor3ub_fnptr(red, green, blue);
        
        public static void SecondaryColor3ubv(byte* v) => GLPointers._glSecondaryColor3ubv_fnptr(v);
        
        public static void SecondaryColor3ui(uint red, uint green, uint blue) => GLPointers._glSecondaryColor3ui_fnptr(red, green, blue);
        
        public static void SecondaryColor3uiv(uint* v) => GLPointers._glSecondaryColor3uiv_fnptr(v);
        
        public static void SecondaryColor3us(ushort red, ushort green, ushort blue) => GLPointers._glSecondaryColor3us_fnptr(red, green, blue);
        
        public static void SecondaryColor3usv(ushort* v) => GLPointers._glSecondaryColor3usv_fnptr(v);
        
        public static void SecondaryColorPointer(int size, ColorPointerType type, int stride, void* pointer) => GLPointers._glSecondaryColorPointer_fnptr(size, (uint)type, stride, pointer);
        
        public static void WindowPos2d(double x, double y) => GLPointers._glWindowPos2d_fnptr(x, y);
        
        public static void WindowPos2dv(double* v) => GLPointers._glWindowPos2dv_fnptr(v);
        
        public static void WindowPos2f(float x, float y) => GLPointers._glWindowPos2f_fnptr(x, y);
        
        public static void WindowPos2fv(float* v) => GLPointers._glWindowPos2fv_fnptr(v);
        
        public static void WindowPos2i(int x, int y) => GLPointers._glWindowPos2i_fnptr(x, y);
        
        public static void WindowPos2iv(int* v) => GLPointers._glWindowPos2iv_fnptr(v);
        
        public static void WindowPos2s(short x, short y) => GLPointers._glWindowPos2s_fnptr(x, y);
        
        public static void WindowPos2sv(short* v) => GLPointers._glWindowPos2sv_fnptr(v);
        
        public static void WindowPos3d(double x, double y, double z) => GLPointers._glWindowPos3d_fnptr(x, y, z);
        
        public static void WindowPos3dv(double* v) => GLPointers._glWindowPos3dv_fnptr(v);
        
        public static void WindowPos3f(float x, float y, float z) => GLPointers._glWindowPos3f_fnptr(x, y, z);
        
        public static void WindowPos3fv(float* v) => GLPointers._glWindowPos3fv_fnptr(v);
        
        public static void WindowPos3i(int x, int y, int z) => GLPointers._glWindowPos3i_fnptr(x, y, z);
        
        public static void WindowPos3iv(int* v) => GLPointers._glWindowPos3iv_fnptr(v);
        
        public static void WindowPos3s(short x, short y, short z) => GLPointers._glWindowPos3s_fnptr(x, y, z);
        
        public static void WindowPos3sv(short* v) => GLPointers._glWindowPos3sv_fnptr(v);
        
        public static void BlendColor(float red, float green, float blue, float alpha) => GLPointers._glBlendColor_fnptr(red, green, blue, alpha);
        
        public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquation_fnptr((uint)mode);
        
        public static void GenQueries(int n, int* ids) => GLPointers._glGenQueries_fnptr(n, ids);
        
        public static void DeleteQueries(int n, int* ids) => GLPointers._glDeleteQueries_fnptr(n, ids);
        
        public static bool IsQuery(int id) => GLPointers._glIsQuery_fnptr(id) != 0;
        
        public static void BeginQuery(QueryTarget target, int id) => GLPointers._glBeginQuery_fnptr((uint)target, id);
        
        public static void EndQuery(QueryTarget target) => GLPointers._glEndQuery_fnptr((uint)target);
        
        public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetQueryObjectiv(int id, QueryObjectParameterName pname, int* parameters) => GLPointers._glGetQueryObjectiv_fnptr(id, (uint)pname, parameters);
        
        public static void GetQueryObjectuiv(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuiv_fnptr(id, (uint)pname, parameters);
        
        public static void BindBuffer(BufferTargetARB target, int buffer) => GLPointers._glBindBuffer_fnptr((uint)target, buffer);
        
        public static void DeleteBuffers(int n, int* buffers) => GLPointers._glDeleteBuffers_fnptr(n, buffers);
        
        public static void GenBuffers(int n, int* buffers) => GLPointers._glGenBuffers_fnptr(n, buffers);
        
        public static bool IsBuffer(int buffer) => GLPointers._glIsBuffer_fnptr(buffer) != 0;
        
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._glBufferData_fnptr((uint)target, size, data, (uint)usage);
        
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glBufferSubData_fnptr((uint)target, offset, size, data);
        
        public static void GetBufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glGetBufferSubData_fnptr((uint)target, offset, size, data);
        
        public static void* MapBuffer(BufferTargetARB target, BufferAccessARB access) => GLPointers._glMapBuffer_fnptr((uint)target, (uint)access);
        
        public static bool UnmapBuffer(BufferTargetARB target) => GLPointers._glUnmapBuffer_fnptr((uint)target) != 0;
        
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._glGetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointerv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparate_fnptr((uint)modeRGB, (uint)modeAlpha);
        
        public static void DrawBuffers(int n, DrawBufferMode* bufs) => GLPointers._glDrawBuffers_fnptr(n, (uint*)bufs);
        
        public static void StencilOpSeparate(TriangleFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => GLPointers._glStencilOpSeparate_fnptr((uint)face, (uint)sfail, (uint)dpfail, (uint)dppass);
        
        public static void StencilFuncSeparate(TriangleFace face, StencilFunction func, int reference, uint mask) => GLPointers._glStencilFuncSeparate_fnptr((uint)face, (uint)func, reference, mask);
        
        public static void StencilMaskSeparate(TriangleFace face, uint mask) => GLPointers._glStencilMaskSeparate_fnptr((uint)face, mask);
        
        public static void AttachShader(int program, int shader) => GLPointers._glAttachShader_fnptr(program, shader);
        
        public static void BindAttribLocation(int program, uint index, byte* name) => GLPointers._glBindAttribLocation_fnptr(program, index, name);
        
        public static void CompileShader(int shader) => GLPointers._glCompileShader_fnptr(shader);
        
        public static int CreateProgram() => GLPointers._glCreateProgram_fnptr();
        
        public static int CreateShader(ShaderType type) => GLPointers._glCreateShader_fnptr((uint)type);
        
        public static void DeleteProgram(int program) => GLPointers._glDeleteProgram_fnptr(program);
        
        public static void DeleteShader(int shader) => GLPointers._glDeleteShader_fnptr(shader);
        
        public static void DetachShader(int program, int shader) => GLPointers._glDetachShader_fnptr(program, shader);
        
        public static void DisableVertexAttribArray(uint index) => GLPointers._glDisableVertexAttribArray_fnptr(index);
        
        public static void EnableVertexAttribArray(uint index) => GLPointers._glEnableVertexAttribArray_fnptr(index);
        
        public static void GetActiveAttrib(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetActiveAttrib_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        public static void GetActiveUniform(int program, uint index, int bufSize, int* length, int* size, UniformType* type, byte* name) => GLPointers._glGetActiveUniform_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        public static void GetAttachedShaders(int program, int maxCount, int* count, int* shaders) => GLPointers._glGetAttachedShaders_fnptr(program, maxCount, count, shaders);
        
        public static int GetAttribLocation(int program, byte* name) => GLPointers._glGetAttribLocation_fnptr(program, name);
        
        public static void GetProgramiv(int program, ProgramPropertyARB pname, int* parameters) => GLPointers._glGetProgramiv_fnptr(program, (uint)pname, parameters);
        
        public static void GetProgramInfoLog(int program, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramInfoLog_fnptr(program, bufSize, length, infoLog);
        
        public static void GetShaderiv(int shader, ShaderParameterName pname, int* parameters) => GLPointers._glGetShaderiv_fnptr(shader, (uint)pname, parameters);
        
        public static void GetShaderInfoLog(int shader, int bufSize, int* length, byte* infoLog) => GLPointers._glGetShaderInfoLog_fnptr(shader, bufSize, length, infoLog);
        
        public static void GetShaderSource(int shader, int bufSize, int* length, byte* source) => GLPointers._glGetShaderSource_fnptr(shader, bufSize, length, source);
        
        public static int GetUniformLocation(int program, byte* name) => GLPointers._glGetUniformLocation_fnptr(program, name);
        
        public static void GetUniformfv(int program, int location, float* parameters) => GLPointers._glGetUniformfv_fnptr(program, location, parameters);
        
        public static void GetUniformiv(int program, int location, int* parameters) => GLPointers._glGetUniformiv_fnptr(program, location, parameters);
        
        public static void GetVertexAttribdv(uint index, VertexAttribPropertyARB pname, double* parameters) => GLPointers._glGetVertexAttribdv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* parameters) => GLPointers._glGetVertexAttribfv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* parameters) => GLPointers._glGetVertexAttribiv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void** pointer) => GLPointers._glGetVertexAttribPointerv_fnptr(index, (uint)pname, pointer);
        
        public static bool IsProgram(int program) => GLPointers._glIsProgram_fnptr(program) != 0;
        
        public static bool IsShader(int shader) => GLPointers._glIsShader_fnptr(shader) != 0;
        
        public static void LinkProgram(int program) => GLPointers._glLinkProgram_fnptr(program);
        
        public static void ShaderSource(int shader, int count, byte** str, int* length) => GLPointers._glShaderSource_fnptr(shader, count, str, length);
        
        public static void UseProgram(int program) => GLPointers._glUseProgram_fnptr(program);
        
        public static void Uniform1f(int location, float v0) => GLPointers._glUniform1f_fnptr(location, v0);
        
        public static void Uniform2f(int location, float v0, float v1) => GLPointers._glUniform2f_fnptr(location, v0, v1);
        
        public static void Uniform3f(int location, float v0, float v1, float v2) => GLPointers._glUniform3f_fnptr(location, v0, v1, v2);
        
        public static void Uniform4f(int location, float v0, float v1, float v2, float v3) => GLPointers._glUniform4f_fnptr(location, v0, v1, v2, v3);
        
        public static void Uniform1i(int location, int v0) => GLPointers._glUniform1i_fnptr(location, v0);
        
        public static void Uniform2i(int location, int v0, int v1) => GLPointers._glUniform2i_fnptr(location, v0, v1);
        
        public static void Uniform3i(int location, int v0, int v1, int v2) => GLPointers._glUniform3i_fnptr(location, v0, v1, v2);
        
        public static void Uniform4i(int location, int v0, int v1, int v2, int v3) => GLPointers._glUniform4i_fnptr(location, v0, v1, v2, v3);
        
        public static void Uniform1fv(int location, int count, float* value) => GLPointers._glUniform1fv_fnptr(location, count, value);
        
        public static void Uniform2fv(int location, int count, float* value) => GLPointers._glUniform2fv_fnptr(location, count, value);
        
        public static void Uniform3fv(int location, int count, float* value) => GLPointers._glUniform3fv_fnptr(location, count, value);
        
        public static void Uniform4fv(int location, int count, float* value) => GLPointers._glUniform4fv_fnptr(location, count, value);
        
        public static void Uniform1iv(int location, int count, int* value) => GLPointers._glUniform1iv_fnptr(location, count, value);
        
        public static void Uniform2iv(int location, int count, int* value) => GLPointers._glUniform2iv_fnptr(location, count, value);
        
        public static void Uniform3iv(int location, int count, int* value) => GLPointers._glUniform3iv_fnptr(location, count, value);
        
        public static void Uniform4iv(int location, int count, int* value) => GLPointers._glUniform4iv_fnptr(location, count, value);
        
        public static void UniformMatrix2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ValidateProgram(int program) => GLPointers._glValidateProgram_fnptr(program);
        
        public static void VertexAttrib1d(uint index, double x) => GLPointers._glVertexAttrib1d_fnptr(index, x);
        
        public static void VertexAttrib1dv(uint index, double* v) => GLPointers._glVertexAttrib1dv_fnptr(index, v);
        
        public static void VertexAttrib1f(uint index, float x) => GLPointers._glVertexAttrib1f_fnptr(index, x);
        
        public static void VertexAttrib1fv(uint index, float* v) => GLPointers._glVertexAttrib1fv_fnptr(index, v);
        
        public static void VertexAttrib1s(uint index, short x) => GLPointers._glVertexAttrib1s_fnptr(index, x);
        
        public static void VertexAttrib1sv(uint index, short* v) => GLPointers._glVertexAttrib1sv_fnptr(index, v);
        
        public static void VertexAttrib2d(uint index, double x, double y) => GLPointers._glVertexAttrib2d_fnptr(index, x, y);
        
        public static void VertexAttrib2dv(uint index, double* v) => GLPointers._glVertexAttrib2dv_fnptr(index, v);
        
        public static void VertexAttrib2f(uint index, float x, float y) => GLPointers._glVertexAttrib2f_fnptr(index, x, y);
        
        public static void VertexAttrib2fv(uint index, float* v) => GLPointers._glVertexAttrib2fv_fnptr(index, v);
        
        public static void VertexAttrib2s(uint index, short x, short y) => GLPointers._glVertexAttrib2s_fnptr(index, x, y);
        
        public static void VertexAttrib2sv(uint index, short* v) => GLPointers._glVertexAttrib2sv_fnptr(index, v);
        
        public static void VertexAttrib3d(uint index, double x, double y, double z) => GLPointers._glVertexAttrib3d_fnptr(index, x, y, z);
        
        public static void VertexAttrib3dv(uint index, double* v) => GLPointers._glVertexAttrib3dv_fnptr(index, v);
        
        public static void VertexAttrib3f(uint index, float x, float y, float z) => GLPointers._glVertexAttrib3f_fnptr(index, x, y, z);
        
        public static void VertexAttrib3fv(uint index, float* v) => GLPointers._glVertexAttrib3fv_fnptr(index, v);
        
        public static void VertexAttrib3s(uint index, short x, short y, short z) => GLPointers._glVertexAttrib3s_fnptr(index, x, y, z);
        
        public static void VertexAttrib3sv(uint index, short* v) => GLPointers._glVertexAttrib3sv_fnptr(index, v);
        
        public static void VertexAttrib4Nbv(uint index, sbyte* v) => GLPointers._glVertexAttrib4Nbv_fnptr(index, v);
        
        public static void VertexAttrib4Niv(uint index, int* v) => GLPointers._glVertexAttrib4Niv_fnptr(index, v);
        
        public static void VertexAttrib4Nsv(uint index, short* v) => GLPointers._glVertexAttrib4Nsv_fnptr(index, v);
        
        public static void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) => GLPointers._glVertexAttrib4Nub_fnptr(index, x, y, z, w);
        
        public static void VertexAttrib4Nubv(uint index, byte* v) => GLPointers._glVertexAttrib4Nubv_fnptr(index, v);
        
        public static void VertexAttrib4Nuiv(uint index, uint* v) => GLPointers._glVertexAttrib4Nuiv_fnptr(index, v);
        
        public static void VertexAttrib4Nusv(uint index, ushort* v) => GLPointers._glVertexAttrib4Nusv_fnptr(index, v);
        
        public static void VertexAttrib4bv(uint index, sbyte* v) => GLPointers._glVertexAttrib4bv_fnptr(index, v);
        
        public static void VertexAttrib4d(uint index, double x, double y, double z, double w) => GLPointers._glVertexAttrib4d_fnptr(index, x, y, z, w);
        
        public static void VertexAttrib4dv(uint index, double* v) => GLPointers._glVertexAttrib4dv_fnptr(index, v);
        
        public static void VertexAttrib4f(uint index, float x, float y, float z, float w) => GLPointers._glVertexAttrib4f_fnptr(index, x, y, z, w);
        
        public static void VertexAttrib4fv(uint index, float* v) => GLPointers._glVertexAttrib4fv_fnptr(index, v);
        
        public static void VertexAttrib4iv(uint index, int* v) => GLPointers._glVertexAttrib4iv_fnptr(index, v);
        
        public static void VertexAttrib4s(uint index, short x, short y, short z, short w) => GLPointers._glVertexAttrib4s_fnptr(index, x, y, z, w);
        
        public static void VertexAttrib4sv(uint index, short* v) => GLPointers._glVertexAttrib4sv_fnptr(index, v);
        
        public static void VertexAttrib4ubv(uint index, byte* v) => GLPointers._glVertexAttrib4ubv_fnptr(index, v);
        
        public static void VertexAttrib4uiv(uint index, uint* v) => GLPointers._glVertexAttrib4uiv_fnptr(index, v);
        
        public static void VertexAttrib4usv(uint index, ushort* v) => GLPointers._glVertexAttrib4usv_fnptr(index, v);
        
        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer) => GLPointers._glVertexAttribPointer_fnptr(index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, pointer);
        
        public static void UniformMatrix2x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix2x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ColorMaski(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaski_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
        
        public static void GetBooleani_v(BufferTargetARB target, uint index, bool* data) => GLPointers._glGetBooleani_v_fnptr((uint)target, index, (byte*)data);
        
        public static void GetIntegeri_v(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_v_fnptr((uint)target, index, data);
        
        public static void Enablei(EnableCap target, uint index) => GLPointers._glEnablei_fnptr((uint)target, index);
        
        public static void Disablei(EnableCap target, uint index) => GLPointers._glDisablei_fnptr((uint)target, index);
        
        public static bool IsEnabledi(EnableCap target, uint index) => GLPointers._glIsEnabledi_fnptr((uint)target, index) != 0;
        
        public static void BeginTransformFeedback(PrimitiveType primitiveMode) => GLPointers._glBeginTransformFeedback_fnptr((uint)primitiveMode);
        
        public static void EndTransformFeedback() => GLPointers._glEndTransformFeedback_fnptr();
        
        public static void BindBufferRange(BufferTargetARB target, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glBindBufferRange_fnptr((uint)target, index, buffer, offset, size);
        
        public static void BindBufferBase(BufferTargetARB target, uint index, int buffer) => GLPointers._glBindBufferBase_fnptr((uint)target, index, buffer);
        
        public static void TransformFeedbackVaryings(int program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode) => GLPointers._glTransformFeedbackVaryings_fnptr(program, count, varyings, (uint)bufferMode);
        
        public static void GetTransformFeedbackVarying(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetTransformFeedbackVarying_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        public static void ClampColor(ClampColorTargetARB target, ClampColorModeARB clamp) => GLPointers._glClampColor_fnptr((uint)target, (uint)clamp);
        
        public static void BeginConditionalRender(uint id, ConditionalRenderMode mode) => GLPointers._glBeginConditionalRender_fnptr(id, (uint)mode);
        
        public static void EndConditionalRender() => GLPointers._glEndConditionalRender_fnptr();
        
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, void* pointer) => GLPointers._glVertexAttribIPointer_fnptr(index, size, (uint)type, stride, pointer);
        
        public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, int* parameters) => GLPointers._glGetVertexAttribIiv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* parameters) => GLPointers._glGetVertexAttribIuiv_fnptr(index, (uint)pname, parameters);
        
        public static void VertexAttribI1i(uint index, int x) => GLPointers._glVertexAttribI1i_fnptr(index, x);
        
        public static void VertexAttribI2i(uint index, int x, int y) => GLPointers._glVertexAttribI2i_fnptr(index, x, y);
        
        public static void VertexAttribI3i(uint index, int x, int y, int z) => GLPointers._glVertexAttribI3i_fnptr(index, x, y, z);
        
        public static void VertexAttribI4i(uint index, int x, int y, int z, int w) => GLPointers._glVertexAttribI4i_fnptr(index, x, y, z, w);
        
        public static void VertexAttribI1ui(uint index, uint x) => GLPointers._glVertexAttribI1ui_fnptr(index, x);
        
        public static void VertexAttribI2ui(uint index, uint x, uint y) => GLPointers._glVertexAttribI2ui_fnptr(index, x, y);
        
        public static void VertexAttribI3ui(uint index, uint x, uint y, uint z) => GLPointers._glVertexAttribI3ui_fnptr(index, x, y, z);
        
        public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => GLPointers._glVertexAttribI4ui_fnptr(index, x, y, z, w);
        
        public static void VertexAttribI1iv(uint index, int* v) => GLPointers._glVertexAttribI1iv_fnptr(index, v);
        
        public static void VertexAttribI2iv(uint index, int* v) => GLPointers._glVertexAttribI2iv_fnptr(index, v);
        
        public static void VertexAttribI3iv(uint index, int* v) => GLPointers._glVertexAttribI3iv_fnptr(index, v);
        
        public static void VertexAttribI4iv(uint index, int* v) => GLPointers._glVertexAttribI4iv_fnptr(index, v);
        
        public static void VertexAttribI1uiv(uint index, uint* v) => GLPointers._glVertexAttribI1uiv_fnptr(index, v);
        
        public static void VertexAttribI2uiv(uint index, uint* v) => GLPointers._glVertexAttribI2uiv_fnptr(index, v);
        
        public static void VertexAttribI3uiv(uint index, uint* v) => GLPointers._glVertexAttribI3uiv_fnptr(index, v);
        
        public static void VertexAttribI4uiv(uint index, uint* v) => GLPointers._glVertexAttribI4uiv_fnptr(index, v);
        
        public static void VertexAttribI4bv(uint index, sbyte* v) => GLPointers._glVertexAttribI4bv_fnptr(index, v);
        
        public static void VertexAttribI4sv(uint index, short* v) => GLPointers._glVertexAttribI4sv_fnptr(index, v);
        
        public static void VertexAttribI4ubv(uint index, byte* v) => GLPointers._glVertexAttribI4ubv_fnptr(index, v);
        
        public static void VertexAttribI4usv(uint index, ushort* v) => GLPointers._glVertexAttribI4usv_fnptr(index, v);
        
        public static void GetUniformuiv(int program, int location, uint* parameters) => GLPointers._glGetUniformuiv_fnptr(program, location, parameters);
        
        public static void BindFragDataLocation(int program, uint color, byte* name) => GLPointers._glBindFragDataLocation_fnptr(program, color, name);
        
        public static int GetFragDataLocation(int program, byte* name) => GLPointers._glGetFragDataLocation_fnptr(program, name);
        
        public static void Uniform1ui(int location, uint v0) => GLPointers._glUniform1ui_fnptr(location, v0);
        
        public static void Uniform2ui(int location, uint v0, uint v1) => GLPointers._glUniform2ui_fnptr(location, v0, v1);
        
        public static void Uniform3ui(int location, uint v0, uint v1, uint v2) => GLPointers._glUniform3ui_fnptr(location, v0, v1, v2);
        
        public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glUniform4ui_fnptr(location, v0, v1, v2, v3);
        
        public static void Uniform1uiv(int location, int count, uint* value) => GLPointers._glUniform1uiv_fnptr(location, count, value);
        
        public static void Uniform2uiv(int location, int count, uint* value) => GLPointers._glUniform2uiv_fnptr(location, count, value);
        
        public static void Uniform3uiv(int location, int count, uint* value) => GLPointers._glUniform3uiv_fnptr(location, count, value);
        
        public static void Uniform4uiv(int location, int count, uint* value) => GLPointers._glUniform4uiv_fnptr(location, count, value);
        
        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void ClearBufferiv(Buffer buffer, int drawbuffer, int* value) => GLPointers._glClearBufferiv_fnptr((uint)buffer, drawbuffer, value);
        
        public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint* value) => GLPointers._glClearBufferuiv_fnptr((uint)buffer, drawbuffer, value);
        
        public static void ClearBufferfv(Buffer buffer, int drawbuffer, float* value) => GLPointers._glClearBufferfv_fnptr((uint)buffer, drawbuffer, value);
        
        public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => GLPointers._glClearBufferfi_fnptr((uint)buffer, drawbuffer, depth, stencil);
        
        public static byte* GetStringi_(StringName name, uint index) => GLPointers._glGetStringi_fnptr((uint)name, index);
        
        public static bool IsRenderbuffer(int renderbuffer) => GLPointers._glIsRenderbuffer_fnptr(renderbuffer) != 0;
        
        public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbuffer_fnptr((uint)target, renderbuffer);
        
        public static void DeleteRenderbuffers(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffers_fnptr(n, renderbuffers);
        
        public static void GenRenderbuffers(int n, int* renderbuffers) => GLPointers._glGenRenderbuffers_fnptr(n, renderbuffers);
        
        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorage_fnptr((uint)target, (uint)internalformat, width, height);
        
        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static bool IsFramebuffer(int framebuffer) => GLPointers._glIsFramebuffer_fnptr(framebuffer) != 0;
        
        public static void BindFramebuffer(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebuffer_fnptr((uint)target, framebuffer);
        
        public static void DeleteFramebuffers(int n, int* framebuffers) => GLPointers._glDeleteFramebuffers_fnptr(n, framebuffers);
        
        public static void GenFramebuffers(int n, int* framebuffers) => GLPointers._glGenFramebuffers_fnptr(n, framebuffers);
        
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatus_fnptr((uint)target);
        
        public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture1D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
        
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
        
        public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset) => GLPointers._glFramebufferTexture3D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, zoffset);
        
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbuffer_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
        
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameteriv_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
        
        public static void GenerateMipmap(TextureTarget target) => GLPointers._glGenerateMipmap_fnptr((uint)target);
        
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebuffer_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
        
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height);
        
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayer_fnptr((uint)target, (uint)attachment, texture, level, layer);
        
        public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRange_fnptr((uint)target, offset, length, (uint)access);
        
        public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRange_fnptr((uint)target, offset, length);
        
        public static void BindVertexArray(int array) => GLPointers._glBindVertexArray_fnptr(array);
        
        public static void DeleteVertexArrays(int n, int* arrays) => GLPointers._glDeleteVertexArrays_fnptr(n, arrays);
        
        public static void GenVertexArrays(int n, int* arrays) => GLPointers._glGenVertexArrays_fnptr(n, arrays);
        
        public static bool IsVertexArray(int array) => GLPointers._glIsVertexArray_fnptr(array) != 0;
        
        public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount) => GLPointers._glDrawArraysInstanced_fnptr((uint)mode, first, count, instancecount);
        
        public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount) => GLPointers._glDrawElementsInstanced_fnptr((uint)mode, count, (uint)type, indices, instancecount);
        
        public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBuffer_fnptr((uint)target, (uint)internalformat, buffer);
        
        public static void PrimitiveRestartIndex(uint index) => GLPointers._glPrimitiveRestartIndex_fnptr(index);
        
        public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubData_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
        
        public static void GetUniformIndices(int program, int uniformCount, byte** uniformNames, uint* uniformIndices) => GLPointers._glGetUniformIndices_fnptr(program, uniformCount, uniformNames, uniformIndices);
        
        public static void GetActiveUniformsiv(int program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters) => GLPointers._glGetActiveUniformsiv_fnptr(program, uniformCount, uniformIndices, (uint)pname, parameters);
        
        public static void GetActiveUniformName(int program, uint uniformIndex, int bufSize, int* length, byte* uniformName) => GLPointers._glGetActiveUniformName_fnptr(program, uniformIndex, bufSize, length, uniformName);
        
        public static uint GetUniformBlockIndex(int program, byte* uniformBlockName) => GLPointers._glGetUniformBlockIndex_fnptr(program, uniformBlockName);
        
        public static void GetActiveUniformBlockiv(int program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters) => GLPointers._glGetActiveUniformBlockiv_fnptr(program, uniformBlockIndex, (uint)pname, parameters);
        
        public static void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => GLPointers._glGetActiveUniformBlockName_fnptr(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        
        public static void UniformBlockBinding(int program, uint uniformBlockIndex, uint uniformBlockBinding) => GLPointers._glUniformBlockBinding_fnptr(program, uniformBlockIndex, uniformBlockBinding);
        
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, basevertex);
        
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertex_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
        
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertex_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
        
        public static void MultiDrawElementsBaseVertex(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
        
        public static void ProvokingVertex(VertexProvokingMode mode) => GLPointers._glProvokingVertex_fnptr((uint)mode);
        
        public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSync_fnptr((uint)condition, (uint)flags);
        
        public static bool IsSync(GLSync sync) => GLPointers._glIsSync_fnptr((IntPtr)sync) != 0;
        
        public static void DeleteSync(GLSync sync) => GLPointers._glDeleteSync_fnptr((IntPtr)sync);
        
        public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        public static void GetInteger64v(GetPName pname, long* data) => GLPointers._glGetInteger64v_fnptr((uint)pname, data);
        
        public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSynciv_fnptr((IntPtr)sync, (uint)pname, count, length, values);
        
        public static void GetInteger64i_v(GetPName target, uint index, long* data) => GLPointers._glGetInteger64i_v_fnptr((uint)target, index, data);
        
        public static void GetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* parameters) => GLPointers._glGetBufferParameteri64v_fnptr((uint)target, (uint)pname, parameters);
        
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTexture_fnptr((uint)target, (uint)attachment, texture, level);
        
        public static void TexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTexImage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void TexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexImage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val) => GLPointers._glGetMultisamplefv_fnptr((uint)pname, index, val);
        
        public static void SampleMaski(uint maskNumber, uint mask) => GLPointers._glSampleMaski_fnptr(maskNumber, mask);
        
        public static void BindFragDataLocationIndexed(int program, uint colorNumber, uint index, byte* name) => GLPointers._glBindFragDataLocationIndexed_fnptr(program, colorNumber, index, name);
        
        public static int GetFragDataIndex(int program, byte* name) => GLPointers._glGetFragDataIndex_fnptr(program, name);
        
        public static void GenSamplers(int count, int* samplers) => GLPointers._glGenSamplers_fnptr(count, samplers);
        
        public static void DeleteSamplers(int count, int* samplers) => GLPointers._glDeleteSamplers_fnptr(count, samplers);
        
        public static bool IsSampler(int sampler) => GLPointers._glIsSampler_fnptr(sampler) != 0;
        
        public static void BindSampler(uint unit, int sampler) => GLPointers._glBindSampler_fnptr(unit, sampler);
        
        public static void SamplerParameteri(int sampler, SamplerParameterI pname, int param) => GLPointers._glSamplerParameteri_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameteriv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameteriv_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameterf(int sampler, SamplerParameterF pname, float param) => GLPointers._glSamplerParameterf_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameterfv(int sampler, SamplerParameterF pname, float* param) => GLPointers._glSamplerParameterfv_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameterIiv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIiv_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuiv_fnptr(sampler, (uint)pname, param);
        
        public static void GetSamplerParameteriv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameteriv_fnptr(sampler, (uint)pname, parameters);
        
        public static void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIiv_fnptr(sampler, (uint)pname, parameters);
        
        public static void GetSamplerParameterfv(int sampler, SamplerParameterF pname, float* parameters) => GLPointers._glGetSamplerParameterfv_fnptr(sampler, (uint)pname, parameters);
        
        public static void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuiv_fnptr(sampler, (uint)pname, parameters);
        
        public static void QueryCounter(int id, QueryCounterTarget target) => GLPointers._glQueryCounter_fnptr(id, (uint)target);
        
        public static void GetQueryObjecti64v(int id, QueryObjectParameterName pname, long* parameters) => GLPointers._glGetQueryObjecti64v_fnptr(id, (uint)pname, parameters);
        
        public static void GetQueryObjectui64v(int id, QueryObjectParameterName pname, ulong* parameters) => GLPointers._glGetQueryObjectui64v_fnptr(id, (uint)pname, parameters);
        
        public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._glVertexAttribDivisor_fnptr(index, divisor);
        
        public static void VertexAttribP1ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP1ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexAttribP1uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP1uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexAttribP2ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP2ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexAttribP2uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP2uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexAttribP3ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP3ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexAttribP3uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP3uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexAttribP4ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP4ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexAttribP4uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP4uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
        
        public static void VertexP2ui(VertexPointerType type, uint value) => GLPointers._glVertexP2ui_fnptr((uint)type, value);
        
        public static void VertexP2uiv(VertexPointerType type, uint* value) => GLPointers._glVertexP2uiv_fnptr((uint)type, value);
        
        public static void VertexP3ui(VertexPointerType type, uint value) => GLPointers._glVertexP3ui_fnptr((uint)type, value);
        
        public static void VertexP3uiv(VertexPointerType type, uint* value) => GLPointers._glVertexP3uiv_fnptr((uint)type, value);
        
        public static void VertexP4ui(VertexPointerType type, uint value) => GLPointers._glVertexP4ui_fnptr((uint)type, value);
        
        public static void VertexP4uiv(VertexPointerType type, uint* value) => GLPointers._glVertexP4uiv_fnptr((uint)type, value);
        
        public static void TexCoordP1ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP1ui_fnptr((uint)type, coords);
        
        public static void TexCoordP1uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP1uiv_fnptr((uint)type, coords);
        
        public static void TexCoordP2ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP2ui_fnptr((uint)type, coords);
        
        public static void TexCoordP2uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP2uiv_fnptr((uint)type, coords);
        
        public static void TexCoordP3ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP3ui_fnptr((uint)type, coords);
        
        public static void TexCoordP3uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP3uiv_fnptr((uint)type, coords);
        
        public static void TexCoordP4ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP4ui_fnptr((uint)type, coords);
        
        public static void TexCoordP4uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP4uiv_fnptr((uint)type, coords);
        
        public static void MultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP1ui_fnptr((uint)texture, (uint)type, coords);
        
        public static void MultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP1uiv_fnptr((uint)texture, (uint)type, coords);
        
        public static void MultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP2ui_fnptr((uint)texture, (uint)type, coords);
        
        public static void MultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP2uiv_fnptr((uint)texture, (uint)type, coords);
        
        public static void MultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP3ui_fnptr((uint)texture, (uint)type, coords);
        
        public static void MultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP3uiv_fnptr((uint)texture, (uint)type, coords);
        
        public static void MultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP4ui_fnptr((uint)texture, (uint)type, coords);
        
        public static void MultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP4uiv_fnptr((uint)texture, (uint)type, coords);
        
        public static void NormalP3ui(NormalPointerType type, uint coords) => GLPointers._glNormalP3ui_fnptr((uint)type, coords);
        
        public static void NormalP3uiv(NormalPointerType type, uint* coords) => GLPointers._glNormalP3uiv_fnptr((uint)type, coords);
        
        public static void ColorP3ui(ColorPointerType type, uint color) => GLPointers._glColorP3ui_fnptr((uint)type, color);
        
        public static void ColorP3uiv(ColorPointerType type, uint* color) => GLPointers._glColorP3uiv_fnptr((uint)type, color);
        
        public static void ColorP4ui(ColorPointerType type, uint color) => GLPointers._glColorP4ui_fnptr((uint)type, color);
        
        public static void ColorP4uiv(ColorPointerType type, uint* color) => GLPointers._glColorP4uiv_fnptr((uint)type, color);
        
        public static void SecondaryColorP3ui(ColorPointerType type, uint color) => GLPointers._glSecondaryColorP3ui_fnptr((uint)type, color);
        
        public static void SecondaryColorP3uiv(ColorPointerType type, uint* color) => GLPointers._glSecondaryColorP3uiv_fnptr((uint)type, color);
        
        public static void MinSampleShading(float value) => GLPointers._glMinSampleShading_fnptr(value);
        
        public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationi_fnptr(buf, (uint)mode);
        
        public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparatei_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
        
        public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunci_fnptr(buf, (uint)src, (uint)dst);
        
        public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparatei_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
        
        public static void DrawArraysIndirect(PrimitiveType mode, void* indirect) => GLPointers._glDrawArraysIndirect_fnptr((uint)mode, indirect);
        
        public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => GLPointers._glDrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect);
        
        public static void Uniform1d(int location, double x) => GLPointers._glUniform1d_fnptr(location, x);
        
        public static void Uniform2d(int location, double x, double y) => GLPointers._glUniform2d_fnptr(location, x, y);
        
        public static void Uniform3d(int location, double x, double y, double z) => GLPointers._glUniform3d_fnptr(location, x, y, z);
        
        public static void Uniform4d(int location, double x, double y, double z, double w) => GLPointers._glUniform4d_fnptr(location, x, y, z, w);
        
        public static void Uniform1dv(int location, int count, double* value) => GLPointers._glUniform1dv_fnptr(location, count, value);
        
        public static void Uniform2dv(int location, int count, double* value) => GLPointers._glUniform2dv_fnptr(location, count, value);
        
        public static void Uniform3dv(int location, int count, double* value) => GLPointers._glUniform3dv_fnptr(location, count, value);
        
        public static void Uniform4dv(int location, int count, double* value) => GLPointers._glUniform4dv_fnptr(location, count, value);
        
        public static void UniformMatrix2dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix2dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix3dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix4dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix2x3dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix2x3dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix2x4dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix2x4dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3x2dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix3x2dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3x4dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix3x4dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4x2dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix4x2dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4x3dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix4x3dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void GetUniformdv(int program, int location, double* parameters) => GLPointers._glGetUniformdv_fnptr(program, location, parameters);
        
        public static int GetSubroutineUniformLocation(int program, ShaderType shadertype, byte* name) => GLPointers._glGetSubroutineUniformLocation_fnptr(program, (uint)shadertype, name);
        
        public static uint GetSubroutineIndex(int program, ShaderType shadertype, byte* name) => GLPointers._glGetSubroutineIndex_fnptr(program, (uint)shadertype, name);
        
        public static void GetActiveSubroutineUniformiv(int program, ShaderType shadertype, uint index, SubroutineParameterName pname, int* values) => GLPointers._glGetActiveSubroutineUniformiv_fnptr(program, (uint)shadertype, index, (uint)pname, values);
        
        public static void GetActiveSubroutineUniformName(int program, ShaderType shadertype, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetActiveSubroutineUniformName_fnptr(program, (uint)shadertype, index, bufSize, length, name);
        
        public static void GetActiveSubroutineName(int program, ShaderType shadertype, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetActiveSubroutineName_fnptr(program, (uint)shadertype, index, bufSize, length, name);
        
        public static void UniformSubroutinesuiv(ShaderType shadertype, int count, uint* indices) => GLPointers._glUniformSubroutinesuiv_fnptr((uint)shadertype, count, indices);
        
        public static void GetUniformSubroutineuiv(ShaderType shadertype, int location, uint* parameters) => GLPointers._glGetUniformSubroutineuiv_fnptr((uint)shadertype, location, parameters);
        
        public static void GetProgramStageiv(int program, ShaderType shadertype, ProgramStagePName pname, int* values) => GLPointers._glGetProgramStageiv_fnptr(program, (uint)shadertype, (uint)pname, values);
        
        public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._glPatchParameteri_fnptr((uint)pname, value);
        
        public static void PatchParameterfv(PatchParameterName pname, float* values) => GLPointers._glPatchParameterfv_fnptr((uint)pname, values);
        
        public static void BindTransformFeedback(BindTransformFeedbackTarget target, int id) => GLPointers._glBindTransformFeedback_fnptr((uint)target, id);
        
        public static void DeleteTransformFeedbacks(int n, int* ids) => GLPointers._glDeleteTransformFeedbacks_fnptr(n, ids);
        
        public static void GenTransformFeedbacks(int n, int* ids) => GLPointers._glGenTransformFeedbacks_fnptr(n, ids);
        
        public static bool IsTransformFeedback(int id) => GLPointers._glIsTransformFeedback_fnptr(id) != 0;
        
        public static void PauseTransformFeedback() => GLPointers._glPauseTransformFeedback_fnptr();
        
        public static void ResumeTransformFeedback() => GLPointers._glResumeTransformFeedback_fnptr();
        
        public static void DrawTransformFeedback(PrimitiveType mode, int id) => GLPointers._glDrawTransformFeedback_fnptr((uint)mode, id);
        
        public static void DrawTransformFeedbackStream(PrimitiveType mode, int id, uint stream) => GLPointers._glDrawTransformFeedbackStream_fnptr((uint)mode, id, stream);
        
        public static void BeginQueryIndexed(QueryTarget target, uint index, int id) => GLPointers._glBeginQueryIndexed_fnptr((uint)target, index, id);
        
        public static void EndQueryIndexed(QueryTarget target, uint index) => GLPointers._glEndQueryIndexed_fnptr((uint)target, index);
        
        public static void GetQueryIndexediv(QueryTarget target, uint index, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryIndexediv_fnptr((uint)target, index, (uint)pname, parameters);
        
        public static void ReleaseShaderCompiler() => GLPointers._glReleaseShaderCompiler_fnptr();
        
        public static void ShaderBinary(int count, int* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length) => GLPointers._glShaderBinary_fnptr(count, shaders, (uint)binaryFormat, binary, length);
        
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => GLPointers._glGetShaderPrecisionFormat_fnptr((uint)shadertype, (uint)precisiontype, range, precision);
        
        public static void DepthRangef(float n, float f) => GLPointers._glDepthRangef_fnptr(n, f);
        
        public static void ClearDepthf(float d) => GLPointers._glClearDepthf_fnptr(d);
        
        public static void GetProgramBinary(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinary_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
        
        public static void ProgramBinary(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinary_fnptr(program, (uint)binaryFormat, binary, length);
        
        public static void ProgramParameteri(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteri_fnptr(program, (uint)pname, value);
        
        public static void UseProgramStages(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStages_fnptr(pipeline, (uint)stages, program);
        
        public static void ActiveShaderProgram(int pipeline, int program) => GLPointers._glActiveShaderProgram_fnptr(pipeline, program);
        
        public static int CreateShaderProgramv(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramv_fnptr((uint)type, count, strings);
        
        public static void BindProgramPipeline(int pipeline) => GLPointers._glBindProgramPipeline_fnptr(pipeline);
        
        public static void DeleteProgramPipelines(int n, int* pipelines) => GLPointers._glDeleteProgramPipelines_fnptr(n, pipelines);
        
        public static void GenProgramPipelines(int n, int* pipelines) => GLPointers._glGenProgramPipelines_fnptr(n, pipelines);
        
        public static bool IsProgramPipeline(int pipeline) => GLPointers._glIsProgramPipeline_fnptr(pipeline) != 0;
        
        public static void GetProgramPipelineiv(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineiv_fnptr(pipeline, (uint)pname, parameters);
        
        public static void ProgramUniform1i(int program, int location, int v0) => GLPointers._glProgramUniform1i_fnptr(program, location, v0);
        
        public static void ProgramUniform1iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform1iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform1f(int program, int location, float v0) => GLPointers._glProgramUniform1f_fnptr(program, location, v0);
        
        public static void ProgramUniform1fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform1d(int program, int location, double v0) => GLPointers._glProgramUniform1d_fnptr(program, location, v0);
        
        public static void ProgramUniform1dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform1dv_fnptr(program, location, count, value);
        
        public static void ProgramUniform1ui(int program, int location, uint v0) => GLPointers._glProgramUniform1ui_fnptr(program, location, v0);
        
        public static void ProgramUniform1uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniform2i(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2i_fnptr(program, location, v0, v1);
        
        public static void ProgramUniform2iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform2iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform2f(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2f_fnptr(program, location, v0, v1);
        
        public static void ProgramUniform2fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform2d(int program, int location, double v0, double v1) => GLPointers._glProgramUniform2d_fnptr(program, location, v0, v1);
        
        public static void ProgramUniform2dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform2dv_fnptr(program, location, count, value);
        
        public static void ProgramUniform2ui(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2ui_fnptr(program, location, v0, v1);
        
        public static void ProgramUniform2uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniform3i(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3i_fnptr(program, location, v0, v1, v2);
        
        public static void ProgramUniform3iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform3iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform3f(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3f_fnptr(program, location, v0, v1, v2);
        
        public static void ProgramUniform3fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform3d(int program, int location, double v0, double v1, double v2) => GLPointers._glProgramUniform3d_fnptr(program, location, v0, v1, v2);
        
        public static void ProgramUniform3dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform3dv_fnptr(program, location, count, value);
        
        public static void ProgramUniform3ui(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3ui_fnptr(program, location, v0, v1, v2);
        
        public static void ProgramUniform3uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniform4i(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4i_fnptr(program, location, v0, v1, v2, v3);
        
        public static void ProgramUniform4iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform4iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform4f(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4f_fnptr(program, location, v0, v1, v2, v3);
        
        public static void ProgramUniform4fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform4d(int program, int location, double v0, double v1, double v2, double v3) => GLPointers._glProgramUniform4d_fnptr(program, location, v0, v1, v2, v3);
        
        public static void ProgramUniform4dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform4dv_fnptr(program, location, count, value);
        
        public static void ProgramUniform4ui(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4ui_fnptr(program, location, v0, v1, v2, v3);
        
        public static void ProgramUniform4uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix2dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix2x3dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2x3dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3x2dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3x2dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix2x4dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2x4dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4x2dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4x2dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3x4dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3x4dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4x3dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4x3dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ValidateProgramPipeline(int pipeline) => GLPointers._glValidateProgramPipeline_fnptr(pipeline);
        
        public static void GetProgramPipelineInfoLog(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLog_fnptr(pipeline, bufSize, length, infoLog);
        
        public static void VertexAttribL1d(uint index, double x) => GLPointers._glVertexAttribL1d_fnptr(index, x);
        
        public static void VertexAttribL2d(uint index, double x, double y) => GLPointers._glVertexAttribL2d_fnptr(index, x, y);
        
        public static void VertexAttribL3d(uint index, double x, double y, double z) => GLPointers._glVertexAttribL3d_fnptr(index, x, y, z);
        
        public static void VertexAttribL4d(uint index, double x, double y, double z, double w) => GLPointers._glVertexAttribL4d_fnptr(index, x, y, z, w);
        
        public static void VertexAttribL1dv(uint index, double* v) => GLPointers._glVertexAttribL1dv_fnptr(index, v);
        
        public static void VertexAttribL2dv(uint index, double* v) => GLPointers._glVertexAttribL2dv_fnptr(index, v);
        
        public static void VertexAttribL3dv(uint index, double* v) => GLPointers._glVertexAttribL3dv_fnptr(index, v);
        
        public static void VertexAttribL4dv(uint index, double* v) => GLPointers._glVertexAttribL4dv_fnptr(index, v);
        
        public static void VertexAttribLPointer(uint index, int size, VertexAttribLType type, int stride, void* pointer) => GLPointers._glVertexAttribLPointer_fnptr(index, size, (uint)type, stride, pointer);
        
        public static void GetVertexAttribLdv(uint index, VertexAttribEnum pname, double* parameters) => GLPointers._glGetVertexAttribLdv_fnptr(index, (uint)pname, parameters);
        
        public static void ViewportArrayv(uint first, int count, float* v) => GLPointers._glViewportArrayv_fnptr(first, count, v);
        
        public static void ViewportIndexedf(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedf_fnptr(index, x, y, w, h);
        
        public static void ViewportIndexedfv(uint index, float* v) => GLPointers._glViewportIndexedfv_fnptr(index, v);
        
        public static void ScissorArrayv(uint first, int count, int* v) => GLPointers._glScissorArrayv_fnptr(first, count, v);
        
        public static void ScissorIndexed(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexed_fnptr(index, left, bottom, width, height);
        
        public static void ScissorIndexedv(uint index, int* v) => GLPointers._glScissorIndexedv_fnptr(index, v);
        
        public static void DepthRangeArrayv(uint first, int count, double* v) => GLPointers._glDepthRangeArrayv_fnptr(first, count, v);
        
        public static void DepthRangeIndexed(uint index, double n, double f) => GLPointers._glDepthRangeIndexed_fnptr(index, n, f);
        
        public static void GetFloati_v(GetPName target, uint index, float* data) => GLPointers._glGetFloati_v_fnptr((uint)target, index, data);
        
        public static void GetDoublei_v(GetPName target, uint index, double* data) => GLPointers._glGetDoublei_v_fnptr((uint)target, index, data);
        
        public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance) => GLPointers._glDrawArraysInstancedBaseInstance_fnptr((uint)mode, first, count, instancecount, baseinstance);
        
        public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseInstance_fnptr((uint)mode, count, (uint)type, indices, instancecount, baseinstance);
        
        public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseVertexBaseInstance_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex, baseinstance);
        
        public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformativ_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
        
        public static void GetActiveAtomicCounterBufferiv(int program, uint bufferIndex, AtomicCounterBufferPName pname, int* parameters) => GLPointers._glGetActiveAtomicCounterBufferiv_fnptr(program, bufferIndex, (uint)pname, parameters);
        
        public static void BindImageTexture(uint unit, int texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format) => GLPointers._glBindImageTexture_fnptr(unit, texture, level, (byte)(layered ? 1 : 0), layer, (uint)access, (uint)format);
        
        public static void MemoryBarrier(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrier_fnptr((uint)barriers);
        
        public static void TexStorage1D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTexStorage1D_fnptr((uint)target, levels, (uint)internalformat, width);
        
        public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2D_fnptr((uint)target, levels, (uint)internalformat, width, height);
        
        public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3D_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
        
        public static void DrawTransformFeedbackInstanced(PrimitiveType mode, int id, int instancecount) => GLPointers._glDrawTransformFeedbackInstanced_fnptr((uint)mode, id, instancecount);
        
        public static void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, int id, uint stream, int instancecount) => GLPointers._glDrawTransformFeedbackStreamInstanced_fnptr((uint)mode, id, stream, instancecount);
        
        public static void ClearBufferData(BufferStorageTarget target, SizedInternalFormat internalformat, PixelFormat format, PixelType type, void* data) => GLPointers._glClearBufferData_fnptr((uint)target, (uint)internalformat, (uint)format, (uint)type, data);
        
        public static void ClearBufferSubData(BufferTargetARB target, SizedInternalFormat internalformat, IntPtr offset, nint size, PixelFormat format, PixelType type, void* data) => GLPointers._glClearBufferSubData_fnptr((uint)target, (uint)internalformat, offset, size, (uint)format, (uint)type, data);
        
        public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => GLPointers._glDispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
        
        public static void DispatchComputeIndirect(IntPtr indirect) => GLPointers._glDispatchComputeIndirect_fnptr(indirect);
        
        public static void CopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubData_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        
        public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteri_fnptr((uint)target, (uint)pname, param);
        
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, long* parameters) => GLPointers._glGetInternalformati64v_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
        
        public static void InvalidateTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) => GLPointers._glInvalidateTexSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth);
        
        public static void InvalidateTexImage(int texture, int level) => GLPointers._glInvalidateTexImage_fnptr(texture, level);
        
        public static void InvalidateBufferSubData(int buffer, IntPtr offset, nint length) => GLPointers._glInvalidateBufferSubData_fnptr(buffer, offset, length);
        
        public static void InvalidateBufferData(int buffer) => GLPointers._glInvalidateBufferData_fnptr(buffer);
        
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glInvalidateFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments);
        
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._glInvalidateSubFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments, x, y, width, height);
        
        public static void MultiDrawArraysIndirect(PrimitiveType mode, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawArraysIndirect_fnptr((uint)mode, indirect, drawcount, stride);
        
        public static void MultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect, drawcount, stride);
        
        public static void GetProgramInterfaceiv(int program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters) => GLPointers._glGetProgramInterfaceiv_fnptr(program, (uint)programInterface, (uint)pname, parameters);
        
        public static uint GetProgramResourceIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceIndex_fnptr(program, (uint)programInterface, name);
        
        public static void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetProgramResourceName_fnptr(program, (uint)programInterface, index, bufSize, length, name);
        
        public static void GetProgramResourceiv(int program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* parameters) => GLPointers._glGetProgramResourceiv_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
        
        public static int GetProgramResourceLocation(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocation_fnptr(program, (uint)programInterface, name);
        
        public static int GetProgramResourceLocationIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocationIndex_fnptr(program, (uint)programInterface, name);
        
        public static void ShaderStorageBlockBinding(int program, uint storageBlockIndex, uint storageBlockBinding) => GLPointers._glShaderStorageBlockBinding_fnptr(program, storageBlockIndex, storageBlockBinding);
        
        public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRange_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
        
        public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTexStorage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void TextureView(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureView_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
        
        public static void BindVertexBuffer(uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glBindVertexBuffer_fnptr(bindingindex, buffer, offset, stride);
        
        public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexAttribFormat_fnptr(attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
        
        public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexAttribIFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
        
        public static void VertexAttribLFormat(uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => GLPointers._glVertexAttribLFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
        
        public static void VertexAttribBinding(uint attribindex, uint bindingindex) => GLPointers._glVertexAttribBinding_fnptr(attribindex, bindingindex);
        
        public static void VertexBindingDivisor(uint bindingindex, uint divisor) => GLPointers._glVertexBindingDivisor_fnptr(bindingindex, divisor);
        
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
        
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
        
        public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
        
        public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
        
        public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
        
        public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
        
        public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
        
        public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
        
        public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
        
        public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
        
        public static void BufferStorage(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags) => GLPointers._glBufferStorage_fnptr((uint)target, size, data, (uint)flags);
        
        public static void ClearTexImage(int texture, int level, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexImage_fnptr(texture, level, (uint)format, (uint)type, data);
        
        public static void ClearTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, data);
        
        public static void BindBuffersBase(BufferTargetARB target, uint first, int count, int* buffers) => GLPointers._glBindBuffersBase_fnptr((uint)target, first, count, buffers);
        
        public static void BindBuffersRange(BufferTargetARB target, uint first, int count, int* buffers, IntPtr* offsets, nint* sizes) => GLPointers._glBindBuffersRange_fnptr((uint)target, first, count, buffers, offsets, sizes);
        
        public static void BindTextures(uint first, int count, int* textures) => GLPointers._glBindTextures_fnptr(first, count, textures);
        
        public static void BindSamplers(uint first, int count, int* samplers) => GLPointers._glBindSamplers_fnptr(first, count, samplers);
        
        public static void BindImageTextures(uint first, int count, int* textures) => GLPointers._glBindImageTextures_fnptr(first, count, textures);
        
        public static void BindVertexBuffers(uint first, int count, int* buffers, IntPtr* offsets, int* strides) => GLPointers._glBindVertexBuffers_fnptr(first, count, buffers, offsets, strides);
        
        public static void ClipControl(ClipControlOrigin origin, ClipControlDepth depth) => GLPointers._glClipControl_fnptr((uint)origin, (uint)depth);
        
        public static void CreateTransformFeedbacks(int n, int* ids) => GLPointers._glCreateTransformFeedbacks_fnptr(n, ids);
        
        public static void TransformFeedbackBufferBase(int xfb, uint index, int buffer) => GLPointers._glTransformFeedbackBufferBase_fnptr(xfb, index, buffer);
        
        public static void TransformFeedbackBufferRange(int xfb, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glTransformFeedbackBufferRange_fnptr(xfb, index, buffer, offset, size);
        
        public static void GetTransformFeedbackiv(int xfb, TransformFeedbackPName pname, int* param) => GLPointers._glGetTransformFeedbackiv_fnptr(xfb, (uint)pname, param);
        
        public static void GetTransformFeedbacki_v(int xfb, TransformFeedbackPName pname, uint index, int* param) => GLPointers._glGetTransformFeedbacki_v_fnptr(xfb, (uint)pname, index, param);
        
        public static void GetTransformFeedbacki64_v(int xfb, TransformFeedbackPName pname, uint index, long* param) => GLPointers._glGetTransformFeedbacki64_v_fnptr(xfb, (uint)pname, index, param);
        
        public static void CreateBuffers(int n, int* buffers) => GLPointers._glCreateBuffers_fnptr(n, buffers);
        
        public static void NamedBufferStorage(int buffer, nint size, void* data, BufferStorageMask flags) => GLPointers._glNamedBufferStorage_fnptr(buffer, size, data, (uint)flags);
        
        public static void NamedBufferData(int buffer, nint size, void* data, VertexBufferObjectUsage usage) => GLPointers._glNamedBufferData_fnptr(buffer, size, data, (uint)usage);
        
        public static void NamedBufferSubData(int buffer, IntPtr offset, nint size, void* data) => GLPointers._glNamedBufferSubData_fnptr(buffer, offset, size, data);
        
        public static void CopyNamedBufferSubData(int readBuffer, int writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyNamedBufferSubData_fnptr(readBuffer, writeBuffer, readOffset, writeOffset, size);
        
        public static void ClearNamedBufferData(int buffer, SizedInternalFormat internalformat, PixelFormat format, PixelType type, void* data) => GLPointers._glClearNamedBufferData_fnptr(buffer, (uint)internalformat, (uint)format, (uint)type, data);
        
        public static void ClearNamedBufferSubData(int buffer, SizedInternalFormat internalformat, IntPtr offset, nint size, PixelFormat format, PixelType type, void* data) => GLPointers._glClearNamedBufferSubData_fnptr(buffer, (uint)internalformat, offset, size, (uint)format, (uint)type, data);
        
        public static void* MapNamedBuffer(int buffer, BufferAccessARB access) => GLPointers._glMapNamedBuffer_fnptr(buffer, (uint)access);
        
        public static void* MapNamedBufferRange(int buffer, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapNamedBufferRange_fnptr(buffer, offset, length, (uint)access);
        
        public static bool UnmapNamedBuffer(int buffer) => GLPointers._glUnmapNamedBuffer_fnptr(buffer) != 0;
        
        public static void FlushMappedNamedBufferRange(int buffer, IntPtr offset, nint length) => GLPointers._glFlushMappedNamedBufferRange_fnptr(buffer, offset, length);
        
        public static void GetNamedBufferParameteriv(int buffer, BufferPNameARB pname, int* parameters) => GLPointers._glGetNamedBufferParameteriv_fnptr(buffer, (uint)pname, parameters);
        
        public static void GetNamedBufferParameteri64v(int buffer, BufferPNameARB pname, long* parameters) => GLPointers._glGetNamedBufferParameteri64v_fnptr(buffer, (uint)pname, parameters);
        
        public static void GetNamedBufferPointerv(int buffer, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetNamedBufferPointerv_fnptr(buffer, (uint)pname, parameters);
        
        public static void GetNamedBufferSubData(int buffer, IntPtr offset, nint size, void* data) => GLPointers._glGetNamedBufferSubData_fnptr(buffer, offset, size, data);
        
        public static void CreateFramebuffers(int n, int* framebuffers) => GLPointers._glCreateFramebuffers_fnptr(n, framebuffers);
        
        public static void NamedFramebufferRenderbuffer(int framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glNamedFramebufferRenderbuffer_fnptr(framebuffer, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
        
        public static void NamedFramebufferParameteri(int framebuffer, FramebufferParameterName pname, int param) => GLPointers._glNamedFramebufferParameteri_fnptr(framebuffer, (uint)pname, param);
        
        public static void NamedFramebufferTexture(int framebuffer, FramebufferAttachment attachment, int texture, int level) => GLPointers._glNamedFramebufferTexture_fnptr(framebuffer, (uint)attachment, texture, level);
        
        public static void NamedFramebufferTextureLayer(int framebuffer, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glNamedFramebufferTextureLayer_fnptr(framebuffer, (uint)attachment, texture, level, layer);
        
        public static void NamedFramebufferDrawBuffer(int framebuffer, ColorBuffer buf) => GLPointers._glNamedFramebufferDrawBuffer_fnptr(framebuffer, (uint)buf);
        
        public static void NamedFramebufferDrawBuffers(int framebuffer, int n, ColorBuffer* bufs) => GLPointers._glNamedFramebufferDrawBuffers_fnptr(framebuffer, n, (uint*)bufs);
        
        public static void NamedFramebufferReadBuffer(int framebuffer, ColorBuffer src) => GLPointers._glNamedFramebufferReadBuffer_fnptr(framebuffer, (uint)src);
        
        public static void InvalidateNamedFramebufferData(int framebuffer, int numAttachments, FramebufferAttachment* attachments) => GLPointers._glInvalidateNamedFramebufferData_fnptr(framebuffer, numAttachments, (uint*)attachments);
        
        public static void InvalidateNamedFramebufferSubData(int framebuffer, int numAttachments, FramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._glInvalidateNamedFramebufferSubData_fnptr(framebuffer, numAttachments, (uint*)attachments, x, y, width, height);
        
        public static void ClearNamedFramebufferiv(int framebuffer, Buffer buffer, int drawbuffer, int* value) => GLPointers._glClearNamedFramebufferiv_fnptr(framebuffer, (uint)buffer, drawbuffer, value);
        
        public static void ClearNamedFramebufferuiv(int framebuffer, Buffer buffer, int drawbuffer, uint* value) => GLPointers._glClearNamedFramebufferuiv_fnptr(framebuffer, (uint)buffer, drawbuffer, value);
        
        public static void ClearNamedFramebufferfv(int framebuffer, Buffer buffer, int drawbuffer, float* value) => GLPointers._glClearNamedFramebufferfv_fnptr(framebuffer, (uint)buffer, drawbuffer, value);
        
        public static void ClearNamedFramebufferfi(int framebuffer, Buffer buffer, int drawbuffer, float depth, int stencil) => GLPointers._glClearNamedFramebufferfi_fnptr(framebuffer, (uint)buffer, drawbuffer, depth, stencil);
        
        public static void BlitNamedFramebuffer(int readFramebuffer, int drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitNamedFramebuffer_fnptr(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
        
        public static FramebufferStatus CheckNamedFramebufferStatus(int framebuffer, FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckNamedFramebufferStatus_fnptr(framebuffer, (uint)target);
        
        public static void GetNamedFramebufferParameteriv(int framebuffer, GetFramebufferParameter pname, int* param) => GLPointers._glGetNamedFramebufferParameteriv_fnptr(framebuffer, (uint)pname, param);
        
        public static void GetNamedFramebufferAttachmentParameteriv(int framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetNamedFramebufferAttachmentParameteriv_fnptr(framebuffer, (uint)attachment, (uint)pname, parameters);
        
        public static void CreateRenderbuffers(int n, int* renderbuffers) => GLPointers._glCreateRenderbuffers_fnptr(n, renderbuffers);
        
        public static void NamedRenderbufferStorage(int renderbuffer, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorage_fnptr(renderbuffer, (uint)internalformat, width, height);
        
        public static void NamedRenderbufferStorageMultisample(int renderbuffer, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisample_fnptr(renderbuffer, samples, (uint)internalformat, width, height);
        
        public static void GetNamedRenderbufferParameteriv(int renderbuffer, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetNamedRenderbufferParameteriv_fnptr(renderbuffer, (uint)pname, parameters);
        
        public static void CreateTextures(TextureTarget target, int n, int* textures) => GLPointers._glCreateTextures_fnptr((uint)target, n, textures);
        
        public static void TextureBuffer(int texture, SizedInternalFormat internalformat, int buffer) => GLPointers._glTextureBuffer_fnptr(texture, (uint)internalformat, buffer);
        
        public static void TextureBufferRange(int texture, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTextureBufferRange_fnptr(texture, (uint)internalformat, buffer, offset, size);
        
        public static void TextureStorage1D(int texture, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTextureStorage1D_fnptr(texture, levels, (uint)internalformat, width);
        
        public static void TextureStorage2D(int texture, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTextureStorage2D_fnptr(texture, levels, (uint)internalformat, width, height);
        
        public static void TextureStorage3D(int texture, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTextureStorage3D_fnptr(texture, levels, (uint)internalformat, width, height, depth);
        
        public static void TextureStorage2DMultisample(int texture, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTextureStorage2DMultisample_fnptr(texture, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void TextureStorage3DMultisample(int texture, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTextureStorage3DMultisample_fnptr(texture, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void TextureSubImage1D(int texture, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage1D_fnptr(texture, level, xoffset, width, (uint)format, (uint)type, pixels);
        
        public static void TextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage2D_fnptr(texture, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        public static void TextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage3D_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
        
        public static void CompressedTextureSubImage1D(int texture, int level, int xoffset, int width, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTextureSubImage1D_fnptr(texture, level, xoffset, width, (uint)format, imageSize, data);
        
        public static void CompressedTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTextureSubImage2D_fnptr(texture, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        public static void CompressedTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTextureSubImage3D_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
        
        public static void CopyTextureSubImage1D(int texture, int level, int xoffset, int x, int y, int width) => GLPointers._glCopyTextureSubImage1D_fnptr(texture, level, xoffset, x, y, width);
        
        public static void CopyTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTextureSubImage2D_fnptr(texture, level, xoffset, yoffset, x, y, width, height);
        
        public static void CopyTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTextureSubImage3D_fnptr(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        public static void TextureParameterf(int texture, TextureParameterName pname, float param) => GLPointers._glTextureParameterf_fnptr(texture, (uint)pname, param);
        
        public static void TextureParameterfv(int texture, TextureParameterName pname, float* param) => GLPointers._glTextureParameterfv_fnptr(texture, (uint)pname, param);
        
        public static void TextureParameteri(int texture, TextureParameterName pname, int param) => GLPointers._glTextureParameteri_fnptr(texture, (uint)pname, param);
        
        public static void TextureParameterIiv(int texture, TextureParameterName pname, int* parameters) => GLPointers._glTextureParameterIiv_fnptr(texture, (uint)pname, parameters);
        
        public static void TextureParameterIuiv(int texture, TextureParameterName pname, uint* parameters) => GLPointers._glTextureParameterIuiv_fnptr(texture, (uint)pname, parameters);
        
        public static void TextureParameteriv(int texture, TextureParameterName pname, int* param) => GLPointers._glTextureParameteriv_fnptr(texture, (uint)pname, param);
        
        public static void GenerateTextureMipmap(int texture) => GLPointers._glGenerateTextureMipmap_fnptr(texture);
        
        public static void BindTextureUnit(uint unit, int texture) => GLPointers._glBindTextureUnit_fnptr(unit, texture);
        
        public static void GetTextureImage(int texture, int level, PixelFormat format, PixelType type, int bufSize, void* pixels) => GLPointers._glGetTextureImage_fnptr(texture, level, (uint)format, (uint)type, bufSize, pixels);
        
        public static void GetCompressedTextureImage(int texture, int level, int bufSize, void* pixels) => GLPointers._glGetCompressedTextureImage_fnptr(texture, level, bufSize, pixels);
        
        public static void GetTextureLevelParameterfv(int texture, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetTextureLevelParameterfv_fnptr(texture, level, (uint)pname, parameters);
        
        public static void GetTextureLevelParameteriv(int texture, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureLevelParameteriv_fnptr(texture, level, (uint)pname, parameters);
        
        public static void GetTextureParameterfv(int texture, GetTextureParameter pname, float* parameters) => GLPointers._glGetTextureParameterfv_fnptr(texture, (uint)pname, parameters);
        
        public static void GetTextureParameterIiv(int texture, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureParameterIiv_fnptr(texture, (uint)pname, parameters);
        
        public static void GetTextureParameterIuiv(int texture, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTextureParameterIuiv_fnptr(texture, (uint)pname, parameters);
        
        public static void GetTextureParameteriv(int texture, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureParameteriv_fnptr(texture, (uint)pname, parameters);
        
        public static void CreateVertexArrays(int n, int* arrays) => GLPointers._glCreateVertexArrays_fnptr(n, arrays);
        
        public static void DisableVertexArrayAttrib(int vaobj, uint index) => GLPointers._glDisableVertexArrayAttrib_fnptr(vaobj, index);
        
        public static void EnableVertexArrayAttrib(int vaobj, uint index) => GLPointers._glEnableVertexArrayAttrib_fnptr(vaobj, index);
        
        public static void VertexArrayElementBuffer(int vaobj, int buffer) => GLPointers._glVertexArrayElementBuffer_fnptr(vaobj, buffer);
        
        public static void VertexArrayVertexBuffer(int vaobj, uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glVertexArrayVertexBuffer_fnptr(vaobj, bindingindex, buffer, offset, stride);
        
        public static void VertexArrayVertexBuffers(int vaobj, uint first, int count, int* buffers, IntPtr* offsets, int* strides) => GLPointers._glVertexArrayVertexBuffers_fnptr(vaobj, first, count, buffers, offsets, strides);
        
        public static void VertexArrayAttribBinding(int vaobj, uint attribindex, uint bindingindex) => GLPointers._glVertexArrayAttribBinding_fnptr(vaobj, attribindex, bindingindex);
        
        public static void VertexArrayAttribFormat(int vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexArrayAttribFormat_fnptr(vaobj, attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
        
        public static void VertexArrayAttribIFormat(int vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexArrayAttribIFormat_fnptr(vaobj, attribindex, size, (uint)type, relativeoffset);
        
        public static void VertexArrayAttribLFormat(int vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => GLPointers._glVertexArrayAttribLFormat_fnptr(vaobj, attribindex, size, (uint)type, relativeoffset);
        
        public static void VertexArrayBindingDivisor(int vaobj, uint bindingindex, uint divisor) => GLPointers._glVertexArrayBindingDivisor_fnptr(vaobj, bindingindex, divisor);
        
        public static void GetVertexArrayiv(int vaobj, VertexArrayPName pname, int* param) => GLPointers._glGetVertexArrayiv_fnptr(vaobj, (uint)pname, param);
        
        public static void GetVertexArrayIndexediv(int vaobj, uint index, VertexArrayPName pname, int* param) => GLPointers._glGetVertexArrayIndexediv_fnptr(vaobj, index, (uint)pname, param);
        
        public static void GetVertexArrayIndexed64iv(int vaobj, uint index, VertexArrayPName pname, long* param) => GLPointers._glGetVertexArrayIndexed64iv_fnptr(vaobj, index, (uint)pname, param);
        
        public static void CreateSamplers(int n, int* samplers) => GLPointers._glCreateSamplers_fnptr(n, samplers);
        
        public static void CreateProgramPipelines(int n, int* pipelines) => GLPointers._glCreateProgramPipelines_fnptr(n, pipelines);
        
        public static void CreateQueries(QueryTarget target, int n, int* ids) => GLPointers._glCreateQueries_fnptr((uint)target, n, ids);
        
        public static void GetQueryBufferObjecti64v(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjecti64v_fnptr(id, buffer, (uint)pname, offset);
        
        public static void GetQueryBufferObjectiv(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjectiv_fnptr(id, buffer, (uint)pname, offset);
        
        public static void GetQueryBufferObjectui64v(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjectui64v_fnptr(id, buffer, (uint)pname, offset);
        
        public static void GetQueryBufferObjectuiv(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjectuiv_fnptr(id, buffer, (uint)pname, offset);
        
        public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrierByRegion_fnptr((uint)barriers);
        
        public static void GetTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, void* pixels) => GLPointers._glGetTextureSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, bufSize, pixels);
        
        public static void GetCompressedTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels) => GLPointers._glGetCompressedTextureSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        
        public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
        
        public static void GetnCompressedTexImage(TextureTarget target, int lod, int bufSize, void* pixels) => GLPointers._glGetnCompressedTexImage_fnptr((uint)target, lod, bufSize, pixels);
        
        public static void GetnTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, void* pixels) => GLPointers._glGetnTexImage_fnptr((uint)target, level, (uint)format, (uint)type, bufSize, pixels);
        
        public static void GetnUniformdv(int program, int location, int bufSize, double* parameters) => GLPointers._glGetnUniformdv_fnptr(program, location, bufSize, parameters);
        
        public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
        
        public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
        
        public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
        
        public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
        
        public static void GetnMapdv(MapTarget target, MapQuery query, int bufSize, double* v) => GLPointers._glGetnMapdv_fnptr((uint)target, (uint)query, bufSize, v);
        
        public static void GetnMapfv(MapTarget target, MapQuery query, int bufSize, float* v) => GLPointers._glGetnMapfv_fnptr((uint)target, (uint)query, bufSize, v);
        
        public static void GetnMapiv(MapTarget target, MapQuery query, int bufSize, int* v) => GLPointers._glGetnMapiv_fnptr((uint)target, (uint)query, bufSize, v);
        
        public static void GetnPixelMapfv(PixelMap map, int bufSize, float* values) => GLPointers._glGetnPixelMapfv_fnptr((uint)map, bufSize, values);
        
        public static void GetnPixelMapuiv(PixelMap map, int bufSize, uint* values) => GLPointers._glGetnPixelMapuiv_fnptr((uint)map, bufSize, values);
        
        public static void GetnPixelMapusv(PixelMap map, int bufSize, ushort* values) => GLPointers._glGetnPixelMapusv_fnptr((uint)map, bufSize, values);
        
        public static void GetnPolygonStipple(int bufSize, byte* pattern) => GLPointers._glGetnPolygonStipple_fnptr(bufSize, pattern);
        
        public static void GetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, int bufSize, void* table) => GLPointers._glGetnColorTable_fnptr((uint)target, (uint)format, (uint)type, bufSize, table);
        
        public static void GetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, int bufSize, void* image) => GLPointers._glGetnConvolutionFilter_fnptr((uint)target, (uint)format, (uint)type, bufSize, image);
        
        public static void GetnSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, int rowBufSize, void* row, int columnBufSize, void* column, void* span) => GLPointers._glGetnSeparableFilter_fnptr((uint)target, (uint)format, (uint)type, rowBufSize, row, columnBufSize, column, span);
        
        public static void GetnHistogram(HistogramTarget target, bool reset, PixelFormat format, PixelType type, int bufSize, void* values) => GLPointers._glGetnHistogram_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, bufSize, values);
        
        public static void GetnMinmax(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, int bufSize, void* values) => GLPointers._glGetnMinmax_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, bufSize, values);
        
        public static void TextureBarrier() => GLPointers._glTextureBarrier_fnptr();
        
        public static void SpecializeShader(int shader, byte* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) => GLPointers._glSpecializeShader_fnptr(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
        
        public static void MultiDrawArraysIndirectCount(PrimitiveType mode, void* indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawArraysIndirectCount_fnptr((uint)mode, indirect, drawcount, maxdrawcount, stride);
        
        public static void MultiDrawElementsIndirectCount(PrimitiveType mode, DrawElementsType type, void* indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawElementsIndirectCount_fnptr((uint)mode, (uint)type, indirect, drawcount, maxdrawcount, stride);
        
        public static void PolygonOffsetClamp(float factor, float units, float clamp) => GLPointers._glPolygonOffsetClamp_fnptr(factor, units, clamp);
        
        /// <summary>_3DFX extensions.</summary>
        public static unsafe partial class _3DFX
        {
            public static void TbufferMask3DFX(uint mask) => GLPointers._glTbufferMask3DFX_fnptr(mask);
            
        }
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            public static void DebugMessageEnableAMD(All category, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageEnableAMD_fnptr((uint)category, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageInsertAMD(All category, DebugSeverity severity, uint id, int length, byte* buf) => GLPointers._glDebugMessageInsertAMD_fnptr((uint)category, (uint)severity, id, length, buf);
            
            public static void DebugMessageCallbackAMD(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallbackAMD_fnptr(callback, userParam);
            
            public static uint GetDebugMessageLogAMD(uint count, int bufSize, All* categories, DebugSeverity* severities, uint* ids, int* lengths, byte* message) => GLPointers._glGetDebugMessageLogAMD_fnptr(count, bufSize, (uint*)categories, (uint*)severities, ids, lengths, message);
            
            public static void BlendFuncIndexedAMD(uint buf, All src, All dst) => GLPointers._glBlendFuncIndexedAMD_fnptr(buf, (uint)src, (uint)dst);
            
            public static void BlendFuncSeparateIndexedAMD(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateIndexedAMD_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            public static void BlendEquationIndexedAMD(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationIndexedAMD_fnptr(buf, (uint)mode);
            
            public static void BlendEquationSeparateIndexedAMD(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateIndexedAMD_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            public static void RenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleAdvancedAMD_fnptr((uint)target, samples, storageSamples, (uint)internalformat, width, height);
            
            public static void NamedRenderbufferStorageMultisampleAdvancedAMD(int renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisampleAdvancedAMD_fnptr(renderbuffer, samples, storageSamples, (uint)internalformat, width, height);
            
            public static void FramebufferSamplePositionsfvAMD(FramebufferTarget target, uint numsamples, uint pixelindex, float* values) => GLPointers._glFramebufferSamplePositionsfvAMD_fnptr((uint)target, numsamples, pixelindex, values);
            
            public static void NamedFramebufferSamplePositionsfvAMD(int framebuffer, uint numsamples, uint pixelindex, float* values) => GLPointers._glNamedFramebufferSamplePositionsfvAMD_fnptr(framebuffer, numsamples, pixelindex, values);
            
            public static void GetFramebufferParameterfvAMD(FramebufferTarget target, FramebufferAttachmentParameterName pname, uint numsamples, uint pixelindex, int size, float* values) => GLPointers._glGetFramebufferParameterfvAMD_fnptr((uint)target, (uint)pname, numsamples, pixelindex, size, values);
            
            public static void GetNamedFramebufferParameterfvAMD(int framebuffer, All pname, uint numsamples, uint pixelindex, int size, float* values) => GLPointers._glGetNamedFramebufferParameterfvAMD_fnptr(framebuffer, (uint)pname, numsamples, pixelindex, size, values);
            
            public static void Uniform1i64NV(int location, long x) => GLPointers._glUniform1i64NV_fnptr(location, x);
            
            public static void Uniform2i64NV(int location, long x, long y) => GLPointers._glUniform2i64NV_fnptr(location, x, y);
            
            public static void Uniform3i64NV(int location, long x, long y, long z) => GLPointers._glUniform3i64NV_fnptr(location, x, y, z);
            
            public static void Uniform4i64NV(int location, long x, long y, long z, long w) => GLPointers._glUniform4i64NV_fnptr(location, x, y, z, w);
            
            public static void Uniform1i64vNV(int location, int count, long* value) => GLPointers._glUniform1i64vNV_fnptr(location, count, value);
            
            public static void Uniform2i64vNV(int location, int count, long* value) => GLPointers._glUniform2i64vNV_fnptr(location, count, value);
            
            public static void Uniform3i64vNV(int location, int count, long* value) => GLPointers._glUniform3i64vNV_fnptr(location, count, value);
            
            public static void Uniform4i64vNV(int location, int count, long* value) => GLPointers._glUniform4i64vNV_fnptr(location, count, value);
            
            public static void Uniform1ui64NV(int location, ulong x) => GLPointers._glUniform1ui64NV_fnptr(location, x);
            
            public static void Uniform2ui64NV(int location, ulong x, ulong y) => GLPointers._glUniform2ui64NV_fnptr(location, x, y);
            
            public static void Uniform3ui64NV(int location, ulong x, ulong y, ulong z) => GLPointers._glUniform3ui64NV_fnptr(location, x, y, z);
            
            public static void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glUniform4ui64NV_fnptr(location, x, y, z, w);
            
            public static void Uniform1ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform1ui64vNV_fnptr(location, count, value);
            
            public static void Uniform2ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform2ui64vNV_fnptr(location, count, value);
            
            public static void Uniform3ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform3ui64vNV_fnptr(location, count, value);
            
            public static void Uniform4ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform4ui64vNV_fnptr(location, count, value);
            
            public static void GetUniformi64vNV(int program, int location, long* parameters) => GLPointers._glGetUniformi64vNV_fnptr(program, location, parameters);
            
            public static void GetUniformui64vNV(int program, int location, ulong* parameters) => GLPointers._glGetUniformui64vNV_fnptr(program, location, parameters);
            
            public static void ProgramUniform1i64NV(int program, int location, long x) => GLPointers._glProgramUniform1i64NV_fnptr(program, location, x);
            
            public static void ProgramUniform2i64NV(int program, int location, long x, long y) => GLPointers._glProgramUniform2i64NV_fnptr(program, location, x, y);
            
            public static void ProgramUniform3i64NV(int program, int location, long x, long y, long z) => GLPointers._glProgramUniform3i64NV_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform4i64NV(int program, int location, long x, long y, long z, long w) => GLPointers._glProgramUniform4i64NV_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform1i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform1i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform2i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform2i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform3i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform3i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform4i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform4i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform1ui64NV(int program, int location, ulong x) => GLPointers._glProgramUniform1ui64NV_fnptr(program, location, x);
            
            public static void ProgramUniform2ui64NV(int program, int location, ulong x, ulong y) => GLPointers._glProgramUniform2ui64NV_fnptr(program, location, x, y);
            
            public static void ProgramUniform3ui64NV(int program, int location, ulong x, ulong y, ulong z) => GLPointers._glProgramUniform3ui64NV_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform4ui64NV(int program, int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glProgramUniform4ui64NV_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform1ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform1ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform2ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform2ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform3ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform3ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform4ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform4ui64vNV_fnptr(program, location, count, value);
            
            public static void VertexAttribParameteriAMD(uint index, All pname, int param) => GLPointers._glVertexAttribParameteriAMD_fnptr(index, (uint)pname, param);
            
            public static void MultiDrawArraysIndirectAMD(PrimitiveType mode, void* indirect, int primcount, int stride) => GLPointers._glMultiDrawArraysIndirectAMD_fnptr((uint)mode, indirect, primcount, stride);
            
            public static void MultiDrawElementsIndirectAMD(PrimitiveType mode, DrawElementsType type, void* indirect, int primcount, int stride) => GLPointers._glMultiDrawElementsIndirectAMD_fnptr((uint)mode, (uint)type, indirect, primcount, stride);
            
            public static void GenNamesAMD(All identifier, uint num, uint* names) => GLPointers._glGenNamesAMD_fnptr((uint)identifier, num, names);
            
            public static void DeleteNamesAMD(All identifier, uint num, uint* names) => GLPointers._glDeleteNamesAMD_fnptr((uint)identifier, num, names);
            
            public static bool IsNameAMD(All identifier, uint name) => GLPointers._glIsNameAMD_fnptr((uint)identifier, name) != 0;
            
            public static void QueryObjectParameteruiAMD(QueryTarget target, int id, All pname, OcclusionQueryEventMaskAMD param) => GLPointers._glQueryObjectParameteruiAMD_fnptr((uint)target, id, (uint)pname, (uint)param);
            
            public static void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups) => GLPointers._glGetPerfMonitorGroupsAMD_fnptr(numGroups, groupsSize, groups);
            
            public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters) => GLPointers._glGetPerfMonitorCountersAMD_fnptr(group, numCounters, maxActiveCounters, counterSize, counters);
            
            public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString) => GLPointers._glGetPerfMonitorGroupStringAMD_fnptr(group, bufSize, length, groupString);
            
            public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString) => GLPointers._glGetPerfMonitorCounterStringAMD_fnptr(group, counter, bufSize, length, counterString);
            
            public static void GetPerfMonitorCounterInfoAMD(uint group, uint counter, All pname, void* data) => GLPointers._glGetPerfMonitorCounterInfoAMD_fnptr(group, counter, (uint)pname, data);
            
            public static void GenPerfMonitorsAMD(int n, uint* monitors) => GLPointers._glGenPerfMonitorsAMD_fnptr(n, monitors);
            
            public static void DeletePerfMonitorsAMD(int n, uint* monitors) => GLPointers._glDeletePerfMonitorsAMD_fnptr(n, monitors);
            
            public static void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, uint* counterList) => GLPointers._glSelectPerfMonitorCountersAMD_fnptr(monitor, (byte)(enable ? 1 : 0), group, numCounters, counterList);
            
            public static void BeginPerfMonitorAMD(uint monitor) => GLPointers._glBeginPerfMonitorAMD_fnptr(monitor);
            
            public static void EndPerfMonitorAMD(uint monitor) => GLPointers._glEndPerfMonitorAMD_fnptr(monitor);
            
            public static void GetPerfMonitorCounterDataAMD(uint monitor, All pname, int dataSize, uint* data, int* bytesWritten) => GLPointers._glGetPerfMonitorCounterDataAMD_fnptr(monitor, (uint)pname, dataSize, data, bytesWritten);
            
            public static void SetMultisamplefvAMD(All pname, uint index, float* val) => GLPointers._glSetMultisamplefvAMD_fnptr((uint)pname, index, val);
            
            public static void TexStorageSparseAMD(TextureTarget target, SizedInternalFormat internalFormat, int width, int height, int depth, int layers, TextureStorageMaskAMD flags) => GLPointers._glTexStorageSparseAMD_fnptr((uint)target, (uint)internalFormat, width, height, depth, layers, (uint)flags);
            
            public static void TextureStorageSparseAMD(int texture, All target, SizedInternalFormat internalFormat, int width, int height, int depth, int layers, TextureStorageMaskAMD flags) => GLPointers._glTextureStorageSparseAMD_fnptr(texture, (uint)target, (uint)internalFormat, width, height, depth, layers, (uint)flags);
            
            public static void StencilOpValueAMD(TriangleFace face, uint value) => GLPointers._glStencilOpValueAMD_fnptr((uint)face, value);
            
            public static void TessellationFactorAMD(float factor) => GLPointers._glTessellationFactorAMD_fnptr(factor);
            
            public static void TessellationModeAMD(All mode) => GLPointers._glTessellationModeAMD_fnptr((uint)mode);
            
        }
        /// <summary>APPLE extensions.</summary>
        public static unsafe partial class APPLE
        {
            public static void ElementPointerAPPLE(ElementPointerTypeATI type, void* pointer) => GLPointers._glElementPointerAPPLE_fnptr((uint)type, pointer);
            
            public static void DrawElementArrayAPPLE(PrimitiveType mode, int first, int count) => GLPointers._glDrawElementArrayAPPLE_fnptr((uint)mode, first, count);
            
            public static void DrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int first, int count) => GLPointers._glDrawRangeElementArrayAPPLE_fnptr((uint)mode, start, end, first, count);
            
            public static void MultiDrawElementArrayAPPLE(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._glMultiDrawElementArrayAPPLE_fnptr((uint)mode, first, count, primcount);
            
            public static void MultiDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int* first, int* count, int primcount) => GLPointers._glMultiDrawRangeElementArrayAPPLE_fnptr((uint)mode, start, end, first, count, primcount);
            
            public static void GenFencesAPPLE(int n, uint* fences) => GLPointers._glGenFencesAPPLE_fnptr(n, fences);
            
            public static void DeleteFencesAPPLE(int n, uint* fences) => GLPointers._glDeleteFencesAPPLE_fnptr(n, fences);
            
            public static void SetFenceAPPLE(uint fence) => GLPointers._glSetFenceAPPLE_fnptr(fence);
            
            public static bool IsFenceAPPLE(uint fence) => GLPointers._glIsFenceAPPLE_fnptr(fence) != 0;
            
            public static bool TestFenceAPPLE(uint fence) => GLPointers._glTestFenceAPPLE_fnptr(fence) != 0;
            
            public static void FinishFenceAPPLE(uint fence) => GLPointers._glFinishFenceAPPLE_fnptr(fence);
            
            public static bool TestObjectAPPLE(ObjectTypeAPPLE obj, uint name) => GLPointers._glTestObjectAPPLE_fnptr((uint)obj, name) != 0;
            
            public static void FinishObjectAPPLE(ObjectTypeAPPLE obj, int name) => GLPointers._glFinishObjectAPPLE_fnptr((uint)obj, name);
            
            public static void BufferParameteriAPPLE(All target, All pname, int param) => GLPointers._glBufferParameteriAPPLE_fnptr((uint)target, (uint)pname, param);
            
            public static void FlushMappedBufferRangeAPPLE(BufferTargetARB target, IntPtr offset, nint size) => GLPointers._glFlushMappedBufferRangeAPPLE_fnptr((uint)target, offset, size);
            
            public static All ObjectPurgeableAPPLE(All objectType, uint name, All option) => (All) GLPointers._glObjectPurgeableAPPLE_fnptr((uint)objectType, name, (uint)option);
            
            public static All ObjectUnpurgeableAPPLE(All objectType, uint name, All option) => (All) GLPointers._glObjectUnpurgeableAPPLE_fnptr((uint)objectType, name, (uint)option);
            
            public static void GetObjectParameterivAPPLE(All objectType, uint name, All pname, int* parameters) => GLPointers._glGetObjectParameterivAPPLE_fnptr((uint)objectType, name, (uint)pname, parameters);
            
            public static void TextureRangeAPPLE(All target, int length, void* pointer) => GLPointers._glTextureRangeAPPLE_fnptr((uint)target, length, pointer);
            
            public static void GetTexParameterPointervAPPLE(All target, All pname, void** parameters) => GLPointers._glGetTexParameterPointervAPPLE_fnptr((uint)target, (uint)pname, parameters);
            
            public static void BindVertexArrayAPPLE(int array) => GLPointers._glBindVertexArrayAPPLE_fnptr(array);
            
            public static void DeleteVertexArraysAPPLE(int n, int* arrays) => GLPointers._glDeleteVertexArraysAPPLE_fnptr(n, arrays);
            
            public static void GenVertexArraysAPPLE(int n, int* arrays) => GLPointers._glGenVertexArraysAPPLE_fnptr(n, arrays);
            
            public static bool IsVertexArrayAPPLE(int array) => GLPointers._glIsVertexArrayAPPLE_fnptr(array) != 0;
            
            public static void VertexArrayRangeAPPLE(int length, void* pointer) => GLPointers._glVertexArrayRangeAPPLE_fnptr(length, pointer);
            
            public static void FlushVertexArrayRangeAPPLE(int length, void* pointer) => GLPointers._glFlushVertexArrayRangeAPPLE_fnptr(length, pointer);
            
            public static void VertexArrayParameteriAPPLE(VertexArrayPNameAPPLE pname, int param) => GLPointers._glVertexArrayParameteriAPPLE_fnptr((uint)pname, param);
            
            public static void EnableVertexAttribAPPLE(uint index, All pname) => GLPointers._glEnableVertexAttribAPPLE_fnptr(index, (uint)pname);
            
            public static void DisableVertexAttribAPPLE(uint index, All pname) => GLPointers._glDisableVertexAttribAPPLE_fnptr(index, (uint)pname);
            
            public static bool IsVertexAttribEnabledAPPLE(uint index, All pname) => GLPointers._glIsVertexAttribEnabledAPPLE_fnptr(index, (uint)pname) != 0;
            
            public static void MapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double* points) => GLPointers._glMapVertexAttrib1dAPPLE_fnptr(index, size, u1, u2, stride, order, points);
            
            public static void MapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float* points) => GLPointers._glMapVertexAttrib1fAPPLE_fnptr(index, size, u1, u2, stride, order, points);
            
            public static void MapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points) => GLPointers._glMapVertexAttrib2dAPPLE_fnptr(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            
            public static void MapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points) => GLPointers._glMapVertexAttrib2fAPPLE_fnptr(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            
        }
        /// <summary>ARB extensions.</summary>
        public static unsafe partial class ARB
        {
            public static void ReleaseShaderCompiler() => GLPointers._glReleaseShaderCompiler_fnptr();
            
            public static void ShaderBinary(int count, int* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length) => GLPointers._glShaderBinary_fnptr(count, shaders, (uint)binaryFormat, binary, length);
            
            public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => GLPointers._glGetShaderPrecisionFormat_fnptr((uint)shadertype, (uint)precisiontype, range, precision);
            
            public static void DepthRangef(float n, float f) => GLPointers._glDepthRangef_fnptr(n, f);
            
            public static void ClearDepthf(float d) => GLPointers._glClearDepthf_fnptr(d);
            
            public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrierByRegion_fnptr((uint)barriers);
            
            public static void PrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBoxARB_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance) => GLPointers._glDrawArraysInstancedBaseInstance_fnptr((uint)mode, first, count, instancecount, baseinstance);
            
            public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseInstance_fnptr((uint)mode, count, (uint)type, indices, instancecount, baseinstance);
            
            public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseVertexBaseInstance_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex, baseinstance);
            
            public static ulong GetTextureHandleARB(int texture) => GLPointers._glGetTextureHandleARB_fnptr(texture);
            
            public static ulong GetTextureSamplerHandleARB(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleARB_fnptr(texture, sampler);
            
            public static void MakeTextureHandleResidentARB(ulong handle) => GLPointers._glMakeTextureHandleResidentARB_fnptr(handle);
            
            public static void MakeTextureHandleNonResidentARB(ulong handle) => GLPointers._glMakeTextureHandleNonResidentARB_fnptr(handle);
            
            public static ulong GetImageHandleARB(int texture, int level, bool layered, int layer, PixelFormat format) => GLPointers._glGetImageHandleARB_fnptr(texture, level, (byte)(layered ? 1 : 0), layer, (uint)format);
            
            public static void MakeImageHandleResidentARB(ulong handle, All access) => GLPointers._glMakeImageHandleResidentARB_fnptr(handle, (uint)access);
            
            public static void MakeImageHandleNonResidentARB(ulong handle) => GLPointers._glMakeImageHandleNonResidentARB_fnptr(handle);
            
            public static void UniformHandleui64ARB(int location, ulong value) => GLPointers._glUniformHandleui64ARB_fnptr(location, value);
            
            public static void UniformHandleui64vARB(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vARB_fnptr(location, count, value);
            
            public static void ProgramUniformHandleui64ARB(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64ARB_fnptr(program, location, value);
            
            public static void ProgramUniformHandleui64vARB(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vARB_fnptr(program, location, count, values);
            
            public static bool IsTextureHandleResidentARB(ulong handle) => GLPointers._glIsTextureHandleResidentARB_fnptr(handle) != 0;
            
            public static bool IsImageHandleResidentARB(ulong handle) => GLPointers._glIsImageHandleResidentARB_fnptr(handle) != 0;
            
            public static void VertexAttribL1ui64ARB(uint index, ulong x) => GLPointers._glVertexAttribL1ui64ARB_fnptr(index, x);
            
            public static void VertexAttribL1ui64vARB(uint index, ulong* v) => GLPointers._glVertexAttribL1ui64vARB_fnptr(index, v);
            
            public static void GetVertexAttribLui64vARB(uint index, VertexAttribEnum pname, ulong* parameters) => GLPointers._glGetVertexAttribLui64vARB_fnptr(index, (uint)pname, parameters);
            
            public static void BindFragDataLocationIndexed(int program, uint colorNumber, uint index, byte* name) => GLPointers._glBindFragDataLocationIndexed_fnptr(program, colorNumber, index, name);
            
            public static int GetFragDataIndex(int program, byte* name) => GLPointers._glGetFragDataIndex_fnptr(program, name);
            
            public static void BufferStorage(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags) => GLPointers._glBufferStorage_fnptr((uint)target, size, data, (uint)flags);
            
            public static GLSync CreateSyncFromCLeventARB(CLContext* context, CLEvent* @event, uint flags) => (GLSync) GLPointers._glCreateSyncFromCLeventARB_fnptr((IntPtr*)context, (IntPtr*)@event, flags);
            
            public static void ClearBufferData(BufferStorageTarget target, SizedInternalFormat internalformat, PixelFormat format, PixelType type, void* data) => GLPointers._glClearBufferData_fnptr((uint)target, (uint)internalformat, (uint)format, (uint)type, data);
            
            public static void ClearBufferSubData(BufferTargetARB target, SizedInternalFormat internalformat, IntPtr offset, nint size, PixelFormat format, PixelType type, void* data) => GLPointers._glClearBufferSubData_fnptr((uint)target, (uint)internalformat, offset, size, (uint)format, (uint)type, data);
            
            public static void ClearTexImage(int texture, int level, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexImage_fnptr(texture, level, (uint)format, (uint)type, data);
            
            public static void ClearTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, data);
            
            public static void ClipControl(ClipControlOrigin origin, ClipControlDepth depth) => GLPointers._glClipControl_fnptr((uint)origin, (uint)depth);
            
            public static void ClampColorARB(ClampColorTargetARB target, ClampColorModeARB clamp) => GLPointers._glClampColorARB_fnptr((uint)target, (uint)clamp);
            
            public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => GLPointers._glDispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
            
            public static void DispatchComputeIndirect(IntPtr indirect) => GLPointers._glDispatchComputeIndirect_fnptr(indirect);
            
            public static void DispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z) => GLPointers._glDispatchComputeGroupSizeARB_fnptr(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z);
            
            public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubData_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            public static void CopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubData_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            public static void DebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControlARB_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsertARB_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            public static void DebugMessageCallbackARB(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallbackARB_fnptr(callback, userParam);
            
            public static uint GetDebugMessageLogARB(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLogARB_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            public static void CreateTransformFeedbacks(int n, int* ids) => GLPointers._glCreateTransformFeedbacks_fnptr(n, ids);
            
            public static void TransformFeedbackBufferBase(int xfb, uint index, int buffer) => GLPointers._glTransformFeedbackBufferBase_fnptr(xfb, index, buffer);
            
            public static void TransformFeedbackBufferRange(int xfb, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glTransformFeedbackBufferRange_fnptr(xfb, index, buffer, offset, size);
            
            public static void GetTransformFeedbackiv(int xfb, TransformFeedbackPName pname, int* param) => GLPointers._glGetTransformFeedbackiv_fnptr(xfb, (uint)pname, param);
            
            public static void GetTransformFeedbacki_v(int xfb, TransformFeedbackPName pname, uint index, int* param) => GLPointers._glGetTransformFeedbacki_v_fnptr(xfb, (uint)pname, index, param);
            
            public static void GetTransformFeedbacki64_v(int xfb, TransformFeedbackPName pname, uint index, long* param) => GLPointers._glGetTransformFeedbacki64_v_fnptr(xfb, (uint)pname, index, param);
            
            public static void CreateBuffers(int n, int* buffers) => GLPointers._glCreateBuffers_fnptr(n, buffers);
            
            public static void NamedBufferStorage(int buffer, nint size, void* data, BufferStorageMask flags) => GLPointers._glNamedBufferStorage_fnptr(buffer, size, data, (uint)flags);
            
            public static void NamedBufferData(int buffer, nint size, void* data, VertexBufferObjectUsage usage) => GLPointers._glNamedBufferData_fnptr(buffer, size, data, (uint)usage);
            
            public static void NamedBufferSubData(int buffer, IntPtr offset, nint size, void* data) => GLPointers._glNamedBufferSubData_fnptr(buffer, offset, size, data);
            
            public static void CopyNamedBufferSubData(int readBuffer, int writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyNamedBufferSubData_fnptr(readBuffer, writeBuffer, readOffset, writeOffset, size);
            
            public static void ClearNamedBufferData(int buffer, SizedInternalFormat internalformat, PixelFormat format, PixelType type, void* data) => GLPointers._glClearNamedBufferData_fnptr(buffer, (uint)internalformat, (uint)format, (uint)type, data);
            
            public static void ClearNamedBufferSubData(int buffer, SizedInternalFormat internalformat, IntPtr offset, nint size, PixelFormat format, PixelType type, void* data) => GLPointers._glClearNamedBufferSubData_fnptr(buffer, (uint)internalformat, offset, size, (uint)format, (uint)type, data);
            
            public static void* MapNamedBuffer(int buffer, BufferAccessARB access) => GLPointers._glMapNamedBuffer_fnptr(buffer, (uint)access);
            
            public static void* MapNamedBufferRange(int buffer, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapNamedBufferRange_fnptr(buffer, offset, length, (uint)access);
            
            public static bool UnmapNamedBuffer(int buffer) => GLPointers._glUnmapNamedBuffer_fnptr(buffer) != 0;
            
            public static void FlushMappedNamedBufferRange(int buffer, IntPtr offset, nint length) => GLPointers._glFlushMappedNamedBufferRange_fnptr(buffer, offset, length);
            
            public static void GetNamedBufferParameteriv(int buffer, BufferPNameARB pname, int* parameters) => GLPointers._glGetNamedBufferParameteriv_fnptr(buffer, (uint)pname, parameters);
            
            public static void GetNamedBufferParameteri64v(int buffer, BufferPNameARB pname, long* parameters) => GLPointers._glGetNamedBufferParameteri64v_fnptr(buffer, (uint)pname, parameters);
            
            public static void GetNamedBufferPointerv(int buffer, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetNamedBufferPointerv_fnptr(buffer, (uint)pname, parameters);
            
            public static void GetNamedBufferSubData(int buffer, IntPtr offset, nint size, void* data) => GLPointers._glGetNamedBufferSubData_fnptr(buffer, offset, size, data);
            
            public static void CreateFramebuffers(int n, int* framebuffers) => GLPointers._glCreateFramebuffers_fnptr(n, framebuffers);
            
            public static void NamedFramebufferRenderbuffer(int framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glNamedFramebufferRenderbuffer_fnptr(framebuffer, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
            
            public static void NamedFramebufferParameteri(int framebuffer, FramebufferParameterName pname, int param) => GLPointers._glNamedFramebufferParameteri_fnptr(framebuffer, (uint)pname, param);
            
            public static void NamedFramebufferTexture(int framebuffer, FramebufferAttachment attachment, int texture, int level) => GLPointers._glNamedFramebufferTexture_fnptr(framebuffer, (uint)attachment, texture, level);
            
            public static void NamedFramebufferTextureLayer(int framebuffer, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glNamedFramebufferTextureLayer_fnptr(framebuffer, (uint)attachment, texture, level, layer);
            
            public static void NamedFramebufferDrawBuffer(int framebuffer, ColorBuffer buf) => GLPointers._glNamedFramebufferDrawBuffer_fnptr(framebuffer, (uint)buf);
            
            public static void NamedFramebufferDrawBuffers(int framebuffer, int n, ColorBuffer* bufs) => GLPointers._glNamedFramebufferDrawBuffers_fnptr(framebuffer, n, (uint*)bufs);
            
            public static void NamedFramebufferReadBuffer(int framebuffer, ColorBuffer src) => GLPointers._glNamedFramebufferReadBuffer_fnptr(framebuffer, (uint)src);
            
            public static void InvalidateNamedFramebufferData(int framebuffer, int numAttachments, FramebufferAttachment* attachments) => GLPointers._glInvalidateNamedFramebufferData_fnptr(framebuffer, numAttachments, (uint*)attachments);
            
            public static void InvalidateNamedFramebufferSubData(int framebuffer, int numAttachments, FramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._glInvalidateNamedFramebufferSubData_fnptr(framebuffer, numAttachments, (uint*)attachments, x, y, width, height);
            
            public static void ClearNamedFramebufferiv(int framebuffer, Buffer buffer, int drawbuffer, int* value) => GLPointers._glClearNamedFramebufferiv_fnptr(framebuffer, (uint)buffer, drawbuffer, value);
            
            public static void ClearNamedFramebufferuiv(int framebuffer, Buffer buffer, int drawbuffer, uint* value) => GLPointers._glClearNamedFramebufferuiv_fnptr(framebuffer, (uint)buffer, drawbuffer, value);
            
            public static void ClearNamedFramebufferfv(int framebuffer, Buffer buffer, int drawbuffer, float* value) => GLPointers._glClearNamedFramebufferfv_fnptr(framebuffer, (uint)buffer, drawbuffer, value);
            
            public static void ClearNamedFramebufferfi(int framebuffer, Buffer buffer, int drawbuffer, float depth, int stencil) => GLPointers._glClearNamedFramebufferfi_fnptr(framebuffer, (uint)buffer, drawbuffer, depth, stencil);
            
            public static void BlitNamedFramebuffer(int readFramebuffer, int drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitNamedFramebuffer_fnptr(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static FramebufferStatus CheckNamedFramebufferStatus(int framebuffer, FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckNamedFramebufferStatus_fnptr(framebuffer, (uint)target);
            
            public static void GetNamedFramebufferParameteriv(int framebuffer, GetFramebufferParameter pname, int* param) => GLPointers._glGetNamedFramebufferParameteriv_fnptr(framebuffer, (uint)pname, param);
            
            public static void GetNamedFramebufferAttachmentParameteriv(int framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetNamedFramebufferAttachmentParameteriv_fnptr(framebuffer, (uint)attachment, (uint)pname, parameters);
            
            public static void CreateRenderbuffers(int n, int* renderbuffers) => GLPointers._glCreateRenderbuffers_fnptr(n, renderbuffers);
            
            public static void NamedRenderbufferStorage(int renderbuffer, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorage_fnptr(renderbuffer, (uint)internalformat, width, height);
            
            public static void NamedRenderbufferStorageMultisample(int renderbuffer, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisample_fnptr(renderbuffer, samples, (uint)internalformat, width, height);
            
            public static void GetNamedRenderbufferParameteriv(int renderbuffer, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetNamedRenderbufferParameteriv_fnptr(renderbuffer, (uint)pname, parameters);
            
            public static void CreateTextures(TextureTarget target, int n, int* textures) => GLPointers._glCreateTextures_fnptr((uint)target, n, textures);
            
            public static void TextureBuffer(int texture, SizedInternalFormat internalformat, int buffer) => GLPointers._glTextureBuffer_fnptr(texture, (uint)internalformat, buffer);
            
            public static void TextureBufferRange(int texture, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTextureBufferRange_fnptr(texture, (uint)internalformat, buffer, offset, size);
            
            public static void TextureStorage1D(int texture, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTextureStorage1D_fnptr(texture, levels, (uint)internalformat, width);
            
            public static void TextureStorage2D(int texture, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTextureStorage2D_fnptr(texture, levels, (uint)internalformat, width, height);
            
            public static void TextureStorage3D(int texture, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTextureStorage3D_fnptr(texture, levels, (uint)internalformat, width, height, depth);
            
            public static void TextureStorage2DMultisample(int texture, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTextureStorage2DMultisample_fnptr(texture, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void TextureStorage3DMultisample(int texture, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTextureStorage3DMultisample_fnptr(texture, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void TextureSubImage1D(int texture, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage1D_fnptr(texture, level, xoffset, width, (uint)format, (uint)type, pixels);
            
            public static void TextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage2D_fnptr(texture, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
            
            public static void TextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage3D_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            public static void CompressedTextureSubImage1D(int texture, int level, int xoffset, int width, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTextureSubImage1D_fnptr(texture, level, xoffset, width, (uint)format, imageSize, data);
            
            public static void CompressedTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTextureSubImage2D_fnptr(texture, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
            
            public static void CompressedTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTextureSubImage3D_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
            
            public static void CopyTextureSubImage1D(int texture, int level, int xoffset, int x, int y, int width) => GLPointers._glCopyTextureSubImage1D_fnptr(texture, level, xoffset, x, y, width);
            
            public static void CopyTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTextureSubImage2D_fnptr(texture, level, xoffset, yoffset, x, y, width, height);
            
            public static void CopyTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTextureSubImage3D_fnptr(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            public static void TextureParameterf(int texture, TextureParameterName pname, float param) => GLPointers._glTextureParameterf_fnptr(texture, (uint)pname, param);
            
            public static void TextureParameterfv(int texture, TextureParameterName pname, float* param) => GLPointers._glTextureParameterfv_fnptr(texture, (uint)pname, param);
            
            public static void TextureParameteri(int texture, TextureParameterName pname, int param) => GLPointers._glTextureParameteri_fnptr(texture, (uint)pname, param);
            
            public static void TextureParameterIiv(int texture, TextureParameterName pname, int* parameters) => GLPointers._glTextureParameterIiv_fnptr(texture, (uint)pname, parameters);
            
            public static void TextureParameterIuiv(int texture, TextureParameterName pname, uint* parameters) => GLPointers._glTextureParameterIuiv_fnptr(texture, (uint)pname, parameters);
            
            public static void TextureParameteriv(int texture, TextureParameterName pname, int* param) => GLPointers._glTextureParameteriv_fnptr(texture, (uint)pname, param);
            
            public static void GenerateTextureMipmap(int texture) => GLPointers._glGenerateTextureMipmap_fnptr(texture);
            
            public static void BindTextureUnit(uint unit, int texture) => GLPointers._glBindTextureUnit_fnptr(unit, texture);
            
            public static void GetTextureImage(int texture, int level, PixelFormat format, PixelType type, int bufSize, void* pixels) => GLPointers._glGetTextureImage_fnptr(texture, level, (uint)format, (uint)type, bufSize, pixels);
            
            public static void GetCompressedTextureImage(int texture, int level, int bufSize, void* pixels) => GLPointers._glGetCompressedTextureImage_fnptr(texture, level, bufSize, pixels);
            
            public static void GetTextureLevelParameterfv(int texture, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetTextureLevelParameterfv_fnptr(texture, level, (uint)pname, parameters);
            
            public static void GetTextureLevelParameteriv(int texture, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureLevelParameteriv_fnptr(texture, level, (uint)pname, parameters);
            
            public static void GetTextureParameterfv(int texture, GetTextureParameter pname, float* parameters) => GLPointers._glGetTextureParameterfv_fnptr(texture, (uint)pname, parameters);
            
            public static void GetTextureParameterIiv(int texture, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureParameterIiv_fnptr(texture, (uint)pname, parameters);
            
            public static void GetTextureParameterIuiv(int texture, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTextureParameterIuiv_fnptr(texture, (uint)pname, parameters);
            
            public static void GetTextureParameteriv(int texture, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureParameteriv_fnptr(texture, (uint)pname, parameters);
            
            public static void CreateVertexArrays(int n, int* arrays) => GLPointers._glCreateVertexArrays_fnptr(n, arrays);
            
            public static void DisableVertexArrayAttrib(int vaobj, uint index) => GLPointers._glDisableVertexArrayAttrib_fnptr(vaobj, index);
            
            public static void EnableVertexArrayAttrib(int vaobj, uint index) => GLPointers._glEnableVertexArrayAttrib_fnptr(vaobj, index);
            
            public static void VertexArrayElementBuffer(int vaobj, int buffer) => GLPointers._glVertexArrayElementBuffer_fnptr(vaobj, buffer);
            
            public static void VertexArrayVertexBuffer(int vaobj, uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glVertexArrayVertexBuffer_fnptr(vaobj, bindingindex, buffer, offset, stride);
            
            public static void VertexArrayVertexBuffers(int vaobj, uint first, int count, int* buffers, IntPtr* offsets, int* strides) => GLPointers._glVertexArrayVertexBuffers_fnptr(vaobj, first, count, buffers, offsets, strides);
            
            public static void VertexArrayAttribBinding(int vaobj, uint attribindex, uint bindingindex) => GLPointers._glVertexArrayAttribBinding_fnptr(vaobj, attribindex, bindingindex);
            
            public static void VertexArrayAttribFormat(int vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexArrayAttribFormat_fnptr(vaobj, attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
            
            public static void VertexArrayAttribIFormat(int vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexArrayAttribIFormat_fnptr(vaobj, attribindex, size, (uint)type, relativeoffset);
            
            public static void VertexArrayAttribLFormat(int vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => GLPointers._glVertexArrayAttribLFormat_fnptr(vaobj, attribindex, size, (uint)type, relativeoffset);
            
            public static void VertexArrayBindingDivisor(int vaobj, uint bindingindex, uint divisor) => GLPointers._glVertexArrayBindingDivisor_fnptr(vaobj, bindingindex, divisor);
            
            public static void GetVertexArrayiv(int vaobj, VertexArrayPName pname, int* param) => GLPointers._glGetVertexArrayiv_fnptr(vaobj, (uint)pname, param);
            
            public static void GetVertexArrayIndexediv(int vaobj, uint index, VertexArrayPName pname, int* param) => GLPointers._glGetVertexArrayIndexediv_fnptr(vaobj, index, (uint)pname, param);
            
            public static void GetVertexArrayIndexed64iv(int vaobj, uint index, VertexArrayPName pname, long* param) => GLPointers._glGetVertexArrayIndexed64iv_fnptr(vaobj, index, (uint)pname, param);
            
            public static void CreateSamplers(int n, int* samplers) => GLPointers._glCreateSamplers_fnptr(n, samplers);
            
            public static void CreateProgramPipelines(int n, int* pipelines) => GLPointers._glCreateProgramPipelines_fnptr(n, pipelines);
            
            public static void CreateQueries(QueryTarget target, int n, int* ids) => GLPointers._glCreateQueries_fnptr((uint)target, n, ids);
            
            public static void GetQueryBufferObjecti64v(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjecti64v_fnptr(id, buffer, (uint)pname, offset);
            
            public static void GetQueryBufferObjectiv(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjectiv_fnptr(id, buffer, (uint)pname, offset);
            
            public static void GetQueryBufferObjectui64v(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjectui64v_fnptr(id, buffer, (uint)pname, offset);
            
            public static void GetQueryBufferObjectuiv(int id, int buffer, QueryObjectParameterName pname, IntPtr offset) => GLPointers._glGetQueryBufferObjectuiv_fnptr(id, buffer, (uint)pname, offset);
            
            public static void DrawBuffersARB(int n, DrawBufferMode* bufs) => GLPointers._glDrawBuffersARB_fnptr(n, (uint*)bufs);
            
            public static void BlendEquationiARB(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationiARB_fnptr(buf, (uint)mode);
            
            public static void BlendEquationSeparateiARB(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateiARB_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            public static void BlendFunciARB(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunciARB_fnptr(buf, (uint)src, (uint)dst);
            
            public static void BlendFuncSeparateiARB(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateiARB_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertex_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertex_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            public static void MultiDrawElementsBaseVertex(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            public static void DrawArraysIndirect(PrimitiveType mode, void* indirect) => GLPointers._glDrawArraysIndirect_fnptr((uint)mode, indirect);
            
            public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => GLPointers._glDrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect);
            
            public static void DrawArraysInstancedARB(PrimitiveType mode, int first, int count, int primcount) => GLPointers._glDrawArraysInstancedARB_fnptr((uint)mode, first, count, primcount);
            
            public static void DrawElementsInstancedARB(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedARB_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void ProgramStringARB(ProgramTarget target, ProgramFormat format, int len, void* str) => GLPointers._glProgramStringARB_fnptr((uint)target, (uint)format, len, str);
            
            public static void BindProgramARB(ProgramTarget target, int program) => GLPointers._glBindProgramARB_fnptr((uint)target, program);
            
            public static void DeleteProgramsARB(int n, int* programs) => GLPointers._glDeleteProgramsARB_fnptr(n, programs);
            
            public static void GenProgramsARB(int n, int* programs) => GLPointers._glGenProgramsARB_fnptr(n, programs);
            
            public static void ProgramEnvParameter4dARB(ProgramTarget target, uint index, double x, double y, double z, double w) => GLPointers._glProgramEnvParameter4dARB_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramEnvParameter4dvARB(ProgramTarget target, uint index, double* parameters) => GLPointers._glProgramEnvParameter4dvARB_fnptr((uint)target, index, parameters);
            
            public static void ProgramEnvParameter4fARB(ProgramTarget target, uint index, float x, float y, float z, float w) => GLPointers._glProgramEnvParameter4fARB_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramEnvParameter4fvARB(ProgramTarget target, uint index, float* parameters) => GLPointers._glProgramEnvParameter4fvARB_fnptr((uint)target, index, parameters);
            
            public static void ProgramLocalParameter4dARB(ProgramTarget target, uint index, double x, double y, double z, double w) => GLPointers._glProgramLocalParameter4dARB_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramLocalParameter4dvARB(ProgramTarget target, uint index, double* parameters) => GLPointers._glProgramLocalParameter4dvARB_fnptr((uint)target, index, parameters);
            
            public static void ProgramLocalParameter4fARB(ProgramTarget target, uint index, float x, float y, float z, float w) => GLPointers._glProgramLocalParameter4fARB_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramLocalParameter4fvARB(ProgramTarget target, uint index, float* parameters) => GLPointers._glProgramLocalParameter4fvARB_fnptr((uint)target, index, parameters);
            
            public static void GetProgramEnvParameterdvARB(ProgramTarget target, uint index, double* parameters) => GLPointers._glGetProgramEnvParameterdvARB_fnptr((uint)target, index, parameters);
            
            public static void GetProgramEnvParameterfvARB(ProgramTarget target, uint index, float* parameters) => GLPointers._glGetProgramEnvParameterfvARB_fnptr((uint)target, index, parameters);
            
            public static void GetProgramLocalParameterdvARB(ProgramTarget target, uint index, double* parameters) => GLPointers._glGetProgramLocalParameterdvARB_fnptr((uint)target, index, parameters);
            
            public static void GetProgramLocalParameterfvARB(ProgramTarget target, uint index, float* parameters) => GLPointers._glGetProgramLocalParameterfvARB_fnptr((uint)target, index, parameters);
            
            public static void GetProgramivARB(ProgramTarget target, ProgramPropertyARB pname, int* parameters) => GLPointers._glGetProgramivARB_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetProgramStringARB(ProgramTarget target, ProgramStringProperty pname, void* str) => GLPointers._glGetProgramStringARB_fnptr((uint)target, (uint)pname, str);
            
            public static bool IsProgramARB(int program) => GLPointers._glIsProgramARB_fnptr(program) != 0;
            
            public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteri_fnptr((uint)target, (uint)pname, param);
            
            public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static bool IsRenderbuffer(int renderbuffer) => GLPointers._glIsRenderbuffer_fnptr(renderbuffer) != 0;
            
            public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbuffer_fnptr((uint)target, renderbuffer);
            
            public static void DeleteRenderbuffers(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffers_fnptr(n, renderbuffers);
            
            public static void GenRenderbuffers(int n, int* renderbuffers) => GLPointers._glGenRenderbuffers_fnptr(n, renderbuffers);
            
            public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorage_fnptr((uint)target, (uint)internalformat, width, height);
            
            public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static bool IsFramebuffer(int framebuffer) => GLPointers._glIsFramebuffer_fnptr(framebuffer) != 0;
            
            public static void BindFramebuffer(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebuffer_fnptr((uint)target, framebuffer);
            
            public static void DeleteFramebuffers(int n, int* framebuffers) => GLPointers._glDeleteFramebuffers_fnptr(n, framebuffers);
            
            public static void GenFramebuffers(int n, int* framebuffers) => GLPointers._glGenFramebuffers_fnptr(n, framebuffers);
            
            public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatus_fnptr((uint)target);
            
            public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture1D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
            
            public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
            
            public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset) => GLPointers._glFramebufferTexture3D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, zoffset);
            
            public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbuffer_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
            
            public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameteriv_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
            
            public static void GenerateMipmap(TextureTarget target) => GLPointers._glGenerateMipmap_fnptr((uint)target);
            
            public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebuffer_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayer_fnptr((uint)target, (uint)attachment, texture, level, layer);
            
            public static void ProgramParameteriARB(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteriARB_fnptr(program, (uint)pname, value);
            
            public static void FramebufferTextureARB(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureARB_fnptr((uint)target, (uint)attachment, texture, level);
            
            public static void FramebufferTextureLayerARB(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayerARB_fnptr((uint)target, (uint)attachment, texture, level, layer);
            
            public static void FramebufferTextureFaceARB(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, TextureTarget face) => GLPointers._glFramebufferTextureFaceARB_fnptr((uint)target, (uint)attachment, texture, level, (uint)face);
            
            public static void GetProgramBinary(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinary_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
            
            public static void ProgramBinary(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinary_fnptr(program, (uint)binaryFormat, binary, length);
            
            public static void ProgramParameteri(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteri_fnptr(program, (uint)pname, value);
            
            public static void GetTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int bufSize, void* pixels) => GLPointers._glGetTextureSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, bufSize, pixels);
            
            public static void GetCompressedTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels) => GLPointers._glGetCompressedTextureSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
            
            public static void SpecializeShaderARB(int shader, byte* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) => GLPointers._glSpecializeShaderARB_fnptr(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
            
            public static void Uniform1d(int location, double x) => GLPointers._glUniform1d_fnptr(location, x);
            
            public static void Uniform2d(int location, double x, double y) => GLPointers._glUniform2d_fnptr(location, x, y);
            
            public static void Uniform3d(int location, double x, double y, double z) => GLPointers._glUniform3d_fnptr(location, x, y, z);
            
            public static void Uniform4d(int location, double x, double y, double z, double w) => GLPointers._glUniform4d_fnptr(location, x, y, z, w);
            
            public static void Uniform1dv(int location, int count, double* value) => GLPointers._glUniform1dv_fnptr(location, count, value);
            
            public static void Uniform2dv(int location, int count, double* value) => GLPointers._glUniform2dv_fnptr(location, count, value);
            
            public static void Uniform3dv(int location, int count, double* value) => GLPointers._glUniform3dv_fnptr(location, count, value);
            
            public static void Uniform4dv(int location, int count, double* value) => GLPointers._glUniform4dv_fnptr(location, count, value);
            
            public static void UniformMatrix2dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix2dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix3dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix3dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix4dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix4dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix2x3dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix2x3dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix2x4dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix2x4dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix3x2dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix3x2dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix3x4dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix3x4dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix4x2dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix4x2dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix4x3dv(int location, int count, bool transpose, double* value) => GLPointers._glUniformMatrix4x3dv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void GetUniformdv(int program, int location, double* parameters) => GLPointers._glGetUniformdv_fnptr(program, location, parameters);
            
            public static void Uniform1i64ARB(int location, long x) => GLPointers._glUniform1i64ARB_fnptr(location, x);
            
            public static void Uniform2i64ARB(int location, long x, long y) => GLPointers._glUniform2i64ARB_fnptr(location, x, y);
            
            public static void Uniform3i64ARB(int location, long x, long y, long z) => GLPointers._glUniform3i64ARB_fnptr(location, x, y, z);
            
            public static void Uniform4i64ARB(int location, long x, long y, long z, long w) => GLPointers._glUniform4i64ARB_fnptr(location, x, y, z, w);
            
            public static void Uniform1i64vARB(int location, int count, long* value) => GLPointers._glUniform1i64vARB_fnptr(location, count, value);
            
            public static void Uniform2i64vARB(int location, int count, long* value) => GLPointers._glUniform2i64vARB_fnptr(location, count, value);
            
            public static void Uniform3i64vARB(int location, int count, long* value) => GLPointers._glUniform3i64vARB_fnptr(location, count, value);
            
            public static void Uniform4i64vARB(int location, int count, long* value) => GLPointers._glUniform4i64vARB_fnptr(location, count, value);
            
            public static void Uniform1ui64ARB(int location, ulong x) => GLPointers._glUniform1ui64ARB_fnptr(location, x);
            
            public static void Uniform2ui64ARB(int location, ulong x, ulong y) => GLPointers._glUniform2ui64ARB_fnptr(location, x, y);
            
            public static void Uniform3ui64ARB(int location, ulong x, ulong y, ulong z) => GLPointers._glUniform3ui64ARB_fnptr(location, x, y, z);
            
            public static void Uniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glUniform4ui64ARB_fnptr(location, x, y, z, w);
            
            public static void Uniform1ui64vARB(int location, int count, ulong* value) => GLPointers._glUniform1ui64vARB_fnptr(location, count, value);
            
            public static void Uniform2ui64vARB(int location, int count, ulong* value) => GLPointers._glUniform2ui64vARB_fnptr(location, count, value);
            
            public static void Uniform3ui64vARB(int location, int count, ulong* value) => GLPointers._glUniform3ui64vARB_fnptr(location, count, value);
            
            public static void Uniform4ui64vARB(int location, int count, ulong* value) => GLPointers._glUniform4ui64vARB_fnptr(location, count, value);
            
            public static void GetUniformi64vARB(int program, int location, long* parameters) => GLPointers._glGetUniformi64vARB_fnptr(program, location, parameters);
            
            public static void GetUniformui64vARB(int program, int location, ulong* parameters) => GLPointers._glGetUniformui64vARB_fnptr(program, location, parameters);
            
            public static void GetnUniformi64vARB(int program, int location, int bufSize, long* parameters) => GLPointers._glGetnUniformi64vARB_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformui64vARB(int program, int location, int bufSize, ulong* parameters) => GLPointers._glGetnUniformui64vARB_fnptr(program, location, bufSize, parameters);
            
            public static void ProgramUniform1i64ARB(int program, int location, long x) => GLPointers._glProgramUniform1i64ARB_fnptr(program, location, x);
            
            public static void ProgramUniform2i64ARB(int program, int location, long x, long y) => GLPointers._glProgramUniform2i64ARB_fnptr(program, location, x, y);
            
            public static void ProgramUniform3i64ARB(int program, int location, long x, long y, long z) => GLPointers._glProgramUniform3i64ARB_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform4i64ARB(int program, int location, long x, long y, long z, long w) => GLPointers._glProgramUniform4i64ARB_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform1i64vARB(int program, int location, int count, long* value) => GLPointers._glProgramUniform1i64vARB_fnptr(program, location, count, value);
            
            public static void ProgramUniform2i64vARB(int program, int location, int count, long* value) => GLPointers._glProgramUniform2i64vARB_fnptr(program, location, count, value);
            
            public static void ProgramUniform3i64vARB(int program, int location, int count, long* value) => GLPointers._glProgramUniform3i64vARB_fnptr(program, location, count, value);
            
            public static void ProgramUniform4i64vARB(int program, int location, int count, long* value) => GLPointers._glProgramUniform4i64vARB_fnptr(program, location, count, value);
            
            public static void ProgramUniform1ui64ARB(int program, int location, ulong x) => GLPointers._glProgramUniform1ui64ARB_fnptr(program, location, x);
            
            public static void ProgramUniform2ui64ARB(int program, int location, ulong x, ulong y) => GLPointers._glProgramUniform2ui64ARB_fnptr(program, location, x, y);
            
            public static void ProgramUniform3ui64ARB(int program, int location, ulong x, ulong y, ulong z) => GLPointers._glProgramUniform3ui64ARB_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform4ui64ARB(int program, int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glProgramUniform4ui64ARB_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform1ui64vARB(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform1ui64vARB_fnptr(program, location, count, value);
            
            public static void ProgramUniform2ui64vARB(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform2ui64vARB_fnptr(program, location, count, value);
            
            public static void ProgramUniform3ui64vARB(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform3ui64vARB_fnptr(program, location, count, value);
            
            public static void ProgramUniform4ui64vARB(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform4ui64vARB_fnptr(program, location, count, value);
            
            public static void BlendColor(float red, float green, float blue, float alpha) => GLPointers._glBlendColor_fnptr(red, green, blue, alpha);
            
            public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquation_fnptr((uint)mode);
            
            public static void ColorTable(ColorTableTarget target, InternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table) => GLPointers._glColorTable_fnptr((uint)target, (uint)internalformat, width, (uint)format, (uint)type, table);
            
            public static void ColorTableParameterfv(ColorTableTarget target, ColorTableParameterPName pname, float* parameters) => GLPointers._glColorTableParameterfv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ColorTableParameteriv(ColorTableTarget target, ColorTableParameterPName pname, int* parameters) => GLPointers._glColorTableParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void CopyColorTable(ColorTableTarget target, InternalFormat internalformat, int x, int y, int width) => GLPointers._glCopyColorTable_fnptr((uint)target, (uint)internalformat, x, y, width);
            
            public static void GetColorTable(ColorTableTarget target, PixelFormat format, PixelType type, void* table) => GLPointers._glGetColorTable_fnptr((uint)target, (uint)format, (uint)type, table);
            
            public static void GetColorTableParameterfv(ColorTableTarget target, ColorTableParameterPName pname, float* parameters) => GLPointers._glGetColorTableParameterfv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetColorTableParameteriv(ColorTableTarget target, ColorTableParameterPName pname, int* parameters) => GLPointers._glGetColorTableParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ColorSubTable(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, void* data) => GLPointers._glColorSubTable_fnptr((uint)target, start, count, (uint)format, (uint)type, data);
            
            public static void CopyColorSubTable(ColorTableTarget target, int start, int x, int y, int width) => GLPointers._glCopyColorSubTable_fnptr((uint)target, start, x, y, width);
            
            public static void ConvolutionFilter1D(ConvolutionTarget target, InternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image) => GLPointers._glConvolutionFilter1D_fnptr((uint)target, (uint)internalformat, width, (uint)format, (uint)type, image);
            
            public static void ConvolutionFilter2D(ConvolutionTarget target, InternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image) => GLPointers._glConvolutionFilter2D_fnptr((uint)target, (uint)internalformat, width, height, (uint)format, (uint)type, image);
            
            public static void ConvolutionParameterf(ConvolutionTarget target, ConvolutionParameter pname, float parameters) => GLPointers._glConvolutionParameterf_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ConvolutionParameterfv(ConvolutionTarget target, ConvolutionParameter pname, float* parameters) => GLPointers._glConvolutionParameterfv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ConvolutionParameteri(ConvolutionTarget target, ConvolutionParameter pname, int parameters) => GLPointers._glConvolutionParameteri_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ConvolutionParameteriv(ConvolutionTarget target, ConvolutionParameter pname, int* parameters) => GLPointers._glConvolutionParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void CopyConvolutionFilter1D(ConvolutionTarget target, InternalFormat internalformat, int x, int y, int width) => GLPointers._glCopyConvolutionFilter1D_fnptr((uint)target, (uint)internalformat, x, y, width);
            
            public static void CopyConvolutionFilter2D(ConvolutionTarget target, InternalFormat internalformat, int x, int y, int width, int height) => GLPointers._glCopyConvolutionFilter2D_fnptr((uint)target, (uint)internalformat, x, y, width, height);
            
            public static void GetConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, void* image) => GLPointers._glGetConvolutionFilter_fnptr((uint)target, (uint)format, (uint)type, image);
            
            public static void GetConvolutionParameterfv(ConvolutionTarget target, ConvolutionParameter pname, float* parameters) => GLPointers._glGetConvolutionParameterfv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetConvolutionParameteriv(ConvolutionTarget target, ConvolutionParameter pname, int* parameters) => GLPointers._glGetConvolutionParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetSeparableFilter(SeparableTargetEXT target, PixelFormat format, PixelType type, void* row, void* column, void* span) => GLPointers._glGetSeparableFilter_fnptr((uint)target, (uint)format, (uint)type, row, column, span);
            
            public static void SeparableFilter2D(SeparableTargetEXT target, InternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column) => GLPointers._glSeparableFilter2D_fnptr((uint)target, (uint)internalformat, width, height, (uint)format, (uint)type, row, column);
            
            public static void GetHistogram(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, void* values) => GLPointers._glGetHistogram_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, values);
            
            public static void GetHistogramParameterfv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float* parameters) => GLPointers._glGetHistogramParameterfv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetHistogramParameteriv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => GLPointers._glGetHistogramParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetMinmax(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, void* values) => GLPointers._glGetMinmax_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, values);
            
            public static void GetMinmaxParameterfv(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float* parameters) => GLPointers._glGetMinmaxParameterfv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetMinmaxParameteriv(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int* parameters) => GLPointers._glGetMinmaxParameteriv_fnptr((uint)target, (uint)pname, parameters);
            
            public static void Histogram(HistogramTargetEXT target, int width, InternalFormat internalformat, bool sink) => GLPointers._glHistogram_fnptr((uint)target, width, (uint)internalformat, (byte)(sink ? 1 : 0));
            
            public static void Minmax(MinmaxTargetEXT target, InternalFormat internalformat, bool sink) => GLPointers._glMinmax_fnptr((uint)target, (uint)internalformat, (byte)(sink ? 1 : 0));
            
            public static void ResetHistogram(HistogramTargetEXT target) => GLPointers._glResetHistogram_fnptr((uint)target);
            
            public static void ResetMinmax(MinmaxTargetEXT target) => GLPointers._glResetMinmax_fnptr((uint)target);
            
            public static void MultiDrawArraysIndirectCountARB(PrimitiveType mode, void* indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawArraysIndirectCountARB_fnptr((uint)mode, indirect, drawcount, maxdrawcount, stride);
            
            public static void MultiDrawElementsIndirectCountARB(PrimitiveType mode, DrawElementsType type, void* indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawElementsIndirectCountARB_fnptr((uint)mode, (uint)type, indirect, drawcount, maxdrawcount, stride);
            
            public static void VertexAttribDivisorARB(uint index, uint divisor) => GLPointers._glVertexAttribDivisorARB_fnptr(index, divisor);
            
            public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformativ_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
            
            public static void GetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, long* parameters) => GLPointers._glGetInternalformati64v_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
            
            public static void InvalidateTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) => GLPointers._glInvalidateTexSubImage_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth);
            
            public static void InvalidateTexImage(int texture, int level) => GLPointers._glInvalidateTexImage_fnptr(texture, level);
            
            public static void InvalidateBufferSubData(int buffer, IntPtr offset, nint length) => GLPointers._glInvalidateBufferSubData_fnptr(buffer, offset, length);
            
            public static void InvalidateBufferData(int buffer) => GLPointers._glInvalidateBufferData_fnptr(buffer);
            
            public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glInvalidateFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments);
            
            public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._glInvalidateSubFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments, x, y, width, height);
            
            public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRange_fnptr((uint)target, offset, length, (uint)access);
            
            public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRange_fnptr((uint)target, offset, length);
            
            public static void CurrentPaletteMatrixARB(int index) => GLPointers._glCurrentPaletteMatrixARB_fnptr(index);
            
            public static void MatrixIndexubvARB(int size, byte* indices) => GLPointers._glMatrixIndexubvARB_fnptr(size, indices);
            
            public static void MatrixIndexusvARB(int size, ushort* indices) => GLPointers._glMatrixIndexusvARB_fnptr(size, indices);
            
            public static void MatrixIndexuivARB(int size, uint* indices) => GLPointers._glMatrixIndexuivARB_fnptr(size, indices);
            
            public static void MatrixIndexPointerARB(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer) => GLPointers._glMatrixIndexPointerARB_fnptr(size, (uint)type, stride, pointer);
            
            public static void BindBuffersBase(BufferTargetARB target, uint first, int count, int* buffers) => GLPointers._glBindBuffersBase_fnptr((uint)target, first, count, buffers);
            
            public static void BindBuffersRange(BufferTargetARB target, uint first, int count, int* buffers, IntPtr* offsets, nint* sizes) => GLPointers._glBindBuffersRange_fnptr((uint)target, first, count, buffers, offsets, sizes);
            
            public static void BindTextures(uint first, int count, int* textures) => GLPointers._glBindTextures_fnptr(first, count, textures);
            
            public static void BindSamplers(uint first, int count, int* samplers) => GLPointers._glBindSamplers_fnptr(first, count, samplers);
            
            public static void BindImageTextures(uint first, int count, int* textures) => GLPointers._glBindImageTextures_fnptr(first, count, textures);
            
            public static void BindVertexBuffers(uint first, int count, int* buffers, IntPtr* offsets, int* strides) => GLPointers._glBindVertexBuffers_fnptr(first, count, buffers, offsets, strides);
            
            public static void MultiDrawArraysIndirect(PrimitiveType mode, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawArraysIndirect_fnptr((uint)mode, indirect, drawcount, stride);
            
            public static void MultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect, drawcount, stride);
            
            public static void SampleCoverageARB(float value, bool invert) => GLPointers._glSampleCoverageARB_fnptr(value, (byte)(invert ? 1 : 0));
            
            public static void ActiveTextureARB(TextureUnit texture) => GLPointers._glActiveTextureARB_fnptr((uint)texture);
            
            public static void ClientActiveTextureARB(TextureUnit texture) => GLPointers._glClientActiveTextureARB_fnptr((uint)texture);
            
            public static void MultiTexCoord1dARB(TextureUnit target, double s) => GLPointers._glMultiTexCoord1dARB_fnptr((uint)target, s);
            
            public static void MultiTexCoord1dvARB(TextureUnit target, double* v) => GLPointers._glMultiTexCoord1dvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord1fARB(TextureUnit target, float s) => GLPointers._glMultiTexCoord1fARB_fnptr((uint)target, s);
            
            public static void MultiTexCoord1fvARB(TextureUnit target, float* v) => GLPointers._glMultiTexCoord1fvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord1iARB(TextureUnit target, int s) => GLPointers._glMultiTexCoord1iARB_fnptr((uint)target, s);
            
            public static void MultiTexCoord1ivARB(TextureUnit target, int* v) => GLPointers._glMultiTexCoord1ivARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord1sARB(TextureUnit target, short s) => GLPointers._glMultiTexCoord1sARB_fnptr((uint)target, s);
            
            public static void MultiTexCoord1svARB(TextureUnit target, short* v) => GLPointers._glMultiTexCoord1svARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord2dARB(TextureUnit target, double s, double t) => GLPointers._glMultiTexCoord2dARB_fnptr((uint)target, s, t);
            
            public static void MultiTexCoord2dvARB(TextureUnit target, double* v) => GLPointers._glMultiTexCoord2dvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord2fARB(TextureUnit target, float s, float t) => GLPointers._glMultiTexCoord2fARB_fnptr((uint)target, s, t);
            
            public static void MultiTexCoord2fvARB(TextureUnit target, float* v) => GLPointers._glMultiTexCoord2fvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord2iARB(TextureUnit target, int s, int t) => GLPointers._glMultiTexCoord2iARB_fnptr((uint)target, s, t);
            
            public static void MultiTexCoord2ivARB(TextureUnit target, int* v) => GLPointers._glMultiTexCoord2ivARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord2sARB(TextureUnit target, short s, short t) => GLPointers._glMultiTexCoord2sARB_fnptr((uint)target, s, t);
            
            public static void MultiTexCoord2svARB(TextureUnit target, short* v) => GLPointers._glMultiTexCoord2svARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord3dARB(TextureUnit target, double s, double t, double r) => GLPointers._glMultiTexCoord3dARB_fnptr((uint)target, s, t, r);
            
            public static void MultiTexCoord3dvARB(TextureUnit target, double* v) => GLPointers._glMultiTexCoord3dvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord3fARB(TextureUnit target, float s, float t, float r) => GLPointers._glMultiTexCoord3fARB_fnptr((uint)target, s, t, r);
            
            public static void MultiTexCoord3fvARB(TextureUnit target, float* v) => GLPointers._glMultiTexCoord3fvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord3iARB(TextureUnit target, int s, int t, int r) => GLPointers._glMultiTexCoord3iARB_fnptr((uint)target, s, t, r);
            
            public static void MultiTexCoord3ivARB(TextureUnit target, int* v) => GLPointers._glMultiTexCoord3ivARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord3sARB(TextureUnit target, short s, short t, short r) => GLPointers._glMultiTexCoord3sARB_fnptr((uint)target, s, t, r);
            
            public static void MultiTexCoord3svARB(TextureUnit target, short* v) => GLPointers._glMultiTexCoord3svARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord4dARB(TextureUnit target, double s, double t, double r, double q) => GLPointers._glMultiTexCoord4dARB_fnptr((uint)target, s, t, r, q);
            
            public static void MultiTexCoord4dvARB(TextureUnit target, double* v) => GLPointers._glMultiTexCoord4dvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord4fARB(TextureUnit target, float s, float t, float r, float q) => GLPointers._glMultiTexCoord4fARB_fnptr((uint)target, s, t, r, q);
            
            public static void MultiTexCoord4fvARB(TextureUnit target, float* v) => GLPointers._glMultiTexCoord4fvARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord4iARB(TextureUnit target, int s, int t, int r, int q) => GLPointers._glMultiTexCoord4iARB_fnptr((uint)target, s, t, r, q);
            
            public static void MultiTexCoord4ivARB(TextureUnit target, int* v) => GLPointers._glMultiTexCoord4ivARB_fnptr((uint)target, v);
            
            public static void MultiTexCoord4sARB(TextureUnit target, short s, short t, short r, short q) => GLPointers._glMultiTexCoord4sARB_fnptr((uint)target, s, t, r, q);
            
            public static void MultiTexCoord4svARB(TextureUnit target, short* v) => GLPointers._glMultiTexCoord4svARB_fnptr((uint)target, v);
            
            public static void GenQueriesARB(int n, int* ids) => GLPointers._glGenQueriesARB_fnptr(n, ids);
            
            public static void DeleteQueriesARB(int n, int* ids) => GLPointers._glDeleteQueriesARB_fnptr(n, ids);
            
            public static bool IsQueryARB(int id) => GLPointers._glIsQueryARB_fnptr(id) != 0;
            
            public static void BeginQueryARB(QueryTarget target, int id) => GLPointers._glBeginQueryARB_fnptr((uint)target, id);
            
            public static void EndQueryARB(QueryTarget target) => GLPointers._glEndQueryARB_fnptr((uint)target);
            
            public static void GetQueryivARB(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryivARB_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetQueryObjectivARB(int id, QueryObjectParameterName pname, int* parameters) => GLPointers._glGetQueryObjectivARB_fnptr(id, (uint)pname, parameters);
            
            public static void GetQueryObjectuivARB(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuivARB_fnptr(id, (uint)pname, parameters);
            
            public static void MaxShaderCompilerThreadsARB(uint count) => GLPointers._glMaxShaderCompilerThreadsARB_fnptr(count);
            
            public static void PointParameterfARB(PointParameterNameARB pname, float param) => GLPointers._glPointParameterfARB_fnptr((uint)pname, param);
            
            public static void PointParameterfvARB(PointParameterNameARB pname, float* parameters) => GLPointers._glPointParameterfvARB_fnptr((uint)pname, parameters);
            
            public static void PolygonOffsetClamp(float factor, float units, float clamp) => GLPointers._glPolygonOffsetClamp_fnptr(factor, units, clamp);
            
            public static void GetProgramInterfaceiv(int program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters) => GLPointers._glGetProgramInterfaceiv_fnptr(program, (uint)programInterface, (uint)pname, parameters);
            
            public static uint GetProgramResourceIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceIndex_fnptr(program, (uint)programInterface, name);
            
            public static void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetProgramResourceName_fnptr(program, (uint)programInterface, index, bufSize, length, name);
            
            public static void GetProgramResourceiv(int program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* parameters) => GLPointers._glGetProgramResourceiv_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
            
            public static int GetProgramResourceLocation(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocation_fnptr(program, (uint)programInterface, name);
            
            public static int GetProgramResourceLocationIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocationIndex_fnptr(program, (uint)programInterface, name);
            
            public static void ProvokingVertex(VertexProvokingMode mode) => GLPointers._glProvokingVertex_fnptr((uint)mode);
            
            public static GraphicsResetStatus GetGraphicsResetStatusARB() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusARB_fnptr();
            
            public static void GetnTexImageARB(TextureTarget target, int level, PixelFormat format, PixelType type, int bufSize, void* img) => GLPointers._glGetnTexImageARB_fnptr((uint)target, level, (uint)format, (uint)type, bufSize, img);
            
            public static void ReadnPixelsARB(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsARB_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            public static void GetnCompressedTexImageARB(TextureTarget target, int lod, int bufSize, void* img) => GLPointers._glGetnCompressedTexImageARB_fnptr((uint)target, lod, bufSize, img);
            
            public static void GetnUniformfvARB(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvARB_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformivARB(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivARB_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformuivARB(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuivARB_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformdvARB(int program, int location, int bufSize, double* parameters) => GLPointers._glGetnUniformdvARB_fnptr(program, location, bufSize, parameters);
            
            public static void GetnMapdvARB(MapTarget target, MapQuery query, int bufSize, double* v) => GLPointers._glGetnMapdvARB_fnptr((uint)target, (uint)query, bufSize, v);
            
            public static void GetnMapfvARB(MapTarget target, MapQuery query, int bufSize, float* v) => GLPointers._glGetnMapfvARB_fnptr((uint)target, (uint)query, bufSize, v);
            
            public static void GetnMapivARB(MapTarget target, MapQuery query, int bufSize, int* v) => GLPointers._glGetnMapivARB_fnptr((uint)target, (uint)query, bufSize, v);
            
            public static void GetnPixelMapfvARB(PixelMap map, int bufSize, float* values) => GLPointers._glGetnPixelMapfvARB_fnptr((uint)map, bufSize, values);
            
            public static void GetnPixelMapuivARB(PixelMap map, int bufSize, uint* values) => GLPointers._glGetnPixelMapuivARB_fnptr((uint)map, bufSize, values);
            
            public static void GetnPixelMapusvARB(PixelMap map, int bufSize, ushort* values) => GLPointers._glGetnPixelMapusvARB_fnptr((uint)map, bufSize, values);
            
            public static void GetnPolygonStippleARB(int bufSize, byte* pattern) => GLPointers._glGetnPolygonStippleARB_fnptr(bufSize, pattern);
            
            public static void GetnColorTableARB(ColorTableTarget target, PixelFormat format, PixelType type, int bufSize, void* table) => GLPointers._glGetnColorTableARB_fnptr((uint)target, (uint)format, (uint)type, bufSize, table);
            
            public static void GetnConvolutionFilterARB(ConvolutionTarget target, PixelFormat format, PixelType type, int bufSize, void* image) => GLPointers._glGetnConvolutionFilterARB_fnptr((uint)target, (uint)format, (uint)type, bufSize, image);
            
            public static void GetnSeparableFilterARB(SeparableTargetEXT target, PixelFormat format, PixelType type, int rowBufSize, void* row, int columnBufSize, void* column, void* span) => GLPointers._glGetnSeparableFilterARB_fnptr((uint)target, (uint)format, (uint)type, rowBufSize, row, columnBufSize, column, span);
            
            public static void GetnHistogramARB(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, int bufSize, void* values) => GLPointers._glGetnHistogramARB_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, bufSize, values);
            
            public static void GetnMinmaxARB(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, int bufSize, void* values) => GLPointers._glGetnMinmaxARB_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, bufSize, values);
            
            public static void FramebufferSampleLocationsfvARB(FramebufferTarget target, uint start, int count, float* v) => GLPointers._glFramebufferSampleLocationsfvARB_fnptr((uint)target, start, count, v);
            
            public static void NamedFramebufferSampleLocationsfvARB(int framebuffer, uint start, int count, float* v) => GLPointers._glNamedFramebufferSampleLocationsfvARB_fnptr(framebuffer, start, count, v);
            
            public static void EvaluateDepthValuesARB() => GLPointers._glEvaluateDepthValuesARB_fnptr();
            
            public static void MinSampleShadingARB(float value) => GLPointers._glMinSampleShadingARB_fnptr(value);
            
            public static void GenSamplers(int count, int* samplers) => GLPointers._glGenSamplers_fnptr(count, samplers);
            
            public static void DeleteSamplers(int count, int* samplers) => GLPointers._glDeleteSamplers_fnptr(count, samplers);
            
            public static bool IsSampler(int sampler) => GLPointers._glIsSampler_fnptr(sampler) != 0;
            
            public static void BindSampler(uint unit, int sampler) => GLPointers._glBindSampler_fnptr(unit, sampler);
            
            public static void SamplerParameteri(int sampler, SamplerParameterI pname, int param) => GLPointers._glSamplerParameteri_fnptr(sampler, (uint)pname, param);
            
            public static void SamplerParameteriv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameteriv_fnptr(sampler, (uint)pname, param);
            
            public static void SamplerParameterf(int sampler, SamplerParameterF pname, float param) => GLPointers._glSamplerParameterf_fnptr(sampler, (uint)pname, param);
            
            public static void SamplerParameterfv(int sampler, SamplerParameterF pname, float* param) => GLPointers._glSamplerParameterfv_fnptr(sampler, (uint)pname, param);
            
            public static void SamplerParameterIiv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIiv_fnptr(sampler, (uint)pname, param);
            
            public static void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuiv_fnptr(sampler, (uint)pname, param);
            
            public static void GetSamplerParameteriv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameteriv_fnptr(sampler, (uint)pname, parameters);
            
            public static void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIiv_fnptr(sampler, (uint)pname, parameters);
            
            public static void GetSamplerParameterfv(int sampler, SamplerParameterF pname, float* parameters) => GLPointers._glGetSamplerParameterfv_fnptr(sampler, (uint)pname, parameters);
            
            public static void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuiv_fnptr(sampler, (uint)pname, parameters);
            
            public static void UseProgramStages(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStages_fnptr(pipeline, (uint)stages, program);
            
            public static void ActiveShaderProgram(int pipeline, int program) => GLPointers._glActiveShaderProgram_fnptr(pipeline, program);
            
            public static int CreateShaderProgramv(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramv_fnptr((uint)type, count, strings);
            
            public static void BindProgramPipeline(int pipeline) => GLPointers._glBindProgramPipeline_fnptr(pipeline);
            
            public static void DeleteProgramPipelines(int n, int* pipelines) => GLPointers._glDeleteProgramPipelines_fnptr(n, pipelines);
            
            public static void GenProgramPipelines(int n, int* pipelines) => GLPointers._glGenProgramPipelines_fnptr(n, pipelines);
            
            public static bool IsProgramPipeline(int pipeline) => GLPointers._glIsProgramPipeline_fnptr(pipeline) != 0;
            
            public static void GetProgramPipelineiv(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineiv_fnptr(pipeline, (uint)pname, parameters);
            
            public static void ProgramUniform1i(int program, int location, int v0) => GLPointers._glProgramUniform1i_fnptr(program, location, v0);
            
            public static void ProgramUniform1iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform1iv_fnptr(program, location, count, value);
            
            public static void ProgramUniform1f(int program, int location, float v0) => GLPointers._glProgramUniform1f_fnptr(program, location, v0);
            
            public static void ProgramUniform1fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fv_fnptr(program, location, count, value);
            
            public static void ProgramUniform1d(int program, int location, double v0) => GLPointers._glProgramUniform1d_fnptr(program, location, v0);
            
            public static void ProgramUniform1dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform1dv_fnptr(program, location, count, value);
            
            public static void ProgramUniform1ui(int program, int location, uint v0) => GLPointers._glProgramUniform1ui_fnptr(program, location, v0);
            
            public static void ProgramUniform1uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uiv_fnptr(program, location, count, value);
            
            public static void ProgramUniform2i(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2i_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform2iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform2iv_fnptr(program, location, count, value);
            
            public static void ProgramUniform2f(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2f_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform2fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fv_fnptr(program, location, count, value);
            
            public static void ProgramUniform2d(int program, int location, double v0, double v1) => GLPointers._glProgramUniform2d_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform2dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform2dv_fnptr(program, location, count, value);
            
            public static void ProgramUniform2ui(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2ui_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform2uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uiv_fnptr(program, location, count, value);
            
            public static void ProgramUniform3i(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3i_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform3iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform3iv_fnptr(program, location, count, value);
            
            public static void ProgramUniform3f(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3f_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform3fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fv_fnptr(program, location, count, value);
            
            public static void ProgramUniform3d(int program, int location, double v0, double v1, double v2) => GLPointers._glProgramUniform3d_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform3dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform3dv_fnptr(program, location, count, value);
            
            public static void ProgramUniform3ui(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3ui_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform3uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uiv_fnptr(program, location, count, value);
            
            public static void ProgramUniform4i(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4i_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform4iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform4iv_fnptr(program, location, count, value);
            
            public static void ProgramUniform4f(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4f_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform4fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fv_fnptr(program, location, count, value);
            
            public static void ProgramUniform4d(int program, int location, double v0, double v1, double v2, double v3) => GLPointers._glProgramUniform4d_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform4dv(int program, int location, int count, double* value) => GLPointers._glProgramUniform4dv_fnptr(program, location, count, value);
            
            public static void ProgramUniform4ui(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4ui_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform4uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uiv_fnptr(program, location, count, value);
            
            public static void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x3dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2x3dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x2dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3x2dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x4dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2x4dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x2dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4x2dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x4dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3x4dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x3dv(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4x3dv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ValidateProgramPipeline(int pipeline) => GLPointers._glValidateProgramPipeline_fnptr(pipeline);
            
            public static void GetProgramPipelineInfoLog(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLog_fnptr(pipeline, bufSize, length, infoLog);
            
            public static void GetActiveAtomicCounterBufferiv(int program, uint bufferIndex, AtomicCounterBufferPName pname, int* parameters) => GLPointers._glGetActiveAtomicCounterBufferiv_fnptr(program, bufferIndex, (uint)pname, parameters);
            
            public static void BindImageTexture(uint unit, int texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format) => GLPointers._glBindImageTexture_fnptr(unit, texture, level, (byte)(layered ? 1 : 0), layer, (uint)access, (uint)format);
            
            public static void MemoryBarrier(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrier_fnptr((uint)barriers);
            
            public static void DeleteObjectARB(GLHandleARB obj) => GLPointers._glDeleteObjectARB_fnptr((IntPtr)obj);
            
            public static GLHandleARB GetHandleARB(ContainerType pname) => (GLHandleARB) GLPointers._glGetHandleARB_fnptr((uint)pname);
            
            public static void DetachObjectARB(GLHandleARB containerObj, GLHandleARB attachedObj) => GLPointers._glDetachObjectARB_fnptr((IntPtr)containerObj, (IntPtr)attachedObj);
            
            public static GLHandleARB CreateShaderObjectARB(ShaderType shaderType) => (GLHandleARB) GLPointers._glCreateShaderObjectARB_fnptr((uint)shaderType);
            
            public static void ShaderSourceARB(GLHandleARB shaderObj, int count, byte** str, int* length) => GLPointers._glShaderSourceARB_fnptr((IntPtr)shaderObj, count, str, length);
            
            public static void CompileShaderARB(GLHandleARB shaderObj) => GLPointers._glCompileShaderARB_fnptr((IntPtr)shaderObj);
            
            public static GLHandleARB CreateProgramObjectARB() => (GLHandleARB) GLPointers._glCreateProgramObjectARB_fnptr();
            
            public static void AttachObjectARB(GLHandleARB containerObj, GLHandleARB obj) => GLPointers._glAttachObjectARB_fnptr((IntPtr)containerObj, (IntPtr)obj);
            
            public static void LinkProgramARB(GLHandleARB programObj) => GLPointers._glLinkProgramARB_fnptr((IntPtr)programObj);
            
            public static void UseProgramObjectARB(GLHandleARB programObj) => GLPointers._glUseProgramObjectARB_fnptr((IntPtr)programObj);
            
            public static void ValidateProgramARB(GLHandleARB programObj) => GLPointers._glValidateProgramARB_fnptr((IntPtr)programObj);
            
            public static void Uniform1fARB(int location, float v0) => GLPointers._glUniform1fARB_fnptr(location, v0);
            
            public static void Uniform2fARB(int location, float v0, float v1) => GLPointers._glUniform2fARB_fnptr(location, v0, v1);
            
            public static void Uniform3fARB(int location, float v0, float v1, float v2) => GLPointers._glUniform3fARB_fnptr(location, v0, v1, v2);
            
            public static void Uniform4fARB(int location, float v0, float v1, float v2, float v3) => GLPointers._glUniform4fARB_fnptr(location, v0, v1, v2, v3);
            
            public static void Uniform1iARB(int location, int v0) => GLPointers._glUniform1iARB_fnptr(location, v0);
            
            public static void Uniform2iARB(int location, int v0, int v1) => GLPointers._glUniform2iARB_fnptr(location, v0, v1);
            
            public static void Uniform3iARB(int location, int v0, int v1, int v2) => GLPointers._glUniform3iARB_fnptr(location, v0, v1, v2);
            
            public static void Uniform4iARB(int location, int v0, int v1, int v2, int v3) => GLPointers._glUniform4iARB_fnptr(location, v0, v1, v2, v3);
            
            public static void Uniform1fvARB(int location, int count, float* value) => GLPointers._glUniform1fvARB_fnptr(location, count, value);
            
            public static void Uniform2fvARB(int location, int count, float* value) => GLPointers._glUniform2fvARB_fnptr(location, count, value);
            
            public static void Uniform3fvARB(int location, int count, float* value) => GLPointers._glUniform3fvARB_fnptr(location, count, value);
            
            public static void Uniform4fvARB(int location, int count, float* value) => GLPointers._glUniform4fvARB_fnptr(location, count, value);
            
            public static void Uniform1ivARB(int location, int count, int* value) => GLPointers._glUniform1ivARB_fnptr(location, count, value);
            
            public static void Uniform2ivARB(int location, int count, int* value) => GLPointers._glUniform2ivARB_fnptr(location, count, value);
            
            public static void Uniform3ivARB(int location, int count, int* value) => GLPointers._glUniform3ivARB_fnptr(location, count, value);
            
            public static void Uniform4ivARB(int location, int count, int* value) => GLPointers._glUniform4ivARB_fnptr(location, count, value);
            
            public static void UniformMatrix2fvARB(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2fvARB_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix3fvARB(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3fvARB_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix4fvARB(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4fvARB_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void GetObjectParameterfvARB(GLHandleARB obj, All pname, float* parameters) => GLPointers._glGetObjectParameterfvARB_fnptr((IntPtr)obj, (uint)pname, parameters);
            
            public static void GetObjectParameterivARB(GLHandleARB obj, All pname, int* parameters) => GLPointers._glGetObjectParameterivARB_fnptr((IntPtr)obj, (uint)pname, parameters);
            
            public static void GetInfoLogARB(GLHandleARB obj, int maxLength, int* length, byte* infoLog) => GLPointers._glGetInfoLogARB_fnptr((IntPtr)obj, maxLength, length, infoLog);
            
            public static void GetAttachedObjectsARB(GLHandleARB containerObj, int maxCount, int* count, GLHandleARB* obj) => GLPointers._glGetAttachedObjectsARB_fnptr((IntPtr)containerObj, maxCount, count, (IntPtr*)obj);
            
            public static int GetUniformLocationARB(GLHandleARB programObj, byte* name) => GLPointers._glGetUniformLocationARB_fnptr((IntPtr)programObj, name);
            
            public static void GetActiveUniformARB(GLHandleARB programObj, uint index, int maxLength, int* length, int* size, UniformType* type, byte* name) => GLPointers._glGetActiveUniformARB_fnptr((IntPtr)programObj, index, maxLength, length, size, (uint*)type, name);
            
            public static void GetUniformfvARB(GLHandleARB programObj, int location, float* parameters) => GLPointers._glGetUniformfvARB_fnptr((IntPtr)programObj, location, parameters);
            
            public static void GetUniformivARB(GLHandleARB programObj, int location, int* parameters) => GLPointers._glGetUniformivARB_fnptr((IntPtr)programObj, location, parameters);
            
            public static void GetShaderSourceARB(GLHandleARB obj, int maxLength, int* length, byte* source) => GLPointers._glGetShaderSourceARB_fnptr((IntPtr)obj, maxLength, length, source);
            
            public static void ShaderStorageBlockBinding(int program, uint storageBlockIndex, uint storageBlockBinding) => GLPointers._glShaderStorageBlockBinding_fnptr(program, storageBlockIndex, storageBlockBinding);
            
            public static int GetSubroutineUniformLocation(int program, ShaderType shadertype, byte* name) => GLPointers._glGetSubroutineUniformLocation_fnptr(program, (uint)shadertype, name);
            
            public static uint GetSubroutineIndex(int program, ShaderType shadertype, byte* name) => GLPointers._glGetSubroutineIndex_fnptr(program, (uint)shadertype, name);
            
            public static void GetActiveSubroutineUniformiv(int program, ShaderType shadertype, uint index, SubroutineParameterName pname, int* values) => GLPointers._glGetActiveSubroutineUniformiv_fnptr(program, (uint)shadertype, index, (uint)pname, values);
            
            public static void GetActiveSubroutineUniformName(int program, ShaderType shadertype, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetActiveSubroutineUniformName_fnptr(program, (uint)shadertype, index, bufSize, length, name);
            
            public static void GetActiveSubroutineName(int program, ShaderType shadertype, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetActiveSubroutineName_fnptr(program, (uint)shadertype, index, bufSize, length, name);
            
            public static void UniformSubroutinesuiv(ShaderType shadertype, int count, uint* indices) => GLPointers._glUniformSubroutinesuiv_fnptr((uint)shadertype, count, indices);
            
            public static void GetUniformSubroutineuiv(ShaderType shadertype, int location, uint* parameters) => GLPointers._glGetUniformSubroutineuiv_fnptr((uint)shadertype, location, parameters);
            
            public static void GetProgramStageiv(int program, ShaderType shadertype, ProgramStagePName pname, int* values) => GLPointers._glGetProgramStageiv_fnptr(program, (uint)shadertype, (uint)pname, values);
            
            public static void NamedStringARB(All type, int namelen, byte* name, int stringlen, byte* str) => GLPointers._glNamedStringARB_fnptr((uint)type, namelen, name, stringlen, str);
            
            public static void DeleteNamedStringARB(int namelen, byte* name) => GLPointers._glDeleteNamedStringARB_fnptr(namelen, name);
            
            public static void CompileShaderIncludeARB(int shader, int count, byte** path, int* length) => GLPointers._glCompileShaderIncludeARB_fnptr(shader, count, path, length);
            
            public static bool IsNamedStringARB(int namelen, byte* name) => GLPointers._glIsNamedStringARB_fnptr(namelen, name) != 0;
            
            public static void GetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, byte* str) => GLPointers._glGetNamedStringARB_fnptr(namelen, name, bufSize, stringlen, str);
            
            public static void GetNamedStringivARB(int namelen, byte* name, All pname, int* parameters) => GLPointers._glGetNamedStringivARB_fnptr(namelen, name, (uint)pname, parameters);
            
            public static void BufferPageCommitmentARB(All target, IntPtr offset, nint size, bool commit) => GLPointers._glBufferPageCommitmentARB_fnptr((uint)target, offset, size, (byte)(commit ? 1 : 0));
            
            public static void NamedBufferPageCommitmentEXT(int buffer, IntPtr offset, nint size, bool commit) => GLPointers._glNamedBufferPageCommitmentEXT_fnptr(buffer, offset, size, (byte)(commit ? 1 : 0));
            
            public static void NamedBufferPageCommitmentARB(int buffer, IntPtr offset, nint size, bool commit) => GLPointers._glNamedBufferPageCommitmentARB_fnptr(buffer, offset, size, (byte)(commit ? 1 : 0));
            
            public static void TexPageCommitmentARB(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => GLPointers._glTexPageCommitmentARB_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (byte)(commit ? 1 : 0));
            
            public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSync_fnptr((uint)condition, (uint)flags);
            
            public static bool IsSync(GLSync sync) => GLPointers._glIsSync_fnptr((IntPtr)sync) != 0;
            
            public static void DeleteSync(GLSync sync) => GLPointers._glDeleteSync_fnptr((IntPtr)sync);
            
            public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            public static void GetInteger64v(GetPName pname, long* data) => GLPointers._glGetInteger64v_fnptr((uint)pname, data);
            
            public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSynciv_fnptr((IntPtr)sync, (uint)pname, count, length, values);
            
            public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._glPatchParameteri_fnptr((uint)pname, value);
            
            public static void PatchParameterfv(PatchParameterName pname, float* values) => GLPointers._glPatchParameterfv_fnptr((uint)pname, values);
            
            public static void TextureBarrier() => GLPointers._glTextureBarrier_fnptr();
            
            public static void TexBufferARB(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferARB_fnptr((uint)target, (uint)internalformat, buffer);
            
            public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRange_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
            
            public static void CompressedTexImage3DARB(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage3DARB_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
            
            public static void CompressedTexImage2DARB(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage2DARB_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
            
            public static void CompressedTexImage1DARB(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage1DARB_fnptr((uint)target, level, (uint)internalformat, width, border, imageSize, data);
            
            public static void CompressedTexSubImage3DARB(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage3DARB_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
            
            public static void CompressedTexSubImage2DARB(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage2DARB_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
            
            public static void CompressedTexSubImage1DARB(TextureTarget target, int level, int xoffset, int width, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage1DARB_fnptr((uint)target, level, xoffset, width, (uint)format, imageSize, data);
            
            public static void GetCompressedTexImageARB(TextureTarget target, int level, void* img) => GLPointers._glGetCompressedTexImageARB_fnptr((uint)target, level, img);
            
            public static void TexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTexImage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void TexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexImage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val) => GLPointers._glGetMultisamplefv_fnptr((uint)pname, index, val);
            
            public static void SampleMaski(uint maskNumber, uint mask) => GLPointers._glSampleMaski_fnptr(maskNumber, mask);
            
            public static void TexStorage1D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTexStorage1D_fnptr((uint)target, levels, (uint)internalformat, width);
            
            public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2D_fnptr((uint)target, levels, (uint)internalformat, width, height);
            
            public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3D_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
            
            public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTexStorage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void TextureView(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureView_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            public static void QueryCounter(int id, QueryCounterTarget target) => GLPointers._glQueryCounter_fnptr(id, (uint)target);
            
            public static void GetQueryObjecti64v(int id, QueryObjectParameterName pname, long* parameters) => GLPointers._glGetQueryObjecti64v_fnptr(id, (uint)pname, parameters);
            
            public static void GetQueryObjectui64v(int id, QueryObjectParameterName pname, ulong* parameters) => GLPointers._glGetQueryObjectui64v_fnptr(id, (uint)pname, parameters);
            
            public static void BindTransformFeedback(BindTransformFeedbackTarget target, int id) => GLPointers._glBindTransformFeedback_fnptr((uint)target, id);
            
            public static void DeleteTransformFeedbacks(int n, int* ids) => GLPointers._glDeleteTransformFeedbacks_fnptr(n, ids);
            
            public static void GenTransformFeedbacks(int n, int* ids) => GLPointers._glGenTransformFeedbacks_fnptr(n, ids);
            
            public static bool IsTransformFeedback(int id) => GLPointers._glIsTransformFeedback_fnptr(id) != 0;
            
            public static void PauseTransformFeedback() => GLPointers._glPauseTransformFeedback_fnptr();
            
            public static void ResumeTransformFeedback() => GLPointers._glResumeTransformFeedback_fnptr();
            
            public static void DrawTransformFeedback(PrimitiveType mode, int id) => GLPointers._glDrawTransformFeedback_fnptr((uint)mode, id);
            
            public static void DrawTransformFeedbackStream(PrimitiveType mode, int id, uint stream) => GLPointers._glDrawTransformFeedbackStream_fnptr((uint)mode, id, stream);
            
            public static void BeginQueryIndexed(QueryTarget target, uint index, int id) => GLPointers._glBeginQueryIndexed_fnptr((uint)target, index, id);
            
            public static void EndQueryIndexed(QueryTarget target, uint index) => GLPointers._glEndQueryIndexed_fnptr((uint)target, index);
            
            public static void GetQueryIndexediv(QueryTarget target, uint index, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryIndexediv_fnptr((uint)target, index, (uint)pname, parameters);
            
            public static void DrawTransformFeedbackInstanced(PrimitiveType mode, int id, int instancecount) => GLPointers._glDrawTransformFeedbackInstanced_fnptr((uint)mode, id, instancecount);
            
            public static void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, int id, uint stream, int instancecount) => GLPointers._glDrawTransformFeedbackStreamInstanced_fnptr((uint)mode, id, stream, instancecount);
            
            public static void LoadTransposeMatrixfARB(float* m) => GLPointers._glLoadTransposeMatrixfARB_fnptr(m);
            
            public static void LoadTransposeMatrixdARB(double* m) => GLPointers._glLoadTransposeMatrixdARB_fnptr(m);
            
            public static void MultTransposeMatrixfARB(float* m) => GLPointers._glMultTransposeMatrixfARB_fnptr(m);
            
            public static void MultTransposeMatrixdARB(double* m) => GLPointers._glMultTransposeMatrixdARB_fnptr(m);
            
            public static void GetUniformIndices(int program, int uniformCount, byte** uniformNames, uint* uniformIndices) => GLPointers._glGetUniformIndices_fnptr(program, uniformCount, uniformNames, uniformIndices);
            
            public static void GetActiveUniformsiv(int program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters) => GLPointers._glGetActiveUniformsiv_fnptr(program, uniformCount, uniformIndices, (uint)pname, parameters);
            
            public static void GetActiveUniformName(int program, uint uniformIndex, int bufSize, int* length, byte* uniformName) => GLPointers._glGetActiveUniformName_fnptr(program, uniformIndex, bufSize, length, uniformName);
            
            public static uint GetUniformBlockIndex(int program, byte* uniformBlockName) => GLPointers._glGetUniformBlockIndex_fnptr(program, uniformBlockName);
            
            public static void GetActiveUniformBlockiv(int program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters) => GLPointers._glGetActiveUniformBlockiv_fnptr(program, uniformBlockIndex, (uint)pname, parameters);
            
            public static void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => GLPointers._glGetActiveUniformBlockName_fnptr(program, uniformBlockIndex, bufSize, length, uniformBlockName);
            
            public static void UniformBlockBinding(int program, uint uniformBlockIndex, uint uniformBlockBinding) => GLPointers._glUniformBlockBinding_fnptr(program, uniformBlockIndex, uniformBlockBinding);
            
            public static void BindBufferRange(BufferTargetARB target, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glBindBufferRange_fnptr((uint)target, index, buffer, offset, size);
            
            public static void BindBufferBase(BufferTargetARB target, uint index, int buffer) => GLPointers._glBindBufferBase_fnptr((uint)target, index, buffer);
            
            public static void GetIntegeri_v(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_v_fnptr((uint)target, index, data);
            
            public static void BindVertexArray(int array) => GLPointers._glBindVertexArray_fnptr(array);
            
            public static void DeleteVertexArrays(int n, int* arrays) => GLPointers._glDeleteVertexArrays_fnptr(n, arrays);
            
            public static void GenVertexArrays(int n, int* arrays) => GLPointers._glGenVertexArrays_fnptr(n, arrays);
            
            public static bool IsVertexArray(int array) => GLPointers._glIsVertexArray_fnptr(array) != 0;
            
            public static void VertexAttribL1d(uint index, double x) => GLPointers._glVertexAttribL1d_fnptr(index, x);
            
            public static void VertexAttribL2d(uint index, double x, double y) => GLPointers._glVertexAttribL2d_fnptr(index, x, y);
            
            public static void VertexAttribL3d(uint index, double x, double y, double z) => GLPointers._glVertexAttribL3d_fnptr(index, x, y, z);
            
            public static void VertexAttribL4d(uint index, double x, double y, double z, double w) => GLPointers._glVertexAttribL4d_fnptr(index, x, y, z, w);
            
            public static void VertexAttribL1dv(uint index, double* v) => GLPointers._glVertexAttribL1dv_fnptr(index, v);
            
            public static void VertexAttribL2dv(uint index, double* v) => GLPointers._glVertexAttribL2dv_fnptr(index, v);
            
            public static void VertexAttribL3dv(uint index, double* v) => GLPointers._glVertexAttribL3dv_fnptr(index, v);
            
            public static void VertexAttribL4dv(uint index, double* v) => GLPointers._glVertexAttribL4dv_fnptr(index, v);
            
            public static void VertexAttribLPointer(uint index, int size, VertexAttribLType type, int stride, void* pointer) => GLPointers._glVertexAttribLPointer_fnptr(index, size, (uint)type, stride, pointer);
            
            public static void GetVertexAttribLdv(uint index, VertexAttribEnum pname, double* parameters) => GLPointers._glGetVertexAttribLdv_fnptr(index, (uint)pname, parameters);
            
            public static void BindVertexBuffer(uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glBindVertexBuffer_fnptr(bindingindex, buffer, offset, stride);
            
            public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexAttribFormat_fnptr(attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
            
            public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexAttribIFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
            
            public static void VertexAttribLFormat(uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => GLPointers._glVertexAttribLFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
            
            public static void VertexAttribBinding(uint attribindex, uint bindingindex) => GLPointers._glVertexAttribBinding_fnptr(attribindex, bindingindex);
            
            public static void VertexBindingDivisor(uint bindingindex, uint divisor) => GLPointers._glVertexBindingDivisor_fnptr(bindingindex, divisor);
            
            public static void WeightbvARB(int size, sbyte* weights) => GLPointers._glWeightbvARB_fnptr(size, weights);
            
            public static void WeightsvARB(int size, short* weights) => GLPointers._glWeightsvARB_fnptr(size, weights);
            
            public static void WeightivARB(int size, int* weights) => GLPointers._glWeightivARB_fnptr(size, weights);
            
            public static void WeightfvARB(int size, float* weights) => GLPointers._glWeightfvARB_fnptr(size, weights);
            
            public static void WeightdvARB(int size, double* weights) => GLPointers._glWeightdvARB_fnptr(size, weights);
            
            public static void WeightubvARB(int size, byte* weights) => GLPointers._glWeightubvARB_fnptr(size, weights);
            
            public static void WeightusvARB(int size, ushort* weights) => GLPointers._glWeightusvARB_fnptr(size, weights);
            
            public static void WeightuivARB(int size, uint* weights) => GLPointers._glWeightuivARB_fnptr(size, weights);
            
            public static void WeightPointerARB(int size, WeightPointerTypeARB type, int stride, void* pointer) => GLPointers._glWeightPointerARB_fnptr(size, (uint)type, stride, pointer);
            
            public static void VertexBlendARB(int count) => GLPointers._glVertexBlendARB_fnptr(count);
            
            public static void BindBufferARB(BufferTargetARB target, int buffer) => GLPointers._glBindBufferARB_fnptr((uint)target, buffer);
            
            public static void DeleteBuffersARB(int n, int* buffers) => GLPointers._glDeleteBuffersARB_fnptr(n, buffers);
            
            public static void GenBuffersARB(int n, int* buffers) => GLPointers._glGenBuffersARB_fnptr(n, buffers);
            
            public static bool IsBufferARB(int buffer) => GLPointers._glIsBufferARB_fnptr(buffer) != 0;
            
            public static void BufferDataARB(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._glBufferDataARB_fnptr((uint)target, size, data, (uint)usage);
            
            public static void BufferSubDataARB(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glBufferSubDataARB_fnptr((uint)target, offset, size, data);
            
            public static void GetBufferSubDataARB(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glGetBufferSubDataARB_fnptr((uint)target, offset, size, data);
            
            public static void* MapBufferARB(BufferTargetARB target, BufferAccessARB access) => GLPointers._glMapBufferARB_fnptr((uint)target, (uint)access);
            
            public static bool UnmapBufferARB(BufferTargetARB target) => GLPointers._glUnmapBufferARB_fnptr((uint)target) != 0;
            
            public static void GetBufferParameterivARB(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._glGetBufferParameterivARB_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetBufferPointervARB(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointervARB_fnptr((uint)target, (uint)pname, parameters);
            
            public static void VertexAttrib1dARB(uint index, double x) => GLPointers._glVertexAttrib1dARB_fnptr(index, x);
            
            public static void VertexAttrib1dvARB(uint index, double* v) => GLPointers._glVertexAttrib1dvARB_fnptr(index, v);
            
            public static void VertexAttrib1fARB(uint index, float x) => GLPointers._glVertexAttrib1fARB_fnptr(index, x);
            
            public static void VertexAttrib1fvARB(uint index, float* v) => GLPointers._glVertexAttrib1fvARB_fnptr(index, v);
            
            public static void VertexAttrib1sARB(uint index, short x) => GLPointers._glVertexAttrib1sARB_fnptr(index, x);
            
            public static void VertexAttrib1svARB(uint index, short* v) => GLPointers._glVertexAttrib1svARB_fnptr(index, v);
            
            public static void VertexAttrib2dARB(uint index, double x, double y) => GLPointers._glVertexAttrib2dARB_fnptr(index, x, y);
            
            public static void VertexAttrib2dvARB(uint index, double* v) => GLPointers._glVertexAttrib2dvARB_fnptr(index, v);
            
            public static void VertexAttrib2fARB(uint index, float x, float y) => GLPointers._glVertexAttrib2fARB_fnptr(index, x, y);
            
            public static void VertexAttrib2fvARB(uint index, float* v) => GLPointers._glVertexAttrib2fvARB_fnptr(index, v);
            
            public static void VertexAttrib2sARB(uint index, short x, short y) => GLPointers._glVertexAttrib2sARB_fnptr(index, x, y);
            
            public static void VertexAttrib2svARB(uint index, short* v) => GLPointers._glVertexAttrib2svARB_fnptr(index, v);
            
            public static void VertexAttrib3dARB(uint index, double x, double y, double z) => GLPointers._glVertexAttrib3dARB_fnptr(index, x, y, z);
            
            public static void VertexAttrib3dvARB(uint index, double* v) => GLPointers._glVertexAttrib3dvARB_fnptr(index, v);
            
            public static void VertexAttrib3fARB(uint index, float x, float y, float z) => GLPointers._glVertexAttrib3fARB_fnptr(index, x, y, z);
            
            public static void VertexAttrib3fvARB(uint index, float* v) => GLPointers._glVertexAttrib3fvARB_fnptr(index, v);
            
            public static void VertexAttrib3sARB(uint index, short x, short y, short z) => GLPointers._glVertexAttrib3sARB_fnptr(index, x, y, z);
            
            public static void VertexAttrib3svARB(uint index, short* v) => GLPointers._glVertexAttrib3svARB_fnptr(index, v);
            
            public static void VertexAttrib4NbvARB(uint index, sbyte* v) => GLPointers._glVertexAttrib4NbvARB_fnptr(index, v);
            
            public static void VertexAttrib4NivARB(uint index, int* v) => GLPointers._glVertexAttrib4NivARB_fnptr(index, v);
            
            public static void VertexAttrib4NsvARB(uint index, short* v) => GLPointers._glVertexAttrib4NsvARB_fnptr(index, v);
            
            public static void VertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) => GLPointers._glVertexAttrib4NubARB_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4NubvARB(uint index, byte* v) => GLPointers._glVertexAttrib4NubvARB_fnptr(index, v);
            
            public static void VertexAttrib4NuivARB(uint index, uint* v) => GLPointers._glVertexAttrib4NuivARB_fnptr(index, v);
            
            public static void VertexAttrib4NusvARB(uint index, ushort* v) => GLPointers._glVertexAttrib4NusvARB_fnptr(index, v);
            
            public static void VertexAttrib4bvARB(uint index, sbyte* v) => GLPointers._glVertexAttrib4bvARB_fnptr(index, v);
            
            public static void VertexAttrib4dARB(uint index, double x, double y, double z, double w) => GLPointers._glVertexAttrib4dARB_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4dvARB(uint index, double* v) => GLPointers._glVertexAttrib4dvARB_fnptr(index, v);
            
            public static void VertexAttrib4fARB(uint index, float x, float y, float z, float w) => GLPointers._glVertexAttrib4fARB_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4fvARB(uint index, float* v) => GLPointers._glVertexAttrib4fvARB_fnptr(index, v);
            
            public static void VertexAttrib4ivARB(uint index, int* v) => GLPointers._glVertexAttrib4ivARB_fnptr(index, v);
            
            public static void VertexAttrib4sARB(uint index, short x, short y, short z, short w) => GLPointers._glVertexAttrib4sARB_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4svARB(uint index, short* v) => GLPointers._glVertexAttrib4svARB_fnptr(index, v);
            
            public static void VertexAttrib4ubvARB(uint index, byte* v) => GLPointers._glVertexAttrib4ubvARB_fnptr(index, v);
            
            public static void VertexAttrib4uivARB(uint index, uint* v) => GLPointers._glVertexAttrib4uivARB_fnptr(index, v);
            
            public static void VertexAttrib4usvARB(uint index, ushort* v) => GLPointers._glVertexAttrib4usvARB_fnptr(index, v);
            
            public static void VertexAttribPointerARB(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer) => GLPointers._glVertexAttribPointerARB_fnptr(index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, pointer);
            
            public static void EnableVertexAttribArrayARB(uint index) => GLPointers._glEnableVertexAttribArrayARB_fnptr(index);
            
            public static void DisableVertexAttribArrayARB(uint index) => GLPointers._glDisableVertexAttribArrayARB_fnptr(index);
            
            public static void GetVertexAttribdvARB(uint index, VertexAttribPropertyARB pname, double* parameters) => GLPointers._glGetVertexAttribdvARB_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribfvARB(uint index, VertexAttribPropertyARB pname, float* parameters) => GLPointers._glGetVertexAttribfvARB_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribivARB(uint index, VertexAttribPropertyARB pname, int* parameters) => GLPointers._glGetVertexAttribivARB_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribPointervARB(uint index, VertexAttribPointerPropertyARB pname, void** pointer) => GLPointers._glGetVertexAttribPointervARB_fnptr(index, (uint)pname, pointer);
            
            public static void BindAttribLocationARB(GLHandleARB programObj, uint index, byte* name) => GLPointers._glBindAttribLocationARB_fnptr((IntPtr)programObj, index, name);
            
            public static void GetActiveAttribARB(GLHandleARB programObj, uint index, int maxLength, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetActiveAttribARB_fnptr((IntPtr)programObj, index, maxLength, length, size, (uint*)type, name);
            
            public static int GetAttribLocationARB(GLHandleARB programObj, byte* name) => GLPointers._glGetAttribLocationARB_fnptr((IntPtr)programObj, name);
            
            public static void VertexAttribP1ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP1ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexAttribP1uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP1uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexAttribP2ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP2ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexAttribP2uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP2uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexAttribP3ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP3ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexAttribP3uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP3uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexAttribP4ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => GLPointers._glVertexAttribP4ui_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexAttribP4uiv(uint index, VertexAttribPointerType type, bool normalized, uint* value) => GLPointers._glVertexAttribP4uiv_fnptr(index, (uint)type, (byte)(normalized ? 1 : 0), value);
            
            public static void VertexP2ui(VertexPointerType type, uint value) => GLPointers._glVertexP2ui_fnptr((uint)type, value);
            
            public static void VertexP2uiv(VertexPointerType type, uint* value) => GLPointers._glVertexP2uiv_fnptr((uint)type, value);
            
            public static void VertexP3ui(VertexPointerType type, uint value) => GLPointers._glVertexP3ui_fnptr((uint)type, value);
            
            public static void VertexP3uiv(VertexPointerType type, uint* value) => GLPointers._glVertexP3uiv_fnptr((uint)type, value);
            
            public static void VertexP4ui(VertexPointerType type, uint value) => GLPointers._glVertexP4ui_fnptr((uint)type, value);
            
            public static void VertexP4uiv(VertexPointerType type, uint* value) => GLPointers._glVertexP4uiv_fnptr((uint)type, value);
            
            public static void TexCoordP1ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP1ui_fnptr((uint)type, coords);
            
            public static void TexCoordP1uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP1uiv_fnptr((uint)type, coords);
            
            public static void TexCoordP2ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP2ui_fnptr((uint)type, coords);
            
            public static void TexCoordP2uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP2uiv_fnptr((uint)type, coords);
            
            public static void TexCoordP3ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP3ui_fnptr((uint)type, coords);
            
            public static void TexCoordP3uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP3uiv_fnptr((uint)type, coords);
            
            public static void TexCoordP4ui(TexCoordPointerType type, uint coords) => GLPointers._glTexCoordP4ui_fnptr((uint)type, coords);
            
            public static void TexCoordP4uiv(TexCoordPointerType type, uint* coords) => GLPointers._glTexCoordP4uiv_fnptr((uint)type, coords);
            
            public static void MultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP1ui_fnptr((uint)texture, (uint)type, coords);
            
            public static void MultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP1uiv_fnptr((uint)texture, (uint)type, coords);
            
            public static void MultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP2ui_fnptr((uint)texture, (uint)type, coords);
            
            public static void MultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP2uiv_fnptr((uint)texture, (uint)type, coords);
            
            public static void MultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP3ui_fnptr((uint)texture, (uint)type, coords);
            
            public static void MultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP3uiv_fnptr((uint)texture, (uint)type, coords);
            
            public static void MultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, uint coords) => GLPointers._glMultiTexCoordP4ui_fnptr((uint)texture, (uint)type, coords);
            
            public static void MultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, uint* coords) => GLPointers._glMultiTexCoordP4uiv_fnptr((uint)texture, (uint)type, coords);
            
            public static void NormalP3ui(NormalPointerType type, uint coords) => GLPointers._glNormalP3ui_fnptr((uint)type, coords);
            
            public static void NormalP3uiv(NormalPointerType type, uint* coords) => GLPointers._glNormalP3uiv_fnptr((uint)type, coords);
            
            public static void ColorP3ui(ColorPointerType type, uint color) => GLPointers._glColorP3ui_fnptr((uint)type, color);
            
            public static void ColorP3uiv(ColorPointerType type, uint* color) => GLPointers._glColorP3uiv_fnptr((uint)type, color);
            
            public static void ColorP4ui(ColorPointerType type, uint color) => GLPointers._glColorP4ui_fnptr((uint)type, color);
            
            public static void ColorP4uiv(ColorPointerType type, uint* color) => GLPointers._glColorP4uiv_fnptr((uint)type, color);
            
            public static void SecondaryColorP3ui(ColorPointerType type, uint color) => GLPointers._glSecondaryColorP3ui_fnptr((uint)type, color);
            
            public static void SecondaryColorP3uiv(ColorPointerType type, uint* color) => GLPointers._glSecondaryColorP3uiv_fnptr((uint)type, color);
            
            public static void ViewportArrayv(uint first, int count, float* v) => GLPointers._glViewportArrayv_fnptr(first, count, v);
            
            public static void ViewportIndexedf(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedf_fnptr(index, x, y, w, h);
            
            public static void ViewportIndexedfv(uint index, float* v) => GLPointers._glViewportIndexedfv_fnptr(index, v);
            
            public static void ScissorArrayv(uint first, int count, int* v) => GLPointers._glScissorArrayv_fnptr(first, count, v);
            
            public static void ScissorIndexed(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexed_fnptr(index, left, bottom, width, height);
            
            public static void ScissorIndexedv(uint index, int* v) => GLPointers._glScissorIndexedv_fnptr(index, v);
            
            public static void DepthRangeArrayv(uint first, int count, double* v) => GLPointers._glDepthRangeArrayv_fnptr(first, count, v);
            
            public static void DepthRangeIndexed(uint index, double n, double f) => GLPointers._glDepthRangeIndexed_fnptr(index, n, f);
            
            public static void GetFloati_v(GetPName target, uint index, float* data) => GLPointers._glGetFloati_v_fnptr((uint)target, index, data);
            
            public static void GetDoublei_v(GetPName target, uint index, double* data) => GLPointers._glGetDoublei_v_fnptr((uint)target, index, data);
            
            public static void DepthRangeArraydvNV(uint first, int count, double* v) => GLPointers._glDepthRangeArraydvNV_fnptr(first, count, v);
            
            public static void DepthRangeIndexeddNV(uint index, double n, double f) => GLPointers._glDepthRangeIndexeddNV_fnptr(index, n, f);
            
            public static void WindowPos2dARB(double x, double y) => GLPointers._glWindowPos2dARB_fnptr(x, y);
            
            public static void WindowPos2dvARB(double* v) => GLPointers._glWindowPos2dvARB_fnptr(v);
            
            public static void WindowPos2fARB(float x, float y) => GLPointers._glWindowPos2fARB_fnptr(x, y);
            
            public static void WindowPos2fvARB(float* v) => GLPointers._glWindowPos2fvARB_fnptr(v);
            
            public static void WindowPos2iARB(int x, int y) => GLPointers._glWindowPos2iARB_fnptr(x, y);
            
            public static void WindowPos2ivARB(int* v) => GLPointers._glWindowPos2ivARB_fnptr(v);
            
            public static void WindowPos2sARB(short x, short y) => GLPointers._glWindowPos2sARB_fnptr(x, y);
            
            public static void WindowPos2svARB(short* v) => GLPointers._glWindowPos2svARB_fnptr(v);
            
            public static void WindowPos3dARB(double x, double y, double z) => GLPointers._glWindowPos3dARB_fnptr(x, y, z);
            
            public static void WindowPos3dvARB(double* v) => GLPointers._glWindowPos3dvARB_fnptr(v);
            
            public static void WindowPos3fARB(float x, float y, float z) => GLPointers._glWindowPos3fARB_fnptr(x, y, z);
            
            public static void WindowPos3fvARB(float* v) => GLPointers._glWindowPos3fvARB_fnptr(v);
            
            public static void WindowPos3iARB(int x, int y, int z) => GLPointers._glWindowPos3iARB_fnptr(x, y, z);
            
            public static void WindowPos3ivARB(int* v) => GLPointers._glWindowPos3ivARB_fnptr(v);
            
            public static void WindowPos3sARB(short x, short y, short z) => GLPointers._glWindowPos3sARB_fnptr(x, y, z);
            
            public static void WindowPos3svARB(short* v) => GLPointers._glWindowPos3svARB_fnptr(v);
            
        }
        /// <summary>ATI extensions.</summary>
        public static unsafe partial class ATI
        {
            public static void DrawBuffersATI(int n, DrawBufferMode* bufs) => GLPointers._glDrawBuffersATI_fnptr(n, (uint*)bufs);
            
            public static void ElementPointerATI(ElementPointerTypeATI type, void* pointer) => GLPointers._glElementPointerATI_fnptr((uint)type, pointer);
            
            public static void DrawElementArrayATI(PrimitiveType mode, int count) => GLPointers._glDrawElementArrayATI_fnptr((uint)mode, count);
            
            public static void DrawRangeElementArrayATI(PrimitiveType mode, uint start, uint end, int count) => GLPointers._glDrawRangeElementArrayATI_fnptr((uint)mode, start, end, count);
            
            public static void TexBumpParameterivATI(TexBumpParameterATI pname, int* param) => GLPointers._glTexBumpParameterivATI_fnptr((uint)pname, param);
            
            public static void TexBumpParameterfvATI(TexBumpParameterATI pname, float* param) => GLPointers._glTexBumpParameterfvATI_fnptr((uint)pname, param);
            
            public static void GetTexBumpParameterivATI(GetTexBumpParameterATI pname, int* param) => GLPointers._glGetTexBumpParameterivATI_fnptr((uint)pname, param);
            
            public static void GetTexBumpParameterfvATI(GetTexBumpParameterATI pname, float* param) => GLPointers._glGetTexBumpParameterfvATI_fnptr((uint)pname, param);
            
            public static uint GenFragmentShadersATI(uint range) => GLPointers._glGenFragmentShadersATI_fnptr(range);
            
            public static void BindFragmentShaderATI(uint id) => GLPointers._glBindFragmentShaderATI_fnptr(id);
            
            public static void DeleteFragmentShaderATI(uint id) => GLPointers._glDeleteFragmentShaderATI_fnptr(id);
            
            public static void BeginFragmentShaderATI() => GLPointers._glBeginFragmentShaderATI_fnptr();
            
            public static void EndFragmentShaderATI() => GLPointers._glEndFragmentShaderATI_fnptr();
            
            public static void PassTexCoordATI(FragmentShaderRegATI dst, FragmentShaderTextureSourceATI coord, SwizzleOpATI swizzle) => GLPointers._glPassTexCoordATI_fnptr((uint)dst, (uint)coord, (uint)swizzle);
            
            public static void SampleMapATI(FragmentShaderRegATI dst, FragmentShaderTextureSourceATI interp, SwizzleOpATI swizzle) => GLPointers._glSampleMapATI_fnptr((uint)dst, (uint)interp, (uint)swizzle);
            
            public static void ColorFragmentOp1ATI(FragmentOp1ATI op, FragmentShaderRegATI dst, FragmentShaderDestMaskATI dstMask, FragmentShaderDestModMaskATI dstMod, FragmentShaderGenericSourceATI arg1, FragmentShaderValueRepATI arg1Rep, FragmentShaderColorModMaskATI arg1Mod) => GLPointers._glColorFragmentOp1ATI_fnptr((uint)op, (uint)dst, (uint)dstMask, (uint)dstMod, (uint)arg1, (uint)arg1Rep, (uint)arg1Mod);
            
            public static void ColorFragmentOp2ATI(FragmentOp2ATI op, FragmentShaderRegATI dst, FragmentShaderDestMaskATI dstMask, FragmentShaderDestModMaskATI dstMod, FragmentShaderGenericSourceATI arg1, FragmentShaderValueRepATI arg1Rep, FragmentShaderColorModMaskATI arg1Mod, FragmentShaderGenericSourceATI arg2, FragmentShaderValueRepATI arg2Rep, FragmentShaderColorModMaskATI arg2Mod) => GLPointers._glColorFragmentOp2ATI_fnptr((uint)op, (uint)dst, (uint)dstMask, (uint)dstMod, (uint)arg1, (uint)arg1Rep, (uint)arg1Mod, (uint)arg2, (uint)arg2Rep, (uint)arg2Mod);
            
            public static void ColorFragmentOp3ATI(FragmentOp3ATI op, FragmentShaderRegATI dst, FragmentShaderDestMaskATI dstMask, FragmentShaderDestModMaskATI dstMod, FragmentShaderGenericSourceATI arg1, FragmentShaderValueRepATI arg1Rep, FragmentShaderColorModMaskATI arg1Mod, FragmentShaderGenericSourceATI arg2, FragmentShaderValueRepATI arg2Rep, FragmentShaderColorModMaskATI arg2Mod, FragmentShaderGenericSourceATI arg3, FragmentShaderValueRepATI arg3Rep, FragmentShaderColorModMaskATI arg3Mod) => GLPointers._glColorFragmentOp3ATI_fnptr((uint)op, (uint)dst, (uint)dstMask, (uint)dstMod, (uint)arg1, (uint)arg1Rep, (uint)arg1Mod, (uint)arg2, (uint)arg2Rep, (uint)arg2Mod, (uint)arg3, (uint)arg3Rep, (uint)arg3Mod);
            
            public static void AlphaFragmentOp1ATI(FragmentOp1ATI op, FragmentShaderRegATI dst, FragmentShaderDestModMaskATI dstMod, FragmentShaderGenericSourceATI arg1, FragmentShaderValueRepATI arg1Rep, FragmentShaderColorModMaskATI arg1Mod) => GLPointers._glAlphaFragmentOp1ATI_fnptr((uint)op, (uint)dst, (uint)dstMod, (uint)arg1, (uint)arg1Rep, (uint)arg1Mod);
            
            public static void AlphaFragmentOp2ATI(FragmentOp2ATI op, FragmentShaderRegATI dst, FragmentShaderDestModMaskATI dstMod, FragmentShaderGenericSourceATI arg1, FragmentShaderValueRepATI arg1Rep, FragmentShaderColorModMaskATI arg1Mod, FragmentShaderGenericSourceATI arg2, FragmentShaderValueRepATI arg2Rep, FragmentShaderColorModMaskATI arg2Mod) => GLPointers._glAlphaFragmentOp2ATI_fnptr((uint)op, (uint)dst, (uint)dstMod, (uint)arg1, (uint)arg1Rep, (uint)arg1Mod, (uint)arg2, (uint)arg2Rep, (uint)arg2Mod);
            
            public static void AlphaFragmentOp3ATI(FragmentOp3ATI op, FragmentShaderRegATI dst, FragmentShaderDestModMaskATI dstMod, FragmentShaderGenericSourceATI arg1, FragmentShaderValueRepATI arg1Rep, FragmentShaderColorModMaskATI arg1Mod, FragmentShaderGenericSourceATI arg2, FragmentShaderValueRepATI arg2Rep, FragmentShaderColorModMaskATI arg2Mod, FragmentShaderGenericSourceATI arg3, FragmentShaderValueRepATI arg3Rep, FragmentShaderColorModMaskATI arg3Mod) => GLPointers._glAlphaFragmentOp3ATI_fnptr((uint)op, (uint)dst, (uint)dstMod, (uint)arg1, (uint)arg1Rep, (uint)arg1Mod, (uint)arg2, (uint)arg2Rep, (uint)arg2Mod, (uint)arg3, (uint)arg3Rep, (uint)arg3Mod);
            
            public static void SetFragmentShaderConstantATI(FragmentShaderConATI dst, float* value) => GLPointers._glSetFragmentShaderConstantATI_fnptr((uint)dst, value);
            
            public static void* MapObjectBufferATI(int buffer) => GLPointers._glMapObjectBufferATI_fnptr(buffer);
            
            public static void UnmapObjectBufferATI(int buffer) => GLPointers._glUnmapObjectBufferATI_fnptr(buffer);
            
            public static void PNTrianglesiATI(PNTrianglesPNameATI pname, int param) => GLPointers._glPNTrianglesiATI_fnptr((uint)pname, param);
            
            public static void PNTrianglesfATI(PNTrianglesPNameATI pname, float param) => GLPointers._glPNTrianglesfATI_fnptr((uint)pname, param);
            
            public static void StencilOpSeparateATI(TriangleFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => GLPointers._glStencilOpSeparateATI_fnptr((uint)face, (uint)sfail, (uint)dpfail, (uint)dppass);
            
            public static void StencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, int reference, uint mask) => GLPointers._glStencilFuncSeparateATI_fnptr((uint)frontfunc, (uint)backfunc, reference, mask);
            
            public static uint NewObjectBufferATI(int size, void* pointer, ArrayObjectUsageATI usage) => GLPointers._glNewObjectBufferATI_fnptr(size, pointer, (uint)usage);
            
            public static bool IsObjectBufferATI(int buffer) => GLPointers._glIsObjectBufferATI_fnptr(buffer) != 0;
            
            public static void UpdateObjectBufferATI(int buffer, uint offset, int size, void* pointer, PreserveModeATI preserve) => GLPointers._glUpdateObjectBufferATI_fnptr(buffer, offset, size, pointer, (uint)preserve);
            
            public static void GetObjectBufferfvATI(int buffer, ArrayObjectPNameATI pname, float* parameters) => GLPointers._glGetObjectBufferfvATI_fnptr(buffer, (uint)pname, parameters);
            
            public static void GetObjectBufferivATI(int buffer, ArrayObjectPNameATI pname, int* parameters) => GLPointers._glGetObjectBufferivATI_fnptr(buffer, (uint)pname, parameters);
            
            public static void FreeObjectBufferATI(int buffer) => GLPointers._glFreeObjectBufferATI_fnptr(buffer);
            
            public static void ArrayObjectATI(EnableCap array, int size, ScalarType type, int stride, int buffer, uint offset) => GLPointers._glArrayObjectATI_fnptr((uint)array, size, (uint)type, stride, buffer, offset);
            
            public static void GetArrayObjectfvATI(EnableCap array, ArrayObjectPNameATI pname, float* parameters) => GLPointers._glGetArrayObjectfvATI_fnptr((uint)array, (uint)pname, parameters);
            
            public static void GetArrayObjectivATI(EnableCap array, ArrayObjectPNameATI pname, int* parameters) => GLPointers._glGetArrayObjectivATI_fnptr((uint)array, (uint)pname, parameters);
            
            public static void VariantArrayObjectATI(uint id, ScalarType type, int stride, int buffer, uint offset) => GLPointers._glVariantArrayObjectATI_fnptr(id, (uint)type, stride, buffer, offset);
            
            public static void GetVariantArrayObjectfvATI(uint id, ArrayObjectPNameATI pname, float* parameters) => GLPointers._glGetVariantArrayObjectfvATI_fnptr(id, (uint)pname, parameters);
            
            public static void GetVariantArrayObjectivATI(uint id, ArrayObjectPNameATI pname, int* parameters) => GLPointers._glGetVariantArrayObjectivATI_fnptr(id, (uint)pname, parameters);
            
            public static void VertexAttribArrayObjectATI(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, int buffer, uint offset) => GLPointers._glVertexAttribArrayObjectATI_fnptr(index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, buffer, offset);
            
            public static void GetVertexAttribArrayObjectfvATI(uint index, ArrayObjectPNameATI pname, float* parameters) => GLPointers._glGetVertexAttribArrayObjectfvATI_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribArrayObjectivATI(uint index, ArrayObjectPNameATI pname, int* parameters) => GLPointers._glGetVertexAttribArrayObjectivATI_fnptr(index, (uint)pname, parameters);
            
            public static void VertexStream1sATI(VertexStreamATI stream, short x) => GLPointers._glVertexStream1sATI_fnptr((uint)stream, x);
            
            public static void VertexStream1svATI(VertexStreamATI stream, short* coords) => GLPointers._glVertexStream1svATI_fnptr((uint)stream, coords);
            
            public static void VertexStream1iATI(VertexStreamATI stream, int x) => GLPointers._glVertexStream1iATI_fnptr((uint)stream, x);
            
            public static void VertexStream1ivATI(VertexStreamATI stream, int* coords) => GLPointers._glVertexStream1ivATI_fnptr((uint)stream, coords);
            
            public static void VertexStream1fATI(VertexStreamATI stream, float x) => GLPointers._glVertexStream1fATI_fnptr((uint)stream, x);
            
            public static void VertexStream1fvATI(VertexStreamATI stream, float* coords) => GLPointers._glVertexStream1fvATI_fnptr((uint)stream, coords);
            
            public static void VertexStream1dATI(VertexStreamATI stream, double x) => GLPointers._glVertexStream1dATI_fnptr((uint)stream, x);
            
            public static void VertexStream1dvATI(VertexStreamATI stream, double* coords) => GLPointers._glVertexStream1dvATI_fnptr((uint)stream, coords);
            
            public static void VertexStream2sATI(VertexStreamATI stream, short x, short y) => GLPointers._glVertexStream2sATI_fnptr((uint)stream, x, y);
            
            public static void VertexStream2svATI(VertexStreamATI stream, short* coords) => GLPointers._glVertexStream2svATI_fnptr((uint)stream, coords);
            
            public static void VertexStream2iATI(VertexStreamATI stream, int x, int y) => GLPointers._glVertexStream2iATI_fnptr((uint)stream, x, y);
            
            public static void VertexStream2ivATI(VertexStreamATI stream, int* coords) => GLPointers._glVertexStream2ivATI_fnptr((uint)stream, coords);
            
            public static void VertexStream2fATI(VertexStreamATI stream, float x, float y) => GLPointers._glVertexStream2fATI_fnptr((uint)stream, x, y);
            
            public static void VertexStream2fvATI(VertexStreamATI stream, float* coords) => GLPointers._glVertexStream2fvATI_fnptr((uint)stream, coords);
            
            public static void VertexStream2dATI(VertexStreamATI stream, double x, double y) => GLPointers._glVertexStream2dATI_fnptr((uint)stream, x, y);
            
            public static void VertexStream2dvATI(VertexStreamATI stream, double* coords) => GLPointers._glVertexStream2dvATI_fnptr((uint)stream, coords);
            
            public static void VertexStream3sATI(VertexStreamATI stream, short x, short y, short z) => GLPointers._glVertexStream3sATI_fnptr((uint)stream, x, y, z);
            
            public static void VertexStream3svATI(VertexStreamATI stream, short* coords) => GLPointers._glVertexStream3svATI_fnptr((uint)stream, coords);
            
            public static void VertexStream3iATI(VertexStreamATI stream, int x, int y, int z) => GLPointers._glVertexStream3iATI_fnptr((uint)stream, x, y, z);
            
            public static void VertexStream3ivATI(VertexStreamATI stream, int* coords) => GLPointers._glVertexStream3ivATI_fnptr((uint)stream, coords);
            
            public static void VertexStream3fATI(VertexStreamATI stream, float x, float y, float z) => GLPointers._glVertexStream3fATI_fnptr((uint)stream, x, y, z);
            
            public static void VertexStream3fvATI(VertexStreamATI stream, float* coords) => GLPointers._glVertexStream3fvATI_fnptr((uint)stream, coords);
            
            public static void VertexStream3dATI(VertexStreamATI stream, double x, double y, double z) => GLPointers._glVertexStream3dATI_fnptr((uint)stream, x, y, z);
            
            public static void VertexStream3dvATI(VertexStreamATI stream, double* coords) => GLPointers._glVertexStream3dvATI_fnptr((uint)stream, coords);
            
            public static void VertexStream4sATI(VertexStreamATI stream, short x, short y, short z, short w) => GLPointers._glVertexStream4sATI_fnptr((uint)stream, x, y, z, w);
            
            public static void VertexStream4svATI(VertexStreamATI stream, short* coords) => GLPointers._glVertexStream4svATI_fnptr((uint)stream, coords);
            
            public static void VertexStream4iATI(VertexStreamATI stream, int x, int y, int z, int w) => GLPointers._glVertexStream4iATI_fnptr((uint)stream, x, y, z, w);
            
            public static void VertexStream4ivATI(VertexStreamATI stream, int* coords) => GLPointers._glVertexStream4ivATI_fnptr((uint)stream, coords);
            
            public static void VertexStream4fATI(VertexStreamATI stream, float x, float y, float z, float w) => GLPointers._glVertexStream4fATI_fnptr((uint)stream, x, y, z, w);
            
            public static void VertexStream4fvATI(VertexStreamATI stream, float* coords) => GLPointers._glVertexStream4fvATI_fnptr((uint)stream, coords);
            
            public static void VertexStream4dATI(VertexStreamATI stream, double x, double y, double z, double w) => GLPointers._glVertexStream4dATI_fnptr((uint)stream, x, y, z, w);
            
            public static void VertexStream4dvATI(VertexStreamATI stream, double* coords) => GLPointers._glVertexStream4dvATI_fnptr((uint)stream, coords);
            
            public static void NormalStream3bATI(VertexStreamATI stream, sbyte nx, sbyte ny, sbyte nz) => GLPointers._glNormalStream3bATI_fnptr((uint)stream, nx, ny, nz);
            
            public static void NormalStream3bvATI(VertexStreamATI stream, sbyte* coords) => GLPointers._glNormalStream3bvATI_fnptr((uint)stream, coords);
            
            public static void NormalStream3sATI(VertexStreamATI stream, short nx, short ny, short nz) => GLPointers._glNormalStream3sATI_fnptr((uint)stream, nx, ny, nz);
            
            public static void NormalStream3svATI(VertexStreamATI stream, short* coords) => GLPointers._glNormalStream3svATI_fnptr((uint)stream, coords);
            
            public static void NormalStream3iATI(VertexStreamATI stream, int nx, int ny, int nz) => GLPointers._glNormalStream3iATI_fnptr((uint)stream, nx, ny, nz);
            
            public static void NormalStream3ivATI(VertexStreamATI stream, int* coords) => GLPointers._glNormalStream3ivATI_fnptr((uint)stream, coords);
            
            public static void NormalStream3fATI(VertexStreamATI stream, float nx, float ny, float nz) => GLPointers._glNormalStream3fATI_fnptr((uint)stream, nx, ny, nz);
            
            public static void NormalStream3fvATI(VertexStreamATI stream, float* coords) => GLPointers._glNormalStream3fvATI_fnptr((uint)stream, coords);
            
            public static void NormalStream3dATI(VertexStreamATI stream, double nx, double ny, double nz) => GLPointers._glNormalStream3dATI_fnptr((uint)stream, nx, ny, nz);
            
            public static void NormalStream3dvATI(VertexStreamATI stream, double* coords) => GLPointers._glNormalStream3dvATI_fnptr((uint)stream, coords);
            
            public static void ClientActiveVertexStreamATI(VertexStreamATI stream) => GLPointers._glClientActiveVertexStreamATI_fnptr((uint)stream);
            
            public static void VertexBlendEnviATI(VertexStreamATI pname, int param) => GLPointers._glVertexBlendEnviATI_fnptr((uint)pname, param);
            
            public static void VertexBlendEnvfATI(VertexStreamATI pname, float param) => GLPointers._glVertexBlendEnvfATI_fnptr((uint)pname, param);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            public static void EGLImageTargetTexStorageEXT(All target, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTexStorageEXT_fnptr((uint)target, image, attrib_list);
            
            public static void EGLImageTargetTextureStorageEXT(int texture, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTextureStorageEXT_fnptr(texture, image, attrib_list);
            
            public static void UniformBufferEXT(int program, int location, int buffer) => GLPointers._glUniformBufferEXT_fnptr(program, location, buffer);
            
            public static int GetUniformBufferSizeEXT(int program, int location) => GLPointers._glGetUniformBufferSizeEXT_fnptr(program, location);
            
            public static IntPtr GetUniformOffsetEXT(int program, int location) => GLPointers._glGetUniformOffsetEXT_fnptr(program, location);
            
            public static void BlendColorEXT(float red, float green, float blue, float alpha) => GLPointers._glBlendColorEXT_fnptr(red, green, blue, alpha);
            
            public static void BlendEquationSeparateEXT(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateEXT_fnptr((uint)modeRGB, (uint)modeAlpha);
            
            public static void BlendFuncSeparateEXT(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => GLPointers._glBlendFuncSeparateEXT_fnptr((uint)sfactorRGB, (uint)dfactorRGB, (uint)sfactorAlpha, (uint)dfactorAlpha);
            
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => GLPointers._glBlendEquationEXT_fnptr((uint)mode);
            
            public static void ColorSubTableEXT(ColorTableTarget target, int start, int count, PixelFormat format, PixelType type, void* data) => GLPointers._glColorSubTableEXT_fnptr((uint)target, start, count, (uint)format, (uint)type, data);
            
            public static void CopyColorSubTableEXT(ColorTableTarget target, int start, int x, int y, int width) => GLPointers._glCopyColorSubTableEXT_fnptr((uint)target, start, x, y, width);
            
            public static void LockArraysEXT(int first, int count) => GLPointers._glLockArraysEXT_fnptr(first, count);
            
            public static void UnlockArraysEXT() => GLPointers._glUnlockArraysEXT_fnptr();
            
            public static void ConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int width, PixelFormat format, PixelType type, void* image) => GLPointers._glConvolutionFilter1DEXT_fnptr((uint)target, (uint)internalformat, width, (uint)format, (uint)type, image);
            
            public static void ConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* image) => GLPointers._glConvolutionFilter2DEXT_fnptr((uint)target, (uint)internalformat, width, height, (uint)format, (uint)type, image);
            
            public static void ConvolutionParameterfEXT(ConvolutionTargetEXT target, ConvolutionParameter pname, float parameters) => GLPointers._glConvolutionParameterfEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameter pname, float* parameters) => GLPointers._glConvolutionParameterfvEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ConvolutionParameteriEXT(ConvolutionTargetEXT target, ConvolutionParameter pname, int parameters) => GLPointers._glConvolutionParameteriEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameter pname, int* parameters) => GLPointers._glConvolutionParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void CopyConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, int width) => GLPointers._glCopyConvolutionFilter1DEXT_fnptr((uint)target, (uint)internalformat, x, y, width);
            
            public static void CopyConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, int width, int height) => GLPointers._glCopyConvolutionFilter2DEXT_fnptr((uint)target, (uint)internalformat, x, y, width, height);
            
            public static void GetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, void* image) => GLPointers._glGetConvolutionFilterEXT_fnptr((uint)target, (uint)format, (uint)type, image);
            
            public static void GetConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameter pname, float* parameters) => GLPointers._glGetConvolutionParameterfvEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameter pname, int* parameters) => GLPointers._glGetConvolutionParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, void* row, void* column, void* span) => GLPointers._glGetSeparableFilterEXT_fnptr((uint)target, (uint)format, (uint)type, row, column, span);
            
            public static void SeparableFilter2DEXT(SeparableTargetEXT target, InternalFormat internalformat, int width, int height, PixelFormat format, PixelType type, void* row, void* column) => GLPointers._glSeparableFilter2DEXT_fnptr((uint)target, (uint)internalformat, width, height, (uint)format, (uint)type, row, column);
            
            public static void Tangent3bEXT(sbyte tx, sbyte ty, sbyte tz) => GLPointers._glTangent3bEXT_fnptr(tx, ty, tz);
            
            public static void Tangent3bvEXT(sbyte* v) => GLPointers._glTangent3bvEXT_fnptr(v);
            
            public static void Tangent3dEXT(double tx, double ty, double tz) => GLPointers._glTangent3dEXT_fnptr(tx, ty, tz);
            
            public static void Tangent3dvEXT(double* v) => GLPointers._glTangent3dvEXT_fnptr(v);
            
            public static void Tangent3fEXT(float tx, float ty, float tz) => GLPointers._glTangent3fEXT_fnptr(tx, ty, tz);
            
            public static void Tangent3fvEXT(float* v) => GLPointers._glTangent3fvEXT_fnptr(v);
            
            public static void Tangent3iEXT(int tx, int ty, int tz) => GLPointers._glTangent3iEXT_fnptr(tx, ty, tz);
            
            public static void Tangent3ivEXT(int* v) => GLPointers._glTangent3ivEXT_fnptr(v);
            
            public static void Tangent3sEXT(short tx, short ty, short tz) => GLPointers._glTangent3sEXT_fnptr(tx, ty, tz);
            
            public static void Tangent3svEXT(short* v) => GLPointers._glTangent3svEXT_fnptr(v);
            
            public static void Binormal3bEXT(sbyte bx, sbyte by, sbyte bz) => GLPointers._glBinormal3bEXT_fnptr(bx, by, bz);
            
            public static void Binormal3bvEXT(sbyte* v) => GLPointers._glBinormal3bvEXT_fnptr(v);
            
            public static void Binormal3dEXT(double bx, double by, double bz) => GLPointers._glBinormal3dEXT_fnptr(bx, by, bz);
            
            public static void Binormal3dvEXT(double* v) => GLPointers._glBinormal3dvEXT_fnptr(v);
            
            public static void Binormal3fEXT(float bx, float by, float bz) => GLPointers._glBinormal3fEXT_fnptr(bx, by, bz);
            
            public static void Binormal3fvEXT(float* v) => GLPointers._glBinormal3fvEXT_fnptr(v);
            
            public static void Binormal3iEXT(int bx, int by, int bz) => GLPointers._glBinormal3iEXT_fnptr(bx, by, bz);
            
            public static void Binormal3ivEXT(int* v) => GLPointers._glBinormal3ivEXT_fnptr(v);
            
            public static void Binormal3sEXT(short bx, short by, short bz) => GLPointers._glBinormal3sEXT_fnptr(bx, by, bz);
            
            public static void Binormal3svEXT(short* v) => GLPointers._glBinormal3svEXT_fnptr(v);
            
            public static void TangentPointerEXT(TangentPointerTypeEXT type, int stride, void* pointer) => GLPointers._glTangentPointerEXT_fnptr((uint)type, stride, pointer);
            
            public static void BinormalPointerEXT(BinormalPointerTypeEXT type, int stride, void* pointer) => GLPointers._glBinormalPointerEXT_fnptr((uint)type, stride, pointer);
            
            public static void CopyTexImage1DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border) => GLPointers._glCopyTexImage1DEXT_fnptr((uint)target, level, (uint)internalformat, x, y, width, border);
            
            public static void CopyTexImage2DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyTexImage2DEXT_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
            
            public static void CopyTexSubImage1DEXT(TextureTarget target, int level, int xoffset, int x, int y, int width) => GLPointers._glCopyTexSubImage1DEXT_fnptr((uint)target, level, xoffset, x, y, width);
            
            public static void CopyTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage2DEXT_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
            
            public static void CopyTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage3DEXT_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            public static void CullParameterdvEXT(CullParameterEXT pname, double* parameters) => GLPointers._glCullParameterdvEXT_fnptr((uint)pname, parameters);
            
            public static void CullParameterfvEXT(CullParameterEXT pname, float* parameters) => GLPointers._glCullParameterfvEXT_fnptr((uint)pname, parameters);
            
            public static void LabelObjectEXT(All type, uint obj, int length, byte* label) => GLPointers._glLabelObjectEXT_fnptr((uint)type, obj, length, label);
            
            public static void GetObjectLabelEXT(All type, uint obj, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelEXT_fnptr((uint)type, obj, bufSize, length, label);
            
            public static void InsertEventMarkerEXT(int length, byte* marker) => GLPointers._glInsertEventMarkerEXT_fnptr(length, marker);
            
            public static void PushGroupMarkerEXT(int length, byte* marker) => GLPointers._glPushGroupMarkerEXT_fnptr(length, marker);
            
            public static void PopGroupMarkerEXT() => GLPointers._glPopGroupMarkerEXT_fnptr();
            
            public static void DepthBoundsEXT(double zmin, double zmax) => GLPointers._glDepthBoundsEXT_fnptr(zmin, zmax);
            
            public static void MatrixLoadfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadfEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoaddEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoaddEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultfEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultdEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultdEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoadIdentityEXT(MatrixMode mode) => GLPointers._glMatrixLoadIdentityEXT_fnptr((uint)mode);
            
            public static void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => GLPointers._glMatrixRotatefEXT_fnptr((uint)mode, angle, x, y, z);
            
            public static void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => GLPointers._glMatrixRotatedEXT_fnptr((uint)mode, angle, x, y, z);
            
            public static void MatrixScalefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixScalefEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixScaledEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixScaledEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixTranslatefEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixTranslatedEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixFrustumEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixOrthoEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            public static void MatrixPopEXT(MatrixMode mode) => GLPointers._glMatrixPopEXT_fnptr((uint)mode);
            
            public static void MatrixPushEXT(MatrixMode mode) => GLPointers._glMatrixPushEXT_fnptr((uint)mode);
            
            public static void ClientAttribDefaultEXT(ClientAttribMask mask) => GLPointers._glClientAttribDefaultEXT_fnptr((uint)mask);
            
            public static void PushClientAttribDefaultEXT(ClientAttribMask mask) => GLPointers._glPushClientAttribDefaultEXT_fnptr((uint)mask);
            
            public static void TextureParameterfEXT(int texture, TextureTarget target, TextureParameterName pname, float param) => GLPointers._glTextureParameterfEXT_fnptr(texture, (uint)target, (uint)pname, param);
            
            public static void TextureParameterfvEXT(int texture, TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glTextureParameterfvEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void TextureParameteriEXT(int texture, TextureTarget target, TextureParameterName pname, int param) => GLPointers._glTextureParameteriEXT_fnptr(texture, (uint)target, (uint)pname, param);
            
            public static void TextureParameterivEXT(int texture, TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTextureParameterivEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void TextureImage1DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureImage1DEXT_fnptr(texture, (uint)target, level, (int)internalformat, width, border, (uint)format, (uint)type, pixels);
            
            public static void TextureImage2DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureImage2DEXT_fnptr(texture, (uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
            
            public static void TextureSubImage1DEXT(int texture, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage1DEXT_fnptr(texture, (uint)target, level, xoffset, width, (uint)format, (uint)type, pixels);
            
            public static void TextureSubImage2DEXT(int texture, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage2DEXT_fnptr(texture, (uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
            
            public static void CopyTextureImage1DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border) => GLPointers._glCopyTextureImage1DEXT_fnptr(texture, (uint)target, level, (uint)internalformat, x, y, width, border);
            
            public static void CopyTextureImage2DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyTextureImage2DEXT_fnptr(texture, (uint)target, level, (uint)internalformat, x, y, width, height, border);
            
            public static void CopyTextureSubImage1DEXT(int texture, TextureTarget target, int level, int xoffset, int x, int y, int width) => GLPointers._glCopyTextureSubImage1DEXT_fnptr(texture, (uint)target, level, xoffset, x, y, width);
            
            public static void CopyTextureSubImage2DEXT(int texture, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTextureSubImage2DEXT_fnptr(texture, (uint)target, level, xoffset, yoffset, x, y, width, height);
            
            public static void GetTextureImageEXT(int texture, TextureTarget target, int level, PixelFormat format, PixelType type, void* pixels) => GLPointers._glGetTextureImageEXT_fnptr(texture, (uint)target, level, (uint)format, (uint)type, pixels);
            
            public static void GetTextureParameterfvEXT(int texture, TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetTextureParameterfvEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void GetTextureParameterivEXT(int texture, TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureParameterivEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void GetTextureLevelParameterfvEXT(int texture, TextureTarget target, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetTextureLevelParameterfvEXT_fnptr(texture, (uint)target, level, (uint)pname, parameters);
            
            public static void GetTextureLevelParameterivEXT(int texture, TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureLevelParameterivEXT_fnptr(texture, (uint)target, level, (uint)pname, parameters);
            
            public static void TextureImage3DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureImage3DEXT_fnptr(texture, (uint)target, level, (int)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
            
            public static void TextureSubImage3DEXT(int texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTextureSubImage3DEXT_fnptr(texture, (uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            public static void CopyTextureSubImage3DEXT(int texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTextureSubImage3DEXT_fnptr(texture, (uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            public static void BindMultiTextureEXT(TextureUnit texunit, TextureTarget target, int texture) => GLPointers._glBindMultiTextureEXT_fnptr((uint)texunit, (uint)target, texture);
            
            public static void MultiTexCoordPointerEXT(TextureUnit texunit, int size, TexCoordPointerType type, int stride, void* pointer) => GLPointers._glMultiTexCoordPointerEXT_fnptr((uint)texunit, size, (uint)type, stride, pointer);
            
            public static void MultiTexEnvfEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float param) => GLPointers._glMultiTexEnvfEXT_fnptr((uint)texunit, (uint)target, (uint)pname, param);
            
            public static void MultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glMultiTexEnvfvEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void MultiTexEnviEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glMultiTexEnviEXT_fnptr((uint)texunit, (uint)target, (uint)pname, param);
            
            public static void MultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glMultiTexEnvivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void MultiTexGendEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double param) => GLPointers._glMultiTexGendEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, param);
            
            public static void MultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double* parameters) => GLPointers._glMultiTexGendvEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, parameters);
            
            public static void MultiTexGenfEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float param) => GLPointers._glMultiTexGenfEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, param);
            
            public static void MultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glMultiTexGenfvEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, parameters);
            
            public static void MultiTexGeniEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._glMultiTexGeniEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, param);
            
            public static void MultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glMultiTexGenivEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, parameters);
            
            public static void GetMultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glGetMultiTexEnvfvEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void GetMultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetMultiTexEnvivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void GetMultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double* parameters) => GLPointers._glGetMultiTexGendvEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, parameters);
            
            public static void GetMultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glGetMultiTexGenfvEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, parameters);
            
            public static void GetMultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glGetMultiTexGenivEXT_fnptr((uint)texunit, (uint)coord, (uint)pname, parameters);
            
            public static void MultiTexParameteriEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int param) => GLPointers._glMultiTexParameteriEXT_fnptr((uint)texunit, (uint)target, (uint)pname, param);
            
            public static void MultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glMultiTexParameterivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void MultiTexParameterfEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float param) => GLPointers._glMultiTexParameterfEXT_fnptr((uint)texunit, (uint)target, (uint)pname, param);
            
            public static void MultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glMultiTexParameterfvEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void MultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glMultiTexImage1DEXT_fnptr((uint)texunit, (uint)target, level, (int)internalformat, width, border, (uint)format, (uint)type, pixels);
            
            public static void MultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glMultiTexImage2DEXT_fnptr((uint)texunit, (uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
            
            public static void MultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels) => GLPointers._glMultiTexSubImage1DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, width, (uint)format, (uint)type, pixels);
            
            public static void MultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glMultiTexSubImage2DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
            
            public static void CopyMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border) => GLPointers._glCopyMultiTexImage1DEXT_fnptr((uint)texunit, (uint)target, level, (uint)internalformat, x, y, width, border);
            
            public static void CopyMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyMultiTexImage2DEXT_fnptr((uint)texunit, (uint)target, level, (uint)internalformat, x, y, width, height, border);
            
            public static void CopyMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int x, int y, int width) => GLPointers._glCopyMultiTexSubImage1DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, x, y, width);
            
            public static void CopyMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyMultiTexSubImage2DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, yoffset, x, y, width, height);
            
            public static void GetMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int level, PixelFormat format, PixelType type, void* pixels) => GLPointers._glGetMultiTexImageEXT_fnptr((uint)texunit, (uint)target, level, (uint)format, (uint)type, pixels);
            
            public static void GetMultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetMultiTexParameterfvEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void GetMultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetMultiTexParameterivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void GetMultiTexLevelParameterfvEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetMultiTexLevelParameterfvEXT_fnptr((uint)texunit, (uint)target, level, (uint)pname, parameters);
            
            public static void GetMultiTexLevelParameterivEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetMultiTexLevelParameterivEXT_fnptr((uint)texunit, (uint)target, level, (uint)pname, parameters);
            
            public static void MultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glMultiTexImage3DEXT_fnptr((uint)texunit, (uint)target, level, (int)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
            
            public static void MultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glMultiTexSubImage3DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            public static void CopyMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyMultiTexSubImage3DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            public static void EnableClientStateIndexedEXT(EnableCap array, uint index) => GLPointers._glEnableClientStateIndexedEXT_fnptr((uint)array, index);
            
            public static void DisableClientStateIndexedEXT(EnableCap array, uint index) => GLPointers._glDisableClientStateIndexedEXT_fnptr((uint)array, index);
            
            public static void GetFloatIndexedvEXT(GetPName target, uint index, float* data) => GLPointers._glGetFloatIndexedvEXT_fnptr((uint)target, index, data);
            
            public static void GetDoubleIndexedvEXT(GetPName target, uint index, double* data) => GLPointers._glGetDoubleIndexedvEXT_fnptr((uint)target, index, data);
            
            public static void GetPointerIndexedvEXT(All target, uint index, void** data) => GLPointers._glGetPointerIndexedvEXT_fnptr((uint)target, index, data);
            
            public static void EnableIndexedEXT(EnableCap target, uint index) => GLPointers._glEnableIndexedEXT_fnptr((uint)target, index);
            
            public static void DisableIndexedEXT(EnableCap target, uint index) => GLPointers._glDisableIndexedEXT_fnptr((uint)target, index);
            
            public static bool IsEnabledIndexedEXT(EnableCap target, uint index) => GLPointers._glIsEnabledIndexedEXT_fnptr((uint)target, index) != 0;
            
            public static void GetIntegerIndexedvEXT(GetPName target, uint index, int* data) => GLPointers._glGetIntegerIndexedvEXT_fnptr((uint)target, index, data);
            
            public static void GetBooleanIndexedvEXT(BufferTargetARB target, uint index, bool* data) => GLPointers._glGetBooleanIndexedvEXT_fnptr((uint)target, index, (byte*)data);
            
            public static void CompressedTextureImage3DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* bits) => GLPointers._glCompressedTextureImage3DEXT_fnptr(texture, (uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, bits);
            
            public static void CompressedTextureImage2DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* bits) => GLPointers._glCompressedTextureImage2DEXT_fnptr(texture, (uint)target, level, (uint)internalformat, width, height, border, imageSize, bits);
            
            public static void CompressedTextureImage1DEXT(int texture, TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, void* bits) => GLPointers._glCompressedTextureImage1DEXT_fnptr(texture, (uint)target, level, (uint)internalformat, width, border, imageSize, bits);
            
            public static void CompressedTextureSubImage3DEXT(int texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* bits) => GLPointers._glCompressedTextureSubImage3DEXT_fnptr(texture, (uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, bits);
            
            public static void CompressedTextureSubImage2DEXT(int texture, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* bits) => GLPointers._glCompressedTextureSubImage2DEXT_fnptr(texture, (uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, bits);
            
            public static void CompressedTextureSubImage1DEXT(int texture, TextureTarget target, int level, int xoffset, int width, InternalFormat format, int imageSize, void* bits) => GLPointers._glCompressedTextureSubImage1DEXT_fnptr(texture, (uint)target, level, xoffset, width, (uint)format, imageSize, bits);
            
            public static void GetCompressedTextureImageEXT(int texture, TextureTarget target, int lod, void* img) => GLPointers._glGetCompressedTextureImageEXT_fnptr(texture, (uint)target, lod, img);
            
            public static void CompressedMultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* bits) => GLPointers._glCompressedMultiTexImage3DEXT_fnptr((uint)texunit, (uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, bits);
            
            public static void CompressedMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* bits) => GLPointers._glCompressedMultiTexImage2DEXT_fnptr((uint)texunit, (uint)target, level, (uint)internalformat, width, height, border, imageSize, bits);
            
            public static void CompressedMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, void* bits) => GLPointers._glCompressedMultiTexImage1DEXT_fnptr((uint)texunit, (uint)target, level, (uint)internalformat, width, border, imageSize, bits);
            
            public static void CompressedMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* bits) => GLPointers._glCompressedMultiTexSubImage3DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, bits);
            
            public static void CompressedMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* bits) => GLPointers._glCompressedMultiTexSubImage2DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, bits);
            
            public static void CompressedMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int width, InternalFormat format, int imageSize, void* bits) => GLPointers._glCompressedMultiTexSubImage1DEXT_fnptr((uint)texunit, (uint)target, level, xoffset, width, (uint)format, imageSize, bits);
            
            public static void GetCompressedMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int lod, void* img) => GLPointers._glGetCompressedMultiTexImageEXT_fnptr((uint)texunit, (uint)target, lod, img);
            
            public static void MatrixLoadTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadTransposefEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoadTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoadTransposedEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultTransposefEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultTransposedEXT_fnptr((uint)mode, m);
            
            public static void NamedBufferDataEXT(int buffer, nint size, void* data, VertexBufferObjectUsage usage) => GLPointers._glNamedBufferDataEXT_fnptr(buffer, size, data, (uint)usage);
            
            public static void NamedBufferSubDataEXT(int buffer, IntPtr offset, nint size, void* data) => GLPointers._glNamedBufferSubDataEXT_fnptr(buffer, offset, size, data);
            
            public static void* MapNamedBufferEXT(int buffer, BufferAccessARB access) => GLPointers._glMapNamedBufferEXT_fnptr(buffer, (uint)access);
            
            public static bool UnmapNamedBufferEXT(int buffer) => GLPointers._glUnmapNamedBufferEXT_fnptr(buffer) != 0;
            
            public static void GetNamedBufferParameterivEXT(int buffer, BufferPNameARB pname, int* parameters) => GLPointers._glGetNamedBufferParameterivEXT_fnptr(buffer, (uint)pname, parameters);
            
            public static void GetNamedBufferPointervEXT(int buffer, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetNamedBufferPointervEXT_fnptr(buffer, (uint)pname, parameters);
            
            public static void GetNamedBufferSubDataEXT(int buffer, IntPtr offset, nint size, void* data) => GLPointers._glGetNamedBufferSubDataEXT_fnptr(buffer, offset, size, data);
            
            public static void ProgramUniform1fEXT(int program, int location, float v0) => GLPointers._glProgramUniform1fEXT_fnptr(program, location, v0);
            
            public static void ProgramUniform2fEXT(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2fEXT_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform3fEXT(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3fEXT_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform4fEXT(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4fEXT_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform1iEXT(int program, int location, int v0) => GLPointers._glProgramUniform1iEXT_fnptr(program, location, v0);
            
            public static void ProgramUniform2iEXT(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2iEXT_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform3iEXT(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3iEXT_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform4iEXT(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4iEXT_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform1fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform2fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform3fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform4fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform1ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform1ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform2ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform2ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform3ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform3ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform4ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform4ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniformMatrix2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void TextureBufferEXT(int texture, TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTextureBufferEXT_fnptr(texture, (uint)target, (uint)internalformat, buffer);
            
            public static void MultiTexBufferEXT(TextureUnit texunit, TextureTarget target, InternalFormat internalformat, int buffer) => GLPointers._glMultiTexBufferEXT_fnptr((uint)texunit, (uint)target, (uint)internalformat, buffer);
            
            public static void TextureParameterIivEXT(int texture, TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTextureParameterIivEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void TextureParameterIuivEXT(int texture, TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTextureParameterIuivEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void GetTextureParameterIivEXT(int texture, TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTextureParameterIivEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void GetTextureParameterIuivEXT(int texture, TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTextureParameterIuivEXT_fnptr(texture, (uint)target, (uint)pname, parameters);
            
            public static void MultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glMultiTexParameterIivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void MultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glMultiTexParameterIuivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void GetMultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetMultiTexParameterIivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void GetMultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetMultiTexParameterIuivEXT_fnptr((uint)texunit, (uint)target, (uint)pname, parameters);
            
            public static void ProgramUniform1uiEXT(int program, int location, uint v0) => GLPointers._glProgramUniform1uiEXT_fnptr(program, location, v0);
            
            public static void ProgramUniform2uiEXT(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2uiEXT_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform3uiEXT(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3uiEXT_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform4uiEXT(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4uiEXT_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform1uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform2uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform3uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform4uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uivEXT_fnptr(program, location, count, value);
            
            public static void NamedProgramLocalParameters4fvEXT(int program, ProgramTarget target, uint index, int count, float* parameters) => GLPointers._glNamedProgramLocalParameters4fvEXT_fnptr(program, (uint)target, index, count, parameters);
            
            public static void NamedProgramLocalParameterI4iEXT(int program, ProgramTarget target, uint index, int x, int y, int z, int w) => GLPointers._glNamedProgramLocalParameterI4iEXT_fnptr(program, (uint)target, index, x, y, z, w);
            
            public static void NamedProgramLocalParameterI4ivEXT(int program, ProgramTarget target, uint index, int* parameters) => GLPointers._glNamedProgramLocalParameterI4ivEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void NamedProgramLocalParametersI4ivEXT(int program, ProgramTarget target, uint index, int count, int* parameters) => GLPointers._glNamedProgramLocalParametersI4ivEXT_fnptr(program, (uint)target, index, count, parameters);
            
            public static void NamedProgramLocalParameterI4uiEXT(int program, ProgramTarget target, uint index, uint x, uint y, uint z, uint w) => GLPointers._glNamedProgramLocalParameterI4uiEXT_fnptr(program, (uint)target, index, x, y, z, w);
            
            public static void NamedProgramLocalParameterI4uivEXT(int program, ProgramTarget target, uint index, uint* parameters) => GLPointers._glNamedProgramLocalParameterI4uivEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void NamedProgramLocalParametersI4uivEXT(int program, ProgramTarget target, uint index, int count, uint* parameters) => GLPointers._glNamedProgramLocalParametersI4uivEXT_fnptr(program, (uint)target, index, count, parameters);
            
            public static void GetNamedProgramLocalParameterIivEXT(int program, ProgramTarget target, uint index, int* parameters) => GLPointers._glGetNamedProgramLocalParameterIivEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void GetNamedProgramLocalParameterIuivEXT(int program, ProgramTarget target, uint index, uint* parameters) => GLPointers._glGetNamedProgramLocalParameterIuivEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void EnableClientStateiEXT(EnableCap array, uint index) => GLPointers._glEnableClientStateiEXT_fnptr((uint)array, index);
            
            public static void DisableClientStateiEXT(EnableCap array, uint index) => GLPointers._glDisableClientStateiEXT_fnptr((uint)array, index);
            
            public static void GetFloati_vEXT(GetPName pname, uint index, float* parameters) => GLPointers._glGetFloati_vEXT_fnptr((uint)pname, index, parameters);
            
            public static void GetDoublei_vEXT(GetPName pname, uint index, double* parameters) => GLPointers._glGetDoublei_vEXT_fnptr((uint)pname, index, parameters);
            
            public static void GetPointeri_vEXT(All pname, uint index, void** parameters) => GLPointers._glGetPointeri_vEXT_fnptr((uint)pname, index, parameters);
            
            public static void NamedProgramStringEXT(int program, ProgramTarget target, ProgramFormat format, int len, void* str) => GLPointers._glNamedProgramStringEXT_fnptr(program, (uint)target, (uint)format, len, str);
            
            public static void NamedProgramLocalParameter4dEXT(int program, ProgramTarget target, uint index, double x, double y, double z, double w) => GLPointers._glNamedProgramLocalParameter4dEXT_fnptr(program, (uint)target, index, x, y, z, w);
            
            public static void NamedProgramLocalParameter4dvEXT(int program, ProgramTarget target, uint index, double* parameters) => GLPointers._glNamedProgramLocalParameter4dvEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void NamedProgramLocalParameter4fEXT(int program, ProgramTarget target, uint index, float x, float y, float z, float w) => GLPointers._glNamedProgramLocalParameter4fEXT_fnptr(program, (uint)target, index, x, y, z, w);
            
            public static void NamedProgramLocalParameter4fvEXT(int program, ProgramTarget target, uint index, float* parameters) => GLPointers._glNamedProgramLocalParameter4fvEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void GetNamedProgramLocalParameterdvEXT(int program, ProgramTarget target, uint index, double* parameters) => GLPointers._glGetNamedProgramLocalParameterdvEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void GetNamedProgramLocalParameterfvEXT(int program, ProgramTarget target, uint index, float* parameters) => GLPointers._glGetNamedProgramLocalParameterfvEXT_fnptr(program, (uint)target, index, parameters);
            
            public static void GetNamedProgramivEXT(int program, ProgramTarget target, ProgramPropertyARB pname, int* parameters) => GLPointers._glGetNamedProgramivEXT_fnptr(program, (uint)target, (uint)pname, parameters);
            
            public static void GetNamedProgramStringEXT(int program, ProgramTarget target, ProgramStringProperty pname, void* str) => GLPointers._glGetNamedProgramStringEXT_fnptr(program, (uint)target, (uint)pname, str);
            
            public static void NamedRenderbufferStorageEXT(int renderbuffer, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageEXT_fnptr(renderbuffer, (uint)internalformat, width, height);
            
            public static void GetNamedRenderbufferParameterivEXT(int renderbuffer, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetNamedRenderbufferParameterivEXT_fnptr(renderbuffer, (uint)pname, parameters);
            
            public static void NamedRenderbufferStorageMultisampleEXT(int renderbuffer, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisampleEXT_fnptr(renderbuffer, samples, (uint)internalformat, width, height);
            
            public static void NamedRenderbufferStorageMultisampleCoverageEXT(int renderbuffer, int coverageSamples, int colorSamples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisampleCoverageEXT_fnptr(renderbuffer, coverageSamples, colorSamples, (uint)internalformat, width, height);
            
            public static FramebufferStatus CheckNamedFramebufferStatusEXT(int framebuffer, FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckNamedFramebufferStatusEXT_fnptr(framebuffer, (uint)target);
            
            public static void NamedFramebufferTexture1DEXT(int framebuffer, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glNamedFramebufferTexture1DEXT_fnptr(framebuffer, (uint)attachment, (uint)textarget, texture, level);
            
            public static void NamedFramebufferTexture2DEXT(int framebuffer, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glNamedFramebufferTexture2DEXT_fnptr(framebuffer, (uint)attachment, (uint)textarget, texture, level);
            
            public static void NamedFramebufferTexture3DEXT(int framebuffer, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset) => GLPointers._glNamedFramebufferTexture3DEXT_fnptr(framebuffer, (uint)attachment, (uint)textarget, texture, level, zoffset);
            
            public static void NamedFramebufferRenderbufferEXT(int framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glNamedFramebufferRenderbufferEXT_fnptr(framebuffer, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
            
            public static void GetNamedFramebufferAttachmentParameterivEXT(int framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetNamedFramebufferAttachmentParameterivEXT_fnptr(framebuffer, (uint)attachment, (uint)pname, parameters);
            
            public static void GenerateTextureMipmapEXT(int texture, TextureTarget target) => GLPointers._glGenerateTextureMipmapEXT_fnptr(texture, (uint)target);
            
            public static void GenerateMultiTexMipmapEXT(TextureUnit texunit, TextureTarget target) => GLPointers._glGenerateMultiTexMipmapEXT_fnptr((uint)texunit, (uint)target);
            
            public static void FramebufferDrawBufferEXT(int framebuffer, DrawBufferMode mode) => GLPointers._glFramebufferDrawBufferEXT_fnptr(framebuffer, (uint)mode);
            
            public static void FramebufferDrawBuffersEXT(int framebuffer, int n, DrawBufferMode* bufs) => GLPointers._glFramebufferDrawBuffersEXT_fnptr(framebuffer, n, (uint*)bufs);
            
            public static void FramebufferReadBufferEXT(int framebuffer, ReadBufferMode mode) => GLPointers._glFramebufferReadBufferEXT_fnptr(framebuffer, (uint)mode);
            
            public static void GetFramebufferParameterivEXT(int framebuffer, GetFramebufferParameter pname, int* parameters) => GLPointers._glGetFramebufferParameterivEXT_fnptr(framebuffer, (uint)pname, parameters);
            
            public static void NamedCopyBufferSubDataEXT(int readBuffer, int writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glNamedCopyBufferSubDataEXT_fnptr(readBuffer, writeBuffer, readOffset, writeOffset, size);
            
            public static void NamedFramebufferTextureEXT(int framebuffer, FramebufferAttachment attachment, int texture, int level) => GLPointers._glNamedFramebufferTextureEXT_fnptr(framebuffer, (uint)attachment, texture, level);
            
            public static void NamedFramebufferTextureLayerEXT(int framebuffer, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glNamedFramebufferTextureLayerEXT_fnptr(framebuffer, (uint)attachment, texture, level, layer);
            
            public static void NamedFramebufferTextureFaceEXT(int framebuffer, FramebufferAttachment attachment, int texture, int level, TextureTarget face) => GLPointers._glNamedFramebufferTextureFaceEXT_fnptr(framebuffer, (uint)attachment, texture, level, (uint)face);
            
            public static void TextureRenderbufferEXT(int texture, TextureTarget target, int renderbuffer) => GLPointers._glTextureRenderbufferEXT_fnptr(texture, (uint)target, renderbuffer);
            
            public static void MultiTexRenderbufferEXT(TextureUnit texunit, TextureTarget target, int renderbuffer) => GLPointers._glMultiTexRenderbufferEXT_fnptr((uint)texunit, (uint)target, renderbuffer);
            
            public static void VertexArrayVertexOffsetEXT(int vaobj, int buffer, int size, VertexPointerType type, int stride, IntPtr offset) => GLPointers._glVertexArrayVertexOffsetEXT_fnptr(vaobj, buffer, size, (uint)type, stride, offset);
            
            public static void VertexArrayColorOffsetEXT(int vaobj, int buffer, int size, ColorPointerType type, int stride, IntPtr offset) => GLPointers._glVertexArrayColorOffsetEXT_fnptr(vaobj, buffer, size, (uint)type, stride, offset);
            
            public static void VertexArrayEdgeFlagOffsetEXT(int vaobj, int buffer, int stride, IntPtr offset) => GLPointers._glVertexArrayEdgeFlagOffsetEXT_fnptr(vaobj, buffer, stride, offset);
            
            public static void VertexArrayIndexOffsetEXT(int vaobj, int buffer, IndexPointerType type, int stride, IntPtr offset) => GLPointers._glVertexArrayIndexOffsetEXT_fnptr(vaobj, buffer, (uint)type, stride, offset);
            
            public static void VertexArrayNormalOffsetEXT(int vaobj, int buffer, NormalPointerType type, int stride, IntPtr offset) => GLPointers._glVertexArrayNormalOffsetEXT_fnptr(vaobj, buffer, (uint)type, stride, offset);
            
            public static void VertexArrayTexCoordOffsetEXT(int vaobj, int buffer, int size, TexCoordPointerType type, int stride, IntPtr offset) => GLPointers._glVertexArrayTexCoordOffsetEXT_fnptr(vaobj, buffer, size, (uint)type, stride, offset);
            
            public static void VertexArrayMultiTexCoordOffsetEXT(int vaobj, int buffer, All texunit, int size, TexCoordPointerType type, int stride, IntPtr offset) => GLPointers._glVertexArrayMultiTexCoordOffsetEXT_fnptr(vaobj, buffer, (uint)texunit, size, (uint)type, stride, offset);
            
            public static void VertexArrayFogCoordOffsetEXT(int vaobj, int buffer, FogCoordinatePointerType type, int stride, IntPtr offset) => GLPointers._glVertexArrayFogCoordOffsetEXT_fnptr(vaobj, buffer, (uint)type, stride, offset);
            
            public static void VertexArraySecondaryColorOffsetEXT(int vaobj, int buffer, int size, ColorPointerType type, int stride, IntPtr offset) => GLPointers._glVertexArraySecondaryColorOffsetEXT_fnptr(vaobj, buffer, size, (uint)type, stride, offset);
            
            public static void VertexArrayVertexAttribOffsetEXT(int vaobj, int buffer, uint index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr offset) => GLPointers._glVertexArrayVertexAttribOffsetEXT_fnptr(vaobj, buffer, index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, offset);
            
            public static void VertexArrayVertexAttribIOffsetEXT(int vaobj, int buffer, uint index, int size, VertexAttribType type, int stride, IntPtr offset) => GLPointers._glVertexArrayVertexAttribIOffsetEXT_fnptr(vaobj, buffer, index, size, (uint)type, stride, offset);
            
            public static void EnableVertexArrayEXT(int vaobj, EnableCap array) => GLPointers._glEnableVertexArrayEXT_fnptr(vaobj, (uint)array);
            
            public static void DisableVertexArrayEXT(int vaobj, EnableCap array) => GLPointers._glDisableVertexArrayEXT_fnptr(vaobj, (uint)array);
            
            public static void EnableVertexArrayAttribEXT(int vaobj, uint index) => GLPointers._glEnableVertexArrayAttribEXT_fnptr(vaobj, index);
            
            public static void DisableVertexArrayAttribEXT(int vaobj, uint index) => GLPointers._glDisableVertexArrayAttribEXT_fnptr(vaobj, index);
            
            public static void GetVertexArrayIntegervEXT(int vaobj, VertexArrayPName pname, int* param) => GLPointers._glGetVertexArrayIntegervEXT_fnptr(vaobj, (uint)pname, param);
            
            public static void GetVertexArrayPointervEXT(int vaobj, VertexArrayPName pname, void** param) => GLPointers._glGetVertexArrayPointervEXT_fnptr(vaobj, (uint)pname, param);
            
            public static void GetVertexArrayIntegeri_vEXT(int vaobj, uint index, VertexArrayPName pname, int* param) => GLPointers._glGetVertexArrayIntegeri_vEXT_fnptr(vaobj, index, (uint)pname, param);
            
            public static void GetVertexArrayPointeri_vEXT(int vaobj, uint index, VertexArrayPName pname, void** param) => GLPointers._glGetVertexArrayPointeri_vEXT_fnptr(vaobj, index, (uint)pname, param);
            
            public static void* MapNamedBufferRangeEXT(int buffer, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapNamedBufferRangeEXT_fnptr(buffer, offset, length, (uint)access);
            
            public static void FlushMappedNamedBufferRangeEXT(int buffer, IntPtr offset, nint length) => GLPointers._glFlushMappedNamedBufferRangeEXT_fnptr(buffer, offset, length);
            
            public static void NamedBufferStorageEXT(int buffer, nint size, void* data, BufferStorageMask flags) => GLPointers._glNamedBufferStorageEXT_fnptr(buffer, size, data, (uint)flags);
            
            public static void ClearNamedBufferDataEXT(int buffer, SizedInternalFormat internalformat, PixelFormat format, PixelType type, void* data) => GLPointers._glClearNamedBufferDataEXT_fnptr(buffer, (uint)internalformat, (uint)format, (uint)type, data);
            
            public static void ClearNamedBufferSubDataEXT(int buffer, SizedInternalFormat internalformat, nint offset, nint size, PixelFormat format, PixelType type, void* data) => GLPointers._glClearNamedBufferSubDataEXT_fnptr(buffer, (uint)internalformat, offset, size, (uint)format, (uint)type, data);
            
            public static void NamedFramebufferParameteriEXT(int framebuffer, FramebufferParameterName pname, int param) => GLPointers._glNamedFramebufferParameteriEXT_fnptr(framebuffer, (uint)pname, param);
            
            public static void GetNamedFramebufferParameterivEXT(int framebuffer, GetFramebufferParameter pname, int* parameters) => GLPointers._glGetNamedFramebufferParameterivEXT_fnptr(framebuffer, (uint)pname, parameters);
            
            public static void ProgramUniform1dEXT(int program, int location, double x) => GLPointers._glProgramUniform1dEXT_fnptr(program, location, x);
            
            public static void ProgramUniform2dEXT(int program, int location, double x, double y) => GLPointers._glProgramUniform2dEXT_fnptr(program, location, x, y);
            
            public static void ProgramUniform3dEXT(int program, int location, double x, double y, double z) => GLPointers._glProgramUniform3dEXT_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform4dEXT(int program, int location, double x, double y, double z, double w) => GLPointers._glProgramUniform4dEXT_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform1dvEXT(int program, int location, int count, double* value) => GLPointers._glProgramUniform1dvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform2dvEXT(int program, int location, int count, double* value) => GLPointers._glProgramUniform2dvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform3dvEXT(int program, int location, int count, double* value) => GLPointers._glProgramUniform3dvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform4dvEXT(int program, int location, int count, double* value) => GLPointers._glProgramUniform4dvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniformMatrix2dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x3dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2x3dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x4dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix2x4dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x2dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3x2dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x4dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix3x4dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x2dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4x2dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x3dvEXT(int program, int location, int count, bool transpose, double* value) => GLPointers._glProgramUniformMatrix4x3dvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void TextureBufferRangeEXT(int texture, TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTextureBufferRangeEXT_fnptr(texture, (uint)target, (uint)internalformat, buffer, offset, size);
            
            public static void TextureStorage1DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTextureStorage1DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width);
            
            public static void TextureStorage2DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTextureStorage2DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height);
            
            public static void TextureStorage3DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTextureStorage3DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height, depth);
            
            public static void TextureStorage2DMultisampleEXT(int texture, TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTextureStorage2DMultisampleEXT_fnptr(texture, (uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void TextureStorage3DMultisampleEXT(int texture, All target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTextureStorage3DMultisampleEXT_fnptr(texture, (uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void VertexArrayBindVertexBufferEXT(int vaobj, uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glVertexArrayBindVertexBufferEXT_fnptr(vaobj, bindingindex, buffer, offset, stride);
            
            public static void VertexArrayVertexAttribFormatEXT(int vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexArrayVertexAttribFormatEXT_fnptr(vaobj, attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
            
            public static void VertexArrayVertexAttribIFormatEXT(int vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexArrayVertexAttribIFormatEXT_fnptr(vaobj, attribindex, size, (uint)type, relativeoffset);
            
            public static void VertexArrayVertexAttribLFormatEXT(int vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => GLPointers._glVertexArrayVertexAttribLFormatEXT_fnptr(vaobj, attribindex, size, (uint)type, relativeoffset);
            
            public static void VertexArrayVertexAttribBindingEXT(int vaobj, uint attribindex, uint bindingindex) => GLPointers._glVertexArrayVertexAttribBindingEXT_fnptr(vaobj, attribindex, bindingindex);
            
            public static void VertexArrayVertexBindingDivisorEXT(int vaobj, uint bindingindex, uint divisor) => GLPointers._glVertexArrayVertexBindingDivisorEXT_fnptr(vaobj, bindingindex, divisor);
            
            public static void VertexArrayVertexAttribLOffsetEXT(int vaobj, int buffer, uint index, int size, VertexAttribLType type, int stride, IntPtr offset) => GLPointers._glVertexArrayVertexAttribLOffsetEXT_fnptr(vaobj, buffer, index, size, (uint)type, stride, offset);
            
            public static void TexturePageCommitmentEXT(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => GLPointers._glTexturePageCommitmentEXT_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (byte)(commit ? 1 : 0));
            
            public static void VertexArrayVertexAttribDivisorEXT(int vaobj, uint index, uint divisor) => GLPointers._glVertexArrayVertexAttribDivisorEXT_fnptr(vaobj, index, divisor);
            
            public static void ColorMaskIndexedEXT(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaskIndexedEXT_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
            
            public static void DrawArraysInstancedEXT(PrimitiveType mode, int start, int count, int primcount) => GLPointers._glDrawArraysInstancedEXT_fnptr((uint)mode, start, count, primcount);
            
            public static void DrawElementsInstancedEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void DrawRangeElementsEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => GLPointers._glDrawRangeElementsEXT_fnptr((uint)mode, start, end, count, (uint)type, indices);
            
            public static void BufferStorageExternalEXT(All target, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glBufferStorageExternalEXT_fnptr((uint)target, offset, size, clientBuffer, (uint)flags);
            
            public static void NamedBufferStorageExternalEXT(int buffer, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glNamedBufferStorageExternalEXT_fnptr(buffer, offset, size, clientBuffer, (uint)flags);
            
            public static void FogCoordfEXT(float coord) => GLPointers._glFogCoordfEXT_fnptr(coord);
            
            public static void FogCoordfvEXT(float* coord) => GLPointers._glFogCoordfvEXT_fnptr(coord);
            
            public static void FogCoorddEXT(double coord) => GLPointers._glFogCoorddEXT_fnptr(coord);
            
            public static void FogCoorddvEXT(double* coord) => GLPointers._glFogCoorddvEXT_fnptr(coord);
            
            public static void FogCoordPointerEXT(FogPointerTypeEXT type, int stride, void* pointer) => GLPointers._glFogCoordPointerEXT_fnptr((uint)type, stride, pointer);
            
            public static void BlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferEXT_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static void BlitFramebufferLayersEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayersEXT_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static void BlitFramebufferLayerEXT(int srcX0, int srcY0, int srcX1, int srcY1, int srcLayer, int dstX0, int dstY0, int dstX1, int dstY1, int dstLayer, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayerEXT_fnptr(srcX0, srcY0, srcX1, srcY1, srcLayer, dstX0, dstY0, dstX1, dstY1, dstLayer, (uint)mask, (uint)filter);
            
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static bool IsRenderbufferEXT(int renderbuffer) => GLPointers._glIsRenderbufferEXT_fnptr(renderbuffer) != 0;
            
            public static void BindRenderbufferEXT(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbufferEXT_fnptr((uint)target, renderbuffer);
            
            public static void DeleteRenderbuffersEXT(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffersEXT_fnptr(n, renderbuffers);
            
            public static void GenRenderbuffersEXT(int n, int* renderbuffers) => GLPointers._glGenRenderbuffersEXT_fnptr(n, renderbuffers);
            
            public static void RenderbufferStorageEXT(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageEXT_fnptr((uint)target, (uint)internalformat, width, height);
            
            public static void GetRenderbufferParameterivEXT(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static bool IsFramebufferEXT(int framebuffer) => GLPointers._glIsFramebufferEXT_fnptr(framebuffer) != 0;
            
            public static void BindFramebufferEXT(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebufferEXT_fnptr((uint)target, framebuffer);
            
            public static void DeleteFramebuffersEXT(int n, int* framebuffers) => GLPointers._glDeleteFramebuffersEXT_fnptr(n, framebuffers);
            
            public static void GenFramebuffersEXT(int n, int* framebuffers) => GLPointers._glGenFramebuffersEXT_fnptr(n, framebuffers);
            
            public static FramebufferStatus CheckFramebufferStatusEXT(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatusEXT_fnptr((uint)target);
            
            public static void FramebufferTexture1DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture1DEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
            
            public static void FramebufferTexture2DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2DEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
            
            public static void FramebufferTexture3DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset) => GLPointers._glFramebufferTexture3DEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, zoffset);
            
            public static void FramebufferRenderbufferEXT(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbufferEXT_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
            
            public static void GetFramebufferAttachmentParameterivEXT(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameterivEXT_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
            
            public static void GenerateMipmapEXT(TextureTarget target) => GLPointers._glGenerateMipmapEXT_fnptr((uint)target);
            
            public static void ProgramParameteriEXT(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteriEXT_fnptr(program, (uint)pname, value);
            
            public static void ProgramEnvParameters4fvEXT(ProgramTarget target, uint index, int count, float* parameters) => GLPointers._glProgramEnvParameters4fvEXT_fnptr((uint)target, index, count, parameters);
            
            public static void ProgramLocalParameters4fvEXT(ProgramTarget target, uint index, int count, float* parameters) => GLPointers._glProgramLocalParameters4fvEXT_fnptr((uint)target, index, count, parameters);
            
            public static void GetUniformuivEXT(int program, int location, uint* parameters) => GLPointers._glGetUniformuivEXT_fnptr(program, location, parameters);
            
            public static void BindFragDataLocationEXT(int program, uint color, byte* name) => GLPointers._glBindFragDataLocationEXT_fnptr(program, color, name);
            
            public static int GetFragDataLocationEXT(int program, byte* name) => GLPointers._glGetFragDataLocationEXT_fnptr(program, name);
            
            public static void Uniform1uiEXT(int location, uint v0) => GLPointers._glUniform1uiEXT_fnptr(location, v0);
            
            public static void Uniform2uiEXT(int location, uint v0, uint v1) => GLPointers._glUniform2uiEXT_fnptr(location, v0, v1);
            
            public static void Uniform3uiEXT(int location, uint v0, uint v1, uint v2) => GLPointers._glUniform3uiEXT_fnptr(location, v0, v1, v2);
            
            public static void Uniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glUniform4uiEXT_fnptr(location, v0, v1, v2, v3);
            
            public static void Uniform1uivEXT(int location, int count, uint* value) => GLPointers._glUniform1uivEXT_fnptr(location, count, value);
            
            public static void Uniform2uivEXT(int location, int count, uint* value) => GLPointers._glUniform2uivEXT_fnptr(location, count, value);
            
            public static void Uniform3uivEXT(int location, int count, uint* value) => GLPointers._glUniform3uivEXT_fnptr(location, count, value);
            
            public static void Uniform4uivEXT(int location, int count, uint* value) => GLPointers._glUniform4uivEXT_fnptr(location, count, value);
            
            public static void VertexAttribI1iEXT(uint index, int x) => GLPointers._glVertexAttribI1iEXT_fnptr(index, x);
            
            public static void VertexAttribI2iEXT(uint index, int x, int y) => GLPointers._glVertexAttribI2iEXT_fnptr(index, x, y);
            
            public static void VertexAttribI3iEXT(uint index, int x, int y, int z) => GLPointers._glVertexAttribI3iEXT_fnptr(index, x, y, z);
            
            public static void VertexAttribI4iEXT(uint index, int x, int y, int z, int w) => GLPointers._glVertexAttribI4iEXT_fnptr(index, x, y, z, w);
            
            public static void VertexAttribI1uiEXT(uint index, uint x) => GLPointers._glVertexAttribI1uiEXT_fnptr(index, x);
            
            public static void VertexAttribI2uiEXT(uint index, uint x, uint y) => GLPointers._glVertexAttribI2uiEXT_fnptr(index, x, y);
            
            public static void VertexAttribI3uiEXT(uint index, uint x, uint y, uint z) => GLPointers._glVertexAttribI3uiEXT_fnptr(index, x, y, z);
            
            public static void VertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w) => GLPointers._glVertexAttribI4uiEXT_fnptr(index, x, y, z, w);
            
            public static void VertexAttribI1ivEXT(uint index, int* v) => GLPointers._glVertexAttribI1ivEXT_fnptr(index, v);
            
            public static void VertexAttribI2ivEXT(uint index, int* v) => GLPointers._glVertexAttribI2ivEXT_fnptr(index, v);
            
            public static void VertexAttribI3ivEXT(uint index, int* v) => GLPointers._glVertexAttribI3ivEXT_fnptr(index, v);
            
            public static void VertexAttribI4ivEXT(uint index, int* v) => GLPointers._glVertexAttribI4ivEXT_fnptr(index, v);
            
            public static void VertexAttribI1uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI1uivEXT_fnptr(index, v);
            
            public static void VertexAttribI2uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI2uivEXT_fnptr(index, v);
            
            public static void VertexAttribI3uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI3uivEXT_fnptr(index, v);
            
            public static void VertexAttribI4uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI4uivEXT_fnptr(index, v);
            
            public static void VertexAttribI4bvEXT(uint index, sbyte* v) => GLPointers._glVertexAttribI4bvEXT_fnptr(index, v);
            
            public static void VertexAttribI4svEXT(uint index, short* v) => GLPointers._glVertexAttribI4svEXT_fnptr(index, v);
            
            public static void VertexAttribI4ubvEXT(uint index, byte* v) => GLPointers._glVertexAttribI4ubvEXT_fnptr(index, v);
            
            public static void VertexAttribI4usvEXT(uint index, ushort* v) => GLPointers._glVertexAttribI4usvEXT_fnptr(index, v);
            
            public static void VertexAttribIPointerEXT(uint index, int size, VertexAttribIType type, int stride, void* pointer) => GLPointers._glVertexAttribIPointerEXT_fnptr(index, size, (uint)type, stride, pointer);
            
            public static void GetVertexAttribIivEXT(uint index, VertexAttribEnum pname, int* parameters) => GLPointers._glGetVertexAttribIivEXT_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribIuivEXT(uint index, VertexAttribEnum pname, uint* parameters) => GLPointers._glGetVertexAttribIuivEXT_fnptr(index, (uint)pname, parameters);
            
            public static void GetHistogramEXT(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, void* values) => GLPointers._glGetHistogramEXT_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, values);
            
            public static void GetHistogramParameterfvEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float* parameters) => GLPointers._glGetHistogramParameterfvEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetHistogramParameterivEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => GLPointers._glGetHistogramParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetMinmaxEXT(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, void* values) => GLPointers._glGetMinmaxEXT_fnptr((uint)target, (byte)(reset ? 1 : 0), (uint)format, (uint)type, values);
            
            public static void GetMinmaxParameterfvEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float* parameters) => GLPointers._glGetMinmaxParameterfvEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetMinmaxParameterivEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int* parameters) => GLPointers._glGetMinmaxParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void HistogramEXT(HistogramTargetEXT target, int width, InternalFormat internalformat, bool sink) => GLPointers._glHistogramEXT_fnptr((uint)target, width, (uint)internalformat, (byte)(sink ? 1 : 0));
            
            public static void MinmaxEXT(MinmaxTargetEXT target, InternalFormat internalformat, bool sink) => GLPointers._glMinmaxEXT_fnptr((uint)target, (uint)internalformat, (byte)(sink ? 1 : 0));
            
            public static void ResetHistogramEXT(HistogramTargetEXT target) => GLPointers._glResetHistogramEXT_fnptr((uint)target);
            
            public static void ResetMinmaxEXT(MinmaxTargetEXT target) => GLPointers._glResetMinmaxEXT_fnptr((uint)target);
            
            public static void IndexFuncEXT(IndexFunctionEXT func, float reference) => GLPointers._glIndexFuncEXT_fnptr((uint)func, reference);
            
            public static void IndexMaterialEXT(TriangleFace face, IndexMaterialParameterEXT mode) => GLPointers._glIndexMaterialEXT_fnptr((uint)face, (uint)mode);
            
            public static void ApplyTextureEXT(LightTextureModeEXT mode) => GLPointers._glApplyTextureEXT_fnptr((uint)mode);
            
            public static void TextureLightEXT(LightTexturePNameEXT pname) => GLPointers._glTextureLightEXT_fnptr((uint)pname);
            
            public static void TextureMaterialEXT(TriangleFace face, MaterialParameter mode) => GLPointers._glTextureMaterialEXT_fnptr((uint)face, (uint)mode);
            
            public static void GetUnsignedBytevEXT(GetPName pname, byte* data) => GLPointers._glGetUnsignedBytevEXT_fnptr((uint)pname, data);
            
            public static void GetUnsignedBytei_vEXT(All target, uint index, byte* data) => GLPointers._glGetUnsignedBytei_vEXT_fnptr((uint)target, index, data);
            
            public static void DeleteMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._glDeleteMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            public static bool IsMemoryObjectEXT(uint memoryObject) => GLPointers._glIsMemoryObjectEXT_fnptr(memoryObject) != 0;
            
            public static void CreateMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._glCreateMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            public static void MemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            public static void GetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glGetMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            public static void TexStorageMem2DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTexStorageMem2DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, memory, offset);
            
            public static void TexStorageMem2DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem2DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void TexStorageMem3DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTexStorageMem3DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            public static void TexStorageMem3DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem3DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void BufferStorageMemEXT(BufferTargetARB target, nint size, uint memory, ulong offset) => GLPointers._glBufferStorageMemEXT_fnptr((uint)target, size, memory, offset);
            
            public static void TextureStorageMem2DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, memory, offset);
            
            public static void TextureStorageMem2DMultisampleEXT(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void TextureStorageMem3DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            public static void TextureStorageMem3DMultisampleEXT(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void NamedBufferStorageMemEXT(int buffer, nint size, uint memory, ulong offset) => GLPointers._glNamedBufferStorageMemEXT_fnptr(buffer, size, memory, offset);
            
            public static void TexStorageMem1DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTexStorageMem1DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, memory, offset);
            
            public static void TextureStorageMem1DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTextureStorageMem1DEXT_fnptr(texture, levels, (uint)internalFormat, width, memory, offset);
            
            public static void ImportMemoryFdEXT(uint memory, ulong size, ExternalHandleType handleType, int fd) => GLPointers._glImportMemoryFdEXT_fnptr(memory, size, (uint)handleType, fd);
            
            public static void ImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, void* handle) => GLPointers._glImportMemoryWin32HandleEXT_fnptr(memory, size, (uint)handleType, handle);
            
            public static void ImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, void* name) => GLPointers._glImportMemoryWin32NameEXT_fnptr(memory, size, (uint)handleType, name);
            
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._glMultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._glMultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void SampleMaskEXT(float value, bool invert) => GLPointers._glSampleMaskEXT_fnptr(value, (byte)(invert ? 1 : 0));
            
            public static void SamplePatternEXT(SamplePatternEXT pattern) => GLPointers._glSamplePatternEXT_fnptr((uint)pattern);
            
            public static void ColorTableEXT(ColorTableTarget target, InternalFormat internalFormat, int width, PixelFormat format, PixelType type, void* table) => GLPointers._glColorTableEXT_fnptr((uint)target, (uint)internalFormat, width, (uint)format, (uint)type, table);
            
            public static void GetColorTableEXT(ColorTableTarget target, PixelFormat format, PixelType type, void* data) => GLPointers._glGetColorTableEXT_fnptr((uint)target, (uint)format, (uint)type, data);
            
            public static void GetColorTableParameterivEXT(ColorTableTarget target, ColorTableParameterPName pname, int* parameters) => GLPointers._glGetColorTableParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetColorTableParameterfvEXT(ColorTableTarget target, ColorTableParameterPName pname, float* parameters) => GLPointers._glGetColorTableParameterfvEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void PixelTransformParameteriEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int param) => GLPointers._glPixelTransformParameteriEXT_fnptr((uint)target, (uint)pname, param);
            
            public static void PixelTransformParameterfEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float param) => GLPointers._glPixelTransformParameterfEXT_fnptr((uint)target, (uint)pname, param);
            
            public static void PixelTransformParameterivEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int* parameters) => GLPointers._glPixelTransformParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void PixelTransformParameterfvEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float* parameters) => GLPointers._glPixelTransformParameterfvEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetPixelTransformParameterivEXT(All target, All pname, int* parameters) => GLPointers._glGetPixelTransformParameterivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetPixelTransformParameterfvEXT(All target, All pname, float* parameters) => GLPointers._glGetPixelTransformParameterfvEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void PointParameterfEXT(PointParameterNameARB pname, float param) => GLPointers._glPointParameterfEXT_fnptr((uint)pname, param);
            
            public static void PointParameterfvEXT(PointParameterNameARB pname, float* parameters) => GLPointers._glPointParameterfvEXT_fnptr((uint)pname, parameters);
            
            public static void PolygonOffsetEXT(float factor, float bias) => GLPointers._glPolygonOffsetEXT_fnptr(factor, bias);
            
            public static void PolygonOffsetClampEXT(float factor, float units, float clamp) => GLPointers._glPolygonOffsetClampEXT_fnptr(factor, units, clamp);
            
            public static void ProvokingVertexEXT(VertexProvokingMode mode) => GLPointers._glProvokingVertexEXT_fnptr((uint)mode);
            
            public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void GenSemaphoresEXT(int n, uint* semaphores) => GLPointers._glGenSemaphoresEXT_fnptr(n, semaphores);
            
            public static void DeleteSemaphoresEXT(int n, uint* semaphores) => GLPointers._glDeleteSemaphoresEXT_fnptr(n, semaphores);
            
            public static bool IsSemaphoreEXT(uint semaphore) => GLPointers._glIsSemaphoreEXT_fnptr(semaphore) != 0;
            
            public static void SemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            public static void GetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glGetSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* srcLayouts) => GLPointers._glWaitSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)srcLayouts);
            
            public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* dstLayouts) => GLPointers._glSignalSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)dstLayouts);
            
            public static void ImportSemaphoreFdEXT(uint semaphore, ExternalHandleType handleType, int fd) => GLPointers._glImportSemaphoreFdEXT_fnptr(semaphore, (uint)handleType, fd);
            
            public static void ImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, void* handle) => GLPointers._glImportSemaphoreWin32HandleEXT_fnptr(semaphore, (uint)handleType, handle);
            
            public static void ImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, void* name) => GLPointers._glImportSemaphoreWin32NameEXT_fnptr(semaphore, (uint)handleType, name);
            
            public static void SecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue) => GLPointers._glSecondaryColor3bEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3bvEXT(sbyte* v) => GLPointers._glSecondaryColor3bvEXT_fnptr(v);
            
            public static void SecondaryColor3dEXT(double red, double green, double blue) => GLPointers._glSecondaryColor3dEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3dvEXT(double* v) => GLPointers._glSecondaryColor3dvEXT_fnptr(v);
            
            public static void SecondaryColor3fEXT(float red, float green, float blue) => GLPointers._glSecondaryColor3fEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3fvEXT(float* v) => GLPointers._glSecondaryColor3fvEXT_fnptr(v);
            
            public static void SecondaryColor3iEXT(int red, int green, int blue) => GLPointers._glSecondaryColor3iEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3ivEXT(int* v) => GLPointers._glSecondaryColor3ivEXT_fnptr(v);
            
            public static void SecondaryColor3sEXT(short red, short green, short blue) => GLPointers._glSecondaryColor3sEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3svEXT(short* v) => GLPointers._glSecondaryColor3svEXT_fnptr(v);
            
            public static void SecondaryColor3ubEXT(byte red, byte green, byte blue) => GLPointers._glSecondaryColor3ubEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3ubvEXT(byte* v) => GLPointers._glSecondaryColor3ubvEXT_fnptr(v);
            
            public static void SecondaryColor3uiEXT(uint red, uint green, uint blue) => GLPointers._glSecondaryColor3uiEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3uivEXT(uint* v) => GLPointers._glSecondaryColor3uivEXT_fnptr(v);
            
            public static void SecondaryColor3usEXT(ushort red, ushort green, ushort blue) => GLPointers._glSecondaryColor3usEXT_fnptr(red, green, blue);
            
            public static void SecondaryColor3usvEXT(ushort* v) => GLPointers._glSecondaryColor3usvEXT_fnptr(v);
            
            public static void SecondaryColorPointerEXT(int size, ColorPointerType type, int stride, void* pointer) => GLPointers._glSecondaryColorPointerEXT_fnptr(size, (uint)type, stride, pointer);
            
            public static void UseShaderProgramEXT(All type, int program) => GLPointers._glUseShaderProgramEXT_fnptr((uint)type, program);
            
            public static void ActiveProgramEXT(int program) => GLPointers._glActiveProgramEXT_fnptr(program);
            
            public static int CreateShaderProgramEXT(ShaderType type, byte* str) => GLPointers._glCreateShaderProgramEXT_fnptr((uint)type, str);
            
            public static void ActiveShaderProgramEXT(int pipeline, int program) => GLPointers._glActiveShaderProgramEXT_fnptr(pipeline, program);
            
            public static void BindProgramPipelineEXT(int pipeline) => GLPointers._glBindProgramPipelineEXT_fnptr(pipeline);
            
            public static int CreateShaderProgramvEXT(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramvEXT_fnptr((uint)type, count, strings);
            
            public static void DeleteProgramPipelinesEXT(int n, int* pipelines) => GLPointers._glDeleteProgramPipelinesEXT_fnptr(n, pipelines);
            
            public static void GenProgramPipelinesEXT(int n, int* pipelines) => GLPointers._glGenProgramPipelinesEXT_fnptr(n, pipelines);
            
            public static void GetProgramPipelineInfoLogEXT(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLogEXT_fnptr(pipeline, bufSize, length, infoLog);
            
            public static void GetProgramPipelineivEXT(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineivEXT_fnptr(pipeline, (uint)pname, parameters);
            
            public static bool IsProgramPipelineEXT(int pipeline) => GLPointers._glIsProgramPipelineEXT_fnptr(pipeline) != 0;
            
            public static void UseProgramStagesEXT(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStagesEXT_fnptr(pipeline, (uint)stages, program);
            
            public static void ValidateProgramPipelineEXT(int pipeline) => GLPointers._glValidateProgramPipelineEXT_fnptr(pipeline);
            
            public static void FramebufferFetchBarrierEXT() => GLPointers._glFramebufferFetchBarrierEXT_fnptr();
            
            public static void BindImageTextureEXT(uint index, int texture, int level, bool layered, int layer, BufferAccessARB access, int format) => GLPointers._glBindImageTextureEXT_fnptr(index, texture, level, (byte)(layered ? 1 : 0), layer, (uint)access, format);
            
            public static void MemoryBarrierEXT(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrierEXT_fnptr((uint)barriers);
            
            public static void StencilClearTagEXT(int stencilTagBits, uint stencilClearTag) => GLPointers._glStencilClearTagEXT_fnptr(stencilTagBits, stencilClearTag);
            
            public static void ActiveStencilFaceEXT(TriangleFace face) => GLPointers._glActiveStencilFaceEXT_fnptr((uint)face);
            
            public static void TexSubImage1DEXT(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage1DEXT_fnptr((uint)target, level, xoffset, width, (uint)format, (uint)type, pixels);
            
            public static void TexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage2DEXT_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
            
            public static void TexImage3DEXT(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage3DEXT_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
            
            public static void TexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage3DEXT_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            public static void FramebufferTextureLayerEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayerEXT_fnptr((uint)target, (uint)attachment, texture, level, layer);
            
            public static void TexBufferEXT(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferEXT_fnptr((uint)target, (uint)internalformat, buffer);
            
            public static void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ClearColorIiEXT(int red, int green, int blue, int alpha) => GLPointers._glClearColorIiEXT_fnptr(red, green, blue, alpha);
            
            public static void ClearColorIuiEXT(uint red, uint green, uint blue, uint alpha) => GLPointers._glClearColorIuiEXT_fnptr(red, green, blue, alpha);
            
            public static bool AreTexturesResidentEXT(int n, int* textures, bool* residences) => GLPointers._glAreTexturesResidentEXT_fnptr(n, textures, (byte*)residences) != 0;
            
            public static void BindTextureEXT(TextureTarget target, int texture) => GLPointers._glBindTextureEXT_fnptr((uint)target, texture);
            
            public static void DeleteTexturesEXT(int n, int* textures) => GLPointers._glDeleteTexturesEXT_fnptr(n, textures);
            
            public static void GenTexturesEXT(int n, int* textures) => GLPointers._glGenTexturesEXT_fnptr(n, textures);
            
            public static bool IsTextureEXT(int texture) => GLPointers._glIsTextureEXT_fnptr(texture) != 0;
            
            public static void PrioritizeTexturesEXT(int n, int* textures, float* priorities) => GLPointers._glPrioritizeTexturesEXT_fnptr(n, textures, priorities);
            
            public static void TextureNormalEXT(TextureNormalModeEXT mode) => GLPointers._glTextureNormalEXT_fnptr((uint)mode);
            
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTexStorage1DEXT_fnptr((uint)target, levels, (uint)internalformat, width);
            
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height);
            
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
            
            public static void GetQueryObjecti64vEXT(int id, QueryObjectParameterName pname, long* parameters) => GLPointers._glGetQueryObjecti64vEXT_fnptr(id, (uint)pname, parameters);
            
            public static void GetQueryObjectui64vEXT(int id, QueryObjectParameterName pname, ulong* parameters) => GLPointers._glGetQueryObjectui64vEXT_fnptr(id, (uint)pname, parameters);
            
            public static void BeginTransformFeedbackEXT(PrimitiveType primitiveMode) => GLPointers._glBeginTransformFeedbackEXT_fnptr((uint)primitiveMode);
            
            public static void EndTransformFeedbackEXT() => GLPointers._glEndTransformFeedbackEXT_fnptr();
            
            public static void BindBufferRangeEXT(BufferTargetARB target, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glBindBufferRangeEXT_fnptr((uint)target, index, buffer, offset, size);
            
            public static void BindBufferOffsetEXT(BufferTargetARB target, uint index, int buffer, IntPtr offset) => GLPointers._glBindBufferOffsetEXT_fnptr((uint)target, index, buffer, offset);
            
            public static void BindBufferBaseEXT(BufferTargetARB target, uint index, int buffer) => GLPointers._glBindBufferBaseEXT_fnptr((uint)target, index, buffer);
            
            public static void TransformFeedbackVaryingsEXT(int program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode) => GLPointers._glTransformFeedbackVaryingsEXT_fnptr(program, count, varyings, (uint)bufferMode);
            
            public static void GetTransformFeedbackVaryingEXT(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetTransformFeedbackVaryingEXT_fnptr(program, index, bufSize, length, size, (uint*)type, name);
            
            public static void ArrayElementEXT(int i) => GLPointers._glArrayElementEXT_fnptr(i);
            
            public static void ColorPointerEXT(int size, ColorPointerType type, int stride, int count, void* pointer) => GLPointers._glColorPointerEXT_fnptr(size, (uint)type, stride, count, pointer);
            
            public static void DrawArraysEXT(PrimitiveType mode, int first, int count) => GLPointers._glDrawArraysEXT_fnptr((uint)mode, first, count);
            
            public static void EdgeFlagPointerEXT(int stride, int count, bool* pointer) => GLPointers._glEdgeFlagPointerEXT_fnptr(stride, count, (byte*)pointer);
            
            public static void GetPointervEXT(GetPointervPName pname, void** parameters) => GLPointers._glGetPointervEXT_fnptr((uint)pname, parameters);
            
            public static void IndexPointerEXT(IndexPointerType type, int stride, int count, void* pointer) => GLPointers._glIndexPointerEXT_fnptr((uint)type, stride, count, pointer);
            
            public static void NormalPointerEXT(NormalPointerType type, int stride, int count, void* pointer) => GLPointers._glNormalPointerEXT_fnptr((uint)type, stride, count, pointer);
            
            public static void TexCoordPointerEXT(int size, TexCoordPointerType type, int stride, int count, void* pointer) => GLPointers._glTexCoordPointerEXT_fnptr(size, (uint)type, stride, count, pointer);
            
            public static void VertexPointerEXT(int size, VertexPointerType type, int stride, int count, void* pointer) => GLPointers._glVertexPointerEXT_fnptr(size, (uint)type, stride, count, pointer);
            
            public static void VertexAttribL1dEXT(uint index, double x) => GLPointers._glVertexAttribL1dEXT_fnptr(index, x);
            
            public static void VertexAttribL2dEXT(uint index, double x, double y) => GLPointers._glVertexAttribL2dEXT_fnptr(index, x, y);
            
            public static void VertexAttribL3dEXT(uint index, double x, double y, double z) => GLPointers._glVertexAttribL3dEXT_fnptr(index, x, y, z);
            
            public static void VertexAttribL4dEXT(uint index, double x, double y, double z, double w) => GLPointers._glVertexAttribL4dEXT_fnptr(index, x, y, z, w);
            
            public static void VertexAttribL1dvEXT(uint index, double* v) => GLPointers._glVertexAttribL1dvEXT_fnptr(index, v);
            
            public static void VertexAttribL2dvEXT(uint index, double* v) => GLPointers._glVertexAttribL2dvEXT_fnptr(index, v);
            
            public static void VertexAttribL3dvEXT(uint index, double* v) => GLPointers._glVertexAttribL3dvEXT_fnptr(index, v);
            
            public static void VertexAttribL4dvEXT(uint index, double* v) => GLPointers._glVertexAttribL4dvEXT_fnptr(index, v);
            
            public static void VertexAttribLPointerEXT(uint index, int size, VertexAttribLType type, int stride, void* pointer) => GLPointers._glVertexAttribLPointerEXT_fnptr(index, size, (uint)type, stride, pointer);
            
            public static void GetVertexAttribLdvEXT(uint index, VertexAttribEnum pname, double* parameters) => GLPointers._glGetVertexAttribLdvEXT_fnptr(index, (uint)pname, parameters);
            
            public static void BeginVertexShaderEXT() => GLPointers._glBeginVertexShaderEXT_fnptr();
            
            public static void EndVertexShaderEXT() => GLPointers._glEndVertexShaderEXT_fnptr();
            
            public static void BindVertexShaderEXT(uint id) => GLPointers._glBindVertexShaderEXT_fnptr(id);
            
            public static uint GenVertexShadersEXT(uint range) => GLPointers._glGenVertexShadersEXT_fnptr(range);
            
            public static void DeleteVertexShaderEXT(uint id) => GLPointers._glDeleteVertexShaderEXT_fnptr(id);
            
            public static void ShaderOp1EXT(VertexShaderOpEXT op, uint res, uint arg1) => GLPointers._glShaderOp1EXT_fnptr((uint)op, res, arg1);
            
            public static void ShaderOp2EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2) => GLPointers._glShaderOp2EXT_fnptr((uint)op, res, arg1, arg2);
            
            public static void ShaderOp3EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2, uint arg3) => GLPointers._glShaderOp3EXT_fnptr((uint)op, res, arg1, arg2, arg3);
            
            public static void SwizzleEXT(uint res, uint input, VertexShaderCoordOutEXT outX, VertexShaderCoordOutEXT outY, VertexShaderCoordOutEXT outZ, VertexShaderCoordOutEXT outW) => GLPointers._glSwizzleEXT_fnptr(res, input, (uint)outX, (uint)outY, (uint)outZ, (uint)outW);
            
            public static void WriteMaskEXT(uint res, uint input, VertexShaderWriteMaskEXT outX, VertexShaderWriteMaskEXT outY, VertexShaderWriteMaskEXT outZ, VertexShaderWriteMaskEXT outW) => GLPointers._glWriteMaskEXT_fnptr(res, input, (uint)outX, (uint)outY, (uint)outZ, (uint)outW);
            
            public static void InsertComponentEXT(uint res, uint src, uint num) => GLPointers._glInsertComponentEXT_fnptr(res, src, num);
            
            public static void ExtractComponentEXT(uint res, uint src, uint num) => GLPointers._glExtractComponentEXT_fnptr(res, src, num);
            
            public static uint GenSymbolsEXT(DataTypeEXT datatype, VertexShaderStorageTypeEXT storagetype, ParameterRangeEXT range, uint components) => GLPointers._glGenSymbolsEXT_fnptr((uint)datatype, (uint)storagetype, (uint)range, components);
            
            public static void SetInvariantEXT(uint id, ScalarType type, void* addr) => GLPointers._glSetInvariantEXT_fnptr(id, (uint)type, addr);
            
            public static void SetLocalConstantEXT(uint id, ScalarType type, void* addr) => GLPointers._glSetLocalConstantEXT_fnptr(id, (uint)type, addr);
            
            public static void VariantbvEXT(uint id, sbyte* addr) => GLPointers._glVariantbvEXT_fnptr(id, addr);
            
            public static void VariantsvEXT(uint id, short* addr) => GLPointers._glVariantsvEXT_fnptr(id, addr);
            
            public static void VariantivEXT(uint id, int* addr) => GLPointers._glVariantivEXT_fnptr(id, addr);
            
            public static void VariantfvEXT(uint id, float* addr) => GLPointers._glVariantfvEXT_fnptr(id, addr);
            
            public static void VariantdvEXT(uint id, double* addr) => GLPointers._glVariantdvEXT_fnptr(id, addr);
            
            public static void VariantubvEXT(uint id, byte* addr) => GLPointers._glVariantubvEXT_fnptr(id, addr);
            
            public static void VariantusvEXT(uint id, ushort* addr) => GLPointers._glVariantusvEXT_fnptr(id, addr);
            
            public static void VariantuivEXT(uint id, uint* addr) => GLPointers._glVariantuivEXT_fnptr(id, addr);
            
            public static void VariantPointerEXT(uint id, ScalarType type, uint stride, void* addr) => GLPointers._glVariantPointerEXT_fnptr(id, (uint)type, stride, addr);
            
            public static void EnableVariantClientStateEXT(uint id) => GLPointers._glEnableVariantClientStateEXT_fnptr(id);
            
            public static void DisableVariantClientStateEXT(uint id) => GLPointers._glDisableVariantClientStateEXT_fnptr(id);
            
            public static uint BindLightParameterEXT(LightName light, LightParameter value) => GLPointers._glBindLightParameterEXT_fnptr((uint)light, (uint)value);
            
            public static uint BindMaterialParameterEXT(TriangleFace face, MaterialParameter value) => GLPointers._glBindMaterialParameterEXT_fnptr((uint)face, (uint)value);
            
            public static uint BindTexGenParameterEXT(TextureUnit unit, TextureCoordName coord, TextureGenParameter value) => GLPointers._glBindTexGenParameterEXT_fnptr((uint)unit, (uint)coord, (uint)value);
            
            public static uint BindTextureUnitParameterEXT(TextureUnit unit, VertexShaderTextureUnitParameter value) => GLPointers._glBindTextureUnitParameterEXT_fnptr((uint)unit, (uint)value);
            
            public static uint BindParameterEXT(VertexShaderParameterEXT value) => GLPointers._glBindParameterEXT_fnptr((uint)value);
            
            public static bool IsVariantEnabledEXT(uint id, VariantCapEXT cap) => GLPointers._glIsVariantEnabledEXT_fnptr(id, (uint)cap) != 0;
            
            public static void GetVariantBooleanvEXT(uint id, GetVariantValueEXT value, bool* data) => GLPointers._glGetVariantBooleanvEXT_fnptr(id, (uint)value, (byte*)data);
            
            public static void GetVariantIntegervEXT(uint id, GetVariantValueEXT value, int* data) => GLPointers._glGetVariantIntegervEXT_fnptr(id, (uint)value, data);
            
            public static void GetVariantFloatvEXT(uint id, GetVariantValueEXT value, float* data) => GLPointers._glGetVariantFloatvEXT_fnptr(id, (uint)value, data);
            
            public static void GetVariantPointervEXT(uint id, GetVariantValueEXT value, void** data) => GLPointers._glGetVariantPointervEXT_fnptr(id, (uint)value, data);
            
            public static void GetInvariantBooleanvEXT(uint id, GetVariantValueEXT value, bool* data) => GLPointers._glGetInvariantBooleanvEXT_fnptr(id, (uint)value, (byte*)data);
            
            public static void GetInvariantIntegervEXT(uint id, GetVariantValueEXT value, int* data) => GLPointers._glGetInvariantIntegervEXT_fnptr(id, (uint)value, data);
            
            public static void GetInvariantFloatvEXT(uint id, GetVariantValueEXT value, float* data) => GLPointers._glGetInvariantFloatvEXT_fnptr(id, (uint)value, data);
            
            public static void GetLocalConstantBooleanvEXT(uint id, GetVariantValueEXT value, bool* data) => GLPointers._glGetLocalConstantBooleanvEXT_fnptr(id, (uint)value, (byte*)data);
            
            public static void GetLocalConstantIntegervEXT(uint id, GetVariantValueEXT value, int* data) => GLPointers._glGetLocalConstantIntegervEXT_fnptr(id, (uint)value, data);
            
            public static void GetLocalConstantFloatvEXT(uint id, GetVariantValueEXT value, float* data) => GLPointers._glGetLocalConstantFloatvEXT_fnptr(id, (uint)value, data);
            
            public static void VertexWeightfEXT(float weight) => GLPointers._glVertexWeightfEXT_fnptr(weight);
            
            public static void VertexWeightfvEXT(float* weight) => GLPointers._glVertexWeightfvEXT_fnptr(weight);
            
            public static void VertexWeightPointerEXT(int size, VertexWeightPointerTypeEXT type, int stride, void* pointer) => GLPointers._glVertexWeightPointerEXT_fnptr(size, (uint)type, stride, pointer);
            
            public static bool AcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout) => GLPointers._glAcquireKeyedMutexWin32EXT_fnptr(memory, key, timeout) != 0;
            
            public static bool ReleaseKeyedMutexWin32EXT(uint memory, ulong key) => GLPointers._glReleaseKeyedMutexWin32EXT_fnptr(memory, key) != 0;
            
            public static void WindowRectanglesEXT(All mode, int count, int* box) => GLPointers._glWindowRectanglesEXT_fnptr((uint)mode, count, box);
            
            public static GLSync ImportSyncEXT(All external_sync_type, IntPtr external_sync, uint flags) => (GLSync) GLPointers._glImportSyncEXT_fnptr((uint)external_sync_type, external_sync, flags);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            public static void CreateSemaphoresNV(int n, uint* semaphores) => GLPointers._glCreateSemaphoresNV_fnptr(n, semaphores);
            
            public static void SemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            public static void GetSemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glGetSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            public static void AlphaToCoverageDitherControlNV(All mode) => GLPointers._glAlphaToCoverageDitherControlNV_fnptr((uint)mode);
            
            public static void MultiDrawArraysIndirectBindlessNV(PrimitiveType mode, void* indirect, int drawCount, int stride, int vertexBufferCount) => GLPointers._glMultiDrawArraysIndirectBindlessNV_fnptr((uint)mode, indirect, drawCount, stride, vertexBufferCount);
            
            public static void MultiDrawElementsIndirectBindlessNV(PrimitiveType mode, DrawElementsType type, void* indirect, int drawCount, int stride, int vertexBufferCount) => GLPointers._glMultiDrawElementsIndirectBindlessNV_fnptr((uint)mode, (uint)type, indirect, drawCount, stride, vertexBufferCount);
            
            public static void MultiDrawArraysIndirectBindlessCountNV(PrimitiveType mode, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount) => GLPointers._glMultiDrawArraysIndirectBindlessCountNV_fnptr((uint)mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
            
            public static void MultiDrawElementsIndirectBindlessCountNV(PrimitiveType mode, DrawElementsType type, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount) => GLPointers._glMultiDrawElementsIndirectBindlessCountNV_fnptr((uint)mode, (uint)type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
            
            public static ulong GetTextureHandleNV(int texture) => GLPointers._glGetTextureHandleNV_fnptr(texture);
            
            public static ulong GetTextureSamplerHandleNV(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleNV_fnptr(texture, sampler);
            
            public static void MakeTextureHandleResidentNV(ulong handle) => GLPointers._glMakeTextureHandleResidentNV_fnptr(handle);
            
            public static void MakeTextureHandleNonResidentNV(ulong handle) => GLPointers._glMakeTextureHandleNonResidentNV_fnptr(handle);
            
            public static ulong GetImageHandleNV(int texture, int level, bool layered, int layer, PixelFormat format) => GLPointers._glGetImageHandleNV_fnptr(texture, level, (byte)(layered ? 1 : 0), layer, (uint)format);
            
            public static void MakeImageHandleResidentNV(ulong handle, All access) => GLPointers._glMakeImageHandleResidentNV_fnptr(handle, (uint)access);
            
            public static void MakeImageHandleNonResidentNV(ulong handle) => GLPointers._glMakeImageHandleNonResidentNV_fnptr(handle);
            
            public static void UniformHandleui64NV(int location, ulong value) => GLPointers._glUniformHandleui64NV_fnptr(location, value);
            
            public static void UniformHandleui64vNV(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vNV_fnptr(location, count, value);
            
            public static void ProgramUniformHandleui64NV(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64NV_fnptr(program, location, value);
            
            public static void ProgramUniformHandleui64vNV(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vNV_fnptr(program, location, count, values);
            
            public static bool IsTextureHandleResidentNV(ulong handle) => GLPointers._glIsTextureHandleResidentNV_fnptr(handle) != 0;
            
            public static bool IsImageHandleResidentNV(ulong handle) => GLPointers._glIsImageHandleResidentNV_fnptr(handle) != 0;
            
            public static void BlendParameteriNV(All pname, int value) => GLPointers._glBlendParameteriNV_fnptr((uint)pname, value);
            
            public static void BlendBarrierNV() => GLPointers._glBlendBarrierNV_fnptr();
            
            public static void ViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff) => GLPointers._glViewportPositionWScaleNV_fnptr(index, xcoeff, ycoeff);
            
            public static void CreateStatesNV(int n, uint* states) => GLPointers._glCreateStatesNV_fnptr(n, states);
            
            public static void DeleteStatesNV(int n, uint* states) => GLPointers._glDeleteStatesNV_fnptr(n, states);
            
            public static bool IsStateNV(uint state) => GLPointers._glIsStateNV_fnptr(state) != 0;
            
            public static void StateCaptureNV(uint state, All mode) => GLPointers._glStateCaptureNV_fnptr(state, (uint)mode);
            
            public static uint GetCommandHeaderNV(CommandOpcodesNV tokenID, uint size) => GLPointers._glGetCommandHeaderNV_fnptr((uint)tokenID, size);
            
            public static ushort GetStageIndexNV(ShaderType shadertype) => GLPointers._glGetStageIndexNV_fnptr((uint)shadertype);
            
            public static void DrawCommandsNV(All primitiveMode, uint buffer, IntPtr* indirects, int* sizes, uint count) => GLPointers._glDrawCommandsNV_fnptr((uint)primitiveMode, buffer, indirects, sizes, count);
            
            public static void DrawCommandsAddressNV(All primitiveMode, ulong* indirects, int* sizes, uint count) => GLPointers._glDrawCommandsAddressNV_fnptr((uint)primitiveMode, indirects, sizes, count);
            
            public static void DrawCommandsStatesNV(int buffer, IntPtr* indirects, int* sizes, uint* states, uint* fbos, uint count) => GLPointers._glDrawCommandsStatesNV_fnptr(buffer, indirects, sizes, states, fbos, count);
            
            public static void DrawCommandsStatesAddressNV(ulong* indirects, int* sizes, uint* states, uint* fbos, uint count) => GLPointers._glDrawCommandsStatesAddressNV_fnptr(indirects, sizes, states, fbos, count);
            
            public static void CreateCommandListsNV(int n, uint* lists) => GLPointers._glCreateCommandListsNV_fnptr(n, lists);
            
            public static void DeleteCommandListsNV(int n, uint* lists) => GLPointers._glDeleteCommandListsNV_fnptr(n, lists);
            
            public static bool IsCommandListNV(uint list) => GLPointers._glIsCommandListNV_fnptr(list) != 0;
            
            public static void ListDrawCommandsStatesClientNV(uint list, uint segment, void** indirects, int* sizes, uint* states, uint* fbos, uint count) => GLPointers._glListDrawCommandsStatesClientNV_fnptr(list, segment, indirects, sizes, states, fbos, count);
            
            public static void CommandListSegmentsNV(uint list, uint segments) => GLPointers._glCommandListSegmentsNV_fnptr(list, segments);
            
            public static void CompileCommandListNV(uint list) => GLPointers._glCompileCommandListNV_fnptr(list);
            
            public static void CallCommandListNV(uint list) => GLPointers._glCallCommandListNV_fnptr(list);
            
            public static void BeginConditionalRenderNV(uint id, ConditionalRenderMode mode) => GLPointers._glBeginConditionalRenderNV_fnptr(id, (uint)mode);
            
            public static void EndConditionalRenderNV() => GLPointers._glEndConditionalRenderNV_fnptr();
            
            public static void SubpixelPrecisionBiasNV(uint xbits, uint ybits) => GLPointers._glSubpixelPrecisionBiasNV_fnptr(xbits, ybits);
            
            public static void ConservativeRasterParameterfNV(All pname, float value) => GLPointers._glConservativeRasterParameterfNV_fnptr((uint)pname, value);
            
            public static void ConservativeRasterParameteriNV(All pname, int param) => GLPointers._glConservativeRasterParameteriNV_fnptr((uint)pname, param);
            
            public static void CopyImageSubDataNV(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => GLPointers._glCopyImageSubDataNV_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            public static void DepthRangedNV(double zNear, double zFar) => GLPointers._glDepthRangedNV_fnptr(zNear, zFar);
            
            public static void ClearDepthdNV(double depth) => GLPointers._glClearDepthdNV_fnptr(depth);
            
            public static void DepthBoundsdNV(double zmin, double zmax) => GLPointers._glDepthBoundsdNV_fnptr(zmin, zmax);
            
            public static void DrawTextureNV(int texture, int sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => GLPointers._glDrawTextureNV_fnptr(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            
            public static void DrawVkImageNV(ulong vkImage, int sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => GLPointers._glDrawVkImageNV_fnptr(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            
            public static IntPtr GetVkProcAddrNV(byte* name) => GLPointers._glGetVkProcAddrNV_fnptr(name);
            
            public static void WaitVkSemaphoreNV(ulong vkSemaphore) => GLPointers._glWaitVkSemaphoreNV_fnptr(vkSemaphore);
            
            public static void SignalVkSemaphoreNV(ulong vkSemaphore) => GLPointers._glSignalVkSemaphoreNV_fnptr(vkSemaphore);
            
            public static void SignalVkFenceNV(ulong vkFence) => GLPointers._glSignalVkFenceNV_fnptr(vkFence);
            
            public static void MapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, int ustride, int vstride, int uorder, int vorder, bool packed, void* points) => GLPointers._glMapControlPointsNV_fnptr((uint)target, index, (uint)type, ustride, vstride, uorder, vorder, (byte)(packed ? 1 : 0), points);
            
            public static void MapParameterivNV(EvalTargetNV target, MapParameterNV pname, int* parameters) => GLPointers._glMapParameterivNV_fnptr((uint)target, (uint)pname, parameters);
            
            public static void MapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float* parameters) => GLPointers._glMapParameterfvNV_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetMapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, int ustride, int vstride, bool packed, void* points) => GLPointers._glGetMapControlPointsNV_fnptr((uint)target, index, (uint)type, ustride, vstride, (byte)(packed ? 1 : 0), points);
            
            public static void GetMapParameterivNV(EvalTargetNV target, MapParameterNV pname, int* parameters) => GLPointers._glGetMapParameterivNV_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetMapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float* parameters) => GLPointers._glGetMapParameterfvNV_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetMapAttribParameterivNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, int* parameters) => GLPointers._glGetMapAttribParameterivNV_fnptr((uint)target, index, (uint)pname, parameters);
            
            public static void GetMapAttribParameterfvNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, float* parameters) => GLPointers._glGetMapAttribParameterfvNV_fnptr((uint)target, index, (uint)pname, parameters);
            
            public static void EvalMapsNV(EvalTargetNV target, EvalMapsModeNV mode) => GLPointers._glEvalMapsNV_fnptr((uint)target, (uint)mode);
            
            public static void GetMultisamplefvNV(GetMultisamplePNameNV pname, uint index, float* val) => GLPointers._glGetMultisamplefvNV_fnptr((uint)pname, index, val);
            
            public static void SampleMaskIndexedNV(uint index, uint mask) => GLPointers._glSampleMaskIndexedNV_fnptr(index, mask);
            
            public static void TexRenderbufferNV(TextureTarget target, int renderbuffer) => GLPointers._glTexRenderbufferNV_fnptr((uint)target, renderbuffer);
            
            public static void DeleteFencesNV(int n, uint* fences) => GLPointers._glDeleteFencesNV_fnptr(n, fences);
            
            public static void GenFencesNV(int n, uint* fences) => GLPointers._glGenFencesNV_fnptr(n, fences);
            
            public static bool IsFenceNV(uint fence) => GLPointers._glIsFenceNV_fnptr(fence) != 0;
            
            public static bool TestFenceNV(uint fence) => GLPointers._glTestFenceNV_fnptr(fence) != 0;
            
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => GLPointers._glGetFenceivNV_fnptr(fence, (uint)pname, parameters);
            
            public static void FinishFenceNV(uint fence) => GLPointers._glFinishFenceNV_fnptr(fence);
            
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => GLPointers._glSetFenceNV_fnptr(fence, (uint)condition);
            
            public static void FragmentCoverageColorNV(uint color) => GLPointers._glFragmentCoverageColorNV_fnptr(color);
            
            public static void ProgramNamedParameter4fNV(int id, int len, byte* name, float x, float y, float z, float w) => GLPointers._glProgramNamedParameter4fNV_fnptr(id, len, name, x, y, z, w);
            
            public static void ProgramNamedParameter4fvNV(int id, int len, byte* name, float* v) => GLPointers._glProgramNamedParameter4fvNV_fnptr(id, len, name, v);
            
            public static void ProgramNamedParameter4dNV(int id, int len, byte* name, double x, double y, double z, double w) => GLPointers._glProgramNamedParameter4dNV_fnptr(id, len, name, x, y, z, w);
            
            public static void ProgramNamedParameter4dvNV(int id, int len, byte* name, double* v) => GLPointers._glProgramNamedParameter4dvNV_fnptr(id, len, name, v);
            
            public static void GetProgramNamedParameterfvNV(int id, int len, byte* name, float* parameters) => GLPointers._glGetProgramNamedParameterfvNV_fnptr(id, len, name, parameters);
            
            public static void GetProgramNamedParameterdvNV(int id, int len, byte* name, double* parameters) => GLPointers._glGetProgramNamedParameterdvNV_fnptr(id, len, name, parameters);
            
            public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void CoverageModulationTableNV(int n, float* v) => GLPointers._glCoverageModulationTableNV_fnptr(n, v);
            
            public static void GetCoverageModulationTableNV(int bufSize, float* v) => GLPointers._glGetCoverageModulationTableNV_fnptr(bufSize, v);
            
            public static void CoverageModulationNV(All components) => GLPointers._glCoverageModulationNV_fnptr((uint)components);
            
            public static void RenderbufferStorageMultisampleCoverageNV(RenderbufferTarget target, int coverageSamples, int colorSamples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleCoverageNV_fnptr((uint)target, coverageSamples, colorSamples, (uint)internalformat, width, height);
            
            public static void ProgramVertexLimitNV(ProgramTarget target, int limit) => GLPointers._glProgramVertexLimitNV_fnptr((uint)target, limit);
            
            public static void FramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureEXT_fnptr((uint)target, (uint)attachment, texture, level);
            
            public static void FramebufferTextureLayerEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayerEXT_fnptr((uint)target, (uint)attachment, texture, level, layer);
            
            public static void FramebufferTextureFaceEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, TextureTarget face) => GLPointers._glFramebufferTextureFaceEXT_fnptr((uint)target, (uint)attachment, texture, level, (uint)face);
            
            public static void ProgramLocalParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w) => GLPointers._glProgramLocalParameterI4iNV_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramLocalParameterI4ivNV(ProgramTarget target, uint index, int* parameters) => GLPointers._glProgramLocalParameterI4ivNV_fnptr((uint)target, index, parameters);
            
            public static void ProgramLocalParametersI4ivNV(ProgramTarget target, uint index, int count, int* parameters) => GLPointers._glProgramLocalParametersI4ivNV_fnptr((uint)target, index, count, parameters);
            
            public static void ProgramLocalParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w) => GLPointers._glProgramLocalParameterI4uiNV_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramLocalParameterI4uivNV(ProgramTarget target, uint index, uint* parameters) => GLPointers._glProgramLocalParameterI4uivNV_fnptr((uint)target, index, parameters);
            
            public static void ProgramLocalParametersI4uivNV(ProgramTarget target, uint index, int count, uint* parameters) => GLPointers._glProgramLocalParametersI4uivNV_fnptr((uint)target, index, count, parameters);
            
            public static void ProgramEnvParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w) => GLPointers._glProgramEnvParameterI4iNV_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramEnvParameterI4ivNV(ProgramTarget target, uint index, int* parameters) => GLPointers._glProgramEnvParameterI4ivNV_fnptr((uint)target, index, parameters);
            
            public static void ProgramEnvParametersI4ivNV(ProgramTarget target, uint index, int count, int* parameters) => GLPointers._glProgramEnvParametersI4ivNV_fnptr((uint)target, index, count, parameters);
            
            public static void ProgramEnvParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w) => GLPointers._glProgramEnvParameterI4uiNV_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramEnvParameterI4uivNV(ProgramTarget target, uint index, uint* parameters) => GLPointers._glProgramEnvParameterI4uivNV_fnptr((uint)target, index, parameters);
            
            public static void ProgramEnvParametersI4uivNV(ProgramTarget target, uint index, int count, uint* parameters) => GLPointers._glProgramEnvParametersI4uivNV_fnptr((uint)target, index, count, parameters);
            
            public static void GetProgramLocalParameterIivNV(ProgramTarget target, uint index, int* parameters) => GLPointers._glGetProgramLocalParameterIivNV_fnptr((uint)target, index, parameters);
            
            public static void GetProgramLocalParameterIuivNV(ProgramTarget target, uint index, uint* parameters) => GLPointers._glGetProgramLocalParameterIuivNV_fnptr((uint)target, index, parameters);
            
            public static void GetProgramEnvParameterIivNV(ProgramTarget target, uint index, int* parameters) => GLPointers._glGetProgramEnvParameterIivNV_fnptr((uint)target, index, parameters);
            
            public static void GetProgramEnvParameterIuivNV(ProgramTarget target, uint index, uint* parameters) => GLPointers._glGetProgramEnvParameterIuivNV_fnptr((uint)target, index, parameters);
            
            public static void ProgramSubroutineParametersuivNV(All target, int count, uint* parameters) => GLPointers._glProgramSubroutineParametersuivNV_fnptr((uint)target, count, parameters);
            
            public static void GetProgramSubroutineParameteruivNV(All target, uint index, uint* param) => GLPointers._glGetProgramSubroutineParameteruivNV_fnptr((uint)target, index, param);
            
            public static void Uniform1i64NV(int location, long x) => GLPointers._glUniform1i64NV_fnptr(location, x);
            
            public static void Uniform2i64NV(int location, long x, long y) => GLPointers._glUniform2i64NV_fnptr(location, x, y);
            
            public static void Uniform3i64NV(int location, long x, long y, long z) => GLPointers._glUniform3i64NV_fnptr(location, x, y, z);
            
            public static void Uniform4i64NV(int location, long x, long y, long z, long w) => GLPointers._glUniform4i64NV_fnptr(location, x, y, z, w);
            
            public static void Uniform1i64vNV(int location, int count, long* value) => GLPointers._glUniform1i64vNV_fnptr(location, count, value);
            
            public static void Uniform2i64vNV(int location, int count, long* value) => GLPointers._glUniform2i64vNV_fnptr(location, count, value);
            
            public static void Uniform3i64vNV(int location, int count, long* value) => GLPointers._glUniform3i64vNV_fnptr(location, count, value);
            
            public static void Uniform4i64vNV(int location, int count, long* value) => GLPointers._glUniform4i64vNV_fnptr(location, count, value);
            
            public static void Uniform1ui64NV(int location, ulong x) => GLPointers._glUniform1ui64NV_fnptr(location, x);
            
            public static void Uniform2ui64NV(int location, ulong x, ulong y) => GLPointers._glUniform2ui64NV_fnptr(location, x, y);
            
            public static void Uniform3ui64NV(int location, ulong x, ulong y, ulong z) => GLPointers._glUniform3ui64NV_fnptr(location, x, y, z);
            
            public static void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glUniform4ui64NV_fnptr(location, x, y, z, w);
            
            public static void Uniform1ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform1ui64vNV_fnptr(location, count, value);
            
            public static void Uniform2ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform2ui64vNV_fnptr(location, count, value);
            
            public static void Uniform3ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform3ui64vNV_fnptr(location, count, value);
            
            public static void Uniform4ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform4ui64vNV_fnptr(location, count, value);
            
            public static void GetUniformi64vNV(int program, int location, long* parameters) => GLPointers._glGetUniformi64vNV_fnptr(program, location, parameters);
            
            public static void ProgramUniform1i64NV(int program, int location, long x) => GLPointers._glProgramUniform1i64NV_fnptr(program, location, x);
            
            public static void ProgramUniform2i64NV(int program, int location, long x, long y) => GLPointers._glProgramUniform2i64NV_fnptr(program, location, x, y);
            
            public static void ProgramUniform3i64NV(int program, int location, long x, long y, long z) => GLPointers._glProgramUniform3i64NV_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform4i64NV(int program, int location, long x, long y, long z, long w) => GLPointers._glProgramUniform4i64NV_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform1i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform1i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform2i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform2i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform3i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform3i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform4i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform4i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform1ui64NV(int program, int location, ulong x) => GLPointers._glProgramUniform1ui64NV_fnptr(program, location, x);
            
            public static void ProgramUniform2ui64NV(int program, int location, ulong x, ulong y) => GLPointers._glProgramUniform2ui64NV_fnptr(program, location, x, y);
            
            public static void ProgramUniform3ui64NV(int program, int location, ulong x, ulong y, ulong z) => GLPointers._glProgramUniform3ui64NV_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform4ui64NV(int program, int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glProgramUniform4ui64NV_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform1ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform1ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform2ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform2ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform3ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform3ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform4ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform4ui64vNV_fnptr(program, location, count, value);
            
            public static void Vertex2hNV(Half x, Half y) => GLPointers._glVertex2hNV_fnptr((ushort)x, (ushort)y);
            
            public static void Vertex2hvNV(Half* v) => GLPointers._glVertex2hvNV_fnptr((ushort*)v);
            
            public static void Vertex3hNV(Half x, Half y, Half z) => GLPointers._glVertex3hNV_fnptr((ushort)x, (ushort)y, (ushort)z);
            
            public static void Vertex3hvNV(Half* v) => GLPointers._glVertex3hvNV_fnptr((ushort*)v);
            
            public static void Vertex4hNV(Half x, Half y, Half z, Half w) => GLPointers._glVertex4hNV_fnptr((ushort)x, (ushort)y, (ushort)z, (ushort)w);
            
            public static void Vertex4hvNV(Half* v) => GLPointers._glVertex4hvNV_fnptr((ushort*)v);
            
            public static void Normal3hNV(Half nx, Half ny, Half nz) => GLPointers._glNormal3hNV_fnptr((ushort)nx, (ushort)ny, (ushort)nz);
            
            public static void Normal3hvNV(Half* v) => GLPointers._glNormal3hvNV_fnptr((ushort*)v);
            
            public static void Color3hNV(Half red, Half green, Half blue) => GLPointers._glColor3hNV_fnptr((ushort)red, (ushort)green, (ushort)blue);
            
            public static void Color3hvNV(Half* v) => GLPointers._glColor3hvNV_fnptr((ushort*)v);
            
            public static void Color4hNV(Half red, Half green, Half blue, Half alpha) => GLPointers._glColor4hNV_fnptr((ushort)red, (ushort)green, (ushort)blue, (ushort)alpha);
            
            public static void Color4hvNV(Half* v) => GLPointers._glColor4hvNV_fnptr((ushort*)v);
            
            public static void TexCoord1hNV(Half s) => GLPointers._glTexCoord1hNV_fnptr((ushort)s);
            
            public static void TexCoord1hvNV(Half* v) => GLPointers._glTexCoord1hvNV_fnptr((ushort*)v);
            
            public static void TexCoord2hNV(Half s, Half t) => GLPointers._glTexCoord2hNV_fnptr((ushort)s, (ushort)t);
            
            public static void TexCoord2hvNV(Half* v) => GLPointers._glTexCoord2hvNV_fnptr((ushort*)v);
            
            public static void TexCoord3hNV(Half s, Half t, Half r) => GLPointers._glTexCoord3hNV_fnptr((ushort)s, (ushort)t, (ushort)r);
            
            public static void TexCoord3hvNV(Half* v) => GLPointers._glTexCoord3hvNV_fnptr((ushort*)v);
            
            public static void TexCoord4hNV(Half s, Half t, Half r, Half q) => GLPointers._glTexCoord4hNV_fnptr((ushort)s, (ushort)t, (ushort)r, (ushort)q);
            
            public static void TexCoord4hvNV(Half* v) => GLPointers._glTexCoord4hvNV_fnptr((ushort*)v);
            
            public static void MultiTexCoord1hNV(TextureUnit target, Half s) => GLPointers._glMultiTexCoord1hNV_fnptr((uint)target, (ushort)s);
            
            public static void MultiTexCoord1hvNV(TextureUnit target, Half* v) => GLPointers._glMultiTexCoord1hvNV_fnptr((uint)target, (ushort*)v);
            
            public static void MultiTexCoord2hNV(TextureUnit target, Half s, Half t) => GLPointers._glMultiTexCoord2hNV_fnptr((uint)target, (ushort)s, (ushort)t);
            
            public static void MultiTexCoord2hvNV(TextureUnit target, Half* v) => GLPointers._glMultiTexCoord2hvNV_fnptr((uint)target, (ushort*)v);
            
            public static void MultiTexCoord3hNV(TextureUnit target, Half s, Half t, Half r) => GLPointers._glMultiTexCoord3hNV_fnptr((uint)target, (ushort)s, (ushort)t, (ushort)r);
            
            public static void MultiTexCoord3hvNV(TextureUnit target, Half* v) => GLPointers._glMultiTexCoord3hvNV_fnptr((uint)target, (ushort*)v);
            
            public static void MultiTexCoord4hNV(TextureUnit target, Half s, Half t, Half r, Half q) => GLPointers._glMultiTexCoord4hNV_fnptr((uint)target, (ushort)s, (ushort)t, (ushort)r, (ushort)q);
            
            public static void MultiTexCoord4hvNV(TextureUnit target, Half* v) => GLPointers._glMultiTexCoord4hvNV_fnptr((uint)target, (ushort*)v);
            
            public static void FogCoordhNV(Half fog) => GLPointers._glFogCoordhNV_fnptr((ushort)fog);
            
            public static void FogCoordhvNV(Half* fog) => GLPointers._glFogCoordhvNV_fnptr((ushort*)fog);
            
            public static void SecondaryColor3hNV(Half red, Half green, Half blue) => GLPointers._glSecondaryColor3hNV_fnptr((ushort)red, (ushort)green, (ushort)blue);
            
            public static void SecondaryColor3hvNV(Half* v) => GLPointers._glSecondaryColor3hvNV_fnptr((ushort*)v);
            
            public static void VertexWeighthNV(Half weight) => GLPointers._glVertexWeighthNV_fnptr((ushort)weight);
            
            public static void VertexWeighthvNV(Half* weight) => GLPointers._glVertexWeighthvNV_fnptr((ushort*)weight);
            
            public static void VertexAttrib1hNV(uint index, Half x) => GLPointers._glVertexAttrib1hNV_fnptr(index, (ushort)x);
            
            public static void VertexAttrib1hvNV(uint index, Half* v) => GLPointers._glVertexAttrib1hvNV_fnptr(index, (ushort*)v);
            
            public static void VertexAttrib2hNV(uint index, Half x, Half y) => GLPointers._glVertexAttrib2hNV_fnptr(index, (ushort)x, (ushort)y);
            
            public static void VertexAttrib2hvNV(uint index, Half* v) => GLPointers._glVertexAttrib2hvNV_fnptr(index, (ushort*)v);
            
            public static void VertexAttrib3hNV(uint index, Half x, Half y, Half z) => GLPointers._glVertexAttrib3hNV_fnptr(index, (ushort)x, (ushort)y, (ushort)z);
            
            public static void VertexAttrib3hvNV(uint index, Half* v) => GLPointers._glVertexAttrib3hvNV_fnptr(index, (ushort*)v);
            
            public static void VertexAttrib4hNV(uint index, Half x, Half y, Half z, Half w) => GLPointers._glVertexAttrib4hNV_fnptr(index, (ushort)x, (ushort)y, (ushort)z, (ushort)w);
            
            public static void VertexAttrib4hvNV(uint index, Half* v) => GLPointers._glVertexAttrib4hvNV_fnptr(index, (ushort*)v);
            
            public static void VertexAttribs1hvNV(uint index, int n, Half* v) => GLPointers._glVertexAttribs1hvNV_fnptr(index, n, (ushort*)v);
            
            public static void VertexAttribs2hvNV(uint index, int n, Half* v) => GLPointers._glVertexAttribs2hvNV_fnptr(index, n, (ushort*)v);
            
            public static void VertexAttribs3hvNV(uint index, int n, Half* v) => GLPointers._glVertexAttribs3hvNV_fnptr(index, n, (ushort*)v);
            
            public static void VertexAttribs4hvNV(uint index, int n, Half* v) => GLPointers._glVertexAttribs4hvNV_fnptr(index, n, (ushort*)v);
            
            public static void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformatSampleivNV_fnptr((uint)target, (uint)internalformat, samples, (uint)pname, count, parameters);
            
            public static void RenderGpuMaskNV(uint mask) => GLPointers._glRenderGpuMaskNV_fnptr(mask);
            
            public static void MulticastBufferSubDataNV(uint gpuMask, int buffer, IntPtr offset, nint size, void* data) => GLPointers._glMulticastBufferSubDataNV_fnptr(gpuMask, buffer, offset, size, data);
            
            public static void MulticastCopyBufferSubDataNV(uint readGpu, uint writeGpuMask, int readBuffer, int writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glMulticastCopyBufferSubDataNV_fnptr(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);
            
            public static void MulticastCopyImageSubDataNV(uint srcGpu, uint dstGpuMask, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glMulticastCopyImageSubDataNV_fnptr(srcGpu, dstGpuMask, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            public static void MulticastBlitFramebufferNV(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, All filter) => GLPointers._glMulticastBlitFramebufferNV_fnptr(srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static void MulticastFramebufferSampleLocationsfvNV(uint gpu, int framebuffer, uint start, int count, float* v) => GLPointers._glMulticastFramebufferSampleLocationsfvNV_fnptr(gpu, framebuffer, start, count, v);
            
            public static void MulticastBarrierNV() => GLPointers._glMulticastBarrierNV_fnptr();
            
            public static void MulticastWaitSyncNV(uint signalGpu, uint waitGpuMask) => GLPointers._glMulticastWaitSyncNV_fnptr(signalGpu, waitGpuMask);
            
            public static void MulticastGetQueryObjectivNV(uint gpu, uint id, All pname, int* parameters) => GLPointers._glMulticastGetQueryObjectivNV_fnptr(gpu, id, (uint)pname, parameters);
            
            public static void MulticastGetQueryObjectuivNV(uint gpu, uint id, All pname, uint* parameters) => GLPointers._glMulticastGetQueryObjectuivNV_fnptr(gpu, id, (uint)pname, parameters);
            
            public static void MulticastGetQueryObjecti64vNV(uint gpu, uint id, All pname, long* parameters) => GLPointers._glMulticastGetQueryObjecti64vNV_fnptr(gpu, id, (uint)pname, parameters);
            
            public static void MulticastGetQueryObjectui64vNV(uint gpu, uint id, All pname, ulong* parameters) => GLPointers._glMulticastGetQueryObjectui64vNV_fnptr(gpu, id, (uint)pname, parameters);
            
            public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, All pname, int first, int count, uint* parameters) => GLPointers._glGetMemoryObjectDetachedResourcesuivNV_fnptr(memory, (uint)pname, first, count, parameters);
            
            public static void ResetMemoryObjectParameterNV(uint memory, All pname) => GLPointers._glResetMemoryObjectParameterNV_fnptr(memory, (uint)pname);
            
            public static void TexAttachMemoryNV(TextureTarget target, uint memory, ulong offset) => GLPointers._glTexAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            public static void BufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset) => GLPointers._glBufferAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            public static void TextureAttachMemoryNV(int texture, uint memory, ulong offset) => GLPointers._glTextureAttachMemoryNV_fnptr(texture, memory, offset);
            
            public static void NamedBufferAttachMemoryNV(int buffer, uint memory, ulong offset) => GLPointers._glNamedBufferAttachMemoryNV_fnptr(buffer, memory, offset);
            
            public static void BufferPageCommitmentMemNV(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glBufferPageCommitmentMemNV_fnptr((uint)target, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            public static void TexPageCommitmentMemNV(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexPageCommitmentMemNV_fnptr((uint)target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            public static void NamedBufferPageCommitmentMemNV(int buffer, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glNamedBufferPageCommitmentMemNV_fnptr(buffer, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            public static void TexturePageCommitmentMemNV(int texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexturePageCommitmentMemNV_fnptr(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            public static void DrawMeshTasksNV(uint first, uint count) => GLPointers._glDrawMeshTasksNV_fnptr(first, count);
            
            public static void DrawMeshTasksIndirectNV(IntPtr indirect) => GLPointers._glDrawMeshTasksIndirectNV_fnptr(indirect);
            
            public static void MultiDrawMeshTasksIndirectNV(IntPtr indirect, int drawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectNV_fnptr(indirect, drawcount, stride);
            
            public static void MultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectCountNV_fnptr(indirect, drawcount, maxdrawcount, stride);
            
            public static void GenOcclusionQueriesNV(int n, uint* ids) => GLPointers._glGenOcclusionQueriesNV_fnptr(n, ids);
            
            public static void DeleteOcclusionQueriesNV(int n, uint* ids) => GLPointers._glDeleteOcclusionQueriesNV_fnptr(n, ids);
            
            public static bool IsOcclusionQueryNV(uint id) => GLPointers._glIsOcclusionQueryNV_fnptr(id) != 0;
            
            public static void BeginOcclusionQueryNV(uint id) => GLPointers._glBeginOcclusionQueryNV_fnptr(id);
            
            public static void EndOcclusionQueryNV() => GLPointers._glEndOcclusionQueryNV_fnptr();
            
            public static void GetOcclusionQueryivNV(uint id, OcclusionQueryParameterNameNV pname, int* parameters) => GLPointers._glGetOcclusionQueryivNV_fnptr(id, (uint)pname, parameters);
            
            public static void GetOcclusionQueryuivNV(uint id, OcclusionQueryParameterNameNV pname, uint* parameters) => GLPointers._glGetOcclusionQueryuivNV_fnptr(id, (uint)pname, parameters);
            
            public static void ProgramBufferParametersfvNV(ProgramTarget target, uint bindingIndex, uint wordIndex, int count, float* parameters) => GLPointers._glProgramBufferParametersfvNV_fnptr((uint)target, bindingIndex, wordIndex, count, parameters);
            
            public static void ProgramBufferParametersIivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, int count, int* parameters) => GLPointers._glProgramBufferParametersIivNV_fnptr((uint)target, bindingIndex, wordIndex, count, parameters);
            
            public static void ProgramBufferParametersIuivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, int count, uint* parameters) => GLPointers._glProgramBufferParametersIuivNV_fnptr((uint)target, bindingIndex, wordIndex, count, parameters);
            
            public static uint GenPathsNV(int range) => GLPointers._glGenPathsNV_fnptr(range);
            
            public static void DeletePathsNV(uint path, int range) => GLPointers._glDeletePathsNV_fnptr(path, range);
            
            public static bool IsPathNV(uint path) => GLPointers._glIsPathNV_fnptr(path) != 0;
            
            public static void PathCommandsNV(uint path, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCommandsNV_fnptr(path, numCommands, commands, numCoords, (uint)coordType, coords);
            
            public static void PathCoordsNV(uint path, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCoordsNV_fnptr(path, numCoords, (uint)coordType, coords);
            
            public static void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCommandsNV_fnptr(path, commandStart, commandsToDelete, numCommands, commands, numCoords, (uint)coordType, coords);
            
            public static void PathSubCoordsNV(uint path, int coordStart, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCoordsNV_fnptr(path, coordStart, numCoords, (uint)coordType, coords);
            
            public static void PathStringNV(uint path, PathStringFormat format, int length, void* pathString) => GLPointers._glPathStringNV_fnptr(path, (uint)format, length, pathString);
            
            public static void PathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, void* charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphsNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, numGlyphs, (uint)type, charcodes, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            public static void PathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphRangeNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyph, numGlyphs, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            public static void WeightPathsNV(uint resultPath, int numPaths, uint* paths, float* weights) => GLPointers._glWeightPathsNV_fnptr(resultPath, numPaths, paths, weights);
            
            public static void CopyPathNV(uint resultPath, uint srcPath) => GLPointers._glCopyPathNV_fnptr(resultPath, srcPath);
            
            public static void InterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight) => GLPointers._glInterpolatePathsNV_fnptr(resultPath, pathA, pathB, weight);
            
            public static void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float* transformValues) => GLPointers._glTransformPathNV_fnptr(resultPath, srcPath, (uint)transformType, transformValues);
            
            public static void PathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._glPathParameterivNV_fnptr(path, (uint)pname, value);
            
            public static void PathParameteriNV(uint path, PathParameter pname, int value) => GLPointers._glPathParameteriNV_fnptr(path, (uint)pname, value);
            
            public static void PathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._glPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            public static void PathParameterfNV(uint path, PathParameter pname, float value) => GLPointers._glPathParameterfNV_fnptr(path, (uint)pname, value);
            
            public static void PathDashArrayNV(uint path, int dashCount, float* dashArray) => GLPointers._glPathDashArrayNV_fnptr(path, dashCount, dashArray);
            
            public static void PathStencilFuncNV(StencilFunction func, int reference, uint mask) => GLPointers._glPathStencilFuncNV_fnptr((uint)func, reference, mask);
            
            public static void PathStencilDepthOffsetNV(float factor, float units) => GLPointers._glPathStencilDepthOffsetNV_fnptr(factor, units);
            
            public static void StencilFillPathNV(uint path, PathFillMode fillMode, uint mask) => GLPointers._glStencilFillPathNV_fnptr(path, (uint)fillMode, mask);
            
            public static void StencilStrokePathNV(uint path, int reference, uint mask) => GLPointers._glStencilStrokePathNV_fnptr(path, reference, mask);
            
            public static void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)transformType, transformValues);
            
            public static void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)transformType, transformValues);
            
            public static void PathCoverDepthFuncNV(DepthFunction func) => GLPointers._glPathCoverDepthFuncNV_fnptr((uint)func);
            
            public static void CoverFillPathNV(uint path, PathCoverMode coverMode) => GLPointers._glCoverFillPathNV_fnptr(path, (uint)coverMode);
            
            public static void CoverStrokePathNV(uint path, PathCoverMode coverMode) => GLPointers._glCoverStrokePathNV_fnptr(path, (uint)coverMode);
            
            public static void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            public static void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            public static void GetPathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._glGetPathParameterivNV_fnptr(path, (uint)pname, value);
            
            public static void GetPathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._glGetPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            public static void GetPathCommandsNV(uint path, byte* commands) => GLPointers._glGetPathCommandsNV_fnptr(path, commands);
            
            public static void GetPathCoordsNV(uint path, float* coords) => GLPointers._glGetPathCoordsNV_fnptr(path, coords);
            
            public static void GetPathDashArrayNV(uint path, float* dashArray) => GLPointers._glGetPathDashArrayNV_fnptr(path, dashArray);
            
            public static void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int stride, float* metrics) => GLPointers._glGetPathMetricsNV_fnptr((uint)metricQueryMask, numPaths, (uint)pathNameType, paths, pathBase, stride, metrics);
            
            public static void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics) => GLPointers._glGetPathMetricRangeNV_fnptr((uint)metricQueryMask, firstPathName, numPaths, stride, metrics);
            
            public static void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float* returnedSpacing) => GLPointers._glGetPathSpacingNV_fnptr((uint)pathListMode, numPaths, (uint)pathNameType, paths, pathBase, advanceScale, kerningScale, (uint)transformType, returnedSpacing);
            
            public static bool IsPointInFillPathNV(uint path, uint mask, float x, float y) => GLPointers._glIsPointInFillPathNV_fnptr(path, mask, x, y) != 0;
            
            public static bool IsPointInStrokePathNV(uint path, float x, float y) => GLPointers._glIsPointInStrokePathNV_fnptr(path, x, y) != 0;
            
            public static float GetPathLengthNV(uint path, int startSegment, int numSegments) => GLPointers._glGetPathLengthNV_fnptr(path, startSegment, numSegments);
            
            public static bool PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY) => GLPointers._glPointAlongPathNV_fnptr(path, startSegment, numSegments, distance, x, y, tangentX, tangentY) != 0;
            
            public static void MatrixLoad3x2fNV(All matrixMode, float* m) => GLPointers._glMatrixLoad3x2fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixLoad3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixLoad3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixLoadTranspose3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixLoadTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixMult3x2fNV(All matrixMode, float* m) => GLPointers._glMatrixMult3x2fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixMult3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixMult3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixMultTranspose3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixMultTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void StencilThenCoverFillPathNV(uint path, PathFillMode fillMode, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverFillPathNV_fnptr(path, (uint)fillMode, mask, (uint)coverMode);
            
            public static void StencilThenCoverStrokePathNV(uint path, int reference, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverStrokePathNV_fnptr(path, reference, mask, (uint)coverMode);
            
            public static void StencilThenCoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            public static void StencilThenCoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            public static All PathGlyphIndexRangeNV(All fontTarget, void* fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount) => (All) GLPointers._glPathGlyphIndexRangeNV_fnptr((uint)fontTarget, fontName, (uint)fontStyle, pathParameterTemplate, emScale, baseAndCount);
            
            public static All PathGlyphIndexArrayNV(uint firstPathName, All fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            public static All PathMemoryGlyphIndexArrayNV(uint firstPathName, All fontTarget, nint fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathMemoryGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            public static void ProgramPathFragmentInputGenNV(int program, int location, All genMode, int components, float* coeffs) => GLPointers._glProgramPathFragmentInputGenNV_fnptr(program, location, (uint)genMode, components, coeffs);
            
            public static void GetProgramResourcefvNV(int program, ProgramInterface programInterface, uint index, int propCount, All* props, int count, int* length, float* parameters) => GLPointers._glGetProgramResourcefvNV_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
            
            public static void PathColorGenNV(PathColor color, PathGenMode genMode, PathColorFormat colorFormat, float* coeffs) => GLPointers._glPathColorGenNV_fnptr((uint)color, (uint)genMode, (uint)colorFormat, coeffs);
            
            public static void PathTexGenNV(PathColor texCoordSet, PathGenMode genMode, int components, float* coeffs) => GLPointers._glPathTexGenNV_fnptr((uint)texCoordSet, (uint)genMode, components, coeffs);
            
            public static void PathFogGenNV(PathGenMode genMode) => GLPointers._glPathFogGenNV_fnptr((uint)genMode);
            
            public static void GetPathColorGenivNV(PathColor color, PathGenMode pname, int* value) => GLPointers._glGetPathColorGenivNV_fnptr((uint)color, (uint)pname, value);
            
            public static void GetPathColorGenfvNV(PathColor color, PathGenMode pname, float* value) => GLPointers._glGetPathColorGenfvNV_fnptr((uint)color, (uint)pname, value);
            
            public static void GetPathTexGenivNV(TextureUnit texCoordSet, PathGenMode pname, int* value) => GLPointers._glGetPathTexGenivNV_fnptr((uint)texCoordSet, (uint)pname, value);
            
            public static void GetPathTexGenfvNV(TextureUnit texCoordSet, PathGenMode pname, float* value) => GLPointers._glGetPathTexGenfvNV_fnptr((uint)texCoordSet, (uint)pname, value);
            
            public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixFrustumEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            public static void MatrixLoadIdentityEXT(MatrixMode mode) => GLPointers._glMatrixLoadIdentityEXT_fnptr((uint)mode);
            
            public static void MatrixLoadTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadTransposefEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoadTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoadTransposedEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoadfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadfEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoaddEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoaddEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultTransposefEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultTransposedEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultfEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultdEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultdEXT_fnptr((uint)mode, m);
            
            public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixOrthoEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            public static void MatrixPopEXT(MatrixMode mode) => GLPointers._glMatrixPopEXT_fnptr((uint)mode);
            
            public static void MatrixPushEXT(MatrixMode mode) => GLPointers._glMatrixPushEXT_fnptr((uint)mode);
            
            public static void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => GLPointers._glMatrixRotatefEXT_fnptr((uint)mode, angle, x, y, z);
            
            public static void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => GLPointers._glMatrixRotatedEXT_fnptr((uint)mode, angle, x, y, z);
            
            public static void MatrixScalefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixScalefEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixScaledEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixScaledEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixTranslatefEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixTranslatedEXT_fnptr((uint)mode, x, y, z);
            
            public static void PixelDataRangeNV(PixelDataRangeTargetNV target, int length, void* pointer) => GLPointers._glPixelDataRangeNV_fnptr((uint)target, length, pointer);
            
            public static void FlushPixelDataRangeNV(PixelDataRangeTargetNV target) => GLPointers._glFlushPixelDataRangeNV_fnptr((uint)target);
            
            public static void PointParameteriNV(PointParameterNameARB pname, int param) => GLPointers._glPointParameteriNV_fnptr((uint)pname, param);
            
            public static void PointParameterivNV(PointParameterNameARB pname, int* parameters) => GLPointers._glPointParameterivNV_fnptr((uint)pname, parameters);
            
            public static void PresentFrameKeyedNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, All type, All target0, uint fill0, uint key0, All target1, uint fill1, uint key1) => GLPointers._glPresentFrameKeyedNV_fnptr(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, (uint)type, (uint)target0, fill0, key0, (uint)target1, fill1, key1);
            
            public static void PresentFrameDualFillNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, All type, All target0, uint fill0, All target1, uint fill1, All target2, uint fill2, All target3, uint fill3) => GLPointers._glPresentFrameDualFillNV_fnptr(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, (uint)type, (uint)target0, fill0, (uint)target1, fill1, (uint)target2, fill2, (uint)target3, fill3);
            
            public static void GetVideoivNV(uint video_slot, All pname, int* parameters) => GLPointers._glGetVideoivNV_fnptr(video_slot, (uint)pname, parameters);
            
            public static void GetVideouivNV(uint video_slot, All pname, uint* parameters) => GLPointers._glGetVideouivNV_fnptr(video_slot, (uint)pname, parameters);
            
            public static void GetVideoi64vNV(uint video_slot, All pname, long* parameters) => GLPointers._glGetVideoi64vNV_fnptr(video_slot, (uint)pname, parameters);
            
            public static void GetVideoui64vNV(uint video_slot, All pname, ulong* parameters) => GLPointers._glGetVideoui64vNV_fnptr(video_slot, (uint)pname, parameters);
            
            public static void PrimitiveRestartNV() => GLPointers._glPrimitiveRestartNV_fnptr();
            
            public static void PrimitiveRestartIndexNV(uint index) => GLPointers._glPrimitiveRestartIndexNV_fnptr(index);
            
            public static int QueryResourceNV(All queryType, int tagId, uint count, int* buffer) => GLPointers._glQueryResourceNV_fnptr((uint)queryType, tagId, count, buffer);
            
            public static void GenQueryResourceTagNV(int n, int* tagIds) => GLPointers._glGenQueryResourceTagNV_fnptr(n, tagIds);
            
            public static void DeleteQueryResourceTagNV(int n, int* tagIds) => GLPointers._glDeleteQueryResourceTagNV_fnptr(n, tagIds);
            
            public static void QueryResourceTagNV(int tagId, byte* tagString) => GLPointers._glQueryResourceTagNV_fnptr(tagId, tagString);
            
            public static void CombinerParameterfvNV(CombinerParameterNV pname, float* parameters) => GLPointers._glCombinerParameterfvNV_fnptr((uint)pname, parameters);
            
            public static void CombinerParameterfNV(CombinerParameterNV pname, float param) => GLPointers._glCombinerParameterfNV_fnptr((uint)pname, param);
            
            public static void CombinerParameterivNV(CombinerParameterNV pname, int* parameters) => GLPointers._glCombinerParameterivNV_fnptr((uint)pname, parameters);
            
            public static void CombinerParameteriNV(CombinerParameterNV pname, int param) => GLPointers._glCombinerParameteriNV_fnptr((uint)pname, param);
            
            public static void CombinerInputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage) => GLPointers._glCombinerInputNV_fnptr((uint)stage, (uint)portion, (uint)variable, (uint)input, (uint)mapping, (uint)componentUsage);
            
            public static void CombinerOutputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerRegisterNV abOutput, CombinerRegisterNV cdOutput, CombinerRegisterNV sumOutput, CombinerScaleNV scale, CombinerBiasNV bias, bool abDotProduct, bool cdDotProduct, bool muxSum) => GLPointers._glCombinerOutputNV_fnptr((uint)stage, (uint)portion, (uint)abOutput, (uint)cdOutput, (uint)sumOutput, (uint)scale, (uint)bias, (byte)(abDotProduct ? 1 : 0), (byte)(cdDotProduct ? 1 : 0), (byte)(muxSum ? 1 : 0));
            
            public static void FinalCombinerInputNV(CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage) => GLPointers._glFinalCombinerInputNV_fnptr((uint)variable, (uint)input, (uint)mapping, (uint)componentUsage);
            
            public static void GetCombinerInputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, float* parameters) => GLPointers._glGetCombinerInputParameterfvNV_fnptr((uint)stage, (uint)portion, (uint)variable, (uint)pname, parameters);
            
            public static void GetCombinerInputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, int* parameters) => GLPointers._glGetCombinerInputParameterivNV_fnptr((uint)stage, (uint)portion, (uint)variable, (uint)pname, parameters);
            
            public static void GetCombinerOutputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, float* parameters) => GLPointers._glGetCombinerOutputParameterfvNV_fnptr((uint)stage, (uint)portion, (uint)pname, parameters);
            
            public static void GetCombinerOutputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, int* parameters) => GLPointers._glGetCombinerOutputParameterivNV_fnptr((uint)stage, (uint)portion, (uint)pname, parameters);
            
            public static void GetFinalCombinerInputParameterfvNV(CombinerVariableNV variable, CombinerParameterNV pname, float* parameters) => GLPointers._glGetFinalCombinerInputParameterfvNV_fnptr((uint)variable, (uint)pname, parameters);
            
            public static void GetFinalCombinerInputParameterivNV(CombinerVariableNV variable, CombinerParameterNV pname, int* parameters) => GLPointers._glGetFinalCombinerInputParameterivNV_fnptr((uint)variable, (uint)pname, parameters);
            
            public static void CombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float* parameters) => GLPointers._glCombinerStageParameterfvNV_fnptr((uint)stage, (uint)pname, parameters);
            
            public static void GetCombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float* parameters) => GLPointers._glGetCombinerStageParameterfvNV_fnptr((uint)stage, (uint)pname, parameters);
            
            public static void FramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, int count, float* v) => GLPointers._glFramebufferSampleLocationsfvNV_fnptr((uint)target, start, count, v);
            
            public static void NamedFramebufferSampleLocationsfvNV(int framebuffer, uint start, int count, float* v) => GLPointers._glNamedFramebufferSampleLocationsfvNV_fnptr(framebuffer, start, count, v);
            
            public static void ResolveDepthValuesNV() => GLPointers._glResolveDepthValuesNV_fnptr();
            
            public static void ScissorExclusiveNV(int x, int y, int width, int height) => GLPointers._glScissorExclusiveNV_fnptr(x, y, width, height);
            
            public static void ScissorExclusiveArrayvNV(uint first, int count, int* v) => GLPointers._glScissorExclusiveArrayvNV_fnptr(first, count, v);
            
            public static void MakeBufferResidentNV(All target, All access) => GLPointers._glMakeBufferResidentNV_fnptr((uint)target, (uint)access);
            
            public static void MakeBufferNonResidentNV(All target) => GLPointers._glMakeBufferNonResidentNV_fnptr((uint)target);
            
            public static bool IsBufferResidentNV(All target) => GLPointers._glIsBufferResidentNV_fnptr((uint)target) != 0;
            
            public static void MakeNamedBufferResidentNV(int buffer, All access) => GLPointers._glMakeNamedBufferResidentNV_fnptr(buffer, (uint)access);
            
            public static void MakeNamedBufferNonResidentNV(int buffer) => GLPointers._glMakeNamedBufferNonResidentNV_fnptr(buffer);
            
            public static bool IsNamedBufferResidentNV(int buffer) => GLPointers._glIsNamedBufferResidentNV_fnptr(buffer) != 0;
            
            public static void GetBufferParameterui64vNV(BufferTargetARB target, All pname, ulong* parameters) => GLPointers._glGetBufferParameterui64vNV_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetNamedBufferParameterui64vNV(int buffer, BufferPNameARB pname, ulong* parameters) => GLPointers._glGetNamedBufferParameterui64vNV_fnptr(buffer, (uint)pname, parameters);
            
            public static void GetIntegerui64vNV(All value, ulong* result) => GLPointers._glGetIntegerui64vNV_fnptr((uint)value, result);
            
            public static void Uniformui64NV(int location, ulong value) => GLPointers._glUniformui64NV_fnptr(location, value);
            
            public static void Uniformui64vNV(int location, int count, ulong* value) => GLPointers._glUniformui64vNV_fnptr(location, count, value);
            
            public static void GetUniformui64vNV(int program, int location, ulong* parameters) => GLPointers._glGetUniformui64vNV_fnptr(program, location, parameters);
            
            public static void ProgramUniformui64NV(int program, int location, ulong value) => GLPointers._glProgramUniformui64NV_fnptr(program, location, value);
            
            public static void ProgramUniformui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniformui64vNV_fnptr(program, location, count, value);
            
            public static void BindShadingRateImageNV(int texture) => GLPointers._glBindShadingRateImageNV_fnptr(texture);
            
            public static void GetShadingRateImagePaletteNV(uint viewport, uint entry, All* rate) => GLPointers._glGetShadingRateImagePaletteNV_fnptr(viewport, entry, (uint*)rate);
            
            public static void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, int* location) => GLPointers._glGetShadingRateSampleLocationivNV_fnptr((uint)rate, samples, index, location);
            
            public static void ShadingRateImageBarrierNV(bool synchronize) => GLPointers._glShadingRateImageBarrierNV_fnptr((byte)(synchronize ? 1 : 0));
            
            public static void ShadingRateImagePaletteNV(uint viewport, uint first, int count, All* rates) => GLPointers._glShadingRateImagePaletteNV_fnptr(viewport, first, count, (uint*)rates);
            
            public static void ShadingRateSampleOrderNV(All order) => GLPointers._glShadingRateSampleOrderNV_fnptr((uint)order);
            
            public static void ShadingRateSampleOrderCustomNV(All rate, uint samples, int* locations) => GLPointers._glShadingRateSampleOrderCustomNV_fnptr((uint)rate, samples, locations);
            
            public static void TextureBarrierNV() => GLPointers._glTextureBarrierNV_fnptr();
            
            public static void TexImage2DMultisampleCoverageNV(TextureTarget target, int coverageSamples, int colorSamples, InternalFormat internalFormat, int width, int height, bool fixedSampleLocations) => GLPointers._glTexImage2DMultisampleCoverageNV_fnptr((uint)target, coverageSamples, colorSamples, (int)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0));
            
            public static void TexImage3DMultisampleCoverageNV(TextureTarget target, int coverageSamples, int colorSamples, InternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations) => GLPointers._glTexImage3DMultisampleCoverageNV_fnptr((uint)target, coverageSamples, colorSamples, (int)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0));
            
            public static void TextureImage2DMultisampleNV(int texture, TextureTarget target, int samples, InternalFormat internalFormat, int width, int height, bool fixedSampleLocations) => GLPointers._glTextureImage2DMultisampleNV_fnptr(texture, (uint)target, samples, (int)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0));
            
            public static void TextureImage3DMultisampleNV(int texture, TextureTarget target, int samples, InternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations) => GLPointers._glTextureImage3DMultisampleNV_fnptr(texture, (uint)target, samples, (int)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0));
            
            public static void TextureImage2DMultisampleCoverageNV(int texture, TextureTarget target, int coverageSamples, int colorSamples, InternalFormat internalFormat, int width, int height, bool fixedSampleLocations) => GLPointers._glTextureImage2DMultisampleCoverageNV_fnptr(texture, (uint)target, coverageSamples, colorSamples, (int)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0));
            
            public static void TextureImage3DMultisampleCoverageNV(int texture, TextureTarget target, int coverageSamples, int colorSamples, InternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations) => GLPointers._glTextureImage3DMultisampleCoverageNV_fnptr(texture, (uint)target, coverageSamples, colorSamples, (int)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0));
            
            public static void BeginTransformFeedbackNV(PrimitiveType primitiveMode) => GLPointers._glBeginTransformFeedbackNV_fnptr((uint)primitiveMode);
            
            public static void EndTransformFeedbackNV() => GLPointers._glEndTransformFeedbackNV_fnptr();
            
            public static void TransformFeedbackAttribsNV(int count, int* attribs, All bufferMode) => GLPointers._glTransformFeedbackAttribsNV_fnptr(count, attribs, (uint)bufferMode);
            
            public static void BindBufferRangeNV(BufferTargetARB target, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glBindBufferRangeNV_fnptr((uint)target, index, buffer, offset, size);
            
            public static void BindBufferOffsetNV(BufferTargetARB target, uint index, int buffer, IntPtr offset) => GLPointers._glBindBufferOffsetNV_fnptr((uint)target, index, buffer, offset);
            
            public static void BindBufferBaseNV(BufferTargetARB target, uint index, int buffer) => GLPointers._glBindBufferBaseNV_fnptr((uint)target, index, buffer);
            
            public static void TransformFeedbackVaryingsNV(int program, int count, TransformFeedbackTokenNV* locations, TransformFeedbackBufferMode bufferMode) => GLPointers._glTransformFeedbackVaryingsNV_fnptr(program, count, (int*)locations, (uint)bufferMode);
            
            public static void ActiveVaryingNV(int program, byte* name) => GLPointers._glActiveVaryingNV_fnptr(program, name);
            
            public static int GetVaryingLocationNV(int program, byte* name) => GLPointers._glGetVaryingLocationNV_fnptr(program, name);
            
            public static void GetActiveVaryingNV(int program, uint index, int bufSize, int* length, int* size, All* type, byte* name) => GLPointers._glGetActiveVaryingNV_fnptr(program, index, bufSize, length, size, (uint*)type, name);
            
            public static void GetTransformFeedbackVaryingNV(int program, uint index, int* location) => GLPointers._glGetTransformFeedbackVaryingNV_fnptr(program, index, location);
            
            public static void TransformFeedbackStreamAttribsNV(int count, int* attribs, int nbuffers, int* bufstreams, All bufferMode) => GLPointers._glTransformFeedbackStreamAttribsNV_fnptr(count, attribs, nbuffers, bufstreams, (uint)bufferMode);
            
            public static void BindTransformFeedbackNV(BufferTargetARB target, int id) => GLPointers._glBindTransformFeedbackNV_fnptr((uint)target, id);
            
            public static void DeleteTransformFeedbacksNV(int n, int* ids) => GLPointers._glDeleteTransformFeedbacksNV_fnptr(n, ids);
            
            public static void GenTransformFeedbacksNV(int n, int* ids) => GLPointers._glGenTransformFeedbacksNV_fnptr(n, ids);
            
            public static bool IsTransformFeedbackNV(int id) => GLPointers._glIsTransformFeedbackNV_fnptr(id) != 0;
            
            public static void PauseTransformFeedbackNV() => GLPointers._glPauseTransformFeedbackNV_fnptr();
            
            public static void ResumeTransformFeedbackNV() => GLPointers._glResumeTransformFeedbackNV_fnptr();
            
            public static void DrawTransformFeedbackNV(PrimitiveType mode, int id) => GLPointers._glDrawTransformFeedbackNV_fnptr((uint)mode, id);
            
            public static void VDPAUInitNV(void* vdpDevice, void* getProcAddress) => GLPointers._glVDPAUInitNV_fnptr(vdpDevice, getProcAddress);
            
            public static void VDPAUFiniNV() => GLPointers._glVDPAUFiniNV_fnptr();
            
            public static IntPtr VDPAURegisterVideoSurfaceNV(void* vdpSurface, All target, int numTextureNames, uint* textureNames) => GLPointers._glVDPAURegisterVideoSurfaceNV_fnptr(vdpSurface, (uint)target, numTextureNames, textureNames);
            
            public static IntPtr VDPAURegisterOutputSurfaceNV(void* vdpSurface, All target, int numTextureNames, uint* textureNames) => GLPointers._glVDPAURegisterOutputSurfaceNV_fnptr(vdpSurface, (uint)target, numTextureNames, textureNames);
            
            public static bool VDPAUIsSurfaceNV(IntPtr surface) => GLPointers._glVDPAUIsSurfaceNV_fnptr(surface) != 0;
            
            public static void VDPAUUnregisterSurfaceNV(IntPtr surface) => GLPointers._glVDPAUUnregisterSurfaceNV_fnptr(surface);
            
            public static void VDPAUGetSurfaceivNV(IntPtr surface, All pname, int count, int* length, int* values) => GLPointers._glVDPAUGetSurfaceivNV_fnptr(surface, (uint)pname, count, length, values);
            
            public static void VDPAUSurfaceAccessNV(IntPtr surface, All access) => GLPointers._glVDPAUSurfaceAccessNV_fnptr(surface, (uint)access);
            
            public static void VDPAUMapSurfacesNV(int numSurfaces, IntPtr* surfaces) => GLPointers._glVDPAUMapSurfacesNV_fnptr(numSurfaces, surfaces);
            
            public static void VDPAUUnmapSurfacesNV(int numSurface, IntPtr* surfaces) => GLPointers._glVDPAUUnmapSurfacesNV_fnptr(numSurface, surfaces);
            
            public static IntPtr VDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, All target, int numTextureNames, uint* textureNames, bool isFrameStructure) => GLPointers._glVDPAURegisterVideoSurfaceWithPictureStructureNV_fnptr(vdpSurface, (uint)target, numTextureNames, textureNames, (byte)(isFrameStructure ? 1 : 0));
            
            public static void FlushVertexArrayRangeNV() => GLPointers._glFlushVertexArrayRangeNV_fnptr();
            
            public static void VertexArrayRangeNV(int length, void* pointer) => GLPointers._glVertexArrayRangeNV_fnptr(length, pointer);
            
            public static void VertexAttribL1i64NV(uint index, long x) => GLPointers._glVertexAttribL1i64NV_fnptr(index, x);
            
            public static void VertexAttribL2i64NV(uint index, long x, long y) => GLPointers._glVertexAttribL2i64NV_fnptr(index, x, y);
            
            public static void VertexAttribL3i64NV(uint index, long x, long y, long z) => GLPointers._glVertexAttribL3i64NV_fnptr(index, x, y, z);
            
            public static void VertexAttribL4i64NV(uint index, long x, long y, long z, long w) => GLPointers._glVertexAttribL4i64NV_fnptr(index, x, y, z, w);
            
            public static void VertexAttribL1i64vNV(uint index, long* v) => GLPointers._glVertexAttribL1i64vNV_fnptr(index, v);
            
            public static void VertexAttribL2i64vNV(uint index, long* v) => GLPointers._glVertexAttribL2i64vNV_fnptr(index, v);
            
            public static void VertexAttribL3i64vNV(uint index, long* v) => GLPointers._glVertexAttribL3i64vNV_fnptr(index, v);
            
            public static void VertexAttribL4i64vNV(uint index, long* v) => GLPointers._glVertexAttribL4i64vNV_fnptr(index, v);
            
            public static void VertexAttribL1ui64NV(uint index, ulong x) => GLPointers._glVertexAttribL1ui64NV_fnptr(index, x);
            
            public static void VertexAttribL2ui64NV(uint index, ulong x, ulong y) => GLPointers._glVertexAttribL2ui64NV_fnptr(index, x, y);
            
            public static void VertexAttribL3ui64NV(uint index, ulong x, ulong y, ulong z) => GLPointers._glVertexAttribL3ui64NV_fnptr(index, x, y, z);
            
            public static void VertexAttribL4ui64NV(uint index, ulong x, ulong y, ulong z, ulong w) => GLPointers._glVertexAttribL4ui64NV_fnptr(index, x, y, z, w);
            
            public static void VertexAttribL1ui64vNV(uint index, ulong* v) => GLPointers._glVertexAttribL1ui64vNV_fnptr(index, v);
            
            public static void VertexAttribL2ui64vNV(uint index, ulong* v) => GLPointers._glVertexAttribL2ui64vNV_fnptr(index, v);
            
            public static void VertexAttribL3ui64vNV(uint index, ulong* v) => GLPointers._glVertexAttribL3ui64vNV_fnptr(index, v);
            
            public static void VertexAttribL4ui64vNV(uint index, ulong* v) => GLPointers._glVertexAttribL4ui64vNV_fnptr(index, v);
            
            public static void GetVertexAttribLi64vNV(uint index, VertexAttribEnum pname, long* parameters) => GLPointers._glGetVertexAttribLi64vNV_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribLui64vNV(uint index, VertexAttribEnum pname, ulong* parameters) => GLPointers._glGetVertexAttribLui64vNV_fnptr(index, (uint)pname, parameters);
            
            public static void VertexAttribLFormatNV(uint index, int size, VertexAttribLType type, int stride) => GLPointers._glVertexAttribLFormatNV_fnptr(index, size, (uint)type, stride);
            
            public static void BufferAddressRangeNV(All pname, uint index, ulong address, nint length) => GLPointers._glBufferAddressRangeNV_fnptr((uint)pname, index, address, length);
            
            public static void VertexFormatNV(int size, VertexPointerType type, int stride) => GLPointers._glVertexFormatNV_fnptr(size, (uint)type, stride);
            
            public static void NormalFormatNV(All type, int stride) => GLPointers._glNormalFormatNV_fnptr((uint)type, stride);
            
            public static void ColorFormatNV(int size, ColorPointerType type, int stride) => GLPointers._glColorFormatNV_fnptr(size, (uint)type, stride);
            
            public static void IndexFormatNV(All type, int stride) => GLPointers._glIndexFormatNV_fnptr((uint)type, stride);
            
            public static void TexCoordFormatNV(int size, All type, int stride) => GLPointers._glTexCoordFormatNV_fnptr(size, (uint)type, stride);
            
            public static void EdgeFlagFormatNV(int stride) => GLPointers._glEdgeFlagFormatNV_fnptr(stride);
            
            public static void SecondaryColorFormatNV(int size, ColorPointerType type, int stride) => GLPointers._glSecondaryColorFormatNV_fnptr(size, (uint)type, stride);
            
            public static void FogCoordFormatNV(All type, int stride) => GLPointers._glFogCoordFormatNV_fnptr((uint)type, stride);
            
            public static void VertexAttribFormatNV(uint index, int size, VertexAttribType type, bool normalized, int stride) => GLPointers._glVertexAttribFormatNV_fnptr(index, size, (uint)type, (byte)(normalized ? 1 : 0), stride);
            
            public static void VertexAttribIFormatNV(uint index, int size, VertexAttribIType type, int stride) => GLPointers._glVertexAttribIFormatNV_fnptr(index, size, (uint)type, stride);
            
            public static void GetIntegerui64i_vNV(All value, uint index, ulong* result) => GLPointers._glGetIntegerui64i_vNV_fnptr((uint)value, index, result);
            
            public static bool AreProgramsResidentNV(int n, int* programs, bool* residences) => GLPointers._glAreProgramsResidentNV_fnptr(n, programs, (byte*)residences) != 0;
            
            public static void BindProgramNV(VertexAttribEnumNV target, int id) => GLPointers._glBindProgramNV_fnptr((uint)target, id);
            
            public static void DeleteProgramsNV(int n, int* programs) => GLPointers._glDeleteProgramsNV_fnptr(n, programs);
            
            public static void ExecuteProgramNV(VertexAttribEnumNV target, uint id, float* parameters) => GLPointers._glExecuteProgramNV_fnptr((uint)target, id, parameters);
            
            public static void GenProgramsNV(int n, int* programs) => GLPointers._glGenProgramsNV_fnptr(n, programs);
            
            public static void GetProgramParameterdvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, double* parameters) => GLPointers._glGetProgramParameterdvNV_fnptr((uint)target, index, (uint)pname, parameters);
            
            public static void GetProgramParameterfvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, float* parameters) => GLPointers._glGetProgramParameterfvNV_fnptr((uint)target, index, (uint)pname, parameters);
            
            public static void GetProgramivNV(int id, VertexAttribEnumNV pname, int* parameters) => GLPointers._glGetProgramivNV_fnptr(id, (uint)pname, parameters);
            
            public static void GetProgramStringNV(int id, VertexAttribEnumNV pname, byte* program) => GLPointers._glGetProgramStringNV_fnptr(id, (uint)pname, program);
            
            public static void GetTrackMatrixivNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV pname, int* parameters) => GLPointers._glGetTrackMatrixivNV_fnptr((uint)target, address, (uint)pname, parameters);
            
            public static void GetVertexAttribdvNV(uint index, VertexAttribEnumNV pname, double* parameters) => GLPointers._glGetVertexAttribdvNV_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribfvNV(uint index, VertexAttribEnumNV pname, float* parameters) => GLPointers._glGetVertexAttribfvNV_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribivNV(uint index, VertexAttribEnumNV pname, int* parameters) => GLPointers._glGetVertexAttribivNV_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribPointervNV(uint index, VertexAttribEnumNV pname, void** pointer) => GLPointers._glGetVertexAttribPointervNV_fnptr(index, (uint)pname, pointer);
            
            public static bool IsProgramNV(int id) => GLPointers._glIsProgramNV_fnptr(id) != 0;
            
            public static void LoadProgramNV(VertexAttribEnumNV target, uint id, int len, byte* program) => GLPointers._glLoadProgramNV_fnptr((uint)target, id, len, program);
            
            public static void ProgramParameter4dNV(VertexAttribEnumNV target, uint index, double x, double y, double z, double w) => GLPointers._glProgramParameter4dNV_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramParameter4dvNV(VertexAttribEnumNV target, uint index, double* v) => GLPointers._glProgramParameter4dvNV_fnptr((uint)target, index, v);
            
            public static void ProgramParameter4fNV(VertexAttribEnumNV target, uint index, float x, float y, float z, float w) => GLPointers._glProgramParameter4fNV_fnptr((uint)target, index, x, y, z, w);
            
            public static void ProgramParameter4fvNV(VertexAttribEnumNV target, uint index, float* v) => GLPointers._glProgramParameter4fvNV_fnptr((uint)target, index, v);
            
            public static void ProgramParameters4dvNV(VertexAttribEnumNV target, uint index, int count, double* v) => GLPointers._glProgramParameters4dvNV_fnptr((uint)target, index, count, v);
            
            public static void ProgramParameters4fvNV(VertexAttribEnumNV target, uint index, int count, float* v) => GLPointers._glProgramParameters4fvNV_fnptr((uint)target, index, count, v);
            
            public static void RequestResidentProgramsNV(int n, int* programs) => GLPointers._glRequestResidentProgramsNV_fnptr(n, programs);
            
            public static void TrackMatrixNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV matrix, VertexAttribEnumNV transform) => GLPointers._glTrackMatrixNV_fnptr((uint)target, address, (uint)matrix, (uint)transform);
            
            public static void VertexAttribPointerNV(uint index, int fsize, VertexAttribEnumNV type, int stride, void* pointer) => GLPointers._glVertexAttribPointerNV_fnptr(index, fsize, (uint)type, stride, pointer);
            
            public static void VertexAttrib1dNV(uint index, double x) => GLPointers._glVertexAttrib1dNV_fnptr(index, x);
            
            public static void VertexAttrib1dvNV(uint index, double* v) => GLPointers._glVertexAttrib1dvNV_fnptr(index, v);
            
            public static void VertexAttrib1fNV(uint index, float x) => GLPointers._glVertexAttrib1fNV_fnptr(index, x);
            
            public static void VertexAttrib1fvNV(uint index, float* v) => GLPointers._glVertexAttrib1fvNV_fnptr(index, v);
            
            public static void VertexAttrib1sNV(uint index, short x) => GLPointers._glVertexAttrib1sNV_fnptr(index, x);
            
            public static void VertexAttrib1svNV(uint index, short* v) => GLPointers._glVertexAttrib1svNV_fnptr(index, v);
            
            public static void VertexAttrib2dNV(uint index, double x, double y) => GLPointers._glVertexAttrib2dNV_fnptr(index, x, y);
            
            public static void VertexAttrib2dvNV(uint index, double* v) => GLPointers._glVertexAttrib2dvNV_fnptr(index, v);
            
            public static void VertexAttrib2fNV(uint index, float x, float y) => GLPointers._glVertexAttrib2fNV_fnptr(index, x, y);
            
            public static void VertexAttrib2fvNV(uint index, float* v) => GLPointers._glVertexAttrib2fvNV_fnptr(index, v);
            
            public static void VertexAttrib2sNV(uint index, short x, short y) => GLPointers._glVertexAttrib2sNV_fnptr(index, x, y);
            
            public static void VertexAttrib2svNV(uint index, short* v) => GLPointers._glVertexAttrib2svNV_fnptr(index, v);
            
            public static void VertexAttrib3dNV(uint index, double x, double y, double z) => GLPointers._glVertexAttrib3dNV_fnptr(index, x, y, z);
            
            public static void VertexAttrib3dvNV(uint index, double* v) => GLPointers._glVertexAttrib3dvNV_fnptr(index, v);
            
            public static void VertexAttrib3fNV(uint index, float x, float y, float z) => GLPointers._glVertexAttrib3fNV_fnptr(index, x, y, z);
            
            public static void VertexAttrib3fvNV(uint index, float* v) => GLPointers._glVertexAttrib3fvNV_fnptr(index, v);
            
            public static void VertexAttrib3sNV(uint index, short x, short y, short z) => GLPointers._glVertexAttrib3sNV_fnptr(index, x, y, z);
            
            public static void VertexAttrib3svNV(uint index, short* v) => GLPointers._glVertexAttrib3svNV_fnptr(index, v);
            
            public static void VertexAttrib4dNV(uint index, double x, double y, double z, double w) => GLPointers._glVertexAttrib4dNV_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4dvNV(uint index, double* v) => GLPointers._glVertexAttrib4dvNV_fnptr(index, v);
            
            public static void VertexAttrib4fNV(uint index, float x, float y, float z, float w) => GLPointers._glVertexAttrib4fNV_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4fvNV(uint index, float* v) => GLPointers._glVertexAttrib4fvNV_fnptr(index, v);
            
            public static void VertexAttrib4sNV(uint index, short x, short y, short z, short w) => GLPointers._glVertexAttrib4sNV_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4svNV(uint index, short* v) => GLPointers._glVertexAttrib4svNV_fnptr(index, v);
            
            public static void VertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w) => GLPointers._glVertexAttrib4ubNV_fnptr(index, x, y, z, w);
            
            public static void VertexAttrib4ubvNV(uint index, byte* v) => GLPointers._glVertexAttrib4ubvNV_fnptr(index, v);
            
            public static void VertexAttribs1dvNV(uint index, int count, double* v) => GLPointers._glVertexAttribs1dvNV_fnptr(index, count, v);
            
            public static void VertexAttribs1fvNV(uint index, int count, float* v) => GLPointers._glVertexAttribs1fvNV_fnptr(index, count, v);
            
            public static void VertexAttribs1svNV(uint index, int count, short* v) => GLPointers._glVertexAttribs1svNV_fnptr(index, count, v);
            
            public static void VertexAttribs2dvNV(uint index, int count, double* v) => GLPointers._glVertexAttribs2dvNV_fnptr(index, count, v);
            
            public static void VertexAttribs2fvNV(uint index, int count, float* v) => GLPointers._glVertexAttribs2fvNV_fnptr(index, count, v);
            
            public static void VertexAttribs2svNV(uint index, int count, short* v) => GLPointers._glVertexAttribs2svNV_fnptr(index, count, v);
            
            public static void VertexAttribs3dvNV(uint index, int count, double* v) => GLPointers._glVertexAttribs3dvNV_fnptr(index, count, v);
            
            public static void VertexAttribs3fvNV(uint index, int count, float* v) => GLPointers._glVertexAttribs3fvNV_fnptr(index, count, v);
            
            public static void VertexAttribs3svNV(uint index, int count, short* v) => GLPointers._glVertexAttribs3svNV_fnptr(index, count, v);
            
            public static void VertexAttribs4dvNV(uint index, int count, double* v) => GLPointers._glVertexAttribs4dvNV_fnptr(index, count, v);
            
            public static void VertexAttribs4fvNV(uint index, int count, float* v) => GLPointers._glVertexAttribs4fvNV_fnptr(index, count, v);
            
            public static void VertexAttribs4svNV(uint index, int count, short* v) => GLPointers._glVertexAttribs4svNV_fnptr(index, count, v);
            
            public static void VertexAttribs4ubvNV(uint index, int count, byte* v) => GLPointers._glVertexAttribs4ubvNV_fnptr(index, count, v);
            
            public static void VertexAttribI1iEXT(uint index, int x) => GLPointers._glVertexAttribI1iEXT_fnptr(index, x);
            
            public static void VertexAttribI2iEXT(uint index, int x, int y) => GLPointers._glVertexAttribI2iEXT_fnptr(index, x, y);
            
            public static void VertexAttribI3iEXT(uint index, int x, int y, int z) => GLPointers._glVertexAttribI3iEXT_fnptr(index, x, y, z);
            
            public static void VertexAttribI4iEXT(uint index, int x, int y, int z, int w) => GLPointers._glVertexAttribI4iEXT_fnptr(index, x, y, z, w);
            
            public static void VertexAttribI1uiEXT(uint index, uint x) => GLPointers._glVertexAttribI1uiEXT_fnptr(index, x);
            
            public static void VertexAttribI2uiEXT(uint index, uint x, uint y) => GLPointers._glVertexAttribI2uiEXT_fnptr(index, x, y);
            
            public static void VertexAttribI3uiEXT(uint index, uint x, uint y, uint z) => GLPointers._glVertexAttribI3uiEXT_fnptr(index, x, y, z);
            
            public static void VertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w) => GLPointers._glVertexAttribI4uiEXT_fnptr(index, x, y, z, w);
            
            public static void VertexAttribI1ivEXT(uint index, int* v) => GLPointers._glVertexAttribI1ivEXT_fnptr(index, v);
            
            public static void VertexAttribI2ivEXT(uint index, int* v) => GLPointers._glVertexAttribI2ivEXT_fnptr(index, v);
            
            public static void VertexAttribI3ivEXT(uint index, int* v) => GLPointers._glVertexAttribI3ivEXT_fnptr(index, v);
            
            public static void VertexAttribI4ivEXT(uint index, int* v) => GLPointers._glVertexAttribI4ivEXT_fnptr(index, v);
            
            public static void VertexAttribI1uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI1uivEXT_fnptr(index, v);
            
            public static void VertexAttribI2uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI2uivEXT_fnptr(index, v);
            
            public static void VertexAttribI3uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI3uivEXT_fnptr(index, v);
            
            public static void VertexAttribI4uivEXT(uint index, uint* v) => GLPointers._glVertexAttribI4uivEXT_fnptr(index, v);
            
            public static void VertexAttribI4bvEXT(uint index, sbyte* v) => GLPointers._glVertexAttribI4bvEXT_fnptr(index, v);
            
            public static void VertexAttribI4svEXT(uint index, short* v) => GLPointers._glVertexAttribI4svEXT_fnptr(index, v);
            
            public static void VertexAttribI4ubvEXT(uint index, byte* v) => GLPointers._glVertexAttribI4ubvEXT_fnptr(index, v);
            
            public static void VertexAttribI4usvEXT(uint index, ushort* v) => GLPointers._glVertexAttribI4usvEXT_fnptr(index, v);
            
            public static void VertexAttribIPointerEXT(uint index, int size, VertexAttribIType type, int stride, void* pointer) => GLPointers._glVertexAttribIPointerEXT_fnptr(index, size, (uint)type, stride, pointer);
            
            public static void GetVertexAttribIivEXT(uint index, VertexAttribEnum pname, int* parameters) => GLPointers._glGetVertexAttribIivEXT_fnptr(index, (uint)pname, parameters);
            
            public static void GetVertexAttribIuivEXT(uint index, VertexAttribEnum pname, uint* parameters) => GLPointers._glGetVertexAttribIuivEXT_fnptr(index, (uint)pname, parameters);
            
            public static void BeginVideoCaptureNV(uint video_capture_slot) => GLPointers._glBeginVideoCaptureNV_fnptr(video_capture_slot);
            
            public static void BindVideoCaptureStreamBufferNV(uint video_capture_slot, uint stream, All frame_region, IntPtr offset) => GLPointers._glBindVideoCaptureStreamBufferNV_fnptr(video_capture_slot, stream, (uint)frame_region, offset);
            
            public static void BindVideoCaptureStreamTextureNV(uint video_capture_slot, uint stream, All frame_region, All target, int texture) => GLPointers._glBindVideoCaptureStreamTextureNV_fnptr(video_capture_slot, stream, (uint)frame_region, (uint)target, texture);
            
            public static void EndVideoCaptureNV(uint video_capture_slot) => GLPointers._glEndVideoCaptureNV_fnptr(video_capture_slot);
            
            public static void GetVideoCaptureivNV(uint video_capture_slot, All pname, int* parameters) => GLPointers._glGetVideoCaptureivNV_fnptr(video_capture_slot, (uint)pname, parameters);
            
            public static void GetVideoCaptureStreamivNV(uint video_capture_slot, uint stream, All pname, int* parameters) => GLPointers._glGetVideoCaptureStreamivNV_fnptr(video_capture_slot, stream, (uint)pname, parameters);
            
            public static void GetVideoCaptureStreamfvNV(uint video_capture_slot, uint stream, All pname, float* parameters) => GLPointers._glGetVideoCaptureStreamfvNV_fnptr(video_capture_slot, stream, (uint)pname, parameters);
            
            public static void GetVideoCaptureStreamdvNV(uint video_capture_slot, uint stream, All pname, double* parameters) => GLPointers._glGetVideoCaptureStreamdvNV_fnptr(video_capture_slot, stream, (uint)pname, parameters);
            
            public static All VideoCaptureNV(uint video_capture_slot, uint* sequence_num, ulong* capture_time) => (All) GLPointers._glVideoCaptureNV_fnptr(video_capture_slot, sequence_num, capture_time);
            
            public static void VideoCaptureStreamParameterivNV(uint video_capture_slot, uint stream, All pname, int* parameters) => GLPointers._glVideoCaptureStreamParameterivNV_fnptr(video_capture_slot, stream, (uint)pname, parameters);
            
            public static void VideoCaptureStreamParameterfvNV(uint video_capture_slot, uint stream, All pname, float* parameters) => GLPointers._glVideoCaptureStreamParameterfvNV_fnptr(video_capture_slot, stream, (uint)pname, parameters);
            
            public static void VideoCaptureStreamParameterdvNV(uint video_capture_slot, uint stream, All pname, double* parameters) => GLPointers._glVideoCaptureStreamParameterdvNV_fnptr(video_capture_slot, stream, (uint)pname, parameters);
            
            public static void ViewportSwizzleNV(uint index, All swizzlex, All swizzley, All swizzlez, All swizzlew) => GLPointers._glViewportSwizzleNV_fnptr(index, (uint)swizzlex, (uint)swizzley, (uint)swizzlez, (uint)swizzlew);
            
        }
        /// <summary>GREMEDY extensions.</summary>
        public static unsafe partial class GREMEDY
        {
            public static void FrameTerminatorGREMEDY() => GLPointers._glFrameTerminatorGREMEDY_fnptr();
            
            public static void StringMarkerGREMEDY(int len, void* str) => GLPointers._glStringMarkerGREMEDY_fnptr(len, str);
            
        }
        /// <summary>HP extensions.</summary>
        public static unsafe partial class HP
        {
            public static void ImageTransformParameteriHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int param) => GLPointers._glImageTransformParameteriHP_fnptr((uint)target, (uint)pname, param);
            
            public static void ImageTransformParameterfHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float param) => GLPointers._glImageTransformParameterfHP_fnptr((uint)target, (uint)pname, param);
            
            public static void ImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int* parameters) => GLPointers._glImageTransformParameterivHP_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float* parameters) => GLPointers._glImageTransformParameterfvHP_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int* parameters) => GLPointers._glGetImageTransformParameterivHP_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float* parameters) => GLPointers._glGetImageTransformParameterfvHP_fnptr((uint)target, (uint)pname, parameters);
            
        }
        /// <summary>IBM extensions.</summary>
        public static unsafe partial class IBM
        {
            public static void MultiModeDrawArraysIBM(PrimitiveType* mode, int* first, int* count, int primcount, int modestride) => GLPointers._glMultiModeDrawArraysIBM_fnptr((uint*)mode, first, count, primcount, modestride);
            
            public static void MultiModeDrawElementsIBM(PrimitiveType* mode, int* count, DrawElementsType type, void** indices, int primcount, int modestride) => GLPointers._glMultiModeDrawElementsIBM_fnptr((uint*)mode, count, (uint)type, indices, primcount, modestride);
            
            public static void FlushStaticDataIBM(All target) => GLPointers._glFlushStaticDataIBM_fnptr((uint)target);
            
            public static void ColorPointerListIBM(int size, ColorPointerType type, int stride, void** pointer, int ptrstride) => GLPointers._glColorPointerListIBM_fnptr(size, (uint)type, stride, pointer, ptrstride);
            
            public static void SecondaryColorPointerListIBM(int size, SecondaryColorPointerTypeIBM type, int stride, void** pointer, int ptrstride) => GLPointers._glSecondaryColorPointerListIBM_fnptr(size, (uint)type, stride, pointer, ptrstride);
            
            public static void EdgeFlagPointerListIBM(int stride, bool** pointer, int ptrstride) => GLPointers._glEdgeFlagPointerListIBM_fnptr(stride, (byte**)pointer, ptrstride);
            
            public static void FogCoordPointerListIBM(FogPointerTypeIBM type, int stride, void** pointer, int ptrstride) => GLPointers._glFogCoordPointerListIBM_fnptr((uint)type, stride, pointer, ptrstride);
            
            public static void IndexPointerListIBM(IndexPointerType type, int stride, void** pointer, int ptrstride) => GLPointers._glIndexPointerListIBM_fnptr((uint)type, stride, pointer, ptrstride);
            
            public static void NormalPointerListIBM(NormalPointerType type, int stride, void** pointer, int ptrstride) => GLPointers._glNormalPointerListIBM_fnptr((uint)type, stride, pointer, ptrstride);
            
            public static void TexCoordPointerListIBM(int size, TexCoordPointerType type, int stride, void** pointer, int ptrstride) => GLPointers._glTexCoordPointerListIBM_fnptr(size, (uint)type, stride, pointer, ptrstride);
            
            public static void VertexPointerListIBM(int size, VertexPointerType type, int stride, void** pointer, int ptrstride) => GLPointers._glVertexPointerListIBM_fnptr(size, (uint)type, stride, pointer, ptrstride);
            
        }
        /// <summary>INGR extensions.</summary>
        public static unsafe partial class INGR
        {
            public static void BlendFuncSeparateINGR(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => GLPointers._glBlendFuncSeparateINGR_fnptr((uint)sfactorRGB, (uint)dfactorRGB, (uint)sfactorAlpha, (uint)dfactorAlpha);
            
        }
        /// <summary>INTEL extensions.</summary>
        public static unsafe partial class INTEL
        {
            public static void ApplyFramebufferAttachmentCMAAINTEL() => GLPointers._glApplyFramebufferAttachmentCMAAINTEL_fnptr();
            
            public static void SyncTextureINTEL(int texture) => GLPointers._glSyncTextureINTEL_fnptr(texture);
            
            public static void UnmapTexture2DINTEL(int texture, int level) => GLPointers._glUnmapTexture2DINTEL_fnptr(texture, level);
            
            public static void* MapTexture2DINTEL(int texture, int level, uint access, int* stride, All* layout) => GLPointers._glMapTexture2DINTEL_fnptr(texture, level, access, stride, (uint*)layout);
            
            public static void VertexPointervINTEL(int size, VertexPointerType type, void** pointer) => GLPointers._glVertexPointervINTEL_fnptr(size, (uint)type, pointer);
            
            public static void NormalPointervINTEL(NormalPointerType type, void** pointer) => GLPointers._glNormalPointervINTEL_fnptr((uint)type, pointer);
            
            public static void ColorPointervINTEL(int size, VertexPointerType type, void** pointer) => GLPointers._glColorPointervINTEL_fnptr(size, (uint)type, pointer);
            
            public static void TexCoordPointervINTEL(int size, VertexPointerType type, void** pointer) => GLPointers._glTexCoordPointervINTEL_fnptr(size, (uint)type, pointer);
            
            public static void BeginPerfQueryINTEL(uint queryHandle) => GLPointers._glBeginPerfQueryINTEL_fnptr(queryHandle);
            
            public static void CreatePerfQueryINTEL(uint queryId, uint* queryHandle) => GLPointers._glCreatePerfQueryINTEL_fnptr(queryId, queryHandle);
            
            public static void DeletePerfQueryINTEL(uint queryHandle) => GLPointers._glDeletePerfQueryINTEL_fnptr(queryHandle);
            
            public static void EndPerfQueryINTEL(uint queryHandle) => GLPointers._glEndPerfQueryINTEL_fnptr(queryHandle);
            
            public static void GetFirstPerfQueryIdINTEL(uint* queryId) => GLPointers._glGetFirstPerfQueryIdINTEL_fnptr(queryId);
            
            public static void GetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId) => GLPointers._glGetNextPerfQueryIdINTEL_fnptr(queryId, nextQueryId);
            
            public static void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue) => GLPointers._glGetPerfCounterInfoINTEL_fnptr(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            
            public static void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten) => GLPointers._glGetPerfQueryDataINTEL_fnptr(queryHandle, flags, dataSize, data, bytesWritten);
            
            public static void GetPerfQueryIdByNameINTEL(byte* queryName, uint* queryId) => GLPointers._glGetPerfQueryIdByNameINTEL_fnptr(queryName, queryId);
            
            public static void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, PerformanceQueryCapsMaskINTEL* capsMask) => GLPointers._glGetPerfQueryInfoINTEL_fnptr(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, (uint*)capsMask);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            public static void BlendBarrierKHR() => GLPointers._glBlendBarrierKHR_fnptr();
            
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
            
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
            
            public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
            
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
            
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
            
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
            
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControlKHR_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsertKHR_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallbackKHR_fnptr(callback, userParam);
            
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLogKHR_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroupKHR_fnptr((uint)source, id, length, message);
            
            public static void PopDebugGroupKHR() => GLPointers._glPopDebugGroupKHR_fnptr();
            
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabelKHR_fnptr((uint)identifier, name, length, label);
            
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelKHR_fnptr((uint)identifier, name, bufSize, length, label);
            
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabelKHR_fnptr(ptr, length, label);
            
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            
            public static void GetPointervKHR(All pname, void** parameters) => GLPointers._glGetPointervKHR_fnptr((uint)pname, parameters);
            
            public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
            
            public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
            
            public static GraphicsResetStatus GetGraphicsResetStatusKHR() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusKHR_fnptr();
            
            public static void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsKHR_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            public static void GetnUniformfvKHR(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvKHR_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformivKHR(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivKHR_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformuivKHR(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuivKHR_fnptr(program, location, bufSize, parameters);
            
            public static void MaxShaderCompilerThreadsKHR(uint count) => GLPointers._glMaxShaderCompilerThreadsKHR_fnptr(count);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            public static void FramebufferParameteriMESA(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteriMESA_fnptr((uint)target, (uint)pname, param);
            
            public static void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameterivMESA_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ResizeBuffersMESA() => GLPointers._glResizeBuffersMESA_fnptr();
            
            public static void WindowPos2dMESA(double x, double y) => GLPointers._glWindowPos2dMESA_fnptr(x, y);
            
            public static void WindowPos2dvMESA(double* v) => GLPointers._glWindowPos2dvMESA_fnptr(v);
            
            public static void WindowPos2fMESA(float x, float y) => GLPointers._glWindowPos2fMESA_fnptr(x, y);
            
            public static void WindowPos2fvMESA(float* v) => GLPointers._glWindowPos2fvMESA_fnptr(v);
            
            public static void WindowPos2iMESA(int x, int y) => GLPointers._glWindowPos2iMESA_fnptr(x, y);
            
            public static void WindowPos2ivMESA(int* v) => GLPointers._glWindowPos2ivMESA_fnptr(v);
            
            public static void WindowPos2sMESA(short x, short y) => GLPointers._glWindowPos2sMESA_fnptr(x, y);
            
            public static void WindowPos2svMESA(short* v) => GLPointers._glWindowPos2svMESA_fnptr(v);
            
            public static void WindowPos3dMESA(double x, double y, double z) => GLPointers._glWindowPos3dMESA_fnptr(x, y, z);
            
            public static void WindowPos3dvMESA(double* v) => GLPointers._glWindowPos3dvMESA_fnptr(v);
            
            public static void WindowPos3fMESA(float x, float y, float z) => GLPointers._glWindowPos3fMESA_fnptr(x, y, z);
            
            public static void WindowPos3fvMESA(float* v) => GLPointers._glWindowPos3fvMESA_fnptr(v);
            
            public static void WindowPos3iMESA(int x, int y, int z) => GLPointers._glWindowPos3iMESA_fnptr(x, y, z);
            
            public static void WindowPos3ivMESA(int* v) => GLPointers._glWindowPos3ivMESA_fnptr(v);
            
            public static void WindowPos3sMESA(short x, short y, short z) => GLPointers._glWindowPos3sMESA_fnptr(x, y, z);
            
            public static void WindowPos3svMESA(short* v) => GLPointers._glWindowPos3svMESA_fnptr(v);
            
            public static void WindowPos4dMESA(double x, double y, double z, double w) => GLPointers._glWindowPos4dMESA_fnptr(x, y, z, w);
            
            public static void WindowPos4dvMESA(double* v) => GLPointers._glWindowPos4dvMESA_fnptr(v);
            
            public static void WindowPos4fMESA(float x, float y, float z, float w) => GLPointers._glWindowPos4fMESA_fnptr(x, y, z, w);
            
            public static void WindowPos4fvMESA(float* v) => GLPointers._glWindowPos4fvMESA_fnptr(v);
            
            public static void WindowPos4iMESA(int x, int y, int z, int w) => GLPointers._glWindowPos4iMESA_fnptr(x, y, z, w);
            
            public static void WindowPos4ivMESA(int* v) => GLPointers._glWindowPos4ivMESA_fnptr(v);
            
            public static void WindowPos4sMESA(short x, short y, short z, short w) => GLPointers._glWindowPos4sMESA_fnptr(x, y, z, w);
            
            public static void WindowPos4svMESA(short* v) => GLPointers._glWindowPos4svMESA_fnptr(v);
            
        }
        /// <summary>NVX extensions.</summary>
        public static unsafe partial class NVX
        {
            public static void BeginConditionalRenderNVX(uint id) => GLPointers._glBeginConditionalRenderNVX_fnptr(id);
            
            public static void EndConditionalRenderNVX() => GLPointers._glEndConditionalRenderNVX_fnptr();
            
            public static void LGPUNamedBufferSubDataNVX(uint gpuMask, int buffer, IntPtr offset, nint size, void* data) => GLPointers._glLGPUNamedBufferSubDataNVX_fnptr(gpuMask, buffer, offset, size, data);
            
            public static void LGPUCopyImageSubDataNVX(uint sourceGpu, uint destinationGpuMask, uint srcName, All srcTarget, int srcLevel, int srcX, int srxY, int srcZ, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => GLPointers._glLGPUCopyImageSubDataNVX_fnptr(sourceGpu, destinationGpuMask, srcName, (uint)srcTarget, srcLevel, srcX, srxY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            public static void LGPUInterlockNVX() => GLPointers._glLGPUInterlockNVX_fnptr();
            
            public static void UploadGpuMaskNVX(uint mask) => GLPointers._glUploadGpuMaskNVX_fnptr(mask);
            
            public static void MulticastViewportArrayvNVX(uint gpu, uint first, int count, float* v) => GLPointers._glMulticastViewportArrayvNVX_fnptr(gpu, first, count, v);
            
            public static void MulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff) => GLPointers._glMulticastViewportPositionWScaleNVX_fnptr(gpu, index, xcoeff, ycoeff);
            
            public static void MulticastScissorArrayvNVX(uint gpu, uint first, int count, int* v) => GLPointers._glMulticastScissorArrayvNVX_fnptr(gpu, first, count, v);
            
            public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, int readBuffer, int writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray) => GLPointers._glAsyncCopyBufferSubDataNVX_fnptr(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
            
            public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray) => GLPointers._glAsyncCopyImageSubDataNVX_fnptr(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
            
            public static uint CreateProgressFenceNVX() => GLPointers._glCreateProgressFenceNVX_fnptr();
            
            public static void SignalSemaphoreui64NVX(uint signalGpu, int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray) => GLPointers._glSignalSemaphoreui64NVX_fnptr(signalGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
            
            public static void WaitSemaphoreui64NVX(uint waitGpu, int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray) => GLPointers._glWaitSemaphoreui64NVX_fnptr(waitGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
            
            public static void ClientWaitSemaphoreui64NVX(int fenceObjectCount, uint* semaphoreArray, ulong* fenceValueArray) => GLPointers._glClientWaitSemaphoreui64NVX_fnptr(fenceObjectCount, semaphoreArray, fenceValueArray);
            
        }
        /// <summary>OES extensions.</summary>
        public static unsafe partial class OES
        {
            public static void MultiTexCoord1bOES(TextureUnit texture, sbyte s) => GLPointers._glMultiTexCoord1bOES_fnptr((uint)texture, s);
            
            public static void MultiTexCoord1bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord1bvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t) => GLPointers._glMultiTexCoord2bOES_fnptr((uint)texture, s, t);
            
            public static void MultiTexCoord2bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord2bvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r) => GLPointers._glMultiTexCoord3bOES_fnptr((uint)texture, s, t, r);
            
            public static void MultiTexCoord3bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord3bvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._glMultiTexCoord4bOES_fnptr((uint)texture, s, t, r, q);
            
            public static void MultiTexCoord4bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord4bvOES_fnptr((uint)texture, coords);
            
            public static void TexCoord1bOES(sbyte s) => GLPointers._glTexCoord1bOES_fnptr(s);
            
            public static void TexCoord1bvOES(sbyte* coords) => GLPointers._glTexCoord1bvOES_fnptr(coords);
            
            public static void TexCoord2bOES(sbyte s, sbyte t) => GLPointers._glTexCoord2bOES_fnptr(s, t);
            
            public static void TexCoord2bvOES(sbyte* coords) => GLPointers._glTexCoord2bvOES_fnptr(coords);
            
            public static void TexCoord3bOES(sbyte s, sbyte t, sbyte r) => GLPointers._glTexCoord3bOES_fnptr(s, t, r);
            
            public static void TexCoord3bvOES(sbyte* coords) => GLPointers._glTexCoord3bvOES_fnptr(coords);
            
            public static void TexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._glTexCoord4bOES_fnptr(s, t, r, q);
            
            public static void TexCoord4bvOES(sbyte* coords) => GLPointers._glTexCoord4bvOES_fnptr(coords);
            
            public static void Vertex2bOES(sbyte x, sbyte y) => GLPointers._glVertex2bOES_fnptr(x, y);
            
            public static void Vertex2bvOES(sbyte* coords) => GLPointers._glVertex2bvOES_fnptr(coords);
            
            public static void Vertex3bOES(sbyte x, sbyte y, sbyte z) => GLPointers._glVertex3bOES_fnptr(x, y, z);
            
            public static void Vertex3bvOES(sbyte* coords) => GLPointers._glVertex3bvOES_fnptr(coords);
            
            public static void Vertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w) => GLPointers._glVertex4bOES_fnptr(x, y, z, w);
            
            public static void Vertex4bvOES(sbyte* coords) => GLPointers._glVertex4bvOES_fnptr(coords);
            
            public static void AlphaFuncxOES(AlphaFunction func, int reference) => GLPointers._glAlphaFuncxOES_fnptr((uint)func, reference);
            
            public static void ClearColorxOES(int red, int green, int blue, int alpha) => GLPointers._glClearColorxOES_fnptr(red, green, blue, alpha);
            
            public static void ClearDepthxOES(int depth) => GLPointers._glClearDepthxOES_fnptr(depth);
            
            public static void ClipPlanexOES(ClipPlaneName plane, int* equation) => GLPointers._glClipPlanexOES_fnptr((uint)plane, equation);
            
            public static void Color4xOES(int red, int green, int blue, int alpha) => GLPointers._glColor4xOES_fnptr(red, green, blue, alpha);
            
            public static void DepthRangexOES(int n, int f) => GLPointers._glDepthRangexOES_fnptr(n, f);
            
            public static void FogxOES(FogPName pname, int param) => GLPointers._glFogxOES_fnptr((uint)pname, param);
            
            public static void FogxvOES(FogPName pname, int* param) => GLPointers._glFogxvOES_fnptr((uint)pname, param);
            
            public static void FrustumxOES(int l, int r, int b, int t, int n, int f) => GLPointers._glFrustumxOES_fnptr(l, r, b, t, n, f);
            
            public static void GetClipPlanexOES(ClipPlaneName plane, int* equation) => GLPointers._glGetClipPlanexOES_fnptr((uint)plane, equation);
            
            public static void GetFixedvOES(GetPName pname, int* parameters) => GLPointers._glGetFixedvOES_fnptr((uint)pname, parameters);
            
            public static void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void LightModelxOES(LightModelParameter pname, int param) => GLPointers._glLightModelxOES_fnptr((uint)pname, param);
            
            public static void LightModelxvOES(LightModelParameter pname, int* param) => GLPointers._glLightModelxvOES_fnptr((uint)pname, param);
            
            public static void LightxOES(LightName light, LightParameter pname, int param) => GLPointers._glLightxOES_fnptr((uint)light, (uint)pname, param);
            
            public static void LightxvOES(LightName light, LightParameter pname, int* parameters) => GLPointers._glLightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            public static void LineWidthxOES(int width) => GLPointers._glLineWidthxOES_fnptr(width);
            
            public static void LoadMatrixxOES(int* m) => GLPointers._glLoadMatrixxOES_fnptr(m);
            
            public static void MaterialxOES(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glMaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            public static void MaterialxvOES(TriangleFace face, MaterialParameter pname, int* param) => GLPointers._glMaterialxvOES_fnptr((uint)face, (uint)pname, param);
            
            public static void MultMatrixxOES(int* m) => GLPointers._glMultMatrixxOES_fnptr(m);
            
            public static void MultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q) => GLPointers._glMultiTexCoord4xOES_fnptr((uint)texture, s, t, r, q);
            
            public static void Normal3xOES(int nx, int ny, int nz) => GLPointers._glNormal3xOES_fnptr(nx, ny, nz);
            
            public static void OrthoxOES(int l, int r, int b, int t, int n, int f) => GLPointers._glOrthoxOES_fnptr(l, r, b, t, n, f);
            
            public static void PointParameterxvOES(PointParameterNameARB pname, int* parameters) => GLPointers._glPointParameterxvOES_fnptr((uint)pname, parameters);
            
            public static void PointSizexOES(int size) => GLPointers._glPointSizexOES_fnptr(size);
            
            public static void PolygonOffsetxOES(int factor, int units) => GLPointers._glPolygonOffsetxOES_fnptr(factor, units);
            
            public static void RotatexOES(int angle, int x, int y, int z) => GLPointers._glRotatexOES_fnptr(angle, x, y, z);
            
            public static void ScalexOES(int x, int y, int z) => GLPointers._glScalexOES_fnptr(x, y, z);
            
            public static void TexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvxOES_fnptr((uint)target, (uint)pname, param);
            
            public static void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TexParameterxOES(TextureTarget target, GetTextureParameter pname, int param) => GLPointers._glTexParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            public static void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glTexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TranslatexOES(int x, int y, int z) => GLPointers._glTranslatexOES_fnptr(x, y, z);
            
            public static void GetLightxvOES(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            public static void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glGetMaterialxvOES_fnptr((uint)face, (uint)pname, parameters);
            
            public static void PointParameterxOES(PointParameterNameARB pname, int param) => GLPointers._glPointParameterxOES_fnptr((uint)pname, param);
            
            public static void SampleCoveragexOES(int value, bool invert) => GLPointers._glSampleCoveragexOES_fnptr(value, (byte)(invert ? 1 : 0));
            
            public static void AccumxOES(All op, int value) => GLPointers._glAccumxOES_fnptr((uint)op, value);
            
            public static void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) => GLPointers._glBitmapxOES_fnptr(width, height, xorig, yorig, xmove, ymove, bitmap);
            
            public static void BlendColorxOES(int red, int green, int blue, int alpha) => GLPointers._glBlendColorxOES_fnptr(red, green, blue, alpha);
            
            public static void ClearAccumxOES(int red, int green, int blue, int alpha) => GLPointers._glClearAccumxOES_fnptr(red, green, blue, alpha);
            
            public static void Color3xOES(int red, int green, int blue) => GLPointers._glColor3xOES_fnptr(red, green, blue);
            
            public static void Color3xvOES(int* components) => GLPointers._glColor3xvOES_fnptr(components);
            
            public static void Color4xvOES(int* components) => GLPointers._glColor4xvOES_fnptr(components);
            
            public static void ConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameter pname, int param) => GLPointers._glConvolutionParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            public static void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameter pname, int* parameters) => GLPointers._glConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void EvalCoord1xOES(int u) => GLPointers._glEvalCoord1xOES_fnptr(u);
            
            public static void EvalCoord1xvOES(int* coords) => GLPointers._glEvalCoord1xvOES_fnptr(coords);
            
            public static void EvalCoord2xOES(int u, int v) => GLPointers._glEvalCoord2xOES_fnptr(u, v);
            
            public static void EvalCoord2xvOES(int* coords) => GLPointers._glEvalCoord2xvOES_fnptr(coords);
            
            public static void FeedbackBufferxOES(int n, All type, int* buffer) => GLPointers._glFeedbackBufferxOES_fnptr(n, (uint)type, buffer);
            
            public static void GetConvolutionParameterxvOES(All target, All pname, int* parameters) => GLPointers._glGetConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => GLPointers._glGetHistogramParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetLightxOES(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxOES_fnptr((uint)light, (uint)pname, parameters);
            
            public static void GetMapxvOES(MapTarget target, GetMapQuery query, int* v) => GLPointers._glGetMapxvOES_fnptr((uint)target, (uint)query, v);
            
            public static void GetMaterialxOES(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glGetMaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            public static void GetPixelMapxv(PixelMap map, int size, int* values) => GLPointers._glGetPixelMapxv_fnptr((uint)map, size, values);
            
            public static void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glGetTexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexLevelParameterxvOES_fnptr((uint)target, level, (uint)pname, parameters);
            
            public static void IndexxOES(int component) => GLPointers._glIndexxOES_fnptr(component);
            
            public static void IndexxvOES(int* component) => GLPointers._glIndexxvOES_fnptr(component);
            
            public static void LoadTransposeMatrixxOES(int* m) => GLPointers._glLoadTransposeMatrixxOES_fnptr(m);
            
            public static void Map1xOES(MapTarget target, int u1, int u2, int stride, int order, int points) => GLPointers._glMap1xOES_fnptr((uint)target, u1, u2, stride, order, points);
            
            public static void Map2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => GLPointers._glMap2xOES_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            
            public static void MapGrid1xOES(int n, int u1, int u2) => GLPointers._glMapGrid1xOES_fnptr(n, u1, u2);
            
            public static void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) => GLPointers._glMapGrid2xOES_fnptr(n, u1, u2, v1, v2);
            
            public static void MultTransposeMatrixxOES(int* m) => GLPointers._glMultTransposeMatrixxOES_fnptr(m);
            
            public static void MultiTexCoord1xOES(TextureUnit texture, int s) => GLPointers._glMultiTexCoord1xOES_fnptr((uint)texture, s);
            
            public static void MultiTexCoord1xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord1xvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord2xOES(TextureUnit texture, int s, int t) => GLPointers._glMultiTexCoord2xOES_fnptr((uint)texture, s, t);
            
            public static void MultiTexCoord2xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord2xvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord3xOES(TextureUnit texture, int s, int t, int r) => GLPointers._glMultiTexCoord3xOES_fnptr((uint)texture, s, t, r);
            
            public static void MultiTexCoord3xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord3xvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord4xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord4xvOES_fnptr((uint)texture, coords);
            
            public static void Normal3xvOES(int* coords) => GLPointers._glNormal3xvOES_fnptr(coords);
            
            public static void PassThroughxOES(int token) => GLPointers._glPassThroughxOES_fnptr(token);
            
            public static void PixelMapx(PixelMap map, int size, int* values) => GLPointers._glPixelMapx_fnptr((uint)map, size, values);
            
            public static void PixelStorex(PixelStoreParameter pname, int param) => GLPointers._glPixelStorex_fnptr((uint)pname, param);
            
            public static void PixelTransferxOES(PixelTransferParameter pname, int param) => GLPointers._glPixelTransferxOES_fnptr((uint)pname, param);
            
            public static void PixelZoomxOES(int xfactor, int yfactor) => GLPointers._glPixelZoomxOES_fnptr(xfactor, yfactor);
            
            public static void PrioritizeTexturesxOES(int n, int* textures, int* priorities) => GLPointers._glPrioritizeTexturesxOES_fnptr(n, textures, priorities);
            
            public static void RasterPos2xOES(int x, int y) => GLPointers._glRasterPos2xOES_fnptr(x, y);
            
            public static void RasterPos2xvOES(int* coords) => GLPointers._glRasterPos2xvOES_fnptr(coords);
            
            public static void RasterPos3xOES(int x, int y, int z) => GLPointers._glRasterPos3xOES_fnptr(x, y, z);
            
            public static void RasterPos3xvOES(int* coords) => GLPointers._glRasterPos3xvOES_fnptr(coords);
            
            public static void RasterPos4xOES(int x, int y, int z, int w) => GLPointers._glRasterPos4xOES_fnptr(x, y, z, w);
            
            public static void RasterPos4xvOES(int* coords) => GLPointers._glRasterPos4xvOES_fnptr(coords);
            
            public static void RectxOES(int x1, int y1, int x2, int y2) => GLPointers._glRectxOES_fnptr(x1, y1, x2, y2);
            
            public static void RectxvOES(int* v1, int* v2) => GLPointers._glRectxvOES_fnptr(v1, v2);
            
            public static void TexCoord1xOES(int s) => GLPointers._glTexCoord1xOES_fnptr(s);
            
            public static void TexCoord1xvOES(int* coords) => GLPointers._glTexCoord1xvOES_fnptr(coords);
            
            public static void TexCoord2xOES(int s, int t) => GLPointers._glTexCoord2xOES_fnptr(s, t);
            
            public static void TexCoord2xvOES(int* coords) => GLPointers._glTexCoord2xvOES_fnptr(coords);
            
            public static void TexCoord3xOES(int s, int t, int r) => GLPointers._glTexCoord3xOES_fnptr(s, t, r);
            
            public static void TexCoord3xvOES(int* coords) => GLPointers._glTexCoord3xvOES_fnptr(coords);
            
            public static void TexCoord4xOES(int s, int t, int r, int q) => GLPointers._glTexCoord4xOES_fnptr(s, t, r, q);
            
            public static void TexCoord4xvOES(int* coords) => GLPointers._glTexCoord4xvOES_fnptr(coords);
            
            public static void TexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._glTexGenxOES_fnptr((uint)coord, (uint)pname, param);
            
            public static void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glTexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void Vertex2xOES(int x) => GLPointers._glVertex2xOES_fnptr(x);
            
            public static void Vertex2xvOES(int* coords) => GLPointers._glVertex2xvOES_fnptr(coords);
            
            public static void Vertex3xOES(int x, int y) => GLPointers._glVertex3xOES_fnptr(x, y);
            
            public static void Vertex3xvOES(int* coords) => GLPointers._glVertex3xvOES_fnptr(coords);
            
            public static void Vertex4xOES(int x, int y, int z) => GLPointers._glVertex4xOES_fnptr(x, y, z);
            
            public static void Vertex4xvOES(int* coords) => GLPointers._glVertex4xvOES_fnptr(coords);
            
            public static uint QueryMatrixxOES(int* mantissa, int* exponent) => GLPointers._glQueryMatrixxOES_fnptr(mantissa, exponent);
            
            public static void ClearDepthfOES(float depth) => GLPointers._glClearDepthfOES_fnptr(depth);
            
            public static void ClipPlanefOES(ClipPlaneName plane, float* equation) => GLPointers._glClipPlanefOES_fnptr((uint)plane, equation);
            
            public static void DepthRangefOES(float n, float f) => GLPointers._glDepthRangefOES_fnptr(n, f);
            
            public static void FrustumfOES(float l, float r, float b, float t, float n, float f) => GLPointers._glFrustumfOES_fnptr(l, r, b, t, n, f);
            
            public static void GetClipPlanefOES(ClipPlaneName plane, float* equation) => GLPointers._glGetClipPlanefOES_fnptr((uint)plane, equation);
            
            public static void OrthofOES(float l, float r, float b, float t, float n, float f) => GLPointers._glOrthofOES_fnptr(l, r, b, t, n, f);
            
        }
        /// <summary>OVR extensions.</summary>
        public static unsafe partial class OVR
        {
            public static void FramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int baseViewIndex, int numViews) => GLPointers._glFramebufferTextureMultiviewOVR_fnptr((uint)target, (uint)attachment, texture, level, baseViewIndex, numViews);
            
        }
        /// <summary>PGI extensions.</summary>
        public static unsafe partial class PGI
        {
            public static void HintPGI(HintTargetPGI target, VertexHintsMaskPGI mode) => GLPointers._glHintPGI_fnptr((uint)target, (int)mode);
            
        }
        /// <summary>SGIS extensions.</summary>
        public static unsafe partial class SGIS
        {
            public static void DetailTexFuncSGIS(TextureTarget target, int n, float* points) => GLPointers._glDetailTexFuncSGIS_fnptr((uint)target, n, points);
            
            public static void GetDetailTexFuncSGIS(TextureTarget target, float* points) => GLPointers._glGetDetailTexFuncSGIS_fnptr((uint)target, points);
            
            public static void FogFuncSGIS(int n, float* points) => GLPointers._glFogFuncSGIS_fnptr(n, points);
            
            public static void GetFogFuncSGIS(float* points) => GLPointers._glGetFogFuncSGIS_fnptr(points);
            
            public static void SampleMaskSGIS(float value, bool invert) => GLPointers._glSampleMaskSGIS_fnptr(value, (byte)(invert ? 1 : 0));
            
            public static void SamplePatternSGIS(SamplePatternSGIS pattern) => GLPointers._glSamplePatternSGIS_fnptr((uint)pattern);
            
            public static void PixelTexGenParameteriSGIS(PixelTexGenParameterNameSGIS pname, int param) => GLPointers._glPixelTexGenParameteriSGIS_fnptr((uint)pname, param);
            
            public static void PixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int* parameters) => GLPointers._glPixelTexGenParameterivSGIS_fnptr((uint)pname, parameters);
            
            public static void PixelTexGenParameterfSGIS(PixelTexGenParameterNameSGIS pname, float param) => GLPointers._glPixelTexGenParameterfSGIS_fnptr((uint)pname, param);
            
            public static void PixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float* parameters) => GLPointers._glPixelTexGenParameterfvSGIS_fnptr((uint)pname, parameters);
            
            public static void GetPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int* parameters) => GLPointers._glGetPixelTexGenParameterivSGIS_fnptr((uint)pname, parameters);
            
            public static void GetPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float* parameters) => GLPointers._glGetPixelTexGenParameterfvSGIS_fnptr((uint)pname, parameters);
            
            public static void PointParameterfSGIS(PointParameterNameARB pname, float param) => GLPointers._glPointParameterfSGIS_fnptr((uint)pname, param);
            
            public static void PointParameterfvSGIS(PointParameterNameARB pname, float* parameters) => GLPointers._glPointParameterfvSGIS_fnptr((uint)pname, parameters);
            
            public static void SharpenTexFuncSGIS(TextureTarget target, int n, float* points) => GLPointers._glSharpenTexFuncSGIS_fnptr((uint)target, n, points);
            
            public static void GetSharpenTexFuncSGIS(TextureTarget target, float* points) => GLPointers._glGetSharpenTexFuncSGIS_fnptr((uint)target, points);
            
            public static void TexImage4DSGIS(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int size4d, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage4DSGIS_fnptr((uint)target, level, (uint)internalformat, width, height, depth, size4d, border, (uint)format, (uint)type, pixels);
            
            public static void TexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage4DSGIS_fnptr((uint)target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, (uint)format, (uint)type, pixels);
            
            public static void TextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha) => GLPointers._glTextureColorMaskSGIS_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
            
            public static void GetTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, float* weights) => GLPointers._glGetTexFilterFuncSGIS_fnptr((uint)target, (uint)filter, weights);
            
            public static void TexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, int n, float* weights) => GLPointers._glTexFilterFuncSGIS_fnptr((uint)target, (uint)filter, n, weights);
            
        }
        /// <summary>SGIX extensions.</summary>
        public static unsafe partial class SGIX
        {
            public static void AsyncMarkerSGIX(uint marker) => GLPointers._glAsyncMarkerSGIX_fnptr(marker);
            
            public static int FinishAsyncSGIX(uint* markerp) => GLPointers._glFinishAsyncSGIX_fnptr(markerp);
            
            public static int PollAsyncSGIX(uint* markerp) => GLPointers._glPollAsyncSGIX_fnptr(markerp);
            
            public static uint GenAsyncMarkersSGIX(int range) => GLPointers._glGenAsyncMarkersSGIX_fnptr(range);
            
            public static void DeleteAsyncMarkersSGIX(uint marker, int range) => GLPointers._glDeleteAsyncMarkersSGIX_fnptr(marker, range);
            
            public static bool IsAsyncMarkerSGIX(uint marker) => GLPointers._glIsAsyncMarkerSGIX_fnptr(marker) != 0;
            
            public static void FlushRasterSGIX() => GLPointers._glFlushRasterSGIX_fnptr();
            
            public static void FragmentColorMaterialSGIX(TriangleFace face, MaterialParameter mode) => GLPointers._glFragmentColorMaterialSGIX_fnptr((uint)face, (uint)mode);
            
            public static void FragmentLightfSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float param) => GLPointers._glFragmentLightfSGIX_fnptr((uint)light, (uint)pname, param);
            
            public static void FragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float* parameters) => GLPointers._glFragmentLightfvSGIX_fnptr((uint)light, (uint)pname, parameters);
            
            public static void FragmentLightiSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int param) => GLPointers._glFragmentLightiSGIX_fnptr((uint)light, (uint)pname, param);
            
            public static void FragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int* parameters) => GLPointers._glFragmentLightivSGIX_fnptr((uint)light, (uint)pname, parameters);
            
            public static void FragmentLightModelfSGIX(FragmentLightModelParameterSGIX pname, float param) => GLPointers._glFragmentLightModelfSGIX_fnptr((uint)pname, param);
            
            public static void FragmentLightModelfvSGIX(FragmentLightModelParameterSGIX pname, float* parameters) => GLPointers._glFragmentLightModelfvSGIX_fnptr((uint)pname, parameters);
            
            public static void FragmentLightModeliSGIX(FragmentLightModelParameterSGIX pname, int param) => GLPointers._glFragmentLightModeliSGIX_fnptr((uint)pname, param);
            
            public static void FragmentLightModelivSGIX(FragmentLightModelParameterSGIX pname, int* parameters) => GLPointers._glFragmentLightModelivSGIX_fnptr((uint)pname, parameters);
            
            public static void FragmentMaterialfSGIX(TriangleFace face, MaterialParameter pname, float param) => GLPointers._glFragmentMaterialfSGIX_fnptr((uint)face, (uint)pname, param);
            
            public static void FragmentMaterialfvSGIX(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glFragmentMaterialfvSGIX_fnptr((uint)face, (uint)pname, parameters);
            
            public static void FragmentMaterialiSGIX(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glFragmentMaterialiSGIX_fnptr((uint)face, (uint)pname, param);
            
            public static void FragmentMaterialivSGIX(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glFragmentMaterialivSGIX_fnptr((uint)face, (uint)pname, parameters);
            
            public static void GetFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float* parameters) => GLPointers._glGetFragmentLightfvSGIX_fnptr((uint)light, (uint)pname, parameters);
            
            public static void GetFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int* parameters) => GLPointers._glGetFragmentLightivSGIX_fnptr((uint)light, (uint)pname, parameters);
            
            public static void GetFragmentMaterialfvSGIX(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glGetFragmentMaterialfvSGIX_fnptr((uint)face, (uint)pname, parameters);
            
            public static void GetFragmentMaterialivSGIX(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glGetFragmentMaterialivSGIX_fnptr((uint)face, (uint)pname, parameters);
            
            public static void LightEnviSGIX(LightEnvParameterSGIX pname, LightEnvModeSGIX param) => GLPointers._glLightEnviSGIX_fnptr((uint)pname, (int)param);
            
            public static void FrameZoomSGIX(int factor) => GLPointers._glFrameZoomSGIX_fnptr(factor);
            
            public static void IglooInterfaceSGIX(All pname, void* parameters) => GLPointers._glIglooInterfaceSGIX_fnptr((uint)pname, parameters);
            
            public static int GetInstrumentsSGIX() => GLPointers._glGetInstrumentsSGIX_fnptr();
            
            public static void InstrumentsBufferSGIX(int size, int* buffer) => GLPointers._glInstrumentsBufferSGIX_fnptr(size, buffer);
            
            public static int PollInstrumentsSGIX(int* marker_p) => GLPointers._glPollInstrumentsSGIX_fnptr(marker_p);
            
            public static void ReadInstrumentsSGIX(int marker) => GLPointers._glReadInstrumentsSGIX_fnptr(marker);
            
            public static void StartInstrumentsSGIX() => GLPointers._glStartInstrumentsSGIX_fnptr();
            
            public static void StopInstrumentsSGIX(int marker) => GLPointers._glStopInstrumentsSGIX_fnptr(marker);
            
            public static void GetListParameterfvSGIX(int list, ListParameterName pname, float* parameters) => GLPointers._glGetListParameterfvSGIX_fnptr(list, (uint)pname, parameters);
            
            public static void GetListParameterivSGIX(int list, ListParameterName pname, int* parameters) => GLPointers._glGetListParameterivSGIX_fnptr(list, (uint)pname, parameters);
            
            public static void ListParameterfSGIX(int list, ListParameterName pname, float param) => GLPointers._glListParameterfSGIX_fnptr(list, (uint)pname, param);
            
            public static void ListParameterfvSGIX(int list, ListParameterName pname, float* parameters) => GLPointers._glListParameterfvSGIX_fnptr(list, (uint)pname, parameters);
            
            public static void ListParameteriSGIX(int list, ListParameterName pname, int param) => GLPointers._glListParameteriSGIX_fnptr(list, (uint)pname, param);
            
            public static void ListParameterivSGIX(int list, ListParameterName pname, int* parameters) => GLPointers._glListParameterivSGIX_fnptr(list, (uint)pname, parameters);
            
            public static void PixelTexGenSGIX(PixelTexGenModeSGIX mode) => GLPointers._glPixelTexGenSGIX_fnptr((uint)mode);
            
            public static void DeformationMap3dSGIX(FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points) => GLPointers._glDeformationMap3dSGIX_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
            
            public static void DeformationMap3fSGIX(FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points) => GLPointers._glDeformationMap3fSGIX_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
            
            public static void DeformSGIX(FfdMaskSGIX mask) => GLPointers._glDeformSGIX_fnptr((uint)mask);
            
            public static void LoadIdentityDeformationMapSGIX(FfdMaskSGIX mask) => GLPointers._glLoadIdentityDeformationMapSGIX_fnptr((uint)mask);
            
            public static void ReferencePlaneSGIX(double* equation) => GLPointers._glReferencePlaneSGIX_fnptr(equation);
            
            public static void SpriteParameterfSGIX(SpriteParameterNameSGIX pname, float param) => GLPointers._glSpriteParameterfSGIX_fnptr((uint)pname, param);
            
            public static void SpriteParameterfvSGIX(SpriteParameterNameSGIX pname, float* parameters) => GLPointers._glSpriteParameterfvSGIX_fnptr((uint)pname, parameters);
            
            public static void SpriteParameteriSGIX(SpriteParameterNameSGIX pname, SpriteModeSGIX param) => GLPointers._glSpriteParameteriSGIX_fnptr((uint)pname, (int)param);
            
            public static void SpriteParameterivSGIX(SpriteParameterNameSGIX pname, SpriteModeSGIX* parameters) => GLPointers._glSpriteParameterivSGIX_fnptr((uint)pname, (int*)parameters);
            
            public static void TagSampleBufferSGIX() => GLPointers._glTagSampleBufferSGIX_fnptr();
            
        }
        /// <summary>SGI extensions.</summary>
        public static unsafe partial class SGI
        {
            public static void ColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int width, PixelFormat format, PixelType type, void* table) => GLPointers._glColorTableSGI_fnptr((uint)target, (uint)internalformat, width, (uint)format, (uint)type, table);
            
            public static void ColorTableParameterfvSGI(ColorTableTargetSGI target, ColorTableParameterPName pname, float* parameters) => GLPointers._glColorTableParameterfvSGI_fnptr((uint)target, (uint)pname, parameters);
            
            public static void ColorTableParameterivSGI(ColorTableTargetSGI target, ColorTableParameterPName pname, int* parameters) => GLPointers._glColorTableParameterivSGI_fnptr((uint)target, (uint)pname, parameters);
            
            public static void CopyColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int x, int y, int width) => GLPointers._glCopyColorTableSGI_fnptr((uint)target, (uint)internalformat, x, y, width);
            
            public static void GetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, void* table) => GLPointers._glGetColorTableSGI_fnptr((uint)target, (uint)format, (uint)type, table);
            
            public static void GetColorTableParameterfvSGI(ColorTableTargetSGI target, ColorTableParameterPName pname, float* parameters) => GLPointers._glGetColorTableParameterfvSGI_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetColorTableParameterivSGI(ColorTableTargetSGI target, ColorTableParameterPName pname, int* parameters) => GLPointers._glGetColorTableParameterivSGI_fnptr((uint)target, (uint)pname, parameters);
            
        }
        /// <summary>SUNX extensions.</summary>
        public static unsafe partial class SUNX
        {
            public static void FinishTextureSUNX() => GLPointers._glFinishTextureSUNX_fnptr();
            
        }
        /// <summary>SUN extensions.</summary>
        public static unsafe partial class SUN
        {
            public static void GlobalAlphaFactorbSUN(sbyte factor) => GLPointers._glGlobalAlphaFactorbSUN_fnptr(factor);
            
            public static void GlobalAlphaFactorsSUN(short factor) => GLPointers._glGlobalAlphaFactorsSUN_fnptr(factor);
            
            public static void GlobalAlphaFactoriSUN(int factor) => GLPointers._glGlobalAlphaFactoriSUN_fnptr(factor);
            
            public static void GlobalAlphaFactorfSUN(float factor) => GLPointers._glGlobalAlphaFactorfSUN_fnptr(factor);
            
            public static void GlobalAlphaFactordSUN(double factor) => GLPointers._glGlobalAlphaFactordSUN_fnptr(factor);
            
            public static void GlobalAlphaFactorubSUN(byte factor) => GLPointers._glGlobalAlphaFactorubSUN_fnptr(factor);
            
            public static void GlobalAlphaFactorusSUN(ushort factor) => GLPointers._glGlobalAlphaFactorusSUN_fnptr(factor);
            
            public static void GlobalAlphaFactoruiSUN(uint factor) => GLPointers._glGlobalAlphaFactoruiSUN_fnptr(factor);
            
            public static void DrawMeshArraysSUN(PrimitiveType mode, int first, int count, int width) => GLPointers._glDrawMeshArraysSUN_fnptr((uint)mode, first, count, width);
            
            public static void ReplacementCodeuiSUN(TriangleListSUN code) => GLPointers._glReplacementCodeuiSUN_fnptr((uint)code);
            
            public static void ReplacementCodeusSUN(ushort code) => GLPointers._glReplacementCodeusSUN_fnptr(code);
            
            public static void ReplacementCodeubSUN(byte code) => GLPointers._glReplacementCodeubSUN_fnptr(code);
            
            public static void ReplacementCodeuivSUN(TriangleListSUN* code) => GLPointers._glReplacementCodeuivSUN_fnptr((uint*)code);
            
            public static void ReplacementCodeusvSUN(ushort* code) => GLPointers._glReplacementCodeusvSUN_fnptr(code);
            
            public static void ReplacementCodeubvSUN(byte* code) => GLPointers._glReplacementCodeubvSUN_fnptr(code);
            
            public static void ReplacementCodePointerSUN(ReplacementCodeTypeSUN type, int stride, void** pointer) => GLPointers._glReplacementCodePointerSUN_fnptr((uint)type, stride, pointer);
            
            public static void Color4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y) => GLPointers._glColor4ubVertex2fSUN_fnptr(r, g, b, a, x, y);
            
            public static void Color4ubVertex2fvSUN(byte* c, float* v) => GLPointers._glColor4ubVertex2fvSUN_fnptr(c, v);
            
            public static void Color4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z) => GLPointers._glColor4ubVertex3fSUN_fnptr(r, g, b, a, x, y, z);
            
            public static void Color4ubVertex3fvSUN(byte* c, float* v) => GLPointers._glColor4ubVertex3fvSUN_fnptr(c, v);
            
            public static void Color3fVertex3fSUN(float r, float g, float b, float x, float y, float z) => GLPointers._glColor3fVertex3fSUN_fnptr(r, g, b, x, y, z);
            
            public static void Color3fVertex3fvSUN(float* c, float* v) => GLPointers._glColor3fVertex3fvSUN_fnptr(c, v);
            
            public static void Normal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z) => GLPointers._glNormal3fVertex3fSUN_fnptr(nx, ny, nz, x, y, z);
            
            public static void Normal3fVertex3fvSUN(float* n, float* v) => GLPointers._glNormal3fVertex3fvSUN_fnptr(n, v);
            
            public static void Color4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => GLPointers._glColor4fNormal3fVertex3fSUN_fnptr(r, g, b, a, nx, ny, nz, x, y, z);
            
            public static void Color4fNormal3fVertex3fvSUN(float* c, float* n, float* v) => GLPointers._glColor4fNormal3fVertex3fvSUN_fnptr(c, n, v);
            
            public static void TexCoord2fVertex3fSUN(float s, float t, float x, float y, float z) => GLPointers._glTexCoord2fVertex3fSUN_fnptr(s, t, x, y, z);
            
            public static void TexCoord2fVertex3fvSUN(float* tc, float* v) => GLPointers._glTexCoord2fVertex3fvSUN_fnptr(tc, v);
            
            public static void TexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w) => GLPointers._glTexCoord4fVertex4fSUN_fnptr(s, t, p, q, x, y, z, w);
            
            public static void TexCoord4fVertex4fvSUN(float* tc, float* v) => GLPointers._glTexCoord4fVertex4fvSUN_fnptr(tc, v);
            
            public static void TexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z) => GLPointers._glTexCoord2fColor4ubVertex3fSUN_fnptr(s, t, r, g, b, a, x, y, z);
            
            public static void TexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v) => GLPointers._glTexCoord2fColor4ubVertex3fvSUN_fnptr(tc, c, v);
            
            public static void TexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z) => GLPointers._glTexCoord2fColor3fVertex3fSUN_fnptr(s, t, r, g, b, x, y, z);
            
            public static void TexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v) => GLPointers._glTexCoord2fColor3fVertex3fvSUN_fnptr(tc, c, v);
            
            public static void TexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z) => GLPointers._glTexCoord2fNormal3fVertex3fSUN_fnptr(s, t, nx, ny, nz, x, y, z);
            
            public static void TexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v) => GLPointers._glTexCoord2fNormal3fVertex3fvSUN_fnptr(tc, n, v);
            
            public static void TexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => GLPointers._glTexCoord2fColor4fNormal3fVertex3fSUN_fnptr(s, t, r, g, b, a, nx, ny, nz, x, y, z);
            
            public static void TexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v) => GLPointers._glTexCoord2fColor4fNormal3fVertex3fvSUN_fnptr(tc, c, n, v);
            
            public static void TexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w) => GLPointers._glTexCoord4fColor4fNormal3fVertex4fSUN_fnptr(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
            
            public static void TexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v) => GLPointers._glTexCoord4fColor4fNormal3fVertex4fvSUN_fnptr(tc, c, n, v);
            
            public static void ReplacementCodeuiVertex3fSUN(TriangleListSUN rc, float x, float y, float z) => GLPointers._glReplacementCodeuiVertex3fSUN_fnptr((uint)rc, x, y, z);
            
            public static void ReplacementCodeuiVertex3fvSUN(TriangleListSUN* rc, float* v) => GLPointers._glReplacementCodeuiVertex3fvSUN_fnptr((uint*)rc, v);
            
            public static void ReplacementCodeuiColor4ubVertex3fSUN(TriangleListSUN rc, byte r, byte g, byte b, byte a, float x, float y, float z) => GLPointers._glReplacementCodeuiColor4ubVertex3fSUN_fnptr((uint)rc, r, g, b, a, x, y, z);
            
            public static void ReplacementCodeuiColor4ubVertex3fvSUN(TriangleListSUN* rc, byte* c, float* v) => GLPointers._glReplacementCodeuiColor4ubVertex3fvSUN_fnptr((uint*)rc, c, v);
            
            public static void ReplacementCodeuiColor3fVertex3fSUN(TriangleListSUN rc, float r, float g, float b, float x, float y, float z) => GLPointers._glReplacementCodeuiColor3fVertex3fSUN_fnptr((uint)rc, r, g, b, x, y, z);
            
            public static void ReplacementCodeuiColor3fVertex3fvSUN(TriangleListSUN* rc, float* c, float* v) => GLPointers._glReplacementCodeuiColor3fVertex3fvSUN_fnptr((uint*)rc, c, v);
            
            public static void ReplacementCodeuiNormal3fVertex3fSUN(TriangleListSUN rc, float nx, float ny, float nz, float x, float y, float z) => GLPointers._glReplacementCodeuiNormal3fVertex3fSUN_fnptr((uint)rc, nx, ny, nz, x, y, z);
            
            public static void ReplacementCodeuiNormal3fVertex3fvSUN(TriangleListSUN* rc, float* n, float* v) => GLPointers._glReplacementCodeuiNormal3fVertex3fvSUN_fnptr((uint*)rc, n, v);
            
            public static void ReplacementCodeuiColor4fNormal3fVertex3fSUN(TriangleListSUN rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => GLPointers._glReplacementCodeuiColor4fNormal3fVertex3fSUN_fnptr((uint)rc, r, g, b, a, nx, ny, nz, x, y, z);
            
            public static void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(TriangleListSUN* rc, float* c, float* n, float* v) => GLPointers._glReplacementCodeuiColor4fNormal3fVertex3fvSUN_fnptr((uint*)rc, c, n, v);
            
            public static void ReplacementCodeuiTexCoord2fVertex3fSUN(TriangleListSUN rc, float s, float t, float x, float y, float z) => GLPointers._glReplacementCodeuiTexCoord2fVertex3fSUN_fnptr((uint)rc, s, t, x, y, z);
            
            public static void ReplacementCodeuiTexCoord2fVertex3fvSUN(TriangleListSUN* rc, float* tc, float* v) => GLPointers._glReplacementCodeuiTexCoord2fVertex3fvSUN_fnptr((uint*)rc, tc, v);
            
            public static void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(TriangleListSUN rc, float s, float t, float nx, float ny, float nz, float x, float y, float z) => GLPointers._glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN_fnptr((uint)rc, s, t, nx, ny, nz, x, y, z);
            
            public static void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(TriangleListSUN* rc, float* tc, float* n, float* v) => GLPointers._glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN_fnptr((uint*)rc, tc, n, v);
            
            public static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(TriangleListSUN rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => GLPointers._glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN_fnptr((uint)rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
            
            public static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(TriangleListSUN* rc, float* tc, float* c, float* n, float* v) => GLPointers._glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN_fnptr((uint*)rc, tc, c, n, v);
            
        }
    }
}
