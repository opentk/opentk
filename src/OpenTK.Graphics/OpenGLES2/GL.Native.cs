// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES2
{
    public static unsafe partial class GL
    {
        public static void ActiveShaderProgram(int pipeline, int program) => GLPointers._glActiveShaderProgram_fnptr(pipeline, program);
        
        public static void ActiveTexture(TextureUnit texture) => GLPointers._glActiveTexture_fnptr((uint)texture);
        
        public static void AttachShader(int program, int shader) => GLPointers._glAttachShader_fnptr(program, shader);
        
        public static void BeginQuery(QueryTarget target, int id) => GLPointers._glBeginQuery_fnptr((uint)target, id);
        
        public static void BeginTransformFeedback(PrimitiveType primitiveMode) => GLPointers._glBeginTransformFeedback_fnptr((uint)primitiveMode);
        
        public static void BindAttribLocation(int program, uint index, byte* name) => GLPointers._glBindAttribLocation_fnptr(program, index, name);
        
        public static void BindBuffer(BufferTargetARB target, int buffer) => GLPointers._glBindBuffer_fnptr((uint)target, buffer);
        
        public static void BindBufferBase(BufferTargetARB target, uint index, int buffer) => GLPointers._glBindBufferBase_fnptr((uint)target, index, buffer);
        
        public static void BindBufferRange(BufferTargetARB target, uint index, int buffer, IntPtr offset, nint size) => GLPointers._glBindBufferRange_fnptr((uint)target, index, buffer, offset, size);
        
        public static void BindFramebuffer(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebuffer_fnptr((uint)target, framebuffer);
        
        public static void BindImageTexture(uint unit, int texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format) => GLPointers._glBindImageTexture_fnptr(unit, texture, level, (byte)(layered ? 1 : 0), layer, (uint)access, (uint)format);
        
        public static void BindProgramPipeline(int pipeline) => GLPointers._glBindProgramPipeline_fnptr(pipeline);
        
        public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbuffer_fnptr((uint)target, renderbuffer);
        
        public static void BindSampler(uint unit, int sampler) => GLPointers._glBindSampler_fnptr(unit, sampler);
        
        public static void BindTexture(TextureTarget target, int texture) => GLPointers._glBindTexture_fnptr((uint)target, texture);
        
        public static void BindTransformFeedback(BindTransformFeedbackTarget target, int id) => GLPointers._glBindTransformFeedback_fnptr((uint)target, id);
        
        public static void BindVertexArray(int array) => GLPointers._glBindVertexArray_fnptr(array);
        
        public static void BindVertexBuffer(uint bindingindex, int buffer, IntPtr offset, int stride) => GLPointers._glBindVertexBuffer_fnptr(bindingindex, buffer, offset, stride);
        
        public static void BlendBarrier() => GLPointers._glBlendBarrier_fnptr();
        
        public static void BlendColor(float red, float green, float blue, float alpha) => GLPointers._glBlendColor_fnptr(red, green, blue, alpha);
        
        public static void BlendEquation(BlendEquationModeEXT mode) => GLPointers._glBlendEquation_fnptr((uint)mode);
        
        public static void BlendEquationi(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationi_fnptr(buf, (uint)mode);
        
        public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparate_fnptr((uint)modeRGB, (uint)modeAlpha);
        
        public static void BlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparatei_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
        
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._glBlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        public static void BlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunci_fnptr(buf, (uint)src, (uint)dst);
        
        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => GLPointers._glBlendFuncSeparate_fnptr((uint)sfactorRGB, (uint)dfactorRGB, (uint)sfactorAlpha, (uint)dfactorAlpha);
        
        public static void BlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparatei_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
        
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebuffer_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
        
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._glBufferData_fnptr((uint)target, size, data, (uint)usage);
        
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glBufferSubData_fnptr((uint)target, offset, size, data);
        
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatus_fnptr((uint)target);
        
        public static void Clear(ClearBufferMask mask) => GLPointers._glClear_fnptr((uint)mask);
        
        public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => GLPointers._glClearBufferfi_fnptr((uint)buffer, drawbuffer, depth, stencil);
        
        public static void ClearBufferfv(Buffer buffer, int drawbuffer, float* value) => GLPointers._glClearBufferfv_fnptr((uint)buffer, drawbuffer, value);
        
        public static void ClearBufferiv(Buffer buffer, int drawbuffer, int* value) => GLPointers._glClearBufferiv_fnptr((uint)buffer, drawbuffer, value);
        
        public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint* value) => GLPointers._glClearBufferuiv_fnptr((uint)buffer, drawbuffer, value);
        
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._glClearColor_fnptr(red, green, blue, alpha);
        
        public static void ClearDepthf(float d) => GLPointers._glClearDepthf_fnptr(d);
        
        public static void ClearStencil(int s) => GLPointers._glClearStencil_fnptr(s);
        
        public static SyncStatus ClientWaitSync(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => GLPointers._glColorMask_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
        
        public static void ColorMaski(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaski_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
        
        public static void CompileShader(int shader) => GLPointers._glCompileShader_fnptr(shader);
        
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage2D_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
        
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage3D_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
        
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
        
        public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubData_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
        
        public static void CopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubData_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyTexImage2D_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
        
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
        
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        public static int CreateProgram() => GLPointers._glCreateProgram_fnptr();
        
        public static int CreateShader(ShaderType type) => GLPointers._glCreateShader_fnptr((uint)type);
        
        public static int CreateShaderProgramv(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramv_fnptr((uint)type, count, strings);
        
        public static void CullFace(TriangleFace mode) => GLPointers._glCullFace_fnptr((uint)mode);
        
        public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
        
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
        
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
        
        public static void DeleteBuffers(int n, int* buffers) => GLPointers._glDeleteBuffers_fnptr(n, buffers);
        
        public static void DeleteFramebuffers(int n, int* framebuffers) => GLPointers._glDeleteFramebuffers_fnptr(n, framebuffers);
        
        public static void DeleteProgram(int program) => GLPointers._glDeleteProgram_fnptr(program);
        
        public static void DeleteProgramPipelines(int n, int* pipelines) => GLPointers._glDeleteProgramPipelines_fnptr(n, pipelines);
        
        public static void DeleteQueries(int n, int* ids) => GLPointers._glDeleteQueries_fnptr(n, ids);
        
        public static void DeleteRenderbuffers(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffers_fnptr(n, renderbuffers);
        
        public static void DeleteSamplers(int count, int* samplers) => GLPointers._glDeleteSamplers_fnptr(count, samplers);
        
        public static void DeleteShader(int shader) => GLPointers._glDeleteShader_fnptr(shader);
        
        public static void DeleteSync(GLSync sync) => GLPointers._glDeleteSync_fnptr((IntPtr)sync);
        
        public static void DeleteTextures(int n, int* textures) => GLPointers._glDeleteTextures_fnptr(n, textures);
        
        public static void DeleteTransformFeedbacks(int n, int* ids) => GLPointers._glDeleteTransformFeedbacks_fnptr(n, ids);
        
        public static void DeleteVertexArrays(int n, int* arrays) => GLPointers._glDeleteVertexArrays_fnptr(n, arrays);
        
        public static void DepthFunc(DepthFunction func) => GLPointers._glDepthFunc_fnptr((uint)func);
        
        public static void DepthMask(bool flag) => GLPointers._glDepthMask_fnptr((byte)(flag ? 1 : 0));
        
        public static void DepthRangef(float n, float f) => GLPointers._glDepthRangef_fnptr(n, f);
        
        public static void DetachShader(int program, int shader) => GLPointers._glDetachShader_fnptr(program, shader);
        
        public static void Disable(EnableCap cap) => GLPointers._glDisable_fnptr((uint)cap);
        
        public static void Disablei(EnableCap target, uint index) => GLPointers._glDisablei_fnptr((uint)target, index);
        
        public static void DisableVertexAttribArray(uint index) => GLPointers._glDisableVertexAttribArray_fnptr(index);
        
        public static void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => GLPointers._glDispatchCompute_fnptr(num_groups_x, num_groups_y, num_groups_z);
        
        public static void DispatchComputeIndirect(IntPtr indirect) => GLPointers._glDispatchComputeIndirect_fnptr(indirect);
        
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._glDrawArrays_fnptr((uint)mode, first, count);
        
        public static void DrawArraysIndirect(PrimitiveType mode, void* indirect) => GLPointers._glDrawArraysIndirect_fnptr((uint)mode, indirect);
        
        public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount) => GLPointers._glDrawArraysInstanced_fnptr((uint)mode, first, count, instancecount);
        
        public static void DrawBuffers(int n, DrawBufferMode* bufs) => GLPointers._glDrawBuffers_fnptr(n, (uint*)bufs);
        
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._glDrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertex_fnptr((uint)mode, count, (uint)type, indices, basevertex);
        
        public static void DrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void* indirect) => GLPointers._glDrawElementsIndirect_fnptr((uint)mode, (uint)type, indirect);
        
        public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount) => GLPointers._glDrawElementsInstanced_fnptr((uint)mode, count, (uint)type, indices, instancecount);
        
        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertex_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
        
        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices) => GLPointers._glDrawRangeElements_fnptr((uint)mode, start, end, count, (uint)type, indices);
        
        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertex_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
        
        public static void Enable(EnableCap cap) => GLPointers._glEnable_fnptr((uint)cap);
        
        public static void Enablei(EnableCap target, uint index) => GLPointers._glEnablei_fnptr((uint)target, index);
        
        public static void EnableVertexAttribArray(uint index) => GLPointers._glEnableVertexAttribArray_fnptr(index);
        
        public static void EndQuery(QueryTarget target) => GLPointers._glEndQuery_fnptr((uint)target);
        
        public static void EndTransformFeedback() => GLPointers._glEndTransformFeedback_fnptr();
        
        public static GLSync FenceSync(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSync_fnptr((uint)condition, (uint)flags);
        
        public static void Finish() => GLPointers._glFinish_fnptr();
        
        public static void Flush() => GLPointers._glFlush_fnptr();
        
        public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRange_fnptr((uint)target, offset, length);
        
        public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteri_fnptr((uint)target, (uint)pname, param);
        
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbuffer_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
        
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTexture_fnptr((uint)target, (uint)attachment, texture, level);
        
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2D_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
        
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => GLPointers._glFramebufferTextureLayer_fnptr((uint)target, (uint)attachment, texture, level, layer);
        
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._glFrontFace_fnptr((uint)mode);
        
        public static void GenBuffers(int n, int* buffers) => GLPointers._glGenBuffers_fnptr(n, buffers);
        
        public static void GenerateMipmap(TextureTarget target) => GLPointers._glGenerateMipmap_fnptr((uint)target);
        
        public static void GenFramebuffers(int n, int* framebuffers) => GLPointers._glGenFramebuffers_fnptr(n, framebuffers);
        
        public static void GenProgramPipelines(int n, int* pipelines) => GLPointers._glGenProgramPipelines_fnptr(n, pipelines);
        
        public static void GenQueries(int n, int* ids) => GLPointers._glGenQueries_fnptr(n, ids);
        
        public static void GenRenderbuffers(int n, int* renderbuffers) => GLPointers._glGenRenderbuffers_fnptr(n, renderbuffers);
        
        public static void GenSamplers(int count, int* samplers) => GLPointers._glGenSamplers_fnptr(count, samplers);
        
        public static void GenTextures(int n, int* textures) => GLPointers._glGenTextures_fnptr(n, textures);
        
        public static void GenTransformFeedbacks(int n, int* ids) => GLPointers._glGenTransformFeedbacks_fnptr(n, ids);
        
        public static void GenVertexArrays(int n, int* arrays) => GLPointers._glGenVertexArrays_fnptr(n, arrays);
        
        public static void GetActiveAttrib(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetActiveAttrib_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        public static void GetActiveUniform(int program, uint index, int bufSize, int* length, int* size, UniformType* type, byte* name) => GLPointers._glGetActiveUniform_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        public static void GetActiveUniformBlockiv(int program, uint uniformBlockIndex, UniformBlockPName pname, int* parameters) => GLPointers._glGetActiveUniformBlockiv_fnptr(program, uniformBlockIndex, (uint)pname, parameters);
        
        public static void GetActiveUniformBlockName(int program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => GLPointers._glGetActiveUniformBlockName_fnptr(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        
        public static void GetActiveUniformsiv(int program, int uniformCount, uint* uniformIndices, UniformPName pname, int* parameters) => GLPointers._glGetActiveUniformsiv_fnptr(program, uniformCount, uniformIndices, (uint)pname, parameters);
        
        public static void GetAttachedShaders(int program, int maxCount, int* count, int* shaders) => GLPointers._glGetAttachedShaders_fnptr(program, maxCount, count, shaders);
        
        public static int GetAttribLocation(int program, byte* name) => GLPointers._glGetAttribLocation_fnptr(program, name);
        
        public static void GetBooleani_v(BufferTargetARB target, uint index, bool* data) => GLPointers._glGetBooleani_v_fnptr((uint)target, index, (byte*)data);
        
        public static void GetBooleanv(GetPName pname, bool* data) => GLPointers._glGetBooleanv_fnptr((uint)pname, (byte*)data);
        
        public static void GetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long* parameters) => GLPointers._glGetBufferParameteri64v_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._glGetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointerv_fnptr((uint)target, (uint)pname, parameters);
        
        public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
        
        public static ErrorCode GetError() => (ErrorCode) GLPointers._glGetError_fnptr();
        
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._glGetFloatv_fnptr((uint)pname, data);
        
        public static int GetFragDataLocation(int program, byte* name) => GLPointers._glGetFragDataLocation_fnptr(program, name);
        
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameteriv_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
        
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
        
        public static void GetInteger64i_v(GetPName target, uint index, long* data) => GLPointers._glGetInteger64i_v_fnptr((uint)target, index, data);
        
        public static void GetInteger64v(GetPName pname, long* data) => GLPointers._glGetInteger64v_fnptr((uint)pname, data);
        
        public static void GetIntegeri_v(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_v_fnptr((uint)target, index, data);
        
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._glGetIntegerv_fnptr((uint)pname, data);
        
        public static void GetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformativ_fnptr((uint)target, (uint)internalformat, (uint)pname, count, parameters);
        
        public static void GetMultisamplefv(GetMultisamplePNameNV pname, uint index, float* val) => GLPointers._glGetMultisamplefv_fnptr((uint)pname, index, val);
        
        public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
        
        public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
        
        public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
        
        public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
        
        public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
        
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
        
        public static void GetProgramBinary(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinary_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
        
        public static void GetProgramInfoLog(int program, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramInfoLog_fnptr(program, bufSize, length, infoLog);
        
        public static void GetProgramInterfaceiv(int program, ProgramInterface programInterface, ProgramInterfacePName pname, int* parameters) => GLPointers._glGetProgramInterfaceiv_fnptr(program, (uint)programInterface, (uint)pname, parameters);
        
        public static void GetProgramiv(int program, ProgramPropertyARB pname, int* parameters) => GLPointers._glGetProgramiv_fnptr(program, (uint)pname, parameters);
        
        public static void GetProgramPipelineInfoLog(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLog_fnptr(pipeline, bufSize, length, infoLog);
        
        public static void GetProgramPipelineiv(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineiv_fnptr(pipeline, (uint)pname, parameters);
        
        public static uint GetProgramResourceIndex(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceIndex_fnptr(program, (uint)programInterface, name);
        
        public static void GetProgramResourceiv(int program, ProgramInterface programInterface, uint index, int propCount, ProgramResourceProperty* props, int count, int* length, int* parameters) => GLPointers._glGetProgramResourceiv_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
        
        public static int GetProgramResourceLocation(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocation_fnptr(program, (uint)programInterface, name);
        
        public static void GetProgramResourceName(int program, ProgramInterface programInterface, uint index, int bufSize, int* length, byte* name) => GLPointers._glGetProgramResourceName_fnptr(program, (uint)programInterface, index, bufSize, length, name);
        
        public static void GetQueryiv(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetQueryObjectuiv(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuiv_fnptr(id, (uint)pname, parameters);
        
        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetSamplerParameterfv(int sampler, SamplerParameterF pname, float* parameters) => GLPointers._glGetSamplerParameterfv_fnptr(sampler, (uint)pname, parameters);
        
        public static void GetSamplerParameterIiv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIiv_fnptr(sampler, (uint)pname, parameters);
        
        public static void GetSamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuiv_fnptr(sampler, (uint)pname, parameters);
        
        public static void GetSamplerParameteriv(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameteriv_fnptr(sampler, (uint)pname, parameters);
        
        public static void GetShaderInfoLog(int shader, int bufSize, int* length, byte* infoLog) => GLPointers._glGetShaderInfoLog_fnptr(shader, bufSize, length, infoLog);
        
        public static void GetShaderiv(int shader, ShaderParameterName pname, int* parameters) => GLPointers._glGetShaderiv_fnptr(shader, (uint)pname, parameters);
        
        public static void GetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int* range, int* precision) => GLPointers._glGetShaderPrecisionFormat_fnptr((uint)shadertype, (uint)precisiontype, range, precision);
        
        public static void GetShaderSource(int shader, int bufSize, int* length, byte* source) => GLPointers._glGetShaderSource_fnptr(shader, bufSize, length, source);
        
        public static byte* GetString_(StringName name) => GLPointers._glGetString_fnptr((uint)name);
        
        public static byte* GetStringi_(StringName name, uint index) => GLPointers._glGetStringi_fnptr((uint)name, index);
        
        public static void GetSynciv(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSynciv_fnptr((IntPtr)sync, (uint)pname, count, length, values);
        
        public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexLevelParameterfv_fnptr((uint)target, level, (uint)pname, parameters);
        
        public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexLevelParameteriv_fnptr((uint)target, level, (uint)pname, parameters);
        
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTransformFeedbackVarying(int program, uint index, int bufSize, int* length, int* size, AttributeType* type, byte* name) => GLPointers._glGetTransformFeedbackVarying_fnptr(program, index, bufSize, length, size, (uint*)type, name);
        
        public static uint GetUniformBlockIndex(int program, byte* uniformBlockName) => GLPointers._glGetUniformBlockIndex_fnptr(program, uniformBlockName);
        
        public static void GetUniformfv(int program, int location, float* parameters) => GLPointers._glGetUniformfv_fnptr(program, location, parameters);
        
        public static void GetUniformIndices(int program, int uniformCount, byte** uniformNames, uint* uniformIndices) => GLPointers._glGetUniformIndices_fnptr(program, uniformCount, uniformNames, uniformIndices);
        
        public static void GetUniformiv(int program, int location, int* parameters) => GLPointers._glGetUniformiv_fnptr(program, location, parameters);
        
        public static int GetUniformLocation(int program, byte* name) => GLPointers._glGetUniformLocation_fnptr(program, name);
        
        public static void GetUniformuiv(int program, int location, uint* parameters) => GLPointers._glGetUniformuiv_fnptr(program, location, parameters);
        
        public static void GetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float* parameters) => GLPointers._glGetVertexAttribfv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, int* parameters) => GLPointers._glGetVertexAttribIiv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint* parameters) => GLPointers._glGetVertexAttribIuiv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int* parameters) => GLPointers._glGetVertexAttribiv_fnptr(index, (uint)pname, parameters);
        
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void** pointer) => GLPointers._glGetVertexAttribPointerv_fnptr(index, (uint)pname, pointer);
        
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._glHint_fnptr((uint)target, (uint)mode);
        
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glInvalidateFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments);
        
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments, int x, int y, int width, int height) => GLPointers._glInvalidateSubFramebuffer_fnptr((uint)target, numAttachments, (uint*)attachments, x, y, width, height);
        
        public static bool IsBuffer(int buffer) => GLPointers._glIsBuffer_fnptr(buffer) != 0;
        
        public static bool IsEnabled(EnableCap cap) => GLPointers._glIsEnabled_fnptr((uint)cap) != 0;
        
        public static bool IsEnabledi(EnableCap target, uint index) => GLPointers._glIsEnabledi_fnptr((uint)target, index) != 0;
        
        public static bool IsFramebuffer(int framebuffer) => GLPointers._glIsFramebuffer_fnptr(framebuffer) != 0;
        
        public static bool IsProgram(int program) => GLPointers._glIsProgram_fnptr(program) != 0;
        
        public static bool IsProgramPipeline(int pipeline) => GLPointers._glIsProgramPipeline_fnptr(pipeline) != 0;
        
        public static bool IsQuery(int id) => GLPointers._glIsQuery_fnptr(id) != 0;
        
        public static bool IsRenderbuffer(int renderbuffer) => GLPointers._glIsRenderbuffer_fnptr(renderbuffer) != 0;
        
        public static bool IsSampler(int sampler) => GLPointers._glIsSampler_fnptr(sampler) != 0;
        
        public static bool IsShader(int shader) => GLPointers._glIsShader_fnptr(shader) != 0;
        
        public static bool IsSync(GLSync sync) => GLPointers._glIsSync_fnptr((IntPtr)sync) != 0;
        
        public static bool IsTexture(int texture) => GLPointers._glIsTexture_fnptr(texture) != 0;
        
        public static bool IsTransformFeedback(int id) => GLPointers._glIsTransformFeedback_fnptr(id) != 0;
        
        public static bool IsVertexArray(int array) => GLPointers._glIsVertexArray_fnptr(array) != 0;
        
        public static void LineWidth(float width) => GLPointers._glLineWidth_fnptr(width);
        
        public static void LinkProgram(int program) => GLPointers._glLinkProgram_fnptr(program);
        
        public static void* MapBufferRange(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRange_fnptr((uint)target, offset, length, (uint)access);
        
        public static void MemoryBarrier(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrier_fnptr((uint)barriers);
        
        public static void MemoryBarrierByRegion(MemoryBarrierMask barriers) => GLPointers._glMemoryBarrierByRegion_fnptr((uint)barriers);
        
        public static void MinSampleShading(float value) => GLPointers._glMinSampleShading_fnptr(value);
        
        public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
        
        public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
        
        public static void PatchParameteri(PatchParameterName pname, int value) => GLPointers._glPatchParameteri_fnptr((uint)pname, value);
        
        public static void PauseTransformFeedback() => GLPointers._glPauseTransformFeedback_fnptr();
        
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._glPixelStorei_fnptr((uint)pname, param);
        
        public static void PolygonOffset(float factor, float units) => GLPointers._glPolygonOffset_fnptr(factor, units);
        
        public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
        
        public static void PrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBox_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        
        public static void ProgramBinary(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinary_fnptr(program, (uint)binaryFormat, binary, length);
        
        public static void ProgramParameteri(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteri_fnptr(program, (uint)pname, value);
        
        public static void ProgramUniform1f(int program, int location, float v0) => GLPointers._glProgramUniform1f_fnptr(program, location, v0);
        
        public static void ProgramUniform1fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform1i(int program, int location, int v0) => GLPointers._glProgramUniform1i_fnptr(program, location, v0);
        
        public static void ProgramUniform1iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform1iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform1ui(int program, int location, uint v0) => GLPointers._glProgramUniform1ui_fnptr(program, location, v0);
        
        public static void ProgramUniform1uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniform2f(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2f_fnptr(program, location, v0, v1);
        
        public static void ProgramUniform2fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform2i(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2i_fnptr(program, location, v0, v1);
        
        public static void ProgramUniform2iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform2iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform2ui(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2ui_fnptr(program, location, v0, v1);
        
        public static void ProgramUniform2uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniform3f(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3f_fnptr(program, location, v0, v1, v2);
        
        public static void ProgramUniform3fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform3i(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3i_fnptr(program, location, v0, v1, v2);
        
        public static void ProgramUniform3iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform3iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform3ui(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3ui_fnptr(program, location, v0, v1, v2);
        
        public static void ProgramUniform3uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniform4f(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4f_fnptr(program, location, v0, v1, v2, v3);
        
        public static void ProgramUniform4fv(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fv_fnptr(program, location, count, value);
        
        public static void ProgramUniform4i(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4i_fnptr(program, location, v0, v1, v2, v3);
        
        public static void ProgramUniform4iv(int program, int location, int count, int* value) => GLPointers._glProgramUniform4iv_fnptr(program, location, count, value);
        
        public static void ProgramUniform4ui(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4ui_fnptr(program, location, v0, v1, v2, v3);
        
        public static void ProgramUniform4uiv(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uiv_fnptr(program, location, count, value);
        
        public static void ProgramUniformMatrix2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix2x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix2x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix3x4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4x2fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void ProgramUniformMatrix4x3fv(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fv_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
        
        public static void ReadBuffer(ReadBufferMode src) => GLPointers._glReadBuffer_fnptr((uint)src);
        
        public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
        
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        public static void ReleaseShaderCompiler() => GLPointers._glReleaseShaderCompiler_fnptr();
        
        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorage_fnptr((uint)target, (uint)internalformat, width, height);
        
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height);
        
        public static void ResumeTransformFeedback() => GLPointers._glResumeTransformFeedback_fnptr();
        
        public static void SampleCoverage(float value, bool invert) => GLPointers._glSampleCoverage_fnptr(value, (byte)(invert ? 1 : 0));
        
        public static void SampleMaski(uint maskNumber, uint mask) => GLPointers._glSampleMaski_fnptr(maskNumber, mask);
        
        public static void SamplerParameterf(int sampler, SamplerParameterF pname, float param) => GLPointers._glSamplerParameterf_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameterfv(int sampler, SamplerParameterF pname, float* param) => GLPointers._glSamplerParameterfv_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameteri(int sampler, SamplerParameterI pname, int param) => GLPointers._glSamplerParameteri_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameterIiv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIiv_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameterIuiv(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuiv_fnptr(sampler, (uint)pname, param);
        
        public static void SamplerParameteriv(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameteriv_fnptr(sampler, (uint)pname, param);
        
        public static void Scissor(int x, int y, int width, int height) => GLPointers._glScissor_fnptr(x, y, width, height);
        
        public static void ShaderBinary(int count, int* shaders, ShaderBinaryFormat binaryFormat, void* binary, int length) => GLPointers._glShaderBinary_fnptr(count, shaders, (uint)binaryFormat, binary, length);
        
        public static void ShaderSource(int shader, int count, byte** str, int* length) => GLPointers._glShaderSource_fnptr(shader, count, str, length);
        
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._glStencilFunc_fnptr((uint)func, reference, mask);
        
        public static void StencilFuncSeparate(TriangleFace face, StencilFunction func, int reference, uint mask) => GLPointers._glStencilFuncSeparate_fnptr((uint)face, (uint)func, reference, mask);
        
        public static void StencilMask(uint mask) => GLPointers._glStencilMask_fnptr(mask);
        
        public static void StencilMaskSeparate(TriangleFace face, uint mask) => GLPointers._glStencilMaskSeparate_fnptr((uint)face, mask);
        
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._glStencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        public static void StencilOpSeparate(TriangleFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => GLPointers._glStencilOpSeparate_fnptr((uint)face, (uint)sfail, (uint)dpfail, (uint)dppass);
        
        public static void TexBuffer(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBuffer_fnptr((uint)target, (uint)internalformat, buffer);
        
        public static void TexBufferRange(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRange_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
        
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage2D_fnptr((uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
        
        public static void TexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage3D_fnptr((uint)target, level, (int)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
        
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._glTexParameterf_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._glTexParameteri_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuiv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexStorage2D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2D_fnptr((uint)target, levels, (uint)internalformat, width, height);
        
        public static void TexStorage2DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, bool fixedsamplelocations) => GLPointers._glTexStorage2DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void TexStorage3D(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3D_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
        
        public static void TexStorage3DMultisample(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisample_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
        
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage3D_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
        
        public static void TransformFeedbackVaryings(int program, int count, byte** varyings, TransformFeedbackBufferMode bufferMode) => GLPointers._glTransformFeedbackVaryings_fnptr(program, count, varyings, (uint)bufferMode);
        
        public static void Uniform1f(int location, float v0) => GLPointers._glUniform1f_fnptr(location, v0);
        
        public static void Uniform1fv(int location, int count, float* value) => GLPointers._glUniform1fv_fnptr(location, count, value);
        
        public static void Uniform1i(int location, int v0) => GLPointers._glUniform1i_fnptr(location, v0);
        
        public static void Uniform1iv(int location, int count, int* value) => GLPointers._glUniform1iv_fnptr(location, count, value);
        
        public static void Uniform1ui(int location, uint v0) => GLPointers._glUniform1ui_fnptr(location, v0);
        
        public static void Uniform1uiv(int location, int count, uint* value) => GLPointers._glUniform1uiv_fnptr(location, count, value);
        
        public static void Uniform2f(int location, float v0, float v1) => GLPointers._glUniform2f_fnptr(location, v0, v1);
        
        public static void Uniform2fv(int location, int count, float* value) => GLPointers._glUniform2fv_fnptr(location, count, value);
        
        public static void Uniform2i(int location, int v0, int v1) => GLPointers._glUniform2i_fnptr(location, v0, v1);
        
        public static void Uniform2iv(int location, int count, int* value) => GLPointers._glUniform2iv_fnptr(location, count, value);
        
        public static void Uniform2ui(int location, uint v0, uint v1) => GLPointers._glUniform2ui_fnptr(location, v0, v1);
        
        public static void Uniform2uiv(int location, int count, uint* value) => GLPointers._glUniform2uiv_fnptr(location, count, value);
        
        public static void Uniform3f(int location, float v0, float v1, float v2) => GLPointers._glUniform3f_fnptr(location, v0, v1, v2);
        
        public static void Uniform3fv(int location, int count, float* value) => GLPointers._glUniform3fv_fnptr(location, count, value);
        
        public static void Uniform3i(int location, int v0, int v1, int v2) => GLPointers._glUniform3i_fnptr(location, v0, v1, v2);
        
        public static void Uniform3iv(int location, int count, int* value) => GLPointers._glUniform3iv_fnptr(location, count, value);
        
        public static void Uniform3ui(int location, uint v0, uint v1, uint v2) => GLPointers._glUniform3ui_fnptr(location, v0, v1, v2);
        
        public static void Uniform3uiv(int location, int count, uint* value) => GLPointers._glUniform3uiv_fnptr(location, count, value);
        
        public static void Uniform4f(int location, float v0, float v1, float v2, float v3) => GLPointers._glUniform4f_fnptr(location, v0, v1, v2, v3);
        
        public static void Uniform4fv(int location, int count, float* value) => GLPointers._glUniform4fv_fnptr(location, count, value);
        
        public static void Uniform4i(int location, int v0, int v1, int v2, int v3) => GLPointers._glUniform4i_fnptr(location, v0, v1, v2, v3);
        
        public static void Uniform4iv(int location, int count, int* value) => GLPointers._glUniform4iv_fnptr(location, count, value);
        
        public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glUniform4ui_fnptr(location, v0, v1, v2, v3);
        
        public static void Uniform4uiv(int location, int count, uint* value) => GLPointers._glUniform4uiv_fnptr(location, count, value);
        
        public static void UniformBlockBinding(int program, uint uniformBlockIndex, uint uniformBlockBinding) => GLPointers._glUniformBlockBinding_fnptr(program, uniformBlockIndex, uniformBlockBinding);
        
        public static void UniformMatrix2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix2x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix2x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix3x4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4x2fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x2fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static void UniformMatrix4x3fv(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x3fv_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
        
        public static bool UnmapBuffer(BufferTargetARB target) => GLPointers._glUnmapBuffer_fnptr((uint)target) != 0;
        
        public static void UseProgram(int program) => GLPointers._glUseProgram_fnptr(program);
        
        public static void UseProgramStages(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStages_fnptr(pipeline, (uint)stages, program);
        
        public static void ValidateProgram(int program) => GLPointers._glValidateProgram_fnptr(program);
        
        public static void ValidateProgramPipeline(int pipeline) => GLPointers._glValidateProgramPipeline_fnptr(pipeline);
        
        public static void VertexAttrib1f(uint index, float x) => GLPointers._glVertexAttrib1f_fnptr(index, x);
        
        public static void VertexAttrib1fv(uint index, float* v) => GLPointers._glVertexAttrib1fv_fnptr(index, v);
        
        public static void VertexAttrib2f(uint index, float x, float y) => GLPointers._glVertexAttrib2f_fnptr(index, x, y);
        
        public static void VertexAttrib2fv(uint index, float* v) => GLPointers._glVertexAttrib2fv_fnptr(index, v);
        
        public static void VertexAttrib3f(uint index, float x, float y, float z) => GLPointers._glVertexAttrib3f_fnptr(index, x, y, z);
        
        public static void VertexAttrib3fv(uint index, float* v) => GLPointers._glVertexAttrib3fv_fnptr(index, v);
        
        public static void VertexAttrib4f(uint index, float x, float y, float z, float w) => GLPointers._glVertexAttrib4f_fnptr(index, x, y, z, w);
        
        public static void VertexAttrib4fv(uint index, float* v) => GLPointers._glVertexAttrib4fv_fnptr(index, v);
        
        public static void VertexAttribBinding(uint attribindex, uint bindingindex) => GLPointers._glVertexAttribBinding_fnptr(attribindex, bindingindex);
        
        public static void VertexAttribDivisor(uint index, uint divisor) => GLPointers._glVertexAttribDivisor_fnptr(index, divisor);
        
        public static void VertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => GLPointers._glVertexAttribFormat_fnptr(attribindex, size, (uint)type, (byte)(normalized ? 1 : 0), relativeoffset);
        
        public static void VertexAttribI4i(uint index, int x, int y, int z, int w) => GLPointers._glVertexAttribI4i_fnptr(index, x, y, z, w);
        
        public static void VertexAttribI4iv(uint index, int* v) => GLPointers._glVertexAttribI4iv_fnptr(index, v);
        
        public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => GLPointers._glVertexAttribI4ui_fnptr(index, x, y, z, w);
        
        public static void VertexAttribI4uiv(uint index, uint* v) => GLPointers._glVertexAttribI4uiv_fnptr(index, v);
        
        public static void VertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => GLPointers._glVertexAttribIFormat_fnptr(attribindex, size, (uint)type, relativeoffset);
        
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIType type, int stride, void* pointer) => GLPointers._glVertexAttribIPointer_fnptr(index, size, (uint)type, stride, pointer);
        
        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, void* pointer) => GLPointers._glVertexAttribPointer_fnptr(index, size, (uint)type, (byte)(normalized ? 1 : 0), stride, pointer);
        
        public static void VertexBindingDivisor(uint bindingindex, uint divisor) => GLPointers._glVertexBindingDivisor_fnptr(bindingindex, divisor);
        
        public static void Viewport(int x, int y, int width, int height) => GLPointers._glViewport_fnptr(x, y, width, height);
        
        public static void WaitSync(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSync_fnptr((IntPtr)sync, (uint)flags, timeout);
        
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            public static void BeginPerfMonitorAMD(uint monitor) => GLPointers._glBeginPerfMonitorAMD_fnptr(monitor);
            
            public static void DeletePerfMonitorsAMD(int n, uint* monitors) => GLPointers._glDeletePerfMonitorsAMD_fnptr(n, monitors);
            
            public static void EndPerfMonitorAMD(uint monitor) => GLPointers._glEndPerfMonitorAMD_fnptr(monitor);
            
            public static void GenPerfMonitorsAMD(int n, uint* monitors) => GLPointers._glGenPerfMonitorsAMD_fnptr(n, monitors);
            
            public static void GetPerfMonitorCounterDataAMD(uint monitor, All pname, int dataSize, uint* data, int* bytesWritten) => GLPointers._glGetPerfMonitorCounterDataAMD_fnptr(monitor, (uint)pname, dataSize, data, bytesWritten);
            
            public static void GetPerfMonitorCounterInfoAMD(uint group, uint counter, All pname, void* data) => GLPointers._glGetPerfMonitorCounterInfoAMD_fnptr(group, counter, (uint)pname, data);
            
            public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters) => GLPointers._glGetPerfMonitorCountersAMD_fnptr(group, numCounters, maxActiveCounters, counterSize, counters);
            
            public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString) => GLPointers._glGetPerfMonitorCounterStringAMD_fnptr(group, counter, bufSize, length, counterString);
            
            public static void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups) => GLPointers._glGetPerfMonitorGroupsAMD_fnptr(numGroups, groupsSize, groups);
            
            public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString) => GLPointers._glGetPerfMonitorGroupStringAMD_fnptr(group, bufSize, length, groupString);
            
            public static void NamedRenderbufferStorageMultisampleAdvancedAMD(int renderbuffer, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glNamedRenderbufferStorageMultisampleAdvancedAMD_fnptr(renderbuffer, samples, storageSamples, (uint)internalformat, width, height);
            
            public static void RenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, int samples, int storageSamples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleAdvancedAMD_fnptr((uint)target, samples, storageSamples, (uint)internalformat, width, height);
            
            public static void SelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, uint* counterList) => GLPointers._glSelectPerfMonitorCountersAMD_fnptr(monitor, (byte)(enable ? 1 : 0), group, numCounters, counterList);
            
        }
        /// <summary>ANGLE extensions.</summary>
        public static unsafe partial class ANGLE
        {
            public static void BlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferANGLE_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static void DrawArraysInstancedANGLE(PrimitiveType mode, int first, int count, int primcount) => GLPointers._glDrawArraysInstancedANGLE_fnptr((uint)mode, first, count, primcount);
            
            public static void DrawElementsInstancedANGLE(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedANGLE_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void GetTranslatedShaderSourceANGLE(int shader, int bufSize, int* length, byte* source) => GLPointers._glGetTranslatedShaderSourceANGLE_fnptr(shader, bufSize, length, source);
            
            public static void RenderbufferStorageMultisampleANGLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleANGLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static void VertexAttribDivisorANGLE(uint index, uint divisor) => GLPointers._glVertexAttribDivisorANGLE_fnptr(index, divisor);
            
        }
        /// <summary>APPLE extensions.</summary>
        public static unsafe partial class APPLE
        {
            public static SyncStatus ClientWaitSyncAPPLE(GLSync sync, SyncObjectMask flags, ulong timeout) => (SyncStatus) GLPointers._glClientWaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
            public static void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => GLPointers._glCopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            
            public static void DeleteSyncAPPLE(GLSync sync) => GLPointers._glDeleteSyncAPPLE_fnptr((IntPtr)sync);
            
            public static GLSync FenceSyncAPPLE(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) GLPointers._glFenceSyncAPPLE_fnptr((uint)condition, (uint)flags);
            
            public static void GetInteger64vAPPLE(GetPName pname, long* parameters) => GLPointers._glGetInteger64vAPPLE_fnptr((uint)pname, parameters);
            
            public static void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => GLPointers._glGetSyncivAPPLE_fnptr((IntPtr)sync, (uint)pname, count, length, values);
            
            public static bool IsSyncAPPLE(GLSync sync) => GLPointers._glIsSyncAPPLE_fnptr((IntPtr)sync) != 0;
            
            public static void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleAPPLE_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static void ResolveMultisampleFramebufferAPPLE() => GLPointers._glResolveMultisampleFramebufferAPPLE_fnptr();
            
            public static void WaitSyncAPPLE(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => GLPointers._glWaitSyncAPPLE_fnptr((IntPtr)sync, (uint)flags, timeout);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            public static bool AcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout) => GLPointers._glAcquireKeyedMutexWin32EXT_fnptr(memory, key, timeout) != 0;
            
            public static void ActiveProgramEXT(int program) => GLPointers._glActiveProgramEXT_fnptr(program);
            
            public static void ActiveShaderProgramEXT(int pipeline, int program) => GLPointers._glActiveShaderProgramEXT_fnptr(pipeline, program);
            
            public static void BeginQueryEXT(QueryTarget target, int id) => GLPointers._glBeginQueryEXT_fnptr((uint)target, id);
            
            public static void BindFragDataLocationEXT(int program, uint color, byte* name) => GLPointers._glBindFragDataLocationEXT_fnptr(program, color, name);
            
            public static void BindFragDataLocationIndexedEXT(int program, uint colorNumber, uint index, byte* name) => GLPointers._glBindFragDataLocationIndexedEXT_fnptr(program, colorNumber, index, name);
            
            public static void BindProgramPipelineEXT(int pipeline) => GLPointers._glBindProgramPipelineEXT_fnptr(pipeline);
            
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => GLPointers._glBlendEquationEXT_fnptr((uint)mode);
            
            public static void BlendEquationiEXT(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationiEXT_fnptr(buf, (uint)mode);
            
            public static void BlendEquationSeparateiEXT(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateiEXT_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            public static void BlendFunciEXT(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunciEXT_fnptr(buf, (uint)src, (uint)dst);
            
            public static void BlendFuncSeparateiEXT(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateiEXT_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            public static void BlitFramebufferLayerEXT(int srcX0, int srcY0, int srcX1, int srcY1, int srcLayer, int dstX0, int dstY0, int dstX1, int dstY1, int dstLayer, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayerEXT_fnptr(srcX0, srcY0, srcX1, srcY1, srcLayer, dstX0, dstY0, dstX1, dstY1, dstLayer, (uint)mask, (uint)filter);
            
            public static void BlitFramebufferLayersEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferLayersEXT_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static void BufferStorageEXT(BufferStorageTarget target, nint size, void* data, BufferStorageMask flags) => GLPointers._glBufferStorageEXT_fnptr((uint)target, size, data, (uint)flags);
            
            public static void BufferStorageExternalEXT(All target, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glBufferStorageExternalEXT_fnptr((uint)target, offset, size, clientBuffer, (uint)flags);
            
            public static void BufferStorageMemEXT(BufferTargetARB target, nint size, uint memory, ulong offset) => GLPointers._glBufferStorageMemEXT_fnptr((uint)target, size, memory, offset);
            
            public static void ClearPixelLocalStorageuiEXT(int offset, int n, uint* values) => GLPointers._glClearPixelLocalStorageuiEXT_fnptr(offset, n, values);
            
            public static void ClearTexImageEXT(int texture, int level, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexImageEXT_fnptr(texture, level, (uint)format, (uint)type, data);
            
            public static void ClearTexSubImageEXT(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* data) => GLPointers._glClearTexSubImageEXT_fnptr(texture, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, data);
            
            public static void ClipControlEXT(All origin, All depth) => GLPointers._glClipControlEXT_fnptr((uint)origin, (uint)depth);
            
            public static void ColorMaskiEXT(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaskiEXT_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
            
            public static void CopyImageSubDataEXT(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubDataEXT_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            public static void CreateMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._glCreateMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            public static int CreateShaderProgramEXT(ShaderType type, byte* str) => GLPointers._glCreateShaderProgramEXT_fnptr((uint)type, str);
            
            public static int CreateShaderProgramvEXT(ShaderType type, int count, byte** strings) => GLPointers._glCreateShaderProgramvEXT_fnptr((uint)type, count, strings);
            
            public static void DeleteMemoryObjectsEXT(int n, uint* memoryObjects) => GLPointers._glDeleteMemoryObjectsEXT_fnptr(n, memoryObjects);
            
            public static void DeleteProgramPipelinesEXT(int n, int* pipelines) => GLPointers._glDeleteProgramPipelinesEXT_fnptr(n, pipelines);
            
            public static void DeleteQueriesEXT(int n, int* ids) => GLPointers._glDeleteQueriesEXT_fnptr(n, ids);
            
            public static void DeleteSemaphoresEXT(int n, uint* semaphores) => GLPointers._glDeleteSemaphoresEXT_fnptr(n, semaphores);
            
            public static void DisableiEXT(EnableCap target, uint index) => GLPointers._glDisableiEXT_fnptr((uint)target, index);
            
            public static void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glDiscardFramebufferEXT_fnptr((uint)target, numAttachments, (uint*)attachments);
            
            public static void DrawArraysInstancedBaseInstanceEXT(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance) => GLPointers._glDrawArraysInstancedBaseInstanceEXT_fnptr((uint)mode, first, count, instancecount, baseinstance);
            
            public static void DrawArraysInstancedEXT(PrimitiveType mode, int start, int count, int primcount) => GLPointers._glDrawArraysInstancedEXT_fnptr((uint)mode, start, count, primcount);
            
            public static void DrawBuffersEXT(int n, All* bufs) => GLPointers._glDrawBuffersEXT_fnptr(n, (uint*)bufs);
            
            public static void DrawBuffersIndexedEXT(int n, All* location, int* indices) => GLPointers._glDrawBuffersIndexedEXT_fnptr(n, (uint*)location, indices);
            
            public static void DrawElementsBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            public static void DrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, baseinstance);
            
            public static void DrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex, uint baseinstance) => GLPointers._glDrawElementsInstancedBaseVertexBaseInstanceEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex, baseinstance);
            
            public static void DrawElementsInstancedBaseVertexEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            public static void DrawElementsInstancedEXT(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void DrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertexEXT_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            public static void DrawTransformFeedbackEXT(PrimitiveType mode, int id) => GLPointers._glDrawTransformFeedbackEXT_fnptr((uint)mode, id);
            
            public static void DrawTransformFeedbackInstancedEXT(PrimitiveType mode, int id, int instancecount) => GLPointers._glDrawTransformFeedbackInstancedEXT_fnptr((uint)mode, id, instancecount);
            
            public static void EGLImageTargetTexStorageEXT(All target, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTexStorageEXT_fnptr((uint)target, image, attrib_list);
            
            public static void EGLImageTargetTextureStorageEXT(int texture, void* image, int* attrib_list) => GLPointers._glEGLImageTargetTextureStorageEXT_fnptr(texture, image, attrib_list);
            
            public static void EnableiEXT(EnableCap target, uint index) => GLPointers._glEnableiEXT_fnptr((uint)target, index);
            
            public static void EndQueryEXT(QueryTarget target) => GLPointers._glEndQueryEXT_fnptr((uint)target);
            
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRangeEXT_fnptr((uint)target, offset, length);
            
            public static void FramebufferFetchBarrierEXT() => GLPointers._glFramebufferFetchBarrierEXT_fnptr();
            
            public static void FramebufferPixelLocalStorageSizeEXT(uint target, int size) => GLPointers._glFramebufferPixelLocalStorageSizeEXT_fnptr(target, size);
            
            public static void FramebufferShadingRateEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int baseLayer, int numLayers, int texelWidth, int texelHeight) => GLPointers._glFramebufferShadingRateEXT_fnptr((uint)target, (uint)attachment, texture, baseLayer, numLayers, texelWidth, texelHeight);
            
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            public static void FramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureEXT_fnptr((uint)target, (uint)attachment, texture, level);
            
            public static void GenProgramPipelinesEXT(int n, int* pipelines) => GLPointers._glGenProgramPipelinesEXT_fnptr(n, pipelines);
            
            public static void GenQueriesEXT(int n, int* ids) => GLPointers._glGenQueriesEXT_fnptr(n, ids);
            
            public static void GenSemaphoresEXT(int n, uint* semaphores) => GLPointers._glGenSemaphoresEXT_fnptr(n, semaphores);
            
            public static int GetFragDataIndexEXT(int program, byte* name) => GLPointers._glGetFragDataIndexEXT_fnptr(program, name);
            
            public static void GetFragmentShadingRatesEXT(int samples, int maxCount, int* count, ShadingRate* shadingRates) => GLPointers._glGetFragmentShadingRatesEXT_fnptr(samples, maxCount, count, (uint*)shadingRates);
            
            public static int GetFramebufferPixelLocalStorageSizeEXT(FramebufferTarget target) => GLPointers._glGetFramebufferPixelLocalStorageSizeEXT_fnptr((uint)target);
            
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusEXT_fnptr();
            
            public static void GetInteger64vEXT(GetPName pname, long* data) => GLPointers._glGetInteger64vEXT_fnptr((uint)pname, data);
            
            public static void GetIntegeri_vEXT(GetPName target, uint index, int* data) => GLPointers._glGetIntegeri_vEXT_fnptr((uint)target, index, data);
            
            public static void GetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glGetMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            public static void GetnUniformfvEXT(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformivEXT(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            
            public static void GetObjectLabelEXT(All type, uint obj, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelEXT_fnptr((uint)type, obj, bufSize, length, label);
            
            public static void GetProgramPipelineInfoLogEXT(int pipeline, int bufSize, int* length, byte* infoLog) => GLPointers._glGetProgramPipelineInfoLogEXT_fnptr(pipeline, bufSize, length, infoLog);
            
            public static void GetProgramPipelineivEXT(int pipeline, PipelineParameterName pname, int* parameters) => GLPointers._glGetProgramPipelineivEXT_fnptr(pipeline, (uint)pname, parameters);
            
            public static int GetProgramResourceLocationIndexEXT(int program, ProgramInterface programInterface, byte* name) => GLPointers._glGetProgramResourceLocationIndexEXT_fnptr(program, (uint)programInterface, name);
            
            public static void GetQueryivEXT(QueryTarget target, QueryParameterName pname, int* parameters) => GLPointers._glGetQueryivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetQueryObjecti64vEXT(int id, QueryObjectParameterName pname, long* parameters) => GLPointers._glGetQueryObjecti64vEXT_fnptr(id, (uint)pname, parameters);
            
            public static void GetQueryObjectivEXT(int id, QueryObjectParameterName pname, int* parameters) => GLPointers._glGetQueryObjectivEXT_fnptr(id, (uint)pname, parameters);
            
            public static void GetQueryObjectui64vEXT(int id, QueryObjectParameterName pname, ulong* parameters) => GLPointers._glGetQueryObjectui64vEXT_fnptr(id, (uint)pname, parameters);
            
            public static void GetQueryObjectuivEXT(int id, QueryObjectParameterName pname, uint* parameters) => GLPointers._glGetQueryObjectuivEXT_fnptr(id, (uint)pname, parameters);
            
            public static void GetSamplerParameterIivEXT(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIivEXT_fnptr(sampler, (uint)pname, parameters);
            
            public static void GetSamplerParameterIuivEXT(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuivEXT_fnptr(sampler, (uint)pname, parameters);
            
            public static void GetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glGetSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            public static void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetUnsignedBytei_vEXT(All target, uint index, byte* data) => GLPointers._glGetUnsignedBytei_vEXT_fnptr((uint)target, index, data);
            
            public static void GetUnsignedBytevEXT(GetPName pname, byte* data) => GLPointers._glGetUnsignedBytevEXT_fnptr((uint)pname, data);
            
            public static void ImportMemoryFdEXT(uint memory, ulong size, ExternalHandleType handleType, int fd) => GLPointers._glImportMemoryFdEXT_fnptr(memory, size, (uint)handleType, fd);
            
            public static void ImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, void* handle) => GLPointers._glImportMemoryWin32HandleEXT_fnptr(memory, size, (uint)handleType, handle);
            
            public static void ImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, void* name) => GLPointers._glImportMemoryWin32NameEXT_fnptr(memory, size, (uint)handleType, name);
            
            public static void ImportSemaphoreFdEXT(uint semaphore, ExternalHandleType handleType, int fd) => GLPointers._glImportSemaphoreFdEXT_fnptr(semaphore, (uint)handleType, fd);
            
            public static void ImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, void* handle) => GLPointers._glImportSemaphoreWin32HandleEXT_fnptr(semaphore, (uint)handleType, handle);
            
            public static void ImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, void* name) => GLPointers._glImportSemaphoreWin32NameEXT_fnptr(semaphore, (uint)handleType, name);
            
            public static void InsertEventMarkerEXT(int length, byte* marker) => GLPointers._glInsertEventMarkerEXT_fnptr(length, marker);
            
            public static bool IsEnablediEXT(EnableCap target, uint index) => GLPointers._glIsEnablediEXT_fnptr((uint)target, index) != 0;
            
            public static bool IsMemoryObjectEXT(uint memoryObject) => GLPointers._glIsMemoryObjectEXT_fnptr(memoryObject) != 0;
            
            public static bool IsProgramPipelineEXT(int pipeline) => GLPointers._glIsProgramPipelineEXT_fnptr(pipeline) != 0;
            
            public static bool IsQueryEXT(int id) => GLPointers._glIsQueryEXT_fnptr(id) != 0;
            
            public static bool IsSemaphoreEXT(uint semaphore) => GLPointers._glIsSemaphoreEXT_fnptr(semaphore) != 0;
            
            public static void LabelObjectEXT(All type, uint obj, int length, byte* label) => GLPointers._glLabelObjectEXT_fnptr((uint)type, obj, length, label);
            
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRangeEXT_fnptr((uint)target, offset, length, (uint)access);
            
            public static void MemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int* parameters) => GLPointers._glMemoryObjectParameterivEXT_fnptr(memoryObject, (uint)pname, parameters);
            
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._glMultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            public static void MultiDrawArraysIndirectEXT(PrimitiveType mode, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawArraysIndirectEXT_fnptr((uint)mode, indirect, drawcount, stride);
            
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._glMultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void MultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, void* indirect, int drawcount, int stride) => GLPointers._glMultiDrawElementsIndirectEXT_fnptr((uint)mode, (uint)type, indirect, drawcount, stride);
            
            public static void NamedBufferStorageExternalEXT(int buffer, IntPtr offset, nint size, void* clientBuffer, BufferStorageMask flags) => GLPointers._glNamedBufferStorageExternalEXT_fnptr(buffer, offset, size, clientBuffer, (uint)flags);
            
            public static void NamedBufferStorageMemEXT(int buffer, nint size, uint memory, ulong offset) => GLPointers._glNamedBufferStorageMemEXT_fnptr(buffer, size, memory, offset);
            
            public static void PatchParameteriEXT(PatchParameterName pname, int value) => GLPointers._glPatchParameteriEXT_fnptr((uint)pname, value);
            
            public static void PolygonOffsetClampEXT(float factor, float units, float clamp) => GLPointers._glPolygonOffsetClampEXT_fnptr(factor, units, clamp);
            
            public static void PopGroupMarkerEXT() => GLPointers._glPopGroupMarkerEXT_fnptr();
            
            public static void PrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBoxEXT_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            public static void ProgramParameteriEXT(int program, ProgramParameterPName pname, int value) => GLPointers._glProgramParameteriEXT_fnptr(program, (uint)pname, value);
            
            public static void ProgramUniform1fEXT(int program, int location, float v0) => GLPointers._glProgramUniform1fEXT_fnptr(program, location, v0);
            
            public static void ProgramUniform1fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform1fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform1iEXT(int program, int location, int v0) => GLPointers._glProgramUniform1iEXT_fnptr(program, location, v0);
            
            public static void ProgramUniform1ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform1ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform1uiEXT(int program, int location, uint v0) => GLPointers._glProgramUniform1uiEXT_fnptr(program, location, v0);
            
            public static void ProgramUniform1uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform1uivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform2fEXT(int program, int location, float v0, float v1) => GLPointers._glProgramUniform2fEXT_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform2fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform2fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform2iEXT(int program, int location, int v0, int v1) => GLPointers._glProgramUniform2iEXT_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform2ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform2ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform2uiEXT(int program, int location, uint v0, uint v1) => GLPointers._glProgramUniform2uiEXT_fnptr(program, location, v0, v1);
            
            public static void ProgramUniform2uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform2uivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform3fEXT(int program, int location, float v0, float v1, float v2) => GLPointers._glProgramUniform3fEXT_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform3fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform3fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform3iEXT(int program, int location, int v0, int v1, int v2) => GLPointers._glProgramUniform3iEXT_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform3ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform3ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform3uiEXT(int program, int location, uint v0, uint v1, uint v2) => GLPointers._glProgramUniform3uiEXT_fnptr(program, location, v0, v1, v2);
            
            public static void ProgramUniform3uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform3uivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform4fEXT(int program, int location, float v0, float v1, float v2, float v3) => GLPointers._glProgramUniform4fEXT_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform4fvEXT(int program, int location, int count, float* value) => GLPointers._glProgramUniform4fvEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform4iEXT(int program, int location, int v0, int v1, int v2, int v3) => GLPointers._glProgramUniform4iEXT_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform4ivEXT(int program, int location, int count, int* value) => GLPointers._glProgramUniform4ivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniform4uiEXT(int program, int location, uint v0, uint v1, uint v2, uint v3) => GLPointers._glProgramUniform4uiEXT_fnptr(program, location, v0, v1, v2, v3);
            
            public static void ProgramUniform4uivEXT(int program, int location, int count, uint* value) => GLPointers._glProgramUniform4uivEXT_fnptr(program, location, count, value);
            
            public static void ProgramUniformMatrix2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix2x4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix2x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix3x4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix3x4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x2fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x2fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void ProgramUniformMatrix4x3fvEXT(int program, int location, int count, bool transpose, float* value) => GLPointers._glProgramUniformMatrix4x3fvEXT_fnptr(program, location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void PushGroupMarkerEXT(int length, byte* marker) => GLPointers._glPushGroupMarkerEXT_fnptr(length, marker);
            
            public static void QueryCounterEXT(int id, QueryCounterTarget target) => GLPointers._glQueryCounterEXT_fnptr(id, (uint)target);
            
            public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void ReadBufferIndexedEXT(ReadBufferMode src, int index) => GLPointers._glReadBufferIndexedEXT_fnptr((uint)src, index);
            
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsEXT_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            public static bool ReleaseKeyedMutexWin32EXT(uint memory, ulong key) => GLPointers._glReleaseKeyedMutexWin32EXT_fnptr(memory, key) != 0;
            
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static void SamplerParameterIivEXT(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIivEXT_fnptr(sampler, (uint)pname, param);
            
            public static void SamplerParameterIuivEXT(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuivEXT_fnptr(sampler, (uint)pname, param);
            
            public static void SemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong* parameters) => GLPointers._glSemaphoreParameterui64vEXT_fnptr(semaphore, (uint)pname, parameters);
            
            public static void ShadingRateCombinerOpsEXT(ShadingRateCombinerOp combinerOp0, ShadingRateCombinerOp combinerOp1) => GLPointers._glShadingRateCombinerOpsEXT_fnptr((uint)combinerOp0, (uint)combinerOp1);
            
            public static void ShadingRateEXT(ShadingRate rate) => GLPointers._glShadingRateEXT_fnptr((uint)rate);
            
            public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* dstLayouts) => GLPointers._glSignalSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)dstLayouts);
            
            public static void TexBufferEXT(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferEXT_fnptr((uint)target, (uint)internalformat, buffer);
            
            public static void TexBufferRangeEXT(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRangeEXT_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
            
            public static void TexPageCommitmentEXT(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => GLPointers._glTexPageCommitmentEXT_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (byte)(commit ? 1 : 0));
            
            public static void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuivEXT_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTexStorage1DEXT_fnptr((uint)target, levels, (uint)internalformat, width);
            
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height);
            
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
            
            public static void TexStorageAttribs2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, TexStorageAttribs* attrib_list) => GLPointers._glTexStorageAttribs2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, (int*)attrib_list);
            
            public static void TexStorageAttribs3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth, TexStorageAttribs* attrib_list) => GLPointers._glTexStorageAttribs3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth, (int*)attrib_list);
            
            public static void TexStorageMem1DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTexStorageMem1DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, memory, offset);
            
            public static void TexStorageMem2DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTexStorageMem2DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, memory, offset);
            
            public static void TexStorageMem2DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem2DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void TexStorageMem3DEXT(TextureTarget target, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTexStorageMem3DEXT_fnptr((uint)target, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            public static void TexStorageMem3DMultisampleEXT(TextureTarget target, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTexStorageMem3DMultisampleEXT_fnptr((uint)target, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void TextureStorage1DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTextureStorage1DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width);
            
            public static void TextureStorage2DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTextureStorage2DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height);
            
            public static void TextureStorage3DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTextureStorage3DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height, depth);
            
            public static void TextureStorageMem1DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, uint memory, ulong offset) => GLPointers._glTextureStorageMem1DEXT_fnptr(texture, levels, (uint)internalFormat, width, memory, offset);
            
            public static void TextureStorageMem2DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, memory, offset);
            
            public static void TextureStorageMem2DMultisampleEXT(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem2DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void TextureStorageMem3DEXT(int texture, int levels, SizedInternalFormat internalFormat, int width, int height, int depth, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DEXT_fnptr(texture, levels, (uint)internalFormat, width, height, depth, memory, offset);
            
            public static void TextureStorageMem3DMultisampleEXT(int texture, int samples, SizedInternalFormat internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => GLPointers._glTextureStorageMem3DMultisampleEXT_fnptr(texture, samples, (uint)internalFormat, width, height, depth, (byte)(fixedSampleLocations ? 1 : 0), memory, offset);
            
            public static void TextureViewEXT(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureViewEXT_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            public static void UseProgramStagesEXT(int pipeline, UseProgramStageMask stages, int program) => GLPointers._glUseProgramStagesEXT_fnptr(pipeline, (uint)stages, program);
            
            public static void UseShaderProgramEXT(All type, int program) => GLPointers._glUseShaderProgramEXT_fnptr((uint)type, program);
            
            public static void ValidateProgramPipelineEXT(int pipeline) => GLPointers._glValidateProgramPipelineEXT_fnptr(pipeline);
            
            public static void VertexAttribDivisorEXT(uint index, uint divisor) => GLPointers._glVertexAttribDivisorEXT_fnptr(index, divisor);
            
            public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, int* buffers, uint numTextureBarriers, int* textures, TextureLayout* srcLayouts) => GLPointers._glWaitSemaphoreEXT_fnptr(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, (uint*)srcLayouts);
            
            public static void WindowRectanglesEXT(All mode, int count, int* box) => GLPointers._glWindowRectanglesEXT_fnptr((uint)mode, count, box);
            
        }
        /// <summary>IMG extensions.</summary>
        public static unsafe partial class IMG
        {
            public static void FramebufferTexture2DDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int xscale, int yscale) => GLPointers._glFramebufferTexture2DDownsampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, xscale, yscale);
            
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            public static void FramebufferTextureLayerDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer, int xscale, int yscale) => GLPointers._glFramebufferTextureLayerDownsampleIMG_fnptr((uint)target, (uint)attachment, texture, level, layer, xscale, yscale);
            
            public static ulong GetTextureHandleIMG(int texture) => GLPointers._glGetTextureHandleIMG_fnptr(texture);
            
            public static ulong GetTextureSamplerHandleIMG(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleIMG_fnptr(texture, sampler);
            
            public static void ProgramUniformHandleui64IMG(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64IMG_fnptr(program, location, value);
            
            public static void ProgramUniformHandleui64vIMG(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vIMG_fnptr(program, location, count, values);
            
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleIMG_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static void UniformHandleui64IMG(int location, ulong value) => GLPointers._glUniformHandleui64IMG_fnptr(location, value);
            
            public static void UniformHandleui64vIMG(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vIMG_fnptr(location, count, value);
            
        }
        /// <summary>INTEL extensions.</summary>
        public static unsafe partial class INTEL
        {
            public static void ApplyFramebufferAttachmentCMAAINTEL() => GLPointers._glApplyFramebufferAttachmentCMAAINTEL_fnptr();
            
            public static void BeginPerfQueryINTEL(uint queryHandle) => GLPointers._glBeginPerfQueryINTEL_fnptr(queryHandle);
            
            public static void CreatePerfQueryINTEL(uint queryId, uint* queryHandle) => GLPointers._glCreatePerfQueryINTEL_fnptr(queryId, queryHandle);
            
            public static void DeletePerfQueryINTEL(uint queryHandle) => GLPointers._glDeletePerfQueryINTEL_fnptr(queryHandle);
            
            public static void EndPerfQueryINTEL(uint queryHandle) => GLPointers._glEndPerfQueryINTEL_fnptr(queryHandle);
            
            public static void GetFirstPerfQueryIdINTEL(uint* queryId) => GLPointers._glGetFirstPerfQueryIdINTEL_fnptr(queryId);
            
            public static void GetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId) => GLPointers._glGetNextPerfQueryIdINTEL_fnptr(queryId, nextQueryId);
            
            public static void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue) => GLPointers._glGetPerfCounterInfoINTEL_fnptr(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
            
            public static void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten) => GLPointers._glGetPerfQueryDataINTEL_fnptr(queryHandle, flags, dataSize, data, bytesWritten);
            
            public static void GetPerfQueryIdByNameINTEL(byte* queryName, uint* queryId) => GLPointers._glGetPerfQueryIdByNameINTEL_fnptr(queryName, queryId);
            
            public static void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, PerformanceQueryCapsMaskINTEL* capsMask) => GLPointers._glGetPerfQueryInfoINTEL_fnptr(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, (uint*)capsMask);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            public static void BlendBarrierKHR() => GLPointers._glBlendBarrierKHR_fnptr();
            
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
            
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallbackKHR_fnptr(callback, userParam);
            
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControlKHR_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsertKHR_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLogKHR_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            public static GraphicsResetStatus GetGraphicsResetStatus() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatus_fnptr();
            
            public static GraphicsResetStatus GetGraphicsResetStatusKHR() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusKHR_fnptr();
            
            public static void GetnUniformfv(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfv_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformfvKHR(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvKHR_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformiv(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformiv_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformivKHR(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivKHR_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformuiv(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuiv_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformuivKHR(int program, int location, int bufSize, uint* parameters) => GLPointers._glGetnUniformuivKHR_fnptr(program, location, bufSize, parameters);
            
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelKHR_fnptr((uint)identifier, name, bufSize, length, label);
            
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            
            public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
            
            public static void GetPointervKHR(All pname, void** parameters) => GLPointers._glGetPointervKHR_fnptr((uint)pname, parameters);
            
            public static void MaxShaderCompilerThreadsKHR(uint count) => GLPointers._glMaxShaderCompilerThreadsKHR_fnptr(count);
            
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
            
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabelKHR_fnptr((uint)identifier, name, length, label);
            
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
            
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabelKHR_fnptr(ptr, length, label);
            
            public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
            
            public static void PopDebugGroupKHR() => GLPointers._glPopDebugGroupKHR_fnptr();
            
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
            
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroupKHR_fnptr((uint)source, id, length, message);
            
            public static void ReadnPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixels_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            public static void ReadnPixelsKHR(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsKHR_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            public static void FramebufferParameteriMESA(FramebufferTarget target, FramebufferParameterName pname, int param) => GLPointers._glFramebufferParameteriMESA_fnptr((uint)target, (uint)pname, param);
            
            public static void GetFramebufferParameterivMESA(FramebufferTarget target, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferParameterivMESA_fnptr((uint)target, (uint)pname, parameters);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            public static void BeginConditionalRenderNV(uint id, ConditionalRenderMode mode) => GLPointers._glBeginConditionalRenderNV_fnptr(id, (uint)mode);
            
            public static void BindShadingRateImageNV(int texture) => GLPointers._glBindShadingRateImageNV_fnptr(texture);
            
            public static void BlendBarrierNV() => GLPointers._glBlendBarrierNV_fnptr();
            
            public static void BlendParameteriNV(All pname, int value) => GLPointers._glBlendParameteriNV_fnptr((uint)pname, value);
            
            public static void BlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => GLPointers._glBlitFramebufferNV_fnptr(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            public static void BufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset) => GLPointers._glBufferAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            public static void BufferPageCommitmentMemNV(BufferStorageTarget target, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glBufferPageCommitmentMemNV_fnptr((uint)target, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            public static void ConservativeRasterParameteriNV(All pname, int param) => GLPointers._glConservativeRasterParameteriNV_fnptr((uint)pname, param);
            
            public static void CopyBufferSubDataNV(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLPointers._glCopyBufferSubDataNV_fnptr((uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            public static void CopyPathNV(uint resultPath, uint srcPath) => GLPointers._glCopyPathNV_fnptr(resultPath, srcPath);
            
            public static void CoverageMaskNV(bool mask) => GLPointers._glCoverageMaskNV_fnptr((byte)(mask ? 1 : 0));
            
            public static void CoverageModulationNV(All components) => GLPointers._glCoverageModulationNV_fnptr((uint)components);
            
            public static void CoverageModulationTableNV(int n, float* v) => GLPointers._glCoverageModulationTableNV_fnptr(n, v);
            
            public static void CoverageOperationNV(All operation) => GLPointers._glCoverageOperationNV_fnptr((uint)operation);
            
            public static void CoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            public static void CoverFillPathNV(uint path, PathCoverMode coverMode) => GLPointers._glCoverFillPathNV_fnptr(path, (uint)coverMode);
            
            public static void CoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)coverMode, (uint)transformType, transformValues);
            
            public static void CoverStrokePathNV(uint path, PathCoverMode coverMode) => GLPointers._glCoverStrokePathNV_fnptr(path, (uint)coverMode);
            
            public static void CreateSemaphoresNV(int n, uint* semaphores) => GLPointers._glCreateSemaphoresNV_fnptr(n, semaphores);
            
            public static void DeleteFencesNV(int n, uint* fences) => GLPointers._glDeleteFencesNV_fnptr(n, fences);
            
            public static void DeletePathsNV(uint path, int range) => GLPointers._glDeletePathsNV_fnptr(path, range);
            
            public static void DepthRangeArrayfvNV(uint first, int count, float* v) => GLPointers._glDepthRangeArrayfvNV_fnptr(first, count, v);
            
            public static void DepthRangeIndexedfNV(uint index, float n, float f) => GLPointers._glDepthRangeIndexedfNV_fnptr(index, n, f);
            
            public static void DisableiNV(EnableCap target, uint index) => GLPointers._glDisableiNV_fnptr((uint)target, index);
            
            public static void DrawArraysInstancedNV(PrimitiveType mode, int first, int count, int primcount) => GLPointers._glDrawArraysInstancedNV_fnptr((uint)mode, first, count, primcount);
            
            public static void DrawBuffersNV(int n, All* bufs) => GLPointers._glDrawBuffersNV_fnptr(n, (uint*)bufs);
            
            public static void DrawElementsInstancedNV(PrimitiveType mode, int count, DrawElementsType type, void* indices, int primcount) => GLPointers._glDrawElementsInstancedNV_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void DrawMeshTasksIndirectNV(IntPtr indirect) => GLPointers._glDrawMeshTasksIndirectNV_fnptr(indirect);
            
            public static void DrawMeshTasksNV(uint first, uint count) => GLPointers._glDrawMeshTasksNV_fnptr(first, count);
            
            public static void DrawVkImageNV(ulong vkImage, int sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => GLPointers._glDrawVkImageNV_fnptr(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            
            public static void EnableiNV(EnableCap target, uint index) => GLPointers._glEnableiNV_fnptr((uint)target, index);
            
            public static void EndConditionalRenderNV() => GLPointers._glEndConditionalRenderNV_fnptr();
            
            public static void FinishFenceNV(uint fence) => GLPointers._glFinishFenceNV_fnptr(fence);
            
            public static void FragmentCoverageColorNV(uint color) => GLPointers._glFragmentCoverageColorNV_fnptr(color);
            
            public static void FramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, int count, float* v) => GLPointers._glFramebufferSampleLocationsfvNV_fnptr((uint)target, start, count, v);
            
            public static void GenFencesNV(int n, uint* fences) => GLPointers._glGenFencesNV_fnptr(n, fences);
            
            public static uint GenPathsNV(int range) => GLPointers._glGenPathsNV_fnptr(range);
            
            public static void GetCoverageModulationTableNV(int bufSize, float* v) => GLPointers._glGetCoverageModulationTableNV_fnptr(bufSize, v);
            
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => GLPointers._glGetFenceivNV_fnptr(fence, (uint)pname, parameters);
            
            public static void GetFloati_vNV(GetPName target, uint index, float* data) => GLPointers._glGetFloati_vNV_fnptr((uint)target, index, data);
            
            public static ulong GetImageHandleNV(int texture, int level, bool layered, int layer, PixelFormat format) => GLPointers._glGetImageHandleNV_fnptr(texture, level, (byte)(layered ? 1 : 0), layer, (uint)format);
            
            public static void GetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, int samples, InternalFormatPName pname, int count, int* parameters) => GLPointers._glGetInternalformatSampleivNV_fnptr((uint)target, (uint)internalformat, samples, (uint)pname, count, parameters);
            
            public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, All pname, int first, int count, uint* parameters) => GLPointers._glGetMemoryObjectDetachedResourcesuivNV_fnptr(memory, (uint)pname, first, count, parameters);
            
            public static void GetPathColorGenfvNV(PathColor color, PathGenMode pname, float* value) => GLPointers._glGetPathColorGenfvNV_fnptr((uint)color, (uint)pname, value);
            
            public static void GetPathColorGenivNV(PathColor color, PathGenMode pname, int* value) => GLPointers._glGetPathColorGenivNV_fnptr((uint)color, (uint)pname, value);
            
            public static void GetPathCommandsNV(uint path, byte* commands) => GLPointers._glGetPathCommandsNV_fnptr(path, commands);
            
            public static void GetPathCoordsNV(uint path, float* coords) => GLPointers._glGetPathCoordsNV_fnptr(path, coords);
            
            public static void GetPathDashArrayNV(uint path, float* dashArray) => GLPointers._glGetPathDashArrayNV_fnptr(path, dashArray);
            
            public static float GetPathLengthNV(uint path, int startSegment, int numSegments) => GLPointers._glGetPathLengthNV_fnptr(path, startSegment, numSegments);
            
            public static void GetPathMetricRangeNV(PathMetricMask metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics) => GLPointers._glGetPathMetricRangeNV_fnptr((uint)metricQueryMask, firstPathName, numPaths, stride, metrics);
            
            public static void GetPathMetricsNV(PathMetricMask metricQueryMask, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int stride, float* metrics) => GLPointers._glGetPathMetricsNV_fnptr((uint)metricQueryMask, numPaths, (uint)pathNameType, paths, pathBase, stride, metrics);
            
            public static void GetPathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._glGetPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            public static void GetPathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._glGetPathParameterivNV_fnptr(path, (uint)pname, value);
            
            public static void GetPathSpacingNV(PathListMode pathListMode, int numPaths, PathElementType pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float* returnedSpacing) => GLPointers._glGetPathSpacingNV_fnptr((uint)pathListMode, numPaths, (uint)pathNameType, paths, pathBase, advanceScale, kerningScale, (uint)transformType, returnedSpacing);
            
            public static void GetPathTexGenfvNV(TextureUnit texCoordSet, PathGenMode pname, float* value) => GLPointers._glGetPathTexGenfvNV_fnptr((uint)texCoordSet, (uint)pname, value);
            
            public static void GetPathTexGenivNV(TextureUnit texCoordSet, PathGenMode pname, int* value) => GLPointers._glGetPathTexGenivNV_fnptr((uint)texCoordSet, (uint)pname, value);
            
            public static void GetProgramResourcefvNV(int program, ProgramInterface programInterface, uint index, int propCount, All* props, int count, int* length, float* parameters) => GLPointers._glGetProgramResourcefvNV_fnptr(program, (uint)programInterface, index, propCount, (uint*)props, count, length, parameters);
            
            public static void GetSemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glGetSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            public static void GetShadingRateImagePaletteNV(uint viewport, uint entry, All* rate) => GLPointers._glGetShadingRateImagePaletteNV_fnptr(viewport, entry, (uint*)rate);
            
            public static void GetShadingRateSampleLocationivNV(All rate, uint samples, uint index, int* location) => GLPointers._glGetShadingRateSampleLocationivNV_fnptr((uint)rate, samples, index, location);
            
            public static ulong GetTextureHandleNV(int texture) => GLPointers._glGetTextureHandleNV_fnptr(texture);
            
            public static ulong GetTextureSamplerHandleNV(int texture, int sampler) => GLPointers._glGetTextureSamplerHandleNV_fnptr(texture, sampler);
            
            public static void GetUniformi64vNV(int program, int location, long* parameters) => GLPointers._glGetUniformi64vNV_fnptr(program, location, parameters);
            
            public static IntPtr GetVkProcAddrNV(byte* name) => GLPointers._glGetVkProcAddrNV_fnptr(name);
            
            public static void InterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight) => GLPointers._glInterpolatePathsNV_fnptr(resultPath, pathA, pathB, weight);
            
            public static bool IsEnablediNV(EnableCap target, uint index) => GLPointers._glIsEnablediNV_fnptr((uint)target, index) != 0;
            
            public static bool IsFenceNV(uint fence) => GLPointers._glIsFenceNV_fnptr(fence) != 0;
            
            public static bool IsImageHandleResidentNV(ulong handle) => GLPointers._glIsImageHandleResidentNV_fnptr(handle) != 0;
            
            public static bool IsPathNV(uint path) => GLPointers._glIsPathNV_fnptr(path) != 0;
            
            public static bool IsPointInFillPathNV(uint path, uint mask, float x, float y) => GLPointers._glIsPointInFillPathNV_fnptr(path, mask, x, y) != 0;
            
            public static bool IsPointInStrokePathNV(uint path, float x, float y) => GLPointers._glIsPointInStrokePathNV_fnptr(path, x, y) != 0;
            
            public static bool IsTextureHandleResidentNV(ulong handle) => GLPointers._glIsTextureHandleResidentNV_fnptr(handle) != 0;
            
            public static void MakeImageHandleNonResidentNV(ulong handle) => GLPointers._glMakeImageHandleNonResidentNV_fnptr(handle);
            
            public static void MakeImageHandleResidentNV(ulong handle, All access) => GLPointers._glMakeImageHandleResidentNV_fnptr(handle, (uint)access);
            
            public static void MakeTextureHandleNonResidentNV(ulong handle) => GLPointers._glMakeTextureHandleNonResidentNV_fnptr(handle);
            
            public static void MakeTextureHandleResidentNV(ulong handle) => GLPointers._glMakeTextureHandleResidentNV_fnptr(handle);
            
            public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixFrustumEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            public static void MatrixLoad3x2fNV(All matrixMode, float* m) => GLPointers._glMatrixLoad3x2fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixLoad3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixLoad3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixLoaddEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoaddEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoadfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadfEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoadIdentityEXT(MatrixMode mode) => GLPointers._glMatrixLoadIdentityEXT_fnptr((uint)mode);
            
            public static void MatrixLoadTranspose3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixLoadTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixLoadTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixLoadTransposedEXT_fnptr((uint)mode, m);
            
            public static void MatrixLoadTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixLoadTransposefEXT_fnptr((uint)mode, m);
            
            public static void MatrixMult3x2fNV(All matrixMode, float* m) => GLPointers._glMatrixMult3x2fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixMult3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixMult3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixMultdEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultdEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultfEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultfEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultTranspose3x3fNV(All matrixMode, float* m) => GLPointers._glMatrixMultTranspose3x3fNV_fnptr((uint)matrixMode, m);
            
            public static void MatrixMultTransposedEXT(MatrixMode mode, double* m) => GLPointers._glMatrixMultTransposedEXT_fnptr((uint)mode, m);
            
            public static void MatrixMultTransposefEXT(MatrixMode mode, float* m) => GLPointers._glMatrixMultTransposefEXT_fnptr((uint)mode, m);
            
            public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => GLPointers._glMatrixOrthoEXT_fnptr((uint)mode, left, right, bottom, top, zNear, zFar);
            
            public static void MatrixPopEXT(MatrixMode mode) => GLPointers._glMatrixPopEXT_fnptr((uint)mode);
            
            public static void MatrixPushEXT(MatrixMode mode) => GLPointers._glMatrixPushEXT_fnptr((uint)mode);
            
            public static void MatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => GLPointers._glMatrixRotatedEXT_fnptr((uint)mode, angle, x, y, z);
            
            public static void MatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => GLPointers._glMatrixRotatefEXT_fnptr((uint)mode, angle, x, y, z);
            
            public static void MatrixScaledEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixScaledEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixScalefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixScalefEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => GLPointers._glMatrixTranslatedEXT_fnptr((uint)mode, x, y, z);
            
            public static void MatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => GLPointers._glMatrixTranslatefEXT_fnptr((uint)mode, x, y, z);
            
            public static void MultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectCountNV_fnptr(indirect, drawcount, maxdrawcount, stride);
            
            public static void MultiDrawMeshTasksIndirectNV(IntPtr indirect, int drawcount, int stride) => GLPointers._glMultiDrawMeshTasksIndirectNV_fnptr(indirect, drawcount, stride);
            
            public static void NamedBufferAttachMemoryNV(int buffer, uint memory, ulong offset) => GLPointers._glNamedBufferAttachMemoryNV_fnptr(buffer, memory, offset);
            
            public static void NamedBufferPageCommitmentMemNV(int buffer, IntPtr offset, nint size, uint memory, ulong memOffset, bool commit) => GLPointers._glNamedBufferPageCommitmentMemNV_fnptr(buffer, offset, size, memory, memOffset, (byte)(commit ? 1 : 0));
            
            public static void NamedFramebufferSampleLocationsfvNV(int framebuffer, uint start, int count, float* v) => GLPointers._glNamedFramebufferSampleLocationsfvNV_fnptr(framebuffer, start, count, v);
            
            public static void PathColorGenNV(PathColor color, PathGenMode genMode, PathColorFormat colorFormat, float* coeffs) => GLPointers._glPathColorGenNV_fnptr((uint)color, (uint)genMode, (uint)colorFormat, coeffs);
            
            public static void PathCommandsNV(uint path, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCommandsNV_fnptr(path, numCommands, commands, numCoords, (uint)coordType, coords);
            
            public static void PathCoordsNV(uint path, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathCoordsNV_fnptr(path, numCoords, (uint)coordType, coords);
            
            public static void PathCoverDepthFuncNV(DepthFunction func) => GLPointers._glPathCoverDepthFuncNV_fnptr((uint)func);
            
            public static void PathDashArrayNV(uint path, int dashCount, float* dashArray) => GLPointers._glPathDashArrayNV_fnptr(path, dashCount, dashArray);
            
            public static void PathFogGenNV(PathGenMode genMode) => GLPointers._glPathFogGenNV_fnptr((uint)genMode);
            
            public static All PathGlyphIndexArrayNV(uint firstPathName, All fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            public static All PathGlyphIndexRangeNV(All fontTarget, void* fontName, PathFontStyle fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount) => (All) GLPointers._glPathGlyphIndexRangeNV_fnptr((uint)fontTarget, fontName, (uint)fontStyle, pathParameterTemplate, emScale, baseAndCount);
            
            public static void PathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, uint firstGlyph, int numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphRangeNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, firstGlyph, numGlyphs, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            public static void PathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, void* fontName, PathFontStyle fontStyle, int numGlyphs, PathElementType type, void* charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => GLPointers._glPathGlyphsNV_fnptr(firstPathName, (uint)fontTarget, fontName, (uint)fontStyle, numGlyphs, (uint)type, charcodes, (uint)handleMissingGlyphs, pathParameterTemplate, emScale);
            
            public static All PathMemoryGlyphIndexArrayNV(uint firstPathName, All fontTarget, nint fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale) => (All) GLPointers._glPathMemoryGlyphIndexArrayNV_fnptr(firstPathName, (uint)fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
            
            public static void PathParameterfNV(uint path, PathParameter pname, float value) => GLPointers._glPathParameterfNV_fnptr(path, (uint)pname, value);
            
            public static void PathParameterfvNV(uint path, PathParameter pname, float* value) => GLPointers._glPathParameterfvNV_fnptr(path, (uint)pname, value);
            
            public static void PathParameteriNV(uint path, PathParameter pname, int value) => GLPointers._glPathParameteriNV_fnptr(path, (uint)pname, value);
            
            public static void PathParameterivNV(uint path, PathParameter pname, int* value) => GLPointers._glPathParameterivNV_fnptr(path, (uint)pname, value);
            
            public static void PathStencilDepthOffsetNV(float factor, float units) => GLPointers._glPathStencilDepthOffsetNV_fnptr(factor, units);
            
            public static void PathStencilFuncNV(StencilFunction func, int reference, uint mask) => GLPointers._glPathStencilFuncNV_fnptr((uint)func, reference, mask);
            
            public static void PathStringNV(uint path, PathStringFormat format, int length, void* pathString) => GLPointers._glPathStringNV_fnptr(path, (uint)format, length, pathString);
            
            public static void PathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCommandsNV_fnptr(path, commandStart, commandsToDelete, numCommands, commands, numCoords, (uint)coordType, coords);
            
            public static void PathSubCoordsNV(uint path, int coordStart, int numCoords, PathCoordType coordType, void* coords) => GLPointers._glPathSubCoordsNV_fnptr(path, coordStart, numCoords, (uint)coordType, coords);
            
            public static void PathTexGenNV(PathColor texCoordSet, PathGenMode genMode, int components, float* coeffs) => GLPointers._glPathTexGenNV_fnptr((uint)texCoordSet, (uint)genMode, components, coeffs);
            
            public static bool PointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY) => GLPointers._glPointAlongPathNV_fnptr(path, startSegment, numSegments, distance, x, y, tangentX, tangentY) != 0;
            
            public static void PolygonModeNV(TriangleFace face, PolygonMode mode) => GLPointers._glPolygonModeNV_fnptr((uint)face, (uint)mode);
            
            public static void ProgramPathFragmentInputGenNV(int program, int location, All genMode, int components, float* coeffs) => GLPointers._glProgramPathFragmentInputGenNV_fnptr(program, location, (uint)genMode, components, coeffs);
            
            public static void ProgramUniform1i64NV(int program, int location, long x) => GLPointers._glProgramUniform1i64NV_fnptr(program, location, x);
            
            public static void ProgramUniform1i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform1i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform1ui64NV(int program, int location, ulong x) => GLPointers._glProgramUniform1ui64NV_fnptr(program, location, x);
            
            public static void ProgramUniform1ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform1ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform2i64NV(int program, int location, long x, long y) => GLPointers._glProgramUniform2i64NV_fnptr(program, location, x, y);
            
            public static void ProgramUniform2i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform2i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform2ui64NV(int program, int location, ulong x, ulong y) => GLPointers._glProgramUniform2ui64NV_fnptr(program, location, x, y);
            
            public static void ProgramUniform2ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform2ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform3i64NV(int program, int location, long x, long y, long z) => GLPointers._glProgramUniform3i64NV_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform3i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform3i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform3ui64NV(int program, int location, ulong x, ulong y, ulong z) => GLPointers._glProgramUniform3ui64NV_fnptr(program, location, x, y, z);
            
            public static void ProgramUniform3ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform3ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform4i64NV(int program, int location, long x, long y, long z, long w) => GLPointers._glProgramUniform4i64NV_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform4i64vNV(int program, int location, int count, long* value) => GLPointers._glProgramUniform4i64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniform4ui64NV(int program, int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glProgramUniform4ui64NV_fnptr(program, location, x, y, z, w);
            
            public static void ProgramUniform4ui64vNV(int program, int location, int count, ulong* value) => GLPointers._glProgramUniform4ui64vNV_fnptr(program, location, count, value);
            
            public static void ProgramUniformHandleui64NV(int program, int location, ulong value) => GLPointers._glProgramUniformHandleui64NV_fnptr(program, location, value);
            
            public static void ProgramUniformHandleui64vNV(int program, int location, int count, ulong* values) => GLPointers._glProgramUniformHandleui64vNV_fnptr(program, location, count, values);
            
            public static void RasterSamplesEXT(uint samples, bool fixedsamplelocations) => GLPointers._glRasterSamplesEXT_fnptr(samples, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void ReadBufferNV(All mode) => GLPointers._glReadBufferNV_fnptr((uint)mode);
            
            public static void RenderbufferStorageMultisampleNV(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleNV_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static void ResetMemoryObjectParameterNV(uint memory, All pname) => GLPointers._glResetMemoryObjectParameterNV_fnptr(memory, (uint)pname);
            
            public static void ResolveDepthValuesNV() => GLPointers._glResolveDepthValuesNV_fnptr();
            
            public static void ScissorArrayvNV(uint first, int count, int* v) => GLPointers._glScissorArrayvNV_fnptr(first, count, v);
            
            public static void ScissorExclusiveArrayvNV(uint first, int count, int* v) => GLPointers._glScissorExclusiveArrayvNV_fnptr(first, count, v);
            
            public static void ScissorExclusiveNV(int x, int y, int width, int height) => GLPointers._glScissorExclusiveNV_fnptr(x, y, width, height);
            
            public static void ScissorIndexedNV(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexedNV_fnptr(index, left, bottom, width, height);
            
            public static void ScissorIndexedvNV(uint index, int* v) => GLPointers._glScissorIndexedvNV_fnptr(index, v);
            
            public static void SemaphoreParameterivNV(uint semaphore, SemaphoreParameterName pname, int* parameters) => GLPointers._glSemaphoreParameterivNV_fnptr(semaphore, (uint)pname, parameters);
            
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => GLPointers._glSetFenceNV_fnptr(fence, (uint)condition);
            
            public static void ShadingRateImageBarrierNV(bool synchronize) => GLPointers._glShadingRateImageBarrierNV_fnptr((byte)(synchronize ? 1 : 0));
            
            public static void ShadingRateImagePaletteNV(uint viewport, uint first, int count, All* rates) => GLPointers._glShadingRateImagePaletteNV_fnptr(viewport, first, count, (uint*)rates);
            
            public static void ShadingRateSampleOrderCustomNV(All rate, uint samples, int* locations) => GLPointers._glShadingRateSampleOrderCustomNV_fnptr((uint)rate, samples, locations);
            
            public static void ShadingRateSampleOrderNV(All order) => GLPointers._glShadingRateSampleOrderNV_fnptr((uint)order);
            
            public static void SignalVkFenceNV(ulong vkFence) => GLPointers._glSignalVkFenceNV_fnptr(vkFence);
            
            public static void SignalVkSemaphoreNV(ulong vkSemaphore) => GLPointers._glSignalVkSemaphoreNV_fnptr(vkSemaphore);
            
            public static void StencilFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)transformType, transformValues);
            
            public static void StencilFillPathNV(uint path, PathFillMode fillMode, uint mask) => GLPointers._glStencilFillPathNV_fnptr(path, (uint)fillMode, mask);
            
            public static void StencilStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float* transformValues) => GLPointers._glStencilStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)transformType, transformValues);
            
            public static void StencilStrokePathNV(uint path, int reference, uint mask) => GLPointers._glStencilStrokePathNV_fnptr(path, reference, mask);
            
            public static void StencilThenCoverFillPathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, PathFillMode fillMode, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverFillPathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, (uint)fillMode, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            public static void StencilThenCoverFillPathNV(uint path, PathFillMode fillMode, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverFillPathNV_fnptr(path, (uint)fillMode, mask, (uint)coverMode);
            
            public static void StencilThenCoverStrokePathInstancedNV(int numPaths, PathElementType pathNameType, void* paths, uint pathBase, int reference, uint mask, InstancedPathCoverMode coverMode, PathTransformType transformType, float* transformValues) => GLPointers._glStencilThenCoverStrokePathInstancedNV_fnptr(numPaths, (uint)pathNameType, paths, pathBase, reference, mask, (uint)coverMode, (uint)transformType, transformValues);
            
            public static void StencilThenCoverStrokePathNV(uint path, int reference, uint mask, PathCoverMode coverMode) => GLPointers._glStencilThenCoverStrokePathNV_fnptr(path, reference, mask, (uint)coverMode);
            
            public static void SubpixelPrecisionBiasNV(uint xbits, uint ybits) => GLPointers._glSubpixelPrecisionBiasNV_fnptr(xbits, ybits);
            
            public static bool TestFenceNV(uint fence) => GLPointers._glTestFenceNV_fnptr(fence) != 0;
            
            public static void TexAttachMemoryNV(TextureTarget target, uint memory, ulong offset) => GLPointers._glTexAttachMemoryNV_fnptr((uint)target, memory, offset);
            
            public static void TexPageCommitmentMemNV(TextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexPageCommitmentMemNV_fnptr((uint)target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            public static void TextureAttachMemoryNV(int texture, uint memory, ulong offset) => GLPointers._glTextureAttachMemoryNV_fnptr(texture, memory, offset);
            
            public static void TexturePageCommitmentMemNV(int texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit) => GLPointers._glTexturePageCommitmentMemNV_fnptr(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, (byte)(commit ? 1 : 0));
            
            public static void TransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float* transformValues) => GLPointers._glTransformPathNV_fnptr(resultPath, srcPath, (uint)transformType, transformValues);
            
            public static void Uniform1i64NV(int location, long x) => GLPointers._glUniform1i64NV_fnptr(location, x);
            
            public static void Uniform1i64vNV(int location, int count, long* value) => GLPointers._glUniform1i64vNV_fnptr(location, count, value);
            
            public static void Uniform1ui64NV(int location, ulong x) => GLPointers._glUniform1ui64NV_fnptr(location, x);
            
            public static void Uniform1ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform1ui64vNV_fnptr(location, count, value);
            
            public static void Uniform2i64NV(int location, long x, long y) => GLPointers._glUniform2i64NV_fnptr(location, x, y);
            
            public static void Uniform2i64vNV(int location, int count, long* value) => GLPointers._glUniform2i64vNV_fnptr(location, count, value);
            
            public static void Uniform2ui64NV(int location, ulong x, ulong y) => GLPointers._glUniform2ui64NV_fnptr(location, x, y);
            
            public static void Uniform2ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform2ui64vNV_fnptr(location, count, value);
            
            public static void Uniform3i64NV(int location, long x, long y, long z) => GLPointers._glUniform3i64NV_fnptr(location, x, y, z);
            
            public static void Uniform3i64vNV(int location, int count, long* value) => GLPointers._glUniform3i64vNV_fnptr(location, count, value);
            
            public static void Uniform3ui64NV(int location, ulong x, ulong y, ulong z) => GLPointers._glUniform3ui64NV_fnptr(location, x, y, z);
            
            public static void Uniform3ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform3ui64vNV_fnptr(location, count, value);
            
            public static void Uniform4i64NV(int location, long x, long y, long z, long w) => GLPointers._glUniform4i64NV_fnptr(location, x, y, z, w);
            
            public static void Uniform4i64vNV(int location, int count, long* value) => GLPointers._glUniform4i64vNV_fnptr(location, count, value);
            
            public static void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => GLPointers._glUniform4ui64NV_fnptr(location, x, y, z, w);
            
            public static void Uniform4ui64vNV(int location, int count, ulong* value) => GLPointers._glUniform4ui64vNV_fnptr(location, count, value);
            
            public static void UniformHandleui64NV(int location, ulong value) => GLPointers._glUniformHandleui64NV_fnptr(location, value);
            
            public static void UniformHandleui64vNV(int location, int count, ulong* value) => GLPointers._glUniformHandleui64vNV_fnptr(location, count, value);
            
            public static void UniformMatrix2x3fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x3fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix2x4fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix2x4fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix3x2fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x2fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix3x4fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix3x4fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix4x2fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x2fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void UniformMatrix4x3fvNV(int location, int count, bool transpose, float* value) => GLPointers._glUniformMatrix4x3fvNV_fnptr(location, count, (byte)(transpose ? 1 : 0), value);
            
            public static void VertexAttribDivisorNV(uint index, uint divisor) => GLPointers._glVertexAttribDivisorNV_fnptr(index, divisor);
            
            public static void ViewportArrayvNV(uint first, int count, float* v) => GLPointers._glViewportArrayvNV_fnptr(first, count, v);
            
            public static void ViewportIndexedfNV(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedfNV_fnptr(index, x, y, w, h);
            
            public static void ViewportIndexedfvNV(uint index, float* v) => GLPointers._glViewportIndexedfvNV_fnptr(index, v);
            
            public static void ViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff) => GLPointers._glViewportPositionWScaleNV_fnptr(index, xcoeff, ycoeff);
            
            public static void ViewportSwizzleNV(uint index, All swizzlex, All swizzley, All swizzlez, All swizzlew) => GLPointers._glViewportSwizzleNV_fnptr(index, (uint)swizzlex, (uint)swizzley, (uint)swizzlez, (uint)swizzlew);
            
            public static void WaitVkSemaphoreNV(ulong vkSemaphore) => GLPointers._glWaitVkSemaphoreNV_fnptr(vkSemaphore);
            
            public static void WeightPathsNV(uint resultPath, int numPaths, uint* paths, float* weights) => GLPointers._glWeightPathsNV_fnptr(resultPath, numPaths, paths, weights);
            
        }
        /// <summary>OES extensions.</summary>
        public static unsafe partial class OES
        {
            public static void BindVertexArrayOES(int array) => GLPointers._glBindVertexArrayOES_fnptr(array);
            
            public static void BlendEquationiOES(uint buf, BlendEquationModeEXT mode) => GLPointers._glBlendEquationiOES_fnptr(buf, (uint)mode);
            
            public static void BlendEquationSeparateiOES(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateiOES_fnptr(buf, (uint)modeRGB, (uint)modeAlpha);
            
            public static void BlendFunciOES(uint buf, BlendingFactor src, BlendingFactor dst) => GLPointers._glBlendFunciOES_fnptr(buf, (uint)src, (uint)dst);
            
            public static void BlendFuncSeparateiOES(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateiOES_fnptr(buf, (uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            public static void ColorMaskiOES(uint index, bool r, bool g, bool b, bool a) => GLPointers._glColorMaskiOES_fnptr(index, (byte)(r ? 1 : 0), (byte)(g ? 1 : 0), (byte)(b ? 1 : 0), (byte)(a ? 1 : 0));
            
            public static void CompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, imageSize, data);
            
            public static void CompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
            
            public static void CopyImageSubDataOES(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) => GLPointers._glCopyImageSubDataOES_fnptr(srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            
            public static void CopyTexSubImage3DOES(All target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
            
            public static void DeleteVertexArraysOES(int n, int* arrays) => GLPointers._glDeleteVertexArraysOES_fnptr(n, arrays);
            
            public static void DepthRangeArrayfvOES(uint first, int count, float* v) => GLPointers._glDepthRangeArrayfvOES_fnptr(first, count, v);
            
            public static void DepthRangeIndexedfOES(uint index, float n, float f) => GLPointers._glDepthRangeIndexedfOES_fnptr(index, n, f);
            
            public static void DisableiOES(EnableCap target, uint index) => GLPointers._glDisableiOES_fnptr((uint)target, index);
            
            public static void DrawElementsBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawElementsBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, basevertex);
            
            public static void DrawElementsInstancedBaseVertexOES(PrimitiveType mode, int count, DrawElementsType type, void* indices, int instancecount, int basevertex) => GLPointers._glDrawElementsInstancedBaseVertexOES_fnptr((uint)mode, count, (uint)type, indices, instancecount, basevertex);
            
            public static void DrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, void* indices, int basevertex) => GLPointers._glDrawRangeElementsBaseVertexOES_fnptr((uint)mode, start, end, count, (uint)type, indices, basevertex);
            
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => GLPointers._glEGLImageTargetRenderbufferStorageOES_fnptr((uint)target, image);
            
            public static void EGLImageTargetTexture2DOES(All target, void* image) => GLPointers._glEGLImageTargetTexture2DOES_fnptr((uint)target, image);
            
            public static void EnableiOES(EnableCap target, uint index) => GLPointers._glEnableiOES_fnptr((uint)target, index);
            
            public static void FramebufferTexture3DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int zoffset) => GLPointers._glFramebufferTexture3DOES_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, zoffset);
            
            public static void FramebufferTextureOES(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => GLPointers._glFramebufferTextureOES_fnptr((uint)target, (uint)attachment, texture, level);
            
            public static void GenVertexArraysOES(int n, int* arrays) => GLPointers._glGenVertexArraysOES_fnptr(n, arrays);
            
            public static void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointervOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetFloati_vOES(GetPName target, uint index, float* data) => GLPointers._glGetFloati_vOES_fnptr((uint)target, index, data);
            
            public static void GetProgramBinaryOES(int program, int bufSize, int* length, All* binaryFormat, void* binary) => GLPointers._glGetProgramBinaryOES_fnptr(program, bufSize, length, (uint*)binaryFormat, binary);
            
            public static void GetSamplerParameterIivOES(int sampler, SamplerParameterI pname, int* parameters) => GLPointers._glGetSamplerParameterIivOES_fnptr(sampler, (uint)pname, parameters);
            
            public static void GetSamplerParameterIuivOES(int sampler, SamplerParameterI pname, uint* parameters) => GLPointers._glGetSamplerParameterIuivOES_fnptr(sampler, (uint)pname, parameters);
            
            public static void GetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint* parameters) => GLPointers._glGetTexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static bool IsEnablediOES(EnableCap target, uint index) => GLPointers._glIsEnablediOES_fnptr((uint)target, index) != 0;
            
            public static bool IsVertexArrayOES(int array) => GLPointers._glIsVertexArrayOES_fnptr(array) != 0;
            
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => GLPointers._glMapBufferOES_fnptr((uint)target, (uint)access);
            
            public static void MinSampleShadingOES(float value) => GLPointers._glMinSampleShadingOES_fnptr(value);
            
            public static void MultiDrawElementsBaseVertexEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int drawcount, int* basevertex) => GLPointers._glMultiDrawElementsBaseVertexEXT_fnptr((uint)mode, count, (uint)type, indices, drawcount, basevertex);
            
            public static void PatchParameteriOES(PatchParameterName pname, int value) => GLPointers._glPatchParameteriOES_fnptr((uint)pname, value);
            
            public static void PrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => GLPointers._glPrimitiveBoundingBoxOES_fnptr(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            
            public static void ProgramBinaryOES(int program, All binaryFormat, void* binary, int length) => GLPointers._glProgramBinaryOES_fnptr(program, (uint)binaryFormat, binary, length);
            
            public static void SamplerParameterIivOES(int sampler, SamplerParameterI pname, int* param) => GLPointers._glSamplerParameterIivOES_fnptr(sampler, (uint)pname, param);
            
            public static void SamplerParameterIuivOES(int sampler, SamplerParameterI pname, uint* param) => GLPointers._glSamplerParameterIuivOES_fnptr(sampler, (uint)pname, param);
            
            public static void ScissorArrayvOES(uint first, int count, int* v) => GLPointers._glScissorArrayvOES_fnptr(first, count, v);
            
            public static void ScissorIndexedOES(uint index, int left, int bottom, int width, int height) => GLPointers._glScissorIndexedOES_fnptr(index, left, bottom, width, height);
            
            public static void ScissorIndexedvOES(uint index, int* v) => GLPointers._glScissorIndexedvOES_fnptr(index, v);
            
            public static void TexBufferOES(TextureTarget target, SizedInternalFormat internalformat, int buffer) => GLPointers._glTexBufferOES_fnptr((uint)target, (uint)internalformat, buffer);
            
            public static void TexBufferRangeOES(TextureTarget target, SizedInternalFormat internalformat, int buffer, IntPtr offset, nint size) => GLPointers._glTexBufferRangeOES_fnptr((uint)target, (uint)internalformat, buffer, offset, size);
            
            public static void TexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage3DOES_fnptr((uint)target, level, (uint)internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
            
            public static void TexParameterIivOES(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameterIivOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint* parameters) => GLPointers._glTexParameterIuivOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TexStorage3DMultisampleOES(TextureTarget target, int samples, SizedInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations) => GLPointers._glTexStorage3DMultisampleOES_fnptr((uint)target, samples, (uint)internalformat, width, height, depth, (byte)(fixedsamplelocations ? 1 : 0));
            
            public static void TexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage3DOES_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
            
            public static void TextureViewOES(int texture, TextureTarget target, int origtexture, SizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => GLPointers._glTextureViewOES_fnptr(texture, (uint)target, origtexture, (uint)internalformat, minlevel, numlevels, minlayer, numlayers);
            
            public static bool UnmapBufferOES(All target) => GLPointers._glUnmapBufferOES_fnptr((uint)target) != 0;
            
            public static void ViewportArrayvOES(uint first, int count, float* v) => GLPointers._glViewportArrayvOES_fnptr(first, count, v);
            
            public static void ViewportIndexedfOES(uint index, float x, float y, float w, float h) => GLPointers._glViewportIndexedfOES_fnptr(index, x, y, w, h);
            
            public static void ViewportIndexedfvOES(uint index, float* v) => GLPointers._glViewportIndexedfvOES_fnptr(index, v);
            
        }
        /// <summary>OVR extensions.</summary>
        public static unsafe partial class OVR
        {
            public static void FramebufferTextureMultisampleMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int samples, int baseViewIndex, int numViews) => GLPointers._glFramebufferTextureMultisampleMultiviewOVR_fnptr((uint)target, (uint)attachment, texture, level, samples, baseViewIndex, numViews);
            
            public static void FramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int baseViewIndex, int numViews) => GLPointers._glFramebufferTextureMultiviewOVR_fnptr((uint)target, (uint)attachment, texture, level, baseViewIndex, numViews);
            
        }
        /// <summary>QCOM extensions.</summary>
        public static unsafe partial class QCOM
        {
            public static void AlphaFuncQCOM(All func, float reference) => GLPointers._glAlphaFuncQCOM_fnptr((uint)func, reference);
            
            public static void DisableDriverControlQCOM(uint driverControl) => GLPointers._glDisableDriverControlQCOM_fnptr(driverControl);
            
            public static void EnableDriverControlQCOM(uint driverControl) => GLPointers._glEnableDriverControlQCOM_fnptr(driverControl);
            
            public static void EndTilingQCOM(BufferBitQCOM preserveMask) => GLPointers._glEndTilingQCOM_fnptr((uint)preserveMask);
            
            public static void ExtGetBufferPointervQCOM(All target, void** parameters) => GLPointers._glExtGetBufferPointervQCOM_fnptr((uint)target, parameters);
            
            public static void ExtGetBuffersQCOM(int* buffers, int maxBuffers, int* numBuffers) => GLPointers._glExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            
            public static void ExtGetFramebuffersQCOM(int* framebuffers, int maxFramebuffers, int* numFramebuffers) => GLPointers._glExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            
            public static void ExtGetProgramBinarySourceQCOM(int program, ShaderType shadertype, byte* source, int* length) => GLPointers._glExtGetProgramBinarySourceQCOM_fnptr(program, (uint)shadertype, source, length);
            
            public static void ExtGetProgramsQCOM(int* programs, int maxPrograms, int* numPrograms) => GLPointers._glExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            
            public static void ExtGetRenderbuffersQCOM(int* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => GLPointers._glExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            
            public static void ExtGetShadersQCOM(int* shaders, int maxShaders, int* numShaders) => GLPointers._glExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            
            public static void ExtGetTexLevelParameterivQCOM(int texture, All face, int level, All pname, int* parameters) => GLPointers._glExtGetTexLevelParameterivQCOM_fnptr(texture, (uint)face, level, (uint)pname, parameters);
            
            public static void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => GLPointers._glExtGetTexSubImageQCOM_fnptr((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, texels);
            
            public static void ExtGetTexturesQCOM(int* textures, int maxTextures, int* numTextures) => GLPointers._glExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            
            public static bool ExtIsProgramBinaryQCOM(int program) => GLPointers._glExtIsProgramBinaryQCOM_fnptr(program) != 0;
            
            public static void ExtrapolateTex2DQCOM(int src1, int src2, int output, float scaleFactor) => GLPointers._glExtrapolateTex2DQCOM_fnptr(src1, src2, output, scaleFactor);
            
            public static void ExtTexObjectStateOverrideiQCOM(All target, All pname, int param) => GLPointers._glExtTexObjectStateOverrideiQCOM_fnptr((uint)target, (uint)pname, param);
            
            public static void FramebufferFetchBarrierQCOM() => GLPointers._glFramebufferFetchBarrierQCOM_fnptr();
            
            public static void FramebufferFoveationConfigQCOM(int framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint* providedFeatures) => GLPointers._glFramebufferFoveationConfigQCOM_fnptr(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);
            
            public static void FramebufferFoveationParametersQCOM(int framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._glFramebufferFoveationParametersQCOM_fnptr(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
            public static void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => GLPointers._glGetDriverControlsQCOM_fnptr(num, size, driverControls);
            
            public static void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => GLPointers._glGetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            
            public static void ShadingRateQCOM(ShadingRateQCOM rate) => GLPointers._glShadingRateQCOM_fnptr((uint)rate);
            
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => GLPointers._glStartTilingQCOM_fnptr(x, y, width, height, (uint)preserveMask);
            
            public static void TexEstimateMotionQCOM(int reference, int target, int output) => GLPointers._glTexEstimateMotionQCOM_fnptr(reference, target, output);
            
            public static void TexEstimateMotionRegionsQCOM(int reference, int target, int output, int mask) => GLPointers._glTexEstimateMotionRegionsQCOM_fnptr(reference, target, output, mask);
            
            public static void TextureFoveationParametersQCOM(int texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => GLPointers._glTextureFoveationParametersQCOM_fnptr(texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
            
        }
    }
}
