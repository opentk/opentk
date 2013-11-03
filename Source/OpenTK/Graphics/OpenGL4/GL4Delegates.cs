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
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgram glActiveShaderProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(OpenTK.Graphics.OpenGL4.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginConditionalRender(UInt32 id, OpenTK.Graphics.OpenGL4.ConditionalRenderType mode);
            internal static BeginConditionalRender glBeginConditionalRender;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQuery(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 id);
            internal static BeginQuery glBeginQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, UInt32 id);
            internal static BeginQueryIndexed glBeginQueryIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedback(OpenTK.Graphics.OpenGL4.BeginFeedbackMode primitiveMode);
            internal static BeginTransformFeedback glBeginTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer);
            internal static BindBufferBase glBindBufferBase;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRange glBindBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BindBuffersBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers);
            internal unsafe static BindBuffersBase glBindBuffersBase;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BindBuffersRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, IntPtr* sizes);
            internal unsafe static BindBuffersRange glBindBuffersRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocation(UInt32 program, UInt32 color, String name);
            internal static BindFragDataLocation glBindFragDataLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            internal static BindFragDataLocationIndexed glBindFragDataLocationIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.TextureAccess access, OpenTK.Graphics.OpenGL4.SizedInternalFormat format);
            internal static BindImageTexture glBindImageTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BindImageTextures(UInt32 first, Int32 count, UInt32* textures);
            internal unsafe static BindImageTextures glBindImageTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramPipeline(UInt32 pipeline);
            internal static BindProgramPipeline glBindProgramPipeline;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindSampler(UInt32 unit, UInt32 sampler);
            internal static BindSampler glBindSampler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BindSamplers(UInt32 first, Int32 count, UInt32* samplers);
            internal unsafe static BindSamplers glBindSamplers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BindTextures(UInt32 first, Int32 count, UInt32* textures);
            internal unsafe static BindTextures glBindTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackTarget target, UInt32 id);
            internal static BindTransformFeedback glBindTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArray(UInt32 array);
            internal static BindVertexArray glBindVertexArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
            internal static BindVertexBuffer glBindVertexBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);
            internal unsafe static BindVertexBuffers glBindVertexBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation(OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationi(UInt32 buf, OpenTK.Graphics.OpenGL4.Version40 mode);
            internal static BlendEquationi glBlendEquationi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend mode);
            internal static BlendEquationiARB glBlendEquationiARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparatei glBlendEquationSeparatei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend modeRGB, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend modeAlpha);
            internal static BlendEquationSeparateiARB glBlendEquationSeparateiARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactor, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunci(UInt32 buf, OpenTK.Graphics.OpenGL4.Version40 src, OpenTK.Graphics.OpenGL4.Version40 dst);
            internal static BlendFunci glBlendFunci;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunciARB(UInt32 buf, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend src, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend dst);
            internal static BlendFunciARB glBlendFunciARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.Version40 srcRGB, OpenTK.Graphics.OpenGL4.Version40 dstRGB, OpenTK.Graphics.OpenGL4.Version40 srcAlpha, OpenTK.Graphics.OpenGL4.Version40 dstAlpha);
            internal static BlendFuncSeparatei glBlendFuncSeparatei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend srcRGB, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend dstRGB, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend srcAlpha, OpenTK.Graphics.OpenGL4.ArbDrawBuffersBlend dstAlpha);
            internal static BlendFuncSeparateiARB glBlendFuncSeparateiARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.OpenGL4.ClearBufferMask mask, OpenTK.Graphics.OpenGL4.BlitFramebufferFilter filter);
            internal static BlitFramebuffer glBlitFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferUsageHint usage);
            internal static BufferData glBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags);
            internal static BufferStorage glBufferStorage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL4.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.OpenGL4.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClampColor(OpenTK.Graphics.OpenGL4.ClampColorTarget target, OpenTK.Graphics.OpenGL4.ClampColorMode clamp);
            internal static ClampColor glClampColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(OpenTK.Graphics.OpenGL4.ClearBufferMask mask);
            internal static Clear glClear;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearBufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            internal static ClearBufferData glClearBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearBufferfi(OpenTK.Graphics.OpenGL4.ClearBufferCombined buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            internal static ClearBufferfi glClearBufferfi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferfv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Single* value);
            internal unsafe static ClearBufferfv glClearBufferfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Int32* value);
            internal unsafe static ClearBufferiv glClearBufferiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, IntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            internal static ClearBufferSubData glClearBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferuiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, UInt32* value);
            internal unsafe static ClearBufferuiv glClearBufferuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepth(Double depth);
            internal static ClearDepth glClearDepth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearTexImage(UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ClearTexImage glClearTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ClearTexSubImage glClearTexSubImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL4.WaitSyncStatus ClientWaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags, UInt64 timeout);
            internal static ClientWaitSync glClientWaitSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaski(UInt32 index, bool r, bool g, bool b, bool a);
            internal static ColorMaski glColorMaski;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static ColorP3ui glColorP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP3uiv glColorP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static ColorP4ui glColorP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP4uiv glColorP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 count, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ColorSubTable glColorSubTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr table);
            internal static ColorTable glColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Single* @params);
            internal unsafe static ColorTableParameterfv glColorTableParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Int32* @params);
            internal unsafe static ColorTableParameteriv glColorTableParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);
            internal unsafe static CompileShaderIncludeARB glCompileShaderIncludeARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage1D glCompressedTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage1D glCompressedTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            internal static ConvolutionFilter1D glConvolutionFilter1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            internal static ConvolutionFilter2D glConvolutionFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterf(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single @params);
            internal static ConvolutionParameterf glConvolutionParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single* @params);
            internal unsafe static ConvolutionParameterfv glConvolutionParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteri(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32 @params);
            internal static ConvolutionParameteri glConvolutionParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32* @params);
            internal unsafe static ConvolutionParameteriv glConvolutionParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubData glCopyBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTable glCopyColorSubTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTable glCopyColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyImageSubData(UInt32 srcName, OpenTK.Graphics.OpenGL4.ImageTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenTK.Graphics.OpenGL4.ImageTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
            internal static CopyImageSubData glCopyImageSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1D glCopyTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1D glCopyTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader(OpenTK.Graphics.OpenGL4.ShaderType type);
            internal static CreateShader glCreateShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramv(OpenTK.Graphics.OpenGL4.ShaderType type, Int32 count, String[] strings);
            internal static CreateShaderProgramv glCreateShaderProgramv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreateSyncFromCLeventARB([OutAttribute] IntPtr* context, [OutAttribute] IntPtr* @event, UInt32 flags);
            internal unsafe static CreateSyncFromCLeventARB glCreateSyncFromCLeventARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(OpenTK.Graphics.OpenGL4.CullFaceMode mode);
            internal static CullFace glCullFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            internal static DebugMessageCallback glDebugMessageCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallbackARB(DebugProcArb callback, IntPtr userParam);
            internal static DebugMessageCallbackARB glDebugMessageCallbackARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            internal static DebugMessageCallbackKHR glDebugMessageCallbackKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageControl(OpenTK.Graphics.OpenGL4.DebugSourceControl source, OpenTK.Graphics.OpenGL4.DebugTypeControl type, OpenTK.Graphics.OpenGL4.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControl glDebugMessageControl;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageControlARB(OpenTK.Graphics.OpenGL4.ArbDebugOutput source, OpenTK.Graphics.OpenGL4.ArbDebugOutput type, OpenTK.Graphics.OpenGL4.ArbDebugOutput severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlARB glDebugMessageControlARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageControlKHR(OpenTK.Graphics.OpenGL4.KhrDebug source, OpenTK.Graphics.OpenGL4.KhrDebug type, OpenTK.Graphics.OpenGL4.KhrDebug severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlKHR glDebugMessageControlKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsert(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, OpenTK.Graphics.OpenGL4.DebugType type, UInt32 id, OpenTK.Graphics.OpenGL4.DebugSeverity severity, Int32 length, String buf);
            internal static DebugMessageInsert glDebugMessageInsert;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsertARB(OpenTK.Graphics.OpenGL4.ArbDebugOutput source, OpenTK.Graphics.OpenGL4.ArbDebugOutput type, UInt32 id, OpenTK.Graphics.OpenGL4.ArbDebugOutput severity, Int32 length, String buf);
            internal static DebugMessageInsertARB glDebugMessageInsertARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsertKHR(OpenTK.Graphics.OpenGL4.KhrDebug source, OpenTK.Graphics.OpenGL4.KhrDebug type, UInt32 id, OpenTK.Graphics.OpenGL4.KhrDebug severity, Int32 length, String buf);
            internal static DebugMessageInsertKHR glDebugMessageInsertKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteNamedStringARB(Int32 namelen, String name);
            internal static DeleteNamedStringARB glDeleteNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramPipelines(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelines glDeleteProgramPipelines;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteSamplers(Int32 count, UInt32* samplers);
            internal unsafe static DeleteSamplers glDeleteSamplers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteSync(IntPtr sync);
            internal static DeleteSync glDeleteSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTransformFeedbacks(Int32 n, UInt32* ids);
            internal unsafe static DeleteTransformFeedbacks glDeleteTransformFeedbacks;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArrays(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArrays glDeleteVertexArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc(OpenTK.Graphics.OpenGL4.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRange(Double near, Double far);
            internal static DepthRange glDepthRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DepthRangeArrayv(UInt32 first, Int32 count, Double* v);
            internal unsafe static DepthRangeArrayv glDepthRangeArrayv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangeIndexed(UInt32 index, Double n, Double f);
            internal static DepthRangeIndexed glDepthRangeIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static Disable glDisable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static Disablei glDisablei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
            internal static DispatchCompute glDispatchCompute;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);
            internal static DispatchComputeGroupSizeARB glDispatchComputeGroupSizeARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DispatchComputeIndirect(IntPtr indirect);
            internal static DispatchComputeIndirect glDispatchComputeIndirect;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect);
            internal static DrawArraysIndirect glDrawArraysIndirect;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount);
            internal static DrawArraysInstanced glDrawArraysInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);
            internal static DrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawBuffer(OpenTK.Graphics.OpenGL4.DrawBufferMode mode);
            internal static DrawBuffer glDrawBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffers(Int32 n, OpenTK.Graphics.OpenGL4.DrawBuffersEnum* bufs);
            internal unsafe static DrawBuffers glDrawBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawElementsBaseVertex glDrawElementsBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect);
            internal static DrawElementsIndirect glDrawElementsIndirect;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount);
            internal static DrawElementsInstanced glDrawElementsInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);
            internal static DrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex);
            internal static DrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);
            internal static DrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedback(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id);
            internal static DrawTransformFeedback glDrawTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedbackInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, Int32 instancecount);
            internal static DrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedbackStream(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream);
            internal static DrawTransformFeedbackStream glDrawTransformFeedbackStream;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedbackStreamInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount);
            internal static DrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static Enable glEnable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static Enablei glEnablei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndConditionalRender();
            internal static EndConditionalRender glEndConditionalRender;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQuery(OpenTK.Graphics.OpenGL4.QueryTarget target);
            internal static EndQuery glEndQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index);
            internal static EndQueryIndexed glEndQueryIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedback();
            internal static EndTransformFeedback glEndTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr FenceSync(OpenTK.Graphics.OpenGL4.SyncCondition condition, UInt32 flags);
            internal static FenceSync glFenceSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRange glFlushMappedBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferParameteri(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, Int32 param);
            internal static FramebufferParameteri glFramebufferParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            internal static FramebufferTexture glFramebufferTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture1D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture1D glFramebufferTexture1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3D glFramebufferTexture3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayer glFramebufferTextureLayer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(OpenTK.Graphics.OpenGL4.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmap(OpenTK.Graphics.OpenGL4.GenerateMipmapTarget target);
            internal static GenerateMipmap glGenerateMipmap;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramPipelines(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelines glGenProgramPipelines;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueries glGenQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenSamplers(Int32 count, [OutAttribute] UInt32* samplers);
            internal unsafe static GenSamplers glGenSamplers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacks glGenTransformFeedbacks;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArrays glGenVertexArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenTK.Graphics.OpenGL4.AtomicCounterBufferParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineName glGetActiveSubroutineName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineUniformiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineUniformName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineUniformName glGetActiveSubroutineUniformName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName);
            internal unsafe static GetActiveUniformName glGetActiveUniformName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleani_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] bool* data);
            internal unsafe static GetBooleani_v glGetBooleani_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteri64v(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointerv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            internal static GetBufferSubData glGetBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr table);
            internal static GetColorTable glGetColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            internal static GetCompressedTexImage glGetCompressedTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetConvolutionFilter(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr image);
            internal static GetConvolutionFilter glGetConvolutionFilter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLog glGetDebugMessageLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLogARB(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.ArbDebugOutput* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.ArbDebugOutput* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.ArbDebugOutput* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogARB glGetDebugMessageLogARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.KhrDebug* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.KhrDebug* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.KhrDebug* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogKHR glGetDebugMessageLogKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublei_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Double* data);
            internal unsafe static GetDoublei_v glGetDoublei_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublev(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Double* data);
            internal unsafe static GetDoublev glGetDoublev;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL4.ErrorCode GetError();
            internal static GetError glGetError;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloati_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Single* data);
            internal unsafe static GetFloati_v glGetFloati_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataIndex(UInt32 program, String name);
            internal static GetFragDataIndex glGetFragDataIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocation(UInt32 program, String name);
            internal static GetFragDataLocation glGetFragDataLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferParameteriv glGetFramebufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL4.ArbRobustness GetGraphicsResetStatusARB();
            internal static GetGraphicsResetStatusARB glGetGraphicsResetStatusARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            internal static GetHistogram glGetHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameteriv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 GetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.ArbBindlessTexture format);
            internal static GetImageHandleARB glGetImageHandleARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64i_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64i_v glGetInteger64i_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64v(OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64v glGetInteger64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegeri_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_v glGetIntegeri_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInternalformati64v(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.All internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int64* @params);
            internal unsafe static GetInternalformati64v glGetInternalformati64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInternalformativ(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.All internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetInternalformativ glGetInternalformativ;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            internal static GetMinmax glGetMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameteriv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultisamplefv(OpenTK.Graphics.OpenGL4.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single* val);
            internal unsafe static GetMultisamplefv glGetMultisamplefv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, [OutAttribute] Int32* stringlen, [OutAttribute] StringBuilder @string);
            internal unsafe static GetNamedStringARB glGetNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedStringivARB(Int32 namelen, String name, OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedStringivARB glGetNamedStringivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnColorTableARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, OpenTK.Graphics.OpenGL4.ArbRobustness format, OpenTK.Graphics.OpenGL4.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr table);
            internal static GetnColorTableARB glGetnColorTableARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnCompressedTexImageARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, Int32 lod, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnCompressedTexImageARB glGetnCompressedTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnConvolutionFilterARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, OpenTK.Graphics.OpenGL4.ArbRobustness format, OpenTK.Graphics.OpenGL4.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr image);
            internal static GetnConvolutionFilterARB glGetnConvolutionFilterARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnHistogramARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, bool reset, OpenTK.Graphics.OpenGL4.ArbRobustness format, OpenTK.Graphics.OpenGL4.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnHistogramARB glGetnHistogramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapdvARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, OpenTK.Graphics.OpenGL4.ArbRobustness query, Int32 bufSize, [OutAttribute] Double* v);
            internal unsafe static GetnMapdvARB glGetnMapdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapfvARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, OpenTK.Graphics.OpenGL4.ArbRobustness query, Int32 bufSize, [OutAttribute] Single* v);
            internal unsafe static GetnMapfvARB glGetnMapfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapivARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, OpenTK.Graphics.OpenGL4.ArbRobustness query, Int32 bufSize, [OutAttribute] Int32* v);
            internal unsafe static GetnMapivARB glGetnMapivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnMinmaxARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, bool reset, OpenTK.Graphics.OpenGL4.ArbRobustness format, OpenTK.Graphics.OpenGL4.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnMinmaxARB glGetnMinmaxARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapfvARB(OpenTK.Graphics.OpenGL4.ArbRobustness map, Int32 bufSize, [OutAttribute] Single* values);
            internal unsafe static GetnPixelMapfvARB glGetnPixelMapfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapuivARB(OpenTK.Graphics.OpenGL4.ArbRobustness map, Int32 bufSize, [OutAttribute] UInt32* values);
            internal unsafe static GetnPixelMapuivARB glGetnPixelMapuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapusvARB(OpenTK.Graphics.OpenGL4.ArbRobustness map, Int32 bufSize, [OutAttribute] UInt16* values);
            internal unsafe static GetnPixelMapusvARB glGetnPixelMapusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPolygonStippleARB(Int32 bufSize, [OutAttribute] Byte* pattern);
            internal unsafe static GetnPolygonStippleARB glGetnPolygonStippleARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnSeparableFilterARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, OpenTK.Graphics.OpenGL4.ArbRobustness format, OpenTK.Graphics.OpenGL4.ArbRobustness type, Int32 rowBufSize, [OutAttribute] IntPtr row, Int32 columnBufSize, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetnSeparableFilterARB glGetnSeparableFilterARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnTexImageARB(OpenTK.Graphics.OpenGL4.ArbRobustness target, Int32 level, OpenTK.Graphics.OpenGL4.ArbRobustness format, OpenTK.Graphics.OpenGL4.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnTexImageARB glGetnTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double* @params);
            internal unsafe static GetnUniformdvARB glGetnUniformdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvARB glGetnUniformfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivARB glGetnUniformivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32* @params);
            internal unsafe static GetnUniformuivARB glGetnUniformuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabel glGetObjectLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectLabelKHR(OpenTK.Graphics.OpenGL4.KhrDebug identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelKHR glGetObjectLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabel glGetObjectPtrLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabelKHR glGetObjectPtrLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerv(OpenTK.Graphics.OpenGL4.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointervKHR(OpenTK.Graphics.OpenGL4.KhrDebug pname, [OutAttribute] IntPtr @params);
            internal static GetPointervKHR glGetPointervKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinary glGetProgramBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInterfaceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, OpenTK.Graphics.OpenGL4.ProgramInterfaceParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramInterfaceiv glGetProgramInterfaceiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLog glGetProgramPipelineInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineiv(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramPipelineParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineiv glGetProgramPipelineiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetProgramResourceIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceIndex glGetProgramResourceIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramResourceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 propCount, OpenTK.Graphics.OpenGL4.ProgramProperty* props, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramResourceiv glGetProgramResourceiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetProgramResourceLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceLocation glGetProgramResourceLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetProgramResourceLocationIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceLocationIndex glGetProgramResourceLocationIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramResourceName(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetProgramResourceName glGetProgramResourceName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStageiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetProgramStageiv glGetProgramStageiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryIndexediv(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryIndexediv glGetQueryIndexediv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryiv(OpenTK.Graphics.OpenGL4.QueryTarget target, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64v glGetQueryObjecti64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectiv glGetQueryObjectiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64v glGetQueryObjectui64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameterIiv glGetSamplerParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetSamplerParameterIuiv glGetSamplerParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetSeparableFilter(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetSeparableFilter glGetSeparableFilter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.OpenGL4.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecisionType precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(OpenTK.Graphics.OpenGL4.StringName name);
            internal static GetString glGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetStringi(OpenTK.Graphics.OpenGL4.StringNameIndexed name, UInt32 index);
            internal static GetStringi glGetStringi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetSubroutineIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            internal static GetSubroutineIndex glGetSubroutineIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetSubroutineUniformLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            internal static GetSubroutineUniformLocation glGetSubroutineUniformLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSynciv(IntPtr sync, OpenTK.Graphics.OpenGL4.SyncParameter pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSynciv glGetSynciv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            internal static GetTexImage glGetTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameterIiv glGetTexParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetTexParameterIuiv glGetTexParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 GetTextureHandleARB(UInt32 texture);
            internal static GetTextureHandleARB glGetTextureHandleARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 GetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);
            internal static GetTextureSamplerHandleARB glGetTextureSamplerHandleARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            internal static GetUniformBlockIndex glGetUniformBlockIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double* @params);
            internal unsafe static GetUniformdv glGetUniformdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
            internal unsafe static GetUniformIndices glGetUniformIndices;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocation(UInt32 program, String name);
            internal static GetUniformLocation glGetUniformLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformSubroutineuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformSubroutineuiv glGetUniformSubroutineuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuiv glGetUniformuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdv glGetVertexAttribdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribLdv glGetVertexAttribLdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLui64vARB(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetVertexAttribLui64vARB glGetVertexAttribLui64vARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(OpenTK.Graphics.OpenGL4.HintTarget target, OpenTK.Graphics.OpenGL4.HintMode mode);
            internal static Hint glHint;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Histogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, Int32 width, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            internal static Histogram glHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InvalidateBufferData(UInt32 buffer);
            internal static InvalidateBufferData glInvalidateBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);
            internal static InvalidateBufferSubData glInvalidateBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments);
            internal unsafe static InvalidateFramebuffer glInvalidateFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            internal unsafe static InvalidateSubFramebuffer glInvalidateSubFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InvalidateTexImage(UInt32 texture, Int32 level);
            internal static InvalidateTexImage glInvalidateTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
            internal static InvalidateTexSubImage glInvalidateTexSubImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabledi(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static IsEnabledi glIsEnabledi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsImageHandleResidentARB(UInt64 handle);
            internal static IsImageHandleResidentARB glIsImageHandleResidentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsNamedStringARB(Int32 namelen, String name);
            internal static IsNamedStringARB glIsNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramPipeline(UInt32 pipeline);
            internal static IsProgramPipeline glIsProgramPipeline;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsQuery(UInt32 id);
            internal static IsQuery glIsQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsSampler(UInt32 sampler);
            internal static IsSampler glIsSampler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsSync(IntPtr sync);
            internal static IsSync glIsSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTextureHandleResidentARB(UInt64 handle);
            internal static IsTextureHandleResidentARB glIsTextureHandleResidentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTransformFeedback(UInt32 id);
            internal static IsTransformFeedback glIsTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArray(UInt32 array);
            internal static IsVertexArray glIsVertexArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LogicOp(OpenTK.Graphics.OpenGL4.LogicOp opcode);
            internal static LogicOp glLogicOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeImageHandleNonResidentARB(UInt64 handle);
            internal static MakeImageHandleNonResidentARB glMakeImageHandleNonResidentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeImageHandleResidentARB(UInt64 handle, OpenTK.Graphics.OpenGL4.ArbBindlessTexture access);
            internal static MakeImageHandleResidentARB glMakeImageHandleResidentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeTextureHandleNonResidentARB(UInt64 handle);
            internal static MakeTextureHandleNonResidentARB glMakeTextureHandleNonResidentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeTextureHandleResidentARB(UInt64 handle);
            internal static MakeTextureHandleResidentARB glMakeTextureHandleResidentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferAccess access);
            internal static MapBuffer glMapBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.OpenGL4.BufferAccessMask access);
            internal static MapBufferRange glMapBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MemoryBarrier(OpenTK.Graphics.OpenGL4.MemoryBarrierFlags barriers);
            internal static MemoryBarrier glMemoryBarrier;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Minmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            internal static Minmax glMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MinSampleShading(Single value);
            internal static MinSampleShading glMinSampleShading;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MinSampleShadingARB(Single value);
            internal static MinSampleShadingARB glMinSampleShadingARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* first, Int32* count, Int32 drawcount);
            internal unsafe static MultiDrawArrays glMultiDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride);
            internal static MultiDrawArraysIndirect glMultiDrawArraysIndirect;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawArraysIndirectCountARB(OpenTK.Graphics.OpenGL4.ArbIndirectParameters mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            internal static MultiDrawArraysIndirectCountARB glMultiDrawArraysIndirectCountARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount);
            internal unsafe static MultiDrawElements glMultiDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32* basevertex);
            internal unsafe static MultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawElementsIndirect(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, Int32 drawcount, Int32 stride);
            internal static MultiDrawElementsIndirect glMultiDrawElementsIndirect;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawElementsIndirectCountARB(OpenTK.Graphics.OpenGL4.ArbIndirectParameters mode, OpenTK.Graphics.OpenGL4.ArbIndirectParameters type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            internal static MultiDrawElementsIndirectCountARB glMultiDrawElementsIndirectCountARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP1ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP1ui glMultiTexCoordP1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP1uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP1uiv glMultiTexCoordP1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP2ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP2ui glMultiTexCoordP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP2uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP2uiv glMultiTexCoordP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP3ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP3ui glMultiTexCoordP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP3uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP3uiv glMultiTexCoordP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP4ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP4ui glMultiTexCoordP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP4uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP4uiv glMultiTexCoordP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedStringARB(OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude type, Int32 namelen, String name, Int32 stringlen, String @string);
            internal static NamedStringARB glNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static NormalP3ui glNormalP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static NormalP3uiv glNormalP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabel glObjectLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectLabelKHR(OpenTK.Graphics.OpenGL4.KhrDebug identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabelKHR glObjectLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabel glObjectPtrLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabelKHR glObjectPtrLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PatchParameterfv(OpenTK.Graphics.OpenGL4.PatchParameterFloat pname, Single* values);
            internal unsafe static PatchParameterfv glPatchParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PatchParameteri(OpenTK.Graphics.OpenGL4.PatchParameterInt pname, Int32 value);
            internal static PatchParameteri glPatchParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PauseTransformFeedback();
            internal static PauseTransformFeedback glPauseTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStoref(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Single param);
            internal static PixelStoref glPixelStoref;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterf(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single param);
            internal static PointParameterf glPointParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteri(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32 param);
            internal static PointParameteri glPointParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameteriv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32* @params);
            internal unsafe static PointParameteriv glPointParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonMode(OpenTK.Graphics.OpenGL4.MaterialFace face, OpenTK.Graphics.OpenGL4.PolygonMode mode);
            internal static PolygonMode glPolygonMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopDebugGroup();
            internal static PopDebugGroup glPopDebugGroup;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopDebugGroupKHR();
            internal static PopDebugGroupKHR glPopDebugGroupKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartIndex(UInt32 index);
            internal static PrimitiveRestartIndex glPrimitiveRestartIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramBinary(UInt32 program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinary glProgramBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteri(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramParameterPName pname, Int32 value);
            internal static ProgramParameteri glProgramParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1d(UInt32 program, Int32 location, Double v0);
            internal static ProgramUniform1d glProgramUniform1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform1dv glProgramUniform1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1f glProgramUniform1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fv glProgramUniform1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1i glProgramUniform1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1iv glProgramUniform1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1ui glProgramUniform1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uiv glProgramUniform1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1);
            internal static ProgramUniform2d glProgramUniform2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform2dv glProgramUniform2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2f glProgramUniform2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fv glProgramUniform2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2i glProgramUniform2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2iv glProgramUniform2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2ui glProgramUniform2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uiv glProgramUniform2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2);
            internal static ProgramUniform3d glProgramUniform3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform3dv glProgramUniform3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3f glProgramUniform3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fv glProgramUniform3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3i glProgramUniform3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3iv glProgramUniform3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3ui glProgramUniform3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uiv glProgramUniform3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3);
            internal static ProgramUniform4d glProgramUniform4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform4dv glProgramUniform4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4f glProgramUniform4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fv glProgramUniform4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4i glProgramUniform4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4iv glProgramUniform4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4ui glProgramUniform4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uiv glProgramUniform4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);
            internal static ProgramUniformHandleui64ARB glProgramUniformHandleui64ARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);
            internal unsafe static ProgramUniformHandleui64vARB glProgramUniformHandleui64vARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2dv glProgramUniformMatrix2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fv glProgramUniformMatrix2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3dv glProgramUniformMatrix3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fv glProgramUniformMatrix3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4dv glProgramUniformMatrix4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fv glProgramUniformMatrix4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProvokingVertex(OpenTK.Graphics.OpenGL4.ProvokingVertexMode mode);
            internal static ProvokingVertex glProvokingVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushDebugGroup(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroup glPushDebugGroup;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushDebugGroupKHR(OpenTK.Graphics.OpenGL4.KhrDebug source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroupKHR glPushDebugGroupKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryCounter(UInt32 id, OpenTK.Graphics.OpenGL4.QueryCounterTarget target);
            internal static QueryCounter glQueryCounter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBuffer(OpenTK.Graphics.OpenGL4.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.ArbRobustness format, OpenTK.Graphics.OpenGL4.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsARB glReadnPixelsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target);
            internal static ResetHistogram glResetHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target);
            internal static ResetMinmax glResetMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResumeTransformFeedback();
            internal static ResumeTransformFeedback glResumeTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaski(UInt32 index, UInt32 mask);
            internal static SampleMaski glSampleMaski;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameterf(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Single param);
            internal static SamplerParameterf glSamplerParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Single* param);
            internal unsafe static SamplerParameterfv glSamplerParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameteri(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Int32 param);
            internal static SamplerParameteri glSamplerParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, Int32* param);
            internal unsafe static SamplerParameterIiv glSamplerParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, UInt32* param);
            internal unsafe static SamplerParameterIuiv glSamplerParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameter pname, Int32* param);
            internal unsafe static SamplerParameteriv glSamplerParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ScissorArrayv(UInt32 first, Int32 count, Int32* v);
            internal unsafe static ScissorArrayv glScissorArrayv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            internal static ScissorIndexed glScissorIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ScissorIndexedv(UInt32 index, Int32* v);
            internal unsafe static ScissorIndexedv glScissorIndexedv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static SecondaryColorP3ui glSecondaryColorP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static SecondaryColorP3uiv glSecondaryColorP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SeparableFilter2D(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr row, IntPtr column);
            internal static SeparableFilter2D glSeparableFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
            internal static ShaderStorageBlockBinding glShaderStorageBlockBinding;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(OpenTK.Graphics.OpenGL4.StencilOp fail, OpenTK.Graphics.OpenGL4.StencilOp zfail, OpenTK.Graphics.OpenGL4.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilOp sfail, OpenTK.Graphics.OpenGL4.StencilOp dpfail, OpenTK.Graphics.OpenGL4.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBuffer(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer);
            internal static TexBuffer glTexBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBufferRange(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static TexBufferRange glTexBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP1ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP1ui glTexCoordP1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP1uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP1uiv glTexCoordP1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP2ui glTexCoordP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP2uiv glTexCoordP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP3ui glTexCoordP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP3uiv glTexCoordP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP4ui glTexCoordP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP4uiv glTexCoordP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage1D glTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            internal static TexImage2DMultisample glTexImage2DMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage3D glTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            internal static TexImage3DMultisample glTexImage3DMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexPageCommitmentARB(OpenTK.Graphics.OpenGL4.ArbSparseTexture target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident);
            internal static TexPageCommitmentARB glTexPageCommitmentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameterIiv glTexParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, UInt32* @params);
            internal unsafe static TexParameterIuiv glTexParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage1D(OpenTK.Graphics.OpenGL4.TextureTarget1d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width);
            internal static TexStorage1D glTexStorage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage2D(OpenTK.Graphics.OpenGL4.TextureTarget2d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2D glTexStorage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample2d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            internal static TexStorage2DMultisample glTexStorage2DMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage3D(OpenTK.Graphics.OpenGL4.TextureTarget3d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3D glTexStorage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample3d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            internal static TexStorage3DMultisample glTexStorage3DMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage1D glTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureView(UInt32 texture, OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 origtexture, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
            internal static TextureView glTextureView;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.OpenGL4.TransformFeedbackMode bufferMode);
            internal static TransformFeedbackVaryings glTransformFeedbackVaryings;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1d(Int32 location, Double x);
            internal static Uniform1d glUniform1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform1dv glUniform1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1f(Int32 location, Single v0);
            internal static Uniform1f glUniform1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fv glUniform1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i(Int32 location, Int32 v0);
            internal static Uniform1i glUniform1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1iv glUniform1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1ui(Int32 location, UInt32 v0);
            internal static Uniform1ui glUniform1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uiv glUniform1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2d(Int32 location, Double x, Double y);
            internal static Uniform2d glUniform2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform2dv glUniform2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
            internal static Uniform2f glUniform2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fv glUniform2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2i glUniform2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2iv glUniform2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2ui glUniform2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uiv glUniform2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3d(Int32 location, Double x, Double y, Double z);
            internal static Uniform3d glUniform3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform3dv glUniform3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3f glUniform3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fv glUniform3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3i glUniform3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3iv glUniform3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3ui glUniform3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uiv glUniform3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4d(Int32 location, Double x, Double y, Double z, Double w);
            internal static Uniform4d glUniform4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform4dv glUniform4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4f glUniform4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fv glUniform4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4i glUniform4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4iv glUniform4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4ui glUniform4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uiv glUniform4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            internal static UniformBlockBinding glUniformBlockBinding;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformHandleui64ARB(Int32 location, UInt64 value);
            internal static UniformHandleui64ARB glUniformHandleui64ARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);
            internal unsafe static UniformHandleui64vARB glUniformHandleui64vARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2dv glUniformMatrix2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x3dv glUniformMatrix2x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x4dv glUniformMatrix2x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3dv glUniformMatrix3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x2dv glUniformMatrix3x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x4dv glUniformMatrix3x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4dv glUniformMatrix4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x2dv glUniformMatrix4x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x3dv glUniformMatrix4x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformSubroutinesuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 count, UInt32* indices);
            internal unsafe static UniformSubroutinesuiv glUniformSubroutinesuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target);
            internal static UnmapBuffer glUnmapBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramStages(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramStageMask stages, UInt32 program);
            internal static UseProgramStages glUseProgramStages;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramPipeline(UInt32 pipeline);
            internal static ValidateProgramPipeline glValidateProgramPipeline;
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
            internal delegate void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
            internal static VertexAttribBinding glVertexAttribBinding;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisor glVertexAttribDivisor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribType type, bool normalized, UInt32 relativeoffset);
            internal static VertexAttribFormat glVertexAttribFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1i(UInt32 index, Int32 x);
            internal static VertexAttribI1i glVertexAttribI1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI1iv glVertexAttribI1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1ui(UInt32 index, UInt32 x);
            internal static VertexAttribI1ui glVertexAttribI1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI1uiv glVertexAttribI1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2i(UInt32 index, Int32 x, Int32 y);
            internal static VertexAttribI2i glVertexAttribI2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI2iv glVertexAttribI2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);
            internal static VertexAttribI2ui glVertexAttribI2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI2uiv glVertexAttribI2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);
            internal static VertexAttribI3i glVertexAttribI3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI3iv glVertexAttribI3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            internal static VertexAttribI3ui glVertexAttribI3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI3uiv glVertexAttribI3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttribI4bv glVertexAttribI4bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4i glVertexAttribI4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4iv glVertexAttribI4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttribI4sv glVertexAttribI4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttribI4ubv glVertexAttribI4ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4ui glVertexAttribI4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttribI4usv glVertexAttribI4usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, UInt32 relativeoffset);
            internal static VertexAttribIFormat glVertexAttribIFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointer glVertexAttribIPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1d(UInt32 index, Double x);
            internal static VertexAttribL1d glVertexAttribL1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL1dv glVertexAttribL1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1ui64ARB(UInt32 index, UInt64 x);
            internal static VertexAttribL1ui64ARB glVertexAttribL1ui64ARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1ui64vARB(UInt32 index, UInt64* v);
            internal unsafe static VertexAttribL1ui64vARB glVertexAttribL1ui64vARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2d(UInt32 index, Double x, Double y);
            internal static VertexAttribL2d glVertexAttribL2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL2dv glVertexAttribL2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttribL3d glVertexAttribL3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL3dv glVertexAttribL3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttribL4d glVertexAttribL4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL4dv glVertexAttribL4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, UInt32 relativeoffset);
            internal static VertexAttribLFormat glVertexAttribLFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribLPointer glVertexAttribLPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP1ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP1ui glVertexAttribP1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP1uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP1uiv glVertexAttribP1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP2ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP2ui glVertexAttribP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP2uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP2uiv glVertexAttribP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP3ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP3ui glVertexAttribP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP3uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP3uiv glVertexAttribP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP4ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP4ui glVertexAttribP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP4uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP4uiv glVertexAttribP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
            internal static VertexBindingDivisor glVertexBindingDivisor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP2ui glVertexP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP2uiv glVertexP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP3ui glVertexP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP3uiv glVertexP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP4ui glVertexP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP4uiv glVertexP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ViewportArrayv(UInt32 first, Int32 count, Single* v);
            internal unsafe static ViewportArrayv glViewportArrayv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            internal static ViewportIndexedf glViewportIndexedf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ViewportIndexedfv(UInt32 index, Single* v);
            internal unsafe static ViewportIndexedfv glViewportIndexedfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL4.WaitSyncStatus WaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags, UInt64 timeout);
            internal static WaitSync glWaitSync;
        }
    }
}
