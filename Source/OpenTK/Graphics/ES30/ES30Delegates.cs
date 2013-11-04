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



namespace OpenTK.Graphics.ES30
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
            internal delegate void ActiveProgramEXT(UInt32 program);
            internal static ActiveProgramEXT glActiveProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgramEXT glActiveShaderProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(OpenTK.Graphics.ES30.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFuncQCOM(OpenTK.Graphics.ES30.All func, Single @ref);
            internal static AlphaFuncQCOM glAlphaFuncQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginPerfMonitorAMD(UInt32 monitor);
            internal static BeginPerfMonitorAMD glBeginPerfMonitorAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQuery(OpenTK.Graphics.ES30.QueryTarget target, UInt32 id);
            internal static BeginQuery glBeginQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryEXT(OpenTK.Graphics.ES30.QueryTarget target, UInt32 id);
            internal static BeginQueryEXT glBeginQueryEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedback(OpenTK.Graphics.ES30.TransformFeedbackPrimitiveType primitiveMode);
            internal static BeginTransformFeedback glBeginTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(OpenTK.Graphics.ES30.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBase(OpenTK.Graphics.ES30.BufferRangeTarget target, UInt32 index, UInt32 buffer);
            internal static BindBufferBase glBindBufferBase;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRange(OpenTK.Graphics.ES30.BufferRangeTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRange glBindBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebuffer(OpenTK.Graphics.ES30.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramPipelineEXT(UInt32 pipeline);
            internal static BindProgramPipelineEXT glBindProgramPipelineEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.ES30.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindSampler(UInt32 unit, UInt32 sampler);
            internal static BindSampler glBindSampler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(OpenTK.Graphics.ES30.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTransformFeedback(OpenTK.Graphics.ES30.TransformFeedbackTarget target, UInt32 id);
            internal static BindTransformFeedback glBindTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArray(UInt32 array);
            internal static BindVertexArray glBindVertexArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArrayOES(UInt32 array);
            internal static BindVertexArrayOES glBindVertexArrayOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendBarrierNV();
            internal static BlendBarrierNV glBlendBarrierNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation(OpenTK.Graphics.ES30.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationEXT(OpenTK.Graphics.ES30.BlendEquationMode mode);
            internal static BlendEquationEXT glBlendEquationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.ES30.BlendEquationMode modeRGB, OpenTK.Graphics.ES30.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(OpenTK.Graphics.ES30.BlendingFactorSrc sfactor, OpenTK.Graphics.ES30.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.ES30.All sfactorRGB, OpenTK.Graphics.ES30.All dfactorRGB, OpenTK.Graphics.ES30.All sfactorAlpha, OpenTK.Graphics.ES30.All dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendParameteriNV(OpenTK.Graphics.ES30.All pname, Int32 value);
            internal static BlendParameteriNV glBlendParameteriNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES30.ClearBufferMask mask, OpenTK.Graphics.ES30.BlitFramebufferFilter filter);
            internal static BlitFramebuffer glBlitFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES30.ClearBufferMask mask, OpenTK.Graphics.ES30.BlitFramebufferFilter filter);
            internal static BlitFramebufferANGLE glBlitFramebufferANGLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebufferNV(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES30.ClearBufferMask mask, OpenTK.Graphics.ES30.BlitFramebufferFilter filter);
            internal static BlitFramebufferNV glBlitFramebufferNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData(OpenTK.Graphics.ES30.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.ES30.BufferUsageHint usage);
            internal static BufferData glBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES30.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.ES30.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(OpenTK.Graphics.ES30.ClearBufferMask mask);
            internal static Clear glClear;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearBufferfi(OpenTK.Graphics.ES30.All buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            internal static ClearBufferfi glClearBufferfi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferfv(OpenTK.Graphics.ES30.All buffer, Int32 drawbuffer, Single* value);
            internal unsafe static ClearBufferfv glClearBufferfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferiv(OpenTK.Graphics.ES30.All buffer, Int32 drawbuffer, Int32* value);
            internal unsafe static ClearBufferiv glClearBufferiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferuiv(OpenTK.Graphics.ES30.All buffer, Int32 drawbuffer, UInt32* value);
            internal unsafe static ClearBufferuiv glClearBufferuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES30.All ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static ClientWaitSync glClientWaitSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES30.All ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static ClientWaitSyncAPPLE glClientWaitSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES30.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3DOES glCompressedTexImage3DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES30.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.All format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3DOES glCompressedTexSubImage3DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyBufferSubData(OpenTK.Graphics.ES30.All readTarget, OpenTK.Graphics.ES30.All writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubData glCopyBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyBufferSubDataNV(OpenTK.Graphics.ES30.All readTarget, OpenTK.Graphics.ES30.All writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubDataNV glCopyBufferSubDataNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES30.TextureCopyComponentCount internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3DOES glCopyTexSubImage3DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            internal static CopyTextureLevelsAPPLE glCopyTextureLevelsAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CoverageMaskNV(bool mask);
            internal static CoverageMaskNV glCoverageMaskNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CoverageOperationNV(OpenTK.Graphics.ES30.All operation);
            internal static CoverageOperationNV glCoverageOperationNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader(OpenTK.Graphics.ES30.ShaderType type);
            internal static CreateShader glCreateShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramEXT(OpenTK.Graphics.ES30.All type, String @string);
            internal static CreateShaderProgramEXT glCreateShaderProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramvEXT(OpenTK.Graphics.ES30.All type, Int32 count, String[] strings);
            internal static CreateShaderProgramvEXT glCreateShaderProgramvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(OpenTK.Graphics.ES30.CullFaceMode mode);
            internal static CullFace glCullFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            internal static DebugMessageCallback glDebugMessageCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            internal static DebugMessageCallbackKHR glDebugMessageCallbackKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageControl(OpenTK.Graphics.ES30.All source, OpenTK.Graphics.ES30.All type, OpenTK.Graphics.ES30.All severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControl glDebugMessageControl;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageControlKHR(OpenTK.Graphics.ES30.All source, OpenTK.Graphics.ES30.All type, OpenTK.Graphics.ES30.All severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlKHR glDebugMessageControlKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsert(OpenTK.Graphics.ES30.All source, OpenTK.Graphics.ES30.All type, UInt32 id, OpenTK.Graphics.ES30.All severity, Int32 length, String buf);
            internal static DebugMessageInsert glDebugMessageInsert;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsertKHR(OpenTK.Graphics.ES30.All source, OpenTK.Graphics.ES30.All type, UInt32 id, OpenTK.Graphics.ES30.All severity, Int32 length, String buf);
            internal static DebugMessageInsertKHR glDebugMessageInsertKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeletePerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            internal unsafe static DeletePerfMonitorsAMD glDeletePerfMonitorsAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelinesEXT glDeleteProgramPipelinesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueriesEXT(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueriesEXT glDeleteQueriesEXT;
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
            internal delegate void DeleteSyncAPPLE(IntPtr sync);
            internal static DeleteSyncAPPLE glDeleteSyncAPPLE;
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
            internal unsafe delegate void DeleteVertexArraysOES(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysOES glDeleteVertexArraysOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc(OpenTK.Graphics.ES30.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(OpenTK.Graphics.ES30.EnableCap cap);
            internal static Disable glDisable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableDriverControlQCOM(UInt32 driverControl);
            internal static DisableDriverControlQCOM glDisableDriverControlQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DiscardFramebufferEXT(OpenTK.Graphics.ES30.All target, Int32 numAttachments, OpenTK.Graphics.ES30.All* attachments);
            internal unsafe static DiscardFramebufferEXT glDiscardFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays1(OpenTK.Graphics.ES30.BeginMode mode, Int32 first, Int32 count);
            internal static DrawArrays1 glDrawArrays1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstanced(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount);
            internal static DrawArraysInstanced glDrawArraysInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedANGLE(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedANGLE glDrawArraysInstancedANGLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 start, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedNV(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedNV glDrawArraysInstancedNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffers(Int32 n, OpenTK.Graphics.ES30.All* bufs);
            internal unsafe static DrawBuffers glDrawBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersEXT(Int32 n, OpenTK.Graphics.ES30.All* bufs);
            internal unsafe static DrawBuffersEXT glDrawBuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersIndexedEXT(Int32 n, OpenTK.Graphics.ES30.All* location, Int32* indices);
            internal unsafe static DrawBuffersIndexedEXT glDrawBuffersIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersNV(Int32 n, OpenTK.Graphics.ES30.All* bufs);
            internal unsafe static DrawBuffersNV glDrawBuffersNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements1(OpenTK.Graphics.ES30.BeginMode mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices);
            internal static DrawElements1 glDrawElements1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstanced(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 instancecount);
            internal static DrawElementsInstanced glDrawElementsInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedANGLE(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.All type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedANGLE glDrawElementsInstancedANGLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedNV(OpenTK.Graphics.ES30.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES30.All type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedNV glDrawElementsInstancedNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElements(OpenTK.Graphics.ES30.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES30.All target, IntPtr image);
            internal static EGLImageTargetRenderbufferStorageOES glEGLImageTargetRenderbufferStorageOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES30.All target, IntPtr image);
            internal static EGLImageTargetTexture2DOES glEGLImageTargetTexture2DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(OpenTK.Graphics.ES30.EnableCap cap);
            internal static Enable glEnable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableDriverControlQCOM(UInt32 driverControl);
            internal static EnableDriverControlQCOM glEnableDriverControlQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndPerfMonitorAMD(UInt32 monitor);
            internal static EndPerfMonitorAMD glEndPerfMonitorAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQuery(OpenTK.Graphics.ES30.QueryTarget target);
            internal static EndQuery glEndQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryEXT(OpenTK.Graphics.ES30.QueryTarget target);
            internal static EndQueryEXT glEndQueryEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTilingQCOM(UInt32 preserveMask);
            internal static EndTilingQCOM glEndTilingQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedback();
            internal static EndTransformFeedback glEndTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES30.All target, [OutAttribute] IntPtr @params);
            internal static ExtGetBufferPointervQCOM glExtGetBufferPointervQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            internal unsafe static ExtGetBuffersQCOM glExtGetBuffersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            internal unsafe static ExtGetFramebuffersQCOM glExtGetFramebuffersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES30.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
            internal unsafe static ExtGetProgramBinarySourceQCOM glExtGetProgramBinarySourceQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
            internal unsafe static ExtGetProgramsQCOM glExtGetProgramsQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
            internal unsafe static ExtGetRenderbuffersQCOM glExtGetRenderbuffersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
            internal unsafe static ExtGetShadersQCOM glExtGetShadersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES30.All face, Int32 level, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static ExtGetTexLevelParameterivQCOM glExtGetTexLevelParameterivQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES30.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.All format, OpenTK.Graphics.ES30.All type, [OutAttribute] IntPtr texels);
            internal static ExtGetTexSubImageQCOM glExtGetTexSubImageQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            internal unsafe static ExtGetTexturesQCOM glExtGetTexturesQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool ExtIsProgramBinaryQCOM(UInt32 program);
            internal static ExtIsProgramBinaryQCOM glExtIsProgramBinaryQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All pname, Int32 param);
            internal static ExtTexObjectStateOverrideiQCOM glExtTexObjectStateOverrideiQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr FenceSync(OpenTK.Graphics.ES30.All condition, UInt32 flags);
            internal static FenceSync glFenceSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES30.All condition, UInt32 flags);
            internal static FenceSyncAPPLE glFenceSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRange(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRange glFlushMappedBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRangeEXT glFlushMappedBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.FramebufferSlot attachment, OpenTK.Graphics.ES30.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.FramebufferSlot attachment, OpenTK.Graphics.ES30.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All attachment, OpenTK.Graphics.ES30.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleEXT glFramebufferTexture2DMultisampleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All attachment, OpenTK.Graphics.ES30.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleIMG glFramebufferTexture2DMultisampleIMG;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3DOES(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All attachment, OpenTK.Graphics.ES30.All textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3DOES glFramebufferTexture3DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayer(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.All attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayer glFramebufferTextureLayer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(OpenTK.Graphics.ES30.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmap(OpenTK.Graphics.ES30.TextureTarget target);
            internal static GenerateMipmap glGenerateMipmap;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenPerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            internal unsafe static GenPerfMonitorsAMD glGenPerfMonitorsAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramPipelinesEXT(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelinesEXT glGenProgramPipelinesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueries glGenQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueriesEXT(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueriesEXT glGenQueriesEXT;
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
            internal unsafe delegate void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysOES glGenVertexArraysOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES30.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES30.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.ES30.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.ES30.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteri64v(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferParameterName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointerv(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointervOES(OpenTK.Graphics.ES30.BufferTarget target, OpenTK.Graphics.ES30.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervOES glGetBufferPointervOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES30.All* sources, [OutAttribute] OpenTK.Graphics.ES30.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES30.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLog glGetDebugMessageLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES30.All* sources, [OutAttribute] OpenTK.Graphics.ES30.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES30.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogKHR glGetDebugMessageLogKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            internal unsafe static GetDriverControlsQCOM glGetDriverControlsQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            internal unsafe static GetDriverControlStringQCOM glGetDriverControlStringQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES30.ErrorCode GetError();
            internal static GetError glGetError;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocation(UInt32 program, String name);
            internal static GetFragDataLocation glGetFragDataLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.ES30.FramebufferTarget target, OpenTK.Graphics.ES30.FramebufferSlot attachment, OpenTK.Graphics.ES30.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES30.All GetGraphicsResetStatusEXT();
            internal static GetGraphicsResetStatusEXT glGetGraphicsResetStatusEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64i_v(OpenTK.Graphics.ES30.All target, UInt32 index, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64i_v glGetInteger64i_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64v(OpenTK.Graphics.ES30.All pname, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64v glGetInteger64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64vAPPLE(OpenTK.Graphics.ES30.All pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64vAPPLE glGetInteger64vAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegeri_v(OpenTK.Graphics.ES30.All target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_v glGetIntegeri_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegeri_vEXT(OpenTK.Graphics.ES30.All target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_vEXT glGetIntegeri_vEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.ES30.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInternalformativ(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All internalformat, OpenTK.Graphics.ES30.All pname, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetInternalformativ glGetInternalformativ;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvEXT glGetnUniformfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivEXT glGetnUniformivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectLabel(OpenTK.Graphics.ES30.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabel glGetObjectLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectLabelEXT(OpenTK.Graphics.ES30.All type, UInt32 @object, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelEXT glGetObjectLabelEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectLabelKHR(OpenTK.Graphics.ES30.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelKHR glGetObjectLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabel glGetObjectPtrLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabelKHR glGetObjectPtrLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCounterDataAMD(UInt32 monitor, OpenTK.Graphics.ES30.All pname, Int32 dataSize, [OutAttribute] UInt32* data, [OutAttribute] Int32* bytesWritten);
            internal unsafe static GetPerfMonitorCounterDataAMD glGetPerfMonitorCounterDataAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, OpenTK.Graphics.ES30.All pname, [OutAttribute] IntPtr data);
            internal static GetPerfMonitorCounterInfoAMD glGetPerfMonitorCounterInfoAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCountersAMD(UInt32 group, [OutAttribute] Int32* numCounters, [OutAttribute] Int32* maxActiveCounters, Int32 counterSize, [OutAttribute] UInt32* counters);
            internal unsafe static GetPerfMonitorCountersAMD glGetPerfMonitorCountersAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder counterString);
            internal unsafe static GetPerfMonitorCounterStringAMD glGetPerfMonitorCounterStringAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups, Int32 groupsSize, [OutAttribute] UInt32* groups);
            internal unsafe static GetPerfMonitorGroupsAMD glGetPerfMonitorGroupsAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder groupString);
            internal unsafe static GetPerfMonitorGroupStringAMD glGetPerfMonitorGroupStringAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerv(OpenTK.Graphics.ES30.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointervKHR(OpenTK.Graphics.ES30.All pname, [OutAttribute] IntPtr @params);
            internal static GetPointervKHR glGetPointervKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.ES30.All* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinary glGetProgramBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramBinaryOES(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.ES30.All* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinaryOES glGetProgramBinaryOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.ES30.ProgramParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLogEXT glGetProgramPipelineInfoLogEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineivEXT(UInt32 pipeline, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineivEXT glGetProgramPipelineivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryiv(OpenTK.Graphics.ES30.QueryTarget target, OpenTK.Graphics.ES30.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryivEXT(OpenTK.Graphics.ES30.QueryTarget target, OpenTK.Graphics.ES30.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryivEXT glGetQueryivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectivEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectivEXT glGetQueryObjectivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuivEXT(UInt32 id, OpenTK.Graphics.ES30.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuivEXT glGetQueryObjectuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.ES30.RenderbufferTarget target, OpenTK.Graphics.ES30.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.ES30.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.ES30.ShaderType shadertype, OpenTK.Graphics.ES30.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(OpenTK.Graphics.ES30.StringName name);
            internal static GetString glGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetStringi(OpenTK.Graphics.ES30.StringName name, UInt32 index);
            internal static GetStringi glGetStringi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSynciv(IntPtr sync, OpenTK.Graphics.ES30.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSynciv glGetSynciv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES30.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSyncivAPPLE glGetSyncivAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.GetTextureParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.GetTextureParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES30.TransformFeedbackType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetTranslatedShaderSourceANGLE glGetTranslatedShaderSourceANGLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            internal static GetUniformBlockIndex glGetUniformBlockIndex;
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
            internal unsafe delegate void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuiv glGetUniformuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.ES30.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.ES30.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.ES30.All pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.ES30.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.ES30.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(OpenTK.Graphics.ES30.HintTarget target, OpenTK.Graphics.ES30.HintMode mode);
            internal static Hint glHint;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InsertEventMarkerEXT(Int32 length, String marker);
            internal static InsertEventMarkerEXT glInsertEventMarkerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InvalidateFramebuffer(OpenTK.Graphics.ES30.All target, Int32 numAttachments, OpenTK.Graphics.ES30.All* attachments);
            internal unsafe static InvalidateFramebuffer glInvalidateFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InvalidateSubFramebuffer(OpenTK.Graphics.ES30.All target, Int32 numAttachments, OpenTK.Graphics.ES30.All* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            internal unsafe static InvalidateSubFramebuffer glInvalidateSubFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled(OpenTK.Graphics.ES30.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramPipelineEXT(UInt32 pipeline);
            internal static IsProgramPipelineEXT glIsProgramPipelineEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsQuery(UInt32 id);
            internal static IsQuery glIsQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsQueryEXT(UInt32 id);
            internal static IsQueryEXT glIsQueryEXT;
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
            internal delegate bool IsSyncAPPLE(IntPtr sync);
            internal static IsSyncAPPLE glIsSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTransformFeedback(UInt32 id);
            internal static IsTransformFeedback glIsTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArray(UInt32 array);
            internal static IsVertexArray glIsVertexArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArrayOES(UInt32 array);
            internal static IsVertexArrayOES glIsVertexArrayOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LabelObjectEXT(OpenTK.Graphics.ES30.All type, UInt32 @object, Int32 length, String label);
            internal static LabelObjectEXT glLabelObjectEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBufferOES(OpenTK.Graphics.ES30.All target, OpenTK.Graphics.ES30.All access);
            internal static MapBufferOES glMapBufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBufferRange(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.ES30.BufferAccessMask access);
            internal static MapBufferRange glMapBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES30.BufferTarget target, IntPtr offset, IntPtr length, UInt32 access);
            internal static MapBufferRangeEXT glMapBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArraysEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsEXT(OpenTK.Graphics.ES30.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES30.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectLabel(OpenTK.Graphics.ES30.All identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabel glObjectLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectLabelKHR(OpenTK.Graphics.ES30.All identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabelKHR glObjectLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabel glObjectPtrLabel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabelKHR glObjectPtrLabelKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PauseTransformFeedback();
            internal static PauseTransformFeedback glPauseTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(OpenTK.Graphics.ES30.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
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
            internal delegate void PopGroupMarkerEXT();
            internal static PopGroupMarkerEXT glPopGroupMarkerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramBinary(UInt32 program, OpenTK.Graphics.ES30.All binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinary glProgramBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramBinaryOES(UInt32 program, OpenTK.Graphics.ES30.All binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinaryOES glProgramBinaryOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteri(UInt32 program, OpenTK.Graphics.ES30.ProgramParameterName pname, Int32 value);
            internal static ProgramParameteri glProgramParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriEXT(UInt32 program, OpenTK.Graphics.ES30.ProgramParameterName pname, Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1fEXT(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1fEXT glProgramUniform1fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fvEXT glProgramUniform1fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1iEXT glProgramUniform1iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1ivEXT glProgramUniform1ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1uiEXT glProgramUniform1uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uivEXT glProgramUniform1uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2fEXT(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2fEXT glProgramUniform2fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fvEXT glProgramUniform2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2iEXT glProgramUniform2iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2ivEXT glProgramUniform2ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2uiEXT glProgramUniform2uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uivEXT glProgramUniform2uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3fEXT glProgramUniform3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fvEXT glProgramUniform3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3iEXT glProgramUniform3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3ivEXT glProgramUniform3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3uiEXT glProgramUniform3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uivEXT glProgramUniform3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4fEXT glProgramUniform4fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fvEXT glProgramUniform4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4iEXT glProgramUniform4iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4ivEXT glProgramUniform4ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4uiEXT glProgramUniform4uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uivEXT glProgramUniform4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fvEXT glProgramUniformMatrix2x3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fvEXT glProgramUniformMatrix2x4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fvEXT glProgramUniformMatrix3x2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fvEXT glProgramUniformMatrix3x4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fvEXT glProgramUniformMatrix4x2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fvEXT glProgramUniformMatrix4x3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushDebugGroup(OpenTK.Graphics.ES30.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroup glPushDebugGroup;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushDebugGroupKHR(OpenTK.Graphics.ES30.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroupKHR glPushDebugGroupKHR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushGroupMarkerEXT(Int32 length, String marker);
            internal static PushGroupMarkerEXT glPushGroupMarkerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryCounterEXT(UInt32 id, OpenTK.Graphics.ES30.All target);
            internal static QueryCounterEXT glQueryCounterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBuffer(OpenTK.Graphics.ES30.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBufferIndexedEXT(OpenTK.Graphics.ES30.All src, Int32 index);
            internal static ReadBufferIndexedEXT glReadBufferIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBufferNV(OpenTK.Graphics.ES30.All mode);
            internal static ReadBufferNV glReadBufferNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES30.All format, OpenTK.Graphics.ES30.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsEXT glReadnPixelsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.ES30.RenderbufferTarget target, OpenTK.Graphics.ES30.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisample(OpenTK.Graphics.ES30.All target, Int32 samples, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleANGLE(OpenTK.Graphics.ES30.All target, Int32 samples, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleANGLE glRenderbufferStorageMultisampleANGLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES30.All target, Int32 samples, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleAPPLE glRenderbufferStorageMultisampleAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES30.All target, Int32 samples, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES30.All target, Int32 samples, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleIMG glRenderbufferStorageMultisampleIMG;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleNV(OpenTK.Graphics.ES30.All target, Int32 samples, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleNV glRenderbufferStorageMultisampleNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResolveMultisampleFramebufferAPPLE();
            internal static ResolveMultisampleFramebufferAPPLE glResolveMultisampleFramebufferAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResumeTransformFeedback();
            internal static ResumeTransformFeedback glResumeTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameterf(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Single param);
            internal static SamplerParameterf glSamplerParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Single* param);
            internal unsafe static SamplerParameterfv glSamplerParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameteri(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Int32 param);
            internal static SamplerParameteri glSamplerParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.ES30.SamplerParameterName pname, Int32* param);
            internal unsafe static SamplerParameteriv glSamplerParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, [OutAttribute] UInt32* counterList);
            internal unsafe static SelectPerfMonitorCountersAMD glSelectPerfMonitorCountersAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES30.All condition);
            internal static SetFenceNV glSetFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.ES30.ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            internal static StartTilingQCOM glStartTilingQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(OpenTK.Graphics.ES30.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.ES30.StencilFace face, OpenTK.Graphics.ES30.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate1(OpenTK.Graphics.ES30.StencilFace face, OpenTK.Graphics.ES30.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate1 glStencilFuncSeparate1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.ES30.CullFaceMode face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(OpenTK.Graphics.ES30.StencilOp fail, OpenTK.Graphics.ES30.StencilOp zfail, OpenTK.Graphics.ES30.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.ES30.StencilFace face, OpenTK.Graphics.ES30.StencilOp sfail, OpenTK.Graphics.ES30.StencilOp dpfail, OpenTK.Graphics.ES30.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate1(OpenTK.Graphics.ES30.StencilFace face, OpenTK.Graphics.ES30.StencilOp sfail, OpenTK.Graphics.ES30.StencilOp dpfail, OpenTK.Graphics.ES30.StencilOp dppass);
            internal static StencilOpSeparate1 glStencilOpSeparate1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES30.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexImage3D glTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES30.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexImage3DOES glTexImage3DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.ES30.TextureTarget target, OpenTK.Graphics.ES30.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage1DEXT(OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width);
            internal static TexStorage1DEXT glTexStorage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2D glTexStorage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage2DEXT(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2DEXT glTexStorage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage3D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3D glTexStorage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage3DEXT(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES30.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3DEXT glTexStorage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D(OpenTK.Graphics.ES30.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3D(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.PixelFormat format, OpenTK.Graphics.ES30.PixelType type, IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3DOES(OpenTK.Graphics.ES30.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES30.All format, OpenTK.Graphics.ES30.All type, IntPtr pixels);
            internal static TexSubImage3DOES glTexSubImage3DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width);
            internal static TextureStorage1DEXT glTextureStorage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height);
            internal static TextureStorage2DEXT glTextureStorage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES30.All target, Int32 levels, OpenTK.Graphics.ES30.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TextureStorage3DEXT glTextureStorage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.ES30.TransformFeedbackMode bufferMode);
            internal static TransformFeedbackVaryings glTransformFeedbackVaryings;
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
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fvNV glUniformMatrix2x3fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fvNV glUniformMatrix2x4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fvNV glUniformMatrix3x2fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fvNV glUniformMatrix3x4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fvNV glUniformMatrix4x2fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fvNV glUniformMatrix4x3fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBuffer(OpenTK.Graphics.ES30.BufferTarget target);
            internal static UnmapBuffer glUnmapBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBufferOES(OpenTK.Graphics.ES30.BufferTarget target);
            internal static UnmapBufferOES glUnmapBufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);
            internal static UseProgramStagesEXT glUseProgramStagesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseShaderProgramEXT(OpenTK.Graphics.ES30.All type, UInt32 program);
            internal static UseShaderProgramEXT glUseShaderProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramPipelineEXT(UInt32 pipeline);
            internal static ValidateProgramPipelineEXT glValidateProgramPipelineEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisor glVertexAttribDivisor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisorANGLE(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorANGLE glVertexAttribDivisorANGLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisorEXT(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorEXT glVertexAttribDivisorEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisorNV(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorNV glVertexAttribDivisorNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4i glVertexAttribI4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4iv glVertexAttribI4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4ui glVertexAttribI4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.ES30.VertexAttribIntegerType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointer glVertexAttribIPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.ES30.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static WaitSync glWaitSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static WaitSyncAPPLE glWaitSyncAPPLE;
        }
    }
}
