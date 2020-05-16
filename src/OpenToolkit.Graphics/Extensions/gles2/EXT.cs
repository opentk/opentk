using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class EXT
    {
        public unsafe static partial class EglImageArray
        {
        }
        public unsafe static partial class EglImageStorage
        {
            [DllImport("opengl32.dll", EntryPoint = "glEGLImageTargetTexStorageEXT")]
            public static extern void GlEGLImageTargetTexStorage(uint target, void* image, int* attrib_list);
            
            [DllImport("opengl32.dll", EntryPoint = "glEGLImageTargetTextureStorageEXT")]
            public static extern void GlEGLImageTargetTextureStorage(uint texture, void* image, int* attrib_list);
            
        }
        public unsafe static partial class YuvTarget
        {
        }
        public unsafe static partial class BaseInstance
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedBaseInstanceEXT")]
            public static extern void GlDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
            public static extern void GlDrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
            public static extern void GlDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);
            
        }
        public unsafe static partial class BlendFuncExtended
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindFragDataLocationIndexedEXT")]
            public static extern void GlBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindFragDataLocationEXT")]
            public static extern void GlBindFragDataLocation(uint program, uint color, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourceLocationIndexEXT")]
            public static extern int GlGetProgramResourceLocationIndex(uint program, uint programInterface, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFragDataIndexEXT")]
            public static extern int GlGetFragDataIndex(uint program, char* name);
            
        }
        public unsafe static partial class BlendMinmax
        {
        }
        public unsafe static partial class BufferStorage
        {
            [DllImport("opengl32.dll", EntryPoint = "glBufferStorageEXT")]
            public static extern void GlBufferStorage(uint target, IntPtr size, void* data, uint flags);
            
        }
        public unsafe static partial class ClearTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glClearTexImageEXT")]
            public static extern void GlClearTexImage(uint texture, int level, uint format, uint type, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearTexSubImageEXT")]
            public static extern void GlClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);
            
        }
        public unsafe static partial class ClipControl
        {
            [DllImport("opengl32.dll", EntryPoint = "glClipControlEXT")]
            public static extern void GlClipControl(uint origin, uint depth);
            
        }
        public unsafe static partial class ClipCullDistance
        {
        }
        public unsafe static partial class ColorBufferFloat
        {
        }
        public unsafe static partial class ColorBufferHalfFloat
        {
        }
        public unsafe static partial class ConservativeDepth
        {
        }
        public unsafe static partial class CopyImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyImageSubDataEXT")]
            public static extern void GlCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
            
        }
        public unsafe static partial class DebugLabel
        {
            [DllImport("opengl32.dll", EntryPoint = "glLabelObjectEXT")]
            public static extern void GlLabelObject(uint type, uint obj, int length, char* label);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetObjectLabelEXT")]
            public static extern void GlGetObjectLabel(uint type, uint obj, int bufSize, int* length, char* label);
            
        }
        public unsafe static partial class DebugMarker
        {
            [DllImport("opengl32.dll", EntryPoint = "glInsertEventMarkerEXT")]
            public static extern void GlInsertEventMarker(int length, char* marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glPushGroupMarkerEXT")]
            public static extern void GlPushGroupMarker(int length, char* marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glPopGroupMarkerEXT")]
            public static extern void GlPopGroupMarker();
            
        }
        public unsafe static partial class DepthClamp
        {
        }
        public unsafe static partial class DiscardFramebuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glDiscardFramebufferEXT")]
            public static extern void GlDiscardFramebuffer(uint target, int numAttachments, uint* attachments);
            
        }
        public unsafe static partial class DisjointTimerQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenQueriesEXT")]
            public static extern void GlGenQueries(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteQueriesEXT")]
            public static extern void GlDeleteQueries(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsQueryEXT")]
            public static extern byte GlIsQuery(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glBeginQueryEXT")]
            public static extern void GlBeginQuery(uint target, uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndQueryEXT")]
            public static extern void GlEndQuery(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glQueryCounterEXT")]
            public static extern void GlQueryCounter(uint id, uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryivEXT")]
            public static extern void GlGetQueryiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectivEXT")]
            public static extern void GlGetQueryObjectiv(uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectuivEXT")]
            public static extern void GlGetQueryObjectuiv(uint id, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjecti64vEXT")]
            public static extern void GlGetQueryObjecti64v(uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectui64vEXT")]
            public static extern void GlGetQueryObjectui64v(uint id, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetInteger64vEXT")]
            public static extern void GlGetInteger64v(uint pname, int* data);
            
        }
        public unsafe static partial class DrawBuffers
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawBuffersEXT")]
            public static extern void GlDrawBuffers(int n, uint* bufs);
            
        }
        public unsafe static partial class DrawBuffersIndexed
        {
            [DllImport("opengl32.dll", EntryPoint = "glEnableiEXT")]
            public static extern void GlEnablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableiEXT")]
            public static extern void GlDisablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationiEXT")]
            public static extern void GlBlendEquationi(uint buf, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparateiEXT")]
            public static extern void GlBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendFunciEXT")]
            public static extern void GlBlendFunci(uint buf, uint src, uint dst);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparateiEXT")]
            public static extern void GlBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorMaskiEXT")]
            public static extern void GlColorMaski(uint index, byte r, byte g, byte b, byte a);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsEnablediEXT")]
            public static extern byte GlIsEnabledi(uint target, uint index);
            
        }
        public unsafe static partial class DrawElementsBaseVertex
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsBaseVertexEXT")]
            public static extern void GlDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
            public static extern void GlDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
            public static extern void GlDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
            public static extern void GlMultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int primcount, int* basevertex);
            
        }
        public unsafe static partial class DrawInstanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedEXT")]
            public static extern void GlDrawArraysInstanced(uint mode, int start, int count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedEXT")]
            public static extern void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int primcount);
            
        }
        public unsafe static partial class DrawTransformFeedback
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackEXT")]
            public static extern void GlDrawTransformFeedback(uint mode, uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackInstancedEXT")]
            public static extern void GlDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);
            
        }
        public unsafe static partial class ExternalBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glBufferStorageExternalEXT")]
            public static extern void GlBufferStorageExternal(uint target, IntPtr offset, IntPtr size, void* clientBuffer, uint flags);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferStorageExternalEXT")]
            public static extern void GlNamedBufferStorageExternal(uint buffer, IntPtr offset, IntPtr size, void* clientBuffer, uint flags);
            
        }
        public unsafe static partial class FloatBlend
        {
        }
        public unsafe static partial class GeometryPointSize
        {
        }
        public unsafe static partial class GeometryShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureEXT")]
            public static extern void GlFramebufferTexture(uint target, uint attachment, uint texture, int level);
            
        }
        public unsafe static partial class GpuShader5
        {
        }
        public unsafe static partial class InstancedArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedEXT")]
            public static extern void GlDrawArraysInstanced(uint mode, int start, int count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedEXT")]
            public static extern void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribDivisorEXT")]
            public static extern void GlVertexAttribDivisor(uint index, uint divisor);
            
        }
        public unsafe static partial class MapBufferRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glMapBufferRangeEXT")]
            public static extern void* GlMapBufferRange(uint target, IntPtr offset, IntPtr length, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushMappedBufferRangeEXT")]
            public static extern void GlFlushMappedBufferRange(uint target, IntPtr offset, IntPtr length);
            
        }
        public unsafe static partial class MemoryObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytevEXT")]
            public static extern void GlGetUnsignedBytev(uint pname, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytei_vEXT")]
            public static extern void GlGetUnsignedBytei_v(uint target, uint index, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteMemoryObjectsEXT")]
            public static extern void GlDeleteMemoryObjects(int n, uint* memoryObjects);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsMemoryObjectEXT")]
            public static extern byte GlIsMemoryObject(uint memoryObject);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateMemoryObjectsEXT")]
            public static extern void GlCreateMemoryObjects(int n, uint* memoryObjects);
            
            [DllImport("opengl32.dll", EntryPoint = "glMemoryObjectParameterivEXT")]
            public static extern void GlMemoryObjectParameteriv(uint memoryObject, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMemoryObjectParameterivEXT")]
            public static extern void GlGetMemoryObjectParameteriv(uint memoryObject, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem2DEXT")]
            public static extern void GlTexStorageMem2D(uint target, int levels, uint internalFormat, int width, int height, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem2DMultisampleEXT")]
            public static extern void GlTexStorageMem2DMultisample(uint target, int samples, uint internalFormat, int width, int height, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem3DEXT")]
            public static extern void GlTexStorageMem3D(uint target, int levels, uint internalFormat, int width, int height, int depth, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageMem3DMultisampleEXT")]
            public static extern void GlTexStorageMem3DMultisample(uint target, int samples, uint internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glBufferStorageMemEXT")]
            public static extern void GlBufferStorageMem(uint target, IntPtr size, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem2DEXT")]
            public static extern void GlTextureStorageMem2D(uint texture, int levels, uint internalFormat, int width, int height, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem2DMultisampleEXT")]
            public static extern void GlTextureStorageMem2DMultisample(uint texture, int samples, uint internalFormat, int width, int height, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem3DEXT")]
            public static extern void GlTextureStorageMem3D(uint texture, int levels, uint internalFormat, int width, int height, int depth, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageMem3DMultisampleEXT")]
            public static extern void GlTextureStorageMem3DMultisample(uint texture, int samples, uint internalFormat, int width, int height, int depth, byte fixedSampleLocations, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferStorageMemEXT")]
            public static extern void GlNamedBufferStorageMem(uint buffer, IntPtr size, uint memory, uint offset);
            
        }
        public unsafe static partial class MemoryObjectFd
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportMemoryFdEXT")]
            public static extern void GlImportMemoryFd(uint memory, uint size, uint handleType, int fd);
            
        }
        public unsafe static partial class MemoryObjectWin32
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportMemoryWin32HandleEXT")]
            public static extern void GlImportMemoryWin32Handle(uint memory, uint size, uint handleType, void* handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glImportMemoryWin32NameEXT")]
            public static extern void GlImportMemoryWin32Name(uint memory, uint size, uint handleType, void* name);
            
        }
        public unsafe static partial class MultiDrawArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysEXT")]
            public static extern void GlMultiDrawArrays(uint mode, int* first, int* count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern void GlMultiDrawElements(uint mode, int* count, uint type, void** indices, int primcount);
            
        }
        public unsafe static partial class MultiDrawIndirect
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysIndirectEXT")]
            public static extern void GlMultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsIndirectEXT")]
            public static extern void GlMultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride);
            
        }
        public unsafe static partial class MultisampledCompatibility
        {
        }
        public unsafe static partial class MultisampledRenderToTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleEXT")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            public static extern void GlFramebufferTexture2DMultisample(uint target, uint attachment, uint textarget, uint texture, int level, int samples);
            
        }
        public unsafe static partial class MultiviewDrawBuffers
        {
            [DllImport("opengl32.dll", EntryPoint = "glReadBufferIndexedEXT")]
            public static extern void GlReadBufferIndexed(uint src, int index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawBuffersIndexedEXT")]
            public static extern void GlDrawBuffersIndexed(int n, uint* location, int* indices);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetIntegeri_vEXT")]
            public static extern void GlGetIntegeri_v(uint target, uint index, int* data);
            
        }
        public unsafe static partial class MultiviewTessellationGeometryShader
        {
        }
        public unsafe static partial class MultiviewTextureMultisample
        {
        }
        public unsafe static partial class MultiviewTimerQuery
        {
        }
        public unsafe static partial class OcclusionQueryBoolean
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenQueriesEXT")]
            public static extern void GlGenQueries(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteQueriesEXT")]
            public static extern void GlDeleteQueries(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsQueryEXT")]
            public static extern byte GlIsQuery(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glBeginQueryEXT")]
            public static extern void GlBeginQuery(uint target, uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndQueryEXT")]
            public static extern void GlEndQuery(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryivEXT")]
            public static extern void GlGetQueryiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetQueryObjectuivEXT")]
            public static extern void GlGetQueryObjectuiv(uint id, uint pname, uint* parameters);
            
        }
        public unsafe static partial class PolygonOffsetClamp
        {
            [DllImport("opengl32.dll", EntryPoint = "glPolygonOffsetClampEXT")]
            public static extern void GlPolygonOffsetClamp(float factor, float units, float clamp);
            
        }
        public unsafe static partial class PostDepthCoverage
        {
        }
        public unsafe static partial class PrimitiveBoundingBox
        {
            [DllImport("opengl32.dll", EntryPoint = "glPrimitiveBoundingBoxEXT")]
            public static extern void GlPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
            
        }
        public unsafe static partial class ProtectedTextures
        {
        }
        public unsafe static partial class PvrtcSrgb
        {
        }
        public unsafe static partial class RasterMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glRasterSamplesEXT")]
            public static extern void GlRasterSamples(uint samples, byte fixedsamplelocations);
            
        }
        public unsafe static partial class ReadFormatBgra
        {
        }
        public unsafe static partial class RenderSnorm
        {
        }
        public unsafe static partial class Robustness
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetGraphicsResetStatusEXT")]
            public static extern uint GlGetGraphicsResetStatus();
            
            [DllImport("opengl32.dll", EntryPoint = "glReadnPixelsEXT")]
            public static extern void GlReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformfvEXT")]
            public static extern void GlGetnUniformfv(uint program, int location, int bufSize, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetnUniformivEXT")]
            public static extern void GlGetnUniformiv(uint program, int location, int bufSize, int* parameters);
            
        }
        public unsafe static partial class Semaphore
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytevEXT")]
            public static extern void GlGetUnsignedBytev(uint pname, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUnsignedBytei_vEXT")]
            public static extern void GlGetUnsignedBytei_v(uint target, uint index, byte* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenSemaphoresEXT")]
            public static extern void GlGenSemaphores(int n, uint* semaphores);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteSemaphoresEXT")]
            public static extern void GlDeleteSemaphores(int n, uint* semaphores);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsSemaphoreEXT")]
            public static extern byte GlIsSemaphore(uint semaphore);
            
            [DllImport("opengl32.dll", EntryPoint = "glSemaphoreParameterui64vEXT")]
            public static extern void GlSemaphoreParameterui64v(uint semaphore, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSemaphoreParameterui64vEXT")]
            public static extern void GlGetSemaphoreParameterui64v(uint semaphore, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glWaitSemaphoreEXT")]
            public static extern void GlWaitSemaphore(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* srcLayouts);
            
            [DllImport("opengl32.dll", EntryPoint = "glSignalSemaphoreEXT")]
            public static extern void GlSignalSemaphore(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* dstLayouts);
            
        }
        public unsafe static partial class SemaphoreFd
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportSemaphoreFdEXT")]
            public static extern void GlImportSemaphoreFd(uint semaphore, uint handleType, int fd);
            
        }
        public unsafe static partial class SemaphoreWin32
        {
            [DllImport("opengl32.dll", EntryPoint = "glImportSemaphoreWin32HandleEXT")]
            public static extern void GlImportSemaphoreWin32Handle(uint semaphore, uint handleType, void* handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glImportSemaphoreWin32NameEXT")]
            public static extern void GlImportSemaphoreWin32Name(uint semaphore, uint handleType, void* name);
            
        }
        public unsafe static partial class Srgb
        {
        }
        public unsafe static partial class SrgbWriteControl
        {
        }
        public unsafe static partial class SeparateShaderObjects
        {
            [DllImport("opengl32.dll", EntryPoint = "glActiveShaderProgramEXT")]
            public static extern void GlActiveShaderProgram(uint pipeline, uint program);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindProgramPipelineEXT")]
            public static extern void GlBindProgramPipeline(uint pipeline);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateShaderProgramvEXT")]
            public static extern uint GlCreateShaderProgramv(uint type, int count, char** strings);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteProgramPipelinesEXT")]
            public static extern void GlDeleteProgramPipelines(int n, uint* pipelines);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenProgramPipelinesEXT")]
            public static extern void GlGenProgramPipelines(int n, uint* pipelines);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineInfoLogEXT")]
            public static extern void GlGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramPipelineivEXT")]
            public static extern void GlGetProgramPipelineiv(uint pipeline, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsProgramPipelineEXT")]
            public static extern byte GlIsProgramPipeline(uint pipeline);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameteriEXT")]
            public static extern void GlProgramParameteri(uint program, uint pname, int value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1fEXT")]
            public static extern void GlProgramUniform1f(uint program, int location, float v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1fvEXT")]
            public static extern void GlProgramUniform1fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1iEXT")]
            public static extern void GlProgramUniform1i(uint program, int location, int v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ivEXT")]
            public static extern void GlProgramUniform1iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2fEXT")]
            public static extern void GlProgramUniform2f(uint program, int location, float v0, float v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2fvEXT")]
            public static extern void GlProgramUniform2fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2iEXT")]
            public static extern void GlProgramUniform2i(uint program, int location, int v0, int v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ivEXT")]
            public static extern void GlProgramUniform2iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3fEXT")]
            public static extern void GlProgramUniform3f(uint program, int location, float v0, float v1, float v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3fvEXT")]
            public static extern void GlProgramUniform3fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3iEXT")]
            public static extern void GlProgramUniform3i(uint program, int location, int v0, int v1, int v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ivEXT")]
            public static extern void GlProgramUniform3iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4fEXT")]
            public static extern void GlProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4fvEXT")]
            public static extern void GlProgramUniform4fv(uint program, int location, int count, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4iEXT")]
            public static extern void GlProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ivEXT")]
            public static extern void GlProgramUniform4iv(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2fvEXT")]
            public static extern void GlProgramUniformMatrix2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3fvEXT")]
            public static extern void GlProgramUniformMatrix3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4fvEXT")]
            public static extern void GlProgramUniformMatrix4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUseProgramStagesEXT")]
            public static extern void GlUseProgramStages(uint pipeline, uint stages, uint program);
            
            [DllImport("opengl32.dll", EntryPoint = "glValidateProgramPipelineEXT")]
            public static extern void GlValidateProgramPipeline(uint pipeline);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1uiEXT")]
            public static extern void GlProgramUniform1ui(uint program, int location, uint v0);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2uiEXT")]
            public static extern void GlProgramUniform2ui(uint program, int location, uint v0, uint v1);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3uiEXT")]
            public static extern void GlProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4uiEXT")]
            public static extern void GlProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1uivEXT")]
            public static extern void GlProgramUniform1uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2uivEXT")]
            public static extern void GlProgramUniform2uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3uivEXT")]
            public static extern void GlProgramUniform3uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4uivEXT")]
            public static extern void GlProgramUniform4uiv(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
            public static extern void GlProgramUniformMatrix2x3fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
            public static extern void GlProgramUniformMatrix3x2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
            public static extern void GlProgramUniformMatrix2x4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
            public static extern void GlProgramUniformMatrix4x2fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
            public static extern void GlProgramUniformMatrix3x4fv(uint program, int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
            public static extern void GlProgramUniformMatrix4x3fv(uint program, int location, int count, byte transpose, float* value);
            
        }
        public unsafe static partial class ShaderFramebufferFetch
        {
        }
        public unsafe static partial class ShaderFramebufferFetchNonCoherent
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferFetchBarrierEXT")]
            public static extern void GlFramebufferFetchBarrier();
            
        }
        public unsafe static partial class ShaderGroupVote
        {
        }
        public unsafe static partial class ShaderImplicitConversions
        {
        }
        public unsafe static partial class ShaderIntegerMix
        {
        }
        public unsafe static partial class ShaderIoBlocks
        {
        }
        public unsafe static partial class ShaderNonConstantGlobalInitializers
        {
        }
        public unsafe static partial class ShaderPixelLocalStorage
        {
        }
        public unsafe static partial class ShaderPixelLocalStorage2
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferPixelLocalStorageSizeEXT")]
            public static extern void GlFramebufferPixelLocalStorageSize(uint target, int size);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferPixelLocalStorageSizeEXT")]
            public static extern int GlGetFramebufferPixelLocalStorageSize(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearPixelLocalStorageuiEXT")]
            public static extern void GlClearPixelLocalStorageui(int offset, int n, uint* values);
            
        }
        public unsafe static partial class ShaderTextureLod
        {
        }
        public unsafe static partial class ShadowSamplers
        {
        }
        public unsafe static partial class SparseTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexPageCommitmentEXT")]
            public static extern void GlTexPageCommitment(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, byte commit);
            
        }
        public unsafe static partial class SparseTexture2
        {
        }
        public unsafe static partial class TessellationPointSize
        {
        }
        public unsafe static partial class TessellationShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glPatchParameteriEXT")]
            public static extern void GlPatchParameteri(uint pname, int value);
            
        }
        public unsafe static partial class TextureBorderClamp
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterIivEXT")]
            public static extern void GlTexParameterIiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexParameterIuivEXT")]
            public static extern void GlTexParameterIuiv(uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIivEXT")]
            public static extern void GlGetTexParameterIiv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTexParameterIuivEXT")]
            public static extern void GlGetTexParameterIuiv(uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIivEXT")]
            public static extern void GlSamplerParameterIiv(uint sampler, uint pname, int* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSamplerParameterIuivEXT")]
            public static extern void GlSamplerParameterIuiv(uint sampler, uint pname, uint* param);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIivEXT")]
            public static extern void GlGetSamplerParameterIiv(uint sampler, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetSamplerParameterIuivEXT")]
            public static extern void GlGetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters);
            
        }
        public unsafe static partial class TextureBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexBufferEXT")]
            public static extern void GlTexBuffer(uint target, uint internalformat, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexBufferRangeEXT")]
            public static extern void GlTexBufferRange(uint target, uint internalformat, uint buffer, IntPtr offset, IntPtr size);
            
        }
        public unsafe static partial class TextureCompressionAstcDecodeMode
        {
        }
        public unsafe static partial class TextureCompressionBptc
        {
        }
        public unsafe static partial class TextureCompressionDxt1
        {
        }
        public unsafe static partial class TextureCompressionRgtc
        {
        }
        public unsafe static partial class TextureCompressionS3tc
        {
        }
        public unsafe static partial class TextureCompressionS3tcSrgb
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
        public unsafe static partial class TextureFormatBgra8888
        {
        }
        public unsafe static partial class TextureFormatSrgbOverride
        {
        }
        public unsafe static partial class TextureMirrorClampToEdge
        {
        }
        public unsafe static partial class TextureNorm16
        {
        }
        public unsafe static partial class TextureQueryLod
        {
        }
        public unsafe static partial class TextureRg
        {
        }
        public unsafe static partial class TextureSrgbR8
        {
        }
        public unsafe static partial class TextureSrgbRg8
        {
        }
        public unsafe static partial class TextureSrgbDecode
        {
        }
        public unsafe static partial class TextureStorage
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage1DEXT")]
            public static extern void GlTexStorage1D(uint target, int levels, uint internalformat, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage2DEXT")]
            public static extern void GlTexStorage2D(uint target, int levels, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexStorage3DEXT")]
            public static extern void GlTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage1DEXT")]
            public static extern void GlTextureStorage1D(uint texture, uint target, int levels, uint internalformat, int width);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage2DEXT")]
            public static extern void GlTextureStorage2D(uint texture, uint target, int levels, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorage3DEXT")]
            public static extern void GlTextureStorage3D(uint texture, uint target, int levels, uint internalformat, int width, int height, int depth);
            
        }
        public unsafe static partial class TextureType2101010Rev
        {
        }
        public unsafe static partial class TextureView
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureViewEXT")]
            public static extern void GlTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
            
        }
        public unsafe static partial class UnpackSubimage
        {
        }
        public unsafe static partial class Win32KeyedMutex
        {
            [DllImport("opengl32.dll", EntryPoint = "glAcquireKeyedMutexWin32EXT")]
            public static extern byte GlAcquireKeyedMutexWin32(uint memory, uint key, uint timeout);
            
            [DllImport("opengl32.dll", EntryPoint = "glReleaseKeyedMutexWin32EXT")]
            public static extern byte GlReleaseKeyedMutexWin32(uint memory, uint key);
            
        }
        public unsafe static partial class WindowRectangles
        {
            [DllImport("opengl32.dll", EntryPoint = "glWindowRectanglesEXT")]
            public static extern void GlWindowRectangles(uint mode, int count, int* box);
            
        }
        public unsafe static partial class TextureShadowLod
        {
        }
    }
}
