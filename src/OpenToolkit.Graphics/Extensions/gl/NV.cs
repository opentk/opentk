using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class NV
    {
        public unsafe static partial class AlphaToCoverageDitherControl
        {
            [DllImport("opengl32.dll", EntryPoint = "glAlphaToCoverageDitherControlNV")]
            public static extern void GlAlphaToCoverageDitherControl(uint mode);
            
        }
        public unsafe static partial class BindlessMultiDrawIndirect
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysIndirectBindlessNV")]
            public static extern void GlMultiDrawArraysIndirectBindless(uint mode, void* indirect, int drawCount, int stride, int vertexBufferCount);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsIndirectBindlessNV")]
            public static extern void GlMultiDrawElementsIndirectBindless(uint mode, uint type, void* indirect, int drawCount, int stride, int vertexBufferCount);
            
        }
        public unsafe static partial class BindlessMultiDrawIndirectCount
        {
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawArraysIndirectBindlessCountNV")]
            public static extern void GlMultiDrawArraysIndirectBindlessCount(uint mode, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawElementsIndirectBindlessCountNV")]
            public static extern void GlMultiDrawElementsIndirectBindlessCount(uint mode, uint type, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);
            
        }
        public unsafe static partial class BindlessTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureHandleNV")]
            public static extern uint GlGetTextureHandle(uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTextureSamplerHandleNV")]
            public static extern uint GlGetTextureSamplerHandle(uint texture, uint sampler);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeTextureHandleResidentNV")]
            public static extern void GlMakeTextureHandleResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeTextureHandleNonResidentNV")]
            public static extern void GlMakeTextureHandleNonResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetImageHandleNV")]
            public static extern uint GlGetImageHandle(uint texture, int level, byte layered, int layer, uint format);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeImageHandleResidentNV")]
            public static extern void GlMakeImageHandleResident(uint handle, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeImageHandleNonResidentNV")]
            public static extern void GlMakeImageHandleNonResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformHandleui64NV")]
            public static extern void GlUniformHandleui64(int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformHandleui64vNV")]
            public static extern void GlUniformHandleui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformHandleui64NV")]
            public static extern void GlProgramUniformHandleui64(uint program, int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformHandleui64vNV")]
            public static extern void GlProgramUniformHandleui64v(uint program, int location, int count, uint* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsTextureHandleResidentNV")]
            public static extern byte GlIsTextureHandleResident(uint handle);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsImageHandleResidentNV")]
            public static extern byte GlIsImageHandleResident(uint handle);
            
        }
        public unsafe static partial class BlendEquationAdvanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlendParameteriNV")]
            public static extern void GlBlendParameteri(uint pname, int value);
            
            [DllImport("opengl32.dll", EntryPoint = "glBlendBarrierNV")]
            public static extern void GlBlendBarrier();
            
        }
        public unsafe static partial class BlendEquationAdvancedCoherent
        {
        }
        public unsafe static partial class BlendMinmaxFactor
        {
        }
        public unsafe static partial class BlendSquare
        {
        }
        public unsafe static partial class ClipSpaceWScaling
        {
            [DllImport("opengl32.dll", EntryPoint = "glViewportPositionWScaleNV")]
            public static extern void GlViewportPositionWScale(uint index, float xcoeff, float ycoeff);
            
        }
        public unsafe static partial class CommandList
        {
            [DllImport("opengl32.dll", EntryPoint = "glCreateStatesNV")]
            public static extern void GlCreateStates(int n, uint* states);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteStatesNV")]
            public static extern void GlDeleteStates(int n, uint* states);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsStateNV")]
            public static extern byte GlIsState(uint state);
            
            [DllImport("opengl32.dll", EntryPoint = "glStateCaptureNV")]
            public static extern void GlStateCapture(uint state, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCommandHeaderNV")]
            public static extern uint GlGetCommandHeader(uint tokenID, uint size);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetStageIndexNV")]
            public static extern ushort GlGetStageIndex(uint shadertype);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawCommandsNV")]
            public static extern void GlDrawCommands(uint primitiveMode, uint buffer, IntPtr* indirects, int* sizes, uint count);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawCommandsAddressNV")]
            public static extern void GlDrawCommandsAddress(uint primitiveMode, uint* indirects, int* sizes, uint count);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawCommandsStatesNV")]
            public static extern void GlDrawCommandsStates(uint buffer, IntPtr* indirects, int* sizes, uint* states, uint* fbos, uint count);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawCommandsStatesAddressNV")]
            public static extern void GlDrawCommandsStatesAddress(uint* indirects, int* sizes, uint* states, uint* fbos, uint count);
            
            [DllImport("opengl32.dll", EntryPoint = "glCreateCommandListsNV")]
            public static extern void GlCreateCommandLists(int n, uint* lists);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteCommandListsNV")]
            public static extern void GlDeleteCommandLists(int n, uint* lists);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsCommandListNV")]
            public static extern byte GlIsCommandList(uint list);
            
            [DllImport("opengl32.dll", EntryPoint = "glListDrawCommandsStatesClientNV")]
            public static extern void GlListDrawCommandsStatesClient(uint list, uint segment, void** indirects, int* sizes, uint* states, uint* fbos, uint count);
            
            [DllImport("opengl32.dll", EntryPoint = "glCommandListSegmentsNV")]
            public static extern void GlCommandListSegments(uint list, uint segments);
            
            [DllImport("opengl32.dll", EntryPoint = "glCompileCommandListNV")]
            public static extern void GlCompileCommandList(uint list);
            
            [DllImport("opengl32.dll", EntryPoint = "glCallCommandListNV")]
            public static extern void GlCallCommandList(uint list);
            
        }
        public unsafe static partial class ComputeProgram5
        {
        }
        public unsafe static partial class ComputeShaderDerivatives
        {
        }
        public unsafe static partial class ConditionalRender
        {
            [DllImport("opengl32.dll", EntryPoint = "glBeginConditionalRenderNV")]
            public static extern void GlBeginConditionalRender(uint id, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndConditionalRenderNV")]
            public static extern void GlEndConditionalRender();
            
        }
        public unsafe static partial class ConservativeRaster
        {
            [DllImport("opengl32.dll", EntryPoint = "glSubpixelPrecisionBiasNV")]
            public static extern void GlSubpixelPrecisionBias(uint xbits, uint ybits);
            
        }
        public unsafe static partial class ConservativeRasterDilate
        {
            [DllImport("opengl32.dll", EntryPoint = "glConservativeRasterParameterfNV")]
            public static extern void GlConservativeRasterParameterf(uint pname, float value);
            
        }
        public unsafe static partial class ConservativeRasterPreSnap
        {
        }
        public unsafe static partial class ConservativeRasterPreSnapTriangles
        {
            [DllImport("opengl32.dll", EntryPoint = "glConservativeRasterParameteriNV")]
            public static extern void GlConservativeRasterParameteri(uint pname, int param);
            
        }
        public unsafe static partial class ConservativeRasterUnderestimation
        {
        }
        public unsafe static partial class CopyDepthToColor
        {
        }
        public unsafe static partial class CopyImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyImageSubDataNV")]
            public static extern void GlCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);
            
        }
        public unsafe static partial class DeepTexture3d
        {
        }
        public unsafe static partial class DepthBufferFloat
        {
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangedNV")]
            public static extern void GlDepthRanged(double zNear, double zFar);
            
            [DllImport("opengl32.dll", EntryPoint = "glClearDepthdNV")]
            public static extern void GlClearDepthd(double depth);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthBoundsdNV")]
            public static extern void GlDepthBoundsd(double zmin, double zmax);
            
        }
        public unsafe static partial class DepthClamp
        {
        }
        public unsafe static partial class DrawTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawTextureNV")]
            public static extern void GlDrawTexture(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
            
        }
        public unsafe static partial class DrawVulkanImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawVkImageNV")]
            public static extern void GlDrawVkImage(uint vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVkProcAddrNV")]
            public static extern void GlGetVkProcAddr(char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glWaitVkSemaphoreNV")]
            public static extern void GlWaitVkSemaphore(uint vkSemaphore);
            
            [DllImport("opengl32.dll", EntryPoint = "glSignalVkSemaphoreNV")]
            public static extern void GlSignalVkSemaphore(uint vkSemaphore);
            
            [DllImport("opengl32.dll", EntryPoint = "glSignalVkFenceNV")]
            public static extern void GlSignalVkFence(uint vkFence);
            
        }
        public unsafe static partial class Evaluators
        {
            [DllImport("opengl32.dll", EntryPoint = "glMapControlPointsNV")]
            public static extern void GlMapControlPoints(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, void* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapParameterivNV")]
            public static extern void GlMapParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMapParameterfvNV")]
            public static extern void GlMapParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMapControlPointsNV")]
            public static extern void GlGetMapControlPoints(uint target, uint index, uint type, int ustride, int vstride, byte packed, void* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMapParameterivNV")]
            public static extern void GlGetMapParameteriv(uint target, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMapParameterfvNV")]
            public static extern void GlGetMapParameterfv(uint target, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMapAttribParameterivNV")]
            public static extern void GlGetMapAttribParameteriv(uint target, uint index, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetMapAttribParameterfvNV")]
            public static extern void GlGetMapAttribParameterfv(uint target, uint index, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glEvalMapsNV")]
            public static extern void GlEvalMaps(uint target, uint mode);
            
        }
        public unsafe static partial class ExplicitMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetMultisamplefvNV")]
            public static extern void GlGetMultisamplefv(uint pname, uint index, float* val);
            
            [DllImport("opengl32.dll", EntryPoint = "glSampleMaskIndexedNV")]
            public static extern void GlSampleMaskIndexed(uint index, uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexRenderbufferNV")]
            public static extern void GlTexRenderbuffer(uint target, uint renderbuffer);
            
        }
        public unsafe static partial class Fence
        {
            [DllImport("opengl32.dll", EntryPoint = "glDeleteFencesNV")]
            public static extern void GlDeleteFences(int n, uint* fences);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenFencesNV")]
            public static extern void GlGenFences(int n, uint* fences);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsFenceNV")]
            public static extern byte GlIsFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glTestFenceNV")]
            public static extern byte GlTestFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFenceivNV")]
            public static extern void GlGetFenceiv(uint fence, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFinishFenceNV")]
            public static extern void GlFinishFence(uint fence);
            
            [DllImport("opengl32.dll", EntryPoint = "glSetFenceNV")]
            public static extern void GlSetFence(uint fence, uint condition);
            
        }
        public unsafe static partial class FillRectangle
        {
        }
        public unsafe static partial class FloatBuffer
        {
        }
        public unsafe static partial class FogDistance
        {
        }
        public unsafe static partial class FragmentCoverageToColor
        {
            [DllImport("opengl32.dll", EntryPoint = "glFragmentCoverageColorNV")]
            public static extern void GlFragmentCoverageColor(uint color);
            
        }
        public unsafe static partial class FragmentProgram
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramNamedParameter4fNV")]
            public static extern void GlProgramNamedParameter4f(uint id, int len, byte* name, float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramNamedParameter4fvNV")]
            public static extern void GlProgramNamedParameter4fv(uint id, int len, byte* name, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramNamedParameter4dNV")]
            public static extern void GlProgramNamedParameter4d(uint id, int len, byte* name, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramNamedParameter4dvNV")]
            public static extern void GlProgramNamedParameter4dv(uint id, int len, byte* name, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramNamedParameterfvNV")]
            public static extern void GlGetProgramNamedParameterfv(uint id, int len, byte* name, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramNamedParameterdvNV")]
            public static extern void GlGetProgramNamedParameterdv(uint id, int len, byte* name, double* parameters);
            
        }
        public unsafe static partial class FragmentProgram2
        {
        }
        public unsafe static partial class FragmentProgram4
        {
        }
        public unsafe static partial class FragmentProgramOption
        {
        }
        public unsafe static partial class FragmentShaderBarycentric
        {
        }
        public unsafe static partial class FragmentShaderInterlock
        {
        }
        public unsafe static partial class FramebufferMixedSamples
        {
            [DllImport("opengl32.dll", EntryPoint = "glRasterSamplesEXT")]
            public static extern void GlRasterSamplesEXT(uint samples, byte fixedsamplelocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glCoverageModulationTableNV")]
            public static extern void GlCoverageModulationTable(int n, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCoverageModulationTableNV")]
            public static extern void GlGetCoverageModulationTable(int bufSize, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glCoverageModulationNV")]
            public static extern void GlCoverageModulation(uint components);
            
        }
        public unsafe static partial class FramebufferMultisampleCoverage
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleCoverageNV")]
            public static extern void GlRenderbufferStorageMultisampleCoverage(uint target, int coverageSamples, int colorSamples, uint internalformat, int width, int height);
            
        }
        public unsafe static partial class GeometryProgram4
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramVertexLimitNV")]
            public static extern void GlProgramVertexLimit(uint target, int limit);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureEXT")]
            public static extern void GlFramebufferTextureEXT(uint target, uint attachment, uint texture, int level);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureLayerEXT")]
            public static extern void GlFramebufferTextureLayerEXT(uint target, uint attachment, uint texture, int level, int layer);
            
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferTextureFaceEXT")]
            public static extern void GlFramebufferTextureFaceEXT(uint target, uint attachment, uint texture, int level, uint face);
            
        }
        public unsafe static partial class GeometryShader4
        {
        }
        public unsafe static partial class GeometryShaderPassthrough
        {
        }
        public unsafe static partial class GpuProgram4
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramLocalParameterI4iNV")]
            public static extern void GlProgramLocalParameterI4i(uint target, uint index, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramLocalParameterI4ivNV")]
            public static extern void GlProgramLocalParameterI4iv(uint target, uint index, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramLocalParametersI4ivNV")]
            public static extern void GlProgramLocalParametersI4iv(uint target, uint index, int count, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramLocalParameterI4uiNV")]
            public static extern void GlProgramLocalParameterI4ui(uint target, uint index, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramLocalParameterI4uivNV")]
            public static extern void GlProgramLocalParameterI4uiv(uint target, uint index, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramLocalParametersI4uivNV")]
            public static extern void GlProgramLocalParametersI4uiv(uint target, uint index, int count, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramEnvParameterI4iNV")]
            public static extern void GlProgramEnvParameterI4i(uint target, uint index, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramEnvParameterI4ivNV")]
            public static extern void GlProgramEnvParameterI4iv(uint target, uint index, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramEnvParametersI4ivNV")]
            public static extern void GlProgramEnvParametersI4iv(uint target, uint index, int count, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramEnvParameterI4uiNV")]
            public static extern void GlProgramEnvParameterI4ui(uint target, uint index, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramEnvParameterI4uivNV")]
            public static extern void GlProgramEnvParameterI4uiv(uint target, uint index, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramEnvParametersI4uivNV")]
            public static extern void GlProgramEnvParametersI4uiv(uint target, uint index, int count, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramLocalParameterIivNV")]
            public static extern void GlGetProgramLocalParameterIiv(uint target, uint index, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramLocalParameterIuivNV")]
            public static extern void GlGetProgramLocalParameterIuiv(uint target, uint index, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramEnvParameterIivNV")]
            public static extern void GlGetProgramEnvParameterIiv(uint target, uint index, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramEnvParameterIuivNV")]
            public static extern void GlGetProgramEnvParameterIuiv(uint target, uint index, uint* parameters);
            
        }
        public unsafe static partial class GpuProgram5
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramSubroutineParametersuivNV")]
            public static extern void GlProgramSubroutineParametersuiv(uint target, int count, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramSubroutineParameteruivNV")]
            public static extern void GlGetProgramSubroutineParameteruiv(uint target, uint index, uint* param);
            
        }
        public unsafe static partial class GpuProgram5MemExtended
        {
        }
        public unsafe static partial class GpuShader5
        {
            [DllImport("opengl32.dll", EntryPoint = "glUniform1i64NV")]
            public static extern void GlUniform1i64(int location, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2i64NV")]
            public static extern void GlUniform2i64(int location, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3i64NV")]
            public static extern void GlUniform3i64(int location, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4i64NV")]
            public static extern void GlUniform4i64(int location, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1i64vNV")]
            public static extern void GlUniform1i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2i64vNV")]
            public static extern void GlUniform2i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3i64vNV")]
            public static extern void GlUniform3i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4i64vNV")]
            public static extern void GlUniform4i64v(int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1ui64NV")]
            public static extern void GlUniform1ui64(int location, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2ui64NV")]
            public static extern void GlUniform2ui64(int location, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3ui64NV")]
            public static extern void GlUniform3ui64(int location, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4ui64NV")]
            public static extern void GlUniform4ui64(int location, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform1ui64vNV")]
            public static extern void GlUniform1ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform2ui64vNV")]
            public static extern void GlUniform2ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform3ui64vNV")]
            public static extern void GlUniform3ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniform4ui64vNV")]
            public static extern void GlUniform4ui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformi64vNV")]
            public static extern void GlGetUniformi64v(uint program, int location, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i64NV")]
            public static extern void GlProgramUniform1i64(uint program, int location, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i64NV")]
            public static extern void GlProgramUniform2i64(uint program, int location, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i64NV")]
            public static extern void GlProgramUniform3i64(uint program, int location, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i64NV")]
            public static extern void GlProgramUniform4i64(uint program, int location, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1i64vNV")]
            public static extern void GlProgramUniform1i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2i64vNV")]
            public static extern void GlProgramUniform2i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3i64vNV")]
            public static extern void GlProgramUniform3i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4i64vNV")]
            public static extern void GlProgramUniform4i64v(uint program, int location, int count, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui64NV")]
            public static extern void GlProgramUniform1ui64(uint program, int location, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui64NV")]
            public static extern void GlProgramUniform2ui64(uint program, int location, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui64NV")]
            public static extern void GlProgramUniform3ui64(uint program, int location, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui64NV")]
            public static extern void GlProgramUniform4ui64(uint program, int location, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform1ui64vNV")]
            public static extern void GlProgramUniform1ui64v(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform2ui64vNV")]
            public static extern void GlProgramUniform2ui64v(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform3ui64vNV")]
            public static extern void GlProgramUniform3ui64v(uint program, int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniform4ui64vNV")]
            public static extern void GlProgramUniform4ui64v(uint program, int location, int count, uint* value);
            
        }
        public unsafe static partial class HalfFloat
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertex2hNV")]
            public static extern void GlVertex2h(ushort x, ushort y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex2hvNV")]
            public static extern void GlVertex2hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex3hNV")]
            public static extern void GlVertex3h(ushort x, ushort y, ushort z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex3hvNV")]
            public static extern void GlVertex3hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex4hNV")]
            public static extern void GlVertex4h(ushort x, ushort y, ushort z, ushort w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertex4hvNV")]
            public static extern void GlVertex4hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormal3hNV")]
            public static extern void GlNormal3h(ushort nx, ushort ny, ushort nz);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormal3hvNV")]
            public static extern void GlNormal3hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor3hNV")]
            public static extern void GlColor3h(ushort red, ushort green, ushort blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor3hvNV")]
            public static extern void GlColor3hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4hNV")]
            public static extern void GlColor4h(ushort red, ushort green, ushort blue, ushort alpha);
            
            [DllImport("opengl32.dll", EntryPoint = "glColor4hvNV")]
            public static extern void GlColor4hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord1hNV")]
            public static extern void GlTexCoord1h(ushort s);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord1hvNV")]
            public static extern void GlTexCoord1hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2hNV")]
            public static extern void GlTexCoord2h(ushort s, ushort t);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord2hvNV")]
            public static extern void GlTexCoord2hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord3hNV")]
            public static extern void GlTexCoord3h(ushort s, ushort t, ushort r);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord3hvNV")]
            public static extern void GlTexCoord3hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4hNV")]
            public static extern void GlTexCoord4h(ushort s, ushort t, ushort r, ushort q);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoord4hvNV")]
            public static extern void GlTexCoord4hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1hNV")]
            public static extern void GlMultiTexCoord1h(uint target, ushort s);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord1hvNV")]
            public static extern void GlMultiTexCoord1hv(uint target, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2hNV")]
            public static extern void GlMultiTexCoord2h(uint target, ushort s, ushort t);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord2hvNV")]
            public static extern void GlMultiTexCoord2hv(uint target, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3hNV")]
            public static extern void GlMultiTexCoord3h(uint target, ushort s, ushort t, ushort r);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord3hvNV")]
            public static extern void GlMultiTexCoord3hv(uint target, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4hNV")]
            public static extern void GlMultiTexCoord4h(uint target, ushort s, ushort t, ushort r, ushort q);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiTexCoord4hvNV")]
            public static extern void GlMultiTexCoord4hv(uint target, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoordhNV")]
            public static extern void GlFogCoordh(ushort fog);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoordhvNV")]
            public static extern void GlFogCoordhv(ushort* fog);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3hNV")]
            public static extern void GlSecondaryColor3h(ushort red, ushort green, ushort blue);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColor3hvNV")]
            public static extern void GlSecondaryColor3hv(ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexWeighthNV")]
            public static extern void GlVertexWeighth(ushort weight);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexWeighthvNV")]
            public static extern void GlVertexWeighthv(ushort* weight);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1hNV")]
            public static extern void GlVertexAttrib1h(uint index, ushort x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1hvNV")]
            public static extern void GlVertexAttrib1hv(uint index, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2hNV")]
            public static extern void GlVertexAttrib2h(uint index, ushort x, ushort y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2hvNV")]
            public static extern void GlVertexAttrib2hv(uint index, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3hNV")]
            public static extern void GlVertexAttrib3h(uint index, ushort x, ushort y, ushort z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3hvNV")]
            public static extern void GlVertexAttrib3hv(uint index, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4hNV")]
            public static extern void GlVertexAttrib4h(uint index, ushort x, ushort y, ushort z, ushort w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4hvNV")]
            public static extern void GlVertexAttrib4hv(uint index, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs1hvNV")]
            public static extern void GlVertexAttribs1hv(uint index, int n, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs2hvNV")]
            public static extern void GlVertexAttribs2hv(uint index, int n, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs3hvNV")]
            public static extern void GlVertexAttribs3hv(uint index, int n, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs4hvNV")]
            public static extern void GlVertexAttribs4hv(uint index, int n, ushort* v);
            
        }
        public unsafe static partial class InternalformatSampleQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetInternalformatSampleivNV")]
            public static extern void GlGetInternalformatSampleiv(uint target, uint internalformat, int samples, uint pname, int count, int* parameters);
            
        }
        public unsafe static partial class LightMaxExponent
        {
        }
        public unsafe static partial class GpuMulticast
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderGpuMaskNV")]
            public static extern void GlRenderGpuMask(uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastBufferSubDataNV")]
            public static extern void GlMulticastBufferSubData(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, void* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastCopyBufferSubDataNV")]
            public static extern void GlMulticastCopyBufferSubData(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastCopyImageSubDataNV")]
            public static extern void GlMulticastCopyImageSubData(uint srcGpu, uint dstGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastBlitFramebufferNV")]
            public static extern void GlMulticastBlitFramebuffer(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
            public static extern void GlMulticastFramebufferSampleLocationsfv(uint gpu, uint framebuffer, uint start, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastBarrierNV")]
            public static extern void GlMulticastBarrier();
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastWaitSyncNV")]
            public static extern void GlMulticastWaitSync(uint signalGpu, uint waitGpuMask);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastGetQueryObjectivNV")]
            public static extern void GlMulticastGetQueryObjectiv(uint gpu, uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastGetQueryObjectuivNV")]
            public static extern void GlMulticastGetQueryObjectuiv(uint gpu, uint id, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastGetQueryObjecti64vNV")]
            public static extern void GlMulticastGetQueryObjecti64v(uint gpu, uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glMulticastGetQueryObjectui64vNV")]
            public static extern void GlMulticastGetQueryObjectui64v(uint gpu, uint id, uint pname, uint* parameters);
            
        }
        public unsafe static partial class MemoryAttachment
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetMemoryObjectDetachedResourcesuivNV")]
            public static extern void GlGetMemoryObjectDetachedResourcesuiv(uint memory, uint pname, int first, int count, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glResetMemoryObjectParameterNV")]
            public static extern void GlResetMemoryObjectParameter(uint memory, uint pname);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexAttachMemoryNV")]
            public static extern void GlTexAttachMemory(uint target, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glBufferAttachMemoryNV")]
            public static extern void GlBufferAttachMemory(uint target, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureAttachMemoryNV")]
            public static extern void GlTextureAttachMemory(uint texture, uint memory, uint offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedBufferAttachMemoryNV")]
            public static extern void GlNamedBufferAttachMemory(uint buffer, uint memory, uint offset);
            
        }
        public unsafe static partial class MeshShader
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawMeshTasksNV")]
            public static extern void GlDrawMeshTasks(uint first, uint count);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawMeshTasksIndirectNV")]
            public static extern void GlDrawMeshTasksIndirect(IntPtr indirect);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawMeshTasksIndirectNV")]
            public static extern void GlMultiDrawMeshTasksIndirect(IntPtr indirect, int drawcount, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glMultiDrawMeshTasksIndirectCountNV")]
            public static extern void GlMultiDrawMeshTasksIndirectCount(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride);
            
        }
        public unsafe static partial class MultisampleCoverage
        {
        }
        public unsafe static partial class MultisampleFilterHint
        {
        }
        public unsafe static partial class OcclusionQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenOcclusionQueriesNV")]
            public static extern void GlGenOcclusionQueries(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteOcclusionQueriesNV")]
            public static extern void GlDeleteOcclusionQueries(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsOcclusionQueryNV")]
            public static extern byte GlIsOcclusionQuery(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glBeginOcclusionQueryNV")]
            public static extern void GlBeginOcclusionQuery(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndOcclusionQueryNV")]
            public static extern void GlEndOcclusionQuery();
            
            [DllImport("opengl32.dll", EntryPoint = "glGetOcclusionQueryivNV")]
            public static extern void GlGetOcclusionQueryiv(uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetOcclusionQueryuivNV")]
            public static extern void GlGetOcclusionQueryuiv(uint id, uint pname, uint* parameters);
            
        }
        public unsafe static partial class PackedDepthStencil
        {
        }
        public unsafe static partial class ParameterBufferObject
        {
            [DllImport("opengl32.dll", EntryPoint = "glProgramBufferParametersfvNV")]
            public static extern void GlProgramBufferParametersfv(uint target, uint bindingIndex, uint wordIndex, int count, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramBufferParametersIivNV")]
            public static extern void GlProgramBufferParametersIiv(uint target, uint bindingIndex, uint wordIndex, int count, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramBufferParametersIuivNV")]
            public static extern void GlProgramBufferParametersIuiv(uint target, uint bindingIndex, uint wordIndex, int count, uint* parameters);
            
        }
        public unsafe static partial class ParameterBufferObject2
        {
        }
        public unsafe static partial class PathRendering
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenPathsNV")]
            public static extern uint GlGenPaths(int range);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeletePathsNV")]
            public static extern void GlDeletePaths(uint path, int range);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsPathNV")]
            public static extern byte GlIsPath(uint path);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathCommandsNV")]
            public static extern void GlPathCommands(uint path, int numCommands, byte* commands, int numCoords, uint coordType, void* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathCoordsNV")]
            public static extern void GlPathCoords(uint path, int numCoords, uint coordType, void* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathSubCommandsNV")]
            public static extern void GlPathSubCommands(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, uint coordType, void* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathSubCoordsNV")]
            public static extern void GlPathSubCoords(uint path, int coordStart, int numCoords, uint coordType, void* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathStringNV")]
            public static extern void GlPathString(uint path, uint format, int length, void* pathString);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathGlyphsNV")]
            public static extern void GlPathGlyphs(uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, int numGlyphs, uint type, void* charcodes, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathGlyphRangeNV")]
            public static extern void GlPathGlyphRange(uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, uint firstGlyph, int numGlyphs, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
            
            [DllImport("opengl32.dll", EntryPoint = "glWeightPathsNV")]
            public static extern void GlWeightPaths(uint resultPath, int numPaths, uint* paths, float* weights);
            
            [DllImport("opengl32.dll", EntryPoint = "glCopyPathNV")]
            public static extern void GlCopyPath(uint resultPath, uint srcPath);
            
            [DllImport("opengl32.dll", EntryPoint = "glInterpolatePathsNV")]
            public static extern void GlInterpolatePaths(uint resultPath, uint pathA, uint pathB, float weight);
            
            [DllImport("opengl32.dll", EntryPoint = "glTransformPathNV")]
            public static extern void GlTransformPath(uint resultPath, uint srcPath, uint transformType, float* transformValues);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathParameterivNV")]
            public static extern void GlPathParameteriv(uint path, uint pname, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathParameteriNV")]
            public static extern void GlPathParameteri(uint path, uint pname, int value);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathParameterfvNV")]
            public static extern void GlPathParameterfv(uint path, uint pname, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathParameterfNV")]
            public static extern void GlPathParameterf(uint path, uint pname, float value);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathDashArrayNV")]
            public static extern void GlPathDashArray(uint path, int dashCount, float* dashArray);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathStencilFuncNV")]
            public static extern void GlPathStencilFunc(uint func, int reference, uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathStencilDepthOffsetNV")]
            public static extern void GlPathStencilDepthOffset(float factor, float units);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilFillPathNV")]
            public static extern void GlStencilFillPath(uint path, uint fillMode, uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilStrokePathNV")]
            public static extern void GlStencilStrokePath(uint path, int reference, uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilFillPathInstancedNV")]
            public static extern void GlStencilFillPathInstanced(int numPaths, uint pathNameType, void* paths, uint pathBase, uint fillMode, uint mask, uint transformType, float* transformValues);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilStrokePathInstancedNV")]
            public static extern void GlStencilStrokePathInstanced(int numPaths, uint pathNameType, void* paths, uint pathBase, int reference, uint mask, uint transformType, float* transformValues);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathCoverDepthFuncNV")]
            public static extern void GlPathCoverDepthFunc(uint func);
            
            [DllImport("opengl32.dll", EntryPoint = "glCoverFillPathNV")]
            public static extern void GlCoverFillPath(uint path, uint coverMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glCoverStrokePathNV")]
            public static extern void GlCoverStrokePath(uint path, uint coverMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glCoverFillPathInstancedNV")]
            public static extern void GlCoverFillPathInstanced(int numPaths, uint pathNameType, void* paths, uint pathBase, uint coverMode, uint transformType, float* transformValues);
            
            [DllImport("opengl32.dll", EntryPoint = "glCoverStrokePathInstancedNV")]
            public static extern void GlCoverStrokePathInstanced(int numPaths, uint pathNameType, void* paths, uint pathBase, uint coverMode, uint transformType, float* transformValues);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathParameterivNV")]
            public static extern void GlGetPathParameteriv(uint path, uint pname, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathParameterfvNV")]
            public static extern void GlGetPathParameterfv(uint path, uint pname, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathCommandsNV")]
            public static extern void GlGetPathCommands(uint path, byte* commands);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathCoordsNV")]
            public static extern void GlGetPathCoords(uint path, float* coords);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathDashArrayNV")]
            public static extern void GlGetPathDashArray(uint path, float* dashArray);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathMetricsNV")]
            public static extern void GlGetPathMetrics(uint metricQueryMask, int numPaths, uint pathNameType, void* paths, uint pathBase, int stride, float* metrics);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathMetricRangeNV")]
            public static extern void GlGetPathMetricRange(uint metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathSpacingNV")]
            public static extern void GlGetPathSpacing(uint pathListMode, int numPaths, uint pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, uint transformType, float* returnedSpacing);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsPointInFillPathNV")]
            public static extern byte GlIsPointInFillPath(uint path, uint mask, float x, float y);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsPointInStrokePathNV")]
            public static extern byte GlIsPointInStrokePath(uint path, float x, float y);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathLengthNV")]
            public static extern float GlGetPathLength(uint path, int startSegment, int numSegments);
            
            [DllImport("opengl32.dll", EntryPoint = "glPointAlongPathNV")]
            public static extern byte GlPointAlongPath(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoad3x2fNV")]
            public static extern void GlMatrixLoad3x2f(uint matrixMode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoad3x3fNV")]
            public static extern void GlMatrixLoad3x3f(uint matrixMode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadTranspose3x3fNV")]
            public static extern void GlMatrixLoadTranspose3x3f(uint matrixMode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMult3x2fNV")]
            public static extern void GlMatrixMult3x2f(uint matrixMode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMult3x3fNV")]
            public static extern void GlMatrixMult3x3f(uint matrixMode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultTranspose3x3fNV")]
            public static extern void GlMatrixMultTranspose3x3f(uint matrixMode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilThenCoverFillPathNV")]
            public static extern void GlStencilThenCoverFillPath(uint path, uint fillMode, uint mask, uint coverMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilThenCoverStrokePathNV")]
            public static extern void GlStencilThenCoverStrokePath(uint path, int reference, uint mask, uint coverMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilThenCoverFillPathInstancedNV")]
            public static extern void GlStencilThenCoverFillPathInstanced(int numPaths, uint pathNameType, void* paths, uint pathBase, uint fillMode, uint mask, uint coverMode, uint transformType, float* transformValues);
            
            [DllImport("opengl32.dll", EntryPoint = "glStencilThenCoverStrokePathInstancedNV")]
            public static extern void GlStencilThenCoverStrokePathInstanced(int numPaths, uint pathNameType, void* paths, uint pathBase, int reference, uint mask, uint coverMode, uint transformType, float* transformValues);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathGlyphIndexRangeNV")]
            public static extern uint GlPathGlyphIndexRange(uint fontTarget, void* fontName, uint fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathGlyphIndexArrayNV")]
            public static extern uint GlPathGlyphIndexArray(uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathMemoryGlyphIndexArrayNV")]
            public static extern uint GlPathMemoryGlyphIndexArray(uint firstPathName, uint fontTarget, IntPtr fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramPathFragmentInputGenNV")]
            public static extern void GlProgramPathFragmentInputGen(uint program, int location, uint genMode, int components, float* coeffs);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramResourcefvNV")]
            public static extern void GlGetProgramResourcefv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathColorGenNV")]
            public static extern void GlPathColorGen(uint color, uint genMode, uint colorFormat, float* coeffs);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathTexGenNV")]
            public static extern void GlPathTexGen(uint texCoordSet, uint genMode, int components, float* coeffs);
            
            [DllImport("opengl32.dll", EntryPoint = "glPathFogGenNV")]
            public static extern void GlPathFogGen(uint genMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathColorGenivNV")]
            public static extern void GlGetPathColorGeniv(uint color, uint pname, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathColorGenfvNV")]
            public static extern void GlGetPathColorGenfv(uint color, uint pname, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathTexGenivNV")]
            public static extern void GlGetPathTexGeniv(uint texCoordSet, uint pname, int* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetPathTexGenfvNV")]
            public static extern void GlGetPathTexGenfv(uint texCoordSet, uint pname, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixFrustumEXT")]
            public static extern void GlMatrixFrustumEXT(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadIdentityEXT")]
            public static extern void GlMatrixLoadIdentityEXT(uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadTransposefEXT")]
            public static extern void GlMatrixLoadTransposefEXT(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadTransposedEXT")]
            public static extern void GlMatrixLoadTransposedEXT(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoadfEXT")]
            public static extern void GlMatrixLoadfEXT(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixLoaddEXT")]
            public static extern void GlMatrixLoaddEXT(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultTransposefEXT")]
            public static extern void GlMatrixMultTransposefEXT(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultTransposedEXT")]
            public static extern void GlMatrixMultTransposedEXT(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultfEXT")]
            public static extern void GlMatrixMultfEXT(uint mode, float* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixMultdEXT")]
            public static extern void GlMatrixMultdEXT(uint mode, double* m);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixOrthoEXT")]
            public static extern void GlMatrixOrthoEXT(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixPopEXT")]
            public static extern void GlMatrixPopEXT(uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixPushEXT")]
            public static extern void GlMatrixPushEXT(uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixRotatefEXT")]
            public static extern void GlMatrixRotatefEXT(uint mode, float angle, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixRotatedEXT")]
            public static extern void GlMatrixRotatedEXT(uint mode, double angle, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixScalefEXT")]
            public static extern void GlMatrixScalefEXT(uint mode, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixScaledEXT")]
            public static extern void GlMatrixScaledEXT(uint mode, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixTranslatefEXT")]
            public static extern void GlMatrixTranslatefEXT(uint mode, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glMatrixTranslatedEXT")]
            public static extern void GlMatrixTranslatedEXT(uint mode, double x, double y, double z);
            
        }
        public unsafe static partial class PathRenderingSharedEdge
        {
        }
        public unsafe static partial class PixelDataRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glPixelDataRangeNV")]
            public static extern void GlPixelDataRange(uint target, int length, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glFlushPixelDataRangeNV")]
            public static extern void GlFlushPixelDataRange(uint target);
            
        }
        public unsafe static partial class PointSprite
        {
            [DllImport("opengl32.dll", EntryPoint = "glPointParameteriNV")]
            public static extern void GlPointParameteri(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glPointParameterivNV")]
            public static extern void GlPointParameteriv(uint pname, int* parameters);
            
        }
        public unsafe static partial class PresentVideo
        {
            [DllImport("opengl32.dll", EntryPoint = "glPresentFrameKeyedNV")]
            public static extern void GlPresentFrameKeyed(uint video_slot, uint minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint key0, uint target1, uint fill1, uint key1);
            
            [DllImport("opengl32.dll", EntryPoint = "glPresentFrameDualFillNV")]
            public static extern void GlPresentFrameDualFill(uint video_slot, uint minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint target1, uint fill1, uint target2, uint fill2, uint target3, uint fill3);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideoivNV")]
            public static extern void GlGetVideoiv(uint video_slot, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideouivNV")]
            public static extern void GlGetVideouiv(uint video_slot, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideoi64vNV")]
            public static extern void GlGetVideoi64v(uint video_slot, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideoui64vNV")]
            public static extern void GlGetVideoui64v(uint video_slot, uint pname, uint* parameters);
            
        }
        public unsafe static partial class PrimitiveRestart
        {
            [DllImport("opengl32.dll", EntryPoint = "glPrimitiveRestartNV")]
            public static extern void GlPrimitiveRestart();
            
            [DllImport("opengl32.dll", EntryPoint = "glPrimitiveRestartIndexNV")]
            public static extern void GlPrimitiveRestartIndex(uint index);
            
        }
        public unsafe static partial class QueryResource
        {
            [DllImport("opengl32.dll", EntryPoint = "glQueryResourceNV")]
            public static extern int GlQueryResource(uint queryType, int tagId, uint count, int* buffer);
            
        }
        public unsafe static partial class QueryResourceTag
        {
            [DllImport("opengl32.dll", EntryPoint = "glGenQueryResourceTagNV")]
            public static extern void GlGenQueryResourceTag(int n, int* tagIds);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteQueryResourceTagNV")]
            public static extern void GlDeleteQueryResourceTag(int n, int* tagIds);
            
            [DllImport("opengl32.dll", EntryPoint = "glQueryResourceTagNV")]
            public static extern void GlQueryResourceTag(int tagId, char* tagString);
            
        }
        public unsafe static partial class RegisterCombiners
        {
            [DllImport("opengl32.dll", EntryPoint = "glCombinerParameterfvNV")]
            public static extern void GlCombinerParameterfv(uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCombinerParameterfNV")]
            public static extern void GlCombinerParameterf(uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glCombinerParameterivNV")]
            public static extern void GlCombinerParameteriv(uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glCombinerParameteriNV")]
            public static extern void GlCombinerParameteri(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glCombinerInputNV")]
            public static extern void GlCombinerInput(uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage);
            
            [DllImport("opengl32.dll", EntryPoint = "glCombinerOutputNV")]
            public static extern void GlCombinerOutput(uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, byte abDotProduct, byte cdDotProduct, byte muxSum);
            
            [DllImport("opengl32.dll", EntryPoint = "glFinalCombinerInputNV")]
            public static extern void GlFinalCombinerInput(uint variable, uint input, uint mapping, uint componentUsage);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCombinerInputParameterfvNV")]
            public static extern void GlGetCombinerInputParameterfv(uint stage, uint portion, uint variable, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCombinerInputParameterivNV")]
            public static extern void GlGetCombinerInputParameteriv(uint stage, uint portion, uint variable, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCombinerOutputParameterfvNV")]
            public static extern void GlGetCombinerOutputParameterfv(uint stage, uint portion, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCombinerOutputParameterivNV")]
            public static extern void GlGetCombinerOutputParameteriv(uint stage, uint portion, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
            public static extern void GlGetFinalCombinerInputParameterfv(uint variable, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFinalCombinerInputParameterivNV")]
            public static extern void GlGetFinalCombinerInputParameteriv(uint variable, uint pname, int* parameters);
            
        }
        public unsafe static partial class RegisterCombiners2
        {
            [DllImport("opengl32.dll", EntryPoint = "glCombinerStageParameterfvNV")]
            public static extern void GlCombinerStageParameterfv(uint stage, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetCombinerStageParameterfvNV")]
            public static extern void GlGetCombinerStageParameterfv(uint stage, uint pname, float* parameters);
            
        }
        public unsafe static partial class RepresentativeFragmentTest
        {
        }
        public unsafe static partial class RobustnessVideoMemoryPurge
        {
        }
        public unsafe static partial class SampleLocations
        {
            [DllImport("opengl32.dll", EntryPoint = "glFramebufferSampleLocationsfvNV")]
            public static extern void GlFramebufferSampleLocationsfv(uint target, uint start, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glNamedFramebufferSampleLocationsfvNV")]
            public static extern void GlNamedFramebufferSampleLocationsfv(uint framebuffer, uint start, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glResolveDepthValuesNV")]
            public static extern void GlResolveDepthValues();
            
        }
        public unsafe static partial class SampleMaskOverrideCoverage
        {
        }
        public unsafe static partial class ScissorExclusive
        {
            [DllImport("opengl32.dll", EntryPoint = "glScissorExclusiveNV")]
            public static extern void GlScissorExclusive(int x, int y, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorExclusiveArrayvNV")]
            public static extern void GlScissorExclusiveArrayv(uint first, int count, int* v);
            
        }
        public unsafe static partial class ShaderAtomicCounters
        {
        }
        public unsafe static partial class ShaderAtomicFloat
        {
        }
        public unsafe static partial class ShaderAtomicFloat64
        {
        }
        public unsafe static partial class ShaderAtomicFp16Vector
        {
        }
        public unsafe static partial class ShaderAtomicInt64
        {
        }
        public unsafe static partial class ShaderBufferLoad
        {
            [DllImport("opengl32.dll", EntryPoint = "glMakeBufferResidentNV")]
            public static extern void GlMakeBufferResident(uint target, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeBufferNonResidentNV")]
            public static extern void GlMakeBufferNonResident(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsBufferResidentNV")]
            public static extern byte GlIsBufferResident(uint target);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeNamedBufferResidentNV")]
            public static extern void GlMakeNamedBufferResident(uint buffer, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glMakeNamedBufferNonResidentNV")]
            public static extern void GlMakeNamedBufferNonResident(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsNamedBufferResidentNV")]
            public static extern byte GlIsNamedBufferResident(uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetBufferParameterui64vNV")]
            public static extern void GlGetBufferParameterui64v(uint target, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetNamedBufferParameterui64vNV")]
            public static extern void GlGetNamedBufferParameterui64v(uint buffer, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetIntegerui64vNV")]
            public static extern void GlGetIntegerui64v(uint value, uint* result);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformui64NV")]
            public static extern void GlUniformui64(int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformui64vNV")]
            public static extern void GlUniformui64v(int location, int count, uint* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetUniformui64vNV")]
            public static extern void GlGetUniformui64v(uint program, int location, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformui64NV")]
            public static extern void GlProgramUniformui64(uint program, int location, uint value);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramUniformui64vNV")]
            public static extern void GlProgramUniformui64v(uint program, int location, int count, uint* value);
            
        }
        public unsafe static partial class ShaderBufferStore
        {
        }
        public unsafe static partial class ShaderStorageBufferObject
        {
        }
        public unsafe static partial class ShaderSubgroupPartitioned
        {
        }
        public unsafe static partial class ShaderTextureFootprint
        {
        }
        public unsafe static partial class ShaderThreadGroup
        {
        }
        public unsafe static partial class ShaderThreadShuffle
        {
        }
        public unsafe static partial class ShadingRateImage
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindShadingRateImageNV")]
            public static extern void GlBindShadingRateImage(uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetShadingRateImagePaletteNV")]
            public static extern void GlGetShadingRateImagePalette(uint viewport, uint entry, uint* rate);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetShadingRateSampleLocationivNV")]
            public static extern void GlGetShadingRateSampleLocationiv(uint rate, uint samples, uint index, int* location);
            
            [DllImport("opengl32.dll", EntryPoint = "glShadingRateImageBarrierNV")]
            public static extern void GlShadingRateImageBarrier(byte synchronize);
            
            [DllImport("opengl32.dll", EntryPoint = "glShadingRateImagePaletteNV")]
            public static extern void GlShadingRateImagePalette(uint viewport, uint first, int count, uint* rates);
            
            [DllImport("opengl32.dll", EntryPoint = "glShadingRateSampleOrderNV")]
            public static extern void GlShadingRateSampleOrder(uint order);
            
            [DllImport("opengl32.dll", EntryPoint = "glShadingRateSampleOrderCustomNV")]
            public static extern void GlShadingRateSampleOrderCustom(uint rate, uint samples, int* locations);
            
        }
        public unsafe static partial class StereoViewRendering
        {
        }
        public unsafe static partial class TessellationProgram5
        {
        }
        public unsafe static partial class TexgenEmboss
        {
        }
        public unsafe static partial class TexgenReflection
        {
        }
        public unsafe static partial class TextureBarrier
        {
            [DllImport("opengl32.dll", EntryPoint = "glTextureBarrierNV")]
            public static extern void GlTextureBarrier();
            
        }
        public unsafe static partial class TextureCompressionVtc
        {
        }
        public unsafe static partial class TextureEnvCombine4
        {
        }
        public unsafe static partial class TextureExpandNormal
        {
        }
        public unsafe static partial class TextureMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glTexImage2DMultisampleCoverageNV")]
            public static extern void GlTexImage2DMultisampleCoverage(uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, byte fixedSampleLocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexImage3DMultisampleCoverageNV")]
            public static extern void GlTexImage3DMultisampleCoverage(uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, byte fixedSampleLocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureImage2DMultisampleNV")]
            public static extern void GlTextureImage2DMultisample(uint texture, uint target, int samples, int internalFormat, int width, int height, byte fixedSampleLocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureImage3DMultisampleNV")]
            public static extern void GlTextureImage3DMultisample(uint texture, uint target, int samples, int internalFormat, int width, int height, int depth, byte fixedSampleLocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureImage2DMultisampleCoverageNV")]
            public static extern void GlTextureImage2DMultisampleCoverage(uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, byte fixedSampleLocations);
            
            [DllImport("opengl32.dll", EntryPoint = "glTextureImage3DMultisampleCoverageNV")]
            public static extern void GlTextureImage3DMultisampleCoverage(uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, byte fixedSampleLocations);
            
        }
        public unsafe static partial class TextureRectangle
        {
        }
        public unsafe static partial class TextureRectangleCompressed
        {
        }
        public unsafe static partial class TextureShader
        {
        }
        public unsafe static partial class TextureShader2
        {
        }
        public unsafe static partial class TextureShader3
        {
        }
        public unsafe static partial class TransformFeedback
        {
            [DllImport("opengl32.dll", EntryPoint = "glBeginTransformFeedbackNV")]
            public static extern void GlBeginTransformFeedback(uint primitiveMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndTransformFeedbackNV")]
            public static extern void GlEndTransformFeedback();
            
            [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackAttribsNV")]
            public static extern void GlTransformFeedbackAttribs(int count, int* attribs, uint bufferMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferRangeNV")]
            public static extern void GlBindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferOffsetNV")]
            public static extern void GlBindBufferOffset(uint target, uint index, uint buffer, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindBufferBaseNV")]
            public static extern void GlBindBufferBase(uint target, uint index, uint buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackVaryingsNV")]
            public static extern void GlTransformFeedbackVaryings(uint program, int count, int* locations, uint bufferMode);
            
            [DllImport("opengl32.dll", EntryPoint = "glActiveVaryingNV")]
            public static extern void GlActiveVarying(uint program, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVaryingLocationNV")]
            public static extern int GlGetVaryingLocation(uint program, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetActiveVaryingNV")]
            public static extern void GlGetActiveVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTransformFeedbackVaryingNV")]
            public static extern void GlGetTransformFeedbackVarying(uint program, uint index, int* location);
            
            [DllImport("opengl32.dll", EntryPoint = "glTransformFeedbackStreamAttribsNV")]
            public static extern void GlTransformFeedbackStreamAttribs(int count, int* attribs, int nbuffers, int* bufstreams, uint bufferMode);
            
        }
        public unsafe static partial class TransformFeedback2
        {
            [DllImport("opengl32.dll", EntryPoint = "glBindTransformFeedbackNV")]
            public static extern void GlBindTransformFeedback(uint target, uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteTransformFeedbacksNV")]
            public static extern void GlDeleteTransformFeedbacks(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenTransformFeedbacksNV")]
            public static extern void GlGenTransformFeedbacks(int n, uint* ids);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsTransformFeedbackNV")]
            public static extern byte GlIsTransformFeedback(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glPauseTransformFeedbackNV")]
            public static extern void GlPauseTransformFeedback();
            
            [DllImport("opengl32.dll", EntryPoint = "glResumeTransformFeedbackNV")]
            public static extern void GlResumeTransformFeedback();
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawTransformFeedbackNV")]
            public static extern void GlDrawTransformFeedback(uint mode, uint id);
            
        }
        public unsafe static partial class UniformBufferUnifiedMemory
        {
        }
        public unsafe static partial class VdpauInterop
        {
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUInitNV")]
            public static extern void GlVDPAUInit(void* vdpDevice, void* getProcAddress);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUFiniNV")]
            public static extern void GlVDPAUFini();
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAURegisterVideoSurfaceNV")]
            public static extern IntPtr GlVDPAURegisterVideoSurface(void* vdpSurface, uint target, int numTextureNames, uint* textureNames);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAURegisterOutputSurfaceNV")]
            public static extern IntPtr GlVDPAURegisterOutputSurface(void* vdpSurface, uint target, int numTextureNames, uint* textureNames);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUIsSurfaceNV")]
            public static extern byte GlVDPAUIsSurface(IntPtr surface);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUUnregisterSurfaceNV")]
            public static extern void GlVDPAUUnregisterSurface(IntPtr surface);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUGetSurfaceivNV")]
            public static extern void GlVDPAUGetSurfaceiv(IntPtr surface, uint pname, int count, int* length, int* values);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUSurfaceAccessNV")]
            public static extern void GlVDPAUSurfaceAccess(IntPtr surface, uint access);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUMapSurfacesNV")]
            public static extern void GlVDPAUMapSurfaces(int numSurfaces, IntPtr* surfaces);
            
            [DllImport("opengl32.dll", EntryPoint = "glVDPAUUnmapSurfacesNV")]
            public static extern void GlVDPAUUnmapSurfaces(int numSurface, IntPtr* surfaces);
            
        }
        public unsafe static partial class VdpauInterop2
        {
            [DllImport("opengl32.dll", EntryPoint = "glVDPAURegisterVideoSurfaceWithPictureStructureNV")]
            public static extern IntPtr GlVDPAURegisterVideoSurfaceWithPictureStructure(void* vdpSurface, uint target, int numTextureNames, uint* textureNames, byte isFrameStructure);
            
        }
        public unsafe static partial class VertexArrayRange
        {
            [DllImport("opengl32.dll", EntryPoint = "glFlushVertexArrayRangeNV")]
            public static extern void GlFlushVertexArrayRange();
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexArrayRangeNV")]
            public static extern void GlVertexArrayRange(int length, void* pointer);
            
        }
        public unsafe static partial class VertexArrayRange2
        {
        }
        public unsafe static partial class VertexAttribInteger64bit
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1i64NV")]
            public static extern void GlVertexAttribL1i64(uint index, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2i64NV")]
            public static extern void GlVertexAttribL2i64(uint index, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3i64NV")]
            public static extern void GlVertexAttribL3i64(uint index, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4i64NV")]
            public static extern void GlVertexAttribL4i64(uint index, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1i64vNV")]
            public static extern void GlVertexAttribL1i64v(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2i64vNV")]
            public static extern void GlVertexAttribL2i64v(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3i64vNV")]
            public static extern void GlVertexAttribL3i64v(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4i64vNV")]
            public static extern void GlVertexAttribL4i64v(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1ui64NV")]
            public static extern void GlVertexAttribL1ui64(uint index, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2ui64NV")]
            public static extern void GlVertexAttribL2ui64(uint index, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3ui64NV")]
            public static extern void GlVertexAttribL3ui64(uint index, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4ui64NV")]
            public static extern void GlVertexAttribL4ui64(uint index, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL1ui64vNV")]
            public static extern void GlVertexAttribL1ui64v(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL2ui64vNV")]
            public static extern void GlVertexAttribL2ui64v(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL3ui64vNV")]
            public static extern void GlVertexAttribL3ui64v(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribL4ui64vNV")]
            public static extern void GlVertexAttribL4ui64v(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribLi64vNV")]
            public static extern void GlGetVertexAttribLi64v(uint index, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribLui64vNV")]
            public static extern void GlGetVertexAttribLui64v(uint index, uint pname, uint* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribLFormatNV")]
            public static extern void GlVertexAttribLFormat(uint index, int size, uint type, int stride);
            
        }
        public unsafe static partial class VertexBufferUnifiedMemory
        {
            [DllImport("opengl32.dll", EntryPoint = "glBufferAddressRangeNV")]
            public static extern void GlBufferAddressRange(uint pname, uint index, uint address, IntPtr length);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexFormatNV")]
            public static extern void GlVertexFormat(int size, uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glNormalFormatNV")]
            public static extern void GlNormalFormat(uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glColorFormatNV")]
            public static extern void GlColorFormat(int size, uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glIndexFormatNV")]
            public static extern void GlIndexFormat(uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glTexCoordFormatNV")]
            public static extern void GlTexCoordFormat(int size, uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glEdgeFlagFormatNV")]
            public static extern void GlEdgeFlagFormat(int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glSecondaryColorFormatNV")]
            public static extern void GlSecondaryColorFormat(int size, uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glFogCoordFormatNV")]
            public static extern void GlFogCoordFormat(uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribFormatNV")]
            public static extern void GlVertexAttribFormat(uint index, int size, uint type, byte normalized, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribIFormatNV")]
            public static extern void GlVertexAttribIFormat(uint index, int size, uint type, int stride);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetIntegerui64i_vNV")]
            public static extern void GlGetIntegerui64i_v(uint value, uint index, uint* result);
            
        }
        public unsafe static partial class VertexProgram
        {
            [DllImport("opengl32.dll", EntryPoint = "glAreProgramsResidentNV")]
            public static extern byte GlAreProgramsResident(int n, uint* programs, byte* residences);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindProgramNV")]
            public static extern void GlBindProgram(uint target, uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteProgramsNV")]
            public static extern void GlDeletePrograms(int n, uint* programs);
            
            [DllImport("opengl32.dll", EntryPoint = "glExecuteProgramNV")]
            public static extern void GlExecuteProgram(uint target, uint id, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenProgramsNV")]
            public static extern void GlGenPrograms(int n, uint* programs);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramParameterdvNV")]
            public static extern void GlGetProgramParameterdv(uint target, uint index, uint pname, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramParameterfvNV")]
            public static extern void GlGetProgramParameterfv(uint target, uint index, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramivNV")]
            public static extern void GlGetProgramiv(uint id, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetProgramStringNV")]
            public static extern void GlGetProgramString(uint id, uint pname, byte* program);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetTrackMatrixivNV")]
            public static extern void GlGetTrackMatrixiv(uint target, uint address, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribdvNV")]
            public static extern void GlGetVertexAttribdv(uint index, uint pname, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribfvNV")]
            public static extern void GlGetVertexAttribfv(uint index, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribivNV")]
            public static extern void GlGetVertexAttribiv(uint index, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribPointervNV")]
            public static extern void GlGetVertexAttribPointerv(uint index, uint pname, void** pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsProgramNV")]
            public static extern byte GlIsProgram(uint id);
            
            [DllImport("opengl32.dll", EntryPoint = "glLoadProgramNV")]
            public static extern void GlLoadProgram(uint target, uint id, int len, byte* program);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameter4dNV")]
            public static extern void GlProgramParameter4d(uint target, uint index, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameter4dvNV")]
            public static extern void GlProgramParameter4dv(uint target, uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameter4fNV")]
            public static extern void GlProgramParameter4f(uint target, uint index, float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameter4fvNV")]
            public static extern void GlProgramParameter4fv(uint target, uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameters4dvNV")]
            public static extern void GlProgramParameters4dv(uint target, uint index, int count, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glProgramParameters4fvNV")]
            public static extern void GlProgramParameters4fv(uint target, uint index, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glRequestResidentProgramsNV")]
            public static extern void GlRequestResidentPrograms(int n, uint* programs);
            
            [DllImport("opengl32.dll", EntryPoint = "glTrackMatrixNV")]
            public static extern void GlTrackMatrix(uint target, uint address, uint matrix, uint transform);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribPointerNV")]
            public static extern void GlVertexAttribPointer(uint index, int fsize, uint type, int stride, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1dNV")]
            public static extern void GlVertexAttrib1d(uint index, double x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1dvNV")]
            public static extern void GlVertexAttrib1dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1fNV")]
            public static extern void GlVertexAttrib1f(uint index, float x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1fvNV")]
            public static extern void GlVertexAttrib1fv(uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1sNV")]
            public static extern void GlVertexAttrib1s(uint index, short x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib1svNV")]
            public static extern void GlVertexAttrib1sv(uint index, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2dNV")]
            public static extern void GlVertexAttrib2d(uint index, double x, double y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2dvNV")]
            public static extern void GlVertexAttrib2dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2fNV")]
            public static extern void GlVertexAttrib2f(uint index, float x, float y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2fvNV")]
            public static extern void GlVertexAttrib2fv(uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2sNV")]
            public static extern void GlVertexAttrib2s(uint index, short x, short y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib2svNV")]
            public static extern void GlVertexAttrib2sv(uint index, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3dNV")]
            public static extern void GlVertexAttrib3d(uint index, double x, double y, double z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3dvNV")]
            public static extern void GlVertexAttrib3dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3fNV")]
            public static extern void GlVertexAttrib3f(uint index, float x, float y, float z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3fvNV")]
            public static extern void GlVertexAttrib3fv(uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3sNV")]
            public static extern void GlVertexAttrib3s(uint index, short x, short y, short z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib3svNV")]
            public static extern void GlVertexAttrib3sv(uint index, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4dNV")]
            public static extern void GlVertexAttrib4d(uint index, double x, double y, double z, double w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4dvNV")]
            public static extern void GlVertexAttrib4dv(uint index, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4fNV")]
            public static extern void GlVertexAttrib4f(uint index, float x, float y, float z, float w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4fvNV")]
            public static extern void GlVertexAttrib4fv(uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4sNV")]
            public static extern void GlVertexAttrib4s(uint index, short x, short y, short z, short w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4svNV")]
            public static extern void GlVertexAttrib4sv(uint index, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4ubNV")]
            public static extern void GlVertexAttrib4ub(uint index, byte x, byte y, byte z, byte w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttrib4ubvNV")]
            public static extern void GlVertexAttrib4ubv(uint index, byte* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs1dvNV")]
            public static extern void GlVertexAttribs1dv(uint index, int count, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs1fvNV")]
            public static extern void GlVertexAttribs1fv(uint index, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs1svNV")]
            public static extern void GlVertexAttribs1sv(uint index, int count, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs2dvNV")]
            public static extern void GlVertexAttribs2dv(uint index, int count, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs2fvNV")]
            public static extern void GlVertexAttribs2fv(uint index, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs2svNV")]
            public static extern void GlVertexAttribs2sv(uint index, int count, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs3dvNV")]
            public static extern void GlVertexAttribs3dv(uint index, int count, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs3fvNV")]
            public static extern void GlVertexAttribs3fv(uint index, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs3svNV")]
            public static extern void GlVertexAttribs3sv(uint index, int count, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs4dvNV")]
            public static extern void GlVertexAttribs4dv(uint index, int count, double* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs4fvNV")]
            public static extern void GlVertexAttribs4fv(uint index, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs4svNV")]
            public static extern void GlVertexAttribs4sv(uint index, int count, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribs4ubvNV")]
            public static extern void GlVertexAttribs4ubv(uint index, int count, byte* v);
            
        }
        public unsafe static partial class VertexProgram11
        {
        }
        public unsafe static partial class VertexProgram2
        {
        }
        public unsafe static partial class VertexProgram2Option
        {
        }
        public unsafe static partial class VertexProgram3
        {
        }
        public unsafe static partial class VertexProgram4
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1iEXT")]
            public static extern void GlVertexAttribI1iEXT(uint index, int x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2iEXT")]
            public static extern void GlVertexAttribI2iEXT(uint index, int x, int y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3iEXT")]
            public static extern void GlVertexAttribI3iEXT(uint index, int x, int y, int z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4iEXT")]
            public static extern void GlVertexAttribI4iEXT(uint index, int x, int y, int z, int w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1uiEXT")]
            public static extern void GlVertexAttribI1uiEXT(uint index, uint x);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2uiEXT")]
            public static extern void GlVertexAttribI2uiEXT(uint index, uint x, uint y);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3uiEXT")]
            public static extern void GlVertexAttribI3uiEXT(uint index, uint x, uint y, uint z);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4uiEXT")]
            public static extern void GlVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1ivEXT")]
            public static extern void GlVertexAttribI1ivEXT(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2ivEXT")]
            public static extern void GlVertexAttribI2ivEXT(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3ivEXT")]
            public static extern void GlVertexAttribI3ivEXT(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4ivEXT")]
            public static extern void GlVertexAttribI4ivEXT(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI1uivEXT")]
            public static extern void GlVertexAttribI1uivEXT(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI2uivEXT")]
            public static extern void GlVertexAttribI2uivEXT(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI3uivEXT")]
            public static extern void GlVertexAttribI3uivEXT(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4uivEXT")]
            public static extern void GlVertexAttribI4uivEXT(uint index, uint* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4bvEXT")]
            public static extern void GlVertexAttribI4bvEXT(uint index, sbyte* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4svEXT")]
            public static extern void GlVertexAttribI4svEXT(uint index, short* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4ubvEXT")]
            public static extern void GlVertexAttribI4ubvEXT(uint index, byte* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribI4usvEXT")]
            public static extern void GlVertexAttribI4usvEXT(uint index, ushort* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribIPointerEXT")]
            public static extern void GlVertexAttribIPointerEXT(uint index, int size, uint type, int stride, void* pointer);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribIivEXT")]
            public static extern void GlGetVertexAttribIivEXT(uint index, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVertexAttribIuivEXT")]
            public static extern void GlGetVertexAttribIuivEXT(uint index, uint pname, uint* parameters);
            
        }
        public unsafe static partial class VideoCapture
        {
            [DllImport("opengl32.dll", EntryPoint = "glBeginVideoCaptureNV")]
            public static extern void GlBeginVideoCapture(uint video_capture_slot);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindVideoCaptureStreamBufferNV")]
            public static extern void GlBindVideoCaptureStreamBuffer(uint video_capture_slot, uint stream, uint frame_region, IntPtr offset);
            
            [DllImport("opengl32.dll", EntryPoint = "glBindVideoCaptureStreamTextureNV")]
            public static extern void GlBindVideoCaptureStreamTexture(uint video_capture_slot, uint stream, uint frame_region, uint target, uint texture);
            
            [DllImport("opengl32.dll", EntryPoint = "glEndVideoCaptureNV")]
            public static extern void GlEndVideoCapture(uint video_capture_slot);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideoCaptureivNV")]
            public static extern void GlGetVideoCaptureiv(uint video_capture_slot, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideoCaptureStreamivNV")]
            public static extern void GlGetVideoCaptureStreamiv(uint video_capture_slot, uint stream, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideoCaptureStreamfvNV")]
            public static extern void GlGetVideoCaptureStreamfv(uint video_capture_slot, uint stream, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetVideoCaptureStreamdvNV")]
            public static extern void GlGetVideoCaptureStreamdv(uint video_capture_slot, uint stream, uint pname, double* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glVideoCaptureNV")]
            public static extern uint GlVideoCapture(uint video_capture_slot, uint* sequence_num, uint* capture_time);
            
            [DllImport("opengl32.dll", EntryPoint = "glVideoCaptureStreamParameterivNV")]
            public static extern void GlVideoCaptureStreamParameteriv(uint video_capture_slot, uint stream, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glVideoCaptureStreamParameterfvNV")]
            public static extern void GlVideoCaptureStreamParameterfv(uint video_capture_slot, uint stream, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glVideoCaptureStreamParameterdvNV")]
            public static extern void GlVideoCaptureStreamParameterdv(uint video_capture_slot, uint stream, uint pname, double* parameters);
            
        }
        public unsafe static partial class ViewportArray2
        {
        }
        public unsafe static partial class ViewportSwizzle
        {
            [DllImport("opengl32.dll", EntryPoint = "glViewportSwizzleNV")]
            public static extern void GlViewportSwizzle(uint index, uint swizzlex, uint swizzley, uint swizzlez, uint swizzlew);
            
        }
    }
}
