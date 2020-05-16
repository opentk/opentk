using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGLES2.Extensions
{
    public static partial class NV
    {
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
        public unsafe static partial class ClipSpaceWScaling
        {
            [DllImport("opengl32.dll", EntryPoint = "glViewportPositionWScaleNV")]
            public static extern void GlViewportPositionWScale(uint index, float xcoeff, float ycoeff);
            
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
        public unsafe static partial class ConservativeRasterPreSnap
        {
        }
        public unsafe static partial class ConservativeRasterPreSnapTriangles
        {
            [DllImport("opengl32.dll", EntryPoint = "glConservativeRasterParameteriNV")]
            public static extern void GlConservativeRasterParameteri(uint pname, int param);
            
        }
        public unsafe static partial class CopyBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glCopyBufferSubDataNV")]
            public static extern void GlCopyBufferSubData(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            
        }
        public unsafe static partial class CoverageSample
        {
            [DllImport("opengl32.dll", EntryPoint = "glCoverageMaskNV")]
            public static extern void GlCoverageMask(byte mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glCoverageOperationNV")]
            public static extern void GlCoverageOperation(uint operation);
            
        }
        public unsafe static partial class DepthNonlinear
        {
        }
        public unsafe static partial class DrawBuffers
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawBuffersNV")]
            public static extern void GlDrawBuffers(int n, uint* bufs);
            
        }
        public unsafe static partial class DrawInstanced
        {
            [DllImport("opengl32.dll", EntryPoint = "glDrawArraysInstancedNV")]
            public static extern void GlDrawArraysInstanced(uint mode, int first, int count, int primcount);
            
            [DllImport("opengl32.dll", EntryPoint = "glDrawElementsInstancedNV")]
            public static extern void GlDrawElementsInstanced(uint mode, int count, uint type, void* indices, int primcount);
            
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
        public unsafe static partial class ExplicitAttribLocation
        {
        }
        public unsafe static partial class FboColorAttachments
        {
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
        public unsafe static partial class FragmentCoverageToColor
        {
            [DllImport("opengl32.dll", EntryPoint = "glFragmentCoverageColorNV")]
            public static extern void GlFragmentCoverageColor(uint color);
            
        }
        public unsafe static partial class FragmentShaderBarycentric
        {
        }
        public unsafe static partial class FragmentShaderInterlock
        {
        }
        public unsafe static partial class FramebufferBlit
        {
            [DllImport("opengl32.dll", EntryPoint = "glBlitFramebufferNV")]
            public static extern void GlBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
            
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
        public unsafe static partial class FramebufferMultisample
        {
            [DllImport("opengl32.dll", EntryPoint = "glRenderbufferStorageMultisampleNV")]
            public static extern void GlRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
            
        }
        public unsafe static partial class GenerateMipmapSrgb
        {
        }
        public unsafe static partial class GeometryShaderPassthrough
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
        public unsafe static partial class ImageFormats
        {
        }
        public unsafe static partial class InstancedArrays
        {
            [DllImport("opengl32.dll", EntryPoint = "glVertexAttribDivisorNV")]
            public static extern void GlVertexAttribDivisor(uint index, uint divisor);
            
        }
        public unsafe static partial class InternalformatSampleQuery
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetInternalformatSampleivNV")]
            public static extern void GlGetInternalformatSampleiv(uint target, uint internalformat, int samples, uint pname, int count, int* parameters);
            
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
        public unsafe static partial class NonSquareMatrices
        {
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x3fvNV")]
            public static extern void GlUniformMatrix2x3fv(int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x2fvNV")]
            public static extern void GlUniformMatrix3x2fv(int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix2x4fvNV")]
            public static extern void GlUniformMatrix2x4fv(int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x2fvNV")]
            public static extern void GlUniformMatrix4x2fv(int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix3x4fvNV")]
            public static extern void GlUniformMatrix3x4fv(int location, int count, byte transpose, float* value);
            
            [DllImport("opengl32.dll", EntryPoint = "glUniformMatrix4x3fvNV")]
            public static extern void GlUniformMatrix4x3fv(int location, int count, byte transpose, float* value);
            
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
        public unsafe static partial class PixelBufferObject
        {
        }
        public unsafe static partial class PolygonMode
        {
            [DllImport("opengl32.dll", EntryPoint = "glPolygonModeNV")]
            public static extern void GlPolygonMode(uint face, uint mode);
            
        }
        public unsafe static partial class ReadBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glReadBufferNV")]
            public static extern void GlReadBuffer(uint mode);
            
        }
        public unsafe static partial class ReadBufferFront
        {
        }
        public unsafe static partial class ReadDepth
        {
        }
        public unsafe static partial class ReadDepthStencil
        {
        }
        public unsafe static partial class ReadStencil
        {
        }
        public unsafe static partial class RepresentativeFragmentTest
        {
        }
        public unsafe static partial class SrgbFormats
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
        public unsafe static partial class ShaderAtomicFp16Vector
        {
        }
        public unsafe static partial class ShaderNoperspectiveInterpolation
        {
        }
        public unsafe static partial class ShaderSubgroupPartitioned
        {
        }
        public unsafe static partial class ShaderTextureFootprint
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
        public unsafe static partial class ShadowSamplersArray
        {
        }
        public unsafe static partial class ShadowSamplersCube
        {
        }
        public unsafe static partial class StereoViewRendering
        {
        }
        public unsafe static partial class TextureBorderClamp
        {
        }
        public unsafe static partial class TextureCompressionS3tcUpdate
        {
        }
        public unsafe static partial class TextureNpot2dMipmap
        {
        }
        public unsafe static partial class ViewportArray
        {
            [DllImport("opengl32.dll", EntryPoint = "glViewportArrayvNV")]
            public static extern void GlViewportArrayv(uint first, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedfNV")]
            public static extern void GlViewportIndexedf(uint index, float x, float y, float w, float h);
            
            [DllImport("opengl32.dll", EntryPoint = "glViewportIndexedfvNV")]
            public static extern void GlViewportIndexedfv(uint index, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorArrayvNV")]
            public static extern void GlScissorArrayv(uint first, int count, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorIndexedNV")]
            public static extern void GlScissorIndexed(uint index, int left, int bottom, int width, int height);
            
            [DllImport("opengl32.dll", EntryPoint = "glScissorIndexedvNV")]
            public static extern void GlScissorIndexedv(uint index, int* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeArrayfvNV")]
            public static extern void GlDepthRangeArrayfv(uint first, int count, float* v);
            
            [DllImport("opengl32.dll", EntryPoint = "glDepthRangeIndexedfNV")]
            public static extern void GlDepthRangeIndexedf(uint index, float n, float f);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFloati_vNV")]
            public static extern void GlGetFloati_v(uint target, uint index, float* data);
            
            [DllImport("opengl32.dll", EntryPoint = "glEnableiNV")]
            public static extern void GlEnablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glDisableiNV")]
            public static extern void GlDisablei(uint target, uint index);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsEnablediNV")]
            public static extern byte GlIsEnabledi(uint target, uint index);
            
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
