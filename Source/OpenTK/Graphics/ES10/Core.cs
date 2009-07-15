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

namespace OpenTK.Graphics.ES10
{
        using System;
        using System.Runtime.InteropServices;
        #pragma warning disable 3019
        #pragma warning disable 1591

    partial class ES
        {

        internal static partial class Core
                {

                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture([In, Out] OpenTK.Graphics.ES10.All texture);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
            internal extern static void AlphaFunc([In, Out] OpenTK.Graphics.ES10.All func, [In, Out] Single @ref);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glAlphaFuncx", ExactSpelling = true)]
            internal extern static void AlphaFuncx([In, Out] OpenTK.Graphics.ES10.All func, [In, Out] int @ref);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] UInt32 texture);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc([In, Out] OpenTK.Graphics.ES10.All sfactor, [In, Out] OpenTK.Graphics.ES10.All dfactor);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear([In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearColorx", ExactSpelling = true)]
            internal extern static void ClearColorx([In, Out] int red, [In, Out] int green, [In, Out] int blue, [In, Out] int alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal extern static void ClearDepthf([In, Out] Single depth);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearDepthx", ExactSpelling = true)]
            internal extern static void ClearDepthx([In, Out] int depth);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil([In, Out] Int32 s);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
            internal extern static void ClientActiveTexture([In, Out] OpenTK.Graphics.ES10.All texture);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glColor4f", ExactSpelling = true)]
            internal extern static void Color4f([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glColor4x", ExactSpelling = true)]
            internal extern static void Color4x([In, Out] int red, [In, Out] int green, [In, Out] int blue, [In, Out] int alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask([In, Out] bool red, [In, Out] bool green, [In, Out] bool blue, [In, Out] bool alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
            internal extern static void ColorPointer([In, Out] Int32 size, [In, Out] OpenTK.Graphics.ES10.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES10.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES10.All format, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES10.All internalformat, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace([In, Out] OpenTK.Graphics.ES10.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal extern static unsafe void DeleteTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal extern static void DepthFunc([In, Out] OpenTK.Graphics.ES10.All func);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask([In, Out] bool flag);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal extern static void DepthRangef([In, Out] Single zNear, [In, Out] Single zFar);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDepthRangex", ExactSpelling = true)]
            internal extern static void DepthRangex([In, Out] int zNear, [In, Out] int zFar);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable([In, Out] OpenTK.Graphics.ES10.All cap);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
            internal extern static void DisableClientState([In, Out] OpenTK.Graphics.ES10.All array);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays([In, Out] OpenTK.Graphics.ES10.All mode, [In, Out] Int32 first, [In, Out] Int32 count);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements([In, Out] OpenTK.Graphics.ES10.All mode, [In, Out] Int32 count, [In, Out] OpenTK.Graphics.ES10.All type, [In, Out] IntPtr indices);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable([In, Out] OpenTK.Graphics.ES10.All cap);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
            internal extern static void EnableClientState([In, Out] OpenTK.Graphics.ES10.All array);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal extern static void Finish();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal extern static void Flush();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFogf", ExactSpelling = true)]
            internal extern static void Fogf([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFogfv", ExactSpelling = true)]
            internal extern static unsafe void Fogfv([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFogx", ExactSpelling = true)]
            internal extern static void Fogx([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFogxv", ExactSpelling = true)]
            internal extern static unsafe void Fogxv([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace([In, Out] OpenTK.Graphics.ES10.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFrustumf", ExactSpelling = true)]
            internal extern static void Frustumf([In, Out] Single left, [In, Out] Single right, [In, Out] Single bottom, [In, Out] Single top, [In, Out] Single zNear, [In, Out] Single zFar);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFrustumx", ExactSpelling = true)]
            internal extern static void Frustumx([In, Out] int left, [In, Out] int right, [In, Out] int bottom, [In, Out] int top, [In, Out] int zNear, [In, Out] int zFar);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static unsafe void GenTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES10.All GetError();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerv([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static unsafe IntPtr GetString([In, Out] OpenTK.Graphics.ES10.All name);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] OpenTK.Graphics.ES10.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightf", ExactSpelling = true)]
            internal extern static void Lightf([In, Out] OpenTK.Graphics.ES10.All light, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightfv", ExactSpelling = true)]
            internal extern static unsafe void Lightfv([In, Out] OpenTK.Graphics.ES10.All light, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
            internal extern static void LightModelf([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
            internal extern static unsafe void LightModelfv([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightModelx", ExactSpelling = true)]
            internal extern static void LightModelx([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightModelxv", ExactSpelling = true)]
            internal extern static unsafe void LightModelxv([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightx", ExactSpelling = true)]
            internal extern static void Lightx([In, Out] OpenTK.Graphics.ES10.All light, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLightxv", ExactSpelling = true)]
            internal extern static unsafe void Lightxv([In, Out] OpenTK.Graphics.ES10.All light, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth([In, Out] Single width);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLineWidthx", ExactSpelling = true)]
            internal extern static void LineWidthx([In, Out] int width);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
            internal extern static void LoadIdentity();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixf([In, Out] Single* m);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLoadMatrixx", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixx([In, Out] int* m);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal extern static void LogicOp([In, Out] OpenTK.Graphics.ES10.All opcode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
            internal extern static void Materialf([In, Out] OpenTK.Graphics.ES10.All face, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
            internal extern static unsafe void Materialfv([In, Out] OpenTK.Graphics.ES10.All face, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMaterialx", ExactSpelling = true)]
            internal extern static void Materialx([In, Out] OpenTK.Graphics.ES10.All face, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMaterialxv", ExactSpelling = true)]
            internal extern static unsafe void Materialxv([In, Out] OpenTK.Graphics.ES10.All face, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
            internal extern static void MatrixMode([In, Out] OpenTK.Graphics.ES10.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
            internal extern static void MultiTexCoord4f([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] Single s, [In, Out] Single t, [In, Out] Single r, [In, Out] Single q);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMultiTexCoord4x", ExactSpelling = true)]
            internal extern static void MultiTexCoord4x([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] int s, [In, Out] int t, [In, Out] int r, [In, Out] int q);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixf([In, Out] Single* m);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glMultMatrixx", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixx([In, Out] int* m);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
            internal extern static void Normal3f([In, Out] Single nx, [In, Out] Single ny, [In, Out] Single nz);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glNormal3x", ExactSpelling = true)]
            internal extern static void Normal3x([In, Out] int nx, [In, Out] int ny, [In, Out] int nz);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
            internal extern static void NormalPointer([In, Out] OpenTK.Graphics.ES10.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glOrthof", ExactSpelling = true)]
            internal extern static void Orthof([In, Out] Single left, [In, Out] Single right, [In, Out] Single bottom, [In, Out] Single top, [In, Out] Single zNear, [In, Out] Single zFar);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glOrthox", ExactSpelling = true)]
            internal extern static void Orthox([In, Out] int left, [In, Out] int right, [In, Out] int bottom, [In, Out] int top, [In, Out] int zNear, [In, Out] int zFar);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei([In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Int32 param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal extern static void PointSize([In, Out] Single size);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPointSizex", ExactSpelling = true)]
            internal extern static void PointSizex([In, Out] int size);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal extern static void PolygonOffset([In, Out] Single factor, [In, Out] Single units);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPolygonOffsetx", ExactSpelling = true)]
            internal extern static void PolygonOffsetx([In, Out] int factor, [In, Out] int units);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
            internal extern static void PopMatrix();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
            internal extern static void PushMatrix();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES10.All format, [In, Out] OpenTK.Graphics.ES10.All type, [In, Out] IntPtr pixels);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glRotatef", ExactSpelling = true)]
            internal extern static void Rotatef([In, Out] Single angle, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glRotatex", ExactSpelling = true)]
            internal extern static void Rotatex([In, Out] int angle, [In, Out] int x, [In, Out] int y, [In, Out] int z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage([In, Out] Single value, [In, Out] bool invert);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glSampleCoveragex", ExactSpelling = true)]
            internal extern static void SampleCoveragex([In, Out] int value, [In, Out] bool invert);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glScalef", ExactSpelling = true)]
            internal extern static void Scalef([In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glScalex", ExactSpelling = true)]
            internal extern static void Scalex([In, Out] int x, [In, Out] int y, [In, Out] int z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
            internal extern static void ShadeModel([In, Out] OpenTK.Graphics.ES10.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc([In, Out] OpenTK.Graphics.ES10.All func, [In, Out] Int32 @ref, [In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask([In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp([In, Out] OpenTK.Graphics.ES10.All fail, [In, Out] OpenTK.Graphics.ES10.All zfail, [In, Out] OpenTK.Graphics.ES10.All zpass);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
            internal extern static void TexCoordPointer([In, Out] Int32 size, [In, Out] OpenTK.Graphics.ES10.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
            internal extern static void TexEnvf([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
            internal extern static unsafe void TexEnvfv([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexEnvx", ExactSpelling = true)]
            internal extern static void TexEnvx([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexEnvxv", ExactSpelling = true)]
            internal extern static unsafe void TexEnvxv([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] Int32 level, [In, Out] Int32 internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] OpenTK.Graphics.ES10.All format, [In, Out] OpenTK.Graphics.ES10.All type, [In, Out] IntPtr pixels);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] Single param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexParameterx", ExactSpelling = true)]
            internal extern static void TexParameterx([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] OpenTK.Graphics.ES10.All pname, [In, Out] int param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D([In, Out] OpenTK.Graphics.ES10.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES10.All format, [In, Out] OpenTK.Graphics.ES10.All type, [In, Out] IntPtr pixels);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
            internal extern static void Translatef([In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTranslatex", ExactSpelling = true)]
            internal extern static void Translatex([In, Out] int x, [In, Out] int y, [In, Out] int z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
            internal extern static void VertexPointer([In, Out] Int32 size, [In, Out] OpenTK.Graphics.ES10.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
                }
        }
}
