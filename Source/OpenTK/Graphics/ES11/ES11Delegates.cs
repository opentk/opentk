//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
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



namespace OpenTK.Graphics.ES11
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
            internal delegate void AccumxOES(OpenTK.Graphics.ES11.All op, int value);
            internal static AccumxOES glAccumxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref);
            internal static AlphaFunc glAlphaFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref);
            internal static AlphaFuncx glAlphaFuncx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFuncxOES(OpenTK.Graphics.ES11.All func, int @ref);
            internal static AlphaFuncxOES glAlphaFuncxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebufferOES(OpenTK.Graphics.ES11.All target, UInt32 framebuffer);
            internal static BindFramebufferOES glBindFramebufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbufferOES(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer);
            internal static BindRenderbufferOES glBindRenderbufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArrayOES(UInt32 array);
            internal static BindVertexArrayOES glBindVertexArrayOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void BitmapxOES(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap);
            internal unsafe static BitmapxOES glBitmapxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColorxOES(int red, int green, int blue, int alpha);
            internal static BlendColorxOES glBlendColorxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationEXT(OpenTK.Graphics.ES11.All mode);
            internal static BlendEquationEXT glBlendEquationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationOES(OpenTK.Graphics.ES11.All mode);
            internal static BlendEquationOES glBlendEquationOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateOES(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha);
            internal static BlendEquationSeparateOES glBlendEquationSeparateOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateOES(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha);
            internal static BlendFuncSeparateOES glBlendFuncSeparateOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage);
            internal static BufferData glBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES11.All CheckFramebufferStatusOES(OpenTK.Graphics.ES11.All target);
            internal static CheckFramebufferStatusOES glCheckFramebufferStatusOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask);
            internal static Clear glClear;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearAccumxOES(int red, int green, int blue, int alpha);
            internal static ClearAccumxOES glClearAccumxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorx(int red, int green, int blue, int alpha);
            internal static ClearColorx glClearColorx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorxOES(int red, int green, int blue, int alpha);
            internal static ClearColorxOES glClearColorxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthfOES(Single depth);
            internal static ClearDepthfOES glClearDepthfOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthx(int depth);
            internal static ClearDepthx glClearDepthx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthxOES(int depth);
            internal static ClearDepthxOES glClearDepthxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
            internal static ClientActiveTexture glClientActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES11.All ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static ClientWaitSyncAPPLE glClientWaitSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanef(OpenTK.Graphics.ES11.All p, Single* eqn);
            internal unsafe static ClipPlanef glClipPlanef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanefIMG(OpenTK.Graphics.ES11.All p, Single* eqn);
            internal unsafe static ClipPlanefIMG glClipPlanefIMG;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanefOES(OpenTK.Graphics.ES11.All plane, Single* equation);
            internal unsafe static ClipPlanefOES glClipPlanefOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation);
            internal unsafe static ClipPlanex glClipPlanex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanexIMG(OpenTK.Graphics.ES11.All p, int* eqn);
            internal unsafe static ClipPlanexIMG glClipPlanexIMG;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlanexOES(OpenTK.Graphics.ES11.All plane, int* equation);
            internal unsafe static ClipPlanexOES glClipPlanexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3xOES(int red, int green, int blue);
            internal static Color3xOES glColor3xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3xvOES(int* components);
            internal unsafe static Color3xvOES glColor3xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
            internal static Color4f glColor4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            internal static Color4ub glColor4ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4x(int red, int green, int blue, int alpha);
            internal static Color4x glColor4x;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4xOES(int red, int green, int blue, int alpha);
            internal static Color4xOES glColor4xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4xvOES(int* components);
            internal unsafe static Color4xvOES glColor4xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer);
            internal static ColorPointer glColorPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static ConvolutionParameterxOES glConvolutionParameterxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static ConvolutionParameterxvOES glConvolutionParameterxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            internal static CopyTextureLevelsAPPLE glCopyTextureLevelsAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode);
            internal static CullFace glCullFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex);
            internal static CurrentPaletteMatrixOES glCurrentPaletteMatrixOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffersOES(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffersOES glDeleteFramebuffersOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffersOES glDeleteRenderbuffersOES;
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
            internal delegate void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangefOES(Single n, Single f);
            internal static DepthRangefOES glDepthRangefOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangex(int n, int f);
            internal static DepthRangex glDepthRangex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangexOES(int n, int f);
            internal static DepthRangexOES glDepthRangexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(OpenTK.Graphics.ES11.EnableCap cap);
            internal static Disable glDisable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientState(OpenTK.Graphics.ES11.EnableCap array);
            internal static DisableClientState glDisableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableDriverControlQCOM(UInt32 driverControl);
            internal static DisableDriverControlQCOM glDisableDriverControlQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DiscardFramebufferEXT(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments);
            internal unsafe static DiscardFramebufferEXT glDiscardFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTexfOES(Single x, Single y, Single z, Single width, Single height);
            internal static DrawTexfOES glDrawTexfOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawTexfvOES(Single* coords);
            internal unsafe static DrawTexfvOES glDrawTexfvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);
            internal static DrawTexiOES glDrawTexiOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawTexivOES(Int32* coords);
            internal unsafe static DrawTexivOES glDrawTexivOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);
            internal static DrawTexsOES glDrawTexsOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawTexsvOES(Int16* coords);
            internal unsafe static DrawTexsvOES glDrawTexsvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTexxOES(int x, int y, int z, int width, int height);
            internal static DrawTexxOES glDrawTexxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawTexxvOES(int* coords);
            internal unsafe static DrawTexxvOES glDrawTexxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES11.All target, IntPtr image);
            internal static EGLImageTargetRenderbufferStorageOES glEGLImageTargetRenderbufferStorageOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES11.All target, IntPtr image);
            internal static EGLImageTargetTexture2DOES glEGLImageTargetTexture2DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(OpenTK.Graphics.ES11.EnableCap cap);
            internal static Enable glEnable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientState(OpenTK.Graphics.ES11.EnableCap array);
            internal static EnableClientState glEnableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableDriverControlQCOM(UInt32 driverControl);
            internal static EnableDriverControlQCOM glEnableDriverControlQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTilingQCOM(UInt32 preserveMask);
            internal static EndTilingQCOM glEndTilingQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1xOES(int u);
            internal static EvalCoord1xOES glEvalCoord1xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1xvOES(int* coords);
            internal unsafe static EvalCoord1xvOES glEvalCoord1xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2xOES(int u, int v);
            internal static EvalCoord2xOES glEvalCoord2xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2xvOES(int* coords);
            internal unsafe static EvalCoord2xvOES glEvalCoord2xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params);
            internal static ExtGetBufferPointervQCOM glExtGetBufferPointervQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            internal unsafe static ExtGetBuffersQCOM glExtGetBuffersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            internal unsafe static ExtGetFramebuffersQCOM glExtGetFramebuffersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
            internal unsafe static ExtGetProgramBinarySourceQCOM glExtGetProgramBinarySourceQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
            internal unsafe static ExtGetProgramsQCOM glExtGetProgramsQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
            internal unsafe static ExtGetRenderbuffersQCOM glExtGetRenderbuffersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
            internal unsafe static ExtGetShadersQCOM glExtGetShadersQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static ExtGetTexLevelParameterivQCOM glExtGetTexLevelParameterivQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels);
            internal static ExtGetTexSubImageQCOM glExtGetTexSubImageQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            internal unsafe static ExtGetTexturesQCOM glExtGetTexturesQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool ExtIsProgramBinaryQCOM(UInt32 program);
            internal static ExtIsProgramBinaryQCOM glExtIsProgramBinaryQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param);
            internal static ExtTexObjectStateOverrideiQCOM glExtTexObjectStateOverrideiQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FeedbackBufferxOES(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer);
            internal unsafe static FeedbackBufferxOES glFeedbackBufferxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES11.All condition, UInt32 flags);
            internal static FenceSyncAPPLE glFenceSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRangeEXT glFlushMappedBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogf(OpenTK.Graphics.ES11.FogParameter pname, Single param);
            internal static Fogf glFogf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogfv(OpenTK.Graphics.ES11.FogParameter pname, Single* @params);
            internal unsafe static Fogfv glFogfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogx(OpenTK.Graphics.ES11.All pname, int param);
            internal static Fogx glFogx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static FogxOES glFogxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogxv(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static Fogxv glFogxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogxvOES(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static FogxvOES glFogxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbufferOES glFramebufferRenderbufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleEXT glFramebufferTexture2DMultisampleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleIMG glFramebufferTexture2DMultisampleIMG;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2DOES glFramebufferTexture2DOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustumf(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static Frustumf glFrustumf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrustumfOES(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static FrustumfOES glFrustumfOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustumx(int l, int r, int b, int t, int n, int f);
            internal static Frustumx glFrustumx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrustumxOES(int l, int r, int b, int t, int n, int f);
            internal static FrustumxOES glFrustumxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmapOES(OpenTK.Graphics.ES11.All target);
            internal static GenerateMipmapOES glGenerateMipmapOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffersOES(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffersOES glGenFramebuffersOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffersOES(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffersOES glGenRenderbuffersOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysOES glGenVertexArraysOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointervOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervOES glGetBufferPointervOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlanef(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
            internal unsafe static GetClipPlanef glGetClipPlanef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlanefOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
            internal unsafe static GetClipPlanefOES glGetClipPlanefOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
            internal unsafe static GetClipPlanex glGetClipPlanex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlanexOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
            internal unsafe static GetClipPlanexOES glGetClipPlanexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetConvolutionParameterxvOES glGetConvolutionParameterxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            internal unsafe static GetDriverControlsQCOM glGetDriverControlsQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            internal unsafe static GetDriverControlStringQCOM glGetDriverControlStringQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES11.ErrorCode GetError();
            internal static GetError glGetError;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFixedv(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetFixedv glGetFixedv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFixedvOES(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetFixedvOES glGetFixedvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameterivOES glGetFramebufferAttachmentParameterivOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES11.All GetGraphicsResetStatusEXT();
            internal static GetGraphicsResetStatusEXT glGetGraphicsResetStatusEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetHistogramParameterxvOES glGetHistogramParameterxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64vAPPLE(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64vAPPLE glGetInteger64vAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetLightfv glGetLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxOES glGetLightxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxv glGetLightxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxvOES glGetLightxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v);
            internal unsafe static GetMapxvOES glGetMapxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static GetMaterialxOES glGetMaterialxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetMaterialxv glGetMaterialxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetMaterialxvOES glGetMaterialxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvEXT glGetnUniformfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivEXT glGetnUniformivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapxv(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values);
            internal unsafe static GetPixelMapxv glGetPixelMapxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerv(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameterivOES glGetRenderbufferParameterivOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(OpenTK.Graphics.ES11.StringName name);
            internal static GetString glGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSyncivAPPLE glGetSyncivAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexEnvxv glGetTexEnvxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexEnvxvOES glGetTexEnvxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexGenfvOES glGetTexGenfvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexGenivOES glGetTexGenivOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexGenxvOES glGetTexGenxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameterxvOES(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexLevelParameterxvOES glGetTexLevelParameterxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexParameterxv glGetTexParameterxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexParameterxvOES glGetTexParameterxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode);
            internal static Hint glHint;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexxOES(int component);
            internal static IndexxOES glIndexxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void IndexxvOES(int* component);
            internal unsafe static IndexxvOES glIndexxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebufferOES(UInt32 framebuffer);
            internal static IsFramebufferOES glIsFramebufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbufferOES(UInt32 renderbuffer);
            internal static IsRenderbufferOES glIsRenderbufferOES;
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
            internal delegate void Lightf(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param);
            internal static Lightf glLightf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params);
            internal unsafe static Lightfv glLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelf(OpenTK.Graphics.ES11.LightModelParameter pname, Single param);
            internal static LightModelf glLightModelf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelfv(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params);
            internal unsafe static LightModelfv glLightModelfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelx(OpenTK.Graphics.ES11.All pname, int param);
            internal static LightModelx glLightModelx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static LightModelxOES glLightModelxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelxv(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static LightModelxv glLightModelxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelxvOES(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static LightModelxvOES glLightModelxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
            internal static Lightx glLightx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
            internal static LightxOES glLightxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static Lightxv glLightxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static LightxvOES glLightxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidthx(int width);
            internal static LineWidthx glLineWidthx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidthxOES(int width);
            internal static LineWidthxOES glLineWidthxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixf(Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixx(int* m);
            internal unsafe static LoadMatrixx glLoadMatrixx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixxOES(int* m);
            internal unsafe static LoadMatrixxOES glLoadMatrixxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadPaletteFromModelViewMatrixOES();
            internal static LoadPaletteFromModelViewMatrixOES glLoadPaletteFromModelViewMatrixOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixxOES(int* m);
            internal unsafe static LoadTransposeMatrixxOES glLoadTransposeMatrixxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode);
            internal static LogicOp glLogicOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Map1xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points);
            internal static Map1xOES glMap1xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Map2xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points);
            internal static Map2xOES glMap2xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access);
            internal static MapBufferOES glMapBufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access);
            internal static MapBufferRangeEXT glMapBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1xOES(Int32 n, int u1, int u2);
            internal static MapGrid1xOES glMapGrid1xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2xOES(Int32 n, int u1, int u2, int v1, int v2);
            internal static MapGrid2xOES glMapGrid2xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialf(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param);
            internal static Materialf glMaterialf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params);
            internal unsafe static Materialfv glMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static Materialx glMaterialx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static MaterialxOES glMaterialxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static Materialxv glMaterialxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static MaterialxvOES glMaterialxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixIndexPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static MatrixIndexPointerOES glMatrixIndexPointerOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode);
            internal static MatrixMode glMatrixMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArraysEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1bOES(OpenTK.Graphics.ES11.All texture, SByte s);
            internal static MultiTexCoord1bOES glMultiTexCoord1bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord1bvOES glMultiTexCoord1bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1xOES(OpenTK.Graphics.ES11.All texture, int s);
            internal static MultiTexCoord1xOES glMultiTexCoord1xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord1xvOES glMultiTexCoord1xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t);
            internal static MultiTexCoord2bOES glMultiTexCoord2bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord2bvOES glMultiTexCoord2bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2xOES(OpenTK.Graphics.ES11.All texture, int s, int t);
            internal static MultiTexCoord2xOES glMultiTexCoord2xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord2xvOES glMultiTexCoord2xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r);
            internal static MultiTexCoord3bOES glMultiTexCoord3bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord3bvOES glMultiTexCoord3bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r);
            internal static MultiTexCoord3xOES glMultiTexCoord3xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord3xvOES glMultiTexCoord3xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q);
            internal static MultiTexCoord4bOES glMultiTexCoord4bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord4bvOES glMultiTexCoord4bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4f(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
            internal static MultiTexCoord4x glMultiTexCoord4x;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
            internal static MultiTexCoord4xOES glMultiTexCoord4xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord4xvOES glMultiTexCoord4xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixf(Single* m);
            internal unsafe static MultMatrixf glMultMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixx(int* m);
            internal unsafe static MultMatrixx glMultMatrixx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixxOES(int* m);
            internal unsafe static MultMatrixxOES glMultMatrixxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixxOES(int* m);
            internal unsafe static MultTransposeMatrixxOES glMultTransposeMatrixxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3f(Single nx, Single ny, Single nz);
            internal static Normal3f glNormal3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3x(int nx, int ny, int nz);
            internal static Normal3x glNormal3x;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3xOES(int nx, int ny, int nz);
            internal static Normal3xOES glNormal3xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3xvOES(int* coords);
            internal unsafe static Normal3xvOES glNormal3xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer);
            internal static NormalPointer glNormalPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Orthof(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static Orthof glOrthof;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void OrthofOES(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static OrthofOES glOrthofOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Orthox(int l, int r, int b, int t, int n, int f);
            internal static Orthox glOrthox;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void OrthoxOES(int l, int r, int b, int t, int n, int f);
            internal static OrthoxOES glOrthoxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PassThroughxOES(int token);
            internal static PassThroughxOES glPassThroughxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values);
            internal unsafe static PixelMapx glPixelMapx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorex(OpenTK.Graphics.ES11.All pname, int param);
            internal static PixelStorex glPixelStorex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static PixelTransferxOES glPixelTransferxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelZoomxOES(int xfactor, int yfactor);
            internal static PixelZoomxOES glPixelZoomxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterf(OpenTK.Graphics.ES11.All pname, Single param);
            internal static PointParameterf glPointParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfv(OpenTK.Graphics.ES11.All pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterx(OpenTK.Graphics.ES11.All pname, int param);
            internal static PointParameterx glPointParameterx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static PointParameterxOES glPointParameterxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterxv(OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static PointParameterxv glPointParameterxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterxvOES(OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static PointParameterxvOES glPointParameterxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSizePointerOES(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static PointSizePointerOES glPointSizePointerOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSizex(int size);
            internal static PointSizex glPointSizex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSizexOES(int size);
            internal static PointSizexOES glPointSizexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffsetx(int factor, int units);
            internal static PolygonOffsetx glPolygonOffsetx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffsetxOES(int factor, int units);
            internal static PolygonOffsetxOES glPolygonOffsetxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTexturesxOES(Int32 n, UInt32* textures, int* priorities);
            internal unsafe static PrioritizeTexturesxOES glPrioritizeTexturesxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 QueryMatrixxOES([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent);
            internal unsafe static QueryMatrixxOES glQueryMatrixxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2xOES(int x, int y);
            internal static RasterPos2xOES glRasterPos2xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2xvOES(int* coords);
            internal unsafe static RasterPos2xvOES glRasterPos2xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3xOES(int x, int y, int z);
            internal static RasterPos3xOES glRasterPos3xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3xvOES(int* coords);
            internal unsafe static RasterPos3xvOES glRasterPos3xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4xOES(int x, int y, int z, int w);
            internal static RasterPos4xOES glRasterPos4xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4xvOES(int* coords);
            internal unsafe static RasterPos4xvOES glRasterPos4xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsEXT glReadnPixelsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RectxOES(int x1, int y1, int x2, int y2);
            internal static RectxOES glRectxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RectxvOES(int* v1, int* v2);
            internal unsafe static RectxvOES glRectxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleAPPLE glRenderbufferStorageMultisampleAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleIMG glRenderbufferStorageMultisampleIMG;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageOES glRenderbufferStorageOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResolveMultisampleFramebufferAPPLE();
            internal static ResolveMultisampleFramebufferAPPLE glResolveMultisampleFramebufferAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
            internal static Rotatef glRotatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatex(int angle, int x, int y, int z);
            internal static Rotatex glRotatex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RotatexOES(int angle, int x, int y, int z);
            internal static RotatexOES glRotatexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverageOES(int value, bool invert);
            internal static SampleCoverageOES glSampleCoverageOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoveragex(int value, bool invert);
            internal static SampleCoveragex glSampleCoveragex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoveragexOES(int value, bool invert);
            internal static SampleCoveragexOES glSampleCoveragexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalef(Single x, Single y, Single z);
            internal static Scalef glScalef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalex(int x, int y, int z);
            internal static Scalex glScalex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ScalexOES(int x, int y, int z);
            internal static ScalexOES glScalexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES11.All condition);
            internal static SetFenceNV glSetFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode);
            internal static ShadeModel glShadeModel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            internal static StartTilingQCOM glStartTilingQCOM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1bOES(SByte s);
            internal static TexCoord1bOES glTexCoord1bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1bvOES(SByte* coords);
            internal unsafe static TexCoord1bvOES glTexCoord1bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1xOES(int s);
            internal static TexCoord1xOES glTexCoord1xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1xvOES(int* coords);
            internal unsafe static TexCoord1xvOES glTexCoord1xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2bOES(SByte s, SByte t);
            internal static TexCoord2bOES glTexCoord2bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2bvOES(SByte* coords);
            internal unsafe static TexCoord2bvOES glTexCoord2bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2xOES(int s, int t);
            internal static TexCoord2xOES glTexCoord2xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2xvOES(int* coords);
            internal unsafe static TexCoord2xvOES glTexCoord2xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3bOES(SByte s, SByte t, SByte r);
            internal static TexCoord3bOES glTexCoord3bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3bvOES(SByte* coords);
            internal unsafe static TexCoord3bvOES glTexCoord3bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3xOES(int s, int t, int r);
            internal static TexCoord3xOES glTexCoord3xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3xvOES(int* coords);
            internal unsafe static TexCoord3xvOES glTexCoord3xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4bOES(SByte s, SByte t, SByte r, SByte q);
            internal static TexCoord4bOES glTexCoord4bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4bvOES(SByte* coords);
            internal unsafe static TexCoord4bvOES glTexCoord4bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4xOES(int s, int t, int r, int q);
            internal static TexCoord4xOES glTexCoord4xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4xvOES(int* coords);
            internal unsafe static TexCoord4xvOES glTexCoord4xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            internal static TexCoordPointer glTexCoordPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvf(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param);
            internal static TexEnvf glTexEnvf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvi(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param);
            internal static TexEnvi glTexEnvi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params);
            internal unsafe static TexEnviv glTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexEnvx glTexEnvx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexEnvxOES glTexEnvxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexEnvxv glTexEnvxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexEnvxvOES glTexEnvxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGenfOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param);
            internal static TexGenfOES glTexGenfOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params);
            internal unsafe static TexGenfvOES glTexGenfvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGeniOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param);
            internal static TexGeniOES glTexGeniOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params);
            internal unsafe static TexGenivOES glTexGenivOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGenxOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexGenxOES glTexGenxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexGenxvOES glTexGenxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexParameterx glTexParameterx;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexParameterxOES glTexParameterxOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexParameterxv glTexParameterxv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexParameterxvOES glTexParameterxvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage1DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
            internal static TexStorage1DEXT glTexStorage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage2DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static TexStorage2DEXT glTexStorage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexStorage3DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3DEXT glTexStorage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
            internal static TextureStorage1DEXT glTextureStorage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static TextureStorage2DEXT glTextureStorage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TextureStorage3DEXT glTextureStorage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatef(Single x, Single y, Single z);
            internal static Translatef glTranslatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatex(int x, int y, int z);
            internal static Translatex glTranslatex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TranslatexOES(int x, int y, int z);
            internal static TranslatexOES glTranslatexOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBufferOES(OpenTK.Graphics.ES11.All target);
            internal static UnmapBufferOES glUnmapBufferOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2bOES(SByte x);
            internal static Vertex2bOES glVertex2bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2bvOES(SByte* coords);
            internal unsafe static Vertex2bvOES glVertex2bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2xOES(int x);
            internal static Vertex2xOES glVertex2xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2xvOES(int* coords);
            internal unsafe static Vertex2xvOES glVertex2xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3bOES(SByte x, SByte y);
            internal static Vertex3bOES glVertex3bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3bvOES(SByte* coords);
            internal unsafe static Vertex3bvOES glVertex3bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3xOES(int x, int y);
            internal static Vertex3xOES glVertex3xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3xvOES(int* coords);
            internal unsafe static Vertex3xvOES glVertex3xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4bOES(SByte x, SByte y, SByte z);
            internal static Vertex4bOES glVertex4bOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4bvOES(SByte* coords);
            internal unsafe static Vertex4bvOES glVertex4bvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4xOES(int x, int y, int z);
            internal static Vertex4xOES glVertex4xOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4xvOES(int* coords);
            internal unsafe static Vertex4xvOES glVertex4xvOES;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer);
            internal static VertexPointer glVertexPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static WaitSyncAPPLE glWaitSyncAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WeightPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static WeightPointerOES glWeightPointerOES;
        }
    }
}
