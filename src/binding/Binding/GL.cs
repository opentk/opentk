using System;
namespace FooBar
{
    public static partial class GL
    {
        static unsafe void glAccum(AccumOp op, float value) => instance.glAccum(op, value);
        
        static unsafe void glActiveProgramEXT(uint program) => instance.glActiveProgramEXT(program);
        
        static unsafe void glActiveShaderProgram(uint pipeline, uint program) => instance.glActiveShaderProgram(pipeline, program);
        
        static unsafe void glActiveShaderProgramEXT(uint pipeline, uint program) => instance.glActiveShaderProgramEXT(pipeline, program);
        
        static unsafe void glActiveStencilFaceEXT(StencilFaceDirection face) => instance.glActiveStencilFaceEXT(face);
        
        static unsafe void glActiveTexture(TextureUnit texture) => instance.glActiveTexture(texture);
        
        static unsafe void glActiveTextureARB(TextureUnit texture) => instance.glActiveTextureARB(texture);
        
        static unsafe void glActiveVaryingNV(uint program, char * name) => instance.glActiveVaryingNV(program, name);
        
        static unsafe void glAlphaFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod) => instance.glAlphaFragmentOp1ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
        
        static unsafe void glAlphaFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod) => instance.glAlphaFragmentOp2ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
        
        static unsafe void glAlphaFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod) => instance.glAlphaFragmentOp3ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
        
        static unsafe void glAlphaFunc(AlphaFunction func, float REF) => instance.glAlphaFunc(func, REF);
        
        static unsafe void glAlphaFuncx(AlphaFunction func, int REF) => instance.glAlphaFuncx(func, REF);
        
        static unsafe void glAlphaFuncxOES(AlphaFunction func, int REF) => instance.glAlphaFuncxOES(func, REF);
        
        static unsafe void glApplyFramebufferAttachmentCMAAINTEL() => instance.glApplyFramebufferAttachmentCMAAINTEL();
        
        static unsafe void glApplyTextureEXT(LightTextureModeEXT mode) => instance.glApplyTextureEXT(mode);
        
        static unsafe bool glAcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout) => instance.glAcquireKeyedMutexWin32EXT(memory, key, timeout);
        
        static unsafe bool glAreProgramsResidentNV(uint n, uint * programs, bool * residences) => instance.glAreProgramsResidentNV(n, programs, residences);
        
        static unsafe bool glAreTexturesResident(uint n, uint * textures, bool * residences) => instance.glAreTexturesResident(n, textures, residences);
        
        static unsafe bool glAreTexturesResidentEXT(uint n, uint * textures, bool * residences) => instance.glAreTexturesResidentEXT(n, textures, residences);
        
        static unsafe void glArrayElement(int i) => instance.glArrayElement(i);
        
        static unsafe void glArrayElementEXT(int i) => instance.glArrayElementEXT(i);
        
        static unsafe void glArrayObjectATI(EnableCap array, int size, ScalarType type, uint stride, uint buffer, uint offset) => instance.glArrayObjectATI(array, size, type, stride, buffer, offset);
        
        static unsafe uint glAsyncCopyBufferSubDataNVX(uint waitSemaphoreCount, uint * waitSemaphoreArray, ulong * fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size, uint signalSemaphoreCount, uint * signalSemaphoreArray, ulong * signalValueArray) => instance.glAsyncCopyBufferSubDataNVX(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
        
        static unsafe void glAsyncMarkerSGIX(uint marker) => instance.glAsyncMarkerSGIX(marker);
        
        static unsafe void glAttachObjectARB(uint containerObj, uint obj) => instance.glAttachObjectARB(containerObj, obj);
        
        static unsafe void glAttachShader(uint program, uint shader) => instance.glAttachShader(program, shader);
        
        static unsafe void glBegin(PrimitiveType mode) => instance.glBegin(mode);
        
        static unsafe void glBeginConditionalRender(uint id, ConditionalRenderMode mode) => instance.glBeginConditionalRender(id, mode);
        
        static unsafe void glBeginConditionalRenderNV(uint id, ConditionalRenderMode mode) => instance.glBeginConditionalRenderNV(id, mode);
        
        static unsafe void glBeginConditionalRenderNVX(uint id) => instance.glBeginConditionalRenderNVX(id);
        
        static unsafe void glBeginFragmentShaderATI() => instance.glBeginFragmentShaderATI();
        
        static unsafe void glBeginOcclusionQueryNV(uint id) => instance.glBeginOcclusionQueryNV(id);
        
        static unsafe void glBeginPerfMonitorAMD(uint monitor) => instance.glBeginPerfMonitorAMD(monitor);
        
        static unsafe void glBeginPerfQueryINTEL(uint queryHandle) => instance.glBeginPerfQueryINTEL(queryHandle);
        
        static unsafe void glBeginQuery(QueryTarget target, uint id) => instance.glBeginQuery(target, id);
        
        static unsafe void glBeginQueryEXT(QueryTarget target, uint id) => instance.glBeginQueryEXT(target, id);
        
        static unsafe void glBeginQueryIndexed(QueryTarget target, uint index, uint id) => instance.glBeginQueryIndexed(target, index, id);
        
        static unsafe void glBeginTransformFeedback(PrimitiveType primitiveMode) => instance.glBeginTransformFeedback(primitiveMode);
        
        static unsafe void glBeginTransformFeedbackEXT(PrimitiveType primitiveMode) => instance.glBeginTransformFeedbackEXT(primitiveMode);
        
        static unsafe void glBeginTransformFeedbackNV(PrimitiveType primitiveMode) => instance.glBeginTransformFeedbackNV(primitiveMode);
        
        static unsafe void glBeginVertexShaderEXT() => instance.glBeginVertexShaderEXT();
        
        static unsafe void glBeginVideoCaptureNV(uint video_capture_slot) => instance.glBeginVideoCaptureNV(video_capture_slot);
        
        static unsafe void glBindAttribLocation(uint program, uint index, char * name) => instance.glBindAttribLocation(program, index, name);
        
        static unsafe void glBindAttribLocationARB(uint programObj, uint index, char * name) => instance.glBindAttribLocationARB(programObj, index, name);
        
        static unsafe void glBindBuffer(BufferTargetARB target, uint buffer) => instance.glBindBuffer(target, buffer);
        
        static unsafe void glBindBufferARB(BufferTargetARB target, uint buffer) => instance.glBindBufferARB(target, buffer);
        
        static unsafe void glBindBufferBase(BufferTargetARB target, uint index, uint buffer) => instance.glBindBufferBase(target, index, buffer);
        
        static unsafe void glBindBufferBaseEXT(BufferTargetARB target, uint index, uint buffer) => instance.glBindBufferBaseEXT(target, index, buffer);
        
        static unsafe void glBindBufferBaseNV(BufferTargetARB target, uint index, uint buffer) => instance.glBindBufferBaseNV(target, index, buffer);
        
        static unsafe void glBindBufferOffsetEXT(BufferTargetARB target, uint index, uint buffer, IntPtr offset) => instance.glBindBufferOffsetEXT(target, index, buffer, offset);
        
        static unsafe void glBindBufferOffsetNV(BufferTargetARB target, uint index, uint buffer, IntPtr offset) => instance.glBindBufferOffsetNV(target, index, buffer, offset);
        
        static unsafe void glBindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, UIntPtr size) => instance.glBindBufferRange(target, index, buffer, offset, size);
        
        static unsafe void glBindBufferRangeEXT(BufferTargetARB target, uint index, uint buffer, IntPtr offset, UIntPtr size) => instance.glBindBufferRangeEXT(target, index, buffer, offset, size);
        
        static unsafe void glBindBufferRangeNV(BufferTargetARB target, uint index, uint buffer, IntPtr offset, UIntPtr size) => instance.glBindBufferRangeNV(target, index, buffer, offset, size);
        
        static unsafe void glBindBuffersBase(BufferTargetARB target, uint first, uint count, uint * buffers) => instance.glBindBuffersBase(target, first, count, buffers);
        
        static unsafe void glBindBuffersRange(BufferTargetARB target, uint first, uint count, uint * buffers, IntPtr * offsets, UIntPtr * sizes) => instance.glBindBuffersRange(target, first, count, buffers, offsets, sizes);
        
        static unsafe void glBindFragDataLocation(uint program, uint color, char * name) => instance.glBindFragDataLocation(program, color, name);
        
        static unsafe void glBindFragDataLocationEXT(uint program, uint color, char * name) => instance.glBindFragDataLocationEXT(program, color, name);
        
        static unsafe void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char * name) => instance.glBindFragDataLocationIndexed(program, colorNumber, index, name);
        
        static unsafe void glBindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, char * name) => instance.glBindFragDataLocationIndexedEXT(program, colorNumber, index, name);
        
        static unsafe void glBindFragmentShaderATI(uint id) => instance.glBindFragmentShaderATI(id);
        
        static unsafe void glBindFramebuffer(FramebufferTarget target, uint framebuffer) => instance.glBindFramebuffer(target, framebuffer);
        
        static unsafe void glBindFramebufferEXT(FramebufferTarget target, uint framebuffer) => instance.glBindFramebufferEXT(target, framebuffer);
        
        static unsafe void glBindFramebufferOES(FramebufferTarget target, uint framebuffer) => instance.glBindFramebufferOES(target, framebuffer);
        
        static unsafe void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format) => instance.glBindImageTexture(unit, texture, level, layered, layer, access, format);
        
        static unsafe void glBindImageTextureEXT(uint index, uint texture, int level, bool layered, int layer, BufferAccessARB access, int format) => instance.glBindImageTextureEXT(index, texture, level, layered, layer, access, format);
        
        static unsafe void glBindImageTextures(uint first, uint count, uint * textures) => instance.glBindImageTextures(first, count, textures);
        
        static unsafe uint glBindLightParameterEXT(LightName light, LightParameter value) => instance.glBindLightParameterEXT(light, value);
        
        static unsafe uint glBindMaterialParameterEXT(MaterialFace face, MaterialParameter value) => instance.glBindMaterialParameterEXT(face, value);
        
        static unsafe void glBindMultiTextureEXT(TextureUnit texunit, TextureTarget target, uint texture) => instance.glBindMultiTextureEXT(texunit, target, texture);
        
        static unsafe uint glBindParameterEXT(VertexShaderParameterEXT value) => instance.glBindParameterEXT(value);
        
        static unsafe void glBindProgramARB(ProgramTargetARB target, uint program) => instance.glBindProgramARB(target, program);
        
        static unsafe void glBindProgramNV(VertexAttribEnumNV target, uint id) => instance.glBindProgramNV(target, id);
        
        static unsafe void glBindProgramPipeline(uint pipeline) => instance.glBindProgramPipeline(pipeline);
        
        static unsafe void glBindProgramPipelineEXT(uint pipeline) => instance.glBindProgramPipelineEXT(pipeline);
        
        static unsafe void glBindRenderbuffer(RenderbufferTarget target, uint renderbuffer) => instance.glBindRenderbuffer(target, renderbuffer);
        
        static unsafe void glBindRenderbufferEXT(RenderbufferTarget target, uint renderbuffer) => instance.glBindRenderbufferEXT(target, renderbuffer);
        
        static unsafe void glBindRenderbufferOES(RenderbufferTarget target, uint renderbuffer) => instance.glBindRenderbufferOES(target, renderbuffer);
        
        static unsafe void glBindSampler(uint unit, uint sampler) => instance.glBindSampler(unit, sampler);
        
        static unsafe void glBindSamplers(uint first, uint count, uint * samplers) => instance.glBindSamplers(first, count, samplers);
        
        static unsafe void glBindShadingRateImageNV(uint texture) => instance.glBindShadingRateImageNV(texture);
        
        static unsafe uint glBindTexGenParameterEXT(TextureUnit unit, TextureCoordName coord, TextureGenParameter value) => instance.glBindTexGenParameterEXT(unit, coord, value);
        
        static unsafe void glBindTexture(TextureTarget target, uint texture) => instance.glBindTexture(target, texture);
        
        static unsafe void glBindTextureEXT(TextureTarget target, uint texture) => instance.glBindTextureEXT(target, texture);
        
        static unsafe void glBindTextureUnit(uint unit, uint texture) => instance.glBindTextureUnit(unit, texture);
        
        static unsafe uint glBindTextureUnitParameterEXT(TextureUnit unit, VertexShaderTextureUnitParameter value) => instance.glBindTextureUnitParameterEXT(unit, value);
        
        static unsafe void glBindTextures(uint first, uint count, uint * textures) => instance.glBindTextures(first, count, textures);
        
        static unsafe void glBindTransformFeedback(BindTransformFeedbackTarget target, uint id) => instance.glBindTransformFeedback(target, id);
        
        static unsafe void glBindTransformFeedbackNV(BufferTargetARB target, uint id) => instance.glBindTransformFeedbackNV(target, id);
        
        static unsafe void glBindVertexArray(uint array) => instance.glBindVertexArray(array);
        
        static unsafe void glBindVertexArrayAPPLE(uint array) => instance.glBindVertexArrayAPPLE(array);
        
        static unsafe void glBindVertexArrayOES(uint array) => instance.glBindVertexArrayOES(array);
        
        static unsafe void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, uint stride) => instance.glBindVertexBuffer(bindingindex, buffer, offset, stride);
        
        static unsafe void glBindVertexBuffers(uint first, uint count, uint * buffers, IntPtr * offsets, uint * strides) => instance.glBindVertexBuffers(first, count, buffers, offsets, strides);
        
        static unsafe void glBindVertexShaderEXT(uint id) => instance.glBindVertexShaderEXT(id);
        
        static unsafe void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz) => instance.glBinormal3bEXT(bx, by, bz);
        
        static unsafe void glBinormal3bvEXT(sbyte * v) => instance.glBinormal3bvEXT(v);
        
        static unsafe void glBinormal3dEXT(double bx, double by, double bz) => instance.glBinormal3dEXT(bx, by, bz);
        
        static unsafe void glBinormal3dvEXT(double * v) => instance.glBinormal3dvEXT(v);
        
        static unsafe void glBinormal3fEXT(float bx, float by, float bz) => instance.glBinormal3fEXT(bx, by, bz);
        
        static unsafe void glBinormal3fvEXT(float * v) => instance.glBinormal3fvEXT(v);
        
        static unsafe void glBinormal3iEXT(int bx, int by, int bz) => instance.glBinormal3iEXT(bx, by, bz);
        
        static unsafe void glBinormal3ivEXT(int * v) => instance.glBinormal3ivEXT(v);
        
        static unsafe void glBinormal3sEXT(short bx, short by, short bz) => instance.glBinormal3sEXT(bx, by, bz);
        
        static unsafe void glBinormal3svEXT(short * v) => instance.glBinormal3svEXT(v);
        
        static unsafe void glBinormalPointerEXT(BinormalPointerTypeEXT type, uint stride, void * pointer) => instance.glBinormalPointerEXT(type, stride, pointer);
        
        static unsafe void glBitmap(uint width, uint height, float xorig, float yorig, float xmove, float ymove, byte * bitmap) => instance.glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
        
        static unsafe void glBitmapxOES(uint width, uint height, int xorig, int yorig, int xmove, int ymove, byte * bitmap) => instance.glBitmapxOES(width, height, xorig, yorig, xmove, ymove, bitmap);
        
        static unsafe void glBlendBarrier() => instance.glBlendBarrier();
        
        static unsafe void glBlendBarrierKHR() => instance.glBlendBarrierKHR();
        
        static unsafe void glBlendBarrierNV() => instance.glBlendBarrierNV();
        
        static unsafe void glBlendColor(float red, float green, float blue, float alpha) => instance.glBlendColor(red, green, blue, alpha);
        
        static unsafe void glBlendColorEXT(float red, float green, float blue, float alpha) => instance.glBlendColorEXT(red, green, blue, alpha);
        
        static unsafe void glBlendColorxOES(int red, int green, int blue, int alpha) => instance.glBlendColorxOES(red, green, blue, alpha);
        
        static unsafe void glBlendEquation(BlendEquationModeEXT mode) => instance.glBlendEquation(mode);
        
        static unsafe void glBlendEquationEXT(BlendEquationModeEXT mode) => instance.glBlendEquationEXT(mode);
        
        static unsafe void glBlendEquationIndexedAMD(uint buf, BlendEquationModeEXT mode) => instance.glBlendEquationIndexedAMD(buf, mode);
        
        static unsafe void glBlendEquationOES(BlendEquationModeEXT mode) => instance.glBlendEquationOES(mode);
        
        static unsafe void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparate(modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationSeparateEXT(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparateEXT(modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationSeparateIndexedAMD(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparateIndexedAMD(buf, modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationSeparateOES(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparateOES(modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationSeparateiARB(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparateiARB(buf, modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationSeparateiEXT(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparateiEXT(buf, modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationSeparateiOES(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => instance.glBlendEquationSeparateiOES(buf, modeRGB, modeAlpha);
        
        static unsafe void glBlendEquationi(uint buf, BlendEquationModeEXT mode) => instance.glBlendEquationi(buf, mode);
        
        static unsafe void glBlendEquationiARB(uint buf, BlendEquationModeEXT mode) => instance.glBlendEquationiARB(buf, mode);
        
        static unsafe void glBlendEquationiEXT(uint buf, BlendEquationModeEXT mode) => instance.glBlendEquationiEXT(buf, mode);
        
        static unsafe void glBlendEquationiOES(uint buf, BlendEquationModeEXT mode) => instance.glBlendEquationiOES(buf, mode);
        
        static unsafe void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => instance.glBlendFunc(sfactor, dfactor);
        
        static unsafe void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => instance.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        
        static unsafe void glBlendFuncSeparateEXT(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => instance.glBlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        
        static unsafe void glBlendFuncSeparateINGR(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha) => instance.glBlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        
        static unsafe void glBlendFuncSeparateIndexedAMD(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => instance.glBlendFuncSeparateIndexedAMD(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        
        static unsafe void glBlendFuncSeparateOES(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => instance.glBlendFuncSeparateOES(srcRGB, dstRGB, srcAlpha, dstAlpha);
        
        static unsafe void glBlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => instance.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        
        static unsafe void glBlendFuncSeparateiARB(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => instance.glBlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        
        static unsafe void glBlendFuncSeparateiEXT(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => instance.glBlendFuncSeparateiEXT(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        
        static unsafe void glBlendFuncSeparateiOES(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => instance.glBlendFuncSeparateiOES(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        
        static unsafe void glBlendFunci(uint buf, BlendingFactor src, BlendingFactor dst) => instance.glBlendFunci(buf, src, dst);
        
        static unsafe void glBlendFunciARB(uint buf, BlendingFactor src, BlendingFactor dst) => instance.glBlendFunciARB(buf, src, dst);
        
        static unsafe void glBlendFunciEXT(uint buf, BlendingFactor src, BlendingFactor dst) => instance.glBlendFunciEXT(buf, src, dst);
        
        static unsafe void glBlendFunciOES(uint buf, BlendingFactor src, BlendingFactor dst) => instance.glBlendFunciOES(buf, src, dst);
        
        static unsafe void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter) => instance.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        
        static unsafe void glBlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter) => instance.glBlitFramebufferANGLE(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        
        static unsafe void glBlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter) => instance.glBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        
        static unsafe void glBlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter) => instance.glBlitFramebufferNV(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        
        static unsafe void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter) => instance.glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        
        static unsafe void glBufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset) => instance.glBufferAttachMemoryNV(target, memory, offset);
        
        static unsafe void glBufferData(BufferTargetARB target, UIntPtr size, void * data, BufferUsageARB usage) => instance.glBufferData(target, size, data, usage);
        
        static unsafe void glBufferDataARB(BufferTargetARB target, UIntPtr size, void * data, BufferUsageARB usage) => instance.glBufferDataARB(target, size, data, usage);
        
        static unsafe void glBufferStorage(BufferStorageTarget target, UIntPtr size, void * data, uint flags) => instance.glBufferStorage(target, size, data, flags);
        
        static unsafe void glBufferStorageEXT(BufferStorageTarget target, UIntPtr size, void * data, uint flags) => instance.glBufferStorageEXT(target, size, data, flags);
        
        static unsafe void glBufferStorageMemEXT(BufferTargetARB target, UIntPtr size, uint memory, ulong offset) => instance.glBufferStorageMemEXT(target, size, memory, offset);
        
        static unsafe void glBufferSubData(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data) => instance.glBufferSubData(target, offset, size, data);
        
        static unsafe void glBufferSubDataARB(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data) => instance.glBufferSubDataARB(target, offset, size, data);
        
        static unsafe void glCallCommandListNV(uint list) => instance.glCallCommandListNV(list);
        
        static unsafe void glCallList(uint list) => instance.glCallList(list);
        
        static unsafe void glCallLists(uint n, ListNameType type, void * lists) => instance.glCallLists(n, type, lists);
        
        static unsafe FramebufferStatus glCheckFramebufferStatus(FramebufferTarget target) => instance.glCheckFramebufferStatus(target);
        
        static unsafe FramebufferStatus glCheckFramebufferStatusEXT(FramebufferTarget target) => instance.glCheckFramebufferStatusEXT(target);
        
        static unsafe FramebufferStatus glCheckFramebufferStatusOES(FramebufferTarget target) => instance.glCheckFramebufferStatusOES(target);
        
        static unsafe FramebufferStatus glCheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target) => instance.glCheckNamedFramebufferStatus(framebuffer, target);
        
        static unsafe FramebufferStatus glCheckNamedFramebufferStatusEXT(uint framebuffer, FramebufferTarget target) => instance.glCheckNamedFramebufferStatusEXT(framebuffer, target);
        
        static unsafe void glClampColor(ClampColorTargetARB target, ClampColorModeARB clamp) => instance.glClampColor(target, clamp);
        
        static unsafe void glClampColorARB(ClampColorTargetARB target, ClampColorModeARB clamp) => instance.glClampColorARB(target, clamp);
        
        static unsafe void glClear(uint mask) => instance.glClear(mask);
        
        static unsafe void glClearAccum(float red, float green, float blue, float alpha) => instance.glClearAccum(red, green, blue, alpha);
        
        static unsafe void glClearAccumxOES(int red, int green, int blue, int alpha) => instance.glClearAccumxOES(red, green, blue, alpha);
        
        static unsafe void glClearBufferData(BufferStorageTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, void * data) => instance.glClearBufferData(target, internalformat, format, type, data);
        
        static unsafe void glClearBufferSubData(BufferTargetARB target, InternalFormat internalformat, IntPtr offset, UIntPtr size, PixelFormat format, PixelType type, void * data) => instance.glClearBufferSubData(target, internalformat, offset, size, format, type, data);
        
        static unsafe void glClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil) => instance.glClearBufferfi(buffer, drawbuffer, depth, stencil);
        
        static unsafe void glClearBufferfv(Buffer buffer, int drawbuffer, float * value) => instance.glClearBufferfv(buffer, drawbuffer, value);
        
        static unsafe void glClearBufferiv(Buffer buffer, int drawbuffer, int * value) => instance.glClearBufferiv(buffer, drawbuffer, value);
        
        static unsafe void glClearBufferuiv(Buffer buffer, int drawbuffer, uint * value) => instance.glClearBufferuiv(buffer, drawbuffer, value);
        
        static unsafe void glClearColor(float red, float green, float blue, float alpha) => instance.glClearColor(red, green, blue, alpha);
        
        static unsafe void glClearColorIiEXT(int red, int green, int blue, int alpha) => instance.glClearColorIiEXT(red, green, blue, alpha);
        
        static unsafe void glClearColorIuiEXT(uint red, uint green, uint blue, uint alpha) => instance.glClearColorIuiEXT(red, green, blue, alpha);
        
        static unsafe void glClearColorx(int red, int green, int blue, int alpha) => instance.glClearColorx(red, green, blue, alpha);
        
        static unsafe void glClearColorxOES(int red, int green, int blue, int alpha) => instance.glClearColorxOES(red, green, blue, alpha);
        
        static unsafe void glClearDepth(double depth) => instance.glClearDepth(depth);
        
        static unsafe void glClearDepthdNV(double depth) => instance.glClearDepthdNV(depth);
        
        static unsafe void glClearDepthf(float d) => instance.glClearDepthf(d);
        
        static unsafe void glClearDepthfOES(float depth) => instance.glClearDepthfOES(depth);
        
        static unsafe void glClearDepthx(int depth) => instance.glClearDepthx(depth);
        
        static unsafe void glClearDepthxOES(int depth) => instance.glClearDepthxOES(depth);
        
        static unsafe void glClearIndex(float c) => instance.glClearIndex(c);
        
        static unsafe void glClearNamedBufferData(uint buffer, InternalFormat internalformat, PixelFormat format, PixelType type, void * data) => instance.glClearNamedBufferData(buffer, internalformat, format, type, data);
        
        static unsafe void glClearNamedBufferDataEXT(uint buffer, InternalFormat internalformat, PixelFormat format, PixelType type, void * data) => instance.glClearNamedBufferDataEXT(buffer, internalformat, format, type, data);
        
        static unsafe void glClearNamedBufferSubData(uint buffer, InternalFormat internalformat, IntPtr offset, UIntPtr size, PixelFormat format, PixelType type, void * data) => instance.glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
        
        static unsafe void glClearNamedFramebufferfi(uint framebuffer, Buffer buffer, int drawbuffer, float depth, int stencil) => instance.glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
        
        static unsafe void glClearNamedFramebufferfv(uint framebuffer, Buffer buffer, int drawbuffer, float * value) => instance.glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
        
        static unsafe void glClearNamedFramebufferiv(uint framebuffer, Buffer buffer, int drawbuffer, int * value) => instance.glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
        
        static unsafe void glClearNamedFramebufferuiv(uint framebuffer, Buffer buffer, int drawbuffer, uint * value) => instance.glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
        
        static unsafe void glClearPixelLocalStorageuiEXT(uint offset, uint n, uint * values) => instance.glClearPixelLocalStorageuiEXT(offset, n, values);
        
        static unsafe void glClearStencil(int s) => instance.glClearStencil(s);
        
        static unsafe void glClearTexImage(uint texture, int level, PixelFormat format, PixelType type, void * data) => instance.glClearTexImage(texture, level, format, type, data);
        
        static unsafe void glClearTexImageEXT(uint texture, int level, PixelFormat format, PixelType type, void * data) => instance.glClearTexImageEXT(texture, level, format, type, data);
        
        static unsafe void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * data) => instance.glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        
        static unsafe void glClearTexSubImageEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * data) => instance.glClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        
        static unsafe void glClientActiveTexture(TextureUnit texture) => instance.glClientActiveTexture(texture);
        
        static unsafe void glClientActiveTextureARB(TextureUnit texture) => instance.glClientActiveTextureARB(texture);
        
        static unsafe void glClientActiveVertexStreamATI(VertexStreamATI stream) => instance.glClientActiveVertexStreamATI(stream);
        
        static unsafe void glClientAttribDefaultEXT(uint mask) => instance.glClientAttribDefaultEXT(mask);
        
        static unsafe void glClientWaitSemaphoreui64NVX(uint fenceObjectCount, uint * semaphoreArray, ulong * fenceValueArray) => instance.glClientWaitSemaphoreui64NVX(fenceObjectCount, semaphoreArray, fenceValueArray);
        
        static unsafe SyncStatus glClientWaitSync(IntPtr sync, uint flags, ulong timeout) => instance.glClientWaitSync(sync, flags, timeout);
        
        static unsafe SyncStatus glClientWaitSyncAPPLE(IntPtr sync, uint flags, ulong timeout) => instance.glClientWaitSyncAPPLE(sync, flags, timeout);
        
        static unsafe void glClipControl(ClipControlOrigin origin, ClipControlDepth depth) => instance.glClipControl(origin, depth);
        
        static unsafe void glClipPlane(ClipPlaneName plane, double * equation) => instance.glClipPlane(plane, equation);
        
        static unsafe void glClipPlanef(ClipPlaneName p, float * eqn) => instance.glClipPlanef(p, eqn);
        
        static unsafe void glClipPlanefIMG(ClipPlaneName p, float * eqn) => instance.glClipPlanefIMG(p, eqn);
        
        static unsafe void glClipPlanefOES(ClipPlaneName plane, float * equation) => instance.glClipPlanefOES(plane, equation);
        
        static unsafe void glClipPlanex(ClipPlaneName plane, int * equation) => instance.glClipPlanex(plane, equation);
        
        static unsafe void glClipPlanexIMG(ClipPlaneName p, int * eqn) => instance.glClipPlanexIMG(p, eqn);
        
        static unsafe void glClipPlanexOES(ClipPlaneName plane, int * equation) => instance.glClipPlanexOES(plane, equation);
        
        static unsafe void glColor3b(sbyte red, sbyte green, sbyte blue) => instance.glColor3b(red, green, blue);
        
        static unsafe void glColor3bv(sbyte * v) => instance.glColor3bv(v);
        
        static unsafe void glColor3d(double red, double green, double blue) => instance.glColor3d(red, green, blue);
        
        static unsafe void glColor3dv(double * v) => instance.glColor3dv(v);
        
        static unsafe void glColor3f(float red, float green, float blue) => instance.glColor3f(red, green, blue);
        
        static unsafe void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z) => instance.glColor3fVertex3fSUN(r, g, b, x, y, z);
        
        static unsafe void glColor3fVertex3fvSUN(float * c, float * v) => instance.glColor3fVertex3fvSUN(c, v);
        
        static unsafe void glColor3fv(float * v) => instance.glColor3fv(v);
        
        static unsafe void glColor3hNV(OpenToolkit.Mathematics.Half red, OpenToolkit.Mathematics.Half green, OpenToolkit.Mathematics.Half blue) => instance.glColor3hNV(red, green, blue);
        
        static unsafe void glColor3hvNV(OpenToolkit.Mathematics.Half * v) => instance.glColor3hvNV(v);
        
        static unsafe void glColor3i(int red, int green, int blue) => instance.glColor3i(red, green, blue);
        
        static unsafe void glColor3iv(int * v) => instance.glColor3iv(v);
        
        static unsafe void glColor3s(short red, short green, short blue) => instance.glColor3s(red, green, blue);
        
        static unsafe void glColor3sv(short * v) => instance.glColor3sv(v);
        
        static unsafe void glColor3ub(byte red, byte green, byte blue) => instance.glColor3ub(red, green, blue);
        
        static unsafe void glColor3ubv(byte * v) => instance.glColor3ubv(v);
        
        static unsafe void glColor3ui(uint red, uint green, uint blue) => instance.glColor3ui(red, green, blue);
        
        static unsafe void glColor3uiv(uint * v) => instance.glColor3uiv(v);
        
        static unsafe void glColor3us(ushort red, ushort green, ushort blue) => instance.glColor3us(red, green, blue);
        
        static unsafe void glColor3usv(ushort * v) => instance.glColor3usv(v);
        
        static unsafe void glColor3xOES(int red, int green, int blue) => instance.glColor3xOES(red, green, blue);
        
        static unsafe void glColor3xvOES(int * components) => instance.glColor3xvOES(components);
        
        static unsafe void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) => instance.glColor4b(red, green, blue, alpha);
        
        static unsafe void glColor4bv(sbyte * v) => instance.glColor4bv(v);
        
        static unsafe void glColor4d(double red, double green, double blue, double alpha) => instance.glColor4d(red, green, blue, alpha);
        
        static unsafe void glColor4dv(double * v) => instance.glColor4dv(v);
        
        static unsafe void glColor4f(float red, float green, float blue, float alpha) => instance.glColor4f(red, green, blue, alpha);
        
        static unsafe void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => instance.glColor4fNormal3fVertex3fSUN(r, g, b, a, nx, ny, nz, x, y, z);
        
        static unsafe void glColor4fNormal3fVertex3fvSUN(float * c, float * n, float * v) => instance.glColor4fNormal3fVertex3fvSUN(c, n, v);
        
        static unsafe void glColor4fv(float * v) => instance.glColor4fv(v);
        
        static unsafe void glColor4hNV(OpenToolkit.Mathematics.Half red, OpenToolkit.Mathematics.Half green, OpenToolkit.Mathematics.Half blue, OpenToolkit.Mathematics.Half alpha) => instance.glColor4hNV(red, green, blue, alpha);
        
        static unsafe void glColor4hvNV(OpenToolkit.Mathematics.Half * v) => instance.glColor4hvNV(v);
        
        static unsafe void glColor4i(int red, int green, int blue, int alpha) => instance.glColor4i(red, green, blue, alpha);
        
        static unsafe void glColor4iv(int * v) => instance.glColor4iv(v);
        
        static unsafe void glColor4s(short red, short green, short blue, short alpha) => instance.glColor4s(red, green, blue, alpha);
        
        static unsafe void glColor4sv(short * v) => instance.glColor4sv(v);
        
        static unsafe void glColor4ub(byte red, byte green, byte blue, byte alpha) => instance.glColor4ub(red, green, blue, alpha);
        
        static unsafe void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y) => instance.glColor4ubVertex2fSUN(r, g, b, a, x, y);
        
        static unsafe void glColor4ubVertex2fvSUN(byte * c, float * v) => instance.glColor4ubVertex2fvSUN(c, v);
        
        static unsafe void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z) => instance.glColor4ubVertex3fSUN(r, g, b, a, x, y, z);
        
        static unsafe void glColor4ubVertex3fvSUN(byte * c, float * v) => instance.glColor4ubVertex3fvSUN(c, v);
        
        static unsafe void glColor4ubv(byte * v) => instance.glColor4ubv(v);
        
        static unsafe void glColor4ui(uint red, uint green, uint blue, uint alpha) => instance.glColor4ui(red, green, blue, alpha);
        
        static unsafe void glColor4uiv(uint * v) => instance.glColor4uiv(v);
        
        static unsafe void glColor4us(ushort red, ushort green, ushort blue, ushort alpha) => instance.glColor4us(red, green, blue, alpha);
        
        static unsafe void glColor4usv(ushort * v) => instance.glColor4usv(v);
        
        static unsafe void glColor4x(int red, int green, int blue, int alpha) => instance.glColor4x(red, green, blue, alpha);
        
        static unsafe void glColor4xOES(int red, int green, int blue, int alpha) => instance.glColor4xOES(red, green, blue, alpha);
        
        static unsafe void glColor4xvOES(int * components) => instance.glColor4xvOES(components);
        
        static unsafe void glColorFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod) => instance.glColorFragmentOp1ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
        
        static unsafe void glColorFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod) => instance.glColorFragmentOp2ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
        
        static unsafe void glColorFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod) => instance.glColorFragmentOp3ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
        
        static unsafe void glColorMask(bool red, bool green, bool blue, bool alpha) => instance.glColorMask(red, green, blue, alpha);
        
        static unsafe void glColorMaskIndexedEXT(uint index, bool r, bool g, bool b, bool a) => instance.glColorMaskIndexedEXT(index, r, g, b, a);
        
        static unsafe void glColorMaski(uint index, bool r, bool g, bool b, bool a) => instance.glColorMaski(index, r, g, b, a);
        
        static unsafe void glColorMaskiEXT(uint index, bool r, bool g, bool b, bool a) => instance.glColorMaskiEXT(index, r, g, b, a);
        
        static unsafe void glColorMaskiOES(uint index, bool r, bool g, bool b, bool a) => instance.glColorMaskiOES(index, r, g, b, a);
        
        static unsafe void glColorMaterial(MaterialFace face, ColorMaterialParameter mode) => instance.glColorMaterial(face, mode);
        
        static unsafe void glColorP3ui(ColorPointerType type, uint color) => instance.glColorP3ui(type, color);
        
        static unsafe void glColorP3uiv(ColorPointerType type, uint * color) => instance.glColorP3uiv(type, color);
        
        static unsafe void glColorP4ui(ColorPointerType type, uint color) => instance.glColorP4ui(type, color);
        
        static unsafe void glColorP4uiv(ColorPointerType type, uint * color) => instance.glColorP4uiv(type, color);
        
        static unsafe void glColorPointer(int size, ColorPointerType type, uint stride, void * pointer) => instance.glColorPointer(size, type, stride, pointer);
        
        static unsafe void glColorPointerEXT(int size, ColorPointerType type, uint stride, uint count, void * pointer) => instance.glColorPointerEXT(size, type, stride, count, pointer);
        
        static unsafe void glColorPointerListIBM(int size, ColorPointerType type, int stride, void * * pointer, int ptrstride) => instance.glColorPointerListIBM(size, type, stride, pointer, ptrstride);
        
        static unsafe void glColorPointervINTEL(int size, VertexPointerType type, void * * pointer) => instance.glColorPointervINTEL(size, type, pointer);
        
        static unsafe void glColorSubTable(ColorTableTarget target, uint start, uint count, PixelFormat format, PixelType type, void * data) => instance.glColorSubTable(target, start, count, format, type, data);
        
        static unsafe void glColorSubTableEXT(ColorTableTarget target, uint start, uint count, PixelFormat format, PixelType type, void * data) => instance.glColorSubTableEXT(target, start, count, format, type, data);
        
        static unsafe void glColorTable(ColorTableTarget target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * table) => instance.glColorTable(target, internalformat, width, format, type, table);
        
        static unsafe void glColorTableEXT(ColorTableTarget target, InternalFormat internalFormat, uint width, PixelFormat format, PixelType type, void * table) => instance.glColorTableEXT(target, internalFormat, width, format, type, table);
        
        static unsafe void glColorTableParameterfv(ColorTableTarget target, ColorTableParameterPNameSGI pname, float * PARAMS) => instance.glColorTableParameterfv(target, pname, PARAMS);
        
        static unsafe void glColorTableParameterfvSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float * PARAMS) => instance.glColorTableParameterfvSGI(target, pname, PARAMS);
        
        static unsafe void glColorTableParameteriv(ColorTableTarget target, ColorTableParameterPNameSGI pname, int * PARAMS) => instance.glColorTableParameteriv(target, pname, PARAMS);
        
        static unsafe void glColorTableParameterivSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int * PARAMS) => instance.glColorTableParameterivSGI(target, pname, PARAMS);
        
        static unsafe void glColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * table) => instance.glColorTableSGI(target, internalformat, width, format, type, table);
        
        static unsafe void glCombinerInputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage) => instance.glCombinerInputNV(stage, portion, variable, input, mapping, componentUsage);
        
        static unsafe void glCombinerOutputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerRegisterNV abOutput, CombinerRegisterNV cdOutput, CombinerRegisterNV sumOutput, CombinerScaleNV scale, CombinerBiasNV bias, bool abDotProduct, bool cdDotProduct, bool muxSum) => instance.glCombinerOutputNV(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);
        
        static unsafe void glCombinerParameterfNV(CombinerParameterNV pname, float param) => instance.glCombinerParameterfNV(pname, param);
        
        static unsafe void glCombinerParameterfvNV(CombinerParameterNV pname, float * PARAMS) => instance.glCombinerParameterfvNV(pname, PARAMS);
        
        static unsafe void glCombinerParameteriNV(CombinerParameterNV pname, int param) => instance.glCombinerParameteriNV(pname, param);
        
        static unsafe void glCombinerParameterivNV(CombinerParameterNV pname, int * PARAMS) => instance.glCombinerParameterivNV(pname, PARAMS);
        
        static unsafe void glCombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float * PARAMS) => instance.glCombinerStageParameterfvNV(stage, pname, PARAMS);
        
        static unsafe void glCommandListSegmentsNV(uint list, uint segments) => instance.glCommandListSegmentsNV(list, segments);
        
        static unsafe void glCompileCommandListNV(uint list) => instance.glCompileCommandListNV(list);
        
        static unsafe void glCompileShader(uint shader) => instance.glCompileShader(shader);
        
        static unsafe void glCompileShaderARB(uint shaderObj) => instance.glCompileShaderARB(shaderObj);
        
        static unsafe void glCompileShaderIncludeARB(uint shader, uint count, char * * path, int * length) => instance.glCompileShaderIncludeARB(shader, count, path, length);
        
        static unsafe void glCompressedMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * bits) => instance.glCompressedMultiTexImage1DEXT(texunit, target, level, internalformat, width, border, imageSize, bits);
        
        static unsafe void glCompressedMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * bits) => instance.glCompressedMultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, imageSize, bits);
        
        static unsafe void glCompressedMultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * bits) => instance.glCompressedMultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, imageSize, bits);
        
        static unsafe void glCompressedMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * bits) => instance.glCompressedMultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, imageSize, bits);
        
        static unsafe void glCompressedMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * bits) => instance.glCompressedMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, bits);
        
        static unsafe void glCompressedMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * bits) => instance.glCompressedMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);
        
        static unsafe void glCompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * data) => instance.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
        
        static unsafe void glCompressedTexImage1DARB(TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * data) => instance.glCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
        
        static unsafe void glCompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * data) => instance.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        
        static unsafe void glCompressedTexImage2DARB(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * data) => instance.glCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
        
        static unsafe void glCompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * data) => instance.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        
        static unsafe void glCompressedTexImage3DARB(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * data) => instance.glCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
        
        static unsafe void glCompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * data) => instance.glCompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data);
        
        static unsafe void glCompressedTexSubImage1D(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        
        static unsafe void glCompressedTexSubImage1DARB(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
        
        static unsafe void glCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        
        static unsafe void glCompressedTexSubImage2DARB(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        
        static unsafe void glCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        
        static unsafe void glCompressedTexSubImage3DARB(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        
        static unsafe void glCompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        
        static unsafe void glCompressedTextureImage1DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * bits) => instance.glCompressedTextureImage1DEXT(texture, target, level, internalformat, width, border, imageSize, bits);
        
        static unsafe void glCompressedTextureImage2DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * bits) => instance.glCompressedTextureImage2DEXT(texture, target, level, internalformat, width, height, border, imageSize, bits);
        
        static unsafe void glCompressedTextureImage3DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * bits) => instance.glCompressedTextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, imageSize, bits);
        
        static unsafe void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        
        static unsafe void glCompressedTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * bits) => instance.glCompressedTextureSubImage1DEXT(texture, target, level, xoffset, width, format, imageSize, bits);
        
        static unsafe void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        
        static unsafe void glCompressedTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * bits) => instance.glCompressedTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits);
        
        static unsafe void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data) => instance.glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        
        static unsafe void glCompressedTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * bits) => instance.glCompressedTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits);
        
        static unsafe void glConvolutionFilter1D(ConvolutionTarget target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * image) => instance.glConvolutionFilter1D(target, internalformat, width, format, type, image);
        
        static unsafe void glConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * image) => instance.glConvolutionFilter1DEXT(target, internalformat, width, format, type, image);
        
        static unsafe void glConvolutionFilter2D(ConvolutionTarget target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * image) => instance.glConvolutionFilter2D(target, internalformat, width, height, format, type, image);
        
        static unsafe void glConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * image) => instance.glConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image);
        
        static unsafe void glConvolutionParameterf(ConvolutionTarget target, ConvolutionParameterEXT pname, float PARAMS) => instance.glConvolutionParameterf(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameterfEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float PARAMS) => instance.glConvolutionParameterfEXT(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameterfv(ConvolutionTarget target, ConvolutionParameterEXT pname, float * PARAMS) => instance.glConvolutionParameterfv(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float * PARAMS) => instance.glConvolutionParameterfvEXT(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameteri(ConvolutionTarget target, ConvolutionParameterEXT pname, int PARAMS) => instance.glConvolutionParameteri(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameteriEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int PARAMS) => instance.glConvolutionParameteriEXT(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameteriv(ConvolutionTarget target, ConvolutionParameterEXT pname, int * PARAMS) => instance.glConvolutionParameteriv(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int * PARAMS) => instance.glConvolutionParameterivEXT(target, pname, PARAMS);
        
        static unsafe void glConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int param) => instance.glConvolutionParameterxOES(target, pname, param);
        
        static unsafe void glConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int * PARAMS) => instance.glConvolutionParameterxvOES(target, pname, PARAMS);
        
        static unsafe void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, UIntPtr size) => instance.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
        
        static unsafe void glCopyBufferSubDataNV(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, UIntPtr size) => instance.glCopyBufferSubDataNV(readTarget, writeTarget, readOffset, writeOffset, size);
        
        static unsafe void glCopyColorSubTable(ColorTableTarget target, uint start, int x, int y, uint width) => instance.glCopyColorSubTable(target, start, x, y, width);
        
        static unsafe void glCopyColorSubTableEXT(ColorTableTarget target, uint start, int x, int y, uint width) => instance.glCopyColorSubTableEXT(target, start, x, y, width);
        
        static unsafe void glCopyColorTable(ColorTableTarget target, InternalFormat internalformat, int x, int y, uint width) => instance.glCopyColorTable(target, internalformat, x, y, width);
        
        static unsafe void glCopyColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int x, int y, uint width) => instance.glCopyColorTableSGI(target, internalformat, x, y, width);
        
        static unsafe void glCopyConvolutionFilter1D(ConvolutionTarget target, InternalFormat internalformat, int x, int y, uint width) => instance.glCopyConvolutionFilter1D(target, internalformat, x, y, width);
        
        static unsafe void glCopyConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, uint width) => instance.glCopyConvolutionFilter1DEXT(target, internalformat, x, y, width);
        
        static unsafe void glCopyConvolutionFilter2D(ConvolutionTarget target, InternalFormat internalformat, int x, int y, uint width, uint height) => instance.glCopyConvolutionFilter2D(target, internalformat, x, y, width, height);
        
        static unsafe void glCopyConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, uint width, uint height) => instance.glCopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height);
        
        static unsafe void glCopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth) => instance.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        
        static unsafe void glCopyImageSubDataEXT(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth) => instance.glCopyImageSubDataEXT(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        
        static unsafe void glCopyImageSubDataNV(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint width, uint height, uint depth) => instance.glCopyImageSubDataNV(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
        
        static unsafe void glCopyImageSubDataOES(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth) => instance.glCopyImageSubDataOES(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        
        static unsafe void glCopyMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border) => instance.glCopyMultiTexImage1DEXT(texunit, target, level, internalformat, x, y, width, border);
        
        static unsafe void glCopyMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border) => instance.glCopyMultiTexImage2DEXT(texunit, target, level, internalformat, x, y, width, height, border);
        
        static unsafe void glCopyMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int x, int y, uint width) => instance.glCopyMultiTexSubImage1DEXT(texunit, target, level, xoffset, x, y, width);
        
        static unsafe void glCopyMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height) => instance.glCopyMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, x, y, width, height);
        
        static unsafe void glCopyMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height) => instance.glCopyMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        static unsafe void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size) => instance.glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
        
        static unsafe void glCopyPathNV(uint resultPath, uint srcPath) => instance.glCopyPathNV(resultPath, srcPath);
        
        static unsafe void glCopyPixels(int x, int y, uint width, uint height, PixelCopyType type) => instance.glCopyPixels(x, y, width, height, type);
        
        static unsafe void glCopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border) => instance.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
        
        static unsafe void glCopyTexImage1DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border) => instance.glCopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
        
        static unsafe void glCopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border) => instance.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        
        static unsafe void glCopyTexImage2DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border) => instance.glCopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
        
        static unsafe void glCopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, uint width) => instance.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
        
        static unsafe void glCopyTexSubImage1DEXT(TextureTarget target, int level, int xoffset, int x, int y, uint width) => instance.glCopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
        
        static unsafe void glCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height) => instance.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        
        static unsafe void glCopyTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height) => instance.glCopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
        
        static unsafe void glCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height) => instance.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        static unsafe void glCopyTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height) => instance.glCopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        static unsafe void glCopyTextureImage1DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border) => instance.glCopyTextureImage1DEXT(texture, target, level, internalformat, x, y, width, border);
        
        static unsafe void glCopyTextureImage2DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border) => instance.glCopyTextureImage2DEXT(texture, target, level, internalformat, x, y, width, height, border);
        
        static unsafe void glCopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, uint sourceLevelCount) => instance.glCopyTextureLevelsAPPLE(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
        
        static unsafe void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, uint width) => instance.glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
        
        static unsafe void glCopyTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, int x, int y, uint width) => instance.glCopyTextureSubImage1DEXT(texture, target, level, xoffset, x, y, width);
        
        static unsafe void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, uint width, uint height) => instance.glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
        
        static unsafe void glCopyTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height) => instance.glCopyTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, x, y, width, height);
        
        static unsafe void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height) => instance.glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        static unsafe void glCopyTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height) => instance.glCopyTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, x, y, width, height);
        
        static unsafe void glCoverFillPathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float * transformValues) => instance.glCoverFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
        
        static unsafe void glCoverFillPathNV(uint path, PathCoverMode coverMode) => instance.glCoverFillPathNV(path, coverMode);
        
        static unsafe void glCoverStrokePathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float * transformValues) => instance.glCoverStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);
        
        static unsafe void glCoverStrokePathNV(uint path, PathCoverMode coverMode) => instance.glCoverStrokePathNV(path, coverMode);
        
        static unsafe void glCoverageMaskNV(bool mask) => instance.glCoverageMaskNV(mask);
        
        static unsafe void glCoverageModulationTableNV(uint n, float * v) => instance.glCoverageModulationTableNV(n, v);
        
        static unsafe void glCreateBuffers(uint n, uint * buffers) => instance.glCreateBuffers(n, buffers);
        
        static unsafe void glCreateCommandListsNV(uint n, uint * lists) => instance.glCreateCommandListsNV(n, lists);
        
        static unsafe void glCreateFramebuffers(uint n, uint * framebuffers) => instance.glCreateFramebuffers(n, framebuffers);
        
        static unsafe void glCreateMemoryObjectsEXT(uint n, uint * memoryObjects) => instance.glCreateMemoryObjectsEXT(n, memoryObjects);
        
        static unsafe void glCreatePerfQueryINTEL(uint queryId, uint * queryHandle) => instance.glCreatePerfQueryINTEL(queryId, queryHandle);
        
        static unsafe uint glCreateProgram() => instance.glCreateProgram();
        
        static unsafe uint glCreateProgramObjectARB() => instance.glCreateProgramObjectARB();
        
        static unsafe void glCreateProgramPipelines(uint n, uint * pipelines) => instance.glCreateProgramPipelines(n, pipelines);
        
        static unsafe uint glCreateProgressFenceNVX() => instance.glCreateProgressFenceNVX();
        
        static unsafe void glCreateQueries(QueryTarget target, uint n, uint * ids) => instance.glCreateQueries(target, n, ids);
        
        static unsafe void glCreateRenderbuffers(uint n, uint * renderbuffers) => instance.glCreateRenderbuffers(n, renderbuffers);
        
        static unsafe void glCreateSamplers(uint n, uint * samplers) => instance.glCreateSamplers(n, samplers);
        
        static unsafe uint glCreateShader(ShaderType type) => instance.glCreateShader(type);
        
        static unsafe uint glCreateShaderObjectARB(ShaderType shaderType) => instance.glCreateShaderObjectARB(shaderType);
        
        static unsafe uint glCreateShaderProgramEXT(ShaderType type, char * STRING) => instance.glCreateShaderProgramEXT(type, STRING);
        
        static unsafe uint glCreateShaderProgramv(ShaderType type, uint count, char * * strings) => instance.glCreateShaderProgramv(type, count, strings);
        
        static unsafe uint glCreateShaderProgramvEXT(ShaderType type, uint count, char * * strings) => instance.glCreateShaderProgramvEXT(type, count, strings);
        
        static unsafe void glCreateStatesNV(uint n, uint * states) => instance.glCreateStatesNV(n, states);
        
        static unsafe IntPtr glCreateSyncFromCLeventARB(Struct_cl_context * context, Struct_cl_event * EVENT, uint flags) => instance.glCreateSyncFromCLeventARB(context, EVENT, flags);
        
        static unsafe void glCreateTextures(TextureTarget target, uint n, uint * textures) => instance.glCreateTextures(target, n, textures);
        
        static unsafe void glCreateTransformFeedbacks(uint n, uint * ids) => instance.glCreateTransformFeedbacks(n, ids);
        
        static unsafe void glCreateVertexArrays(uint n, uint * arrays) => instance.glCreateVertexArrays(n, arrays);
        
        static unsafe void glCullFace(CullFaceMode mode) => instance.glCullFace(mode);
        
        static unsafe void glCullParameterdvEXT(CullParameterEXT pname, double * PARAMS) => instance.glCullParameterdvEXT(pname, PARAMS);
        
        static unsafe void glCullParameterfvEXT(CullParameterEXT pname, float * PARAMS) => instance.glCullParameterfvEXT(pname, PARAMS);
        
        static unsafe void glCurrentPaletteMatrixARB(int index) => instance.glCurrentPaletteMatrixARB(index);
        
        static unsafe void glCurrentPaletteMatrixOES(uint matrixpaletteindex) => instance.glCurrentPaletteMatrixOES(matrixpaletteindex);
        
        static unsafe void glDebugMessageCallback(DebugProc callback, void * userParam) => instance.glDebugMessageCallback(callback, userParam);
        
        static unsafe void glDebugMessageCallbackAMD(DebugProcAmd callback, void * userParam) => instance.glDebugMessageCallbackAMD(callback, userParam);
        
        static unsafe void glDebugMessageCallbackARB(DebugProcArb callback, void * userParam) => instance.glDebugMessageCallbackARB(callback, userParam);
        
        static unsafe void glDebugMessageCallbackKHR(DebugProcKhr callback, void * userParam) => instance.glDebugMessageCallbackKHR(callback, userParam);
        
        static unsafe void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint count, uint * ids, bool enabled) => instance.glDebugMessageControl(source, type, severity, count, ids, enabled);
        
        static unsafe void glDebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, uint count, uint * ids, bool enabled) => instance.glDebugMessageControlARB(source, type, severity, count, ids, enabled);
        
        static unsafe void glDebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, uint count, uint * ids, bool enabled) => instance.glDebugMessageControlKHR(source, type, severity, count, ids, enabled);
        
        static unsafe void glDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, uint length, char * buf) => instance.glDebugMessageInsert(source, type, id, severity, length, buf);
        
        static unsafe void glDebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, uint length, char * buf) => instance.glDebugMessageInsertARB(source, type, id, severity, length, buf);
        
        static unsafe void glDebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, uint length, char * buf) => instance.glDebugMessageInsertKHR(source, type, id, severity, length, buf);
        
        static unsafe void glDeformSGIX(uint mask) => instance.glDeformSGIX(mask);
        
        static unsafe void glDeformationMap3dSGIX(FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double * points) => instance.glDeformationMap3dSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
        
        static unsafe void glDeformationMap3fSGIX(FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float * points) => instance.glDeformationMap3fSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
        
        static unsafe void glDeleteAsyncMarkersSGIX(uint marker, uint range) => instance.glDeleteAsyncMarkersSGIX(marker, range);
        
        static unsafe void glDeleteBuffers(uint n, uint * buffers) => instance.glDeleteBuffers(n, buffers);
        
        static unsafe void glDeleteBuffersARB(uint n, uint * buffers) => instance.glDeleteBuffersARB(n, buffers);
        
        static unsafe void glDeleteCommandListsNV(uint n, uint * lists) => instance.glDeleteCommandListsNV(n, lists);
        
        static unsafe void glDeleteFencesAPPLE(uint n, uint * fences) => instance.glDeleteFencesAPPLE(n, fences);
        
        static unsafe void glDeleteFencesNV(uint n, uint * fences) => instance.glDeleteFencesNV(n, fences);
        
        static unsafe void glDeleteFragmentShaderATI(uint id) => instance.glDeleteFragmentShaderATI(id);
        
        static unsafe void glDeleteFramebuffers(uint n, uint * framebuffers) => instance.glDeleteFramebuffers(n, framebuffers);
        
        static unsafe void glDeleteFramebuffersEXT(uint n, uint * framebuffers) => instance.glDeleteFramebuffersEXT(n, framebuffers);
        
        static unsafe void glDeleteFramebuffersOES(uint n, uint * framebuffers) => instance.glDeleteFramebuffersOES(n, framebuffers);
        
        static unsafe void glDeleteLists(uint list, uint range) => instance.glDeleteLists(list, range);
        
        static unsafe void glDeleteMemoryObjectsEXT(uint n, uint * memoryObjects) => instance.glDeleteMemoryObjectsEXT(n, memoryObjects);
        
        static unsafe void glDeleteNamedStringARB(int namelen, char * name) => instance.glDeleteNamedStringARB(namelen, name);
        
        static unsafe void glDeleteObjectARB(uint obj) => instance.glDeleteObjectARB(obj);
        
        static unsafe void glDeleteOcclusionQueriesNV(uint n, uint * ids) => instance.glDeleteOcclusionQueriesNV(n, ids);
        
        static unsafe void glDeletePathsNV(uint path, uint range) => instance.glDeletePathsNV(path, range);
        
        static unsafe void glDeletePerfMonitorsAMD(uint n, uint * monitors) => instance.glDeletePerfMonitorsAMD(n, monitors);
        
        static unsafe void glDeletePerfQueryINTEL(uint queryHandle) => instance.glDeletePerfQueryINTEL(queryHandle);
        
        static unsafe void glDeleteProgram(uint program) => instance.glDeleteProgram(program);
        
        static unsafe void glDeleteProgramPipelines(uint n, uint * pipelines) => instance.glDeleteProgramPipelines(n, pipelines);
        
        static unsafe void glDeleteProgramPipelinesEXT(uint n, uint * pipelines) => instance.glDeleteProgramPipelinesEXT(n, pipelines);
        
        static unsafe void glDeleteProgramsARB(uint n, uint * programs) => instance.glDeleteProgramsARB(n, programs);
        
        static unsafe void glDeleteProgramsNV(uint n, uint * programs) => instance.glDeleteProgramsNV(n, programs);
        
        static unsafe void glDeleteQueries(uint n, uint * ids) => instance.glDeleteQueries(n, ids);
        
        static unsafe void glDeleteQueriesARB(uint n, uint * ids) => instance.glDeleteQueriesARB(n, ids);
        
        static unsafe void glDeleteQueriesEXT(uint n, uint * ids) => instance.glDeleteQueriesEXT(n, ids);
        
        static unsafe void glDeleteQueryResourceTagNV(uint n, int * tagIds) => instance.glDeleteQueryResourceTagNV(n, tagIds);
        
        static unsafe void glDeleteRenderbuffers(uint n, uint * renderbuffers) => instance.glDeleteRenderbuffers(n, renderbuffers);
        
        static unsafe void glDeleteRenderbuffersEXT(uint n, uint * renderbuffers) => instance.glDeleteRenderbuffersEXT(n, renderbuffers);
        
        static unsafe void glDeleteRenderbuffersOES(uint n, uint * renderbuffers) => instance.glDeleteRenderbuffersOES(n, renderbuffers);
        
        static unsafe void glDeleteSamplers(uint count, uint * samplers) => instance.glDeleteSamplers(count, samplers);
        
        static unsafe void glDeleteSemaphoresEXT(uint n, uint * semaphores) => instance.glDeleteSemaphoresEXT(n, semaphores);
        
        static unsafe void glDeleteShader(uint shader) => instance.glDeleteShader(shader);
        
        static unsafe void glDeleteStatesNV(uint n, uint * states) => instance.glDeleteStatesNV(n, states);
        
        static unsafe void glDeleteSync(IntPtr sync) => instance.glDeleteSync(sync);
        
        static unsafe void glDeleteSyncAPPLE(IntPtr sync) => instance.glDeleteSyncAPPLE(sync);
        
        static unsafe void glDeleteTextures(uint n, uint * textures) => instance.glDeleteTextures(n, textures);
        
        static unsafe void glDeleteTexturesEXT(uint n, uint * textures) => instance.glDeleteTexturesEXT(n, textures);
        
        static unsafe void glDeleteTransformFeedbacks(uint n, uint * ids) => instance.glDeleteTransformFeedbacks(n, ids);
        
        static unsafe void glDeleteTransformFeedbacksNV(uint n, uint * ids) => instance.glDeleteTransformFeedbacksNV(n, ids);
        
        static unsafe void glDeleteVertexArrays(uint n, uint * arrays) => instance.glDeleteVertexArrays(n, arrays);
        
        static unsafe void glDeleteVertexArraysAPPLE(uint n, uint * arrays) => instance.glDeleteVertexArraysAPPLE(n, arrays);
        
        static unsafe void glDeleteVertexArraysOES(uint n, uint * arrays) => instance.glDeleteVertexArraysOES(n, arrays);
        
        static unsafe void glDeleteVertexShaderEXT(uint id) => instance.glDeleteVertexShaderEXT(id);
        
        static unsafe void glDepthBoundsEXT(double zmin, double zmax) => instance.glDepthBoundsEXT(zmin, zmax);
        
        static unsafe void glDepthBoundsdNV(double zmin, double zmax) => instance.glDepthBoundsdNV(zmin, zmax);
        
        static unsafe void glDepthFunc(DepthFunction func) => instance.glDepthFunc(func);
        
        static unsafe void glDepthMask(bool flag) => instance.glDepthMask(flag);
        
        static unsafe void glDepthRange(double n, double f) => instance.glDepthRange(n, f);
        
        static unsafe void glDepthRangeArrayfvNV(uint first, uint count, float * v) => instance.glDepthRangeArrayfvNV(first, count, v);
        
        static unsafe void glDepthRangeArrayfvOES(uint first, uint count, float * v) => instance.glDepthRangeArrayfvOES(first, count, v);
        
        static unsafe void glDepthRangeArrayv(uint first, uint count, double * v) => instance.glDepthRangeArrayv(first, count, v);
        
        static unsafe void glDepthRangeIndexed(uint index, double n, double f) => instance.glDepthRangeIndexed(index, n, f);
        
        static unsafe void glDepthRangeIndexedfNV(uint index, float n, float f) => instance.glDepthRangeIndexedfNV(index, n, f);
        
        static unsafe void glDepthRangeIndexedfOES(uint index, float n, float f) => instance.glDepthRangeIndexedfOES(index, n, f);
        
        static unsafe void glDepthRangedNV(double zNear, double zFar) => instance.glDepthRangedNV(zNear, zFar);
        
        static unsafe void glDepthRangef(float n, float f) => instance.glDepthRangef(n, f);
        
        static unsafe void glDepthRangefOES(float n, float f) => instance.glDepthRangefOES(n, f);
        
        static unsafe void glDepthRangex(int n, int f) => instance.glDepthRangex(n, f);
        
        static unsafe void glDepthRangexOES(int n, int f) => instance.glDepthRangexOES(n, f);
        
        static unsafe void glDetachObjectARB(uint containerObj, uint attachedObj) => instance.glDetachObjectARB(containerObj, attachedObj);
        
        static unsafe void glDetachShader(uint program, uint shader) => instance.glDetachShader(program, shader);
        
        static unsafe void glDetailTexFuncSGIS(TextureTarget target, uint n, float * points) => instance.glDetailTexFuncSGIS(target, n, points);
        
        static unsafe void glDisable(EnableCap cap) => instance.glDisable(cap);
        
        static unsafe void glDisableClientState(EnableCap array) => instance.glDisableClientState(array);
        
        static unsafe void glDisableClientStateIndexedEXT(EnableCap array, uint index) => instance.glDisableClientStateIndexedEXT(array, index);
        
        static unsafe void glDisableClientStateiEXT(EnableCap array, uint index) => instance.glDisableClientStateiEXT(array, index);
        
        static unsafe void glDisableDriverControlQCOM(uint driverControl) => instance.glDisableDriverControlQCOM(driverControl);
        
        static unsafe void glDisableIndexedEXT(EnableCap target, uint index) => instance.glDisableIndexedEXT(target, index);
        
        static unsafe void glDisableVariantClientStateEXT(uint id) => instance.glDisableVariantClientStateEXT(id);
        
        static unsafe void glDisableVertexArrayAttrib(uint vaobj, uint index) => instance.glDisableVertexArrayAttrib(vaobj, index);
        
        static unsafe void glDisableVertexArrayAttribEXT(uint vaobj, uint index) => instance.glDisableVertexArrayAttribEXT(vaobj, index);
        
        static unsafe void glDisableVertexArrayEXT(uint vaobj, EnableCap array) => instance.glDisableVertexArrayEXT(vaobj, array);
        
        static unsafe void glDisableVertexAttribArray(uint index) => instance.glDisableVertexAttribArray(index);
        
        static unsafe void glDisableVertexAttribArrayARB(uint index) => instance.glDisableVertexAttribArrayARB(index);
        
        static unsafe void glDisablei(EnableCap target, uint index) => instance.glDisablei(target, index);
        
        static unsafe void glDisableiEXT(EnableCap target, uint index) => instance.glDisableiEXT(target, index);
        
        static unsafe void glDisableiNV(EnableCap target, uint index) => instance.glDisableiNV(target, index);
        
        static unsafe void glDisableiOES(EnableCap target, uint index) => instance.glDisableiOES(target, index);
        
        static unsafe void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => instance.glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
        
        static unsafe void glDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z) => instance.glDispatchComputeGroupSizeARB(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z);
        
        static unsafe void glDispatchComputeIndirect(IntPtr indirect) => instance.glDispatchComputeIndirect(indirect);
        
        static unsafe void glDrawArrays(PrimitiveType mode, int first, uint count) => instance.glDrawArrays(mode, first, count);
        
        static unsafe void glDrawArraysEXT(PrimitiveType mode, int first, uint count) => instance.glDrawArraysEXT(mode, first, count);
        
        static unsafe void glDrawArraysIndirect(PrimitiveType mode, void * indirect) => instance.glDrawArraysIndirect(mode, indirect);
        
        static unsafe void glDrawArraysInstanced(PrimitiveType mode, int first, uint count, uint instancecount) => instance.glDrawArraysInstanced(mode, first, count, instancecount);
        
        static unsafe void glDrawArraysInstancedANGLE(PrimitiveType mode, int first, uint count, uint primcount) => instance.glDrawArraysInstancedANGLE(mode, first, count, primcount);
        
        static unsafe void glDrawArraysInstancedARB(PrimitiveType mode, int first, uint count, uint primcount) => instance.glDrawArraysInstancedARB(mode, first, count, primcount);
        
        static unsafe void glDrawArraysInstancedBaseInstance(PrimitiveType mode, int first, uint count, uint instancecount, uint baseinstance) => instance.glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
        
        static unsafe void glDrawArraysInstancedBaseInstanceEXT(PrimitiveType mode, int first, uint count, uint instancecount, uint baseinstance) => instance.glDrawArraysInstancedBaseInstanceEXT(mode, first, count, instancecount, baseinstance);
        
        static unsafe void glDrawArraysInstancedEXT(PrimitiveType mode, int start, uint count, uint primcount) => instance.glDrawArraysInstancedEXT(mode, start, count, primcount);
        
        static unsafe void glDrawArraysInstancedNV(PrimitiveType mode, int first, uint count, uint primcount) => instance.glDrawArraysInstancedNV(mode, first, count, primcount);
        
        static unsafe void glDrawBuffer(DrawBufferMode buf) => instance.glDrawBuffer(buf);
        
        static unsafe void glDrawBuffers(uint n, DrawBufferMode * bufs) => instance.glDrawBuffers(n, bufs);
        
        static unsafe void glDrawBuffersARB(uint n, DrawBufferMode * bufs) => instance.glDrawBuffersARB(n, bufs);
        
        static unsafe void glDrawBuffersATI(uint n, DrawBufferMode * bufs) => instance.glDrawBuffersATI(n, bufs);
        
        static unsafe void glDrawCommandsStatesAddressNV(ulong * indirects, uint * sizes, uint * states, uint * fbos, uint count) => instance.glDrawCommandsStatesAddressNV(indirects, sizes, states, fbos, count);
        
        static unsafe void glDrawCommandsStatesNV(uint buffer, IntPtr * indirects, uint * sizes, uint * states, uint * fbos, uint count) => instance.glDrawCommandsStatesNV(buffer, indirects, sizes, states, fbos, count);
        
        static unsafe void glDrawElementArrayAPPLE(PrimitiveType mode, int first, uint count) => instance.glDrawElementArrayAPPLE(mode, first, count);
        
        static unsafe void glDrawElementArrayATI(PrimitiveType mode, uint count) => instance.glDrawElementArrayATI(mode, count);
        
        static unsafe void glDrawElements(PrimitiveType mode, uint count, DrawElementsType type, void * indices) => instance.glDrawElements(mode, count, type, indices);
        
        static unsafe void glDrawElementsBaseVertex(PrimitiveType mode, uint count, DrawElementsType type, void * indices, int basevertex) => instance.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
        
        static unsafe void glDrawElementsBaseVertexEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, int basevertex) => instance.glDrawElementsBaseVertexEXT(mode, count, type, indices, basevertex);
        
        static unsafe void glDrawElementsBaseVertexOES(PrimitiveType mode, uint count, DrawElementsType type, void * indices, int basevertex) => instance.glDrawElementsBaseVertexOES(mode, count, type, indices, basevertex);
        
        static unsafe void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void * indirect) => instance.glDrawElementsIndirect(mode, type, indirect);
        
        static unsafe void glDrawElementsInstanced(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount) => instance.glDrawElementsInstanced(mode, count, type, indices, instancecount);
        
        static unsafe void glDrawElementsInstancedANGLE(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint primcount) => instance.glDrawElementsInstancedANGLE(mode, count, type, indices, primcount);
        
        static unsafe void glDrawElementsInstancedARB(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint primcount) => instance.glDrawElementsInstancedARB(mode, count, type, indices, primcount);
        
        static unsafe void glDrawElementsInstancedBaseInstance(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint instancecount, uint baseinstance) => instance.glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
        
        static unsafe void glDrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint instancecount, uint baseinstance) => instance.glDrawElementsInstancedBaseInstanceEXT(mode, count, type, indices, instancecount, baseinstance);
        
        static unsafe void glDrawElementsInstancedBaseVertex(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex) => instance.glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
        
        static unsafe void glDrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex, uint baseinstance) => instance.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
        
        static unsafe void glDrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex, uint baseinstance) => instance.glDrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, indices, instancecount, basevertex, baseinstance);
        
        static unsafe void glDrawElementsInstancedBaseVertexEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex) => instance.glDrawElementsInstancedBaseVertexEXT(mode, count, type, indices, instancecount, basevertex);
        
        static unsafe void glDrawElementsInstancedBaseVertexOES(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex) => instance.glDrawElementsInstancedBaseVertexOES(mode, count, type, indices, instancecount, basevertex);
        
        static unsafe void glDrawElementsInstancedEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint primcount) => instance.glDrawElementsInstancedEXT(mode, count, type, indices, primcount);
        
        static unsafe void glDrawElementsInstancedNV(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint primcount) => instance.glDrawElementsInstancedNV(mode, count, type, indices, primcount);
        
        static unsafe void glDrawMeshArraysSUN(PrimitiveType mode, int first, uint count, uint width) => instance.glDrawMeshArraysSUN(mode, first, count, width);
        
        static unsafe void glDrawMeshTasksNV(uint first, uint count) => instance.glDrawMeshTasksNV(first, count);
        
        static unsafe void glDrawMeshTasksIndirectNV(IntPtr indirect) => instance.glDrawMeshTasksIndirectNV(indirect);
        
        static unsafe void glDrawPixels(uint width, uint height, PixelFormat format, PixelType type, void * pixels) => instance.glDrawPixels(width, height, format, type, pixels);
        
        static unsafe void glDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int first, uint count) => instance.glDrawRangeElementArrayAPPLE(mode, start, end, first, count);
        
        static unsafe void glDrawRangeElementArrayATI(PrimitiveType mode, uint start, uint end, uint count) => instance.glDrawRangeElementArrayATI(mode, start, end, count);
        
        static unsafe void glDrawRangeElements(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices) => instance.glDrawRangeElements(mode, start, end, count, type, indices);
        
        static unsafe void glDrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices, int basevertex) => instance.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        
        static unsafe void glDrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices, int basevertex) => instance.glDrawRangeElementsBaseVertexEXT(mode, start, end, count, type, indices, basevertex);
        
        static unsafe void glDrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices, int basevertex) => instance.glDrawRangeElementsBaseVertexOES(mode, start, end, count, type, indices, basevertex);
        
        static unsafe void glDrawRangeElementsEXT(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices) => instance.glDrawRangeElementsEXT(mode, start, end, count, type, indices);
        
        static unsafe void glDrawTexfOES(float x, float y, float z, float width, float height) => instance.glDrawTexfOES(x, y, z, width, height);
        
        static unsafe void glDrawTexfvOES(float * coords) => instance.glDrawTexfvOES(coords);
        
        static unsafe void glDrawTexiOES(int x, int y, int z, int width, int height) => instance.glDrawTexiOES(x, y, z, width, height);
        
        static unsafe void glDrawTexivOES(int * coords) => instance.glDrawTexivOES(coords);
        
        static unsafe void glDrawTexsOES(short x, short y, short z, short width, short height) => instance.glDrawTexsOES(x, y, z, width, height);
        
        static unsafe void glDrawTexsvOES(short * coords) => instance.glDrawTexsvOES(coords);
        
        static unsafe void glDrawTextureNV(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => instance.glDrawTextureNV(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
        
        static unsafe void glDrawTexxOES(int x, int y, int z, int width, int height) => instance.glDrawTexxOES(x, y, z, width, height);
        
        static unsafe void glDrawTexxvOES(int * coords) => instance.glDrawTexxvOES(coords);
        
        static unsafe void glDrawTransformFeedback(PrimitiveType mode, uint id) => instance.glDrawTransformFeedback(mode, id);
        
        static unsafe void glDrawTransformFeedbackEXT(PrimitiveType mode, uint id) => instance.glDrawTransformFeedbackEXT(mode, id);
        
        static unsafe void glDrawTransformFeedbackInstanced(PrimitiveType mode, uint id, uint instancecount) => instance.glDrawTransformFeedbackInstanced(mode, id, instancecount);
        
        static unsafe void glDrawTransformFeedbackInstancedEXT(PrimitiveType mode, uint id, uint instancecount) => instance.glDrawTransformFeedbackInstancedEXT(mode, id, instancecount);
        
        static unsafe void glDrawTransformFeedbackNV(PrimitiveType mode, uint id) => instance.glDrawTransformFeedbackNV(mode, id);
        
        static unsafe void glDrawTransformFeedbackStream(PrimitiveType mode, uint id, uint stream) => instance.glDrawTransformFeedbackStream(mode, id, stream);
        
        static unsafe void glDrawTransformFeedbackStreamInstanced(PrimitiveType mode, uint id, uint stream, uint instancecount) => instance.glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
        
        static unsafe void glEGLImageTargetTextureStorageEXT(uint texture, IntPtr image, int * attrib_list) => instance.glEGLImageTargetTextureStorageEXT(texture, image, attrib_list);
        
        static unsafe void glEdgeFlag(bool flag) => instance.glEdgeFlag(flag);
        
        static unsafe void glEdgeFlagFormatNV(uint stride) => instance.glEdgeFlagFormatNV(stride);
        
        static unsafe void glEdgeFlagPointer(uint stride, void * pointer) => instance.glEdgeFlagPointer(stride, pointer);
        
        static unsafe void glEdgeFlagPointerEXT(uint stride, uint count, bool * pointer) => instance.glEdgeFlagPointerEXT(stride, count, pointer);
        
        static unsafe void glEdgeFlagPointerListIBM(int stride, bool * * pointer, int ptrstride) => instance.glEdgeFlagPointerListIBM(stride, pointer, ptrstride);
        
        static unsafe void glEdgeFlagv(bool * flag) => instance.glEdgeFlagv(flag);
        
        static unsafe void glElementPointerAPPLE(ElementPointerTypeATI type, void * pointer) => instance.glElementPointerAPPLE(type, pointer);
        
        static unsafe void glElementPointerATI(ElementPointerTypeATI type, void * pointer) => instance.glElementPointerATI(type, pointer);
        
        static unsafe void glEnable(EnableCap cap) => instance.glEnable(cap);
        
        static unsafe void glEnableClientState(EnableCap array) => instance.glEnableClientState(array);
        
        static unsafe void glEnableClientStateIndexedEXT(EnableCap array, uint index) => instance.glEnableClientStateIndexedEXT(array, index);
        
        static unsafe void glEnableClientStateiEXT(EnableCap array, uint index) => instance.glEnableClientStateiEXT(array, index);
        
        static unsafe void glEnableDriverControlQCOM(uint driverControl) => instance.glEnableDriverControlQCOM(driverControl);
        
        static unsafe void glEnableIndexedEXT(EnableCap target, uint index) => instance.glEnableIndexedEXT(target, index);
        
        static unsafe void glEnableVariantClientStateEXT(uint id) => instance.glEnableVariantClientStateEXT(id);
        
        static unsafe void glEnableVertexArrayAttrib(uint vaobj, uint index) => instance.glEnableVertexArrayAttrib(vaobj, index);
        
        static unsafe void glEnableVertexArrayAttribEXT(uint vaobj, uint index) => instance.glEnableVertexArrayAttribEXT(vaobj, index);
        
        static unsafe void glEnableVertexArrayEXT(uint vaobj, EnableCap array) => instance.glEnableVertexArrayEXT(vaobj, array);
        
        static unsafe void glEnableVertexAttribArray(uint index) => instance.glEnableVertexAttribArray(index);
        
        static unsafe void glEnableVertexAttribArrayARB(uint index) => instance.glEnableVertexAttribArrayARB(index);
        
        static unsafe void glEnablei(EnableCap target, uint index) => instance.glEnablei(target, index);
        
        static unsafe void glEnableiEXT(EnableCap target, uint index) => instance.glEnableiEXT(target, index);
        
        static unsafe void glEnableiNV(EnableCap target, uint index) => instance.glEnableiNV(target, index);
        
        static unsafe void glEnableiOES(EnableCap target, uint index) => instance.glEnableiOES(target, index);
        
        static unsafe void glEnd() => instance.glEnd();
        
        static unsafe void glEndConditionalRender() => instance.glEndConditionalRender();
        
        static unsafe void glEndConditionalRenderNV() => instance.glEndConditionalRenderNV();
        
        static unsafe void glEndConditionalRenderNVX() => instance.glEndConditionalRenderNVX();
        
        static unsafe void glEndFragmentShaderATI() => instance.glEndFragmentShaderATI();
        
        static unsafe void glEndList() => instance.glEndList();
        
        static unsafe void glEndOcclusionQueryNV() => instance.glEndOcclusionQueryNV();
        
        static unsafe void glEndPerfMonitorAMD(uint monitor) => instance.glEndPerfMonitorAMD(monitor);
        
        static unsafe void glEndPerfQueryINTEL(uint queryHandle) => instance.glEndPerfQueryINTEL(queryHandle);
        
        static unsafe void glEndQuery(QueryTarget target) => instance.glEndQuery(target);
        
        static unsafe void glEndQueryARB(QueryTarget target) => instance.glEndQueryARB(target);
        
        static unsafe void glEndQueryEXT(QueryTarget target) => instance.glEndQueryEXT(target);
        
        static unsafe void glEndQueryIndexed(QueryTarget target, uint index) => instance.glEndQueryIndexed(target, index);
        
        static unsafe void glEndTilingQCOM(uint preserveMask) => instance.glEndTilingQCOM(preserveMask);
        
        static unsafe void glEndTransformFeedback() => instance.glEndTransformFeedback();
        
        static unsafe void glEndTransformFeedbackEXT() => instance.glEndTransformFeedbackEXT();
        
        static unsafe void glEndTransformFeedbackNV() => instance.glEndTransformFeedbackNV();
        
        static unsafe void glEndVertexShaderEXT() => instance.glEndVertexShaderEXT();
        
        static unsafe void glEndVideoCaptureNV(uint video_capture_slot) => instance.glEndVideoCaptureNV(video_capture_slot);
        
        static unsafe void glEvalCoord1d(double u) => instance.glEvalCoord1d(u);
        
        static unsafe void glEvalCoord1dv(double * u) => instance.glEvalCoord1dv(u);
        
        static unsafe void glEvalCoord1f(float u) => instance.glEvalCoord1f(u);
        
        static unsafe void glEvalCoord1fv(float * u) => instance.glEvalCoord1fv(u);
        
        static unsafe void glEvalCoord1xOES(int u) => instance.glEvalCoord1xOES(u);
        
        static unsafe void glEvalCoord1xvOES(int * coords) => instance.glEvalCoord1xvOES(coords);
        
        static unsafe void glEvalCoord2d(double u, double v) => instance.glEvalCoord2d(u, v);
        
        static unsafe void glEvalCoord2dv(double * u) => instance.glEvalCoord2dv(u);
        
        static unsafe void glEvalCoord2f(float u, float v) => instance.glEvalCoord2f(u, v);
        
        static unsafe void glEvalCoord2fv(float * u) => instance.glEvalCoord2fv(u);
        
        static unsafe void glEvalCoord2xOES(int u, int v) => instance.glEvalCoord2xOES(u, v);
        
        static unsafe void glEvalCoord2xvOES(int * coords) => instance.glEvalCoord2xvOES(coords);
        
        static unsafe void glEvalMapsNV(EvalTargetNV target, EvalMapsModeNV mode) => instance.glEvalMapsNV(target, mode);
        
        static unsafe void glEvalMesh1(MeshMode1 mode, int i1, int i2) => instance.glEvalMesh1(mode, i1, i2);
        
        static unsafe void glEvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2) => instance.glEvalMesh2(mode, i1, i2, j1, j2);
        
        static unsafe void glEvalPoint1(int i) => instance.glEvalPoint1(i);
        
        static unsafe void glEvalPoint2(int i, int j) => instance.glEvalPoint2(i, j);
        
        static unsafe void glEvaluateDepthValuesARB() => instance.glEvaluateDepthValuesARB();
        
        static unsafe void glExecuteProgramNV(VertexAttribEnumNV target, uint id, float * PARAMS) => instance.glExecuteProgramNV(target, id, PARAMS);
        
        static unsafe void glExtGetBuffersQCOM(uint * buffers, int maxBuffers, int * numBuffers) => instance.glExtGetBuffersQCOM(buffers, maxBuffers, numBuffers);
        
        static unsafe void glExtGetFramebuffersQCOM(uint * framebuffers, int maxFramebuffers, int * numFramebuffers) => instance.glExtGetFramebuffersQCOM(framebuffers, maxFramebuffers, numFramebuffers);
        
        static unsafe void glExtGetProgramBinarySourceQCOM(uint program, ShaderType shadertype, char * source, int * length) => instance.glExtGetProgramBinarySourceQCOM(program, shadertype, source, length);
        
        static unsafe void glExtGetProgramsQCOM(uint * programs, int maxPrograms, int * numPrograms) => instance.glExtGetProgramsQCOM(programs, maxPrograms, numPrograms);
        
        static unsafe void glExtGetRenderbuffersQCOM(uint * renderbuffers, int maxRenderbuffers, int * numRenderbuffers) => instance.glExtGetRenderbuffersQCOM(renderbuffers, maxRenderbuffers, numRenderbuffers);
        
        static unsafe void glExtGetShadersQCOM(uint * shaders, int maxShaders, int * numShaders) => instance.glExtGetShadersQCOM(shaders, maxShaders, numShaders);
        
        static unsafe void glExtGetTexturesQCOM(uint * textures, int maxTextures, int * numTextures) => instance.glExtGetTexturesQCOM(textures, maxTextures, numTextures);
        
        static unsafe bool glExtIsProgramBinaryQCOM(uint program) => instance.glExtIsProgramBinaryQCOM(program);
        
        static unsafe void glExtractComponentEXT(uint res, uint src, uint num) => instance.glExtractComponentEXT(res, src, num);
        
        static unsafe void glFeedbackBuffer(uint size, FeedbackType type, float * buffer) => instance.glFeedbackBuffer(size, type, buffer);
        
        static unsafe IntPtr glFenceSync(SyncCondition condition, uint flags) => instance.glFenceSync(condition, flags);
        
        static unsafe IntPtr glFenceSyncAPPLE(SyncCondition condition, uint flags) => instance.glFenceSyncAPPLE(condition, flags);
        
        static unsafe void glFinalCombinerInputNV(CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage) => instance.glFinalCombinerInputNV(variable, input, mapping, componentUsage);
        
        static unsafe void glFinish() => instance.glFinish();
        
        static unsafe int glFinishAsyncSGIX(uint * markerp) => instance.glFinishAsyncSGIX(markerp);
        
        static unsafe void glFinishFenceAPPLE(uint fence) => instance.glFinishFenceAPPLE(fence);
        
        static unsafe void glFinishFenceNV(uint fence) => instance.glFinishFenceNV(fence);
        
        static unsafe void glFinishObjectAPPLE(ObjectTypeAPPLE OBJECT, int name) => instance.glFinishObjectAPPLE(OBJECT, name);
        
        static unsafe void glFinishTextureSUNX() => instance.glFinishTextureSUNX();
        
        static unsafe void glFlush() => instance.glFlush();
        
        static unsafe void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, UIntPtr length) => instance.glFlushMappedBufferRange(target, offset, length);
        
        static unsafe void glFlushMappedBufferRangeAPPLE(BufferTargetARB target, IntPtr offset, UIntPtr size) => instance.glFlushMappedBufferRangeAPPLE(target, offset, size);
        
        static unsafe void glFlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, UIntPtr length) => instance.glFlushMappedBufferRangeEXT(target, offset, length);
        
        static unsafe void glFlushMappedNamedBufferRange(uint buffer, IntPtr offset, UIntPtr length) => instance.glFlushMappedNamedBufferRange(buffer, offset, length);
        
        static unsafe void glFlushMappedNamedBufferRangeEXT(uint buffer, IntPtr offset, UIntPtr length) => instance.glFlushMappedNamedBufferRangeEXT(buffer, offset, length);
        
        static unsafe void glFlushPixelDataRangeNV(PixelDataRangeTargetNV target) => instance.glFlushPixelDataRangeNV(target);
        
        static unsafe void glFlushRasterSGIX() => instance.glFlushRasterSGIX();
        
        static unsafe void glFlushVertexArrayRangeAPPLE(uint length, void * pointer) => instance.glFlushVertexArrayRangeAPPLE(length, pointer);
        
        static unsafe void glFlushVertexArrayRangeNV() => instance.glFlushVertexArrayRangeNV();
        
        static unsafe void glFogCoordPointer(FogPointerTypeEXT type, uint stride, void * pointer) => instance.glFogCoordPointer(type, stride, pointer);
        
        static unsafe void glFogCoordPointerEXT(FogPointerTypeEXT type, uint stride, void * pointer) => instance.glFogCoordPointerEXT(type, stride, pointer);
        
        static unsafe void glFogCoordPointerListIBM(FogPointerTypeIBM type, int stride, void * * pointer, int ptrstride) => instance.glFogCoordPointerListIBM(type, stride, pointer, ptrstride);
        
        static unsafe void glFogCoordd(double coord) => instance.glFogCoordd(coord);
        
        static unsafe void glFogCoorddEXT(double coord) => instance.glFogCoorddEXT(coord);
        
        static unsafe void glFogCoorddv(double * coord) => instance.glFogCoorddv(coord);
        
        static unsafe void glFogCoorddvEXT(double * coord) => instance.glFogCoorddvEXT(coord);
        
        static unsafe void glFogCoordf(float coord) => instance.glFogCoordf(coord);
        
        static unsafe void glFogCoordfEXT(float coord) => instance.glFogCoordfEXT(coord);
        
        static unsafe void glFogCoordfv(float * coord) => instance.glFogCoordfv(coord);
        
        static unsafe void glFogCoordfvEXT(float * coord) => instance.glFogCoordfvEXT(coord);
        
        static unsafe void glFogCoordhNV(OpenToolkit.Mathematics.Half fog) => instance.glFogCoordhNV(fog);
        
        static unsafe void glFogCoordhvNV(OpenToolkit.Mathematics.Half * fog) => instance.glFogCoordhvNV(fog);
        
        static unsafe void glFogFuncSGIS(uint n, float * points) => instance.glFogFuncSGIS(n, points);
        
        static unsafe void glFogf(FogParameter pname, float param) => instance.glFogf(pname, param);
        
        static unsafe void glFogfv(FogParameter pname, float * PARAMS) => instance.glFogfv(pname, PARAMS);
        
        static unsafe void glFogi(FogParameter pname, int param) => instance.glFogi(pname, param);
        
        static unsafe void glFogiv(FogParameter pname, int * PARAMS) => instance.glFogiv(pname, PARAMS);
        
        static unsafe void glFogx(FogPName pname, int param) => instance.glFogx(pname, param);
        
        static unsafe void glFogxOES(FogPName pname, int param) => instance.glFogxOES(pname, param);
        
        static unsafe void glFogxv(FogPName pname, int * param) => instance.glFogxv(pname, param);
        
        static unsafe void glFogxvOES(FogPName pname, int * param) => instance.glFogxvOES(pname, param);
        
        static unsafe void glFragmentColorMaterialSGIX(MaterialFace face, MaterialParameter mode) => instance.glFragmentColorMaterialSGIX(face, mode);
        
        static unsafe void glFragmentCoverageColorNV(uint color) => instance.glFragmentCoverageColorNV(color);
        
        static unsafe void glFragmentLightModelfSGIX(FragmentLightModelParameterSGIX pname, float param) => instance.glFragmentLightModelfSGIX(pname, param);
        
        static unsafe void glFragmentLightModelfvSGIX(FragmentLightModelParameterSGIX pname, float * PARAMS) => instance.glFragmentLightModelfvSGIX(pname, PARAMS);
        
        static unsafe void glFragmentLightModeliSGIX(FragmentLightModelParameterSGIX pname, int param) => instance.glFragmentLightModeliSGIX(pname, param);
        
        static unsafe void glFragmentLightModelivSGIX(FragmentLightModelParameterSGIX pname, int * PARAMS) => instance.glFragmentLightModelivSGIX(pname, PARAMS);
        
        static unsafe void glFragmentLightfSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float param) => instance.glFragmentLightfSGIX(light, pname, param);
        
        static unsafe void glFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float * PARAMS) => instance.glFragmentLightfvSGIX(light, pname, PARAMS);
        
        static unsafe void glFragmentLightiSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int param) => instance.glFragmentLightiSGIX(light, pname, param);
        
        static unsafe void glFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int * PARAMS) => instance.glFragmentLightivSGIX(light, pname, PARAMS);
        
        static unsafe void glFragmentMaterialfSGIX(MaterialFace face, MaterialParameter pname, float param) => instance.glFragmentMaterialfSGIX(face, pname, param);
        
        static unsafe void glFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float * PARAMS) => instance.glFragmentMaterialfvSGIX(face, pname, PARAMS);
        
        static unsafe void glFragmentMaterialiSGIX(MaterialFace face, MaterialParameter pname, int param) => instance.glFragmentMaterialiSGIX(face, pname, param);
        
        static unsafe void glFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int * PARAMS) => instance.glFragmentMaterialivSGIX(face, pname, PARAMS);
        
        static unsafe void glFrameTerminatorGREMEDY() => instance.glFrameTerminatorGREMEDY();
        
        static unsafe void glFrameZoomSGIX(int factor) => instance.glFrameZoomSGIX(factor);
        
        static unsafe void glFramebufferDrawBufferEXT(uint framebuffer, DrawBufferMode mode) => instance.glFramebufferDrawBufferEXT(framebuffer, mode);
        
        static unsafe void glFramebufferDrawBuffersEXT(uint framebuffer, uint n, DrawBufferMode * bufs) => instance.glFramebufferDrawBuffersEXT(framebuffer, n, bufs);
        
        static unsafe void glFramebufferFetchBarrierEXT() => instance.glFramebufferFetchBarrierEXT();
        
        static unsafe void glFramebufferFetchBarrierQCOM() => instance.glFramebufferFetchBarrierQCOM();
        
        static unsafe void glFramebufferFoveationConfigQCOM(uint framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint * providedFeatures) => instance.glFramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures);
        
        static unsafe void glFramebufferFoveationParametersQCOM(uint framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => instance.glFramebufferFoveationParametersQCOM(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
        
        static unsafe void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param) => instance.glFramebufferParameteri(target, pname, param);
        
        static unsafe void glFramebufferPixelLocalStorageSizeEXT(uint target, uint size) => instance.glFramebufferPixelLocalStorageSizeEXT(target, size);
        
        static unsafe void glFramebufferReadBufferEXT(uint framebuffer, ReadBufferMode mode) => instance.glFramebufferReadBufferEXT(framebuffer, mode);
        
        static unsafe void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer) => instance.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        
        static unsafe void glFramebufferRenderbufferEXT(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer) => instance.glFramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
        
        static unsafe void glFramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer) => instance.glFramebufferRenderbufferOES(target, attachment, renderbuffertarget, renderbuffer);
        
        static unsafe void glFramebufferSampleLocationsfvARB(FramebufferTarget target, uint start, uint count, float * v) => instance.glFramebufferSampleLocationsfvARB(target, start, count, v);
        
        static unsafe void glFramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, uint count, float * v) => instance.glFramebufferSampleLocationsfvNV(target, start, count, v);
        
        static unsafe void glFramebufferSamplePositionsfvAMD(FramebufferTarget target, uint numsamples, uint pixelindex, float * values) => instance.glFramebufferSamplePositionsfvAMD(target, numsamples, pixelindex, values);
        
        static unsafe void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level) => instance.glFramebufferTexture(target, attachment, texture, level);
        
        static unsafe void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => instance.glFramebufferTexture1D(target, attachment, textarget, texture, level);
        
        static unsafe void glFramebufferTexture1DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => instance.glFramebufferTexture1DEXT(target, attachment, textarget, texture, level);
        
        static unsafe void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => instance.glFramebufferTexture2D(target, attachment, textarget, texture, level);
        
        static unsafe void glFramebufferTexture2DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => instance.glFramebufferTexture2DEXT(target, attachment, textarget, texture, level);
        
        static unsafe void glFramebufferTexture2DDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int xscale, int yscale) => instance.glFramebufferTexture2DDownsampleIMG(target, attachment, textarget, texture, level, xscale, yscale);
        
        static unsafe void glFramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, uint samples) => instance.glFramebufferTexture2DMultisampleEXT(target, attachment, textarget, texture, level, samples);
        
        static unsafe void glFramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, uint samples) => instance.glFramebufferTexture2DMultisampleIMG(target, attachment, textarget, texture, level, samples);
        
        static unsafe void glFramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => instance.glFramebufferTexture2DOES(target, attachment, textarget, texture, level);
        
        static unsafe void glFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset) => instance.glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
        
        static unsafe void glFramebufferTexture3DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset) => instance.glFramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
        
        static unsafe void glFramebufferTexture3DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset) => instance.glFramebufferTexture3DOES(target, attachment, textarget, texture, level, zoffset);
        
        static unsafe void glFramebufferTextureARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level) => instance.glFramebufferTextureARB(target, attachment, texture, level);
        
        static unsafe void glFramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level) => instance.glFramebufferTextureEXT(target, attachment, texture, level);
        
        static unsafe void glFramebufferTextureFaceARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face) => instance.glFramebufferTextureFaceARB(target, attachment, texture, level, face);
        
        static unsafe void glFramebufferTextureFaceEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face) => instance.glFramebufferTextureFaceEXT(target, attachment, texture, level, face);
        
        static unsafe void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer) => instance.glFramebufferTextureLayer(target, attachment, texture, level, layer);
        
        static unsafe void glFramebufferTextureLayerARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer) => instance.glFramebufferTextureLayerARB(target, attachment, texture, level, layer);
        
        static unsafe void glFramebufferTextureLayerEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer) => instance.glFramebufferTextureLayerEXT(target, attachment, texture, level, layer);
        
        static unsafe void glFramebufferTextureLayerDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer, int xscale, int yscale) => instance.glFramebufferTextureLayerDownsampleIMG(target, attachment, texture, level, layer, xscale, yscale);
        
        static unsafe void glFramebufferTextureMultisampleMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, uint samples, int baseViewIndex, uint numViews) => instance.glFramebufferTextureMultisampleMultiviewOVR(target, attachment, texture, level, samples, baseViewIndex, numViews);
        
        static unsafe void glFramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int baseViewIndex, uint numViews) => instance.glFramebufferTextureMultiviewOVR(target, attachment, texture, level, baseViewIndex, numViews);
        
        static unsafe void glFramebufferTextureOES(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level) => instance.glFramebufferTextureOES(target, attachment, texture, level);
        
        static unsafe void glFreeObjectBufferATI(uint buffer) => instance.glFreeObjectBufferATI(buffer);
        
        static unsafe void glFrontFace(FrontFaceDirection mode) => instance.glFrontFace(mode);
        
        static unsafe void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar) => instance.glFrustum(left, right, bottom, top, zNear, zFar);
        
        static unsafe void glFrustumf(float l, float r, float b, float t, float n, float f) => instance.glFrustumf(l, r, b, t, n, f);
        
        static unsafe void glFrustumfOES(float l, float r, float b, float t, float n, float f) => instance.glFrustumfOES(l, r, b, t, n, f);
        
        static unsafe void glFrustumx(int l, int r, int b, int t, int n, int f) => instance.glFrustumx(l, r, b, t, n, f);
        
        static unsafe void glFrustumxOES(int l, int r, int b, int t, int n, int f) => instance.glFrustumxOES(l, r, b, t, n, f);
        
        static unsafe uint glGenAsyncMarkersSGIX(uint range) => instance.glGenAsyncMarkersSGIX(range);
        
        static unsafe void glGenBuffers(uint n, uint * buffers) => instance.glGenBuffers(n, buffers);
        
        static unsafe void glGenBuffersARB(uint n, uint * buffers) => instance.glGenBuffersARB(n, buffers);
        
        static unsafe void glGenFencesAPPLE(uint n, uint * fences) => instance.glGenFencesAPPLE(n, fences);
        
        static unsafe void glGenFencesNV(uint n, uint * fences) => instance.glGenFencesNV(n, fences);
        
        static unsafe uint glGenFragmentShadersATI(uint range) => instance.glGenFragmentShadersATI(range);
        
        static unsafe void glGenFramebuffers(uint n, uint * framebuffers) => instance.glGenFramebuffers(n, framebuffers);
        
        static unsafe void glGenFramebuffersEXT(uint n, uint * framebuffers) => instance.glGenFramebuffersEXT(n, framebuffers);
        
        static unsafe void glGenFramebuffersOES(uint n, uint * framebuffers) => instance.glGenFramebuffersOES(n, framebuffers);
        
        static unsafe uint glGenLists(uint range) => instance.glGenLists(range);
        
        static unsafe void glGenOcclusionQueriesNV(uint n, uint * ids) => instance.glGenOcclusionQueriesNV(n, ids);
        
        static unsafe uint glGenPathsNV(uint range) => instance.glGenPathsNV(range);
        
        static unsafe void glGenPerfMonitorsAMD(uint n, uint * monitors) => instance.glGenPerfMonitorsAMD(n, monitors);
        
        static unsafe void glGenProgramPipelines(uint n, uint * pipelines) => instance.glGenProgramPipelines(n, pipelines);
        
        static unsafe void glGenProgramPipelinesEXT(uint n, uint * pipelines) => instance.glGenProgramPipelinesEXT(n, pipelines);
        
        static unsafe void glGenProgramsARB(uint n, uint * programs) => instance.glGenProgramsARB(n, programs);
        
        static unsafe void glGenProgramsNV(uint n, uint * programs) => instance.glGenProgramsNV(n, programs);
        
        static unsafe void glGenQueries(uint n, uint * ids) => instance.glGenQueries(n, ids);
        
        static unsafe void glGenQueriesARB(uint n, uint * ids) => instance.glGenQueriesARB(n, ids);
        
        static unsafe void glGenQueriesEXT(uint n, uint * ids) => instance.glGenQueriesEXT(n, ids);
        
        static unsafe void glGenQueryResourceTagNV(uint n, int * tagIds) => instance.glGenQueryResourceTagNV(n, tagIds);
        
        static unsafe void glGenRenderbuffers(uint n, uint * renderbuffers) => instance.glGenRenderbuffers(n, renderbuffers);
        
        static unsafe void glGenRenderbuffersEXT(uint n, uint * renderbuffers) => instance.glGenRenderbuffersEXT(n, renderbuffers);
        
        static unsafe void glGenRenderbuffersOES(uint n, uint * renderbuffers) => instance.glGenRenderbuffersOES(n, renderbuffers);
        
        static unsafe void glGenSamplers(uint count, uint * samplers) => instance.glGenSamplers(count, samplers);
        
        static unsafe void glGenSemaphoresEXT(uint n, uint * semaphores) => instance.glGenSemaphoresEXT(n, semaphores);
        
        static unsafe uint glGenSymbolsEXT(DataTypeEXT datatype, VertexShaderStorageTypeEXT storagetype, ParameterRangeEXT range, uint components) => instance.glGenSymbolsEXT(datatype, storagetype, range, components);
        
        static unsafe void glGenTextures(uint n, uint * textures) => instance.glGenTextures(n, textures);
        
        static unsafe void glGenTexturesEXT(uint n, uint * textures) => instance.glGenTexturesEXT(n, textures);
        
        static unsafe void glGenTransformFeedbacks(uint n, uint * ids) => instance.glGenTransformFeedbacks(n, ids);
        
        static unsafe void glGenTransformFeedbacksNV(uint n, uint * ids) => instance.glGenTransformFeedbacksNV(n, ids);
        
        static unsafe void glGenVertexArrays(uint n, uint * arrays) => instance.glGenVertexArrays(n, arrays);
        
        static unsafe void glGenVertexArraysAPPLE(uint n, uint * arrays) => instance.glGenVertexArraysAPPLE(n, arrays);
        
        static unsafe void glGenVertexArraysOES(uint n, uint * arrays) => instance.glGenVertexArraysOES(n, arrays);
        
        static unsafe uint glGenVertexShadersEXT(uint range) => instance.glGenVertexShadersEXT(range);
        
        static unsafe void glGenerateMipmap(TextureTarget target) => instance.glGenerateMipmap(target);
        
        static unsafe void glGenerateMipmapEXT(TextureTarget target) => instance.glGenerateMipmapEXT(target);
        
        static unsafe void glGenerateMipmapOES(TextureTarget target) => instance.glGenerateMipmapOES(target);
        
        static unsafe void glGenerateMultiTexMipmapEXT(TextureUnit texunit, TextureTarget target) => instance.glGenerateMultiTexMipmapEXT(texunit, target);
        
        static unsafe void glGenerateTextureMipmap(uint texture) => instance.glGenerateTextureMipmap(texture);
        
        static unsafe void glGenerateTextureMipmapEXT(uint texture, TextureTarget target) => instance.glGenerateTextureMipmapEXT(texture, target);
        
        static unsafe void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, AtomicCounterBufferPName pname, int * PARAMS) => instance.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, PARAMS);
        
        static unsafe void glGetActiveAttrib(uint program, uint index, uint bufSize, uint * length, int * size, AttributeType * type, char * name) => instance.glGetActiveAttrib(program, index, bufSize, length, size, type, name);
        
        static unsafe void glGetActiveAttribARB(uint programObj, uint index, uint maxLength, uint * length, int * size, AttributeType * type, char * name) => instance.glGetActiveAttribARB(programObj, index, maxLength, length, size, type, name);
        
        static unsafe void glGetActiveSubroutineName(uint program, ShaderType shadertype, uint index, uint bufsize, uint * length, char * name) => instance.glGetActiveSubroutineName(program, shadertype, index, bufsize, length, name);
        
        static unsafe void glGetActiveSubroutineUniformName(uint program, ShaderType shadertype, uint index, uint bufsize, uint * length, char * name) => instance.glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, length, name);
        
        static unsafe void glGetActiveSubroutineUniformiv(uint program, ShaderType shadertype, uint index, SubroutineParameterName pname, int * values) => instance.glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
        
        static unsafe void glGetActiveUniform(uint program, uint index, uint bufSize, uint * length, int * size, UniformType * type, char * name) => instance.glGetActiveUniform(program, index, bufSize, length, size, type, name);
        
        static unsafe void glGetActiveUniformARB(uint programObj, uint index, uint maxLength, uint * length, int * size, UniformType * type, char * name) => instance.glGetActiveUniformARB(programObj, index, maxLength, length, size, type, name);
        
        static unsafe void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, uint bufSize, uint * length, char * uniformBlockName) => instance.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        
        static unsafe void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int * PARAMS) => instance.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, PARAMS);
        
        static unsafe void glGetActiveUniformName(uint program, uint uniformIndex, uint bufSize, uint * length, char * uniformName) => instance.glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
        
        static unsafe void glGetActiveUniformsiv(uint program, uint uniformCount, uint * uniformIndices, UniformPName pname, int * PARAMS) => instance.glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, PARAMS);
        
        static unsafe void glGetArrayObjectfvATI(EnableCap array, ArrayObjectPNameATI pname, float * PARAMS) => instance.glGetArrayObjectfvATI(array, pname, PARAMS);
        
        static unsafe void glGetArrayObjectivATI(EnableCap array, ArrayObjectPNameATI pname, int * PARAMS) => instance.glGetArrayObjectivATI(array, pname, PARAMS);
        
        static unsafe void glGetAttachedObjectsARB(uint containerObj, uint maxCount, uint * count, uint * obj) => instance.glGetAttachedObjectsARB(containerObj, maxCount, count, obj);
        
        static unsafe void glGetAttachedShaders(uint program, uint maxCount, uint * count, uint * shaders) => instance.glGetAttachedShaders(program, maxCount, count, shaders);
        
        static unsafe int glGetAttribLocation(uint program, char * name) => instance.glGetAttribLocation(program, name);
        
        static unsafe int glGetAttribLocationARB(uint programObj, char * name) => instance.glGetAttribLocationARB(programObj, name);
        
        static unsafe void glGetBooleanIndexedvEXT(BufferTargetARB target, uint index, bool * data) => instance.glGetBooleanIndexedvEXT(target, index, data);
        
        static unsafe void glGetBooleani_v(BufferTargetARB target, uint index, bool * data) => instance.glGetBooleani_v(target, index, data);
        
        static unsafe void glGetBooleanv(GetPName pname, bool * data) => instance.glGetBooleanv(pname, data);
        
        static unsafe void glGetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long * PARAMS) => instance.glGetBufferParameteri64v(target, pname, PARAMS);
        
        static unsafe void glGetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int * PARAMS) => instance.glGetBufferParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetBufferParameterivARB(BufferTargetARB target, BufferPNameARB pname, int * PARAMS) => instance.glGetBufferParameterivARB(target, pname, PARAMS);
        
        static unsafe void glGetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void * * PARAMS) => instance.glGetBufferPointerv(target, pname, PARAMS);
        
        static unsafe void glGetBufferPointervARB(BufferTargetARB target, BufferPointerNameARB pname, void * * PARAMS) => instance.glGetBufferPointervARB(target, pname, PARAMS);
        
        static unsafe void glGetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void * * PARAMS) => instance.glGetBufferPointervOES(target, pname, PARAMS);
        
        static unsafe void glGetBufferSubData(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data) => instance.glGetBufferSubData(target, offset, size, data);
        
        static unsafe void glGetBufferSubDataARB(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data) => instance.glGetBufferSubDataARB(target, offset, size, data);
        
        static unsafe void glGetClipPlane(ClipPlaneName plane, double * equation) => instance.glGetClipPlane(plane, equation);
        
        static unsafe void glGetClipPlanef(ClipPlaneName plane, float * equation) => instance.glGetClipPlanef(plane, equation);
        
        static unsafe void glGetClipPlanefOES(ClipPlaneName plane, float * equation) => instance.glGetClipPlanefOES(plane, equation);
        
        static unsafe void glGetClipPlanex(ClipPlaneName plane, int * equation) => instance.glGetClipPlanex(plane, equation);
        
        static unsafe void glGetClipPlanexOES(ClipPlaneName plane, int * equation) => instance.glGetClipPlanexOES(plane, equation);
        
        static unsafe void glGetColorTable(ColorTableTarget target, PixelFormat format, PixelType type, void * table) => instance.glGetColorTable(target, format, type, table);
        
        static unsafe void glGetColorTableEXT(ColorTableTarget target, PixelFormat format, PixelType type, void * data) => instance.glGetColorTableEXT(target, format, type, data);
        
        static unsafe void glGetColorTableParameterfv(ColorTableTarget target, GetColorTableParameterPNameSGI pname, float * PARAMS) => instance.glGetColorTableParameterfv(target, pname, PARAMS);
        
        static unsafe void glGetColorTableParameterfvEXT(ColorTableTarget target, GetColorTableParameterPNameSGI pname, float * PARAMS) => instance.glGetColorTableParameterfvEXT(target, pname, PARAMS);
        
        static unsafe void glGetColorTableParameterfvSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, float * PARAMS) => instance.glGetColorTableParameterfvSGI(target, pname, PARAMS);
        
        static unsafe void glGetColorTableParameteriv(ColorTableTarget target, GetColorTableParameterPNameSGI pname, int * PARAMS) => instance.glGetColorTableParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetColorTableParameterivEXT(ColorTableTarget target, GetColorTableParameterPNameSGI pname, int * PARAMS) => instance.glGetColorTableParameterivEXT(target, pname, PARAMS);
        
        static unsafe void glGetColorTableParameterivSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, int * PARAMS) => instance.glGetColorTableParameterivSGI(target, pname, PARAMS);
        
        static unsafe void glGetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, void * table) => instance.glGetColorTableSGI(target, format, type, table);
        
        static unsafe void glGetCombinerInputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, float * PARAMS) => instance.glGetCombinerInputParameterfvNV(stage, portion, variable, pname, PARAMS);
        
        static unsafe void glGetCombinerInputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, int * PARAMS) => instance.glGetCombinerInputParameterivNV(stage, portion, variable, pname, PARAMS);
        
        static unsafe void glGetCombinerOutputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, float * PARAMS) => instance.glGetCombinerOutputParameterfvNV(stage, portion, pname, PARAMS);
        
        static unsafe void glGetCombinerOutputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, int * PARAMS) => instance.glGetCombinerOutputParameterivNV(stage, portion, pname, PARAMS);
        
        static unsafe void glGetCombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float * PARAMS) => instance.glGetCombinerStageParameterfvNV(stage, pname, PARAMS);
        
        static unsafe void glGetCompressedMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int lod, void * img) => instance.glGetCompressedMultiTexImageEXT(texunit, target, lod, img);
        
        static unsafe void glGetCompressedTexImage(TextureTarget target, int level, void * img) => instance.glGetCompressedTexImage(target, level, img);
        
        static unsafe void glGetCompressedTexImageARB(TextureTarget target, int level, void * img) => instance.glGetCompressedTexImageARB(target, level, img);
        
        static unsafe void glGetCompressedTextureImage(uint texture, int level, uint bufSize, void * pixels) => instance.glGetCompressedTextureImage(texture, level, bufSize, pixels);
        
        static unsafe void glGetCompressedTextureImageEXT(uint texture, TextureTarget target, int lod, void * img) => instance.glGetCompressedTextureImageEXT(texture, target, lod, img);
        
        static unsafe void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint bufSize, void * pixels) => instance.glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        
        static unsafe void glGetConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, void * image) => instance.glGetConvolutionFilter(target, format, type, image);
        
        static unsafe void glGetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, void * image) => instance.glGetConvolutionFilterEXT(target, format, type, image);
        
        static unsafe void glGetConvolutionParameterfv(ConvolutionTarget target, ConvolutionParameterEXT pname, float * PARAMS) => instance.glGetConvolutionParameterfv(target, pname, PARAMS);
        
        static unsafe void glGetConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float * PARAMS) => instance.glGetConvolutionParameterfvEXT(target, pname, PARAMS);
        
        static unsafe void glGetConvolutionParameteriv(ConvolutionTarget target, ConvolutionParameterEXT pname, int * PARAMS) => instance.glGetConvolutionParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int * PARAMS) => instance.glGetConvolutionParameterivEXT(target, pname, PARAMS);
        
        static unsafe void glGetCoverageModulationTableNV(uint bufsize, float * v) => instance.glGetCoverageModulationTableNV(bufsize, v);
        
        static unsafe uint glGetDebugMessageLog(uint count, uint bufSize, DebugSource * sources, DebugType * types, uint * ids, DebugSeverity * severities, uint * lengths, char * messageLog) => instance.glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
        
        static unsafe uint glGetDebugMessageLogARB(uint count, uint bufSize, DebugSource * sources, DebugType * types, uint * ids, DebugSeverity * severities, uint * lengths, char * messageLog) => instance.glGetDebugMessageLogARB(count, bufSize, sources, types, ids, severities, lengths, messageLog);
        
        static unsafe uint glGetDebugMessageLogKHR(uint count, uint bufSize, DebugSource * sources, DebugType * types, uint * ids, DebugSeverity * severities, uint * lengths, char * messageLog) => instance.glGetDebugMessageLogKHR(count, bufSize, sources, types, ids, severities, lengths, messageLog);
        
        static unsafe void glGetDetailTexFuncSGIS(TextureTarget target, float * points) => instance.glGetDetailTexFuncSGIS(target, points);
        
        static unsafe void glGetDoublev(GetPName pname, double * data) => instance.glGetDoublev(pname, data);
        
        static unsafe void glGetDriverControlStringQCOM(uint driverControl, uint bufSize, uint * length, char * driverControlString) => instance.glGetDriverControlStringQCOM(driverControl, bufSize, length, driverControlString);
        
        static unsafe void glGetDriverControlsQCOM(int * num, uint size, uint * driverControls) => instance.glGetDriverControlsQCOM(num, size, driverControls);
        
        static unsafe ErrorCode glGetError() => instance.glGetError();
        
        static unsafe void glGetFenceivNV(uint fence, FenceParameterNameNV pname, int * PARAMS) => instance.glGetFenceivNV(fence, pname, PARAMS);
        
        static unsafe void glGetFinalCombinerInputParameterfvNV(CombinerVariableNV variable, CombinerParameterNV pname, float * PARAMS) => instance.glGetFinalCombinerInputParameterfvNV(variable, pname, PARAMS);
        
        static unsafe void glGetFinalCombinerInputParameterivNV(CombinerVariableNV variable, CombinerParameterNV pname, int * PARAMS) => instance.glGetFinalCombinerInputParameterivNV(variable, pname, PARAMS);
        
        static unsafe void glGetFirstPerfQueryIdINTEL(uint * queryId) => instance.glGetFirstPerfQueryIdINTEL(queryId);
        
        static unsafe void glGetFixedv(GetPName pname, int * PARAMS) => instance.glGetFixedv(pname, PARAMS);
        
        static unsafe void glGetFixedvOES(GetPName pname, int * PARAMS) => instance.glGetFixedvOES(pname, PARAMS);
        
        static unsafe void glGetFloatv(GetPName pname, float * data) => instance.glGetFloatv(pname, data);
        
        static unsafe void glGetFogFuncSGIS(float * points) => instance.glGetFogFuncSGIS(points);
        
        static unsafe int glGetFragDataIndex(uint program, char * name) => instance.glGetFragDataIndex(program, name);
        
        static unsafe int glGetFragDataIndexEXT(uint program, char * name) => instance.glGetFragDataIndexEXT(program, name);
        
        static unsafe int glGetFragDataLocation(uint program, char * name) => instance.glGetFragDataLocation(program, name);
        
        static unsafe int glGetFragDataLocationEXT(uint program, char * name) => instance.glGetFragDataLocationEXT(program, name);
        
        static unsafe void glGetFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float * PARAMS) => instance.glGetFragmentLightfvSGIX(light, pname, PARAMS);
        
        static unsafe void glGetFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int * PARAMS) => instance.glGetFragmentLightivSGIX(light, pname, PARAMS);
        
        static unsafe void glGetFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float * PARAMS) => instance.glGetFragmentMaterialfvSGIX(face, pname, PARAMS);
        
        static unsafe void glGetFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int * PARAMS) => instance.glGetFragmentMaterialivSGIX(face, pname, PARAMS);
        
        static unsafe void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS) => instance.glGetFramebufferAttachmentParameteriv(target, attachment, pname, PARAMS);
        
        static unsafe void glGetFramebufferAttachmentParameterivEXT(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS) => instance.glGetFramebufferAttachmentParameterivEXT(target, attachment, pname, PARAMS);
        
        static unsafe void glGetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS) => instance.glGetFramebufferAttachmentParameterivOES(target, attachment, pname, PARAMS);
        
        static unsafe void glGetFramebufferParameterfvAMD(FramebufferTarget target, FramebufferAttachmentParameterName pname, uint numsamples, uint pixelindex, uint size, float * values) => instance.glGetFramebufferParameterfvAMD(target, pname, numsamples, pixelindex, size, values);
        
        static unsafe void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int * PARAMS) => instance.glGetFramebufferParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetFramebufferParameterivEXT(uint framebuffer, GetFramebufferParameter pname, int * PARAMS) => instance.glGetFramebufferParameterivEXT(framebuffer, pname, PARAMS);
        
        static unsafe uint glGetFramebufferPixelLocalStorageSizeEXT(uint target) => instance.glGetFramebufferPixelLocalStorageSizeEXT(target);
        
        static unsafe GraphicsResetStatus glGetGraphicsResetStatus() => instance.glGetGraphicsResetStatus();
        
        static unsafe GraphicsResetStatus glGetGraphicsResetStatusARB() => instance.glGetGraphicsResetStatusARB();
        
        static unsafe GraphicsResetStatus glGetGraphicsResetStatusEXT() => instance.glGetGraphicsResetStatusEXT();
        
        static unsafe GraphicsResetStatus glGetGraphicsResetStatusKHR() => instance.glGetGraphicsResetStatusKHR();
        
        static unsafe void glGetHistogram(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values) => instance.glGetHistogram(target, reset, format, type, values);
        
        static unsafe void glGetHistogramEXT(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values) => instance.glGetHistogramEXT(target, reset, format, type, values);
        
        static unsafe void glGetHistogramParameterfv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float * PARAMS) => instance.glGetHistogramParameterfv(target, pname, PARAMS);
        
        static unsafe void glGetHistogramParameterfvEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float * PARAMS) => instance.glGetHistogramParameterfvEXT(target, pname, PARAMS);
        
        static unsafe void glGetHistogramParameteriv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int * PARAMS) => instance.glGetHistogramParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetHistogramParameterivEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int * PARAMS) => instance.glGetHistogramParameterivEXT(target, pname, PARAMS);
        
        static unsafe void glGetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int * PARAMS) => instance.glGetHistogramParameterxvOES(target, pname, PARAMS);
        
        static unsafe ulong glGetImageHandleARB(uint texture, int level, bool layered, int layer, PixelFormat format) => instance.glGetImageHandleARB(texture, level, layered, layer, format);
        
        static unsafe ulong glGetImageHandleNV(uint texture, int level, bool layered, int layer, PixelFormat format) => instance.glGetImageHandleNV(texture, level, layered, layer, format);
        
        static unsafe void glGetImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float * PARAMS) => instance.glGetImageTransformParameterfvHP(target, pname, PARAMS);
        
        static unsafe void glGetImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int * PARAMS) => instance.glGetImageTransformParameterivHP(target, pname, PARAMS);
        
        static unsafe void glGetInfoLogARB(uint obj, uint maxLength, uint * length, char * infoLog) => instance.glGetInfoLogARB(obj, maxLength, length, infoLog);
        
        static unsafe int glGetInstrumentsSGIX() => instance.glGetInstrumentsSGIX();
        
        static unsafe void glGetInteger64v(GetPName pname, long * data) => instance.glGetInteger64v(pname, data);
        
        static unsafe void glGetInteger64vAPPLE(GetPName pname, long * PARAMS) => instance.glGetInteger64vAPPLE(pname, PARAMS);
        
        static unsafe void glGetIntegerv(GetPName pname, int * data) => instance.glGetIntegerv(pname, data);
        
        static unsafe void glGetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, uint samples, InternalFormatPName pname, uint bufSize, int * PARAMS) => instance.glGetInternalformatSampleivNV(target, internalformat, samples, pname, bufSize, PARAMS);
        
        static unsafe void glGetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, uint bufSize, long * PARAMS) => instance.glGetInternalformati64v(target, internalformat, pname, bufSize, PARAMS);
        
        static unsafe void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, uint bufSize, int * PARAMS) => instance.glGetInternalformativ(target, internalformat, pname, bufSize, PARAMS);
        
        static unsafe void glGetInvariantBooleanvEXT(uint id, GetVariantValueEXT value, bool * data) => instance.glGetInvariantBooleanvEXT(id, value, data);
        
        static unsafe void glGetInvariantFloatvEXT(uint id, GetVariantValueEXT value, float * data) => instance.glGetInvariantFloatvEXT(id, value, data);
        
        static unsafe void glGetInvariantIntegervEXT(uint id, GetVariantValueEXT value, int * data) => instance.glGetInvariantIntegervEXT(id, value, data);
        
        static unsafe void glGetLightfv(LightName light, LightParameter pname, float * PARAMS) => instance.glGetLightfv(light, pname, PARAMS);
        
        static unsafe void glGetLightiv(LightName light, LightParameter pname, int * PARAMS) => instance.glGetLightiv(light, pname, PARAMS);
        
        static unsafe void glGetLightxOES(LightName light, LightParameter pname, int * PARAMS) => instance.glGetLightxOES(light, pname, PARAMS);
        
        static unsafe void glGetLightxv(LightName light, LightParameter pname, int * PARAMS) => instance.glGetLightxv(light, pname, PARAMS);
        
        static unsafe void glGetLightxvOES(LightName light, LightParameter pname, int * PARAMS) => instance.glGetLightxvOES(light, pname, PARAMS);
        
        static unsafe void glGetListParameterfvSGIX(uint list, ListParameterName pname, float * PARAMS) => instance.glGetListParameterfvSGIX(list, pname, PARAMS);
        
        static unsafe void glGetListParameterivSGIX(uint list, ListParameterName pname, int * PARAMS) => instance.glGetListParameterivSGIX(list, pname, PARAMS);
        
        static unsafe void glGetLocalConstantBooleanvEXT(uint id, GetVariantValueEXT value, bool * data) => instance.glGetLocalConstantBooleanvEXT(id, value, data);
        
        static unsafe void glGetLocalConstantFloatvEXT(uint id, GetVariantValueEXT value, float * data) => instance.glGetLocalConstantFloatvEXT(id, value, data);
        
        static unsafe void glGetLocalConstantIntegervEXT(uint id, GetVariantValueEXT value, int * data) => instance.glGetLocalConstantIntegervEXT(id, value, data);
        
        static unsafe void glGetMapAttribParameterfvNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, float * PARAMS) => instance.glGetMapAttribParameterfvNV(target, index, pname, PARAMS);
        
        static unsafe void glGetMapAttribParameterivNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, int * PARAMS) => instance.glGetMapAttribParameterivNV(target, index, pname, PARAMS);
        
        static unsafe void glGetMapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, uint ustride, uint vstride, bool packed, void * points) => instance.glGetMapControlPointsNV(target, index, type, ustride, vstride, packed, points);
        
        static unsafe void glGetMapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float * PARAMS) => instance.glGetMapParameterfvNV(target, pname, PARAMS);
        
        static unsafe void glGetMapParameterivNV(EvalTargetNV target, MapParameterNV pname, int * PARAMS) => instance.glGetMapParameterivNV(target, pname, PARAMS);
        
        static unsafe void glGetMapdv(MapTarget target, GetMapQuery query, double * v) => instance.glGetMapdv(target, query, v);
        
        static unsafe void glGetMapfv(MapTarget target, GetMapQuery query, float * v) => instance.glGetMapfv(target, query, v);
        
        static unsafe void glGetMapiv(MapTarget target, GetMapQuery query, int * v) => instance.glGetMapiv(target, query, v);
        
        static unsafe void glGetMapxvOES(MapTarget target, GetMapQuery query, int * v) => instance.glGetMapxvOES(target, query, v);
        
        static unsafe void glGetMaterialfv(MaterialFace face, MaterialParameter pname, float * PARAMS) => instance.glGetMaterialfv(face, pname, PARAMS);
        
        static unsafe void glGetMaterialiv(MaterialFace face, MaterialParameter pname, int * PARAMS) => instance.glGetMaterialiv(face, pname, PARAMS);
        
        static unsafe void glGetMaterialxOES(MaterialFace face, MaterialParameter pname, int param) => instance.glGetMaterialxOES(face, pname, param);
        
        static unsafe void glGetMaterialxv(MaterialFace face, MaterialParameter pname, int * PARAMS) => instance.glGetMaterialxv(face, pname, PARAMS);
        
        static unsafe void glGetMaterialxvOES(MaterialFace face, MaterialParameter pname, int * PARAMS) => instance.glGetMaterialxvOES(face, pname, PARAMS);
        
        static unsafe void glGetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int * PARAMS) => instance.glGetMemoryObjectParameterivEXT(memoryObject, pname, PARAMS);
        
        static unsafe void glGetMinmax(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values) => instance.glGetMinmax(target, reset, format, type, values);
        
        static unsafe void glGetMinmaxEXT(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values) => instance.glGetMinmaxEXT(target, reset, format, type, values);
        
        static unsafe void glGetMinmaxParameterfv(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float * PARAMS) => instance.glGetMinmaxParameterfv(target, pname, PARAMS);
        
        static unsafe void glGetMinmaxParameterfvEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float * PARAMS) => instance.glGetMinmaxParameterfvEXT(target, pname, PARAMS);
        
        static unsafe void glGetMinmaxParameteriv(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int * PARAMS) => instance.glGetMinmaxParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetMinmaxParameterivEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int * PARAMS) => instance.glGetMinmaxParameterivEXT(target, pname, PARAMS);
        
        static unsafe void glGetMultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS) => instance.glGetMultiTexEnvfvEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glGetMultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glGetMultiTexEnvivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glGetMultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double * PARAMS) => instance.glGetMultiTexGendvEXT(texunit, coord, pname, PARAMS);
        
        static unsafe void glGetMultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float * PARAMS) => instance.glGetMultiTexGenfvEXT(texunit, coord, pname, PARAMS);
        
        static unsafe void glGetMultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glGetMultiTexGenivEXT(texunit, coord, pname, PARAMS);
        
        static unsafe void glGetMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int level, PixelFormat format, PixelType type, void * pixels) => instance.glGetMultiTexImageEXT(texunit, target, level, format, type, pixels);
        
        static unsafe void glGetMultiTexLevelParameterfvEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, float * PARAMS) => instance.glGetMultiTexLevelParameterfvEXT(texunit, target, level, pname, PARAMS);
        
        static unsafe void glGetMultiTexLevelParameterivEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, int * PARAMS) => instance.glGetMultiTexLevelParameterivEXT(texunit, target, level, pname, PARAMS);
        
        static unsafe void glGetMultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetMultiTexParameterIivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glGetMultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, uint * PARAMS) => instance.glGetMultiTexParameterIuivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glGetMultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, float * PARAMS) => instance.glGetMultiTexParameterfvEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glGetMultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetMultiTexParameterivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glGetMultisamplefv(GetMultisamplePNameNV pname, uint index, float * val) => instance.glGetMultisamplefv(pname, index, val);
        
        static unsafe void glGetMultisamplefvNV(GetMultisamplePNameNV pname, uint index, float * val) => instance.glGetMultisamplefvNV(pname, index, val);
        
        static unsafe void glGetNamedBufferParameteri64v(uint buffer, VertexBufferObjectParameter pname, long * PARAMS) => instance.glGetNamedBufferParameteri64v(buffer, pname, PARAMS);
        
        static unsafe void glGetNamedBufferParameteriv(uint buffer, VertexBufferObjectParameter pname, int * PARAMS) => instance.glGetNamedBufferParameteriv(buffer, pname, PARAMS);
        
        static unsafe void glGetNamedBufferParameterivEXT(uint buffer, VertexBufferObjectParameter pname, int * PARAMS) => instance.glGetNamedBufferParameterivEXT(buffer, pname, PARAMS);
        
        static unsafe void glGetNamedBufferParameterui64vNV(uint buffer, VertexBufferObjectParameter pname, ulong * PARAMS) => instance.glGetNamedBufferParameterui64vNV(buffer, pname, PARAMS);
        
        static unsafe void glGetNamedBufferPointerv(uint buffer, VertexBufferObjectParameter pname, void * * PARAMS) => instance.glGetNamedBufferPointerv(buffer, pname, PARAMS);
        
        static unsafe void glGetNamedBufferPointervEXT(uint buffer, VertexBufferObjectParameter pname, void * * PARAMS) => instance.glGetNamedBufferPointervEXT(buffer, pname, PARAMS);
        
        static unsafe void glGetNamedBufferSubData(uint buffer, IntPtr offset, UIntPtr size, void * data) => instance.glGetNamedBufferSubData(buffer, offset, size, data);
        
        static unsafe void glGetNamedBufferSubDataEXT(uint buffer, IntPtr offset, UIntPtr size, void * data) => instance.glGetNamedBufferSubDataEXT(buffer, offset, size, data);
        
        static unsafe void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS) => instance.glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, PARAMS);
        
        static unsafe void glGetNamedFramebufferAttachmentParameterivEXT(uint framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS) => instance.glGetNamedFramebufferAttachmentParameterivEXT(framebuffer, attachment, pname, PARAMS);
        
        static unsafe void glGetNamedFramebufferParameteriv(uint framebuffer, GetFramebufferParameter pname, int * param) => instance.glGetNamedFramebufferParameteriv(framebuffer, pname, param);
        
        static unsafe void glGetNamedFramebufferParameterivEXT(uint framebuffer, GetFramebufferParameter pname, int * PARAMS) => instance.glGetNamedFramebufferParameterivEXT(framebuffer, pname, PARAMS);
        
        static unsafe void glGetNamedProgramLocalParameterIivEXT(uint program, ProgramTarget target, uint index, int * PARAMS) => instance.glGetNamedProgramLocalParameterIivEXT(program, target, index, PARAMS);
        
        static unsafe void glGetNamedProgramLocalParameterIuivEXT(uint program, ProgramTarget target, uint index, uint * PARAMS) => instance.glGetNamedProgramLocalParameterIuivEXT(program, target, index, PARAMS);
        
        static unsafe void glGetNamedProgramLocalParameterdvEXT(uint program, ProgramTarget target, uint index, double * PARAMS) => instance.glGetNamedProgramLocalParameterdvEXT(program, target, index, PARAMS);
        
        static unsafe void glGetNamedProgramLocalParameterfvEXT(uint program, ProgramTarget target, uint index, float * PARAMS) => instance.glGetNamedProgramLocalParameterfvEXT(program, target, index, PARAMS);
        
        static unsafe void glGetNamedProgramStringEXT(uint program, ProgramTarget target, ProgramStringProperty pname, void * STRING) => instance.glGetNamedProgramStringEXT(program, target, pname, STRING);
        
        static unsafe void glGetNamedProgramivEXT(uint program, ProgramTarget target, ProgramPropertyARB pname, int * PARAMS) => instance.glGetNamedProgramivEXT(program, target, pname, PARAMS);
        
        static unsafe void glGetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameterName pname, int * PARAMS) => instance.glGetNamedRenderbufferParameteriv(renderbuffer, pname, PARAMS);
        
        static unsafe void glGetNamedRenderbufferParameterivEXT(uint renderbuffer, RenderbufferParameterName pname, int * PARAMS) => instance.glGetNamedRenderbufferParameterivEXT(renderbuffer, pname, PARAMS);
        
        static unsafe void glGetNamedStringARB(int namelen, char * name, uint bufSize, int * stringlen, char * STRING) => instance.glGetNamedStringARB(namelen, name, bufSize, stringlen, STRING);
        
        static unsafe void glGetNextPerfQueryIdINTEL(uint queryId, uint * nextQueryId) => instance.glGetNextPerfQueryIdINTEL(queryId, nextQueryId);
        
        static unsafe void glGetObjectBufferfvATI(uint buffer, ArrayObjectPNameATI pname, float * PARAMS) => instance.glGetObjectBufferfvATI(buffer, pname, PARAMS);
        
        static unsafe void glGetObjectBufferivATI(uint buffer, ArrayObjectPNameATI pname, int * PARAMS) => instance.glGetObjectBufferivATI(buffer, pname, PARAMS);
        
        static unsafe void glGetObjectLabel(ObjectIdentifier identifier, uint name, uint bufSize, uint * length, char * label) => instance.glGetObjectLabel(identifier, name, bufSize, length, label);
        
        static unsafe void glGetObjectPtrLabel(void * ptr, uint bufSize, uint * length, char * label) => instance.glGetObjectPtrLabel(ptr, bufSize, length, label);
        
        static unsafe void glGetObjectPtrLabelKHR(void * ptr, uint bufSize, uint * length, char * label) => instance.glGetObjectPtrLabelKHR(ptr, bufSize, length, label);
        
        static unsafe void glGetOcclusionQueryivNV(uint id, OcclusionQueryParameterNameNV pname, int * PARAMS) => instance.glGetOcclusionQueryivNV(id, pname, PARAMS);
        
        static unsafe void glGetOcclusionQueryuivNV(uint id, OcclusionQueryParameterNameNV pname, uint * PARAMS) => instance.glGetOcclusionQueryuivNV(id, pname, PARAMS);
        
        static unsafe void glGetPathColorGenfvNV(PathColor color, PathGenMode pname, float * value) => instance.glGetPathColorGenfvNV(color, pname, value);
        
        static unsafe void glGetPathColorGenivNV(PathColor color, PathGenMode pname, int * value) => instance.glGetPathColorGenivNV(color, pname, value);
        
        static unsafe void glGetPathCommandsNV(uint path, byte * commands) => instance.glGetPathCommandsNV(path, commands);
        
        static unsafe void glGetPathCoordsNV(uint path, float * coords) => instance.glGetPathCoordsNV(path, coords);
        
        static unsafe void glGetPathDashArrayNV(uint path, float * dashArray) => instance.glGetPathDashArrayNV(path, dashArray);
        
        static unsafe float glGetPathLengthNV(uint path, uint startSegment, uint numSegments) => instance.glGetPathLengthNV(path, startSegment, numSegments);
        
        static unsafe void glGetPathMetricRangeNV(uint metricQueryMask, uint firstPathName, uint numPaths, uint stride, float * metrics) => instance.glGetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, metrics);
        
        static unsafe void glGetPathMetricsNV(uint metricQueryMask, uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, uint stride, float * metrics) => instance.glGetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);
        
        static unsafe void glGetPathParameterfvNV(uint path, PathParameter pname, float * value) => instance.glGetPathParameterfvNV(path, pname, value);
        
        static unsafe void glGetPathParameterivNV(uint path, PathParameter pname, int * value) => instance.glGetPathParameterivNV(path, pname, value);
        
        static unsafe void glGetPathSpacingNV(PathListMode pathListMode, uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float * returnedSpacing) => instance.glGetPathSpacingNV(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        
        static unsafe void glGetPathTexGenfvNV(TextureUnit texCoordSet, PathGenMode pname, float * value) => instance.glGetPathTexGenfvNV(texCoordSet, pname, value);
        
        static unsafe void glGetPathTexGenivNV(TextureUnit texCoordSet, PathGenMode pname, int * value) => instance.glGetPathTexGenivNV(texCoordSet, pname, value);
        
        static unsafe void glGetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, char * counterName, uint counterDescLength, char * counterDesc, uint * counterOffset, uint * counterDataSize, uint * counterTypeEnum, uint * counterDataTypeEnum, ulong * rawCounterMaxValue) => instance.glGetPerfCounterInfoINTEL(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        
        static unsafe void glGetPerfMonitorCounterStringAMD(uint group, uint counter, uint bufSize, uint * length, char * counterString) => instance.glGetPerfMonitorCounterStringAMD(group, counter, bufSize, length, counterString);
        
        static unsafe void glGetPerfMonitorCountersAMD(uint group, int * numCounters, int * maxActiveCounters, uint counterSize, uint * counters) => instance.glGetPerfMonitorCountersAMD(group, numCounters, maxActiveCounters, counterSize, counters);
        
        static unsafe void glGetPerfMonitorGroupStringAMD(uint group, uint bufSize, uint * length, char * groupString) => instance.glGetPerfMonitorGroupStringAMD(group, bufSize, length, groupString);
        
        static unsafe void glGetPerfMonitorGroupsAMD(int * numGroups, uint groupsSize, uint * groups) => instance.glGetPerfMonitorGroupsAMD(numGroups, groupsSize, groups);
        
        static unsafe void glGetPerfQueryDataINTEL(uint queryHandle, uint flags, uint dataSize, void * data, uint * bytesWritten) => instance.glGetPerfQueryDataINTEL(queryHandle, flags, dataSize, data, bytesWritten);
        
        static unsafe void glGetPerfQueryIdByNameINTEL(char * queryName, uint * queryId) => instance.glGetPerfQueryIdByNameINTEL(queryName, queryId);
        
        static unsafe void glGetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, char * queryName, uint * dataSize, uint * noCounters, uint * noInstances, uint * capsMask) => instance.glGetPerfQueryInfoINTEL(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);
        
        static unsafe void glGetPixelMapfv(PixelMap map, float * values) => instance.glGetPixelMapfv(map, values);
        
        static unsafe void glGetPixelMapuiv(PixelMap map, uint * values) => instance.glGetPixelMapuiv(map, values);
        
        static unsafe void glGetPixelMapusv(PixelMap map, ushort * values) => instance.glGetPixelMapusv(map, values);
        
        static unsafe void glGetPixelMapxv(PixelMap map, int size, int * values) => instance.glGetPixelMapxv(map, size, values);
        
        static unsafe void glGetPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float * PARAMS) => instance.glGetPixelTexGenParameterfvSGIS(pname, PARAMS);
        
        static unsafe void glGetPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int * PARAMS) => instance.glGetPixelTexGenParameterivSGIS(pname, PARAMS);
        
        static unsafe void glGetPointerv(GetPointervPName pname, void * * PARAMS) => instance.glGetPointerv(pname, PARAMS);
        
        static unsafe void glGetPointervEXT(GetPointervPName pname, void * * PARAMS) => instance.glGetPointervEXT(pname, PARAMS);
        
        static unsafe void glGetPolygonStipple(byte * mask) => instance.glGetPolygonStipple(mask);
        
        static unsafe void glGetProgramEnvParameterIivNV(ProgramTarget target, uint index, int * PARAMS) => instance.glGetProgramEnvParameterIivNV(target, index, PARAMS);
        
        static unsafe void glGetProgramEnvParameterIuivNV(ProgramTarget target, uint index, uint * PARAMS) => instance.glGetProgramEnvParameterIuivNV(target, index, PARAMS);
        
        static unsafe void glGetProgramEnvParameterdvARB(ProgramTargetARB target, uint index, double * PARAMS) => instance.glGetProgramEnvParameterdvARB(target, index, PARAMS);
        
        static unsafe void glGetProgramEnvParameterfvARB(ProgramTargetARB target, uint index, float * PARAMS) => instance.glGetProgramEnvParameterfvARB(target, index, PARAMS);
        
        static unsafe void glGetProgramInfoLog(uint program, uint bufSize, uint * length, char * infoLog) => instance.glGetProgramInfoLog(program, bufSize, length, infoLog);
        
        static unsafe void glGetProgramInterfaceiv(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int * PARAMS) => instance.glGetProgramInterfaceiv(program, programInterface, pname, PARAMS);
        
        static unsafe void glGetProgramLocalParameterIivNV(ProgramTarget target, uint index, int * PARAMS) => instance.glGetProgramLocalParameterIivNV(target, index, PARAMS);
        
        static unsafe void glGetProgramLocalParameterIuivNV(ProgramTarget target, uint index, uint * PARAMS) => instance.glGetProgramLocalParameterIuivNV(target, index, PARAMS);
        
        static unsafe void glGetProgramLocalParameterdvARB(ProgramTargetARB target, uint index, double * PARAMS) => instance.glGetProgramLocalParameterdvARB(target, index, PARAMS);
        
        static unsafe void glGetProgramLocalParameterfvARB(ProgramTargetARB target, uint index, float * PARAMS) => instance.glGetProgramLocalParameterfvARB(target, index, PARAMS);
        
        static unsafe void glGetProgramNamedParameterdvNV(uint id, uint len, byte * name, double * PARAMS) => instance.glGetProgramNamedParameterdvNV(id, len, name, PARAMS);
        
        static unsafe void glGetProgramNamedParameterfvNV(uint id, uint len, byte * name, float * PARAMS) => instance.glGetProgramNamedParameterfvNV(id, len, name, PARAMS);
        
        static unsafe void glGetProgramParameterdvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, double * PARAMS) => instance.glGetProgramParameterdvNV(target, index, pname, PARAMS);
        
        static unsafe void glGetProgramParameterfvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, float * PARAMS) => instance.glGetProgramParameterfvNV(target, index, pname, PARAMS);
        
        static unsafe void glGetProgramPipelineInfoLog(uint pipeline, uint bufSize, uint * length, char * infoLog) => instance.glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
        
        static unsafe void glGetProgramPipelineInfoLogEXT(uint pipeline, uint bufSize, uint * length, char * infoLog) => instance.glGetProgramPipelineInfoLogEXT(pipeline, bufSize, length, infoLog);
        
        static unsafe void glGetProgramPipelineiv(uint pipeline, PipelineParameterName pname, int * PARAMS) => instance.glGetProgramPipelineiv(pipeline, pname, PARAMS);
        
        static unsafe void glGetProgramPipelineivEXT(uint pipeline, PipelineParameterName pname, int * PARAMS) => instance.glGetProgramPipelineivEXT(pipeline, pname, PARAMS);
        
        static unsafe uint glGetProgramResourceIndex(uint program, ProgramInterface programInterface, char * name) => instance.glGetProgramResourceIndex(program, programInterface, name);
        
        static unsafe int glGetProgramResourceLocation(uint program, ProgramInterface programInterface, char * name) => instance.glGetProgramResourceLocation(program, programInterface, name);
        
        static unsafe int glGetProgramResourceLocationIndex(uint program, ProgramInterface programInterface, char * name) => instance.glGetProgramResourceLocationIndex(program, programInterface, name);
        
        static unsafe int glGetProgramResourceLocationIndexEXT(uint program, ProgramInterface programInterface, char * name) => instance.glGetProgramResourceLocationIndexEXT(program, programInterface, name);
        
        static unsafe void glGetProgramResourceName(uint program, ProgramInterface programInterface, uint index, uint bufSize, uint * length, char * name) => instance.glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
        
        static unsafe void glGetProgramResourceiv(uint program, ProgramInterface programInterface, uint index, uint propCount, ProgramResourceProperty * props, uint bufSize, uint * length, int * PARAMS) => instance.glGetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, PARAMS);
        
        static unsafe void glGetProgramStageiv(uint program, ShaderType shadertype, ProgramStagePName pname, int * values) => instance.glGetProgramStageiv(program, shadertype, pname, values);
        
        static unsafe void glGetProgramStringARB(ProgramTargetARB target, ProgramStringPropertyARB pname, void * STRING) => instance.glGetProgramStringARB(target, pname, STRING);
        
        static unsafe void glGetProgramStringNV(uint id, VertexAttribEnumNV pname, byte * program) => instance.glGetProgramStringNV(id, pname, program);
        
        static unsafe void glGetProgramiv(uint program, ProgramPropertyARB pname, int * PARAMS) => instance.glGetProgramiv(program, pname, PARAMS);
        
        static unsafe void glGetProgramivARB(ProgramTargetARB target, ProgramPropertyARB pname, int * PARAMS) => instance.glGetProgramivARB(target, pname, PARAMS);
        
        static unsafe void glGetProgramivNV(uint id, VertexAttribEnumNV pname, int * PARAMS) => instance.glGetProgramivNV(id, pname, PARAMS);
        
        static unsafe void glGetQueryBufferObjecti64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset) => instance.glGetQueryBufferObjecti64v(id, buffer, pname, offset);
        
        static unsafe void glGetQueryBufferObjectiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset) => instance.glGetQueryBufferObjectiv(id, buffer, pname, offset);
        
        static unsafe void glGetQueryBufferObjectui64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset) => instance.glGetQueryBufferObjectui64v(id, buffer, pname, offset);
        
        static unsafe void glGetQueryBufferObjectuiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset) => instance.glGetQueryBufferObjectuiv(id, buffer, pname, offset);
        
        static unsafe void glGetQueryIndexediv(QueryTarget target, uint index, QueryParameterName pname, int * PARAMS) => instance.glGetQueryIndexediv(target, index, pname, PARAMS);
        
        static unsafe void glGetQueryObjecti64v(uint id, QueryObjectParameterName pname, long * PARAMS) => instance.glGetQueryObjecti64v(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjecti64vEXT(uint id, QueryObjectParameterName pname, long * PARAMS) => instance.glGetQueryObjecti64vEXT(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectiv(uint id, QueryObjectParameterName pname, int * PARAMS) => instance.glGetQueryObjectiv(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectivARB(uint id, QueryObjectParameterName pname, int * PARAMS) => instance.glGetQueryObjectivARB(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectivEXT(uint id, QueryObjectParameterName pname, int * PARAMS) => instance.glGetQueryObjectivEXT(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectui64v(uint id, QueryObjectParameterName pname, ulong * PARAMS) => instance.glGetQueryObjectui64v(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectui64vEXT(uint id, QueryObjectParameterName pname, ulong * PARAMS) => instance.glGetQueryObjectui64vEXT(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint * PARAMS) => instance.glGetQueryObjectuiv(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectuivARB(uint id, QueryObjectParameterName pname, uint * PARAMS) => instance.glGetQueryObjectuivARB(id, pname, PARAMS);
        
        static unsafe void glGetQueryObjectuivEXT(uint id, QueryObjectParameterName pname, uint * PARAMS) => instance.glGetQueryObjectuivEXT(id, pname, PARAMS);
        
        static unsafe void glGetQueryiv(QueryTarget target, QueryParameterName pname, int * PARAMS) => instance.glGetQueryiv(target, pname, PARAMS);
        
        static unsafe void glGetQueryivARB(QueryTarget target, QueryParameterName pname, int * PARAMS) => instance.glGetQueryivARB(target, pname, PARAMS);
        
        static unsafe void glGetQueryivEXT(QueryTarget target, QueryParameterName pname, int * PARAMS) => instance.glGetQueryivEXT(target, pname, PARAMS);
        
        static unsafe void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int * PARAMS) => instance.glGetRenderbufferParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetRenderbufferParameterivEXT(RenderbufferTarget target, RenderbufferParameterName pname, int * PARAMS) => instance.glGetRenderbufferParameterivEXT(target, pname, PARAMS);
        
        static unsafe void glGetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int * PARAMS) => instance.glGetRenderbufferParameterivOES(target, pname, PARAMS);
        
        static unsafe void glGetSamplerParameterIiv(uint sampler, SamplerParameterI pname, int * PARAMS) => instance.glGetSamplerParameterIiv(sampler, pname, PARAMS);
        
        static unsafe void glGetSamplerParameterIivEXT(uint sampler, SamplerParameterI pname, int * PARAMS) => instance.glGetSamplerParameterIivEXT(sampler, pname, PARAMS);
        
        static unsafe void glGetSamplerParameterIivOES(uint sampler, SamplerParameterI pname, int * PARAMS) => instance.glGetSamplerParameterIivOES(sampler, pname, PARAMS);
        
        static unsafe void glGetSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint * PARAMS) => instance.glGetSamplerParameterIuiv(sampler, pname, PARAMS);
        
        static unsafe void glGetSamplerParameterIuivEXT(uint sampler, SamplerParameterI pname, uint * PARAMS) => instance.glGetSamplerParameterIuivEXT(sampler, pname, PARAMS);
        
        static unsafe void glGetSamplerParameterIuivOES(uint sampler, SamplerParameterI pname, uint * PARAMS) => instance.glGetSamplerParameterIuivOES(sampler, pname, PARAMS);
        
        static unsafe void glGetSamplerParameterfv(uint sampler, SamplerParameterF pname, float * PARAMS) => instance.glGetSamplerParameterfv(sampler, pname, PARAMS);
        
        static unsafe void glGetSamplerParameteriv(uint sampler, SamplerParameterI pname, int * PARAMS) => instance.glGetSamplerParameteriv(sampler, pname, PARAMS);
        
        static unsafe void glGetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong * PARAMS) => instance.glGetSemaphoreParameterui64vEXT(semaphore, pname, PARAMS);
        
        static unsafe void glGetSeparableFilter(SeparableTargetEXT target, PixelFormat format, PixelType type, void * row, void * column, void * span) => instance.glGetSeparableFilter(target, format, type, row, column, span);
        
        static unsafe void glGetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, void * row, void * column, void * span) => instance.glGetSeparableFilterEXT(target, format, type, row, column, span);
        
        static unsafe void glGetShaderInfoLog(uint shader, uint bufSize, uint * length, char * infoLog) => instance.glGetShaderInfoLog(shader, bufSize, length, infoLog);
        
        static unsafe void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int * range, int * precision) => instance.glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
        
        static unsafe void glGetShaderSource(uint shader, uint bufSize, uint * length, char * source) => instance.glGetShaderSource(shader, bufSize, length, source);
        
        static unsafe void glGetShaderSourceARB(uint obj, uint maxLength, uint * length, char * source) => instance.glGetShaderSourceARB(obj, maxLength, length, source);
        
        static unsafe void glGetShaderiv(uint shader, ShaderParameterName pname, int * PARAMS) => instance.glGetShaderiv(shader, pname, PARAMS);
        
        static unsafe void glGetSharpenTexFuncSGIS(TextureTarget target, float * points) => instance.glGetSharpenTexFuncSGIS(target, points);
        
        static unsafe ushort glGetStageIndexNV(ShaderType shadertype) => instance.glGetStageIndexNV(shadertype);
        
        static unsafe byte * glGetString(StringName name) => instance.glGetString(name);
        
        static unsafe byte * glGetStringi(StringName name, uint index) => instance.glGetStringi(name, index);
        
        static unsafe uint glGetSubroutineIndex(uint program, ShaderType shadertype, char * name) => instance.glGetSubroutineIndex(program, shadertype, name);
        
        static unsafe int glGetSubroutineUniformLocation(uint program, ShaderType shadertype, char * name) => instance.glGetSubroutineUniformLocation(program, shadertype, name);
        
        static unsafe void glGetSynciv(IntPtr sync, SyncParameterName pname, uint bufSize, uint * length, int * values) => instance.glGetSynciv(sync, pname, bufSize, length, values);
        
        static unsafe void glGetSyncivAPPLE(IntPtr sync, SyncParameterName pname, uint bufSize, uint * length, int * values) => instance.glGetSyncivAPPLE(sync, pname, bufSize, length, values);
        
        static unsafe void glGetTexBumpParameterfvATI(GetTexBumpParameterATI pname, float * param) => instance.glGetTexBumpParameterfvATI(pname, param);
        
        static unsafe void glGetTexBumpParameterivATI(GetTexBumpParameterATI pname, int * param) => instance.glGetTexBumpParameterivATI(pname, param);
        
        static unsafe void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS) => instance.glGetTexEnvfv(target, pname, PARAMS);
        
        static unsafe void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glGetTexEnviv(target, pname, PARAMS);
        
        static unsafe void glGetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glGetTexEnvxv(target, pname, PARAMS);
        
        static unsafe void glGetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glGetTexEnvxvOES(target, pname, PARAMS);
        
        static unsafe void glGetTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, float * weights) => instance.glGetTexFilterFuncSGIS(target, filter, weights);
        
        static unsafe void glGetTexGendv(TextureCoordName coord, TextureGenParameter pname, double * PARAMS) => instance.glGetTexGendv(coord, pname, PARAMS);
        
        static unsafe void glGetTexGenfv(TextureCoordName coord, TextureGenParameter pname, float * PARAMS) => instance.glGetTexGenfv(coord, pname, PARAMS);
        
        static unsafe void glGetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float * PARAMS) => instance.glGetTexGenfvOES(coord, pname, PARAMS);
        
        static unsafe void glGetTexGeniv(TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glGetTexGeniv(coord, pname, PARAMS);
        
        static unsafe void glGetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glGetTexGenivOES(coord, pname, PARAMS);
        
        static unsafe void glGetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glGetTexGenxvOES(coord, pname, PARAMS);
        
        static unsafe void glGetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, void * pixels) => instance.glGetTexImage(target, level, format, type, pixels);
        
        static unsafe void glGetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float * PARAMS) => instance.glGetTexLevelParameterfv(target, level, pname, PARAMS);
        
        static unsafe void glGetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int * PARAMS) => instance.glGetTexLevelParameteriv(target, level, pname, PARAMS);
        
        static unsafe void glGetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int * PARAMS) => instance.glGetTexLevelParameterxvOES(target, level, pname, PARAMS);
        
        static unsafe void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTexParameterIiv(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTexParameterIivEXT(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTexParameterIivOES(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint * PARAMS) => instance.glGetTexParameterIuiv(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint * PARAMS) => instance.glGetTexParameterIuivEXT(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint * PARAMS) => instance.glGetTexParameterIuivOES(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, float * PARAMS) => instance.glGetTexParameterfv(target, pname, PARAMS);
        
        static unsafe void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTexParameteriv(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterxv(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTexParameterxv(target, pname, PARAMS);
        
        static unsafe void glGetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTexParameterxvOES(target, pname, PARAMS);
        
        static unsafe ulong glGetTextureHandleARB(uint texture) => instance.glGetTextureHandleARB(texture);
        
        static unsafe ulong glGetTextureHandleIMG(uint texture) => instance.glGetTextureHandleIMG(texture);
        
        static unsafe ulong glGetTextureHandleNV(uint texture) => instance.glGetTextureHandleNV(texture);
        
        static unsafe void glGetTextureImage(uint texture, int level, PixelFormat format, PixelType type, uint bufSize, void * pixels) => instance.glGetTextureImage(texture, level, format, type, bufSize, pixels);
        
        static unsafe void glGetTextureImageEXT(uint texture, TextureTarget target, int level, PixelFormat format, PixelType type, void * pixels) => instance.glGetTextureImageEXT(texture, target, level, format, type, pixels);
        
        static unsafe void glGetTextureLevelParameterfv(uint texture, int level, GetTextureParameter pname, float * PARAMS) => instance.glGetTextureLevelParameterfv(texture, level, pname, PARAMS);
        
        static unsafe void glGetTextureLevelParameterfvEXT(uint texture, TextureTarget target, int level, GetTextureParameter pname, float * PARAMS) => instance.glGetTextureLevelParameterfvEXT(texture, target, level, pname, PARAMS);
        
        static unsafe void glGetTextureLevelParameteriv(uint texture, int level, GetTextureParameter pname, int * PARAMS) => instance.glGetTextureLevelParameteriv(texture, level, pname, PARAMS);
        
        static unsafe void glGetTextureLevelParameterivEXT(uint texture, TextureTarget target, int level, GetTextureParameter pname, int * PARAMS) => instance.glGetTextureLevelParameterivEXT(texture, target, level, pname, PARAMS);
        
        static unsafe void glGetTextureParameterIiv(uint texture, GetTextureParameter pname, int * PARAMS) => instance.glGetTextureParameterIiv(texture, pname, PARAMS);
        
        static unsafe void glGetTextureParameterIivEXT(uint texture, TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTextureParameterIivEXT(texture, target, pname, PARAMS);
        
        static unsafe void glGetTextureParameterIuiv(uint texture, GetTextureParameter pname, uint * PARAMS) => instance.glGetTextureParameterIuiv(texture, pname, PARAMS);
        
        static unsafe void glGetTextureParameterIuivEXT(uint texture, TextureTarget target, GetTextureParameter pname, uint * PARAMS) => instance.glGetTextureParameterIuivEXT(texture, target, pname, PARAMS);
        
        static unsafe void glGetTextureParameterfv(uint texture, GetTextureParameter pname, float * PARAMS) => instance.glGetTextureParameterfv(texture, pname, PARAMS);
        
        static unsafe void glGetTextureParameterfvEXT(uint texture, TextureTarget target, GetTextureParameter pname, float * PARAMS) => instance.glGetTextureParameterfvEXT(texture, target, pname, PARAMS);
        
        static unsafe void glGetTextureParameteriv(uint texture, GetTextureParameter pname, int * PARAMS) => instance.glGetTextureParameteriv(texture, pname, PARAMS);
        
        static unsafe void glGetTextureParameterivEXT(uint texture, TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glGetTextureParameterivEXT(texture, target, pname, PARAMS);
        
        static unsafe ulong glGetTextureSamplerHandleARB(uint texture, uint sampler) => instance.glGetTextureSamplerHandleARB(texture, sampler);
        
        static unsafe ulong glGetTextureSamplerHandleIMG(uint texture, uint sampler) => instance.glGetTextureSamplerHandleIMG(texture, sampler);
        
        static unsafe ulong glGetTextureSamplerHandleNV(uint texture, uint sampler) => instance.glGetTextureSamplerHandleNV(texture, sampler);
        
        static unsafe void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, uint bufSize, void * pixels) => instance.glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        
        static unsafe void glGetTrackMatrixivNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV pname, int * PARAMS) => instance.glGetTrackMatrixivNV(target, address, pname, PARAMS);
        
        static unsafe void glGetTransformFeedbackVarying(uint program, uint index, uint bufSize, uint * length, uint * size, GlslTypeToken * type, char * name) => instance.glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
        
        static unsafe void glGetTransformFeedbackVaryingEXT(uint program, uint index, uint bufSize, uint * length, uint * size, GlslTypeToken * type, char * name) => instance.glGetTransformFeedbackVaryingEXT(program, index, bufSize, length, size, type, name);
        
        static unsafe void glGetTransformFeedbackVaryingNV(uint program, uint index, int * location) => instance.glGetTransformFeedbackVaryingNV(program, index, location);
        
        static unsafe void glGetTransformFeedbacki64_v(uint xfb, TransformFeedbackPName pname, uint index, long * param) => instance.glGetTransformFeedbacki64_v(xfb, pname, index, param);
        
        static unsafe void glGetTransformFeedbacki_v(uint xfb, TransformFeedbackPName pname, uint index, int * param) => instance.glGetTransformFeedbacki_v(xfb, pname, index, param);
        
        static unsafe void glGetTransformFeedbackiv(uint xfb, TransformFeedbackPName pname, int * param) => instance.glGetTransformFeedbackiv(xfb, pname, param);
        
        static unsafe void glGetTranslatedShaderSourceANGLE(uint shader, uint bufsize, uint * length, char * source) => instance.glGetTranslatedShaderSourceANGLE(shader, bufsize, length, source);
        
        static unsafe uint glGetUniformBlockIndex(uint program, char * uniformBlockName) => instance.glGetUniformBlockIndex(program, uniformBlockName);
        
        static unsafe int glGetUniformBufferSizeEXT(uint program, int location) => instance.glGetUniformBufferSizeEXT(program, location);
        
        static unsafe void glGetUniformIndices(uint program, uint uniformCount, char * * uniformNames, uint * uniformIndices) => instance.glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
        
        static unsafe int glGetUniformLocation(uint program, char * name) => instance.glGetUniformLocation(program, name);
        
        static unsafe int glGetUniformLocationARB(uint programObj, char * name) => instance.glGetUniformLocationARB(programObj, name);
        
        static unsafe IntPtr glGetUniformOffsetEXT(uint program, int location) => instance.glGetUniformOffsetEXT(program, location);
        
        static unsafe void glGetUniformSubroutineuiv(ShaderType shadertype, int location, uint * PARAMS) => instance.glGetUniformSubroutineuiv(shadertype, location, PARAMS);
        
        static unsafe void glGetUniformdv(uint program, int location, double * PARAMS) => instance.glGetUniformdv(program, location, PARAMS);
        
        static unsafe void glGetUniformfv(uint program, int location, float * PARAMS) => instance.glGetUniformfv(program, location, PARAMS);
        
        static unsafe void glGetUniformfvARB(uint programObj, int location, float * PARAMS) => instance.glGetUniformfvARB(programObj, location, PARAMS);
        
        static unsafe void glGetUniformi64vARB(uint program, int location, long * PARAMS) => instance.glGetUniformi64vARB(program, location, PARAMS);
        
        static unsafe void glGetUniformi64vNV(uint program, int location, long * PARAMS) => instance.glGetUniformi64vNV(program, location, PARAMS);
        
        static unsafe void glGetUniformiv(uint program, int location, int * PARAMS) => instance.glGetUniformiv(program, location, PARAMS);
        
        static unsafe void glGetUniformivARB(uint programObj, int location, int * PARAMS) => instance.glGetUniformivARB(programObj, location, PARAMS);
        
        static unsafe void glGetUniformui64vARB(uint program, int location, ulong * PARAMS) => instance.glGetUniformui64vARB(program, location, PARAMS);
        
        static unsafe void glGetUniformui64vNV(uint program, int location, ulong * PARAMS) => instance.glGetUniformui64vNV(program, location, PARAMS);
        
        static unsafe void glGetUniformuiv(uint program, int location, uint * PARAMS) => instance.glGetUniformuiv(program, location, PARAMS);
        
        static unsafe void glGetUniformuivEXT(uint program, int location, uint * PARAMS) => instance.glGetUniformuivEXT(program, location, PARAMS);
        
        static unsafe void glGetUnsignedBytevEXT(GetPName pname, byte * data) => instance.glGetUnsignedBytevEXT(pname, data);
        
        static unsafe void glGetVariantArrayObjectfvATI(uint id, ArrayObjectPNameATI pname, float * PARAMS) => instance.glGetVariantArrayObjectfvATI(id, pname, PARAMS);
        
        static unsafe void glGetVariantArrayObjectivATI(uint id, ArrayObjectPNameATI pname, int * PARAMS) => instance.glGetVariantArrayObjectivATI(id, pname, PARAMS);
        
        static unsafe void glGetVariantBooleanvEXT(uint id, GetVariantValueEXT value, bool * data) => instance.glGetVariantBooleanvEXT(id, value, data);
        
        static unsafe void glGetVariantFloatvEXT(uint id, GetVariantValueEXT value, float * data) => instance.glGetVariantFloatvEXT(id, value, data);
        
        static unsafe void glGetVariantIntegervEXT(uint id, GetVariantValueEXT value, int * data) => instance.glGetVariantIntegervEXT(id, value, data);
        
        static unsafe void glGetVariantPointervEXT(uint id, GetVariantValueEXT value, void * * data) => instance.glGetVariantPointervEXT(id, value, data);
        
        static unsafe int glGetVaryingLocationNV(uint program, char * name) => instance.glGetVaryingLocationNV(program, name);
        
        static unsafe void glGetVertexArrayIndexed64iv(uint vaobj, uint index, VertexArrayPName pname, long * param) => instance.glGetVertexArrayIndexed64iv(vaobj, index, pname, param);
        
        static unsafe void glGetVertexArrayIndexediv(uint vaobj, uint index, VertexArrayPName pname, int * param) => instance.glGetVertexArrayIndexediv(vaobj, index, pname, param);
        
        static unsafe void glGetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexArrayPName pname, int * param) => instance.glGetVertexArrayIntegeri_vEXT(vaobj, index, pname, param);
        
        static unsafe void glGetVertexArrayIntegervEXT(uint vaobj, VertexArrayPName pname, int * param) => instance.glGetVertexArrayIntegervEXT(vaobj, pname, param);
        
        static unsafe void glGetVertexArrayPointeri_vEXT(uint vaobj, uint index, VertexArrayPName pname, void * * param) => instance.glGetVertexArrayPointeri_vEXT(vaobj, index, pname, param);
        
        static unsafe void glGetVertexArrayPointervEXT(uint vaobj, VertexArrayPName pname, void * * param) => instance.glGetVertexArrayPointervEXT(vaobj, pname, param);
        
        static unsafe void glGetVertexArrayiv(uint vaobj, VertexArrayPName pname, int * param) => instance.glGetVertexArrayiv(vaobj, pname, param);
        
        static unsafe void glGetVertexAttribArrayObjectfvATI(uint index, ArrayObjectPNameATI pname, float * PARAMS) => instance.glGetVertexAttribArrayObjectfvATI(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribArrayObjectivATI(uint index, ArrayObjectPNameATI pname, int * PARAMS) => instance.glGetVertexAttribArrayObjectivATI(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribIiv(uint index, VertexAttribEnum pname, int * PARAMS) => instance.glGetVertexAttribIiv(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribIivEXT(uint index, VertexAttribEnum pname, int * PARAMS) => instance.glGetVertexAttribIivEXT(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint * PARAMS) => instance.glGetVertexAttribIuiv(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribIuivEXT(uint index, VertexAttribEnum pname, uint * PARAMS) => instance.glGetVertexAttribIuivEXT(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribLdv(uint index, VertexAttribEnum pname, double * PARAMS) => instance.glGetVertexAttribLdv(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribLdvEXT(uint index, VertexAttribEnum pname, double * PARAMS) => instance.glGetVertexAttribLdvEXT(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribLi64vNV(uint index, VertexAttribEnum pname, long * PARAMS) => instance.glGetVertexAttribLi64vNV(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribLui64vARB(uint index, VertexAttribEnum pname, ulong * PARAMS) => instance.glGetVertexAttribLui64vARB(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribLui64vNV(uint index, VertexAttribEnum pname, ulong * PARAMS) => instance.glGetVertexAttribLui64vNV(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void * * pointer) => instance.glGetVertexAttribPointerv(index, pname, pointer);
        
        static unsafe void glGetVertexAttribPointervARB(uint index, VertexAttribPointerPropertyARB pname, void * * pointer) => instance.glGetVertexAttribPointervARB(index, pname, pointer);
        
        static unsafe void glGetVertexAttribPointervNV(uint index, VertexAttribEnumNV pname, void * * pointer) => instance.glGetVertexAttribPointervNV(index, pname, pointer);
        
        static unsafe void glGetVertexAttribdv(uint index, VertexAttribPropertyARB pname, double * PARAMS) => instance.glGetVertexAttribdv(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribdvARB(uint index, VertexAttribPropertyARB pname, double * PARAMS) => instance.glGetVertexAttribdvARB(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribdvNV(uint index, VertexAttribEnumNV pname, double * PARAMS) => instance.glGetVertexAttribdvNV(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float * PARAMS) => instance.glGetVertexAttribfv(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribfvARB(uint index, VertexAttribPropertyARB pname, float * PARAMS) => instance.glGetVertexAttribfvARB(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribfvNV(uint index, VertexAttribEnumNV pname, float * PARAMS) => instance.glGetVertexAttribfvNV(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int * PARAMS) => instance.glGetVertexAttribiv(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribivARB(uint index, VertexAttribPropertyARB pname, int * PARAMS) => instance.glGetVertexAttribivARB(index, pname, PARAMS);
        
        static unsafe void glGetVertexAttribivNV(uint index, VertexAttribEnumNV pname, int * PARAMS) => instance.glGetVertexAttribivNV(index, pname, PARAMS);
        
        static unsafe void glGetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, uint bufSize, void * table) => instance.glGetnColorTable(target, format, type, bufSize, table);
        
        static unsafe void glGetnColorTableARB(ColorTableTarget target, PixelFormat format, PixelType type, uint bufSize, void * table) => instance.glGetnColorTableARB(target, format, type, bufSize, table);
        
        static unsafe void glGetnCompressedTexImage(TextureTarget target, int lod, uint bufSize, void * pixels) => instance.glGetnCompressedTexImage(target, lod, bufSize, pixels);
        
        static unsafe void glGetnCompressedTexImageARB(TextureTarget target, int lod, uint bufSize, void * img) => instance.glGetnCompressedTexImageARB(target, lod, bufSize, img);
        
        static unsafe void glGetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, uint bufSize, void * image) => instance.glGetnConvolutionFilter(target, format, type, bufSize, image);
        
        static unsafe void glGetnConvolutionFilterARB(ConvolutionTarget target, PixelFormat format, PixelType type, uint bufSize, void * image) => instance.glGetnConvolutionFilterARB(target, format, type, bufSize, image);
        
        static unsafe void glGetnHistogram(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values) => instance.glGetnHistogram(target, reset, format, type, bufSize, values);
        
        static unsafe void glGetnHistogramARB(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values) => instance.glGetnHistogramARB(target, reset, format, type, bufSize, values);
        
        static unsafe void glGetnMapdv(MapTarget target, MapQuery query, uint bufSize, double * v) => instance.glGetnMapdv(target, query, bufSize, v);
        
        static unsafe void glGetnMapdvARB(MapTarget target, MapQuery query, uint bufSize, double * v) => instance.glGetnMapdvARB(target, query, bufSize, v);
        
        static unsafe void glGetnMapfv(MapTarget target, MapQuery query, uint bufSize, float * v) => instance.glGetnMapfv(target, query, bufSize, v);
        
        static unsafe void glGetnMapfvARB(MapTarget target, MapQuery query, uint bufSize, float * v) => instance.glGetnMapfvARB(target, query, bufSize, v);
        
        static unsafe void glGetnMapiv(MapTarget target, MapQuery query, uint bufSize, int * v) => instance.glGetnMapiv(target, query, bufSize, v);
        
        static unsafe void glGetnMapivARB(MapTarget target, MapQuery query, uint bufSize, int * v) => instance.glGetnMapivARB(target, query, bufSize, v);
        
        static unsafe void glGetnMinmax(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values) => instance.glGetnMinmax(target, reset, format, type, bufSize, values);
        
        static unsafe void glGetnMinmaxARB(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values) => instance.glGetnMinmaxARB(target, reset, format, type, bufSize, values);
        
        static unsafe void glGetnPixelMapfv(PixelMap map, uint bufSize, float * values) => instance.glGetnPixelMapfv(map, bufSize, values);
        
        static unsafe void glGetnPixelMapfvARB(PixelMap map, uint bufSize, float * values) => instance.glGetnPixelMapfvARB(map, bufSize, values);
        
        static unsafe void glGetnPixelMapuiv(PixelMap map, uint bufSize, uint * values) => instance.glGetnPixelMapuiv(map, bufSize, values);
        
        static unsafe void glGetnPixelMapuivARB(PixelMap map, uint bufSize, uint * values) => instance.glGetnPixelMapuivARB(map, bufSize, values);
        
        static unsafe void glGetnPixelMapusv(PixelMap map, uint bufSize, ushort * values) => instance.glGetnPixelMapusv(map, bufSize, values);
        
        static unsafe void glGetnPixelMapusvARB(PixelMap map, uint bufSize, ushort * values) => instance.glGetnPixelMapusvARB(map, bufSize, values);
        
        static unsafe void glGetnPolygonStipple(uint bufSize, byte * pattern) => instance.glGetnPolygonStipple(bufSize, pattern);
        
        static unsafe void glGetnPolygonStippleARB(uint bufSize, byte * pattern) => instance.glGetnPolygonStippleARB(bufSize, pattern);
        
        static unsafe void glGetnSeparableFilter(SeparableTargetEXT target, PixelFormat format, PixelType type, uint rowBufSize, void * row, uint columnBufSize, void * column, void * span) => instance.glGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
        
        static unsafe void glGetnSeparableFilterARB(SeparableTargetEXT target, PixelFormat format, PixelType type, uint rowBufSize, void * row, uint columnBufSize, void * column, void * span) => instance.glGetnSeparableFilterARB(target, format, type, rowBufSize, row, columnBufSize, column, span);
        
        static unsafe void glGetnTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, uint bufSize, void * pixels) => instance.glGetnTexImage(target, level, format, type, bufSize, pixels);
        
        static unsafe void glGetnTexImageARB(TextureTarget target, int level, PixelFormat format, PixelType type, uint bufSize, void * img) => instance.glGetnTexImageARB(target, level, format, type, bufSize, img);
        
        static unsafe void glGetnUniformdv(uint program, int location, uint bufSize, double * PARAMS) => instance.glGetnUniformdv(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformdvARB(uint program, int location, uint bufSize, double * PARAMS) => instance.glGetnUniformdvARB(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformfv(uint program, int location, uint bufSize, float * PARAMS) => instance.glGetnUniformfv(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformfvARB(uint program, int location, uint bufSize, float * PARAMS) => instance.glGetnUniformfvARB(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformfvEXT(uint program, int location, uint bufSize, float * PARAMS) => instance.glGetnUniformfvEXT(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformfvKHR(uint program, int location, uint bufSize, float * PARAMS) => instance.glGetnUniformfvKHR(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformi64vARB(uint program, int location, uint bufSize, long * PARAMS) => instance.glGetnUniformi64vARB(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformiv(uint program, int location, uint bufSize, int * PARAMS) => instance.glGetnUniformiv(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformivARB(uint program, int location, uint bufSize, int * PARAMS) => instance.glGetnUniformivARB(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformivEXT(uint program, int location, uint bufSize, int * PARAMS) => instance.glGetnUniformivEXT(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformivKHR(uint program, int location, uint bufSize, int * PARAMS) => instance.glGetnUniformivKHR(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformui64vARB(uint program, int location, uint bufSize, ulong * PARAMS) => instance.glGetnUniformui64vARB(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformuiv(uint program, int location, uint bufSize, uint * PARAMS) => instance.glGetnUniformuiv(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformuivARB(uint program, int location, uint bufSize, uint * PARAMS) => instance.glGetnUniformuivARB(program, location, bufSize, PARAMS);
        
        static unsafe void glGetnUniformuivKHR(uint program, int location, uint bufSize, uint * PARAMS) => instance.glGetnUniformuivKHR(program, location, bufSize, PARAMS);
        
        static unsafe void glGlobalAlphaFactorbSUN(sbyte factor) => instance.glGlobalAlphaFactorbSUN(factor);
        
        static unsafe void glGlobalAlphaFactordSUN(double factor) => instance.glGlobalAlphaFactordSUN(factor);
        
        static unsafe void glGlobalAlphaFactorfSUN(float factor) => instance.glGlobalAlphaFactorfSUN(factor);
        
        static unsafe void glGlobalAlphaFactoriSUN(int factor) => instance.glGlobalAlphaFactoriSUN(factor);
        
        static unsafe void glGlobalAlphaFactorsSUN(short factor) => instance.glGlobalAlphaFactorsSUN(factor);
        
        static unsafe void glGlobalAlphaFactorubSUN(byte factor) => instance.glGlobalAlphaFactorubSUN(factor);
        
        static unsafe void glGlobalAlphaFactoruiSUN(uint factor) => instance.glGlobalAlphaFactoruiSUN(factor);
        
        static unsafe void glGlobalAlphaFactorusSUN(ushort factor) => instance.glGlobalAlphaFactorusSUN(factor);
        
        static unsafe void glHint(HintTarget target, HintMode mode) => instance.glHint(target, mode);
        
        static unsafe void glHintPGI(HintTargetPGI target, int mode) => instance.glHintPGI(target, mode);
        
        static unsafe void glHistogram(HistogramTargetEXT target, uint width, InternalFormat internalformat, bool sink) => instance.glHistogram(target, width, internalformat, sink);
        
        static unsafe void glHistogramEXT(HistogramTargetEXT target, uint width, InternalFormat internalformat, bool sink) => instance.glHistogramEXT(target, width, internalformat, sink);
        
        static unsafe void glIglooInterfaceSGIX(IglooFunctionSelectSGIX pname, void * PARAMS) => instance.glIglooInterfaceSGIX(pname, PARAMS);
        
        static unsafe void glImageTransformParameterfHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float param) => instance.glImageTransformParameterfHP(target, pname, param);
        
        static unsafe void glImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float * PARAMS) => instance.glImageTransformParameterfvHP(target, pname, PARAMS);
        
        static unsafe void glImageTransformParameteriHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int param) => instance.glImageTransformParameteriHP(target, pname, param);
        
        static unsafe void glImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int * PARAMS) => instance.glImageTransformParameterivHP(target, pname, PARAMS);
        
        static unsafe void glImportMemoryFdEXT(uint memory, ulong size, ExternalHandleType handleType, int fd) => instance.glImportMemoryFdEXT(memory, size, handleType, fd);
        
        static unsafe void glImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, void * handle) => instance.glImportMemoryWin32HandleEXT(memory, size, handleType, handle);
        
        static unsafe void glImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, void * name) => instance.glImportMemoryWin32NameEXT(memory, size, handleType, name);
        
        static unsafe void glImportSemaphoreFdEXT(uint semaphore, ExternalHandleType handleType, int fd) => instance.glImportSemaphoreFdEXT(semaphore, handleType, fd);
        
        static unsafe void glImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, void * handle) => instance.glImportSemaphoreWin32HandleEXT(semaphore, handleType, handle);
        
        static unsafe void glImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, void * name) => instance.glImportSemaphoreWin32NameEXT(semaphore, handleType, name);
        
        static unsafe void glIndexFuncEXT(IndexFunctionEXT func, float REF) => instance.glIndexFuncEXT(func, REF);
        
        static unsafe void glIndexMask(uint mask) => instance.glIndexMask(mask);
        
        static unsafe void glIndexMaterialEXT(MaterialFace face, IndexMaterialParameterEXT mode) => instance.glIndexMaterialEXT(face, mode);
        
        static unsafe void glIndexPointer(IndexPointerType type, uint stride, void * pointer) => instance.glIndexPointer(type, stride, pointer);
        
        static unsafe void glIndexPointerEXT(IndexPointerType type, uint stride, uint count, void * pointer) => instance.glIndexPointerEXT(type, stride, count, pointer);
        
        static unsafe void glIndexPointerListIBM(IndexPointerType type, int stride, void * * pointer, int ptrstride) => instance.glIndexPointerListIBM(type, stride, pointer, ptrstride);
        
        static unsafe void glIndexd(double c) => instance.glIndexd(c);
        
        static unsafe void glIndexdv(double * c) => instance.glIndexdv(c);
        
        static unsafe void glIndexf(float c) => instance.glIndexf(c);
        
        static unsafe void glIndexfv(float * c) => instance.glIndexfv(c);
        
        static unsafe void glIndexi(int c) => instance.glIndexi(c);
        
        static unsafe void glIndexiv(int * c) => instance.glIndexiv(c);
        
        static unsafe void glIndexs(short c) => instance.glIndexs(c);
        
        static unsafe void glIndexsv(short * c) => instance.glIndexsv(c);
        
        static unsafe void glIndexub(byte c) => instance.glIndexub(c);
        
        static unsafe void glIndexubv(byte * c) => instance.glIndexubv(c);
        
        static unsafe void glIndexxOES(int component) => instance.glIndexxOES(component);
        
        static unsafe void glIndexxvOES(int * component) => instance.glIndexxvOES(component);
        
        static unsafe void glInitNames() => instance.glInitNames();
        
        static unsafe void glInsertComponentEXT(uint res, uint src, uint num) => instance.glInsertComponentEXT(res, src, num);
        
        static unsafe void glInsertEventMarkerEXT(uint length, char * marker) => instance.glInsertEventMarkerEXT(length, marker);
        
        static unsafe void glInstrumentsBufferSGIX(uint size, int * buffer) => instance.glInstrumentsBufferSGIX(size, buffer);
        
        static unsafe void glInterleavedArrays(InterleavedArrayFormat format, uint stride, void * pointer) => instance.glInterleavedArrays(format, stride, pointer);
        
        static unsafe void glInterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight) => instance.glInterpolatePathsNV(resultPath, pathA, pathB, weight);
        
        static unsafe void glInvalidateBufferData(uint buffer) => instance.glInvalidateBufferData(buffer);
        
        static unsafe void glInvalidateBufferSubData(uint buffer, IntPtr offset, UIntPtr length) => instance.glInvalidateBufferSubData(buffer, offset, length);
        
        static unsafe void glInvalidateFramebuffer(FramebufferTarget target, uint numAttachments, FramebufferAttachment * attachments) => instance.glInvalidateFramebuffer(target, numAttachments, attachments);
        
        static unsafe void glInvalidateNamedFramebufferData(uint framebuffer, uint numAttachments, FramebufferAttachment * attachments) => instance.glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
        
        static unsafe void glInvalidateNamedFramebufferSubData(uint framebuffer, uint numAttachments, FramebufferAttachment * attachments, int x, int y, uint width, uint height) => instance.glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
        
        static unsafe void glInvalidateSubFramebuffer(FramebufferTarget target, uint numAttachments, FramebufferAttachment * attachments, int x, int y, uint width, uint height) => instance.glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
        
        static unsafe void glInvalidateTexImage(uint texture, int level) => instance.glInvalidateTexImage(texture, level);
        
        static unsafe void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth) => instance.glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
        
        static unsafe bool glIsAsyncMarkerSGIX(uint marker) => instance.glIsAsyncMarkerSGIX(marker);
        
        static unsafe bool glIsBuffer(uint buffer) => instance.glIsBuffer(buffer);
        
        static unsafe bool glIsBufferARB(uint buffer) => instance.glIsBufferARB(buffer);
        
        static unsafe bool glIsCommandListNV(uint list) => instance.glIsCommandListNV(list);
        
        static unsafe bool glIsEnabled(EnableCap cap) => instance.glIsEnabled(cap);
        
        static unsafe bool glIsEnabledIndexedEXT(EnableCap target, uint index) => instance.glIsEnabledIndexedEXT(target, index);
        
        static unsafe bool glIsEnabledi(EnableCap target, uint index) => instance.glIsEnabledi(target, index);
        
        static unsafe bool glIsEnablediEXT(EnableCap target, uint index) => instance.glIsEnablediEXT(target, index);
        
        static unsafe bool glIsEnablediNV(EnableCap target, uint index) => instance.glIsEnablediNV(target, index);
        
        static unsafe bool glIsEnablediOES(EnableCap target, uint index) => instance.glIsEnablediOES(target, index);
        
        static unsafe bool glIsFenceAPPLE(uint fence) => instance.glIsFenceAPPLE(fence);
        
        static unsafe bool glIsFenceNV(uint fence) => instance.glIsFenceNV(fence);
        
        static unsafe bool glIsFramebuffer(uint framebuffer) => instance.glIsFramebuffer(framebuffer);
        
        static unsafe bool glIsFramebufferEXT(uint framebuffer) => instance.glIsFramebufferEXT(framebuffer);
        
        static unsafe bool glIsFramebufferOES(uint framebuffer) => instance.glIsFramebufferOES(framebuffer);
        
        static unsafe bool glIsImageHandleResidentARB(ulong handle) => instance.glIsImageHandleResidentARB(handle);
        
        static unsafe bool glIsImageHandleResidentNV(ulong handle) => instance.glIsImageHandleResidentNV(handle);
        
        static unsafe bool glIsList(uint list) => instance.glIsList(list);
        
        static unsafe bool glIsMemoryObjectEXT(uint memoryObject) => instance.glIsMemoryObjectEXT(memoryObject);
        
        static unsafe bool glIsNamedBufferResidentNV(uint buffer) => instance.glIsNamedBufferResidentNV(buffer);
        
        static unsafe bool glIsNamedStringARB(int namelen, char * name) => instance.glIsNamedStringARB(namelen, name);
        
        static unsafe bool glIsObjectBufferATI(uint buffer) => instance.glIsObjectBufferATI(buffer);
        
        static unsafe bool glIsOcclusionQueryNV(uint id) => instance.glIsOcclusionQueryNV(id);
        
        static unsafe bool glIsPathNV(uint path) => instance.glIsPathNV(path);
        
        static unsafe bool glIsPointInFillPathNV(uint path, uint mask, float x, float y) => instance.glIsPointInFillPathNV(path, mask, x, y);
        
        static unsafe bool glIsPointInStrokePathNV(uint path, float x, float y) => instance.glIsPointInStrokePathNV(path, x, y);
        
        static unsafe bool glIsProgram(uint program) => instance.glIsProgram(program);
        
        static unsafe bool glIsProgramARB(uint program) => instance.glIsProgramARB(program);
        
        static unsafe bool glIsProgramNV(uint id) => instance.glIsProgramNV(id);
        
        static unsafe bool glIsProgramPipeline(uint pipeline) => instance.glIsProgramPipeline(pipeline);
        
        static unsafe bool glIsProgramPipelineEXT(uint pipeline) => instance.glIsProgramPipelineEXT(pipeline);
        
        static unsafe bool glIsQuery(uint id) => instance.glIsQuery(id);
        
        static unsafe bool glIsQueryARB(uint id) => instance.glIsQueryARB(id);
        
        static unsafe bool glIsQueryEXT(uint id) => instance.glIsQueryEXT(id);
        
        static unsafe bool glIsRenderbuffer(uint renderbuffer) => instance.glIsRenderbuffer(renderbuffer);
        
        static unsafe bool glIsRenderbufferEXT(uint renderbuffer) => instance.glIsRenderbufferEXT(renderbuffer);
        
        static unsafe bool glIsRenderbufferOES(uint renderbuffer) => instance.glIsRenderbufferOES(renderbuffer);
        
        static unsafe bool glIsSemaphoreEXT(uint semaphore) => instance.glIsSemaphoreEXT(semaphore);
        
        static unsafe bool glIsSampler(uint sampler) => instance.glIsSampler(sampler);
        
        static unsafe bool glIsShader(uint shader) => instance.glIsShader(shader);
        
        static unsafe bool glIsStateNV(uint state) => instance.glIsStateNV(state);
        
        static unsafe bool glIsSync(IntPtr sync) => instance.glIsSync(sync);
        
        static unsafe bool glIsSyncAPPLE(IntPtr sync) => instance.glIsSyncAPPLE(sync);
        
        static unsafe bool glIsTexture(uint texture) => instance.glIsTexture(texture);
        
        static unsafe bool glIsTextureEXT(uint texture) => instance.glIsTextureEXT(texture);
        
        static unsafe bool glIsTextureHandleResidentARB(ulong handle) => instance.glIsTextureHandleResidentARB(handle);
        
        static unsafe bool glIsTextureHandleResidentNV(ulong handle) => instance.glIsTextureHandleResidentNV(handle);
        
        static unsafe bool glIsTransformFeedback(uint id) => instance.glIsTransformFeedback(id);
        
        static unsafe bool glIsTransformFeedbackNV(uint id) => instance.glIsTransformFeedbackNV(id);
        
        static unsafe bool glIsVariantEnabledEXT(uint id, VariantCapEXT cap) => instance.glIsVariantEnabledEXT(id, cap);
        
        static unsafe bool glIsVertexArray(uint array) => instance.glIsVertexArray(array);
        
        static unsafe bool glIsVertexArrayAPPLE(uint array) => instance.glIsVertexArrayAPPLE(array);
        
        static unsafe bool glIsVertexArrayOES(uint array) => instance.glIsVertexArrayOES(array);
        
        static unsafe void glLGPUInterlockNVX() => instance.glLGPUInterlockNVX();
        
        static unsafe void glLGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, UIntPtr size, void * data) => instance.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, size, data);
        
        static unsafe void glLightEnviSGIX(LightEnvParameterSGIX pname, int param) => instance.glLightEnviSGIX(pname, param);
        
        static unsafe void glLightModelf(LightModelParameter pname, float param) => instance.glLightModelf(pname, param);
        
        static unsafe void glLightModelfv(LightModelParameter pname, float * PARAMS) => instance.glLightModelfv(pname, PARAMS);
        
        static unsafe void glLightModeli(LightModelParameter pname, int param) => instance.glLightModeli(pname, param);
        
        static unsafe void glLightModeliv(LightModelParameter pname, int * PARAMS) => instance.glLightModeliv(pname, PARAMS);
        
        static unsafe void glLightModelx(LightModelParameter pname, int param) => instance.glLightModelx(pname, param);
        
        static unsafe void glLightModelxOES(LightModelParameter pname, int param) => instance.glLightModelxOES(pname, param);
        
        static unsafe void glLightModelxv(LightModelParameter pname, int * param) => instance.glLightModelxv(pname, param);
        
        static unsafe void glLightModelxvOES(LightModelParameter pname, int * param) => instance.glLightModelxvOES(pname, param);
        
        static unsafe void glLightf(LightName light, LightParameter pname, float param) => instance.glLightf(light, pname, param);
        
        static unsafe void glLightfv(LightName light, LightParameter pname, float * PARAMS) => instance.glLightfv(light, pname, PARAMS);
        
        static unsafe void glLighti(LightName light, LightParameter pname, int param) => instance.glLighti(light, pname, param);
        
        static unsafe void glLightiv(LightName light, LightParameter pname, int * PARAMS) => instance.glLightiv(light, pname, PARAMS);
        
        static unsafe void glLightx(LightName light, LightParameter pname, int param) => instance.glLightx(light, pname, param);
        
        static unsafe void glLightxOES(LightName light, LightParameter pname, int param) => instance.glLightxOES(light, pname, param);
        
        static unsafe void glLightxv(LightName light, LightParameter pname, int * PARAMS) => instance.glLightxv(light, pname, PARAMS);
        
        static unsafe void glLightxvOES(LightName light, LightParameter pname, int * PARAMS) => instance.glLightxvOES(light, pname, PARAMS);
        
        static unsafe void glLineStipple(int factor, ushort pattern) => instance.glLineStipple(factor, pattern);
        
        static unsafe void glLineWidth(float width) => instance.glLineWidth(width);
        
        static unsafe void glLineWidthx(int width) => instance.glLineWidthx(width);
        
        static unsafe void glLineWidthxOES(int width) => instance.glLineWidthxOES(width);
        
        static unsafe void glLinkProgram(uint program) => instance.glLinkProgram(program);
        
        static unsafe void glLinkProgramARB(uint programObj) => instance.glLinkProgramARB(programObj);
        
        static unsafe void glListBase(uint BASE) => instance.glListBase(BASE);
        
        static unsafe void glListDrawCommandsStatesClientNV(uint list, uint segment, void * * indirects, uint * sizes, uint * states, uint * fbos, uint count) => instance.glListDrawCommandsStatesClientNV(list, segment, indirects, sizes, states, fbos, count);
        
        static unsafe void glListParameterfSGIX(uint list, ListParameterName pname, float param) => instance.glListParameterfSGIX(list, pname, param);
        
        static unsafe void glListParameterfvSGIX(uint list, ListParameterName pname, float * PARAMS) => instance.glListParameterfvSGIX(list, pname, PARAMS);
        
        static unsafe void glListParameteriSGIX(uint list, ListParameterName pname, int param) => instance.glListParameteriSGIX(list, pname, param);
        
        static unsafe void glListParameterivSGIX(uint list, ListParameterName pname, int * PARAMS) => instance.glListParameterivSGIX(list, pname, PARAMS);
        
        static unsafe void glLoadIdentity() => instance.glLoadIdentity();
        
        static unsafe void glLoadIdentityDeformationMapSGIX(uint mask) => instance.glLoadIdentityDeformationMapSGIX(mask);
        
        static unsafe void glLoadMatrixd(double * m) => instance.glLoadMatrixd(m);
        
        static unsafe void glLoadMatrixf(float * m) => instance.glLoadMatrixf(m);
        
        static unsafe void glLoadMatrixx(int * m) => instance.glLoadMatrixx(m);
        
        static unsafe void glLoadMatrixxOES(int * m) => instance.glLoadMatrixxOES(m);
        
        static unsafe void glLoadName(uint name) => instance.glLoadName(name);
        
        static unsafe void glLoadPaletteFromModelViewMatrixOES() => instance.glLoadPaletteFromModelViewMatrixOES();
        
        static unsafe void glLoadProgramNV(VertexAttribEnumNV target, uint id, uint len, byte * program) => instance.glLoadProgramNV(target, id, len, program);
        
        static unsafe void glLoadTransposeMatrixd(double * m) => instance.glLoadTransposeMatrixd(m);
        
        static unsafe void glLoadTransposeMatrixdARB(double * m) => instance.glLoadTransposeMatrixdARB(m);
        
        static unsafe void glLoadTransposeMatrixf(float * m) => instance.glLoadTransposeMatrixf(m);
        
        static unsafe void glLoadTransposeMatrixfARB(float * m) => instance.glLoadTransposeMatrixfARB(m);
        
        static unsafe void glLoadTransposeMatrixxOES(int * m) => instance.glLoadTransposeMatrixxOES(m);
        
        static unsafe void glLockArraysEXT(int first, uint count) => instance.glLockArraysEXT(first, count);
        
        static unsafe void glLogicOp(LogicOp opcode) => instance.glLogicOp(opcode);
        
        static unsafe void glMakeImageHandleNonResidentARB(ulong handle) => instance.glMakeImageHandleNonResidentARB(handle);
        
        static unsafe void glMakeImageHandleNonResidentNV(ulong handle) => instance.glMakeImageHandleNonResidentNV(handle);
        
        static unsafe void glMakeNamedBufferNonResidentNV(uint buffer) => instance.glMakeNamedBufferNonResidentNV(buffer);
        
        static unsafe void glMakeTextureHandleNonResidentARB(ulong handle) => instance.glMakeTextureHandleNonResidentARB(handle);
        
        static unsafe void glMakeTextureHandleNonResidentNV(ulong handle) => instance.glMakeTextureHandleNonResidentNV(handle);
        
        static unsafe void glMakeTextureHandleResidentARB(ulong handle) => instance.glMakeTextureHandleResidentARB(handle);
        
        static unsafe void glMakeTextureHandleResidentNV(ulong handle) => instance.glMakeTextureHandleResidentNV(handle);
        
        static unsafe void glMap1d(MapTarget target, double u1, double u2, int stride, int order, double * points) => instance.glMap1d(target, u1, u2, stride, order, points);
        
        static unsafe void glMap1f(MapTarget target, float u1, float u2, int stride, int order, float * points) => instance.glMap1f(target, u1, u2, stride, order, points);
        
        static unsafe void glMap1xOES(MapTarget target, int u1, int u2, int stride, int order, int points) => instance.glMap1xOES(target, u1, u2, stride, order, points);
        
        static unsafe void glMap2d(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double * points) => instance.glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        
        static unsafe void glMap2f(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float * points) => instance.glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        
        static unsafe void glMap2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => instance.glMap2xOES(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        
        static unsafe void * glMapBuffer(BufferTargetARB target, BufferAccessARB access) => instance.glMapBuffer(target, access);
        
        static unsafe void * glMapBufferARB(BufferTargetARB target, BufferAccessARB access) => instance.glMapBufferARB(target, access);
        
        static unsafe void * glMapBufferOES(BufferTargetARB target, BufferAccessARB access) => instance.glMapBufferOES(target, access);
        
        static unsafe void * glMapBufferRange(BufferTargetARB target, IntPtr offset, UIntPtr length, uint access) => instance.glMapBufferRange(target, offset, length, access);
        
        static unsafe void * glMapBufferRangeEXT(BufferTargetARB target, IntPtr offset, UIntPtr length, uint access) => instance.glMapBufferRangeEXT(target, offset, length, access);
        
        static unsafe void glMapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, uint ustride, uint vstride, int uorder, int vorder, bool packed, void * points) => instance.glMapControlPointsNV(target, index, type, ustride, vstride, uorder, vorder, packed, points);
        
        static unsafe void glMapGrid1d(int un, double u1, double u2) => instance.glMapGrid1d(un, u1, u2);
        
        static unsafe void glMapGrid1f(int un, float u1, float u2) => instance.glMapGrid1f(un, u1, u2);
        
        static unsafe void glMapGrid1xOES(int n, int u1, int u2) => instance.glMapGrid1xOES(n, u1, u2);
        
        static unsafe void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) => instance.glMapGrid2d(un, u1, u2, vn, v1, v2);
        
        static unsafe void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) => instance.glMapGrid2f(un, u1, u2, vn, v1, v2);
        
        static unsafe void glMapGrid2xOES(int n, int u1, int u2, int v1, int v2) => instance.glMapGrid2xOES(n, u1, u2, v1, v2);
        
        static unsafe void * glMapNamedBuffer(uint buffer, BufferAccessARB access) => instance.glMapNamedBuffer(buffer, access);
        
        static unsafe void * glMapNamedBufferEXT(uint buffer, BufferAccessARB access) => instance.glMapNamedBufferEXT(buffer, access);
        
        static unsafe void * glMapNamedBufferRange(uint buffer, IntPtr offset, UIntPtr length, uint access) => instance.glMapNamedBufferRange(buffer, offset, length, access);
        
        static unsafe void * glMapNamedBufferRangeEXT(uint buffer, IntPtr offset, UIntPtr length, uint access) => instance.glMapNamedBufferRangeEXT(buffer, offset, length, access);
        
        static unsafe void * glMapObjectBufferATI(uint buffer) => instance.glMapObjectBufferATI(buffer);
        
        static unsafe void glMapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float * PARAMS) => instance.glMapParameterfvNV(target, pname, PARAMS);
        
        static unsafe void glMapParameterivNV(EvalTargetNV target, MapParameterNV pname, int * PARAMS) => instance.glMapParameterivNV(target, pname, PARAMS);
        
        static unsafe void glMapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double * points) => instance.glMapVertexAttrib1dAPPLE(index, size, u1, u2, stride, order, points);
        
        static unsafe void glMapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float * points) => instance.glMapVertexAttrib1fAPPLE(index, size, u1, u2, stride, order, points);
        
        static unsafe void glMapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double * points) => instance.glMapVertexAttrib2dAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        
        static unsafe void glMapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float * points) => instance.glMapVertexAttrib2fAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        
        static unsafe void glMaterialf(MaterialFace face, MaterialParameter pname, float param) => instance.glMaterialf(face, pname, param);
        
        static unsafe void glMaterialfv(MaterialFace face, MaterialParameter pname, float * PARAMS) => instance.glMaterialfv(face, pname, PARAMS);
        
        static unsafe void glMateriali(MaterialFace face, MaterialParameter pname, int param) => instance.glMateriali(face, pname, param);
        
        static unsafe void glMaterialiv(MaterialFace face, MaterialParameter pname, int * PARAMS) => instance.glMaterialiv(face, pname, PARAMS);
        
        static unsafe void glMaterialx(MaterialFace face, MaterialParameter pname, int param) => instance.glMaterialx(face, pname, param);
        
        static unsafe void glMaterialxOES(MaterialFace face, MaterialParameter pname, int param) => instance.glMaterialxOES(face, pname, param);
        
        static unsafe void glMaterialxv(MaterialFace face, MaterialParameter pname, int * param) => instance.glMaterialxv(face, pname, param);
        
        static unsafe void glMaterialxvOES(MaterialFace face, MaterialParameter pname, int * param) => instance.glMaterialxvOES(face, pname, param);
        
        static unsafe void glMatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => instance.glMatrixFrustumEXT(mode, left, right, bottom, top, zNear, zFar);
        
        static unsafe void glMatrixIndexPointerARB(int size, MatrixIndexPointerTypeARB type, uint stride, void * pointer) => instance.glMatrixIndexPointerARB(size, type, stride, pointer);
        
        static unsafe void glMatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, uint stride, void * pointer) => instance.glMatrixIndexPointerOES(size, type, stride, pointer);
        
        static unsafe void glMatrixIndexubvARB(int size, byte * indices) => instance.glMatrixIndexubvARB(size, indices);
        
        static unsafe void glMatrixIndexuivARB(int size, uint * indices) => instance.glMatrixIndexuivARB(size, indices);
        
        static unsafe void glMatrixIndexusvARB(int size, ushort * indices) => instance.glMatrixIndexusvARB(size, indices);
        
        static unsafe void glMatrixLoadIdentityEXT(MatrixMode mode) => instance.glMatrixLoadIdentityEXT(mode);
        
        static unsafe void glMatrixLoadTransposedEXT(MatrixMode mode, double * m) => instance.glMatrixLoadTransposedEXT(mode, m);
        
        static unsafe void glMatrixLoadTransposefEXT(MatrixMode mode, float * m) => instance.glMatrixLoadTransposefEXT(mode, m);
        
        static unsafe void glMatrixLoaddEXT(MatrixMode mode, double * m) => instance.glMatrixLoaddEXT(mode, m);
        
        static unsafe void glMatrixLoadfEXT(MatrixMode mode, float * m) => instance.glMatrixLoadfEXT(mode, m);
        
        static unsafe void glMatrixMode(MatrixMode mode) => instance.glMatrixMode(mode);
        
        static unsafe void glMatrixMultTransposedEXT(MatrixMode mode, double * m) => instance.glMatrixMultTransposedEXT(mode, m);
        
        static unsafe void glMatrixMultTransposefEXT(MatrixMode mode, float * m) => instance.glMatrixMultTransposefEXT(mode, m);
        
        static unsafe void glMatrixMultdEXT(MatrixMode mode, double * m) => instance.glMatrixMultdEXT(mode, m);
        
        static unsafe void glMatrixMultfEXT(MatrixMode mode, float * m) => instance.glMatrixMultfEXT(mode, m);
        
        static unsafe void glMatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar) => instance.glMatrixOrthoEXT(mode, left, right, bottom, top, zNear, zFar);
        
        static unsafe void glMatrixPopEXT(MatrixMode mode) => instance.glMatrixPopEXT(mode);
        
        static unsafe void glMatrixPushEXT(MatrixMode mode) => instance.glMatrixPushEXT(mode);
        
        static unsafe void glMatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z) => instance.glMatrixRotatedEXT(mode, angle, x, y, z);
        
        static unsafe void glMatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z) => instance.glMatrixRotatefEXT(mode, angle, x, y, z);
        
        static unsafe void glMatrixScaledEXT(MatrixMode mode, double x, double y, double z) => instance.glMatrixScaledEXT(mode, x, y, z);
        
        static unsafe void glMatrixScalefEXT(MatrixMode mode, float x, float y, float z) => instance.glMatrixScalefEXT(mode, x, y, z);
        
        static unsafe void glMatrixTranslatedEXT(MatrixMode mode, double x, double y, double z) => instance.glMatrixTranslatedEXT(mode, x, y, z);
        
        static unsafe void glMatrixTranslatefEXT(MatrixMode mode, float x, float y, float z) => instance.glMatrixTranslatefEXT(mode, x, y, z);
        
        static unsafe void glMaxShaderCompilerThreadsKHR(uint count) => instance.glMaxShaderCompilerThreadsKHR(count);
        
        static unsafe void glMaxShaderCompilerThreadsARB(uint count) => instance.glMaxShaderCompilerThreadsARB(count);
        
        static unsafe void glMemoryBarrier(uint barriers) => instance.glMemoryBarrier(barriers);
        
        static unsafe void glMemoryBarrierByRegion(uint barriers) => instance.glMemoryBarrierByRegion(barriers);
        
        static unsafe void glMemoryBarrierEXT(uint barriers) => instance.glMemoryBarrierEXT(barriers);
        
        static unsafe void glMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int * PARAMS) => instance.glMemoryObjectParameterivEXT(memoryObject, pname, PARAMS);
        
        static unsafe void glMinSampleShading(float value) => instance.glMinSampleShading(value);
        
        static unsafe void glMinSampleShadingARB(float value) => instance.glMinSampleShadingARB(value);
        
        static unsafe void glMinSampleShadingOES(float value) => instance.glMinSampleShadingOES(value);
        
        static unsafe void glMinmax(MinmaxTargetEXT target, InternalFormat internalformat, bool sink) => instance.glMinmax(target, internalformat, sink);
        
        static unsafe void glMinmaxEXT(MinmaxTargetEXT target, InternalFormat internalformat, bool sink) => instance.glMinmaxEXT(target, internalformat, sink);
        
        static unsafe void glMultMatrixd(double * m) => instance.glMultMatrixd(m);
        
        static unsafe void glMultMatrixf(float * m) => instance.glMultMatrixf(m);
        
        static unsafe void glMultMatrixx(int * m) => instance.glMultMatrixx(m);
        
        static unsafe void glMultMatrixxOES(int * m) => instance.glMultMatrixxOES(m);
        
        static unsafe void glMultTransposeMatrixd(double * m) => instance.glMultTransposeMatrixd(m);
        
        static unsafe void glMultTransposeMatrixdARB(double * m) => instance.glMultTransposeMatrixdARB(m);
        
        static unsafe void glMultTransposeMatrixf(float * m) => instance.glMultTransposeMatrixf(m);
        
        static unsafe void glMultTransposeMatrixfARB(float * m) => instance.glMultTransposeMatrixfARB(m);
        
        static unsafe void glMultTransposeMatrixxOES(int * m) => instance.glMultTransposeMatrixxOES(m);
        
        static unsafe void glMultiDrawArrays(PrimitiveType mode, int * first, uint * count, uint drawcount) => instance.glMultiDrawArrays(mode, first, count, drawcount);
        
        static unsafe void glMultiDrawArraysEXT(PrimitiveType mode, int * first, uint * count, uint primcount) => instance.glMultiDrawArraysEXT(mode, first, count, primcount);
        
        static unsafe void glMultiDrawArraysIndirect(PrimitiveType mode, void * indirect, uint drawcount, uint stride) => instance.glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
        
        static unsafe void glMultiDrawArraysIndirectAMD(PrimitiveType mode, void * indirect, uint primcount, uint stride) => instance.glMultiDrawArraysIndirectAMD(mode, indirect, primcount, stride);
        
        static unsafe void glMultiDrawArraysIndirectBindlessCountNV(PrimitiveType mode, void * indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount) => instance.glMultiDrawArraysIndirectBindlessCountNV(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
        
        static unsafe void glMultiDrawArraysIndirectBindlessNV(PrimitiveType mode, void * indirect, uint drawCount, uint stride, int vertexBufferCount) => instance.glMultiDrawArraysIndirectBindlessNV(mode, indirect, drawCount, stride, vertexBufferCount);
        
        static unsafe void glMultiDrawArraysIndirectCount(PrimitiveType mode, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride) => instance.glMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);
        
        static unsafe void glMultiDrawArraysIndirectCountARB(PrimitiveType mode, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride) => instance.glMultiDrawArraysIndirectCountARB(mode, indirect, drawcount, maxdrawcount, stride);
        
        static unsafe void glMultiDrawArraysIndirectEXT(PrimitiveType mode, void * indirect, uint drawcount, uint stride) => instance.glMultiDrawArraysIndirectEXT(mode, indirect, drawcount, stride);
        
        static unsafe void glMultiDrawElementArrayAPPLE(PrimitiveType mode, int * first, uint * count, uint primcount) => instance.glMultiDrawElementArrayAPPLE(mode, first, count, primcount);
        
        static unsafe void glMultiDrawElements(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint drawcount) => instance.glMultiDrawElements(mode, count, type, indices, drawcount);
        
        static unsafe void glMultiDrawElementsBaseVertex(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint drawcount, int * basevertex) => instance.glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
        
        static unsafe void glMultiDrawElementsBaseVertexEXT(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint primcount, int * basevertex) => instance.glMultiDrawElementsBaseVertexEXT(mode, count, type, indices, primcount, basevertex);
        
        static unsafe void glMultiDrawElementsEXT(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint primcount) => instance.glMultiDrawElementsEXT(mode, count, type, indices, primcount);
        
        static unsafe void glMultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawcount, uint stride) => instance.glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
        
        static unsafe void glMultiDrawElementsIndirectAMD(PrimitiveType mode, DrawElementsType type, void * indirect, uint primcount, uint stride) => instance.glMultiDrawElementsIndirectAMD(mode, type, indirect, primcount, stride);
        
        static unsafe void glMultiDrawElementsIndirectBindlessCountNV(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount) => instance.glMultiDrawElementsIndirectBindlessCountNV(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
        
        static unsafe void glMultiDrawElementsIndirectBindlessNV(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawCount, uint stride, int vertexBufferCount) => instance.glMultiDrawElementsIndirectBindlessNV(mode, type, indirect, drawCount, stride, vertexBufferCount);
        
        static unsafe void glMultiDrawElementsIndirectCount(PrimitiveType mode, DrawElementsType type, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride) => instance.glMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);
        
        static unsafe void glMultiDrawElementsIndirectCountARB(PrimitiveType mode, DrawElementsType type, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride) => instance.glMultiDrawElementsIndirectCountARB(mode, type, indirect, drawcount, maxdrawcount, stride);
        
        static unsafe void glMultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawcount, uint stride) => instance.glMultiDrawElementsIndirectEXT(mode, type, indirect, drawcount, stride);
        
        static unsafe void glMultiDrawMeshTasksIndirectNV(IntPtr indirect, uint drawcount, uint stride) => instance.glMultiDrawMeshTasksIndirectNV(indirect, drawcount, stride);
        
        static unsafe void glMultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, uint maxdrawcount, uint stride) => instance.glMultiDrawMeshTasksIndirectCountNV(indirect, drawcount, maxdrawcount, stride);
        
        static unsafe void glMultiDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int * first, uint * count, uint primcount) => instance.glMultiDrawRangeElementArrayAPPLE(mode, start, end, first, count, primcount);
        
        static unsafe void glMultiModeDrawArraysIBM(PrimitiveType * mode, int * first, uint * count, uint primcount, int modestride) => instance.glMultiModeDrawArraysIBM(mode, first, count, primcount, modestride);
        
        static unsafe void glMultiModeDrawElementsIBM(PrimitiveType * mode, uint * count, DrawElementsType type, void * * indices, uint primcount, int modestride) => instance.glMultiModeDrawElementsIBM(mode, count, type, indices, primcount, modestride);
        
        static unsafe void glMultiTexCoord1bOES(TextureUnit texture, sbyte s) => instance.glMultiTexCoord1bOES(texture, s);
        
        static unsafe void glMultiTexCoord1bvOES(TextureUnit texture, sbyte * coords) => instance.glMultiTexCoord1bvOES(texture, coords);
        
        static unsafe void glMultiTexCoord1d(TextureUnit target, double s) => instance.glMultiTexCoord1d(target, s);
        
        static unsafe void glMultiTexCoord1dARB(TextureUnit target, double s) => instance.glMultiTexCoord1dARB(target, s);
        
        static unsafe void glMultiTexCoord1dv(TextureUnit target, double * v) => instance.glMultiTexCoord1dv(target, v);
        
        static unsafe void glMultiTexCoord1dvARB(TextureUnit target, double * v) => instance.glMultiTexCoord1dvARB(target, v);
        
        static unsafe void glMultiTexCoord1f(TextureUnit target, float s) => instance.glMultiTexCoord1f(target, s);
        
        static unsafe void glMultiTexCoord1fARB(TextureUnit target, float s) => instance.glMultiTexCoord1fARB(target, s);
        
        static unsafe void glMultiTexCoord1fv(TextureUnit target, float * v) => instance.glMultiTexCoord1fv(target, v);
        
        static unsafe void glMultiTexCoord1fvARB(TextureUnit target, float * v) => instance.glMultiTexCoord1fvARB(target, v);
        
        static unsafe void glMultiTexCoord1hNV(TextureUnit target, OpenToolkit.Mathematics.Half s) => instance.glMultiTexCoord1hNV(target, s);
        
        static unsafe void glMultiTexCoord1hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v) => instance.glMultiTexCoord1hvNV(target, v);
        
        static unsafe void glMultiTexCoord1i(TextureUnit target, int s) => instance.glMultiTexCoord1i(target, s);
        
        static unsafe void glMultiTexCoord1iARB(TextureUnit target, int s) => instance.glMultiTexCoord1iARB(target, s);
        
        static unsafe void glMultiTexCoord1iv(TextureUnit target, int * v) => instance.glMultiTexCoord1iv(target, v);
        
        static unsafe void glMultiTexCoord1ivARB(TextureUnit target, int * v) => instance.glMultiTexCoord1ivARB(target, v);
        
        static unsafe void glMultiTexCoord1s(TextureUnit target, short s) => instance.glMultiTexCoord1s(target, s);
        
        static unsafe void glMultiTexCoord1sARB(TextureUnit target, short s) => instance.glMultiTexCoord1sARB(target, s);
        
        static unsafe void glMultiTexCoord1sv(TextureUnit target, short * v) => instance.glMultiTexCoord1sv(target, v);
        
        static unsafe void glMultiTexCoord1svARB(TextureUnit target, short * v) => instance.glMultiTexCoord1svARB(target, v);
        
        static unsafe void glMultiTexCoord1xOES(TextureUnit texture, int s) => instance.glMultiTexCoord1xOES(texture, s);
        
        static unsafe void glMultiTexCoord1xvOES(TextureUnit texture, int * coords) => instance.glMultiTexCoord1xvOES(texture, coords);
        
        static unsafe void glMultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t) => instance.glMultiTexCoord2bOES(texture, s, t);
        
        static unsafe void glMultiTexCoord2bvOES(TextureUnit texture, sbyte * coords) => instance.glMultiTexCoord2bvOES(texture, coords);
        
        static unsafe void glMultiTexCoord2d(TextureUnit target, double s, double t) => instance.glMultiTexCoord2d(target, s, t);
        
        static unsafe void glMultiTexCoord2dARB(TextureUnit target, double s, double t) => instance.glMultiTexCoord2dARB(target, s, t);
        
        static unsafe void glMultiTexCoord2dv(TextureUnit target, double * v) => instance.glMultiTexCoord2dv(target, v);
        
        static unsafe void glMultiTexCoord2dvARB(TextureUnit target, double * v) => instance.glMultiTexCoord2dvARB(target, v);
        
        static unsafe void glMultiTexCoord2f(TextureUnit target, float s, float t) => instance.glMultiTexCoord2f(target, s, t);
        
        static unsafe void glMultiTexCoord2fARB(TextureUnit target, float s, float t) => instance.glMultiTexCoord2fARB(target, s, t);
        
        static unsafe void glMultiTexCoord2fv(TextureUnit target, float * v) => instance.glMultiTexCoord2fv(target, v);
        
        static unsafe void glMultiTexCoord2fvARB(TextureUnit target, float * v) => instance.glMultiTexCoord2fvARB(target, v);
        
        static unsafe void glMultiTexCoord2hNV(TextureUnit target, OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t) => instance.glMultiTexCoord2hNV(target, s, t);
        
        static unsafe void glMultiTexCoord2hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v) => instance.glMultiTexCoord2hvNV(target, v);
        
        static unsafe void glMultiTexCoord2i(TextureUnit target, int s, int t) => instance.glMultiTexCoord2i(target, s, t);
        
        static unsafe void glMultiTexCoord2iARB(TextureUnit target, int s, int t) => instance.glMultiTexCoord2iARB(target, s, t);
        
        static unsafe void glMultiTexCoord2iv(TextureUnit target, int * v) => instance.glMultiTexCoord2iv(target, v);
        
        static unsafe void glMultiTexCoord2ivARB(TextureUnit target, int * v) => instance.glMultiTexCoord2ivARB(target, v);
        
        static unsafe void glMultiTexCoord2s(TextureUnit target, short s, short t) => instance.glMultiTexCoord2s(target, s, t);
        
        static unsafe void glMultiTexCoord2sARB(TextureUnit target, short s, short t) => instance.glMultiTexCoord2sARB(target, s, t);
        
        static unsafe void glMultiTexCoord2sv(TextureUnit target, short * v) => instance.glMultiTexCoord2sv(target, v);
        
        static unsafe void glMultiTexCoord2svARB(TextureUnit target, short * v) => instance.glMultiTexCoord2svARB(target, v);
        
        static unsafe void glMultiTexCoord2xOES(TextureUnit texture, int s, int t) => instance.glMultiTexCoord2xOES(texture, s, t);
        
        static unsafe void glMultiTexCoord2xvOES(TextureUnit texture, int * coords) => instance.glMultiTexCoord2xvOES(texture, coords);
        
        static unsafe void glMultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r) => instance.glMultiTexCoord3bOES(texture, s, t, r);
        
        static unsafe void glMultiTexCoord3bvOES(TextureUnit texture, sbyte * coords) => instance.glMultiTexCoord3bvOES(texture, coords);
        
        static unsafe void glMultiTexCoord3d(TextureUnit target, double s, double t, double r) => instance.glMultiTexCoord3d(target, s, t, r);
        
        static unsafe void glMultiTexCoord3dARB(TextureUnit target, double s, double t, double r) => instance.glMultiTexCoord3dARB(target, s, t, r);
        
        static unsafe void glMultiTexCoord3dv(TextureUnit target, double * v) => instance.glMultiTexCoord3dv(target, v);
        
        static unsafe void glMultiTexCoord3dvARB(TextureUnit target, double * v) => instance.glMultiTexCoord3dvARB(target, v);
        
        static unsafe void glMultiTexCoord3f(TextureUnit target, float s, float t, float r) => instance.glMultiTexCoord3f(target, s, t, r);
        
        static unsafe void glMultiTexCoord3fARB(TextureUnit target, float s, float t, float r) => instance.glMultiTexCoord3fARB(target, s, t, r);
        
        static unsafe void glMultiTexCoord3fv(TextureUnit target, float * v) => instance.glMultiTexCoord3fv(target, v);
        
        static unsafe void glMultiTexCoord3fvARB(TextureUnit target, float * v) => instance.glMultiTexCoord3fvARB(target, v);
        
        static unsafe void glMultiTexCoord3hNV(TextureUnit target, OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r) => instance.glMultiTexCoord3hNV(target, s, t, r);
        
        static unsafe void glMultiTexCoord3hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v) => instance.glMultiTexCoord3hvNV(target, v);
        
        static unsafe void glMultiTexCoord3i(TextureUnit target, int s, int t, int r) => instance.glMultiTexCoord3i(target, s, t, r);
        
        static unsafe void glMultiTexCoord3iARB(TextureUnit target, int s, int t, int r) => instance.glMultiTexCoord3iARB(target, s, t, r);
        
        static unsafe void glMultiTexCoord3iv(TextureUnit target, int * v) => instance.glMultiTexCoord3iv(target, v);
        
        static unsafe void glMultiTexCoord3ivARB(TextureUnit target, int * v) => instance.glMultiTexCoord3ivARB(target, v);
        
        static unsafe void glMultiTexCoord3s(TextureUnit target, short s, short t, short r) => instance.glMultiTexCoord3s(target, s, t, r);
        
        static unsafe void glMultiTexCoord3sARB(TextureUnit target, short s, short t, short r) => instance.glMultiTexCoord3sARB(target, s, t, r);
        
        static unsafe void glMultiTexCoord3sv(TextureUnit target, short * v) => instance.glMultiTexCoord3sv(target, v);
        
        static unsafe void glMultiTexCoord3svARB(TextureUnit target, short * v) => instance.glMultiTexCoord3svARB(target, v);
        
        static unsafe void glMultiTexCoord3xOES(TextureUnit texture, int s, int t, int r) => instance.glMultiTexCoord3xOES(texture, s, t, r);
        
        static unsafe void glMultiTexCoord3xvOES(TextureUnit texture, int * coords) => instance.glMultiTexCoord3xvOES(texture, coords);
        
        static unsafe void glMultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => instance.glMultiTexCoord4bOES(texture, s, t, r, q);
        
        static unsafe void glMultiTexCoord4bvOES(TextureUnit texture, sbyte * coords) => instance.glMultiTexCoord4bvOES(texture, coords);
        
        static unsafe void glMultiTexCoord4d(TextureUnit target, double s, double t, double r, double q) => instance.glMultiTexCoord4d(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4dARB(TextureUnit target, double s, double t, double r, double q) => instance.glMultiTexCoord4dARB(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4dv(TextureUnit target, double * v) => instance.glMultiTexCoord4dv(target, v);
        
        static unsafe void glMultiTexCoord4dvARB(TextureUnit target, double * v) => instance.glMultiTexCoord4dvARB(target, v);
        
        static unsafe void glMultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => instance.glMultiTexCoord4f(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4fARB(TextureUnit target, float s, float t, float r, float q) => instance.glMultiTexCoord4fARB(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4fv(TextureUnit target, float * v) => instance.glMultiTexCoord4fv(target, v);
        
        static unsafe void glMultiTexCoord4fvARB(TextureUnit target, float * v) => instance.glMultiTexCoord4fvARB(target, v);
        
        static unsafe void glMultiTexCoord4hNV(TextureUnit target, OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r, OpenToolkit.Mathematics.Half q) => instance.glMultiTexCoord4hNV(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v) => instance.glMultiTexCoord4hvNV(target, v);
        
        static unsafe void glMultiTexCoord4i(TextureUnit target, int s, int t, int r, int q) => instance.glMultiTexCoord4i(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4iARB(TextureUnit target, int s, int t, int r, int q) => instance.glMultiTexCoord4iARB(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4iv(TextureUnit target, int * v) => instance.glMultiTexCoord4iv(target, v);
        
        static unsafe void glMultiTexCoord4ivARB(TextureUnit target, int * v) => instance.glMultiTexCoord4ivARB(target, v);
        
        static unsafe void glMultiTexCoord4s(TextureUnit target, short s, short t, short r, short q) => instance.glMultiTexCoord4s(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4sARB(TextureUnit target, short s, short t, short r, short q) => instance.glMultiTexCoord4sARB(target, s, t, r, q);
        
        static unsafe void glMultiTexCoord4sv(TextureUnit target, short * v) => instance.glMultiTexCoord4sv(target, v);
        
        static unsafe void glMultiTexCoord4svARB(TextureUnit target, short * v) => instance.glMultiTexCoord4svARB(target, v);
        
        static unsafe void glMultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => instance.glMultiTexCoord4x(texture, s, t, r, q);
        
        static unsafe void glMultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q) => instance.glMultiTexCoord4xOES(texture, s, t, r, q);
        
        static unsafe void glMultiTexCoord4xvOES(TextureUnit texture, int * coords) => instance.glMultiTexCoord4xvOES(texture, coords);
        
        static unsafe void glMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, uint coords) => instance.glMultiTexCoordP1ui(texture, type, coords);
        
        static unsafe void glMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, uint * coords) => instance.glMultiTexCoordP1uiv(texture, type, coords);
        
        static unsafe void glMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, uint coords) => instance.glMultiTexCoordP2ui(texture, type, coords);
        
        static unsafe void glMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, uint * coords) => instance.glMultiTexCoordP2uiv(texture, type, coords);
        
        static unsafe void glMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, uint coords) => instance.glMultiTexCoordP3ui(texture, type, coords);
        
        static unsafe void glMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, uint * coords) => instance.glMultiTexCoordP3uiv(texture, type, coords);
        
        static unsafe void glMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, uint coords) => instance.glMultiTexCoordP4ui(texture, type, coords);
        
        static unsafe void glMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, uint * coords) => instance.glMultiTexCoordP4uiv(texture, type, coords);
        
        static unsafe void glMultiTexCoordPointerEXT(TextureUnit texunit, int size, TexCoordPointerType type, uint stride, void * pointer) => instance.glMultiTexCoordPointerEXT(texunit, size, type, stride, pointer);
        
        static unsafe void glMultiTexEnvfEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float param) => instance.glMultiTexEnvfEXT(texunit, target, pname, param);
        
        static unsafe void glMultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS) => instance.glMultiTexEnvfvEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glMultiTexEnviEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int param) => instance.glMultiTexEnviEXT(texunit, target, pname, param);
        
        static unsafe void glMultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glMultiTexEnvivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glMultiTexGendEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double param) => instance.glMultiTexGendEXT(texunit, coord, pname, param);
        
        static unsafe void glMultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double * PARAMS) => instance.glMultiTexGendvEXT(texunit, coord, pname, PARAMS);
        
        static unsafe void glMultiTexGenfEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float param) => instance.glMultiTexGenfEXT(texunit, coord, pname, param);
        
        static unsafe void glMultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float * PARAMS) => instance.glMultiTexGenfvEXT(texunit, coord, pname, PARAMS);
        
        static unsafe void glMultiTexGeniEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int param) => instance.glMultiTexGeniEXT(texunit, coord, pname, param);
        
        static unsafe void glMultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glMultiTexGenivEXT(texunit, coord, pname, PARAMS);
        
        static unsafe void glMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int internalformat, uint width, int border, PixelFormat format, PixelType type, void * pixels) => instance.glMultiTexImage1DEXT(texunit, target, level, internalformat, width, border, format, type, pixels);
        
        static unsafe void glMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int internalformat, uint width, uint height, int border, PixelFormat format, PixelType type, void * pixels) => instance.glMultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, format, type, pixels);
        
        static unsafe void glMultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels) => instance.glMultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels);
        
        static unsafe void glMultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glMultiTexParameterIivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glMultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, uint * PARAMS) => instance.glMultiTexParameterIuivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glMultiTexParameterfEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float param) => instance.glMultiTexParameterfEXT(texunit, target, pname, param);
        
        static unsafe void glMultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float * PARAMS) => instance.glMultiTexParameterfvEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glMultiTexParameteriEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int param) => instance.glMultiTexParameteriEXT(texunit, target, pname, param);
        
        static unsafe void glMultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glMultiTexParameterivEXT(texunit, target, pname, PARAMS);
        
        static unsafe void glMultiTexRenderbufferEXT(TextureUnit texunit, TextureTarget target, uint renderbuffer) => instance.glMultiTexRenderbufferEXT(texunit, target, renderbuffer);
        
        static unsafe void glMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels) => instance.glMultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, type, pixels);
        
        static unsafe void glMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels) => instance.glMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels);
        
        static unsafe void glMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels) => instance.glMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        
        static unsafe void glMulticastBarrierNV() => instance.glMulticastBarrierNV();
        
        static unsafe void glMulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, UIntPtr size, void * data) => instance.glMulticastBufferSubDataNV(gpuMask, buffer, offset, size, data);
        
        static unsafe void glMulticastCopyBufferSubDataNV(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size) => instance.glMulticastCopyBufferSubDataNV(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);
        
        static unsafe void glMulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, uint count, float * v) => instance.glMulticastFramebufferSampleLocationsfvNV(gpu, framebuffer, start, count, v);
        
        static unsafe void glMulticastScissorArrayvNVX(uint gpu, uint first, uint count, int * v) => instance.glMulticastScissorArrayvNVX(gpu, first, count, v);
        
        static unsafe void glMulticastViewportArrayvNVX(uint gpu, uint first, uint count, float * v) => instance.glMulticastViewportArrayvNVX(gpu, first, count, v);
        
        static unsafe void glMulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff) => instance.glMulticastViewportPositionWScaleNVX(gpu, index, xcoeff, ycoeff);
        
        static unsafe void glMulticastWaitSyncNV(uint signalGpu, uint waitGpuMask) => instance.glMulticastWaitSyncNV(signalGpu, waitGpuMask);
        
        static unsafe void glNamedBufferAttachMemoryNV(uint buffer, uint memory, ulong offset) => instance.glNamedBufferAttachMemoryNV(buffer, memory, offset);
        
        static unsafe void glNamedBufferData(uint buffer, UIntPtr size, void * data, VertexBufferObjectUsage usage) => instance.glNamedBufferData(buffer, size, data, usage);
        
        static unsafe void glNamedBufferDataEXT(uint buffer, UIntPtr size, void * data, VertexBufferObjectUsage usage) => instance.glNamedBufferDataEXT(buffer, size, data, usage);
        
        static unsafe void glNamedBufferPageCommitmentARB(uint buffer, IntPtr offset, UIntPtr size, bool commit) => instance.glNamedBufferPageCommitmentARB(buffer, offset, size, commit);
        
        static unsafe void glNamedBufferPageCommitmentEXT(uint buffer, IntPtr offset, UIntPtr size, bool commit) => instance.glNamedBufferPageCommitmentEXT(buffer, offset, size, commit);
        
        static unsafe void glNamedBufferStorage(uint buffer, UIntPtr size, void * data, uint flags) => instance.glNamedBufferStorage(buffer, size, data, flags);
        
        static unsafe void glNamedBufferStorageExternalEXT(uint buffer, IntPtr offset, UIntPtr size, IntPtr clientBuffer, uint flags) => instance.glNamedBufferStorageExternalEXT(buffer, offset, size, clientBuffer, flags);
        
        static unsafe void glNamedBufferStorageEXT(uint buffer, UIntPtr size, void * data, uint flags) => instance.glNamedBufferStorageEXT(buffer, size, data, flags);
        
        static unsafe void glNamedBufferStorageMemEXT(uint buffer, UIntPtr size, uint memory, ulong offset) => instance.glNamedBufferStorageMemEXT(buffer, size, memory, offset);
        
        static unsafe void glNamedBufferSubData(uint buffer, IntPtr offset, UIntPtr size, void * data) => instance.glNamedBufferSubData(buffer, offset, size, data);
        
        static unsafe void glNamedBufferSubDataEXT(uint buffer, IntPtr offset, UIntPtr size, void * data) => instance.glNamedBufferSubDataEXT(buffer, offset, size, data);
        
        static unsafe void glNamedCopyBufferSubDataEXT(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size) => instance.glNamedCopyBufferSubDataEXT(readBuffer, writeBuffer, readOffset, writeOffset, size);
        
        static unsafe void glNamedFramebufferDrawBuffer(uint framebuffer, ColorBuffer buf) => instance.glNamedFramebufferDrawBuffer(framebuffer, buf);
        
        static unsafe void glNamedFramebufferDrawBuffers(uint framebuffer, uint n, ColorBuffer * bufs) => instance.glNamedFramebufferDrawBuffers(framebuffer, n, bufs);
        
        static unsafe void glNamedFramebufferParameteri(uint framebuffer, FramebufferParameterName pname, int param) => instance.glNamedFramebufferParameteri(framebuffer, pname, param);
        
        static unsafe void glNamedFramebufferParameteriEXT(uint framebuffer, FramebufferParameterName pname, int param) => instance.glNamedFramebufferParameteriEXT(framebuffer, pname, param);
        
        static unsafe void glNamedFramebufferReadBuffer(uint framebuffer, ColorBuffer src) => instance.glNamedFramebufferReadBuffer(framebuffer, src);
        
        static unsafe void glNamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer) => instance.glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
        
        static unsafe void glNamedFramebufferRenderbufferEXT(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer) => instance.glNamedFramebufferRenderbufferEXT(framebuffer, attachment, renderbuffertarget, renderbuffer);
        
        static unsafe void glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, uint count, float * v) => instance.glNamedFramebufferSampleLocationsfvARB(framebuffer, start, count, v);
        
        static unsafe void glNamedFramebufferSampleLocationsfvNV(uint framebuffer, uint start, uint count, float * v) => instance.glNamedFramebufferSampleLocationsfvNV(framebuffer, start, count, v);
        
        static unsafe void glNamedFramebufferTexture(uint framebuffer, FramebufferAttachment attachment, uint texture, int level) => instance.glNamedFramebufferTexture(framebuffer, attachment, texture, level);
        
        static unsafe void glNamedFramebufferSamplePositionsfvAMD(uint framebuffer, uint numsamples, uint pixelindex, float * values) => instance.glNamedFramebufferSamplePositionsfvAMD(framebuffer, numsamples, pixelindex, values);
        
        static unsafe void glNamedFramebufferTexture1DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => instance.glNamedFramebufferTexture1DEXT(framebuffer, attachment, textarget, texture, level);
        
        static unsafe void glNamedFramebufferTexture2DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level) => instance.glNamedFramebufferTexture2DEXT(framebuffer, attachment, textarget, texture, level);
        
        static unsafe void glNamedFramebufferTexture3DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset) => instance.glNamedFramebufferTexture3DEXT(framebuffer, attachment, textarget, texture, level, zoffset);
        
        static unsafe void glNamedFramebufferTextureEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level) => instance.glNamedFramebufferTextureEXT(framebuffer, attachment, texture, level);
        
        static unsafe void glNamedFramebufferTextureFaceEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, TextureTarget face) => instance.glNamedFramebufferTextureFaceEXT(framebuffer, attachment, texture, level, face);
        
        static unsafe void glNamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer) => instance.glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
        
        static unsafe void glNamedFramebufferTextureLayerEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer) => instance.glNamedFramebufferTextureLayerEXT(framebuffer, attachment, texture, level, layer);
        
        static unsafe void glNamedProgramLocalParameter4dEXT(uint program, ProgramTarget target, uint index, double x, double y, double z, double w) => instance.glNamedProgramLocalParameter4dEXT(program, target, index, x, y, z, w);
        
        static unsafe void glNamedProgramLocalParameter4dvEXT(uint program, ProgramTarget target, uint index, double * PARAMS) => instance.glNamedProgramLocalParameter4dvEXT(program, target, index, PARAMS);
        
        static unsafe void glNamedProgramLocalParameter4fEXT(uint program, ProgramTarget target, uint index, float x, float y, float z, float w) => instance.glNamedProgramLocalParameter4fEXT(program, target, index, x, y, z, w);
        
        static unsafe void glNamedProgramLocalParameter4fvEXT(uint program, ProgramTarget target, uint index, float * PARAMS) => instance.glNamedProgramLocalParameter4fvEXT(program, target, index, PARAMS);
        
        static unsafe void glNamedProgramLocalParameterI4iEXT(uint program, ProgramTarget target, uint index, int x, int y, int z, int w) => instance.glNamedProgramLocalParameterI4iEXT(program, target, index, x, y, z, w);
        
        static unsafe void glNamedProgramLocalParameterI4ivEXT(uint program, ProgramTarget target, uint index, int * PARAMS) => instance.glNamedProgramLocalParameterI4ivEXT(program, target, index, PARAMS);
        
        static unsafe void glNamedProgramLocalParameterI4uiEXT(uint program, ProgramTarget target, uint index, uint x, uint y, uint z, uint w) => instance.glNamedProgramLocalParameterI4uiEXT(program, target, index, x, y, z, w);
        
        static unsafe void glNamedProgramLocalParameterI4uivEXT(uint program, ProgramTarget target, uint index, uint * PARAMS) => instance.glNamedProgramLocalParameterI4uivEXT(program, target, index, PARAMS);
        
        static unsafe void glNamedProgramLocalParameters4fvEXT(uint program, ProgramTarget target, uint index, uint count, float * PARAMS) => instance.glNamedProgramLocalParameters4fvEXT(program, target, index, count, PARAMS);
        
        static unsafe void glNamedProgramLocalParametersI4ivEXT(uint program, ProgramTarget target, uint index, uint count, int * PARAMS) => instance.glNamedProgramLocalParametersI4ivEXT(program, target, index, count, PARAMS);
        
        static unsafe void glNamedProgramLocalParametersI4uivEXT(uint program, ProgramTarget target, uint index, uint count, uint * PARAMS) => instance.glNamedProgramLocalParametersI4uivEXT(program, target, index, count, PARAMS);
        
        static unsafe void glNamedProgramStringEXT(uint program, ProgramTarget target, ProgramFormat format, uint len, void * STRING) => instance.glNamedProgramStringEXT(program, target, format, len, STRING);
        
        static unsafe void glNamedRenderbufferStorage(uint renderbuffer, InternalFormat internalformat, uint width, uint height) => instance.glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
        
        static unsafe void glNamedRenderbufferStorageEXT(uint renderbuffer, InternalFormat internalformat, uint width, uint height) => instance.glNamedRenderbufferStorageEXT(renderbuffer, internalformat, width, height);
        
        static unsafe void glNamedRenderbufferStorageMultisample(uint renderbuffer, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
        
        static unsafe void glNamedRenderbufferStorageMultisampleAdvancedAMD(uint renderbuffer, uint samples, uint storageSamples, InternalFormat internalformat, uint width, uint height) => instance.glNamedRenderbufferStorageMultisampleAdvancedAMD(renderbuffer, samples, storageSamples, internalformat, width, height);
        
        static unsafe void glNamedRenderbufferStorageMultisampleCoverageEXT(uint renderbuffer, uint coverageSamples, uint colorSamples, InternalFormat internalformat, uint width, uint height) => instance.glNamedRenderbufferStorageMultisampleCoverageEXT(renderbuffer, coverageSamples, colorSamples, internalformat, width, height);
        
        static unsafe void glNamedRenderbufferStorageMultisampleEXT(uint renderbuffer, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glNamedRenderbufferStorageMultisampleEXT(renderbuffer, samples, internalformat, width, height);
        
        static unsafe void glNewList(uint list, ListMode mode) => instance.glNewList(list, mode);
        
        static unsafe uint glNewObjectBufferATI(uint size, void * pointer, ArrayObjectUsageATI usage) => instance.glNewObjectBufferATI(size, pointer, usage);
        
        static unsafe void glNormal3b(sbyte nx, sbyte ny, sbyte nz) => instance.glNormal3b(nx, ny, nz);
        
        static unsafe void glNormal3bv(sbyte * v) => instance.glNormal3bv(v);
        
        static unsafe void glNormal3d(double nx, double ny, double nz) => instance.glNormal3d(nx, ny, nz);
        
        static unsafe void glNormal3dv(double * v) => instance.glNormal3dv(v);
        
        static unsafe void glNormal3f(float nx, float ny, float nz) => instance.glNormal3f(nx, ny, nz);
        
        static unsafe void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z) => instance.glNormal3fVertex3fSUN(nx, ny, nz, x, y, z);
        
        static unsafe void glNormal3fVertex3fvSUN(float * n, float * v) => instance.glNormal3fVertex3fvSUN(n, v);
        
        static unsafe void glNormal3fv(float * v) => instance.glNormal3fv(v);
        
        static unsafe void glNormal3hNV(OpenToolkit.Mathematics.Half nx, OpenToolkit.Mathematics.Half ny, OpenToolkit.Mathematics.Half nz) => instance.glNormal3hNV(nx, ny, nz);
        
        static unsafe void glNormal3hvNV(OpenToolkit.Mathematics.Half * v) => instance.glNormal3hvNV(v);
        
        static unsafe void glNormal3i(int nx, int ny, int nz) => instance.glNormal3i(nx, ny, nz);
        
        static unsafe void glNormal3iv(int * v) => instance.glNormal3iv(v);
        
        static unsafe void glNormal3s(short nx, short ny, short nz) => instance.glNormal3s(nx, ny, nz);
        
        static unsafe void glNormal3sv(short * v) => instance.glNormal3sv(v);
        
        static unsafe void glNormal3x(int nx, int ny, int nz) => instance.glNormal3x(nx, ny, nz);
        
        static unsafe void glNormal3xOES(int nx, int ny, int nz) => instance.glNormal3xOES(nx, ny, nz);
        
        static unsafe void glNormal3xvOES(int * coords) => instance.glNormal3xvOES(coords);
        
        static unsafe void glNormalP3ui(NormalPointerType type, uint coords) => instance.glNormalP3ui(type, coords);
        
        static unsafe void glNormalP3uiv(NormalPointerType type, uint * coords) => instance.glNormalP3uiv(type, coords);
        
        static unsafe void glNormalPointer(NormalPointerType type, uint stride, void * pointer) => instance.glNormalPointer(type, stride, pointer);
        
        static unsafe void glNormalPointerEXT(NormalPointerType type, uint stride, uint count, void * pointer) => instance.glNormalPointerEXT(type, stride, count, pointer);
        
        static unsafe void glNormalPointerListIBM(NormalPointerType type, int stride, void * * pointer, int ptrstride) => instance.glNormalPointerListIBM(type, stride, pointer, ptrstride);
        
        static unsafe void glNormalPointervINTEL(NormalPointerType type, void * * pointer) => instance.glNormalPointervINTEL(type, pointer);
        
        static unsafe void glNormalStream3bATI(VertexStreamATI stream, sbyte nx, sbyte ny, sbyte nz) => instance.glNormalStream3bATI(stream, nx, ny, nz);
        
        static unsafe void glNormalStream3bvATI(VertexStreamATI stream, sbyte * coords) => instance.glNormalStream3bvATI(stream, coords);
        
        static unsafe void glNormalStream3dATI(VertexStreamATI stream, double nx, double ny, double nz) => instance.glNormalStream3dATI(stream, nx, ny, nz);
        
        static unsafe void glNormalStream3dvATI(VertexStreamATI stream, double * coords) => instance.glNormalStream3dvATI(stream, coords);
        
        static unsafe void glNormalStream3fATI(VertexStreamATI stream, float nx, float ny, float nz) => instance.glNormalStream3fATI(stream, nx, ny, nz);
        
        static unsafe void glNormalStream3fvATI(VertexStreamATI stream, float * coords) => instance.glNormalStream3fvATI(stream, coords);
        
        static unsafe void glNormalStream3iATI(VertexStreamATI stream, int nx, int ny, int nz) => instance.glNormalStream3iATI(stream, nx, ny, nz);
        
        static unsafe void glNormalStream3ivATI(VertexStreamATI stream, int * coords) => instance.glNormalStream3ivATI(stream, coords);
        
        static unsafe void glNormalStream3sATI(VertexStreamATI stream, short nx, short ny, short nz) => instance.glNormalStream3sATI(stream, nx, ny, nz);
        
        static unsafe void glNormalStream3svATI(VertexStreamATI stream, short * coords) => instance.glNormalStream3svATI(stream, coords);
        
        static unsafe void glObjectLabel(ObjectIdentifier identifier, uint name, uint length, char * label) => instance.glObjectLabel(identifier, name, length, label);
        
        static unsafe void glObjectLabelKHR(ObjectIdentifier identifier, uint name, uint length, char * label) => instance.glObjectLabelKHR(identifier, name, length, label);
        
        static unsafe void glObjectPtrLabel(void * ptr, uint length, char * label) => instance.glObjectPtrLabel(ptr, length, label);
        
        static unsafe void glObjectPtrLabelKHR(void * ptr, uint length, char * label) => instance.glObjectPtrLabelKHR(ptr, length, label);
        
        static unsafe void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar) => instance.glOrtho(left, right, bottom, top, zNear, zFar);
        
        static unsafe void glOrthof(float l, float r, float b, float t, float n, float f) => instance.glOrthof(l, r, b, t, n, f);
        
        static unsafe void glOrthofOES(float l, float r, float b, float t, float n, float f) => instance.glOrthofOES(l, r, b, t, n, f);
        
        static unsafe void glOrthox(int l, int r, int b, int t, int n, int f) => instance.glOrthox(l, r, b, t, n, f);
        
        static unsafe void glOrthoxOES(int l, int r, int b, int t, int n, int f) => instance.glOrthoxOES(l, r, b, t, n, f);
        
        static unsafe void glPNTrianglesfATI(PNTrianglesPNameATI pname, float param) => instance.glPNTrianglesfATI(pname, param);
        
        static unsafe void glPNTrianglesiATI(PNTrianglesPNameATI pname, int param) => instance.glPNTrianglesiATI(pname, param);
        
        static unsafe void glPassTexCoordATI(uint dst, uint coord, SwizzleOpATI swizzle) => instance.glPassTexCoordATI(dst, coord, swizzle);
        
        static unsafe void glPassThrough(float token) => instance.glPassThrough(token);
        
        static unsafe void glPassThroughxOES(int token) => instance.glPassThroughxOES(token);
        
        static unsafe void glPatchParameterfv(PatchParameterName pname, float * values) => instance.glPatchParameterfv(pname, values);
        
        static unsafe void glPatchParameteri(PatchParameterName pname, int value) => instance.glPatchParameteri(pname, value);
        
        static unsafe void glPatchParameteriEXT(PatchParameterName pname, int value) => instance.glPatchParameteriEXT(pname, value);
        
        static unsafe void glPatchParameteriOES(PatchParameterName pname, int value) => instance.glPatchParameteriOES(pname, value);
        
        static unsafe void glPathColorGenNV(PathColor color, PathGenMode genMode, PathColorFormat colorFormat, float * coeffs) => instance.glPathColorGenNV(color, genMode, colorFormat, coeffs);
        
        static unsafe void glPathCommandsNV(uint path, uint numCommands, byte * commands, uint numCoords, PathCoordType coordType, void * coords) => instance.glPathCommandsNV(path, numCommands, commands, numCoords, coordType, coords);
        
        static unsafe void glPathCoordsNV(uint path, uint numCoords, PathCoordType coordType, void * coords) => instance.glPathCoordsNV(path, numCoords, coordType, coords);
        
        static unsafe void glPathCoverDepthFuncNV(DepthFunction func) => instance.glPathCoverDepthFuncNV(func);
        
        static unsafe void glPathDashArrayNV(uint path, uint dashCount, float * dashArray) => instance.glPathDashArrayNV(path, dashCount, dashArray);
        
        static unsafe void glPathFogGenNV(PathGenMode genMode) => instance.glPathFogGenNV(genMode);
        
        static unsafe void glPathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, void * fontName, uint fontStyle, uint firstGlyph, uint numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => instance.glPathGlyphRangeNV(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        
        static unsafe void glPathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, void * fontName, uint fontStyle, uint numGlyphs, PathElementType type, void * charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale) => instance.glPathGlyphsNV(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        
        static unsafe void glPathParameterfNV(uint path, PathParameter pname, float value) => instance.glPathParameterfNV(path, pname, value);
        
        static unsafe void glPathParameterfvNV(uint path, PathParameter pname, float * value) => instance.glPathParameterfvNV(path, pname, value);
        
        static unsafe void glPathParameteriNV(uint path, PathParameter pname, int value) => instance.glPathParameteriNV(path, pname, value);
        
        static unsafe void glPathParameterivNV(uint path, PathParameter pname, int * value) => instance.glPathParameterivNV(path, pname, value);
        
        static unsafe void glPathStencilDepthOffsetNV(float factor, float units) => instance.glPathStencilDepthOffsetNV(factor, units);
        
        static unsafe void glPathStencilFuncNV(StencilFunction func, int REF, uint mask) => instance.glPathStencilFuncNV(func, REF, mask);
        
        static unsafe void glPathStringNV(uint path, PathStringFormat format, uint length, void * pathString) => instance.glPathStringNV(path, format, length, pathString);
        
        static unsafe void glPathSubCommandsNV(uint path, uint commandStart, uint commandsToDelete, uint numCommands, byte * commands, uint numCoords, PathCoordType coordType, void * coords) => instance.glPathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);
        
        static unsafe void glPathSubCoordsNV(uint path, uint coordStart, uint numCoords, PathCoordType coordType, void * coords) => instance.glPathSubCoordsNV(path, coordStart, numCoords, coordType, coords);
        
        static unsafe void glPathTexGenNV(PathColor texCoordSet, PathGenMode genMode, int components, float * coeffs) => instance.glPathTexGenNV(texCoordSet, genMode, components, coeffs);
        
        static unsafe void glPauseTransformFeedback() => instance.glPauseTransformFeedback();
        
        static unsafe void glPauseTransformFeedbackNV() => instance.glPauseTransformFeedbackNV();
        
        static unsafe void glPixelDataRangeNV(PixelDataRangeTargetNV target, uint length, void * pointer) => instance.glPixelDataRangeNV(target, length, pointer);
        
        static unsafe void glPixelMapfv(PixelMap map, uint mapsize, float * values) => instance.glPixelMapfv(map, mapsize, values);
        
        static unsafe void glPixelMapuiv(PixelMap map, uint mapsize, uint * values) => instance.glPixelMapuiv(map, mapsize, values);
        
        static unsafe void glPixelMapusv(PixelMap map, uint mapsize, ushort * values) => instance.glPixelMapusv(map, mapsize, values);
        
        static unsafe void glPixelMapx(PixelMap map, int size, int * values) => instance.glPixelMapx(map, size, values);
        
        static unsafe void glPixelStoref(PixelStoreParameter pname, float param) => instance.glPixelStoref(pname, param);
        
        static unsafe void glPixelStorei(PixelStoreParameter pname, int param) => instance.glPixelStorei(pname, param);
        
        static unsafe void glPixelStorex(PixelStoreParameter pname, int param) => instance.glPixelStorex(pname, param);
        
        static unsafe void glPixelTexGenParameterfSGIS(PixelTexGenParameterNameSGIS pname, float param) => instance.glPixelTexGenParameterfSGIS(pname, param);
        
        static unsafe void glPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float * PARAMS) => instance.glPixelTexGenParameterfvSGIS(pname, PARAMS);
        
        static unsafe void glPixelTexGenParameteriSGIS(PixelTexGenParameterNameSGIS pname, int param) => instance.glPixelTexGenParameteriSGIS(pname, param);
        
        static unsafe void glPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int * PARAMS) => instance.glPixelTexGenParameterivSGIS(pname, PARAMS);
        
        static unsafe void glPixelTexGenSGIX(PixelTexGenModeSGIX mode) => instance.glPixelTexGenSGIX(mode);
        
        static unsafe void glPixelTransferf(PixelTransferParameter pname, float param) => instance.glPixelTransferf(pname, param);
        
        static unsafe void glPixelTransferi(PixelTransferParameter pname, int param) => instance.glPixelTransferi(pname, param);
        
        static unsafe void glPixelTransferxOES(PixelTransferParameter pname, int param) => instance.glPixelTransferxOES(pname, param);
        
        static unsafe void glPixelTransformParameterfEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float param) => instance.glPixelTransformParameterfEXT(target, pname, param);
        
        static unsafe void glPixelTransformParameterfvEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float * PARAMS) => instance.glPixelTransformParameterfvEXT(target, pname, PARAMS);
        
        static unsafe void glPixelTransformParameteriEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int param) => instance.glPixelTransformParameteriEXT(target, pname, param);
        
        static unsafe void glPixelTransformParameterivEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int * PARAMS) => instance.glPixelTransformParameterivEXT(target, pname, PARAMS);
        
        static unsafe void glPixelZoom(float xfactor, float yfactor) => instance.glPixelZoom(xfactor, yfactor);
        
        static unsafe void glPixelZoomxOES(int xfactor, int yfactor) => instance.glPixelZoomxOES(xfactor, yfactor);
        
        static unsafe bool glPointAlongPathNV(uint path, uint startSegment, uint numSegments, float distance, float * x, float * y, float * tangentX, float * tangentY) => instance.glPointAlongPathNV(path, startSegment, numSegments, distance, x, y, tangentX, tangentY);
        
        static unsafe void glPointParameterf(PointParameterNameARB pname, float param) => instance.glPointParameterf(pname, param);
        
        static unsafe void glPointParameterfARB(PointParameterNameARB pname, float param) => instance.glPointParameterfARB(pname, param);
        
        static unsafe void glPointParameterfEXT(PointParameterNameARB pname, float param) => instance.glPointParameterfEXT(pname, param);
        
        static unsafe void glPointParameterfSGIS(PointParameterNameARB pname, float param) => instance.glPointParameterfSGIS(pname, param);
        
        static unsafe void glPointParameterfv(PointParameterNameARB pname, float * PARAMS) => instance.glPointParameterfv(pname, PARAMS);
        
        static unsafe void glPointParameterfvARB(PointParameterNameARB pname, float * PARAMS) => instance.glPointParameterfvARB(pname, PARAMS);
        
        static unsafe void glPointParameterfvEXT(PointParameterNameARB pname, float * PARAMS) => instance.glPointParameterfvEXT(pname, PARAMS);
        
        static unsafe void glPointParameterfvSGIS(PointParameterNameARB pname, float * PARAMS) => instance.glPointParameterfvSGIS(pname, PARAMS);
        
        static unsafe void glPointParameteri(PointParameterNameARB pname, int param) => instance.glPointParameteri(pname, param);
        
        static unsafe void glPointParameteriNV(PointParameterNameARB pname, int param) => instance.glPointParameteriNV(pname, param);
        
        static unsafe void glPointParameteriv(PointParameterNameARB pname, int * PARAMS) => instance.glPointParameteriv(pname, PARAMS);
        
        static unsafe void glPointParameterivNV(PointParameterNameARB pname, int * PARAMS) => instance.glPointParameterivNV(pname, PARAMS);
        
        static unsafe void glPointParameterx(PointParameterNameARB pname, int param) => instance.glPointParameterx(pname, param);
        
        static unsafe void glPointParameterxOES(PointParameterNameARB pname, int param) => instance.glPointParameterxOES(pname, param);
        
        static unsafe void glPointParameterxv(PointParameterNameARB pname, int * PARAMS) => instance.glPointParameterxv(pname, PARAMS);
        
        static unsafe void glPointParameterxvOES(PointParameterNameARB pname, int * PARAMS) => instance.glPointParameterxvOES(pname, PARAMS);
        
        static unsafe void glPointSize(float size) => instance.glPointSize(size);
        
        static unsafe void glPointSizex(int size) => instance.glPointSizex(size);
        
        static unsafe void glPointSizexOES(int size) => instance.glPointSizexOES(size);
        
        static unsafe int glPollAsyncSGIX(uint * markerp) => instance.glPollAsyncSGIX(markerp);
        
        static unsafe int glPollInstrumentsSGIX(int * marker_p) => instance.glPollInstrumentsSGIX(marker_p);
        
        static unsafe void glPolygonMode(MaterialFace face, PolygonMode mode) => instance.glPolygonMode(face, mode);
        
        static unsafe void glPolygonModeNV(MaterialFace face, PolygonMode mode) => instance.glPolygonModeNV(face, mode);
        
        static unsafe void glPolygonOffset(float factor, float units) => instance.glPolygonOffset(factor, units);
        
        static unsafe void glPolygonOffsetClamp(float factor, float units, float clamp) => instance.glPolygonOffsetClamp(factor, units, clamp);
        
        static unsafe void glPolygonOffsetClampEXT(float factor, float units, float clamp) => instance.glPolygonOffsetClampEXT(factor, units, clamp);
        
        static unsafe void glPolygonOffsetEXT(float factor, float bias) => instance.glPolygonOffsetEXT(factor, bias);
        
        static unsafe void glPolygonOffsetx(int factor, int units) => instance.glPolygonOffsetx(factor, units);
        
        static unsafe void glPolygonOffsetxOES(int factor, int units) => instance.glPolygonOffsetxOES(factor, units);
        
        static unsafe void glPolygonStipple(byte * mask) => instance.glPolygonStipple(mask);
        
        static unsafe void glPopAttrib() => instance.glPopAttrib();
        
        static unsafe void glPopClientAttrib() => instance.glPopClientAttrib();
        
        static unsafe void glPopDebugGroup() => instance.glPopDebugGroup();
        
        static unsafe void glPopDebugGroupKHR() => instance.glPopDebugGroupKHR();
        
        static unsafe void glPopGroupMarkerEXT() => instance.glPopGroupMarkerEXT();
        
        static unsafe void glPopMatrix() => instance.glPopMatrix();
        
        static unsafe void glPopName() => instance.glPopName();
        
        static unsafe void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => instance.glPrimitiveBoundingBox(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        
        static unsafe void glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => instance.glPrimitiveBoundingBoxARB(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        
        static unsafe void glPrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => instance.glPrimitiveBoundingBoxEXT(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        
        static unsafe void glPrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => instance.glPrimitiveBoundingBoxOES(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
        
        static unsafe void glPrimitiveRestartIndex(uint index) => instance.glPrimitiveRestartIndex(index);
        
        static unsafe void glPrimitiveRestartIndexNV(uint index) => instance.glPrimitiveRestartIndexNV(index);
        
        static unsafe void glPrimitiveRestartNV() => instance.glPrimitiveRestartNV();
        
        static unsafe void glPrioritizeTextures(uint n, uint * textures, float * priorities) => instance.glPrioritizeTextures(n, textures, priorities);
        
        static unsafe void glPrioritizeTexturesEXT(uint n, uint * textures, float * priorities) => instance.glPrioritizeTexturesEXT(n, textures, priorities);
        
        static unsafe void glPrioritizeTexturesxOES(uint n, uint * textures, int * priorities) => instance.glPrioritizeTexturesxOES(n, textures, priorities);
        
        static unsafe void glProgramBufferParametersIivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, uint count, int * PARAMS) => instance.glProgramBufferParametersIivNV(target, bindingIndex, wordIndex, count, PARAMS);
        
        static unsafe void glProgramBufferParametersIuivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, uint count, uint * PARAMS) => instance.glProgramBufferParametersIuivNV(target, bindingIndex, wordIndex, count, PARAMS);
        
        static unsafe void glProgramBufferParametersfvNV(ProgramTarget target, uint bindingIndex, uint wordIndex, uint count, float * PARAMS) => instance.glProgramBufferParametersfvNV(target, bindingIndex, wordIndex, count, PARAMS);
        
        static unsafe void glProgramEnvParameter4dARB(ProgramTargetARB target, uint index, double x, double y, double z, double w) => instance.glProgramEnvParameter4dARB(target, index, x, y, z, w);
        
        static unsafe void glProgramEnvParameter4dvARB(ProgramTargetARB target, uint index, double * PARAMS) => instance.glProgramEnvParameter4dvARB(target, index, PARAMS);
        
        static unsafe void glProgramEnvParameter4fARB(ProgramTargetARB target, uint index, float x, float y, float z, float w) => instance.glProgramEnvParameter4fARB(target, index, x, y, z, w);
        
        static unsafe void glProgramEnvParameter4fvARB(ProgramTargetARB target, uint index, float * PARAMS) => instance.glProgramEnvParameter4fvARB(target, index, PARAMS);
        
        static unsafe void glProgramEnvParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w) => instance.glProgramEnvParameterI4iNV(target, index, x, y, z, w);
        
        static unsafe void glProgramEnvParameterI4ivNV(ProgramTarget target, uint index, int * PARAMS) => instance.glProgramEnvParameterI4ivNV(target, index, PARAMS);
        
        static unsafe void glProgramEnvParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w) => instance.glProgramEnvParameterI4uiNV(target, index, x, y, z, w);
        
        static unsafe void glProgramEnvParameterI4uivNV(ProgramTarget target, uint index, uint * PARAMS) => instance.glProgramEnvParameterI4uivNV(target, index, PARAMS);
        
        static unsafe void glProgramEnvParameters4fvEXT(ProgramTargetARB target, uint index, uint count, float * PARAMS) => instance.glProgramEnvParameters4fvEXT(target, index, count, PARAMS);
        
        static unsafe void glProgramEnvParametersI4ivNV(ProgramTarget target, uint index, uint count, int * PARAMS) => instance.glProgramEnvParametersI4ivNV(target, index, count, PARAMS);
        
        static unsafe void glProgramEnvParametersI4uivNV(ProgramTarget target, uint index, uint count, uint * PARAMS) => instance.glProgramEnvParametersI4uivNV(target, index, count, PARAMS);
        
        static unsafe void glProgramLocalParameter4dARB(ProgramTargetARB target, uint index, double x, double y, double z, double w) => instance.glProgramLocalParameter4dARB(target, index, x, y, z, w);
        
        static unsafe void glProgramLocalParameter4dvARB(ProgramTargetARB target, uint index, double * PARAMS) => instance.glProgramLocalParameter4dvARB(target, index, PARAMS);
        
        static unsafe void glProgramLocalParameter4fARB(ProgramTargetARB target, uint index, float x, float y, float z, float w) => instance.glProgramLocalParameter4fARB(target, index, x, y, z, w);
        
        static unsafe void glProgramLocalParameter4fvARB(ProgramTargetARB target, uint index, float * PARAMS) => instance.glProgramLocalParameter4fvARB(target, index, PARAMS);
        
        static unsafe void glProgramLocalParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w) => instance.glProgramLocalParameterI4iNV(target, index, x, y, z, w);
        
        static unsafe void glProgramLocalParameterI4ivNV(ProgramTarget target, uint index, int * PARAMS) => instance.glProgramLocalParameterI4ivNV(target, index, PARAMS);
        
        static unsafe void glProgramLocalParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w) => instance.glProgramLocalParameterI4uiNV(target, index, x, y, z, w);
        
        static unsafe void glProgramLocalParameterI4uivNV(ProgramTarget target, uint index, uint * PARAMS) => instance.glProgramLocalParameterI4uivNV(target, index, PARAMS);
        
        static unsafe void glProgramLocalParameters4fvEXT(ProgramTargetARB target, uint index, uint count, float * PARAMS) => instance.glProgramLocalParameters4fvEXT(target, index, count, PARAMS);
        
        static unsafe void glProgramLocalParametersI4ivNV(ProgramTarget target, uint index, uint count, int * PARAMS) => instance.glProgramLocalParametersI4ivNV(target, index, count, PARAMS);
        
        static unsafe void glProgramLocalParametersI4uivNV(ProgramTarget target, uint index, uint count, uint * PARAMS) => instance.glProgramLocalParametersI4uivNV(target, index, count, PARAMS);
        
        static unsafe void glProgramNamedParameter4dNV(uint id, uint len, byte * name, double x, double y, double z, double w) => instance.glProgramNamedParameter4dNV(id, len, name, x, y, z, w);
        
        static unsafe void glProgramNamedParameter4dvNV(uint id, uint len, byte * name, double * v) => instance.glProgramNamedParameter4dvNV(id, len, name, v);
        
        static unsafe void glProgramNamedParameter4fNV(uint id, uint len, byte * name, float x, float y, float z, float w) => instance.glProgramNamedParameter4fNV(id, len, name, x, y, z, w);
        
        static unsafe void glProgramNamedParameter4fvNV(uint id, uint len, byte * name, float * v) => instance.glProgramNamedParameter4fvNV(id, len, name, v);
        
        static unsafe void glProgramParameter4dNV(VertexAttribEnumNV target, uint index, double x, double y, double z, double w) => instance.glProgramParameter4dNV(target, index, x, y, z, w);
        
        static unsafe void glProgramParameter4dvNV(VertexAttribEnumNV target, uint index, double * v) => instance.glProgramParameter4dvNV(target, index, v);
        
        static unsafe void glProgramParameter4fNV(VertexAttribEnumNV target, uint index, float x, float y, float z, float w) => instance.glProgramParameter4fNV(target, index, x, y, z, w);
        
        static unsafe void glProgramParameter4fvNV(VertexAttribEnumNV target, uint index, float * v) => instance.glProgramParameter4fvNV(target, index, v);
        
        static unsafe void glProgramParameteri(uint program, ProgramParameterPName pname, int value) => instance.glProgramParameteri(program, pname, value);
        
        static unsafe void glProgramParameteriARB(uint program, ProgramParameterPName pname, int value) => instance.glProgramParameteriARB(program, pname, value);
        
        static unsafe void glProgramParameteriEXT(uint program, ProgramParameterPName pname, int value) => instance.glProgramParameteriEXT(program, pname, value);
        
        static unsafe void glProgramParameters4dvNV(VertexAttribEnumNV target, uint index, uint count, double * v) => instance.glProgramParameters4dvNV(target, index, count, v);
        
        static unsafe void glProgramParameters4fvNV(VertexAttribEnumNV target, uint index, uint count, float * v) => instance.glProgramParameters4fvNV(target, index, count, v);
        
        static unsafe void glProgramStringARB(ProgramTargetARB target, ProgramFormatARB format, uint len, void * STRING) => instance.glProgramStringARB(target, format, len, STRING);
        
        static unsafe void glProgramUniform1d(uint program, int location, double v0) => instance.glProgramUniform1d(program, location, v0);
        
        static unsafe void glProgramUniform1dEXT(uint program, int location, double x) => instance.glProgramUniform1dEXT(program, location, x);
        
        static unsafe void glProgramUniform1dv(uint program, int location, uint count, double * value) => instance.glProgramUniform1dv(program, location, count, value);
        
        static unsafe void glProgramUniform1dvEXT(uint program, int location, uint count, double * value) => instance.glProgramUniform1dvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform1f(uint program, int location, float v0) => instance.glProgramUniform1f(program, location, v0);
        
        static unsafe void glProgramUniform1fEXT(uint program, int location, float v0) => instance.glProgramUniform1fEXT(program, location, v0);
        
        static unsafe void glProgramUniform1fv(uint program, int location, uint count, float * value) => instance.glProgramUniform1fv(program, location, count, value);
        
        static unsafe void glProgramUniform1fvEXT(uint program, int location, uint count, float * value) => instance.glProgramUniform1fvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform1i(uint program, int location, int v0) => instance.glProgramUniform1i(program, location, v0);
        
        static unsafe void glProgramUniform1i64ARB(uint program, int location, long x) => instance.glProgramUniform1i64ARB(program, location, x);
        
        static unsafe void glProgramUniform1i64NV(uint program, int location, long x) => instance.glProgramUniform1i64NV(program, location, x);
        
        static unsafe void glProgramUniform1i64vARB(uint program, int location, uint count, long * value) => instance.glProgramUniform1i64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform1i64vNV(uint program, int location, uint count, long * value) => instance.glProgramUniform1i64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform1iEXT(uint program, int location, int v0) => instance.glProgramUniform1iEXT(program, location, v0);
        
        static unsafe void glProgramUniform1iv(uint program, int location, uint count, int * value) => instance.glProgramUniform1iv(program, location, count, value);
        
        static unsafe void glProgramUniform1ivEXT(uint program, int location, uint count, int * value) => instance.glProgramUniform1ivEXT(program, location, count, value);
        
        static unsafe void glProgramUniform1ui(uint program, int location, uint v0) => instance.glProgramUniform1ui(program, location, v0);
        
        static unsafe void glProgramUniform1ui64ARB(uint program, int location, ulong x) => instance.glProgramUniform1ui64ARB(program, location, x);
        
        static unsafe void glProgramUniform1ui64NV(uint program, int location, ulong x) => instance.glProgramUniform1ui64NV(program, location, x);
        
        static unsafe void glProgramUniform1ui64vARB(uint program, int location, uint count, ulong * value) => instance.glProgramUniform1ui64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform1ui64vNV(uint program, int location, uint count, ulong * value) => instance.glProgramUniform1ui64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform1uiEXT(uint program, int location, uint v0) => instance.glProgramUniform1uiEXT(program, location, v0);
        
        static unsafe void glProgramUniform1uiv(uint program, int location, uint count, uint * value) => instance.glProgramUniform1uiv(program, location, count, value);
        
        static unsafe void glProgramUniform1uivEXT(uint program, int location, uint count, uint * value) => instance.glProgramUniform1uivEXT(program, location, count, value);
        
        static unsafe void glProgramUniform2d(uint program, int location, double v0, double v1) => instance.glProgramUniform2d(program, location, v0, v1);
        
        static unsafe void glProgramUniform2dEXT(uint program, int location, double x, double y) => instance.glProgramUniform2dEXT(program, location, x, y);
        
        static unsafe void glProgramUniform2dv(uint program, int location, uint count, double * value) => instance.glProgramUniform2dv(program, location, count, value);
        
        static unsafe void glProgramUniform2dvEXT(uint program, int location, uint count, double * value) => instance.glProgramUniform2dvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform2f(uint program, int location, float v0, float v1) => instance.glProgramUniform2f(program, location, v0, v1);
        
        static unsafe void glProgramUniform2fEXT(uint program, int location, float v0, float v1) => instance.glProgramUniform2fEXT(program, location, v0, v1);
        
        static unsafe void glProgramUniform2fv(uint program, int location, uint count, float * value) => instance.glProgramUniform2fv(program, location, count, value);
        
        static unsafe void glProgramUniform2fvEXT(uint program, int location, uint count, float * value) => instance.glProgramUniform2fvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform2i(uint program, int location, int v0, int v1) => instance.glProgramUniform2i(program, location, v0, v1);
        
        static unsafe void glProgramUniform2i64ARB(uint program, int location, long x, long y) => instance.glProgramUniform2i64ARB(program, location, x, y);
        
        static unsafe void glProgramUniform2i64NV(uint program, int location, long x, long y) => instance.glProgramUniform2i64NV(program, location, x, y);
        
        static unsafe void glProgramUniform2i64vARB(uint program, int location, uint count, long * value) => instance.glProgramUniform2i64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform2i64vNV(uint program, int location, uint count, long * value) => instance.glProgramUniform2i64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform2iEXT(uint program, int location, int v0, int v1) => instance.glProgramUniform2iEXT(program, location, v0, v1);
        
        static unsafe void glProgramUniform2iv(uint program, int location, uint count, int * value) => instance.glProgramUniform2iv(program, location, count, value);
        
        static unsafe void glProgramUniform2ivEXT(uint program, int location, uint count, int * value) => instance.glProgramUniform2ivEXT(program, location, count, value);
        
        static unsafe void glProgramUniform2ui(uint program, int location, uint v0, uint v1) => instance.glProgramUniform2ui(program, location, v0, v1);
        
        static unsafe void glProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y) => instance.glProgramUniform2ui64ARB(program, location, x, y);
        
        static unsafe void glProgramUniform2ui64NV(uint program, int location, ulong x, ulong y) => instance.glProgramUniform2ui64NV(program, location, x, y);
        
        static unsafe void glProgramUniform2ui64vARB(uint program, int location, uint count, ulong * value) => instance.glProgramUniform2ui64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform2ui64vNV(uint program, int location, uint count, ulong * value) => instance.glProgramUniform2ui64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform2uiEXT(uint program, int location, uint v0, uint v1) => instance.glProgramUniform2uiEXT(program, location, v0, v1);
        
        static unsafe void glProgramUniform2uiv(uint program, int location, uint count, uint * value) => instance.glProgramUniform2uiv(program, location, count, value);
        
        static unsafe void glProgramUniform2uivEXT(uint program, int location, uint count, uint * value) => instance.glProgramUniform2uivEXT(program, location, count, value);
        
        static unsafe void glProgramUniform3d(uint program, int location, double v0, double v1, double v2) => instance.glProgramUniform3d(program, location, v0, v1, v2);
        
        static unsafe void glProgramUniform3dEXT(uint program, int location, double x, double y, double z) => instance.glProgramUniform3dEXT(program, location, x, y, z);
        
        static unsafe void glProgramUniform3dv(uint program, int location, uint count, double * value) => instance.glProgramUniform3dv(program, location, count, value);
        
        static unsafe void glProgramUniform3dvEXT(uint program, int location, uint count, double * value) => instance.glProgramUniform3dvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform3f(uint program, int location, float v0, float v1, float v2) => instance.glProgramUniform3f(program, location, v0, v1, v2);
        
        static unsafe void glProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2) => instance.glProgramUniform3fEXT(program, location, v0, v1, v2);
        
        static unsafe void glProgramUniform3fv(uint program, int location, uint count, float * value) => instance.glProgramUniform3fv(program, location, count, value);
        
        static unsafe void glProgramUniform3fvEXT(uint program, int location, uint count, float * value) => instance.glProgramUniform3fvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform3i(uint program, int location, int v0, int v1, int v2) => instance.glProgramUniform3i(program, location, v0, v1, v2);
        
        static unsafe void glProgramUniform3i64ARB(uint program, int location, long x, long y, long z) => instance.glProgramUniform3i64ARB(program, location, x, y, z);
        
        static unsafe void glProgramUniform3i64NV(uint program, int location, long x, long y, long z) => instance.glProgramUniform3i64NV(program, location, x, y, z);
        
        static unsafe void glProgramUniform3i64vARB(uint program, int location, uint count, long * value) => instance.glProgramUniform3i64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform3i64vNV(uint program, int location, uint count, long * value) => instance.glProgramUniform3i64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2) => instance.glProgramUniform3iEXT(program, location, v0, v1, v2);
        
        static unsafe void glProgramUniform3iv(uint program, int location, uint count, int * value) => instance.glProgramUniform3iv(program, location, count, value);
        
        static unsafe void glProgramUniform3ivEXT(uint program, int location, uint count, int * value) => instance.glProgramUniform3ivEXT(program, location, count, value);
        
        static unsafe void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) => instance.glProgramUniform3ui(program, location, v0, v1, v2);
        
        static unsafe void glProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z) => instance.glProgramUniform3ui64ARB(program, location, x, y, z);
        
        static unsafe void glProgramUniform3ui64NV(uint program, int location, ulong x, ulong y, ulong z) => instance.glProgramUniform3ui64NV(program, location, x, y, z);
        
        static unsafe void glProgramUniform3ui64vARB(uint program, int location, uint count, ulong * value) => instance.glProgramUniform3ui64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform3ui64vNV(uint program, int location, uint count, ulong * value) => instance.glProgramUniform3ui64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2) => instance.glProgramUniform3uiEXT(program, location, v0, v1, v2);
        
        static unsafe void glProgramUniform3uiv(uint program, int location, uint count, uint * value) => instance.glProgramUniform3uiv(program, location, count, value);
        
        static unsafe void glProgramUniform3uivEXT(uint program, int location, uint count, uint * value) => instance.glProgramUniform3uivEXT(program, location, count, value);
        
        static unsafe void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) => instance.glProgramUniform4d(program, location, v0, v1, v2, v3);
        
        static unsafe void glProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w) => instance.glProgramUniform4dEXT(program, location, x, y, z, w);
        
        static unsafe void glProgramUniform4dv(uint program, int location, uint count, double * value) => instance.glProgramUniform4dv(program, location, count, value);
        
        static unsafe void glProgramUniform4dvEXT(uint program, int location, uint count, double * value) => instance.glProgramUniform4dvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) => instance.glProgramUniform4f(program, location, v0, v1, v2, v3);
        
        static unsafe void glProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3) => instance.glProgramUniform4fEXT(program, location, v0, v1, v2, v3);
        
        static unsafe void glProgramUniform4fv(uint program, int location, uint count, float * value) => instance.glProgramUniform4fv(program, location, count, value);
        
        static unsafe void glProgramUniform4fvEXT(uint program, int location, uint count, float * value) => instance.glProgramUniform4fvEXT(program, location, count, value);
        
        static unsafe void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) => instance.glProgramUniform4i(program, location, v0, v1, v2, v3);
        
        static unsafe void glProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w) => instance.glProgramUniform4i64ARB(program, location, x, y, z, w);
        
        static unsafe void glProgramUniform4i64NV(uint program, int location, long x, long y, long z, long w) => instance.glProgramUniform4i64NV(program, location, x, y, z, w);
        
        static unsafe void glProgramUniform4i64vARB(uint program, int location, uint count, long * value) => instance.glProgramUniform4i64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform4i64vNV(uint program, int location, uint count, long * value) => instance.glProgramUniform4i64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3) => instance.glProgramUniform4iEXT(program, location, v0, v1, v2, v3);
        
        static unsafe void glProgramUniform4iv(uint program, int location, uint count, int * value) => instance.glProgramUniform4iv(program, location, count, value);
        
        static unsafe void glProgramUniform4ivEXT(uint program, int location, uint count, int * value) => instance.glProgramUniform4ivEXT(program, location, count, value);
        
        static unsafe void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) => instance.glProgramUniform4ui(program, location, v0, v1, v2, v3);
        
        static unsafe void glProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w) => instance.glProgramUniform4ui64ARB(program, location, x, y, z, w);
        
        static unsafe void glProgramUniform4ui64NV(uint program, int location, ulong x, ulong y, ulong z, ulong w) => instance.glProgramUniform4ui64NV(program, location, x, y, z, w);
        
        static unsafe void glProgramUniform4ui64vARB(uint program, int location, uint count, ulong * value) => instance.glProgramUniform4ui64vARB(program, location, count, value);
        
        static unsafe void glProgramUniform4ui64vNV(uint program, int location, uint count, ulong * value) => instance.glProgramUniform4ui64vNV(program, location, count, value);
        
        static unsafe void glProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3) => instance.glProgramUniform4uiEXT(program, location, v0, v1, v2, v3);
        
        static unsafe void glProgramUniform4uiv(uint program, int location, uint count, uint * value) => instance.glProgramUniform4uiv(program, location, count, value);
        
        static unsafe void glProgramUniform4uivEXT(uint program, int location, uint count, uint * value) => instance.glProgramUniform4uivEXT(program, location, count, value);
        
        static unsafe void glProgramUniformHandleui64ARB(uint program, int location, ulong value) => instance.glProgramUniformHandleui64ARB(program, location, value);
        
        static unsafe void glProgramUniformHandleui64IMG(uint program, int location, ulong value) => instance.glProgramUniformHandleui64IMG(program, location, value);
        
        static unsafe void glProgramUniformHandleui64NV(uint program, int location, ulong value) => instance.glProgramUniformHandleui64NV(program, location, value);
        
        static unsafe void glProgramUniformHandleui64vARB(uint program, int location, uint count, ulong * values) => instance.glProgramUniformHandleui64vARB(program, location, count, values);
        
        static unsafe void glProgramUniformHandleui64vIMG(uint program, int location, uint count, ulong * values) => instance.glProgramUniformHandleui64vIMG(program, location, count, values);
        
        static unsafe void glProgramUniformHandleui64vNV(uint program, int location, uint count, ulong * values) => instance.glProgramUniformHandleui64vNV(program, location, count, values);
        
        static unsafe void glProgramUniformMatrix2dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix2dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix2dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix2fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix2fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x3dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix2x3dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x3dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix2x3dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x3fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x3fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix2x3fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x4dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix2x4dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x4dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix2x4dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x4fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix2x4fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix2x4fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix3dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix3dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix3fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix3fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x2dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix3x2dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x2dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix3x2dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x2fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x2fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix3x2fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x4dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix3x4dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x4dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix3x4dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x4fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix3x4fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix3x4fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix4dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix4dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix4fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix4fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x2dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix4x2dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x2dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix4x2dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x2fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x2fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix4x2fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x3dv(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix4x3dv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x3dvEXT(uint program, int location, uint count, bool transpose, double * value) => instance.glProgramUniformMatrix4x3dvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x3fv(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformMatrix4x3fvEXT(uint program, int location, uint count, bool transpose, float * value) => instance.glProgramUniformMatrix4x3fvEXT(program, location, count, transpose, value);
        
        static unsafe void glProgramUniformui64NV(uint program, int location, ulong value) => instance.glProgramUniformui64NV(program, location, value);
        
        static unsafe void glProgramUniformui64vNV(uint program, int location, uint count, ulong * value) => instance.glProgramUniformui64vNV(program, location, count, value);
        
        static unsafe void glProgramVertexLimitNV(ProgramTarget target, int limit) => instance.glProgramVertexLimitNV(target, limit);
        
        static unsafe void glProvokingVertex(VertexProvokingMode mode) => instance.glProvokingVertex(mode);
        
        static unsafe void glProvokingVertexEXT(VertexProvokingMode mode) => instance.glProvokingVertexEXT(mode);
        
        static unsafe void glPushAttrib(uint mask) => instance.glPushAttrib(mask);
        
        static unsafe void glPushClientAttrib(uint mask) => instance.glPushClientAttrib(mask);
        
        static unsafe void glPushClientAttribDefaultEXT(uint mask) => instance.glPushClientAttribDefaultEXT(mask);
        
        static unsafe void glPushDebugGroup(DebugSource source, uint id, uint length, char * message) => instance.glPushDebugGroup(source, id, length, message);
        
        static unsafe void glPushDebugGroupKHR(DebugSource source, uint id, uint length, char * message) => instance.glPushDebugGroupKHR(source, id, length, message);
        
        static unsafe void glPushGroupMarkerEXT(uint length, char * marker) => instance.glPushGroupMarkerEXT(length, marker);
        
        static unsafe void glPushMatrix() => instance.glPushMatrix();
        
        static unsafe void glPushName(uint name) => instance.glPushName(name);
        
        static unsafe void glQueryCounter(uint id, QueryCounterTarget target) => instance.glQueryCounter(id, target);
        
        static unsafe void glQueryCounterEXT(uint id, QueryCounterTarget target) => instance.glQueryCounterEXT(id, target);
        
        static unsafe uint glQueryMatrixxOES(int * mantissa, int * exponent) => instance.glQueryMatrixxOES(mantissa, exponent);
        
        static unsafe void glQueryResourceTagNV(int tagId, char * tagString) => instance.glQueryResourceTagNV(tagId, tagString);
        
        static unsafe void glRasterPos2d(double x, double y) => instance.glRasterPos2d(x, y);
        
        static unsafe void glRasterPos2dv(double * v) => instance.glRasterPos2dv(v);
        
        static unsafe void glRasterPos2f(float x, float y) => instance.glRasterPos2f(x, y);
        
        static unsafe void glRasterPos2fv(float * v) => instance.glRasterPos2fv(v);
        
        static unsafe void glRasterPos2i(int x, int y) => instance.glRasterPos2i(x, y);
        
        static unsafe void glRasterPos2iv(int * v) => instance.glRasterPos2iv(v);
        
        static unsafe void glRasterPos2s(short x, short y) => instance.glRasterPos2s(x, y);
        
        static unsafe void glRasterPos2sv(short * v) => instance.glRasterPos2sv(v);
        
        static unsafe void glRasterPos2xOES(int x, int y) => instance.glRasterPos2xOES(x, y);
        
        static unsafe void glRasterPos2xvOES(int * coords) => instance.glRasterPos2xvOES(coords);
        
        static unsafe void glRasterPos3d(double x, double y, double z) => instance.glRasterPos3d(x, y, z);
        
        static unsafe void glRasterPos3dv(double * v) => instance.glRasterPos3dv(v);
        
        static unsafe void glRasterPos3f(float x, float y, float z) => instance.glRasterPos3f(x, y, z);
        
        static unsafe void glRasterPos3fv(float * v) => instance.glRasterPos3fv(v);
        
        static unsafe void glRasterPos3i(int x, int y, int z) => instance.glRasterPos3i(x, y, z);
        
        static unsafe void glRasterPos3iv(int * v) => instance.glRasterPos3iv(v);
        
        static unsafe void glRasterPos3s(short x, short y, short z) => instance.glRasterPos3s(x, y, z);
        
        static unsafe void glRasterPos3sv(short * v) => instance.glRasterPos3sv(v);
        
        static unsafe void glRasterPos3xOES(int x, int y, int z) => instance.glRasterPos3xOES(x, y, z);
        
        static unsafe void glRasterPos3xvOES(int * coords) => instance.glRasterPos3xvOES(coords);
        
        static unsafe void glRasterPos4d(double x, double y, double z, double w) => instance.glRasterPos4d(x, y, z, w);
        
        static unsafe void glRasterPos4dv(double * v) => instance.glRasterPos4dv(v);
        
        static unsafe void glRasterPos4f(float x, float y, float z, float w) => instance.glRasterPos4f(x, y, z, w);
        
        static unsafe void glRasterPos4fv(float * v) => instance.glRasterPos4fv(v);
        
        static unsafe void glRasterPos4i(int x, int y, int z, int w) => instance.glRasterPos4i(x, y, z, w);
        
        static unsafe void glRasterPos4iv(int * v) => instance.glRasterPos4iv(v);
        
        static unsafe void glRasterPos4s(short x, short y, short z, short w) => instance.glRasterPos4s(x, y, z, w);
        
        static unsafe void glRasterPos4sv(short * v) => instance.glRasterPos4sv(v);
        
        static unsafe void glRasterPos4xOES(int x, int y, int z, int w) => instance.glRasterPos4xOES(x, y, z, w);
        
        static unsafe void glRasterPos4xvOES(int * coords) => instance.glRasterPos4xvOES(coords);
        
        static unsafe void glRasterSamplesEXT(uint samples, bool fixedsamplelocations) => instance.glRasterSamplesEXT(samples, fixedsamplelocations);
        
        static unsafe void glReadBuffer(ReadBufferMode src) => instance.glReadBuffer(src);
        
        static unsafe void glReadBufferIndexedEXT(ReadBufferMode src, int index) => instance.glReadBufferIndexedEXT(src, index);
        
        static unsafe void glReadInstrumentsSGIX(int marker) => instance.glReadInstrumentsSGIX(marker);
        
        static unsafe void glReadPixels(int x, int y, uint width, uint height, PixelFormat format, PixelType type, void * pixels) => instance.glReadPixels(x, y, width, height, format, type, pixels);
        
        static unsafe void glReadnPixels(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data) => instance.glReadnPixels(x, y, width, height, format, type, bufSize, data);
        
        static unsafe void glReadnPixelsARB(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data) => instance.glReadnPixelsARB(x, y, width, height, format, type, bufSize, data);
        
        static unsafe void glReadnPixelsEXT(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data) => instance.glReadnPixelsEXT(x, y, width, height, format, type, bufSize, data);
        
        static unsafe void glReadnPixelsKHR(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data) => instance.glReadnPixelsKHR(x, y, width, height, format, type, bufSize, data);
        
        static unsafe bool glReleaseKeyedMutexWin32EXT(uint memory, ulong key) => instance.glReleaseKeyedMutexWin32EXT(memory, key);
        
        static unsafe void glRectd(double x1, double y1, double x2, double y2) => instance.glRectd(x1, y1, x2, y2);
        
        static unsafe void glRectdv(double * v1, double * v2) => instance.glRectdv(v1, v2);
        
        static unsafe void glRectf(float x1, float y1, float x2, float y2) => instance.glRectf(x1, y1, x2, y2);
        
        static unsafe void glRectfv(float * v1, float * v2) => instance.glRectfv(v1, v2);
        
        static unsafe void glRecti(int x1, int y1, int x2, int y2) => instance.glRecti(x1, y1, x2, y2);
        
        static unsafe void glRectiv(int * v1, int * v2) => instance.glRectiv(v1, v2);
        
        static unsafe void glRects(short x1, short y1, short x2, short y2) => instance.glRects(x1, y1, x2, y2);
        
        static unsafe void glRectsv(short * v1, short * v2) => instance.glRectsv(v1, v2);
        
        static unsafe void glRectxOES(int x1, int y1, int x2, int y2) => instance.glRectxOES(x1, y1, x2, y2);
        
        static unsafe void glRectxvOES(int * v1, int * v2) => instance.glRectxvOES(v1, v2);
        
        static unsafe void glReferencePlaneSGIX(double * equation) => instance.glReferencePlaneSGIX(equation);
        
        static unsafe void glReleaseShaderCompiler() => instance.glReleaseShaderCompiler();
        
        static unsafe void glRenderGpuMaskNV(uint mask) => instance.glRenderGpuMaskNV(mask);
        
        static unsafe int glRenderMode(RenderingMode mode) => instance.glRenderMode(mode);
        
        static unsafe void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorage(target, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageEXT(RenderbufferTarget target, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageEXT(target, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisample(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisampleANGLE(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisampleANGLE(target, samples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisampleAPPLE(target, samples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, uint samples, uint storageSamples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisampleAdvancedAMD(target, samples, storageSamples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisampleCoverageNV(RenderbufferTarget target, uint coverageSamples, uint colorSamples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisampleCoverageNV(target, coverageSamples, colorSamples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisampleEXT(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisampleIMG(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisampleIMG(target, samples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageMultisampleNV(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageMultisampleNV(target, samples, internalformat, width, height);
        
        static unsafe void glRenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, uint width, uint height) => instance.glRenderbufferStorageOES(target, internalformat, width, height);
        
        static unsafe void glReplacementCodePointerSUN(ReplacementCodeTypeSUN type, uint stride, void * * pointer) => instance.glReplacementCodePointerSUN(type, stride, pointer);
        
        static unsafe void glReplacementCodeubSUN(byte code) => instance.glReplacementCodeubSUN(code);
        
        static unsafe void glReplacementCodeubvSUN(byte * code) => instance.glReplacementCodeubvSUN(code);
        
        static unsafe void glReplacementCodeuiColor3fVertex3fSUN(uint rc, float r, float g, float b, float x, float y, float z) => instance.glReplacementCodeuiColor3fVertex3fSUN(rc, r, g, b, x, y, z);
        
        static unsafe void glReplacementCodeuiColor3fVertex3fvSUN(uint * rc, float * c, float * v) => instance.glReplacementCodeuiColor3fVertex3fvSUN(rc, c, v);
        
        static unsafe void glReplacementCodeuiColor4fNormal3fVertex3fSUN(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => instance.glReplacementCodeuiColor4fNormal3fVertex3fSUN(rc, r, g, b, a, nx, ny, nz, x, y, z);
        
        static unsafe void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint * rc, float * c, float * n, float * v) => instance.glReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n, v);
        
        static unsafe void glReplacementCodeuiColor4ubVertex3fSUN(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z) => instance.glReplacementCodeuiColor4ubVertex3fSUN(rc, r, g, b, a, x, y, z);
        
        static unsafe void glReplacementCodeuiColor4ubVertex3fvSUN(uint * rc, byte * c, float * v) => instance.glReplacementCodeuiColor4ubVertex3fvSUN(rc, c, v);
        
        static unsafe void glReplacementCodeuiNormal3fVertex3fSUN(uint rc, float nx, float ny, float nz, float x, float y, float z) => instance.glReplacementCodeuiNormal3fVertex3fSUN(rc, nx, ny, nz, x, y, z);
        
        static unsafe void glReplacementCodeuiNormal3fVertex3fvSUN(uint * rc, float * n, float * v) => instance.glReplacementCodeuiNormal3fVertex3fvSUN(rc, n, v);
        
        static unsafe void glReplacementCodeuiSUN(uint code) => instance.glReplacementCodeuiSUN(code);
        
        static unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => instance.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
        
        static unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint * rc, float * tc, float * c, float * n, float * v) => instance.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n, v);
        
        static unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z) => instance.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(rc, s, t, nx, ny, nz, x, y, z);
        
        static unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint * rc, float * tc, float * n, float * v) => instance.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n, v);
        
        static unsafe void glReplacementCodeuiTexCoord2fVertex3fSUN(uint rc, float s, float t, float x, float y, float z) => instance.glReplacementCodeuiTexCoord2fVertex3fSUN(rc, s, t, x, y, z);
        
        static unsafe void glReplacementCodeuiTexCoord2fVertex3fvSUN(uint * rc, float * tc, float * v) => instance.glReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc, v);
        
        static unsafe void glReplacementCodeuiVertex3fSUN(uint rc, float x, float y, float z) => instance.glReplacementCodeuiVertex3fSUN(rc, x, y, z);
        
        static unsafe void glReplacementCodeuiVertex3fvSUN(uint * rc, float * v) => instance.glReplacementCodeuiVertex3fvSUN(rc, v);
        
        static unsafe void glReplacementCodeuivSUN(uint * code) => instance.glReplacementCodeuivSUN(code);
        
        static unsafe void glReplacementCodeusSUN(ushort code) => instance.glReplacementCodeusSUN(code);
        
        static unsafe void glReplacementCodeusvSUN(ushort * code) => instance.glReplacementCodeusvSUN(code);
        
        static unsafe void glRequestResidentProgramsNV(uint n, uint * programs) => instance.glRequestResidentProgramsNV(n, programs);
        
        static unsafe void glResetHistogram(HistogramTargetEXT target) => instance.glResetHistogram(target);
        
        static unsafe void glResetHistogramEXT(HistogramTargetEXT target) => instance.glResetHistogramEXT(target);
        
        static unsafe void glResetMinmax(MinmaxTargetEXT target) => instance.glResetMinmax(target);
        
        static unsafe void glResetMinmaxEXT(MinmaxTargetEXT target) => instance.glResetMinmaxEXT(target);
        
        static unsafe void glResizeBuffersMESA() => instance.glResizeBuffersMESA();
        
        static unsafe void glResolveDepthValuesNV() => instance.glResolveDepthValuesNV();
        
        static unsafe void glResolveMultisampleFramebufferAPPLE() => instance.glResolveMultisampleFramebufferAPPLE();
        
        static unsafe void glResumeTransformFeedback() => instance.glResumeTransformFeedback();
        
        static unsafe void glResumeTransformFeedbackNV() => instance.glResumeTransformFeedbackNV();
        
        static unsafe void glRotated(double angle, double x, double y, double z) => instance.glRotated(angle, x, y, z);
        
        static unsafe void glRotatef(float angle, float x, float y, float z) => instance.glRotatef(angle, x, y, z);
        
        static unsafe void glRotatex(int angle, int x, int y, int z) => instance.glRotatex(angle, x, y, z);
        
        static unsafe void glRotatexOES(int angle, int x, int y, int z) => instance.glRotatexOES(angle, x, y, z);
        
        static unsafe void glSampleCoverage(float value, bool invert) => instance.glSampleCoverage(value, invert);
        
        static unsafe void glSampleCoverageARB(float value, bool invert) => instance.glSampleCoverageARB(value, invert);
        
        static unsafe void glSampleCoveragex(int value, bool invert) => instance.glSampleCoveragex(value, invert);
        
        static unsafe void glSampleCoveragexOES(int value, bool invert) => instance.glSampleCoveragexOES(value, invert);
        
        static unsafe void glSampleMapATI(uint dst, uint interp, SwizzleOpATI swizzle) => instance.glSampleMapATI(dst, interp, swizzle);
        
        static unsafe void glSampleMaskEXT(float value, bool invert) => instance.glSampleMaskEXT(value, invert);
        
        static unsafe void glSampleMaskIndexedNV(uint index, uint mask) => instance.glSampleMaskIndexedNV(index, mask);
        
        static unsafe void glSampleMaskSGIS(float value, bool invert) => instance.glSampleMaskSGIS(value, invert);
        
        static unsafe void glSampleMaski(uint maskNumber, uint mask) => instance.glSampleMaski(maskNumber, mask);
        
        static unsafe void glSamplePatternEXT(SamplePatternEXT pattern) => instance.glSamplePatternEXT(pattern);
        
        static unsafe void glSamplePatternSGIS(SamplePatternSGIS pattern) => instance.glSamplePatternSGIS(pattern);
        
        static unsafe void glSamplerParameterIiv(uint sampler, SamplerParameterI pname, int * param) => instance.glSamplerParameterIiv(sampler, pname, param);
        
        static unsafe void glSamplerParameterIivEXT(uint sampler, SamplerParameterI pname, int * param) => instance.glSamplerParameterIivEXT(sampler, pname, param);
        
        static unsafe void glSamplerParameterIivOES(uint sampler, SamplerParameterI pname, int * param) => instance.glSamplerParameterIivOES(sampler, pname, param);
        
        static unsafe void glSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint * param) => instance.glSamplerParameterIuiv(sampler, pname, param);
        
        static unsafe void glSamplerParameterIuivEXT(uint sampler, SamplerParameterI pname, uint * param) => instance.glSamplerParameterIuivEXT(sampler, pname, param);
        
        static unsafe void glSamplerParameterIuivOES(uint sampler, SamplerParameterI pname, uint * param) => instance.glSamplerParameterIuivOES(sampler, pname, param);
        
        static unsafe void glSamplerParameterf(uint sampler, SamplerParameterF pname, float param) => instance.glSamplerParameterf(sampler, pname, param);
        
        static unsafe void glSamplerParameterfv(uint sampler, SamplerParameterF pname, float * param) => instance.glSamplerParameterfv(sampler, pname, param);
        
        static unsafe void glSamplerParameteri(uint sampler, SamplerParameterI pname, int param) => instance.glSamplerParameteri(sampler, pname, param);
        
        static unsafe void glSamplerParameteriv(uint sampler, SamplerParameterI pname, int * param) => instance.glSamplerParameteriv(sampler, pname, param);
        
        static unsafe void glScaled(double x, double y, double z) => instance.glScaled(x, y, z);
        
        static unsafe void glScalef(float x, float y, float z) => instance.glScalef(x, y, z);
        
        static unsafe void glScalex(int x, int y, int z) => instance.glScalex(x, y, z);
        
        static unsafe void glScalexOES(int x, int y, int z) => instance.glScalexOES(x, y, z);
        
        static unsafe void glScissor(int x, int y, uint width, uint height) => instance.glScissor(x, y, width, height);
        
        static unsafe void glScissorArrayv(uint first, uint count, int * v) => instance.glScissorArrayv(first, count, v);
        
        static unsafe void glScissorArrayvNV(uint first, uint count, int * v) => instance.glScissorArrayvNV(first, count, v);
        
        static unsafe void glScissorArrayvOES(uint first, uint count, int * v) => instance.glScissorArrayvOES(first, count, v);
        
        static unsafe void glScissorExclusiveArrayvNV(uint first, uint count, int * v) => instance.glScissorExclusiveArrayvNV(first, count, v);
        
        static unsafe void glScissorExclusiveNV(int x, int y, uint width, uint height) => instance.glScissorExclusiveNV(x, y, width, height);
        
        static unsafe void glScissorIndexed(uint index, int left, int bottom, uint width, uint height) => instance.glScissorIndexed(index, left, bottom, width, height);
        
        static unsafe void glScissorIndexedNV(uint index, int left, int bottom, uint width, uint height) => instance.glScissorIndexedNV(index, left, bottom, width, height);
        
        static unsafe void glScissorIndexedOES(uint index, int left, int bottom, uint width, uint height) => instance.glScissorIndexedOES(index, left, bottom, width, height);
        
        static unsafe void glScissorIndexedv(uint index, int * v) => instance.glScissorIndexedv(index, v);
        
        static unsafe void glScissorIndexedvNV(uint index, int * v) => instance.glScissorIndexedvNV(index, v);
        
        static unsafe void glScissorIndexedvOES(uint index, int * v) => instance.glScissorIndexedvOES(index, v);
        
        static unsafe void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue) => instance.glSecondaryColor3b(red, green, blue);
        
        static unsafe void glSecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue) => instance.glSecondaryColor3bEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3bv(sbyte * v) => instance.glSecondaryColor3bv(v);
        
        static unsafe void glSecondaryColor3bvEXT(sbyte * v) => instance.glSecondaryColor3bvEXT(v);
        
        static unsafe void glSecondaryColor3d(double red, double green, double blue) => instance.glSecondaryColor3d(red, green, blue);
        
        static unsafe void glSecondaryColor3dEXT(double red, double green, double blue) => instance.glSecondaryColor3dEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3dv(double * v) => instance.glSecondaryColor3dv(v);
        
        static unsafe void glSecondaryColor3dvEXT(double * v) => instance.glSecondaryColor3dvEXT(v);
        
        static unsafe void glSecondaryColor3f(float red, float green, float blue) => instance.glSecondaryColor3f(red, green, blue);
        
        static unsafe void glSecondaryColor3fEXT(float red, float green, float blue) => instance.glSecondaryColor3fEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3fv(float * v) => instance.glSecondaryColor3fv(v);
        
        static unsafe void glSecondaryColor3fvEXT(float * v) => instance.glSecondaryColor3fvEXT(v);
        
        static unsafe void glSecondaryColor3hNV(OpenToolkit.Mathematics.Half red, OpenToolkit.Mathematics.Half green, OpenToolkit.Mathematics.Half blue) => instance.glSecondaryColor3hNV(red, green, blue);
        
        static unsafe void glSecondaryColor3hvNV(OpenToolkit.Mathematics.Half * v) => instance.glSecondaryColor3hvNV(v);
        
        static unsafe void glSecondaryColor3i(int red, int green, int blue) => instance.glSecondaryColor3i(red, green, blue);
        
        static unsafe void glSecondaryColor3iEXT(int red, int green, int blue) => instance.glSecondaryColor3iEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3iv(int * v) => instance.glSecondaryColor3iv(v);
        
        static unsafe void glSecondaryColor3ivEXT(int * v) => instance.glSecondaryColor3ivEXT(v);
        
        static unsafe void glSecondaryColor3s(short red, short green, short blue) => instance.glSecondaryColor3s(red, green, blue);
        
        static unsafe void glSecondaryColor3sEXT(short red, short green, short blue) => instance.glSecondaryColor3sEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3sv(short * v) => instance.glSecondaryColor3sv(v);
        
        static unsafe void glSecondaryColor3svEXT(short * v) => instance.glSecondaryColor3svEXT(v);
        
        static unsafe void glSecondaryColor3ub(byte red, byte green, byte blue) => instance.glSecondaryColor3ub(red, green, blue);
        
        static unsafe void glSecondaryColor3ubEXT(byte red, byte green, byte blue) => instance.glSecondaryColor3ubEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3ubv(byte * v) => instance.glSecondaryColor3ubv(v);
        
        static unsafe void glSecondaryColor3ubvEXT(byte * v) => instance.glSecondaryColor3ubvEXT(v);
        
        static unsafe void glSecondaryColor3ui(uint red, uint green, uint blue) => instance.glSecondaryColor3ui(red, green, blue);
        
        static unsafe void glSecondaryColor3uiEXT(uint red, uint green, uint blue) => instance.glSecondaryColor3uiEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3uiv(uint * v) => instance.glSecondaryColor3uiv(v);
        
        static unsafe void glSecondaryColor3uivEXT(uint * v) => instance.glSecondaryColor3uivEXT(v);
        
        static unsafe void glSecondaryColor3us(ushort red, ushort green, ushort blue) => instance.glSecondaryColor3us(red, green, blue);
        
        static unsafe void glSecondaryColor3usEXT(ushort red, ushort green, ushort blue) => instance.glSecondaryColor3usEXT(red, green, blue);
        
        static unsafe void glSecondaryColor3usv(ushort * v) => instance.glSecondaryColor3usv(v);
        
        static unsafe void glSecondaryColor3usvEXT(ushort * v) => instance.glSecondaryColor3usvEXT(v);
        
        static unsafe void glSecondaryColorFormatNV(int size, ColorPointerType type, uint stride) => instance.glSecondaryColorFormatNV(size, type, stride);
        
        static unsafe void glSecondaryColorP3ui(ColorPointerType type, uint color) => instance.glSecondaryColorP3ui(type, color);
        
        static unsafe void glSecondaryColorP3uiv(ColorPointerType type, uint * color) => instance.glSecondaryColorP3uiv(type, color);
        
        static unsafe void glSecondaryColorPointer(int size, ColorPointerType type, uint stride, void * pointer) => instance.glSecondaryColorPointer(size, type, stride, pointer);
        
        static unsafe void glSecondaryColorPointerEXT(int size, ColorPointerType type, uint stride, void * pointer) => instance.glSecondaryColorPointerEXT(size, type, stride, pointer);
        
        static unsafe void glSecondaryColorPointerListIBM(int size, SecondaryColorPointerTypeIBM type, int stride, void * * pointer, int ptrstride) => instance.glSecondaryColorPointerListIBM(size, type, stride, pointer, ptrstride);
        
        static unsafe void glSelectBuffer(uint size, uint * buffer) => instance.glSelectBuffer(size, buffer);
        
        static unsafe void glSelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, uint * counterList) => instance.glSelectPerfMonitorCountersAMD(monitor, enable, group, numCounters, counterList);
        
        static unsafe void glSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong * PARAMS) => instance.glSemaphoreParameterui64vEXT(semaphore, pname, PARAMS);
        
        static unsafe void glSeparableFilter2D(SeparableTargetEXT target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * row, void * column) => instance.glSeparableFilter2D(target, internalformat, width, height, format, type, row, column);
        
        static unsafe void glSeparableFilter2DEXT(SeparableTargetEXT target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * row, void * column) => instance.glSeparableFilter2DEXT(target, internalformat, width, height, format, type, row, column);
        
        static unsafe void glSetFenceAPPLE(uint fence) => instance.glSetFenceAPPLE(fence);
        
        static unsafe void glSetFenceNV(uint fence, FenceConditionNV condition) => instance.glSetFenceNV(fence, condition);
        
        static unsafe void glSetFragmentShaderConstantATI(uint dst, float * value) => instance.glSetFragmentShaderConstantATI(dst, value);
        
        static unsafe void glSetInvariantEXT(uint id, ScalarType type, void * addr) => instance.glSetInvariantEXT(id, type, addr);
        
        static unsafe void glSetLocalConstantEXT(uint id, ScalarType type, void * addr) => instance.glSetLocalConstantEXT(id, type, addr);
        
        static unsafe void glShadeModel(ShadingModel mode) => instance.glShadeModel(mode);
        
        static unsafe void glShaderOp1EXT(VertexShaderOpEXT op, uint res, uint arg1) => instance.glShaderOp1EXT(op, res, arg1);
        
        static unsafe void glShaderOp2EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2) => instance.glShaderOp2EXT(op, res, arg1, arg2);
        
        static unsafe void glShaderOp3EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2, uint arg3) => instance.glShaderOp3EXT(op, res, arg1, arg2, arg3);
        
        static unsafe void glShaderSource(uint shader, uint count, char * * STRING, int * length) => instance.glShaderSource(shader, count, STRING, length);
        
        static unsafe void glShaderSourceARB(uint shaderObj, uint count, char * * STRING, int * length) => instance.glShaderSourceARB(shaderObj, count, STRING, length);
        
        static unsafe void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) => instance.glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
        
        static unsafe void glShadingRateImageBarrierNV(bool synchronize) => instance.glShadingRateImageBarrierNV(synchronize);
        
        static unsafe void glSharpenTexFuncSGIS(TextureTarget target, uint n, float * points) => instance.glSharpenTexFuncSGIS(target, n, points);
        
        static unsafe void glSignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint * buffers, uint numTextureBarriers, uint * textures, TextureLayout * dstLayouts) => instance.glSignalSemaphoreEXT(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);
        
        static unsafe void glSignalSemaphoreui64NVX(uint signalGpu, uint fenceObjectCount, uint * semaphoreArray, ulong * fenceValueArray) => instance.glSignalSemaphoreui64NVX(signalGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
        
        static unsafe void glSpecializeShader(uint shader, char * pEntryPoint, uint numSpecializationConstants, uint * pConstantIndex, uint * pConstantValue) => instance.glSpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
        
        static unsafe void glSpecializeShaderARB(uint shader, char * pEntryPoint, uint numSpecializationConstants, uint * pConstantIndex, uint * pConstantValue) => instance.glSpecializeShaderARB(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
        
        static unsafe void glSpriteParameterfSGIX(SpriteParameterNameSGIX pname, float param) => instance.glSpriteParameterfSGIX(pname, param);
        
        static unsafe void glSpriteParameterfvSGIX(SpriteParameterNameSGIX pname, float * PARAMS) => instance.glSpriteParameterfvSGIX(pname, PARAMS);
        
        static unsafe void glSpriteParameteriSGIX(SpriteParameterNameSGIX pname, int param) => instance.glSpriteParameteriSGIX(pname, param);
        
        static unsafe void glSpriteParameterivSGIX(SpriteParameterNameSGIX pname, int * PARAMS) => instance.glSpriteParameterivSGIX(pname, PARAMS);
        
        static unsafe void glStartInstrumentsSGIX() => instance.glStartInstrumentsSGIX();
        
        static unsafe void glStartTilingQCOM(uint x, uint y, uint width, uint height, uint preserveMask) => instance.glStartTilingQCOM(x, y, width, height, preserveMask);
        
        static unsafe void glStencilClearTagEXT(uint stencilTagBits, uint stencilClearTag) => instance.glStencilClearTagEXT(stencilTagBits, stencilClearTag);
        
        static unsafe void glStencilFillPathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float * transformValues) => instance.glStencilFillPathInstancedNV(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);
        
        static unsafe void glStencilFillPathNV(uint path, PathFillMode fillMode, uint mask) => instance.glStencilFillPathNV(path, fillMode, mask);
        
        static unsafe void glStencilFunc(StencilFunction func, int REF, uint mask) => instance.glStencilFunc(func, REF, mask);
        
        static unsafe void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int REF, uint mask) => instance.glStencilFuncSeparate(face, func, REF, mask);
        
        static unsafe void glStencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, int REF, uint mask) => instance.glStencilFuncSeparateATI(frontfunc, backfunc, REF, mask);
        
        static unsafe void glStencilMask(uint mask) => instance.glStencilMask(mask);
        
        static unsafe void glStencilMaskSeparate(StencilFaceDirection face, uint mask) => instance.glStencilMaskSeparate(face, mask);
        
        static unsafe void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => instance.glStencilOp(fail, zfail, zpass);
        
        static unsafe void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => instance.glStencilOpSeparate(face, sfail, dpfail, dppass);
        
        static unsafe void glStencilOpSeparateATI(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => instance.glStencilOpSeparateATI(face, sfail, dpfail, dppass);
        
        static unsafe void glStencilOpValueAMD(StencilFaceDirection face, uint value) => instance.glStencilOpValueAMD(face, value);
        
        static unsafe void glStencilStrokePathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float * transformValues) => instance.glStencilStrokePathInstancedNV(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);
        
        static unsafe void glStencilStrokePathNV(uint path, int reference, uint mask) => instance.glStencilStrokePathNV(path, reference, mask);
        
        static unsafe void glStopInstrumentsSGIX(int marker) => instance.glStopInstrumentsSGIX(marker);
        
        static unsafe void glStringMarkerGREMEDY(uint len, void * STRING) => instance.glStringMarkerGREMEDY(len, STRING);
        
        static unsafe void glSubpixelPrecisionBiasNV(uint xbits, uint ybits) => instance.glSubpixelPrecisionBiasNV(xbits, ybits);
        
        static unsafe void glSwizzleEXT(uint res, uint IN, VertexShaderCoordOutEXT outX, VertexShaderCoordOutEXT outY, VertexShaderCoordOutEXT outZ, VertexShaderCoordOutEXT outW) => instance.glSwizzleEXT(res, IN, outX, outY, outZ, outW);
        
        static unsafe void glSyncTextureINTEL(uint texture) => instance.glSyncTextureINTEL(texture);
        
        static unsafe void glTagSampleBufferSGIX() => instance.glTagSampleBufferSGIX();
        
        static unsafe void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz) => instance.glTangent3bEXT(tx, ty, tz);
        
        static unsafe void glTangent3bvEXT(sbyte * v) => instance.glTangent3bvEXT(v);
        
        static unsafe void glTangent3dEXT(double tx, double ty, double tz) => instance.glTangent3dEXT(tx, ty, tz);
        
        static unsafe void glTangent3dvEXT(double * v) => instance.glTangent3dvEXT(v);
        
        static unsafe void glTangent3fEXT(float tx, float ty, float tz) => instance.glTangent3fEXT(tx, ty, tz);
        
        static unsafe void glTangent3fvEXT(float * v) => instance.glTangent3fvEXT(v);
        
        static unsafe void glTangent3iEXT(int tx, int ty, int tz) => instance.glTangent3iEXT(tx, ty, tz);
        
        static unsafe void glTangent3ivEXT(int * v) => instance.glTangent3ivEXT(v);
        
        static unsafe void glTangent3sEXT(short tx, short ty, short tz) => instance.glTangent3sEXT(tx, ty, tz);
        
        static unsafe void glTangent3svEXT(short * v) => instance.glTangent3svEXT(v);
        
        static unsafe void glTangentPointerEXT(TangentPointerTypeEXT type, uint stride, void * pointer) => instance.glTangentPointerEXT(type, stride, pointer);
        
        static unsafe void glTbufferMask3DFX(uint mask) => instance.glTbufferMask3DFX(mask);
        
        static unsafe void glTessellationFactorAMD(float factor) => instance.glTessellationFactorAMD(factor);
        
        static unsafe bool glTestFenceAPPLE(uint fence) => instance.glTestFenceAPPLE(fence);
        
        static unsafe bool glTestFenceNV(uint fence) => instance.glTestFenceNV(fence);
        
        static unsafe bool glTestObjectAPPLE(ObjectTypeAPPLE OBJECT, uint name) => instance.glTestObjectAPPLE(OBJECT, name);
        
        static unsafe void glTexAttachMemoryNV(TextureTarget target, uint memory, ulong offset) => instance.glTexAttachMemoryNV(target, memory, offset);
        
        static unsafe void glTexBuffer(TextureTarget target, InternalFormat internalformat, uint buffer) => instance.glTexBuffer(target, internalformat, buffer);
        
        static unsafe void glTexBufferARB(TextureTarget target, InternalFormat internalformat, uint buffer) => instance.glTexBufferARB(target, internalformat, buffer);
        
        static unsafe void glTexBufferEXT(TextureTarget target, InternalFormat internalformat, uint buffer) => instance.glTexBufferEXT(target, internalformat, buffer);
        
        static unsafe void glTexBufferOES(TextureTarget target, InternalFormat internalformat, uint buffer) => instance.glTexBufferOES(target, internalformat, buffer);
        
        static unsafe void glTexBufferRange(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size) => instance.glTexBufferRange(target, internalformat, buffer, offset, size);
        
        static unsafe void glTexBufferRangeEXT(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size) => instance.glTexBufferRangeEXT(target, internalformat, buffer, offset, size);
        
        static unsafe void glTexBufferRangeOES(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size) => instance.glTexBufferRangeOES(target, internalformat, buffer, offset, size);
        
        static unsafe void glTexBumpParameterfvATI(TexBumpParameterATI pname, float * param) => instance.glTexBumpParameterfvATI(pname, param);
        
        static unsafe void glTexBumpParameterivATI(TexBumpParameterATI pname, int * param) => instance.glTexBumpParameterivATI(pname, param);
        
        static unsafe void glTexCoord1bOES(sbyte s) => instance.glTexCoord1bOES(s);
        
        static unsafe void glTexCoord1bvOES(sbyte * coords) => instance.glTexCoord1bvOES(coords);
        
        static unsafe void glTexCoord1d(double s) => instance.glTexCoord1d(s);
        
        static unsafe void glTexCoord1dv(double * v) => instance.glTexCoord1dv(v);
        
        static unsafe void glTexCoord1f(float s) => instance.glTexCoord1f(s);
        
        static unsafe void glTexCoord1fv(float * v) => instance.glTexCoord1fv(v);
        
        static unsafe void glTexCoord1hNV(OpenToolkit.Mathematics.Half s) => instance.glTexCoord1hNV(s);
        
        static unsafe void glTexCoord1hvNV(OpenToolkit.Mathematics.Half * v) => instance.glTexCoord1hvNV(v);
        
        static unsafe void glTexCoord1i(int s) => instance.glTexCoord1i(s);
        
        static unsafe void glTexCoord1iv(int * v) => instance.glTexCoord1iv(v);
        
        static unsafe void glTexCoord1s(short s) => instance.glTexCoord1s(s);
        
        static unsafe void glTexCoord1sv(short * v) => instance.glTexCoord1sv(v);
        
        static unsafe void glTexCoord1xOES(int s) => instance.glTexCoord1xOES(s);
        
        static unsafe void glTexCoord1xvOES(int * coords) => instance.glTexCoord1xvOES(coords);
        
        static unsafe void glTexCoord2bOES(sbyte s, sbyte t) => instance.glTexCoord2bOES(s, t);
        
        static unsafe void glTexCoord2bvOES(sbyte * coords) => instance.glTexCoord2bvOES(coords);
        
        static unsafe void glTexCoord2d(double s, double t) => instance.glTexCoord2d(s, t);
        
        static unsafe void glTexCoord2dv(double * v) => instance.glTexCoord2dv(v);
        
        static unsafe void glTexCoord2f(float s, float t) => instance.glTexCoord2f(s, t);
        
        static unsafe void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z) => instance.glTexCoord2fColor3fVertex3fSUN(s, t, r, g, b, x, y, z);
        
        static unsafe void glTexCoord2fColor3fVertex3fvSUN(float * tc, float * c, float * v) => instance.glTexCoord2fColor3fVertex3fvSUN(tc, c, v);
        
        static unsafe void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z) => instance.glTexCoord2fColor4fNormal3fVertex3fSUN(s, t, r, g, b, a, nx, ny, nz, x, y, z);
        
        static unsafe void glTexCoord2fColor4fNormal3fVertex3fvSUN(float * tc, float * c, float * n, float * v) => instance.glTexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n, v);
        
        static unsafe void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z) => instance.glTexCoord2fColor4ubVertex3fSUN(s, t, r, g, b, a, x, y, z);
        
        static unsafe void glTexCoord2fColor4ubVertex3fvSUN(float * tc, byte * c, float * v) => instance.glTexCoord2fColor4ubVertex3fvSUN(tc, c, v);
        
        static unsafe void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z) => instance.glTexCoord2fNormal3fVertex3fSUN(s, t, nx, ny, nz, x, y, z);
        
        static unsafe void glTexCoord2fNormal3fVertex3fvSUN(float * tc, float * n, float * v) => instance.glTexCoord2fNormal3fVertex3fvSUN(tc, n, v);
        
        static unsafe void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z) => instance.glTexCoord2fVertex3fSUN(s, t, x, y, z);
        
        static unsafe void glTexCoord2fVertex3fvSUN(float * tc, float * v) => instance.glTexCoord2fVertex3fvSUN(tc, v);
        
        static unsafe void glTexCoord2fv(float * v) => instance.glTexCoord2fv(v);
        
        static unsafe void glTexCoord2hNV(OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t) => instance.glTexCoord2hNV(s, t);
        
        static unsafe void glTexCoord2hvNV(OpenToolkit.Mathematics.Half * v) => instance.glTexCoord2hvNV(v);
        
        static unsafe void glTexCoord2i(int s, int t) => instance.glTexCoord2i(s, t);
        
        static unsafe void glTexCoord2iv(int * v) => instance.glTexCoord2iv(v);
        
        static unsafe void glTexCoord2s(short s, short t) => instance.glTexCoord2s(s, t);
        
        static unsafe void glTexCoord2sv(short * v) => instance.glTexCoord2sv(v);
        
        static unsafe void glTexCoord2xOES(int s, int t) => instance.glTexCoord2xOES(s, t);
        
        static unsafe void glTexCoord2xvOES(int * coords) => instance.glTexCoord2xvOES(coords);
        
        static unsafe void glTexCoord3bOES(sbyte s, sbyte t, sbyte r) => instance.glTexCoord3bOES(s, t, r);
        
        static unsafe void glTexCoord3bvOES(sbyte * coords) => instance.glTexCoord3bvOES(coords);
        
        static unsafe void glTexCoord3d(double s, double t, double r) => instance.glTexCoord3d(s, t, r);
        
        static unsafe void glTexCoord3dv(double * v) => instance.glTexCoord3dv(v);
        
        static unsafe void glTexCoord3f(float s, float t, float r) => instance.glTexCoord3f(s, t, r);
        
        static unsafe void glTexCoord3fv(float * v) => instance.glTexCoord3fv(v);
        
        static unsafe void glTexCoord3hNV(OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r) => instance.glTexCoord3hNV(s, t, r);
        
        static unsafe void glTexCoord3hvNV(OpenToolkit.Mathematics.Half * v) => instance.glTexCoord3hvNV(v);
        
        static unsafe void glTexCoord3i(int s, int t, int r) => instance.glTexCoord3i(s, t, r);
        
        static unsafe void glTexCoord3iv(int * v) => instance.glTexCoord3iv(v);
        
        static unsafe void glTexCoord3s(short s, short t, short r) => instance.glTexCoord3s(s, t, r);
        
        static unsafe void glTexCoord3sv(short * v) => instance.glTexCoord3sv(v);
        
        static unsafe void glTexCoord3xOES(int s, int t, int r) => instance.glTexCoord3xOES(s, t, r);
        
        static unsafe void glTexCoord3xvOES(int * coords) => instance.glTexCoord3xvOES(coords);
        
        static unsafe void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q) => instance.glTexCoord4bOES(s, t, r, q);
        
        static unsafe void glTexCoord4bvOES(sbyte * coords) => instance.glTexCoord4bvOES(coords);
        
        static unsafe void glTexCoord4d(double s, double t, double r, double q) => instance.glTexCoord4d(s, t, r, q);
        
        static unsafe void glTexCoord4dv(double * v) => instance.glTexCoord4dv(v);
        
        static unsafe void glTexCoord4f(float s, float t, float r, float q) => instance.glTexCoord4f(s, t, r, q);
        
        static unsafe void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w) => instance.glTexCoord4fColor4fNormal3fVertex4fSUN(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
        
        static unsafe void glTexCoord4fColor4fNormal3fVertex4fvSUN(float * tc, float * c, float * n, float * v) => instance.glTexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n, v);
        
        static unsafe void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w) => instance.glTexCoord4fVertex4fSUN(s, t, p, q, x, y, z, w);
        
        static unsafe void glTexCoord4fVertex4fvSUN(float * tc, float * v) => instance.glTexCoord4fVertex4fvSUN(tc, v);
        
        static unsafe void glTexCoord4fv(float * v) => instance.glTexCoord4fv(v);
        
        static unsafe void glTexCoord4hNV(OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r, OpenToolkit.Mathematics.Half q) => instance.glTexCoord4hNV(s, t, r, q);
        
        static unsafe void glTexCoord4hvNV(OpenToolkit.Mathematics.Half * v) => instance.glTexCoord4hvNV(v);
        
        static unsafe void glTexCoord4i(int s, int t, int r, int q) => instance.glTexCoord4i(s, t, r, q);
        
        static unsafe void glTexCoord4iv(int * v) => instance.glTexCoord4iv(v);
        
        static unsafe void glTexCoord4s(short s, short t, short r, short q) => instance.glTexCoord4s(s, t, r, q);
        
        static unsafe void glTexCoord4sv(short * v) => instance.glTexCoord4sv(v);
        
        static unsafe void glTexCoord4xOES(int s, int t, int r, int q) => instance.glTexCoord4xOES(s, t, r, q);
        
        static unsafe void glTexCoord4xvOES(int * coords) => instance.glTexCoord4xvOES(coords);
        
        static unsafe void glTexCoordP1ui(TexCoordPointerType type, uint coords) => instance.glTexCoordP1ui(type, coords);
        
        static unsafe void glTexCoordP1uiv(TexCoordPointerType type, uint * coords) => instance.glTexCoordP1uiv(type, coords);
        
        static unsafe void glTexCoordP2ui(TexCoordPointerType type, uint coords) => instance.glTexCoordP2ui(type, coords);
        
        static unsafe void glTexCoordP2uiv(TexCoordPointerType type, uint * coords) => instance.glTexCoordP2uiv(type, coords);
        
        static unsafe void glTexCoordP3ui(TexCoordPointerType type, uint coords) => instance.glTexCoordP3ui(type, coords);
        
        static unsafe void glTexCoordP3uiv(TexCoordPointerType type, uint * coords) => instance.glTexCoordP3uiv(type, coords);
        
        static unsafe void glTexCoordP4ui(TexCoordPointerType type, uint coords) => instance.glTexCoordP4ui(type, coords);
        
        static unsafe void glTexCoordP4uiv(TexCoordPointerType type, uint * coords) => instance.glTexCoordP4uiv(type, coords);
        
        static unsafe void glTexCoordPointer(int size, TexCoordPointerType type, uint stride, void * pointer) => instance.glTexCoordPointer(size, type, stride, pointer);
        
        static unsafe void glTexCoordPointerEXT(int size, TexCoordPointerType type, uint stride, uint count, void * pointer) => instance.glTexCoordPointerEXT(size, type, stride, count, pointer);
        
        static unsafe void glTexCoordPointerListIBM(int size, TexCoordPointerType type, int stride, void * * pointer, int ptrstride) => instance.glTexCoordPointerListIBM(size, type, stride, pointer, ptrstride);
        
        static unsafe void glTexCoordPointervINTEL(int size, VertexPointerType type, void * * pointer) => instance.glTexCoordPointervINTEL(size, type, pointer);
        
        static unsafe void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => instance.glTexEnvf(target, pname, param);
        
        static unsafe void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS) => instance.glTexEnvfv(target, pname, PARAMS);
        
        static unsafe void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => instance.glTexEnvi(target, pname, param);
        
        static unsafe void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glTexEnviv(target, pname, PARAMS);
        
        static unsafe void glTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => instance.glTexEnvx(target, pname, param);
        
        static unsafe void glTexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param) => instance.glTexEnvxOES(target, pname, param);
        
        static unsafe void glTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glTexEnvxv(target, pname, PARAMS);
        
        static unsafe void glTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS) => instance.glTexEnvxvOES(target, pname, PARAMS);
        
        static unsafe void glTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, uint n, float * weights) => instance.glTexFilterFuncSGIS(target, filter, n, weights);
        
        static unsafe void glTexGend(TextureCoordName coord, TextureGenParameter pname, double param) => instance.glTexGend(coord, pname, param);
        
        static unsafe void glTexGendv(TextureCoordName coord, TextureGenParameter pname, double * PARAMS) => instance.glTexGendv(coord, pname, PARAMS);
        
        static unsafe void glTexGenf(TextureCoordName coord, TextureGenParameter pname, float param) => instance.glTexGenf(coord, pname, param);
        
        static unsafe void glTexGenfOES(TextureCoordName coord, TextureGenParameter pname, float param) => instance.glTexGenfOES(coord, pname, param);
        
        static unsafe void glTexGenfv(TextureCoordName coord, TextureGenParameter pname, float * PARAMS) => instance.glTexGenfv(coord, pname, PARAMS);
        
        static unsafe void glTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float * PARAMS) => instance.glTexGenfvOES(coord, pname, PARAMS);
        
        static unsafe void glTexGeni(TextureCoordName coord, TextureGenParameter pname, int param) => instance.glTexGeni(coord, pname, param);
        
        static unsafe void glTexGeniOES(TextureCoordName coord, TextureGenParameter pname, int param) => instance.glTexGeniOES(coord, pname, param);
        
        static unsafe void glTexGeniv(TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glTexGeniv(coord, pname, PARAMS);
        
        static unsafe void glTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glTexGenivOES(coord, pname, PARAMS);
        
        static unsafe void glTexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param) => instance.glTexGenxOES(coord, pname, param);
        
        static unsafe void glTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS) => instance.glTexGenxvOES(coord, pname, PARAMS);
        
        static unsafe void glTexImage1D(TextureTarget target, int level, int internalformat, uint width, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
        
        static unsafe void glTexImage2D(TextureTarget target, int level, int internalformat, uint width, uint height, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        
        static unsafe void glTexImage2DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations) => instance.glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
        
        static unsafe void glTexImage2DMultisampleCoverageNV(TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, bool fixedSampleLocations) => instance.glTexImage2DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
        
        static unsafe void glTexImage3D(TextureTarget target, int level, int internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        
        static unsafe void glTexImage3DEXT(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels);
        
        static unsafe void glTexImage3DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations) => instance.glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        
        static unsafe void glTexImage3DMultisampleCoverageNV(TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, uint depth, bool fixedSampleLocations) => instance.glTexImage3DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
        
        static unsafe void glTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTexImage3DOES(target, level, internalformat, width, height, depth, border, format, type, pixels);
        
        static unsafe void glTexImage4DSGIS(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, uint size4d, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);
        
        static unsafe void glTexParameterIiv(TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glTexParameterIiv(target, pname, PARAMS);
        
        static unsafe void glTexParameterIivEXT(TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glTexParameterIivEXT(target, pname, PARAMS);
        
        static unsafe void glTexParameterIivOES(TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glTexParameterIivOES(target, pname, PARAMS);
        
        static unsafe void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, uint * PARAMS) => instance.glTexParameterIuiv(target, pname, PARAMS);
        
        static unsafe void glTexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint * PARAMS) => instance.glTexParameterIuivEXT(target, pname, PARAMS);
        
        static unsafe void glTexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint * PARAMS) => instance.glTexParameterIuivOES(target, pname, PARAMS);
        
        static unsafe void glTexParameterf(TextureTarget target, TextureParameterName pname, float param) => instance.glTexParameterf(target, pname, param);
        
        static unsafe void glTexParameterfv(TextureTarget target, TextureParameterName pname, float * PARAMS) => instance.glTexParameterfv(target, pname, PARAMS);
        
        static unsafe void glTexParameteri(TextureTarget target, TextureParameterName pname, int param) => instance.glTexParameteri(target, pname, param);
        
        static unsafe void glTexParameteriv(TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glTexParameteriv(target, pname, PARAMS);
        
        static unsafe void glTexParameterx(TextureTarget target, GetTextureParameter pname, int param) => instance.glTexParameterx(target, pname, param);
        
        static unsafe void glTexParameterxOES(TextureTarget target, GetTextureParameter pname, int param) => instance.glTexParameterxOES(target, pname, param);
        
        static unsafe void glTexParameterxv(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glTexParameterxv(target, pname, PARAMS);
        
        static unsafe void glTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int * PARAMS) => instance.glTexParameterxvOES(target, pname, PARAMS);
        
        static unsafe void glTexRenderbufferNV(TextureTarget target, uint renderbuffer) => instance.glTexRenderbufferNV(target, renderbuffer);
        
        static unsafe void glTexStorage1D(TextureTarget target, uint levels, InternalFormat internalformat, uint width) => instance.glTexStorage1D(target, levels, internalformat, width);
        
        static unsafe void glTexStorage1DEXT(TextureTarget target, uint levels, InternalFormat internalformat, uint width) => instance.glTexStorage1DEXT(target, levels, internalformat, width);
        
        static unsafe void glTexStorage2D(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height) => instance.glTexStorage2D(target, levels, internalformat, width, height);
        
        static unsafe void glTexStorage2DEXT(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height) => instance.glTexStorage2DEXT(target, levels, internalformat, width, height);
        
        static unsafe void glTexStorage2DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations) => instance.glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
        
        static unsafe void glTexStorage3D(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height, uint depth) => instance.glTexStorage3D(target, levels, internalformat, width, height, depth);
        
        static unsafe void glTexStorage3DEXT(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height, uint depth) => instance.glTexStorage3DEXT(target, levels, internalformat, width, height, depth);
        
        static unsafe void glTexStorage3DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations) => instance.glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        
        static unsafe void glTexStorage3DMultisampleOES(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations) => instance.glTexStorage3DMultisampleOES(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        
        static unsafe void glTexStorageSparseAMD(TextureTarget target, InternalFormat internalFormat, uint width, uint height, uint depth, uint layers, uint flags) => instance.glTexStorageSparseAMD(target, internalFormat, width, height, depth, layers, flags);
        
        static unsafe void glTexSubImage1D(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
        
        static unsafe void glTexSubImage1DEXT(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage1DEXT(target, level, xoffset, width, format, type, pixels);
        
        static unsafe void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        
        static unsafe void glTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels);
        
        static unsafe void glTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        
        static unsafe void glTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        
        static unsafe void glTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        
        static unsafe void glTexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, uint width, uint height, uint depth, uint size4d, PixelFormat format, PixelType type, void * pixels) => instance.glTexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);
        
        static unsafe void glTextureAttachMemoryNV(uint texture, uint memory, ulong offset) => instance.glTextureAttachMemoryNV(texture, memory, offset);
        
        static unsafe void glTextureBarrier() => instance.glTextureBarrier();
        
        static unsafe void glTextureBarrierNV() => instance.glTextureBarrierNV();
        
        static unsafe void glTextureBuffer(uint texture, InternalFormat internalformat, uint buffer) => instance.glTextureBuffer(texture, internalformat, buffer);
        
        static unsafe void glTextureBufferEXT(uint texture, TextureTarget target, InternalFormat internalformat, uint buffer) => instance.glTextureBufferEXT(texture, target, internalformat, buffer);
        
        static unsafe void glTextureBufferRange(uint texture, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size) => instance.glTextureBufferRange(texture, internalformat, buffer, offset, size);
        
        static unsafe void glTextureBufferRangeEXT(uint texture, TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size) => instance.glTextureBufferRangeEXT(texture, target, internalformat, buffer, offset, size);
        
        static unsafe void glTextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha) => instance.glTextureColorMaskSGIS(red, green, blue, alpha);
        
        static unsafe void glTextureFoveationParametersQCOM(uint texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea) => instance.glTextureFoveationParametersQCOM(texture, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
        
        static unsafe void glTextureImage1DEXT(uint texture, TextureTarget target, int level, int internalformat, uint width, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTextureImage1DEXT(texture, target, level, internalformat, width, border, format, type, pixels);
        
        static unsafe void glTextureImage2DEXT(uint texture, TextureTarget target, int level, int internalformat, uint width, uint height, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTextureImage2DEXT(texture, target, level, internalformat, width, height, border, format, type, pixels);
        
        static unsafe void glTextureImage2DMultisampleCoverageNV(uint texture, TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, bool fixedSampleLocations) => instance.glTextureImage2DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
        
        static unsafe void glTextureImage2DMultisampleNV(uint texture, TextureTarget target, uint samples, int internalFormat, uint width, uint height, bool fixedSampleLocations) => instance.glTextureImage2DMultisampleNV(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
        
        static unsafe void glTextureImage3DEXT(uint texture, TextureTarget target, int level, int internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels) => instance.glTextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, format, type, pixels);
        
        static unsafe void glTextureImage3DMultisampleCoverageNV(uint texture, TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, uint depth, bool fixedSampleLocations) => instance.glTextureImage3DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
        
        static unsafe void glTextureImage3DMultisampleNV(uint texture, TextureTarget target, uint samples, int internalFormat, uint width, uint height, uint depth, bool fixedSampleLocations) => instance.glTextureImage3DMultisampleNV(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
        
        static unsafe void glTextureLightEXT(LightTexturePNameEXT pname) => instance.glTextureLightEXT(pname);
        
        static unsafe void glTextureMaterialEXT(MaterialFace face, MaterialParameter mode) => instance.glTextureMaterialEXT(face, mode);
        
        static unsafe void glTextureNormalEXT(TextureNormalModeEXT mode) => instance.glTextureNormalEXT(mode);
        
        static unsafe void glTexturePageCommitmentEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, bool commit) => instance.glTexturePageCommitmentEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, commit);
        
        static unsafe void glTextureParameterIiv(uint texture, TextureParameterName pname, int * PARAMS) => instance.glTextureParameterIiv(texture, pname, PARAMS);
        
        static unsafe void glTextureParameterIivEXT(uint texture, TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glTextureParameterIivEXT(texture, target, pname, PARAMS);
        
        static unsafe void glTextureParameterIuiv(uint texture, TextureParameterName pname, uint * PARAMS) => instance.glTextureParameterIuiv(texture, pname, PARAMS);
        
        static unsafe void glTextureParameterIuivEXT(uint texture, TextureTarget target, TextureParameterName pname, uint * PARAMS) => instance.glTextureParameterIuivEXT(texture, target, pname, PARAMS);
        
        static unsafe void glTextureParameterf(uint texture, TextureParameterName pname, float param) => instance.glTextureParameterf(texture, pname, param);
        
        static unsafe void glTextureParameterfEXT(uint texture, TextureTarget target, TextureParameterName pname, float param) => instance.glTextureParameterfEXT(texture, target, pname, param);
        
        static unsafe void glTextureParameterfv(uint texture, TextureParameterName pname, float * param) => instance.glTextureParameterfv(texture, pname, param);
        
        static unsafe void glTextureParameterfvEXT(uint texture, TextureTarget target, TextureParameterName pname, float * PARAMS) => instance.glTextureParameterfvEXT(texture, target, pname, PARAMS);
        
        static unsafe void glTextureParameteri(uint texture, TextureParameterName pname, int param) => instance.glTextureParameteri(texture, pname, param);
        
        static unsafe void glTextureParameteriEXT(uint texture, TextureTarget target, TextureParameterName pname, int param) => instance.glTextureParameteriEXT(texture, target, pname, param);
        
        static unsafe void glTextureParameteriv(uint texture, TextureParameterName pname, int * param) => instance.glTextureParameteriv(texture, pname, param);
        
        static unsafe void glTextureParameterivEXT(uint texture, TextureTarget target, TextureParameterName pname, int * PARAMS) => instance.glTextureParameterivEXT(texture, target, pname, PARAMS);
        
        static unsafe void glTextureRenderbufferEXT(uint texture, TextureTarget target, uint renderbuffer) => instance.glTextureRenderbufferEXT(texture, target, renderbuffer);
        
        static unsafe void glTextureStorage1D(uint texture, uint levels, InternalFormat internalformat, uint width) => instance.glTextureStorage1D(texture, levels, internalformat, width);
        
        static unsafe void glTextureStorage2D(uint texture, uint levels, InternalFormat internalformat, uint width, uint height) => instance.glTextureStorage2D(texture, levels, internalformat, width, height);
        
        static unsafe void glTextureStorage2DMultisample(uint texture, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations) => instance.glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
        
        static unsafe void glTextureStorage2DMultisampleEXT(uint texture, TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations) => instance.glTextureStorage2DMultisampleEXT(texture, target, samples, internalformat, width, height, fixedsamplelocations);
        
        static unsafe void glTextureStorage3D(uint texture, uint levels, InternalFormat internalformat, uint width, uint height, uint depth) => instance.glTextureStorage3D(texture, levels, internalformat, width, height, depth);
        
        static unsafe void glTextureStorage3DMultisample(uint texture, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations) => instance.glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
        
        static unsafe void glTextureSubImage1D(uint texture, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels) => instance.glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        
        static unsafe void glTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels) => instance.glTextureSubImage1DEXT(texture, target, level, xoffset, width, format, type, pixels);
        
        static unsafe void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels) => instance.glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        
        static unsafe void glTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels) => instance.glTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, type, pixels);
        
        static unsafe void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels) => instance.glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        
        static unsafe void glTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels) => instance.glTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        
        static unsafe void glTextureView(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => instance.glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
        
        static unsafe void glTextureViewEXT(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => instance.glTextureViewEXT(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
        
        static unsafe void glTextureViewOES(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => instance.glTextureViewOES(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
        
        static unsafe void glTrackMatrixNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV matrix, VertexAttribEnumNV transform) => instance.glTrackMatrixNV(target, address, matrix, transform);
        
        static unsafe void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer) => instance.glTransformFeedbackBufferBase(xfb, index, buffer);
        
        static unsafe void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, UIntPtr size) => instance.glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
        
        static unsafe void glTransformFeedbackVaryings(uint program, uint count, char * * varyings, TransformFeedbackBufferMode bufferMode) => instance.glTransformFeedbackVaryings(program, count, varyings, bufferMode);
        
        static unsafe void glTransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float * transformValues) => instance.glTransformPathNV(resultPath, srcPath, transformType, transformValues);
        
        static unsafe void glTranslated(double x, double y, double z) => instance.glTranslated(x, y, z);
        
        static unsafe void glTranslatef(float x, float y, float z) => instance.glTranslatef(x, y, z);
        
        static unsafe void glTranslatex(int x, int y, int z) => instance.glTranslatex(x, y, z);
        
        static unsafe void glTranslatexOES(int x, int y, int z) => instance.glTranslatexOES(x, y, z);
        
        static unsafe void glUniform1d(int location, double x) => instance.glUniform1d(location, x);
        
        static unsafe void glUniform1dv(int location, uint count, double * value) => instance.glUniform1dv(location, count, value);
        
        static unsafe void glUniform1f(int location, float v0) => instance.glUniform1f(location, v0);
        
        static unsafe void glUniform1fARB(int location, float v0) => instance.glUniform1fARB(location, v0);
        
        static unsafe void glUniform1fv(int location, uint count, float * value) => instance.glUniform1fv(location, count, value);
        
        static unsafe void glUniform1fvARB(int location, uint count, float * value) => instance.glUniform1fvARB(location, count, value);
        
        static unsafe void glUniform1i(int location, int v0) => instance.glUniform1i(location, v0);
        
        static unsafe void glUniform1i64ARB(int location, long x) => instance.glUniform1i64ARB(location, x);
        
        static unsafe void glUniform1i64NV(int location, long x) => instance.glUniform1i64NV(location, x);
        
        static unsafe void glUniform1i64vARB(int location, uint count, long * value) => instance.glUniform1i64vARB(location, count, value);
        
        static unsafe void glUniform1i64vNV(int location, uint count, long * value) => instance.glUniform1i64vNV(location, count, value);
        
        static unsafe void glUniform1iARB(int location, int v0) => instance.glUniform1iARB(location, v0);
        
        static unsafe void glUniform1iv(int location, uint count, int * value) => instance.glUniform1iv(location, count, value);
        
        static unsafe void glUniform1ivARB(int location, uint count, int * value) => instance.glUniform1ivARB(location, count, value);
        
        static unsafe void glUniform1ui(int location, uint v0) => instance.glUniform1ui(location, v0);
        
        static unsafe void glUniform1ui64ARB(int location, ulong x) => instance.glUniform1ui64ARB(location, x);
        
        static unsafe void glUniform1ui64NV(int location, ulong x) => instance.glUniform1ui64NV(location, x);
        
        static unsafe void glUniform1ui64vARB(int location, uint count, ulong * value) => instance.glUniform1ui64vARB(location, count, value);
        
        static unsafe void glUniform1ui64vNV(int location, uint count, ulong * value) => instance.glUniform1ui64vNV(location, count, value);
        
        static unsafe void glUniform1uiEXT(int location, uint v0) => instance.glUniform1uiEXT(location, v0);
        
        static unsafe void glUniform1uiv(int location, uint count, uint * value) => instance.glUniform1uiv(location, count, value);
        
        static unsafe void glUniform1uivEXT(int location, uint count, uint * value) => instance.glUniform1uivEXT(location, count, value);
        
        static unsafe void glUniform2d(int location, double x, double y) => instance.glUniform2d(location, x, y);
        
        static unsafe void glUniform2dv(int location, uint count, double * value) => instance.glUniform2dv(location, count, value);
        
        static unsafe void glUniform2f(int location, float v0, float v1) => instance.glUniform2f(location, v0, v1);
        
        static unsafe void glUniform2fARB(int location, float v0, float v1) => instance.glUniform2fARB(location, v0, v1);
        
        static unsafe void glUniform2fv(int location, uint count, float * value) => instance.glUniform2fv(location, count, value);
        
        static unsafe void glUniform2fvARB(int location, uint count, float * value) => instance.glUniform2fvARB(location, count, value);
        
        static unsafe void glUniform2i(int location, int v0, int v1) => instance.glUniform2i(location, v0, v1);
        
        static unsafe void glUniform2i64ARB(int location, long x, long y) => instance.glUniform2i64ARB(location, x, y);
        
        static unsafe void glUniform2i64NV(int location, long x, long y) => instance.glUniform2i64NV(location, x, y);
        
        static unsafe void glUniform2i64vARB(int location, uint count, long * value) => instance.glUniform2i64vARB(location, count, value);
        
        static unsafe void glUniform2i64vNV(int location, uint count, long * value) => instance.glUniform2i64vNV(location, count, value);
        
        static unsafe void glUniform2iARB(int location, int v0, int v1) => instance.glUniform2iARB(location, v0, v1);
        
        static unsafe void glUniform2iv(int location, uint count, int * value) => instance.glUniform2iv(location, count, value);
        
        static unsafe void glUniform2ivARB(int location, uint count, int * value) => instance.glUniform2ivARB(location, count, value);
        
        static unsafe void glUniform2ui(int location, uint v0, uint v1) => instance.glUniform2ui(location, v0, v1);
        
        static unsafe void glUniform2ui64ARB(int location, ulong x, ulong y) => instance.glUniform2ui64ARB(location, x, y);
        
        static unsafe void glUniform2ui64NV(int location, ulong x, ulong y) => instance.glUniform2ui64NV(location, x, y);
        
        static unsafe void glUniform2ui64vARB(int location, uint count, ulong * value) => instance.glUniform2ui64vARB(location, count, value);
        
        static unsafe void glUniform2ui64vNV(int location, uint count, ulong * value) => instance.glUniform2ui64vNV(location, count, value);
        
        static unsafe void glUniform2uiEXT(int location, uint v0, uint v1) => instance.glUniform2uiEXT(location, v0, v1);
        
        static unsafe void glUniform2uiv(int location, uint count, uint * value) => instance.glUniform2uiv(location, count, value);
        
        static unsafe void glUniform2uivEXT(int location, uint count, uint * value) => instance.glUniform2uivEXT(location, count, value);
        
        static unsafe void glUniform3d(int location, double x, double y, double z) => instance.glUniform3d(location, x, y, z);
        
        static unsafe void glUniform3dv(int location, uint count, double * value) => instance.glUniform3dv(location, count, value);
        
        static unsafe void glUniform3f(int location, float v0, float v1, float v2) => instance.glUniform3f(location, v0, v1, v2);
        
        static unsafe void glUniform3fARB(int location, float v0, float v1, float v2) => instance.glUniform3fARB(location, v0, v1, v2);
        
        static unsafe void glUniform3fv(int location, uint count, float * value) => instance.glUniform3fv(location, count, value);
        
        static unsafe void glUniform3fvARB(int location, uint count, float * value) => instance.glUniform3fvARB(location, count, value);
        
        static unsafe void glUniform3i(int location, int v0, int v1, int v2) => instance.glUniform3i(location, v0, v1, v2);
        
        static unsafe void glUniform3i64ARB(int location, long x, long y, long z) => instance.glUniform3i64ARB(location, x, y, z);
        
        static unsafe void glUniform3i64NV(int location, long x, long y, long z) => instance.glUniform3i64NV(location, x, y, z);
        
        static unsafe void glUniform3i64vARB(int location, uint count, long * value) => instance.glUniform3i64vARB(location, count, value);
        
        static unsafe void glUniform3i64vNV(int location, uint count, long * value) => instance.glUniform3i64vNV(location, count, value);
        
        static unsafe void glUniform3iARB(int location, int v0, int v1, int v2) => instance.glUniform3iARB(location, v0, v1, v2);
        
        static unsafe void glUniform3iv(int location, uint count, int * value) => instance.glUniform3iv(location, count, value);
        
        static unsafe void glUniform3ivARB(int location, uint count, int * value) => instance.glUniform3ivARB(location, count, value);
        
        static unsafe void glUniform3ui(int location, uint v0, uint v1, uint v2) => instance.glUniform3ui(location, v0, v1, v2);
        
        static unsafe void glUniform3ui64ARB(int location, ulong x, ulong y, ulong z) => instance.glUniform3ui64ARB(location, x, y, z);
        
        static unsafe void glUniform3ui64NV(int location, ulong x, ulong y, ulong z) => instance.glUniform3ui64NV(location, x, y, z);
        
        static unsafe void glUniform3ui64vARB(int location, uint count, ulong * value) => instance.glUniform3ui64vARB(location, count, value);
        
        static unsafe void glUniform3ui64vNV(int location, uint count, ulong * value) => instance.glUniform3ui64vNV(location, count, value);
        
        static unsafe void glUniform3uiEXT(int location, uint v0, uint v1, uint v2) => instance.glUniform3uiEXT(location, v0, v1, v2);
        
        static unsafe void glUniform3uiv(int location, uint count, uint * value) => instance.glUniform3uiv(location, count, value);
        
        static unsafe void glUniform3uivEXT(int location, uint count, uint * value) => instance.glUniform3uivEXT(location, count, value);
        
        static unsafe void glUniform4d(int location, double x, double y, double z, double w) => instance.glUniform4d(location, x, y, z, w);
        
        static unsafe void glUniform4dv(int location, uint count, double * value) => instance.glUniform4dv(location, count, value);
        
        static unsafe void glUniform4f(int location, float v0, float v1, float v2, float v3) => instance.glUniform4f(location, v0, v1, v2, v3);
        
        static unsafe void glUniform4fARB(int location, float v0, float v1, float v2, float v3) => instance.glUniform4fARB(location, v0, v1, v2, v3);
        
        static unsafe void glUniform4fv(int location, uint count, float * value) => instance.glUniform4fv(location, count, value);
        
        static unsafe void glUniform4fvARB(int location, uint count, float * value) => instance.glUniform4fvARB(location, count, value);
        
        static unsafe void glUniform4i(int location, int v0, int v1, int v2, int v3) => instance.glUniform4i(location, v0, v1, v2, v3);
        
        static unsafe void glUniform4i64ARB(int location, long x, long y, long z, long w) => instance.glUniform4i64ARB(location, x, y, z, w);
        
        static unsafe void glUniform4i64NV(int location, long x, long y, long z, long w) => instance.glUniform4i64NV(location, x, y, z, w);
        
        static unsafe void glUniform4i64vARB(int location, uint count, long * value) => instance.glUniform4i64vARB(location, count, value);
        
        static unsafe void glUniform4i64vNV(int location, uint count, long * value) => instance.glUniform4i64vNV(location, count, value);
        
        static unsafe void glUniform4iARB(int location, int v0, int v1, int v2, int v3) => instance.glUniform4iARB(location, v0, v1, v2, v3);
        
        static unsafe void glUniform4iv(int location, uint count, int * value) => instance.glUniform4iv(location, count, value);
        
        static unsafe void glUniform4ivARB(int location, uint count, int * value) => instance.glUniform4ivARB(location, count, value);
        
        static unsafe void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => instance.glUniform4ui(location, v0, v1, v2, v3);
        
        static unsafe void glUniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w) => instance.glUniform4ui64ARB(location, x, y, z, w);
        
        static unsafe void glUniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w) => instance.glUniform4ui64NV(location, x, y, z, w);
        
        static unsafe void glUniform4ui64vARB(int location, uint count, ulong * value) => instance.glUniform4ui64vARB(location, count, value);
        
        static unsafe void glUniform4ui64vNV(int location, uint count, ulong * value) => instance.glUniform4ui64vNV(location, count, value);
        
        static unsafe void glUniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3) => instance.glUniform4uiEXT(location, v0, v1, v2, v3);
        
        static unsafe void glUniform4uiv(int location, uint count, uint * value) => instance.glUniform4uiv(location, count, value);
        
        static unsafe void glUniform4uivEXT(int location, uint count, uint * value) => instance.glUniform4uivEXT(location, count, value);
        
        static unsafe void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) => instance.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
        
        static unsafe void glUniformBufferEXT(uint program, int location, uint buffer) => instance.glUniformBufferEXT(program, location, buffer);
        
        static unsafe void glUniformHandleui64ARB(int location, ulong value) => instance.glUniformHandleui64ARB(location, value);
        
        static unsafe void glUniformHandleui64IMG(int location, ulong value) => instance.glUniformHandleui64IMG(location, value);
        
        static unsafe void glUniformHandleui64NV(int location, ulong value) => instance.glUniformHandleui64NV(location, value);
        
        static unsafe void glUniformHandleui64vARB(int location, uint count, ulong * value) => instance.glUniformHandleui64vARB(location, count, value);
        
        static unsafe void glUniformHandleui64vIMG(int location, uint count, ulong * value) => instance.glUniformHandleui64vIMG(location, count, value);
        
        static unsafe void glUniformHandleui64vNV(int location, uint count, ulong * value) => instance.glUniformHandleui64vNV(location, count, value);
        
        static unsafe void glUniformMatrix2dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix2dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix2fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2fvARB(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix2fvARB(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2x3dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix2x3dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2x3fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix2x3fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2x3fvNV(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix2x3fvNV(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2x4dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix2x4dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2x4fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix2x4fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix2x4fvNV(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix2x4fvNV(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix3dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix3fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3fvARB(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix3fvARB(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3x2dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix3x2dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3x2fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix3x2fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3x2fvNV(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix3x2fvNV(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3x4dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix3x4dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3x4fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix3x4fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix3x4fvNV(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix3x4fvNV(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix4dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix4fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4fvARB(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix4fvARB(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4x2dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix4x2dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4x2fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix4x2fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4x2fvNV(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix4x2fvNV(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4x3dv(int location, uint count, bool transpose, double * value) => instance.glUniformMatrix4x3dv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4x3fv(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix4x3fv(location, count, transpose, value);
        
        static unsafe void glUniformMatrix4x3fvNV(int location, uint count, bool transpose, float * value) => instance.glUniformMatrix4x3fvNV(location, count, transpose, value);
        
        static unsafe void glUniformSubroutinesuiv(ShaderType shadertype, uint count, uint * indices) => instance.glUniformSubroutinesuiv(shadertype, count, indices);
        
        static unsafe void glUniformui64NV(int location, ulong value) => instance.glUniformui64NV(location, value);
        
        static unsafe void glUniformui64vNV(int location, uint count, ulong * value) => instance.glUniformui64vNV(location, count, value);
        
        static unsafe void glUnlockArraysEXT() => instance.glUnlockArraysEXT();
        
        static unsafe bool glUnmapBuffer(BufferTargetARB target) => instance.glUnmapBuffer(target);
        
        static unsafe bool glUnmapBufferARB(BufferTargetARB target) => instance.glUnmapBufferARB(target);
        
        static unsafe bool glUnmapNamedBuffer(uint buffer) => instance.glUnmapNamedBuffer(buffer);
        
        static unsafe bool glUnmapNamedBufferEXT(uint buffer) => instance.glUnmapNamedBufferEXT(buffer);
        
        static unsafe void glUnmapObjectBufferATI(uint buffer) => instance.glUnmapObjectBufferATI(buffer);
        
        static unsafe void glUnmapTexture2DINTEL(uint texture, int level) => instance.glUnmapTexture2DINTEL(texture, level);
        
        static unsafe void glUpdateObjectBufferATI(uint buffer, uint offset, uint size, void * pointer, PreserveModeATI preserve) => instance.glUpdateObjectBufferATI(buffer, offset, size, pointer, preserve);
        
        static unsafe void glUploadGpuMaskNVX(uint mask) => instance.glUploadGpuMaskNVX(mask);
        
        static unsafe void glUseProgram(uint program) => instance.glUseProgram(program);
        
        static unsafe void glUseProgramObjectARB(uint programObj) => instance.glUseProgramObjectARB(programObj);
        
        static unsafe void glUseProgramStages(uint pipeline, uint stages, uint program) => instance.glUseProgramStages(pipeline, stages, program);
        
        static unsafe void glUseProgramStagesEXT(uint pipeline, uint stages, uint program) => instance.glUseProgramStagesEXT(pipeline, stages, program);
        
        static unsafe void glVDPAUFiniNV() => instance.glVDPAUFiniNV();
        
        static unsafe void glVDPAUInitNV(void * vdpDevice, void * getProcAddress) => instance.glVDPAUInitNV(vdpDevice, getProcAddress);
        
        static unsafe bool glVDPAUIsSurfaceNV(IntPtr surface) => instance.glVDPAUIsSurfaceNV(surface);
        
        static unsafe void glVDPAUMapSurfacesNV(uint numSurfaces, IntPtr * surfaces) => instance.glVDPAUMapSurfacesNV(numSurfaces, surfaces);
        
        static unsafe void glVDPAUUnmapSurfacesNV(uint numSurface, IntPtr * surfaces) => instance.glVDPAUUnmapSurfacesNV(numSurface, surfaces);
        
        static unsafe void glVDPAUUnregisterSurfaceNV(IntPtr surface) => instance.glVDPAUUnregisterSurfaceNV(surface);
        
        static unsafe void glValidateProgram(uint program) => instance.glValidateProgram(program);
        
        static unsafe void glValidateProgramARB(uint programObj) => instance.glValidateProgramARB(programObj);
        
        static unsafe void glValidateProgramPipeline(uint pipeline) => instance.glValidateProgramPipeline(pipeline);
        
        static unsafe void glValidateProgramPipelineEXT(uint pipeline) => instance.glValidateProgramPipelineEXT(pipeline);
        
        static unsafe void glVariantArrayObjectATI(uint id, ScalarType type, uint stride, uint buffer, uint offset) => instance.glVariantArrayObjectATI(id, type, stride, buffer, offset);
        
        static unsafe void glVariantPointerEXT(uint id, ScalarType type, uint stride, void * addr) => instance.glVariantPointerEXT(id, type, stride, addr);
        
        static unsafe void glVariantbvEXT(uint id, sbyte * addr) => instance.glVariantbvEXT(id, addr);
        
        static unsafe void glVariantdvEXT(uint id, double * addr) => instance.glVariantdvEXT(id, addr);
        
        static unsafe void glVariantfvEXT(uint id, float * addr) => instance.glVariantfvEXT(id, addr);
        
        static unsafe void glVariantivEXT(uint id, int * addr) => instance.glVariantivEXT(id, addr);
        
        static unsafe void glVariantsvEXT(uint id, short * addr) => instance.glVariantsvEXT(id, addr);
        
        static unsafe void glVariantubvEXT(uint id, byte * addr) => instance.glVariantubvEXT(id, addr);
        
        static unsafe void glVariantuivEXT(uint id, uint * addr) => instance.glVariantuivEXT(id, addr);
        
        static unsafe void glVariantusvEXT(uint id, ushort * addr) => instance.glVariantusvEXT(id, addr);
        
        static unsafe void glVertex2bOES(sbyte x, sbyte y) => instance.glVertex2bOES(x, y);
        
        static unsafe void glVertex2bvOES(sbyte * coords) => instance.glVertex2bvOES(coords);
        
        static unsafe void glVertex2d(double x, double y) => instance.glVertex2d(x, y);
        
        static unsafe void glVertex2dv(double * v) => instance.glVertex2dv(v);
        
        static unsafe void glVertex2f(float x, float y) => instance.glVertex2f(x, y);
        
        static unsafe void glVertex2fv(float * v) => instance.glVertex2fv(v);
        
        static unsafe void glVertex2hNV(OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y) => instance.glVertex2hNV(x, y);
        
        static unsafe void glVertex2hvNV(OpenToolkit.Mathematics.Half * v) => instance.glVertex2hvNV(v);
        
        static unsafe void glVertex2i(int x, int y) => instance.glVertex2i(x, y);
        
        static unsafe void glVertex2iv(int * v) => instance.glVertex2iv(v);
        
        static unsafe void glVertex2s(short x, short y) => instance.glVertex2s(x, y);
        
        static unsafe void glVertex2sv(short * v) => instance.glVertex2sv(v);
        
        static unsafe void glVertex2xOES(int x) => instance.glVertex2xOES(x);
        
        static unsafe void glVertex2xvOES(int * coords) => instance.glVertex2xvOES(coords);
        
        static unsafe void glVertex3bOES(sbyte x, sbyte y, sbyte z) => instance.glVertex3bOES(x, y, z);
        
        static unsafe void glVertex3bvOES(sbyte * coords) => instance.glVertex3bvOES(coords);
        
        static unsafe void glVertex3d(double x, double y, double z) => instance.glVertex3d(x, y, z);
        
        static unsafe void glVertex3dv(double * v) => instance.glVertex3dv(v);
        
        static unsafe void glVertex3f(float x, float y, float z) => instance.glVertex3f(x, y, z);
        
        static unsafe void glVertex3fv(float * v) => instance.glVertex3fv(v);
        
        static unsafe void glVertex3hNV(OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z) => instance.glVertex3hNV(x, y, z);
        
        static unsafe void glVertex3hvNV(OpenToolkit.Mathematics.Half * v) => instance.glVertex3hvNV(v);
        
        static unsafe void glVertex3i(int x, int y, int z) => instance.glVertex3i(x, y, z);
        
        static unsafe void glVertex3iv(int * v) => instance.glVertex3iv(v);
        
        static unsafe void glVertex3s(short x, short y, short z) => instance.glVertex3s(x, y, z);
        
        static unsafe void glVertex3sv(short * v) => instance.glVertex3sv(v);
        
        static unsafe void glVertex3xOES(int x, int y) => instance.glVertex3xOES(x, y);
        
        static unsafe void glVertex3xvOES(int * coords) => instance.glVertex3xvOES(coords);
        
        static unsafe void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w) => instance.glVertex4bOES(x, y, z, w);
        
        static unsafe void glVertex4bvOES(sbyte * coords) => instance.glVertex4bvOES(coords);
        
        static unsafe void glVertex4d(double x, double y, double z, double w) => instance.glVertex4d(x, y, z, w);
        
        static unsafe void glVertex4dv(double * v) => instance.glVertex4dv(v);
        
        static unsafe void glVertex4f(float x, float y, float z, float w) => instance.glVertex4f(x, y, z, w);
        
        static unsafe void glVertex4fv(float * v) => instance.glVertex4fv(v);
        
        static unsafe void glVertex4hNV(OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z, OpenToolkit.Mathematics.Half w) => instance.glVertex4hNV(x, y, z, w);
        
        static unsafe void glVertex4hvNV(OpenToolkit.Mathematics.Half * v) => instance.glVertex4hvNV(v);
        
        static unsafe void glVertex4i(int x, int y, int z, int w) => instance.glVertex4i(x, y, z, w);
        
        static unsafe void glVertex4iv(int * v) => instance.glVertex4iv(v);
        
        static unsafe void glVertex4s(short x, short y, short z, short w) => instance.glVertex4s(x, y, z, w);
        
        static unsafe void glVertex4sv(short * v) => instance.glVertex4sv(v);
        
        static unsafe void glVertex4xOES(int x, int y, int z) => instance.glVertex4xOES(x, y, z);
        
        static unsafe void glVertex4xvOES(int * coords) => instance.glVertex4xvOES(coords);
        
        static unsafe void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) => instance.glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
        
        static unsafe void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => instance.glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
        
        static unsafe void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => instance.glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
        
        static unsafe void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => instance.glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
        
        static unsafe void glVertexArrayBindVertexBufferEXT(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, uint stride) => instance.glVertexArrayBindVertexBufferEXT(vaobj, bindingindex, buffer, offset, stride);
        
        static unsafe void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) => instance.glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
        
        static unsafe void glVertexArrayColorOffsetEXT(uint vaobj, uint buffer, int size, ColorPointerType type, uint stride, IntPtr offset) => instance.glVertexArrayColorOffsetEXT(vaobj, buffer, size, type, stride, offset);
        
        static unsafe void glVertexArrayEdgeFlagOffsetEXT(uint vaobj, uint buffer, uint stride, IntPtr offset) => instance.glVertexArrayEdgeFlagOffsetEXT(vaobj, buffer, stride, offset);
        
        static unsafe void glVertexArrayElementBuffer(uint vaobj, uint buffer) => instance.glVertexArrayElementBuffer(vaobj, buffer);
        
        static unsafe void glVertexArrayFogCoordOffsetEXT(uint vaobj, uint buffer, FogCoordinatePointerType type, uint stride, IntPtr offset) => instance.glVertexArrayFogCoordOffsetEXT(vaobj, buffer, type, stride, offset);
        
        static unsafe void glVertexArrayIndexOffsetEXT(uint vaobj, uint buffer, IndexPointerType type, uint stride, IntPtr offset) => instance.glVertexArrayIndexOffsetEXT(vaobj, buffer, type, stride, offset);
        
        static unsafe void glVertexArrayNormalOffsetEXT(uint vaobj, uint buffer, NormalPointerType type, uint stride, IntPtr offset) => instance.glVertexArrayNormalOffsetEXT(vaobj, buffer, type, stride, offset);
        
        static unsafe void glVertexArrayParameteriAPPLE(VertexArrayPNameAPPLE pname, int param) => instance.glVertexArrayParameteriAPPLE(pname, param);
        
        static unsafe void glVertexArrayRangeAPPLE(uint length, void * pointer) => instance.glVertexArrayRangeAPPLE(length, pointer);
        
        static unsafe void glVertexArrayRangeNV(uint length, void * pointer) => instance.glVertexArrayRangeNV(length, pointer);
        
        static unsafe void glVertexArraySecondaryColorOffsetEXT(uint vaobj, uint buffer, int size, ColorPointerType type, uint stride, IntPtr offset) => instance.glVertexArraySecondaryColorOffsetEXT(vaobj, buffer, size, type, stride, offset);
        
        static unsafe void glVertexArrayTexCoordOffsetEXT(uint vaobj, uint buffer, int size, TexCoordPointerType type, uint stride, IntPtr offset) => instance.glVertexArrayTexCoordOffsetEXT(vaobj, buffer, size, type, stride, offset);
        
        static unsafe void glVertexArrayVertexAttribBindingEXT(uint vaobj, uint attribindex, uint bindingindex) => instance.glVertexArrayVertexAttribBindingEXT(vaobj, attribindex, bindingindex);
        
        static unsafe void glVertexArrayVertexAttribDivisorEXT(uint vaobj, uint index, uint divisor) => instance.glVertexArrayVertexAttribDivisorEXT(vaobj, index, divisor);
        
        static unsafe void glVertexArrayVertexAttribFormatEXT(uint vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => instance.glVertexArrayVertexAttribFormatEXT(vaobj, attribindex, size, type, normalized, relativeoffset);
        
        static unsafe void glVertexArrayVertexAttribIFormatEXT(uint vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => instance.glVertexArrayVertexAttribIFormatEXT(vaobj, attribindex, size, type, relativeoffset);
        
        static unsafe void glVertexArrayVertexAttribIOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribType type, uint stride, IntPtr offset) => instance.glVertexArrayVertexAttribIOffsetEXT(vaobj, buffer, index, size, type, stride, offset);
        
        static unsafe void glVertexArrayVertexAttribLFormatEXT(uint vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => instance.glVertexArrayVertexAttribLFormatEXT(vaobj, attribindex, size, type, relativeoffset);
        
        static unsafe void glVertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribLType type, uint stride, IntPtr offset) => instance.glVertexArrayVertexAttribLOffsetEXT(vaobj, buffer, index, size, type, stride, offset);
        
        static unsafe void glVertexArrayVertexAttribOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, IntPtr offset) => instance.glVertexArrayVertexAttribOffsetEXT(vaobj, buffer, index, size, type, normalized, stride, offset);
        
        static unsafe void glVertexArrayVertexBindingDivisorEXT(uint vaobj, uint bindingindex, uint divisor) => instance.glVertexArrayVertexBindingDivisorEXT(vaobj, bindingindex, divisor);
        
        static unsafe void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, uint stride) => instance.glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
        
        static unsafe void glVertexArrayVertexBuffers(uint vaobj, uint first, uint count, uint * buffers, IntPtr * offsets, uint * strides) => instance.glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
        
        static unsafe void glVertexArrayVertexOffsetEXT(uint vaobj, uint buffer, int size, VertexPointerType type, uint stride, IntPtr offset) => instance.glVertexArrayVertexOffsetEXT(vaobj, buffer, size, type, stride, offset);
        
        static unsafe void glVertexAttrib1d(uint index, double x) => instance.glVertexAttrib1d(index, x);
        
        static unsafe void glVertexAttrib1dARB(uint index, double x) => instance.glVertexAttrib1dARB(index, x);
        
        static unsafe void glVertexAttrib1dNV(uint index, double x) => instance.glVertexAttrib1dNV(index, x);
        
        static unsafe void glVertexAttrib1dv(uint index, double * v) => instance.glVertexAttrib1dv(index, v);
        
        static unsafe void glVertexAttrib1dvARB(uint index, double * v) => instance.glVertexAttrib1dvARB(index, v);
        
        static unsafe void glVertexAttrib1dvNV(uint index, double * v) => instance.glVertexAttrib1dvNV(index, v);
        
        static unsafe void glVertexAttrib1f(uint index, float x) => instance.glVertexAttrib1f(index, x);
        
        static unsafe void glVertexAttrib1fARB(uint index, float x) => instance.glVertexAttrib1fARB(index, x);
        
        static unsafe void glVertexAttrib1fNV(uint index, float x) => instance.glVertexAttrib1fNV(index, x);
        
        static unsafe void glVertexAttrib1fv(uint index, float * v) => instance.glVertexAttrib1fv(index, v);
        
        static unsafe void glVertexAttrib1fvARB(uint index, float * v) => instance.glVertexAttrib1fvARB(index, v);
        
        static unsafe void glVertexAttrib1fvNV(uint index, float * v) => instance.glVertexAttrib1fvNV(index, v);
        
        static unsafe void glVertexAttrib1hNV(uint index, OpenToolkit.Mathematics.Half x) => instance.glVertexAttrib1hNV(index, x);
        
        static unsafe void glVertexAttrib1hvNV(uint index, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttrib1hvNV(index, v);
        
        static unsafe void glVertexAttrib1s(uint index, short x) => instance.glVertexAttrib1s(index, x);
        
        static unsafe void glVertexAttrib1sARB(uint index, short x) => instance.glVertexAttrib1sARB(index, x);
        
        static unsafe void glVertexAttrib1sNV(uint index, short x) => instance.glVertexAttrib1sNV(index, x);
        
        static unsafe void glVertexAttrib1sv(uint index, short * v) => instance.glVertexAttrib1sv(index, v);
        
        static unsafe void glVertexAttrib1svARB(uint index, short * v) => instance.glVertexAttrib1svARB(index, v);
        
        static unsafe void glVertexAttrib1svNV(uint index, short * v) => instance.glVertexAttrib1svNV(index, v);
        
        static unsafe void glVertexAttrib2d(uint index, double x, double y) => instance.glVertexAttrib2d(index, x, y);
        
        static unsafe void glVertexAttrib2dARB(uint index, double x, double y) => instance.glVertexAttrib2dARB(index, x, y);
        
        static unsafe void glVertexAttrib2dNV(uint index, double x, double y) => instance.glVertexAttrib2dNV(index, x, y);
        
        static unsafe void glVertexAttrib2dv(uint index, double * v) => instance.glVertexAttrib2dv(index, v);
        
        static unsafe void glVertexAttrib2dvARB(uint index, double * v) => instance.glVertexAttrib2dvARB(index, v);
        
        static unsafe void glVertexAttrib2dvNV(uint index, double * v) => instance.glVertexAttrib2dvNV(index, v);
        
        static unsafe void glVertexAttrib2f(uint index, float x, float y) => instance.glVertexAttrib2f(index, x, y);
        
        static unsafe void glVertexAttrib2fARB(uint index, float x, float y) => instance.glVertexAttrib2fARB(index, x, y);
        
        static unsafe void glVertexAttrib2fNV(uint index, float x, float y) => instance.glVertexAttrib2fNV(index, x, y);
        
        static unsafe void glVertexAttrib2fv(uint index, float * v) => instance.glVertexAttrib2fv(index, v);
        
        static unsafe void glVertexAttrib2fvARB(uint index, float * v) => instance.glVertexAttrib2fvARB(index, v);
        
        static unsafe void glVertexAttrib2fvNV(uint index, float * v) => instance.glVertexAttrib2fvNV(index, v);
        
        static unsafe void glVertexAttrib2hNV(uint index, OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y) => instance.glVertexAttrib2hNV(index, x, y);
        
        static unsafe void glVertexAttrib2hvNV(uint index, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttrib2hvNV(index, v);
        
        static unsafe void glVertexAttrib2s(uint index, short x, short y) => instance.glVertexAttrib2s(index, x, y);
        
        static unsafe void glVertexAttrib2sARB(uint index, short x, short y) => instance.glVertexAttrib2sARB(index, x, y);
        
        static unsafe void glVertexAttrib2sNV(uint index, short x, short y) => instance.glVertexAttrib2sNV(index, x, y);
        
        static unsafe void glVertexAttrib2sv(uint index, short * v) => instance.glVertexAttrib2sv(index, v);
        
        static unsafe void glVertexAttrib2svARB(uint index, short * v) => instance.glVertexAttrib2svARB(index, v);
        
        static unsafe void glVertexAttrib2svNV(uint index, short * v) => instance.glVertexAttrib2svNV(index, v);
        
        static unsafe void glVertexAttrib3d(uint index, double x, double y, double z) => instance.glVertexAttrib3d(index, x, y, z);
        
        static unsafe void glVertexAttrib3dARB(uint index, double x, double y, double z) => instance.glVertexAttrib3dARB(index, x, y, z);
        
        static unsafe void glVertexAttrib3dNV(uint index, double x, double y, double z) => instance.glVertexAttrib3dNV(index, x, y, z);
        
        static unsafe void glVertexAttrib3dv(uint index, double * v) => instance.glVertexAttrib3dv(index, v);
        
        static unsafe void glVertexAttrib3dvARB(uint index, double * v) => instance.glVertexAttrib3dvARB(index, v);
        
        static unsafe void glVertexAttrib3dvNV(uint index, double * v) => instance.glVertexAttrib3dvNV(index, v);
        
        static unsafe void glVertexAttrib3f(uint index, float x, float y, float z) => instance.glVertexAttrib3f(index, x, y, z);
        
        static unsafe void glVertexAttrib3fARB(uint index, float x, float y, float z) => instance.glVertexAttrib3fARB(index, x, y, z);
        
        static unsafe void glVertexAttrib3fNV(uint index, float x, float y, float z) => instance.glVertexAttrib3fNV(index, x, y, z);
        
        static unsafe void glVertexAttrib3fv(uint index, float * v) => instance.glVertexAttrib3fv(index, v);
        
        static unsafe void glVertexAttrib3fvARB(uint index, float * v) => instance.glVertexAttrib3fvARB(index, v);
        
        static unsafe void glVertexAttrib3fvNV(uint index, float * v) => instance.glVertexAttrib3fvNV(index, v);
        
        static unsafe void glVertexAttrib3hNV(uint index, OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z) => instance.glVertexAttrib3hNV(index, x, y, z);
        
        static unsafe void glVertexAttrib3hvNV(uint index, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttrib3hvNV(index, v);
        
        static unsafe void glVertexAttrib3s(uint index, short x, short y, short z) => instance.glVertexAttrib3s(index, x, y, z);
        
        static unsafe void glVertexAttrib3sARB(uint index, short x, short y, short z) => instance.glVertexAttrib3sARB(index, x, y, z);
        
        static unsafe void glVertexAttrib3sNV(uint index, short x, short y, short z) => instance.glVertexAttrib3sNV(index, x, y, z);
        
        static unsafe void glVertexAttrib3sv(uint index, short * v) => instance.glVertexAttrib3sv(index, v);
        
        static unsafe void glVertexAttrib3svARB(uint index, short * v) => instance.glVertexAttrib3svARB(index, v);
        
        static unsafe void glVertexAttrib3svNV(uint index, short * v) => instance.glVertexAttrib3svNV(index, v);
        
        static unsafe void glVertexAttrib4Nbv(uint index, sbyte * v) => instance.glVertexAttrib4Nbv(index, v);
        
        static unsafe void glVertexAttrib4NbvARB(uint index, sbyte * v) => instance.glVertexAttrib4NbvARB(index, v);
        
        static unsafe void glVertexAttrib4Niv(uint index, int * v) => instance.glVertexAttrib4Niv(index, v);
        
        static unsafe void glVertexAttrib4NivARB(uint index, int * v) => instance.glVertexAttrib4NivARB(index, v);
        
        static unsafe void glVertexAttrib4Nsv(uint index, short * v) => instance.glVertexAttrib4Nsv(index, v);
        
        static unsafe void glVertexAttrib4NsvARB(uint index, short * v) => instance.glVertexAttrib4NsvARB(index, v);
        
        static unsafe void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) => instance.glVertexAttrib4Nub(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) => instance.glVertexAttrib4NubARB(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4Nubv(uint index, byte * v) => instance.glVertexAttrib4Nubv(index, v);
        
        static unsafe void glVertexAttrib4NubvARB(uint index, byte * v) => instance.glVertexAttrib4NubvARB(index, v);
        
        static unsafe void glVertexAttrib4Nuiv(uint index, uint * v) => instance.glVertexAttrib4Nuiv(index, v);
        
        static unsafe void glVertexAttrib4NuivARB(uint index, uint * v) => instance.glVertexAttrib4NuivARB(index, v);
        
        static unsafe void glVertexAttrib4Nusv(uint index, ushort * v) => instance.glVertexAttrib4Nusv(index, v);
        
        static unsafe void glVertexAttrib4NusvARB(uint index, ushort * v) => instance.glVertexAttrib4NusvARB(index, v);
        
        static unsafe void glVertexAttrib4bv(uint index, sbyte * v) => instance.glVertexAttrib4bv(index, v);
        
        static unsafe void glVertexAttrib4bvARB(uint index, sbyte * v) => instance.glVertexAttrib4bvARB(index, v);
        
        static unsafe void glVertexAttrib4d(uint index, double x, double y, double z, double w) => instance.glVertexAttrib4d(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4dARB(uint index, double x, double y, double z, double w) => instance.glVertexAttrib4dARB(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4dNV(uint index, double x, double y, double z, double w) => instance.glVertexAttrib4dNV(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4dv(uint index, double * v) => instance.glVertexAttrib4dv(index, v);
        
        static unsafe void glVertexAttrib4dvARB(uint index, double * v) => instance.glVertexAttrib4dvARB(index, v);
        
        static unsafe void glVertexAttrib4dvNV(uint index, double * v) => instance.glVertexAttrib4dvNV(index, v);
        
        static unsafe void glVertexAttrib4f(uint index, float x, float y, float z, float w) => instance.glVertexAttrib4f(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4fARB(uint index, float x, float y, float z, float w) => instance.glVertexAttrib4fARB(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4fNV(uint index, float x, float y, float z, float w) => instance.glVertexAttrib4fNV(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4fv(uint index, float * v) => instance.glVertexAttrib4fv(index, v);
        
        static unsafe void glVertexAttrib4fvARB(uint index, float * v) => instance.glVertexAttrib4fvARB(index, v);
        
        static unsafe void glVertexAttrib4fvNV(uint index, float * v) => instance.glVertexAttrib4fvNV(index, v);
        
        static unsafe void glVertexAttrib4hNV(uint index, OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z, OpenToolkit.Mathematics.Half w) => instance.glVertexAttrib4hNV(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4hvNV(uint index, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttrib4hvNV(index, v);
        
        static unsafe void glVertexAttrib4iv(uint index, int * v) => instance.glVertexAttrib4iv(index, v);
        
        static unsafe void glVertexAttrib4ivARB(uint index, int * v) => instance.glVertexAttrib4ivARB(index, v);
        
        static unsafe void glVertexAttrib4s(uint index, short x, short y, short z, short w) => instance.glVertexAttrib4s(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4sARB(uint index, short x, short y, short z, short w) => instance.glVertexAttrib4sARB(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4sNV(uint index, short x, short y, short z, short w) => instance.glVertexAttrib4sNV(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4sv(uint index, short * v) => instance.glVertexAttrib4sv(index, v);
        
        static unsafe void glVertexAttrib4svARB(uint index, short * v) => instance.glVertexAttrib4svARB(index, v);
        
        static unsafe void glVertexAttrib4svNV(uint index, short * v) => instance.glVertexAttrib4svNV(index, v);
        
        static unsafe void glVertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w) => instance.glVertexAttrib4ubNV(index, x, y, z, w);
        
        static unsafe void glVertexAttrib4ubv(uint index, byte * v) => instance.glVertexAttrib4ubv(index, v);
        
        static unsafe void glVertexAttrib4ubvARB(uint index, byte * v) => instance.glVertexAttrib4ubvARB(index, v);
        
        static unsafe void glVertexAttrib4ubvNV(uint index, byte * v) => instance.glVertexAttrib4ubvNV(index, v);
        
        static unsafe void glVertexAttrib4uiv(uint index, uint * v) => instance.glVertexAttrib4uiv(index, v);
        
        static unsafe void glVertexAttrib4uivARB(uint index, uint * v) => instance.glVertexAttrib4uivARB(index, v);
        
        static unsafe void glVertexAttrib4usv(uint index, ushort * v) => instance.glVertexAttrib4usv(index, v);
        
        static unsafe void glVertexAttrib4usvARB(uint index, ushort * v) => instance.glVertexAttrib4usvARB(index, v);
        
        static unsafe void glVertexAttribArrayObjectATI(uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, uint buffer, uint offset) => instance.glVertexAttribArrayObjectATI(index, size, type, normalized, stride, buffer, offset);
        
        static unsafe void glVertexAttribBinding(uint attribindex, uint bindingindex) => instance.glVertexAttribBinding(attribindex, bindingindex);
        
        static unsafe void glVertexAttribDivisor(uint index, uint divisor) => instance.glVertexAttribDivisor(index, divisor);
        
        static unsafe void glVertexAttribDivisorANGLE(uint index, uint divisor) => instance.glVertexAttribDivisorANGLE(index, divisor);
        
        static unsafe void glVertexAttribDivisorARB(uint index, uint divisor) => instance.glVertexAttribDivisorARB(index, divisor);
        
        static unsafe void glVertexAttribDivisorEXT(uint index, uint divisor) => instance.glVertexAttribDivisorEXT(index, divisor);
        
        static unsafe void glVertexAttribDivisorNV(uint index, uint divisor) => instance.glVertexAttribDivisorNV(index, divisor);
        
        static unsafe void glVertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset) => instance.glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
        
        static unsafe void glVertexAttribFormatNV(uint index, int size, VertexAttribType type, bool normalized, uint stride) => instance.glVertexAttribFormatNV(index, size, type, normalized, stride);
        
        static unsafe void glVertexAttribI1i(uint index, int x) => instance.glVertexAttribI1i(index, x);
        
        static unsafe void glVertexAttribI1iEXT(uint index, int x) => instance.glVertexAttribI1iEXT(index, x);
        
        static unsafe void glVertexAttribI1iv(uint index, int * v) => instance.glVertexAttribI1iv(index, v);
        
        static unsafe void glVertexAttribI1ivEXT(uint index, int * v) => instance.glVertexAttribI1ivEXT(index, v);
        
        static unsafe void glVertexAttribI1ui(uint index, uint x) => instance.glVertexAttribI1ui(index, x);
        
        static unsafe void glVertexAttribI1uiEXT(uint index, uint x) => instance.glVertexAttribI1uiEXT(index, x);
        
        static unsafe void glVertexAttribI1uiv(uint index, uint * v) => instance.glVertexAttribI1uiv(index, v);
        
        static unsafe void glVertexAttribI1uivEXT(uint index, uint * v) => instance.glVertexAttribI1uivEXT(index, v);
        
        static unsafe void glVertexAttribI2i(uint index, int x, int y) => instance.glVertexAttribI2i(index, x, y);
        
        static unsafe void glVertexAttribI2iEXT(uint index, int x, int y) => instance.glVertexAttribI2iEXT(index, x, y);
        
        static unsafe void glVertexAttribI2iv(uint index, int * v) => instance.glVertexAttribI2iv(index, v);
        
        static unsafe void glVertexAttribI2ivEXT(uint index, int * v) => instance.glVertexAttribI2ivEXT(index, v);
        
        static unsafe void glVertexAttribI2ui(uint index, uint x, uint y) => instance.glVertexAttribI2ui(index, x, y);
        
        static unsafe void glVertexAttribI2uiEXT(uint index, uint x, uint y) => instance.glVertexAttribI2uiEXT(index, x, y);
        
        static unsafe void glVertexAttribI2uiv(uint index, uint * v) => instance.glVertexAttribI2uiv(index, v);
        
        static unsafe void glVertexAttribI2uivEXT(uint index, uint * v) => instance.glVertexAttribI2uivEXT(index, v);
        
        static unsafe void glVertexAttribI3i(uint index, int x, int y, int z) => instance.glVertexAttribI3i(index, x, y, z);
        
        static unsafe void glVertexAttribI3iEXT(uint index, int x, int y, int z) => instance.glVertexAttribI3iEXT(index, x, y, z);
        
        static unsafe void glVertexAttribI3iv(uint index, int * v) => instance.glVertexAttribI3iv(index, v);
        
        static unsafe void glVertexAttribI3ivEXT(uint index, int * v) => instance.glVertexAttribI3ivEXT(index, v);
        
        static unsafe void glVertexAttribI3ui(uint index, uint x, uint y, uint z) => instance.glVertexAttribI3ui(index, x, y, z);
        
        static unsafe void glVertexAttribI3uiEXT(uint index, uint x, uint y, uint z) => instance.glVertexAttribI3uiEXT(index, x, y, z);
        
        static unsafe void glVertexAttribI3uiv(uint index, uint * v) => instance.glVertexAttribI3uiv(index, v);
        
        static unsafe void glVertexAttribI3uivEXT(uint index, uint * v) => instance.glVertexAttribI3uivEXT(index, v);
        
        static unsafe void glVertexAttribI4bv(uint index, sbyte * v) => instance.glVertexAttribI4bv(index, v);
        
        static unsafe void glVertexAttribI4bvEXT(uint index, sbyte * v) => instance.glVertexAttribI4bvEXT(index, v);
        
        static unsafe void glVertexAttribI4i(uint index, int x, int y, int z, int w) => instance.glVertexAttribI4i(index, x, y, z, w);
        
        static unsafe void glVertexAttribI4iEXT(uint index, int x, int y, int z, int w) => instance.glVertexAttribI4iEXT(index, x, y, z, w);
        
        static unsafe void glVertexAttribI4iv(uint index, int * v) => instance.glVertexAttribI4iv(index, v);
        
        static unsafe void glVertexAttribI4ivEXT(uint index, int * v) => instance.glVertexAttribI4ivEXT(index, v);
        
        static unsafe void glVertexAttribI4sv(uint index, short * v) => instance.glVertexAttribI4sv(index, v);
        
        static unsafe void glVertexAttribI4svEXT(uint index, short * v) => instance.glVertexAttribI4svEXT(index, v);
        
        static unsafe void glVertexAttribI4ubv(uint index, byte * v) => instance.glVertexAttribI4ubv(index, v);
        
        static unsafe void glVertexAttribI4ubvEXT(uint index, byte * v) => instance.glVertexAttribI4ubvEXT(index, v);
        
        static unsafe void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => instance.glVertexAttribI4ui(index, x, y, z, w);
        
        static unsafe void glVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w) => instance.glVertexAttribI4uiEXT(index, x, y, z, w);
        
        static unsafe void glVertexAttribI4uiv(uint index, uint * v) => instance.glVertexAttribI4uiv(index, v);
        
        static unsafe void glVertexAttribI4uivEXT(uint index, uint * v) => instance.glVertexAttribI4uivEXT(index, v);
        
        static unsafe void glVertexAttribI4usv(uint index, ushort * v) => instance.glVertexAttribI4usv(index, v);
        
        static unsafe void glVertexAttribI4usvEXT(uint index, ushort * v) => instance.glVertexAttribI4usvEXT(index, v);
        
        static unsafe void glVertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset) => instance.glVertexAttribIFormat(attribindex, size, type, relativeoffset);
        
        static unsafe void glVertexAttribIFormatNV(uint index, int size, VertexAttribIType type, uint stride) => instance.glVertexAttribIFormatNV(index, size, type, stride);
        
        static unsafe void glVertexAttribIPointer(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer) => instance.glVertexAttribIPointer(index, size, type, stride, pointer);
        
        static unsafe void glVertexAttribIPointerEXT(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer) => instance.glVertexAttribIPointerEXT(index, size, type, stride, pointer);
        
        static unsafe void glVertexAttribL1d(uint index, double x) => instance.glVertexAttribL1d(index, x);
        
        static unsafe void glVertexAttribL1dEXT(uint index, double x) => instance.glVertexAttribL1dEXT(index, x);
        
        static unsafe void glVertexAttribL1dv(uint index, double * v) => instance.glVertexAttribL1dv(index, v);
        
        static unsafe void glVertexAttribL1dvEXT(uint index, double * v) => instance.glVertexAttribL1dvEXT(index, v);
        
        static unsafe void glVertexAttribL1i64NV(uint index, long x) => instance.glVertexAttribL1i64NV(index, x);
        
        static unsafe void glVertexAttribL1i64vNV(uint index, long * v) => instance.glVertexAttribL1i64vNV(index, v);
        
        static unsafe void glVertexAttribL1ui64ARB(uint index, ulong x) => instance.glVertexAttribL1ui64ARB(index, x);
        
        static unsafe void glVertexAttribL1ui64NV(uint index, ulong x) => instance.glVertexAttribL1ui64NV(index, x);
        
        static unsafe void glVertexAttribL1ui64vARB(uint index, ulong * v) => instance.glVertexAttribL1ui64vARB(index, v);
        
        static unsafe void glVertexAttribL1ui64vNV(uint index, ulong * v) => instance.glVertexAttribL1ui64vNV(index, v);
        
        static unsafe void glVertexAttribL2d(uint index, double x, double y) => instance.glVertexAttribL2d(index, x, y);
        
        static unsafe void glVertexAttribL2dEXT(uint index, double x, double y) => instance.glVertexAttribL2dEXT(index, x, y);
        
        static unsafe void glVertexAttribL2dv(uint index, double * v) => instance.glVertexAttribL2dv(index, v);
        
        static unsafe void glVertexAttribL2dvEXT(uint index, double * v) => instance.glVertexAttribL2dvEXT(index, v);
        
        static unsafe void glVertexAttribL2i64NV(uint index, long x, long y) => instance.glVertexAttribL2i64NV(index, x, y);
        
        static unsafe void glVertexAttribL2i64vNV(uint index, long * v) => instance.glVertexAttribL2i64vNV(index, v);
        
        static unsafe void glVertexAttribL2ui64NV(uint index, ulong x, ulong y) => instance.glVertexAttribL2ui64NV(index, x, y);
        
        static unsafe void glVertexAttribL2ui64vNV(uint index, ulong * v) => instance.glVertexAttribL2ui64vNV(index, v);
        
        static unsafe void glVertexAttribL3d(uint index, double x, double y, double z) => instance.glVertexAttribL3d(index, x, y, z);
        
        static unsafe void glVertexAttribL3dEXT(uint index, double x, double y, double z) => instance.glVertexAttribL3dEXT(index, x, y, z);
        
        static unsafe void glVertexAttribL3dv(uint index, double * v) => instance.glVertexAttribL3dv(index, v);
        
        static unsafe void glVertexAttribL3dvEXT(uint index, double * v) => instance.glVertexAttribL3dvEXT(index, v);
        
        static unsafe void glVertexAttribL3i64NV(uint index, long x, long y, long z) => instance.glVertexAttribL3i64NV(index, x, y, z);
        
        static unsafe void glVertexAttribL3i64vNV(uint index, long * v) => instance.glVertexAttribL3i64vNV(index, v);
        
        static unsafe void glVertexAttribL3ui64NV(uint index, ulong x, ulong y, ulong z) => instance.glVertexAttribL3ui64NV(index, x, y, z);
        
        static unsafe void glVertexAttribL3ui64vNV(uint index, ulong * v) => instance.glVertexAttribL3ui64vNV(index, v);
        
        static unsafe void glVertexAttribL4d(uint index, double x, double y, double z, double w) => instance.glVertexAttribL4d(index, x, y, z, w);
        
        static unsafe void glVertexAttribL4dEXT(uint index, double x, double y, double z, double w) => instance.glVertexAttribL4dEXT(index, x, y, z, w);
        
        static unsafe void glVertexAttribL4dv(uint index, double * v) => instance.glVertexAttribL4dv(index, v);
        
        static unsafe void glVertexAttribL4dvEXT(uint index, double * v) => instance.glVertexAttribL4dvEXT(index, v);
        
        static unsafe void glVertexAttribL4i64NV(uint index, long x, long y, long z, long w) => instance.glVertexAttribL4i64NV(index, x, y, z, w);
        
        static unsafe void glVertexAttribL4i64vNV(uint index, long * v) => instance.glVertexAttribL4i64vNV(index, v);
        
        static unsafe void glVertexAttribL4ui64NV(uint index, ulong x, ulong y, ulong z, ulong w) => instance.glVertexAttribL4ui64NV(index, x, y, z, w);
        
        static unsafe void glVertexAttribL4ui64vNV(uint index, ulong * v) => instance.glVertexAttribL4ui64vNV(index, v);
        
        static unsafe void glVertexAttribLFormat(uint attribindex, int size, VertexAttribLType type, uint relativeoffset) => instance.glVertexAttribLFormat(attribindex, size, type, relativeoffset);
        
        static unsafe void glVertexAttribLFormatNV(uint index, int size, VertexAttribLType type, uint stride) => instance.glVertexAttribLFormatNV(index, size, type, stride);
        
        static unsafe void glVertexAttribLPointer(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer) => instance.glVertexAttribLPointer(index, size, type, stride, pointer);
        
        static unsafe void glVertexAttribLPointerEXT(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer) => instance.glVertexAttribLPointerEXT(index, size, type, stride, pointer);
        
        static unsafe void glVertexAttribP1ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => instance.glVertexAttribP1ui(index, type, normalized, value);
        
        static unsafe void glVertexAttribP1uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value) => instance.glVertexAttribP1uiv(index, type, normalized, value);
        
        static unsafe void glVertexAttribP2ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => instance.glVertexAttribP2ui(index, type, normalized, value);
        
        static unsafe void glVertexAttribP2uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value) => instance.glVertexAttribP2uiv(index, type, normalized, value);
        
        static unsafe void glVertexAttribP3ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => instance.glVertexAttribP3ui(index, type, normalized, value);
        
        static unsafe void glVertexAttribP3uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value) => instance.glVertexAttribP3uiv(index, type, normalized, value);
        
        static unsafe void glVertexAttribP4ui(uint index, VertexAttribPointerType type, bool normalized, uint value) => instance.glVertexAttribP4ui(index, type, normalized, value);
        
        static unsafe void glVertexAttribP4uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value) => instance.glVertexAttribP4uiv(index, type, normalized, value);
        
        static unsafe void glVertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, void * pointer) => instance.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
        
        static unsafe void glVertexAttribPointerARB(uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, void * pointer) => instance.glVertexAttribPointerARB(index, size, type, normalized, stride, pointer);
        
        static unsafe void glVertexAttribPointerNV(uint index, int fsize, VertexAttribEnumNV type, uint stride, void * pointer) => instance.glVertexAttribPointerNV(index, fsize, type, stride, pointer);
        
        static unsafe void glVertexAttribs1dvNV(uint index, uint count, double * v) => instance.glVertexAttribs1dvNV(index, count, v);
        
        static unsafe void glVertexAttribs1fvNV(uint index, uint count, float * v) => instance.glVertexAttribs1fvNV(index, count, v);
        
        static unsafe void glVertexAttribs1hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttribs1hvNV(index, n, v);
        
        static unsafe void glVertexAttribs1svNV(uint index, uint count, short * v) => instance.glVertexAttribs1svNV(index, count, v);
        
        static unsafe void glVertexAttribs2dvNV(uint index, uint count, double * v) => instance.glVertexAttribs2dvNV(index, count, v);
        
        static unsafe void glVertexAttribs2fvNV(uint index, uint count, float * v) => instance.glVertexAttribs2fvNV(index, count, v);
        
        static unsafe void glVertexAttribs2hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttribs2hvNV(index, n, v);
        
        static unsafe void glVertexAttribs2svNV(uint index, uint count, short * v) => instance.glVertexAttribs2svNV(index, count, v);
        
        static unsafe void glVertexAttribs3dvNV(uint index, uint count, double * v) => instance.glVertexAttribs3dvNV(index, count, v);
        
        static unsafe void glVertexAttribs3fvNV(uint index, uint count, float * v) => instance.glVertexAttribs3fvNV(index, count, v);
        
        static unsafe void glVertexAttribs3hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttribs3hvNV(index, n, v);
        
        static unsafe void glVertexAttribs3svNV(uint index, uint count, short * v) => instance.glVertexAttribs3svNV(index, count, v);
        
        static unsafe void glVertexAttribs4dvNV(uint index, uint count, double * v) => instance.glVertexAttribs4dvNV(index, count, v);
        
        static unsafe void glVertexAttribs4fvNV(uint index, uint count, float * v) => instance.glVertexAttribs4fvNV(index, count, v);
        
        static unsafe void glVertexAttribs4hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v) => instance.glVertexAttribs4hvNV(index, n, v);
        
        static unsafe void glVertexAttribs4svNV(uint index, uint count, short * v) => instance.glVertexAttribs4svNV(index, count, v);
        
        static unsafe void glVertexAttribs4ubvNV(uint index, uint count, byte * v) => instance.glVertexAttribs4ubvNV(index, count, v);
        
        static unsafe void glVertexBindingDivisor(uint bindingindex, uint divisor) => instance.glVertexBindingDivisor(bindingindex, divisor);
        
        static unsafe void glVertexBlendARB(int count) => instance.glVertexBlendARB(count);
        
        static unsafe void glVertexBlendEnvfATI(VertexStreamATI pname, float param) => instance.glVertexBlendEnvfATI(pname, param);
        
        static unsafe void glVertexBlendEnviATI(VertexStreamATI pname, int param) => instance.glVertexBlendEnviATI(pname, param);
        
        static unsafe void glVertexFormatNV(int size, VertexPointerType type, uint stride) => instance.glVertexFormatNV(size, type, stride);
        
        static unsafe void glVertexP2ui(VertexPointerType type, uint value) => instance.glVertexP2ui(type, value);
        
        static unsafe void glVertexP2uiv(VertexPointerType type, uint * value) => instance.glVertexP2uiv(type, value);
        
        static unsafe void glVertexP3ui(VertexPointerType type, uint value) => instance.glVertexP3ui(type, value);
        
        static unsafe void glVertexP3uiv(VertexPointerType type, uint * value) => instance.glVertexP3uiv(type, value);
        
        static unsafe void glVertexP4ui(VertexPointerType type, uint value) => instance.glVertexP4ui(type, value);
        
        static unsafe void glVertexP4uiv(VertexPointerType type, uint * value) => instance.glVertexP4uiv(type, value);
        
        static unsafe void glVertexPointer(int size, VertexPointerType type, uint stride, void * pointer) => instance.glVertexPointer(size, type, stride, pointer);
        
        static unsafe void glVertexPointerEXT(int size, VertexPointerType type, uint stride, uint count, void * pointer) => instance.glVertexPointerEXT(size, type, stride, count, pointer);
        
        static unsafe void glVertexPointerListIBM(int size, VertexPointerType type, int stride, void * * pointer, int ptrstride) => instance.glVertexPointerListIBM(size, type, stride, pointer, ptrstride);
        
        static unsafe void glVertexPointervINTEL(int size, VertexPointerType type, void * * pointer) => instance.glVertexPointervINTEL(size, type, pointer);
        
        static unsafe void glVertexStream1dATI(VertexStreamATI stream, double x) => instance.glVertexStream1dATI(stream, x);
        
        static unsafe void glVertexStream1dvATI(VertexStreamATI stream, double * coords) => instance.glVertexStream1dvATI(stream, coords);
        
        static unsafe void glVertexStream1fATI(VertexStreamATI stream, float x) => instance.glVertexStream1fATI(stream, x);
        
        static unsafe void glVertexStream1fvATI(VertexStreamATI stream, float * coords) => instance.glVertexStream1fvATI(stream, coords);
        
        static unsafe void glVertexStream1iATI(VertexStreamATI stream, int x) => instance.glVertexStream1iATI(stream, x);
        
        static unsafe void glVertexStream1ivATI(VertexStreamATI stream, int * coords) => instance.glVertexStream1ivATI(stream, coords);
        
        static unsafe void glVertexStream1sATI(VertexStreamATI stream, short x) => instance.glVertexStream1sATI(stream, x);
        
        static unsafe void glVertexStream1svATI(VertexStreamATI stream, short * coords) => instance.glVertexStream1svATI(stream, coords);
        
        static unsafe void glVertexStream2dATI(VertexStreamATI stream, double x, double y) => instance.glVertexStream2dATI(stream, x, y);
        
        static unsafe void glVertexStream2dvATI(VertexStreamATI stream, double * coords) => instance.glVertexStream2dvATI(stream, coords);
        
        static unsafe void glVertexStream2fATI(VertexStreamATI stream, float x, float y) => instance.glVertexStream2fATI(stream, x, y);
        
        static unsafe void glVertexStream2fvATI(VertexStreamATI stream, float * coords) => instance.glVertexStream2fvATI(stream, coords);
        
        static unsafe void glVertexStream2iATI(VertexStreamATI stream, int x, int y) => instance.glVertexStream2iATI(stream, x, y);
        
        static unsafe void glVertexStream2ivATI(VertexStreamATI stream, int * coords) => instance.glVertexStream2ivATI(stream, coords);
        
        static unsafe void glVertexStream2sATI(VertexStreamATI stream, short x, short y) => instance.glVertexStream2sATI(stream, x, y);
        
        static unsafe void glVertexStream2svATI(VertexStreamATI stream, short * coords) => instance.glVertexStream2svATI(stream, coords);
        
        static unsafe void glVertexStream3dATI(VertexStreamATI stream, double x, double y, double z) => instance.glVertexStream3dATI(stream, x, y, z);
        
        static unsafe void glVertexStream3dvATI(VertexStreamATI stream, double * coords) => instance.glVertexStream3dvATI(stream, coords);
        
        static unsafe void glVertexStream3fATI(VertexStreamATI stream, float x, float y, float z) => instance.glVertexStream3fATI(stream, x, y, z);
        
        static unsafe void glVertexStream3fvATI(VertexStreamATI stream, float * coords) => instance.glVertexStream3fvATI(stream, coords);
        
        static unsafe void glVertexStream3iATI(VertexStreamATI stream, int x, int y, int z) => instance.glVertexStream3iATI(stream, x, y, z);
        
        static unsafe void glVertexStream3ivATI(VertexStreamATI stream, int * coords) => instance.glVertexStream3ivATI(stream, coords);
        
        static unsafe void glVertexStream3sATI(VertexStreamATI stream, short x, short y, short z) => instance.glVertexStream3sATI(stream, x, y, z);
        
        static unsafe void glVertexStream3svATI(VertexStreamATI stream, short * coords) => instance.glVertexStream3svATI(stream, coords);
        
        static unsafe void glVertexStream4dATI(VertexStreamATI stream, double x, double y, double z, double w) => instance.glVertexStream4dATI(stream, x, y, z, w);
        
        static unsafe void glVertexStream4dvATI(VertexStreamATI stream, double * coords) => instance.glVertexStream4dvATI(stream, coords);
        
        static unsafe void glVertexStream4fATI(VertexStreamATI stream, float x, float y, float z, float w) => instance.glVertexStream4fATI(stream, x, y, z, w);
        
        static unsafe void glVertexStream4fvATI(VertexStreamATI stream, float * coords) => instance.glVertexStream4fvATI(stream, coords);
        
        static unsafe void glVertexStream4iATI(VertexStreamATI stream, int x, int y, int z, int w) => instance.glVertexStream4iATI(stream, x, y, z, w);
        
        static unsafe void glVertexStream4ivATI(VertexStreamATI stream, int * coords) => instance.glVertexStream4ivATI(stream, coords);
        
        static unsafe void glVertexStream4sATI(VertexStreamATI stream, short x, short y, short z, short w) => instance.glVertexStream4sATI(stream, x, y, z, w);
        
        static unsafe void glVertexStream4svATI(VertexStreamATI stream, short * coords) => instance.glVertexStream4svATI(stream, coords);
        
        static unsafe void glVertexWeightPointerEXT(int size, VertexWeightPointerTypeEXT type, uint stride, void * pointer) => instance.glVertexWeightPointerEXT(size, type, stride, pointer);
        
        static unsafe void glVertexWeightfEXT(float weight) => instance.glVertexWeightfEXT(weight);
        
        static unsafe void glVertexWeightfvEXT(float * weight) => instance.glVertexWeightfvEXT(weight);
        
        static unsafe void glVertexWeighthNV(OpenToolkit.Mathematics.Half weight) => instance.glVertexWeighthNV(weight);
        
        static unsafe void glVertexWeighthvNV(OpenToolkit.Mathematics.Half * weight) => instance.glVertexWeighthvNV(weight);
        
        static unsafe void glViewport(int x, int y, uint width, uint height) => instance.glViewport(x, y, width, height);
        
        static unsafe void glViewportArrayv(uint first, uint count, float * v) => instance.glViewportArrayv(first, count, v);
        
        static unsafe void glViewportArrayvNV(uint first, uint count, float * v) => instance.glViewportArrayvNV(first, count, v);
        
        static unsafe void glViewportArrayvOES(uint first, uint count, float * v) => instance.glViewportArrayvOES(first, count, v);
        
        static unsafe void glViewportIndexedf(uint index, float x, float y, float w, float h) => instance.glViewportIndexedf(index, x, y, w, h);
        
        static unsafe void glViewportIndexedfOES(uint index, float x, float y, float w, float h) => instance.glViewportIndexedfOES(index, x, y, w, h);
        
        static unsafe void glViewportIndexedfNV(uint index, float x, float y, float w, float h) => instance.glViewportIndexedfNV(index, x, y, w, h);
        
        static unsafe void glViewportIndexedfv(uint index, float * v) => instance.glViewportIndexedfv(index, v);
        
        static unsafe void glViewportIndexedfvOES(uint index, float * v) => instance.glViewportIndexedfvOES(index, v);
        
        static unsafe void glViewportIndexedfvNV(uint index, float * v) => instance.glViewportIndexedfvNV(index, v);
        
        static unsafe void glViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff) => instance.glViewportPositionWScaleNV(index, xcoeff, ycoeff);
        
        static unsafe void glWaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint * buffers, uint numTextureBarriers, uint * textures, TextureLayout * srcLayouts) => instance.glWaitSemaphoreEXT(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);
        
        static unsafe void glWaitSemaphoreui64NVX(uint waitGpu, uint fenceObjectCount, uint * semaphoreArray, ulong * fenceValueArray) => instance.glWaitSemaphoreui64NVX(waitGpu, fenceObjectCount, semaphoreArray, fenceValueArray);
        
        static unsafe void glWaitSync(IntPtr sync, uint flags, ulong timeout) => instance.glWaitSync(sync, flags, timeout);
        
        static unsafe void glWaitSyncAPPLE(IntPtr sync, uint flags, ulong timeout) => instance.glWaitSyncAPPLE(sync, flags, timeout);
        
        static unsafe void glWeightPathsNV(uint resultPath, uint numPaths, uint * paths, float * weights) => instance.glWeightPathsNV(resultPath, numPaths, paths, weights);
        
        static unsafe void glWeightPointerARB(int size, WeightPointerTypeARB type, uint stride, void * pointer) => instance.glWeightPointerARB(size, type, stride, pointer);
        
        static unsafe void glWeightbvARB(int size, sbyte * weights) => instance.glWeightbvARB(size, weights);
        
        static unsafe void glWeightdvARB(int size, double * weights) => instance.glWeightdvARB(size, weights);
        
        static unsafe void glWeightfvARB(int size, float * weights) => instance.glWeightfvARB(size, weights);
        
        static unsafe void glWeightivARB(int size, int * weights) => instance.glWeightivARB(size, weights);
        
        static unsafe void glWeightsvARB(int size, short * weights) => instance.glWeightsvARB(size, weights);
        
        static unsafe void glWeightubvARB(int size, byte * weights) => instance.glWeightubvARB(size, weights);
        
        static unsafe void glWeightuivARB(int size, uint * weights) => instance.glWeightuivARB(size, weights);
        
        static unsafe void glWeightusvARB(int size, ushort * weights) => instance.glWeightusvARB(size, weights);
        
        static unsafe void glWindowPos2d(double x, double y) => instance.glWindowPos2d(x, y);
        
        static unsafe void glWindowPos2dARB(double x, double y) => instance.glWindowPos2dARB(x, y);
        
        static unsafe void glWindowPos2dMESA(double x, double y) => instance.glWindowPos2dMESA(x, y);
        
        static unsafe void glWindowPos2dv(double * v) => instance.glWindowPos2dv(v);
        
        static unsafe void glWindowPos2dvARB(double * v) => instance.glWindowPos2dvARB(v);
        
        static unsafe void glWindowPos2dvMESA(double * v) => instance.glWindowPos2dvMESA(v);
        
        static unsafe void glWindowPos2f(float x, float y) => instance.glWindowPos2f(x, y);
        
        static unsafe void glWindowPos2fARB(float x, float y) => instance.glWindowPos2fARB(x, y);
        
        static unsafe void glWindowPos2fMESA(float x, float y) => instance.glWindowPos2fMESA(x, y);
        
        static unsafe void glWindowPos2fv(float * v) => instance.glWindowPos2fv(v);
        
        static unsafe void glWindowPos2fvARB(float * v) => instance.glWindowPos2fvARB(v);
        
        static unsafe void glWindowPos2fvMESA(float * v) => instance.glWindowPos2fvMESA(v);
        
        static unsafe void glWindowPos2i(int x, int y) => instance.glWindowPos2i(x, y);
        
        static unsafe void glWindowPos2iARB(int x, int y) => instance.glWindowPos2iARB(x, y);
        
        static unsafe void glWindowPos2iMESA(int x, int y) => instance.glWindowPos2iMESA(x, y);
        
        static unsafe void glWindowPos2iv(int * v) => instance.glWindowPos2iv(v);
        
        static unsafe void glWindowPos2ivARB(int * v) => instance.glWindowPos2ivARB(v);
        
        static unsafe void glWindowPos2ivMESA(int * v) => instance.glWindowPos2ivMESA(v);
        
        static unsafe void glWindowPos2s(short x, short y) => instance.glWindowPos2s(x, y);
        
        static unsafe void glWindowPos2sARB(short x, short y) => instance.glWindowPos2sARB(x, y);
        
        static unsafe void glWindowPos2sMESA(short x, short y) => instance.glWindowPos2sMESA(x, y);
        
        static unsafe void glWindowPos2sv(short * v) => instance.glWindowPos2sv(v);
        
        static unsafe void glWindowPos2svARB(short * v) => instance.glWindowPos2svARB(v);
        
        static unsafe void glWindowPos2svMESA(short * v) => instance.glWindowPos2svMESA(v);
        
        static unsafe void glWindowPos3d(double x, double y, double z) => instance.glWindowPos3d(x, y, z);
        
        static unsafe void glWindowPos3dARB(double x, double y, double z) => instance.glWindowPos3dARB(x, y, z);
        
        static unsafe void glWindowPos3dMESA(double x, double y, double z) => instance.glWindowPos3dMESA(x, y, z);
        
        static unsafe void glWindowPos3dv(double * v) => instance.glWindowPos3dv(v);
        
        static unsafe void glWindowPos3dvARB(double * v) => instance.glWindowPos3dvARB(v);
        
        static unsafe void glWindowPos3dvMESA(double * v) => instance.glWindowPos3dvMESA(v);
        
        static unsafe void glWindowPos3f(float x, float y, float z) => instance.glWindowPos3f(x, y, z);
        
        static unsafe void glWindowPos3fARB(float x, float y, float z) => instance.glWindowPos3fARB(x, y, z);
        
        static unsafe void glWindowPos3fMESA(float x, float y, float z) => instance.glWindowPos3fMESA(x, y, z);
        
        static unsafe void glWindowPos3fv(float * v) => instance.glWindowPos3fv(v);
        
        static unsafe void glWindowPos3fvARB(float * v) => instance.glWindowPos3fvARB(v);
        
        static unsafe void glWindowPos3fvMESA(float * v) => instance.glWindowPos3fvMESA(v);
        
        static unsafe void glWindowPos3i(int x, int y, int z) => instance.glWindowPos3i(x, y, z);
        
        static unsafe void glWindowPos3iARB(int x, int y, int z) => instance.glWindowPos3iARB(x, y, z);
        
        static unsafe void glWindowPos3iMESA(int x, int y, int z) => instance.glWindowPos3iMESA(x, y, z);
        
        static unsafe void glWindowPos3iv(int * v) => instance.glWindowPos3iv(v);
        
        static unsafe void glWindowPos3ivARB(int * v) => instance.glWindowPos3ivARB(v);
        
        static unsafe void glWindowPos3ivMESA(int * v) => instance.glWindowPos3ivMESA(v);
        
        static unsafe void glWindowPos3s(short x, short y, short z) => instance.glWindowPos3s(x, y, z);
        
        static unsafe void glWindowPos3sARB(short x, short y, short z) => instance.glWindowPos3sARB(x, y, z);
        
        static unsafe void glWindowPos3sMESA(short x, short y, short z) => instance.glWindowPos3sMESA(x, y, z);
        
        static unsafe void glWindowPos3sv(short * v) => instance.glWindowPos3sv(v);
        
        static unsafe void glWindowPos3svARB(short * v) => instance.glWindowPos3svARB(v);
        
        static unsafe void glWindowPos3svMESA(short * v) => instance.glWindowPos3svMESA(v);
        
        static unsafe void glWindowPos4dMESA(double x, double y, double z, double w) => instance.glWindowPos4dMESA(x, y, z, w);
        
        static unsafe void glWindowPos4dvMESA(double * v) => instance.glWindowPos4dvMESA(v);
        
        static unsafe void glWindowPos4fMESA(float x, float y, float z, float w) => instance.glWindowPos4fMESA(x, y, z, w);
        
        static unsafe void glWindowPos4fvMESA(float * v) => instance.glWindowPos4fvMESA(v);
        
        static unsafe void glWindowPos4iMESA(int x, int y, int z, int w) => instance.glWindowPos4iMESA(x, y, z, w);
        
        static unsafe void glWindowPos4ivMESA(int * v) => instance.glWindowPos4ivMESA(v);
        
        static unsafe void glWindowPos4sMESA(short x, short y, short z, short w) => instance.glWindowPos4sMESA(x, y, z, w);
        
        static unsafe void glWindowPos4svMESA(short * v) => instance.glWindowPos4svMESA(v);
        
        static unsafe void glWriteMaskEXT(uint res, uint IN, VertexShaderWriteMaskEXT outX, VertexShaderWriteMaskEXT outY, VertexShaderWriteMaskEXT outZ, VertexShaderWriteMaskEXT outW) => instance.glWriteMaskEXT(res, IN, outX, outY, outZ, outW);
        
        static unsafe void glDrawVkImageNV(ulong vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1) => instance.glDrawVkImageNV(vkImage, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
        
        static unsafe void glWaitVkSemaphoreNV(ulong vkSemaphore) => instance.glWaitVkSemaphoreNV(vkSemaphore);
        
        static unsafe void glSignalVkSemaphoreNV(ulong vkSemaphore) => instance.glSignalVkSemaphoreNV(vkSemaphore);
        
        static unsafe void glSignalVkFenceNV(ulong vkFence) => instance.glSignalVkFenceNV(vkFence);
        
    }
}
