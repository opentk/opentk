using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class AMD
    {
        public unsafe static partial class BlendMinmaxFactor
        {
        }
        public unsafe static partial class ConservativeDepth
        {
        }
        public unsafe static partial class DebugOutput
        {
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageEnableAMD")]
            public static extern void GlDebugMessageEnable(uint category, uint severity, int count, uint* ids, byte enabled);
            
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageInsertAMD")]
            public static extern void GlDebugMessageInsert(uint category, uint severity, uint id, int length, char* buf);
            
            [DllImport("opengl32.dll", EntryPoint = "glDebugMessageCallbackAMD")]
            public static extern void GlDebugMessageCallback(GLDEBUGPROCAMD callback, void* userParam);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetDebugMessageLogAMD")]
            public static extern uint GlGetDebugMessageLog(uint count, int bufSize, uint* categories, uint* severities, uint* ids, int* lengths, char* message);
            
        }
        public unsafe static partial class DepthClampSeparate
        {
        }
        public unsafe static partial class DrawBuffersBlend
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncIndexedAMD")]
            public static extern void GlBlendFuncIndexed(uint buf, uint src, uint dst);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendFuncSeparateIndexedAMD")]
            public static extern void GlBlendFuncSeparateIndexed(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationIndexedAMD")]
            public static extern void GlBlendEquationIndexed(uint buf, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendEquationSeparateIndexedAMD")]
            public static extern void GlBlendEquationSeparateIndexed(uint buf, uint modeRGB, uint modeAlpha);
            
        }
        public unsafe static partial class FramebufferMultisampleAdvanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD")]
            public static extern void GlRenderbufferStorageMultisampleAdvanced(uint target, int samples, int storageSamples, uint internalformat, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD")]
            public static extern void GlNamedRenderbufferStorageMultisampleAdvanced(uint renderbuffer, int samples, int storageSamples, uint internalformat, int width, int height);
            
        }
        public unsafe static partial class FramebufferSamplePositions
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferSamplePositionsfvAMD")]
            public static extern void GlFramebufferSamplePositionsfv(uint target, uint numsamples, uint pixelindex, float* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferSamplePositionsfvAMD")]
            public static extern void GlNamedFramebufferSamplePositionsfv(uint framebuffer, uint numsamples, uint pixelindex, float* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFramebufferParameterfvAMD")]
            public static extern void GlGetFramebufferParameterfv(uint target, uint pname, uint numsamples, uint pixelindex, int size, float* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedFramebufferParameterfvAMD")]
            public static extern void GlGetNamedFramebufferParameterfv(uint framebuffer, uint pname, uint numsamples, uint pixelindex, int size, float* values);
            
        }
        public unsafe static partial class GcnShader
        {
        }
        public unsafe static partial class GpuShaderHalfFloat
        {
        }
        public unsafe static partial class GpuShaderInt16
        {
        }
        public unsafe static partial class GpuShaderInt64
        {
            [DllImport("opengl32.dll", EntryPoint = "glUniform1i64NV")]
            public static extern void GlUniform1i64NV(int location, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2i64NV")]
            public static extern void GlUniform2i64NV(int location, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3i64NV")]
            public static extern void GlUniform3i64NV(int location, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4i64NV")]
            public static extern void GlUniform4i64NV(int location, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1i64vNV")]
            public static extern void GlUniform1i64vNV(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2i64vNV")]
            public static extern void GlUniform2i64vNV(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3i64vNV")]
            public static extern void GlUniform3i64vNV(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4i64vNV")]
            public static extern void GlUniform4i64vNV(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1ui64NV")]
            public static extern void GlUniform1ui64NV(int location, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2ui64NV")]
            public static extern void GlUniform2ui64NV(int location, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3ui64NV")]
            public static extern void GlUniform3ui64NV(int location, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4ui64NV")]
            public static extern void GlUniform4ui64NV(int location, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1ui64vNV")]
            public static extern void GlUniform1ui64vNV(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2ui64vNV")]
            public static extern void GlUniform2ui64vNV(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3ui64vNV")]
            public static extern void GlUniform3ui64vNV(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4ui64vNV")]
            public static extern void GlUniform4ui64vNV(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformi64vNV")]
            public static extern void GlGetUniformi64vNV(uint program, int location, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformui64vNV")]
            public static extern void GlGetUniformui64vNV(uint program, int location, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i64NV")]
            public static extern void GlProgramUniform1i64NV(uint program, int location, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i64NV")]
            public static extern void GlProgramUniform2i64NV(uint program, int location, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i64NV")]
            public static extern void GlProgramUniform3i64NV(uint program, int location, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i64NV")]
            public static extern void GlProgramUniform4i64NV(uint program, int location, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i64vNV")]
            public static extern void GlProgramUniform1i64vNV(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i64vNV")]
            public static extern void GlProgramUniform2i64vNV(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i64vNV")]
            public static extern void GlProgramUniform3i64vNV(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i64vNV")]
            public static extern void GlProgramUniform4i64vNV(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui64NV")]
            public static extern void GlProgramUniform1ui64NV(uint program, int location, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui64NV")]
            public static extern void GlProgramUniform2ui64NV(uint program, int location, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui64NV")]
            public static extern void GlProgramUniform3ui64NV(uint program, int location, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui64NV")]
            public static extern void GlProgramUniform4ui64NV(uint program, int location, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui64vNV")]
            public static extern void GlProgramUniform1ui64vNV(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui64vNV")]
            public static extern void GlProgramUniform2ui64vNV(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui64vNV")]
            public static extern void GlProgramUniform3ui64vNV(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui64vNV")]
            public static extern void GlProgramUniform4ui64vNV(uint program, int location, int count, uint* value);
            
        }
        public unsafe static partial class InterleavedElements
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribParameteriAMD")]
            public static extern void GlVertexAttribParameteri(uint index, uint pname, int param);
            
        }
        public unsafe static partial class MultiDrawIndirect
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysIndirectAMD")]
            public static extern void GlMultiDrawArraysIndirect(uint mode, void* indirect, int primcount, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsIndirectAMD")]
            public static extern void GlMultiDrawElementsIndirect(uint mode, uint type, void* indirect, int primcount, int stride);
            
        }
        public unsafe static partial class NameGenDelete
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenNamesAMD")]
            public static extern void GlGenNames(uint identifier, uint num, uint* names);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteNamesAMD")]
            public static extern void GlDeleteNames(uint identifier, uint num, uint* names);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsNameAMD")]
            public static extern byte GlIsName(uint identifier, uint name);
            
        }
        public unsafe static partial class OcclusionQueryEvent
        {
            [DllImport("opengl32.dll", EntryPoint = "glQueryObjectParameteruiAMD")]
            public static extern void GlQueryObjectParameterui(uint target, uint id, uint pname, uint param);
            
        }
        public unsafe static partial class PerformanceMonitor
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorGroupsAMD")]
            public static extern void GlGetPerfMonitorGroups(int* numGroups, int groupsSize, uint* groups);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCountersAMD")]
            public static extern void GlGetPerfMonitorCounters(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorGroupStringAMD")]
            public static extern void GlGetPerfMonitorGroupString(uint group, int bufSize, int* length, char* groupString);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCounterStringAMD")]
            public static extern void GlGetPerfMonitorCounterString(uint group, uint counter, int bufSize, int* length, char* counterString);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCounterInfoAMD")]
            public static extern void GlGetPerfMonitorCounterInfo(uint group, uint counter, uint pname, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenPerfMonitorsAMD")]
            public static extern void GlGenPerfMonitors(int n, uint* monitors);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeletePerfMonitorsAMD")]
            public static extern void GlDeletePerfMonitors(int n, uint* monitors);
            
            [DllImport("opengl32.dll", EntryPoint = "glSelectPerfMonitorCountersAMD")]
            public static extern void GlSelectPerfMonitorCounters(uint monitor, byte enable, uint group, int numCounters, uint* counterList);
            
            [DllImport("opengl32.dll", EntryPoint = "glBeginPerfMonitorAMD")]
            public static extern void GlBeginPerfMonitor(uint monitor);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndPerfMonitorAMD")]
            public static extern void GlEndPerfMonitor(uint monitor);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPerfMonitorCounterDataAMD")]
            public static extern void GlGetPerfMonitorCounterData(uint monitor, uint pname, int dataSize, uint* data, int* bytesWritten);
            
        }
        public unsafe static partial class PinnedMemory
        {
        }
        public unsafe static partial class QueryBufferObject
        {
        }
        public unsafe static partial class SamplePositions
        {
            [DllImport("opengl32.dll", EntryPoint = "glSetMultisamplefvAMD")]
            public static extern void GlSetMultisamplefv(uint pname, uint index, float* val);
            
        }
        public unsafe static partial class SeamlessCubemapPerTexture
        {
        }
        public unsafe static partial class ShaderAtomicCounterOps
        {
        }
        public unsafe static partial class ShaderBallot
        {
        }
        public unsafe static partial class ShaderGpuShaderHalfFloatFetch
        {
        }
        public unsafe static partial class ShaderImageLoadStoreLod
        {
        }
        public unsafe static partial class ShaderStencilExport
        {
        }
        public unsafe static partial class ShaderTrinaryMinmax
        {
        }
        public unsafe static partial class ShaderExplicitVertexParameter
        {
        }
        public unsafe static partial class SparseTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexStorageSparseAMD")]
            public static extern void GlTexStorageSparse(uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureStorageSparseAMD")]
            public static extern void GlTextureStorageSparse(uint texture, uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags);
            
        }
        public unsafe static partial class StencilOperationExtended
        {
            [DllImport("opengl32.dll", EntryPoint = "glStencilOpValueAMD")]
            public static extern void GlStencilOpValue(uint face, uint value);
            
        }
        public unsafe static partial class TextureGatherBiasLod
        {
        }
        public unsafe static partial class TextureTexture4
        {
        }
        public unsafe static partial class TransformFeedback3LinesTriangles
        {
        }
        public unsafe static partial class TransformFeedback4
        {
        }
        public unsafe static partial class VertexShaderLayer
        {
        }
        public unsafe static partial class VertexShaderTessellator
        {
            [DllImport("opengl32.dll", EntryPoint = "glTessellationFactorAMD")]
            public static extern void GlTessellationFactor(float factor);
            
            [DllImport("opengl32.dll", EntryPoint = "glTessellationModeAMD")]
            public static extern void GlTessellationMode(uint mode);
            
        }
        public unsafe static partial class VertexShaderViewportIndex
        {
        }
    }
}
