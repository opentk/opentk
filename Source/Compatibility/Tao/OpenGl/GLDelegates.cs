#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

namespace Tao.OpenGl
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649

    partial class Gl
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NewList(UInt32 list, int mode);
            internal static NewList glNewList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndList();
            internal static EndList glEndList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CallList(UInt32 list);
            internal static CallList glCallList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CallLists(Int32 n, int type, IntPtr lists);
            internal static CallLists glCallLists;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteLists(UInt32 list, Int32 range);
            internal static DeleteLists glDeleteLists;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenLists(Int32 range);
            internal static GenLists glGenLists;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListBase(UInt32 @base);
            internal static ListBase glListBase;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Begin(int mode);
            internal static Begin glBegin;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
            internal unsafe static Bitmap glBitmap;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3b(SByte red, SByte green, SByte blue);
            internal static Color3b glColor3b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3bv(SByte* v);
            internal unsafe static Color3bv glColor3bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3d(Double red, Double green, Double blue);
            internal static Color3d glColor3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3dv(Double* v);
            internal unsafe static Color3dv glColor3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3f(Single red, Single green, Single blue);
            internal static Color3f glColor3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fv(Single* v);
            internal unsafe static Color3fv glColor3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3i(Int32 red, Int32 green, Int32 blue);
            internal static Color3i glColor3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3iv(Int32* v);
            internal unsafe static Color3iv glColor3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3s(Int16 red, Int16 green, Int16 blue);
            internal static Color3s glColor3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3sv(Int16* v);
            internal unsafe static Color3sv glColor3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ub(Byte red, Byte green, Byte blue);
            internal static Color3ub glColor3ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3ubv(Byte* v);
            internal unsafe static Color3ubv glColor3ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
            internal static Color3ui glColor3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3uiv(UInt32* v);
            internal unsafe static Color3uiv glColor3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3us(UInt16 red, UInt16 green, UInt16 blue);
            internal static Color3us glColor3us;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3usv(UInt16* v);
            internal unsafe static Color3usv glColor3usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
            internal static Color4b glColor4b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4bv(SByte* v);
            internal unsafe static Color4bv glColor4bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4d(Double red, Double green, Double blue, Double alpha);
            internal static Color4d glColor4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4dv(Double* v);
            internal unsafe static Color4dv glColor4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
            internal static Color4f glColor4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fv(Single* v);
            internal unsafe static Color4fv glColor4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static Color4i glColor4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4iv(Int32* v);
            internal unsafe static Color4iv glColor4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
            internal static Color4s glColor4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4sv(Int16* v);
            internal unsafe static Color4sv glColor4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            internal static Color4ub glColor4ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubv(Byte* v);
            internal unsafe static Color4ubv glColor4ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            internal static Color4ui glColor4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4uiv(UInt32* v);
            internal unsafe static Color4uiv glColor4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            internal static Color4us glColor4us;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4usv(UInt16* v);
            internal unsafe static Color4usv glColor4usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlag(Int32 flag);
            internal static EdgeFlag glEdgeFlag;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagv(Int32* flag);
            internal unsafe static EdgeFlagv glEdgeFlagv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void End();
            internal static End glEnd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexd(Double c);
            internal static Indexd glIndexd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexdv(Double* c);
            internal unsafe static Indexdv glIndexdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexf(Single c);
            internal static Indexf glIndexf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexfv(Single* c);
            internal unsafe static Indexfv glIndexfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexi(Int32 c);
            internal static Indexi glIndexi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexiv(Int32* c);
            internal unsafe static Indexiv glIndexiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexs(Int16 c);
            internal static Indexs glIndexs;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexsv(Int16* c);
            internal unsafe static Indexsv glIndexsv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3b(SByte nx, SByte ny, SByte nz);
            internal static Normal3b glNormal3b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3bv(SByte* v);
            internal unsafe static Normal3bv glNormal3bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3d(Double nx, Double ny, Double nz);
            internal static Normal3d glNormal3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3dv(Double* v);
            internal unsafe static Normal3dv glNormal3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3f(Single nx, Single ny, Single nz);
            internal static Normal3f glNormal3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fv(Single* v);
            internal unsafe static Normal3fv glNormal3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3i(Int32 nx, Int32 ny, Int32 nz);
            internal static Normal3i glNormal3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3iv(Int32* v);
            internal unsafe static Normal3iv glNormal3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3s(Int16 nx, Int16 ny, Int16 nz);
            internal static Normal3s glNormal3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3sv(Int16* v);
            internal unsafe static Normal3sv glNormal3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2d(Double x, Double y);
            internal static RasterPos2d glRasterPos2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2dv(Double* v);
            internal unsafe static RasterPos2dv glRasterPos2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2f(Single x, Single y);
            internal static RasterPos2f glRasterPos2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2fv(Single* v);
            internal unsafe static RasterPos2fv glRasterPos2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2i(Int32 x, Int32 y);
            internal static RasterPos2i glRasterPos2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2iv(Int32* v);
            internal unsafe static RasterPos2iv glRasterPos2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2s(Int16 x, Int16 y);
            internal static RasterPos2s glRasterPos2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2sv(Int16* v);
            internal unsafe static RasterPos2sv glRasterPos2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3d(Double x, Double y, Double z);
            internal static RasterPos3d glRasterPos3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3dv(Double* v);
            internal unsafe static RasterPos3dv glRasterPos3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3f(Single x, Single y, Single z);
            internal static RasterPos3f glRasterPos3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3fv(Single* v);
            internal unsafe static RasterPos3fv glRasterPos3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3i(Int32 x, Int32 y, Int32 z);
            internal static RasterPos3i glRasterPos3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3iv(Int32* v);
            internal unsafe static RasterPos3iv glRasterPos3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3s(Int16 x, Int16 y, Int16 z);
            internal static RasterPos3s glRasterPos3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3sv(Int16* v);
            internal unsafe static RasterPos3sv glRasterPos3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4d(Double x, Double y, Double z, Double w);
            internal static RasterPos4d glRasterPos4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4dv(Double* v);
            internal unsafe static RasterPos4dv glRasterPos4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4f(Single x, Single y, Single z, Single w);
            internal static RasterPos4f glRasterPos4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4fv(Single* v);
            internal unsafe static RasterPos4fv glRasterPos4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static RasterPos4i glRasterPos4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4iv(Int32* v);
            internal unsafe static RasterPos4iv glRasterPos4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static RasterPos4s glRasterPos4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4sv(Int16* v);
            internal unsafe static RasterPos4sv glRasterPos4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectd(Double x1, Double y1, Double x2, Double y2);
            internal static Rectd glRectd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectdv(Double* v1, Double* v2);
            internal unsafe static Rectdv glRectdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectf(Single x1, Single y1, Single x2, Single y2);
            internal static Rectf glRectf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectfv(Single* v1, Single* v2);
            internal unsafe static Rectfv glRectfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
            internal static Recti glRecti;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectiv(Int32* v1, Int32* v2);
            internal unsafe static Rectiv glRectiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
            internal static Rects glRects;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectsv(Int16* v1, Int16* v2);
            internal unsafe static Rectsv glRectsv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1d(Double s);
            internal static TexCoord1d glTexCoord1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1dv(Double* v);
            internal unsafe static TexCoord1dv glTexCoord1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1f(Single s);
            internal static TexCoord1f glTexCoord1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1fv(Single* v);
            internal unsafe static TexCoord1fv glTexCoord1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1i(Int32 s);
            internal static TexCoord1i glTexCoord1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1iv(Int32* v);
            internal unsafe static TexCoord1iv glTexCoord1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1s(Int16 s);
            internal static TexCoord1s glTexCoord1s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1sv(Int16* v);
            internal unsafe static TexCoord1sv glTexCoord1sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2d(Double s, Double t);
            internal static TexCoord2d glTexCoord2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2dv(Double* v);
            internal unsafe static TexCoord2dv glTexCoord2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2f(Single s, Single t);
            internal static TexCoord2f glTexCoord2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fv(Single* v);
            internal unsafe static TexCoord2fv glTexCoord2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2i(Int32 s, Int32 t);
            internal static TexCoord2i glTexCoord2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2iv(Int32* v);
            internal unsafe static TexCoord2iv glTexCoord2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2s(Int16 s, Int16 t);
            internal static TexCoord2s glTexCoord2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2sv(Int16* v);
            internal unsafe static TexCoord2sv glTexCoord2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3d(Double s, Double t, Double r);
            internal static TexCoord3d glTexCoord3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3dv(Double* v);
            internal unsafe static TexCoord3dv glTexCoord3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3f(Single s, Single t, Single r);
            internal static TexCoord3f glTexCoord3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3fv(Single* v);
            internal unsafe static TexCoord3fv glTexCoord3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3i(Int32 s, Int32 t, Int32 r);
            internal static TexCoord3i glTexCoord3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3iv(Int32* v);
            internal unsafe static TexCoord3iv glTexCoord3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3s(Int16 s, Int16 t, Int16 r);
            internal static TexCoord3s glTexCoord3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3sv(Int16* v);
            internal unsafe static TexCoord3sv glTexCoord3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4d(Double s, Double t, Double r, Double q);
            internal static TexCoord4d glTexCoord4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4dv(Double* v);
            internal unsafe static TexCoord4dv glTexCoord4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4f(Single s, Single t, Single r, Single q);
            internal static TexCoord4f glTexCoord4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fv(Single* v);
            internal unsafe static TexCoord4fv glTexCoord4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
            internal static TexCoord4i glTexCoord4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4iv(Int32* v);
            internal unsafe static TexCoord4iv glTexCoord4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
            internal static TexCoord4s glTexCoord4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4sv(Int16* v);
            internal unsafe static TexCoord4sv glTexCoord4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2d(Double x, Double y);
            internal static Vertex2d glVertex2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2dv(Double* v);
            internal unsafe static Vertex2dv glVertex2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2f(Single x, Single y);
            internal static Vertex2f glVertex2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2fv(Single* v);
            internal unsafe static Vertex2fv glVertex2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2i(Int32 x, Int32 y);
            internal static Vertex2i glVertex2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2iv(Int32* v);
            internal unsafe static Vertex2iv glVertex2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2s(Int16 x, Int16 y);
            internal static Vertex2s glVertex2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2sv(Int16* v);
            internal unsafe static Vertex2sv glVertex2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3d(Double x, Double y, Double z);
            internal static Vertex3d glVertex3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3dv(Double* v);
            internal unsafe static Vertex3dv glVertex3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3f(Single x, Single y, Single z);
            internal static Vertex3f glVertex3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3fv(Single* v);
            internal unsafe static Vertex3fv glVertex3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3i(Int32 x, Int32 y, Int32 z);
            internal static Vertex3i glVertex3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3iv(Int32* v);
            internal unsafe static Vertex3iv glVertex3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3s(Int16 x, Int16 y, Int16 z);
            internal static Vertex3s glVertex3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3sv(Int16* v);
            internal unsafe static Vertex3sv glVertex3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4d(Double x, Double y, Double z, Double w);
            internal static Vertex4d glVertex4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4dv(Double* v);
            internal unsafe static Vertex4dv glVertex4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4f(Single x, Single y, Single z, Single w);
            internal static Vertex4f glVertex4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4fv(Single* v);
            internal unsafe static Vertex4fv glVertex4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static Vertex4i glVertex4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4iv(Int32* v);
            internal unsafe static Vertex4iv glVertex4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static Vertex4s glVertex4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4sv(Int16* v);
            internal unsafe static Vertex4sv glVertex4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlane(int plane, Double* equation);
            internal unsafe static ClipPlane glClipPlane;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaterial(int face, int mode);
            internal static ColorMaterial glColorMaterial;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(int mode);
            internal static CullFace glCullFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogf(int pname, Single param);
            internal static Fogf glFogf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogfv(int pname, Single* @params);
            internal unsafe static Fogfv glFogfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogi(int pname, Int32 param);
            internal static Fogi glFogi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogiv(int pname, Int32* @params);
            internal unsafe static Fogiv glFogiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(int mode);
            internal static FrontFace glFrontFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(int target, int mode);
            internal static Hint glHint;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lightf(int light, int pname, Single param);
            internal static Lightf glLightf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightfv(int light, int pname, Single* @params);
            internal unsafe static Lightfv glLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lighti(int light, int pname, Int32 param);
            internal static Lighti glLighti;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightiv(int light, int pname, Int32* @params);
            internal unsafe static Lightiv glLightiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelf(int pname, Single param);
            internal static LightModelf glLightModelf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelfv(int pname, Single* @params);
            internal unsafe static LightModelfv glLightModelfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModeli(int pname, Int32 param);
            internal static LightModeli glLightModeli;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModeliv(int pname, Int32* @params);
            internal unsafe static LightModeliv glLightModeliv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineStipple(Int32 factor, UInt16 pattern);
            internal static LineStipple glLineStipple;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialf(int face, int pname, Single param);
            internal static Materialf glMaterialf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialfv(int face, int pname, Single* @params);
            internal unsafe static Materialfv glMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materiali(int face, int pname, Int32 param);
            internal static Materiali glMateriali;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialiv(int face, int pname, Int32* @params);
            internal unsafe static Materialiv glMaterialiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonMode(int face, int mode);
            internal static PolygonMode glPolygonMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PolygonStipple(Byte* mask);
            internal unsafe static PolygonStipple glPolygonStipple;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShadeModel(int mode);
            internal static ShadeModel glShadeModel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(int target, int pname, Single param);
            internal static TexParameterf glTexParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(int target, int pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(int target, int pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(int target, int pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels);
            internal static TexImage1D glTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvf(int target, int pname, Single param);
            internal static TexEnvf glTexEnvf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvfv(int target, int pname, Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvi(int target, int pname, Int32 param);
            internal static TexEnvi glTexEnvi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnviv(int target, int pname, Int32* @params);
            internal unsafe static TexEnviv glTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGend(int coord, int pname, Double param);
            internal static TexGend glTexGend;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGendv(int coord, int pname, Double* @params);
            internal unsafe static TexGendv glTexGendv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGenf(int coord, int pname, Single param);
            internal static TexGenf glTexGenf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGenfv(int coord, int pname, Single* @params);
            internal unsafe static TexGenfv glTexGenfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGeni(int coord, int pname, Int32 param);
            internal static TexGeni glTexGeni;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGeniv(int coord, int pname, Int32* @params);
            internal unsafe static TexGeniv glTexGeniv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FeedbackBuffer(Int32 size, int type, [Out] Single* buffer);
            internal unsafe static FeedbackBuffer glFeedbackBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SelectBuffer(Int32 size, [Out] UInt32* buffer);
            internal unsafe static SelectBuffer glSelectBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 RenderMode(int mode);
            internal static RenderMode glRenderMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InitNames();
            internal static InitNames glInitNames;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadName(UInt32 name);
            internal static LoadName glLoadName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PassThrough(Single token);
            internal static PassThrough glPassThrough;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopName();
            internal static PopName glPopName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushName(UInt32 name);
            internal static PushName glPushName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawBuffer(int mode);
            internal static DrawBuffer glDrawBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(int mask);
            internal static Clear glClear;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearAccum(Single red, Single green, Single blue, Single alpha);
            internal static ClearAccum glClearAccum;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearIndex(Single c);
            internal static ClearIndex glClearIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepth(Double depth);
            internal static ClearDepth glClearDepth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static ColorMask glColorMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(Int32 flag);
            internal static DepthMask glDepthMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMask(UInt32 mask);
            internal static IndexMask glIndexMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Accum(int op, Single value);
            internal static Accum glAccum;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(int cap);
            internal static Disable glDisable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(int cap);
            internal static Enable glEnable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopAttrib();
            internal static PopAttrib glPopAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushAttrib(int mask);
            internal static PushAttrib glPushAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1d(int target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            internal unsafe static Map1d glMap1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1f(int target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            internal unsafe static Map1f glMap1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2d(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            internal unsafe static Map2d glMap2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2f(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            internal unsafe static Map2f glMap2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1d(Int32 un, Double u1, Double u2);
            internal static MapGrid1d glMapGrid1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1f(Int32 un, Single u1, Single u2);
            internal static MapGrid1f glMapGrid1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
            internal static MapGrid2d glMapGrid2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
            internal static MapGrid2f glMapGrid2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1d(Double u);
            internal static EvalCoord1d glEvalCoord1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1dv(Double* u);
            internal unsafe static EvalCoord1dv glEvalCoord1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1f(Single u);
            internal static EvalCoord1f glEvalCoord1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1fv(Single* u);
            internal unsafe static EvalCoord1fv glEvalCoord1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2d(Double u, Double v);
            internal static EvalCoord2d glEvalCoord2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2dv(Double* u);
            internal unsafe static EvalCoord2dv glEvalCoord2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2f(Single u, Single v);
            internal static EvalCoord2f glEvalCoord2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2fv(Single* u);
            internal unsafe static EvalCoord2fv glEvalCoord2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh1(int mode, Int32 i1, Int32 i2);
            internal static EvalMesh1 glEvalMesh1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint1(Int32 i);
            internal static EvalPoint1 glEvalPoint1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
            internal static EvalMesh2 glEvalMesh2;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint2(Int32 i, Int32 j);
            internal static EvalPoint2 glEvalPoint2;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFunc(int func, Single @ref);
            internal static AlphaFunc glAlphaFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(int sfactor, int dfactor);
            internal static BlendFunc glBlendFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LogicOp(int opcode);
            internal static LogicOp glLogicOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(int func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(int fail, int zfail, int zpass);
            internal static StencilOp glStencilOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc(int func);
            internal static DepthFunc glDepthFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelZoom(Single xfactor, Single yfactor);
            internal static PixelZoom glPixelZoom;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferf(int pname, Single param);
            internal static PixelTransferf glPixelTransferf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferi(int pname, Int32 param);
            internal static PixelTransferi glPixelTransferi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStoref(int pname, Single param);
            internal static PixelStoref glPixelStoref;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(int pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapfv(int map, Int32 mapsize, Single* values);
            internal unsafe static PixelMapfv glPixelMapfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapuiv(int map, Int32 mapsize, UInt32* values);
            internal unsafe static PixelMapuiv glPixelMapuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapusv(int map, Int32 mapsize, UInt16* values);
            internal unsafe static PixelMapusv glPixelMapusv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBuffer(int mode);
            internal static ReadBuffer glReadBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type);
            internal static CopyPixels glCopyPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, [Out] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawPixels(Int32 width, Int32 height, int format, int type, IntPtr pixels);
            internal static DrawPixels glDrawPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(int pname, [Out] Int32* @params);
            internal unsafe static GetBooleanv glGetBooleanv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlane(int plane, [Out] Double* equation);
            internal unsafe static GetClipPlane glGetClipPlane;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublev(int pname, [Out] Double* @params);
            internal unsafe static GetDoublev glGetDoublev;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetError();
            internal static GetError glGetError;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(int pname, [Out] Single* @params);
            internal unsafe static GetFloatv glGetFloatv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(int pname, [Out] Int32* @params);
            internal unsafe static GetIntegerv glGetIntegerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightfv(int light, int pname, [Out] Single* @params);
            internal unsafe static GetLightfv glGetLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightiv(int light, int pname, [Out] Int32* @params);
            internal unsafe static GetLightiv glGetLightiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapdv(int target, int query, [Out] Double* v);
            internal unsafe static GetMapdv glGetMapdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapfv(int target, int query, [Out] Single* v);
            internal unsafe static GetMapfv glGetMapfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapiv(int target, int query, [Out] Int32* v);
            internal unsafe static GetMapiv glGetMapiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialfv(int face, int pname, [Out] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialiv(int face, int pname, [Out] Int32* @params);
            internal unsafe static GetMaterialiv glGetMaterialiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapfv(int map, [Out] Single* values);
            internal unsafe static GetPixelMapfv glGetPixelMapfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapuiv(int map, [Out] UInt32* values);
            internal unsafe static GetPixelMapuiv glGetPixelMapuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapusv(int map, [Out] UInt16* values);
            internal unsafe static GetPixelMapusv glGetPixelMapusv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPolygonStipple([Out] Byte* mask);
            internal unsafe static GetPolygonStipple glGetPolygonStipple;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(int name);
            internal static GetString glGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvfv(int target, int pname, [Out] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnviv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGendv(int coord, int pname, [Out] Double* @params);
            internal unsafe static GetTexGendv glGetTexGendv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGenfv(int coord, int pname, [Out] Single* @params);
            internal unsafe static GetTexGenfv glGetTexGenfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGeniv(int coord, int pname, [Out] Int32* @params);
            internal unsafe static GetTexGeniv glGetTexGeniv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTexImage(int target, Int32 level, int format, int type, [Out] IntPtr pixels);
            internal static GetTexImage glGetTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(int target, int pname, [Out] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameterfv(int target, Int32 level, int pname, [Out] Single* @params);
            internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameteriv(int target, Int32 level, int pname, [Out] Int32* @params);
            internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsEnabled(int cap);
            internal static IsEnabled glIsEnabled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsList(UInt32 list);
            internal static IsList glIsList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRange(Double near, Double far);
            internal static DepthRange glDepthRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static Frustum glFrustum;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixf(Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixd(Double* m);
            internal unsafe static LoadMatrixd glLoadMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixMode(int mode);
            internal static MatrixMode glMatrixMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixf(Single* m);
            internal unsafe static MultMatrixf glMultMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixd(Double* m);
            internal unsafe static MultMatrixd glMultMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static Ortho glOrtho;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotated(Double angle, Double x, Double y, Double z);
            internal static Rotated glRotated;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
            internal static Rotatef glRotatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scaled(Double x, Double y, Double z);
            internal static Scaled glScaled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalef(Single x, Single y, Single z);
            internal static Scalef glScalef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translated(Double x, Double y, Double z);
            internal static Translated glTranslated;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatef(Single x, Single y, Single z);
            internal static Translatef glTranslatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElement(Int32 i);
            internal static ArrayElement glArrayElement;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static ColorPointer glColorPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientState(int array);
            internal static DisableClientState glDisableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(int mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements(int mode, Int32 count, int type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlagPointer(Int32 stride, IntPtr pointer);
            internal static EdgeFlagPointer glEdgeFlagPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientState(int array);
            internal static EnableClientState glEnableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerv(int pname, [Out] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointer(int type, Int32 stride, IntPtr pointer);
            internal static IndexPointer glIndexPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InterleavedArrays(int format, Int32 stride, IntPtr pointer);
            internal static InterleavedArrays glInterleavedArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointer(int type, Int32 stride, IntPtr pointer);
            internal static NormalPointer glNormalPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static TexCoordPointer glTexCoordPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static VertexPointer glVertexPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1D glCopyTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1D glCopyTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
            internal static TexSubImage1D glTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 AreTexturesResident(Int32 n, UInt32* textures, [Out] Int32* residences);
            internal unsafe static AreTexturesResident glAreTexturesResident;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(int target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures(Int32 n, [Out] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
            internal unsafe static PrioritizeTextures glPrioritizeTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexub(Byte c);
            internal static Indexub glIndexub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexubv(Byte* c);
            internal unsafe static Indexubv glIndexubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopClientAttrib();
            internal static PopClientAttrib glPopClientAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushClientAttrib(int mask);
            internal static PushClientAttrib glPushClientAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation(int mode);
            internal static BlendEquation glBlendEquation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTable(int target, int internalformat, Int32 width, int format, int type, IntPtr table);
            internal static ColorTable glColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfv(int target, int pname, Single* @params);
            internal unsafe static ColorTableParameterfv glColorTableParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameteriv(int target, int pname, Int32* @params);
            internal unsafe static ColorTableParameteriv glColorTableParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTable(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTable glCopyColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTable(int target, int format, int type, [Out] IntPtr table);
            internal static GetColorTable glGetColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfv(int target, int pname, [Out] Single* @params);
            internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameteriv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorSubTable(int target, Int32 start, Int32 count, int format, int type, IntPtr data);
            internal static ColorSubTable glColorSubTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTable(int target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTable glCopyColorSubTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, IntPtr image);
            internal static ConvolutionFilter1D glConvolutionFilter1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr image);
            internal static ConvolutionFilter2D glConvolutionFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterf(int target, int pname, Single @params);
            internal static ConvolutionParameterf glConvolutionParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfv(int target, int pname, Single* @params);
            internal unsafe static ConvolutionParameterfv glConvolutionParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteri(int target, int pname, Int32 @params);
            internal static ConvolutionParameteri glConvolutionParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameteriv(int target, int pname, Int32* @params);
            internal unsafe static ConvolutionParameteriv glConvolutionParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1D(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2D(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetConvolutionFilter(int target, int format, int type, [Out] IntPtr image);
            internal static GetConvolutionFilter glGetConvolutionFilter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfv(int target, int pname, [Out] Single* @params);
            internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameteriv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetSeparableFilter(int target, int format, int type, [Out] IntPtr row, [Out] IntPtr column, [Out] IntPtr span);
            internal static GetSeparableFilter glGetSeparableFilter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr row, IntPtr column);
            internal static SeparableFilter2D glSeparableFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetHistogram(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            internal static GetHistogram glGetHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfv(int target, int pname, [Out] Single* @params);
            internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameteriv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMinmax(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            internal static GetMinmax glGetMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfv(int target, int pname, [Out] Single* @params);
            internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameteriv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Histogram(int target, Int32 width, int internalformat, Int32 sink);
            internal static Histogram glHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Minmax(int target, int internalformat, Int32 sink);
            internal static Minmax glMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogram(int target);
            internal static ResetHistogram glResetHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmax(int target);
            internal static ResetMinmax glResetMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
            internal static TexImage3D glTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(int texture);
            internal static ActiveTexture glActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTexture(int texture);
            internal static ClientActiveTexture glClientActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1d(int target, Double s);
            internal static MultiTexCoord1d glMultiTexCoord1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dv(int target, Double* v);
            internal unsafe static MultiTexCoord1dv glMultiTexCoord1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1f(int target, Single s);
            internal static MultiTexCoord1f glMultiTexCoord1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fv(int target, Single* v);
            internal unsafe static MultiTexCoord1fv glMultiTexCoord1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1i(int target, Int32 s);
            internal static MultiTexCoord1i glMultiTexCoord1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1iv(int target, Int32* v);
            internal unsafe static MultiTexCoord1iv glMultiTexCoord1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1s(int target, Int16 s);
            internal static MultiTexCoord1s glMultiTexCoord1s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1sv(int target, Int16* v);
            internal unsafe static MultiTexCoord1sv glMultiTexCoord1sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2d(int target, Double s, Double t);
            internal static MultiTexCoord2d glMultiTexCoord2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dv(int target, Double* v);
            internal unsafe static MultiTexCoord2dv glMultiTexCoord2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2f(int target, Single s, Single t);
            internal static MultiTexCoord2f glMultiTexCoord2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fv(int target, Single* v);
            internal unsafe static MultiTexCoord2fv glMultiTexCoord2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2i(int target, Int32 s, Int32 t);
            internal static MultiTexCoord2i glMultiTexCoord2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2iv(int target, Int32* v);
            internal unsafe static MultiTexCoord2iv glMultiTexCoord2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2s(int target, Int16 s, Int16 t);
            internal static MultiTexCoord2s glMultiTexCoord2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2sv(int target, Int16* v);
            internal unsafe static MultiTexCoord2sv glMultiTexCoord2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3d(int target, Double s, Double t, Double r);
            internal static MultiTexCoord3d glMultiTexCoord3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dv(int target, Double* v);
            internal unsafe static MultiTexCoord3dv glMultiTexCoord3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3f(int target, Single s, Single t, Single r);
            internal static MultiTexCoord3f glMultiTexCoord3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fv(int target, Single* v);
            internal unsafe static MultiTexCoord3fv glMultiTexCoord3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3i(int target, Int32 s, Int32 t, Int32 r);
            internal static MultiTexCoord3i glMultiTexCoord3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3iv(int target, Int32* v);
            internal unsafe static MultiTexCoord3iv glMultiTexCoord3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3s(int target, Int16 s, Int16 t, Int16 r);
            internal static MultiTexCoord3s glMultiTexCoord3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3sv(int target, Int16* v);
            internal unsafe static MultiTexCoord3sv glMultiTexCoord3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4d(int target, Double s, Double t, Double r, Double q);
            internal static MultiTexCoord4d glMultiTexCoord4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dv(int target, Double* v);
            internal unsafe static MultiTexCoord4dv glMultiTexCoord4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4f(int target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fv(int target, Single* v);
            internal unsafe static MultiTexCoord4fv glMultiTexCoord4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4i(int target, Int32 s, Int32 t, Int32 r, Int32 q);
            internal static MultiTexCoord4i glMultiTexCoord4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4iv(int target, Int32* v);
            internal unsafe static MultiTexCoord4iv glMultiTexCoord4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4s(int target, Int16 s, Int16 t, Int16 r, Int16 q);
            internal static MultiTexCoord4s glMultiTexCoord4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4sv(int target, Int16* v);
            internal unsafe static MultiTexCoord4sv glMultiTexCoord4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixf(Single* m);
            internal unsafe static LoadTransposeMatrixf glLoadTransposeMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixd(Double* m);
            internal unsafe static LoadTransposeMatrixd glLoadTransposeMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixf(Single* m);
            internal unsafe static MultTransposeMatrixf glMultTransposeMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixd(Double* m);
            internal unsafe static MultTransposeMatrixd glMultTransposeMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value, Int32 invert);
            internal static SampleCoverage glSampleCoverage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage1D glCompressedTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage1D glCompressedTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTexImage(int target, Int32 level, [Out] IntPtr img);
            internal static GetCompressedTexImage glGetCompressedTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordf(Single coord);
            internal static FogCoordf glFogCoordf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfv(Single* coord);
            internal unsafe static FogCoordfv glFogCoordfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordd(Double coord);
            internal static FogCoordd glFogCoordd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddv(Double* coord);
            internal unsafe static FogCoorddv glFogCoorddv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointer(int type, Int32 stride, IntPtr pointer);
            internal static FogCoordPointer glFogCoordPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArrays(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArrays glMultiDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElements(int mode, Int32* count, int type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElements glMultiDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterf(int pname, Single param);
            internal static PointParameterf glPointParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfv(int pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteri(int pname, Int32 param);
            internal static PointParameteri glPointParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameteriv(int pname, Int32* @params);
            internal unsafe static PointParameteriv glPointParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3b(SByte red, SByte green, SByte blue);
            internal static SecondaryColor3b glSecondaryColor3b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bv(SByte* v);
            internal unsafe static SecondaryColor3bv glSecondaryColor3bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3d(Double red, Double green, Double blue);
            internal static SecondaryColor3d glSecondaryColor3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dv(Double* v);
            internal unsafe static SecondaryColor3dv glSecondaryColor3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3f(Single red, Single green, Single blue);
            internal static SecondaryColor3f glSecondaryColor3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fv(Single* v);
            internal unsafe static SecondaryColor3fv glSecondaryColor3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
            internal static SecondaryColor3i glSecondaryColor3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3iv(Int32* v);
            internal unsafe static SecondaryColor3iv glSecondaryColor3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
            internal static SecondaryColor3s glSecondaryColor3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3sv(Int16* v);
            internal unsafe static SecondaryColor3sv glSecondaryColor3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ub(Byte red, Byte green, Byte blue);
            internal static SecondaryColor3ub glSecondaryColor3ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubv(Byte* v);
            internal unsafe static SecondaryColor3ubv glSecondaryColor3ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
            internal static SecondaryColor3ui glSecondaryColor3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uiv(UInt32* v);
            internal unsafe static SecondaryColor3uiv glSecondaryColor3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3us glSecondaryColor3us;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usv(UInt16* v);
            internal unsafe static SecondaryColor3usv glSecondaryColor3usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static SecondaryColorPointer glSecondaryColorPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2d(Double x, Double y);
            internal static WindowPos2d glWindowPos2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dv(Double* v);
            internal unsafe static WindowPos2dv glWindowPos2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2f(Single x, Single y);
            internal static WindowPos2f glWindowPos2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fv(Single* v);
            internal unsafe static WindowPos2fv glWindowPos2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2i(Int32 x, Int32 y);
            internal static WindowPos2i glWindowPos2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2iv(Int32* v);
            internal unsafe static WindowPos2iv glWindowPos2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2s(Int16 x, Int16 y);
            internal static WindowPos2s glWindowPos2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2sv(Int16* v);
            internal unsafe static WindowPos2sv glWindowPos2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3d(Double x, Double y, Double z);
            internal static WindowPos3d glWindowPos3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dv(Double* v);
            internal unsafe static WindowPos3dv glWindowPos3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3f(Single x, Single y, Single z);
            internal static WindowPos3f glWindowPos3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fv(Single* v);
            internal unsafe static WindowPos3fv glWindowPos3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3i(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3i glWindowPos3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3iv(Int32* v);
            internal unsafe static WindowPos3iv glWindowPos3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3s(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3s glWindowPos3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3sv(Int16* v);
            internal unsafe static WindowPos3sv glWindowPos3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueries(Int32 n, [Out] UInt32* ids);
            internal unsafe static GenQueries glGenQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsQuery(UInt32 id);
            internal static IsQuery glIsQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQuery(int target, UInt32 id);
            internal static BeginQuery glBeginQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQuery(int target);
            internal static EndQuery glEndQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryiv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectiv(UInt32 id, int pname, [Out] Int32* @params);
            internal unsafe static GetQueryObjectiv glGetQueryObjectiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, int pname, [Out] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(int target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n, [Out] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData(int target, IntPtr size, IntPtr data, int usage);
            internal static BufferData glBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData(int target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferSubData(int target, IntPtr offset, IntPtr size, [Out] IntPtr data);
            internal static GetBufferSubData glGetBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBuffer(int target, int access);
            internal unsafe static MapBuffer glMapBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 UnmapBuffer(int target);
            internal static UnmapBuffer glUnmapBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointerv(int target, int pname, [Out] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate(int modeRGB, int modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffers(Int32 n, int* bufs);
            internal unsafe static DrawBuffers glDrawBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate(int face, int sfail, int dpfail, int dppass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate(int face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, System.String name);
            internal static BindAttribLocation glBindAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader(int type);
            internal static CreateShader glCreateShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocation(UInt32 program, System.String name);
            internal static GetAttribLocation glGetAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv(UInt32 program, int pname, [Out] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv(UInt32 shader, int pname, [Out] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocation(UInt32 program, System.String name);
            internal static GetUniformLocation glGetUniformLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [Out] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [Out] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdv(UInt32 index, int pname, [Out] Double* @params);
            internal unsafe static GetVertexAttribdv glGetVertexAttribdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, int pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, int pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointerv(UInt32 index, int pname, [Out] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsProgram(UInt32 program);
            internal static IsProgram glIsProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsShader(UInt32 shader);
            internal static IsShader glIsShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, System.String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1f(Int32 location, Single v0);
            internal static Uniform1f glUniform1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
            internal static Uniform2f glUniform2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3f glUniform3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4f glUniform4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i(Int32 location, Int32 v0);
            internal static Uniform1i glUniform1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2i glUniform2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3i glUniform3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4i glUniform4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fv glUniform1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fv glUniform2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fv glUniform3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fv glUniform4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1iv glUniform1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2iv glUniform2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3iv glUniform3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4iv glUniform4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1d(UInt32 index, Double x);
            internal static VertexAttrib1d glVertexAttrib1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dv glVertexAttrib1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1s(UInt32 index, Int16 x);
            internal static VertexAttrib1s glVertexAttrib1s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1sv glVertexAttrib1sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2d(UInt32 index, Double x, Double y);
            internal static VertexAttrib2d glVertexAttrib2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dv glVertexAttrib2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2s glVertexAttrib2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2sv glVertexAttrib2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3d glVertexAttrib3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dv glVertexAttrib3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3s glVertexAttrib3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3sv glVertexAttrib3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nbv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Niv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nsv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4Nub glVertexAttrib4Nub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bv glVertexAttrib4bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4d glVertexAttrib4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dv glVertexAttrib4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4iv glVertexAttrib4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4s glVertexAttrib4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4sv glVertexAttrib4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usv glVertexAttrib4usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, int type, Int32 normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTextureARB(int texture);
            internal static ActiveTextureARB glActiveTextureARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTextureARB(int texture);
            internal static ClientActiveTextureARB glClientActiveTextureARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1dARB(int target, Double s);
            internal static MultiTexCoord1dARB glMultiTexCoord1dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dvARB(int target, Double* v);
            internal unsafe static MultiTexCoord1dvARB glMultiTexCoord1dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1fARB(int target, Single s);
            internal static MultiTexCoord1fARB glMultiTexCoord1fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fvARB(int target, Single* v);
            internal unsafe static MultiTexCoord1fvARB glMultiTexCoord1fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1iARB(int target, Int32 s);
            internal static MultiTexCoord1iARB glMultiTexCoord1iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1ivARB(int target, Int32* v);
            internal unsafe static MultiTexCoord1ivARB glMultiTexCoord1ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1sARB(int target, Int16 s);
            internal static MultiTexCoord1sARB glMultiTexCoord1sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1svARB(int target, Int16* v);
            internal unsafe static MultiTexCoord1svARB glMultiTexCoord1svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2dARB(int target, Double s, Double t);
            internal static MultiTexCoord2dARB glMultiTexCoord2dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dvARB(int target, Double* v);
            internal unsafe static MultiTexCoord2dvARB glMultiTexCoord2dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2fARB(int target, Single s, Single t);
            internal static MultiTexCoord2fARB glMultiTexCoord2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fvARB(int target, Single* v);
            internal unsafe static MultiTexCoord2fvARB glMultiTexCoord2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2iARB(int target, Int32 s, Int32 t);
            internal static MultiTexCoord2iARB glMultiTexCoord2iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2ivARB(int target, Int32* v);
            internal unsafe static MultiTexCoord2ivARB glMultiTexCoord2ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2sARB(int target, Int16 s, Int16 t);
            internal static MultiTexCoord2sARB glMultiTexCoord2sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2svARB(int target, Int16* v);
            internal unsafe static MultiTexCoord2svARB glMultiTexCoord2svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3dARB(int target, Double s, Double t, Double r);
            internal static MultiTexCoord3dARB glMultiTexCoord3dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dvARB(int target, Double* v);
            internal unsafe static MultiTexCoord3dvARB glMultiTexCoord3dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3fARB(int target, Single s, Single t, Single r);
            internal static MultiTexCoord3fARB glMultiTexCoord3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fvARB(int target, Single* v);
            internal unsafe static MultiTexCoord3fvARB glMultiTexCoord3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3iARB(int target, Int32 s, Int32 t, Int32 r);
            internal static MultiTexCoord3iARB glMultiTexCoord3iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3ivARB(int target, Int32* v);
            internal unsafe static MultiTexCoord3ivARB glMultiTexCoord3ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3sARB(int target, Int16 s, Int16 t, Int16 r);
            internal static MultiTexCoord3sARB glMultiTexCoord3sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3svARB(int target, Int16* v);
            internal unsafe static MultiTexCoord3svARB glMultiTexCoord3svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4dARB(int target, Double s, Double t, Double r, Double q);
            internal static MultiTexCoord4dARB glMultiTexCoord4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dvARB(int target, Double* v);
            internal unsafe static MultiTexCoord4dvARB glMultiTexCoord4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4fARB(int target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4fARB glMultiTexCoord4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fvARB(int target, Single* v);
            internal unsafe static MultiTexCoord4fvARB glMultiTexCoord4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4iARB(int target, Int32 s, Int32 t, Int32 r, Int32 q);
            internal static MultiTexCoord4iARB glMultiTexCoord4iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4ivARB(int target, Int32* v);
            internal unsafe static MultiTexCoord4ivARB glMultiTexCoord4ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4sARB(int target, Int16 s, Int16 t, Int16 r, Int16 q);
            internal static MultiTexCoord4sARB glMultiTexCoord4sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4svARB(int target, Int16* v);
            internal unsafe static MultiTexCoord4svARB glMultiTexCoord4svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixfARB(Single* m);
            internal unsafe static LoadTransposeMatrixfARB glLoadTransposeMatrixfARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixdARB(Double* m);
            internal unsafe static LoadTransposeMatrixdARB glLoadTransposeMatrixdARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixfARB(Single* m);
            internal unsafe static MultTransposeMatrixfARB glMultTransposeMatrixfARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixdARB(Double* m);
            internal unsafe static MultTransposeMatrixdARB glMultTransposeMatrixdARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverageARB(Single value, Int32 invert);
            internal static SampleCoverageARB glSampleCoverageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3DARB glCompressedTexImage3DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2DARB glCompressedTexImage2DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage1DARB(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage1DARB glCompressedTexImage1DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3DARB glCompressedTexSubImage3DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2DARB glCompressedTexSubImage2DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage1DARB(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage1DARB glCompressedTexSubImage1DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTexImageARB(int target, Int32 level, [Out] IntPtr img);
            internal static GetCompressedTexImageARB glGetCompressedTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfARB(int pname, Single param);
            internal static PointParameterfARB glPointParameterfARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvARB(int pname, Single* @params);
            internal unsafe static PointParameterfvARB glPointParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightbvARB(Int32 size, SByte* weights);
            internal unsafe static WeightbvARB glWeightbvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightsvARB(Int32 size, Int16* weights);
            internal unsafe static WeightsvARB glWeightsvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightivARB(Int32 size, Int32* weights);
            internal unsafe static WeightivARB glWeightivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightfvARB(Int32 size, Single* weights);
            internal unsafe static WeightfvARB glWeightfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightdvARB(Int32 size, Double* weights);
            internal unsafe static WeightdvARB glWeightdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightubvARB(Int32 size, Byte* weights);
            internal unsafe static WeightubvARB glWeightubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightusvARB(Int32 size, UInt16* weights);
            internal unsafe static WeightusvARB glWeightusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightuivARB(Int32 size, UInt32* weights);
            internal unsafe static WeightuivARB glWeightuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WeightPointerARB(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static WeightPointerARB glWeightPointerARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendARB(Int32 count);
            internal static VertexBlendARB glVertexBlendARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CurrentPaletteMatrixARB(Int32 index);
            internal static CurrentPaletteMatrixARB glCurrentPaletteMatrixARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexubvARB(Int32 size, Byte* indices);
            internal unsafe static MatrixIndexubvARB glMatrixIndexubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexusvARB(Int32 size, UInt16* indices);
            internal unsafe static MatrixIndexusvARB glMatrixIndexusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexuivARB(Int32 size, UInt32* indices);
            internal unsafe static MatrixIndexuivARB glMatrixIndexuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixIndexPointerARB(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static MatrixIndexPointerARB glMatrixIndexPointerARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dARB(Double x, Double y);
            internal static WindowPos2dARB glWindowPos2dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvARB(Double* v);
            internal unsafe static WindowPos2dvARB glWindowPos2dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fARB(Single x, Single y);
            internal static WindowPos2fARB glWindowPos2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvARB(Single* v);
            internal unsafe static WindowPos2fvARB glWindowPos2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iARB(Int32 x, Int32 y);
            internal static WindowPos2iARB glWindowPos2iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivARB(Int32* v);
            internal unsafe static WindowPos2ivARB glWindowPos2ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sARB(Int16 x, Int16 y);
            internal static WindowPos2sARB glWindowPos2sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svARB(Int16* v);
            internal unsafe static WindowPos2svARB glWindowPos2svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dARB(Double x, Double y, Double z);
            internal static WindowPos3dARB glWindowPos3dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvARB(Double* v);
            internal unsafe static WindowPos3dvARB glWindowPos3dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fARB(Single x, Single y, Single z);
            internal static WindowPos3fARB glWindowPos3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvARB(Single* v);
            internal unsafe static WindowPos3fvARB glWindowPos3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iARB(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3iARB glWindowPos3iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivARB(Int32* v);
            internal unsafe static WindowPos3ivARB glWindowPos3ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sARB(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3sARB glWindowPos3sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svARB(Int16* v);
            internal unsafe static WindowPos3svARB glWindowPos3svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dARB(UInt32 index, Double x);
            internal static VertexAttrib1dARB glVertexAttrib1dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dvARB glVertexAttrib1dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fARB(UInt32 index, Single x);
            internal static VertexAttrib1fARB glVertexAttrib1fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fvARB glVertexAttrib1fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sARB(UInt32 index, Int16 x);
            internal static VertexAttrib1sARB glVertexAttrib1sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1svARB glVertexAttrib1svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dARB(UInt32 index, Double x, Double y);
            internal static VertexAttrib2dARB glVertexAttrib2dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dvARB glVertexAttrib2dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fARB(UInt32 index, Single x, Single y);
            internal static VertexAttrib2fARB glVertexAttrib2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fvARB glVertexAttrib2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2sARB glVertexAttrib2sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2svARB glVertexAttrib2svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dARB(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3dARB glVertexAttrib3dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dvARB glVertexAttrib3dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fARB(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3fARB glVertexAttrib3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fvARB glVertexAttrib3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3sARB glVertexAttrib3sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3svARB glVertexAttrib3svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NbvARB(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4NbvARB glVertexAttrib4NbvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NivARB(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4NivARB glVertexAttrib4NivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NsvARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4NsvARB glVertexAttrib4NsvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4NubARB(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4NubARB glVertexAttrib4NubARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NubvARB(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4NubvARB glVertexAttrib4NubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NuivARB(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4NuivARB glVertexAttrib4NuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NusvARB(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4NusvARB glVertexAttrib4NusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bvARB(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bvARB glVertexAttrib4bvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dARB(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4dARB glVertexAttrib4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dvARB glVertexAttrib4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fARB(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4fARB glVertexAttrib4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fvARB glVertexAttrib4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ivARB(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4ivARB glVertexAttrib4ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4sARB glVertexAttrib4sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4svARB glVertexAttrib4svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvARB(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubvARB glVertexAttrib4ubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uivARB(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uivARB glVertexAttrib4uivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usvARB(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usvARB glVertexAttrib4usvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointerARB(UInt32 index, Int32 size, int type, Int32 normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointerARB glVertexAttribPointerARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArrayARB(UInt32 index);
            internal static EnableVertexAttribArrayARB glEnableVertexAttribArrayARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArrayARB(UInt32 index);
            internal static DisableVertexAttribArrayARB glDisableVertexAttribArrayARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramStringARB(int target, int format, Int32 len, IntPtr @string);
            internal static ProgramStringARB glProgramStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramARB(int target, UInt32 program);
            internal static BindProgramARB glBindProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsARB(Int32 n, UInt32* programs);
            internal unsafe static DeleteProgramsARB glDeleteProgramsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsARB(Int32 n, [Out] UInt32* programs);
            internal unsafe static GenProgramsARB glGenProgramsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4dARB(int target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramEnvParameter4dARB glProgramEnvParameter4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4dvARB(int target, UInt32 index, Double* @params);
            internal unsafe static ProgramEnvParameter4dvARB glProgramEnvParameter4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4fARB(int target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramEnvParameter4fARB glProgramEnvParameter4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4fvARB(int target, UInt32 index, Single* @params);
            internal unsafe static ProgramEnvParameter4fvARB glProgramEnvParameter4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4dARB(int target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramLocalParameter4dARB glProgramLocalParameter4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4dvARB(int target, UInt32 index, Double* @params);
            internal unsafe static ProgramLocalParameter4dvARB glProgramLocalParameter4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4fARB(int target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramLocalParameter4fARB glProgramLocalParameter4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4fvARB(int target, UInt32 index, Single* @params);
            internal unsafe static ProgramLocalParameter4fvARB glProgramLocalParameter4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterdvARB(int target, UInt32 index, [Out] Double* @params);
            internal unsafe static GetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterfvARB(int target, UInt32 index, [Out] Single* @params);
            internal unsafe static GetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterdvARB(int target, UInt32 index, [Out] Double* @params);
            internal unsafe static GetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterfvARB(int target, UInt32 index, [Out] Single* @params);
            internal unsafe static GetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivARB(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetProgramivARB glGetProgramivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetProgramStringARB(int target, int pname, [Out] IntPtr @string);
            internal static GetProgramStringARB glGetProgramStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvARB(UInt32 index, int pname, [Out] Double* @params);
            internal unsafe static GetVertexAttribdvARB glGetVertexAttribdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvARB(UInt32 index, int pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribfvARB glGetVertexAttribfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivARB(UInt32 index, int pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribivARB glGetVertexAttribivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointervARB(UInt32 index, int pname, [Out] IntPtr pointer);
            internal static GetVertexAttribPointervARB glGetVertexAttribPointervARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsProgramARB(UInt32 program);
            internal static IsProgramARB glIsProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferARB(int target, UInt32 buffer);
            internal static BindBufferARB glBindBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffersARB(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffersARB glDeleteBuffersARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffersARB(Int32 n, [Out] UInt32* buffers);
            internal unsafe static GenBuffersARB glGenBuffersARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsBufferARB(UInt32 buffer);
            internal static IsBufferARB glIsBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferDataARB(int target, IntPtr size, IntPtr data, int usage);
            internal static BufferDataARB glBufferDataARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubDataARB(int target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubDataARB glBufferSubDataARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferSubDataARB(int target, IntPtr offset, IntPtr size, [Out] IntPtr data);
            internal static GetBufferSubDataARB glGetBufferSubDataARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBufferARB(int target, int access);
            internal unsafe static MapBufferARB glMapBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 UnmapBufferARB(int target);
            internal static UnmapBufferARB glUnmapBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameterivARB(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetBufferParameterivARB glGetBufferParameterivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointervARB(int target, int pname, [Out] IntPtr @params);
            internal static GetBufferPointervARB glGetBufferPointervARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueriesARB(Int32 n, [Out] UInt32* ids);
            internal unsafe static GenQueriesARB glGenQueriesARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueriesARB(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueriesARB glDeleteQueriesARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsQueryARB(UInt32 id);
            internal static IsQueryARB glIsQueryARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryARB(int target, UInt32 id);
            internal static BeginQueryARB glBeginQueryARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryARB(int target);
            internal static EndQueryARB glEndQueryARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryivARB(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetQueryivARB glGetQueryivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectivARB(UInt32 id, int pname, [Out] Int32* @params);
            internal unsafe static GetQueryObjectivARB glGetQueryObjectivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuivARB(UInt32 id, int pname, [Out] UInt32* @params);
            internal unsafe static GetQueryObjectuivARB glGetQueryObjectuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteObjectARB(UInt32 obj);
            internal static DeleteObjectARB glDeleteObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetHandleARB(int pname);
            internal static GetHandleARB glGetHandleARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
            internal static DetachObjectARB glDetachObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderObjectARB(int shaderType);
            internal static CreateShaderObjectARB glCreateShaderObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSourceARB(UInt32 shaderObj, Int32 count, System.String[] @string, Int32* length);
            internal unsafe static ShaderSourceARB glShaderSourceARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShaderARB(UInt32 shaderObj);
            internal static CompileShaderARB glCompileShaderARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgramObjectARB();
            internal static CreateProgramObjectARB glCreateProgramObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachObjectARB(UInt32 containerObj, UInt32 obj);
            internal static AttachObjectARB glAttachObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgramARB(UInt32 programObj);
            internal static LinkProgramARB glLinkProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramObjectARB(UInt32 programObj);
            internal static UseProgramObjectARB glUseProgramObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramARB(UInt32 programObj);
            internal static ValidateProgramARB glValidateProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1fARB(Int32 location, Single v0);
            internal static Uniform1fARB glUniform1fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2fARB(Int32 location, Single v0, Single v1);
            internal static Uniform2fARB glUniform2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3fARB(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3fARB glUniform3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4fARB(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4fARB glUniform4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1iARB(Int32 location, Int32 v0);
            internal static Uniform1iARB glUniform1iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2iARB(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2iARB glUniform2iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3iARB glUniform3iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4iARB glUniform4iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fvARB glUniform1fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fvARB glUniform2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fvARB glUniform3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fvARB glUniform4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1ivARB glUniform1ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2ivARB glUniform2ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3ivARB glUniform3ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4ivARB glUniform4ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fvARB(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix2fvARB glUniformMatrix2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fvARB(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix3fvARB glUniformMatrix3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fvARB(Int32 location, Int32 count, Int32 transpose, Single* value);
            internal unsafe static UniformMatrix4fvARB glUniformMatrix4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterfvARB(UInt32 obj, int pname, [Out] Single* @params);
            internal unsafe static GetObjectParameterfvARB glGetObjectParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterivARB(UInt32 obj, int pname, [Out] Int32* @params);
            internal unsafe static GetObjectParameterivARB glGetObjectParameterivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInfoLogARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            internal unsafe static GetInfoLogARB glGetInfoLogARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
            internal unsafe static GetAttachedObjectsARB glGetAttachedObjectsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocationARB(UInt32 programObj, System.String name);
            internal static GetUniformLocationARB glGetUniformLocationARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveUniformARB glGetActiveUniformARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfvARB(UInt32 programObj, Int32 location, [Out] Single* @params);
            internal unsafe static GetUniformfvARB glGetUniformfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformivARB(UInt32 programObj, Int32 location, [Out] Int32* @params);
            internal unsafe static GetUniformivARB glGetUniformivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSourceARB(UInt32 obj, Int32 maxLength, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
            internal unsafe static GetShaderSourceARB glGetShaderSourceARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocationARB(UInt32 programObj, UInt32 index, System.String name);
            internal static BindAttribLocationARB glBindAttribLocationARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveAttribARB glGetActiveAttribARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocationARB(UInt32 programObj, System.String name);
            internal static GetAttribLocationARB glGetAttribLocationARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersARB(Int32 n, int* bufs);
            internal unsafe static DrawBuffersARB glDrawBuffersARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClampColorARB(int target, int clamp);
            internal static ClampColorARB glClampColorARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColorEXT(Single red, Single green, Single blue, Single alpha);
            internal static BlendColorEXT glBlendColorEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffsetEXT(Single factor, Single bias);
            internal static PolygonOffsetEXT glPolygonOffsetEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DEXT(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
            internal static TexImage3DEXT glTexImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
            internal static TexSubImage3DEXT glTexSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexFilterFuncSGIS(int target, int filter, [Out] Single* weights);
            internal unsafe static GetTexFilterFuncSGIS glGetTexFilterFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexFilterFuncSGIS(int target, int filter, Int32 n, Single* weights);
            internal unsafe static TexFilterFuncSGIS glTexFilterFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
            internal static TexSubImage1DEXT glTexSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
            internal static TexSubImage2DEXT glTexSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1DEXT glCopyTexImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2DEXT glCopyTexImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1DEXT glCopyTexSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2DEXT glCopyTexSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3DEXT glCopyTexSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetHistogramEXT(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            internal static GetHistogramEXT glGetHistogramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfvEXT(int target, int pname, [Out] Single* @params);
            internal unsafe static GetHistogramParameterfvEXT glGetHistogramParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterivEXT(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetHistogramParameterivEXT glGetHistogramParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMinmaxEXT(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            internal static GetMinmaxEXT glGetMinmaxEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfvEXT(int target, int pname, [Out] Single* @params);
            internal unsafe static GetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterivEXT(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetMinmaxParameterivEXT glGetMinmaxParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void HistogramEXT(int target, Int32 width, int internalformat, Int32 sink);
            internal static HistogramEXT glHistogramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MinmaxEXT(int target, int internalformat, Int32 sink);
            internal static MinmaxEXT glMinmaxEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogramEXT(int target);
            internal static ResetHistogramEXT glResetHistogramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmaxEXT(int target);
            internal static ResetMinmaxEXT glResetMinmaxEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter1DEXT(int target, int internalformat, Int32 width, int format, int type, IntPtr image);
            internal static ConvolutionFilter1DEXT glConvolutionFilter1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr image);
            internal static ConvolutionFilter2DEXT glConvolutionFilter2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterfEXT(int target, int pname, Single @params);
            internal static ConvolutionParameterfEXT glConvolutionParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfvEXT(int target, int pname, Single* @params);
            internal unsafe static ConvolutionParameterfvEXT glConvolutionParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteriEXT(int target, int pname, Int32 @params);
            internal static ConvolutionParameteriEXT glConvolutionParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterivEXT(int target, int pname, Int32* @params);
            internal unsafe static ConvolutionParameterivEXT glConvolutionParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetConvolutionFilterEXT(int target, int format, int type, [Out] IntPtr image);
            internal static GetConvolutionFilterEXT glGetConvolutionFilterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfvEXT(int target, int pname, [Out] Single* @params);
            internal unsafe static GetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterivEXT(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetConvolutionParameterivEXT glGetConvolutionParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetSeparableFilterEXT(int target, int format, int type, [Out] IntPtr row, [Out] IntPtr column, [Out] IntPtr span);
            internal static GetSeparableFilterEXT glGetSeparableFilterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SeparableFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr row, IntPtr column);
            internal static SeparableFilter2DEXT glSeparableFilter2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTableSGI(int target, int internalformat, Int32 width, int format, int type, IntPtr table);
            internal static ColorTableSGI glColorTableSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfvSGI(int target, int pname, Single* @params);
            internal unsafe static ColorTableParameterfvSGI glColorTableParameterfvSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterivSGI(int target, int pname, Int32* @params);
            internal unsafe static ColorTableParameterivSGI glColorTableParameterivSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTableSGI(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTableSGI glCopyColorTableSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTableSGI(int target, int format, int type, [Out] IntPtr table);
            internal static GetColorTableSGI glGetColorTableSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvSGI(int target, int pname, [Out] Single* @params);
            internal unsafe static GetColorTableParameterfvSGI glGetColorTableParameterfvSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivSGI(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetColorTableParameterivSGI glGetColorTableParameterivSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenSGIX(int mode);
            internal static PixelTexGenSGIX glPixelTexGenSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameteriSGIS(int pname, Int32 param);
            internal static PixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterivSGIS(int pname, Int32* @params);
            internal unsafe static PixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameterfSGIS(int pname, Single param);
            internal static PixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterfvSGIS(int pname, Single* @params);
            internal unsafe static PixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterivSGIS(int pname, [Out] Int32* @params);
            internal unsafe static GetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterfvSGIS(int pname, [Out] Single* @params);
            internal unsafe static GetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage4DSGIS(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, int format, int type, IntPtr pixels);
            internal static TexImage4DSGIS glTexImage4DSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage4DSGIS(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, int format, int type, IntPtr pixels);
            internal static TexSubImage4DSGIS glTexSubImage4DSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 AreTexturesResidentEXT(Int32 n, UInt32* textures, [Out] Int32* residences);
            internal unsafe static AreTexturesResidentEXT glAreTexturesResidentEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTextureEXT(int target, UInt32 texture);
            internal static BindTextureEXT glBindTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTexturesEXT(Int32 n, UInt32* textures);
            internal unsafe static DeleteTexturesEXT glDeleteTexturesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTexturesEXT(Int32 n, [Out] UInt32* textures);
            internal unsafe static GenTexturesEXT glGenTexturesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsTextureEXT(UInt32 texture);
            internal static IsTextureEXT glIsTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTexturesEXT(Int32 n, UInt32* textures, Single* priorities);
            internal unsafe static PrioritizeTexturesEXT glPrioritizeTexturesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DetailTexFuncSGIS(int target, Int32 n, Single* points);
            internal unsafe static DetailTexFuncSGIS glDetailTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDetailTexFuncSGIS(int target, [Out] Single* points);
            internal unsafe static GetDetailTexFuncSGIS glGetDetailTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SharpenTexFuncSGIS(int target, Int32 n, Single* points);
            internal unsafe static SharpenTexFuncSGIS glSharpenTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSharpenTexFuncSGIS(int target, [Out] Single* points);
            internal unsafe static GetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskSGIS(Single value, Int32 invert);
            internal static SampleMaskSGIS glSampleMaskSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternSGIS(int pattern);
            internal static SamplePatternSGIS glSamplePatternSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElementEXT(Int32 i);
            internal static ArrayElementEXT glArrayElementEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer);
            internal static ColorPointerEXT glColorPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysEXT(int mode, Int32 first, Int32 count);
            internal static DrawArraysEXT glDrawArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerEXT(Int32 stride, Int32 count, Int32* pointer);
            internal unsafe static EdgeFlagPointerEXT glEdgeFlagPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointervEXT(int pname, [Out] IntPtr @params);
            internal static GetPointervEXT glGetPointervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointerEXT(int type, Int32 stride, Int32 count, IntPtr pointer);
            internal static IndexPointerEXT glIndexPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointerEXT(int type, Int32 stride, Int32 count, IntPtr pointer);
            internal static NormalPointerEXT glNormalPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer);
            internal static TexCoordPointerEXT glTexCoordPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer);
            internal static VertexPointerEXT glVertexPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationEXT(int mode);
            internal static BlendEquationEXT glBlendEquationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameterfSGIX(int pname, Single param);
            internal static SpriteParameterfSGIX glSpriteParameterfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterfvSGIX(int pname, Single* @params);
            internal unsafe static SpriteParameterfvSGIX glSpriteParameterfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameteriSGIX(int pname, Int32 param);
            internal static SpriteParameteriSGIX glSpriteParameteriSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterivSGIX(int pname, Int32* @params);
            internal unsafe static SpriteParameterivSGIX glSpriteParameterivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfEXT(int pname, Single param);
            internal static PointParameterfEXT glPointParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvEXT(int pname, Single* @params);
            internal unsafe static PointParameterfvEXT glPointParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfSGIS(int pname, Single param);
            internal static PointParameterfSGIS glPointParameterfSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvSGIS(int pname, Single* @params);
            internal unsafe static PointParameterfvSGIS glPointParameterfvSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetInstrumentsSGIX();
            internal static GetInstrumentsSGIX glGetInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InstrumentsBufferSGIX(Int32 size, [Out] Int32* buffer);
            internal unsafe static InstrumentsBufferSGIX glInstrumentsBufferSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollInstrumentsSGIX([Out] Int32* marker_p);
            internal unsafe static PollInstrumentsSGIX glPollInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadInstrumentsSGIX(Int32 marker);
            internal static ReadInstrumentsSGIX glReadInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StartInstrumentsSGIX();
            internal static StartInstrumentsSGIX glStartInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StopInstrumentsSGIX(Int32 marker);
            internal static StopInstrumentsSGIX glStopInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrameZoomSGIX(Int32 factor);
            internal static FrameZoomSGIX glFrameZoomSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TagSampleBufferSGIX();
            internal static TagSampleBufferSGIX glTagSampleBufferSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3dSGIX(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double w1, Double w2, Int32 wstride, Int32 worder, Double* points);
            internal unsafe static DeformationMap3dSGIX glDeformationMap3dSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3fSGIX(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single w1, Single w2, Int32 wstride, Int32 worder, Single* points);
            internal unsafe static DeformationMap3fSGIX glDeformationMap3fSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeformSGIX(int mask);
            internal static DeformSGIX glDeformSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentityDeformationMapSGIX(int mask);
            internal static LoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReferencePlaneSGIX(Double* equation);
            internal unsafe static ReferencePlaneSGIX glReferencePlaneSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushRasterSGIX();
            internal static FlushRasterSGIX glFlushRasterSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogFuncSGIS(Int32 n, Single* points);
            internal unsafe static FogFuncSGIS glFogFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFogFuncSGIS([Out] Single* points);
            internal unsafe static GetFogFuncSGIS glGetFogFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameteriHP(int target, int pname, Int32 param);
            internal static ImageTransformParameteriHP glImageTransformParameteriHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameterfHP(int target, int pname, Single param);
            internal static ImageTransformParameterfHP glImageTransformParameterfHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterivHP(int target, int pname, Int32* @params);
            internal unsafe static ImageTransformParameterivHP glImageTransformParameterivHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterfvHP(int target, int pname, Single* @params);
            internal unsafe static ImageTransformParameterfvHP glImageTransformParameterfvHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterivHP(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetImageTransformParameterivHP glGetImageTransformParameterivHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterfvHP(int target, int pname, [Out] Single* @params);
            internal unsafe static GetImageTransformParameterfvHP glGetImageTransformParameterfvHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorSubTableEXT(int target, Int32 start, Int32 count, int format, int type, IntPtr data);
            internal static ColorSubTableEXT glColorSubTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTableEXT(int target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTableEXT glCopyColorSubTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void HintPGI(int target, Int32 mode);
            internal static HintPGI glHintPGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTableEXT(int target, int internalFormat, Int32 width, int format, int type, IntPtr table);
            internal static ColorTableEXT glColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTableEXT(int target, int format, int type, [Out] IntPtr data);
            internal static GetColorTableEXT glGetColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivEXT(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetColorTableParameterivEXT glGetColorTableParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvEXT(int target, int pname, [Out] Single* @params);
            internal unsafe static GetColorTableParameterfvEXT glGetColorTableParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterfvSGIX(UInt32 list, int pname, [Out] Single* @params);
            internal unsafe static GetListParameterfvSGIX glGetListParameterfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterivSGIX(UInt32 list, int pname, [Out] Int32* @params);
            internal unsafe static GetListParameterivSGIX glGetListParameterivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameterfSGIX(UInt32 list, int pname, Single param);
            internal static ListParameterfSGIX glListParameterfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterfvSGIX(UInt32 list, int pname, Single* @params);
            internal unsafe static ListParameterfvSGIX glListParameterfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameteriSGIX(UInt32 list, int pname, Int32 param);
            internal static ListParameteriSGIX glListParameteriSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterivSGIX(UInt32 list, int pname, Int32* @params);
            internal unsafe static ListParameterivSGIX glListParameterivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMaterialEXT(int face, int mode);
            internal static IndexMaterialEXT glIndexMaterialEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexFuncEXT(int func, Single @ref);
            internal static IndexFuncEXT glIndexFuncEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LockArraysEXT(Int32 first, Int32 count);
            internal static LockArraysEXT glLockArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UnlockArraysEXT();
            internal static UnlockArraysEXT glUnlockArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterdvEXT(int pname, [Out] Double* @params);
            internal unsafe static CullParameterdvEXT glCullParameterdvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterfvEXT(int pname, [Out] Single* @params);
            internal unsafe static CullParameterfvEXT glCullParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentColorMaterialSGIX(int face, int mode);
            internal static FragmentColorMaterialSGIX glFragmentColorMaterialSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightfSGIX(int light, int pname, Single param);
            internal static FragmentLightfSGIX glFragmentLightfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightfvSGIX(int light, int pname, Single* @params);
            internal unsafe static FragmentLightfvSGIX glFragmentLightfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightiSGIX(int light, int pname, Int32 param);
            internal static FragmentLightiSGIX glFragmentLightiSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightivSGIX(int light, int pname, Int32* @params);
            internal unsafe static FragmentLightivSGIX glFragmentLightivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModelfSGIX(int pname, Single param);
            internal static FragmentLightModelfSGIX glFragmentLightModelfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelfvSGIX(int pname, Single* @params);
            internal unsafe static FragmentLightModelfvSGIX glFragmentLightModelfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModeliSGIX(int pname, Int32 param);
            internal static FragmentLightModeliSGIX glFragmentLightModeliSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelivSGIX(int pname, Int32* @params);
            internal unsafe static FragmentLightModelivSGIX glFragmentLightModelivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialfSGIX(int face, int pname, Single param);
            internal static FragmentMaterialfSGIX glFragmentMaterialfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialfvSGIX(int face, int pname, Single* @params);
            internal unsafe static FragmentMaterialfvSGIX glFragmentMaterialfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialiSGIX(int face, int pname, Int32 param);
            internal static FragmentMaterialiSGIX glFragmentMaterialiSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialivSGIX(int face, int pname, Int32* @params);
            internal unsafe static FragmentMaterialivSGIX glFragmentMaterialivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightfvSGIX(int light, int pname, [Out] Single* @params);
            internal unsafe static GetFragmentLightfvSGIX glGetFragmentLightfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightivSGIX(int light, int pname, [Out] Int32* @params);
            internal unsafe static GetFragmentLightivSGIX glGetFragmentLightivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialfvSGIX(int face, int pname, [Out] Single* @params);
            internal unsafe static GetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialivSGIX(int face, int pname, [Out] Int32* @params);
            internal unsafe static GetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightEnviSGIX(int pname, Int32 param);
            internal static LightEnviSGIX glLightEnviSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementsEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices);
            internal static DrawRangeElementsEXT glDrawRangeElementsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ApplyTextureEXT(int mode);
            internal static ApplyTextureEXT glApplyTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureLightEXT(int pname);
            internal static TextureLightEXT glTextureLightEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureMaterialEXT(int face, int mode);
            internal static TextureMaterialEXT glTextureMaterialEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AsyncMarkerSGIX(UInt32 marker);
            internal static AsyncMarkerSGIX glAsyncMarkerSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 FinishAsyncSGIX([Out] UInt32* markerp);
            internal unsafe static FinishAsyncSGIX glFinishAsyncSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollAsyncSGIX([Out] UInt32* markerp);
            internal unsafe static PollAsyncSGIX glPollAsyncSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenAsyncMarkersSGIX(Int32 range);
            internal static GenAsyncMarkersSGIX glGenAsyncMarkersSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
            internal static DeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsAsyncMarkerSGIX(UInt32 marker);
            internal static IsAsyncMarkerSGIX glIsAsyncMarkerSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointervINTEL(Int32 size, int type, IntPtr pointer);
            internal static VertexPointervINTEL glVertexPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointervINTEL(int type, IntPtr pointer);
            internal static NormalPointervINTEL glNormalPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointervINTEL(Int32 size, int type, IntPtr pointer);
            internal static ColorPointervINTEL glColorPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointervINTEL(Int32 size, int type, IntPtr pointer);
            internal static TexCoordPointervINTEL glTexCoordPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameteriEXT(int target, int pname, Int32 param);
            internal static PixelTransformParameteriEXT glPixelTransformParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameterfEXT(int target, int pname, Single param);
            internal static PixelTransformParameterfEXT glPixelTransformParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterivEXT(int target, int pname, Int32* @params);
            internal unsafe static PixelTransformParameterivEXT glPixelTransformParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterfvEXT(int target, int pname, Single* @params);
            internal unsafe static PixelTransformParameterfvEXT glPixelTransformParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3bEXT(SByte red, SByte green, SByte blue);
            internal static SecondaryColor3bEXT glSecondaryColor3bEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bvEXT(SByte* v);
            internal unsafe static SecondaryColor3bvEXT glSecondaryColor3bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3dEXT(Double red, Double green, Double blue);
            internal static SecondaryColor3dEXT glSecondaryColor3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dvEXT(Double* v);
            internal unsafe static SecondaryColor3dvEXT glSecondaryColor3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3fEXT(Single red, Single green, Single blue);
            internal static SecondaryColor3fEXT glSecondaryColor3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fvEXT(Single* v);
            internal unsafe static SecondaryColor3fvEXT glSecondaryColor3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
            internal static SecondaryColor3iEXT glSecondaryColor3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ivEXT(Int32* v);
            internal unsafe static SecondaryColor3ivEXT glSecondaryColor3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
            internal static SecondaryColor3sEXT glSecondaryColor3sEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3svEXT(Int16* v);
            internal unsafe static SecondaryColor3svEXT glSecondaryColor3svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ubEXT(Byte red, Byte green, Byte blue);
            internal static SecondaryColor3ubEXT glSecondaryColor3ubEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubvEXT(Byte* v);
            internal unsafe static SecondaryColor3ubvEXT glSecondaryColor3ubvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
            internal static SecondaryColor3uiEXT glSecondaryColor3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uivEXT(UInt32* v);
            internal unsafe static SecondaryColor3uivEXT glSecondaryColor3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3usEXT glSecondaryColor3usEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usvEXT(UInt16* v);
            internal unsafe static SecondaryColor3usvEXT glSecondaryColor3usvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointerEXT(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static SecondaryColorPointerEXT glSecondaryColorPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureNormalEXT(int mode);
            internal static TextureNormalEXT glTextureNormalEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArraysEXT(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsEXT(int mode, Int32* count, int type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordfEXT(Single coord);
            internal static FogCoordfEXT glFogCoordfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfvEXT(Single* coord);
            internal unsafe static FogCoordfvEXT glFogCoordfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoorddEXT(Double coord);
            internal static FogCoorddEXT glFogCoorddEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddvEXT(Double* coord);
            internal unsafe static FogCoorddvEXT glFogCoorddvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointerEXT(int type, Int32 stride, IntPtr pointer);
            internal static FogCoordPointerEXT glFogCoordPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3bEXT(SByte tx, SByte ty, SByte tz);
            internal static Tangent3bEXT glTangent3bEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3bvEXT(SByte* v);
            internal unsafe static Tangent3bvEXT glTangent3bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3dEXT(Double tx, Double ty, Double tz);
            internal static Tangent3dEXT glTangent3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3dvEXT(Double* v);
            internal unsafe static Tangent3dvEXT glTangent3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3fEXT(Single tx, Single ty, Single tz);
            internal static Tangent3fEXT glTangent3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3fvEXT(Single* v);
            internal unsafe static Tangent3fvEXT glTangent3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
            internal static Tangent3iEXT glTangent3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3ivEXT(Int32* v);
            internal unsafe static Tangent3ivEXT glTangent3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
            internal static Tangent3sEXT glTangent3sEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3svEXT(Int16* v);
            internal unsafe static Tangent3svEXT glTangent3svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3bEXT(SByte bx, SByte by, SByte bz);
            internal static Binormal3bEXT glBinormal3bEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3bvEXT(SByte* v);
            internal unsafe static Binormal3bvEXT glBinormal3bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3dEXT(Double bx, Double by, Double bz);
            internal static Binormal3dEXT glBinormal3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3dvEXT(Double* v);
            internal unsafe static Binormal3dvEXT glBinormal3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3fEXT(Single bx, Single by, Single bz);
            internal static Binormal3fEXT glBinormal3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3fvEXT(Single* v);
            internal unsafe static Binormal3fvEXT glBinormal3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3iEXT(Int32 bx, Int32 by, Int32 bz);
            internal static Binormal3iEXT glBinormal3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3ivEXT(Int32* v);
            internal unsafe static Binormal3ivEXT glBinormal3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3sEXT(Int16 bx, Int16 by, Int16 bz);
            internal static Binormal3sEXT glBinormal3sEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3svEXT(Int16* v);
            internal unsafe static Binormal3svEXT glBinormal3svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TangentPointerEXT(int type, Int32 stride, IntPtr pointer);
            internal static TangentPointerEXT glTangentPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BinormalPointerEXT(int type, Int32 stride, IntPtr pointer);
            internal static BinormalPointerEXT glBinormalPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishTextureSUNX();
            internal static FinishTextureSUNX glFinishTextureSUNX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorbSUN(SByte factor);
            internal static GlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorsSUN(Int16 factor);
            internal static GlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoriSUN(Int32 factor);
            internal static GlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorfSUN(Single factor);
            internal static GlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactordSUN(Double factor);
            internal static GlobalAlphaFactordSUN glGlobalAlphaFactordSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorubSUN(Byte factor);
            internal static GlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorusSUN(UInt16 factor);
            internal static GlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoruiSUN(UInt32 factor);
            internal static GlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiSUN(UInt32 code);
            internal static ReplacementCodeuiSUN glReplacementCodeuiSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeusSUN(UInt16 code);
            internal static ReplacementCodeusSUN glReplacementCodeusSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeubSUN(Byte code);
            internal static ReplacementCodeubSUN glReplacementCodeubSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuivSUN(UInt32* code);
            internal unsafe static ReplacementCodeuivSUN glReplacementCodeuivSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeusvSUN(UInt16* code);
            internal unsafe static ReplacementCodeusvSUN glReplacementCodeusvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeubvSUN(Byte* code);
            internal unsafe static ReplacementCodeubvSUN glReplacementCodeubvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodePointerSUN(int type, Int32 stride, IntPtr pointer);
            internal static ReplacementCodePointerSUN glReplacementCodePointerSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex2fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y);
            internal static Color4ubVertex2fSUN glColor4ubVertex2fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex2fvSUN(Byte* c, Single* v);
            internal unsafe static Color4ubVertex2fvSUN glColor4ubVertex2fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex3fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static Color4ubVertex3fSUN glColor4ubVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex3fvSUN(Byte* c, Single* v);
            internal unsafe static Color4ubVertex3fvSUN glColor4ubVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3fVertex3fSUN(Single r, Single g, Single b, Single x, Single y, Single z);
            internal static Color3fVertex3fSUN glColor3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fVertex3fvSUN(Single* c, Single* v);
            internal unsafe static Color3fVertex3fvSUN glColor3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3fVertex3fSUN(Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static Normal3fVertex3fSUN glNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fVertex3fvSUN(Single* n, Single* v);
            internal unsafe static Normal3fVertex3fvSUN glNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4fNormal3fVertex3fSUN(Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static Color4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fNormal3fVertex3fvSUN(Single* c, Single* n, Single* v);
            internal unsafe static Color4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fVertex3fSUN(Single s, Single t, Single x, Single y, Single z);
            internal static TexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fVertex3fvSUN(Single* tc, Single* v);
            internal unsafe static TexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fVertex4fSUN(Single s, Single t, Single p, Single q, Single x, Single y, Single z, Single w);
            internal static TexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fVertex4fvSUN(Single* tc, Single* v);
            internal unsafe static TexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4ubVertex3fSUN(Single s, Single t, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static TexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4ubVertex3fvSUN(Single* tc, Byte* c, Single* v);
            internal unsafe static TexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single x, Single y, Single z);
            internal static TexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor3fVertex3fvSUN(Single* tc, Single* c, Single* v);
            internal unsafe static TexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fNormal3fVertex3fSUN(Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static TexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fNormal3fVertex3fvSUN(Single* tc, Single* n, Single* v);
            internal unsafe static TexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4fNormal3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static TexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static TexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fColor4fNormal3fVertex4fSUN(Single s, Single t, Single p, Single q, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z, Single w);
            internal static TexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static TexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiVertex3fSUN(UInt32 rc, Single x, Single y, Single z);
            internal static ReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiVertex3fvSUN(UInt32* rc, Single* v);
            internal unsafe static ReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, Byte* c, Single* v);
            internal unsafe static ReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, Single* c, Single* v);
            internal unsafe static ReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* c, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, Single s, Single t, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, Single* tc, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateEXT(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
            internal static BlendFuncSeparateEXT glBlendFuncSeparateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateINGR(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
            internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeightfEXT(Single weight);
            internal static VertexWeightfEXT glVertexWeightfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeightfvEXT(Single* weight);
            internal unsafe static VertexWeightfvEXT glVertexWeightfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeightPointerEXT(Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static VertexWeightPointerEXT glVertexWeightPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushVertexArrayRangeNV();
            internal static FlushVertexArrayRangeNV glFlushVertexArrayRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayRangeNV(Int32 length, IntPtr pointer);
            internal static VertexArrayRangeNV glVertexArrayRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterfvNV(int pname, Single* @params);
            internal unsafe static CombinerParameterfvNV glCombinerParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameterfNV(int pname, Single param);
            internal static CombinerParameterfNV glCombinerParameterfNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterivNV(int pname, Int32* @params);
            internal unsafe static CombinerParameterivNV glCombinerParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameteriNV(int pname, Int32 param);
            internal static CombinerParameteriNV glCombinerParameteriNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerInputNV(int stage, int portion, int variable, int input, int mapping, int componentUsage);
            internal static CombinerInputNV glCombinerInputNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerOutputNV(int stage, int portion, int abOutput, int cdOutput, int sumOutput, int scale, int bias, Int32 abDotProduct, Int32 cdDotProduct, Int32 muxSum);
            internal static CombinerOutputNV glCombinerOutputNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinalCombinerInputNV(int variable, int input, int mapping, int componentUsage);
            internal static FinalCombinerInputNV glFinalCombinerInputNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterfvNV(int stage, int portion, int variable, int pname, [Out] Single* @params);
            internal unsafe static GetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterivNV(int stage, int portion, int variable, int pname, [Out] Int32* @params);
            internal unsafe static GetCombinerInputParameterivNV glGetCombinerInputParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterfvNV(int stage, int portion, int pname, [Out] Single* @params);
            internal unsafe static GetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterivNV(int stage, int portion, int pname, [Out] Int32* @params);
            internal unsafe static GetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterfvNV(int variable, int pname, [Out] Single* @params);
            internal unsafe static GetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterivNV(int variable, int pname, [Out] Int32* @params);
            internal unsafe static GetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResizeBuffersMESA();
            internal static ResizeBuffersMESA glResizeBuffersMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dMESA(Double x, Double y);
            internal static WindowPos2dMESA glWindowPos2dMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvMESA(Double* v);
            internal unsafe static WindowPos2dvMESA glWindowPos2dvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fMESA(Single x, Single y);
            internal static WindowPos2fMESA glWindowPos2fMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvMESA(Single* v);
            internal unsafe static WindowPos2fvMESA glWindowPos2fvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iMESA(Int32 x, Int32 y);
            internal static WindowPos2iMESA glWindowPos2iMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivMESA(Int32* v);
            internal unsafe static WindowPos2ivMESA glWindowPos2ivMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sMESA(Int16 x, Int16 y);
            internal static WindowPos2sMESA glWindowPos2sMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svMESA(Int16* v);
            internal unsafe static WindowPos2svMESA glWindowPos2svMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dMESA(Double x, Double y, Double z);
            internal static WindowPos3dMESA glWindowPos3dMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvMESA(Double* v);
            internal unsafe static WindowPos3dvMESA glWindowPos3dvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fMESA(Single x, Single y, Single z);
            internal static WindowPos3fMESA glWindowPos3fMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvMESA(Single* v);
            internal unsafe static WindowPos3fvMESA glWindowPos3fvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iMESA(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3iMESA glWindowPos3iMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivMESA(Int32* v);
            internal unsafe static WindowPos3ivMESA glWindowPos3ivMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sMESA(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3sMESA glWindowPos3sMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svMESA(Int16* v);
            internal unsafe static WindowPos3svMESA glWindowPos3svMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4dMESA(Double x, Double y, Double z, Double w);
            internal static WindowPos4dMESA glWindowPos4dMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4dvMESA(Double* v);
            internal unsafe static WindowPos4dvMESA glWindowPos4dvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4fMESA(Single x, Single y, Single z, Single w);
            internal static WindowPos4fMESA glWindowPos4fMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4fvMESA(Single* v);
            internal unsafe static WindowPos4fvMESA glWindowPos4fvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static WindowPos4iMESA glWindowPos4iMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4ivMESA(Int32* v);
            internal unsafe static WindowPos4ivMESA glWindowPos4ivMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static WindowPos4sMESA glWindowPos4sMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4svMESA(Int16* v);
            internal unsafe static WindowPos4svMESA glWindowPos4svMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawArraysIBM(int* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
            internal unsafe static MultiModeDrawArraysIBM glMultiModeDrawArraysIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawElementsIBM(int* mode, Int32* count, int type, IntPtr indices, Int32 primcount, Int32 modestride);
            internal unsafe static MultiModeDrawElementsIBM glMultiModeDrawElementsIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointerListIBM(Int32 size, int type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static ColorPointerListIBM glColorPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointerListIBM(Int32 size, int type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static SecondaryColorPointerListIBM glSecondaryColorPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerListIBM(Int32 stride, Int32* pointer, Int32 ptrstride);
            internal unsafe static EdgeFlagPointerListIBM glEdgeFlagPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointerListIBM(int type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static FogCoordPointerListIBM glFogCoordPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointerListIBM(int type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static IndexPointerListIBM glIndexPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointerListIBM(int type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static NormalPointerListIBM glNormalPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointerListIBM(Int32 size, int type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static TexCoordPointerListIBM glTexCoordPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointerListIBM(Int32 size, int type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static VertexPointerListIBM glVertexPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TbufferMask3DFX(UInt32 mask);
            internal static TbufferMask3DFX glTbufferMask3DFX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskEXT(Single value, Int32 invert);
            internal static SampleMaskEXT glSampleMaskEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternEXT(int pattern);
            internal static SamplePatternEXT glSamplePatternEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureColorMaskSGIS(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static TextureColorMaskSGIS glTextureColorMaskSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IglooInterfaceSGIX(int pname, IntPtr @params);
            internal static IglooInterfaceSGIX glIglooInterfaceSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesNV(Int32 n, [Out] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, int pname, [Out] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceNV(UInt32 fence, int condition);
            internal static SetFenceNV glSetFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, Int32 packed, IntPtr points);
            internal static MapControlPointsNV glMapControlPointsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterivNV(int target, int pname, Int32* @params);
            internal unsafe static MapParameterivNV glMapParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterfvNV(int target, int pname, Single* @params);
            internal unsafe static MapParameterfvNV glMapParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, Int32 packed, [Out] IntPtr points);
            internal static GetMapControlPointsNV glGetMapControlPointsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterivNV(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetMapParameterivNV glGetMapParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterfvNV(int target, int pname, [Out] Single* @params);
            internal unsafe static GetMapParameterfvNV glGetMapParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterivNV(int target, UInt32 index, int pname, [Out] Int32* @params);
            internal unsafe static GetMapAttribParameterivNV glGetMapAttribParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterfvNV(int target, UInt32 index, int pname, [Out] Single* @params);
            internal unsafe static GetMapAttribParameterfvNV glGetMapAttribParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMapsNV(int target, int mode);
            internal static EvalMapsNV glEvalMapsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerStageParameterfvNV(int stage, int pname, Single* @params);
            internal unsafe static CombinerStageParameterfvNV glCombinerStageParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerStageParameterfvNV(int stage, int pname, [Out] Single* @params);
            internal unsafe static GetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 AreProgramsResidentNV(Int32 n, UInt32* programs, [Out] Int32* residences);
            internal unsafe static AreProgramsResidentNV glAreProgramsResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramNV(int target, UInt32 id);
            internal static BindProgramNV glBindProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsNV(Int32 n, UInt32* programs);
            internal unsafe static DeleteProgramsNV glDeleteProgramsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExecuteProgramNV(int target, UInt32 id, Single* @params);
            internal unsafe static ExecuteProgramNV glExecuteProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsNV(Int32 n, [Out] UInt32* programs);
            internal unsafe static GenProgramsNV glGenProgramsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterdvNV(int target, UInt32 index, int pname, [Out] Double* @params);
            internal unsafe static GetProgramParameterdvNV glGetProgramParameterdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterfvNV(int target, UInt32 index, int pname, [Out] Single* @params);
            internal unsafe static GetProgramParameterfvNV glGetProgramParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivNV(UInt32 id, int pname, [Out] Int32* @params);
            internal unsafe static GetProgramivNV glGetProgramivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStringNV(UInt32 id, int pname, [Out] Byte* program);
            internal unsafe static GetProgramStringNV glGetProgramStringNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTrackMatrixivNV(int target, UInt32 address, int pname, [Out] Int32* @params);
            internal unsafe static GetTrackMatrixivNV glGetTrackMatrixivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvNV(UInt32 index, int pname, [Out] Double* @params);
            internal unsafe static GetVertexAttribdvNV glGetVertexAttribdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvNV(UInt32 index, int pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribfvNV glGetVertexAttribfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivNV(UInt32 index, int pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribivNV glGetVertexAttribivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointervNV(UInt32 index, int pname, [Out] IntPtr pointer);
            internal static GetVertexAttribPointervNV glGetVertexAttribPointervNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsProgramNV(UInt32 id);
            internal static IsProgramNV glIsProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadProgramNV(int target, UInt32 id, Int32 len, Byte* program);
            internal unsafe static LoadProgramNV glLoadProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4dNV(int target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramParameter4dNV glProgramParameter4dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4dvNV(int target, UInt32 index, Double* v);
            internal unsafe static ProgramParameter4dvNV glProgramParameter4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4fNV(int target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramParameter4fNV glProgramParameter4fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4fvNV(int target, UInt32 index, Single* v);
            internal unsafe static ProgramParameter4fvNV glProgramParameter4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4dvNV(int target, UInt32 index, UInt32 count, Double* v);
            internal unsafe static ProgramParameters4dvNV glProgramParameters4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4fvNV(int target, UInt32 index, UInt32 count, Single* v);
            internal unsafe static ProgramParameters4fvNV glProgramParameters4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RequestResidentProgramsNV(Int32 n, UInt32* programs);
            internal unsafe static RequestResidentProgramsNV glRequestResidentProgramsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TrackMatrixNV(int target, UInt32 address, int matrix, int transform);
            internal static TrackMatrixNV glTrackMatrixNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointerNV(UInt32 index, Int32 fsize, int type, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointerNV glVertexAttribPointerNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dNV(UInt32 index, Double x);
            internal static VertexAttrib1dNV glVertexAttrib1dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dvNV glVertexAttrib1dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fNV(UInt32 index, Single x);
            internal static VertexAttrib1fNV glVertexAttrib1fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fvNV glVertexAttrib1fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sNV(UInt32 index, Int16 x);
            internal static VertexAttrib1sNV glVertexAttrib1sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1svNV glVertexAttrib1svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dNV(UInt32 index, Double x, Double y);
            internal static VertexAttrib2dNV glVertexAttrib2dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dvNV glVertexAttrib2dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fNV(UInt32 index, Single x, Single y);
            internal static VertexAttrib2fNV glVertexAttrib2fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fvNV glVertexAttrib2fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2sNV glVertexAttrib2sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2svNV glVertexAttrib2svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dNV(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3dNV glVertexAttrib3dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dvNV glVertexAttrib3dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fNV(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3fNV glVertexAttrib3fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fvNV glVertexAttrib3fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3sNV glVertexAttrib3sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3svNV glVertexAttrib3svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dNV(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4dNV glVertexAttrib4dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dvNV glVertexAttrib4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fNV(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4fNV glVertexAttrib4fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fvNV glVertexAttrib4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4sNV glVertexAttrib4sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4svNV glVertexAttrib4svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4ubNV(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4ubNV glVertexAttrib4ubNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvNV(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubvNV glVertexAttrib4ubvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs1dvNV glVertexAttribs1dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs1fvNV glVertexAttribs1fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs1svNV glVertexAttribs1svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs2dvNV glVertexAttribs2dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs2fvNV glVertexAttribs2fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs2svNV glVertexAttribs2svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs3dvNV glVertexAttribs3dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs3fvNV glVertexAttribs3fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs3svNV glVertexAttribs3svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs4dvNV glVertexAttribs4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs4fvNV glVertexAttribs4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs4svNV glVertexAttribs4svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4ubvNV(UInt32 index, Int32 count, Byte* v);
            internal unsafe static VertexAttribs4ubvNV glVertexAttribs4ubvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterivATI(int pname, Int32* param);
            internal unsafe static TexBumpParameterivATI glTexBumpParameterivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterfvATI(int pname, Single* param);
            internal unsafe static TexBumpParameterfvATI glTexBumpParameterfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterivATI(int pname, [Out] Int32* param);
            internal unsafe static GetTexBumpParameterivATI glGetTexBumpParameterivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterfvATI(int pname, [Out] Single* param);
            internal unsafe static GetTexBumpParameterfvATI glGetTexBumpParameterfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenFragmentShadersATI(UInt32 range);
            internal static GenFragmentShadersATI glGenFragmentShadersATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragmentShaderATI(UInt32 id);
            internal static BindFragmentShaderATI glBindFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteFragmentShaderATI(UInt32 id);
            internal static DeleteFragmentShaderATI glDeleteFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginFragmentShaderATI();
            internal static BeginFragmentShaderATI glBeginFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndFragmentShaderATI();
            internal static EndFragmentShaderATI glEndFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PassTexCoordATI(UInt32 dst, UInt32 coord, int swizzle);
            internal static PassTexCoordATI glPassTexCoordATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMapATI(UInt32 dst, UInt32 interp, int swizzle);
            internal static SampleMapATI glSampleMapATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            internal static ColorFragmentOp1ATI glColorFragmentOp1ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            internal static ColorFragmentOp2ATI glColorFragmentOp2ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            internal static ColorFragmentOp3ATI glColorFragmentOp3ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            internal static AlphaFragmentOp1ATI glAlphaFragmentOp1ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            internal static AlphaFragmentOp2ATI glAlphaFragmentOp2ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            internal static AlphaFragmentOp3ATI glAlphaFragmentOp3ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetFragmentShaderConstantATI(UInt32 dst, Single* value);
            internal unsafe static SetFragmentShaderConstantATI glSetFragmentShaderConstantATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesiATI(int pname, Int32 param);
            internal static PNTrianglesiATI glPNTrianglesiATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesfATI(int pname, Single param);
            internal static PNTrianglesfATI glPNTrianglesfATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 NewObjectBufferATI(Int32 size, IntPtr pointer, int usage);
            internal static NewObjectBufferATI glNewObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsObjectBufferATI(UInt32 buffer);
            internal static IsObjectBufferATI glIsObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, int preserve);
            internal static UpdateObjectBufferATI glUpdateObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferfvATI(UInt32 buffer, int pname, [Out] Single* @params);
            internal unsafe static GetObjectBufferfvATI glGetObjectBufferfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferivATI(UInt32 buffer, int pname, [Out] Int32* @params);
            internal unsafe static GetObjectBufferivATI glGetObjectBufferivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FreeObjectBufferATI(UInt32 buffer);
            internal static FreeObjectBufferATI glFreeObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayObjectATI(int array, Int32 size, int type, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static ArrayObjectATI glArrayObjectATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectfvATI(int array, int pname, [Out] Single* @params);
            internal unsafe static GetArrayObjectfvATI glGetArrayObjectfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectivATI(int array, int pname, [Out] Int32* @params);
            internal unsafe static GetArrayObjectivATI glGetArrayObjectivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VariantArrayObjectATI(UInt32 id, int type, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static VariantArrayObjectATI glVariantArrayObjectATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectfvATI(UInt32 id, int pname, [Out] Single* @params);
            internal unsafe static GetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectivATI(UInt32 id, int pname, [Out] Int32* @params);
            internal unsafe static GetVariantArrayObjectivATI glGetVariantArrayObjectivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginVertexShaderEXT();
            internal static BeginVertexShaderEXT glBeginVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndVertexShaderEXT();
            internal static EndVertexShaderEXT glEndVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexShaderEXT(UInt32 id);
            internal static BindVertexShaderEXT glBindVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenVertexShadersEXT(UInt32 range);
            internal static GenVertexShadersEXT glGenVertexShadersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteVertexShaderEXT(UInt32 id);
            internal static DeleteVertexShaderEXT glDeleteVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp1EXT(int op, UInt32 res, UInt32 arg1);
            internal static ShaderOp1EXT glShaderOp1EXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp2EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2);
            internal static ShaderOp2EXT glShaderOp2EXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp3EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
            internal static ShaderOp3EXT glShaderOp3EXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SwizzleEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
            internal static SwizzleEXT glSwizzleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WriteMaskEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
            internal static WriteMaskEXT glWriteMaskEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            internal static InsertComponentEXT glInsertComponentEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            internal static ExtractComponentEXT glExtractComponentEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenSymbolsEXT(int datatype, int storagetype, int range, UInt32 components);
            internal static GenSymbolsEXT glGenSymbolsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetInvariantEXT(UInt32 id, int type, IntPtr addr);
            internal static SetInvariantEXT glSetInvariantEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetLocalConstantEXT(UInt32 id, int type, IntPtr addr);
            internal static SetLocalConstantEXT glSetLocalConstantEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantbvEXT(UInt32 id, SByte* addr);
            internal unsafe static VariantbvEXT glVariantbvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantsvEXT(UInt32 id, Int16* addr);
            internal unsafe static VariantsvEXT glVariantsvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantivEXT(UInt32 id, Int32* addr);
            internal unsafe static VariantivEXT glVariantivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantfvEXT(UInt32 id, Single* addr);
            internal unsafe static VariantfvEXT glVariantfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantdvEXT(UInt32 id, Double* addr);
            internal unsafe static VariantdvEXT glVariantdvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantubvEXT(UInt32 id, Byte* addr);
            internal unsafe static VariantubvEXT glVariantubvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantusvEXT(UInt32 id, UInt16* addr);
            internal unsafe static VariantusvEXT glVariantusvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantuivEXT(UInt32 id, UInt32* addr);
            internal unsafe static VariantuivEXT glVariantuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VariantPointerEXT(UInt32 id, int type, UInt32 stride, IntPtr addr);
            internal static VariantPointerEXT glVariantPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVariantClientStateEXT(UInt32 id);
            internal static EnableVariantClientStateEXT glEnableVariantClientStateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVariantClientStateEXT(UInt32 id);
            internal static DisableVariantClientStateEXT glDisableVariantClientStateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindLightParameterEXT(int light, int value);
            internal static BindLightParameterEXT glBindLightParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindMaterialParameterEXT(int face, int value);
            internal static BindMaterialParameterEXT glBindMaterialParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTexGenParameterEXT(int unit, int coord, int value);
            internal static BindTexGenParameterEXT glBindTexGenParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTextureUnitParameterEXT(int unit, int value);
            internal static BindTextureUnitParameterEXT glBindTextureUnitParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindParameterEXT(int value);
            internal static BindParameterEXT glBindParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsVariantEnabledEXT(UInt32 id, int cap);
            internal static IsVariantEnabledEXT glIsVariantEnabledEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantBooleanvEXT(UInt32 id, int value, [Out] Int32* data);
            internal unsafe static GetVariantBooleanvEXT glGetVariantBooleanvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
            internal unsafe static GetVariantIntegervEXT glGetVariantIntegervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantFloatvEXT(UInt32 id, int value, [Out] Single* data);
            internal unsafe static GetVariantFloatvEXT glGetVariantFloatvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVariantPointervEXT(UInt32 id, int value, [Out] IntPtr data);
            internal static GetVariantPointervEXT glGetVariantPointervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantBooleanvEXT(UInt32 id, int value, [Out] Int32* data);
            internal unsafe static GetInvariantBooleanvEXT glGetInvariantBooleanvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
            internal unsafe static GetInvariantIntegervEXT glGetInvariantIntegervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantFloatvEXT(UInt32 id, int value, [Out] Single* data);
            internal unsafe static GetInvariantFloatvEXT glGetInvariantFloatvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantBooleanvEXT(UInt32 id, int value, [Out] Int32* data);
            internal unsafe static GetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantIntegervEXT(UInt32 id, int value, [Out] Int32* data);
            internal unsafe static GetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantFloatvEXT(UInt32 id, int value, [Out] Single* data);
            internal unsafe static GetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1sATI(int stream, Int16 x);
            internal static VertexStream1sATI glVertexStream1sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1svATI(int stream, Int16* coords);
            internal unsafe static VertexStream1svATI glVertexStream1svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1iATI(int stream, Int32 x);
            internal static VertexStream1iATI glVertexStream1iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1ivATI(int stream, Int32* coords);
            internal unsafe static VertexStream1ivATI glVertexStream1ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1fATI(int stream, Single x);
            internal static VertexStream1fATI glVertexStream1fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1fvATI(int stream, Single* coords);
            internal unsafe static VertexStream1fvATI glVertexStream1fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1dATI(int stream, Double x);
            internal static VertexStream1dATI glVertexStream1dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1dvATI(int stream, Double* coords);
            internal unsafe static VertexStream1dvATI glVertexStream1dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2sATI(int stream, Int16 x, Int16 y);
            internal static VertexStream2sATI glVertexStream2sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2svATI(int stream, Int16* coords);
            internal unsafe static VertexStream2svATI glVertexStream2svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2iATI(int stream, Int32 x, Int32 y);
            internal static VertexStream2iATI glVertexStream2iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2ivATI(int stream, Int32* coords);
            internal unsafe static VertexStream2ivATI glVertexStream2ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2fATI(int stream, Single x, Single y);
            internal static VertexStream2fATI glVertexStream2fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2fvATI(int stream, Single* coords);
            internal unsafe static VertexStream2fvATI glVertexStream2fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2dATI(int stream, Double x, Double y);
            internal static VertexStream2dATI glVertexStream2dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2dvATI(int stream, Double* coords);
            internal unsafe static VertexStream2dvATI glVertexStream2dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3sATI(int stream, Int16 x, Int16 y, Int16 z);
            internal static VertexStream3sATI glVertexStream3sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3svATI(int stream, Int16* coords);
            internal unsafe static VertexStream3svATI glVertexStream3svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3iATI(int stream, Int32 x, Int32 y, Int32 z);
            internal static VertexStream3iATI glVertexStream3iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3ivATI(int stream, Int32* coords);
            internal unsafe static VertexStream3ivATI glVertexStream3ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3fATI(int stream, Single x, Single y, Single z);
            internal static VertexStream3fATI glVertexStream3fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3fvATI(int stream, Single* coords);
            internal unsafe static VertexStream3fvATI glVertexStream3fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3dATI(int stream, Double x, Double y, Double z);
            internal static VertexStream3dATI glVertexStream3dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3dvATI(int stream, Double* coords);
            internal unsafe static VertexStream3dvATI glVertexStream3dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4sATI(int stream, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexStream4sATI glVertexStream4sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4svATI(int stream, Int16* coords);
            internal unsafe static VertexStream4svATI glVertexStream4svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4iATI(int stream, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexStream4iATI glVertexStream4iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4ivATI(int stream, Int32* coords);
            internal unsafe static VertexStream4ivATI glVertexStream4ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4fATI(int stream, Single x, Single y, Single z, Single w);
            internal static VertexStream4fATI glVertexStream4fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4fvATI(int stream, Single* coords);
            internal unsafe static VertexStream4fvATI glVertexStream4fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4dATI(int stream, Double x, Double y, Double z, Double w);
            internal static VertexStream4dATI glVertexStream4dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4dvATI(int stream, Double* coords);
            internal unsafe static VertexStream4dvATI glVertexStream4dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3bATI(int stream, SByte nx, SByte ny, SByte nz);
            internal static NormalStream3bATI glNormalStream3bATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3bvATI(int stream, SByte* coords);
            internal unsafe static NormalStream3bvATI glNormalStream3bvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3sATI(int stream, Int16 nx, Int16 ny, Int16 nz);
            internal static NormalStream3sATI glNormalStream3sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3svATI(int stream, Int16* coords);
            internal unsafe static NormalStream3svATI glNormalStream3svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3iATI(int stream, Int32 nx, Int32 ny, Int32 nz);
            internal static NormalStream3iATI glNormalStream3iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3ivATI(int stream, Int32* coords);
            internal unsafe static NormalStream3ivATI glNormalStream3ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3fATI(int stream, Single nx, Single ny, Single nz);
            internal static NormalStream3fATI glNormalStream3fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3fvATI(int stream, Single* coords);
            internal unsafe static NormalStream3fvATI glNormalStream3fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3dATI(int stream, Double nx, Double ny, Double nz);
            internal static NormalStream3dATI glNormalStream3dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3dvATI(int stream, Double* coords);
            internal unsafe static NormalStream3dvATI glNormalStream3dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveVertexStreamATI(int stream);
            internal static ClientActiveVertexStreamATI glClientActiveVertexStreamATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnviATI(int pname, Int32 param);
            internal static VertexBlendEnviATI glVertexBlendEnviATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnvfATI(int pname, Single param);
            internal static VertexBlendEnvfATI glVertexBlendEnvfATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ElementPointerATI(int type, IntPtr pointer);
            internal static ElementPointerATI glElementPointerATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayATI(int mode, Int32 count);
            internal static DrawElementArrayATI glDrawElementArrayATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayATI(int mode, UInt32 start, UInt32 end, Int32 count);
            internal static DrawRangeElementArrayATI glDrawRangeElementArrayATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawMeshArraysSUN(int mode, Int32 first, Int32 count, Int32 width);
            internal static DrawMeshArraysSUN glDrawMeshArraysSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenOcclusionQueriesNV(Int32 n, [Out] UInt32* ids);
            internal unsafe static GenOcclusionQueriesNV glGenOcclusionQueriesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
            internal unsafe static DeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsOcclusionQueryNV(UInt32 id);
            internal static IsOcclusionQueryNV glIsOcclusionQueryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginOcclusionQueryNV(UInt32 id);
            internal static BeginOcclusionQueryNV glBeginOcclusionQueryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndOcclusionQueryNV();
            internal static EndOcclusionQueryNV glEndOcclusionQueryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryivNV(UInt32 id, int pname, [Out] Int32* @params);
            internal unsafe static GetOcclusionQueryivNV glGetOcclusionQueryivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryuivNV(UInt32 id, int pname, [Out] UInt32* @params);
            internal unsafe static GetOcclusionQueryuivNV glGetOcclusionQueryuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteriNV(int pname, Int32 param);
            internal static PointParameteriNV glPointParameteriNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterivNV(int pname, Int32* @params);
            internal unsafe static PointParameterivNV glPointParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveStencilFaceEXT(int face);
            internal static ActiveStencilFaceEXT glActiveStencilFaceEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ElementPointerAPPLE(int type, IntPtr pointer);
            internal static ElementPointerAPPLE glElementPointerAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayAPPLE(int mode, Int32 first, Int32 count);
            internal static DrawElementArrayAPPLE glDrawElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
            internal static DrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementArrayAPPLE(int mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesAPPLE(Int32 n, [Out] UInt32* fences);
            internal unsafe static GenFencesAPPLE glGenFencesAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesAPPLE(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesAPPLE glDeleteFencesAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceAPPLE(UInt32 fence);
            internal static SetFenceAPPLE glSetFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsFenceAPPLE(UInt32 fence);
            internal static IsFenceAPPLE glIsFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 TestFenceAPPLE(UInt32 fence);
            internal static TestFenceAPPLE glTestFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceAPPLE(UInt32 fence);
            internal static FinishFenceAPPLE glFinishFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 TestObjectAPPLE(int @object, UInt32 name);
            internal static TestObjectAPPLE glTestObjectAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishObjectAPPLE(int @object, Int32 name);
            internal static FinishObjectAPPLE glFinishObjectAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArrayAPPLE(UInt32 array);
            internal static BindVertexArrayAPPLE glBindVertexArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArraysAPPLE(Int32 n, [Out] UInt32* arrays);
            internal unsafe static GenVertexArraysAPPLE glGenVertexArraysAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsVertexArrayAPPLE(UInt32 array);
            internal static IsVertexArrayAPPLE glIsVertexArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayRangeAPPLE(Int32 length, [Out] IntPtr pointer);
            internal static VertexArrayRangeAPPLE glVertexArrayRangeAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushVertexArrayRangeAPPLE(Int32 length, [Out] IntPtr pointer);
            internal static FlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayParameteriAPPLE(int pname, Int32 param);
            internal static VertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersATI(Int32 n, int* bufs);
            internal unsafe static DrawBuffersATI glDrawBuffersATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fNV(UInt32 id, Int32 len, Byte* name, Single x, Single y, Single z, Single w);
            internal unsafe static ProgramNamedParameter4fNV glProgramNamedParameter4fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dNV(UInt32 id, Int32 len, Byte* name, Double x, Double y, Double z, Double w);
            internal unsafe static ProgramNamedParameter4dNV glProgramNamedParameter4dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fvNV(UInt32 id, Int32 len, Byte* name, Single* v);
            internal unsafe static ProgramNamedParameter4fvNV glProgramNamedParameter4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dvNV(UInt32 id, Int32 len, Byte* name, Double* v);
            internal unsafe static ProgramNamedParameter4dvNV glProgramNamedParameter4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterfvNV(UInt32 id, Int32 len, Byte* name, [Out] Single* @params);
            internal unsafe static GetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterdvNV(UInt32 id, Int32 len, Byte* name, [Out] Double* @params);
            internal unsafe static GetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2hNV(UInt16 x, UInt16 y);
            internal static Vertex2hNV glVertex2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2hvNV(UInt16* v);
            internal unsafe static Vertex2hvNV glVertex2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3hNV(UInt16 x, UInt16 y, UInt16 z);
            internal static Vertex3hNV glVertex3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3hvNV(UInt16* v);
            internal unsafe static Vertex3hvNV glVertex3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);
            internal static Vertex4hNV glVertex4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4hvNV(UInt16* v);
            internal unsafe static Vertex4hvNV glVertex4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);
            internal static Normal3hNV glNormal3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3hvNV(UInt16* v);
            internal unsafe static Normal3hvNV glNormal3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3hNV(UInt16 red, UInt16 green, UInt16 blue);
            internal static Color3hNV glColor3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3hvNV(UInt16* v);
            internal unsafe static Color3hvNV glColor3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            internal static Color4hNV glColor4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4hvNV(UInt16* v);
            internal unsafe static Color4hvNV glColor4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1hNV(UInt16 s);
            internal static TexCoord1hNV glTexCoord1hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1hvNV(UInt16* v);
            internal unsafe static TexCoord1hvNV glTexCoord1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2hNV(UInt16 s, UInt16 t);
            internal static TexCoord2hNV glTexCoord2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2hvNV(UInt16* v);
            internal unsafe static TexCoord2hvNV glTexCoord2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);
            internal static TexCoord3hNV glTexCoord3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3hvNV(UInt16* v);
            internal unsafe static TexCoord3hvNV glTexCoord3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);
            internal static TexCoord4hNV glTexCoord4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4hvNV(UInt16* v);
            internal unsafe static TexCoord4hvNV glTexCoord4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1hNV(int target, UInt16 s);
            internal static MultiTexCoord1hNV glMultiTexCoord1hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1hvNV(int target, UInt16* v);
            internal unsafe static MultiTexCoord1hvNV glMultiTexCoord1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2hNV(int target, UInt16 s, UInt16 t);
            internal static MultiTexCoord2hNV glMultiTexCoord2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2hvNV(int target, UInt16* v);
            internal unsafe static MultiTexCoord2hvNV glMultiTexCoord2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3hNV(int target, UInt16 s, UInt16 t, UInt16 r);
            internal static MultiTexCoord3hNV glMultiTexCoord3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3hvNV(int target, UInt16* v);
            internal unsafe static MultiTexCoord3hvNV glMultiTexCoord3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4hNV(int target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);
            internal static MultiTexCoord4hNV glMultiTexCoord4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4hvNV(int target, UInt16* v);
            internal unsafe static MultiTexCoord4hvNV glMultiTexCoord4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordhNV(UInt16 fog);
            internal static FogCoordhNV glFogCoordhNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordhvNV(UInt16* fog);
            internal unsafe static FogCoordhvNV glFogCoordhvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3hNV glSecondaryColor3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3hvNV(UInt16* v);
            internal unsafe static SecondaryColor3hvNV glSecondaryColor3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeighthNV(UInt16 weight);
            internal static VertexWeighthNV glVertexWeighthNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeighthvNV(UInt16* weight);
            internal unsafe static VertexWeighthvNV glVertexWeighthvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1hNV(UInt32 index, UInt16 x);
            internal static VertexAttrib1hNV glVertexAttrib1hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib1hvNV glVertexAttrib1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);
            internal static VertexAttrib2hNV glVertexAttrib2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib2hvNV glVertexAttrib2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);
            internal static VertexAttrib3hNV glVertexAttrib3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib3hvNV glVertexAttrib3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);
            internal static VertexAttrib4hNV glVertexAttrib4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4hvNV(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4hvNV glVertexAttrib4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs1hvNV glVertexAttribs1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs2hvNV glVertexAttribs2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs3hvNV glVertexAttribs3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);
            internal unsafe static VertexAttribs4hvNV glVertexAttribs4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelDataRangeNV(int target, Int32 length, [Out] IntPtr pointer);
            internal static PixelDataRangeNV glPixelDataRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushPixelDataRangeNV(int target);
            internal static FlushPixelDataRangeNV glFlushPixelDataRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartNV();
            internal static PrimitiveRestartNV glPrimitiveRestartNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartIndexNV(UInt32 index);
            internal static PrimitiveRestartIndexNV glPrimitiveRestartIndexNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapObjectBufferATI(UInt32 buffer);
            internal unsafe static MapObjectBufferATI glMapObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UnmapObjectBufferATI(UInt32 buffer);
            internal static UnmapObjectBufferATI glUnmapObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparateATI(int face, int sfail, int dpfail, int dppass);
            internal static StencilOpSeparateATI glStencilOpSeparateATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparateATI(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparateATI glStencilFuncSeparateATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribArrayObjectATI(UInt32 index, Int32 size, int type, Int32 normalized, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static VertexAttribArrayObjectATI glVertexAttribArrayObjectATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectfvATI(UInt32 index, int pname, [Out] Single* @params);
            internal unsafe static GetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectivATI(UInt32 index, int pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsEXT(Double zmin, Double zmax);
            internal static DepthBoundsEXT glDepthBoundsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateEXT(int modeRGB, int modeAlpha);
            internal static BlendEquationSeparateEXT glBlendEquationSeparateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsRenderbufferEXT(UInt32 renderbuffer);
            internal static IsRenderbufferEXT glIsRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbufferEXT(int target, UInt32 renderbuffer);
            internal static BindRenderbufferEXT glBindRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffersEXT glDeleteRenderbuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffersEXT(Int32 n, [Out] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffersEXT glGenRenderbuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageEXT(int target, int internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageEXT glRenderbufferStorageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameterivEXT(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsFramebufferEXT(UInt32 framebuffer);
            internal static IsFramebufferEXT glIsFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebufferEXT(int target, UInt32 framebuffer);
            internal static BindFramebufferEXT glBindFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffersEXT glDeleteFramebuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffersEXT(Int32 n, [Out] UInt32* framebuffers);
            internal unsafe static GenFramebuffersEXT glGenFramebuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int CheckFramebufferStatusEXT(int target);
            internal static CheckFramebufferStatusEXT glCheckFramebufferStatusEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture1DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture1DEXT glFramebufferTexture1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2DEXT glFramebufferTexture2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3DEXT glFramebufferTexture3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbufferEXT(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbufferEXT glFramebufferRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameterivEXT(int target, int attachment, int pname, [Out] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmapEXT(int target);
            internal static GenerateMipmapEXT glGenerateMipmapEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StringMarkerGREMEDY(Int32 len, IntPtr @string);
            internal static StringMarkerGREMEDY glStringMarkerGREMEDY;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
            internal static StencilClearTagEXT glStencilClearTagEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, int mask, int filter);
            internal static BlitFramebufferEXT glBlitFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleEXT(int target, Int32 samples, int internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, int pname, [Out] Int64* @params);
            internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, int pname, [Out] UInt64* @params);
            internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameters4fvEXT(int target, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameters4fvEXT(int target, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferParameteriAPPLE(int target, int pname, Int32 param);
            internal static BufferParameteriAPPLE glBufferParameteriAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRangeAPPLE(int target, IntPtr offset, IntPtr size);
            internal static FlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static ProgramLocalParameterI4iNV glProgramLocalParameterI4iNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4ivNV(int target, UInt32 index, Int32* @params);
            internal unsafe static ProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static ProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4uivNV(int target, UInt32 index, UInt32* @params);
            internal unsafe static ProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static ProgramEnvParameterI4iNV glProgramEnvParameterI4iNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4ivNV(int target, UInt32 index, Int32* @params);
            internal unsafe static ProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static ProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4uivNV(int target, UInt32 index, UInt32* @params);
            internal unsafe static ProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIivNV(int target, UInt32 index, [Out] Int32* @params);
            internal unsafe static GetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIuivNV(int target, UInt32 index, [Out] UInt32* @params);
            internal unsafe static GetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIivNV(int target, UInt32 index, [Out] Int32* @params);
            internal unsafe static GetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIuivNV(int target, UInt32 index, [Out] UInt32* @params);
            internal unsafe static GetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramVertexLimitNV(int target, Int32 limit);
            internal static ProgramVertexLimitNV glProgramVertexLimitNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureEXT(int target, int attachment, UInt32 texture, Int32 level);
            internal static FramebufferTextureEXT glFramebufferTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayerEXT(int target, int attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayerEXT glFramebufferTextureLayerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureFaceEXT(int target, int attachment, UInt32 texture, Int32 level, int face);
            internal static FramebufferTextureFaceEXT glFramebufferTextureFaceEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriEXT(UInt32 program, int pname, Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1iEXT(UInt32 index, Int32 x);
            internal static VertexAttribI1iEXT glVertexAttribI1iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
            internal static VertexAttribI2iEXT glVertexAttribI2iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
            internal static VertexAttribI3iEXT glVertexAttribI3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4iEXT glVertexAttribI4iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1uiEXT(UInt32 index, UInt32 x);
            internal static VertexAttribI1uiEXT glVertexAttribI1uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
            internal static VertexAttribI2uiEXT glVertexAttribI2uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            internal static VertexAttribI3uiEXT glVertexAttribI3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4uiEXT glVertexAttribI4uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI1ivEXT glVertexAttribI1ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI2ivEXT glVertexAttribI2ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI3ivEXT glVertexAttribI3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4ivEXT glVertexAttribI4ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI1uivEXT glVertexAttribI1uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI2uivEXT glVertexAttribI2uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI3uivEXT glVertexAttribI3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uivEXT glVertexAttribI4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4bvEXT(UInt32 index, SByte* v);
            internal unsafe static VertexAttribI4bvEXT glVertexAttribI4bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4svEXT(UInt32 index, Int16* v);
            internal unsafe static VertexAttribI4svEXT glVertexAttribI4svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ubvEXT(UInt32 index, Byte* v);
            internal unsafe static VertexAttribI4ubvEXT glVertexAttribI4ubvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4usvEXT(UInt32 index, UInt16* v);
            internal unsafe static VertexAttribI4usvEXT glVertexAttribI4usvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointerEXT glVertexAttribIPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIivEXT(UInt32 index, int pname, [Out] Int32* @params);
            internal unsafe static GetVertexAttribIivEXT glGetVertexAttribIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuivEXT(UInt32 index, int pname, [Out] UInt32* @params);
            internal unsafe static GetVertexAttribIuivEXT glGetVertexAttribIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformuivEXT(UInt32 program, Int32 location, [Out] UInt32* @params);
            internal unsafe static GetUniformuivEXT glGetUniformuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocationEXT(UInt32 program, UInt32 color, System.String name);
            internal static BindFragDataLocationEXT glBindFragDataLocationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocationEXT(UInt32 program, System.String name);
            internal static GetFragDataLocationEXT glGetFragDataLocationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1uiEXT(Int32 location, UInt32 v0);
            internal static Uniform1uiEXT glUniform1uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2uiEXT glUniform2uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3uiEXT glUniform3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4uiEXT glUniform4uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uivEXT glUniform1uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uivEXT glUniform2uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uivEXT glUniform3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uivEXT glUniform4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedEXT(int mode, Int32 start, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedEXT(int mode, Int32 count, int type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBufferEXT(int target, int internalformat, UInt32 buffer);
            internal static TexBufferEXT glTexBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangedNV(Double zNear, Double zFar);
            internal static DepthRangedNV glDepthRangedNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthdNV(Double depth);
            internal static ClearDepthdNV glClearDepthdNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsdNV(Double zmin, Double zmax);
            internal static DepthBoundsdNV glDepthBoundsdNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleCoverageNV(int target, Int32 coverageSamples, Int32 colorSamples, int internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersfvNV(int target, UInt32 buffer, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramBufferParametersfvNV glProgramBufferParametersfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIivNV(int target, UInt32 buffer, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramBufferParametersIivNV glProgramBufferParametersIivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIuivNV(int target, UInt32 buffer, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramBufferParametersIuivNV glProgramBufferParametersIuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaskIndexedEXT(UInt32 index, Int32 r, Int32 g, Int32 b, Int32 a);
            internal static ColorMaskIndexedEXT glColorMaskIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanIndexedvEXT(int target, UInt32 index, [Out] Int32* data);
            internal unsafe static GetBooleanIndexedvEXT glGetBooleanIndexedvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerIndexedvEXT(int target, UInt32 index, [Out] Int32* data);
            internal unsafe static GetIntegerIndexedvEXT glGetIntegerIndexedvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableIndexedEXT(int target, UInt32 index);
            internal static EnableIndexedEXT glEnableIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableIndexedEXT(int target, UInt32 index);
            internal static DisableIndexedEXT glDisableIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 IsEnabledIndexedEXT(int target, UInt32 index);
            internal static IsEnabledIndexedEXT glIsEnabledIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedbackNV(int primitiveMode);
            internal static BeginTransformFeedbackNV glBeginTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedbackNV();
            internal static EndTransformFeedbackNV glEndTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackAttribsNV(UInt32 count, Int32* attribs, int bufferMode);
            internal unsafe static TransformFeedbackAttribsNV glTransformFeedbackAttribsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRangeNV(int target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRangeNV glBindBufferRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferOffsetNV(int target, UInt32 index, UInt32 buffer, IntPtr offset);
            internal static BindBufferOffsetNV glBindBufferOffsetNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBaseNV(int target, UInt32 index, UInt32 buffer);
            internal static BindBufferBaseNV glBindBufferBaseNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, int bufferMode);
            internal unsafe static TransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveVaryingNV(UInt32 program, System.String name);
            internal static ActiveVaryingNV glActiveVaryingNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetVaryingLocationNV(UInt32 program, System.String name);
            internal static GetVaryingLocationNV glGetVaryingLocationNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            internal unsafe static GetActiveVaryingNV glGetActiveVaryingNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, [Out] Int32* location);
            internal unsafe static GetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
            internal static UniformBufferEXT glUniformBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location);
            internal static GetUniformBufferSizeEXT glGetUniformBufferSizeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location);
            internal static GetUniformOffsetEXT glGetUniformOffsetEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIivEXT(int target, int pname, Int32* @params);
            internal unsafe static TexParameterIivEXT glTexParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIuivEXT(int target, int pname, UInt32* @params);
            internal unsafe static TexParameterIuivEXT glTexParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIivEXT(int target, int pname, [Out] Int32* @params);
            internal unsafe static GetTexParameterIivEXT glGetTexParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIuivEXT(int target, int pname, [Out] UInt32* @params);
            internal unsafe static GetTexParameterIuivEXT glGetTexParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static ClearColorIiEXT glClearColorIiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            internal static ClearColorIuiEXT glClearColorIuiEXT;
        }
    }
    #pragma warning restore 0649
}
