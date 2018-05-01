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

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.Graphics.ES10
{
#pragma warning disable 3019
#pragma warning disable 1591

    partial class GL
    {
        internal static class Core
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal static extern void ActiveTexture(All texture);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
            internal static extern void AlphaFunc(All func, float @ref);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glAlphaFuncx", ExactSpelling = true)]
            internal static extern void AlphaFuncx(All func, int @ref);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal static extern void BindTexture(All target, uint texture);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal static extern void BlendFunc(All sfactor, All dfactor);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal static extern void Clear(uint mask);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal static extern void ClearColor(float red, float green, float blue, float alpha);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glClearColorx", ExactSpelling = true)]
            internal static extern void ClearColorx(int red, int green, int blue, int alpha);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal static extern void ClearDepthf(float depth);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glClearDepthx", ExactSpelling = true)]
            internal static extern void ClearDepthx(int depth);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal static extern void ClearStencil(int s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
            internal static extern void ClientActiveTexture(All texture);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glColor4f", ExactSpelling = true)]
            internal static extern void Color4f(float red, float green, float blue, float alpha);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glColor4x", ExactSpelling = true)]
            internal static extern void Color4x(int red, int green, int blue, int alpha);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal static extern void ColorMask(bool red, bool green, bool blue, bool alpha);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
            internal static extern void ColorPointer(int size, All type, int stride, IntPtr pointer);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal static extern void CompressedTexImage2D(All target, int level, All internalformat, int width,
                int height, int border, int imageSize, IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal static extern void CompressedTexSubImage2D(All target, int level, int xoffset, int yoffset,
                int width, int height, All format, int imageSize, IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal static extern void CopyTexImage2D(All target, int level, All internalformat, int x, int y,
                int width, int height, int border);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal static extern void CopyTexSubImage2D(All target, int level, int xoffset, int yoffset, int x, int y,
                int width, int height);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal static extern void CullFace(All mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal static extern unsafe void DeleteTextures(int n, uint* textures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal static extern void DepthFunc(All func);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal static extern void DepthMask(bool flag);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal static extern void DepthRangef(float zNear, float zFar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDepthRangex", ExactSpelling = true)]
            internal static extern void DepthRangex(int zNear, int zFar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal static extern void Disable(All cap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
            internal static extern void DisableClientState(All array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal static extern void DrawArrays(All mode, int first, int count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal static extern void DrawElements(All mode, int count, All type, IntPtr indices);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal static extern void Enable(All cap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
            internal static extern void EnableClientState(All array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal static extern void Finish();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal static extern void Flush();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFogf", ExactSpelling = true)]
            internal static extern void Fogf(All pname, float param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFogfv", ExactSpelling = true)]
            internal static extern unsafe void Fogfv(All pname, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFogx", ExactSpelling = true)]
            internal static extern void Fogx(All pname, int param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFogxv", ExactSpelling = true)]
            internal static extern unsafe void Fogxv(All pname, int* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal static extern void FrontFace(All mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFrustumf", ExactSpelling = true)]
            internal static extern void Frustumf(float left, float right, float bottom, float top, float zNear,
                float zFar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glFrustumx", ExactSpelling = true)]
            internal static extern void Frustumx(int left, int right, int bottom, int top, int zNear, int zFar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal static extern unsafe void GenTextures(int n, uint* textures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal static extern All GetError();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal static extern unsafe void GetIntegerv(All pname, int* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal static extern IntPtr GetString(All name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal static extern void Hint(All target, All mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightf", ExactSpelling = true)]
            internal static extern void Lightf(All light, All pname, float param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightfv", ExactSpelling = true)]
            internal static extern unsafe void Lightfv(All light, All pname, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
            internal static extern void LightModelf(All pname, float param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
            internal static extern unsafe void LightModelfv(All pname, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightModelx", ExactSpelling = true)]
            internal static extern void LightModelx(All pname, int param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightModelxv", ExactSpelling = true)]
            internal static extern unsafe void LightModelxv(All pname, int* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightx", ExactSpelling = true)]
            internal static extern void Lightx(All light, All pname, int param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLightxv", ExactSpelling = true)]
            internal static extern unsafe void Lightxv(All light, All pname, int* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal static extern void LineWidth(float width);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLineWidthx", ExactSpelling = true)]
            internal static extern void LineWidthx(int width);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
            internal static extern void LoadIdentity();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
            internal static extern unsafe void LoadMatrixf(float* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLoadMatrixx", ExactSpelling = true)]
            internal static extern unsafe void LoadMatrixx(int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal static extern void LogicOp(All opcode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
            internal static extern void Materialf(All face, All pname, float param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
            internal static extern unsafe void Materialfv(All face, All pname, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMaterialx", ExactSpelling = true)]
            internal static extern void Materialx(All face, All pname, int param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMaterialxv", ExactSpelling = true)]
            internal static extern unsafe void Materialxv(All face, All pname, int* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
            internal static extern void MatrixMode(All mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
            internal static extern void MultiTexCoord4f(All target, float s, float t, float r, float q);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4x", ExactSpelling = true)]
            internal static extern void MultiTexCoord4x(All target, int s, int t, int r, int q);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
            internal static extern unsafe void MultMatrixf(float* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glMultMatrixx", ExactSpelling = true)]
            internal static extern unsafe void MultMatrixx(int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
            internal static extern void Normal3f(float nx, float ny, float nz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glNormal3x", ExactSpelling = true)]
            internal static extern void Normal3x(int nx, int ny, int nz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
            internal static extern void NormalPointer(All type, int stride, IntPtr pointer);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glOrthof", ExactSpelling = true)]
            internal static extern void Orthof(float left, float right, float bottom, float top, float zNear,
                float zFar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glOrthox", ExactSpelling = true)]
            internal static extern void Orthox(int left, int right, int bottom, int top, int zNear, int zFar);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal static extern void PixelStorei(All pname, int param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal static extern void PointSize(float size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glPointSizex", ExactSpelling = true)]
            internal static extern void PointSizex(int size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal static extern void PolygonOffset(float factor, float units);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glPolygonOffsetx", ExactSpelling = true)]
            internal static extern void PolygonOffsetx(int factor, int units);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
            internal static extern void PopMatrix();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
            internal static extern void PushMatrix();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal static extern void ReadPixels(int x, int y, int width, int height, All format, All type,
                IntPtr pixels);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glRotatef", ExactSpelling = true)]
            internal static extern void Rotatef(float angle, float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glRotatex", ExactSpelling = true)]
            internal static extern void Rotatex(int angle, int x, int y, int z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal static extern void SampleCoverage(float value, bool invert);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glSampleCoveragex", ExactSpelling = true)]
            internal static extern void SampleCoveragex(int value, bool invert);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glScalef", ExactSpelling = true)]
            internal static extern void Scalef(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glScalex", ExactSpelling = true)]
            internal static extern void Scalex(int x, int y, int z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal static extern void Scissor(int x, int y, int width, int height);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
            internal static extern void ShadeModel(All mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal static extern void StencilFunc(All func, int @ref, uint mask);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal static extern void StencilMask(uint mask);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal static extern void StencilOp(All fail, All zfail, All zpass);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
            internal static extern void TexCoordPointer(int size, All type, int stride, IntPtr pointer);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
            internal static extern void TexEnvf(All target, All pname, float param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
            internal static extern unsafe void TexEnvfv(All target, All pname, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexEnvx", ExactSpelling = true)]
            internal static extern void TexEnvx(All target, All pname, int param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexEnvxv", ExactSpelling = true)]
            internal static extern unsafe void TexEnvxv(All target, All pname, int* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal static extern void TexImage2D(All target, int level, int internalformat, int width, int height,
                int border, All format, All type, IntPtr pixels);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal static extern void TexParameterf(All target, All pname, float param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexParameterx", ExactSpelling = true)]
            internal static extern void TexParameterx(All target, All pname, int param);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal static extern void TexSubImage2D(All target, int level, int xoffset, int yoffset, int width,
                int height, All format, All type, IntPtr pixels);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
            internal static extern void Translatef(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glTranslatex", ExactSpelling = true)]
            internal static extern void Translatex(int x, int y, int z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
            internal static extern void VertexPointer(int size, All type, int stride, IntPtr pointer);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal static extern void Viewport(int x, int y, int width, int height);
        }
    }
}