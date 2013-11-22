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



namespace OpenTK.Graphics.ES20
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
            internal delegate void ActiveProgramEXT(UInt32 program);
            internal static ActiveProgramEXT glActiveProgramEXT = Load_ActiveProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgramEXT glActiveShaderProgramEXT = Load_ActiveShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveTexture(OpenTK.Graphics.ES20.TextureUnit texture);
            internal static ActiveTexture glActiveTexture = Load_ActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFuncQCOM(OpenTK.Graphics.ES20.All func, Single @ref);
            internal static AlphaFuncQCOM glAlphaFuncQCOM = Load_AlphaFuncQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader = Load_AttachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginPerfMonitorAMD(UInt32 monitor);
            internal static BeginPerfMonitorAMD glBeginPerfMonitorAMD = Load_BeginPerfMonitorAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginQueryEXT(OpenTK.Graphics.ES20.QueryTarget target, UInt32 id);
            internal static BeginQueryEXT glBeginQueryEXT = Load_BeginQueryEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation = Load_BindAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBuffer(OpenTK.Graphics.ES20.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer = Load_BindBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFramebuffer(OpenTK.Graphics.ES20.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer = Load_BindFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindProgramPipelineEXT(UInt32 pipeline);
            internal static BindProgramPipelineEXT glBindProgramPipelineEXT = Load_BindProgramPipelineEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.ES20.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer = Load_BindRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTexture(OpenTK.Graphics.ES20.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture = Load_BindTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexArrayOES(UInt32 array);
            internal static BindVertexArrayOES glBindVertexArrayOES = Load_BindVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendBarrierNV();
            internal static BlendBarrierNV glBlendBarrierNV = Load_BlendBarrierNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor = Load_BlendColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquation(OpenTK.Graphics.ES20.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation = Load_BlendEquation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationEXT(OpenTK.Graphics.ES20.BlendEquationMode mode);
            internal static BlendEquationEXT glBlendEquationEXT = Load_BlendEquationEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.ES20.BlendEquationMode modeRGB, OpenTK.Graphics.ES20.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate = Load_BlendEquationSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunc(OpenTK.Graphics.ES20.BlendingFactorSrc sfactor, OpenTK.Graphics.ES20.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc = Load_BlendFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.ES20.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.ES20.BlendingFactorDest dfactorRGB, OpenTK.Graphics.ES20.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.ES20.BlendingFactorDest dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate = Load_BlendFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendParameteriNV(OpenTK.Graphics.ES20.All pname, Int32 value);
            internal static BlendParameteriNV glBlendParameteriNV = Load_BlendParameteriNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES20.ClearBufferMask mask, OpenTK.Graphics.ES20.BlitFramebufferFilter filter);
            internal static BlitFramebufferANGLE glBlitFramebufferANGLE = Load_BlitFramebufferANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlitFramebufferNV(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES20.ClearBufferMask mask, OpenTK.Graphics.ES20.BlitFramebufferFilter filter);
            internal static BlitFramebufferNV glBlitFramebufferNV = Load_BlitFramebufferNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.ES20.BufferUsageHint usage);
            internal static BufferData glBufferData = Load_BufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferSubData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData = Load_BufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES20.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.ES20.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus = Load_CheckFramebufferStatus;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Clear(OpenTK.Graphics.ES20.ClearBufferMask mask);
            internal static Clear glClear = Load_Clear;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor = Load_ClearColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf = Load_ClearDepthf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil = Load_ClearStencil;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES20.WaitSyncStatus ClientWaitSyncAPPLE(IntPtr sync, OpenTK.Graphics.ES20.ClientWaitSyncFlags flags, UInt64 timeout);
            internal static ClientWaitSyncAPPLE glClientWaitSyncAPPLE = Load_ClientWaitSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask = Load_ColorMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader = Load_CompileShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES20.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D = Load_CompressedTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES20.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3DOES glCompressedTexImage3DOES = Load_CompressedTexImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D = Load_CompressedTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3DOES glCompressedTexSubImage3DOES = Load_CompressedTexSubImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyBufferSubDataNV(OpenTK.Graphics.ES20.BufferTarget readTarget, OpenTK.Graphics.ES20.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubDataNV glCopyBufferSubDataNV = Load_CopyBufferSubDataNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES20.TextureCopyComponentCount internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D = Load_CopyTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D = Load_CopyTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3DOES glCopyTexSubImage3DOES = Load_CopyTexSubImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            internal static CopyTextureLevelsAPPLE glCopyTextureLevelsAPPLE = Load_CopyTextureLevelsAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CoverageMaskNV(bool mask);
            internal static CoverageMaskNV glCoverageMaskNV = Load_CoverageMaskNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CoverageOperationNV(OpenTK.Graphics.ES20.All operation);
            internal static CoverageOperationNV glCoverageOperationNV = Load_CoverageOperationNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram = Load_CreateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShader(OpenTK.Graphics.ES20.ShaderType type);
            internal static CreateShader glCreateShader = Load_CreateShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShaderProgramEXT(OpenTK.Graphics.ES20.All type, String @string);
            internal static CreateShaderProgramEXT glCreateShaderProgramEXT = Load_CreateShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShaderProgramvEXT(OpenTK.Graphics.ES20.All type, Int32 count, String[] strings);
            internal static CreateShaderProgramvEXT glCreateShaderProgramvEXT = Load_CreateShaderProgramvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CullFace(OpenTK.Graphics.ES20.CullFaceMode mode);
            internal static CullFace glCullFace = Load_CullFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            internal static DebugMessageCallback glDebugMessageCallback = Load_DebugMessageCallback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            internal static DebugMessageCallbackKHR glDebugMessageCallbackKHR = Load_DebugMessageCallbackKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControl(OpenTK.Graphics.ES20.DebugSourceControl source, OpenTK.Graphics.ES20.DebugTypeControl type, OpenTK.Graphics.ES20.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControl glDebugMessageControl = Load_DebugMessageControl;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControlKHR(OpenTK.Graphics.ES20.DebugSourceControl source, OpenTK.Graphics.ES20.DebugTypeControl type, OpenTK.Graphics.ES20.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlKHR glDebugMessageControlKHR = Load_DebugMessageControlKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsert(OpenTK.Graphics.ES20.DebugSourceExternal source, OpenTK.Graphics.ES20.DebugType type, UInt32 id, OpenTK.Graphics.ES20.DebugSeverity severity, Int32 length, String buf);
            internal static DebugMessageInsert glDebugMessageInsert = Load_DebugMessageInsert;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsertKHR(OpenTK.Graphics.ES20.DebugSourceExternal source, OpenTK.Graphics.ES20.DebugType type, UInt32 id, OpenTK.Graphics.ES20.DebugSeverity severity, Int32 length, String buf);
            internal static DebugMessageInsertKHR glDebugMessageInsertKHR = Load_DebugMessageInsertKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers = Load_DeleteBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV = Load_DeleteFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers = Load_DeleteFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeletePerfMonitorsAMD(Int32 n, UInt32* monitors);
            internal unsafe static DeletePerfMonitorsAMD glDeletePerfMonitorsAMD = Load_DeletePerfMonitorsAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram = Load_DeleteProgram;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelinesEXT glDeleteProgramPipelinesEXT = Load_DeleteProgramPipelinesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteQueriesEXT(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueriesEXT glDeleteQueriesEXT = Load_DeleteQueriesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers = Load_DeleteRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader = Load_DeleteShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteSyncAPPLE(IntPtr sync);
            internal static DeleteSyncAPPLE glDeleteSyncAPPLE = Load_DeleteSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures = Load_DeleteTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteVertexArraysOES(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysOES glDeleteVertexArraysOES = Load_DeleteVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthFunc(OpenTK.Graphics.ES20.DepthFunction func);
            internal static DepthFunc glDepthFunc = Load_DepthFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask = Load_DepthMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef = Load_DepthRangef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader = Load_DetachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disable(OpenTK.Graphics.ES20.EnableCap cap);
            internal static Disable glDisable = Load_Disable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableDriverControlQCOM(UInt32 driverControl);
            internal static DisableDriverControlQCOM glDisableDriverControlQCOM = Load_DisableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray = Load_DisableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DiscardFramebufferEXT(OpenTK.Graphics.ES20.All target, Int32 numAttachments, OpenTK.Graphics.ES20.All* attachments);
            internal unsafe static DiscardFramebufferEXT glDiscardFramebufferEXT = Load_DiscardFramebufferEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArrays(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays = Load_DrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedANGLE(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedANGLE glDrawArraysInstancedANGLE = Load_DrawArraysInstancedANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 start, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT = Load_DrawArraysInstancedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedNV(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedNV glDrawArraysInstancedNV = Load_DrawArraysInstancedNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffersEXT(Int32 n, OpenTK.Graphics.ES20.DrawBufferMode* bufs);
            internal unsafe static DrawBuffersEXT glDrawBuffersEXT = Load_DrawBuffersEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffersIndexedEXT(Int32 n, OpenTK.Graphics.ES20.All* location, Int32* indices);
            internal unsafe static DrawBuffersIndexedEXT glDrawBuffersIndexedEXT = Load_DrawBuffersIndexedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffersNV(Int32 n, OpenTK.Graphics.ES20.DrawBufferMode* bufs);
            internal unsafe static DrawBuffersNV glDrawBuffersNV = Load_DrawBuffersNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElements(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements = Load_DrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedANGLE(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedANGLE glDrawElementsInstancedANGLE = Load_DrawElementsInstancedANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT = Load_DrawElementsInstancedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedNV(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedNV glDrawElementsInstancedNV = Load_DrawElementsInstancedNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES20.All target, IntPtr image);
            internal static EGLImageTargetRenderbufferStorageOES glEGLImageTargetRenderbufferStorageOES = Load_EGLImageTargetRenderbufferStorageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES20.All target, IntPtr image);
            internal static EGLImageTargetTexture2DOES glEGLImageTargetTexture2DOES = Load_EGLImageTargetTexture2DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enable(OpenTK.Graphics.ES20.EnableCap cap);
            internal static Enable glEnable = Load_Enable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableDriverControlQCOM(UInt32 driverControl);
            internal static EnableDriverControlQCOM glEnableDriverControlQCOM = Load_EnableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray = Load_EnableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndPerfMonitorAMD(UInt32 monitor);
            internal static EndPerfMonitorAMD glEndPerfMonitorAMD = Load_EndPerfMonitorAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndQueryEXT(OpenTK.Graphics.ES20.QueryTarget target);
            internal static EndQueryEXT glEndQueryEXT = Load_EndQueryEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndTilingQCOM(UInt32 preserveMask);
            internal static EndTilingQCOM glEndTilingQCOM = Load_EndTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES20.All target, [OutAttribute] IntPtr @params);
            internal static ExtGetBufferPointervQCOM glExtGetBufferPointervQCOM = Load_ExtGetBufferPointervQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            internal unsafe static ExtGetBuffersQCOM glExtGetBuffersQCOM = Load_ExtGetBuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            internal unsafe static ExtGetFramebuffersQCOM glExtGetFramebuffersQCOM = Load_ExtGetFramebuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES20.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
            internal unsafe static ExtGetProgramBinarySourceQCOM glExtGetProgramBinarySourceQCOM = Load_ExtGetProgramBinarySourceQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
            internal unsafe static ExtGetProgramsQCOM glExtGetProgramsQCOM = Load_ExtGetProgramsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
            internal unsafe static ExtGetRenderbuffersQCOM glExtGetRenderbuffersQCOM = Load_ExtGetRenderbuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
            internal unsafe static ExtGetShadersQCOM glExtGetShadersQCOM = Load_ExtGetShadersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES20.All face, Int32 level, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            internal unsafe static ExtGetTexLevelParameterivQCOM glExtGetTexLevelParameterivQCOM = Load_ExtGetTexLevelParameterivQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES20.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, [OutAttribute] IntPtr texels);
            internal static ExtGetTexSubImageQCOM glExtGetTexSubImageQCOM = Load_ExtGetTexSubImageQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            internal unsafe static ExtGetTexturesQCOM glExtGetTexturesQCOM = Load_ExtGetTexturesQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool ExtIsProgramBinaryQCOM(UInt32 program);
            internal static ExtIsProgramBinaryQCOM glExtIsProgramBinaryQCOM = Load_ExtIsProgramBinaryQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All pname, Int32 param);
            internal static ExtTexObjectStateOverrideiQCOM glExtTexObjectStateOverrideiQCOM = Load_ExtTexObjectStateOverrideiQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES20.SyncCondition condition, OpenTK.Graphics.ES20.WaitSyncFlags flags);
            internal static FenceSyncAPPLE glFenceSyncAPPLE = Load_FenceSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Finish();
            internal static Finish glFinish = Load_Finish;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV = Load_FinishFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Flush();
            internal static Flush glFlush = Load_Flush;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRangeEXT glFlushMappedBufferRangeEXT = Load_FlushMappedBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer = Load_FramebufferRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.TextureTarget2d textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D = Load_FramebufferTexture2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleEXT glFramebufferTexture2DMultisampleEXT = Load_FramebufferTexture2DMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleIMG glFramebufferTexture2DMultisampleIMG = Load_FramebufferTexture2DMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture3DOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3DOES glFramebufferTexture3DOES = Load_FramebufferTexture3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrontFace(OpenTK.Graphics.ES20.FrontFaceDirection mode);
            internal static FrontFace glFrontFace = Load_FrontFace;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers = Load_GenBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GenerateMipmap(OpenTK.Graphics.ES20.TextureTarget target);
            internal static GenerateMipmap glGenerateMipmap = Load_GenerateMipmap;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV = Load_GenFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers = Load_GenFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenPerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            internal unsafe static GenPerfMonitorsAMD glGenPerfMonitorsAMD = Load_GenPerfMonitorsAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenProgramPipelinesEXT(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelinesEXT glGenProgramPipelinesEXT = Load_GenProgramPipelinesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenQueriesEXT(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueriesEXT glGenQueriesEXT = Load_GenQueriesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers = Load_GenRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures = Load_GenTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysOES glGenVertexArraysOES = Load_GenVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib = Load_GetActiveAttrib;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform = Load_GetActiveUniform;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders = Load_GetAttachedShaders;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation = Load_GetAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv = Load_GetBooleanv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.ES20.BufferTarget target, OpenTK.Graphics.ES20.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv = Load_GetBufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferPointervOES(OpenTK.Graphics.ES20.BufferTarget target, OpenTK.Graphics.ES20.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervOES glGetBufferPointervOES = Load_GetBufferPointervOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES20.DebugSourceExternal* sources, [OutAttribute] OpenTK.Graphics.ES20.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES20.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLog glGetDebugMessageLog = Load_GetDebugMessageLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES20.DebugSourceExternal* sources, [OutAttribute] OpenTK.Graphics.ES20.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES20.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogKHR glGetDebugMessageLogKHR = Load_GetDebugMessageLogKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            internal unsafe static GetDriverControlsQCOM glGetDriverControlsQCOM = Load_GetDriverControlsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            internal unsafe static GetDriverControlStringQCOM glGetDriverControlStringQCOM = Load_GetDriverControlStringQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES20.ErrorCode GetError();
            internal static GetError glGetError = Load_GetError;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV = Load_GetFenceivNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv = Load_GetFloatv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv = Load_GetFramebufferAttachmentParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES20.All GetGraphicsResetStatusEXT();
            internal static GetGraphicsResetStatusEXT glGetGraphicsResetStatusEXT = Load_GetGraphicsResetStatusEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64vAPPLE(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64vAPPLE glGetInteger64vAPPLE = Load_GetInteger64vAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegeri_vEXT(OpenTK.Graphics.ES20.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_vEXT glGetIntegeri_vEXT = Load_GetIntegeri_vEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv = Load_GetIntegerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvEXT glGetnUniformfvEXT = Load_GetnUniformfvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivEXT glGetnUniformivEXT = Load_GetnUniformivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabel(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabel glGetObjectLabel = Load_GetObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabelEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelEXT glGetObjectLabelEXT = Load_GetObjectLabelEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabelKHR(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelKHR glGetObjectLabelKHR = Load_GetObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabel glGetObjectPtrLabel = Load_GetObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabelKHR glGetObjectPtrLabelKHR = Load_GetObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorCounterDataAMD(UInt32 monitor, OpenTK.Graphics.ES20.All pname, Int32 dataSize, [OutAttribute] UInt32* data, [OutAttribute] Int32* bytesWritten);
            internal unsafe static GetPerfMonitorCounterDataAMD glGetPerfMonitorCounterDataAMD = Load_GetPerfMonitorCounterDataAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr data);
            internal static GetPerfMonitorCounterInfoAMD glGetPerfMonitorCounterInfoAMD = Load_GetPerfMonitorCounterInfoAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorCountersAMD(UInt32 group, [OutAttribute] Int32* numCounters, [OutAttribute] Int32* maxActiveCounters, Int32 counterSize, [OutAttribute] UInt32* counters);
            internal unsafe static GetPerfMonitorCountersAMD glGetPerfMonitorCountersAMD = Load_GetPerfMonitorCountersAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder counterString);
            internal unsafe static GetPerfMonitorCounterStringAMD glGetPerfMonitorCounterStringAMD = Load_GetPerfMonitorCounterStringAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups, Int32 groupsSize, [OutAttribute] UInt32* groups);
            internal unsafe static GetPerfMonitorGroupsAMD glGetPerfMonitorGroupsAMD = Load_GetPerfMonitorGroupsAMD;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder groupString);
            internal unsafe static GetPerfMonitorGroupStringAMD glGetPerfMonitorGroupStringAMD = Load_GetPerfMonitorGroupStringAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointerv(OpenTK.Graphics.ES20.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv = Load_GetPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointervKHR(OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr @params);
            internal static GetPointervKHR glGetPointervKHR = Load_GetPointervKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramBinaryOES(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.ES20.All* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinaryOES glGetProgramBinaryOES = Load_GetProgramBinaryOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog = Load_GetProgramInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.ES20.GetProgramParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv = Load_GetProgramiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLogEXT glGetProgramPipelineInfoLogEXT = Load_GetProgramPipelineInfoLogEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineivEXT(UInt32 pipeline, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineivEXT glGetProgramPipelineivEXT = Load_GetProgramPipelineivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryivEXT(OpenTK.Graphics.ES20.QueryTarget target, OpenTK.Graphics.ES20.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryivEXT glGetQueryivEXT = Load_GetQueryivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT = Load_GetQueryObjecti64vEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectivEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectivEXT glGetQueryObjectivEXT = Load_GetQueryObjectivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT = Load_GetQueryObjectui64vEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectuivEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuivEXT glGetQueryObjectuivEXT = Load_GetQueryObjectuivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv = Load_GetRenderbufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog = Load_GetShaderInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.ES20.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv = Load_GetShaderiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.ES20.ShaderType shadertype, OpenTK.Graphics.ES20.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat = Load_GetShaderPrecisionFormat;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource = Load_GetShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetString(OpenTK.Graphics.ES20.StringName name);
            internal static GetString glGetString = Load_GetString;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES20.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSyncivAPPLE glGetSyncivAPPLE = Load_GetSyncivAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv = Load_GetTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv = Load_GetTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetTranslatedShaderSourceANGLE glGetTranslatedShaderSourceANGLE = Load_GetTranslatedShaderSourceANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv = Load_GetUniformfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv = Load_GetUniformiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetUniformLocation(UInt32 program, String name);
            internal static GetUniformLocation glGetUniformLocation = Load_GetUniformLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv = Load_GetVertexAttribfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv = Load_GetVertexAttribiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv = Load_GetVertexAttribPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Hint(OpenTK.Graphics.ES20.HintTarget target, OpenTK.Graphics.ES20.HintMode mode);
            internal static Hint glHint = Load_Hint;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InsertEventMarkerEXT(Int32 length, String marker);
            internal static InsertEventMarkerEXT glInsertEventMarkerEXT = Load_InsertEventMarkerEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer = Load_IsBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabled(OpenTK.Graphics.ES20.EnableCap cap);
            internal static IsEnabled glIsEnabled = Load_IsEnabled;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV = Load_IsFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer = Load_IsFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram = Load_IsProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgramPipelineEXT(UInt32 pipeline);
            internal static IsProgramPipelineEXT glIsProgramPipelineEXT = Load_IsProgramPipelineEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsQueryEXT(UInt32 id);
            internal static IsQueryEXT glIsQueryEXT = Load_IsQueryEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer = Load_IsRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader = Load_IsShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSyncAPPLE(IntPtr sync);
            internal static IsSyncAPPLE glIsSyncAPPLE = Load_IsSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture = Load_IsTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsVertexArrayOES(UInt32 array);
            internal static IsVertexArrayOES glIsVertexArrayOES = Load_IsVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LabelObjectEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 length, String label);
            internal static LabelObjectEXT glLabelObjectEXT = Load_LabelObjectEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth = Load_LineWidth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram = Load_LinkProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All access);
            internal static MapBufferOES glMapBufferOES = Load_MapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr length, UInt32 access);
            internal static MapBufferRangeEXT glMapBufferRangeEXT = Load_MapBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawArraysEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT = Load_MultiDrawArraysEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElementsEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT = Load_MultiDrawElementsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabel(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabel glObjectLabel = Load_ObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabelKHR(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabelKHR glObjectLabelKHR = Load_ObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabel glObjectPtrLabel = Load_ObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabelKHR glObjectPtrLabelKHR = Load_ObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorei(OpenTK.Graphics.ES20.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei = Load_PixelStorei;
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
            internal delegate void PopGroupMarkerEXT();
            internal static PopGroupMarkerEXT glPopGroupMarkerEXT = Load_PopGroupMarkerEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramBinaryOES(UInt32 program, OpenTK.Graphics.ES20.All binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinaryOES glProgramBinaryOES = Load_ProgramBinaryOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramParameteriEXT(UInt32 program, OpenTK.Graphics.ES20.ProgramParameterName pname, Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT = Load_ProgramParameteriEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1fEXT(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1fEXT glProgramUniform1fEXT = Load_ProgramUniform1fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fvEXT glProgramUniform1fvEXT = Load_ProgramUniform1fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1iEXT glProgramUniform1iEXT = Load_ProgramUniform1iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1ivEXT glProgramUniform1ivEXT = Load_ProgramUniform1ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1uiEXT glProgramUniform1uiEXT = Load_ProgramUniform1uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uivEXT glProgramUniform1uivEXT = Load_ProgramUniform1uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2fEXT(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2fEXT glProgramUniform2fEXT = Load_ProgramUniform2fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fvEXT glProgramUniform2fvEXT = Load_ProgramUniform2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2iEXT glProgramUniform2iEXT = Load_ProgramUniform2iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2ivEXT glProgramUniform2ivEXT = Load_ProgramUniform2ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2uiEXT glProgramUniform2uiEXT = Load_ProgramUniform2uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uivEXT glProgramUniform2uivEXT = Load_ProgramUniform2uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3fEXT glProgramUniform3fEXT = Load_ProgramUniform3fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fvEXT glProgramUniform3fvEXT = Load_ProgramUniform3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3iEXT glProgramUniform3iEXT = Load_ProgramUniform3iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3ivEXT glProgramUniform3ivEXT = Load_ProgramUniform3ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3uiEXT glProgramUniform3uiEXT = Load_ProgramUniform3uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uivEXT glProgramUniform3uivEXT = Load_ProgramUniform3uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4fEXT glProgramUniform4fEXT = Load_ProgramUniform4fEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fvEXT glProgramUniform4fvEXT = Load_ProgramUniform4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4iEXT glProgramUniform4iEXT = Load_ProgramUniform4iEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4ivEXT glProgramUniform4ivEXT = Load_ProgramUniform4ivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4uiEXT glProgramUniform4uiEXT = Load_ProgramUniform4uiEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uivEXT glProgramUniform4uivEXT = Load_ProgramUniform4uivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT = Load_ProgramUniformMatrix2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fvEXT glProgramUniformMatrix2x3fvEXT = Load_ProgramUniformMatrix2x3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fvEXT glProgramUniformMatrix2x4fvEXT = Load_ProgramUniformMatrix2x4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT = Load_ProgramUniformMatrix3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fvEXT glProgramUniformMatrix3x2fvEXT = Load_ProgramUniformMatrix3x2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fvEXT glProgramUniformMatrix3x4fvEXT = Load_ProgramUniformMatrix3x4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT = Load_ProgramUniformMatrix4fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fvEXT glProgramUniformMatrix4x2fvEXT = Load_ProgramUniformMatrix4x2fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fvEXT glProgramUniformMatrix4x3fvEXT = Load_ProgramUniformMatrix4x3fvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroup(OpenTK.Graphics.ES20.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroup glPushDebugGroup = Load_PushDebugGroup;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroupKHR(OpenTK.Graphics.ES20.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroupKHR glPushDebugGroupKHR = Load_PushDebugGroupKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushGroupMarkerEXT(Int32 length, String marker);
            internal static PushGroupMarkerEXT glPushGroupMarkerEXT = Load_PushGroupMarkerEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void QueryCounterEXT(UInt32 id, OpenTK.Graphics.ES20.All target);
            internal static QueryCounterEXT glQueryCounterEXT = Load_QueryCounterEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadBufferIndexedEXT(OpenTK.Graphics.ES20.All src, Int32 index);
            internal static ReadBufferIndexedEXT glReadBufferIndexedEXT = Load_ReadBufferIndexedEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadBufferNV(OpenTK.Graphics.ES20.All mode);
            internal static ReadBufferNV glReadBufferNV = Load_ReadBufferNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsEXT glReadnPixelsEXT = Load_ReadnPixelsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels = Load_ReadPixels;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler = Load_ReleaseShaderCompiler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage = Load_RenderbufferStorage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleANGLE(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleANGLE glRenderbufferStorageMultisampleANGLE = Load_RenderbufferStorageMultisampleANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleAPPLE glRenderbufferStorageMultisampleAPPLE = Load_RenderbufferStorageMultisampleAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT = Load_RenderbufferStorageMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleIMG glRenderbufferStorageMultisampleIMG = Load_RenderbufferStorageMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleNV(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleNV glRenderbufferStorageMultisampleNV = Load_RenderbufferStorageMultisampleNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResolveMultisampleFramebufferAPPLE();
            internal static ResolveMultisampleFramebufferAPPLE glResolveMultisampleFramebufferAPPLE = Load_ResolveMultisampleFramebufferAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage = Load_SampleCoverage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor = Load_Scissor;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, [OutAttribute] UInt32* counterList);
            internal unsafe static SelectPerfMonitorCountersAMD glSelectPerfMonitorCountersAMD = Load_SelectPerfMonitorCountersAMD;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES20.All condition);
            internal static SetFenceNV glSetFenceNV = Load_SetFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.ES20.ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary = Load_ShaderBinary;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource = Load_ShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            internal static StartTilingQCOM glStartTilingQCOM = Load_StartTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFunc(OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc = Load_StencilFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate = Load_StencilFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask = Load_StencilMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.ES20.StencilFace face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate = Load_StencilMaskSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOp(OpenTK.Graphics.ES20.StencilOp fail, OpenTK.Graphics.ES20.StencilOp zfail, OpenTK.Graphics.ES20.StencilOp zpass);
            internal static StencilOp glStencilOp = Load_StencilOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilOp sfail, OpenTK.Graphics.ES20.StencilOp dpfail, OpenTK.Graphics.ES20.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate = Load_StencilOpSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV = Load_TestFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES20.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D = Load_TexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES20.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            internal static TexImage3DOES glTexImage3DOES = Load_TexImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterf(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf = Load_TexParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv = Load_TexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameteri(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri = Load_TexParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv = Load_TexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage1DEXT(OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width);
            internal static TexStorage1DEXT glTexStorage1DEXT = Load_TexStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2DEXT(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES20.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2DEXT glTexStorage2DEXT = Load_TexStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3DEXT(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 levels, OpenTK.Graphics.ES20.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3DEXT glTexStorage3DEXT = Load_TexStorage3DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D = Load_TexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, IntPtr pixels);
            internal static TexSubImage3DOES glTexSubImage3DOES = Load_TexSubImage3DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width);
            internal static TextureStorage1DEXT glTextureStorage1DEXT = Load_TextureStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            internal static TextureStorage2DEXT glTextureStorage2DEXT = Load_TextureStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TextureStorage3DEXT glTextureStorage3DEXT = Load_TextureStorage3DEXT;
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
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv = Load_UniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fvNV glUniformMatrix2x3fvNV = Load_UniformMatrix2x3fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fvNV glUniformMatrix2x4fvNV = Load_UniformMatrix2x4fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv = Load_UniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fvNV glUniformMatrix3x2fvNV = Load_UniformMatrix3x2fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fvNV glUniformMatrix3x4fvNV = Load_UniformMatrix3x4fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv = Load_UniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fvNV glUniformMatrix4x2fvNV = Load_UniformMatrix4x2fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fvNV glUniformMatrix4x3fvNV = Load_UniformMatrix4x3fvNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool UnmapBufferOES(OpenTK.Graphics.ES20.BufferTarget target);
            internal static UnmapBufferOES glUnmapBufferOES = Load_UnmapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram = Load_UseProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);
            internal static UseProgramStagesEXT glUseProgramStagesEXT = Load_UseProgramStagesEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseShaderProgramEXT(OpenTK.Graphics.ES20.All type, UInt32 program);
            internal static UseShaderProgramEXT glUseShaderProgramEXT = Load_UseShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram = Load_ValidateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgramPipelineEXT(UInt32 pipeline);
            internal static ValidateProgramPipelineEXT glValidateProgramPipelineEXT = Load_ValidateProgramPipelineEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f = Load_VertexAttrib1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv = Load_VertexAttrib1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f = Load_VertexAttrib2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv = Load_VertexAttrib2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f = Load_VertexAttrib3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv = Load_VertexAttrib3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f = Load_VertexAttrib4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv = Load_VertexAttrib4fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisorANGLE(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorANGLE glVertexAttribDivisorANGLE = Load_VertexAttribDivisorANGLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisorEXT(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorEXT glVertexAttribDivisorEXT = Load_VertexAttribDivisorEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisorNV(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorNV glVertexAttribDivisorNV = Load_VertexAttribDivisorNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.ES20.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer = Load_VertexAttribPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport = Load_Viewport;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void WaitSyncAPPLE(IntPtr sync, OpenTK.Graphics.ES20.WaitSyncFlags flags, UInt64 timeout);
            internal static WaitSyncAPPLE glWaitSyncAPPLE = Load_WaitSyncAPPLE;
        }
        internal static void Load_ActiveProgramEXT(UInt32 program)
        {
            Delegates.glActiveProgramEXT = (Delegates.ActiveProgramEXT)GetExtensionDelegateStatic("glActiveProgramEXT", typeof(Delegates.ActiveProgramEXT));
            Delegates.glActiveProgramEXT((UInt32)program);
        }
        internal static void Load_ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program)
        {
            Delegates.glActiveShaderProgramEXT = (Delegates.ActiveShaderProgramEXT)GetExtensionDelegateStatic("glActiveShaderProgramEXT", typeof(Delegates.ActiveShaderProgramEXT));
            Delegates.glActiveShaderProgramEXT((UInt32)pipeline, (UInt32)program);
        }
        internal static void Load_ActiveTexture(OpenTK.Graphics.ES20.TextureUnit texture)
        {
            Delegates.glActiveTexture = (Delegates.ActiveTexture)GetExtensionDelegateStatic("glActiveTexture", typeof(Delegates.ActiveTexture));
            Delegates.glActiveTexture((OpenTK.Graphics.ES20.TextureUnit)texture);
        }
        internal static void Load_AlphaFuncQCOM(OpenTK.Graphics.ES20.All func, Single @ref)
        {
            Delegates.glAlphaFuncQCOM = (Delegates.AlphaFuncQCOM)GetExtensionDelegateStatic("glAlphaFuncQCOM", typeof(Delegates.AlphaFuncQCOM));
            Delegates.glAlphaFuncQCOM((OpenTK.Graphics.ES20.All)func, (Single)@ref);
        }
        internal static void Load_AttachShader(UInt32 program, UInt32 shader)
        {
            Delegates.glAttachShader = (Delegates.AttachShader)GetExtensionDelegateStatic("glAttachShader", typeof(Delegates.AttachShader));
            Delegates.glAttachShader((UInt32)program, (UInt32)shader);
        }
        internal static void Load_BeginPerfMonitorAMD(UInt32 monitor)
        {
            Delegates.glBeginPerfMonitorAMD = (Delegates.BeginPerfMonitorAMD)GetExtensionDelegateStatic("glBeginPerfMonitorAMD", typeof(Delegates.BeginPerfMonitorAMD));
            Delegates.glBeginPerfMonitorAMD((UInt32)monitor);
        }
        internal static void Load_BeginQueryEXT(OpenTK.Graphics.ES20.QueryTarget target, UInt32 id)
        {
            Delegates.glBeginQueryEXT = (Delegates.BeginQueryEXT)GetExtensionDelegateStatic("glBeginQueryEXT", typeof(Delegates.BeginQueryEXT));
            Delegates.glBeginQueryEXT((OpenTK.Graphics.ES20.QueryTarget)target, (UInt32)id);
        }
        internal static void Load_BindAttribLocation(UInt32 program, UInt32 index, String name)
        {
            Delegates.glBindAttribLocation = (Delegates.BindAttribLocation)GetExtensionDelegateStatic("glBindAttribLocation", typeof(Delegates.BindAttribLocation));
            Delegates.glBindAttribLocation((UInt32)program, (UInt32)index, (String)name);
        }
        internal static void Load_BindBuffer(OpenTK.Graphics.ES20.BufferTarget target, UInt32 buffer)
        {
            Delegates.glBindBuffer = (Delegates.BindBuffer)GetExtensionDelegateStatic("glBindBuffer", typeof(Delegates.BindBuffer));
            Delegates.glBindBuffer((OpenTK.Graphics.ES20.BufferTarget)target, (UInt32)buffer);
        }
        internal static void Load_BindFramebuffer(OpenTK.Graphics.ES20.FramebufferTarget target, UInt32 framebuffer)
        {
            Delegates.glBindFramebuffer = (Delegates.BindFramebuffer)GetExtensionDelegateStatic("glBindFramebuffer", typeof(Delegates.BindFramebuffer));
            Delegates.glBindFramebuffer((OpenTK.Graphics.ES20.FramebufferTarget)target, (UInt32)framebuffer);
        }
        internal static void Load_BindProgramPipelineEXT(UInt32 pipeline)
        {
            Delegates.glBindProgramPipelineEXT = (Delegates.BindProgramPipelineEXT)GetExtensionDelegateStatic("glBindProgramPipelineEXT", typeof(Delegates.BindProgramPipelineEXT));
            Delegates.glBindProgramPipelineEXT((UInt32)pipeline);
        }
        internal static void Load_BindRenderbuffer(OpenTK.Graphics.ES20.RenderbufferTarget target, UInt32 renderbuffer)
        {
            Delegates.glBindRenderbuffer = (Delegates.BindRenderbuffer)GetExtensionDelegateStatic("glBindRenderbuffer", typeof(Delegates.BindRenderbuffer));
            Delegates.glBindRenderbuffer((OpenTK.Graphics.ES20.RenderbufferTarget)target, (UInt32)renderbuffer);
        }
        internal static void Load_BindTexture(OpenTK.Graphics.ES20.TextureTarget target, UInt32 texture)
        {
            Delegates.glBindTexture = (Delegates.BindTexture)GetExtensionDelegateStatic("glBindTexture", typeof(Delegates.BindTexture));
            Delegates.glBindTexture((OpenTK.Graphics.ES20.TextureTarget)target, (UInt32)texture);
        }
        internal static void Load_BindVertexArrayOES(UInt32 array)
        {
            Delegates.glBindVertexArrayOES = (Delegates.BindVertexArrayOES)GetExtensionDelegateStatic("glBindVertexArrayOES", typeof(Delegates.BindVertexArrayOES));
            Delegates.glBindVertexArrayOES((UInt32)array);
        }
        internal static void Load_BlendBarrierNV()
        {
            Delegates.glBlendBarrierNV = (Delegates.BlendBarrierNV)GetExtensionDelegateStatic("glBlendBarrierNV", typeof(Delegates.BlendBarrierNV));
            Delegates.glBlendBarrierNV();
        }
        internal static void Load_BlendColor(Single red, Single green, Single blue, Single alpha)
        {
            Delegates.glBlendColor = (Delegates.BlendColor)GetExtensionDelegateStatic("glBlendColor", typeof(Delegates.BlendColor));
            Delegates.glBlendColor((Single)red, (Single)green, (Single)blue, (Single)alpha);
        }
        internal static void Load_BlendEquation(OpenTK.Graphics.ES20.BlendEquationMode mode)
        {
            Delegates.glBlendEquation = (Delegates.BlendEquation)GetExtensionDelegateStatic("glBlendEquation", typeof(Delegates.BlendEquation));
            Delegates.glBlendEquation((OpenTK.Graphics.ES20.BlendEquationMode)mode);
        }
        internal static void Load_BlendEquationEXT(OpenTK.Graphics.ES20.BlendEquationMode mode)
        {
            Delegates.glBlendEquationEXT = (Delegates.BlendEquationEXT)GetExtensionDelegateStatic("glBlendEquationEXT", typeof(Delegates.BlendEquationEXT));
            Delegates.glBlendEquationEXT((OpenTK.Graphics.ES20.BlendEquationMode)mode);
        }
        internal static void Load_BlendEquationSeparate(OpenTK.Graphics.ES20.BlendEquationMode modeRGB, OpenTK.Graphics.ES20.BlendEquationMode modeAlpha)
        {
            Delegates.glBlendEquationSeparate = (Delegates.BlendEquationSeparate)GetExtensionDelegateStatic("glBlendEquationSeparate", typeof(Delegates.BlendEquationSeparate));
            Delegates.glBlendEquationSeparate((OpenTK.Graphics.ES20.BlendEquationMode)modeRGB, (OpenTK.Graphics.ES20.BlendEquationMode)modeAlpha);
        }
        internal static void Load_BlendFunc(OpenTK.Graphics.ES20.BlendingFactorSrc sfactor, OpenTK.Graphics.ES20.BlendingFactorDest dfactor)
        {
            Delegates.glBlendFunc = (Delegates.BlendFunc)GetExtensionDelegateStatic("glBlendFunc", typeof(Delegates.BlendFunc));
            Delegates.glBlendFunc((OpenTK.Graphics.ES20.BlendingFactorSrc)sfactor, (OpenTK.Graphics.ES20.BlendingFactorDest)dfactor);
        }
        internal static void Load_BlendFuncSeparate(OpenTK.Graphics.ES20.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.ES20.BlendingFactorDest dfactorRGB, OpenTK.Graphics.ES20.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.ES20.BlendingFactorDest dfactorAlpha)
        {
            Delegates.glBlendFuncSeparate = (Delegates.BlendFuncSeparate)GetExtensionDelegateStatic("glBlendFuncSeparate", typeof(Delegates.BlendFuncSeparate));
            Delegates.glBlendFuncSeparate((OpenTK.Graphics.ES20.BlendingFactorSrc)sfactorRGB, (OpenTK.Graphics.ES20.BlendingFactorDest)dfactorRGB, (OpenTK.Graphics.ES20.BlendingFactorSrc)sfactorAlpha, (OpenTK.Graphics.ES20.BlendingFactorDest)dfactorAlpha);
        }
        internal static void Load_BlendParameteriNV(OpenTK.Graphics.ES20.All pname, Int32 value)
        {
            Delegates.glBlendParameteriNV = (Delegates.BlendParameteriNV)GetExtensionDelegateStatic("glBlendParameteriNV", typeof(Delegates.BlendParameteriNV));
            Delegates.glBlendParameteriNV((OpenTK.Graphics.ES20.All)pname, (Int32)value);
        }
        internal static void Load_BlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES20.ClearBufferMask mask, OpenTK.Graphics.ES20.BlitFramebufferFilter filter)
        {
            Delegates.glBlitFramebufferANGLE = (Delegates.BlitFramebufferANGLE)GetExtensionDelegateStatic("glBlitFramebufferANGLE", typeof(Delegates.BlitFramebufferANGLE));
            Delegates.glBlitFramebufferANGLE((Int32)srcX0, (Int32)srcY0, (Int32)srcX1, (Int32)srcY1, (Int32)dstX0, (Int32)dstY0, (Int32)dstX1, (Int32)dstY1, (OpenTK.Graphics.ES20.ClearBufferMask)mask, (OpenTK.Graphics.ES20.BlitFramebufferFilter)filter);
        }
        internal static void Load_BlitFramebufferNV(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.ES20.ClearBufferMask mask, OpenTK.Graphics.ES20.BlitFramebufferFilter filter)
        {
            Delegates.glBlitFramebufferNV = (Delegates.BlitFramebufferNV)GetExtensionDelegateStatic("glBlitFramebufferNV", typeof(Delegates.BlitFramebufferNV));
            Delegates.glBlitFramebufferNV((Int32)srcX0, (Int32)srcY0, (Int32)srcX1, (Int32)srcY1, (Int32)dstX0, (Int32)dstY0, (Int32)dstX1, (Int32)dstY1, (OpenTK.Graphics.ES20.ClearBufferMask)mask, (OpenTK.Graphics.ES20.BlitFramebufferFilter)filter);
        }
        internal static void Load_BufferData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.ES20.BufferUsageHint usage)
        {
            Delegates.glBufferData = (Delegates.BufferData)GetExtensionDelegateStatic("glBufferData", typeof(Delegates.BufferData));
            Delegates.glBufferData((OpenTK.Graphics.ES20.BufferTarget)target, (IntPtr)size, (IntPtr)data, (OpenTK.Graphics.ES20.BufferUsageHint)usage);
        }
        internal static void Load_BufferSubData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data)
        {
            Delegates.glBufferSubData = (Delegates.BufferSubData)GetExtensionDelegateStatic("glBufferSubData", typeof(Delegates.BufferSubData));
            Delegates.glBufferSubData((OpenTK.Graphics.ES20.BufferTarget)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data);
        }
        internal static OpenTK.Graphics.ES20.FramebufferErrorCode Load_CheckFramebufferStatus(OpenTK.Graphics.ES20.FramebufferTarget target)
        {
            Delegates.glCheckFramebufferStatus = (Delegates.CheckFramebufferStatus)GetExtensionDelegateStatic("glCheckFramebufferStatus", typeof(Delegates.CheckFramebufferStatus));
            return Delegates.glCheckFramebufferStatus((OpenTK.Graphics.ES20.FramebufferTarget)target);
        }
        internal static void Load_Clear(OpenTK.Graphics.ES20.ClearBufferMask mask)
        {
            Delegates.glClear = (Delegates.Clear)GetExtensionDelegateStatic("glClear", typeof(Delegates.Clear));
            Delegates.glClear((OpenTK.Graphics.ES20.ClearBufferMask)mask);
        }
        internal static void Load_ClearColor(Single red, Single green, Single blue, Single alpha)
        {
            Delegates.glClearColor = (Delegates.ClearColor)GetExtensionDelegateStatic("glClearColor", typeof(Delegates.ClearColor));
            Delegates.glClearColor((Single)red, (Single)green, (Single)blue, (Single)alpha);
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
        internal static OpenTK.Graphics.ES20.WaitSyncStatus Load_ClientWaitSyncAPPLE(IntPtr sync, OpenTK.Graphics.ES20.ClientWaitSyncFlags flags, UInt64 timeout)
        {
            Delegates.glClientWaitSyncAPPLE = (Delegates.ClientWaitSyncAPPLE)GetExtensionDelegateStatic("glClientWaitSyncAPPLE", typeof(Delegates.ClientWaitSyncAPPLE));
            return Delegates.glClientWaitSyncAPPLE((IntPtr)sync, (OpenTK.Graphics.ES20.ClientWaitSyncFlags)flags, (UInt64)timeout);
        }
        internal static void Load_ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            Delegates.glColorMask = (Delegates.ColorMask)GetExtensionDelegateStatic("glColorMask", typeof(Delegates.ColorMask));
            Delegates.glColorMask((bool)red, (bool)green, (bool)blue, (bool)alpha);
        }
        internal static void Load_CompileShader(UInt32 shader)
        {
            Delegates.glCompileShader = (Delegates.CompileShader)GetExtensionDelegateStatic("glCompileShader", typeof(Delegates.CompileShader));
            Delegates.glCompileShader((UInt32)shader);
        }
        internal static void Load_CompressedTexImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES20.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage2D = (Delegates.CompressedTexImage2D)GetExtensionDelegateStatic("glCompressedTexImage2D", typeof(Delegates.CompressedTexImage2D));
            Delegates.glCompressedTexImage2D((OpenTK.Graphics.ES20.TextureTarget2d)target, (Int32)level, (OpenTK.Graphics.ES20.CompressedInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES20.CompressedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage3DOES = (Delegates.CompressedTexImage3DOES)GetExtensionDelegateStatic("glCompressedTexImage3DOES", typeof(Delegates.CompressedTexImage3DOES));
            Delegates.glCompressedTexImage3DOES((OpenTK.Graphics.ES20.TextureTarget3d)target, (Int32)level, (OpenTK.Graphics.ES20.CompressedInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)depth, (Int32)border, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)GetExtensionDelegateStatic("glCompressedTexSubImage2D", typeof(Delegates.CompressedTexSubImage2D));
            Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.ES20.TextureTarget2d)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES20.PixelFormat)format, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CompressedTexSubImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage3DOES = (Delegates.CompressedTexSubImage3DOES)GetExtensionDelegateStatic("glCompressedTexSubImage3DOES", typeof(Delegates.CompressedTexSubImage3DOES));
            Delegates.glCompressedTexSubImage3DOES((OpenTK.Graphics.ES20.TextureTarget3d)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES20.All)format, (Int32)imageSize, (IntPtr)data);
        }
        internal static void Load_CopyBufferSubDataNV(OpenTK.Graphics.ES20.BufferTarget readTarget, OpenTK.Graphics.ES20.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
        {
            Delegates.glCopyBufferSubDataNV = (Delegates.CopyBufferSubDataNV)GetExtensionDelegateStatic("glCopyBufferSubDataNV", typeof(Delegates.CopyBufferSubDataNV));
            Delegates.glCopyBufferSubDataNV((OpenTK.Graphics.ES20.BufferTarget)readTarget, (OpenTK.Graphics.ES20.BufferTarget)writeTarget, (IntPtr)readOffset, (IntPtr)writeOffset, (IntPtr)size);
        }
        internal static void Load_CopyTexImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES20.TextureCopyComponentCount internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
        {
            Delegates.glCopyTexImage2D = (Delegates.CopyTexImage2D)GetExtensionDelegateStatic("glCopyTexImage2D", typeof(Delegates.CopyTexImage2D));
            Delegates.glCopyTexImage2D((OpenTK.Graphics.ES20.TextureTarget2d)target, (Int32)level, (OpenTK.Graphics.ES20.TextureCopyComponentCount)internalformat, (Int32)x, (Int32)y, (Int32)width, (Int32)height, (Int32)border);
        }
        internal static void Load_CopyTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTexSubImage2D = (Delegates.CopyTexSubImage2D)GetExtensionDelegateStatic("glCopyTexSubImage2D", typeof(Delegates.CopyTexSubImage2D));
            Delegates.glCopyTexSubImage2D((OpenTK.Graphics.ES20.TextureTarget2d)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static void Load_CopyTexSubImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTexSubImage3DOES = (Delegates.CopyTexSubImage3DOES)GetExtensionDelegateStatic("glCopyTexSubImage3DOES", typeof(Delegates.CopyTexSubImage3DOES));
            Delegates.glCopyTexSubImage3DOES((OpenTK.Graphics.ES20.TextureTarget3d)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static void Load_CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
        {
            Delegates.glCopyTextureLevelsAPPLE = (Delegates.CopyTextureLevelsAPPLE)GetExtensionDelegateStatic("glCopyTextureLevelsAPPLE", typeof(Delegates.CopyTextureLevelsAPPLE));
            Delegates.glCopyTextureLevelsAPPLE((UInt32)destinationTexture, (UInt32)sourceTexture, (Int32)sourceBaseLevel, (Int32)sourceLevelCount);
        }
        internal static void Load_CoverageMaskNV(bool mask)
        {
            Delegates.glCoverageMaskNV = (Delegates.CoverageMaskNV)GetExtensionDelegateStatic("glCoverageMaskNV", typeof(Delegates.CoverageMaskNV));
            Delegates.glCoverageMaskNV((bool)mask);
        }
        internal static void Load_CoverageOperationNV(OpenTK.Graphics.ES20.All operation)
        {
            Delegates.glCoverageOperationNV = (Delegates.CoverageOperationNV)GetExtensionDelegateStatic("glCoverageOperationNV", typeof(Delegates.CoverageOperationNV));
            Delegates.glCoverageOperationNV((OpenTK.Graphics.ES20.All)operation);
        }
        internal static Int32 Load_CreateProgram()
        {
            Delegates.glCreateProgram = (Delegates.CreateProgram)GetExtensionDelegateStatic("glCreateProgram", typeof(Delegates.CreateProgram));
            return Delegates.glCreateProgram();
        }
        internal static Int32 Load_CreateShader(OpenTK.Graphics.ES20.ShaderType type)
        {
            Delegates.glCreateShader = (Delegates.CreateShader)GetExtensionDelegateStatic("glCreateShader", typeof(Delegates.CreateShader));
            return Delegates.glCreateShader((OpenTK.Graphics.ES20.ShaderType)type);
        }
        internal static Int32 Load_CreateShaderProgramEXT(OpenTK.Graphics.ES20.All type, String @string)
        {
            Delegates.glCreateShaderProgramEXT = (Delegates.CreateShaderProgramEXT)GetExtensionDelegateStatic("glCreateShaderProgramEXT", typeof(Delegates.CreateShaderProgramEXT));
            return Delegates.glCreateShaderProgramEXT((OpenTK.Graphics.ES20.All)type, (String)@string);
        }
        internal static Int32 Load_CreateShaderProgramvEXT(OpenTK.Graphics.ES20.All type, Int32 count, String[] strings)
        {
            Delegates.glCreateShaderProgramvEXT = (Delegates.CreateShaderProgramvEXT)GetExtensionDelegateStatic("glCreateShaderProgramvEXT", typeof(Delegates.CreateShaderProgramvEXT));
            return Delegates.glCreateShaderProgramvEXT((OpenTK.Graphics.ES20.All)type, (Int32)count, (String[])strings);
        }
        internal static void Load_CullFace(OpenTK.Graphics.ES20.CullFaceMode mode)
        {
            Delegates.glCullFace = (Delegates.CullFace)GetExtensionDelegateStatic("glCullFace", typeof(Delegates.CullFace));
            Delegates.glCullFace((OpenTK.Graphics.ES20.CullFaceMode)mode);
        }
        internal static void Load_DebugMessageCallback(DebugProc callback, IntPtr userParam)
        {
            Delegates.glDebugMessageCallback = (Delegates.DebugMessageCallback)GetExtensionDelegateStatic("glDebugMessageCallback", typeof(Delegates.DebugMessageCallback));
            Delegates.glDebugMessageCallback((DebugProc)callback, (IntPtr)userParam);
        }
        internal static void Load_DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam)
        {
            Delegates.glDebugMessageCallbackKHR = (Delegates.DebugMessageCallbackKHR)GetExtensionDelegateStatic("glDebugMessageCallbackKHR", typeof(Delegates.DebugMessageCallbackKHR));
            Delegates.glDebugMessageCallbackKHR((DebugProcKhr)callback, (IntPtr)userParam);
        }
        internal static unsafe void Load_DebugMessageControl(OpenTK.Graphics.ES20.DebugSourceControl source, OpenTK.Graphics.ES20.DebugTypeControl type, OpenTK.Graphics.ES20.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled)
        {
            Delegates.glDebugMessageControl = (Delegates.DebugMessageControl)GetExtensionDelegateStatic("glDebugMessageControl", typeof(Delegates.DebugMessageControl));
            Delegates.glDebugMessageControl((OpenTK.Graphics.ES20.DebugSourceControl)source, (OpenTK.Graphics.ES20.DebugTypeControl)type, (OpenTK.Graphics.ES20.DebugSeverityControl)severity, (Int32)count, (UInt32*)ids, (bool)enabled);
        }
        internal static unsafe void Load_DebugMessageControlKHR(OpenTK.Graphics.ES20.DebugSourceControl source, OpenTK.Graphics.ES20.DebugTypeControl type, OpenTK.Graphics.ES20.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled)
        {
            Delegates.glDebugMessageControlKHR = (Delegates.DebugMessageControlKHR)GetExtensionDelegateStatic("glDebugMessageControlKHR", typeof(Delegates.DebugMessageControlKHR));
            Delegates.glDebugMessageControlKHR((OpenTK.Graphics.ES20.DebugSourceControl)source, (OpenTK.Graphics.ES20.DebugTypeControl)type, (OpenTK.Graphics.ES20.DebugSeverityControl)severity, (Int32)count, (UInt32*)ids, (bool)enabled);
        }
        internal static void Load_DebugMessageInsert(OpenTK.Graphics.ES20.DebugSourceExternal source, OpenTK.Graphics.ES20.DebugType type, UInt32 id, OpenTK.Graphics.ES20.DebugSeverity severity, Int32 length, String buf)
        {
            Delegates.glDebugMessageInsert = (Delegates.DebugMessageInsert)GetExtensionDelegateStatic("glDebugMessageInsert", typeof(Delegates.DebugMessageInsert));
            Delegates.glDebugMessageInsert((OpenTK.Graphics.ES20.DebugSourceExternal)source, (OpenTK.Graphics.ES20.DebugType)type, (UInt32)id, (OpenTK.Graphics.ES20.DebugSeverity)severity, (Int32)length, (String)buf);
        }
        internal static void Load_DebugMessageInsertKHR(OpenTK.Graphics.ES20.DebugSourceExternal source, OpenTK.Graphics.ES20.DebugType type, UInt32 id, OpenTK.Graphics.ES20.DebugSeverity severity, Int32 length, String buf)
        {
            Delegates.glDebugMessageInsertKHR = (Delegates.DebugMessageInsertKHR)GetExtensionDelegateStatic("glDebugMessageInsertKHR", typeof(Delegates.DebugMessageInsertKHR));
            Delegates.glDebugMessageInsertKHR((OpenTK.Graphics.ES20.DebugSourceExternal)source, (OpenTK.Graphics.ES20.DebugType)type, (UInt32)id, (OpenTK.Graphics.ES20.DebugSeverity)severity, (Int32)length, (String)buf);
        }
        internal static unsafe void Load_DeleteBuffers(Int32 n, UInt32* buffers)
        {
            Delegates.glDeleteBuffers = (Delegates.DeleteBuffers)GetExtensionDelegateStatic("glDeleteBuffers", typeof(Delegates.DeleteBuffers));
            Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers);
        }
        internal static unsafe void Load_DeleteFencesNV(Int32 n, UInt32* fences)
        {
            Delegates.glDeleteFencesNV = (Delegates.DeleteFencesNV)GetExtensionDelegateStatic("glDeleteFencesNV", typeof(Delegates.DeleteFencesNV));
            Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences);
        }
        internal static unsafe void Load_DeleteFramebuffers(Int32 n, UInt32* framebuffers)
        {
            Delegates.glDeleteFramebuffers = (Delegates.DeleteFramebuffers)GetExtensionDelegateStatic("glDeleteFramebuffers", typeof(Delegates.DeleteFramebuffers));
            Delegates.glDeleteFramebuffers((Int32)n, (UInt32*)framebuffers);
        }
        internal static unsafe void Load_DeletePerfMonitorsAMD(Int32 n, UInt32* monitors)
        {
            Delegates.glDeletePerfMonitorsAMD = (Delegates.DeletePerfMonitorsAMD)GetExtensionDelegateStatic("glDeletePerfMonitorsAMD", typeof(Delegates.DeletePerfMonitorsAMD));
            Delegates.glDeletePerfMonitorsAMD((Int32)n, (UInt32*)monitors);
        }
        internal static void Load_DeleteProgram(UInt32 program)
        {
            Delegates.glDeleteProgram = (Delegates.DeleteProgram)GetExtensionDelegateStatic("glDeleteProgram", typeof(Delegates.DeleteProgram));
            Delegates.glDeleteProgram((UInt32)program);
        }
        internal static unsafe void Load_DeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines)
        {
            Delegates.glDeleteProgramPipelinesEXT = (Delegates.DeleteProgramPipelinesEXT)GetExtensionDelegateStatic("glDeleteProgramPipelinesEXT", typeof(Delegates.DeleteProgramPipelinesEXT));
            Delegates.glDeleteProgramPipelinesEXT((Int32)n, (UInt32*)pipelines);
        }
        internal static unsafe void Load_DeleteQueriesEXT(Int32 n, UInt32* ids)
        {
            Delegates.glDeleteQueriesEXT = (Delegates.DeleteQueriesEXT)GetExtensionDelegateStatic("glDeleteQueriesEXT", typeof(Delegates.DeleteQueriesEXT));
            Delegates.glDeleteQueriesEXT((Int32)n, (UInt32*)ids);
        }
        internal static unsafe void Load_DeleteRenderbuffers(Int32 n, UInt32* renderbuffers)
        {
            Delegates.glDeleteRenderbuffers = (Delegates.DeleteRenderbuffers)GetExtensionDelegateStatic("glDeleteRenderbuffers", typeof(Delegates.DeleteRenderbuffers));
            Delegates.glDeleteRenderbuffers((Int32)n, (UInt32*)renderbuffers);
        }
        internal static void Load_DeleteShader(UInt32 shader)
        {
            Delegates.glDeleteShader = (Delegates.DeleteShader)GetExtensionDelegateStatic("glDeleteShader", typeof(Delegates.DeleteShader));
            Delegates.glDeleteShader((UInt32)shader);
        }
        internal static void Load_DeleteSyncAPPLE(IntPtr sync)
        {
            Delegates.glDeleteSyncAPPLE = (Delegates.DeleteSyncAPPLE)GetExtensionDelegateStatic("glDeleteSyncAPPLE", typeof(Delegates.DeleteSyncAPPLE));
            Delegates.glDeleteSyncAPPLE((IntPtr)sync);
        }
        internal static unsafe void Load_DeleteTextures(Int32 n, UInt32* textures)
        {
            Delegates.glDeleteTextures = (Delegates.DeleteTextures)GetExtensionDelegateStatic("glDeleteTextures", typeof(Delegates.DeleteTextures));
            Delegates.glDeleteTextures((Int32)n, (UInt32*)textures);
        }
        internal static unsafe void Load_DeleteVertexArraysOES(Int32 n, UInt32* arrays)
        {
            Delegates.glDeleteVertexArraysOES = (Delegates.DeleteVertexArraysOES)GetExtensionDelegateStatic("glDeleteVertexArraysOES", typeof(Delegates.DeleteVertexArraysOES));
            Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays);
        }
        internal static void Load_DepthFunc(OpenTK.Graphics.ES20.DepthFunction func)
        {
            Delegates.glDepthFunc = (Delegates.DepthFunc)GetExtensionDelegateStatic("glDepthFunc", typeof(Delegates.DepthFunc));
            Delegates.glDepthFunc((OpenTK.Graphics.ES20.DepthFunction)func);
        }
        internal static void Load_DepthMask(bool flag)
        {
            Delegates.glDepthMask = (Delegates.DepthMask)GetExtensionDelegateStatic("glDepthMask", typeof(Delegates.DepthMask));
            Delegates.glDepthMask((bool)flag);
        }
        internal static void Load_DepthRangef(Single n, Single f)
        {
            Delegates.glDepthRangef = (Delegates.DepthRangef)GetExtensionDelegateStatic("glDepthRangef", typeof(Delegates.DepthRangef));
            Delegates.glDepthRangef((Single)n, (Single)f);
        }
        internal static void Load_DetachShader(UInt32 program, UInt32 shader)
        {
            Delegates.glDetachShader = (Delegates.DetachShader)GetExtensionDelegateStatic("glDetachShader", typeof(Delegates.DetachShader));
            Delegates.glDetachShader((UInt32)program, (UInt32)shader);
        }
        internal static void Load_Disable(OpenTK.Graphics.ES20.EnableCap cap)
        {
            Delegates.glDisable = (Delegates.Disable)GetExtensionDelegateStatic("glDisable", typeof(Delegates.Disable));
            Delegates.glDisable((OpenTK.Graphics.ES20.EnableCap)cap);
        }
        internal static void Load_DisableDriverControlQCOM(UInt32 driverControl)
        {
            Delegates.glDisableDriverControlQCOM = (Delegates.DisableDriverControlQCOM)GetExtensionDelegateStatic("glDisableDriverControlQCOM", typeof(Delegates.DisableDriverControlQCOM));
            Delegates.glDisableDriverControlQCOM((UInt32)driverControl);
        }
        internal static void Load_DisableVertexAttribArray(UInt32 index)
        {
            Delegates.glDisableVertexAttribArray = (Delegates.DisableVertexAttribArray)GetExtensionDelegateStatic("glDisableVertexAttribArray", typeof(Delegates.DisableVertexAttribArray));
            Delegates.glDisableVertexAttribArray((UInt32)index);
        }
        internal static unsafe void Load_DiscardFramebufferEXT(OpenTK.Graphics.ES20.All target, Int32 numAttachments, OpenTK.Graphics.ES20.All* attachments)
        {
            Delegates.glDiscardFramebufferEXT = (Delegates.DiscardFramebufferEXT)GetExtensionDelegateStatic("glDiscardFramebufferEXT", typeof(Delegates.DiscardFramebufferEXT));
            Delegates.glDiscardFramebufferEXT((OpenTK.Graphics.ES20.All)target, (Int32)numAttachments, (OpenTK.Graphics.ES20.All*)attachments);
        }
        internal static void Load_DrawArrays(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count)
        {
            Delegates.glDrawArrays = (Delegates.DrawArrays)GetExtensionDelegateStatic("glDrawArrays", typeof(Delegates.DrawArrays));
            Delegates.glDrawArrays((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)first, (Int32)count);
        }
        internal static void Load_DrawArraysInstancedANGLE(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount)
        {
            Delegates.glDrawArraysInstancedANGLE = (Delegates.DrawArraysInstancedANGLE)GetExtensionDelegateStatic("glDrawArraysInstancedANGLE", typeof(Delegates.DrawArraysInstancedANGLE));
            Delegates.glDrawArraysInstancedANGLE((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)first, (Int32)count, (Int32)primcount);
        }
        internal static void Load_DrawArraysInstancedEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 start, Int32 count, Int32 primcount)
        {
            Delegates.glDrawArraysInstancedEXT = (Delegates.DrawArraysInstancedEXT)GetExtensionDelegateStatic("glDrawArraysInstancedEXT", typeof(Delegates.DrawArraysInstancedEXT));
            Delegates.glDrawArraysInstancedEXT((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)start, (Int32)count, (Int32)primcount);
        }
        internal static void Load_DrawArraysInstancedNV(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount)
        {
            Delegates.glDrawArraysInstancedNV = (Delegates.DrawArraysInstancedNV)GetExtensionDelegateStatic("glDrawArraysInstancedNV", typeof(Delegates.DrawArraysInstancedNV));
            Delegates.glDrawArraysInstancedNV((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)first, (Int32)count, (Int32)primcount);
        }
        internal static unsafe void Load_DrawBuffersEXT(Int32 n, OpenTK.Graphics.ES20.DrawBufferMode* bufs)
        {
            Delegates.glDrawBuffersEXT = (Delegates.DrawBuffersEXT)GetExtensionDelegateStatic("glDrawBuffersEXT", typeof(Delegates.DrawBuffersEXT));
            Delegates.glDrawBuffersEXT((Int32)n, (OpenTK.Graphics.ES20.DrawBufferMode*)bufs);
        }
        internal static unsafe void Load_DrawBuffersIndexedEXT(Int32 n, OpenTK.Graphics.ES20.All* location, Int32* indices)
        {
            Delegates.glDrawBuffersIndexedEXT = (Delegates.DrawBuffersIndexedEXT)GetExtensionDelegateStatic("glDrawBuffersIndexedEXT", typeof(Delegates.DrawBuffersIndexedEXT));
            Delegates.glDrawBuffersIndexedEXT((Int32)n, (OpenTK.Graphics.ES20.All*)location, (Int32*)indices);
        }
        internal static unsafe void Load_DrawBuffersNV(Int32 n, OpenTK.Graphics.ES20.DrawBufferMode* bufs)
        {
            Delegates.glDrawBuffersNV = (Delegates.DrawBuffersNV)GetExtensionDelegateStatic("glDrawBuffersNV", typeof(Delegates.DrawBuffersNV));
            Delegates.glDrawBuffersNV((Int32)n, (OpenTK.Graphics.ES20.DrawBufferMode*)bufs);
        }
        internal static void Load_DrawElements(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices)
        {
            Delegates.glDrawElements = (Delegates.DrawElements)GetExtensionDelegateStatic("glDrawElements", typeof(Delegates.DrawElements));
            Delegates.glDrawElements((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES20.DrawElementsType)type, (IntPtr)indices);
        }
        internal static void Load_DrawElementsInstancedANGLE(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount)
        {
            Delegates.glDrawElementsInstancedANGLE = (Delegates.DrawElementsInstancedANGLE)GetExtensionDelegateStatic("glDrawElementsInstancedANGLE", typeof(Delegates.DrawElementsInstancedANGLE));
            Delegates.glDrawElementsInstancedANGLE((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES20.DrawElementsType)type, (IntPtr)indices, (Int32)primcount);
        }
        internal static void Load_DrawElementsInstancedEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount)
        {
            Delegates.glDrawElementsInstancedEXT = (Delegates.DrawElementsInstancedEXT)GetExtensionDelegateStatic("glDrawElementsInstancedEXT", typeof(Delegates.DrawElementsInstancedEXT));
            Delegates.glDrawElementsInstancedEXT((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES20.DrawElementsType)type, (IntPtr)indices, (Int32)primcount);
        }
        internal static void Load_DrawElementsInstancedNV(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount)
        {
            Delegates.glDrawElementsInstancedNV = (Delegates.DrawElementsInstancedNV)GetExtensionDelegateStatic("glDrawElementsInstancedNV", typeof(Delegates.DrawElementsInstancedNV));
            Delegates.glDrawElementsInstancedNV((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES20.DrawElementsType)type, (IntPtr)indices, (Int32)primcount);
        }
        internal static void Load_EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES20.All target, IntPtr image)
        {
            Delegates.glEGLImageTargetRenderbufferStorageOES = (Delegates.EGLImageTargetRenderbufferStorageOES)GetExtensionDelegateStatic("glEGLImageTargetRenderbufferStorageOES", typeof(Delegates.EGLImageTargetRenderbufferStorageOES));
            Delegates.glEGLImageTargetRenderbufferStorageOES((OpenTK.Graphics.ES20.All)target, (IntPtr)image);
        }
        internal static void Load_EGLImageTargetTexture2DOES(OpenTK.Graphics.ES20.All target, IntPtr image)
        {
            Delegates.glEGLImageTargetTexture2DOES = (Delegates.EGLImageTargetTexture2DOES)GetExtensionDelegateStatic("glEGLImageTargetTexture2DOES", typeof(Delegates.EGLImageTargetTexture2DOES));
            Delegates.glEGLImageTargetTexture2DOES((OpenTK.Graphics.ES20.All)target, (IntPtr)image);
        }
        internal static void Load_Enable(OpenTK.Graphics.ES20.EnableCap cap)
        {
            Delegates.glEnable = (Delegates.Enable)GetExtensionDelegateStatic("glEnable", typeof(Delegates.Enable));
            Delegates.glEnable((OpenTK.Graphics.ES20.EnableCap)cap);
        }
        internal static void Load_EnableDriverControlQCOM(UInt32 driverControl)
        {
            Delegates.glEnableDriverControlQCOM = (Delegates.EnableDriverControlQCOM)GetExtensionDelegateStatic("glEnableDriverControlQCOM", typeof(Delegates.EnableDriverControlQCOM));
            Delegates.glEnableDriverControlQCOM((UInt32)driverControl);
        }
        internal static void Load_EnableVertexAttribArray(UInt32 index)
        {
            Delegates.glEnableVertexAttribArray = (Delegates.EnableVertexAttribArray)GetExtensionDelegateStatic("glEnableVertexAttribArray", typeof(Delegates.EnableVertexAttribArray));
            Delegates.glEnableVertexAttribArray((UInt32)index);
        }
        internal static void Load_EndPerfMonitorAMD(UInt32 monitor)
        {
            Delegates.glEndPerfMonitorAMD = (Delegates.EndPerfMonitorAMD)GetExtensionDelegateStatic("glEndPerfMonitorAMD", typeof(Delegates.EndPerfMonitorAMD));
            Delegates.glEndPerfMonitorAMD((UInt32)monitor);
        }
        internal static void Load_EndQueryEXT(OpenTK.Graphics.ES20.QueryTarget target)
        {
            Delegates.glEndQueryEXT = (Delegates.EndQueryEXT)GetExtensionDelegateStatic("glEndQueryEXT", typeof(Delegates.EndQueryEXT));
            Delegates.glEndQueryEXT((OpenTK.Graphics.ES20.QueryTarget)target);
        }
        internal static void Load_EndTilingQCOM(UInt32 preserveMask)
        {
            Delegates.glEndTilingQCOM = (Delegates.EndTilingQCOM)GetExtensionDelegateStatic("glEndTilingQCOM", typeof(Delegates.EndTilingQCOM));
            Delegates.glEndTilingQCOM((UInt32)preserveMask);
        }
        internal static void Load_ExtGetBufferPointervQCOM(OpenTK.Graphics.ES20.All target, [OutAttribute] IntPtr @params)
        {
            Delegates.glExtGetBufferPointervQCOM = (Delegates.ExtGetBufferPointervQCOM)GetExtensionDelegateStatic("glExtGetBufferPointervQCOM", typeof(Delegates.ExtGetBufferPointervQCOM));
            Delegates.glExtGetBufferPointervQCOM((OpenTK.Graphics.ES20.All)target, (IntPtr)@params);
        }
        internal static unsafe void Load_ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers)
        {
            Delegates.glExtGetBuffersQCOM = (Delegates.ExtGetBuffersQCOM)GetExtensionDelegateStatic("glExtGetBuffersQCOM", typeof(Delegates.ExtGetBuffersQCOM));
            Delegates.glExtGetBuffersQCOM((UInt32*)buffers, (Int32)maxBuffers, (Int32*)numBuffers);
        }
        internal static unsafe void Load_ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers)
        {
            Delegates.glExtGetFramebuffersQCOM = (Delegates.ExtGetFramebuffersQCOM)GetExtensionDelegateStatic("glExtGetFramebuffersQCOM", typeof(Delegates.ExtGetFramebuffersQCOM));
            Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers, (Int32)maxFramebuffers, (Int32*)numFramebuffers);
        }
        internal static unsafe void Load_ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES20.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length)
        {
            Delegates.glExtGetProgramBinarySourceQCOM = (Delegates.ExtGetProgramBinarySourceQCOM)GetExtensionDelegateStatic("glExtGetProgramBinarySourceQCOM", typeof(Delegates.ExtGetProgramBinarySourceQCOM));
            Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES20.All)shadertype, (StringBuilder)source, (Int32*)length);
        }
        internal static unsafe void Load_ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms)
        {
            Delegates.glExtGetProgramsQCOM = (Delegates.ExtGetProgramsQCOM)GetExtensionDelegateStatic("glExtGetProgramsQCOM", typeof(Delegates.ExtGetProgramsQCOM));
            Delegates.glExtGetProgramsQCOM((UInt32*)programs, (Int32)maxPrograms, (Int32*)numPrograms);
        }
        internal static unsafe void Load_ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers)
        {
            Delegates.glExtGetRenderbuffersQCOM = (Delegates.ExtGetRenderbuffersQCOM)GetExtensionDelegateStatic("glExtGetRenderbuffersQCOM", typeof(Delegates.ExtGetRenderbuffersQCOM));
            Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers);
        }
        internal static unsafe void Load_ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders)
        {
            Delegates.glExtGetShadersQCOM = (Delegates.ExtGetShadersQCOM)GetExtensionDelegateStatic("glExtGetShadersQCOM", typeof(Delegates.ExtGetShadersQCOM));
            Delegates.glExtGetShadersQCOM((UInt32*)shaders, (Int32)maxShaders, (Int32*)numShaders);
        }
        internal static unsafe void Load_ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES20.All face, Int32 level, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params)
        {
            Delegates.glExtGetTexLevelParameterivQCOM = (Delegates.ExtGetTexLevelParameterivQCOM)GetExtensionDelegateStatic("glExtGetTexLevelParameterivQCOM", typeof(Delegates.ExtGetTexLevelParameterivQCOM));
            Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES20.All)face, (Int32)level, (OpenTK.Graphics.ES20.All)pname, (Int32*)@params);
        }
        internal static void Load_ExtGetTexSubImageQCOM(OpenTK.Graphics.ES20.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, [OutAttribute] IntPtr texels)
        {
            Delegates.glExtGetTexSubImageQCOM = (Delegates.ExtGetTexSubImageQCOM)GetExtensionDelegateStatic("glExtGetTexSubImageQCOM", typeof(Delegates.ExtGetTexSubImageQCOM));
            Delegates.glExtGetTexSubImageQCOM((OpenTK.Graphics.ES20.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES20.All)format, (OpenTK.Graphics.ES20.All)type, (IntPtr)texels);
        }
        internal static unsafe void Load_ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures)
        {
            Delegates.glExtGetTexturesQCOM = (Delegates.ExtGetTexturesQCOM)GetExtensionDelegateStatic("glExtGetTexturesQCOM", typeof(Delegates.ExtGetTexturesQCOM));
            Delegates.glExtGetTexturesQCOM((UInt32*)textures, (Int32)maxTextures, (Int32*)numTextures);
        }
        internal static bool Load_ExtIsProgramBinaryQCOM(UInt32 program)
        {
            Delegates.glExtIsProgramBinaryQCOM = (Delegates.ExtIsProgramBinaryQCOM)GetExtensionDelegateStatic("glExtIsProgramBinaryQCOM", typeof(Delegates.ExtIsProgramBinaryQCOM));
            return Delegates.glExtIsProgramBinaryQCOM((UInt32)program);
        }
        internal static void Load_ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All pname, Int32 param)
        {
            Delegates.glExtTexObjectStateOverrideiQCOM = (Delegates.ExtTexObjectStateOverrideiQCOM)GetExtensionDelegateStatic("glExtTexObjectStateOverrideiQCOM", typeof(Delegates.ExtTexObjectStateOverrideiQCOM));
            Delegates.glExtTexObjectStateOverrideiQCOM((OpenTK.Graphics.ES20.All)target, (OpenTK.Graphics.ES20.All)pname, (Int32)param);
        }
        internal static IntPtr Load_FenceSyncAPPLE(OpenTK.Graphics.ES20.SyncCondition condition, OpenTK.Graphics.ES20.WaitSyncFlags flags)
        {
            Delegates.glFenceSyncAPPLE = (Delegates.FenceSyncAPPLE)GetExtensionDelegateStatic("glFenceSyncAPPLE", typeof(Delegates.FenceSyncAPPLE));
            return Delegates.glFenceSyncAPPLE((OpenTK.Graphics.ES20.SyncCondition)condition, (OpenTK.Graphics.ES20.WaitSyncFlags)flags);
        }
        internal static void Load_Finish()
        {
            Delegates.glFinish = (Delegates.Finish)GetExtensionDelegateStatic("glFinish", typeof(Delegates.Finish));
            Delegates.glFinish();
        }
        internal static void Load_FinishFenceNV(UInt32 fence)
        {
            Delegates.glFinishFenceNV = (Delegates.FinishFenceNV)GetExtensionDelegateStatic("glFinishFenceNV", typeof(Delegates.FinishFenceNV));
            Delegates.glFinishFenceNV((UInt32)fence);
        }
        internal static void Load_Flush()
        {
            Delegates.glFlush = (Delegates.Flush)GetExtensionDelegateStatic("glFlush", typeof(Delegates.Flush));
            Delegates.glFlush();
        }
        internal static void Load_FlushMappedBufferRangeEXT(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr length)
        {
            Delegates.glFlushMappedBufferRangeEXT = (Delegates.FlushMappedBufferRangeEXT)GetExtensionDelegateStatic("glFlushMappedBufferRangeEXT", typeof(Delegates.FlushMappedBufferRangeEXT));
            Delegates.glFlushMappedBufferRangeEXT((OpenTK.Graphics.ES20.BufferTarget)target, (IntPtr)offset, (IntPtr)length);
        }
        internal static void Load_FramebufferRenderbuffer(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
        {
            Delegates.glFramebufferRenderbuffer = (Delegates.FramebufferRenderbuffer)GetExtensionDelegateStatic("glFramebufferRenderbuffer", typeof(Delegates.FramebufferRenderbuffer));
            Delegates.glFramebufferRenderbuffer((OpenTK.Graphics.ES20.FramebufferTarget)target, (OpenTK.Graphics.ES20.All)attachment, (OpenTK.Graphics.ES20.RenderbufferTarget)renderbuffertarget, (UInt32)renderbuffer);
        }
        internal static void Load_FramebufferTexture2D(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.TextureTarget2d textarget, UInt32 texture, Int32 level)
        {
            Delegates.glFramebufferTexture2D = (Delegates.FramebufferTexture2D)GetExtensionDelegateStatic("glFramebufferTexture2D", typeof(Delegates.FramebufferTexture2D));
            Delegates.glFramebufferTexture2D((OpenTK.Graphics.ES20.FramebufferTarget)target, (OpenTK.Graphics.ES20.All)attachment, (OpenTK.Graphics.ES20.TextureTarget2d)textarget, (UInt32)texture, (Int32)level);
        }
        internal static void Load_FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 samples)
        {
            Delegates.glFramebufferTexture2DMultisampleEXT = (Delegates.FramebufferTexture2DMultisampleEXT)GetExtensionDelegateStatic("glFramebufferTexture2DMultisampleEXT", typeof(Delegates.FramebufferTexture2DMultisampleEXT));
            Delegates.glFramebufferTexture2DMultisampleEXT((OpenTK.Graphics.ES20.All)target, (OpenTK.Graphics.ES20.All)attachment, (OpenTK.Graphics.ES20.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
        }
        internal static void Load_FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 samples)
        {
            Delegates.glFramebufferTexture2DMultisampleIMG = (Delegates.FramebufferTexture2DMultisampleIMG)GetExtensionDelegateStatic("glFramebufferTexture2DMultisampleIMG", typeof(Delegates.FramebufferTexture2DMultisampleIMG));
            Delegates.glFramebufferTexture2DMultisampleIMG((OpenTK.Graphics.ES20.All)target, (OpenTK.Graphics.ES20.All)attachment, (OpenTK.Graphics.ES20.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
        }
        internal static void Load_FramebufferTexture3DOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 zoffset)
        {
            Delegates.glFramebufferTexture3DOES = (Delegates.FramebufferTexture3DOES)GetExtensionDelegateStatic("glFramebufferTexture3DOES", typeof(Delegates.FramebufferTexture3DOES));
            Delegates.glFramebufferTexture3DOES((OpenTK.Graphics.ES20.All)target, (OpenTK.Graphics.ES20.All)attachment, (OpenTK.Graphics.ES20.All)textarget, (UInt32)texture, (Int32)level, (Int32)zoffset);
        }
        internal static void Load_FrontFace(OpenTK.Graphics.ES20.FrontFaceDirection mode)
        {
            Delegates.glFrontFace = (Delegates.FrontFace)GetExtensionDelegateStatic("glFrontFace", typeof(Delegates.FrontFace));
            Delegates.glFrontFace((OpenTK.Graphics.ES20.FrontFaceDirection)mode);
        }
        internal static unsafe void Load_GenBuffers(Int32 n, [OutAttribute] UInt32* buffers)
        {
            Delegates.glGenBuffers = (Delegates.GenBuffers)GetExtensionDelegateStatic("glGenBuffers", typeof(Delegates.GenBuffers));
            Delegates.glGenBuffers((Int32)n, (UInt32*)buffers);
        }
        internal static void Load_GenerateMipmap(OpenTK.Graphics.ES20.TextureTarget target)
        {
            Delegates.glGenerateMipmap = (Delegates.GenerateMipmap)GetExtensionDelegateStatic("glGenerateMipmap", typeof(Delegates.GenerateMipmap));
            Delegates.glGenerateMipmap((OpenTK.Graphics.ES20.TextureTarget)target);
        }
        internal static unsafe void Load_GenFencesNV(Int32 n, [OutAttribute] UInt32* fences)
        {
            Delegates.glGenFencesNV = (Delegates.GenFencesNV)GetExtensionDelegateStatic("glGenFencesNV", typeof(Delegates.GenFencesNV));
            Delegates.glGenFencesNV((Int32)n, (UInt32*)fences);
        }
        internal static unsafe void Load_GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers)
        {
            Delegates.glGenFramebuffers = (Delegates.GenFramebuffers)GetExtensionDelegateStatic("glGenFramebuffers", typeof(Delegates.GenFramebuffers));
            Delegates.glGenFramebuffers((Int32)n, (UInt32*)framebuffers);
        }
        internal static unsafe void Load_GenPerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors)
        {
            Delegates.glGenPerfMonitorsAMD = (Delegates.GenPerfMonitorsAMD)GetExtensionDelegateStatic("glGenPerfMonitorsAMD", typeof(Delegates.GenPerfMonitorsAMD));
            Delegates.glGenPerfMonitorsAMD((Int32)n, (UInt32*)monitors);
        }
        internal static unsafe void Load_GenProgramPipelinesEXT(Int32 n, [OutAttribute] UInt32* pipelines)
        {
            Delegates.glGenProgramPipelinesEXT = (Delegates.GenProgramPipelinesEXT)GetExtensionDelegateStatic("glGenProgramPipelinesEXT", typeof(Delegates.GenProgramPipelinesEXT));
            Delegates.glGenProgramPipelinesEXT((Int32)n, (UInt32*)pipelines);
        }
        internal static unsafe void Load_GenQueriesEXT(Int32 n, [OutAttribute] UInt32* ids)
        {
            Delegates.glGenQueriesEXT = (Delegates.GenQueriesEXT)GetExtensionDelegateStatic("glGenQueriesEXT", typeof(Delegates.GenQueriesEXT));
            Delegates.glGenQueriesEXT((Int32)n, (UInt32*)ids);
        }
        internal static unsafe void Load_GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers)
        {
            Delegates.glGenRenderbuffers = (Delegates.GenRenderbuffers)GetExtensionDelegateStatic("glGenRenderbuffers", typeof(Delegates.GenRenderbuffers));
            Delegates.glGenRenderbuffers((Int32)n, (UInt32*)renderbuffers);
        }
        internal static unsafe void Load_GenTextures(Int32 n, [OutAttribute] UInt32* textures)
        {
            Delegates.glGenTextures = (Delegates.GenTextures)GetExtensionDelegateStatic("glGenTextures", typeof(Delegates.GenTextures));
            Delegates.glGenTextures((Int32)n, (UInt32*)textures);
        }
        internal static unsafe void Load_GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays)
        {
            Delegates.glGenVertexArraysOES = (Delegates.GenVertexArraysOES)GetExtensionDelegateStatic("glGenVertexArraysOES", typeof(Delegates.GenVertexArraysOES));
            Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays);
        }
        internal static unsafe void Load_GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveAttribType* type, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetActiveAttrib = (Delegates.GetActiveAttrib)GetExtensionDelegateStatic("glGetActiveAttrib", typeof(Delegates.GetActiveAttrib));
            Delegates.glGetActiveAttrib((UInt32)program, (UInt32)index, (Int32)bufSize, (Int32*)length, (Int32*)size, (OpenTK.Graphics.ES20.ActiveAttribType*)type, (StringBuilder)name);
        }
        internal static unsafe void Load_GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveUniformType* type, [OutAttribute] StringBuilder name)
        {
            Delegates.glGetActiveUniform = (Delegates.GetActiveUniform)GetExtensionDelegateStatic("glGetActiveUniform", typeof(Delegates.GetActiveUniform));
            Delegates.glGetActiveUniform((UInt32)program, (UInt32)index, (Int32)bufSize, (Int32*)length, (Int32*)size, (OpenTK.Graphics.ES20.ActiveUniformType*)type, (StringBuilder)name);
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
        internal static unsafe void Load_GetBooleanv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] bool* data)
        {
            Delegates.glGetBooleanv = (Delegates.GetBooleanv)GetExtensionDelegateStatic("glGetBooleanv", typeof(Delegates.GetBooleanv));
            Delegates.glGetBooleanv((OpenTK.Graphics.ES20.GetPName)pname, (bool*)data);
        }
        internal static unsafe void Load_GetBufferParameteriv(OpenTK.Graphics.ES20.BufferTarget target, OpenTK.Graphics.ES20.BufferParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetBufferParameteriv = (Delegates.GetBufferParameteriv)GetExtensionDelegateStatic("glGetBufferParameteriv", typeof(Delegates.GetBufferParameteriv));
            Delegates.glGetBufferParameteriv((OpenTK.Graphics.ES20.BufferTarget)target, (OpenTK.Graphics.ES20.BufferParameterName)pname, (Int32*)@params);
        }
        internal static void Load_GetBufferPointervOES(OpenTK.Graphics.ES20.BufferTarget target, OpenTK.Graphics.ES20.BufferPointer pname, [OutAttribute] IntPtr @params)
        {
            Delegates.glGetBufferPointervOES = (Delegates.GetBufferPointervOES)GetExtensionDelegateStatic("glGetBufferPointervOES", typeof(Delegates.GetBufferPointervOES));
            Delegates.glGetBufferPointervOES((OpenTK.Graphics.ES20.BufferTarget)target, (OpenTK.Graphics.ES20.BufferPointer)pname, (IntPtr)@params);
        }
        internal static unsafe Int32 Load_GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES20.DebugSourceExternal* sources, [OutAttribute] OpenTK.Graphics.ES20.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES20.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog)
        {
            Delegates.glGetDebugMessageLog = (Delegates.GetDebugMessageLog)GetExtensionDelegateStatic("glGetDebugMessageLog", typeof(Delegates.GetDebugMessageLog));
            return Delegates.glGetDebugMessageLog((UInt32)count, (Int32)bufSize, (OpenTK.Graphics.ES20.DebugSourceExternal*)sources, (OpenTK.Graphics.ES20.DebugType*)types, (UInt32*)ids, (OpenTK.Graphics.ES20.DebugSeverity*)severities, (Int32*)lengths, (StringBuilder)messageLog);
        }
        internal static unsafe Int32 Load_GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES20.DebugSourceExternal* sources, [OutAttribute] OpenTK.Graphics.ES20.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES20.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog)
        {
            Delegates.glGetDebugMessageLogKHR = (Delegates.GetDebugMessageLogKHR)GetExtensionDelegateStatic("glGetDebugMessageLogKHR", typeof(Delegates.GetDebugMessageLogKHR));
            return Delegates.glGetDebugMessageLogKHR((UInt32)count, (Int32)bufSize, (OpenTK.Graphics.ES20.DebugSourceExternal*)sources, (OpenTK.Graphics.ES20.DebugType*)types, (UInt32*)ids, (OpenTK.Graphics.ES20.DebugSeverity*)severities, (Int32*)lengths, (StringBuilder)messageLog);
        }
        internal static unsafe void Load_GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls)
        {
            Delegates.glGetDriverControlsQCOM = (Delegates.GetDriverControlsQCOM)GetExtensionDelegateStatic("glGetDriverControlsQCOM", typeof(Delegates.GetDriverControlsQCOM));
            Delegates.glGetDriverControlsQCOM((Int32*)num, (Int32)size, (UInt32*)driverControls);
        }
        internal static unsafe void Load_GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString)
        {
            Delegates.glGetDriverControlStringQCOM = (Delegates.GetDriverControlStringQCOM)GetExtensionDelegateStatic("glGetDriverControlStringQCOM", typeof(Delegates.GetDriverControlStringQCOM));
            Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length, (StringBuilder)driverControlString);
        }
        internal static OpenTK.Graphics.ES20.ErrorCode Load_GetError()
        {
            Delegates.glGetError = (Delegates.GetError)GetExtensionDelegateStatic("glGetError", typeof(Delegates.GetError));
            return Delegates.glGetError();
        }
        internal static unsafe void Load_GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetFenceivNV = (Delegates.GetFenceivNV)GetExtensionDelegateStatic("glGetFenceivNV", typeof(Delegates.GetFenceivNV));
            Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES20.All)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetFloatv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Single* data)
        {
            Delegates.glGetFloatv = (Delegates.GetFloatv)GetExtensionDelegateStatic("glGetFloatv", typeof(Delegates.GetFloatv));
            Delegates.glGetFloatv((OpenTK.Graphics.ES20.GetPName)pname, (Single*)data);
        }
        internal static unsafe void Load_GetFramebufferAttachmentParameteriv(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.FramebufferParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetFramebufferAttachmentParameteriv = (Delegates.GetFramebufferAttachmentParameteriv)GetExtensionDelegateStatic("glGetFramebufferAttachmentParameteriv", typeof(Delegates.GetFramebufferAttachmentParameteriv));
            Delegates.glGetFramebufferAttachmentParameteriv((OpenTK.Graphics.ES20.FramebufferTarget)target, (OpenTK.Graphics.ES20.All)attachment, (OpenTK.Graphics.ES20.FramebufferParameterName)pname, (Int32*)@params);
        }
        internal static OpenTK.Graphics.ES20.All Load_GetGraphicsResetStatusEXT()
        {
            Delegates.glGetGraphicsResetStatusEXT = (Delegates.GetGraphicsResetStatusEXT)GetExtensionDelegateStatic("glGetGraphicsResetStatusEXT", typeof(Delegates.GetGraphicsResetStatusEXT));
            return Delegates.glGetGraphicsResetStatusEXT();
        }
        internal static unsafe void Load_GetInteger64vAPPLE(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Int64* @params)
        {
            Delegates.glGetInteger64vAPPLE = (Delegates.GetInteger64vAPPLE)GetExtensionDelegateStatic("glGetInteger64vAPPLE", typeof(Delegates.GetInteger64vAPPLE));
            Delegates.glGetInteger64vAPPLE((OpenTK.Graphics.ES20.GetPName)pname, (Int64*)@params);
        }
        internal static unsafe void Load_GetIntegeri_vEXT(OpenTK.Graphics.ES20.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data)
        {
            Delegates.glGetIntegeri_vEXT = (Delegates.GetIntegeri_vEXT)GetExtensionDelegateStatic("glGetIntegeri_vEXT", typeof(Delegates.GetIntegeri_vEXT));
            Delegates.glGetIntegeri_vEXT((OpenTK.Graphics.ES20.GetIndexedPName)target, (UInt32)index, (Int32*)data);
        }
        internal static unsafe void Load_GetIntegerv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Int32* data)
        {
            Delegates.glGetIntegerv = (Delegates.GetIntegerv)GetExtensionDelegateStatic("glGetIntegerv", typeof(Delegates.GetIntegerv));
            Delegates.glGetIntegerv((OpenTK.Graphics.ES20.GetPName)pname, (Int32*)data);
        }
        internal static unsafe void Load_GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params)
        {
            Delegates.glGetnUniformfvEXT = (Delegates.GetnUniformfvEXT)GetExtensionDelegateStatic("glGetnUniformfvEXT", typeof(Delegates.GetnUniformfvEXT));
            Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params);
        }
        internal static unsafe void Load_GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params)
        {
            Delegates.glGetnUniformivEXT = (Delegates.GetnUniformivEXT)GetExtensionDelegateStatic("glGetnUniformivEXT", typeof(Delegates.GetnUniformivEXT));
            Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params);
        }
        internal static unsafe void Load_GetObjectLabel(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label)
        {
            Delegates.glGetObjectLabel = (Delegates.GetObjectLabel)GetExtensionDelegateStatic("glGetObjectLabel", typeof(Delegates.GetObjectLabel));
            Delegates.glGetObjectLabel((OpenTK.Graphics.ES20.ObjectLabelIdentifier)identifier, (UInt32)name, (Int32)bufSize, (Int32*)length, (StringBuilder)label);
        }
        internal static unsafe void Load_GetObjectLabelEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label)
        {
            Delegates.glGetObjectLabelEXT = (Delegates.GetObjectLabelEXT)GetExtensionDelegateStatic("glGetObjectLabelEXT", typeof(Delegates.GetObjectLabelEXT));
            Delegates.glGetObjectLabelEXT((OpenTK.Graphics.ES20.All)type, (UInt32)@object, (Int32)bufSize, (Int32*)length, (StringBuilder)label);
        }
        internal static unsafe void Load_GetObjectLabelKHR(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label)
        {
            Delegates.glGetObjectLabelKHR = (Delegates.GetObjectLabelKHR)GetExtensionDelegateStatic("glGetObjectLabelKHR", typeof(Delegates.GetObjectLabelKHR));
            Delegates.glGetObjectLabelKHR((OpenTK.Graphics.ES20.ObjectLabelIdentifier)identifier, (UInt32)name, (Int32)bufSize, (Int32*)length, (StringBuilder)label);
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
        internal static unsafe void Load_GetPerfMonitorCounterDataAMD(UInt32 monitor, OpenTK.Graphics.ES20.All pname, Int32 dataSize, [OutAttribute] UInt32* data, [OutAttribute] Int32* bytesWritten)
        {
            Delegates.glGetPerfMonitorCounterDataAMD = (Delegates.GetPerfMonitorCounterDataAMD)GetExtensionDelegateStatic("glGetPerfMonitorCounterDataAMD", typeof(Delegates.GetPerfMonitorCounterDataAMD));
            Delegates.glGetPerfMonitorCounterDataAMD((UInt32)monitor, (OpenTK.Graphics.ES20.All)pname, (Int32)dataSize, (UInt32*)data, (Int32*)bytesWritten);
        }
        internal static void Load_GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr data)
        {
            Delegates.glGetPerfMonitorCounterInfoAMD = (Delegates.GetPerfMonitorCounterInfoAMD)GetExtensionDelegateStatic("glGetPerfMonitorCounterInfoAMD", typeof(Delegates.GetPerfMonitorCounterInfoAMD));
            Delegates.glGetPerfMonitorCounterInfoAMD((UInt32)group, (UInt32)counter, (OpenTK.Graphics.ES20.All)pname, (IntPtr)data);
        }
        internal static unsafe void Load_GetPerfMonitorCountersAMD(UInt32 group, [OutAttribute] Int32* numCounters, [OutAttribute] Int32* maxActiveCounters, Int32 counterSize, [OutAttribute] UInt32* counters)
        {
            Delegates.glGetPerfMonitorCountersAMD = (Delegates.GetPerfMonitorCountersAMD)GetExtensionDelegateStatic("glGetPerfMonitorCountersAMD", typeof(Delegates.GetPerfMonitorCountersAMD));
            Delegates.glGetPerfMonitorCountersAMD((UInt32)group, (Int32*)numCounters, (Int32*)maxActiveCounters, (Int32)counterSize, (UInt32*)counters);
        }
        internal static unsafe void Load_GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder counterString)
        {
            Delegates.glGetPerfMonitorCounterStringAMD = (Delegates.GetPerfMonitorCounterStringAMD)GetExtensionDelegateStatic("glGetPerfMonitorCounterStringAMD", typeof(Delegates.GetPerfMonitorCounterStringAMD));
            Delegates.glGetPerfMonitorCounterStringAMD((UInt32)group, (UInt32)counter, (Int32)bufSize, (Int32*)length, (StringBuilder)counterString);
        }
        internal static unsafe void Load_GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups, Int32 groupsSize, [OutAttribute] UInt32* groups)
        {
            Delegates.glGetPerfMonitorGroupsAMD = (Delegates.GetPerfMonitorGroupsAMD)GetExtensionDelegateStatic("glGetPerfMonitorGroupsAMD", typeof(Delegates.GetPerfMonitorGroupsAMD));
            Delegates.glGetPerfMonitorGroupsAMD((Int32*)numGroups, (Int32)groupsSize, (UInt32*)groups);
        }
        internal static unsafe void Load_GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder groupString)
        {
            Delegates.glGetPerfMonitorGroupStringAMD = (Delegates.GetPerfMonitorGroupStringAMD)GetExtensionDelegateStatic("glGetPerfMonitorGroupStringAMD", typeof(Delegates.GetPerfMonitorGroupStringAMD));
            Delegates.glGetPerfMonitorGroupStringAMD((UInt32)group, (Int32)bufSize, (Int32*)length, (StringBuilder)groupString);
        }
        internal static void Load_GetPointerv(OpenTK.Graphics.ES20.GetPointervPName pname, [OutAttribute] IntPtr @params)
        {
            Delegates.glGetPointerv = (Delegates.GetPointerv)GetExtensionDelegateStatic("glGetPointerv", typeof(Delegates.GetPointerv));
            Delegates.glGetPointerv((OpenTK.Graphics.ES20.GetPointervPName)pname, (IntPtr)@params);
        }
        internal static void Load_GetPointervKHR(OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr @params)
        {
            Delegates.glGetPointervKHR = (Delegates.GetPointervKHR)GetExtensionDelegateStatic("glGetPointervKHR", typeof(Delegates.GetPointervKHR));
            Delegates.glGetPointervKHR((OpenTK.Graphics.ES20.All)pname, (IntPtr)@params);
        }
        internal static unsafe void Load_GetProgramBinaryOES(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.ES20.All* binaryFormat, [OutAttribute] IntPtr binary)
        {
            Delegates.glGetProgramBinaryOES = (Delegates.GetProgramBinaryOES)GetExtensionDelegateStatic("glGetProgramBinaryOES", typeof(Delegates.GetProgramBinaryOES));
            Delegates.glGetProgramBinaryOES((UInt32)program, (Int32)bufSize, (Int32*)length, (OpenTK.Graphics.ES20.All*)binaryFormat, (IntPtr)binary);
        }
        internal static unsafe void Load_GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog)
        {
            Delegates.glGetProgramInfoLog = (Delegates.GetProgramInfoLog)GetExtensionDelegateStatic("glGetProgramInfoLog", typeof(Delegates.GetProgramInfoLog));
            Delegates.glGetProgramInfoLog((UInt32)program, (Int32)bufSize, (Int32*)length, (StringBuilder)infoLog);
        }
        internal static unsafe void Load_GetProgramiv(UInt32 program, OpenTK.Graphics.ES20.GetProgramParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetProgramiv = (Delegates.GetProgramiv)GetExtensionDelegateStatic("glGetProgramiv", typeof(Delegates.GetProgramiv));
            Delegates.glGetProgramiv((UInt32)program, (OpenTK.Graphics.ES20.GetProgramParameterName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog)
        {
            Delegates.glGetProgramPipelineInfoLogEXT = (Delegates.GetProgramPipelineInfoLogEXT)GetExtensionDelegateStatic("glGetProgramPipelineInfoLogEXT", typeof(Delegates.GetProgramPipelineInfoLogEXT));
            Delegates.glGetProgramPipelineInfoLogEXT((UInt32)pipeline, (Int32)bufSize, (Int32*)length, (StringBuilder)infoLog);
        }
        internal static unsafe void Load_GetProgramPipelineivEXT(UInt32 pipeline, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetProgramPipelineivEXT = (Delegates.GetProgramPipelineivEXT)GetExtensionDelegateStatic("glGetProgramPipelineivEXT", typeof(Delegates.GetProgramPipelineivEXT));
            Delegates.glGetProgramPipelineivEXT((UInt32)pipeline, (OpenTK.Graphics.ES20.All)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetQueryivEXT(OpenTK.Graphics.ES20.QueryTarget target, OpenTK.Graphics.ES20.GetQueryParam pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetQueryivEXT = (Delegates.GetQueryivEXT)GetExtensionDelegateStatic("glGetQueryivEXT", typeof(Delegates.GetQueryivEXT));
            Delegates.glGetQueryivEXT((OpenTK.Graphics.ES20.QueryTarget)target, (OpenTK.Graphics.ES20.GetQueryParam)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetQueryObjecti64vEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] Int64* @params)
        {
            Delegates.glGetQueryObjecti64vEXT = (Delegates.GetQueryObjecti64vEXT)GetExtensionDelegateStatic("glGetQueryObjecti64vEXT", typeof(Delegates.GetQueryObjecti64vEXT));
            Delegates.glGetQueryObjecti64vEXT((UInt32)id, (OpenTK.Graphics.ES20.GetQueryObjectParam)pname, (Int64*)@params);
        }
        internal static unsafe void Load_GetQueryObjectivEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetQueryObjectivEXT = (Delegates.GetQueryObjectivEXT)GetExtensionDelegateStatic("glGetQueryObjectivEXT", typeof(Delegates.GetQueryObjectivEXT));
            Delegates.glGetQueryObjectivEXT((UInt32)id, (OpenTK.Graphics.ES20.GetQueryObjectParam)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetQueryObjectui64vEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] UInt64* @params)
        {
            Delegates.glGetQueryObjectui64vEXT = (Delegates.GetQueryObjectui64vEXT)GetExtensionDelegateStatic("glGetQueryObjectui64vEXT", typeof(Delegates.GetQueryObjectui64vEXT));
            Delegates.glGetQueryObjectui64vEXT((UInt32)id, (OpenTK.Graphics.ES20.GetQueryObjectParam)pname, (UInt64*)@params);
        }
        internal static unsafe void Load_GetQueryObjectuivEXT(UInt32 id, OpenTK.Graphics.ES20.GetQueryObjectParam pname, [OutAttribute] UInt32* @params)
        {
            Delegates.glGetQueryObjectuivEXT = (Delegates.GetQueryObjectuivEXT)GetExtensionDelegateStatic("glGetQueryObjectuivEXT", typeof(Delegates.GetQueryObjectuivEXT));
            Delegates.glGetQueryObjectuivEXT((UInt32)id, (OpenTK.Graphics.ES20.GetQueryObjectParam)pname, (UInt32*)@params);
        }
        internal static unsafe void Load_GetRenderbufferParameteriv(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetRenderbufferParameteriv = (Delegates.GetRenderbufferParameteriv)GetExtensionDelegateStatic("glGetRenderbufferParameteriv", typeof(Delegates.GetRenderbufferParameteriv));
            Delegates.glGetRenderbufferParameteriv((OpenTK.Graphics.ES20.RenderbufferTarget)target, (OpenTK.Graphics.ES20.RenderbufferParameterName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog)
        {
            Delegates.glGetShaderInfoLog = (Delegates.GetShaderInfoLog)GetExtensionDelegateStatic("glGetShaderInfoLog", typeof(Delegates.GetShaderInfoLog));
            Delegates.glGetShaderInfoLog((UInt32)shader, (Int32)bufSize, (Int32*)length, (StringBuilder)infoLog);
        }
        internal static unsafe void Load_GetShaderiv(UInt32 shader, OpenTK.Graphics.ES20.ShaderParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetShaderiv = (Delegates.GetShaderiv)GetExtensionDelegateStatic("glGetShaderiv", typeof(Delegates.GetShaderiv));
            Delegates.glGetShaderiv((UInt32)shader, (OpenTK.Graphics.ES20.ShaderParameter)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetShaderPrecisionFormat(OpenTK.Graphics.ES20.ShaderType shadertype, OpenTK.Graphics.ES20.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision)
        {
            Delegates.glGetShaderPrecisionFormat = (Delegates.GetShaderPrecisionFormat)GetExtensionDelegateStatic("glGetShaderPrecisionFormat", typeof(Delegates.GetShaderPrecisionFormat));
            Delegates.glGetShaderPrecisionFormat((OpenTK.Graphics.ES20.ShaderType)shadertype, (OpenTK.Graphics.ES20.ShaderPrecision)precisiontype, (Int32*)range, (Int32*)precision);
        }
        internal static unsafe void Load_GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source)
        {
            Delegates.glGetShaderSource = (Delegates.GetShaderSource)GetExtensionDelegateStatic("glGetShaderSource", typeof(Delegates.GetShaderSource));
            Delegates.glGetShaderSource((UInt32)shader, (Int32)bufSize, (Int32*)length, (StringBuilder)source);
        }
        internal static IntPtr Load_GetString(OpenTK.Graphics.ES20.StringName name)
        {
            Delegates.glGetString = (Delegates.GetString)GetExtensionDelegateStatic("glGetString", typeof(Delegates.GetString));
            return Delegates.glGetString((OpenTK.Graphics.ES20.StringName)name);
        }
        internal static unsafe void Load_GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES20.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values)
        {
            Delegates.glGetSyncivAPPLE = (Delegates.GetSyncivAPPLE)GetExtensionDelegateStatic("glGetSyncivAPPLE", typeof(Delegates.GetSyncivAPPLE));
            Delegates.glGetSyncivAPPLE((IntPtr)sync, (OpenTK.Graphics.ES20.SyncParameterName)pname, (Int32)bufSize, (Int32*)length, (Int32*)values);
        }
        internal static unsafe void Load_GetTexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameterName pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetTexParameterfv = (Delegates.GetTexParameterfv)GetExtensionDelegateStatic("glGetTexParameterfv", typeof(Delegates.GetTexParameterfv));
            Delegates.glGetTexParameterfv((OpenTK.Graphics.ES20.TextureTarget)target, (OpenTK.Graphics.ES20.GetTextureParameterName)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetTexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameterName pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetTexParameteriv = (Delegates.GetTexParameteriv)GetExtensionDelegateStatic("glGetTexParameteriv", typeof(Delegates.GetTexParameteriv));
            Delegates.glGetTexParameteriv((OpenTK.Graphics.ES20.TextureTarget)target, (OpenTK.Graphics.ES20.GetTextureParameterName)pname, (Int32*)@params);
        }
        internal static unsafe void Load_GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source)
        {
            Delegates.glGetTranslatedShaderSourceANGLE = (Delegates.GetTranslatedShaderSourceANGLE)GetExtensionDelegateStatic("glGetTranslatedShaderSourceANGLE", typeof(Delegates.GetTranslatedShaderSourceANGLE));
            Delegates.glGetTranslatedShaderSourceANGLE((UInt32)shader, (Int32)bufsize, (Int32*)length, (StringBuilder)source);
        }
        internal static unsafe void Load_GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params)
        {
            Delegates.glGetUniformfv = (Delegates.GetUniformfv)GetExtensionDelegateStatic("glGetUniformfv", typeof(Delegates.GetUniformfv));
            Delegates.glGetUniformfv((UInt32)program, (Int32)location, (Single*)@params);
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
        internal static unsafe void Load_GetVertexAttribfv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Single* @params)
        {
            Delegates.glGetVertexAttribfv = (Delegates.GetVertexAttribfv)GetExtensionDelegateStatic("glGetVertexAttribfv", typeof(Delegates.GetVertexAttribfv));
            Delegates.glGetVertexAttribfv((UInt32)index, (OpenTK.Graphics.ES20.VertexAttribParameter)pname, (Single*)@params);
        }
        internal static unsafe void Load_GetVertexAttribiv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Int32* @params)
        {
            Delegates.glGetVertexAttribiv = (Delegates.GetVertexAttribiv)GetExtensionDelegateStatic("glGetVertexAttribiv", typeof(Delegates.GetVertexAttribiv));
            Delegates.glGetVertexAttribiv((UInt32)index, (OpenTK.Graphics.ES20.VertexAttribParameter)pname, (Int32*)@params);
        }
        internal static void Load_GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer)
        {
            Delegates.glGetVertexAttribPointerv = (Delegates.GetVertexAttribPointerv)GetExtensionDelegateStatic("glGetVertexAttribPointerv", typeof(Delegates.GetVertexAttribPointerv));
            Delegates.glGetVertexAttribPointerv((UInt32)index, (OpenTK.Graphics.ES20.VertexAttribPointerParameter)pname, (IntPtr)pointer);
        }
        internal static void Load_Hint(OpenTK.Graphics.ES20.HintTarget target, OpenTK.Graphics.ES20.HintMode mode)
        {
            Delegates.glHint = (Delegates.Hint)GetExtensionDelegateStatic("glHint", typeof(Delegates.Hint));
            Delegates.glHint((OpenTK.Graphics.ES20.HintTarget)target, (OpenTK.Graphics.ES20.HintMode)mode);
        }
        internal static void Load_InsertEventMarkerEXT(Int32 length, String marker)
        {
            Delegates.glInsertEventMarkerEXT = (Delegates.InsertEventMarkerEXT)GetExtensionDelegateStatic("glInsertEventMarkerEXT", typeof(Delegates.InsertEventMarkerEXT));
            Delegates.glInsertEventMarkerEXT((Int32)length, (String)marker);
        }
        internal static bool Load_IsBuffer(UInt32 buffer)
        {
            Delegates.glIsBuffer = (Delegates.IsBuffer)GetExtensionDelegateStatic("glIsBuffer", typeof(Delegates.IsBuffer));
            return Delegates.glIsBuffer((UInt32)buffer);
        }
        internal static bool Load_IsEnabled(OpenTK.Graphics.ES20.EnableCap cap)
        {
            Delegates.glIsEnabled = (Delegates.IsEnabled)GetExtensionDelegateStatic("glIsEnabled", typeof(Delegates.IsEnabled));
            return Delegates.glIsEnabled((OpenTK.Graphics.ES20.EnableCap)cap);
        }
        internal static bool Load_IsFenceNV(UInt32 fence)
        {
            Delegates.glIsFenceNV = (Delegates.IsFenceNV)GetExtensionDelegateStatic("glIsFenceNV", typeof(Delegates.IsFenceNV));
            return Delegates.glIsFenceNV((UInt32)fence);
        }
        internal static bool Load_IsFramebuffer(UInt32 framebuffer)
        {
            Delegates.glIsFramebuffer = (Delegates.IsFramebuffer)GetExtensionDelegateStatic("glIsFramebuffer", typeof(Delegates.IsFramebuffer));
            return Delegates.glIsFramebuffer((UInt32)framebuffer);
        }
        internal static bool Load_IsProgram(UInt32 program)
        {
            Delegates.glIsProgram = (Delegates.IsProgram)GetExtensionDelegateStatic("glIsProgram", typeof(Delegates.IsProgram));
            return Delegates.glIsProgram((UInt32)program);
        }
        internal static bool Load_IsProgramPipelineEXT(UInt32 pipeline)
        {
            Delegates.glIsProgramPipelineEXT = (Delegates.IsProgramPipelineEXT)GetExtensionDelegateStatic("glIsProgramPipelineEXT", typeof(Delegates.IsProgramPipelineEXT));
            return Delegates.glIsProgramPipelineEXT((UInt32)pipeline);
        }
        internal static bool Load_IsQueryEXT(UInt32 id)
        {
            Delegates.glIsQueryEXT = (Delegates.IsQueryEXT)GetExtensionDelegateStatic("glIsQueryEXT", typeof(Delegates.IsQueryEXT));
            return Delegates.glIsQueryEXT((UInt32)id);
        }
        internal static bool Load_IsRenderbuffer(UInt32 renderbuffer)
        {
            Delegates.glIsRenderbuffer = (Delegates.IsRenderbuffer)GetExtensionDelegateStatic("glIsRenderbuffer", typeof(Delegates.IsRenderbuffer));
            return Delegates.glIsRenderbuffer((UInt32)renderbuffer);
        }
        internal static bool Load_IsShader(UInt32 shader)
        {
            Delegates.glIsShader = (Delegates.IsShader)GetExtensionDelegateStatic("glIsShader", typeof(Delegates.IsShader));
            return Delegates.glIsShader((UInt32)shader);
        }
        internal static bool Load_IsSyncAPPLE(IntPtr sync)
        {
            Delegates.glIsSyncAPPLE = (Delegates.IsSyncAPPLE)GetExtensionDelegateStatic("glIsSyncAPPLE", typeof(Delegates.IsSyncAPPLE));
            return Delegates.glIsSyncAPPLE((IntPtr)sync);
        }
        internal static bool Load_IsTexture(UInt32 texture)
        {
            Delegates.glIsTexture = (Delegates.IsTexture)GetExtensionDelegateStatic("glIsTexture", typeof(Delegates.IsTexture));
            return Delegates.glIsTexture((UInt32)texture);
        }
        internal static bool Load_IsVertexArrayOES(UInt32 array)
        {
            Delegates.glIsVertexArrayOES = (Delegates.IsVertexArrayOES)GetExtensionDelegateStatic("glIsVertexArrayOES", typeof(Delegates.IsVertexArrayOES));
            return Delegates.glIsVertexArrayOES((UInt32)array);
        }
        internal static void Load_LabelObjectEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 length, String label)
        {
            Delegates.glLabelObjectEXT = (Delegates.LabelObjectEXT)GetExtensionDelegateStatic("glLabelObjectEXT", typeof(Delegates.LabelObjectEXT));
            Delegates.glLabelObjectEXT((OpenTK.Graphics.ES20.All)type, (UInt32)@object, (Int32)length, (String)label);
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
        internal static IntPtr Load_MapBufferOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All access)
        {
            Delegates.glMapBufferOES = (Delegates.MapBufferOES)GetExtensionDelegateStatic("glMapBufferOES", typeof(Delegates.MapBufferOES));
            return Delegates.glMapBufferOES((OpenTK.Graphics.ES20.All)target, (OpenTK.Graphics.ES20.All)access);
        }
        internal static IntPtr Load_MapBufferRangeEXT(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr length, UInt32 access)
        {
            Delegates.glMapBufferRangeEXT = (Delegates.MapBufferRangeEXT)GetExtensionDelegateStatic("glMapBufferRangeEXT", typeof(Delegates.MapBufferRangeEXT));
            return Delegates.glMapBufferRangeEXT((OpenTK.Graphics.ES20.BufferTarget)target, (IntPtr)offset, (IntPtr)length, (UInt32)access);
        }
        internal static unsafe void Load_MultiDrawArraysEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount)
        {
            Delegates.glMultiDrawArraysEXT = (Delegates.MultiDrawArraysEXT)GetExtensionDelegateStatic("glMultiDrawArraysEXT", typeof(Delegates.MultiDrawArraysEXT));
            Delegates.glMultiDrawArraysEXT((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32*)first, (Int32*)count, (Int32)primcount);
        }
        internal static unsafe void Load_MultiDrawElementsEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount)
        {
            Delegates.glMultiDrawElementsEXT = (Delegates.MultiDrawElementsEXT)GetExtensionDelegateStatic("glMultiDrawElementsEXT", typeof(Delegates.MultiDrawElementsEXT));
            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES20.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.ES20.DrawElementsType)type, (IntPtr)indices, (Int32)primcount);
        }
        internal static void Load_ObjectLabel(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label)
        {
            Delegates.glObjectLabel = (Delegates.ObjectLabel)GetExtensionDelegateStatic("glObjectLabel", typeof(Delegates.ObjectLabel));
            Delegates.glObjectLabel((OpenTK.Graphics.ES20.ObjectLabelIdentifier)identifier, (UInt32)name, (Int32)length, (String)label);
        }
        internal static void Load_ObjectLabelKHR(OpenTK.Graphics.ES20.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label)
        {
            Delegates.glObjectLabelKHR = (Delegates.ObjectLabelKHR)GetExtensionDelegateStatic("glObjectLabelKHR", typeof(Delegates.ObjectLabelKHR));
            Delegates.glObjectLabelKHR((OpenTK.Graphics.ES20.ObjectLabelIdentifier)identifier, (UInt32)name, (Int32)length, (String)label);
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
        internal static void Load_PixelStorei(OpenTK.Graphics.ES20.PixelStoreParameter pname, Int32 param)
        {
            Delegates.glPixelStorei = (Delegates.PixelStorei)GetExtensionDelegateStatic("glPixelStorei", typeof(Delegates.PixelStorei));
            Delegates.glPixelStorei((OpenTK.Graphics.ES20.PixelStoreParameter)pname, (Int32)param);
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
        internal static void Load_PopGroupMarkerEXT()
        {
            Delegates.glPopGroupMarkerEXT = (Delegates.PopGroupMarkerEXT)GetExtensionDelegateStatic("glPopGroupMarkerEXT", typeof(Delegates.PopGroupMarkerEXT));
            Delegates.glPopGroupMarkerEXT();
        }
        internal static void Load_ProgramBinaryOES(UInt32 program, OpenTK.Graphics.ES20.All binaryFormat, IntPtr binary, Int32 length)
        {
            Delegates.glProgramBinaryOES = (Delegates.ProgramBinaryOES)GetExtensionDelegateStatic("glProgramBinaryOES", typeof(Delegates.ProgramBinaryOES));
            Delegates.glProgramBinaryOES((UInt32)program, (OpenTK.Graphics.ES20.All)binaryFormat, (IntPtr)binary, (Int32)length);
        }
        internal static void Load_ProgramParameteriEXT(UInt32 program, OpenTK.Graphics.ES20.ProgramParameterName pname, Int32 value)
        {
            Delegates.glProgramParameteriEXT = (Delegates.ProgramParameteriEXT)GetExtensionDelegateStatic("glProgramParameteriEXT", typeof(Delegates.ProgramParameteriEXT));
            Delegates.glProgramParameteriEXT((UInt32)program, (OpenTK.Graphics.ES20.ProgramParameterName)pname, (Int32)value);
        }
        internal static void Load_ProgramUniform1fEXT(UInt32 program, Int32 location, Single v0)
        {
            Delegates.glProgramUniform1fEXT = (Delegates.ProgramUniform1fEXT)GetExtensionDelegateStatic("glProgramUniform1fEXT", typeof(Delegates.ProgramUniform1fEXT));
            Delegates.glProgramUniform1fEXT((UInt32)program, (Int32)location, (Single)v0);
        }
        internal static unsafe void Load_ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform1fvEXT = (Delegates.ProgramUniform1fvEXT)GetExtensionDelegateStatic("glProgramUniform1fvEXT", typeof(Delegates.ProgramUniform1fvEXT));
            Delegates.glProgramUniform1fvEXT((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0)
        {
            Delegates.glProgramUniform1iEXT = (Delegates.ProgramUniform1iEXT)GetExtensionDelegateStatic("glProgramUniform1iEXT", typeof(Delegates.ProgramUniform1iEXT));
            Delegates.glProgramUniform1iEXT((UInt32)program, (Int32)location, (Int32)v0);
        }
        internal static unsafe void Load_ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform1ivEXT = (Delegates.ProgramUniform1ivEXT)GetExtensionDelegateStatic("glProgramUniform1ivEXT", typeof(Delegates.ProgramUniform1ivEXT));
            Delegates.glProgramUniform1ivEXT((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0)
        {
            Delegates.glProgramUniform1uiEXT = (Delegates.ProgramUniform1uiEXT)GetExtensionDelegateStatic("glProgramUniform1uiEXT", typeof(Delegates.ProgramUniform1uiEXT));
            Delegates.glProgramUniform1uiEXT((UInt32)program, (Int32)location, (UInt32)v0);
        }
        internal static unsafe void Load_ProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform1uivEXT = (Delegates.ProgramUniform1uivEXT)GetExtensionDelegateStatic("glProgramUniform1uivEXT", typeof(Delegates.ProgramUniform1uivEXT));
            Delegates.glProgramUniform1uivEXT((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_ProgramUniform2fEXT(UInt32 program, Int32 location, Single v0, Single v1)
        {
            Delegates.glProgramUniform2fEXT = (Delegates.ProgramUniform2fEXT)GetExtensionDelegateStatic("glProgramUniform2fEXT", typeof(Delegates.ProgramUniform2fEXT));
            Delegates.glProgramUniform2fEXT((UInt32)program, (Int32)location, (Single)v0, (Single)v1);
        }
        internal static unsafe void Load_ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform2fvEXT = (Delegates.ProgramUniform2fvEXT)GetExtensionDelegateStatic("glProgramUniform2fvEXT", typeof(Delegates.ProgramUniform2fvEXT));
            Delegates.glProgramUniform2fvEXT((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1)
        {
            Delegates.glProgramUniform2iEXT = (Delegates.ProgramUniform2iEXT)GetExtensionDelegateStatic("glProgramUniform2iEXT", typeof(Delegates.ProgramUniform2iEXT));
            Delegates.glProgramUniform2iEXT((UInt32)program, (Int32)location, (Int32)v0, (Int32)v1);
        }
        internal static unsafe void Load_ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform2ivEXT = (Delegates.ProgramUniform2ivEXT)GetExtensionDelegateStatic("glProgramUniform2ivEXT", typeof(Delegates.ProgramUniform2ivEXT));
            Delegates.glProgramUniform2ivEXT((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1)
        {
            Delegates.glProgramUniform2uiEXT = (Delegates.ProgramUniform2uiEXT)GetExtensionDelegateStatic("glProgramUniform2uiEXT", typeof(Delegates.ProgramUniform2uiEXT));
            Delegates.glProgramUniform2uiEXT((UInt32)program, (Int32)location, (UInt32)v0, (UInt32)v1);
        }
        internal static unsafe void Load_ProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform2uivEXT = (Delegates.ProgramUniform2uivEXT)GetExtensionDelegateStatic("glProgramUniform2uivEXT", typeof(Delegates.ProgramUniform2uivEXT));
            Delegates.glProgramUniform2uivEXT((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_ProgramUniform3fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2)
        {
            Delegates.glProgramUniform3fEXT = (Delegates.ProgramUniform3fEXT)GetExtensionDelegateStatic("glProgramUniform3fEXT", typeof(Delegates.ProgramUniform3fEXT));
            Delegates.glProgramUniform3fEXT((UInt32)program, (Int32)location, (Single)v0, (Single)v1, (Single)v2);
        }
        internal static unsafe void Load_ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform3fvEXT = (Delegates.ProgramUniform3fvEXT)GetExtensionDelegateStatic("glProgramUniform3fvEXT", typeof(Delegates.ProgramUniform3fvEXT));
            Delegates.glProgramUniform3fvEXT((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
        {
            Delegates.glProgramUniform3iEXT = (Delegates.ProgramUniform3iEXT)GetExtensionDelegateStatic("glProgramUniform3iEXT", typeof(Delegates.ProgramUniform3iEXT));
            Delegates.glProgramUniform3iEXT((UInt32)program, (Int32)location, (Int32)v0, (Int32)v1, (Int32)v2);
        }
        internal static unsafe void Load_ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform3ivEXT = (Delegates.ProgramUniform3ivEXT)GetExtensionDelegateStatic("glProgramUniform3ivEXT", typeof(Delegates.ProgramUniform3ivEXT));
            Delegates.glProgramUniform3ivEXT((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
        {
            Delegates.glProgramUniform3uiEXT = (Delegates.ProgramUniform3uiEXT)GetExtensionDelegateStatic("glProgramUniform3uiEXT", typeof(Delegates.ProgramUniform3uiEXT));
            Delegates.glProgramUniform3uiEXT((UInt32)program, (Int32)location, (UInt32)v0, (UInt32)v1, (UInt32)v2);
        }
        internal static unsafe void Load_ProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform3uivEXT = (Delegates.ProgramUniform3uivEXT)GetExtensionDelegateStatic("glProgramUniform3uivEXT", typeof(Delegates.ProgramUniform3uivEXT));
            Delegates.glProgramUniform3uivEXT((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static void Load_ProgramUniform4fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3)
        {
            Delegates.glProgramUniform4fEXT = (Delegates.ProgramUniform4fEXT)GetExtensionDelegateStatic("glProgramUniform4fEXT", typeof(Delegates.ProgramUniform4fEXT));
            Delegates.glProgramUniform4fEXT((UInt32)program, (Int32)location, (Single)v0, (Single)v1, (Single)v2, (Single)v3);
        }
        internal static unsafe void Load_ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value)
        {
            Delegates.glProgramUniform4fvEXT = (Delegates.ProgramUniform4fvEXT)GetExtensionDelegateStatic("glProgramUniform4fvEXT", typeof(Delegates.ProgramUniform4fvEXT));
            Delegates.glProgramUniform4fvEXT((UInt32)program, (Int32)location, (Int32)count, (Single*)value);
        }
        internal static void Load_ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
        {
            Delegates.glProgramUniform4iEXT = (Delegates.ProgramUniform4iEXT)GetExtensionDelegateStatic("glProgramUniform4iEXT", typeof(Delegates.ProgramUniform4iEXT));
            Delegates.glProgramUniform4iEXT((UInt32)program, (Int32)location, (Int32)v0, (Int32)v1, (Int32)v2, (Int32)v3);
        }
        internal static unsafe void Load_ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value)
        {
            Delegates.glProgramUniform4ivEXT = (Delegates.ProgramUniform4ivEXT)GetExtensionDelegateStatic("glProgramUniform4ivEXT", typeof(Delegates.ProgramUniform4ivEXT));
            Delegates.glProgramUniform4ivEXT((UInt32)program, (Int32)location, (Int32)count, (Int32*)value);
        }
        internal static void Load_ProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
        {
            Delegates.glProgramUniform4uiEXT = (Delegates.ProgramUniform4uiEXT)GetExtensionDelegateStatic("glProgramUniform4uiEXT", typeof(Delegates.ProgramUniform4uiEXT));
            Delegates.glProgramUniform4uiEXT((UInt32)program, (Int32)location, (UInt32)v0, (UInt32)v1, (UInt32)v2, (UInt32)v3);
        }
        internal static unsafe void Load_ProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value)
        {
            Delegates.glProgramUniform4uivEXT = (Delegates.ProgramUniform4uivEXT)GetExtensionDelegateStatic("glProgramUniform4uivEXT", typeof(Delegates.ProgramUniform4uivEXT));
            Delegates.glProgramUniform4uivEXT((UInt32)program, (Int32)location, (Int32)count, (UInt32*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix2fvEXT = (Delegates.ProgramUniformMatrix2fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix2fvEXT", typeof(Delegates.ProgramUniformMatrix2fvEXT));
            Delegates.glProgramUniformMatrix2fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix2x3fvEXT = (Delegates.ProgramUniformMatrix2x3fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix2x3fvEXT", typeof(Delegates.ProgramUniformMatrix2x3fvEXT));
            Delegates.glProgramUniformMatrix2x3fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix2x4fvEXT = (Delegates.ProgramUniformMatrix2x4fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix2x4fvEXT", typeof(Delegates.ProgramUniformMatrix2x4fvEXT));
            Delegates.glProgramUniformMatrix2x4fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix3fvEXT = (Delegates.ProgramUniformMatrix3fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix3fvEXT", typeof(Delegates.ProgramUniformMatrix3fvEXT));
            Delegates.glProgramUniformMatrix3fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix3x2fvEXT = (Delegates.ProgramUniformMatrix3x2fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix3x2fvEXT", typeof(Delegates.ProgramUniformMatrix3x2fvEXT));
            Delegates.glProgramUniformMatrix3x2fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix3x4fvEXT = (Delegates.ProgramUniformMatrix3x4fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix3x4fvEXT", typeof(Delegates.ProgramUniformMatrix3x4fvEXT));
            Delegates.glProgramUniformMatrix3x4fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix4fvEXT = (Delegates.ProgramUniformMatrix4fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix4fvEXT", typeof(Delegates.ProgramUniformMatrix4fvEXT));
            Delegates.glProgramUniformMatrix4fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix4x2fvEXT = (Delegates.ProgramUniformMatrix4x2fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix4x2fvEXT", typeof(Delegates.ProgramUniformMatrix4x2fvEXT));
            Delegates.glProgramUniformMatrix4x2fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_ProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glProgramUniformMatrix4x3fvEXT = (Delegates.ProgramUniformMatrix4x3fvEXT)GetExtensionDelegateStatic("glProgramUniformMatrix4x3fvEXT", typeof(Delegates.ProgramUniformMatrix4x3fvEXT));
            Delegates.glProgramUniformMatrix4x3fvEXT((UInt32)program, (Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static void Load_PushDebugGroup(OpenTK.Graphics.ES20.All source, UInt32 id, Int32 length, String message)
        {
            Delegates.glPushDebugGroup = (Delegates.PushDebugGroup)GetExtensionDelegateStatic("glPushDebugGroup", typeof(Delegates.PushDebugGroup));
            Delegates.glPushDebugGroup((OpenTK.Graphics.ES20.All)source, (UInt32)id, (Int32)length, (String)message);
        }
        internal static void Load_PushDebugGroupKHR(OpenTK.Graphics.ES20.All source, UInt32 id, Int32 length, String message)
        {
            Delegates.glPushDebugGroupKHR = (Delegates.PushDebugGroupKHR)GetExtensionDelegateStatic("glPushDebugGroupKHR", typeof(Delegates.PushDebugGroupKHR));
            Delegates.glPushDebugGroupKHR((OpenTK.Graphics.ES20.All)source, (UInt32)id, (Int32)length, (String)message);
        }
        internal static void Load_PushGroupMarkerEXT(Int32 length, String marker)
        {
            Delegates.glPushGroupMarkerEXT = (Delegates.PushGroupMarkerEXT)GetExtensionDelegateStatic("glPushGroupMarkerEXT", typeof(Delegates.PushGroupMarkerEXT));
            Delegates.glPushGroupMarkerEXT((Int32)length, (String)marker);
        }
        internal static void Load_QueryCounterEXT(UInt32 id, OpenTK.Graphics.ES20.All target)
        {
            Delegates.glQueryCounterEXT = (Delegates.QueryCounterEXT)GetExtensionDelegateStatic("glQueryCounterEXT", typeof(Delegates.QueryCounterEXT));
            Delegates.glQueryCounterEXT((UInt32)id, (OpenTK.Graphics.ES20.All)target);
        }
        internal static void Load_ReadBufferIndexedEXT(OpenTK.Graphics.ES20.All src, Int32 index)
        {
            Delegates.glReadBufferIndexedEXT = (Delegates.ReadBufferIndexedEXT)GetExtensionDelegateStatic("glReadBufferIndexedEXT", typeof(Delegates.ReadBufferIndexedEXT));
            Delegates.glReadBufferIndexedEXT((OpenTK.Graphics.ES20.All)src, (Int32)index);
        }
        internal static void Load_ReadBufferNV(OpenTK.Graphics.ES20.All mode)
        {
            Delegates.glReadBufferNV = (Delegates.ReadBufferNV)GetExtensionDelegateStatic("glReadBufferNV", typeof(Delegates.ReadBufferNV));
            Delegates.glReadBufferNV((OpenTK.Graphics.ES20.All)mode);
        }
        internal static void Load_ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, Int32 bufSize, [OutAttribute] IntPtr data)
        {
            Delegates.glReadnPixelsEXT = (Delegates.ReadnPixelsEXT)GetExtensionDelegateStatic("glReadnPixelsEXT", typeof(Delegates.ReadnPixelsEXT));
            Delegates.glReadnPixelsEXT((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES20.All)format, (OpenTK.Graphics.ES20.All)type, (Int32)bufSize, (IntPtr)data);
        }
        internal static void Load_ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, [OutAttribute] IntPtr pixels)
        {
            Delegates.glReadPixels = (Delegates.ReadPixels)GetExtensionDelegateStatic("glReadPixels", typeof(Delegates.ReadPixels));
            Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES20.PixelFormat)format, (OpenTK.Graphics.ES20.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_ReleaseShaderCompiler()
        {
            Delegates.glReleaseShaderCompiler = (Delegates.ReleaseShaderCompiler)GetExtensionDelegateStatic("glReleaseShaderCompiler", typeof(Delegates.ReleaseShaderCompiler));
            Delegates.glReleaseShaderCompiler();
        }
        internal static void Load_RenderbufferStorage(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorage = (Delegates.RenderbufferStorage)GetExtensionDelegateStatic("glRenderbufferStorage", typeof(Delegates.RenderbufferStorage));
            Delegates.glRenderbufferStorage((OpenTK.Graphics.ES20.RenderbufferTarget)target, (OpenTK.Graphics.ES20.RenderbufferInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_RenderbufferStorageMultisampleANGLE(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorageMultisampleANGLE = (Delegates.RenderbufferStorageMultisampleANGLE)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleANGLE", typeof(Delegates.RenderbufferStorageMultisampleANGLE));
            Delegates.glRenderbufferStorageMultisampleANGLE((OpenTK.Graphics.ES20.RenderbufferTarget)target, (Int32)samples, (OpenTK.Graphics.ES20.RenderbufferInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorageMultisampleAPPLE = (Delegates.RenderbufferStorageMultisampleAPPLE)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleAPPLE", typeof(Delegates.RenderbufferStorageMultisampleAPPLE));
            Delegates.glRenderbufferStorageMultisampleAPPLE((OpenTK.Graphics.ES20.RenderbufferTarget)target, (Int32)samples, (OpenTK.Graphics.ES20.RenderbufferInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorageMultisampleEXT = (Delegates.RenderbufferStorageMultisampleEXT)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleEXT", typeof(Delegates.RenderbufferStorageMultisampleEXT));
            Delegates.glRenderbufferStorageMultisampleEXT((OpenTK.Graphics.ES20.RenderbufferTarget)target, (Int32)samples, (OpenTK.Graphics.ES20.RenderbufferInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorageMultisampleIMG = (Delegates.RenderbufferStorageMultisampleIMG)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleIMG", typeof(Delegates.RenderbufferStorageMultisampleIMG));
            Delegates.glRenderbufferStorageMultisampleIMG((OpenTK.Graphics.ES20.RenderbufferTarget)target, (Int32)samples, (OpenTK.Graphics.ES20.RenderbufferInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_RenderbufferStorageMultisampleNV(OpenTK.Graphics.ES20.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorageMultisampleNV = (Delegates.RenderbufferStorageMultisampleNV)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleNV", typeof(Delegates.RenderbufferStorageMultisampleNV));
            Delegates.glRenderbufferStorageMultisampleNV((OpenTK.Graphics.ES20.RenderbufferTarget)target, (Int32)samples, (OpenTK.Graphics.ES20.RenderbufferInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_ResolveMultisampleFramebufferAPPLE()
        {
            Delegates.glResolveMultisampleFramebufferAPPLE = (Delegates.ResolveMultisampleFramebufferAPPLE)GetExtensionDelegateStatic("glResolveMultisampleFramebufferAPPLE", typeof(Delegates.ResolveMultisampleFramebufferAPPLE));
            Delegates.glResolveMultisampleFramebufferAPPLE();
        }
        internal static void Load_SampleCoverage(Single value, bool invert)
        {
            Delegates.glSampleCoverage = (Delegates.SampleCoverage)GetExtensionDelegateStatic("glSampleCoverage", typeof(Delegates.SampleCoverage));
            Delegates.glSampleCoverage((Single)value, (bool)invert);
        }
        internal static void Load_Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glScissor = (Delegates.Scissor)GetExtensionDelegateStatic("glScissor", typeof(Delegates.Scissor));
            Delegates.glScissor((Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static unsafe void Load_SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, [OutAttribute] UInt32* counterList)
        {
            Delegates.glSelectPerfMonitorCountersAMD = (Delegates.SelectPerfMonitorCountersAMD)GetExtensionDelegateStatic("glSelectPerfMonitorCountersAMD", typeof(Delegates.SelectPerfMonitorCountersAMD));
            Delegates.glSelectPerfMonitorCountersAMD((UInt32)monitor, (bool)enable, (UInt32)group, (Int32)numCounters, (UInt32*)counterList);
        }
        internal static void Load_SetFenceNV(UInt32 fence, OpenTK.Graphics.ES20.All condition)
        {
            Delegates.glSetFenceNV = (Delegates.SetFenceNV)GetExtensionDelegateStatic("glSetFenceNV", typeof(Delegates.SetFenceNV));
            Delegates.glSetFenceNV((UInt32)fence, (OpenTK.Graphics.ES20.All)condition);
        }
        internal static unsafe void Load_ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.ES20.ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length)
        {
            Delegates.glShaderBinary = (Delegates.ShaderBinary)GetExtensionDelegateStatic("glShaderBinary", typeof(Delegates.ShaderBinary));
            Delegates.glShaderBinary((Int32)count, (UInt32*)shaders, (OpenTK.Graphics.ES20.ShaderBinaryFormat)binaryformat, (IntPtr)binary, (Int32)length);
        }
        internal static unsafe void Load_ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length)
        {
            Delegates.glShaderSource = (Delegates.ShaderSource)GetExtensionDelegateStatic("glShaderSource", typeof(Delegates.ShaderSource));
            Delegates.glShaderSource((UInt32)shader, (Int32)count, (String[])@string, (Int32*)length);
        }
        internal static void Load_StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask)
        {
            Delegates.glStartTilingQCOM = (Delegates.StartTilingQCOM)GetExtensionDelegateStatic("glStartTilingQCOM", typeof(Delegates.StartTilingQCOM));
            Delegates.glStartTilingQCOM((UInt32)x, (UInt32)y, (UInt32)width, (UInt32)height, (UInt32)preserveMask);
        }
        internal static void Load_StencilFunc(OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask)
        {
            Delegates.glStencilFunc = (Delegates.StencilFunc)GetExtensionDelegateStatic("glStencilFunc", typeof(Delegates.StencilFunc));
            Delegates.glStencilFunc((OpenTK.Graphics.ES20.StencilFunction)func, (Int32)@ref, (UInt32)mask);
        }
        internal static void Load_StencilFuncSeparate(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask)
        {
            Delegates.glStencilFuncSeparate = (Delegates.StencilFuncSeparate)GetExtensionDelegateStatic("glStencilFuncSeparate", typeof(Delegates.StencilFuncSeparate));
            Delegates.glStencilFuncSeparate((OpenTK.Graphics.ES20.StencilFace)face, (OpenTK.Graphics.ES20.StencilFunction)func, (Int32)@ref, (UInt32)mask);
        }
        internal static void Load_StencilMask(UInt32 mask)
        {
            Delegates.glStencilMask = (Delegates.StencilMask)GetExtensionDelegateStatic("glStencilMask", typeof(Delegates.StencilMask));
            Delegates.glStencilMask((UInt32)mask);
        }
        internal static void Load_StencilMaskSeparate(OpenTK.Graphics.ES20.StencilFace face, UInt32 mask)
        {
            Delegates.glStencilMaskSeparate = (Delegates.StencilMaskSeparate)GetExtensionDelegateStatic("glStencilMaskSeparate", typeof(Delegates.StencilMaskSeparate));
            Delegates.glStencilMaskSeparate((OpenTK.Graphics.ES20.StencilFace)face, (UInt32)mask);
        }
        internal static void Load_StencilOp(OpenTK.Graphics.ES20.StencilOp fail, OpenTK.Graphics.ES20.StencilOp zfail, OpenTK.Graphics.ES20.StencilOp zpass)
        {
            Delegates.glStencilOp = (Delegates.StencilOp)GetExtensionDelegateStatic("glStencilOp", typeof(Delegates.StencilOp));
            Delegates.glStencilOp((OpenTK.Graphics.ES20.StencilOp)fail, (OpenTK.Graphics.ES20.StencilOp)zfail, (OpenTK.Graphics.ES20.StencilOp)zpass);
        }
        internal static void Load_StencilOpSeparate(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilOp sfail, OpenTK.Graphics.ES20.StencilOp dpfail, OpenTK.Graphics.ES20.StencilOp dppass)
        {
            Delegates.glStencilOpSeparate = (Delegates.StencilOpSeparate)GetExtensionDelegateStatic("glStencilOpSeparate", typeof(Delegates.StencilOpSeparate));
            Delegates.glStencilOpSeparate((OpenTK.Graphics.ES20.StencilFace)face, (OpenTK.Graphics.ES20.StencilOp)sfail, (OpenTK.Graphics.ES20.StencilOp)dpfail, (OpenTK.Graphics.ES20.StencilOp)dppass);
        }
        internal static bool Load_TestFenceNV(UInt32 fence)
        {
            Delegates.glTestFenceNV = (Delegates.TestFenceNV)GetExtensionDelegateStatic("glTestFenceNV", typeof(Delegates.TestFenceNV));
            return Delegates.glTestFenceNV((UInt32)fence);
        }
        internal static void Load_TexImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, OpenTK.Graphics.ES20.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels)
        {
            Delegates.glTexImage2D = (Delegates.TexImage2D)GetExtensionDelegateStatic("glTexImage2D", typeof(Delegates.TexImage2D));
            Delegates.glTexImage2D((OpenTK.Graphics.ES20.TextureTarget2d)target, (Int32)level, (OpenTK.Graphics.ES20.TextureComponentCount)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.ES20.PixelFormat)format, (OpenTK.Graphics.ES20.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, OpenTK.Graphics.ES20.TextureComponentCount internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels)
        {
            Delegates.glTexImage3DOES = (Delegates.TexImage3DOES)GetExtensionDelegateStatic("glTexImage3DOES", typeof(Delegates.TexImage3DOES));
            Delegates.glTexImage3DOES((OpenTK.Graphics.ES20.TextureTarget3d)target, (Int32)level, (OpenTK.Graphics.ES20.TextureComponentCount)internalformat, (Int32)width, (Int32)height, (Int32)depth, (Int32)border, (OpenTK.Graphics.ES20.PixelFormat)format, (OpenTK.Graphics.ES20.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexParameterf(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single param)
        {
            Delegates.glTexParameterf = (Delegates.TexParameterf)GetExtensionDelegateStatic("glTexParameterf", typeof(Delegates.TexParameterf));
            Delegates.glTexParameterf((OpenTK.Graphics.ES20.TextureTarget)target, (OpenTK.Graphics.ES20.TextureParameterName)pname, (Single)param);
        }
        internal static unsafe void Load_TexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single* @params)
        {
            Delegates.glTexParameterfv = (Delegates.TexParameterfv)GetExtensionDelegateStatic("glTexParameterfv", typeof(Delegates.TexParameterfv));
            Delegates.glTexParameterfv((OpenTK.Graphics.ES20.TextureTarget)target, (OpenTK.Graphics.ES20.TextureParameterName)pname, (Single*)@params);
        }
        internal static void Load_TexParameteri(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32 param)
        {
            Delegates.glTexParameteri = (Delegates.TexParameteri)GetExtensionDelegateStatic("glTexParameteri", typeof(Delegates.TexParameteri));
            Delegates.glTexParameteri((OpenTK.Graphics.ES20.TextureTarget)target, (OpenTK.Graphics.ES20.TextureParameterName)pname, (Int32)param);
        }
        internal static unsafe void Load_TexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32* @params)
        {
            Delegates.glTexParameteriv = (Delegates.TexParameteriv)GetExtensionDelegateStatic("glTexParameteriv", typeof(Delegates.TexParameteriv));
            Delegates.glTexParameteriv((OpenTK.Graphics.ES20.TextureTarget)target, (OpenTK.Graphics.ES20.TextureParameterName)pname, (Int32*)@params);
        }
        internal static void Load_TexStorage1DEXT(OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width)
        {
            Delegates.glTexStorage1DEXT = (Delegates.TexStorage1DEXT)GetExtensionDelegateStatic("glTexStorage1DEXT", typeof(Delegates.TexStorage1DEXT));
            Delegates.glTexStorage1DEXT((OpenTK.Graphics.ES20.All)target, (Int32)levels, (OpenTK.Graphics.ES20.All)internalformat, (Int32)width);
        }
        internal static void Load_TexStorage2DEXT(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 levels, OpenTK.Graphics.ES20.SizedInternalFormat internalformat, Int32 width, Int32 height)
        {
            Delegates.glTexStorage2DEXT = (Delegates.TexStorage2DEXT)GetExtensionDelegateStatic("glTexStorage2DEXT", typeof(Delegates.TexStorage2DEXT));
            Delegates.glTexStorage2DEXT((OpenTK.Graphics.ES20.TextureTarget2d)target, (Int32)levels, (OpenTK.Graphics.ES20.SizedInternalFormat)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_TexStorage3DEXT(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 levels, OpenTK.Graphics.ES20.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth)
        {
            Delegates.glTexStorage3DEXT = (Delegates.TexStorage3DEXT)GetExtensionDelegateStatic("glTexStorage3DEXT", typeof(Delegates.TexStorage3DEXT));
            Delegates.glTexStorage3DEXT((OpenTK.Graphics.ES20.TextureTarget3d)target, (Int32)levels, (OpenTK.Graphics.ES20.SizedInternalFormat)internalformat, (Int32)width, (Int32)height, (Int32)depth);
        }
        internal static void Load_TexSubImage2D(OpenTK.Graphics.ES20.TextureTarget2d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage2D = (Delegates.TexSubImage2D)GetExtensionDelegateStatic("glTexSubImage2D", typeof(Delegates.TexSubImage2D));
            Delegates.glTexSubImage2D((OpenTK.Graphics.ES20.TextureTarget2d)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES20.PixelFormat)format, (OpenTK.Graphics.ES20.PixelType)type, (IntPtr)pixels);
        }
        internal static void Load_TexSubImage3DOES(OpenTK.Graphics.ES20.TextureTarget3d target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, IntPtr pixels)
        {
            Delegates.glTexSubImage3DOES = (Delegates.TexSubImage3DOES)GetExtensionDelegateStatic("glTexSubImage3DOES", typeof(Delegates.TexSubImage3DOES));
            Delegates.glTexSubImage3DOES((OpenTK.Graphics.ES20.TextureTarget3d)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES20.All)format, (OpenTK.Graphics.ES20.All)type, (IntPtr)pixels);
        }
        internal static void Load_TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width)
        {
            Delegates.glTextureStorage1DEXT = (Delegates.TextureStorage1DEXT)GetExtensionDelegateStatic("glTextureStorage1DEXT", typeof(Delegates.TextureStorage1DEXT));
            Delegates.glTextureStorage1DEXT((UInt32)texture, (OpenTK.Graphics.ES20.All)target, (Int32)levels, (OpenTK.Graphics.ES20.All)internalformat, (Int32)width);
        }
        internal static void Load_TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height)
        {
            Delegates.glTextureStorage2DEXT = (Delegates.TextureStorage2DEXT)GetExtensionDelegateStatic("glTextureStorage2DEXT", typeof(Delegates.TextureStorage2DEXT));
            Delegates.glTextureStorage2DEXT((UInt32)texture, (OpenTK.Graphics.ES20.All)target, (Int32)levels, (OpenTK.Graphics.ES20.All)internalformat, (Int32)width, (Int32)height);
        }
        internal static void Load_TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height, Int32 depth)
        {
            Delegates.glTextureStorage3DEXT = (Delegates.TextureStorage3DEXT)GetExtensionDelegateStatic("glTextureStorage3DEXT", typeof(Delegates.TextureStorage3DEXT));
            Delegates.glTextureStorage3DEXT((UInt32)texture, (OpenTK.Graphics.ES20.All)target, (Int32)levels, (OpenTK.Graphics.ES20.All)internalformat, (Int32)width, (Int32)height, (Int32)depth);
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
        internal static unsafe void Load_UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix2fv = (Delegates.UniformMatrix2fv)GetExtensionDelegateStatic("glUniformMatrix2fv", typeof(Delegates.UniformMatrix2fv));
            Delegates.glUniformMatrix2fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix2x3fvNV(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix2x3fvNV = (Delegates.UniformMatrix2x3fvNV)GetExtensionDelegateStatic("glUniformMatrix2x3fvNV", typeof(Delegates.UniformMatrix2x3fvNV));
            Delegates.glUniformMatrix2x3fvNV((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix2x4fvNV(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix2x4fvNV = (Delegates.UniformMatrix2x4fvNV)GetExtensionDelegateStatic("glUniformMatrix2x4fvNV", typeof(Delegates.UniformMatrix2x4fvNV));
            Delegates.glUniformMatrix2x4fvNV((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix3fv = (Delegates.UniformMatrix3fv)GetExtensionDelegateStatic("glUniformMatrix3fv", typeof(Delegates.UniformMatrix3fv));
            Delegates.glUniformMatrix3fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix3x2fvNV(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix3x2fvNV = (Delegates.UniformMatrix3x2fvNV)GetExtensionDelegateStatic("glUniformMatrix3x2fvNV", typeof(Delegates.UniformMatrix3x2fvNV));
            Delegates.glUniformMatrix3x2fvNV((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix3x4fvNV(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix3x4fvNV = (Delegates.UniformMatrix3x4fvNV)GetExtensionDelegateStatic("glUniformMatrix3x4fvNV", typeof(Delegates.UniformMatrix3x4fvNV));
            Delegates.glUniformMatrix3x4fvNV((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix4fv = (Delegates.UniformMatrix4fv)GetExtensionDelegateStatic("glUniformMatrix4fv", typeof(Delegates.UniformMatrix4fv));
            Delegates.glUniformMatrix4fv((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix4x2fvNV(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix4x2fvNV = (Delegates.UniformMatrix4x2fvNV)GetExtensionDelegateStatic("glUniformMatrix4x2fvNV", typeof(Delegates.UniformMatrix4x2fvNV));
            Delegates.glUniformMatrix4x2fvNV((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static unsafe void Load_UniformMatrix4x3fvNV(Int32 location, Int32 count, bool transpose, Single* value)
        {
            Delegates.glUniformMatrix4x3fvNV = (Delegates.UniformMatrix4x3fvNV)GetExtensionDelegateStatic("glUniformMatrix4x3fvNV", typeof(Delegates.UniformMatrix4x3fvNV));
            Delegates.glUniformMatrix4x3fvNV((Int32)location, (Int32)count, (bool)transpose, (Single*)value);
        }
        internal static bool Load_UnmapBufferOES(OpenTK.Graphics.ES20.BufferTarget target)
        {
            Delegates.glUnmapBufferOES = (Delegates.UnmapBufferOES)GetExtensionDelegateStatic("glUnmapBufferOES", typeof(Delegates.UnmapBufferOES));
            return Delegates.glUnmapBufferOES((OpenTK.Graphics.ES20.BufferTarget)target);
        }
        internal static void Load_UseProgram(UInt32 program)
        {
            Delegates.glUseProgram = (Delegates.UseProgram)GetExtensionDelegateStatic("glUseProgram", typeof(Delegates.UseProgram));
            Delegates.glUseProgram((UInt32)program);
        }
        internal static void Load_UseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program)
        {
            Delegates.glUseProgramStagesEXT = (Delegates.UseProgramStagesEXT)GetExtensionDelegateStatic("glUseProgramStagesEXT", typeof(Delegates.UseProgramStagesEXT));
            Delegates.glUseProgramStagesEXT((UInt32)pipeline, (UInt32)stages, (UInt32)program);
        }
        internal static void Load_UseShaderProgramEXT(OpenTK.Graphics.ES20.All type, UInt32 program)
        {
            Delegates.glUseShaderProgramEXT = (Delegates.UseShaderProgramEXT)GetExtensionDelegateStatic("glUseShaderProgramEXT", typeof(Delegates.UseShaderProgramEXT));
            Delegates.glUseShaderProgramEXT((OpenTK.Graphics.ES20.All)type, (UInt32)program);
        }
        internal static void Load_ValidateProgram(UInt32 program)
        {
            Delegates.glValidateProgram = (Delegates.ValidateProgram)GetExtensionDelegateStatic("glValidateProgram", typeof(Delegates.ValidateProgram));
            Delegates.glValidateProgram((UInt32)program);
        }
        internal static void Load_ValidateProgramPipelineEXT(UInt32 pipeline)
        {
            Delegates.glValidateProgramPipelineEXT = (Delegates.ValidateProgramPipelineEXT)GetExtensionDelegateStatic("glValidateProgramPipelineEXT", typeof(Delegates.ValidateProgramPipelineEXT));
            Delegates.glValidateProgramPipelineEXT((UInt32)pipeline);
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
        internal static void Load_VertexAttribDivisorANGLE(UInt32 index, UInt32 divisor)
        {
            Delegates.glVertexAttribDivisorANGLE = (Delegates.VertexAttribDivisorANGLE)GetExtensionDelegateStatic("glVertexAttribDivisorANGLE", typeof(Delegates.VertexAttribDivisorANGLE));
            Delegates.glVertexAttribDivisorANGLE((UInt32)index, (UInt32)divisor);
        }
        internal static void Load_VertexAttribDivisorEXT(UInt32 index, UInt32 divisor)
        {
            Delegates.glVertexAttribDivisorEXT = (Delegates.VertexAttribDivisorEXT)GetExtensionDelegateStatic("glVertexAttribDivisorEXT", typeof(Delegates.VertexAttribDivisorEXT));
            Delegates.glVertexAttribDivisorEXT((UInt32)index, (UInt32)divisor);
        }
        internal static void Load_VertexAttribDivisorNV(UInt32 index, UInt32 divisor)
        {
            Delegates.glVertexAttribDivisorNV = (Delegates.VertexAttribDivisorNV)GetExtensionDelegateStatic("glVertexAttribDivisorNV", typeof(Delegates.VertexAttribDivisorNV));
            Delegates.glVertexAttribDivisorNV((UInt32)index, (UInt32)divisor);
        }
        internal static void Load_VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.ES20.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer)
        {
            Delegates.glVertexAttribPointer = (Delegates.VertexAttribPointer)GetExtensionDelegateStatic("glVertexAttribPointer", typeof(Delegates.VertexAttribPointer));
            Delegates.glVertexAttribPointer((UInt32)index, (Int32)size, (OpenTK.Graphics.ES20.VertexAttribPointerType)type, (bool)normalized, (Int32)stride, (IntPtr)pointer);
        }
        internal static void Load_Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glViewport = (Delegates.Viewport)GetExtensionDelegateStatic("glViewport", typeof(Delegates.Viewport));
            Delegates.glViewport((Int32)x, (Int32)y, (Int32)width, (Int32)height);
        }
        internal static void Load_WaitSyncAPPLE(IntPtr sync, OpenTK.Graphics.ES20.WaitSyncFlags flags, UInt64 timeout)
        {
            Delegates.glWaitSyncAPPLE = (Delegates.WaitSyncAPPLE)GetExtensionDelegateStatic("glWaitSyncAPPLE", typeof(Delegates.WaitSyncAPPLE));
            Delegates.glWaitSyncAPPLE((IntPtr)sync, (OpenTK.Graphics.ES20.WaitSyncFlags)flags, (UInt64)timeout);
        }
    }
}
