using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLCORE.Extensions
{
    public static partial class ARB
    {
        public unsafe static partial class Es2Compatibility
        {
            [DllImport("opengl32.dll", EntryPoint = "glReleaseShaderCompiler")]
            public static extern void GlReleaseShaderCompiler();
            
            [DllImport("opengl32.dll", EntryPoint = "glShaderBinary")]
            public static extern void GlShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetShaderPrecisionFormat")]
            public static extern void GlGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangef")]
            public static extern void GlDepthRangef(float n, float f);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearDepthf")]
            public static extern void GlClearDepthf(float d);
            
        }
        public unsafe static partial class Es31Compatibility
        {
            [DllImport("opengl32.dll", EntryPoint = "glMemoryBarrierByRegion")]
            public static extern void GlMemoryBarrierByRegion(uint barriers);
            
        }
        public unsafe static partial class Es32Compatibility
        {
            [DllImport("opengl32.dll", EntryPoint = "glPrimitiveBoundingBoxARB")]
            public static extern void GlPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
            
        }
        public unsafe static partial class Es3Compatibility
        {
        }
        public unsafe static partial class ArraysOfArrays
        {
        }
        public unsafe static partial class BaseInstance
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedBaseInstance")]
            public static extern void GlDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseInstance")]
            public static extern void GlDrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
            public static extern void GlDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);
            
        }
        public unsafe static partial class BindlessTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureHandleARB")]
            public static extern uint GlGetTextureHandle(uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureSamplerHandleARB")]
            public static extern uint GlGetTextureSamplerHandle(uint texture, uint sampler);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeTextureHandleResidentARB")]
            public static extern void GlMakeTextureHandleResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeTextureHandleNonResidentARB")]
            public static extern void GlMakeTextureHandleNonResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetImageHandleARB")]
            public static extern uint GlGetImageHandle(uint texture, int level, byte layered, int layer, uint format);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeImageHandleResidentARB")]
            public static extern void GlMakeImageHandleResident(uint handle, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeImageHandleNonResidentARB")]
            public static extern void GlMakeImageHandleNonResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformHandleui64ARB")]
            public static extern void GlUniformHandleui64(int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformHandleui64vARB")]
            public static extern void GlUniformHandleui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformHandleui64ARB")]
            public static extern void GlProgramUniformHandleui64(uint program, int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformHandleui64vARB")]
            public static extern void GlProgramUniformHandleui64v(uint program, int location, int count, uint* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsTextureHandleResidentARB")]
            public static extern byte GlIsTextureHandleResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsImageHandleResidentARB")]
            public static extern byte GlIsImageHandleResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1ui64ARB")]
            public static extern void GlVertexAttribL1ui64(uint index, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1ui64vARB")]
            public static extern void GlVertexAttribL1ui64v(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribLui64vARB")]
            public static extern void GlGetVertexAttribLui64v(uint index, uint pname, uint* parameters);
            
        }
        public unsafe static partial class BlendFuncExtended
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindFragDataLocationIndexed")]
            public static extern void GlBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFragDataIndex")]
            public static extern int GlGetFragDataIndex(uint program, char* name);
            
        }
        public unsafe static partial class BufferStorage
        {
            [DllImport("opengl32.dll", EntryPoint = "glBufferStorage")]
            public static extern void GlBufferStorage(uint target, IntPtr size, void* data, uint flags);
            
        }
        public unsafe static partial class ClEvent
        {
            [DllImport("opengl32.dll", EntryPoint = "glCreateSyncFromCLeventARB")]
            public static extern GLsync* GlCreateSyncFromCLevent(CLContext* context, CLEvent* @event, uint flags);
            
        }
        public unsafe static partial class ClearBufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glClearBufferData")]
            public static extern void GlClearBufferData(uint target, uint internalformat, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearBufferSubData")]
            public static extern void GlClearBufferSubData(uint target, uint internalformat, IntPtr offset, IntPtr size, uint format, uint type, void* data);
            
        }
        public unsafe static partial class ClearTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glClearTexImage")]
            public static extern void GlClearTexImage(uint texture, int level, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearTexSubImage")]
            public static extern void GlClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);
            
        }
        public unsafe static partial class ClipControl
        {
            [DllImport("opengl32.dll", EntryPoint = "glClipControl")]
            public static extern void GlClipControl(uint origin, uint depth);
            
        }
        public unsafe static partial class CompressedTexturePixelStorage
        {
        }
        public unsafe static partial class ComputeShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glDispatchCompute")]
            public static extern void GlDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);
            
            [DllImport("opengl32.dll", EntryPoint = "glDispatchComputeIndirect")]
            public static extern void GlDispatchComputeIndirect(IntPtr indirect);
            
        }
        public unsafe static partial class ComputeVariableGroupSize
        {
            [DllImport("opengl32.dll", EntryPoint = "glDispatchComputeGroupSizeARB")]
            public static extern void GlDispatchComputeGroupSize(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);
            
        }
        public unsafe static partial class ConditionalRenderInverted
        {
        }
        public unsafe static partial class ConservativeDepth
        {
        }
        public unsafe static partial class CopyBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyBufferSubData")]
            public static extern void GlCopyBufferSubData(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            
        }
        public unsafe static partial class CopyImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyImageSubData")]
            public static extern void GlCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
            
        }
        public unsafe static partial class CullDistance
        {
        }
        public unsafe static partial class DebugOutput
        {
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageControlARB")]
            public static extern void GlDebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, byte enabled);
            
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageInsertARB")]
            public static extern void GlDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char* buf);
            
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageCallbackARB")]
            public static extern void GlDebugMessageCallback(GLDEBUGPROCARB callback, void* userParam);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDebugMessageLogARB")]
            public static extern uint GlGetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);
            
        }
        public unsafe static partial class DepthBufferFloat
        {
        }
        public unsafe static partial class DepthClamp
        {
        }
        public unsafe static partial class DerivativeControl
        {
        }
        public unsafe static partial class DirectStateAccess
        {
            [DllImport("opengl32.dll", EntryPoint = "glCreateTransformFeedbacks")]
            public static extern void GlCreateTransformFeedbacks(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackBufferBase")]
            public static extern void GlTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackBufferRange")]
            public static extern void GlTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTransformFeedbackiv")]
            public static extern void GlGetTransformFeedbackiv(uint xfb, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTransformFeedbacki_v")]
            public static extern void GlGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTransformFeedbacki64_v")]
            public static extern void GlGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateBuffers")]
            public static extern void GlCreateBuffers(int n, uint* buffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferStorage")]
            public static extern void GlNamedBufferStorage(uint buffer, IntPtr size, void* data, uint flags);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferData")]
            public static extern void GlNamedBufferData(uint buffer, IntPtr size, void* data, uint usage);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferSubData")]
            public static extern void GlNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyNamedBufferSubData")]
            public static extern void GlCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedBufferData")]
            public static extern void GlClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedBufferSubData")]
            public static extern void GlClearNamedBufferSubData(uint buffer, uint internalformat, IntPtr offset, IntPtr size, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapNamedBuffer")]
            public static extern void* GlMapNamedBuffer(uint buffer, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapNamedBufferRange")]
            public static extern void* GlMapNamedBufferRange(uint buffer, IntPtr offset, IntPtr length, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glUnmapNamedBuffer")]
            public static extern byte GlUnmapNamedBuffer(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushMappedNamedBufferRange")]
            public static extern void GlFlushMappedNamedBufferRange(uint buffer, IntPtr offset, IntPtr length);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferParameteriv")]
            public static extern void GlGetNamedBufferParameteriv(uint buffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferParameteri64v")]
            public static extern void GlGetNamedBufferParameteri64v(uint buffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferPointerv")]
            public static extern void GlGetNamedBufferPointerv(uint buffer, uint pname, void** parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferSubData")]
            public static extern void GlGetNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateFramebuffers")]
            public static extern void GlCreateFramebuffers(int n, uint* framebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferRenderbuffer")]
            public static extern void GlNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferParameteri")]
            public static extern void GlNamedFramebufferParameteri(uint framebuffer, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTexture")]
            public static extern void GlNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferTextureLayer")]
            public static extern void GlNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferDrawBuffer")]
            public static extern void GlNamedFramebufferDrawBuffer(uint framebuffer, uint buf);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferDrawBuffers")]
            public static extern void GlNamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferReadBuffer")]
            public static extern void GlNamedFramebufferReadBuffer(uint framebuffer, uint src);
            
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateNamedFramebufferData")]
            public static extern void GlInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments);
            
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateNamedFramebufferSubData")]
            public static extern void GlInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedFramebufferiv")]
            public static extern void GlClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedFramebufferuiv")]
            public static extern void GlClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedFramebufferfv")]
            public static extern void GlClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearNamedFramebufferfi")]
            public static extern void GlClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlitNamedFramebuffer")]
            public static extern void GlBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
            
            [DllImport("opengl32.dll", EntryPoint = "glCheckNamedFramebufferStatus")]
            public static extern uint GlCheckNamedFramebufferStatus(uint framebuffer, uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedFramebufferParameteriv")]
            public static extern void GlGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
            public static extern void GlGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateRenderbuffers")]
            public static extern void GlCreateRenderbuffers(int n, uint* renderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedRenderbufferStorage")]
            public static extern void GlNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedRenderbufferStorageMultisample")]
            public static extern void GlNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedRenderbufferParameteriv")]
            public static extern void GlGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateTextures")]
            public static extern void GlCreateTextures(uint target, int n, uint* textures);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureBuffer")]
            public static extern void GlTextureBuffer(uint texture, uint internalformat, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureBufferRange")]
            public static extern void GlTextureBufferRange(uint texture, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage1D")]
            public static extern void GlTextureStorage1D(uint texture, int levels, uint internalformat, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage2D")]
            public static extern void GlTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage3D")]
            public static extern void GlTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage2DMultisample")]
            public static extern void GlTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage3DMultisample")]
            public static extern void GlTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureSubImage1D")]
            public static extern void GlTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureSubImage2D")]
            public static extern void GlTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureSubImage3D")]
            public static extern void GlTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureSubImage1D")]
            public static extern void GlCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureSubImage2D")]
            public static extern void GlCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompressedTextureSubImage3D")]
            public static extern void GlCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureSubImage1D")]
            public static extern void GlCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureSubImage2D")]
            public static extern void GlCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyTextureSubImage3D")]
            public static extern void GlCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterf")]
            public static extern void GlTextureParameterf(uint texture, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterfv")]
            public static extern void GlTextureParameterfv(uint texture, uint pname, float* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameteri")]
            public static extern void GlTextureParameteri(uint texture, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterIiv")]
            public static extern void GlTextureParameterIiv(uint texture, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameterIuiv")]
            public static extern void GlTextureParameterIuiv(uint texture, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureParameteriv")]
            public static extern void GlTextureParameteriv(uint texture, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenerateTextureMipmap")]
            public static extern void GlGenerateTextureMipmap(uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindTextureUnit")]
            public static extern void GlBindTextureUnit(uint unit, uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureImage")]
            public static extern void GlGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCompressedTextureImage")]
            public static extern void GlGetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureLevelParameterfv")]
            public static extern void GlGetTextureLevelParameterfv(uint texture, int level, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureLevelParameteriv")]
            public static extern void GlGetTextureLevelParameteriv(uint texture, int level, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameterfv")]
            public static extern void GlGetTextureParameterfv(uint texture, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameterIiv")]
            public static extern void GlGetTextureParameterIiv(uint texture, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameterIuiv")]
            public static extern void GlGetTextureParameterIuiv(uint texture, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureParameteriv")]
            public static extern void GlGetTextureParameteriv(uint texture, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateVertexArrays")]
            public static extern void GlCreateVertexArrays(int n, uint* arrays);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableVertexArrayAttrib")]
            public static extern void GlDisableVertexArrayAttrib(uint vaobj, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableVertexArrayAttrib")]
            public static extern void GlEnableVertexArrayAttrib(uint vaobj, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayElementBuffer")]
            public static extern void GlVertexArrayElementBuffer(uint vaobj, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexBuffer")]
            public static extern void GlVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayVertexBuffers")]
            public static extern void GlVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, IntPtr* offsets, int* strides);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayAttribBinding")]
            public static extern void GlVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayAttribFormat")]
            public static extern void GlVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayAttribIFormat")]
            public static extern void GlVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayAttribLFormat")]
            public static extern void GlVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayBindingDivisor")]
            public static extern void GlVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexArrayiv")]
            public static extern void GlGetVertexArrayiv(uint vaobj, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexArrayIndexediv")]
            public static extern void GlGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexArrayIndexed64iv")]
            public static extern void GlGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateSamplers")]
            public static extern void GlCreateSamplers(int n, uint* samplers);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateProgramPipelines")]
            public static extern void GlCreateProgramPipelines(int n, uint* pipelines);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateQueries")]
            public static extern void GlCreateQueries(uint target, int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryBufferObjecti64v")]
            public static extern void GlGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryBufferObjectiv")]
            public static extern void GlGetQueryBufferObjectiv(uint id, uint buffer, uint pname, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryBufferObjectui64v")]
            public static extern void GlGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryBufferObjectuiv")]
            public static extern void GlGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, IntPtr offset);
            
        }
        public unsafe static partial class DrawBuffersBlend
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationiARB")]
            public static extern void GlBlendEquationi(uint buf, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparateiARB")]
            public static extern void GlBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendFunciARB")]
            public static extern void GlBlendFunci(uint buf, uint src, uint dst);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparateiARB")]
            public static extern void GlBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
            
        }
        public unsafe static partial class DrawElementsBaseVertex
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsBaseVertex")]
            public static extern void GlDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementsBaseVertex")]
            public static extern void GlDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertex")]
            public static extern void GlDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsBaseVertex")]
            public static extern void GlMultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex);
            
        }
        public unsafe static partial class DrawIndirect
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysIndirect")]
            public static extern void GlDrawArraysIndirect(uint mode, void* indirect);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsIndirect")]
            public static extern void GlDrawElementsIndirect(uint mode, uint type, void* indirect);
            
        }
        public unsafe static partial class DrawInstanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedARB")]
            public static extern void GlDrawArraysInstanced(uint mode, int first, int count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedARB")]
            public static extern void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int primcount);
            
        }
        public unsafe static partial class EnhancedLayouts
        {
        }
        public unsafe static partial class ExplicitAttribLocation
        {
        }
        public unsafe static partial class ExplicitUniformLocation
        {
        }
        public unsafe static partial class FragmentCoordConventions
        {
        }
        public unsafe static partial class FragmentLayerViewport
        {
        }
        public unsafe static partial class FragmentShaderInterlock
        {
        }
        public unsafe static partial class FramebufferNoAttachments
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferParameteri")]
            public static extern void GlFramebufferParameteri(uint target, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferParameteriv")]
            public static extern void GlGetFramebufferParameteriv(uint target, uint pname, int* parameters);
            
        }
        public unsafe static partial class FramebufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glIsRenderbuffer")]
            public static extern byte GlIsRenderbuffer(uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindRenderbuffer")]
            public static extern void GlBindRenderbuffer(uint target, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteRenderbuffers")]
            public static extern void GlDeleteRenderbuffers(int n, uint* renderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenRenderbuffers")]
            public static extern void GlGenRenderbuffers(int n, uint* renderbuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorage")]
            public static extern void GlRenderbufferStorage(uint target, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetRenderbufferParameteriv")]
            public static extern void GlGetRenderbufferParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsFramebuffer")]
            public static extern byte GlIsFramebuffer(uint framebuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindFramebuffer")]
            public static extern void GlBindFramebuffer(uint target, uint framebuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteFramebuffers")]
            public static extern void GlDeleteFramebuffers(int n, uint* framebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenFramebuffers")]
            public static extern void GlGenFramebuffers(int n, uint* framebuffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glCheckFramebufferStatus")]
            public static extern uint GlCheckFramebufferStatus(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture1D")]
            public static extern void GlFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2D")]
            public static extern void GlFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture3D")]
            public static extern void GlFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferRenderbuffer")]
            public static extern void GlFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
            public static extern void GlGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenerateMipmap")]
            public static extern void GlGenerateMipmap(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlitFramebuffer")]
            public static extern void GlBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
            
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisample")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureLayer")]
            public static extern void GlFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);
            
        }
        public unsafe static partial class FramebufferSrgb
        {
        }
        public unsafe static partial class GeometryShader4
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameteriARB")]
            public static extern void GlProgramParameteri(uint program, uint pname, int value);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureARB")]
            public static extern void GlFramebufferTexture(uint target, uint attachment, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureLayerARB")]
            public static extern void GlFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureFaceARB")]
            public static extern void GlFramebufferTextureFace(uint target, uint attachment, uint texture, int level, uint face);
            
        }
        public unsafe static partial class GetProgramBinary
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramBinary")]
            public static extern void GlGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramBinary")]
            public static extern void GlProgramBinary(uint program, uint binaryFormat, void* binary, int length);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameteri")]
            public static extern void GlProgramParameteri(uint program, uint pname, int value);
            
        }
        public unsafe static partial class GetTextureSubImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureSubImage")]
            public static extern void GlGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCompressedTextureSubImage")]
            public static extern void GlGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels);
            
        }
        public unsafe static partial class GlSpirv
        {
            [DllImport("opengl32.dll", EntryPoint = "glSpecializeShaderARB")]
            public static extern void GlSpecializeShader(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);
            
        }
        public unsafe static partial class GpuShader5
        {
        }
        public unsafe static partial class GpuShaderFp64
        {
            [DllImport("opengl32.dll", EntryPoint = "glUniform1d")]
            public static extern void GlUniform1d(int location, double x);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2d")]
            public static extern void GlUniform2d(int location, double x, double y);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3d")]
            public static extern void GlUniform3d(int location, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4d")]
            public static extern void GlUniform4d(int location, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1dv")]
            public static extern void GlUniform1dv(int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2dv")]
            public static extern void GlUniform2dv(int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3dv")]
            public static extern void GlUniform3dv(int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4dv")]
            public static extern void GlUniform4dv(int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2dv")]
            public static extern void GlUniformMatrix2dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3dv")]
            public static extern void GlUniformMatrix3dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4dv")]
            public static extern void GlUniformMatrix4dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x3dv")]
            public static extern void GlUniformMatrix2x3dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x4dv")]
            public static extern void GlUniformMatrix2x4dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x2dv")]
            public static extern void GlUniformMatrix3x2dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x4dv")]
            public static extern void GlUniformMatrix3x4dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x2dv")]
            public static extern void GlUniformMatrix4x2dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x3dv")]
            public static extern void GlUniformMatrix4x3dv(int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformdv")]
            public static extern void GlGetUniformdv(uint program, int location, double* parameters);
            
        }
        public unsafe static partial class GpuShaderInt64
        {
            [DllImport("opengl32.dll", EntryPoint = "glUniform1i64ARB")]
            public static extern void GlUniform1i64(int location, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2i64ARB")]
            public static extern void GlUniform2i64(int location, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3i64ARB")]
            public static extern void GlUniform3i64(int location, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4i64ARB")]
            public static extern void GlUniform4i64(int location, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1i64vARB")]
            public static extern void GlUniform1i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2i64vARB")]
            public static extern void GlUniform2i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3i64vARB")]
            public static extern void GlUniform3i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4i64vARB")]
            public static extern void GlUniform4i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1ui64ARB")]
            public static extern void GlUniform1ui64(int location, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2ui64ARB")]
            public static extern void GlUniform2ui64(int location, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3ui64ARB")]
            public static extern void GlUniform3ui64(int location, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4ui64ARB")]
            public static extern void GlUniform4ui64(int location, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1ui64vARB")]
            public static extern void GlUniform1ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2ui64vARB")]
            public static extern void GlUniform2ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3ui64vARB")]
            public static extern void GlUniform3ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4ui64vARB")]
            public static extern void GlUniform4ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformi64vARB")]
            public static extern void GlGetUniformi64v(uint program, int location, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformui64vARB")]
            public static extern void GlGetUniformui64v(uint program, int location, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformi64vARB")]
            public static extern void GlGetnUniformi64v(uint program, int location, int bufSize, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformui64vARB")]
            public static extern void GlGetnUniformui64v(uint program, int location, int bufSize, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i64ARB")]
            public static extern void GlProgramUniform1i64(uint program, int location, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i64ARB")]
            public static extern void GlProgramUniform2i64(uint program, int location, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i64ARB")]
            public static extern void GlProgramUniform3i64(uint program, int location, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i64ARB")]
            public static extern void GlProgramUniform4i64(uint program, int location, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i64vARB")]
            public static extern void GlProgramUniform1i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i64vARB")]
            public static extern void GlProgramUniform2i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i64vARB")]
            public static extern void GlProgramUniform3i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i64vARB")]
            public static extern void GlProgramUniform4i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui64ARB")]
            public static extern void GlProgramUniform1ui64(uint program, int location, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui64ARB")]
            public static extern void GlProgramUniform2ui64(uint program, int location, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui64ARB")]
            public static extern void GlProgramUniform3ui64(uint program, int location, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui64ARB")]
            public static extern void GlProgramUniform4ui64(uint program, int location, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui64vARB")]
            public static extern void GlProgramUniform1ui64v(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui64vARB")]
            public static extern void GlProgramUniform2ui64v(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui64vARB")]
            public static extern void GlProgramUniform3ui64v(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui64vARB")]
            public static extern void GlProgramUniform4ui64v(uint program, int location, int count, uint* value);
            
        }
        public unsafe static partial class HalfFloatVertex
        {
        }
        public unsafe static partial class Imaging
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendColor")]
            public static extern void GlBlendColor(float red, float green, float blue, float alpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquation")]
            public static extern void GlBlendEquation(uint mode);
            
        }
        public unsafe static partial class IndirectParameters
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysIndirectCountARB")]
            public static extern void GlMultiDrawArraysIndirectCount(uint mode, void* indirect, IntPtr drawcount, int maxdrawcount, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsIndirectCountARB")]
            public static extern void GlMultiDrawElementsIndirectCount(uint mode, uint type, void* indirect, IntPtr drawcount, int maxdrawcount, int stride);
            
        }
        public unsafe static partial class InstancedArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribDivisorARB")]
            public static extern void GlVertexAttribDivisor(uint index, uint divisor);
            
        }
        public unsafe static partial class InternalformatQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetInternalformativ")]
            public static extern void GlGetInternalformativ(uint target, uint internalformat, uint pname, int count, int* parameters);
            
        }
        public unsafe static partial class InternalformatQuery2
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetInternalformati64v")]
            public static extern void GlGetInternalformati64v(uint target, uint internalformat, uint pname, int count, int* parameters);
            
        }
        public unsafe static partial class InvalidateSubdata
        {
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateTexSubImage")]
            public static extern void GlInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateTexImage")]
            public static extern void GlInvalidateTexImage(uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateBufferSubData")]
            public static extern void GlInvalidateBufferSubData(uint buffer, IntPtr offset, IntPtr length);
            
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateBufferData")]
            public static extern void GlInvalidateBufferData(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateFramebuffer")]
            public static extern void GlInvalidateFramebuffer(uint target, int numAttachments, uint* attachments);
            
            [DllImport("opengl32.dll", EntryPoint = "glInvalidateSubFramebuffer")]
            public static extern void GlInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);
            
        }
        public unsafe static partial class MapBufferAlignment
        {
        }
        public unsafe static partial class MapBufferRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glMapBufferRange")]
            public static extern void* GlMapBufferRange(uint target, IntPtr offset, IntPtr length, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushMappedBufferRange")]
            public static extern void GlFlushMappedBufferRange(uint target, IntPtr offset, IntPtr length);
            
        }
        public unsafe static partial class MultiBind
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindBuffersBase")]
            public static extern void GlBindBuffersBase(uint target, uint first, int count, uint* buffers);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBuffersRange")]
            public static extern void GlBindBuffersRange(uint target, uint first, int count, uint* buffers, IntPtr* offsets, IntPtr* sizes);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindTextures")]
            public static extern void GlBindTextures(uint first, int count, uint* textures);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindSamplers")]
            public static extern void GlBindSamplers(uint first, int count, uint* samplers);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindImageTextures")]
            public static extern void GlBindImageTextures(uint first, int count, uint* textures);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindVertexBuffers")]
            public static extern void GlBindVertexBuffers(uint first, int count, uint* buffers, IntPtr* offsets, int* strides);
            
        }
        public unsafe static partial class MultiDrawIndirect
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysIndirect")]
            public static extern void GlMultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsIndirect")]
            public static extern void GlMultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride);
            
        }
        public unsafe static partial class OcclusionQuery2
        {
        }
        public unsafe static partial class ParallelShaderCompile
        {
            [DllImport("opengl32.dll", EntryPoint = "glMaxShaderCompilerThreadsARB")]
            public static extern void GlMaxShaderCompilerThreads(uint count);
            
        }
        public unsafe static partial class PipelineStatisticsQuery
        {
        }
        public unsafe static partial class PixelBufferObject
        {
        }
        public unsafe static partial class PolygonOffsetClamp
        {
            [DllImport("opengl32.dll", EntryPoint = "glPolygonOffsetClamp")]
            public static extern void GlPolygonOffsetClamp(float factor, float units, float clamp);
            
        }
        public unsafe static partial class PostDepthCoverage
        {
        }
        public unsafe static partial class ProgramInterfaceQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramInterfaceiv")]
            public static extern void GlGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceIndex")]
            public static extern uint GlGetProgramResourceIndex(uint program, uint programInterface, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceName")]
            public static extern void GlGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceiv")]
            public static extern void GlGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceLocation")]
            public static extern int GlGetProgramResourceLocation(uint program, uint programInterface, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceLocationIndex")]
            public static extern int GlGetProgramResourceLocationIndex(uint program, uint programInterface, char* name);
            
        }
        public unsafe static partial class ProvokingVertex
        {
            [DllImport("opengl32.dll", EntryPoint = "glProvokingVertex")]
            public static extern void GlProvokingVertex(uint mode);
            
        }
        public unsafe static partial class QueryBufferObject
        {
        }
        public unsafe static partial class RobustBufferAccessBehavior
        {
        }
        public unsafe static partial class Robustness
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetGraphicsResetStatusARB")]
            public static extern uint GlGetGraphicsResetStatus();
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnTexImageARB")]
            public static extern void GlGetnTexImage(uint target, int level, uint format, uint type, int bufSize, void* img);
            
            [DllImport("opengl32.dll", EntryPoint = "glReadnPixelsARB")]
            public static extern void GlReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnCompressedTexImageARB")]
            public static extern void GlGetnCompressedTexImage(uint target, int lod, int bufSize, void* img);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformfvARB")]
            public static extern void GlGetnUniformfv(uint program, int location, int bufSize, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformivARB")]
            public static extern void GlGetnUniformiv(uint program, int location, int bufSize, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformuivARB")]
            public static extern void GlGetnUniformuiv(uint program, int location, int bufSize, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformdvARB")]
            public static extern void GlGetnUniformdv(uint program, int location, int bufSize, double* parameters);
            
        }
        public unsafe static partial class RobustnessIsolation
        {
        }
        public unsafe static partial class SampleLocations
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferSampleLocationsfvARB")]
            public static extern void GlFramebufferSampleLocationsfv(uint target, uint start, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferSampleLocationsfvARB")]
            public static extern void GlNamedFramebufferSampleLocationsfv(uint framebuffer, uint start, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glEvaluateDepthValuesARB")]
            public static extern void GlEvaluateDepthValues();
            
        }
        public unsafe static partial class SampleShading
        {
            [DllImport("opengl32.dll", EntryPoint = "glMinSampleShadingARB")]
            public static extern void GlMinSampleShading(float value);
            
        }
        public unsafe static partial class SamplerObjects
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenSamplers")]
            public static extern void GlGenSamplers(int count, uint* samplers);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteSamplers")]
            public static extern void GlDeleteSamplers(int count, uint* samplers);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsSampler")]
            public static extern byte GlIsSampler(uint sampler);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindSampler")]
            public static extern void GlBindSampler(uint unit, uint sampler);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameteri")]
            public static extern void GlSamplerParameteri(uint sampler, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameteriv")]
            public static extern void GlSamplerParameteriv(uint sampler, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterf")]
            public static extern void GlSamplerParameterf(uint sampler, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterfv")]
            public static extern void GlSamplerParameterfv(uint sampler, uint pname, float* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIiv")]
            public static extern void GlSamplerParameterIiv(uint sampler, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIuiv")]
            public static extern void GlSamplerParameterIuiv(uint sampler, uint pname, uint* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameteriv")]
            public static extern void GlGetSamplerParameteriv(uint sampler, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIiv")]
            public static extern void GlGetSamplerParameterIiv(uint sampler, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterfv")]
            public static extern void GlGetSamplerParameterfv(uint sampler, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIuiv")]
            public static extern void GlGetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters);
            
        }
        public unsafe static partial class SeamlessCubeMap
        {
        }
        public unsafe static partial class SeamlessCubemapPerTexture
        {
        }
        public unsafe static partial class SeparateShaderObjects
        {
            [DllImport("opengl32.dll", EntryPoint = "glUseProgramStages")]
            public static extern void GlUseProgramStages(uint pipeline, uint stages, uint program);
            
            [DllImport("opengl32.dll", EntryPoint = "glActiveShaderProgram")]
            public static extern void GlActiveShaderProgram(uint pipeline, uint program);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateShaderProgramv")]
            public static extern uint GlCreateShaderProgramv(uint type, int count, char** strings);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindProgramPipeline")]
            public static extern void GlBindProgramPipeline(uint pipeline);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteProgramPipelines")]
            public static extern void GlDeleteProgramPipelines(int n, uint* pipelines);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenProgramPipelines")]
            public static extern void GlGenProgramPipelines(int n, uint* pipelines);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsProgramPipeline")]
            public static extern byte GlIsProgramPipeline(uint pipeline);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineiv")]
            public static extern void GlGetProgramPipelineiv(uint pipeline, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameteri")]
            public static extern void GlProgramParameteri(uint program, uint pname, int value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i")]
            public static extern void GlProgramUniform1i(uint program, int location, int v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1iv")]
            public static extern void GlProgramUniform1iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1f")]
            public static extern void GlProgramUniform1f(uint program, int location, float v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1fv")]
            public static extern void GlProgramUniform1fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1d")]
            public static extern void GlProgramUniform1d(uint program, int location, double v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1dv")]
            public static extern void GlProgramUniform1dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui")]
            public static extern void GlProgramUniform1ui(uint program, int location, uint v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1uiv")]
            public static extern void GlProgramUniform1uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i")]
            public static extern void GlProgramUniform2i(uint program, int location, int v0, int v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2iv")]
            public static extern void GlProgramUniform2iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2f")]
            public static extern void GlProgramUniform2f(uint program, int location, float v0, float v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2fv")]
            public static extern void GlProgramUniform2fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2d")]
            public static extern void GlProgramUniform2d(uint program, int location, double v0, double v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2dv")]
            public static extern void GlProgramUniform2dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui")]
            public static extern void GlProgramUniform2ui(uint program, int location, uint v0, uint v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2uiv")]
            public static extern void GlProgramUniform2uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i")]
            public static extern void GlProgramUniform3i(uint program, int location, int v0, int v1, int v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3iv")]
            public static extern void GlProgramUniform3iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3f")]
            public static extern void GlProgramUniform3f(uint program, int location, float v0, float v1, float v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3fv")]
            public static extern void GlProgramUniform3fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3d")]
            public static extern void GlProgramUniform3d(uint program, int location, double v0, double v1, double v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3dv")]
            public static extern void GlProgramUniform3dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui")]
            public static extern void GlProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3uiv")]
            public static extern void GlProgramUniform3uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i")]
            public static extern void GlProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4iv")]
            public static extern void GlProgramUniform4iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4f")]
            public static extern void GlProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4fv")]
            public static extern void GlProgramUniform4fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4d")]
            public static extern void GlProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4dv")]
            public static extern void GlProgramUniform4dv(uint program, int location, int count, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui")]
            public static extern void GlProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4uiv")]
            public static extern void GlProgramUniform4uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2fv")]
            public static extern void GlProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3fv")]
            public static extern void GlProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4fv")]
            public static extern void GlProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2dv")]
            public static extern void GlProgramUniformMatrix2dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3dv")]
            public static extern void GlProgramUniformMatrix3dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4dv")]
            public static extern void GlProgramUniformMatrix4dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3fv")]
            public static extern void GlProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2fv")]
            public static extern void GlProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4fv")]
            public static extern void GlProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2fv")]
            public static extern void GlProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4fv")]
            public static extern void GlProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3fv")]
            public static extern void GlProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3dv")]
            public static extern void GlProgramUniformMatrix2x3dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2dv")]
            public static extern void GlProgramUniformMatrix3x2dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4dv")]
            public static extern void GlProgramUniformMatrix2x4dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2dv")]
            public static extern void GlProgramUniformMatrix4x2dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4dv")]
            public static extern void GlProgramUniformMatrix3x4dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3dv")]
            public static extern void GlProgramUniformMatrix4x3dv(uint program, int location, int count, byte transpose, double* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glValidateProgramPipeline")]
            public static extern void GlValidateProgramPipeline(uint pipeline);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineInfoLog")]
            public static extern void GlGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog);
            
        }
        public unsafe static partial class ShaderAtomicCounterOps
        {
        }
        public unsafe static partial class ShaderAtomicCounters
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveAtomicCounterBufferiv")]
            public static extern void GlGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* parameters);
            
        }
        public unsafe static partial class ShaderBallot
        {
        }
        public unsafe static partial class ShaderBitEncoding
        {
        }
        public unsafe static partial class ShaderClock
        {
        }
        public unsafe static partial class ShaderDrawParameters
        {
        }
        public unsafe static partial class ShaderGroupVote
        {
        }
        public unsafe static partial class ShaderImageLoadStore
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindImageTexture")]
            public static extern void GlBindImageTexture(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format);
            
            [DllImport("opengl32.dll", EntryPoint = "glMemoryBarrier")]
            public static extern void GlMemoryBarrier(uint barriers);
            
        }
        public unsafe static partial class ShaderImageSize
        {
        }
        public unsafe static partial class ShaderPrecision
        {
        }
        public unsafe static partial class ShaderStencilExport
        {
        }
        public unsafe static partial class ShaderStorageBufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glShaderStorageBlockBinding")]
            public static extern void GlShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);
            
        }
        public unsafe static partial class ShaderSubroutine
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetSubroutineUniformLocation")]
            public static extern int GlGetSubroutineUniformLocation(uint program, uint shadertype, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSubroutineIndex")]
            public static extern uint GlGetSubroutineIndex(uint program, uint shadertype, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveSubroutineUniformiv")]
            public static extern void GlGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveSubroutineUniformName")]
            public static extern void GlGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveSubroutineName")]
            public static extern void GlGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformSubroutinesuiv")]
            public static extern void GlUniformSubroutinesuiv(uint shadertype, int count, uint* indices);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformSubroutineuiv")]
            public static extern void GlGetUniformSubroutineuiv(uint shadertype, int location, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramStageiv")]
            public static extern void GlGetProgramStageiv(uint program, uint shadertype, uint pname, int* values);
            
        }
        public unsafe static partial class ShaderTextureImageSamples
        {
        }
        public unsafe static partial class ShaderViewportLayerArray
        {
        }
        public unsafe static partial class ShadingLanguage420pack
        {
        }
        public unsafe static partial class ShadingLanguageInclude
        {
            [DllImport("opengl32.dll", EntryPoint = "glNamedStringARB")]
            public static extern void GlNamedString(uint type, int namelen, char* name, int stringlen, char* str);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteNamedStringARB")]
            public static extern void GlDeleteNamedString(int namelen, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompileShaderIncludeARB")]
            public static extern void GlCompileShaderInclude(uint shader, int count, char** path, int* length);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsNamedStringARB")]
            public static extern byte GlIsNamedString(int namelen, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedStringARB")]
            public static extern void GlGetNamedString(int namelen, char* name, int bufSize, int* stringlen, char* str);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedStringivARB")]
            public static extern void GlGetNamedStringiv(int namelen, char* name, uint pname, int* parameters);
            
        }
        public unsafe static partial class ShadingLanguagePacking
        {
        }
        public unsafe static partial class SparseBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glBufferPageCommitmentARB")]
            public static extern void GlBufferPageCommitment(uint target, IntPtr offset, IntPtr size, byte commit);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferPageCommitmentEXT")]
            public static extern void GlNamedBufferPageCommitmentEXT(uint buffer, IntPtr offset, IntPtr size, byte commit);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferPageCommitmentARB")]
            public static extern void GlNamedBufferPageCommitment(uint buffer, IntPtr offset, IntPtr size, byte commit);
            
        }
        public unsafe static partial class SparseTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexPageCommitmentARB")]
            public static extern void GlTexPageCommitment(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, byte commit);
            
        }
        public unsafe static partial class SparseTexture2
        {
        }
        public unsafe static partial class SparseTextureClamp
        {
        }
        public unsafe static partial class SpirvExtensions
        {
        }
        public unsafe static partial class StencilTexturing
        {
        }
        public unsafe static partial class Sync
        {
            [DllImport("opengl32.dll", EntryPoint = "glFenceSync")]
            public static extern GLsync* GlFenceSync(uint condition, uint flags);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsSync")]
            public static extern byte GlIsSync(GLsync* sync);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteSync")]
            public static extern void GlDeleteSync(GLsync* sync);
            
            [DllImport("opengl32.dll", EntryPoint = "glClientWaitSync")]
            public static extern uint GlClientWaitSync(GLsync* sync, uint flags, uint timeout);
            
            [DllImport("opengl32.dll", EntryPoint = "glWaitSync")]
            public static extern void GlWaitSync(GLsync* sync, uint flags, uint timeout);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetInteger64v")]
            public static extern void GlGetInteger64v(uint pname, int* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSynciv")]
            public static extern void GlGetSynciv(GLsync* sync, uint pname, int count, int* length, int* values);
            
        }
        public unsafe static partial class TessellationShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glPatchParameteri")]
            public static extern void GlPatchParameteri(uint pname, int value);
            
            [DllImport("opengl32.dll", EntryPoint = "glPatchParameterfv")]
            public static extern void GlPatchParameterfv(uint pname, float* values);
            
        }
        public unsafe static partial class TextureBarrier
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureBarrier")]
            public static extern void GlTextureBarrier();
            
        }
        public unsafe static partial class TextureBorderClamp
        {
        }
        public unsafe static partial class TextureBufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexBufferARB")]
            public static extern void GlTexBuffer(uint target, uint internalformat, uint buffer);
            
        }
        public unsafe static partial class TextureBufferObjectRgb32
        {
        }
        public unsafe static partial class TextureBufferRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexBufferRange")]
            public static extern void GlTexBufferRange(uint target, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
            
        }
        public unsafe static partial class TextureCompressionBptc
        {
        }
        public unsafe static partial class TextureCompressionRgtc
        {
        }
        public unsafe static partial class TextureCubeMapArray
        {
        }
        public unsafe static partial class TextureFilterAnisotropic
        {
        }
        public unsafe static partial class TextureFilterMinmax
        {
        }
        public unsafe static partial class TextureGather
        {
        }
        public unsafe static partial class TextureMirrorClampToEdge
        {
        }
        public unsafe static partial class TextureMirroredRepeat
        {
        }
        public unsafe static partial class TextureMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexImage2DMultisample")]
            public static extern void GlTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexImage3DMultisample")]
            public static extern void GlTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMultisamplefv")]
            public static extern void GlGetMultisamplefv(uint pname, uint index, float* val);
            
            [DllImport("opengl32.dll", EntryPoint = "glSampleMaski")]
            public static extern void GlSampleMaski(uint maskNumber, uint mask);
            
        }
        public unsafe static partial class TextureNonPowerOfTwo
        {
        }
        public unsafe static partial class TextureQueryLevels
        {
        }
        public unsafe static partial class TextureQueryLod
        {
        }
        public unsafe static partial class TextureRg
        {
        }
        public unsafe static partial class TextureRgb10A2ui
        {
        }
        public unsafe static partial class TextureStencil8
        {
        }
        public unsafe static partial class TextureStorage
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage1D")]
            public static extern void GlTexStorage1D(uint target, int levels, uint internalformat, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage2D")]
            public static extern void GlTexStorage2D(uint target, int levels, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage3D")]
            public static extern void GlTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);
            
        }
        public unsafe static partial class TextureStorageMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage2DMultisample")]
            public static extern void GlTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage3DMultisample")]
            public static extern void GlTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);
            
        }
        public unsafe static partial class TextureSwizzle
        {
        }
        public unsafe static partial class TextureView
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureView")]
            public static extern void GlTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
            
        }
        public unsafe static partial class TimerQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glQueryCounter")]
            public static extern void GlQueryCounter(uint id, uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjecti64v")]
            public static extern void GlGetQueryObjecti64v(uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectui64v")]
            public static extern void GlGetQueryObjectui64v(uint id, uint pname, uint* parameters);
            
        }
        public unsafe static partial class TransformFeedback2
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindTransformFeedback")]
            public static extern void GlBindTransformFeedback(uint target, uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteTransformFeedbacks")]
            public static extern void GlDeleteTransformFeedbacks(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenTransformFeedbacks")]
            public static extern void GlGenTransformFeedbacks(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsTransformFeedback")]
            public static extern byte GlIsTransformFeedback(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glPauseTransformFeedback")]
            public static extern void GlPauseTransformFeedback();
            
            [DllImport("opengl32.dll", EntryPoint = "glResumeTransformFeedback")]
            public static extern void GlResumeTransformFeedback();
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedback")]
            public static extern void GlDrawTransformFeedback(uint mode, uint id);
            
        }
        public unsafe static partial class TransformFeedback3
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackStream")]
            public static extern void GlDrawTransformFeedbackStream(uint mode, uint id, uint stream);
            
            [DllImport("opengl32.dll", EntryPoint = "glBeginQueryIndexed")]
            public static extern void GlBeginQueryIndexed(uint target, uint index, uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndQueryIndexed")]
            public static extern void GlEndQueryIndexed(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryIndexediv")]
            public static extern void GlGetQueryIndexediv(uint target, uint index, uint pname, int* parameters);
            
        }
        public unsafe static partial class TransformFeedbackInstanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackInstanced")]
            public static extern void GlDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
            public static extern void GlDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount);
            
        }
        public unsafe static partial class TransformFeedbackOverflowQuery
        {
        }
        public unsafe static partial class UniformBufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformIndices")]
            public static extern void GlGetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformsiv")]
            public static extern void GlGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformName")]
            public static extern void GlGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformBlockIndex")]
            public static extern uint GlGetUniformBlockIndex(uint program, char* uniformBlockName);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformBlockiv")]
            public static extern void GlGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveUniformBlockName")]
            public static extern void GlGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformBlockBinding")]
            public static extern void GlUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferRange")]
            public static extern void GlBindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferBase")]
            public static extern void GlBindBufferBase(uint target, uint index, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetIntegeri_v")]
            public static extern void GlGetIntegeri_v(uint target, uint index, int* data);
            
        }
        public unsafe static partial class VertexArrayBgra
        {
        }
        public unsafe static partial class VertexArrayObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindVertexArray")]
            public static extern void GlBindVertexArray(uint array);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteVertexArrays")]
            public static extern void GlDeleteVertexArrays(int n, uint* arrays);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenVertexArrays")]
            public static extern void GlGenVertexArrays(int n, uint* arrays);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsVertexArray")]
            public static extern byte GlIsVertexArray(uint array);
            
        }
        public unsafe static partial class VertexAttrib64bit
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1d")]
            public static extern void GlVertexAttribL1d(uint index, double x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2d")]
            public static extern void GlVertexAttribL2d(uint index, double x, double y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3d")]
            public static extern void GlVertexAttribL3d(uint index, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4d")]
            public static extern void GlVertexAttribL4d(uint index, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1dv")]
            public static extern void GlVertexAttribL1dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2dv")]
            public static extern void GlVertexAttribL2dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3dv")]
            public static extern void GlVertexAttribL3dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4dv")]
            public static extern void GlVertexAttribL4dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribLPointer")]
            public static extern void GlVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribLdv")]
            public static extern void GlGetVertexAttribLdv(uint index, uint pname, double* parameters);
            
        }
        public unsafe static partial class VertexAttribBinding
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindVertexBuffer")]
            public static extern void GlBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribFormat")]
            public static extern void GlVertexAttribFormat(uint attribindex, int size, uint type, byte normalized, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribIFormat")]
            public static extern void GlVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribLFormat")]
            public static extern void GlVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribBinding")]
            public static extern void GlVertexAttribBinding(uint attribindex, uint bindingindex);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexBindingDivisor")]
            public static extern void GlVertexBindingDivisor(uint bindingindex, uint divisor);
            
        }
        public unsafe static partial class VertexType10f11f11fRev
        {
        }
        public unsafe static partial class VertexType2101010Rev
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP1ui")]
            public static extern void GlVertexAttribP1ui(uint index, uint type, byte normalized, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP1uiv")]
            public static extern void GlVertexAttribP1uiv(uint index, uint type, byte normalized, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP2ui")]
            public static extern void GlVertexAttribP2ui(uint index, uint type, byte normalized, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP2uiv")]
            public static extern void GlVertexAttribP2uiv(uint index, uint type, byte normalized, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP3ui")]
            public static extern void GlVertexAttribP3ui(uint index, uint type, byte normalized, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP3uiv")]
            public static extern void GlVertexAttribP3uiv(uint index, uint type, byte normalized, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP4ui")]
            public static extern void GlVertexAttribP4ui(uint index, uint type, byte normalized, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribP4uiv")]
            public static extern void GlVertexAttribP4uiv(uint index, uint type, byte normalized, uint* value);
            
        }
        public unsafe static partial class ViewportArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glViewportArrayv")]
            public static extern void GlViewportArrayv(uint first, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedf")]
            public static extern void GlViewportIndexedf(uint index, float x, float y, float w, float h);
            
            [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedfv")]
            public static extern void GlViewportIndexedfv(uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorArrayv")]
            public static extern void GlScissorArrayv(uint first, int count, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorIndexed")]
            public static extern void GlScissorIndexed(uint index, int left, int bottom, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorIndexedv")]
            public static extern void GlScissorIndexedv(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeArrayv")]
            public static extern void GlDepthRangeArrayv(uint first, int count, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeIndexed")]
            public static extern void GlDepthRangeIndexed(uint index, double n, double f);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFloati_v")]
            public static extern void GlGetFloati_v(uint target, uint index, float* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDoublei_v")]
            public static extern void GlGetDoublei_v(uint target, uint index, double* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeArraydvNV")]
            public static extern void GlDepthRangeArraydvNV(uint first, int count, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeIndexeddNV")]
            public static extern void GlDepthRangeIndexeddNV(uint index, double n, double f);
            
        }
    }
}
