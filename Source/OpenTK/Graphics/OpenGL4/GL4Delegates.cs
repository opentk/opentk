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
    using System.Security;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {
        internal static partial class Delegates
        {
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgram glActiveShaderProgram = Load_ActiveShaderProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveTexture(OpenTK.Graphics.OpenGL4.TextureUnit texture);
            internal static ActiveTexture glActiveTexture = Load_ActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader = Load_AttachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginConditionalRender(UInt32 id, OpenTK.Graphics.OpenGL4.ConditionalRenderType mode);
            internal static BeginConditionalRender glBeginConditionalRender = Load_BeginConditionalRender;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginQuery(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 id);
            internal static BeginQuery glBeginQuery = Load_BeginQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, UInt32 id);
            internal static BeginQueryIndexed glBeginQueryIndexed = Load_BeginQueryIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackPrimitiveType primitiveMode);
            internal static BeginTransformFeedback glBeginTransformFeedback = Load_BeginTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation = Load_BindAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer = Load_BindBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBufferBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer);
            internal static BindBufferBase glBindBufferBase = Load_BindBufferBase;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBufferRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRange glBindBufferRange = Load_BindBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindBuffersBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers);
            internal unsafe static BindBuffersBase glBindBuffersBase = Load_BindBuffersBase;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindBuffersRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, IntPtr* sizes);
            internal unsafe static BindBuffersRange glBindBuffersRange = Load_BindBuffersRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFragDataLocation(UInt32 program, UInt32 color, String name);
            internal static BindFragDataLocation glBindFragDataLocation = Load_BindFragDataLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            internal static BindFragDataLocationIndexed glBindFragDataLocationIndexed = Load_BindFragDataLocationIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer = Load_BindFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.TextureAccess access, OpenTK.Graphics.OpenGL4.SizedInternalFormat format);
            internal static BindImageTexture glBindImageTexture = Load_BindImageTexture;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindImageTextures(UInt32 first, Int32 count, UInt32* textures);
            internal unsafe static BindImageTextures glBindImageTextures = Load_BindImageTextures;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindProgramPipeline(UInt32 pipeline);
            internal static BindProgramPipeline glBindProgramPipeline = Load_BindProgramPipeline;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer = Load_BindRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindSampler(UInt32 unit, UInt32 sampler);
            internal static BindSampler glBindSampler = Load_BindSampler;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindSamplers(UInt32 first, Int32 count, UInt32* samplers);
            internal unsafe static BindSamplers glBindSamplers = Load_BindSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTexture(OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture = Load_BindTexture;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindTextures(UInt32 first, Int32 count, UInt32* textures);
            internal unsafe static BindTextures glBindTextures = Load_BindTextures;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackTarget target, UInt32 id);
            internal static BindTransformFeedback glBindTransformFeedback = Load_BindTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexArray(UInt32 array);
            internal static BindVertexArray glBindVertexArray = Load_BindVertexArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
            internal static BindVertexBuffer glBindVertexBuffer = Load_BindVertexBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);
            internal unsafe static BindVertexBuffers glBindVertexBuffers = Load_BindVertexBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor = Load_BlendColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquation(OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation = Load_BlendEquation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationi(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            internal static BlendEquationi glBlendEquationi = Load_BlendEquationi;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            internal static BlendEquationiARB glBlendEquationiARB = Load_BlendEquationiARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate = Load_BlendEquationSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparatei glBlendEquationSeparatei = Load_BlendEquationSeparatei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All modeRGB, OpenTK.Graphics.OpenGL4.All modeAlpha);
            internal static BlendEquationSeparateiARB glBlendEquationSeparateiARB = Load_BlendEquationSeparateiARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunc(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactor, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc = Load_BlendFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunci(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendingFactorSrc src, OpenTK.Graphics.OpenGL4.BlendingFactorDest dst);
            internal static BlendFunci glBlendFunci = Load_BlendFunci;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunciARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All src, OpenTK.Graphics.OpenGL4.All dst);
            internal static BlendFunciARB glBlendFunciARB = Load_BlendFunciARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate = Load_BlendFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendingFactorSrc srcRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dstRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc srcAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dstAlpha);
            internal static BlendFuncSeparatei glBlendFuncSeparatei = Load_BlendFuncSeparatei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All srcRGB, OpenTK.Graphics.OpenGL4.All dstRGB, OpenTK.Graphics.OpenGL4.All srcAlpha, OpenTK.Graphics.OpenGL4.All dstAlpha);
            internal static BlendFuncSeparateiARB glBlendFuncSeparateiARB = Load_BlendFuncSeparateiARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.OpenGL4.ClearBufferMask mask, OpenTK.Graphics.OpenGL4.BlitFramebufferFilter filter);
            internal static BlitFramebuffer glBlitFramebuffer = Load_BlitFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferUsageHint usage);
            internal static BufferData glBufferData = Load_BufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags);
            internal static BufferStorage glBufferStorage = Load_BufferStorage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData = Load_BufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.OpenGL4.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus = Load_CheckFramebufferStatus;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClampColor(OpenTK.Graphics.OpenGL4.ClampColorTarget target, OpenTK.Graphics.OpenGL4.ClampColorMode clamp);
            internal static ClampColor glClampColor = Load_ClampColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Clear(OpenTK.Graphics.OpenGL4.ClearBufferMask mask);
            internal static Clear glClear = Load_Clear;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearBufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            internal static ClearBufferData glClearBufferData = Load_ClearBufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearBufferfi(OpenTK.Graphics.OpenGL4.ClearBufferCombined buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            internal static ClearBufferfi glClearBufferfi = Load_ClearBufferfi;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferfv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Single* value);
            internal unsafe static ClearBufferfv glClearBufferfv = Load_ClearBufferfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Int32* value);
            internal unsafe static ClearBufferiv glClearBufferiv = Load_ClearBufferiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, IntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            internal static ClearBufferSubData glClearBufferSubData = Load_ClearBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferuiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, UInt32* value);
            internal unsafe static ClearBufferuiv glClearBufferuiv = Load_ClearBufferuiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor = Load_ClearColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepth(Double depth);
            internal static ClearDepth glClearDepth = Load_ClearDepth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf = Load_ClearDepthf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil = Load_ClearStencil;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearTexImage(UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ClearTexImage glClearTexImage = Load_ClearTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ClearTexSubImage glClearTexSubImage = Load_ClearTexSubImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.WaitSyncStatus ClientWaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.ClientWaitSyncFlags flags, UInt64 timeout);
            internal static ClientWaitSync glClientWaitSync = Load_ClientWaitSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask = Load_ColorMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMaski(UInt32 index, bool r, bool g, bool b, bool a);
            internal static ColorMaski glColorMaski = Load_ColorMaski;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static ColorP3ui glColorP3ui = Load_ColorP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP3uiv glColorP3uiv = Load_ColorP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static ColorP4ui glColorP4ui = Load_ColorP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP4uiv glColorP4uiv = Load_ColorP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 count, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ColorSubTable glColorSubTable = Load_ColorSubTable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr table);
            internal static ColorTable glColorTable = Load_ColorTable;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Single* @params);
            internal unsafe static ColorTableParameterfv glColorTableParameterfv = Load_ColorTableParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Int32* @params);
            internal unsafe static ColorTableParameteriv glColorTableParameteriv = Load_ColorTableParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader = Load_CompileShader;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void CompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);
            internal unsafe static CompileShaderIncludeARB glCompileShaderIncludeARB = Load_CompileShaderIncludeARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage1D glCompressedTexImage1D = Load_CompressedTexImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D = Load_CompressedTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D = Load_CompressedTexImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage1D glCompressedTexSubImage1D = Load_CompressedTexSubImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D = Load_CompressedTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D = Load_CompressedTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            internal static ConvolutionFilter1D glConvolutionFilter1D = Load_ConvolutionFilter1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            internal static ConvolutionFilter2D glConvolutionFilter2D = Load_ConvolutionFilter2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionParameterf(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single @params);
            internal static ConvolutionParameterf glConvolutionParameterf = Load_ConvolutionParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single* @params);
            internal unsafe static ConvolutionParameterfv glConvolutionParameterfv = Load_ConvolutionParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionParameteri(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32 @params);
            internal static ConvolutionParameteri glConvolutionParameteri = Load_ConvolutionParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32* @params);
            internal unsafe static ConvolutionParameteriv glConvolutionParameteriv = Load_ConvolutionParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubData glCopyBufferSubData = Load_CopyBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTable glCopyColorSubTable = Load_CopyColorSubTable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTable glCopyColorTable = Load_CopyColorTable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D = Load_CopyConvolutionFilter1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D = Load_CopyConvolutionFilter2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyImageSubData(UInt32 srcName, OpenTK.Graphics.OpenGL4.ImageTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenTK.Graphics.OpenGL4.ImageTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
            internal static CopyImageSubData glCopyImageSubData = Load_CopyImageSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1D glCopyTexImage1D = Load_CopyTexImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D = Load_CopyTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1D glCopyTexSubImage1D = Load_CopyTexSubImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D = Load_CopyTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D = Load_CopyTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram = Load_CreateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShader(OpenTK.Graphics.OpenGL4.ShaderType type);
            internal static CreateShader glCreateShader = Load_CreateShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShaderProgramv(OpenTK.Graphics.OpenGL4.ShaderType type, Int32 count, String[] strings);
            internal static CreateShaderProgramv glCreateShaderProgramv = Load_CreateShaderProgramv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate IntPtr CreateSyncFromCLeventARB([OutAttribute] IntPtr* context, [OutAttribute] IntPtr* @event, UInt32 flags);
            internal unsafe static CreateSyncFromCLeventARB glCreateSyncFromCLeventARB = Load_CreateSyncFromCLeventARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CullFace(OpenTK.Graphics.OpenGL4.CullFaceMode mode);
            internal static CullFace glCullFace = Load_CullFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            internal static DebugMessageCallback glDebugMessageCallback = Load_DebugMessageCallback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallbackARB(DebugProcArb callback, IntPtr userParam);
            internal static DebugMessageCallbackARB glDebugMessageCallbackARB = Load_DebugMessageCallbackARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            internal static DebugMessageCallbackKHR glDebugMessageCallbackKHR = Load_DebugMessageCallbackKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControl(OpenTK.Graphics.OpenGL4.DebugSourceControl source, OpenTK.Graphics.OpenGL4.DebugTypeControl type, OpenTK.Graphics.OpenGL4.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControl glDebugMessageControl = Load_DebugMessageControl;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControlARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlARB glDebugMessageControlARB = Load_DebugMessageControlARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControlKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlKHR glDebugMessageControlKHR = Load_DebugMessageControlKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsert(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, OpenTK.Graphics.OpenGL4.DebugType type, UInt32 id, OpenTK.Graphics.OpenGL4.DebugSeverity severity, Int32 length, String buf);
            internal static DebugMessageInsert glDebugMessageInsert = Load_DebugMessageInsert;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsertARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf);
            internal static DebugMessageInsertARB glDebugMessageInsertARB = Load_DebugMessageInsertARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsertKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf);
            internal static DebugMessageInsertKHR glDebugMessageInsertKHR = Load_DebugMessageInsertKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers = Load_DeleteBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers = Load_DeleteFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteNamedStringARB(Int32 namelen, String name);
            internal static DeleteNamedStringARB glDeleteNamedStringARB = Load_DeleteNamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram = Load_DeleteProgram;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteProgramPipelines(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelines glDeleteProgramPipelines = Load_DeleteProgramPipelines;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries = Load_DeleteQueries;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers = Load_DeleteRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteSamplers(Int32 count, UInt32* samplers);
            internal unsafe static DeleteSamplers glDeleteSamplers = Load_DeleteSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader = Load_DeleteShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteSync(IntPtr sync);
            internal static DeleteSync glDeleteSync = Load_DeleteSync;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures = Load_DeleteTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTransformFeedbacks(Int32 n, UInt32* ids);
            internal unsafe static DeleteTransformFeedbacks glDeleteTransformFeedbacks = Load_DeleteTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteVertexArrays(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArrays glDeleteVertexArrays = Load_DeleteVertexArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthFunc(OpenTK.Graphics.OpenGL4.DepthFunction func);
            internal static DepthFunc glDepthFunc = Load_DepthFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask = Load_DepthMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRange(Double near, Double far);
            internal static DepthRange glDepthRange = Load_DepthRange;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DepthRangeArrayv(UInt32 first, Int32 count, Double* v);
            internal unsafe static DepthRangeArrayv glDepthRangeArrayv = Load_DepthRangeArrayv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef = Load_DepthRangef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangeIndexed(UInt32 index, Double n, Double f);
            internal static DepthRangeIndexed glDepthRangeIndexed = Load_DepthRangeIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader = Load_DetachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static Disable glDisable = Load_Disable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static Disablei glDisablei = Load_Disablei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray = Load_DisableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
            internal static DispatchCompute glDispatchCompute = Load_DispatchCompute;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);
            internal static DispatchComputeGroupSizeARB glDispatchComputeGroupSizeARB = Load_DispatchComputeGroupSizeARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DispatchComputeIndirect(IntPtr indirect);
            internal static DispatchComputeIndirect glDispatchComputeIndirect = Load_DispatchComputeIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays = Load_DrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect);
            internal static DrawArraysIndirect glDrawArraysIndirect = Load_DrawArraysIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount);
            internal static DrawArraysInstanced glDrawArraysInstanced = Load_DrawArraysInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);
            internal static DrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance = Load_DrawArraysInstancedBaseInstance;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawBuffer(OpenTK.Graphics.OpenGL4.DrawBufferMode mode);
            internal static DrawBuffer glDrawBuffer = Load_DrawBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffers(Int32 n, OpenTK.Graphics.OpenGL4.DrawBuffersEnum* bufs);
            internal unsafe static DrawBuffers glDrawBuffers = Load_DrawBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements = Load_DrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawElementsBaseVertex glDrawElementsBaseVertex = Load_DrawElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect);
            internal static DrawElementsIndirect glDrawElementsIndirect = Load_DrawElementsIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount);
            internal static DrawElementsInstanced glDrawElementsInstanced = Load_DrawElementsInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);
            internal static DrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance = Load_DrawElementsInstancedBaseInstance;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex);
            internal static DrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex = Load_DrawElementsInstancedBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);
            internal static DrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance = Load_DrawElementsInstancedBaseVertexBaseInstance;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawRangeElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements = Load_DrawRangeElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex = Load_DrawRangeElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedback(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id);
            internal static DrawTransformFeedback glDrawTransformFeedback = Load_DrawTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedbackInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, Int32 instancecount);
            internal static DrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced = Load_DrawTransformFeedbackInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedbackStream(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream);
            internal static DrawTransformFeedbackStream glDrawTransformFeedbackStream = Load_DrawTransformFeedbackStream;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedbackStreamInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount);
            internal static DrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced = Load_DrawTransformFeedbackStreamInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static Enable glEnable = Load_Enable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static Enablei glEnablei = Load_Enablei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray = Load_EnableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndConditionalRender();
            internal static EndConditionalRender glEndConditionalRender = Load_EndConditionalRender;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndQuery(OpenTK.Graphics.OpenGL4.QueryTarget target);
            internal static EndQuery glEndQuery = Load_EndQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index);
            internal static EndQueryIndexed glEndQueryIndexed = Load_EndQueryIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndTransformFeedback();
            internal static EndTransformFeedback glEndTransformFeedback = Load_EndTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr FenceSync(OpenTK.Graphics.OpenGL4.SyncCondition condition, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags);
            internal static FenceSync glFenceSync = Load_FenceSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Finish();
            internal static Finish glFinish = Load_Finish;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Flush();
            internal static Flush glFlush = Load_Flush;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FlushMappedBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRange glFlushMappedBufferRange = Load_FlushMappedBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferParameteri(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, Int32 param);
            internal static FramebufferParameteri glFramebufferParameteri = Load_FramebufferParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer = Load_FramebufferRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            internal static FramebufferTexture glFramebufferTexture = Load_FramebufferTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture1D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture1D glFramebufferTexture1D = Load_FramebufferTexture1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D = Load_FramebufferTexture2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture3D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3D glFramebufferTexture3D = Load_FramebufferTexture3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayer glFramebufferTextureLayer = Load_FramebufferTextureLayer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrontFace(OpenTK.Graphics.OpenGL4.FrontFaceDirection mode);
            internal static FrontFace glFrontFace = Load_FrontFace;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers = Load_GenBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GenerateMipmap(OpenTK.Graphics.OpenGL4.GenerateMipmapTarget target);
            internal static GenerateMipmap glGenerateMipmap = Load_GenerateMipmap;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers = Load_GenFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenProgramPipelines(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelines glGenProgramPipelines = Load_GenProgramPipelines;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueries glGenQueries = Load_GenQueries;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers = Load_GenRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenSamplers(Int32 count, [OutAttribute] UInt32* samplers);
            internal unsafe static GenSamplers glGenSamplers = Load_GenSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures = Load_GenTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacks glGenTransformFeedbacks = Load_GenTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArrays glGenVertexArrays = Load_GenVertexArrays;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenTK.Graphics.OpenGL4.AtomicCounterBufferParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv = Load_GetActiveAtomicCounterBufferiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib = Load_GetActiveAttrib;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveSubroutineName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineName glGetActiveSubroutineName = Load_GetActiveSubroutineName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveSubroutineUniformiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv = Load_GetActiveSubroutineUniformiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveSubroutineUniformName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineUniformName glGetActiveSubroutineUniformName = Load_GetActiveSubroutineUniformName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform = Load_GetActiveUniform;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv = Load_GetActiveUniformBlockiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName = Load_GetActiveUniformBlockName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName);
            internal unsafe static GetActiveUniformName glGetActiveUniformName = Load_GetActiveUniformName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv = Load_GetActiveUniformsiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders = Load_GetAttachedShaders;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation = Load_GetAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleani_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] bool* data);
            internal unsafe static GetBooleani_v glGetBooleani_v = Load_GetBooleani_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv = Load_GetBooleanv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteri64v(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v = Load_GetBufferParameteri64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv = Load_GetBufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferPointerv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv = Load_GetBufferPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            internal static GetBufferSubData glGetBufferSubData = Load_GetBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr table);
            internal static GetColorTable glGetColorTable = Load_GetColorTable;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv = Load_GetColorTableParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv = Load_GetColorTableParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetCompressedTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            internal static GetCompressedTexImage glGetCompressedTexImage = Load_GetCompressedTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetConvolutionFilter(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr image);
            internal static GetConvolutionFilter glGetConvolutionFilter = Load_GetConvolutionFilter;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv = Load_GetConvolutionParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv = Load_GetConvolutionParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugSource* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLog glGetDebugMessageLog = Load_GetDebugMessageLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLogARB(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogARB glGetDebugMessageLogARB = Load_GetDebugMessageLogARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogKHR glGetDebugMessageLogKHR = Load_GetDebugMessageLogKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDoublei_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Double* data);
            internal unsafe static GetDoublei_v glGetDoublei_v = Load_GetDoublei_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDoublev(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Double* data);
            internal unsafe static GetDoublev glGetDoublev = Load_GetDoublev;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.ErrorCode GetError();
            internal static GetError glGetError = Load_GetError;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloati_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Single* data);
            internal unsafe static GetFloati_v glGetFloati_v = Load_GetFloati_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv = Load_GetFloatv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetFragDataIndex(UInt32 program, String name);
            internal static GetFragDataIndex glGetFragDataIndex = Load_GetFragDataIndex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetFragDataLocation(UInt32 program, String name);
            internal static GetFragDataLocation glGetFragDataLocation = Load_GetFragDataLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv = Load_GetFramebufferAttachmentParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferParameteriv glGetFramebufferParameteriv = Load_GetFramebufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.All GetGraphicsResetStatusARB();
            internal static GetGraphicsResetStatusARB glGetGraphicsResetStatusARB = Load_GetGraphicsResetStatusARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            internal static GetHistogram glGetHistogram = Load_GetHistogram;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetHistogramParameterfv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv = Load_GetHistogramParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetHistogramParameteriv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv = Load_GetHistogramParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 GetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.All format);
            internal static GetImageHandleARB glGetImageHandleARB = Load_GetImageHandleARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64i_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64i_v glGetInteger64i_v = Load_GetInteger64i_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64v(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64v glGetInteger64v = Load_GetInteger64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegeri_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_v glGetIntegeri_v = Load_GetIntegeri_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv = Load_GetIntegerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInternalformati64v(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int64* @params);
            internal unsafe static GetInternalformati64v glGetInternalformati64v = Load_GetInternalformati64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInternalformativ(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetInternalformativ glGetInternalformativ = Load_GetInternalformativ;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            internal static GetMinmax glGetMinmax = Load_GetMinmax;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMinmaxParameterfv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv = Load_GetMinmaxParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMinmaxParameteriv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv = Load_GetMinmaxParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMultisamplefv(OpenTK.Graphics.OpenGL4.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single* val);
            internal unsafe static GetMultisamplefv glGetMultisamplefv = Load_GetMultisamplefv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, [OutAttribute] Int32* stringlen, [OutAttribute] StringBuilder @string);
            internal unsafe static GetNamedStringARB glGetNamedStringARB = Load_GetNamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetNamedStringivARB(Int32 namelen, String name, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedStringivARB glGetNamedStringivARB = Load_GetNamedStringivARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnColorTableARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr table);
            internal static GetnColorTableARB glGetnColorTableARB = Load_GetnColorTableARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnCompressedTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 lod, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnCompressedTexImageARB glGetnCompressedTexImageARB = Load_GetnCompressedTexImageARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnConvolutionFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr image);
            internal static GetnConvolutionFilterARB glGetnConvolutionFilterARB = Load_GetnConvolutionFilterARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnHistogramARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnHistogramARB glGetnHistogramARB = Load_GetnHistogramARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnMapdvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Double* v);
            internal unsafe static GetnMapdvARB glGetnMapdvARB = Load_GetnMapdvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnMapfvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Single* v);
            internal unsafe static GetnMapfvARB glGetnMapfvARB = Load_GetnMapfvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnMapivARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Int32* v);
            internal unsafe static GetnMapivARB glGetnMapivARB = Load_GetnMapivARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnMinmaxARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnMinmaxARB glGetnMinmaxARB = Load_GetnMinmaxARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPixelMapfvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] Single* values);
            internal unsafe static GetnPixelMapfvARB glGetnPixelMapfvARB = Load_GetnPixelMapfvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPixelMapuivARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt32* values);
            internal unsafe static GetnPixelMapuivARB glGetnPixelMapuivARB = Load_GetnPixelMapuivARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPixelMapusvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt16* values);
            internal unsafe static GetnPixelMapusvARB glGetnPixelMapusvARB = Load_GetnPixelMapusvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPolygonStippleARB(Int32 bufSize, [OutAttribute] Byte* pattern);
            internal unsafe static GetnPolygonStippleARB glGetnPolygonStippleARB = Load_GetnPolygonStippleARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnSeparableFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 rowBufSize, [OutAttribute] IntPtr row, Int32 columnBufSize, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetnSeparableFilterARB glGetnSeparableFilterARB = Load_GetnSeparableFilterARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnTexImageARB glGetnTexImageARB = Load_GetnTexImageARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double* @params);
            internal unsafe static GetnUniformdvARB glGetnUniformdvARB = Load_GetnUniformdvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvARB glGetnUniformfvARB = Load_GetnUniformfvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivARB glGetnUniformivARB = Load_GetnUniformivARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32* @params);
            internal unsafe static GetnUniformuivARB glGetnUniformuivARB = Load_GetnUniformuivARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabel glGetObjectLabel = Load_GetObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelKHR glGetObjectLabelKHR = Load_GetObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabel glGetObjectPtrLabel = Load_GetObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabelKHR glGetObjectPtrLabelKHR = Load_GetObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointerv(OpenTK.Graphics.OpenGL4.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv = Load_GetPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointervKHR(OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] IntPtr @params);
            internal static GetPointervKHR glGetPointervKHR = Load_GetPointervKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinary glGetProgramBinary = Load_GetProgramBinary;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog = Load_GetProgramInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramInterfaceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, OpenTK.Graphics.OpenGL4.ProgramInterfaceParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramInterfaceiv glGetProgramInterfaceiv = Load_GetProgramInterfaceiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.OpenGL4.GetProgramParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv = Load_GetProgramiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLog glGetProgramPipelineInfoLog = Load_GetProgramPipelineInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineiv(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramPipelineParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineiv glGetProgramPipelineiv = Load_GetProgramPipelineiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetProgramResourceIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceIndex glGetProgramResourceIndex = Load_GetProgramResourceIndex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramResourceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 propCount, OpenTK.Graphics.OpenGL4.ProgramProperty* props, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramResourceiv glGetProgramResourceiv = Load_GetProgramResourceiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetProgramResourceLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceLocation glGetProgramResourceLocation = Load_GetProgramResourceLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetProgramResourceLocationIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceLocationIndex glGetProgramResourceLocationIndex = Load_GetProgramResourceLocationIndex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramResourceName(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetProgramResourceName glGetProgramResourceName = Load_GetProgramResourceName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramStageiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetProgramStageiv glGetProgramStageiv = Load_GetProgramStageiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryIndexediv(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryIndexediv glGetQueryIndexediv = Load_GetQueryIndexediv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryiv(OpenTK.Graphics.OpenGL4.QueryTarget target, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv = Load_GetQueryiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjecti64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64v glGetQueryObjecti64v = Load_GetQueryObjecti64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectiv glGetQueryObjectiv = Load_GetQueryObjectiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectui64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64v glGetQueryObjectui64v = Load_GetQueryObjectui64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv = Load_GetQueryObjectuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv = Load_GetRenderbufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv = Load_GetSamplerParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameterIiv glGetSamplerParameterIiv = Load_GetSamplerParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetSamplerParameterIuiv glGetSamplerParameterIuiv = Load_GetSamplerParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv = Load_GetSamplerParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetSeparableFilter(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetSeparableFilter glGetSeparableFilter = Load_GetSeparableFilter;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog = Load_GetShaderInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.OpenGL4.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv = Load_GetShaderiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat = Load_GetShaderPrecisionFormat;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource = Load_GetShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetString(OpenTK.Graphics.OpenGL4.StringName name);
            internal static GetString glGetString = Load_GetString;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetStringi(OpenTK.Graphics.OpenGL4.StringNameIndexed name, UInt32 index);
            internal static GetStringi glGetStringi = Load_GetStringi;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetSubroutineIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            internal static GetSubroutineIndex glGetSubroutineIndex = Load_GetSubroutineIndex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetSubroutineUniformLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            internal static GetSubroutineUniformLocation glGetSubroutineUniformLocation = Load_GetSubroutineUniformLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSynciv(IntPtr sync, OpenTK.Graphics.OpenGL4.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSynciv glGetSynciv = Load_GetSynciv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            internal static GetTexImage glGetTexImage = Load_GetTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexLevelParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv = Load_GetTexLevelParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexLevelParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv = Load_GetTexLevelParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv = Load_GetTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameterIiv glGetTexParameterIiv = Load_GetTexParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetTexParameterIuiv glGetTexParameterIuiv = Load_GetTexParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv = Load_GetTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 GetTextureHandleARB(UInt32 texture);
            internal static GetTextureHandleARB glGetTextureHandleARB = Load_GetTextureHandleARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 GetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);
            internal static GetTextureSamplerHandleARB glGetTextureSamplerHandleARB = Load_GetTextureSamplerHandleARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.TransformFeedbackType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying = Load_GetTransformFeedbackVarying;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            internal static GetUniformBlockIndex glGetUniformBlockIndex = Load_GetUniformBlockIndex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double* @params);
            internal unsafe static GetUniformdv glGetUniformdv = Load_GetUniformdv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv = Load_GetUniformfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
            internal unsafe static GetUniformIndices glGetUniformIndices = Load_GetUniformIndices;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv = Load_GetUniformiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetUniformLocation(UInt32 program, String name);
            internal static GetUniformLocation glGetUniformLocation = Load_GetUniformLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformSubroutineuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformSubroutineuiv glGetUniformSubroutineuiv = Load_GetUniformSubroutineuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuiv glGetUniformuiv = Load_GetUniformuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdv glGetVertexAttribdv = Load_GetVertexAttribdv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv = Load_GetVertexAttribfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv = Load_GetVertexAttribIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv = Load_GetVertexAttribIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv = Load_GetVertexAttribiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribLdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribLdv glGetVertexAttribLdv = Load_GetVertexAttribLdv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribLui64vARB(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetVertexAttribLui64vARB glGetVertexAttribLui64vARB = Load_GetVertexAttribLui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv = Load_GetVertexAttribPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Hint(OpenTK.Graphics.OpenGL4.HintTarget target, OpenTK.Graphics.OpenGL4.HintMode mode);
            internal static Hint glHint = Load_Hint;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Histogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, Int32 width, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            internal static Histogram glHistogram = Load_Histogram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateBufferData(UInt32 buffer);
            internal static InvalidateBufferData glInvalidateBufferData = Load_InvalidateBufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);
            internal static InvalidateBufferSubData glInvalidateBufferSubData = Load_InvalidateBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments);
            internal unsafe static InvalidateFramebuffer glInvalidateFramebuffer = Load_InvalidateFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            internal unsafe static InvalidateSubFramebuffer glInvalidateSubFramebuffer = Load_InvalidateSubFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateTexImage(UInt32 texture, Int32 level);
            internal static InvalidateTexImage glInvalidateTexImage = Load_InvalidateTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
            internal static InvalidateTexSubImage glInvalidateTexSubImage = Load_InvalidateTexSubImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer = Load_IsBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabled(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static IsEnabled glIsEnabled = Load_IsEnabled;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabledi(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static IsEnabledi glIsEnabledi = Load_IsEnabledi;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer = Load_IsFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsImageHandleResidentARB(UInt64 handle);
            internal static IsImageHandleResidentARB glIsImageHandleResidentARB = Load_IsImageHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsNamedStringARB(Int32 namelen, String name);
            internal static IsNamedStringARB glIsNamedStringARB = Load_IsNamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram = Load_IsProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgramPipeline(UInt32 pipeline);
            internal static IsProgramPipeline glIsProgramPipeline = Load_IsProgramPipeline;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsQuery(UInt32 id);
            internal static IsQuery glIsQuery = Load_IsQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer = Load_IsRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSampler(UInt32 sampler);
            internal static IsSampler glIsSampler = Load_IsSampler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader = Load_IsShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSync(IntPtr sync);
            internal static IsSync glIsSync = Load_IsSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture = Load_IsTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTextureHandleResidentARB(UInt64 handle);
            internal static IsTextureHandleResidentARB glIsTextureHandleResidentARB = Load_IsTextureHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTransformFeedback(UInt32 id);
            internal static IsTransformFeedback glIsTransformFeedback = Load_IsTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsVertexArray(UInt32 array);
            internal static IsVertexArray glIsVertexArray = Load_IsVertexArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth = Load_LineWidth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram = Load_LinkProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LogicOp(OpenTK.Graphics.OpenGL4.LogicOp opcode);
            internal static LogicOp glLogicOp = Load_LogicOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeImageHandleNonResidentARB(UInt64 handle);
            internal static MakeImageHandleNonResidentARB glMakeImageHandleNonResidentARB = Load_MakeImageHandleNonResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeImageHandleResidentARB(UInt64 handle, OpenTK.Graphics.OpenGL4.All access);
            internal static MakeImageHandleResidentARB glMakeImageHandleResidentARB = Load_MakeImageHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeTextureHandleNonResidentARB(UInt64 handle);
            internal static MakeTextureHandleNonResidentARB glMakeTextureHandleNonResidentARB = Load_MakeTextureHandleNonResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeTextureHandleResidentARB(UInt64 handle);
            internal static MakeTextureHandleResidentARB glMakeTextureHandleResidentARB = Load_MakeTextureHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferAccess access);
            internal static MapBuffer glMapBuffer = Load_MapBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.OpenGL4.BufferAccessMask access);
            internal static MapBufferRange glMapBufferRange = Load_MapBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MemoryBarrier(OpenTK.Graphics.OpenGL4.MemoryBarrierFlags barriers);
            internal static MemoryBarrier glMemoryBarrier = Load_MemoryBarrier;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Minmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            internal static Minmax glMinmax = Load_Minmax;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MinSampleShading(Single value);
            internal static MinSampleShading glMinSampleShading = Load_MinSampleShading;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MinSampleShadingARB(Single value);
            internal static MinSampleShadingARB glMinSampleShadingARB = Load_MinSampleShadingARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* first, Int32* count, Int32 drawcount);
            internal unsafe static MultiDrawArrays glMultiDrawArrays = Load_MultiDrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride);
            internal static MultiDrawArraysIndirect glMultiDrawArraysIndirect = Load_MultiDrawArraysIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawArraysIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            internal static MultiDrawArraysIndirectCountARB glMultiDrawArraysIndirectCountARB = Load_MultiDrawArraysIndirectCountARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount);
            internal unsafe static MultiDrawElements glMultiDrawElements = Load_MultiDrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32* basevertex);
            internal unsafe static MultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex = Load_MultiDrawElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawElementsIndirect(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, Int32 drawcount, Int32 stride);
            internal static MultiDrawElementsIndirect glMultiDrawElementsIndirect = Load_MultiDrawElementsIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawElementsIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            internal static MultiDrawElementsIndirectCountARB glMultiDrawElementsIndirectCountARB = Load_MultiDrawElementsIndirectCountARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP1ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP1ui glMultiTexCoordP1ui = Load_MultiTexCoordP1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP1uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP1uiv glMultiTexCoordP1uiv = Load_MultiTexCoordP1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP2ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP2ui glMultiTexCoordP2ui = Load_MultiTexCoordP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP2uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP2uiv glMultiTexCoordP2uiv = Load_MultiTexCoordP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP3ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP3ui glMultiTexCoordP3ui = Load_MultiTexCoordP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP3uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP3uiv glMultiTexCoordP3uiv = Load_MultiTexCoordP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP4ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP4ui glMultiTexCoordP4ui = Load_MultiTexCoordP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP4uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP4uiv glMultiTexCoordP4uiv = Load_MultiTexCoordP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void NamedStringARB(OpenTK.Graphics.OpenGL4.All type, Int32 namelen, String name, Int32 stringlen, String @string);
            internal static NamedStringARB glNamedStringARB = Load_NamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void NormalP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static NormalP3ui glNormalP3ui = Load_NormalP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void NormalP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static NormalP3uiv glNormalP3uiv = Load_NormalP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabel glObjectLabel = Load_ObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabelKHR glObjectLabelKHR = Load_ObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabel glObjectPtrLabel = Load_ObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabelKHR glObjectPtrLabelKHR = Load_ObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PatchParameterfv(OpenTK.Graphics.OpenGL4.PatchParameterFloat pname, Single* values);
            internal unsafe static PatchParameterfv glPatchParameterfv = Load_PatchParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PatchParameteri(OpenTK.Graphics.OpenGL4.PatchParameterInt pname, Int32 value);
            internal static PatchParameteri glPatchParameteri = Load_PatchParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PauseTransformFeedback();
            internal static PauseTransformFeedback glPauseTransformFeedback = Load_PauseTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStoref(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Single param);
            internal static PixelStoref glPixelStoref = Load_PixelStoref;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorei(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei = Load_PixelStorei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterf(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single param);
            internal static PointParameterf glPointParameterf = Load_PointParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterfv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv = Load_PointParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameteri(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32 param);
            internal static PointParameteri glPointParameteri = Load_PointParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameteriv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32* @params);
            internal unsafe static PointParameteriv glPointParameteriv = Load_PointParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize = Load_PointSize;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonMode(OpenTK.Graphics.OpenGL4.MaterialFace face, OpenTK.Graphics.OpenGL4.PolygonMode mode);
            internal static PolygonMode glPolygonMode = Load_PolygonMode;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset = Load_PolygonOffset;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopDebugGroup();
            internal static PopDebugGroup glPopDebugGroup = Load_PopDebugGroup;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopDebugGroupKHR();
            internal static PopDebugGroupKHR glPopDebugGroupKHR = Load_PopDebugGroupKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PrimitiveRestartIndex(UInt32 index);
            internal static PrimitiveRestartIndex glPrimitiveRestartIndex = Load_PrimitiveRestartIndex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramBinary(UInt32 program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinary glProgramBinary = Load_ProgramBinary;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramParameteri(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramParameterName pname, Int32 value);
            internal static ProgramParameteri glProgramParameteri = Load_ProgramParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1d(UInt32 program, Int32 location, Double v0);
            internal static ProgramUniform1d glProgramUniform1d = Load_ProgramUniform1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform1dv glProgramUniform1dv = Load_ProgramUniform1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1f glProgramUniform1f = Load_ProgramUniform1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fv glProgramUniform1fv = Load_ProgramUniform1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1i glProgramUniform1i = Load_ProgramUniform1i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1iv glProgramUniform1iv = Load_ProgramUniform1iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1ui glProgramUniform1ui = Load_ProgramUniform1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uiv glProgramUniform1uiv = Load_ProgramUniform1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1);
            internal static ProgramUniform2d glProgramUniform2d = Load_ProgramUniform2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform2dv glProgramUniform2dv = Load_ProgramUniform2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2f glProgramUniform2f = Load_ProgramUniform2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fv glProgramUniform2fv = Load_ProgramUniform2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2i glProgramUniform2i = Load_ProgramUniform2i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2iv glProgramUniform2iv = Load_ProgramUniform2iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2ui glProgramUniform2ui = Load_ProgramUniform2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uiv glProgramUniform2uiv = Load_ProgramUniform2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2);
            internal static ProgramUniform3d glProgramUniform3d = Load_ProgramUniform3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform3dv glProgramUniform3dv = Load_ProgramUniform3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3f glProgramUniform3f = Load_ProgramUniform3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fv glProgramUniform3fv = Load_ProgramUniform3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3i glProgramUniform3i = Load_ProgramUniform3i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3iv glProgramUniform3iv = Load_ProgramUniform3iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3ui glProgramUniform3ui = Load_ProgramUniform3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uiv glProgramUniform3uiv = Load_ProgramUniform3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3);
            internal static ProgramUniform4d glProgramUniform4d = Load_ProgramUniform4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform4dv glProgramUniform4dv = Load_ProgramUniform4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4f glProgramUniform4f = Load_ProgramUniform4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fv glProgramUniform4fv = Load_ProgramUniform4fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4i glProgramUniform4i = Load_ProgramUniform4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4iv glProgramUniform4iv = Load_ProgramUniform4iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4ui glProgramUniform4ui = Load_ProgramUniform4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uiv glProgramUniform4uiv = Load_ProgramUniform4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);
            internal static ProgramUniformHandleui64ARB glProgramUniformHandleui64ARB = Load_ProgramUniformHandleui64ARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);
            internal unsafe static ProgramUniformHandleui64vARB glProgramUniformHandleui64vARB = Load_ProgramUniformHandleui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2dv glProgramUniformMatrix2dv = Load_ProgramUniformMatrix2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fv glProgramUniformMatrix2fv = Load_ProgramUniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv = Load_ProgramUniformMatrix2x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv = Load_ProgramUniformMatrix2x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv = Load_ProgramUniformMatrix2x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv = Load_ProgramUniformMatrix2x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3dv glProgramUniformMatrix3dv = Load_ProgramUniformMatrix3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fv glProgramUniformMatrix3fv = Load_ProgramUniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv = Load_ProgramUniformMatrix3x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv = Load_ProgramUniformMatrix3x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv = Load_ProgramUniformMatrix3x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv = Load_ProgramUniformMatrix3x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4dv glProgramUniformMatrix4dv = Load_ProgramUniformMatrix4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fv glProgramUniformMatrix4fv = Load_ProgramUniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv = Load_ProgramUniformMatrix4x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv = Load_ProgramUniformMatrix4x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv = Load_ProgramUniformMatrix4x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv = Load_ProgramUniformMatrix4x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProvokingVertex(OpenTK.Graphics.OpenGL4.ProvokingVertexMode mode);
            internal static ProvokingVertex glProvokingVertex = Load_ProvokingVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroup(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroup glPushDebugGroup = Load_PushDebugGroup;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroupKHR(OpenTK.Graphics.OpenGL4.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroupKHR glPushDebugGroupKHR = Load_PushDebugGroupKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void QueryCounter(UInt32 id, OpenTK.Graphics.OpenGL4.QueryCounterTarget target);
            internal static QueryCounter glQueryCounter = Load_QueryCounter;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadBuffer(OpenTK.Graphics.OpenGL4.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer = Load_ReadBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsARB glReadnPixelsARB = Load_ReadnPixelsARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels = Load_ReadPixels;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler = Load_ReleaseShaderCompiler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage = Load_RenderbufferStorage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample = Load_RenderbufferStorageMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target);
            internal static ResetHistogram glResetHistogram = Load_ResetHistogram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target);
            internal static ResetMinmax glResetMinmax = Load_ResetMinmax;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResumeTransformFeedback();
            internal static ResumeTransformFeedback glResumeTransformFeedback = Load_ResumeTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage = Load_SampleCoverage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleMaski(UInt32 index, UInt32 mask);
            internal static SampleMaski glSampleMaski = Load_SampleMaski;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SamplerParameterf(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Single param);
            internal static SamplerParameterf glSamplerParameterf = Load_SamplerParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Single* param);
            internal unsafe static SamplerParameterfv glSamplerParameterfv = Load_SamplerParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SamplerParameteri(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32 param);
            internal static SamplerParameteri glSamplerParameteri = Load_SamplerParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32* param);
            internal unsafe static SamplerParameterIiv glSamplerParameterIiv = Load_SamplerParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, UInt32* param);
            internal unsafe static SamplerParameterIuiv glSamplerParameterIuiv = Load_SamplerParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32* param);
            internal unsafe static SamplerParameteriv glSamplerParameteriv = Load_SamplerParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor = Load_Scissor;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ScissorArrayv(UInt32 first, Int32 count, Int32* v);
            internal unsafe static ScissorArrayv glScissorArrayv = Load_ScissorArrayv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            internal static ScissorIndexed glScissorIndexed = Load_ScissorIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ScissorIndexedv(UInt32 index, Int32* v);
            internal unsafe static ScissorIndexedv glScissorIndexedv = Load_ScissorIndexedv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SecondaryColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static SecondaryColorP3ui glSecondaryColorP3ui = Load_SecondaryColorP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SecondaryColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static SecondaryColorP3uiv glSecondaryColorP3uiv = Load_SecondaryColorP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SeparableFilter2D(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr row, IntPtr column);
            internal static SeparableFilter2D glSeparableFilter2D = Load_SeparableFilter2D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary = Load_ShaderBinary;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource = Load_ShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
            internal static ShaderStorageBlockBinding glShaderStorageBlockBinding = Load_ShaderStorageBlockBinding;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFunc(OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc = Load_StencilFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate = Load_StencilFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask = Load_StencilMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate = Load_StencilMaskSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOp(OpenTK.Graphics.OpenGL4.StencilOp fail, OpenTK.Graphics.OpenGL4.StencilOp zfail, OpenTK.Graphics.OpenGL4.StencilOp zpass);
            internal static StencilOp glStencilOp = Load_StencilOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilOp sfail, OpenTK.Graphics.OpenGL4.StencilOp dpfail, OpenTK.Graphics.OpenGL4.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate = Load_StencilOpSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexBuffer(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer);
            internal static TexBuffer glTexBuffer = Load_TexBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexBufferRange(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static TexBufferRange glTexBufferRange = Load_TexBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP1ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP1ui glTexCoordP1ui = Load_TexCoordP1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP1uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP1uiv glTexCoordP1uiv = Load_TexCoordP1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP2ui glTexCoordP2ui = Load_TexCoordP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP2uiv glTexCoordP2uiv = Load_TexCoordP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP3ui glTexCoordP3ui = Load_TexCoordP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP3uiv glTexCoordP3uiv = Load_TexCoordP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP4ui glTexCoordP4ui = Load_TexCoordP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP4uiv glTexCoordP4uiv = Load_TexCoordP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage1D glTexImage1D = Load_TexImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D = Load_TexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            internal static TexImage2DMultisample glTexImage2DMultisample = Load_TexImage2DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage3D glTexImage3D = Load_TexImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            internal static TexImage3DMultisample glTexImage3DMultisample = Load_TexImage3DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexPageCommitmentARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident);
            internal static TexPageCommitmentARB glTexPageCommitmentARB = Load_TexPageCommitmentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterf(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf = Load_TexParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv = Load_TexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameteri(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri = Load_TexParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameterIiv glTexParameterIiv = Load_TexParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, UInt32* @params);
            internal unsafe static TexParameterIuiv glTexParameterIuiv = Load_TexParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv = Load_TexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage1D(OpenTK.Graphics.OpenGL4.TextureTarget1d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width);
            internal static TexStorage1D glTexStorage1D = Load_TexStorage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2D(OpenTK.Graphics.OpenGL4.TextureTarget2d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2D glTexStorage2D = Load_TexStorage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample2d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            internal static TexStorage2DMultisample glTexStorage2DMultisample = Load_TexStorage2DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3D(OpenTK.Graphics.OpenGL4.TextureTarget3d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3D glTexStorage3D = Load_TexStorage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample3d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            internal static TexStorage3DMultisample glTexStorage3DMultisample = Load_TexStorage3DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage1D glTexSubImage1D = Load_TexSubImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D = Load_TexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D = Load_TexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureView(UInt32 texture, OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 origtexture, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
            internal static TextureView glTextureView = Load_TextureView;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.OpenGL4.TransformFeedbackMode bufferMode);
            internal static TransformFeedbackVaryings glTransformFeedbackVaryings = Load_TransformFeedbackVaryings;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1d(Int32 location, Double x);
            internal static Uniform1d glUniform1d = Load_Uniform1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform1dv glUniform1dv = Load_Uniform1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1f(Int32 location, Single v0);
            internal static Uniform1f glUniform1f = Load_Uniform1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fv glUniform1fv = Load_Uniform1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1i(Int32 location, Int32 v0);
            internal static Uniform1i glUniform1i = Load_Uniform1i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1iv glUniform1iv = Load_Uniform1iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1ui(Int32 location, UInt32 v0);
            internal static Uniform1ui glUniform1ui = Load_Uniform1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uiv glUniform1uiv = Load_Uniform1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2d(Int32 location, Double x, Double y);
            internal static Uniform2d glUniform2d = Load_Uniform2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform2dv glUniform2dv = Load_Uniform2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
            internal static Uniform2f glUniform2f = Load_Uniform2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fv glUniform2fv = Load_Uniform2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2i glUniform2i = Load_Uniform2i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2iv glUniform2iv = Load_Uniform2iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2ui glUniform2ui = Load_Uniform2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uiv glUniform2uiv = Load_Uniform2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3d(Int32 location, Double x, Double y, Double z);
            internal static Uniform3d glUniform3d = Load_Uniform3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform3dv glUniform3dv = Load_Uniform3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3f glUniform3f = Load_Uniform3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fv glUniform3fv = Load_Uniform3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3i glUniform3i = Load_Uniform3i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3iv glUniform3iv = Load_Uniform3iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3ui glUniform3ui = Load_Uniform3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uiv glUniform3uiv = Load_Uniform3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4d(Int32 location, Double x, Double y, Double z, Double w);
            internal static Uniform4d glUniform4d = Load_Uniform4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform4dv glUniform4dv = Load_Uniform4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4f glUniform4f = Load_Uniform4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fv glUniform4fv = Load_Uniform4fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4i glUniform4i = Load_Uniform4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4iv glUniform4iv = Load_Uniform4iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4ui glUniform4ui = Load_Uniform4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uiv glUniform4uiv = Load_Uniform4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            internal static UniformBlockBinding glUniformBlockBinding = Load_UniformBlockBinding;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UniformHandleui64ARB(Int32 location, UInt64 value);
            internal static UniformHandleui64ARB glUniformHandleui64ARB = Load_UniformHandleui64ARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);
            internal unsafe static UniformHandleui64vARB glUniformHandleui64vARB = Load_UniformHandleui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2dv glUniformMatrix2dv = Load_UniformMatrix2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv = Load_UniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x3dv glUniformMatrix2x3dv = Load_UniformMatrix2x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv = Load_UniformMatrix2x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x4dv glUniformMatrix2x4dv = Load_UniformMatrix2x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv = Load_UniformMatrix2x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3dv glUniformMatrix3dv = Load_UniformMatrix3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv = Load_UniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x2dv glUniformMatrix3x2dv = Load_UniformMatrix3x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv = Load_UniformMatrix3x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x4dv glUniformMatrix3x4dv = Load_UniformMatrix3x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv = Load_UniformMatrix3x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4dv glUniformMatrix4dv = Load_UniformMatrix4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv = Load_UniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x2dv glUniformMatrix4x2dv = Load_UniformMatrix4x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv = Load_UniformMatrix4x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x3dv glUniformMatrix4x3dv = Load_UniformMatrix4x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv = Load_UniformMatrix4x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformSubroutinesuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 count, UInt32* indices);
            internal unsafe static UniformSubroutinesuiv glUniformSubroutinesuiv = Load_UniformSubroutinesuiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool UnmapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target);
            internal static UnmapBuffer glUnmapBuffer = Load_UnmapBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram = Load_UseProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgramStages(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramStageMask stages, UInt32 program);
            internal static UseProgramStages glUseProgramStages = Load_UseProgramStages;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram = Load_ValidateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgramPipeline(UInt32 pipeline);
            internal static ValidateProgramPipeline glValidateProgramPipeline = Load_ValidateProgramPipeline;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1d(UInt32 index, Double x);
            internal static VertexAttrib1d glVertexAttrib1d = Load_VertexAttrib1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dv glVertexAttrib1dv = Load_VertexAttrib1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f = Load_VertexAttrib1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv = Load_VertexAttrib1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1s(UInt32 index, Int16 x);
            internal static VertexAttrib1s glVertexAttrib1s = Load_VertexAttrib1s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1sv glVertexAttrib1sv = Load_VertexAttrib1sv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2d(UInt32 index, Double x, Double y);
            internal static VertexAttrib2d glVertexAttrib2d = Load_VertexAttrib2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dv glVertexAttrib2dv = Load_VertexAttrib2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f = Load_VertexAttrib2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv = Load_VertexAttrib2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2s glVertexAttrib2s = Load_VertexAttrib2s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2sv glVertexAttrib2sv = Load_VertexAttrib2sv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3d glVertexAttrib3d = Load_VertexAttrib3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dv glVertexAttrib3dv = Load_VertexAttrib3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f = Load_VertexAttrib3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv = Load_VertexAttrib3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3s glVertexAttrib3s = Load_VertexAttrib3s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3sv glVertexAttrib3sv = Load_VertexAttrib3sv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bv glVertexAttrib4bv = Load_VertexAttrib4bv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4d glVertexAttrib4d = Load_VertexAttrib4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dv glVertexAttrib4dv = Load_VertexAttrib4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f = Load_VertexAttrib4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv = Load_VertexAttrib4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4iv glVertexAttrib4iv = Load_VertexAttrib4iv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nbv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv = Load_VertexAttrib4Nbv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Niv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv = Load_VertexAttrib4Niv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nsv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv = Load_VertexAttrib4Nsv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4Nub glVertexAttrib4Nub = Load_VertexAttrib4Nub;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv = Load_VertexAttrib4Nubv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv = Load_VertexAttrib4Nuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv = Load_VertexAttrib4Nusv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4s glVertexAttrib4s = Load_VertexAttrib4s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4sv glVertexAttrib4sv = Load_VertexAttrib4sv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv = Load_VertexAttrib4ubv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv = Load_VertexAttrib4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usv glVertexAttrib4usv = Load_VertexAttrib4usv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
            internal static VertexAttribBinding glVertexAttribBinding = Load_VertexAttribBinding;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisor glVertexAttribDivisor = Load_VertexAttribDivisor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribType type, bool normalized, UInt32 relativeoffset);
            internal static VertexAttribFormat glVertexAttribFormat = Load_VertexAttribFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI1i(UInt32 index, Int32 x);
            internal static VertexAttribI1i glVertexAttribI1i = Load_VertexAttribI1i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI1iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI1iv glVertexAttribI1iv = Load_VertexAttribI1iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI1ui(UInt32 index, UInt32 x);
            internal static VertexAttribI1ui glVertexAttribI1ui = Load_VertexAttribI1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI1uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI1uiv glVertexAttribI1uiv = Load_VertexAttribI1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI2i(UInt32 index, Int32 x, Int32 y);
            internal static VertexAttribI2i glVertexAttribI2i = Load_VertexAttribI2i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI2iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI2iv glVertexAttribI2iv = Load_VertexAttribI2iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);
            internal static VertexAttribI2ui glVertexAttribI2ui = Load_VertexAttribI2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI2uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI2uiv glVertexAttribI2uiv = Load_VertexAttribI2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);
            internal static VertexAttribI3i glVertexAttribI3i = Load_VertexAttribI3i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI3iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI3iv glVertexAttribI3iv = Load_VertexAttribI3iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            internal static VertexAttribI3ui glVertexAttribI3ui = Load_VertexAttribI3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI3uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI3uiv glVertexAttribI3uiv = Load_VertexAttribI3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttribI4bv glVertexAttribI4bv = Load_VertexAttribI4bv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4i glVertexAttribI4i = Load_VertexAttribI4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4iv glVertexAttribI4iv = Load_VertexAttribI4iv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttribI4sv glVertexAttribI4sv = Load_VertexAttribI4sv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttribI4ubv glVertexAttribI4ubv = Load_VertexAttribI4ubv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4ui glVertexAttribI4ui = Load_VertexAttribI4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv = Load_VertexAttribI4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttribI4usv glVertexAttribI4usv = Load_VertexAttribI4usv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, UInt32 relativeoffset);
            internal static VertexAttribIFormat glVertexAttribIFormat = Load_VertexAttribIFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointer glVertexAttribIPointer = Load_VertexAttribIPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL1d(UInt32 index, Double x);
            internal static VertexAttribL1d glVertexAttribL1d = Load_VertexAttribL1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL1dv glVertexAttribL1dv = Load_VertexAttribL1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL1ui64ARB(UInt32 index, UInt64 x);
            internal static VertexAttribL1ui64ARB glVertexAttribL1ui64ARB = Load_VertexAttribL1ui64ARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL1ui64vARB(UInt32 index, UInt64* v);
            internal unsafe static VertexAttribL1ui64vARB glVertexAttribL1ui64vARB = Load_VertexAttribL1ui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL2d(UInt32 index, Double x, Double y);
            internal static VertexAttribL2d glVertexAttribL2d = Load_VertexAttribL2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL2dv glVertexAttribL2dv = Load_VertexAttribL2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttribL3d glVertexAttribL3d = Load_VertexAttribL3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL3dv glVertexAttribL3dv = Load_VertexAttribL3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttribL4d glVertexAttribL4d = Load_VertexAttribL4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL4dv glVertexAttribL4dv = Load_VertexAttribL4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, UInt32 relativeoffset);
            internal static VertexAttribLFormat glVertexAttribLFormat = Load_VertexAttribLFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribLPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribLPointer glVertexAttribLPointer = Load_VertexAttribLPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP1ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP1ui glVertexAttribP1ui = Load_VertexAttribP1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP1uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP1uiv glVertexAttribP1uiv = Load_VertexAttribP1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP2ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP2ui glVertexAttribP2ui = Load_VertexAttribP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP2uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP2uiv glVertexAttribP2uiv = Load_VertexAttribP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP3ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP3ui glVertexAttribP3ui = Load_VertexAttribP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP3uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP3uiv glVertexAttribP3uiv = Load_VertexAttribP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP4ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP4ui glVertexAttribP4ui = Load_VertexAttribP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP4uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP4uiv glVertexAttribP4uiv = Load_VertexAttribP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer = Load_VertexAttribPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
            internal static VertexBindingDivisor glVertexBindingDivisor = Load_VertexBindingDivisor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP2ui glVertexP2ui = Load_VertexP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP2uiv glVertexP2uiv = Load_VertexP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP3ui glVertexP3ui = Load_VertexP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP3uiv glVertexP3uiv = Load_VertexP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP4ui glVertexP4ui = Load_VertexP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP4uiv glVertexP4uiv = Load_VertexP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport = Load_Viewport;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ViewportArrayv(UInt32 first, Int32 count, Single* v);
            internal unsafe static ViewportArrayv glViewportArrayv = Load_ViewportArrayv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            internal static ViewportIndexedf glViewportIndexedf = Load_ViewportIndexedf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ViewportIndexedfv(UInt32 index, Single* v);
            internal unsafe static ViewportIndexedfv glViewportIndexedfv = Load_ViewportIndexedfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.WaitSyncStatus WaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags, UInt64 timeout);
            internal static WaitSync glWaitSync = Load_WaitSync;
        }
        internal static void Load_ActiveShaderProgram(UInt32 pipeline, UInt32 program)
        {
            Delegates.glActiveShaderProgram = (Delegates.ActiveShaderProgram)GetExtensionDelegateStatic("glActiveShaderProgram", typeof(Delegates.ActiveShaderProgram));
            Delegates.glActiveShaderProgram((UInt32)pipeline, (UInt32)program);
        }
        internal static void Load_ActiveTexture(OpenTK.Graphics.OpenGL4.TextureUnit texture)
        {
            Delegates.glActiveTexture = (Delegates.ActiveTexture)GetExtensionDelegateStatic("glActiveTexture", typeof(Delegates.ActiveTexture));
            Delegates.glActiveTexture((OpenTK.Graphics.OpenGL4.TextureUnit)texture);
        }
        internal static void Load_AttachShader(UInt32 program, UInt32 shader)
        {
            Delegates.glAttachShader = (Delegates.AttachShader)GetExtensionDelegateStatic("glAttachShader", typeof(Delegates.AttachShader));
            Delegates.glAttachShader((UInt32)program, (UInt32)shader);
        }
        internal static void Load_BeginConditionalRender(UInt32 id, OpenTK.Graphics.OpenGL4.ConditionalRenderType mode)
        {
            Delegates.glBeginConditionalRender = (Delegates.BeginConditionalRender)GetExtensionDelegateStatic("glBeginConditionalRender", typeof(Delegates.BeginConditionalRender));
            Delegates.glBeginConditionalRender((UInt32)id, (OpenTK.Graphics.OpenGL4.ConditionalRenderType)mode);
        }
        internal static void Load_BeginQuery(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 id)
        {
            Delegates.glBeginQuery = (Delegates.BeginQuery)GetExtensionDelegateStatic("glBeginQuery", typeof(Delegates.BeginQuery));
            Delegates.glBeginQuery((OpenTK.Graphics.OpenGL4.QueryTarget)target, (UInt32)id);
        }
        internal static void Load_BeginQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, UInt32 id)
        {
            Delegates.glBeginQueryIndexed = (Delegates.BeginQueryIndexed)GetExtensionDelegateStatic("glBeginQueryIndexed", typeof(Delegates.BeginQueryIndexed));
            Delegates.glBeginQueryIndexed((OpenTK.Graphics.OpenGL4.QueryTarget)target, (UInt32)index, (UInt32)id);
        }
        internal static void Load_BeginTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackPrimitiveType primitiveMode)
        {
            Delegates.glBeginTransformFeedback = (Delegates.BeginTransformFeedback)GetExtensionDelegateStatic("glBeginTransformFeedback", typeof(Delegates.BeginTransformFeedback));
            Delegates.glBeginTransformFeedback((OpenTK.Graphics.OpenGL4.TransformFeedbackPrimitiveType)primitiveMode);
        }
        internal static void Load_BindAttribLocation(UInt32 program, UInt32 index, String name)
        {
            Delegates.glBindAttribLocation = (Delegates.BindAttribLocation)GetExtensionDelegateStatic("glBindAttribLocation", typeof(Delegates.BindAttribLocation));
            Delegates.glBindAttribLocation((UInt32)program, (UInt32)index, (String)name);
        }
        internal static void Load_BindBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, UInt32 buffer)
        {
            Delegates.glBindBuffer = (Delegates.BindBuffer)GetExtensionDelegateStatic("glBindBuffer", typeof(Delegates.BindBuffer));
            Delegates.glBindBuffer((OpenTK.Graphics.OpenGL4.BufferTarget)target, (UInt32)buffer);
        }
        internal static void Load_BindBufferBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer)
        {
            Delegates.glBindBufferBase = (Delegates.BindBufferBase)GetExtensionDelegateStatic("glBindBufferBase", typeof(Delegates.BindBufferBase));
            Delegates.glBindBufferBase((OpenTK.Graphics.OpenGL4.BufferRangeTarget)target, (UInt32)index, (UInt32)buffer);
        }
        internal static void Load_BindBufferRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size)
        {
            Delegates.glBindBufferRange = (Delegates.BindBufferRange)GetExtensionDelegateStatic("glBindBufferRange", typeof(Delegates.BindBufferRange));
            Delegates.glBindBufferRange((OpenTK.Graphics.OpenGL4.BufferRangeTarget)target, (UInt32)index, (UInt32)buffer, (IntPtr)offset, (IntPtr)size);
        }
        internal static unsafe void Load_BindBuffersBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers)
        {
            Delegates.glBindBuffersBase = (Delegates.BindBuffersBase)GetExtensionDelegateStatic("glBindBuffersBase", typeof(Delegates.BindBuffersBase));
            Delegates.glBindBuffersBase((OpenTK.Graphics.OpenGL4.BufferRangeTarget)target, (UInt32)first, (Int32)count, (UInt32*)buffers);
        }
        internal static unsafe void Load_BindBuffersRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, IntPtr* sizes)
        {
            Delegates.glBindBuffersRange = (Delegates.BindBuffersRange)GetExtensionDelegateStatic("glBindBuffersRange", typeof(Delegates.BindBuffersRange));
            Delegates.glBindBuffersRange((OpenTK.Graphics.OpenGL4.BufferRangeTarget)target, (UInt32)first, (Int32)count, (UInt32*)buffers, (IntPtr*)offsets, (IntPtr*)sizes);
        }
        internal static void Load_BindFragDataLocation(UInt32 program, UInt32 color, String name)
        {
            Delegates.glBindFragDataLocation = (Delegates.BindFragDataLocation)GetExtensionDelegateStatic("glBindFragDataLocation", typeof(Delegates.BindFragDataLocation));
            Delegates.glBindFragDataLocation((UInt32)program, (UInt32)color, (String)name);
        }
        internal static void Load_BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name)
        {
            Delegates.glBindFragDataLocationIndexed = (Delegates.BindFragDataLocationIndexed)GetExtensionDelegateStatic("glBindFragDataLocationIndexed", typeof(Delegates.BindFragDataLocationIndexed));
            Delegates.glBindFragDataLocationIndexed((UInt32)program, (UInt32)colorNumber, (UInt32)index, (String)name);
        }
        internal static void Load_BindFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, UInt32 framebuffer)
        {
            Delegates.glBindFramebuffer = (Delegates.BindFramebuffer)GetExtensionDelegateStatic("glBindFramebuffer", typeof(Delegates.BindFramebuffer));
            Delegates.glBindFramebuffer((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (UInt32)framebuffer);
        }
        internal static void Load_BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.TextureAccess access, OpenTK.Graphics.OpenGL4.SizedInternalFormat format)
        {
            Delegates.glBindImageTexture = (Delegates.BindImageTexture)GetExtensionDelegateStatic("glBindImageTexture", typeof(Delegates.BindImageTexture));
            Delegates.glBindImageTexture((UInt32)unit, (UInt32)texture, (Int32)level, (bool)layered, (Int32)layer, (OpenTK.Graphics.OpenGL4.TextureAccess)access, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)format);
        }
        internal static unsafe void Load_BindImageTextures(UInt32 first, Int32 count, UInt32* textures)
        {
            Delegates.glBindImageTextures = (Delegates.BindImageTextures)GetExtensionDelegateStatic("glBindImageTextures", typeof(Delegates.BindImageTextures));
            Delegates.glBindImageTextures((UInt32)first, (Int32)count, (UInt32*)textures);
        }
        internal static void Load_BindProgramPipeline(UInt32 pipeline)
        {
            Delegates.glBindProgramPipeline = (Delegates.BindProgramPipeline)GetExtensionDelegateStatic("glBindProgramPipeline", typeof(Delegates.BindProgramPipeline));
            Delegates.glBindProgramPipeline((UInt32)pipeline);
        }
        internal static void Load_BindRenderbuffer(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, UInt32 renderbuffer)
        {
            Delegates.glBindRenderbuffer = (Delegates.BindRenderbuffer)GetExtensionDelegateStatic("glBindRenderbuffer", typeof(Delegates.BindRenderbuffer));
            Delegates.glBindRenderbuffer((OpenTK.Graphics.OpenGL4.RenderbufferTarget)target, (UInt32)renderbuffer);
        }
        internal static void Load_BindSampler(UInt32 unit, UInt32 sampler)
        {
            Delegates.glBindSampler = (Delegates.BindSampler)GetExtensionDelegateStatic("glBindSampler", typeof(Delegates.BindSampler));
            Delegates.glBindSampler((UInt32)unit, (UInt32)sampler);
        }
        internal static unsafe void Load_BindSamplers(UInt32 first, Int32 count, UInt32* samplers)
        {
            Delegates.glBindSamplers = (Delegates.BindSamplers)GetExtensionDelegateStatic("glBindSamplers", typeof(Delegates.BindSamplers));
            Delegates.glBindSamplers((UInt32)first, (Int32)count, (UInt32*)samplers);
        }
        internal static void Load_BindTexture(OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 texture)
        {
            Delegates.glBindTexture = (Delegates.BindTexture)GetExtensionDelegateStatic("glBindTexture", typeof(Delegates.BindTexture));
            Delegates.glBindTexture((OpenTK.Graphics.OpenGL4.TextureTarget)target, (UInt32)texture);
        }
        internal static unsafe void Load_BindTextures(UInt32 first, Int32 count, UInt32* textures)
        {
            Delegates.glBindTextures = (Delegates.BindTextures)GetExtensionDelegateStatic("glBindTextures", typeof(Delegates.BindTextures));
            Delegates.glBindTextures((UInt32)first, (Int32)count, (UInt32*)textures);
        }
        internal static void Load_BindTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackTarget target, UInt32 id)
        {
            Delegates.glBindTransformFeedback = (Delegates.BindTransformFeedback)GetExtensionDelegateStatic("glBindTransformFeedback", typeof(Delegates.BindTransformFeedback));
            Delegates.glBindTransformFeedback((OpenTK.Graphics.OpenGL4.TransformFeedbackTarget)target, (UInt32)id);
        }
        internal static void Load_BindVertexArray(UInt32 array)
        {
            Delegates.glBindVertexArray = (Delegates.BindVertexArray)GetExtensionDelegateStatic("glBindVertexArray", typeof(Delegates.BindVertexArray));
            Delegates.glBindVertexArray((UInt32)array);
        }
        internal static void Load_BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
        {
            Delegates.glBindVertexBuffer = (Delegates.BindVertexBuffer)GetExtensionDelegateStatic("glBindVertexBuffer", typeof(Delegates.BindVertexBuffer));
            Delegates.glBindVertexBuffer((UInt32)bindingindex, (UInt32)buffer, (IntPtr)offset, (Int32)stride);
        }
        internal static unsafe void Load_BindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides)
        {
            Delegates.glBindVertexBuffers = (Delegates.BindVertexBuffers)GetExtensionDelegateStatic("glBindVertexBuffers", typeof(Delegates.BindVertexBuffers));
            Delegates.glBindVertexBuffers((UInt32)first, (Int32)count, (UInt32*)buffers, (IntPtr*)offsets, (Int32*)strides);
        }
        internal static void Load_BlendColor(Single red, Single green, Single blue, Single alpha)
        {
            Delegates.glBlendColor = (Delegates.BlendColor)GetExtensionDelegateStatic("glBlendColor", typeof(Delegates.BlendColor));
            Delegates.glBlendColor((Single)red, (Single)green, (Single)blue, (Single)alpha);
        }
        internal static void Load_BlendEquation(OpenTK.Graphics.OpenGL4.BlendEquationMode mode)
        {
            Delegates.glBlendEquation = (Delegates.BlendEquation)GetExtensionDelegateStatic("glBlendEquation", typeof(Delegates.BlendEquation));
            Delegates.glBlendEquation((OpenTK.Graphics.OpenGL4.BlendEquationMode)mode);
        }
        internal static void Load_BlendEquationi(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode mode)
        {
            Delegates.glBlendEquationi = (Delegates.BlendEquationi)GetExtensionDelegateStatic("glBlendEquationi", typeof(Delegates.BlendEquationi));
            Delegates.glBlendEquationi((UInt32)buf, (OpenTK.Graphics.OpenGL4.BlendEquationMode)mode);
        }
        internal static void Load_BlendEquationiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode mode)
        {
            Delegates.glBlendEquationiARB = (Delegates.BlendEquationiARB)GetExtensionDelegateStatic("glBlendEquationiARB", typeof(Delegates.BlendEquationiARB));
            Delegates.glBlendEquationiARB((UInt32)buf, (OpenTK.Graphics.OpenGL4.BlendEquationMode)mode);
        }
        internal static void Load_BlendEquationSeparate(OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha)
        {
            Delegates.glBlendEquationSeparate = (Delegates.BlendEquationSeparate)GetExtensionDelegateStatic("glBlendEquationSeparate", typeof(Delegates.BlendEquationSeparate));
            Delegates.glBlendEquationSeparate((OpenTK.Graphics.OpenGL4.BlendEquationMode)modeRGB, (OpenTK.Graphics.OpenGL4.BlendEquationMode)modeAlpha);
        }
        internal static void Load_BlendEquationSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha)
        {
            Delegates.glBlendEquationSeparatei = (Delegates.BlendEquationSeparatei)GetExtensionDelegateStatic("glBlendEquationSeparatei", typeof(Delegates.BlendEquationSeparatei));
            Delegates.glBlendEquationSeparatei((UInt32)buf, (OpenTK.Graphics.OpenGL4.BlendEquationMode)modeRGB, (OpenTK.Graphics.OpenGL4.BlendEquationMode)modeAlpha);
        }
        internal static void Load_BlendEquationSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All modeRGB, OpenTK.Graphics.OpenGL4.All modeAlpha)
        {
            Delegates.glBlendEquationSeparateiARB = (Delegates.BlendEquationSeparateiARB)GetExtensionDelegateStatic("glBlendEquationSeparateiARB", typeof(Delegates.BlendEquationSeparateiARB));
            Delegates.glBlendEquationSeparateiARB((UInt32)buf, (OpenTK.Graphics.OpenGL4.All)modeRGB, (OpenTK.Graphics.OpenGL4.All)modeAlpha);
        }
        internal static void Load_BlendFunc(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactor, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactor)
        {
            Delegates.glBlendFunc = (Delegates.BlendFunc)GetExtensionDelegateStatic("glBlendFunc", typeof(Delegates.BlendFunc));
            Delegates.glBlendFunc((OpenTK.Graphics.OpenGL4.BlendingFactorSrc)sfactor, (OpenTK.Graphics.OpenGL4.BlendingFactorDest)dfactor);
        }
        internal static void Load_BlendFunci(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendingFactorSrc src, OpenTK.Graphics.OpenGL4.BlendingFactorDest dst)
        {
            Delegates.glBlendFunci = (Delegates.BlendFunci)GetExtensionDelegateStatic("glBlendFunci", typeof(Delegates.BlendFunci));
            Delegates.glBlendFunci((UInt32)buf, (OpenTK.Graphics.OpenGL4.BlendingFactorSrc)src, (OpenTK.Graphics.OpenGL4.BlendingFactorDest)dst);
        }
        internal static void Load_BlendFunciARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All src, OpenTK.Graphics.OpenGL4.All dst)
        {
            Delegates.glBlendFunciARB = (Delegates.BlendFunciARB)GetExtensionDelegateStatic("glBlendFunciARB", typeof(Delegates.BlendFunciARB));
            Delegates.glBlendFunciARB((UInt32)buf, (OpenTK.Graphics.OpenGL4.All)src, (OpenTK.Graphics.OpenGL4.All)dst);
        }
        internal static void Load_BlendFuncSeparate(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorAlpha)
        {
            Delegates.glBlendFuncSeparate = (Delegates.BlendFuncSeparate)GetExtensionDelegateStatic("glBlendFuncSeparate", typeof(Delegates.BlendFuncSeparate));
            Delegates.glBlendFuncSeparate((OpenTK.Graphics.OpenGL4.BlendingFactorSrc)sfactorRGB, (OpenTK.Graphics.OpenGL4.BlendingFactorDest)dfactorRGB, (OpenTK.Graphics.OpenGL4.BlendingFactorSrc)sfactorAlpha, (OpenTK.Graphics.OpenGL4.BlendingFactorDest)dfactorAlpha);
        }
        internal static void Load_BlendFuncSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendingFactorSrc srcRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dstRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc srcAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dstAlpha)
        {
            Delegates.glBlendFuncSeparatei = (Delegates.BlendFuncSeparatei)GetExtensionDelegateStatic("glBlendFuncSeparatei", typeof(Delegates.BlendFuncSeparatei));
            Delegates.glBlendFuncSeparatei((UInt32)buf, (OpenTK.Graphics.OpenGL4.BlendingFactorSrc)srcRGB, (OpenTK.Graphics.OpenGL4.BlendingFactorDest)dstRGB, (OpenTK.Graphics.OpenGL4.BlendingFactorSrc)srcAlpha, (OpenTK.Graphics.OpenGL4.BlendingFactorDest)dstAlpha);
        }
        internal static void Load_BlendFuncSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All srcRGB, OpenTK.Graphics.OpenGL4.All dstRGB, OpenTK.Graphics.OpenGL4.All srcAlpha, OpenTK.Graphics.OpenGL4.All dstAlpha)
        {
            Delegates.glBlendFuncSeparateiARB = (Delegates.BlendFuncSeparateiARB)GetExtensionDelegateStatic("glBlendFuncSeparateiARB", typeof(Delegates.BlendFuncSeparateiARB));
            Delegates.glBlendFuncSeparateiARB((UInt32)buf, (OpenTK.Graphics.OpenGL4.All)srcRGB, (OpenTK.Graphics.OpenGL4.All)dstRGB, (OpenTK.Graphics.OpenGL4.All)srcAlpha, (OpenTK.Graphics.OpenGL4.All)dstAlpha);
        }
        internal static void Load_BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.OpenGL4.ClearBufferMask mask, OpenTK.Graphics.OpenGL4.BlitFramebufferFilter filter)
        {
            Delegates.glBlitFramebuffer = (Delegates.BlitFramebuffer)GetExtensionDelegateStatic("glBlitFramebuffer", typeof(Delegates.BlitFramebuffer));
            Delegates.glBlitFramebuffer((Int32)srcX0, (Int32)srcY0, (Int32)srcX1, (Int32)srcY1, (Int32)dstX0, (Int32)dstY0, (Int32)dstX1, (Int32)dstY1, (OpenTK.Graphics.OpenGL4.ClearBufferMask)mask, (OpenTK.Graphics.OpenGL4.BlitFramebufferFilter)filter);
        }
        internal static void Load_BufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferUsageHint usage)
        {
            Delegates.glBufferData = (Delegates.BufferData)GetExtensionDelegateStatic("glBufferData", typeof(Delegates.BufferData));
            Delegates.glBufferData((OpenTK.Graphics.OpenGL4.BufferTarget)target, (IntPtr)size, (IntPtr)data, (OpenTK.Graphics.OpenGL4.BufferUsageHint)usage);
        }
        internal static void Load_BufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags)
        {
            Delegates.glBufferStorage = (Delegates.BufferStorage)GetExtensionDelegateStatic("glBufferStorage", typeof(Delegates.BufferStorage));
            Delegates.glBufferStorage((OpenTK.Graphics.OpenGL4.BufferTarget)target, (IntPtr)size, (IntPtr)data, (OpenTK.Graphics.OpenGL4.BufferStorageFlags)flags);
        }
        internal static void Load_BufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data)
        {
            Delegates.glBufferSubData = (Delegates.BufferSubData)GetExtensionDelegateStatic("glBufferSubData", typeof(Delegates.BufferSubData));
            Delegates.glBufferSubData((OpenTK.Graphics.OpenGL4.BufferTarget)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data);
        }
        internal static OpenTK.Graphics.OpenGL4.FramebufferErrorCode Load_CheckFramebufferStatus(OpenTK.Graphics.OpenGL4.FramebufferTarget target)
        {
            Delegates.glCheckFramebufferStatus = (Delegates.CheckFramebufferStatus)GetExtensionDelegateStatic("glCheckFramebufferStatus", typeof(Delegates.CheckFramebufferStatus));
            return Delegates.glCheckFramebufferStatus((OpenTK.Graphics.OpenGL4.FramebufferTarget)target);
        }
        internal static void Load_ClampColor(OpenTK.Graphics.OpenGL4.ClampColorTarget target, OpenTK.Graphics.OpenGL4.ClampColorMode clamp)
        {
            Delegates.glClampColor = (Delegates.ClampColor)GetExtensionDelegateStatic("glClampColor", typeof(Delegates.ClampColor));
            Delegates.glClampColor((OpenTK.Graphics.OpenGL4.ClampColorTarget)target, (OpenTK.Graphics.OpenGL4.ClampColorMode)clamp);
        }
        internal static void Load_Clear(OpenTK.Graphics.OpenGL4.ClearBufferMask mask)
        {
            Delegates.glClear = (Delegates.Clear)GetExtensionDelegateStatic("glClear", typeof(Delegates.Clear));
            Delegates.glClear((OpenTK.Graphics.OpenGL4.ClearBufferMask)mask);
        }
        internal static void Load_ClearBufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data)
        {
            Delegates.glClearBufferData = (Delegates.ClearBufferData)GetExtensionDelegateStatic("glClearBufferData", typeof(Delegates.ClearBufferData));
            Delegates.glClearBufferData((OpenTK.Graphics.OpenGL4.BufferTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.All)type, (IntPtr)data);
        }
        internal static void Load_ClearBufferfi(OpenTK.Graphics.OpenGL4.ClearBufferCombined buffer, Int32 drawbuffer, Single depth, Int32 stencil)
        {
            Delegates.glClearBufferfi = (Delegates.ClearBufferfi)GetExtensionDelegateStatic("glClearBufferfi", typeof(Delegates.ClearBufferfi));
            Delegates.glClearBufferfi((OpenTK.Graphics.OpenGL4.ClearBufferCombined)buffer, (Int32)drawbuffer, (Single)depth, (Int32)stencil);
        }
        internal static unsafe void Load_ClearBufferfv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Single* value)
        {
            Delegates.glClearBufferfv = (Delegates.ClearBufferfv)GetExtensionDelegateStatic("glClearBufferfv", typeof(Delegates.ClearBufferfv));
            Delegates.glClearBufferfv((OpenTK.Graphics.OpenGL4.ClearBuffer)buffer, (Int32)drawbuffer, (Single*)value);
        }
        internal static unsafe void Load_ClearBufferiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Int32* value)
        {
            Delegates.glClearBufferiv = (Delegates.ClearBufferiv)GetExtensionDelegateStatic("glClearBufferiv", typeof(Delegates.ClearBufferiv));
            Delegates.glClearBufferiv((OpenTK.Graphics.OpenGL4.ClearBuffer)buffer, (Int32)drawbuffer, (Int32*)value);
        }
        internal static void Load_ClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, IntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data)
        {
            Delegates.glClearBufferSubData = (Delegates.ClearBufferSubData)GetExtensionDelegateStatic("glClearBufferSubData", typeof(Delegates.ClearBufferSubData));
            Delegates.glClearBufferSubData((OpenTK.Graphics.OpenGL4.BufferTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (IntPtr)offset, (IntPtr)size, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.All)type, (IntPtr)data);
        }
        internal static unsafe void Load_ClearBufferuiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, UInt32* value)
        {
            Delegates.glClearBufferuiv = (Delegates.ClearBufferuiv)GetExtensionDelegateStatic("glClearBufferuiv", typeof(Delegates.ClearBufferuiv));
            Delegates.glClearBufferuiv((OpenTK.Graphics.OpenGL4.ClearBuffer)buffer, (Int32)drawbuffer, (UInt32*)value);
        }
        internal static void Load_ClearColor(Single red, Single green, Single blue, Single alpha)
        {
            Delegates.glClearColor = (Delegates.ClearColor)GetExtensionDelegateStatic("glClearColor", typeof(Delegates.ClearColor));
            Delegates.glClearColor((Single)red, (Single)green, (Single)blue, (Single)alpha);
        }
        internal static void Load_ClearDepth(Double depth)
        {
            Delegates.glClearDepth = (Delegates.ClearDepth)GetExtensionDelegateStatic("glClearDepth", typeof(Delegates.ClearDepth));
            Delegates.glClearDepth((Double)depth);
        }
        internal static void Load_ClearDepthf(Single d)
        {
            Delegates.glClearDepthf = (Delegates.ClearDepthf)GetExtensionDelegateStatic("glClearDepthf", typeof(Delegates.ClearDepthf));
            Delegates.glClearDepthf((Single)d);
        }
        internal static void Load_ClearStencil(Int32 s)
        {
            Delegates.glClearStencil = (Delegates.ClearStencil)GetExtensionDelegateStatic("glClearStencil", typeof(Delegates.ClearStencil));
            Delegates.glClearStencil((Int32)s);
        }
        internal static void Load_ClearTexImage(UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data)
        {
            Delegates.glClearTexImage = (Delegates.ClearTexImage)GetExtensionDelegateStatic("glClearTexImage", typeof(Delegates.ClearTexImage));
            Delegates.glClearTexImage((UInt32)texture, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)data);
        }
        internal static void Load_ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data)
        {
            Delegates.glClearTexSubImage = (Delegates.ClearTexSubImage)GetExtensionDelegateStatic("glClearTexSubImage", typeof(Delegates.ClearTexSubImage));
            Delegates.glClearTexSubImage((UInt32)texture, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)data);
        }
        internal static OpenTK.Graphics.OpenGL4.WaitSyncStatus Load_ClientWaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.ClientWaitSyncFlags flags, UInt64 timeout)
        {
            Delegates.glClientWaitSync = (Delegates.ClientWaitSync)GetExtensionDelegateStatic("glClientWaitSync", typeof(Delegates.ClientWaitSync));
            return Delegates.glClientWaitSync((IntPtr)sync, (OpenTK.Graphics.OpenGL4.ClientWaitSyncFlags)flags, (UInt64)timeout);
        }
        internal static void Load_ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            Delegates.glColorMask = (Delegates.ColorMask)GetExtensionDelegateStatic("glColorMask", typeof(Delegates.ColorMask));
            Delegates.glColorMask((bool)red, (bool)green, (bool)blue, (bool)alpha);
        }
        internal static void Load_ColorMaski(UInt32 index, bool r, bool g, bool b, bool a)
        {
            Delegates.glColorMaski = (Delegates.ColorMaski)GetExtensionDelegateStatic("glColorMaski", typeof(Delegates.ColorMaski));
            Delegates.glColorMaski((UInt32)index, (bool)r, (bool)g, (bool)b, (bool)a);
        }
        internal static void Load_ColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color)
        {
            Delegates.glColorP3ui = (Delegates.ColorP3ui)GetExtensionDelegateStatic("glColorP3ui", typeof(Delegates.ColorP3ui));
            Delegates.glColorP3ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)color);
        }
        internal static unsafe void Load_ColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color)
        {
            Delegates.glColorP3uiv = (Delegates.ColorP3uiv)GetExtensionDelegateStatic("glColorP3uiv", typeof(Delegates.ColorP3uiv));
            Delegates.glColorP3uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)color);
        }
        internal static void Load_ColorP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color)
        {
            Delegates.glColorP4ui = (Delegates.ColorP4ui)GetExtensionDelegateStatic("glColorP4ui", typeof(Delegates.ColorP4ui));
            Delegates.glColorP4ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)color);
        }
        internal static unsafe void Load_ColorP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color)
        {
            Delegates.glColorP4uiv = (Delegates.ColorP4uiv)GetExtensionDelegateStatic("glColorP4uiv", typeof(Delegates.ColorP4uiv));
            Delegates.glColorP4uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)color);
        }
        internal static void Load_ColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 count, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data)
        {
            Delegates.glColorSubTable = (Delegates.ColorSubTable)GetExtensionDelegateStatic("glColorSubTable", typeof(Delegates.ColorSubTable));
            Delegates.glColorSubTable((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (Int32)start, (Int32)count, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)data);
        }
        internal static void Load_ColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr table)
        {
            Delegates.glColorTable = (Delegates.ColorTable)GetExtensionDelegateStatic("glColorTable", typeof(Delegates.ColorTable));
            Delegates.glColorTable((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)table);
        }
        internal static unsafe void Load_ColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Single* @params)
        {
            Delegates.glColorTableParameterfv = (Delegates.ColorTableParameterfv)GetExtensionDelegateStatic("glColorTableParameterfv", typeof(Delegates.ColorTableParameterfv));
            Delegates.glColorTableParameterfv((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (OpenTK.Graphics.OpenGL4.ColorTableParameterPName)pname, (Single*)@params);
        }
        internal static unsafe void Load_ColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Int32* @params)
        {
            Delegates.glColorTableParameteriv = (Delegates.ColorTableParameteriv)GetExtensionDelegateStatic("glColorTableParameteriv", typeof(Delegates.ColorTableParameteriv));
            Delegates.glColorTableParameteriv((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (OpenTK.Graphics.OpenGL4.ColorTableParameterPName)pname, (Int32*)@params);
        }
        internal static void Load_CompileShader(UInt32 shader)
        {
            Delegates.glCompileShader = (Delegates.CompileShader)GetExtensionDelegateStatic("glCompileShader", typeof(Delegates.CompileShader));
            Delegates.glCompileShader((UInt32)shader);
        }
        internal static unsafe void Load_CompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length)
        {
            Delegates.glCompileShaderIncludeARB = (Delegates.CompileShaderIncludeARB)GetExtensionDelegateStatic("glCompileShaderIncludeARB", typeof(Delegates.CompileShaderIncludeARB));
            Delegates.glCompileShaderIncludeARB((UInt32)shader, (Int32)count, (String[])path, (Int32*)length);
        }
        internal static void Load_CompressedTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage1D = (Delegates.CompressedTexImage1D)GetExtensionDelegateStatic("glCompressedTexImage1D", typeof(Delegates.CompressedTexImage1D));
            Delegates.glCompressedTexImage1D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)border, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage2D = (Delegates.CompressedTexImage2D)GetExtensionDelegateStatic("glCompressedTexImage2D", typeof(Delegates.CompressedTexImage2D));
            Delegates.glCompressedTexImage2D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage3D = (Delegates.CompressedTexImage3D)GetExtensionDelegateStatic("glCompressedTexImage3D", typeof(Delegates.CompressedTexImage3D));
            Delegates.glCompressedTexImage3D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)depth, (Int32)border, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage1D = (Delegates.CompressedTexSubImage1D)GetExtensionDelegateStatic("glCompressedTexSubImage1D", typeof(Delegates.CompressedTexSubImage1D));
            Delegates.glCompressedTexSubImage1D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)width, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)GetExtensionDelegateStatic("glCompressedTexSubImage2D", typeof(Delegates.CompressedTexSubImage2D));
            Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage3D = (Delegates.CompressedTexSubImage3D)GetExtensionDelegateStatic("glCompressedTexSubImage3D", typeof(Delegates.CompressedTexSubImage3D));
            Delegates.glCompressedTexSubImage3D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_ConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image)
        {
            Delegates.glConvolutionFilter1D = (Delegates.ConvolutionFilter1D)GetExtensionDelegateStatic("glConvolutionFilter1D", typeof(Delegates.ConvolutionFilter1D));
            Delegates.glConvolutionFilter1D((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)image);
        }
        internal static void Load_ConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image)
        {
            Delegates.glConvolutionFilter2D = (Delegates.ConvolutionFilter2D)GetExtensionDelegateStatic("glConvolutionFilter2D", typeof(Delegates.ConvolutionFilter2D));
            Delegates.glConvolutionFilter2D((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)image);
        }
        internal static void Load_ConvolutionParameterf(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single @params)
        {
            Delegates.glConvolutionParameterf = (Delegates.ConvolutionParameterf)GetExtensionDelegateStatic("glConvolutionParameterf", typeof(Delegates.ConvolutionParameterf));
            Delegates.glConvolutionParameterf((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.ConvolutionParameter)pname, (Single)@params);
        }
        internal static unsafe void Load_ConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single* @params)
        {
            Delegates.glConvolutionParameterfv = (Delegates.ConvolutionParameterfv)GetExtensionDelegateStatic("glConvolutionParameterfv", typeof(Delegates.ConvolutionParameterfv));
            Delegates.glConvolutionParameterfv((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.ConvolutionParameter)pname, (Single*)@params);
        }
        internal static void Load_ConvolutionParameteri(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32 @params)
        {
            Delegates.glConvolutionParameteri = (Delegates.ConvolutionParameteri)GetExtensionDelegateStatic("glConvolutionParameteri", typeof(Delegates.ConvolutionParameteri));
            Delegates.glConvolutionParameteri((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.ConvolutionParameter)pname, (Int32)@params);
        }
        internal static unsafe void Load_ConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32* @params)
        {
            Delegates.glConvolutionParameteriv = (Delegates.ConvolutionParameteriv)GetExtensionDelegateStatic("glConvolutionParameteriv", typeof(Delegates.ConvolutionParameteriv));
            Delegates.glConvolutionParameteriv((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.ConvolutionParameter)pname, (Int32*)@params);
        }
        internal static void Load_CopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
        {
            Delegates.glCopyBufferSubData = (Delegates.CopyBufferSubData)GetExtensionDelegateStatic("glCopyBufferSubData", typeof(Delegates.CopyBufferSubData));
            Delegates.glCopyBufferSubData((OpenTK.Graphics.OpenGL4.BufferTarget)readTarget, (OpenTK.Graphics.OpenGL4.BufferTarget)writeTarget, (IntPtr)readOffset, (IntPtr)writeOffset, (IntPtr)size);
        }
        internal static void Load_CopyColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width)
        {
            Delegates.glCopyColorSubTable = (Delegates.CopyColorSubTable)GetExtensionDelegateStatic("glCopyColorSubTable", typeof(Delegates.CopyColorSubTable));
            Delegates.glCopyColorSubTable((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (Int32)start, (Int32)x, (Int32)y, (Int32)width);
        }
        internal static void Load_CopyColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width)
        {
            Delegates.glCopyColorTable = (Delegates.CopyColorTable)GetExtensionDelegateStatic("glCopyColorTable", typeof(Delegates.CopyColorTable));
            Delegates.glCopyColorTable((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)x, (Int32)y, (Int32)width);
        }
        internal static void Load_CopyConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width)
        {
            Delegates.glCopyConvolutionFilter1D = (Delegates.CopyConvolutionFilter1D)GetExtensionDelegateStatic("glCopyConvolutionFilter1D", typeof(Delegates.CopyConvolutionFilter1D));
            Delegates.glCopyConvolutionFilter1D((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)x, (Int32)y, (Int32)width);
        }
        internal static void Load_CopyConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyConvolutionFilter2D = (Delegates.CopyConvolutionFilter2D)GetExtensionDelegateStatic("glCopyConvolutionFilter2D", typeof(Delegates.CopyConvolutionFilter2D));
            Delegates.glCopyConvolutionFilter2D((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static void Load_CopyImageSubData(UInt32 srcName, OpenTK.Graphics.OpenGL4.ImageTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenTK.Graphics.OpenGL4.ImageTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
        {
            Delegates.glCopyImageSubData = (Delegates.CopyImageSubData)GetExtensionDelegateStatic("glCopyImageSubData", typeof(Delegates.CopyImageSubData));
            Delegates.glCopyImageSubData((UInt32)srcName, (OpenTK.Graphics.OpenGL4.ImageTarget)srcTarget, (Int32)srcLevel, (Int32)srcX, (Int32)srcY, (Int32)srcZ, (UInt32)dstName, (OpenTK.Graphics.OpenGL4.ImageTarget)dstTarget, (Int32)dstLevel, (Int32)dstX, (Int32)dstY, (Int32)dstZ, (Int32)srcWidth, (Int32)srcHeight, (Int32)srcDepth);
        }
        internal static void Load_CopyTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
        {
            Delegates.glCopyTexImage1D = (Delegates.CopyTexImage1D)GetExtensionDelegateStatic("glCopyTexImage1D", typeof(Delegates.CopyTexImage1D));
            Delegates.glCopyTexImage1D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)x, (Int32)y, (Int32)width, (Int32)border);
        }
        internal static void Load_CopyTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
        {
            Delegates.glCopyTexImage2D = (Delegates.CopyTexImage2D)GetExtensionDelegateStatic("glCopyTexImage2D", typeof(Delegates.CopyTexImage2D));
            Delegates.glCopyTexImage2D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)x, (Int32)y, (Int32)width, (Int32)height, (Int32)border);
        }
        internal static void Load_CopyTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
        {
            Delegates.glCopyTexSubImage1D = (Delegates.CopyTexSubImage1D)GetExtensionDelegateStatic("glCopyTexSubImage1D", typeof(Delegates.CopyTexSubImage1D));
            Delegates.glCopyTexSubImage1D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)x, (Int32)y, (Int32)width);
        }
        internal static void Load_CopyTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTexSubImage2D = (Delegates.CopyTexSubImage2D)GetExtensionDelegateStatic("glCopyTexSubImage2D", typeof(Delegates.CopyTexSubImage2D));
            Delegates.glCopyTexSubImage2D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static void Load_CopyTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTexSubImage3D = (Delegates.CopyTexSubImage3D)GetExtensionDelegateStatic("glCopyTexSubImage3D", typeof(Delegates.CopyTexSubImage3D));
            Delegates.glCopyTexSubImage3D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static Int32 Load_CreateProgram()
        {
            Delegates.glCreateProgram = (Delegates.CreateProgram)GetExtensionDelegateStatic("glCreateProgram", typeof(Delegates.CreateProgram));
            return Delegates.glCreateProgram();
        }
        internal static Int32 Load_CreateShader(OpenTK.Graphics.OpenGL4.ShaderType type)
        {
            Delegates.glCreateShader = (Delegates.CreateShader)GetExtensionDelegateStatic("glCreateShader", typeof(Delegates.CreateShader));
            return Delegates.glCreateShader((OpenTK.Graphics.OpenGL4.ShaderType)type);
        }
        internal static Int32 Load_CreateShaderProgramv(OpenTK.Graphics.OpenGL4.ShaderType type, Int32 count, String[] strings)
        {
            Delegates.glCreateShaderProgramv = (Delegates.CreateShaderProgramv)GetExtensionDelegateStatic("glCreateShaderProgramv", typeof(Delegates.CreateShaderProgramv));
            return Delegates.glCreateShaderProgramv((OpenTK.Graphics.OpenGL4.ShaderType)type, (Int32)count, (String[])strings);
        }
        internal static unsafe IntPtr Load_CreateSyncFromCLeventARB([OutAttribute] IntPtr* context, [OutAttribute] IntPtr* @event, UInt32 flags)
        {
            Delegates.glCreateSyncFromCLeventARB = (Delegates.CreateSyncFromCLeventARB)GetExtensionDelegateStatic("glCreateSyncFromCLeventARB", typeof(Delegates.CreateSyncFromCLeventARB));
            return Delegates.glCreateSyncFromCLeventARB((IntPtr*)context, (IntPtr*)@event, (UInt32)flags);
        }
        internal static void Load_CullFace(OpenTK.Graphics.OpenGL4.CullFaceMode mode)
        {
            Delegates.glCullFace = (Delegates.CullFace)GetExtensionDelegateStatic("glCullFace", typeof(Delegates.CullFace));
            Delegates.glCullFace((OpenTK.Graphics.OpenGL4.CullFaceMode)mode);
        }
        internal static void Load_DebugMessageCallback(DebugProc callback, IntPtr userParam)
        {
            Delegates.glDebugMessageCallback = (Delegates.DebugMessageCallback)GetExtensionDelegateStatic("glDebugMessageCallback", typeof(Delegates.DebugMessageCallback));
            Delegates.glDebugMessageCallback((DebugProc)callback, (IntPtr)userParam);
        }
        internal static void Load_DebugMessageCallbackARB(DebugProcArb callback, IntPtr userParam)
        {
            Delegates.glDebugMessageCallbackARB = (Delegates.DebugMessageCallbackARB)GetExtensionDelegateStatic("glDebugMessageCallbackARB", typeof(Delegates.DebugMessageCallbackARB));
            Delegates.glDebugMessageCallbackARB((DebugProcArb)callback, (IntPtr)userParam);
        }
        internal static void Load_DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam)
        {
            Delegates.glDebugMessageCallbackKHR = (Delegates.DebugMessageCallbackKHR)GetExtensionDelegateStatic("glDebugMessageCallbackKHR", typeof(Delegates.DebugMessageCallbackKHR));
            Delegates.glDebugMessageCallbackKHR((DebugProcKhr)callback, (IntPtr)userParam);
        }
        internal static unsafe void Load_DebugMessageControl(OpenTK.Graphics.OpenGL4.DebugSourceControl source, OpenTK.Graphics.OpenGL4.DebugTypeControl type, OpenTK.Graphics.OpenGL4.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled)
        {
            Delegates.glDebugMessageControl = (Delegates.DebugMessageControl)GetExtensionDelegateStatic("glDebugMessageControl", typeof(Delegates.DebugMessageControl));
            Delegates.glDebugMessageControl((OpenTK.Graphics.OpenGL4.DebugSourceControl)source, (OpenTK.Graphics.OpenGL4.DebugTypeControl)type, (OpenTK.Graphics.OpenGL4.DebugSeverityControl)severity, (Int32)count, (UInt32*)ids, (bool)enabled);
        }
        internal static unsafe void Load_DebugMessageControlARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled)
        {
            Delegates.glDebugMessageControlARB = (Delegates.DebugMessageControlARB)GetExtensionDelegateStatic("glDebugMessageControlARB", typeof(Delegates.DebugMessageControlARB));
            Delegates.glDebugMessageControlARB((OpenTK.Graphics.OpenGL4.All)source, (OpenTK.Graphics.OpenGL4.All)type, (OpenTK.Graphics.OpenGL4.All)severity, (Int32)count, (UInt32*)ids, (bool)enabled);
        }
        internal static unsafe void Load_DebugMessageControlKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled)
        {
            Delegates.glDebugMessageControlKHR = (Delegates.DebugMessageControlKHR)GetExtensionDelegateStatic("glDebugMessageControlKHR", typeof(Delegates.DebugMessageControlKHR));
            Delegates.glDebugMessageControlKHR((OpenTK.Graphics.OpenGL4.All)source, (OpenTK.Graphics.OpenGL4.All)type, (OpenTK.Graphics.OpenGL4.All)severity, (Int32)count, (UInt32*)ids, (bool)enabled);
        }
        internal static void Load_DebugMessageInsert(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, OpenTK.Graphics.OpenGL4.DebugType type, UInt32 id, OpenTK.Graphics.OpenGL4.DebugSeverity severity, Int32 length, String buf)
        {
            Delegates.glDebugMessageInsert = (Delegates.DebugMessageInsert)GetExtensionDelegateStatic("glDebugMessageInsert", typeof(Delegates.DebugMessageInsert));
            Delegates.glDebugMessageInsert((OpenTK.Graphics.OpenGL4.DebugSourceExternal)source, (OpenTK.Graphics.OpenGL4.DebugType)type, (UInt32)id, (OpenTK.Graphics.OpenGL4.DebugSeverity)severity, (Int32)length, (String)buf);
        }
        internal static void Load_DebugMessageInsertARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf)
        {
            Delegates.glDebugMessageInsertARB = (Delegates.DebugMessageInsertARB)GetExtensionDelegateStatic("glDebugMessageInsertARB", typeof(Delegates.DebugMessageInsertARB));
            Delegates.glDebugMessageInsertARB((OpenTK.Graphics.OpenGL4.All)source, (OpenTK.Graphics.OpenGL4.All)type, (UInt32)id, (OpenTK.Graphics.OpenGL4.All)severity, (Int32)length, (String)buf);
        }
        internal static void Load_DebugMessageInsertKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf)
        {
            Delegates.glDebugMessageInsertKHR = (Delegates.DebugMessageInsertKHR)GetExtensionDelegateStatic("glDebugMessageInsertKHR", typeof(Delegates.DebugMessageInsertKHR));
            Delegates.glDebugMessageInsertKHR((OpenTK.Graphics.OpenGL4.All)source, (OpenTK.Graphics.OpenGL4.All)type, (UInt32)id, (OpenTK.Graphics.OpenGL4.All)severity, (Int32)length, (String)buf);
        }
        internal static unsafe void Load_DeleteBuffers(Int32 n, UInt32* buffers)
        {
            Delegates.glDeleteBuffers = (Delegates.DeleteBuffers)GetExtensionDelegateStatic("glDeleteBuffers", typeof(Delegates.DeleteBuffers));
            Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers);
        }
        internal static unsafe void Load_DeleteFramebuffers(Int32 n, UInt32* framebuffers)
        {
            Delegates.glDeleteFramebuffers = (Delegates.DeleteFramebuffers)GetExtensionDelegateStatic("glDeleteFramebuffers", typeof(Delegates.DeleteFramebuffers));
            Delegates.glDeleteFramebuffers((Int32)n, (UInt32*)framebuffers);
        }
        internal static void Load_DeleteNamedStringARB(Int32 namelen, String name)
        {
            Delegates.glDeleteNamedStringARB = (Delegates.DeleteNamedStringARB)GetExtensionDelegateStatic("glDeleteNamedStringARB", typeof(Delegates.DeleteNamedStringARB));
            Delegates.glDeleteNamedStringARB((Int32)namelen, (String)name);
        }
        internal static void Load_DeleteProgram(UInt32 program)
        {
            Delegates.glDeleteProgram = (Delegates.DeleteProgram)GetExtensionDelegateStatic("glDeleteProgram", typeof(Delegates.DeleteProgram));
            Delegates.glDeleteProgram((UInt32)program);
        }
        internal static unsafe void Load_DeleteProgramPipelines(Int32 n, UInt32* pipelines)
        {
            Delegates.glDeleteProgramPipelines = (Delegates.DeleteProgramPipelines)GetExtensionDelegateStatic("glDeleteProgramPipelines", typeof(Delegates.DeleteProgramPipelines));
            Delegates.glDeleteProgramPipelines((Int32)n, (UInt32*)pipelines);
        }
        internal static unsafe void Load_DeleteQueries(Int32 n, UInt32* ids)
        {
            Delegates.glDeleteQueries = (Delegates.DeleteQueries)GetExtensionDelegateStatic("glDeleteQueries", typeof(Delegates.DeleteQueries));
            Delegates.glDeleteQueries((Int32)n, (UInt32*)ids);
        }
        internal static unsafe void Load_DeleteRenderbuffers(Int32 n, UInt32* renderbuffers)
        {
            Delegates.glDeleteRenderbuffers = (Delegates.DeleteRenderbuffers)GetExtensionDelegateStatic("glDeleteRenderbuffers", typeof(Delegates.DeleteRenderbuffers));
            Delegates.glDeleteRenderbuffers((Int32)n, (UInt32*)renderbuffers);
        }
        internal static unsafe void Load_DeleteSamplers(Int32 count, UInt32* samplers)
        {
            Delegates.glDeleteSamplers = (Delegates.DeleteSamplers)GetExtensionDelegateStatic("glDeleteSamplers", typeof(Delegates.DeleteSamplers));
            Delegates.glDeleteSamplers((Int32)count, (UInt32*)samplers);
        }
        internal static void Load_DeleteShader(UInt32 shader)
        {
            Delegates.glDeleteShader = (Delegates.DeleteShader)GetExtensionDelegateStatic("glDeleteShader", typeof(Delegates.DeleteShader));
            Delegates.glDeleteShader((UInt32)shader);
        }
        internal static void Load_DeleteSync(IntPtr sync)
        {
            Delegates.glDeleteSync = (Delegates.DeleteSync)GetExtensionDelegateStatic("glDeleteSync", typeof(Delegates.DeleteSync));
            Delegates.glDeleteSync((IntPtr)sync);
        }
        internal static unsafe void Load_DeleteTextures(Int32 n, UInt32* textures)
        {
            Delegates.glDeleteTextures = (Delegates.DeleteTextures)GetExtensionDelegateStatic("glDeleteTextures", typeof(Delegates.DeleteTextures));
            Delegates.glDeleteTextures((Int32)n, (UInt32*)textures);
        }
        internal static unsafe void Load_DeleteTransformFeedbacks(Int32 n, UInt32* ids)
        {
            Delegates.glDeleteTransformFeedbacks = (Delegates.DeleteTransformFeedbacks)GetExtensionDelegateStatic("glDeleteTransformFeedbacks", typeof(Delegates.DeleteTransformFeedbacks));
            Delegates.glDeleteTransformFeedbacks((Int32)n, (UInt32*)ids);
        }
        internal static unsafe void Load_DeleteVertexArrays(Int32 n, UInt32* arrays)
        {
            Delegates.glDeleteVertexArrays = (Delegates.DeleteVertexArrays)GetExtensionDelegateStatic("glDeleteVertexArrays", typeof(Delegates.DeleteVertexArrays));
            Delegates.glDeleteVertexArrays((Int32)n, (UInt32*)arrays);
        }
        internal static void Load_DepthFunc(OpenTK.Graphics.OpenGL4.DepthFunction func)
        {
            Delegates.glDepthFunc = (Delegates.DepthFunc)GetExtensionDelegateStatic("glDepthFunc", typeof(Delegates.DepthFunc));
            Delegates.glDepthFunc((OpenTK.Graphics.OpenGL4.DepthFunction)func);
        }
        internal static void Load_DepthMask(bool flag)
        {
            Delegates.glDepthMask = (Delegates.DepthMask)GetExtensionDelegateStatic("glDepthMask", typeof(Delegates.DepthMask));
            Delegates.glDepthMask((bool)flag);
        }
        internal static void Load_DepthRange(Double near, Double far)
        {
            Delegates.glDepthRange = (Delegates.DepthRange)GetExtensionDelegateStatic("glDepthRange", typeof(Delegates.DepthRange));
            Delegates.glDepthRange((Double)near, (Double)far);
        }
        internal static unsafe void Load_DepthRangeArrayv(UInt32 first, Int32 count, Double* v)
        {
            Delegates.glDepthRangeArrayv = (Delegates.DepthRangeArrayv)GetExtensionDelegateStatic("glDepthRangeArrayv", typeof(Delegates.DepthRangeArrayv));
            Delegates.glDepthRangeArrayv((UInt32)first, (Int32)count, (Double*)v);
        }
        internal static void Load_DepthRangef(Single n, Single f)
        {
            Delegates.glDepthRangef = (Delegates.DepthRangef)GetExtensionDelegateStatic("glDepthRangef", typeof(Delegates.DepthRangef));
            Delegates.glDepthRangef((Single)n, (Single)f);
        }
        internal static void Load_DepthRangeIndexed(UInt32 index, Double n, Double f)
        {
            Delegates.glDepthRangeIndexed = (Delegates.DepthRangeIndexed)GetExtensionDelegateStatic("glDepthRangeIndexed", typeof(Delegates.DepthRangeIndexed));
            Delegates.glDepthRangeIndexed((UInt32)index, (Double)n, (Double)f);
        }
        internal static void Load_DetachShader(UInt32 program, UInt32 shader)
        {
            Delegates.glDetachShader = (Delegates.DetachShader)GetExtensionDelegateStatic("glDetachShader", typeof(Delegates.DetachShader));
            Delegates.glDetachShader((UInt32)program, (UInt32)shader);
        }
        internal static void Load_Disable(OpenTK.Graphics.OpenGL4.EnableCap cap)
        {
            Delegates.glDisable = (Delegates.Disable)GetExtensionDelegateStatic("glDisable", typeof(Delegates.Disable));
            Delegates.glDisable((OpenTK.Graphics.OpenGL4.EnableCap)cap);
        }
        internal static void Load_Disablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index)
        {
            Delegates.glDisablei = (Delegates.Disablei)GetExtensionDelegateStatic("glDisablei", typeof(Delegates.Disablei));
            Delegates.glDisablei((OpenTK.Graphics.OpenGL4.IndexedEnableCap)target, (UInt32)index);
        }
        internal static void Load_DisableVertexAttribArray(UInt32 index)
        {
            Delegates.glDisableVertexAttribArray = (Delegates.DisableVertexAttribArray)GetExtensionDelegateStatic("glDisableVertexAttribArray", typeof(Delegates.DisableVertexAttribArray));
            Delegates.glDisableVertexAttribArray((UInt32)index);
        }
        internal static void Load_DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z)
        {
            Delegates.glDispatchCompute = (Delegates.DispatchCompute)GetExtensionDelegateStatic("glDispatchCompute", typeof(Delegates.DispatchCompute));
            Delegates.glDispatchCompute((UInt32)num_groups_x, (UInt32)num_groups_y, (UInt32)num_groups_z);
        }
        internal static void Load_DispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z)
        {
            Delegates.glDispatchComputeGroupSizeARB = (Delegates.DispatchComputeGroupSizeARB)GetExtensionDelegateStatic("glDispatchComputeGroupSizeARB", typeof(Delegates.DispatchComputeGroupSizeARB));
            Delegates.glDispatchComputeGroupSizeARB((UInt32)num_groups_x, (UInt32)num_groups_y, (UInt32)num_groups_z, (UInt32)group_size_x, (UInt32)group_size_y, (UInt32)group_size_z);
        }
        internal static void Load_DispatchComputeIndirect(IntPtr indirect)
        {
            Delegates.glDispatchComputeIndirect = (Delegates.DispatchComputeIndirect)GetExtensionDelegateStatic("glDispatchComputeIndirect", typeof(Delegates.DispatchComputeIndirect));
            Delegates.glDispatchComputeIndirect((IntPtr)indirect);
        }
        internal static void Load_DrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count)
        {
            Delegates.glDrawArrays = (Delegates.DrawArrays)GetExtensionDelegateStatic("glDrawArrays", typeof(Delegates.DrawArrays));
            Delegates.glDrawArrays((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)first, (Int32)count);
        }
        internal static void Load_DrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect)
        {
            Delegates.glDrawArraysIndirect = (Delegates.DrawArraysIndirect)GetExtensionDelegateStatic("glDrawArraysIndirect", typeof(Delegates.DrawArraysIndirect));
            Delegates.glDrawArraysIndirect((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (IntPtr)indirect);
        }
        internal static void Load_DrawArraysInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount)
        {
            Delegates.glDrawArraysInstanced = (Delegates.DrawArraysInstanced)GetExtensionDelegateStatic("glDrawArraysInstanced", typeof(Delegates.DrawArraysInstanced));
            Delegates.glDrawArraysInstanced((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)first, (Int32)count, (Int32)instancecount);
        }
        internal static void Load_DrawArraysInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance)
        {
            Delegates.glDrawArraysInstancedBaseInstance = (Delegates.DrawArraysInstancedBaseInstance)GetExtensionDelegateStatic("glDrawArraysInstancedBaseInstance", typeof(Delegates.DrawArraysInstancedBaseInstance));
            Delegates.glDrawArraysInstancedBaseInstance((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)first, (Int32)count, (Int32)instancecount, (UInt32)baseinstance);
        }
        internal static void Load_DrawBuffer(OpenTK.Graphics.OpenGL4.DrawBufferMode mode)
        {
            Delegates.glDrawBuffer = (Delegates.DrawBuffer)GetExtensionDelegateStatic("glDrawBuffer", typeof(Delegates.DrawBuffer));
            Delegates.glDrawBuffer((OpenTK.Graphics.OpenGL4.DrawBufferMode)mode);
        }
        internal static unsafe void Load_DrawBuffers(Int32 n, OpenTK.Graphics.OpenGL4.DrawBuffersEnum* bufs)
        {
            Delegates.glDrawBuffers = (Delegates.DrawBuffers)GetExtensionDelegateStatic("glDrawBuffers", typeof(Delegates.DrawBuffers));
            Delegates.glDrawBuffers((Int32)n, (OpenTK.Graphics.OpenGL4.DrawBuffersEnum*)bufs);
        }
        internal static void Load_DrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices)
        {
            Delegates.glDrawElements = (Delegates.DrawElements)GetExtensionDelegateStatic("glDrawElements", typeof(Delegates.DrawElements));
            Delegates.glDrawElements((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices);
        }
        internal static void Load_DrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex)
        {
            Delegates.glDrawElementsBaseVertex = (Delegates.DrawElementsBaseVertex)GetExtensionDelegateStatic("glDrawElementsBaseVertex", typeof(Delegates.DrawElementsBaseVertex));
            Delegates.glDrawElementsBaseVertex((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)basevertex);
        }
        internal static void Load_DrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect)
        {
            Delegates.glDrawElementsIndirect = (Delegates.DrawElementsIndirect)GetExtensionDelegateStatic("glDrawElementsIndirect", typeof(Delegates.DrawElementsIndirect));
            Delegates.glDrawElementsIndirect((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (OpenTK.Graphics.OpenGL4.All)type, (IntPtr)indirect);
        }
        internal static void Load_DrawElementsInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount)
        {
            Delegates.glDrawElementsInstanced = (Delegates.DrawElementsInstanced)GetExtensionDelegateStatic("glDrawElementsInstanced", typeof(Delegates.DrawElementsInstanced));
            Delegates.glDrawElementsInstanced((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)instancecount);
        }
        internal static void Load_DrawElementsInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance)
        {
            Delegates.glDrawElementsInstancedBaseInstance = (Delegates.DrawElementsInstancedBaseInstance)GetExtensionDelegateStatic("glDrawElementsInstancedBaseInstance", typeof(Delegates.DrawElementsInstancedBaseInstance));
            Delegates.glDrawElementsInstancedBaseInstance((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)instancecount, (UInt32)baseinstance);
        }
        internal static void Load_DrawElementsInstancedBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex)
        {
            Delegates.glDrawElementsInstancedBaseVertex = (Delegates.DrawElementsInstancedBaseVertex)GetExtensionDelegateStatic("glDrawElementsInstancedBaseVertex", typeof(Delegates.DrawElementsInstancedBaseVertex));
            Delegates.glDrawElementsInstancedBaseVertex((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)instancecount, (Int32)basevertex);
        }
        internal static void Load_DrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance)
        {
            Delegates.glDrawElementsInstancedBaseVertexBaseInstance = (Delegates.DrawElementsInstancedBaseVertexBaseInstance)GetExtensionDelegateStatic("glDrawElementsInstancedBaseVertexBaseInstance", typeof(Delegates.DrawElementsInstancedBaseVertexBaseInstance));
            Delegates.glDrawElementsInstancedBaseVertexBaseInstance((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)instancecount, (Int32)basevertex, (UInt32)baseinstance);
        }
        internal static void Load_DrawRangeElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices)
        {
            Delegates.glDrawRangeElements = (Delegates.DrawRangeElements)GetExtensionDelegateStatic("glDrawRangeElements", typeof(Delegates.DrawRangeElements));
            Delegates.glDrawRangeElements((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (UInt32)start, (UInt32)end, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices);
        }
        internal static void Load_DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex)
        {
            Delegates.glDrawRangeElementsBaseVertex = (Delegates.DrawRangeElementsBaseVertex)GetExtensionDelegateStatic("glDrawRangeElementsBaseVertex", typeof(Delegates.DrawRangeElementsBaseVertex));
            Delegates.glDrawRangeElementsBaseVertex((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (UInt32)start, (UInt32)end, (Int32)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)basevertex);
        }
        internal static void Load_DrawTransformFeedback(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id)
        {
            Delegates.glDrawTransformFeedback = (Delegates.DrawTransformFeedback)GetExtensionDelegateStatic("glDrawTransformFeedback", typeof(Delegates.DrawTransformFeedback));
            Delegates.glDrawTransformFeedback((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (UInt32)id);
        }
        internal static void Load_DrawTransformFeedbackInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, Int32 instancecount)
        {
            Delegates.glDrawTransformFeedbackInstanced = (Delegates.DrawTransformFeedbackInstanced)GetExtensionDelegateStatic("glDrawTransformFeedbackInstanced", typeof(Delegates.DrawTransformFeedbackInstanced));
            Delegates.glDrawTransformFeedbackInstanced((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (UInt32)id, (Int32)instancecount);
        }
        internal static void Load_DrawTransformFeedbackStream(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream)
        {
            Delegates.glDrawTransformFeedbackStream = (Delegates.DrawTransformFeedbackStream)GetExtensionDelegateStatic("glDrawTransformFeedbackStream", typeof(Delegates.DrawTransformFeedbackStream));
            Delegates.glDrawTransformFeedbackStream((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (UInt32)id, (UInt32)stream);
        }
        internal static void Load_DrawTransformFeedbackStreamInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount)
        {
            Delegates.glDrawTransformFeedbackStreamInstanced = (Delegates.DrawTransformFeedbackStreamInstanced)GetExtensionDelegateStatic("glDrawTransformFeedbackStreamInstanced", typeof(Delegates.DrawTransformFeedbackStreamInstanced));
            Delegates.glDrawTransformFeedbackStreamInstanced((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (UInt32)id, (UInt32)stream, (Int32)instancecount);
        }
        internal static void Load_Enable(OpenTK.Graphics.OpenGL4.EnableCap cap)
        {
            Delegates.glEnable = (Delegates.Enable)GetExtensionDelegateStatic("glEnable", typeof(Delegates.Enable));
            Delegates.glEnable((OpenTK.Graphics.OpenGL4.EnableCap)cap);
        }
        internal static void Load_Enablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index)
        {
            Delegates.glEnablei = (Delegates.Enablei)GetExtensionDelegateStatic("glEnablei", typeof(Delegates.Enablei));
            Delegates.glEnablei((OpenTK.Graphics.OpenGL4.IndexedEnableCap)target, (UInt32)index);
        }
        internal static void Load_EnableVertexAttribArray(UInt32 index)
        {
            Delegates.glEnableVertexAttribArray = (Delegates.EnableVertexAttribArray)GetExtensionDelegateStatic("glEnableVertexAttribArray", typeof(Delegates.EnableVertexAttribArray));
            Delegates.glEnableVertexAttribArray((UInt32)index);
        }
        internal static void Load_EndConditionalRender()
        {
            Delegates.glEndConditionalRender = (Delegates.EndConditionalRender)GetExtensionDelegateStatic("glEndConditionalRender", typeof(Delegates.EndConditionalRender));
            Delegates.glEndConditionalRender();
        }
        internal static void Load_EndQuery(OpenTK.Graphics.OpenGL4.QueryTarget target)
        {
            Delegates.glEndQuery = (Delegates.EndQuery)GetExtensionDelegateStatic("glEndQuery", typeof(Delegates.EndQuery));
            Delegates.glEndQuery((OpenTK.Graphics.OpenGL4.QueryTarget)target);
        }
        internal static void Load_EndQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index)
        {
            Delegates.glEndQueryIndexed = (Delegates.EndQueryIndexed)GetExtensionDelegateStatic("glEndQueryIndexed", typeof(Delegates.EndQueryIndexed));
            Delegates.glEndQueryIndexed((OpenTK.Graphics.OpenGL4.QueryTarget)target, (UInt32)index);
        }
        internal static void Load_EndTransformFeedback()
        {
            Delegates.glEndTransformFeedback = (Delegates.EndTransformFeedback)GetExtensionDelegateStatic("glEndTransformFeedback", typeof(Delegates.EndTransformFeedback));
            Delegates.glEndTransformFeedback();
        }
        internal static IntPtr Load_FenceSync(OpenTK.Graphics.OpenGL4.SyncCondition condition, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags)
        {
            Delegates.glFenceSync = (Delegates.FenceSync)GetExtensionDelegateStatic("glFenceSync", typeof(Delegates.FenceSync));
            return Delegates.glFenceSync((OpenTK.Graphics.OpenGL4.SyncCondition)condition, (OpenTK.Graphics.OpenGL4.WaitSyncFlags)flags);
        }
        internal static void Load_Finish()
        {
            Delegates.glFinish = (Delegates.Finish)GetExtensionDelegateStatic("glFinish", typeof(Delegates.Finish));
            Delegates.glFinish();
        }
        internal static void Load_Flush()
        {
            Delegates.glFlush = (Delegates.Flush)GetExtensionDelegateStatic("glFlush", typeof(Delegates.Flush));
            Delegates.glFlush();
        }
        internal static void Load_FlushMappedBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length)
        {
            Delegates.glFlushMappedBufferRange = (Delegates.FlushMappedBufferRange)GetExtensionDelegateStatic("glFlushMappedBufferRange", typeof(Delegates.FlushMappedBufferRange));
            Delegates.glFlushMappedBufferRange((OpenTK.Graphics.OpenGL4.BufferTarget)target, (IntPtr)offset, (IntPtr)length);
        }
        internal static void Load_FramebufferParameteri(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, Int32 param)
        {
            Delegates.glFramebufferParameteri = (Delegates.FramebufferParameteri)GetExtensionDelegateStatic("glFramebufferParameteri", typeof(Delegates.FramebufferParameteri));
            Delegates.glFramebufferParameteri((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter)pname, (Int32)param);
        }
        internal static void Load_FramebufferRenderbuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
        {
            Delegates.glFramebufferRenderbuffer = (Delegates.FramebufferRenderbuffer)GetExtensionDelegateStatic("glFramebufferRenderbuffer", typeof(Delegates.FramebufferRenderbuffer));
            Delegates.glFramebufferRenderbuffer((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferAttachment)attachment, (OpenTK.Graphics.OpenGL4.RenderbufferTarget)renderbuffertarget, (UInt32)renderbuffer);
        }
        internal static void Load_FramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level)
        {
            Delegates.glFramebufferTexture = (Delegates.FramebufferTexture)GetExtensionDelegateStatic("glFramebufferTexture", typeof(Delegates.FramebufferTexture));
            Delegates.glFramebufferTexture((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferAttachment)attachment, (UInt32)texture, (Int32)level);
        }
        internal static void Load_FramebufferTexture1D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level)
        {
            Delegates.glFramebufferTexture1D = (Delegates.FramebufferTexture1D)GetExtensionDelegateStatic("glFramebufferTexture1D", typeof(Delegates.FramebufferTexture1D));
            Delegates.glFramebufferTexture1D((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferAttachment)attachment, (OpenTK.Graphics.OpenGL4.TextureTarget)textarget, (UInt32)texture, (Int32)level);
        }
        internal static void Load_FramebufferTexture2D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level)
        {
            Delegates.glFramebufferTexture2D = (Delegates.FramebufferTexture2D)GetExtensionDelegateStatic("glFramebufferTexture2D", typeof(Delegates.FramebufferTexture2D));
            Delegates.glFramebufferTexture2D((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferAttachment)attachment, (OpenTK.Graphics.OpenGL4.TextureTarget)textarget, (UInt32)texture, (Int32)level);
        }
        internal static void Load_FramebufferTexture3D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset)
        {
            Delegates.glFramebufferTexture3D = (Delegates.FramebufferTexture3D)GetExtensionDelegateStatic("glFramebufferTexture3D", typeof(Delegates.FramebufferTexture3D));
            Delegates.glFramebufferTexture3D((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferAttachment)attachment, (OpenTK.Graphics.OpenGL4.TextureTarget)textarget, (UInt32)texture, (Int32)level, (Int32)zoffset);
        }
        internal static void Load_FramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
        {
            Delegates.glFramebufferTextureLayer = (Delegates.FramebufferTextureLayer)GetExtensionDelegateStatic("glFramebufferTextureLayer", typeof(Delegates.FramebufferTextureLayer));
            Delegates.glFramebufferTextureLayer((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferAttachment)attachment, (UInt32)texture, (Int32)level, (Int32)layer);
        }
        internal static void Load_FrontFace(OpenTK.Graphics.OpenGL4.FrontFaceDirection mode)
        {
            Delegates.glFrontFace = (Delegates.FrontFace)GetExtensionDelegateStatic("glFrontFace", typeof(Delegates.FrontFace));
            Delegates.glFrontFace((OpenTK.Graphics.OpenGL4.FrontFaceDirection)mode);
        }
        internal static unsafe void Load_GenBuffers(Int32 n, [OutAttribute] UInt32* buffers)
        {
            Delegates.glGenBuffers = (Delegates.GenBuffers)GetExtensionDelegateStatic("glGenBuffers", typeof(Delegates.GenBuffers));
            Delegates.glGenBuffers((Int32)n, (UInt32*)buffers);
        }
        internal static void Load_GenerateMipmap(OpenTK.Graphics.OpenGL4.GenerateMipmapTarget target)
        {
            Delegates.glGenerateMipmap = (Delegates.GenerateMipmap)GetExtensionDelegateStatic("glGenerateMipmap", typeof(Delegates.GenerateMipmap));
            Delegates.glGenerateMipmap((OpenTK.Graphics.OpenGL4.GenerateMipmapTarget)target);
        }
        internal static unsafe void Load_GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers)
        {
            Delegates.glGenFramebuffers = (Delegates.GenFramebuffers)GetExtensionDelegateStatic("glGenFramebuffers", typeof(Delegates.GenFramebuffers));
            Delegates.glGenFramebuffers((Int32)n, (UInt32*)framebuffers);
        }
        internal static unsafe void Load_GenProgramPipelines(Int32 n, [OutAttribute] UInt32* pipelines)
        {
            Delegates.glGenProgramPipelines = (Delegates.GenProgramPipelines)GetExtensionDelegateStatic("glGenProgramPipelines", typeof(Delegates.GenProgramPipelines));
            Delegates.glGenProgramPipelines((Int32)n, (UInt32*)pipelines);
        }
        internal static unsafe void Load_GenQueries(Int32 n, [OutAttribute] UInt32* ids)
        {
            Delegates.glGenQueries = (Delegates.GenQueries)GetExtensionDelegateStatic("glGenQueries", typeof(Delegates.GenQueries));
            Delegates.glGenQueries((Int32)n, (UInt32*)ids);
        }
        internal static unsafe void Load_GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers)
        {
            Delegates.glGenRenderbuffers = (Delegates.GenRenderbuffers)GetExtensionDelegateStatic("glGenRenderbuffers", typeof(Delegates.GenRenderbuffers));
            Delegates.glGenRenderbuffers((Int32)n, (UInt32*)renderbuffers);
        }
        internal static unsafe void Load_GenSamplers(Int32 count, [OutAttribute] UInt32* samplers)
        {
            Delegates.glGenSamplers = (Delegates.GenSamplers)GetExtensionDelegateStatic("glGenSamplers", typeof(Delegates.GenSamplers));
            Delegates.glGenSamplers((Int32)count, (UInt32*)samplers);
        }
        internal static unsafe void Load_GenTextures(Int32 n, [OutAttribute] UInt32* textures)
        {
            Delegates.glGenTextures = (Delegates.GenTextures)GetExtensionDelegateStatic("glGenTextures", typeof(Delegates.GenTextures));
            Delegates.glGenTextures((Int32)n, (UInt32*)textures);
        }
        internal static unsafe void Load_GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids)
        {
            Delegates.glGenTransformFeedbacks = (Delegates.GenTransformFeedbacks)GetExtensionDelegateStatic("glGenTransformFeedbacks", typeof(Delegates.GenTransformFeedbacks));
            Delegates.glGenTransformFeedbacks((Int32)n, (UInt32*)ids);
        }
        internal static unsafe void Load_GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays)
        {
            Delegates.glGenVertexArrays = (Delegates.GenVertexArrays)GetExtensionDelegateStatic("glGenVertexArrays", typeof(Delegates.GenVertexArrays));
            Delegates.glGenVertexArrays((Int32)n, (UInt32*)arrays);
        }
        internal static unsafe void Load_GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenTK.Graphics.OpenGL4.AtomicCounterBufferParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetActiveAtomicCounterBufferiv = (Delegates.GetActiveAtomicCounterBufferiv)GetExtensionDelegateStatic("glGetActiveAtomicCounterBufferiv", typeof(Delegates.GetActiveAtomicCounterBufferiv));
            Delegates.glGetActiveAtomicCounterBufferiv((UInt32)program, (UInt32)bufferIndex, (OpenTK.Graphics.OpenGL4.AtomicCounterBufferParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveAttribType* type, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetActiveAttrib = (Delegates.GetActiveAttrib)GetExtensionDelegateStatic("glGetActiveAttrib", typeof(Delegates.GetActiveAttrib));
            Delegates.glGetActiveAttrib((UInt32)program, (UInt32)index, (Int32)bufSize, (Int32*)length, (Int32*)size, (OpenTK.Graphics.OpenGL4.ActiveAttribType*)type, (StringBuilder)name);
        }
        internal static unsafe void Load_GetActiveSubroutineName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetActiveSubroutineName = (Delegates.GetActiveSubroutineName)GetExtensionDelegateStatic("glGetActiveSubroutineName", typeof(Delegates.GetActiveSubroutineName));
            Delegates.glGetActiveSubroutineName((UInt32)program, (OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (UInt32)index, (Int32)bufsize, (Int32*)length, (StringBuilder)name);
        }
        internal static unsafe void Load_GetActiveSubroutineUniformiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute] Int32* values)
        {
            Delegates.glGetActiveSubroutineUniformiv = (Delegates.GetActiveSubroutineUniformiv)GetExtensionDelegateStatic("glGetActiveSubroutineUniformiv", typeof(Delegates.GetActiveSubroutineUniformiv));
            Delegates.glGetActiveSubroutineUniformiv((UInt32)program, (OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (UInt32)index, (OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter)pname, (Int32*)values);
        }
        internal static unsafe void Load_GetActiveSubroutineUniformName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetActiveSubroutineUniformName = (Delegates.GetActiveSubroutineUniformName)GetExtensionDelegateStatic("glGetActiveSubroutineUniformName", typeof(Delegates.GetActiveSubroutineUniformName));
            Delegates.glGetActiveSubroutineUniformName((UInt32)program, (OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (UInt32)index, (Int32)bufsize, (Int32*)length, (StringBuilder)name);
        }
        internal static unsafe void Load_GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveUniformType* type, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetActiveUniform = (Delegates.GetActiveUniform)GetExtensionDelegateStatic("glGetActiveUniform", typeof(Delegates.GetActiveUniform));
            Delegates.glGetActiveUniform((UInt32)program, (UInt32)index, (Int32)bufSize, (Int32*)length, (Int32*)size, (OpenTK.Graphics.OpenGL4.ActiveUniformType*)type, (StringBuilder)name);
        }
        internal static unsafe void Load_GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetActiveUniformBlockiv = (Delegates.GetActiveUniformBlockiv)GetExtensionDelegateStatic("glGetActiveUniformBlockiv", typeof(Delegates.GetActiveUniformBlockiv));
            Delegates.glGetActiveUniformBlockiv((UInt32)program, (UInt32)uniformBlockIndex, (OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName)
        {
            Delegates.glGetActiveUniformBlockName = (Delegates.GetActiveUniformBlockName)GetExtensionDelegateStatic("glGetActiveUniformBlockName", typeof(Delegates.GetActiveUniformBlockName));
            Delegates.glGetActiveUniformBlockName((UInt32)program, (UInt32)uniformBlockIndex, (Int32)bufSize, (Int32*)length, (StringBuilder)uniformBlockName);
        }
        internal static unsafe void Load_GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName)
        {
            Delegates.glGetActiveUniformName = (Delegates.GetActiveUniformName)GetExtensionDelegateStatic("glGetActiveUniformName", typeof(Delegates.GetActiveUniformName));
            Delegates.glGetActiveUniformName((UInt32)program, (UInt32)uniformIndex, (Int32)bufSize, (Int32*)length, (StringBuilder)uniformName);
        }
        internal static unsafe void Load_GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetActiveUniformsiv = (Delegates.GetActiveUniformsiv)GetExtensionDelegateStatic("glGetActiveUniformsiv", typeof(Delegates.GetActiveUniformsiv));
            Delegates.glGetActiveUniformsiv((UInt32)program, (Int32)uniformCount, (UInt32*)uniformIndices, (OpenTK.Graphics.OpenGL4.ActiveUniformParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders)
        {
            Delegates.glGetAttachedShaders = (Delegates.GetAttachedShaders)GetExtensionDelegateStatic("glGetAttachedShaders", typeof(Delegates.GetAttachedShaders));
            Delegates.glGetAttachedShaders((UInt32)program, (Int32)maxCount, (Int32*)count, (UInt32*)shaders);
        }
        internal static Int32 Load_GetAttribLocation(UInt32 program, String name)
        {
            Delegates.glGetAttribLocation = (Delegates.GetAttribLocation)GetExtensionDelegateStatic("glGetAttribLocation", typeof(Delegates.GetAttribLocation));
            return Delegates.glGetAttribLocation((UInt32)program, (String)name);
        }
        internal static unsafe void Load_GetBooleani_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] bool* data)
        {
            Delegates.glGetBooleani_v = (Delegates.GetBooleani_v)GetExtensionDelegateStatic("glGetBooleani_v", typeof(Delegates.GetBooleani_v));
            Delegates.glGetBooleani_v((OpenTK.Graphics.OpenGL4.GetIndexedPName)target, (UInt32)index, (bool*)data);
        }
        internal static unsafe void Load_GetBooleanv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] bool* data)
        {
            Delegates.glGetBooleanv = (Delegates.GetBooleanv)GetExtensionDelegateStatic("glGetBooleanv", typeof(Delegates.GetBooleanv));
            Delegates.glGetBooleanv((OpenTK.Graphics.OpenGL4.GetPName)pname, (bool*)data);
        }
        internal static unsafe void Load_GetBufferParameteri64v(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int64* @params)
        {
            Delegates.glGetBufferParameteri64v = (Delegates.GetBufferParameteri64v)GetExtensionDelegateStatic("glGetBufferParameteri64v", typeof(Delegates.GetBufferParameteri64v));
            Delegates.glGetBufferParameteri64v((OpenTK.Graphics.OpenGL4.BufferTarget)target, (OpenTK.Graphics.OpenGL4.BufferParameterName)pname, (Int64*)@params);
        }
        internal static unsafe void Load_GetBufferParameteriv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetBufferParameteriv = (Delegates.GetBufferParameteriv)GetExtensionDelegateStatic("glGetBufferParameteriv", typeof(Delegates.GetBufferParameteriv));
            Delegates.glGetBufferParameteriv((OpenTK.Graphics.OpenGL4.BufferTarget)target, (OpenTK.Graphics.OpenGL4.BufferParameterName)pname, (Int32*)@params);
        }
        internal static void Load_GetBufferPointerv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferPointer pname, [OutAttribute] IntPtr @params)
        {
            Delegates.glGetBufferPointerv = (Delegates.GetBufferPointerv)GetExtensionDelegateStatic("glGetBufferPointerv", typeof(Delegates.GetBufferPointerv));
            Delegates.glGetBufferPointerv((OpenTK.Graphics.OpenGL4.BufferTarget)target, (OpenTK.Graphics.OpenGL4.BufferPointer)pname, (IntPtr)@params);
        }
        internal static void Load_GetBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data)
        {
            Delegates.glGetBufferSubData = (Delegates.GetBufferSubData)GetExtensionDelegateStatic("glGetBufferSubData", typeof(Delegates.GetBufferSubData));
            Delegates.glGetBufferSubData((OpenTK.Graphics.OpenGL4.BufferTarget)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data);
        }
        internal static void Load_GetColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr table)
        {
            Delegates.glGetColorTable = (Delegates.GetColorTable)GetExtensionDelegateStatic("glGetColorTable", typeof(Delegates.GetColorTable));
            Delegates.glGetColorTable((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)table);
        }
        internal static unsafe void Load_GetColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetColorTableParameterfv = (Delegates.GetColorTableParameterfv)GetExtensionDelegateStatic("glGetColorTableParameterfv", typeof(Delegates.GetColorTableParameterfv));
            Delegates.glGetColorTableParameterfv((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (OpenTK.Graphics.OpenGL4.GetColorTableParameterPName)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetColorTableParameteriv = (Delegates.GetColorTableParameteriv)GetExtensionDelegateStatic("glGetColorTableParameteriv", typeof(Delegates.GetColorTableParameteriv));
            Delegates.glGetColorTableParameteriv((OpenTK.Graphics.OpenGL4.ColorTableTarget)target, (OpenTK.Graphics.OpenGL4.GetColorTableParameterPName)pname, (Int32*)@params);
        }
        internal static void Load_GetCompressedTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, [OutAttribute] IntPtr img)
        {
            Delegates.glGetCompressedTexImage = (Delegates.GetCompressedTexImage)GetExtensionDelegateStatic("glGetCompressedTexImage", typeof(Delegates.GetCompressedTexImage));
            Delegates.glGetCompressedTexImage((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (IntPtr)img);
        }
        internal static void Load_GetConvolutionFilter(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr image)
        {
            Delegates.glGetConvolutionFilter = (Delegates.GetConvolutionFilter)GetExtensionDelegateStatic("glGetConvolutionFilter", typeof(Delegates.GetConvolutionFilter));
            Delegates.glGetConvolutionFilter((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)image);
        }
        internal static unsafe void Load_GetConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetConvolutionParameterfv = (Delegates.GetConvolutionParameterfv)GetExtensionDelegateStatic("glGetConvolutionParameterfv", typeof(Delegates.GetConvolutionParameterfv));
            Delegates.glGetConvolutionParameterfv((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetConvolutionParameteriv = (Delegates.GetConvolutionParameteriv)GetExtensionDelegateStatic("glGetConvolutionParameteriv", typeof(Delegates.GetConvolutionParameteriv));
            Delegates.glGetConvolutionParameteriv((OpenTK.Graphics.OpenGL4.ConvolutionTarget)target, (OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName)pname, (Int32*)@params);
        }
        internal static unsafe Int32 Load_GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugSource* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog)
        {
            Delegates.glGetDebugMessageLog = (Delegates.GetDebugMessageLog)GetExtensionDelegateStatic("glGetDebugMessageLog", typeof(Delegates.GetDebugMessageLog));
            return Delegates.glGetDebugMessageLog((UInt32)count, (Int32)bufSize, (OpenTK.Graphics.OpenGL4.DebugSource*)sources, (OpenTK.Graphics.OpenGL4.DebugType*)types, (UInt32*)ids, (OpenTK.Graphics.OpenGL4.DebugSeverity*)severities, (Int32*)lengths, (StringBuilder)messageLog);
        }
        internal static unsafe Int32 Load_GetDebugMessageLogARB(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog)
        {
            Delegates.glGetDebugMessageLogARB = (Delegates.GetDebugMessageLogARB)GetExtensionDelegateStatic("glGetDebugMessageLogARB", typeof(Delegates.GetDebugMessageLogARB));
            return Delegates.glGetDebugMessageLogARB((UInt32)count, (Int32)bufSize, (OpenTK.Graphics.OpenGL4.All*)sources, (OpenTK.Graphics.OpenGL4.All*)types, (UInt32*)ids, (OpenTK.Graphics.OpenGL4.All*)severities, (Int32*)lengths, (StringBuilder)messageLog);
        }
        internal static unsafe Int32 Load_GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog)
        {
            Delegates.glGetDebugMessageLogKHR = (Delegates.GetDebugMessageLogKHR)GetExtensionDelegateStatic("glGetDebugMessageLogKHR", typeof(Delegates.GetDebugMessageLogKHR));
            return Delegates.glGetDebugMessageLogKHR((UInt32)count, (Int32)bufSize, (OpenTK.Graphics.OpenGL4.All*)sources, (OpenTK.Graphics.OpenGL4.All*)types, (UInt32*)ids, (OpenTK.Graphics.OpenGL4.All*)severities, (Int32*)lengths, (StringBuilder)messageLog);
        }
        internal static unsafe void Load_GetDoublei_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Double* data)
        {
            Delegates.glGetDoublei_v = (Delegates.GetDoublei_v)GetExtensionDelegateStatic("glGetDoublei_v", typeof(Delegates.GetDoublei_v));
            Delegates.glGetDoublei_v((OpenTK.Graphics.OpenGL4.GetIndexedPName)target, (UInt32)index, (Double*)data);
        }
        internal static unsafe void Load_GetDoublev(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Double* data)
        {
            Delegates.glGetDoublev = (Delegates.GetDoublev)GetExtensionDelegateStatic("glGetDoublev", typeof(Delegates.GetDoublev));
            Delegates.glGetDoublev((OpenTK.Graphics.OpenGL4.GetPName)pname, (Double*)data);
        }
        internal static OpenTK.Graphics.OpenGL4.ErrorCode Load_GetError()
        {
            Delegates.glGetError = (Delegates.GetError)GetExtensionDelegateStatic("glGetError", typeof(Delegates.GetError));
            return Delegates.glGetError();
        }
        internal static unsafe void Load_GetFloati_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Single* data)
        {
            Delegates.glGetFloati_v = (Delegates.GetFloati_v)GetExtensionDelegateStatic("glGetFloati_v", typeof(Delegates.GetFloati_v));
            Delegates.glGetFloati_v((OpenTK.Graphics.OpenGL4.GetIndexedPName)target, (UInt32)index, (Single*)data);
        }
        internal static unsafe void Load_GetFloatv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Single* data)
        {
            Delegates.glGetFloatv = (Delegates.GetFloatv)GetExtensionDelegateStatic("glGetFloatv", typeof(Delegates.GetFloatv));
            Delegates.glGetFloatv((OpenTK.Graphics.OpenGL4.GetPName)pname, (Single*)data);
        }
        internal static Int32 Load_GetFragDataIndex(UInt32 program, String name)
        {
            Delegates.glGetFragDataIndex = (Delegates.GetFragDataIndex)GetExtensionDelegateStatic("glGetFragDataIndex", typeof(Delegates.GetFragDataIndex));
            return Delegates.glGetFragDataIndex((UInt32)program, (String)name);
        }
        internal static Int32 Load_GetFragDataLocation(UInt32 program, String name)
        {
            Delegates.glGetFragDataLocation = (Delegates.GetFragDataLocation)GetExtensionDelegateStatic("glGetFragDataLocation", typeof(Delegates.GetFragDataLocation));
            return Delegates.glGetFragDataLocation((UInt32)program, (String)name);
        }
        internal static unsafe void Load_GetFramebufferAttachmentParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetFramebufferAttachmentParameteriv = (Delegates.GetFramebufferAttachmentParameteriv)GetExtensionDelegateStatic("glGetFramebufferAttachmentParameteriv", typeof(Delegates.GetFramebufferAttachmentParameteriv));
            Delegates.glGetFramebufferAttachmentParameteriv((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferAttachment)attachment, (OpenTK.Graphics.OpenGL4.FramebufferParameterName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetFramebufferParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetFramebufferParameteriv = (Delegates.GetFramebufferParameteriv)GetExtensionDelegateStatic("glGetFramebufferParameteriv", typeof(Delegates.GetFramebufferParameteriv));
            Delegates.glGetFramebufferParameteriv((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter)pname, (Int32*)@params);
        }
        internal static OpenTK.Graphics.OpenGL4.All Load_GetGraphicsResetStatusARB()
        {
            Delegates.glGetGraphicsResetStatusARB = (Delegates.GetGraphicsResetStatusARB)GetExtensionDelegateStatic("glGetGraphicsResetStatusARB", typeof(Delegates.GetGraphicsResetStatusARB));
            return Delegates.glGetGraphicsResetStatusARB();
        }
        internal static void Load_GetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values)
        {
            Delegates.glGetHistogram = (Delegates.GetHistogram)GetExtensionDelegateStatic("glGetHistogram", typeof(Delegates.GetHistogram));
            Delegates.glGetHistogram((OpenTK.Graphics.OpenGL4.HistogramTarget)target, (bool)reset, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)values);
        }
        internal static unsafe void Load_GetHistogramParameterfv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetHistogramParameterfv = (Delegates.GetHistogramParameterfv)GetExtensionDelegateStatic("glGetHistogramParameterfv", typeof(Delegates.GetHistogramParameterfv));
            Delegates.glGetHistogramParameterfv((OpenTK.Graphics.OpenGL4.HistogramTarget)target, (OpenTK.Graphics.OpenGL4.GetHistogramParameterPName)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetHistogramParameteriv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetHistogramParameteriv = (Delegates.GetHistogramParameteriv)GetExtensionDelegateStatic("glGetHistogramParameteriv", typeof(Delegates.GetHistogramParameteriv));
            Delegates.glGetHistogramParameteriv((OpenTK.Graphics.OpenGL4.HistogramTarget)target, (OpenTK.Graphics.OpenGL4.GetHistogramParameterPName)pname, (Int32*)@params);
        }
        internal static Int64 Load_GetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.All format)
        {
            Delegates.glGetImageHandleARB = (Delegates.GetImageHandleARB)GetExtensionDelegateStatic("glGetImageHandleARB", typeof(Delegates.GetImageHandleARB));
            return Delegates.glGetImageHandleARB((UInt32)texture, (Int32)level, (bool)layered, (Int32)layer, (OpenTK.Graphics.OpenGL4.All)format);
        }
        internal static unsafe void Load_GetInteger64i_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data)
        {
            Delegates.glGetInteger64i_v = (Delegates.GetInteger64i_v)GetExtensionDelegateStatic("glGetInteger64i_v", typeof(Delegates.GetInteger64i_v));
            Delegates.glGetInteger64i_v((OpenTK.Graphics.OpenGL4.GetIndexedPName)target, (UInt32)index, (Int64*)data);
        }
        internal static unsafe void Load_GetInteger64v(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int64* data)
        {
            Delegates.glGetInteger64v = (Delegates.GetInteger64v)GetExtensionDelegateStatic("glGetInteger64v", typeof(Delegates.GetInteger64v));
            Delegates.glGetInteger64v((OpenTK.Graphics.OpenGL4.GetPName)pname, (Int64*)data);
        }
        internal static unsafe void Load_GetIntegeri_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data)
        {
            Delegates.glGetIntegeri_v = (Delegates.GetIntegeri_v)GetExtensionDelegateStatic("glGetIntegeri_v", typeof(Delegates.GetIntegeri_v));
            Delegates.glGetIntegeri_v((OpenTK.Graphics.OpenGL4.GetIndexedPName)target, (UInt32)index, (Int32*)data);
        }
        internal static unsafe void Load_GetIntegerv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int32* data)
        {
            Delegates.glGetIntegerv = (Delegates.GetIntegerv)GetExtensionDelegateStatic("glGetIntegerv", typeof(Delegates.GetIntegerv));
            Delegates.glGetIntegerv((OpenTK.Graphics.OpenGL4.GetPName)pname, (Int32*)data);
        }
        internal static unsafe void Load_GetInternalformati64v(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int64* @params)
        {
            Delegates.glGetInternalformati64v = (Delegates.GetInternalformati64v)GetExtensionDelegateStatic("glGetInternalformati64v", typeof(Delegates.GetInternalformati64v));
            Delegates.glGetInternalformati64v((OpenTK.Graphics.OpenGL4.ImageTarget)target, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (OpenTK.Graphics.OpenGL4.InternalFormatParameter)pname, (Int32)bufSize, (Int64*)@params);
        }
        internal static unsafe void Load_GetInternalformativ(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int32* @params)
        {
            Delegates.glGetInternalformativ = (Delegates.GetInternalformativ)GetExtensionDelegateStatic("glGetInternalformativ", typeof(Delegates.GetInternalformativ));
            Delegates.glGetInternalformativ((OpenTK.Graphics.OpenGL4.ImageTarget)target, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (OpenTK.Graphics.OpenGL4.InternalFormatParameter)pname, (Int32)bufSize, (Int32*)@params);
        }
        internal static void Load_GetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values)
        {
            Delegates.glGetMinmax = (Delegates.GetMinmax)GetExtensionDelegateStatic("glGetMinmax", typeof(Delegates.GetMinmax));
            Delegates.glGetMinmax((OpenTK.Graphics.OpenGL4.MinmaxTarget)target, (bool)reset, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)values);
        }
        internal static unsafe void Load_GetMinmaxParameterfv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetMinmaxParameterfv = (Delegates.GetMinmaxParameterfv)GetExtensionDelegateStatic("glGetMinmaxParameterfv", typeof(Delegates.GetMinmaxParameterfv));
            Delegates.glGetMinmaxParameterfv((OpenTK.Graphics.OpenGL4.MinmaxTarget)target, (OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetMinmaxParameteriv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetMinmaxParameteriv = (Delegates.GetMinmaxParameteriv)GetExtensionDelegateStatic("glGetMinmaxParameteriv", typeof(Delegates.GetMinmaxParameteriv));
            Delegates.glGetMinmaxParameteriv((OpenTK.Graphics.OpenGL4.MinmaxTarget)target, (OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetMultisamplefv(OpenTK.Graphics.OpenGL4.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single* val)
        {
            Delegates.glGetMultisamplefv = (Delegates.GetMultisamplefv)GetExtensionDelegateStatic("glGetMultisamplefv", typeof(Delegates.GetMultisamplefv));
            Delegates.glGetMultisamplefv((OpenTK.Graphics.OpenGL4.GetMultisamplePName)pname, (UInt32)index, (Single*)val);
        }
        internal static unsafe void Load_GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, [OutAttribute] Int32* stringlen, [OutAttribute] StringBuilder @string)
        {
            Delegates.glGetNamedStringARB = (Delegates.GetNamedStringARB)GetExtensionDelegateStatic("glGetNamedStringARB", typeof(Delegates.GetNamedStringARB));
            Delegates.glGetNamedStringARB((Int32)namelen, (String)name, (Int32)bufSize, (Int32*)stringlen, (StringBuilder)@string);
        }
        internal static unsafe void Load_GetNamedStringivARB(Int32 namelen, String name, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetNamedStringivARB = (Delegates.GetNamedStringivARB)GetExtensionDelegateStatic("glGetNamedStringivARB", typeof(Delegates.GetNamedStringivARB));
            Delegates.glGetNamedStringivARB((Int32)namelen, (String)name, (OpenTK.Graphics.OpenGL4.All)pname, (Int32*)@params);
        }
        internal static void Load_GetnColorTableARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr table)
        {
            Delegates.glGetnColorTableARB = (Delegates.GetnColorTableARB)GetExtensionDelegateStatic("glGetnColorTableARB", typeof(Delegates.GetnColorTableARB));
            Delegates.glGetnColorTableARB((OpenTK.Graphics.OpenGL4.All)target, (OpenTK.Graphics.OpenGL4.All)format, (OpenTK.Graphics.OpenGL4.All)type, (Int32)bufSize, (IntPtr)table);
        }
        internal static void Load_GetnCompressedTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 lod, Int32 bufSize, [OutAttribute] IntPtr img)
        {
            Delegates.glGetnCompressedTexImageARB = (Delegates.GetnCompressedTexImageARB)GetExtensionDelegateStatic("glGetnCompressedTexImageARB", typeof(Delegates.GetnCompressedTexImageARB));
            Delegates.glGetnCompressedTexImageARB((OpenTK.Graphics.OpenGL4.All)target, (Int32)lod, (Int32)bufSize, (IntPtr)img);
        }
        internal static void Load_GetnConvolutionFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr image)
        {
            Delegates.glGetnConvolutionFilterARB = (Delegates.GetnConvolutionFilterARB)GetExtensionDelegateStatic("glGetnConvolutionFilterARB", typeof(Delegates.GetnConvolutionFilterARB));
            Delegates.glGetnConvolutionFilterARB((OpenTK.Graphics.OpenGL4.All)target, (OpenTK.Graphics.OpenGL4.All)format, (OpenTK.Graphics.OpenGL4.All)type, (Int32)bufSize, (IntPtr)image);
        }
        internal static void Load_GetnHistogramARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values)
        {
            Delegates.glGetnHistogramARB = (Delegates.GetnHistogramARB)GetExtensionDelegateStatic("glGetnHistogramARB", typeof(Delegates.GetnHistogramARB));
            Delegates.glGetnHistogramARB((OpenTK.Graphics.OpenGL4.All)target, (bool)reset, (OpenTK.Graphics.OpenGL4.All)format, (OpenTK.Graphics.OpenGL4.All)type, (Int32)bufSize, (IntPtr)values);
        }
        internal static unsafe void Load_GetnMapdvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Double* v)
        {
            Delegates.glGetnMapdvARB = (Delegates.GetnMapdvARB)GetExtensionDelegateStatic("glGetnMapdvARB", typeof(Delegates.GetnMapdvARB));
            Delegates.glGetnMapdvARB((OpenTK.Graphics.OpenGL4.All)target, (OpenTK.Graphics.OpenGL4.All)query, (Int32)bufSize, (Double*)v);
        }
        internal static unsafe void Load_GetnMapfvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Single* v)
        {
            Delegates.glGetnMapfvARB = (Delegates.GetnMapfvARB)GetExtensionDelegateStatic("glGetnMapfvARB", typeof(Delegates.GetnMapfvARB));
            Delegates.glGetnMapfvARB((OpenTK.Graphics.OpenGL4.All)target, (OpenTK.Graphics.OpenGL4.All)query, (Int32)bufSize, (Single*)v);
        }
        internal static unsafe void Load_GetnMapivARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Int32* v)
        {
            Delegates.glGetnMapivARB = (Delegates.GetnMapivARB)GetExtensionDelegateStatic("glGetnMapivARB", typeof(Delegates.GetnMapivARB));
            Delegates.glGetnMapivARB((OpenTK.Graphics.OpenGL4.All)target, (OpenTK.Graphics.OpenGL4.All)query, (Int32)bufSize, (Int32*)v);
        }
        internal static void Load_GetnMinmaxARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values)
        {
            Delegates.glGetnMinmaxARB = (Delegates.GetnMinmaxARB)GetExtensionDelegateStatic("glGetnMinmaxARB", typeof(Delegates.GetnMinmaxARB));
            Delegates.glGetnMinmaxARB((OpenTK.Graphics.OpenGL4.All)target, (bool)reset, (OpenTK.Graphics.OpenGL4.All)format, (OpenTK.Graphics.OpenGL4.All)type, (Int32)bufSize, (IntPtr)values);
        }
        internal static unsafe void Load_GetnPixelMapfvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] Single* values)
        {
            Delegates.glGetnPixelMapfvARB = (Delegates.GetnPixelMapfvARB)GetExtensionDelegateStatic("glGetnPixelMapfvARB", typeof(Delegates.GetnPixelMapfvARB));
            Delegates.glGetnPixelMapfvARB((OpenTK.Graphics.OpenGL4.All)map, (Int32)bufSize, (Single*)values);
        }
        internal static unsafe void Load_GetnPixelMapuivARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt32* values)
        {
            Delegates.glGetnPixelMapuivARB = (Delegates.GetnPixelMapuivARB)GetExtensionDelegateStatic("glGetnPixelMapuivARB", typeof(Delegates.GetnPixelMapuivARB));
            Delegates.glGetnPixelMapuivARB((OpenTK.Graphics.OpenGL4.All)map, (Int32)bufSize, (UInt32*)values);
        }
        internal static unsafe void Load_GetnPixelMapusvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt16* values)
        {
            Delegates.glGetnPixelMapusvARB = (Delegates.GetnPixelMapusvARB)GetExtensionDelegateStatic("glGetnPixelMapusvARB", typeof(Delegates.GetnPixelMapusvARB));
            Delegates.glGetnPixelMapusvARB((OpenTK.Graphics.OpenGL4.All)map, (Int32)bufSize, (UInt16*)values);
        }
        internal static unsafe void Load_GetnPolygonStippleARB(Int32 bufSize, [OutAttribute] Byte* pattern)
        {
            Delegates.glGetnPolygonStippleARB = (Delegates.GetnPolygonStippleARB)GetExtensionDelegateStatic("glGetnPolygonStippleARB", typeof(Delegates.GetnPolygonStippleARB));
            Delegates.glGetnPolygonStippleARB((Int32)bufSize, (Byte*)pattern);
        }
        internal static void Load_GetnSeparableFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 rowBufSize, [OutAttribute] IntPtr row, Int32 columnBufSize, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span)
        {
            Delegates.glGetnSeparableFilterARB = (Delegates.GetnSeparableFilterARB)GetExtensionDelegateStatic("glGetnSeparableFilterARB", typeof(Delegates.GetnSeparableFilterARB));
            Delegates.glGetnSeparableFilterARB((OpenTK.Graphics.OpenGL4.All)target, (OpenTK.Graphics.OpenGL4.All)format, (OpenTK.Graphics.OpenGL4.All)type, (Int32)rowBufSize, (IntPtr)row, (Int32)columnBufSize, (IntPtr)column, (IntPtr)span);
        }
        internal static void Load_GetnTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr img)
        {
            Delegates.glGetnTexImageARB = (Delegates.GetnTexImageARB)GetExtensionDelegateStatic("glGetnTexImageARB", typeof(Delegates.GetnTexImageARB));
            Delegates.glGetnTexImageARB((OpenTK.Graphics.OpenGL4.All)target, (Int32)level, (OpenTK.Graphics.OpenGL4.All)format, (OpenTK.Graphics.OpenGL4.All)type, (Int32)bufSize, (IntPtr)img);
        }
        internal static unsafe void Load_GetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double* @params)
        {
            Delegates.glGetnUniformdvARB = (Delegates.GetnUniformdvARB)GetExtensionDelegateStatic("glGetnUniformdvARB", typeof(Delegates.GetnUniformdvARB));
            Delegates.glGetnUniformdvARB((UInt32)program, (Int32)location, (Int32)bufSize, (Double*)@params);
        }
        internal static unsafe void Load_GetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params)
        {
            Delegates.glGetnUniformfvARB = (Delegates.GetnUniformfvARB)GetExtensionDelegateStatic("glGetnUniformfvARB", typeof(Delegates.GetnUniformfvARB));
            Delegates.glGetnUniformfvARB((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params);
        }
        internal static unsafe void Load_GetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params)
        {
            Delegates.glGetnUniformivARB = (Delegates.GetnUniformivARB)GetExtensionDelegateStatic("glGetnUniformivARB", typeof(Delegates.GetnUniformivARB));
            Delegates.glGetnUniformivARB((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params);
        }
        internal static unsafe void Load_GetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetnUniformuivARB = (Delegates.GetnUniformuivARB)GetExtensionDelegateStatic("glGetnUniformuivARB", typeof(Delegates.GetnUniformuivARB));
            Delegates.glGetnUniformuivARB((UInt32)program, (Int32)location, (Int32)bufSize, (UInt32*)@params);
        }
        internal static unsafe void Load_GetObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label)
        {
            Delegates.glGetObjectLabel = (Delegates.GetObjectLabel)GetExtensionDelegateStatic("glGetObjectLabel", typeof(Delegates.GetObjectLabel));
            Delegates.glGetObjectLabel((OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier)identifier, (UInt32)name, (Int32)bufSize, (Int32*)length, (StringBuilder)label);
        }
        internal static unsafe void Load_GetObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label)
        {
            Delegates.glGetObjectLabelKHR = (Delegates.GetObjectLabelKHR)GetExtensionDelegateStatic("glGetObjectLabelKHR", typeof(Delegates.GetObjectLabelKHR));
            Delegates.glGetObjectLabelKHR((OpenTK.Graphics.OpenGL4.All)identifier, (UInt32)name, (Int32)bufSize, (Int32*)length, (StringBuilder)label);
        }
        internal static unsafe void Load_GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label)
        {
            Delegates.glGetObjectPtrLabel = (Delegates.GetObjectPtrLabel)GetExtensionDelegateStatic("glGetObjectPtrLabel", typeof(Delegates.GetObjectPtrLabel));
            Delegates.glGetObjectPtrLabel((IntPtr)ptr, (Int32)bufSize, (Int32*)length, (StringBuilder)label);
        }
        internal static unsafe void Load_GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label)
        {
            Delegates.glGetObjectPtrLabelKHR = (Delegates.GetObjectPtrLabelKHR)GetExtensionDelegateStatic("glGetObjectPtrLabelKHR", typeof(Delegates.GetObjectPtrLabelKHR));
            Delegates.glGetObjectPtrLabelKHR((IntPtr)ptr, (Int32)bufSize, (Int32*)length, (StringBuilder)label);
        }
        internal static void Load_GetPointerv(OpenTK.Graphics.OpenGL4.GetPointervPName pname, [OutAttribute] IntPtr @params)
        {
            Delegates.glGetPointerv = (Delegates.GetPointerv)GetExtensionDelegateStatic("glGetPointerv", typeof(Delegates.GetPointerv));
            Delegates.glGetPointerv((OpenTK.Graphics.OpenGL4.GetPointervPName)pname, (IntPtr)@params);
        }
        internal static void Load_GetPointervKHR(OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] IntPtr @params)
        {
            Delegates.glGetPointervKHR = (Delegates.GetPointervKHR)GetExtensionDelegateStatic("glGetPointervKHR", typeof(Delegates.GetPointervKHR));
            Delegates.glGetPointervKHR((OpenTK.Graphics.OpenGL4.All)pname, (IntPtr)@params);
        }
        internal static unsafe void Load_GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [OutAttribute] IntPtr binary)
        {
            Delegates.glGetProgramBinary = (Delegates.GetProgramBinary)GetExtensionDelegateStatic("glGetProgramBinary", typeof(Delegates.GetProgramBinary));
            Delegates.glGetProgramBinary((UInt32)program, (Int32)bufSize, (Int32*)length, (OpenTK.Graphics.OpenGL4.BinaryFormat*)binaryFormat, (IntPtr)binary);
        }
        internal static unsafe void Load_GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog)
        {
            Delegates.glGetProgramInfoLog = (Delegates.GetProgramInfoLog)GetExtensionDelegateStatic("glGetProgramInfoLog", typeof(Delegates.GetProgramInfoLog));
            Delegates.glGetProgramInfoLog((UInt32)program, (Int32)bufSize, (Int32*)length, (StringBuilder)infoLog);
        }
        internal static unsafe void Load_GetProgramInterfaceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, OpenTK.Graphics.OpenGL4.ProgramInterfaceParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetProgramInterfaceiv = (Delegates.GetProgramInterfaceiv)GetExtensionDelegateStatic("glGetProgramInterfaceiv", typeof(Delegates.GetProgramInterfaceiv));
            Delegates.glGetProgramInterfaceiv((UInt32)program, (OpenTK.Graphics.OpenGL4.ProgramInterface)programInterface, (OpenTK.Graphics.OpenGL4.ProgramInterfaceParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetProgramiv(UInt32 program, OpenTK.Graphics.OpenGL4.GetProgramParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetProgramiv = (Delegates.GetProgramiv)GetExtensionDelegateStatic("glGetProgramiv", typeof(Delegates.GetProgramiv));
            Delegates.glGetProgramiv((UInt32)program, (OpenTK.Graphics.OpenGL4.GetProgramParameterName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog)
        {
            Delegates.glGetProgramPipelineInfoLog = (Delegates.GetProgramPipelineInfoLog)GetExtensionDelegateStatic("glGetProgramPipelineInfoLog", typeof(Delegates.GetProgramPipelineInfoLog));
            Delegates.glGetProgramPipelineInfoLog((UInt32)pipeline, (Int32)bufSize, (Int32*)length, (StringBuilder)infoLog);
        }
        internal static unsafe void Load_GetProgramPipelineiv(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramPipelineParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetProgramPipelineiv = (Delegates.GetProgramPipelineiv)GetExtensionDelegateStatic("glGetProgramPipelineiv", typeof(Delegates.GetProgramPipelineiv));
            Delegates.glGetProgramPipelineiv((UInt32)pipeline, (OpenTK.Graphics.OpenGL4.ProgramPipelineParameter)pname, (Int32*)@params);
        }
        internal static Int32 Load_GetProgramResourceIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name)
        {
            Delegates.glGetProgramResourceIndex = (Delegates.GetProgramResourceIndex)GetExtensionDelegateStatic("glGetProgramResourceIndex", typeof(Delegates.GetProgramResourceIndex));
            return Delegates.glGetProgramResourceIndex((UInt32)program, (OpenTK.Graphics.OpenGL4.ProgramInterface)programInterface, (String)name);
        }
        internal static unsafe void Load_GetProgramResourceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 propCount, OpenTK.Graphics.OpenGL4.ProgramProperty* props, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* @params)
        {
            Delegates.glGetProgramResourceiv = (Delegates.GetProgramResourceiv)GetExtensionDelegateStatic("glGetProgramResourceiv", typeof(Delegates.GetProgramResourceiv));
            Delegates.glGetProgramResourceiv((UInt32)program, (OpenTK.Graphics.OpenGL4.ProgramInterface)programInterface, (UInt32)index, (Int32)propCount, (OpenTK.Graphics.OpenGL4.ProgramProperty*)props, (Int32)bufSize, (Int32*)length, (Int32*)@params);
        }
        internal static Int32 Load_GetProgramResourceLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name)
        {
            Delegates.glGetProgramResourceLocation = (Delegates.GetProgramResourceLocation)GetExtensionDelegateStatic("glGetProgramResourceLocation", typeof(Delegates.GetProgramResourceLocation));
            return Delegates.glGetProgramResourceLocation((UInt32)program, (OpenTK.Graphics.OpenGL4.ProgramInterface)programInterface, (String)name);
        }
        internal static Int32 Load_GetProgramResourceLocationIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name)
        {
            Delegates.glGetProgramResourceLocationIndex = (Delegates.GetProgramResourceLocationIndex)GetExtensionDelegateStatic("glGetProgramResourceLocationIndex", typeof(Delegates.GetProgramResourceLocationIndex));
            return Delegates.glGetProgramResourceLocationIndex((UInt32)program, (OpenTK.Graphics.OpenGL4.ProgramInterface)programInterface, (String)name);
        }
        internal static unsafe void Load_GetProgramResourceName(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetProgramResourceName = (Delegates.GetProgramResourceName)GetExtensionDelegateStatic("glGetProgramResourceName", typeof(Delegates.GetProgramResourceName));
            Delegates.glGetProgramResourceName((UInt32)program, (OpenTK.Graphics.OpenGL4.ProgramInterface)programInterface, (UInt32)index, (Int32)bufSize, (Int32*)length, (StringBuilder)name);
        }
        internal static unsafe void Load_GetProgramStageiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute] Int32* values)
        {
            Delegates.glGetProgramStageiv = (Delegates.GetProgramStageiv)GetExtensionDelegateStatic("glGetProgramStageiv", typeof(Delegates.GetProgramStageiv));
            Delegates.glGetProgramStageiv((UInt32)program, (OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (OpenTK.Graphics.OpenGL4.ProgramStageParameter)pname, (Int32*)values);
        }
        internal static unsafe void Load_GetQueryIndexediv(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetQueryIndexediv = (Delegates.GetQueryIndexediv)GetExtensionDelegateStatic("glGetQueryIndexediv", typeof(Delegates.GetQueryIndexediv));
            Delegates.glGetQueryIndexediv((OpenTK.Graphics.OpenGL4.QueryTarget)target, (UInt32)index, (OpenTK.Graphics.OpenGL4.GetQueryParam)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetQueryiv(OpenTK.Graphics.OpenGL4.QueryTarget target, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetQueryiv = (Delegates.GetQueryiv)GetExtensionDelegateStatic("glGetQueryiv", typeof(Delegates.GetQueryiv));
            Delegates.glGetQueryiv((OpenTK.Graphics.OpenGL4.QueryTarget)target, (OpenTK.Graphics.OpenGL4.GetQueryParam)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetQueryObjecti64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int64* @params)
        {
            Delegates.glGetQueryObjecti64v = (Delegates.GetQueryObjecti64v)GetExtensionDelegateStatic("glGetQueryObjecti64v", typeof(Delegates.GetQueryObjecti64v));
            Delegates.glGetQueryObjecti64v((UInt32)id, (OpenTK.Graphics.OpenGL4.GetQueryObjectParam)pname, (Int64*)@params);
        }
        internal static unsafe void Load_GetQueryObjectiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetQueryObjectiv = (Delegates.GetQueryObjectiv)GetExtensionDelegateStatic("glGetQueryObjectiv", typeof(Delegates.GetQueryObjectiv));
            Delegates.glGetQueryObjectiv((UInt32)id, (OpenTK.Graphics.OpenGL4.GetQueryObjectParam)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetQueryObjectui64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt64* @params)
        {
            Delegates.glGetQueryObjectui64v = (Delegates.GetQueryObjectui64v)GetExtensionDelegateStatic("glGetQueryObjectui64v", typeof(Delegates.GetQueryObjectui64v));
            Delegates.glGetQueryObjectui64v((UInt32)id, (OpenTK.Graphics.OpenGL4.GetQueryObjectParam)pname, (UInt64*)@params);
        }
        internal static unsafe void Load_GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetQueryObjectuiv = (Delegates.GetQueryObjectuiv)GetExtensionDelegateStatic("glGetQueryObjectuiv", typeof(Delegates.GetQueryObjectuiv));
            Delegates.glGetQueryObjectuiv((UInt32)id, (OpenTK.Graphics.OpenGL4.GetQueryObjectParam)pname, (UInt32*)@params);
        }
        internal static unsafe void Load_GetRenderbufferParameteriv(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetRenderbufferParameteriv = (Delegates.GetRenderbufferParameteriv)GetExtensionDelegateStatic("glGetRenderbufferParameteriv", typeof(Delegates.GetRenderbufferParameteriv));
            Delegates.glGetRenderbufferParameteriv((OpenTK.Graphics.OpenGL4.RenderbufferTarget)target, (OpenTK.Graphics.OpenGL4.RenderbufferParameterName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetSamplerParameterfv = (Delegates.GetSamplerParameterfv)GetExtensionDelegateStatic("glGetSamplerParameterfv", typeof(Delegates.GetSamplerParameterfv));
            Delegates.glGetSamplerParameterfv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetSamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetSamplerParameterIiv = (Delegates.GetSamplerParameterIiv)GetExtensionDelegateStatic("glGetSamplerParameterIiv", typeof(Delegates.GetSamplerParameterIiv));
            Delegates.glGetSamplerParameterIiv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.All)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetSamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetSamplerParameterIuiv = (Delegates.GetSamplerParameterIuiv)GetExtensionDelegateStatic("glGetSamplerParameterIuiv", typeof(Delegates.GetSamplerParameterIuiv));
            Delegates.glGetSamplerParameterIuiv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.All)pname, (UInt32*)@params);
        }
        internal static unsafe void Load_GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetSamplerParameteriv = (Delegates.GetSamplerParameteriv)GetExtensionDelegateStatic("glGetSamplerParameteriv", typeof(Delegates.GetSamplerParameteriv));
            Delegates.glGetSamplerParameteriv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (Int32*)@params);
        }
        internal static void Load_GetSeparableFilter(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span)
        {
            Delegates.glGetSeparableFilter = (Delegates.GetSeparableFilter)GetExtensionDelegateStatic("glGetSeparableFilter", typeof(Delegates.GetSeparableFilter));
            Delegates.glGetSeparableFilter((OpenTK.Graphics.OpenGL4.SeparableTarget)target, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)row, (IntPtr)column, (IntPtr)span);
        }
        internal static unsafe void Load_GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog)
        {
            Delegates.glGetShaderInfoLog = (Delegates.GetShaderInfoLog)GetExtensionDelegateStatic("glGetShaderInfoLog", typeof(Delegates.GetShaderInfoLog));
            Delegates.glGetShaderInfoLog((UInt32)shader, (Int32)bufSize, (Int32*)length, (StringBuilder)infoLog);
        }
        internal static unsafe void Load_GetShaderiv(UInt32 shader, OpenTK.Graphics.OpenGL4.ShaderParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetShaderiv = (Delegates.GetShaderiv)GetExtensionDelegateStatic("glGetShaderiv", typeof(Delegates.GetShaderiv));
            Delegates.glGetShaderiv((UInt32)shader, (OpenTK.Graphics.OpenGL4.ShaderParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision)
        {
            Delegates.glGetShaderPrecisionFormat = (Delegates.GetShaderPrecisionFormat)GetExtensionDelegateStatic("glGetShaderPrecisionFormat", typeof(Delegates.GetShaderPrecisionFormat));
            Delegates.glGetShaderPrecisionFormat((OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (OpenTK.Graphics.OpenGL4.ShaderPrecision)precisiontype, (Int32*)range, (Int32*)precision);
        }
        internal static unsafe void Load_GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source)
        {
            Delegates.glGetShaderSource = (Delegates.GetShaderSource)GetExtensionDelegateStatic("glGetShaderSource", typeof(Delegates.GetShaderSource));
            Delegates.glGetShaderSource((UInt32)shader, (Int32)bufSize, (Int32*)length, (StringBuilder)source);
        }
        internal static IntPtr Load_GetString(OpenTK.Graphics.OpenGL4.StringName name)
        {
            Delegates.glGetString = (Delegates.GetString)GetExtensionDelegateStatic("glGetString", typeof(Delegates.GetString));
            return Delegates.glGetString((OpenTK.Graphics.OpenGL4.StringName)name);
        }
        internal static IntPtr Load_GetStringi(OpenTK.Graphics.OpenGL4.StringNameIndexed name, UInt32 index)
        {
            Delegates.glGetStringi = (Delegates.GetStringi)GetExtensionDelegateStatic("glGetStringi", typeof(Delegates.GetStringi));
            return Delegates.glGetStringi((OpenTK.Graphics.OpenGL4.StringNameIndexed)name, (UInt32)index);
        }
        internal static Int32 Load_GetSubroutineIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name)
        {
            Delegates.glGetSubroutineIndex = (Delegates.GetSubroutineIndex)GetExtensionDelegateStatic("glGetSubroutineIndex", typeof(Delegates.GetSubroutineIndex));
            return Delegates.glGetSubroutineIndex((UInt32)program, (OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (String)name);
        }
        internal static Int32 Load_GetSubroutineUniformLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name)
        {
            Delegates.glGetSubroutineUniformLocation = (Delegates.GetSubroutineUniformLocation)GetExtensionDelegateStatic("glGetSubroutineUniformLocation", typeof(Delegates.GetSubroutineUniformLocation));
            return Delegates.glGetSubroutineUniformLocation((UInt32)program, (OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (String)name);
        }
        internal static unsafe void Load_GetSynciv(IntPtr sync, OpenTK.Graphics.OpenGL4.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values)
        {
            Delegates.glGetSynciv = (Delegates.GetSynciv)GetExtensionDelegateStatic("glGetSynciv", typeof(Delegates.GetSynciv));
            Delegates.glGetSynciv((IntPtr)sync, (OpenTK.Graphics.OpenGL4.SyncParameterName)pname, (Int32)bufSize, (Int32*)length, (Int32*)values);
        }
        internal static void Load_GetTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels)
        {
            Delegates.glGetTexImage = (Delegates.GetTexImage)GetExtensionDelegateStatic("glGetTexImage", typeof(Delegates.GetTexImage));
            Delegates.glGetTexImage((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static unsafe void Load_GetTexLevelParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetTexLevelParameterfv = (Delegates.GetTexLevelParameterfv)GetExtensionDelegateStatic("glGetTexLevelParameterfv", typeof(Delegates.GetTexLevelParameterfv));
            Delegates.glGetTexLevelParameterfv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.GetTextureParameter)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetTexLevelParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetTexLevelParameteriv = (Delegates.GetTexLevelParameteriv)GetExtensionDelegateStatic("glGetTexLevelParameteriv", typeof(Delegates.GetTexLevelParameteriv));
            Delegates.glGetTexLevelParameteriv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.GetTextureParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetTexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetTexParameterfv = (Delegates.GetTexParameterfv)GetExtensionDelegateStatic("glGetTexParameterfv", typeof(Delegates.GetTexParameterfv));
            Delegates.glGetTexParameterfv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.GetTextureParameter)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetTexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetTexParameterIiv = (Delegates.GetTexParameterIiv)GetExtensionDelegateStatic("glGetTexParameterIiv", typeof(Delegates.GetTexParameterIiv));
            Delegates.glGetTexParameterIiv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.GetTextureParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetTexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetTexParameterIuiv = (Delegates.GetTexParameterIuiv)GetExtensionDelegateStatic("glGetTexParameterIuiv", typeof(Delegates.GetTexParameterIuiv));
            Delegates.glGetTexParameterIuiv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.GetTextureParameter)pname, (UInt32*)@params);
        }
        internal static unsafe void Load_GetTexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetTexParameteriv = (Delegates.GetTexParameteriv)GetExtensionDelegateStatic("glGetTexParameteriv", typeof(Delegates.GetTexParameteriv));
            Delegates.glGetTexParameteriv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.GetTextureParameter)pname, (Int32*)@params);
        }
        internal static Int64 Load_GetTextureHandleARB(UInt32 texture)
        {
            Delegates.glGetTextureHandleARB = (Delegates.GetTextureHandleARB)GetExtensionDelegateStatic("glGetTextureHandleARB", typeof(Delegates.GetTextureHandleARB));
            return Delegates.glGetTextureHandleARB((UInt32)texture);
        }
        internal static Int64 Load_GetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler)
        {
            Delegates.glGetTextureSamplerHandleARB = (Delegates.GetTextureSamplerHandleARB)GetExtensionDelegateStatic("glGetTextureSamplerHandleARB", typeof(Delegates.GetTextureSamplerHandleARB));
            return Delegates.glGetTextureSamplerHandleARB((UInt32)texture, (UInt32)sampler);
        }
        internal static unsafe void Load_GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.TransformFeedbackType* type, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetTransformFeedbackVarying = (Delegates.GetTransformFeedbackVarying)GetExtensionDelegateStatic("glGetTransformFeedbackVarying", typeof(Delegates.GetTransformFeedbackVarying));
            Delegates.glGetTransformFeedbackVarying((UInt32)program, (UInt32)index, (Int32)bufSize, (Int32*)length, (Int32*)size, (OpenTK.Graphics.OpenGL4.TransformFeedbackType*)type, (StringBuilder)name);
        }
        internal static Int32 Load_GetUniformBlockIndex(UInt32 program, String uniformBlockName)
        {
            Delegates.glGetUniformBlockIndex = (Delegates.GetUniformBlockIndex)GetExtensionDelegateStatic("glGetUniformBlockIndex", typeof(Delegates.GetUniformBlockIndex));
            return Delegates.glGetUniformBlockIndex((UInt32)program, (String)uniformBlockName);
        }
        internal static unsafe void Load_GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double* @params)
        {
            Delegates.glGetUniformdv = (Delegates.GetUniformdv)GetExtensionDelegateStatic("glGetUniformdv", typeof(Delegates.GetUniformdv));
            Delegates.glGetUniformdv((UInt32)program, (Int32)location, (Double*)@params);
        }
        internal static unsafe void Load_GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params)
        {
            Delegates.glGetUniformfv = (Delegates.GetUniformfv)GetExtensionDelegateStatic("glGetUniformfv", typeof(Delegates.GetUniformfv));
            Delegates.glGetUniformfv((UInt32)program, (Int32)location, (Single*)@params);
        }
        internal static unsafe void Load_GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices)
        {
            Delegates.glGetUniformIndices = (Delegates.GetUniformIndices)GetExtensionDelegateStatic("glGetUniformIndices", typeof(Delegates.GetUniformIndices));
            Delegates.glGetUniformIndices((UInt32)program, (Int32)uniformCount, (String[])uniformNames, (UInt32*)uniformIndices);
        }
        internal static unsafe void Load_GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params)
        {
            Delegates.glGetUniformiv = (Delegates.GetUniformiv)GetExtensionDelegateStatic("glGetUniformiv", typeof(Delegates.GetUniformiv));
            Delegates.glGetUniformiv((UInt32)program, (Int32)location, (Int32*)@params);
        }
        internal static Int32 Load_GetUniformLocation(UInt32 program, String name)
        {
            Delegates.glGetUniformLocation = (Delegates.GetUniformLocation)GetExtensionDelegateStatic("glGetUniformLocation", typeof(Delegates.GetUniformLocation));
            return Delegates.glGetUniformLocation((UInt32)program, (String)name);
        }
        internal static unsafe void Load_GetUniformSubroutineuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 location, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetUniformSubroutineuiv = (Delegates.GetUniformSubroutineuiv)GetExtensionDelegateStatic("glGetUniformSubroutineuiv", typeof(Delegates.GetUniformSubroutineuiv));
            Delegates.glGetUniformSubroutineuiv((OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (Int32)location, (UInt32*)@params);
        }
        internal static unsafe void Load_GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetUniformuiv = (Delegates.GetUniformuiv)GetExtensionDelegateStatic("glGetUniformuiv", typeof(Delegates.GetUniformuiv));
            Delegates.glGetUniformuiv((UInt32)program, (Int32)location, (UInt32*)@params);
        }
        internal static unsafe void Load_GetVertexAttribdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params)
        {
            Delegates.glGetVertexAttribdv = (Delegates.GetVertexAttribdv)GetExtensionDelegateStatic("glGetVertexAttribdv", typeof(Delegates.GetVertexAttribdv));
            Delegates.glGetVertexAttribdv((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribParameter)pname, (Double*)@params);
        }
        internal static unsafe void Load_GetVertexAttribfv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetVertexAttribfv = (Delegates.GetVertexAttribfv)GetExtensionDelegateStatic("glGetVertexAttribfv", typeof(Delegates.GetVertexAttribfv));
            Delegates.glGetVertexAttribfv((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribParameter)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetVertexAttribIiv = (Delegates.GetVertexAttribIiv)GetExtensionDelegateStatic("glGetVertexAttribIiv", typeof(Delegates.GetVertexAttribIiv));
            Delegates.glGetVertexAttribIiv((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetVertexAttribIuiv = (Delegates.GetVertexAttribIuiv)GetExtensionDelegateStatic("glGetVertexAttribIuiv", typeof(Delegates.GetVertexAttribIuiv));
            Delegates.glGetVertexAttribIuiv((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribParameter)pname, (UInt32*)@params);
        }
        internal static unsafe void Load_GetVertexAttribiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetVertexAttribiv = (Delegates.GetVertexAttribiv)GetExtensionDelegateStatic("glGetVertexAttribiv", typeof(Delegates.GetVertexAttribiv));
            Delegates.glGetVertexAttribiv((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetVertexAttribLdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params)
        {
            Delegates.glGetVertexAttribLdv = (Delegates.GetVertexAttribLdv)GetExtensionDelegateStatic("glGetVertexAttribLdv", typeof(Delegates.GetVertexAttribLdv));
            Delegates.glGetVertexAttribLdv((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribParameter)pname, (Double*)@params);
        }
        internal static unsafe void Load_GetVertexAttribLui64vARB(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] UInt64* @params)
        {
            Delegates.glGetVertexAttribLui64vARB = (Delegates.GetVertexAttribLui64vARB)GetExtensionDelegateStatic("glGetVertexAttribLui64vARB", typeof(Delegates.GetVertexAttribLui64vARB));
            Delegates.glGetVertexAttribLui64vARB((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribParameterArb)pname, (UInt64*)@params);
        }
        internal static void Load_GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer)
        {
            Delegates.glGetVertexAttribPointerv = (Delegates.GetVertexAttribPointerv)GetExtensionDelegateStatic("glGetVertexAttribPointerv", typeof(Delegates.GetVertexAttribPointerv));
            Delegates.glGetVertexAttribPointerv((UInt32)index, (OpenTK.Graphics.OpenGL4.VertexAttribPointerParameter)pname, (IntPtr)pointer);
        }
        internal static void Load_Hint(OpenTK.Graphics.OpenGL4.HintTarget target, OpenTK.Graphics.OpenGL4.HintMode mode)
        {
            Delegates.glHint = (Delegates.Hint)GetExtensionDelegateStatic("glHint", typeof(Delegates.Hint));
            Delegates.glHint((OpenTK.Graphics.OpenGL4.HintTarget)target, (OpenTK.Graphics.OpenGL4.HintMode)mode);
        }
        internal static void Load_Histogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, Int32 width, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink)
        {
            Delegates.glHistogram = (Delegates.Histogram)GetExtensionDelegateStatic("glHistogram", typeof(Delegates.Histogram));
            Delegates.glHistogram((OpenTK.Graphics.OpenGL4.HistogramTarget)target, (Int32)width, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (bool)sink);
        }
        internal static void Load_InvalidateBufferData(UInt32 buffer)
        {
            Delegates.glInvalidateBufferData = (Delegates.InvalidateBufferData)GetExtensionDelegateStatic("glInvalidateBufferData", typeof(Delegates.InvalidateBufferData));
            Delegates.glInvalidateBufferData((UInt32)buffer);
        }
        internal static void Load_InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length)
        {
            Delegates.glInvalidateBufferSubData = (Delegates.InvalidateBufferSubData)GetExtensionDelegateStatic("glInvalidateBufferSubData", typeof(Delegates.InvalidateBufferSubData));
            Delegates.glInvalidateBufferSubData((UInt32)buffer, (IntPtr)offset, (IntPtr)length);
        }
        internal static unsafe void Load_InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments)
        {
            Delegates.glInvalidateFramebuffer = (Delegates.InvalidateFramebuffer)GetExtensionDelegateStatic("glInvalidateFramebuffer", typeof(Delegates.InvalidateFramebuffer));
            Delegates.glInvalidateFramebuffer((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (Int32)numAttachments, (OpenTK.Graphics.OpenGL4.FramebufferAttachment*)attachments);
        }
        internal static unsafe void Load_InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glInvalidateSubFramebuffer = (Delegates.InvalidateSubFramebuffer)GetExtensionDelegateStatic("glInvalidateSubFramebuffer", typeof(Delegates.InvalidateSubFramebuffer));
            Delegates.glInvalidateSubFramebuffer((OpenTK.Graphics.OpenGL4.FramebufferTarget)target, (Int32)numAttachments, (OpenTK.Graphics.OpenGL4.FramebufferAttachment*)attachments, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static void Load_InvalidateTexImage(UInt32 texture, Int32 level)
        {
            Delegates.glInvalidateTexImage = (Delegates.InvalidateTexImage)GetExtensionDelegateStatic("glInvalidateTexImage", typeof(Delegates.InvalidateTexImage));
            Delegates.glInvalidateTexImage((UInt32)texture, (Int32)level);
        }
        internal static void Load_InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth)
        {
            Delegates.glInvalidateTexSubImage = (Delegates.InvalidateTexSubImage)GetExtensionDelegateStatic("glInvalidateTexSubImage", typeof(Delegates.InvalidateTexSubImage));
            Delegates.glInvalidateTexSubImage((UInt32)texture, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth);
        }
        internal static bool Load_IsBuffer(UInt32 buffer)
        {
            Delegates.glIsBuffer = (Delegates.IsBuffer)GetExtensionDelegateStatic("glIsBuffer", typeof(Delegates.IsBuffer));
            return Delegates.glIsBuffer((UInt32)buffer);
        }
        internal static bool Load_IsEnabled(OpenTK.Graphics.OpenGL4.EnableCap cap)
        {
            Delegates.glIsEnabled = (Delegates.IsEnabled)GetExtensionDelegateStatic("glIsEnabled", typeof(Delegates.IsEnabled));
            return Delegates.glIsEnabled((OpenTK.Graphics.OpenGL4.EnableCap)cap);
        }
        internal static bool Load_IsEnabledi(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index)
        {
            Delegates.glIsEnabledi = (Delegates.IsEnabledi)GetExtensionDelegateStatic("glIsEnabledi", typeof(Delegates.IsEnabledi));
            return Delegates.glIsEnabledi((OpenTK.Graphics.OpenGL4.IndexedEnableCap)target, (UInt32)index);
        }
        internal static bool Load_IsFramebuffer(UInt32 framebuffer)
        {
            Delegates.glIsFramebuffer = (Delegates.IsFramebuffer)GetExtensionDelegateStatic("glIsFramebuffer", typeof(Delegates.IsFramebuffer));
            return Delegates.glIsFramebuffer((UInt32)framebuffer);
        }
        internal static bool Load_IsImageHandleResidentARB(UInt64 handle)
        {
            Delegates.glIsImageHandleResidentARB = (Delegates.IsImageHandleResidentARB)GetExtensionDelegateStatic("glIsImageHandleResidentARB", typeof(Delegates.IsImageHandleResidentARB));
            return Delegates.glIsImageHandleResidentARB((UInt64)handle);
        }
        internal static bool Load_IsNamedStringARB(Int32 namelen, String name)
        {
            Delegates.glIsNamedStringARB = (Delegates.IsNamedStringARB)GetExtensionDelegateStatic("glIsNamedStringARB", typeof(Delegates.IsNamedStringARB));
            return Delegates.glIsNamedStringARB((Int32)namelen, (String)name);
        }
        internal static bool Load_IsProgram(UInt32 program)
        {
            Delegates.glIsProgram = (Delegates.IsProgram)GetExtensionDelegateStatic("glIsProgram", typeof(Delegates.IsProgram));
            return Delegates.glIsProgram((UInt32)program);
        }
        internal static bool Load_IsProgramPipeline(UInt32 pipeline)
        {
            Delegates.glIsProgramPipeline = (Delegates.IsProgramPipeline)GetExtensionDelegateStatic("glIsProgramPipeline", typeof(Delegates.IsProgramPipeline));
            return Delegates.glIsProgramPipeline((UInt32)pipeline);
        }
        internal static bool Load_IsQuery(UInt32 id)
        {
            Delegates.glIsQuery = (Delegates.IsQuery)GetExtensionDelegateStatic("glIsQuery", typeof(Delegates.IsQuery));
            return Delegates.glIsQuery((UInt32)id);
        }
        internal static bool Load_IsRenderbuffer(UInt32 renderbuffer)
        {
            Delegates.glIsRenderbuffer = (Delegates.IsRenderbuffer)GetExtensionDelegateStatic("glIsRenderbuffer", typeof(Delegates.IsRenderbuffer));
            return Delegates.glIsRenderbuffer((UInt32)renderbuffer);
        }
        internal static bool Load_IsSampler(UInt32 sampler)
        {
            Delegates.glIsSampler = (Delegates.IsSampler)GetExtensionDelegateStatic("glIsSampler", typeof(Delegates.IsSampler));
            return Delegates.glIsSampler((UInt32)sampler);
        }
        internal static bool Load_IsShader(UInt32 shader)
        {
            Delegates.glIsShader = (Delegates.IsShader)GetExtensionDelegateStatic("glIsShader", typeof(Delegates.IsShader));
            return Delegates.glIsShader((UInt32)shader);
        }
        internal static bool Load_IsSync(IntPtr sync)
        {
            Delegates.glIsSync = (Delegates.IsSync)GetExtensionDelegateStatic("glIsSync", typeof(Delegates.IsSync));
            return Delegates.glIsSync((IntPtr)sync);
        }
        internal static bool Load_IsTexture(UInt32 texture)
        {
            Delegates.glIsTexture = (Delegates.IsTexture)GetExtensionDelegateStatic("glIsTexture", typeof(Delegates.IsTexture));
            return Delegates.glIsTexture((UInt32)texture);
        }
        internal static bool Load_IsTextureHandleResidentARB(UInt64 handle)
        {
            Delegates.glIsTextureHandleResidentARB = (Delegates.IsTextureHandleResidentARB)GetExtensionDelegateStatic("glIsTextureHandleResidentARB", typeof(Delegates.IsTextureHandleResidentARB));
            return Delegates.glIsTextureHandleResidentARB((UInt64)handle);
        }
        internal static bool Load_IsTransformFeedback(UInt32 id)
        {
            Delegates.glIsTransformFeedback = (Delegates.IsTransformFeedback)GetExtensionDelegateStatic("glIsTransformFeedback", typeof(Delegates.IsTransformFeedback));
            return Delegates.glIsTransformFeedback((UInt32)id);
        }
        internal static bool Load_IsVertexArray(UInt32 array)
        {
            Delegates.glIsVertexArray = (Delegates.IsVertexArray)GetExtensionDelegateStatic("glIsVertexArray", typeof(Delegates.IsVertexArray));
            return Delegates.glIsVertexArray((UInt32)array);
        }
        internal static void Load_LineWidth(Single width)
        {
            Delegates.glLineWidth = (Delegates.LineWidth)GetExtensionDelegateStatic("glLineWidth", typeof(Delegates.LineWidth));
            Delegates.glLineWidth((Single)width);
        }
        internal static void Load_LinkProgram(UInt32 program)
        {
            Delegates.glLinkProgram = (Delegates.LinkProgram)GetExtensionDelegateStatic("glLinkProgram", typeof(Delegates.LinkProgram));
            Delegates.glLinkProgram((UInt32)program);
        }
        internal static void Load_LogicOp(OpenTK.Graphics.OpenGL4.LogicOp opcode)
        {
            Delegates.glLogicOp = (Delegates.LogicOp)GetExtensionDelegateStatic("glLogicOp", typeof(Delegates.LogicOp));
            Delegates.glLogicOp((OpenTK.Graphics.OpenGL4.LogicOp)opcode);
        }
        internal static void Load_MakeImageHandleNonResidentARB(UInt64 handle)
        {
            Delegates.glMakeImageHandleNonResidentARB = (Delegates.MakeImageHandleNonResidentARB)GetExtensionDelegateStatic("glMakeImageHandleNonResidentARB", typeof(Delegates.MakeImageHandleNonResidentARB));
            Delegates.glMakeImageHandleNonResidentARB((UInt64)handle);
        }
        internal static void Load_MakeImageHandleResidentARB(UInt64 handle, OpenTK.Graphics.OpenGL4.All access)
        {
            Delegates.glMakeImageHandleResidentARB = (Delegates.MakeImageHandleResidentARB)GetExtensionDelegateStatic("glMakeImageHandleResidentARB", typeof(Delegates.MakeImageHandleResidentARB));
            Delegates.glMakeImageHandleResidentARB((UInt64)handle, (OpenTK.Graphics.OpenGL4.All)access);
        }
        internal static void Load_MakeTextureHandleNonResidentARB(UInt64 handle)
        {
            Delegates.glMakeTextureHandleNonResidentARB = (Delegates.MakeTextureHandleNonResidentARB)GetExtensionDelegateStatic("glMakeTextureHandleNonResidentARB", typeof(Delegates.MakeTextureHandleNonResidentARB));
            Delegates.glMakeTextureHandleNonResidentARB((UInt64)handle);
        }
        internal static void Load_MakeTextureHandleResidentARB(UInt64 handle)
        {
            Delegates.glMakeTextureHandleResidentARB = (Delegates.MakeTextureHandleResidentARB)GetExtensionDelegateStatic("glMakeTextureHandleResidentARB", typeof(Delegates.MakeTextureHandleResidentARB));
            Delegates.glMakeTextureHandleResidentARB((UInt64)handle);
        }
        internal static IntPtr Load_MapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferAccess access)
        {
            Delegates.glMapBuffer = (Delegates.MapBuffer)GetExtensionDelegateStatic("glMapBuffer", typeof(Delegates.MapBuffer));
            return Delegates.glMapBuffer((OpenTK.Graphics.OpenGL4.BufferTarget)target, (OpenTK.Graphics.OpenGL4.BufferAccess)access);
        }
        internal static IntPtr Load_MapBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.OpenGL4.BufferAccessMask access)
        {
            Delegates.glMapBufferRange = (Delegates.MapBufferRange)GetExtensionDelegateStatic("glMapBufferRange", typeof(Delegates.MapBufferRange));
            return Delegates.glMapBufferRange((OpenTK.Graphics.OpenGL4.BufferTarget)target, (IntPtr)offset, (IntPtr)length, (OpenTK.Graphics.OpenGL4.BufferAccessMask)access);
        }
        internal static void Load_MemoryBarrier(OpenTK.Graphics.OpenGL4.MemoryBarrierFlags barriers)
        {
            Delegates.glMemoryBarrier = (Delegates.MemoryBarrier)GetExtensionDelegateStatic("glMemoryBarrier", typeof(Delegates.MemoryBarrier));
            Delegates.glMemoryBarrier((OpenTK.Graphics.OpenGL4.MemoryBarrierFlags)barriers);
        }
        internal static void Load_Minmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink)
        {
            Delegates.glMinmax = (Delegates.Minmax)GetExtensionDelegateStatic("glMinmax", typeof(Delegates.Minmax));
            Delegates.glMinmax((OpenTK.Graphics.OpenGL4.MinmaxTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (bool)sink);
        }
        internal static void Load_MinSampleShading(Single value)
        {
            Delegates.glMinSampleShading = (Delegates.MinSampleShading)GetExtensionDelegateStatic("glMinSampleShading", typeof(Delegates.MinSampleShading));
            Delegates.glMinSampleShading((Single)value);
        }
        internal static void Load_MinSampleShadingARB(Single value)
        {
            Delegates.glMinSampleShadingARB = (Delegates.MinSampleShadingARB)GetExtensionDelegateStatic("glMinSampleShadingARB", typeof(Delegates.MinSampleShadingARB));
            Delegates.glMinSampleShadingARB((Single)value);
        }
        internal static unsafe void Load_MultiDrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* first, Int32* count, Int32 drawcount)
        {
            Delegates.glMultiDrawArrays = (Delegates.MultiDrawArrays)GetExtensionDelegateStatic("glMultiDrawArrays", typeof(Delegates.MultiDrawArrays));
            Delegates.glMultiDrawArrays((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32*)first, (Int32*)count, (Int32)drawcount);
        }
        internal static void Load_MultiDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride)
        {
            Delegates.glMultiDrawArraysIndirect = (Delegates.MultiDrawArraysIndirect)GetExtensionDelegateStatic("glMultiDrawArraysIndirect", typeof(Delegates.MultiDrawArraysIndirect));
            Delegates.glMultiDrawArraysIndirect((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (IntPtr)indirect, (Int32)drawcount, (Int32)stride);
        }
        internal static void Load_MultiDrawArraysIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
        {
            Delegates.glMultiDrawArraysIndirectCountARB = (Delegates.MultiDrawArraysIndirectCountARB)GetExtensionDelegateStatic("glMultiDrawArraysIndirectCountARB", typeof(Delegates.MultiDrawArraysIndirectCountARB));
            Delegates.glMultiDrawArraysIndirectCountARB((OpenTK.Graphics.OpenGL4.All)mode, (IntPtr)indirect, (IntPtr)drawcount, (Int32)maxdrawcount, (Int32)stride);
        }
        internal static unsafe void Load_MultiDrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount)
        {
            Delegates.glMultiDrawElements = (Delegates.MultiDrawElements)GetExtensionDelegateStatic("glMultiDrawElements", typeof(Delegates.MultiDrawElements));
            Delegates.glMultiDrawElements((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)drawcount);
        }
        internal static unsafe void Load_MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32* basevertex)
        {
            Delegates.glMultiDrawElementsBaseVertex = (Delegates.MultiDrawElementsBaseVertex)GetExtensionDelegateStatic("glMultiDrawElementsBaseVertex", typeof(Delegates.MultiDrawElementsBaseVertex));
            Delegates.glMultiDrawElementsBaseVertex((OpenTK.Graphics.OpenGL4.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.OpenGL4.DrawElementsType)type, (IntPtr)indices, (Int32)drawcount, (Int32*)basevertex);
        }
        internal static void Load_MultiDrawElementsIndirect(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, Int32 drawcount, Int32 stride)
        {
            Delegates.glMultiDrawElementsIndirect = (Delegates.MultiDrawElementsIndirect)GetExtensionDelegateStatic("glMultiDrawElementsIndirect", typeof(Delegates.MultiDrawElementsIndirect));
            Delegates.glMultiDrawElementsIndirect((OpenTK.Graphics.OpenGL4.All)mode, (OpenTK.Graphics.OpenGL4.All)type, (IntPtr)indirect, (Int32)drawcount, (Int32)stride);
        }
        internal static void Load_MultiDrawElementsIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
        {
            Delegates.glMultiDrawElementsIndirectCountARB = (Delegates.MultiDrawElementsIndirectCountARB)GetExtensionDelegateStatic("glMultiDrawElementsIndirectCountARB", typeof(Delegates.MultiDrawElementsIndirectCountARB));
            Delegates.glMultiDrawElementsIndirectCountARB((OpenTK.Graphics.OpenGL4.All)mode, (OpenTK.Graphics.OpenGL4.All)type, (IntPtr)indirect, (IntPtr)drawcount, (Int32)maxdrawcount, (Int32)stride);
        }
        internal static void Load_MultiTexCoordP1ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glMultiTexCoordP1ui = (Delegates.MultiTexCoordP1ui)GetExtensionDelegateStatic("glMultiTexCoordP1ui", typeof(Delegates.MultiTexCoordP1ui));
            Delegates.glMultiTexCoordP1ui((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_MultiTexCoordP1uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glMultiTexCoordP1uiv = (Delegates.MultiTexCoordP1uiv)GetExtensionDelegateStatic("glMultiTexCoordP1uiv", typeof(Delegates.MultiTexCoordP1uiv));
            Delegates.glMultiTexCoordP1uiv((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_MultiTexCoordP2ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glMultiTexCoordP2ui = (Delegates.MultiTexCoordP2ui)GetExtensionDelegateStatic("glMultiTexCoordP2ui", typeof(Delegates.MultiTexCoordP2ui));
            Delegates.glMultiTexCoordP2ui((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_MultiTexCoordP2uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glMultiTexCoordP2uiv = (Delegates.MultiTexCoordP2uiv)GetExtensionDelegateStatic("glMultiTexCoordP2uiv", typeof(Delegates.MultiTexCoordP2uiv));
            Delegates.glMultiTexCoordP2uiv((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_MultiTexCoordP3ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glMultiTexCoordP3ui = (Delegates.MultiTexCoordP3ui)GetExtensionDelegateStatic("glMultiTexCoordP3ui", typeof(Delegates.MultiTexCoordP3ui));
            Delegates.glMultiTexCoordP3ui((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_MultiTexCoordP3uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glMultiTexCoordP3uiv = (Delegates.MultiTexCoordP3uiv)GetExtensionDelegateStatic("glMultiTexCoordP3uiv", typeof(Delegates.MultiTexCoordP3uiv));
            Delegates.glMultiTexCoordP3uiv((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_MultiTexCoordP4ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glMultiTexCoordP4ui = (Delegates.MultiTexCoordP4ui)GetExtensionDelegateStatic("glMultiTexCoordP4ui", typeof(Delegates.MultiTexCoordP4ui));
            Delegates.glMultiTexCoordP4ui((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_MultiTexCoordP4uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glMultiTexCoordP4uiv = (Delegates.MultiTexCoordP4uiv)GetExtensionDelegateStatic("glMultiTexCoordP4uiv", typeof(Delegates.MultiTexCoordP4uiv));
            Delegates.glMultiTexCoordP4uiv((OpenTK.Graphics.OpenGL4.TextureUnit)texture, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_NamedStringARB(OpenTK.Graphics.OpenGL4.All type, Int32 namelen, String name, Int32 stringlen, String @string)
        {
            Delegates.glNamedStringARB = (Delegates.NamedStringARB)GetExtensionDelegateStatic("glNamedStringARB", typeof(Delegates.NamedStringARB));
            Delegates.glNamedStringARB((OpenTK.Graphics.OpenGL4.All)type, (Int32)namelen, (String)name, (Int32)stringlen, (String)@string);
        }
        internal static void Load_NormalP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glNormalP3ui = (Delegates.NormalP3ui)GetExtensionDelegateStatic("glNormalP3ui", typeof(Delegates.NormalP3ui));
            Delegates.glNormalP3ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_NormalP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glNormalP3uiv = (Delegates.NormalP3uiv)GetExtensionDelegateStatic("glNormalP3uiv", typeof(Delegates.NormalP3uiv));
            Delegates.glNormalP3uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_ObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label)
        {
            Delegates.glObjectLabel = (Delegates.ObjectLabel)GetExtensionDelegateStatic("glObjectLabel", typeof(Delegates.ObjectLabel));
            Delegates.glObjectLabel((OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier)identifier, (UInt32)name, (Int32)length, (String)label);
        }
        internal static void Load_ObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 length, String label)
        {
            Delegates.glObjectLabelKHR = (Delegates.ObjectLabelKHR)GetExtensionDelegateStatic("glObjectLabelKHR", typeof(Delegates.ObjectLabelKHR));
            Delegates.glObjectLabelKHR((OpenTK.Graphics.OpenGL4.All)identifier, (UInt32)name, (Int32)length, (String)label);
        }
        internal static void Load_ObjectPtrLabel(IntPtr ptr, Int32 length, String label)
        {
            Delegates.glObjectPtrLabel = (Delegates.ObjectPtrLabel)GetExtensionDelegateStatic("glObjectPtrLabel", typeof(Delegates.ObjectPtrLabel));
            Delegates.glObjectPtrLabel((IntPtr)ptr, (Int32)length, (String)label);
        }
        internal static void Load_ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label)
        {
            Delegates.glObjectPtrLabelKHR = (Delegates.ObjectPtrLabelKHR)GetExtensionDelegateStatic("glObjectPtrLabelKHR", typeof(Delegates.ObjectPtrLabelKHR));
            Delegates.glObjectPtrLabelKHR((IntPtr)ptr, (Int32)length, (String)label);
        }
        internal static unsafe void Load_PatchParameterfv(OpenTK.Graphics.OpenGL4.PatchParameterFloat pname, Single* values)
        {
            Delegates.glPatchParameterfv = (Delegates.PatchParameterfv)GetExtensionDelegateStatic("glPatchParameterfv", typeof(Delegates.PatchParameterfv));
            Delegates.glPatchParameterfv((OpenTK.Graphics.OpenGL4.PatchParameterFloat)pname, (Single*)values);
        }
        internal static void Load_PatchParameteri(OpenTK.Graphics.OpenGL4.PatchParameterInt pname, Int32 value)
        {
            Delegates.glPatchParameteri = (Delegates.PatchParameteri)GetExtensionDelegateStatic("glPatchParameteri", typeof(Delegates.PatchParameteri));
            Delegates.glPatchParameteri((OpenTK.Graphics.OpenGL4.PatchParameterInt)pname, (Int32)value);
        }
        internal static void Load_PauseTransformFeedback()
        {
            Delegates.glPauseTransformFeedback = (Delegates.PauseTransformFeedback)GetExtensionDelegateStatic("glPauseTransformFeedback", typeof(Delegates.PauseTransformFeedback));
            Delegates.glPauseTransformFeedback();
        }
        internal static void Load_PixelStoref(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Single param)
        {
            Delegates.glPixelStoref = (Delegates.PixelStoref)GetExtensionDelegateStatic("glPixelStoref", typeof(Delegates.PixelStoref));
            Delegates.glPixelStoref((OpenTK.Graphics.OpenGL4.PixelStoreParameter)pname, (Single)param);
        }
        internal static void Load_PixelStorei(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Int32 param)
        {
            Delegates.glPixelStorei = (Delegates.PixelStorei)GetExtensionDelegateStatic("glPixelStorei", typeof(Delegates.PixelStorei));
            Delegates.glPixelStorei((OpenTK.Graphics.OpenGL4.PixelStoreParameter)pname, (Int32)param);
        }
        internal static void Load_PointParameterf(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single param)
        {
            Delegates.glPointParameterf = (Delegates.PointParameterf)GetExtensionDelegateStatic("glPointParameterf", typeof(Delegates.PointParameterf));
            Delegates.glPointParameterf((OpenTK.Graphics.OpenGL4.PointParameterName)pname, (Single)param);
        }
        internal static unsafe void Load_PointParameterfv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single* @params)
        {
            Delegates.glPointParameterfv = (Delegates.PointParameterfv)GetExtensionDelegateStatic("glPointParameterfv", typeof(Delegates.PointParameterfv));
            Delegates.glPointParameterfv((OpenTK.Graphics.OpenGL4.PointParameterName)pname, (Single*)@params);
        }
        internal static void Load_PointParameteri(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32 param)
        {
            Delegates.glPointParameteri = (Delegates.PointParameteri)GetExtensionDelegateStatic("glPointParameteri", typeof(Delegates.PointParameteri));
            Delegates.glPointParameteri((OpenTK.Graphics.OpenGL4.PointParameterName)pname, (Int32)param);
        }
        internal static unsafe void Load_PointParameteriv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32* @params)
        {
            Delegates.glPointParameteriv = (Delegates.PointParameteriv)GetExtensionDelegateStatic("glPointParameteriv", typeof(Delegates.PointParameteriv));
            Delegates.glPointParameteriv((OpenTK.Graphics.OpenGL4.PointParameterName)pname, (Int32*)@params);
        }
        internal static void Load_PointSize(Single size)
        {
            Delegates.glPointSize = (Delegates.PointSize)GetExtensionDelegateStatic("glPointSize", typeof(Delegates.PointSize));
            Delegates.glPointSize((Single)size);
        }
        internal static void Load_PolygonMode(OpenTK.Graphics.OpenGL4.MaterialFace face, OpenTK.Graphics.OpenGL4.PolygonMode mode)
        {
            Delegates.glPolygonMode = (Delegates.PolygonMode)GetExtensionDelegateStatic("glPolygonMode", typeof(Delegates.PolygonMode));
            Delegates.glPolygonMode((OpenTK.Graphics.OpenGL4.MaterialFace)face, (OpenTK.Graphics.OpenGL4.PolygonMode)mode);
        }
        internal static void Load_PolygonOffset(Single factor, Single units)
        {
            Delegates.glPolygonOffset = (Delegates.PolygonOffset)GetExtensionDelegateStatic("glPolygonOffset", typeof(Delegates.PolygonOffset));
            Delegates.glPolygonOffset((Single)factor, (Single)units);
        }
        internal static void Load_PopDebugGroup()
        {
            Delegates.glPopDebugGroup = (Delegates.PopDebugGroup)GetExtensionDelegateStatic("glPopDebugGroup", typeof(Delegates.PopDebugGroup));
            Delegates.glPopDebugGroup();
        }
        internal static void Load_PopDebugGroupKHR()
        {
            Delegates.glPopDebugGroupKHR = (Delegates.PopDebugGroupKHR)GetExtensionDelegateStatic("glPopDebugGroupKHR", typeof(Delegates.PopDebugGroupKHR));
            Delegates.glPopDebugGroupKHR();
        }
        internal static void Load_PrimitiveRestartIndex(UInt32 index)
        {
            Delegates.glPrimitiveRestartIndex = (Delegates.PrimitiveRestartIndex)GetExtensionDelegateStatic("glPrimitiveRestartIndex", typeof(Delegates.PrimitiveRestartIndex));
            Delegates.glPrimitiveRestartIndex((UInt32)index);
        }
        internal static void Load_ProgramBinary(UInt32 program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, IntPtr binary, Int32 length)
        {
            Delegates.glProgramBinary = (Delegates.ProgramBinary)GetExtensionDelegateStatic("glProgramBinary", typeof(Delegates.ProgramBinary));
            Delegates.glProgramBinary((UInt32)program, (OpenTK.Graphics.OpenGL4.BinaryFormat)binaryFormat, (IntPtr)binary, (Int32)length);
        }
        internal static void Load_ProgramParameteri(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramParameterName pname, Int32 value)
        {
            Delegates.glProgramParameteri = (Delegates.ProgramParameteri)GetExtensionDelegateStatic("glProgramParameteri", typeof(Delegates.ProgramParameteri));
            Delegates.glProgramParameteri((UInt32)program, (OpenTK.Graphics.OpenGL4.ProgramParameterName)pname, (Int32)value);
        }
        internal static void Load_ProgramUniform1d(UInt32 program, Int32 location, Double v0)
        {
            Delegates.glProgramUniform1d = (Delegates.ProgramUniform1d)GetExtensionDelegateStatic("glProgramUniform1d", typeof(Delegates.ProgramUniform1d));
            Delegates.glProgramUniform1d((UInt32)program, (Int32)location, (Double)v0);
        }
        internal static unsafe void Load_ProgramUniform1dv(UInt32 program, Int32 location, Int32 count, Double* value)
        {
            Delegates.glProgramUniform1dv = (Delegates.ProgramUniform1dv)GetExtensionDelegateStatic("glProgramUniform1dv", typeof(Delegates.ProgramUniform1dv));
            Delegates.glProgramUniform1dv((UInt32)program, (Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_ProgramUniform1f(UInt32 program, Int32 location, Single v0)
        {
            Delegates.glProgramUniform1f = (Delegates.ProgramUniform1f)GetExtensionDelegateStatic("glProgramUniform1f", typeof(Delegates.ProgramUniform1f));
            Delegates.glProgramUniform1f((UInt32)program, (Int32)location, (Single)v0);
        }
        internal static unsafe void Load_ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform1fv = (Delegates.ProgramUniform1fv)GetExtensionDelegateStatic("glProgramUniform1fv", typeof(Delegates.ProgramUniform1fv));
            Delegates.glProgramUniform1fv((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform1i(UInt32 program, Int32 location, Int32 v0)
        {
            Delegates.glProgramUniform1i = (Delegates.ProgramUniform1i)GetExtensionDelegateStatic("glProgramUniform1i", typeof(Delegates.ProgramUniform1i));
            Delegates.glProgramUniform1i((UInt32)program, (Int32)location, (Int32)v0);
        }
        internal static unsafe void Load_ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform1iv = (Delegates.ProgramUniform1iv)GetExtensionDelegateStatic("glProgramUniform1iv", typeof(Delegates.ProgramUniform1iv));
            Delegates.glProgramUniform1iv((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0)
        {
            Delegates.glProgramUniform1ui = (Delegates.ProgramUniform1ui)GetExtensionDelegateStatic("glProgramUniform1ui", typeof(Delegates.ProgramUniform1ui));
            Delegates.glProgramUniform1ui((UInt32)program, (Int32)location, (UInt32)v0);
        }
        internal static unsafe void Load_ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform1uiv = (Delegates.ProgramUniform1uiv)GetExtensionDelegateStatic("glProgramUniform1uiv", typeof(Delegates.ProgramUniform1uiv));
            Delegates.glProgramUniform1uiv((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_ProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1)
        {
            Delegates.glProgramUniform2d = (Delegates.ProgramUniform2d)GetExtensionDelegateStatic("glProgramUniform2d", typeof(Delegates.ProgramUniform2d));
            Delegates.glProgramUniform2d((UInt32)program, (Int32)location, (Double)v0, (Double)v1);
        }
        internal static unsafe void Load_ProgramUniform2dv(UInt32 program, Int32 location, Int32 count, Double* value)
        {
            Delegates.glProgramUniform2dv = (Delegates.ProgramUniform2dv)GetExtensionDelegateStatic("glProgramUniform2dv", typeof(Delegates.ProgramUniform2dv));
            Delegates.glProgramUniform2dv((UInt32)program, (Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1)
        {
            Delegates.glProgramUniform2f = (Delegates.ProgramUniform2f)GetExtensionDelegateStatic("glProgramUniform2f", typeof(Delegates.ProgramUniform2f));
            Delegates.glProgramUniform2f((UInt32)program, (Int32)location, (Single)v0, (Single)v1);
        }
        internal static unsafe void Load_ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform2fv = (Delegates.ProgramUniform2fv)GetExtensionDelegateStatic("glProgramUniform2fv", typeof(Delegates.ProgramUniform2fv));
            Delegates.glProgramUniform2fv((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1)
        {
            Delegates.glProgramUniform2i = (Delegates.ProgramUniform2i)GetExtensionDelegateStatic("glProgramUniform2i", typeof(Delegates.ProgramUniform2i));
            Delegates.glProgramUniform2i((UInt32)program, (Int32)location, (Int32)v0, (Int32)v1);
        }
        internal static unsafe void Load_ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform2iv = (Delegates.ProgramUniform2iv)GetExtensionDelegateStatic("glProgramUniform2iv", typeof(Delegates.ProgramUniform2iv));
            Delegates.glProgramUniform2iv((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1)
        {
            Delegates.glProgramUniform2ui = (Delegates.ProgramUniform2ui)GetExtensionDelegateStatic("glProgramUniform2ui", typeof(Delegates.ProgramUniform2ui));
            Delegates.glProgramUniform2ui((UInt32)program, (Int32)location, (UInt32)v0, (UInt32)v1);
        }
        internal static unsafe void Load_ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform2uiv = (Delegates.ProgramUniform2uiv)GetExtensionDelegateStatic("glProgramUniform2uiv", typeof(Delegates.ProgramUniform2uiv));
            Delegates.glProgramUniform2uiv((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_ProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2)
        {
            Delegates.glProgramUniform3d = (Delegates.ProgramUniform3d)GetExtensionDelegateStatic("glProgramUniform3d", typeof(Delegates.ProgramUniform3d));
            Delegates.glProgramUniform3d((UInt32)program, (Int32)location, (Double)v0, (Double)v1, (Double)v2);
        }
        internal static unsafe void Load_ProgramUniform3dv(UInt32 program, Int32 location, Int32 count, Double* value)
        {
            Delegates.glProgramUniform3dv = (Delegates.ProgramUniform3dv)GetExtensionDelegateStatic("glProgramUniform3dv", typeof(Delegates.ProgramUniform3dv));
            Delegates.glProgramUniform3dv((UInt32)program, (Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2)
        {
            Delegates.glProgramUniform3f = (Delegates.ProgramUniform3f)GetExtensionDelegateStatic("glProgramUniform3f", typeof(Delegates.ProgramUniform3f));
            Delegates.glProgramUniform3f((UInt32)program, (Int32)location, (Single)v0, (Single)v1, (Single)v2);
        }
        internal static unsafe void Load_ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform3fv = (Delegates.ProgramUniform3fv)GetExtensionDelegateStatic("glProgramUniform3fv", typeof(Delegates.ProgramUniform3fv));
            Delegates.glProgramUniform3fv((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
        {
            Delegates.glProgramUniform3i = (Delegates.ProgramUniform3i)GetExtensionDelegateStatic("glProgramUniform3i", typeof(Delegates.ProgramUniform3i));
            Delegates.glProgramUniform3i((UInt32)program, (Int32)location, (Int32)v0, (Int32)v1, (Int32)v2);
        }
        internal static unsafe void Load_ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform3iv = (Delegates.ProgramUniform3iv)GetExtensionDelegateStatic("glProgramUniform3iv", typeof(Delegates.ProgramUniform3iv));
            Delegates.glProgramUniform3iv((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
        {
            Delegates.glProgramUniform3ui = (Delegates.ProgramUniform3ui)GetExtensionDelegateStatic("glProgramUniform3ui", typeof(Delegates.ProgramUniform3ui));
            Delegates.glProgramUniform3ui((UInt32)program, (Int32)location, (UInt32)v0, (UInt32)v1, (UInt32)v2);
        }
        internal static unsafe void Load_ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform3uiv = (Delegates.ProgramUniform3uiv)GetExtensionDelegateStatic("glProgramUniform3uiv", typeof(Delegates.ProgramUniform3uiv));
            Delegates.glProgramUniform3uiv((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_ProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3)
        {
            Delegates.glProgramUniform4d = (Delegates.ProgramUniform4d)GetExtensionDelegateStatic("glProgramUniform4d", typeof(Delegates.ProgramUniform4d));
            Delegates.glProgramUniform4d((UInt32)program, (Int32)location, (Double)v0, (Double)v1, (Double)v2, (Double)v3);
        }
        internal static unsafe void Load_ProgramUniform4dv(UInt32 program, Int32 location, Int32 count, Double* value)
        {
            Delegates.glProgramUniform4dv = (Delegates.ProgramUniform4dv)GetExtensionDelegateStatic("glProgramUniform4dv", typeof(Delegates.ProgramUniform4dv));
            Delegates.glProgramUniform4dv((UInt32)program, (Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3)
        {
            Delegates.glProgramUniform4f = (Delegates.ProgramUniform4f)GetExtensionDelegateStatic("glProgramUniform4f", typeof(Delegates.ProgramUniform4f));
            Delegates.glProgramUniform4f((UInt32)program, (Int32)location, (Single)v0, (Single)v1, (Single)v2, (Single)v3);
        }
        internal static unsafe void Load_ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform4fv = (Delegates.ProgramUniform4fv)GetExtensionDelegateStatic("glProgramUniform4fv", typeof(Delegates.ProgramUniform4fv));
            Delegates.glProgramUniform4fv((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
        {
            Delegates.glProgramUniform4i = (Delegates.ProgramUniform4i)GetExtensionDelegateStatic("glProgramUniform4i", typeof(Delegates.ProgramUniform4i));
            Delegates.glProgramUniform4i((UInt32)program, (Int32)location, (Int32)v0, (Int32)v1, (Int32)v2, (Int32)v3);
        }
        internal static unsafe void Load_ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform4iv = (Delegates.ProgramUniform4iv)GetExtensionDelegateStatic("glProgramUniform4iv", typeof(Delegates.ProgramUniform4iv));
            Delegates.glProgramUniform4iv((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
        {
            Delegates.glProgramUniform4ui = (Delegates.ProgramUniform4ui)GetExtensionDelegateStatic("glProgramUniform4ui", typeof(Delegates.ProgramUniform4ui));
            Delegates.glProgramUniform4ui((UInt32)program, (Int32)location, (UInt32)v0, (UInt32)v1, (UInt32)v2, (UInt32)v3);
        }
        internal static unsafe void Load_ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform4uiv = (Delegates.ProgramUniform4uiv)GetExtensionDelegateStatic("glProgramUniform4uiv", typeof(Delegates.ProgramUniform4uiv));
            Delegates.glProgramUniform4uiv((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_ProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value)
        {
            Delegates.glProgramUniformHandleui64ARB = (Delegates.ProgramUniformHandleui64ARB)GetExtensionDelegateStatic("glProgramUniformHandleui64ARB", typeof(Delegates.ProgramUniformHandleui64ARB));
            Delegates.glProgramUniformHandleui64ARB((UInt32)program, (Int32)location, (UInt64)value);
        }
        internal static unsafe void Load_ProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values)
        {
            Delegates.glProgramUniformHandleui64vARB = (Delegates.ProgramUniformHandleui64vARB)GetExtensionDelegateStatic("glProgramUniformHandleui64vARB", typeof(Delegates.ProgramUniformHandleui64vARB));
            Delegates.glProgramUniformHandleui64vARB((UInt32)program, (Int32)location, (Int32)count, (UInt64*)values);
        }
        internal static unsafe void Load_ProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix2dv = (Delegates.ProgramUniformMatrix2dv)GetExtensionDelegateStatic("glProgramUniformMatrix2dv", typeof(Delegates.ProgramUniformMatrix2dv));
            Delegates.glProgramUniformMatrix2dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix2fv = (Delegates.ProgramUniformMatrix2fv)GetExtensionDelegateStatic("glProgramUniformMatrix2fv", typeof(Delegates.ProgramUniformMatrix2fv));
            Delegates.glProgramUniformMatrix2fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix2x3dv = (Delegates.ProgramUniformMatrix2x3dv)GetExtensionDelegateStatic("glProgramUniformMatrix2x3dv", typeof(Delegates.ProgramUniformMatrix2x3dv));
            Delegates.glProgramUniformMatrix2x3dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix2x3fv = (Delegates.ProgramUniformMatrix2x3fv)GetExtensionDelegateStatic("glProgramUniformMatrix2x3fv", typeof(Delegates.ProgramUniformMatrix2x3fv));
            Delegates.glProgramUniformMatrix2x3fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix2x4dv = (Delegates.ProgramUniformMatrix2x4dv)GetExtensionDelegateStatic("glProgramUniformMatrix2x4dv", typeof(Delegates.ProgramUniformMatrix2x4dv));
            Delegates.glProgramUniformMatrix2x4dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix2x4fv = (Delegates.ProgramUniformMatrix2x4fv)GetExtensionDelegateStatic("glProgramUniformMatrix2x4fv", typeof(Delegates.ProgramUniformMatrix2x4fv));
            Delegates.glProgramUniformMatrix2x4fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix3dv = (Delegates.ProgramUniformMatrix3dv)GetExtensionDelegateStatic("glProgramUniformMatrix3dv", typeof(Delegates.ProgramUniformMatrix3dv));
            Delegates.glProgramUniformMatrix3dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix3fv = (Delegates.ProgramUniformMatrix3fv)GetExtensionDelegateStatic("glProgramUniformMatrix3fv", typeof(Delegates.ProgramUniformMatrix3fv));
            Delegates.glProgramUniformMatrix3fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix3x2dv = (Delegates.ProgramUniformMatrix3x2dv)GetExtensionDelegateStatic("glProgramUniformMatrix3x2dv", typeof(Delegates.ProgramUniformMatrix3x2dv));
            Delegates.glProgramUniformMatrix3x2dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix3x2fv = (Delegates.ProgramUniformMatrix3x2fv)GetExtensionDelegateStatic("glProgramUniformMatrix3x2fv", typeof(Delegates.ProgramUniformMatrix3x2fv));
            Delegates.glProgramUniformMatrix3x2fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix3x4dv = (Delegates.ProgramUniformMatrix3x4dv)GetExtensionDelegateStatic("glProgramUniformMatrix3x4dv", typeof(Delegates.ProgramUniformMatrix3x4dv));
            Delegates.glProgramUniformMatrix3x4dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix3x4fv = (Delegates.ProgramUniformMatrix3x4fv)GetExtensionDelegateStatic("glProgramUniformMatrix3x4fv", typeof(Delegates.ProgramUniformMatrix3x4fv));
            Delegates.glProgramUniformMatrix3x4fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix4dv = (Delegates.ProgramUniformMatrix4dv)GetExtensionDelegateStatic("glProgramUniformMatrix4dv", typeof(Delegates.ProgramUniformMatrix4dv));
            Delegates.glProgramUniformMatrix4dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix4fv = (Delegates.ProgramUniformMatrix4fv)GetExtensionDelegateStatic("glProgramUniformMatrix4fv", typeof(Delegates.ProgramUniformMatrix4fv));
            Delegates.glProgramUniformMatrix4fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix4x2dv = (Delegates.ProgramUniformMatrix4x2dv)GetExtensionDelegateStatic("glProgramUniformMatrix4x2dv", typeof(Delegates.ProgramUniformMatrix4x2dv));
            Delegates.glProgramUniformMatrix4x2dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix4x2fv = (Delegates.ProgramUniformMatrix4x2fv)GetExtensionDelegateStatic("glProgramUniformMatrix4x2fv", typeof(Delegates.ProgramUniformMatrix4x2fv));
            Delegates.glProgramUniformMatrix4x2fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glProgramUniformMatrix4x3dv = (Delegates.ProgramUniformMatrix4x3dv)GetExtensionDelegateStatic("glProgramUniformMatrix4x3dv", typeof(Delegates.ProgramUniformMatrix4x3dv));
            Delegates.glProgramUniformMatrix4x3dv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix4x3fv = (Delegates.ProgramUniformMatrix4x3fv)GetExtensionDelegateStatic("glProgramUniformMatrix4x3fv", typeof(Delegates.ProgramUniformMatrix4x3fv));
            Delegates.glProgramUniformMatrix4x3fv((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static void Load_ProvokingVertex(OpenTK.Graphics.OpenGL4.ProvokingVertexMode mode)
        {
            Delegates.glProvokingVertex = (Delegates.ProvokingVertex)GetExtensionDelegateStatic("glProvokingVertex", typeof(Delegates.ProvokingVertex));
            Delegates.glProvokingVertex((OpenTK.Graphics.OpenGL4.ProvokingVertexMode)mode);
        }
        internal static void Load_PushDebugGroup(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, UInt32 id, Int32 length, String message)
        {
            Delegates.glPushDebugGroup = (Delegates.PushDebugGroup)GetExtensionDelegateStatic("glPushDebugGroup", typeof(Delegates.PushDebugGroup));
            Delegates.glPushDebugGroup((OpenTK.Graphics.OpenGL4.DebugSourceExternal)source, (UInt32)id, (Int32)length, (String)message);
        }
        internal static void Load_PushDebugGroupKHR(OpenTK.Graphics.OpenGL4.All source, UInt32 id, Int32 length, String message)
        {
            Delegates.glPushDebugGroupKHR = (Delegates.PushDebugGroupKHR)GetExtensionDelegateStatic("glPushDebugGroupKHR", typeof(Delegates.PushDebugGroupKHR));
            Delegates.glPushDebugGroupKHR((OpenTK.Graphics.OpenGL4.All)source, (UInt32)id, (Int32)length, (String)message);
        }
        internal static void Load_QueryCounter(UInt32 id, OpenTK.Graphics.OpenGL4.QueryCounterTarget target)
        {
            Delegates.glQueryCounter = (Delegates.QueryCounter)GetExtensionDelegateStatic("glQueryCounter", typeof(Delegates.QueryCounter));
            Delegates.glQueryCounter((UInt32)id, (OpenTK.Graphics.OpenGL4.QueryCounterTarget)target);
        }
        internal static void Load_ReadBuffer(OpenTK.Graphics.OpenGL4.ReadBufferMode mode)
        {
            Delegates.glReadBuffer = (Delegates.ReadBuffer)GetExtensionDelegateStatic("glReadBuffer", typeof(Delegates.ReadBuffer));
            Delegates.glReadBuffer((OpenTK.Graphics.OpenGL4.ReadBufferMode)mode);
        }
        internal static void Load_ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr data)
        {
            Delegates.glReadnPixelsARB = (Delegates.ReadnPixelsARB)GetExtensionDelegateStatic("glReadnPixelsARB", typeof(Delegates.ReadnPixelsARB));
            Delegates.glReadnPixelsARB((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.OpenGL4.All)format, (OpenTK.Graphics.OpenGL4.All)type, (Int32)bufSize, (IntPtr)data);
        }
        internal static void Load_ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels)
        {
            Delegates.glReadPixels = (Delegates.ReadPixels)GetExtensionDelegateStatic("glReadPixels", typeof(Delegates.ReadPixels));
            Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_ReleaseShaderCompiler()
        {
            Delegates.glReleaseShaderCompiler = (Delegates.ReleaseShaderCompiler)GetExtensionDelegateStatic("glReleaseShaderCompiler", typeof(Delegates.ReleaseShaderCompiler));
            Delegates.glReleaseShaderCompiler();
        }
        internal static void Load_RenderbufferStorage(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorage = (Delegates.RenderbufferStorage)GetExtensionDelegateStatic("glRenderbufferStorage", typeof(Delegates.RenderbufferStorage));
            Delegates.glRenderbufferStorage((OpenTK.Graphics.OpenGL4.RenderbufferTarget)target, (OpenTK.Graphics.OpenGL4.RenderbufferStorage)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorageMultisample = (Delegates.RenderbufferStorageMultisample)GetExtensionDelegateStatic("glRenderbufferStorageMultisample", typeof(Delegates.RenderbufferStorageMultisample));
            Delegates.glRenderbufferStorageMultisample((OpenTK.Graphics.OpenGL4.RenderbufferTarget)target, (Int32)samples, (OpenTK.Graphics.OpenGL4.RenderbufferStorage)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_ResetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target)
        {
            Delegates.glResetHistogram = (Delegates.ResetHistogram)GetExtensionDelegateStatic("glResetHistogram", typeof(Delegates.ResetHistogram));
            Delegates.glResetHistogram((OpenTK.Graphics.OpenGL4.HistogramTarget)target);
        }
        internal static void Load_ResetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target)
        {
            Delegates.glResetMinmax = (Delegates.ResetMinmax)GetExtensionDelegateStatic("glResetMinmax", typeof(Delegates.ResetMinmax));
            Delegates.glResetMinmax((OpenTK.Graphics.OpenGL4.MinmaxTarget)target);
        }
        internal static void Load_ResumeTransformFeedback()
        {
            Delegates.glResumeTransformFeedback = (Delegates.ResumeTransformFeedback)GetExtensionDelegateStatic("glResumeTransformFeedback", typeof(Delegates.ResumeTransformFeedback));
            Delegates.glResumeTransformFeedback();
        }
        internal static void Load_SampleCoverage(Single value, bool invert)
        {
            Delegates.glSampleCoverage = (Delegates.SampleCoverage)GetExtensionDelegateStatic("glSampleCoverage", typeof(Delegates.SampleCoverage));
            Delegates.glSampleCoverage((Single)value, (bool)invert);
        }
        internal static void Load_SampleMaski(UInt32 index, UInt32 mask)
        {
            Delegates.glSampleMaski = (Delegates.SampleMaski)GetExtensionDelegateStatic("glSampleMaski", typeof(Delegates.SampleMaski));
            Delegates.glSampleMaski((UInt32)index, (UInt32)mask);
        }
        internal static void Load_SamplerParameterf(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Single param)
        {
            Delegates.glSamplerParameterf = (Delegates.SamplerParameterf)GetExtensionDelegateStatic("glSamplerParameterf", typeof(Delegates.SamplerParameterf));
            Delegates.glSamplerParameterf((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (Single)param);
        }
        internal static unsafe void Load_SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Single* param)
        {
            Delegates.glSamplerParameterfv = (Delegates.SamplerParameterfv)GetExtensionDelegateStatic("glSamplerParameterfv", typeof(Delegates.SamplerParameterfv));
            Delegates.glSamplerParameterfv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (Single*)param);
        }
        internal static void Load_SamplerParameteri(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32 param)
        {
            Delegates.glSamplerParameteri = (Delegates.SamplerParameteri)GetExtensionDelegateStatic("glSamplerParameteri", typeof(Delegates.SamplerParameteri));
            Delegates.glSamplerParameteri((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (Int32)param);
        }
        internal static unsafe void Load_SamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32* param)
        {
            Delegates.glSamplerParameterIiv = (Delegates.SamplerParameterIiv)GetExtensionDelegateStatic("glSamplerParameterIiv", typeof(Delegates.SamplerParameterIiv));
            Delegates.glSamplerParameterIiv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (Int32*)param);
        }
        internal static unsafe void Load_SamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, UInt32* param)
        {
            Delegates.glSamplerParameterIuiv = (Delegates.SamplerParameterIuiv)GetExtensionDelegateStatic("glSamplerParameterIuiv", typeof(Delegates.SamplerParameterIuiv));
            Delegates.glSamplerParameterIuiv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (UInt32*)param);
        }
        internal static unsafe void Load_SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32* param)
        {
            Delegates.glSamplerParameteriv = (Delegates.SamplerParameteriv)GetExtensionDelegateStatic("glSamplerParameteriv", typeof(Delegates.SamplerParameteriv));
            Delegates.glSamplerParameteriv((UInt32)sampler, (OpenTK.Graphics.OpenGL4.SamplerParameterName)pname, (Int32*)param);
        }
        internal static void Load_Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glScissor = (Delegates.Scissor)GetExtensionDelegateStatic("glScissor", typeof(Delegates.Scissor));
            Delegates.glScissor((Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static unsafe void Load_ScissorArrayv(UInt32 first, Int32 count, Int32* v)
        {
            Delegates.glScissorArrayv = (Delegates.ScissorArrayv)GetExtensionDelegateStatic("glScissorArrayv", typeof(Delegates.ScissorArrayv));
            Delegates.glScissorArrayv((UInt32)first, (Int32)count, (Int32*)v);
        }
        internal static void Load_ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
        {
            Delegates.glScissorIndexed = (Delegates.ScissorIndexed)GetExtensionDelegateStatic("glScissorIndexed", typeof(Delegates.ScissorIndexed));
            Delegates.glScissorIndexed((UInt32)index, (Int32)left, (Int32)bottom, (Int32)width, (Int32)height);
        }
        internal static unsafe void Load_ScissorIndexedv(UInt32 index, Int32* v)
        {
            Delegates.glScissorIndexedv = (Delegates.ScissorIndexedv)GetExtensionDelegateStatic("glScissorIndexedv", typeof(Delegates.ScissorIndexedv));
            Delegates.glScissorIndexedv((UInt32)index, (Int32*)v);
        }
        internal static void Load_SecondaryColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color)
        {
            Delegates.glSecondaryColorP3ui = (Delegates.SecondaryColorP3ui)GetExtensionDelegateStatic("glSecondaryColorP3ui", typeof(Delegates.SecondaryColorP3ui));
            Delegates.glSecondaryColorP3ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)color);
        }
        internal static unsafe void Load_SecondaryColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color)
        {
            Delegates.glSecondaryColorP3uiv = (Delegates.SecondaryColorP3uiv)GetExtensionDelegateStatic("glSecondaryColorP3uiv", typeof(Delegates.SecondaryColorP3uiv));
            Delegates.glSecondaryColorP3uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)color);
        }
        internal static void Load_SeparableFilter2D(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr row, IntPtr column)
        {
            Delegates.glSeparableFilter2D = (Delegates.SeparableFilter2D)GetExtensionDelegateStatic("glSeparableFilter2D", typeof(Delegates.SeparableFilter2D));
            Delegates.glSeparableFilter2D((OpenTK.Graphics.OpenGL4.SeparableTarget)target, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)row, (IntPtr)column);
        }
        internal static unsafe void Load_ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, IntPtr binary, Int32 length)
        {
            Delegates.glShaderBinary = (Delegates.ShaderBinary)GetExtensionDelegateStatic("glShaderBinary", typeof(Delegates.ShaderBinary));
            Delegates.glShaderBinary((Int32)count, (UInt32*)shaders, (OpenTK.Graphics.OpenGL4.BinaryFormat)binaryformat, (IntPtr)binary, (Int32)length);
        }
        internal static unsafe void Load_ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length)
        {
            Delegates.glShaderSource = (Delegates.ShaderSource)GetExtensionDelegateStatic("glShaderSource", typeof(Delegates.ShaderSource));
            Delegates.glShaderSource((UInt32)shader, (Int32)count, (String[])@string, (Int32*)length);
        }
        internal static void Load_ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding)
        {
            Delegates.glShaderStorageBlockBinding = (Delegates.ShaderStorageBlockBinding)GetExtensionDelegateStatic("glShaderStorageBlockBinding", typeof(Delegates.ShaderStorageBlockBinding));
            Delegates.glShaderStorageBlockBinding((UInt32)program, (UInt32)storageBlockIndex, (UInt32)storageBlockBinding);
        }
        internal static void Load_StencilFunc(OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask)
        {
            Delegates.glStencilFunc = (Delegates.StencilFunc)GetExtensionDelegateStatic("glStencilFunc", typeof(Delegates.StencilFunc));
            Delegates.glStencilFunc((OpenTK.Graphics.OpenGL4.StencilFunction)func, (Int32)@ref, (UInt32)mask);
        }
        internal static void Load_StencilFuncSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask)
        {
            Delegates.glStencilFuncSeparate = (Delegates.StencilFuncSeparate)GetExtensionDelegateStatic("glStencilFuncSeparate", typeof(Delegates.StencilFuncSeparate));
            Delegates.glStencilFuncSeparate((OpenTK.Graphics.OpenGL4.StencilFace)face, (OpenTK.Graphics.OpenGL4.StencilFunction)func, (Int32)@ref, (UInt32)mask);
        }
        internal static void Load_StencilMask(UInt32 mask)
        {
            Delegates.glStencilMask = (Delegates.StencilMask)GetExtensionDelegateStatic("glStencilMask", typeof(Delegates.StencilMask));
            Delegates.glStencilMask((UInt32)mask);
        }
        internal static void Load_StencilMaskSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, UInt32 mask)
        {
            Delegates.glStencilMaskSeparate = (Delegates.StencilMaskSeparate)GetExtensionDelegateStatic("glStencilMaskSeparate", typeof(Delegates.StencilMaskSeparate));
            Delegates.glStencilMaskSeparate((OpenTK.Graphics.OpenGL4.StencilFace)face, (UInt32)mask);
        }
        internal static void Load_StencilOp(OpenTK.Graphics.OpenGL4.StencilOp fail, OpenTK.Graphics.OpenGL4.StencilOp zfail, OpenTK.Graphics.OpenGL4.StencilOp zpass)
        {
            Delegates.glStencilOp = (Delegates.StencilOp)GetExtensionDelegateStatic("glStencilOp", typeof(Delegates.StencilOp));
            Delegates.glStencilOp((OpenTK.Graphics.OpenGL4.StencilOp)fail, (OpenTK.Graphics.OpenGL4.StencilOp)zfail, (OpenTK.Graphics.OpenGL4.StencilOp)zpass);
        }
        internal static void Load_StencilOpSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilOp sfail, OpenTK.Graphics.OpenGL4.StencilOp dpfail, OpenTK.Graphics.OpenGL4.StencilOp dppass)
        {
            Delegates.glStencilOpSeparate = (Delegates.StencilOpSeparate)GetExtensionDelegateStatic("glStencilOpSeparate", typeof(Delegates.StencilOpSeparate));
            Delegates.glStencilOpSeparate((OpenTK.Graphics.OpenGL4.StencilFace)face, (OpenTK.Graphics.OpenGL4.StencilOp)sfail, (OpenTK.Graphics.OpenGL4.StencilOp)dpfail, (OpenTK.Graphics.OpenGL4.StencilOp)dppass);
        }
        internal static void Load_TexBuffer(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer)
        {
            Delegates.glTexBuffer = (Delegates.TexBuffer)GetExtensionDelegateStatic("glTexBuffer", typeof(Delegates.TexBuffer));
            Delegates.glTexBuffer((OpenTK.Graphics.OpenGL4.TextureBufferTarget)target, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (UInt32)buffer);
        }
        internal static void Load_TexBufferRange(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size)
        {
            Delegates.glTexBufferRange = (Delegates.TexBufferRange)GetExtensionDelegateStatic("glTexBufferRange", typeof(Delegates.TexBufferRange));
            Delegates.glTexBufferRange((OpenTK.Graphics.OpenGL4.TextureBufferTarget)target, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (UInt32)buffer, (IntPtr)offset, (IntPtr)size);
        }
        internal static void Load_TexCoordP1ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glTexCoordP1ui = (Delegates.TexCoordP1ui)GetExtensionDelegateStatic("glTexCoordP1ui", typeof(Delegates.TexCoordP1ui));
            Delegates.glTexCoordP1ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_TexCoordP1uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glTexCoordP1uiv = (Delegates.TexCoordP1uiv)GetExtensionDelegateStatic("glTexCoordP1uiv", typeof(Delegates.TexCoordP1uiv));
            Delegates.glTexCoordP1uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_TexCoordP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glTexCoordP2ui = (Delegates.TexCoordP2ui)GetExtensionDelegateStatic("glTexCoordP2ui", typeof(Delegates.TexCoordP2ui));
            Delegates.glTexCoordP2ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_TexCoordP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glTexCoordP2uiv = (Delegates.TexCoordP2uiv)GetExtensionDelegateStatic("glTexCoordP2uiv", typeof(Delegates.TexCoordP2uiv));
            Delegates.glTexCoordP2uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_TexCoordP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glTexCoordP3ui = (Delegates.TexCoordP3ui)GetExtensionDelegateStatic("glTexCoordP3ui", typeof(Delegates.TexCoordP3ui));
            Delegates.glTexCoordP3ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_TexCoordP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glTexCoordP3uiv = (Delegates.TexCoordP3uiv)GetExtensionDelegateStatic("glTexCoordP3uiv", typeof(Delegates.TexCoordP3uiv));
            Delegates.glTexCoordP3uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_TexCoordP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords)
        {
            Delegates.glTexCoordP4ui = (Delegates.TexCoordP4ui)GetExtensionDelegateStatic("glTexCoordP4ui", typeof(Delegates.TexCoordP4ui));
            Delegates.glTexCoordP4ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)coords);
        }
        internal static unsafe void Load_TexCoordP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords)
        {
            Delegates.glTexCoordP4uiv = (Delegates.TexCoordP4uiv)GetExtensionDelegateStatic("glTexCoordP4uiv", typeof(Delegates.TexCoordP4uiv));
            Delegates.glTexCoordP4uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)coords);
        }
        internal static void Load_TexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels)
        {
            Delegates.glTexImage1D = (Delegates.TexImage1D)GetExtensionDelegateStatic("glTexImage1D", typeof(Delegates.TexImage1D));
            Delegates.glTexImage1D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)border, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels)
        {
            Delegates.glTexImage2D = (Delegates.TexImage2D)GetExtensionDelegateStatic("glTexImage2D", typeof(Delegates.TexImage2D));
            Delegates.glTexImage2D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexImage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
        {
            Delegates.glTexImage2DMultisample = (Delegates.TexImage2DMultisample)GetExtensionDelegateStatic("glTexImage2DMultisample", typeof(Delegates.TexImage2DMultisample));
            Delegates.glTexImage2DMultisample((OpenTK.Graphics.OpenGL4.TextureTargetMultisample)target, (Int32)samples, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (bool)fixedsamplelocations);
        }
        internal static void Load_TexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels)
        {
            Delegates.glTexImage3D = (Delegates.TexImage3D)GetExtensionDelegateStatic("glTexImage3D", typeof(Delegates.TexImage3D));
            Delegates.glTexImage3D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)depth, (Int32)border, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexImage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
        {
            Delegates.glTexImage3DMultisample = (Delegates.TexImage3DMultisample)GetExtensionDelegateStatic("glTexImage3DMultisample", typeof(Delegates.TexImage3DMultisample));
            Delegates.glTexImage3DMultisample((OpenTK.Graphics.OpenGL4.TextureTargetMultisample)target, (Int32)samples, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)depth, (bool)fixedsamplelocations);
        }
        internal static void Load_TexPageCommitmentARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident)
        {
            Delegates.glTexPageCommitmentARB = (Delegates.TexPageCommitmentARB)GetExtensionDelegateStatic("glTexPageCommitmentARB", typeof(Delegates.TexPageCommitmentARB));
            Delegates.glTexPageCommitmentARB((OpenTK.Graphics.OpenGL4.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (bool)resident);
        }
        internal static void Load_TexParameterf(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single param)
        {
            Delegates.glTexParameterf = (Delegates.TexParameterf)GetExtensionDelegateStatic("glTexParameterf", typeof(Delegates.TexParameterf));
            Delegates.glTexParameterf((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.TextureParameterName)pname, (Single)param);
        }
        internal static unsafe void Load_TexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single* @params)
        {
            Delegates.glTexParameterfv = (Delegates.TexParameterfv)GetExtensionDelegateStatic("glTexParameterfv", typeof(Delegates.TexParameterfv));
            Delegates.glTexParameterfv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.TextureParameterName)pname, (Single*)@params);
        }
        internal static void Load_TexParameteri(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32 param)
        {
            Delegates.glTexParameteri = (Delegates.TexParameteri)GetExtensionDelegateStatic("glTexParameteri", typeof(Delegates.TexParameteri));
            Delegates.glTexParameteri((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.TextureParameterName)pname, (Int32)param);
        }
        internal static unsafe void Load_TexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params)
        {
            Delegates.glTexParameterIiv = (Delegates.TexParameterIiv)GetExtensionDelegateStatic("glTexParameterIiv", typeof(Delegates.TexParameterIiv));
            Delegates.glTexParameterIiv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.TextureParameterName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_TexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, UInt32* @params)
        {
            Delegates.glTexParameterIuiv = (Delegates.TexParameterIuiv)GetExtensionDelegateStatic("glTexParameterIuiv", typeof(Delegates.TexParameterIuiv));
            Delegates.glTexParameterIuiv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.TextureParameterName)pname, (UInt32*)@params);
        }
        internal static unsafe void Load_TexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params)
        {
            Delegates.glTexParameteriv = (Delegates.TexParameteriv)GetExtensionDelegateStatic("glTexParameteriv", typeof(Delegates.TexParameteriv));
            Delegates.glTexParameteriv((OpenTK.Graphics.OpenGL4.TextureTarget)target, (OpenTK.Graphics.OpenGL4.TextureParameterName)pname, (Int32*)@params);
        }
        internal static void Load_TexStorage1D(OpenTK.Graphics.OpenGL4.TextureTarget1d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width)
        {
            Delegates.glTexStorage1D = (Delegates.TexStorage1D)GetExtensionDelegateStatic("glTexStorage1D", typeof(Delegates.TexStorage1D));
            Delegates.glTexStorage1D((OpenTK.Graphics.OpenGL4.TextureTarget1d)target, (Int32)levels, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (Int32)width);
        }
        internal static void Load_TexStorage2D(OpenTK.Graphics.OpenGL4.TextureTarget2d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glTexStorage2D = (Delegates.TexStorage2D)GetExtensionDelegateStatic("glTexStorage2D", typeof(Delegates.TexStorage2D));
            Delegates.glTexStorage2D((OpenTK.Graphics.OpenGL4.TextureTarget2d)target, (Int32)levels, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_TexStorage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample2d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
        {
            Delegates.glTexStorage2DMultisample = (Delegates.TexStorage2DMultisample)GetExtensionDelegateStatic("glTexStorage2DMultisample", typeof(Delegates.TexStorage2DMultisample));
            Delegates.glTexStorage2DMultisample((OpenTK.Graphics.OpenGL4.TextureTargetMultisample2d)target, (Int32)samples, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (Int32)width, (Int32)height, (bool)fixedsamplelocations);
        }
        internal static void Load_TexStorage3D(OpenTK.Graphics.OpenGL4.TextureTarget3d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth)
        {
            Delegates.glTexStorage3D = (Delegates.TexStorage3D)GetExtensionDelegateStatic("glTexStorage3D", typeof(Delegates.TexStorage3D));
            Delegates.glTexStorage3D((OpenTK.Graphics.OpenGL4.TextureTarget3d)target, (Int32)levels, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)depth);
        }
        internal static void Load_TexStorage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample3d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
        {
            Delegates.glTexStorage3DMultisample = (Delegates.TexStorage3DMultisample)GetExtensionDelegateStatic("glTexStorage3DMultisample", typeof(Delegates.TexStorage3DMultisample));
            Delegates.glTexStorage3DMultisample((OpenTK.Graphics.OpenGL4.TextureTargetMultisample3d)target, (Int32)samples, (OpenTK.Graphics.OpenGL4.SizedInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)depth, (bool)fixedsamplelocations);
        }
        internal static void Load_TexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage1D = (Delegates.TexSubImage1D)GetExtensionDelegateStatic("glTexSubImage1D", typeof(Delegates.TexSubImage1D));
            Delegates.glTexSubImage1D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)width, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage2D = (Delegates.TexSubImage2D)GetExtensionDelegateStatic("glTexSubImage2D", typeof(Delegates.TexSubImage2D));
            Delegates.glTexSubImage2D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage3D = (Delegates.TexSubImage3D)GetExtensionDelegateStatic("glTexSubImage3D", typeof(Delegates.TexSubImage3D));
            Delegates.glTexSubImage3D((OpenTK.Graphics.OpenGL4.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.OpenGL4.PixelFormat)format, (OpenTK.Graphics.OpenGL4.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TextureView(UInt32 texture, OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 origtexture, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
        {
            Delegates.glTextureView = (Delegates.TextureView)GetExtensionDelegateStatic("glTextureView", typeof(Delegates.TextureView));
            Delegates.glTextureView((UInt32)texture, (OpenTK.Graphics.OpenGL4.TextureTarget)target, (UInt32)origtexture, (OpenTK.Graphics.OpenGL4.PixelInternalFormat)internalformat, (UInt32)minlevel, (UInt32)numlevels, (UInt32)minlayer, (UInt32)numlayers);
        }
        internal static void Load_TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.OpenGL4.TransformFeedbackMode bufferMode)
        {
            Delegates.glTransformFeedbackVaryings = (Delegates.TransformFeedbackVaryings)GetExtensionDelegateStatic("glTransformFeedbackVaryings", typeof(Delegates.TransformFeedbackVaryings));
            Delegates.glTransformFeedbackVaryings((UInt32)program, (Int32)count, (String[])varyings, (OpenTK.Graphics.OpenGL4.TransformFeedbackMode)bufferMode);
        }
        internal static void Load_Uniform1d(Int32 location, Double x)
        {
            Delegates.glUniform1d = (Delegates.Uniform1d)GetExtensionDelegateStatic("glUniform1d", typeof(Delegates.Uniform1d));
            Delegates.glUniform1d((Int32)location, (Double)x);
        }
        internal static unsafe void Load_Uniform1dv(Int32 location, Int32 count, Double* value)
        {
            Delegates.glUniform1dv = (Delegates.Uniform1dv)GetExtensionDelegateStatic("glUniform1dv", typeof(Delegates.Uniform1dv));
            Delegates.glUniform1dv((Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_Uniform1f(Int32 location, Single v0)
        {
            Delegates.glUniform1f = (Delegates.Uniform1f)GetExtensionDelegateStatic("glUniform1f", typeof(Delegates.Uniform1f));
            Delegates.glUniform1f((Int32)location, (Single)v0);
        }
        internal static unsafe void Load_Uniform1fv(Int32 location, Int32 count, Single* value)
        {
            Delegates.glUniform1fv = (Delegates.Uniform1fv)GetExtensionDelegateStatic("glUniform1fv", typeof(Delegates.Uniform1fv));
            Delegates.glUniform1fv((Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_Uniform1i(Int32 location, Int32 v0)
        {
            Delegates.glUniform1i = (Delegates.Uniform1i)GetExtensionDelegateStatic("glUniform1i", typeof(Delegates.Uniform1i));
            Delegates.glUniform1i((Int32)location, (Int32)v0);
        }
        internal static unsafe void Load_Uniform1iv(Int32 location, Int32 count, Int32* value)
        {
            Delegates.glUniform1iv = (Delegates.Uniform1iv)GetExtensionDelegateStatic("glUniform1iv", typeof(Delegates.Uniform1iv));
            Delegates.glUniform1iv((Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_Uniform1ui(Int32 location, UInt32 v0)
        {
            Delegates.glUniform1ui = (Delegates.Uniform1ui)GetExtensionDelegateStatic("glUniform1ui", typeof(Delegates.Uniform1ui));
            Delegates.glUniform1ui((Int32)location, (UInt32)v0);
        }
        internal static unsafe void Load_Uniform1uiv(Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glUniform1uiv = (Delegates.Uniform1uiv)GetExtensionDelegateStatic("glUniform1uiv", typeof(Delegates.Uniform1uiv));
            Delegates.glUniform1uiv((Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_Uniform2d(Int32 location, Double x, Double y)
        {
            Delegates.glUniform2d = (Delegates.Uniform2d)GetExtensionDelegateStatic("glUniform2d", typeof(Delegates.Uniform2d));
            Delegates.glUniform2d((Int32)location, (Double)x, (Double)y);
        }
        internal static unsafe void Load_Uniform2dv(Int32 location, Int32 count, Double* value)
        {
            Delegates.glUniform2dv = (Delegates.Uniform2dv)GetExtensionDelegateStatic("glUniform2dv", typeof(Delegates.Uniform2dv));
            Delegates.glUniform2dv((Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_Uniform2f(Int32 location, Single v0, Single v1)
        {
            Delegates.glUniform2f = (Delegates.Uniform2f)GetExtensionDelegateStatic("glUniform2f", typeof(Delegates.Uniform2f));
            Delegates.glUniform2f((Int32)location, (Single)v0, (Single)v1);
        }
        internal static unsafe void Load_Uniform2fv(Int32 location, Int32 count, Single* value)
        {
            Delegates.glUniform2fv = (Delegates.Uniform2fv)GetExtensionDelegateStatic("glUniform2fv", typeof(Delegates.Uniform2fv));
            Delegates.glUniform2fv((Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_Uniform2i(Int32 location, Int32 v0, Int32 v1)
        {
            Delegates.glUniform2i = (Delegates.Uniform2i)GetExtensionDelegateStatic("glUniform2i", typeof(Delegates.Uniform2i));
            Delegates.glUniform2i((Int32)location, (Int32)v0, (Int32)v1);
        }
        internal static unsafe void Load_Uniform2iv(Int32 location, Int32 count, Int32* value)
        {
            Delegates.glUniform2iv = (Delegates.Uniform2iv)GetExtensionDelegateStatic("glUniform2iv", typeof(Delegates.Uniform2iv));
            Delegates.glUniform2iv((Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_Uniform2ui(Int32 location, UInt32 v0, UInt32 v1)
        {
            Delegates.glUniform2ui = (Delegates.Uniform2ui)GetExtensionDelegateStatic("glUniform2ui", typeof(Delegates.Uniform2ui));
            Delegates.glUniform2ui((Int32)location, (UInt32)v0, (UInt32)v1);
        }
        internal static unsafe void Load_Uniform2uiv(Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glUniform2uiv = (Delegates.Uniform2uiv)GetExtensionDelegateStatic("glUniform2uiv", typeof(Delegates.Uniform2uiv));
            Delegates.glUniform2uiv((Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_Uniform3d(Int32 location, Double x, Double y, Double z)
        {
            Delegates.glUniform3d = (Delegates.Uniform3d)GetExtensionDelegateStatic("glUniform3d", typeof(Delegates.Uniform3d));
            Delegates.glUniform3d((Int32)location, (Double)x, (Double)y, (Double)z);
        }
        internal static unsafe void Load_Uniform3dv(Int32 location, Int32 count, Double* value)
        {
            Delegates.glUniform3dv = (Delegates.Uniform3dv)GetExtensionDelegateStatic("glUniform3dv", typeof(Delegates.Uniform3dv));
            Delegates.glUniform3dv((Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_Uniform3f(Int32 location, Single v0, Single v1, Single v2)
        {
            Delegates.glUniform3f = (Delegates.Uniform3f)GetExtensionDelegateStatic("glUniform3f", typeof(Delegates.Uniform3f));
            Delegates.glUniform3f((Int32)location, (Single)v0, (Single)v1, (Single)v2);
        }
        internal static unsafe void Load_Uniform3fv(Int32 location, Int32 count, Single* value)
        {
            Delegates.glUniform3fv = (Delegates.Uniform3fv)GetExtensionDelegateStatic("glUniform3fv", typeof(Delegates.Uniform3fv));
            Delegates.glUniform3fv((Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2)
        {
            Delegates.glUniform3i = (Delegates.Uniform3i)GetExtensionDelegateStatic("glUniform3i", typeof(Delegates.Uniform3i));
            Delegates.glUniform3i((Int32)location, (Int32)v0, (Int32)v1, (Int32)v2);
        }
        internal static unsafe void Load_Uniform3iv(Int32 location, Int32 count, Int32* value)
        {
            Delegates.glUniform3iv = (Delegates.Uniform3iv)GetExtensionDelegateStatic("glUniform3iv", typeof(Delegates.Uniform3iv));
            Delegates.glUniform3iv((Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
        {
            Delegates.glUniform3ui = (Delegates.Uniform3ui)GetExtensionDelegateStatic("glUniform3ui", typeof(Delegates.Uniform3ui));
            Delegates.glUniform3ui((Int32)location, (UInt32)v0, (UInt32)v1, (UInt32)v2);
        }
        internal static unsafe void Load_Uniform3uiv(Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glUniform3uiv = (Delegates.Uniform3uiv)GetExtensionDelegateStatic("glUniform3uiv", typeof(Delegates.Uniform3uiv));
            Delegates.glUniform3uiv((Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_Uniform4d(Int32 location, Double x, Double y, Double z, Double w)
        {
            Delegates.glUniform4d = (Delegates.Uniform4d)GetExtensionDelegateStatic("glUniform4d", typeof(Delegates.Uniform4d));
            Delegates.glUniform4d((Int32)location, (Double)x, (Double)y, (Double)z, (Double)w);
        }
        internal static unsafe void Load_Uniform4dv(Int32 location, Int32 count, Double* value)
        {
            Delegates.glUniform4dv = (Delegates.Uniform4dv)GetExtensionDelegateStatic("glUniform4dv", typeof(Delegates.Uniform4dv));
            Delegates.glUniform4dv((Int32)location, (Int32)count, (Double*)value);
        }
        internal static void Load_Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3)
        {
            Delegates.glUniform4f = (Delegates.Uniform4f)GetExtensionDelegateStatic("glUniform4f", typeof(Delegates.Uniform4f));
            Delegates.glUniform4f((Int32)location, (Single)v0, (Single)v1, (Single)v2, (Single)v3);
        }
        internal static unsafe void Load_Uniform4fv(Int32 location, Int32 count, Single* value)
        {
            Delegates.glUniform4fv = (Delegates.Uniform4fv)GetExtensionDelegateStatic("glUniform4fv", typeof(Delegates.Uniform4fv));
            Delegates.glUniform4fv((Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
        {
            Delegates.glUniform4i = (Delegates.Uniform4i)GetExtensionDelegateStatic("glUniform4i", typeof(Delegates.Uniform4i));
            Delegates.glUniform4i((Int32)location, (Int32)v0, (Int32)v1, (Int32)v2, (Int32)v3);
        }
        internal static unsafe void Load_Uniform4iv(Int32 location, Int32 count, Int32* value)
        {
            Delegates.glUniform4iv = (Delegates.Uniform4iv)GetExtensionDelegateStatic("glUniform4iv", typeof(Delegates.Uniform4iv));
            Delegates.glUniform4iv((Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
        {
            Delegates.glUniform4ui = (Delegates.Uniform4ui)GetExtensionDelegateStatic("glUniform4ui", typeof(Delegates.Uniform4ui));
            Delegates.glUniform4ui((Int32)location, (UInt32)v0, (UInt32)v1, (UInt32)v2, (UInt32)v3);
        }
        internal static unsafe void Load_Uniform4uiv(Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glUniform4uiv = (Delegates.Uniform4uiv)GetExtensionDelegateStatic("glUniform4uiv", typeof(Delegates.Uniform4uiv));
            Delegates.glUniform4uiv((Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
        {
            Delegates.glUniformBlockBinding = (Delegates.UniformBlockBinding)GetExtensionDelegateStatic("glUniformBlockBinding", typeof(Delegates.UniformBlockBinding));
            Delegates.glUniformBlockBinding((UInt32)program, (UInt32)uniformBlockIndex, (UInt32)uniformBlockBinding);
        }
        internal static void Load_UniformHandleui64ARB(Int32 location, UInt64 value)
        {
            Delegates.glUniformHandleui64ARB = (Delegates.UniformHandleui64ARB)GetExtensionDelegateStatic("glUniformHandleui64ARB", typeof(Delegates.UniformHandleui64ARB));
            Delegates.glUniformHandleui64ARB((Int32)location, (UInt64)value);
        }
        internal static unsafe void Load_UniformHandleui64vARB(Int32 location, Int32 count, UInt64* value)
        {
            Delegates.glUniformHandleui64vARB = (Delegates.UniformHandleui64vARB)GetExtensionDelegateStatic("glUniformHandleui64vARB", typeof(Delegates.UniformHandleui64vARB));
            Delegates.glUniformHandleui64vARB((Int32)location, (Int32)count, (UInt64*)value);
        }
        internal static unsafe void Load_UniformMatrix2dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix2dv = (Delegates.UniformMatrix2dv)GetExtensionDelegateStatic("glUniformMatrix2dv", typeof(Delegates.UniformMatrix2dv));
            Delegates.glUniformMatrix2dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix2fv = (Delegates.UniformMatrix2fv)GetExtensionDelegateStatic("glUniformMatrix2fv", typeof(Delegates.UniformMatrix2fv));
            Delegates.glUniformMatrix2fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix2x3dv = (Delegates.UniformMatrix2x3dv)GetExtensionDelegateStatic("glUniformMatrix2x3dv", typeof(Delegates.UniformMatrix2x3dv));
            Delegates.glUniformMatrix2x3dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix2x3fv = (Delegates.UniformMatrix2x3fv)GetExtensionDelegateStatic("glUniformMatrix2x3fv", typeof(Delegates.UniformMatrix2x3fv));
            Delegates.glUniformMatrix2x3fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix2x4dv = (Delegates.UniformMatrix2x4dv)GetExtensionDelegateStatic("glUniformMatrix2x4dv", typeof(Delegates.UniformMatrix2x4dv));
            Delegates.glUniformMatrix2x4dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix2x4fv = (Delegates.UniformMatrix2x4fv)GetExtensionDelegateStatic("glUniformMatrix2x4fv", typeof(Delegates.UniformMatrix2x4fv));
            Delegates.glUniformMatrix2x4fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix3dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix3dv = (Delegates.UniformMatrix3dv)GetExtensionDelegateStatic("glUniformMatrix3dv", typeof(Delegates.UniformMatrix3dv));
            Delegates.glUniformMatrix3dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix3fv = (Delegates.UniformMatrix3fv)GetExtensionDelegateStatic("glUniformMatrix3fv", typeof(Delegates.UniformMatrix3fv));
            Delegates.glUniformMatrix3fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix3x2dv = (Delegates.UniformMatrix3x2dv)GetExtensionDelegateStatic("glUniformMatrix3x2dv", typeof(Delegates.UniformMatrix3x2dv));
            Delegates.glUniformMatrix3x2dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix3x2fv = (Delegates.UniformMatrix3x2fv)GetExtensionDelegateStatic("glUniformMatrix3x2fv", typeof(Delegates.UniformMatrix3x2fv));
            Delegates.glUniformMatrix3x2fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix3x4dv = (Delegates.UniformMatrix3x4dv)GetExtensionDelegateStatic("glUniformMatrix3x4dv", typeof(Delegates.UniformMatrix3x4dv));
            Delegates.glUniformMatrix3x4dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix3x4fv = (Delegates.UniformMatrix3x4fv)GetExtensionDelegateStatic("glUniformMatrix3x4fv", typeof(Delegates.UniformMatrix3x4fv));
            Delegates.glUniformMatrix3x4fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix4dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix4dv = (Delegates.UniformMatrix4dv)GetExtensionDelegateStatic("glUniformMatrix4dv", typeof(Delegates.UniformMatrix4dv));
            Delegates.glUniformMatrix4dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix4fv = (Delegates.UniformMatrix4fv)GetExtensionDelegateStatic("glUniformMatrix4fv", typeof(Delegates.UniformMatrix4fv));
            Delegates.glUniformMatrix4fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix4x2dv = (Delegates.UniformMatrix4x2dv)GetExtensionDelegateStatic("glUniformMatrix4x2dv", typeof(Delegates.UniformMatrix4x2dv));
            Delegates.glUniformMatrix4x2dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix4x2fv = (Delegates.UniformMatrix4x2fv)GetExtensionDelegateStatic("glUniformMatrix4x2fv", typeof(Delegates.UniformMatrix4x2fv));
            Delegates.glUniformMatrix4x2fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, Double* value)
        {
            Delegates.glUniformMatrix4x3dv = (Delegates.UniformMatrix4x3dv)GetExtensionDelegateStatic("glUniformMatrix4x3dv", typeof(Delegates.UniformMatrix4x3dv));
            Delegates.glUniformMatrix4x3dv((Int32)location, (Int32)count, (bool)transpose, (Double*)value);
        }
        internal static unsafe void Load_UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix4x3fv = (Delegates.UniformMatrix4x3fv)GetExtensionDelegateStatic("glUniformMatrix4x3fv", typeof(Delegates.UniformMatrix4x3fv));
            Delegates.glUniformMatrix4x3fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformSubroutinesuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 count, UInt32* indices)
        {
            Delegates.glUniformSubroutinesuiv = (Delegates.UniformSubroutinesuiv)GetExtensionDelegateStatic("glUniformSubroutinesuiv", typeof(Delegates.UniformSubroutinesuiv));
            Delegates.glUniformSubroutinesuiv((OpenTK.Graphics.OpenGL4.ShaderType)shadertype, (Int32)count, (UInt32*)indices);
        }
        internal static bool Load_UnmapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target)
        {
            Delegates.glUnmapBuffer = (Delegates.UnmapBuffer)GetExtensionDelegateStatic("glUnmapBuffer", typeof(Delegates.UnmapBuffer));
            return Delegates.glUnmapBuffer((OpenTK.Graphics.OpenGL4.BufferTarget)target);
        }
        internal static void Load_UseProgram(UInt32 program)
        {
            Delegates.glUseProgram = (Delegates.UseProgram)GetExtensionDelegateStatic("glUseProgram", typeof(Delegates.UseProgram));
            Delegates.glUseProgram((UInt32)program);
        }
        internal static void Load_UseProgramStages(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramStageMask stages, UInt32 program)
        {
            Delegates.glUseProgramStages = (Delegates.UseProgramStages)GetExtensionDelegateStatic("glUseProgramStages", typeof(Delegates.UseProgramStages));
            Delegates.glUseProgramStages((UInt32)pipeline, (OpenTK.Graphics.OpenGL4.ProgramStageMask)stages, (UInt32)program);
        }
        internal static void Load_ValidateProgram(UInt32 program)
        {
            Delegates.glValidateProgram = (Delegates.ValidateProgram)GetExtensionDelegateStatic("glValidateProgram", typeof(Delegates.ValidateProgram));
            Delegates.glValidateProgram((UInt32)program);
        }
        internal static void Load_ValidateProgramPipeline(UInt32 pipeline)
        {
            Delegates.glValidateProgramPipeline = (Delegates.ValidateProgramPipeline)GetExtensionDelegateStatic("glValidateProgramPipeline", typeof(Delegates.ValidateProgramPipeline));
            Delegates.glValidateProgramPipeline((UInt32)pipeline);
        }
        internal static void Load_VertexAttrib1d(UInt32 index, Double x)
        {
            Delegates.glVertexAttrib1d = (Delegates.VertexAttrib1d)GetExtensionDelegateStatic("glVertexAttrib1d", typeof(Delegates.VertexAttrib1d));
            Delegates.glVertexAttrib1d((UInt32)index, (Double)x);
        }
        internal static unsafe void Load_VertexAttrib1dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttrib1dv = (Delegates.VertexAttrib1dv)GetExtensionDelegateStatic("glVertexAttrib1dv", typeof(Delegates.VertexAttrib1dv));
            Delegates.glVertexAttrib1dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttrib1f(UInt32 index, Single x)
        {
            Delegates.glVertexAttrib1f = (Delegates.VertexAttrib1f)GetExtensionDelegateStatic("glVertexAttrib1f", typeof(Delegates.VertexAttrib1f));
            Delegates.glVertexAttrib1f((UInt32)index, (Single)x);
        }
        internal static unsafe void Load_VertexAttrib1fv(UInt32 index, Single* v)
        {
            Delegates.glVertexAttrib1fv = (Delegates.VertexAttrib1fv)GetExtensionDelegateStatic("glVertexAttrib1fv", typeof(Delegates.VertexAttrib1fv));
            Delegates.glVertexAttrib1fv((UInt32)index, (Single*)v);
        }
        internal static void Load_VertexAttrib1s(UInt32 index, Int16 x)
        {
            Delegates.glVertexAttrib1s = (Delegates.VertexAttrib1s)GetExtensionDelegateStatic("glVertexAttrib1s", typeof(Delegates.VertexAttrib1s));
            Delegates.glVertexAttrib1s((UInt32)index, (Int16)x);
        }
        internal static unsafe void Load_VertexAttrib1sv(UInt32 index, Int16* v)
        {
            Delegates.glVertexAttrib1sv = (Delegates.VertexAttrib1sv)GetExtensionDelegateStatic("glVertexAttrib1sv", typeof(Delegates.VertexAttrib1sv));
            Delegates.glVertexAttrib1sv((UInt32)index, (Int16*)v);
        }
        internal static void Load_VertexAttrib2d(UInt32 index, Double x, Double y)
        {
            Delegates.glVertexAttrib2d = (Delegates.VertexAttrib2d)GetExtensionDelegateStatic("glVertexAttrib2d", typeof(Delegates.VertexAttrib2d));
            Delegates.glVertexAttrib2d((UInt32)index, (Double)x, (Double)y);
        }
        internal static unsafe void Load_VertexAttrib2dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttrib2dv = (Delegates.VertexAttrib2dv)GetExtensionDelegateStatic("glVertexAttrib2dv", typeof(Delegates.VertexAttrib2dv));
            Delegates.glVertexAttrib2dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttrib2f(UInt32 index, Single x, Single y)
        {
            Delegates.glVertexAttrib2f = (Delegates.VertexAttrib2f)GetExtensionDelegateStatic("glVertexAttrib2f", typeof(Delegates.VertexAttrib2f));
            Delegates.glVertexAttrib2f((UInt32)index, (Single)x, (Single)y);
        }
        internal static unsafe void Load_VertexAttrib2fv(UInt32 index, Single* v)
        {
            Delegates.glVertexAttrib2fv = (Delegates.VertexAttrib2fv)GetExtensionDelegateStatic("glVertexAttrib2fv", typeof(Delegates.VertexAttrib2fv));
            Delegates.glVertexAttrib2fv((UInt32)index, (Single*)v);
        }
        internal static void Load_VertexAttrib2s(UInt32 index, Int16 x, Int16 y)
        {
            Delegates.glVertexAttrib2s = (Delegates.VertexAttrib2s)GetExtensionDelegateStatic("glVertexAttrib2s", typeof(Delegates.VertexAttrib2s));
            Delegates.glVertexAttrib2s((UInt32)index, (Int16)x, (Int16)y);
        }
        internal static unsafe void Load_VertexAttrib2sv(UInt32 index, Int16* v)
        {
            Delegates.glVertexAttrib2sv = (Delegates.VertexAttrib2sv)GetExtensionDelegateStatic("glVertexAttrib2sv", typeof(Delegates.VertexAttrib2sv));
            Delegates.glVertexAttrib2sv((UInt32)index, (Int16*)v);
        }
        internal static void Load_VertexAttrib3d(UInt32 index, Double x, Double y, Double z)
        {
            Delegates.glVertexAttrib3d = (Delegates.VertexAttrib3d)GetExtensionDelegateStatic("glVertexAttrib3d", typeof(Delegates.VertexAttrib3d));
            Delegates.glVertexAttrib3d((UInt32)index, (Double)x, (Double)y, (Double)z);
        }
        internal static unsafe void Load_VertexAttrib3dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttrib3dv = (Delegates.VertexAttrib3dv)GetExtensionDelegateStatic("glVertexAttrib3dv", typeof(Delegates.VertexAttrib3dv));
            Delegates.glVertexAttrib3dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttrib3f(UInt32 index, Single x, Single y, Single z)
        {
            Delegates.glVertexAttrib3f = (Delegates.VertexAttrib3f)GetExtensionDelegateStatic("glVertexAttrib3f", typeof(Delegates.VertexAttrib3f));
            Delegates.glVertexAttrib3f((UInt32)index, (Single)x, (Single)y, (Single)z);
        }
        internal static unsafe void Load_VertexAttrib3fv(UInt32 index, Single* v)
        {
            Delegates.glVertexAttrib3fv = (Delegates.VertexAttrib3fv)GetExtensionDelegateStatic("glVertexAttrib3fv", typeof(Delegates.VertexAttrib3fv));
            Delegates.glVertexAttrib3fv((UInt32)index, (Single*)v);
        }
        internal static void Load_VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z)
        {
            Delegates.glVertexAttrib3s = (Delegates.VertexAttrib3s)GetExtensionDelegateStatic("glVertexAttrib3s", typeof(Delegates.VertexAttrib3s));
            Delegates.glVertexAttrib3s((UInt32)index, (Int16)x, (Int16)y, (Int16)z);
        }
        internal static unsafe void Load_VertexAttrib3sv(UInt32 index, Int16* v)
        {
            Delegates.glVertexAttrib3sv = (Delegates.VertexAttrib3sv)GetExtensionDelegateStatic("glVertexAttrib3sv", typeof(Delegates.VertexAttrib3sv));
            Delegates.glVertexAttrib3sv((UInt32)index, (Int16*)v);
        }
        internal static unsafe void Load_VertexAttrib4bv(UInt32 index, SByte* v)
        {
            Delegates.glVertexAttrib4bv = (Delegates.VertexAttrib4bv)GetExtensionDelegateStatic("glVertexAttrib4bv", typeof(Delegates.VertexAttrib4bv));
            Delegates.glVertexAttrib4bv((UInt32)index, (SByte*)v);
        }
        internal static void Load_VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w)
        {
            Delegates.glVertexAttrib4d = (Delegates.VertexAttrib4d)GetExtensionDelegateStatic("glVertexAttrib4d", typeof(Delegates.VertexAttrib4d));
            Delegates.glVertexAttrib4d((UInt32)index, (Double)x, (Double)y, (Double)z, (Double)w);
        }
        internal static unsafe void Load_VertexAttrib4dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttrib4dv = (Delegates.VertexAttrib4dv)GetExtensionDelegateStatic("glVertexAttrib4dv", typeof(Delegates.VertexAttrib4dv));
            Delegates.glVertexAttrib4dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w)
        {
            Delegates.glVertexAttrib4f = (Delegates.VertexAttrib4f)GetExtensionDelegateStatic("glVertexAttrib4f", typeof(Delegates.VertexAttrib4f));
            Delegates.glVertexAttrib4f((UInt32)index, (Single)x, (Single)y, (Single)z, (Single)w);
        }
        internal static unsafe void Load_VertexAttrib4fv(UInt32 index, Single* v)
        {
            Delegates.glVertexAttrib4fv = (Delegates.VertexAttrib4fv)GetExtensionDelegateStatic("glVertexAttrib4fv", typeof(Delegates.VertexAttrib4fv));
            Delegates.glVertexAttrib4fv((UInt32)index, (Single*)v);
        }
        internal static unsafe void Load_VertexAttrib4iv(UInt32 index, Int32* v)
        {
            Delegates.glVertexAttrib4iv = (Delegates.VertexAttrib4iv)GetExtensionDelegateStatic("glVertexAttrib4iv", typeof(Delegates.VertexAttrib4iv));
            Delegates.glVertexAttrib4iv((UInt32)index, (Int32*)v);
        }
        internal static unsafe void Load_VertexAttrib4Nbv(UInt32 index, SByte* v)
        {
            Delegates.glVertexAttrib4Nbv = (Delegates.VertexAttrib4Nbv)GetExtensionDelegateStatic("glVertexAttrib4Nbv", typeof(Delegates.VertexAttrib4Nbv));
            Delegates.glVertexAttrib4Nbv((UInt32)index, (SByte*)v);
        }
        internal static unsafe void Load_VertexAttrib4Niv(UInt32 index, Int32* v)
        {
            Delegates.glVertexAttrib4Niv = (Delegates.VertexAttrib4Niv)GetExtensionDelegateStatic("glVertexAttrib4Niv", typeof(Delegates.VertexAttrib4Niv));
            Delegates.glVertexAttrib4Niv((UInt32)index, (Int32*)v);
        }
        internal static unsafe void Load_VertexAttrib4Nsv(UInt32 index, Int16* v)
        {
            Delegates.glVertexAttrib4Nsv = (Delegates.VertexAttrib4Nsv)GetExtensionDelegateStatic("glVertexAttrib4Nsv", typeof(Delegates.VertexAttrib4Nsv));
            Delegates.glVertexAttrib4Nsv((UInt32)index, (Int16*)v);
        }
        internal static void Load_VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w)
        {
            Delegates.glVertexAttrib4Nub = (Delegates.VertexAttrib4Nub)GetExtensionDelegateStatic("glVertexAttrib4Nub", typeof(Delegates.VertexAttrib4Nub));
            Delegates.glVertexAttrib4Nub((UInt32)index, (Byte)x, (Byte)y, (Byte)z, (Byte)w);
        }
        internal static unsafe void Load_VertexAttrib4Nubv(UInt32 index, Byte* v)
        {
            Delegates.glVertexAttrib4Nubv = (Delegates.VertexAttrib4Nubv)GetExtensionDelegateStatic("glVertexAttrib4Nubv", typeof(Delegates.VertexAttrib4Nubv));
            Delegates.glVertexAttrib4Nubv((UInt32)index, (Byte*)v);
        }
        internal static unsafe void Load_VertexAttrib4Nuiv(UInt32 index, UInt32* v)
        {
            Delegates.glVertexAttrib4Nuiv = (Delegates.VertexAttrib4Nuiv)GetExtensionDelegateStatic("glVertexAttrib4Nuiv", typeof(Delegates.VertexAttrib4Nuiv));
            Delegates.glVertexAttrib4Nuiv((UInt32)index, (UInt32*)v);
        }
        internal static unsafe void Load_VertexAttrib4Nusv(UInt32 index, UInt16* v)
        {
            Delegates.glVertexAttrib4Nusv = (Delegates.VertexAttrib4Nusv)GetExtensionDelegateStatic("glVertexAttrib4Nusv", typeof(Delegates.VertexAttrib4Nusv));
            Delegates.glVertexAttrib4Nusv((UInt32)index, (UInt16*)v);
        }
        internal static void Load_VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
        {
            Delegates.glVertexAttrib4s = (Delegates.VertexAttrib4s)GetExtensionDelegateStatic("glVertexAttrib4s", typeof(Delegates.VertexAttrib4s));
            Delegates.glVertexAttrib4s((UInt32)index, (Int16)x, (Int16)y, (Int16)z, (Int16)w);
        }
        internal static unsafe void Load_VertexAttrib4sv(UInt32 index, Int16* v)
        {
            Delegates.glVertexAttrib4sv = (Delegates.VertexAttrib4sv)GetExtensionDelegateStatic("glVertexAttrib4sv", typeof(Delegates.VertexAttrib4sv));
            Delegates.glVertexAttrib4sv((UInt32)index, (Int16*)v);
        }
        internal static unsafe void Load_VertexAttrib4ubv(UInt32 index, Byte* v)
        {
            Delegates.glVertexAttrib4ubv = (Delegates.VertexAttrib4ubv)GetExtensionDelegateStatic("glVertexAttrib4ubv", typeof(Delegates.VertexAttrib4ubv));
            Delegates.glVertexAttrib4ubv((UInt32)index, (Byte*)v);
        }
        internal static unsafe void Load_VertexAttrib4uiv(UInt32 index, UInt32* v)
        {
            Delegates.glVertexAttrib4uiv = (Delegates.VertexAttrib4uiv)GetExtensionDelegateStatic("glVertexAttrib4uiv", typeof(Delegates.VertexAttrib4uiv));
            Delegates.glVertexAttrib4uiv((UInt32)index, (UInt32*)v);
        }
        internal static unsafe void Load_VertexAttrib4usv(UInt32 index, UInt16* v)
        {
            Delegates.glVertexAttrib4usv = (Delegates.VertexAttrib4usv)GetExtensionDelegateStatic("glVertexAttrib4usv", typeof(Delegates.VertexAttrib4usv));
            Delegates.glVertexAttrib4usv((UInt32)index, (UInt16*)v);
        }
        internal static void Load_VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex)
        {
            Delegates.glVertexAttribBinding = (Delegates.VertexAttribBinding)GetExtensionDelegateStatic("glVertexAttribBinding", typeof(Delegates.VertexAttribBinding));
            Delegates.glVertexAttribBinding((UInt32)attribindex, (UInt32)bindingindex);
        }
        internal static void Load_VertexAttribDivisor(UInt32 index, UInt32 divisor)
        {
            Delegates.glVertexAttribDivisor = (Delegates.VertexAttribDivisor)GetExtensionDelegateStatic("glVertexAttribDivisor", typeof(Delegates.VertexAttribDivisor));
            Delegates.glVertexAttribDivisor((UInt32)index, (UInt32)divisor);
        }
        internal static void Load_VertexAttribFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribType type, bool normalized, UInt32 relativeoffset)
        {
            Delegates.glVertexAttribFormat = (Delegates.VertexAttribFormat)GetExtensionDelegateStatic("glVertexAttribFormat", typeof(Delegates.VertexAttribFormat));
            Delegates.glVertexAttribFormat((UInt32)attribindex, (Int32)size, (OpenTK.Graphics.OpenGL4.VertexAttribType)type, (bool)normalized, (UInt32)relativeoffset);
        }
        internal static void Load_VertexAttribI1i(UInt32 index, Int32 x)
        {
            Delegates.glVertexAttribI1i = (Delegates.VertexAttribI1i)GetExtensionDelegateStatic("glVertexAttribI1i", typeof(Delegates.VertexAttribI1i));
            Delegates.glVertexAttribI1i((UInt32)index, (Int32)x);
        }
        internal static unsafe void Load_VertexAttribI1iv(UInt32 index, Int32* v)
        {
            Delegates.glVertexAttribI1iv = (Delegates.VertexAttribI1iv)GetExtensionDelegateStatic("glVertexAttribI1iv", typeof(Delegates.VertexAttribI1iv));
            Delegates.glVertexAttribI1iv((UInt32)index, (Int32*)v);
        }
        internal static void Load_VertexAttribI1ui(UInt32 index, UInt32 x)
        {
            Delegates.glVertexAttribI1ui = (Delegates.VertexAttribI1ui)GetExtensionDelegateStatic("glVertexAttribI1ui", typeof(Delegates.VertexAttribI1ui));
            Delegates.glVertexAttribI1ui((UInt32)index, (UInt32)x);
        }
        internal static unsafe void Load_VertexAttribI1uiv(UInt32 index, UInt32* v)
        {
            Delegates.glVertexAttribI1uiv = (Delegates.VertexAttribI1uiv)GetExtensionDelegateStatic("glVertexAttribI1uiv", typeof(Delegates.VertexAttribI1uiv));
            Delegates.glVertexAttribI1uiv((UInt32)index, (UInt32*)v);
        }
        internal static void Load_VertexAttribI2i(UInt32 index, Int32 x, Int32 y)
        {
            Delegates.glVertexAttribI2i = (Delegates.VertexAttribI2i)GetExtensionDelegateStatic("glVertexAttribI2i", typeof(Delegates.VertexAttribI2i));
            Delegates.glVertexAttribI2i((UInt32)index, (Int32)x, (Int32)y);
        }
        internal static unsafe void Load_VertexAttribI2iv(UInt32 index, Int32* v)
        {
            Delegates.glVertexAttribI2iv = (Delegates.VertexAttribI2iv)GetExtensionDelegateStatic("glVertexAttribI2iv", typeof(Delegates.VertexAttribI2iv));
            Delegates.glVertexAttribI2iv((UInt32)index, (Int32*)v);
        }
        internal static void Load_VertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y)
        {
            Delegates.glVertexAttribI2ui = (Delegates.VertexAttribI2ui)GetExtensionDelegateStatic("glVertexAttribI2ui", typeof(Delegates.VertexAttribI2ui));
            Delegates.glVertexAttribI2ui((UInt32)index, (UInt32)x, (UInt32)y);
        }
        internal static unsafe void Load_VertexAttribI2uiv(UInt32 index, UInt32* v)
        {
            Delegates.glVertexAttribI2uiv = (Delegates.VertexAttribI2uiv)GetExtensionDelegateStatic("glVertexAttribI2uiv", typeof(Delegates.VertexAttribI2uiv));
            Delegates.glVertexAttribI2uiv((UInt32)index, (UInt32*)v);
        }
        internal static void Load_VertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z)
        {
            Delegates.glVertexAttribI3i = (Delegates.VertexAttribI3i)GetExtensionDelegateStatic("glVertexAttribI3i", typeof(Delegates.VertexAttribI3i));
            Delegates.glVertexAttribI3i((UInt32)index, (Int32)x, (Int32)y, (Int32)z);
        }
        internal static unsafe void Load_VertexAttribI3iv(UInt32 index, Int32* v)
        {
            Delegates.glVertexAttribI3iv = (Delegates.VertexAttribI3iv)GetExtensionDelegateStatic("glVertexAttribI3iv", typeof(Delegates.VertexAttribI3iv));
            Delegates.glVertexAttribI3iv((UInt32)index, (Int32*)v);
        }
        internal static void Load_VertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
        {
            Delegates.glVertexAttribI3ui = (Delegates.VertexAttribI3ui)GetExtensionDelegateStatic("glVertexAttribI3ui", typeof(Delegates.VertexAttribI3ui));
            Delegates.glVertexAttribI3ui((UInt32)index, (UInt32)x, (UInt32)y, (UInt32)z);
        }
        internal static unsafe void Load_VertexAttribI3uiv(UInt32 index, UInt32* v)
        {
            Delegates.glVertexAttribI3uiv = (Delegates.VertexAttribI3uiv)GetExtensionDelegateStatic("glVertexAttribI3uiv", typeof(Delegates.VertexAttribI3uiv));
            Delegates.glVertexAttribI3uiv((UInt32)index, (UInt32*)v);
        }
        internal static unsafe void Load_VertexAttribI4bv(UInt32 index, SByte* v)
        {
            Delegates.glVertexAttribI4bv = (Delegates.VertexAttribI4bv)GetExtensionDelegateStatic("glVertexAttribI4bv", typeof(Delegates.VertexAttribI4bv));
            Delegates.glVertexAttribI4bv((UInt32)index, (SByte*)v);
        }
        internal static void Load_VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
        {
            Delegates.glVertexAttribI4i = (Delegates.VertexAttribI4i)GetExtensionDelegateStatic("glVertexAttribI4i", typeof(Delegates.VertexAttribI4i));
            Delegates.glVertexAttribI4i((UInt32)index, (Int32)x, (Int32)y, (Int32)z, (Int32)w);
        }
        internal static unsafe void Load_VertexAttribI4iv(UInt32 index, Int32* v)
        {
            Delegates.glVertexAttribI4iv = (Delegates.VertexAttribI4iv)GetExtensionDelegateStatic("glVertexAttribI4iv", typeof(Delegates.VertexAttribI4iv));
            Delegates.glVertexAttribI4iv((UInt32)index, (Int32*)v);
        }
        internal static unsafe void Load_VertexAttribI4sv(UInt32 index, Int16* v)
        {
            Delegates.glVertexAttribI4sv = (Delegates.VertexAttribI4sv)GetExtensionDelegateStatic("glVertexAttribI4sv", typeof(Delegates.VertexAttribI4sv));
            Delegates.glVertexAttribI4sv((UInt32)index, (Int16*)v);
        }
        internal static unsafe void Load_VertexAttribI4ubv(UInt32 index, Byte* v)
        {
            Delegates.glVertexAttribI4ubv = (Delegates.VertexAttribI4ubv)GetExtensionDelegateStatic("glVertexAttribI4ubv", typeof(Delegates.VertexAttribI4ubv));
            Delegates.glVertexAttribI4ubv((UInt32)index, (Byte*)v);
        }
        internal static void Load_VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
        {
            Delegates.glVertexAttribI4ui = (Delegates.VertexAttribI4ui)GetExtensionDelegateStatic("glVertexAttribI4ui", typeof(Delegates.VertexAttribI4ui));
            Delegates.glVertexAttribI4ui((UInt32)index, (UInt32)x, (UInt32)y, (UInt32)z, (UInt32)w);
        }
        internal static unsafe void Load_VertexAttribI4uiv(UInt32 index, UInt32* v)
        {
            Delegates.glVertexAttribI4uiv = (Delegates.VertexAttribI4uiv)GetExtensionDelegateStatic("glVertexAttribI4uiv", typeof(Delegates.VertexAttribI4uiv));
            Delegates.glVertexAttribI4uiv((UInt32)index, (UInt32*)v);
        }
        internal static unsafe void Load_VertexAttribI4usv(UInt32 index, UInt16* v)
        {
            Delegates.glVertexAttribI4usv = (Delegates.VertexAttribI4usv)GetExtensionDelegateStatic("glVertexAttribI4usv", typeof(Delegates.VertexAttribI4usv));
            Delegates.glVertexAttribI4usv((UInt32)index, (UInt16*)v);
        }
        internal static void Load_VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, UInt32 relativeoffset)
        {
            Delegates.glVertexAttribIFormat = (Delegates.VertexAttribIFormat)GetExtensionDelegateStatic("glVertexAttribIFormat", typeof(Delegates.VertexAttribIFormat));
            Delegates.glVertexAttribIFormat((UInt32)attribindex, (Int32)size, (OpenTK.Graphics.OpenGL4.VertexAttribIntegerType)type, (UInt32)relativeoffset);
        }
        internal static void Load_VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, Int32 stride, IntPtr pointer)
        {
            Delegates.glVertexAttribIPointer = (Delegates.VertexAttribIPointer)GetExtensionDelegateStatic("glVertexAttribIPointer", typeof(Delegates.VertexAttribIPointer));
            Delegates.glVertexAttribIPointer((UInt32)index, (Int32)size, (OpenTK.Graphics.OpenGL4.VertexAttribIntegerType)type, (Int32)stride, (IntPtr)pointer);
        }
        internal static void Load_VertexAttribL1d(UInt32 index, Double x)
        {
            Delegates.glVertexAttribL1d = (Delegates.VertexAttribL1d)GetExtensionDelegateStatic("glVertexAttribL1d", typeof(Delegates.VertexAttribL1d));
            Delegates.glVertexAttribL1d((UInt32)index, (Double)x);
        }
        internal static unsafe void Load_VertexAttribL1dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttribL1dv = (Delegates.VertexAttribL1dv)GetExtensionDelegateStatic("glVertexAttribL1dv", typeof(Delegates.VertexAttribL1dv));
            Delegates.glVertexAttribL1dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttribL1ui64ARB(UInt32 index, UInt64 x)
        {
            Delegates.glVertexAttribL1ui64ARB = (Delegates.VertexAttribL1ui64ARB)GetExtensionDelegateStatic("glVertexAttribL1ui64ARB", typeof(Delegates.VertexAttribL1ui64ARB));
            Delegates.glVertexAttribL1ui64ARB((UInt32)index, (UInt64)x);
        }
        internal static unsafe void Load_VertexAttribL1ui64vARB(UInt32 index, UInt64* v)
        {
            Delegates.glVertexAttribL1ui64vARB = (Delegates.VertexAttribL1ui64vARB)GetExtensionDelegateStatic("glVertexAttribL1ui64vARB", typeof(Delegates.VertexAttribL1ui64vARB));
            Delegates.glVertexAttribL1ui64vARB((UInt32)index, (UInt64*)v);
        }
        internal static void Load_VertexAttribL2d(UInt32 index, Double x, Double y)
        {
            Delegates.glVertexAttribL2d = (Delegates.VertexAttribL2d)GetExtensionDelegateStatic("glVertexAttribL2d", typeof(Delegates.VertexAttribL2d));
            Delegates.glVertexAttribL2d((UInt32)index, (Double)x, (Double)y);
        }
        internal static unsafe void Load_VertexAttribL2dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttribL2dv = (Delegates.VertexAttribL2dv)GetExtensionDelegateStatic("glVertexAttribL2dv", typeof(Delegates.VertexAttribL2dv));
            Delegates.glVertexAttribL2dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttribL3d(UInt32 index, Double x, Double y, Double z)
        {
            Delegates.glVertexAttribL3d = (Delegates.VertexAttribL3d)GetExtensionDelegateStatic("glVertexAttribL3d", typeof(Delegates.VertexAttribL3d));
            Delegates.glVertexAttribL3d((UInt32)index, (Double)x, (Double)y, (Double)z);
        }
        internal static unsafe void Load_VertexAttribL3dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttribL3dv = (Delegates.VertexAttribL3dv)GetExtensionDelegateStatic("glVertexAttribL3dv", typeof(Delegates.VertexAttribL3dv));
            Delegates.glVertexAttribL3dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w)
        {
            Delegates.glVertexAttribL4d = (Delegates.VertexAttribL4d)GetExtensionDelegateStatic("glVertexAttribL4d", typeof(Delegates.VertexAttribL4d));
            Delegates.glVertexAttribL4d((UInt32)index, (Double)x, (Double)y, (Double)z, (Double)w);
        }
        internal static unsafe void Load_VertexAttribL4dv(UInt32 index, Double* v)
        {
            Delegates.glVertexAttribL4dv = (Delegates.VertexAttribL4dv)GetExtensionDelegateStatic("glVertexAttribL4dv", typeof(Delegates.VertexAttribL4dv));
            Delegates.glVertexAttribL4dv((UInt32)index, (Double*)v);
        }
        internal static void Load_VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, UInt32 relativeoffset)
        {
            Delegates.glVertexAttribLFormat = (Delegates.VertexAttribLFormat)GetExtensionDelegateStatic("glVertexAttribLFormat", typeof(Delegates.VertexAttribLFormat));
            Delegates.glVertexAttribLFormat((UInt32)attribindex, (Int32)size, (OpenTK.Graphics.OpenGL4.VertexAttribDoubleType)type, (UInt32)relativeoffset);
        }
        internal static void Load_VertexAttribLPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, Int32 stride, IntPtr pointer)
        {
            Delegates.glVertexAttribLPointer = (Delegates.VertexAttribLPointer)GetExtensionDelegateStatic("glVertexAttribLPointer", typeof(Delegates.VertexAttribLPointer));
            Delegates.glVertexAttribLPointer((UInt32)index, (Int32)size, (OpenTK.Graphics.OpenGL4.VertexAttribDoubleType)type, (Int32)stride, (IntPtr)pointer);
        }
        internal static void Load_VertexAttribP1ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value)
        {
            Delegates.glVertexAttribP1ui = (Delegates.VertexAttribP1ui)GetExtensionDelegateStatic("glVertexAttribP1ui", typeof(Delegates.VertexAttribP1ui));
            Delegates.glVertexAttribP1ui((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32)value);
        }
        internal static unsafe void Load_VertexAttribP1uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value)
        {
            Delegates.glVertexAttribP1uiv = (Delegates.VertexAttribP1uiv)GetExtensionDelegateStatic("glVertexAttribP1uiv", typeof(Delegates.VertexAttribP1uiv));
            Delegates.glVertexAttribP1uiv((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32*)value);
        }
        internal static void Load_VertexAttribP2ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value)
        {
            Delegates.glVertexAttribP2ui = (Delegates.VertexAttribP2ui)GetExtensionDelegateStatic("glVertexAttribP2ui", typeof(Delegates.VertexAttribP2ui));
            Delegates.glVertexAttribP2ui((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32)value);
        }
        internal static unsafe void Load_VertexAttribP2uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value)
        {
            Delegates.glVertexAttribP2uiv = (Delegates.VertexAttribP2uiv)GetExtensionDelegateStatic("glVertexAttribP2uiv", typeof(Delegates.VertexAttribP2uiv));
            Delegates.glVertexAttribP2uiv((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32*)value);
        }
        internal static void Load_VertexAttribP3ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value)
        {
            Delegates.glVertexAttribP3ui = (Delegates.VertexAttribP3ui)GetExtensionDelegateStatic("glVertexAttribP3ui", typeof(Delegates.VertexAttribP3ui));
            Delegates.glVertexAttribP3ui((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32)value);
        }
        internal static unsafe void Load_VertexAttribP3uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value)
        {
            Delegates.glVertexAttribP3uiv = (Delegates.VertexAttribP3uiv)GetExtensionDelegateStatic("glVertexAttribP3uiv", typeof(Delegates.VertexAttribP3uiv));
            Delegates.glVertexAttribP3uiv((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32*)value);
        }
        internal static void Load_VertexAttribP4ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value)
        {
            Delegates.glVertexAttribP4ui = (Delegates.VertexAttribP4ui)GetExtensionDelegateStatic("glVertexAttribP4ui", typeof(Delegates.VertexAttribP4ui));
            Delegates.glVertexAttribP4ui((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32)value);
        }
        internal static unsafe void Load_VertexAttribP4uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value)
        {
            Delegates.glVertexAttribP4uiv = (Delegates.VertexAttribP4uiv)GetExtensionDelegateStatic("glVertexAttribP4uiv", typeof(Delegates.VertexAttribP4uiv));
            Delegates.glVertexAttribP4uiv((UInt32)index, (OpenTK.Graphics.OpenGL4.PackedPointerType)type, (bool)normalized, (UInt32*)value);
        }
        internal static void Load_VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer)
        {
            Delegates.glVertexAttribPointer = (Delegates.VertexAttribPointer)GetExtensionDelegateStatic("glVertexAttribPointer", typeof(Delegates.VertexAttribPointer));
            Delegates.glVertexAttribPointer((UInt32)index, (Int32)size, (OpenTK.Graphics.OpenGL4.VertexAttribPointerType)type, (bool)normalized, (Int32)stride, (IntPtr)pointer);
        }
        internal static void Load_VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor)
        {
            Delegates.glVertexBindingDivisor = (Delegates.VertexBindingDivisor)GetExtensionDelegateStatic("glVertexBindingDivisor", typeof(Delegates.VertexBindingDivisor));
            Delegates.glVertexBindingDivisor((UInt32)bindingindex, (UInt32)divisor);
        }
        internal static void Load_VertexP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value)
        {
            Delegates.glVertexP2ui = (Delegates.VertexP2ui)GetExtensionDelegateStatic("glVertexP2ui", typeof(Delegates.VertexP2ui));
            Delegates.glVertexP2ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)value);
        }
        internal static unsafe void Load_VertexP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value)
        {
            Delegates.glVertexP2uiv = (Delegates.VertexP2uiv)GetExtensionDelegateStatic("glVertexP2uiv", typeof(Delegates.VertexP2uiv));
            Delegates.glVertexP2uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)value);
        }
        internal static void Load_VertexP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value)
        {
            Delegates.glVertexP3ui = (Delegates.VertexP3ui)GetExtensionDelegateStatic("glVertexP3ui", typeof(Delegates.VertexP3ui));
            Delegates.glVertexP3ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)value);
        }
        internal static unsafe void Load_VertexP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value)
        {
            Delegates.glVertexP3uiv = (Delegates.VertexP3uiv)GetExtensionDelegateStatic("glVertexP3uiv", typeof(Delegates.VertexP3uiv));
            Delegates.glVertexP3uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)value);
        }
        internal static void Load_VertexP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value)
        {
            Delegates.glVertexP4ui = (Delegates.VertexP4ui)GetExtensionDelegateStatic("glVertexP4ui", typeof(Delegates.VertexP4ui));
            Delegates.glVertexP4ui((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32)value);
        }
        internal static unsafe void Load_VertexP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value)
        {
            Delegates.glVertexP4uiv = (Delegates.VertexP4uiv)GetExtensionDelegateStatic("glVertexP4uiv", typeof(Delegates.VertexP4uiv));
            Delegates.glVertexP4uiv((OpenTK.Graphics.OpenGL4.PackedPointerType)type, (UInt32*)value);
        }
        internal static void Load_Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glViewport = (Delegates.Viewport)GetExtensionDelegateStatic("glViewport", typeof(Delegates.Viewport));
            Delegates.glViewport((Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static unsafe void Load_ViewportArrayv(UInt32 first, Int32 count, Single* v)
        {
            Delegates.glViewportArrayv = (Delegates.ViewportArrayv)GetExtensionDelegateStatic("glViewportArrayv", typeof(Delegates.ViewportArrayv));
            Delegates.glViewportArrayv((UInt32)first, (Int32)count, (Single*)v);
        }
        internal static void Load_ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h)
        {
            Delegates.glViewportIndexedf = (Delegates.ViewportIndexedf)GetExtensionDelegateStatic("glViewportIndexedf", typeof(Delegates.ViewportIndexedf));
            Delegates.glViewportIndexedf((UInt32)index, (Single)x, (Single)y, (Single)w, (Single)h);
        }
        internal static unsafe void Load_ViewportIndexedfv(UInt32 index, Single* v)
        {
            Delegates.glViewportIndexedfv = (Delegates.ViewportIndexedfv)GetExtensionDelegateStatic("glViewportIndexedfv", typeof(Delegates.ViewportIndexedfv));
            Delegates.glViewportIndexedfv((UInt32)index, (Single*)v);
        }
        internal static OpenTK.Graphics.OpenGL4.WaitSyncStatus Load_WaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags, UInt64 timeout)
        {
            Delegates.glWaitSync = (Delegates.WaitSync)GetExtensionDelegateStatic("glWaitSync", typeof(Delegates.WaitSync));
            return Delegates.glWaitSync((IntPtr)sync, (OpenTK.Graphics.OpenGL4.WaitSyncFlags)flags, (UInt64)timeout);
        }
    }
}
