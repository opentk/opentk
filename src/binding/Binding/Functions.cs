using System;

namespace FooBar
{
    public interface IGL
    {
        unsafe void glAccum(AccumOp op, float value);
        
        unsafe void glActiveProgramEXT(uint program);
        
        unsafe void glActiveShaderProgram(uint pipeline, uint program);
        
        unsafe void glActiveShaderProgramEXT(uint pipeline, uint program);
        
        unsafe void glActiveStencilFaceEXT(StencilFaceDirection face);
        
        unsafe void glActiveTexture(TextureUnit texture);
        
        unsafe void glActiveTextureARB(TextureUnit texture);
        
        unsafe void glActiveVaryingNV(uint program, char * name);
        
        unsafe void glAlphaFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        
        unsafe void glAlphaFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        
        unsafe void glAlphaFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        
        unsafe void glAlphaFunc(AlphaFunction func, float REF);
        
        unsafe void glAlphaFuncx(AlphaFunction func, int REF);
        
        unsafe void glAlphaFuncxOES(AlphaFunction func, int REF);
        
        unsafe void glApplyFramebufferAttachmentCMAAINTEL();
        
        unsafe void glApplyTextureEXT(LightTextureModeEXT mode);
        
        unsafe bool glAcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout);
        
        unsafe bool glAreProgramsResidentNV(uint n, uint * programs, bool * residences);
        
        unsafe bool glAreTexturesResident(uint n, uint * textures, bool * residences);
        
        unsafe bool glAreTexturesResidentEXT(uint n, uint * textures, bool * residences);
        
        unsafe void glArrayElement(int i);
        
        unsafe void glArrayElementEXT(int i);
        
        unsafe void glArrayObjectATI(EnableCap array, int size, ScalarType type, uint stride, uint buffer, uint offset);
        
        unsafe uint glAsyncCopyBufferSubDataNVX(uint waitSemaphoreCount, uint * waitSemaphoreArray, ulong * fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size, uint signalSemaphoreCount, uint * signalSemaphoreArray, ulong * signalValueArray);
        
        unsafe void glAsyncMarkerSGIX(uint marker);
        
        unsafe void glAttachObjectARB(uint containerObj, uint obj);
        
        unsafe void glAttachShader(uint program, uint shader);
        
        unsafe void glBegin(PrimitiveType mode);
        
        unsafe void glBeginConditionalRender(uint id, ConditionalRenderMode mode);
        
        unsafe void glBeginConditionalRenderNV(uint id, ConditionalRenderMode mode);
        
        unsafe void glBeginConditionalRenderNVX(uint id);
        
        unsafe void glBeginFragmentShaderATI();
        
        unsafe void glBeginOcclusionQueryNV(uint id);
        
        unsafe void glBeginPerfMonitorAMD(uint monitor);
        
        unsafe void glBeginPerfQueryINTEL(uint queryHandle);
        
        unsafe void glBeginQuery(QueryTarget target, uint id);
        
        unsafe void glBeginQueryEXT(QueryTarget target, uint id);
        
        unsafe void glBeginQueryIndexed(QueryTarget target, uint index, uint id);
        
        unsafe void glBeginTransformFeedback(PrimitiveType primitiveMode);
        
        unsafe void glBeginTransformFeedbackEXT(PrimitiveType primitiveMode);
        
        unsafe void glBeginTransformFeedbackNV(PrimitiveType primitiveMode);
        
        unsafe void glBeginVertexShaderEXT();
        
        unsafe void glBeginVideoCaptureNV(uint video_capture_slot);
        
        unsafe void glBindAttribLocation(uint program, uint index, char * name);
        
        unsafe void glBindAttribLocationARB(uint programObj, uint index, char * name);
        
        unsafe void glBindBuffer(BufferTargetARB target, uint buffer);
        
        unsafe void glBindBufferARB(BufferTargetARB target, uint buffer);
        
        unsafe void glBindBufferBase(BufferTargetARB target, uint index, uint buffer);
        
        unsafe void glBindBufferBaseEXT(BufferTargetARB target, uint index, uint buffer);
        
        unsafe void glBindBufferBaseNV(BufferTargetARB target, uint index, uint buffer);
        
        unsafe void glBindBufferOffsetEXT(BufferTargetARB target, uint index, uint buffer, IntPtr offset);
        
        unsafe void glBindBufferOffsetNV(BufferTargetARB target, uint index, uint buffer, IntPtr offset);
        
        unsafe void glBindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glBindBufferRangeEXT(BufferTargetARB target, uint index, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glBindBufferRangeNV(BufferTargetARB target, uint index, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glBindBuffersBase(BufferTargetARB target, uint first, uint count, uint * buffers);
        
        unsafe void glBindBuffersRange(BufferTargetARB target, uint first, uint count, uint * buffers, IntPtr * offsets, UIntPtr * sizes);
        
        unsafe void glBindFragDataLocation(uint program, uint color, char * name);
        
        unsafe void glBindFragDataLocationEXT(uint program, uint color, char * name);
        
        unsafe void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char * name);
        
        unsafe void glBindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, char * name);
        
        unsafe void glBindFragmentShaderATI(uint id);
        
        unsafe void glBindFramebuffer(FramebufferTarget target, uint framebuffer);
        
        unsafe void glBindFramebufferEXT(FramebufferTarget target, uint framebuffer);
        
        unsafe void glBindFramebufferOES(FramebufferTarget target, uint framebuffer);
        
        unsafe void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, BufferAccessARB access, InternalFormat format);
        
        unsafe void glBindImageTextureEXT(uint index, uint texture, int level, bool layered, int layer, BufferAccessARB access, int format);
        
        unsafe void glBindImageTextures(uint first, uint count, uint * textures);
        
        unsafe uint glBindLightParameterEXT(LightName light, LightParameter value);
        
        unsafe uint glBindMaterialParameterEXT(MaterialFace face, MaterialParameter value);
        
        unsafe void glBindMultiTextureEXT(TextureUnit texunit, TextureTarget target, uint texture);
        
        unsafe uint glBindParameterEXT(VertexShaderParameterEXT value);
        
        unsafe void glBindProgramARB(ProgramTargetARB target, uint program);
        
        unsafe void glBindProgramNV(VertexAttribEnumNV target, uint id);
        
        unsafe void glBindProgramPipeline(uint pipeline);
        
        unsafe void glBindProgramPipelineEXT(uint pipeline);
        
        unsafe void glBindRenderbuffer(RenderbufferTarget target, uint renderbuffer);
        
        unsafe void glBindRenderbufferEXT(RenderbufferTarget target, uint renderbuffer);
        
        unsafe void glBindRenderbufferOES(RenderbufferTarget target, uint renderbuffer);
        
        unsafe void glBindSampler(uint unit, uint sampler);
        
        unsafe void glBindSamplers(uint first, uint count, uint * samplers);
        
        unsafe void glBindShadingRateImageNV(uint texture);
        
        unsafe uint glBindTexGenParameterEXT(TextureUnit unit, TextureCoordName coord, TextureGenParameter value);
        
        unsafe void glBindTexture(TextureTarget target, uint texture);
        
        unsafe void glBindTextureEXT(TextureTarget target, uint texture);
        
        unsafe void glBindTextureUnit(uint unit, uint texture);
        
        unsafe uint glBindTextureUnitParameterEXT(TextureUnit unit, VertexShaderTextureUnitParameter value);
        
        unsafe void glBindTextures(uint first, uint count, uint * textures);
        
        unsafe void glBindTransformFeedback(BindTransformFeedbackTarget target, uint id);
        
        unsafe void glBindTransformFeedbackNV(BufferTargetARB target, uint id);
        
        unsafe void glBindVertexArray(uint array);
        
        unsafe void glBindVertexArrayAPPLE(uint array);
        
        unsafe void glBindVertexArrayOES(uint array);
        
        unsafe void glBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, uint stride);
        
        unsafe void glBindVertexBuffers(uint first, uint count, uint * buffers, IntPtr * offsets, uint * strides);
        
        unsafe void glBindVertexShaderEXT(uint id);
        
        unsafe void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz);
        
        unsafe void glBinormal3bvEXT(sbyte * v);
        
        unsafe void glBinormal3dEXT(double bx, double by, double bz);
        
        unsafe void glBinormal3dvEXT(double * v);
        
        unsafe void glBinormal3fEXT(float bx, float by, float bz);
        
        unsafe void glBinormal3fvEXT(float * v);
        
        unsafe void glBinormal3iEXT(int bx, int by, int bz);
        
        unsafe void glBinormal3ivEXT(int * v);
        
        unsafe void glBinormal3sEXT(short bx, short by, short bz);
        
        unsafe void glBinormal3svEXT(short * v);
        
        unsafe void glBinormalPointerEXT(BinormalPointerTypeEXT type, uint stride, void * pointer);
        
        unsafe void glBitmap(uint width, uint height, float xorig, float yorig, float xmove, float ymove, byte * bitmap);
        
        unsafe void glBitmapxOES(uint width, uint height, int xorig, int yorig, int xmove, int ymove, byte * bitmap);
        
        unsafe void glBlendBarrier();
        
        unsafe void glBlendBarrierKHR();
        
        unsafe void glBlendBarrierNV();
        
        unsafe void glBlendColor(float red, float green, float blue, float alpha);
        
        unsafe void glBlendColorEXT(float red, float green, float blue, float alpha);
        
        unsafe void glBlendColorxOES(int red, int green, int blue, int alpha);
        
        unsafe void glBlendEquation(BlendEquationModeEXT mode);
        
        unsafe void glBlendEquationEXT(BlendEquationModeEXT mode);
        
        unsafe void glBlendEquationIndexedAMD(uint buf, BlendEquationModeEXT mode);
        
        unsafe void glBlendEquationOES(BlendEquationModeEXT mode);
        
        unsafe void glBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationSeparateEXT(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationSeparateIndexedAMD(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationSeparateOES(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationSeparatei(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationSeparateiARB(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationSeparateiEXT(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationSeparateiOES(uint buf, BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        
        unsafe void glBlendEquationi(uint buf, BlendEquationModeEXT mode);
        
        unsafe void glBlendEquationiARB(uint buf, BlendEquationModeEXT mode);
        
        unsafe void glBlendEquationiEXT(uint buf, BlendEquationModeEXT mode);
        
        unsafe void glBlendEquationiOES(uint buf, BlendEquationModeEXT mode);
        
        unsafe void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor);
        
        unsafe void glBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);
        
        unsafe void glBlendFuncSeparateEXT(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);
        
        unsafe void glBlendFuncSeparateINGR(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);
        
        unsafe void glBlendFuncSeparateIndexedAMD(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
        
        unsafe void glBlendFuncSeparateOES(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
        
        unsafe void glBlendFuncSeparatei(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
        
        unsafe void glBlendFuncSeparateiARB(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
        
        unsafe void glBlendFuncSeparateiEXT(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
        
        unsafe void glBlendFuncSeparateiOES(uint buf, BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha);
        
        unsafe void glBlendFunci(uint buf, BlendingFactor src, BlendingFactor dst);
        
        unsafe void glBlendFunciARB(uint buf, BlendingFactor src, BlendingFactor dst);
        
        unsafe void glBlendFunciEXT(uint buf, BlendingFactor src, BlendingFactor dst);
        
        unsafe void glBlendFunciOES(uint buf, BlendingFactor src, BlendingFactor dst);
        
        unsafe void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter);
        
        unsafe void glBlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter);
        
        unsafe void glBlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter);
        
        unsafe void glBlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter);
        
        unsafe void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, BlitFramebufferFilter filter);
        
        unsafe void glBufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset);
        
        unsafe void glBufferData(BufferTargetARB target, UIntPtr size, void * data, BufferUsageARB usage);
        
        unsafe void glBufferDataARB(BufferTargetARB target, UIntPtr size, void * data, BufferUsageARB usage);
        
        unsafe void glBufferStorage(BufferStorageTarget target, UIntPtr size, void * data, uint flags);
        
        unsafe void glBufferStorageEXT(BufferStorageTarget target, UIntPtr size, void * data, uint flags);
        
        unsafe void glBufferStorageMemEXT(BufferTargetARB target, UIntPtr size, uint memory, ulong offset);
        
        unsafe void glBufferSubData(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glBufferSubDataARB(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glCallCommandListNV(uint list);
        
        unsafe void glCallList(uint list);
        
        unsafe void glCallLists(uint n, ListNameType type, void * lists);
        
        unsafe FramebufferStatus glCheckFramebufferStatus(FramebufferTarget target);
        
        unsafe FramebufferStatus glCheckFramebufferStatusEXT(FramebufferTarget target);
        
        unsafe FramebufferStatus glCheckFramebufferStatusOES(FramebufferTarget target);
        
        unsafe FramebufferStatus glCheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target);
        
        unsafe FramebufferStatus glCheckNamedFramebufferStatusEXT(uint framebuffer, FramebufferTarget target);
        
        unsafe void glClampColor(ClampColorTargetARB target, ClampColorModeARB clamp);
        
        unsafe void glClampColorARB(ClampColorTargetARB target, ClampColorModeARB clamp);
        
        unsafe void glClear(uint mask);
        
        unsafe void glClearAccum(float red, float green, float blue, float alpha);
        
        unsafe void glClearAccumxOES(int red, int green, int blue, int alpha);
        
        unsafe void glClearBufferData(BufferStorageTarget target, InternalFormat internalformat, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearBufferSubData(BufferTargetARB target, InternalFormat internalformat, IntPtr offset, UIntPtr size, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil);
        
        unsafe void glClearBufferfv(Buffer buffer, int drawbuffer, float * value);
        
        unsafe void glClearBufferiv(Buffer buffer, int drawbuffer, int * value);
        
        unsafe void glClearBufferuiv(Buffer buffer, int drawbuffer, uint * value);
        
        unsafe void glClearColor(float red, float green, float blue, float alpha);
        
        unsafe void glClearColorIiEXT(int red, int green, int blue, int alpha);
        
        unsafe void glClearColorIuiEXT(uint red, uint green, uint blue, uint alpha);
        
        unsafe void glClearColorx(int red, int green, int blue, int alpha);
        
        unsafe void glClearColorxOES(int red, int green, int blue, int alpha);
        
        unsafe void glClearDepth(double depth);
        
        unsafe void glClearDepthdNV(double depth);
        
        unsafe void glClearDepthf(float d);
        
        unsafe void glClearDepthfOES(float depth);
        
        unsafe void glClearDepthx(int depth);
        
        unsafe void glClearDepthxOES(int depth);
        
        unsafe void glClearIndex(float c);
        
        unsafe void glClearNamedBufferData(uint buffer, InternalFormat internalformat, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearNamedBufferDataEXT(uint buffer, InternalFormat internalformat, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearNamedBufferSubData(uint buffer, InternalFormat internalformat, IntPtr offset, UIntPtr size, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearNamedFramebufferfi(uint framebuffer, Buffer buffer, int drawbuffer, float depth, int stencil);
        
        unsafe void glClearNamedFramebufferfv(uint framebuffer, Buffer buffer, int drawbuffer, float * value);
        
        unsafe void glClearNamedFramebufferiv(uint framebuffer, Buffer buffer, int drawbuffer, int * value);
        
        unsafe void glClearNamedFramebufferuiv(uint framebuffer, Buffer buffer, int drawbuffer, uint * value);
        
        unsafe void glClearPixelLocalStorageuiEXT(uint offset, uint n, uint * values);
        
        unsafe void glClearStencil(int s);
        
        unsafe void glClearTexImage(uint texture, int level, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearTexImageEXT(uint texture, int level, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClearTexSubImageEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * data);
        
        unsafe void glClientActiveTexture(TextureUnit texture);
        
        unsafe void glClientActiveTextureARB(TextureUnit texture);
        
        unsafe void glClientActiveVertexStreamATI(VertexStreamATI stream);
        
        unsafe void glClientAttribDefaultEXT(uint mask);
        
        unsafe void glClientWaitSemaphoreui64NVX(uint fenceObjectCount, uint * semaphoreArray, ulong * fenceValueArray);
        
        unsafe SyncStatus glClientWaitSync(IntPtr sync, uint flags, ulong timeout);
        
        unsafe SyncStatus glClientWaitSyncAPPLE(IntPtr sync, uint flags, ulong timeout);
        
        unsafe void glClipControl(ClipControlOrigin origin, ClipControlDepth depth);
        
        unsafe void glClipPlane(ClipPlaneName plane, double * equation);
        
        unsafe void glClipPlanef(ClipPlaneName p, float * eqn);
        
        unsafe void glClipPlanefIMG(ClipPlaneName p, float * eqn);
        
        unsafe void glClipPlanefOES(ClipPlaneName plane, float * equation);
        
        unsafe void glClipPlanex(ClipPlaneName plane, int * equation);
        
        unsafe void glClipPlanexIMG(ClipPlaneName p, int * eqn);
        
        unsafe void glClipPlanexOES(ClipPlaneName plane, int * equation);
        
        unsafe void glColor3b(sbyte red, sbyte green, sbyte blue);
        
        unsafe void glColor3bv(sbyte * v);
        
        unsafe void glColor3d(double red, double green, double blue);
        
        unsafe void glColor3dv(double * v);
        
        unsafe void glColor3f(float red, float green, float blue);
        
        unsafe void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z);
        
        unsafe void glColor3fVertex3fvSUN(float * c, float * v);
        
        unsafe void glColor3fv(float * v);
        
        unsafe void glColor3hNV(OpenToolkit.Mathematics.Half red, OpenToolkit.Mathematics.Half green, OpenToolkit.Mathematics.Half blue);
        
        unsafe void glColor3hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glColor3i(int red, int green, int blue);
        
        unsafe void glColor3iv(int * v);
        
        unsafe void glColor3s(short red, short green, short blue);
        
        unsafe void glColor3sv(short * v);
        
        unsafe void glColor3ub(byte red, byte green, byte blue);
        
        unsafe void glColor3ubv(byte * v);
        
        unsafe void glColor3ui(uint red, uint green, uint blue);
        
        unsafe void glColor3uiv(uint * v);
        
        unsafe void glColor3us(ushort red, ushort green, ushort blue);
        
        unsafe void glColor3usv(ushort * v);
        
        unsafe void glColor3xOES(int red, int green, int blue);
        
        unsafe void glColor3xvOES(int * components);
        
        unsafe void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
        
        unsafe void glColor4bv(sbyte * v);
        
        unsafe void glColor4d(double red, double green, double blue, double alpha);
        
        unsafe void glColor4dv(double * v);
        
        unsafe void glColor4f(float red, float green, float blue, float alpha);
        
        unsafe void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glColor4fNormal3fVertex3fvSUN(float * c, float * n, float * v);
        
        unsafe void glColor4fv(float * v);
        
        unsafe void glColor4hNV(OpenToolkit.Mathematics.Half red, OpenToolkit.Mathematics.Half green, OpenToolkit.Mathematics.Half blue, OpenToolkit.Mathematics.Half alpha);
        
        unsafe void glColor4hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glColor4i(int red, int green, int blue, int alpha);
        
        unsafe void glColor4iv(int * v);
        
        unsafe void glColor4s(short red, short green, short blue, short alpha);
        
        unsafe void glColor4sv(short * v);
        
        unsafe void glColor4ub(byte red, byte green, byte blue, byte alpha);
        
        unsafe void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);
        
        unsafe void glColor4ubVertex2fvSUN(byte * c, float * v);
        
        unsafe void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);
        
        unsafe void glColor4ubVertex3fvSUN(byte * c, float * v);
        
        unsafe void glColor4ubv(byte * v);
        
        unsafe void glColor4ui(uint red, uint green, uint blue, uint alpha);
        
        unsafe void glColor4uiv(uint * v);
        
        unsafe void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
        
        unsafe void glColor4usv(ushort * v);
        
        unsafe void glColor4x(int red, int green, int blue, int alpha);
        
        unsafe void glColor4xOES(int red, int green, int blue, int alpha);
        
        unsafe void glColor4xvOES(int * components);
        
        unsafe void glColorFragmentOp1ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        
        unsafe void glColorFragmentOp2ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        
        unsafe void glColorFragmentOp3ATI(FragmentOpATI op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        
        unsafe void glColorMask(bool red, bool green, bool blue, bool alpha);
        
        unsafe void glColorMaskIndexedEXT(uint index, bool r, bool g, bool b, bool a);
        
        unsafe void glColorMaski(uint index, bool r, bool g, bool b, bool a);
        
        unsafe void glColorMaskiEXT(uint index, bool r, bool g, bool b, bool a);
        
        unsafe void glColorMaskiOES(uint index, bool r, bool g, bool b, bool a);
        
        unsafe void glColorMaterial(MaterialFace face, ColorMaterialParameter mode);
        
        unsafe void glColorP3ui(ColorPointerType type, uint color);
        
        unsafe void glColorP3uiv(ColorPointerType type, uint * color);
        
        unsafe void glColorP4ui(ColorPointerType type, uint color);
        
        unsafe void glColorP4uiv(ColorPointerType type, uint * color);
        
        unsafe void glColorPointer(int size, ColorPointerType type, uint stride, void * pointer);
        
        unsafe void glColorPointerEXT(int size, ColorPointerType type, uint stride, uint count, void * pointer);
        
        unsafe void glColorPointerListIBM(int size, ColorPointerType type, int stride, void * * pointer, int ptrstride);
        
        unsafe void glColorPointervINTEL(int size, VertexPointerType type, void * * pointer);
        
        unsafe void glColorSubTable(ColorTableTarget target, uint start, uint count, PixelFormat format, PixelType type, void * data);
        
        unsafe void glColorSubTableEXT(ColorTableTarget target, uint start, uint count, PixelFormat format, PixelType type, void * data);
        
        unsafe void glColorTable(ColorTableTarget target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * table);
        
        unsafe void glColorTableEXT(ColorTableTarget target, InternalFormat internalFormat, uint width, PixelFormat format, PixelType type, void * table);
        
        unsafe void glColorTableParameterfv(ColorTableTarget target, ColorTableParameterPNameSGI pname, float * PARAMS);
        
        unsafe void glColorTableParameterfvSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, float * PARAMS);
        
        unsafe void glColorTableParameteriv(ColorTableTarget target, ColorTableParameterPNameSGI pname, int * PARAMS);
        
        unsafe void glColorTableParameterivSGI(ColorTableTargetSGI target, ColorTableParameterPNameSGI pname, int * PARAMS);
        
        unsafe void glColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * table);
        
        unsafe void glCombinerInputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage);
        
        unsafe void glCombinerOutputNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerRegisterNV abOutput, CombinerRegisterNV cdOutput, CombinerRegisterNV sumOutput, CombinerScaleNV scale, CombinerBiasNV bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
        
        unsafe void glCombinerParameterfNV(CombinerParameterNV pname, float param);
        
        unsafe void glCombinerParameterfvNV(CombinerParameterNV pname, float * PARAMS);
        
        unsafe void glCombinerParameteriNV(CombinerParameterNV pname, int param);
        
        unsafe void glCombinerParameterivNV(CombinerParameterNV pname, int * PARAMS);
        
        unsafe void glCombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float * PARAMS);
        
        unsafe void glCommandListSegmentsNV(uint list, uint segments);
        
        unsafe void glCompileCommandListNV(uint list);
        
        unsafe void glCompileShader(uint shader);
        
        unsafe void glCompileShaderARB(uint shaderObj);
        
        unsafe void glCompileShaderIncludeARB(uint shader, uint count, char * * path, int * length);
        
        unsafe void glCompressedMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * bits);
        
        unsafe void glCompressedMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * bits);
        
        unsafe void glCompressedMultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * bits);
        
        unsafe void glCompressedMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * bits);
        
        unsafe void glCompressedMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * bits);
        
        unsafe void glCompressedMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * bits);
        
        unsafe void glCompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * data);
        
        unsafe void glCompressedTexImage1DARB(TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * data);
        
        unsafe void glCompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * data);
        
        unsafe void glCompressedTexImage2DARB(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * data);
        
        unsafe void glCompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * data);
        
        unsafe void glCompressedTexImage3DARB(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * data);
        
        unsafe void glCompressedTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * data);
        
        unsafe void glCompressedTexSubImage1D(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTexSubImage1DARB(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTexSubImage2DARB(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTexSubImage3DARB(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTextureImage1DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, uint width, int border, uint imageSize, void * bits);
        
        unsafe void glCompressedTextureImage2DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, int border, uint imageSize, void * bits);
        
        unsafe void glCompressedTextureImage3DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, uint imageSize, void * bits);
        
        unsafe void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, uint imageSize, void * bits);
        
        unsafe void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, uint imageSize, void * bits);
        
        unsafe void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * data);
        
        unsafe void glCompressedTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, uint imageSize, void * bits);
        
        unsafe void glConvolutionFilter1D(ConvolutionTarget target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * image);
        
        unsafe void glConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, uint width, PixelFormat format, PixelType type, void * image);
        
        unsafe void glConvolutionFilter2D(ConvolutionTarget target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * image);
        
        unsafe void glConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * image);
        
        unsafe void glConvolutionParameterf(ConvolutionTarget target, ConvolutionParameterEXT pname, float PARAMS);
        
        unsafe void glConvolutionParameterfEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float PARAMS);
        
        unsafe void glConvolutionParameterfv(ConvolutionTarget target, ConvolutionParameterEXT pname, float * PARAMS);
        
        unsafe void glConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float * PARAMS);
        
        unsafe void glConvolutionParameteri(ConvolutionTarget target, ConvolutionParameterEXT pname, int PARAMS);
        
        unsafe void glConvolutionParameteriEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int PARAMS);
        
        unsafe void glConvolutionParameteriv(ConvolutionTarget target, ConvolutionParameterEXT pname, int * PARAMS);
        
        unsafe void glConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int * PARAMS);
        
        unsafe void glConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int param);
        
        unsafe void glConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int * PARAMS);
        
        unsafe void glCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, UIntPtr size);
        
        unsafe void glCopyBufferSubDataNV(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, UIntPtr size);
        
        unsafe void glCopyColorSubTable(ColorTableTarget target, uint start, int x, int y, uint width);
        
        unsafe void glCopyColorSubTableEXT(ColorTableTarget target, uint start, int x, int y, uint width);
        
        unsafe void glCopyColorTable(ColorTableTarget target, InternalFormat internalformat, int x, int y, uint width);
        
        unsafe void glCopyColorTableSGI(ColorTableTargetSGI target, InternalFormat internalformat, int x, int y, uint width);
        
        unsafe void glCopyConvolutionFilter1D(ConvolutionTarget target, InternalFormat internalformat, int x, int y, uint width);
        
        unsafe void glCopyConvolutionFilter1DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, uint width);
        
        unsafe void glCopyConvolutionFilter2D(ConvolutionTarget target, InternalFormat internalformat, int x, int y, uint width, uint height);
        
        unsafe void glCopyConvolutionFilter2DEXT(ConvolutionTargetEXT target, InternalFormat internalformat, int x, int y, uint width, uint height);
        
        unsafe void glCopyImageSubData(uint srcName, CopyImageSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth);
        
        unsafe void glCopyImageSubDataEXT(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth);
        
        unsafe void glCopyImageSubDataNV(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint width, uint height, uint depth);
        
        unsafe void glCopyImageSubDataOES(uint srcName, CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, uint srcWidth, uint srcHeight, uint srcDepth);
        
        unsafe void glCopyMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border);
        
        unsafe void glCopyMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border);
        
        unsafe void glCopyMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int x, int y, uint width);
        
        unsafe void glCopyMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size);
        
        unsafe void glCopyPathNV(uint resultPath, uint srcPath);
        
        unsafe void glCopyPixels(int x, int y, uint width, uint height, PixelCopyType type);
        
        unsafe void glCopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border);
        
        unsafe void glCopyTexImage1DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border);
        
        unsafe void glCopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border);
        
        unsafe void glCopyTexImage2DEXT(TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border);
        
        unsafe void glCopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, uint width);
        
        unsafe void glCopyTexSubImage1DEXT(TextureTarget target, int level, int xoffset, int x, int y, uint width);
        
        unsafe void glCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyTextureImage1DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, int border);
        
        unsafe void glCopyTextureImage2DEXT(uint texture, TextureTarget target, int level, InternalFormat internalformat, int x, int y, uint width, uint height, int border);
        
        unsafe void glCopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, uint sourceLevelCount);
        
        unsafe void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, uint width);
        
        unsafe void glCopyTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, int x, int y, uint width);
        
        unsafe void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
        
        unsafe void glCopyTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, uint width, uint height);
        
        unsafe void glCoverFillPathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float * transformValues);
        
        unsafe void glCoverFillPathNV(uint path, PathCoverMode coverMode);
        
        unsafe void glCoverStrokePathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, PathCoverMode coverMode, PathTransformType transformType, float * transformValues);
        
        unsafe void glCoverStrokePathNV(uint path, PathCoverMode coverMode);
        
        unsafe void glCoverageMaskNV(bool mask);
        
        unsafe void glCoverageModulationTableNV(uint n, float * v);
        
        unsafe void glCreateBuffers(uint n, uint * buffers);
        
        unsafe void glCreateCommandListsNV(uint n, uint * lists);
        
        unsafe void glCreateFramebuffers(uint n, uint * framebuffers);
        
        unsafe void glCreateMemoryObjectsEXT(uint n, uint * memoryObjects);
        
        unsafe void glCreatePerfQueryINTEL(uint queryId, uint * queryHandle);
        
        unsafe uint glCreateProgram();
        
        unsafe uint glCreateProgramObjectARB();
        
        unsafe void glCreateProgramPipelines(uint n, uint * pipelines);
        
        unsafe uint glCreateProgressFenceNVX();
        
        unsafe void glCreateQueries(QueryTarget target, uint n, uint * ids);
        
        unsafe void glCreateRenderbuffers(uint n, uint * renderbuffers);
        
        unsafe void glCreateSamplers(uint n, uint * samplers);
        
        unsafe uint glCreateShader(ShaderType type);
        
        unsafe uint glCreateShaderObjectARB(ShaderType shaderType);
        
        unsafe uint glCreateShaderProgramEXT(ShaderType type, char * STRING);
        
        unsafe uint glCreateShaderProgramv(ShaderType type, uint count, char * * strings);
        
        unsafe uint glCreateShaderProgramvEXT(ShaderType type, uint count, char * * strings);
        
        unsafe void glCreateStatesNV(uint n, uint * states);
        
        unsafe IntPtr glCreateSyncFromCLeventARB(Struct_cl_context * context, Struct_cl_event * EVENT, uint flags);
        
        unsafe void glCreateTextures(TextureTarget target, uint n, uint * textures);
        
        unsafe void glCreateTransformFeedbacks(uint n, uint * ids);
        
        unsafe void glCreateVertexArrays(uint n, uint * arrays);
        
        unsafe void glCullFace(CullFaceMode mode);
        
        unsafe void glCullParameterdvEXT(CullParameterEXT pname, double * PARAMS);
        
        unsafe void glCullParameterfvEXT(CullParameterEXT pname, float * PARAMS);
        
        unsafe void glCurrentPaletteMatrixARB(int index);
        
        unsafe void glCurrentPaletteMatrixOES(uint matrixpaletteindex);
        
        unsafe void glDebugMessageCallback(DebugProc callback, void * userParam);
        
        unsafe void glDebugMessageCallbackAMD(DebugProcAmd callback, void * userParam);
        
        unsafe void glDebugMessageCallbackARB(DebugProcArb callback, void * userParam);
        
        unsafe void glDebugMessageCallbackKHR(DebugProcKhr callback, void * userParam);
        
        unsafe void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint count, uint * ids, bool enabled);
        
        unsafe void glDebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, uint count, uint * ids, bool enabled);
        
        unsafe void glDebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, uint count, uint * ids, bool enabled);
        
        unsafe void glDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, uint length, char * buf);
        
        unsafe void glDebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, uint length, char * buf);
        
        unsafe void glDebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, uint length, char * buf);
        
        unsafe void glDeformSGIX(uint mask);
        
        unsafe void glDeformationMap3dSGIX(FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double * points);
        
        unsafe void glDeformationMap3fSGIX(FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float * points);
        
        unsafe void glDeleteAsyncMarkersSGIX(uint marker, uint range);
        
        unsafe void glDeleteBuffers(uint n, uint * buffers);
        
        unsafe void glDeleteBuffersARB(uint n, uint * buffers);
        
        unsafe void glDeleteCommandListsNV(uint n, uint * lists);
        
        unsafe void glDeleteFencesAPPLE(uint n, uint * fences);
        
        unsafe void glDeleteFencesNV(uint n, uint * fences);
        
        unsafe void glDeleteFragmentShaderATI(uint id);
        
        unsafe void glDeleteFramebuffers(uint n, uint * framebuffers);
        
        unsafe void glDeleteFramebuffersEXT(uint n, uint * framebuffers);
        
        unsafe void glDeleteFramebuffersOES(uint n, uint * framebuffers);
        
        unsafe void glDeleteLists(uint list, uint range);
        
        unsafe void glDeleteMemoryObjectsEXT(uint n, uint * memoryObjects);
        
        unsafe void glDeleteNamedStringARB(int namelen, char * name);
        
        unsafe void glDeleteObjectARB(uint obj);
        
        unsafe void glDeleteOcclusionQueriesNV(uint n, uint * ids);
        
        unsafe void glDeletePathsNV(uint path, uint range);
        
        unsafe void glDeletePerfMonitorsAMD(uint n, uint * monitors);
        
        unsafe void glDeletePerfQueryINTEL(uint queryHandle);
        
        unsafe void glDeleteProgram(uint program);
        
        unsafe void glDeleteProgramPipelines(uint n, uint * pipelines);
        
        unsafe void glDeleteProgramPipelinesEXT(uint n, uint * pipelines);
        
        unsafe void glDeleteProgramsARB(uint n, uint * programs);
        
        unsafe void glDeleteProgramsNV(uint n, uint * programs);
        
        unsafe void glDeleteQueries(uint n, uint * ids);
        
        unsafe void glDeleteQueriesARB(uint n, uint * ids);
        
        unsafe void glDeleteQueriesEXT(uint n, uint * ids);
        
        unsafe void glDeleteQueryResourceTagNV(uint n, int * tagIds);
        
        unsafe void glDeleteRenderbuffers(uint n, uint * renderbuffers);
        
        unsafe void glDeleteRenderbuffersEXT(uint n, uint * renderbuffers);
        
        unsafe void glDeleteRenderbuffersOES(uint n, uint * renderbuffers);
        
        unsafe void glDeleteSamplers(uint count, uint * samplers);
        
        unsafe void glDeleteSemaphoresEXT(uint n, uint * semaphores);
        
        unsafe void glDeleteShader(uint shader);
        
        unsafe void glDeleteStatesNV(uint n, uint * states);
        
        unsafe void glDeleteSync(IntPtr sync);
        
        unsafe void glDeleteSyncAPPLE(IntPtr sync);
        
        unsafe void glDeleteTextures(uint n, uint * textures);
        
        unsafe void glDeleteTexturesEXT(uint n, uint * textures);
        
        unsafe void glDeleteTransformFeedbacks(uint n, uint * ids);
        
        unsafe void glDeleteTransformFeedbacksNV(uint n, uint * ids);
        
        unsafe void glDeleteVertexArrays(uint n, uint * arrays);
        
        unsafe void glDeleteVertexArraysAPPLE(uint n, uint * arrays);
        
        unsafe void glDeleteVertexArraysOES(uint n, uint * arrays);
        
        unsafe void glDeleteVertexShaderEXT(uint id);
        
        unsafe void glDepthBoundsEXT(double zmin, double zmax);
        
        unsafe void glDepthBoundsdNV(double zmin, double zmax);
        
        unsafe void glDepthFunc(DepthFunction func);
        
        unsafe void glDepthMask(bool flag);
        
        unsafe void glDepthRange(double n, double f);
        
        unsafe void glDepthRangeArrayfvNV(uint first, uint count, float * v);
        
        unsafe void glDepthRangeArrayfvOES(uint first, uint count, float * v);
        
        unsafe void glDepthRangeArrayv(uint first, uint count, double * v);
        
        unsafe void glDepthRangeIndexed(uint index, double n, double f);
        
        unsafe void glDepthRangeIndexedfNV(uint index, float n, float f);
        
        unsafe void glDepthRangeIndexedfOES(uint index, float n, float f);
        
        unsafe void glDepthRangedNV(double zNear, double zFar);
        
        unsafe void glDepthRangef(float n, float f);
        
        unsafe void glDepthRangefOES(float n, float f);
        
        unsafe void glDepthRangex(int n, int f);
        
        unsafe void glDepthRangexOES(int n, int f);
        
        unsafe void glDetachObjectARB(uint containerObj, uint attachedObj);
        
        unsafe void glDetachShader(uint program, uint shader);
        
        unsafe void glDetailTexFuncSGIS(TextureTarget target, uint n, float * points);
        
        unsafe void glDisable(EnableCap cap);
        
        unsafe void glDisableClientState(EnableCap array);
        
        unsafe void glDisableClientStateIndexedEXT(EnableCap array, uint index);
        
        unsafe void glDisableClientStateiEXT(EnableCap array, uint index);
        
        unsafe void glDisableDriverControlQCOM(uint driverControl);
        
        unsafe void glDisableIndexedEXT(EnableCap target, uint index);
        
        unsafe void glDisableVariantClientStateEXT(uint id);
        
        unsafe void glDisableVertexArrayAttrib(uint vaobj, uint index);
        
        unsafe void glDisableVertexArrayAttribEXT(uint vaobj, uint index);
        
        unsafe void glDisableVertexArrayEXT(uint vaobj, EnableCap array);
        
        unsafe void glDisableVertexAttribArray(uint index);
        
        unsafe void glDisableVertexAttribArrayARB(uint index);
        
        unsafe void glDisablei(EnableCap target, uint index);
        
        unsafe void glDisableiEXT(EnableCap target, uint index);
        
        unsafe void glDisableiNV(EnableCap target, uint index);
        
        unsafe void glDisableiOES(EnableCap target, uint index);
        
        unsafe void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);
        
        unsafe void glDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);
        
        unsafe void glDispatchComputeIndirect(IntPtr indirect);
        
        unsafe void glDrawArrays(PrimitiveType mode, int first, uint count);
        
        unsafe void glDrawArraysEXT(PrimitiveType mode, int first, uint count);
        
        unsafe void glDrawArraysIndirect(PrimitiveType mode, void * indirect);
        
        unsafe void glDrawArraysInstanced(PrimitiveType mode, int first, uint count, uint instancecount);
        
        unsafe void glDrawArraysInstancedANGLE(PrimitiveType mode, int first, uint count, uint primcount);
        
        unsafe void glDrawArraysInstancedARB(PrimitiveType mode, int first, uint count, uint primcount);
        
        unsafe void glDrawArraysInstancedBaseInstance(PrimitiveType mode, int first, uint count, uint instancecount, uint baseinstance);
        
        unsafe void glDrawArraysInstancedBaseInstanceEXT(PrimitiveType mode, int first, uint count, uint instancecount, uint baseinstance);
        
        unsafe void glDrawArraysInstancedEXT(PrimitiveType mode, int start, uint count, uint primcount);
        
        unsafe void glDrawArraysInstancedNV(PrimitiveType mode, int first, uint count, uint primcount);
        
        unsafe void glDrawBuffer(DrawBufferMode buf);
        
        unsafe void glDrawBuffers(uint n, DrawBufferMode * bufs);
        
        unsafe void glDrawBuffersARB(uint n, DrawBufferMode * bufs);
        
        unsafe void glDrawBuffersATI(uint n, DrawBufferMode * bufs);
        
        unsafe void glDrawCommandsStatesAddressNV(ulong * indirects, uint * sizes, uint * states, uint * fbos, uint count);
        
        unsafe void glDrawCommandsStatesNV(uint buffer, IntPtr * indirects, uint * sizes, uint * states, uint * fbos, uint count);
        
        unsafe void glDrawElementArrayAPPLE(PrimitiveType mode, int first, uint count);
        
        unsafe void glDrawElementArrayATI(PrimitiveType mode, uint count);
        
        unsafe void glDrawElements(PrimitiveType mode, uint count, DrawElementsType type, void * indices);
        
        unsafe void glDrawElementsBaseVertex(PrimitiveType mode, uint count, DrawElementsType type, void * indices, int basevertex);
        
        unsafe void glDrawElementsBaseVertexEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, int basevertex);
        
        unsafe void glDrawElementsBaseVertexOES(PrimitiveType mode, uint count, DrawElementsType type, void * indices, int basevertex);
        
        unsafe void glDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void * indirect);
        
        unsafe void glDrawElementsInstanced(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount);
        
        unsafe void glDrawElementsInstancedANGLE(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint primcount);
        
        unsafe void glDrawElementsInstancedARB(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint primcount);
        
        unsafe void glDrawElementsInstancedBaseInstance(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint instancecount, uint baseinstance);
        
        unsafe void glDrawElementsInstancedBaseInstanceEXT(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint instancecount, uint baseinstance);
        
        unsafe void glDrawElementsInstancedBaseVertex(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex);
        
        unsafe void glDrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex, uint baseinstance);
        
        unsafe void glDrawElementsInstancedBaseVertexBaseInstanceEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex, uint baseinstance);
        
        unsafe void glDrawElementsInstancedBaseVertexEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex);
        
        unsafe void glDrawElementsInstancedBaseVertexOES(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint instancecount, int basevertex);
        
        unsafe void glDrawElementsInstancedEXT(PrimitiveType mode, uint count, DrawElementsType type, void * indices, uint primcount);
        
        unsafe void glDrawElementsInstancedNV(PrimitiveType mode, uint count, PrimitiveType type, void * indices, uint primcount);
        
        unsafe void glDrawMeshArraysSUN(PrimitiveType mode, int first, uint count, uint width);
        
        unsafe void glDrawMeshTasksNV(uint first, uint count);
        
        unsafe void glDrawMeshTasksIndirectNV(IntPtr indirect);
        
        unsafe void glDrawPixels(uint width, uint height, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int first, uint count);
        
        unsafe void glDrawRangeElementArrayATI(PrimitiveType mode, uint start, uint end, uint count);
        
        unsafe void glDrawRangeElements(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices);
        
        unsafe void glDrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices, int basevertex);
        
        unsafe void glDrawRangeElementsBaseVertexEXT(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices, int basevertex);
        
        unsafe void glDrawRangeElementsBaseVertexOES(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices, int basevertex);
        
        unsafe void glDrawRangeElementsEXT(PrimitiveType mode, uint start, uint end, uint count, DrawElementsType type, void * indices);
        
        unsafe void glDrawTexfOES(float x, float y, float z, float width, float height);
        
        unsafe void glDrawTexfvOES(float * coords);
        
        unsafe void glDrawTexiOES(int x, int y, int z, int width, int height);
        
        unsafe void glDrawTexivOES(int * coords);
        
        unsafe void glDrawTexsOES(short x, short y, short z, short width, short height);
        
        unsafe void glDrawTexsvOES(short * coords);
        
        unsafe void glDrawTextureNV(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
        
        unsafe void glDrawTexxOES(int x, int y, int z, int width, int height);
        
        unsafe void glDrawTexxvOES(int * coords);
        
        unsafe void glDrawTransformFeedback(PrimitiveType mode, uint id);
        
        unsafe void glDrawTransformFeedbackEXT(PrimitiveType mode, uint id);
        
        unsafe void glDrawTransformFeedbackInstanced(PrimitiveType mode, uint id, uint instancecount);
        
        unsafe void glDrawTransformFeedbackInstancedEXT(PrimitiveType mode, uint id, uint instancecount);
        
        unsafe void glDrawTransformFeedbackNV(PrimitiveType mode, uint id);
        
        unsafe void glDrawTransformFeedbackStream(PrimitiveType mode, uint id, uint stream);
        
        unsafe void glDrawTransformFeedbackStreamInstanced(PrimitiveType mode, uint id, uint stream, uint instancecount);
        
        unsafe void glEGLImageTargetTextureStorageEXT(uint texture, IntPtr image, int * attrib_list);
        
        unsafe void glEdgeFlag(bool flag);
        
        unsafe void glEdgeFlagFormatNV(uint stride);
        
        unsafe void glEdgeFlagPointer(uint stride, void * pointer);
        
        unsafe void glEdgeFlagPointerEXT(uint stride, uint count, bool * pointer);
        
        unsafe void glEdgeFlagPointerListIBM(int stride, bool * * pointer, int ptrstride);
        
        unsafe void glEdgeFlagv(bool * flag);
        
        unsafe void glElementPointerAPPLE(ElementPointerTypeATI type, void * pointer);
        
        unsafe void glElementPointerATI(ElementPointerTypeATI type, void * pointer);
        
        unsafe void glEnable(EnableCap cap);
        
        unsafe void glEnableClientState(EnableCap array);
        
        unsafe void glEnableClientStateIndexedEXT(EnableCap array, uint index);
        
        unsafe void glEnableClientStateiEXT(EnableCap array, uint index);
        
        unsafe void glEnableDriverControlQCOM(uint driverControl);
        
        unsafe void glEnableIndexedEXT(EnableCap target, uint index);
        
        unsafe void glEnableVariantClientStateEXT(uint id);
        
        unsafe void glEnableVertexArrayAttrib(uint vaobj, uint index);
        
        unsafe void glEnableVertexArrayAttribEXT(uint vaobj, uint index);
        
        unsafe void glEnableVertexArrayEXT(uint vaobj, EnableCap array);
        
        unsafe void glEnableVertexAttribArray(uint index);
        
        unsafe void glEnableVertexAttribArrayARB(uint index);
        
        unsafe void glEnablei(EnableCap target, uint index);
        
        unsafe void glEnableiEXT(EnableCap target, uint index);
        
        unsafe void glEnableiNV(EnableCap target, uint index);
        
        unsafe void glEnableiOES(EnableCap target, uint index);
        
        unsafe void glEnd();
        
        unsafe void glEndConditionalRender();
        
        unsafe void glEndConditionalRenderNV();
        
        unsafe void glEndConditionalRenderNVX();
        
        unsafe void glEndFragmentShaderATI();
        
        unsafe void glEndList();
        
        unsafe void glEndOcclusionQueryNV();
        
        unsafe void glEndPerfMonitorAMD(uint monitor);
        
        unsafe void glEndPerfQueryINTEL(uint queryHandle);
        
        unsafe void glEndQuery(QueryTarget target);
        
        unsafe void glEndQueryARB(QueryTarget target);
        
        unsafe void glEndQueryEXT(QueryTarget target);
        
        unsafe void glEndQueryIndexed(QueryTarget target, uint index);
        
        unsafe void glEndTilingQCOM(uint preserveMask);
        
        unsafe void glEndTransformFeedback();
        
        unsafe void glEndTransformFeedbackEXT();
        
        unsafe void glEndTransformFeedbackNV();
        
        unsafe void glEndVertexShaderEXT();
        
        unsafe void glEndVideoCaptureNV(uint video_capture_slot);
        
        unsafe void glEvalCoord1d(double u);
        
        unsafe void glEvalCoord1dv(double * u);
        
        unsafe void glEvalCoord1f(float u);
        
        unsafe void glEvalCoord1fv(float * u);
        
        unsafe void glEvalCoord1xOES(int u);
        
        unsafe void glEvalCoord1xvOES(int * coords);
        
        unsafe void glEvalCoord2d(double u, double v);
        
        unsafe void glEvalCoord2dv(double * u);
        
        unsafe void glEvalCoord2f(float u, float v);
        
        unsafe void glEvalCoord2fv(float * u);
        
        unsafe void glEvalCoord2xOES(int u, int v);
        
        unsafe void glEvalCoord2xvOES(int * coords);
        
        unsafe void glEvalMapsNV(EvalTargetNV target, EvalMapsModeNV mode);
        
        unsafe void glEvalMesh1(MeshMode1 mode, int i1, int i2);
        
        unsafe void glEvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2);
        
        unsafe void glEvalPoint1(int i);
        
        unsafe void glEvalPoint2(int i, int j);
        
        unsafe void glEvaluateDepthValuesARB();
        
        unsafe void glExecuteProgramNV(VertexAttribEnumNV target, uint id, float * PARAMS);
        
        unsafe void glExtGetBuffersQCOM(uint * buffers, int maxBuffers, int * numBuffers);
        
        unsafe void glExtGetFramebuffersQCOM(uint * framebuffers, int maxFramebuffers, int * numFramebuffers);
        
        unsafe void glExtGetProgramBinarySourceQCOM(uint program, ShaderType shadertype, char * source, int * length);
        
        unsafe void glExtGetProgramsQCOM(uint * programs, int maxPrograms, int * numPrograms);
        
        unsafe void glExtGetRenderbuffersQCOM(uint * renderbuffers, int maxRenderbuffers, int * numRenderbuffers);
        
        unsafe void glExtGetShadersQCOM(uint * shaders, int maxShaders, int * numShaders);
        
        unsafe void glExtGetTexturesQCOM(uint * textures, int maxTextures, int * numTextures);
        
        unsafe bool glExtIsProgramBinaryQCOM(uint program);
        
        unsafe void glExtractComponentEXT(uint res, uint src, uint num);
        
        unsafe void glFeedbackBuffer(uint size, FeedbackType type, float * buffer);
        
        unsafe IntPtr glFenceSync(SyncCondition condition, uint flags);
        
        unsafe IntPtr glFenceSyncAPPLE(SyncCondition condition, uint flags);
        
        unsafe void glFinalCombinerInputNV(CombinerVariableNV variable, CombinerRegisterNV input, CombinerMappingNV mapping, CombinerComponentUsageNV componentUsage);
        
        unsafe void glFinish();
        
        unsafe int glFinishAsyncSGIX(uint * markerp);
        
        unsafe void glFinishFenceAPPLE(uint fence);
        
        unsafe void glFinishFenceNV(uint fence);
        
        unsafe void glFinishObjectAPPLE(ObjectTypeAPPLE OBJECT, int name);
        
        unsafe void glFinishTextureSUNX();
        
        unsafe void glFlush();
        
        unsafe void glFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, UIntPtr length);
        
        unsafe void glFlushMappedBufferRangeAPPLE(BufferTargetARB target, IntPtr offset, UIntPtr size);
        
        unsafe void glFlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, UIntPtr length);
        
        unsafe void glFlushMappedNamedBufferRange(uint buffer, IntPtr offset, UIntPtr length);
        
        unsafe void glFlushMappedNamedBufferRangeEXT(uint buffer, IntPtr offset, UIntPtr length);
        
        unsafe void glFlushPixelDataRangeNV(PixelDataRangeTargetNV target);
        
        unsafe void glFlushRasterSGIX();
        
        unsafe void glFlushVertexArrayRangeAPPLE(uint length, void * pointer);
        
        unsafe void glFlushVertexArrayRangeNV();
        
        unsafe void glFogCoordPointer(FogPointerTypeEXT type, uint stride, void * pointer);
        
        unsafe void glFogCoordPointerEXT(FogPointerTypeEXT type, uint stride, void * pointer);
        
        unsafe void glFogCoordPointerListIBM(FogPointerTypeIBM type, int stride, void * * pointer, int ptrstride);
        
        unsafe void glFogCoordd(double coord);
        
        unsafe void glFogCoorddEXT(double coord);
        
        unsafe void glFogCoorddv(double * coord);
        
        unsafe void glFogCoorddvEXT(double * coord);
        
        unsafe void glFogCoordf(float coord);
        
        unsafe void glFogCoordfEXT(float coord);
        
        unsafe void glFogCoordfv(float * coord);
        
        unsafe void glFogCoordfvEXT(float * coord);
        
        unsafe void glFogCoordhNV(OpenToolkit.Mathematics.Half fog);
        
        unsafe void glFogCoordhvNV(OpenToolkit.Mathematics.Half * fog);
        
        unsafe void glFogFuncSGIS(uint n, float * points);
        
        unsafe void glFogf(FogParameter pname, float param);
        
        unsafe void glFogfv(FogParameter pname, float * PARAMS);
        
        unsafe void glFogi(FogParameter pname, int param);
        
        unsafe void glFogiv(FogParameter pname, int * PARAMS);
        
        unsafe void glFogx(FogPName pname, int param);
        
        unsafe void glFogxOES(FogPName pname, int param);
        
        unsafe void glFogxv(FogPName pname, int * param);
        
        unsafe void glFogxvOES(FogPName pname, int * param);
        
        unsafe void glFragmentColorMaterialSGIX(MaterialFace face, MaterialParameter mode);
        
        unsafe void glFragmentCoverageColorNV(uint color);
        
        unsafe void glFragmentLightModelfSGIX(FragmentLightModelParameterSGIX pname, float param);
        
        unsafe void glFragmentLightModelfvSGIX(FragmentLightModelParameterSGIX pname, float * PARAMS);
        
        unsafe void glFragmentLightModeliSGIX(FragmentLightModelParameterSGIX pname, int param);
        
        unsafe void glFragmentLightModelivSGIX(FragmentLightModelParameterSGIX pname, int * PARAMS);
        
        unsafe void glFragmentLightfSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float param);
        
        unsafe void glFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float * PARAMS);
        
        unsafe void glFragmentLightiSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int param);
        
        unsafe void glFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int * PARAMS);
        
        unsafe void glFragmentMaterialfSGIX(MaterialFace face, MaterialParameter pname, float param);
        
        unsafe void glFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float * PARAMS);
        
        unsafe void glFragmentMaterialiSGIX(MaterialFace face, MaterialParameter pname, int param);
        
        unsafe void glFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int * PARAMS);
        
        unsafe void glFrameTerminatorGREMEDY();
        
        unsafe void glFrameZoomSGIX(int factor);
        
        unsafe void glFramebufferDrawBufferEXT(uint framebuffer, DrawBufferMode mode);
        
        unsafe void glFramebufferDrawBuffersEXT(uint framebuffer, uint n, DrawBufferMode * bufs);
        
        unsafe void glFramebufferFetchBarrierEXT();
        
        unsafe void glFramebufferFetchBarrierQCOM();
        
        unsafe void glFramebufferFoveationConfigQCOM(uint framebuffer, uint numLayers, uint focalPointsPerLayer, uint requestedFeatures, uint * providedFeatures);
        
        unsafe void glFramebufferFoveationParametersQCOM(uint framebuffer, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea);
        
        unsafe void glFramebufferParameteri(FramebufferTarget target, FramebufferParameterName pname, int param);
        
        unsafe void glFramebufferPixelLocalStorageSizeEXT(uint target, uint size);
        
        unsafe void glFramebufferReadBufferEXT(uint framebuffer, ReadBufferMode mode);
        
        unsafe void glFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
        
        unsafe void glFramebufferRenderbufferEXT(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
        
        unsafe void glFramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
        
        unsafe void glFramebufferSampleLocationsfvARB(FramebufferTarget target, uint start, uint count, float * v);
        
        unsafe void glFramebufferSampleLocationsfvNV(FramebufferTarget target, uint start, uint count, float * v);
        
        unsafe void glFramebufferSamplePositionsfvAMD(FramebufferTarget target, uint numsamples, uint pixelindex, float * values);
        
        unsafe void glFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
        
        unsafe void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        
        unsafe void glFramebufferTexture1DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        
        unsafe void glFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        
        unsafe void glFramebufferTexture2DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        
        unsafe void glFramebufferTexture2DDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int xscale, int yscale);
        
        unsafe void glFramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, uint samples);
        
        unsafe void glFramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, uint samples);
        
        unsafe void glFramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        
        unsafe void glFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);
        
        unsafe void glFramebufferTexture3DEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);
        
        unsafe void glFramebufferTexture3DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);
        
        unsafe void glFramebufferTextureARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
        
        unsafe void glFramebufferTextureEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
        
        unsafe void glFramebufferTextureFaceARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face);
        
        unsafe void glFramebufferTextureFaceEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, TextureTarget face);
        
        unsafe void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);
        
        unsafe void glFramebufferTextureLayerARB(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);
        
        unsafe void glFramebufferTextureLayerEXT(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);
        
        unsafe void glFramebufferTextureLayerDownsampleIMG(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer, int xscale, int yscale);
        
        unsafe void glFramebufferTextureMultisampleMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, uint samples, int baseViewIndex, uint numViews);
        
        unsafe void glFramebufferTextureMultiviewOVR(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int baseViewIndex, uint numViews);
        
        unsafe void glFramebufferTextureOES(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
        
        unsafe void glFreeObjectBufferATI(uint buffer);
        
        unsafe void glFrontFace(FrontFaceDirection mode);
        
        unsafe void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
        
        unsafe void glFrustumf(float l, float r, float b, float t, float n, float f);
        
        unsafe void glFrustumfOES(float l, float r, float b, float t, float n, float f);
        
        unsafe void glFrustumx(int l, int r, int b, int t, int n, int f);
        
        unsafe void glFrustumxOES(int l, int r, int b, int t, int n, int f);
        
        unsafe uint glGenAsyncMarkersSGIX(uint range);
        
        unsafe void glGenBuffers(uint n, uint * buffers);
        
        unsafe void glGenBuffersARB(uint n, uint * buffers);
        
        unsafe void glGenFencesAPPLE(uint n, uint * fences);
        
        unsafe void glGenFencesNV(uint n, uint * fences);
        
        unsafe uint glGenFragmentShadersATI(uint range);
        
        unsafe void glGenFramebuffers(uint n, uint * framebuffers);
        
        unsafe void glGenFramebuffersEXT(uint n, uint * framebuffers);
        
        unsafe void glGenFramebuffersOES(uint n, uint * framebuffers);
        
        unsafe uint glGenLists(uint range);
        
        unsafe void glGenOcclusionQueriesNV(uint n, uint * ids);
        
        unsafe uint glGenPathsNV(uint range);
        
        unsafe void glGenPerfMonitorsAMD(uint n, uint * monitors);
        
        unsafe void glGenProgramPipelines(uint n, uint * pipelines);
        
        unsafe void glGenProgramPipelinesEXT(uint n, uint * pipelines);
        
        unsafe void glGenProgramsARB(uint n, uint * programs);
        
        unsafe void glGenProgramsNV(uint n, uint * programs);
        
        unsafe void glGenQueries(uint n, uint * ids);
        
        unsafe void glGenQueriesARB(uint n, uint * ids);
        
        unsafe void glGenQueriesEXT(uint n, uint * ids);
        
        unsafe void glGenQueryResourceTagNV(uint n, int * tagIds);
        
        unsafe void glGenRenderbuffers(uint n, uint * renderbuffers);
        
        unsafe void glGenRenderbuffersEXT(uint n, uint * renderbuffers);
        
        unsafe void glGenRenderbuffersOES(uint n, uint * renderbuffers);
        
        unsafe void glGenSamplers(uint count, uint * samplers);
        
        unsafe void glGenSemaphoresEXT(uint n, uint * semaphores);
        
        unsafe uint glGenSymbolsEXT(DataTypeEXT datatype, VertexShaderStorageTypeEXT storagetype, ParameterRangeEXT range, uint components);
        
        unsafe void glGenTextures(uint n, uint * textures);
        
        unsafe void glGenTexturesEXT(uint n, uint * textures);
        
        unsafe void glGenTransformFeedbacks(uint n, uint * ids);
        
        unsafe void glGenTransformFeedbacksNV(uint n, uint * ids);
        
        unsafe void glGenVertexArrays(uint n, uint * arrays);
        
        unsafe void glGenVertexArraysAPPLE(uint n, uint * arrays);
        
        unsafe void glGenVertexArraysOES(uint n, uint * arrays);
        
        unsafe uint glGenVertexShadersEXT(uint range);
        
        unsafe void glGenerateMipmap(TextureTarget target);
        
        unsafe void glGenerateMipmapEXT(TextureTarget target);
        
        unsafe void glGenerateMipmapOES(TextureTarget target);
        
        unsafe void glGenerateMultiTexMipmapEXT(TextureUnit texunit, TextureTarget target);
        
        unsafe void glGenerateTextureMipmap(uint texture);
        
        unsafe void glGenerateTextureMipmapEXT(uint texture, TextureTarget target);
        
        unsafe void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, AtomicCounterBufferPName pname, int * PARAMS);
        
        unsafe void glGetActiveAttrib(uint program, uint index, uint bufSize, uint * length, int * size, AttributeType * type, char * name);
        
        unsafe void glGetActiveAttribARB(uint programObj, uint index, uint maxLength, uint * length, int * size, AttributeType * type, char * name);
        
        unsafe void glGetActiveSubroutineName(uint program, ShaderType shadertype, uint index, uint bufsize, uint * length, char * name);
        
        unsafe void glGetActiveSubroutineUniformName(uint program, ShaderType shadertype, uint index, uint bufsize, uint * length, char * name);
        
        unsafe void glGetActiveSubroutineUniformiv(uint program, ShaderType shadertype, uint index, SubroutineParameterName pname, int * values);
        
        unsafe void glGetActiveUniform(uint program, uint index, uint bufSize, uint * length, int * size, UniformType * type, char * name);
        
        unsafe void glGetActiveUniformARB(uint programObj, uint index, uint maxLength, uint * length, int * size, UniformType * type, char * name);
        
        unsafe void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, uint bufSize, uint * length, char * uniformBlockName);
        
        unsafe void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int * PARAMS);
        
        unsafe void glGetActiveUniformName(uint program, uint uniformIndex, uint bufSize, uint * length, char * uniformName);
        
        unsafe void glGetActiveUniformsiv(uint program, uint uniformCount, uint * uniformIndices, UniformPName pname, int * PARAMS);
        
        unsafe void glGetArrayObjectfvATI(EnableCap array, ArrayObjectPNameATI pname, float * PARAMS);
        
        unsafe void glGetArrayObjectivATI(EnableCap array, ArrayObjectPNameATI pname, int * PARAMS);
        
        unsafe void glGetAttachedObjectsARB(uint containerObj, uint maxCount, uint * count, uint * obj);
        
        unsafe void glGetAttachedShaders(uint program, uint maxCount, uint * count, uint * shaders);
        
        unsafe int glGetAttribLocation(uint program, char * name);
        
        unsafe int glGetAttribLocationARB(uint programObj, char * name);
        
        unsafe void glGetBooleanIndexedvEXT(BufferTargetARB target, uint index, bool * data);
        
        unsafe void glGetBooleani_v(BufferTargetARB target, uint index, bool * data);
        
        unsafe void glGetBooleanv(GetPName pname, bool * data);
        
        unsafe void glGetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long * PARAMS);
        
        unsafe void glGetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int * PARAMS);
        
        unsafe void glGetBufferParameterivARB(BufferTargetARB target, BufferPNameARB pname, int * PARAMS);
        
        unsafe void glGetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, void * * PARAMS);
        
        unsafe void glGetBufferPointervARB(BufferTargetARB target, BufferPointerNameARB pname, void * * PARAMS);
        
        unsafe void glGetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void * * PARAMS);
        
        unsafe void glGetBufferSubData(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glGetBufferSubDataARB(BufferTargetARB target, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glGetClipPlane(ClipPlaneName plane, double * equation);
        
        unsafe void glGetClipPlanef(ClipPlaneName plane, float * equation);
        
        unsafe void glGetClipPlanefOES(ClipPlaneName plane, float * equation);
        
        unsafe void glGetClipPlanex(ClipPlaneName plane, int * equation);
        
        unsafe void glGetClipPlanexOES(ClipPlaneName plane, int * equation);
        
        unsafe void glGetColorTable(ColorTableTarget target, PixelFormat format, PixelType type, void * table);
        
        unsafe void glGetColorTableEXT(ColorTableTarget target, PixelFormat format, PixelType type, void * data);
        
        unsafe void glGetColorTableParameterfv(ColorTableTarget target, GetColorTableParameterPNameSGI pname, float * PARAMS);
        
        unsafe void glGetColorTableParameterfvEXT(ColorTableTarget target, GetColorTableParameterPNameSGI pname, float * PARAMS);
        
        unsafe void glGetColorTableParameterfvSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, float * PARAMS);
        
        unsafe void glGetColorTableParameteriv(ColorTableTarget target, GetColorTableParameterPNameSGI pname, int * PARAMS);
        
        unsafe void glGetColorTableParameterivEXT(ColorTableTarget target, GetColorTableParameterPNameSGI pname, int * PARAMS);
        
        unsafe void glGetColorTableParameterivSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, int * PARAMS);
        
        unsafe void glGetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, void * table);
        
        unsafe void glGetCombinerInputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, float * PARAMS);
        
        unsafe void glGetCombinerInputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerVariableNV variable, CombinerParameterNV pname, int * PARAMS);
        
        unsafe void glGetCombinerOutputParameterfvNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, float * PARAMS);
        
        unsafe void glGetCombinerOutputParameterivNV(CombinerStageNV stage, CombinerPortionNV portion, CombinerParameterNV pname, int * PARAMS);
        
        unsafe void glGetCombinerStageParameterfvNV(CombinerStageNV stage, CombinerParameterNV pname, float * PARAMS);
        
        unsafe void glGetCompressedMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int lod, void * img);
        
        unsafe void glGetCompressedTexImage(TextureTarget target, int level, void * img);
        
        unsafe void glGetCompressedTexImageARB(TextureTarget target, int level, void * img);
        
        unsafe void glGetCompressedTextureImage(uint texture, int level, uint bufSize, void * pixels);
        
        unsafe void glGetCompressedTextureImageEXT(uint texture, TextureTarget target, int lod, void * img);
        
        unsafe void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, uint bufSize, void * pixels);
        
        unsafe void glGetConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, void * image);
        
        unsafe void glGetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, void * image);
        
        unsafe void glGetConvolutionParameterfv(ConvolutionTarget target, ConvolutionParameterEXT pname, float * PARAMS);
        
        unsafe void glGetConvolutionParameterfvEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float * PARAMS);
        
        unsafe void glGetConvolutionParameteriv(ConvolutionTarget target, ConvolutionParameterEXT pname, int * PARAMS);
        
        unsafe void glGetConvolutionParameterivEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int * PARAMS);
        
        unsafe void glGetCoverageModulationTableNV(uint bufsize, float * v);
        
        unsafe uint glGetDebugMessageLog(uint count, uint bufSize, DebugSource * sources, DebugType * types, uint * ids, DebugSeverity * severities, uint * lengths, char * messageLog);
        
        unsafe uint glGetDebugMessageLogARB(uint count, uint bufSize, DebugSource * sources, DebugType * types, uint * ids, DebugSeverity * severities, uint * lengths, char * messageLog);
        
        unsafe uint glGetDebugMessageLogKHR(uint count, uint bufSize, DebugSource * sources, DebugType * types, uint * ids, DebugSeverity * severities, uint * lengths, char * messageLog);
        
        unsafe void glGetDetailTexFuncSGIS(TextureTarget target, float * points);
        
        unsafe void glGetDoublev(GetPName pname, double * data);
        
        unsafe void glGetDriverControlStringQCOM(uint driverControl, uint bufSize, uint * length, char * driverControlString);
        
        unsafe void glGetDriverControlsQCOM(int * num, uint size, uint * driverControls);
        
        unsafe ErrorCode glGetError();
        
        unsafe void glGetFenceivNV(uint fence, FenceParameterNameNV pname, int * PARAMS);
        
        unsafe void glGetFinalCombinerInputParameterfvNV(CombinerVariableNV variable, CombinerParameterNV pname, float * PARAMS);
        
        unsafe void glGetFinalCombinerInputParameterivNV(CombinerVariableNV variable, CombinerParameterNV pname, int * PARAMS);
        
        unsafe void glGetFirstPerfQueryIdINTEL(uint * queryId);
        
        unsafe void glGetFixedv(GetPName pname, int * PARAMS);
        
        unsafe void glGetFixedvOES(GetPName pname, int * PARAMS);
        
        unsafe void glGetFloatv(GetPName pname, float * data);
        
        unsafe void glGetFogFuncSGIS(float * points);
        
        unsafe int glGetFragDataIndex(uint program, char * name);
        
        unsafe int glGetFragDataIndexEXT(uint program, char * name);
        
        unsafe int glGetFragDataLocation(uint program, char * name);
        
        unsafe int glGetFragDataLocationEXT(uint program, char * name);
        
        unsafe void glGetFragmentLightfvSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, float * PARAMS);
        
        unsafe void glGetFragmentLightivSGIX(FragmentLightNameSGIX light, FragmentLightParameterSGIX pname, int * PARAMS);
        
        unsafe void glGetFragmentMaterialfvSGIX(MaterialFace face, MaterialParameter pname, float * PARAMS);
        
        unsafe void glGetFragmentMaterialivSGIX(MaterialFace face, MaterialParameter pname, int * PARAMS);
        
        unsafe void glGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS);
        
        unsafe void glGetFramebufferAttachmentParameterivEXT(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS);
        
        unsafe void glGetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS);
        
        unsafe void glGetFramebufferParameterfvAMD(FramebufferTarget target, FramebufferAttachmentParameterName pname, uint numsamples, uint pixelindex, uint size, float * values);
        
        unsafe void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferAttachmentParameterName pname, int * PARAMS);
        
        unsafe void glGetFramebufferParameterivEXT(uint framebuffer, GetFramebufferParameter pname, int * PARAMS);
        
        unsafe uint glGetFramebufferPixelLocalStorageSizeEXT(uint target);
        
        unsafe GraphicsResetStatus glGetGraphicsResetStatus();
        
        unsafe GraphicsResetStatus glGetGraphicsResetStatusARB();
        
        unsafe GraphicsResetStatus glGetGraphicsResetStatusEXT();
        
        unsafe GraphicsResetStatus glGetGraphicsResetStatusKHR();
        
        unsafe void glGetHistogram(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values);
        
        unsafe void glGetHistogramEXT(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values);
        
        unsafe void glGetHistogramParameterfv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float * PARAMS);
        
        unsafe void glGetHistogramParameterfvEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, float * PARAMS);
        
        unsafe void glGetHistogramParameteriv(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int * PARAMS);
        
        unsafe void glGetHistogramParameterivEXT(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int * PARAMS);
        
        unsafe void glGetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int * PARAMS);
        
        unsafe ulong glGetImageHandleARB(uint texture, int level, bool layered, int layer, PixelFormat format);
        
        unsafe ulong glGetImageHandleNV(uint texture, int level, bool layered, int layer, PixelFormat format);
        
        unsafe void glGetImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float * PARAMS);
        
        unsafe void glGetImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int * PARAMS);
        
        unsafe void glGetInfoLogARB(uint obj, uint maxLength, uint * length, char * infoLog);
        
        unsafe int glGetInstrumentsSGIX();
        
        unsafe void glGetInteger64v(GetPName pname, long * data);
        
        unsafe void glGetInteger64vAPPLE(GetPName pname, long * PARAMS);
        
        unsafe void glGetIntegerv(GetPName pname, int * data);
        
        unsafe void glGetInternalformatSampleivNV(TextureTarget target, InternalFormat internalformat, uint samples, InternalFormatPName pname, uint bufSize, int * PARAMS);
        
        unsafe void glGetInternalformati64v(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, uint bufSize, long * PARAMS);
        
        unsafe void glGetInternalformativ(TextureTarget target, InternalFormat internalformat, InternalFormatPName pname, uint bufSize, int * PARAMS);
        
        unsafe void glGetInvariantBooleanvEXT(uint id, GetVariantValueEXT value, bool * data);
        
        unsafe void glGetInvariantFloatvEXT(uint id, GetVariantValueEXT value, float * data);
        
        unsafe void glGetInvariantIntegervEXT(uint id, GetVariantValueEXT value, int * data);
        
        unsafe void glGetLightfv(LightName light, LightParameter pname, float * PARAMS);
        
        unsafe void glGetLightiv(LightName light, LightParameter pname, int * PARAMS);
        
        unsafe void glGetLightxOES(LightName light, LightParameter pname, int * PARAMS);
        
        unsafe void glGetLightxv(LightName light, LightParameter pname, int * PARAMS);
        
        unsafe void glGetLightxvOES(LightName light, LightParameter pname, int * PARAMS);
        
        unsafe void glGetListParameterfvSGIX(uint list, ListParameterName pname, float * PARAMS);
        
        unsafe void glGetListParameterivSGIX(uint list, ListParameterName pname, int * PARAMS);
        
        unsafe void glGetLocalConstantBooleanvEXT(uint id, GetVariantValueEXT value, bool * data);
        
        unsafe void glGetLocalConstantFloatvEXT(uint id, GetVariantValueEXT value, float * data);
        
        unsafe void glGetLocalConstantIntegervEXT(uint id, GetVariantValueEXT value, int * data);
        
        unsafe void glGetMapAttribParameterfvNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, float * PARAMS);
        
        unsafe void glGetMapAttribParameterivNV(EvalTargetNV target, uint index, MapAttribParameterNV pname, int * PARAMS);
        
        unsafe void glGetMapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, uint ustride, uint vstride, bool packed, void * points);
        
        unsafe void glGetMapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float * PARAMS);
        
        unsafe void glGetMapParameterivNV(EvalTargetNV target, MapParameterNV pname, int * PARAMS);
        
        unsafe void glGetMapdv(MapTarget target, GetMapQuery query, double * v);
        
        unsafe void glGetMapfv(MapTarget target, GetMapQuery query, float * v);
        
        unsafe void glGetMapiv(MapTarget target, GetMapQuery query, int * v);
        
        unsafe void glGetMapxvOES(MapTarget target, GetMapQuery query, int * v);
        
        unsafe void glGetMaterialfv(MaterialFace face, MaterialParameter pname, float * PARAMS);
        
        unsafe void glGetMaterialiv(MaterialFace face, MaterialParameter pname, int * PARAMS);
        
        unsafe void glGetMaterialxOES(MaterialFace face, MaterialParameter pname, int param);
        
        unsafe void glGetMaterialxv(MaterialFace face, MaterialParameter pname, int * PARAMS);
        
        unsafe void glGetMaterialxvOES(MaterialFace face, MaterialParameter pname, int * PARAMS);
        
        unsafe void glGetMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int * PARAMS);
        
        unsafe void glGetMinmax(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values);
        
        unsafe void glGetMinmaxEXT(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, void * values);
        
        unsafe void glGetMinmaxParameterfv(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float * PARAMS);
        
        unsafe void glGetMinmaxParameterfvEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, float * PARAMS);
        
        unsafe void glGetMinmaxParameteriv(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int * PARAMS);
        
        unsafe void glGetMinmaxParameterivEXT(MinmaxTargetEXT target, GetMinmaxParameterPNameEXT pname, int * PARAMS);
        
        unsafe void glGetMultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS);
        
        unsafe void glGetMultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glGetMultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double * PARAMS);
        
        unsafe void glGetMultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float * PARAMS);
        
        unsafe void glGetMultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glGetMultiTexImageEXT(TextureUnit texunit, TextureTarget target, int level, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glGetMultiTexLevelParameterfvEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetMultiTexLevelParameterivEXT(TextureUnit texunit, TextureTarget target, int level, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetMultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetMultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, uint * PARAMS);
        
        unsafe void glGetMultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetMultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetMultisamplefv(GetMultisamplePNameNV pname, uint index, float * val);
        
        unsafe void glGetMultisamplefvNV(GetMultisamplePNameNV pname, uint index, float * val);
        
        unsafe void glGetNamedBufferParameteri64v(uint buffer, VertexBufferObjectParameter pname, long * PARAMS);
        
        unsafe void glGetNamedBufferParameteriv(uint buffer, VertexBufferObjectParameter pname, int * PARAMS);
        
        unsafe void glGetNamedBufferParameterivEXT(uint buffer, VertexBufferObjectParameter pname, int * PARAMS);
        
        unsafe void glGetNamedBufferParameterui64vNV(uint buffer, VertexBufferObjectParameter pname, ulong * PARAMS);
        
        unsafe void glGetNamedBufferPointerv(uint buffer, VertexBufferObjectParameter pname, void * * PARAMS);
        
        unsafe void glGetNamedBufferPointervEXT(uint buffer, VertexBufferObjectParameter pname, void * * PARAMS);
        
        unsafe void glGetNamedBufferSubData(uint buffer, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glGetNamedBufferSubDataEXT(uint buffer, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS);
        
        unsafe void glGetNamedFramebufferAttachmentParameterivEXT(uint framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int * PARAMS);
        
        unsafe void glGetNamedFramebufferParameteriv(uint framebuffer, GetFramebufferParameter pname, int * param);
        
        unsafe void glGetNamedFramebufferParameterivEXT(uint framebuffer, GetFramebufferParameter pname, int * PARAMS);
        
        unsafe void glGetNamedProgramLocalParameterIivEXT(uint program, ProgramTarget target, uint index, int * PARAMS);
        
        unsafe void glGetNamedProgramLocalParameterIuivEXT(uint program, ProgramTarget target, uint index, uint * PARAMS);
        
        unsafe void glGetNamedProgramLocalParameterdvEXT(uint program, ProgramTarget target, uint index, double * PARAMS);
        
        unsafe void glGetNamedProgramLocalParameterfvEXT(uint program, ProgramTarget target, uint index, float * PARAMS);
        
        unsafe void glGetNamedProgramStringEXT(uint program, ProgramTarget target, ProgramStringProperty pname, void * STRING);
        
        unsafe void glGetNamedProgramivEXT(uint program, ProgramTarget target, ProgramPropertyARB pname, int * PARAMS);
        
        unsafe void glGetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameterName pname, int * PARAMS);
        
        unsafe void glGetNamedRenderbufferParameterivEXT(uint renderbuffer, RenderbufferParameterName pname, int * PARAMS);
        
        unsafe void glGetNamedStringARB(int namelen, char * name, uint bufSize, int * stringlen, char * STRING);
        
        unsafe void glGetNextPerfQueryIdINTEL(uint queryId, uint * nextQueryId);
        
        unsafe void glGetObjectBufferfvATI(uint buffer, ArrayObjectPNameATI pname, float * PARAMS);
        
        unsafe void glGetObjectBufferivATI(uint buffer, ArrayObjectPNameATI pname, int * PARAMS);
        
        unsafe void glGetObjectLabel(ObjectIdentifier identifier, uint name, uint bufSize, uint * length, char * label);
        
        unsafe void glGetObjectPtrLabel(void * ptr, uint bufSize, uint * length, char * label);
        
        unsafe void glGetObjectPtrLabelKHR(void * ptr, uint bufSize, uint * length, char * label);
        
        unsafe void glGetOcclusionQueryivNV(uint id, OcclusionQueryParameterNameNV pname, int * PARAMS);
        
        unsafe void glGetOcclusionQueryuivNV(uint id, OcclusionQueryParameterNameNV pname, uint * PARAMS);
        
        unsafe void glGetPathColorGenfvNV(PathColor color, PathGenMode pname, float * value);
        
        unsafe void glGetPathColorGenivNV(PathColor color, PathGenMode pname, int * value);
        
        unsafe void glGetPathCommandsNV(uint path, byte * commands);
        
        unsafe void glGetPathCoordsNV(uint path, float * coords);
        
        unsafe void glGetPathDashArrayNV(uint path, float * dashArray);
        
        unsafe float glGetPathLengthNV(uint path, uint startSegment, uint numSegments);
        
        unsafe void glGetPathMetricRangeNV(uint metricQueryMask, uint firstPathName, uint numPaths, uint stride, float * metrics);
        
        unsafe void glGetPathMetricsNV(uint metricQueryMask, uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, uint stride, float * metrics);
        
        unsafe void glGetPathParameterfvNV(uint path, PathParameter pname, float * value);
        
        unsafe void glGetPathParameterivNV(uint path, PathParameter pname, int * value);
        
        unsafe void glGetPathSpacingNV(PathListMode pathListMode, uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, float advanceScale, float kerningScale, PathTransformType transformType, float * returnedSpacing);
        
        unsafe void glGetPathTexGenfvNV(TextureUnit texCoordSet, PathGenMode pname, float * value);
        
        unsafe void glGetPathTexGenivNV(TextureUnit texCoordSet, PathGenMode pname, int * value);
        
        unsafe void glGetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, char * counterName, uint counterDescLength, char * counterDesc, uint * counterOffset, uint * counterDataSize, uint * counterTypeEnum, uint * counterDataTypeEnum, ulong * rawCounterMaxValue);
        
        unsafe void glGetPerfMonitorCounterStringAMD(uint group, uint counter, uint bufSize, uint * length, char * counterString);
        
        unsafe void glGetPerfMonitorCountersAMD(uint group, int * numCounters, int * maxActiveCounters, uint counterSize, uint * counters);
        
        unsafe void glGetPerfMonitorGroupStringAMD(uint group, uint bufSize, uint * length, char * groupString);
        
        unsafe void glGetPerfMonitorGroupsAMD(int * numGroups, uint groupsSize, uint * groups);
        
        unsafe void glGetPerfQueryDataINTEL(uint queryHandle, uint flags, uint dataSize, void * data, uint * bytesWritten);
        
        unsafe void glGetPerfQueryIdByNameINTEL(char * queryName, uint * queryId);
        
        unsafe void glGetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, char * queryName, uint * dataSize, uint * noCounters, uint * noInstances, uint * capsMask);
        
        unsafe void glGetPixelMapfv(PixelMap map, float * values);
        
        unsafe void glGetPixelMapuiv(PixelMap map, uint * values);
        
        unsafe void glGetPixelMapusv(PixelMap map, ushort * values);
        
        unsafe void glGetPixelMapxv(PixelMap map, int size, int * values);
        
        unsafe void glGetPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float * PARAMS);
        
        unsafe void glGetPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int * PARAMS);
        
        unsafe void glGetPointerv(GetPointervPName pname, void * * PARAMS);
        
        unsafe void glGetPointervEXT(GetPointervPName pname, void * * PARAMS);
        
        unsafe void glGetPolygonStipple(byte * mask);
        
        unsafe void glGetProgramEnvParameterIivNV(ProgramTarget target, uint index, int * PARAMS);
        
        unsafe void glGetProgramEnvParameterIuivNV(ProgramTarget target, uint index, uint * PARAMS);
        
        unsafe void glGetProgramEnvParameterdvARB(ProgramTargetARB target, uint index, double * PARAMS);
        
        unsafe void glGetProgramEnvParameterfvARB(ProgramTargetARB target, uint index, float * PARAMS);
        
        unsafe void glGetProgramInfoLog(uint program, uint bufSize, uint * length, char * infoLog);
        
        unsafe void glGetProgramInterfaceiv(uint program, ProgramInterface programInterface, ProgramInterfacePName pname, int * PARAMS);
        
        unsafe void glGetProgramLocalParameterIivNV(ProgramTarget target, uint index, int * PARAMS);
        
        unsafe void glGetProgramLocalParameterIuivNV(ProgramTarget target, uint index, uint * PARAMS);
        
        unsafe void glGetProgramLocalParameterdvARB(ProgramTargetARB target, uint index, double * PARAMS);
        
        unsafe void glGetProgramLocalParameterfvARB(ProgramTargetARB target, uint index, float * PARAMS);
        
        unsafe void glGetProgramNamedParameterdvNV(uint id, uint len, byte * name, double * PARAMS);
        
        unsafe void glGetProgramNamedParameterfvNV(uint id, uint len, byte * name, float * PARAMS);
        
        unsafe void glGetProgramParameterdvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, double * PARAMS);
        
        unsafe void glGetProgramParameterfvNV(VertexAttribEnumNV target, uint index, VertexAttribEnumNV pname, float * PARAMS);
        
        unsafe void glGetProgramPipelineInfoLog(uint pipeline, uint bufSize, uint * length, char * infoLog);
        
        unsafe void glGetProgramPipelineInfoLogEXT(uint pipeline, uint bufSize, uint * length, char * infoLog);
        
        unsafe void glGetProgramPipelineiv(uint pipeline, PipelineParameterName pname, int * PARAMS);
        
        unsafe void glGetProgramPipelineivEXT(uint pipeline, PipelineParameterName pname, int * PARAMS);
        
        unsafe uint glGetProgramResourceIndex(uint program, ProgramInterface programInterface, char * name);
        
        unsafe int glGetProgramResourceLocation(uint program, ProgramInterface programInterface, char * name);
        
        unsafe int glGetProgramResourceLocationIndex(uint program, ProgramInterface programInterface, char * name);
        
        unsafe int glGetProgramResourceLocationIndexEXT(uint program, ProgramInterface programInterface, char * name);
        
        unsafe void glGetProgramResourceName(uint program, ProgramInterface programInterface, uint index, uint bufSize, uint * length, char * name);
        
        unsafe void glGetProgramResourceiv(uint program, ProgramInterface programInterface, uint index, uint propCount, ProgramResourceProperty * props, uint bufSize, uint * length, int * PARAMS);
        
        unsafe void glGetProgramStageiv(uint program, ShaderType shadertype, ProgramStagePName pname, int * values);
        
        unsafe void glGetProgramStringARB(ProgramTargetARB target, ProgramStringPropertyARB pname, void * STRING);
        
        unsafe void glGetProgramStringNV(uint id, VertexAttribEnumNV pname, byte * program);
        
        unsafe void glGetProgramiv(uint program, ProgramPropertyARB pname, int * PARAMS);
        
        unsafe void glGetProgramivARB(ProgramTargetARB target, ProgramPropertyARB pname, int * PARAMS);
        
        unsafe void glGetProgramivNV(uint id, VertexAttribEnumNV pname, int * PARAMS);
        
        unsafe void glGetQueryBufferObjecti64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
        
        unsafe void glGetQueryBufferObjectiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
        
        unsafe void glGetQueryBufferObjectui64v(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
        
        unsafe void glGetQueryBufferObjectuiv(uint id, uint buffer, QueryObjectParameterName pname, IntPtr offset);
        
        unsafe void glGetQueryIndexediv(QueryTarget target, uint index, QueryParameterName pname, int * PARAMS);
        
        unsafe void glGetQueryObjecti64v(uint id, QueryObjectParameterName pname, long * PARAMS);
        
        unsafe void glGetQueryObjecti64vEXT(uint id, QueryObjectParameterName pname, long * PARAMS);
        
        unsafe void glGetQueryObjectiv(uint id, QueryObjectParameterName pname, int * PARAMS);
        
        unsafe void glGetQueryObjectivARB(uint id, QueryObjectParameterName pname, int * PARAMS);
        
        unsafe void glGetQueryObjectivEXT(uint id, QueryObjectParameterName pname, int * PARAMS);
        
        unsafe void glGetQueryObjectui64v(uint id, QueryObjectParameterName pname, ulong * PARAMS);
        
        unsafe void glGetQueryObjectui64vEXT(uint id, QueryObjectParameterName pname, ulong * PARAMS);
        
        unsafe void glGetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint * PARAMS);
        
        unsafe void glGetQueryObjectuivARB(uint id, QueryObjectParameterName pname, uint * PARAMS);
        
        unsafe void glGetQueryObjectuivEXT(uint id, QueryObjectParameterName pname, uint * PARAMS);
        
        unsafe void glGetQueryiv(QueryTarget target, QueryParameterName pname, int * PARAMS);
        
        unsafe void glGetQueryivARB(QueryTarget target, QueryParameterName pname, int * PARAMS);
        
        unsafe void glGetQueryivEXT(QueryTarget target, QueryParameterName pname, int * PARAMS);
        
        unsafe void glGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int * PARAMS);
        
        unsafe void glGetRenderbufferParameterivEXT(RenderbufferTarget target, RenderbufferParameterName pname, int * PARAMS);
        
        unsafe void glGetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int * PARAMS);
        
        unsafe void glGetSamplerParameterIiv(uint sampler, SamplerParameterI pname, int * PARAMS);
        
        unsafe void glGetSamplerParameterIivEXT(uint sampler, SamplerParameterI pname, int * PARAMS);
        
        unsafe void glGetSamplerParameterIivOES(uint sampler, SamplerParameterI pname, int * PARAMS);
        
        unsafe void glGetSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint * PARAMS);
        
        unsafe void glGetSamplerParameterIuivEXT(uint sampler, SamplerParameterI pname, uint * PARAMS);
        
        unsafe void glGetSamplerParameterIuivOES(uint sampler, SamplerParameterI pname, uint * PARAMS);
        
        unsafe void glGetSamplerParameterfv(uint sampler, SamplerParameterF pname, float * PARAMS);
        
        unsafe void glGetSamplerParameteriv(uint sampler, SamplerParameterI pname, int * PARAMS);
        
        unsafe void glGetSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong * PARAMS);
        
        unsafe void glGetSeparableFilter(SeparableTargetEXT target, PixelFormat format, PixelType type, void * row, void * column, void * span);
        
        unsafe void glGetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, void * row, void * column, void * span);
        
        unsafe void glGetShaderInfoLog(uint shader, uint bufSize, uint * length, char * infoLog);
        
        unsafe void glGetShaderPrecisionFormat(ShaderType shadertype, PrecisionType precisiontype, int * range, int * precision);
        
        unsafe void glGetShaderSource(uint shader, uint bufSize, uint * length, char * source);
        
        unsafe void glGetShaderSourceARB(uint obj, uint maxLength, uint * length, char * source);
        
        unsafe void glGetShaderiv(uint shader, ShaderParameterName pname, int * PARAMS);
        
        unsafe void glGetSharpenTexFuncSGIS(TextureTarget target, float * points);
        
        unsafe ushort glGetStageIndexNV(ShaderType shadertype);
        
        unsafe byte * glGetString(StringName name);
        
        unsafe byte * glGetStringi(StringName name, uint index);
        
        unsafe uint glGetSubroutineIndex(uint program, ShaderType shadertype, char * name);
        
        unsafe int glGetSubroutineUniformLocation(uint program, ShaderType shadertype, char * name);
        
        unsafe void glGetSynciv(IntPtr sync, SyncParameterName pname, uint bufSize, uint * length, int * values);
        
        unsafe void glGetSyncivAPPLE(IntPtr sync, SyncParameterName pname, uint bufSize, uint * length, int * values);
        
        unsafe void glGetTexBumpParameterfvATI(GetTexBumpParameterATI pname, float * param);
        
        unsafe void glGetTexBumpParameterivATI(GetTexBumpParameterATI pname, int * param);
        
        unsafe void glGetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS);
        
        unsafe void glGetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glGetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glGetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glGetTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, float * weights);
        
        unsafe void glGetTexGendv(TextureCoordName coord, TextureGenParameter pname, double * PARAMS);
        
        unsafe void glGetTexGenfv(TextureCoordName coord, TextureGenParameter pname, float * PARAMS);
        
        unsafe void glGetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float * PARAMS);
        
        unsafe void glGetTexGeniv(TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glGetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glGetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glGetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glGetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTexParameterIivOES(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint * PARAMS);
        
        unsafe void glGetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, uint * PARAMS);
        
        unsafe void glGetTexParameterIuivOES(TextureTarget target, GetTextureParameter pname, uint * PARAMS);
        
        unsafe void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTexParameterxv(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe ulong glGetTextureHandleARB(uint texture);
        
        unsafe ulong glGetTextureHandleIMG(uint texture);
        
        unsafe ulong glGetTextureHandleNV(uint texture);
        
        unsafe void glGetTextureImage(uint texture, int level, PixelFormat format, PixelType type, uint bufSize, void * pixels);
        
        unsafe void glGetTextureImageEXT(uint texture, TextureTarget target, int level, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glGetTextureLevelParameterfv(uint texture, int level, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetTextureLevelParameterfvEXT(uint texture, TextureTarget target, int level, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetTextureLevelParameteriv(uint texture, int level, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTextureLevelParameterivEXT(uint texture, TextureTarget target, int level, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTextureParameterIiv(uint texture, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTextureParameterIivEXT(uint texture, TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTextureParameterIuiv(uint texture, GetTextureParameter pname, uint * PARAMS);
        
        unsafe void glGetTextureParameterIuivEXT(uint texture, TextureTarget target, GetTextureParameter pname, uint * PARAMS);
        
        unsafe void glGetTextureParameterfv(uint texture, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetTextureParameterfvEXT(uint texture, TextureTarget target, GetTextureParameter pname, float * PARAMS);
        
        unsafe void glGetTextureParameteriv(uint texture, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glGetTextureParameterivEXT(uint texture, TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe ulong glGetTextureSamplerHandleARB(uint texture, uint sampler);
        
        unsafe ulong glGetTextureSamplerHandleIMG(uint texture, uint sampler);
        
        unsafe ulong glGetTextureSamplerHandleNV(uint texture, uint sampler);
        
        unsafe void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, uint bufSize, void * pixels);
        
        unsafe void glGetTrackMatrixivNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV pname, int * PARAMS);
        
        unsafe void glGetTransformFeedbackVarying(uint program, uint index, uint bufSize, uint * length, uint * size, GlslTypeToken * type, char * name);
        
        unsafe void glGetTransformFeedbackVaryingEXT(uint program, uint index, uint bufSize, uint * length, uint * size, GlslTypeToken * type, char * name);
        
        unsafe void glGetTransformFeedbackVaryingNV(uint program, uint index, int * location);
        
        unsafe void glGetTransformFeedbacki64_v(uint xfb, TransformFeedbackPName pname, uint index, long * param);
        
        unsafe void glGetTransformFeedbacki_v(uint xfb, TransformFeedbackPName pname, uint index, int * param);
        
        unsafe void glGetTransformFeedbackiv(uint xfb, TransformFeedbackPName pname, int * param);
        
        unsafe void glGetTranslatedShaderSourceANGLE(uint shader, uint bufsize, uint * length, char * source);
        
        unsafe uint glGetUniformBlockIndex(uint program, char * uniformBlockName);
        
        unsafe int glGetUniformBufferSizeEXT(uint program, int location);
        
        unsafe void glGetUniformIndices(uint program, uint uniformCount, char * * uniformNames, uint * uniformIndices);
        
        unsafe int glGetUniformLocation(uint program, char * name);
        
        unsafe int glGetUniformLocationARB(uint programObj, char * name);
        
        unsafe IntPtr glGetUniformOffsetEXT(uint program, int location);
        
        unsafe void glGetUniformSubroutineuiv(ShaderType shadertype, int location, uint * PARAMS);
        
        unsafe void glGetUniformdv(uint program, int location, double * PARAMS);
        
        unsafe void glGetUniformfv(uint program, int location, float * PARAMS);
        
        unsafe void glGetUniformfvARB(uint programObj, int location, float * PARAMS);
        
        unsafe void glGetUniformi64vARB(uint program, int location, long * PARAMS);
        
        unsafe void glGetUniformi64vNV(uint program, int location, long * PARAMS);
        
        unsafe void glGetUniformiv(uint program, int location, int * PARAMS);
        
        unsafe void glGetUniformivARB(uint programObj, int location, int * PARAMS);
        
        unsafe void glGetUniformui64vARB(uint program, int location, ulong * PARAMS);
        
        unsafe void glGetUniformui64vNV(uint program, int location, ulong * PARAMS);
        
        unsafe void glGetUniformuiv(uint program, int location, uint * PARAMS);
        
        unsafe void glGetUniformuivEXT(uint program, int location, uint * PARAMS);
        
        unsafe void glGetUnsignedBytevEXT(GetPName pname, byte * data);
        
        unsafe void glGetVariantArrayObjectfvATI(uint id, ArrayObjectPNameATI pname, float * PARAMS);
        
        unsafe void glGetVariantArrayObjectivATI(uint id, ArrayObjectPNameATI pname, int * PARAMS);
        
        unsafe void glGetVariantBooleanvEXT(uint id, GetVariantValueEXT value, bool * data);
        
        unsafe void glGetVariantFloatvEXT(uint id, GetVariantValueEXT value, float * data);
        
        unsafe void glGetVariantIntegervEXT(uint id, GetVariantValueEXT value, int * data);
        
        unsafe void glGetVariantPointervEXT(uint id, GetVariantValueEXT value, void * * data);
        
        unsafe int glGetVaryingLocationNV(uint program, char * name);
        
        unsafe void glGetVertexArrayIndexed64iv(uint vaobj, uint index, VertexArrayPName pname, long * param);
        
        unsafe void glGetVertexArrayIndexediv(uint vaobj, uint index, VertexArrayPName pname, int * param);
        
        unsafe void glGetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexArrayPName pname, int * param);
        
        unsafe void glGetVertexArrayIntegervEXT(uint vaobj, VertexArrayPName pname, int * param);
        
        unsafe void glGetVertexArrayPointeri_vEXT(uint vaobj, uint index, VertexArrayPName pname, void * * param);
        
        unsafe void glGetVertexArrayPointervEXT(uint vaobj, VertexArrayPName pname, void * * param);
        
        unsafe void glGetVertexArrayiv(uint vaobj, VertexArrayPName pname, int * param);
        
        unsafe void glGetVertexAttribArrayObjectfvATI(uint index, ArrayObjectPNameATI pname, float * PARAMS);
        
        unsafe void glGetVertexAttribArrayObjectivATI(uint index, ArrayObjectPNameATI pname, int * PARAMS);
        
        unsafe void glGetVertexAttribIiv(uint index, VertexAttribEnum pname, int * PARAMS);
        
        unsafe void glGetVertexAttribIivEXT(uint index, VertexAttribEnum pname, int * PARAMS);
        
        unsafe void glGetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint * PARAMS);
        
        unsafe void glGetVertexAttribIuivEXT(uint index, VertexAttribEnum pname, uint * PARAMS);
        
        unsafe void glGetVertexAttribLdv(uint index, VertexAttribEnum pname, double * PARAMS);
        
        unsafe void glGetVertexAttribLdvEXT(uint index, VertexAttribEnum pname, double * PARAMS);
        
        unsafe void glGetVertexAttribLi64vNV(uint index, VertexAttribEnum pname, long * PARAMS);
        
        unsafe void glGetVertexAttribLui64vARB(uint index, VertexAttribEnum pname, ulong * PARAMS);
        
        unsafe void glGetVertexAttribLui64vNV(uint index, VertexAttribEnum pname, ulong * PARAMS);
        
        unsafe void glGetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, void * * pointer);
        
        unsafe void glGetVertexAttribPointervARB(uint index, VertexAttribPointerPropertyARB pname, void * * pointer);
        
        unsafe void glGetVertexAttribPointervNV(uint index, VertexAttribEnumNV pname, void * * pointer);
        
        unsafe void glGetVertexAttribdv(uint index, VertexAttribPropertyARB pname, double * PARAMS);
        
        unsafe void glGetVertexAttribdvARB(uint index, VertexAttribPropertyARB pname, double * PARAMS);
        
        unsafe void glGetVertexAttribdvNV(uint index, VertexAttribEnumNV pname, double * PARAMS);
        
        unsafe void glGetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float * PARAMS);
        
        unsafe void glGetVertexAttribfvARB(uint index, VertexAttribPropertyARB pname, float * PARAMS);
        
        unsafe void glGetVertexAttribfvNV(uint index, VertexAttribEnumNV pname, float * PARAMS);
        
        unsafe void glGetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int * PARAMS);
        
        unsafe void glGetVertexAttribivARB(uint index, VertexAttribPropertyARB pname, int * PARAMS);
        
        unsafe void glGetVertexAttribivNV(uint index, VertexAttribEnumNV pname, int * PARAMS);
        
        unsafe void glGetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, uint bufSize, void * table);
        
        unsafe void glGetnColorTableARB(ColorTableTarget target, PixelFormat format, PixelType type, uint bufSize, void * table);
        
        unsafe void glGetnCompressedTexImage(TextureTarget target, int lod, uint bufSize, void * pixels);
        
        unsafe void glGetnCompressedTexImageARB(TextureTarget target, int lod, uint bufSize, void * img);
        
        unsafe void glGetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, uint bufSize, void * image);
        
        unsafe void glGetnConvolutionFilterARB(ConvolutionTarget target, PixelFormat format, PixelType type, uint bufSize, void * image);
        
        unsafe void glGetnHistogram(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values);
        
        unsafe void glGetnHistogramARB(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values);
        
        unsafe void glGetnMapdv(MapTarget target, MapQuery query, uint bufSize, double * v);
        
        unsafe void glGetnMapdvARB(MapTarget target, MapQuery query, uint bufSize, double * v);
        
        unsafe void glGetnMapfv(MapTarget target, MapQuery query, uint bufSize, float * v);
        
        unsafe void glGetnMapfvARB(MapTarget target, MapQuery query, uint bufSize, float * v);
        
        unsafe void glGetnMapiv(MapTarget target, MapQuery query, uint bufSize, int * v);
        
        unsafe void glGetnMapivARB(MapTarget target, MapQuery query, uint bufSize, int * v);
        
        unsafe void glGetnMinmax(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values);
        
        unsafe void glGetnMinmaxARB(MinmaxTargetEXT target, bool reset, PixelFormat format, PixelType type, uint bufSize, void * values);
        
        unsafe void glGetnPixelMapfv(PixelMap map, uint bufSize, float * values);
        
        unsafe void glGetnPixelMapfvARB(PixelMap map, uint bufSize, float * values);
        
        unsafe void glGetnPixelMapuiv(PixelMap map, uint bufSize, uint * values);
        
        unsafe void glGetnPixelMapuivARB(PixelMap map, uint bufSize, uint * values);
        
        unsafe void glGetnPixelMapusv(PixelMap map, uint bufSize, ushort * values);
        
        unsafe void glGetnPixelMapusvARB(PixelMap map, uint bufSize, ushort * values);
        
        unsafe void glGetnPolygonStipple(uint bufSize, byte * pattern);
        
        unsafe void glGetnPolygonStippleARB(uint bufSize, byte * pattern);
        
        unsafe void glGetnSeparableFilter(SeparableTargetEXT target, PixelFormat format, PixelType type, uint rowBufSize, void * row, uint columnBufSize, void * column, void * span);
        
        unsafe void glGetnSeparableFilterARB(SeparableTargetEXT target, PixelFormat format, PixelType type, uint rowBufSize, void * row, uint columnBufSize, void * column, void * span);
        
        unsafe void glGetnTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, uint bufSize, void * pixels);
        
        unsafe void glGetnTexImageARB(TextureTarget target, int level, PixelFormat format, PixelType type, uint bufSize, void * img);
        
        unsafe void glGetnUniformdv(uint program, int location, uint bufSize, double * PARAMS);
        
        unsafe void glGetnUniformdvARB(uint program, int location, uint bufSize, double * PARAMS);
        
        unsafe void glGetnUniformfv(uint program, int location, uint bufSize, float * PARAMS);
        
        unsafe void glGetnUniformfvARB(uint program, int location, uint bufSize, float * PARAMS);
        
        unsafe void glGetnUniformfvEXT(uint program, int location, uint bufSize, float * PARAMS);
        
        unsafe void glGetnUniformfvKHR(uint program, int location, uint bufSize, float * PARAMS);
        
        unsafe void glGetnUniformi64vARB(uint program, int location, uint bufSize, long * PARAMS);
        
        unsafe void glGetnUniformiv(uint program, int location, uint bufSize, int * PARAMS);
        
        unsafe void glGetnUniformivARB(uint program, int location, uint bufSize, int * PARAMS);
        
        unsafe void glGetnUniformivEXT(uint program, int location, uint bufSize, int * PARAMS);
        
        unsafe void glGetnUniformivKHR(uint program, int location, uint bufSize, int * PARAMS);
        
        unsafe void glGetnUniformui64vARB(uint program, int location, uint bufSize, ulong * PARAMS);
        
        unsafe void glGetnUniformuiv(uint program, int location, uint bufSize, uint * PARAMS);
        
        unsafe void glGetnUniformuivARB(uint program, int location, uint bufSize, uint * PARAMS);
        
        unsafe void glGetnUniformuivKHR(uint program, int location, uint bufSize, uint * PARAMS);
        
        unsafe void glGlobalAlphaFactorbSUN(sbyte factor);
        
        unsafe void glGlobalAlphaFactordSUN(double factor);
        
        unsafe void glGlobalAlphaFactorfSUN(float factor);
        
        unsafe void glGlobalAlphaFactoriSUN(int factor);
        
        unsafe void glGlobalAlphaFactorsSUN(short factor);
        
        unsafe void glGlobalAlphaFactorubSUN(byte factor);
        
        unsafe void glGlobalAlphaFactoruiSUN(uint factor);
        
        unsafe void glGlobalAlphaFactorusSUN(ushort factor);
        
        unsafe void glHint(HintTarget target, HintMode mode);
        
        unsafe void glHintPGI(HintTargetPGI target, int mode);
        
        unsafe void glHistogram(HistogramTargetEXT target, uint width, InternalFormat internalformat, bool sink);
        
        unsafe void glHistogramEXT(HistogramTargetEXT target, uint width, InternalFormat internalformat, bool sink);
        
        unsafe void glIglooInterfaceSGIX(IglooFunctionSelectSGIX pname, void * PARAMS);
        
        unsafe void glImageTransformParameterfHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float param);
        
        unsafe void glImageTransformParameterfvHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float * PARAMS);
        
        unsafe void glImageTransformParameteriHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int param);
        
        unsafe void glImageTransformParameterivHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int * PARAMS);
        
        unsafe void glImportMemoryFdEXT(uint memory, ulong size, ExternalHandleType handleType, int fd);
        
        unsafe void glImportMemoryWin32HandleEXT(uint memory, ulong size, ExternalHandleType handleType, void * handle);
        
        unsafe void glImportMemoryWin32NameEXT(uint memory, ulong size, ExternalHandleType handleType, void * name);
        
        unsafe void glImportSemaphoreFdEXT(uint semaphore, ExternalHandleType handleType, int fd);
        
        unsafe void glImportSemaphoreWin32HandleEXT(uint semaphore, ExternalHandleType handleType, void * handle);
        
        unsafe void glImportSemaphoreWin32NameEXT(uint semaphore, ExternalHandleType handleType, void * name);
        
        unsafe void glIndexFuncEXT(IndexFunctionEXT func, float REF);
        
        unsafe void glIndexMask(uint mask);
        
        unsafe void glIndexMaterialEXT(MaterialFace face, IndexMaterialParameterEXT mode);
        
        unsafe void glIndexPointer(IndexPointerType type, uint stride, void * pointer);
        
        unsafe void glIndexPointerEXT(IndexPointerType type, uint stride, uint count, void * pointer);
        
        unsafe void glIndexPointerListIBM(IndexPointerType type, int stride, void * * pointer, int ptrstride);
        
        unsafe void glIndexd(double c);
        
        unsafe void glIndexdv(double * c);
        
        unsafe void glIndexf(float c);
        
        unsafe void glIndexfv(float * c);
        
        unsafe void glIndexi(int c);
        
        unsafe void glIndexiv(int * c);
        
        unsafe void glIndexs(short c);
        
        unsafe void glIndexsv(short * c);
        
        unsafe void glIndexub(byte c);
        
        unsafe void glIndexubv(byte * c);
        
        unsafe void glIndexxOES(int component);
        
        unsafe void glIndexxvOES(int * component);
        
        unsafe void glInitNames();
        
        unsafe void glInsertComponentEXT(uint res, uint src, uint num);
        
        unsafe void glInsertEventMarkerEXT(uint length, char * marker);
        
        unsafe void glInstrumentsBufferSGIX(uint size, int * buffer);
        
        unsafe void glInterleavedArrays(InterleavedArrayFormat format, uint stride, void * pointer);
        
        unsafe void glInterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight);
        
        unsafe void glInvalidateBufferData(uint buffer);
        
        unsafe void glInvalidateBufferSubData(uint buffer, IntPtr offset, UIntPtr length);
        
        unsafe void glInvalidateFramebuffer(FramebufferTarget target, uint numAttachments, FramebufferAttachment * attachments);
        
        unsafe void glInvalidateNamedFramebufferData(uint framebuffer, uint numAttachments, FramebufferAttachment * attachments);
        
        unsafe void glInvalidateNamedFramebufferSubData(uint framebuffer, uint numAttachments, FramebufferAttachment * attachments, int x, int y, uint width, uint height);
        
        unsafe void glInvalidateSubFramebuffer(FramebufferTarget target, uint numAttachments, FramebufferAttachment * attachments, int x, int y, uint width, uint height);
        
        unsafe void glInvalidateTexImage(uint texture, int level);
        
        unsafe void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth);
        
        unsafe bool glIsAsyncMarkerSGIX(uint marker);
        
        unsafe bool glIsBuffer(uint buffer);
        
        unsafe bool glIsBufferARB(uint buffer);
        
        unsafe bool glIsCommandListNV(uint list);
        
        unsafe bool glIsEnabled(EnableCap cap);
        
        unsafe bool glIsEnabledIndexedEXT(EnableCap target, uint index);
        
        unsafe bool glIsEnabledi(EnableCap target, uint index);
        
        unsafe bool glIsEnablediEXT(EnableCap target, uint index);
        
        unsafe bool glIsEnablediNV(EnableCap target, uint index);
        
        unsafe bool glIsEnablediOES(EnableCap target, uint index);
        
        unsafe bool glIsFenceAPPLE(uint fence);
        
        unsafe bool glIsFenceNV(uint fence);
        
        unsafe bool glIsFramebuffer(uint framebuffer);
        
        unsafe bool glIsFramebufferEXT(uint framebuffer);
        
        unsafe bool glIsFramebufferOES(uint framebuffer);
        
        unsafe bool glIsImageHandleResidentARB(ulong handle);
        
        unsafe bool glIsImageHandleResidentNV(ulong handle);
        
        unsafe bool glIsList(uint list);
        
        unsafe bool glIsMemoryObjectEXT(uint memoryObject);
        
        unsafe bool glIsNamedBufferResidentNV(uint buffer);
        
        unsafe bool glIsNamedStringARB(int namelen, char * name);
        
        unsafe bool glIsObjectBufferATI(uint buffer);
        
        unsafe bool glIsOcclusionQueryNV(uint id);
        
        unsafe bool glIsPathNV(uint path);
        
        unsafe bool glIsPointInFillPathNV(uint path, uint mask, float x, float y);
        
        unsafe bool glIsPointInStrokePathNV(uint path, float x, float y);
        
        unsafe bool glIsProgram(uint program);
        
        unsafe bool glIsProgramARB(uint program);
        
        unsafe bool glIsProgramNV(uint id);
        
        unsafe bool glIsProgramPipeline(uint pipeline);
        
        unsafe bool glIsProgramPipelineEXT(uint pipeline);
        
        unsafe bool glIsQuery(uint id);
        
        unsafe bool glIsQueryARB(uint id);
        
        unsafe bool glIsQueryEXT(uint id);
        
        unsafe bool glIsRenderbuffer(uint renderbuffer);
        
        unsafe bool glIsRenderbufferEXT(uint renderbuffer);
        
        unsafe bool glIsRenderbufferOES(uint renderbuffer);
        
        unsafe bool glIsSemaphoreEXT(uint semaphore);
        
        unsafe bool glIsSampler(uint sampler);
        
        unsafe bool glIsShader(uint shader);
        
        unsafe bool glIsStateNV(uint state);
        
        unsafe bool glIsSync(IntPtr sync);
        
        unsafe bool glIsSyncAPPLE(IntPtr sync);
        
        unsafe bool glIsTexture(uint texture);
        
        unsafe bool glIsTextureEXT(uint texture);
        
        unsafe bool glIsTextureHandleResidentARB(ulong handle);
        
        unsafe bool glIsTextureHandleResidentNV(ulong handle);
        
        unsafe bool glIsTransformFeedback(uint id);
        
        unsafe bool glIsTransformFeedbackNV(uint id);
        
        unsafe bool glIsVariantEnabledEXT(uint id, VariantCapEXT cap);
        
        unsafe bool glIsVertexArray(uint array);
        
        unsafe bool glIsVertexArrayAPPLE(uint array);
        
        unsafe bool glIsVertexArrayOES(uint array);
        
        unsafe void glLGPUInterlockNVX();
        
        unsafe void glLGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glLightEnviSGIX(LightEnvParameterSGIX pname, int param);
        
        unsafe void glLightModelf(LightModelParameter pname, float param);
        
        unsafe void glLightModelfv(LightModelParameter pname, float * PARAMS);
        
        unsafe void glLightModeli(LightModelParameter pname, int param);
        
        unsafe void glLightModeliv(LightModelParameter pname, int * PARAMS);
        
        unsafe void glLightModelx(LightModelParameter pname, int param);
        
        unsafe void glLightModelxOES(LightModelParameter pname, int param);
        
        unsafe void glLightModelxv(LightModelParameter pname, int * param);
        
        unsafe void glLightModelxvOES(LightModelParameter pname, int * param);
        
        unsafe void glLightf(LightName light, LightParameter pname, float param);
        
        unsafe void glLightfv(LightName light, LightParameter pname, float * PARAMS);
        
        unsafe void glLighti(LightName light, LightParameter pname, int param);
        
        unsafe void glLightiv(LightName light, LightParameter pname, int * PARAMS);
        
        unsafe void glLightx(LightName light, LightParameter pname, int param);
        
        unsafe void glLightxOES(LightName light, LightParameter pname, int param);
        
        unsafe void glLightxv(LightName light, LightParameter pname, int * PARAMS);
        
        unsafe void glLightxvOES(LightName light, LightParameter pname, int * PARAMS);
        
        unsafe void glLineStipple(int factor, ushort pattern);
        
        unsafe void glLineWidth(float width);
        
        unsafe void glLineWidthx(int width);
        
        unsafe void glLineWidthxOES(int width);
        
        unsafe void glLinkProgram(uint program);
        
        unsafe void glLinkProgramARB(uint programObj);
        
        unsafe void glListBase(uint BASE);
        
        unsafe void glListDrawCommandsStatesClientNV(uint list, uint segment, void * * indirects, uint * sizes, uint * states, uint * fbos, uint count);
        
        unsafe void glListParameterfSGIX(uint list, ListParameterName pname, float param);
        
        unsafe void glListParameterfvSGIX(uint list, ListParameterName pname, float * PARAMS);
        
        unsafe void glListParameteriSGIX(uint list, ListParameterName pname, int param);
        
        unsafe void glListParameterivSGIX(uint list, ListParameterName pname, int * PARAMS);
        
        unsafe void glLoadIdentity();
        
        unsafe void glLoadIdentityDeformationMapSGIX(uint mask);
        
        unsafe void glLoadMatrixd(double * m);
        
        unsafe void glLoadMatrixf(float * m);
        
        unsafe void glLoadMatrixx(int * m);
        
        unsafe void glLoadMatrixxOES(int * m);
        
        unsafe void glLoadName(uint name);
        
        unsafe void glLoadPaletteFromModelViewMatrixOES();
        
        unsafe void glLoadProgramNV(VertexAttribEnumNV target, uint id, uint len, byte * program);
        
        unsafe void glLoadTransposeMatrixd(double * m);
        
        unsafe void glLoadTransposeMatrixdARB(double * m);
        
        unsafe void glLoadTransposeMatrixf(float * m);
        
        unsafe void glLoadTransposeMatrixfARB(float * m);
        
        unsafe void glLoadTransposeMatrixxOES(int * m);
        
        unsafe void glLockArraysEXT(int first, uint count);
        
        unsafe void glLogicOp(LogicOp opcode);
        
        unsafe void glMakeImageHandleNonResidentARB(ulong handle);
        
        unsafe void glMakeImageHandleNonResidentNV(ulong handle);
        
        unsafe void glMakeNamedBufferNonResidentNV(uint buffer);
        
        unsafe void glMakeTextureHandleNonResidentARB(ulong handle);
        
        unsafe void glMakeTextureHandleNonResidentNV(ulong handle);
        
        unsafe void glMakeTextureHandleResidentARB(ulong handle);
        
        unsafe void glMakeTextureHandleResidentNV(ulong handle);
        
        unsafe void glMap1d(MapTarget target, double u1, double u2, int stride, int order, double * points);
        
        unsafe void glMap1f(MapTarget target, float u1, float u2, int stride, int order, float * points);
        
        unsafe void glMap1xOES(MapTarget target, int u1, int u2, int stride, int order, int points);
        
        unsafe void glMap2d(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double * points);
        
        unsafe void glMap2f(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float * points);
        
        unsafe void glMap2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points);
        
        unsafe void * glMapBuffer(BufferTargetARB target, BufferAccessARB access);
        
        unsafe void * glMapBufferARB(BufferTargetARB target, BufferAccessARB access);
        
        unsafe void * glMapBufferOES(BufferTargetARB target, BufferAccessARB access);
        
        unsafe void * glMapBufferRange(BufferTargetARB target, IntPtr offset, UIntPtr length, uint access);
        
        unsafe void * glMapBufferRangeEXT(BufferTargetARB target, IntPtr offset, UIntPtr length, uint access);
        
        unsafe void glMapControlPointsNV(EvalTargetNV target, uint index, MapTypeNV type, uint ustride, uint vstride, int uorder, int vorder, bool packed, void * points);
        
        unsafe void glMapGrid1d(int un, double u1, double u2);
        
        unsafe void glMapGrid1f(int un, float u1, float u2);
        
        unsafe void glMapGrid1xOES(int n, int u1, int u2);
        
        unsafe void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
        
        unsafe void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
        
        unsafe void glMapGrid2xOES(int n, int u1, int u2, int v1, int v2);
        
        unsafe void * glMapNamedBuffer(uint buffer, BufferAccessARB access);
        
        unsafe void * glMapNamedBufferEXT(uint buffer, BufferAccessARB access);
        
        unsafe void * glMapNamedBufferRange(uint buffer, IntPtr offset, UIntPtr length, uint access);
        
        unsafe void * glMapNamedBufferRangeEXT(uint buffer, IntPtr offset, UIntPtr length, uint access);
        
        unsafe void * glMapObjectBufferATI(uint buffer);
        
        unsafe void glMapParameterfvNV(EvalTargetNV target, MapParameterNV pname, float * PARAMS);
        
        unsafe void glMapParameterivNV(EvalTargetNV target, MapParameterNV pname, int * PARAMS);
        
        unsafe void glMapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double * points);
        
        unsafe void glMapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float * points);
        
        unsafe void glMapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double * points);
        
        unsafe void glMapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float * points);
        
        unsafe void glMaterialf(MaterialFace face, MaterialParameter pname, float param);
        
        unsafe void glMaterialfv(MaterialFace face, MaterialParameter pname, float * PARAMS);
        
        unsafe void glMateriali(MaterialFace face, MaterialParameter pname, int param);
        
        unsafe void glMaterialiv(MaterialFace face, MaterialParameter pname, int * PARAMS);
        
        unsafe void glMaterialx(MaterialFace face, MaterialParameter pname, int param);
        
        unsafe void glMaterialxOES(MaterialFace face, MaterialParameter pname, int param);
        
        unsafe void glMaterialxv(MaterialFace face, MaterialParameter pname, int * param);
        
        unsafe void glMaterialxvOES(MaterialFace face, MaterialParameter pname, int * param);
        
        unsafe void glMatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar);
        
        unsafe void glMatrixIndexPointerARB(int size, MatrixIndexPointerTypeARB type, uint stride, void * pointer);
        
        unsafe void glMatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, uint stride, void * pointer);
        
        unsafe void glMatrixIndexubvARB(int size, byte * indices);
        
        unsafe void glMatrixIndexuivARB(int size, uint * indices);
        
        unsafe void glMatrixIndexusvARB(int size, ushort * indices);
        
        unsafe void glMatrixLoadIdentityEXT(MatrixMode mode);
        
        unsafe void glMatrixLoadTransposedEXT(MatrixMode mode, double * m);
        
        unsafe void glMatrixLoadTransposefEXT(MatrixMode mode, float * m);
        
        unsafe void glMatrixLoaddEXT(MatrixMode mode, double * m);
        
        unsafe void glMatrixLoadfEXT(MatrixMode mode, float * m);
        
        unsafe void glMatrixMode(MatrixMode mode);
        
        unsafe void glMatrixMultTransposedEXT(MatrixMode mode, double * m);
        
        unsafe void glMatrixMultTransposefEXT(MatrixMode mode, float * m);
        
        unsafe void glMatrixMultdEXT(MatrixMode mode, double * m);
        
        unsafe void glMatrixMultfEXT(MatrixMode mode, float * m);
        
        unsafe void glMatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar);
        
        unsafe void glMatrixPopEXT(MatrixMode mode);
        
        unsafe void glMatrixPushEXT(MatrixMode mode);
        
        unsafe void glMatrixRotatedEXT(MatrixMode mode, double angle, double x, double y, double z);
        
        unsafe void glMatrixRotatefEXT(MatrixMode mode, float angle, float x, float y, float z);
        
        unsafe void glMatrixScaledEXT(MatrixMode mode, double x, double y, double z);
        
        unsafe void glMatrixScalefEXT(MatrixMode mode, float x, float y, float z);
        
        unsafe void glMatrixTranslatedEXT(MatrixMode mode, double x, double y, double z);
        
        unsafe void glMatrixTranslatefEXT(MatrixMode mode, float x, float y, float z);
        
        unsafe void glMaxShaderCompilerThreadsKHR(uint count);
        
        unsafe void glMaxShaderCompilerThreadsARB(uint count);
        
        unsafe void glMemoryBarrier(uint barriers);
        
        unsafe void glMemoryBarrierByRegion(uint barriers);
        
        unsafe void glMemoryBarrierEXT(uint barriers);
        
        unsafe void glMemoryObjectParameterivEXT(uint memoryObject, MemoryObjectParameterName pname, int * PARAMS);
        
        unsafe void glMinSampleShading(float value);
        
        unsafe void glMinSampleShadingARB(float value);
        
        unsafe void glMinSampleShadingOES(float value);
        
        unsafe void glMinmax(MinmaxTargetEXT target, InternalFormat internalformat, bool sink);
        
        unsafe void glMinmaxEXT(MinmaxTargetEXT target, InternalFormat internalformat, bool sink);
        
        unsafe void glMultMatrixd(double * m);
        
        unsafe void glMultMatrixf(float * m);
        
        unsafe void glMultMatrixx(int * m);
        
        unsafe void glMultMatrixxOES(int * m);
        
        unsafe void glMultTransposeMatrixd(double * m);
        
        unsafe void glMultTransposeMatrixdARB(double * m);
        
        unsafe void glMultTransposeMatrixf(float * m);
        
        unsafe void glMultTransposeMatrixfARB(float * m);
        
        unsafe void glMultTransposeMatrixxOES(int * m);
        
        unsafe void glMultiDrawArrays(PrimitiveType mode, int * first, uint * count, uint drawcount);
        
        unsafe void glMultiDrawArraysEXT(PrimitiveType mode, int * first, uint * count, uint primcount);
        
        unsafe void glMultiDrawArraysIndirect(PrimitiveType mode, void * indirect, uint drawcount, uint stride);
        
        unsafe void glMultiDrawArraysIndirectAMD(PrimitiveType mode, void * indirect, uint primcount, uint stride);
        
        unsafe void glMultiDrawArraysIndirectBindlessCountNV(PrimitiveType mode, void * indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount);
        
        unsafe void glMultiDrawArraysIndirectBindlessNV(PrimitiveType mode, void * indirect, uint drawCount, uint stride, int vertexBufferCount);
        
        unsafe void glMultiDrawArraysIndirectCount(PrimitiveType mode, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride);
        
        unsafe void glMultiDrawArraysIndirectCountARB(PrimitiveType mode, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride);
        
        unsafe void glMultiDrawArraysIndirectEXT(PrimitiveType mode, void * indirect, uint drawcount, uint stride);
        
        unsafe void glMultiDrawElementArrayAPPLE(PrimitiveType mode, int * first, uint * count, uint primcount);
        
        unsafe void glMultiDrawElements(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint drawcount);
        
        unsafe void glMultiDrawElementsBaseVertex(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint drawcount, int * basevertex);
        
        unsafe void glMultiDrawElementsBaseVertexEXT(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint primcount, int * basevertex);
        
        unsafe void glMultiDrawElementsEXT(PrimitiveType mode, uint * count, DrawElementsType type, void * * indices, uint primcount);
        
        unsafe void glMultiDrawElementsIndirect(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawcount, uint stride);
        
        unsafe void glMultiDrawElementsIndirectAMD(PrimitiveType mode, DrawElementsType type, void * indirect, uint primcount, uint stride);
        
        unsafe void glMultiDrawElementsIndirectBindlessCountNV(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawCount, uint maxDrawCount, uint stride, int vertexBufferCount);
        
        unsafe void glMultiDrawElementsIndirectBindlessNV(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawCount, uint stride, int vertexBufferCount);
        
        unsafe void glMultiDrawElementsIndirectCount(PrimitiveType mode, DrawElementsType type, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride);
        
        unsafe void glMultiDrawElementsIndirectCountARB(PrimitiveType mode, DrawElementsType type, void * indirect, IntPtr drawcount, uint maxdrawcount, uint stride);
        
        unsafe void glMultiDrawElementsIndirectEXT(PrimitiveType mode, DrawElementsType type, void * indirect, uint drawcount, uint stride);
        
        unsafe void glMultiDrawMeshTasksIndirectNV(IntPtr indirect, uint drawcount, uint stride);
        
        unsafe void glMultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, uint maxdrawcount, uint stride);
        
        unsafe void glMultiDrawRangeElementArrayAPPLE(PrimitiveType mode, uint start, uint end, int * first, uint * count, uint primcount);
        
        unsafe void glMultiModeDrawArraysIBM(PrimitiveType * mode, int * first, uint * count, uint primcount, int modestride);
        
        unsafe void glMultiModeDrawElementsIBM(PrimitiveType * mode, uint * count, DrawElementsType type, void * * indices, uint primcount, int modestride);
        
        unsafe void glMultiTexCoord1bOES(TextureUnit texture, sbyte s);
        
        unsafe void glMultiTexCoord1bvOES(TextureUnit texture, sbyte * coords);
        
        unsafe void glMultiTexCoord1d(TextureUnit target, double s);
        
        unsafe void glMultiTexCoord1dARB(TextureUnit target, double s);
        
        unsafe void glMultiTexCoord1dv(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord1dvARB(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord1f(TextureUnit target, float s);
        
        unsafe void glMultiTexCoord1fARB(TextureUnit target, float s);
        
        unsafe void glMultiTexCoord1fv(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord1fvARB(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord1hNV(TextureUnit target, OpenToolkit.Mathematics.Half s);
        
        unsafe void glMultiTexCoord1hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glMultiTexCoord1i(TextureUnit target, int s);
        
        unsafe void glMultiTexCoord1iARB(TextureUnit target, int s);
        
        unsafe void glMultiTexCoord1iv(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord1ivARB(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord1s(TextureUnit target, short s);
        
        unsafe void glMultiTexCoord1sARB(TextureUnit target, short s);
        
        unsafe void glMultiTexCoord1sv(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord1svARB(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord1xOES(TextureUnit texture, int s);
        
        unsafe void glMultiTexCoord1xvOES(TextureUnit texture, int * coords);
        
        unsafe void glMultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t);
        
        unsafe void glMultiTexCoord2bvOES(TextureUnit texture, sbyte * coords);
        
        unsafe void glMultiTexCoord2d(TextureUnit target, double s, double t);
        
        unsafe void glMultiTexCoord2dARB(TextureUnit target, double s, double t);
        
        unsafe void glMultiTexCoord2dv(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord2dvARB(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord2f(TextureUnit target, float s, float t);
        
        unsafe void glMultiTexCoord2fARB(TextureUnit target, float s, float t);
        
        unsafe void glMultiTexCoord2fv(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord2fvARB(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord2hNV(TextureUnit target, OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t);
        
        unsafe void glMultiTexCoord2hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glMultiTexCoord2i(TextureUnit target, int s, int t);
        
        unsafe void glMultiTexCoord2iARB(TextureUnit target, int s, int t);
        
        unsafe void glMultiTexCoord2iv(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord2ivARB(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord2s(TextureUnit target, short s, short t);
        
        unsafe void glMultiTexCoord2sARB(TextureUnit target, short s, short t);
        
        unsafe void glMultiTexCoord2sv(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord2svARB(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord2xOES(TextureUnit texture, int s, int t);
        
        unsafe void glMultiTexCoord2xvOES(TextureUnit texture, int * coords);
        
        unsafe void glMultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r);
        
        unsafe void glMultiTexCoord3bvOES(TextureUnit texture, sbyte * coords);
        
        unsafe void glMultiTexCoord3d(TextureUnit target, double s, double t, double r);
        
        unsafe void glMultiTexCoord3dARB(TextureUnit target, double s, double t, double r);
        
        unsafe void glMultiTexCoord3dv(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord3dvARB(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord3f(TextureUnit target, float s, float t, float r);
        
        unsafe void glMultiTexCoord3fARB(TextureUnit target, float s, float t, float r);
        
        unsafe void glMultiTexCoord3fv(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord3fvARB(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord3hNV(TextureUnit target, OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r);
        
        unsafe void glMultiTexCoord3hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glMultiTexCoord3i(TextureUnit target, int s, int t, int r);
        
        unsafe void glMultiTexCoord3iARB(TextureUnit target, int s, int t, int r);
        
        unsafe void glMultiTexCoord3iv(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord3ivARB(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord3s(TextureUnit target, short s, short t, short r);
        
        unsafe void glMultiTexCoord3sARB(TextureUnit target, short s, short t, short r);
        
        unsafe void glMultiTexCoord3sv(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord3svARB(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord3xOES(TextureUnit texture, int s, int t, int r);
        
        unsafe void glMultiTexCoord3xvOES(TextureUnit texture, int * coords);
        
        unsafe void glMultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q);
        
        unsafe void glMultiTexCoord4bvOES(TextureUnit texture, sbyte * coords);
        
        unsafe void glMultiTexCoord4d(TextureUnit target, double s, double t, double r, double q);
        
        unsafe void glMultiTexCoord4dARB(TextureUnit target, double s, double t, double r, double q);
        
        unsafe void glMultiTexCoord4dv(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord4dvARB(TextureUnit target, double * v);
        
        unsafe void glMultiTexCoord4f(TextureUnit target, float s, float t, float r, float q);
        
        unsafe void glMultiTexCoord4fARB(TextureUnit target, float s, float t, float r, float q);
        
        unsafe void glMultiTexCoord4fv(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord4fvARB(TextureUnit target, float * v);
        
        unsafe void glMultiTexCoord4hNV(TextureUnit target, OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r, OpenToolkit.Mathematics.Half q);
        
        unsafe void glMultiTexCoord4hvNV(TextureUnit target, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glMultiTexCoord4i(TextureUnit target, int s, int t, int r, int q);
        
        unsafe void glMultiTexCoord4iARB(TextureUnit target, int s, int t, int r, int q);
        
        unsafe void glMultiTexCoord4iv(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord4ivARB(TextureUnit target, int * v);
        
        unsafe void glMultiTexCoord4s(TextureUnit target, short s, short t, short r, short q);
        
        unsafe void glMultiTexCoord4sARB(TextureUnit target, short s, short t, short r, short q);
        
        unsafe void glMultiTexCoord4sv(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord4svARB(TextureUnit target, short * v);
        
        unsafe void glMultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q);
        
        unsafe void glMultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q);
        
        unsafe void glMultiTexCoord4xvOES(TextureUnit texture, int * coords);
        
        unsafe void glMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, uint coords);
        
        unsafe void glMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, uint * coords);
        
        unsafe void glMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, uint coords);
        
        unsafe void glMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, uint * coords);
        
        unsafe void glMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, uint coords);
        
        unsafe void glMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, uint * coords);
        
        unsafe void glMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, uint coords);
        
        unsafe void glMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, uint * coords);
        
        unsafe void glMultiTexCoordPointerEXT(TextureUnit texunit, int size, TexCoordPointerType type, uint stride, void * pointer);
        
        unsafe void glMultiTexEnvfEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float param);
        
        unsafe void glMultiTexEnvfvEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS);
        
        unsafe void glMultiTexEnviEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int param);
        
        unsafe void glMultiTexEnvivEXT(TextureUnit texunit, TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glMultiTexGendEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double param);
        
        unsafe void glMultiTexGendvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, double * PARAMS);
        
        unsafe void glMultiTexGenfEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float param);
        
        unsafe void glMultiTexGenfvEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, float * PARAMS);
        
        unsafe void glMultiTexGeniEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int param);
        
        unsafe void glMultiTexGenivEXT(TextureUnit texunit, TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glMultiTexImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int internalformat, uint width, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glMultiTexImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int internalformat, uint width, uint height, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glMultiTexImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glMultiTexParameterIivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glMultiTexParameterIuivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, uint * PARAMS);
        
        unsafe void glMultiTexParameterfEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float param);
        
        unsafe void glMultiTexParameterfvEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, float * PARAMS);
        
        unsafe void glMultiTexParameteriEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int param);
        
        unsafe void glMultiTexParameterivEXT(TextureUnit texunit, TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glMultiTexRenderbufferEXT(TextureUnit texunit, TextureTarget target, uint renderbuffer);
        
        unsafe void glMultiTexSubImage1DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glMultiTexSubImage2DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glMultiTexSubImage3DEXT(TextureUnit texunit, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glMulticastBarrierNV();
        
        unsafe void glMulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glMulticastCopyBufferSubDataNV(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size);
        
        unsafe void glMulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, uint count, float * v);
        
        unsafe void glMulticastScissorArrayvNVX(uint gpu, uint first, uint count, int * v);
        
        unsafe void glMulticastViewportArrayvNVX(uint gpu, uint first, uint count, float * v);
        
        unsafe void glMulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff);
        
        unsafe void glMulticastWaitSyncNV(uint signalGpu, uint waitGpuMask);
        
        unsafe void glNamedBufferAttachMemoryNV(uint buffer, uint memory, ulong offset);
        
        unsafe void glNamedBufferData(uint buffer, UIntPtr size, void * data, VertexBufferObjectUsage usage);
        
        unsafe void glNamedBufferDataEXT(uint buffer, UIntPtr size, void * data, VertexBufferObjectUsage usage);
        
        unsafe void glNamedBufferPageCommitmentARB(uint buffer, IntPtr offset, UIntPtr size, bool commit);
        
        unsafe void glNamedBufferPageCommitmentEXT(uint buffer, IntPtr offset, UIntPtr size, bool commit);
        
        unsafe void glNamedBufferStorage(uint buffer, UIntPtr size, void * data, uint flags);
        
        unsafe void glNamedBufferStorageExternalEXT(uint buffer, IntPtr offset, UIntPtr size, IntPtr clientBuffer, uint flags);
        
        unsafe void glNamedBufferStorageEXT(uint buffer, UIntPtr size, void * data, uint flags);
        
        unsafe void glNamedBufferStorageMemEXT(uint buffer, UIntPtr size, uint memory, ulong offset);
        
        unsafe void glNamedBufferSubData(uint buffer, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glNamedBufferSubDataEXT(uint buffer, IntPtr offset, UIntPtr size, void * data);
        
        unsafe void glNamedCopyBufferSubDataEXT(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, UIntPtr size);
        
        unsafe void glNamedFramebufferDrawBuffer(uint framebuffer, ColorBuffer buf);
        
        unsafe void glNamedFramebufferDrawBuffers(uint framebuffer, uint n, ColorBuffer * bufs);
        
        unsafe void glNamedFramebufferParameteri(uint framebuffer, FramebufferParameterName pname, int param);
        
        unsafe void glNamedFramebufferParameteriEXT(uint framebuffer, FramebufferParameterName pname, int param);
        
        unsafe void glNamedFramebufferReadBuffer(uint framebuffer, ColorBuffer src);
        
        unsafe void glNamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
        
        unsafe void glNamedFramebufferRenderbufferEXT(uint framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
        
        unsafe void glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, uint count, float * v);
        
        unsafe void glNamedFramebufferSampleLocationsfvNV(uint framebuffer, uint start, uint count, float * v);
        
        unsafe void glNamedFramebufferTexture(uint framebuffer, FramebufferAttachment attachment, uint texture, int level);
        
        unsafe void glNamedFramebufferSamplePositionsfvAMD(uint framebuffer, uint numsamples, uint pixelindex, float * values);
        
        unsafe void glNamedFramebufferTexture1DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        
        unsafe void glNamedFramebufferTexture2DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        
        unsafe void glNamedFramebufferTexture3DEXT(uint framebuffer, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);
        
        unsafe void glNamedFramebufferTextureEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level);
        
        unsafe void glNamedFramebufferTextureFaceEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, TextureTarget face);
        
        unsafe void glNamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer);
        
        unsafe void glNamedFramebufferTextureLayerEXT(uint framebuffer, FramebufferAttachment attachment, uint texture, int level, int layer);
        
        unsafe void glNamedProgramLocalParameter4dEXT(uint program, ProgramTarget target, uint index, double x, double y, double z, double w);
        
        unsafe void glNamedProgramLocalParameter4dvEXT(uint program, ProgramTarget target, uint index, double * PARAMS);
        
        unsafe void glNamedProgramLocalParameter4fEXT(uint program, ProgramTarget target, uint index, float x, float y, float z, float w);
        
        unsafe void glNamedProgramLocalParameter4fvEXT(uint program, ProgramTarget target, uint index, float * PARAMS);
        
        unsafe void glNamedProgramLocalParameterI4iEXT(uint program, ProgramTarget target, uint index, int x, int y, int z, int w);
        
        unsafe void glNamedProgramLocalParameterI4ivEXT(uint program, ProgramTarget target, uint index, int * PARAMS);
        
        unsafe void glNamedProgramLocalParameterI4uiEXT(uint program, ProgramTarget target, uint index, uint x, uint y, uint z, uint w);
        
        unsafe void glNamedProgramLocalParameterI4uivEXT(uint program, ProgramTarget target, uint index, uint * PARAMS);
        
        unsafe void glNamedProgramLocalParameters4fvEXT(uint program, ProgramTarget target, uint index, uint count, float * PARAMS);
        
        unsafe void glNamedProgramLocalParametersI4ivEXT(uint program, ProgramTarget target, uint index, uint count, int * PARAMS);
        
        unsafe void glNamedProgramLocalParametersI4uivEXT(uint program, ProgramTarget target, uint index, uint count, uint * PARAMS);
        
        unsafe void glNamedProgramStringEXT(uint program, ProgramTarget target, ProgramFormat format, uint len, void * STRING);
        
        unsafe void glNamedRenderbufferStorage(uint renderbuffer, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glNamedRenderbufferStorageEXT(uint renderbuffer, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glNamedRenderbufferStorageMultisample(uint renderbuffer, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glNamedRenderbufferStorageMultisampleAdvancedAMD(uint renderbuffer, uint samples, uint storageSamples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glNamedRenderbufferStorageMultisampleCoverageEXT(uint renderbuffer, uint coverageSamples, uint colorSamples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glNamedRenderbufferStorageMultisampleEXT(uint renderbuffer, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glNewList(uint list, ListMode mode);
        
        unsafe uint glNewObjectBufferATI(uint size, void * pointer, ArrayObjectUsageATI usage);
        
        unsafe void glNormal3b(sbyte nx, sbyte ny, sbyte nz);
        
        unsafe void glNormal3bv(sbyte * v);
        
        unsafe void glNormal3d(double nx, double ny, double nz);
        
        unsafe void glNormal3dv(double * v);
        
        unsafe void glNormal3f(float nx, float ny, float nz);
        
        unsafe void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glNormal3fVertex3fvSUN(float * n, float * v);
        
        unsafe void glNormal3fv(float * v);
        
        unsafe void glNormal3hNV(OpenToolkit.Mathematics.Half nx, OpenToolkit.Mathematics.Half ny, OpenToolkit.Mathematics.Half nz);
        
        unsafe void glNormal3hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glNormal3i(int nx, int ny, int nz);
        
        unsafe void glNormal3iv(int * v);
        
        unsafe void glNormal3s(short nx, short ny, short nz);
        
        unsafe void glNormal3sv(short * v);
        
        unsafe void glNormal3x(int nx, int ny, int nz);
        
        unsafe void glNormal3xOES(int nx, int ny, int nz);
        
        unsafe void glNormal3xvOES(int * coords);
        
        unsafe void glNormalP3ui(NormalPointerType type, uint coords);
        
        unsafe void glNormalP3uiv(NormalPointerType type, uint * coords);
        
        unsafe void glNormalPointer(NormalPointerType type, uint stride, void * pointer);
        
        unsafe void glNormalPointerEXT(NormalPointerType type, uint stride, uint count, void * pointer);
        
        unsafe void glNormalPointerListIBM(NormalPointerType type, int stride, void * * pointer, int ptrstride);
        
        unsafe void glNormalPointervINTEL(NormalPointerType type, void * * pointer);
        
        unsafe void glNormalStream3bATI(VertexStreamATI stream, sbyte nx, sbyte ny, sbyte nz);
        
        unsafe void glNormalStream3bvATI(VertexStreamATI stream, sbyte * coords);
        
        unsafe void glNormalStream3dATI(VertexStreamATI stream, double nx, double ny, double nz);
        
        unsafe void glNormalStream3dvATI(VertexStreamATI stream, double * coords);
        
        unsafe void glNormalStream3fATI(VertexStreamATI stream, float nx, float ny, float nz);
        
        unsafe void glNormalStream3fvATI(VertexStreamATI stream, float * coords);
        
        unsafe void glNormalStream3iATI(VertexStreamATI stream, int nx, int ny, int nz);
        
        unsafe void glNormalStream3ivATI(VertexStreamATI stream, int * coords);
        
        unsafe void glNormalStream3sATI(VertexStreamATI stream, short nx, short ny, short nz);
        
        unsafe void glNormalStream3svATI(VertexStreamATI stream, short * coords);
        
        unsafe void glObjectLabel(ObjectIdentifier identifier, uint name, uint length, char * label);
        
        unsafe void glObjectLabelKHR(ObjectIdentifier identifier, uint name, uint length, char * label);
        
        unsafe void glObjectPtrLabel(void * ptr, uint length, char * label);
        
        unsafe void glObjectPtrLabelKHR(void * ptr, uint length, char * label);
        
        unsafe void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
        
        unsafe void glOrthof(float l, float r, float b, float t, float n, float f);
        
        unsafe void glOrthofOES(float l, float r, float b, float t, float n, float f);
        
        unsafe void glOrthox(int l, int r, int b, int t, int n, int f);
        
        unsafe void glOrthoxOES(int l, int r, int b, int t, int n, int f);
        
        unsafe void glPNTrianglesfATI(PNTrianglesPNameATI pname, float param);
        
        unsafe void glPNTrianglesiATI(PNTrianglesPNameATI pname, int param);
        
        unsafe void glPassTexCoordATI(uint dst, uint coord, SwizzleOpATI swizzle);
        
        unsafe void glPassThrough(float token);
        
        unsafe void glPassThroughxOES(int token);
        
        unsafe void glPatchParameterfv(PatchParameterName pname, float * values);
        
        unsafe void glPatchParameteri(PatchParameterName pname, int value);
        
        unsafe void glPatchParameteriEXT(PatchParameterName pname, int value);
        
        unsafe void glPatchParameteriOES(PatchParameterName pname, int value);
        
        unsafe void glPathColorGenNV(PathColor color, PathGenMode genMode, PathColorFormat colorFormat, float * coeffs);
        
        unsafe void glPathCommandsNV(uint path, uint numCommands, byte * commands, uint numCoords, PathCoordType coordType, void * coords);
        
        unsafe void glPathCoordsNV(uint path, uint numCoords, PathCoordType coordType, void * coords);
        
        unsafe void glPathCoverDepthFuncNV(DepthFunction func);
        
        unsafe void glPathDashArrayNV(uint path, uint dashCount, float * dashArray);
        
        unsafe void glPathFogGenNV(PathGenMode genMode);
        
        unsafe void glPathGlyphRangeNV(uint firstPathName, PathFontTarget fontTarget, void * fontName, uint fontStyle, uint firstGlyph, uint numGlyphs, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        
        unsafe void glPathGlyphsNV(uint firstPathName, PathFontTarget fontTarget, void * fontName, uint fontStyle, uint numGlyphs, PathElementType type, void * charcodes, PathHandleMissingGlyphs handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        
        unsafe void glPathParameterfNV(uint path, PathParameter pname, float value);
        
        unsafe void glPathParameterfvNV(uint path, PathParameter pname, float * value);
        
        unsafe void glPathParameteriNV(uint path, PathParameter pname, int value);
        
        unsafe void glPathParameterivNV(uint path, PathParameter pname, int * value);
        
        unsafe void glPathStencilDepthOffsetNV(float factor, float units);
        
        unsafe void glPathStencilFuncNV(StencilFunction func, int REF, uint mask);
        
        unsafe void glPathStringNV(uint path, PathStringFormat format, uint length, void * pathString);
        
        unsafe void glPathSubCommandsNV(uint path, uint commandStart, uint commandsToDelete, uint numCommands, byte * commands, uint numCoords, PathCoordType coordType, void * coords);
        
        unsafe void glPathSubCoordsNV(uint path, uint coordStart, uint numCoords, PathCoordType coordType, void * coords);
        
        unsafe void glPathTexGenNV(PathColor texCoordSet, PathGenMode genMode, int components, float * coeffs);
        
        unsafe void glPauseTransformFeedback();
        
        unsafe void glPauseTransformFeedbackNV();
        
        unsafe void glPixelDataRangeNV(PixelDataRangeTargetNV target, uint length, void * pointer);
        
        unsafe void glPixelMapfv(PixelMap map, uint mapsize, float * values);
        
        unsafe void glPixelMapuiv(PixelMap map, uint mapsize, uint * values);
        
        unsafe void glPixelMapusv(PixelMap map, uint mapsize, ushort * values);
        
        unsafe void glPixelMapx(PixelMap map, int size, int * values);
        
        unsafe void glPixelStoref(PixelStoreParameter pname, float param);
        
        unsafe void glPixelStorei(PixelStoreParameter pname, int param);
        
        unsafe void glPixelStorex(PixelStoreParameter pname, int param);
        
        unsafe void glPixelTexGenParameterfSGIS(PixelTexGenParameterNameSGIS pname, float param);
        
        unsafe void glPixelTexGenParameterfvSGIS(PixelTexGenParameterNameSGIS pname, float * PARAMS);
        
        unsafe void glPixelTexGenParameteriSGIS(PixelTexGenParameterNameSGIS pname, int param);
        
        unsafe void glPixelTexGenParameterivSGIS(PixelTexGenParameterNameSGIS pname, int * PARAMS);
        
        unsafe void glPixelTexGenSGIX(PixelTexGenModeSGIX mode);
        
        unsafe void glPixelTransferf(PixelTransferParameter pname, float param);
        
        unsafe void glPixelTransferi(PixelTransferParameter pname, int param);
        
        unsafe void glPixelTransferxOES(PixelTransferParameter pname, int param);
        
        unsafe void glPixelTransformParameterfEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float param);
        
        unsafe void glPixelTransformParameterfvEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, float * PARAMS);
        
        unsafe void glPixelTransformParameteriEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int param);
        
        unsafe void glPixelTransformParameterivEXT(PixelTransformTargetEXT target, PixelTransformPNameEXT pname, int * PARAMS);
        
        unsafe void glPixelZoom(float xfactor, float yfactor);
        
        unsafe void glPixelZoomxOES(int xfactor, int yfactor);
        
        unsafe bool glPointAlongPathNV(uint path, uint startSegment, uint numSegments, float distance, float * x, float * y, float * tangentX, float * tangentY);
        
        unsafe void glPointParameterf(PointParameterNameARB pname, float param);
        
        unsafe void glPointParameterfARB(PointParameterNameARB pname, float param);
        
        unsafe void glPointParameterfEXT(PointParameterNameARB pname, float param);
        
        unsafe void glPointParameterfSGIS(PointParameterNameARB pname, float param);
        
        unsafe void glPointParameterfv(PointParameterNameARB pname, float * PARAMS);
        
        unsafe void glPointParameterfvARB(PointParameterNameARB pname, float * PARAMS);
        
        unsafe void glPointParameterfvEXT(PointParameterNameARB pname, float * PARAMS);
        
        unsafe void glPointParameterfvSGIS(PointParameterNameARB pname, float * PARAMS);
        
        unsafe void glPointParameteri(PointParameterNameARB pname, int param);
        
        unsafe void glPointParameteriNV(PointParameterNameARB pname, int param);
        
        unsafe void glPointParameteriv(PointParameterNameARB pname, int * PARAMS);
        
        unsafe void glPointParameterivNV(PointParameterNameARB pname, int * PARAMS);
        
        unsafe void glPointParameterx(PointParameterNameARB pname, int param);
        
        unsafe void glPointParameterxOES(PointParameterNameARB pname, int param);
        
        unsafe void glPointParameterxv(PointParameterNameARB pname, int * PARAMS);
        
        unsafe void glPointParameterxvOES(PointParameterNameARB pname, int * PARAMS);
        
        unsafe void glPointSize(float size);
        
        unsafe void glPointSizex(int size);
        
        unsafe void glPointSizexOES(int size);
        
        unsafe int glPollAsyncSGIX(uint * markerp);
        
        unsafe int glPollInstrumentsSGIX(int * marker_p);
        
        unsafe void glPolygonMode(MaterialFace face, PolygonMode mode);
        
        unsafe void glPolygonModeNV(MaterialFace face, PolygonMode mode);
        
        unsafe void glPolygonOffset(float factor, float units);
        
        unsafe void glPolygonOffsetClamp(float factor, float units, float clamp);
        
        unsafe void glPolygonOffsetClampEXT(float factor, float units, float clamp);
        
        unsafe void glPolygonOffsetEXT(float factor, float bias);
        
        unsafe void glPolygonOffsetx(int factor, int units);
        
        unsafe void glPolygonOffsetxOES(int factor, int units);
        
        unsafe void glPolygonStipple(byte * mask);
        
        unsafe void glPopAttrib();
        
        unsafe void glPopClientAttrib();
        
        unsafe void glPopDebugGroup();
        
        unsafe void glPopDebugGroupKHR();
        
        unsafe void glPopGroupMarkerEXT();
        
        unsafe void glPopMatrix();
        
        unsafe void glPopName();
        
        unsafe void glPrimitiveBoundingBox(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        
        unsafe void glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        
        unsafe void glPrimitiveBoundingBoxEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        
        unsafe void glPrimitiveBoundingBoxOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        
        unsafe void glPrimitiveRestartIndex(uint index);
        
        unsafe void glPrimitiveRestartIndexNV(uint index);
        
        unsafe void glPrimitiveRestartNV();
        
        unsafe void glPrioritizeTextures(uint n, uint * textures, float * priorities);
        
        unsafe void glPrioritizeTexturesEXT(uint n, uint * textures, float * priorities);
        
        unsafe void glPrioritizeTexturesxOES(uint n, uint * textures, int * priorities);
        
        unsafe void glProgramBufferParametersIivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, uint count, int * PARAMS);
        
        unsafe void glProgramBufferParametersIuivNV(ProgramTarget target, uint bindingIndex, uint wordIndex, uint count, uint * PARAMS);
        
        unsafe void glProgramBufferParametersfvNV(ProgramTarget target, uint bindingIndex, uint wordIndex, uint count, float * PARAMS);
        
        unsafe void glProgramEnvParameter4dARB(ProgramTargetARB target, uint index, double x, double y, double z, double w);
        
        unsafe void glProgramEnvParameter4dvARB(ProgramTargetARB target, uint index, double * PARAMS);
        
        unsafe void glProgramEnvParameter4fARB(ProgramTargetARB target, uint index, float x, float y, float z, float w);
        
        unsafe void glProgramEnvParameter4fvARB(ProgramTargetARB target, uint index, float * PARAMS);
        
        unsafe void glProgramEnvParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w);
        
        unsafe void glProgramEnvParameterI4ivNV(ProgramTarget target, uint index, int * PARAMS);
        
        unsafe void glProgramEnvParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w);
        
        unsafe void glProgramEnvParameterI4uivNV(ProgramTarget target, uint index, uint * PARAMS);
        
        unsafe void glProgramEnvParameters4fvEXT(ProgramTargetARB target, uint index, uint count, float * PARAMS);
        
        unsafe void glProgramEnvParametersI4ivNV(ProgramTarget target, uint index, uint count, int * PARAMS);
        
        unsafe void glProgramEnvParametersI4uivNV(ProgramTarget target, uint index, uint count, uint * PARAMS);
        
        unsafe void glProgramLocalParameter4dARB(ProgramTargetARB target, uint index, double x, double y, double z, double w);
        
        unsafe void glProgramLocalParameter4dvARB(ProgramTargetARB target, uint index, double * PARAMS);
        
        unsafe void glProgramLocalParameter4fARB(ProgramTargetARB target, uint index, float x, float y, float z, float w);
        
        unsafe void glProgramLocalParameter4fvARB(ProgramTargetARB target, uint index, float * PARAMS);
        
        unsafe void glProgramLocalParameterI4iNV(ProgramTarget target, uint index, int x, int y, int z, int w);
        
        unsafe void glProgramLocalParameterI4ivNV(ProgramTarget target, uint index, int * PARAMS);
        
        unsafe void glProgramLocalParameterI4uiNV(ProgramTarget target, uint index, uint x, uint y, uint z, uint w);
        
        unsafe void glProgramLocalParameterI4uivNV(ProgramTarget target, uint index, uint * PARAMS);
        
        unsafe void glProgramLocalParameters4fvEXT(ProgramTargetARB target, uint index, uint count, float * PARAMS);
        
        unsafe void glProgramLocalParametersI4ivNV(ProgramTarget target, uint index, uint count, int * PARAMS);
        
        unsafe void glProgramLocalParametersI4uivNV(ProgramTarget target, uint index, uint count, uint * PARAMS);
        
        unsafe void glProgramNamedParameter4dNV(uint id, uint len, byte * name, double x, double y, double z, double w);
        
        unsafe void glProgramNamedParameter4dvNV(uint id, uint len, byte * name, double * v);
        
        unsafe void glProgramNamedParameter4fNV(uint id, uint len, byte * name, float x, float y, float z, float w);
        
        unsafe void glProgramNamedParameter4fvNV(uint id, uint len, byte * name, float * v);
        
        unsafe void glProgramParameter4dNV(VertexAttribEnumNV target, uint index, double x, double y, double z, double w);
        
        unsafe void glProgramParameter4dvNV(VertexAttribEnumNV target, uint index, double * v);
        
        unsafe void glProgramParameter4fNV(VertexAttribEnumNV target, uint index, float x, float y, float z, float w);
        
        unsafe void glProgramParameter4fvNV(VertexAttribEnumNV target, uint index, float * v);
        
        unsafe void glProgramParameteri(uint program, ProgramParameterPName pname, int value);
        
        unsafe void glProgramParameteriARB(uint program, ProgramParameterPName pname, int value);
        
        unsafe void glProgramParameteriEXT(uint program, ProgramParameterPName pname, int value);
        
        unsafe void glProgramParameters4dvNV(VertexAttribEnumNV target, uint index, uint count, double * v);
        
        unsafe void glProgramParameters4fvNV(VertexAttribEnumNV target, uint index, uint count, float * v);
        
        unsafe void glProgramStringARB(ProgramTargetARB target, ProgramFormatARB format, uint len, void * STRING);
        
        unsafe void glProgramUniform1d(uint program, int location, double v0);
        
        unsafe void glProgramUniform1dEXT(uint program, int location, double x);
        
        unsafe void glProgramUniform1dv(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform1dvEXT(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform1f(uint program, int location, float v0);
        
        unsafe void glProgramUniform1fEXT(uint program, int location, float v0);
        
        unsafe void glProgramUniform1fv(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform1fvEXT(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform1i(uint program, int location, int v0);
        
        unsafe void glProgramUniform1i64ARB(uint program, int location, long x);
        
        unsafe void glProgramUniform1i64NV(uint program, int location, long x);
        
        unsafe void glProgramUniform1i64vARB(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform1i64vNV(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform1iEXT(uint program, int location, int v0);
        
        unsafe void glProgramUniform1iv(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform1ivEXT(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform1ui(uint program, int location, uint v0);
        
        unsafe void glProgramUniform1ui64ARB(uint program, int location, ulong x);
        
        unsafe void glProgramUniform1ui64NV(uint program, int location, ulong x);
        
        unsafe void glProgramUniform1ui64vARB(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform1ui64vNV(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform1uiEXT(uint program, int location, uint v0);
        
        unsafe void glProgramUniform1uiv(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniform1uivEXT(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniform2d(uint program, int location, double v0, double v1);
        
        unsafe void glProgramUniform2dEXT(uint program, int location, double x, double y);
        
        unsafe void glProgramUniform2dv(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform2dvEXT(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform2f(uint program, int location, float v0, float v1);
        
        unsafe void glProgramUniform2fEXT(uint program, int location, float v0, float v1);
        
        unsafe void glProgramUniform2fv(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform2fvEXT(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform2i(uint program, int location, int v0, int v1);
        
        unsafe void glProgramUniform2i64ARB(uint program, int location, long x, long y);
        
        unsafe void glProgramUniform2i64NV(uint program, int location, long x, long y);
        
        unsafe void glProgramUniform2i64vARB(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform2i64vNV(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform2iEXT(uint program, int location, int v0, int v1);
        
        unsafe void glProgramUniform2iv(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform2ivEXT(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform2ui(uint program, int location, uint v0, uint v1);
        
        unsafe void glProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y);
        
        unsafe void glProgramUniform2ui64NV(uint program, int location, ulong x, ulong y);
        
        unsafe void glProgramUniform2ui64vARB(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform2ui64vNV(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform2uiEXT(uint program, int location, uint v0, uint v1);
        
        unsafe void glProgramUniform2uiv(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniform2uivEXT(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniform3d(uint program, int location, double v0, double v1, double v2);
        
        unsafe void glProgramUniform3dEXT(uint program, int location, double x, double y, double z);
        
        unsafe void glProgramUniform3dv(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform3dvEXT(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform3f(uint program, int location, float v0, float v1, float v2);
        
        unsafe void glProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2);
        
        unsafe void glProgramUniform3fv(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform3fvEXT(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform3i(uint program, int location, int v0, int v1, int v2);
        
        unsafe void glProgramUniform3i64ARB(uint program, int location, long x, long y, long z);
        
        unsafe void glProgramUniform3i64NV(uint program, int location, long x, long y, long z);
        
        unsafe void glProgramUniform3i64vARB(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform3i64vNV(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2);
        
        unsafe void glProgramUniform3iv(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform3ivEXT(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
        
        unsafe void glProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z);
        
        unsafe void glProgramUniform3ui64NV(uint program, int location, ulong x, ulong y, ulong z);
        
        unsafe void glProgramUniform3ui64vARB(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform3ui64vNV(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2);
        
        unsafe void glProgramUniform3uiv(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniform3uivEXT(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);
        
        unsafe void glProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w);
        
        unsafe void glProgramUniform4dv(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform4dvEXT(uint program, int location, uint count, double * value);
        
        unsafe void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
        
        unsafe void glProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3);
        
        unsafe void glProgramUniform4fv(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform4fvEXT(uint program, int location, uint count, float * value);
        
        unsafe void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
        
        unsafe void glProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w);
        
        unsafe void glProgramUniform4i64NV(uint program, int location, long x, long y, long z, long w);
        
        unsafe void glProgramUniform4i64vARB(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform4i64vNV(uint program, int location, uint count, long * value);
        
        unsafe void glProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3);
        
        unsafe void glProgramUniform4iv(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform4ivEXT(uint program, int location, uint count, int * value);
        
        unsafe void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
        
        unsafe void glProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w);
        
        unsafe void glProgramUniform4ui64NV(uint program, int location, ulong x, ulong y, ulong z, ulong w);
        
        unsafe void glProgramUniform4ui64vARB(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform4ui64vNV(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3);
        
        unsafe void glProgramUniform4uiv(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniform4uivEXT(uint program, int location, uint count, uint * value);
        
        unsafe void glProgramUniformHandleui64ARB(uint program, int location, ulong value);
        
        unsafe void glProgramUniformHandleui64IMG(uint program, int location, ulong value);
        
        unsafe void glProgramUniformHandleui64NV(uint program, int location, ulong value);
        
        unsafe void glProgramUniformHandleui64vARB(uint program, int location, uint count, ulong * values);
        
        unsafe void glProgramUniformHandleui64vIMG(uint program, int location, uint count, ulong * values);
        
        unsafe void glProgramUniformHandleui64vNV(uint program, int location, uint count, ulong * values);
        
        unsafe void glProgramUniformMatrix2dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix2dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix2fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix2fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix2x3dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix2x3dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix2x3fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix2x3fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix2x4dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix2x4dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix2x4fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix2x4fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix3dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix3dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix3fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix3fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix3x2dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix3x2dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix3x2fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix3x2fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix3x4dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix3x4dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix3x4fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix3x4fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix4dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix4dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix4fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix4fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix4x2dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix4x2dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix4x2fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix4x2fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix4x3dv(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix4x3dvEXT(uint program, int location, uint count, bool transpose, double * value);
        
        unsafe void glProgramUniformMatrix4x3fv(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformMatrix4x3fvEXT(uint program, int location, uint count, bool transpose, float * value);
        
        unsafe void glProgramUniformui64NV(uint program, int location, ulong value);
        
        unsafe void glProgramUniformui64vNV(uint program, int location, uint count, ulong * value);
        
        unsafe void glProgramVertexLimitNV(ProgramTarget target, int limit);
        
        unsafe void glProvokingVertex(VertexProvokingMode mode);
        
        unsafe void glProvokingVertexEXT(VertexProvokingMode mode);
        
        unsafe void glPushAttrib(uint mask);
        
        unsafe void glPushClientAttrib(uint mask);
        
        unsafe void glPushClientAttribDefaultEXT(uint mask);
        
        unsafe void glPushDebugGroup(DebugSource source, uint id, uint length, char * message);
        
        unsafe void glPushDebugGroupKHR(DebugSource source, uint id, uint length, char * message);
        
        unsafe void glPushGroupMarkerEXT(uint length, char * marker);
        
        unsafe void glPushMatrix();
        
        unsafe void glPushName(uint name);
        
        unsafe void glQueryCounter(uint id, QueryCounterTarget target);
        
        unsafe void glQueryCounterEXT(uint id, QueryCounterTarget target);
        
        unsafe uint glQueryMatrixxOES(int * mantissa, int * exponent);
        
        unsafe void glQueryResourceTagNV(int tagId, char * tagString);
        
        unsafe void glRasterPos2d(double x, double y);
        
        unsafe void glRasterPos2dv(double * v);
        
        unsafe void glRasterPos2f(float x, float y);
        
        unsafe void glRasterPos2fv(float * v);
        
        unsafe void glRasterPos2i(int x, int y);
        
        unsafe void glRasterPos2iv(int * v);
        
        unsafe void glRasterPos2s(short x, short y);
        
        unsafe void glRasterPos2sv(short * v);
        
        unsafe void glRasterPos2xOES(int x, int y);
        
        unsafe void glRasterPos2xvOES(int * coords);
        
        unsafe void glRasterPos3d(double x, double y, double z);
        
        unsafe void glRasterPos3dv(double * v);
        
        unsafe void glRasterPos3f(float x, float y, float z);
        
        unsafe void glRasterPos3fv(float * v);
        
        unsafe void glRasterPos3i(int x, int y, int z);
        
        unsafe void glRasterPos3iv(int * v);
        
        unsafe void glRasterPos3s(short x, short y, short z);
        
        unsafe void glRasterPos3sv(short * v);
        
        unsafe void glRasterPos3xOES(int x, int y, int z);
        
        unsafe void glRasterPos3xvOES(int * coords);
        
        unsafe void glRasterPos4d(double x, double y, double z, double w);
        
        unsafe void glRasterPos4dv(double * v);
        
        unsafe void glRasterPos4f(float x, float y, float z, float w);
        
        unsafe void glRasterPos4fv(float * v);
        
        unsafe void glRasterPos4i(int x, int y, int z, int w);
        
        unsafe void glRasterPos4iv(int * v);
        
        unsafe void glRasterPos4s(short x, short y, short z, short w);
        
        unsafe void glRasterPos4sv(short * v);
        
        unsafe void glRasterPos4xOES(int x, int y, int z, int w);
        
        unsafe void glRasterPos4xvOES(int * coords);
        
        unsafe void glRasterSamplesEXT(uint samples, bool fixedsamplelocations);
        
        unsafe void glReadBuffer(ReadBufferMode src);
        
        unsafe void glReadBufferIndexedEXT(ReadBufferMode src, int index);
        
        unsafe void glReadInstrumentsSGIX(int marker);
        
        unsafe void glReadPixels(int x, int y, uint width, uint height, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glReadnPixels(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data);
        
        unsafe void glReadnPixelsARB(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data);
        
        unsafe void glReadnPixelsEXT(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data);
        
        unsafe void glReadnPixelsKHR(int x, int y, uint width, uint height, PixelFormat format, PixelType type, uint bufSize, void * data);
        
        unsafe bool glReleaseKeyedMutexWin32EXT(uint memory, ulong key);
        
        unsafe void glRectd(double x1, double y1, double x2, double y2);
        
        unsafe void glRectdv(double * v1, double * v2);
        
        unsafe void glRectf(float x1, float y1, float x2, float y2);
        
        unsafe void glRectfv(float * v1, float * v2);
        
        unsafe void glRecti(int x1, int y1, int x2, int y2);
        
        unsafe void glRectiv(int * v1, int * v2);
        
        unsafe void glRects(short x1, short y1, short x2, short y2);
        
        unsafe void glRectsv(short * v1, short * v2);
        
        unsafe void glRectxOES(int x1, int y1, int x2, int y2);
        
        unsafe void glRectxvOES(int * v1, int * v2);
        
        unsafe void glReferencePlaneSGIX(double * equation);
        
        unsafe void glReleaseShaderCompiler();
        
        unsafe void glRenderGpuMaskNV(uint mask);
        
        unsafe int glRenderMode(RenderingMode mode);
        
        unsafe void glRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageEXT(RenderbufferTarget target, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisample(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisampleANGLE(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisampleAdvancedAMD(RenderbufferTarget target, uint samples, uint storageSamples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisampleCoverageNV(RenderbufferTarget target, uint coverageSamples, uint colorSamples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisampleEXT(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisampleIMG(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageMultisampleNV(RenderbufferTarget target, uint samples, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glRenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glReplacementCodePointerSUN(ReplacementCodeTypeSUN type, uint stride, void * * pointer);
        
        unsafe void glReplacementCodeubSUN(byte code);
        
        unsafe void glReplacementCodeubvSUN(byte * code);
        
        unsafe void glReplacementCodeuiColor3fVertex3fSUN(uint rc, float r, float g, float b, float x, float y, float z);
        
        unsafe void glReplacementCodeuiColor3fVertex3fvSUN(uint * rc, float * c, float * v);
        
        unsafe void glReplacementCodeuiColor4fNormal3fVertex3fSUN(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint * rc, float * c, float * n, float * v);
        
        unsafe void glReplacementCodeuiColor4ubVertex3fSUN(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z);
        
        unsafe void glReplacementCodeuiColor4ubVertex3fvSUN(uint * rc, byte * c, float * v);
        
        unsafe void glReplacementCodeuiNormal3fVertex3fSUN(uint rc, float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glReplacementCodeuiNormal3fVertex3fvSUN(uint * rc, float * n, float * v);
        
        unsafe void glReplacementCodeuiSUN(uint code);
        
        unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint * rc, float * tc, float * c, float * n, float * v);
        
        unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint * rc, float * tc, float * n, float * v);
        
        unsafe void glReplacementCodeuiTexCoord2fVertex3fSUN(uint rc, float s, float t, float x, float y, float z);
        
        unsafe void glReplacementCodeuiTexCoord2fVertex3fvSUN(uint * rc, float * tc, float * v);
        
        unsafe void glReplacementCodeuiVertex3fSUN(uint rc, float x, float y, float z);
        
        unsafe void glReplacementCodeuiVertex3fvSUN(uint * rc, float * v);
        
        unsafe void glReplacementCodeuivSUN(uint * code);
        
        unsafe void glReplacementCodeusSUN(ushort code);
        
        unsafe void glReplacementCodeusvSUN(ushort * code);
        
        unsafe void glRequestResidentProgramsNV(uint n, uint * programs);
        
        unsafe void glResetHistogram(HistogramTargetEXT target);
        
        unsafe void glResetHistogramEXT(HistogramTargetEXT target);
        
        unsafe void glResetMinmax(MinmaxTargetEXT target);
        
        unsafe void glResetMinmaxEXT(MinmaxTargetEXT target);
        
        unsafe void glResizeBuffersMESA();
        
        unsafe void glResolveDepthValuesNV();
        
        unsafe void glResolveMultisampleFramebufferAPPLE();
        
        unsafe void glResumeTransformFeedback();
        
        unsafe void glResumeTransformFeedbackNV();
        
        unsafe void glRotated(double angle, double x, double y, double z);
        
        unsafe void glRotatef(float angle, float x, float y, float z);
        
        unsafe void glRotatex(int angle, int x, int y, int z);
        
        unsafe void glRotatexOES(int angle, int x, int y, int z);
        
        unsafe void glSampleCoverage(float value, bool invert);
        
        unsafe void glSampleCoverageARB(float value, bool invert);
        
        unsafe void glSampleCoveragex(int value, bool invert);
        
        unsafe void glSampleCoveragexOES(int value, bool invert);
        
        unsafe void glSampleMapATI(uint dst, uint interp, SwizzleOpATI swizzle);
        
        unsafe void glSampleMaskEXT(float value, bool invert);
        
        unsafe void glSampleMaskIndexedNV(uint index, uint mask);
        
        unsafe void glSampleMaskSGIS(float value, bool invert);
        
        unsafe void glSampleMaski(uint maskNumber, uint mask);
        
        unsafe void glSamplePatternEXT(SamplePatternEXT pattern);
        
        unsafe void glSamplePatternSGIS(SamplePatternSGIS pattern);
        
        unsafe void glSamplerParameterIiv(uint sampler, SamplerParameterI pname, int * param);
        
        unsafe void glSamplerParameterIivEXT(uint sampler, SamplerParameterI pname, int * param);
        
        unsafe void glSamplerParameterIivOES(uint sampler, SamplerParameterI pname, int * param);
        
        unsafe void glSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint * param);
        
        unsafe void glSamplerParameterIuivEXT(uint sampler, SamplerParameterI pname, uint * param);
        
        unsafe void glSamplerParameterIuivOES(uint sampler, SamplerParameterI pname, uint * param);
        
        unsafe void glSamplerParameterf(uint sampler, SamplerParameterF pname, float param);
        
        unsafe void glSamplerParameterfv(uint sampler, SamplerParameterF pname, float * param);
        
        unsafe void glSamplerParameteri(uint sampler, SamplerParameterI pname, int param);
        
        unsafe void glSamplerParameteriv(uint sampler, SamplerParameterI pname, int * param);
        
        unsafe void glScaled(double x, double y, double z);
        
        unsafe void glScalef(float x, float y, float z);
        
        unsafe void glScalex(int x, int y, int z);
        
        unsafe void glScalexOES(int x, int y, int z);
        
        unsafe void glScissor(int x, int y, uint width, uint height);
        
        unsafe void glScissorArrayv(uint first, uint count, int * v);
        
        unsafe void glScissorArrayvNV(uint first, uint count, int * v);
        
        unsafe void glScissorArrayvOES(uint first, uint count, int * v);
        
        unsafe void glScissorExclusiveArrayvNV(uint first, uint count, int * v);
        
        unsafe void glScissorExclusiveNV(int x, int y, uint width, uint height);
        
        unsafe void glScissorIndexed(uint index, int left, int bottom, uint width, uint height);
        
        unsafe void glScissorIndexedNV(uint index, int left, int bottom, uint width, uint height);
        
        unsafe void glScissorIndexedOES(uint index, int left, int bottom, uint width, uint height);
        
        unsafe void glScissorIndexedv(uint index, int * v);
        
        unsafe void glScissorIndexedvNV(uint index, int * v);
        
        unsafe void glScissorIndexedvOES(uint index, int * v);
        
        unsafe void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);
        
        unsafe void glSecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue);
        
        unsafe void glSecondaryColor3bv(sbyte * v);
        
        unsafe void glSecondaryColor3bvEXT(sbyte * v);
        
        unsafe void glSecondaryColor3d(double red, double green, double blue);
        
        unsafe void glSecondaryColor3dEXT(double red, double green, double blue);
        
        unsafe void glSecondaryColor3dv(double * v);
        
        unsafe void glSecondaryColor3dvEXT(double * v);
        
        unsafe void glSecondaryColor3f(float red, float green, float blue);
        
        unsafe void glSecondaryColor3fEXT(float red, float green, float blue);
        
        unsafe void glSecondaryColor3fv(float * v);
        
        unsafe void glSecondaryColor3fvEXT(float * v);
        
        unsafe void glSecondaryColor3hNV(OpenToolkit.Mathematics.Half red, OpenToolkit.Mathematics.Half green, OpenToolkit.Mathematics.Half blue);
        
        unsafe void glSecondaryColor3hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glSecondaryColor3i(int red, int green, int blue);
        
        unsafe void glSecondaryColor3iEXT(int red, int green, int blue);
        
        unsafe void glSecondaryColor3iv(int * v);
        
        unsafe void glSecondaryColor3ivEXT(int * v);
        
        unsafe void glSecondaryColor3s(short red, short green, short blue);
        
        unsafe void glSecondaryColor3sEXT(short red, short green, short blue);
        
        unsafe void glSecondaryColor3sv(short * v);
        
        unsafe void glSecondaryColor3svEXT(short * v);
        
        unsafe void glSecondaryColor3ub(byte red, byte green, byte blue);
        
        unsafe void glSecondaryColor3ubEXT(byte red, byte green, byte blue);
        
        unsafe void glSecondaryColor3ubv(byte * v);
        
        unsafe void glSecondaryColor3ubvEXT(byte * v);
        
        unsafe void glSecondaryColor3ui(uint red, uint green, uint blue);
        
        unsafe void glSecondaryColor3uiEXT(uint red, uint green, uint blue);
        
        unsafe void glSecondaryColor3uiv(uint * v);
        
        unsafe void glSecondaryColor3uivEXT(uint * v);
        
        unsafe void glSecondaryColor3us(ushort red, ushort green, ushort blue);
        
        unsafe void glSecondaryColor3usEXT(ushort red, ushort green, ushort blue);
        
        unsafe void glSecondaryColor3usv(ushort * v);
        
        unsafe void glSecondaryColor3usvEXT(ushort * v);
        
        unsafe void glSecondaryColorFormatNV(int size, ColorPointerType type, uint stride);
        
        unsafe void glSecondaryColorP3ui(ColorPointerType type, uint color);
        
        unsafe void glSecondaryColorP3uiv(ColorPointerType type, uint * color);
        
        unsafe void glSecondaryColorPointer(int size, ColorPointerType type, uint stride, void * pointer);
        
        unsafe void glSecondaryColorPointerEXT(int size, ColorPointerType type, uint stride, void * pointer);
        
        unsafe void glSecondaryColorPointerListIBM(int size, SecondaryColorPointerTypeIBM type, int stride, void * * pointer, int ptrstride);
        
        unsafe void glSelectBuffer(uint size, uint * buffer);
        
        unsafe void glSelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, uint * counterList);
        
        unsafe void glSemaphoreParameterui64vEXT(uint semaphore, SemaphoreParameterName pname, ulong * PARAMS);
        
        unsafe void glSeparableFilter2D(SeparableTargetEXT target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * row, void * column);
        
        unsafe void glSeparableFilter2DEXT(SeparableTargetEXT target, InternalFormat internalformat, uint width, uint height, PixelFormat format, PixelType type, void * row, void * column);
        
        unsafe void glSetFenceAPPLE(uint fence);
        
        unsafe void glSetFenceNV(uint fence, FenceConditionNV condition);
        
        unsafe void glSetFragmentShaderConstantATI(uint dst, float * value);
        
        unsafe void glSetInvariantEXT(uint id, ScalarType type, void * addr);
        
        unsafe void glSetLocalConstantEXT(uint id, ScalarType type, void * addr);
        
        unsafe void glShadeModel(ShadingModel mode);
        
        unsafe void glShaderOp1EXT(VertexShaderOpEXT op, uint res, uint arg1);
        
        unsafe void glShaderOp2EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2);
        
        unsafe void glShaderOp3EXT(VertexShaderOpEXT op, uint res, uint arg1, uint arg2, uint arg3);
        
        unsafe void glShaderSource(uint shader, uint count, char * * STRING, int * length);
        
        unsafe void glShaderSourceARB(uint shaderObj, uint count, char * * STRING, int * length);
        
        unsafe void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);
        
        unsafe void glShadingRateImageBarrierNV(bool synchronize);
        
        unsafe void glSharpenTexFuncSGIS(TextureTarget target, uint n, float * points);
        
        unsafe void glSignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint * buffers, uint numTextureBarriers, uint * textures, TextureLayout * dstLayouts);
        
        unsafe void glSignalSemaphoreui64NVX(uint signalGpu, uint fenceObjectCount, uint * semaphoreArray, ulong * fenceValueArray);
        
        unsafe void glSpecializeShader(uint shader, char * pEntryPoint, uint numSpecializationConstants, uint * pConstantIndex, uint * pConstantValue);
        
        unsafe void glSpecializeShaderARB(uint shader, char * pEntryPoint, uint numSpecializationConstants, uint * pConstantIndex, uint * pConstantValue);
        
        unsafe void glSpriteParameterfSGIX(SpriteParameterNameSGIX pname, float param);
        
        unsafe void glSpriteParameterfvSGIX(SpriteParameterNameSGIX pname, float * PARAMS);
        
        unsafe void glSpriteParameteriSGIX(SpriteParameterNameSGIX pname, int param);
        
        unsafe void glSpriteParameterivSGIX(SpriteParameterNameSGIX pname, int * PARAMS);
        
        unsafe void glStartInstrumentsSGIX();
        
        unsafe void glStartTilingQCOM(uint x, uint y, uint width, uint height, uint preserveMask);
        
        unsafe void glStencilClearTagEXT(uint stencilTagBits, uint stencilClearTag);
        
        unsafe void glStencilFillPathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, PathFillMode fillMode, uint mask, PathTransformType transformType, float * transformValues);
        
        unsafe void glStencilFillPathNV(uint path, PathFillMode fillMode, uint mask);
        
        unsafe void glStencilFunc(StencilFunction func, int REF, uint mask);
        
        unsafe void glStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int REF, uint mask);
        
        unsafe void glStencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, int REF, uint mask);
        
        unsafe void glStencilMask(uint mask);
        
        unsafe void glStencilMaskSeparate(StencilFaceDirection face, uint mask);
        
        unsafe void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass);
        
        unsafe void glStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
        
        unsafe void glStencilOpSeparateATI(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
        
        unsafe void glStencilOpValueAMD(StencilFaceDirection face, uint value);
        
        unsafe void glStencilStrokePathInstancedNV(uint numPaths, PathElementType pathNameType, void * paths, uint pathBase, int reference, uint mask, PathTransformType transformType, float * transformValues);
        
        unsafe void glStencilStrokePathNV(uint path, int reference, uint mask);
        
        unsafe void glStopInstrumentsSGIX(int marker);
        
        unsafe void glStringMarkerGREMEDY(uint len, void * STRING);
        
        unsafe void glSubpixelPrecisionBiasNV(uint xbits, uint ybits);
        
        unsafe void glSwizzleEXT(uint res, uint IN, VertexShaderCoordOutEXT outX, VertexShaderCoordOutEXT outY, VertexShaderCoordOutEXT outZ, VertexShaderCoordOutEXT outW);
        
        unsafe void glSyncTextureINTEL(uint texture);
        
        unsafe void glTagSampleBufferSGIX();
        
        unsafe void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz);
        
        unsafe void glTangent3bvEXT(sbyte * v);
        
        unsafe void glTangent3dEXT(double tx, double ty, double tz);
        
        unsafe void glTangent3dvEXT(double * v);
        
        unsafe void glTangent3fEXT(float tx, float ty, float tz);
        
        unsafe void glTangent3fvEXT(float * v);
        
        unsafe void glTangent3iEXT(int tx, int ty, int tz);
        
        unsafe void glTangent3ivEXT(int * v);
        
        unsafe void glTangent3sEXT(short tx, short ty, short tz);
        
        unsafe void glTangent3svEXT(short * v);
        
        unsafe void glTangentPointerEXT(TangentPointerTypeEXT type, uint stride, void * pointer);
        
        unsafe void glTbufferMask3DFX(uint mask);
        
        unsafe void glTessellationFactorAMD(float factor);
        
        unsafe bool glTestFenceAPPLE(uint fence);
        
        unsafe bool glTestFenceNV(uint fence);
        
        unsafe bool glTestObjectAPPLE(ObjectTypeAPPLE OBJECT, uint name);
        
        unsafe void glTexAttachMemoryNV(TextureTarget target, uint memory, ulong offset);
        
        unsafe void glTexBuffer(TextureTarget target, InternalFormat internalformat, uint buffer);
        
        unsafe void glTexBufferARB(TextureTarget target, InternalFormat internalformat, uint buffer);
        
        unsafe void glTexBufferEXT(TextureTarget target, InternalFormat internalformat, uint buffer);
        
        unsafe void glTexBufferOES(TextureTarget target, InternalFormat internalformat, uint buffer);
        
        unsafe void glTexBufferRange(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glTexBufferRangeEXT(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glTexBufferRangeOES(TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glTexBumpParameterfvATI(TexBumpParameterATI pname, float * param);
        
        unsafe void glTexBumpParameterivATI(TexBumpParameterATI pname, int * param);
        
        unsafe void glTexCoord1bOES(sbyte s);
        
        unsafe void glTexCoord1bvOES(sbyte * coords);
        
        unsafe void glTexCoord1d(double s);
        
        unsafe void glTexCoord1dv(double * v);
        
        unsafe void glTexCoord1f(float s);
        
        unsafe void glTexCoord1fv(float * v);
        
        unsafe void glTexCoord1hNV(OpenToolkit.Mathematics.Half s);
        
        unsafe void glTexCoord1hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glTexCoord1i(int s);
        
        unsafe void glTexCoord1iv(int * v);
        
        unsafe void glTexCoord1s(short s);
        
        unsafe void glTexCoord1sv(short * v);
        
        unsafe void glTexCoord1xOES(int s);
        
        unsafe void glTexCoord1xvOES(int * coords);
        
        unsafe void glTexCoord2bOES(sbyte s, sbyte t);
        
        unsafe void glTexCoord2bvOES(sbyte * coords);
        
        unsafe void glTexCoord2d(double s, double t);
        
        unsafe void glTexCoord2dv(double * v);
        
        unsafe void glTexCoord2f(float s, float t);
        
        unsafe void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);
        
        unsafe void glTexCoord2fColor3fVertex3fvSUN(float * tc, float * c, float * v);
        
        unsafe void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glTexCoord2fColor4fNormal3fVertex3fvSUN(float * tc, float * c, float * n, float * v);
        
        unsafe void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);
        
        unsafe void glTexCoord2fColor4ubVertex3fvSUN(float * tc, byte * c, float * v);
        
        unsafe void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);
        
        unsafe void glTexCoord2fNormal3fVertex3fvSUN(float * tc, float * n, float * v);
        
        unsafe void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);
        
        unsafe void glTexCoord2fVertex3fvSUN(float * tc, float * v);
        
        unsafe void glTexCoord2fv(float * v);
        
        unsafe void glTexCoord2hNV(OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t);
        
        unsafe void glTexCoord2hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glTexCoord2i(int s, int t);
        
        unsafe void glTexCoord2iv(int * v);
        
        unsafe void glTexCoord2s(short s, short t);
        
        unsafe void glTexCoord2sv(short * v);
        
        unsafe void glTexCoord2xOES(int s, int t);
        
        unsafe void glTexCoord2xvOES(int * coords);
        
        unsafe void glTexCoord3bOES(sbyte s, sbyte t, sbyte r);
        
        unsafe void glTexCoord3bvOES(sbyte * coords);
        
        unsafe void glTexCoord3d(double s, double t, double r);
        
        unsafe void glTexCoord3dv(double * v);
        
        unsafe void glTexCoord3f(float s, float t, float r);
        
        unsafe void glTexCoord3fv(float * v);
        
        unsafe void glTexCoord3hNV(OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r);
        
        unsafe void glTexCoord3hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glTexCoord3i(int s, int t, int r);
        
        unsafe void glTexCoord3iv(int * v);
        
        unsafe void glTexCoord3s(short s, short t, short r);
        
        unsafe void glTexCoord3sv(short * v);
        
        unsafe void glTexCoord3xOES(int s, int t, int r);
        
        unsafe void glTexCoord3xvOES(int * coords);
        
        unsafe void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q);
        
        unsafe void glTexCoord4bvOES(sbyte * coords);
        
        unsafe void glTexCoord4d(double s, double t, double r, double q);
        
        unsafe void glTexCoord4dv(double * v);
        
        unsafe void glTexCoord4f(float s, float t, float r, float q);
        
        unsafe void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);
        
        unsafe void glTexCoord4fColor4fNormal3fVertex4fvSUN(float * tc, float * c, float * n, float * v);
        
        unsafe void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);
        
        unsafe void glTexCoord4fVertex4fvSUN(float * tc, float * v);
        
        unsafe void glTexCoord4fv(float * v);
        
        unsafe void glTexCoord4hNV(OpenToolkit.Mathematics.Half s, OpenToolkit.Mathematics.Half t, OpenToolkit.Mathematics.Half r, OpenToolkit.Mathematics.Half q);
        
        unsafe void glTexCoord4hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glTexCoord4i(int s, int t, int r, int q);
        
        unsafe void glTexCoord4iv(int * v);
        
        unsafe void glTexCoord4s(short s, short t, short r, short q);
        
        unsafe void glTexCoord4sv(short * v);
        
        unsafe void glTexCoord4xOES(int s, int t, int r, int q);
        
        unsafe void glTexCoord4xvOES(int * coords);
        
        unsafe void glTexCoordP1ui(TexCoordPointerType type, uint coords);
        
        unsafe void glTexCoordP1uiv(TexCoordPointerType type, uint * coords);
        
        unsafe void glTexCoordP2ui(TexCoordPointerType type, uint coords);
        
        unsafe void glTexCoordP2uiv(TexCoordPointerType type, uint * coords);
        
        unsafe void glTexCoordP3ui(TexCoordPointerType type, uint coords);
        
        unsafe void glTexCoordP3uiv(TexCoordPointerType type, uint * coords);
        
        unsafe void glTexCoordP4ui(TexCoordPointerType type, uint coords);
        
        unsafe void glTexCoordP4uiv(TexCoordPointerType type, uint * coords);
        
        unsafe void glTexCoordPointer(int size, TexCoordPointerType type, uint stride, void * pointer);
        
        unsafe void glTexCoordPointerEXT(int size, TexCoordPointerType type, uint stride, uint count, void * pointer);
        
        unsafe void glTexCoordPointerListIBM(int size, TexCoordPointerType type, int stride, void * * pointer, int ptrstride);
        
        unsafe void glTexCoordPointervINTEL(int size, VertexPointerType type, void * * pointer);
        
        unsafe void glTexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param);
        
        unsafe void glTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float * PARAMS);
        
        unsafe void glTexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param);
        
        unsafe void glTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glTexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param);
        
        unsafe void glTexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param);
        
        unsafe void glTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int * PARAMS);
        
        unsafe void glTexFilterFuncSGIS(TextureTarget target, TextureFilterSGIS filter, uint n, float * weights);
        
        unsafe void glTexGend(TextureCoordName coord, TextureGenParameter pname, double param);
        
        unsafe void glTexGendv(TextureCoordName coord, TextureGenParameter pname, double * PARAMS);
        
        unsafe void glTexGenf(TextureCoordName coord, TextureGenParameter pname, float param);
        
        unsafe void glTexGenfOES(TextureCoordName coord, TextureGenParameter pname, float param);
        
        unsafe void glTexGenfv(TextureCoordName coord, TextureGenParameter pname, float * PARAMS);
        
        unsafe void glTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float * PARAMS);
        
        unsafe void glTexGeni(TextureCoordName coord, TextureGenParameter pname, int param);
        
        unsafe void glTexGeniOES(TextureCoordName coord, TextureGenParameter pname, int param);
        
        unsafe void glTexGeniv(TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glTexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param);
        
        unsafe void glTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int * PARAMS);
        
        unsafe void glTexImage1D(TextureTarget target, int level, int internalformat, uint width, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexImage2D(TextureTarget target, int level, int internalformat, uint width, uint height, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexImage2DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations);
        
        unsafe void glTexImage2DMultisampleCoverageNV(TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, bool fixedSampleLocations);
        
        unsafe void glTexImage3D(TextureTarget target, int level, int internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexImage3DEXT(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexImage3DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations);
        
        unsafe void glTexImage3DMultisampleCoverageNV(TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, uint depth, bool fixedSampleLocations);
        
        unsafe void glTexImage3DOES(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexImage4DSGIS(TextureTarget target, int level, InternalFormat internalformat, uint width, uint height, uint depth, uint size4d, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexParameterIiv(TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glTexParameterIivEXT(TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glTexParameterIivOES(TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glTexParameterIuiv(TextureTarget target, TextureParameterName pname, uint * PARAMS);
        
        unsafe void glTexParameterIuivEXT(TextureTarget target, TextureParameterName pname, uint * PARAMS);
        
        unsafe void glTexParameterIuivOES(TextureTarget target, TextureParameterName pname, uint * PARAMS);
        
        unsafe void glTexParameterf(TextureTarget target, TextureParameterName pname, float param);
        
        unsafe void glTexParameterfv(TextureTarget target, TextureParameterName pname, float * PARAMS);
        
        unsafe void glTexParameteri(TextureTarget target, TextureParameterName pname, int param);
        
        unsafe void glTexParameteriv(TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glTexParameterx(TextureTarget target, GetTextureParameter pname, int param);
        
        unsafe void glTexParameterxOES(TextureTarget target, GetTextureParameter pname, int param);
        
        unsafe void glTexParameterxv(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int * PARAMS);
        
        unsafe void glTexRenderbufferNV(TextureTarget target, uint renderbuffer);
        
        unsafe void glTexStorage1D(TextureTarget target, uint levels, InternalFormat internalformat, uint width);
        
        unsafe void glTexStorage1DEXT(TextureTarget target, uint levels, InternalFormat internalformat, uint width);
        
        unsafe void glTexStorage2D(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glTexStorage2DEXT(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glTexStorage2DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations);
        
        unsafe void glTexStorage3D(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height, uint depth);
        
        unsafe void glTexStorage3DEXT(TextureTarget target, uint levels, InternalFormat internalformat, uint width, uint height, uint depth);
        
        unsafe void glTexStorage3DMultisample(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations);
        
        unsafe void glTexStorage3DMultisampleOES(TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations);
        
        unsafe void glTexStorageSparseAMD(TextureTarget target, InternalFormat internalFormat, uint width, uint height, uint depth, uint layers, uint flags);
        
        unsafe void glTexSubImage1D(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexSubImage1DEXT(TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexSubImage2DEXT(TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexSubImage3DEXT(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexSubImage3DOES(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTexSubImage4DSGIS(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int woffset, uint width, uint height, uint depth, uint size4d, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureAttachMemoryNV(uint texture, uint memory, ulong offset);
        
        unsafe void glTextureBarrier();
        
        unsafe void glTextureBarrierNV();
        
        unsafe void glTextureBuffer(uint texture, InternalFormat internalformat, uint buffer);
        
        unsafe void glTextureBufferEXT(uint texture, TextureTarget target, InternalFormat internalformat, uint buffer);
        
        unsafe void glTextureBufferRange(uint texture, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glTextureBufferRangeEXT(uint texture, TextureTarget target, InternalFormat internalformat, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glTextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);
        
        unsafe void glTextureFoveationParametersQCOM(uint texture, uint layer, uint focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea);
        
        unsafe void glTextureImage1DEXT(uint texture, TextureTarget target, int level, int internalformat, uint width, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureImage2DEXT(uint texture, TextureTarget target, int level, int internalformat, uint width, uint height, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureImage2DMultisampleCoverageNV(uint texture, TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, bool fixedSampleLocations);
        
        unsafe void glTextureImage2DMultisampleNV(uint texture, TextureTarget target, uint samples, int internalFormat, uint width, uint height, bool fixedSampleLocations);
        
        unsafe void glTextureImage3DEXT(uint texture, TextureTarget target, int level, int internalformat, uint width, uint height, uint depth, int border, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureImage3DMultisampleCoverageNV(uint texture, TextureTarget target, uint coverageSamples, uint colorSamples, int internalFormat, uint width, uint height, uint depth, bool fixedSampleLocations);
        
        unsafe void glTextureImage3DMultisampleNV(uint texture, TextureTarget target, uint samples, int internalFormat, uint width, uint height, uint depth, bool fixedSampleLocations);
        
        unsafe void glTextureLightEXT(LightTexturePNameEXT pname);
        
        unsafe void glTextureMaterialEXT(MaterialFace face, MaterialParameter mode);
        
        unsafe void glTextureNormalEXT(TextureNormalModeEXT mode);
        
        unsafe void glTexturePageCommitmentEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, bool commit);
        
        unsafe void glTextureParameterIiv(uint texture, TextureParameterName pname, int * PARAMS);
        
        unsafe void glTextureParameterIivEXT(uint texture, TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glTextureParameterIuiv(uint texture, TextureParameterName pname, uint * PARAMS);
        
        unsafe void glTextureParameterIuivEXT(uint texture, TextureTarget target, TextureParameterName pname, uint * PARAMS);
        
        unsafe void glTextureParameterf(uint texture, TextureParameterName pname, float param);
        
        unsafe void glTextureParameterfEXT(uint texture, TextureTarget target, TextureParameterName pname, float param);
        
        unsafe void glTextureParameterfv(uint texture, TextureParameterName pname, float * param);
        
        unsafe void glTextureParameterfvEXT(uint texture, TextureTarget target, TextureParameterName pname, float * PARAMS);
        
        unsafe void glTextureParameteri(uint texture, TextureParameterName pname, int param);
        
        unsafe void glTextureParameteriEXT(uint texture, TextureTarget target, TextureParameterName pname, int param);
        
        unsafe void glTextureParameteriv(uint texture, TextureParameterName pname, int * param);
        
        unsafe void glTextureParameterivEXT(uint texture, TextureTarget target, TextureParameterName pname, int * PARAMS);
        
        unsafe void glTextureRenderbufferEXT(uint texture, TextureTarget target, uint renderbuffer);
        
        unsafe void glTextureStorage1D(uint texture, uint levels, InternalFormat internalformat, uint width);
        
        unsafe void glTextureStorage2D(uint texture, uint levels, InternalFormat internalformat, uint width, uint height);
        
        unsafe void glTextureStorage2DMultisample(uint texture, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations);
        
        unsafe void glTextureStorage2DMultisampleEXT(uint texture, TextureTarget target, uint samples, InternalFormat internalformat, uint width, uint height, bool fixedsamplelocations);
        
        unsafe void glTextureStorage3D(uint texture, uint levels, InternalFormat internalformat, uint width, uint height, uint depth);
        
        unsafe void glTextureStorage3DMultisample(uint texture, uint samples, InternalFormat internalformat, uint width, uint height, uint depth, bool fixedsamplelocations);
        
        unsafe void glTextureSubImage1D(uint texture, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureSubImage1DEXT(uint texture, TextureTarget target, int level, int xoffset, uint width, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureSubImage2DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, uint width, uint height, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureSubImage3DEXT(uint texture, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, uint width, uint height, uint depth, PixelFormat format, PixelType type, void * pixels);
        
        unsafe void glTextureView(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
        
        unsafe void glTextureViewEXT(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
        
        unsafe void glTextureViewOES(uint texture, TextureTarget target, uint origtexture, InternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
        
        unsafe void glTrackMatrixNV(VertexAttribEnumNV target, uint address, VertexAttribEnumNV matrix, VertexAttribEnumNV transform);
        
        unsafe void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);
        
        unsafe void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, UIntPtr size);
        
        unsafe void glTransformFeedbackVaryings(uint program, uint count, char * * varyings, TransformFeedbackBufferMode bufferMode);
        
        unsafe void glTransformPathNV(uint resultPath, uint srcPath, PathTransformType transformType, float * transformValues);
        
        unsafe void glTranslated(double x, double y, double z);
        
        unsafe void glTranslatef(float x, float y, float z);
        
        unsafe void glTranslatex(int x, int y, int z);
        
        unsafe void glTranslatexOES(int x, int y, int z);
        
        unsafe void glUniform1d(int location, double x);
        
        unsafe void glUniform1dv(int location, uint count, double * value);
        
        unsafe void glUniform1f(int location, float v0);
        
        unsafe void glUniform1fARB(int location, float v0);
        
        unsafe void glUniform1fv(int location, uint count, float * value);
        
        unsafe void glUniform1fvARB(int location, uint count, float * value);
        
        unsafe void glUniform1i(int location, int v0);
        
        unsafe void glUniform1i64ARB(int location, long x);
        
        unsafe void glUniform1i64NV(int location, long x);
        
        unsafe void glUniform1i64vARB(int location, uint count, long * value);
        
        unsafe void glUniform1i64vNV(int location, uint count, long * value);
        
        unsafe void glUniform1iARB(int location, int v0);
        
        unsafe void glUniform1iv(int location, uint count, int * value);
        
        unsafe void glUniform1ivARB(int location, uint count, int * value);
        
        unsafe void glUniform1ui(int location, uint v0);
        
        unsafe void glUniform1ui64ARB(int location, ulong x);
        
        unsafe void glUniform1ui64NV(int location, ulong x);
        
        unsafe void glUniform1ui64vARB(int location, uint count, ulong * value);
        
        unsafe void glUniform1ui64vNV(int location, uint count, ulong * value);
        
        unsafe void glUniform1uiEXT(int location, uint v0);
        
        unsafe void glUniform1uiv(int location, uint count, uint * value);
        
        unsafe void glUniform1uivEXT(int location, uint count, uint * value);
        
        unsafe void glUniform2d(int location, double x, double y);
        
        unsafe void glUniform2dv(int location, uint count, double * value);
        
        unsafe void glUniform2f(int location, float v0, float v1);
        
        unsafe void glUniform2fARB(int location, float v0, float v1);
        
        unsafe void glUniform2fv(int location, uint count, float * value);
        
        unsafe void glUniform2fvARB(int location, uint count, float * value);
        
        unsafe void glUniform2i(int location, int v0, int v1);
        
        unsafe void glUniform2i64ARB(int location, long x, long y);
        
        unsafe void glUniform2i64NV(int location, long x, long y);
        
        unsafe void glUniform2i64vARB(int location, uint count, long * value);
        
        unsafe void glUniform2i64vNV(int location, uint count, long * value);
        
        unsafe void glUniform2iARB(int location, int v0, int v1);
        
        unsafe void glUniform2iv(int location, uint count, int * value);
        
        unsafe void glUniform2ivARB(int location, uint count, int * value);
        
        unsafe void glUniform2ui(int location, uint v0, uint v1);
        
        unsafe void glUniform2ui64ARB(int location, ulong x, ulong y);
        
        unsafe void glUniform2ui64NV(int location, ulong x, ulong y);
        
        unsafe void glUniform2ui64vARB(int location, uint count, ulong * value);
        
        unsafe void glUniform2ui64vNV(int location, uint count, ulong * value);
        
        unsafe void glUniform2uiEXT(int location, uint v0, uint v1);
        
        unsafe void glUniform2uiv(int location, uint count, uint * value);
        
        unsafe void glUniform2uivEXT(int location, uint count, uint * value);
        
        unsafe void glUniform3d(int location, double x, double y, double z);
        
        unsafe void glUniform3dv(int location, uint count, double * value);
        
        unsafe void glUniform3f(int location, float v0, float v1, float v2);
        
        unsafe void glUniform3fARB(int location, float v0, float v1, float v2);
        
        unsafe void glUniform3fv(int location, uint count, float * value);
        
        unsafe void glUniform3fvARB(int location, uint count, float * value);
        
        unsafe void glUniform3i(int location, int v0, int v1, int v2);
        
        unsafe void glUniform3i64ARB(int location, long x, long y, long z);
        
        unsafe void glUniform3i64NV(int location, long x, long y, long z);
        
        unsafe void glUniform3i64vARB(int location, uint count, long * value);
        
        unsafe void glUniform3i64vNV(int location, uint count, long * value);
        
        unsafe void glUniform3iARB(int location, int v0, int v1, int v2);
        
        unsafe void glUniform3iv(int location, uint count, int * value);
        
        unsafe void glUniform3ivARB(int location, uint count, int * value);
        
        unsafe void glUniform3ui(int location, uint v0, uint v1, uint v2);
        
        unsafe void glUniform3ui64ARB(int location, ulong x, ulong y, ulong z);
        
        unsafe void glUniform3ui64NV(int location, ulong x, ulong y, ulong z);
        
        unsafe void glUniform3ui64vARB(int location, uint count, ulong * value);
        
        unsafe void glUniform3ui64vNV(int location, uint count, ulong * value);
        
        unsafe void glUniform3uiEXT(int location, uint v0, uint v1, uint v2);
        
        unsafe void glUniform3uiv(int location, uint count, uint * value);
        
        unsafe void glUniform3uivEXT(int location, uint count, uint * value);
        
        unsafe void glUniform4d(int location, double x, double y, double z, double w);
        
        unsafe void glUniform4dv(int location, uint count, double * value);
        
        unsafe void glUniform4f(int location, float v0, float v1, float v2, float v3);
        
        unsafe void glUniform4fARB(int location, float v0, float v1, float v2, float v3);
        
        unsafe void glUniform4fv(int location, uint count, float * value);
        
        unsafe void glUniform4fvARB(int location, uint count, float * value);
        
        unsafe void glUniform4i(int location, int v0, int v1, int v2, int v3);
        
        unsafe void glUniform4i64ARB(int location, long x, long y, long z, long w);
        
        unsafe void glUniform4i64NV(int location, long x, long y, long z, long w);
        
        unsafe void glUniform4i64vARB(int location, uint count, long * value);
        
        unsafe void glUniform4i64vNV(int location, uint count, long * value);
        
        unsafe void glUniform4iARB(int location, int v0, int v1, int v2, int v3);
        
        unsafe void glUniform4iv(int location, uint count, int * value);
        
        unsafe void glUniform4ivARB(int location, uint count, int * value);
        
        unsafe void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
        
        unsafe void glUniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w);
        
        unsafe void glUniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w);
        
        unsafe void glUniform4ui64vARB(int location, uint count, ulong * value);
        
        unsafe void glUniform4ui64vNV(int location, uint count, ulong * value);
        
        unsafe void glUniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3);
        
        unsafe void glUniform4uiv(int location, uint count, uint * value);
        
        unsafe void glUniform4uivEXT(int location, uint count, uint * value);
        
        unsafe void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        
        unsafe void glUniformBufferEXT(uint program, int location, uint buffer);
        
        unsafe void glUniformHandleui64ARB(int location, ulong value);
        
        unsafe void glUniformHandleui64IMG(int location, ulong value);
        
        unsafe void glUniformHandleui64NV(int location, ulong value);
        
        unsafe void glUniformHandleui64vARB(int location, uint count, ulong * value);
        
        unsafe void glUniformHandleui64vIMG(int location, uint count, ulong * value);
        
        unsafe void glUniformHandleui64vNV(int location, uint count, ulong * value);
        
        unsafe void glUniformMatrix2dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix2fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix2fvARB(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix2x3dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix2x3fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix2x3fvNV(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix2x4dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix2x4fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix2x4fvNV(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix3dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix3fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix3fvARB(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix3x2dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix3x2fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix3x2fvNV(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix3x4dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix3x4fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix3x4fvNV(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix4dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix4fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix4fvARB(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix4x2dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix4x2fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix4x2fvNV(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix4x3dv(int location, uint count, bool transpose, double * value);
        
        unsafe void glUniformMatrix4x3fv(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformMatrix4x3fvNV(int location, uint count, bool transpose, float * value);
        
        unsafe void glUniformSubroutinesuiv(ShaderType shadertype, uint count, uint * indices);
        
        unsafe void glUniformui64NV(int location, ulong value);
        
        unsafe void glUniformui64vNV(int location, uint count, ulong * value);
        
        unsafe void glUnlockArraysEXT();
        
        unsafe bool glUnmapBuffer(BufferTargetARB target);
        
        unsafe bool glUnmapBufferARB(BufferTargetARB target);
        
        unsafe bool glUnmapNamedBuffer(uint buffer);
        
        unsafe bool glUnmapNamedBufferEXT(uint buffer);
        
        unsafe void glUnmapObjectBufferATI(uint buffer);
        
        unsafe void glUnmapTexture2DINTEL(uint texture, int level);
        
        unsafe void glUpdateObjectBufferATI(uint buffer, uint offset, uint size, void * pointer, PreserveModeATI preserve);
        
        unsafe void glUploadGpuMaskNVX(uint mask);
        
        unsafe void glUseProgram(uint program);
        
        unsafe void glUseProgramObjectARB(uint programObj);
        
        unsafe void glUseProgramStages(uint pipeline, uint stages, uint program);
        
        unsafe void glUseProgramStagesEXT(uint pipeline, uint stages, uint program);
        
        unsafe void glVDPAUFiniNV();
        
        unsafe void glVDPAUInitNV(void * vdpDevice, void * getProcAddress);
        
        unsafe bool glVDPAUIsSurfaceNV(IntPtr surface);
        
        unsafe void glVDPAUMapSurfacesNV(uint numSurfaces, IntPtr * surfaces);
        
        unsafe void glVDPAUUnmapSurfacesNV(uint numSurface, IntPtr * surfaces);
        
        unsafe void glVDPAUUnregisterSurfaceNV(IntPtr surface);
        
        unsafe void glValidateProgram(uint program);
        
        unsafe void glValidateProgramARB(uint programObj);
        
        unsafe void glValidateProgramPipeline(uint pipeline);
        
        unsafe void glValidateProgramPipelineEXT(uint pipeline);
        
        unsafe void glVariantArrayObjectATI(uint id, ScalarType type, uint stride, uint buffer, uint offset);
        
        unsafe void glVariantPointerEXT(uint id, ScalarType type, uint stride, void * addr);
        
        unsafe void glVariantbvEXT(uint id, sbyte * addr);
        
        unsafe void glVariantdvEXT(uint id, double * addr);
        
        unsafe void glVariantfvEXT(uint id, float * addr);
        
        unsafe void glVariantivEXT(uint id, int * addr);
        
        unsafe void glVariantsvEXT(uint id, short * addr);
        
        unsafe void glVariantubvEXT(uint id, byte * addr);
        
        unsafe void glVariantuivEXT(uint id, uint * addr);
        
        unsafe void glVariantusvEXT(uint id, ushort * addr);
        
        unsafe void glVertex2bOES(sbyte x, sbyte y);
        
        unsafe void glVertex2bvOES(sbyte * coords);
        
        unsafe void glVertex2d(double x, double y);
        
        unsafe void glVertex2dv(double * v);
        
        unsafe void glVertex2f(float x, float y);
        
        unsafe void glVertex2fv(float * v);
        
        unsafe void glVertex2hNV(OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y);
        
        unsafe void glVertex2hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertex2i(int x, int y);
        
        unsafe void glVertex2iv(int * v);
        
        unsafe void glVertex2s(short x, short y);
        
        unsafe void glVertex2sv(short * v);
        
        unsafe void glVertex2xOES(int x);
        
        unsafe void glVertex2xvOES(int * coords);
        
        unsafe void glVertex3bOES(sbyte x, sbyte y, sbyte z);
        
        unsafe void glVertex3bvOES(sbyte * coords);
        
        unsafe void glVertex3d(double x, double y, double z);
        
        unsafe void glVertex3dv(double * v);
        
        unsafe void glVertex3f(float x, float y, float z);
        
        unsafe void glVertex3fv(float * v);
        
        unsafe void glVertex3hNV(OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z);
        
        unsafe void glVertex3hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertex3i(int x, int y, int z);
        
        unsafe void glVertex3iv(int * v);
        
        unsafe void glVertex3s(short x, short y, short z);
        
        unsafe void glVertex3sv(short * v);
        
        unsafe void glVertex3xOES(int x, int y);
        
        unsafe void glVertex3xvOES(int * coords);
        
        unsafe void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w);
        
        unsafe void glVertex4bvOES(sbyte * coords);
        
        unsafe void glVertex4d(double x, double y, double z, double w);
        
        unsafe void glVertex4dv(double * v);
        
        unsafe void glVertex4f(float x, float y, float z, float w);
        
        unsafe void glVertex4fv(float * v);
        
        unsafe void glVertex4hNV(OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z, OpenToolkit.Mathematics.Half w);
        
        unsafe void glVertex4hvNV(OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertex4i(int x, int y, int z, int w);
        
        unsafe void glVertex4iv(int * v);
        
        unsafe void glVertex4s(short x, short y, short z, short w);
        
        unsafe void glVertex4sv(short * v);
        
        unsafe void glVertex4xOES(int x, int y, int z);
        
        unsafe void glVertex4xvOES(int * coords);
        
        unsafe void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);
        
        unsafe void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset);
        
        unsafe void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset);
        
        unsafe void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset);
        
        unsafe void glVertexArrayBindVertexBufferEXT(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, uint stride);
        
        unsafe void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);
        
        unsafe void glVertexArrayColorOffsetEXT(uint vaobj, uint buffer, int size, ColorPointerType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayEdgeFlagOffsetEXT(uint vaobj, uint buffer, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayElementBuffer(uint vaobj, uint buffer);
        
        unsafe void glVertexArrayFogCoordOffsetEXT(uint vaobj, uint buffer, FogCoordinatePointerType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayIndexOffsetEXT(uint vaobj, uint buffer, IndexPointerType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayNormalOffsetEXT(uint vaobj, uint buffer, NormalPointerType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayParameteriAPPLE(VertexArrayPNameAPPLE pname, int param);
        
        unsafe void glVertexArrayRangeAPPLE(uint length, void * pointer);
        
        unsafe void glVertexArrayRangeNV(uint length, void * pointer);
        
        unsafe void glVertexArraySecondaryColorOffsetEXT(uint vaobj, uint buffer, int size, ColorPointerType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayTexCoordOffsetEXT(uint vaobj, uint buffer, int size, TexCoordPointerType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayVertexAttribBindingEXT(uint vaobj, uint attribindex, uint bindingindex);
        
        unsafe void glVertexArrayVertexAttribDivisorEXT(uint vaobj, uint index, uint divisor);
        
        unsafe void glVertexArrayVertexAttribFormatEXT(uint vaobj, uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset);
        
        unsafe void glVertexArrayVertexAttribIFormatEXT(uint vaobj, uint attribindex, int size, VertexAttribIType type, uint relativeoffset);
        
        unsafe void glVertexArrayVertexAttribIOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayVertexAttribLFormatEXT(uint vaobj, uint attribindex, int size, VertexAttribLType type, uint relativeoffset);
        
        unsafe void glVertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribLType type, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayVertexAttribOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, IntPtr offset);
        
        unsafe void glVertexArrayVertexBindingDivisorEXT(uint vaobj, uint bindingindex, uint divisor);
        
        unsafe void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, uint stride);
        
        unsafe void glVertexArrayVertexBuffers(uint vaobj, uint first, uint count, uint * buffers, IntPtr * offsets, uint * strides);
        
        unsafe void glVertexArrayVertexOffsetEXT(uint vaobj, uint buffer, int size, VertexPointerType type, uint stride, IntPtr offset);
        
        unsafe void glVertexAttrib1d(uint index, double x);
        
        unsafe void glVertexAttrib1dARB(uint index, double x);
        
        unsafe void glVertexAttrib1dNV(uint index, double x);
        
        unsafe void glVertexAttrib1dv(uint index, double * v);
        
        unsafe void glVertexAttrib1dvARB(uint index, double * v);
        
        unsafe void glVertexAttrib1dvNV(uint index, double * v);
        
        unsafe void glVertexAttrib1f(uint index, float x);
        
        unsafe void glVertexAttrib1fARB(uint index, float x);
        
        unsafe void glVertexAttrib1fNV(uint index, float x);
        
        unsafe void glVertexAttrib1fv(uint index, float * v);
        
        unsafe void glVertexAttrib1fvARB(uint index, float * v);
        
        unsafe void glVertexAttrib1fvNV(uint index, float * v);
        
        unsafe void glVertexAttrib1hNV(uint index, OpenToolkit.Mathematics.Half x);
        
        unsafe void glVertexAttrib1hvNV(uint index, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttrib1s(uint index, short x);
        
        unsafe void glVertexAttrib1sARB(uint index, short x);
        
        unsafe void glVertexAttrib1sNV(uint index, short x);
        
        unsafe void glVertexAttrib1sv(uint index, short * v);
        
        unsafe void glVertexAttrib1svARB(uint index, short * v);
        
        unsafe void glVertexAttrib1svNV(uint index, short * v);
        
        unsafe void glVertexAttrib2d(uint index, double x, double y);
        
        unsafe void glVertexAttrib2dARB(uint index, double x, double y);
        
        unsafe void glVertexAttrib2dNV(uint index, double x, double y);
        
        unsafe void glVertexAttrib2dv(uint index, double * v);
        
        unsafe void glVertexAttrib2dvARB(uint index, double * v);
        
        unsafe void glVertexAttrib2dvNV(uint index, double * v);
        
        unsafe void glVertexAttrib2f(uint index, float x, float y);
        
        unsafe void glVertexAttrib2fARB(uint index, float x, float y);
        
        unsafe void glVertexAttrib2fNV(uint index, float x, float y);
        
        unsafe void glVertexAttrib2fv(uint index, float * v);
        
        unsafe void glVertexAttrib2fvARB(uint index, float * v);
        
        unsafe void glVertexAttrib2fvNV(uint index, float * v);
        
        unsafe void glVertexAttrib2hNV(uint index, OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y);
        
        unsafe void glVertexAttrib2hvNV(uint index, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttrib2s(uint index, short x, short y);
        
        unsafe void glVertexAttrib2sARB(uint index, short x, short y);
        
        unsafe void glVertexAttrib2sNV(uint index, short x, short y);
        
        unsafe void glVertexAttrib2sv(uint index, short * v);
        
        unsafe void glVertexAttrib2svARB(uint index, short * v);
        
        unsafe void glVertexAttrib2svNV(uint index, short * v);
        
        unsafe void glVertexAttrib3d(uint index, double x, double y, double z);
        
        unsafe void glVertexAttrib3dARB(uint index, double x, double y, double z);
        
        unsafe void glVertexAttrib3dNV(uint index, double x, double y, double z);
        
        unsafe void glVertexAttrib3dv(uint index, double * v);
        
        unsafe void glVertexAttrib3dvARB(uint index, double * v);
        
        unsafe void glVertexAttrib3dvNV(uint index, double * v);
        
        unsafe void glVertexAttrib3f(uint index, float x, float y, float z);
        
        unsafe void glVertexAttrib3fARB(uint index, float x, float y, float z);
        
        unsafe void glVertexAttrib3fNV(uint index, float x, float y, float z);
        
        unsafe void glVertexAttrib3fv(uint index, float * v);
        
        unsafe void glVertexAttrib3fvARB(uint index, float * v);
        
        unsafe void glVertexAttrib3fvNV(uint index, float * v);
        
        unsafe void glVertexAttrib3hNV(uint index, OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z);
        
        unsafe void glVertexAttrib3hvNV(uint index, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttrib3s(uint index, short x, short y, short z);
        
        unsafe void glVertexAttrib3sARB(uint index, short x, short y, short z);
        
        unsafe void glVertexAttrib3sNV(uint index, short x, short y, short z);
        
        unsafe void glVertexAttrib3sv(uint index, short * v);
        
        unsafe void glVertexAttrib3svARB(uint index, short * v);
        
        unsafe void glVertexAttrib3svNV(uint index, short * v);
        
        unsafe void glVertexAttrib4Nbv(uint index, sbyte * v);
        
        unsafe void glVertexAttrib4NbvARB(uint index, sbyte * v);
        
        unsafe void glVertexAttrib4Niv(uint index, int * v);
        
        unsafe void glVertexAttrib4NivARB(uint index, int * v);
        
        unsafe void glVertexAttrib4Nsv(uint index, short * v);
        
        unsafe void glVertexAttrib4NsvARB(uint index, short * v);
        
        unsafe void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);
        
        unsafe void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w);
        
        unsafe void glVertexAttrib4Nubv(uint index, byte * v);
        
        unsafe void glVertexAttrib4NubvARB(uint index, byte * v);
        
        unsafe void glVertexAttrib4Nuiv(uint index, uint * v);
        
        unsafe void glVertexAttrib4NuivARB(uint index, uint * v);
        
        unsafe void glVertexAttrib4Nusv(uint index, ushort * v);
        
        unsafe void glVertexAttrib4NusvARB(uint index, ushort * v);
        
        unsafe void glVertexAttrib4bv(uint index, sbyte * v);
        
        unsafe void glVertexAttrib4bvARB(uint index, sbyte * v);
        
        unsafe void glVertexAttrib4d(uint index, double x, double y, double z, double w);
        
        unsafe void glVertexAttrib4dARB(uint index, double x, double y, double z, double w);
        
        unsafe void glVertexAttrib4dNV(uint index, double x, double y, double z, double w);
        
        unsafe void glVertexAttrib4dv(uint index, double * v);
        
        unsafe void glVertexAttrib4dvARB(uint index, double * v);
        
        unsafe void glVertexAttrib4dvNV(uint index, double * v);
        
        unsafe void glVertexAttrib4f(uint index, float x, float y, float z, float w);
        
        unsafe void glVertexAttrib4fARB(uint index, float x, float y, float z, float w);
        
        unsafe void glVertexAttrib4fNV(uint index, float x, float y, float z, float w);
        
        unsafe void glVertexAttrib4fv(uint index, float * v);
        
        unsafe void glVertexAttrib4fvARB(uint index, float * v);
        
        unsafe void glVertexAttrib4fvNV(uint index, float * v);
        
        unsafe void glVertexAttrib4hNV(uint index, OpenToolkit.Mathematics.Half x, OpenToolkit.Mathematics.Half y, OpenToolkit.Mathematics.Half z, OpenToolkit.Mathematics.Half w);
        
        unsafe void glVertexAttrib4hvNV(uint index, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttrib4iv(uint index, int * v);
        
        unsafe void glVertexAttrib4ivARB(uint index, int * v);
        
        unsafe void glVertexAttrib4s(uint index, short x, short y, short z, short w);
        
        unsafe void glVertexAttrib4sARB(uint index, short x, short y, short z, short w);
        
        unsafe void glVertexAttrib4sNV(uint index, short x, short y, short z, short w);
        
        unsafe void glVertexAttrib4sv(uint index, short * v);
        
        unsafe void glVertexAttrib4svARB(uint index, short * v);
        
        unsafe void glVertexAttrib4svNV(uint index, short * v);
        
        unsafe void glVertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w);
        
        unsafe void glVertexAttrib4ubv(uint index, byte * v);
        
        unsafe void glVertexAttrib4ubvARB(uint index, byte * v);
        
        unsafe void glVertexAttrib4ubvNV(uint index, byte * v);
        
        unsafe void glVertexAttrib4uiv(uint index, uint * v);
        
        unsafe void glVertexAttrib4uivARB(uint index, uint * v);
        
        unsafe void glVertexAttrib4usv(uint index, ushort * v);
        
        unsafe void glVertexAttrib4usvARB(uint index, ushort * v);
        
        unsafe void glVertexAttribArrayObjectATI(uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, uint buffer, uint offset);
        
        unsafe void glVertexAttribBinding(uint attribindex, uint bindingindex);
        
        unsafe void glVertexAttribDivisor(uint index, uint divisor);
        
        unsafe void glVertexAttribDivisorANGLE(uint index, uint divisor);
        
        unsafe void glVertexAttribDivisorARB(uint index, uint divisor);
        
        unsafe void glVertexAttribDivisorEXT(uint index, uint divisor);
        
        unsafe void glVertexAttribDivisorNV(uint index, uint divisor);
        
        unsafe void glVertexAttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized, uint relativeoffset);
        
        unsafe void glVertexAttribFormatNV(uint index, int size, VertexAttribType type, bool normalized, uint stride);
        
        unsafe void glVertexAttribI1i(uint index, int x);
        
        unsafe void glVertexAttribI1iEXT(uint index, int x);
        
        unsafe void glVertexAttribI1iv(uint index, int * v);
        
        unsafe void glVertexAttribI1ivEXT(uint index, int * v);
        
        unsafe void glVertexAttribI1ui(uint index, uint x);
        
        unsafe void glVertexAttribI1uiEXT(uint index, uint x);
        
        unsafe void glVertexAttribI1uiv(uint index, uint * v);
        
        unsafe void glVertexAttribI1uivEXT(uint index, uint * v);
        
        unsafe void glVertexAttribI2i(uint index, int x, int y);
        
        unsafe void glVertexAttribI2iEXT(uint index, int x, int y);
        
        unsafe void glVertexAttribI2iv(uint index, int * v);
        
        unsafe void glVertexAttribI2ivEXT(uint index, int * v);
        
        unsafe void glVertexAttribI2ui(uint index, uint x, uint y);
        
        unsafe void glVertexAttribI2uiEXT(uint index, uint x, uint y);
        
        unsafe void glVertexAttribI2uiv(uint index, uint * v);
        
        unsafe void glVertexAttribI2uivEXT(uint index, uint * v);
        
        unsafe void glVertexAttribI3i(uint index, int x, int y, int z);
        
        unsafe void glVertexAttribI3iEXT(uint index, int x, int y, int z);
        
        unsafe void glVertexAttribI3iv(uint index, int * v);
        
        unsafe void glVertexAttribI3ivEXT(uint index, int * v);
        
        unsafe void glVertexAttribI3ui(uint index, uint x, uint y, uint z);
        
        unsafe void glVertexAttribI3uiEXT(uint index, uint x, uint y, uint z);
        
        unsafe void glVertexAttribI3uiv(uint index, uint * v);
        
        unsafe void glVertexAttribI3uivEXT(uint index, uint * v);
        
        unsafe void glVertexAttribI4bv(uint index, sbyte * v);
        
        unsafe void glVertexAttribI4bvEXT(uint index, sbyte * v);
        
        unsafe void glVertexAttribI4i(uint index, int x, int y, int z, int w);
        
        unsafe void glVertexAttribI4iEXT(uint index, int x, int y, int z, int w);
        
        unsafe void glVertexAttribI4iv(uint index, int * v);
        
        unsafe void glVertexAttribI4ivEXT(uint index, int * v);
        
        unsafe void glVertexAttribI4sv(uint index, short * v);
        
        unsafe void glVertexAttribI4svEXT(uint index, short * v);
        
        unsafe void glVertexAttribI4ubv(uint index, byte * v);
        
        unsafe void glVertexAttribI4ubvEXT(uint index, byte * v);
        
        unsafe void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);
        
        unsafe void glVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w);
        
        unsafe void glVertexAttribI4uiv(uint index, uint * v);
        
        unsafe void glVertexAttribI4uivEXT(uint index, uint * v);
        
        unsafe void glVertexAttribI4usv(uint index, ushort * v);
        
        unsafe void glVertexAttribI4usvEXT(uint index, ushort * v);
        
        unsafe void glVertexAttribIFormat(uint attribindex, int size, VertexAttribIType type, uint relativeoffset);
        
        unsafe void glVertexAttribIFormatNV(uint index, int size, VertexAttribIType type, uint stride);
        
        unsafe void glVertexAttribIPointer(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer);
        
        unsafe void glVertexAttribIPointerEXT(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer);
        
        unsafe void glVertexAttribL1d(uint index, double x);
        
        unsafe void glVertexAttribL1dEXT(uint index, double x);
        
        unsafe void glVertexAttribL1dv(uint index, double * v);
        
        unsafe void glVertexAttribL1dvEXT(uint index, double * v);
        
        unsafe void glVertexAttribL1i64NV(uint index, long x);
        
        unsafe void glVertexAttribL1i64vNV(uint index, long * v);
        
        unsafe void glVertexAttribL1ui64ARB(uint index, ulong x);
        
        unsafe void glVertexAttribL1ui64NV(uint index, ulong x);
        
        unsafe void glVertexAttribL1ui64vARB(uint index, ulong * v);
        
        unsafe void glVertexAttribL1ui64vNV(uint index, ulong * v);
        
        unsafe void glVertexAttribL2d(uint index, double x, double y);
        
        unsafe void glVertexAttribL2dEXT(uint index, double x, double y);
        
        unsafe void glVertexAttribL2dv(uint index, double * v);
        
        unsafe void glVertexAttribL2dvEXT(uint index, double * v);
        
        unsafe void glVertexAttribL2i64NV(uint index, long x, long y);
        
        unsafe void glVertexAttribL2i64vNV(uint index, long * v);
        
        unsafe void glVertexAttribL2ui64NV(uint index, ulong x, ulong y);
        
        unsafe void glVertexAttribL2ui64vNV(uint index, ulong * v);
        
        unsafe void glVertexAttribL3d(uint index, double x, double y, double z);
        
        unsafe void glVertexAttribL3dEXT(uint index, double x, double y, double z);
        
        unsafe void glVertexAttribL3dv(uint index, double * v);
        
        unsafe void glVertexAttribL3dvEXT(uint index, double * v);
        
        unsafe void glVertexAttribL3i64NV(uint index, long x, long y, long z);
        
        unsafe void glVertexAttribL3i64vNV(uint index, long * v);
        
        unsafe void glVertexAttribL3ui64NV(uint index, ulong x, ulong y, ulong z);
        
        unsafe void glVertexAttribL3ui64vNV(uint index, ulong * v);
        
        unsafe void glVertexAttribL4d(uint index, double x, double y, double z, double w);
        
        unsafe void glVertexAttribL4dEXT(uint index, double x, double y, double z, double w);
        
        unsafe void glVertexAttribL4dv(uint index, double * v);
        
        unsafe void glVertexAttribL4dvEXT(uint index, double * v);
        
        unsafe void glVertexAttribL4i64NV(uint index, long x, long y, long z, long w);
        
        unsafe void glVertexAttribL4i64vNV(uint index, long * v);
        
        unsafe void glVertexAttribL4ui64NV(uint index, ulong x, ulong y, ulong z, ulong w);
        
        unsafe void glVertexAttribL4ui64vNV(uint index, ulong * v);
        
        unsafe void glVertexAttribLFormat(uint attribindex, int size, VertexAttribLType type, uint relativeoffset);
        
        unsafe void glVertexAttribLFormatNV(uint index, int size, VertexAttribLType type, uint stride);
        
        unsafe void glVertexAttribLPointer(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer);
        
        unsafe void glVertexAttribLPointerEXT(uint index, int size, VertexAttribPointerType type, uint stride, void * pointer);
        
        unsafe void glVertexAttribP1ui(uint index, VertexAttribPointerType type, bool normalized, uint value);
        
        unsafe void glVertexAttribP1uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value);
        
        unsafe void glVertexAttribP2ui(uint index, VertexAttribPointerType type, bool normalized, uint value);
        
        unsafe void glVertexAttribP2uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value);
        
        unsafe void glVertexAttribP3ui(uint index, VertexAttribPointerType type, bool normalized, uint value);
        
        unsafe void glVertexAttribP3uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value);
        
        unsafe void glVertexAttribP4ui(uint index, VertexAttribPointerType type, bool normalized, uint value);
        
        unsafe void glVertexAttribP4uiv(uint index, VertexAttribPointerType type, bool normalized, uint * value);
        
        unsafe void glVertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, void * pointer);
        
        unsafe void glVertexAttribPointerARB(uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, void * pointer);
        
        unsafe void glVertexAttribPointerNV(uint index, int fsize, VertexAttribEnumNV type, uint stride, void * pointer);
        
        unsafe void glVertexAttribs1dvNV(uint index, uint count, double * v);
        
        unsafe void glVertexAttribs1fvNV(uint index, uint count, float * v);
        
        unsafe void glVertexAttribs1hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttribs1svNV(uint index, uint count, short * v);
        
        unsafe void glVertexAttribs2dvNV(uint index, uint count, double * v);
        
        unsafe void glVertexAttribs2fvNV(uint index, uint count, float * v);
        
        unsafe void glVertexAttribs2hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttribs2svNV(uint index, uint count, short * v);
        
        unsafe void glVertexAttribs3dvNV(uint index, uint count, double * v);
        
        unsafe void glVertexAttribs3fvNV(uint index, uint count, float * v);
        
        unsafe void glVertexAttribs3hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttribs3svNV(uint index, uint count, short * v);
        
        unsafe void glVertexAttribs4dvNV(uint index, uint count, double * v);
        
        unsafe void glVertexAttribs4fvNV(uint index, uint count, float * v);
        
        unsafe void glVertexAttribs4hvNV(uint index, uint n, OpenToolkit.Mathematics.Half * v);
        
        unsafe void glVertexAttribs4svNV(uint index, uint count, short * v);
        
        unsafe void glVertexAttribs4ubvNV(uint index, uint count, byte * v);
        
        unsafe void glVertexBindingDivisor(uint bindingindex, uint divisor);
        
        unsafe void glVertexBlendARB(int count);
        
        unsafe void glVertexBlendEnvfATI(VertexStreamATI pname, float param);
        
        unsafe void glVertexBlendEnviATI(VertexStreamATI pname, int param);
        
        unsafe void glVertexFormatNV(int size, VertexPointerType type, uint stride);
        
        unsafe void glVertexP2ui(VertexPointerType type, uint value);
        
        unsafe void glVertexP2uiv(VertexPointerType type, uint * value);
        
        unsafe void glVertexP3ui(VertexPointerType type, uint value);
        
        unsafe void glVertexP3uiv(VertexPointerType type, uint * value);
        
        unsafe void glVertexP4ui(VertexPointerType type, uint value);
        
        unsafe void glVertexP4uiv(VertexPointerType type, uint * value);
        
        unsafe void glVertexPointer(int size, VertexPointerType type, uint stride, void * pointer);
        
        unsafe void glVertexPointerEXT(int size, VertexPointerType type, uint stride, uint count, void * pointer);
        
        unsafe void glVertexPointerListIBM(int size, VertexPointerType type, int stride, void * * pointer, int ptrstride);
        
        unsafe void glVertexPointervINTEL(int size, VertexPointerType type, void * * pointer);
        
        unsafe void glVertexStream1dATI(VertexStreamATI stream, double x);
        
        unsafe void glVertexStream1dvATI(VertexStreamATI stream, double * coords);
        
        unsafe void glVertexStream1fATI(VertexStreamATI stream, float x);
        
        unsafe void glVertexStream1fvATI(VertexStreamATI stream, float * coords);
        
        unsafe void glVertexStream1iATI(VertexStreamATI stream, int x);
        
        unsafe void glVertexStream1ivATI(VertexStreamATI stream, int * coords);
        
        unsafe void glVertexStream1sATI(VertexStreamATI stream, short x);
        
        unsafe void glVertexStream1svATI(VertexStreamATI stream, short * coords);
        
        unsafe void glVertexStream2dATI(VertexStreamATI stream, double x, double y);
        
        unsafe void glVertexStream2dvATI(VertexStreamATI stream, double * coords);
        
        unsafe void glVertexStream2fATI(VertexStreamATI stream, float x, float y);
        
        unsafe void glVertexStream2fvATI(VertexStreamATI stream, float * coords);
        
        unsafe void glVertexStream2iATI(VertexStreamATI stream, int x, int y);
        
        unsafe void glVertexStream2ivATI(VertexStreamATI stream, int * coords);
        
        unsafe void glVertexStream2sATI(VertexStreamATI stream, short x, short y);
        
        unsafe void glVertexStream2svATI(VertexStreamATI stream, short * coords);
        
        unsafe void glVertexStream3dATI(VertexStreamATI stream, double x, double y, double z);
        
        unsafe void glVertexStream3dvATI(VertexStreamATI stream, double * coords);
        
        unsafe void glVertexStream3fATI(VertexStreamATI stream, float x, float y, float z);
        
        unsafe void glVertexStream3fvATI(VertexStreamATI stream, float * coords);
        
        unsafe void glVertexStream3iATI(VertexStreamATI stream, int x, int y, int z);
        
        unsafe void glVertexStream3ivATI(VertexStreamATI stream, int * coords);
        
        unsafe void glVertexStream3sATI(VertexStreamATI stream, short x, short y, short z);
        
        unsafe void glVertexStream3svATI(VertexStreamATI stream, short * coords);
        
        unsafe void glVertexStream4dATI(VertexStreamATI stream, double x, double y, double z, double w);
        
        unsafe void glVertexStream4dvATI(VertexStreamATI stream, double * coords);
        
        unsafe void glVertexStream4fATI(VertexStreamATI stream, float x, float y, float z, float w);
        
        unsafe void glVertexStream4fvATI(VertexStreamATI stream, float * coords);
        
        unsafe void glVertexStream4iATI(VertexStreamATI stream, int x, int y, int z, int w);
        
        unsafe void glVertexStream4ivATI(VertexStreamATI stream, int * coords);
        
        unsafe void glVertexStream4sATI(VertexStreamATI stream, short x, short y, short z, short w);
        
        unsafe void glVertexStream4svATI(VertexStreamATI stream, short * coords);
        
        unsafe void glVertexWeightPointerEXT(int size, VertexWeightPointerTypeEXT type, uint stride, void * pointer);
        
        unsafe void glVertexWeightfEXT(float weight);
        
        unsafe void glVertexWeightfvEXT(float * weight);
        
        unsafe void glVertexWeighthNV(OpenToolkit.Mathematics.Half weight);
        
        unsafe void glVertexWeighthvNV(OpenToolkit.Mathematics.Half * weight);
        
        unsafe void glViewport(int x, int y, uint width, uint height);
        
        unsafe void glViewportArrayv(uint first, uint count, float * v);
        
        unsafe void glViewportArrayvNV(uint first, uint count, float * v);
        
        unsafe void glViewportArrayvOES(uint first, uint count, float * v);
        
        unsafe void glViewportIndexedf(uint index, float x, float y, float w, float h);
        
        unsafe void glViewportIndexedfOES(uint index, float x, float y, float w, float h);
        
        unsafe void glViewportIndexedfNV(uint index, float x, float y, float w, float h);
        
        unsafe void glViewportIndexedfv(uint index, float * v);
        
        unsafe void glViewportIndexedfvOES(uint index, float * v);
        
        unsafe void glViewportIndexedfvNV(uint index, float * v);
        
        unsafe void glViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff);
        
        unsafe void glWaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint * buffers, uint numTextureBarriers, uint * textures, TextureLayout * srcLayouts);
        
        unsafe void glWaitSemaphoreui64NVX(uint waitGpu, uint fenceObjectCount, uint * semaphoreArray, ulong * fenceValueArray);
        
        unsafe void glWaitSync(IntPtr sync, uint flags, ulong timeout);
        
        unsafe void glWaitSyncAPPLE(IntPtr sync, uint flags, ulong timeout);
        
        unsafe void glWeightPathsNV(uint resultPath, uint numPaths, uint * paths, float * weights);
        
        unsafe void glWeightPointerARB(int size, WeightPointerTypeARB type, uint stride, void * pointer);
        
        unsafe void glWeightbvARB(int size, sbyte * weights);
        
        unsafe void glWeightdvARB(int size, double * weights);
        
        unsafe void glWeightfvARB(int size, float * weights);
        
        unsafe void glWeightivARB(int size, int * weights);
        
        unsafe void glWeightsvARB(int size, short * weights);
        
        unsafe void glWeightubvARB(int size, byte * weights);
        
        unsafe void glWeightuivARB(int size, uint * weights);
        
        unsafe void glWeightusvARB(int size, ushort * weights);
        
        unsafe void glWindowPos2d(double x, double y);
        
        unsafe void glWindowPos2dARB(double x, double y);
        
        unsafe void glWindowPos2dMESA(double x, double y);
        
        unsafe void glWindowPos2dv(double * v);
        
        unsafe void glWindowPos2dvARB(double * v);
        
        unsafe void glWindowPos2dvMESA(double * v);
        
        unsafe void glWindowPos2f(float x, float y);
        
        unsafe void glWindowPos2fARB(float x, float y);
        
        unsafe void glWindowPos2fMESA(float x, float y);
        
        unsafe void glWindowPos2fv(float * v);
        
        unsafe void glWindowPos2fvARB(float * v);
        
        unsafe void glWindowPos2fvMESA(float * v);
        
        unsafe void glWindowPos2i(int x, int y);
        
        unsafe void glWindowPos2iARB(int x, int y);
        
        unsafe void glWindowPos2iMESA(int x, int y);
        
        unsafe void glWindowPos2iv(int * v);
        
        unsafe void glWindowPos2ivARB(int * v);
        
        unsafe void glWindowPos2ivMESA(int * v);
        
        unsafe void glWindowPos2s(short x, short y);
        
        unsafe void glWindowPos2sARB(short x, short y);
        
        unsafe void glWindowPos2sMESA(short x, short y);
        
        unsafe void glWindowPos2sv(short * v);
        
        unsafe void glWindowPos2svARB(short * v);
        
        unsafe void glWindowPos2svMESA(short * v);
        
        unsafe void glWindowPos3d(double x, double y, double z);
        
        unsafe void glWindowPos3dARB(double x, double y, double z);
        
        unsafe void glWindowPos3dMESA(double x, double y, double z);
        
        unsafe void glWindowPos3dv(double * v);
        
        unsafe void glWindowPos3dvARB(double * v);
        
        unsafe void glWindowPos3dvMESA(double * v);
        
        unsafe void glWindowPos3f(float x, float y, float z);
        
        unsafe void glWindowPos3fARB(float x, float y, float z);
        
        unsafe void glWindowPos3fMESA(float x, float y, float z);
        
        unsafe void glWindowPos3fv(float * v);
        
        unsafe void glWindowPos3fvARB(float * v);
        
        unsafe void glWindowPos3fvMESA(float * v);
        
        unsafe void glWindowPos3i(int x, int y, int z);
        
        unsafe void glWindowPos3iARB(int x, int y, int z);
        
        unsafe void glWindowPos3iMESA(int x, int y, int z);
        
        unsafe void glWindowPos3iv(int * v);
        
        unsafe void glWindowPos3ivARB(int * v);
        
        unsafe void glWindowPos3ivMESA(int * v);
        
        unsafe void glWindowPos3s(short x, short y, short z);
        
        unsafe void glWindowPos3sARB(short x, short y, short z);
        
        unsafe void glWindowPos3sMESA(short x, short y, short z);
        
        unsafe void glWindowPos3sv(short * v);
        
        unsafe void glWindowPos3svARB(short * v);
        
        unsafe void glWindowPos3svMESA(short * v);
        
        unsafe void glWindowPos4dMESA(double x, double y, double z, double w);
        
        unsafe void glWindowPos4dvMESA(double * v);
        
        unsafe void glWindowPos4fMESA(float x, float y, float z, float w);
        
        unsafe void glWindowPos4fvMESA(float * v);
        
        unsafe void glWindowPos4iMESA(int x, int y, int z, int w);
        
        unsafe void glWindowPos4ivMESA(int * v);
        
        unsafe void glWindowPos4sMESA(short x, short y, short z, short w);
        
        unsafe void glWindowPos4svMESA(short * v);
        
        unsafe void glWriteMaskEXT(uint res, uint IN, VertexShaderWriteMaskEXT outX, VertexShaderWriteMaskEXT outY, VertexShaderWriteMaskEXT outZ, VertexShaderWriteMaskEXT outW);
        
        unsafe void glDrawVkImageNV(ulong vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
        
        unsafe void glWaitVkSemaphoreNV(ulong vkSemaphore);
        
        unsafe void glSignalVkSemaphoreNV(ulong vkSemaphore);
        
        unsafe void glSignalVkFenceNV(ulong vkFence);
        
    }
}
