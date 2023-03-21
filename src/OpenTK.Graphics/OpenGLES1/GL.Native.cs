// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES1
{
    public static unsafe partial class GL
    {
        public static void ActiveTexture(TextureUnit texture) => GLPointers._glActiveTexture_fnptr((uint)texture);
        
        public static void AlphaFunc(AlphaFunction func, float reference) => GLPointers._glAlphaFunc_fnptr((uint)func, reference);
        
        public static void AlphaFuncx(AlphaFunction func, int reference) => GLPointers._glAlphaFuncx_fnptr((uint)func, reference);
        
        public static void BindBuffer(BufferTargetARB target, int buffer) => GLPointers._glBindBuffer_fnptr((uint)target, buffer);
        
        public static void BindTexture(TextureTarget target, int texture) => GLPointers._glBindTexture_fnptr((uint)target, texture);
        
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => GLPointers._glBlendFunc_fnptr((uint)sfactor, (uint)dfactor);
        
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => GLPointers._glBufferData_fnptr((uint)target, size, data, (uint)usage);
        
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => GLPointers._glBufferSubData_fnptr((uint)target, offset, size, data);
        
        public static void Clear(ClearBufferMask mask) => GLPointers._glClear_fnptr((uint)mask);
        
        public static void ClearColor(float red, float green, float blue, float alpha) => GLPointers._glClearColor_fnptr(red, green, blue, alpha);
        
        public static void ClearColorx(int red, int green, int blue, int alpha) => GLPointers._glClearColorx_fnptr(red, green, blue, alpha);
        
        public static void ClearDepthf(float d) => GLPointers._glClearDepthf_fnptr(d);
        
        public static void ClearDepthx(int depth) => GLPointers._glClearDepthx_fnptr(depth);
        
        public static void ClearStencil(int s) => GLPointers._glClearStencil_fnptr(s);
        
        public static void ClientActiveTexture(TextureUnit texture) => GLPointers._glClientActiveTexture_fnptr((uint)texture);
        
        public static void ClipPlanef(ClipPlaneName p, float* eqn) => GLPointers._glClipPlanef_fnptr((uint)p, eqn);
        
        public static void ClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._glClipPlanex_fnptr((uint)plane, equation);
        
        public static void Color4f(float red, float green, float blue, float alpha) => GLPointers._glColor4f_fnptr(red, green, blue, alpha);
        
        public static void Color4ub(byte red, byte green, byte blue, byte alpha) => GLPointers._glColor4ub_fnptr(red, green, blue, alpha);
        
        public static void Color4x(int red, int green, int blue, int alpha) => GLPointers._glColor4x_fnptr(red, green, blue, alpha);
        
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => GLPointers._glColorMask_fnptr((byte)(red ? 1 : 0), (byte)(green ? 1 : 0), (byte)(blue ? 1 : 0), (byte)(alpha ? 1 : 0));
        
        public static void ColorPointer(int size, ColorPointerType type, int stride, void* pointer) => GLPointers._glColorPointer_fnptr(size, (uint)type, stride, pointer);
        
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => GLPointers._glCompressedTexImage2D_fnptr((uint)target, level, (uint)internalformat, width, height, border, imageSize, data);
        
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, InternalFormat format, int imageSize, void* data) => GLPointers._glCompressedTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
        
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => GLPointers._glCopyTexImage2D_fnptr((uint)target, level, (uint)internalformat, x, y, width, height, border);
        
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => GLPointers._glCopyTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, x, y, width, height);
        
        public static void CullFace(TriangleFace mode) => GLPointers._glCullFace_fnptr((uint)mode);
        
        public static void DeleteBuffers(int n, int* buffers) => GLPointers._glDeleteBuffers_fnptr(n, buffers);
        
        public static void DeleteTextures(int n, int* textures) => GLPointers._glDeleteTextures_fnptr(n, textures);
        
        public static void DepthFunc(DepthFunction func) => GLPointers._glDepthFunc_fnptr((uint)func);
        
        public static void DepthMask(bool flag) => GLPointers._glDepthMask_fnptr((byte)(flag ? 1 : 0));
        
        public static void DepthRangef(float n, float f) => GLPointers._glDepthRangef_fnptr(n, f);
        
        public static void DepthRangex(int n, int f) => GLPointers._glDepthRangex_fnptr(n, f);
        
        public static void Disable(EnableCap cap) => GLPointers._glDisable_fnptr((uint)cap);
        
        public static void DisableClientState(EnableCap array) => GLPointers._glDisableClientState_fnptr((uint)array);
        
        public static void DrawArrays(PrimitiveType mode, int first, int count) => GLPointers._glDrawArrays_fnptr((uint)mode, first, count);
        
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => GLPointers._glDrawElements_fnptr((uint)mode, count, (uint)type, indices);
        
        public static void Enable(EnableCap cap) => GLPointers._glEnable_fnptr((uint)cap);
        
        public static void EnableClientState(EnableCap array) => GLPointers._glEnableClientState_fnptr((uint)array);
        
        public static void Finish() => GLPointers._glFinish_fnptr();
        
        public static void Flush() => GLPointers._glFlush_fnptr();
        
        public static void Fogf(FogParameter pname, float param) => GLPointers._glFogf_fnptr((uint)pname, param);
        
        public static void Fogfv(FogParameter pname, float* parameters) => GLPointers._glFogfv_fnptr((uint)pname, parameters);
        
        public static void Fogx(FogPName pname, int param) => GLPointers._glFogx_fnptr((uint)pname, param);
        
        public static void Fogxv(FogPName pname, int* param) => GLPointers._glFogxv_fnptr((uint)pname, param);
        
        public static void FrontFace(FrontFaceDirection mode) => GLPointers._glFrontFace_fnptr((uint)mode);
        
        public static void Frustumf(float l, float r, float b, float t, float n, float f) => GLPointers._glFrustumf_fnptr(l, r, b, t, n, f);
        
        public static void Frustumx(int l, int r, int b, int t, int n, int f) => GLPointers._glFrustumx_fnptr(l, r, b, t, n, f);
        
        public static void GenBuffers(int n, int* buffers) => GLPointers._glGenBuffers_fnptr(n, buffers);
        
        public static void GenTextures(int n, int* textures) => GLPointers._glGenTextures_fnptr(n, textures);
        
        public static void GetBooleanv(GetPName pname, bool* data) => GLPointers._glGetBooleanv_fnptr((uint)pname, (byte*)data);
        
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => GLPointers._glGetBufferParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetClipPlanef(ClipPlaneName plane, float* equation) => GLPointers._glGetClipPlanef_fnptr((uint)plane, equation);
        
        public static void GetClipPlanex(ClipPlaneName plane, int* equation) => GLPointers._glGetClipPlanex_fnptr((uint)plane, equation);
        
        public static ErrorCode GetError() => (ErrorCode) GLPointers._glGetError_fnptr();
        
        public static void GetFixedv(GetPName pname, int* parameters) => GLPointers._glGetFixedv_fnptr((uint)pname, parameters);
        
        public static void GetFloatv(GetPName pname, float* data) => GLPointers._glGetFloatv_fnptr((uint)pname, data);
        
        public static void GetIntegerv(GetPName pname, int* data) => GLPointers._glGetIntegerv_fnptr((uint)pname, data);
        
        public static void GetLightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._glGetLightfv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void GetLightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void GetMaterialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glGetMaterialfv_fnptr((uint)face, (uint)pname, parameters);
        
        public static void GetMaterialxv(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glGetMaterialxv_fnptr((uint)face, (uint)pname, parameters);
        
        public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
        
        public static byte* GetString_(StringName name) => GLPointers._glGetString_fnptr((uint)name);
        
        public static void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glGetTexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnvxv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => GLPointers._glGetTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterxv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void Hint(HintTarget target, HintMode mode) => GLPointers._glHint_fnptr((uint)target, (uint)mode);
        
        public static bool IsBuffer(int buffer) => GLPointers._glIsBuffer_fnptr(buffer) != 0;
        
        public static bool IsEnabled(EnableCap cap) => GLPointers._glIsEnabled_fnptr((uint)cap) != 0;
        
        public static bool IsTexture(int texture) => GLPointers._glIsTexture_fnptr(texture) != 0;
        
        public static void Lightf(LightName light, LightParameter pname, float param) => GLPointers._glLightf_fnptr((uint)light, (uint)pname, param);
        
        public static void Lightfv(LightName light, LightParameter pname, float* parameters) => GLPointers._glLightfv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void LightModelf(LightModelParameter pname, float param) => GLPointers._glLightModelf_fnptr((uint)pname, param);
        
        public static void LightModelfv(LightModelParameter pname, float* parameters) => GLPointers._glLightModelfv_fnptr((uint)pname, parameters);
        
        public static void LightModelx(LightModelParameter pname, int param) => GLPointers._glLightModelx_fnptr((uint)pname, param);
        
        public static void LightModelxv(LightModelParameter pname, int* param) => GLPointers._glLightModelxv_fnptr((uint)pname, param);
        
        public static void Lightx(LightName light, LightParameter pname, int param) => GLPointers._glLightx_fnptr((uint)light, (uint)pname, param);
        
        public static void Lightxv(LightName light, LightParameter pname, int* parameters) => GLPointers._glLightxv_fnptr((uint)light, (uint)pname, parameters);
        
        public static void LineWidth(float width) => GLPointers._glLineWidth_fnptr(width);
        
        public static void LineWidthx(int width) => GLPointers._glLineWidthx_fnptr(width);
        
        public static void LoadIdentity() => GLPointers._glLoadIdentity_fnptr();
        
        public static void LoadMatrixf(float* m) => GLPointers._glLoadMatrixf_fnptr(m);
        
        public static void LoadMatrixx(int* m) => GLPointers._glLoadMatrixx_fnptr(m);
        
        public static void LogicOp(LogicOp opcode) => GLPointers._glLogicOp_fnptr((uint)opcode);
        
        public static void Materialf(TriangleFace face, MaterialParameter pname, float param) => GLPointers._glMaterialf_fnptr((uint)face, (uint)pname, param);
        
        public static void Materialfv(TriangleFace face, MaterialParameter pname, float* parameters) => GLPointers._glMaterialfv_fnptr((uint)face, (uint)pname, parameters);
        
        public static void Materialx(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glMaterialx_fnptr((uint)face, (uint)pname, param);
        
        public static void Materialxv(TriangleFace face, MaterialParameter pname, int* param) => GLPointers._glMaterialxv_fnptr((uint)face, (uint)pname, param);
        
        public static void MatrixMode(MatrixMode mode) => GLPointers._glMatrixMode_fnptr((uint)mode);
        
        public static void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => GLPointers._glMultiTexCoord4f_fnptr((uint)target, s, t, r, q);
        
        public static void MultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => GLPointers._glMultiTexCoord4x_fnptr((uint)texture, s, t, r, q);
        
        public static void MultMatrixf(float* m) => GLPointers._glMultMatrixf_fnptr(m);
        
        public static void MultMatrixx(int* m) => GLPointers._glMultMatrixx_fnptr(m);
        
        public static void Normal3f(float nx, float ny, float nz) => GLPointers._glNormal3f_fnptr(nx, ny, nz);
        
        public static void Normal3x(int nx, int ny, int nz) => GLPointers._glNormal3x_fnptr(nx, ny, nz);
        
        public static void NormalPointer(NormalPointerType type, int stride, void* pointer) => GLPointers._glNormalPointer_fnptr((uint)type, stride, pointer);
        
        public static void Orthof(float l, float r, float b, float t, float n, float f) => GLPointers._glOrthof_fnptr(l, r, b, t, n, f);
        
        public static void Orthox(int l, int r, int b, int t, int n, int f) => GLPointers._glOrthox_fnptr(l, r, b, t, n, f);
        
        public static void PixelStorei(PixelStoreParameter pname, int param) => GLPointers._glPixelStorei_fnptr((uint)pname, param);
        
        public static void PointParameterf(PointParameterNameARB pname, float param) => GLPointers._glPointParameterf_fnptr((uint)pname, param);
        
        public static void PointParameterfv(PointParameterNameARB pname, float* parameters) => GLPointers._glPointParameterfv_fnptr((uint)pname, parameters);
        
        public static void PointParameterx(PointParameterNameARB pname, int param) => GLPointers._glPointParameterx_fnptr((uint)pname, param);
        
        public static void PointParameterxv(PointParameterNameARB pname, int* parameters) => GLPointers._glPointParameterxv_fnptr((uint)pname, parameters);
        
        public static void PointSize(float size) => GLPointers._glPointSize_fnptr(size);
        
        public static void PointSizex(int size) => GLPointers._glPointSizex_fnptr(size);
        
        public static void PolygonOffset(float factor, float units) => GLPointers._glPolygonOffset_fnptr(factor, units);
        
        public static void PolygonOffsetx(int factor, int units) => GLPointers._glPolygonOffsetx_fnptr(factor, units);
        
        public static void PopMatrix() => GLPointers._glPopMatrix_fnptr();
        
        public static void PushMatrix() => GLPointers._glPushMatrix_fnptr();
        
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glReadPixels_fnptr(x, y, width, height, (uint)format, (uint)type, pixels);
        
        public static void Rotatef(float angle, float x, float y, float z) => GLPointers._glRotatef_fnptr(angle, x, y, z);
        
        public static void Rotatex(int angle, int x, int y, int z) => GLPointers._glRotatex_fnptr(angle, x, y, z);
        
        public static void SampleCoverage(float value, bool invert) => GLPointers._glSampleCoverage_fnptr(value, (byte)(invert ? 1 : 0));
        
        public static void SampleCoveragex(int value, bool invert) => GLPointers._glSampleCoveragex_fnptr(value, (byte)(invert ? 1 : 0));
        
        public static void Scalef(float x, float y, float z) => GLPointers._glScalef_fnptr(x, y, z);
        
        public static void Scalex(int x, int y, int z) => GLPointers._glScalex_fnptr(x, y, z);
        
        public static void Scissor(int x, int y, int width, int height) => GLPointers._glScissor_fnptr(x, y, width, height);
        
        public static void ShadeModel(ShadingModel mode) => GLPointers._glShadeModel_fnptr((uint)mode);
        
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => GLPointers._glStencilFunc_fnptr((uint)func, reference, mask);
        
        public static void StencilMask(uint mask) => GLPointers._glStencilMask_fnptr(mask);
        
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => GLPointers._glStencilOp_fnptr((uint)fail, (uint)zfail, (uint)zpass);
        
        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer) => GLPointers._glTexCoordPointer_fnptr(size, (uint)type, stride, pointer);
        
        public static void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => GLPointers._glTexEnvf_fnptr((uint)target, (uint)pname, param);
        
        public static void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => GLPointers._glTexEnvfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvi_fnptr((uint)target, (uint)pname, param);
        
        public static void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnviv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvx_fnptr((uint)target, (uint)pname, param);
        
        public static void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnvxv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexImage2D_fnptr((uint)target, level, (int)internalformat, width, height, border, (uint)format, (uint)type, pixels);
        
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => GLPointers._glTexParameterf_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => GLPointers._glTexParameterfv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => GLPointers._glTexParameteri_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => GLPointers._glTexParameteriv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexParameterx(TextureTarget target, GetTextureParameter pname, int param) => GLPointers._glTexParameterx_fnptr((uint)target, (uint)pname, param);
        
        public static void TexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glTexParameterxv_fnptr((uint)target, (uint)pname, parameters);
        
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => GLPointers._glTexSubImage2D_fnptr((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
        
        public static void Translatef(float x, float y, float z) => GLPointers._glTranslatef_fnptr(x, y, z);
        
        public static void Translatex(int x, int y, int z) => GLPointers._glTranslatex_fnptr(x, y, z);
        
        public static void VertexPointer(int size, VertexPointerType type, int stride, void* pointer) => GLPointers._glVertexPointer_fnptr(size, (uint)type, stride, pointer);
        
        public static void Viewport(int x, int y, int width, int height) => GLPointers._glViewport_fnptr(x, y, width, height);
        
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
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => GLPointers._glBlendEquationEXT_fnptr((uint)mode);
            
            public static void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => GLPointers._glDiscardFramebufferEXT_fnptr((uint)target, numAttachments, (uint*)attachments);
            
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => GLPointers._glFlushMappedBufferRangeEXT_fnptr((uint)target, offset, length);
            
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleEXT_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => (GraphicsResetStatus) GLPointers._glGetGraphicsResetStatusEXT_fnptr();
            
            public static void GetnUniformfvEXT(int program, int location, int bufSize, float* parameters) => GLPointers._glGetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            
            public static void GetnUniformivEXT(int program, int location, int bufSize, int* parameters) => GLPointers._glGetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            
            public static void InsertEventMarkerEXT(int length, byte* marker) => GLPointers._glInsertEventMarkerEXT_fnptr(length, marker);
            
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => GLPointers._glMapBufferRangeEXT_fnptr((uint)target, offset, length, (uint)access);
            
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => GLPointers._glMultiDrawArraysEXT_fnptr((uint)mode, first, count, primcount);
            
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => GLPointers._glMultiDrawElementsEXT_fnptr((uint)mode, count, (uint)type, indices, primcount);
            
            public static void PopGroupMarkerEXT() => GLPointers._glPopGroupMarkerEXT_fnptr();
            
            public static void PushGroupMarkerEXT(int length, byte* marker) => GLPointers._glPushGroupMarkerEXT_fnptr(length, marker);
            
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => GLPointers._glReadnPixelsEXT_fnptr(x, y, width, height, (uint)format, (uint)type, bufSize, data);
            
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleEXT_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTexStorage1DEXT_fnptr((uint)target, levels, (uint)internalformat, width);
            
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTexStorage2DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height);
            
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTexStorage3DEXT_fnptr((uint)target, levels, (uint)internalformat, width, height, depth);
            
            public static void TextureStorage1DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width) => GLPointers._glTextureStorage1DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width);
            
            public static void TextureStorage2DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => GLPointers._glTextureStorage2DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height);
            
            public static void TextureStorage3DEXT(int texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => GLPointers._glTextureStorage3DEXT_fnptr(texture, (uint)target, levels, (uint)internalformat, width, height, depth);
            
        }
        /// <summary>IMG extensions.</summary>
        public static unsafe partial class IMG
        {
            public static void ClipPlanefIMG(ClipPlaneName p, float* eqn) => GLPointers._glClipPlanefIMG_fnptr((uint)p, eqn);
            
            public static void ClipPlanexIMG(ClipPlaneName p, int* eqn) => GLPointers._glClipPlanexIMG_fnptr((uint)p, eqn);
            
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level, int samples) => GLPointers._glFramebufferTexture2DMultisampleIMG_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level, samples);
            
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageMultisampleIMG_fnptr((uint)target, samples, (uint)internalformat, width, height);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallback_fnptr(callback, userParam);
            
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => GLPointers._glDebugMessageCallbackKHR_fnptr(callback, userParam);
            
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControl_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, bool enabled) => GLPointers._glDebugMessageControlKHR_fnptr((uint)source, (uint)type, (uint)severity, count, ids, (byte)(enabled ? 1 : 0));
            
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsert_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => GLPointers._glDebugMessageInsertKHR_fnptr((uint)source, (uint)type, id, (uint)severity, length, buf);
            
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLog_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => GLPointers._glGetDebugMessageLogKHR_fnptr(count, bufSize, (uint*)sources, (uint*)types, ids, (uint*)severities, lengths, messageLog);
            
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabel_fnptr((uint)identifier, name, bufSize, length, label);
            
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => GLPointers._glGetObjectLabelKHR_fnptr((uint)identifier, name, bufSize, length, label);
            
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => GLPointers._glGetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            
            public static void GetPointerv(GetPointervPName pname, void** parameters) => GLPointers._glGetPointerv_fnptr((uint)pname, parameters);
            
            public static void GetPointervKHR(All pname, void** parameters) => GLPointers._glGetPointervKHR_fnptr((uint)pname, parameters);
            
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabel_fnptr((uint)identifier, name, length, label);
            
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => GLPointers._glObjectLabelKHR_fnptr((uint)identifier, name, length, label);
            
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabel_fnptr(ptr, length, label);
            
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => GLPointers._glObjectPtrLabelKHR_fnptr(ptr, length, label);
            
            public static void PopDebugGroup() => GLPointers._glPopDebugGroup_fnptr();
            
            public static void PopDebugGroupKHR() => GLPointers._glPopDebugGroupKHR_fnptr();
            
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroup_fnptr((uint)source, id, length, message);
            
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => GLPointers._glPushDebugGroupKHR_fnptr((uint)source, id, length, message);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            public static void DeleteFencesNV(int n, uint* fences) => GLPointers._glDeleteFencesNV_fnptr(n, fences);
            
            public static void FinishFenceNV(uint fence) => GLPointers._glFinishFenceNV_fnptr(fence);
            
            public static void GenFencesNV(int n, uint* fences) => GLPointers._glGenFencesNV_fnptr(n, fences);
            
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => GLPointers._glGetFenceivNV_fnptr(fence, (uint)pname, parameters);
            
            public static bool IsFenceNV(uint fence) => GLPointers._glIsFenceNV_fnptr(fence) != 0;
            
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => GLPointers._glSetFenceNV_fnptr(fence, (uint)condition);
            
            public static bool TestFenceNV(uint fence) => GLPointers._glTestFenceNV_fnptr(fence) != 0;
            
        }
        /// <summary>OES extensions.</summary>
        public static unsafe partial class OES
        {
            public static void AccumxOES(All op, int value) => GLPointers._glAccumxOES_fnptr((uint)op, value);
            
            public static void AlphaFuncxOES(AlphaFunction func, int reference) => GLPointers._glAlphaFuncxOES_fnptr((uint)func, reference);
            
            public static void BindFramebufferOES(FramebufferTarget target, int framebuffer) => GLPointers._glBindFramebufferOES_fnptr((uint)target, framebuffer);
            
            public static void BindRenderbufferOES(RenderbufferTarget target, int renderbuffer) => GLPointers._glBindRenderbufferOES_fnptr((uint)target, renderbuffer);
            
            public static void BindVertexArrayOES(int array) => GLPointers._glBindVertexArrayOES_fnptr(array);
            
            public static void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) => GLPointers._glBitmapxOES_fnptr(width, height, xorig, yorig, xmove, ymove, bitmap);
            
            public static void BlendColorxOES(int red, int green, int blue, int alpha) => GLPointers._glBlendColorxOES_fnptr(red, green, blue, alpha);
            
            public static void BlendEquationOES(BlendEquationModeEXT mode) => GLPointers._glBlendEquationOES_fnptr((uint)mode);
            
            public static void BlendEquationSeparateOES(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => GLPointers._glBlendEquationSeparateOES_fnptr((uint)modeRGB, (uint)modeAlpha);
            
            public static void BlendFuncSeparateOES(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => GLPointers._glBlendFuncSeparateOES_fnptr((uint)srcRGB, (uint)dstRGB, (uint)srcAlpha, (uint)dstAlpha);
            
            public static FramebufferStatus CheckFramebufferStatusOES(FramebufferTarget target) => (FramebufferStatus) GLPointers._glCheckFramebufferStatusOES_fnptr((uint)target);
            
            public static void ClearAccumxOES(int red, int green, int blue, int alpha) => GLPointers._glClearAccumxOES_fnptr(red, green, blue, alpha);
            
            public static void ClearColorxOES(int red, int green, int blue, int alpha) => GLPointers._glClearColorxOES_fnptr(red, green, blue, alpha);
            
            public static void ClearDepthfOES(float depth) => GLPointers._glClearDepthfOES_fnptr(depth);
            
            public static void ClearDepthxOES(int depth) => GLPointers._glClearDepthxOES_fnptr(depth);
            
            public static void ClipPlanefOES(ClipPlaneName plane, float* equation) => GLPointers._glClipPlanefOES_fnptr((uint)plane, equation);
            
            public static void ClipPlanexOES(ClipPlaneName plane, int* equation) => GLPointers._glClipPlanexOES_fnptr((uint)plane, equation);
            
            public static void Color3xOES(int red, int green, int blue) => GLPointers._glColor3xOES_fnptr(red, green, blue);
            
            public static void Color3xvOES(int* components) => GLPointers._glColor3xvOES_fnptr(components);
            
            public static void Color4xOES(int red, int green, int blue, int alpha) => GLPointers._glColor4xOES_fnptr(red, green, blue, alpha);
            
            public static void Color4xvOES(int* components) => GLPointers._glColor4xvOES_fnptr(components);
            
            public static void ConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameter pname, int param) => GLPointers._glConvolutionParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            public static void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameter pname, int* parameters) => GLPointers._glConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void CurrentPaletteMatrixOES(uint matrixpaletteindex) => GLPointers._glCurrentPaletteMatrixOES_fnptr(matrixpaletteindex);
            
            public static void DeleteFramebuffersOES(int n, int* framebuffers) => GLPointers._glDeleteFramebuffersOES_fnptr(n, framebuffers);
            
            public static void DeleteRenderbuffersOES(int n, int* renderbuffers) => GLPointers._glDeleteRenderbuffersOES_fnptr(n, renderbuffers);
            
            public static void DeleteVertexArraysOES(int n, int* arrays) => GLPointers._glDeleteVertexArraysOES_fnptr(n, arrays);
            
            public static void DepthRangefOES(float n, float f) => GLPointers._glDepthRangefOES_fnptr(n, f);
            
            public static void DepthRangexOES(int n, int f) => GLPointers._glDepthRangexOES_fnptr(n, f);
            
            public static void DrawTexfOES(float x, float y, float z, float width, float height) => GLPointers._glDrawTexfOES_fnptr(x, y, z, width, height);
            
            public static void DrawTexfvOES(float* coords) => GLPointers._glDrawTexfvOES_fnptr(coords);
            
            public static void DrawTexiOES(int x, int y, int z, int width, int height) => GLPointers._glDrawTexiOES_fnptr(x, y, z, width, height);
            
            public static void DrawTexivOES(int* coords) => GLPointers._glDrawTexivOES_fnptr(coords);
            
            public static void DrawTexsOES(short x, short y, short z, short width, short height) => GLPointers._glDrawTexsOES_fnptr(x, y, z, width, height);
            
            public static void DrawTexsvOES(short* coords) => GLPointers._glDrawTexsvOES_fnptr(coords);
            
            public static void DrawTexxOES(int x, int y, int z, int width, int height) => GLPointers._glDrawTexxOES_fnptr(x, y, z, width, height);
            
            public static void DrawTexxvOES(int* coords) => GLPointers._glDrawTexxvOES_fnptr(coords);
            
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => GLPointers._glEGLImageTargetRenderbufferStorageOES_fnptr((uint)target, image);
            
            public static void EGLImageTargetTexture2DOES(All target, void* image) => GLPointers._glEGLImageTargetTexture2DOES_fnptr((uint)target, image);
            
            public static void EvalCoord1xOES(int u) => GLPointers._glEvalCoord1xOES_fnptr(u);
            
            public static void EvalCoord1xvOES(int* coords) => GLPointers._glEvalCoord1xvOES_fnptr(coords);
            
            public static void EvalCoord2xOES(int u, int v) => GLPointers._glEvalCoord2xOES_fnptr(u, v);
            
            public static void EvalCoord2xvOES(int* coords) => GLPointers._glEvalCoord2xvOES_fnptr(coords);
            
            public static void FeedbackBufferxOES(int n, All type, int* buffer) => GLPointers._glFeedbackBufferxOES_fnptr(n, (uint)type, buffer);
            
            public static void FogxOES(FogPName pname, int param) => GLPointers._glFogxOES_fnptr((uint)pname, param);
            
            public static void FogxvOES(FogPName pname, int* param) => GLPointers._glFogxvOES_fnptr((uint)pname, param);
            
            public static void FramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer) => GLPointers._glFramebufferRenderbufferOES_fnptr((uint)target, (uint)attachment, (uint)renderbuffertarget, renderbuffer);
            
            public static void FramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level) => GLPointers._glFramebufferTexture2DOES_fnptr((uint)target, (uint)attachment, (uint)textarget, texture, level);
            
            public static void FrustumfOES(float l, float r, float b, float t, float n, float f) => GLPointers._glFrustumfOES_fnptr(l, r, b, t, n, f);
            
            public static void FrustumxOES(int l, int r, int b, int t, int n, int f) => GLPointers._glFrustumxOES_fnptr(l, r, b, t, n, f);
            
            public static void GenerateMipmapOES(TextureTarget target) => GLPointers._glGenerateMipmapOES_fnptr((uint)target);
            
            public static void GenFramebuffersOES(int n, int* framebuffers) => GLPointers._glGenFramebuffersOES_fnptr(n, framebuffers);
            
            public static void GenRenderbuffersOES(int n, int* renderbuffers) => GLPointers._glGenRenderbuffersOES_fnptr(n, renderbuffers);
            
            public static void GenVertexArraysOES(int n, int* arrays) => GLPointers._glGenVertexArraysOES_fnptr(n, arrays);
            
            public static void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => GLPointers._glGetBufferPointervOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetClipPlanefOES(ClipPlaneName plane, float* equation) => GLPointers._glGetClipPlanefOES_fnptr((uint)plane, equation);
            
            public static void GetClipPlanexOES(ClipPlaneName plane, int* equation) => GLPointers._glGetClipPlanexOES_fnptr((uint)plane, equation);
            
            public static void GetConvolutionParameterxvOES(All target, All pname, int* parameters) => GLPointers._glGetConvolutionParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetFixedvOES(GetPName pname, int* parameters) => GLPointers._glGetFixedvOES_fnptr((uint)pname, parameters);
            
            public static void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => GLPointers._glGetFramebufferAttachmentParameterivOES_fnptr((uint)target, (uint)attachment, (uint)pname, parameters);
            
            public static void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => GLPointers._glGetHistogramParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetLightxOES(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxOES_fnptr((uint)light, (uint)pname, parameters);
            
            public static void GetLightxvOES(LightName light, LightParameter pname, int* parameters) => GLPointers._glGetLightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            public static void GetMapxvOES(MapTarget target, GetMapQuery query, int* v) => GLPointers._glGetMapxvOES_fnptr((uint)target, (uint)query, v);
            
            public static void GetMaterialxOES(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glGetMaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            public static void GetMaterialxvOES(TriangleFace face, MaterialParameter pname, int* parameters) => GLPointers._glGetMaterialxvOES_fnptr((uint)face, (uint)pname, parameters);
            
            public static void GetPixelMapxv(PixelMap map, int size, int* values) => GLPointers._glGetPixelMapxv_fnptr((uint)map, size, values);
            
            public static void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => GLPointers._glGetRenderbufferParameterivOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glGetTexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glGetTexGenfvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glGetTexGenivOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glGetTexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexLevelParameterxvOES_fnptr((uint)target, level, (uint)pname, parameters);
            
            public static void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glGetTexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void IndexxOES(int component) => GLPointers._glIndexxOES_fnptr(component);
            
            public static void IndexxvOES(int* component) => GLPointers._glIndexxvOES_fnptr(component);
            
            public static bool IsFramebufferOES(int framebuffer) => GLPointers._glIsFramebufferOES_fnptr(framebuffer) != 0;
            
            public static bool IsRenderbufferOES(int renderbuffer) => GLPointers._glIsRenderbufferOES_fnptr(renderbuffer) != 0;
            
            public static bool IsVertexArrayOES(int array) => GLPointers._glIsVertexArrayOES_fnptr(array) != 0;
            
            public static void LightModelxOES(LightModelParameter pname, int param) => GLPointers._glLightModelxOES_fnptr((uint)pname, param);
            
            public static void LightModelxvOES(LightModelParameter pname, int* param) => GLPointers._glLightModelxvOES_fnptr((uint)pname, param);
            
            public static void LightxOES(LightName light, LightParameter pname, int param) => GLPointers._glLightxOES_fnptr((uint)light, (uint)pname, param);
            
            public static void LightxvOES(LightName light, LightParameter pname, int* parameters) => GLPointers._glLightxvOES_fnptr((uint)light, (uint)pname, parameters);
            
            public static void LineWidthxOES(int width) => GLPointers._glLineWidthxOES_fnptr(width);
            
            public static void LoadMatrixxOES(int* m) => GLPointers._glLoadMatrixxOES_fnptr(m);
            
            public static void LoadPaletteFromModelViewMatrixOES() => GLPointers._glLoadPaletteFromModelViewMatrixOES_fnptr();
            
            public static void LoadTransposeMatrixxOES(int* m) => GLPointers._glLoadTransposeMatrixxOES_fnptr(m);
            
            public static void Map1xOES(MapTarget target, int u1, int u2, int stride, int order, int points) => GLPointers._glMap1xOES_fnptr((uint)target, u1, u2, stride, order, points);
            
            public static void Map2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => GLPointers._glMap2xOES_fnptr((uint)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => GLPointers._glMapBufferOES_fnptr((uint)target, (uint)access);
            
            public static void MapGrid1xOES(int n, int u1, int u2) => GLPointers._glMapGrid1xOES_fnptr(n, u1, u2);
            
            public static void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) => GLPointers._glMapGrid2xOES_fnptr(n, u1, u2, v1, v2);
            
            public static void MaterialxOES(TriangleFace face, MaterialParameter pname, int param) => GLPointers._glMaterialxOES_fnptr((uint)face, (uint)pname, param);
            
            public static void MaterialxvOES(TriangleFace face, MaterialParameter pname, int* param) => GLPointers._glMaterialxvOES_fnptr((uint)face, (uint)pname, param);
            
            public static void MatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer) => GLPointers._glMatrixIndexPointerOES_fnptr(size, (uint)type, stride, pointer);
            
            public static void MultiTexCoord1bOES(TextureUnit texture, sbyte s) => GLPointers._glMultiTexCoord1bOES_fnptr((uint)texture, s);
            
            public static void MultiTexCoord1bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord1bvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord1xOES(TextureUnit texture, int s) => GLPointers._glMultiTexCoord1xOES_fnptr((uint)texture, s);
            
            public static void MultiTexCoord1xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord1xvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t) => GLPointers._glMultiTexCoord2bOES_fnptr((uint)texture, s, t);
            
            public static void MultiTexCoord2bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord2bvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord2xOES(TextureUnit texture, int s, int t) => GLPointers._glMultiTexCoord2xOES_fnptr((uint)texture, s, t);
            
            public static void MultiTexCoord2xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord2xvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r) => GLPointers._glMultiTexCoord3bOES_fnptr((uint)texture, s, t, r);
            
            public static void MultiTexCoord3bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord3bvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord3xOES(TextureUnit texture, int s, int t, int r) => GLPointers._glMultiTexCoord3xOES_fnptr((uint)texture, s, t, r);
            
            public static void MultiTexCoord3xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord3xvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._glMultiTexCoord4bOES_fnptr((uint)texture, s, t, r, q);
            
            public static void MultiTexCoord4bvOES(TextureUnit texture, sbyte* coords) => GLPointers._glMultiTexCoord4bvOES_fnptr((uint)texture, coords);
            
            public static void MultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q) => GLPointers._glMultiTexCoord4xOES_fnptr((uint)texture, s, t, r, q);
            
            public static void MultiTexCoord4xvOES(TextureUnit texture, int* coords) => GLPointers._glMultiTexCoord4xvOES_fnptr((uint)texture, coords);
            
            public static void MultMatrixxOES(int* m) => GLPointers._glMultMatrixxOES_fnptr(m);
            
            public static void MultTransposeMatrixxOES(int* m) => GLPointers._glMultTransposeMatrixxOES_fnptr(m);
            
            public static void Normal3xOES(int nx, int ny, int nz) => GLPointers._glNormal3xOES_fnptr(nx, ny, nz);
            
            public static void Normal3xvOES(int* coords) => GLPointers._glNormal3xvOES_fnptr(coords);
            
            public static void OrthofOES(float l, float r, float b, float t, float n, float f) => GLPointers._glOrthofOES_fnptr(l, r, b, t, n, f);
            
            public static void OrthoxOES(int l, int r, int b, int t, int n, int f) => GLPointers._glOrthoxOES_fnptr(l, r, b, t, n, f);
            
            public static void PassThroughxOES(int token) => GLPointers._glPassThroughxOES_fnptr(token);
            
            public static void PixelMapx(PixelMap map, int size, int* values) => GLPointers._glPixelMapx_fnptr((uint)map, size, values);
            
            public static void PixelStorex(PixelStoreParameter pname, int param) => GLPointers._glPixelStorex_fnptr((uint)pname, param);
            
            public static void PixelTransferxOES(PixelTransferParameter pname, int param) => GLPointers._glPixelTransferxOES_fnptr((uint)pname, param);
            
            public static void PixelZoomxOES(int xfactor, int yfactor) => GLPointers._glPixelZoomxOES_fnptr(xfactor, yfactor);
            
            public static void PointParameterxOES(PointParameterNameARB pname, int param) => GLPointers._glPointParameterxOES_fnptr((uint)pname, param);
            
            public static void PointParameterxvOES(PointParameterNameARB pname, int* parameters) => GLPointers._glPointParameterxvOES_fnptr((uint)pname, parameters);
            
            public static void PointSizePointerOES(All type, int stride, void* pointer) => GLPointers._glPointSizePointerOES_fnptr((uint)type, stride, pointer);
            
            public static void PointSizexOES(int size) => GLPointers._glPointSizexOES_fnptr(size);
            
            public static void PolygonOffsetxOES(int factor, int units) => GLPointers._glPolygonOffsetxOES_fnptr(factor, units);
            
            public static void PrioritizeTexturesxOES(int n, int* textures, int* priorities) => GLPointers._glPrioritizeTexturesxOES_fnptr(n, textures, priorities);
            
            public static uint QueryMatrixxOES(int* mantissa, int* exponent) => GLPointers._glQueryMatrixxOES_fnptr(mantissa, exponent);
            
            public static void RasterPos2xOES(int x, int y) => GLPointers._glRasterPos2xOES_fnptr(x, y);
            
            public static void RasterPos2xvOES(int* coords) => GLPointers._glRasterPos2xvOES_fnptr(coords);
            
            public static void RasterPos3xOES(int x, int y, int z) => GLPointers._glRasterPos3xOES_fnptr(x, y, z);
            
            public static void RasterPos3xvOES(int* coords) => GLPointers._glRasterPos3xvOES_fnptr(coords);
            
            public static void RasterPos4xOES(int x, int y, int z, int w) => GLPointers._glRasterPos4xOES_fnptr(x, y, z, w);
            
            public static void RasterPos4xvOES(int* coords) => GLPointers._glRasterPos4xvOES_fnptr(coords);
            
            public static void RectxOES(int x1, int y1, int x2, int y2) => GLPointers._glRectxOES_fnptr(x1, y1, x2, y2);
            
            public static void RectxvOES(int* v1, int* v2) => GLPointers._glRectxvOES_fnptr(v1, v2);
            
            public static void RenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => GLPointers._glRenderbufferStorageOES_fnptr((uint)target, (uint)internalformat, width, height);
            
            public static void RotatexOES(int angle, int x, int y, int z) => GLPointers._glRotatexOES_fnptr(angle, x, y, z);
            
            public static void SampleCoveragexOES(int value, bool invert) => GLPointers._glSampleCoveragexOES_fnptr(value, (byte)(invert ? 1 : 0));
            
            public static void ScalexOES(int x, int y, int z) => GLPointers._glScalexOES_fnptr(x, y, z);
            
            public static void TexCoord1bOES(sbyte s) => GLPointers._glTexCoord1bOES_fnptr(s);
            
            public static void TexCoord1bvOES(sbyte* coords) => GLPointers._glTexCoord1bvOES_fnptr(coords);
            
            public static void TexCoord1xOES(int s) => GLPointers._glTexCoord1xOES_fnptr(s);
            
            public static void TexCoord1xvOES(int* coords) => GLPointers._glTexCoord1xvOES_fnptr(coords);
            
            public static void TexCoord2bOES(sbyte s, sbyte t) => GLPointers._glTexCoord2bOES_fnptr(s, t);
            
            public static void TexCoord2bvOES(sbyte* coords) => GLPointers._glTexCoord2bvOES_fnptr(coords);
            
            public static void TexCoord2xOES(int s, int t) => GLPointers._glTexCoord2xOES_fnptr(s, t);
            
            public static void TexCoord2xvOES(int* coords) => GLPointers._glTexCoord2xvOES_fnptr(coords);
            
            public static void TexCoord3bOES(sbyte s, sbyte t, sbyte r) => GLPointers._glTexCoord3bOES_fnptr(s, t, r);
            
            public static void TexCoord3bvOES(sbyte* coords) => GLPointers._glTexCoord3bvOES_fnptr(coords);
            
            public static void TexCoord3xOES(int s, int t, int r) => GLPointers._glTexCoord3xOES_fnptr(s, t, r);
            
            public static void TexCoord3xvOES(int* coords) => GLPointers._glTexCoord3xvOES_fnptr(coords);
            
            public static void TexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q) => GLPointers._glTexCoord4bOES_fnptr(s, t, r, q);
            
            public static void TexCoord4bvOES(sbyte* coords) => GLPointers._glTexCoord4bvOES_fnptr(coords);
            
            public static void TexCoord4xOES(int s, int t, int r, int q) => GLPointers._glTexCoord4xOES_fnptr(s, t, r, q);
            
            public static void TexCoord4xvOES(int* coords) => GLPointers._glTexCoord4xvOES_fnptr(coords);
            
            public static void TexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param) => GLPointers._glTexEnvxOES_fnptr((uint)target, (uint)pname, param);
            
            public static void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => GLPointers._glTexEnvxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TexGenfOES(TextureCoordName coord, TextureGenParameter pname, float param) => GLPointers._glTexGenfOES_fnptr((uint)coord, (uint)pname, param);
            
            public static void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => GLPointers._glTexGenfvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void TexGeniOES(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._glTexGeniOES_fnptr((uint)coord, (uint)pname, param);
            
            public static void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glTexGenivOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void TexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param) => GLPointers._glTexGenxOES_fnptr((uint)coord, (uint)pname, param);
            
            public static void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => GLPointers._glTexGenxvOES_fnptr((uint)coord, (uint)pname, parameters);
            
            public static void TexParameterxOES(TextureTarget target, GetTextureParameter pname, int param) => GLPointers._glTexParameterxOES_fnptr((uint)target, (uint)pname, param);
            
            public static void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => GLPointers._glTexParameterxvOES_fnptr((uint)target, (uint)pname, parameters);
            
            public static void TranslatexOES(int x, int y, int z) => GLPointers._glTranslatexOES_fnptr(x, y, z);
            
            public static bool UnmapBufferOES(All target) => GLPointers._glUnmapBufferOES_fnptr((uint)target) != 0;
            
            public static void Vertex2bOES(sbyte x, sbyte y) => GLPointers._glVertex2bOES_fnptr(x, y);
            
            public static void Vertex2bvOES(sbyte* coords) => GLPointers._glVertex2bvOES_fnptr(coords);
            
            public static void Vertex2xOES(int x) => GLPointers._glVertex2xOES_fnptr(x);
            
            public static void Vertex2xvOES(int* coords) => GLPointers._glVertex2xvOES_fnptr(coords);
            
            public static void Vertex3bOES(sbyte x, sbyte y, sbyte z) => GLPointers._glVertex3bOES_fnptr(x, y, z);
            
            public static void Vertex3bvOES(sbyte* coords) => GLPointers._glVertex3bvOES_fnptr(coords);
            
            public static void Vertex3xOES(int x, int y) => GLPointers._glVertex3xOES_fnptr(x, y);
            
            public static void Vertex3xvOES(int* coords) => GLPointers._glVertex3xvOES_fnptr(coords);
            
            public static void Vertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w) => GLPointers._glVertex4bOES_fnptr(x, y, z, w);
            
            public static void Vertex4bvOES(sbyte* coords) => GLPointers._glVertex4bvOES_fnptr(coords);
            
            public static void Vertex4xOES(int x, int y, int z) => GLPointers._glVertex4xOES_fnptr(x, y, z);
            
            public static void Vertex4xvOES(int* coords) => GLPointers._glVertex4xvOES_fnptr(coords);
            
            public static void WeightPointerOES(int size, All type, int stride, void* pointer) => GLPointers._glWeightPointerOES_fnptr(size, (uint)type, stride, pointer);
            
        }
        /// <summary>QCOM extensions.</summary>
        public static unsafe partial class QCOM
        {
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
            
            public static void ExtTexObjectStateOverrideiQCOM(All target, All pname, int param) => GLPointers._glExtTexObjectStateOverrideiQCOM_fnptr((uint)target, (uint)pname, param);
            
            public static void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => GLPointers._glGetDriverControlsQCOM_fnptr(num, size, driverControls);
            
            public static void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => GLPointers._glGetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => GLPointers._glStartTilingQCOM_fnptr(x, y, width, height, (uint)preserveMask);
            
        }
    }
}
