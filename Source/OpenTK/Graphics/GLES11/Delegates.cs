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

namespace OpenTK.Graphics.GLES11
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture([In, Out] OpenTK.Graphics.GLES11.All texture);
            internal static ActiveTexture glActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFunc([In, Out] OpenTK.Graphics.GLES11.All func, [In, Out] Single @ref);
            internal static AlphaFunc glAlphaFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFuncx([In, Out] OpenTK.Graphics.GLES11.All func, [In, Out] int @ref);
            internal static AlphaFuncx glAlphaFuncx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] UInt32 texture);
            internal static BindTexture glBindTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc([In, Out] OpenTK.Graphics.GLES11.All sfactor, [In, Out] OpenTK.Graphics.GLES11.All dfactor);
            internal static BlendFunc glBlendFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] IntPtr size, [In, Out] IntPtr data, [In, Out] OpenTK.Graphics.GLES11.All usage);
            internal static BufferData glBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] IntPtr offset, [In, Out] IntPtr size, [In, Out] IntPtr data);
            internal static BufferSubData glBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear([In, Out] UInt32 mask);
            internal static Clear glClear;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
            internal static ClearColor glClearColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorx([In, Out] int red, [In, Out] int green, [In, Out] int blue, [In, Out] int alpha);
            internal static ClearColorx glClearColorx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf([In, Out] Single depth);
            internal static ClearDepthf glClearDepthf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthx([In, Out] int depth);
            internal static ClearDepthx glClearDepthx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil([In, Out] Int32 s);
            internal static ClearStencil glClearStencil;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTexture([In, Out] OpenTK.Graphics.GLES11.All texture);
            internal static ClientActiveTexture glClientActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanef([In, Out] OpenTK.Graphics.GLES11.All plane, [In, Out] Single* equation);
            internal unsafe static ClipPlanef glClipPlanef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanex([In, Out] OpenTK.Graphics.GLES11.All plane, [In, Out] int* equation);
            internal unsafe static ClipPlanex glClipPlanex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4f([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
            internal static Color4f glColor4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ub([In, Out] Byte red, [In, Out] Byte green, [In, Out] Byte blue, [In, Out] Byte alpha);
            internal static Color4ub glColor4ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4x([In, Out] int red, [In, Out] int green, [In, Out] int blue, [In, Out] int alpha);
            internal static Color4x glColor4x;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask([In, Out] bool red, [In, Out] bool green, [In, Out] bool blue, [In, Out] bool alpha);
            internal static ColorMask glColorMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointer([In, Out] Int32 size, [In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
            internal static ColorPointer glColorPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.GLES11.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.GLES11.All format, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.GLES11.All internalformat, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace([In, Out] OpenTK.Graphics.GLES11.All mode);
            internal static CullFace glCullFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers([In, Out] Int32 n, [In, Out] UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc([In, Out] OpenTK.Graphics.GLES11.All func);
            internal static DepthFunc glDepthFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask([In, Out] bool flag);
            internal static DepthMask glDepthMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef([In, Out] Single zNear, [In, Out] Single zFar);
            internal static DepthRangef glDepthRangef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangex([In, Out] int zNear, [In, Out] int zFar);
            internal static DepthRangex glDepthRangex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable([In, Out] OpenTK.Graphics.GLES11.All cap);
            internal static Disable glDisable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientState([In, Out] OpenTK.Graphics.GLES11.All array);
            internal static DisableClientState glDisableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays([In, Out] OpenTK.Graphics.GLES11.All mode, [In, Out] Int32 first, [In, Out] Int32 count);
            internal static DrawArrays glDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements([In, Out] OpenTK.Graphics.GLES11.All mode, [In, Out] Int32 count, [In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] IntPtr indices);
            internal static DrawElements glDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable([In, Out] OpenTK.Graphics.GLES11.All cap);
            internal static Enable glEnable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientState([In, Out] OpenTK.Graphics.GLES11.All array);
            internal static EnableClientState glEnableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogf([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single param);
            internal static Fogf glFogf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogfv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static Fogfv glFogfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogx([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int param);
            internal static Fogx glFogx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogxv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static Fogxv glFogxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace([In, Out] OpenTK.Graphics.GLES11.All mode);
            internal static FrontFace glFrontFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustumf([In, Out] Single left, [In, Out] Single right, [In, Out] Single bottom, [In, Out] Single top, [In, Out] Single zNear, [In, Out] Single zFar);
            internal static Frustumf glFrustumf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustumx([In, Out] int left, [In, Out] int right, [In, Out] int bottom, [In, Out] int top, [In, Out] int zNear, [In, Out] int zFar);
            internal static Frustumx glFrustumx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers([In, Out] Int32 n, [In, Out] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] bool* @params);
            internal unsafe static GetBooleanv glGetBooleanv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlanef([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* eqn);
            internal unsafe static GetClipPlanef glGetClipPlanef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlanex([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* eqn);
            internal unsafe static GetClipPlanex glGetClipPlanex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.GLES11.All GetError();
            internal static GetError glGetError;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFixedv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static GetFixedv glGetFixedv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static GetFloatv glGetFloatv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32* @params);
            internal unsafe static GetIntegerv glGetIntegerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightfv([In, Out] OpenTK.Graphics.GLES11.All light, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static GetLightfv glGetLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightxv([In, Out] OpenTK.Graphics.GLES11.All light, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static GetLightxv glGetLightxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialfv([In, Out] OpenTK.Graphics.GLES11.All face, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialxv([In, Out] OpenTK.Graphics.GLES11.All face, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static GetMaterialxv glGetMaterialxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Byte GetString([In, Out] OpenTK.Graphics.GLES11.All name);
            internal unsafe static GetString glGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvfv([In, Out] OpenTK.Graphics.GLES11.All env, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnviv([In, Out] OpenTK.Graphics.GLES11.All env, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvxv([In, Out] OpenTK.Graphics.GLES11.All env, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static GetTexEnvxv glGetTexEnvxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterxv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static GetTexParameterxv glGetTexParameterxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All mode);
            internal static Hint glHint;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer([In, Out] UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled([In, Out] OpenTK.Graphics.GLES11.All cap);
            internal static IsEnabled glIsEnabled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTexture([In, Out] UInt32 texture);
            internal static IsTexture glIsTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lightf([In, Out] OpenTK.Graphics.GLES11.All light, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single param);
            internal static Lightf glLightf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightfv([In, Out] OpenTK.Graphics.GLES11.All light, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static Lightfv glLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelf([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single param);
            internal static LightModelf glLightModelf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelfv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static LightModelfv glLightModelfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelx([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int param);
            internal static LightModelx glLightModelx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelxv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static LightModelxv glLightModelxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lightx([In, Out] OpenTK.Graphics.GLES11.All light, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int param);
            internal static Lightx glLightx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightxv([In, Out] OpenTK.Graphics.GLES11.All light, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static Lightxv glLightxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth([In, Out] Single width);
            internal static LineWidth glLineWidth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidthx([In, Out] int width);
            internal static LineWidthx glLineWidthx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixf([In, Out] Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixx([In, Out] int* m);
            internal unsafe static LoadMatrixx glLoadMatrixx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LogicOp([In, Out] OpenTK.Graphics.GLES11.All opcode);
            internal static LogicOp glLogicOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialf([In, Out] OpenTK.Graphics.GLES11.All face, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single param);
            internal static Materialf glMaterialf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialfv([In, Out] OpenTK.Graphics.GLES11.All face, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static Materialfv glMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialx([In, Out] OpenTK.Graphics.GLES11.All face, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int param);
            internal static Materialx glMaterialx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialxv([In, Out] OpenTK.Graphics.GLES11.All face, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static Materialxv glMaterialxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixMode([In, Out] OpenTK.Graphics.GLES11.All mode);
            internal static MatrixMode glMatrixMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4f([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] Single s, [In, Out] Single t, [In, Out] Single r, [In, Out] Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4x([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] int s, [In, Out] int t, [In, Out] int r, [In, Out] int q);
            internal static MultiTexCoord4x glMultiTexCoord4x;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixf([In, Out] Single* m);
            internal unsafe static MultMatrixf glMultMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixx([In, Out] int* m);
            internal unsafe static MultMatrixx glMultMatrixx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3f([In, Out] Single nx, [In, Out] Single ny, [In, Out] Single nz);
            internal static Normal3f glNormal3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3x([In, Out] int nx, [In, Out] int ny, [In, Out] int nz);
            internal static Normal3x glNormal3x;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointer([In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
            internal static NormalPointer glNormalPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Orthof([In, Out] Single left, [In, Out] Single right, [In, Out] Single bottom, [In, Out] Single top, [In, Out] Single zNear, [In, Out] Single zFar);
            internal static Orthof glOrthof;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Orthox([In, Out] int left, [In, Out] int right, [In, Out] int bottom, [In, Out] int top, [In, Out] int zNear, [In, Out] int zFar);
            internal static Orthox glOrthox;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32 param);
            internal static PixelStorei glPixelStorei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterf([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single param);
            internal static PointParameterf glPointParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterx([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int param);
            internal static PointParameterx glPointParameterx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterxv([In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static PointParameterxv glPointParameterxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSize([In, Out] Single size);
            internal static PointSize glPointSize;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSizePointerOES([In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
            internal static PointSizePointerOES glPointSizePointerOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSizex([In, Out] int size);
            internal static PointSizex glPointSizex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset([In, Out] Single factor, [In, Out] Single units);
            internal static PolygonOffset glPolygonOffset;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffsetx([In, Out] int factor, [In, Out] int units);
            internal static PolygonOffsetx glPolygonOffsetx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.GLES11.All format, [In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatef([In, Out] Single angle, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
            internal static Rotatef glRotatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatex([In, Out] int angle, [In, Out] int x, [In, Out] int y, [In, Out] int z);
            internal static Rotatex glRotatex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage([In, Out] Single value, [In, Out] bool invert);
            internal static SampleCoverage glSampleCoverage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoveragex([In, Out] int value, [In, Out] bool invert);
            internal static SampleCoveragex glSampleCoveragex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalef([In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
            internal static Scalef glScalef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalex([In, Out] int x, [In, Out] int y, [In, Out] int z);
            internal static Scalex glScalex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
            internal static Scissor glScissor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShadeModel([In, Out] OpenTK.Graphics.GLES11.All mode);
            internal static ShadeModel glShadeModel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc([In, Out] OpenTK.Graphics.GLES11.All func, [In, Out] Int32 @ref, [In, Out] UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask([In, Out] UInt32 mask);
            internal static StencilMask glStencilMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp([In, Out] OpenTK.Graphics.GLES11.All fail, [In, Out] OpenTK.Graphics.GLES11.All zfail, [In, Out] OpenTK.Graphics.GLES11.All zpass);
            internal static StencilOp glStencilOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointer([In, Out] Int32 size, [In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
            internal static TexCoordPointer glTexCoordPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvf([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single param);
            internal static TexEnvf glTexEnvf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvfv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvi([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32 param);
            internal static TexEnvi glTexEnvi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnviv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32* @params);
            internal unsafe static TexEnviv glTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvx([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int param);
            internal static TexEnvx glTexEnvx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvxv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static TexEnvxv glTexEnvxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] Int32 level, [In, Out] Int32 internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] OpenTK.Graphics.GLES11.All format, [In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single param);
            internal static TexParameterf glTexParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32 param);
            internal static TexParameteri glTexParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterx([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int param);
            internal static TexParameterx glTexParameterx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterxv([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] OpenTK.Graphics.GLES11.All pname, [In, Out] int* @params);
            internal unsafe static TexParameterxv glTexParameterxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D([In, Out] OpenTK.Graphics.GLES11.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.GLES11.All format, [In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatef([In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
            internal static Translatef glTranslatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatex([In, Out] int x, [In, Out] int y, [In, Out] int z);
            internal static Translatex glTranslatex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointer([In, Out] Int32 size, [In, Out] OpenTK.Graphics.GLES11.All type, [In, Out] Int32 stride, [In, Out] IntPtr pointer);
            internal static VertexPointer glVertexPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
            internal static Viewport glViewport;
        }
    }
}
