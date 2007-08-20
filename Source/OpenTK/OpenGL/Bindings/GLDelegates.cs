namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    partial class GL
    {

        internal static class Delegates
        {
            static Delegates()
            {
            }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NewList(UInt32 list, GL.Enums.ListMode mode);
            internal static NewList glNewList = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndList();
            internal static EndList glEndList = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CallList(UInt32 list);
            internal static CallList glCallList = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CallLists(Int32 n, GL.Enums.ListNameType type, void* lists);
            internal unsafe static CallLists glCallLists = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteLists(UInt32 list, Int32 range);
            internal static DeleteLists glDeleteLists = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenLists(Int32 range);
            internal static GenLists glGenLists = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListBase(UInt32 @base);
            internal static ListBase glListBase = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Begin(GL.Enums.BeginMode mode);
            internal static Begin glBegin = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
            internal unsafe static Bitmap glBitmap = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3b(SByte red, SByte green, SByte blue);
            internal static Color3b glColor3b = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3bv(SByte* v);
            internal unsafe static Color3bv glColor3bv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3d(Double red, Double green, Double blue);
            internal static Color3d glColor3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3dv(Double* v);
            internal unsafe static Color3dv glColor3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3f(Single red, Single green, Single blue);
            internal static Color3f glColor3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fv(Single* v);
            internal unsafe static Color3fv glColor3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3i(Int32 red, Int32 green, Int32 blue);
            internal static Color3i glColor3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3iv(Int32* v);
            internal unsafe static Color3iv glColor3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3s(Int16 red, Int16 green, Int16 blue);
            internal static Color3s glColor3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3sv(Int16* v);
            internal unsafe static Color3sv glColor3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ub(Byte red, Byte green, Byte blue);
            internal static Color3ub glColor3ub = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3ubv(Byte* v);
            internal unsafe static Color3ubv glColor3ubv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
            internal static Color3ui glColor3ui = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3uiv(UInt32* v);
            internal unsafe static Color3uiv glColor3uiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3us(UInt16 red, UInt16 green, UInt16 blue);
            internal static Color3us glColor3us = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3usv(UInt16* v);
            internal unsafe static Color3usv glColor3usv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
            internal static Color4b glColor4b = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4bv(SByte* v);
            internal unsafe static Color4bv glColor4bv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4d(Double red, Double green, Double blue, Double alpha);
            internal static Color4d glColor4d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4dv(Double* v);
            internal unsafe static Color4dv glColor4dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
            internal static Color4f glColor4f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fv(Single* v);
            internal unsafe static Color4fv glColor4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static Color4i glColor4i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4iv(Int32* v);
            internal unsafe static Color4iv glColor4iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
            internal static Color4s glColor4s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4sv(Int16* v);
            internal unsafe static Color4sv glColor4sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            internal static Color4ub glColor4ub = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubv(Byte* v);
            internal unsafe static Color4ubv glColor4ubv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            internal static Color4ui glColor4ui = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4uiv(UInt32* v);
            internal unsafe static Color4uiv glColor4uiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            internal static Color4us glColor4us = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4usv(UInt16* v);
            internal unsafe static Color4usv glColor4usv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlag(GL.Enums.Boolean flag);
            internal static EdgeFlag glEdgeFlag = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagv(GL.Enums.Boolean* flag);
            internal unsafe static EdgeFlagv glEdgeFlagv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void End();
            internal static End glEnd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexd(Double c);
            internal static Indexd glIndexd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexdv(Double* c);
            internal unsafe static Indexdv glIndexdv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexf(Single c);
            internal static Indexf glIndexf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexfv(Single* c);
            internal unsafe static Indexfv glIndexfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexi(Int32 c);
            internal static Indexi glIndexi = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexiv(Int32* c);
            internal unsafe static Indexiv glIndexiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexs(Int16 c);
            internal static Indexs glIndexs = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexsv(Int16* c);
            internal unsafe static Indexsv glIndexsv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3b(SByte nx, SByte ny, SByte nz);
            internal static Normal3b glNormal3b = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3bv(SByte* v);
            internal unsafe static Normal3bv glNormal3bv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3d(Double nx, Double ny, Double nz);
            internal static Normal3d glNormal3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3dv(Double* v);
            internal unsafe static Normal3dv glNormal3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3f(Single nx, Single ny, Single nz);
            internal static Normal3f glNormal3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fv(Single* v);
            internal unsafe static Normal3fv glNormal3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3i(Int32 nx, Int32 ny, Int32 nz);
            internal static Normal3i glNormal3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3iv(Int32* v);
            internal unsafe static Normal3iv glNormal3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3s(Int16 nx, Int16 ny, Int16 nz);
            internal static Normal3s glNormal3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3sv(Int16* v);
            internal unsafe static Normal3sv glNormal3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2d(Double x, Double y);
            internal static RasterPos2d glRasterPos2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2dv(Double* v);
            internal unsafe static RasterPos2dv glRasterPos2dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2f(Single x, Single y);
            internal static RasterPos2f glRasterPos2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2fv(Single* v);
            internal unsafe static RasterPos2fv glRasterPos2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2i(Int32 x, Int32 y);
            internal static RasterPos2i glRasterPos2i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2iv(Int32* v);
            internal unsafe static RasterPos2iv glRasterPos2iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2s(Int16 x, Int16 y);
            internal static RasterPos2s glRasterPos2s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2sv(Int16* v);
            internal unsafe static RasterPos2sv glRasterPos2sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3d(Double x, Double y, Double z);
            internal static RasterPos3d glRasterPos3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3dv(Double* v);
            internal unsafe static RasterPos3dv glRasterPos3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3f(Single x, Single y, Single z);
            internal static RasterPos3f glRasterPos3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3fv(Single* v);
            internal unsafe static RasterPos3fv glRasterPos3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3i(Int32 x, Int32 y, Int32 z);
            internal static RasterPos3i glRasterPos3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3iv(Int32* v);
            internal unsafe static RasterPos3iv glRasterPos3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3s(Int16 x, Int16 y, Int16 z);
            internal static RasterPos3s glRasterPos3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3sv(Int16* v);
            internal unsafe static RasterPos3sv glRasterPos3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4d(Double x, Double y, Double z, Double w);
            internal static RasterPos4d glRasterPos4d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4dv(Double* v);
            internal unsafe static RasterPos4dv glRasterPos4dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4f(Single x, Single y, Single z, Single w);
            internal static RasterPos4f glRasterPos4f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4fv(Single* v);
            internal unsafe static RasterPos4fv glRasterPos4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static RasterPos4i glRasterPos4i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4iv(Int32* v);
            internal unsafe static RasterPos4iv glRasterPos4iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static RasterPos4s glRasterPos4s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4sv(Int16* v);
            internal unsafe static RasterPos4sv glRasterPos4sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectd(Double x1, Double y1, Double x2, Double y2);
            internal static Rectd glRectd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectdv(Double* v1, Double* v2);
            internal unsafe static Rectdv glRectdv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectf(Single x1, Single y1, Single x2, Single y2);
            internal static Rectf glRectf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectfv(Single* v1, Single* v2);
            internal unsafe static Rectfv glRectfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
            internal static Recti glRecti = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectiv(Int32* v1, Int32* v2);
            internal unsafe static Rectiv glRectiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
            internal static Rects glRects = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectsv(Int16* v1, Int16* v2);
            internal unsafe static Rectsv glRectsv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1d(Double s);
            internal static TexCoord1d glTexCoord1d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1dv(Double* v);
            internal unsafe static TexCoord1dv glTexCoord1dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1f(Single s);
            internal static TexCoord1f glTexCoord1f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1fv(Single* v);
            internal unsafe static TexCoord1fv glTexCoord1fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1i(Int32 s);
            internal static TexCoord1i glTexCoord1i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1iv(Int32* v);
            internal unsafe static TexCoord1iv glTexCoord1iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1s(Int16 s);
            internal static TexCoord1s glTexCoord1s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1sv(Int16* v);
            internal unsafe static TexCoord1sv glTexCoord1sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2d(Double s, Double t);
            internal static TexCoord2d glTexCoord2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2dv(Double* v);
            internal unsafe static TexCoord2dv glTexCoord2dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2f(Single s, Single t);
            internal static TexCoord2f glTexCoord2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fv(Single* v);
            internal unsafe static TexCoord2fv glTexCoord2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2i(Int32 s, Int32 t);
            internal static TexCoord2i glTexCoord2i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2iv(Int32* v);
            internal unsafe static TexCoord2iv glTexCoord2iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2s(Int16 s, Int16 t);
            internal static TexCoord2s glTexCoord2s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2sv(Int16* v);
            internal unsafe static TexCoord2sv glTexCoord2sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3d(Double s, Double t, Double r);
            internal static TexCoord3d glTexCoord3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3dv(Double* v);
            internal unsafe static TexCoord3dv glTexCoord3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3f(Single s, Single t, Single r);
            internal static TexCoord3f glTexCoord3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3fv(Single* v);
            internal unsafe static TexCoord3fv glTexCoord3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3i(Int32 s, Int32 t, Int32 r);
            internal static TexCoord3i glTexCoord3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3iv(Int32* v);
            internal unsafe static TexCoord3iv glTexCoord3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3s(Int16 s, Int16 t, Int16 r);
            internal static TexCoord3s glTexCoord3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3sv(Int16* v);
            internal unsafe static TexCoord3sv glTexCoord3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4d(Double s, Double t, Double r, Double q);
            internal static TexCoord4d glTexCoord4d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4dv(Double* v);
            internal unsafe static TexCoord4dv glTexCoord4dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4f(Single s, Single t, Single r, Single q);
            internal static TexCoord4f glTexCoord4f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fv(Single* v);
            internal unsafe static TexCoord4fv glTexCoord4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
            internal static TexCoord4i glTexCoord4i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4iv(Int32* v);
            internal unsafe static TexCoord4iv glTexCoord4iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
            internal static TexCoord4s glTexCoord4s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4sv(Int16* v);
            internal unsafe static TexCoord4sv glTexCoord4sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2d(Double x, Double y);
            internal static Vertex2d glVertex2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2dv(Double* v);
            internal unsafe static Vertex2dv glVertex2dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2f(Single x, Single y);
            internal static Vertex2f glVertex2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2fv(Single* v);
            internal unsafe static Vertex2fv glVertex2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2i(Int32 x, Int32 y);
            internal static Vertex2i glVertex2i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2iv(Int32* v);
            internal unsafe static Vertex2iv glVertex2iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2s(Int16 x, Int16 y);
            internal static Vertex2s glVertex2s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2sv(Int16* v);
            internal unsafe static Vertex2sv glVertex2sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3d(Double x, Double y, Double z);
            internal static Vertex3d glVertex3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3dv(Double* v);
            internal unsafe static Vertex3dv glVertex3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3f(Single x, Single y, Single z);
            internal static Vertex3f glVertex3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3fv(Single* v);
            internal unsafe static Vertex3fv glVertex3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3i(Int32 x, Int32 y, Int32 z);
            internal static Vertex3i glVertex3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3iv(Int32* v);
            internal unsafe static Vertex3iv glVertex3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3s(Int16 x, Int16 y, Int16 z);
            internal static Vertex3s glVertex3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3sv(Int16* v);
            internal unsafe static Vertex3sv glVertex3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4d(Double x, Double y, Double z, Double w);
            internal static Vertex4d glVertex4d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4dv(Double* v);
            internal unsafe static Vertex4dv glVertex4dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4f(Single x, Single y, Single z, Single w);
            internal static Vertex4f glVertex4f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4fv(Single* v);
            internal unsafe static Vertex4fv glVertex4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static Vertex4i glVertex4i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4iv(Int32* v);
            internal unsafe static Vertex4iv glVertex4iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static Vertex4s glVertex4s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4sv(Int16* v);
            internal unsafe static Vertex4sv glVertex4sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlane(GL.Enums.ClipPlaneName plane, Double* equation);
            internal unsafe static ClipPlane glClipPlane = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaterial(GL.Enums.MaterialFace face, GL.Enums.ColorMaterialParameter mode);
            internal static ColorMaterial glColorMaterial = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(GL.Enums.CullFaceMode mode);
            internal static CullFace glCullFace = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogf(GL.Enums.FogParameter pname, Single param);
            internal static Fogf glFogf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogfv(GL.Enums.FogParameter pname, Single* @params);
            internal unsafe static Fogfv glFogfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogi(GL.Enums.FogParameter pname, Int32 param);
            internal static Fogi glFogi = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogiv(GL.Enums.FogParameter pname, Int32* @params);
            internal unsafe static Fogiv glFogiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(GL.Enums.FrontFaceDirection mode);
            internal static FrontFace glFrontFace = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(GL.Enums.HintTarget target, GL.Enums.HintMode mode);
            internal static Hint glHint = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lightf(GL.Enums.LightName light, GL.Enums.LightParameter pname, Single param);
            internal static Lightf glLightf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, Single* @params);
            internal unsafe static Lightfv glLightfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lighti(GL.Enums.LightName light, GL.Enums.LightParameter pname, Int32 param);
            internal static Lighti glLighti = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, Int32* @params);
            internal unsafe static Lightiv glLightiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelf(GL.Enums.LightModelParameter pname, Single param);
            internal static LightModelf glLightModelf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelfv(GL.Enums.LightModelParameter pname, Single* @params);
            internal unsafe static LightModelfv glLightModelfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModeli(GL.Enums.LightModelParameter pname, Int32 param);
            internal static LightModeli glLightModeli = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModeliv(GL.Enums.LightModelParameter pname, Int32* @params);
            internal unsafe static LightModeliv glLightModeliv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineStipple(Int32 factor, UInt16 pattern);
            internal static LineStipple glLineStipple = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialf(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single param);
            internal static Materialf glMaterialf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single* @params);
            internal unsafe static Materialfv glMaterialfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materiali(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32 param);
            internal static Materiali glMateriali = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32* @params);
            internal unsafe static Materialiv glMaterialiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonMode(GL.Enums.MaterialFace face, GL.Enums.PolygonMode mode);
            internal static PolygonMode glPolygonMode = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PolygonStipple(Byte* mask);
            internal unsafe static PolygonStipple glPolygonStipple = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShadeModel(GL.Enums.ShadingModel mode);
            internal static ShadeModel glShadeModel = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexImage1D glTexImage1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexImage2D glTexImage2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvf(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Single param);
            internal static TexEnvf glTexEnvf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvi(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Int32 param);
            internal static TexEnvi glTexEnvi = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, Int32* @params);
            internal unsafe static TexEnviv glTexEnviv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGend(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Double param);
            internal static TexGend glTexGend = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Double* @params);
            internal unsafe static TexGendv glTexGendv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGenf(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Single param);
            internal static TexGenf glTexGenf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Single* @params);
            internal unsafe static TexGenfv glTexGenfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGeni(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Int32 param);
            internal static TexGeni glTexGeni = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, Int32* @params);
            internal unsafe static TexGeniv glTexGeniv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FeedbackBuffer(Int32 size, GL.Enums.FeedbackType type, [Out] Single* buffer);
            internal unsafe static FeedbackBuffer glFeedbackBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SelectBuffer(Int32 size, [Out] UInt32* buffer);
            internal unsafe static SelectBuffer glSelectBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 RenderMode(GL.Enums.RenderingMode mode);
            internal static RenderMode glRenderMode = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InitNames();
            internal static InitNames glInitNames = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadName(UInt32 name);
            internal static LoadName glLoadName = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PassThrough(Single token);
            internal static PassThrough glPassThrough = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopName();
            internal static PopName glPopName = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushName(UInt32 name);
            internal static PushName glPushName = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawBuffer(GL.Enums.DrawBufferMode mode);
            internal static DrawBuffer glDrawBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(GL.Enums.ClearBufferMask mask);
            internal static Clear glClear = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearAccum(Single red, Single green, Single blue, Single alpha);
            internal static ClearAccum glClearAccum = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearIndex(Single c);
            internal static ClearIndex glClearIndex = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepth(Double depth);
            internal static ClearDepth glClearDepth = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
            internal static ColorMask glColorMask = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(GL.Enums.Boolean flag);
            internal static DepthMask glDepthMask = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMask(UInt32 mask);
            internal static IndexMask glIndexMask = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Accum(GL.Enums.AccumOp op, Single value);
            internal static Accum glAccum = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(GL.Enums.EnableCap cap);
            internal static Disable glDisable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(GL.Enums.EnableCap cap);
            internal static Enable glEnable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopAttrib();
            internal static PopAttrib glPopAttrib = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushAttrib(GL.Enums.AttribMask mask);
            internal static PushAttrib glPushAttrib = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1d(GL.Enums.MapTarget target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            internal unsafe static Map1d glMap1d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1f(GL.Enums.MapTarget target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            internal unsafe static Map1f glMap1f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2d(GL.Enums.MapTarget target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            internal unsafe static Map2d glMap2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2f(GL.Enums.MapTarget target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            internal unsafe static Map2f glMap2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1d(Int32 un, Double u1, Double u2);
            internal static MapGrid1d glMapGrid1d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1f(Int32 un, Single u1, Single u2);
            internal static MapGrid1f glMapGrid1f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
            internal static MapGrid2d glMapGrid2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
            internal static MapGrid2f glMapGrid2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1d(Double u);
            internal static EvalCoord1d glEvalCoord1d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1dv(Double* u);
            internal unsafe static EvalCoord1dv glEvalCoord1dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1f(Single u);
            internal static EvalCoord1f glEvalCoord1f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1fv(Single* u);
            internal unsafe static EvalCoord1fv glEvalCoord1fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2d(Double u, Double v);
            internal static EvalCoord2d glEvalCoord2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2dv(Double* u);
            internal unsafe static EvalCoord2dv glEvalCoord2dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2f(Single u, Single v);
            internal static EvalCoord2f glEvalCoord2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2fv(Single* u);
            internal unsafe static EvalCoord2fv glEvalCoord2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh1(GL.Enums.MeshMode1 mode, Int32 i1, Int32 i2);
            internal static EvalMesh1 glEvalMesh1 = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint1(Int32 i);
            internal static EvalPoint1 glEvalPoint1 = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh2(GL.Enums.MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
            internal static EvalMesh2 glEvalMesh2 = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint2(Int32 i, Int32 j);
            internal static EvalPoint2 glEvalPoint2 = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFunc(GL.Enums.AlphaFunction func, Single @ref);
            internal static AlphaFunc glAlphaFunc = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(GL.Enums.BlendingFactorSrc sfactor, GL.Enums.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LogicOp(GL.Enums.LogicOp opcode);
            internal static LogicOp glLogicOp = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(GL.Enums.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(GL.Enums.StencilOp fail, GL.Enums.StencilOp zfail, GL.Enums.StencilOp zpass);
            internal static StencilOp glStencilOp = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc(GL.Enums.DepthFunction func);
            internal static DepthFunc glDepthFunc = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelZoom(Single xfactor, Single yfactor);
            internal static PixelZoom glPixelZoom = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferf(GL.Enums.PixelTransferParameter pname, Single param);
            internal static PixelTransferf glPixelTransferf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferi(GL.Enums.PixelTransferParameter pname, Int32 param);
            internal static PixelTransferi glPixelTransferi = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStoref(GL.Enums.PixelStoreParameter pname, Single param);
            internal static PixelStoref glPixelStoref = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(GL.Enums.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapfv(GL.Enums.PixelMap map, Int32 mapsize, Single* values);
            internal unsafe static PixelMapfv glPixelMapfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapuiv(GL.Enums.PixelMap map, Int32 mapsize, UInt32* values);
            internal unsafe static PixelMapuiv glPixelMapuiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapusv(GL.Enums.PixelMap map, Int32 mapsize, UInt16* values);
            internal unsafe static PixelMapusv glPixelMapusv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBuffer(GL.Enums.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, GL.Enums.PixelCopyType type);
            internal static CopyPixels glCopyPixels = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* pixels);
            internal unsafe static ReadPixels glReadPixels = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawPixels(Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static DrawPixels glDrawPixels = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(GL.Enums.GetPName pname, [Out] GL.Enums.Boolean* @params);
            internal unsafe static GetBooleanv glGetBooleanv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlane(GL.Enums.ClipPlaneName plane, [Out] Double* equation);
            internal unsafe static GetClipPlane glGetClipPlane = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublev(GL.Enums.GetPName pname, [Out] Double* @params);
            internal unsafe static GetDoublev glGetDoublev = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate GL.Enums.All GetError();
            internal static GetError glGetError = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(GL.Enums.GetPName pname, [Out] Single* @params);
            internal unsafe static GetFloatv glGetFloatv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(GL.Enums.GetPName pname, [Out] Int32* @params);
            internal unsafe static GetIntegerv glGetIntegerv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, [Out] Single* @params);
            internal unsafe static GetLightfv glGetLightfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, [Out] Int32* @params);
            internal unsafe static GetLightiv glGetLightiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapdv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, [Out] Double* v);
            internal unsafe static GetMapdv glGetMapdv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapfv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, [Out] Single* v);
            internal unsafe static GetMapfv glGetMapfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapiv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, [Out] Int32* v);
            internal unsafe static GetMapiv glGetMapiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Int32* @params);
            internal unsafe static GetMaterialiv glGetMaterialiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapfv(GL.Enums.PixelMap map, [Out] Single* values);
            internal unsafe static GetPixelMapfv glGetPixelMapfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapuiv(GL.Enums.PixelMap map, [Out] UInt32* values);
            internal unsafe static GetPixelMapuiv glGetPixelMapuiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapusv(GL.Enums.PixelMap map, [Out] UInt16* values);
            internal unsafe static GetPixelMapusv glGetPixelMapusv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPolygonStipple([Out] Byte* mask);
            internal unsafe static GetPolygonStipple glGetPolygonStipple = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(GL.Enums.StringName name);
            internal static GetString glGetString = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, [Out] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, [Out] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, [Out] Double* @params);
            internal unsafe static GetTexGendv glGetTexGendv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, [Out] Single* @params);
            internal unsafe static GetTexGenfv glGetTexGenfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, [Out] Int32* @params);
            internal unsafe static GetTexGeniv glGetTexGeniv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexImage(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* pixels);
            internal unsafe static GetTexImage glGetTexImage = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameterfv(GL.Enums.TextureTarget target, Int32 level, GL.Enums.GetTextureParameter pname, [Out] Single* @params);
            internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameteriv(GL.Enums.TextureTarget target, Int32 level, GL.Enums.GetTextureParameter pname, [Out] Int32* @params);
            internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsEnabled(GL.Enums.EnableCap cap);
            internal static IsEnabled glIsEnabled = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsList(UInt32 list);
            internal static IsList glIsList = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRange(Double near, Double far);
            internal static DepthRange glDepthRange = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static Frustum glFrustum = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixf(Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixd(Double* m);
            internal unsafe static LoadMatrixd glLoadMatrixd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixMode(GL.Enums.MatrixMode mode);
            internal static MatrixMode glMatrixMode = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixf(Single* m);
            internal unsafe static MultMatrixf glMultMatrixf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixd(Double* m);
            internal unsafe static MultMatrixd glMultMatrixd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static Ortho glOrtho = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotated(Double angle, Double x, Double y, Double z);
            internal static Rotated glRotated = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
            internal static Rotatef glRotatef = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scaled(Double x, Double y, Double z);
            internal static Scaled glScaled = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalef(Single x, Single y, Single z);
            internal static Scalef glScalef = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translated(Double x, Double y, Double z);
            internal static Translated glTranslated = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatef(Single x, Single y, Single z);
            internal static Translatef glTranslatef = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElement(Int32 i);
            internal static ArrayElement glArrayElement = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorPointer(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer);
            internal unsafe static ColorPointer glColorPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientState(GL.Enums.EnableCap array);
            internal static DisableClientState glDisableClientState = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(GL.Enums.BeginMode mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawElements(GL.Enums.BeginMode mode, Int32 count, GL.Enums.All type, void* indices);
            internal unsafe static DrawElements glDrawElements = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointer(Int32 stride, void* pointer);
            internal unsafe static EdgeFlagPointer glEdgeFlagPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientState(GL.Enums.EnableCap array);
            internal static EnableClientState glEnableClientState = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPointerv(GL.Enums.GetPointervPName pname, [Out] void* @params);
            internal unsafe static GetPointerv glGetPointerv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void IndexPointer(GL.Enums.IndexPointerType type, Int32 stride, void* pointer);
            internal unsafe static IndexPointer glIndexPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InterleavedArrays(GL.Enums.InterleavedArrayFormat format, Int32 stride, void* pointer);
            internal unsafe static InterleavedArrays glInterleavedArrays = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalPointer(GL.Enums.NormalPointerType type, Int32 stride, void* pointer);
            internal unsafe static NormalPointer glNormalPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordPointer(Int32 size, GL.Enums.TexCoordPointerType type, Int32 stride, void* pointer);
            internal unsafe static TexCoordPointer glTexCoordPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexPointer(Int32 size, GL.Enums.VertexPointerType type, Int32 stride, void* pointer);
            internal unsafe static VertexPointer glVertexPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1D glCopyTexImage1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1D glCopyTexSubImage1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexSubImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexSubImage1D glTexSubImage1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexSubImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexSubImage2D glTexSubImage2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean AreTexturesResident(Int32 n, UInt32* textures, [Out] GL.Enums.Boolean* residences);
            internal unsafe static AreTexturesResident glAreTexturesResident = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(GL.Enums.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures(Int32 n, [Out] UInt32* textures);
            internal unsafe static GenTextures glGenTextures = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
            internal unsafe static PrioritizeTextures glPrioritizeTextures = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexub(Byte c);
            internal static Indexub glIndexub = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexubv(Byte* c);
            internal unsafe static Indexubv glIndexubv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopClientAttrib();
            internal static PopClientAttrib glPopClientAttrib = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushClientAttrib(GL.Enums.ClientAttribMask mask);
            internal static PushClientAttrib glPushClientAttrib = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation(GL.Enums.VERSION_1_2 mode);
            internal static BlendEquation glBlendEquation = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawRangeElements(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 count, GL.Enums.VERSION_1_2 type, void* indices);
            internal unsafe static DrawRangeElements glDrawRangeElements = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
            internal unsafe static ColorTable glColorTable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Single* @params);
            internal unsafe static ColorTableParameterfv glColorTableParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Int32* @params);
            internal unsafe static ColorTableParameteriv glColorTableParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTable glCopyColorTable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* table);
            internal unsafe static GetColorTable glGetColorTable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
            internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
            internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorSubTable(GL.Enums.VERSION_1_2 target, Int32 start, Int32 count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            internal unsafe static ColorSubTable glColorSubTable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTable(GL.Enums.VERSION_1_2 target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTable glCopyColorSubTable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
            internal unsafe static ConvolutionFilter1D glConvolutionFilter1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
            internal unsafe static ConvolutionFilter2D glConvolutionFilter2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterf(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Single @params);
            internal static ConvolutionParameterf glConvolutionParameterf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Single* @params);
            internal unsafe static ConvolutionParameterfv glConvolutionParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteri(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Int32 @params);
            internal static ConvolutionParameteri glConvolutionParameteri = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, Int32* @params);
            internal unsafe static ConvolutionParameteriv glConvolutionParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* image);
            internal unsafe static GetConvolutionFilter glGetConvolutionFilter = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
            internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
            internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSeparableFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* row, [Out] void* column, [Out] void* span);
            internal unsafe static GetSeparableFilter glGetSeparableFilter = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SeparableFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
            internal unsafe static SeparableFilter2D glSeparableFilter2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogram(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
            internal unsafe static GetHistogram glGetHistogram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
            internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
            internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmax(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
            internal unsafe static GetMinmax glGetMinmax = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Single* @params);
            internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, [Out] Int32* @params);
            internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Histogram(GL.Enums.VERSION_1_2 target, Int32 width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
            internal static Histogram glHistogram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Minmax(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
            internal static Minmax glMinmax = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogram(GL.Enums.VERSION_1_2 target);
            internal static ResetHistogram glResetHistogram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmax(GL.Enums.VERSION_1_2 target);
            internal static ResetMinmax glResetMinmax = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexImage3D glTexImage3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexSubImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexSubImage3D glTexSubImage3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(GL.Enums.VERSION_1_3 texture);
            internal static ActiveTexture glActiveTexture = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTexture(GL.Enums.VERSION_1_3 texture);
            internal static ClientActiveTexture glClientActiveTexture = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1d(GL.Enums.VERSION_1_3 target, Double s);
            internal static MultiTexCoord1d glMultiTexCoord1d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dv(GL.Enums.VERSION_1_3 target, Double* v);
            internal unsafe static MultiTexCoord1dv glMultiTexCoord1dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1f(GL.Enums.VERSION_1_3 target, Single s);
            internal static MultiTexCoord1f glMultiTexCoord1f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fv(GL.Enums.VERSION_1_3 target, Single* v);
            internal unsafe static MultiTexCoord1fv glMultiTexCoord1fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1i(GL.Enums.VERSION_1_3 target, Int32 s);
            internal static MultiTexCoord1i glMultiTexCoord1i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1iv(GL.Enums.VERSION_1_3 target, Int32* v);
            internal unsafe static MultiTexCoord1iv glMultiTexCoord1iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1s(GL.Enums.VERSION_1_3 target, Int16 s);
            internal static MultiTexCoord1s glMultiTexCoord1s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1sv(GL.Enums.VERSION_1_3 target, Int16* v);
            internal unsafe static MultiTexCoord1sv glMultiTexCoord1sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2d(GL.Enums.VERSION_1_3 target, Double s, Double t);
            internal static MultiTexCoord2d glMultiTexCoord2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dv(GL.Enums.VERSION_1_3 target, Double* v);
            internal unsafe static MultiTexCoord2dv glMultiTexCoord2dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2f(GL.Enums.VERSION_1_3 target, Single s, Single t);
            internal static MultiTexCoord2f glMultiTexCoord2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fv(GL.Enums.VERSION_1_3 target, Single* v);
            internal unsafe static MultiTexCoord2fv glMultiTexCoord2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2i(GL.Enums.VERSION_1_3 target, Int32 s, Int32 t);
            internal static MultiTexCoord2i glMultiTexCoord2i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2iv(GL.Enums.VERSION_1_3 target, Int32* v);
            internal unsafe static MultiTexCoord2iv glMultiTexCoord2iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2s(GL.Enums.VERSION_1_3 target, Int16 s, Int16 t);
            internal static MultiTexCoord2s glMultiTexCoord2s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2sv(GL.Enums.VERSION_1_3 target, Int16* v);
            internal unsafe static MultiTexCoord2sv glMultiTexCoord2sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3d(GL.Enums.VERSION_1_3 target, Double s, Double t, Double r);
            internal static MultiTexCoord3d glMultiTexCoord3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dv(GL.Enums.VERSION_1_3 target, Double* v);
            internal unsafe static MultiTexCoord3dv glMultiTexCoord3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3f(GL.Enums.VERSION_1_3 target, Single s, Single t, Single r);
            internal static MultiTexCoord3f glMultiTexCoord3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fv(GL.Enums.VERSION_1_3 target, Single* v);
            internal unsafe static MultiTexCoord3fv glMultiTexCoord3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3i(GL.Enums.VERSION_1_3 target, Int32 s, Int32 t, Int32 r);
            internal static MultiTexCoord3i glMultiTexCoord3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3iv(GL.Enums.VERSION_1_3 target, Int32* v);
            internal unsafe static MultiTexCoord3iv glMultiTexCoord3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3s(GL.Enums.VERSION_1_3 target, Int16 s, Int16 t, Int16 r);
            internal static MultiTexCoord3s glMultiTexCoord3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3sv(GL.Enums.VERSION_1_3 target, Int16* v);
            internal unsafe static MultiTexCoord3sv glMultiTexCoord3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4d(GL.Enums.VERSION_1_3 target, Double s, Double t, Double r, Double q);
            internal static MultiTexCoord4d glMultiTexCoord4d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dv(GL.Enums.VERSION_1_3 target, Double* v);
            internal unsafe static MultiTexCoord4dv glMultiTexCoord4dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4f(GL.Enums.VERSION_1_3 target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fv(GL.Enums.VERSION_1_3 target, Single* v);
            internal unsafe static MultiTexCoord4fv glMultiTexCoord4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4i(GL.Enums.VERSION_1_3 target, Int32 s, Int32 t, Int32 r, Int32 q);
            internal static MultiTexCoord4i glMultiTexCoord4i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4iv(GL.Enums.VERSION_1_3 target, Int32* v);
            internal unsafe static MultiTexCoord4iv glMultiTexCoord4iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4s(GL.Enums.VERSION_1_3 target, Int16 s, Int16 t, Int16 r, Int16 q);
            internal static MultiTexCoord4s glMultiTexCoord4s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4sv(GL.Enums.VERSION_1_3 target, Int16* v);
            internal unsafe static MultiTexCoord4sv glMultiTexCoord4sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixf(Single* m);
            internal unsafe static LoadTransposeMatrixf glLoadTransposeMatrixf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixd(Double* m);
            internal unsafe static LoadTransposeMatrixd glLoadTransposeMatrixd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixf(Single* m);
            internal unsafe static MultTransposeMatrixf glMultTransposeMatrixf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixd(Double* m);
            internal unsafe static MultTransposeMatrixd glMultTransposeMatrixd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value, GL.Enums.Boolean invert);
            internal static SampleCoverage glSampleCoverage = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexImage3D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
            internal unsafe static CompressedTexImage3D glCompressedTexImage3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexImage2D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
            internal unsafe static CompressedTexImage2D glCompressedTexImage2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexImage1D(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
            internal unsafe static CompressedTexImage1D glCompressedTexImage1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexSubImage3D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
            internal unsafe static CompressedTexSubImage3D glCompressedTexSubImage3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexSubImage2D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
            internal unsafe static CompressedTexSubImage2D glCompressedTexSubImage2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexSubImage1D(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
            internal unsafe static CompressedTexSubImage1D glCompressedTexSubImage1D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCompressedTexImage(GL.Enums.TextureTarget target, Int32 level, [Out] void* img);
            internal unsafe static GetCompressedTexImage glGetCompressedTexImage = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate(GL.Enums.VERSION_1_4 sfactorRGB, GL.Enums.VERSION_1_4 dfactorRGB, GL.Enums.VERSION_1_4 sfactorAlpha, GL.Enums.VERSION_1_4 dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordf(Single coord);
            internal static FogCoordf glFogCoordf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfv(Single* coord);
            internal unsafe static FogCoordfv glFogCoordfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordd(Double coord);
            internal static FogCoordd glFogCoordd = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddv(Double* coord);
            internal unsafe static FogCoorddv glFogCoorddv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordPointer(GL.Enums.VERSION_1_4 type, Int32 stride, void* pointer);
            internal unsafe static FogCoordPointer glFogCoordPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArrays(GL.Enums.BeginMode mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArrays glMultiDrawArrays = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElements(GL.Enums.BeginMode mode, Int32* count, GL.Enums.VERSION_1_4 type, void* indices, Int32 primcount);
            internal unsafe static MultiDrawElements glMultiDrawElements = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterf(GL.Enums.VERSION_1_4 pname, Single param);
            internal static PointParameterf glPointParameterf = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfv(GL.Enums.VERSION_1_4 pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteri(GL.Enums.VERSION_1_4 pname, Int32 param);
            internal static PointParameteri glPointParameteri = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameteriv(GL.Enums.VERSION_1_4 pname, Int32* @params);
            internal unsafe static PointParameteriv glPointParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3b(SByte red, SByte green, SByte blue);
            internal static SecondaryColor3b glSecondaryColor3b = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bv(SByte* v);
            internal unsafe static SecondaryColor3bv glSecondaryColor3bv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3d(Double red, Double green, Double blue);
            internal static SecondaryColor3d glSecondaryColor3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dv(Double* v);
            internal unsafe static SecondaryColor3dv glSecondaryColor3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3f(Single red, Single green, Single blue);
            internal static SecondaryColor3f glSecondaryColor3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fv(Single* v);
            internal unsafe static SecondaryColor3fv glSecondaryColor3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
            internal static SecondaryColor3i glSecondaryColor3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3iv(Int32* v);
            internal unsafe static SecondaryColor3iv glSecondaryColor3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
            internal static SecondaryColor3s glSecondaryColor3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3sv(Int16* v);
            internal unsafe static SecondaryColor3sv glSecondaryColor3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ub(Byte red, Byte green, Byte blue);
            internal static SecondaryColor3ub glSecondaryColor3ub = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubv(Byte* v);
            internal unsafe static SecondaryColor3ubv glSecondaryColor3ubv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
            internal static SecondaryColor3ui glSecondaryColor3ui = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uiv(UInt32* v);
            internal unsafe static SecondaryColor3uiv glSecondaryColor3uiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3us glSecondaryColor3us = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usv(UInt16* v);
            internal unsafe static SecondaryColor3usv glSecondaryColor3usv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColorPointer(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer);
            internal unsafe static SecondaryColorPointer glSecondaryColorPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2d(Double x, Double y);
            internal static WindowPos2d glWindowPos2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dv(Double* v);
            internal unsafe static WindowPos2dv glWindowPos2dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2f(Single x, Single y);
            internal static WindowPos2f glWindowPos2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fv(Single* v);
            internal unsafe static WindowPos2fv glWindowPos2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2i(Int32 x, Int32 y);
            internal static WindowPos2i glWindowPos2i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2iv(Int32* v);
            internal unsafe static WindowPos2iv glWindowPos2iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2s(Int16 x, Int16 y);
            internal static WindowPos2s glWindowPos2s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2sv(Int16* v);
            internal unsafe static WindowPos2sv glWindowPos2sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3d(Double x, Double y, Double z);
            internal static WindowPos3d glWindowPos3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dv(Double* v);
            internal unsafe static WindowPos3dv glWindowPos3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3f(Single x, Single y, Single z);
            internal static WindowPos3f glWindowPos3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fv(Single* v);
            internal unsafe static WindowPos3fv glWindowPos3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3i(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3i glWindowPos3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3iv(Int32* v);
            internal unsafe static WindowPos3iv glWindowPos3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3s(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3s glWindowPos3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3sv(Int16* v);
            internal unsafe static WindowPos3sv glWindowPos3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueries(Int32 n, [Out] UInt32* ids);
            internal unsafe static GenQueries glGenQueries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsQuery(UInt32 id);
            internal static IsQuery glIsQuery = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQuery(GL.Enums.VERSION_1_5 target, UInt32 id);
            internal static BeginQuery glBeginQuery = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQuery(GL.Enums.VERSION_1_5 target);
            internal static EndQuery glEndQuery = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryiv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, [Out] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectiv(UInt32 id, GL.Enums.VERSION_1_5 pname, [Out] Int32* @params);
            internal unsafe static GetQueryObjectiv glGetQueryObjectiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, GL.Enums.VERSION_1_5 pname, [Out] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(GL.Enums.VERSION_1_5 target, UInt32 buffer);
            internal static BindBuffer glBindBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n, [Out] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BufferData(GL.Enums.VERSION_1_5 target, IntPtr size, void* data, GL.Enums.VERSION_1_5 usage);
            internal unsafe static BufferData glBufferData = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BufferSubData(GL.Enums.VERSION_1_5 target, IntPtr offset, IntPtr size, void* data);
            internal unsafe static BufferSubData glBufferSubData = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferSubData(GL.Enums.VERSION_1_5 target, IntPtr offset, IntPtr size, [Out] void* data);
            internal unsafe static GetBufferSubData glGetBufferSubData = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBuffer(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 access);
            internal static MapBuffer glMapBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UnmapBuffer(GL.Enums.VERSION_1_5 target);
            internal static UnmapBuffer glUnmapBuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, [Out] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferPointerv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, [Out] void* @params);
            internal unsafe static GetBufferPointerv glGetBufferPointerv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffers(Int32 n, GL.Enums.VERSION_2_0* bufs);
            internal unsafe static DrawBuffers glDrawBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate(GL.Enums.VERSION_2_0 face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate(GL.Enums.VERSION_2_0 face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, System.String name);
            internal static BindAttribLocation glBindAttribLocation = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader(GL.Enums.VERSION_2_0 type);
            internal static CreateShader glCreateShader = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.VERSION_2_0* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.VERSION_2_0* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
            internal unsafe static GetAttachedShaders glGetAttachedShaders = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocation(UInt32 program, System.String name);
            internal static GetAttribLocation glGetAttribLocation = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv(UInt32 program, GL.Enums.VERSION_2_0 pname, [Out] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv(UInt32 shader, GL.Enums.VERSION_2_0 pname, [Out] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
            internal unsafe static GetShaderSource glGetShaderSource = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocation(UInt32 program, System.String name);
            internal static GetUniformLocation glGetUniformLocation = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [Out] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [Out] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] Double* @params);
            internal unsafe static GetVertexAttribdv glGetVertexAttribdv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribPointerv(UInt32 index, GL.Enums.VERSION_2_0 pname, [Out] void* pointer);
            internal unsafe static GetVertexAttribPointerv glGetVertexAttribPointerv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsProgram(UInt32 program);
            internal static IsProgram glIsProgram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsShader(UInt32 shader);
            internal static IsShader glIsShader = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, System.String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1f(Int32 location, Single v0);
            internal static Uniform1f glUniform1f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
            internal static Uniform2f glUniform2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3f glUniform3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4f glUniform4f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i(Int32 location, Int32 v0);
            internal static Uniform1i glUniform1i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2i glUniform2i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3i glUniform3i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4i glUniform4i = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fv glUniform1fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fv glUniform2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fv glUniform3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fv glUniform4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1iv glUniform1iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2iv glUniform2iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3iv glUniform3iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4iv glUniform4iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1d(UInt32 index, Double x);
            internal static VertexAttrib1d glVertexAttrib1d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dv glVertexAttrib1dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1s(UInt32 index, Int16 x);
            internal static VertexAttrib1s glVertexAttrib1s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1sv glVertexAttrib1sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2d(UInt32 index, Double x, Double y);
            internal static VertexAttrib2d glVertexAttrib2d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dv glVertexAttrib2dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2s glVertexAttrib2s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2sv glVertexAttrib2sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3d glVertexAttrib3d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dv glVertexAttrib3dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3s glVertexAttrib3s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3sv glVertexAttrib3sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nbv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Niv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nsv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4Nub glVertexAttrib4Nub = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bv glVertexAttrib4bv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4d glVertexAttrib4d = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dv glVertexAttrib4dv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4iv glVertexAttrib4iv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4s glVertexAttrib4s = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4sv glVertexAttrib4sv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usv glVertexAttrib4usv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribPointer(UInt32 index, Int32 size, GL.Enums.VERSION_2_0 type, GL.Enums.Boolean normalized, Int32 stride, void* pointer);
            internal unsafe static VertexAttribPointer glVertexAttribPointer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTextureARB(GL.Enums.ARB_multitexture texture);
            internal static ActiveTextureARB glActiveTextureARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTextureARB(GL.Enums.ARB_multitexture texture);
            internal static ClientActiveTextureARB glClientActiveTextureARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1dARB(GL.Enums.ARB_multitexture target, Double s);
            internal static MultiTexCoord1dARB glMultiTexCoord1dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dvARB(GL.Enums.ARB_multitexture target, Double* v);
            internal unsafe static MultiTexCoord1dvARB glMultiTexCoord1dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1fARB(GL.Enums.ARB_multitexture target, Single s);
            internal static MultiTexCoord1fARB glMultiTexCoord1fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fvARB(GL.Enums.ARB_multitexture target, Single* v);
            internal unsafe static MultiTexCoord1fvARB glMultiTexCoord1fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1iARB(GL.Enums.ARB_multitexture target, Int32 s);
            internal static MultiTexCoord1iARB glMultiTexCoord1iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1ivARB(GL.Enums.ARB_multitexture target, Int32* v);
            internal unsafe static MultiTexCoord1ivARB glMultiTexCoord1ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1sARB(GL.Enums.ARB_multitexture target, Int16 s);
            internal static MultiTexCoord1sARB glMultiTexCoord1sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1svARB(GL.Enums.ARB_multitexture target, Int16* v);
            internal unsafe static MultiTexCoord1svARB glMultiTexCoord1svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2dARB(GL.Enums.ARB_multitexture target, Double s, Double t);
            internal static MultiTexCoord2dARB glMultiTexCoord2dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dvARB(GL.Enums.ARB_multitexture target, Double* v);
            internal unsafe static MultiTexCoord2dvARB glMultiTexCoord2dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2fARB(GL.Enums.ARB_multitexture target, Single s, Single t);
            internal static MultiTexCoord2fARB glMultiTexCoord2fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fvARB(GL.Enums.ARB_multitexture target, Single* v);
            internal unsafe static MultiTexCoord2fvARB glMultiTexCoord2fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2iARB(GL.Enums.ARB_multitexture target, Int32 s, Int32 t);
            internal static MultiTexCoord2iARB glMultiTexCoord2iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2ivARB(GL.Enums.ARB_multitexture target, Int32* v);
            internal unsafe static MultiTexCoord2ivARB glMultiTexCoord2ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2sARB(GL.Enums.ARB_multitexture target, Int16 s, Int16 t);
            internal static MultiTexCoord2sARB glMultiTexCoord2sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2svARB(GL.Enums.ARB_multitexture target, Int16* v);
            internal unsafe static MultiTexCoord2svARB glMultiTexCoord2svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3dARB(GL.Enums.ARB_multitexture target, Double s, Double t, Double r);
            internal static MultiTexCoord3dARB glMultiTexCoord3dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dvARB(GL.Enums.ARB_multitexture target, Double* v);
            internal unsafe static MultiTexCoord3dvARB glMultiTexCoord3dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3fARB(GL.Enums.ARB_multitexture target, Single s, Single t, Single r);
            internal static MultiTexCoord3fARB glMultiTexCoord3fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fvARB(GL.Enums.ARB_multitexture target, Single* v);
            internal unsafe static MultiTexCoord3fvARB glMultiTexCoord3fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3iARB(GL.Enums.ARB_multitexture target, Int32 s, Int32 t, Int32 r);
            internal static MultiTexCoord3iARB glMultiTexCoord3iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3ivARB(GL.Enums.ARB_multitexture target, Int32* v);
            internal unsafe static MultiTexCoord3ivARB glMultiTexCoord3ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3sARB(GL.Enums.ARB_multitexture target, Int16 s, Int16 t, Int16 r);
            internal static MultiTexCoord3sARB glMultiTexCoord3sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3svARB(GL.Enums.ARB_multitexture target, Int16* v);
            internal unsafe static MultiTexCoord3svARB glMultiTexCoord3svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4dARB(GL.Enums.ARB_multitexture target, Double s, Double t, Double r, Double q);
            internal static MultiTexCoord4dARB glMultiTexCoord4dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dvARB(GL.Enums.ARB_multitexture target, Double* v);
            internal unsafe static MultiTexCoord4dvARB glMultiTexCoord4dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4fARB(GL.Enums.ARB_multitexture target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4fARB glMultiTexCoord4fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fvARB(GL.Enums.ARB_multitexture target, Single* v);
            internal unsafe static MultiTexCoord4fvARB glMultiTexCoord4fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4iARB(GL.Enums.ARB_multitexture target, Int32 s, Int32 t, Int32 r, Int32 q);
            internal static MultiTexCoord4iARB glMultiTexCoord4iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4ivARB(GL.Enums.ARB_multitexture target, Int32* v);
            internal unsafe static MultiTexCoord4ivARB glMultiTexCoord4ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4sARB(GL.Enums.ARB_multitexture target, Int16 s, Int16 t, Int16 r, Int16 q);
            internal static MultiTexCoord4sARB glMultiTexCoord4sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4svARB(GL.Enums.ARB_multitexture target, Int16* v);
            internal unsafe static MultiTexCoord4svARB glMultiTexCoord4svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixfARB(Single* m);
            internal unsafe static LoadTransposeMatrixfARB glLoadTransposeMatrixfARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixdARB(Double* m);
            internal unsafe static LoadTransposeMatrixdARB glLoadTransposeMatrixdARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixfARB(Single* m);
            internal unsafe static MultTransposeMatrixfARB glMultTransposeMatrixfARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixdARB(Double* m);
            internal unsafe static MultTransposeMatrixdARB glMultTransposeMatrixdARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverageARB(Single value, GL.Enums.Boolean invert);
            internal static SampleCoverageARB glSampleCoverageARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexImage3DARB(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, void* data);
            internal unsafe static CompressedTexImage3DARB glCompressedTexImage3DARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexImage2DARB(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, void* data);
            internal unsafe static CompressedTexImage2DARB glCompressedTexImage2DARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexImage1DARB(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, void* data);
            internal unsafe static CompressedTexImage1DARB glCompressedTexImage1DARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexSubImage3DARB(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
            internal unsafe static CompressedTexSubImage3DARB glCompressedTexSubImage3DARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexSubImage2DARB(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
            internal unsafe static CompressedTexSubImage2DARB glCompressedTexSubImage2DARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompressedTexSubImage1DARB(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, Int32 imageSize, void* data);
            internal unsafe static CompressedTexSubImage1DARB glCompressedTexSubImage1DARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCompressedTexImageARB(GL.Enums.TextureTarget target, Int32 level, [Out] void* img);
            internal unsafe static GetCompressedTexImageARB glGetCompressedTexImageARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfARB(GL.Enums.ARB_point_parameters pname, Single param);
            internal static PointParameterfARB glPointParameterfARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvARB(GL.Enums.ARB_point_parameters pname, Single* @params);
            internal unsafe static PointParameterfvARB glPointParameterfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightbvARB(Int32 size, SByte* weights);
            internal unsafe static WeightbvARB glWeightbvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightsvARB(Int32 size, Int16* weights);
            internal unsafe static WeightsvARB glWeightsvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightivARB(Int32 size, Int32* weights);
            internal unsafe static WeightivARB glWeightivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightfvARB(Int32 size, Single* weights);
            internal unsafe static WeightfvARB glWeightfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightdvARB(Int32 size, Double* weights);
            internal unsafe static WeightdvARB glWeightdvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightubvARB(Int32 size, Byte* weights);
            internal unsafe static WeightubvARB glWeightubvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightusvARB(Int32 size, UInt16* weights);
            internal unsafe static WeightusvARB glWeightusvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightuivARB(Int32 size, UInt32* weights);
            internal unsafe static WeightuivARB glWeightuivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightPointerARB(Int32 size, GL.Enums.ARB_vertex_blend type, Int32 stride, void* pointer);
            internal unsafe static WeightPointerARB glWeightPointerARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendARB(Int32 count);
            internal static VertexBlendARB glVertexBlendARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CurrentPaletteMatrixARB(Int32 index);
            internal static CurrentPaletteMatrixARB glCurrentPaletteMatrixARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexubvARB(Int32 size, Byte* indices);
            internal unsafe static MatrixIndexubvARB glMatrixIndexubvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexusvARB(Int32 size, UInt16* indices);
            internal unsafe static MatrixIndexusvARB glMatrixIndexusvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexuivARB(Int32 size, UInt32* indices);
            internal unsafe static MatrixIndexuivARB glMatrixIndexuivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexPointerARB(Int32 size, GL.Enums.ARB_matrix_palette type, Int32 stride, void* pointer);
            internal unsafe static MatrixIndexPointerARB glMatrixIndexPointerARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dARB(Double x, Double y);
            internal static WindowPos2dARB glWindowPos2dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvARB(Double* v);
            internal unsafe static WindowPos2dvARB glWindowPos2dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fARB(Single x, Single y);
            internal static WindowPos2fARB glWindowPos2fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvARB(Single* v);
            internal unsafe static WindowPos2fvARB glWindowPos2fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iARB(Int32 x, Int32 y);
            internal static WindowPos2iARB glWindowPos2iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivARB(Int32* v);
            internal unsafe static WindowPos2ivARB glWindowPos2ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sARB(Int16 x, Int16 y);
            internal static WindowPos2sARB glWindowPos2sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svARB(Int16* v);
            internal unsafe static WindowPos2svARB glWindowPos2svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dARB(Double x, Double y, Double z);
            internal static WindowPos3dARB glWindowPos3dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvARB(Double* v);
            internal unsafe static WindowPos3dvARB glWindowPos3dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fARB(Single x, Single y, Single z);
            internal static WindowPos3fARB glWindowPos3fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvARB(Single* v);
            internal unsafe static WindowPos3fvARB glWindowPos3fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iARB(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3iARB glWindowPos3iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivARB(Int32* v);
            internal unsafe static WindowPos3ivARB glWindowPos3ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sARB(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3sARB glWindowPos3sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svARB(Int16* v);
            internal unsafe static WindowPos3svARB glWindowPos3svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dARB(UInt32 index, Double x);
            internal static VertexAttrib1dARB glVertexAttrib1dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dvARB glVertexAttrib1dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fARB(UInt32 index, Single x);
            internal static VertexAttrib1fARB glVertexAttrib1fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fvARB glVertexAttrib1fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sARB(UInt32 index, Int16 x);
            internal static VertexAttrib1sARB glVertexAttrib1sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1svARB glVertexAttrib1svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dARB(UInt32 index, Double x, Double y);
            internal static VertexAttrib2dARB glVertexAttrib2dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dvARB glVertexAttrib2dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fARB(UInt32 index, Single x, Single y);
            internal static VertexAttrib2fARB glVertexAttrib2fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fvARB glVertexAttrib2fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2sARB glVertexAttrib2sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2svARB glVertexAttrib2svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dARB(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3dARB glVertexAttrib3dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dvARB glVertexAttrib3dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fARB(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3fARB glVertexAttrib3fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fvARB glVertexAttrib3fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3sARB glVertexAttrib3sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3svARB glVertexAttrib3svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NbvARB(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4NbvARB glVertexAttrib4NbvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NivARB(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4NivARB glVertexAttrib4NivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NsvARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4NsvARB glVertexAttrib4NsvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4NubARB(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4NubARB glVertexAttrib4NubARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NubvARB(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4NubvARB glVertexAttrib4NubvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NuivARB(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4NuivARB glVertexAttrib4NuivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NusvARB(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4NusvARB glVertexAttrib4NusvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bvARB(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bvARB glVertexAttrib4bvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dARB(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4dARB glVertexAttrib4dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dvARB glVertexAttrib4dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fARB(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4fARB glVertexAttrib4fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fvARB glVertexAttrib4fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ivARB(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4ivARB glVertexAttrib4ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4sARB glVertexAttrib4sARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4svARB glVertexAttrib4svARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvARB(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubvARB glVertexAttrib4ubvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uivARB(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uivARB glVertexAttrib4uivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usvARB(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usvARB glVertexAttrib4usvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribPointerARB(UInt32 index, Int32 size, GL.Enums.ARB_vertex_program type, GL.Enums.Boolean normalized, Int32 stride, void* pointer);
            internal unsafe static VertexAttribPointerARB glVertexAttribPointerARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArrayARB(UInt32 index);
            internal static EnableVertexAttribArrayARB glEnableVertexAttribArrayARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArrayARB(UInt32 index);
            internal static DisableVertexAttribArrayARB glDisableVertexAttribArrayARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program format, Int32 len, void* @string);
            internal unsafe static ProgramStringARB glProgramStringARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramARB(GL.Enums.ARB_vertex_program target, UInt32 program);
            internal static BindProgramARB glBindProgramARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsARB(Int32 n, UInt32* programs);
            internal unsafe static DeleteProgramsARB glDeleteProgramsARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsARB(Int32 n, [Out] UInt32* programs);
            internal unsafe static GenProgramsARB glGenProgramsARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4dARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramEnvParameter4dARB glProgramEnvParameter4dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4dvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double* @params);
            internal unsafe static ProgramEnvParameter4dvARB glProgramEnvParameter4dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4fARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramEnvParameter4fARB glProgramEnvParameter4fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4fvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single* @params);
            internal unsafe static ProgramEnvParameter4fvARB glProgramEnvParameter4fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4dARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramLocalParameter4dARB glProgramLocalParameter4dARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4dvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Double* @params);
            internal unsafe static ProgramLocalParameter4dvARB glProgramLocalParameter4dvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4fARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramLocalParameter4fARB glProgramLocalParameter4fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4fvARB(GL.Enums.ARB_vertex_program target, UInt32 index, Single* @params);
            internal unsafe static ProgramLocalParameter4fvARB glProgramLocalParameter4fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterdvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Double* @params);
            internal unsafe static GetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterfvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Single* @params);
            internal unsafe static GetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterdvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Double* @params);
            internal unsafe static GetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterfvARB(GL.Enums.ARB_vertex_program target, UInt32 index, [Out] Single* @params);
            internal unsafe static GetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, [Out] Int32* @params);
            internal unsafe static GetProgramivARB glGetProgramivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, [Out] void* @string);
            internal unsafe static GetProgramStringARB glGetProgramStringARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] Double* @params);
            internal unsafe static GetVertexAttribdvARB glGetVertexAttribdvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribfvARB glGetVertexAttribfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribivARB glGetVertexAttribivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribPointervARB(UInt32 index, GL.Enums.ARB_vertex_program pname, [Out] void* pointer);
            internal unsafe static GetVertexAttribPointervARB glGetVertexAttribPointervARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsProgramARB(UInt32 program);
            internal static IsProgramARB glIsProgramARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferARB(GL.Enums.ARB_vertex_buffer_object target, UInt32 buffer);
            internal static BindBufferARB glBindBufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffersARB(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffersARB glDeleteBuffersARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffersARB(Int32 n, [Out] UInt32* buffers);
            internal unsafe static GenBuffersARB glGenBuffersARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsBufferARB(UInt32 buffer);
            internal static IsBufferARB glIsBufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BufferDataARB(GL.Enums.ARB_vertex_buffer_object target, IntPtr size, void* data, GL.Enums.ARB_vertex_buffer_object usage);
            internal unsafe static BufferDataARB glBufferDataARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, IntPtr offset, IntPtr size, void* data);
            internal unsafe static BufferSubDataARB glBufferSubDataARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, IntPtr offset, IntPtr size, [Out] void* data);
            internal unsafe static GetBufferSubDataARB glGetBufferSubDataARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBufferARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object access);
            internal static MapBufferARB glMapBufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UnmapBufferARB(GL.Enums.ARB_vertex_buffer_object target);
            internal static UnmapBufferARB glUnmapBufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameterivARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, [Out] Int32* @params);
            internal unsafe static GetBufferParameterivARB glGetBufferParameterivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferPointervARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, [Out] void* @params);
            internal unsafe static GetBufferPointervARB glGetBufferPointervARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueriesARB(Int32 n, [Out] UInt32* ids);
            internal unsafe static GenQueriesARB glGenQueriesARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueriesARB(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueriesARB glDeleteQueriesARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsQueryARB(UInt32 id);
            internal static IsQueryARB glIsQueryARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryARB(GL.Enums.ARB_occlusion_query target, UInt32 id);
            internal static BeginQueryARB glBeginQueryARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryARB(GL.Enums.ARB_occlusion_query target);
            internal static EndQueryARB glEndQueryARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryivARB(GL.Enums.ARB_occlusion_query target, GL.Enums.ARB_occlusion_query pname, [Out] Int32* @params);
            internal unsafe static GetQueryivARB glGetQueryivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectivARB(UInt32 id, GL.Enums.ARB_occlusion_query pname, [Out] Int32* @params);
            internal unsafe static GetQueryObjectivARB glGetQueryObjectivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuivARB(UInt32 id, GL.Enums.ARB_occlusion_query pname, [Out] UInt32* @params);
            internal unsafe static GetQueryObjectuivARB glGetQueryObjectuivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteObjectARB(UInt32 obj);
            internal static DeleteObjectARB glDeleteObjectARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetHandleARB(GL.Enums.ARB_shader_objects pname);
            internal static GetHandleARB glGetHandleARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
            internal static DetachObjectARB glDetachObjectARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderObjectARB(GL.Enums.ARB_shader_objects shaderType);
            internal static CreateShaderObjectARB glCreateShaderObjectARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSourceARB(UInt32 shaderObj, Int32 count, System.String[] @string, Int32* length);
            internal unsafe static ShaderSourceARB glShaderSourceARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShaderARB(UInt32 shaderObj);
            internal static CompileShaderARB glCompileShaderARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgramObjectARB();
            internal static CreateProgramObjectARB glCreateProgramObjectARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachObjectARB(UInt32 containerObj, UInt32 obj);
            internal static AttachObjectARB glAttachObjectARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgramARB(UInt32 programObj);
            internal static LinkProgramARB glLinkProgramARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramObjectARB(UInt32 programObj);
            internal static UseProgramObjectARB glUseProgramObjectARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramARB(UInt32 programObj);
            internal static ValidateProgramARB glValidateProgramARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1fARB(Int32 location, Single v0);
            internal static Uniform1fARB glUniform1fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2fARB(Int32 location, Single v0, Single v1);
            internal static Uniform2fARB glUniform2fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3fARB(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3fARB glUniform3fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4fARB(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4fARB glUniform4fARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1iARB(Int32 location, Int32 v0);
            internal static Uniform1iARB glUniform1iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2iARB(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2iARB glUniform2iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3iARB glUniform3iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4iARB glUniform4iARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fvARB glUniform1fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fvARB glUniform2fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fvARB glUniform3fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fvARB glUniform4fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1ivARB glUniform1ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2ivARB glUniform2ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3ivARB glUniform3ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4ivARB glUniform4ivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fvARB(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix2fvARB glUniformMatrix2fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fvARB(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix3fvARB glUniformMatrix3fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fvARB(Int32 location, Int32 count, GL.Enums.Boolean transpose, Single* value);
            internal unsafe static UniformMatrix4fvARB glUniformMatrix4fvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterfvARB(UInt32 obj, GL.Enums.ARB_shader_objects pname, [Out] Single* @params);
            internal unsafe static GetObjectParameterfvARB glGetObjectParameterfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterivARB(UInt32 obj, GL.Enums.ARB_shader_objects pname, [Out] Int32* @params);
            internal unsafe static GetObjectParameterivARB glGetObjectParameterivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInfoLogARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            internal unsafe static GetInfoLogARB glGetInfoLogARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
            internal unsafe static GetAttachedObjectsARB glGetAttachedObjectsARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocationARB(UInt32 programObj, System.String name);
            internal static GetUniformLocationARB glGetUniformLocationARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.ARB_shader_objects* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveUniformARB glGetActiveUniformARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfvARB(UInt32 programObj, Int32 location, [Out] Single* @params);
            internal unsafe static GetUniformfvARB glGetUniformfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformivARB(UInt32 programObj, Int32 location, [Out] Int32* @params);
            internal unsafe static GetUniformivARB glGetUniformivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSourceARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
            internal unsafe static GetShaderSourceARB glGetShaderSourceARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocationARB(UInt32 programObj, UInt32 index, System.String name);
            internal static BindAttribLocationARB glBindAttribLocationARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.ARB_vertex_shader* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveAttribARB glGetActiveAttribARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocationARB(UInt32 programObj, System.String name);
            internal static GetAttribLocationARB glGetAttribLocationARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersARB(Int32 n, GL.Enums.ARB_draw_buffers* bufs);
            internal unsafe static DrawBuffersARB glDrawBuffersARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClampColorARB(GL.Enums.ARB_color_buffer_float target, GL.Enums.ARB_color_buffer_float clamp);
            internal static ClampColorARB glClampColorARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColorEXT(Single red, Single green, Single blue, Single alpha);
            internal static BlendColorEXT glBlendColorEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffsetEXT(Single factor, Single bias);
            internal static PolygonOffsetEXT glPolygonOffsetEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexImage3DEXT(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexImage3DEXT glTexImage3DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexSubImage3DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexSubImage3DEXT glTexSubImage3DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, [Out] Single* weights);
            internal unsafe static GetTexFilterFuncSGIS glGetTexFilterFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, Int32 n, Single* weights);
            internal unsafe static TexFilterFuncSGIS glTexFilterFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexSubImage1DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexSubImage1DEXT glTexSubImage1DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexSubImage2DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexSubImage2DEXT glTexSubImage2DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1DEXT(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1DEXT glCopyTexImage1DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2DEXT(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2DEXT glCopyTexImage2DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1DEXT glCopyTexSubImage1DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2DEXT glCopyTexSubImage2DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3DEXT(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3DEXT glCopyTexSubImage3DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
            internal unsafe static GetHistogramEXT glGetHistogramEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfvEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, [Out] Single* @params);
            internal unsafe static GetHistogramParameterfvEXT glGetHistogramParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterivEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, [Out] Int32* @params);
            internal unsafe static GetHistogramParameterivEXT glGetHistogramParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* values);
            internal unsafe static GetMinmaxEXT glGetMinmaxEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfvEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, [Out] Single* @params);
            internal unsafe static GetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterivEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, [Out] Int32* @params);
            internal unsafe static GetMinmaxParameterivEXT glGetMinmaxParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void HistogramEXT(GL.Enums.HistogramTargetEXT target, Int32 width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
            internal static HistogramEXT glHistogramEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
            internal static MinmaxEXT glMinmaxEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogramEXT(GL.Enums.HistogramTargetEXT target);
            internal static ResetHistogramEXT glResetHistogramEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmaxEXT(GL.Enums.MinmaxTargetEXT target);
            internal static ResetMinmaxEXT glResetMinmaxEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
            internal unsafe static ConvolutionFilter1DEXT glConvolutionFilter1DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
            internal unsafe static ConvolutionFilter2DEXT glConvolutionFilter2DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterfEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Single @params);
            internal static ConvolutionParameterfEXT glConvolutionParameterfEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Single* @params);
            internal unsafe static ConvolutionParameterfvEXT glConvolutionParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteriEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Int32 @params);
            internal static ConvolutionParameteriEXT glConvolutionParameteriEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, Int32* @params);
            internal unsafe static ConvolutionParameterivEXT glConvolutionParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionFilterEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* image);
            internal unsafe static GetConvolutionFilterEXT glGetConvolutionFilterEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, [Out] Single* @params);
            internal unsafe static GetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, [Out] Int32* @params);
            internal unsafe static GetConvolutionParameterivEXT glGetConvolutionParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSeparableFilterEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* row, [Out] void* column, [Out] void* span);
            internal unsafe static GetSeparableFilterEXT glGetSeparableFilterEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SeparableFilter2DEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
            internal unsafe static SeparableFilter2DEXT glSeparableFilter2DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
            internal unsafe static ColorTableSGI glColorTableSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, Single* @params);
            internal unsafe static ColorTableParameterfvSGI glColorTableParameterfvSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, Int32* @params);
            internal unsafe static ColorTableParameterivSGI glColorTableParameterivSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTableSGI glCopyColorTableSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* table);
            internal unsafe static GetColorTableSGI glGetColorTableSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, [Out] Single* @params);
            internal unsafe static GetColorTableParameterfvSGI glGetColorTableParameterfvSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, [Out] Int32* @params);
            internal unsafe static GetColorTableParameterivSGI glGetColorTableParameterivSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenSGIX(GL.Enums.SGIX_pixel_texture mode);
            internal static PixelTexGenSGIX glPixelTexGenSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameteriSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Int32 param);
            internal static PixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Int32* @params);
            internal unsafe static PixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameterfSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Single param);
            internal static PixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, Single* @params);
            internal unsafe static PixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, [Out] Int32* @params);
            internal unsafe static GetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, [Out] Single* @params);
            internal unsafe static GetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexImage4DSGIS(GL.Enums.TextureTarget target, Int32 level, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexImage4DSGIS glTexImage4DSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexSubImage4DSGIS(GL.Enums.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
            internal unsafe static TexSubImage4DSGIS glTexSubImage4DSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean AreTexturesResidentEXT(Int32 n, UInt32* textures, [Out] GL.Enums.Boolean* residences);
            internal unsafe static AreTexturesResidentEXT glAreTexturesResidentEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTextureEXT(GL.Enums.TextureTarget target, UInt32 texture);
            internal static BindTextureEXT glBindTextureEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTexturesEXT(Int32 n, UInt32* textures);
            internal unsafe static DeleteTexturesEXT glDeleteTexturesEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTexturesEXT(Int32 n, [Out] UInt32* textures);
            internal unsafe static GenTexturesEXT glGenTexturesEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsTextureEXT(UInt32 texture);
            internal static IsTextureEXT glIsTextureEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTexturesEXT(Int32 n, UInt32* textures, Single* priorities);
            internal unsafe static PrioritizeTexturesEXT glPrioritizeTexturesEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DetailTexFuncSGIS(GL.Enums.TextureTarget target, Int32 n, Single* points);
            internal unsafe static DetailTexFuncSGIS glDetailTexFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDetailTexFuncSGIS(GL.Enums.TextureTarget target, [Out] Single* points);
            internal unsafe static GetDetailTexFuncSGIS glGetDetailTexFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SharpenTexFuncSGIS(GL.Enums.TextureTarget target, Int32 n, Single* points);
            internal unsafe static SharpenTexFuncSGIS glSharpenTexFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSharpenTexFuncSGIS(GL.Enums.TextureTarget target, [Out] Single* points);
            internal unsafe static GetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskSGIS(Single value, GL.Enums.Boolean invert);
            internal static SampleMaskSGIS glSampleMaskSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternSGIS(GL.Enums.SamplePatternSGIS pattern);
            internal static SamplePatternSGIS glSamplePatternSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElementEXT(Int32 i);
            internal static ArrayElementEXT glArrayElementEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorPointerEXT(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, Int32 count, void* pointer);
            internal unsafe static ColorPointerEXT glColorPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysEXT(GL.Enums.BeginMode mode, Int32 first, Int32 count);
            internal static DrawArraysEXT glDrawArraysEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerEXT(Int32 stride, Int32 count, GL.Enums.Boolean* pointer);
            internal unsafe static EdgeFlagPointerEXT glEdgeFlagPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPointervEXT(GL.Enums.GetPointervPName pname, [Out] void* @params);
            internal unsafe static GetPointervEXT glGetPointervEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void IndexPointerEXT(GL.Enums.IndexPointerType type, Int32 stride, Int32 count, void* pointer);
            internal unsafe static IndexPointerEXT glIndexPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalPointerEXT(GL.Enums.NormalPointerType type, Int32 stride, Int32 count, void* pointer);
            internal unsafe static NormalPointerEXT glNormalPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordPointerEXT(Int32 size, GL.Enums.TexCoordPointerType type, Int32 stride, Int32 count, void* pointer);
            internal unsafe static TexCoordPointerEXT glTexCoordPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexPointerEXT(Int32 size, GL.Enums.VertexPointerType type, Int32 stride, Int32 count, void* pointer);
            internal unsafe static VertexPointerEXT glVertexPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationEXT(GL.Enums.BlendEquationModeEXT mode);
            internal static BlendEquationEXT glBlendEquationEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameterfSGIX(GL.Enums.SGIX_sprite pname, Single param);
            internal static SpriteParameterfSGIX glSpriteParameterfSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterfvSGIX(GL.Enums.SGIX_sprite pname, Single* @params);
            internal unsafe static SpriteParameterfvSGIX glSpriteParameterfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameteriSGIX(GL.Enums.SGIX_sprite pname, Int32 param);
            internal static SpriteParameteriSGIX glSpriteParameteriSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterivSGIX(GL.Enums.SGIX_sprite pname, Int32* @params);
            internal unsafe static SpriteParameterivSGIX glSpriteParameterivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfEXT(GL.Enums.EXT_point_parameters pname, Single param);
            internal static PointParameterfEXT glPointParameterfEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvEXT(GL.Enums.EXT_point_parameters pname, Single* @params);
            internal unsafe static PointParameterfvEXT glPointParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfSGIS(GL.Enums.SGIS_point_parameters pname, Single param);
            internal static PointParameterfSGIS glPointParameterfSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvSGIS(GL.Enums.SGIS_point_parameters pname, Single* @params);
            internal unsafe static PointParameterfvSGIS glPointParameterfvSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetInstrumentsSGIX();
            internal static GetInstrumentsSGIX glGetInstrumentsSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InstrumentsBufferSGIX(Int32 size, [Out] Int32* buffer);
            internal unsafe static InstrumentsBufferSGIX glInstrumentsBufferSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollInstrumentsSGIX([Out] Int32* marker_p);
            internal unsafe static PollInstrumentsSGIX glPollInstrumentsSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadInstrumentsSGIX(Int32 marker);
            internal static ReadInstrumentsSGIX glReadInstrumentsSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StartInstrumentsSGIX();
            internal static StartInstrumentsSGIX glStartInstrumentsSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StopInstrumentsSGIX(Int32 marker);
            internal static StopInstrumentsSGIX glStopInstrumentsSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrameZoomSGIX(Int32 factor);
            internal static FrameZoomSGIX glFrameZoomSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TagSampleBufferSGIX();
            internal static TagSampleBufferSGIX glTagSampleBufferSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3dSGIX(GL.Enums.FfdTargetSGIX target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double w1, Double w2, Int32 wstride, Int32 worder, Double* points);
            internal unsafe static DeformationMap3dSGIX glDeformationMap3dSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3fSGIX(GL.Enums.FfdTargetSGIX target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single w1, Single w2, Int32 wstride, Int32 worder, Single* points);
            internal unsafe static DeformationMap3fSGIX glDeformationMap3fSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeformSGIX(GL.Enums.FfdMaskSGIX mask);
            internal static DeformSGIX glDeformSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentityDeformationMapSGIX(GL.Enums.FfdMaskSGIX mask);
            internal static LoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReferencePlaneSGIX(Double* equation);
            internal unsafe static ReferencePlaneSGIX glReferencePlaneSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushRasterSGIX();
            internal static FlushRasterSGIX glFlushRasterSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogFuncSGIS(Int32 n, Single* points);
            internal unsafe static FogFuncSGIS glFogFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFogFuncSGIS([Out] Single* points);
            internal unsafe static GetFogFuncSGIS glGetFogFuncSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameteriHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Int32 param);
            internal static ImageTransformParameteriHP glImageTransformParameteriHP = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameterfHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Single param);
            internal static ImageTransformParameterfHP glImageTransformParameterfHP = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Int32* @params);
            internal unsafe static ImageTransformParameterivHP glImageTransformParameterivHP = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, Single* @params);
            internal unsafe static ImageTransformParameterfvHP glImageTransformParameterfvHP = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, [Out] Int32* @params);
            internal unsafe static GetImageTransformParameterivHP glGetImageTransformParameterivHP = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, [Out] Single* @params);
            internal unsafe static GetImageTransformParameterfvHP glGetImageTransformParameterfvHP = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorSubTableEXT(GL.Enums.EXT_color_subtable target, Int32 start, Int32 count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            internal unsafe static ColorSubTableEXT glColorSubTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTableEXT(GL.Enums.EXT_color_subtable target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTableEXT glCopyColorSubTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void HintPGI(GL.Enums.PGI_misc_hints target, Int32 mode);
            internal static HintPGI glHintPGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelInternalFormat internalFormat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
            internal unsafe static ColorTableEXT glColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, [Out] void* data);
            internal unsafe static GetColorTableEXT glGetColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, [Out] Int32* @params);
            internal unsafe static GetColorTableParameterivEXT glGetColorTableParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, [Out] Single* @params);
            internal unsafe static GetColorTableParameterfvEXT glGetColorTableParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterfvSGIX(UInt32 list, GL.Enums.ListParameterName pname, [Out] Single* @params);
            internal unsafe static GetListParameterfvSGIX glGetListParameterfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterivSGIX(UInt32 list, GL.Enums.ListParameterName pname, [Out] Int32* @params);
            internal unsafe static GetListParameterivSGIX glGetListParameterivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameterfSGIX(UInt32 list, GL.Enums.ListParameterName pname, Single param);
            internal static ListParameterfSGIX glListParameterfSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterfvSGIX(UInt32 list, GL.Enums.ListParameterName pname, Single* @params);
            internal unsafe static ListParameterfvSGIX glListParameterfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameteriSGIX(UInt32 list, GL.Enums.ListParameterName pname, Int32 param);
            internal static ListParameteriSGIX glListParameteriSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterivSGIX(UInt32 list, GL.Enums.ListParameterName pname, Int32* @params);
            internal unsafe static ListParameterivSGIX glListParameterivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.EXT_index_material mode);
            internal static IndexMaterialEXT glIndexMaterialEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexFuncEXT(GL.Enums.EXT_index_func func, Single @ref);
            internal static IndexFuncEXT glIndexFuncEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LockArraysEXT(Int32 first, Int32 count);
            internal static LockArraysEXT glLockArraysEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UnlockArraysEXT();
            internal static UnlockArraysEXT glUnlockArraysEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterdvEXT(GL.Enums.EXT_cull_vertex pname, [Out] Double* @params);
            internal unsafe static CullParameterdvEXT glCullParameterdvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterfvEXT(GL.Enums.EXT_cull_vertex pname, [Out] Single* @params);
            internal unsafe static CullParameterfvEXT glCullParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentColorMaterialSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
            internal static FragmentColorMaterialSGIX glFragmentColorMaterialSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightfSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Single param);
            internal static FragmentLightfSGIX glFragmentLightfSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Single* @params);
            internal unsafe static FragmentLightfvSGIX glFragmentLightfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightiSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Int32 param);
            internal static FragmentLightiSGIX glFragmentLightiSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, Int32* @params);
            internal unsafe static FragmentLightivSGIX glFragmentLightivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModelfSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Single param);
            internal static FragmentLightModelfSGIX glFragmentLightModelfSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelfvSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Single* @params);
            internal unsafe static FragmentLightModelfvSGIX glFragmentLightModelfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModeliSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Int32 param);
            internal static FragmentLightModeliSGIX glFragmentLightModeliSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelivSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, Int32* @params);
            internal unsafe static FragmentLightModelivSGIX glFragmentLightModelivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialfSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single param);
            internal static FragmentMaterialfSGIX glFragmentMaterialfSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Single* @params);
            internal unsafe static FragmentMaterialfvSGIX glFragmentMaterialfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialiSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32 param);
            internal static FragmentMaterialiSGIX glFragmentMaterialiSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, Int32* @params);
            internal unsafe static FragmentMaterialivSGIX glFragmentMaterialivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, [Out] Single* @params);
            internal unsafe static GetFragmentLightfvSGIX glGetFragmentLightfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, [Out] Int32* @params);
            internal unsafe static GetFragmentLightivSGIX glGetFragmentLightivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Single* @params);
            internal unsafe static GetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, [Out] Int32* @params);
            internal unsafe static GetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightEnviSGIX(GL.Enums.LightEnvParameterSGIX pname, Int32 param);
            internal static LightEnviSGIX glLightEnviSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawRangeElementsEXT(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 count, GL.Enums.EXT_draw_range_elements type, void* indices);
            internal unsafe static DrawRangeElementsEXT glDrawRangeElementsEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ApplyTextureEXT(GL.Enums.EXT_light_texture mode);
            internal static ApplyTextureEXT glApplyTextureEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureLightEXT(GL.Enums.EXT_light_texture pname);
            internal static TextureLightEXT glTextureLightEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
            internal static TextureMaterialEXT glTextureMaterialEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AsyncMarkerSGIX(UInt32 marker);
            internal static AsyncMarkerSGIX glAsyncMarkerSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 FinishAsyncSGIX([Out] UInt32* markerp);
            internal unsafe static FinishAsyncSGIX glFinishAsyncSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollAsyncSGIX([Out] UInt32* markerp);
            internal unsafe static PollAsyncSGIX glPollAsyncSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenAsyncMarkersSGIX(Int32 range);
            internal static GenAsyncMarkersSGIX glGenAsyncMarkersSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
            internal static DeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsAsyncMarkerSGIX(UInt32 marker);
            internal static IsAsyncMarkerSGIX glIsAsyncMarkerSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexPointervINTEL(Int32 size, GL.Enums.VertexPointerType type, void* pointer);
            internal unsafe static VertexPointervINTEL glVertexPointervINTEL = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalPointervINTEL(GL.Enums.NormalPointerType type, void* pointer);
            internal unsafe static NormalPointervINTEL glNormalPointervINTEL = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorPointervINTEL(Int32 size, GL.Enums.VertexPointerType type, void* pointer);
            internal unsafe static ColorPointervINTEL glColorPointervINTEL = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordPointervINTEL(Int32 size, GL.Enums.VertexPointerType type, void* pointer);
            internal unsafe static TexCoordPointervINTEL glTexCoordPointervINTEL = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameteriEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Int32 param);
            internal static PixelTransformParameteriEXT glPixelTransformParameteriEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameterfEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Single param);
            internal static PixelTransformParameterfEXT glPixelTransformParameterfEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterivEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Int32* @params);
            internal unsafe static PixelTransformParameterivEXT glPixelTransformParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterfvEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, Single* @params);
            internal unsafe static PixelTransformParameterfvEXT glPixelTransformParameterfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3bEXT(SByte red, SByte green, SByte blue);
            internal static SecondaryColor3bEXT glSecondaryColor3bEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bvEXT(SByte* v);
            internal unsafe static SecondaryColor3bvEXT glSecondaryColor3bvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3dEXT(Double red, Double green, Double blue);
            internal static SecondaryColor3dEXT glSecondaryColor3dEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dvEXT(Double* v);
            internal unsafe static SecondaryColor3dvEXT glSecondaryColor3dvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3fEXT(Single red, Single green, Single blue);
            internal static SecondaryColor3fEXT glSecondaryColor3fEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fvEXT(Single* v);
            internal unsafe static SecondaryColor3fvEXT glSecondaryColor3fvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
            internal static SecondaryColor3iEXT glSecondaryColor3iEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ivEXT(Int32* v);
            internal unsafe static SecondaryColor3ivEXT glSecondaryColor3ivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
            internal static SecondaryColor3sEXT glSecondaryColor3sEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3svEXT(Int16* v);
            internal unsafe static SecondaryColor3svEXT glSecondaryColor3svEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ubEXT(Byte red, Byte green, Byte blue);
            internal static SecondaryColor3ubEXT glSecondaryColor3ubEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubvEXT(Byte* v);
            internal unsafe static SecondaryColor3ubvEXT glSecondaryColor3ubvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
            internal static SecondaryColor3uiEXT glSecondaryColor3uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uivEXT(UInt32* v);
            internal unsafe static SecondaryColor3uivEXT glSecondaryColor3uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3usEXT glSecondaryColor3usEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usvEXT(UInt16* v);
            internal unsafe static SecondaryColor3usvEXT glSecondaryColor3usvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColorPointerEXT(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer);
            internal unsafe static SecondaryColorPointerEXT glSecondaryColorPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureNormalEXT(GL.Enums.EXT_texture_perturb_normal mode);
            internal static TextureNormalEXT glTextureNormalEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArraysEXT(GL.Enums.BeginMode mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsEXT(GL.Enums.BeginMode mode, Int32* count, GL.Enums.EXT_multi_draw_arrays type, void* indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordfEXT(Single coord);
            internal static FogCoordfEXT glFogCoordfEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfvEXT(Single* coord);
            internal unsafe static FogCoordfvEXT glFogCoordfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoorddEXT(Double coord);
            internal static FogCoorddEXT glFogCoorddEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddvEXT(Double* coord);
            internal unsafe static FogCoorddvEXT glFogCoorddvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordPointerEXT(GL.Enums.EXT_fog_coord type, Int32 stride, void* pointer);
            internal unsafe static FogCoordPointerEXT glFogCoordPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3bEXT(SByte tx, SByte ty, SByte tz);
            internal static Tangent3bEXT glTangent3bEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3bvEXT(SByte* v);
            internal unsafe static Tangent3bvEXT glTangent3bvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3dEXT(Double tx, Double ty, Double tz);
            internal static Tangent3dEXT glTangent3dEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3dvEXT(Double* v);
            internal unsafe static Tangent3dvEXT glTangent3dvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3fEXT(Single tx, Single ty, Single tz);
            internal static Tangent3fEXT glTangent3fEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3fvEXT(Single* v);
            internal unsafe static Tangent3fvEXT glTangent3fvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
            internal static Tangent3iEXT glTangent3iEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3ivEXT(Int32* v);
            internal unsafe static Tangent3ivEXT glTangent3ivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
            internal static Tangent3sEXT glTangent3sEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3svEXT(Int16* v);
            internal unsafe static Tangent3svEXT glTangent3svEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3bEXT(SByte bx, SByte by, SByte bz);
            internal static Binormal3bEXT glBinormal3bEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3bvEXT(SByte* v);
            internal unsafe static Binormal3bvEXT glBinormal3bvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3dEXT(Double bx, Double by, Double bz);
            internal static Binormal3dEXT glBinormal3dEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3dvEXT(Double* v);
            internal unsafe static Binormal3dvEXT glBinormal3dvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3fEXT(Single bx, Single by, Single bz);
            internal static Binormal3fEXT glBinormal3fEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3fvEXT(Single* v);
            internal unsafe static Binormal3fvEXT glBinormal3fvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3iEXT(Int32 bx, Int32 by, Int32 bz);
            internal static Binormal3iEXT glBinormal3iEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3ivEXT(Int32* v);
            internal unsafe static Binormal3ivEXT glBinormal3ivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3sEXT(Int16 bx, Int16 by, Int16 bz);
            internal static Binormal3sEXT glBinormal3sEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3svEXT(Int16* v);
            internal unsafe static Binormal3svEXT glBinormal3svEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TangentPointerEXT(GL.Enums.EXT_coordinate_frame type, Int32 stride, void* pointer);
            internal unsafe static TangentPointerEXT glTangentPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BinormalPointerEXT(GL.Enums.EXT_coordinate_frame type, Int32 stride, void* pointer);
            internal unsafe static BinormalPointerEXT glBinormalPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishTextureSUNX();
            internal static FinishTextureSUNX glFinishTextureSUNX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorbSUN(SByte factor);
            internal static GlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorsSUN(Int16 factor);
            internal static GlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoriSUN(Int32 factor);
            internal static GlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorfSUN(Single factor);
            internal static GlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactordSUN(Double factor);
            internal static GlobalAlphaFactordSUN glGlobalAlphaFactordSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorubSUN(Byte factor);
            internal static GlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorusSUN(UInt16 factor);
            internal static GlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoruiSUN(UInt32 factor);
            internal static GlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiSUN(UInt32 code);
            internal static ReplacementCodeuiSUN glReplacementCodeuiSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeusSUN(UInt16 code);
            internal static ReplacementCodeusSUN glReplacementCodeusSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeubSUN(Byte code);
            internal static ReplacementCodeubSUN glReplacementCodeubSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuivSUN(UInt32* code);
            internal unsafe static ReplacementCodeuivSUN glReplacementCodeuivSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeusvSUN(UInt16* code);
            internal unsafe static ReplacementCodeusvSUN glReplacementCodeusvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeubvSUN(Byte* code);
            internal unsafe static ReplacementCodeubvSUN glReplacementCodeubvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodePointerSUN(GL.Enums.SUN_triangle_list type, Int32 stride, void* pointer);
            internal unsafe static ReplacementCodePointerSUN glReplacementCodePointerSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex2fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y);
            internal static Color4ubVertex2fSUN glColor4ubVertex2fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex2fvSUN(Byte* c, Single* v);
            internal unsafe static Color4ubVertex2fvSUN glColor4ubVertex2fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex3fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static Color4ubVertex3fSUN glColor4ubVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex3fvSUN(Byte* c, Single* v);
            internal unsafe static Color4ubVertex3fvSUN glColor4ubVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3fVertex3fSUN(Single r, Single g, Single b, Single x, Single y, Single z);
            internal static Color3fVertex3fSUN glColor3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fVertex3fvSUN(Single* c, Single* v);
            internal unsafe static Color3fVertex3fvSUN glColor3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3fVertex3fSUN(Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static Normal3fVertex3fSUN glNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fVertex3fvSUN(Single* n, Single* v);
            internal unsafe static Normal3fVertex3fvSUN glNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4fNormal3fVertex3fSUN(Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static Color4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fNormal3fVertex3fvSUN(Single* c, Single* n, Single* v);
            internal unsafe static Color4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fVertex3fSUN(Single s, Single t, Single x, Single y, Single z);
            internal static TexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fVertex3fvSUN(Single* tc, Single* v);
            internal unsafe static TexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fVertex4fSUN(Single s, Single t, Single p, Single q, Single x, Single y, Single z, Single w);
            internal static TexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fVertex4fvSUN(Single* tc, Single* v);
            internal unsafe static TexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4ubVertex3fSUN(Single s, Single t, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static TexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4ubVertex3fvSUN(Single* tc, Byte* c, Single* v);
            internal unsafe static TexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single x, Single y, Single z);
            internal static TexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor3fVertex3fvSUN(Single* tc, Single* c, Single* v);
            internal unsafe static TexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fNormal3fVertex3fSUN(Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static TexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fNormal3fVertex3fvSUN(Single* tc, Single* n, Single* v);
            internal unsafe static TexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4fNormal3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static TexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static TexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fColor4fNormal3fVertex4fSUN(Single s, Single t, Single p, Single q, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z, Single w);
            internal static TexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static TexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiVertex3fSUN(UInt32 rc, Single x, Single y, Single z);
            internal static ReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiVertex3fvSUN(UInt32* rc, Single* v);
            internal unsafe static ReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, Byte* c, Single* v);
            internal unsafe static ReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, Single* c, Single* v);
            internal unsafe static ReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* c, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, Single s, Single t, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, Single* tc, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateEXT(GL.Enums.EXT_blend_func_separate sfactorRGB, GL.Enums.EXT_blend_func_separate dfactorRGB, GL.Enums.EXT_blend_func_separate sfactorAlpha, GL.Enums.EXT_blend_func_separate dfactorAlpha);
            internal static BlendFuncSeparateEXT glBlendFuncSeparateEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateINGR(GL.Enums.All sfactorRGB, GL.Enums.All dfactorRGB, GL.Enums.All sfactorAlpha, GL.Enums.All dfactorAlpha);
            internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeightfEXT(Single weight);
            internal static VertexWeightfEXT glVertexWeightfEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeightfvEXT(Single* weight);
            internal unsafe static VertexWeightfvEXT glVertexWeightfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeightPointerEXT(Int32 size, GL.Enums.EXT_vertex_weighting type, Int32 stride, void* pointer);
            internal unsafe static VertexWeightPointerEXT glVertexWeightPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushVertexArrayRangeNV();
            internal static FlushVertexArrayRangeNV glFlushVertexArrayRangeNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexArrayRangeNV(Int32 length, void* pointer);
            internal unsafe static VertexArrayRangeNV glVertexArrayRangeNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterfvNV(GL.Enums.NV_register_combiners pname, Single* @params);
            internal unsafe static CombinerParameterfvNV glCombinerParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameterfNV(GL.Enums.NV_register_combiners pname, Single param);
            internal static CombinerParameterfNV glCombinerParameterfNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterivNV(GL.Enums.NV_register_combiners pname, Int32* @params);
            internal unsafe static CombinerParameterivNV glCombinerParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameteriNV(GL.Enums.NV_register_combiners pname, Int32 param);
            internal static CombinerParameteriNV glCombinerParameteriNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerInputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
            internal static CombinerInputNV glCombinerInputNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerOutputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners abOutput, GL.Enums.NV_register_combiners cdOutput, GL.Enums.NV_register_combiners sumOutput, GL.Enums.NV_register_combiners scale, GL.Enums.NV_register_combiners bias, GL.Enums.Boolean abDotProduct, GL.Enums.Boolean cdDotProduct, GL.Enums.Boolean muxSum);
            internal static CombinerOutputNV glCombinerOutputNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinalCombinerInputNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
            internal static FinalCombinerInputNV glFinalCombinerInputNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Single* @params);
            internal unsafe static GetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Int32* @params);
            internal unsafe static GetCombinerInputParameterivNV glGetCombinerInputParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, [Out] Single* @params);
            internal unsafe static GetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, [Out] Int32* @params);
            internal unsafe static GetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterfvNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Single* @params);
            internal unsafe static GetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterivNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, [Out] Int32* @params);
            internal unsafe static GetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResizeBuffersMESA();
            internal static ResizeBuffersMESA glResizeBuffersMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dMESA(Double x, Double y);
            internal static WindowPos2dMESA glWindowPos2dMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvMESA(Double* v);
            internal unsafe static WindowPos2dvMESA glWindowPos2dvMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fMESA(Single x, Single y);
            internal static WindowPos2fMESA glWindowPos2fMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvMESA(Single* v);
            internal unsafe static WindowPos2fvMESA glWindowPos2fvMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iMESA(Int32 x, Int32 y);
            internal static WindowPos2iMESA glWindowPos2iMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivMESA(Int32* v);
            internal unsafe static WindowPos2ivMESA glWindowPos2ivMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sMESA(Int16 x, Int16 y);
            internal static WindowPos2sMESA glWindowPos2sMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svMESA(Int16* v);
            internal unsafe static WindowPos2svMESA glWindowPos2svMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dMESA(Double x, Double y, Double z);
            internal static WindowPos3dMESA glWindowPos3dMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvMESA(Double* v);
            internal unsafe static WindowPos3dvMESA glWindowPos3dvMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fMESA(Single x, Single y, Single z);
            internal static WindowPos3fMESA glWindowPos3fMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvMESA(Single* v);
            internal unsafe static WindowPos3fvMESA glWindowPos3fvMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iMESA(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3iMESA glWindowPos3iMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivMESA(Int32* v);
            internal unsafe static WindowPos3ivMESA glWindowPos3ivMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sMESA(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3sMESA glWindowPos3sMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svMESA(Int16* v);
            internal unsafe static WindowPos3svMESA glWindowPos3svMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4dMESA(Double x, Double y, Double z, Double w);
            internal static WindowPos4dMESA glWindowPos4dMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4dvMESA(Double* v);
            internal unsafe static WindowPos4dvMESA glWindowPos4dvMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4fMESA(Single x, Single y, Single z, Single w);
            internal static WindowPos4fMESA glWindowPos4fMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4fvMESA(Single* v);
            internal unsafe static WindowPos4fvMESA glWindowPos4fvMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static WindowPos4iMESA glWindowPos4iMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4ivMESA(Int32* v);
            internal unsafe static WindowPos4ivMESA glWindowPos4ivMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static WindowPos4sMESA glWindowPos4sMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4svMESA(Int16* v);
            internal unsafe static WindowPos4svMESA glWindowPos4svMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
            internal unsafe static MultiModeDrawArraysIBM glMultiModeDrawArraysIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, Int32* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, Int32 primcount, Int32 modestride);
            internal unsafe static MultiModeDrawElementsIBM glMultiModeDrawElementsIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorPointerListIBM(Int32 size, GL.Enums.ColorPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
            internal unsafe static ColorPointerListIBM glColorPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColorPointerListIBM(Int32 size, GL.Enums.IBM_vertex_array_lists type, Int32 stride, void* pointer, Int32 ptrstride);
            internal unsafe static SecondaryColorPointerListIBM glSecondaryColorPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerListIBM(Int32 stride, Boolean* pointer, Int32 ptrstride);
            internal unsafe static EdgeFlagPointerListIBM glEdgeFlagPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordPointerListIBM(GL.Enums.IBM_vertex_array_lists type, Int32 stride, void* pointer, Int32 ptrstride);
            internal unsafe static FogCoordPointerListIBM glFogCoordPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void IndexPointerListIBM(GL.Enums.IndexPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
            internal unsafe static IndexPointerListIBM glIndexPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalPointerListIBM(GL.Enums.NormalPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
            internal unsafe static NormalPointerListIBM glNormalPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordPointerListIBM(Int32 size, GL.Enums.TexCoordPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
            internal unsafe static TexCoordPointerListIBM glTexCoordPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexPointerListIBM(Int32 size, GL.Enums.VertexPointerType type, Int32 stride, void* pointer, Int32 ptrstride);
            internal unsafe static VertexPointerListIBM glVertexPointerListIBM = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TbufferMask3DFX(UInt32 mask);
            internal static TbufferMask3DFX glTbufferMask3DFX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskEXT(Single value, GL.Enums.Boolean invert);
            internal static SampleMaskEXT glSampleMaskEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternEXT(GL.Enums.EXT_multisample pattern);
            internal static SamplePatternEXT glSamplePatternEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureColorMaskSGIS(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
            internal static TextureColorMaskSGIS glTextureColorMaskSGIS = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void IglooInterfaceSGIX(GL.Enums.All pname, void* @params);
            internal unsafe static IglooInterfaceSGIX glIglooInterfaceSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesNV(Int32 n, [Out] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, GL.Enums.NV_fence pname, [Out] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceNV(UInt32 fence, GL.Enums.NV_fence condition);
            internal static SetFenceNV glSetFenceNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapControlPointsNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, GL.Enums.Boolean packed, void* points);
            internal unsafe static MapControlPointsNV glMapControlPointsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, Int32* @params);
            internal unsafe static MapParameterivNV glMapParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, Single* @params);
            internal unsafe static MapParameterfvNV glMapParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapControlPointsNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators type, Int32 ustride, Int32 vstride, GL.Enums.Boolean packed, [Out] void* points);
            internal unsafe static GetMapControlPointsNV glGetMapControlPointsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, [Out] Int32* @params);
            internal unsafe static GetMapParameterivNV glGetMapParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, [Out] Single* @params);
            internal unsafe static GetMapParameterfvNV glGetMapParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterivNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators pname, [Out] Int32* @params);
            internal unsafe static GetMapAttribParameterivNV glGetMapAttribParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterfvNV(GL.Enums.NV_evaluators target, UInt32 index, GL.Enums.NV_evaluators pname, [Out] Single* @params);
            internal unsafe static GetMapAttribParameterfvNV glGetMapAttribParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMapsNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators mode);
            internal static EvalMapsNV glEvalMapsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, Single* @params);
            internal unsafe static CombinerStageParameterfvNV glCombinerStageParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, [Out] Single* @params);
            internal unsafe static GetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean AreProgramsResidentNV(Int32 n, UInt32* programs, [Out] GL.Enums.Boolean* residences);
            internal unsafe static AreProgramsResidentNV glAreProgramsResidentNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramNV(GL.Enums.NV_vertex_program target, UInt32 id);
            internal static BindProgramNV glBindProgramNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsNV(Int32 n, UInt32* programs);
            internal unsafe static DeleteProgramsNV glDeleteProgramsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExecuteProgramNV(GL.Enums.NV_vertex_program target, UInt32 id, Single* @params);
            internal unsafe static ExecuteProgramNV glExecuteProgramNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsNV(Int32 n, [Out] UInt32* programs);
            internal unsafe static GenProgramsNV glGenProgramsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterdvNV(GL.Enums.NV_vertex_program target, UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Double* @params);
            internal unsafe static GetProgramParameterdvNV glGetProgramParameterdvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterfvNV(GL.Enums.NV_vertex_program target, UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Single* @params);
            internal unsafe static GetProgramParameterfvNV glGetProgramParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivNV(UInt32 id, GL.Enums.NV_vertex_program pname, [Out] Int32* @params);
            internal unsafe static GetProgramivNV glGetProgramivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStringNV(UInt32 id, GL.Enums.NV_vertex_program pname, [Out] Byte* program);
            internal unsafe static GetProgramStringNV glGetProgramStringNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTrackMatrixivNV(GL.Enums.NV_vertex_program target, UInt32 address, GL.Enums.NV_vertex_program pname, [Out] Int32* @params);
            internal unsafe static GetTrackMatrixivNV glGetTrackMatrixivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Double* @params);
            internal unsafe static GetVertexAttribdvNV glGetVertexAttribdvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribfvNV glGetVertexAttribfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribivNV glGetVertexAttribivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribPointervNV(UInt32 index, GL.Enums.NV_vertex_program pname, [Out] void* pointer);
            internal unsafe static GetVertexAttribPointervNV glGetVertexAttribPointervNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsProgramNV(UInt32 id);
            internal static IsProgramNV glIsProgramNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadProgramNV(GL.Enums.NV_vertex_program target, UInt32 id, Int32 len, Byte* program);
            internal unsafe static LoadProgramNV glLoadProgramNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4dNV(GL.Enums.NV_vertex_program target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramParameter4dNV glProgramParameter4dNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4dvNV(GL.Enums.NV_vertex_program target, UInt32 index, Double* v);
            internal unsafe static ProgramParameter4dvNV glProgramParameter4dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4fNV(GL.Enums.NV_vertex_program target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramParameter4fNV glProgramParameter4fNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4fvNV(GL.Enums.NV_vertex_program target, UInt32 index, Single* v);
            internal unsafe static ProgramParameter4fvNV glProgramParameter4fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4dvNV(GL.Enums.NV_vertex_program target, UInt32 index, UInt32 count, Double* v);
            internal unsafe static ProgramParameters4dvNV glProgramParameters4dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4fvNV(GL.Enums.NV_vertex_program target, UInt32 index, UInt32 count, Single* v);
            internal unsafe static ProgramParameters4fvNV glProgramParameters4fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RequestResidentProgramsNV(Int32 n, UInt32* programs);
            internal unsafe static RequestResidentProgramsNV glRequestResidentProgramsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TrackMatrixNV(GL.Enums.NV_vertex_program target, UInt32 address, GL.Enums.NV_vertex_program matrix, GL.Enums.NV_vertex_program transform);
            internal static TrackMatrixNV glTrackMatrixNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribPointerNV(UInt32 index, Int32 fsize, GL.Enums.NV_vertex_program type, Int32 stride, void* pointer);
            internal unsafe static VertexAttribPointerNV glVertexAttribPointerNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dNV(UInt32 index, Double x);
            internal static VertexAttrib1dNV glVertexAttrib1dNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dvNV glVertexAttrib1dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fNV(UInt32 index, Single x);
            internal static VertexAttrib1fNV glVertexAttrib1fNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fvNV glVertexAttrib1fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sNV(UInt32 index, Int16 x);
            internal static VertexAttrib1sNV glVertexAttrib1sNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1svNV glVertexAttrib1svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dNV(UInt32 index, Double x, Double y);
            internal static VertexAttrib2dNV glVertexAttrib2dNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dvNV glVertexAttrib2dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fNV(UInt32 index, Single x, Single y);
            internal static VertexAttrib2fNV glVertexAttrib2fNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fvNV glVertexAttrib2fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2sNV glVertexAttrib2sNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2svNV glVertexAttrib2svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dNV(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3dNV glVertexAttrib3dNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dvNV glVertexAttrib3dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fNV(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3fNV glVertexAttrib3fNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fvNV glVertexAttrib3fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3sNV glVertexAttrib3sNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3svNV glVertexAttrib3svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dNV(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4dNV glVertexAttrib4dNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dvNV glVertexAttrib4dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fNV(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4fNV glVertexAttrib4fNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fvNV glVertexAttrib4fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4sNV glVertexAttrib4sNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4svNV glVertexAttrib4svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4ubNV(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4ubNV glVertexAttrib4ubNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvNV(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubvNV glVertexAttrib4ubvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs1dvNV glVertexAttribs1dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs1fvNV glVertexAttribs1fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs1svNV glVertexAttribs1svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs2dvNV glVertexAttribs2dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs2fvNV glVertexAttribs2fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs2svNV glVertexAttribs2svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs3dvNV glVertexAttribs3dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs3fvNV glVertexAttribs3fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs3svNV glVertexAttribs3svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs4dvNV glVertexAttribs4dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs4fvNV glVertexAttribs4fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs4svNV glVertexAttribs4svNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4ubvNV(UInt32 index, Int32 count, Byte* v);
            internal unsafe static VertexAttribs4ubvNV glVertexAttribs4ubvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, Int32* param);
            internal unsafe static TexBumpParameterivATI glTexBumpParameterivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, Single* param);
            internal unsafe static TexBumpParameterfvATI glTexBumpParameterfvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, [Out] Int32* param);
            internal unsafe static GetTexBumpParameterivATI glGetTexBumpParameterivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, [Out] Single* param);
            internal unsafe static GetTexBumpParameterfvATI glGetTexBumpParameterfvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenFragmentShadersATI(UInt32 range);
            internal static GenFragmentShadersATI glGenFragmentShadersATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragmentShaderATI(UInt32 id);
            internal static BindFragmentShaderATI glBindFragmentShaderATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteFragmentShaderATI(UInt32 id);
            internal static DeleteFragmentShaderATI glDeleteFragmentShaderATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginFragmentShaderATI();
            internal static BeginFragmentShaderATI glBeginFragmentShaderATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndFragmentShaderATI();
            internal static EndFragmentShaderATI glEndFragmentShaderATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PassTexCoordATI(UInt32 dst, UInt32 coord, GL.Enums.ATI_fragment_shader swizzle);
            internal static PassTexCoordATI glPassTexCoordATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMapATI(UInt32 dst, UInt32 interp, GL.Enums.ATI_fragment_shader swizzle);
            internal static SampleMapATI glSampleMapATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            internal static ColorFragmentOp1ATI glColorFragmentOp1ATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            internal static ColorFragmentOp2ATI glColorFragmentOp2ATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            internal static ColorFragmentOp3ATI glColorFragmentOp3ATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            internal static AlphaFragmentOp1ATI glAlphaFragmentOp1ATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            internal static AlphaFragmentOp2ATI glAlphaFragmentOp2ATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            internal static AlphaFragmentOp3ATI glAlphaFragmentOp3ATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetFragmentShaderConstantATI(UInt32 dst, Single* value);
            internal unsafe static SetFragmentShaderConstantATI glSetFragmentShaderConstantATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesiATI(GL.Enums.ATI_pn_triangles pname, Int32 param);
            internal static PNTrianglesiATI glPNTrianglesiATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesfATI(GL.Enums.ATI_pn_triangles pname, Single param);
            internal static PNTrianglesfATI glPNTrianglesfATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 NewObjectBufferATI(Int32 size, void* pointer, GL.Enums.ATI_vertex_array_object usage);
            internal unsafe static NewObjectBufferATI glNewObjectBufferATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsObjectBufferATI(UInt32 buffer);
            internal static IsObjectBufferATI glIsObjectBufferATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, void* pointer, GL.Enums.ATI_vertex_array_object preserve);
            internal unsafe static UpdateObjectBufferATI glUpdateObjectBufferATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferfvATI(UInt32 buffer, GL.Enums.ATI_vertex_array_object pname, [Out] Single* @params);
            internal unsafe static GetObjectBufferfvATI glGetObjectBufferfvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferivATI(UInt32 buffer, GL.Enums.ATI_vertex_array_object pname, [Out] Int32* @params);
            internal unsafe static GetObjectBufferivATI glGetObjectBufferivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FreeObjectBufferATI(UInt32 buffer);
            internal static FreeObjectBufferATI glFreeObjectBufferATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayObjectATI(GL.Enums.EnableCap array, Int32 size, GL.Enums.ATI_vertex_array_object type, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static ArrayObjectATI glArrayObjectATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectfvATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, [Out] Single* @params);
            internal unsafe static GetArrayObjectfvATI glGetArrayObjectfvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectivATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, [Out] Int32* @params);
            internal unsafe static GetArrayObjectivATI glGetArrayObjectivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VariantArrayObjectATI(UInt32 id, GL.Enums.ATI_vertex_array_object type, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static VariantArrayObjectATI glVariantArrayObjectATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectfvATI(UInt32 id, GL.Enums.ATI_vertex_array_object pname, [Out] Single* @params);
            internal unsafe static GetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectivATI(UInt32 id, GL.Enums.ATI_vertex_array_object pname, [Out] Int32* @params);
            internal unsafe static GetVariantArrayObjectivATI glGetVariantArrayObjectivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginVertexShaderEXT();
            internal static BeginVertexShaderEXT glBeginVertexShaderEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndVertexShaderEXT();
            internal static EndVertexShaderEXT glEndVertexShaderEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexShaderEXT(UInt32 id);
            internal static BindVertexShaderEXT glBindVertexShaderEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenVertexShadersEXT(UInt32 range);
            internal static GenVertexShadersEXT glGenVertexShadersEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteVertexShaderEXT(UInt32 id);
            internal static DeleteVertexShaderEXT glDeleteVertexShaderEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp1EXT(GL.Enums.EXT_vertex_shader op, UInt32 res, UInt32 arg1);
            internal static ShaderOp1EXT glShaderOp1EXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp2EXT(GL.Enums.EXT_vertex_shader op, UInt32 res, UInt32 arg1, UInt32 arg2);
            internal static ShaderOp2EXT glShaderOp2EXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp3EXT(GL.Enums.EXT_vertex_shader op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
            internal static ShaderOp3EXT glShaderOp3EXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SwizzleEXT(UInt32 res, UInt32 @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
            internal static SwizzleEXT glSwizzleEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WriteMaskEXT(UInt32 res, UInt32 @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
            internal static WriteMaskEXT glWriteMaskEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            internal static InsertComponentEXT glInsertComponentEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            internal static ExtractComponentEXT glExtractComponentEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenSymbolsEXT(GL.Enums.EXT_vertex_shader datatype, GL.Enums.EXT_vertex_shader storagetype, GL.Enums.EXT_vertex_shader range, UInt32 components);
            internal static GenSymbolsEXT glGenSymbolsEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetInvariantEXT(UInt32 id, GL.Enums.EXT_vertex_shader type, void* addr);
            internal unsafe static SetInvariantEXT glSetInvariantEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetLocalConstantEXT(UInt32 id, GL.Enums.EXT_vertex_shader type, void* addr);
            internal unsafe static SetLocalConstantEXT glSetLocalConstantEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantbvEXT(UInt32 id, SByte* addr);
            internal unsafe static VariantbvEXT glVariantbvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantsvEXT(UInt32 id, Int16* addr);
            internal unsafe static VariantsvEXT glVariantsvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantivEXT(UInt32 id, Int32* addr);
            internal unsafe static VariantivEXT glVariantivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantfvEXT(UInt32 id, Single* addr);
            internal unsafe static VariantfvEXT glVariantfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantdvEXT(UInt32 id, Double* addr);
            internal unsafe static VariantdvEXT glVariantdvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantubvEXT(UInt32 id, Byte* addr);
            internal unsafe static VariantubvEXT glVariantubvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantusvEXT(UInt32 id, UInt16* addr);
            internal unsafe static VariantusvEXT glVariantusvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantuivEXT(UInt32 id, UInt32* addr);
            internal unsafe static VariantuivEXT glVariantuivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantPointerEXT(UInt32 id, GL.Enums.EXT_vertex_shader type, UInt32 stride, void* addr);
            internal unsafe static VariantPointerEXT glVariantPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVariantClientStateEXT(UInt32 id);
            internal static EnableVariantClientStateEXT glEnableVariantClientStateEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVariantClientStateEXT(UInt32 id);
            internal static DisableVariantClientStateEXT glDisableVariantClientStateEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindLightParameterEXT(GL.Enums.LightName light, GL.Enums.LightParameter value);
            internal static BindLightParameterEXT glBindLightParameterEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindMaterialParameterEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter value);
            internal static BindMaterialParameterEXT glBindMaterialParameterEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTexGenParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter value);
            internal static BindTexGenParameterEXT glBindTexGenParameterEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTextureUnitParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.EXT_vertex_shader value);
            internal static BindTextureUnitParameterEXT glBindTextureUnitParameterEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindParameterEXT(GL.Enums.EXT_vertex_shader value);
            internal static BindParameterEXT glBindParameterEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsVariantEnabledEXT(UInt32 id, GL.Enums.EXT_vertex_shader cap);
            internal static IsVariantEnabledEXT glIsVariantEnabledEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantBooleanvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] GL.Enums.Boolean* data);
            internal unsafe static GetVariantBooleanvEXT glGetVariantBooleanvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantIntegervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Int32* data);
            internal unsafe static GetVariantIntegervEXT glGetVariantIntegervEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantFloatvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Single* data);
            internal unsafe static GetVariantFloatvEXT glGetVariantFloatvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantPointervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] void* data);
            internal unsafe static GetVariantPointervEXT glGetVariantPointervEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantBooleanvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] GL.Enums.Boolean* data);
            internal unsafe static GetInvariantBooleanvEXT glGetInvariantBooleanvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantIntegervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Int32* data);
            internal unsafe static GetInvariantIntegervEXT glGetInvariantIntegervEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantFloatvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Single* data);
            internal unsafe static GetInvariantFloatvEXT glGetInvariantFloatvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantBooleanvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] GL.Enums.Boolean* data);
            internal unsafe static GetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantIntegervEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Int32* data);
            internal unsafe static GetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantFloatvEXT(UInt32 id, GL.Enums.EXT_vertex_shader value, [Out] Single* data);
            internal unsafe static GetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1sATI(GL.Enums.ATI_vertex_streams stream, Int16 x);
            internal static VertexStream1sATI glVertexStream1sATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
            internal unsafe static VertexStream1svATI glVertexStream1svATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1iATI(GL.Enums.ATI_vertex_streams stream, Int32 x);
            internal static VertexStream1iATI glVertexStream1iATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
            internal unsafe static VertexStream1ivATI glVertexStream1ivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1fATI(GL.Enums.ATI_vertex_streams stream, Single x);
            internal static VertexStream1fATI glVertexStream1fATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
            internal unsafe static VertexStream1fvATI glVertexStream1fvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1dATI(GL.Enums.ATI_vertex_streams stream, Double x);
            internal static VertexStream1dATI glVertexStream1dATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
            internal unsafe static VertexStream1dvATI glVertexStream1dvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2sATI(GL.Enums.ATI_vertex_streams stream, Int16 x, Int16 y);
            internal static VertexStream2sATI glVertexStream2sATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
            internal unsafe static VertexStream2svATI glVertexStream2svATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2iATI(GL.Enums.ATI_vertex_streams stream, Int32 x, Int32 y);
            internal static VertexStream2iATI glVertexStream2iATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
            internal unsafe static VertexStream2ivATI glVertexStream2ivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2fATI(GL.Enums.ATI_vertex_streams stream, Single x, Single y);
            internal static VertexStream2fATI glVertexStream2fATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
            internal unsafe static VertexStream2fvATI glVertexStream2fvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2dATI(GL.Enums.ATI_vertex_streams stream, Double x, Double y);
            internal static VertexStream2dATI glVertexStream2dATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
            internal unsafe static VertexStream2dvATI glVertexStream2dvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3sATI(GL.Enums.ATI_vertex_streams stream, Int16 x, Int16 y, Int16 z);
            internal static VertexStream3sATI glVertexStream3sATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
            internal unsafe static VertexStream3svATI glVertexStream3svATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3iATI(GL.Enums.ATI_vertex_streams stream, Int32 x, Int32 y, Int32 z);
            internal static VertexStream3iATI glVertexStream3iATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
            internal unsafe static VertexStream3ivATI glVertexStream3ivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3fATI(GL.Enums.ATI_vertex_streams stream, Single x, Single y, Single z);
            internal static VertexStream3fATI glVertexStream3fATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
            internal unsafe static VertexStream3fvATI glVertexStream3fvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3dATI(GL.Enums.ATI_vertex_streams stream, Double x, Double y, Double z);
            internal static VertexStream3dATI glVertexStream3dATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
            internal unsafe static VertexStream3dvATI glVertexStream3dvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4sATI(GL.Enums.ATI_vertex_streams stream, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexStream4sATI glVertexStream4sATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
            internal unsafe static VertexStream4svATI glVertexStream4svATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4iATI(GL.Enums.ATI_vertex_streams stream, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexStream4iATI glVertexStream4iATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
            internal unsafe static VertexStream4ivATI glVertexStream4ivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4fATI(GL.Enums.ATI_vertex_streams stream, Single x, Single y, Single z, Single w);
            internal static VertexStream4fATI glVertexStream4fATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
            internal unsafe static VertexStream4fvATI glVertexStream4fvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4dATI(GL.Enums.ATI_vertex_streams stream, Double x, Double y, Double z, Double w);
            internal static VertexStream4dATI glVertexStream4dATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
            internal unsafe static VertexStream4dvATI glVertexStream4dvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3bATI(GL.Enums.ATI_vertex_streams stream, SByte nx, SByte ny, SByte nz);
            internal static NormalStream3bATI glNormalStream3bATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3bvATI(GL.Enums.ATI_vertex_streams stream, SByte* coords);
            internal unsafe static NormalStream3bvATI glNormalStream3bvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3sATI(GL.Enums.ATI_vertex_streams stream, Int16 nx, Int16 ny, Int16 nz);
            internal static NormalStream3sATI glNormalStream3sATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3svATI(GL.Enums.ATI_vertex_streams stream, Int16* coords);
            internal unsafe static NormalStream3svATI glNormalStream3svATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3iATI(GL.Enums.ATI_vertex_streams stream, Int32 nx, Int32 ny, Int32 nz);
            internal static NormalStream3iATI glNormalStream3iATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3ivATI(GL.Enums.ATI_vertex_streams stream, Int32* coords);
            internal unsafe static NormalStream3ivATI glNormalStream3ivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3fATI(GL.Enums.ATI_vertex_streams stream, Single nx, Single ny, Single nz);
            internal static NormalStream3fATI glNormalStream3fATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3fvATI(GL.Enums.ATI_vertex_streams stream, Single* coords);
            internal unsafe static NormalStream3fvATI glNormalStream3fvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3dATI(GL.Enums.ATI_vertex_streams stream, Double nx, Double ny, Double nz);
            internal static NormalStream3dATI glNormalStream3dATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3dvATI(GL.Enums.ATI_vertex_streams stream, Double* coords);
            internal unsafe static NormalStream3dvATI glNormalStream3dvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveVertexStreamATI(GL.Enums.ATI_vertex_streams stream);
            internal static ClientActiveVertexStreamATI glClientActiveVertexStreamATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnviATI(GL.Enums.ATI_vertex_streams pname, Int32 param);
            internal static VertexBlendEnviATI glVertexBlendEnviATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnvfATI(GL.Enums.ATI_vertex_streams pname, Single param);
            internal static VertexBlendEnvfATI glVertexBlendEnvfATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ElementPointerATI(GL.Enums.ATI_element_array type, void* pointer);
            internal unsafe static ElementPointerATI glElementPointerATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayATI(GL.Enums.BeginMode mode, Int32 count);
            internal static DrawElementArrayATI glDrawElementArrayATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayATI(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 count);
            internal static DrawRangeElementArrayATI glDrawRangeElementArrayATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawMeshArraysSUN(GL.Enums.BeginMode mode, Int32 first, Int32 count, Int32 width);
            internal static DrawMeshArraysSUN glDrawMeshArraysSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenOcclusionQueriesNV(Int32 n, [Out] UInt32* ids);
            internal unsafe static GenOcclusionQueriesNV glGenOcclusionQueriesNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
            internal unsafe static DeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsOcclusionQueryNV(UInt32 id);
            internal static IsOcclusionQueryNV glIsOcclusionQueryNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginOcclusionQueryNV(UInt32 id);
            internal static BeginOcclusionQueryNV glBeginOcclusionQueryNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndOcclusionQueryNV();
            internal static EndOcclusionQueryNV glEndOcclusionQueryNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryivNV(UInt32 id, GL.Enums.NV_occlusion_query pname, [Out] Int32* @params);
            internal unsafe static GetOcclusionQueryivNV glGetOcclusionQueryivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryuivNV(UInt32 id, GL.Enums.NV_occlusion_query pname, [Out] UInt32* @params);
            internal unsafe static GetOcclusionQueryuivNV glGetOcclusionQueryuivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteriNV(GL.Enums.NV_point_sprite pname, Int32 param);
            internal static PointParameteriNV glPointParameteriNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterivNV(GL.Enums.NV_point_sprite pname, Int32* @params);
            internal unsafe static PointParameterivNV glPointParameterivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveStencilFaceEXT(GL.Enums.EXT_stencil_two_side face);
            internal static ActiveStencilFaceEXT glActiveStencilFaceEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ElementPointerAPPLE(GL.Enums.APPLE_element_array type, void* pointer);
            internal unsafe static ElementPointerAPPLE glElementPointerAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayAPPLE(GL.Enums.BeginMode mode, Int32 first, Int32 count);
            internal static DrawElementArrayAPPLE glDrawElementArrayAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
            internal static DrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementArrayAPPLE(GL.Enums.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesAPPLE(Int32 n, [Out] UInt32* fences);
            internal unsafe static GenFencesAPPLE glGenFencesAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesAPPLE(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesAPPLE glDeleteFencesAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceAPPLE(UInt32 fence);
            internal static SetFenceAPPLE glSetFenceAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsFenceAPPLE(UInt32 fence);
            internal static IsFenceAPPLE glIsFenceAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean TestFenceAPPLE(UInt32 fence);
            internal static TestFenceAPPLE glTestFenceAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceAPPLE(UInt32 fence);
            internal static FinishFenceAPPLE glFinishFenceAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean TestObjectAPPLE(GL.Enums.APPLE_fence @object, UInt32 name);
            internal static TestObjectAPPLE glTestObjectAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishObjectAPPLE(GL.Enums.APPLE_fence @object, Int32 name);
            internal static FinishObjectAPPLE glFinishObjectAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArrayAPPLE(UInt32 array);
            internal static BindVertexArrayAPPLE glBindVertexArrayAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArraysAPPLE(Int32 n, [Out] UInt32* arrays);
            internal unsafe static GenVertexArraysAPPLE glGenVertexArraysAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsVertexArrayAPPLE(UInt32 array);
            internal static IsVertexArrayAPPLE glIsVertexArrayAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
            internal unsafe static VertexArrayRangeAPPLE glVertexArrayRangeAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FlushVertexArrayRangeAPPLE(Int32 length, [Out] void* pointer);
            internal unsafe static FlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayParameteriAPPLE(GL.Enums.APPLE_vertex_array_range pname, Int32 param);
            internal static VertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersATI(Int32 n, GL.Enums.ATI_draw_buffers* bufs);
            internal unsafe static DrawBuffersATI glDrawBuffersATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fNV(UInt32 id, Int32 len, Byte* name, Single x, Single y, Single z, Single w);
            internal unsafe static ProgramNamedParameter4fNV glProgramNamedParameter4fNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dNV(UInt32 id, Int32 len, Byte* name, Double x, Double y, Double z, Double w);
            internal unsafe static ProgramNamedParameter4dNV glProgramNamedParameter4dNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fvNV(UInt32 id, Int32 len, Byte* name, Single* v);
            internal unsafe static ProgramNamedParameter4fvNV glProgramNamedParameter4fvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dvNV(UInt32 id, Int32 len, Byte* name, Double* v);
            internal unsafe static ProgramNamedParameter4dvNV glProgramNamedParameter4dvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterfvNV(UInt32 id, Int32 len, Byte* name, [Out] Single* @params);
            internal unsafe static GetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterdvNV(UInt32 id, Int32 len, Byte* name, [Out] Double* @params);
            internal unsafe static GetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2hNV(UInt16 x, UInt16 y);
            internal static Vertex2hNV glVertex2hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2hvNV(UInt16* v);
            internal unsafe static Vertex2hvNV glVertex2hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3hNV(UInt16 x, UInt16 y, UInt16 z);
            internal static Vertex3hNV glVertex3hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3hvNV(UInt16* v);
            internal unsafe static Vertex3hvNV glVertex3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);
            internal static Vertex4hNV glVertex4hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4hvNV(UInt16* v);
            internal unsafe static Vertex4hvNV glVertex4hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);
            internal static Normal3hNV glNormal3hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3hvNV(UInt16* v);
            internal unsafe static Normal3hvNV glNormal3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3hNV(UInt16 red, UInt16 green, UInt16 blue);
            internal static Color3hNV glColor3hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3hvNV(UInt16* v);
            internal unsafe static Color3hvNV glColor3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            internal static Color4hNV glColor4hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4hvNV(UInt16* v);
            internal unsafe static Color4hvNV glColor4hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1hNV(UInt16 s);
            internal static TexCoord1hNV glTexCoord1hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1hvNV(UInt16* v);
            internal unsafe static TexCoord1hvNV glTexCoord1hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2hNV(UInt16 s, UInt16 t);
            internal static TexCoord2hNV glTexCoord2hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2hvNV(UInt16* v);
            internal unsafe static TexCoord2hvNV glTexCoord2hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);
            internal static TexCoord3hNV glTexCoord3hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3hvNV(UInt16* v);
            internal unsafe static TexCoord3hvNV glTexCoord3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);
            internal static TexCoord4hNV glTexCoord4hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4hvNV(UInt16* v);
            internal unsafe static TexCoord4hvNV glTexCoord4hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1hNV(GL.Enums.NV_half_float target, UInt16 s);
            internal static MultiTexCoord1hNV glMultiTexCoord1hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1hvNV(GL.Enums.NV_half_float target, UInt16* v);
            internal unsafe static MultiTexCoord1hvNV glMultiTexCoord1hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2hNV(GL.Enums.NV_half_float target, UInt16 s, UInt16 t);
            internal static MultiTexCoord2hNV glMultiTexCoord2hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2hvNV(GL.Enums.NV_half_float target, UInt16* v);
            internal unsafe static MultiTexCoord2hvNV glMultiTexCoord2hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3hNV(GL.Enums.NV_half_float target, UInt16 s, UInt16 t, UInt16 r);
            internal static MultiTexCoord3hNV glMultiTexCoord3hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3hvNV(GL.Enums.NV_half_float target, UInt16* v);
            internal unsafe static MultiTexCoord3hvNV glMultiTexCoord3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4hNV(GL.Enums.NV_half_float target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);
            internal static MultiTexCoord4hNV glMultiTexCoord4hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4hvNV(GL.Enums.NV_half_float target, UInt16* v);
            internal unsafe static MultiTexCoord4hvNV glMultiTexCoord4hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordhNV(UInt16 fog);
            internal static FogCoordhNV glFogCoordhNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordhvNV(UInt16* fog);
            internal unsafe static FogCoordhvNV glFogCoordhvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3hNV glSecondaryColor3hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3hvNV(UInt16* v);
            internal unsafe static SecondaryColor3hvNV glSecondaryColor3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeighthNV(UInt16 weight);
            internal static VertexWeighthNV glVertexWeighthNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeighthvNV(UInt16* weight);
            internal unsafe static VertexWeighthvNV glVertexWeighthvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1hNV(UInt32 index, UInt16 x);
            internal static VertexAttrib1hNV glVertexAttrib1hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib1hvNV glVertexAttrib1hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);
            internal static VertexAttrib2hNV glVertexAttrib2hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib2hvNV glVertexAttrib2hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);
            internal static VertexAttrib3hNV glVertexAttrib3hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib3hvNV glVertexAttrib3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);
            internal static VertexAttrib4hNV glVertexAttrib4hNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4hvNV glVertexAttrib4hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs1hvNV glVertexAttribs1hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs2hvNV glVertexAttribs2hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs3hvNV glVertexAttribs3hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs4hvNV glVertexAttribs4hvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelDataRangeNV(GL.Enums.NV_pixel_data_range target, Int32 length, [Out] void* pointer);
            internal unsafe static PixelDataRangeNV glPixelDataRangeNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushPixelDataRangeNV(GL.Enums.NV_pixel_data_range target);
            internal static FlushPixelDataRangeNV glFlushPixelDataRangeNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartNV();
            internal static PrimitiveRestartNV glPrimitiveRestartNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartIndexNV(UInt32 index);
            internal static PrimitiveRestartIndexNV glPrimitiveRestartIndexNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapObjectBufferATI(UInt32 buffer);
            internal static MapObjectBufferATI glMapObjectBufferATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UnmapObjectBufferATI(UInt32 buffer);
            internal static UnmapObjectBufferATI glUnmapObjectBufferATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparateATI(GL.Enums.ATI_separate_stencil face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
            internal static StencilOpSeparateATI glStencilOpSeparateATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparateATI(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparateATI glStencilFuncSeparateATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribArrayObjectATI(UInt32 index, Int32 size, GL.Enums.ATI_vertex_attrib_array_object type, GL.Enums.Boolean normalized, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static VertexAttribArrayObjectATI glVertexAttribArrayObjectATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectfvATI(UInt32 index, GL.Enums.ATI_vertex_attrib_array_object pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectivATI(UInt32 index, GL.Enums.ATI_vertex_attrib_array_object pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsEXT(Double zmin, Double zmax);
            internal static DepthBoundsEXT glDepthBoundsEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateEXT(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
            internal static BlendEquationSeparateEXT glBlendEquationSeparateEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsRenderbufferEXT(UInt32 renderbuffer);
            internal static IsRenderbufferEXT glIsRenderbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, UInt32 renderbuffer);
            internal static BindRenderbufferEXT glBindRenderbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffersEXT glDeleteRenderbuffersEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffersEXT(Int32 n, [Out] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffersEXT glGenRenderbuffersEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageEXT glRenderbufferStorageEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object pname, [Out] Int32* @params);
            internal unsafe static GetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsFramebufferEXT(UInt32 framebuffer);
            internal static IsFramebufferEXT glIsFramebufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebufferEXT(GL.Enums.EXT_framebuffer_object target, UInt32 framebuffer);
            internal static BindFramebufferEXT glBindFramebufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffersEXT glDeleteFramebuffersEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffersEXT(Int32 n, [Out] UInt32* framebuffers);
            internal unsafe static GenFramebuffersEXT glGenFramebuffersEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate GL.Enums.All CheckFramebufferStatusEXT(GL.Enums.EXT_framebuffer_object target);
            internal static CheckFramebufferStatusEXT glCheckFramebufferStatusEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture1DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture1DEXT glFramebufferTexture1DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2DEXT glFramebufferTexture2DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3DEXT glFramebufferTexture3DEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbufferEXT glFramebufferRenderbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object pname, [Out] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmapEXT(GL.Enums.EXT_framebuffer_object target);
            internal static GenerateMipmapEXT glGenerateMipmapEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void StringMarkerGREMEDY(Int32 len, void* @string);
            internal unsafe static StringMarkerGREMEDY glStringMarkerGREMEDY = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
            internal static StencilClearTagEXT glStencilClearTagEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, GL.Enums.ClearBufferMask mask, GL.Enums.EXT_framebuffer_blit filter);
            internal static BlitFramebufferEXT glBlitFramebufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleEXT(GL.Enums.EXT_framebuffer_multisample target, Int32 samples, GL.Enums.EXT_framebuffer_multisample internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, GL.Enums.EXT_timer_query pname, [Out] Int64* @params);
            internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, GL.Enums.EXT_timer_query pname, [Out] UInt64* @params);
            internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferParameteriAPPLE(GL.Enums.APPLE_flush_buffer_range target, GL.Enums.APPLE_flush_buffer_range pname, Int32 param);
            internal static BufferParameteriAPPLE glBufferParameteriAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRangeAPPLE(GL.Enums.APPLE_flush_buffer_range target, IntPtr offset, IntPtr size);
            internal static FlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4iNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static ProgramLocalParameterI4iNV glProgramLocalParameterI4iNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32* @params);
            internal unsafe static ProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4uiNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static ProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32* @params);
            internal unsafe static ProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4iNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static ProgramEnvParameterI4iNV glProgramEnvParameterI4iNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32* @params);
            internal unsafe static ProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4ivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4uiNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static ProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, UInt32* @params);
            internal unsafe static ProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4uivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] Int32* @params);
            internal unsafe static GetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIuivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] UInt32* @params);
            internal unsafe static GetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] Int32* @params);
            internal unsafe static GetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIuivNV(GL.Enums.NV_gpu_program4 target, UInt32 index, [Out] UInt32* @params);
            internal unsafe static GetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramVertexLimitNV(GL.Enums.NV_geometry_program4 target, Int32 limit);
            internal static ProgramVertexLimitNV glProgramVertexLimitNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, UInt32 texture, Int32 level);
            internal static FramebufferTextureEXT glFramebufferTextureEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayerEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayerEXT glFramebufferTextureLayerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureFaceEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, UInt32 texture, Int32 level, GL.Enums.TextureTarget face);
            internal static FramebufferTextureFaceEXT glFramebufferTextureFaceEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriEXT(UInt32 program, GL.Enums.EXT_geometry_shader4 pname, Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1iEXT(UInt32 index, Int32 x);
            internal static VertexAttribI1iEXT glVertexAttribI1iEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
            internal static VertexAttribI2iEXT glVertexAttribI2iEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
            internal static VertexAttribI3iEXT glVertexAttribI3iEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4iEXT glVertexAttribI4iEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1uiEXT(UInt32 index, UInt32 x);
            internal static VertexAttribI1uiEXT glVertexAttribI1uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
            internal static VertexAttribI2uiEXT glVertexAttribI2uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            internal static VertexAttribI3uiEXT glVertexAttribI3uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4uiEXT glVertexAttribI4uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI1ivEXT glVertexAttribI1ivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI2ivEXT glVertexAttribI2ivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI3ivEXT glVertexAttribI3ivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4ivEXT glVertexAttribI4ivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI1uivEXT glVertexAttribI1uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI2uivEXT glVertexAttribI2uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI3uivEXT glVertexAttribI3uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uivEXT glVertexAttribI4uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4bvEXT(UInt32 index, SByte* v);
            internal unsafe static VertexAttribI4bvEXT glVertexAttribI4bvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4svEXT(UInt32 index, Int16* v);
            internal unsafe static VertexAttribI4svEXT glVertexAttribI4svEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ubvEXT(UInt32 index, Byte* v);
            internal unsafe static VertexAttribI4ubvEXT glVertexAttribI4ubvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4usvEXT(UInt32 index, UInt16* v);
            internal unsafe static VertexAttribI4usvEXT glVertexAttribI4usvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribIPointerEXT(UInt32 index, Int32 size, GL.Enums.NV_vertex_program4 type, Int32 stride, void* pointer);
            internal unsafe static VertexAttribIPointerEXT glVertexAttribIPointerEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIivEXT(UInt32 index, GL.Enums.NV_vertex_program4 pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribIivEXT glGetVertexAttribIivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuivEXT(UInt32 index, GL.Enums.NV_vertex_program4 pname, [Out] UInt32* @params);
            internal unsafe static GetVertexAttribIuivEXT glGetVertexAttribIuivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformuivEXT(UInt32 program, Int32 location, [Out] UInt32* @params);
            internal unsafe static GetUniformuivEXT glGetUniformuivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocationEXT(UInt32 program, UInt32 color, System.String name);
            internal static BindFragDataLocationEXT glBindFragDataLocationEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocationEXT(UInt32 program, System.String name);
            internal static GetFragDataLocationEXT glGetFragDataLocationEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1uiEXT(Int32 location, UInt32 v0);
            internal static Uniform1uiEXT glUniform1uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2uiEXT glUniform2uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3uiEXT glUniform3uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4uiEXT glUniform4uiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uivEXT glUniform1uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uivEXT glUniform2uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uivEXT glUniform3uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uivEXT glUniform4uivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedEXT(GL.Enums.BeginMode mode, Int32 start, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawElementsInstancedEXT(GL.Enums.BeginMode mode, Int32 count, GL.Enums.EXT_draw_instanced type, void* indices, Int32 primcount);
            internal unsafe static DrawElementsInstancedEXT glDrawElementsInstancedEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBufferEXT(GL.Enums.TextureTarget target, GL.Enums.EXT_texture_buffer_object internalformat, UInt32 buffer);
            internal static TexBufferEXT glTexBufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangedNV(Double zNear, Double zFar);
            internal static DepthRangedNV glDepthRangedNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthdNV(Double depth);
            internal static ClearDepthdNV glClearDepthdNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsdNV(Double zmin, Double zmax);
            internal static DepthBoundsdNV glDepthBoundsdNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleCoverageNV(GL.Enums.NV_framebuffer_multisample_coverage target, Int32 coverageSamples, Int32 colorSamples, GL.Enums.PixelInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersfvNV(GL.Enums.NV_parameter_buffer_object target, UInt32 buffer, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramBufferParametersfvNV glProgramBufferParametersfvNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIivNV(GL.Enums.NV_parameter_buffer_object target, UInt32 buffer, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramBufferParametersIivNV glProgramBufferParametersIivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIuivNV(GL.Enums.NV_parameter_buffer_object target, UInt32 buffer, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramBufferParametersIuivNV glProgramBufferParametersIuivNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaskIndexedEXT(UInt32 index, GL.Enums.Boolean r, GL.Enums.Boolean g, GL.Enums.Boolean b, GL.Enums.Boolean a);
            internal static ColorMaskIndexedEXT glColorMaskIndexedEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanIndexedvEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index, [Out] GL.Enums.Boolean* data);
            internal unsafe static GetBooleanIndexedvEXT glGetBooleanIndexedvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerIndexedvEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index, [Out] Int32* data);
            internal unsafe static GetIntegerIndexedvEXT glGetIntegerIndexedvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableIndexedEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index);
            internal static EnableIndexedEXT glEnableIndexedEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableIndexedEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index);
            internal static DisableIndexedEXT glDisableIndexedEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsEnabledIndexedEXT(GL.Enums.EXT_draw_buffers2 target, UInt32 index);
            internal static IsEnabledIndexedEXT glIsEnabledIndexedEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedbackNV(GL.Enums.NV_transform_feedback primitiveMode);
            internal static BeginTransformFeedbackNV glBeginTransformFeedbackNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedbackNV();
            internal static EndTransformFeedbackNV glEndTransformFeedbackNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackAttribsNV(UInt32 count, Int32* attribs, GL.Enums.NV_transform_feedback bufferMode);
            internal unsafe static TransformFeedbackAttribsNV glTransformFeedbackAttribsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRangeNV(GL.Enums.NV_transform_feedback target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRangeNV glBindBufferRangeNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferOffsetNV(GL.Enums.NV_transform_feedback target, UInt32 index, UInt32 buffer, IntPtr offset);
            internal static BindBufferOffsetNV glBindBufferOffsetNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBaseNV(GL.Enums.NV_transform_feedback target, UInt32 index, UInt32 buffer);
            internal static BindBufferBaseNV glBindBufferBaseNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, GL.Enums.NV_transform_feedback bufferMode);
            internal unsafe static TransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveVaryingNV(UInt32 program, System.String name);
            internal static ActiveVaryingNV glActiveVaryingNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetVaryingLocationNV(UInt32 program, System.String name);
            internal static GetVaryingLocationNV glGetVaryingLocationNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] GL.Enums.NV_transform_feedback* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveVaryingNV glGetActiveVaryingNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, [Out] Int32* location);
            internal unsafe static GetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
            internal static UniformBufferEXT glUniformBufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location);
            internal static GetUniformBufferSizeEXT glGetUniformBufferSizeEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location);
            internal static GetUniformOffsetEXT glGetUniformOffsetEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameterIivEXT glTexParameterIivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, UInt32* @params);
            internal unsafe static TexParameterIuivEXT glTexParameterIuivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] Int32* @params);
            internal unsafe static GetTexParameterIivEXT glGetTexParameterIivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, [Out] UInt32* @params);
            internal unsafe static GetTexParameterIuivEXT glGetTexParameterIuivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static ClearColorIiEXT glClearColorIiEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            internal static ClearColorIuiEXT glClearColorIuiEXT = null;
        }
    }
}
