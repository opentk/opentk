//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
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



namespace OpenTK.Graphics.ES11
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {

        internal static partial class Core
        {

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAccumxOES", ExactSpelling = true)]
            internal extern static void AccumxOES(OpenTK.Graphics.ES11.OesFixedPoint op, int value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture(OpenTK.Graphics.ES11.VersionEsCm10 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
            internal extern static void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFuncx", ExactSpelling = true)]
            internal extern static void AlphaFuncx(OpenTK.Graphics.ES11.VersionEsCm10 func, int @ref);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFuncxOES", ExactSpelling = true)]
            internal extern static void AlphaFuncxOES(OpenTK.Graphics.ES11.OesFixedPoint func, int @ref);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal extern static void BindBuffer(OpenTK.Graphics.ES11.VersionEsCm10 target, UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFramebufferOES", ExactSpelling = true)]
            internal extern static void BindFramebufferOES(OpenTK.Graphics.ES11.OesFramebufferObject target, UInt32 framebuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindRenderbufferOES", ExactSpelling = true)]
            internal extern static void BindRenderbufferOES(OpenTK.Graphics.ES11.OesFramebufferObject target, UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexArrayOES", ExactSpelling = true)]
            internal extern static void BindVertexArrayOES(UInt32 array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBitmapxOES", ExactSpelling = true)]
            internal extern static unsafe void BitmapxOES(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendColorxOES", ExactSpelling = true)]
            internal extern static void BlendColorxOES(int red, int green, int blue, int alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationEXT", ExactSpelling = true)]
            internal extern static void BlendEquationEXT(OpenTK.Graphics.ES11.ExtBlendMinmax mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationOES", ExactSpelling = true)]
            internal extern static void BlendEquationOES(OpenTK.Graphics.ES11.OesBlendSubtract mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparateOES", ExactSpelling = true)]
            internal extern static void BlendEquationSeparateOES(OpenTK.Graphics.ES11.OesBlendEquationSeparate modeRGB, OpenTK.Graphics.ES11.OesBlendEquationSeparate modeAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparateOES", ExactSpelling = true)]
            internal extern static void BlendFuncSeparateOES(OpenTK.Graphics.ES11.OesBlendFuncSeparate srcRGB, OpenTK.Graphics.ES11.OesBlendFuncSeparate dstRGB, OpenTK.Graphics.ES11.OesBlendFuncSeparate srcAlpha, OpenTK.Graphics.ES11.OesBlendFuncSeparate dstAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal extern static void BufferData(OpenTK.Graphics.ES11.VersionEsCm10 target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.VersionEsCm10 usage);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal extern static void BufferSubData(OpenTK.Graphics.ES11.VersionEsCm10 target, IntPtr offset, IntPtr size, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCheckFramebufferStatusOES", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES11.OesFramebufferObject CheckFramebufferStatusOES(OpenTK.Graphics.ES11.OesFramebufferObject target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearAccumxOES", ExactSpelling = true)]
            internal extern static void ClearAccumxOES(int red, int green, int blue, int alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColorx", ExactSpelling = true)]
            internal extern static void ClearColorx(int red, int green, int blue, int alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColorxOES", ExactSpelling = true)]
            internal extern static void ClearColorxOES(int red, int green, int blue, int alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal extern static void ClearDepthf(Single d);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthfOES", ExactSpelling = true)]
            internal extern static void ClearDepthfOES(Single depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthx", ExactSpelling = true)]
            internal extern static void ClearDepthx(int depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthxOES", ExactSpelling = true)]
            internal extern static void ClearDepthxOES(int depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil(Int32 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
            internal extern static void ClientActiveTexture(OpenTK.Graphics.ES11.VersionEsCm10 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientWaitSyncAPPLE", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES11.AppleSync ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClipPlanef", ExactSpelling = true)]
            internal extern static unsafe void ClipPlanef(OpenTK.Graphics.ES11.VersionEsCm10 p, Single* eqn);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClipPlanefIMG", ExactSpelling = true)]
            internal extern static unsafe void ClipPlanefIMG(OpenTK.Graphics.ES11.ImgUserClipPlane p, Single* eqn);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClipPlanefOES", ExactSpelling = true)]
            internal extern static unsafe void ClipPlanefOES(OpenTK.Graphics.ES11.OesSinglePrecision plane, Single* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClipPlanex", ExactSpelling = true)]
            internal extern static unsafe void ClipPlanex(OpenTK.Graphics.ES11.VersionEsCm10 plane, int* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClipPlanexIMG", ExactSpelling = true)]
            internal extern static unsafe void ClipPlanexIMG(OpenTK.Graphics.ES11.ImgUserClipPlane p, int* eqn);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClipPlanexOES", ExactSpelling = true)]
            internal extern static unsafe void ClipPlanexOES(OpenTK.Graphics.ES11.OesFixedPoint plane, int* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3xOES", ExactSpelling = true)]
            internal extern static void Color3xOES(int red, int green, int blue);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3xvOES", ExactSpelling = true)]
            internal extern static unsafe void Color3xvOES(int* components);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4f", ExactSpelling = true)]
            internal extern static void Color4f(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
            internal extern static void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4x", ExactSpelling = true)]
            internal extern static void Color4x(int red, int green, int blue, int alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4xOES", ExactSpelling = true)]
            internal extern static void Color4xOES(int red, int green, int blue, int alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4xvOES", ExactSpelling = true)]
            internal extern static unsafe void Color4xvOES(int* components);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask(bool red, bool green, bool blue, bool alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
            internal extern static void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.VersionEsCm10 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterxOES", ExactSpelling = true)]
            internal extern static void ConvolutionParameterxOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterxvOES", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameterxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.VersionEsCm10 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTextureLevelsAPPLE", ExactSpelling = true)]
            internal extern static void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCurrentPaletteMatrixOES", ExactSpelling = true)]
            internal extern static void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteBuffers(Int32 n, UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFencesNV", ExactSpelling = true)]
            internal extern static unsafe void DeleteFencesNV(Int32 n, UInt32* fences);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFramebuffersOES", ExactSpelling = true)]
            internal extern static unsafe void DeleteFramebuffersOES(Int32 n, UInt32* framebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteRenderbuffersOES", ExactSpelling = true)]
            internal extern static unsafe void DeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteSyncAPPLE", ExactSpelling = true)]
            internal extern static void DeleteSyncAPPLE(IntPtr sync);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal extern static unsafe void DeleteTextures(Int32 n, UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteVertexArraysOES", ExactSpelling = true)]
            internal extern static unsafe void DeleteVertexArraysOES(Int32 n, UInt32* arrays);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal extern static void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask(bool flag);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal extern static void DepthRangef(Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangefOES", ExactSpelling = true)]
            internal extern static void DepthRangefOES(Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangex", ExactSpelling = true)]
            internal extern static void DepthRangex(int n, int f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangexOES", ExactSpelling = true)]
            internal extern static void DepthRangexOES(int n, int f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable(OpenTK.Graphics.ES11.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
            internal extern static void DisableClientState(OpenTK.Graphics.ES11.EnableCap array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableDriverControlQCOM", ExactSpelling = true)]
            internal extern static void DisableDriverControlQCOM(UInt32 driverControl);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDiscardFramebufferEXT", ExactSpelling = true)]
            internal extern static unsafe void DiscardFramebufferEXT(OpenTK.Graphics.ES11.ExtDiscardFramebuffer target, Int32 numAttachments, OpenTK.Graphics.ES11.ExtDiscardFramebuffer* attachments);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.VersionEsCm10 type, IntPtr indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexfOES", ExactSpelling = true)]
            internal extern static void DrawTexfOES(Single x, Single y, Single z, Single width, Single height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexfvOES", ExactSpelling = true)]
            internal extern static unsafe void DrawTexfvOES(Single* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexiOES", ExactSpelling = true)]
            internal extern static void DrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexivOES", ExactSpelling = true)]
            internal extern static unsafe void DrawTexivOES(Int32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexsOES", ExactSpelling = true)]
            internal extern static void DrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexsvOES", ExactSpelling = true)]
            internal extern static unsafe void DrawTexsvOES(Int16* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexxOES", ExactSpelling = true)]
            internal extern static void DrawTexxOES(int x, int y, int z, int width, int height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTexxvOES", ExactSpelling = true)]
            internal extern static unsafe void DrawTexxvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEGLImageTargetRenderbufferStorageOES", ExactSpelling = true)]
            internal extern static void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES11.OesEglImage target, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEGLImageTargetTexture2DOES", ExactSpelling = true)]
            internal extern static void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES11.OesEglImage target, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable(OpenTK.Graphics.ES11.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
            internal extern static void EnableClientState(OpenTK.Graphics.ES11.EnableCap array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableDriverControlQCOM", ExactSpelling = true)]
            internal extern static void EnableDriverControlQCOM(UInt32 driverControl);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndTilingQCOM", ExactSpelling = true)]
            internal extern static void EndTilingQCOM(UInt32 preserveMask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord1xOES", ExactSpelling = true)]
            internal extern static void EvalCoord1xOES(int u);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord1xvOES", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord1xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord2xOES", ExactSpelling = true)]
            internal extern static void EvalCoord2xOES(int u, int v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord2xvOES", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord2xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetBufferPointervQCOM", ExactSpelling = true)]
            internal extern static void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES11.QcomExtendedGet target, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetBuffersQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetFramebuffersQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetProgramBinarySourceQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES11.QcomExtendedGet2 shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetProgramsQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetRenderbuffersQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetShadersQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetTexLevelParameterivQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES11.QcomExtendedGet face, Int32 level, OpenTK.Graphics.ES11.QcomExtendedGet pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetTexSubImageQCOM", ExactSpelling = true)]
            internal extern static void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES11.QcomExtendedGet target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.QcomExtendedGet format, OpenTK.Graphics.ES11.QcomExtendedGet type, [OutAttribute] IntPtr texels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetTexturesQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtIsProgramBinaryQCOM", ExactSpelling = true)]
            internal extern static bool ExtIsProgramBinaryQCOM(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtTexObjectStateOverrideiQCOM", ExactSpelling = true)]
            internal extern static void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES11.QcomExtendedGet target, OpenTK.Graphics.ES11.QcomExtendedGet pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFeedbackBufferxOES", ExactSpelling = true)]
            internal extern static unsafe void FeedbackBufferxOES(Int32 n, OpenTK.Graphics.ES11.OesFixedPoint type, int* buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFenceSyncAPPLE", ExactSpelling = true)]
            internal extern static IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES11.AppleSync condition, UInt32 flags);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal extern static void Finish();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinishFenceNV", ExactSpelling = true)]
            internal extern static void FinishFenceNV(UInt32 fence);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal extern static void Flush();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushMappedBufferRangeEXT", ExactSpelling = true)]
            internal extern static void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES11.ExtMapBufferRange target, IntPtr offset, IntPtr length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogf", ExactSpelling = true)]
            internal extern static void Fogf(OpenTK.Graphics.ES11.FogParameter pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogfv", ExactSpelling = true)]
            internal extern static unsafe void Fogfv(OpenTK.Graphics.ES11.FogParameter pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogx", ExactSpelling = true)]
            internal extern static void Fogx(OpenTK.Graphics.ES11.VersionEsCm10 pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogxOES", ExactSpelling = true)]
            internal extern static void FogxOES(OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogxv", ExactSpelling = true)]
            internal extern static unsafe void Fogxv(OpenTK.Graphics.ES11.VersionEsCm10 pname, int* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogxvOES", ExactSpelling = true)]
            internal extern static unsafe void FogxvOES(OpenTK.Graphics.ES11.OesFixedPoint pname, int* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferRenderbufferOES", ExactSpelling = true)]
            internal extern static void FramebufferRenderbufferOES(OpenTK.Graphics.ES11.OesFramebufferObject target, OpenTK.Graphics.ES11.OesFramebufferObject attachment, OpenTK.Graphics.ES11.OesFramebufferObject renderbuffertarget, UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2DMultisampleEXT", ExactSpelling = true)]
            internal extern static void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES11.ExtMultisampledRenderToTexture target, OpenTK.Graphics.ES11.ExtMultisampledRenderToTexture attachment, OpenTK.Graphics.ES11.ExtMultisampledRenderToTexture textarget, UInt32 texture, Int32 level, Int32 samples);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2DMultisampleIMG", ExactSpelling = true)]
            internal extern static void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES11.ImgMultisampledRenderToTexture target, OpenTK.Graphics.ES11.ImgMultisampledRenderToTexture attachment, OpenTK.Graphics.ES11.ImgMultisampledRenderToTexture textarget, UInt32 texture, Int32 level, Int32 samples);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2DOES", ExactSpelling = true)]
            internal extern static void FramebufferTexture2DOES(OpenTK.Graphics.ES11.OesFramebufferObject target, OpenTK.Graphics.ES11.OesFramebufferObject attachment, OpenTK.Graphics.ES11.OesFramebufferObject textarget, UInt32 texture, Int32 level);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrustumf", ExactSpelling = true)]
            internal extern static void Frustumf(Single l, Single r, Single b, Single t, Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrustumfOES", ExactSpelling = true)]
            internal extern static void FrustumfOES(Single l, Single r, Single b, Single t, Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrustumx", ExactSpelling = true)]
            internal extern static void Frustumx(int l, int r, int b, int t, int n, int f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrustumxOES", ExactSpelling = true)]
            internal extern static void FrustumxOES(int l, int r, int b, int t, int n, int f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal extern static unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenerateMipmapOES", ExactSpelling = true)]
            internal extern static void GenerateMipmapOES(OpenTK.Graphics.ES11.OesFramebufferObject target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFencesNV", ExactSpelling = true)]
            internal extern static unsafe void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFramebuffersOES", ExactSpelling = true)]
            internal extern static unsafe void GenFramebuffersOES(Int32 n, [OutAttribute] UInt32* framebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenRenderbuffersOES", ExactSpelling = true)]
            internal extern static unsafe void GenRenderbuffersOES(Int32 n, [OutAttribute] UInt32* renderbuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenVertexArraysOES", ExactSpelling = true)]
            internal extern static unsafe void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal extern static unsafe void GetBooleanv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteriv(OpenTK.Graphics.ES11.VersionEsCm10 target, OpenTK.Graphics.ES11.VersionEsCm10 pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferPointervOES", ExactSpelling = true)]
            internal extern static void GetBufferPointervOES(OpenTK.Graphics.ES11.OesMapbuffer target, OpenTK.Graphics.ES11.OesMapbuffer pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetClipPlanef", ExactSpelling = true)]
            internal extern static unsafe void GetClipPlanef(OpenTK.Graphics.ES11.VersionEsCm10 plane, [OutAttribute] Single* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetClipPlanefOES", ExactSpelling = true)]
            internal extern static unsafe void GetClipPlanefOES(OpenTK.Graphics.ES11.OesSinglePrecision plane, [OutAttribute] Single* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetClipPlanex", ExactSpelling = true)]
            internal extern static unsafe void GetClipPlanex(OpenTK.Graphics.ES11.VersionEsCm10 plane, [OutAttribute] int* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetClipPlanexOES", ExactSpelling = true)]
            internal extern static unsafe void GetClipPlanexOES(OpenTK.Graphics.ES11.OesFixedPoint plane, [OutAttribute] int* equation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionParameterxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameterxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDriverControlsQCOM", ExactSpelling = true)]
            internal extern static unsafe void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDriverControlStringQCOM", ExactSpelling = true)]
            internal extern static unsafe void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES11.ErrorCode GetError();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFenceivNV", ExactSpelling = true)]
            internal extern static unsafe void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES11.NvFence pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFixedv", ExactSpelling = true)]
            internal extern static unsafe void GetFixedv(OpenTK.Graphics.ES11.VersionEsCm10 pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFixedvOES", ExactSpelling = true)]
            internal extern static unsafe void GetFixedvOES(OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal extern static unsafe void GetFloatv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFramebufferAttachmentParameterivOES", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferAttachmentParameterivOES(OpenTK.Graphics.ES11.OesFramebufferObject target, OpenTK.Graphics.ES11.OesFramebufferObject attachment, OpenTK.Graphics.ES11.OesFramebufferObject pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetGraphicsResetStatusEXT", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES11.ExtRobustness GetGraphicsResetStatusEXT();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramParameterxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameterxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInteger64vAPPLE", ExactSpelling = true)]
            internal extern static unsafe void GetInteger64vAPPLE(OpenTK.Graphics.ES11.AppleSync pname, [OutAttribute] Int64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
            internal extern static unsafe void GetLightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLightxOES", ExactSpelling = true)]
            internal extern static unsafe void GetLightxOES(OpenTK.Graphics.ES11.OesFixedPoint light, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLightxv", ExactSpelling = true)]
            internal extern static unsafe void GetLightxv(OpenTK.Graphics.ES11.VersionEsCm10 light, OpenTK.Graphics.ES11.VersionEsCm10 pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLightxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetLightxvOES(OpenTK.Graphics.ES11.OesFixedPoint light, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetMapxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint query, [OutAttribute] int* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
            internal extern static unsafe void GetMaterialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMaterialxOES", ExactSpelling = true)]
            internal extern static void GetMaterialxOES(OpenTK.Graphics.ES11.OesFixedPoint face, OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMaterialxv", ExactSpelling = true)]
            internal extern static unsafe void GetMaterialxv(OpenTK.Graphics.ES11.VersionEsCm10 face, OpenTK.Graphics.ES11.VersionEsCm10 pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMaterialxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetMaterialxvOES(OpenTK.Graphics.ES11.OesFixedPoint face, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPixelMapxv", ExactSpelling = true)]
            internal extern static unsafe void GetPixelMapxv(OpenTK.Graphics.ES11.OesFixedPoint map, Int32 size, [OutAttribute] int* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal extern static void GetPointerv(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetRenderbufferParameterivOES", ExactSpelling = true)]
            internal extern static unsafe void GetRenderbufferParameterivOES(OpenTK.Graphics.ES11.OesFramebufferObject target, OpenTK.Graphics.ES11.OesFramebufferObject pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(OpenTK.Graphics.ES11.StringName name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSyncivAPPLE", ExactSpelling = true)]
            internal extern static unsafe void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES11.AppleSync pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexEnvxv", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnvxv(OpenTK.Graphics.ES11.VersionEsCm10 target, OpenTK.Graphics.ES11.VersionEsCm10 pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexEnvxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnvxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexGenfvOES", ExactSpelling = true)]
            internal extern static unsafe void GetTexGenfvOES(OpenTK.Graphics.ES11.OesTextureCubeMap coord, OpenTK.Graphics.ES11.OesTextureCubeMap pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexGenivOES", ExactSpelling = true)]
            internal extern static unsafe void GetTexGenivOES(OpenTK.Graphics.ES11.OesTextureCubeMap coord, OpenTK.Graphics.ES11.OesTextureCubeMap pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexGenxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetTexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexLevelParameterxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetTexLevelParameterxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, Int32 level, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterxv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterxv(OpenTK.Graphics.ES11.VersionEsCm10 target, OpenTK.Graphics.ES11.VersionEsCm10 pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterxvOES", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, [OutAttribute] int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexxOES", ExactSpelling = true)]
            internal extern static void IndexxOES(int component);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexxvOES", ExactSpelling = true)]
            internal extern static unsafe void IndexxvOES(int* component);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal extern static bool IsBuffer(UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal extern static bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFenceNV", ExactSpelling = true)]
            internal extern static bool IsFenceNV(UInt32 fence);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFramebufferOES", ExactSpelling = true)]
            internal extern static bool IsFramebufferOES(UInt32 framebuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsRenderbufferOES", ExactSpelling = true)]
            internal extern static bool IsRenderbufferOES(UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsSyncAPPLE", ExactSpelling = true)]
            internal extern static bool IsSyncAPPLE(IntPtr sync);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal extern static bool IsTexture(UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsVertexArrayOES", ExactSpelling = true)]
            internal extern static bool IsVertexArrayOES(UInt32 array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightf", ExactSpelling = true)]
            internal extern static void Lightf(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightfv", ExactSpelling = true)]
            internal extern static unsafe void Lightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
            internal extern static void LightModelf(OpenTK.Graphics.ES11.LightModelParameter pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
            internal extern static unsafe void LightModelfv(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelx", ExactSpelling = true)]
            internal extern static void LightModelx(OpenTK.Graphics.ES11.VersionEsCm10 pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelxOES", ExactSpelling = true)]
            internal extern static void LightModelxOES(OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelxv", ExactSpelling = true)]
            internal extern static unsafe void LightModelxv(OpenTK.Graphics.ES11.VersionEsCm10 pname, int* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelxvOES", ExactSpelling = true)]
            internal extern static unsafe void LightModelxvOES(OpenTK.Graphics.ES11.OesFixedPoint pname, int* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightx", ExactSpelling = true)]
            internal extern static void Lightx(OpenTK.Graphics.ES11.VersionEsCm10 light, OpenTK.Graphics.ES11.VersionEsCm10 pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightxOES", ExactSpelling = true)]
            internal extern static void LightxOES(OpenTK.Graphics.ES11.OesFixedPoint light, OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightxv", ExactSpelling = true)]
            internal extern static unsafe void Lightxv(OpenTK.Graphics.ES11.VersionEsCm10 light, OpenTK.Graphics.ES11.VersionEsCm10 pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightxvOES", ExactSpelling = true)]
            internal extern static unsafe void LightxvOES(OpenTK.Graphics.ES11.OesFixedPoint light, OpenTK.Graphics.ES11.OesFixedPoint pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth(Single width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLineWidthx", ExactSpelling = true)]
            internal extern static void LineWidthx(int width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLineWidthxOES", ExactSpelling = true)]
            internal extern static void LineWidthxOES(int width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
            internal extern static void LoadIdentity();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixf(Single* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadMatrixx", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixx(int* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadMatrixxOES", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixxOES(int* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadPaletteFromModelViewMatrixOES", ExactSpelling = true)]
            internal extern static void LoadPaletteFromModelViewMatrixOES();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadTransposeMatrixxOES", ExactSpelling = true)]
            internal extern static unsafe void LoadTransposeMatrixxOES(int* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal extern static void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMap1xOES", ExactSpelling = true)]
            internal extern static void Map1xOES(OpenTK.Graphics.ES11.OesFixedPoint target, int u1, int u2, Int32 stride, Int32 order, int points);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMap2xOES", ExactSpelling = true)]
            internal extern static void Map2xOES(OpenTK.Graphics.ES11.OesFixedPoint target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBufferOES", ExactSpelling = true)]
            internal extern static IntPtr MapBufferOES(OpenTK.Graphics.ES11.OesMapbuffer target, OpenTK.Graphics.ES11.OesMapbuffer access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBufferRangeEXT", ExactSpelling = true)]
            internal extern static IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES11.ExtMapBufferRange target, IntPtr offset, IntPtr length, UInt32 access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapGrid1xOES", ExactSpelling = true)]
            internal extern static void MapGrid1xOES(Int32 n, int u1, int u2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapGrid2xOES", ExactSpelling = true)]
            internal extern static void MapGrid2xOES(Int32 n, int u1, int u2, int v1, int v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
            internal extern static void Materialf(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
            internal extern static unsafe void Materialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialx", ExactSpelling = true)]
            internal extern static void Materialx(OpenTK.Graphics.ES11.VersionEsCm10 face, OpenTK.Graphics.ES11.VersionEsCm10 pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialxOES", ExactSpelling = true)]
            internal extern static void MaterialxOES(OpenTK.Graphics.ES11.OesFixedPoint face, OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialxv", ExactSpelling = true)]
            internal extern static unsafe void Materialxv(OpenTK.Graphics.ES11.VersionEsCm10 face, OpenTK.Graphics.ES11.VersionEsCm10 pname, int* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialxvOES", ExactSpelling = true)]
            internal extern static unsafe void MaterialxvOES(OpenTK.Graphics.ES11.OesFixedPoint face, OpenTK.Graphics.ES11.OesFixedPoint pname, int* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixIndexPointerOES", ExactSpelling = true)]
            internal extern static void MatrixIndexPointerOES(Int32 size, OpenTK.Graphics.ES11.OesMatrixPalette type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
            internal extern static void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArraysEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawArraysEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElementsEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.ExtMultiDrawArrays type, IntPtr indices, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1bOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord1bOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1bvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1bvOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1xOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord1xOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1xvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1xvOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2bOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord2bOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte s, SByte t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2bvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2bvOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2xOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord2xOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int s, int t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2xvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2xvOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3bOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord3bOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte s, SByte t, SByte r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3bvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3bvOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3xOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord3xOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int s, int t, int r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3xvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3xvOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4bOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord4bOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte s, SByte t, SByte r, SByte q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4bvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4bvOES(OpenTK.Graphics.ES11.OesByteCoordinates texture, SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
            internal extern static void MultiTexCoord4f(OpenTK.Graphics.ES11.VersionEsCm10 target, Single s, Single t, Single r, Single q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4x", ExactSpelling = true)]
            internal extern static void MultiTexCoord4x(OpenTK.Graphics.ES11.VersionEsCm10 texture, int s, int t, int r, int q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4xOES", ExactSpelling = true)]
            internal extern static void MultiTexCoord4xOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int s, int t, int r, int q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4xvOES", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4xvOES(OpenTK.Graphics.ES11.OesFixedPoint texture, int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixf(Single* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultMatrixx", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixx(int* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultMatrixxOES", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixxOES(int* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultTransposeMatrixxOES", ExactSpelling = true)]
            internal extern static unsafe void MultTransposeMatrixxOES(int* m);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
            internal extern static void Normal3f(Single nx, Single ny, Single nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3x", ExactSpelling = true)]
            internal extern static void Normal3x(int nx, int ny, int nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3xOES", ExactSpelling = true)]
            internal extern static void Normal3xOES(int nx, int ny, int nz);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3xvOES", ExactSpelling = true)]
            internal extern static unsafe void Normal3xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
            internal extern static void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glOrthof", ExactSpelling = true)]
            internal extern static void Orthof(Single l, Single r, Single b, Single t, Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glOrthofOES", ExactSpelling = true)]
            internal extern static void OrthofOES(Single l, Single r, Single b, Single t, Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glOrthox", ExactSpelling = true)]
            internal extern static void Orthox(int l, int r, int b, int t, int n, int f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glOrthoxOES", ExactSpelling = true)]
            internal extern static void OrthoxOES(int l, int r, int b, int t, int n, int f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPassThroughxOES", ExactSpelling = true)]
            internal extern static void PassThroughxOES(int token);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelMapx", ExactSpelling = true)]
            internal extern static unsafe void PixelMapx(OpenTK.Graphics.ES11.OesFixedPoint map, Int32 size, int* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelStorex", ExactSpelling = true)]
            internal extern static void PixelStorex(OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTransferxOES", ExactSpelling = true)]
            internal extern static void PixelTransferxOES(OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelZoomxOES", ExactSpelling = true)]
            internal extern static void PixelZoomxOES(int xfactor, int yfactor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
            internal extern static void PointParameterf(OpenTK.Graphics.ES11.VersionEsCm10 pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
            internal extern static unsafe void PointParameterfv(OpenTK.Graphics.ES11.VersionEsCm10 pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterx", ExactSpelling = true)]
            internal extern static void PointParameterx(OpenTK.Graphics.ES11.VersionEsCm10 pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterxOES", ExactSpelling = true)]
            internal extern static void PointParameterxOES(OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterxv", ExactSpelling = true)]
            internal extern static unsafe void PointParameterxv(OpenTK.Graphics.ES11.VersionEsCm10 pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterxvOES", ExactSpelling = true)]
            internal extern static unsafe void PointParameterxvOES(OpenTK.Graphics.ES11.OesFixedPoint pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal extern static void PointSize(Single size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointSizePointerOES", ExactSpelling = true)]
            internal extern static void PointSizePointerOES(OpenTK.Graphics.ES11.OesPointSizeArray type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointSizex", ExactSpelling = true)]
            internal extern static void PointSizex(int size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointSizexOES", ExactSpelling = true)]
            internal extern static void PointSizexOES(int size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal extern static void PolygonOffset(Single factor, Single units);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonOffsetx", ExactSpelling = true)]
            internal extern static void PolygonOffsetx(int factor, int units);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonOffsetxOES", ExactSpelling = true)]
            internal extern static void PolygonOffsetxOES(int factor, int units);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
            internal extern static void PopMatrix();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPrioritizeTexturesxOES", ExactSpelling = true)]
            internal extern static unsafe void PrioritizeTexturesxOES(Int32 n, UInt32* textures, int* priorities);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
            internal extern static void PushMatrix();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glQueryMatrixxOES", ExactSpelling = true)]
            internal extern static unsafe Int32 QueryMatrixxOES([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2xOES", ExactSpelling = true)]
            internal extern static void RasterPos2xOES(int x, int y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2xvOES", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3xOES", ExactSpelling = true)]
            internal extern static void RasterPos3xOES(int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3xvOES", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4xOES", ExactSpelling = true)]
            internal extern static void RasterPos4xOES(int x, int y, int z, int w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4xvOES", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadnPixelsEXT", ExactSpelling = true)]
            internal extern static void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.ExtRobustness format, OpenTK.Graphics.ES11.ExtRobustness type, Int32 bufSize, [OutAttribute] IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectxOES", ExactSpelling = true)]
            internal extern static void RectxOES(int x1, int y1, int x2, int y2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectxvOES", ExactSpelling = true)]
            internal extern static unsafe void RectxvOES(int* v1, int* v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleAPPLE", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES11.AppleFramebufferMultisample target, Int32 samples, OpenTK.Graphics.ES11.AppleFramebufferMultisample internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES11.ExtMultisampledRenderToTexture target, Int32 samples, OpenTK.Graphics.ES11.ExtMultisampledRenderToTexture internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleIMG", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES11.ImgMultisampledRenderToTexture target, Int32 samples, OpenTK.Graphics.ES11.ImgMultisampledRenderToTexture internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageOES", ExactSpelling = true)]
            internal extern static void RenderbufferStorageOES(OpenTK.Graphics.ES11.OesFramebufferObject target, OpenTK.Graphics.ES11.OesFramebufferObject internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResolveMultisampleFramebufferAPPLE", ExactSpelling = true)]
            internal extern static void ResolveMultisampleFramebufferAPPLE();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRotatef", ExactSpelling = true)]
            internal extern static void Rotatef(Single angle, Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRotatex", ExactSpelling = true)]
            internal extern static void Rotatex(int angle, int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRotatexOES", ExactSpelling = true)]
            internal extern static void RotatexOES(int angle, int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage(Single value, bool invert);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoverageOES", ExactSpelling = true)]
            internal extern static void SampleCoverageOES(int value, bool invert);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoveragex", ExactSpelling = true)]
            internal extern static void SampleCoveragex(int value, bool invert);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoveragexOES", ExactSpelling = true)]
            internal extern static void SampleCoveragexOES(int value, bool invert);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScalef", ExactSpelling = true)]
            internal extern static void Scalef(Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScalex", ExactSpelling = true)]
            internal extern static void Scalex(int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScalexOES", ExactSpelling = true)]
            internal extern static void ScalexOES(int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetFenceNV", ExactSpelling = true)]
            internal extern static void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES11.NvFence condition);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
            internal extern static void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStartTilingQCOM", ExactSpelling = true)]
            internal extern static void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask(UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTestFenceNV", ExactSpelling = true)]
            internal extern static bool TestFenceNV(UInt32 fence);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1bOES", ExactSpelling = true)]
            internal extern static void TexCoord1bOES(SByte s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1bvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1bvOES(SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1xOES", ExactSpelling = true)]
            internal extern static void TexCoord1xOES(int s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1xvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2bOES", ExactSpelling = true)]
            internal extern static void TexCoord2bOES(SByte s, SByte t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2bvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2bvOES(SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2xOES", ExactSpelling = true)]
            internal extern static void TexCoord2xOES(int s, int t);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2xvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3bOES", ExactSpelling = true)]
            internal extern static void TexCoord3bOES(SByte s, SByte t, SByte r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3bvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3bvOES(SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3xOES", ExactSpelling = true)]
            internal extern static void TexCoord3xOES(int s, int t, int r);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3xvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4bOES", ExactSpelling = true)]
            internal extern static void TexCoord4bOES(SByte s, SByte t, SByte r, SByte q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4bvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4bvOES(SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4xOES", ExactSpelling = true)]
            internal extern static void TexCoord4xOES(int s, int t, int r, int q);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4xvOES", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
            internal extern static void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
            internal extern static void TexEnvf(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
            internal extern static unsafe void TexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
            internal extern static void TexEnvi(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
            internal extern static unsafe void TexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvx", ExactSpelling = true)]
            internal extern static void TexEnvx(OpenTK.Graphics.ES11.VersionEsCm10 target, OpenTK.Graphics.ES11.VersionEsCm10 pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvxOES", ExactSpelling = true)]
            internal extern static void TexEnvxOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvxv", ExactSpelling = true)]
            internal extern static unsafe void TexEnvxv(OpenTK.Graphics.ES11.VersionEsCm10 target, OpenTK.Graphics.ES11.VersionEsCm10 pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvxvOES", ExactSpelling = true)]
            internal extern static unsafe void TexEnvxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGenfOES", ExactSpelling = true)]
            internal extern static void TexGenfOES(OpenTK.Graphics.ES11.OesTextureCubeMap coord, OpenTK.Graphics.ES11.OesTextureCubeMap pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGenfvOES", ExactSpelling = true)]
            internal extern static unsafe void TexGenfvOES(OpenTK.Graphics.ES11.OesTextureCubeMap coord, OpenTK.Graphics.ES11.OesTextureCubeMap pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGeniOES", ExactSpelling = true)]
            internal extern static void TexGeniOES(OpenTK.Graphics.ES11.OesTextureCubeMap coord, OpenTK.Graphics.ES11.OesTextureCubeMap pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGenivOES", ExactSpelling = true)]
            internal extern static unsafe void TexGenivOES(OpenTK.Graphics.ES11.OesTextureCubeMap coord, OpenTK.Graphics.ES11.OesTextureCubeMap pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGenxOES", ExactSpelling = true)]
            internal extern static void TexGenxOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGenxvOES", ExactSpelling = true)]
            internal extern static unsafe void TexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal extern static void TexParameteri(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void TexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterx", ExactSpelling = true)]
            internal extern static void TexParameterx(OpenTK.Graphics.ES11.VersionEsCm10 target, OpenTK.Graphics.ES11.VersionEsCm10 pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterxOES", ExactSpelling = true)]
            internal extern static void TexParameterxOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, int param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterxv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterxv(OpenTK.Graphics.ES11.VersionEsCm10 target, OpenTK.Graphics.ES11.VersionEsCm10 pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterxvOES", ExactSpelling = true)]
            internal extern static unsafe void TexParameterxvOES(OpenTK.Graphics.ES11.OesFixedPoint target, OpenTK.Graphics.ES11.OesFixedPoint pname, int* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage1DEXT", ExactSpelling = true)]
            internal extern static void TexStorage1DEXT(OpenTK.Graphics.ES11.ExtTextureStorage target, Int32 levels, OpenTK.Graphics.ES11.ExtTextureStorage internalformat, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage2DEXT", ExactSpelling = true)]
            internal extern static void TexStorage2DEXT(OpenTK.Graphics.ES11.ExtTextureStorage target, Int32 levels, OpenTK.Graphics.ES11.ExtTextureStorage internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage3DEXT", ExactSpelling = true)]
            internal extern static void TexStorage3DEXT(OpenTK.Graphics.ES11.ExtTextureStorage target, Int32 levels, OpenTK.Graphics.ES11.ExtTextureStorage internalformat, Int32 width, Int32 height, Int32 depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureStorage1DEXT", ExactSpelling = true)]
            internal extern static void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES11.ExtTextureStorage target, Int32 levels, OpenTK.Graphics.ES11.ExtTextureStorage internalformat, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureStorage2DEXT", ExactSpelling = true)]
            internal extern static void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES11.ExtTextureStorage target, Int32 levels, OpenTK.Graphics.ES11.ExtTextureStorage internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureStorage3DEXT", ExactSpelling = true)]
            internal extern static void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES11.ExtTextureStorage target, Int32 levels, OpenTK.Graphics.ES11.ExtTextureStorage internalformat, Int32 width, Int32 height, Int32 depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
            internal extern static void Translatef(Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTranslatex", ExactSpelling = true)]
            internal extern static void Translatex(int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTranslatexOES", ExactSpelling = true)]
            internal extern static void TranslatexOES(int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnmapBufferOES", ExactSpelling = true)]
            internal extern static bool UnmapBufferOES(OpenTK.Graphics.ES11.OesMapbuffer target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2bOES", ExactSpelling = true)]
            internal extern static void Vertex2bOES(SByte x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2bvOES", ExactSpelling = true)]
            internal extern static unsafe void Vertex2bvOES(SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2xOES", ExactSpelling = true)]
            internal extern static void Vertex2xOES(int x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2xvOES", ExactSpelling = true)]
            internal extern static unsafe void Vertex2xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3bOES", ExactSpelling = true)]
            internal extern static void Vertex3bOES(SByte x, SByte y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3bvOES", ExactSpelling = true)]
            internal extern static unsafe void Vertex3bvOES(SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3xOES", ExactSpelling = true)]
            internal extern static void Vertex3xOES(int x, int y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3xvOES", ExactSpelling = true)]
            internal extern static unsafe void Vertex3xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4bOES", ExactSpelling = true)]
            internal extern static void Vertex4bOES(SByte x, SByte y, SByte z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4bvOES", ExactSpelling = true)]
            internal extern static unsafe void Vertex4bvOES(SByte* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4xOES", ExactSpelling = true)]
            internal extern static void Vertex4xOES(int x, int y, int z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4xvOES", ExactSpelling = true)]
            internal extern static unsafe void Vertex4xvOES(int* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
            internal extern static void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWaitSyncAPPLE", ExactSpelling = true)]
            internal extern static void WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightPointerOES", ExactSpelling = true)]
            internal extern static void WeightPointerOES(Int32 size, OpenTK.Graphics.ES11.OesMatrixPalette type, Int32 stride, IntPtr pointer);
        }
    }
}
