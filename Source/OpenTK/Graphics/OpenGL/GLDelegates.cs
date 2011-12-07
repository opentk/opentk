//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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



namespace OpenTK.Graphics.OpenGL
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
            internal delegate void Accum(OpenTK.Graphics.OpenGL.AccumOp op, Single value);
            internal static Accum glAccum;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveProgramEXT(UInt32 program);
            internal static ActiveProgramEXT glActiveProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgram glActiveShaderProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveStencilFaceEXT(OpenTK.Graphics.OpenGL.ExtStencilTwoSide face);
            internal static ActiveStencilFaceEXT glActiveStencilFaceEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(OpenTK.Graphics.OpenGL.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTextureARB(OpenTK.Graphics.OpenGL.TextureUnit texture);
            internal static ActiveTextureARB glActiveTextureARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveVaryingNV(UInt32 program, String name);
            internal static ActiveVaryingNV glActiveVaryingNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp1ATI(OpenTK.Graphics.OpenGL.AtiFragmentShader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            internal static AlphaFragmentOp1ATI glAlphaFragmentOp1ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp2ATI(OpenTK.Graphics.OpenGL.AtiFragmentShader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            internal static AlphaFragmentOp2ATI glAlphaFragmentOp2ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp3ATI(OpenTK.Graphics.OpenGL.AtiFragmentShader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            internal static AlphaFragmentOp3ATI glAlphaFragmentOp3ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFunc(OpenTK.Graphics.OpenGL.AlphaFunction func, Single @ref);
            internal static AlphaFunc glAlphaFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ApplyTextureEXT(OpenTK.Graphics.OpenGL.ExtLightTexture mode);
            internal static ApplyTextureEXT glApplyTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool AreProgramsResidentNV(Int32 n, UInt32* programs, [OutAttribute] bool* residences);
            internal unsafe static AreProgramsResidentNV glAreProgramsResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool AreTexturesResident(Int32 n, UInt32* textures, [OutAttribute] bool* residences);
            internal unsafe static AreTexturesResident glAreTexturesResident;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool AreTexturesResidentEXT(Int32 n, UInt32* textures, [OutAttribute] bool* residences);
            internal unsafe static AreTexturesResidentEXT glAreTexturesResidentEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElement(Int32 i);
            internal static ArrayElement glArrayElement;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElementEXT(Int32 i);
            internal static ArrayElementEXT glArrayElementEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayObjectATI(OpenTK.Graphics.OpenGL.EnableCap array, Int32 size, OpenTK.Graphics.OpenGL.AtiVertexArrayObject type, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static ArrayObjectATI glArrayObjectATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AsyncMarkerSGIX(UInt32 marker);
            internal static AsyncMarkerSGIX glAsyncMarkerSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachObjectARB(UInt32 containerObj, UInt32 obj);
            internal static AttachObjectARB glAttachObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Begin(OpenTK.Graphics.OpenGL.BeginMode mode);
            internal static Begin glBegin;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginConditionalRender(UInt32 id, OpenTK.Graphics.OpenGL.ConditionalRenderType mode);
            internal static BeginConditionalRender glBeginConditionalRender;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginConditionalRenderNV(UInt32 id, OpenTK.Graphics.OpenGL.NvConditionalRender mode);
            internal static BeginConditionalRenderNV glBeginConditionalRenderNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginFragmentShaderATI();
            internal static BeginFragmentShaderATI glBeginFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginOcclusionQueryNV(UInt32 id);
            internal static BeginOcclusionQueryNV glBeginOcclusionQueryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginPerfMonitorAMD(UInt32 monitor);
            internal static BeginPerfMonitorAMD glBeginPerfMonitorAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQuery(OpenTK.Graphics.OpenGL.QueryTarget target, UInt32 id);
            internal static BeginQuery glBeginQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryARB(OpenTK.Graphics.OpenGL.ArbOcclusionQuery target, UInt32 id);
            internal static BeginQueryARB glBeginQueryARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryIndexed(OpenTK.Graphics.OpenGL.QueryTarget target, UInt32 index, UInt32 id);
            internal static BeginQueryIndexed glBeginQueryIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedback(OpenTK.Graphics.OpenGL.BeginFeedbackMode primitiveMode);
            internal static BeginTransformFeedback glBeginTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedbackEXT(OpenTK.Graphics.OpenGL.ExtTransformFeedback primitiveMode);
            internal static BeginTransformFeedbackEXT glBeginTransformFeedbackEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedbackNV(OpenTK.Graphics.OpenGL.NvTransformFeedback primitiveMode);
            internal static BeginTransformFeedbackNV glBeginTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginVertexShaderEXT();
            internal static BeginVertexShaderEXT glBeginVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginVideoCaptureNV(UInt32 video_capture_slot);
            internal static BeginVideoCaptureNV glBeginVideoCaptureNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocationARB(UInt32 programObj, UInt32 index, String name);
            internal static BindAttribLocationARB glBindAttribLocationARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(OpenTK.Graphics.OpenGL.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferARB(OpenTK.Graphics.OpenGL.BufferTargetArb target, UInt32 buffer);
            internal static BindBufferARB glBindBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBase(OpenTK.Graphics.OpenGL.BufferTarget target, UInt32 index, UInt32 buffer);
            internal static BindBufferBase glBindBufferBase;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBaseEXT(OpenTK.Graphics.OpenGL.ExtTransformFeedback target, UInt32 index, UInt32 buffer);
            internal static BindBufferBaseEXT glBindBufferBaseEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBaseNV(OpenTK.Graphics.OpenGL.NvTransformFeedback target, UInt32 index, UInt32 buffer);
            internal static BindBufferBaseNV glBindBufferBaseNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferOffsetEXT(OpenTK.Graphics.OpenGL.ExtTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset);
            internal static BindBufferOffsetEXT glBindBufferOffsetEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferOffsetNV(OpenTK.Graphics.OpenGL.NvTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset);
            internal static BindBufferOffsetNV glBindBufferOffsetNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRange glBindBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRangeEXT(OpenTK.Graphics.OpenGL.ExtTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRangeEXT glBindBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRangeNV(OpenTK.Graphics.OpenGL.NvTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRangeNV glBindBufferRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocation(UInt32 program, UInt32 color, String name);
            internal static BindFragDataLocation glBindFragDataLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocationEXT(UInt32 program, UInt32 color, String name);
            internal static BindFragDataLocationEXT glBindFragDataLocationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            internal static BindFragDataLocationIndexed glBindFragDataLocationIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragmentShaderATI(UInt32 id);
            internal static BindFragmentShaderATI glBindFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebuffer(OpenTK.Graphics.OpenGL.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebufferEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebufferEXT glBindFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL.ExtShaderImageLoadStore access, Int32 format);
            internal static BindImageTextureEXT glBindImageTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindLightParameterEXT(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter value);
            internal static BindLightParameterEXT glBindLightParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindMaterialParameterEXT(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter value);
            internal static BindMaterialParameterEXT glBindMaterialParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindMultiTextureEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, UInt32 texture);
            internal static BindMultiTextureEXT glBindMultiTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindParameterEXT(OpenTK.Graphics.OpenGL.ExtVertexShader value);
            internal static BindParameterEXT glBindParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 program);
            internal static BindProgramARB glBindProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 id);
            internal static BindProgramNV glBindProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramPipeline(UInt32 pipeline);
            internal static BindProgramPipeline glBindProgramPipeline;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.OpenGL.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbufferEXT(OpenTK.Graphics.OpenGL.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbufferEXT glBindRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindSampler(UInt32 unit, UInt32 sampler);
            internal static BindSampler glBindSampler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTexGenParameterEXT(OpenTK.Graphics.OpenGL.TextureUnit unit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter value);
            internal static BindTexGenParameterEXT glBindTexGenParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(OpenTK.Graphics.OpenGL.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTextureEXT(OpenTK.Graphics.OpenGL.TextureTarget target, UInt32 texture);
            internal static BindTextureEXT glBindTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTextureUnitParameterEXT(OpenTK.Graphics.OpenGL.TextureUnit unit, OpenTK.Graphics.OpenGL.ExtVertexShader value);
            internal static BindTextureUnitParameterEXT glBindTextureUnitParameterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTransformFeedback(OpenTK.Graphics.OpenGL.TransformFeedbackTarget target, UInt32 id);
            internal static BindTransformFeedback glBindTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTransformFeedbackNV(OpenTK.Graphics.OpenGL.NvTransformFeedback2 target, UInt32 id);
            internal static BindTransformFeedbackNV glBindTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArray(UInt32 array);
            internal static BindVertexArray glBindVertexArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArrayAPPLE(UInt32 array);
            internal static BindVertexArrayAPPLE glBindVertexArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexShaderEXT(UInt32 id);
            internal static BindVertexShaderEXT glBindVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture frame_region, IntPtr offset);
            internal static BindVideoCaptureStreamBufferNV glBindVideoCaptureStreamBufferNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture frame_region, OpenTK.Graphics.OpenGL.NvVideoCapture target, UInt32 texture);
            internal static BindVideoCaptureStreamTextureNV glBindVideoCaptureStreamTextureNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3bEXT(SByte bx, SByte by, SByte bz);
            internal static Binormal3bEXT glBinormal3bEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3bvEXT(SByte* v);
            internal unsafe static Binormal3bvEXT glBinormal3bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3dEXT(Double bx, Double by, Double bz);
            internal static Binormal3dEXT glBinormal3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3dvEXT(Double* v);
            internal unsafe static Binormal3dvEXT glBinormal3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3fEXT(Single bx, Single by, Single bz);
            internal static Binormal3fEXT glBinormal3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3fvEXT(Single* v);
            internal unsafe static Binormal3fvEXT glBinormal3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3iEXT(Int32 bx, Int32 by, Int32 bz);
            internal static Binormal3iEXT glBinormal3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3ivEXT(Int32* v);
            internal unsafe static Binormal3ivEXT glBinormal3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3sEXT(Int16 bx, Int16 by, Int16 bz);
            internal static Binormal3sEXT glBinormal3sEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3svEXT(Int16* v);
            internal unsafe static Binormal3svEXT glBinormal3svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BinormalPointerEXT(OpenTK.Graphics.OpenGL.NormalPointerType type, Int32 stride, IntPtr pointer);
            internal static BinormalPointerEXT glBinormalPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
            internal unsafe static Bitmap glBitmap;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColorEXT(Single red, Single green, Single blue, Single alpha);
            internal static BlendColorEXT glBlendColorEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation(OpenTK.Graphics.OpenGL.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationEXT(OpenTK.Graphics.OpenGL.ExtBlendMinmax mode);
            internal static BlendEquationEXT glBlendEquationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationi(UInt32 buf, OpenTK.Graphics.OpenGL.Version40 mode);
            internal static BlendEquationi glBlendEquationi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationiARB(UInt32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend mode);
            internal static BlendEquationiARB glBlendEquationiARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationIndexedAMD(UInt32 buf, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend mode);
            internal static BlendEquationIndexedAMD glBlendEquationIndexedAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.OpenGL.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateEXT(OpenTK.Graphics.OpenGL.ExtBlendEquationSeparate modeRGB, OpenTK.Graphics.OpenGL.ExtBlendEquationSeparate modeAlpha);
            internal static BlendEquationSeparateEXT glBlendEquationSeparateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparatei glBlendEquationSeparatei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend modeRGB, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend modeAlpha);
            internal static BlendEquationSeparateiARB glBlendEquationSeparateiARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateIndexedAMD(UInt32 buf, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend modeRGB, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend modeAlpha);
            internal static BlendEquationSeparateIndexedAMD glBlendEquationSeparateIndexedAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(OpenTK.Graphics.OpenGL.BlendingFactorSrc sfactor, OpenTK.Graphics.OpenGL.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunci(UInt32 buf, OpenTK.Graphics.OpenGL.Version40 src, OpenTK.Graphics.OpenGL.Version40 dst);
            internal static BlendFunci glBlendFunci;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunciARB(UInt32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend src, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dst);
            internal static BlendFunciARB glBlendFunciARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncIndexedAMD(UInt32 buf, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend src, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend dst);
            internal static BlendFuncIndexedAMD glBlendFuncIndexedAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.OpenGL.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.OpenGL.BlendingFactorDest dfactorRGB, OpenTK.Graphics.OpenGL.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.OpenGL.BlendingFactorDest dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateEXT(OpenTK.Graphics.OpenGL.ExtBlendFuncSeparate sfactorRGB, OpenTK.Graphics.OpenGL.ExtBlendFuncSeparate dfactorRGB, OpenTK.Graphics.OpenGL.ExtBlendFuncSeparate sfactorAlpha, OpenTK.Graphics.OpenGL.ExtBlendFuncSeparate dfactorAlpha);
            internal static BlendFuncSeparateEXT glBlendFuncSeparateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL.Version40 srcRGB, OpenTK.Graphics.OpenGL.Version40 dstRGB, OpenTK.Graphics.OpenGL.Version40 srcAlpha, OpenTK.Graphics.OpenGL.Version40 dstAlpha);
            internal static BlendFuncSeparatei glBlendFuncSeparatei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend srcRGB, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dstRGB, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend srcAlpha, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dstAlpha);
            internal static BlendFuncSeparateiARB glBlendFuncSeparateiARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateIndexedAMD(UInt32 buf, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend srcRGB, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend dstRGB, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend srcAlpha, OpenTK.Graphics.OpenGL.AmdDrawBuffersBlend dstAlpha);
            internal static BlendFuncSeparateIndexedAMD glBlendFuncSeparateIndexedAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateINGR(OpenTK.Graphics.OpenGL.All sfactorRGB, OpenTK.Graphics.OpenGL.All dfactorRGB, OpenTK.Graphics.OpenGL.All sfactorAlpha, OpenTK.Graphics.OpenGL.All dfactorAlpha);
            internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.OpenGL.ClearBufferMask mask, OpenTK.Graphics.OpenGL.BlitFramebufferFilter filter);
            internal static BlitFramebuffer glBlitFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.OpenGL.ClearBufferMask mask, OpenTK.Graphics.OpenGL.ExtFramebufferBlit filter);
            internal static BlitFramebufferEXT glBlitFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferAddressRangeNV(OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory pname, UInt32 index, UInt64 address, IntPtr length);
            internal static BufferAddressRangeNV glBufferAddressRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL.BufferUsageHint usage);
            internal static BufferData glBufferData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferDataARB(OpenTK.Graphics.OpenGL.BufferTargetArb target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL.BufferUsageArb usage);
            internal static BufferDataARB glBufferDataARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferParameteriAPPLE(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferParameterApple pname, Int32 param);
            internal static BufferParameteriAPPLE glBufferParameteriAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubDataARB(OpenTK.Graphics.OpenGL.BufferTargetArb target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubDataARB glBufferSubDataARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CallList(UInt32 list);
            internal static CallList glCallList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CallLists(Int32 n, OpenTK.Graphics.OpenGL.ListNameType type, IntPtr lists);
            internal static CallLists glCallLists;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.OpenGL.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.FramebufferErrorCode CheckFramebufferStatusEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target);
            internal static CheckFramebufferStatusEXT glCheckFramebufferStatusEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.ExtDirectStateAccess CheckNamedFramebufferStatusEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferTarget target);
            internal static CheckNamedFramebufferStatusEXT glCheckNamedFramebufferStatusEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClampColor(OpenTK.Graphics.OpenGL.ClampColorTarget target, OpenTK.Graphics.OpenGL.ClampColorMode clamp);
            internal static ClampColor glClampColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClampColorARB(OpenTK.Graphics.OpenGL.ArbColorBufferFloat target, OpenTK.Graphics.OpenGL.ArbColorBufferFloat clamp);
            internal static ClampColorARB glClampColorARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(OpenTK.Graphics.OpenGL.ClearBufferMask mask);
            internal static Clear glClear;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearAccum(Single red, Single green, Single blue, Single alpha);
            internal static ClearAccum glClearAccum;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearBufferfi(OpenTK.Graphics.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            internal static ClearBufferfi glClearBufferfi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferfv(OpenTK.Graphics.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single* value);
            internal unsafe static ClearBufferfv glClearBufferfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferiv(OpenTK.Graphics.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32* value);
            internal unsafe static ClearBufferiv glClearBufferiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferuiv(OpenTK.Graphics.OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32* value);
            internal unsafe static ClearBufferuiv glClearBufferuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static ClearColorIiEXT glClearColorIiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            internal static ClearColorIuiEXT glClearColorIuiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepth(Double depth);
            internal static ClearDepth glClearDepth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthdNV(Double depth);
            internal static ClearDepthdNV glClearDepthdNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearIndex(Single c);
            internal static ClearIndex glClearIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTexture(OpenTK.Graphics.OpenGL.TextureUnit texture);
            internal static ClientActiveTexture glClientActiveTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTextureARB(OpenTK.Graphics.OpenGL.TextureUnit texture);
            internal static ClientActiveTextureARB glClientActiveTextureARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveVertexStreamATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream);
            internal static ClientActiveVertexStreamATI glClientActiveVertexStreamATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientAttribDefaultEXT(OpenTK.Graphics.OpenGL.ClientAttribMask mask);
            internal static ClientAttribDefaultEXT glClientAttribDefaultEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static ClientWaitSync glClientWaitSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlane(OpenTK.Graphics.OpenGL.ClipPlaneName plane, Double* equation);
            internal unsafe static ClipPlane glClipPlane;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3b(SByte red, SByte green, SByte blue);
            internal static Color3b glColor3b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3bv(SByte* v);
            internal unsafe static Color3bv glColor3bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3d(Double red, Double green, Double blue);
            internal static Color3d glColor3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3dv(Double* v);
            internal unsafe static Color3dv glColor3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3f(Single red, Single green, Single blue);
            internal static Color3f glColor3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fv(Single* v);
            internal unsafe static Color3fv glColor3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3fVertex3fSUN(Single r, Single g, Single b, Single x, Single y, Single z);
            internal static Color3fVertex3fSUN glColor3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fVertex3fvSUN(Single* c, Single* v);
            internal unsafe static Color3fVertex3fvSUN glColor3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3hNV(Half red, Half green, Half blue);
            internal static Color3hNV glColor3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3hvNV(Half* v);
            internal unsafe static Color3hvNV glColor3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3i(Int32 red, Int32 green, Int32 blue);
            internal static Color3i glColor3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3iv(Int32* v);
            internal unsafe static Color3iv glColor3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3s(Int16 red, Int16 green, Int16 blue);
            internal static Color3s glColor3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3sv(Int16* v);
            internal unsafe static Color3sv glColor3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ub(Byte red, Byte green, Byte blue);
            internal static Color3ub glColor3ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3ubv(Byte* v);
            internal unsafe static Color3ubv glColor3ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
            internal static Color3ui glColor3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3uiv(UInt32* v);
            internal unsafe static Color3uiv glColor3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3us(UInt16 red, UInt16 green, UInt16 blue);
            internal static Color3us glColor3us;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3usv(UInt16* v);
            internal unsafe static Color3usv glColor3usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
            internal static Color4b glColor4b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4bv(SByte* v);
            internal unsafe static Color4bv glColor4bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4d(Double red, Double green, Double blue, Double alpha);
            internal static Color4d glColor4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4dv(Double* v);
            internal unsafe static Color4dv glColor4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
            internal static Color4f glColor4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4fNormal3fVertex3fSUN(Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static Color4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fNormal3fVertex3fvSUN(Single* c, Single* n, Single* v);
            internal unsafe static Color4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fv(Single* v);
            internal unsafe static Color4fv glColor4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4hNV(Half red, Half green, Half blue, Half alpha);
            internal static Color4hNV glColor4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4hvNV(Half* v);
            internal unsafe static Color4hvNV glColor4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            internal static Color4i glColor4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4iv(Int32* v);
            internal unsafe static Color4iv glColor4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
            internal static Color4s glColor4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4sv(Int16* v);
            internal unsafe static Color4sv glColor4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            internal static Color4ub glColor4ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubv(Byte* v);
            internal unsafe static Color4ubv glColor4ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex2fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y);
            internal static Color4ubVertex2fSUN glColor4ubVertex2fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex2fvSUN(Byte* c, Single* v);
            internal unsafe static Color4ubVertex2fvSUN glColor4ubVertex2fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex3fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static Color4ubVertex3fSUN glColor4ubVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex3fvSUN(Byte* c, Single* v);
            internal unsafe static Color4ubVertex3fvSUN glColor4ubVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            internal static Color4ui glColor4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4uiv(UInt32* v);
            internal unsafe static Color4uiv glColor4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            internal static Color4us glColor4us;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4usv(UInt16* v);
            internal unsafe static Color4usv glColor4usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFormatNV(Int32 size, OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static ColorFormatNV glColorFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp1ATI(OpenTK.Graphics.OpenGL.AtiFragmentShader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            internal static ColorFragmentOp1ATI glColorFragmentOp1ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp2ATI(OpenTK.Graphics.OpenGL.AtiFragmentShader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            internal static ColorFragmentOp2ATI glColorFragmentOp2ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp3ATI(OpenTK.Graphics.OpenGL.AtiFragmentShader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            internal static ColorFragmentOp3ATI glColorFragmentOp3ATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaski(UInt32 index, bool r, bool g, bool b, bool a);
            internal static ColorMaski glColorMaski;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaskIndexedEXT(UInt32 index, bool r, bool g, bool b, bool a);
            internal static ColorMaskIndexedEXT glColorMaskIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.ColorMaterialParameter mode);
            internal static ColorMaterial glColorMaterial;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorP3ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 color);
            internal static ColorP3ui glColorP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorP3uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP3uiv glColorP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorP4ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 color);
            internal static ColorP4ui glColorP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorP4uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP4uiv glColorP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointer(Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, Int32 stride, IntPtr pointer);
            internal static ColorPointer glColorPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointerEXT(Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            internal static ColorPointerEXT glColorPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointerListIBM(Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static ColorPointerListIBM glColorPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointervINTEL(Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, IntPtr pointer);
            internal static ColorPointervINTEL glColorPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorSubTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, Int32 start, Int32 count, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr data);
            internal static ColorSubTable glColorSubTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorSubTableEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, Int32 start, Int32 count, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr data);
            internal static ColorSubTableEXT glColorSubTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr table);
            internal static ColorTable glColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTableEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalFormat, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr table);
            internal static ColorTableEXT glColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfv(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.ColorTableParameterPName pname, Single* @params);
            internal unsafe static ColorTableParameterfv glColorTableParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfvSGI(OpenTK.Graphics.OpenGL.SgiColorTable target, OpenTK.Graphics.OpenGL.SgiColorTable pname, Single* @params);
            internal unsafe static ColorTableParameterfvSGI glColorTableParameterfvSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameteriv(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.ColorTableParameterPName pname, Int32* @params);
            internal unsafe static ColorTableParameteriv glColorTableParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterivSGI(OpenTK.Graphics.OpenGL.SgiColorTable target, OpenTK.Graphics.OpenGL.SgiColorTable pname, Int32* @params);
            internal unsafe static ColorTableParameterivSGI glColorTableParameterivSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTableSGI(OpenTK.Graphics.OpenGL.SgiColorTable target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr table);
            internal static ColorTableSGI glColorTableSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerInputNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners portion, OpenTK.Graphics.OpenGL.NvRegisterCombiners variable, OpenTK.Graphics.OpenGL.NvRegisterCombiners input, OpenTK.Graphics.OpenGL.NvRegisterCombiners mapping, OpenTK.Graphics.OpenGL.NvRegisterCombiners componentUsage);
            internal static CombinerInputNV glCombinerInputNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerOutputNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners portion, OpenTK.Graphics.OpenGL.NvRegisterCombiners abOutput, OpenTK.Graphics.OpenGL.NvRegisterCombiners cdOutput, OpenTK.Graphics.OpenGL.NvRegisterCombiners sumOutput, OpenTK.Graphics.OpenGL.NvRegisterCombiners scale, OpenTK.Graphics.OpenGL.NvRegisterCombiners bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
            internal static CombinerOutputNV glCombinerOutputNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameterfNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, Single param);
            internal static CombinerParameterfNV glCombinerParameterfNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterfvNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, Single* @params);
            internal unsafe static CombinerParameterfvNV glCombinerParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameteriNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, Int32 param);
            internal static CombinerParameteriNV glCombinerParameteriNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterivNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, Int32* @params);
            internal unsafe static CombinerParameterivNV glCombinerParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerStageParameterfvNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners2 stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners2 pname, Single* @params);
            internal unsafe static CombinerStageParameterfvNV glCombinerStageParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShaderARB(UInt32 shaderObj);
            internal static CompileShaderARB glCompileShaderARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);
            internal unsafe static CompileShaderIncludeARB glCompileShaderIncludeARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexImage1DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);
            internal static CompressedMultiTexImage1DEXT glCompressedMultiTexImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexImage2DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);
            internal static CompressedMultiTexImage2DEXT glCompressedMultiTexImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexImage3DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);
            internal static CompressedMultiTexImage3DEXT glCompressedMultiTexImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexSubImage1DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr bits);
            internal static CompressedMultiTexSubImage1DEXT glCompressedMultiTexSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexSubImage2DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr bits);
            internal static CompressedMultiTexSubImage2DEXT glCompressedMultiTexSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexSubImage3DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr bits);
            internal static CompressedMultiTexSubImage3DEXT glCompressedMultiTexSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage1D glCompressedTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage1DARB(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage1DARB glCompressedTexImage1DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2DARB(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2DARB glCompressedTexImage2DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3DARB(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3DARB glCompressedTexImage3DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage1D glCompressedTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage1DARB(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage1DARB glCompressedTexSubImage1DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2DARB(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2DARB glCompressedTexSubImage2DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3DARB(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3DARB glCompressedTexSubImage3DARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureImage1DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);
            internal static CompressedTextureImage1DEXT glCompressedTextureImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureImage2DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);
            internal static CompressedTextureImage2DEXT glCompressedTextureImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureImage3DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);
            internal static CompressedTextureImage3DEXT glCompressedTextureImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureSubImage1DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr bits);
            internal static CompressedTextureSubImage1DEXT glCompressedTextureSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureSubImage2DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr bits);
            internal static CompressedTextureSubImage2DEXT glCompressedTextureSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureSubImage3DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, Int32 imageSize, IntPtr bits);
            internal static CompressedTextureSubImage3DEXT glCompressedTextureSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter1D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr image);
            internal static ConvolutionFilter1D glConvolutionFilter1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter1DEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr image);
            internal static ConvolutionFilter1DEXT glConvolutionFilter1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter2D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr image);
            internal static ConvolutionFilter2D glConvolutionFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter2DEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr image);
            internal static ConvolutionFilter2DEXT glConvolutionFilter2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterf(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, Single @params);
            internal static ConvolutionParameterf glConvolutionParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterfEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.ExtConvolution pname, Single @params);
            internal static ConvolutionParameterfEXT glConvolutionParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfv(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, Single* @params);
            internal unsafe static ConvolutionParameterfv glConvolutionParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfvEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.ExtConvolution pname, Single* @params);
            internal unsafe static ConvolutionParameterfvEXT glConvolutionParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteri(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, Int32 @params);
            internal static ConvolutionParameteri glConvolutionParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteriEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.ExtConvolution pname, Int32 @params);
            internal static ConvolutionParameteriEXT glConvolutionParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameteriv(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, Int32* @params);
            internal unsafe static ConvolutionParameteriv glConvolutionParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterivEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.ExtConvolution pname, Int32* @params);
            internal unsafe static ConvolutionParameterivEXT glConvolutionParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyBufferSubData(OpenTK.Graphics.OpenGL.BufferTarget readTarget, OpenTK.Graphics.OpenGL.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubData glCopyBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTable glCopyColorSubTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTableEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTableEXT glCopyColorSubTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTable glCopyColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTableSGI(OpenTK.Graphics.OpenGL.SgiColorTable target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTableSGI glCopyColorTableSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1DEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2DEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyImageSubDataNV(UInt32 srcName, OpenTK.Graphics.OpenGL.NvCopyImage srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenTK.Graphics.OpenGL.NvCopyImage dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);
            internal static CopyImageSubDataNV glCopyImageSubDataNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexImage1DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyMultiTexImage1DEXT glCopyMultiTexImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexImage2DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyMultiTexImage2DEXT glCopyMultiTexImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexSubImage1DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyMultiTexSubImage1DEXT glCopyMultiTexSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexSubImage2DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyMultiTexSubImage2DEXT glCopyMultiTexSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexSubImage3DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyMultiTexSubImage3DEXT glCopyMultiTexSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelCopyType type);
            internal static CopyPixels glCopyPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1D glCopyTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1DEXT glCopyTexImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2DEXT glCopyTexImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1D glCopyTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1DEXT glCopyTexSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2DEXT glCopyTexSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3DEXT glCopyTexSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureImage1DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTextureImage1DEXT glCopyTextureImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureImage2DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTextureImage2DEXT glCopyTextureImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureSubImage1DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTextureSubImage1DEXT glCopyTextureSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureSubImage2DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTextureSubImage2DEXT glCopyTextureSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureSubImage3DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTextureSubImage3DEXT glCopyTextureSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgramObjectARB();
            internal static CreateProgramObjectARB glCreateProgramObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader(OpenTK.Graphics.OpenGL.ShaderType type);
            internal static CreateShader glCreateShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderObjectARB(OpenTK.Graphics.OpenGL.ArbShaderObjects shaderType);
            internal static CreateShaderObjectARB glCreateShaderObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramEXT(OpenTK.Graphics.OpenGL.ExtSeparateShaderObjects type, String @string);
            internal static CreateShaderProgramEXT glCreateShaderProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramv(OpenTK.Graphics.OpenGL.ShaderType type, Int32 count, String[] strings);
            internal static CreateShaderProgramv glCreateShaderProgramv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateSyncFromCLeventARB(IntPtr context, IntPtr @event, UInt32 flags);
            internal static CreateSyncFromCLeventARB glCreateSyncFromCLeventARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(OpenTK.Graphics.OpenGL.CullFaceMode mode);
            internal static CullFace glCullFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterdvEXT(OpenTK.Graphics.OpenGL.ExtCullVertex pname, [OutAttribute] Double* @params);
            internal unsafe static CullParameterdvEXT glCullParameterdvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterfvEXT(OpenTK.Graphics.OpenGL.ExtCullVertex pname, [OutAttribute] Single* @params);
            internal unsafe static CullParameterfvEXT glCullParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CurrentPaletteMatrixARB(Int32 index);
            internal static CurrentPaletteMatrixARB glCurrentPaletteMatrixARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallbackAMD(DebugProcAmd callback, [OutAttribute] IntPtr userParam);
            internal static DebugMessageCallbackAMD glDebugMessageCallbackAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallbackARB(DebugProcArb callback, IntPtr userParam);
            internal static DebugMessageCallbackARB glDebugMessageCallbackARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageControlARB(OpenTK.Graphics.OpenGL.ArbDebugOutput source, OpenTK.Graphics.OpenGL.ArbDebugOutput type, OpenTK.Graphics.OpenGL.ArbDebugOutput severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlARB glDebugMessageControlARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageEnableAMD(OpenTK.Graphics.OpenGL.AmdDebugOutput category, OpenTK.Graphics.OpenGL.AmdDebugOutput severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageEnableAMD glDebugMessageEnableAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsertAMD(OpenTK.Graphics.OpenGL.AmdDebugOutput category, OpenTK.Graphics.OpenGL.AmdDebugOutput severity, UInt32 id, Int32 length, String buf);
            internal static DebugMessageInsertAMD glDebugMessageInsertAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsertARB(OpenTK.Graphics.OpenGL.ArbDebugOutput source, OpenTK.Graphics.OpenGL.ArbDebugOutput type, UInt32 id, OpenTK.Graphics.OpenGL.ArbDebugOutput severity, Int32 length, String buf);
            internal static DebugMessageInsertARB glDebugMessageInsertARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3dSGIX(OpenTK.Graphics.OpenGL.SgixPolynomialFfd target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double w1, Double w2, Int32 wstride, Int32 worder, Double* points);
            internal unsafe static DeformationMap3dSGIX glDeformationMap3dSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3fSGIX(OpenTK.Graphics.OpenGL.SgixPolynomialFfd target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single w1, Single w2, Int32 wstride, Int32 worder, Single* points);
            internal unsafe static DeformationMap3fSGIX glDeformationMap3fSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeformSGIX(UInt32 mask);
            internal static DeformSGIX glDeformSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
            internal static DeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffersARB(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffersARB glDeleteBuffersARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesAPPLE(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesAPPLE glDeleteFencesAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteFragmentShaderATI(UInt32 id);
            internal static DeleteFragmentShaderATI glDeleteFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffersEXT glDeleteFramebuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteLists(UInt32 list, Int32 range);
            internal static DeleteLists glDeleteLists;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteNamedStringARB(Int32 namelen, String name);
            internal static DeleteNamedStringARB glDeleteNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteNamesAMD(OpenTK.Graphics.OpenGL.AmdNameGenDelete identifier, UInt32 num, UInt32* names);
            internal unsafe static DeleteNamesAMD glDeleteNamesAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteObjectARB(UInt32 obj);
            internal static DeleteObjectARB glDeleteObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
            internal unsafe static DeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeletePerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            internal unsafe static DeletePerfMonitorsAMD glDeletePerfMonitorsAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramPipelines(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelines glDeleteProgramPipelines;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsARB(Int32 n, UInt32* programs);
            internal unsafe static DeleteProgramsARB glDeleteProgramsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsNV(Int32 n, UInt32* programs);
            internal unsafe static DeleteProgramsNV glDeleteProgramsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueriesARB(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueriesARB glDeleteQueriesARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffersEXT glDeleteRenderbuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteSamplers(Int32 count, UInt32* samplers);
            internal unsafe static DeleteSamplers glDeleteSamplers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteSync(IntPtr sync);
            internal static DeleteSync glDeleteSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTexturesEXT(Int32 n, UInt32* textures);
            internal unsafe static DeleteTexturesEXT glDeleteTexturesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTransformFeedbacks(Int32 n, UInt32* ids);
            internal unsafe static DeleteTransformFeedbacks glDeleteTransformFeedbacks;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTransformFeedbacksNV(Int32 n, UInt32* ids);
            internal unsafe static DeleteTransformFeedbacksNV glDeleteTransformFeedbacksNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArrays(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArrays glDeleteVertexArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteVertexShaderEXT(UInt32 id);
            internal static DeleteVertexShaderEXT glDeleteVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsdNV(Double zmin, Double zmax);
            internal static DepthBoundsdNV glDepthBoundsdNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsEXT(Double zmin, Double zmax);
            internal static DepthBoundsEXT glDepthBoundsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc(OpenTK.Graphics.OpenGL.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRange(Double near, Double far);
            internal static DepthRange glDepthRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DepthRangeArrayv(UInt32 first, Int32 count, Double* v);
            internal unsafe static DepthRangeArrayv glDepthRangeArrayv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangedNV(Double zNear, Double zFar);
            internal static DepthRangedNV glDepthRangedNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangeIndexed(UInt32 index, Double n, Double f);
            internal static DepthRangeIndexed glDepthRangeIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
            internal static DetachObjectARB glDetachObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DetailTexFuncSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 n, Single* points);
            internal unsafe static DetailTexFuncSGIS glDetailTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(OpenTK.Graphics.OpenGL.EnableCap cap);
            internal static Disable glDisable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientState(OpenTK.Graphics.OpenGL.ArrayCap array);
            internal static DisableClientState glDisableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientStateIndexedEXT(OpenTK.Graphics.OpenGL.EnableCap array, UInt32 index);
            internal static DisableClientStateIndexedEXT glDisableClientStateIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disablei(OpenTK.Graphics.OpenGL.IndexedEnableCap target, UInt32 index);
            internal static Disablei glDisablei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableIndexedEXT(OpenTK.Graphics.OpenGL.IndexedEnableCap target, UInt32 index);
            internal static DisableIndexedEXT glDisableIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVariantClientStateEXT(UInt32 id);
            internal static DisableVariantClientStateEXT glDisableVariantClientStateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribAPPLE(UInt32 index, OpenTK.Graphics.OpenGL.AppleVertexProgramEvaluators pname);
            internal static DisableVertexAttribAPPLE glDisableVertexAttribAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArrayARB(UInt32 index);
            internal static DisableVertexAttribArrayARB glDisableVertexAttribArrayARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysEXT(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 first, Int32 count);
            internal static DrawArraysEXT glDrawArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysIndirect(OpenTK.Graphics.OpenGL.ArbDrawIndirect mode, IntPtr indirect);
            internal static DrawArraysIndirect glDrawArraysIndirect;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstanced(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstanced glDrawArraysInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedARB(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedARB glDrawArraysInstancedARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedEXT(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 start, Int32 count, Int32 primcount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawBuffer(OpenTK.Graphics.OpenGL.DrawBufferMode mode);
            internal static DrawBuffer glDrawBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffers(Int32 n, OpenTK.Graphics.OpenGL.DrawBuffersEnum* bufs);
            internal unsafe static DrawBuffers glDrawBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersARB(Int32 n, OpenTK.Graphics.OpenGL.ArbDrawBuffers* bufs);
            internal unsafe static DrawBuffersARB glDrawBuffersARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersATI(Int32 n, OpenTK.Graphics.OpenGL.AtiDrawBuffers* bufs);
            internal unsafe static DrawBuffersATI glDrawBuffersATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayAPPLE(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 first, Int32 count);
            internal static DrawElementArrayAPPLE glDrawElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayATI(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 count);
            internal static DrawElementArrayATI glDrawElementArrayATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawElementsBaseVertex glDrawElementsBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsIndirect(OpenTK.Graphics.OpenGL.ArbDrawIndirect mode, OpenTK.Graphics.OpenGL.ArbDrawIndirect type, IntPtr indirect);
            internal static DrawElementsIndirect glDrawElementsIndirect;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstanced(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstanced glDrawElementsInstanced;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedARB(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedARB glDrawElementsInstancedARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex);
            internal static DrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedEXT(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawMeshArraysSUN(OpenTK.Graphics.OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 width);
            internal static DrawMeshArraysSUN glDrawMeshArraysSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawPixels(Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static DrawPixels glDrawPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayAPPLE(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
            internal static DrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayATI(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count);
            internal static DrawRangeElementArrayATI glDrawRangeElementArrayATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElements(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementsEXT(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices);
            internal static DrawRangeElementsEXT glDrawRangeElementsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedback(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 id);
            internal static DrawTransformFeedback glDrawTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedbackNV(OpenTK.Graphics.OpenGL.NvTransformFeedback2 mode, UInt32 id);
            internal static DrawTransformFeedbackNV glDrawTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedbackStream(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 id, UInt32 stream);
            internal static DrawTransformFeedbackStream glDrawTransformFeedbackStream;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlag(bool flag);
            internal static EdgeFlag glEdgeFlag;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlagFormatNV(Int32 stride);
            internal static EdgeFlagFormatNV glEdgeFlagFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlagPointer(Int32 stride, IntPtr pointer);
            internal static EdgeFlagPointer glEdgeFlagPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerEXT(Int32 stride, Int32 count, bool* pointer);
            internal unsafe static EdgeFlagPointerEXT glEdgeFlagPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerListIBM(Int32 stride, bool* pointer, Int32 ptrstride);
            internal unsafe static EdgeFlagPointerListIBM glEdgeFlagPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagv(bool* flag);
            internal unsafe static EdgeFlagv glEdgeFlagv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ElementPointerAPPLE(OpenTK.Graphics.OpenGL.AppleElementArray type, IntPtr pointer);
            internal static ElementPointerAPPLE glElementPointerAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ElementPointerATI(OpenTK.Graphics.OpenGL.AtiElementArray type, IntPtr pointer);
            internal static ElementPointerATI glElementPointerATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(OpenTK.Graphics.OpenGL.EnableCap cap);
            internal static Enable glEnable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientState(OpenTK.Graphics.OpenGL.ArrayCap array);
            internal static EnableClientState glEnableClientState;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientStateIndexedEXT(OpenTK.Graphics.OpenGL.EnableCap array, UInt32 index);
            internal static EnableClientStateIndexedEXT glEnableClientStateIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enablei(OpenTK.Graphics.OpenGL.IndexedEnableCap target, UInt32 index);
            internal static Enablei glEnablei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableIndexedEXT(OpenTK.Graphics.OpenGL.IndexedEnableCap target, UInt32 index);
            internal static EnableIndexedEXT glEnableIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVariantClientStateEXT(UInt32 id);
            internal static EnableVariantClientStateEXT glEnableVariantClientStateEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribAPPLE(UInt32 index, OpenTK.Graphics.OpenGL.AppleVertexProgramEvaluators pname);
            internal static EnableVertexAttribAPPLE glEnableVertexAttribAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArrayARB(UInt32 index);
            internal static EnableVertexAttribArrayARB glEnableVertexAttribArrayARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void End();
            internal static End glEnd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndConditionalRender();
            internal static EndConditionalRender glEndConditionalRender;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndConditionalRenderNV();
            internal static EndConditionalRenderNV glEndConditionalRenderNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndFragmentShaderATI();
            internal static EndFragmentShaderATI glEndFragmentShaderATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndList();
            internal static EndList glEndList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndOcclusionQueryNV();
            internal static EndOcclusionQueryNV glEndOcclusionQueryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndPerfMonitorAMD(UInt32 monitor);
            internal static EndPerfMonitorAMD glEndPerfMonitorAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQuery(OpenTK.Graphics.OpenGL.QueryTarget target);
            internal static EndQuery glEndQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryARB(OpenTK.Graphics.OpenGL.ArbOcclusionQuery target);
            internal static EndQueryARB glEndQueryARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryIndexed(OpenTK.Graphics.OpenGL.QueryTarget target, UInt32 index);
            internal static EndQueryIndexed glEndQueryIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedback();
            internal static EndTransformFeedback glEndTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedbackEXT();
            internal static EndTransformFeedbackEXT glEndTransformFeedbackEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedbackNV();
            internal static EndTransformFeedbackNV glEndTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndVertexShaderEXT();
            internal static EndVertexShaderEXT glEndVertexShaderEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndVideoCaptureNV(UInt32 video_capture_slot);
            internal static EndVideoCaptureNV glEndVideoCaptureNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1d(Double u);
            internal static EvalCoord1d glEvalCoord1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1dv(Double* u);
            internal unsafe static EvalCoord1dv glEvalCoord1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1f(Single u);
            internal static EvalCoord1f glEvalCoord1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1fv(Single* u);
            internal unsafe static EvalCoord1fv glEvalCoord1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2d(Double u, Double v);
            internal static EvalCoord2d glEvalCoord2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2dv(Double* u);
            internal unsafe static EvalCoord2dv glEvalCoord2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2f(Single u, Single v);
            internal static EvalCoord2f glEvalCoord2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2fv(Single* u);
            internal unsafe static EvalCoord2fv glEvalCoord2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMapsNV(OpenTK.Graphics.OpenGL.NvEvaluators target, OpenTK.Graphics.OpenGL.NvEvaluators mode);
            internal static EvalMapsNV glEvalMapsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh1(OpenTK.Graphics.OpenGL.MeshMode1 mode, Int32 i1, Int32 i2);
            internal static EvalMesh1 glEvalMesh1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh2(OpenTK.Graphics.OpenGL.MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
            internal static EvalMesh2 glEvalMesh2;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint1(Int32 i);
            internal static EvalPoint1 glEvalPoint1;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint2(Int32 i, Int32 j);
            internal static EvalPoint2 glEvalPoint2;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExecuteProgramNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 id, Single* @params);
            internal unsafe static ExecuteProgramNV glExecuteProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            internal static ExtractComponentEXT glExtractComponentEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FeedbackBuffer(Int32 size, OpenTK.Graphics.OpenGL.FeedbackType type, [OutAttribute] Single* buffer);
            internal unsafe static FeedbackBuffer glFeedbackBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr FenceSync(OpenTK.Graphics.OpenGL.ArbSync condition, UInt32 flags);
            internal static FenceSync glFenceSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinalCombinerInputNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners variable, OpenTK.Graphics.OpenGL.NvRegisterCombiners input, OpenTK.Graphics.OpenGL.NvRegisterCombiners mapping, OpenTK.Graphics.OpenGL.NvRegisterCombiners componentUsage);
            internal static FinalCombinerInputNV glFinalCombinerInputNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 FinishAsyncSGIX([OutAttribute] UInt32* markerp);
            internal unsafe static FinishAsyncSGIX glFinishAsyncSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceAPPLE(UInt32 fence);
            internal static FinishFenceAPPLE glFinishFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishObjectAPPLE(OpenTK.Graphics.OpenGL.AppleFence @object, Int32 name);
            internal static FinishObjectAPPLE glFinishObjectAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishTextureSUNX();
            internal static FinishTextureSUNX glFinishTextureSUNX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRange glFlushMappedBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRangeAPPLE(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, IntPtr size);
            internal static FlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, IntPtr length);
            internal static FlushMappedNamedBufferRangeEXT glFlushMappedNamedBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushPixelDataRangeNV(OpenTK.Graphics.OpenGL.NvPixelDataRange target);
            internal static FlushPixelDataRangeNV glFlushPixelDataRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushRasterSGIX();
            internal static FlushRasterSGIX glFlushRasterSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushVertexArrayRangeAPPLE(Int32 length, [OutAttribute] IntPtr pointer);
            internal static FlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushVertexArrayRangeNV();
            internal static FlushVertexArrayRangeNV glFlushVertexArrayRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordd(Double coord);
            internal static FogCoordd glFogCoordd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoorddEXT(Double coord);
            internal static FogCoorddEXT glFogCoorddEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddv(Double* coord);
            internal unsafe static FogCoorddv glFogCoorddv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddvEXT(Double* coord);
            internal unsafe static FogCoorddvEXT glFogCoorddvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordf(Single coord);
            internal static FogCoordf glFogCoordf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordfEXT(Single coord);
            internal static FogCoordfEXT glFogCoordfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordFormatNV(OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static FogCoordFormatNV glFogCoordFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfv(Single* coord);
            internal unsafe static FogCoordfv glFogCoordfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfvEXT(Single* coord);
            internal unsafe static FogCoordfvEXT glFogCoordfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordhNV(Half fog);
            internal static FogCoordhNV glFogCoordhNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordhvNV(Half* fog);
            internal unsafe static FogCoordhvNV glFogCoordhvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointer(OpenTK.Graphics.OpenGL.FogPointerType type, Int32 stride, IntPtr pointer);
            internal static FogCoordPointer glFogCoordPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointerEXT(OpenTK.Graphics.OpenGL.ExtFogCoord type, Int32 stride, IntPtr pointer);
            internal static FogCoordPointerEXT glFogCoordPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointerListIBM(OpenTK.Graphics.OpenGL.IbmVertexArrayLists type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static FogCoordPointerListIBM glFogCoordPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogf(OpenTK.Graphics.OpenGL.FogParameter pname, Single param);
            internal static Fogf glFogf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogFuncSGIS(Int32 n, Single* points);
            internal unsafe static FogFuncSGIS glFogFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogfv(OpenTK.Graphics.OpenGL.FogParameter pname, Single* @params);
            internal unsafe static Fogfv glFogfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogi(OpenTK.Graphics.OpenGL.FogParameter pname, Int32 param);
            internal static Fogi glFogi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogiv(OpenTK.Graphics.OpenGL.FogParameter pname, Int32* @params);
            internal unsafe static Fogiv glFogiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentColorMaterialSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter mode);
            internal static FragmentColorMaterialSGIX glFragmentColorMaterialSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightfSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Single param);
            internal static FragmentLightfSGIX glFragmentLightfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightfvSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Single* @params);
            internal unsafe static FragmentLightfvSGIX glFragmentLightfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightiSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Int32 param);
            internal static FragmentLightiSGIX glFragmentLightiSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightivSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Int32* @params);
            internal unsafe static FragmentLightivSGIX glFragmentLightivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModelfSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Single param);
            internal static FragmentLightModelfSGIX glFragmentLightModelfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelfvSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Single* @params);
            internal unsafe static FragmentLightModelfvSGIX glFragmentLightModelfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModeliSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Int32 param);
            internal static FragmentLightModeliSGIX glFragmentLightModeliSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelivSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Int32* @params);
            internal unsafe static FragmentLightModelivSGIX glFragmentLightModelivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialfSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Single param);
            internal static FragmentMaterialfSGIX glFragmentMaterialfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialfvSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Single* @params);
            internal unsafe static FragmentMaterialfvSGIX glFragmentMaterialfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialiSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Int32 param);
            internal static FragmentMaterialiSGIX glFragmentMaterialiSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialivSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Int32* @params);
            internal unsafe static FragmentMaterialivSGIX glFragmentMaterialivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferDrawBufferEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.DrawBufferMode mode);
            internal static FramebufferDrawBufferEXT glFramebufferDrawBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FramebufferDrawBuffersEXT(UInt32 framebuffer, Int32 n, OpenTK.Graphics.OpenGL.DrawBufferMode* bufs);
            internal unsafe static FramebufferDrawBuffersEXT glFramebufferDrawBuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferReadBufferEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.ReadBufferMode mode);
            internal static FramebufferReadBufferEXT glFramebufferReadBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbufferEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbufferEXT glFramebufferRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            internal static FramebufferTexture glFramebufferTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture1D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture1D glFramebufferTexture1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture1DEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture1DEXT glFramebufferTexture1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2DEXT glFramebufferTexture2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3D glFramebufferTexture3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3DEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3DEXT glFramebufferTexture3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureARB(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            internal static FramebufferTextureARB glFramebufferTextureARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            internal static FramebufferTextureEXT glFramebufferTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureFaceARB(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL.TextureTarget face);
            internal static FramebufferTextureFaceARB glFramebufferTextureFaceARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureFaceEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL.TextureTarget face);
            internal static FramebufferTextureFaceEXT glFramebufferTextureFaceEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayer(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayer glFramebufferTextureLayer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayerARB(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayerARB glFramebufferTextureLayerARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayerEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayerEXT glFramebufferTextureLayerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrameTerminatorGREMEDY();
            internal static FrameTerminatorGREMEDY glFrameTerminatorGREMEDY;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrameZoomSGIX(Int32 factor);
            internal static FrameZoomSGIX glFrameZoomSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FreeObjectBufferATI(UInt32 buffer);
            internal static FreeObjectBufferATI glFreeObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(OpenTK.Graphics.OpenGL.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static Frustum glFrustum;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenAsyncMarkersSGIX(Int32 range);
            internal static GenAsyncMarkersSGIX glGenAsyncMarkersSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffersARB(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffersARB glGenBuffersARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmap(OpenTK.Graphics.OpenGL.GenerateMipmapTarget target);
            internal static GenerateMipmap glGenerateMipmap;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmapEXT(OpenTK.Graphics.OpenGL.GenerateMipmapTarget target);
            internal static GenerateMipmapEXT glGenerateMipmapEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMultiTexMipmapEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target);
            internal static GenerateMultiTexMipmapEXT glGenerateMultiTexMipmapEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateTextureMipmapEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target);
            internal static GenerateTextureMipmapEXT glGenerateTextureMipmapEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesAPPLE(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesAPPLE glGenFencesAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenFragmentShadersATI(UInt32 range);
            internal static GenFragmentShadersATI glGenFragmentShadersATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffersEXT(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffersEXT glGenFramebuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenLists(Int32 range);
            internal static GenLists glGenLists;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenNamesAMD(OpenTK.Graphics.OpenGL.AmdNameGenDelete identifier, UInt32 num, [OutAttribute] UInt32* names);
            internal unsafe static GenNamesAMD glGenNamesAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenOcclusionQueriesNV(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenOcclusionQueriesNV glGenOcclusionQueriesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenPerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            internal unsafe static GenPerfMonitorsAMD glGenPerfMonitorsAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramPipelines(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelines glGenProgramPipelines;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsARB(Int32 n, [OutAttribute] UInt32* programs);
            internal unsafe static GenProgramsARB glGenProgramsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsNV(Int32 n, [OutAttribute] UInt32* programs);
            internal unsafe static GenProgramsNV glGenProgramsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueries glGenQueries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueriesARB(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueriesARB glGenQueriesARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffersEXT(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffersEXT glGenRenderbuffersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenSamplers(Int32 count, [OutAttribute] UInt32* samplers);
            internal unsafe static GenSamplers glGenSamplers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenSymbolsEXT(OpenTK.Graphics.OpenGL.ExtVertexShader datatype, OpenTK.Graphics.OpenGL.ExtVertexShader storagetype, OpenTK.Graphics.OpenGL.ExtVertexShader range, UInt32 components);
            internal static GenSymbolsEXT glGenSymbolsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTexturesEXT(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTexturesEXT glGenTexturesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacks glGenTransformFeedbacks;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTransformFeedbacksNV(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacksNV glGenTransformFeedbacksNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArrays glGenVertexArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArraysAPPLE(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysAPPLE glGenVertexArraysAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenVertexShadersEXT(UInt32 range);
            internal static GenVertexShadersEXT glGenVertexShadersEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL.ArbVertexShader* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttribARB glGetActiveAttribARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineName(UInt32 program, OpenTK.Graphics.OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineName glGetActiveSubroutineName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineUniformiv(UInt32 program, OpenTK.Graphics.OpenGL.ShaderType shadertype, UInt32 index, OpenTK.Graphics.OpenGL.ActiveSubroutineUniformParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineUniformName(UInt32 program, OpenTK.Graphics.OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineUniformName glGetActiveSubroutineUniformName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL.ArbShaderObjects* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniformARB glGetActiveUniformARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName);
            internal unsafe static GetActiveUniformName glGetActiveUniformName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.OpenGL.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL.NvTransformFeedback* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveVaryingNV glGetActiveVaryingNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectfvATI(OpenTK.Graphics.OpenGL.EnableCap array, OpenTK.Graphics.OpenGL.AtiVertexArrayObject pname, [OutAttribute] Single* @params);
            internal unsafe static GetArrayObjectfvATI glGetArrayObjectfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectivATI(OpenTK.Graphics.OpenGL.EnableCap array, OpenTK.Graphics.OpenGL.AtiVertexArrayObject pname, [OutAttribute] Int32* @params);
            internal unsafe static GetArrayObjectivATI glGetArrayObjectivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* obj);
            internal unsafe static GetAttachedObjectsARB glGetAttachedObjectsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* obj);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocationARB(UInt32 programObj, String name);
            internal static GetAttribLocationARB glGetAttribLocationARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleani_v(OpenTK.Graphics.OpenGL.GetIndexedPName target, UInt32 index, [OutAttribute] bool* data);
            internal unsafe static GetBooleani_v glGetBooleani_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanIndexedvEXT(OpenTK.Graphics.OpenGL.ExtDrawBuffers2 target, UInt32 index, [OutAttribute] bool* data);
            internal unsafe static GetBooleanIndexedvEXT glGetBooleanIndexedvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute] bool* @params);
            internal unsafe static GetBooleanv glGetBooleanv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteri64v(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferParameterName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameterivARB(OpenTK.Graphics.OpenGL.ArbVertexBufferObject target, OpenTK.Graphics.OpenGL.BufferParameterNameArb pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameterivARB glGetBufferParameterivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameterui64vNV(OpenTK.Graphics.OpenGL.NvShaderBufferLoad target, OpenTK.Graphics.OpenGL.NvShaderBufferLoad pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetBufferParameterui64vNV glGetBufferParameterui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointerv(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointervARB(OpenTK.Graphics.OpenGL.ArbVertexBufferObject target, OpenTK.Graphics.OpenGL.BufferPointerNameArb pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervARB glGetBufferPointervARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferSubData(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            internal static GetBufferSubData glGetBufferSubData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferSubDataARB(OpenTK.Graphics.OpenGL.BufferTargetArb target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            internal static GetBufferSubDataARB glGetBufferSubDataARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlane(OpenTK.Graphics.OpenGL.ClipPlaneName plane, [OutAttribute] Double* equation);
            internal unsafe static GetClipPlane glGetClipPlane;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr table);
            internal static GetColorTable glGetColorTable;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTableEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr data);
            internal static GetColorTableEXT glGetColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfv(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfvEXT glGetColorTableParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvSGI(OpenTK.Graphics.OpenGL.SgiColorTable target, OpenTK.Graphics.OpenGL.SgiColorTable pname, [OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfvSGI glGetColorTableParameterfvSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameteriv(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameterivEXT glGetColorTableParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivSGI(OpenTK.Graphics.OpenGL.SgiColorTable target, OpenTK.Graphics.OpenGL.SgiColorTable pname, [OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameterivSGI glGetColorTableParameterivSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTableSGI(OpenTK.Graphics.OpenGL.SgiColorTable target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr table);
            internal static GetColorTableSGI glGetColorTableSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterfvNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners portion, OpenTK.Graphics.OpenGL.NvRegisterCombiners variable, OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, [OutAttribute] Single* @params);
            internal unsafe static GetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterivNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners portion, OpenTK.Graphics.OpenGL.NvRegisterCombiners variable, OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, [OutAttribute] Int32* @params);
            internal unsafe static GetCombinerInputParameterivNV glGetCombinerInputParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterfvNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners portion, OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, [OutAttribute] Single* @params);
            internal unsafe static GetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterivNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners portion, OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, [OutAttribute] Int32* @params);
            internal unsafe static GetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerStageParameterfvNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners2 stage, OpenTK.Graphics.OpenGL.NvRegisterCombiners2 pname, [OutAttribute] Single* @params);
            internal unsafe static GetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedMultiTexImageEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 lod, [OutAttribute] IntPtr img);
            internal static GetCompressedMultiTexImageEXT glGetCompressedMultiTexImageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTexImage(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            internal static GetCompressedTexImage glGetCompressedTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTexImageARB(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            internal static GetCompressedTexImageARB glGetCompressedTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTextureImageEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 lod, [OutAttribute] IntPtr img);
            internal static GetCompressedTextureImageEXT glGetCompressedTextureImageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetConvolutionFilter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr image);
            internal static GetConvolutionFilter glGetConvolutionFilter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetConvolutionFilterEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr image);
            internal static GetConvolutionFilterEXT glGetConvolutionFilterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfv(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.GetConvolutionParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfvEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.ExtConvolution pname, [OutAttribute] Single* @params);
            internal unsafe static GetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameteriv(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.GetConvolutionParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterivEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.ExtConvolution pname, [OutAttribute] Int32* @params);
            internal unsafe static GetConvolutionParameterivEXT glGetConvolutionParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLogAMD(UInt32 count, Int32 bufsize, [OutAttribute] OpenTK.Graphics.OpenGL.AmdDebugOutput* categories, [OutAttribute] UInt32* severities, [OutAttribute] UInt32* ids, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder message);
            internal unsafe static GetDebugMessageLogAMD glGetDebugMessageLogAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLogARB(UInt32 count, Int32 bufsize, [OutAttribute] OpenTK.Graphics.OpenGL.ArbDebugOutput* sources, [OutAttribute] OpenTK.Graphics.OpenGL.ArbDebugOutput* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL.ArbDebugOutput* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogARB glGetDebugMessageLogARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDetailTexFuncSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, [OutAttribute] Single* points);
            internal unsafe static GetDetailTexFuncSGIS glGetDetailTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublei_v(OpenTK.Graphics.OpenGL.GetIndexedPName target, UInt32 index, [OutAttribute] Double* data);
            internal unsafe static GetDoublei_v glGetDoublei_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoubleIndexedvEXT(OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Double* data);
            internal unsafe static GetDoubleIndexedvEXT glGetDoubleIndexedvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublev(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute] Double* @params);
            internal unsafe static GetDoublev glGetDoublev;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.ErrorCode GetError();
            internal static GetError glGetError;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, OpenTK.Graphics.OpenGL.NvFence pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterfvNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners variable, OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, [OutAttribute] Single* @params);
            internal unsafe static GetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterivNV(OpenTK.Graphics.OpenGL.NvRegisterCombiners variable, OpenTK.Graphics.OpenGL.NvRegisterCombiners pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloati_v(OpenTK.Graphics.OpenGL.GetIndexedPName target, UInt32 index, [OutAttribute] Single* data);
            internal unsafe static GetFloati_v glGetFloati_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatIndexedvEXT(OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Single* data);
            internal unsafe static GetFloatIndexedvEXT glGetFloatIndexedvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetFloatv glGetFloatv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFogFuncSGIS([OutAttribute] Single* points);
            internal unsafe static GetFogFuncSGIS glGetFogFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataIndex(UInt32 program, String name);
            internal static GetFragDataIndex glGetFragDataIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocation(UInt32 program, String name);
            internal static GetFragDataLocation glGetFragDataLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocationEXT(UInt32 program, String name);
            internal static GetFragDataLocationEXT glGetFragDataLocationEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightfvSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute] Single* @params);
            internal unsafe static GetFragmentLightfvSGIX glGetFragmentLightfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightivSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFragmentLightivSGIX glGetFragmentLightivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialfvSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialivSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameterivEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferParameterivEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferParameterivEXT glGetFramebufferParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.ArbRobustness GetGraphicsResetStatusARB();
            internal static GetGraphicsResetStatusARB glGetGraphicsResetStatusARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetHandleARB(OpenTK.Graphics.OpenGL.ArbShaderObjects pname);
            internal static GetHandleARB glGetHandleARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetHistogram(OpenTK.Graphics.OpenGL.HistogramTarget target, bool reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr values);
            internal static GetHistogram glGetHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetHistogramEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, bool reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr values);
            internal static GetHistogramEXT glGetHistogramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfv(OpenTK.Graphics.OpenGL.HistogramTarget target, OpenTK.Graphics.OpenGL.GetHistogramParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfvEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, OpenTK.Graphics.OpenGL.ExtHistogram pname, [OutAttribute] Single* @params);
            internal unsafe static GetHistogramParameterfvEXT glGetHistogramParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameteriv(OpenTK.Graphics.OpenGL.HistogramTarget target, OpenTK.Graphics.OpenGL.GetHistogramParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterivEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, OpenTK.Graphics.OpenGL.ExtHistogram pname, [OutAttribute] Int32* @params);
            internal unsafe static GetHistogramParameterivEXT glGetHistogramParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterfvHP(OpenTK.Graphics.OpenGL.HpImageTransform target, OpenTK.Graphics.OpenGL.HpImageTransform pname, [OutAttribute] Single* @params);
            internal unsafe static GetImageTransformParameterfvHP glGetImageTransformParameterfvHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterivHP(OpenTK.Graphics.OpenGL.HpImageTransform target, OpenTK.Graphics.OpenGL.HpImageTransform pname, [OutAttribute] Int32* @params);
            internal unsafe static GetImageTransformParameterivHP glGetImageTransformParameterivHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInfoLogARB(UInt32 obj, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetInfoLogARB glGetInfoLogARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetInstrumentsSGIX();
            internal static GetInstrumentsSGIX glGetInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64i_v(OpenTK.Graphics.OpenGL.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64i_v glGetInteger64i_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64v(OpenTK.Graphics.OpenGL.ArbSync pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64v glGetInteger64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegeri_v(OpenTK.Graphics.OpenGL.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_v glGetIntegeri_v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerIndexedvEXT(OpenTK.Graphics.OpenGL.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerIndexedvEXT glGetIntegerIndexedvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerui64i_vNV(OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory value, UInt32 index, [OutAttribute] UInt64* result);
            internal unsafe static GetIntegerui64i_vNV glGetIntegerui64i_vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerui64vNV(OpenTK.Graphics.OpenGL.NvShaderBufferLoad value, [OutAttribute] UInt64* result);
            internal unsafe static GetIntegerui64vNV glGetIntegerui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetIntegerv glGetIntegerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantBooleanvEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] bool* data);
            internal unsafe static GetInvariantBooleanvEXT glGetInvariantBooleanvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantFloatvEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] Single* data);
            internal unsafe static GetInvariantFloatvEXT glGetInvariantFloatvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantIntegervEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] Int32* data);
            internal unsafe static GetInvariantIntegervEXT glGetInvariantIntegervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightfv(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetLightfv glGetLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightiv(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetLightiv glGetLightiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterfvSGIX(UInt32 list, OpenTK.Graphics.OpenGL.ListParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetListParameterfvSGIX glGetListParameterfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterivSGIX(UInt32 list, OpenTK.Graphics.OpenGL.ListParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetListParameterivSGIX glGetListParameterivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantBooleanvEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] bool* data);
            internal unsafe static GetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantFloatvEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] Single* data);
            internal unsafe static GetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantIntegervEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] Int32* data);
            internal unsafe static GetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterfvNV(OpenTK.Graphics.OpenGL.NvEvaluators target, UInt32 index, OpenTK.Graphics.OpenGL.NvEvaluators pname, [OutAttribute] Single* @params);
            internal unsafe static GetMapAttribParameterfvNV glGetMapAttribParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterivNV(OpenTK.Graphics.OpenGL.NvEvaluators target, UInt32 index, OpenTK.Graphics.OpenGL.NvEvaluators pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMapAttribParameterivNV glGetMapAttribParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMapControlPointsNV(OpenTK.Graphics.OpenGL.NvEvaluators target, UInt32 index, OpenTK.Graphics.OpenGL.NvEvaluators type, Int32 ustride, Int32 vstride, bool packed, [OutAttribute] IntPtr points);
            internal static GetMapControlPointsNV glGetMapControlPointsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapdv(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, [OutAttribute] Double* v);
            internal unsafe static GetMapdv glGetMapdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapfv(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, [OutAttribute] Single* v);
            internal unsafe static GetMapfv glGetMapfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapiv(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, [OutAttribute] Int32* v);
            internal unsafe static GetMapiv glGetMapiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterfvNV(OpenTK.Graphics.OpenGL.NvEvaluators target, OpenTK.Graphics.OpenGL.NvEvaluators pname, [OutAttribute] Single* @params);
            internal unsafe static GetMapParameterfvNV glGetMapParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterivNV(OpenTK.Graphics.OpenGL.NvEvaluators target, OpenTK.Graphics.OpenGL.NvEvaluators pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMapParameterivNV glGetMapParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialfv(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialiv(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMaterialiv glGetMaterialiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMinmax(OpenTK.Graphics.OpenGL.MinmaxTarget target, bool reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr values);
            internal static GetMinmax glGetMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMinmaxEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, bool reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr values);
            internal static GetMinmaxEXT glGetMinmaxEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfv(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.GetMinmaxParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfvEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, OpenTK.Graphics.OpenGL.ExtHistogram pname, [OutAttribute] Single* @params);
            internal unsafe static GetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameteriv(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.GetMinmaxParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterivEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, OpenTK.Graphics.OpenGL.ExtHistogram pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMinmaxParameterivEXT glGetMinmaxParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultisamplefv(OpenTK.Graphics.OpenGL.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single* val);
            internal unsafe static GetMultisamplefv glGetMultisamplefv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultisamplefvNV(OpenTK.Graphics.OpenGL.NvExplicitMultisample pname, UInt32 index, [OutAttribute] Single* val);
            internal unsafe static GetMultisamplefvNV glGetMultisamplefvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexEnvfvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMultiTexEnvfvEXT glGetMultiTexEnvfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexEnvivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexEnvivEXT glGetMultiTexEnvivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexGendvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetMultiTexGendvEXT glGetMultiTexGendvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexGenfvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMultiTexGenfvEXT glGetMultiTexGenfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexGenivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexGenivEXT glGetMultiTexGenivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMultiTexImageEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr pixels);
            internal static GetMultiTexImageEXT glGetMultiTexImageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexLevelParameterfvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMultiTexLevelParameterfvEXT glGetMultiTexLevelParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexLevelParameterivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexLevelParameterivEXT glGetMultiTexLevelParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterfvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMultiTexParameterfvEXT glGetMultiTexParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterIivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexParameterIivEXT glGetMultiTexParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterIuivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetMultiTexParameterIuivEXT glGetMultiTexParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexParameterivEXT glGetMultiTexParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedBufferParameterivEXT(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedBufferParameterivEXT glGetNamedBufferParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedBufferParameterui64vNV(UInt32 buffer, OpenTK.Graphics.OpenGL.NvShaderBufferLoad pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetNamedBufferParameterui64vNV glGetNamedBufferParameterui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetNamedBufferPointervEXT(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess pname, [OutAttribute] IntPtr @params);
            internal static GetNamedBufferPointervEXT glGetNamedBufferPointervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            internal static GetNamedBufferSubDataEXT glGetNamedBufferSubDataEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedFramebufferAttachmentParameterivEXT glGetNamedFramebufferAttachmentParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramivEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, OpenTK.Graphics.OpenGL.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedProgramivEXT glGetNamedProgramivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterdvEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Double* @params);
            internal unsafe static GetNamedProgramLocalParameterdvEXT glGetNamedProgramLocalParameterdvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterfvEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Single* @params);
            internal unsafe static GetNamedProgramLocalParameterfvEXT glGetNamedProgramLocalParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterIivEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedProgramLocalParameterIivEXT glGetNamedProgramLocalParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterIuivEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, [OutAttribute] UInt32* @params);
            internal unsafe static GetNamedProgramLocalParameterIuivEXT glGetNamedProgramLocalParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetNamedProgramStringEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, OpenTK.Graphics.OpenGL.ExtDirectStateAccess pname, [OutAttribute] IntPtr @string);
            internal static GetNamedProgramStringEXT glGetNamedProgramStringEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedRenderbufferParameterivEXT(UInt32 renderbuffer, OpenTK.Graphics.OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedRenderbufferParameterivEXT glGetNamedRenderbufferParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, [OutAttribute] Int32* stringlen, [OutAttribute] StringBuilder @string);
            internal unsafe static GetNamedStringARB glGetNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedStringivARB(Int32 namelen, String name, OpenTK.Graphics.OpenGL.ArbShadingLanguageInclude pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedStringivARB glGetNamedStringivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnColorTableARB(OpenTK.Graphics.OpenGL.ArbRobustness target, OpenTK.Graphics.OpenGL.ArbRobustness format, OpenTK.Graphics.OpenGL.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr table);
            internal static GetnColorTableARB glGetnColorTableARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnCompressedTexImageARB(OpenTK.Graphics.OpenGL.ArbRobustness target, Int32 lod, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnCompressedTexImageARB glGetnCompressedTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnConvolutionFilterARB(OpenTK.Graphics.OpenGL.ArbRobustness target, OpenTK.Graphics.OpenGL.ArbRobustness format, OpenTK.Graphics.OpenGL.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr image);
            internal static GetnConvolutionFilterARB glGetnConvolutionFilterARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnHistogramARB(OpenTK.Graphics.OpenGL.ArbRobustness target, bool reset, OpenTK.Graphics.OpenGL.ArbRobustness format, OpenTK.Graphics.OpenGL.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnHistogramARB glGetnHistogramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapdvARB(OpenTK.Graphics.OpenGL.ArbRobustness target, OpenTK.Graphics.OpenGL.ArbRobustness query, Int32 bufSize, [OutAttribute] Double* v);
            internal unsafe static GetnMapdvARB glGetnMapdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapfvARB(OpenTK.Graphics.OpenGL.ArbRobustness target, OpenTK.Graphics.OpenGL.ArbRobustness query, Int32 bufSize, [OutAttribute] Single* v);
            internal unsafe static GetnMapfvARB glGetnMapfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapivARB(OpenTK.Graphics.OpenGL.ArbRobustness target, OpenTK.Graphics.OpenGL.ArbRobustness query, Int32 bufSize, [OutAttribute] Int32* v);
            internal unsafe static GetnMapivARB glGetnMapivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnMinmaxARB(OpenTK.Graphics.OpenGL.ArbRobustness target, bool reset, OpenTK.Graphics.OpenGL.ArbRobustness format, OpenTK.Graphics.OpenGL.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnMinmaxARB glGetnMinmaxARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapfvARB(OpenTK.Graphics.OpenGL.ArbRobustness map, Int32 bufSize, [OutAttribute] Single* values);
            internal unsafe static GetnPixelMapfvARB glGetnPixelMapfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapuivARB(OpenTK.Graphics.OpenGL.ArbRobustness map, Int32 bufSize, [OutAttribute] UInt32* values);
            internal unsafe static GetnPixelMapuivARB glGetnPixelMapuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapusvARB(OpenTK.Graphics.OpenGL.ArbRobustness map, Int32 bufSize, [OutAttribute] UInt16* values);
            internal unsafe static GetnPixelMapusvARB glGetnPixelMapusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPolygonStippleARB(Int32 bufSize, [OutAttribute] Byte* pattern);
            internal unsafe static GetnPolygonStippleARB glGetnPolygonStippleARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnSeparableFilterARB(OpenTK.Graphics.OpenGL.ArbRobustness target, OpenTK.Graphics.OpenGL.ArbRobustness format, OpenTK.Graphics.OpenGL.ArbRobustness type, Int32 rowBufSize, [OutAttribute] IntPtr row, Int32 columnBufSize, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetnSeparableFilterARB glGetnSeparableFilterARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnTexImageARB(OpenTK.Graphics.OpenGL.ArbRobustness target, Int32 level, OpenTK.Graphics.OpenGL.ArbRobustness format, OpenTK.Graphics.OpenGL.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnTexImageARB glGetnTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double* @params);
            internal unsafe static GetnUniformdvARB glGetnUniformdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvARB glGetnUniformfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivARB glGetnUniformivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32* @params);
            internal unsafe static GetnUniformuivARB glGetnUniformuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferfvATI(UInt32 buffer, OpenTK.Graphics.OpenGL.AtiVertexArrayObject pname, [OutAttribute] Single* @params);
            internal unsafe static GetObjectBufferfvATI glGetObjectBufferfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferivATI(UInt32 buffer, OpenTK.Graphics.OpenGL.AtiVertexArrayObject pname, [OutAttribute] Int32* @params);
            internal unsafe static GetObjectBufferivATI glGetObjectBufferivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterfvARB(UInt32 obj, OpenTK.Graphics.OpenGL.ArbShaderObjects pname, [OutAttribute] Single* @params);
            internal unsafe static GetObjectParameterfvARB glGetObjectParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterivAPPLE(OpenTK.Graphics.OpenGL.AppleObjectPurgeable objectType, UInt32 name, OpenTK.Graphics.OpenGL.AppleObjectPurgeable pname, [OutAttribute] Int32* @params);
            internal unsafe static GetObjectParameterivAPPLE glGetObjectParameterivAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterivARB(UInt32 obj, OpenTK.Graphics.OpenGL.ArbShaderObjects pname, [OutAttribute] Int32* @params);
            internal unsafe static GetObjectParameterivARB glGetObjectParameterivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryivNV(UInt32 id, OpenTK.Graphics.OpenGL.NvOcclusionQuery pname, [OutAttribute] Int32* @params);
            internal unsafe static GetOcclusionQueryivNV glGetOcclusionQueryivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryuivNV(UInt32 id, OpenTK.Graphics.OpenGL.NvOcclusionQuery pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetOcclusionQueryuivNV glGetOcclusionQueryuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCounterDataAMD(UInt32 monitor, OpenTK.Graphics.OpenGL.AmdPerformanceMonitor pname, Int32 dataSize, [OutAttribute] UInt32* data, [OutAttribute] Int32* bytesWritten);
            internal unsafe static GetPerfMonitorCounterDataAMD glGetPerfMonitorCounterDataAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, OpenTK.Graphics.OpenGL.AmdPerformanceMonitor pname, [OutAttribute] IntPtr data);
            internal static GetPerfMonitorCounterInfoAMD glGetPerfMonitorCounterInfoAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCountersAMD(UInt32 group, [OutAttribute] Int32* numCounters, [OutAttribute] Int32* maxActiveCounters, Int32 counterSize, [OutAttribute] UInt32* counters);
            internal unsafe static GetPerfMonitorCountersAMD glGetPerfMonitorCountersAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder counterString);
            internal unsafe static GetPerfMonitorCounterStringAMD glGetPerfMonitorCounterStringAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups, Int32 groupsSize, [OutAttribute] UInt32* groups);
            internal unsafe static GetPerfMonitorGroupsAMD glGetPerfMonitorGroupsAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder groupString);
            internal unsafe static GetPerfMonitorGroupStringAMD glGetPerfMonitorGroupStringAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapfv(OpenTK.Graphics.OpenGL.PixelMap map, [OutAttribute] Single* values);
            internal unsafe static GetPixelMapfv glGetPixelMapfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapuiv(OpenTK.Graphics.OpenGL.PixelMap map, [OutAttribute] UInt32* values);
            internal unsafe static GetPixelMapuiv glGetPixelMapuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapusv(OpenTK.Graphics.OpenGL.PixelMap map, [OutAttribute] UInt16* values);
            internal unsafe static GetPixelMapusv glGetPixelMapusv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterfvSGIS(OpenTK.Graphics.OpenGL.SgisPixelTexture pname, [OutAttribute] Single* @params);
            internal unsafe static GetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterivSGIS(OpenTK.Graphics.OpenGL.SgisPixelTexture pname, [OutAttribute] Int32* @params);
            internal unsafe static GetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerIndexedvEXT(OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, [OutAttribute] IntPtr data);
            internal static GetPointerIndexedvEXT glGetPointerIndexedvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerv(OpenTK.Graphics.OpenGL.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointervEXT(OpenTK.Graphics.OpenGL.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointervEXT glGetPointervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPolygonStipple([OutAttribute] Byte* mask);
            internal unsafe static GetPolygonStipple glGetPolygonStipple;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.OpenGL.BinaryFormat* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinary glGetProgramBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterdvARB(OpenTK.Graphics.OpenGL.ArbVertexProgram target, UInt32 index, [OutAttribute] Double* @params);
            internal unsafe static GetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterfvARB(OpenTK.Graphics.OpenGL.ArbVertexProgram target, UInt32 index, [OutAttribute] Single* @params);
            internal unsafe static GetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIuivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, [OutAttribute] UInt32* @params);
            internal unsafe static GetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.OpenGL.ProgramParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramivARB glGetProgramivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivNV(UInt32 id, OpenTK.Graphics.OpenGL.NvVertexProgram pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramivNV glGetProgramivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterdvARB(OpenTK.Graphics.OpenGL.ArbVertexProgram target, UInt32 index, [OutAttribute] Double* @params);
            internal unsafe static GetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterfvARB(OpenTK.Graphics.OpenGL.ArbVertexProgram target, UInt32 index, [OutAttribute] Single* @params);
            internal unsafe static GetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIuivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, [OutAttribute] UInt32* @params);
            internal unsafe static GetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterdvNV(UInt32 id, Int32 len, Byte* name, [OutAttribute] Double* @params);
            internal unsafe static GetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterfvNV(UInt32 id, Int32 len, Byte* name, [OutAttribute] Single* @params);
            internal unsafe static GetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterdvNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, [OutAttribute] Double* @params);
            internal unsafe static GetProgramParameterdvNV glGetProgramParameterdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterfvNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, [OutAttribute] Single* @params);
            internal unsafe static GetProgramParameterfvNV glGetProgramParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLog glGetProgramPipelineInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineiv(UInt32 pipeline, OpenTK.Graphics.OpenGL.ProgramPipelineParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineiv glGetProgramPipelineiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStageiv(UInt32 program, OpenTK.Graphics.OpenGL.ShaderType shadertype, OpenTK.Graphics.OpenGL.ProgramStageParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetProgramStageiv glGetProgramStageiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetProgramStringARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, [OutAttribute] IntPtr @string);
            internal static GetProgramStringARB glGetProgramStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStringNV(UInt32 id, OpenTK.Graphics.OpenGL.NvVertexProgram pname, [OutAttribute] Byte* program);
            internal unsafe static GetProgramStringNV glGetProgramStringNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramSubroutineParameteruivNV(OpenTK.Graphics.OpenGL.NvGpuProgram5 target, UInt32 index, [OutAttribute] UInt32* param);
            internal unsafe static GetProgramSubroutineParameteruivNV glGetProgramSubroutineParameteruivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryIndexediv(OpenTK.Graphics.OpenGL.QueryTarget target, UInt32 index, OpenTK.Graphics.OpenGL.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryIndexediv glGetQueryIndexediv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryiv(OpenTK.Graphics.OpenGL.QueryTarget target, OpenTK.Graphics.OpenGL.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryivARB(OpenTK.Graphics.OpenGL.ArbOcclusionQuery target, OpenTK.Graphics.OpenGL.ArbOcclusionQuery pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryivARB glGetQueryivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64v(UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64v glGetQueryObjecti64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtTimerQuery pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectiv(UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectiv glGetQueryObjectiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectivARB(UInt32 id, OpenTK.Graphics.OpenGL.ArbOcclusionQuery pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectivARB glGetQueryObjectivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64v(UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64v glGetQueryObjectui64v;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtTimerQuery pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuivARB(UInt32 id, OpenTK.Graphics.OpenGL.ArbOcclusionQuery pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuivARB glGetQueryObjectuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.OpenGL.RenderbufferTarget target, OpenTK.Graphics.OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameterivEXT(OpenTK.Graphics.OpenGL.RenderbufferTarget target, OpenTK.Graphics.OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL.SamplerParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL.ArbSamplerObjects pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameterIiv glGetSamplerParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL.ArbSamplerObjects pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetSamplerParameterIuiv glGetSamplerParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL.SamplerParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetSeparableFilter(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetSeparableFilter glGetSeparableFilter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetSeparableFilterEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetSeparableFilterEXT glGetSeparableFilterEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.OpenGL.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL.ShaderType shadertype, OpenTK.Graphics.OpenGL.ShaderPrecisionType precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSourceARB(UInt32 obj, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSourceARB glGetShaderSourceARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSharpenTexFuncSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, [OutAttribute] Single* points);
            internal unsafe static GetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(OpenTK.Graphics.OpenGL.StringName name);
            internal static GetString glGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetStringi(OpenTK.Graphics.OpenGL.StringName name, UInt32 index);
            internal static GetStringi glGetStringi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetSubroutineIndex(UInt32 program, OpenTK.Graphics.OpenGL.ShaderType shadertype, String name);
            internal static GetSubroutineIndex glGetSubroutineIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetSubroutineUniformLocation(UInt32 program, OpenTK.Graphics.OpenGL.ShaderType shadertype, String name);
            internal static GetSubroutineUniformLocation glGetSubroutineUniformLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSynciv(IntPtr sync, OpenTK.Graphics.OpenGL.ArbSync pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSynciv glGetSynciv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterfvATI(OpenTK.Graphics.OpenGL.AtiEnvmapBumpmap pname, [OutAttribute] Single* param);
            internal unsafe static GetTexBumpParameterfvATI glGetTexBumpParameterfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterivATI(OpenTK.Graphics.OpenGL.AtiEnvmapBumpmap pname, [OutAttribute] Int32* param);
            internal unsafe static GetTexBumpParameterivATI glGetTexBumpParameterivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvfv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnviv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexFilterFuncSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.SgisTextureFilter4 filter, [OutAttribute] Single* weights);
            internal unsafe static GetTexFilterFuncSGIS glGetTexFilterFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGendv(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetTexGendv glGetTexGendv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGenfv(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexGenfv glGetTexGenfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGeniv(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexGeniv glGetTexGeniv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTexImage(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr pixels);
            internal static GetTexImage glGetTexImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameterfv(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameteriv(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIiv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameterIiv glGetTexParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameterIivEXT glGetTexParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIuiv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetTexParameterIuiv glGetTexParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIuivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetTexParameterIuivEXT glGetTexParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTexParameterPointervAPPLE(OpenTK.Graphics.OpenGL.AppleTextureRange target, OpenTK.Graphics.OpenGL.AppleTextureRange pname, [OutAttribute] IntPtr @params);
            internal static GetTexParameterPointervAPPLE glGetTexParameterPointervAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTextureImageEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr pixels);
            internal static GetTextureImageEXT glGetTextureImageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureLevelParameterfvEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTextureLevelParameterfvEXT glGetTextureLevelParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureLevelParameterivEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTextureLevelParameterivEXT glGetTextureLevelParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterfvEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTextureParameterfvEXT glGetTextureParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterIivEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTextureParameterIivEXT glGetTextureParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterIuivEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetTextureParameterIuivEXT glGetTextureParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterivEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTextureParameterivEXT glGetTextureParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTrackMatrixivNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 address, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTrackMatrixivNV glGetTrackMatrixivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVaryingEXT(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL.ExtTransformFeedback* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVaryingEXT glGetTransformFeedbackVaryingEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, [OutAttribute] Int32* location);
            internal unsafe static GetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            internal static GetUniformBlockIndex glGetUniformBlockIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location);
            internal static GetUniformBufferSizeEXT glGetUniformBufferSizeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double* @params);
            internal unsafe static GetUniformdv glGetUniformdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfvARB(UInt32 programObj, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfvARB glGetUniformfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformi64vNV(UInt32 program, Int32 location, [OutAttribute] Int64* @params);
            internal unsafe static GetUniformi64vNV glGetUniformi64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
            internal unsafe static GetUniformIndices glGetUniformIndices;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformivARB(UInt32 programObj, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformivARB glGetUniformivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocation(UInt32 program, String name);
            internal static GetUniformLocation glGetUniformLocation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocationARB(UInt32 programObj, String name);
            internal static GetUniformLocationARB glGetUniformLocationARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location);
            internal static GetUniformOffsetEXT glGetUniformOffsetEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformSubroutineuiv(OpenTK.Graphics.OpenGL.ShaderType shadertype, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformSubroutineuiv glGetUniformSubroutineuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformui64vNV(UInt32 program, Int32 location, [OutAttribute] UInt64* @params);
            internal unsafe static GetUniformui64vNV glGetUniformui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuiv glGetUniformuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformuivEXT(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuivEXT glGetUniformuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectfvATI(UInt32 id, OpenTK.Graphics.OpenGL.AtiVertexArrayObject pname, [OutAttribute] Single* @params);
            internal unsafe static GetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectivATI(UInt32 id, OpenTK.Graphics.OpenGL.AtiVertexArrayObject pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVariantArrayObjectivATI glGetVariantArrayObjectivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantBooleanvEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] bool* data);
            internal unsafe static GetVariantBooleanvEXT glGetVariantBooleanvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantFloatvEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] Single* data);
            internal unsafe static GetVariantFloatvEXT glGetVariantFloatvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantIntegervEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] Int32* data);
            internal unsafe static GetVariantIntegervEXT glGetVariantIntegervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVariantPointervEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader value, [OutAttribute] IntPtr data);
            internal static GetVariantPointervEXT glGetVariantPointervEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetVaryingLocationNV(UInt32 program, String name);
            internal static GetVaryingLocationNV glGetVaryingLocationNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectfvATI(UInt32 index, OpenTK.Graphics.OpenGL.AtiVertexAttribArrayObject pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectivATI(UInt32 index, OpenTK.Graphics.OpenGL.AtiVertexAttribArrayObject pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdv(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdv glGetVertexAttribdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvARB(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameterArb pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdvARB glGetVertexAttribdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvNV(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexProgram pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdvNV glGetVertexAttribdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvARB(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameterArb pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfvARB glGetVertexAttribfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvNV(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexProgram pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfvNV glGetVertexAttribfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIivEXT(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexProgram4 pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIivEXT glGetVertexAttribIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuivEXT(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexProgram4 pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuivEXT glGetVertexAttribIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivARB(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameterArb pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribivARB glGetVertexAttribivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivNV(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexProgram pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribivNV glGetVertexAttribivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLdv(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribLdv glGetVertexAttribLdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLdvEXT(UInt32 index, OpenTK.Graphics.OpenGL.ExtVertexAttrib64bit pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribLdvEXT glGetVertexAttribLdvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLi64vNV(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexAttribInteger64bit pname, [OutAttribute] Int64* @params);
            internal unsafe static GetVertexAttribLi64vNV glGetVertexAttribLi64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLui64vNV(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexAttribInteger64bit pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetVertexAttribLui64vNV glGetVertexAttribLui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointervARB(UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameterArb pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointervARB glGetVertexAttribPointervARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointervNV(UInt32 index, OpenTK.Graphics.OpenGL.NvVertexProgram pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointervNV glGetVertexAttribPointervNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureivNV(UInt32 video_capture_slot, OpenTK.Graphics.OpenGL.NvVideoCapture pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVideoCaptureivNV glGetVideoCaptureivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureStreamdvNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture pname, [OutAttribute] Double* @params);
            internal unsafe static GetVideoCaptureStreamdvNV glGetVideoCaptureStreamdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureStreamfvNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture pname, [OutAttribute] Single* @params);
            internal unsafe static GetVideoCaptureStreamfvNV glGetVideoCaptureStreamfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureStreamivNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVideoCaptureStreamivNV glGetVideoCaptureStreamivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoi64vNV(UInt32 video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute] Int64* @params);
            internal unsafe static GetVideoi64vNV glGetVideoi64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoivNV(UInt32 video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVideoivNV glGetVideoivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoui64vNV(UInt32 video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetVideoui64vNV glGetVideoui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideouivNV(UInt32 video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVideouivNV glGetVideouivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorbSUN(SByte factor);
            internal static GlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactordSUN(Double factor);
            internal static GlobalAlphaFactordSUN glGlobalAlphaFactordSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorfSUN(Single factor);
            internal static GlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoriSUN(Int32 factor);
            internal static GlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorsSUN(Int16 factor);
            internal static GlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorubSUN(Byte factor);
            internal static GlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoruiSUN(UInt32 factor);
            internal static GlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorusSUN(UInt16 factor);
            internal static GlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(OpenTK.Graphics.OpenGL.HintTarget target, OpenTK.Graphics.OpenGL.HintMode mode);
            internal static Hint glHint;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void HintPGI(OpenTK.Graphics.OpenGL.PgiMiscHints target, Int32 mode);
            internal static HintPGI glHintPGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Histogram(OpenTK.Graphics.OpenGL.HistogramTarget target, Int32 width, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, bool sink);
            internal static Histogram glHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void HistogramEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, Int32 width, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, bool sink);
            internal static HistogramEXT glHistogramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IglooInterfaceSGIX(OpenTK.Graphics.OpenGL.All pname, IntPtr @params);
            internal static IglooInterfaceSGIX glIglooInterfaceSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameterfHP(OpenTK.Graphics.OpenGL.HpImageTransform target, OpenTK.Graphics.OpenGL.HpImageTransform pname, Single param);
            internal static ImageTransformParameterfHP glImageTransformParameterfHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterfvHP(OpenTK.Graphics.OpenGL.HpImageTransform target, OpenTK.Graphics.OpenGL.HpImageTransform pname, Single* @params);
            internal unsafe static ImageTransformParameterfvHP glImageTransformParameterfvHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameteriHP(OpenTK.Graphics.OpenGL.HpImageTransform target, OpenTK.Graphics.OpenGL.HpImageTransform pname, Int32 param);
            internal static ImageTransformParameteriHP glImageTransformParameteriHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterivHP(OpenTK.Graphics.OpenGL.HpImageTransform target, OpenTK.Graphics.OpenGL.HpImageTransform pname, Int32* @params);
            internal unsafe static ImageTransformParameterivHP glImageTransformParameterivHP;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr ImportSyncEXT(OpenTK.Graphics.OpenGL.ExtX11SyncObject external_sync_type, IntPtr external_sync, UInt32 flags);
            internal static ImportSyncEXT glImportSyncEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexd(Double c);
            internal static Indexd glIndexd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexdv(Double* c);
            internal unsafe static Indexdv glIndexdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexf(Single c);
            internal static Indexf glIndexf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexFormatNV(OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static IndexFormatNV glIndexFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexFuncEXT(OpenTK.Graphics.OpenGL.ExtIndexFunc func, Single @ref);
            internal static IndexFuncEXT glIndexFuncEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexfv(Single* c);
            internal unsafe static Indexfv glIndexfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexi(Int32 c);
            internal static Indexi glIndexi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexiv(Int32* c);
            internal unsafe static Indexiv glIndexiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMask(UInt32 mask);
            internal static IndexMask glIndexMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMaterialEXT(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.ExtIndexMaterial mode);
            internal static IndexMaterialEXT glIndexMaterialEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointer(OpenTK.Graphics.OpenGL.IndexPointerType type, Int32 stride, IntPtr pointer);
            internal static IndexPointer glIndexPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointerEXT(OpenTK.Graphics.OpenGL.IndexPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            internal static IndexPointerEXT glIndexPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointerListIBM(OpenTK.Graphics.OpenGL.IndexPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static IndexPointerListIBM glIndexPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexs(Int16 c);
            internal static Indexs glIndexs;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexsv(Int16* c);
            internal unsafe static Indexsv glIndexsv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexub(Byte c);
            internal static Indexub glIndexub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexubv(Byte* c);
            internal unsafe static Indexubv glIndexubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InitNames();
            internal static InitNames glInitNames;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            internal static InsertComponentEXT glInsertComponentEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InstrumentsBufferSGIX(Int32 size, [OutAttribute] Int32* buffer);
            internal unsafe static InstrumentsBufferSGIX glInstrumentsBufferSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void InterleavedArrays(OpenTK.Graphics.OpenGL.InterleavedArrayFormat format, Int32 stride, IntPtr pointer);
            internal static InterleavedArrays glInterleavedArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsAsyncMarkerSGIX(UInt32 marker);
            internal static IsAsyncMarkerSGIX glIsAsyncMarkerSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBufferARB(UInt32 buffer);
            internal static IsBufferARB glIsBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBufferResidentNV(OpenTK.Graphics.OpenGL.NvShaderBufferLoad target);
            internal static IsBufferResidentNV glIsBufferResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled(OpenTK.Graphics.OpenGL.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabledi(OpenTK.Graphics.OpenGL.IndexedEnableCap target, UInt32 index);
            internal static IsEnabledi glIsEnabledi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabledIndexedEXT(OpenTK.Graphics.OpenGL.IndexedEnableCap target, UInt32 index);
            internal static IsEnabledIndexedEXT glIsEnabledIndexedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFenceAPPLE(UInt32 fence);
            internal static IsFenceAPPLE glIsFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebufferEXT(UInt32 framebuffer);
            internal static IsFramebufferEXT glIsFramebufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsList(UInt32 list);
            internal static IsList glIsList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsNameAMD(OpenTK.Graphics.OpenGL.AmdNameGenDelete identifier, UInt32 name);
            internal static IsNameAMD glIsNameAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsNamedBufferResidentNV(UInt32 buffer);
            internal static IsNamedBufferResidentNV glIsNamedBufferResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsNamedStringARB(Int32 namelen, String name);
            internal static IsNamedStringARB glIsNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsObjectBufferATI(UInt32 buffer);
            internal static IsObjectBufferATI glIsObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsOcclusionQueryNV(UInt32 id);
            internal static IsOcclusionQueryNV glIsOcclusionQueryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramARB(UInt32 program);
            internal static IsProgramARB glIsProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramNV(UInt32 id);
            internal static IsProgramNV glIsProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramPipeline(UInt32 pipeline);
            internal static IsProgramPipeline glIsProgramPipeline;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsQuery(UInt32 id);
            internal static IsQuery glIsQuery;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsQueryARB(UInt32 id);
            internal static IsQueryARB glIsQueryARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbufferEXT(UInt32 renderbuffer);
            internal static IsRenderbufferEXT glIsRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsSampler(UInt32 sampler);
            internal static IsSampler glIsSampler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsSync(IntPtr sync);
            internal static IsSync glIsSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTextureEXT(UInt32 texture);
            internal static IsTextureEXT glIsTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTransformFeedback(UInt32 id);
            internal static IsTransformFeedback glIsTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTransformFeedbackNV(UInt32 id);
            internal static IsTransformFeedbackNV glIsTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVariantEnabledEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader cap);
            internal static IsVariantEnabledEXT glIsVariantEnabledEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArray(UInt32 array);
            internal static IsVertexArray glIsVertexArray;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArrayAPPLE(UInt32 array);
            internal static IsVertexArrayAPPLE glIsVertexArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexAttribEnabledAPPLE(UInt32 index, OpenTK.Graphics.OpenGL.AppleVertexProgramEvaluators pname);
            internal static IsVertexAttribEnabledAPPLE glIsVertexAttribEnabledAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightEnviSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, Int32 param);
            internal static LightEnviSGIX glLightEnviSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lightf(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, Single param);
            internal static Lightf glLightf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightfv(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, Single* @params);
            internal unsafe static Lightfv glLightfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Lighti(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, Int32 param);
            internal static Lighti glLighti;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightiv(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, Int32* @params);
            internal unsafe static Lightiv glLightiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelf(OpenTK.Graphics.OpenGL.LightModelParameter pname, Single param);
            internal static LightModelf glLightModelf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelfv(OpenTK.Graphics.OpenGL.LightModelParameter pname, Single* @params);
            internal unsafe static LightModelfv glLightModelfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModeli(OpenTK.Graphics.OpenGL.LightModelParameter pname, Int32 param);
            internal static LightModeli glLightModeli;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModeliv(OpenTK.Graphics.OpenGL.LightModelParameter pname, Int32* @params);
            internal unsafe static LightModeliv glLightModeliv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineStipple(Int32 factor, UInt16 pattern);
            internal static LineStipple glLineStipple;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgramARB(UInt32 programObj);
            internal static LinkProgramARB glLinkProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListBase(UInt32 @base);
            internal static ListBase glListBase;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameterfSGIX(UInt32 list, OpenTK.Graphics.OpenGL.ListParameterName pname, Single param);
            internal static ListParameterfSGIX glListParameterfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterfvSGIX(UInt32 list, OpenTK.Graphics.OpenGL.ListParameterName pname, Single* @params);
            internal unsafe static ListParameterfvSGIX glListParameterfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameteriSGIX(UInt32 list, OpenTK.Graphics.OpenGL.ListParameterName pname, Int32 param);
            internal static ListParameteriSGIX glListParameteriSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterivSGIX(UInt32 list, OpenTK.Graphics.OpenGL.ListParameterName pname, Int32* @params);
            internal unsafe static ListParameterivSGIX glListParameterivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentityDeformationMapSGIX(UInt32 mask);
            internal static LoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixd(Double* m);
            internal unsafe static LoadMatrixd glLoadMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixf(Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadName(UInt32 name);
            internal static LoadName glLoadName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadProgramNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 id, Int32 len, Byte* program);
            internal unsafe static LoadProgramNV glLoadProgramNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixd(Double* m);
            internal unsafe static LoadTransposeMatrixd glLoadTransposeMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixdARB(Double* m);
            internal unsafe static LoadTransposeMatrixdARB glLoadTransposeMatrixdARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixf(Single* m);
            internal unsafe static LoadTransposeMatrixf glLoadTransposeMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixfARB(Single* m);
            internal unsafe static LoadTransposeMatrixfARB glLoadTransposeMatrixfARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LockArraysEXT(Int32 first, Int32 count);
            internal static LockArraysEXT glLockArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LogicOp(OpenTK.Graphics.OpenGL.LogicOp opcode);
            internal static LogicOp glLogicOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeBufferNonResidentNV(OpenTK.Graphics.OpenGL.NvShaderBufferLoad target);
            internal static MakeBufferNonResidentNV glMakeBufferNonResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeBufferResidentNV(OpenTK.Graphics.OpenGL.NvShaderBufferLoad target, OpenTK.Graphics.OpenGL.NvShaderBufferLoad access);
            internal static MakeBufferResidentNV glMakeBufferResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeNamedBufferNonResidentNV(UInt32 buffer);
            internal static MakeNamedBufferNonResidentNV glMakeNamedBufferNonResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeNamedBufferResidentNV(UInt32 buffer, OpenTK.Graphics.OpenGL.NvShaderBufferLoad access);
            internal static MakeNamedBufferResidentNV glMakeNamedBufferResidentNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1d(OpenTK.Graphics.OpenGL.MapTarget target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            internal unsafe static Map1d glMap1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1f(OpenTK.Graphics.OpenGL.MapTarget target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            internal unsafe static Map1f glMap1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2d(OpenTK.Graphics.OpenGL.MapTarget target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            internal unsafe static Map2d glMap2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2f(OpenTK.Graphics.OpenGL.MapTarget target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            internal unsafe static Map2f glMap2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBuffer(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferAccess access);
            internal unsafe static MapBuffer glMapBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBufferARB(OpenTK.Graphics.OpenGL.BufferTargetArb target, OpenTK.Graphics.OpenGL.ArbVertexBufferObject access);
            internal unsafe static MapBufferARB glMapBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.OpenGL.BufferAccessMask access);
            internal unsafe static MapBufferRange glMapBufferRange;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapControlPointsNV(OpenTK.Graphics.OpenGL.NvEvaluators target, UInt32 index, OpenTK.Graphics.OpenGL.NvEvaluators type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, bool packed, IntPtr points);
            internal static MapControlPointsNV glMapControlPointsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1d(Int32 un, Double u1, Double u2);
            internal static MapGrid1d glMapGrid1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1f(Int32 un, Single u1, Single u2);
            internal static MapGrid1f glMapGrid1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
            internal static MapGrid2d glMapGrid2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
            internal static MapGrid2f glMapGrid2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapNamedBufferEXT(UInt32 buffer, OpenTK.Graphics.OpenGL.ExtDirectStateAccess access);
            internal unsafe static MapNamedBufferEXT glMapNamedBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, IntPtr length, OpenTK.Graphics.OpenGL.BufferAccessMask access);
            internal unsafe static MapNamedBufferRangeEXT glMapNamedBufferRangeEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapObjectBufferATI(UInt32 buffer);
            internal unsafe static MapObjectBufferATI glMapObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterfvNV(OpenTK.Graphics.OpenGL.NvEvaluators target, OpenTK.Graphics.OpenGL.NvEvaluators pname, Single* @params);
            internal unsafe static MapParameterfvNV glMapParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterivNV(OpenTK.Graphics.OpenGL.NvEvaluators target, OpenTK.Graphics.OpenGL.NvEvaluators pname, Int32* @params);
            internal unsafe static MapParameterivNV glMapParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib1dAPPLE(UInt32 index, UInt32 size, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            internal unsafe static MapVertexAttrib1dAPPLE glMapVertexAttrib1dAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib1fAPPLE(UInt32 index, UInt32 size, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            internal unsafe static MapVertexAttrib1fAPPLE glMapVertexAttrib1fAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib2dAPPLE(UInt32 index, UInt32 size, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            internal unsafe static MapVertexAttrib2dAPPLE glMapVertexAttrib2dAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib2fAPPLE(UInt32 index, UInt32 size, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            internal unsafe static MapVertexAttrib2fAPPLE glMapVertexAttrib2fAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialf(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Single param);
            internal static Materialf glMaterialf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialfv(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Single* @params);
            internal unsafe static Materialfv glMaterialfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Materiali(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Int32 param);
            internal static Materiali glMateriali;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialiv(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, Int32* @params);
            internal unsafe static Materialiv glMaterialiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixFrustumEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static MatrixFrustumEXT glMatrixFrustumEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixIndexPointerARB(Int32 size, OpenTK.Graphics.OpenGL.ArbMatrixPalette type, Int32 stride, IntPtr pointer);
            internal static MatrixIndexPointerARB glMatrixIndexPointerARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexubvARB(Int32 size, Byte* indices);
            internal unsafe static MatrixIndexubvARB glMatrixIndexubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexuivARB(Int32 size, UInt32* indices);
            internal unsafe static MatrixIndexuivARB glMatrixIndexuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexusvARB(Int32 size, UInt16* indices);
            internal unsafe static MatrixIndexusvARB glMatrixIndexusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoaddEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double* m);
            internal unsafe static MatrixLoaddEXT glMatrixLoaddEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoadfEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Single* m);
            internal unsafe static MatrixLoadfEXT glMatrixLoadfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixLoadIdentityEXT(OpenTK.Graphics.OpenGL.MatrixMode mode);
            internal static MatrixLoadIdentityEXT glMatrixLoadIdentityEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoadTransposedEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double* m);
            internal unsafe static MatrixLoadTransposedEXT glMatrixLoadTransposedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoadTransposefEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Single* m);
            internal unsafe static MatrixLoadTransposefEXT glMatrixLoadTransposefEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixMode(OpenTK.Graphics.OpenGL.MatrixMode mode);
            internal static MatrixMode glMatrixMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultdEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double* m);
            internal unsafe static MatrixMultdEXT glMatrixMultdEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultfEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Single* m);
            internal unsafe static MatrixMultfEXT glMatrixMultfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultTransposedEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double* m);
            internal unsafe static MatrixMultTransposedEXT glMatrixMultTransposedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultTransposefEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Single* m);
            internal unsafe static MatrixMultTransposefEXT glMatrixMultTransposefEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixOrthoEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static MatrixOrthoEXT glMatrixOrthoEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixPopEXT(OpenTK.Graphics.OpenGL.MatrixMode mode);
            internal static MatrixPopEXT glMatrixPopEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixPushEXT(OpenTK.Graphics.OpenGL.MatrixMode mode);
            internal static MatrixPushEXT glMatrixPushEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixRotatedEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double angle, Double x, Double y, Double z);
            internal static MatrixRotatedEXT glMatrixRotatedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixRotatefEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Single angle, Single x, Single y, Single z);
            internal static MatrixRotatefEXT glMatrixRotatefEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixScaledEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double x, Double y, Double z);
            internal static MatrixScaledEXT glMatrixScaledEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixScalefEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Single x, Single y, Single z);
            internal static MatrixScalefEXT glMatrixScalefEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixTranslatedEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Double x, Double y, Double z);
            internal static MatrixTranslatedEXT glMatrixTranslatedEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixTranslatefEXT(OpenTK.Graphics.OpenGL.MatrixMode mode, Single x, Single y, Single z);
            internal static MatrixTranslatefEXT glMatrixTranslatefEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MemoryBarrierEXT(UInt32 barriers);
            internal static MemoryBarrierEXT glMemoryBarrierEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Minmax(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, bool sink);
            internal static Minmax glMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MinmaxEXT(OpenTK.Graphics.OpenGL.ExtHistogram target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, bool sink);
            internal static MinmaxEXT glMinmaxEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MinSampleShading(Single value);
            internal static MinSampleShading glMinSampleShading;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MinSampleShadingARB(Single value);
            internal static MinSampleShadingARB glMinSampleShadingARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArrays(OpenTK.Graphics.OpenGL.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArrays glMultiDrawArrays;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArraysEXT(OpenTK.Graphics.OpenGL.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawArraysIndirectAMD(OpenTK.Graphics.OpenGL.AmdMultiDrawIndirect mode, IntPtr indirect, Int32 primcount, Int32 stride);
            internal static MultiDrawArraysIndirectAMD glMultiDrawArraysIndirectAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementArrayAPPLE(OpenTK.Graphics.OpenGL.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElements(OpenTK.Graphics.OpenGL.BeginMode mode, Int32* count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElements glMultiDrawElements;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, Int32* count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32* basevertex);
            internal unsafe static MultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsEXT(OpenTK.Graphics.OpenGL.BeginMode mode, Int32* count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawElementsIndirectAMD(OpenTK.Graphics.OpenGL.AmdMultiDrawIndirect mode, OpenTK.Graphics.OpenGL.AmdMultiDrawIndirect type, IntPtr indirect, Int32 primcount, Int32 stride);
            internal static MultiDrawElementsIndirectAMD glMultiDrawElementsIndirectAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawRangeElementArrayAPPLE(OpenTK.Graphics.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawArraysIBM(OpenTK.Graphics.OpenGL.BeginMode* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
            internal unsafe static MultiModeDrawArraysIBM glMultiModeDrawArraysIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawElementsIBM(OpenTK.Graphics.OpenGL.BeginMode* mode, Int32* count, OpenTK.Graphics.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 modestride);
            internal unsafe static MultiModeDrawElementsIBM glMultiModeDrawElementsIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexBufferEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, UInt32 buffer);
            internal static MultiTexBufferEXT glMultiTexBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1d(OpenTK.Graphics.OpenGL.TextureUnit target, Double s);
            internal static MultiTexCoord1d glMultiTexCoord1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1dARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double s);
            internal static MultiTexCoord1dARB glMultiTexCoord1dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dv(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord1dv glMultiTexCoord1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord1dvARB glMultiTexCoord1dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1f(OpenTK.Graphics.OpenGL.TextureUnit target, Single s);
            internal static MultiTexCoord1f glMultiTexCoord1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1fARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single s);
            internal static MultiTexCoord1fARB glMultiTexCoord1fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fv(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord1fv glMultiTexCoord1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord1fvARB glMultiTexCoord1fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1hNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half s);
            internal static MultiTexCoord1hNV glMultiTexCoord1hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1hvNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half* v);
            internal unsafe static MultiTexCoord1hvNV glMultiTexCoord1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1i(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s);
            internal static MultiTexCoord1i glMultiTexCoord1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1iARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s);
            internal static MultiTexCoord1iARB glMultiTexCoord1iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1iv(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord1iv glMultiTexCoord1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1ivARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord1ivARB glMultiTexCoord1ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1s(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s);
            internal static MultiTexCoord1s glMultiTexCoord1s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1sARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s);
            internal static MultiTexCoord1sARB glMultiTexCoord1sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1sv(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord1sv glMultiTexCoord1sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1svARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord1svARB glMultiTexCoord1svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2d(OpenTK.Graphics.OpenGL.TextureUnit target, Double s, Double t);
            internal static MultiTexCoord2d glMultiTexCoord2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2dARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double s, Double t);
            internal static MultiTexCoord2dARB glMultiTexCoord2dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dv(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord2dv glMultiTexCoord2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord2dvARB glMultiTexCoord2dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2f(OpenTK.Graphics.OpenGL.TextureUnit target, Single s, Single t);
            internal static MultiTexCoord2f glMultiTexCoord2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2fARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single s, Single t);
            internal static MultiTexCoord2fARB glMultiTexCoord2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fv(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord2fv glMultiTexCoord2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord2fvARB glMultiTexCoord2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2hNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half s, Half t);
            internal static MultiTexCoord2hNV glMultiTexCoord2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2hvNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half* v);
            internal unsafe static MultiTexCoord2hvNV glMultiTexCoord2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2i(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s, Int32 t);
            internal static MultiTexCoord2i glMultiTexCoord2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2iARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s, Int32 t);
            internal static MultiTexCoord2iARB glMultiTexCoord2iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2iv(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord2iv glMultiTexCoord2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2ivARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord2ivARB glMultiTexCoord2ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2s(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s, Int16 t);
            internal static MultiTexCoord2s glMultiTexCoord2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2sARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s, Int16 t);
            internal static MultiTexCoord2sARB glMultiTexCoord2sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2sv(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord2sv glMultiTexCoord2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2svARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord2svARB glMultiTexCoord2svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3d(OpenTK.Graphics.OpenGL.TextureUnit target, Double s, Double t, Double r);
            internal static MultiTexCoord3d glMultiTexCoord3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3dARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double s, Double t, Double r);
            internal static MultiTexCoord3dARB glMultiTexCoord3dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dv(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord3dv glMultiTexCoord3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord3dvARB glMultiTexCoord3dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3f(OpenTK.Graphics.OpenGL.TextureUnit target, Single s, Single t, Single r);
            internal static MultiTexCoord3f glMultiTexCoord3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3fARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single s, Single t, Single r);
            internal static MultiTexCoord3fARB glMultiTexCoord3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fv(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord3fv glMultiTexCoord3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord3fvARB glMultiTexCoord3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3hNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half s, Half t, Half r);
            internal static MultiTexCoord3hNV glMultiTexCoord3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3hvNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half* v);
            internal unsafe static MultiTexCoord3hvNV glMultiTexCoord3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3i(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s, Int32 t, Int32 r);
            internal static MultiTexCoord3i glMultiTexCoord3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3iARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s, Int32 t, Int32 r);
            internal static MultiTexCoord3iARB glMultiTexCoord3iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3iv(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord3iv glMultiTexCoord3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3ivARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord3ivARB glMultiTexCoord3ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3s(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s, Int16 t, Int16 r);
            internal static MultiTexCoord3s glMultiTexCoord3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3sARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s, Int16 t, Int16 r);
            internal static MultiTexCoord3sARB glMultiTexCoord3sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3sv(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord3sv glMultiTexCoord3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3svARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord3svARB glMultiTexCoord3svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4d(OpenTK.Graphics.OpenGL.TextureUnit target, Double s, Double t, Double r, Double q);
            internal static MultiTexCoord4d glMultiTexCoord4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4dARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double s, Double t, Double r, Double q);
            internal static MultiTexCoord4dARB glMultiTexCoord4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dv(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord4dv glMultiTexCoord4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Double* v);
            internal unsafe static MultiTexCoord4dvARB glMultiTexCoord4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4f(OpenTK.Graphics.OpenGL.TextureUnit target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4fARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4fARB glMultiTexCoord4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fv(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord4fv glMultiTexCoord4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fvARB(OpenTK.Graphics.OpenGL.TextureUnit target, Single* v);
            internal unsafe static MultiTexCoord4fvARB glMultiTexCoord4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4hNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half s, Half t, Half r, Half q);
            internal static MultiTexCoord4hNV glMultiTexCoord4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4hvNV(OpenTK.Graphics.OpenGL.TextureUnit target, Half* v);
            internal unsafe static MultiTexCoord4hvNV glMultiTexCoord4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4i(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s, Int32 t, Int32 r, Int32 q);
            internal static MultiTexCoord4i glMultiTexCoord4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4iARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32 s, Int32 t, Int32 r, Int32 q);
            internal static MultiTexCoord4iARB glMultiTexCoord4iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4iv(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord4iv glMultiTexCoord4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4ivARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int32* v);
            internal unsafe static MultiTexCoord4ivARB glMultiTexCoord4ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4s(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s, Int16 t, Int16 r, Int16 q);
            internal static MultiTexCoord4s glMultiTexCoord4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4sARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16 s, Int16 t, Int16 r, Int16 q);
            internal static MultiTexCoord4sARB glMultiTexCoord4sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4sv(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord4sv glMultiTexCoord4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4svARB(OpenTK.Graphics.OpenGL.TextureUnit target, Int16* v);
            internal unsafe static MultiTexCoord4svARB glMultiTexCoord4svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP1ui(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP1ui glMultiTexCoordP1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP1uiv(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP1uiv glMultiTexCoordP1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP2ui(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP2ui glMultiTexCoordP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP2uiv(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP2uiv glMultiTexCoordP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP3ui(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP3ui glMultiTexCoordP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP3uiv(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP3uiv glMultiTexCoordP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP4ui(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP4ui glMultiTexCoordP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP4uiv(OpenTK.Graphics.OpenGL.TextureUnit texture, OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP4uiv glMultiTexCoordP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordPointerEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            internal static MultiTexCoordPointerEXT glMultiTexCoordPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexEnvfEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Single param);
            internal static MultiTexEnvfEXT glMultiTexEnvfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexEnvfvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Single* @params);
            internal unsafe static MultiTexEnvfvEXT glMultiTexEnvfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexEnviEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Int32 param);
            internal static MultiTexEnviEXT glMultiTexEnviEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexEnvivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Int32* @params);
            internal unsafe static MultiTexEnvivEXT glMultiTexEnvivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexGendEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Double param);
            internal static MultiTexGendEXT glMultiTexGendEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexGendvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Double* @params);
            internal unsafe static MultiTexGendvEXT glMultiTexGendvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexGenfEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Single param);
            internal static MultiTexGenfEXT glMultiTexGenfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexGenfvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Single* @params);
            internal unsafe static MultiTexGenfvEXT glMultiTexGenfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexGeniEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Int32 param);
            internal static MultiTexGeniEXT glMultiTexGeniEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexGenivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Int32* @params);
            internal unsafe static MultiTexGenivEXT glMultiTexGenivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexImage1DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static MultiTexImage1DEXT glMultiTexImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexImage2DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static MultiTexImage2DEXT glMultiTexImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexImage3DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static MultiTexImage3DEXT glMultiTexImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexParameterfEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Single param);
            internal static MultiTexParameterfEXT glMultiTexParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterfvEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Single* @params);
            internal unsafe static MultiTexParameterfvEXT glMultiTexParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexParameteriEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32 param);
            internal static MultiTexParameteriEXT glMultiTexParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterIivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32* @params);
            internal unsafe static MultiTexParameterIivEXT glMultiTexParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterIuivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, UInt32* @params);
            internal unsafe static MultiTexParameterIuivEXT glMultiTexParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterivEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32* @params);
            internal unsafe static MultiTexParameterivEXT glMultiTexParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexRenderbufferEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, UInt32 renderbuffer);
            internal static MultiTexRenderbufferEXT glMultiTexRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexSubImage1DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static MultiTexSubImage1DEXT glMultiTexSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexSubImage2DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static MultiTexSubImage2DEXT glMultiTexSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexSubImage3DEXT(OpenTK.Graphics.OpenGL.TextureUnit texunit, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static MultiTexSubImage3DEXT glMultiTexSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixd(Double* m);
            internal unsafe static MultMatrixd glMultMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixf(Single* m);
            internal unsafe static MultMatrixf glMultMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixd(Double* m);
            internal unsafe static MultTransposeMatrixd glMultTransposeMatrixd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixdARB(Double* m);
            internal unsafe static MultTransposeMatrixdARB glMultTransposeMatrixdARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixf(Single* m);
            internal unsafe static MultTransposeMatrixf glMultTransposeMatrixf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixfARB(Single* m);
            internal unsafe static MultTransposeMatrixfARB glMultTransposeMatrixfARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedBufferDataEXT(UInt32 buffer, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL.ExtDirectStateAccess usage);
            internal static NamedBufferDataEXT glNamedBufferDataEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, IntPtr size, IntPtr data);
            internal static NamedBufferSubDataEXT glNamedBufferSubDataEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static NamedCopyBufferSubDataEXT glNamedCopyBufferSubDataEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferRenderbufferEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static NamedFramebufferRenderbufferEXT glNamedFramebufferRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTexture1DEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static NamedFramebufferTexture1DEXT glNamedFramebufferTexture1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTexture2DEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static NamedFramebufferTexture2DEXT glNamedFramebufferTexture2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTexture3DEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static NamedFramebufferTexture3DEXT glNamedFramebufferTexture3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTextureEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            internal static NamedFramebufferTextureEXT glNamedFramebufferTextureEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTextureFaceEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL.TextureTarget face);
            internal static NamedFramebufferTextureFaceEXT glNamedFramebufferTextureFaceEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTextureLayerEXT(UInt32 framebuffer, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static NamedFramebufferTextureLayerEXT glNamedFramebufferTextureLayerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameter4dEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static NamedProgramLocalParameter4dEXT glNamedProgramLocalParameter4dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameter4dvEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Double* @params);
            internal unsafe static NamedProgramLocalParameter4dvEXT glNamedProgramLocalParameter4dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameter4fEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static NamedProgramLocalParameter4fEXT glNamedProgramLocalParameter4fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameter4fvEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Single* @params);
            internal unsafe static NamedProgramLocalParameter4fvEXT glNamedProgramLocalParameter4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameterI4iEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static NamedProgramLocalParameterI4iEXT glNamedProgramLocalParameterI4iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameterI4ivEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Int32* @params);
            internal unsafe static NamedProgramLocalParameterI4ivEXT glNamedProgramLocalParameterI4ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameterI4uiEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static NamedProgramLocalParameterI4uiEXT glNamedProgramLocalParameterI4uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameterI4uivEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, UInt32* @params);
            internal unsafe static NamedProgramLocalParameterI4uivEXT glNamedProgramLocalParameterI4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameters4fvEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Int32 count, Single* @params);
            internal unsafe static NamedProgramLocalParameters4fvEXT glNamedProgramLocalParameters4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParametersI4ivEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static NamedProgramLocalParametersI4ivEXT glNamedProgramLocalParametersI4ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParametersI4uivEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static NamedProgramLocalParametersI4uivEXT glNamedProgramLocalParametersI4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramStringEXT(UInt32 program, OpenTK.Graphics.OpenGL.ExtDirectStateAccess target, OpenTK.Graphics.OpenGL.ExtDirectStateAccess format, Int32 len, IntPtr @string);
            internal static NamedProgramStringEXT glNamedProgramStringEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedRenderbufferStorageEXT(UInt32 renderbuffer, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height);
            internal static NamedRenderbufferStorageEXT glNamedRenderbufferStorageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height);
            internal static NamedRenderbufferStorageMultisampleCoverageEXT glNamedRenderbufferStorageMultisampleCoverageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height);
            internal static NamedRenderbufferStorageMultisampleEXT glNamedRenderbufferStorageMultisampleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedStringARB(OpenTK.Graphics.OpenGL.ArbShadingLanguageInclude type, Int32 namelen, String name, Int32 stringlen, String @string);
            internal static NamedStringARB glNamedStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NewList(UInt32 list, OpenTK.Graphics.OpenGL.ListMode mode);
            internal static NewList glNewList;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 NewObjectBufferATI(Int32 size, IntPtr pointer, OpenTK.Graphics.OpenGL.AtiVertexArrayObject usage);
            internal static NewObjectBufferATI glNewObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3b(SByte nx, SByte ny, SByte nz);
            internal static Normal3b glNormal3b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3bv(SByte* v);
            internal unsafe static Normal3bv glNormal3bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3d(Double nx, Double ny, Double nz);
            internal static Normal3d glNormal3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3dv(Double* v);
            internal unsafe static Normal3dv glNormal3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3f(Single nx, Single ny, Single nz);
            internal static Normal3f glNormal3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fv(Single* v);
            internal unsafe static Normal3fv glNormal3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3fVertex3fSUN(Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static Normal3fVertex3fSUN glNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fVertex3fvSUN(Single* n, Single* v);
            internal unsafe static Normal3fVertex3fvSUN glNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3hNV(Half nx, Half ny, Half nz);
            internal static Normal3hNV glNormal3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3hvNV(Half* v);
            internal unsafe static Normal3hvNV glNormal3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3i(Int32 nx, Int32 ny, Int32 nz);
            internal static Normal3i glNormal3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3iv(Int32* v);
            internal unsafe static Normal3iv glNormal3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3s(Int16 nx, Int16 ny, Int16 nz);
            internal static Normal3s glNormal3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3sv(Int16* v);
            internal unsafe static Normal3sv glNormal3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalFormatNV(OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static NormalFormatNV glNormalFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalP3ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static NormalP3ui glNormalP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalP3uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static NormalP3uiv glNormalP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointer(OpenTK.Graphics.OpenGL.NormalPointerType type, Int32 stride, IntPtr pointer);
            internal static NormalPointer glNormalPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointerEXT(OpenTK.Graphics.OpenGL.NormalPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            internal static NormalPointerEXT glNormalPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointerListIBM(OpenTK.Graphics.OpenGL.NormalPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static NormalPointerListIBM glNormalPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointervINTEL(OpenTK.Graphics.OpenGL.NormalPointerType type, IntPtr pointer);
            internal static NormalPointervINTEL glNormalPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3bATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, SByte nx, SByte ny, SByte nz);
            internal static NormalStream3bATI glNormalStream3bATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3bvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, SByte* coords);
            internal unsafe static NormalStream3bvATI glNormalStream3bvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3dATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double nx, Double ny, Double nz);
            internal static NormalStream3dATI glNormalStream3dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3dvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double* coords);
            internal unsafe static NormalStream3dvATI glNormalStream3dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3fATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single nx, Single ny, Single nz);
            internal static NormalStream3fATI glNormalStream3fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3fvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single* coords);
            internal unsafe static NormalStream3fvATI glNormalStream3fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3iATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32 nx, Int32 ny, Int32 nz);
            internal static NormalStream3iATI glNormalStream3iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3ivATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32* coords);
            internal unsafe static NormalStream3ivATI glNormalStream3ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3sATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16 nx, Int16 ny, Int16 nz);
            internal static NormalStream3sATI glNormalStream3sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3svATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16* coords);
            internal unsafe static NormalStream3svATI glNormalStream3svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.AppleObjectPurgeable ObjectPurgeableAPPLE(OpenTK.Graphics.OpenGL.AppleObjectPurgeable objectType, UInt32 name, OpenTK.Graphics.OpenGL.AppleObjectPurgeable option);
            internal static ObjectPurgeableAPPLE glObjectPurgeableAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.OpenGL.AppleObjectPurgeable ObjectUnpurgeableAPPLE(OpenTK.Graphics.OpenGL.AppleObjectPurgeable objectType, UInt32 name, OpenTK.Graphics.OpenGL.AppleObjectPurgeable option);
            internal static ObjectUnpurgeableAPPLE glObjectUnpurgeableAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            internal static Ortho glOrtho;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PassTexCoordATI(UInt32 dst, UInt32 coord, OpenTK.Graphics.OpenGL.AtiFragmentShader swizzle);
            internal static PassTexCoordATI glPassTexCoordATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PassThrough(Single token);
            internal static PassThrough glPassThrough;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PatchParameterfv(OpenTK.Graphics.OpenGL.PatchParameterFloat pname, Single* values);
            internal unsafe static PatchParameterfv glPatchParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PatchParameteri(OpenTK.Graphics.OpenGL.PatchParameterInt pname, Int32 value);
            internal static PatchParameteri glPatchParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PauseTransformFeedback();
            internal static PauseTransformFeedback glPauseTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PauseTransformFeedbackNV();
            internal static PauseTransformFeedbackNV glPauseTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelDataRangeNV(OpenTK.Graphics.OpenGL.NvPixelDataRange target, Int32 length, [OutAttribute] IntPtr pointer);
            internal static PixelDataRangeNV glPixelDataRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapfv(OpenTK.Graphics.OpenGL.PixelMap map, Int32 mapsize, Single* values);
            internal unsafe static PixelMapfv glPixelMapfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapuiv(OpenTK.Graphics.OpenGL.PixelMap map, Int32 mapsize, UInt32* values);
            internal unsafe static PixelMapuiv glPixelMapuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapusv(OpenTK.Graphics.OpenGL.PixelMap map, Int32 mapsize, UInt16* values);
            internal unsafe static PixelMapusv glPixelMapusv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStoref(OpenTK.Graphics.OpenGL.PixelStoreParameter pname, Single param);
            internal static PixelStoref glPixelStoref;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(OpenTK.Graphics.OpenGL.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameterfSGIS(OpenTK.Graphics.OpenGL.SgisPixelTexture pname, Single param);
            internal static PixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterfvSGIS(OpenTK.Graphics.OpenGL.SgisPixelTexture pname, Single* @params);
            internal unsafe static PixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameteriSGIS(OpenTK.Graphics.OpenGL.SgisPixelTexture pname, Int32 param);
            internal static PixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterivSGIS(OpenTK.Graphics.OpenGL.SgisPixelTexture pname, Int32* @params);
            internal unsafe static PixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenSGIX(OpenTK.Graphics.OpenGL.SgixPixelTexture mode);
            internal static PixelTexGenSGIX glPixelTexGenSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferf(OpenTK.Graphics.OpenGL.PixelTransferParameter pname, Single param);
            internal static PixelTransferf glPixelTransferf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferi(OpenTK.Graphics.OpenGL.PixelTransferParameter pname, Int32 param);
            internal static PixelTransferi glPixelTransferi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameterfEXT(OpenTK.Graphics.OpenGL.ExtPixelTransform target, OpenTK.Graphics.OpenGL.ExtPixelTransform pname, Single param);
            internal static PixelTransformParameterfEXT glPixelTransformParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterfvEXT(OpenTK.Graphics.OpenGL.ExtPixelTransform target, OpenTK.Graphics.OpenGL.ExtPixelTransform pname, Single* @params);
            internal unsafe static PixelTransformParameterfvEXT glPixelTransformParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameteriEXT(OpenTK.Graphics.OpenGL.ExtPixelTransform target, OpenTK.Graphics.OpenGL.ExtPixelTransform pname, Int32 param);
            internal static PixelTransformParameteriEXT glPixelTransformParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterivEXT(OpenTK.Graphics.OpenGL.ExtPixelTransform target, OpenTK.Graphics.OpenGL.ExtPixelTransform pname, Int32* @params);
            internal unsafe static PixelTransformParameterivEXT glPixelTransformParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelZoom(Single xfactor, Single yfactor);
            internal static PixelZoom glPixelZoom;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesfATI(OpenTK.Graphics.OpenGL.AtiPnTriangles pname, Single param);
            internal static PNTrianglesfATI glPNTrianglesfATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesiATI(OpenTK.Graphics.OpenGL.AtiPnTriangles pname, Int32 param);
            internal static PNTrianglesiATI glPNTrianglesiATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterf(OpenTK.Graphics.OpenGL.PointParameterName pname, Single param);
            internal static PointParameterf glPointParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfARB(OpenTK.Graphics.OpenGL.ArbPointParameters pname, Single param);
            internal static PointParameterfARB glPointParameterfARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfEXT(OpenTK.Graphics.OpenGL.ExtPointParameters pname, Single param);
            internal static PointParameterfEXT glPointParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfSGIS(OpenTK.Graphics.OpenGL.SgisPointParameters pname, Single param);
            internal static PointParameterfSGIS glPointParameterfSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfv(OpenTK.Graphics.OpenGL.PointParameterName pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvARB(OpenTK.Graphics.OpenGL.ArbPointParameters pname, Single* @params);
            internal unsafe static PointParameterfvARB glPointParameterfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvEXT(OpenTK.Graphics.OpenGL.ExtPointParameters pname, Single* @params);
            internal unsafe static PointParameterfvEXT glPointParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvSGIS(OpenTK.Graphics.OpenGL.SgisPointParameters pname, Single* @params);
            internal unsafe static PointParameterfvSGIS glPointParameterfvSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteri(OpenTK.Graphics.OpenGL.PointParameterName pname, Int32 param);
            internal static PointParameteri glPointParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteriNV(OpenTK.Graphics.OpenGL.NvPointSprite pname, Int32 param);
            internal static PointParameteriNV glPointParameteriNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameteriv(OpenTK.Graphics.OpenGL.PointParameterName pname, Int32* @params);
            internal unsafe static PointParameteriv glPointParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterivNV(OpenTK.Graphics.OpenGL.NvPointSprite pname, Int32* @params);
            internal unsafe static PointParameterivNV glPointParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollAsyncSGIX([OutAttribute] UInt32* markerp);
            internal unsafe static PollAsyncSGIX glPollAsyncSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollInstrumentsSGIX([OutAttribute] Int32* marker_p);
            internal unsafe static PollInstrumentsSGIX glPollInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonMode(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.PolygonMode mode);
            internal static PolygonMode glPolygonMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffsetEXT(Single factor, Single bias);
            internal static PolygonOffsetEXT glPolygonOffsetEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PolygonStipple(Byte* mask);
            internal unsafe static PolygonStipple glPolygonStipple;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopAttrib();
            internal static PopAttrib glPopAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopClientAttrib();
            internal static PopClientAttrib glPopClientAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PopName();
            internal static PopName glPopName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, OpenTK.Graphics.OpenGL.NvPresentVideo type, OpenTK.Graphics.OpenGL.NvPresentVideo target0, UInt32 fill0, OpenTK.Graphics.OpenGL.NvPresentVideo target1, UInt32 fill1, OpenTK.Graphics.OpenGL.NvPresentVideo target2, UInt32 fill2, OpenTK.Graphics.OpenGL.NvPresentVideo target3, UInt32 fill3);
            internal static PresentFrameDualFillNV glPresentFrameDualFillNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, OpenTK.Graphics.OpenGL.NvPresentVideo type, OpenTK.Graphics.OpenGL.NvPresentVideo target0, UInt32 fill0, UInt32 key0, OpenTK.Graphics.OpenGL.NvPresentVideo target1, UInt32 fill1, UInt32 key1);
            internal static PresentFrameKeyedNV glPresentFrameKeyedNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartIndex(UInt32 index);
            internal static PrimitiveRestartIndex glPrimitiveRestartIndex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartIndexNV(UInt32 index);
            internal static PrimitiveRestartIndexNV glPrimitiveRestartIndexNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartNV();
            internal static PrimitiveRestartNV glPrimitiveRestartNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
            internal unsafe static PrioritizeTextures glPrioritizeTextures;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTexturesEXT(Int32 n, UInt32* textures, Single* priorities);
            internal unsafe static PrioritizeTexturesEXT glPrioritizeTexturesEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramBinary(UInt32 program, OpenTK.Graphics.OpenGL.BinaryFormat binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinary glProgramBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersfvNV(OpenTK.Graphics.OpenGL.NvParameterBufferObject target, UInt32 buffer, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramBufferParametersfvNV glProgramBufferParametersfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIivNV(OpenTK.Graphics.OpenGL.NvParameterBufferObject target, UInt32 buffer, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramBufferParametersIivNV glProgramBufferParametersIivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIuivNV(OpenTK.Graphics.OpenGL.NvParameterBufferObject target, UInt32 buffer, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramBufferParametersIuivNV glProgramBufferParametersIuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4dARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramEnvParameter4dARB glProgramEnvParameter4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4dvARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Double* @params);
            internal unsafe static ProgramEnvParameter4dvARB glProgramEnvParameter4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4fARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramEnvParameter4fARB glProgramEnvParameter4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4fvARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Single* @params);
            internal unsafe static ProgramEnvParameter4fvARB glProgramEnvParameter4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4iNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static ProgramEnvParameterI4iNV glProgramEnvParameterI4iNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4ivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32* @params);
            internal unsafe static ProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4uiNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static ProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4uivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, UInt32* @params);
            internal unsafe static ProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameters4fvEXT(OpenTK.Graphics.OpenGL.ExtGpuProgramParameters target, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4ivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4uivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4dARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramLocalParameter4dARB glProgramLocalParameter4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4dvARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Double* @params);
            internal unsafe static ProgramLocalParameter4dvARB glProgramLocalParameter4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4fARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramLocalParameter4fARB glProgramLocalParameter4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4fvARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Single* @params);
            internal unsafe static ProgramLocalParameter4fvARB glProgramLocalParameter4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4iNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static ProgramLocalParameterI4iNV glProgramLocalParameterI4iNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4ivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32* @params);
            internal unsafe static ProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4uiNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static ProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4uivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, UInt32* @params);
            internal unsafe static ProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameters4fvEXT(OpenTK.Graphics.OpenGL.ExtGpuProgramParameters target, UInt32 index, Int32 count, Single* @params);
            internal unsafe static ProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4ivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32 count, Int32* @params);
            internal unsafe static ProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4uivNV(OpenTK.Graphics.OpenGL.NvGpuProgram4 target, UInt32 index, Int32 count, UInt32* @params);
            internal unsafe static ProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dNV(UInt32 id, Int32 len, Byte* name, Double x, Double y, Double z, Double w);
            internal unsafe static ProgramNamedParameter4dNV glProgramNamedParameter4dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dvNV(UInt32 id, Int32 len, Byte* name, Double* v);
            internal unsafe static ProgramNamedParameter4dvNV glProgramNamedParameter4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fNV(UInt32 id, Int32 len, Byte* name, Single x, Single y, Single z, Single w);
            internal unsafe static ProgramNamedParameter4fNV glProgramNamedParameter4fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fvNV(UInt32 id, Int32 len, Byte* name, Single* v);
            internal unsafe static ProgramNamedParameter4fvNV glProgramNamedParameter4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4dNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Double x, Double y, Double z, Double w);
            internal static ProgramParameter4dNV glProgramParameter4dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4dvNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Double* v);
            internal unsafe static ProgramParameter4dvNV glProgramParameter4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4fNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Single x, Single y, Single z, Single w);
            internal static ProgramParameter4fNV glProgramParameter4fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4fvNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Single* v);
            internal unsafe static ProgramParameter4fvNV glProgramParameter4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteri(UInt32 program, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, Int32 value);
            internal static ProgramParameteri glProgramParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriARB(UInt32 program, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, Int32 value);
            internal static ProgramParameteriARB glProgramParameteriARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriEXT(UInt32 program, OpenTK.Graphics.OpenGL.AssemblyProgramParameterArb pname, Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4dvNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Int32 count, Double* v);
            internal unsafe static ProgramParameters4dvNV glProgramParameters4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4fvNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 index, Int32 count, Single* v);
            internal unsafe static ProgramParameters4fvNV glProgramParameters4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramStringARB(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, OpenTK.Graphics.OpenGL.ArbVertexProgram format, Int32 len, IntPtr @string);
            internal static ProgramStringARB glProgramStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramSubroutineParametersuivNV(OpenTK.Graphics.OpenGL.NvGpuProgram5 target, Int32 count, UInt32* @params);
            internal unsafe static ProgramSubroutineParametersuivNV glProgramSubroutineParametersuivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1d(UInt32 program, Int32 location, Double v0);
            internal static ProgramUniform1d glProgramUniform1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1dEXT(UInt32 program, Int32 location, Double x);
            internal static ProgramUniform1dEXT glProgramUniform1dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform1dv glProgramUniform1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform1dvEXT glProgramUniform1dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1f glProgramUniform1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1fEXT(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1fEXT glProgramUniform1fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fv glProgramUniform1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fvEXT glProgramUniform1fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1i glProgramUniform1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1i64NV(UInt32 program, Int32 location, Int64 x);
            internal static ProgramUniform1i64NV glProgramUniform1i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            internal unsafe static ProgramUniform1i64vNV glProgramUniform1i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1iEXT glProgramUniform1iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1iv glProgramUniform1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1ivEXT glProgramUniform1ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1ui glProgramUniform1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1ui64NV(UInt32 program, Int32 location, UInt64 x);
            internal static ProgramUniform1ui64NV glProgramUniform1ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            internal unsafe static ProgramUniform1ui64vNV glProgramUniform1ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1uiEXT glProgramUniform1uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uiv glProgramUniform1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uivEXT glProgramUniform1uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1);
            internal static ProgramUniform2d glProgramUniform2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2dEXT(UInt32 program, Int32 location, Double x, Double y);
            internal static ProgramUniform2dEXT glProgramUniform2dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform2dv glProgramUniform2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform2dvEXT glProgramUniform2dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2f glProgramUniform2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2fEXT(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2fEXT glProgramUniform2fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fv glProgramUniform2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fvEXT glProgramUniform2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2i glProgramUniform2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2i64NV(UInt32 program, Int32 location, Int64 x, Int64 y);
            internal static ProgramUniform2i64NV glProgramUniform2i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            internal unsafe static ProgramUniform2i64vNV glProgramUniform2i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2iEXT glProgramUniform2iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2iv glProgramUniform2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2ivEXT glProgramUniform2ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2ui glProgramUniform2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y);
            internal static ProgramUniform2ui64NV glProgramUniform2ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            internal unsafe static ProgramUniform2ui64vNV glProgramUniform2ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2uiEXT glProgramUniform2uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uiv glProgramUniform2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uivEXT glProgramUniform2uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2);
            internal static ProgramUniform3d glProgramUniform3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3dEXT(UInt32 program, Int32 location, Double x, Double y, Double z);
            internal static ProgramUniform3dEXT glProgramUniform3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform3dv glProgramUniform3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform3dvEXT glProgramUniform3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3f glProgramUniform3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3fEXT glProgramUniform3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fv glProgramUniform3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fvEXT glProgramUniform3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3i glProgramUniform3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);
            internal static ProgramUniform3i64NV glProgramUniform3i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            internal unsafe static ProgramUniform3i64vNV glProgramUniform3i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3iEXT glProgramUniform3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3iv glProgramUniform3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3ivEXT glProgramUniform3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3ui glProgramUniform3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);
            internal static ProgramUniform3ui64NV glProgramUniform3ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            internal unsafe static ProgramUniform3ui64vNV glProgramUniform3ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3uiEXT glProgramUniform3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uiv glProgramUniform3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uivEXT glProgramUniform3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3);
            internal static ProgramUniform4d glProgramUniform4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4dEXT(UInt32 program, Int32 location, Double x, Double y, Double z, Double w);
            internal static ProgramUniform4dEXT glProgramUniform4dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform4dv glProgramUniform4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform4dvEXT glProgramUniform4dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4f glProgramUniform4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4fEXT glProgramUniform4fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fv glProgramUniform4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fvEXT glProgramUniform4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4i glProgramUniform4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);
            internal static ProgramUniform4i64NV glProgramUniform4i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            internal unsafe static ProgramUniform4i64vNV glProgramUniform4i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4iEXT glProgramUniform4iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4iv glProgramUniform4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4ivEXT glProgramUniform4ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4ui glProgramUniform4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
            internal static ProgramUniform4ui64NV glProgramUniform4ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            internal unsafe static ProgramUniform4ui64vNV glProgramUniform4ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4uiEXT glProgramUniform4uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uiv glProgramUniform4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uivEXT glProgramUniform4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2dv glProgramUniformMatrix2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2dvEXT glProgramUniformMatrix2dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fv glProgramUniformMatrix2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x3dvEXT glProgramUniformMatrix2x3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fvEXT glProgramUniformMatrix2x3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x4dvEXT glProgramUniformMatrix2x4dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fvEXT glProgramUniformMatrix2x4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3dv glProgramUniformMatrix3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3dvEXT glProgramUniformMatrix3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fv glProgramUniformMatrix3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x2dvEXT glProgramUniformMatrix3x2dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fvEXT glProgramUniformMatrix3x2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x4dvEXT glProgramUniformMatrix3x4dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fvEXT glProgramUniformMatrix3x4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4dv glProgramUniformMatrix4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4dvEXT glProgramUniformMatrix4dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fv glProgramUniformMatrix4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x2dvEXT glProgramUniformMatrix4x2dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fvEXT glProgramUniformMatrix4x2fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x3dvEXT glProgramUniformMatrix4x3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fvEXT glProgramUniformMatrix4x3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniformui64NV(UInt32 program, Int32 location, UInt64 value);
            internal static ProgramUniformui64NV glProgramUniformui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            internal unsafe static ProgramUniformui64vNV glProgramUniformui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramVertexLimitNV(OpenTK.Graphics.OpenGL.NvGeometryProgram4 target, Int32 limit);
            internal static ProgramVertexLimitNV glProgramVertexLimitNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProvokingVertex(OpenTK.Graphics.OpenGL.ProvokingVertexMode mode);
            internal static ProvokingVertex glProvokingVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ProvokingVertexEXT(OpenTK.Graphics.OpenGL.ExtProvokingVertex mode);
            internal static ProvokingVertexEXT glProvokingVertexEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushAttrib(OpenTK.Graphics.OpenGL.AttribMask mask);
            internal static PushAttrib glPushAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushClientAttrib(OpenTK.Graphics.OpenGL.ClientAttribMask mask);
            internal static PushClientAttrib glPushClientAttrib;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushClientAttribDefaultEXT(OpenTK.Graphics.OpenGL.ClientAttribMask mask);
            internal static PushClientAttribDefaultEXT glPushClientAttribDefaultEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PushName(UInt32 name);
            internal static PushName glPushName;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryCounter(UInt32 id, OpenTK.Graphics.OpenGL.QueryCounterTarget target);
            internal static QueryCounter glQueryCounter;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2d(Double x, Double y);
            internal static RasterPos2d glRasterPos2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2dv(Double* v);
            internal unsafe static RasterPos2dv glRasterPos2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2f(Single x, Single y);
            internal static RasterPos2f glRasterPos2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2fv(Single* v);
            internal unsafe static RasterPos2fv glRasterPos2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2i(Int32 x, Int32 y);
            internal static RasterPos2i glRasterPos2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2iv(Int32* v);
            internal unsafe static RasterPos2iv glRasterPos2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2s(Int16 x, Int16 y);
            internal static RasterPos2s glRasterPos2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2sv(Int16* v);
            internal unsafe static RasterPos2sv glRasterPos2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3d(Double x, Double y, Double z);
            internal static RasterPos3d glRasterPos3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3dv(Double* v);
            internal unsafe static RasterPos3dv glRasterPos3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3f(Single x, Single y, Single z);
            internal static RasterPos3f glRasterPos3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3fv(Single* v);
            internal unsafe static RasterPos3fv glRasterPos3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3i(Int32 x, Int32 y, Int32 z);
            internal static RasterPos3i glRasterPos3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3iv(Int32* v);
            internal unsafe static RasterPos3iv glRasterPos3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3s(Int16 x, Int16 y, Int16 z);
            internal static RasterPos3s glRasterPos3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3sv(Int16* v);
            internal unsafe static RasterPos3sv glRasterPos3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4d(Double x, Double y, Double z, Double w);
            internal static RasterPos4d glRasterPos4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4dv(Double* v);
            internal unsafe static RasterPos4dv glRasterPos4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4f(Single x, Single y, Single z, Single w);
            internal static RasterPos4f glRasterPos4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4fv(Single* v);
            internal unsafe static RasterPos4fv glRasterPos4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static RasterPos4i glRasterPos4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4iv(Int32* v);
            internal unsafe static RasterPos4iv glRasterPos4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static RasterPos4s glRasterPos4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4sv(Int16* v);
            internal unsafe static RasterPos4sv glRasterPos4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBuffer(OpenTK.Graphics.OpenGL.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadInstrumentsSGIX(Int32 marker);
            internal static ReadInstrumentsSGIX glReadInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.ArbRobustness format, OpenTK.Graphics.OpenGL.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsARB glReadnPixelsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectd(Double x1, Double y1, Double x2, Double y2);
            internal static Rectd glRectd;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectdv(Double* v1, Double* v2);
            internal unsafe static Rectdv glRectdv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectf(Single x1, Single y1, Single x2, Single y2);
            internal static Rectf glRectf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectfv(Single* v1, Single* v2);
            internal unsafe static Rectfv glRectfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
            internal static Recti glRecti;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectiv(Int32* v1, Int32* v2);
            internal unsafe static Rectiv glRectiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
            internal static Rects glRects;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectsv(Int16* v1, Int16* v2);
            internal unsafe static Rectsv glRectsv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReferencePlaneSGIX(Double* equation);
            internal unsafe static ReferencePlaneSGIX glReferencePlaneSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.OpenGL.RenderbufferTarget target, OpenTK.Graphics.OpenGL.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageEXT(OpenTK.Graphics.OpenGL.RenderbufferTarget target, OpenTK.Graphics.OpenGL.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageEXT glRenderbufferStorageEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.OpenGL.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleCoverageNV(OpenTK.Graphics.OpenGL.RenderbufferTarget target, Int32 coverageSamples, Int32 colorSamples, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.OpenGL.ExtFramebufferMultisample target, Int32 samples, OpenTK.Graphics.OpenGL.ExtFramebufferMultisample internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 RenderMode(OpenTK.Graphics.OpenGL.RenderingMode mode);
            internal static RenderMode glRenderMode;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodePointerSUN(OpenTK.Graphics.OpenGL.SunTriangleList type, Int32 stride, IntPtr pointer);
            internal static ReplacementCodePointerSUN glReplacementCodePointerSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeubSUN(Byte code);
            internal static ReplacementCodeubSUN glReplacementCodeubSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeubvSUN(Byte* code);
            internal unsafe static ReplacementCodeubvSUN glReplacementCodeubvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, Single* c, Single* v);
            internal unsafe static ReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* c, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static ReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, Byte* c, Single* v);
            internal unsafe static ReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiSUN(UInt32 code);
            internal static ReplacementCodeuiSUN glReplacementCodeuiSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* n, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, Single s, Single t, Single x, Single y, Single z);
            internal static ReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, Single* tc, Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiVertex3fSUN(UInt32 rc, Single x, Single y, Single z);
            internal static ReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiVertex3fvSUN(UInt32* rc, Single* v);
            internal unsafe static ReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuivSUN(UInt32* code);
            internal unsafe static ReplacementCodeuivSUN glReplacementCodeuivSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeusSUN(UInt16 code);
            internal static ReplacementCodeusSUN glReplacementCodeusSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeusvSUN(UInt16* code);
            internal unsafe static ReplacementCodeusvSUN glReplacementCodeusvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RequestResidentProgramsNV(Int32 n, UInt32* programs);
            internal unsafe static RequestResidentProgramsNV glRequestResidentProgramsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogram(OpenTK.Graphics.OpenGL.HistogramTarget target);
            internal static ResetHistogram glResetHistogram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogramEXT(OpenTK.Graphics.OpenGL.ExtHistogram target);
            internal static ResetHistogramEXT glResetHistogramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmax(OpenTK.Graphics.OpenGL.MinmaxTarget target);
            internal static ResetMinmax glResetMinmax;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmaxEXT(OpenTK.Graphics.OpenGL.ExtHistogram target);
            internal static ResetMinmaxEXT glResetMinmaxEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResizeBuffersMESA();
            internal static ResizeBuffersMESA glResizeBuffersMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResumeTransformFeedback();
            internal static ResumeTransformFeedback glResumeTransformFeedback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ResumeTransformFeedbackNV();
            internal static ResumeTransformFeedbackNV glResumeTransformFeedbackNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotated(Double angle, Double x, Double y, Double z);
            internal static Rotated glRotated;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
            internal static Rotatef glRotatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverageARB(Single value, bool invert);
            internal static SampleCoverageARB glSampleCoverageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMapATI(UInt32 dst, UInt32 interp, OpenTK.Graphics.OpenGL.AtiFragmentShader swizzle);
            internal static SampleMapATI glSampleMapATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskEXT(Single value, bool invert);
            internal static SampleMaskEXT glSampleMaskEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaski(UInt32 index, UInt32 mask);
            internal static SampleMaski glSampleMaski;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskIndexedNV(UInt32 index, UInt32 mask);
            internal static SampleMaskIndexedNV glSampleMaskIndexedNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskSGIS(Single value, bool invert);
            internal static SampleMaskSGIS glSampleMaskSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternEXT(OpenTK.Graphics.OpenGL.ExtMultisample pattern);
            internal static SamplePatternEXT glSamplePatternEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternSGIS(OpenTK.Graphics.OpenGL.SgisMultisample pattern);
            internal static SamplePatternSGIS glSamplePatternSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameterf(UInt32 sampler, OpenTK.Graphics.OpenGL.SamplerParameter pname, Single param);
            internal static SamplerParameterf glSamplerParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL.SamplerParameter pname, Single* param);
            internal unsafe static SamplerParameterfv glSamplerParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameteri(UInt32 sampler, OpenTK.Graphics.OpenGL.SamplerParameter pname, Int32 param);
            internal static SamplerParameteri glSamplerParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL.ArbSamplerObjects pname, Int32* param);
            internal unsafe static SamplerParameterIiv glSamplerParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL.ArbSamplerObjects pname, UInt32* param);
            internal unsafe static SamplerParameterIuiv glSamplerParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL.SamplerParameter pname, Int32* param);
            internal unsafe static SamplerParameteriv glSamplerParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scaled(Double x, Double y, Double z);
            internal static Scaled glScaled;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalef(Single x, Single y, Single z);
            internal static Scalef glScalef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ScissorArrayv(UInt32 first, Int32 count, Int32* v);
            internal unsafe static ScissorArrayv glScissorArrayv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            internal static ScissorIndexed glScissorIndexed;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ScissorIndexedv(UInt32 index, Int32* v);
            internal unsafe static ScissorIndexedv glScissorIndexedv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3b(SByte red, SByte green, SByte blue);
            internal static SecondaryColor3b glSecondaryColor3b;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3bEXT(SByte red, SByte green, SByte blue);
            internal static SecondaryColor3bEXT glSecondaryColor3bEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bv(SByte* v);
            internal unsafe static SecondaryColor3bv glSecondaryColor3bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bvEXT(SByte* v);
            internal unsafe static SecondaryColor3bvEXT glSecondaryColor3bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3d(Double red, Double green, Double blue);
            internal static SecondaryColor3d glSecondaryColor3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3dEXT(Double red, Double green, Double blue);
            internal static SecondaryColor3dEXT glSecondaryColor3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dv(Double* v);
            internal unsafe static SecondaryColor3dv glSecondaryColor3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dvEXT(Double* v);
            internal unsafe static SecondaryColor3dvEXT glSecondaryColor3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3f(Single red, Single green, Single blue);
            internal static SecondaryColor3f glSecondaryColor3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3fEXT(Single red, Single green, Single blue);
            internal static SecondaryColor3fEXT glSecondaryColor3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fv(Single* v);
            internal unsafe static SecondaryColor3fv glSecondaryColor3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fvEXT(Single* v);
            internal unsafe static SecondaryColor3fvEXT glSecondaryColor3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3hNV(Half red, Half green, Half blue);
            internal static SecondaryColor3hNV glSecondaryColor3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3hvNV(Half* v);
            internal unsafe static SecondaryColor3hvNV glSecondaryColor3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
            internal static SecondaryColor3i glSecondaryColor3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
            internal static SecondaryColor3iEXT glSecondaryColor3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3iv(Int32* v);
            internal unsafe static SecondaryColor3iv glSecondaryColor3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ivEXT(Int32* v);
            internal unsafe static SecondaryColor3ivEXT glSecondaryColor3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
            internal static SecondaryColor3s glSecondaryColor3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
            internal static SecondaryColor3sEXT glSecondaryColor3sEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3sv(Int16* v);
            internal unsafe static SecondaryColor3sv glSecondaryColor3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3svEXT(Int16* v);
            internal unsafe static SecondaryColor3svEXT glSecondaryColor3svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ub(Byte red, Byte green, Byte blue);
            internal static SecondaryColor3ub glSecondaryColor3ub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ubEXT(Byte red, Byte green, Byte blue);
            internal static SecondaryColor3ubEXT glSecondaryColor3ubEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubv(Byte* v);
            internal unsafe static SecondaryColor3ubv glSecondaryColor3ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubvEXT(Byte* v);
            internal unsafe static SecondaryColor3ubvEXT glSecondaryColor3ubvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
            internal static SecondaryColor3ui glSecondaryColor3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
            internal static SecondaryColor3uiEXT glSecondaryColor3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uiv(UInt32* v);
            internal unsafe static SecondaryColor3uiv glSecondaryColor3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uivEXT(UInt32* v);
            internal unsafe static SecondaryColor3uivEXT glSecondaryColor3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3us glSecondaryColor3us;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
            internal static SecondaryColor3usEXT glSecondaryColor3usEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usv(UInt16* v);
            internal unsafe static SecondaryColor3usv glSecondaryColor3usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usvEXT(UInt16* v);
            internal unsafe static SecondaryColor3usvEXT glSecondaryColor3usvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorFormatNV(Int32 size, OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static SecondaryColorFormatNV glSecondaryColorFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorP3ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 color);
            internal static SecondaryColorP3ui glSecondaryColorP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColorP3uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* color);
            internal unsafe static SecondaryColorP3uiv glSecondaryColorP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointer(Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, Int32 stride, IntPtr pointer);
            internal static SecondaryColorPointer glSecondaryColorPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointerEXT(Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, Int32 stride, IntPtr pointer);
            internal static SecondaryColorPointerEXT glSecondaryColorPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointerListIBM(Int32 size, OpenTK.Graphics.OpenGL.IbmVertexArrayLists type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static SecondaryColorPointerListIBM glSecondaryColorPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SelectBuffer(Int32 size, [OutAttribute] UInt32* buffer);
            internal unsafe static SelectBuffer glSelectBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, [OutAttribute] UInt32* counterList);
            internal unsafe static SelectPerfMonitorCountersAMD glSelectPerfMonitorCountersAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SeparableFilter2D(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr row, IntPtr column);
            internal static SeparableFilter2D glSeparableFilter2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SeparableFilter2DEXT(OpenTK.Graphics.OpenGL.ExtConvolution target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr row, IntPtr column);
            internal static SeparableFilter2DEXT glSeparableFilter2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceAPPLE(UInt32 fence);
            internal static SetFenceAPPLE glSetFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceNV(UInt32 fence, OpenTK.Graphics.OpenGL.NvFence condition);
            internal static SetFenceNV glSetFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetFragmentShaderConstantATI(UInt32 dst, Single* value);
            internal unsafe static SetFragmentShaderConstantATI glSetFragmentShaderConstantATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetInvariantEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader type, IntPtr addr);
            internal static SetInvariantEXT glSetInvariantEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SetLocalConstantEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader type, IntPtr addr);
            internal static SetLocalConstantEXT glSetLocalConstantEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetMultisamplefvAMD(OpenTK.Graphics.OpenGL.AmdSamplePositions pname, UInt32 index, Single* val);
            internal unsafe static SetMultisamplefvAMD glSetMultisamplefvAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShadeModel(OpenTK.Graphics.OpenGL.ShadingModel mode);
            internal static ShadeModel glShadeModel;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.OpenGL.BinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp1EXT(OpenTK.Graphics.OpenGL.ExtVertexShader op, UInt32 res, UInt32 arg1);
            internal static ShaderOp1EXT glShaderOp1EXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp2EXT(OpenTK.Graphics.OpenGL.ExtVertexShader op, UInt32 res, UInt32 arg1, UInt32 arg2);
            internal static ShaderOp2EXT glShaderOp2EXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp3EXT(OpenTK.Graphics.OpenGL.ExtVertexShader op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
            internal static ShaderOp3EXT glShaderOp3EXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSourceARB(UInt32 shaderObj, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSourceARB glShaderSourceARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SharpenTexFuncSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 n, Single* points);
            internal unsafe static SharpenTexFuncSGIS glSharpenTexFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameterfSGIX(OpenTK.Graphics.OpenGL.SgixSprite pname, Single param);
            internal static SpriteParameterfSGIX glSpriteParameterfSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterfvSGIX(OpenTK.Graphics.OpenGL.SgixSprite pname, Single* @params);
            internal unsafe static SpriteParameterfvSGIX glSpriteParameterfvSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameteriSGIX(OpenTK.Graphics.OpenGL.SgixSprite pname, Int32 param);
            internal static SpriteParameteriSGIX glSpriteParameteriSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterivSGIX(OpenTK.Graphics.OpenGL.SgixSprite pname, Int32* @params);
            internal unsafe static SpriteParameterivSGIX glSpriteParameterivSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StartInstrumentsSGIX();
            internal static StartInstrumentsSGIX glStartInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
            internal static StencilClearTagEXT glStencilClearTagEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(OpenTK.Graphics.OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.OpenGL.Version20 face, OpenTK.Graphics.OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparateATI(OpenTK.Graphics.OpenGL.StencilFunction frontfunc, OpenTK.Graphics.OpenGL.StencilFunction backfunc, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparateATI glStencilFuncSeparateATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.OpenGL.StencilFace face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(OpenTK.Graphics.OpenGL.StencilOp fail, OpenTK.Graphics.OpenGL.StencilOp zfail, OpenTK.Graphics.OpenGL.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.OpenGL.StencilFace face, OpenTK.Graphics.OpenGL.StencilOp sfail, OpenTK.Graphics.OpenGL.StencilOp dpfail, OpenTK.Graphics.OpenGL.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparateATI(OpenTK.Graphics.OpenGL.AtiSeparateStencil face, OpenTK.Graphics.OpenGL.StencilOp sfail, OpenTK.Graphics.OpenGL.StencilOp dpfail, OpenTK.Graphics.OpenGL.StencilOp dppass);
            internal static StencilOpSeparateATI glStencilOpSeparateATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StopInstrumentsSGIX(Int32 marker);
            internal static StopInstrumentsSGIX glStopInstrumentsSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StringMarkerGREMEDY(Int32 len, IntPtr @string);
            internal static StringMarkerGREMEDY glStringMarkerGREMEDY;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SwizzleEXT(UInt32 res, UInt32 @in, OpenTK.Graphics.OpenGL.ExtVertexShader outX, OpenTK.Graphics.OpenGL.ExtVertexShader outY, OpenTK.Graphics.OpenGL.ExtVertexShader outZ, OpenTK.Graphics.OpenGL.ExtVertexShader outW);
            internal static SwizzleEXT glSwizzleEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TagSampleBufferSGIX();
            internal static TagSampleBufferSGIX glTagSampleBufferSGIX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3bEXT(SByte tx, SByte ty, SByte tz);
            internal static Tangent3bEXT glTangent3bEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3bvEXT(SByte* v);
            internal unsafe static Tangent3bvEXT glTangent3bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3dEXT(Double tx, Double ty, Double tz);
            internal static Tangent3dEXT glTangent3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3dvEXT(Double* v);
            internal unsafe static Tangent3dvEXT glTangent3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3fEXT(Single tx, Single ty, Single tz);
            internal static Tangent3fEXT glTangent3fEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3fvEXT(Single* v);
            internal unsafe static Tangent3fvEXT glTangent3fvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
            internal static Tangent3iEXT glTangent3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3ivEXT(Int32* v);
            internal unsafe static Tangent3ivEXT glTangent3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
            internal static Tangent3sEXT glTangent3sEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3svEXT(Int16* v);
            internal unsafe static Tangent3svEXT glTangent3svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TangentPointerEXT(OpenTK.Graphics.OpenGL.NormalPointerType type, Int32 stride, IntPtr pointer);
            internal static TangentPointerEXT glTangentPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TbufferMask3DFX(UInt32 mask);
            internal static TbufferMask3DFX glTbufferMask3DFX;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessellationFactorAMD(Single factor);
            internal static TessellationFactorAMD glTessellationFactorAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessellationModeAMD(OpenTK.Graphics.OpenGL.AmdVertexShaderTesselator mode);
            internal static TessellationModeAMD glTessellationModeAMD;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestFenceAPPLE(UInt32 fence);
            internal static TestFenceAPPLE glTestFenceAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestObjectAPPLE(OpenTK.Graphics.OpenGL.AppleFence @object, UInt32 name);
            internal static TestObjectAPPLE glTestObjectAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBuffer(OpenTK.Graphics.OpenGL.TextureBufferTarget target, OpenTK.Graphics.OpenGL.SizedInternalFormat internalformat, UInt32 buffer);
            internal static TexBuffer glTexBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBufferARB(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.ArbTextureBufferObject internalformat, UInt32 buffer);
            internal static TexBufferARB glTexBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBufferEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.ExtTextureBufferObject internalformat, UInt32 buffer);
            internal static TexBufferEXT glTexBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterfvATI(OpenTK.Graphics.OpenGL.AtiEnvmapBumpmap pname, Single* param);
            internal unsafe static TexBumpParameterfvATI glTexBumpParameterfvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterivATI(OpenTK.Graphics.OpenGL.AtiEnvmapBumpmap pname, Int32* param);
            internal unsafe static TexBumpParameterivATI glTexBumpParameterivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1d(Double s);
            internal static TexCoord1d glTexCoord1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1dv(Double* v);
            internal unsafe static TexCoord1dv glTexCoord1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1f(Single s);
            internal static TexCoord1f glTexCoord1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1fv(Single* v);
            internal unsafe static TexCoord1fv glTexCoord1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1hNV(Half s);
            internal static TexCoord1hNV glTexCoord1hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1hvNV(Half* v);
            internal unsafe static TexCoord1hvNV glTexCoord1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1i(Int32 s);
            internal static TexCoord1i glTexCoord1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1iv(Int32* v);
            internal unsafe static TexCoord1iv glTexCoord1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1s(Int16 s);
            internal static TexCoord1s glTexCoord1s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1sv(Int16* v);
            internal unsafe static TexCoord1sv glTexCoord1sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2d(Double s, Double t);
            internal static TexCoord2d glTexCoord2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2dv(Double* v);
            internal unsafe static TexCoord2dv glTexCoord2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2f(Single s, Single t);
            internal static TexCoord2f glTexCoord2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single x, Single y, Single z);
            internal static TexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor3fVertex3fvSUN(Single* tc, Single* c, Single* v);
            internal unsafe static TexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4fNormal3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static TexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static TexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4ubVertex3fSUN(Single s, Single t, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            internal static TexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4ubVertex3fvSUN(Single* tc, Byte* c, Single* v);
            internal unsafe static TexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fNormal3fVertex3fSUN(Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            internal static TexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fNormal3fVertex3fvSUN(Single* tc, Single* n, Single* v);
            internal unsafe static TexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fv(Single* v);
            internal unsafe static TexCoord2fv glTexCoord2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fVertex3fSUN(Single s, Single t, Single x, Single y, Single z);
            internal static TexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fVertex3fvSUN(Single* tc, Single* v);
            internal unsafe static TexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2hNV(Half s, Half t);
            internal static TexCoord2hNV glTexCoord2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2hvNV(Half* v);
            internal unsafe static TexCoord2hvNV glTexCoord2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2i(Int32 s, Int32 t);
            internal static TexCoord2i glTexCoord2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2iv(Int32* v);
            internal unsafe static TexCoord2iv glTexCoord2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2s(Int16 s, Int16 t);
            internal static TexCoord2s glTexCoord2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2sv(Int16* v);
            internal unsafe static TexCoord2sv glTexCoord2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3d(Double s, Double t, Double r);
            internal static TexCoord3d glTexCoord3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3dv(Double* v);
            internal unsafe static TexCoord3dv glTexCoord3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3f(Single s, Single t, Single r);
            internal static TexCoord3f glTexCoord3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3fv(Single* v);
            internal unsafe static TexCoord3fv glTexCoord3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3hNV(Half s, Half t, Half r);
            internal static TexCoord3hNV glTexCoord3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3hvNV(Half* v);
            internal unsafe static TexCoord3hvNV glTexCoord3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3i(Int32 s, Int32 t, Int32 r);
            internal static TexCoord3i glTexCoord3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3iv(Int32* v);
            internal unsafe static TexCoord3iv glTexCoord3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3s(Int16 s, Int16 t, Int16 r);
            internal static TexCoord3s glTexCoord3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3sv(Int16* v);
            internal unsafe static TexCoord3sv glTexCoord3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4d(Double s, Double t, Double r, Double q);
            internal static TexCoord4d glTexCoord4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4dv(Double* v);
            internal unsafe static TexCoord4dv glTexCoord4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4f(Single s, Single t, Single r, Single q);
            internal static TexCoord4f glTexCoord4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fColor4fNormal3fVertex4fSUN(Single s, Single t, Single p, Single q, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z, Single w);
            internal static TexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc, Single* c, Single* n, Single* v);
            internal unsafe static TexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fv(Single* v);
            internal unsafe static TexCoord4fv glTexCoord4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fVertex4fSUN(Single s, Single t, Single p, Single q, Single x, Single y, Single z, Single w);
            internal static TexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fVertex4fvSUN(Single* tc, Single* v);
            internal unsafe static TexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4hNV(Half s, Half t, Half r, Half q);
            internal static TexCoord4hNV glTexCoord4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4hvNV(Half* v);
            internal unsafe static TexCoord4hvNV glTexCoord4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
            internal static TexCoord4i glTexCoord4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4iv(Int32* v);
            internal unsafe static TexCoord4iv glTexCoord4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
            internal static TexCoord4s glTexCoord4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4sv(Int16* v);
            internal unsafe static TexCoord4sv glTexCoord4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordFormatNV(Int32 size, OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static TexCoordFormatNV glTexCoordFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP1ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static TexCoordP1ui glTexCoordP1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP1uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP1uiv glTexCoordP1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP2ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static TexCoordP2ui glTexCoordP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP2uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP2uiv glTexCoordP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP3ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static TexCoordP3ui glTexCoordP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP3uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP3uiv glTexCoordP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP4ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 coords);
            internal static TexCoordP4ui glTexCoordP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP4uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP4uiv glTexCoordP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointer(Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            internal static TexCoordPointer glTexCoordPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointerEXT(Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            internal static TexCoordPointerEXT glTexCoordPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointerListIBM(Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static TexCoordPointerListIBM glTexCoordPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointervINTEL(Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, IntPtr pointer);
            internal static TexCoordPointervINTEL glTexCoordPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvf(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Single param);
            internal static TexEnvf glTexEnvf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvfv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvi(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Int32 param);
            internal static TexEnvi glTexEnvi;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnviv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, Int32* @params);
            internal unsafe static TexEnviv glTexEnviv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexFilterFuncSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.SgisTextureFilter4 filter, Int32 n, Single* weights);
            internal unsafe static TexFilterFuncSGIS glTexFilterFuncSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGend(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Double param);
            internal static TexGend glTexGend;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGendv(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Double* @params);
            internal unsafe static TexGendv glTexGendv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGenf(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Single param);
            internal static TexGenf glTexGenf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGenfv(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Single* @params);
            internal unsafe static TexGenfv glTexGenfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGeni(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Int32 param);
            internal static TexGeni glTexGeni;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGeniv(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, Int32* @params);
            internal unsafe static TexGeniv glTexGeniv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexImage1D glTexImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2DMultisample(OpenTK.Graphics.OpenGL.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            internal static TexImage2DMultisample glTexImage2DMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2DMultisampleCoverageNV(OpenTK.Graphics.OpenGL.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
            internal static TexImage2DMultisampleCoverageNV glTexImage2DMultisampleCoverageNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexImage3D glTexImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexImage3DEXT glTexImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DMultisample(OpenTK.Graphics.OpenGL.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            internal static TexImage3DMultisample glTexImage3DMultisample;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DMultisampleCoverageNV(OpenTK.Graphics.OpenGL.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
            internal static TexImage3DMultisampleCoverageNV glTexImage3DMultisampleCoverageNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage4DSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexImage4DSGIS glTexImage4DSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIiv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameterIiv glTexParameterIiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameterIivEXT glTexParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIuiv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, UInt32* @params);
            internal unsafe static TexParameterIuiv glTexParameterIuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIuivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, UInt32* @params);
            internal unsafe static TexParameterIuivEXT glTexParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexRenderbufferNV(OpenTK.Graphics.OpenGL.TextureTarget target, UInt32 renderbuffer);
            internal static TexRenderbufferNV glTexRenderbufferNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexSubImage1D glTexSubImage1D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage1DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexSubImage1DEXT glTexSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexSubImage2DEXT glTexSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexSubImage3DEXT glTexSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage4DSGIS(OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TexSubImage4DSGIS glTexSubImage4DSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureBarrierNV();
            internal static TextureBarrierNV glTextureBarrierNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureBufferEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, UInt32 buffer);
            internal static TextureBufferEXT glTextureBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);
            internal static TextureColorMaskSGIS glTextureColorMaskSGIS;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage1DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TextureImage1DEXT glTextureImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage2DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TextureImage2DEXT glTextureImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage2DMultisampleCoverageNV(UInt32 texture, OpenTK.Graphics.OpenGL.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
            internal static TextureImage2DMultisampleCoverageNV glTextureImage2DMultisampleCoverageNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage2DMultisampleNV(UInt32 texture, OpenTK.Graphics.OpenGL.NvTextureMultisample target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
            internal static TextureImage2DMultisampleNV glTextureImage2DMultisampleNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage3DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TextureImage3DEXT glTextureImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage3DMultisampleCoverageNV(UInt32 texture, OpenTK.Graphics.OpenGL.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
            internal static TextureImage3DMultisampleCoverageNV glTextureImage3DMultisampleCoverageNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage3DMultisampleNV(UInt32 texture, OpenTK.Graphics.OpenGL.NvTextureMultisample target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
            internal static TextureImage3DMultisampleNV glTextureImage3DMultisampleNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureLightEXT(OpenTK.Graphics.OpenGL.ExtLightTexture pname);
            internal static TextureLightEXT glTextureLightEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureMaterialEXT(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter mode);
            internal static TextureMaterialEXT glTextureMaterialEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureNormalEXT(OpenTK.Graphics.OpenGL.ExtTexturePerturbNormal mode);
            internal static TextureNormalEXT glTextureNormalEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureParameterfEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Single param);
            internal static TextureParameterfEXT glTextureParameterfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterfvEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Single* @params);
            internal unsafe static TextureParameterfvEXT glTextureParameterfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureParameteriEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32 param);
            internal static TextureParameteriEXT glTextureParameteriEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterIivEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32* @params);
            internal unsafe static TextureParameterIivEXT glTextureParameterIivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterIuivEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, UInt32* @params);
            internal unsafe static TextureParameterIuivEXT glTextureParameterIuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterivEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, Int32* @params);
            internal unsafe static TextureParameterivEXT glTextureParameterivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureRangeAPPLE(OpenTK.Graphics.OpenGL.AppleTextureRange target, Int32 length, IntPtr pointer);
            internal static TextureRangeAPPLE glTextureRangeAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureRenderbufferEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, UInt32 renderbuffer);
            internal static TextureRenderbufferEXT glTextureRenderbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureSubImage1DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TextureSubImage1DEXT glTextureSubImage1DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureSubImage2DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TextureSubImage2DEXT glTextureSubImage2DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureSubImage3DEXT(UInt32 texture, OpenTK.Graphics.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, IntPtr pixels);
            internal static TextureSubImage3DEXT glTextureSubImage3DEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TrackMatrixNV(OpenTK.Graphics.OpenGL.AssemblyProgramTargetArb target, UInt32 address, OpenTK.Graphics.OpenGL.NvVertexProgram matrix, OpenTK.Graphics.OpenGL.NvVertexProgram transform);
            internal static TrackMatrixNV glTrackMatrixNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackAttribsNV(UInt32 count, Int32* attribs, OpenTK.Graphics.OpenGL.NvTransformFeedback bufferMode);
            internal unsafe static TransformFeedbackAttribsNV glTransformFeedbackAttribsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackStreamAttribsNV(Int32 count, Int32* attribs, Int32 nbuffers, Int32* bufstreams, OpenTK.Graphics.OpenGL.NvTransformFeedback bufferMode);
            internal unsafe static TransformFeedbackStreamAttribsNV glTransformFeedbackStreamAttribsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.OpenGL.TransformFeedbackMode bufferMode);
            internal static TransformFeedbackVaryings glTransformFeedbackVaryings;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TransformFeedbackVaryingsEXT(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.OpenGL.ExtTransformFeedback bufferMode);
            internal static TransformFeedbackVaryingsEXT glTransformFeedbackVaryingsEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, OpenTK.Graphics.OpenGL.NvTransformFeedback bufferMode);
            internal unsafe static TransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translated(Double x, Double y, Double z);
            internal static Translated glTranslated;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatef(Single x, Single y, Single z);
            internal static Translatef glTranslatef;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1d(Int32 location, Double x);
            internal static Uniform1d glUniform1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform1dv glUniform1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1f(Int32 location, Single v0);
            internal static Uniform1f glUniform1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1fARB(Int32 location, Single v0);
            internal static Uniform1fARB glUniform1fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fv glUniform1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fvARB glUniform1fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i(Int32 location, Int32 v0);
            internal static Uniform1i glUniform1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i64NV(Int32 location, Int64 x);
            internal static Uniform1i64NV glUniform1i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1i64vNV(Int32 location, Int32 count, Int64* value);
            internal unsafe static Uniform1i64vNV glUniform1i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1iARB(Int32 location, Int32 v0);
            internal static Uniform1iARB glUniform1iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1iv glUniform1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1ivARB glUniform1ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1ui(Int32 location, UInt32 v0);
            internal static Uniform1ui glUniform1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1ui64NV(Int32 location, UInt64 x);
            internal static Uniform1ui64NV glUniform1ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1ui64vNV(Int32 location, Int32 count, UInt64* value);
            internal unsafe static Uniform1ui64vNV glUniform1ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1uiEXT(Int32 location, UInt32 v0);
            internal static Uniform1uiEXT glUniform1uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uiv glUniform1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uivEXT glUniform1uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2d(Int32 location, Double x, Double y);
            internal static Uniform2d glUniform2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform2dv glUniform2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
            internal static Uniform2f glUniform2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2fARB(Int32 location, Single v0, Single v1);
            internal static Uniform2fARB glUniform2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fv glUniform2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fvARB glUniform2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2i glUniform2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i64NV(Int32 location, Int64 x, Int64 y);
            internal static Uniform2i64NV glUniform2i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2i64vNV(Int32 location, Int32 count, Int64* value);
            internal unsafe static Uniform2i64vNV glUniform2i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2iARB(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2iARB glUniform2iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2iv glUniform2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2ivARB glUniform2ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2ui glUniform2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2ui64NV(Int32 location, UInt64 x, UInt64 y);
            internal static Uniform2ui64NV glUniform2ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2ui64vNV(Int32 location, Int32 count, UInt64* value);
            internal unsafe static Uniform2ui64vNV glUniform2ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2uiEXT glUniform2uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uiv glUniform2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uivEXT glUniform2uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3d(Int32 location, Double x, Double y, Double z);
            internal static Uniform3d glUniform3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform3dv glUniform3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3f glUniform3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3fARB(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3fARB glUniform3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fv glUniform3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fvARB glUniform3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3i glUniform3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i64NV(Int32 location, Int64 x, Int64 y, Int64 z);
            internal static Uniform3i64NV glUniform3i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3i64vNV(Int32 location, Int32 count, Int64* value);
            internal unsafe static Uniform3i64vNV glUniform3i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3iARB glUniform3iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3iv glUniform3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3ivARB glUniform3ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3ui glUniform3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z);
            internal static Uniform3ui64NV glUniform3ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3ui64vNV(Int32 location, Int32 count, UInt64* value);
            internal unsafe static Uniform3ui64vNV glUniform3ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3uiEXT glUniform3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uiv glUniform3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uivEXT glUniform3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4d(Int32 location, Double x, Double y, Double z, Double w);
            internal static Uniform4d glUniform4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform4dv glUniform4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4f glUniform4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4fARB(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4fARB glUniform4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fv glUniform4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fvARB(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fvARB glUniform4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4i glUniform4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i64NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);
            internal static Uniform4i64NV glUniform4i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4i64vNV(Int32 location, Int32 count, Int64* value);
            internal unsafe static Uniform4i64vNV glUniform4i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4iARB glUniform4iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4iv glUniform4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4ivARB(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4ivARB glUniform4ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4ui glUniform4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
            internal static Uniform4ui64NV glUniform4ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4ui64vNV(Int32 location, Int32 count, UInt64* value);
            internal unsafe static Uniform4ui64vNV glUniform4ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4uiEXT glUniform4uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uiv glUniform4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4uivEXT(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uivEXT glUniform4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            internal static UniformBlockBinding glUniformBlockBinding;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
            internal static UniformBufferEXT glUniformBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2dv glUniformMatrix2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fvARB(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fvARB glUniformMatrix2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x3dv glUniformMatrix2x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x4dv glUniformMatrix2x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3dv glUniformMatrix3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fvARB(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fvARB glUniformMatrix3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x2dv glUniformMatrix3x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x4dv glUniformMatrix3x4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4dv glUniformMatrix4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fvARB(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fvARB glUniformMatrix4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x2dv glUniformMatrix4x2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x3dv glUniformMatrix4x3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformSubroutinesuiv(OpenTK.Graphics.OpenGL.ShaderType shadertype, Int32 count, UInt32* indices);
            internal unsafe static UniformSubroutinesuiv glUniformSubroutinesuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniformui64NV(Int32 location, UInt64 value);
            internal static Uniformui64NV glUniformui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniformui64vNV(Int32 location, Int32 count, UInt64* value);
            internal unsafe static Uniformui64vNV glUniformui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UnlockArraysEXT();
            internal static UnlockArraysEXT glUnlockArraysEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBuffer(OpenTK.Graphics.OpenGL.BufferTarget target);
            internal static UnmapBuffer glUnmapBuffer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBufferARB(OpenTK.Graphics.OpenGL.BufferTargetArb target);
            internal static UnmapBufferARB glUnmapBufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapNamedBufferEXT(UInt32 buffer);
            internal static UnmapNamedBufferEXT glUnmapNamedBufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UnmapObjectBufferATI(UInt32 buffer);
            internal static UnmapObjectBufferATI glUnmapObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, OpenTK.Graphics.OpenGL.AtiVertexArrayObject preserve);
            internal static UpdateObjectBufferATI glUpdateObjectBufferATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramObjectARB(UInt32 programObj);
            internal static UseProgramObjectARB glUseProgramObjectARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramStages(UInt32 pipeline, OpenTK.Graphics.OpenGL.ProgramStageMask stages, UInt32 program);
            internal static UseProgramStages glUseProgramStages;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseShaderProgramEXT(OpenTK.Graphics.OpenGL.ExtSeparateShaderObjects type, UInt32 program);
            internal static UseShaderProgramEXT glUseShaderProgramEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramARB(UInt32 programObj);
            internal static ValidateProgramARB glValidateProgramARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramPipeline(UInt32 pipeline);
            internal static ValidateProgramPipeline glValidateProgramPipeline;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VariantArrayObjectATI(UInt32 id, OpenTK.Graphics.OpenGL.AtiVertexArrayObject type, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static VariantArrayObjectATI glVariantArrayObjectATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantbvEXT(UInt32 id, SByte* addr);
            internal unsafe static VariantbvEXT glVariantbvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantdvEXT(UInt32 id, Double* addr);
            internal unsafe static VariantdvEXT glVariantdvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantfvEXT(UInt32 id, Single* addr);
            internal unsafe static VariantfvEXT glVariantfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantivEXT(UInt32 id, Int32* addr);
            internal unsafe static VariantivEXT glVariantivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VariantPointerEXT(UInt32 id, OpenTK.Graphics.OpenGL.ExtVertexShader type, UInt32 stride, IntPtr addr);
            internal static VariantPointerEXT glVariantPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantsvEXT(UInt32 id, Int16* addr);
            internal unsafe static VariantsvEXT glVariantsvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantubvEXT(UInt32 id, Byte* addr);
            internal unsafe static VariantubvEXT glVariantubvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantuivEXT(UInt32 id, UInt32* addr);
            internal unsafe static VariantuivEXT glVariantuivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantusvEXT(UInt32 id, UInt16* addr);
            internal unsafe static VariantusvEXT glVariantusvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUFiniNV();
            internal static VDPAUFiniNV glVDPAUFiniNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VDPAUGetSurfaceivNV(IntPtr surface, OpenTK.Graphics.OpenGL.NvVdpauInterop pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static VDPAUGetSurfaceivNV glVDPAUGetSurfaceivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);
            internal static VDPAUInitNV glVDPAUInitNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUIsSurfaceNV(IntPtr surface);
            internal static VDPAUIsSurfaceNV glVDPAUIsSurfaceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VDPAUMapSurfacesNV(Int32 numSurfaces, IntPtr* surfaces);
            internal unsafe static VDPAUMapSurfacesNV glVDPAUMapSurfacesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr VDPAURegisterOutputSurfaceNV([OutAttribute] IntPtr vdpSurface, OpenTK.Graphics.OpenGL.NvVdpauInterop target, Int32 numTextureNames, UInt32* textureNames);
            internal unsafe static VDPAURegisterOutputSurfaceNV glVDPAURegisterOutputSurfaceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr VDPAURegisterVideoSurfaceNV([OutAttribute] IntPtr vdpSurface, OpenTK.Graphics.OpenGL.NvVdpauInterop target, Int32 numTextureNames, UInt32* textureNames);
            internal unsafe static VDPAURegisterVideoSurfaceNV glVDPAURegisterVideoSurfaceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUSurfaceAccessNV(IntPtr surface, OpenTK.Graphics.OpenGL.NvVdpauInterop access);
            internal static VDPAUSurfaceAccessNV glVDPAUSurfaceAccessNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VDPAUUnmapSurfacesNV(Int32 numSurface, IntPtr* surfaces);
            internal unsafe static VDPAUUnmapSurfacesNV glVDPAUUnmapSurfacesNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUUnregisterSurfaceNV(IntPtr surface);
            internal static VDPAUUnregisterSurfaceNV glVDPAUUnregisterSurfaceNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2d(Double x, Double y);
            internal static Vertex2d glVertex2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2dv(Double* v);
            internal unsafe static Vertex2dv glVertex2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2f(Single x, Single y);
            internal static Vertex2f glVertex2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2fv(Single* v);
            internal unsafe static Vertex2fv glVertex2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2hNV(Half x, Half y);
            internal static Vertex2hNV glVertex2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2hvNV(Half* v);
            internal unsafe static Vertex2hvNV glVertex2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2i(Int32 x, Int32 y);
            internal static Vertex2i glVertex2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2iv(Int32* v);
            internal unsafe static Vertex2iv glVertex2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2s(Int16 x, Int16 y);
            internal static Vertex2s glVertex2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2sv(Int16* v);
            internal unsafe static Vertex2sv glVertex2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3d(Double x, Double y, Double z);
            internal static Vertex3d glVertex3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3dv(Double* v);
            internal unsafe static Vertex3dv glVertex3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3f(Single x, Single y, Single z);
            internal static Vertex3f glVertex3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3fv(Single* v);
            internal unsafe static Vertex3fv glVertex3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3hNV(Half x, Half y, Half z);
            internal static Vertex3hNV glVertex3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3hvNV(Half* v);
            internal unsafe static Vertex3hvNV glVertex3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3i(Int32 x, Int32 y, Int32 z);
            internal static Vertex3i glVertex3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3iv(Int32* v);
            internal unsafe static Vertex3iv glVertex3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3s(Int16 x, Int16 y, Int16 z);
            internal static Vertex3s glVertex3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3sv(Int16* v);
            internal unsafe static Vertex3sv glVertex3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4d(Double x, Double y, Double z, Double w);
            internal static Vertex4d glVertex4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4dv(Double* v);
            internal unsafe static Vertex4dv glVertex4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4f(Single x, Single y, Single z, Single w);
            internal static Vertex4f glVertex4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4fv(Single* v);
            internal unsafe static Vertex4fv glVertex4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4hNV(Half x, Half y, Half z, Half w);
            internal static Vertex4hNV glVertex4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4hvNV(Half* v);
            internal unsafe static Vertex4hvNV glVertex4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static Vertex4i glVertex4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4iv(Int32* v);
            internal unsafe static Vertex4iv glVertex4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static Vertex4s glVertex4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4sv(Int16* v);
            internal unsafe static Vertex4sv glVertex4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayParameteriAPPLE(OpenTK.Graphics.OpenGL.AppleVertexArrayRange pname, Int32 param);
            internal static VertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayRangeAPPLE(Int32 length, [OutAttribute] IntPtr pointer);
            internal static VertexArrayRangeAPPLE glVertexArrayRangeAPPLE;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayRangeNV(Int32 length, IntPtr pointer);
            internal static VertexArrayRangeNV glVertexArrayRangeNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.ExtVertexAttrib64bit type, Int32 stride, IntPtr offset);
            internal static VertexArrayVertexAttribLOffsetEXT glVertexArrayVertexAttribLOffsetEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1d(UInt32 index, Double x);
            internal static VertexAttrib1d glVertexAttrib1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dARB(UInt32 index, Double x);
            internal static VertexAttrib1dARB glVertexAttrib1dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dNV(UInt32 index, Double x);
            internal static VertexAttrib1dNV glVertexAttrib1dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dv glVertexAttrib1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dvARB glVertexAttrib1dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dvNV glVertexAttrib1dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fARB(UInt32 index, Single x);
            internal static VertexAttrib1fARB glVertexAttrib1fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fNV(UInt32 index, Single x);
            internal static VertexAttrib1fNV glVertexAttrib1fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fvARB glVertexAttrib1fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fvNV glVertexAttrib1fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1hNV(UInt32 index, Half x);
            internal static VertexAttrib1hNV glVertexAttrib1hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1hvNV(UInt32 index, Half* v);
            internal unsafe static VertexAttrib1hvNV glVertexAttrib1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1s(UInt32 index, Int16 x);
            internal static VertexAttrib1s glVertexAttrib1s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sARB(UInt32 index, Int16 x);
            internal static VertexAttrib1sARB glVertexAttrib1sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sNV(UInt32 index, Int16 x);
            internal static VertexAttrib1sNV glVertexAttrib1sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1sv glVertexAttrib1sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1svARB glVertexAttrib1svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1svNV glVertexAttrib1svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2d(UInt32 index, Double x, Double y);
            internal static VertexAttrib2d glVertexAttrib2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dARB(UInt32 index, Double x, Double y);
            internal static VertexAttrib2dARB glVertexAttrib2dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dNV(UInt32 index, Double x, Double y);
            internal static VertexAttrib2dNV glVertexAttrib2dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dv glVertexAttrib2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dvARB glVertexAttrib2dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dvNV glVertexAttrib2dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fARB(UInt32 index, Single x, Single y);
            internal static VertexAttrib2fARB glVertexAttrib2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fNV(UInt32 index, Single x, Single y);
            internal static VertexAttrib2fNV glVertexAttrib2fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fvARB glVertexAttrib2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fvNV glVertexAttrib2fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2hNV(UInt32 index, Half x, Half y);
            internal static VertexAttrib2hNV glVertexAttrib2hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2hvNV(UInt32 index, Half* v);
            internal unsafe static VertexAttrib2hvNV glVertexAttrib2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2s glVertexAttrib2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2sARB glVertexAttrib2sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2sNV glVertexAttrib2sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2sv glVertexAttrib2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2svARB glVertexAttrib2svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2svNV glVertexAttrib2svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3d glVertexAttrib3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dARB(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3dARB glVertexAttrib3dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dNV(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3dNV glVertexAttrib3dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dv glVertexAttrib3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dvARB glVertexAttrib3dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dvNV glVertexAttrib3dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fARB(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3fARB glVertexAttrib3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fNV(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3fNV glVertexAttrib3fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fvARB glVertexAttrib3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fvNV glVertexAttrib3fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3hNV(UInt32 index, Half x, Half y, Half z);
            internal static VertexAttrib3hNV glVertexAttrib3hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3hvNV(UInt32 index, Half* v);
            internal unsafe static VertexAttrib3hvNV glVertexAttrib3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3s glVertexAttrib3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3sARB glVertexAttrib3sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3sNV glVertexAttrib3sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3sv glVertexAttrib3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3svARB glVertexAttrib3svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3svNV glVertexAttrib3svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bv glVertexAttrib4bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bvARB(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bvARB glVertexAttrib4bvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4d glVertexAttrib4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dARB(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4dARB glVertexAttrib4dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dNV(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4dNV glVertexAttrib4dNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dv glVertexAttrib4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvARB(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dvARB glVertexAttrib4dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvNV(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dvNV glVertexAttrib4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fARB(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4fARB glVertexAttrib4fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fNV(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4fNV glVertexAttrib4fNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvARB(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fvARB glVertexAttrib4fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvNV(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fvNV glVertexAttrib4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4hNV(UInt32 index, Half x, Half y, Half z, Half w);
            internal static VertexAttrib4hNV glVertexAttrib4hNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4hvNV(UInt32 index, Half* v);
            internal unsafe static VertexAttrib4hvNV glVertexAttrib4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4iv glVertexAttrib4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ivARB(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4ivARB glVertexAttrib4ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nbv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NbvARB(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4NbvARB glVertexAttrib4NbvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Niv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NivARB(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4NivARB glVertexAttrib4NivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nsv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NsvARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4NsvARB glVertexAttrib4NsvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4Nub glVertexAttrib4Nub;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4NubARB(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4NubARB glVertexAttrib4NubARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NubvARB(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4NubvARB glVertexAttrib4NubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NuivARB(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4NuivARB glVertexAttrib4NuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NusvARB(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4NusvARB glVertexAttrib4NusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4s glVertexAttrib4s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4sARB glVertexAttrib4sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4sNV glVertexAttrib4sNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4sv glVertexAttrib4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svARB(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4svARB glVertexAttrib4svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svNV(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4svNV glVertexAttrib4svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4ubNV(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4ubNV glVertexAttrib4ubNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvARB(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubvARB glVertexAttrib4ubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvNV(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubvNV glVertexAttrib4ubvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uivARB(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uivARB glVertexAttrib4uivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usv glVertexAttrib4usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usvARB(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usvARB glVertexAttrib4usvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribArrayObjectATI(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.AtiVertexAttribArrayObject type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);
            internal static VertexAttribArrayObjectATI glVertexAttribArrayObjectATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisor glVertexAttribDivisor;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisorARB(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisorARB glVertexAttribDivisorARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribFormatNV(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, bool normalized, Int32 stride);
            internal static VertexAttribFormatNV glVertexAttribFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1i(UInt32 index, Int32 x);
            internal static VertexAttribI1i glVertexAttribI1i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1iEXT(UInt32 index, Int32 x);
            internal static VertexAttribI1iEXT glVertexAttribI1iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI1iv glVertexAttribI1iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI1ivEXT glVertexAttribI1ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1ui(UInt32 index, UInt32 x);
            internal static VertexAttribI1ui glVertexAttribI1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1uiEXT(UInt32 index, UInt32 x);
            internal static VertexAttribI1uiEXT glVertexAttribI1uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI1uiv glVertexAttribI1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI1uivEXT glVertexAttribI1uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2i(UInt32 index, Int32 x, Int32 y);
            internal static VertexAttribI2i glVertexAttribI2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
            internal static VertexAttribI2iEXT glVertexAttribI2iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI2iv glVertexAttribI2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI2ivEXT glVertexAttribI2ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);
            internal static VertexAttribI2ui glVertexAttribI2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
            internal static VertexAttribI2uiEXT glVertexAttribI2uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI2uiv glVertexAttribI2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI2uivEXT glVertexAttribI2uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);
            internal static VertexAttribI3i glVertexAttribI3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
            internal static VertexAttribI3iEXT glVertexAttribI3iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI3iv glVertexAttribI3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI3ivEXT glVertexAttribI3ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            internal static VertexAttribI3ui glVertexAttribI3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            internal static VertexAttribI3uiEXT glVertexAttribI3uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI3uiv glVertexAttribI3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI3uivEXT glVertexAttribI3uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttribI4bv glVertexAttribI4bv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4bvEXT(UInt32 index, SByte* v);
            internal unsafe static VertexAttribI4bvEXT glVertexAttribI4bvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4i glVertexAttribI4i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4iEXT glVertexAttribI4iEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4iv glVertexAttribI4iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ivEXT(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4ivEXT glVertexAttribI4ivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttribI4sv glVertexAttribI4sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4svEXT(UInt32 index, Int16* v);
            internal unsafe static VertexAttribI4svEXT glVertexAttribI4svEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttribI4ubv glVertexAttribI4ubv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ubvEXT(UInt32 index, Byte* v);
            internal unsafe static VertexAttribI4ubvEXT glVertexAttribI4ubvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4ui glVertexAttribI4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4uiEXT glVertexAttribI4uiEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uivEXT(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uivEXT glVertexAttribI4uivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttribI4usv glVertexAttribI4usv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4usvEXT(UInt32 index, UInt16* v);
            internal unsafe static VertexAttribI4usvEXT glVertexAttribI4usvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIFormatNV(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static VertexAttribIFormatNV glVertexAttribIFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointer glVertexAttribIPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIPointerEXT(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.NvVertexProgram4 type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointerEXT glVertexAttribIPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1d(UInt32 index, Double x);
            internal static VertexAttribL1d glVertexAttribL1d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1dEXT(UInt32 index, Double x);
            internal static VertexAttribL1dEXT glVertexAttribL1dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL1dv glVertexAttribL1dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1dvEXT(UInt32 index, Double* v);
            internal unsafe static VertexAttribL1dvEXT glVertexAttribL1dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1i64NV(UInt32 index, Int64 x);
            internal static VertexAttribL1i64NV glVertexAttribL1i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1i64vNV(UInt32 index, Int64* v);
            internal unsafe static VertexAttribL1i64vNV glVertexAttribL1i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1ui64NV(UInt32 index, UInt64 x);
            internal static VertexAttribL1ui64NV glVertexAttribL1ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1ui64vNV(UInt32 index, UInt64* v);
            internal unsafe static VertexAttribL1ui64vNV glVertexAttribL1ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2d(UInt32 index, Double x, Double y);
            internal static VertexAttribL2d glVertexAttribL2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2dEXT(UInt32 index, Double x, Double y);
            internal static VertexAttribL2dEXT glVertexAttribL2dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL2dv glVertexAttribL2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2dvEXT(UInt32 index, Double* v);
            internal unsafe static VertexAttribL2dvEXT glVertexAttribL2dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);
            internal static VertexAttribL2i64NV glVertexAttribL2i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2i64vNV(UInt32 index, Int64* v);
            internal unsafe static VertexAttribL2i64vNV glVertexAttribL2i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);
            internal static VertexAttribL2ui64NV glVertexAttribL2ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2ui64vNV(UInt32 index, UInt64* v);
            internal unsafe static VertexAttribL2ui64vNV glVertexAttribL2ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttribL3d glVertexAttribL3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3dEXT(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttribL3dEXT glVertexAttribL3dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL3dv glVertexAttribL3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3dvEXT(UInt32 index, Double* v);
            internal unsafe static VertexAttribL3dvEXT glVertexAttribL3dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);
            internal static VertexAttribL3i64NV glVertexAttribL3i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3i64vNV(UInt32 index, Int64* v);
            internal unsafe static VertexAttribL3i64vNV glVertexAttribL3i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);
            internal static VertexAttribL3ui64NV glVertexAttribL3ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3ui64vNV(UInt32 index, UInt64* v);
            internal unsafe static VertexAttribL3ui64vNV glVertexAttribL3ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttribL4d glVertexAttribL4d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4dEXT(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttribL4dEXT glVertexAttribL4dEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL4dv glVertexAttribL4dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4dvEXT(UInt32 index, Double* v);
            internal unsafe static VertexAttribL4dvEXT glVertexAttribL4dvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);
            internal static VertexAttribL4i64NV glVertexAttribL4i64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4i64vNV(UInt32 index, Int64* v);
            internal unsafe static VertexAttribL4i64vNV glVertexAttribL4i64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
            internal static VertexAttribL4ui64NV glVertexAttribL4ui64NV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4ui64vNV(UInt32 index, UInt64* v);
            internal unsafe static VertexAttribL4ui64vNV glVertexAttribL4ui64vNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLFormatNV(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.NvVertexAttribInteger64bit type, Int32 stride);
            internal static VertexAttribLFormatNV glVertexAttribLFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.VertexAttribDPointerType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribLPointer glVertexAttribLPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLPointerEXT(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.ExtVertexAttrib64bit type, Int32 stride, IntPtr pointer);
            internal static VertexAttribLPointerEXT glVertexAttribLPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP1ui(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP1ui glVertexAttribP1ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP1uiv(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP1uiv glVertexAttribP1uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP2ui(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP2ui glVertexAttribP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP2uiv(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP2uiv glVertexAttribP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP3ui(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP3ui glVertexAttribP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP3uiv(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP3uiv glVertexAttribP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP4ui(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP4ui glVertexAttribP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP4uiv(UInt32 index, OpenTK.Graphics.OpenGL.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP4uiv glVertexAttribP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointerARB(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerTypeArb type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointerARB glVertexAttribPointerARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointerNV(UInt32 index, Int32 fsize, OpenTK.Graphics.OpenGL.VertexAttribParameterArb type, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointerNV glVertexAttribPointerNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs1dvNV glVertexAttribs1dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs1fvNV glVertexAttribs1fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1hvNV(UInt32 index, Int32 n, Half* v);
            internal unsafe static VertexAttribs1hvNV glVertexAttribs1hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs1svNV glVertexAttribs1svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs2dvNV glVertexAttribs2dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs2fvNV glVertexAttribs2fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2hvNV(UInt32 index, Int32 n, Half* v);
            internal unsafe static VertexAttribs2hvNV glVertexAttribs2hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs2svNV glVertexAttribs2svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs3dvNV glVertexAttribs3dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs3fvNV glVertexAttribs3fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3hvNV(UInt32 index, Int32 n, Half* v);
            internal unsafe static VertexAttribs3hvNV glVertexAttribs3hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs3svNV glVertexAttribs3svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4dvNV(UInt32 index, Int32 count, Double* v);
            internal unsafe static VertexAttribs4dvNV glVertexAttribs4dvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4fvNV(UInt32 index, Int32 count, Single* v);
            internal unsafe static VertexAttribs4fvNV glVertexAttribs4fvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4hvNV(UInt32 index, Int32 n, Half* v);
            internal unsafe static VertexAttribs4hvNV glVertexAttribs4hvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
            internal unsafe static VertexAttribs4svNV glVertexAttribs4svNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4ubvNV(UInt32 index, Int32 count, Byte* v);
            internal unsafe static VertexAttribs4ubvNV glVertexAttribs4ubvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendARB(Int32 count);
            internal static VertexBlendARB glVertexBlendARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnvfATI(OpenTK.Graphics.OpenGL.AtiVertexStreams pname, Single param);
            internal static VertexBlendEnvfATI glVertexBlendEnvfATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnviATI(OpenTK.Graphics.OpenGL.AtiVertexStreams pname, Int32 param);
            internal static VertexBlendEnviATI glVertexBlendEnviATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexFormatNV(Int32 size, OpenTK.Graphics.OpenGL.NvVertexBufferUnifiedMemory type, Int32 stride);
            internal static VertexFormatNV glVertexFormatNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP2ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 value);
            internal static VertexP2ui glVertexP2ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP2uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP2uiv glVertexP2uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP3ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 value);
            internal static VertexP3ui glVertexP3ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP3uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP3uiv glVertexP3uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP4ui(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32 value);
            internal static VertexP4ui glVertexP4ui;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP4uiv(OpenTK.Graphics.OpenGL.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP4uiv glVertexP4uiv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointer(Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, Int32 stride, IntPtr pointer);
            internal static VertexPointer glVertexPointer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointerEXT(Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            internal static VertexPointerEXT glVertexPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointerListIBM(Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            internal static VertexPointerListIBM glVertexPointerListIBM;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointervINTEL(Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, IntPtr pointer);
            internal static VertexPointervINTEL glVertexPointervINTEL;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1dATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double x);
            internal static VertexStream1dATI glVertexStream1dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1dvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double* coords);
            internal unsafe static VertexStream1dvATI glVertexStream1dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1fATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single x);
            internal static VertexStream1fATI glVertexStream1fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1fvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single* coords);
            internal unsafe static VertexStream1fvATI glVertexStream1fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1iATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32 x);
            internal static VertexStream1iATI glVertexStream1iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1ivATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32* coords);
            internal unsafe static VertexStream1ivATI glVertexStream1ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1sATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16 x);
            internal static VertexStream1sATI glVertexStream1sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1svATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16* coords);
            internal unsafe static VertexStream1svATI glVertexStream1svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2dATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double x, Double y);
            internal static VertexStream2dATI glVertexStream2dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2dvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double* coords);
            internal unsafe static VertexStream2dvATI glVertexStream2dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2fATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single x, Single y);
            internal static VertexStream2fATI glVertexStream2fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2fvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single* coords);
            internal unsafe static VertexStream2fvATI glVertexStream2fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2iATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32 x, Int32 y);
            internal static VertexStream2iATI glVertexStream2iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2ivATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32* coords);
            internal unsafe static VertexStream2ivATI glVertexStream2ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2sATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16 x, Int16 y);
            internal static VertexStream2sATI glVertexStream2sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2svATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16* coords);
            internal unsafe static VertexStream2svATI glVertexStream2svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3dATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double x, Double y, Double z);
            internal static VertexStream3dATI glVertexStream3dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3dvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double* coords);
            internal unsafe static VertexStream3dvATI glVertexStream3dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3fATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single x, Single y, Single z);
            internal static VertexStream3fATI glVertexStream3fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3fvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single* coords);
            internal unsafe static VertexStream3fvATI glVertexStream3fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3iATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32 x, Int32 y, Int32 z);
            internal static VertexStream3iATI glVertexStream3iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3ivATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32* coords);
            internal unsafe static VertexStream3ivATI glVertexStream3ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3sATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16 x, Int16 y, Int16 z);
            internal static VertexStream3sATI glVertexStream3sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3svATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16* coords);
            internal unsafe static VertexStream3svATI glVertexStream3svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4dATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double x, Double y, Double z, Double w);
            internal static VertexStream4dATI glVertexStream4dATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4dvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Double* coords);
            internal unsafe static VertexStream4dvATI glVertexStream4dvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4fATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single x, Single y, Single z, Single w);
            internal static VertexStream4fATI glVertexStream4fATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4fvATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Single* coords);
            internal unsafe static VertexStream4fvATI glVertexStream4fvATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4iATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexStream4iATI glVertexStream4iATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4ivATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int32* coords);
            internal unsafe static VertexStream4ivATI glVertexStream4ivATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4sATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexStream4sATI glVertexStream4sATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4svATI(OpenTK.Graphics.OpenGL.AtiVertexStreams stream, Int16* coords);
            internal unsafe static VertexStream4svATI glVertexStream4svATI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeightfEXT(Single weight);
            internal static VertexWeightfEXT glVertexWeightfEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeightfvEXT(Single* weight);
            internal unsafe static VertexWeightfvEXT glVertexWeightfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeighthNV(Half weight);
            internal static VertexWeighthNV glVertexWeighthNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeighthvNV(Half* weight);
            internal unsafe static VertexWeighthvNV glVertexWeighthvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeightPointerEXT(Int32 size, OpenTK.Graphics.OpenGL.ExtVertexWeighting type, Int32 stride, IntPtr pointer);
            internal static VertexWeightPointerEXT glVertexWeightPointerEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate OpenTK.Graphics.OpenGL.NvVideoCapture VideoCaptureNV(UInt32 video_capture_slot, [OutAttribute] UInt32* sequence_num, [OutAttribute] UInt64* capture_time);
            internal unsafe static VideoCaptureNV glVideoCaptureNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VideoCaptureStreamParameterdvNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture pname, Double* @params);
            internal unsafe static VideoCaptureStreamParameterdvNV glVideoCaptureStreamParameterdvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VideoCaptureStreamParameterfvNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture pname, Single* @params);
            internal unsafe static VideoCaptureStreamParameterfvNV glVideoCaptureStreamParameterfvNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VideoCaptureStreamParameterivNV(UInt32 video_capture_slot, UInt32 stream, OpenTK.Graphics.OpenGL.NvVideoCapture pname, Int32* @params);
            internal unsafe static VideoCaptureStreamParameterivNV glVideoCaptureStreamParameterivNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ViewportArrayv(UInt32 first, Int32 count, Single* v);
            internal unsafe static ViewportArrayv glViewportArrayv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            internal static ViewportIndexedf glViewportIndexedf;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ViewportIndexedfv(UInt32 index, Single* v);
            internal unsafe static ViewportIndexedfv glViewportIndexedfv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static WaitSync glWaitSync;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightbvARB(Int32 size, SByte* weights);
            internal unsafe static WeightbvARB glWeightbvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightdvARB(Int32 size, Double* weights);
            internal unsafe static WeightdvARB glWeightdvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightfvARB(Int32 size, Single* weights);
            internal unsafe static WeightfvARB glWeightfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightivARB(Int32 size, Int32* weights);
            internal unsafe static WeightivARB glWeightivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WeightPointerARB(Int32 size, OpenTK.Graphics.OpenGL.ArbVertexBlend type, Int32 stride, IntPtr pointer);
            internal static WeightPointerARB glWeightPointerARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightsvARB(Int32 size, Int16* weights);
            internal unsafe static WeightsvARB glWeightsvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightubvARB(Int32 size, Byte* weights);
            internal unsafe static WeightubvARB glWeightubvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightuivARB(Int32 size, UInt32* weights);
            internal unsafe static WeightuivARB glWeightuivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightusvARB(Int32 size, UInt16* weights);
            internal unsafe static WeightusvARB glWeightusvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2d(Double x, Double y);
            internal static WindowPos2d glWindowPos2d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dARB(Double x, Double y);
            internal static WindowPos2dARB glWindowPos2dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dMESA(Double x, Double y);
            internal static WindowPos2dMESA glWindowPos2dMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dv(Double* v);
            internal unsafe static WindowPos2dv glWindowPos2dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvARB(Double* v);
            internal unsafe static WindowPos2dvARB glWindowPos2dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvMESA(Double* v);
            internal unsafe static WindowPos2dvMESA glWindowPos2dvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2f(Single x, Single y);
            internal static WindowPos2f glWindowPos2f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fARB(Single x, Single y);
            internal static WindowPos2fARB glWindowPos2fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fMESA(Single x, Single y);
            internal static WindowPos2fMESA glWindowPos2fMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fv(Single* v);
            internal unsafe static WindowPos2fv glWindowPos2fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvARB(Single* v);
            internal unsafe static WindowPos2fvARB glWindowPos2fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvMESA(Single* v);
            internal unsafe static WindowPos2fvMESA glWindowPos2fvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2i(Int32 x, Int32 y);
            internal static WindowPos2i glWindowPos2i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iARB(Int32 x, Int32 y);
            internal static WindowPos2iARB glWindowPos2iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iMESA(Int32 x, Int32 y);
            internal static WindowPos2iMESA glWindowPos2iMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2iv(Int32* v);
            internal unsafe static WindowPos2iv glWindowPos2iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivARB(Int32* v);
            internal unsafe static WindowPos2ivARB glWindowPos2ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivMESA(Int32* v);
            internal unsafe static WindowPos2ivMESA glWindowPos2ivMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2s(Int16 x, Int16 y);
            internal static WindowPos2s glWindowPos2s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sARB(Int16 x, Int16 y);
            internal static WindowPos2sARB glWindowPos2sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sMESA(Int16 x, Int16 y);
            internal static WindowPos2sMESA glWindowPos2sMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2sv(Int16* v);
            internal unsafe static WindowPos2sv glWindowPos2sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svARB(Int16* v);
            internal unsafe static WindowPos2svARB glWindowPos2svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svMESA(Int16* v);
            internal unsafe static WindowPos2svMESA glWindowPos2svMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3d(Double x, Double y, Double z);
            internal static WindowPos3d glWindowPos3d;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dARB(Double x, Double y, Double z);
            internal static WindowPos3dARB glWindowPos3dARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dMESA(Double x, Double y, Double z);
            internal static WindowPos3dMESA glWindowPos3dMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dv(Double* v);
            internal unsafe static WindowPos3dv glWindowPos3dv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvARB(Double* v);
            internal unsafe static WindowPos3dvARB glWindowPos3dvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvMESA(Double* v);
            internal unsafe static WindowPos3dvMESA glWindowPos3dvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3f(Single x, Single y, Single z);
            internal static WindowPos3f glWindowPos3f;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fARB(Single x, Single y, Single z);
            internal static WindowPos3fARB glWindowPos3fARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fMESA(Single x, Single y, Single z);
            internal static WindowPos3fMESA glWindowPos3fMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fv(Single* v);
            internal unsafe static WindowPos3fv glWindowPos3fv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvARB(Single* v);
            internal unsafe static WindowPos3fvARB glWindowPos3fvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvMESA(Single* v);
            internal unsafe static WindowPos3fvMESA glWindowPos3fvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3i(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3i glWindowPos3i;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iARB(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3iARB glWindowPos3iARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iMESA(Int32 x, Int32 y, Int32 z);
            internal static WindowPos3iMESA glWindowPos3iMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3iv(Int32* v);
            internal unsafe static WindowPos3iv glWindowPos3iv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivARB(Int32* v);
            internal unsafe static WindowPos3ivARB glWindowPos3ivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivMESA(Int32* v);
            internal unsafe static WindowPos3ivMESA glWindowPos3ivMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3s(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3s glWindowPos3s;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sARB(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3sARB glWindowPos3sARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sMESA(Int16 x, Int16 y, Int16 z);
            internal static WindowPos3sMESA glWindowPos3sMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3sv(Int16* v);
            internal unsafe static WindowPos3sv glWindowPos3sv;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svARB(Int16* v);
            internal unsafe static WindowPos3svARB glWindowPos3svARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svMESA(Int16* v);
            internal unsafe static WindowPos3svMESA glWindowPos3svMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4dMESA(Double x, Double y, Double z, Double w);
            internal static WindowPos4dMESA glWindowPos4dMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4dvMESA(Double* v);
            internal unsafe static WindowPos4dvMESA glWindowPos4dvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4fMESA(Single x, Single y, Single z, Single w);
            internal static WindowPos4fMESA glWindowPos4fMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4fvMESA(Single* v);
            internal unsafe static WindowPos4fvMESA glWindowPos4fvMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
            internal static WindowPos4iMESA glWindowPos4iMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4ivMESA(Int32* v);
            internal unsafe static WindowPos4ivMESA glWindowPos4ivMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
            internal static WindowPos4sMESA glWindowPos4sMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4svMESA(Int16* v);
            internal unsafe static WindowPos4svMESA glWindowPos4svMESA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WriteMaskEXT(UInt32 res, UInt32 @in, OpenTK.Graphics.OpenGL.ExtVertexShader outX, OpenTK.Graphics.OpenGL.ExtVertexShader outY, OpenTK.Graphics.OpenGL.ExtVertexShader outZ, OpenTK.Graphics.OpenGL.ExtVertexShader outW);
            internal static WriteMaskEXT glWriteMaskEXT;
        }
    }
}
