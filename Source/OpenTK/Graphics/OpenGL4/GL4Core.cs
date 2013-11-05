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



namespace OpenTK.Graphics.OpenGL4
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
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
            internal extern static void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture(OpenTK.Graphics.OpenGL4.TextureUnit texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal extern static void AttachShader(UInt32 program, UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginConditionalRender", ExactSpelling = true)]
            internal extern static void BeginConditionalRender(UInt32 id, OpenTK.Graphics.OpenGL4.ConditionalRenderType mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
            internal extern static void BeginQuery(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginQueryIndexed", ExactSpelling = true)]
            internal extern static void BeginQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginTransformFeedback", ExactSpelling = true)]
            internal extern static void BeginTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackPrimitiveType primitiveMode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal extern static void BindAttribLocation(UInt32 program, UInt32 index, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal extern static void BindBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferBase", ExactSpelling = true)]
            internal extern static void BindBufferBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferRange", ExactSpelling = true)]
            internal extern static void BindBufferRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBuffersBase", ExactSpelling = true)]
            internal extern static unsafe void BindBuffersBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBuffersRange", ExactSpelling = true)]
            internal extern static unsafe void BindBuffersRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, IntPtr* sizes);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFragDataLocation", ExactSpelling = true)]
            internal extern static void BindFragDataLocation(UInt32 program, UInt32 color, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
            internal extern static void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
            internal extern static void BindFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, UInt32 framebuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindImageTexture", ExactSpelling = true)]
            internal extern static void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.TextureAccess access, OpenTK.Graphics.OpenGL4.SizedInternalFormat format);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindImageTextures", ExactSpelling = true)]
            internal extern static unsafe void BindImageTextures(UInt32 first, Int32 count, UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
            internal extern static void BindProgramPipeline(UInt32 pipeline);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
            internal extern static void BindRenderbuffer(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindSampler", ExactSpelling = true)]
            internal extern static void BindSampler(UInt32 unit, UInt32 sampler);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindSamplers", ExactSpelling = true)]
            internal extern static unsafe void BindSamplers(UInt32 first, Int32 count, UInt32* samplers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture(OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTextures", ExactSpelling = true)]
            internal extern static unsafe void BindTextures(UInt32 first, Int32 count, UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTransformFeedback", ExactSpelling = true)]
            internal extern static void BindTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackTarget target, UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexArray", ExactSpelling = true)]
            internal extern static void BindVertexArray(UInt32 array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexBuffer", ExactSpelling = true)]
            internal extern static void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexBuffers", ExactSpelling = true)]
            internal extern static unsafe void BindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal extern static void BlendColor(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal extern static void BlendEquation(OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationi", ExactSpelling = true)]
            internal extern static void BlendEquationi(UInt32 buf, OpenTK.Graphics.OpenGL4.All mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationiARB", ExactSpelling = true)]
            internal extern static void BlendEquationiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal extern static void BlendEquationSeparate(OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparatei", ExactSpelling = true)]
            internal extern static void BlendEquationSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparateiARB", ExactSpelling = true)]
            internal extern static void BlendEquationSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All modeRGB, OpenTK.Graphics.OpenGL4.All modeAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactor, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunci", ExactSpelling = true)]
            internal extern static void BlendFunci(UInt32 buf, OpenTK.Graphics.OpenGL4.All src, OpenTK.Graphics.OpenGL4.All dst);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunciARB", ExactSpelling = true)]
            internal extern static void BlendFunciARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All src, OpenTK.Graphics.OpenGL4.All dst);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal extern static void BlendFuncSeparate(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparatei", ExactSpelling = true)]
            internal extern static void BlendFuncSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.All srcRGB, OpenTK.Graphics.OpenGL4.All dstRGB, OpenTK.Graphics.OpenGL4.All srcAlpha, OpenTK.Graphics.OpenGL4.All dstAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparateiARB", ExactSpelling = true)]
            internal extern static void BlendFuncSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All srcRGB, OpenTK.Graphics.OpenGL4.All dstRGB, OpenTK.Graphics.OpenGL4.All srcAlpha, OpenTK.Graphics.OpenGL4.All dstAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlitFramebuffer", ExactSpelling = true)]
            internal extern static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.OpenGL4.ClearBufferMask mask, OpenTK.Graphics.OpenGL4.BlitFramebufferFilter filter);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal extern static void BufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferUsageHint usage);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferStorage", ExactSpelling = true)]
            internal extern static void BufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal extern static void BufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.OpenGL4.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.OpenGL4.FramebufferTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClampColor", ExactSpelling = true)]
            internal extern static void ClampColor(OpenTK.Graphics.OpenGL4.ClampColorTarget target, OpenTK.Graphics.OpenGL4.ClampColorMode clamp);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear(OpenTK.Graphics.OpenGL4.ClearBufferMask mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferData", ExactSpelling = true)]
            internal extern static void ClearBufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferfi", ExactSpelling = true)]
            internal extern static void ClearBufferfi(OpenTK.Graphics.OpenGL4.ClearBufferCombined buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferfv", ExactSpelling = true)]
            internal extern static unsafe void ClearBufferfv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferiv", ExactSpelling = true)]
            internal extern static unsafe void ClearBufferiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferSubData", ExactSpelling = true)]
            internal extern static void ClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, IntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferuiv", ExactSpelling = true)]
            internal extern static unsafe void ClearBufferuiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
            internal extern static void ClearDepth(Double depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal extern static void ClearDepthf(Single d);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil(Int32 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearTexImage", ExactSpelling = true)]
            internal extern static void ClearTexImage(UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearTexSubImage", ExactSpelling = true)]
            internal extern static void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientWaitSync", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.OpenGL4.WaitSyncStatus ClientWaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.ClientWaitSyncFlags flags, UInt64 timeout);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask(bool red, bool green, bool blue, bool alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMaski", ExactSpelling = true)]
            internal extern static void ColorMaski(UInt32 index, bool r, bool g, bool b, bool a);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP3ui", ExactSpelling = true)]
            internal extern static void ColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP3uiv", ExactSpelling = true)]
            internal extern static unsafe void ColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP4ui", ExactSpelling = true)]
            internal extern static void ColorP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP4uiv", ExactSpelling = true)]
            internal extern static unsafe void ColorP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorSubTable", ExactSpelling = true)]
            internal extern static void ColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 count, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTable", ExactSpelling = true)]
            internal extern static void ColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr table);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal extern static void CompileShader(UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompileShaderIncludeARB", ExactSpelling = true)]
            internal extern static unsafe void CompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
            internal extern static void ConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
            internal extern static void ConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
            internal extern static void ConvolutionParameterf(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
            internal extern static void ConvolutionParameteri(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32 @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyBufferSubData", ExactSpelling = true)]
            internal extern static void CopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
            internal extern static void CopyColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyColorTable", ExactSpelling = true)]
            internal extern static void CopyColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyImageSubData", ExactSpelling = true)]
            internal extern static void CopyImageSubData(UInt32 srcName, OpenTK.Graphics.OpenGL4.ImageTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenTK.Graphics.OpenGL4.ImageTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
            internal extern static void CopyTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal extern static Int32 CreateProgram();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal extern static Int32 CreateShader(OpenTK.Graphics.OpenGL4.ShaderType type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
            internal extern static Int32 CreateShaderProgramv(OpenTK.Graphics.OpenGL4.ShaderType type, Int32 count, String[] strings);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateSyncFromCLeventARB", ExactSpelling = true)]
            internal extern static unsafe IntPtr CreateSyncFromCLeventARB([OutAttribute] IntPtr* context, [OutAttribute] IntPtr* @event, UInt32 flags);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace(OpenTK.Graphics.OpenGL4.CullFaceMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageCallback", ExactSpelling = true)]
            internal extern static void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageCallbackARB", ExactSpelling = true)]
            internal extern static void DebugMessageCallbackARB(DebugProcArb callback, IntPtr userParam);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageCallbackKHR", ExactSpelling = true)]
            internal extern static void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageControl", ExactSpelling = true)]
            internal extern static unsafe void DebugMessageControl(OpenTK.Graphics.OpenGL4.DebugSourceControl source, OpenTK.Graphics.OpenGL4.DebugTypeControl type, OpenTK.Graphics.OpenGL4.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageControlARB", ExactSpelling = true)]
            internal extern static unsafe void DebugMessageControlARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageControlKHR", ExactSpelling = true)]
            internal extern static unsafe void DebugMessageControlKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageInsert", ExactSpelling = true)]
            internal extern static void DebugMessageInsert(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, OpenTK.Graphics.OpenGL4.DebugType type, UInt32 id, OpenTK.Graphics.OpenGL4.DebugSeverity severity, Int32 length, String buf);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageInsertARB", ExactSpelling = true)]
            internal extern static void DebugMessageInsertARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageInsertKHR", ExactSpelling = true)]
            internal extern static void DebugMessageInsertKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteBuffers(Int32 n, UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteNamedStringARB", ExactSpelling = true)]
            internal extern static void DeleteNamedStringARB(Int32 namelen, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal extern static void DeleteProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
            internal extern static unsafe void DeleteProgramPipelines(Int32 n, UInt32* pipelines);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
            internal extern static unsafe void DeleteQueries(Int32 n, UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
            internal extern static unsafe void DeleteSamplers(Int32 count, UInt32* samplers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal extern static void DeleteShader(UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteSync", ExactSpelling = true)]
            internal extern static void DeleteSync(IntPtr sync);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal extern static unsafe void DeleteTextures(Int32 n, UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteTransformFeedbacks", ExactSpelling = true)]
            internal extern static unsafe void DeleteTransformFeedbacks(Int32 n, UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteVertexArrays", ExactSpelling = true)]
            internal extern static unsafe void DeleteVertexArrays(Int32 n, UInt32* arrays);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal extern static void DepthFunc(OpenTK.Graphics.OpenGL4.DepthFunction func);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask(bool flag);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
            internal extern static void DepthRange(Double near, Double far);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
            internal extern static unsafe void DepthRangeArrayv(UInt32 first, Int32 count, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal extern static void DepthRangef(Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
            internal extern static void DepthRangeIndexed(UInt32 index, Double n, Double f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal extern static void DetachShader(UInt32 program, UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisablei", ExactSpelling = true)]
            internal extern static void Disablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal extern static void DisableVertexAttribArray(UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDispatchCompute", ExactSpelling = true)]
            internal extern static void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDispatchComputeGroupSizeARB", ExactSpelling = true)]
            internal extern static void DispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDispatchComputeIndirect", ExactSpelling = true)]
            internal extern static void DispatchComputeIndirect(IntPtr indirect);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysIndirect", ExactSpelling = true)]
            internal extern static void DrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstanced", ExactSpelling = true)]
            internal extern static void DrawArraysInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstancedBaseInstance", ExactSpelling = true)]
            internal extern static void DrawArraysInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
            internal extern static void DrawBuffer(OpenTK.Graphics.OpenGL4.DrawBufferMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffers(Int32 n, OpenTK.Graphics.OpenGL4.DrawBuffersEnum* bufs);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
            internal extern static void DrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsIndirect", ExactSpelling = true)]
            internal extern static void DrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstanced", ExactSpelling = true)]
            internal extern static void DrawElementsInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedBaseInstance", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
            internal extern static void DrawRangeElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
            internal extern static void DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTransformFeedback", ExactSpelling = true)]
            internal extern static void DrawTransformFeedback(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTransformFeedbackInstanced", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, Int32 instancecount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTransformFeedbackStream", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackStream(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTransformFeedbackStreamInstanced", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackStreamInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnablei", ExactSpelling = true)]
            internal extern static void Enablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal extern static void EnableVertexAttribArray(UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndConditionalRender", ExactSpelling = true)]
            internal extern static void EndConditionalRender();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
            internal extern static void EndQuery(OpenTK.Graphics.OpenGL4.QueryTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndQueryIndexed", ExactSpelling = true)]
            internal extern static void EndQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndTransformFeedback", ExactSpelling = true)]
            internal extern static void EndTransformFeedback();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFenceSync", ExactSpelling = true)]
            internal extern static IntPtr FenceSync(OpenTK.Graphics.OpenGL4.SyncCondition condition, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal extern static void Finish();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal extern static void Flush();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushMappedBufferRange", ExactSpelling = true)]
            internal extern static void FlushMappedBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferParameteri", ExactSpelling = true)]
            internal extern static void FramebufferParameteri(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
            internal extern static void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
            internal extern static void FramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture1D", ExactSpelling = true)]
            internal extern static void FramebufferTexture1D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
            internal extern static void FramebufferTexture2D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture3D", ExactSpelling = true)]
            internal extern static void FramebufferTexture3D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureLayer", ExactSpelling = true)]
            internal extern static void FramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace(OpenTK.Graphics.OpenGL4.FrontFaceDirection mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal extern static unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
            internal extern static void GenerateMipmap(OpenTK.Graphics.OpenGL4.GenerateMipmapTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
            internal extern static unsafe void GenProgramPipelines(Int32 n, [OutAttribute] UInt32* pipelines);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
            internal extern static unsafe void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenSamplers", ExactSpelling = true)]
            internal extern static unsafe void GenSamplers(Int32 count, [OutAttribute] UInt32* samplers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTransformFeedbacks", ExactSpelling = true)]
            internal extern static unsafe void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenVertexArrays", ExactSpelling = true)]
            internal extern static unsafe void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveAtomicCounterBufferiv", ExactSpelling = true)]
            internal extern static unsafe void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenTK.Graphics.OpenGL4.AtomicCounterBufferParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal extern static unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveSubroutineName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveSubroutineName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveSubroutineUniformiv", ExactSpelling = true)]
            internal extern static unsafe void GetActiveSubroutineUniformiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute] Int32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveSubroutineUniformName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveSubroutineUniformName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformBlockiv", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformBlockName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformsiv", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal extern static unsafe void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal extern static Int32 GetAttribLocation(UInt32 program, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBooleani_v", ExactSpelling = true)]
            internal extern static unsafe void GetBooleani_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] bool* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal extern static unsafe void GetBooleanv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] bool* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteri64v(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteriv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
            internal extern static void GetBufferPointerv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferPointer pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
            internal extern static void GetBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTable", ExactSpelling = true)]
            internal extern static void GetColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr table);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
            internal extern static void GetCompressedTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
            internal extern static void GetConvolutionFilter(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDebugMessageLog", ExactSpelling = true)]
            internal extern static unsafe Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDebugMessageLogARB", ExactSpelling = true)]
            internal extern static unsafe Int32 GetDebugMessageLogARB(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDebugMessageLogKHR", ExactSpelling = true)]
            internal extern static unsafe Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
            internal extern static unsafe void GetDoublei_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Double* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
            internal extern static unsafe void GetDoublev(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Double* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.OpenGL4.ErrorCode GetError();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFloati_v", ExactSpelling = true)]
            internal extern static unsafe void GetFloati_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Single* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal extern static unsafe void GetFloatv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Single* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
            internal extern static Int32 GetFragDataIndex(UInt32 program, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragDataLocation", ExactSpelling = true)]
            internal extern static Int32 GetFragDataLocation(UInt32 program, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFramebufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetGraphicsResetStatusARB", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.OpenGL4.All GetGraphicsResetStatusARB();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogram", ExactSpelling = true)]
            internal extern static void GetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameterfv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameteriv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetImageHandleARB", ExactSpelling = true)]
            internal extern static Int64 GetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.All format);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
            internal extern static unsafe void GetInteger64i_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInteger64v", ExactSpelling = true)]
            internal extern static unsafe void GetInteger64v(OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int64* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegeri_v", ExactSpelling = true)]
            internal extern static unsafe void GetIntegeri_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int32* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInternalformati64v", ExactSpelling = true)]
            internal extern static unsafe void GetInternalformati64v(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.All internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInternalformativ", ExactSpelling = true)]
            internal extern static unsafe void GetInternalformativ(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.All internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmax", ExactSpelling = true)]
            internal extern static void GetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameterfv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameteriv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
            internal extern static unsafe void GetMultisamplefv(OpenTK.Graphics.OpenGL4.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single* val);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedStringARB", ExactSpelling = true)]
            internal extern static unsafe void GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, [OutAttribute] Int32* stringlen, [OutAttribute] StringBuilder @string);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedStringivARB", ExactSpelling = true)]
            internal extern static unsafe void GetNamedStringivARB(Int32 namelen, String name, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnColorTableARB", ExactSpelling = true)]
            internal extern static void GetnColorTableARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr table);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnCompressedTexImageARB", ExactSpelling = true)]
            internal extern static void GetnCompressedTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 lod, Int32 bufSize, [OutAttribute] IntPtr img);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnConvolutionFilterARB", ExactSpelling = true)]
            internal extern static void GetnConvolutionFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnHistogramARB", ExactSpelling = true)]
            internal extern static void GetnHistogramARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMapdvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnMapdvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMapfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnMapfvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMapivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnMapivARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMinmaxARB", ExactSpelling = true)]
            internal extern static void GetnMinmaxARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPixelMapfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPixelMapfvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] Single* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPixelMapuivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPixelMapuivARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPixelMapusvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPixelMapusvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt16* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPolygonStippleARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPolygonStippleARB(Int32 bufSize, [OutAttribute] Byte* pattern);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnSeparableFilterARB", ExactSpelling = true)]
            internal extern static void GetnSeparableFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 rowBufSize, [OutAttribute] IntPtr row, Int32 columnBufSize, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnTexImageARB", ExactSpelling = true)]
            internal extern static void GetnTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr img);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformdvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformuivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectLabel", ExactSpelling = true)]
            internal extern static unsafe void GetObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectLabelKHR", ExactSpelling = true)]
            internal extern static unsafe void GetObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectPtrLabel", ExactSpelling = true)]
            internal extern static unsafe void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectPtrLabelKHR", ExactSpelling = true)]
            internal extern static unsafe void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal extern static void GetPointerv(OpenTK.Graphics.OpenGL4.GetPointervPName pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointervKHR", ExactSpelling = true)]
            internal extern static void GetPointervKHR(OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
            internal extern static unsafe void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [OutAttribute] IntPtr binary);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramInterfaceiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramInterfaceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, OpenTK.Graphics.OpenGL4.ProgramInterfaceParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramPipelineiv(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramPipelineParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramResourceIndex", ExactSpelling = true)]
            internal extern static Int32 GetProgramResourceIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramResourceiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramResourceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 propCount, OpenTK.Graphics.OpenGL4.ProgramProperty* props, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramResourceLocation", ExactSpelling = true)]
            internal extern static Int32 GetProgramResourceLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramResourceLocationIndex", ExactSpelling = true)]
            internal extern static Int32 GetProgramResourceLocationIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramResourceName", ExactSpelling = true)]
            internal extern static unsafe void GetProgramResourceName(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramStageiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramStageiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute] Int32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryIndexediv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryIndexediv(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryiv(OpenTK.Graphics.OpenGL4.QueryTarget target, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjecti64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectui64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetRenderbufferParameteriv(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
            internal extern static void GetSeparableFilter(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal extern static unsafe void GetShaderiv(UInt32 shader, OpenTK.Graphics.OpenGL4.ShaderParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
            internal extern static unsafe void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal extern static unsafe void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(OpenTK.Graphics.OpenGL4.StringName name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetStringi", ExactSpelling = true)]
            internal extern static IntPtr GetStringi(OpenTK.Graphics.OpenGL4.StringNameIndexed name, UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSubroutineIndex", ExactSpelling = true)]
            internal extern static Int32 GetSubroutineIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSubroutineUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetSubroutineUniformLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSynciv", ExactSpelling = true)]
            internal extern static unsafe void GetSynciv(IntPtr sync, OpenTK.Graphics.OpenGL4.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
            internal extern static void GetTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexLevelParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexLevelParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureHandleARB", ExactSpelling = true)]
            internal extern static Int64 GetTextureHandleARB(UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureSamplerHandleARB", ExactSpelling = true)]
            internal extern static Int64 GetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTransformFeedbackVarying", ExactSpelling = true)]
            internal extern static unsafe void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.TransformFeedbackType* type, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformBlockIndex", ExactSpelling = true)]
            internal extern static Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformdv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformIndices", ExactSpelling = true)]
            internal extern static unsafe void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetUniformLocation(UInt32 program, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformSubroutineuiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformSubroutineuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 location, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformuiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribIiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribIuiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribLdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribLui64vARB", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribLui64vARB(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] UInt64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint(OpenTK.Graphics.OpenGL4.HintTarget target, OpenTK.Graphics.OpenGL4.HintMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHistogram", ExactSpelling = true)]
            internal extern static void Histogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, Int32 width, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInvalidateBufferData", ExactSpelling = true)]
            internal extern static void InvalidateBufferData(UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInvalidateBufferSubData", ExactSpelling = true)]
            internal extern static void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInvalidateFramebuffer", ExactSpelling = true)]
            internal extern static unsafe void InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInvalidateSubFramebuffer", ExactSpelling = true)]
            internal extern static unsafe void InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInvalidateTexImage", ExactSpelling = true)]
            internal extern static void InvalidateTexImage(UInt32 texture, Int32 level);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInvalidateTexSubImage", ExactSpelling = true)]
            internal extern static void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal extern static bool IsBuffer(UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal extern static bool IsEnabled(OpenTK.Graphics.OpenGL4.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsEnabledi", ExactSpelling = true)]
            internal extern static bool IsEnabledi(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
            internal extern static bool IsFramebuffer(UInt32 framebuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsImageHandleResidentARB", ExactSpelling = true)]
            internal extern static bool IsImageHandleResidentARB(UInt64 handle);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsNamedStringARB", ExactSpelling = true)]
            internal extern static bool IsNamedStringARB(Int32 namelen, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal extern static bool IsProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
            internal extern static bool IsProgramPipeline(UInt32 pipeline);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
            internal extern static bool IsQuery(UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
            internal extern static bool IsRenderbuffer(UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsSampler", ExactSpelling = true)]
            internal extern static bool IsSampler(UInt32 sampler);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal extern static bool IsShader(UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsSync", ExactSpelling = true)]
            internal extern static bool IsSync(IntPtr sync);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal extern static bool IsTexture(UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTextureHandleResidentARB", ExactSpelling = true)]
            internal extern static bool IsTextureHandleResidentARB(UInt64 handle);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTransformFeedback", ExactSpelling = true)]
            internal extern static bool IsTransformFeedback(UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsVertexArray", ExactSpelling = true)]
            internal extern static bool IsVertexArray(UInt32 array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth(Single width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal extern static void LinkProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal extern static void LogicOp(OpenTK.Graphics.OpenGL4.LogicOp opcode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeImageHandleNonResidentARB", ExactSpelling = true)]
            internal extern static void MakeImageHandleNonResidentARB(UInt64 handle);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeImageHandleResidentARB", ExactSpelling = true)]
            internal extern static void MakeImageHandleResidentARB(UInt64 handle, OpenTK.Graphics.OpenGL4.All access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeTextureHandleNonResidentARB", ExactSpelling = true)]
            internal extern static void MakeTextureHandleNonResidentARB(UInt64 handle);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeTextureHandleResidentARB", ExactSpelling = true)]
            internal extern static void MakeTextureHandleResidentARB(UInt64 handle);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
            internal extern static IntPtr MapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferAccess access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBufferRange", ExactSpelling = true)]
            internal extern static IntPtr MapBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.OpenGL4.BufferAccessMask access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMemoryBarrier", ExactSpelling = true)]
            internal extern static void MemoryBarrier(OpenTK.Graphics.OpenGL4.MemoryBarrierFlags barriers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMinmax", ExactSpelling = true)]
            internal extern static void Minmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMinSampleShading", ExactSpelling = true)]
            internal extern static void MinSampleShading(Single value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMinSampleShadingARB", ExactSpelling = true)]
            internal extern static void MinSampleShadingARB(Single value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* first, Int32* count, Int32 drawcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArraysIndirect", ExactSpelling = true)]
            internal extern static void MultiDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArraysIndirectCountARB", ExactSpelling = true)]
            internal extern static void MultiDrawArraysIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32* basevertex);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsIndirect", ExactSpelling = true)]
            internal extern static void MultiDrawElementsIndirect(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, Int32 drawcount, Int32 stride);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsIndirectCountARB", ExactSpelling = true)]
            internal extern static void MultiDrawElementsIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP1ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP1ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP1uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP1uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP2ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP2ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP2uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP2uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP3ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP3ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP3uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP3uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP4ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP4ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP4uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP4uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedStringARB", ExactSpelling = true)]
            internal extern static void NamedStringARB(OpenTK.Graphics.OpenGL4.All type, Int32 namelen, String name, Int32 stringlen, String @string);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalP3ui", ExactSpelling = true)]
            internal extern static void NormalP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalP3uiv", ExactSpelling = true)]
            internal extern static unsafe void NormalP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectLabel", ExactSpelling = true)]
            internal extern static void ObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectLabelKHR", ExactSpelling = true)]
            internal extern static void ObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectPtrLabel", ExactSpelling = true)]
            internal extern static void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectPtrLabelKHR", ExactSpelling = true)]
            internal extern static void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPatchParameterfv", ExactSpelling = true)]
            internal extern static unsafe void PatchParameterfv(OpenTK.Graphics.OpenGL4.PatchParameterFloat pname, Single* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPatchParameteri", ExactSpelling = true)]
            internal extern static void PatchParameteri(OpenTK.Graphics.OpenGL4.PatchParameterInt pname, Int32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPauseTransformFeedback", ExactSpelling = true)]
            internal extern static void PauseTransformFeedback();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
            internal extern static void PixelStoref(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
            internal extern static void PointParameterf(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
            internal extern static unsafe void PointParameterfv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
            internal extern static void PointParameteri(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
            internal extern static unsafe void PointParameteriv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal extern static void PointSize(Single size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
            internal extern static void PolygonMode(OpenTK.Graphics.OpenGL4.MaterialFace face, OpenTK.Graphics.OpenGL4.PolygonMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal extern static void PolygonOffset(Single factor, Single units);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopDebugGroup", ExactSpelling = true)]
            internal extern static void PopDebugGroup();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopDebugGroupKHR", ExactSpelling = true)]
            internal extern static void PopDebugGroupKHR();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPrimitiveRestartIndex", ExactSpelling = true)]
            internal extern static void PrimitiveRestartIndex(UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramBinary", ExactSpelling = true)]
            internal extern static void ProgramBinary(UInt32 program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, IntPtr binary, Int32 length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameteri", ExactSpelling = true)]
            internal extern static void ProgramParameteri(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramParameterPName pname, Int32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1d", ExactSpelling = true)]
            internal extern static void ProgramUniform1d(UInt32 program, Int32 location, Double v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
            internal extern static void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
            internal extern static void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
            internal extern static void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2d", ExactSpelling = true)]
            internal extern static void ProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
            internal extern static void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
            internal extern static void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
            internal extern static void ProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3d", ExactSpelling = true)]
            internal extern static void ProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
            internal extern static void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
            internal extern static void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
            internal extern static void ProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4d", ExactSpelling = true)]
            internal extern static void ProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
            internal extern static void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
            internal extern static void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
            internal extern static void ProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformHandleui64ARB", ExactSpelling = true)]
            internal extern static void ProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformHandleui64vARB", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProvokingVertex", ExactSpelling = true)]
            internal extern static void ProvokingVertex(OpenTK.Graphics.OpenGL4.ProvokingVertexMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushDebugGroup", ExactSpelling = true)]
            internal extern static void PushDebugGroup(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, UInt32 id, Int32 length, String message);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushDebugGroupKHR", ExactSpelling = true)]
            internal extern static void PushDebugGroupKHR(OpenTK.Graphics.OpenGL4.All source, UInt32 id, Int32 length, String message);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glQueryCounter", ExactSpelling = true)]
            internal extern static void QueryCounter(UInt32 id, OpenTK.Graphics.OpenGL4.QueryCounterTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
            internal extern static void ReadBuffer(OpenTK.Graphics.OpenGL4.ReadBufferMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadnPixelsARB", ExactSpelling = true)]
            internal extern static void ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReleaseShaderCompiler", ExactSpelling = true)]
            internal extern static void ReleaseShaderCompiler();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
            internal extern static void RenderbufferStorage(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisample", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResetHistogram", ExactSpelling = true)]
            internal extern static void ResetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResetMinmax", ExactSpelling = true)]
            internal extern static void ResetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResumeTransformFeedback", ExactSpelling = true)]
            internal extern static void ResumeTransformFeedback();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage(Single value, bool invert);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleMaski", ExactSpelling = true)]
            internal extern static void SampleMaski(UInt32 index, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
            internal extern static void SamplerParameterf(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Single* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
            internal extern static void SamplerParameteri(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, Int32* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, UInt32* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Int32* param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissorArrayv", ExactSpelling = true)]
            internal extern static unsafe void ScissorArrayv(UInt32 first, Int32 count, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissorIndexed", ExactSpelling = true)]
            internal extern static void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
            internal extern static unsafe void ScissorIndexedv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorP3ui", ExactSpelling = true)]
            internal extern static void SecondaryColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorP3uiv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
            internal extern static void SeparableFilter2D(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr row, IntPtr column);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
            internal extern static unsafe void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, IntPtr binary, Int32 length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal extern static unsafe void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderStorageBlockBinding", ExactSpelling = true)]
            internal extern static void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc(OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal extern static void StencilFuncSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask(UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal extern static void StencilMaskSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp(OpenTK.Graphics.OpenGL4.StencilOp fail, OpenTK.Graphics.OpenGL4.StencilOp zfail, OpenTK.Graphics.OpenGL4.StencilOp zpass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal extern static void StencilOpSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilOp sfail, OpenTK.Graphics.OpenGL4.StencilOp dpfail, OpenTK.Graphics.OpenGL4.StencilOp dppass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexBuffer", ExactSpelling = true)]
            internal extern static void TexBuffer(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexBufferRange", ExactSpelling = true)]
            internal extern static void TexBufferRange(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP1ui", ExactSpelling = true)]
            internal extern static void TexCoordP1ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP1uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP1uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP2ui", ExactSpelling = true)]
            internal extern static void TexCoordP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP2uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP3ui", ExactSpelling = true)]
            internal extern static void TexCoordP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP3uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP4ui", ExactSpelling = true)]
            internal extern static void TexCoordP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP4uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
            internal extern static void TexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
            internal extern static void TexImage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
            internal extern static void TexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
            internal extern static void TexImage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexPageCommitmentARB", ExactSpelling = true)]
            internal extern static void TexPageCommitmentARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal extern static void TexParameteri(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void TexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage1D", ExactSpelling = true)]
            internal extern static void TexStorage1D(OpenTK.Graphics.OpenGL4.TextureTarget1d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage2D", ExactSpelling = true)]
            internal extern static void TexStorage2D(OpenTK.Graphics.OpenGL4.TextureTarget2d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage2DMultisample", ExactSpelling = true)]
            internal extern static void TexStorage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample2d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage3D", ExactSpelling = true)]
            internal extern static void TexStorage3D(OpenTK.Graphics.OpenGL4.TextureTarget3d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage3DMultisample", ExactSpelling = true)]
            internal extern static void TexStorage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample3d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
            internal extern static void TexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
            internal extern static void TexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureView", ExactSpelling = true)]
            internal extern static void TextureView(UInt32 texture, OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 origtexture, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
            internal extern static void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.OpenGL4.TransformFeedbackMode bufferMode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1d", ExactSpelling = true)]
            internal extern static void Uniform1d(Int32 location, Double x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1dv(Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
            internal extern static void Uniform1f(Int32 location, Single v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
            internal extern static void Uniform1i(Int32 location, Int32 v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1ui", ExactSpelling = true)]
            internal extern static void Uniform1ui(Int32 location, UInt32 v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1uiv(Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2d", ExactSpelling = true)]
            internal extern static void Uniform2d(Int32 location, Double x, Double y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2dv(Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
            internal extern static void Uniform2f(Int32 location, Single v0, Single v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
            internal extern static void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2ui", ExactSpelling = true)]
            internal extern static void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2uiv(Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3d", ExactSpelling = true)]
            internal extern static void Uniform3d(Int32 location, Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3dv(Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
            internal extern static void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
            internal extern static void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3ui", ExactSpelling = true)]
            internal extern static void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3uiv(Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4d", ExactSpelling = true)]
            internal extern static void Uniform4d(Int32 location, Double x, Double y, Double z, Double w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4dv(Int32 location, Int32 count, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
            internal extern static void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4fv(Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
            internal extern static void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4iv(Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4ui", ExactSpelling = true)]
            internal extern static void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4uiv(Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformBlockBinding", ExactSpelling = true)]
            internal extern static void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformHandleui64ARB", ExactSpelling = true)]
            internal extern static void UniformHandleui64ARB(Int32 location, UInt64 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformHandleui64vARB", ExactSpelling = true)]
            internal extern static unsafe void UniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x3dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x4dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x2dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x4dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x2dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x3dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformSubroutinesuiv", ExactSpelling = true)]
            internal extern static unsafe void UniformSubroutinesuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 count, UInt32* indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
            internal extern static bool UnmapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal extern static void UseProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseProgramStages", ExactSpelling = true)]
            internal extern static void UseProgramStages(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramStageMask stages, UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal extern static void ValidateProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
            internal extern static void ValidateProgramPipeline(UInt32 pipeline);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
            internal extern static void VertexAttrib1d(UInt32 index, Double x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal extern static void VertexAttrib1f(UInt32 index, Single x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
            internal extern static void VertexAttrib1s(UInt32 index, Int16 x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
            internal extern static void VertexAttrib2d(UInt32 index, Double x, Double y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal extern static void VertexAttrib2f(UInt32 index, Single x, Single y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
            internal extern static void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
            internal extern static void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal extern static void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
            internal extern static void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4bv(UInt32 index, SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
            internal extern static void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal extern static void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4iv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nbv(UInt32 index, SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Niv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nsv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nubv(UInt32 index, Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
            internal extern static void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4ubv(UInt32 index, Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4uiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4usv(UInt32 index, UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribBinding", ExactSpelling = true)]
            internal extern static void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
            internal extern static void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribFormat", ExactSpelling = true)]
            internal extern static void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribType type, bool normalized, UInt32 relativeoffset);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1i", ExactSpelling = true)]
            internal extern static void VertexAttribI1i(UInt32 index, Int32 x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI1iv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1ui", ExactSpelling = true)]
            internal extern static void VertexAttribI1ui(UInt32 index, UInt32 x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI1uiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2i", ExactSpelling = true)]
            internal extern static void VertexAttribI2i(UInt32 index, Int32 x, Int32 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI2iv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2ui", ExactSpelling = true)]
            internal extern static void VertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI2uiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3i", ExactSpelling = true)]
            internal extern static void VertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI3iv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3ui", ExactSpelling = true)]
            internal extern static void VertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI3uiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4bv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4bv(UInt32 index, SByte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4i", ExactSpelling = true)]
            internal extern static void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4iv(UInt32 index, Int32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4sv(UInt32 index, Int16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4ubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4ubv(UInt32 index, Byte* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4ui", ExactSpelling = true)]
            internal extern static void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4uiv(UInt32 index, UInt32* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4usv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4usv(UInt32 index, UInt16* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribIFormat", ExactSpelling = true)]
            internal extern static void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, UInt32 relativeoffset);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribIPointer", ExactSpelling = true)]
            internal extern static void VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
            internal extern static void VertexAttribL1d(UInt32 index, Double x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL1dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1ui64ARB", ExactSpelling = true)]
            internal extern static void VertexAttribL1ui64ARB(UInt32 index, UInt64 x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1ui64vARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL1ui64vARB(UInt32 index, UInt64* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
            internal extern static void VertexAttribL2d(UInt32 index, Double x, Double y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL2dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
            internal extern static void VertexAttribL3d(UInt32 index, Double x, Double y, Double z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL3dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
            internal extern static void VertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL4dv(UInt32 index, Double* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribLFormat", ExactSpelling = true)]
            internal extern static void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, UInt32 relativeoffset);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
            internal extern static void VertexAttribLPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
            internal extern static void VertexAttribP1ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP1uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP1uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
            internal extern static void VertexAttribP2ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP2uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP2uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
            internal extern static void VertexAttribP3ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP3uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP3uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
            internal extern static void VertexAttribP4ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP4uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal extern static void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexBindingDivisor", ExactSpelling = true)]
            internal extern static void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP2ui", ExactSpelling = true)]
            internal extern static void VertexP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP2uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP3ui", ExactSpelling = true)]
            internal extern static void VertexP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP3uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP4ui", ExactSpelling = true)]
            internal extern static void VertexP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewportArrayv", ExactSpelling = true)]
            internal extern static unsafe void ViewportArrayv(UInt32 first, Int32 count, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
            internal extern static void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
            internal extern static unsafe void ViewportIndexedfv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWaitSync", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.OpenGL4.WaitSyncStatus WaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags, UInt64 timeout);
        }
    }
}
