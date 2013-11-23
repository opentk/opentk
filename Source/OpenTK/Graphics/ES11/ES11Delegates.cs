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
    using System.Security;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL
    {
        internal static partial class Delegates
        {
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AccumxOES(OpenTK.Graphics.ES11.All op, int value);
            internal static AccumxOES glAccumxOES = Load_AccumxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
            internal static ActiveTexture glActiveTexture = Load_ActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref);
            internal static AlphaFunc glAlphaFunc = Load_AlphaFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref);
            internal static AlphaFuncx glAlphaFuncx = Load_AlphaFuncx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFuncxOES(OpenTK.Graphics.ES11.All func, int @ref);
            internal static AlphaFuncxOES glAlphaFuncxOES = Load_AlphaFuncxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer);
            internal static BindBuffer glBindBuffer = Load_BindBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFramebufferOES(OpenTK.Graphics.ES11.All target, UInt32 framebuffer);
            internal static BindFramebufferOES glBindFramebufferOES = Load_BindFramebufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindRenderbufferOES(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer);
            internal static BindRenderbufferOES glBindRenderbufferOES = Load_BindRenderbufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture = Load_BindTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexArrayOES(UInt32 array);
            internal static BindVertexArrayOES glBindVertexArrayOES = Load_BindVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BitmapxOES(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap);
            internal unsafe static BitmapxOES glBitmapxOES = Load_BitmapxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendColorxOES(int red, int green, int blue, int alpha);
            internal static BlendColorxOES glBlendColorxOES = Load_BlendColorxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationEXT(OpenTK.Graphics.ES11.All mode);
            internal static BlendEquationEXT glBlendEquationEXT = Load_BlendEquationEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationOES(OpenTK.Graphics.ES11.All mode);
            internal static BlendEquationOES glBlendEquationOES = Load_BlendEquationOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparateOES(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha);
            internal static BlendEquationSeparateOES glBlendEquationSeparateOES = Load_BlendEquationSeparateOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc = Load_BlendFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparateOES(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha);
            internal static BlendFuncSeparateOES glBlendFuncSeparateOES = Load_BlendFuncSeparateOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage);
            internal static BufferData glBufferData = Load_BufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData = Load_BufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.All CheckFramebufferStatusOES(OpenTK.Graphics.ES11.All target);
            internal static CheckFramebufferStatusOES glCheckFramebufferStatusOES = Load_CheckFramebufferStatusOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask);
            internal static Clear glClear = Load_Clear;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearAccumxOES(int red, int green, int blue, int alpha);
            internal static ClearAccumxOES glClearAccumxOES = Load_ClearAccumxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor = Load_ClearColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColorx(int red, int green, int blue, int alpha);
            internal static ClearColorx glClearColorx = Load_ClearColorx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColorxOES(int red, int green, int blue, int alpha);
            internal static ClearColorxOES glClearColorxOES = Load_ClearColorxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf = Load_ClearDepthf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthfOES(Single depth);
            internal static ClearDepthfOES glClearDepthfOES = Load_ClearDepthfOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthx(int depth);
            internal static ClearDepthx glClearDepthx = Load_ClearDepthx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthxOES(int depth);
            internal static ClearDepthxOES glClearDepthxOES = Load_ClearDepthxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil = Load_ClearStencil;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
            internal static ClientActiveTexture glClientActiveTexture = Load_ClientActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.All ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static ClientWaitSyncAPPLE glClientWaitSyncAPPLE = Load_ClientWaitSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanef(OpenTK.Graphics.ES11.All p, Single* eqn);
            internal unsafe static ClipPlanef glClipPlanef = Load_ClipPlanef;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanefIMG(OpenTK.Graphics.ES11.All p, Single* eqn);
            internal unsafe static ClipPlanefIMG glClipPlanefIMG = Load_ClipPlanefIMG;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanefOES(OpenTK.Graphics.ES11.All plane, Single* equation);
            internal unsafe static ClipPlanefOES glClipPlanefOES = Load_ClipPlanefOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation);
            internal unsafe static ClipPlanex glClipPlanex = Load_ClipPlanex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanexIMG(OpenTK.Graphics.ES11.All p, int* eqn);
            internal unsafe static ClipPlanexIMG glClipPlanexIMG = Load_ClipPlanexIMG;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanexOES(OpenTK.Graphics.ES11.All plane, int* equation);
            internal unsafe static ClipPlanexOES glClipPlanexOES = Load_ClipPlanexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color3xOES(int red, int green, int blue);
            internal static Color3xOES glColor3xOES = Load_Color3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Color3xvOES(int* components);
            internal unsafe static Color3xvOES glColor3xvOES = Load_Color3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
            internal static Color4f glColor4f = Load_Color4f;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            internal static Color4ub glColor4ub = Load_Color4ub;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4x(int red, int green, int blue, int alpha);
            internal static Color4x glColor4x = Load_Color4x;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4xOES(int red, int green, int blue, int alpha);
            internal static Color4xOES glColor4xOES = Load_Color4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Color4xvOES(int* components);
            internal unsafe static Color4xvOES glColor4xvOES = Load_Color4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask = Load_ColorMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer);
            internal static ColorPointer glColorPointer = Load_ColorPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D = Load_CompressedTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D = Load_CompressedTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static ConvolutionParameterxOES glConvolutionParameterxOES = Load_ConvolutionParameterxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static ConvolutionParameterxvOES glConvolutionParameterxvOES = Load_ConvolutionParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D = Load_CopyTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D = Load_CopyTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            internal static CopyTextureLevelsAPPLE glCopyTextureLevelsAPPLE = Load_CopyTextureLevelsAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode);
            internal static CullFace glCullFace = Load_CullFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex);
            internal static CurrentPaletteMatrixOES glCurrentPaletteMatrixOES = Load_CurrentPaletteMatrixOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers = Load_DeleteBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV = Load_DeleteFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFramebuffersOES(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffersOES glDeleteFramebuffersOES = Load_DeleteFramebuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffersOES glDeleteRenderbuffersOES = Load_DeleteRenderbuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteSyncAPPLE(IntPtr sync);
            internal static DeleteSyncAPPLE glDeleteSyncAPPLE = Load_DeleteSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures = Load_DeleteTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteVertexArraysOES(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysOES glDeleteVertexArraysOES = Load_DeleteVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func);
            internal static DepthFunc glDepthFunc = Load_DepthFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask = Load_DepthMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef = Load_DepthRangef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangefOES(Single n, Single f);
            internal static DepthRangefOES glDepthRangefOES = Load_DepthRangefOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangex(int n, int f);
            internal static DepthRangex glDepthRangex = Load_DepthRangex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangexOES(int n, int f);
            internal static DepthRangexOES glDepthRangexOES = Load_DepthRangexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disable(OpenTK.Graphics.ES11.EnableCap cap);
            internal static Disable glDisable = Load_Disable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableClientState(OpenTK.Graphics.ES11.EnableCap array);
            internal static DisableClientState glDisableClientState = Load_DisableClientState;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableDriverControlQCOM(UInt32 driverControl);
            internal static DisableDriverControlQCOM glDisableDriverControlQCOM = Load_DisableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DiscardFramebufferEXT(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments);
            internal unsafe static DiscardFramebufferEXT glDiscardFramebufferEXT = Load_DiscardFramebufferEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays = Load_DrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices);
            internal static DrawElements glDrawElements = Load_DrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexfOES(Single x, Single y, Single z, Single width, Single height);
            internal static DrawTexfOES glDrawTexfOES = Load_DrawTexfOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexfvOES(Single* coords);
            internal unsafe static DrawTexfvOES glDrawTexfvOES = Load_DrawTexfvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);
            internal static DrawTexiOES glDrawTexiOES = Load_DrawTexiOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexivOES(Int32* coords);
            internal unsafe static DrawTexivOES glDrawTexivOES = Load_DrawTexivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);
            internal static DrawTexsOES glDrawTexsOES = Load_DrawTexsOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexsvOES(Int16* coords);
            internal unsafe static DrawTexsvOES glDrawTexsvOES = Load_DrawTexsvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexxOES(int x, int y, int z, int width, int height);
            internal static DrawTexxOES glDrawTexxOES = Load_DrawTexxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexxvOES(int* coords);
            internal unsafe static DrawTexxvOES glDrawTexxvOES = Load_DrawTexxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES11.All target, IntPtr image);
            internal static EGLImageTargetRenderbufferStorageOES glEGLImageTargetRenderbufferStorageOES = Load_EGLImageTargetRenderbufferStorageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES11.All target, IntPtr image);
            internal static EGLImageTargetTexture2DOES glEGLImageTargetTexture2DOES = Load_EGLImageTargetTexture2DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enable(OpenTK.Graphics.ES11.EnableCap cap);
            internal static Enable glEnable = Load_Enable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableClientState(OpenTK.Graphics.ES11.EnableCap array);
            internal static EnableClientState glEnableClientState = Load_EnableClientState;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableDriverControlQCOM(UInt32 driverControl);
            internal static EnableDriverControlQCOM glEnableDriverControlQCOM = Load_EnableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndTilingQCOM(UInt32 preserveMask);
            internal static EndTilingQCOM glEndTilingQCOM = Load_EndTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EvalCoord1xOES(int u);
            internal static EvalCoord1xOES glEvalCoord1xOES = Load_EvalCoord1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void EvalCoord1xvOES(int* coords);
            internal unsafe static EvalCoord1xvOES glEvalCoord1xvOES = Load_EvalCoord1xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EvalCoord2xOES(int u, int v);
            internal static EvalCoord2xOES glEvalCoord2xOES = Load_EvalCoord2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void EvalCoord2xvOES(int* coords);
            internal unsafe static EvalCoord2xvOES glEvalCoord2xvOES = Load_EvalCoord2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params);
            internal static ExtGetBufferPointervQCOM glExtGetBufferPointervQCOM = Load_ExtGetBufferPointervQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            internal unsafe static ExtGetBuffersQCOM glExtGetBuffersQCOM = Load_ExtGetBuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            internal unsafe static ExtGetFramebuffersQCOM glExtGetFramebuffersQCOM = Load_ExtGetFramebuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
            internal unsafe static ExtGetProgramBinarySourceQCOM glExtGetProgramBinarySourceQCOM = Load_ExtGetProgramBinarySourceQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
            internal unsafe static ExtGetProgramsQCOM glExtGetProgramsQCOM = Load_ExtGetProgramsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
            internal unsafe static ExtGetRenderbuffersQCOM glExtGetRenderbuffersQCOM = Load_ExtGetRenderbuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
            internal unsafe static ExtGetShadersQCOM glExtGetShadersQCOM = Load_ExtGetShadersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static ExtGetTexLevelParameterivQCOM glExtGetTexLevelParameterivQCOM = Load_ExtGetTexLevelParameterivQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels);
            internal static ExtGetTexSubImageQCOM glExtGetTexSubImageQCOM = Load_ExtGetTexSubImageQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            internal unsafe static ExtGetTexturesQCOM glExtGetTexturesQCOM = Load_ExtGetTexturesQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool ExtIsProgramBinaryQCOM(UInt32 program);
            internal static ExtIsProgramBinaryQCOM glExtIsProgramBinaryQCOM = Load_ExtIsProgramBinaryQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param);
            internal static ExtTexObjectStateOverrideiQCOM glExtTexObjectStateOverrideiQCOM = Load_ExtTexObjectStateOverrideiQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void FeedbackBufferxOES(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer);
            internal unsafe static FeedbackBufferxOES glFeedbackBufferxOES = Load_FeedbackBufferxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES11.All condition, UInt32 flags);
            internal static FenceSyncAPPLE glFenceSyncAPPLE = Load_FenceSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Finish();
            internal static Finish glFinish = Load_Finish;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV = Load_FinishFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Flush();
            internal static Flush glFlush = Load_Flush;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRangeEXT glFlushMappedBufferRangeEXT = Load_FlushMappedBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Fogf(OpenTK.Graphics.ES11.FogParameter pname, Single param);
            internal static Fogf glFogf = Load_Fogf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Fogfv(OpenTK.Graphics.ES11.FogParameter pname, Single* @params);
            internal unsafe static Fogfv glFogfv = Load_Fogfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Fogx(OpenTK.Graphics.ES11.All pname, int param);
            internal static Fogx glFogx = Load_Fogx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FogxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static FogxOES glFogxOES = Load_FogxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Fogxv(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static Fogxv glFogxv = Load_Fogxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void FogxvOES(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static FogxvOES glFogxvOES = Load_FogxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferRenderbufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbufferOES glFramebufferRenderbufferOES = Load_FramebufferRenderbufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleEXT glFramebufferTexture2DMultisampleEXT = Load_FramebufferTexture2DMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleIMG glFramebufferTexture2DMultisampleIMG = Load_FramebufferTexture2DMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2DOES glFramebufferTexture2DOES = Load_FramebufferTexture2DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode);
            internal static FrontFace glFrontFace = Load_FrontFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Frustumf(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static Frustumf glFrustumf = Load_Frustumf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrustumfOES(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static FrustumfOES glFrustumfOES = Load_FrustumfOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Frustumx(int l, int r, int b, int t, int n, int f);
            internal static Frustumx glFrustumx = Load_Frustumx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrustumxOES(int l, int r, int b, int t, int n, int f);
            internal static FrustumxOES glFrustumxOES = Load_FrustumxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers = Load_GenBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GenerateMipmapOES(OpenTK.Graphics.ES11.All target);
            internal static GenerateMipmapOES glGenerateMipmapOES = Load_GenerateMipmapOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV = Load_GenFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFramebuffersOES(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffersOES glGenFramebuffersOES = Load_GenFramebuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenRenderbuffersOES(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffersOES glGenRenderbuffersOES = Load_GenRenderbuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures = Load_GenTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysOES glGenVertexArraysOES = Load_GenVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv = Load_GetBooleanv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv = Load_GetBufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferPointervOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervOES glGetBufferPointervOES = Load_GetBufferPointervOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanef(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
            internal unsafe static GetClipPlanef glGetClipPlanef = Load_GetClipPlanef;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanefOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
            internal unsafe static GetClipPlanefOES glGetClipPlanefOES = Load_GetClipPlanefOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
            internal unsafe static GetClipPlanex glGetClipPlanex = Load_GetClipPlanex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanexOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
            internal unsafe static GetClipPlanexOES glGetClipPlanexOES = Load_GetClipPlanexOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetConvolutionParameterxvOES glGetConvolutionParameterxvOES = Load_GetConvolutionParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            internal unsafe static GetDriverControlsQCOM glGetDriverControlsQCOM = Load_GetDriverControlsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            internal unsafe static GetDriverControlStringQCOM glGetDriverControlStringQCOM = Load_GetDriverControlStringQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.ErrorCode GetError();
            internal static GetError glGetError = Load_GetError;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV = Load_GetFenceivNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFixedv(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetFixedv glGetFixedv = Load_GetFixedv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFixedvOES(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetFixedvOES glGetFixedvOES = Load_GetFixedvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv = Load_GetFloatv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferAttachmentParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameterivOES glGetFramebufferAttachmentParameterivOES = Load_GetFramebufferAttachmentParameterivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.All GetGraphicsResetStatusEXT();
            internal static GetGraphicsResetStatusEXT glGetGraphicsResetStatusEXT = Load_GetGraphicsResetStatusEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetHistogramParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetHistogramParameterxvOES glGetHistogramParameterxvOES = Load_GetHistogramParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64vAPPLE(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64vAPPLE glGetInteger64vAPPLE = Load_GetInteger64vAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv = Load_GetIntegerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetLightfv glGetLightfv = Load_GetLightfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxOES glGetLightxOES = Load_GetLightxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxv glGetLightxv = Load_GetLightxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxvOES glGetLightxvOES = Load_GetLightxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMapxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v);
            internal unsafe static GetMapxvOES glGetMapxvOES = Load_GetMapxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMaterialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv = Load_GetMaterialfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetMaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static GetMaterialxOES glGetMaterialxOES = Load_GetMaterialxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMaterialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetMaterialxv glGetMaterialxv = Load_GetMaterialxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetMaterialxvOES glGetMaterialxvOES = Load_GetMaterialxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvEXT glGetnUniformfvEXT = Load_GetnUniformfvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivEXT glGetnUniformivEXT = Load_GetnUniformivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPixelMapxv(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values);
            internal unsafe static GetPixelMapxv glGetPixelMapxv = Load_GetPixelMapxv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointerv(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv = Load_GetPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetRenderbufferParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameterivOES glGetRenderbufferParameterivOES = Load_GetRenderbufferParameterivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetString(OpenTK.Graphics.ES11.StringName name);
            internal static GetString glGetString = Load_GetString;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSyncivAPPLE glGetSyncivAPPLE = Load_GetSyncivAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv = Load_GetTexEnvfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv = Load_GetTexEnviv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexEnvxv glGetTexEnvxv = Load_GetTexEnvxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexEnvxvOES glGetTexEnvxvOES = Load_GetTexEnvxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexGenfvOES glGetTexGenfvOES = Load_GetTexGenfvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexGenivOES glGetTexGenivOES = Load_GetTexGenivOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexGenxvOES glGetTexGenxvOES = Load_GetTexGenxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexLevelParameterxvOES(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexLevelParameterxvOES glGetTexLevelParameterxvOES = Load_GetTexLevelParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv = Load_GetTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv = Load_GetTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexParameterxv glGetTexParameterxv = Load_GetTexParameterxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexParameterxvOES glGetTexParameterxvOES = Load_GetTexParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode);
            internal static Hint glHint = Load_Hint;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void IndexxOES(int component);
            internal static IndexxOES glIndexxOES = Load_IndexxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void IndexxvOES(int* component);
            internal unsafe static IndexxvOES glIndexxvOES = Load_IndexxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer = Load_IsBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap);
            internal static IsEnabled glIsEnabled = Load_IsEnabled;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV = Load_IsFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFramebufferOES(UInt32 framebuffer);
            internal static IsFramebufferOES glIsFramebufferOES = Load_IsFramebufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsRenderbufferOES(UInt32 renderbuffer);
            internal static IsRenderbufferOES glIsRenderbufferOES = Load_IsRenderbufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSyncAPPLE(IntPtr sync);
            internal static IsSyncAPPLE glIsSyncAPPLE = Load_IsSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture = Load_IsTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsVertexArrayOES(UInt32 array);
            internal static IsVertexArrayOES glIsVertexArrayOES = Load_IsVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Lightf(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param);
            internal static Lightf glLightf = Load_Lightf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Lightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params);
            internal unsafe static Lightfv glLightfv = Load_Lightfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightModelf(OpenTK.Graphics.ES11.LightModelParameter pname, Single param);
            internal static LightModelf glLightModelf = Load_LightModelf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightModelfv(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params);
            internal unsafe static LightModelfv glLightModelfv = Load_LightModelfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightModelx(OpenTK.Graphics.ES11.All pname, int param);
            internal static LightModelx glLightModelx = Load_LightModelx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightModelxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static LightModelxOES glLightModelxOES = Load_LightModelxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightModelxv(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static LightModelxv glLightModelxv = Load_LightModelxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightModelxvOES(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static LightModelxvOES glLightModelxvOES = Load_LightModelxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
            internal static Lightx glLightx = Load_Lightx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
            internal static LightxOES glLightxOES = Load_LightxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Lightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static Lightxv glLightxv = Load_Lightxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static LightxvOES glLightxvOES = Load_LightxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth = Load_LineWidth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidthx(int width);
            internal static LineWidthx glLineWidthx = Load_LineWidthx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidthxOES(int width);
            internal static LineWidthxOES glLineWidthxOES = Load_LineWidthxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity = Load_LoadIdentity;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadMatrixf(Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf = Load_LoadMatrixf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadMatrixx(int* m);
            internal unsafe static LoadMatrixx glLoadMatrixx = Load_LoadMatrixx;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadMatrixxOES(int* m);
            internal unsafe static LoadMatrixxOES glLoadMatrixxOES = Load_LoadMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LoadPaletteFromModelViewMatrixOES();
            internal static LoadPaletteFromModelViewMatrixOES glLoadPaletteFromModelViewMatrixOES = Load_LoadPaletteFromModelViewMatrixOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadTransposeMatrixxOES(int* m);
            internal unsafe static LoadTransposeMatrixxOES glLoadTransposeMatrixxOES = Load_LoadTransposeMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode);
            internal static LogicOp glLogicOp = Load_LogicOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Map1xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points);
            internal static Map1xOES glMap1xOES = Load_Map1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Map2xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points);
            internal static Map2xOES glMap2xOES = Load_Map2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access);
            internal static MapBufferOES glMapBufferOES = Load_MapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access);
            internal static MapBufferRangeEXT glMapBufferRangeEXT = Load_MapBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MapGrid1xOES(Int32 n, int u1, int u2);
            internal static MapGrid1xOES glMapGrid1xOES = Load_MapGrid1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MapGrid2xOES(Int32 n, int u1, int u2, int v1, int v2);
            internal static MapGrid2xOES glMapGrid2xOES = Load_MapGrid2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Materialf(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param);
            internal static Materialf glMaterialf = Load_Materialf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Materialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params);
            internal unsafe static Materialfv glMaterialfv = Load_Materialfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static Materialx glMaterialx = Load_Materialx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static MaterialxOES glMaterialxOES = Load_MaterialxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Materialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static Materialxv glMaterialxv = Load_Materialxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static MaterialxvOES glMaterialxvOES = Load_MaterialxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MatrixIndexPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static MatrixIndexPointerOES glMatrixIndexPointerOES = Load_MatrixIndexPointerOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode);
            internal static MatrixMode glMatrixMode = Load_MatrixMode;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawArraysEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT = Load_MultiDrawArraysEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElementsEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT = Load_MultiDrawElementsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord1bOES(OpenTK.Graphics.ES11.All texture, SByte s);
            internal static MultiTexCoord1bOES glMultiTexCoord1bOES = Load_MultiTexCoord1bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord1bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord1bvOES glMultiTexCoord1bvOES = Load_MultiTexCoord1bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord1xOES(OpenTK.Graphics.ES11.All texture, int s);
            internal static MultiTexCoord1xOES glMultiTexCoord1xOES = Load_MultiTexCoord1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord1xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord1xvOES glMultiTexCoord1xvOES = Load_MultiTexCoord1xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord2bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t);
            internal static MultiTexCoord2bOES glMultiTexCoord2bOES = Load_MultiTexCoord2bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord2bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord2bvOES glMultiTexCoord2bvOES = Load_MultiTexCoord2bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord2xOES(OpenTK.Graphics.ES11.All texture, int s, int t);
            internal static MultiTexCoord2xOES glMultiTexCoord2xOES = Load_MultiTexCoord2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord2xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord2xvOES glMultiTexCoord2xvOES = Load_MultiTexCoord2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord3bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r);
            internal static MultiTexCoord3bOES glMultiTexCoord3bOES = Load_MultiTexCoord3bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord3bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord3bvOES glMultiTexCoord3bvOES = Load_MultiTexCoord3bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord3xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r);
            internal static MultiTexCoord3xOES glMultiTexCoord3xOES = Load_MultiTexCoord3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord3xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord3xvOES glMultiTexCoord3xvOES = Load_MultiTexCoord3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q);
            internal static MultiTexCoord4bOES glMultiTexCoord4bOES = Load_MultiTexCoord4bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord4bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord4bvOES glMultiTexCoord4bvOES = Load_MultiTexCoord4bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4f(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f = Load_MultiTexCoord4f;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
            internal static MultiTexCoord4x glMultiTexCoord4x = Load_MultiTexCoord4x;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
            internal static MultiTexCoord4xOES glMultiTexCoord4xOES = Load_MultiTexCoord4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord4xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord4xvOES glMultiTexCoord4xvOES = Load_MultiTexCoord4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultMatrixf(Single* m);
            internal unsafe static MultMatrixf glMultMatrixf = Load_MultMatrixf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultMatrixx(int* m);
            internal unsafe static MultMatrixx glMultMatrixx = Load_MultMatrixx;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultMatrixxOES(int* m);
            internal unsafe static MultMatrixxOES glMultMatrixxOES = Load_MultMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultTransposeMatrixxOES(int* m);
            internal unsafe static MultTransposeMatrixxOES glMultTransposeMatrixxOES = Load_MultTransposeMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Normal3f(Single nx, Single ny, Single nz);
            internal static Normal3f glNormal3f = Load_Normal3f;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Normal3x(int nx, int ny, int nz);
            internal static Normal3x glNormal3x = Load_Normal3x;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Normal3xOES(int nx, int ny, int nz);
            internal static Normal3xOES glNormal3xOES = Load_Normal3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Normal3xvOES(int* coords);
            internal unsafe static Normal3xvOES glNormal3xvOES = Load_Normal3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer);
            internal static NormalPointer glNormalPointer = Load_NormalPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Orthof(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static Orthof glOrthof = Load_Orthof;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void OrthofOES(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static OrthofOES glOrthofOES = Load_OrthofOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Orthox(int l, int r, int b, int t, int n, int f);
            internal static Orthox glOrthox = Load_Orthox;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void OrthoxOES(int l, int r, int b, int t, int n, int f);
            internal static OrthoxOES glOrthoxOES = Load_OrthoxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PassThroughxOES(int token);
            internal static PassThroughxOES glPassThroughxOES = Load_PassThroughxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values);
            internal unsafe static PixelMapx glPixelMapx = Load_PixelMapx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorei(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei = Load_PixelStorei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorex(OpenTK.Graphics.ES11.All pname, int param);
            internal static PixelStorex glPixelStorex = Load_PixelStorex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelTransferxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static PixelTransferxOES glPixelTransferxOES = Load_PixelTransferxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelZoomxOES(int xfactor, int yfactor);
            internal static PixelZoomxOES glPixelZoomxOES = Load_PixelZoomxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterf(OpenTK.Graphics.ES11.All pname, Single param);
            internal static PointParameterf glPointParameterf = Load_PointParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterfv(OpenTK.Graphics.ES11.All pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv = Load_PointParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterx(OpenTK.Graphics.ES11.All pname, int param);
            internal static PointParameterx glPointParameterx = Load_PointParameterx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static PointParameterxOES glPointParameterxOES = Load_PointParameterxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterxv(OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static PointParameterxv glPointParameterxv = Load_PointParameterxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterxvOES(OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static PointParameterxvOES glPointParameterxvOES = Load_PointParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize = Load_PointSize;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSizePointerOES(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static PointSizePointerOES glPointSizePointerOES = Load_PointSizePointerOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSizex(int size);
            internal static PointSizex glPointSizex = Load_PointSizex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSizexOES(int size);
            internal static PointSizexOES glPointSizexOES = Load_PointSizexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset = Load_PolygonOffset;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffsetx(int factor, int units);
            internal static PolygonOffsetx glPolygonOffsetx = Load_PolygonOffsetx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffsetxOES(int factor, int units);
            internal static PolygonOffsetxOES glPolygonOffsetxOES = Load_PolygonOffsetxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix = Load_PopMatrix;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PrioritizeTexturesxOES(Int32 n, UInt32* textures, int* priorities);
            internal unsafe static PrioritizeTexturesxOES glPrioritizeTexturesxOES = Load_PrioritizeTexturesxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix = Load_PushMatrix;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 QueryMatrixxOES([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent);
            internal unsafe static QueryMatrixxOES glQueryMatrixxOES = Load_QueryMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RasterPos2xOES(int x, int y);
            internal static RasterPos2xOES glRasterPos2xOES = Load_RasterPos2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RasterPos2xvOES(int* coords);
            internal unsafe static RasterPos2xvOES glRasterPos2xvOES = Load_RasterPos2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RasterPos3xOES(int x, int y, int z);
            internal static RasterPos3xOES glRasterPos3xOES = Load_RasterPos3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RasterPos3xvOES(int* coords);
            internal unsafe static RasterPos3xvOES glRasterPos3xvOES = Load_RasterPos3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RasterPos4xOES(int x, int y, int z, int w);
            internal static RasterPos4xOES glRasterPos4xOES = Load_RasterPos4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RasterPos4xvOES(int* coords);
            internal unsafe static RasterPos4xvOES glRasterPos4xvOES = Load_RasterPos4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsEXT glReadnPixelsEXT = Load_ReadnPixelsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels = Load_ReadPixels;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RectxOES(int x1, int y1, int x2, int y2);
            internal static RectxOES glRectxOES = Load_RectxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RectxvOES(int* v1, int* v2);
            internal unsafe static RectxvOES glRectxvOES = Load_RectxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleAPPLE glRenderbufferStorageMultisampleAPPLE = Load_RenderbufferStorageMultisampleAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT = Load_RenderbufferStorageMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleIMG glRenderbufferStorageMultisampleIMG = Load_RenderbufferStorageMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageOES glRenderbufferStorageOES = Load_RenderbufferStorageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResolveMultisampleFramebufferAPPLE();
            internal static ResolveMultisampleFramebufferAPPLE glResolveMultisampleFramebufferAPPLE = Load_ResolveMultisampleFramebufferAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
            internal static Rotatef glRotatef = Load_Rotatef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Rotatex(int angle, int x, int y, int z);
            internal static Rotatex glRotatex = Load_Rotatex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RotatexOES(int angle, int x, int y, int z);
            internal static RotatexOES glRotatexOES = Load_RotatexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage = Load_SampleCoverage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverageOES(int value, bool invert);
            internal static SampleCoverageOES glSampleCoverageOES = Load_SampleCoverageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoveragex(int value, bool invert);
            internal static SampleCoveragex glSampleCoveragex = Load_SampleCoveragex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoveragexOES(int value, bool invert);
            internal static SampleCoveragexOES glSampleCoveragexOES = Load_SampleCoveragexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scalef(Single x, Single y, Single z);
            internal static Scalef glScalef = Load_Scalef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scalex(int x, int y, int z);
            internal static Scalex glScalex = Load_Scalex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ScalexOES(int x, int y, int z);
            internal static ScalexOES glScalexOES = Load_ScalexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor = Load_Scissor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES11.All condition);
            internal static SetFenceNV glSetFenceNV = Load_SetFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode);
            internal static ShadeModel glShadeModel = Load_ShadeModel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            internal static StartTilingQCOM glStartTilingQCOM = Load_StartTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc = Load_StencilFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask = Load_StencilMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass);
            internal static StencilOp glStencilOp = Load_StencilOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV = Load_TestFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord1bOES(SByte s);
            internal static TexCoord1bOES glTexCoord1bOES = Load_TexCoord1bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord1bvOES(SByte* coords);
            internal unsafe static TexCoord1bvOES glTexCoord1bvOES = Load_TexCoord1bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord1xOES(int s);
            internal static TexCoord1xOES glTexCoord1xOES = Load_TexCoord1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord1xvOES(int* coords);
            internal unsafe static TexCoord1xvOES glTexCoord1xvOES = Load_TexCoord1xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord2bOES(SByte s, SByte t);
            internal static TexCoord2bOES glTexCoord2bOES = Load_TexCoord2bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord2bvOES(SByte* coords);
            internal unsafe static TexCoord2bvOES glTexCoord2bvOES = Load_TexCoord2bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord2xOES(int s, int t);
            internal static TexCoord2xOES glTexCoord2xOES = Load_TexCoord2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord2xvOES(int* coords);
            internal unsafe static TexCoord2xvOES glTexCoord2xvOES = Load_TexCoord2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord3bOES(SByte s, SByte t, SByte r);
            internal static TexCoord3bOES glTexCoord3bOES = Load_TexCoord3bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord3bvOES(SByte* coords);
            internal unsafe static TexCoord3bvOES glTexCoord3bvOES = Load_TexCoord3bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord3xOES(int s, int t, int r);
            internal static TexCoord3xOES glTexCoord3xOES = Load_TexCoord3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord3xvOES(int* coords);
            internal unsafe static TexCoord3xvOES glTexCoord3xvOES = Load_TexCoord3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord4bOES(SByte s, SByte t, SByte r, SByte q);
            internal static TexCoord4bOES glTexCoord4bOES = Load_TexCoord4bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord4bvOES(SByte* coords);
            internal unsafe static TexCoord4bvOES glTexCoord4bvOES = Load_TexCoord4bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord4xOES(int s, int t, int r, int q);
            internal static TexCoord4xOES glTexCoord4xOES = Load_TexCoord4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord4xvOES(int* coords);
            internal unsafe static TexCoord4xvOES glTexCoord4xvOES = Load_TexCoord4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            internal static TexCoordPointer glTexCoordPointer = Load_TexCoordPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvf(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param);
            internal static TexEnvf glTexEnvf = Load_TexEnvf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv = Load_TexEnvfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvi(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param);
            internal static TexEnvi glTexEnvi = Load_TexEnvi;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params);
            internal unsafe static TexEnviv glTexEnviv = Load_TexEnviv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexEnvx glTexEnvx = Load_TexEnvx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexEnvxOES glTexEnvxOES = Load_TexEnvxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexEnvxv glTexEnvxv = Load_TexEnvxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexEnvxvOES glTexEnvxvOES = Load_TexEnvxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexGenfOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param);
            internal static TexGenfOES glTexGenfOES = Load_TexGenfOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params);
            internal unsafe static TexGenfvOES glTexGenfvOES = Load_TexGenfvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexGeniOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param);
            internal static TexGeniOES glTexGeniOES = Load_TexGeniOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params);
            internal unsafe static TexGenivOES glTexGenivOES = Load_TexGenivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexGenxOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexGenxOES glTexGenxOES = Load_TexGenxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexGenxvOES glTexGenxvOES = Load_TexGenxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D = Load_TexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterf(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf = Load_TexParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv = Load_TexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameteri(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri = Load_TexParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv = Load_TexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexParameterx glTexParameterx = Load_TexParameterx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexParameterxOES glTexParameterxOES = Load_TexParameterxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexParameterxv glTexParameterxv = Load_TexParameterxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexParameterxvOES glTexParameterxvOES = Load_TexParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage1DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
            internal static TexStorage1DEXT glTexStorage1DEXT = Load_TexStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static TexStorage2DEXT glTexStorage2DEXT = Load_TexStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3DEXT glTexStorage3DEXT = Load_TexStorage3DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D = Load_TexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
            internal static TextureStorage1DEXT glTextureStorage1DEXT = Load_TextureStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static TextureStorage2DEXT glTextureStorage2DEXT = Load_TextureStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TextureStorage3DEXT glTextureStorage3DEXT = Load_TextureStorage3DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Translatef(Single x, Single y, Single z);
            internal static Translatef glTranslatef = Load_Translatef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Translatex(int x, int y, int z);
            internal static Translatex glTranslatex = Load_Translatex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TranslatexOES(int x, int y, int z);
            internal static TranslatexOES glTranslatexOES = Load_TranslatexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool UnmapBufferOES(OpenTK.Graphics.ES11.All target);
            internal static UnmapBufferOES glUnmapBufferOES = Load_UnmapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex2bOES(SByte x);
            internal static Vertex2bOES glVertex2bOES = Load_Vertex2bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex2bvOES(SByte* coords);
            internal unsafe static Vertex2bvOES glVertex2bvOES = Load_Vertex2bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex2xOES(int x);
            internal static Vertex2xOES glVertex2xOES = Load_Vertex2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex2xvOES(int* coords);
            internal unsafe static Vertex2xvOES glVertex2xvOES = Load_Vertex2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex3bOES(SByte x, SByte y);
            internal static Vertex3bOES glVertex3bOES = Load_Vertex3bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex3bvOES(SByte* coords);
            internal unsafe static Vertex3bvOES glVertex3bvOES = Load_Vertex3bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex3xOES(int x, int y);
            internal static Vertex3xOES glVertex3xOES = Load_Vertex3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex3xvOES(int* coords);
            internal unsafe static Vertex3xvOES glVertex3xvOES = Load_Vertex3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex4bOES(SByte x, SByte y, SByte z);
            internal static Vertex4bOES glVertex4bOES = Load_Vertex4bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex4bvOES(SByte* coords);
            internal unsafe static Vertex4bvOES glVertex4bvOES = Load_Vertex4bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex4xOES(int x, int y, int z);
            internal static Vertex4xOES glVertex4xOES = Load_Vertex4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex4xvOES(int* coords);
            internal unsafe static Vertex4xvOES glVertex4xvOES = Load_Vertex4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer);
            internal static VertexPointer glVertexPointer = Load_VertexPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport = Load_Viewport;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static WaitSyncAPPLE glWaitSyncAPPLE = Load_WaitSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void WeightPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static WeightPointerOES glWeightPointerOES = Load_WeightPointerOES;
            internal static void Load_AccumxOES(OpenTK.Graphics.ES11.All op, int value)
            {
                Delegates.glAccumxOES = (Delegates.AccumxOES)GetExtensionDelegateStatic("glAccumxOES", typeof(Delegates.AccumxOES));
                Delegates.glAccumxOES((OpenTK.Graphics.ES11.All)op, (int)value);
            }
            internal static void Load_ActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture)
            {
                Delegates.glActiveTexture = (Delegates.ActiveTexture)GetExtensionDelegateStatic("glActiveTexture", typeof(Delegates.ActiveTexture));
                Delegates.glActiveTexture((OpenTK.Graphics.ES11.TextureUnit)texture);
            }
            internal static void Load_AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref)
            {
                Delegates.glAlphaFunc = (Delegates.AlphaFunc)GetExtensionDelegateStatic("glAlphaFunc", typeof(Delegates.AlphaFunc));
                Delegates.glAlphaFunc((OpenTK.Graphics.ES11.AlphaFunction)func, (Single)@ref);
            }
            internal static void Load_AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref)
            {
                Delegates.glAlphaFuncx = (Delegates.AlphaFuncx)GetExtensionDelegateStatic("glAlphaFuncx", typeof(Delegates.AlphaFuncx));
                Delegates.glAlphaFuncx((OpenTK.Graphics.ES11.All)func, (int)@ref);
            }
            internal static void Load_AlphaFuncxOES(OpenTK.Graphics.ES11.All func, int @ref)
            {
                Delegates.glAlphaFuncxOES = (Delegates.AlphaFuncxOES)GetExtensionDelegateStatic("glAlphaFuncxOES", typeof(Delegates.AlphaFuncxOES));
                Delegates.glAlphaFuncxOES((OpenTK.Graphics.ES11.All)func, (int)@ref);
            }
            internal static void Load_BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer)
            {
                Delegates.glBindBuffer = (Delegates.BindBuffer)GetExtensionDelegateStatic("glBindBuffer", typeof(Delegates.BindBuffer));
                Delegates.glBindBuffer((OpenTK.Graphics.ES11.All)target, (UInt32)buffer);
            }
            internal static void Load_BindFramebufferOES(OpenTK.Graphics.ES11.All target, UInt32 framebuffer)
            {
                Delegates.glBindFramebufferOES = (Delegates.BindFramebufferOES)GetExtensionDelegateStatic("glBindFramebufferOES", typeof(Delegates.BindFramebufferOES));
                Delegates.glBindFramebufferOES((OpenTK.Graphics.ES11.All)target, (UInt32)framebuffer);
            }
            internal static void Load_BindRenderbufferOES(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer)
            {
                Delegates.glBindRenderbufferOES = (Delegates.BindRenderbufferOES)GetExtensionDelegateStatic("glBindRenderbufferOES", typeof(Delegates.BindRenderbufferOES));
                Delegates.glBindRenderbufferOES((OpenTK.Graphics.ES11.All)target, (UInt32)renderbuffer);
            }
            internal static void Load_BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture)
            {
                Delegates.glBindTexture = (Delegates.BindTexture)GetExtensionDelegateStatic("glBindTexture", typeof(Delegates.BindTexture));
                Delegates.glBindTexture((OpenTK.Graphics.ES11.TextureTarget)target, (UInt32)texture);
            }
            internal static void Load_BindVertexArrayOES(UInt32 array)
            {
                Delegates.glBindVertexArrayOES = (Delegates.BindVertexArrayOES)GetExtensionDelegateStatic("glBindVertexArrayOES", typeof(Delegates.BindVertexArrayOES));
                Delegates.glBindVertexArrayOES((UInt32)array);
            }
            internal static unsafe void Load_BitmapxOES(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap)
            {
                Delegates.glBitmapxOES = (Delegates.BitmapxOES)GetExtensionDelegateStatic("glBitmapxOES", typeof(Delegates.BitmapxOES));
                Delegates.glBitmapxOES((Int32)width, (Int32)height, (int)xorig, (int)yorig, (int)xmove, (int)ymove, (Byte*)bitmap);
            }
            internal static void Load_BlendColorxOES(int red, int green, int blue, int alpha)
            {
                Delegates.glBlendColorxOES = (Delegates.BlendColorxOES)GetExtensionDelegateStatic("glBlendColorxOES", typeof(Delegates.BlendColorxOES));
                Delegates.glBlendColorxOES((int)red, (int)green, (int)blue, (int)alpha);
            }
            internal static void Load_BlendEquationEXT(OpenTK.Graphics.ES11.All mode)
            {
                Delegates.glBlendEquationEXT = (Delegates.BlendEquationEXT)GetExtensionDelegateStatic("glBlendEquationEXT", typeof(Delegates.BlendEquationEXT));
                Delegates.glBlendEquationEXT((OpenTK.Graphics.ES11.All)mode);
            }
            internal static void Load_BlendEquationOES(OpenTK.Graphics.ES11.All mode)
            {
                Delegates.glBlendEquationOES = (Delegates.BlendEquationOES)GetExtensionDelegateStatic("glBlendEquationOES", typeof(Delegates.BlendEquationOES));
                Delegates.glBlendEquationOES((OpenTK.Graphics.ES11.All)mode);
            }
            internal static void Load_BlendEquationSeparateOES(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha)
            {
                Delegates.glBlendEquationSeparateOES = (Delegates.BlendEquationSeparateOES)GetExtensionDelegateStatic("glBlendEquationSeparateOES", typeof(Delegates.BlendEquationSeparateOES));
                Delegates.glBlendEquationSeparateOES((OpenTK.Graphics.ES11.All)modeRGB, (OpenTK.Graphics.ES11.All)modeAlpha);
            }
            internal static void Load_BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor)
            {
                Delegates.glBlendFunc = (Delegates.BlendFunc)GetExtensionDelegateStatic("glBlendFunc", typeof(Delegates.BlendFunc));
                Delegates.glBlendFunc((OpenTK.Graphics.ES11.BlendingFactorSrc)sfactor, (OpenTK.Graphics.ES11.BlendingFactorDest)dfactor);
            }
            internal static void Load_BlendFuncSeparateOES(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha)
            {
                Delegates.glBlendFuncSeparateOES = (Delegates.BlendFuncSeparateOES)GetExtensionDelegateStatic("glBlendFuncSeparateOES", typeof(Delegates.BlendFuncSeparateOES));
                Delegates.glBlendFuncSeparateOES((OpenTK.Graphics.ES11.All)srcRGB, (OpenTK.Graphics.ES11.All)dstRGB, (OpenTK.Graphics.ES11.All)srcAlpha, (OpenTK.Graphics.ES11.All)dstAlpha);
            }
            internal static void Load_BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage)
            {
                Delegates.glBufferData = (Delegates.BufferData)GetExtensionDelegateStatic("glBufferData", typeof(Delegates.BufferData));
                Delegates.glBufferData((OpenTK.Graphics.ES11.All)target, (IntPtr)size, (IntPtr)data, (OpenTK.Graphics.ES11.All)usage);
            }
            internal static void Load_BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data)
            {
                Delegates.glBufferSubData = (Delegates.BufferSubData)GetExtensionDelegateStatic("glBufferSubData", typeof(Delegates.BufferSubData));
                Delegates.glBufferSubData((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data);
            }
            internal static OpenTK.Graphics.ES11.All Load_CheckFramebufferStatusOES(OpenTK.Graphics.ES11.All target)
            {
                Delegates.glCheckFramebufferStatusOES = (Delegates.CheckFramebufferStatusOES)GetExtensionDelegateStatic("glCheckFramebufferStatusOES", typeof(Delegates.CheckFramebufferStatusOES));
                return Delegates.glCheckFramebufferStatusOES((OpenTK.Graphics.ES11.All)target);
            }
            internal static void Load_Clear(OpenTK.Graphics.ES11.ClearBufferMask mask)
            {
                Delegates.glClear = (Delegates.Clear)GetExtensionDelegateStatic("glClear", typeof(Delegates.Clear));
                Delegates.glClear((OpenTK.Graphics.ES11.ClearBufferMask)mask);
            }
            internal static void Load_ClearAccumxOES(int red, int green, int blue, int alpha)
            {
                Delegates.glClearAccumxOES = (Delegates.ClearAccumxOES)GetExtensionDelegateStatic("glClearAccumxOES", typeof(Delegates.ClearAccumxOES));
                Delegates.glClearAccumxOES((int)red, (int)green, (int)blue, (int)alpha);
            }
            internal static void Load_ClearColor(Single red, Single green, Single blue, Single alpha)
            {
                Delegates.glClearColor = (Delegates.ClearColor)GetExtensionDelegateStatic("glClearColor", typeof(Delegates.ClearColor));
                Delegates.glClearColor((Single)red, (Single)green, (Single)blue, (Single)alpha);
            }
            internal static void Load_ClearColorx(int red, int green, int blue, int alpha)
            {
                Delegates.glClearColorx = (Delegates.ClearColorx)GetExtensionDelegateStatic("glClearColorx", typeof(Delegates.ClearColorx));
                Delegates.glClearColorx((int)red, (int)green, (int)blue, (int)alpha);
            }
            internal static void Load_ClearColorxOES(int red, int green, int blue, int alpha)
            {
                Delegates.glClearColorxOES = (Delegates.ClearColorxOES)GetExtensionDelegateStatic("glClearColorxOES", typeof(Delegates.ClearColorxOES));
                Delegates.glClearColorxOES((int)red, (int)green, (int)blue, (int)alpha);
            }
            internal static void Load_ClearDepthf(Single d)
            {
                Delegates.glClearDepthf = (Delegates.ClearDepthf)GetExtensionDelegateStatic("glClearDepthf", typeof(Delegates.ClearDepthf));
                Delegates.glClearDepthf((Single)d);
            }
            internal static void Load_ClearDepthfOES(Single depth)
            {
                Delegates.glClearDepthfOES = (Delegates.ClearDepthfOES)GetExtensionDelegateStatic("glClearDepthfOES", typeof(Delegates.ClearDepthfOES));
                Delegates.glClearDepthfOES((Single)depth);
            }
            internal static void Load_ClearDepthx(int depth)
            {
                Delegates.glClearDepthx = (Delegates.ClearDepthx)GetExtensionDelegateStatic("glClearDepthx", typeof(Delegates.ClearDepthx));
                Delegates.glClearDepthx((int)depth);
            }
            internal static void Load_ClearDepthxOES(int depth)
            {
                Delegates.glClearDepthxOES = (Delegates.ClearDepthxOES)GetExtensionDelegateStatic("glClearDepthxOES", typeof(Delegates.ClearDepthxOES));
                Delegates.glClearDepthxOES((int)depth);
            }
            internal static void Load_ClearStencil(Int32 s)
            {
                Delegates.glClearStencil = (Delegates.ClearStencil)GetExtensionDelegateStatic("glClearStencil", typeof(Delegates.ClearStencil));
                Delegates.glClearStencil((Int32)s);
            }
            internal static void Load_ClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture)
            {
                Delegates.glClientActiveTexture = (Delegates.ClientActiveTexture)GetExtensionDelegateStatic("glClientActiveTexture", typeof(Delegates.ClientActiveTexture));
                Delegates.glClientActiveTexture((OpenTK.Graphics.ES11.TextureUnit)texture);
            }
            internal static OpenTK.Graphics.ES11.All Load_ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout)
            {
                Delegates.glClientWaitSyncAPPLE = (Delegates.ClientWaitSyncAPPLE)GetExtensionDelegateStatic("glClientWaitSyncAPPLE", typeof(Delegates.ClientWaitSyncAPPLE));
                return Delegates.glClientWaitSyncAPPLE((IntPtr)sync, (UInt32)flags, (UInt64)timeout);
            }
            internal static unsafe void Load_ClipPlanef(OpenTK.Graphics.ES11.All p, Single* eqn)
            {
                Delegates.glClipPlanef = (Delegates.ClipPlanef)GetExtensionDelegateStatic("glClipPlanef", typeof(Delegates.ClipPlanef));
                Delegates.glClipPlanef((OpenTK.Graphics.ES11.All)p, (Single*)eqn);
            }
            internal static unsafe void Load_ClipPlanefIMG(OpenTK.Graphics.ES11.All p, Single* eqn)
            {
                Delegates.glClipPlanefIMG = (Delegates.ClipPlanefIMG)GetExtensionDelegateStatic("glClipPlanefIMG", typeof(Delegates.ClipPlanefIMG));
                Delegates.glClipPlanefIMG((OpenTK.Graphics.ES11.All)p, (Single*)eqn);
            }
            internal static unsafe void Load_ClipPlanefOES(OpenTK.Graphics.ES11.All plane, Single* equation)
            {
                Delegates.glClipPlanefOES = (Delegates.ClipPlanefOES)GetExtensionDelegateStatic("glClipPlanefOES", typeof(Delegates.ClipPlanefOES));
                Delegates.glClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation);
            }
            internal static unsafe void Load_ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation)
            {
                Delegates.glClipPlanex = (Delegates.ClipPlanex)GetExtensionDelegateStatic("glClipPlanex", typeof(Delegates.ClipPlanex));
                Delegates.glClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation);
            }
            internal static unsafe void Load_ClipPlanexIMG(OpenTK.Graphics.ES11.All p, int* eqn)
            {
                Delegates.glClipPlanexIMG = (Delegates.ClipPlanexIMG)GetExtensionDelegateStatic("glClipPlanexIMG", typeof(Delegates.ClipPlanexIMG));
                Delegates.glClipPlanexIMG((OpenTK.Graphics.ES11.All)p, (int*)eqn);
            }
            internal static unsafe void Load_ClipPlanexOES(OpenTK.Graphics.ES11.All plane, int* equation)
            {
                Delegates.glClipPlanexOES = (Delegates.ClipPlanexOES)GetExtensionDelegateStatic("glClipPlanexOES", typeof(Delegates.ClipPlanexOES));
                Delegates.glClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation);
            }
            internal static void Load_Color3xOES(int red, int green, int blue)
            {
                Delegates.glColor3xOES = (Delegates.Color3xOES)GetExtensionDelegateStatic("glColor3xOES", typeof(Delegates.Color3xOES));
                Delegates.glColor3xOES((int)red, (int)green, (int)blue);
            }
            internal static unsafe void Load_Color3xvOES(int* components)
            {
                Delegates.glColor3xvOES = (Delegates.Color3xvOES)GetExtensionDelegateStatic("glColor3xvOES", typeof(Delegates.Color3xvOES));
                Delegates.glColor3xvOES((int*)components);
            }
            internal static void Load_Color4f(Single red, Single green, Single blue, Single alpha)
            {
                Delegates.glColor4f = (Delegates.Color4f)GetExtensionDelegateStatic("glColor4f", typeof(Delegates.Color4f));
                Delegates.glColor4f((Single)red, (Single)green, (Single)blue, (Single)alpha);
            }
            internal static void Load_Color4ub(Byte red, Byte green, Byte blue, Byte alpha)
            {
                Delegates.glColor4ub = (Delegates.Color4ub)GetExtensionDelegateStatic("glColor4ub", typeof(Delegates.Color4ub));
                Delegates.glColor4ub((Byte)red, (Byte)green, (Byte)blue, (Byte)alpha);
            }
            internal static void Load_Color4x(int red, int green, int blue, int alpha)
            {
                Delegates.glColor4x = (Delegates.Color4x)GetExtensionDelegateStatic("glColor4x", typeof(Delegates.Color4x));
                Delegates.glColor4x((int)red, (int)green, (int)blue, (int)alpha);
            }
            internal static void Load_Color4xOES(int red, int green, int blue, int alpha)
            {
                Delegates.glColor4xOES = (Delegates.Color4xOES)GetExtensionDelegateStatic("glColor4xOES", typeof(Delegates.Color4xOES));
                Delegates.glColor4xOES((int)red, (int)green, (int)blue, (int)alpha);
            }
            internal static unsafe void Load_Color4xvOES(int* components)
            {
                Delegates.glColor4xvOES = (Delegates.Color4xvOES)GetExtensionDelegateStatic("glColor4xvOES", typeof(Delegates.Color4xvOES));
                Delegates.glColor4xvOES((int*)components);
            }
            internal static void Load_ColorMask(bool red, bool green, bool blue, bool alpha)
            {
                Delegates.glColorMask = (Delegates.ColorMask)GetExtensionDelegateStatic("glColorMask", typeof(Delegates.ColorMask));
                Delegates.glColorMask((bool)red, (bool)green, (bool)blue, (bool)alpha);
            }
            internal static void Load_ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer)
            {
                Delegates.glColorPointer = (Delegates.ColorPointer)GetExtensionDelegateStatic("glColorPointer", typeof(Delegates.ColorPointer));
                Delegates.glColorPointer((Int32)size, (OpenTK.Graphics.ES11.ColorPointerType)type, (Int32)stride, (IntPtr)pointer);
            }
            internal static void Load_CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
            {
                Delegates.glCompressedTexImage2D = (Delegates.CompressedTexImage2D)GetExtensionDelegateStatic("glCompressedTexImage2D", typeof(Delegates.CompressedTexImage2D));
                Delegates.glCompressedTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data);
            }
            internal static void Load_CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data)
            {
                Delegates.glCompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)GetExtensionDelegateStatic("glCompressedTexSubImage2D", typeof(Delegates.CompressedTexSubImage2D));
                Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (Int32)imageSize, (IntPtr)data);
            }
            internal static void Load_ConvolutionParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glConvolutionParameterxOES = (Delegates.ConvolutionParameterxOES)GetExtensionDelegateStatic("glConvolutionParameterxOES", typeof(Delegates.ConvolutionParameterxOES));
                Delegates.glConvolutionParameterxOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_ConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glConvolutionParameterxvOES = (Delegates.ConvolutionParameterxvOES)GetExtensionDelegateStatic("glConvolutionParameterxvOES", typeof(Delegates.ConvolutionParameterxvOES));
                Delegates.glConvolutionParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static void Load_CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
            {
                Delegates.glCopyTexImage2D = (Delegates.CopyTexImage2D)GetExtensionDelegateStatic("glCopyTexImage2D", typeof(Delegates.CopyTexImage2D));
                Delegates.glCopyTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)x, (Int32)y, (Int32)width, (Int32)height, (Int32)border);
            }
            internal static void Load_CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
            {
                Delegates.glCopyTexSubImage2D = (Delegates.CopyTexSubImage2D)GetExtensionDelegateStatic("glCopyTexSubImage2D", typeof(Delegates.CopyTexSubImage2D));
                Delegates.glCopyTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
            }
            internal static void Load_CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
            {
                Delegates.glCopyTextureLevelsAPPLE = (Delegates.CopyTextureLevelsAPPLE)GetExtensionDelegateStatic("glCopyTextureLevelsAPPLE", typeof(Delegates.CopyTextureLevelsAPPLE));
                Delegates.glCopyTextureLevelsAPPLE((UInt32)destinationTexture, (UInt32)sourceTexture, (Int32)sourceBaseLevel, (Int32)sourceLevelCount);
            }
            internal static void Load_CullFace(OpenTK.Graphics.ES11.CullFaceMode mode)
            {
                Delegates.glCullFace = (Delegates.CullFace)GetExtensionDelegateStatic("glCullFace", typeof(Delegates.CullFace));
                Delegates.glCullFace((OpenTK.Graphics.ES11.CullFaceMode)mode);
            }
            internal static void Load_CurrentPaletteMatrixOES(UInt32 matrixpaletteindex)
            {
                Delegates.glCurrentPaletteMatrixOES = (Delegates.CurrentPaletteMatrixOES)GetExtensionDelegateStatic("glCurrentPaletteMatrixOES", typeof(Delegates.CurrentPaletteMatrixOES));
                Delegates.glCurrentPaletteMatrixOES((UInt32)matrixpaletteindex);
            }
            internal static unsafe void Load_DeleteBuffers(Int32 n, UInt32* buffers)
            {
                Delegates.glDeleteBuffers = (Delegates.DeleteBuffers)GetExtensionDelegateStatic("glDeleteBuffers", typeof(Delegates.DeleteBuffers));
                Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers);
            }
            internal static unsafe void Load_DeleteFencesNV(Int32 n, UInt32* fences)
            {
                Delegates.glDeleteFencesNV = (Delegates.DeleteFencesNV)GetExtensionDelegateStatic("glDeleteFencesNV", typeof(Delegates.DeleteFencesNV));
                Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences);
            }
            internal static unsafe void Load_DeleteFramebuffersOES(Int32 n, UInt32* framebuffers)
            {
                Delegates.glDeleteFramebuffersOES = (Delegates.DeleteFramebuffersOES)GetExtensionDelegateStatic("glDeleteFramebuffersOES", typeof(Delegates.DeleteFramebuffersOES));
                Delegates.glDeleteFramebuffersOES((Int32)n, (UInt32*)framebuffers);
            }
            internal static unsafe void Load_DeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers)
            {
                Delegates.glDeleteRenderbuffersOES = (Delegates.DeleteRenderbuffersOES)GetExtensionDelegateStatic("glDeleteRenderbuffersOES", typeof(Delegates.DeleteRenderbuffersOES));
                Delegates.glDeleteRenderbuffersOES((Int32)n, (UInt32*)renderbuffers);
            }
            internal static void Load_DeleteSyncAPPLE(IntPtr sync)
            {
                Delegates.glDeleteSyncAPPLE = (Delegates.DeleteSyncAPPLE)GetExtensionDelegateStatic("glDeleteSyncAPPLE", typeof(Delegates.DeleteSyncAPPLE));
                Delegates.glDeleteSyncAPPLE((IntPtr)sync);
            }
            internal static unsafe void Load_DeleteTextures(Int32 n, UInt32* textures)
            {
                Delegates.glDeleteTextures = (Delegates.DeleteTextures)GetExtensionDelegateStatic("glDeleteTextures", typeof(Delegates.DeleteTextures));
                Delegates.glDeleteTextures((Int32)n, (UInt32*)textures);
            }
            internal static unsafe void Load_DeleteVertexArraysOES(Int32 n, UInt32* arrays)
            {
                Delegates.glDeleteVertexArraysOES = (Delegates.DeleteVertexArraysOES)GetExtensionDelegateStatic("glDeleteVertexArraysOES", typeof(Delegates.DeleteVertexArraysOES));
                Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays);
            }
            internal static void Load_DepthFunc(OpenTK.Graphics.ES11.DepthFunction func)
            {
                Delegates.glDepthFunc = (Delegates.DepthFunc)GetExtensionDelegateStatic("glDepthFunc", typeof(Delegates.DepthFunc));
                Delegates.glDepthFunc((OpenTK.Graphics.ES11.DepthFunction)func);
            }
            internal static void Load_DepthMask(bool flag)
            {
                Delegates.glDepthMask = (Delegates.DepthMask)GetExtensionDelegateStatic("glDepthMask", typeof(Delegates.DepthMask));
                Delegates.glDepthMask((bool)flag);
            }
            internal static void Load_DepthRangef(Single n, Single f)
            {
                Delegates.glDepthRangef = (Delegates.DepthRangef)GetExtensionDelegateStatic("glDepthRangef", typeof(Delegates.DepthRangef));
                Delegates.glDepthRangef((Single)n, (Single)f);
            }
            internal static void Load_DepthRangefOES(Single n, Single f)
            {
                Delegates.glDepthRangefOES = (Delegates.DepthRangefOES)GetExtensionDelegateStatic("glDepthRangefOES", typeof(Delegates.DepthRangefOES));
                Delegates.glDepthRangefOES((Single)n, (Single)f);
            }
            internal static void Load_DepthRangex(int n, int f)
            {
                Delegates.glDepthRangex = (Delegates.DepthRangex)GetExtensionDelegateStatic("glDepthRangex", typeof(Delegates.DepthRangex));
                Delegates.glDepthRangex((int)n, (int)f);
            }
            internal static void Load_DepthRangexOES(int n, int f)
            {
                Delegates.glDepthRangexOES = (Delegates.DepthRangexOES)GetExtensionDelegateStatic("glDepthRangexOES", typeof(Delegates.DepthRangexOES));
                Delegates.glDepthRangexOES((int)n, (int)f);
            }
            internal static void Load_Disable(OpenTK.Graphics.ES11.EnableCap cap)
            {
                Delegates.glDisable = (Delegates.Disable)GetExtensionDelegateStatic("glDisable", typeof(Delegates.Disable));
                Delegates.glDisable((OpenTK.Graphics.ES11.EnableCap)cap);
            }
            internal static void Load_DisableClientState(OpenTK.Graphics.ES11.EnableCap array)
            {
                Delegates.glDisableClientState = (Delegates.DisableClientState)GetExtensionDelegateStatic("glDisableClientState", typeof(Delegates.DisableClientState));
                Delegates.glDisableClientState((OpenTK.Graphics.ES11.EnableCap)array);
            }
            internal static void Load_DisableDriverControlQCOM(UInt32 driverControl)
            {
                Delegates.glDisableDriverControlQCOM = (Delegates.DisableDriverControlQCOM)GetExtensionDelegateStatic("glDisableDriverControlQCOM", typeof(Delegates.DisableDriverControlQCOM));
                Delegates.glDisableDriverControlQCOM((UInt32)driverControl);
            }
            internal static unsafe void Load_DiscardFramebufferEXT(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments)
            {
                Delegates.glDiscardFramebufferEXT = (Delegates.DiscardFramebufferEXT)GetExtensionDelegateStatic("glDiscardFramebufferEXT", typeof(Delegates.DiscardFramebufferEXT));
                Delegates.glDiscardFramebufferEXT((OpenTK.Graphics.ES11.All)target, (Int32)numAttachments, (OpenTK.Graphics.ES11.All*)attachments);
            }
            internal static void Load_DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count)
            {
                Delegates.glDrawArrays = (Delegates.DrawArrays)GetExtensionDelegateStatic("glDrawArrays", typeof(Delegates.DrawArrays));
                Delegates.glDrawArrays((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)first, (Int32)count);
            }
            internal static void Load_DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices)
            {
                Delegates.glDrawElements = (Delegates.DrawElements)GetExtensionDelegateStatic("glDrawElements", typeof(Delegates.DrawElements));
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices);
            }
            internal static void Load_DrawTexfOES(Single x, Single y, Single z, Single width, Single height)
            {
                Delegates.glDrawTexfOES = (Delegates.DrawTexfOES)GetExtensionDelegateStatic("glDrawTexfOES", typeof(Delegates.DrawTexfOES));
                Delegates.glDrawTexfOES((Single)x, (Single)y, (Single)z, (Single)width, (Single)height);
            }
            internal static unsafe void Load_DrawTexfvOES(Single* coords)
            {
                Delegates.glDrawTexfvOES = (Delegates.DrawTexfvOES)GetExtensionDelegateStatic("glDrawTexfvOES", typeof(Delegates.DrawTexfvOES));
                Delegates.glDrawTexfvOES((Single*)coords);
            }
            internal static void Load_DrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height)
            {
                Delegates.glDrawTexiOES = (Delegates.DrawTexiOES)GetExtensionDelegateStatic("glDrawTexiOES", typeof(Delegates.DrawTexiOES));
                Delegates.glDrawTexiOES((Int32)x, (Int32)y, (Int32)z, (Int32)width, (Int32)height);
            }
            internal static unsafe void Load_DrawTexivOES(Int32* coords)
            {
                Delegates.glDrawTexivOES = (Delegates.DrawTexivOES)GetExtensionDelegateStatic("glDrawTexivOES", typeof(Delegates.DrawTexivOES));
                Delegates.glDrawTexivOES((Int32*)coords);
            }
            internal static void Load_DrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height)
            {
                Delegates.glDrawTexsOES = (Delegates.DrawTexsOES)GetExtensionDelegateStatic("glDrawTexsOES", typeof(Delegates.DrawTexsOES));
                Delegates.glDrawTexsOES((Int16)x, (Int16)y, (Int16)z, (Int16)width, (Int16)height);
            }
            internal static unsafe void Load_DrawTexsvOES(Int16* coords)
            {
                Delegates.glDrawTexsvOES = (Delegates.DrawTexsvOES)GetExtensionDelegateStatic("glDrawTexsvOES", typeof(Delegates.DrawTexsvOES));
                Delegates.glDrawTexsvOES((Int16*)coords);
            }
            internal static void Load_DrawTexxOES(int x, int y, int z, int width, int height)
            {
                Delegates.glDrawTexxOES = (Delegates.DrawTexxOES)GetExtensionDelegateStatic("glDrawTexxOES", typeof(Delegates.DrawTexxOES));
                Delegates.glDrawTexxOES((int)x, (int)y, (int)z, (int)width, (int)height);
            }
            internal static unsafe void Load_DrawTexxvOES(int* coords)
            {
                Delegates.glDrawTexxvOES = (Delegates.DrawTexxvOES)GetExtensionDelegateStatic("glDrawTexxvOES", typeof(Delegates.DrawTexxvOES));
                Delegates.glDrawTexxvOES((int*)coords);
            }
            internal static void Load_EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES11.All target, IntPtr image)
            {
                Delegates.glEGLImageTargetRenderbufferStorageOES = (Delegates.EGLImageTargetRenderbufferStorageOES)GetExtensionDelegateStatic("glEGLImageTargetRenderbufferStorageOES", typeof(Delegates.EGLImageTargetRenderbufferStorageOES));
                Delegates.glEGLImageTargetRenderbufferStorageOES((OpenTK.Graphics.ES11.All)target, (IntPtr)image);
            }
            internal static void Load_EGLImageTargetTexture2DOES(OpenTK.Graphics.ES11.All target, IntPtr image)
            {
                Delegates.glEGLImageTargetTexture2DOES = (Delegates.EGLImageTargetTexture2DOES)GetExtensionDelegateStatic("glEGLImageTargetTexture2DOES", typeof(Delegates.EGLImageTargetTexture2DOES));
                Delegates.glEGLImageTargetTexture2DOES((OpenTK.Graphics.ES11.All)target, (IntPtr)image);
            }
            internal static void Load_Enable(OpenTK.Graphics.ES11.EnableCap cap)
            {
                Delegates.glEnable = (Delegates.Enable)GetExtensionDelegateStatic("glEnable", typeof(Delegates.Enable));
                Delegates.glEnable((OpenTK.Graphics.ES11.EnableCap)cap);
            }
            internal static void Load_EnableClientState(OpenTK.Graphics.ES11.EnableCap array)
            {
                Delegates.glEnableClientState = (Delegates.EnableClientState)GetExtensionDelegateStatic("glEnableClientState", typeof(Delegates.EnableClientState));
                Delegates.glEnableClientState((OpenTK.Graphics.ES11.EnableCap)array);
            }
            internal static void Load_EnableDriverControlQCOM(UInt32 driverControl)
            {
                Delegates.glEnableDriverControlQCOM = (Delegates.EnableDriverControlQCOM)GetExtensionDelegateStatic("glEnableDriverControlQCOM", typeof(Delegates.EnableDriverControlQCOM));
                Delegates.glEnableDriverControlQCOM((UInt32)driverControl);
            }
            internal static void Load_EndTilingQCOM(UInt32 preserveMask)
            {
                Delegates.glEndTilingQCOM = (Delegates.EndTilingQCOM)GetExtensionDelegateStatic("glEndTilingQCOM", typeof(Delegates.EndTilingQCOM));
                Delegates.glEndTilingQCOM((UInt32)preserveMask);
            }
            internal static void Load_EvalCoord1xOES(int u)
            {
                Delegates.glEvalCoord1xOES = (Delegates.EvalCoord1xOES)GetExtensionDelegateStatic("glEvalCoord1xOES", typeof(Delegates.EvalCoord1xOES));
                Delegates.glEvalCoord1xOES((int)u);
            }
            internal static unsafe void Load_EvalCoord1xvOES(int* coords)
            {
                Delegates.glEvalCoord1xvOES = (Delegates.EvalCoord1xvOES)GetExtensionDelegateStatic("glEvalCoord1xvOES", typeof(Delegates.EvalCoord1xvOES));
                Delegates.glEvalCoord1xvOES((int*)coords);
            }
            internal static void Load_EvalCoord2xOES(int u, int v)
            {
                Delegates.glEvalCoord2xOES = (Delegates.EvalCoord2xOES)GetExtensionDelegateStatic("glEvalCoord2xOES", typeof(Delegates.EvalCoord2xOES));
                Delegates.glEvalCoord2xOES((int)u, (int)v);
            }
            internal static unsafe void Load_EvalCoord2xvOES(int* coords)
            {
                Delegates.glEvalCoord2xvOES = (Delegates.EvalCoord2xvOES)GetExtensionDelegateStatic("glEvalCoord2xvOES", typeof(Delegates.EvalCoord2xvOES));
                Delegates.glEvalCoord2xvOES((int*)coords);
            }
            internal static void Load_ExtGetBufferPointervQCOM(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params)
            {
                Delegates.glExtGetBufferPointervQCOM = (Delegates.ExtGetBufferPointervQCOM)GetExtensionDelegateStatic("glExtGetBufferPointervQCOM", typeof(Delegates.ExtGetBufferPointervQCOM));
                Delegates.glExtGetBufferPointervQCOM((OpenTK.Graphics.ES11.All)target, (IntPtr)@params);
            }
            internal static unsafe void Load_ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers)
            {
                Delegates.glExtGetBuffersQCOM = (Delegates.ExtGetBuffersQCOM)GetExtensionDelegateStatic("glExtGetBuffersQCOM", typeof(Delegates.ExtGetBuffersQCOM));
                Delegates.glExtGetBuffersQCOM((UInt32*)buffers, (Int32)maxBuffers, (Int32*)numBuffers);
            }
            internal static unsafe void Load_ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers)
            {
                Delegates.glExtGetFramebuffersQCOM = (Delegates.ExtGetFramebuffersQCOM)GetExtensionDelegateStatic("glExtGetFramebuffersQCOM", typeof(Delegates.ExtGetFramebuffersQCOM));
                Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers, (Int32)maxFramebuffers, (Int32*)numFramebuffers);
            }
            internal static unsafe void Load_ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length)
            {
                Delegates.glExtGetProgramBinarySourceQCOM = (Delegates.ExtGetProgramBinarySourceQCOM)GetExtensionDelegateStatic("glExtGetProgramBinarySourceQCOM", typeof(Delegates.ExtGetProgramBinarySourceQCOM));
                Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES11.All)shadertype, (StringBuilder)source, (Int32*)length);
            }
            internal static unsafe void Load_ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms)
            {
                Delegates.glExtGetProgramsQCOM = (Delegates.ExtGetProgramsQCOM)GetExtensionDelegateStatic("glExtGetProgramsQCOM", typeof(Delegates.ExtGetProgramsQCOM));
                Delegates.glExtGetProgramsQCOM((UInt32*)programs, (Int32)maxPrograms, (Int32*)numPrograms);
            }
            internal static unsafe void Load_ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers)
            {
                Delegates.glExtGetRenderbuffersQCOM = (Delegates.ExtGetRenderbuffersQCOM)GetExtensionDelegateStatic("glExtGetRenderbuffersQCOM", typeof(Delegates.ExtGetRenderbuffersQCOM));
                Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers);
            }
            internal static unsafe void Load_ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders)
            {
                Delegates.glExtGetShadersQCOM = (Delegates.ExtGetShadersQCOM)GetExtensionDelegateStatic("glExtGetShadersQCOM", typeof(Delegates.ExtGetShadersQCOM));
                Delegates.glExtGetShadersQCOM((UInt32*)shaders, (Int32)maxShaders, (Int32*)numShaders);
            }
            internal static unsafe void Load_ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                Delegates.glExtGetTexLevelParameterivQCOM = (Delegates.ExtGetTexLevelParameterivQCOM)GetExtensionDelegateStatic("glExtGetTexLevelParameterivQCOM", typeof(Delegates.ExtGetTexLevelParameterivQCOM));
                Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES11.All)face, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            }
            internal static void Load_ExtGetTexSubImageQCOM(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels)
            {
                Delegates.glExtGetTexSubImageQCOM = (Delegates.ExtGetTexSubImageQCOM)GetExtensionDelegateStatic("glExtGetTexSubImageQCOM", typeof(Delegates.ExtGetTexSubImageQCOM));
                Delegates.glExtGetTexSubImageQCOM((OpenTK.Graphics.ES11.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (IntPtr)texels);
            }
            internal static unsafe void Load_ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures)
            {
                Delegates.glExtGetTexturesQCOM = (Delegates.ExtGetTexturesQCOM)GetExtensionDelegateStatic("glExtGetTexturesQCOM", typeof(Delegates.ExtGetTexturesQCOM));
                Delegates.glExtGetTexturesQCOM((UInt32*)textures, (Int32)maxTextures, (Int32*)numTextures);
            }
            internal static bool Load_ExtIsProgramBinaryQCOM(UInt32 program)
            {
                Delegates.glExtIsProgramBinaryQCOM = (Delegates.ExtIsProgramBinaryQCOM)GetExtensionDelegateStatic("glExtIsProgramBinaryQCOM", typeof(Delegates.ExtIsProgramBinaryQCOM));
                return Delegates.glExtIsProgramBinaryQCOM((UInt32)program);
            }
            internal static void Load_ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param)
            {
                Delegates.glExtTexObjectStateOverrideiQCOM = (Delegates.ExtTexObjectStateOverrideiQCOM)GetExtensionDelegateStatic("glExtTexObjectStateOverrideiQCOM", typeof(Delegates.ExtTexObjectStateOverrideiQCOM));
                Delegates.glExtTexObjectStateOverrideiQCOM((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32)param);
            }
            internal static unsafe void Load_FeedbackBufferxOES(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer)
            {
                Delegates.glFeedbackBufferxOES = (Delegates.FeedbackBufferxOES)GetExtensionDelegateStatic("glFeedbackBufferxOES", typeof(Delegates.FeedbackBufferxOES));
                Delegates.glFeedbackBufferxOES((Int32)n, (OpenTK.Graphics.ES11.All)type, (int*)buffer);
            }
            internal static IntPtr Load_FenceSyncAPPLE(OpenTK.Graphics.ES11.All condition, UInt32 flags)
            {
                Delegates.glFenceSyncAPPLE = (Delegates.FenceSyncAPPLE)GetExtensionDelegateStatic("glFenceSyncAPPLE", typeof(Delegates.FenceSyncAPPLE));
                return Delegates.glFenceSyncAPPLE((OpenTK.Graphics.ES11.All)condition, (UInt32)flags);
            }
            internal static void Load_Finish()
            {
                Delegates.glFinish = (Delegates.Finish)GetExtensionDelegateStatic("glFinish", typeof(Delegates.Finish));
                Delegates.glFinish();
            }
            internal static void Load_FinishFenceNV(UInt32 fence)
            {
                Delegates.glFinishFenceNV = (Delegates.FinishFenceNV)GetExtensionDelegateStatic("glFinishFenceNV", typeof(Delegates.FinishFenceNV));
                Delegates.glFinishFenceNV((UInt32)fence);
            }
            internal static void Load_Flush()
            {
                Delegates.glFlush = (Delegates.Flush)GetExtensionDelegateStatic("glFlush", typeof(Delegates.Flush));
                Delegates.glFlush();
            }
            internal static void Load_FlushMappedBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length)
            {
                Delegates.glFlushMappedBufferRangeEXT = (Delegates.FlushMappedBufferRangeEXT)GetExtensionDelegateStatic("glFlushMappedBufferRangeEXT", typeof(Delegates.FlushMappedBufferRangeEXT));
                Delegates.glFlushMappedBufferRangeEXT((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)length);
            }
            internal static void Load_Fogf(OpenTK.Graphics.ES11.FogParameter pname, Single param)
            {
                Delegates.glFogf = (Delegates.Fogf)GetExtensionDelegateStatic("glFogf", typeof(Delegates.Fogf));
                Delegates.glFogf((OpenTK.Graphics.ES11.FogParameter)pname, (Single)param);
            }
            internal static unsafe void Load_Fogfv(OpenTK.Graphics.ES11.FogParameter pname, Single* @params)
            {
                Delegates.glFogfv = (Delegates.Fogfv)GetExtensionDelegateStatic("glFogfv", typeof(Delegates.Fogfv));
                Delegates.glFogfv((OpenTK.Graphics.ES11.FogParameter)pname, (Single*)@params);
            }
            internal static void Load_Fogx(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glFogx = (Delegates.Fogx)GetExtensionDelegateStatic("glFogx", typeof(Delegates.Fogx));
                Delegates.glFogx((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_FogxOES(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glFogxOES = (Delegates.FogxOES)GetExtensionDelegateStatic("glFogxOES", typeof(Delegates.FogxOES));
                Delegates.glFogxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_Fogxv(OpenTK.Graphics.ES11.All pname, int* param)
            {
                Delegates.glFogxv = (Delegates.Fogxv)GetExtensionDelegateStatic("glFogxv", typeof(Delegates.Fogxv));
                Delegates.glFogxv((OpenTK.Graphics.ES11.All)pname, (int*)param);
            }
            internal static unsafe void Load_FogxvOES(OpenTK.Graphics.ES11.All pname, int* param)
            {
                Delegates.glFogxvOES = (Delegates.FogxvOES)GetExtensionDelegateStatic("glFogxvOES", typeof(Delegates.FogxvOES));
                Delegates.glFogxvOES((OpenTK.Graphics.ES11.All)pname, (int*)param);
            }
            internal static void Load_FramebufferRenderbufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer)
            {
                Delegates.glFramebufferRenderbufferOES = (Delegates.FramebufferRenderbufferOES)GetExtensionDelegateStatic("glFramebufferRenderbufferOES", typeof(Delegates.FramebufferRenderbufferOES));
                Delegates.glFramebufferRenderbufferOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)renderbuffertarget, (UInt32)renderbuffer);
            }
            internal static void Load_FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples)
            {
                Delegates.glFramebufferTexture2DMultisampleEXT = (Delegates.FramebufferTexture2DMultisampleEXT)GetExtensionDelegateStatic("glFramebufferTexture2DMultisampleEXT", typeof(Delegates.FramebufferTexture2DMultisampleEXT));
                Delegates.glFramebufferTexture2DMultisampleEXT((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
            }
            internal static void Load_FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples)
            {
                Delegates.glFramebufferTexture2DMultisampleIMG = (Delegates.FramebufferTexture2DMultisampleIMG)GetExtensionDelegateStatic("glFramebufferTexture2DMultisampleIMG", typeof(Delegates.FramebufferTexture2DMultisampleIMG));
                Delegates.glFramebufferTexture2DMultisampleIMG((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
            }
            internal static void Load_FramebufferTexture2DOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level)
            {
                Delegates.glFramebufferTexture2DOES = (Delegates.FramebufferTexture2DOES)GetExtensionDelegateStatic("glFramebufferTexture2DOES", typeof(Delegates.FramebufferTexture2DOES));
                Delegates.glFramebufferTexture2DOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level);
            }
            internal static void Load_FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode)
            {
                Delegates.glFrontFace = (Delegates.FrontFace)GetExtensionDelegateStatic("glFrontFace", typeof(Delegates.FrontFace));
                Delegates.glFrontFace((OpenTK.Graphics.ES11.FrontFaceDirection)mode);
            }
            internal static void Load_Frustumf(Single l, Single r, Single b, Single t, Single n, Single f)
            {
                Delegates.glFrustumf = (Delegates.Frustumf)GetExtensionDelegateStatic("glFrustumf", typeof(Delegates.Frustumf));
                Delegates.glFrustumf((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
            }
            internal static void Load_FrustumfOES(Single l, Single r, Single b, Single t, Single n, Single f)
            {
                Delegates.glFrustumfOES = (Delegates.FrustumfOES)GetExtensionDelegateStatic("glFrustumfOES", typeof(Delegates.FrustumfOES));
                Delegates.glFrustumfOES((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
            }
            internal static void Load_Frustumx(int l, int r, int b, int t, int n, int f)
            {
                Delegates.glFrustumx = (Delegates.Frustumx)GetExtensionDelegateStatic("glFrustumx", typeof(Delegates.Frustumx));
                Delegates.glFrustumx((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
            }
            internal static void Load_FrustumxOES(int l, int r, int b, int t, int n, int f)
            {
                Delegates.glFrustumxOES = (Delegates.FrustumxOES)GetExtensionDelegateStatic("glFrustumxOES", typeof(Delegates.FrustumxOES));
                Delegates.glFrustumxOES((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
            }
            internal static unsafe void Load_GenBuffers(Int32 n, [OutAttribute] UInt32* buffers)
            {
                Delegates.glGenBuffers = (Delegates.GenBuffers)GetExtensionDelegateStatic("glGenBuffers", typeof(Delegates.GenBuffers));
                Delegates.glGenBuffers((Int32)n, (UInt32*)buffers);
            }
            internal static void Load_GenerateMipmapOES(OpenTK.Graphics.ES11.All target)
            {
                Delegates.glGenerateMipmapOES = (Delegates.GenerateMipmapOES)GetExtensionDelegateStatic("glGenerateMipmapOES", typeof(Delegates.GenerateMipmapOES));
                Delegates.glGenerateMipmapOES((OpenTK.Graphics.ES11.All)target);
            }
            internal static unsafe void Load_GenFencesNV(Int32 n, [OutAttribute] UInt32* fences)
            {
                Delegates.glGenFencesNV = (Delegates.GenFencesNV)GetExtensionDelegateStatic("glGenFencesNV", typeof(Delegates.GenFencesNV));
                Delegates.glGenFencesNV((Int32)n, (UInt32*)fences);
            }
            internal static unsafe void Load_GenFramebuffersOES(Int32 n, [OutAttribute] UInt32* framebuffers)
            {
                Delegates.glGenFramebuffersOES = (Delegates.GenFramebuffersOES)GetExtensionDelegateStatic("glGenFramebuffersOES", typeof(Delegates.GenFramebuffersOES));
                Delegates.glGenFramebuffersOES((Int32)n, (UInt32*)framebuffers);
            }
            internal static unsafe void Load_GenRenderbuffersOES(Int32 n, [OutAttribute] UInt32* renderbuffers)
            {
                Delegates.glGenRenderbuffersOES = (Delegates.GenRenderbuffersOES)GetExtensionDelegateStatic("glGenRenderbuffersOES", typeof(Delegates.GenRenderbuffersOES));
                Delegates.glGenRenderbuffersOES((Int32)n, (UInt32*)renderbuffers);
            }
            internal static unsafe void Load_GenTextures(Int32 n, [OutAttribute] UInt32* textures)
            {
                Delegates.glGenTextures = (Delegates.GenTextures)GetExtensionDelegateStatic("glGenTextures", typeof(Delegates.GenTextures));
                Delegates.glGenTextures((Int32)n, (UInt32*)textures);
            }
            internal static unsafe void Load_GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays)
            {
                Delegates.glGenVertexArraysOES = (Delegates.GenVertexArraysOES)GetExtensionDelegateStatic("glGenVertexArraysOES", typeof(Delegates.GenVertexArraysOES));
                Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays);
            }
            internal static unsafe void Load_GetBooleanv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data)
            {
                Delegates.glGetBooleanv = (Delegates.GetBooleanv)GetExtensionDelegateStatic("glGetBooleanv", typeof(Delegates.GetBooleanv));
                Delegates.glGetBooleanv((OpenTK.Graphics.ES11.GetPName)pname, (bool*)data);
            }
            internal static unsafe void Load_GetBufferParameteriv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                Delegates.glGetBufferParameteriv = (Delegates.GetBufferParameteriv)GetExtensionDelegateStatic("glGetBufferParameteriv", typeof(Delegates.GetBufferParameteriv));
                Delegates.glGetBufferParameteriv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            }
            internal static void Load_GetBufferPointervOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params)
            {
                Delegates.glGetBufferPointervOES = (Delegates.GetBufferPointervOES)GetExtensionDelegateStatic("glGetBufferPointervOES", typeof(Delegates.GetBufferPointervOES));
                Delegates.glGetBufferPointervOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (IntPtr)@params);
            }
            internal static unsafe void Load_GetClipPlanef(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation)
            {
                Delegates.glGetClipPlanef = (Delegates.GetClipPlanef)GetExtensionDelegateStatic("glGetClipPlanef", typeof(Delegates.GetClipPlanef));
                Delegates.glGetClipPlanef((OpenTK.Graphics.ES11.All)plane, (Single*)equation);
            }
            internal static unsafe void Load_GetClipPlanefOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation)
            {
                Delegates.glGetClipPlanefOES = (Delegates.GetClipPlanefOES)GetExtensionDelegateStatic("glGetClipPlanefOES", typeof(Delegates.GetClipPlanefOES));
                Delegates.glGetClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation);
            }
            internal static unsafe void Load_GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation)
            {
                Delegates.glGetClipPlanex = (Delegates.GetClipPlanex)GetExtensionDelegateStatic("glGetClipPlanex", typeof(Delegates.GetClipPlanex));
                Delegates.glGetClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation);
            }
            internal static unsafe void Load_GetClipPlanexOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation)
            {
                Delegates.glGetClipPlanexOES = (Delegates.GetClipPlanexOES)GetExtensionDelegateStatic("glGetClipPlanexOES", typeof(Delegates.GetClipPlanexOES));
                Delegates.glGetClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation);
            }
            internal static unsafe void Load_GetConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetConvolutionParameterxvOES = (Delegates.GetConvolutionParameterxvOES)GetExtensionDelegateStatic("glGetConvolutionParameterxvOES", typeof(Delegates.GetConvolutionParameterxvOES));
                Delegates.glGetConvolutionParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls)
            {
                Delegates.glGetDriverControlsQCOM = (Delegates.GetDriverControlsQCOM)GetExtensionDelegateStatic("glGetDriverControlsQCOM", typeof(Delegates.GetDriverControlsQCOM));
                Delegates.glGetDriverControlsQCOM((Int32*)num, (Int32)size, (UInt32*)driverControls);
            }
            internal static unsafe void Load_GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString)
            {
                Delegates.glGetDriverControlStringQCOM = (Delegates.GetDriverControlStringQCOM)GetExtensionDelegateStatic("glGetDriverControlStringQCOM", typeof(Delegates.GetDriverControlStringQCOM));
                Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length, (StringBuilder)driverControlString);
            }
            internal static OpenTK.Graphics.ES11.ErrorCode Load_GetError()
            {
                Delegates.glGetError = (Delegates.GetError)GetExtensionDelegateStatic("glGetError", typeof(Delegates.GetError));
                return Delegates.glGetError();
            }
            internal static unsafe void Load_GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                Delegates.glGetFenceivNV = (Delegates.GetFenceivNV)GetExtensionDelegateStatic("glGetFenceivNV", typeof(Delegates.GetFenceivNV));
                Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            }
            internal static unsafe void Load_GetFixedv(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetFixedv = (Delegates.GetFixedv)GetExtensionDelegateStatic("glGetFixedv", typeof(Delegates.GetFixedv));
                Delegates.glGetFixedv((OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetFixedvOES(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetFixedvOES = (Delegates.GetFixedvOES)GetExtensionDelegateStatic("glGetFixedvOES", typeof(Delegates.GetFixedvOES));
                Delegates.glGetFixedvOES((OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetFloatv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data)
            {
                Delegates.glGetFloatv = (Delegates.GetFloatv)GetExtensionDelegateStatic("glGetFloatv", typeof(Delegates.GetFloatv));
                Delegates.glGetFloatv((OpenTK.Graphics.ES11.GetPName)pname, (Single*)data);
            }
            internal static unsafe void Load_GetFramebufferAttachmentParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                Delegates.glGetFramebufferAttachmentParameterivOES = (Delegates.GetFramebufferAttachmentParameterivOES)GetExtensionDelegateStatic("glGetFramebufferAttachmentParameterivOES", typeof(Delegates.GetFramebufferAttachmentParameterivOES));
                Delegates.glGetFramebufferAttachmentParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            }
            internal static OpenTK.Graphics.ES11.All Load_GetGraphicsResetStatusEXT()
            {
                Delegates.glGetGraphicsResetStatusEXT = (Delegates.GetGraphicsResetStatusEXT)GetExtensionDelegateStatic("glGetGraphicsResetStatusEXT", typeof(Delegates.GetGraphicsResetStatusEXT));
                return Delegates.glGetGraphicsResetStatusEXT();
            }
            internal static unsafe void Load_GetHistogramParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetHistogramParameterxvOES = (Delegates.GetHistogramParameterxvOES)GetExtensionDelegateStatic("glGetHistogramParameterxvOES", typeof(Delegates.GetHistogramParameterxvOES));
                Delegates.glGetHistogramParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetInteger64vAPPLE(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params)
            {
                Delegates.glGetInteger64vAPPLE = (Delegates.GetInteger64vAPPLE)GetExtensionDelegateStatic("glGetInteger64vAPPLE", typeof(Delegates.GetInteger64vAPPLE));
                Delegates.glGetInteger64vAPPLE((OpenTK.Graphics.ES11.All)pname, (Int64*)@params);
            }
            internal static unsafe void Load_GetIntegerv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data)
            {
                Delegates.glGetIntegerv = (Delegates.GetIntegerv)GetExtensionDelegateStatic("glGetIntegerv", typeof(Delegates.GetIntegerv));
                Delegates.glGetIntegerv((OpenTK.Graphics.ES11.GetPName)pname, (Int32*)data);
            }
            internal static unsafe void Load_GetLightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params)
            {
                Delegates.glGetLightfv = (Delegates.GetLightfv)GetExtensionDelegateStatic("glGetLightfv", typeof(Delegates.GetLightfv));
                Delegates.glGetLightfv((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single*)@params);
            }
            internal static unsafe void Load_GetLightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetLightxOES = (Delegates.GetLightxOES)GetExtensionDelegateStatic("glGetLightxOES", typeof(Delegates.GetLightxOES));
                Delegates.glGetLightxOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetLightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetLightxv = (Delegates.GetLightxv)GetExtensionDelegateStatic("glGetLightxv", typeof(Delegates.GetLightxv));
                Delegates.glGetLightxv((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetLightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetLightxvOES = (Delegates.GetLightxvOES)GetExtensionDelegateStatic("glGetLightxvOES", typeof(Delegates.GetLightxvOES));
                Delegates.glGetLightxvOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetMapxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v)
            {
                Delegates.glGetMapxvOES = (Delegates.GetMapxvOES)GetExtensionDelegateStatic("glGetMapxvOES", typeof(Delegates.GetMapxvOES));
                Delegates.glGetMapxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)query, (int*)v);
            }
            internal static unsafe void Load_GetMaterialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params)
            {
                Delegates.glGetMaterialfv = (Delegates.GetMaterialfv)GetExtensionDelegateStatic("glGetMaterialfv", typeof(Delegates.GetMaterialfv));
                Delegates.glGetMaterialfv((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single*)@params);
            }
            internal static void Load_GetMaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glGetMaterialxOES = (Delegates.GetMaterialxOES)GetExtensionDelegateStatic("glGetMaterialxOES", typeof(Delegates.GetMaterialxOES));
                Delegates.glGetMaterialxOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_GetMaterialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetMaterialxv = (Delegates.GetMaterialxv)GetExtensionDelegateStatic("glGetMaterialxv", typeof(Delegates.GetMaterialxv));
                Delegates.glGetMaterialxv((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetMaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetMaterialxvOES = (Delegates.GetMaterialxvOES)GetExtensionDelegateStatic("glGetMaterialxvOES", typeof(Delegates.GetMaterialxvOES));
                Delegates.glGetMaterialxvOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params)
            {
                Delegates.glGetnUniformfvEXT = (Delegates.GetnUniformfvEXT)GetExtensionDelegateStatic("glGetnUniformfvEXT", typeof(Delegates.GetnUniformfvEXT));
                Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params);
            }
            internal static unsafe void Load_GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params)
            {
                Delegates.glGetnUniformivEXT = (Delegates.GetnUniformivEXT)GetExtensionDelegateStatic("glGetnUniformivEXT", typeof(Delegates.GetnUniformivEXT));
                Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params);
            }
            internal static unsafe void Load_GetPixelMapxv(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values)
            {
                Delegates.glGetPixelMapxv = (Delegates.GetPixelMapxv)GetExtensionDelegateStatic("glGetPixelMapxv", typeof(Delegates.GetPixelMapxv));
                Delegates.glGetPixelMapxv((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values);
            }
            internal static void Load_GetPointerv(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params)
            {
                Delegates.glGetPointerv = (Delegates.GetPointerv)GetExtensionDelegateStatic("glGetPointerv", typeof(Delegates.GetPointerv));
                Delegates.glGetPointerv((OpenTK.Graphics.ES11.GetPointervPName)pname, (IntPtr)@params);
            }
            internal static unsafe void Load_GetRenderbufferParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                Delegates.glGetRenderbufferParameterivOES = (Delegates.GetRenderbufferParameterivOES)GetExtensionDelegateStatic("glGetRenderbufferParameterivOES", typeof(Delegates.GetRenderbufferParameterivOES));
                Delegates.glGetRenderbufferParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            }
            internal static IntPtr Load_GetString(OpenTK.Graphics.ES11.StringName name)
            {
                Delegates.glGetString = (Delegates.GetString)GetExtensionDelegateStatic("glGetString", typeof(Delegates.GetString));
                return Delegates.glGetString((OpenTK.Graphics.ES11.StringName)name);
            }
            internal static unsafe void Load_GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values)
            {
                Delegates.glGetSyncivAPPLE = (Delegates.GetSyncivAPPLE)GetExtensionDelegateStatic("glGetSyncivAPPLE", typeof(Delegates.GetSyncivAPPLE));
                Delegates.glGetSyncivAPPLE((IntPtr)sync, (OpenTK.Graphics.ES11.All)pname, (Int32)bufSize, (Int32*)length, (Int32*)values);
            }
            internal static unsafe void Load_GetTexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params)
            {
                Delegates.glGetTexEnvfv = (Delegates.GetTexEnvfv)GetExtensionDelegateStatic("glGetTexEnvfv", typeof(Delegates.GetTexEnvfv));
                Delegates.glGetTexEnvfv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single*)@params);
            }
            internal static unsafe void Load_GetTexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params)
            {
                Delegates.glGetTexEnviv = (Delegates.GetTexEnviv)GetExtensionDelegateStatic("glGetTexEnviv", typeof(Delegates.GetTexEnviv));
                Delegates.glGetTexEnviv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32*)@params);
            }
            internal static unsafe void Load_GetTexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetTexEnvxv = (Delegates.GetTexEnvxv)GetExtensionDelegateStatic("glGetTexEnvxv", typeof(Delegates.GetTexEnvxv));
                Delegates.glGetTexEnvxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetTexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetTexEnvxvOES = (Delegates.GetTexEnvxvOES)GetExtensionDelegateStatic("glGetTexEnvxvOES", typeof(Delegates.GetTexEnvxvOES));
                Delegates.glGetTexEnvxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetTexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params)
            {
                Delegates.glGetTexGenfvOES = (Delegates.GetTexGenfvOES)GetExtensionDelegateStatic("glGetTexGenfvOES", typeof(Delegates.GetTexGenfvOES));
                Delegates.glGetTexGenfvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single*)@params);
            }
            internal static unsafe void Load_GetTexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                Delegates.glGetTexGenivOES = (Delegates.GetTexGenivOES)GetExtensionDelegateStatic("glGetTexGenivOES", typeof(Delegates.GetTexGenivOES));
                Delegates.glGetTexGenivOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            }
            internal static unsafe void Load_GetTexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetTexGenxvOES = (Delegates.GetTexGenxvOES)GetExtensionDelegateStatic("glGetTexGenxvOES", typeof(Delegates.GetTexGenxvOES));
                Delegates.glGetTexGenxvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetTexLevelParameterxvOES(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetTexLevelParameterxvOES = (Delegates.GetTexLevelParameterxvOES)GetExtensionDelegateStatic("glGetTexLevelParameterxvOES", typeof(Delegates.GetTexLevelParameterxvOES));
                Delegates.glGetTexLevelParameterxvOES((OpenTK.Graphics.ES11.All)target, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetTexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params)
            {
                Delegates.glGetTexParameterfv = (Delegates.GetTexParameterfv)GetExtensionDelegateStatic("glGetTexParameterfv", typeof(Delegates.GetTexParameterfv));
                Delegates.glGetTexParameterfv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Single*)@params);
            }
            internal static unsafe void Load_GetTexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params)
            {
                Delegates.glGetTexParameteriv = (Delegates.GetTexParameteriv)GetExtensionDelegateStatic("glGetTexParameteriv", typeof(Delegates.GetTexParameteriv));
                Delegates.glGetTexParameteriv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Int32*)@params);
            }
            internal static unsafe void Load_GetTexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetTexParameterxv = (Delegates.GetTexParameterxv)GetExtensionDelegateStatic("glGetTexParameterxv", typeof(Delegates.GetTexParameterxv));
                Delegates.glGetTexParameterxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_GetTexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                Delegates.glGetTexParameterxvOES = (Delegates.GetTexParameterxvOES)GetExtensionDelegateStatic("glGetTexParameterxvOES", typeof(Delegates.GetTexParameterxvOES));
                Delegates.glGetTexParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static void Load_Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode)
            {
                Delegates.glHint = (Delegates.Hint)GetExtensionDelegateStatic("glHint", typeof(Delegates.Hint));
                Delegates.glHint((OpenTK.Graphics.ES11.HintTarget)target, (OpenTK.Graphics.ES11.HintMode)mode);
            }
            internal static void Load_IndexxOES(int component)
            {
                Delegates.glIndexxOES = (Delegates.IndexxOES)GetExtensionDelegateStatic("glIndexxOES", typeof(Delegates.IndexxOES));
                Delegates.glIndexxOES((int)component);
            }
            internal static unsafe void Load_IndexxvOES(int* component)
            {
                Delegates.glIndexxvOES = (Delegates.IndexxvOES)GetExtensionDelegateStatic("glIndexxvOES", typeof(Delegates.IndexxvOES));
                Delegates.glIndexxvOES((int*)component);
            }
            internal static bool Load_IsBuffer(UInt32 buffer)
            {
                Delegates.glIsBuffer = (Delegates.IsBuffer)GetExtensionDelegateStatic("glIsBuffer", typeof(Delegates.IsBuffer));
                return Delegates.glIsBuffer((UInt32)buffer);
            }
            internal static bool Load_IsEnabled(OpenTK.Graphics.ES11.EnableCap cap)
            {
                Delegates.glIsEnabled = (Delegates.IsEnabled)GetExtensionDelegateStatic("glIsEnabled", typeof(Delegates.IsEnabled));
                return Delegates.glIsEnabled((OpenTK.Graphics.ES11.EnableCap)cap);
            }
            internal static bool Load_IsFenceNV(UInt32 fence)
            {
                Delegates.glIsFenceNV = (Delegates.IsFenceNV)GetExtensionDelegateStatic("glIsFenceNV", typeof(Delegates.IsFenceNV));
                return Delegates.glIsFenceNV((UInt32)fence);
            }
            internal static bool Load_IsFramebufferOES(UInt32 framebuffer)
            {
                Delegates.glIsFramebufferOES = (Delegates.IsFramebufferOES)GetExtensionDelegateStatic("glIsFramebufferOES", typeof(Delegates.IsFramebufferOES));
                return Delegates.glIsFramebufferOES((UInt32)framebuffer);
            }
            internal static bool Load_IsRenderbufferOES(UInt32 renderbuffer)
            {
                Delegates.glIsRenderbufferOES = (Delegates.IsRenderbufferOES)GetExtensionDelegateStatic("glIsRenderbufferOES", typeof(Delegates.IsRenderbufferOES));
                return Delegates.glIsRenderbufferOES((UInt32)renderbuffer);
            }
            internal static bool Load_IsSyncAPPLE(IntPtr sync)
            {
                Delegates.glIsSyncAPPLE = (Delegates.IsSyncAPPLE)GetExtensionDelegateStatic("glIsSyncAPPLE", typeof(Delegates.IsSyncAPPLE));
                return Delegates.glIsSyncAPPLE((IntPtr)sync);
            }
            internal static bool Load_IsTexture(UInt32 texture)
            {
                Delegates.glIsTexture = (Delegates.IsTexture)GetExtensionDelegateStatic("glIsTexture", typeof(Delegates.IsTexture));
                return Delegates.glIsTexture((UInt32)texture);
            }
            internal static bool Load_IsVertexArrayOES(UInt32 array)
            {
                Delegates.glIsVertexArrayOES = (Delegates.IsVertexArrayOES)GetExtensionDelegateStatic("glIsVertexArrayOES", typeof(Delegates.IsVertexArrayOES));
                return Delegates.glIsVertexArrayOES((UInt32)array);
            }
            internal static void Load_Lightf(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param)
            {
                Delegates.glLightf = (Delegates.Lightf)GetExtensionDelegateStatic("glLightf", typeof(Delegates.Lightf));
                Delegates.glLightf((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single)param);
            }
            internal static unsafe void Load_Lightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params)
            {
                Delegates.glLightfv = (Delegates.Lightfv)GetExtensionDelegateStatic("glLightfv", typeof(Delegates.Lightfv));
                Delegates.glLightfv((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single*)@params);
            }
            internal static void Load_LightModelf(OpenTK.Graphics.ES11.LightModelParameter pname, Single param)
            {
                Delegates.glLightModelf = (Delegates.LightModelf)GetExtensionDelegateStatic("glLightModelf", typeof(Delegates.LightModelf));
                Delegates.glLightModelf((OpenTK.Graphics.ES11.LightModelParameter)pname, (Single)param);
            }
            internal static unsafe void Load_LightModelfv(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params)
            {
                Delegates.glLightModelfv = (Delegates.LightModelfv)GetExtensionDelegateStatic("glLightModelfv", typeof(Delegates.LightModelfv));
                Delegates.glLightModelfv((OpenTK.Graphics.ES11.LightModelParameter)pname, (Single*)@params);
            }
            internal static void Load_LightModelx(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glLightModelx = (Delegates.LightModelx)GetExtensionDelegateStatic("glLightModelx", typeof(Delegates.LightModelx));
                Delegates.glLightModelx((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_LightModelxOES(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glLightModelxOES = (Delegates.LightModelxOES)GetExtensionDelegateStatic("glLightModelxOES", typeof(Delegates.LightModelxOES));
                Delegates.glLightModelxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_LightModelxv(OpenTK.Graphics.ES11.All pname, int* param)
            {
                Delegates.glLightModelxv = (Delegates.LightModelxv)GetExtensionDelegateStatic("glLightModelxv", typeof(Delegates.LightModelxv));
                Delegates.glLightModelxv((OpenTK.Graphics.ES11.All)pname, (int*)param);
            }
            internal static unsafe void Load_LightModelxvOES(OpenTK.Graphics.ES11.All pname, int* param)
            {
                Delegates.glLightModelxvOES = (Delegates.LightModelxvOES)GetExtensionDelegateStatic("glLightModelxvOES", typeof(Delegates.LightModelxvOES));
                Delegates.glLightModelxvOES((OpenTK.Graphics.ES11.All)pname, (int*)param);
            }
            internal static void Load_Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glLightx = (Delegates.Lightx)GetExtensionDelegateStatic("glLightx", typeof(Delegates.Lightx));
                Delegates.glLightx((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_LightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glLightxOES = (Delegates.LightxOES)GetExtensionDelegateStatic("glLightxOES", typeof(Delegates.LightxOES));
                Delegates.glLightxOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_Lightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glLightxv = (Delegates.Lightxv)GetExtensionDelegateStatic("glLightxv", typeof(Delegates.Lightxv));
                Delegates.glLightxv((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_LightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glLightxvOES = (Delegates.LightxvOES)GetExtensionDelegateStatic("glLightxvOES", typeof(Delegates.LightxvOES));
                Delegates.glLightxvOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static void Load_LineWidth(Single width)
            {
                Delegates.glLineWidth = (Delegates.LineWidth)GetExtensionDelegateStatic("glLineWidth", typeof(Delegates.LineWidth));
                Delegates.glLineWidth((Single)width);
            }
            internal static void Load_LineWidthx(int width)
            {
                Delegates.glLineWidthx = (Delegates.LineWidthx)GetExtensionDelegateStatic("glLineWidthx", typeof(Delegates.LineWidthx));
                Delegates.glLineWidthx((int)width);
            }
            internal static void Load_LineWidthxOES(int width)
            {
                Delegates.glLineWidthxOES = (Delegates.LineWidthxOES)GetExtensionDelegateStatic("glLineWidthxOES", typeof(Delegates.LineWidthxOES));
                Delegates.glLineWidthxOES((int)width);
            }
            internal static void Load_LoadIdentity()
            {
                Delegates.glLoadIdentity = (Delegates.LoadIdentity)GetExtensionDelegateStatic("glLoadIdentity", typeof(Delegates.LoadIdentity));
                Delegates.glLoadIdentity();
            }
            internal static unsafe void Load_LoadMatrixf(Single* m)
            {
                Delegates.glLoadMatrixf = (Delegates.LoadMatrixf)GetExtensionDelegateStatic("glLoadMatrixf", typeof(Delegates.LoadMatrixf));
                Delegates.glLoadMatrixf((Single*)m);
            }
            internal static unsafe void Load_LoadMatrixx(int* m)
            {
                Delegates.glLoadMatrixx = (Delegates.LoadMatrixx)GetExtensionDelegateStatic("glLoadMatrixx", typeof(Delegates.LoadMatrixx));
                Delegates.glLoadMatrixx((int*)m);
            }
            internal static unsafe void Load_LoadMatrixxOES(int* m)
            {
                Delegates.glLoadMatrixxOES = (Delegates.LoadMatrixxOES)GetExtensionDelegateStatic("glLoadMatrixxOES", typeof(Delegates.LoadMatrixxOES));
                Delegates.glLoadMatrixxOES((int*)m);
            }
            internal static void Load_LoadPaletteFromModelViewMatrixOES()
            {
                Delegates.glLoadPaletteFromModelViewMatrixOES = (Delegates.LoadPaletteFromModelViewMatrixOES)GetExtensionDelegateStatic("glLoadPaletteFromModelViewMatrixOES", typeof(Delegates.LoadPaletteFromModelViewMatrixOES));
                Delegates.glLoadPaletteFromModelViewMatrixOES();
            }
            internal static unsafe void Load_LoadTransposeMatrixxOES(int* m)
            {
                Delegates.glLoadTransposeMatrixxOES = (Delegates.LoadTransposeMatrixxOES)GetExtensionDelegateStatic("glLoadTransposeMatrixxOES", typeof(Delegates.LoadTransposeMatrixxOES));
                Delegates.glLoadTransposeMatrixxOES((int*)m);
            }
            internal static void Load_LogicOp(OpenTK.Graphics.ES11.LogicOp opcode)
            {
                Delegates.glLogicOp = (Delegates.LogicOp)GetExtensionDelegateStatic("glLogicOp", typeof(Delegates.LogicOp));
                Delegates.glLogicOp((OpenTK.Graphics.ES11.LogicOp)opcode);
            }
            internal static void Load_Map1xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points)
            {
                Delegates.glMap1xOES = (Delegates.Map1xOES)GetExtensionDelegateStatic("glMap1xOES", typeof(Delegates.Map1xOES));
                Delegates.glMap1xOES((OpenTK.Graphics.ES11.All)target, (int)u1, (int)u2, (Int32)stride, (Int32)order, (int)points);
            }
            internal static void Load_Map2xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points)
            {
                Delegates.glMap2xOES = (Delegates.Map2xOES)GetExtensionDelegateStatic("glMap2xOES", typeof(Delegates.Map2xOES));
                Delegates.glMap2xOES((OpenTK.Graphics.ES11.All)target, (int)u1, (int)u2, (Int32)ustride, (Int32)uorder, (int)v1, (int)v2, (Int32)vstride, (Int32)vorder, (int)points);
            }
            internal static IntPtr Load_MapBufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access)
            {
                Delegates.glMapBufferOES = (Delegates.MapBufferOES)GetExtensionDelegateStatic("glMapBufferOES", typeof(Delegates.MapBufferOES));
                return Delegates.glMapBufferOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)access);
            }
            internal static IntPtr Load_MapBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access)
            {
                Delegates.glMapBufferRangeEXT = (Delegates.MapBufferRangeEXT)GetExtensionDelegateStatic("glMapBufferRangeEXT", typeof(Delegates.MapBufferRangeEXT));
                return Delegates.glMapBufferRangeEXT((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)length, (UInt32)access);
            }
            internal static void Load_MapGrid1xOES(Int32 n, int u1, int u2)
            {
                Delegates.glMapGrid1xOES = (Delegates.MapGrid1xOES)GetExtensionDelegateStatic("glMapGrid1xOES", typeof(Delegates.MapGrid1xOES));
                Delegates.glMapGrid1xOES((Int32)n, (int)u1, (int)u2);
            }
            internal static void Load_MapGrid2xOES(Int32 n, int u1, int u2, int v1, int v2)
            {
                Delegates.glMapGrid2xOES = (Delegates.MapGrid2xOES)GetExtensionDelegateStatic("glMapGrid2xOES", typeof(Delegates.MapGrid2xOES));
                Delegates.glMapGrid2xOES((Int32)n, (int)u1, (int)u2, (int)v1, (int)v2);
            }
            internal static void Load_Materialf(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param)
            {
                Delegates.glMaterialf = (Delegates.Materialf)GetExtensionDelegateStatic("glMaterialf", typeof(Delegates.Materialf));
                Delegates.glMaterialf((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single)param);
            }
            internal static unsafe void Load_Materialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params)
            {
                Delegates.glMaterialfv = (Delegates.Materialfv)GetExtensionDelegateStatic("glMaterialfv", typeof(Delegates.Materialfv));
                Delegates.glMaterialfv((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single*)@params);
            }
            internal static void Load_Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glMaterialx = (Delegates.Materialx)GetExtensionDelegateStatic("glMaterialx", typeof(Delegates.Materialx));
                Delegates.glMaterialx((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_MaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glMaterialxOES = (Delegates.MaterialxOES)GetExtensionDelegateStatic("glMaterialxOES", typeof(Delegates.MaterialxOES));
                Delegates.glMaterialxOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_Materialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param)
            {
                Delegates.glMaterialxv = (Delegates.Materialxv)GetExtensionDelegateStatic("glMaterialxv", typeof(Delegates.Materialxv));
                Delegates.glMaterialxv((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)param);
            }
            internal static unsafe void Load_MaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param)
            {
                Delegates.glMaterialxvOES = (Delegates.MaterialxvOES)GetExtensionDelegateStatic("glMaterialxvOES", typeof(Delegates.MaterialxvOES));
                Delegates.glMaterialxvOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)param);
            }
            internal static void Load_MatrixIndexPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            {
                Delegates.glMatrixIndexPointerOES = (Delegates.MatrixIndexPointerOES)GetExtensionDelegateStatic("glMatrixIndexPointerOES", typeof(Delegates.MatrixIndexPointerOES));
                Delegates.glMatrixIndexPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer);
            }
            internal static void Load_MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode)
            {
                Delegates.glMatrixMode = (Delegates.MatrixMode)GetExtensionDelegateStatic("glMatrixMode", typeof(Delegates.MatrixMode));
                Delegates.glMatrixMode((OpenTK.Graphics.ES11.MatrixMode)mode);
            }
            internal static unsafe void Load_MultiDrawArraysEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount)
            {
                Delegates.glMultiDrawArraysEXT = (Delegates.MultiDrawArraysEXT)GetExtensionDelegateStatic("glMultiDrawArraysEXT", typeof(Delegates.MultiDrawArraysEXT));
                Delegates.glMultiDrawArraysEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)first, (Int32*)count, (Int32)primcount);
            }
            internal static unsafe void Load_MultiDrawElementsEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
            {
                Delegates.glMultiDrawElementsEXT = (Delegates.MultiDrawElementsEXT)GetExtensionDelegateStatic("glMultiDrawElementsEXT", typeof(Delegates.MultiDrawElementsEXT));
                Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices, (Int32)primcount);
            }
            internal static void Load_MultiTexCoord1bOES(OpenTK.Graphics.ES11.All texture, SByte s)
            {
                Delegates.glMultiTexCoord1bOES = (Delegates.MultiTexCoord1bOES)GetExtensionDelegateStatic("glMultiTexCoord1bOES", typeof(Delegates.MultiTexCoord1bOES));
                Delegates.glMultiTexCoord1bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s);
            }
            internal static unsafe void Load_MultiTexCoord1bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                Delegates.glMultiTexCoord1bvOES = (Delegates.MultiTexCoord1bvOES)GetExtensionDelegateStatic("glMultiTexCoord1bvOES", typeof(Delegates.MultiTexCoord1bvOES));
                Delegates.glMultiTexCoord1bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
            }
            internal static void Load_MultiTexCoord1xOES(OpenTK.Graphics.ES11.All texture, int s)
            {
                Delegates.glMultiTexCoord1xOES = (Delegates.MultiTexCoord1xOES)GetExtensionDelegateStatic("glMultiTexCoord1xOES", typeof(Delegates.MultiTexCoord1xOES));
                Delegates.glMultiTexCoord1xOES((OpenTK.Graphics.ES11.All)texture, (int)s);
            }
            internal static unsafe void Load_MultiTexCoord1xvOES(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                Delegates.glMultiTexCoord1xvOES = (Delegates.MultiTexCoord1xvOES)GetExtensionDelegateStatic("glMultiTexCoord1xvOES", typeof(Delegates.MultiTexCoord1xvOES));
                Delegates.glMultiTexCoord1xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
            }
            internal static void Load_MultiTexCoord2bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t)
            {
                Delegates.glMultiTexCoord2bOES = (Delegates.MultiTexCoord2bOES)GetExtensionDelegateStatic("glMultiTexCoord2bOES", typeof(Delegates.MultiTexCoord2bOES));
                Delegates.glMultiTexCoord2bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t);
            }
            internal static unsafe void Load_MultiTexCoord2bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                Delegates.glMultiTexCoord2bvOES = (Delegates.MultiTexCoord2bvOES)GetExtensionDelegateStatic("glMultiTexCoord2bvOES", typeof(Delegates.MultiTexCoord2bvOES));
                Delegates.glMultiTexCoord2bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
            }
            internal static void Load_MultiTexCoord2xOES(OpenTK.Graphics.ES11.All texture, int s, int t)
            {
                Delegates.glMultiTexCoord2xOES = (Delegates.MultiTexCoord2xOES)GetExtensionDelegateStatic("glMultiTexCoord2xOES", typeof(Delegates.MultiTexCoord2xOES));
                Delegates.glMultiTexCoord2xOES((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t);
            }
            internal static unsafe void Load_MultiTexCoord2xvOES(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                Delegates.glMultiTexCoord2xvOES = (Delegates.MultiTexCoord2xvOES)GetExtensionDelegateStatic("glMultiTexCoord2xvOES", typeof(Delegates.MultiTexCoord2xvOES));
                Delegates.glMultiTexCoord2xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
            }
            internal static void Load_MultiTexCoord3bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r)
            {
                Delegates.glMultiTexCoord3bOES = (Delegates.MultiTexCoord3bOES)GetExtensionDelegateStatic("glMultiTexCoord3bOES", typeof(Delegates.MultiTexCoord3bOES));
                Delegates.glMultiTexCoord3bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t, (SByte)r);
            }
            internal static unsafe void Load_MultiTexCoord3bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                Delegates.glMultiTexCoord3bvOES = (Delegates.MultiTexCoord3bvOES)GetExtensionDelegateStatic("glMultiTexCoord3bvOES", typeof(Delegates.MultiTexCoord3bvOES));
                Delegates.glMultiTexCoord3bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
            }
            internal static void Load_MultiTexCoord3xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r)
            {
                Delegates.glMultiTexCoord3xOES = (Delegates.MultiTexCoord3xOES)GetExtensionDelegateStatic("glMultiTexCoord3xOES", typeof(Delegates.MultiTexCoord3xOES));
                Delegates.glMultiTexCoord3xOES((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t, (int)r);
            }
            internal static unsafe void Load_MultiTexCoord3xvOES(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                Delegates.glMultiTexCoord3xvOES = (Delegates.MultiTexCoord3xvOES)GetExtensionDelegateStatic("glMultiTexCoord3xvOES", typeof(Delegates.MultiTexCoord3xvOES));
                Delegates.glMultiTexCoord3xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
            }
            internal static void Load_MultiTexCoord4bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q)
            {
                Delegates.glMultiTexCoord4bOES = (Delegates.MultiTexCoord4bOES)GetExtensionDelegateStatic("glMultiTexCoord4bOES", typeof(Delegates.MultiTexCoord4bOES));
                Delegates.glMultiTexCoord4bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t, (SByte)r, (SByte)q);
            }
            internal static unsafe void Load_MultiTexCoord4bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                Delegates.glMultiTexCoord4bvOES = (Delegates.MultiTexCoord4bvOES)GetExtensionDelegateStatic("glMultiTexCoord4bvOES", typeof(Delegates.MultiTexCoord4bvOES));
                Delegates.glMultiTexCoord4bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
            }
            internal static void Load_MultiTexCoord4f(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q)
            {
                Delegates.glMultiTexCoord4f = (Delegates.MultiTexCoord4f)GetExtensionDelegateStatic("glMultiTexCoord4f", typeof(Delegates.MultiTexCoord4f));
                Delegates.glMultiTexCoord4f((OpenTK.Graphics.ES11.TextureUnit)target, (Single)s, (Single)t, (Single)r, (Single)q);
            }
            internal static void Load_MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q)
            {
                Delegates.glMultiTexCoord4x = (Delegates.MultiTexCoord4x)GetExtensionDelegateStatic("glMultiTexCoord4x", typeof(Delegates.MultiTexCoord4x));
                Delegates.glMultiTexCoord4x((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t, (int)r, (int)q);
            }
            internal static void Load_MultiTexCoord4xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q)
            {
                Delegates.glMultiTexCoord4xOES = (Delegates.MultiTexCoord4xOES)GetExtensionDelegateStatic("glMultiTexCoord4xOES", typeof(Delegates.MultiTexCoord4xOES));
                Delegates.glMultiTexCoord4xOES((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t, (int)r, (int)q);
            }
            internal static unsafe void Load_MultiTexCoord4xvOES(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                Delegates.glMultiTexCoord4xvOES = (Delegates.MultiTexCoord4xvOES)GetExtensionDelegateStatic("glMultiTexCoord4xvOES", typeof(Delegates.MultiTexCoord4xvOES));
                Delegates.glMultiTexCoord4xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
            }
            internal static unsafe void Load_MultMatrixf(Single* m)
            {
                Delegates.glMultMatrixf = (Delegates.MultMatrixf)GetExtensionDelegateStatic("glMultMatrixf", typeof(Delegates.MultMatrixf));
                Delegates.glMultMatrixf((Single*)m);
            }
            internal static unsafe void Load_MultMatrixx(int* m)
            {
                Delegates.glMultMatrixx = (Delegates.MultMatrixx)GetExtensionDelegateStatic("glMultMatrixx", typeof(Delegates.MultMatrixx));
                Delegates.glMultMatrixx((int*)m);
            }
            internal static unsafe void Load_MultMatrixxOES(int* m)
            {
                Delegates.glMultMatrixxOES = (Delegates.MultMatrixxOES)GetExtensionDelegateStatic("glMultMatrixxOES", typeof(Delegates.MultMatrixxOES));
                Delegates.glMultMatrixxOES((int*)m);
            }
            internal static unsafe void Load_MultTransposeMatrixxOES(int* m)
            {
                Delegates.glMultTransposeMatrixxOES = (Delegates.MultTransposeMatrixxOES)GetExtensionDelegateStatic("glMultTransposeMatrixxOES", typeof(Delegates.MultTransposeMatrixxOES));
                Delegates.glMultTransposeMatrixxOES((int*)m);
            }
            internal static void Load_Normal3f(Single nx, Single ny, Single nz)
            {
                Delegates.glNormal3f = (Delegates.Normal3f)GetExtensionDelegateStatic("glNormal3f", typeof(Delegates.Normal3f));
                Delegates.glNormal3f((Single)nx, (Single)ny, (Single)nz);
            }
            internal static void Load_Normal3x(int nx, int ny, int nz)
            {
                Delegates.glNormal3x = (Delegates.Normal3x)GetExtensionDelegateStatic("glNormal3x", typeof(Delegates.Normal3x));
                Delegates.glNormal3x((int)nx, (int)ny, (int)nz);
            }
            internal static void Load_Normal3xOES(int nx, int ny, int nz)
            {
                Delegates.glNormal3xOES = (Delegates.Normal3xOES)GetExtensionDelegateStatic("glNormal3xOES", typeof(Delegates.Normal3xOES));
                Delegates.glNormal3xOES((int)nx, (int)ny, (int)nz);
            }
            internal static unsafe void Load_Normal3xvOES(int* coords)
            {
                Delegates.glNormal3xvOES = (Delegates.Normal3xvOES)GetExtensionDelegateStatic("glNormal3xvOES", typeof(Delegates.Normal3xvOES));
                Delegates.glNormal3xvOES((int*)coords);
            }
            internal static void Load_NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer)
            {
                Delegates.glNormalPointer = (Delegates.NormalPointer)GetExtensionDelegateStatic("glNormalPointer", typeof(Delegates.NormalPointer));
                Delegates.glNormalPointer((OpenTK.Graphics.ES11.NormalPointerType)type, (Int32)stride, (IntPtr)pointer);
            }
            internal static void Load_Orthof(Single l, Single r, Single b, Single t, Single n, Single f)
            {
                Delegates.glOrthof = (Delegates.Orthof)GetExtensionDelegateStatic("glOrthof", typeof(Delegates.Orthof));
                Delegates.glOrthof((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
            }
            internal static void Load_OrthofOES(Single l, Single r, Single b, Single t, Single n, Single f)
            {
                Delegates.glOrthofOES = (Delegates.OrthofOES)GetExtensionDelegateStatic("glOrthofOES", typeof(Delegates.OrthofOES));
                Delegates.glOrthofOES((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
            }
            internal static void Load_Orthox(int l, int r, int b, int t, int n, int f)
            {
                Delegates.glOrthox = (Delegates.Orthox)GetExtensionDelegateStatic("glOrthox", typeof(Delegates.Orthox));
                Delegates.glOrthox((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
            }
            internal static void Load_OrthoxOES(int l, int r, int b, int t, int n, int f)
            {
                Delegates.glOrthoxOES = (Delegates.OrthoxOES)GetExtensionDelegateStatic("glOrthoxOES", typeof(Delegates.OrthoxOES));
                Delegates.glOrthoxOES((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
            }
            internal static void Load_PassThroughxOES(int token)
            {
                Delegates.glPassThroughxOES = (Delegates.PassThroughxOES)GetExtensionDelegateStatic("glPassThroughxOES", typeof(Delegates.PassThroughxOES));
                Delegates.glPassThroughxOES((int)token);
            }
            internal static unsafe void Load_PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values)
            {
                Delegates.glPixelMapx = (Delegates.PixelMapx)GetExtensionDelegateStatic("glPixelMapx", typeof(Delegates.PixelMapx));
                Delegates.glPixelMapx((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values);
            }
            internal static void Load_PixelStorei(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param)
            {
                Delegates.glPixelStorei = (Delegates.PixelStorei)GetExtensionDelegateStatic("glPixelStorei", typeof(Delegates.PixelStorei));
                Delegates.glPixelStorei((OpenTK.Graphics.ES11.PixelStoreParameter)pname, (Int32)param);
            }
            internal static void Load_PixelStorex(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glPixelStorex = (Delegates.PixelStorex)GetExtensionDelegateStatic("glPixelStorex", typeof(Delegates.PixelStorex));
                Delegates.glPixelStorex((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_PixelTransferxOES(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glPixelTransferxOES = (Delegates.PixelTransferxOES)GetExtensionDelegateStatic("glPixelTransferxOES", typeof(Delegates.PixelTransferxOES));
                Delegates.glPixelTransferxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_PixelZoomxOES(int xfactor, int yfactor)
            {
                Delegates.glPixelZoomxOES = (Delegates.PixelZoomxOES)GetExtensionDelegateStatic("glPixelZoomxOES", typeof(Delegates.PixelZoomxOES));
                Delegates.glPixelZoomxOES((int)xfactor, (int)yfactor);
            }
            internal static void Load_PointParameterf(OpenTK.Graphics.ES11.All pname, Single param)
            {
                Delegates.glPointParameterf = (Delegates.PointParameterf)GetExtensionDelegateStatic("glPointParameterf", typeof(Delegates.PointParameterf));
                Delegates.glPointParameterf((OpenTK.Graphics.ES11.All)pname, (Single)param);
            }
            internal static unsafe void Load_PointParameterfv(OpenTK.Graphics.ES11.All pname, Single* @params)
            {
                Delegates.glPointParameterfv = (Delegates.PointParameterfv)GetExtensionDelegateStatic("glPointParameterfv", typeof(Delegates.PointParameterfv));
                Delegates.glPointParameterfv((OpenTK.Graphics.ES11.All)pname, (Single*)@params);
            }
            internal static void Load_PointParameterx(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glPointParameterx = (Delegates.PointParameterx)GetExtensionDelegateStatic("glPointParameterx", typeof(Delegates.PointParameterx));
                Delegates.glPointParameterx((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_PointParameterxOES(OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glPointParameterxOES = (Delegates.PointParameterxOES)GetExtensionDelegateStatic("glPointParameterxOES", typeof(Delegates.PointParameterxOES));
                Delegates.glPointParameterxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_PointParameterxv(OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glPointParameterxv = (Delegates.PointParameterxv)GetExtensionDelegateStatic("glPointParameterxv", typeof(Delegates.PointParameterxv));
                Delegates.glPointParameterxv((OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_PointParameterxvOES(OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glPointParameterxvOES = (Delegates.PointParameterxvOES)GetExtensionDelegateStatic("glPointParameterxvOES", typeof(Delegates.PointParameterxvOES));
                Delegates.glPointParameterxvOES((OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static void Load_PointSize(Single size)
            {
                Delegates.glPointSize = (Delegates.PointSize)GetExtensionDelegateStatic("glPointSize", typeof(Delegates.PointSize));
                Delegates.glPointSize((Single)size);
            }
            internal static void Load_PointSizePointerOES(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            {
                Delegates.glPointSizePointerOES = (Delegates.PointSizePointerOES)GetExtensionDelegateStatic("glPointSizePointerOES", typeof(Delegates.PointSizePointerOES));
                Delegates.glPointSizePointerOES((OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer);
            }
            internal static void Load_PointSizex(int size)
            {
                Delegates.glPointSizex = (Delegates.PointSizex)GetExtensionDelegateStatic("glPointSizex", typeof(Delegates.PointSizex));
                Delegates.glPointSizex((int)size);
            }
            internal static void Load_PointSizexOES(int size)
            {
                Delegates.glPointSizexOES = (Delegates.PointSizexOES)GetExtensionDelegateStatic("glPointSizexOES", typeof(Delegates.PointSizexOES));
                Delegates.glPointSizexOES((int)size);
            }
            internal static void Load_PolygonOffset(Single factor, Single units)
            {
                Delegates.glPolygonOffset = (Delegates.PolygonOffset)GetExtensionDelegateStatic("glPolygonOffset", typeof(Delegates.PolygonOffset));
                Delegates.glPolygonOffset((Single)factor, (Single)units);
            }
            internal static void Load_PolygonOffsetx(int factor, int units)
            {
                Delegates.glPolygonOffsetx = (Delegates.PolygonOffsetx)GetExtensionDelegateStatic("glPolygonOffsetx", typeof(Delegates.PolygonOffsetx));
                Delegates.glPolygonOffsetx((int)factor, (int)units);
            }
            internal static void Load_PolygonOffsetxOES(int factor, int units)
            {
                Delegates.glPolygonOffsetxOES = (Delegates.PolygonOffsetxOES)GetExtensionDelegateStatic("glPolygonOffsetxOES", typeof(Delegates.PolygonOffsetxOES));
                Delegates.glPolygonOffsetxOES((int)factor, (int)units);
            }
            internal static void Load_PopMatrix()
            {
                Delegates.glPopMatrix = (Delegates.PopMatrix)GetExtensionDelegateStatic("glPopMatrix", typeof(Delegates.PopMatrix));
                Delegates.glPopMatrix();
            }
            internal static unsafe void Load_PrioritizeTexturesxOES(Int32 n, UInt32* textures, int* priorities)
            {
                Delegates.glPrioritizeTexturesxOES = (Delegates.PrioritizeTexturesxOES)GetExtensionDelegateStatic("glPrioritizeTexturesxOES", typeof(Delegates.PrioritizeTexturesxOES));
                Delegates.glPrioritizeTexturesxOES((Int32)n, (UInt32*)textures, (int*)priorities);
            }
            internal static void Load_PushMatrix()
            {
                Delegates.glPushMatrix = (Delegates.PushMatrix)GetExtensionDelegateStatic("glPushMatrix", typeof(Delegates.PushMatrix));
                Delegates.glPushMatrix();
            }
            internal static unsafe Int32 Load_QueryMatrixxOES([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent)
            {
                Delegates.glQueryMatrixxOES = (Delegates.QueryMatrixxOES)GetExtensionDelegateStatic("glQueryMatrixxOES", typeof(Delegates.QueryMatrixxOES));
                return Delegates.glQueryMatrixxOES((int*)mantissa, (Int32*)exponent);
            }
            internal static void Load_RasterPos2xOES(int x, int y)
            {
                Delegates.glRasterPos2xOES = (Delegates.RasterPos2xOES)GetExtensionDelegateStatic("glRasterPos2xOES", typeof(Delegates.RasterPos2xOES));
                Delegates.glRasterPos2xOES((int)x, (int)y);
            }
            internal static unsafe void Load_RasterPos2xvOES(int* coords)
            {
                Delegates.glRasterPos2xvOES = (Delegates.RasterPos2xvOES)GetExtensionDelegateStatic("glRasterPos2xvOES", typeof(Delegates.RasterPos2xvOES));
                Delegates.glRasterPos2xvOES((int*)coords);
            }
            internal static void Load_RasterPos3xOES(int x, int y, int z)
            {
                Delegates.glRasterPos3xOES = (Delegates.RasterPos3xOES)GetExtensionDelegateStatic("glRasterPos3xOES", typeof(Delegates.RasterPos3xOES));
                Delegates.glRasterPos3xOES((int)x, (int)y, (int)z);
            }
            internal static unsafe void Load_RasterPos3xvOES(int* coords)
            {
                Delegates.glRasterPos3xvOES = (Delegates.RasterPos3xvOES)GetExtensionDelegateStatic("glRasterPos3xvOES", typeof(Delegates.RasterPos3xvOES));
                Delegates.glRasterPos3xvOES((int*)coords);
            }
            internal static void Load_RasterPos4xOES(int x, int y, int z, int w)
            {
                Delegates.glRasterPos4xOES = (Delegates.RasterPos4xOES)GetExtensionDelegateStatic("glRasterPos4xOES", typeof(Delegates.RasterPos4xOES));
                Delegates.glRasterPos4xOES((int)x, (int)y, (int)z, (int)w);
            }
            internal static unsafe void Load_RasterPos4xvOES(int* coords)
            {
                Delegates.glRasterPos4xvOES = (Delegates.RasterPos4xvOES)GetExtensionDelegateStatic("glRasterPos4xvOES", typeof(Delegates.RasterPos4xvOES));
                Delegates.glRasterPos4xvOES((int*)coords);
            }
            internal static void Load_ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data)
            {
                Delegates.glReadnPixelsEXT = (Delegates.ReadnPixelsEXT)GetExtensionDelegateStatic("glReadnPixelsEXT", typeof(Delegates.ReadnPixelsEXT));
                Delegates.glReadnPixelsEXT((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (Int32)bufSize, (IntPtr)data);
            }
            internal static void Load_ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels)
            {
                Delegates.glReadPixels = (Delegates.ReadPixels)GetExtensionDelegateStatic("glReadPixels", typeof(Delegates.ReadPixels));
                Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels);
            }
            internal static void Load_RectxOES(int x1, int y1, int x2, int y2)
            {
                Delegates.glRectxOES = (Delegates.RectxOES)GetExtensionDelegateStatic("glRectxOES", typeof(Delegates.RectxOES));
                Delegates.glRectxOES((int)x1, (int)y1, (int)x2, (int)y2);
            }
            internal static unsafe void Load_RectxvOES(int* v1, int* v2)
            {
                Delegates.glRectxvOES = (Delegates.RectxvOES)GetExtensionDelegateStatic("glRectxvOES", typeof(Delegates.RectxvOES));
                Delegates.glRectxvOES((int*)v1, (int*)v2);
            }
            internal static void Load_RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                Delegates.glRenderbufferStorageMultisampleAPPLE = (Delegates.RenderbufferStorageMultisampleAPPLE)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleAPPLE", typeof(Delegates.RenderbufferStorageMultisampleAPPLE));
                Delegates.glRenderbufferStorageMultisampleAPPLE((OpenTK.Graphics.ES11.All)target, (Int32)samples, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
            }
            internal static void Load_RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                Delegates.glRenderbufferStorageMultisampleEXT = (Delegates.RenderbufferStorageMultisampleEXT)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleEXT", typeof(Delegates.RenderbufferStorageMultisampleEXT));
                Delegates.glRenderbufferStorageMultisampleEXT((OpenTK.Graphics.ES11.All)target, (Int32)samples, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
            }
            internal static void Load_RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                Delegates.glRenderbufferStorageMultisampleIMG = (Delegates.RenderbufferStorageMultisampleIMG)GetExtensionDelegateStatic("glRenderbufferStorageMultisampleIMG", typeof(Delegates.RenderbufferStorageMultisampleIMG));
                Delegates.glRenderbufferStorageMultisampleIMG((OpenTK.Graphics.ES11.All)target, (Int32)samples, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
            }
            internal static void Load_RenderbufferStorageOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                Delegates.glRenderbufferStorageOES = (Delegates.RenderbufferStorageOES)GetExtensionDelegateStatic("glRenderbufferStorageOES", typeof(Delegates.RenderbufferStorageOES));
                Delegates.glRenderbufferStorageOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
            }
            internal static void Load_ResolveMultisampleFramebufferAPPLE()
            {
                Delegates.glResolveMultisampleFramebufferAPPLE = (Delegates.ResolveMultisampleFramebufferAPPLE)GetExtensionDelegateStatic("glResolveMultisampleFramebufferAPPLE", typeof(Delegates.ResolveMultisampleFramebufferAPPLE));
                Delegates.glResolveMultisampleFramebufferAPPLE();
            }
            internal static void Load_Rotatef(Single angle, Single x, Single y, Single z)
            {
                Delegates.glRotatef = (Delegates.Rotatef)GetExtensionDelegateStatic("glRotatef", typeof(Delegates.Rotatef));
                Delegates.glRotatef((Single)angle, (Single)x, (Single)y, (Single)z);
            }
            internal static void Load_Rotatex(int angle, int x, int y, int z)
            {
                Delegates.glRotatex = (Delegates.Rotatex)GetExtensionDelegateStatic("glRotatex", typeof(Delegates.Rotatex));
                Delegates.glRotatex((int)angle, (int)x, (int)y, (int)z);
            }
            internal static void Load_RotatexOES(int angle, int x, int y, int z)
            {
                Delegates.glRotatexOES = (Delegates.RotatexOES)GetExtensionDelegateStatic("glRotatexOES", typeof(Delegates.RotatexOES));
                Delegates.glRotatexOES((int)angle, (int)x, (int)y, (int)z);
            }
            internal static void Load_SampleCoverage(Single value, bool invert)
            {
                Delegates.glSampleCoverage = (Delegates.SampleCoverage)GetExtensionDelegateStatic("glSampleCoverage", typeof(Delegates.SampleCoverage));
                Delegates.glSampleCoverage((Single)value, (bool)invert);
            }
            internal static void Load_SampleCoverageOES(int value, bool invert)
            {
                Delegates.glSampleCoverageOES = (Delegates.SampleCoverageOES)GetExtensionDelegateStatic("glSampleCoverageOES", typeof(Delegates.SampleCoverageOES));
                Delegates.glSampleCoverageOES((int)value, (bool)invert);
            }
            internal static void Load_SampleCoveragex(int value, bool invert)
            {
                Delegates.glSampleCoveragex = (Delegates.SampleCoveragex)GetExtensionDelegateStatic("glSampleCoveragex", typeof(Delegates.SampleCoveragex));
                Delegates.glSampleCoveragex((int)value, (bool)invert);
            }
            internal static void Load_SampleCoveragexOES(int value, bool invert)
            {
                Delegates.glSampleCoveragexOES = (Delegates.SampleCoveragexOES)GetExtensionDelegateStatic("glSampleCoveragexOES", typeof(Delegates.SampleCoveragexOES));
                Delegates.glSampleCoveragexOES((int)value, (bool)invert);
            }
            internal static void Load_Scalef(Single x, Single y, Single z)
            {
                Delegates.glScalef = (Delegates.Scalef)GetExtensionDelegateStatic("glScalef", typeof(Delegates.Scalef));
                Delegates.glScalef((Single)x, (Single)y, (Single)z);
            }
            internal static void Load_Scalex(int x, int y, int z)
            {
                Delegates.glScalex = (Delegates.Scalex)GetExtensionDelegateStatic("glScalex", typeof(Delegates.Scalex));
                Delegates.glScalex((int)x, (int)y, (int)z);
            }
            internal static void Load_ScalexOES(int x, int y, int z)
            {
                Delegates.glScalexOES = (Delegates.ScalexOES)GetExtensionDelegateStatic("glScalexOES", typeof(Delegates.ScalexOES));
                Delegates.glScalexOES((int)x, (int)y, (int)z);
            }
            internal static void Load_Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
            {
                Delegates.glScissor = (Delegates.Scissor)GetExtensionDelegateStatic("glScissor", typeof(Delegates.Scissor));
                Delegates.glScissor((Int32)x, (Int32)y, (Int32)width, (Int32)height);
            }
            internal static void Load_SetFenceNV(UInt32 fence, OpenTK.Graphics.ES11.All condition)
            {
                Delegates.glSetFenceNV = (Delegates.SetFenceNV)GetExtensionDelegateStatic("glSetFenceNV", typeof(Delegates.SetFenceNV));
                Delegates.glSetFenceNV((UInt32)fence, (OpenTK.Graphics.ES11.All)condition);
            }
            internal static void Load_ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode)
            {
                Delegates.glShadeModel = (Delegates.ShadeModel)GetExtensionDelegateStatic("glShadeModel", typeof(Delegates.ShadeModel));
                Delegates.glShadeModel((OpenTK.Graphics.ES11.ShadingModel)mode);
            }
            internal static void Load_StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask)
            {
                Delegates.glStartTilingQCOM = (Delegates.StartTilingQCOM)GetExtensionDelegateStatic("glStartTilingQCOM", typeof(Delegates.StartTilingQCOM));
                Delegates.glStartTilingQCOM((UInt32)x, (UInt32)y, (UInt32)width, (UInt32)height, (UInt32)preserveMask);
            }
            internal static void Load_StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask)
            {
                Delegates.glStencilFunc = (Delegates.StencilFunc)GetExtensionDelegateStatic("glStencilFunc", typeof(Delegates.StencilFunc));
                Delegates.glStencilFunc((OpenTK.Graphics.ES11.StencilFunction)func, (Int32)@ref, (UInt32)mask);
            }
            internal static void Load_StencilMask(UInt32 mask)
            {
                Delegates.glStencilMask = (Delegates.StencilMask)GetExtensionDelegateStatic("glStencilMask", typeof(Delegates.StencilMask));
                Delegates.glStencilMask((UInt32)mask);
            }
            internal static void Load_StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass)
            {
                Delegates.glStencilOp = (Delegates.StencilOp)GetExtensionDelegateStatic("glStencilOp", typeof(Delegates.StencilOp));
                Delegates.glStencilOp((OpenTK.Graphics.ES11.StencilOp)fail, (OpenTK.Graphics.ES11.StencilOp)zfail, (OpenTK.Graphics.ES11.StencilOp)zpass);
            }
            internal static bool Load_TestFenceNV(UInt32 fence)
            {
                Delegates.glTestFenceNV = (Delegates.TestFenceNV)GetExtensionDelegateStatic("glTestFenceNV", typeof(Delegates.TestFenceNV));
                return Delegates.glTestFenceNV((UInt32)fence);
            }
            internal static void Load_TexCoord1bOES(SByte s)
            {
                Delegates.glTexCoord1bOES = (Delegates.TexCoord1bOES)GetExtensionDelegateStatic("glTexCoord1bOES", typeof(Delegates.TexCoord1bOES));
                Delegates.glTexCoord1bOES((SByte)s);
            }
            internal static unsafe void Load_TexCoord1bvOES(SByte* coords)
            {
                Delegates.glTexCoord1bvOES = (Delegates.TexCoord1bvOES)GetExtensionDelegateStatic("glTexCoord1bvOES", typeof(Delegates.TexCoord1bvOES));
                Delegates.glTexCoord1bvOES((SByte*)coords);
            }
            internal static void Load_TexCoord1xOES(int s)
            {
                Delegates.glTexCoord1xOES = (Delegates.TexCoord1xOES)GetExtensionDelegateStatic("glTexCoord1xOES", typeof(Delegates.TexCoord1xOES));
                Delegates.glTexCoord1xOES((int)s);
            }
            internal static unsafe void Load_TexCoord1xvOES(int* coords)
            {
                Delegates.glTexCoord1xvOES = (Delegates.TexCoord1xvOES)GetExtensionDelegateStatic("glTexCoord1xvOES", typeof(Delegates.TexCoord1xvOES));
                Delegates.glTexCoord1xvOES((int*)coords);
            }
            internal static void Load_TexCoord2bOES(SByte s, SByte t)
            {
                Delegates.glTexCoord2bOES = (Delegates.TexCoord2bOES)GetExtensionDelegateStatic("glTexCoord2bOES", typeof(Delegates.TexCoord2bOES));
                Delegates.glTexCoord2bOES((SByte)s, (SByte)t);
            }
            internal static unsafe void Load_TexCoord2bvOES(SByte* coords)
            {
                Delegates.glTexCoord2bvOES = (Delegates.TexCoord2bvOES)GetExtensionDelegateStatic("glTexCoord2bvOES", typeof(Delegates.TexCoord2bvOES));
                Delegates.glTexCoord2bvOES((SByte*)coords);
            }
            internal static void Load_TexCoord2xOES(int s, int t)
            {
                Delegates.glTexCoord2xOES = (Delegates.TexCoord2xOES)GetExtensionDelegateStatic("glTexCoord2xOES", typeof(Delegates.TexCoord2xOES));
                Delegates.glTexCoord2xOES((int)s, (int)t);
            }
            internal static unsafe void Load_TexCoord2xvOES(int* coords)
            {
                Delegates.glTexCoord2xvOES = (Delegates.TexCoord2xvOES)GetExtensionDelegateStatic("glTexCoord2xvOES", typeof(Delegates.TexCoord2xvOES));
                Delegates.glTexCoord2xvOES((int*)coords);
            }
            internal static void Load_TexCoord3bOES(SByte s, SByte t, SByte r)
            {
                Delegates.glTexCoord3bOES = (Delegates.TexCoord3bOES)GetExtensionDelegateStatic("glTexCoord3bOES", typeof(Delegates.TexCoord3bOES));
                Delegates.glTexCoord3bOES((SByte)s, (SByte)t, (SByte)r);
            }
            internal static unsafe void Load_TexCoord3bvOES(SByte* coords)
            {
                Delegates.glTexCoord3bvOES = (Delegates.TexCoord3bvOES)GetExtensionDelegateStatic("glTexCoord3bvOES", typeof(Delegates.TexCoord3bvOES));
                Delegates.glTexCoord3bvOES((SByte*)coords);
            }
            internal static void Load_TexCoord3xOES(int s, int t, int r)
            {
                Delegates.glTexCoord3xOES = (Delegates.TexCoord3xOES)GetExtensionDelegateStatic("glTexCoord3xOES", typeof(Delegates.TexCoord3xOES));
                Delegates.glTexCoord3xOES((int)s, (int)t, (int)r);
            }
            internal static unsafe void Load_TexCoord3xvOES(int* coords)
            {
                Delegates.glTexCoord3xvOES = (Delegates.TexCoord3xvOES)GetExtensionDelegateStatic("glTexCoord3xvOES", typeof(Delegates.TexCoord3xvOES));
                Delegates.glTexCoord3xvOES((int*)coords);
            }
            internal static void Load_TexCoord4bOES(SByte s, SByte t, SByte r, SByte q)
            {
                Delegates.glTexCoord4bOES = (Delegates.TexCoord4bOES)GetExtensionDelegateStatic("glTexCoord4bOES", typeof(Delegates.TexCoord4bOES));
                Delegates.glTexCoord4bOES((SByte)s, (SByte)t, (SByte)r, (SByte)q);
            }
            internal static unsafe void Load_TexCoord4bvOES(SByte* coords)
            {
                Delegates.glTexCoord4bvOES = (Delegates.TexCoord4bvOES)GetExtensionDelegateStatic("glTexCoord4bvOES", typeof(Delegates.TexCoord4bvOES));
                Delegates.glTexCoord4bvOES((SByte*)coords);
            }
            internal static void Load_TexCoord4xOES(int s, int t, int r, int q)
            {
                Delegates.glTexCoord4xOES = (Delegates.TexCoord4xOES)GetExtensionDelegateStatic("glTexCoord4xOES", typeof(Delegates.TexCoord4xOES));
                Delegates.glTexCoord4xOES((int)s, (int)t, (int)r, (int)q);
            }
            internal static unsafe void Load_TexCoord4xvOES(int* coords)
            {
                Delegates.glTexCoord4xvOES = (Delegates.TexCoord4xvOES)GetExtensionDelegateStatic("glTexCoord4xvOES", typeof(Delegates.TexCoord4xvOES));
                Delegates.glTexCoord4xvOES((int*)coords);
            }
            internal static void Load_TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer)
            {
                Delegates.glTexCoordPointer = (Delegates.TexCoordPointer)GetExtensionDelegateStatic("glTexCoordPointer", typeof(Delegates.TexCoordPointer));
                Delegates.glTexCoordPointer((Int32)size, (OpenTK.Graphics.ES11.TexCoordPointerType)type, (Int32)stride, (IntPtr)pointer);
            }
            internal static void Load_TexEnvf(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param)
            {
                Delegates.glTexEnvf = (Delegates.TexEnvf)GetExtensionDelegateStatic("glTexEnvf", typeof(Delegates.TexEnvf));
                Delegates.glTexEnvf((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single)param);
            }
            internal static unsafe void Load_TexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params)
            {
                Delegates.glTexEnvfv = (Delegates.TexEnvfv)GetExtensionDelegateStatic("glTexEnvfv", typeof(Delegates.TexEnvfv));
                Delegates.glTexEnvfv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single*)@params);
            }
            internal static void Load_TexEnvi(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param)
            {
                Delegates.glTexEnvi = (Delegates.TexEnvi)GetExtensionDelegateStatic("glTexEnvi", typeof(Delegates.TexEnvi));
                Delegates.glTexEnvi((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32)param);
            }
            internal static unsafe void Load_TexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params)
            {
                Delegates.glTexEnviv = (Delegates.TexEnviv)GetExtensionDelegateStatic("glTexEnviv", typeof(Delegates.TexEnviv));
                Delegates.glTexEnviv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32*)@params);
            }
            internal static void Load_TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glTexEnvx = (Delegates.TexEnvx)GetExtensionDelegateStatic("glTexEnvx", typeof(Delegates.TexEnvx));
                Delegates.glTexEnvx((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_TexEnvxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glTexEnvxOES = (Delegates.TexEnvxOES)GetExtensionDelegateStatic("glTexEnvxOES", typeof(Delegates.TexEnvxOES));
                Delegates.glTexEnvxOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_TexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glTexEnvxv = (Delegates.TexEnvxv)GetExtensionDelegateStatic("glTexEnvxv", typeof(Delegates.TexEnvxv));
                Delegates.glTexEnvxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_TexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glTexEnvxvOES = (Delegates.TexEnvxvOES)GetExtensionDelegateStatic("glTexEnvxvOES", typeof(Delegates.TexEnvxvOES));
                Delegates.glTexEnvxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static void Load_TexGenfOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param)
            {
                Delegates.glTexGenfOES = (Delegates.TexGenfOES)GetExtensionDelegateStatic("glTexGenfOES", typeof(Delegates.TexGenfOES));
                Delegates.glTexGenfOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single)param);
            }
            internal static unsafe void Load_TexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params)
            {
                Delegates.glTexGenfvOES = (Delegates.TexGenfvOES)GetExtensionDelegateStatic("glTexGenfvOES", typeof(Delegates.TexGenfvOES));
                Delegates.glTexGenfvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single*)@params);
            }
            internal static void Load_TexGeniOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param)
            {
                Delegates.glTexGeniOES = (Delegates.TexGeniOES)GetExtensionDelegateStatic("glTexGeniOES", typeof(Delegates.TexGeniOES));
                Delegates.glTexGeniOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32)param);
            }
            internal static unsafe void Load_TexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params)
            {
                Delegates.glTexGenivOES = (Delegates.TexGenivOES)GetExtensionDelegateStatic("glTexGenivOES", typeof(Delegates.TexGenivOES));
                Delegates.glTexGenivOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            }
            internal static void Load_TexGenxOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glTexGenxOES = (Delegates.TexGenxOES)GetExtensionDelegateStatic("glTexGenxOES", typeof(Delegates.TexGenxOES));
                Delegates.glTexGenxOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_TexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glTexGenxvOES = (Delegates.TexGenxvOES)GetExtensionDelegateStatic("glTexGenxvOES", typeof(Delegates.TexGenxvOES));
                Delegates.glTexGenxvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static void Load_TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels)
            {
                Delegates.glTexImage2D = (Delegates.TexImage2D)GetExtensionDelegateStatic("glTexImage2D", typeof(Delegates.TexImage2D));
                Delegates.glTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels);
            }
            internal static void Load_TexParameterf(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param)
            {
                Delegates.glTexParameterf = (Delegates.TexParameterf)GetExtensionDelegateStatic("glTexParameterf", typeof(Delegates.TexParameterf));
                Delegates.glTexParameterf((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Single)param);
            }
            internal static unsafe void Load_TexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params)
            {
                Delegates.glTexParameterfv = (Delegates.TexParameterfv)GetExtensionDelegateStatic("glTexParameterfv", typeof(Delegates.TexParameterfv));
                Delegates.glTexParameterfv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Single*)@params);
            }
            internal static void Load_TexParameteri(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param)
            {
                Delegates.glTexParameteri = (Delegates.TexParameteri)GetExtensionDelegateStatic("glTexParameteri", typeof(Delegates.TexParameteri));
                Delegates.glTexParameteri((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Int32)param);
            }
            internal static unsafe void Load_TexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params)
            {
                Delegates.glTexParameteriv = (Delegates.TexParameteriv)GetExtensionDelegateStatic("glTexParameteriv", typeof(Delegates.TexParameteriv));
                Delegates.glTexParameteriv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Int32*)@params);
            }
            internal static void Load_TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glTexParameterx = (Delegates.TexParameterx)GetExtensionDelegateStatic("glTexParameterx", typeof(Delegates.TexParameterx));
                Delegates.glTexParameterx((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static void Load_TexParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                Delegates.glTexParameterxOES = (Delegates.TexParameterxOES)GetExtensionDelegateStatic("glTexParameterxOES", typeof(Delegates.TexParameterxOES));
                Delegates.glTexParameterxOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
            }
            internal static unsafe void Load_TexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glTexParameterxv = (Delegates.TexParameterxv)GetExtensionDelegateStatic("glTexParameterxv", typeof(Delegates.TexParameterxv));
                Delegates.glTexParameterxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static unsafe void Load_TexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                Delegates.glTexParameterxvOES = (Delegates.TexParameterxvOES)GetExtensionDelegateStatic("glTexParameterxvOES", typeof(Delegates.TexParameterxvOES));
                Delegates.glTexParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            }
            internal static void Load_TexStorage1DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            {
                Delegates.glTexStorage1DEXT = (Delegates.TexStorage1DEXT)GetExtensionDelegateStatic("glTexStorage1DEXT", typeof(Delegates.TexStorage1DEXT));
                Delegates.glTexStorage1DEXT((OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width);
            }
            internal static void Load_TexStorage2DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                Delegates.glTexStorage2DEXT = (Delegates.TexStorage2DEXT)GetExtensionDelegateStatic("glTexStorage2DEXT", typeof(Delegates.TexStorage2DEXT));
                Delegates.glTexStorage2DEXT((OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
            }
            internal static void Load_TexStorage3DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            {
                Delegates.glTexStorage3DEXT = (Delegates.TexStorage3DEXT)GetExtensionDelegateStatic("glTexStorage3DEXT", typeof(Delegates.TexStorage3DEXT));
                Delegates.glTexStorage3DEXT((OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)depth);
            }
            internal static void Load_TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels)
            {
                Delegates.glTexSubImage2D = (Delegates.TexSubImage2D)GetExtensionDelegateStatic("glTexSubImage2D", typeof(Delegates.TexSubImage2D));
                Delegates.glTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels);
            }
            internal static void Load_TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            {
                Delegates.glTextureStorage1DEXT = (Delegates.TextureStorage1DEXT)GetExtensionDelegateStatic("glTextureStorage1DEXT", typeof(Delegates.TextureStorage1DEXT));
                Delegates.glTextureStorage1DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width);
            }
            internal static void Load_TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                Delegates.glTextureStorage2DEXT = (Delegates.TextureStorage2DEXT)GetExtensionDelegateStatic("glTextureStorage2DEXT", typeof(Delegates.TextureStorage2DEXT));
                Delegates.glTextureStorage2DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
            }
            internal static void Load_TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            {
                Delegates.glTextureStorage3DEXT = (Delegates.TextureStorage3DEXT)GetExtensionDelegateStatic("glTextureStorage3DEXT", typeof(Delegates.TextureStorage3DEXT));
                Delegates.glTextureStorage3DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)depth);
            }
            internal static void Load_Translatef(Single x, Single y, Single z)
            {
                Delegates.glTranslatef = (Delegates.Translatef)GetExtensionDelegateStatic("glTranslatef", typeof(Delegates.Translatef));
                Delegates.glTranslatef((Single)x, (Single)y, (Single)z);
            }
            internal static void Load_Translatex(int x, int y, int z)
            {
                Delegates.glTranslatex = (Delegates.Translatex)GetExtensionDelegateStatic("glTranslatex", typeof(Delegates.Translatex));
                Delegates.glTranslatex((int)x, (int)y, (int)z);
            }
            internal static void Load_TranslatexOES(int x, int y, int z)
            {
                Delegates.glTranslatexOES = (Delegates.TranslatexOES)GetExtensionDelegateStatic("glTranslatexOES", typeof(Delegates.TranslatexOES));
                Delegates.glTranslatexOES((int)x, (int)y, (int)z);
            }
            internal static bool Load_UnmapBufferOES(OpenTK.Graphics.ES11.All target)
            {
                Delegates.glUnmapBufferOES = (Delegates.UnmapBufferOES)GetExtensionDelegateStatic("glUnmapBufferOES", typeof(Delegates.UnmapBufferOES));
                return Delegates.glUnmapBufferOES((OpenTK.Graphics.ES11.All)target);
            }
            internal static void Load_Vertex2bOES(SByte x)
            {
                Delegates.glVertex2bOES = (Delegates.Vertex2bOES)GetExtensionDelegateStatic("glVertex2bOES", typeof(Delegates.Vertex2bOES));
                Delegates.glVertex2bOES((SByte)x);
            }
            internal static unsafe void Load_Vertex2bvOES(SByte* coords)
            {
                Delegates.glVertex2bvOES = (Delegates.Vertex2bvOES)GetExtensionDelegateStatic("glVertex2bvOES", typeof(Delegates.Vertex2bvOES));
                Delegates.glVertex2bvOES((SByte*)coords);
            }
            internal static void Load_Vertex2xOES(int x)
            {
                Delegates.glVertex2xOES = (Delegates.Vertex2xOES)GetExtensionDelegateStatic("glVertex2xOES", typeof(Delegates.Vertex2xOES));
                Delegates.glVertex2xOES((int)x);
            }
            internal static unsafe void Load_Vertex2xvOES(int* coords)
            {
                Delegates.glVertex2xvOES = (Delegates.Vertex2xvOES)GetExtensionDelegateStatic("glVertex2xvOES", typeof(Delegates.Vertex2xvOES));
                Delegates.glVertex2xvOES((int*)coords);
            }
            internal static void Load_Vertex3bOES(SByte x, SByte y)
            {
                Delegates.glVertex3bOES = (Delegates.Vertex3bOES)GetExtensionDelegateStatic("glVertex3bOES", typeof(Delegates.Vertex3bOES));
                Delegates.glVertex3bOES((SByte)x, (SByte)y);
            }
            internal static unsafe void Load_Vertex3bvOES(SByte* coords)
            {
                Delegates.glVertex3bvOES = (Delegates.Vertex3bvOES)GetExtensionDelegateStatic("glVertex3bvOES", typeof(Delegates.Vertex3bvOES));
                Delegates.glVertex3bvOES((SByte*)coords);
            }
            internal static void Load_Vertex3xOES(int x, int y)
            {
                Delegates.glVertex3xOES = (Delegates.Vertex3xOES)GetExtensionDelegateStatic("glVertex3xOES", typeof(Delegates.Vertex3xOES));
                Delegates.glVertex3xOES((int)x, (int)y);
            }
            internal static unsafe void Load_Vertex3xvOES(int* coords)
            {
                Delegates.glVertex3xvOES = (Delegates.Vertex3xvOES)GetExtensionDelegateStatic("glVertex3xvOES", typeof(Delegates.Vertex3xvOES));
                Delegates.glVertex3xvOES((int*)coords);
            }
            internal static void Load_Vertex4bOES(SByte x, SByte y, SByte z)
            {
                Delegates.glVertex4bOES = (Delegates.Vertex4bOES)GetExtensionDelegateStatic("glVertex4bOES", typeof(Delegates.Vertex4bOES));
                Delegates.glVertex4bOES((SByte)x, (SByte)y, (SByte)z);
            }
            internal static unsafe void Load_Vertex4bvOES(SByte* coords)
            {
                Delegates.glVertex4bvOES = (Delegates.Vertex4bvOES)GetExtensionDelegateStatic("glVertex4bvOES", typeof(Delegates.Vertex4bvOES));
                Delegates.glVertex4bvOES((SByte*)coords);
            }
            internal static void Load_Vertex4xOES(int x, int y, int z)
            {
                Delegates.glVertex4xOES = (Delegates.Vertex4xOES)GetExtensionDelegateStatic("glVertex4xOES", typeof(Delegates.Vertex4xOES));
                Delegates.glVertex4xOES((int)x, (int)y, (int)z);
            }
            internal static unsafe void Load_Vertex4xvOES(int* coords)
            {
                Delegates.glVertex4xvOES = (Delegates.Vertex4xvOES)GetExtensionDelegateStatic("glVertex4xvOES", typeof(Delegates.Vertex4xvOES));
                Delegates.glVertex4xvOES((int*)coords);
            }
            internal static void Load_VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer)
            {
                Delegates.glVertexPointer = (Delegates.VertexPointer)GetExtensionDelegateStatic("glVertexPointer", typeof(Delegates.VertexPointer));
                Delegates.glVertexPointer((Int32)size, (OpenTK.Graphics.ES11.VertexPointerType)type, (Int32)stride, (IntPtr)pointer);
            }
            internal static void Load_Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
            {
                Delegates.glViewport = (Delegates.Viewport)GetExtensionDelegateStatic("glViewport", typeof(Delegates.Viewport));
                Delegates.glViewport((Int32)x, (Int32)y, (Int32)width, (Int32)height);
            }
            internal static void Load_WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout)
            {
                Delegates.glWaitSyncAPPLE = (Delegates.WaitSyncAPPLE)GetExtensionDelegateStatic("glWaitSyncAPPLE", typeof(Delegates.WaitSyncAPPLE));
                Delegates.glWaitSyncAPPLE((IntPtr)sync, (UInt32)flags, (UInt64)timeout);
            }
            internal static void Load_WeightPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            {
                Delegates.glWeightPointerOES = (Delegates.WeightPointerOES)GetExtensionDelegateStatic("glWeightPointerOES", typeof(Delegates.WeightPointerOES));
                Delegates.glWeightPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer);
            }
        }
    }
}
