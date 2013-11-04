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
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {

        internal static partial class Core
        {

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveProgramEXT", ExactSpelling = true)]
            internal extern static void ActiveProgramEXT(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveShaderProgramEXT", ExactSpelling = true)]
            internal extern static void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture(OpenTK.Graphics.ES20.TextureUnit texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFuncQCOM", ExactSpelling = true)]
            internal extern static void AlphaFuncQCOM(OpenTK.Graphics.ES20.All func, Single @ref);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal extern static void AttachShader(UInt32 program, UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginPerfMonitorAMD", ExactSpelling = true)]
            internal extern static void BeginPerfMonitorAMD(UInt32 monitor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginQueryEXT", ExactSpelling = true)]
            internal extern static void BeginQueryEXT(OpenTK.Graphics.ES20.All target, UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal extern static void BindAttribLocation(UInt32 program, UInt32 index, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal extern static void BindBuffer(OpenTK.Graphics.ES20.BufferTarget target, UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
            internal extern static void BindFramebuffer(OpenTK.Graphics.ES20.FramebufferTarget target, UInt32 framebuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindProgramPipelineEXT", ExactSpelling = true)]
            internal extern static void BindProgramPipelineEXT(UInt32 pipeline);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
            internal extern static void BindRenderbuffer(OpenTK.Graphics.ES20.RenderbufferTarget target, UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture(OpenTK.Graphics.ES20.TextureTarget target, UInt32 texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexArrayOES", ExactSpelling = true)]
            internal extern static void BindVertexArrayOES(UInt32 array);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendBarrierNV", ExactSpelling = true)]
            internal extern static void BlendBarrierNV();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal extern static void BlendColor(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal extern static void BlendEquation(OpenTK.Graphics.ES20.BlendEquationMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationEXT", ExactSpelling = true)]
            internal extern static void BlendEquationEXT(OpenTK.Graphics.ES20.All mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal extern static void BlendEquationSeparate(OpenTK.Graphics.ES20.BlendEquationMode modeRGB, OpenTK.Graphics.ES20.BlendEquationMode modeAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc(OpenTK.Graphics.ES20.BlendingFactorSrc sfactor, OpenTK.Graphics.ES20.BlendingFactorDest dfactor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal extern static void BlendFuncSeparate(OpenTK.Graphics.ES20.All sfactorRGB, OpenTK.Graphics.ES20.All dfactorRGB, OpenTK.Graphics.ES20.All sfactorAlpha, OpenTK.Graphics.ES20.All dfactorAlpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendParameteriNV", ExactSpelling = true)]
            internal extern static void BlendParameteriNV(OpenTK.Graphics.ES20.All pname, Int32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlitFramebufferANGLE", ExactSpelling = true)]
            internal extern static void BlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, OpenTK.Graphics.ES20.All filter);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlitFramebufferNV", ExactSpelling = true)]
            internal extern static void BlitFramebufferNV(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, OpenTK.Graphics.ES20.All filter);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal extern static void BufferData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.ES20.BufferUsage usage);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal extern static void BufferSubData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES20.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.ES20.FramebufferTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear(OpenTK.Graphics.ES20.ClearBufferMask mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor(Single red, Single green, Single blue, Single alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal extern static void ClearDepthf(Single d);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil(Int32 s);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientWaitSyncAPPLE", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES20.All ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask(bool red, bool green, bool blue, bool alpha);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal extern static void CompileShader(UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, OpenTK.Graphics.ES20.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage3DOES", ExactSpelling = true)]
            internal extern static void CompressedTexImage3DOES(OpenTK.Graphics.ES20.All target, Int32 level, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage3DOES", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage3DOES(OpenTK.Graphics.ES20.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, Int32 imageSize, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyBufferSubDataNV", ExactSpelling = true)]
            internal extern static void CopyBufferSubDataNV(OpenTK.Graphics.ES20.All readTarget, OpenTK.Graphics.ES20.All writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, OpenTK.Graphics.ES20.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage3DOES", ExactSpelling = true)]
            internal extern static void CopyTexSubImage3DOES(OpenTK.Graphics.ES20.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTextureLevelsAPPLE", ExactSpelling = true)]
            internal extern static void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCoverageMaskNV", ExactSpelling = true)]
            internal extern static void CoverageMaskNV(bool mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCoverageOperationNV", ExactSpelling = true)]
            internal extern static void CoverageOperationNV(OpenTK.Graphics.ES20.All operation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal extern static Int32 CreateProgram();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal extern static Int32 CreateShader(OpenTK.Graphics.ES20.ShaderType type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShaderProgramEXT", ExactSpelling = true)]
            internal extern static Int32 CreateShaderProgramEXT(OpenTK.Graphics.ES20.All type, String @string);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShaderProgramvEXT", ExactSpelling = true)]
            internal extern static Int32 CreateShaderProgramvEXT(OpenTK.Graphics.ES20.All type, Int32 count, String[] strings);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace(OpenTK.Graphics.ES20.CullFaceMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageCallback", ExactSpelling = true)]
            internal extern static void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageCallbackKHR", ExactSpelling = true)]
            internal extern static void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageControl", ExactSpelling = true)]
            internal extern static unsafe void DebugMessageControl(OpenTK.Graphics.ES20.All source, OpenTK.Graphics.ES20.All type, OpenTK.Graphics.ES20.All severity, Int32 count, UInt32* ids, bool enabled);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageControlKHR", ExactSpelling = true)]
            internal extern static unsafe void DebugMessageControlKHR(OpenTK.Graphics.ES20.All source, OpenTK.Graphics.ES20.All type, OpenTK.Graphics.ES20.All severity, Int32 count, UInt32* ids, bool enabled);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageInsert", ExactSpelling = true)]
            internal extern static void DebugMessageInsert(OpenTK.Graphics.ES20.All source, OpenTK.Graphics.ES20.All type, UInt32 id, OpenTK.Graphics.ES20.All severity, Int32 length, String buf);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageInsertKHR", ExactSpelling = true)]
            internal extern static void DebugMessageInsertKHR(OpenTK.Graphics.ES20.All source, OpenTK.Graphics.ES20.All type, UInt32 id, OpenTK.Graphics.ES20.All severity, Int32 length, String buf);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteBuffers(Int32 n, UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFencesNV", ExactSpelling = true)]
            internal extern static unsafe void DeleteFencesNV(Int32 n, UInt32* fences);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeletePerfMonitorsAMD", ExactSpelling = true)]
            internal extern static unsafe void DeletePerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal extern static void DeleteProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgramPipelinesEXT", ExactSpelling = true)]
            internal extern static unsafe void DeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteQueriesEXT", ExactSpelling = true)]
            internal extern static unsafe void DeleteQueriesEXT(Int32 n, UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal extern static void DeleteShader(UInt32 shader);
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
            internal extern static void DepthFunc(OpenTK.Graphics.ES20.DepthFunction func);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask(bool flag);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal extern static void DepthRangef(Single n, Single f);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal extern static void DetachShader(UInt32 program, UInt32 shader);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable(OpenTK.Graphics.ES20.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableDriverControlQCOM", ExactSpelling = true)]
            internal extern static void DisableDriverControlQCOM(UInt32 driverControl);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal extern static void DisableVertexAttribArray(UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDiscardFramebufferEXT", ExactSpelling = true)]
            internal extern static unsafe void DiscardFramebufferEXT(OpenTK.Graphics.ES20.All target, Int32 numAttachments, OpenTK.Graphics.ES20.All* attachments);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays1(OpenTK.Graphics.ES20.BeginMode mode, Int32 first, Int32 count);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstancedANGLE", ExactSpelling = true)]
            internal extern static void DrawArraysInstancedANGLE(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstancedEXT", ExactSpelling = true)]
            internal extern static void DrawArraysInstancedEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 start, Int32 count, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstancedNV", ExactSpelling = true)]
            internal extern static void DrawArraysInstancedNV(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 first, Int32 count, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffersEXT", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffersEXT(Int32 n, OpenTK.Graphics.ES20.All* bufs);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffersIndexedEXT", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffersIndexedEXT(Int32 n, OpenTK.Graphics.ES20.All* location, Int32* indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffersNV", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffersNV(Int32 n, OpenTK.Graphics.ES20.All* bufs);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements1(OpenTK.Graphics.ES20.BeginMode mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedANGLE", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedANGLE(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.All type, IntPtr indices, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedEXT", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedNV", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedNV(OpenTK.Graphics.ES20.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES20.All type, IntPtr indices, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEGLImageTargetRenderbufferStorageOES", ExactSpelling = true)]
            internal extern static void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES20.All target, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEGLImageTargetTexture2DOES", ExactSpelling = true)]
            internal extern static void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES20.All target, IntPtr image);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable(OpenTK.Graphics.ES20.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableDriverControlQCOM", ExactSpelling = true)]
            internal extern static void EnableDriverControlQCOM(UInt32 driverControl);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal extern static void EnableVertexAttribArray(UInt32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndPerfMonitorAMD", ExactSpelling = true)]
            internal extern static void EndPerfMonitorAMD(UInt32 monitor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndQueryEXT", ExactSpelling = true)]
            internal extern static void EndQueryEXT(OpenTK.Graphics.ES20.All target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndTilingQCOM", ExactSpelling = true)]
            internal extern static void EndTilingQCOM(UInt32 preserveMask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetBufferPointervQCOM", ExactSpelling = true)]
            internal extern static void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES20.All target, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetBuffersQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetFramebuffersQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetProgramBinarySourceQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES20.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
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
            internal extern static unsafe void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES20.All face, Int32 level, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetTexSubImageQCOM", ExactSpelling = true)]
            internal extern static void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES20.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, [OutAttribute] IntPtr texels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtGetTexturesQCOM", ExactSpelling = true)]
            internal extern static unsafe void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtIsProgramBinaryQCOM", ExactSpelling = true)]
            internal extern static bool ExtIsProgramBinaryQCOM(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtTexObjectStateOverrideiQCOM", ExactSpelling = true)]
            internal extern static void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFenceSyncAPPLE", ExactSpelling = true)]
            internal extern static IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES20.All condition, UInt32 flags);
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
            internal extern static void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES20.All target, IntPtr offset, IntPtr length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
            internal extern static void FramebufferRenderbuffer(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferSlot attachment, OpenTK.Graphics.ES20.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
            internal extern static void FramebufferTexture2D(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferSlot attachment, OpenTK.Graphics.ES20.TextureTarget textarget, UInt32 texture, Int32 level);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2DMultisampleEXT", ExactSpelling = true)]
            internal extern static void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 samples);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2DMultisampleIMG", ExactSpelling = true)]
            internal extern static void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 samples);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture3DOES", ExactSpelling = true)]
            internal extern static void FramebufferTexture3DOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All attachment, OpenTK.Graphics.ES20.All textarget, UInt32 texture, Int32 level, Int32 zoffset);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace(OpenTK.Graphics.ES20.FrontFaceDirection mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal extern static unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
            internal extern static void GenerateMipmap(OpenTK.Graphics.ES20.TextureTarget target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFencesNV", ExactSpelling = true)]
            internal extern static unsafe void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenPerfMonitorsAMD", ExactSpelling = true)]
            internal extern static unsafe void GenPerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenProgramPipelinesEXT", ExactSpelling = true)]
            internal extern static unsafe void GenProgramPipelinesEXT(Int32 n, [OutAttribute] UInt32* pipelines);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenQueriesEXT", ExactSpelling = true)]
            internal extern static unsafe void GenQueriesEXT(Int32 n, [OutAttribute] UInt32* ids);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenVertexArraysOES", ExactSpelling = true)]
            internal extern static unsafe void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal extern static unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal extern static unsafe void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal extern static Int32 GetAttribLocation(UInt32 program, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal extern static unsafe void GetBooleanv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] bool* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteriv(OpenTK.Graphics.ES20.BufferTarget target, OpenTK.Graphics.ES20.BufferParameterName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferPointervOES", ExactSpelling = true)]
            internal extern static void GetBufferPointervOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDebugMessageLog", ExactSpelling = true)]
            internal extern static unsafe Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES20.All* sources, [OutAttribute] OpenTK.Graphics.ES20.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES20.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDebugMessageLogKHR", ExactSpelling = true)]
            internal extern static unsafe Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.ES20.All* sources, [OutAttribute] OpenTK.Graphics.ES20.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.ES20.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDriverControlsQCOM", ExactSpelling = true)]
            internal extern static unsafe void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDriverControlStringQCOM", ExactSpelling = true)]
            internal extern static unsafe void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES20.ErrorCode GetError();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFenceivNV", ExactSpelling = true)]
            internal extern static unsafe void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal extern static unsafe void GetFloatv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Single* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferSlot attachment, OpenTK.Graphics.ES20.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetGraphicsResetStatusEXT", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES20.All GetGraphicsResetStatusEXT();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInteger64vAPPLE", ExactSpelling = true)]
            internal extern static unsafe void GetInteger64vAPPLE(OpenTK.Graphics.ES20.All pname, [OutAttribute] Int64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegeri_vEXT", ExactSpelling = true)]
            internal extern static unsafe void GetIntegeri_vEXT(OpenTK.Graphics.ES20.All target, UInt32 index, [OutAttribute] Int32* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Int32* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectLabel", ExactSpelling = true)]
            internal extern static unsafe void GetObjectLabel(OpenTK.Graphics.ES20.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectLabelEXT", ExactSpelling = true)]
            internal extern static unsafe void GetObjectLabelEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectLabelKHR", ExactSpelling = true)]
            internal extern static unsafe void GetObjectLabelKHR(OpenTK.Graphics.ES20.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectPtrLabel", ExactSpelling = true)]
            internal extern static unsafe void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectPtrLabelKHR", ExactSpelling = true)]
            internal extern static unsafe void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCounterDataAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorCounterDataAMD(UInt32 monitor, OpenTK.Graphics.ES20.All pname, Int32 dataSize, [OutAttribute] UInt32* data, [OutAttribute] Int32* bytesWritten);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCounterInfoAMD", ExactSpelling = true)]
            internal extern static void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCountersAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorCountersAMD(UInt32 group, [OutAttribute] Int32* numCounters, [OutAttribute] Int32* maxActiveCounters, Int32 counterSize, [OutAttribute] UInt32* counters);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCounterStringAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder counterString);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorGroupsAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups, Int32 groupsSize, [OutAttribute] UInt32* groups);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorGroupStringAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder groupString);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal extern static void GetPointerv(OpenTK.Graphics.ES20.GetPointervPName pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointervKHR", ExactSpelling = true)]
            internal extern static void GetPointervKHR(OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramBinaryOES", ExactSpelling = true)]
            internal extern static unsafe void GetProgramBinaryOES(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.ES20.All* binaryFormat, [OutAttribute] IntPtr binary);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramiv(UInt32 program, OpenTK.Graphics.ES20.ProgramParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramPipelineInfoLogEXT", ExactSpelling = true)]
            internal extern static unsafe void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramPipelineivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetProgramPipelineivEXT(UInt32 pipeline, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetQueryivEXT(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjecti64vEXT", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjecti64vEXT(UInt32 id, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectivEXT(UInt32 id, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectui64vEXT", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectui64vEXT(UInt32 id, OpenTK.Graphics.ES20.All pname, [OutAttribute] UInt64* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectuivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectuivEXT(UInt32 id, OpenTK.Graphics.ES20.All pname, [OutAttribute] UInt32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetRenderbufferParameteriv(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal extern static unsafe void GetShaderiv(UInt32 shader, OpenTK.Graphics.ES20.ShaderParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
            internal extern static unsafe void GetShaderPrecisionFormat(OpenTK.Graphics.ES20.ShaderType shadertype, OpenTK.Graphics.ES20.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal extern static unsafe void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(OpenTK.Graphics.ES20.StringName name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSyncivAPPLE", ExactSpelling = true)]
            internal extern static unsafe void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES20.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTranslatedShaderSourceANGLE", ExactSpelling = true)]
            internal extern static unsafe void GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetUniformLocation(UInt32 program, String name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint(OpenTK.Graphics.ES20.HintTarget target, OpenTK.Graphics.ES20.HintMode mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInsertEventMarkerEXT", ExactSpelling = true)]
            internal extern static void InsertEventMarkerEXT(Int32 length, String marker);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal extern static bool IsBuffer(UInt32 buffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal extern static bool IsEnabled(OpenTK.Graphics.ES20.EnableCap cap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFenceNV", ExactSpelling = true)]
            internal extern static bool IsFenceNV(UInt32 fence);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
            internal extern static bool IsFramebuffer(UInt32 framebuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal extern static bool IsProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgramPipelineEXT", ExactSpelling = true)]
            internal extern static bool IsProgramPipelineEXT(UInt32 pipeline);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsQueryEXT", ExactSpelling = true)]
            internal extern static bool IsQueryEXT(UInt32 id);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
            internal extern static bool IsRenderbuffer(UInt32 renderbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal extern static bool IsShader(UInt32 shader);
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
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLabelObjectEXT", ExactSpelling = true)]
            internal extern static void LabelObjectEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth(Single width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal extern static void LinkProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBufferOES", ExactSpelling = true)]
            internal extern static IntPtr MapBufferOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBufferRangeEXT", ExactSpelling = true)]
            internal extern static IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES20.All target, IntPtr offset, IntPtr length, UInt32 access);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArraysEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawArraysEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElementsEXT(OpenTK.Graphics.ES20.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices, Int32 primcount);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectLabel", ExactSpelling = true)]
            internal extern static void ObjectLabel(OpenTK.Graphics.ES20.All identifier, UInt32 name, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectLabelKHR", ExactSpelling = true)]
            internal extern static void ObjectLabelKHR(OpenTK.Graphics.ES20.All identifier, UInt32 name, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectPtrLabel", ExactSpelling = true)]
            internal extern static void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectPtrLabelKHR", ExactSpelling = true)]
            internal extern static void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei(OpenTK.Graphics.ES20.PixelStoreParameter pname, Int32 param);
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
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopGroupMarkerEXT", ExactSpelling = true)]
            internal extern static void PopGroupMarkerEXT();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramBinaryOES", ExactSpelling = true)]
            internal extern static void ProgramBinaryOES(UInt32 program, OpenTK.Graphics.ES20.All binaryFormat, IntPtr binary, Int32 length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameteriEXT", ExactSpelling = true)]
            internal extern static void ProgramParameteriEXT(UInt32 program, OpenTK.Graphics.ES20.All pname, Int32 value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform1fEXT(UInt32 program, Int32 location, Single v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform2fEXT(UInt32 program, Int32 location, Single v0, Single v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform3fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform4fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushDebugGroup", ExactSpelling = true)]
            internal extern static void PushDebugGroup(OpenTK.Graphics.ES20.All source, UInt32 id, Int32 length, String message);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushDebugGroupKHR", ExactSpelling = true)]
            internal extern static void PushDebugGroupKHR(OpenTK.Graphics.ES20.All source, UInt32 id, Int32 length, String message);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushGroupMarkerEXT", ExactSpelling = true)]
            internal extern static void PushGroupMarkerEXT(Int32 length, String marker);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glQueryCounterEXT", ExactSpelling = true)]
            internal extern static void QueryCounterEXT(UInt32 id, OpenTK.Graphics.ES20.All target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadBufferIndexedEXT", ExactSpelling = true)]
            internal extern static void ReadBufferIndexedEXT(OpenTK.Graphics.ES20.All src, Int32 index);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadBufferNV", ExactSpelling = true)]
            internal extern static void ReadBufferNV(OpenTK.Graphics.ES20.All mode);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadnPixelsEXT", ExactSpelling = true)]
            internal extern static void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, [OutAttribute] IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReleaseShaderCompiler", ExactSpelling = true)]
            internal extern static void ReleaseShaderCompiler();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
            internal extern static void RenderbufferStorage(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleANGLE", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleANGLE(OpenTK.Graphics.ES20.All target, Int32 samples, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleAPPLE", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES20.All target, Int32 samples, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES20.All target, Int32 samples, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleIMG", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES20.All target, Int32 samples, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleNV", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleNV(OpenTK.Graphics.ES20.All target, Int32 samples, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResolveMultisampleFramebufferAPPLE", ExactSpelling = true)]
            internal extern static void ResolveMultisampleFramebufferAPPLE();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage(Single value, bool invert);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSelectPerfMonitorCountersAMD", ExactSpelling = true)]
            internal extern static unsafe void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, [OutAttribute] UInt32* counterList);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetFenceNV", ExactSpelling = true)]
            internal extern static void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES20.All condition);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
            internal extern static unsafe void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.ES20.ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal extern static unsafe void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStartTilingQCOM", ExactSpelling = true)]
            internal extern static void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc(OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal extern static void StencilFuncSeparate(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal extern static void StencilFuncSeparate1(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask(UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal extern static void StencilMaskSeparate(OpenTK.Graphics.ES20.StencilFace face, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp(OpenTK.Graphics.ES20.StencilOp fail, OpenTK.Graphics.ES20.StencilOp zfail, OpenTK.Graphics.ES20.StencilOp zpass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal extern static void StencilOpSeparate(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilOp sfail, OpenTK.Graphics.ES20.StencilOp dpfail, OpenTK.Graphics.ES20.StencilOp dppass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal extern static void StencilOpSeparate1(OpenTK.Graphics.ES20.StencilFace face, OpenTK.Graphics.ES20.StencilOp sfail, OpenTK.Graphics.ES20.StencilOp dpfail, OpenTK.Graphics.ES20.StencilOp dppass);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTestFenceNV", ExactSpelling = true)]
            internal extern static bool TestFenceNV(UInt32 fence);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, OpenTK.Graphics.ES20.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage3DOES", ExactSpelling = true)]
            internal extern static void TexImage3DOES(OpenTK.Graphics.ES20.All target, Int32 level, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal extern static void TexParameteri(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32 param);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void TexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32* @params);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage1DEXT", ExactSpelling = true)]
            internal extern static void TexStorage1DEXT(OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage2DEXT", ExactSpelling = true)]
            internal extern static void TexStorage2DEXT(OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexStorage3DEXT", ExactSpelling = true)]
            internal extern static void TexStorage3DEXT(OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height, Int32 depth);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage3DOES", ExactSpelling = true)]
            internal extern static void TexSubImage3DOES(OpenTK.Graphics.ES20.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES20.All format, OpenTK.Graphics.ES20.All type, IntPtr pixels);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureStorage1DEXT", ExactSpelling = true)]
            internal extern static void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureStorage2DEXT", ExactSpelling = true)]
            internal extern static void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureStorage3DEXT", ExactSpelling = true)]
            internal extern static void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height, Int32 depth);
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
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x3fvNV", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x4fvNV", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x2fvNV", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x4fvNV", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x4fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x2fvNV", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x2fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x3fvNV", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x3fvNV(Int32 location, Int32 count, bool transpose, Single* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnmapBufferOES", ExactSpelling = true)]
            internal extern static bool UnmapBufferOES(OpenTK.Graphics.ES20.All target);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal extern static void UseProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseProgramStagesEXT", ExactSpelling = true)]
            internal extern static void UseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseShaderProgramEXT", ExactSpelling = true)]
            internal extern static void UseShaderProgramEXT(OpenTK.Graphics.ES20.All type, UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal extern static void ValidateProgram(UInt32 program);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glValidateProgramPipelineEXT", ExactSpelling = true)]
            internal extern static void ValidateProgramPipelineEXT(UInt32 pipeline);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal extern static void VertexAttrib1f(UInt32 index, Single x);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal extern static void VertexAttrib2f(UInt32 index, Single x, Single y);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal extern static void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal extern static void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4fv(UInt32 index, Single* v);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribDivisorANGLE", ExactSpelling = true)]
            internal extern static void VertexAttribDivisorANGLE(UInt32 index, UInt32 divisor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribDivisorEXT", ExactSpelling = true)]
            internal extern static void VertexAttribDivisorEXT(UInt32 index, UInt32 divisor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribDivisorNV", ExactSpelling = true)]
            internal extern static void VertexAttribDivisorNV(UInt32 index, UInt32 divisor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal extern static void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.ES20.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWaitSyncAPPLE", ExactSpelling = true)]
            internal extern static void WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
        }
    }
}
