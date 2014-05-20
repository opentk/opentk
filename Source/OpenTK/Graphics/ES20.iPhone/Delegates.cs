//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
// Copyright 2013 Xamarin Inc
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
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgramEXT glActiveShaderProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(OpenTK.Graphics.ES20.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryEXT(OpenTK.Graphics.ES20.All target, UInt32 id);
            internal static BeginQueryEXT glBeginQueryEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(OpenTK.Graphics.ES20.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebuffer(OpenTK.Graphics.ES20.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramPipelineEXT(UInt32 pipeline);
            internal static BindProgramPipelineEXT glBindProgramPipelineEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.ES20.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(OpenTK.Graphics.ES20.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArrayOES(UInt32 array);
            internal static BindVertexArrayOES glBindVertexArrayOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation(OpenTK.Graphics.ES20.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.ES20.BlendEquationMode modeRGB, OpenTK.Graphics.ES20.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(OpenTK.Graphics.ES20.BlendingFactorSrc sfactor, OpenTK.Graphics.ES20.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.ES20.BlendingFactorSrc srcRGB, OpenTK.Graphics.ES20.BlendingFactorDest dstRGB, OpenTK.Graphics.ES20.BlendingFactorSrc srcAlpha, OpenTK.Graphics.ES20.BlendingFactorDest dstAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.ES20.BufferUsage usage);
            internal static BufferData glBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData(OpenTK.Graphics.ES20.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES20.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.ES20.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(OpenTK.Graphics.ES20.ClearBufferMask mask);
            internal static Clear glClear;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf(Single depth);
            internal static ClearDepthf glClearDepthf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES20.All ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static ClientWaitSyncAPPLE glClientWaitSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, OpenTK.Graphics.ES20.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, OpenTK.Graphics.ES20.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            internal static CopyTextureLevelsAPPLE glCopyTextureLevelsAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader(OpenTK.Graphics.ES20.ShaderType type);
            internal static CreateShader glCreateShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramvEXT(OpenTK.Graphics.ES20.All type, Int32 count, String strings);
            internal static CreateShaderProgramvEXT glCreateShaderProgramvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(OpenTK.Graphics.ES20.CullFaceMode mode);
            internal static CullFace glCullFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelinesEXT glDeleteProgramPipelinesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueriesEXT(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueriesEXT glDeleteQueriesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteSyncAPPLE(IntPtr sync);
            internal static DeleteSyncAPPLE glDeleteSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArraysOES(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysOES glDeleteVertexArraysOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc(OpenTK.Graphics.ES20.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef(Single zNear, Single zFar);
            internal static DepthRangef glDepthRangef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(OpenTK.Graphics.ES20.EnableCap cap);
            internal static Disable glDisable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DiscardFramebufferEXT(OpenTK.Graphics.ES20.All target, Int32 numAttachments, OpenTK.Graphics.ES20.All* attachments);
            internal unsafe static DiscardFramebufferEXT glDiscardFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(OpenTK.Graphics.ES20.BeginMode mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedEXT(OpenTK.Graphics.ES20.All mode, Int32 first, Int32 count, Int32 instanceCount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements(OpenTK.Graphics.ES20.BeginMode mode, Int32 count, OpenTK.Graphics.ES20.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedEXT(OpenTK.Graphics.ES20.All mode, Int32 count, OpenTK.Graphics.ES20.All type, IntPtr indices, Int32 instanceCount);
            internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(OpenTK.Graphics.ES20.EnableCap cap);
            internal static Enable glEnable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryEXT(OpenTK.Graphics.ES20.All target);
            internal static EndQueryEXT glEndQueryEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES20.All condition, UInt32 flags);
            internal static FenceSyncAPPLE glFenceSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES20.All target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRangeEXT glFlushMappedBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferSlot attachment, OpenTK.Graphics.ES20.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferSlot attachment, OpenTK.Graphics.ES20.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(OpenTK.Graphics.ES20.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmap(OpenTK.Graphics.ES20.TextureTarget target);
            internal static GenerateMipmap glGenerateMipmap;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramPipelinesEXT(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelinesEXT glGenProgramPipelinesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueriesEXT(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueriesEXT glGenQueriesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysOES glGenVertexArraysOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.ES20.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxcount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] bool* @params);
            internal unsafe static GetBooleanv glGetBooleanv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.ES20.BufferTarget target, OpenTK.Graphics.ES20.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointervOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervOES glGetBufferPointervOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES20.ErrorCode GetError();
            internal static GetError glGetError;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetFloatv glGetFloatv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferSlot attachment, OpenTK.Graphics.ES20.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64vAPPLE(OpenTK.Graphics.ES20.All pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64vAPPLE glGetInteger64vAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.ES20.GetPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetIntegerv glGetIntegerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectLabelEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelEXT glGetObjectLabelEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infolog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.ES20.ProgramParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLogEXT glGetProgramPipelineInfoLogEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineivEXT(UInt32 pipeline, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineivEXT glGetProgramPipelineivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryivEXT(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryivEXT glGetQueryivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuivEXT(UInt32 id, OpenTK.Graphics.ES20.All pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuivEXT glGetQueryObjectuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infolog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.ES20.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.ES20.ShaderType shadertype, OpenTK.Graphics.ES20.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr GetString(OpenTK.Graphics.ES20.StringName name);
            internal unsafe static GetString glGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES20.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSyncivAPPLE glGetSyncivAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetUniformLocation(UInt32 program, String name);
            internal static GetUniformLocation glGetUniformLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.ES20.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(OpenTK.Graphics.ES20.HintTarget target, OpenTK.Graphics.ES20.HintMode mode);
            internal static Hint glHint;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InsertEventMarkerEXT(Int32 length, String marker);
            internal static InsertEventMarkerEXT glInsertEventMarkerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled(OpenTK.Graphics.ES20.EnableCap cap);
            internal static IsEnabled glIsEnabled;
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
            internal delegate bool IsQueryEXT(UInt32 id);
            internal static IsQueryEXT glIsQueryEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsSyncAPPLE(IntPtr sync);
            internal static IsSyncAPPLE glIsSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArrayOES(UInt32 array);
            internal static IsVertexArrayOES glIsVertexArrayOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LabelObjectEXT(OpenTK.Graphics.ES20.All type, UInt32 @object, Int32 length, String label);
            internal static LabelObjectEXT glLabelObjectEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBufferOES(OpenTK.Graphics.ES20.All target, OpenTK.Graphics.ES20.All access);
            internal unsafe static MapBufferOES glMapBufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES20.All target, IntPtr offset, IntPtr length, UInt32 access);
            internal unsafe static MapBufferRangeEXT glMapBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(OpenTK.Graphics.ES20.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopGroupMarkerEXT();
            internal static PopGroupMarkerEXT glPopGroupMarkerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriEXT(UInt32 program, OpenTK.Graphics.ES20.All pname, Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1fEXT(UInt32 program, Int32 location, Single x);
            internal static ProgramUniform1fEXT glProgramUniform1fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fvEXT glProgramUniform1fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 x);
            internal static ProgramUniform1iEXT glProgramUniform1iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1ivEXT glProgramUniform1ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2fEXT(UInt32 program, Int32 location, Single x, Single y);
            internal static ProgramUniform2fEXT glProgramUniform2fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fvEXT glProgramUniform2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 x, Int32 y);
            internal static ProgramUniform2iEXT glProgramUniform2iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2ivEXT glProgramUniform2ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3fEXT(UInt32 program, Int32 location, Single x, Single y, Single z);
            internal static ProgramUniform3fEXT glProgramUniform3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fvEXT glProgramUniform3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 x, Int32 y, Int32 z);
            internal static ProgramUniform3iEXT glProgramUniform3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3ivEXT glProgramUniform3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4fEXT(UInt32 program, Int32 location, Single x, Single y, Single z, Single w);
            internal static ProgramUniform4fEXT glProgramUniform4fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fvEXT glProgramUniform4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static ProgramUniform4iEXT glProgramUniform4iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4ivEXT glProgramUniform4ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushGroupMarkerEXT(Int32 length, String marker);
            internal static PushGroupMarkerEXT glPushGroupMarkerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.ES20.RenderbufferTarget target, OpenTK.Graphics.ES20.RenderbufferInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES20.All target, Int32 samples, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleAPPLE glRenderbufferStorageMultisampleAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResolveMultisampleFramebufferAPPLE();
            internal static ResolveMultisampleFramebufferAPPLE glResolveMultisampleFramebufferAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderBinary(Int32 n, UInt32* shaders, OpenTK.Graphics.ES20.ShaderBinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.ES20.CullFaceMode face, OpenTK.Graphics.ES20.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.ES20.CullFaceMode face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(OpenTK.Graphics.ES20.StencilOp fail, OpenTK.Graphics.ES20.StencilOp zfail, OpenTK.Graphics.ES20.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.ES20.CullFaceMode face, OpenTK.Graphics.ES20.StencilOp fail, OpenTK.Graphics.ES20.StencilOp zfail, OpenTK.Graphics.ES20.StencilOp zpass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, OpenTK.Graphics.ES20.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.ES20.TextureTarget target, OpenTK.Graphics.ES20.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage2DEXT(OpenTK.Graphics.ES20.All target, Int32 levels, OpenTK.Graphics.ES20.All internalformat, Int32 width, Int32 height);
            internal static TexStorage2DEXT glTexStorage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D(OpenTK.Graphics.ES20.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES20.PixelFormat format, OpenTK.Graphics.ES20.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1f(Int32 location, Single x);
            internal static Uniform1f glUniform1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* v);
            internal unsafe static Uniform1fv glUniform1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i(Int32 location, Int32 x);
            internal static Uniform1i glUniform1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* v);
            internal unsafe static Uniform1iv glUniform1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2f(Int32 location, Single x, Single y);
            internal static Uniform2f glUniform2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* v);
            internal unsafe static Uniform2fv glUniform2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i(Int32 location, Int32 x, Int32 y);
            internal static Uniform2i glUniform2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* v);
            internal unsafe static Uniform2iv glUniform2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3f(Int32 location, Single x, Single y, Single z);
            internal static Uniform3f glUniform3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* v);
            internal unsafe static Uniform3fv glUniform3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i(Int32 location, Int32 x, Int32 y, Int32 z);
            internal static Uniform3i glUniform3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* v);
            internal unsafe static Uniform3iv glUniform3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4f(Int32 location, Single x, Single y, Single z, Single w);
            internal static Uniform4f glUniform4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* v);
            internal unsafe static Uniform4fv glUniform4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i(Int32 location, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static Uniform4i glUniform4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* v);
            internal unsafe static Uniform4iv glUniform4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBufferOES(OpenTK.Graphics.ES20.All target);
            internal static UnmapBufferOES glUnmapBufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);
            internal static UseProgramStagesEXT glUseProgramStagesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramPipelineEXT(UInt32 pipeline);
            internal static ValidateProgramPipelineEXT glValidateProgramPipelineEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1f(UInt32 indx, Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fv(UInt32 indx, Single* values);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2f(UInt32 indx, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fv(UInt32 indx, Single* values);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3f(UInt32 indx, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fv(UInt32 indx, Single* values);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4f(UInt32 indx, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fv(UInt32 indx, Single* values);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisorEXT(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorEXT glVertexAttribDivisorEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointer(UInt32 indx, Int32 size, OpenTK.Graphics.ES20.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr ptr);
            internal static VertexAttribPointer glVertexAttribPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static WaitSyncAPPLE glWaitSyncAPPLE;
        }
    }
}
