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

#pragma warning disable 3019
#pragma warning disable 1591

    partial class Gl
    {

        internal static partial class Imports
        {

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNewList", ExactSpelling = true)]
            internal extern static void NewList(UInt32 list, int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndList", ExactSpelling = true)]
            internal extern static void EndList();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCallList", ExactSpelling = true)]
            internal extern static void CallList(UInt32 list);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCallLists", ExactSpelling = true)]
            internal extern static void CallLists(Int32 n, int type, IntPtr lists);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteLists", ExactSpelling = true)]
            internal extern static void DeleteLists(UInt32 list, Int32 range);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenLists", ExactSpelling = true)]
            internal extern static Int32 GenLists(Int32 range);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glListBase", ExactSpelling = true)]
            internal extern static void ListBase(UInt32 @base);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBegin", ExactSpelling = true)]
            internal extern static void Begin(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBitmap", ExactSpelling = true)]
            internal extern static unsafe void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3b", ExactSpelling = true)]
            internal extern static void Color3b(SByte red, SByte green, SByte blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3bv", ExactSpelling = true)]
            internal extern static unsafe void Color3bv(SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3d", ExactSpelling = true)]
            internal extern static void Color3d(Double red, Double green, Double blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3dv", ExactSpelling = true)]
            internal extern static unsafe void Color3dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3f", ExactSpelling = true)]
            internal extern static void Color3f(Single red, Single green, Single blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3fv", ExactSpelling = true)]
            internal extern static unsafe void Color3fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3i", ExactSpelling = true)]
            internal extern static void Color3i(Int32 red, Int32 green, Int32 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3iv", ExactSpelling = true)]
            internal extern static unsafe void Color3iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3s", ExactSpelling = true)]
            internal extern static void Color3s(Int16 red, Int16 green, Int16 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3sv", ExactSpelling = true)]
            internal extern static unsafe void Color3sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3ub", ExactSpelling = true)]
            internal extern static void Color3ub(Byte red, Byte green, Byte blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3ubv", ExactSpelling = true)]
            internal extern static unsafe void Color3ubv(Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3ui", ExactSpelling = true)]
            internal extern static void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3uiv", ExactSpelling = true)]
            internal extern static unsafe void Color3uiv(UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3us", ExactSpelling = true)]
            internal extern static void Color3us(UInt16 red, UInt16 green, UInt16 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor3usv", ExactSpelling = true)]
            internal extern static unsafe void Color3usv(UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4b", ExactSpelling = true)]
            internal extern static void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4bv", ExactSpelling = true)]
            internal extern static unsafe void Color4bv(SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4d", ExactSpelling = true)]
            internal extern static void Color4d(Double red, Double green, Double blue, Double alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4dv", ExactSpelling = true)]
            internal extern static unsafe void Color4dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4f", ExactSpelling = true)]
            internal extern static void Color4f(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4fv", ExactSpelling = true)]
            internal extern static unsafe void Color4fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4i", ExactSpelling = true)]
            internal extern static void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4iv", ExactSpelling = true)]
            internal extern static unsafe void Color4iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4s", ExactSpelling = true)]
            internal extern static void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4sv", ExactSpelling = true)]
            internal extern static unsafe void Color4sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
            internal extern static void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ubv", ExactSpelling = true)]
            internal extern static unsafe void Color4ubv(Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4ui", ExactSpelling = true)]
            internal extern static void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4uiv", ExactSpelling = true)]
            internal extern static unsafe void Color4uiv(UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4us", ExactSpelling = true)]
            internal extern static void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColor4usv", ExactSpelling = true)]
            internal extern static unsafe void Color4usv(UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
            internal extern static void EdgeFlag(Int32 flag);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
            internal extern static unsafe void EdgeFlagv(Int32* flag);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnd", ExactSpelling = true)]
            internal extern static void End();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexd", ExactSpelling = true)]
            internal extern static void Indexd(Double c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexdv", ExactSpelling = true)]
            internal extern static unsafe void Indexdv(Double* c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexf", ExactSpelling = true)]
            internal extern static void Indexf(Single c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexfv", ExactSpelling = true)]
            internal extern static unsafe void Indexfv(Single* c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexi", ExactSpelling = true)]
            internal extern static void Indexi(Int32 c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexiv", ExactSpelling = true)]
            internal extern static unsafe void Indexiv(Int32* c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexs", ExactSpelling = true)]
            internal extern static void Indexs(Int16 c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexsv", ExactSpelling = true)]
            internal extern static unsafe void Indexsv(Int16* c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3b", ExactSpelling = true)]
            internal extern static void Normal3b(SByte nx, SByte ny, SByte nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3bv", ExactSpelling = true)]
            internal extern static unsafe void Normal3bv(SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3d", ExactSpelling = true)]
            internal extern static void Normal3d(Double nx, Double ny, Double nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3dv", ExactSpelling = true)]
            internal extern static unsafe void Normal3dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
            internal extern static void Normal3f(Single nx, Single ny, Single nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3fv", ExactSpelling = true)]
            internal extern static unsafe void Normal3fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3i", ExactSpelling = true)]
            internal extern static void Normal3i(Int32 nx, Int32 ny, Int32 nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3iv", ExactSpelling = true)]
            internal extern static unsafe void Normal3iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3s", ExactSpelling = true)]
            internal extern static void Normal3s(Int16 nx, Int16 ny, Int16 nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormal3sv", ExactSpelling = true)]
            internal extern static unsafe void Normal3sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
            internal extern static void RasterPos2d(Double x, Double y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
            internal extern static void RasterPos2f(Single x, Single y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
            internal extern static void RasterPos2i(Int32 x, Int32 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
            internal extern static void RasterPos2s(Int16 x, Int16 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
            internal extern static void RasterPos3d(Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
            internal extern static void RasterPos3f(Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
            internal extern static void RasterPos3i(Int32 x, Int32 y, Int32 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
            internal extern static void RasterPos3s(Int16 x, Int16 y, Int16 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
            internal extern static void RasterPos4d(Double x, Double y, Double z, Double w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
            internal extern static void RasterPos4f(Single x, Single y, Single z, Single w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
            internal extern static void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
            internal extern static void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectd", ExactSpelling = true)]
            internal extern static void Rectd(Double x1, Double y1, Double x2, Double y2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectdv", ExactSpelling = true)]
            internal extern static unsafe void Rectdv(Double* v1, Double* v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectf", ExactSpelling = true)]
            internal extern static void Rectf(Single x1, Single y1, Single x2, Single y2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectfv", ExactSpelling = true)]
            internal extern static unsafe void Rectfv(Single* v1, Single* v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRecti", ExactSpelling = true)]
            internal extern static void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectiv", ExactSpelling = true)]
            internal extern static unsafe void Rectiv(Int32* v1, Int32* v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRects", ExactSpelling = true)]
            internal extern static void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRectsv", ExactSpelling = true)]
            internal extern static unsafe void Rectsv(Int16* v1, Int16* v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
            internal extern static void TexCoord1d(Double s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
            internal extern static void TexCoord1f(Single s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
            internal extern static void TexCoord1i(Int32 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
            internal extern static void TexCoord1s(Int16 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
            internal extern static void TexCoord2d(Double s, Double t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
            internal extern static void TexCoord2f(Single s, Single t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
            internal extern static void TexCoord2i(Int32 s, Int32 t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
            internal extern static void TexCoord2s(Int16 s, Int16 t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
            internal extern static void TexCoord3d(Double s, Double t, Double r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
            internal extern static void TexCoord3f(Single s, Single t, Single r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
            internal extern static void TexCoord3i(Int32 s, Int32 t, Int32 r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
            internal extern static void TexCoord3s(Int16 s, Int16 t, Int16 r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
            internal extern static void TexCoord4d(Double s, Double t, Double r, Double q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
            internal extern static void TexCoord4f(Single s, Single t, Single r, Single q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
            internal extern static void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
            internal extern static void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2d", ExactSpelling = true)]
            internal extern static void Vertex2d(Double x, Double y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2dv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2f", ExactSpelling = true)]
            internal extern static void Vertex2f(Single x, Single y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2fv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2i", ExactSpelling = true)]
            internal extern static void Vertex2i(Int32 x, Int32 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2iv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2s", ExactSpelling = true)]
            internal extern static void Vertex2s(Int16 x, Int16 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex2sv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3d", ExactSpelling = true)]
            internal extern static void Vertex3d(Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3dv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3f", ExactSpelling = true)]
            internal extern static void Vertex3f(Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3fv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3i", ExactSpelling = true)]
            internal extern static void Vertex3i(Int32 x, Int32 y, Int32 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3iv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3s", ExactSpelling = true)]
            internal extern static void Vertex3s(Int16 x, Int16 y, Int16 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex3sv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4d", ExactSpelling = true)]
            internal extern static void Vertex4d(Double x, Double y, Double z, Double w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4dv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4f", ExactSpelling = true)]
            internal extern static void Vertex4f(Single x, Single y, Single z, Single w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4fv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4i", ExactSpelling = true)]
            internal extern static void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4iv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4s", ExactSpelling = true)]
            internal extern static void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertex4sv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClipPlane", ExactSpelling = true)]
            internal extern static unsafe void ClipPlane(int plane, Double* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorMaterial", ExactSpelling = true)]
            internal extern static void ColorMaterial(int face, int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogf", ExactSpelling = true)]
            internal extern static void Fogf(int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogfv", ExactSpelling = true)]
            internal extern static unsafe void Fogfv(int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogi", ExactSpelling = true)]
            internal extern static void Fogi(int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogiv", ExactSpelling = true)]
            internal extern static unsafe void Fogiv(int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint(int target, int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightf", ExactSpelling = true)]
            internal extern static void Lightf(int light, int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightfv", ExactSpelling = true)]
            internal extern static unsafe void Lightfv(int light, int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLighti", ExactSpelling = true)]
            internal extern static void Lighti(int light, int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightiv", ExactSpelling = true)]
            internal extern static unsafe void Lightiv(int light, int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
            internal extern static void LightModelf(int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
            internal extern static unsafe void LightModelfv(int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModeli", ExactSpelling = true)]
            internal extern static void LightModeli(int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLightModeliv", ExactSpelling = true)]
            internal extern static unsafe void LightModeliv(int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLineStipple", ExactSpelling = true)]
            internal extern static void LineStipple(Int32 factor, UInt16 pattern);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth(Single width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
            internal extern static void Materialf(int face, int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
            internal extern static unsafe void Materialfv(int face, int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMateriali", ExactSpelling = true)]
            internal extern static void Materiali(int face, int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMaterialiv", ExactSpelling = true)]
            internal extern static unsafe void Materialiv(int face, int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal extern static void PointSize(Single size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
            internal extern static void PolygonMode(int face, int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
            internal extern static unsafe void PolygonStipple(Byte* mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
            internal extern static void ShadeModel(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf(int target, int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterfv(int target, int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal extern static void TexParameteri(int target, int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void TexParameteriv(int target, int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
            internal extern static void TexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
            internal extern static void TexEnvf(int target, int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
            internal extern static unsafe void TexEnvfv(int target, int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
            internal extern static void TexEnvi(int target, int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
            internal extern static unsafe void TexEnviv(int target, int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGend", ExactSpelling = true)]
            internal extern static void TexGend(int coord, int pname, Double param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGendv", ExactSpelling = true)]
            internal extern static unsafe void TexGendv(int coord, int pname, Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGenf", ExactSpelling = true)]
            internal extern static void TexGenf(int coord, int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGenfv", ExactSpelling = true)]
            internal extern static unsafe void TexGenfv(int coord, int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGeni", ExactSpelling = true)]
            internal extern static void TexGeni(int coord, int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexGeniv", ExactSpelling = true)]
            internal extern static unsafe void TexGeniv(int coord, int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
            internal extern static unsafe void FeedbackBuffer(Int32 size, int type, [Out] Single* buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
            internal extern static unsafe void SelectBuffer(Int32 size, [Out] UInt32* buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRenderMode", ExactSpelling = true)]
            internal extern static Int32 RenderMode(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInitNames", ExactSpelling = true)]
            internal extern static void InitNames();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadName", ExactSpelling = true)]
            internal extern static void LoadName(UInt32 name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPassThrough", ExactSpelling = true)]
            internal extern static void PassThrough(Single token);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopName", ExactSpelling = true)]
            internal extern static void PopName();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushName", ExactSpelling = true)]
            internal extern static void PushName(UInt32 name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
            internal extern static void DrawBuffer(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear(int mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearAccum", ExactSpelling = true)]
            internal extern static void ClearAccum(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearIndex", ExactSpelling = true)]
            internal extern static void ClearIndex(Single c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil(Int32 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
            internal extern static void ClearDepth(Double depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask(UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask(Int32 flag);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexMask", ExactSpelling = true)]
            internal extern static void IndexMask(UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAccum", ExactSpelling = true)]
            internal extern static void Accum(int op, Single value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable(int cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable(int cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal extern static void Finish();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal extern static void Flush();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopAttrib", ExactSpelling = true)]
            internal extern static void PopAttrib();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushAttrib", ExactSpelling = true)]
            internal extern static void PushAttrib(int mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap1d", ExactSpelling = true)]
            internal extern static unsafe void Map1d(int target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap1f", ExactSpelling = true)]
            internal extern static unsafe void Map1f(int target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap2d", ExactSpelling = true)]
            internal extern static unsafe void Map2d(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMap2f", ExactSpelling = true)]
            internal extern static unsafe void Map2f(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
            internal extern static void MapGrid1d(Int32 un, Double u1, Double u2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
            internal extern static void MapGrid1f(Int32 un, Single u1, Single u2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
            internal extern static void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
            internal extern static void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
            internal extern static void EvalCoord1d(Double u);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord1dv(Double* u);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
            internal extern static void EvalCoord1f(Single u);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord1fv(Single* u);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
            internal extern static void EvalCoord2d(Double u, Double v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord2dv(Double* u);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
            internal extern static void EvalCoord2f(Single u, Single v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord2fv(Single* u);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
            internal extern static void EvalMesh1(int mode, Int32 i1, Int32 i2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
            internal extern static void EvalPoint1(Int32 i);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
            internal extern static void EvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
            internal extern static void EvalPoint2(Int32 i, Int32 j);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
            internal extern static void AlphaFunc(int func, Single @ref);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc(int sfactor, int dfactor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal extern static void LogicOp(int opcode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc(int func, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp(int fail, int zfail, int zpass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal extern static void DepthFunc(int func);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelZoom", ExactSpelling = true)]
            internal extern static void PixelZoom(Single xfactor, Single yfactor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
            internal extern static void PixelTransferf(int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
            internal extern static void PixelTransferi(int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
            internal extern static void PixelStoref(int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei(int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
            internal extern static unsafe void PixelMapfv(int map, Int32 mapsize, Single* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
            internal extern static unsafe void PixelMapuiv(int map, Int32 mapsize, UInt32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
            internal extern static unsafe void PixelMapusv(int map, Int32 mapsize, UInt16* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
            internal extern static void ReadBuffer(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyPixels", ExactSpelling = true)]
            internal extern static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, [Out] IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawPixels", ExactSpelling = true)]
            internal extern static void DrawPixels(Int32 width, Int32 height, int format, int type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal extern static unsafe void GetBooleanv(int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
            internal extern static unsafe void GetClipPlane(int plane, [Out] Double* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
            internal extern static unsafe void GetDoublev(int pname, [Out] Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static int GetError();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal extern static unsafe void GetFloatv(int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerv(int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
            internal extern static unsafe void GetLightfv(int light, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetLightiv", ExactSpelling = true)]
            internal extern static unsafe void GetLightiv(int light, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapdv", ExactSpelling = true)]
            internal extern static unsafe void GetMapdv(int target, int query, [Out] Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapfv", ExactSpelling = true)]
            internal extern static unsafe void GetMapfv(int target, int query, [Out] Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMapiv", ExactSpelling = true)]
            internal extern static unsafe void GetMapiv(int target, int query, [Out] Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
            internal extern static unsafe void GetMaterialfv(int face, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
            internal extern static unsafe void GetMaterialiv(int face, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
            internal extern static unsafe void GetPixelMapfv(int map, [Out] Single* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
            internal extern static unsafe void GetPixelMapuiv(int map, [Out] UInt32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
            internal extern static unsafe void GetPixelMapusv(int map, [Out] UInt16* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
            internal extern static unsafe void GetPolygonStipple([Out] Byte* mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(int name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnvfv(int target, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnviv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
            internal extern static unsafe void GetTexGendv(int coord, int pname, [Out] Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexGenfv(int coord, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
            internal extern static unsafe void GetTexGeniv(int coord, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
            internal extern static void GetTexImage(int target, Int32 level, int format, int type, [Out] IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterfv(int target, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameteriv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexLevelParameterfv(int target, Int32 level, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexLevelParameteriv(int target, Int32 level, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal extern static Int32 IsEnabled(int cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsList", ExactSpelling = true)]
            internal extern static Int32 IsList(UInt32 list);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
            internal extern static void DepthRange(Double near, Double far);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFrustum", ExactSpelling = true)]
            internal extern static void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
            internal extern static void LoadIdentity();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixf(Single* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixd(Double* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
            internal extern static void MatrixMode(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixf(Single* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixd(Double* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glOrtho", ExactSpelling = true)]
            internal extern static void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
            internal extern static void PopMatrix();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
            internal extern static void PushMatrix();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRotated", ExactSpelling = true)]
            internal extern static void Rotated(Double angle, Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRotatef", ExactSpelling = true)]
            internal extern static void Rotatef(Single angle, Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScaled", ExactSpelling = true)]
            internal extern static void Scaled(Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScalef", ExactSpelling = true)]
            internal extern static void Scalef(Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTranslated", ExactSpelling = true)]
            internal extern static void Translated(Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
            internal extern static void Translatef(Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glArrayElement", ExactSpelling = true)]
            internal extern static void ArrayElement(Int32 i);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
            internal extern static void ColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
            internal extern static void DisableClientState(int array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays(int mode, Int32 first, Int32 count);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements(int mode, Int32 count, int type, IntPtr indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
            internal extern static void EdgeFlagPointer(Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
            internal extern static void EnableClientState(int array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal extern static void GetPointerv(int pname, [Out] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexPointer", ExactSpelling = true)]
            internal extern static void IndexPointer(int type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
            internal extern static void InterleavedArrays(int format, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
            internal extern static void NormalPointer(int type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
            internal extern static void TexCoordPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
            internal extern static void VertexPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal extern static void PolygonOffset(Single factor, Single units);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
            internal extern static void CopyTexImage1D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
            internal extern static void TexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
            internal extern static unsafe Int32 AreTexturesResident(Int32 n, UInt32* textures, [Out] Int32* residences);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture(int target, UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal extern static unsafe void DeleteTextures(Int32 n, UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static unsafe void GenTextures(Int32 n, [Out] UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal extern static Int32 IsTexture(UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
            internal extern static unsafe void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexub", ExactSpelling = true)]
            internal extern static void Indexub(Byte c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIndexubv", ExactSpelling = true)]
            internal extern static unsafe void Indexubv(Byte* c);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
            internal extern static void PopClientAttrib();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
            internal extern static void PushClientAttrib(int mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal extern static void BlendColor(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal extern static void BlendEquation(int mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
            internal extern static void DrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTable", ExactSpelling = true)]
            internal extern static void ColorTable(int target, int internalformat, Int32 width, int format, int type, IntPtr table);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameterfv(int target, int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameteriv(int target, int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyColorTable", ExactSpelling = true)]
            internal extern static void CopyColorTable(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTable", ExactSpelling = true)]
            internal extern static void GetColorTable(int target, int format, int type, [Out] IntPtr table);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameterfv(int target, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameteriv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorSubTable", ExactSpelling = true)]
            internal extern static void ColorSubTable(int target, Int32 start, Int32 count, int format, int type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
            internal extern static void CopyColorSubTable(int target, Int32 start, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
            internal extern static void ConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
            internal extern static void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
            internal extern static void ConvolutionParameterf(int target, int pname, Single @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameterfv(int target, int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
            internal extern static void ConvolutionParameteri(int target, int pname, Int32 @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameteriv(int target, int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter1D(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter2D(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
            internal extern static void GetConvolutionFilter(int target, int format, int type, [Out] IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameterfv(int target, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameteriv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
            internal extern static void GetSeparableFilter(int target, int format, int type, [Out] IntPtr row, [Out] IntPtr column, [Out] IntPtr span);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
            internal extern static void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr row, IntPtr column);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogram", ExactSpelling = true)]
            internal extern static void GetHistogram(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameterfv(int target, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameteriv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmax", ExactSpelling = true)]
            internal extern static void GetMinmax(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameterfv(int target, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameteriv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glHistogram", ExactSpelling = true)]
            internal extern static void Histogram(int target, Int32 width, int internalformat, Int32 sink);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMinmax", ExactSpelling = true)]
            internal extern static void Minmax(int target, int internalformat, Int32 sink);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glResetHistogram", ExactSpelling = true)]
            internal extern static void ResetHistogram(int target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glResetMinmax", ExactSpelling = true)]
            internal extern static void ResetMinmax(int target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
            internal extern static void TexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
            internal extern static void TexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture(int texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
            internal extern static void ClientActiveTexture(int texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1d", ExactSpelling = true)]
            internal extern static void MultiTexCoord1d(int target, Double s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1dv(int target, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1f", ExactSpelling = true)]
            internal extern static void MultiTexCoord1f(int target, Single s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1fv(int target, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1i", ExactSpelling = true)]
            internal extern static void MultiTexCoord1i(int target, Int32 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1iv(int target, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1s", ExactSpelling = true)]
            internal extern static void MultiTexCoord1s(int target, Int16 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord1sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1sv(int target, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2d", ExactSpelling = true)]
            internal extern static void MultiTexCoord2d(int target, Double s, Double t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2dv(int target, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2f", ExactSpelling = true)]
            internal extern static void MultiTexCoord2f(int target, Single s, Single t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2fv(int target, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2i", ExactSpelling = true)]
            internal extern static void MultiTexCoord2i(int target, Int32 s, Int32 t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2iv(int target, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2s", ExactSpelling = true)]
            internal extern static void MultiTexCoord2s(int target, Int16 s, Int16 t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord2sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2sv(int target, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3d", ExactSpelling = true)]
            internal extern static void MultiTexCoord3d(int target, Double s, Double t, Double r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3dv(int target, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3f", ExactSpelling = true)]
            internal extern static void MultiTexCoord3f(int target, Single s, Single t, Single r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3fv(int target, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3i", ExactSpelling = true)]
            internal extern static void MultiTexCoord3i(int target, Int32 s, Int32 t, Int32 r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3iv(int target, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3s", ExactSpelling = true)]
            internal extern static void MultiTexCoord3s(int target, Int16 s, Int16 t, Int16 r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord3sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3sv(int target, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4d", ExactSpelling = true)]
            internal extern static void MultiTexCoord4d(int target, Double s, Double t, Double r, Double q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4dv(int target, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
            internal extern static void MultiTexCoord4f(int target, Single s, Single t, Single r, Single q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4fv(int target, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4i", ExactSpelling = true)]
            internal extern static void MultiTexCoord4i(int target, Int32 s, Int32 t, Int32 r, Int32 q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4iv(int target, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4s", ExactSpelling = true)]
            internal extern static void MultiTexCoord4s(int target, Int16 s, Int16 t, Int16 r, Int16 q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiTexCoord4sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4sv(int target, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadTransposeMatrixf", ExactSpelling = true)]
            internal extern static unsafe void LoadTransposeMatrixf(Single* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLoadTransposeMatrixd", ExactSpelling = true)]
            internal extern static unsafe void LoadTransposeMatrixd(Double* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultTransposeMatrixf", ExactSpelling = true)]
            internal extern static unsafe void MultTransposeMatrixf(Single* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultTransposeMatrixd", ExactSpelling = true)]
            internal extern static unsafe void MultTransposeMatrixd(Double* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage(Single value, Int32 invert);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
            internal extern static void GetCompressedTexImage(int target, Int32 level, [Out] IntPtr img);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal extern static void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordf", ExactSpelling = true)]
            internal extern static void FogCoordf(Single coord);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordfv", ExactSpelling = true)]
            internal extern static unsafe void FogCoordfv(Single* coord);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordd", ExactSpelling = true)]
            internal extern static void FogCoordd(Double coord);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoorddv", ExactSpelling = true)]
            internal extern static unsafe void FogCoorddv(Double* coord);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFogCoordPointer", ExactSpelling = true)]
            internal extern static void FogCoordPointer(int type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawArrays(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElements(int mode, Int32* count, int type, IntPtr indices, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
            internal extern static void PointParameterf(int pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
            internal extern static unsafe void PointParameterfv(int pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
            internal extern static void PointParameteri(int pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
            internal extern static unsafe void PointParameteriv(int pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3b", ExactSpelling = true)]
            internal extern static void SecondaryColor3b(SByte red, SByte green, SByte blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3bv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3bv(SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3d", ExactSpelling = true)]
            internal extern static void SecondaryColor3d(Double red, Double green, Double blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3dv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3f", ExactSpelling = true)]
            internal extern static void SecondaryColor3f(Single red, Single green, Single blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3fv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3i", ExactSpelling = true)]
            internal extern static void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3iv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3s", ExactSpelling = true)]
            internal extern static void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3sv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ub", ExactSpelling = true)]
            internal extern static void SecondaryColor3ub(Byte red, Byte green, Byte blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ubv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3ubv(Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3ui", ExactSpelling = true)]
            internal extern static void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3uiv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3uiv(UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3us", ExactSpelling = true)]
            internal extern static void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColor3usv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3usv(UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSecondaryColorPointer", ExactSpelling = true)]
            internal extern static void SecondaryColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2d", ExactSpelling = true)]
            internal extern static void WindowPos2d(Double x, Double y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2dv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2f", ExactSpelling = true)]
            internal extern static void WindowPos2f(Single x, Single y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2fv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2i", ExactSpelling = true)]
            internal extern static void WindowPos2i(Int32 x, Int32 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2iv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2s", ExactSpelling = true)]
            internal extern static void WindowPos2s(Int16 x, Int16 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos2sv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3d", ExactSpelling = true)]
            internal extern static void WindowPos3d(Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3dv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3dv(Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3f", ExactSpelling = true)]
            internal extern static void WindowPos3f(Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3fv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3fv(Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3i", ExactSpelling = true)]
            internal extern static void WindowPos3i(Int32 x, Int32 y, Int32 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3iv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3iv(Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3s", ExactSpelling = true)]
            internal extern static void WindowPos3s(Int16 x, Int16 y, Int16 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWindowPos3sv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3sv(Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
            internal extern static unsafe void GenQueries(Int32 n, [Out] UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
            internal extern static unsafe void DeleteQueries(Int32 n, UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
            internal extern static Int32 IsQuery(UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
            internal extern static void BeginQuery(int target, UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
            internal extern static void EndQuery(int target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryiv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectiv(UInt32 id, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectuiv(UInt32 id, int pname, [Out] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal extern static void BindBuffer(int target, UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteBuffers(Int32 n, UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal extern static unsafe void GenBuffers(Int32 n, [Out] UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal extern static Int32 IsBuffer(UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal extern static void BufferData(int target, IntPtr size, IntPtr data, int usage);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal extern static void BufferSubData(int target, IntPtr offset, IntPtr size, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
            internal extern static void GetBufferSubData(int target, IntPtr offset, IntPtr size, [Out] IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
            internal extern static unsafe IntPtr MapBuffer(int target, int access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
            internal extern static Int32 UnmapBuffer(int target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteriv(int target, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
            internal extern static void GetBufferPointerv(int target, int pname, [Out] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal extern static void BlendEquationSeparate(int modeRGB, int modeAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffers(Int32 n, int* bufs);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal extern static void StencilOpSeparate(int face, int sfail, int dpfail, int dppass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal extern static void StencilFuncSeparate(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal extern static void StencilMaskSeparate(int face, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal extern static void AttachShader(UInt32 program, UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal extern static void BindAttribLocation(UInt32 program, UInt32 index, System.String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal extern static void CompileShader(UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal extern static Int32 CreateProgram();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal extern static Int32 CreateShader(int type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal extern static void DeleteProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal extern static void DeleteShader(UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal extern static void DetachShader(UInt32 program, UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal extern static void DisableVertexAttribArray(UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal extern static void EnableVertexAttribArray(UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal extern static unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal extern static unsafe void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal extern static Int32 GetAttribLocation(UInt32 program, System.String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramiv(UInt32 program, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetProgramInfoLog(UInt32 program, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal extern static unsafe void GetShaderiv(UInt32 shader, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal extern static unsafe void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetUniformLocation(UInt32 program, System.String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformfv(UInt32 program, Int32 location, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformiv(UInt32 program, Int32 location, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribdv(UInt32 index, int pname, [Out] Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribfv(UInt32 index, int pname, [Out] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribiv(UInt32 index, int pname, [Out] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointerv(UInt32 index, int pname, [Out] IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal extern static Int32 IsProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal extern static Int32 IsShader(UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal extern static void LinkProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal extern static unsafe void ShaderSource(UInt32 shader, Int32 count, System.String[] @string, Int32* length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal extern static void UseProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
            internal extern static void Uniform1f(Int32 location, Single v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
            internal extern static void Uniform2f(Int32 location, Single v0, Single v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
            internal extern static void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
            internal extern static void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
            internal extern static void Uniform1i(Int32 location, Int32 v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
            internal extern static void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
            internal extern static void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
            internal extern static void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal extern static void ValidateProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
            internal extern static void VertexAttrib1d(UInt32 index, Double x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal extern static void VertexAttrib1f(UInt32 index, Single x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
            internal extern static void VertexAttrib1s(UInt32 index, Int16 x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
            internal extern static void VertexAttrib2d(UInt32 index, Double x, Double y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal extern static void VertexAttrib2f(UInt32 index, Single x, Single y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
            internal extern static void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
            internal extern static void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal extern static void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
            internal extern static void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nbv(UInt32 index, SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Niv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nsv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nubv(UInt32 index, Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4bv(UInt32 index, SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
            internal extern static void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal extern static void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4iv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
            internal extern static void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4ubv(UInt32 index, Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4uiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4usv(UInt32 index, UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal extern static void VertexAttribPointer(UInt32 index, Int32 size, int type, Int32 normalized, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
        }
    }
}
