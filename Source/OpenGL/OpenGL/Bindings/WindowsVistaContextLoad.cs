using System;
using System.Runtime.InteropServices;
using OpenTK.OpenGL;

namespace OpenTK.OpenGL.Platform
{
    public partial class WindowsVistaContext
    {
        #region DllImports

        internal class Imports
        {
            [DllImport(_dll_name, EntryPoint = "glNewList")]
            public static extern void NewList(uint list, Enums.ListMode mode);

            [DllImport(_dll_name, EntryPoint = "glEndList")]
            public static extern void EndList();

            [DllImport(_dll_name, EntryPoint = "glCallList")]
            public static extern void CallList(uint list);

            [DllImport(_dll_name, EntryPoint = "glCallLists")]
            public static extern void CallLists(int n, Enums.ListNameType type, [MarshalAs(UnmanagedType.AsAny)] object lists);

            [DllImport(_dll_name, EntryPoint = "glDeleteLists")]
            public static extern void DeleteLists(uint list, int range);

            [DllImport(_dll_name, EntryPoint = "glGenLists")]
            public static extern uint GenLists(int range);

            [DllImport(_dll_name, EntryPoint = "glListBase")]
            public static extern void ListBase(uint @base);

            [DllImport(_dll_name, EntryPoint = "glBegin")]
            public static extern void Begin(Enums.BeginMode mode);

            [DllImport(_dll_name, EntryPoint = "glBitmap")]
            public static extern void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);

            [DllImport(_dll_name, EntryPoint = "glColor3b")]
            public static extern void Color3b(byte red, byte green, byte blue);

            [DllImport(_dll_name, EntryPoint = "glColor3bv")]
            public static extern void Color3bv(byte[] v);

            [DllImport(_dll_name, EntryPoint = "glColor3d")]
            public static extern void Color3d(double red, double green, double blue);

            [DllImport(_dll_name, EntryPoint = "glColor3dv")]
            public static extern void Color3dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glColor3f")]
            public static extern void Color3f(float red, float green, float blue);

            [DllImport(_dll_name, EntryPoint = "glColor3fv")]
            public static extern void Color3fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glColor3i")]
            public static extern void Color3i(int red, int green, int blue);

            [DllImport(_dll_name, EntryPoint = "glColor3iv")]
            public static extern void Color3iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glColor3s")]
            public static extern void Color3s(short red, short green, short blue);

            [DllImport(_dll_name, EntryPoint = "glColor3sv")]
            public static extern void Color3sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glColor3ub")]
            public static extern void Color3ub(byte red, byte green, byte blue);

            [DllImport(_dll_name, EntryPoint = "glColor3ubv")]
            public static extern void Color3ubv(byte[] v);

            [DllImport(_dll_name, EntryPoint = "glColor3ui")]
            public static extern void Color3ui(uint red, uint green, uint blue);

            [DllImport(_dll_name, EntryPoint = "glColor3uiv")]
            public static extern void Color3uiv(uint[] v);

            [DllImport(_dll_name, EntryPoint = "glColor3us")]
            public static extern void Color3us(ushort red, ushort green, ushort blue);

            [DllImport(_dll_name, EntryPoint = "glColor3usv")]
            public static extern void Color3usv(ushort[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4b")]
            public static extern void Color4b(byte red, byte green, byte blue, byte alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4bv")]
            public static extern void Color4bv(byte[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4d")]
            public static extern void Color4d(double red, double green, double blue, double alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4dv")]
            public static extern void Color4dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4f")]
            public static extern void Color4f(float red, float green, float blue, float alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4fv")]
            public static extern void Color4fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4i")]
            public static extern void Color4i(int red, int green, int blue, int alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4iv")]
            public static extern void Color4iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4s")]
            public static extern void Color4s(short red, short green, short blue, short alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4sv")]
            public static extern void Color4sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4ub")]
            public static extern void Color4ub(byte red, byte green, byte blue, byte alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4ubv")]
            public static extern void Color4ubv(byte[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4ui")]
            public static extern void Color4ui(uint red, uint green, uint blue, uint alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4uiv")]
            public static extern void Color4uiv(uint[] v);

            [DllImport(_dll_name, EntryPoint = "glColor4us")]
            public static extern void Color4us(ushort red, ushort green, ushort blue, ushort alpha);

            [DllImport(_dll_name, EntryPoint = "glColor4usv")]
            public static extern void Color4usv(ushort[] v);

            [DllImport(_dll_name, EntryPoint = "glEdgeFlag")]
            public static extern void EdgeFlag(bool flag);

            [DllImport(_dll_name, EntryPoint = "glEdgeFlagv")]
            public static extern void EdgeFlagv(bool[] flag);

            [DllImport(_dll_name, EntryPoint = "glEnd")]
            public static extern void End();

            [DllImport(_dll_name, EntryPoint = "glIndexd")]
            public static extern void Indexd(double c);

            [DllImport(_dll_name, EntryPoint = "glIndexdv")]
            public static extern void Indexdv(double[] c);

            [DllImport(_dll_name, EntryPoint = "glIndexf")]
            public static extern void Indexf(float c);

            [DllImport(_dll_name, EntryPoint = "glIndexfv")]
            public static extern void Indexfv(float[] c);

            [DllImport(_dll_name, EntryPoint = "glIndexi")]
            public static extern void Indexi(int c);

            [DllImport(_dll_name, EntryPoint = "glIndexiv")]
            public static extern void Indexiv(int[] c);

            [DllImport(_dll_name, EntryPoint = "glIndexs")]
            public static extern void Indexs(short c);

            [DllImport(_dll_name, EntryPoint = "glIndexsv")]
            public static extern void Indexsv(short[] c);

            [DllImport(_dll_name, EntryPoint = "glNormal3b")]
            public static extern void Normal3b(byte nx, byte ny, byte nz);

            [DllImport(_dll_name, EntryPoint = "glNormal3bv")]
            public static extern void Normal3bv(byte[] v);

            [DllImport(_dll_name, EntryPoint = "glNormal3d")]
            public static extern void Normal3d(double nx, double ny, double nz);

            [DllImport(_dll_name, EntryPoint = "glNormal3dv")]
            public static extern void Normal3dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glNormal3f")]
            public static extern void Normal3f(float nx, float ny, float nz);

            [DllImport(_dll_name, EntryPoint = "glNormal3fv")]
            public static extern void Normal3fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glNormal3i")]
            public static extern void Normal3i(int nx, int ny, int nz);

            [DllImport(_dll_name, EntryPoint = "glNormal3iv")]
            public static extern void Normal3iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glNormal3s")]
            public static extern void Normal3s(short nx, short ny, short nz);

            [DllImport(_dll_name, EntryPoint = "glNormal3sv")]
            public static extern void Normal3sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2d")]
            public static extern void RasterPos2d(double x, double y);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2dv")]
            public static extern void RasterPos2dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2f")]
            public static extern void RasterPos2f(float x, float y);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2fv")]
            public static extern void RasterPos2fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2i")]
            public static extern void RasterPos2i(int x, int y);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2iv")]
            public static extern void RasterPos2iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2s")]
            public static extern void RasterPos2s(short x, short y);

            [DllImport(_dll_name, EntryPoint = "glRasterPos2sv")]
            public static extern void RasterPos2sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3d")]
            public static extern void RasterPos3d(double x, double y, double z);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3dv")]
            public static extern void RasterPos3dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3f")]
            public static extern void RasterPos3f(float x, float y, float z);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3fv")]
            public static extern void RasterPos3fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3i")]
            public static extern void RasterPos3i(int x, int y, int z);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3iv")]
            public static extern void RasterPos3iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3s")]
            public static extern void RasterPos3s(short x, short y, short z);

            [DllImport(_dll_name, EntryPoint = "glRasterPos3sv")]
            public static extern void RasterPos3sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4d")]
            public static extern void RasterPos4d(double x, double y, double z, double w);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4dv")]
            public static extern void RasterPos4dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4f")]
            public static extern void RasterPos4f(float x, float y, float z, float w);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4fv")]
            public static extern void RasterPos4fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4i")]
            public static extern void RasterPos4i(int x, int y, int z, int w);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4iv")]
            public static extern void RasterPos4iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4s")]
            public static extern void RasterPos4s(short x, short y, short z, short w);

            [DllImport(_dll_name, EntryPoint = "glRasterPos4sv")]
            public static extern void RasterPos4sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glRectd")]
            public static extern void Rectd(double x1, double y1, double x2, double y2);

            [DllImport(_dll_name, EntryPoint = "glRectdv")]
            public static extern void Rectdv(double[] v1, double[] v2);

            [DllImport(_dll_name, EntryPoint = "glRectf")]
            public static extern void Rectf(float x1, float y1, float x2, float y2);

            [DllImport(_dll_name, EntryPoint = "glRectfv")]
            public static extern void Rectfv(float[] v1, float[] v2);

            [DllImport(_dll_name, EntryPoint = "glRecti")]
            public static extern void Recti(int x1, int y1, int x2, int y2);

            [DllImport(_dll_name, EntryPoint = "glRectiv")]
            public static extern void Rectiv(int[] v1, int[] v2);

            [DllImport(_dll_name, EntryPoint = "glRects")]
            public static extern void Rects(short x1, short y1, short x2, short y2);

            [DllImport(_dll_name, EntryPoint = "glRectsv")]
            public static extern void Rectsv(short[] v1, short[] v2);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1d")]
            public static extern void TexCoord1d(double s);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1dv")]
            public static extern void TexCoord1dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1f")]
            public static extern void TexCoord1f(float s);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1fv")]
            public static extern void TexCoord1fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1i")]
            public static extern void TexCoord1i(int s);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1iv")]
            public static extern void TexCoord1iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1s")]
            public static extern void TexCoord1s(short s);

            [DllImport(_dll_name, EntryPoint = "glTexCoord1sv")]
            public static extern void TexCoord1sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2d")]
            public static extern void TexCoord2d(double s, double t);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2dv")]
            public static extern void TexCoord2dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2f")]
            public static extern void TexCoord2f(float s, float t);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2fv")]
            public static extern void TexCoord2fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2i")]
            public static extern void TexCoord2i(int s, int t);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2iv")]
            public static extern void TexCoord2iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2s")]
            public static extern void TexCoord2s(short s, short t);

            [DllImport(_dll_name, EntryPoint = "glTexCoord2sv")]
            public static extern void TexCoord2sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3d")]
            public static extern void TexCoord3d(double s, double t, double r);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3dv")]
            public static extern void TexCoord3dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3f")]
            public static extern void TexCoord3f(float s, float t, float r);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3fv")]
            public static extern void TexCoord3fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3i")]
            public static extern void TexCoord3i(int s, int t, int r);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3iv")]
            public static extern void TexCoord3iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3s")]
            public static extern void TexCoord3s(short s, short t, short r);

            [DllImport(_dll_name, EntryPoint = "glTexCoord3sv")]
            public static extern void TexCoord3sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4d")]
            public static extern void TexCoord4d(double s, double t, double r, double q);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4dv")]
            public static extern void TexCoord4dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4f")]
            public static extern void TexCoord4f(float s, float t, float r, float q);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4fv")]
            public static extern void TexCoord4fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4i")]
            public static extern void TexCoord4i(int s, int t, int r, int q);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4iv")]
            public static extern void TexCoord4iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4s")]
            public static extern void TexCoord4s(short s, short t, short r, short q);

            [DllImport(_dll_name, EntryPoint = "glTexCoord4sv")]
            public static extern void TexCoord4sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex2d")]
            public static extern void Vertex2d(double x, double y);

            [DllImport(_dll_name, EntryPoint = "glVertex2dv")]
            public static extern void Vertex2dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex2f")]
            public static extern void Vertex2f(float x, float y);

            [DllImport(_dll_name, EntryPoint = "glVertex2fv")]
            public static extern void Vertex2fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex2i")]
            public static extern void Vertex2i(int x, int y);

            [DllImport(_dll_name, EntryPoint = "glVertex2iv")]
            public static extern void Vertex2iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex2s")]
            public static extern void Vertex2s(short x, short y);

            [DllImport(_dll_name, EntryPoint = "glVertex2sv")]
            public static extern void Vertex2sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex3d")]
            public static extern void Vertex3d(double x, double y, double z);

            [DllImport(_dll_name, EntryPoint = "glVertex3dv")]
            public static extern void Vertex3dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex3f")]
            public static extern void Vertex3f(float x, float y, float z);

            [DllImport(_dll_name, EntryPoint = "glVertex3fv")]
            public static extern void Vertex3fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex3i")]
            public static extern void Vertex3i(int x, int y, int z);

            [DllImport(_dll_name, EntryPoint = "glVertex3iv")]
            public static extern void Vertex3iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex3s")]
            public static extern void Vertex3s(short x, short y, short z);

            [DllImport(_dll_name, EntryPoint = "glVertex3sv")]
            public static extern void Vertex3sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex4d")]
            public static extern void Vertex4d(double x, double y, double z, double w);

            [DllImport(_dll_name, EntryPoint = "glVertex4dv")]
            public static extern void Vertex4dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex4f")]
            public static extern void Vertex4f(float x, float y, float z, float w);

            [DllImport(_dll_name, EntryPoint = "glVertex4fv")]
            public static extern void Vertex4fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex4i")]
            public static extern void Vertex4i(int x, int y, int z, int w);

            [DllImport(_dll_name, EntryPoint = "glVertex4iv")]
            public static extern void Vertex4iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glVertex4s")]
            public static extern void Vertex4s(short x, short y, short z, short w);

            [DllImport(_dll_name, EntryPoint = "glVertex4sv")]
            public static extern void Vertex4sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glClipPlane")]
            public static extern void ClipPlane(Enums.ClipPlaneName plane, double[] equation);

            [DllImport(_dll_name, EntryPoint = "glColorMaterial")]
            public static extern void ColorMaterial(Enums.MaterialFace face, Enums.ColorMaterialParameter mode);

            [DllImport(_dll_name, EntryPoint = "glCullFace")]
            public static extern void CullFace(Enums.CullFaceMode mode);

            [DllImport(_dll_name, EntryPoint = "glFogf")]
            public static extern void Fogf(Enums.FogParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glFogfv")]
            public static extern void Fogfv(Enums.FogParameter pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glFogi")]
            public static extern void Fogi(Enums.FogParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glFogiv")]
            public static extern void Fogiv(Enums.FogParameter pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glFrontFace")]
            public static extern void FrontFace(Enums.FrontFaceDirection mode);

            [DllImport(_dll_name, EntryPoint = "glHint")]
            public static extern void Hint(Enums.HintTarget target, Enums.HintMode mode);

            [DllImport(_dll_name, EntryPoint = "glLightf")]
            public static extern void Lightf(Enums.LightName light, Enums.LightParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glLightfv")]
            public static extern void Lightfv(Enums.LightName light, Enums.LightParameter pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glLighti")]
            public static extern void Lighti(Enums.LightName light, Enums.LightParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glLightiv")]
            public static extern void Lightiv(Enums.LightName light, Enums.LightParameter pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glLightModelf")]
            public static extern void LightModelf(Enums.LightModelParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glLightModelfv")]
            public static extern void LightModelfv(Enums.LightModelParameter pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glLightModeli")]
            public static extern void LightModeli(Enums.LightModelParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glLightModeliv")]
            public static extern void LightModeliv(Enums.LightModelParameter pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glLineStipple")]
            public static extern void LineStipple(int factor, ushort pattern);

            [DllImport(_dll_name, EntryPoint = "glLineWidth")]
            public static extern void LineWidth(float width);

            [DllImport(_dll_name, EntryPoint = "glMaterialf")]
            public static extern void Materialf(Enums.MaterialFace face, Enums.MaterialParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glMaterialfv")]
            public static extern void Materialfv(Enums.MaterialFace face, Enums.MaterialParameter pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glMateriali")]
            public static extern void Materiali(Enums.MaterialFace face, Enums.MaterialParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glMaterialiv")]
            public static extern void Materialiv(Enums.MaterialFace face, Enums.MaterialParameter pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glPointSize")]
            public static extern void PointSize(float size);

            [DllImport(_dll_name, EntryPoint = "glPolygonMode")]
            public static extern void PolygonMode(Enums.MaterialFace face, Enums.PolygonMode mode);

            [DllImport(_dll_name, EntryPoint = "glPolygonStipple")]
            public static extern void PolygonStipple(byte[] mask);

            [DllImport(_dll_name, EntryPoint = "glScissor")]
            public static extern void Scissor(int x, int y, int width, int height);

            [DllImport(_dll_name, EntryPoint = "glShadeModel")]
            public static extern void ShadeModel(Enums.ShadingModel mode);

            [DllImport(_dll_name, EntryPoint = "glTexParameterf")]
            public static extern void TexParameterf(Enums.TextureTarget target, Enums.TextureParameterName pname, float param);

            [DllImport(_dll_name, EntryPoint = "glTexParameterfv")]
            public static extern void TexParameterfv(Enums.TextureTarget target, Enums.TextureParameterName pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glTexParameteri")]
            public static extern void TexParameteri(Enums.TextureTarget target, Enums.TextureParameterName pname, int param);

            [DllImport(_dll_name, EntryPoint = "glTexParameteriv")]
            public static extern void TexParameteriv(Enums.TextureTarget target, Enums.TextureParameterName pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glTexImage1D")]
            public static extern void TexImage1D(Enums.TextureTarget target, int level, int internalformat, int width, int border, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);

            [DllImport(_dll_name, EntryPoint = "glTexImage2D")]
            public static extern void TexImage2D(Enums.TextureTarget target, int level, int internalformat, int width, int height, int border, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);

            [DllImport(_dll_name, EntryPoint = "glTexEnvf")]
            public static extern void TexEnvf(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glTexEnvfv")]
            public static extern void TexEnvfv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glTexEnvi")]
            public static extern void TexEnvi(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glTexEnviv")]
            public static extern void TexEnviv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glTexGend")]
            public static extern void TexGend(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, double param);

            [DllImport(_dll_name, EntryPoint = "glTexGendv")]
            public static extern void TexGendv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, double[] parameters);

            [DllImport(_dll_name, EntryPoint = "glTexGenf")]
            public static extern void TexGenf(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glTexGenfv")]
            public static extern void TexGenfv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glTexGeni")]
            public static extern void TexGeni(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glTexGeniv")]
            public static extern void TexGeniv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glFeedbackBuffer")]
            public static extern void FeedbackBuffer(int size, Enums.FeedbackType type, out float[] buffer);

            [DllImport(_dll_name, EntryPoint = "glSelectBuffer")]
            public static extern void SelectBuffer(int size, out uint[] buffer);

            [DllImport(_dll_name, EntryPoint = "glRenderMode")]
            public static extern int RenderMode(Enums.RenderingMode mode);

            [DllImport(_dll_name, EntryPoint = "glInitNames")]
            public static extern void InitNames();

            [DllImport(_dll_name, EntryPoint = "glLoadName")]
            public static extern void LoadName(uint name);

            [DllImport(_dll_name, EntryPoint = "glPassThrough")]
            public static extern void PassThrough(float token);

            [DllImport(_dll_name, EntryPoint = "glPopName")]
            public static extern void PopName();

            [DllImport(_dll_name, EntryPoint = "glPushName")]
            public static extern void PushName(uint name);

            [DllImport(_dll_name, EntryPoint = "glDrawBuffer")]
            public static extern void DrawBuffer(Enums.DrawBufferMode mode);

            [DllImport(_dll_name, EntryPoint = "glClear")]
            public static extern void Clear(Enums.ClearBufferMask mask);

            [DllImport(_dll_name, EntryPoint = "glClearAccum")]
            public static extern void ClearAccum(float red, float green, float blue, float alpha);

            [DllImport(_dll_name, EntryPoint = "glClearIndex")]
            public static extern void ClearIndex(float c);

            [DllImport(_dll_name, EntryPoint = "glClearColor")]
            public static extern void ClearColor(float red, float green, float blue, float alpha);

            [DllImport(_dll_name, EntryPoint = "glClearStencil")]
            public static extern void ClearStencil(int s);

            [DllImport(_dll_name, EntryPoint = "glClearDepth")]
            public static extern void ClearDepth(double depth);

            [DllImport(_dll_name, EntryPoint = "glStencilMask")]
            public static extern void StencilMask(uint mask);

            [DllImport(_dll_name, EntryPoint = "glColorMask")]
            public static extern void ColorMask(bool red, bool green, bool blue, bool alpha);

            [DllImport(_dll_name, EntryPoint = "glDepthMask")]
            public static extern void DepthMask(bool flag);

            [DllImport(_dll_name, EntryPoint = "glIndexMask")]
            public static extern void IndexMask(uint mask);

            [DllImport(_dll_name, EntryPoint = "glAccum")]
            public static extern void Accum(Enums.AccumOp op, float value);

            [DllImport(_dll_name, EntryPoint = "glDisable")]
            public static extern void Disable(Enums.EnableCap cap);

            [DllImport(_dll_name, EntryPoint = "glEnable")]
            public static extern void Enable(Enums.EnableCap cap);

            [DllImport(_dll_name, EntryPoint = "glFinish")]
            public static extern void Finish();

            [DllImport(_dll_name, EntryPoint = "glFlush")]
            public static extern void Flush();

            [DllImport(_dll_name, EntryPoint = "glPopAttrib")]
            public static extern void PopAttrib();

            [DllImport(_dll_name, EntryPoint = "glPushAttrib")]
            public static extern void PushAttrib(Enums.AttribMask mask);

            [DllImport(_dll_name, EntryPoint = "glMap1d")]
            public static extern void Map1d(Enums.MapTarget target, double u1, double u2, int stride, int order, double[] points);

            [DllImport(_dll_name, EntryPoint = "glMap1f")]
            public static extern void Map1f(Enums.MapTarget target, float u1, float u2, int stride, int order, float[] points);

            [DllImport(_dll_name, EntryPoint = "glMap2d")]
            public static extern void Map2d(Enums.MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);

            [DllImport(_dll_name, EntryPoint = "glMap2f")]
            public static extern void Map2f(Enums.MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);

            [DllImport(_dll_name, EntryPoint = "glMapGrid1d")]
            public static extern void MapGrid1d(int un, double u1, double u2);

            [DllImport(_dll_name, EntryPoint = "glMapGrid1f")]
            public static extern void MapGrid1f(int un, float u1, float u2);

            [DllImport(_dll_name, EntryPoint = "glMapGrid2d")]
            public static extern void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

            [DllImport(_dll_name, EntryPoint = "glMapGrid2f")]
            public static extern void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord1d")]
            public static extern void EvalCoord1d(double u);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord1dv")]
            public static extern void EvalCoord1dv(double[] u);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord1f")]
            public static extern void EvalCoord1f(float u);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord1fv")]
            public static extern void EvalCoord1fv(float[] u);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord2d")]
            public static extern void EvalCoord2d(double u, double v);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord2dv")]
            public static extern void EvalCoord2dv(double[] u);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord2f")]
            public static extern void EvalCoord2f(float u, float v);

            [DllImport(_dll_name, EntryPoint = "glEvalCoord2fv")]
            public static extern void EvalCoord2fv(float[] u);

            [DllImport(_dll_name, EntryPoint = "glEvalMesh1")]
            public static extern void EvalMesh1(Enums.MeshMode1 mode, int i1, int i2);

            [DllImport(_dll_name, EntryPoint = "glEvalPoint1")]
            public static extern void EvalPoint1(int i);

            [DllImport(_dll_name, EntryPoint = "glEvalMesh2")]
            public static extern void EvalMesh2(Enums.MeshMode2 mode, int i1, int i2, int j1, int j2);

            [DllImport(_dll_name, EntryPoint = "glEvalPoint2")]
            public static extern void EvalPoint2(int i, int j);

            [DllImport(_dll_name, EntryPoint = "glAlphaFunc")]
            public static extern void AlphaFunc(Enums.AlphaFunction func, float reference);

            [DllImport(_dll_name, EntryPoint = "glBlendFunc")]
            public static extern void BlendFunc(Enums.BlendingFactorSrc sfactor, Enums.BlendingFactorDest dfactor);

            [DllImport(_dll_name, EntryPoint = "glLogicOp")]
            public static extern void LogicOp(Enums.LogicOp opcode);

            [DllImport(_dll_name, EntryPoint = "glStencilFunc")]
            public static extern void StencilFunc(Enums.StencilFunction func, int reference, uint mask);

            [DllImport(_dll_name, EntryPoint = "glStencilOp")]
            public static extern void StencilOp(Enums.StencilOp fail, Enums.StencilOp zfail, Enums.StencilOp zpass);

            [DllImport(_dll_name, EntryPoint = "glDepthFunc")]
            public static extern void DepthFunc(Enums.DepthFunction func);

            [DllImport(_dll_name, EntryPoint = "glPixelZoom")]
            public static extern void PixelZoom(float xfactor, float yfactor);

            [DllImport(_dll_name, EntryPoint = "glPixelTransferf")]
            public static extern void PixelTransferf(Enums.PixelTransferParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glPixelTransferi")]
            public static extern void PixelTransferi(Enums.PixelTransferParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glPixelStoref")]
            public static extern void PixelStoref(Enums.PixelStoreParameter pname, float param);

            [DllImport(_dll_name, EntryPoint = "glPixelStorei")]
            public static extern void PixelStorei(Enums.PixelStoreParameter pname, int param);

            [DllImport(_dll_name, EntryPoint = "glPixelMapfv")]
            public static extern void PixelMapfv(Enums.PixelMap map, int mapsize, float[] values);

            [DllImport(_dll_name, EntryPoint = "glPixelMapuiv")]
            public static extern void PixelMapuiv(Enums.PixelMap map, int mapsize, uint[] values);

            [DllImport(_dll_name, EntryPoint = "glPixelMapusv")]
            public static extern void PixelMapusv(Enums.PixelMap map, int mapsize, ushort[] values);

            [DllImport(_dll_name, EntryPoint = "glReadBuffer")]
            public static extern void ReadBuffer(Enums.ReadBufferMode mode);

            [DllImport(_dll_name, EntryPoint = "glCopyPixels")]
            public static extern void CopyPixels(int x, int y, int width, int height, Enums.PixelCopyType type);

            [DllImport(_dll_name, EntryPoint = "glReadPixels")]
            public static extern void ReadPixels(int x, int y, int width, int height, Enums.PixelFormat format, Enums.PixelType type, out object pixels);

            [DllImport(_dll_name, EntryPoint = "glDrawPixels")]
            public static extern void DrawPixels(int width, int height, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);

            [DllImport(_dll_name, EntryPoint = "glGetBooleanv")]
            public static extern void GetBooleanv(Enums.GetPName pname, out bool[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetClipPlane")]
            public static extern void GetClipPlane(Enums.ClipPlaneName plane, out double[] equation);

            [DllImport(_dll_name, EntryPoint = "glGetDoublev")]
            public static extern void GetDoublev(Enums.GetPName pname, out double[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetError")]
            public static extern Enums.ErrorCode GetError();

            [DllImport(_dll_name, EntryPoint = "glGetFloatv")]
            public static extern void GetFloatv(Enums.GetPName pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetIntegerv")]
            public static extern void GetIntegerv(Enums.GetPName pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetLightfv")]
            public static extern void GetLightfv(Enums.LightName light, Enums.LightParameter pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetLightiv")]
            public static extern void GetLightiv(Enums.LightName light, Enums.LightParameter pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetMapdv")]
            public static extern void GetMapdv(Enums.MapTarget target, Enums.GetMapQuery query, out double[] v);

            [DllImport(_dll_name, EntryPoint = "glGetMapfv")]
            public static extern void GetMapfv(Enums.MapTarget target, Enums.GetMapQuery query, out float[] v);

            [DllImport(_dll_name, EntryPoint = "glGetMapiv")]
            public static extern void GetMapiv(Enums.MapTarget target, Enums.GetMapQuery query, out int[] v);

            [DllImport(_dll_name, EntryPoint = "glGetMaterialfv")]
            public static extern void GetMaterialfv(Enums.MaterialFace face, Enums.MaterialParameter pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetMaterialiv")]
            public static extern void GetMaterialiv(Enums.MaterialFace face, Enums.MaterialParameter pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetPixelMapfv")]
            public static extern void GetPixelMapfv(Enums.PixelMap map, out float[] values);

            [DllImport(_dll_name, EntryPoint = "glGetPixelMapuiv")]
            public static extern void GetPixelMapuiv(Enums.PixelMap map, out uint[] values);

            [DllImport(_dll_name, EntryPoint = "glGetPixelMapusv")]
            public static extern void GetPixelMapusv(Enums.PixelMap map, out ushort[] values);

            [DllImport(_dll_name, EntryPoint = "glGetPolygonStipple")]
            public static extern void GetPolygonStipple(out byte[] mask);

            [DllImport(_dll_name, EntryPoint = "glGetString")]
            public static extern string GetString(Enums.StringName name);

            [DllImport(_dll_name, EntryPoint = "glGetTexEnvfv")]
            public static extern void GetTexEnvfv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexEnviv")]
            public static extern void GetTexEnviv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexGendv")]
            public static extern void GetTexGendv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, out double[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexGenfv")]
            public static extern void GetTexGenfv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexGeniv")]
            public static extern void GetTexGeniv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexImage")]
            public static extern void GetTexImage(Enums.TextureTarget target, int level, Enums.PixelFormat format, Enums.PixelType type, out object pixels);

            [DllImport(_dll_name, EntryPoint = "glGetTexParameterfv")]
            public static extern void GetTexParameterfv(Enums.TextureTarget target, Enums.GetTextureParameter pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexParameteriv")]
            public static extern void GetTexParameteriv(Enums.TextureTarget target, Enums.GetTextureParameter pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexLevelParameterfv")]
            public static extern void GetTexLevelParameterfv(Enums.TextureTarget target, int level, Enums.GetTextureParameter pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetTexLevelParameteriv")]
            public static extern void GetTexLevelParameteriv(Enums.TextureTarget target, int level, Enums.GetTextureParameter pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glIsEnabled")]
            public static extern bool IsEnabled(Enums.EnableCap cap);

            [DllImport(_dll_name, EntryPoint = "glIsList")]
            public static extern bool IsList(uint list);

            [DllImport(_dll_name, EntryPoint = "glDepthRange")]
            public static extern void DepthRange(double near, double far);

            [DllImport(_dll_name, EntryPoint = "glFrustum")]
            public static extern void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);

            [DllImport(_dll_name, EntryPoint = "glLoadIdentity")]
            public static extern void LoadIdentity();

            [DllImport(_dll_name, EntryPoint = "glLoadMatrixf")]
            public static extern void LoadMatrixf(float[] m);

            [DllImport(_dll_name, EntryPoint = "glLoadMatrixd")]
            public static extern void LoadMatrixd(double[] m);

            [DllImport(_dll_name, EntryPoint = "glMatrixMode")]
            public static extern void MatrixMode(Enums.MatrixMode mode);

            [DllImport(_dll_name, EntryPoint = "glMultMatrixf")]
            public static extern void MultMatrixf(float[] m);

            [DllImport(_dll_name, EntryPoint = "glMultMatrixd")]
            public static extern void MultMatrixd(double[] m);

            [DllImport(_dll_name, EntryPoint = "glOrtho")]
            public static extern void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);

            [DllImport(_dll_name, EntryPoint = "glPopMatrix")]
            public static extern void PopMatrix();

            [DllImport(_dll_name, EntryPoint = "glPushMatrix")]
            public static extern void PushMatrix();

            [DllImport(_dll_name, EntryPoint = "glRotated")]
            public static extern void Rotated(double angle, double x, double y, double z);

            [DllImport(_dll_name, EntryPoint = "glRotatef")]
            public static extern void Rotatef(float angle, float x, float y, float z);

            [DllImport(_dll_name, EntryPoint = "glScaled")]
            public static extern void Scaled(double x, double y, double z);

            [DllImport(_dll_name, EntryPoint = "glScalef")]
            public static extern void Scalef(float x, float y, float z);

            [DllImport(_dll_name, EntryPoint = "glTranslated")]
            public static extern void Translated(double x, double y, double z);

            [DllImport(_dll_name, EntryPoint = "glTranslatef")]
            public static extern void Translatef(float x, float y, float z);

            [DllImport(_dll_name, EntryPoint = "glViewport")]
            public static extern void Viewport(int x, int y, int width, int height);

            [DllImport(_dll_name, EntryPoint = "glArrayElement")]
            public static extern void ArrayElement(int i);

            [DllImport(_dll_name, EntryPoint = "glColorPointer")]
            public static extern void ColorPointer(int size, Enums.ColorPointerType type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glDisableClientState")]
            public static extern void DisableClientState(Enums.EnableCap array);

            [DllImport(_dll_name, EntryPoint = "glDrawArrays")]
            public static extern void DrawArrays(Enums.BeginMode mode, int first, int count);

            [DllImport(_dll_name, EntryPoint = "glDrawElements")]
            public static extern void DrawElements(Enums.BeginMode mode, int count, uint type, [MarshalAs(UnmanagedType.AsAny)] object indices);

            [DllImport(_dll_name, EntryPoint = "glEdgeFlagPointer")]
            public static extern void EdgeFlagPointer(int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glEnableClientState")]
            public static extern void EnableClientState(Enums.EnableCap array);

            [DllImport(_dll_name, EntryPoint = "glGetPointerv")]
            public static extern void GetPointerv(Enums.GetPointervPName pname, out object parameters);

            [DllImport(_dll_name, EntryPoint = "glIndexPointer")]
            public static extern void IndexPointer(Enums.IndexPointerType type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glInterleavedArrays")]
            public static extern void InterleavedArrays(Enums.InterleavedArrayFormat format, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glNormalPointer")]
            public static extern void NormalPointer(Enums.NormalPointerType type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glTexCoordPointer")]
            public static extern void TexCoordPointer(int size, Enums.TexCoordPointerType type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glVertexPointer")]
            public static extern void VertexPointer(int size, Enums.VertexPointerType type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glPolygonOffset")]
            public static extern void PolygonOffset(float factor, float units);

            [DllImport(_dll_name, EntryPoint = "glCopyTexImage1D")]
            public static extern void CopyTexImage1D(Enums.TextureTarget target, int level, Enums.PixelInternalFormat internalformat, int x, int y, int width, int border);

            [DllImport(_dll_name, EntryPoint = "glCopyTexImage2D")]
            public static extern void CopyTexImage2D(Enums.TextureTarget target, int level, Enums.PixelInternalFormat internalformat, int x, int y, int width, int height, int border);

            [DllImport(_dll_name, EntryPoint = "glCopyTexSubImage1D")]
            public static extern void CopyTexSubImage1D(Enums.TextureTarget target, int level, int xoffset, int x, int y, int width);

            [DllImport(_dll_name, EntryPoint = "glCopyTexSubImage2D")]
            public static extern void CopyTexSubImage2D(Enums.TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

            [DllImport(_dll_name, EntryPoint = "glTexSubImage1D")]
            public static extern void TexSubImage1D(Enums.TextureTarget target, int level, int xoffset, int width, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);

            [DllImport(_dll_name, EntryPoint = "glTexSubImage2D")]
            public static extern void TexSubImage2D(Enums.TextureTarget target, int level, int xoffset, int yoffset, int width, int height, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);

            [DllImport(_dll_name, EntryPoint = "glAreTexturesResident")]
            public static extern bool AreTexturesResident(int n, uint[] textures, out bool[] residences);

            [DllImport(_dll_name, EntryPoint = "glBindTexture")]
            public static extern void BindTexture(Enums.TextureTarget target, uint texture);

            [DllImport(_dll_name, EntryPoint = "glDeleteTextures")]
            public static extern void DeleteTextures(int n, uint[] textures);

            [DllImport(_dll_name, EntryPoint = "glGenTextures")]
            public static extern void GenTextures(int n, out uint[] textures);

            [DllImport(_dll_name, EntryPoint = "glIsTexture")]
            public static extern bool IsTexture(uint texture);

            [DllImport(_dll_name, EntryPoint = "glPrioritizeTextures")]
            public static extern void PrioritizeTextures(int n, uint[] textures, float[] priorities);

            [DllImport(_dll_name, EntryPoint = "glIndexub")]
            public static extern void Indexub(byte c);

            [DllImport(_dll_name, EntryPoint = "glIndexubv")]
            public static extern void Indexubv(byte[] c);

            [DllImport(_dll_name, EntryPoint = "glPopClientAttrib")]
            public static extern void PopClientAttrib();

            [DllImport(_dll_name, EntryPoint = "glPushClientAttrib")]
            public static extern void PushClientAttrib(Enums.ClientAttribMask mask);

            [DllImport(_dll_name, EntryPoint = "glBlendColor")]
            public static extern void BlendColor(float red, float green, float blue, float alpha);

            [DllImport(_dll_name, EntryPoint = "glBlendEquation")]
            public static extern void BlendEquation(Enums.BlendEquationModeEXT mode);

            [DllImport(_dll_name, EntryPoint = "glDrawRangeElements")]
            public static extern void DrawRangeElements(Enums.BeginMode mode, uint start, uint end, int count, uint type, [MarshalAs(UnmanagedType.AsAny)] object indices);

            [DllImport(_dll_name, EntryPoint = "glColorTable")]
            public static extern void ColorTable(Enums.ColorTableTargetSGI target, Enums.PixelInternalFormat internalformat, int width, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object table);

            [DllImport(_dll_name, EntryPoint = "glColorTableParameterfv")]
            public static extern void ColorTableParameterfv(Enums.ColorTableTargetSGI target, Enums.ColorTableParameterPNameSGI pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glColorTableParameteriv")]
            public static extern void ColorTableParameteriv(Enums.ColorTableTargetSGI target, Enums.ColorTableParameterPNameSGI pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glCopyColorTable")]
            public static extern void CopyColorTable(Enums.ColorTableTargetSGI target, Enums.PixelInternalFormat internalformat, int x, int y, int width);

            [DllImport(_dll_name, EntryPoint = "glGetColorTable")]
            public static extern void GetColorTable(Enums.ColorTableTargetSGI target, Enums.PixelFormat format, Enums.PixelType type, out object table);

            [DllImport(_dll_name, EntryPoint = "glGetColorTableParameterfv")]
            public static extern void GetColorTableParameterfv(Enums.ColorTableTargetSGI target, Enums.GetColorTableParameterPNameSGI pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetColorTableParameteriv")]
            public static extern void GetColorTableParameteriv(Enums.ColorTableTargetSGI target, Enums.GetColorTableParameterPNameSGI pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glColorSubTable")]
            public static extern void ColorSubTable(Enums.ColorTableTargetSGI target, int start, int count, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object data);

            [DllImport(_dll_name, EntryPoint = "glCopyColorSubTable")]
            public static extern void CopyColorSubTable(Enums.ColorTableTargetSGI target, int start, int x, int y, int width);

            [DllImport(_dll_name, EntryPoint = "glConvolutionFilter1D")]
            public static extern void ConvolutionFilter1D(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, int width, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object image);

            [DllImport(_dll_name, EntryPoint = "glConvolutionFilter2D")]
            public static extern void ConvolutionFilter2D(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, int width, int height, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object image);

            [DllImport(_dll_name, EntryPoint = "glConvolutionParameterf")]
            public static extern void ConvolutionParameterf(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, float parameters);

            [DllImport(_dll_name, EntryPoint = "glConvolutionParameterfv")]
            public static extern void ConvolutionParameterfv(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glConvolutionParameteri")]
            public static extern void ConvolutionParameteri(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, int parameters);

            [DllImport(_dll_name, EntryPoint = "glConvolutionParameteriv")]
            public static extern void ConvolutionParameteriv(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glCopyConvolutionFilter1D")]
            public static extern void CopyConvolutionFilter1D(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, int x, int y, int width);

            [DllImport(_dll_name, EntryPoint = "glCopyConvolutionFilter2D")]
            public static extern void CopyConvolutionFilter2D(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, int x, int y, int width, int height);

            [DllImport(_dll_name, EntryPoint = "glGetConvolutionFilter")]
            public static extern void GetConvolutionFilter(Enums.ConvolutionTargetEXT target, Enums.PixelFormat format, Enums.PixelType type, out object image);

            [DllImport(_dll_name, EntryPoint = "glGetConvolutionParameterfv")]
            public static extern void GetConvolutionParameterfv(Enums.ConvolutionTargetEXT target, Enums.GetConvolutionParameter pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetConvolutionParameteriv")]
            public static extern void GetConvolutionParameteriv(Enums.ConvolutionTargetEXT target, Enums.GetConvolutionParameter pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetSeparableFilter")]
            public static extern void GetSeparableFilter(Enums.SeparableTargetEXT target, Enums.PixelFormat format, Enums.PixelType type, out object row, out object column, out object span);

            [DllImport(_dll_name, EntryPoint = "glSeparableFilter2D")]
            public static extern void SeparableFilter2D(Enums.SeparableTargetEXT target, Enums.PixelInternalFormat internalformat, int width, int height, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object row, [MarshalAs(UnmanagedType.AsAny)] object column);

            [DllImport(_dll_name, EntryPoint = "glGetHistogram")]
            public static extern void GetHistogram(Enums.HistogramTargetEXT target, bool reset, Enums.PixelFormat format, Enums.PixelType type, out object values);

            [DllImport(_dll_name, EntryPoint = "glGetHistogramParameterfv")]
            public static extern void GetHistogramParameterfv(Enums.HistogramTargetEXT target, Enums.GetHistogramParameterPNameEXT pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetHistogramParameteriv")]
            public static extern void GetHistogramParameteriv(Enums.HistogramTargetEXT target, Enums.GetHistogramParameterPNameEXT pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetMinmax")]
            public static extern void GetMinmax(Enums.MinmaxTargetEXT target, bool reset, Enums.PixelFormat format, Enums.PixelType type, out object values);

            [DllImport(_dll_name, EntryPoint = "glGetMinmaxParameterfv")]
            public static extern void GetMinmaxParameterfv(Enums.MinmaxTargetEXT target, Enums.GetMinmaxParameterPNameEXT pname, out float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glGetMinmaxParameteriv")]
            public static extern void GetMinmaxParameteriv(Enums.MinmaxTargetEXT target, Enums.GetMinmaxParameterPNameEXT pname, out int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glHistogram")]
            public static extern void Histogram(Enums.HistogramTargetEXT target, int width, Enums.PixelInternalFormat internalformat, bool sink);

            [DllImport(_dll_name, EntryPoint = "glMinmax")]
            public static extern void Minmax(Enums.MinmaxTargetEXT target, Enums.PixelInternalFormat internalformat, bool sink);

            [DllImport(_dll_name, EntryPoint = "glResetHistogram")]
            public static extern void ResetHistogram(Enums.HistogramTargetEXT target);

            [DllImport(_dll_name, EntryPoint = "glResetMinmax")]
            public static extern void ResetMinmax(Enums.MinmaxTargetEXT target);

            [DllImport(_dll_name, EntryPoint = "glTexImage3D")]
            public static extern void TexImage3D(Enums.TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);

            [DllImport(_dll_name, EntryPoint = "glTexSubImage3D")]
            public static extern void TexSubImage3D(Enums.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, Enums.PixelFormat format, Enums.PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);

            [DllImport(_dll_name, EntryPoint = "glCopyTexSubImage3D")]
            public static extern void CopyTexSubImage3D(Enums.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

            [DllImport(_dll_name, EntryPoint = "glActiveTexture")]
            public static extern void ActiveTexture(uint texture);

            [DllImport(_dll_name, EntryPoint = "glClientActiveTexture")]
            public static extern void ClientActiveTexture(uint texture);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1d")]
            public static extern void MultiTexCoord1d(uint target, double s);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1dv")]
            public static extern void MultiTexCoord1dv(uint target, double[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1f")]
            public static extern void MultiTexCoord1f(uint target, float s);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1fv")]
            public static extern void MultiTexCoord1fv(uint target, float[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1i")]
            public static extern void MultiTexCoord1i(uint target, int s);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1iv")]
            public static extern void MultiTexCoord1iv(uint target, int[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1s")]
            public static extern void MultiTexCoord1s(uint target, short s);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord1sv")]
            public static extern void MultiTexCoord1sv(uint target, short[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2d")]
            public static extern void MultiTexCoord2d(uint target, double s, double t);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2dv")]
            public static extern void MultiTexCoord2dv(uint target, double[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2f")]
            public static extern void MultiTexCoord2f(uint target, float s, float t);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2fv")]
            public static extern void MultiTexCoord2fv(uint target, float[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2i")]
            public static extern void MultiTexCoord2i(uint target, int s, int t);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2iv")]
            public static extern void MultiTexCoord2iv(uint target, int[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2s")]
            public static extern void MultiTexCoord2s(uint target, short s, short t);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord2sv")]
            public static extern void MultiTexCoord2sv(uint target, short[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3d")]
            public static extern void MultiTexCoord3d(uint target, double s, double t, double r);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3dv")]
            public static extern void MultiTexCoord3dv(uint target, double[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3f")]
            public static extern void MultiTexCoord3f(uint target, float s, float t, float r);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3fv")]
            public static extern void MultiTexCoord3fv(uint target, float[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3i")]
            public static extern void MultiTexCoord3i(uint target, int s, int t, int r);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3iv")]
            public static extern void MultiTexCoord3iv(uint target, int[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3s")]
            public static extern void MultiTexCoord3s(uint target, short s, short t, short r);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord3sv")]
            public static extern void MultiTexCoord3sv(uint target, short[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4d")]
            public static extern void MultiTexCoord4d(uint target, double s, double t, double r, double q);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4dv")]
            public static extern void MultiTexCoord4dv(uint target, double[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4f")]
            public static extern void MultiTexCoord4f(uint target, float s, float t, float r, float q);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4fv")]
            public static extern void MultiTexCoord4fv(uint target, float[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4i")]
            public static extern void MultiTexCoord4i(uint target, int s, int t, int r, int q);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4iv")]
            public static extern void MultiTexCoord4iv(uint target, int[] v);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4s")]
            public static extern void MultiTexCoord4s(uint target, short s, short t, short r, short q);

            [DllImport(_dll_name, EntryPoint = "glMultiTexCoord4sv")]
            public static extern void MultiTexCoord4sv(uint target, short[] v);

            [DllImport(_dll_name, EntryPoint = "glLoadTransposeMatrixf")]
            public static extern void LoadTransposeMatrixf(float[] m);

            [DllImport(_dll_name, EntryPoint = "glLoadTransposeMatrixd")]
            public static extern void LoadTransposeMatrixd(double[] m);

            [DllImport(_dll_name, EntryPoint = "glMultTransposeMatrixf")]
            public static extern void MultTransposeMatrixf(float[] m);

            [DllImport(_dll_name, EntryPoint = "glMultTransposeMatrixd")]
            public static extern void MultTransposeMatrixd(double[] m);

            [DllImport(_dll_name, EntryPoint = "glSampleCoverage")]
            public static extern void SampleCoverage(float value, bool invert);

            [DllImport(_dll_name, EntryPoint = "glCompressedTexImage3D")]
            public static extern void CompressedTexImage3D(Enums.TextureTarget target, int level, Enums.PixelInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data);

            [DllImport(_dll_name, EntryPoint = "glCompressedTexImage2D")]
            public static extern void CompressedTexImage2D(Enums.TextureTarget target, int level, Enums.PixelInternalFormat internalformat, int width, int height, int border, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data);

            [DllImport(_dll_name, EntryPoint = "glCompressedTexImage1D")]
            public static extern void CompressedTexImage1D(Enums.TextureTarget target, int level, Enums.PixelInternalFormat internalformat, int width, int border, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data);

            [DllImport(_dll_name, EntryPoint = "glCompressedTexSubImage3D")]
            public static extern void CompressedTexSubImage3D(Enums.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, Enums.PixelFormat format, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data);

            [DllImport(_dll_name, EntryPoint = "glCompressedTexSubImage2D")]
            public static extern void CompressedTexSubImage2D(Enums.TextureTarget target, int level, int xoffset, int yoffset, int width, int height, Enums.PixelFormat format, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data);

            [DllImport(_dll_name, EntryPoint = "glCompressedTexSubImage1D")]
            public static extern void CompressedTexSubImage1D(Enums.TextureTarget target, int level, int xoffset, int width, Enums.PixelFormat format, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data);

            [DllImport(_dll_name, EntryPoint = "glGetCompressedTexImage")]
            public static extern void GetCompressedTexImage(Enums.TextureTarget target, int level, out object img);

            [DllImport(_dll_name, EntryPoint = "glBlendFuncSeparate")]
            public static extern void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

            [DllImport(_dll_name, EntryPoint = "glFogCoordf")]
            public static extern void FogCoordf(float coord);

            [DllImport(_dll_name, EntryPoint = "glFogCoordfv")]
            public static extern void FogCoordfv(float[] coord);

            [DllImport(_dll_name, EntryPoint = "glFogCoordd")]
            public static extern void FogCoordd(double coord);

            [DllImport(_dll_name, EntryPoint = "glFogCoorddv")]
            public static extern void FogCoorddv(double[] coord);

            [DllImport(_dll_name, EntryPoint = "glFogCoordPointer")]
            public static extern void FogCoordPointer(uint type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glMultiDrawArrays")]
            public static extern void MultiDrawArrays(Enums.BeginMode mode, out int[] first, out int[] count, int primcount);

            [DllImport(_dll_name, EntryPoint = "glMultiDrawElements")]
            public static extern void MultiDrawElements(Enums.BeginMode mode, int[] count, uint type, [MarshalAs(UnmanagedType.AsAny)] object indices, int primcount);

            [DllImport(_dll_name, EntryPoint = "glPointParameterf")]
            public static extern void PointParameterf(Enums.PointParameterNameSGIS pname, float param);

            [DllImport(_dll_name, EntryPoint = "glPointParameterfv")]
            public static extern void PointParameterfv(Enums.PointParameterNameSGIS pname, float[] parameters);

            [DllImport(_dll_name, EntryPoint = "glPointParameteri")]
            public static extern void PointParameteri(Enums.PointParameterNameSGIS pname, int param);

            [DllImport(_dll_name, EntryPoint = "glPointParameteriv")]
            public static extern void PointParameteriv(Enums.PointParameterNameSGIS pname, int[] parameters);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3b")]
            public static extern void SecondaryColor3b(byte red, byte green, byte blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3bv")]
            public static extern void SecondaryColor3bv(byte[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3d")]
            public static extern void SecondaryColor3d(double red, double green, double blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3dv")]
            public static extern void SecondaryColor3dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3f")]
            public static extern void SecondaryColor3f(float red, float green, float blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3fv")]
            public static extern void SecondaryColor3fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3i")]
            public static extern void SecondaryColor3i(int red, int green, int blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3iv")]
            public static extern void SecondaryColor3iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3s")]
            public static extern void SecondaryColor3s(short red, short green, short blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3sv")]
            public static extern void SecondaryColor3sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3ub")]
            public static extern void SecondaryColor3ub(byte red, byte green, byte blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3ubv")]
            public static extern void SecondaryColor3ubv(byte[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3ui")]
            public static extern void SecondaryColor3ui(uint red, uint green, uint blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3uiv")]
            public static extern void SecondaryColor3uiv(uint[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3us")]
            public static extern void SecondaryColor3us(ushort red, ushort green, ushort blue);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColor3usv")]
            public static extern void SecondaryColor3usv(ushort[] v);

            [DllImport(_dll_name, EntryPoint = "glSecondaryColorPointer")]
            public static extern void SecondaryColorPointer(int size, Enums.ColorPointerType type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2d")]
            public static extern void WindowPos2d(double x, double y);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2dv")]
            public static extern void WindowPos2dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2f")]
            public static extern void WindowPos2f(float x, float y);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2fv")]
            public static extern void WindowPos2fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2i")]
            public static extern void WindowPos2i(int x, int y);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2iv")]
            public static extern void WindowPos2iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2s")]
            public static extern void WindowPos2s(short x, short y);

            [DllImport(_dll_name, EntryPoint = "glWindowPos2sv")]
            public static extern void WindowPos2sv(short[] v);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3d")]
            public static extern void WindowPos3d(double x, double y, double z);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3dv")]
            public static extern void WindowPos3dv(double[] v);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3f")]
            public static extern void WindowPos3f(float x, float y, float z);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3fv")]
            public static extern void WindowPos3fv(float[] v);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3i")]
            public static extern void WindowPos3i(int x, int y, int z);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3iv")]
            public static extern void WindowPos3iv(int[] v);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3s")]
            public static extern void WindowPos3s(short x, short y, short z);

            [DllImport(_dll_name, EntryPoint = "glWindowPos3sv")]
            public static extern void WindowPos3sv(short[] v);

        }
        #endregion

        #region Load core

        /// <summary>
        /// Loads the core opengl functions (versions 1.0-2.0).
        /// </summary>
        public override void Load()
        {
            if (GL.CoreLoaded) return;
            if (GL.ExtensionsLoaded) return;
            GL.NewList = new GL.Delegates.NewList(Imports.NewList);
            GL.EndList = new GL.Delegates.EndList(Imports.EndList);
            GL.CallList = new GL.Delegates.CallList(Imports.CallList);
            GL.CallLists = new GL.Delegates.CallLists(Imports.CallLists);
            GL.DeleteLists = new GL.Delegates.DeleteLists(Imports.DeleteLists);
            GL.GenLists = new GL.Delegates.GenLists(Imports.GenLists);
            GL.ListBase = new GL.Delegates.ListBase(Imports.ListBase);
            GL.Begin = new GL.Delegates.Begin(Imports.Begin);
            GL.Bitmap = new GL.Delegates.Bitmap(Imports.Bitmap);
            GL.Color3b = new GL.Delegates.Color3b(Imports.Color3b);
            GL.Color3bv = new GL.Delegates.Color3bv(Imports.Color3bv);
            GL.Color3d = new GL.Delegates.Color3d(Imports.Color3d);
            GL.Color3dv = new GL.Delegates.Color3dv(Imports.Color3dv);
            GL.Color3f = new GL.Delegates.Color3f(Imports.Color3f);
            GL.Color3fv = new GL.Delegates.Color3fv(Imports.Color3fv);
            GL.Color3i = new GL.Delegates.Color3i(Imports.Color3i);
            GL.Color3iv = new GL.Delegates.Color3iv(Imports.Color3iv);
            GL.Color3s = new GL.Delegates.Color3s(Imports.Color3s);
            GL.Color3sv = new GL.Delegates.Color3sv(Imports.Color3sv);
            GL.Color3ub = new GL.Delegates.Color3ub(Imports.Color3ub);
            GL.Color3ubv = new GL.Delegates.Color3ubv(Imports.Color3ubv);
            GL.Color3ui = new GL.Delegates.Color3ui(Imports.Color3ui);
            GL.Color3uiv = new GL.Delegates.Color3uiv(Imports.Color3uiv);
            GL.Color3us = new GL.Delegates.Color3us(Imports.Color3us);
            GL.Color3usv = new GL.Delegates.Color3usv(Imports.Color3usv);
            GL.Color4b = new GL.Delegates.Color4b(Imports.Color4b);
            GL.Color4bv = new GL.Delegates.Color4bv(Imports.Color4bv);
            GL.Color4d = new GL.Delegates.Color4d(Imports.Color4d);
            GL.Color4dv = new GL.Delegates.Color4dv(Imports.Color4dv);
            GL.Color4f = new GL.Delegates.Color4f(Imports.Color4f);
            GL.Color4fv = new GL.Delegates.Color4fv(Imports.Color4fv);
            GL.Color4i = new GL.Delegates.Color4i(Imports.Color4i);
            GL.Color4iv = new GL.Delegates.Color4iv(Imports.Color4iv);
            GL.Color4s = new GL.Delegates.Color4s(Imports.Color4s);
            GL.Color4sv = new GL.Delegates.Color4sv(Imports.Color4sv);
            GL.Color4ub = new GL.Delegates.Color4ub(Imports.Color4ub);
            GL.Color4ubv = new GL.Delegates.Color4ubv(Imports.Color4ubv);
            GL.Color4ui = new GL.Delegates.Color4ui(Imports.Color4ui);
            GL.Color4uiv = new GL.Delegates.Color4uiv(Imports.Color4uiv);
            GL.Color4us = new GL.Delegates.Color4us(Imports.Color4us);
            GL.Color4usv = new GL.Delegates.Color4usv(Imports.Color4usv);
            GL.EdgeFlag = new GL.Delegates.EdgeFlag(Imports.EdgeFlag);
            GL.EdgeFlagv = new GL.Delegates.EdgeFlagv(Imports.EdgeFlagv);
            GL.End = new GL.Delegates.End(Imports.End);
            GL.Indexd = new GL.Delegates.Indexd(Imports.Indexd);
            GL.Indexdv = new GL.Delegates.Indexdv(Imports.Indexdv);
            GL.Indexf = new GL.Delegates.Indexf(Imports.Indexf);
            GL.Indexfv = new GL.Delegates.Indexfv(Imports.Indexfv);
            GL.Indexi = new GL.Delegates.Indexi(Imports.Indexi);
            GL.Indexiv = new GL.Delegates.Indexiv(Imports.Indexiv);
            GL.Indexs = new GL.Delegates.Indexs(Imports.Indexs);
            GL.Indexsv = new GL.Delegates.Indexsv(Imports.Indexsv);
            GL.Normal3b = new GL.Delegates.Normal3b(Imports.Normal3b);
            GL.Normal3bv = new GL.Delegates.Normal3bv(Imports.Normal3bv);
            GL.Normal3d = new GL.Delegates.Normal3d(Imports.Normal3d);
            GL.Normal3dv = new GL.Delegates.Normal3dv(Imports.Normal3dv);
            GL.Normal3f = new GL.Delegates.Normal3f(Imports.Normal3f);
            GL.Normal3fv = new GL.Delegates.Normal3fv(Imports.Normal3fv);
            GL.Normal3i = new GL.Delegates.Normal3i(Imports.Normal3i);
            GL.Normal3iv = new GL.Delegates.Normal3iv(Imports.Normal3iv);
            GL.Normal3s = new GL.Delegates.Normal3s(Imports.Normal3s);
            GL.Normal3sv = new GL.Delegates.Normal3sv(Imports.Normal3sv);
            GL.RasterPos2d = new GL.Delegates.RasterPos2d(Imports.RasterPos2d);
            GL.RasterPos2dv = new GL.Delegates.RasterPos2dv(Imports.RasterPos2dv);
            GL.RasterPos2f = new GL.Delegates.RasterPos2f(Imports.RasterPos2f);
            GL.RasterPos2fv = new GL.Delegates.RasterPos2fv(Imports.RasterPos2fv);
            GL.RasterPos2i = new GL.Delegates.RasterPos2i(Imports.RasterPos2i);
            GL.RasterPos2iv = new GL.Delegates.RasterPos2iv(Imports.RasterPos2iv);
            GL.RasterPos2s = new GL.Delegates.RasterPos2s(Imports.RasterPos2s);
            GL.RasterPos2sv = new GL.Delegates.RasterPos2sv(Imports.RasterPos2sv);
            GL.RasterPos3d = new GL.Delegates.RasterPos3d(Imports.RasterPos3d);
            GL.RasterPos3dv = new GL.Delegates.RasterPos3dv(Imports.RasterPos3dv);
            GL.RasterPos3f = new GL.Delegates.RasterPos3f(Imports.RasterPos3f);
            GL.RasterPos3fv = new GL.Delegates.RasterPos3fv(Imports.RasterPos3fv);
            GL.RasterPos3i = new GL.Delegates.RasterPos3i(Imports.RasterPos3i);
            GL.RasterPos3iv = new GL.Delegates.RasterPos3iv(Imports.RasterPos3iv);
            GL.RasterPos3s = new GL.Delegates.RasterPos3s(Imports.RasterPos3s);
            GL.RasterPos3sv = new GL.Delegates.RasterPos3sv(Imports.RasterPos3sv);
            GL.RasterPos4d = new GL.Delegates.RasterPos4d(Imports.RasterPos4d);
            GL.RasterPos4dv = new GL.Delegates.RasterPos4dv(Imports.RasterPos4dv);
            GL.RasterPos4f = new GL.Delegates.RasterPos4f(Imports.RasterPos4f);
            GL.RasterPos4fv = new GL.Delegates.RasterPos4fv(Imports.RasterPos4fv);
            GL.RasterPos4i = new GL.Delegates.RasterPos4i(Imports.RasterPos4i);
            GL.RasterPos4iv = new GL.Delegates.RasterPos4iv(Imports.RasterPos4iv);
            GL.RasterPos4s = new GL.Delegates.RasterPos4s(Imports.RasterPos4s);
            GL.RasterPos4sv = new GL.Delegates.RasterPos4sv(Imports.RasterPos4sv);
            GL.Rectd = new GL.Delegates.Rectd(Imports.Rectd);
            GL.Rectdv = new GL.Delegates.Rectdv(Imports.Rectdv);
            GL.Rectf = new GL.Delegates.Rectf(Imports.Rectf);
            GL.Rectfv = new GL.Delegates.Rectfv(Imports.Rectfv);
            GL.Recti = new GL.Delegates.Recti(Imports.Recti);
            GL.Rectiv = new GL.Delegates.Rectiv(Imports.Rectiv);
            GL.Rects = new GL.Delegates.Rects(Imports.Rects);
            GL.Rectsv = new GL.Delegates.Rectsv(Imports.Rectsv);
            GL.TexCoord1d = new GL.Delegates.TexCoord1d(Imports.TexCoord1d);
            GL.TexCoord1dv = new GL.Delegates.TexCoord1dv(Imports.TexCoord1dv);
            GL.TexCoord1f = new GL.Delegates.TexCoord1f(Imports.TexCoord1f);
            GL.TexCoord1fv = new GL.Delegates.TexCoord1fv(Imports.TexCoord1fv);
            GL.TexCoord1i = new GL.Delegates.TexCoord1i(Imports.TexCoord1i);
            GL.TexCoord1iv = new GL.Delegates.TexCoord1iv(Imports.TexCoord1iv);
            GL.TexCoord1s = new GL.Delegates.TexCoord1s(Imports.TexCoord1s);
            GL.TexCoord1sv = new GL.Delegates.TexCoord1sv(Imports.TexCoord1sv);
            GL.TexCoord2d = new GL.Delegates.TexCoord2d(Imports.TexCoord2d);
            GL.TexCoord2dv = new GL.Delegates.TexCoord2dv(Imports.TexCoord2dv);
            GL.TexCoord2f = new GL.Delegates.TexCoord2f(Imports.TexCoord2f);
            GL.TexCoord2fv = new GL.Delegates.TexCoord2fv(Imports.TexCoord2fv);
            GL.TexCoord2i = new GL.Delegates.TexCoord2i(Imports.TexCoord2i);
            GL.TexCoord2iv = new GL.Delegates.TexCoord2iv(Imports.TexCoord2iv);
            GL.TexCoord2s = new GL.Delegates.TexCoord2s(Imports.TexCoord2s);
            GL.TexCoord2sv = new GL.Delegates.TexCoord2sv(Imports.TexCoord2sv);
            GL.TexCoord3d = new GL.Delegates.TexCoord3d(Imports.TexCoord3d);
            GL.TexCoord3dv = new GL.Delegates.TexCoord3dv(Imports.TexCoord3dv);
            GL.TexCoord3f = new GL.Delegates.TexCoord3f(Imports.TexCoord3f);
            GL.TexCoord3fv = new GL.Delegates.TexCoord3fv(Imports.TexCoord3fv);
            GL.TexCoord3i = new GL.Delegates.TexCoord3i(Imports.TexCoord3i);
            GL.TexCoord3iv = new GL.Delegates.TexCoord3iv(Imports.TexCoord3iv);
            GL.TexCoord3s = new GL.Delegates.TexCoord3s(Imports.TexCoord3s);
            GL.TexCoord3sv = new GL.Delegates.TexCoord3sv(Imports.TexCoord3sv);
            GL.TexCoord4d = new GL.Delegates.TexCoord4d(Imports.TexCoord4d);
            GL.TexCoord4dv = new GL.Delegates.TexCoord4dv(Imports.TexCoord4dv);
            GL.TexCoord4f = new GL.Delegates.TexCoord4f(Imports.TexCoord4f);
            GL.TexCoord4fv = new GL.Delegates.TexCoord4fv(Imports.TexCoord4fv);
            GL.TexCoord4i = new GL.Delegates.TexCoord4i(Imports.TexCoord4i);
            GL.TexCoord4iv = new GL.Delegates.TexCoord4iv(Imports.TexCoord4iv);
            GL.TexCoord4s = new GL.Delegates.TexCoord4s(Imports.TexCoord4s);
            GL.TexCoord4sv = new GL.Delegates.TexCoord4sv(Imports.TexCoord4sv);
            GL.Vertex2d = new GL.Delegates.Vertex2d(Imports.Vertex2d);
            GL.Vertex2dv = new GL.Delegates.Vertex2dv(Imports.Vertex2dv);
            GL.Vertex2f = new GL.Delegates.Vertex2f(Imports.Vertex2f);
            GL.Vertex2fv = new GL.Delegates.Vertex2fv(Imports.Vertex2fv);
            GL.Vertex2i = new GL.Delegates.Vertex2i(Imports.Vertex2i);
            GL.Vertex2iv = new GL.Delegates.Vertex2iv(Imports.Vertex2iv);
            GL.Vertex2s = new GL.Delegates.Vertex2s(Imports.Vertex2s);
            GL.Vertex2sv = new GL.Delegates.Vertex2sv(Imports.Vertex2sv);
            GL.Vertex3d = new GL.Delegates.Vertex3d(Imports.Vertex3d);
            GL.Vertex3dv = new GL.Delegates.Vertex3dv(Imports.Vertex3dv);
            GL.Vertex3f = new GL.Delegates.Vertex3f(Imports.Vertex3f);
            GL.Vertex3fv = new GL.Delegates.Vertex3fv(Imports.Vertex3fv);
            GL.Vertex3i = new GL.Delegates.Vertex3i(Imports.Vertex3i);
            GL.Vertex3iv = new GL.Delegates.Vertex3iv(Imports.Vertex3iv);
            GL.Vertex3s = new GL.Delegates.Vertex3s(Imports.Vertex3s);
            GL.Vertex3sv = new GL.Delegates.Vertex3sv(Imports.Vertex3sv);
            GL.Vertex4d = new GL.Delegates.Vertex4d(Imports.Vertex4d);
            GL.Vertex4dv = new GL.Delegates.Vertex4dv(Imports.Vertex4dv);
            GL.Vertex4f = new GL.Delegates.Vertex4f(Imports.Vertex4f);
            GL.Vertex4fv = new GL.Delegates.Vertex4fv(Imports.Vertex4fv);
            GL.Vertex4i = new GL.Delegates.Vertex4i(Imports.Vertex4i);
            GL.Vertex4iv = new GL.Delegates.Vertex4iv(Imports.Vertex4iv);
            GL.Vertex4s = new GL.Delegates.Vertex4s(Imports.Vertex4s);
            GL.Vertex4sv = new GL.Delegates.Vertex4sv(Imports.Vertex4sv);
            GL.ClipPlane = new GL.Delegates.ClipPlane(Imports.ClipPlane);
            GL.ColorMaterial = new GL.Delegates.ColorMaterial(Imports.ColorMaterial);
            GL.CullFace = new GL.Delegates.CullFace(Imports.CullFace);
            GL.Fogf = new GL.Delegates.Fogf(Imports.Fogf);
            GL.Fogfv = new GL.Delegates.Fogfv(Imports.Fogfv);
            GL.Fogi = new GL.Delegates.Fogi(Imports.Fogi);
            GL.Fogiv = new GL.Delegates.Fogiv(Imports.Fogiv);
            GL.FrontFace = new GL.Delegates.FrontFace(Imports.FrontFace);
            GL.Hint = new GL.Delegates.Hint(Imports.Hint);
            GL.Lightf = new GL.Delegates.Lightf(Imports.Lightf);
            GL.Lightfv = new GL.Delegates.Lightfv(Imports.Lightfv);
            GL.Lighti = new GL.Delegates.Lighti(Imports.Lighti);
            GL.Lightiv = new GL.Delegates.Lightiv(Imports.Lightiv);
            GL.LightModelf = new GL.Delegates.LightModelf(Imports.LightModelf);
            GL.LightModelfv = new GL.Delegates.LightModelfv(Imports.LightModelfv);
            GL.LightModeli = new GL.Delegates.LightModeli(Imports.LightModeli);
            GL.LightModeliv = new GL.Delegates.LightModeliv(Imports.LightModeliv);
            GL.LineStipple = new GL.Delegates.LineStipple(Imports.LineStipple);
            GL.LineWidth = new GL.Delegates.LineWidth(Imports.LineWidth);
            GL.Materialf = new GL.Delegates.Materialf(Imports.Materialf);
            GL.Materialfv = new GL.Delegates.Materialfv(Imports.Materialfv);
            GL.Materiali = new GL.Delegates.Materiali(Imports.Materiali);
            GL.Materialiv = new GL.Delegates.Materialiv(Imports.Materialiv);
            GL.PointSize = new GL.Delegates.PointSize(Imports.PointSize);
            GL.PolygonMode = new GL.Delegates.PolygonMode(Imports.PolygonMode);
            GL.PolygonStipple = new GL.Delegates.PolygonStipple(Imports.PolygonStipple);
            GL.Scissor = new GL.Delegates.Scissor(Imports.Scissor);
            GL.ShadeModel = new GL.Delegates.ShadeModel(Imports.ShadeModel);
            GL.TexParameterf = new GL.Delegates.TexParameterf(Imports.TexParameterf);
            GL.TexParameterfv = new GL.Delegates.TexParameterfv(Imports.TexParameterfv);
            GL.TexParameteri = new GL.Delegates.TexParameteri(Imports.TexParameteri);
            GL.TexParameteriv = new GL.Delegates.TexParameteriv(Imports.TexParameteriv);
            GL.TexImage1D = new GL.Delegates.TexImage1D(Imports.TexImage1D);
            GL.TexImage2D = new GL.Delegates.TexImage2D(Imports.TexImage2D);
            GL.TexEnvf = new GL.Delegates.TexEnvf(Imports.TexEnvf);
            GL.TexEnvfv = new GL.Delegates.TexEnvfv(Imports.TexEnvfv);
            GL.TexEnvi = new GL.Delegates.TexEnvi(Imports.TexEnvi);
            GL.TexEnviv = new GL.Delegates.TexEnviv(Imports.TexEnviv);
            GL.TexGend = new GL.Delegates.TexGend(Imports.TexGend);
            GL.TexGendv = new GL.Delegates.TexGendv(Imports.TexGendv);
            GL.TexGenf = new GL.Delegates.TexGenf(Imports.TexGenf);
            GL.TexGenfv = new GL.Delegates.TexGenfv(Imports.TexGenfv);
            GL.TexGeni = new GL.Delegates.TexGeni(Imports.TexGeni);
            GL.TexGeniv = new GL.Delegates.TexGeniv(Imports.TexGeniv);
            GL.FeedbackBuffer = new GL.Delegates.FeedbackBuffer(Imports.FeedbackBuffer);
            GL.SelectBuffer = new GL.Delegates.SelectBuffer(Imports.SelectBuffer);
            GL.RenderMode = new GL.Delegates.RenderMode(Imports.RenderMode);
            GL.InitNames = new GL.Delegates.InitNames(Imports.InitNames);
            GL.LoadName = new GL.Delegates.LoadName(Imports.LoadName);
            GL.PassThrough = new GL.Delegates.PassThrough(Imports.PassThrough);
            GL.PopName = new GL.Delegates.PopName(Imports.PopName);
            GL.PushName = new GL.Delegates.PushName(Imports.PushName);
            GL.DrawBuffer = new GL.Delegates.DrawBuffer(Imports.DrawBuffer);
            GL.Clear = new GL.Delegates.Clear(Imports.Clear);
            GL.ClearAccum = new GL.Delegates.ClearAccum(Imports.ClearAccum);
            GL.ClearIndex = new GL.Delegates.ClearIndex(Imports.ClearIndex);
            GL.ClearColor = new GL.Delegates.ClearColor(Imports.ClearColor);
            GL.ClearStencil = new GL.Delegates.ClearStencil(Imports.ClearStencil);
            GL.ClearDepth = new GL.Delegates.ClearDepth(Imports.ClearDepth);
            GL.StencilMask = new GL.Delegates.StencilMask(Imports.StencilMask);
            GL.ColorMask = new GL.Delegates.ColorMask(Imports.ColorMask);
            GL.DepthMask = new GL.Delegates.DepthMask(Imports.DepthMask);
            GL.IndexMask = new GL.Delegates.IndexMask(Imports.IndexMask);
            GL.Accum = new GL.Delegates.Accum(Imports.Accum);
            GL.Disable = new GL.Delegates.Disable(Imports.Disable);
            GL.Enable = new GL.Delegates.Enable(Imports.Enable);
            GL.Finish = new GL.Delegates.Finish(Imports.Finish);
            GL.Flush = new GL.Delegates.Flush(Imports.Flush);
            GL.PopAttrib = new GL.Delegates.PopAttrib(Imports.PopAttrib);
            GL.PushAttrib = new GL.Delegates.PushAttrib(Imports.PushAttrib);
            GL.Map1d = new GL.Delegates.Map1d(Imports.Map1d);
            GL.Map1f = new GL.Delegates.Map1f(Imports.Map1f);
            GL.Map2d = new GL.Delegates.Map2d(Imports.Map2d);
            GL.Map2f = new GL.Delegates.Map2f(Imports.Map2f);
            GL.MapGrid1d = new GL.Delegates.MapGrid1d(Imports.MapGrid1d);
            GL.MapGrid1f = new GL.Delegates.MapGrid1f(Imports.MapGrid1f);
            GL.MapGrid2d = new GL.Delegates.MapGrid2d(Imports.MapGrid2d);
            GL.MapGrid2f = new GL.Delegates.MapGrid2f(Imports.MapGrid2f);
            GL.EvalCoord1d = new GL.Delegates.EvalCoord1d(Imports.EvalCoord1d);
            GL.EvalCoord1dv = new GL.Delegates.EvalCoord1dv(Imports.EvalCoord1dv);
            GL.EvalCoord1f = new GL.Delegates.EvalCoord1f(Imports.EvalCoord1f);
            GL.EvalCoord1fv = new GL.Delegates.EvalCoord1fv(Imports.EvalCoord1fv);
            GL.EvalCoord2d = new GL.Delegates.EvalCoord2d(Imports.EvalCoord2d);
            GL.EvalCoord2dv = new GL.Delegates.EvalCoord2dv(Imports.EvalCoord2dv);
            GL.EvalCoord2f = new GL.Delegates.EvalCoord2f(Imports.EvalCoord2f);
            GL.EvalCoord2fv = new GL.Delegates.EvalCoord2fv(Imports.EvalCoord2fv);
            GL.EvalMesh1 = new GL.Delegates.EvalMesh1(Imports.EvalMesh1);
            GL.EvalPoint1 = new GL.Delegates.EvalPoint1(Imports.EvalPoint1);
            GL.EvalMesh2 = new GL.Delegates.EvalMesh2(Imports.EvalMesh2);
            GL.EvalPoint2 = new GL.Delegates.EvalPoint2(Imports.EvalPoint2);
            GL.AlphaFunc = new GL.Delegates.AlphaFunc(Imports.AlphaFunc);
            GL.BlendFunc = new GL.Delegates.BlendFunc(Imports.BlendFunc);
            GL.LogicOp = new GL.Delegates.LogicOp(Imports.LogicOp);
            GL.StencilFunc = new GL.Delegates.StencilFunc(Imports.StencilFunc);
            GL.StencilOp = new GL.Delegates.StencilOp(Imports.StencilOp);
            GL.DepthFunc = new GL.Delegates.DepthFunc(Imports.DepthFunc);
            GL.PixelZoom = new GL.Delegates.PixelZoom(Imports.PixelZoom);
            GL.PixelTransferf = new GL.Delegates.PixelTransferf(Imports.PixelTransferf);
            GL.PixelTransferi = new GL.Delegates.PixelTransferi(Imports.PixelTransferi);
            GL.PixelStoref = new GL.Delegates.PixelStoref(Imports.PixelStoref);
            GL.PixelStorei = new GL.Delegates.PixelStorei(Imports.PixelStorei);
            GL.PixelMapfv = new GL.Delegates.PixelMapfv(Imports.PixelMapfv);
            GL.PixelMapuiv = new GL.Delegates.PixelMapuiv(Imports.PixelMapuiv);
            GL.PixelMapusv = new GL.Delegates.PixelMapusv(Imports.PixelMapusv);
            GL.ReadBuffer = new GL.Delegates.ReadBuffer(Imports.ReadBuffer);
            GL.CopyPixels = new GL.Delegates.CopyPixels(Imports.CopyPixels);
            GL.ReadPixels = new GL.Delegates.ReadPixels(Imports.ReadPixels);
            GL.DrawPixels = new GL.Delegates.DrawPixels(Imports.DrawPixels);
            GL.GetBooleanv = new GL.Delegates.GetBooleanv(Imports.GetBooleanv);
            GL.GetClipPlane = new GL.Delegates.GetClipPlane(Imports.GetClipPlane);
            GL.GetDoublev = new GL.Delegates.GetDoublev(Imports.GetDoublev);
            GL.GetError = new GL.Delegates.GetError(Imports.GetError);
            GL.GetFloatv = new GL.Delegates.GetFloatv(Imports.GetFloatv);
            GL.GetIntegerv = new GL.Delegates.GetIntegerv(Imports.GetIntegerv);
            GL.GetLightfv = new GL.Delegates.GetLightfv(Imports.GetLightfv);
            GL.GetLightiv = new GL.Delegates.GetLightiv(Imports.GetLightiv);
            GL.GetMapdv = new GL.Delegates.GetMapdv(Imports.GetMapdv);
            GL.GetMapfv = new GL.Delegates.GetMapfv(Imports.GetMapfv);
            GL.GetMapiv = new GL.Delegates.GetMapiv(Imports.GetMapiv);
            GL.GetMaterialfv = new GL.Delegates.GetMaterialfv(Imports.GetMaterialfv);
            GL.GetMaterialiv = new GL.Delegates.GetMaterialiv(Imports.GetMaterialiv);
            GL.GetPixelMapfv = new GL.Delegates.GetPixelMapfv(Imports.GetPixelMapfv);
            GL.GetPixelMapuiv = new GL.Delegates.GetPixelMapuiv(Imports.GetPixelMapuiv);
            GL.GetPixelMapusv = new GL.Delegates.GetPixelMapusv(Imports.GetPixelMapusv);
            GL.GetPolygonStipple = new GL.Delegates.GetPolygonStipple(Imports.GetPolygonStipple);
            GL.GetString = new GL.Delegates.GetString(Imports.GetString);
            GL.GetTexEnvfv = new GL.Delegates.GetTexEnvfv(Imports.GetTexEnvfv);
            GL.GetTexEnviv = new GL.Delegates.GetTexEnviv(Imports.GetTexEnviv);
            GL.GetTexGendv = new GL.Delegates.GetTexGendv(Imports.GetTexGendv);
            GL.GetTexGenfv = new GL.Delegates.GetTexGenfv(Imports.GetTexGenfv);
            GL.GetTexGeniv = new GL.Delegates.GetTexGeniv(Imports.GetTexGeniv);
            GL.GetTexImage = new GL.Delegates.GetTexImage(Imports.GetTexImage);
            GL.GetTexParameterfv = new GL.Delegates.GetTexParameterfv(Imports.GetTexParameterfv);
            GL.GetTexParameteriv = new GL.Delegates.GetTexParameteriv(Imports.GetTexParameteriv);
            GL.GetTexLevelParameterfv = new GL.Delegates.GetTexLevelParameterfv(Imports.GetTexLevelParameterfv);
            GL.GetTexLevelParameteriv = new GL.Delegates.GetTexLevelParameteriv(Imports.GetTexLevelParameteriv);
            GL.IsEnabled = new GL.Delegates.IsEnabled(Imports.IsEnabled);
            GL.IsList = new GL.Delegates.IsList(Imports.IsList);
            GL.DepthRange = new GL.Delegates.DepthRange(Imports.DepthRange);
            GL.Frustum = new GL.Delegates.Frustum(Imports.Frustum);
            GL.LoadIdentity = new GL.Delegates.LoadIdentity(Imports.LoadIdentity);
            GL.LoadMatrixf = new GL.Delegates.LoadMatrixf(Imports.LoadMatrixf);
            GL.LoadMatrixd = new GL.Delegates.LoadMatrixd(Imports.LoadMatrixd);
            GL.MatrixMode = new GL.Delegates.MatrixMode(Imports.MatrixMode);
            GL.MultMatrixf = new GL.Delegates.MultMatrixf(Imports.MultMatrixf);
            GL.MultMatrixd = new GL.Delegates.MultMatrixd(Imports.MultMatrixd);
            GL.Ortho = new GL.Delegates.Ortho(Imports.Ortho);
            GL.PopMatrix = new GL.Delegates.PopMatrix(Imports.PopMatrix);
            GL.PushMatrix = new GL.Delegates.PushMatrix(Imports.PushMatrix);
            GL.Rotated = new GL.Delegates.Rotated(Imports.Rotated);
            GL.Rotatef = new GL.Delegates.Rotatef(Imports.Rotatef);
            GL.Scaled = new GL.Delegates.Scaled(Imports.Scaled);
            GL.Scalef = new GL.Delegates.Scalef(Imports.Scalef);
            GL.Translated = new GL.Delegates.Translated(Imports.Translated);
            GL.Translatef = new GL.Delegates.Translatef(Imports.Translatef);
            GL.Viewport = new GL.Delegates.Viewport(Imports.Viewport);
            GL.ArrayElement = new GL.Delegates.ArrayElement(Imports.ArrayElement);
            GL.ColorPointer = new GL.Delegates.ColorPointer(Imports.ColorPointer);
            GL.DisableClientState = new GL.Delegates.DisableClientState(Imports.DisableClientState);
            GL.DrawArrays = new GL.Delegates.DrawArrays(Imports.DrawArrays);
            GL.DrawElements = new GL.Delegates.DrawElements(Imports.DrawElements);
            GL.EdgeFlagPointer = new GL.Delegates.EdgeFlagPointer(Imports.EdgeFlagPointer);
            GL.EnableClientState = new GL.Delegates.EnableClientState(Imports.EnableClientState);
            GL.GetPointerv = new GL.Delegates.GetPointerv(Imports.GetPointerv);
            GL.IndexPointer = new GL.Delegates.IndexPointer(Imports.IndexPointer);
            GL.InterleavedArrays = new GL.Delegates.InterleavedArrays(Imports.InterleavedArrays);
            GL.NormalPointer = new GL.Delegates.NormalPointer(Imports.NormalPointer);
            GL.TexCoordPointer = new GL.Delegates.TexCoordPointer(Imports.TexCoordPointer);
            GL.VertexPointer = new GL.Delegates.VertexPointer(Imports.VertexPointer);
            GL.PolygonOffset = new GL.Delegates.PolygonOffset(Imports.PolygonOffset);
            GL.CopyTexImage1D = new GL.Delegates.CopyTexImage1D(Imports.CopyTexImage1D);
            GL.CopyTexImage2D = new GL.Delegates.CopyTexImage2D(Imports.CopyTexImage2D);
            GL.CopyTexSubImage1D = new GL.Delegates.CopyTexSubImage1D(Imports.CopyTexSubImage1D);
            GL.CopyTexSubImage2D = new GL.Delegates.CopyTexSubImage2D(Imports.CopyTexSubImage2D);
            GL.TexSubImage1D = new GL.Delegates.TexSubImage1D(Imports.TexSubImage1D);
            GL.TexSubImage2D = new GL.Delegates.TexSubImage2D(Imports.TexSubImage2D);
            GL.AreTexturesResident = new GL.Delegates.AreTexturesResident(Imports.AreTexturesResident);
            GL.BindTexture = new GL.Delegates.BindTexture(Imports.BindTexture);
            GL.DeleteTextures = new GL.Delegates.DeleteTextures(Imports.DeleteTextures);
            GL.GenTextures = new GL.Delegates.GenTextures(Imports.GenTextures);
            GL.IsTexture = new GL.Delegates.IsTexture(Imports.IsTexture);
            GL.PrioritizeTextures = new GL.Delegates.PrioritizeTextures(Imports.PrioritizeTextures);
            GL.Indexub = new GL.Delegates.Indexub(Imports.Indexub);
            GL.Indexubv = new GL.Delegates.Indexubv(Imports.Indexubv);
            GL.PopClientAttrib = new GL.Delegates.PopClientAttrib(Imports.PopClientAttrib);
            GL.PushClientAttrib = new GL.Delegates.PushClientAttrib(Imports.PushClientAttrib);
            GL.BlendColor = new GL.Delegates.BlendColor(Imports.BlendColor);
            GL.BlendEquation = new GL.Delegates.BlendEquation(Imports.BlendEquation);
            GL.DrawRangeElements = new GL.Delegates.DrawRangeElements(Imports.DrawRangeElements);
            GL.ColorTable = new GL.Delegates.ColorTable(Imports.ColorTable);
            GL.ColorTableParameterfv = new GL.Delegates.ColorTableParameterfv(Imports.ColorTableParameterfv);
            GL.ColorTableParameteriv = new GL.Delegates.ColorTableParameteriv(Imports.ColorTableParameteriv);
            GL.CopyColorTable = new GL.Delegates.CopyColorTable(Imports.CopyColorTable);
            GL.GetColorTable = new GL.Delegates.GetColorTable(Imports.GetColorTable);
            GL.GetColorTableParameterfv = new GL.Delegates.GetColorTableParameterfv(Imports.GetColorTableParameterfv);
            GL.GetColorTableParameteriv = new GL.Delegates.GetColorTableParameteriv(Imports.GetColorTableParameteriv);
            GL.ColorSubTable = new GL.Delegates.ColorSubTable(Imports.ColorSubTable);
            GL.CopyColorSubTable = new GL.Delegates.CopyColorSubTable(Imports.CopyColorSubTable);
            GL.ConvolutionFilter1D = new GL.Delegates.ConvolutionFilter1D(Imports.ConvolutionFilter1D);
            GL.ConvolutionFilter2D = new GL.Delegates.ConvolutionFilter2D(Imports.ConvolutionFilter2D);
            GL.ConvolutionParameterf = new GL.Delegates.ConvolutionParameterf(Imports.ConvolutionParameterf);
            GL.ConvolutionParameterfv = new GL.Delegates.ConvolutionParameterfv(Imports.ConvolutionParameterfv);
            GL.ConvolutionParameteri = new GL.Delegates.ConvolutionParameteri(Imports.ConvolutionParameteri);
            GL.ConvolutionParameteriv = new GL.Delegates.ConvolutionParameteriv(Imports.ConvolutionParameteriv);
            GL.CopyConvolutionFilter1D = new GL.Delegates.CopyConvolutionFilter1D(Imports.CopyConvolutionFilter1D);
            GL.CopyConvolutionFilter2D = new GL.Delegates.CopyConvolutionFilter2D(Imports.CopyConvolutionFilter2D);
            GL.GetConvolutionFilter = new GL.Delegates.GetConvolutionFilter(Imports.GetConvolutionFilter);
            GL.GetConvolutionParameterfv = new GL.Delegates.GetConvolutionParameterfv(Imports.GetConvolutionParameterfv);
            GL.GetConvolutionParameteriv = new GL.Delegates.GetConvolutionParameteriv(Imports.GetConvolutionParameteriv);
            GL.GetSeparableFilter = new GL.Delegates.GetSeparableFilter(Imports.GetSeparableFilter);
            GL.SeparableFilter2D = new GL.Delegates.SeparableFilter2D(Imports.SeparableFilter2D);
            GL.GetHistogram = new GL.Delegates.GetHistogram(Imports.GetHistogram);
            GL.GetHistogramParameterfv = new GL.Delegates.GetHistogramParameterfv(Imports.GetHistogramParameterfv);
            GL.GetHistogramParameteriv = new GL.Delegates.GetHistogramParameteriv(Imports.GetHistogramParameteriv);
            GL.GetMinmax = new GL.Delegates.GetMinmax(Imports.GetMinmax);
            GL.GetMinmaxParameterfv = new GL.Delegates.GetMinmaxParameterfv(Imports.GetMinmaxParameterfv);
            GL.GetMinmaxParameteriv = new GL.Delegates.GetMinmaxParameteriv(Imports.GetMinmaxParameteriv);
            GL.Histogram = new GL.Delegates.Histogram(Imports.Histogram);
            GL.Minmax = new GL.Delegates.Minmax(Imports.Minmax);
            GL.ResetHistogram = new GL.Delegates.ResetHistogram(Imports.ResetHistogram);
            GL.ResetMinmax = new GL.Delegates.ResetMinmax(Imports.ResetMinmax);
            GL.TexImage3D = new GL.Delegates.TexImage3D(Imports.TexImage3D);
            GL.TexSubImage3D = new GL.Delegates.TexSubImage3D(Imports.TexSubImage3D);
            GL.CopyTexSubImage3D = new GL.Delegates.CopyTexSubImage3D(Imports.CopyTexSubImage3D);
            GL.ActiveTexture = new GL.Delegates.ActiveTexture(Imports.ActiveTexture);
            GL.ClientActiveTexture = new GL.Delegates.ClientActiveTexture(Imports.ClientActiveTexture);
            GL.MultiTexCoord1d = new GL.Delegates.MultiTexCoord1d(Imports.MultiTexCoord1d);
            GL.MultiTexCoord1dv = new GL.Delegates.MultiTexCoord1dv(Imports.MultiTexCoord1dv);
            GL.MultiTexCoord1f = new GL.Delegates.MultiTexCoord1f(Imports.MultiTexCoord1f);
            GL.MultiTexCoord1fv = new GL.Delegates.MultiTexCoord1fv(Imports.MultiTexCoord1fv);
            GL.MultiTexCoord1i = new GL.Delegates.MultiTexCoord1i(Imports.MultiTexCoord1i);
            GL.MultiTexCoord1iv = new GL.Delegates.MultiTexCoord1iv(Imports.MultiTexCoord1iv);
            GL.MultiTexCoord1s = new GL.Delegates.MultiTexCoord1s(Imports.MultiTexCoord1s);
            GL.MultiTexCoord1sv = new GL.Delegates.MultiTexCoord1sv(Imports.MultiTexCoord1sv);
            GL.MultiTexCoord2d = new GL.Delegates.MultiTexCoord2d(Imports.MultiTexCoord2d);
            GL.MultiTexCoord2dv = new GL.Delegates.MultiTexCoord2dv(Imports.MultiTexCoord2dv);
            GL.MultiTexCoord2f = new GL.Delegates.MultiTexCoord2f(Imports.MultiTexCoord2f);
            GL.MultiTexCoord2fv = new GL.Delegates.MultiTexCoord2fv(Imports.MultiTexCoord2fv);
            GL.MultiTexCoord2i = new GL.Delegates.MultiTexCoord2i(Imports.MultiTexCoord2i);
            GL.MultiTexCoord2iv = new GL.Delegates.MultiTexCoord2iv(Imports.MultiTexCoord2iv);
            GL.MultiTexCoord2s = new GL.Delegates.MultiTexCoord2s(Imports.MultiTexCoord2s);
            GL.MultiTexCoord2sv = new GL.Delegates.MultiTexCoord2sv(Imports.MultiTexCoord2sv);
            GL.MultiTexCoord3d = new GL.Delegates.MultiTexCoord3d(Imports.MultiTexCoord3d);
            GL.MultiTexCoord3dv = new GL.Delegates.MultiTexCoord3dv(Imports.MultiTexCoord3dv);
            GL.MultiTexCoord3f = new GL.Delegates.MultiTexCoord3f(Imports.MultiTexCoord3f);
            GL.MultiTexCoord3fv = new GL.Delegates.MultiTexCoord3fv(Imports.MultiTexCoord3fv);
            GL.MultiTexCoord3i = new GL.Delegates.MultiTexCoord3i(Imports.MultiTexCoord3i);
            GL.MultiTexCoord3iv = new GL.Delegates.MultiTexCoord3iv(Imports.MultiTexCoord3iv);
            GL.MultiTexCoord3s = new GL.Delegates.MultiTexCoord3s(Imports.MultiTexCoord3s);
            GL.MultiTexCoord3sv = new GL.Delegates.MultiTexCoord3sv(Imports.MultiTexCoord3sv);
            GL.MultiTexCoord4d = new GL.Delegates.MultiTexCoord4d(Imports.MultiTexCoord4d);
            GL.MultiTexCoord4dv = new GL.Delegates.MultiTexCoord4dv(Imports.MultiTexCoord4dv);
            GL.MultiTexCoord4f = new GL.Delegates.MultiTexCoord4f(Imports.MultiTexCoord4f);
            GL.MultiTexCoord4fv = new GL.Delegates.MultiTexCoord4fv(Imports.MultiTexCoord4fv);
            GL.MultiTexCoord4i = new GL.Delegates.MultiTexCoord4i(Imports.MultiTexCoord4i);
            GL.MultiTexCoord4iv = new GL.Delegates.MultiTexCoord4iv(Imports.MultiTexCoord4iv);
            GL.MultiTexCoord4s = new GL.Delegates.MultiTexCoord4s(Imports.MultiTexCoord4s);
            GL.MultiTexCoord4sv = new GL.Delegates.MultiTexCoord4sv(Imports.MultiTexCoord4sv);
            GL.LoadTransposeMatrixf = new GL.Delegates.LoadTransposeMatrixf(Imports.LoadTransposeMatrixf);
            GL.LoadTransposeMatrixd = new GL.Delegates.LoadTransposeMatrixd(Imports.LoadTransposeMatrixd);
            GL.MultTransposeMatrixf = new GL.Delegates.MultTransposeMatrixf(Imports.MultTransposeMatrixf);
            GL.MultTransposeMatrixd = new GL.Delegates.MultTransposeMatrixd(Imports.MultTransposeMatrixd);
            GL.SampleCoverage = new GL.Delegates.SampleCoverage(Imports.SampleCoverage);
            GL.CompressedTexImage3D = new GL.Delegates.CompressedTexImage3D(Imports.CompressedTexImage3D);
            GL.CompressedTexImage2D = new GL.Delegates.CompressedTexImage2D(Imports.CompressedTexImage2D);
            GL.CompressedTexImage1D = new GL.Delegates.CompressedTexImage1D(Imports.CompressedTexImage1D);
            GL.CompressedTexSubImage3D = new GL.Delegates.CompressedTexSubImage3D(Imports.CompressedTexSubImage3D);
            GL.CompressedTexSubImage2D = new GL.Delegates.CompressedTexSubImage2D(Imports.CompressedTexSubImage2D);
            GL.CompressedTexSubImage1D = new GL.Delegates.CompressedTexSubImage1D(Imports.CompressedTexSubImage1D);
            GL.GetCompressedTexImage = new GL.Delegates.GetCompressedTexImage(Imports.GetCompressedTexImage);
            GL.BlendFuncSeparate = new GL.Delegates.BlendFuncSeparate(Imports.BlendFuncSeparate);
            GL.FogCoordf = new GL.Delegates.FogCoordf(Imports.FogCoordf);
            GL.FogCoordfv = new GL.Delegates.FogCoordfv(Imports.FogCoordfv);
            GL.FogCoordd = new GL.Delegates.FogCoordd(Imports.FogCoordd);
            GL.FogCoorddv = new GL.Delegates.FogCoorddv(Imports.FogCoorddv);
            GL.FogCoordPointer = new GL.Delegates.FogCoordPointer(Imports.FogCoordPointer);
            GL.MultiDrawArrays = new GL.Delegates.MultiDrawArrays(Imports.MultiDrawArrays);
            GL.MultiDrawElements = new GL.Delegates.MultiDrawElements(Imports.MultiDrawElements);
            GL.PointParameterf = new GL.Delegates.PointParameterf(Imports.PointParameterf);
            GL.PointParameterfv = new GL.Delegates.PointParameterfv(Imports.PointParameterfv);
            GL.PointParameteri = new GL.Delegates.PointParameteri(Imports.PointParameteri);
            GL.PointParameteriv = new GL.Delegates.PointParameteriv(Imports.PointParameteriv);
            GL.SecondaryColor3b = new GL.Delegates.SecondaryColor3b(Imports.SecondaryColor3b);
            GL.SecondaryColor3bv = new GL.Delegates.SecondaryColor3bv(Imports.SecondaryColor3bv);
            GL.SecondaryColor3d = new GL.Delegates.SecondaryColor3d(Imports.SecondaryColor3d);
            GL.SecondaryColor3dv = new GL.Delegates.SecondaryColor3dv(Imports.SecondaryColor3dv);
            GL.SecondaryColor3f = new GL.Delegates.SecondaryColor3f(Imports.SecondaryColor3f);
            GL.SecondaryColor3fv = new GL.Delegates.SecondaryColor3fv(Imports.SecondaryColor3fv);
            GL.SecondaryColor3i = new GL.Delegates.SecondaryColor3i(Imports.SecondaryColor3i);
            GL.SecondaryColor3iv = new GL.Delegates.SecondaryColor3iv(Imports.SecondaryColor3iv);
            GL.SecondaryColor3s = new GL.Delegates.SecondaryColor3s(Imports.SecondaryColor3s);
            GL.SecondaryColor3sv = new GL.Delegates.SecondaryColor3sv(Imports.SecondaryColor3sv);
            GL.SecondaryColor3ub = new GL.Delegates.SecondaryColor3ub(Imports.SecondaryColor3ub);
            GL.SecondaryColor3ubv = new GL.Delegates.SecondaryColor3ubv(Imports.SecondaryColor3ubv);
            GL.SecondaryColor3ui = new GL.Delegates.SecondaryColor3ui(Imports.SecondaryColor3ui);
            GL.SecondaryColor3uiv = new GL.Delegates.SecondaryColor3uiv(Imports.SecondaryColor3uiv);
            GL.SecondaryColor3us = new GL.Delegates.SecondaryColor3us(Imports.SecondaryColor3us);
            GL.SecondaryColor3usv = new GL.Delegates.SecondaryColor3usv(Imports.SecondaryColor3usv);
            GL.SecondaryColorPointer = new GL.Delegates.SecondaryColorPointer(Imports.SecondaryColorPointer);
            GL.WindowPos2d = new GL.Delegates.WindowPos2d(Imports.WindowPos2d);
            GL.WindowPos2dv = new GL.Delegates.WindowPos2dv(Imports.WindowPos2dv);
            GL.WindowPos2f = new GL.Delegates.WindowPos2f(Imports.WindowPos2f);
            GL.WindowPos2fv = new GL.Delegates.WindowPos2fv(Imports.WindowPos2fv);
            GL.WindowPos2i = new GL.Delegates.WindowPos2i(Imports.WindowPos2i);
            GL.WindowPos2iv = new GL.Delegates.WindowPos2iv(Imports.WindowPos2iv);
            GL.WindowPos2s = new GL.Delegates.WindowPos2s(Imports.WindowPos2s);
            GL.WindowPos2sv = new GL.Delegates.WindowPos2sv(Imports.WindowPos2sv);
            GL.WindowPos3d = new GL.Delegates.WindowPos3d(Imports.WindowPos3d);
            GL.WindowPos3dv = new GL.Delegates.WindowPos3dv(Imports.WindowPos3dv);
            GL.WindowPos3f = new GL.Delegates.WindowPos3f(Imports.WindowPos3f);
            GL.WindowPos3fv = new GL.Delegates.WindowPos3fv(Imports.WindowPos3fv);
            GL.WindowPos3i = new GL.Delegates.WindowPos3i(Imports.WindowPos3i);
            GL.WindowPos3iv = new GL.Delegates.WindowPos3iv(Imports.WindowPos3iv);
            GL.WindowPos3s = new GL.Delegates.WindowPos3s(Imports.WindowPos3s);
            GL.WindowPos3sv = new GL.Delegates.WindowPos3sv(Imports.WindowPos3sv);
            GL.GenQueries = (GL.Delegates.GenQueries) GetAddress("glGenQueries", typeof(GL.Delegates.GenQueries));
            GL.DeleteQueries = (GL.Delegates.DeleteQueries) GetAddress("glDeleteQueries", typeof(GL.Delegates.DeleteQueries));
            GL.IsQuery = (GL.Delegates.IsQuery) GetAddress("glIsQuery", typeof(GL.Delegates.IsQuery));
            GL.BeginQuery = (GL.Delegates.BeginQuery) GetAddress("glBeginQuery", typeof(GL.Delegates.BeginQuery));
            GL.EndQuery = (GL.Delegates.EndQuery) GetAddress("glEndQuery", typeof(GL.Delegates.EndQuery));
            GL.GetQueryiv = (GL.Delegates.GetQueryiv) GetAddress("glGetQueryiv", typeof(GL.Delegates.GetQueryiv));
            GL.GetQueryObjectiv = (GL.Delegates.GetQueryObjectiv) GetAddress("glGetQueryObjectiv", typeof(GL.Delegates.GetQueryObjectiv));
            GL.GetQueryObjectuiv = (GL.Delegates.GetQueryObjectuiv) GetAddress("glGetQueryObjectuiv", typeof(GL.Delegates.GetQueryObjectuiv));
            GL.BindBuffer = (GL.Delegates.BindBuffer) GetAddress("glBindBuffer", typeof(GL.Delegates.BindBuffer));
            GL.DeleteBuffers = (GL.Delegates.DeleteBuffers) GetAddress("glDeleteBuffers", typeof(GL.Delegates.DeleteBuffers));
            GL.GenBuffers = (GL.Delegates.GenBuffers) GetAddress("glGenBuffers", typeof(GL.Delegates.GenBuffers));
            GL.IsBuffer = (GL.Delegates.IsBuffer) GetAddress("glIsBuffer", typeof(GL.Delegates.IsBuffer));
            GL.BufferData = (GL.Delegates.BufferData) GetAddress("glBufferData", typeof(GL.Delegates.BufferData));
            GL.BufferSubData = (GL.Delegates.BufferSubData) GetAddress("glBufferSubData", typeof(GL.Delegates.BufferSubData));
            GL.GetBufferSubData = (GL.Delegates.GetBufferSubData) GetAddress("glGetBufferSubData", typeof(GL.Delegates.GetBufferSubData));
            GL.MapBuffer_ = (GL.Delegates.MapBuffer_) GetAddress("glMapBuffer_", typeof(GL.Delegates.MapBuffer_));
            GL.UnmapBuffer = (GL.Delegates.UnmapBuffer) GetAddress("glUnmapBuffer", typeof(GL.Delegates.UnmapBuffer));
            GL.GetBufferParameteriv = (GL.Delegates.GetBufferParameteriv) GetAddress("glGetBufferParameteriv", typeof(GL.Delegates.GetBufferParameteriv));
            GL.GetBufferPointerv = (GL.Delegates.GetBufferPointerv) GetAddress("glGetBufferPointerv", typeof(GL.Delegates.GetBufferPointerv));
            GL.BlendEquationSeparate = (GL.Delegates.BlendEquationSeparate) GetAddress("glBlendEquationSeparate", typeof(GL.Delegates.BlendEquationSeparate));
            GL.DrawBuffers = (GL.Delegates.DrawBuffers) GetAddress("glDrawBuffers", typeof(GL.Delegates.DrawBuffers));
            GL.StencilOpSeparate = (GL.Delegates.StencilOpSeparate) GetAddress("glStencilOpSeparate", typeof(GL.Delegates.StencilOpSeparate));
            GL.StencilFuncSeparate = (GL.Delegates.StencilFuncSeparate) GetAddress("glStencilFuncSeparate", typeof(GL.Delegates.StencilFuncSeparate));
            GL.StencilMaskSeparate = (GL.Delegates.StencilMaskSeparate) GetAddress("glStencilMaskSeparate", typeof(GL.Delegates.StencilMaskSeparate));
            GL.AttachShader = (GL.Delegates.AttachShader) GetAddress("glAttachShader", typeof(GL.Delegates.AttachShader));
            GL.BindAttribLocation = (GL.Delegates.BindAttribLocation) GetAddress("glBindAttribLocation", typeof(GL.Delegates.BindAttribLocation));
            GL.CompileShader = (GL.Delegates.CompileShader) GetAddress("glCompileShader", typeof(GL.Delegates.CompileShader));
            GL.CreateProgram = (GL.Delegates.CreateProgram) GetAddress("glCreateProgram", typeof(GL.Delegates.CreateProgram));
            GL.CreateShader = (GL.Delegates.CreateShader) GetAddress("glCreateShader", typeof(GL.Delegates.CreateShader));
            GL.DeleteProgram = (GL.Delegates.DeleteProgram) GetAddress("glDeleteProgram", typeof(GL.Delegates.DeleteProgram));
            GL.DeleteShader = (GL.Delegates.DeleteShader) GetAddress("glDeleteShader", typeof(GL.Delegates.DeleteShader));
            GL.DetachShader = (GL.Delegates.DetachShader) GetAddress("glDetachShader", typeof(GL.Delegates.DetachShader));
            GL.DisableVertexAttribArray = (GL.Delegates.DisableVertexAttribArray) GetAddress("glDisableVertexAttribArray", typeof(GL.Delegates.DisableVertexAttribArray));
            GL.EnableVertexAttribArray = (GL.Delegates.EnableVertexAttribArray) GetAddress("glEnableVertexAttribArray", typeof(GL.Delegates.EnableVertexAttribArray));
            GL.GetActiveAttrib = (GL.Delegates.GetActiveAttrib) GetAddress("glGetActiveAttrib", typeof(GL.Delegates.GetActiveAttrib));
            GL.GetActiveUniform = (GL.Delegates.GetActiveUniform) GetAddress("glGetActiveUniform", typeof(GL.Delegates.GetActiveUniform));
            GL.GetAttachedShaders = (GL.Delegates.GetAttachedShaders) GetAddress("glGetAttachedShaders", typeof(GL.Delegates.GetAttachedShaders));
            GL.GetAttribLocation = (GL.Delegates.GetAttribLocation) GetAddress("glGetAttribLocation", typeof(GL.Delegates.GetAttribLocation));
            GL.GetProgramiv = (GL.Delegates.GetProgramiv) GetAddress("glGetProgramiv", typeof(GL.Delegates.GetProgramiv));
            GL.GetProgramInfoLog = (GL.Delegates.GetProgramInfoLog) GetAddress("glGetProgramInfoLog", typeof(GL.Delegates.GetProgramInfoLog));
            GL.GetShaderiv = (GL.Delegates.GetShaderiv) GetAddress("glGetShaderiv", typeof(GL.Delegates.GetShaderiv));
            GL.GetShaderInfoLog = (GL.Delegates.GetShaderInfoLog) GetAddress("glGetShaderInfoLog", typeof(GL.Delegates.GetShaderInfoLog));
            GL.GetShaderSource = (GL.Delegates.GetShaderSource) GetAddress("glGetShaderSource", typeof(GL.Delegates.GetShaderSource));
            GL.GetUniformLocation = (GL.Delegates.GetUniformLocation) GetAddress("glGetUniformLocation", typeof(GL.Delegates.GetUniformLocation));
            GL.GetUniformfv = (GL.Delegates.GetUniformfv) GetAddress("glGetUniformfv", typeof(GL.Delegates.GetUniformfv));
            GL.GetUniformiv = (GL.Delegates.GetUniformiv) GetAddress("glGetUniformiv", typeof(GL.Delegates.GetUniformiv));
            GL.GetVertexAttribdv = (GL.Delegates.GetVertexAttribdv) GetAddress("glGetVertexAttribdv", typeof(GL.Delegates.GetVertexAttribdv));
            GL.GetVertexAttribfv = (GL.Delegates.GetVertexAttribfv) GetAddress("glGetVertexAttribfv", typeof(GL.Delegates.GetVertexAttribfv));
            GL.GetVertexAttribiv = (GL.Delegates.GetVertexAttribiv) GetAddress("glGetVertexAttribiv", typeof(GL.Delegates.GetVertexAttribiv));
            GL.GetVertexAttribPointerv = (GL.Delegates.GetVertexAttribPointerv) GetAddress("glGetVertexAttribPointerv", typeof(GL.Delegates.GetVertexAttribPointerv));
            GL.IsProgram = (GL.Delegates.IsProgram) GetAddress("glIsProgram", typeof(GL.Delegates.IsProgram));
            GL.IsShader = (GL.Delegates.IsShader) GetAddress("glIsShader", typeof(GL.Delegates.IsShader));
            GL.LinkProgram = (GL.Delegates.LinkProgram) GetAddress("glLinkProgram", typeof(GL.Delegates.LinkProgram));
            GL.ShaderSource = (GL.Delegates.ShaderSource) GetAddress("glShaderSource", typeof(GL.Delegates.ShaderSource));
            GL.UseProgram = (GL.Delegates.UseProgram) GetAddress("glUseProgram", typeof(GL.Delegates.UseProgram));
            GL.Uniform1f = (GL.Delegates.Uniform1f) GetAddress("glUniform1f", typeof(GL.Delegates.Uniform1f));
            GL.Uniform2f = (GL.Delegates.Uniform2f) GetAddress("glUniform2f", typeof(GL.Delegates.Uniform2f));
            GL.Uniform3f = (GL.Delegates.Uniform3f) GetAddress("glUniform3f", typeof(GL.Delegates.Uniform3f));
            GL.Uniform4f = (GL.Delegates.Uniform4f) GetAddress("glUniform4f", typeof(GL.Delegates.Uniform4f));
            GL.Uniform1i = (GL.Delegates.Uniform1i) GetAddress("glUniform1i", typeof(GL.Delegates.Uniform1i));
            GL.Uniform2i = (GL.Delegates.Uniform2i) GetAddress("glUniform2i", typeof(GL.Delegates.Uniform2i));
            GL.Uniform3i = (GL.Delegates.Uniform3i) GetAddress("glUniform3i", typeof(GL.Delegates.Uniform3i));
            GL.Uniform4i = (GL.Delegates.Uniform4i) GetAddress("glUniform4i", typeof(GL.Delegates.Uniform4i));
            GL.Uniform1fv = (GL.Delegates.Uniform1fv) GetAddress("glUniform1fv", typeof(GL.Delegates.Uniform1fv));
            GL.Uniform2fv = (GL.Delegates.Uniform2fv) GetAddress("glUniform2fv", typeof(GL.Delegates.Uniform2fv));
            GL.Uniform3fv = (GL.Delegates.Uniform3fv) GetAddress("glUniform3fv", typeof(GL.Delegates.Uniform3fv));
            GL.Uniform4fv = (GL.Delegates.Uniform4fv) GetAddress("glUniform4fv", typeof(GL.Delegates.Uniform4fv));
            GL.Uniform1iv = (GL.Delegates.Uniform1iv) GetAddress("glUniform1iv", typeof(GL.Delegates.Uniform1iv));
            GL.Uniform2iv = (GL.Delegates.Uniform2iv) GetAddress("glUniform2iv", typeof(GL.Delegates.Uniform2iv));
            GL.Uniform3iv = (GL.Delegates.Uniform3iv) GetAddress("glUniform3iv", typeof(GL.Delegates.Uniform3iv));
            GL.Uniform4iv = (GL.Delegates.Uniform4iv) GetAddress("glUniform4iv", typeof(GL.Delegates.Uniform4iv));
            GL.UniformMatrix2fv = (GL.Delegates.UniformMatrix2fv) GetAddress("glUniformMatrix2fv", typeof(GL.Delegates.UniformMatrix2fv));
            GL.UniformMatrix3fv = (GL.Delegates.UniformMatrix3fv) GetAddress("glUniformMatrix3fv", typeof(GL.Delegates.UniformMatrix3fv));
            GL.UniformMatrix4fv = (GL.Delegates.UniformMatrix4fv) GetAddress("glUniformMatrix4fv", typeof(GL.Delegates.UniformMatrix4fv));
            GL.ValidateProgram = (GL.Delegates.ValidateProgram) GetAddress("glValidateProgram", typeof(GL.Delegates.ValidateProgram));
            GL.VertexAttrib1d = (GL.Delegates.VertexAttrib1d) GetAddress("glVertexAttrib1d", typeof(GL.Delegates.VertexAttrib1d));
            GL.VertexAttrib1dv = (GL.Delegates.VertexAttrib1dv) GetAddress("glVertexAttrib1dv", typeof(GL.Delegates.VertexAttrib1dv));
            GL.VertexAttrib1f = (GL.Delegates.VertexAttrib1f) GetAddress("glVertexAttrib1f", typeof(GL.Delegates.VertexAttrib1f));
            GL.VertexAttrib1fv = (GL.Delegates.VertexAttrib1fv) GetAddress("glVertexAttrib1fv", typeof(GL.Delegates.VertexAttrib1fv));
            GL.VertexAttrib1s = (GL.Delegates.VertexAttrib1s) GetAddress("glVertexAttrib1s", typeof(GL.Delegates.VertexAttrib1s));
            GL.VertexAttrib1sv = (GL.Delegates.VertexAttrib1sv) GetAddress("glVertexAttrib1sv", typeof(GL.Delegates.VertexAttrib1sv));
            GL.VertexAttrib2d = (GL.Delegates.VertexAttrib2d) GetAddress("glVertexAttrib2d", typeof(GL.Delegates.VertexAttrib2d));
            GL.VertexAttrib2dv = (GL.Delegates.VertexAttrib2dv) GetAddress("glVertexAttrib2dv", typeof(GL.Delegates.VertexAttrib2dv));
            GL.VertexAttrib2f = (GL.Delegates.VertexAttrib2f) GetAddress("glVertexAttrib2f", typeof(GL.Delegates.VertexAttrib2f));
            GL.VertexAttrib2fv = (GL.Delegates.VertexAttrib2fv) GetAddress("glVertexAttrib2fv", typeof(GL.Delegates.VertexAttrib2fv));
            GL.VertexAttrib2s = (GL.Delegates.VertexAttrib2s) GetAddress("glVertexAttrib2s", typeof(GL.Delegates.VertexAttrib2s));
            GL.VertexAttrib2sv = (GL.Delegates.VertexAttrib2sv) GetAddress("glVertexAttrib2sv", typeof(GL.Delegates.VertexAttrib2sv));
            GL.VertexAttrib3d = (GL.Delegates.VertexAttrib3d) GetAddress("glVertexAttrib3d", typeof(GL.Delegates.VertexAttrib3d));
            GL.VertexAttrib3dv = (GL.Delegates.VertexAttrib3dv) GetAddress("glVertexAttrib3dv", typeof(GL.Delegates.VertexAttrib3dv));
            GL.VertexAttrib3f = (GL.Delegates.VertexAttrib3f) GetAddress("glVertexAttrib3f", typeof(GL.Delegates.VertexAttrib3f));
            GL.VertexAttrib3fv = (GL.Delegates.VertexAttrib3fv) GetAddress("glVertexAttrib3fv", typeof(GL.Delegates.VertexAttrib3fv));
            GL.VertexAttrib3s = (GL.Delegates.VertexAttrib3s) GetAddress("glVertexAttrib3s", typeof(GL.Delegates.VertexAttrib3s));
            GL.VertexAttrib3sv = (GL.Delegates.VertexAttrib3sv) GetAddress("glVertexAttrib3sv", typeof(GL.Delegates.VertexAttrib3sv));
            GL.VertexAttrib4Nbv = (GL.Delegates.VertexAttrib4Nbv) GetAddress("glVertexAttrib4Nbv", typeof(GL.Delegates.VertexAttrib4Nbv));
            GL.VertexAttrib4Niv = (GL.Delegates.VertexAttrib4Niv) GetAddress("glVertexAttrib4Niv", typeof(GL.Delegates.VertexAttrib4Niv));
            GL.VertexAttrib4Nsv = (GL.Delegates.VertexAttrib4Nsv) GetAddress("glVertexAttrib4Nsv", typeof(GL.Delegates.VertexAttrib4Nsv));
            GL.VertexAttrib4Nub = (GL.Delegates.VertexAttrib4Nub) GetAddress("glVertexAttrib4Nub", typeof(GL.Delegates.VertexAttrib4Nub));
            GL.VertexAttrib4Nubv = (GL.Delegates.VertexAttrib4Nubv) GetAddress("glVertexAttrib4Nubv", typeof(GL.Delegates.VertexAttrib4Nubv));
            GL.VertexAttrib4Nuiv = (GL.Delegates.VertexAttrib4Nuiv) GetAddress("glVertexAttrib4Nuiv", typeof(GL.Delegates.VertexAttrib4Nuiv));
            GL.VertexAttrib4Nusv = (GL.Delegates.VertexAttrib4Nusv) GetAddress("glVertexAttrib4Nusv", typeof(GL.Delegates.VertexAttrib4Nusv));
            GL.VertexAttrib4bv = (GL.Delegates.VertexAttrib4bv) GetAddress("glVertexAttrib4bv", typeof(GL.Delegates.VertexAttrib4bv));
            GL.VertexAttrib4d = (GL.Delegates.VertexAttrib4d) GetAddress("glVertexAttrib4d", typeof(GL.Delegates.VertexAttrib4d));
            GL.VertexAttrib4dv = (GL.Delegates.VertexAttrib4dv) GetAddress("glVertexAttrib4dv", typeof(GL.Delegates.VertexAttrib4dv));
            GL.VertexAttrib4f = (GL.Delegates.VertexAttrib4f) GetAddress("glVertexAttrib4f", typeof(GL.Delegates.VertexAttrib4f));
            GL.VertexAttrib4fv = (GL.Delegates.VertexAttrib4fv) GetAddress("glVertexAttrib4fv", typeof(GL.Delegates.VertexAttrib4fv));
            GL.VertexAttrib4iv = (GL.Delegates.VertexAttrib4iv) GetAddress("glVertexAttrib4iv", typeof(GL.Delegates.VertexAttrib4iv));
            GL.VertexAttrib4s = (GL.Delegates.VertexAttrib4s) GetAddress("glVertexAttrib4s", typeof(GL.Delegates.VertexAttrib4s));
            GL.VertexAttrib4sv = (GL.Delegates.VertexAttrib4sv) GetAddress("glVertexAttrib4sv", typeof(GL.Delegates.VertexAttrib4sv));
            GL.VertexAttrib4ubv = (GL.Delegates.VertexAttrib4ubv) GetAddress("glVertexAttrib4ubv", typeof(GL.Delegates.VertexAttrib4ubv));
            GL.VertexAttrib4uiv = (GL.Delegates.VertexAttrib4uiv) GetAddress("glVertexAttrib4uiv", typeof(GL.Delegates.VertexAttrib4uiv));
            GL.VertexAttrib4usv = (GL.Delegates.VertexAttrib4usv) GetAddress("glVertexAttrib4usv", typeof(GL.Delegates.VertexAttrib4usv));
            GL.VertexAttribPointer = (GL.Delegates.VertexAttribPointer) GetAddress("glVertexAttribPointer", typeof(GL.Delegates.VertexAttribPointer));
        CoreLoaded = true;
        }

        #endregion

        #region Load extensions

        /// <summary>
        /// Loads the opengl extensions (e.g. ARB, EXT, vendor and platform specific functions).
        /// </summary>
        public override void LoadExtensions()
        {
            GL.ActiveTextureARB = (GL.Delegates.ActiveTextureARB) GetAddress("glActiveTextureARB", typeof(GL.Delegates.ActiveTextureARB));
            GL.ClientActiveTextureARB = (GL.Delegates.ClientActiveTextureARB) GetAddress("glClientActiveTextureARB", typeof(GL.Delegates.ClientActiveTextureARB));
            GL.MultiTexCoord1dARB = (GL.Delegates.MultiTexCoord1dARB) GetAddress("glMultiTexCoord1dARB", typeof(GL.Delegates.MultiTexCoord1dARB));
            GL.MultiTexCoord1dvARB = (GL.Delegates.MultiTexCoord1dvARB) GetAddress("glMultiTexCoord1dvARB", typeof(GL.Delegates.MultiTexCoord1dvARB));
            GL.MultiTexCoord1fARB = (GL.Delegates.MultiTexCoord1fARB) GetAddress("glMultiTexCoord1fARB", typeof(GL.Delegates.MultiTexCoord1fARB));
            GL.MultiTexCoord1fvARB = (GL.Delegates.MultiTexCoord1fvARB) GetAddress("glMultiTexCoord1fvARB", typeof(GL.Delegates.MultiTexCoord1fvARB));
            GL.MultiTexCoord1iARB = (GL.Delegates.MultiTexCoord1iARB) GetAddress("glMultiTexCoord1iARB", typeof(GL.Delegates.MultiTexCoord1iARB));
            GL.MultiTexCoord1ivARB = (GL.Delegates.MultiTexCoord1ivARB) GetAddress("glMultiTexCoord1ivARB", typeof(GL.Delegates.MultiTexCoord1ivARB));
            GL.MultiTexCoord1sARB = (GL.Delegates.MultiTexCoord1sARB) GetAddress("glMultiTexCoord1sARB", typeof(GL.Delegates.MultiTexCoord1sARB));
            GL.MultiTexCoord1svARB = (GL.Delegates.MultiTexCoord1svARB) GetAddress("glMultiTexCoord1svARB", typeof(GL.Delegates.MultiTexCoord1svARB));
            GL.MultiTexCoord2dARB = (GL.Delegates.MultiTexCoord2dARB) GetAddress("glMultiTexCoord2dARB", typeof(GL.Delegates.MultiTexCoord2dARB));
            GL.MultiTexCoord2dvARB = (GL.Delegates.MultiTexCoord2dvARB) GetAddress("glMultiTexCoord2dvARB", typeof(GL.Delegates.MultiTexCoord2dvARB));
            GL.MultiTexCoord2fARB = (GL.Delegates.MultiTexCoord2fARB) GetAddress("glMultiTexCoord2fARB", typeof(GL.Delegates.MultiTexCoord2fARB));
            GL.MultiTexCoord2fvARB = (GL.Delegates.MultiTexCoord2fvARB) GetAddress("glMultiTexCoord2fvARB", typeof(GL.Delegates.MultiTexCoord2fvARB));
            GL.MultiTexCoord2iARB = (GL.Delegates.MultiTexCoord2iARB) GetAddress("glMultiTexCoord2iARB", typeof(GL.Delegates.MultiTexCoord2iARB));
            GL.MultiTexCoord2ivARB = (GL.Delegates.MultiTexCoord2ivARB) GetAddress("glMultiTexCoord2ivARB", typeof(GL.Delegates.MultiTexCoord2ivARB));
            GL.MultiTexCoord2sARB = (GL.Delegates.MultiTexCoord2sARB) GetAddress("glMultiTexCoord2sARB", typeof(GL.Delegates.MultiTexCoord2sARB));
            GL.MultiTexCoord2svARB = (GL.Delegates.MultiTexCoord2svARB) GetAddress("glMultiTexCoord2svARB", typeof(GL.Delegates.MultiTexCoord2svARB));
            GL.MultiTexCoord3dARB = (GL.Delegates.MultiTexCoord3dARB) GetAddress("glMultiTexCoord3dARB", typeof(GL.Delegates.MultiTexCoord3dARB));
            GL.MultiTexCoord3dvARB = (GL.Delegates.MultiTexCoord3dvARB) GetAddress("glMultiTexCoord3dvARB", typeof(GL.Delegates.MultiTexCoord3dvARB));
            GL.MultiTexCoord3fARB = (GL.Delegates.MultiTexCoord3fARB) GetAddress("glMultiTexCoord3fARB", typeof(GL.Delegates.MultiTexCoord3fARB));
            GL.MultiTexCoord3fvARB = (GL.Delegates.MultiTexCoord3fvARB) GetAddress("glMultiTexCoord3fvARB", typeof(GL.Delegates.MultiTexCoord3fvARB));
            GL.MultiTexCoord3iARB = (GL.Delegates.MultiTexCoord3iARB) GetAddress("glMultiTexCoord3iARB", typeof(GL.Delegates.MultiTexCoord3iARB));
            GL.MultiTexCoord3ivARB = (GL.Delegates.MultiTexCoord3ivARB) GetAddress("glMultiTexCoord3ivARB", typeof(GL.Delegates.MultiTexCoord3ivARB));
            GL.MultiTexCoord3sARB = (GL.Delegates.MultiTexCoord3sARB) GetAddress("glMultiTexCoord3sARB", typeof(GL.Delegates.MultiTexCoord3sARB));
            GL.MultiTexCoord3svARB = (GL.Delegates.MultiTexCoord3svARB) GetAddress("glMultiTexCoord3svARB", typeof(GL.Delegates.MultiTexCoord3svARB));
            GL.MultiTexCoord4dARB = (GL.Delegates.MultiTexCoord4dARB) GetAddress("glMultiTexCoord4dARB", typeof(GL.Delegates.MultiTexCoord4dARB));
            GL.MultiTexCoord4dvARB = (GL.Delegates.MultiTexCoord4dvARB) GetAddress("glMultiTexCoord4dvARB", typeof(GL.Delegates.MultiTexCoord4dvARB));
            GL.MultiTexCoord4fARB = (GL.Delegates.MultiTexCoord4fARB) GetAddress("glMultiTexCoord4fARB", typeof(GL.Delegates.MultiTexCoord4fARB));
            GL.MultiTexCoord4fvARB = (GL.Delegates.MultiTexCoord4fvARB) GetAddress("glMultiTexCoord4fvARB", typeof(GL.Delegates.MultiTexCoord4fvARB));
            GL.MultiTexCoord4iARB = (GL.Delegates.MultiTexCoord4iARB) GetAddress("glMultiTexCoord4iARB", typeof(GL.Delegates.MultiTexCoord4iARB));
            GL.MultiTexCoord4ivARB = (GL.Delegates.MultiTexCoord4ivARB) GetAddress("glMultiTexCoord4ivARB", typeof(GL.Delegates.MultiTexCoord4ivARB));
            GL.MultiTexCoord4sARB = (GL.Delegates.MultiTexCoord4sARB) GetAddress("glMultiTexCoord4sARB", typeof(GL.Delegates.MultiTexCoord4sARB));
            GL.MultiTexCoord4svARB = (GL.Delegates.MultiTexCoord4svARB) GetAddress("glMultiTexCoord4svARB", typeof(GL.Delegates.MultiTexCoord4svARB));
            GL.LoadTransposeMatrixfARB = (GL.Delegates.LoadTransposeMatrixfARB) GetAddress("glLoadTransposeMatrixfARB", typeof(GL.Delegates.LoadTransposeMatrixfARB));
            GL.LoadTransposeMatrixdARB = (GL.Delegates.LoadTransposeMatrixdARB) GetAddress("glLoadTransposeMatrixdARB", typeof(GL.Delegates.LoadTransposeMatrixdARB));
            GL.MultTransposeMatrixfARB = (GL.Delegates.MultTransposeMatrixfARB) GetAddress("glMultTransposeMatrixfARB", typeof(GL.Delegates.MultTransposeMatrixfARB));
            GL.MultTransposeMatrixdARB = (GL.Delegates.MultTransposeMatrixdARB) GetAddress("glMultTransposeMatrixdARB", typeof(GL.Delegates.MultTransposeMatrixdARB));
            GL.SampleCoverageARB = (GL.Delegates.SampleCoverageARB) GetAddress("glSampleCoverageARB", typeof(GL.Delegates.SampleCoverageARB));
            GL.CompressedTexImage3DARB = (GL.Delegates.CompressedTexImage3DARB) GetAddress("glCompressedTexImage3DARB", typeof(GL.Delegates.CompressedTexImage3DARB));
            GL.CompressedTexImage2DARB = (GL.Delegates.CompressedTexImage2DARB) GetAddress("glCompressedTexImage2DARB", typeof(GL.Delegates.CompressedTexImage2DARB));
            GL.CompressedTexImage1DARB = (GL.Delegates.CompressedTexImage1DARB) GetAddress("glCompressedTexImage1DARB", typeof(GL.Delegates.CompressedTexImage1DARB));
            GL.CompressedTexSubImage3DARB = (GL.Delegates.CompressedTexSubImage3DARB) GetAddress("glCompressedTexSubImage3DARB", typeof(GL.Delegates.CompressedTexSubImage3DARB));
            GL.CompressedTexSubImage2DARB = (GL.Delegates.CompressedTexSubImage2DARB) GetAddress("glCompressedTexSubImage2DARB", typeof(GL.Delegates.CompressedTexSubImage2DARB));
            GL.CompressedTexSubImage1DARB = (GL.Delegates.CompressedTexSubImage1DARB) GetAddress("glCompressedTexSubImage1DARB", typeof(GL.Delegates.CompressedTexSubImage1DARB));
            GL.GetCompressedTexImageARB = (GL.Delegates.GetCompressedTexImageARB) GetAddress("glGetCompressedTexImageARB", typeof(GL.Delegates.GetCompressedTexImageARB));
            GL.PointParameterfARB = (GL.Delegates.PointParameterfARB) GetAddress("glPointParameterfARB", typeof(GL.Delegates.PointParameterfARB));
            GL.PointParameterfvARB = (GL.Delegates.PointParameterfvARB) GetAddress("glPointParameterfvARB", typeof(GL.Delegates.PointParameterfvARB));
            GL.WeightbvARB = (GL.Delegates.WeightbvARB) GetAddress("glWeightbvARB", typeof(GL.Delegates.WeightbvARB));
            GL.WeightsvARB = (GL.Delegates.WeightsvARB) GetAddress("glWeightsvARB", typeof(GL.Delegates.WeightsvARB));
            GL.WeightivARB = (GL.Delegates.WeightivARB) GetAddress("glWeightivARB", typeof(GL.Delegates.WeightivARB));
            GL.WeightfvARB = (GL.Delegates.WeightfvARB) GetAddress("glWeightfvARB", typeof(GL.Delegates.WeightfvARB));
            GL.WeightdvARB = (GL.Delegates.WeightdvARB) GetAddress("glWeightdvARB", typeof(GL.Delegates.WeightdvARB));
            GL.WeightubvARB = (GL.Delegates.WeightubvARB) GetAddress("glWeightubvARB", typeof(GL.Delegates.WeightubvARB));
            GL.WeightusvARB = (GL.Delegates.WeightusvARB) GetAddress("glWeightusvARB", typeof(GL.Delegates.WeightusvARB));
            GL.WeightuivARB = (GL.Delegates.WeightuivARB) GetAddress("glWeightuivARB", typeof(GL.Delegates.WeightuivARB));
            GL.WeightPointerARB = (GL.Delegates.WeightPointerARB) GetAddress("glWeightPointerARB", typeof(GL.Delegates.WeightPointerARB));
            GL.VertexBlendARB = (GL.Delegates.VertexBlendARB) GetAddress("glVertexBlendARB", typeof(GL.Delegates.VertexBlendARB));
            GL.CurrentPaletteMatrixARB = (GL.Delegates.CurrentPaletteMatrixARB) GetAddress("glCurrentPaletteMatrixARB", typeof(GL.Delegates.CurrentPaletteMatrixARB));
            GL.MatrixIndexubvARB = (GL.Delegates.MatrixIndexubvARB) GetAddress("glMatrixIndexubvARB", typeof(GL.Delegates.MatrixIndexubvARB));
            GL.MatrixIndexusvARB = (GL.Delegates.MatrixIndexusvARB) GetAddress("glMatrixIndexusvARB", typeof(GL.Delegates.MatrixIndexusvARB));
            GL.MatrixIndexuivARB = (GL.Delegates.MatrixIndexuivARB) GetAddress("glMatrixIndexuivARB", typeof(GL.Delegates.MatrixIndexuivARB));
            GL.MatrixIndexPointerARB = (GL.Delegates.MatrixIndexPointerARB) GetAddress("glMatrixIndexPointerARB", typeof(GL.Delegates.MatrixIndexPointerARB));
            GL.WindowPos2dARB = (GL.Delegates.WindowPos2dARB) GetAddress("glWindowPos2dARB", typeof(GL.Delegates.WindowPos2dARB));
            GL.WindowPos2dvARB = (GL.Delegates.WindowPos2dvARB) GetAddress("glWindowPos2dvARB", typeof(GL.Delegates.WindowPos2dvARB));
            GL.WindowPos2fARB = (GL.Delegates.WindowPos2fARB) GetAddress("glWindowPos2fARB", typeof(GL.Delegates.WindowPos2fARB));
            GL.WindowPos2fvARB = (GL.Delegates.WindowPos2fvARB) GetAddress("glWindowPos2fvARB", typeof(GL.Delegates.WindowPos2fvARB));
            GL.WindowPos2iARB = (GL.Delegates.WindowPos2iARB) GetAddress("glWindowPos2iARB", typeof(GL.Delegates.WindowPos2iARB));
            GL.WindowPos2ivARB = (GL.Delegates.WindowPos2ivARB) GetAddress("glWindowPos2ivARB", typeof(GL.Delegates.WindowPos2ivARB));
            GL.WindowPos2sARB = (GL.Delegates.WindowPos2sARB) GetAddress("glWindowPos2sARB", typeof(GL.Delegates.WindowPos2sARB));
            GL.WindowPos2svARB = (GL.Delegates.WindowPos2svARB) GetAddress("glWindowPos2svARB", typeof(GL.Delegates.WindowPos2svARB));
            GL.WindowPos3dARB = (GL.Delegates.WindowPos3dARB) GetAddress("glWindowPos3dARB", typeof(GL.Delegates.WindowPos3dARB));
            GL.WindowPos3dvARB = (GL.Delegates.WindowPos3dvARB) GetAddress("glWindowPos3dvARB", typeof(GL.Delegates.WindowPos3dvARB));
            GL.WindowPos3fARB = (GL.Delegates.WindowPos3fARB) GetAddress("glWindowPos3fARB", typeof(GL.Delegates.WindowPos3fARB));
            GL.WindowPos3fvARB = (GL.Delegates.WindowPos3fvARB) GetAddress("glWindowPos3fvARB", typeof(GL.Delegates.WindowPos3fvARB));
            GL.WindowPos3iARB = (GL.Delegates.WindowPos3iARB) GetAddress("glWindowPos3iARB", typeof(GL.Delegates.WindowPos3iARB));
            GL.WindowPos3ivARB = (GL.Delegates.WindowPos3ivARB) GetAddress("glWindowPos3ivARB", typeof(GL.Delegates.WindowPos3ivARB));
            GL.WindowPos3sARB = (GL.Delegates.WindowPos3sARB) GetAddress("glWindowPos3sARB", typeof(GL.Delegates.WindowPos3sARB));
            GL.WindowPos3svARB = (GL.Delegates.WindowPos3svARB) GetAddress("glWindowPos3svARB", typeof(GL.Delegates.WindowPos3svARB));
            GL.VertexAttrib1dARB = (GL.Delegates.VertexAttrib1dARB) GetAddress("glVertexAttrib1dARB", typeof(GL.Delegates.VertexAttrib1dARB));
            GL.VertexAttrib1dvARB = (GL.Delegates.VertexAttrib1dvARB) GetAddress("glVertexAttrib1dvARB", typeof(GL.Delegates.VertexAttrib1dvARB));
            GL.VertexAttrib1fARB = (GL.Delegates.VertexAttrib1fARB) GetAddress("glVertexAttrib1fARB", typeof(GL.Delegates.VertexAttrib1fARB));
            GL.VertexAttrib1fvARB = (GL.Delegates.VertexAttrib1fvARB) GetAddress("glVertexAttrib1fvARB", typeof(GL.Delegates.VertexAttrib1fvARB));
            GL.VertexAttrib1sARB = (GL.Delegates.VertexAttrib1sARB) GetAddress("glVertexAttrib1sARB", typeof(GL.Delegates.VertexAttrib1sARB));
            GL.VertexAttrib1svARB = (GL.Delegates.VertexAttrib1svARB) GetAddress("glVertexAttrib1svARB", typeof(GL.Delegates.VertexAttrib1svARB));
            GL.VertexAttrib2dARB = (GL.Delegates.VertexAttrib2dARB) GetAddress("glVertexAttrib2dARB", typeof(GL.Delegates.VertexAttrib2dARB));
            GL.VertexAttrib2dvARB = (GL.Delegates.VertexAttrib2dvARB) GetAddress("glVertexAttrib2dvARB", typeof(GL.Delegates.VertexAttrib2dvARB));
            GL.VertexAttrib2fARB = (GL.Delegates.VertexAttrib2fARB) GetAddress("glVertexAttrib2fARB", typeof(GL.Delegates.VertexAttrib2fARB));
            GL.VertexAttrib2fvARB = (GL.Delegates.VertexAttrib2fvARB) GetAddress("glVertexAttrib2fvARB", typeof(GL.Delegates.VertexAttrib2fvARB));
            GL.VertexAttrib2sARB = (GL.Delegates.VertexAttrib2sARB) GetAddress("glVertexAttrib2sARB", typeof(GL.Delegates.VertexAttrib2sARB));
            GL.VertexAttrib2svARB = (GL.Delegates.VertexAttrib2svARB) GetAddress("glVertexAttrib2svARB", typeof(GL.Delegates.VertexAttrib2svARB));
            GL.VertexAttrib3dARB = (GL.Delegates.VertexAttrib3dARB) GetAddress("glVertexAttrib3dARB", typeof(GL.Delegates.VertexAttrib3dARB));
            GL.VertexAttrib3dvARB = (GL.Delegates.VertexAttrib3dvARB) GetAddress("glVertexAttrib3dvARB", typeof(GL.Delegates.VertexAttrib3dvARB));
            GL.VertexAttrib3fARB = (GL.Delegates.VertexAttrib3fARB) GetAddress("glVertexAttrib3fARB", typeof(GL.Delegates.VertexAttrib3fARB));
            GL.VertexAttrib3fvARB = (GL.Delegates.VertexAttrib3fvARB) GetAddress("glVertexAttrib3fvARB", typeof(GL.Delegates.VertexAttrib3fvARB));
            GL.VertexAttrib3sARB = (GL.Delegates.VertexAttrib3sARB) GetAddress("glVertexAttrib3sARB", typeof(GL.Delegates.VertexAttrib3sARB));
            GL.VertexAttrib3svARB = (GL.Delegates.VertexAttrib3svARB) GetAddress("glVertexAttrib3svARB", typeof(GL.Delegates.VertexAttrib3svARB));
            GL.VertexAttrib4NbvARB = (GL.Delegates.VertexAttrib4NbvARB) GetAddress("glVertexAttrib4NbvARB", typeof(GL.Delegates.VertexAttrib4NbvARB));
            GL.VertexAttrib4NivARB = (GL.Delegates.VertexAttrib4NivARB) GetAddress("glVertexAttrib4NivARB", typeof(GL.Delegates.VertexAttrib4NivARB));
            GL.VertexAttrib4NsvARB = (GL.Delegates.VertexAttrib4NsvARB) GetAddress("glVertexAttrib4NsvARB", typeof(GL.Delegates.VertexAttrib4NsvARB));
            GL.VertexAttrib4NubARB = (GL.Delegates.VertexAttrib4NubARB) GetAddress("glVertexAttrib4NubARB", typeof(GL.Delegates.VertexAttrib4NubARB));
            GL.VertexAttrib4NubvARB = (GL.Delegates.VertexAttrib4NubvARB) GetAddress("glVertexAttrib4NubvARB", typeof(GL.Delegates.VertexAttrib4NubvARB));
            GL.VertexAttrib4NuivARB = (GL.Delegates.VertexAttrib4NuivARB) GetAddress("glVertexAttrib4NuivARB", typeof(GL.Delegates.VertexAttrib4NuivARB));
            GL.VertexAttrib4NusvARB = (GL.Delegates.VertexAttrib4NusvARB) GetAddress("glVertexAttrib4NusvARB", typeof(GL.Delegates.VertexAttrib4NusvARB));
            GL.VertexAttrib4bvARB = (GL.Delegates.VertexAttrib4bvARB) GetAddress("glVertexAttrib4bvARB", typeof(GL.Delegates.VertexAttrib4bvARB));
            GL.VertexAttrib4dARB = (GL.Delegates.VertexAttrib4dARB) GetAddress("glVertexAttrib4dARB", typeof(GL.Delegates.VertexAttrib4dARB));
            GL.VertexAttrib4dvARB = (GL.Delegates.VertexAttrib4dvARB) GetAddress("glVertexAttrib4dvARB", typeof(GL.Delegates.VertexAttrib4dvARB));
            GL.VertexAttrib4fARB = (GL.Delegates.VertexAttrib4fARB) GetAddress("glVertexAttrib4fARB", typeof(GL.Delegates.VertexAttrib4fARB));
            GL.VertexAttrib4fvARB = (GL.Delegates.VertexAttrib4fvARB) GetAddress("glVertexAttrib4fvARB", typeof(GL.Delegates.VertexAttrib4fvARB));
            GL.VertexAttrib4ivARB = (GL.Delegates.VertexAttrib4ivARB) GetAddress("glVertexAttrib4ivARB", typeof(GL.Delegates.VertexAttrib4ivARB));
            GL.VertexAttrib4sARB = (GL.Delegates.VertexAttrib4sARB) GetAddress("glVertexAttrib4sARB", typeof(GL.Delegates.VertexAttrib4sARB));
            GL.VertexAttrib4svARB = (GL.Delegates.VertexAttrib4svARB) GetAddress("glVertexAttrib4svARB", typeof(GL.Delegates.VertexAttrib4svARB));
            GL.VertexAttrib4ubvARB = (GL.Delegates.VertexAttrib4ubvARB) GetAddress("glVertexAttrib4ubvARB", typeof(GL.Delegates.VertexAttrib4ubvARB));
            GL.VertexAttrib4uivARB = (GL.Delegates.VertexAttrib4uivARB) GetAddress("glVertexAttrib4uivARB", typeof(GL.Delegates.VertexAttrib4uivARB));
            GL.VertexAttrib4usvARB = (GL.Delegates.VertexAttrib4usvARB) GetAddress("glVertexAttrib4usvARB", typeof(GL.Delegates.VertexAttrib4usvARB));
            GL.VertexAttribPointerARB = (GL.Delegates.VertexAttribPointerARB) GetAddress("glVertexAttribPointerARB", typeof(GL.Delegates.VertexAttribPointerARB));
            GL.EnableVertexAttribArrayARB = (GL.Delegates.EnableVertexAttribArrayARB) GetAddress("glEnableVertexAttribArrayARB", typeof(GL.Delegates.EnableVertexAttribArrayARB));
            GL.DisableVertexAttribArrayARB = (GL.Delegates.DisableVertexAttribArrayARB) GetAddress("glDisableVertexAttribArrayARB", typeof(GL.Delegates.DisableVertexAttribArrayARB));
            GL.ProgramStringARB = (GL.Delegates.ProgramStringARB) GetAddress("glProgramStringARB", typeof(GL.Delegates.ProgramStringARB));
            GL.BindProgramARB = (GL.Delegates.BindProgramARB) GetAddress("glBindProgramARB", typeof(GL.Delegates.BindProgramARB));
            GL.DeleteProgramsARB = (GL.Delegates.DeleteProgramsARB) GetAddress("glDeleteProgramsARB", typeof(GL.Delegates.DeleteProgramsARB));
            GL.GenProgramsARB = (GL.Delegates.GenProgramsARB) GetAddress("glGenProgramsARB", typeof(GL.Delegates.GenProgramsARB));
            GL.ProgramEnvParameter4dARB = (GL.Delegates.ProgramEnvParameter4dARB) GetAddress("glProgramEnvParameter4dARB", typeof(GL.Delegates.ProgramEnvParameter4dARB));
            GL.ProgramEnvParameter4dvARB = (GL.Delegates.ProgramEnvParameter4dvARB) GetAddress("glProgramEnvParameter4dvARB", typeof(GL.Delegates.ProgramEnvParameter4dvARB));
            GL.ProgramEnvParameter4fARB = (GL.Delegates.ProgramEnvParameter4fARB) GetAddress("glProgramEnvParameter4fARB", typeof(GL.Delegates.ProgramEnvParameter4fARB));
            GL.ProgramEnvParameter4fvARB = (GL.Delegates.ProgramEnvParameter4fvARB) GetAddress("glProgramEnvParameter4fvARB", typeof(GL.Delegates.ProgramEnvParameter4fvARB));
            GL.ProgramLocalParameter4dARB = (GL.Delegates.ProgramLocalParameter4dARB) GetAddress("glProgramLocalParameter4dARB", typeof(GL.Delegates.ProgramLocalParameter4dARB));
            GL.ProgramLocalParameter4dvARB = (GL.Delegates.ProgramLocalParameter4dvARB) GetAddress("glProgramLocalParameter4dvARB", typeof(GL.Delegates.ProgramLocalParameter4dvARB));
            GL.ProgramLocalParameter4fARB = (GL.Delegates.ProgramLocalParameter4fARB) GetAddress("glProgramLocalParameter4fARB", typeof(GL.Delegates.ProgramLocalParameter4fARB));
            GL.ProgramLocalParameter4fvARB = (GL.Delegates.ProgramLocalParameter4fvARB) GetAddress("glProgramLocalParameter4fvARB", typeof(GL.Delegates.ProgramLocalParameter4fvARB));
            GL.GetProgramEnvParameterdvARB = (GL.Delegates.GetProgramEnvParameterdvARB) GetAddress("glGetProgramEnvParameterdvARB", typeof(GL.Delegates.GetProgramEnvParameterdvARB));
            GL.GetProgramEnvParameterfvARB = (GL.Delegates.GetProgramEnvParameterfvARB) GetAddress("glGetProgramEnvParameterfvARB", typeof(GL.Delegates.GetProgramEnvParameterfvARB));
            GL.GetProgramLocalParameterdvARB = (GL.Delegates.GetProgramLocalParameterdvARB) GetAddress("glGetProgramLocalParameterdvARB", typeof(GL.Delegates.GetProgramLocalParameterdvARB));
            GL.GetProgramLocalParameterfvARB = (GL.Delegates.GetProgramLocalParameterfvARB) GetAddress("glGetProgramLocalParameterfvARB", typeof(GL.Delegates.GetProgramLocalParameterfvARB));
            GL.GetProgramivARB = (GL.Delegates.GetProgramivARB) GetAddress("glGetProgramivARB", typeof(GL.Delegates.GetProgramivARB));
            GL.GetProgramStringARB = (GL.Delegates.GetProgramStringARB) GetAddress("glGetProgramStringARB", typeof(GL.Delegates.GetProgramStringARB));
            GL.GetVertexAttribdvARB = (GL.Delegates.GetVertexAttribdvARB) GetAddress("glGetVertexAttribdvARB", typeof(GL.Delegates.GetVertexAttribdvARB));
            GL.GetVertexAttribfvARB = (GL.Delegates.GetVertexAttribfvARB) GetAddress("glGetVertexAttribfvARB", typeof(GL.Delegates.GetVertexAttribfvARB));
            GL.GetVertexAttribivARB = (GL.Delegates.GetVertexAttribivARB) GetAddress("glGetVertexAttribivARB", typeof(GL.Delegates.GetVertexAttribivARB));
            GL.GetVertexAttribPointervARB = (GL.Delegates.GetVertexAttribPointervARB) GetAddress("glGetVertexAttribPointervARB", typeof(GL.Delegates.GetVertexAttribPointervARB));
            GL.IsProgramARB = (GL.Delegates.IsProgramARB) GetAddress("glIsProgramARB", typeof(GL.Delegates.IsProgramARB));
            GL.BindBufferARB = (GL.Delegates.BindBufferARB) GetAddress("glBindBufferARB", typeof(GL.Delegates.BindBufferARB));
            GL.DeleteBuffersARB = (GL.Delegates.DeleteBuffersARB) GetAddress("glDeleteBuffersARB", typeof(GL.Delegates.DeleteBuffersARB));
            GL.GenBuffersARB = (GL.Delegates.GenBuffersARB) GetAddress("glGenBuffersARB", typeof(GL.Delegates.GenBuffersARB));
            GL.IsBufferARB = (GL.Delegates.IsBufferARB) GetAddress("glIsBufferARB", typeof(GL.Delegates.IsBufferARB));
            GL.BufferDataARB = (GL.Delegates.BufferDataARB) GetAddress("glBufferDataARB", typeof(GL.Delegates.BufferDataARB));
            GL.BufferSubDataARB = (GL.Delegates.BufferSubDataARB) GetAddress("glBufferSubDataARB", typeof(GL.Delegates.BufferSubDataARB));
            GL.GetBufferSubDataARB = (GL.Delegates.GetBufferSubDataARB) GetAddress("glGetBufferSubDataARB", typeof(GL.Delegates.GetBufferSubDataARB));
            GL.MapBufferARB_ = (GL.Delegates.MapBufferARB_) GetAddress("glMapBufferARB_", typeof(GL.Delegates.MapBufferARB_));
            GL.UnmapBufferARB = (GL.Delegates.UnmapBufferARB) GetAddress("glUnmapBufferARB", typeof(GL.Delegates.UnmapBufferARB));
            GL.GetBufferParameterivARB = (GL.Delegates.GetBufferParameterivARB) GetAddress("glGetBufferParameterivARB", typeof(GL.Delegates.GetBufferParameterivARB));
            GL.GetBufferPointervARB = (GL.Delegates.GetBufferPointervARB) GetAddress("glGetBufferPointervARB", typeof(GL.Delegates.GetBufferPointervARB));
            GL.GenQueriesARB = (GL.Delegates.GenQueriesARB) GetAddress("glGenQueriesARB", typeof(GL.Delegates.GenQueriesARB));
            GL.DeleteQueriesARB = (GL.Delegates.DeleteQueriesARB) GetAddress("glDeleteQueriesARB", typeof(GL.Delegates.DeleteQueriesARB));
            GL.IsQueryARB = (GL.Delegates.IsQueryARB) GetAddress("glIsQueryARB", typeof(GL.Delegates.IsQueryARB));
            GL.BeginQueryARB = (GL.Delegates.BeginQueryARB) GetAddress("glBeginQueryARB", typeof(GL.Delegates.BeginQueryARB));
            GL.EndQueryARB = (GL.Delegates.EndQueryARB) GetAddress("glEndQueryARB", typeof(GL.Delegates.EndQueryARB));
            GL.GetQueryivARB = (GL.Delegates.GetQueryivARB) GetAddress("glGetQueryivARB", typeof(GL.Delegates.GetQueryivARB));
            GL.GetQueryObjectivARB = (GL.Delegates.GetQueryObjectivARB) GetAddress("glGetQueryObjectivARB", typeof(GL.Delegates.GetQueryObjectivARB));
            GL.GetQueryObjectuivARB = (GL.Delegates.GetQueryObjectuivARB) GetAddress("glGetQueryObjectuivARB", typeof(GL.Delegates.GetQueryObjectuivARB));
            GL.DeleteObjectARB = (GL.Delegates.DeleteObjectARB) GetAddress("glDeleteObjectARB", typeof(GL.Delegates.DeleteObjectARB));
            GL.GetHandleARB = (GL.Delegates.GetHandleARB) GetAddress("glGetHandleARB", typeof(GL.Delegates.GetHandleARB));
            GL.DetachObjectARB = (GL.Delegates.DetachObjectARB) GetAddress("glDetachObjectARB", typeof(GL.Delegates.DetachObjectARB));
            GL.CreateShaderObjectARB = (GL.Delegates.CreateShaderObjectARB) GetAddress("glCreateShaderObjectARB", typeof(GL.Delegates.CreateShaderObjectARB));
            GL.ShaderSourceARB = (GL.Delegates.ShaderSourceARB) GetAddress("glShaderSourceARB", typeof(GL.Delegates.ShaderSourceARB));
            GL.CompileShaderARB = (GL.Delegates.CompileShaderARB) GetAddress("glCompileShaderARB", typeof(GL.Delegates.CompileShaderARB));
            GL.CreateProgramObjectARB = (GL.Delegates.CreateProgramObjectARB) GetAddress("glCreateProgramObjectARB", typeof(GL.Delegates.CreateProgramObjectARB));
            GL.AttachObjectARB = (GL.Delegates.AttachObjectARB) GetAddress("glAttachObjectARB", typeof(GL.Delegates.AttachObjectARB));
            GL.LinkProgramARB = (GL.Delegates.LinkProgramARB) GetAddress("glLinkProgramARB", typeof(GL.Delegates.LinkProgramARB));
            GL.UseProgramObjectARB = (GL.Delegates.UseProgramObjectARB) GetAddress("glUseProgramObjectARB", typeof(GL.Delegates.UseProgramObjectARB));
            GL.ValidateProgramARB = (GL.Delegates.ValidateProgramARB) GetAddress("glValidateProgramARB", typeof(GL.Delegates.ValidateProgramARB));
            GL.Uniform1fARB = (GL.Delegates.Uniform1fARB) GetAddress("glUniform1fARB", typeof(GL.Delegates.Uniform1fARB));
            GL.Uniform2fARB = (GL.Delegates.Uniform2fARB) GetAddress("glUniform2fARB", typeof(GL.Delegates.Uniform2fARB));
            GL.Uniform3fARB = (GL.Delegates.Uniform3fARB) GetAddress("glUniform3fARB", typeof(GL.Delegates.Uniform3fARB));
            GL.Uniform4fARB = (GL.Delegates.Uniform4fARB) GetAddress("glUniform4fARB", typeof(GL.Delegates.Uniform4fARB));
            GL.Uniform1iARB = (GL.Delegates.Uniform1iARB) GetAddress("glUniform1iARB", typeof(GL.Delegates.Uniform1iARB));
            GL.Uniform2iARB = (GL.Delegates.Uniform2iARB) GetAddress("glUniform2iARB", typeof(GL.Delegates.Uniform2iARB));
            GL.Uniform3iARB = (GL.Delegates.Uniform3iARB) GetAddress("glUniform3iARB", typeof(GL.Delegates.Uniform3iARB));
            GL.Uniform4iARB = (GL.Delegates.Uniform4iARB) GetAddress("glUniform4iARB", typeof(GL.Delegates.Uniform4iARB));
            GL.Uniform1fvARB = (GL.Delegates.Uniform1fvARB) GetAddress("glUniform1fvARB", typeof(GL.Delegates.Uniform1fvARB));
            GL.Uniform2fvARB = (GL.Delegates.Uniform2fvARB) GetAddress("glUniform2fvARB", typeof(GL.Delegates.Uniform2fvARB));
            GL.Uniform3fvARB = (GL.Delegates.Uniform3fvARB) GetAddress("glUniform3fvARB", typeof(GL.Delegates.Uniform3fvARB));
            GL.Uniform4fvARB = (GL.Delegates.Uniform4fvARB) GetAddress("glUniform4fvARB", typeof(GL.Delegates.Uniform4fvARB));
            GL.Uniform1ivARB = (GL.Delegates.Uniform1ivARB) GetAddress("glUniform1ivARB", typeof(GL.Delegates.Uniform1ivARB));
            GL.Uniform2ivARB = (GL.Delegates.Uniform2ivARB) GetAddress("glUniform2ivARB", typeof(GL.Delegates.Uniform2ivARB));
            GL.Uniform3ivARB = (GL.Delegates.Uniform3ivARB) GetAddress("glUniform3ivARB", typeof(GL.Delegates.Uniform3ivARB));
            GL.Uniform4ivARB = (GL.Delegates.Uniform4ivARB) GetAddress("glUniform4ivARB", typeof(GL.Delegates.Uniform4ivARB));
            GL.UniformMatrix2fvARB = (GL.Delegates.UniformMatrix2fvARB) GetAddress("glUniformMatrix2fvARB", typeof(GL.Delegates.UniformMatrix2fvARB));
            GL.UniformMatrix3fvARB = (GL.Delegates.UniformMatrix3fvARB) GetAddress("glUniformMatrix3fvARB", typeof(GL.Delegates.UniformMatrix3fvARB));
            GL.UniformMatrix4fvARB = (GL.Delegates.UniformMatrix4fvARB) GetAddress("glUniformMatrix4fvARB", typeof(GL.Delegates.UniformMatrix4fvARB));
            GL.GetObjectParameterfvARB = (GL.Delegates.GetObjectParameterfvARB) GetAddress("glGetObjectParameterfvARB", typeof(GL.Delegates.GetObjectParameterfvARB));
            GL.GetObjectParameterivARB = (GL.Delegates.GetObjectParameterivARB) GetAddress("glGetObjectParameterivARB", typeof(GL.Delegates.GetObjectParameterivARB));
            GL.GetInfoLogARB = (GL.Delegates.GetInfoLogARB) GetAddress("glGetInfoLogARB", typeof(GL.Delegates.GetInfoLogARB));
            GL.GetAttachedObjectsARB = (GL.Delegates.GetAttachedObjectsARB) GetAddress("glGetAttachedObjectsARB", typeof(GL.Delegates.GetAttachedObjectsARB));
            GL.GetUniformLocationARB = (GL.Delegates.GetUniformLocationARB) GetAddress("glGetUniformLocationARB", typeof(GL.Delegates.GetUniformLocationARB));
            GL.GetActiveUniformARB = (GL.Delegates.GetActiveUniformARB) GetAddress("glGetActiveUniformARB", typeof(GL.Delegates.GetActiveUniformARB));
            GL.GetUniformfvARB = (GL.Delegates.GetUniformfvARB) GetAddress("glGetUniformfvARB", typeof(GL.Delegates.GetUniformfvARB));
            GL.GetUniformivARB = (GL.Delegates.GetUniformivARB) GetAddress("glGetUniformivARB", typeof(GL.Delegates.GetUniformivARB));
            GL.GetShaderSourceARB = (GL.Delegates.GetShaderSourceARB) GetAddress("glGetShaderSourceARB", typeof(GL.Delegates.GetShaderSourceARB));
            GL.BindAttribLocationARB = (GL.Delegates.BindAttribLocationARB) GetAddress("glBindAttribLocationARB", typeof(GL.Delegates.BindAttribLocationARB));
            GL.GetActiveAttribARB = (GL.Delegates.GetActiveAttribARB) GetAddress("glGetActiveAttribARB", typeof(GL.Delegates.GetActiveAttribARB));
            GL.GetAttribLocationARB = (GL.Delegates.GetAttribLocationARB) GetAddress("glGetAttribLocationARB", typeof(GL.Delegates.GetAttribLocationARB));
            GL.DrawBuffersARB = (GL.Delegates.DrawBuffersARB) GetAddress("glDrawBuffersARB", typeof(GL.Delegates.DrawBuffersARB));
            GL.ClampColorARB = (GL.Delegates.ClampColorARB) GetAddress("glClampColorARB", typeof(GL.Delegates.ClampColorARB));
            GL.BlendColorEXT = (GL.Delegates.BlendColorEXT) GetAddress("glBlendColorEXT", typeof(GL.Delegates.BlendColorEXT));
            GL.PolygonOffsetEXT = (GL.Delegates.PolygonOffsetEXT) GetAddress("glPolygonOffsetEXT", typeof(GL.Delegates.PolygonOffsetEXT));
            GL.TexImage3DEXT = (GL.Delegates.TexImage3DEXT) GetAddress("glTexImage3DEXT", typeof(GL.Delegates.TexImage3DEXT));
            GL.TexSubImage3DEXT = (GL.Delegates.TexSubImage3DEXT) GetAddress("glTexSubImage3DEXT", typeof(GL.Delegates.TexSubImage3DEXT));
            GL.GetTexFilterFuncSGIS = (GL.Delegates.GetTexFilterFuncSGIS) GetAddress("glGetTexFilterFuncSGIS", typeof(GL.Delegates.GetTexFilterFuncSGIS));
            GL.TexFilterFuncSGIS = (GL.Delegates.TexFilterFuncSGIS) GetAddress("glTexFilterFuncSGIS", typeof(GL.Delegates.TexFilterFuncSGIS));
            GL.TexSubImage1DEXT = (GL.Delegates.TexSubImage1DEXT) GetAddress("glTexSubImage1DEXT", typeof(GL.Delegates.TexSubImage1DEXT));
            GL.TexSubImage2DEXT = (GL.Delegates.TexSubImage2DEXT) GetAddress("glTexSubImage2DEXT", typeof(GL.Delegates.TexSubImage2DEXT));
            GL.CopyTexImage1DEXT = (GL.Delegates.CopyTexImage1DEXT) GetAddress("glCopyTexImage1DEXT", typeof(GL.Delegates.CopyTexImage1DEXT));
            GL.CopyTexImage2DEXT = (GL.Delegates.CopyTexImage2DEXT) GetAddress("glCopyTexImage2DEXT", typeof(GL.Delegates.CopyTexImage2DEXT));
            GL.CopyTexSubImage1DEXT = (GL.Delegates.CopyTexSubImage1DEXT) GetAddress("glCopyTexSubImage1DEXT", typeof(GL.Delegates.CopyTexSubImage1DEXT));
            GL.CopyTexSubImage2DEXT = (GL.Delegates.CopyTexSubImage2DEXT) GetAddress("glCopyTexSubImage2DEXT", typeof(GL.Delegates.CopyTexSubImage2DEXT));
            GL.CopyTexSubImage3DEXT = (GL.Delegates.CopyTexSubImage3DEXT) GetAddress("glCopyTexSubImage3DEXT", typeof(GL.Delegates.CopyTexSubImage3DEXT));
            GL.GetHistogramEXT = (GL.Delegates.GetHistogramEXT) GetAddress("glGetHistogramEXT", typeof(GL.Delegates.GetHistogramEXT));
            GL.GetHistogramParameterfvEXT = (GL.Delegates.GetHistogramParameterfvEXT) GetAddress("glGetHistogramParameterfvEXT", typeof(GL.Delegates.GetHistogramParameterfvEXT));
            GL.GetHistogramParameterivEXT = (GL.Delegates.GetHistogramParameterivEXT) GetAddress("glGetHistogramParameterivEXT", typeof(GL.Delegates.GetHistogramParameterivEXT));
            GL.GetMinmaxEXT = (GL.Delegates.GetMinmaxEXT) GetAddress("glGetMinmaxEXT", typeof(GL.Delegates.GetMinmaxEXT));
            GL.GetMinmaxParameterfvEXT = (GL.Delegates.GetMinmaxParameterfvEXT) GetAddress("glGetMinmaxParameterfvEXT", typeof(GL.Delegates.GetMinmaxParameterfvEXT));
            GL.GetMinmaxParameterivEXT = (GL.Delegates.GetMinmaxParameterivEXT) GetAddress("glGetMinmaxParameterivEXT", typeof(GL.Delegates.GetMinmaxParameterivEXT));
            GL.HistogramEXT = (GL.Delegates.HistogramEXT) GetAddress("glHistogramEXT", typeof(GL.Delegates.HistogramEXT));
            GL.MinmaxEXT = (GL.Delegates.MinmaxEXT) GetAddress("glMinmaxEXT", typeof(GL.Delegates.MinmaxEXT));
            GL.ResetHistogramEXT = (GL.Delegates.ResetHistogramEXT) GetAddress("glResetHistogramEXT", typeof(GL.Delegates.ResetHistogramEXT));
            GL.ResetMinmaxEXT = (GL.Delegates.ResetMinmaxEXT) GetAddress("glResetMinmaxEXT", typeof(GL.Delegates.ResetMinmaxEXT));
            GL.ConvolutionFilter1DEXT = (GL.Delegates.ConvolutionFilter1DEXT) GetAddress("glConvolutionFilter1DEXT", typeof(GL.Delegates.ConvolutionFilter1DEXT));
            GL.ConvolutionFilter2DEXT = (GL.Delegates.ConvolutionFilter2DEXT) GetAddress("glConvolutionFilter2DEXT", typeof(GL.Delegates.ConvolutionFilter2DEXT));
            GL.ConvolutionParameterfEXT = (GL.Delegates.ConvolutionParameterfEXT) GetAddress("glConvolutionParameterfEXT", typeof(GL.Delegates.ConvolutionParameterfEXT));
            GL.ConvolutionParameterfvEXT = (GL.Delegates.ConvolutionParameterfvEXT) GetAddress("glConvolutionParameterfvEXT", typeof(GL.Delegates.ConvolutionParameterfvEXT));
            GL.ConvolutionParameteriEXT = (GL.Delegates.ConvolutionParameteriEXT) GetAddress("glConvolutionParameteriEXT", typeof(GL.Delegates.ConvolutionParameteriEXT));
            GL.ConvolutionParameterivEXT = (GL.Delegates.ConvolutionParameterivEXT) GetAddress("glConvolutionParameterivEXT", typeof(GL.Delegates.ConvolutionParameterivEXT));
            GL.CopyConvolutionFilter1DEXT = (GL.Delegates.CopyConvolutionFilter1DEXT) GetAddress("glCopyConvolutionFilter1DEXT", typeof(GL.Delegates.CopyConvolutionFilter1DEXT));
            GL.CopyConvolutionFilter2DEXT = (GL.Delegates.CopyConvolutionFilter2DEXT) GetAddress("glCopyConvolutionFilter2DEXT", typeof(GL.Delegates.CopyConvolutionFilter2DEXT));
            GL.GetConvolutionFilterEXT = (GL.Delegates.GetConvolutionFilterEXT) GetAddress("glGetConvolutionFilterEXT", typeof(GL.Delegates.GetConvolutionFilterEXT));
            GL.GetConvolutionParameterfvEXT = (GL.Delegates.GetConvolutionParameterfvEXT) GetAddress("glGetConvolutionParameterfvEXT", typeof(GL.Delegates.GetConvolutionParameterfvEXT));
            GL.GetConvolutionParameterivEXT = (GL.Delegates.GetConvolutionParameterivEXT) GetAddress("glGetConvolutionParameterivEXT", typeof(GL.Delegates.GetConvolutionParameterivEXT));
            GL.GetSeparableFilterEXT = (GL.Delegates.GetSeparableFilterEXT) GetAddress("glGetSeparableFilterEXT", typeof(GL.Delegates.GetSeparableFilterEXT));
            GL.SeparableFilter2DEXT = (GL.Delegates.SeparableFilter2DEXT) GetAddress("glSeparableFilter2DEXT", typeof(GL.Delegates.SeparableFilter2DEXT));
            GL.ColorTableSGI = (GL.Delegates.ColorTableSGI) GetAddress("glColorTableSGI", typeof(GL.Delegates.ColorTableSGI));
            GL.ColorTableParameterfvSGI = (GL.Delegates.ColorTableParameterfvSGI) GetAddress("glColorTableParameterfvSGI", typeof(GL.Delegates.ColorTableParameterfvSGI));
            GL.ColorTableParameterivSGI = (GL.Delegates.ColorTableParameterivSGI) GetAddress("glColorTableParameterivSGI", typeof(GL.Delegates.ColorTableParameterivSGI));
            GL.CopyColorTableSGI = (GL.Delegates.CopyColorTableSGI) GetAddress("glCopyColorTableSGI", typeof(GL.Delegates.CopyColorTableSGI));
            GL.GetColorTableSGI = (GL.Delegates.GetColorTableSGI) GetAddress("glGetColorTableSGI", typeof(GL.Delegates.GetColorTableSGI));
            GL.GetColorTableParameterfvSGI = (GL.Delegates.GetColorTableParameterfvSGI) GetAddress("glGetColorTableParameterfvSGI", typeof(GL.Delegates.GetColorTableParameterfvSGI));
            GL.GetColorTableParameterivSGI = (GL.Delegates.GetColorTableParameterivSGI) GetAddress("glGetColorTableParameterivSGI", typeof(GL.Delegates.GetColorTableParameterivSGI));
            GL.PixelTexGenSGIX = (GL.Delegates.PixelTexGenSGIX) GetAddress("glPixelTexGenSGIX", typeof(GL.Delegates.PixelTexGenSGIX));
            GL.PixelTexGenParameteriSGIS = (GL.Delegates.PixelTexGenParameteriSGIS) GetAddress("glPixelTexGenParameteriSGIS", typeof(GL.Delegates.PixelTexGenParameteriSGIS));
            GL.PixelTexGenParameterivSGIS = (GL.Delegates.PixelTexGenParameterivSGIS) GetAddress("glPixelTexGenParameterivSGIS", typeof(GL.Delegates.PixelTexGenParameterivSGIS));
            GL.PixelTexGenParameterfSGIS = (GL.Delegates.PixelTexGenParameterfSGIS) GetAddress("glPixelTexGenParameterfSGIS", typeof(GL.Delegates.PixelTexGenParameterfSGIS));
            GL.PixelTexGenParameterfvSGIS = (GL.Delegates.PixelTexGenParameterfvSGIS) GetAddress("glPixelTexGenParameterfvSGIS", typeof(GL.Delegates.PixelTexGenParameterfvSGIS));
            GL.GetPixelTexGenParameterivSGIS = (GL.Delegates.GetPixelTexGenParameterivSGIS) GetAddress("glGetPixelTexGenParameterivSGIS", typeof(GL.Delegates.GetPixelTexGenParameterivSGIS));
            GL.GetPixelTexGenParameterfvSGIS = (GL.Delegates.GetPixelTexGenParameterfvSGIS) GetAddress("glGetPixelTexGenParameterfvSGIS", typeof(GL.Delegates.GetPixelTexGenParameterfvSGIS));
            GL.TexImage4DSGIS = (GL.Delegates.TexImage4DSGIS) GetAddress("glTexImage4DSGIS", typeof(GL.Delegates.TexImage4DSGIS));
            GL.TexSubImage4DSGIS = (GL.Delegates.TexSubImage4DSGIS) GetAddress("glTexSubImage4DSGIS", typeof(GL.Delegates.TexSubImage4DSGIS));
            GL.AreTexturesResidentEXT = (GL.Delegates.AreTexturesResidentEXT) GetAddress("glAreTexturesResidentEXT", typeof(GL.Delegates.AreTexturesResidentEXT));
            GL.BindTextureEXT = (GL.Delegates.BindTextureEXT) GetAddress("glBindTextureEXT", typeof(GL.Delegates.BindTextureEXT));
            GL.DeleteTexturesEXT = (GL.Delegates.DeleteTexturesEXT) GetAddress("glDeleteTexturesEXT", typeof(GL.Delegates.DeleteTexturesEXT));
            GL.GenTexturesEXT = (GL.Delegates.GenTexturesEXT) GetAddress("glGenTexturesEXT", typeof(GL.Delegates.GenTexturesEXT));
            GL.IsTextureEXT = (GL.Delegates.IsTextureEXT) GetAddress("glIsTextureEXT", typeof(GL.Delegates.IsTextureEXT));
            GL.PrioritizeTexturesEXT = (GL.Delegates.PrioritizeTexturesEXT) GetAddress("glPrioritizeTexturesEXT", typeof(GL.Delegates.PrioritizeTexturesEXT));
            GL.DetailTexFuncSGIS = (GL.Delegates.DetailTexFuncSGIS) GetAddress("glDetailTexFuncSGIS", typeof(GL.Delegates.DetailTexFuncSGIS));
            GL.GetDetailTexFuncSGIS = (GL.Delegates.GetDetailTexFuncSGIS) GetAddress("glGetDetailTexFuncSGIS", typeof(GL.Delegates.GetDetailTexFuncSGIS));
            GL.SharpenTexFuncSGIS = (GL.Delegates.SharpenTexFuncSGIS) GetAddress("glSharpenTexFuncSGIS", typeof(GL.Delegates.SharpenTexFuncSGIS));
            GL.GetSharpenTexFuncSGIS = (GL.Delegates.GetSharpenTexFuncSGIS) GetAddress("glGetSharpenTexFuncSGIS", typeof(GL.Delegates.GetSharpenTexFuncSGIS));
            GL.SampleMaskSGIS = (GL.Delegates.SampleMaskSGIS) GetAddress("glSampleMaskSGIS", typeof(GL.Delegates.SampleMaskSGIS));
            GL.SamplePatternSGIS = (GL.Delegates.SamplePatternSGIS) GetAddress("glSamplePatternSGIS", typeof(GL.Delegates.SamplePatternSGIS));
            GL.ArrayElementEXT = (GL.Delegates.ArrayElementEXT) GetAddress("glArrayElementEXT", typeof(GL.Delegates.ArrayElementEXT));
            GL.ColorPointerEXT = (GL.Delegates.ColorPointerEXT) GetAddress("glColorPointerEXT", typeof(GL.Delegates.ColorPointerEXT));
            GL.DrawArraysEXT = (GL.Delegates.DrawArraysEXT) GetAddress("glDrawArraysEXT", typeof(GL.Delegates.DrawArraysEXT));
            GL.EdgeFlagPointerEXT = (GL.Delegates.EdgeFlagPointerEXT) GetAddress("glEdgeFlagPointerEXT", typeof(GL.Delegates.EdgeFlagPointerEXT));
            GL.GetPointervEXT = (GL.Delegates.GetPointervEXT) GetAddress("glGetPointervEXT", typeof(GL.Delegates.GetPointervEXT));
            GL.IndexPointerEXT = (GL.Delegates.IndexPointerEXT) GetAddress("glIndexPointerEXT", typeof(GL.Delegates.IndexPointerEXT));
            GL.NormalPointerEXT = (GL.Delegates.NormalPointerEXT) GetAddress("glNormalPointerEXT", typeof(GL.Delegates.NormalPointerEXT));
            GL.TexCoordPointerEXT = (GL.Delegates.TexCoordPointerEXT) GetAddress("glTexCoordPointerEXT", typeof(GL.Delegates.TexCoordPointerEXT));
            GL.VertexPointerEXT = (GL.Delegates.VertexPointerEXT) GetAddress("glVertexPointerEXT", typeof(GL.Delegates.VertexPointerEXT));
            GL.BlendEquationEXT = (GL.Delegates.BlendEquationEXT) GetAddress("glBlendEquationEXT", typeof(GL.Delegates.BlendEquationEXT));
            GL.SpriteParameterfSGIX = (GL.Delegates.SpriteParameterfSGIX) GetAddress("glSpriteParameterfSGIX", typeof(GL.Delegates.SpriteParameterfSGIX));
            GL.SpriteParameterfvSGIX = (GL.Delegates.SpriteParameterfvSGIX) GetAddress("glSpriteParameterfvSGIX", typeof(GL.Delegates.SpriteParameterfvSGIX));
            GL.SpriteParameteriSGIX = (GL.Delegates.SpriteParameteriSGIX) GetAddress("glSpriteParameteriSGIX", typeof(GL.Delegates.SpriteParameteriSGIX));
            GL.SpriteParameterivSGIX = (GL.Delegates.SpriteParameterivSGIX) GetAddress("glSpriteParameterivSGIX", typeof(GL.Delegates.SpriteParameterivSGIX));
            GL.PointParameterfEXT = (GL.Delegates.PointParameterfEXT) GetAddress("glPointParameterfEXT", typeof(GL.Delegates.PointParameterfEXT));
            GL.PointParameterfvEXT = (GL.Delegates.PointParameterfvEXT) GetAddress("glPointParameterfvEXT", typeof(GL.Delegates.PointParameterfvEXT));
            GL.PointParameterfSGIS = (GL.Delegates.PointParameterfSGIS) GetAddress("glPointParameterfSGIS", typeof(GL.Delegates.PointParameterfSGIS));
            GL.PointParameterfvSGIS = (GL.Delegates.PointParameterfvSGIS) GetAddress("glPointParameterfvSGIS", typeof(GL.Delegates.PointParameterfvSGIS));
            GL.GetInstrumentsSGIX = (GL.Delegates.GetInstrumentsSGIX) GetAddress("glGetInstrumentsSGIX", typeof(GL.Delegates.GetInstrumentsSGIX));
            GL.InstrumentsBufferSGIX = (GL.Delegates.InstrumentsBufferSGIX) GetAddress("glInstrumentsBufferSGIX", typeof(GL.Delegates.InstrumentsBufferSGIX));
            GL.PollInstrumentsSGIX = (GL.Delegates.PollInstrumentsSGIX) GetAddress("glPollInstrumentsSGIX", typeof(GL.Delegates.PollInstrumentsSGIX));
            GL.ReadInstrumentsSGIX = (GL.Delegates.ReadInstrumentsSGIX) GetAddress("glReadInstrumentsSGIX", typeof(GL.Delegates.ReadInstrumentsSGIX));
            GL.StartInstrumentsSGIX = (GL.Delegates.StartInstrumentsSGIX) GetAddress("glStartInstrumentsSGIX", typeof(GL.Delegates.StartInstrumentsSGIX));
            GL.StopInstrumentsSGIX = (GL.Delegates.StopInstrumentsSGIX) GetAddress("glStopInstrumentsSGIX", typeof(GL.Delegates.StopInstrumentsSGIX));
            GL.FrameZoomSGIX = (GL.Delegates.FrameZoomSGIX) GetAddress("glFrameZoomSGIX", typeof(GL.Delegates.FrameZoomSGIX));
            GL.TagSampleBufferSGIX = (GL.Delegates.TagSampleBufferSGIX) GetAddress("glTagSampleBufferSGIX", typeof(GL.Delegates.TagSampleBufferSGIX));
            GL.DeformationMap3dSGIX = (GL.Delegates.DeformationMap3dSGIX) GetAddress("glDeformationMap3dSGIX", typeof(GL.Delegates.DeformationMap3dSGIX));
            GL.DeformationMap3fSGIX = (GL.Delegates.DeformationMap3fSGIX) GetAddress("glDeformationMap3fSGIX", typeof(GL.Delegates.DeformationMap3fSGIX));
            GL.DeformSGIX = (GL.Delegates.DeformSGIX) GetAddress("glDeformSGIX", typeof(GL.Delegates.DeformSGIX));
            GL.LoadIdentityDeformationMapSGIX = (GL.Delegates.LoadIdentityDeformationMapSGIX) GetAddress("glLoadIdentityDeformationMapSGIX", typeof(GL.Delegates.LoadIdentityDeformationMapSGIX));
            GL.ReferencePlaneSGIX = (GL.Delegates.ReferencePlaneSGIX) GetAddress("glReferencePlaneSGIX", typeof(GL.Delegates.ReferencePlaneSGIX));
            GL.FlushRasterSGIX = (GL.Delegates.FlushRasterSGIX) GetAddress("glFlushRasterSGIX", typeof(GL.Delegates.FlushRasterSGIX));
            GL.FogFuncSGIS = (GL.Delegates.FogFuncSGIS) GetAddress("glFogFuncSGIS", typeof(GL.Delegates.FogFuncSGIS));
            GL.GetFogFuncSGIS = (GL.Delegates.GetFogFuncSGIS) GetAddress("glGetFogFuncSGIS", typeof(GL.Delegates.GetFogFuncSGIS));
            GL.ImageTransformParameteriHP = (GL.Delegates.ImageTransformParameteriHP) GetAddress("glImageTransformParameteriHP", typeof(GL.Delegates.ImageTransformParameteriHP));
            GL.ImageTransformParameterfHP = (GL.Delegates.ImageTransformParameterfHP) GetAddress("glImageTransformParameterfHP", typeof(GL.Delegates.ImageTransformParameterfHP));
            GL.ImageTransformParameterivHP = (GL.Delegates.ImageTransformParameterivHP) GetAddress("glImageTransformParameterivHP", typeof(GL.Delegates.ImageTransformParameterivHP));
            GL.ImageTransformParameterfvHP = (GL.Delegates.ImageTransformParameterfvHP) GetAddress("glImageTransformParameterfvHP", typeof(GL.Delegates.ImageTransformParameterfvHP));
            GL.GetImageTransformParameterivHP = (GL.Delegates.GetImageTransformParameterivHP) GetAddress("glGetImageTransformParameterivHP", typeof(GL.Delegates.GetImageTransformParameterivHP));
            GL.GetImageTransformParameterfvHP = (GL.Delegates.GetImageTransformParameterfvHP) GetAddress("glGetImageTransformParameterfvHP", typeof(GL.Delegates.GetImageTransformParameterfvHP));
            GL.ColorSubTableEXT = (GL.Delegates.ColorSubTableEXT) GetAddress("glColorSubTableEXT", typeof(GL.Delegates.ColorSubTableEXT));
            GL.CopyColorSubTableEXT = (GL.Delegates.CopyColorSubTableEXT) GetAddress("glCopyColorSubTableEXT", typeof(GL.Delegates.CopyColorSubTableEXT));
            GL.HintPGI = (GL.Delegates.HintPGI) GetAddress("glHintPGI", typeof(GL.Delegates.HintPGI));
            GL.ColorTableEXT = (GL.Delegates.ColorTableEXT) GetAddress("glColorTableEXT", typeof(GL.Delegates.ColorTableEXT));
            GL.GetColorTableEXT = (GL.Delegates.GetColorTableEXT) GetAddress("glGetColorTableEXT", typeof(GL.Delegates.GetColorTableEXT));
            GL.GetColorTableParameterivEXT = (GL.Delegates.GetColorTableParameterivEXT) GetAddress("glGetColorTableParameterivEXT", typeof(GL.Delegates.GetColorTableParameterivEXT));
            GL.GetColorTableParameterfvEXT = (GL.Delegates.GetColorTableParameterfvEXT) GetAddress("glGetColorTableParameterfvEXT", typeof(GL.Delegates.GetColorTableParameterfvEXT));
            GL.GetListParameterfvSGIX = (GL.Delegates.GetListParameterfvSGIX) GetAddress("glGetListParameterfvSGIX", typeof(GL.Delegates.GetListParameterfvSGIX));
            GL.GetListParameterivSGIX = (GL.Delegates.GetListParameterivSGIX) GetAddress("glGetListParameterivSGIX", typeof(GL.Delegates.GetListParameterivSGIX));
            GL.ListParameterfSGIX = (GL.Delegates.ListParameterfSGIX) GetAddress("glListParameterfSGIX", typeof(GL.Delegates.ListParameterfSGIX));
            GL.ListParameterfvSGIX = (GL.Delegates.ListParameterfvSGIX) GetAddress("glListParameterfvSGIX", typeof(GL.Delegates.ListParameterfvSGIX));
            GL.ListParameteriSGIX = (GL.Delegates.ListParameteriSGIX) GetAddress("glListParameteriSGIX", typeof(GL.Delegates.ListParameteriSGIX));
            GL.ListParameterivSGIX = (GL.Delegates.ListParameterivSGIX) GetAddress("glListParameterivSGIX", typeof(GL.Delegates.ListParameterivSGIX));
            GL.IndexMaterialEXT = (GL.Delegates.IndexMaterialEXT) GetAddress("glIndexMaterialEXT", typeof(GL.Delegates.IndexMaterialEXT));
            GL.IndexFuncEXT = (GL.Delegates.IndexFuncEXT) GetAddress("glIndexFuncEXT", typeof(GL.Delegates.IndexFuncEXT));
            GL.LockArraysEXT = (GL.Delegates.LockArraysEXT) GetAddress("glLockArraysEXT", typeof(GL.Delegates.LockArraysEXT));
            GL.UnlockArraysEXT = (GL.Delegates.UnlockArraysEXT) GetAddress("glUnlockArraysEXT", typeof(GL.Delegates.UnlockArraysEXT));
            GL.CullParameterdvEXT = (GL.Delegates.CullParameterdvEXT) GetAddress("glCullParameterdvEXT", typeof(GL.Delegates.CullParameterdvEXT));
            GL.CullParameterfvEXT = (GL.Delegates.CullParameterfvEXT) GetAddress("glCullParameterfvEXT", typeof(GL.Delegates.CullParameterfvEXT));
            GL.FragmentColorMaterialSGIX = (GL.Delegates.FragmentColorMaterialSGIX) GetAddress("glFragmentColorMaterialSGIX", typeof(GL.Delegates.FragmentColorMaterialSGIX));
            GL.FragmentLightfSGIX = (GL.Delegates.FragmentLightfSGIX) GetAddress("glFragmentLightfSGIX", typeof(GL.Delegates.FragmentLightfSGIX));
            GL.FragmentLightfvSGIX = (GL.Delegates.FragmentLightfvSGIX) GetAddress("glFragmentLightfvSGIX", typeof(GL.Delegates.FragmentLightfvSGIX));
            GL.FragmentLightiSGIX = (GL.Delegates.FragmentLightiSGIX) GetAddress("glFragmentLightiSGIX", typeof(GL.Delegates.FragmentLightiSGIX));
            GL.FragmentLightivSGIX = (GL.Delegates.FragmentLightivSGIX) GetAddress("glFragmentLightivSGIX", typeof(GL.Delegates.FragmentLightivSGIX));
            GL.FragmentLightModelfSGIX = (GL.Delegates.FragmentLightModelfSGIX) GetAddress("glFragmentLightModelfSGIX", typeof(GL.Delegates.FragmentLightModelfSGIX));
            GL.FragmentLightModelfvSGIX = (GL.Delegates.FragmentLightModelfvSGIX) GetAddress("glFragmentLightModelfvSGIX", typeof(GL.Delegates.FragmentLightModelfvSGIX));
            GL.FragmentLightModeliSGIX = (GL.Delegates.FragmentLightModeliSGIX) GetAddress("glFragmentLightModeliSGIX", typeof(GL.Delegates.FragmentLightModeliSGIX));
            GL.FragmentLightModelivSGIX = (GL.Delegates.FragmentLightModelivSGIX) GetAddress("glFragmentLightModelivSGIX", typeof(GL.Delegates.FragmentLightModelivSGIX));
            GL.FragmentMaterialfSGIX = (GL.Delegates.FragmentMaterialfSGIX) GetAddress("glFragmentMaterialfSGIX", typeof(GL.Delegates.FragmentMaterialfSGIX));
            GL.FragmentMaterialfvSGIX = (GL.Delegates.FragmentMaterialfvSGIX) GetAddress("glFragmentMaterialfvSGIX", typeof(GL.Delegates.FragmentMaterialfvSGIX));
            GL.FragmentMaterialiSGIX = (GL.Delegates.FragmentMaterialiSGIX) GetAddress("glFragmentMaterialiSGIX", typeof(GL.Delegates.FragmentMaterialiSGIX));
            GL.FragmentMaterialivSGIX = (GL.Delegates.FragmentMaterialivSGIX) GetAddress("glFragmentMaterialivSGIX", typeof(GL.Delegates.FragmentMaterialivSGIX));
            GL.GetFragmentLightfvSGIX = (GL.Delegates.GetFragmentLightfvSGIX) GetAddress("glGetFragmentLightfvSGIX", typeof(GL.Delegates.GetFragmentLightfvSGIX));
            GL.GetFragmentLightivSGIX = (GL.Delegates.GetFragmentLightivSGIX) GetAddress("glGetFragmentLightivSGIX", typeof(GL.Delegates.GetFragmentLightivSGIX));
            GL.GetFragmentMaterialfvSGIX = (GL.Delegates.GetFragmentMaterialfvSGIX) GetAddress("glGetFragmentMaterialfvSGIX", typeof(GL.Delegates.GetFragmentMaterialfvSGIX));
            GL.GetFragmentMaterialivSGIX = (GL.Delegates.GetFragmentMaterialivSGIX) GetAddress("glGetFragmentMaterialivSGIX", typeof(GL.Delegates.GetFragmentMaterialivSGIX));
            GL.LightEnviSGIX = (GL.Delegates.LightEnviSGIX) GetAddress("glLightEnviSGIX", typeof(GL.Delegates.LightEnviSGIX));
            GL.DrawRangeElementsEXT = (GL.Delegates.DrawRangeElementsEXT) GetAddress("glDrawRangeElementsEXT", typeof(GL.Delegates.DrawRangeElementsEXT));
            GL.ApplyTextureEXT = (GL.Delegates.ApplyTextureEXT) GetAddress("glApplyTextureEXT", typeof(GL.Delegates.ApplyTextureEXT));
            GL.TextureLightEXT = (GL.Delegates.TextureLightEXT) GetAddress("glTextureLightEXT", typeof(GL.Delegates.TextureLightEXT));
            GL.TextureMaterialEXT = (GL.Delegates.TextureMaterialEXT) GetAddress("glTextureMaterialEXT", typeof(GL.Delegates.TextureMaterialEXT));
            GL.AsyncMarkerSGIX = (GL.Delegates.AsyncMarkerSGIX) GetAddress("glAsyncMarkerSGIX", typeof(GL.Delegates.AsyncMarkerSGIX));
            GL.FinishAsyncSGIX = (GL.Delegates.FinishAsyncSGIX) GetAddress("glFinishAsyncSGIX", typeof(GL.Delegates.FinishAsyncSGIX));
            GL.PollAsyncSGIX = (GL.Delegates.PollAsyncSGIX) GetAddress("glPollAsyncSGIX", typeof(GL.Delegates.PollAsyncSGIX));
            GL.GenAsyncMarkersSGIX = (GL.Delegates.GenAsyncMarkersSGIX) GetAddress("glGenAsyncMarkersSGIX", typeof(GL.Delegates.GenAsyncMarkersSGIX));
            GL.DeleteAsyncMarkersSGIX = (GL.Delegates.DeleteAsyncMarkersSGIX) GetAddress("glDeleteAsyncMarkersSGIX", typeof(GL.Delegates.DeleteAsyncMarkersSGIX));
            GL.IsAsyncMarkerSGIX = (GL.Delegates.IsAsyncMarkerSGIX) GetAddress("glIsAsyncMarkerSGIX", typeof(GL.Delegates.IsAsyncMarkerSGIX));
            GL.VertexPointervINTEL = (GL.Delegates.VertexPointervINTEL) GetAddress("glVertexPointervINTEL", typeof(GL.Delegates.VertexPointervINTEL));
            GL.NormalPointervINTEL = (GL.Delegates.NormalPointervINTEL) GetAddress("glNormalPointervINTEL", typeof(GL.Delegates.NormalPointervINTEL));
            GL.ColorPointervINTEL = (GL.Delegates.ColorPointervINTEL) GetAddress("glColorPointervINTEL", typeof(GL.Delegates.ColorPointervINTEL));
            GL.TexCoordPointervINTEL = (GL.Delegates.TexCoordPointervINTEL) GetAddress("glTexCoordPointervINTEL", typeof(GL.Delegates.TexCoordPointervINTEL));
            GL.PixelTransformParameteriEXT = (GL.Delegates.PixelTransformParameteriEXT) GetAddress("glPixelTransformParameteriEXT", typeof(GL.Delegates.PixelTransformParameteriEXT));
            GL.PixelTransformParameterfEXT = (GL.Delegates.PixelTransformParameterfEXT) GetAddress("glPixelTransformParameterfEXT", typeof(GL.Delegates.PixelTransformParameterfEXT));
            GL.PixelTransformParameterivEXT = (GL.Delegates.PixelTransformParameterivEXT) GetAddress("glPixelTransformParameterivEXT", typeof(GL.Delegates.PixelTransformParameterivEXT));
            GL.PixelTransformParameterfvEXT = (GL.Delegates.PixelTransformParameterfvEXT) GetAddress("glPixelTransformParameterfvEXT", typeof(GL.Delegates.PixelTransformParameterfvEXT));
            GL.SecondaryColor3bEXT = (GL.Delegates.SecondaryColor3bEXT) GetAddress("glSecondaryColor3bEXT", typeof(GL.Delegates.SecondaryColor3bEXT));
            GL.SecondaryColor3bvEXT = (GL.Delegates.SecondaryColor3bvEXT) GetAddress("glSecondaryColor3bvEXT", typeof(GL.Delegates.SecondaryColor3bvEXT));
            GL.SecondaryColor3dEXT = (GL.Delegates.SecondaryColor3dEXT) GetAddress("glSecondaryColor3dEXT", typeof(GL.Delegates.SecondaryColor3dEXT));
            GL.SecondaryColor3dvEXT = (GL.Delegates.SecondaryColor3dvEXT) GetAddress("glSecondaryColor3dvEXT", typeof(GL.Delegates.SecondaryColor3dvEXT));
            GL.SecondaryColor3fEXT = (GL.Delegates.SecondaryColor3fEXT) GetAddress("glSecondaryColor3fEXT", typeof(GL.Delegates.SecondaryColor3fEXT));
            GL.SecondaryColor3fvEXT = (GL.Delegates.SecondaryColor3fvEXT) GetAddress("glSecondaryColor3fvEXT", typeof(GL.Delegates.SecondaryColor3fvEXT));
            GL.SecondaryColor3iEXT = (GL.Delegates.SecondaryColor3iEXT) GetAddress("glSecondaryColor3iEXT", typeof(GL.Delegates.SecondaryColor3iEXT));
            GL.SecondaryColor3ivEXT = (GL.Delegates.SecondaryColor3ivEXT) GetAddress("glSecondaryColor3ivEXT", typeof(GL.Delegates.SecondaryColor3ivEXT));
            GL.SecondaryColor3sEXT = (GL.Delegates.SecondaryColor3sEXT) GetAddress("glSecondaryColor3sEXT", typeof(GL.Delegates.SecondaryColor3sEXT));
            GL.SecondaryColor3svEXT = (GL.Delegates.SecondaryColor3svEXT) GetAddress("glSecondaryColor3svEXT", typeof(GL.Delegates.SecondaryColor3svEXT));
            GL.SecondaryColor3ubEXT = (GL.Delegates.SecondaryColor3ubEXT) GetAddress("glSecondaryColor3ubEXT", typeof(GL.Delegates.SecondaryColor3ubEXT));
            GL.SecondaryColor3ubvEXT = (GL.Delegates.SecondaryColor3ubvEXT) GetAddress("glSecondaryColor3ubvEXT", typeof(GL.Delegates.SecondaryColor3ubvEXT));
            GL.SecondaryColor3uiEXT = (GL.Delegates.SecondaryColor3uiEXT) GetAddress("glSecondaryColor3uiEXT", typeof(GL.Delegates.SecondaryColor3uiEXT));
            GL.SecondaryColor3uivEXT = (GL.Delegates.SecondaryColor3uivEXT) GetAddress("glSecondaryColor3uivEXT", typeof(GL.Delegates.SecondaryColor3uivEXT));
            GL.SecondaryColor3usEXT = (GL.Delegates.SecondaryColor3usEXT) GetAddress("glSecondaryColor3usEXT", typeof(GL.Delegates.SecondaryColor3usEXT));
            GL.SecondaryColor3usvEXT = (GL.Delegates.SecondaryColor3usvEXT) GetAddress("glSecondaryColor3usvEXT", typeof(GL.Delegates.SecondaryColor3usvEXT));
            GL.SecondaryColorPointerEXT = (GL.Delegates.SecondaryColorPointerEXT) GetAddress("glSecondaryColorPointerEXT", typeof(GL.Delegates.SecondaryColorPointerEXT));
            GL.TextureNormalEXT = (GL.Delegates.TextureNormalEXT) GetAddress("glTextureNormalEXT", typeof(GL.Delegates.TextureNormalEXT));
            GL.MultiDrawArraysEXT = (GL.Delegates.MultiDrawArraysEXT) GetAddress("glMultiDrawArraysEXT", typeof(GL.Delegates.MultiDrawArraysEXT));
            GL.MultiDrawElementsEXT = (GL.Delegates.MultiDrawElementsEXT) GetAddress("glMultiDrawElementsEXT", typeof(GL.Delegates.MultiDrawElementsEXT));
            GL.FogCoordfEXT = (GL.Delegates.FogCoordfEXT) GetAddress("glFogCoordfEXT", typeof(GL.Delegates.FogCoordfEXT));
            GL.FogCoordfvEXT = (GL.Delegates.FogCoordfvEXT) GetAddress("glFogCoordfvEXT", typeof(GL.Delegates.FogCoordfvEXT));
            GL.FogCoorddEXT = (GL.Delegates.FogCoorddEXT) GetAddress("glFogCoorddEXT", typeof(GL.Delegates.FogCoorddEXT));
            GL.FogCoorddvEXT = (GL.Delegates.FogCoorddvEXT) GetAddress("glFogCoorddvEXT", typeof(GL.Delegates.FogCoorddvEXT));
            GL.FogCoordPointerEXT = (GL.Delegates.FogCoordPointerEXT) GetAddress("glFogCoordPointerEXT", typeof(GL.Delegates.FogCoordPointerEXT));
            GL.Tangent3bEXT = (GL.Delegates.Tangent3bEXT) GetAddress("glTangent3bEXT", typeof(GL.Delegates.Tangent3bEXT));
            GL.Tangent3bvEXT = (GL.Delegates.Tangent3bvEXT) GetAddress("glTangent3bvEXT", typeof(GL.Delegates.Tangent3bvEXT));
            GL.Tangent3dEXT = (GL.Delegates.Tangent3dEXT) GetAddress("glTangent3dEXT", typeof(GL.Delegates.Tangent3dEXT));
            GL.Tangent3dvEXT = (GL.Delegates.Tangent3dvEXT) GetAddress("glTangent3dvEXT", typeof(GL.Delegates.Tangent3dvEXT));
            GL.Tangent3fEXT = (GL.Delegates.Tangent3fEXT) GetAddress("glTangent3fEXT", typeof(GL.Delegates.Tangent3fEXT));
            GL.Tangent3fvEXT = (GL.Delegates.Tangent3fvEXT) GetAddress("glTangent3fvEXT", typeof(GL.Delegates.Tangent3fvEXT));
            GL.Tangent3iEXT = (GL.Delegates.Tangent3iEXT) GetAddress("glTangent3iEXT", typeof(GL.Delegates.Tangent3iEXT));
            GL.Tangent3ivEXT = (GL.Delegates.Tangent3ivEXT) GetAddress("glTangent3ivEXT", typeof(GL.Delegates.Tangent3ivEXT));
            GL.Tangent3sEXT = (GL.Delegates.Tangent3sEXT) GetAddress("glTangent3sEXT", typeof(GL.Delegates.Tangent3sEXT));
            GL.Tangent3svEXT = (GL.Delegates.Tangent3svEXT) GetAddress("glTangent3svEXT", typeof(GL.Delegates.Tangent3svEXT));
            GL.Binormal3bEXT = (GL.Delegates.Binormal3bEXT) GetAddress("glBinormal3bEXT", typeof(GL.Delegates.Binormal3bEXT));
            GL.Binormal3bvEXT = (GL.Delegates.Binormal3bvEXT) GetAddress("glBinormal3bvEXT", typeof(GL.Delegates.Binormal3bvEXT));
            GL.Binormal3dEXT = (GL.Delegates.Binormal3dEXT) GetAddress("glBinormal3dEXT", typeof(GL.Delegates.Binormal3dEXT));
            GL.Binormal3dvEXT = (GL.Delegates.Binormal3dvEXT) GetAddress("glBinormal3dvEXT", typeof(GL.Delegates.Binormal3dvEXT));
            GL.Binormal3fEXT = (GL.Delegates.Binormal3fEXT) GetAddress("glBinormal3fEXT", typeof(GL.Delegates.Binormal3fEXT));
            GL.Binormal3fvEXT = (GL.Delegates.Binormal3fvEXT) GetAddress("glBinormal3fvEXT", typeof(GL.Delegates.Binormal3fvEXT));
            GL.Binormal3iEXT = (GL.Delegates.Binormal3iEXT) GetAddress("glBinormal3iEXT", typeof(GL.Delegates.Binormal3iEXT));
            GL.Binormal3ivEXT = (GL.Delegates.Binormal3ivEXT) GetAddress("glBinormal3ivEXT", typeof(GL.Delegates.Binormal3ivEXT));
            GL.Binormal3sEXT = (GL.Delegates.Binormal3sEXT) GetAddress("glBinormal3sEXT", typeof(GL.Delegates.Binormal3sEXT));
            GL.Binormal3svEXT = (GL.Delegates.Binormal3svEXT) GetAddress("glBinormal3svEXT", typeof(GL.Delegates.Binormal3svEXT));
            GL.TangentPointerEXT = (GL.Delegates.TangentPointerEXT) GetAddress("glTangentPointerEXT", typeof(GL.Delegates.TangentPointerEXT));
            GL.BinormalPointerEXT = (GL.Delegates.BinormalPointerEXT) GetAddress("glBinormalPointerEXT", typeof(GL.Delegates.BinormalPointerEXT));
            GL.FinishTextureSUNX = (GL.Delegates.FinishTextureSUNX) GetAddress("glFinishTextureSUNX", typeof(GL.Delegates.FinishTextureSUNX));
            GL.GlobalAlphaFactorbSUN = (GL.Delegates.GlobalAlphaFactorbSUN) GetAddress("glGlobalAlphaFactorbSUN", typeof(GL.Delegates.GlobalAlphaFactorbSUN));
            GL.GlobalAlphaFactorsSUN = (GL.Delegates.GlobalAlphaFactorsSUN) GetAddress("glGlobalAlphaFactorsSUN", typeof(GL.Delegates.GlobalAlphaFactorsSUN));
            GL.GlobalAlphaFactoriSUN = (GL.Delegates.GlobalAlphaFactoriSUN) GetAddress("glGlobalAlphaFactoriSUN", typeof(GL.Delegates.GlobalAlphaFactoriSUN));
            GL.GlobalAlphaFactorfSUN = (GL.Delegates.GlobalAlphaFactorfSUN) GetAddress("glGlobalAlphaFactorfSUN", typeof(GL.Delegates.GlobalAlphaFactorfSUN));
            GL.GlobalAlphaFactordSUN = (GL.Delegates.GlobalAlphaFactordSUN) GetAddress("glGlobalAlphaFactordSUN", typeof(GL.Delegates.GlobalAlphaFactordSUN));
            GL.GlobalAlphaFactorubSUN = (GL.Delegates.GlobalAlphaFactorubSUN) GetAddress("glGlobalAlphaFactorubSUN", typeof(GL.Delegates.GlobalAlphaFactorubSUN));
            GL.GlobalAlphaFactorusSUN = (GL.Delegates.GlobalAlphaFactorusSUN) GetAddress("glGlobalAlphaFactorusSUN", typeof(GL.Delegates.GlobalAlphaFactorusSUN));
            GL.GlobalAlphaFactoruiSUN = (GL.Delegates.GlobalAlphaFactoruiSUN) GetAddress("glGlobalAlphaFactoruiSUN", typeof(GL.Delegates.GlobalAlphaFactoruiSUN));
            GL.ReplacementCodeuiSUN = (GL.Delegates.ReplacementCodeuiSUN) GetAddress("glReplacementCodeuiSUN", typeof(GL.Delegates.ReplacementCodeuiSUN));
            GL.ReplacementCodeusSUN = (GL.Delegates.ReplacementCodeusSUN) GetAddress("glReplacementCodeusSUN", typeof(GL.Delegates.ReplacementCodeusSUN));
            GL.ReplacementCodeubSUN = (GL.Delegates.ReplacementCodeubSUN) GetAddress("glReplacementCodeubSUN", typeof(GL.Delegates.ReplacementCodeubSUN));
            GL.ReplacementCodeuivSUN = (GL.Delegates.ReplacementCodeuivSUN) GetAddress("glReplacementCodeuivSUN", typeof(GL.Delegates.ReplacementCodeuivSUN));
            GL.ReplacementCodeusvSUN = (GL.Delegates.ReplacementCodeusvSUN) GetAddress("glReplacementCodeusvSUN", typeof(GL.Delegates.ReplacementCodeusvSUN));
            GL.ReplacementCodeubvSUN = (GL.Delegates.ReplacementCodeubvSUN) GetAddress("glReplacementCodeubvSUN", typeof(GL.Delegates.ReplacementCodeubvSUN));
            GL.ReplacementCodePointerSUN = (GL.Delegates.ReplacementCodePointerSUN) GetAddress("glReplacementCodePointerSUN", typeof(GL.Delegates.ReplacementCodePointerSUN));
            GL.Color4ubVertex2fSUN = (GL.Delegates.Color4ubVertex2fSUN) GetAddress("glColor4ubVertex2fSUN", typeof(GL.Delegates.Color4ubVertex2fSUN));
            GL.Color4ubVertex2fvSUN = (GL.Delegates.Color4ubVertex2fvSUN) GetAddress("glColor4ubVertex2fvSUN", typeof(GL.Delegates.Color4ubVertex2fvSUN));
            GL.Color4ubVertex3fSUN = (GL.Delegates.Color4ubVertex3fSUN) GetAddress("glColor4ubVertex3fSUN", typeof(GL.Delegates.Color4ubVertex3fSUN));
            GL.Color4ubVertex3fvSUN = (GL.Delegates.Color4ubVertex3fvSUN) GetAddress("glColor4ubVertex3fvSUN", typeof(GL.Delegates.Color4ubVertex3fvSUN));
            GL.Color3fVertex3fSUN = (GL.Delegates.Color3fVertex3fSUN) GetAddress("glColor3fVertex3fSUN", typeof(GL.Delegates.Color3fVertex3fSUN));
            GL.Color3fVertex3fvSUN = (GL.Delegates.Color3fVertex3fvSUN) GetAddress("glColor3fVertex3fvSUN", typeof(GL.Delegates.Color3fVertex3fvSUN));
            GL.Normal3fVertex3fSUN = (GL.Delegates.Normal3fVertex3fSUN) GetAddress("glNormal3fVertex3fSUN", typeof(GL.Delegates.Normal3fVertex3fSUN));
            GL.Normal3fVertex3fvSUN = (GL.Delegates.Normal3fVertex3fvSUN) GetAddress("glNormal3fVertex3fvSUN", typeof(GL.Delegates.Normal3fVertex3fvSUN));
            GL.Color4fNormal3fVertex3fSUN = (GL.Delegates.Color4fNormal3fVertex3fSUN) GetAddress("glColor4fNormal3fVertex3fSUN", typeof(GL.Delegates.Color4fNormal3fVertex3fSUN));
            GL.Color4fNormal3fVertex3fvSUN = (GL.Delegates.Color4fNormal3fVertex3fvSUN) GetAddress("glColor4fNormal3fVertex3fvSUN", typeof(GL.Delegates.Color4fNormal3fVertex3fvSUN));
            GL.TexCoord2fVertex3fSUN = (GL.Delegates.TexCoord2fVertex3fSUN) GetAddress("glTexCoord2fVertex3fSUN", typeof(GL.Delegates.TexCoord2fVertex3fSUN));
            GL.TexCoord2fVertex3fvSUN = (GL.Delegates.TexCoord2fVertex3fvSUN) GetAddress("glTexCoord2fVertex3fvSUN", typeof(GL.Delegates.TexCoord2fVertex3fvSUN));
            GL.TexCoord4fVertex4fSUN = (GL.Delegates.TexCoord4fVertex4fSUN) GetAddress("glTexCoord4fVertex4fSUN", typeof(GL.Delegates.TexCoord4fVertex4fSUN));
            GL.TexCoord4fVertex4fvSUN = (GL.Delegates.TexCoord4fVertex4fvSUN) GetAddress("glTexCoord4fVertex4fvSUN", typeof(GL.Delegates.TexCoord4fVertex4fvSUN));
            GL.TexCoord2fColor4ubVertex3fSUN = (GL.Delegates.TexCoord2fColor4ubVertex3fSUN) GetAddress("glTexCoord2fColor4ubVertex3fSUN", typeof(GL.Delegates.TexCoord2fColor4ubVertex3fSUN));
            GL.TexCoord2fColor4ubVertex3fvSUN = (GL.Delegates.TexCoord2fColor4ubVertex3fvSUN) GetAddress("glTexCoord2fColor4ubVertex3fvSUN", typeof(GL.Delegates.TexCoord2fColor4ubVertex3fvSUN));
            GL.TexCoord2fColor3fVertex3fSUN = (GL.Delegates.TexCoord2fColor3fVertex3fSUN) GetAddress("glTexCoord2fColor3fVertex3fSUN", typeof(GL.Delegates.TexCoord2fColor3fVertex3fSUN));
            GL.TexCoord2fColor3fVertex3fvSUN = (GL.Delegates.TexCoord2fColor3fVertex3fvSUN) GetAddress("glTexCoord2fColor3fVertex3fvSUN", typeof(GL.Delegates.TexCoord2fColor3fVertex3fvSUN));
            GL.TexCoord2fNormal3fVertex3fSUN = (GL.Delegates.TexCoord2fNormal3fVertex3fSUN) GetAddress("glTexCoord2fNormal3fVertex3fSUN", typeof(GL.Delegates.TexCoord2fNormal3fVertex3fSUN));
            GL.TexCoord2fNormal3fVertex3fvSUN = (GL.Delegates.TexCoord2fNormal3fVertex3fvSUN) GetAddress("glTexCoord2fNormal3fVertex3fvSUN", typeof(GL.Delegates.TexCoord2fNormal3fVertex3fvSUN));
            GL.TexCoord2fColor4fNormal3fVertex3fSUN = (GL.Delegates.TexCoord2fColor4fNormal3fVertex3fSUN) GetAddress("glTexCoord2fColor4fNormal3fVertex3fSUN", typeof(GL.Delegates.TexCoord2fColor4fNormal3fVertex3fSUN));
            GL.TexCoord2fColor4fNormal3fVertex3fvSUN = (GL.Delegates.TexCoord2fColor4fNormal3fVertex3fvSUN) GetAddress("glTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(GL.Delegates.TexCoord2fColor4fNormal3fVertex3fvSUN));
            GL.TexCoord4fColor4fNormal3fVertex4fSUN = (GL.Delegates.TexCoord4fColor4fNormal3fVertex4fSUN) GetAddress("glTexCoord4fColor4fNormal3fVertex4fSUN", typeof(GL.Delegates.TexCoord4fColor4fNormal3fVertex4fSUN));
            GL.TexCoord4fColor4fNormal3fVertex4fvSUN = (GL.Delegates.TexCoord4fColor4fNormal3fVertex4fvSUN) GetAddress("glTexCoord4fColor4fNormal3fVertex4fvSUN", typeof(GL.Delegates.TexCoord4fColor4fNormal3fVertex4fvSUN));
            GL.ReplacementCodeuiVertex3fSUN = (GL.Delegates.ReplacementCodeuiVertex3fSUN) GetAddress("glReplacementCodeuiVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiVertex3fSUN));
            GL.ReplacementCodeuiVertex3fvSUN = (GL.Delegates.ReplacementCodeuiVertex3fvSUN) GetAddress("glReplacementCodeuiVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiVertex3fvSUN));
            GL.ReplacementCodeuiColor4ubVertex3fSUN = (GL.Delegates.ReplacementCodeuiColor4ubVertex3fSUN) GetAddress("glReplacementCodeuiColor4ubVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiColor4ubVertex3fSUN));
            GL.ReplacementCodeuiColor4ubVertex3fvSUN = (GL.Delegates.ReplacementCodeuiColor4ubVertex3fvSUN) GetAddress("glReplacementCodeuiColor4ubVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiColor4ubVertex3fvSUN));
            GL.ReplacementCodeuiColor3fVertex3fSUN = (GL.Delegates.ReplacementCodeuiColor3fVertex3fSUN) GetAddress("glReplacementCodeuiColor3fVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiColor3fVertex3fSUN));
            GL.ReplacementCodeuiColor3fVertex3fvSUN = (GL.Delegates.ReplacementCodeuiColor3fVertex3fvSUN) GetAddress("glReplacementCodeuiColor3fVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiColor3fVertex3fvSUN));
            GL.ReplacementCodeuiNormal3fVertex3fSUN = (GL.Delegates.ReplacementCodeuiNormal3fVertex3fSUN) GetAddress("glReplacementCodeuiNormal3fVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiNormal3fVertex3fSUN));
            GL.ReplacementCodeuiNormal3fVertex3fvSUN = (GL.Delegates.ReplacementCodeuiNormal3fVertex3fvSUN) GetAddress("glReplacementCodeuiNormal3fVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiNormal3fVertex3fvSUN));
            GL.ReplacementCodeuiColor4fNormal3fVertex3fSUN = (GL.Delegates.ReplacementCodeuiColor4fNormal3fVertex3fSUN) GetAddress("glReplacementCodeuiColor4fNormal3fVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiColor4fNormal3fVertex3fSUN));
            GL.ReplacementCodeuiColor4fNormal3fVertex3fvSUN = (GL.Delegates.ReplacementCodeuiColor4fNormal3fVertex3fvSUN) GetAddress("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiColor4fNormal3fVertex3fvSUN));
            GL.ReplacementCodeuiTexCoord2fVertex3fSUN = (GL.Delegates.ReplacementCodeuiTexCoord2fVertex3fSUN) GetAddress("glReplacementCodeuiTexCoord2fVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiTexCoord2fVertex3fSUN));
            GL.ReplacementCodeuiTexCoord2fVertex3fvSUN = (GL.Delegates.ReplacementCodeuiTexCoord2fVertex3fvSUN) GetAddress("glReplacementCodeuiTexCoord2fVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiTexCoord2fVertex3fvSUN));
            GL.ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = (GL.Delegates.ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN) GetAddress("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN));
            GL.ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = (GL.Delegates.ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN) GetAddress("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN));
            GL.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = (GL.Delegates.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN) GetAddress("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", typeof(GL.Delegates.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN));
            GL.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = (GL.Delegates.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN) GetAddress("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(GL.Delegates.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN));
            GL.BlendFuncSeparateEXT = (GL.Delegates.BlendFuncSeparateEXT) GetAddress("glBlendFuncSeparateEXT", typeof(GL.Delegates.BlendFuncSeparateEXT));
            GL.BlendFuncSeparateINGR = (GL.Delegates.BlendFuncSeparateINGR) GetAddress("glBlendFuncSeparateINGR", typeof(GL.Delegates.BlendFuncSeparateINGR));
            GL.VertexWeightfEXT = (GL.Delegates.VertexWeightfEXT) GetAddress("glVertexWeightfEXT", typeof(GL.Delegates.VertexWeightfEXT));
            GL.VertexWeightfvEXT = (GL.Delegates.VertexWeightfvEXT) GetAddress("glVertexWeightfvEXT", typeof(GL.Delegates.VertexWeightfvEXT));
            GL.VertexWeightPointerEXT = (GL.Delegates.VertexWeightPointerEXT) GetAddress("glVertexWeightPointerEXT", typeof(GL.Delegates.VertexWeightPointerEXT));
            GL.FlushVertexArrayRangeNV = (GL.Delegates.FlushVertexArrayRangeNV) GetAddress("glFlushVertexArrayRangeNV", typeof(GL.Delegates.FlushVertexArrayRangeNV));
            GL.VertexArrayRangeNV = (GL.Delegates.VertexArrayRangeNV) GetAddress("glVertexArrayRangeNV", typeof(GL.Delegates.VertexArrayRangeNV));
            GL.CombinerParameterfvNV = (GL.Delegates.CombinerParameterfvNV) GetAddress("glCombinerParameterfvNV", typeof(GL.Delegates.CombinerParameterfvNV));
            GL.CombinerParameterfNV = (GL.Delegates.CombinerParameterfNV) GetAddress("glCombinerParameterfNV", typeof(GL.Delegates.CombinerParameterfNV));
            GL.CombinerParameterivNV = (GL.Delegates.CombinerParameterivNV) GetAddress("glCombinerParameterivNV", typeof(GL.Delegates.CombinerParameterivNV));
            GL.CombinerParameteriNV = (GL.Delegates.CombinerParameteriNV) GetAddress("glCombinerParameteriNV", typeof(GL.Delegates.CombinerParameteriNV));
            GL.CombinerInputNV = (GL.Delegates.CombinerInputNV) GetAddress("glCombinerInputNV", typeof(GL.Delegates.CombinerInputNV));
            GL.CombinerOutputNV = (GL.Delegates.CombinerOutputNV) GetAddress("glCombinerOutputNV", typeof(GL.Delegates.CombinerOutputNV));
            GL.FinalCombinerInputNV = (GL.Delegates.FinalCombinerInputNV) GetAddress("glFinalCombinerInputNV", typeof(GL.Delegates.FinalCombinerInputNV));
            GL.GetCombinerInputParameterfvNV = (GL.Delegates.GetCombinerInputParameterfvNV) GetAddress("glGetCombinerInputParameterfvNV", typeof(GL.Delegates.GetCombinerInputParameterfvNV));
            GL.GetCombinerInputParameterivNV = (GL.Delegates.GetCombinerInputParameterivNV) GetAddress("glGetCombinerInputParameterivNV", typeof(GL.Delegates.GetCombinerInputParameterivNV));
            GL.GetCombinerOutputParameterfvNV = (GL.Delegates.GetCombinerOutputParameterfvNV) GetAddress("glGetCombinerOutputParameterfvNV", typeof(GL.Delegates.GetCombinerOutputParameterfvNV));
            GL.GetCombinerOutputParameterivNV = (GL.Delegates.GetCombinerOutputParameterivNV) GetAddress("glGetCombinerOutputParameterivNV", typeof(GL.Delegates.GetCombinerOutputParameterivNV));
            GL.GetFinalCombinerInputParameterfvNV = (GL.Delegates.GetFinalCombinerInputParameterfvNV) GetAddress("glGetFinalCombinerInputParameterfvNV", typeof(GL.Delegates.GetFinalCombinerInputParameterfvNV));
            GL.GetFinalCombinerInputParameterivNV = (GL.Delegates.GetFinalCombinerInputParameterivNV) GetAddress("glGetFinalCombinerInputParameterivNV", typeof(GL.Delegates.GetFinalCombinerInputParameterivNV));
            GL.ResizeBuffersMESA = (GL.Delegates.ResizeBuffersMESA) GetAddress("glResizeBuffersMESA", typeof(GL.Delegates.ResizeBuffersMESA));
            GL.WindowPos2dMESA = (GL.Delegates.WindowPos2dMESA) GetAddress("glWindowPos2dMESA", typeof(GL.Delegates.WindowPos2dMESA));
            GL.WindowPos2dvMESA = (GL.Delegates.WindowPos2dvMESA) GetAddress("glWindowPos2dvMESA", typeof(GL.Delegates.WindowPos2dvMESA));
            GL.WindowPos2fMESA = (GL.Delegates.WindowPos2fMESA) GetAddress("glWindowPos2fMESA", typeof(GL.Delegates.WindowPos2fMESA));
            GL.WindowPos2fvMESA = (GL.Delegates.WindowPos2fvMESA) GetAddress("glWindowPos2fvMESA", typeof(GL.Delegates.WindowPos2fvMESA));
            GL.WindowPos2iMESA = (GL.Delegates.WindowPos2iMESA) GetAddress("glWindowPos2iMESA", typeof(GL.Delegates.WindowPos2iMESA));
            GL.WindowPos2ivMESA = (GL.Delegates.WindowPos2ivMESA) GetAddress("glWindowPos2ivMESA", typeof(GL.Delegates.WindowPos2ivMESA));
            GL.WindowPos2sMESA = (GL.Delegates.WindowPos2sMESA) GetAddress("glWindowPos2sMESA", typeof(GL.Delegates.WindowPos2sMESA));
            GL.WindowPos2svMESA = (GL.Delegates.WindowPos2svMESA) GetAddress("glWindowPos2svMESA", typeof(GL.Delegates.WindowPos2svMESA));
            GL.WindowPos3dMESA = (GL.Delegates.WindowPos3dMESA) GetAddress("glWindowPos3dMESA", typeof(GL.Delegates.WindowPos3dMESA));
            GL.WindowPos3dvMESA = (GL.Delegates.WindowPos3dvMESA) GetAddress("glWindowPos3dvMESA", typeof(GL.Delegates.WindowPos3dvMESA));
            GL.WindowPos3fMESA = (GL.Delegates.WindowPos3fMESA) GetAddress("glWindowPos3fMESA", typeof(GL.Delegates.WindowPos3fMESA));
            GL.WindowPos3fvMESA = (GL.Delegates.WindowPos3fvMESA) GetAddress("glWindowPos3fvMESA", typeof(GL.Delegates.WindowPos3fvMESA));
            GL.WindowPos3iMESA = (GL.Delegates.WindowPos3iMESA) GetAddress("glWindowPos3iMESA", typeof(GL.Delegates.WindowPos3iMESA));
            GL.WindowPos3ivMESA = (GL.Delegates.WindowPos3ivMESA) GetAddress("glWindowPos3ivMESA", typeof(GL.Delegates.WindowPos3ivMESA));
            GL.WindowPos3sMESA = (GL.Delegates.WindowPos3sMESA) GetAddress("glWindowPos3sMESA", typeof(GL.Delegates.WindowPos3sMESA));
            GL.WindowPos3svMESA = (GL.Delegates.WindowPos3svMESA) GetAddress("glWindowPos3svMESA", typeof(GL.Delegates.WindowPos3svMESA));
            GL.WindowPos4dMESA = (GL.Delegates.WindowPos4dMESA) GetAddress("glWindowPos4dMESA", typeof(GL.Delegates.WindowPos4dMESA));
            GL.WindowPos4dvMESA = (GL.Delegates.WindowPos4dvMESA) GetAddress("glWindowPos4dvMESA", typeof(GL.Delegates.WindowPos4dvMESA));
            GL.WindowPos4fMESA = (GL.Delegates.WindowPos4fMESA) GetAddress("glWindowPos4fMESA", typeof(GL.Delegates.WindowPos4fMESA));
            GL.WindowPos4fvMESA = (GL.Delegates.WindowPos4fvMESA) GetAddress("glWindowPos4fvMESA", typeof(GL.Delegates.WindowPos4fvMESA));
            GL.WindowPos4iMESA = (GL.Delegates.WindowPos4iMESA) GetAddress("glWindowPos4iMESA", typeof(GL.Delegates.WindowPos4iMESA));
            GL.WindowPos4ivMESA = (GL.Delegates.WindowPos4ivMESA) GetAddress("glWindowPos4ivMESA", typeof(GL.Delegates.WindowPos4ivMESA));
            GL.WindowPos4sMESA = (GL.Delegates.WindowPos4sMESA) GetAddress("glWindowPos4sMESA", typeof(GL.Delegates.WindowPos4sMESA));
            GL.WindowPos4svMESA = (GL.Delegates.WindowPos4svMESA) GetAddress("glWindowPos4svMESA", typeof(GL.Delegates.WindowPos4svMESA));
            GL.MultiModeDrawArraysIBM = (GL.Delegates.MultiModeDrawArraysIBM) GetAddress("glMultiModeDrawArraysIBM", typeof(GL.Delegates.MultiModeDrawArraysIBM));
            GL.MultiModeDrawElementsIBM = (GL.Delegates.MultiModeDrawElementsIBM) GetAddress("glMultiModeDrawElementsIBM", typeof(GL.Delegates.MultiModeDrawElementsIBM));
            GL.ColorPointerListIBM = (GL.Delegates.ColorPointerListIBM) GetAddress("glColorPointerListIBM", typeof(GL.Delegates.ColorPointerListIBM));
            GL.SecondaryColorPointerListIBM = (GL.Delegates.SecondaryColorPointerListIBM) GetAddress("glSecondaryColorPointerListIBM", typeof(GL.Delegates.SecondaryColorPointerListIBM));
            GL.EdgeFlagPointerListIBM = (GL.Delegates.EdgeFlagPointerListIBM) GetAddress("glEdgeFlagPointerListIBM", typeof(GL.Delegates.EdgeFlagPointerListIBM));
            GL.FogCoordPointerListIBM = (GL.Delegates.FogCoordPointerListIBM) GetAddress("glFogCoordPointerListIBM", typeof(GL.Delegates.FogCoordPointerListIBM));
            GL.IndexPointerListIBM = (GL.Delegates.IndexPointerListIBM) GetAddress("glIndexPointerListIBM", typeof(GL.Delegates.IndexPointerListIBM));
            GL.NormalPointerListIBM = (GL.Delegates.NormalPointerListIBM) GetAddress("glNormalPointerListIBM", typeof(GL.Delegates.NormalPointerListIBM));
            GL.TexCoordPointerListIBM = (GL.Delegates.TexCoordPointerListIBM) GetAddress("glTexCoordPointerListIBM", typeof(GL.Delegates.TexCoordPointerListIBM));
            GL.VertexPointerListIBM = (GL.Delegates.VertexPointerListIBM) GetAddress("glVertexPointerListIBM", typeof(GL.Delegates.VertexPointerListIBM));
            GL.TbufferMask3DFX = (GL.Delegates.TbufferMask3DFX) GetAddress("glTbufferMask3DFX", typeof(GL.Delegates.TbufferMask3DFX));
            GL.SampleMaskEXT = (GL.Delegates.SampleMaskEXT) GetAddress("glSampleMaskEXT", typeof(GL.Delegates.SampleMaskEXT));
            GL.SamplePatternEXT = (GL.Delegates.SamplePatternEXT) GetAddress("glSamplePatternEXT", typeof(GL.Delegates.SamplePatternEXT));
            GL.TextureColorMaskSGIS = (GL.Delegates.TextureColorMaskSGIS) GetAddress("glTextureColorMaskSGIS", typeof(GL.Delegates.TextureColorMaskSGIS));
            GL.IglooInterfaceSGIX = (GL.Delegates.IglooInterfaceSGIX) GetAddress("glIglooInterfaceSGIX", typeof(GL.Delegates.IglooInterfaceSGIX));
            GL.DeleteFencesNV = (GL.Delegates.DeleteFencesNV) GetAddress("glDeleteFencesNV", typeof(GL.Delegates.DeleteFencesNV));
            GL.GenFencesNV = (GL.Delegates.GenFencesNV) GetAddress("glGenFencesNV", typeof(GL.Delegates.GenFencesNV));
            GL.IsFenceNV = (GL.Delegates.IsFenceNV) GetAddress("glIsFenceNV", typeof(GL.Delegates.IsFenceNV));
            GL.TestFenceNV = (GL.Delegates.TestFenceNV) GetAddress("glTestFenceNV", typeof(GL.Delegates.TestFenceNV));
            GL.GetFenceivNV = (GL.Delegates.GetFenceivNV) GetAddress("glGetFenceivNV", typeof(GL.Delegates.GetFenceivNV));
            GL.FinishFenceNV = (GL.Delegates.FinishFenceNV) GetAddress("glFinishFenceNV", typeof(GL.Delegates.FinishFenceNV));
            GL.SetFenceNV = (GL.Delegates.SetFenceNV) GetAddress("glSetFenceNV", typeof(GL.Delegates.SetFenceNV));
            GL.MapControlPointsNV = (GL.Delegates.MapControlPointsNV) GetAddress("glMapControlPointsNV", typeof(GL.Delegates.MapControlPointsNV));
            GL.MapParameterivNV = (GL.Delegates.MapParameterivNV) GetAddress("glMapParameterivNV", typeof(GL.Delegates.MapParameterivNV));
            GL.MapParameterfvNV = (GL.Delegates.MapParameterfvNV) GetAddress("glMapParameterfvNV", typeof(GL.Delegates.MapParameterfvNV));
            GL.GetMapControlPointsNV = (GL.Delegates.GetMapControlPointsNV) GetAddress("glGetMapControlPointsNV", typeof(GL.Delegates.GetMapControlPointsNV));
            GL.GetMapParameterivNV = (GL.Delegates.GetMapParameterivNV) GetAddress("glGetMapParameterivNV", typeof(GL.Delegates.GetMapParameterivNV));
            GL.GetMapParameterfvNV = (GL.Delegates.GetMapParameterfvNV) GetAddress("glGetMapParameterfvNV", typeof(GL.Delegates.GetMapParameterfvNV));
            GL.GetMapAttribParameterivNV = (GL.Delegates.GetMapAttribParameterivNV) GetAddress("glGetMapAttribParameterivNV", typeof(GL.Delegates.GetMapAttribParameterivNV));
            GL.GetMapAttribParameterfvNV = (GL.Delegates.GetMapAttribParameterfvNV) GetAddress("glGetMapAttribParameterfvNV", typeof(GL.Delegates.GetMapAttribParameterfvNV));
            GL.EvalMapsNV = (GL.Delegates.EvalMapsNV) GetAddress("glEvalMapsNV", typeof(GL.Delegates.EvalMapsNV));
            GL.CombinerStageParameterfvNV = (GL.Delegates.CombinerStageParameterfvNV) GetAddress("glCombinerStageParameterfvNV", typeof(GL.Delegates.CombinerStageParameterfvNV));
            GL.GetCombinerStageParameterfvNV = (GL.Delegates.GetCombinerStageParameterfvNV) GetAddress("glGetCombinerStageParameterfvNV", typeof(GL.Delegates.GetCombinerStageParameterfvNV));
            GL.AreProgramsResidentNV = (GL.Delegates.AreProgramsResidentNV) GetAddress("glAreProgramsResidentNV", typeof(GL.Delegates.AreProgramsResidentNV));
            GL.BindProgramNV = (GL.Delegates.BindProgramNV) GetAddress("glBindProgramNV", typeof(GL.Delegates.BindProgramNV));
            GL.DeleteProgramsNV = (GL.Delegates.DeleteProgramsNV) GetAddress("glDeleteProgramsNV", typeof(GL.Delegates.DeleteProgramsNV));
            GL.ExecuteProgramNV = (GL.Delegates.ExecuteProgramNV) GetAddress("glExecuteProgramNV", typeof(GL.Delegates.ExecuteProgramNV));
            GL.GenProgramsNV = (GL.Delegates.GenProgramsNV) GetAddress("glGenProgramsNV", typeof(GL.Delegates.GenProgramsNV));
            GL.GetProgramParameterdvNV = (GL.Delegates.GetProgramParameterdvNV) GetAddress("glGetProgramParameterdvNV", typeof(GL.Delegates.GetProgramParameterdvNV));
            GL.GetProgramParameterfvNV = (GL.Delegates.GetProgramParameterfvNV) GetAddress("glGetProgramParameterfvNV", typeof(GL.Delegates.GetProgramParameterfvNV));
            GL.GetProgramivNV = (GL.Delegates.GetProgramivNV) GetAddress("glGetProgramivNV", typeof(GL.Delegates.GetProgramivNV));
            GL.GetProgramStringNV = (GL.Delegates.GetProgramStringNV) GetAddress("glGetProgramStringNV", typeof(GL.Delegates.GetProgramStringNV));
            GL.GetTrackMatrixivNV = (GL.Delegates.GetTrackMatrixivNV) GetAddress("glGetTrackMatrixivNV", typeof(GL.Delegates.GetTrackMatrixivNV));
            GL.GetVertexAttribdvNV = (GL.Delegates.GetVertexAttribdvNV) GetAddress("glGetVertexAttribdvNV", typeof(GL.Delegates.GetVertexAttribdvNV));
            GL.GetVertexAttribfvNV = (GL.Delegates.GetVertexAttribfvNV) GetAddress("glGetVertexAttribfvNV", typeof(GL.Delegates.GetVertexAttribfvNV));
            GL.GetVertexAttribivNV = (GL.Delegates.GetVertexAttribivNV) GetAddress("glGetVertexAttribivNV", typeof(GL.Delegates.GetVertexAttribivNV));
            GL.GetVertexAttribPointervNV = (GL.Delegates.GetVertexAttribPointervNV) GetAddress("glGetVertexAttribPointervNV", typeof(GL.Delegates.GetVertexAttribPointervNV));
            GL.IsProgramNV = (GL.Delegates.IsProgramNV) GetAddress("glIsProgramNV", typeof(GL.Delegates.IsProgramNV));
            GL.LoadProgramNV = (GL.Delegates.LoadProgramNV) GetAddress("glLoadProgramNV", typeof(GL.Delegates.LoadProgramNV));
            GL.ProgramParameter4dNV = (GL.Delegates.ProgramParameter4dNV) GetAddress("glProgramParameter4dNV", typeof(GL.Delegates.ProgramParameter4dNV));
            GL.ProgramParameter4dvNV = (GL.Delegates.ProgramParameter4dvNV) GetAddress("glProgramParameter4dvNV", typeof(GL.Delegates.ProgramParameter4dvNV));
            GL.ProgramParameter4fNV = (GL.Delegates.ProgramParameter4fNV) GetAddress("glProgramParameter4fNV", typeof(GL.Delegates.ProgramParameter4fNV));
            GL.ProgramParameter4fvNV = (GL.Delegates.ProgramParameter4fvNV) GetAddress("glProgramParameter4fvNV", typeof(GL.Delegates.ProgramParameter4fvNV));
            GL.ProgramParameters4dvNV = (GL.Delegates.ProgramParameters4dvNV) GetAddress("glProgramParameters4dvNV", typeof(GL.Delegates.ProgramParameters4dvNV));
            GL.ProgramParameters4fvNV = (GL.Delegates.ProgramParameters4fvNV) GetAddress("glProgramParameters4fvNV", typeof(GL.Delegates.ProgramParameters4fvNV));
            GL.RequestResidentProgramsNV = (GL.Delegates.RequestResidentProgramsNV) GetAddress("glRequestResidentProgramsNV", typeof(GL.Delegates.RequestResidentProgramsNV));
            GL.TrackMatrixNV = (GL.Delegates.TrackMatrixNV) GetAddress("glTrackMatrixNV", typeof(GL.Delegates.TrackMatrixNV));
            GL.VertexAttribPointerNV = (GL.Delegates.VertexAttribPointerNV) GetAddress("glVertexAttribPointerNV", typeof(GL.Delegates.VertexAttribPointerNV));
            GL.VertexAttrib1dNV = (GL.Delegates.VertexAttrib1dNV) GetAddress("glVertexAttrib1dNV", typeof(GL.Delegates.VertexAttrib1dNV));
            GL.VertexAttrib1dvNV = (GL.Delegates.VertexAttrib1dvNV) GetAddress("glVertexAttrib1dvNV", typeof(GL.Delegates.VertexAttrib1dvNV));
            GL.VertexAttrib1fNV = (GL.Delegates.VertexAttrib1fNV) GetAddress("glVertexAttrib1fNV", typeof(GL.Delegates.VertexAttrib1fNV));
            GL.VertexAttrib1fvNV = (GL.Delegates.VertexAttrib1fvNV) GetAddress("glVertexAttrib1fvNV", typeof(GL.Delegates.VertexAttrib1fvNV));
            GL.VertexAttrib1sNV = (GL.Delegates.VertexAttrib1sNV) GetAddress("glVertexAttrib1sNV", typeof(GL.Delegates.VertexAttrib1sNV));
            GL.VertexAttrib1svNV = (GL.Delegates.VertexAttrib1svNV) GetAddress("glVertexAttrib1svNV", typeof(GL.Delegates.VertexAttrib1svNV));
            GL.VertexAttrib2dNV = (GL.Delegates.VertexAttrib2dNV) GetAddress("glVertexAttrib2dNV", typeof(GL.Delegates.VertexAttrib2dNV));
            GL.VertexAttrib2dvNV = (GL.Delegates.VertexAttrib2dvNV) GetAddress("glVertexAttrib2dvNV", typeof(GL.Delegates.VertexAttrib2dvNV));
            GL.VertexAttrib2fNV = (GL.Delegates.VertexAttrib2fNV) GetAddress("glVertexAttrib2fNV", typeof(GL.Delegates.VertexAttrib2fNV));
            GL.VertexAttrib2fvNV = (GL.Delegates.VertexAttrib2fvNV) GetAddress("glVertexAttrib2fvNV", typeof(GL.Delegates.VertexAttrib2fvNV));
            GL.VertexAttrib2sNV = (GL.Delegates.VertexAttrib2sNV) GetAddress("glVertexAttrib2sNV", typeof(GL.Delegates.VertexAttrib2sNV));
            GL.VertexAttrib2svNV = (GL.Delegates.VertexAttrib2svNV) GetAddress("glVertexAttrib2svNV", typeof(GL.Delegates.VertexAttrib2svNV));
            GL.VertexAttrib3dNV = (GL.Delegates.VertexAttrib3dNV) GetAddress("glVertexAttrib3dNV", typeof(GL.Delegates.VertexAttrib3dNV));
            GL.VertexAttrib3dvNV = (GL.Delegates.VertexAttrib3dvNV) GetAddress("glVertexAttrib3dvNV", typeof(GL.Delegates.VertexAttrib3dvNV));
            GL.VertexAttrib3fNV = (GL.Delegates.VertexAttrib3fNV) GetAddress("glVertexAttrib3fNV", typeof(GL.Delegates.VertexAttrib3fNV));
            GL.VertexAttrib3fvNV = (GL.Delegates.VertexAttrib3fvNV) GetAddress("glVertexAttrib3fvNV", typeof(GL.Delegates.VertexAttrib3fvNV));
            GL.VertexAttrib3sNV = (GL.Delegates.VertexAttrib3sNV) GetAddress("glVertexAttrib3sNV", typeof(GL.Delegates.VertexAttrib3sNV));
            GL.VertexAttrib3svNV = (GL.Delegates.VertexAttrib3svNV) GetAddress("glVertexAttrib3svNV", typeof(GL.Delegates.VertexAttrib3svNV));
            GL.VertexAttrib4dNV = (GL.Delegates.VertexAttrib4dNV) GetAddress("glVertexAttrib4dNV", typeof(GL.Delegates.VertexAttrib4dNV));
            GL.VertexAttrib4dvNV = (GL.Delegates.VertexAttrib4dvNV) GetAddress("glVertexAttrib4dvNV", typeof(GL.Delegates.VertexAttrib4dvNV));
            GL.VertexAttrib4fNV = (GL.Delegates.VertexAttrib4fNV) GetAddress("glVertexAttrib4fNV", typeof(GL.Delegates.VertexAttrib4fNV));
            GL.VertexAttrib4fvNV = (GL.Delegates.VertexAttrib4fvNV) GetAddress("glVertexAttrib4fvNV", typeof(GL.Delegates.VertexAttrib4fvNV));
            GL.VertexAttrib4sNV = (GL.Delegates.VertexAttrib4sNV) GetAddress("glVertexAttrib4sNV", typeof(GL.Delegates.VertexAttrib4sNV));
            GL.VertexAttrib4svNV = (GL.Delegates.VertexAttrib4svNV) GetAddress("glVertexAttrib4svNV", typeof(GL.Delegates.VertexAttrib4svNV));
            GL.VertexAttrib4ubNV = (GL.Delegates.VertexAttrib4ubNV) GetAddress("glVertexAttrib4ubNV", typeof(GL.Delegates.VertexAttrib4ubNV));
            GL.VertexAttrib4ubvNV = (GL.Delegates.VertexAttrib4ubvNV) GetAddress("glVertexAttrib4ubvNV", typeof(GL.Delegates.VertexAttrib4ubvNV));
            GL.VertexAttribs1dvNV = (GL.Delegates.VertexAttribs1dvNV) GetAddress("glVertexAttribs1dvNV", typeof(GL.Delegates.VertexAttribs1dvNV));
            GL.VertexAttribs1fvNV = (GL.Delegates.VertexAttribs1fvNV) GetAddress("glVertexAttribs1fvNV", typeof(GL.Delegates.VertexAttribs1fvNV));
            GL.VertexAttribs1svNV = (GL.Delegates.VertexAttribs1svNV) GetAddress("glVertexAttribs1svNV", typeof(GL.Delegates.VertexAttribs1svNV));
            GL.VertexAttribs2dvNV = (GL.Delegates.VertexAttribs2dvNV) GetAddress("glVertexAttribs2dvNV", typeof(GL.Delegates.VertexAttribs2dvNV));
            GL.VertexAttribs2fvNV = (GL.Delegates.VertexAttribs2fvNV) GetAddress("glVertexAttribs2fvNV", typeof(GL.Delegates.VertexAttribs2fvNV));
            GL.VertexAttribs2svNV = (GL.Delegates.VertexAttribs2svNV) GetAddress("glVertexAttribs2svNV", typeof(GL.Delegates.VertexAttribs2svNV));
            GL.VertexAttribs3dvNV = (GL.Delegates.VertexAttribs3dvNV) GetAddress("glVertexAttribs3dvNV", typeof(GL.Delegates.VertexAttribs3dvNV));
            GL.VertexAttribs3fvNV = (GL.Delegates.VertexAttribs3fvNV) GetAddress("glVertexAttribs3fvNV", typeof(GL.Delegates.VertexAttribs3fvNV));
            GL.VertexAttribs3svNV = (GL.Delegates.VertexAttribs3svNV) GetAddress("glVertexAttribs3svNV", typeof(GL.Delegates.VertexAttribs3svNV));
            GL.VertexAttribs4dvNV = (GL.Delegates.VertexAttribs4dvNV) GetAddress("glVertexAttribs4dvNV", typeof(GL.Delegates.VertexAttribs4dvNV));
            GL.VertexAttribs4fvNV = (GL.Delegates.VertexAttribs4fvNV) GetAddress("glVertexAttribs4fvNV", typeof(GL.Delegates.VertexAttribs4fvNV));
            GL.VertexAttribs4svNV = (GL.Delegates.VertexAttribs4svNV) GetAddress("glVertexAttribs4svNV", typeof(GL.Delegates.VertexAttribs4svNV));
            GL.VertexAttribs4ubvNV = (GL.Delegates.VertexAttribs4ubvNV) GetAddress("glVertexAttribs4ubvNV", typeof(GL.Delegates.VertexAttribs4ubvNV));
            GL.TexBumpParameterivATI = (GL.Delegates.TexBumpParameterivATI) GetAddress("glTexBumpParameterivATI", typeof(GL.Delegates.TexBumpParameterivATI));
            GL.TexBumpParameterfvATI = (GL.Delegates.TexBumpParameterfvATI) GetAddress("glTexBumpParameterfvATI", typeof(GL.Delegates.TexBumpParameterfvATI));
            GL.GetTexBumpParameterivATI = (GL.Delegates.GetTexBumpParameterivATI) GetAddress("glGetTexBumpParameterivATI", typeof(GL.Delegates.GetTexBumpParameterivATI));
            GL.GetTexBumpParameterfvATI = (GL.Delegates.GetTexBumpParameterfvATI) GetAddress("glGetTexBumpParameterfvATI", typeof(GL.Delegates.GetTexBumpParameterfvATI));
            GL.GenFragmentShadersATI = (GL.Delegates.GenFragmentShadersATI) GetAddress("glGenFragmentShadersATI", typeof(GL.Delegates.GenFragmentShadersATI));
            GL.BindFragmentShaderATI = (GL.Delegates.BindFragmentShaderATI) GetAddress("glBindFragmentShaderATI", typeof(GL.Delegates.BindFragmentShaderATI));
            GL.DeleteFragmentShaderATI = (GL.Delegates.DeleteFragmentShaderATI) GetAddress("glDeleteFragmentShaderATI", typeof(GL.Delegates.DeleteFragmentShaderATI));
            GL.BeginFragmentShaderATI = (GL.Delegates.BeginFragmentShaderATI) GetAddress("glBeginFragmentShaderATI", typeof(GL.Delegates.BeginFragmentShaderATI));
            GL.EndFragmentShaderATI = (GL.Delegates.EndFragmentShaderATI) GetAddress("glEndFragmentShaderATI", typeof(GL.Delegates.EndFragmentShaderATI));
            GL.PassTexCoordATI = (GL.Delegates.PassTexCoordATI) GetAddress("glPassTexCoordATI", typeof(GL.Delegates.PassTexCoordATI));
            GL.SampleMapATI = (GL.Delegates.SampleMapATI) GetAddress("glSampleMapATI", typeof(GL.Delegates.SampleMapATI));
            GL.ColorFragmentOp1ATI = (GL.Delegates.ColorFragmentOp1ATI) GetAddress("glColorFragmentOp1ATI", typeof(GL.Delegates.ColorFragmentOp1ATI));
            GL.ColorFragmentOp2ATI = (GL.Delegates.ColorFragmentOp2ATI) GetAddress("glColorFragmentOp2ATI", typeof(GL.Delegates.ColorFragmentOp2ATI));
            GL.ColorFragmentOp3ATI = (GL.Delegates.ColorFragmentOp3ATI) GetAddress("glColorFragmentOp3ATI", typeof(GL.Delegates.ColorFragmentOp3ATI));
            GL.AlphaFragmentOp1ATI = (GL.Delegates.AlphaFragmentOp1ATI) GetAddress("glAlphaFragmentOp1ATI", typeof(GL.Delegates.AlphaFragmentOp1ATI));
            GL.AlphaFragmentOp2ATI = (GL.Delegates.AlphaFragmentOp2ATI) GetAddress("glAlphaFragmentOp2ATI", typeof(GL.Delegates.AlphaFragmentOp2ATI));
            GL.AlphaFragmentOp3ATI = (GL.Delegates.AlphaFragmentOp3ATI) GetAddress("glAlphaFragmentOp3ATI", typeof(GL.Delegates.AlphaFragmentOp3ATI));
            GL.SetFragmentShaderConstantATI = (GL.Delegates.SetFragmentShaderConstantATI) GetAddress("glSetFragmentShaderConstantATI", typeof(GL.Delegates.SetFragmentShaderConstantATI));
            GL.PNTrianglesiATI = (GL.Delegates.PNTrianglesiATI) GetAddress("glPNTrianglesiATI", typeof(GL.Delegates.PNTrianglesiATI));
            GL.PNTrianglesfATI = (GL.Delegates.PNTrianglesfATI) GetAddress("glPNTrianglesfATI", typeof(GL.Delegates.PNTrianglesfATI));
            GL.NewObjectBufferATI = (GL.Delegates.NewObjectBufferATI) GetAddress("glNewObjectBufferATI", typeof(GL.Delegates.NewObjectBufferATI));
            GL.IsObjectBufferATI = (GL.Delegates.IsObjectBufferATI) GetAddress("glIsObjectBufferATI", typeof(GL.Delegates.IsObjectBufferATI));
            GL.UpdateObjectBufferATI = (GL.Delegates.UpdateObjectBufferATI) GetAddress("glUpdateObjectBufferATI", typeof(GL.Delegates.UpdateObjectBufferATI));
            GL.GetObjectBufferfvATI = (GL.Delegates.GetObjectBufferfvATI) GetAddress("glGetObjectBufferfvATI", typeof(GL.Delegates.GetObjectBufferfvATI));
            GL.GetObjectBufferivATI = (GL.Delegates.GetObjectBufferivATI) GetAddress("glGetObjectBufferivATI", typeof(GL.Delegates.GetObjectBufferivATI));
            GL.FreeObjectBufferATI = (GL.Delegates.FreeObjectBufferATI) GetAddress("glFreeObjectBufferATI", typeof(GL.Delegates.FreeObjectBufferATI));
            GL.ArrayObjectATI = (GL.Delegates.ArrayObjectATI) GetAddress("glArrayObjectATI", typeof(GL.Delegates.ArrayObjectATI));
            GL.GetArrayObjectfvATI = (GL.Delegates.GetArrayObjectfvATI) GetAddress("glGetArrayObjectfvATI", typeof(GL.Delegates.GetArrayObjectfvATI));
            GL.GetArrayObjectivATI = (GL.Delegates.GetArrayObjectivATI) GetAddress("glGetArrayObjectivATI", typeof(GL.Delegates.GetArrayObjectivATI));
            GL.VariantArrayObjectATI = (GL.Delegates.VariantArrayObjectATI) GetAddress("glVariantArrayObjectATI", typeof(GL.Delegates.VariantArrayObjectATI));
            GL.GetVariantArrayObjectfvATI = (GL.Delegates.GetVariantArrayObjectfvATI) GetAddress("glGetVariantArrayObjectfvATI", typeof(GL.Delegates.GetVariantArrayObjectfvATI));
            GL.GetVariantArrayObjectivATI = (GL.Delegates.GetVariantArrayObjectivATI) GetAddress("glGetVariantArrayObjectivATI", typeof(GL.Delegates.GetVariantArrayObjectivATI));
            GL.BeginVertexShaderEXT = (GL.Delegates.BeginVertexShaderEXT) GetAddress("glBeginVertexShaderEXT", typeof(GL.Delegates.BeginVertexShaderEXT));
            GL.EndVertexShaderEXT = (GL.Delegates.EndVertexShaderEXT) GetAddress("glEndVertexShaderEXT", typeof(GL.Delegates.EndVertexShaderEXT));
            GL.BindVertexShaderEXT = (GL.Delegates.BindVertexShaderEXT) GetAddress("glBindVertexShaderEXT", typeof(GL.Delegates.BindVertexShaderEXT));
            GL.GenVertexShadersEXT = (GL.Delegates.GenVertexShadersEXT) GetAddress("glGenVertexShadersEXT", typeof(GL.Delegates.GenVertexShadersEXT));
            GL.DeleteVertexShaderEXT = (GL.Delegates.DeleteVertexShaderEXT) GetAddress("glDeleteVertexShaderEXT", typeof(GL.Delegates.DeleteVertexShaderEXT));
            GL.ShaderOp1EXT = (GL.Delegates.ShaderOp1EXT) GetAddress("glShaderOp1EXT", typeof(GL.Delegates.ShaderOp1EXT));
            GL.ShaderOp2EXT = (GL.Delegates.ShaderOp2EXT) GetAddress("glShaderOp2EXT", typeof(GL.Delegates.ShaderOp2EXT));
            GL.ShaderOp3EXT = (GL.Delegates.ShaderOp3EXT) GetAddress("glShaderOp3EXT", typeof(GL.Delegates.ShaderOp3EXT));
            GL.SwizzleEXT = (GL.Delegates.SwizzleEXT) GetAddress("glSwizzleEXT", typeof(GL.Delegates.SwizzleEXT));
            GL.WriteMaskEXT = (GL.Delegates.WriteMaskEXT) GetAddress("glWriteMaskEXT", typeof(GL.Delegates.WriteMaskEXT));
            GL.InsertComponentEXT = (GL.Delegates.InsertComponentEXT) GetAddress("glInsertComponentEXT", typeof(GL.Delegates.InsertComponentEXT));
            GL.ExtractComponentEXT = (GL.Delegates.ExtractComponentEXT) GetAddress("glExtractComponentEXT", typeof(GL.Delegates.ExtractComponentEXT));
            GL.GenSymbolsEXT = (GL.Delegates.GenSymbolsEXT) GetAddress("glGenSymbolsEXT", typeof(GL.Delegates.GenSymbolsEXT));
            GL.SetInvariantEXT = (GL.Delegates.SetInvariantEXT) GetAddress("glSetInvariantEXT", typeof(GL.Delegates.SetInvariantEXT));
            GL.SetLocalConstantEXT = (GL.Delegates.SetLocalConstantEXT) GetAddress("glSetLocalConstantEXT", typeof(GL.Delegates.SetLocalConstantEXT));
            GL.VariantbvEXT = (GL.Delegates.VariantbvEXT) GetAddress("glVariantbvEXT", typeof(GL.Delegates.VariantbvEXT));
            GL.VariantsvEXT = (GL.Delegates.VariantsvEXT) GetAddress("glVariantsvEXT", typeof(GL.Delegates.VariantsvEXT));
            GL.VariantivEXT = (GL.Delegates.VariantivEXT) GetAddress("glVariantivEXT", typeof(GL.Delegates.VariantivEXT));
            GL.VariantfvEXT = (GL.Delegates.VariantfvEXT) GetAddress("glVariantfvEXT", typeof(GL.Delegates.VariantfvEXT));
            GL.VariantdvEXT = (GL.Delegates.VariantdvEXT) GetAddress("glVariantdvEXT", typeof(GL.Delegates.VariantdvEXT));
            GL.VariantubvEXT = (GL.Delegates.VariantubvEXT) GetAddress("glVariantubvEXT", typeof(GL.Delegates.VariantubvEXT));
            GL.VariantusvEXT = (GL.Delegates.VariantusvEXT) GetAddress("glVariantusvEXT", typeof(GL.Delegates.VariantusvEXT));
            GL.VariantuivEXT = (GL.Delegates.VariantuivEXT) GetAddress("glVariantuivEXT", typeof(GL.Delegates.VariantuivEXT));
            GL.VariantPointerEXT = (GL.Delegates.VariantPointerEXT) GetAddress("glVariantPointerEXT", typeof(GL.Delegates.VariantPointerEXT));
            GL.EnableVariantClientStateEXT = (GL.Delegates.EnableVariantClientStateEXT) GetAddress("glEnableVariantClientStateEXT", typeof(GL.Delegates.EnableVariantClientStateEXT));
            GL.DisableVariantClientStateEXT = (GL.Delegates.DisableVariantClientStateEXT) GetAddress("glDisableVariantClientStateEXT", typeof(GL.Delegates.DisableVariantClientStateEXT));
            GL.BindLightParameterEXT = (GL.Delegates.BindLightParameterEXT) GetAddress("glBindLightParameterEXT", typeof(GL.Delegates.BindLightParameterEXT));
            GL.BindMaterialParameterEXT = (GL.Delegates.BindMaterialParameterEXT) GetAddress("glBindMaterialParameterEXT", typeof(GL.Delegates.BindMaterialParameterEXT));
            GL.BindTexGenParameterEXT = (GL.Delegates.BindTexGenParameterEXT) GetAddress("glBindTexGenParameterEXT", typeof(GL.Delegates.BindTexGenParameterEXT));
            GL.BindTextureUnitParameterEXT = (GL.Delegates.BindTextureUnitParameterEXT) GetAddress("glBindTextureUnitParameterEXT", typeof(GL.Delegates.BindTextureUnitParameterEXT));
            GL.BindParameterEXT = (GL.Delegates.BindParameterEXT) GetAddress("glBindParameterEXT", typeof(GL.Delegates.BindParameterEXT));
            GL.IsVariantEnabledEXT = (GL.Delegates.IsVariantEnabledEXT) GetAddress("glIsVariantEnabledEXT", typeof(GL.Delegates.IsVariantEnabledEXT));
            GL.GetVariantBooleanvEXT = (GL.Delegates.GetVariantBooleanvEXT) GetAddress("glGetVariantBooleanvEXT", typeof(GL.Delegates.GetVariantBooleanvEXT));
            GL.GetVariantIntegervEXT = (GL.Delegates.GetVariantIntegervEXT) GetAddress("glGetVariantIntegervEXT", typeof(GL.Delegates.GetVariantIntegervEXT));
            GL.GetVariantFloatvEXT = (GL.Delegates.GetVariantFloatvEXT) GetAddress("glGetVariantFloatvEXT", typeof(GL.Delegates.GetVariantFloatvEXT));
            GL.GetVariantPointervEXT = (GL.Delegates.GetVariantPointervEXT) GetAddress("glGetVariantPointervEXT", typeof(GL.Delegates.GetVariantPointervEXT));
            GL.GetInvariantBooleanvEXT = (GL.Delegates.GetInvariantBooleanvEXT) GetAddress("glGetInvariantBooleanvEXT", typeof(GL.Delegates.GetInvariantBooleanvEXT));
            GL.GetInvariantIntegervEXT = (GL.Delegates.GetInvariantIntegervEXT) GetAddress("glGetInvariantIntegervEXT", typeof(GL.Delegates.GetInvariantIntegervEXT));
            GL.GetInvariantFloatvEXT = (GL.Delegates.GetInvariantFloatvEXT) GetAddress("glGetInvariantFloatvEXT", typeof(GL.Delegates.GetInvariantFloatvEXT));
            GL.GetLocalConstantBooleanvEXT = (GL.Delegates.GetLocalConstantBooleanvEXT) GetAddress("glGetLocalConstantBooleanvEXT", typeof(GL.Delegates.GetLocalConstantBooleanvEXT));
            GL.GetLocalConstantIntegervEXT = (GL.Delegates.GetLocalConstantIntegervEXT) GetAddress("glGetLocalConstantIntegervEXT", typeof(GL.Delegates.GetLocalConstantIntegervEXT));
            GL.GetLocalConstantFloatvEXT = (GL.Delegates.GetLocalConstantFloatvEXT) GetAddress("glGetLocalConstantFloatvEXT", typeof(GL.Delegates.GetLocalConstantFloatvEXT));
            GL.VertexStream1sATI = (GL.Delegates.VertexStream1sATI) GetAddress("glVertexStream1sATI", typeof(GL.Delegates.VertexStream1sATI));
            GL.VertexStream1svATI = (GL.Delegates.VertexStream1svATI) GetAddress("glVertexStream1svATI", typeof(GL.Delegates.VertexStream1svATI));
            GL.VertexStream1iATI = (GL.Delegates.VertexStream1iATI) GetAddress("glVertexStream1iATI", typeof(GL.Delegates.VertexStream1iATI));
            GL.VertexStream1ivATI = (GL.Delegates.VertexStream1ivATI) GetAddress("glVertexStream1ivATI", typeof(GL.Delegates.VertexStream1ivATI));
            GL.VertexStream1fATI = (GL.Delegates.VertexStream1fATI) GetAddress("glVertexStream1fATI", typeof(GL.Delegates.VertexStream1fATI));
            GL.VertexStream1fvATI = (GL.Delegates.VertexStream1fvATI) GetAddress("glVertexStream1fvATI", typeof(GL.Delegates.VertexStream1fvATI));
            GL.VertexStream1dATI = (GL.Delegates.VertexStream1dATI) GetAddress("glVertexStream1dATI", typeof(GL.Delegates.VertexStream1dATI));
            GL.VertexStream1dvATI = (GL.Delegates.VertexStream1dvATI) GetAddress("glVertexStream1dvATI", typeof(GL.Delegates.VertexStream1dvATI));
            GL.VertexStream2sATI = (GL.Delegates.VertexStream2sATI) GetAddress("glVertexStream2sATI", typeof(GL.Delegates.VertexStream2sATI));
            GL.VertexStream2svATI = (GL.Delegates.VertexStream2svATI) GetAddress("glVertexStream2svATI", typeof(GL.Delegates.VertexStream2svATI));
            GL.VertexStream2iATI = (GL.Delegates.VertexStream2iATI) GetAddress("glVertexStream2iATI", typeof(GL.Delegates.VertexStream2iATI));
            GL.VertexStream2ivATI = (GL.Delegates.VertexStream2ivATI) GetAddress("glVertexStream2ivATI", typeof(GL.Delegates.VertexStream2ivATI));
            GL.VertexStream2fATI = (GL.Delegates.VertexStream2fATI) GetAddress("glVertexStream2fATI", typeof(GL.Delegates.VertexStream2fATI));
            GL.VertexStream2fvATI = (GL.Delegates.VertexStream2fvATI) GetAddress("glVertexStream2fvATI", typeof(GL.Delegates.VertexStream2fvATI));
            GL.VertexStream2dATI = (GL.Delegates.VertexStream2dATI) GetAddress("glVertexStream2dATI", typeof(GL.Delegates.VertexStream2dATI));
            GL.VertexStream2dvATI = (GL.Delegates.VertexStream2dvATI) GetAddress("glVertexStream2dvATI", typeof(GL.Delegates.VertexStream2dvATI));
            GL.VertexStream3sATI = (GL.Delegates.VertexStream3sATI) GetAddress("glVertexStream3sATI", typeof(GL.Delegates.VertexStream3sATI));
            GL.VertexStream3svATI = (GL.Delegates.VertexStream3svATI) GetAddress("glVertexStream3svATI", typeof(GL.Delegates.VertexStream3svATI));
            GL.VertexStream3iATI = (GL.Delegates.VertexStream3iATI) GetAddress("glVertexStream3iATI", typeof(GL.Delegates.VertexStream3iATI));
            GL.VertexStream3ivATI = (GL.Delegates.VertexStream3ivATI) GetAddress("glVertexStream3ivATI", typeof(GL.Delegates.VertexStream3ivATI));
            GL.VertexStream3fATI = (GL.Delegates.VertexStream3fATI) GetAddress("glVertexStream3fATI", typeof(GL.Delegates.VertexStream3fATI));
            GL.VertexStream3fvATI = (GL.Delegates.VertexStream3fvATI) GetAddress("glVertexStream3fvATI", typeof(GL.Delegates.VertexStream3fvATI));
            GL.VertexStream3dATI = (GL.Delegates.VertexStream3dATI) GetAddress("glVertexStream3dATI", typeof(GL.Delegates.VertexStream3dATI));
            GL.VertexStream3dvATI = (GL.Delegates.VertexStream3dvATI) GetAddress("glVertexStream3dvATI", typeof(GL.Delegates.VertexStream3dvATI));
            GL.VertexStream4sATI = (GL.Delegates.VertexStream4sATI) GetAddress("glVertexStream4sATI", typeof(GL.Delegates.VertexStream4sATI));
            GL.VertexStream4svATI = (GL.Delegates.VertexStream4svATI) GetAddress("glVertexStream4svATI", typeof(GL.Delegates.VertexStream4svATI));
            GL.VertexStream4iATI = (GL.Delegates.VertexStream4iATI) GetAddress("glVertexStream4iATI", typeof(GL.Delegates.VertexStream4iATI));
            GL.VertexStream4ivATI = (GL.Delegates.VertexStream4ivATI) GetAddress("glVertexStream4ivATI", typeof(GL.Delegates.VertexStream4ivATI));
            GL.VertexStream4fATI = (GL.Delegates.VertexStream4fATI) GetAddress("glVertexStream4fATI", typeof(GL.Delegates.VertexStream4fATI));
            GL.VertexStream4fvATI = (GL.Delegates.VertexStream4fvATI) GetAddress("glVertexStream4fvATI", typeof(GL.Delegates.VertexStream4fvATI));
            GL.VertexStream4dATI = (GL.Delegates.VertexStream4dATI) GetAddress("glVertexStream4dATI", typeof(GL.Delegates.VertexStream4dATI));
            GL.VertexStream4dvATI = (GL.Delegates.VertexStream4dvATI) GetAddress("glVertexStream4dvATI", typeof(GL.Delegates.VertexStream4dvATI));
            GL.NormalStream3bATI = (GL.Delegates.NormalStream3bATI) GetAddress("glNormalStream3bATI", typeof(GL.Delegates.NormalStream3bATI));
            GL.NormalStream3bvATI = (GL.Delegates.NormalStream3bvATI) GetAddress("glNormalStream3bvATI", typeof(GL.Delegates.NormalStream3bvATI));
            GL.NormalStream3sATI = (GL.Delegates.NormalStream3sATI) GetAddress("glNormalStream3sATI", typeof(GL.Delegates.NormalStream3sATI));
            GL.NormalStream3svATI = (GL.Delegates.NormalStream3svATI) GetAddress("glNormalStream3svATI", typeof(GL.Delegates.NormalStream3svATI));
            GL.NormalStream3iATI = (GL.Delegates.NormalStream3iATI) GetAddress("glNormalStream3iATI", typeof(GL.Delegates.NormalStream3iATI));
            GL.NormalStream3ivATI = (GL.Delegates.NormalStream3ivATI) GetAddress("glNormalStream3ivATI", typeof(GL.Delegates.NormalStream3ivATI));
            GL.NormalStream3fATI = (GL.Delegates.NormalStream3fATI) GetAddress("glNormalStream3fATI", typeof(GL.Delegates.NormalStream3fATI));
            GL.NormalStream3fvATI = (GL.Delegates.NormalStream3fvATI) GetAddress("glNormalStream3fvATI", typeof(GL.Delegates.NormalStream3fvATI));
            GL.NormalStream3dATI = (GL.Delegates.NormalStream3dATI) GetAddress("glNormalStream3dATI", typeof(GL.Delegates.NormalStream3dATI));
            GL.NormalStream3dvATI = (GL.Delegates.NormalStream3dvATI) GetAddress("glNormalStream3dvATI", typeof(GL.Delegates.NormalStream3dvATI));
            GL.ClientActiveVertexStreamATI = (GL.Delegates.ClientActiveVertexStreamATI) GetAddress("glClientActiveVertexStreamATI", typeof(GL.Delegates.ClientActiveVertexStreamATI));
            GL.VertexBlendEnviATI = (GL.Delegates.VertexBlendEnviATI) GetAddress("glVertexBlendEnviATI", typeof(GL.Delegates.VertexBlendEnviATI));
            GL.VertexBlendEnvfATI = (GL.Delegates.VertexBlendEnvfATI) GetAddress("glVertexBlendEnvfATI", typeof(GL.Delegates.VertexBlendEnvfATI));
            GL.ElementPointerATI = (GL.Delegates.ElementPointerATI) GetAddress("glElementPointerATI", typeof(GL.Delegates.ElementPointerATI));
            GL.DrawElementArrayATI = (GL.Delegates.DrawElementArrayATI) GetAddress("glDrawElementArrayATI", typeof(GL.Delegates.DrawElementArrayATI));
            GL.DrawRangeElementArrayATI = (GL.Delegates.DrawRangeElementArrayATI) GetAddress("glDrawRangeElementArrayATI", typeof(GL.Delegates.DrawRangeElementArrayATI));
            GL.DrawMeshArraysSUN = (GL.Delegates.DrawMeshArraysSUN) GetAddress("glDrawMeshArraysSUN", typeof(GL.Delegates.DrawMeshArraysSUN));
            GL.GenOcclusionQueriesNV = (GL.Delegates.GenOcclusionQueriesNV) GetAddress("glGenOcclusionQueriesNV", typeof(GL.Delegates.GenOcclusionQueriesNV));
            GL.DeleteOcclusionQueriesNV = (GL.Delegates.DeleteOcclusionQueriesNV) GetAddress("glDeleteOcclusionQueriesNV", typeof(GL.Delegates.DeleteOcclusionQueriesNV));
            GL.IsOcclusionQueryNV = (GL.Delegates.IsOcclusionQueryNV) GetAddress("glIsOcclusionQueryNV", typeof(GL.Delegates.IsOcclusionQueryNV));
            GL.BeginOcclusionQueryNV = (GL.Delegates.BeginOcclusionQueryNV) GetAddress("glBeginOcclusionQueryNV", typeof(GL.Delegates.BeginOcclusionQueryNV));
            GL.EndOcclusionQueryNV = (GL.Delegates.EndOcclusionQueryNV) GetAddress("glEndOcclusionQueryNV", typeof(GL.Delegates.EndOcclusionQueryNV));
            GL.GetOcclusionQueryivNV = (GL.Delegates.GetOcclusionQueryivNV) GetAddress("glGetOcclusionQueryivNV", typeof(GL.Delegates.GetOcclusionQueryivNV));
            GL.GetOcclusionQueryuivNV = (GL.Delegates.GetOcclusionQueryuivNV) GetAddress("glGetOcclusionQueryuivNV", typeof(GL.Delegates.GetOcclusionQueryuivNV));
            GL.PointParameteriNV = (GL.Delegates.PointParameteriNV) GetAddress("glPointParameteriNV", typeof(GL.Delegates.PointParameteriNV));
            GL.PointParameterivNV = (GL.Delegates.PointParameterivNV) GetAddress("glPointParameterivNV", typeof(GL.Delegates.PointParameterivNV));
            GL.ActiveStencilFaceEXT = (GL.Delegates.ActiveStencilFaceEXT) GetAddress("glActiveStencilFaceEXT", typeof(GL.Delegates.ActiveStencilFaceEXT));
            GL.ElementPointerAPPLE = (GL.Delegates.ElementPointerAPPLE) GetAddress("glElementPointerAPPLE", typeof(GL.Delegates.ElementPointerAPPLE));
            GL.DrawElementArrayAPPLE = (GL.Delegates.DrawElementArrayAPPLE) GetAddress("glDrawElementArrayAPPLE", typeof(GL.Delegates.DrawElementArrayAPPLE));
            GL.DrawRangeElementArrayAPPLE = (GL.Delegates.DrawRangeElementArrayAPPLE) GetAddress("glDrawRangeElementArrayAPPLE", typeof(GL.Delegates.DrawRangeElementArrayAPPLE));
            GL.MultiDrawElementArrayAPPLE = (GL.Delegates.MultiDrawElementArrayAPPLE) GetAddress("glMultiDrawElementArrayAPPLE", typeof(GL.Delegates.MultiDrawElementArrayAPPLE));
            GL.MultiDrawRangeElementArrayAPPLE = (GL.Delegates.MultiDrawRangeElementArrayAPPLE) GetAddress("glMultiDrawRangeElementArrayAPPLE", typeof(GL.Delegates.MultiDrawRangeElementArrayAPPLE));
            GL.GenFencesAPPLE = (GL.Delegates.GenFencesAPPLE) GetAddress("glGenFencesAPPLE", typeof(GL.Delegates.GenFencesAPPLE));
            GL.DeleteFencesAPPLE = (GL.Delegates.DeleteFencesAPPLE) GetAddress("glDeleteFencesAPPLE", typeof(GL.Delegates.DeleteFencesAPPLE));
            GL.SetFenceAPPLE = (GL.Delegates.SetFenceAPPLE) GetAddress("glSetFenceAPPLE", typeof(GL.Delegates.SetFenceAPPLE));
            GL.IsFenceAPPLE = (GL.Delegates.IsFenceAPPLE) GetAddress("glIsFenceAPPLE", typeof(GL.Delegates.IsFenceAPPLE));
            GL.TestFenceAPPLE = (GL.Delegates.TestFenceAPPLE) GetAddress("glTestFenceAPPLE", typeof(GL.Delegates.TestFenceAPPLE));
            GL.FinishFenceAPPLE = (GL.Delegates.FinishFenceAPPLE) GetAddress("glFinishFenceAPPLE", typeof(GL.Delegates.FinishFenceAPPLE));
            GL.TestObjectAPPLE = (GL.Delegates.TestObjectAPPLE) GetAddress("glTestObjectAPPLE", typeof(GL.Delegates.TestObjectAPPLE));
            GL.FinishObjectAPPLE = (GL.Delegates.FinishObjectAPPLE) GetAddress("glFinishObjectAPPLE", typeof(GL.Delegates.FinishObjectAPPLE));
            GL.BindVertexArrayAPPLE = (GL.Delegates.BindVertexArrayAPPLE) GetAddress("glBindVertexArrayAPPLE", typeof(GL.Delegates.BindVertexArrayAPPLE));
            GL.DeleteVertexArraysAPPLE = (GL.Delegates.DeleteVertexArraysAPPLE) GetAddress("glDeleteVertexArraysAPPLE", typeof(GL.Delegates.DeleteVertexArraysAPPLE));
            GL.GenVertexArraysAPPLE = (GL.Delegates.GenVertexArraysAPPLE) GetAddress("glGenVertexArraysAPPLE", typeof(GL.Delegates.GenVertexArraysAPPLE));
            GL.IsVertexArrayAPPLE = (GL.Delegates.IsVertexArrayAPPLE) GetAddress("glIsVertexArrayAPPLE", typeof(GL.Delegates.IsVertexArrayAPPLE));
            GL.VertexArrayRangeAPPLE = (GL.Delegates.VertexArrayRangeAPPLE) GetAddress("glVertexArrayRangeAPPLE", typeof(GL.Delegates.VertexArrayRangeAPPLE));
            GL.FlushVertexArrayRangeAPPLE = (GL.Delegates.FlushVertexArrayRangeAPPLE) GetAddress("glFlushVertexArrayRangeAPPLE", typeof(GL.Delegates.FlushVertexArrayRangeAPPLE));
            GL.VertexArrayParameteriAPPLE = (GL.Delegates.VertexArrayParameteriAPPLE) GetAddress("glVertexArrayParameteriAPPLE", typeof(GL.Delegates.VertexArrayParameteriAPPLE));
            GL.DrawBuffersATI = (GL.Delegates.DrawBuffersATI) GetAddress("glDrawBuffersATI", typeof(GL.Delegates.DrawBuffersATI));
            GL.ProgramNamedParameter4fNV = (GL.Delegates.ProgramNamedParameter4fNV) GetAddress("glProgramNamedParameter4fNV", typeof(GL.Delegates.ProgramNamedParameter4fNV));
            GL.ProgramNamedParameter4dNV = (GL.Delegates.ProgramNamedParameter4dNV) GetAddress("glProgramNamedParameter4dNV", typeof(GL.Delegates.ProgramNamedParameter4dNV));
            GL.ProgramNamedParameter4fvNV = (GL.Delegates.ProgramNamedParameter4fvNV) GetAddress("glProgramNamedParameter4fvNV", typeof(GL.Delegates.ProgramNamedParameter4fvNV));
            GL.ProgramNamedParameter4dvNV = (GL.Delegates.ProgramNamedParameter4dvNV) GetAddress("glProgramNamedParameter4dvNV", typeof(GL.Delegates.ProgramNamedParameter4dvNV));
            GL.GetProgramNamedParameterfvNV = (GL.Delegates.GetProgramNamedParameterfvNV) GetAddress("glGetProgramNamedParameterfvNV", typeof(GL.Delegates.GetProgramNamedParameterfvNV));
            GL.GetProgramNamedParameterdvNV = (GL.Delegates.GetProgramNamedParameterdvNV) GetAddress("glGetProgramNamedParameterdvNV", typeof(GL.Delegates.GetProgramNamedParameterdvNV));
            GL.Vertex2hNV = (GL.Delegates.Vertex2hNV) GetAddress("glVertex2hNV", typeof(GL.Delegates.Vertex2hNV));
            GL.Vertex2hvNV = (GL.Delegates.Vertex2hvNV) GetAddress("glVertex2hvNV", typeof(GL.Delegates.Vertex2hvNV));
            GL.Vertex3hNV = (GL.Delegates.Vertex3hNV) GetAddress("glVertex3hNV", typeof(GL.Delegates.Vertex3hNV));
            GL.Vertex3hvNV = (GL.Delegates.Vertex3hvNV) GetAddress("glVertex3hvNV", typeof(GL.Delegates.Vertex3hvNV));
            GL.Vertex4hNV = (GL.Delegates.Vertex4hNV) GetAddress("glVertex4hNV", typeof(GL.Delegates.Vertex4hNV));
            GL.Vertex4hvNV = (GL.Delegates.Vertex4hvNV) GetAddress("glVertex4hvNV", typeof(GL.Delegates.Vertex4hvNV));
            GL.Normal3hNV = (GL.Delegates.Normal3hNV) GetAddress("glNormal3hNV", typeof(GL.Delegates.Normal3hNV));
            GL.Normal3hvNV = (GL.Delegates.Normal3hvNV) GetAddress("glNormal3hvNV", typeof(GL.Delegates.Normal3hvNV));
            GL.Color3hNV = (GL.Delegates.Color3hNV) GetAddress("glColor3hNV", typeof(GL.Delegates.Color3hNV));
            GL.Color3hvNV = (GL.Delegates.Color3hvNV) GetAddress("glColor3hvNV", typeof(GL.Delegates.Color3hvNV));
            GL.Color4hNV = (GL.Delegates.Color4hNV) GetAddress("glColor4hNV", typeof(GL.Delegates.Color4hNV));
            GL.Color4hvNV = (GL.Delegates.Color4hvNV) GetAddress("glColor4hvNV", typeof(GL.Delegates.Color4hvNV));
            GL.TexCoord1hNV = (GL.Delegates.TexCoord1hNV) GetAddress("glTexCoord1hNV", typeof(GL.Delegates.TexCoord1hNV));
            GL.TexCoord1hvNV = (GL.Delegates.TexCoord1hvNV) GetAddress("glTexCoord1hvNV", typeof(GL.Delegates.TexCoord1hvNV));
            GL.TexCoord2hNV = (GL.Delegates.TexCoord2hNV) GetAddress("glTexCoord2hNV", typeof(GL.Delegates.TexCoord2hNV));
            GL.TexCoord2hvNV = (GL.Delegates.TexCoord2hvNV) GetAddress("glTexCoord2hvNV", typeof(GL.Delegates.TexCoord2hvNV));
            GL.TexCoord3hNV = (GL.Delegates.TexCoord3hNV) GetAddress("glTexCoord3hNV", typeof(GL.Delegates.TexCoord3hNV));
            GL.TexCoord3hvNV = (GL.Delegates.TexCoord3hvNV) GetAddress("glTexCoord3hvNV", typeof(GL.Delegates.TexCoord3hvNV));
            GL.TexCoord4hNV = (GL.Delegates.TexCoord4hNV) GetAddress("glTexCoord4hNV", typeof(GL.Delegates.TexCoord4hNV));
            GL.TexCoord4hvNV = (GL.Delegates.TexCoord4hvNV) GetAddress("glTexCoord4hvNV", typeof(GL.Delegates.TexCoord4hvNV));
            GL.MultiTexCoord1hNV = (GL.Delegates.MultiTexCoord1hNV) GetAddress("glMultiTexCoord1hNV", typeof(GL.Delegates.MultiTexCoord1hNV));
            GL.MultiTexCoord1hvNV = (GL.Delegates.MultiTexCoord1hvNV) GetAddress("glMultiTexCoord1hvNV", typeof(GL.Delegates.MultiTexCoord1hvNV));
            GL.MultiTexCoord2hNV = (GL.Delegates.MultiTexCoord2hNV) GetAddress("glMultiTexCoord2hNV", typeof(GL.Delegates.MultiTexCoord2hNV));
            GL.MultiTexCoord2hvNV = (GL.Delegates.MultiTexCoord2hvNV) GetAddress("glMultiTexCoord2hvNV", typeof(GL.Delegates.MultiTexCoord2hvNV));
            GL.MultiTexCoord3hNV = (GL.Delegates.MultiTexCoord3hNV) GetAddress("glMultiTexCoord3hNV", typeof(GL.Delegates.MultiTexCoord3hNV));
            GL.MultiTexCoord3hvNV = (GL.Delegates.MultiTexCoord3hvNV) GetAddress("glMultiTexCoord3hvNV", typeof(GL.Delegates.MultiTexCoord3hvNV));
            GL.MultiTexCoord4hNV = (GL.Delegates.MultiTexCoord4hNV) GetAddress("glMultiTexCoord4hNV", typeof(GL.Delegates.MultiTexCoord4hNV));
            GL.MultiTexCoord4hvNV = (GL.Delegates.MultiTexCoord4hvNV) GetAddress("glMultiTexCoord4hvNV", typeof(GL.Delegates.MultiTexCoord4hvNV));
            GL.FogCoordhNV = (GL.Delegates.FogCoordhNV) GetAddress("glFogCoordhNV", typeof(GL.Delegates.FogCoordhNV));
            GL.FogCoordhvNV = (GL.Delegates.FogCoordhvNV) GetAddress("glFogCoordhvNV", typeof(GL.Delegates.FogCoordhvNV));
            GL.SecondaryColor3hNV = (GL.Delegates.SecondaryColor3hNV) GetAddress("glSecondaryColor3hNV", typeof(GL.Delegates.SecondaryColor3hNV));
            GL.SecondaryColor3hvNV = (GL.Delegates.SecondaryColor3hvNV) GetAddress("glSecondaryColor3hvNV", typeof(GL.Delegates.SecondaryColor3hvNV));
            GL.VertexWeighthNV = (GL.Delegates.VertexWeighthNV) GetAddress("glVertexWeighthNV", typeof(GL.Delegates.VertexWeighthNV));
            GL.VertexWeighthvNV = (GL.Delegates.VertexWeighthvNV) GetAddress("glVertexWeighthvNV", typeof(GL.Delegates.VertexWeighthvNV));
            GL.VertexAttrib1hNV = (GL.Delegates.VertexAttrib1hNV) GetAddress("glVertexAttrib1hNV", typeof(GL.Delegates.VertexAttrib1hNV));
            GL.VertexAttrib1hvNV = (GL.Delegates.VertexAttrib1hvNV) GetAddress("glVertexAttrib1hvNV", typeof(GL.Delegates.VertexAttrib1hvNV));
            GL.VertexAttrib2hNV = (GL.Delegates.VertexAttrib2hNV) GetAddress("glVertexAttrib2hNV", typeof(GL.Delegates.VertexAttrib2hNV));
            GL.VertexAttrib2hvNV = (GL.Delegates.VertexAttrib2hvNV) GetAddress("glVertexAttrib2hvNV", typeof(GL.Delegates.VertexAttrib2hvNV));
            GL.VertexAttrib3hNV = (GL.Delegates.VertexAttrib3hNV) GetAddress("glVertexAttrib3hNV", typeof(GL.Delegates.VertexAttrib3hNV));
            GL.VertexAttrib3hvNV = (GL.Delegates.VertexAttrib3hvNV) GetAddress("glVertexAttrib3hvNV", typeof(GL.Delegates.VertexAttrib3hvNV));
            GL.VertexAttrib4hNV = (GL.Delegates.VertexAttrib4hNV) GetAddress("glVertexAttrib4hNV", typeof(GL.Delegates.VertexAttrib4hNV));
            GL.VertexAttrib4hvNV = (GL.Delegates.VertexAttrib4hvNV) GetAddress("glVertexAttrib4hvNV", typeof(GL.Delegates.VertexAttrib4hvNV));
            GL.VertexAttribs1hvNV = (GL.Delegates.VertexAttribs1hvNV) GetAddress("glVertexAttribs1hvNV", typeof(GL.Delegates.VertexAttribs1hvNV));
            GL.VertexAttribs2hvNV = (GL.Delegates.VertexAttribs2hvNV) GetAddress("glVertexAttribs2hvNV", typeof(GL.Delegates.VertexAttribs2hvNV));
            GL.VertexAttribs3hvNV = (GL.Delegates.VertexAttribs3hvNV) GetAddress("glVertexAttribs3hvNV", typeof(GL.Delegates.VertexAttribs3hvNV));
            GL.VertexAttribs4hvNV = (GL.Delegates.VertexAttribs4hvNV) GetAddress("glVertexAttribs4hvNV", typeof(GL.Delegates.VertexAttribs4hvNV));
            GL.PixelDataRangeNV = (GL.Delegates.PixelDataRangeNV) GetAddress("glPixelDataRangeNV", typeof(GL.Delegates.PixelDataRangeNV));
            GL.FlushPixelDataRangeNV = (GL.Delegates.FlushPixelDataRangeNV) GetAddress("glFlushPixelDataRangeNV", typeof(GL.Delegates.FlushPixelDataRangeNV));
            GL.PrimitiveRestartNV = (GL.Delegates.PrimitiveRestartNV) GetAddress("glPrimitiveRestartNV", typeof(GL.Delegates.PrimitiveRestartNV));
            GL.PrimitiveRestartIndexNV = (GL.Delegates.PrimitiveRestartIndexNV) GetAddress("glPrimitiveRestartIndexNV", typeof(GL.Delegates.PrimitiveRestartIndexNV));
            GL.MapObjectBufferATI_ = (GL.Delegates.MapObjectBufferATI_) GetAddress("glMapObjectBufferATI_", typeof(GL.Delegates.MapObjectBufferATI_));
            GL.UnmapObjectBufferATI = (GL.Delegates.UnmapObjectBufferATI) GetAddress("glUnmapObjectBufferATI", typeof(GL.Delegates.UnmapObjectBufferATI));
            GL.StencilOpSeparateATI = (GL.Delegates.StencilOpSeparateATI) GetAddress("glStencilOpSeparateATI", typeof(GL.Delegates.StencilOpSeparateATI));
            GL.StencilFuncSeparateATI = (GL.Delegates.StencilFuncSeparateATI) GetAddress("glStencilFuncSeparateATI", typeof(GL.Delegates.StencilFuncSeparateATI));
            GL.VertexAttribArrayObjectATI = (GL.Delegates.VertexAttribArrayObjectATI) GetAddress("glVertexAttribArrayObjectATI", typeof(GL.Delegates.VertexAttribArrayObjectATI));
            GL.GetVertexAttribArrayObjectfvATI = (GL.Delegates.GetVertexAttribArrayObjectfvATI) GetAddress("glGetVertexAttribArrayObjectfvATI", typeof(GL.Delegates.GetVertexAttribArrayObjectfvATI));
            GL.GetVertexAttribArrayObjectivATI = (GL.Delegates.GetVertexAttribArrayObjectivATI) GetAddress("glGetVertexAttribArrayObjectivATI", typeof(GL.Delegates.GetVertexAttribArrayObjectivATI));
            GL.DepthBoundsEXT = (GL.Delegates.DepthBoundsEXT) GetAddress("glDepthBoundsEXT", typeof(GL.Delegates.DepthBoundsEXT));
            GL.BlendEquationSeparateEXT = (GL.Delegates.BlendEquationSeparateEXT) GetAddress("glBlendEquationSeparateEXT", typeof(GL.Delegates.BlendEquationSeparateEXT));
            GL.IsRenderbufferEXT = (GL.Delegates.IsRenderbufferEXT) GetAddress("glIsRenderbufferEXT", typeof(GL.Delegates.IsRenderbufferEXT));
            GL.BindRenderbufferEXT = (GL.Delegates.BindRenderbufferEXT) GetAddress("glBindRenderbufferEXT", typeof(GL.Delegates.BindRenderbufferEXT));
            GL.DeleteRenderbuffersEXT = (GL.Delegates.DeleteRenderbuffersEXT) GetAddress("glDeleteRenderbuffersEXT", typeof(GL.Delegates.DeleteRenderbuffersEXT));
            GL.GenRenderbuffersEXT = (GL.Delegates.GenRenderbuffersEXT) GetAddress("glGenRenderbuffersEXT", typeof(GL.Delegates.GenRenderbuffersEXT));
            GL.RenderbufferStorageEXT = (GL.Delegates.RenderbufferStorageEXT) GetAddress("glRenderbufferStorageEXT", typeof(GL.Delegates.RenderbufferStorageEXT));
            GL.GetRenderbufferParameterivEXT = (GL.Delegates.GetRenderbufferParameterivEXT) GetAddress("glGetRenderbufferParameterivEXT", typeof(GL.Delegates.GetRenderbufferParameterivEXT));
            GL.IsFramebufferEXT = (GL.Delegates.IsFramebufferEXT) GetAddress("glIsFramebufferEXT", typeof(GL.Delegates.IsFramebufferEXT));
            GL.BindFramebufferEXT = (GL.Delegates.BindFramebufferEXT) GetAddress("glBindFramebufferEXT", typeof(GL.Delegates.BindFramebufferEXT));
            GL.DeleteFramebuffersEXT = (GL.Delegates.DeleteFramebuffersEXT) GetAddress("glDeleteFramebuffersEXT", typeof(GL.Delegates.DeleteFramebuffersEXT));
            GL.GenFramebuffersEXT = (GL.Delegates.GenFramebuffersEXT) GetAddress("glGenFramebuffersEXT", typeof(GL.Delegates.GenFramebuffersEXT));
            GL.CheckFramebufferStatusEXT = (GL.Delegates.CheckFramebufferStatusEXT) GetAddress("glCheckFramebufferStatusEXT", typeof(GL.Delegates.CheckFramebufferStatusEXT));
            GL.FramebufferTexture1DEXT = (GL.Delegates.FramebufferTexture1DEXT) GetAddress("glFramebufferTexture1DEXT", typeof(GL.Delegates.FramebufferTexture1DEXT));
            GL.FramebufferTexture2DEXT = (GL.Delegates.FramebufferTexture2DEXT) GetAddress("glFramebufferTexture2DEXT", typeof(GL.Delegates.FramebufferTexture2DEXT));
            GL.FramebufferTexture3DEXT = (GL.Delegates.FramebufferTexture3DEXT) GetAddress("glFramebufferTexture3DEXT", typeof(GL.Delegates.FramebufferTexture3DEXT));
            GL.FramebufferRenderbufferEXT = (GL.Delegates.FramebufferRenderbufferEXT) GetAddress("glFramebufferRenderbufferEXT", typeof(GL.Delegates.FramebufferRenderbufferEXT));
            GL.GetFramebufferAttachmentParameterivEXT = (GL.Delegates.GetFramebufferAttachmentParameterivEXT) GetAddress("glGetFramebufferAttachmentParameterivEXT", typeof(GL.Delegates.GetFramebufferAttachmentParameterivEXT));
            GL.GenerateMipmapEXT = (GL.Delegates.GenerateMipmapEXT) GetAddress("glGenerateMipmapEXT", typeof(GL.Delegates.GenerateMipmapEXT));
            GL.StringMarkerGREMEDY = (GL.Delegates.StringMarkerGREMEDY) GetAddress("glStringMarkerGREMEDY", typeof(GL.Delegates.StringMarkerGREMEDY));
        CoreLoaded = true;
        }

        #endregion
    }
}
