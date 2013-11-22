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
        public GL()
        {
            IGraphicsContextInternal context = GraphicsContext.CurrentContext as IGraphicsContextInternal;
            if (context == null) throw new GraphicsContextMissingException();

            Delegates.glAccumxOES = (Delegates.AccumxOES)GetExtensionDelegate("glAccumxOES", typeof(Delegates.AccumxOES));
            Delegates.glActiveTexture = (Delegates.ActiveTexture)GetExtensionDelegate("glActiveTexture", typeof(Delegates.ActiveTexture));
            Delegates.glAlphaFunc = (Delegates.AlphaFunc)GetExtensionDelegate("glAlphaFunc", typeof(Delegates.AlphaFunc));
            Delegates.glAlphaFuncx = (Delegates.AlphaFuncx)GetExtensionDelegate("glAlphaFuncx", typeof(Delegates.AlphaFuncx));
            Delegates.glAlphaFuncxOES = (Delegates.AlphaFuncxOES)GetExtensionDelegate("glAlphaFuncxOES", typeof(Delegates.AlphaFuncxOES));
            Delegates.glBindBuffer = (Delegates.BindBuffer)GetExtensionDelegate("glBindBuffer", typeof(Delegates.BindBuffer));
            Delegates.glBindFramebufferOES = (Delegates.BindFramebufferOES)GetExtensionDelegate("glBindFramebufferOES", typeof(Delegates.BindFramebufferOES));
            Delegates.glBindRenderbufferOES = (Delegates.BindRenderbufferOES)GetExtensionDelegate("glBindRenderbufferOES", typeof(Delegates.BindRenderbufferOES));
            Delegates.glBindTexture = (Delegates.BindTexture)GetExtensionDelegate("glBindTexture", typeof(Delegates.BindTexture));
            Delegates.glBindVertexArrayOES = (Delegates.BindVertexArrayOES)GetExtensionDelegate("glBindVertexArrayOES", typeof(Delegates.BindVertexArrayOES));
            Delegates.glBitmapxOES = (Delegates.BitmapxOES)GetExtensionDelegate("glBitmapxOES", typeof(Delegates.BitmapxOES));
            Delegates.glBlendColorxOES = (Delegates.BlendColorxOES)GetExtensionDelegate("glBlendColorxOES", typeof(Delegates.BlendColorxOES));
            Delegates.glBlendEquationEXT = (Delegates.BlendEquationEXT)GetExtensionDelegate("glBlendEquationEXT", typeof(Delegates.BlendEquationEXT));
            Delegates.glBlendEquationOES = (Delegates.BlendEquationOES)GetExtensionDelegate("glBlendEquationOES", typeof(Delegates.BlendEquationOES));
            Delegates.glBlendEquationSeparateOES = (Delegates.BlendEquationSeparateOES)GetExtensionDelegate("glBlendEquationSeparateOES", typeof(Delegates.BlendEquationSeparateOES));
            Delegates.glBlendFunc = (Delegates.BlendFunc)GetExtensionDelegate("glBlendFunc", typeof(Delegates.BlendFunc));
            Delegates.glBlendFuncSeparateOES = (Delegates.BlendFuncSeparateOES)GetExtensionDelegate("glBlendFuncSeparateOES", typeof(Delegates.BlendFuncSeparateOES));
            Delegates.glBufferData = (Delegates.BufferData)GetExtensionDelegate("glBufferData", typeof(Delegates.BufferData));
            Delegates.glBufferSubData = (Delegates.BufferSubData)GetExtensionDelegate("glBufferSubData", typeof(Delegates.BufferSubData));
            Delegates.glCheckFramebufferStatusOES = (Delegates.CheckFramebufferStatusOES)GetExtensionDelegate("glCheckFramebufferStatusOES", typeof(Delegates.CheckFramebufferStatusOES));
            Delegates.glClear = (Delegates.Clear)GetExtensionDelegate("glClear", typeof(Delegates.Clear));
            Delegates.glClearAccumxOES = (Delegates.ClearAccumxOES)GetExtensionDelegate("glClearAccumxOES", typeof(Delegates.ClearAccumxOES));
            Delegates.glClearColor = (Delegates.ClearColor)GetExtensionDelegate("glClearColor", typeof(Delegates.ClearColor));
            Delegates.glClearColorx = (Delegates.ClearColorx)GetExtensionDelegate("glClearColorx", typeof(Delegates.ClearColorx));
            Delegates.glClearColorxOES = (Delegates.ClearColorxOES)GetExtensionDelegate("glClearColorxOES", typeof(Delegates.ClearColorxOES));
            Delegates.glClearDepthf = (Delegates.ClearDepthf)GetExtensionDelegate("glClearDepthf", typeof(Delegates.ClearDepthf));
            Delegates.glClearDepthfOES = (Delegates.ClearDepthfOES)GetExtensionDelegate("glClearDepthfOES", typeof(Delegates.ClearDepthfOES));
            Delegates.glClearDepthx = (Delegates.ClearDepthx)GetExtensionDelegate("glClearDepthx", typeof(Delegates.ClearDepthx));
            Delegates.glClearDepthxOES = (Delegates.ClearDepthxOES)GetExtensionDelegate("glClearDepthxOES", typeof(Delegates.ClearDepthxOES));
            Delegates.glClearStencil = (Delegates.ClearStencil)GetExtensionDelegate("glClearStencil", typeof(Delegates.ClearStencil));
            Delegates.glClientActiveTexture = (Delegates.ClientActiveTexture)GetExtensionDelegate("glClientActiveTexture", typeof(Delegates.ClientActiveTexture));
            Delegates.glClientWaitSyncAPPLE = (Delegates.ClientWaitSyncAPPLE)GetExtensionDelegate("glClientWaitSyncAPPLE", typeof(Delegates.ClientWaitSyncAPPLE));
            Delegates.glClipPlanef = (Delegates.ClipPlanef)GetExtensionDelegate("glClipPlanef", typeof(Delegates.ClipPlanef));
            Delegates.glClipPlanefIMG = (Delegates.ClipPlanefIMG)GetExtensionDelegate("glClipPlanefIMG", typeof(Delegates.ClipPlanefIMG));
            Delegates.glClipPlanefOES = (Delegates.ClipPlanefOES)GetExtensionDelegate("glClipPlanefOES", typeof(Delegates.ClipPlanefOES));
            Delegates.glClipPlanex = (Delegates.ClipPlanex)GetExtensionDelegate("glClipPlanex", typeof(Delegates.ClipPlanex));
            Delegates.glClipPlanexIMG = (Delegates.ClipPlanexIMG)GetExtensionDelegate("glClipPlanexIMG", typeof(Delegates.ClipPlanexIMG));
            Delegates.glClipPlanexOES = (Delegates.ClipPlanexOES)GetExtensionDelegate("glClipPlanexOES", typeof(Delegates.ClipPlanexOES));
            Delegates.glColor3xOES = (Delegates.Color3xOES)GetExtensionDelegate("glColor3xOES", typeof(Delegates.Color3xOES));
            Delegates.glColor3xvOES = (Delegates.Color3xvOES)GetExtensionDelegate("glColor3xvOES", typeof(Delegates.Color3xvOES));
            Delegates.glColor4f = (Delegates.Color4f)GetExtensionDelegate("glColor4f", typeof(Delegates.Color4f));
            Delegates.glColor4ub = (Delegates.Color4ub)GetExtensionDelegate("glColor4ub", typeof(Delegates.Color4ub));
            Delegates.glColor4x = (Delegates.Color4x)GetExtensionDelegate("glColor4x", typeof(Delegates.Color4x));
            Delegates.glColor4xOES = (Delegates.Color4xOES)GetExtensionDelegate("glColor4xOES", typeof(Delegates.Color4xOES));
            Delegates.glColor4xvOES = (Delegates.Color4xvOES)GetExtensionDelegate("glColor4xvOES", typeof(Delegates.Color4xvOES));
            Delegates.glColorMask = (Delegates.ColorMask)GetExtensionDelegate("glColorMask", typeof(Delegates.ColorMask));
            Delegates.glColorPointer = (Delegates.ColorPointer)GetExtensionDelegate("glColorPointer", typeof(Delegates.ColorPointer));
            Delegates.glCompressedTexImage2D = (Delegates.CompressedTexImage2D)GetExtensionDelegate("glCompressedTexImage2D", typeof(Delegates.CompressedTexImage2D));
            Delegates.glCompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)GetExtensionDelegate("glCompressedTexSubImage2D", typeof(Delegates.CompressedTexSubImage2D));
            Delegates.glConvolutionParameterxOES = (Delegates.ConvolutionParameterxOES)GetExtensionDelegate("glConvolutionParameterxOES", typeof(Delegates.ConvolutionParameterxOES));
            Delegates.glConvolutionParameterxvOES = (Delegates.ConvolutionParameterxvOES)GetExtensionDelegate("glConvolutionParameterxvOES", typeof(Delegates.ConvolutionParameterxvOES));
            Delegates.glCopyTexImage2D = (Delegates.CopyTexImage2D)GetExtensionDelegate("glCopyTexImage2D", typeof(Delegates.CopyTexImage2D));
            Delegates.glCopyTexSubImage2D = (Delegates.CopyTexSubImage2D)GetExtensionDelegate("glCopyTexSubImage2D", typeof(Delegates.CopyTexSubImage2D));
            Delegates.glCopyTextureLevelsAPPLE = (Delegates.CopyTextureLevelsAPPLE)GetExtensionDelegate("glCopyTextureLevelsAPPLE", typeof(Delegates.CopyTextureLevelsAPPLE));
            Delegates.glCullFace = (Delegates.CullFace)GetExtensionDelegate("glCullFace", typeof(Delegates.CullFace));
            Delegates.glCurrentPaletteMatrixOES = (Delegates.CurrentPaletteMatrixOES)GetExtensionDelegate("glCurrentPaletteMatrixOES", typeof(Delegates.CurrentPaletteMatrixOES));
            Delegates.glDeleteBuffers = (Delegates.DeleteBuffers)GetExtensionDelegate("glDeleteBuffers", typeof(Delegates.DeleteBuffers));
            Delegates.glDeleteFencesNV = (Delegates.DeleteFencesNV)GetExtensionDelegate("glDeleteFencesNV", typeof(Delegates.DeleteFencesNV));
            Delegates.glDeleteFramebuffersOES = (Delegates.DeleteFramebuffersOES)GetExtensionDelegate("glDeleteFramebuffersOES", typeof(Delegates.DeleteFramebuffersOES));
            Delegates.glDeleteRenderbuffersOES = (Delegates.DeleteRenderbuffersOES)GetExtensionDelegate("glDeleteRenderbuffersOES", typeof(Delegates.DeleteRenderbuffersOES));
            Delegates.glDeleteSyncAPPLE = (Delegates.DeleteSyncAPPLE)GetExtensionDelegate("glDeleteSyncAPPLE", typeof(Delegates.DeleteSyncAPPLE));
            Delegates.glDeleteTextures = (Delegates.DeleteTextures)GetExtensionDelegate("glDeleteTextures", typeof(Delegates.DeleteTextures));
            Delegates.glDeleteVertexArraysOES = (Delegates.DeleteVertexArraysOES)GetExtensionDelegate("glDeleteVertexArraysOES", typeof(Delegates.DeleteVertexArraysOES));
            Delegates.glDepthFunc = (Delegates.DepthFunc)GetExtensionDelegate("glDepthFunc", typeof(Delegates.DepthFunc));
            Delegates.glDepthMask = (Delegates.DepthMask)GetExtensionDelegate("glDepthMask", typeof(Delegates.DepthMask));
            Delegates.glDepthRangef = (Delegates.DepthRangef)GetExtensionDelegate("glDepthRangef", typeof(Delegates.DepthRangef));
            Delegates.glDepthRangefOES = (Delegates.DepthRangefOES)GetExtensionDelegate("glDepthRangefOES", typeof(Delegates.DepthRangefOES));
            Delegates.glDepthRangex = (Delegates.DepthRangex)GetExtensionDelegate("glDepthRangex", typeof(Delegates.DepthRangex));
            Delegates.glDepthRangexOES = (Delegates.DepthRangexOES)GetExtensionDelegate("glDepthRangexOES", typeof(Delegates.DepthRangexOES));
            Delegates.glDisable = (Delegates.Disable)GetExtensionDelegate("glDisable", typeof(Delegates.Disable));
            Delegates.glDisableClientState = (Delegates.DisableClientState)GetExtensionDelegate("glDisableClientState", typeof(Delegates.DisableClientState));
            Delegates.glDisableDriverControlQCOM = (Delegates.DisableDriverControlQCOM)GetExtensionDelegate("glDisableDriverControlQCOM", typeof(Delegates.DisableDriverControlQCOM));
            Delegates.glDiscardFramebufferEXT = (Delegates.DiscardFramebufferEXT)GetExtensionDelegate("glDiscardFramebufferEXT", typeof(Delegates.DiscardFramebufferEXT));
            Delegates.glDrawArrays = (Delegates.DrawArrays)GetExtensionDelegate("glDrawArrays", typeof(Delegates.DrawArrays));
            Delegates.glDrawElements = (Delegates.DrawElements)GetExtensionDelegate("glDrawElements", typeof(Delegates.DrawElements));
            Delegates.glDrawTexfOES = (Delegates.DrawTexfOES)GetExtensionDelegate("glDrawTexfOES", typeof(Delegates.DrawTexfOES));
            Delegates.glDrawTexfvOES = (Delegates.DrawTexfvOES)GetExtensionDelegate("glDrawTexfvOES", typeof(Delegates.DrawTexfvOES));
            Delegates.glDrawTexiOES = (Delegates.DrawTexiOES)GetExtensionDelegate("glDrawTexiOES", typeof(Delegates.DrawTexiOES));
            Delegates.glDrawTexivOES = (Delegates.DrawTexivOES)GetExtensionDelegate("glDrawTexivOES", typeof(Delegates.DrawTexivOES));
            Delegates.glDrawTexsOES = (Delegates.DrawTexsOES)GetExtensionDelegate("glDrawTexsOES", typeof(Delegates.DrawTexsOES));
            Delegates.glDrawTexsvOES = (Delegates.DrawTexsvOES)GetExtensionDelegate("glDrawTexsvOES", typeof(Delegates.DrawTexsvOES));
            Delegates.glDrawTexxOES = (Delegates.DrawTexxOES)GetExtensionDelegate("glDrawTexxOES", typeof(Delegates.DrawTexxOES));
            Delegates.glDrawTexxvOES = (Delegates.DrawTexxvOES)GetExtensionDelegate("glDrawTexxvOES", typeof(Delegates.DrawTexxvOES));
            Delegates.glEGLImageTargetRenderbufferStorageOES = (Delegates.EGLImageTargetRenderbufferStorageOES)GetExtensionDelegate("glEGLImageTargetRenderbufferStorageOES", typeof(Delegates.EGLImageTargetRenderbufferStorageOES));
            Delegates.glEGLImageTargetTexture2DOES = (Delegates.EGLImageTargetTexture2DOES)GetExtensionDelegate("glEGLImageTargetTexture2DOES", typeof(Delegates.EGLImageTargetTexture2DOES));
            Delegates.glEnable = (Delegates.Enable)GetExtensionDelegate("glEnable", typeof(Delegates.Enable));
            Delegates.glEnableClientState = (Delegates.EnableClientState)GetExtensionDelegate("glEnableClientState", typeof(Delegates.EnableClientState));
            Delegates.glEnableDriverControlQCOM = (Delegates.EnableDriverControlQCOM)GetExtensionDelegate("glEnableDriverControlQCOM", typeof(Delegates.EnableDriverControlQCOM));
            Delegates.glEndTilingQCOM = (Delegates.EndTilingQCOM)GetExtensionDelegate("glEndTilingQCOM", typeof(Delegates.EndTilingQCOM));
            Delegates.glEvalCoord1xOES = (Delegates.EvalCoord1xOES)GetExtensionDelegate("glEvalCoord1xOES", typeof(Delegates.EvalCoord1xOES));
            Delegates.glEvalCoord1xvOES = (Delegates.EvalCoord1xvOES)GetExtensionDelegate("glEvalCoord1xvOES", typeof(Delegates.EvalCoord1xvOES));
            Delegates.glEvalCoord2xOES = (Delegates.EvalCoord2xOES)GetExtensionDelegate("glEvalCoord2xOES", typeof(Delegates.EvalCoord2xOES));
            Delegates.glEvalCoord2xvOES = (Delegates.EvalCoord2xvOES)GetExtensionDelegate("glEvalCoord2xvOES", typeof(Delegates.EvalCoord2xvOES));
            Delegates.glExtGetBufferPointervQCOM = (Delegates.ExtGetBufferPointervQCOM)GetExtensionDelegate("glExtGetBufferPointervQCOM", typeof(Delegates.ExtGetBufferPointervQCOM));
            Delegates.glExtGetBuffersQCOM = (Delegates.ExtGetBuffersQCOM)GetExtensionDelegate("glExtGetBuffersQCOM", typeof(Delegates.ExtGetBuffersQCOM));
            Delegates.glExtGetFramebuffersQCOM = (Delegates.ExtGetFramebuffersQCOM)GetExtensionDelegate("glExtGetFramebuffersQCOM", typeof(Delegates.ExtGetFramebuffersQCOM));
            Delegates.glExtGetProgramBinarySourceQCOM = (Delegates.ExtGetProgramBinarySourceQCOM)GetExtensionDelegate("glExtGetProgramBinarySourceQCOM", typeof(Delegates.ExtGetProgramBinarySourceQCOM));
            Delegates.glExtGetProgramsQCOM = (Delegates.ExtGetProgramsQCOM)GetExtensionDelegate("glExtGetProgramsQCOM", typeof(Delegates.ExtGetProgramsQCOM));
            Delegates.glExtGetRenderbuffersQCOM = (Delegates.ExtGetRenderbuffersQCOM)GetExtensionDelegate("glExtGetRenderbuffersQCOM", typeof(Delegates.ExtGetRenderbuffersQCOM));
            Delegates.glExtGetShadersQCOM = (Delegates.ExtGetShadersQCOM)GetExtensionDelegate("glExtGetShadersQCOM", typeof(Delegates.ExtGetShadersQCOM));
            Delegates.glExtGetTexLevelParameterivQCOM = (Delegates.ExtGetTexLevelParameterivQCOM)GetExtensionDelegate("glExtGetTexLevelParameterivQCOM", typeof(Delegates.ExtGetTexLevelParameterivQCOM));
            Delegates.glExtGetTexSubImageQCOM = (Delegates.ExtGetTexSubImageQCOM)GetExtensionDelegate("glExtGetTexSubImageQCOM", typeof(Delegates.ExtGetTexSubImageQCOM));
            Delegates.glExtGetTexturesQCOM = (Delegates.ExtGetTexturesQCOM)GetExtensionDelegate("glExtGetTexturesQCOM", typeof(Delegates.ExtGetTexturesQCOM));
            Delegates.glExtIsProgramBinaryQCOM = (Delegates.ExtIsProgramBinaryQCOM)GetExtensionDelegate("glExtIsProgramBinaryQCOM", typeof(Delegates.ExtIsProgramBinaryQCOM));
            Delegates.glExtTexObjectStateOverrideiQCOM = (Delegates.ExtTexObjectStateOverrideiQCOM)GetExtensionDelegate("glExtTexObjectStateOverrideiQCOM", typeof(Delegates.ExtTexObjectStateOverrideiQCOM));
            Delegates.glFeedbackBufferxOES = (Delegates.FeedbackBufferxOES)GetExtensionDelegate("glFeedbackBufferxOES", typeof(Delegates.FeedbackBufferxOES));
            Delegates.glFenceSyncAPPLE = (Delegates.FenceSyncAPPLE)GetExtensionDelegate("glFenceSyncAPPLE", typeof(Delegates.FenceSyncAPPLE));
            Delegates.glFinish = (Delegates.Finish)GetExtensionDelegate("glFinish", typeof(Delegates.Finish));
            Delegates.glFinishFenceNV = (Delegates.FinishFenceNV)GetExtensionDelegate("glFinishFenceNV", typeof(Delegates.FinishFenceNV));
            Delegates.glFlush = (Delegates.Flush)GetExtensionDelegate("glFlush", typeof(Delegates.Flush));
            Delegates.glFlushMappedBufferRangeEXT = (Delegates.FlushMappedBufferRangeEXT)GetExtensionDelegate("glFlushMappedBufferRangeEXT", typeof(Delegates.FlushMappedBufferRangeEXT));
            Delegates.glFogf = (Delegates.Fogf)GetExtensionDelegate("glFogf", typeof(Delegates.Fogf));
            Delegates.glFogfv = (Delegates.Fogfv)GetExtensionDelegate("glFogfv", typeof(Delegates.Fogfv));
            Delegates.glFogx = (Delegates.Fogx)GetExtensionDelegate("glFogx", typeof(Delegates.Fogx));
            Delegates.glFogxOES = (Delegates.FogxOES)GetExtensionDelegate("glFogxOES", typeof(Delegates.FogxOES));
            Delegates.glFogxv = (Delegates.Fogxv)GetExtensionDelegate("glFogxv", typeof(Delegates.Fogxv));
            Delegates.glFogxvOES = (Delegates.FogxvOES)GetExtensionDelegate("glFogxvOES", typeof(Delegates.FogxvOES));
            Delegates.glFramebufferRenderbufferOES = (Delegates.FramebufferRenderbufferOES)GetExtensionDelegate("glFramebufferRenderbufferOES", typeof(Delegates.FramebufferRenderbufferOES));
            Delegates.glFramebufferTexture2DMultisampleEXT = (Delegates.FramebufferTexture2DMultisampleEXT)GetExtensionDelegate("glFramebufferTexture2DMultisampleEXT", typeof(Delegates.FramebufferTexture2DMultisampleEXT));
            Delegates.glFramebufferTexture2DMultisampleIMG = (Delegates.FramebufferTexture2DMultisampleIMG)GetExtensionDelegate("glFramebufferTexture2DMultisampleIMG", typeof(Delegates.FramebufferTexture2DMultisampleIMG));
            Delegates.glFramebufferTexture2DOES = (Delegates.FramebufferTexture2DOES)GetExtensionDelegate("glFramebufferTexture2DOES", typeof(Delegates.FramebufferTexture2DOES));
            Delegates.glFrontFace = (Delegates.FrontFace)GetExtensionDelegate("glFrontFace", typeof(Delegates.FrontFace));
            Delegates.glFrustumf = (Delegates.Frustumf)GetExtensionDelegate("glFrustumf", typeof(Delegates.Frustumf));
            Delegates.glFrustumfOES = (Delegates.FrustumfOES)GetExtensionDelegate("glFrustumfOES", typeof(Delegates.FrustumfOES));
            Delegates.glFrustumx = (Delegates.Frustumx)GetExtensionDelegate("glFrustumx", typeof(Delegates.Frustumx));
            Delegates.glFrustumxOES = (Delegates.FrustumxOES)GetExtensionDelegate("glFrustumxOES", typeof(Delegates.FrustumxOES));
            Delegates.glGenBuffers = (Delegates.GenBuffers)GetExtensionDelegate("glGenBuffers", typeof(Delegates.GenBuffers));
            Delegates.glGenerateMipmapOES = (Delegates.GenerateMipmapOES)GetExtensionDelegate("glGenerateMipmapOES", typeof(Delegates.GenerateMipmapOES));
            Delegates.glGenFencesNV = (Delegates.GenFencesNV)GetExtensionDelegate("glGenFencesNV", typeof(Delegates.GenFencesNV));
            Delegates.glGenFramebuffersOES = (Delegates.GenFramebuffersOES)GetExtensionDelegate("glGenFramebuffersOES", typeof(Delegates.GenFramebuffersOES));
            Delegates.glGenRenderbuffersOES = (Delegates.GenRenderbuffersOES)GetExtensionDelegate("glGenRenderbuffersOES", typeof(Delegates.GenRenderbuffersOES));
            Delegates.glGenTextures = (Delegates.GenTextures)GetExtensionDelegate("glGenTextures", typeof(Delegates.GenTextures));
            Delegates.glGenVertexArraysOES = (Delegates.GenVertexArraysOES)GetExtensionDelegate("glGenVertexArraysOES", typeof(Delegates.GenVertexArraysOES));
            Delegates.glGetBooleanv = (Delegates.GetBooleanv)GetExtensionDelegate("glGetBooleanv", typeof(Delegates.GetBooleanv));
            Delegates.glGetBufferParameteriv = (Delegates.GetBufferParameteriv)GetExtensionDelegate("glGetBufferParameteriv", typeof(Delegates.GetBufferParameteriv));
            Delegates.glGetBufferPointervOES = (Delegates.GetBufferPointervOES)GetExtensionDelegate("glGetBufferPointervOES", typeof(Delegates.GetBufferPointervOES));
            Delegates.glGetClipPlanef = (Delegates.GetClipPlanef)GetExtensionDelegate("glGetClipPlanef", typeof(Delegates.GetClipPlanef));
            Delegates.glGetClipPlanefOES = (Delegates.GetClipPlanefOES)GetExtensionDelegate("glGetClipPlanefOES", typeof(Delegates.GetClipPlanefOES));
            Delegates.glGetClipPlanex = (Delegates.GetClipPlanex)GetExtensionDelegate("glGetClipPlanex", typeof(Delegates.GetClipPlanex));
            Delegates.glGetClipPlanexOES = (Delegates.GetClipPlanexOES)GetExtensionDelegate("glGetClipPlanexOES", typeof(Delegates.GetClipPlanexOES));
            Delegates.glGetConvolutionParameterxvOES = (Delegates.GetConvolutionParameterxvOES)GetExtensionDelegate("glGetConvolutionParameterxvOES", typeof(Delegates.GetConvolutionParameterxvOES));
            Delegates.glGetDriverControlsQCOM = (Delegates.GetDriverControlsQCOM)GetExtensionDelegate("glGetDriverControlsQCOM", typeof(Delegates.GetDriverControlsQCOM));
            Delegates.glGetDriverControlStringQCOM = (Delegates.GetDriverControlStringQCOM)GetExtensionDelegate("glGetDriverControlStringQCOM", typeof(Delegates.GetDriverControlStringQCOM));
            Delegates.glGetError = (Delegates.GetError)GetExtensionDelegate("glGetError", typeof(Delegates.GetError));
            Delegates.glGetFenceivNV = (Delegates.GetFenceivNV)GetExtensionDelegate("glGetFenceivNV", typeof(Delegates.GetFenceivNV));
            Delegates.glGetFixedv = (Delegates.GetFixedv)GetExtensionDelegate("glGetFixedv", typeof(Delegates.GetFixedv));
            Delegates.glGetFixedvOES = (Delegates.GetFixedvOES)GetExtensionDelegate("glGetFixedvOES", typeof(Delegates.GetFixedvOES));
            Delegates.glGetFloatv = (Delegates.GetFloatv)GetExtensionDelegate("glGetFloatv", typeof(Delegates.GetFloatv));
            Delegates.glGetFramebufferAttachmentParameterivOES = (Delegates.GetFramebufferAttachmentParameterivOES)GetExtensionDelegate("glGetFramebufferAttachmentParameterivOES", typeof(Delegates.GetFramebufferAttachmentParameterivOES));
            Delegates.glGetGraphicsResetStatusEXT = (Delegates.GetGraphicsResetStatusEXT)GetExtensionDelegate("glGetGraphicsResetStatusEXT", typeof(Delegates.GetGraphicsResetStatusEXT));
            Delegates.glGetHistogramParameterxvOES = (Delegates.GetHistogramParameterxvOES)GetExtensionDelegate("glGetHistogramParameterxvOES", typeof(Delegates.GetHistogramParameterxvOES));
            Delegates.glGetInteger64vAPPLE = (Delegates.GetInteger64vAPPLE)GetExtensionDelegate("glGetInteger64vAPPLE", typeof(Delegates.GetInteger64vAPPLE));
            Delegates.glGetIntegerv = (Delegates.GetIntegerv)GetExtensionDelegate("glGetIntegerv", typeof(Delegates.GetIntegerv));
            Delegates.glGetLightfv = (Delegates.GetLightfv)GetExtensionDelegate("glGetLightfv", typeof(Delegates.GetLightfv));
            Delegates.glGetLightxOES = (Delegates.GetLightxOES)GetExtensionDelegate("glGetLightxOES", typeof(Delegates.GetLightxOES));
            Delegates.glGetLightxv = (Delegates.GetLightxv)GetExtensionDelegate("glGetLightxv", typeof(Delegates.GetLightxv));
            Delegates.glGetLightxvOES = (Delegates.GetLightxvOES)GetExtensionDelegate("glGetLightxvOES", typeof(Delegates.GetLightxvOES));
            Delegates.glGetMapxvOES = (Delegates.GetMapxvOES)GetExtensionDelegate("glGetMapxvOES", typeof(Delegates.GetMapxvOES));
            Delegates.glGetMaterialfv = (Delegates.GetMaterialfv)GetExtensionDelegate("glGetMaterialfv", typeof(Delegates.GetMaterialfv));
            Delegates.glGetMaterialxOES = (Delegates.GetMaterialxOES)GetExtensionDelegate("glGetMaterialxOES", typeof(Delegates.GetMaterialxOES));
            Delegates.glGetMaterialxv = (Delegates.GetMaterialxv)GetExtensionDelegate("glGetMaterialxv", typeof(Delegates.GetMaterialxv));
            Delegates.glGetMaterialxvOES = (Delegates.GetMaterialxvOES)GetExtensionDelegate("glGetMaterialxvOES", typeof(Delegates.GetMaterialxvOES));
            Delegates.glGetnUniformfvEXT = (Delegates.GetnUniformfvEXT)GetExtensionDelegate("glGetnUniformfvEXT", typeof(Delegates.GetnUniformfvEXT));
            Delegates.glGetnUniformivEXT = (Delegates.GetnUniformivEXT)GetExtensionDelegate("glGetnUniformivEXT", typeof(Delegates.GetnUniformivEXT));
            Delegates.glGetPixelMapxv = (Delegates.GetPixelMapxv)GetExtensionDelegate("glGetPixelMapxv", typeof(Delegates.GetPixelMapxv));
            Delegates.glGetPointerv = (Delegates.GetPointerv)GetExtensionDelegate("glGetPointerv", typeof(Delegates.GetPointerv));
            Delegates.glGetRenderbufferParameterivOES = (Delegates.GetRenderbufferParameterivOES)GetExtensionDelegate("glGetRenderbufferParameterivOES", typeof(Delegates.GetRenderbufferParameterivOES));
            Delegates.glGetString = (Delegates.GetString)GetExtensionDelegate("glGetString", typeof(Delegates.GetString));
            Delegates.glGetSyncivAPPLE = (Delegates.GetSyncivAPPLE)GetExtensionDelegate("glGetSyncivAPPLE", typeof(Delegates.GetSyncivAPPLE));
            Delegates.glGetTexEnvfv = (Delegates.GetTexEnvfv)GetExtensionDelegate("glGetTexEnvfv", typeof(Delegates.GetTexEnvfv));
            Delegates.glGetTexEnviv = (Delegates.GetTexEnviv)GetExtensionDelegate("glGetTexEnviv", typeof(Delegates.GetTexEnviv));
            Delegates.glGetTexEnvxv = (Delegates.GetTexEnvxv)GetExtensionDelegate("glGetTexEnvxv", typeof(Delegates.GetTexEnvxv));
            Delegates.glGetTexEnvxvOES = (Delegates.GetTexEnvxvOES)GetExtensionDelegate("glGetTexEnvxvOES", typeof(Delegates.GetTexEnvxvOES));
            Delegates.glGetTexGenfvOES = (Delegates.GetTexGenfvOES)GetExtensionDelegate("glGetTexGenfvOES", typeof(Delegates.GetTexGenfvOES));
            Delegates.glGetTexGenivOES = (Delegates.GetTexGenivOES)GetExtensionDelegate("glGetTexGenivOES", typeof(Delegates.GetTexGenivOES));
            Delegates.glGetTexGenxvOES = (Delegates.GetTexGenxvOES)GetExtensionDelegate("glGetTexGenxvOES", typeof(Delegates.GetTexGenxvOES));
            Delegates.glGetTexLevelParameterxvOES = (Delegates.GetTexLevelParameterxvOES)GetExtensionDelegate("glGetTexLevelParameterxvOES", typeof(Delegates.GetTexLevelParameterxvOES));
            Delegates.glGetTexParameterfv = (Delegates.GetTexParameterfv)GetExtensionDelegate("glGetTexParameterfv", typeof(Delegates.GetTexParameterfv));
            Delegates.glGetTexParameteriv = (Delegates.GetTexParameteriv)GetExtensionDelegate("glGetTexParameteriv", typeof(Delegates.GetTexParameteriv));
            Delegates.glGetTexParameterxv = (Delegates.GetTexParameterxv)GetExtensionDelegate("glGetTexParameterxv", typeof(Delegates.GetTexParameterxv));
            Delegates.glGetTexParameterxvOES = (Delegates.GetTexParameterxvOES)GetExtensionDelegate("glGetTexParameterxvOES", typeof(Delegates.GetTexParameterxvOES));
            Delegates.glHint = (Delegates.Hint)GetExtensionDelegate("glHint", typeof(Delegates.Hint));
            Delegates.glIndexxOES = (Delegates.IndexxOES)GetExtensionDelegate("glIndexxOES", typeof(Delegates.IndexxOES));
            Delegates.glIndexxvOES = (Delegates.IndexxvOES)GetExtensionDelegate("glIndexxvOES", typeof(Delegates.IndexxvOES));
            Delegates.glIsBuffer = (Delegates.IsBuffer)GetExtensionDelegate("glIsBuffer", typeof(Delegates.IsBuffer));
            Delegates.glIsEnabled = (Delegates.IsEnabled)GetExtensionDelegate("glIsEnabled", typeof(Delegates.IsEnabled));
            Delegates.glIsFenceNV = (Delegates.IsFenceNV)GetExtensionDelegate("glIsFenceNV", typeof(Delegates.IsFenceNV));
            Delegates.glIsFramebufferOES = (Delegates.IsFramebufferOES)GetExtensionDelegate("glIsFramebufferOES", typeof(Delegates.IsFramebufferOES));
            Delegates.glIsRenderbufferOES = (Delegates.IsRenderbufferOES)GetExtensionDelegate("glIsRenderbufferOES", typeof(Delegates.IsRenderbufferOES));
            Delegates.glIsSyncAPPLE = (Delegates.IsSyncAPPLE)GetExtensionDelegate("glIsSyncAPPLE", typeof(Delegates.IsSyncAPPLE));
            Delegates.glIsTexture = (Delegates.IsTexture)GetExtensionDelegate("glIsTexture", typeof(Delegates.IsTexture));
            Delegates.glIsVertexArrayOES = (Delegates.IsVertexArrayOES)GetExtensionDelegate("glIsVertexArrayOES", typeof(Delegates.IsVertexArrayOES));
            Delegates.glLightf = (Delegates.Lightf)GetExtensionDelegate("glLightf", typeof(Delegates.Lightf));
            Delegates.glLightfv = (Delegates.Lightfv)GetExtensionDelegate("glLightfv", typeof(Delegates.Lightfv));
            Delegates.glLightModelf = (Delegates.LightModelf)GetExtensionDelegate("glLightModelf", typeof(Delegates.LightModelf));
            Delegates.glLightModelfv = (Delegates.LightModelfv)GetExtensionDelegate("glLightModelfv", typeof(Delegates.LightModelfv));
            Delegates.glLightModelx = (Delegates.LightModelx)GetExtensionDelegate("glLightModelx", typeof(Delegates.LightModelx));
            Delegates.glLightModelxOES = (Delegates.LightModelxOES)GetExtensionDelegate("glLightModelxOES", typeof(Delegates.LightModelxOES));
            Delegates.glLightModelxv = (Delegates.LightModelxv)GetExtensionDelegate("glLightModelxv", typeof(Delegates.LightModelxv));
            Delegates.glLightModelxvOES = (Delegates.LightModelxvOES)GetExtensionDelegate("glLightModelxvOES", typeof(Delegates.LightModelxvOES));
            Delegates.glLightx = (Delegates.Lightx)GetExtensionDelegate("glLightx", typeof(Delegates.Lightx));
            Delegates.glLightxOES = (Delegates.LightxOES)GetExtensionDelegate("glLightxOES", typeof(Delegates.LightxOES));
            Delegates.glLightxv = (Delegates.Lightxv)GetExtensionDelegate("glLightxv", typeof(Delegates.Lightxv));
            Delegates.glLightxvOES = (Delegates.LightxvOES)GetExtensionDelegate("glLightxvOES", typeof(Delegates.LightxvOES));
            Delegates.glLineWidth = (Delegates.LineWidth)GetExtensionDelegate("glLineWidth", typeof(Delegates.LineWidth));
            Delegates.glLineWidthx = (Delegates.LineWidthx)GetExtensionDelegate("glLineWidthx", typeof(Delegates.LineWidthx));
            Delegates.glLineWidthxOES = (Delegates.LineWidthxOES)GetExtensionDelegate("glLineWidthxOES", typeof(Delegates.LineWidthxOES));
            Delegates.glLoadIdentity = (Delegates.LoadIdentity)GetExtensionDelegate("glLoadIdentity", typeof(Delegates.LoadIdentity));
            Delegates.glLoadMatrixf = (Delegates.LoadMatrixf)GetExtensionDelegate("glLoadMatrixf", typeof(Delegates.LoadMatrixf));
            Delegates.glLoadMatrixx = (Delegates.LoadMatrixx)GetExtensionDelegate("glLoadMatrixx", typeof(Delegates.LoadMatrixx));
            Delegates.glLoadMatrixxOES = (Delegates.LoadMatrixxOES)GetExtensionDelegate("glLoadMatrixxOES", typeof(Delegates.LoadMatrixxOES));
            Delegates.glLoadPaletteFromModelViewMatrixOES = (Delegates.LoadPaletteFromModelViewMatrixOES)GetExtensionDelegate("glLoadPaletteFromModelViewMatrixOES", typeof(Delegates.LoadPaletteFromModelViewMatrixOES));
            Delegates.glLoadTransposeMatrixxOES = (Delegates.LoadTransposeMatrixxOES)GetExtensionDelegate("glLoadTransposeMatrixxOES", typeof(Delegates.LoadTransposeMatrixxOES));
            Delegates.glLogicOp = (Delegates.LogicOp)GetExtensionDelegate("glLogicOp", typeof(Delegates.LogicOp));
            Delegates.glMap1xOES = (Delegates.Map1xOES)GetExtensionDelegate("glMap1xOES", typeof(Delegates.Map1xOES));
            Delegates.glMap2xOES = (Delegates.Map2xOES)GetExtensionDelegate("glMap2xOES", typeof(Delegates.Map2xOES));
            Delegates.glMapBufferOES = (Delegates.MapBufferOES)GetExtensionDelegate("glMapBufferOES", typeof(Delegates.MapBufferOES));
            Delegates.glMapBufferRangeEXT = (Delegates.MapBufferRangeEXT)GetExtensionDelegate("glMapBufferRangeEXT", typeof(Delegates.MapBufferRangeEXT));
            Delegates.glMapGrid1xOES = (Delegates.MapGrid1xOES)GetExtensionDelegate("glMapGrid1xOES", typeof(Delegates.MapGrid1xOES));
            Delegates.glMapGrid2xOES = (Delegates.MapGrid2xOES)GetExtensionDelegate("glMapGrid2xOES", typeof(Delegates.MapGrid2xOES));
            Delegates.glMaterialf = (Delegates.Materialf)GetExtensionDelegate("glMaterialf", typeof(Delegates.Materialf));
            Delegates.glMaterialfv = (Delegates.Materialfv)GetExtensionDelegate("glMaterialfv", typeof(Delegates.Materialfv));
            Delegates.glMaterialx = (Delegates.Materialx)GetExtensionDelegate("glMaterialx", typeof(Delegates.Materialx));
            Delegates.glMaterialxOES = (Delegates.MaterialxOES)GetExtensionDelegate("glMaterialxOES", typeof(Delegates.MaterialxOES));
            Delegates.glMaterialxv = (Delegates.Materialxv)GetExtensionDelegate("glMaterialxv", typeof(Delegates.Materialxv));
            Delegates.glMaterialxvOES = (Delegates.MaterialxvOES)GetExtensionDelegate("glMaterialxvOES", typeof(Delegates.MaterialxvOES));
            Delegates.glMatrixIndexPointerOES = (Delegates.MatrixIndexPointerOES)GetExtensionDelegate("glMatrixIndexPointerOES", typeof(Delegates.MatrixIndexPointerOES));
            Delegates.glMatrixMode = (Delegates.MatrixMode)GetExtensionDelegate("glMatrixMode", typeof(Delegates.MatrixMode));
            Delegates.glMultiDrawArraysEXT = (Delegates.MultiDrawArraysEXT)GetExtensionDelegate("glMultiDrawArraysEXT", typeof(Delegates.MultiDrawArraysEXT));
            Delegates.glMultiDrawElementsEXT = (Delegates.MultiDrawElementsEXT)GetExtensionDelegate("glMultiDrawElementsEXT", typeof(Delegates.MultiDrawElementsEXT));
            Delegates.glMultiTexCoord1bOES = (Delegates.MultiTexCoord1bOES)GetExtensionDelegate("glMultiTexCoord1bOES", typeof(Delegates.MultiTexCoord1bOES));
            Delegates.glMultiTexCoord1bvOES = (Delegates.MultiTexCoord1bvOES)GetExtensionDelegate("glMultiTexCoord1bvOES", typeof(Delegates.MultiTexCoord1bvOES));
            Delegates.glMultiTexCoord1xOES = (Delegates.MultiTexCoord1xOES)GetExtensionDelegate("glMultiTexCoord1xOES", typeof(Delegates.MultiTexCoord1xOES));
            Delegates.glMultiTexCoord1xvOES = (Delegates.MultiTexCoord1xvOES)GetExtensionDelegate("glMultiTexCoord1xvOES", typeof(Delegates.MultiTexCoord1xvOES));
            Delegates.glMultiTexCoord2bOES = (Delegates.MultiTexCoord2bOES)GetExtensionDelegate("glMultiTexCoord2bOES", typeof(Delegates.MultiTexCoord2bOES));
            Delegates.glMultiTexCoord2bvOES = (Delegates.MultiTexCoord2bvOES)GetExtensionDelegate("glMultiTexCoord2bvOES", typeof(Delegates.MultiTexCoord2bvOES));
            Delegates.glMultiTexCoord2xOES = (Delegates.MultiTexCoord2xOES)GetExtensionDelegate("glMultiTexCoord2xOES", typeof(Delegates.MultiTexCoord2xOES));
            Delegates.glMultiTexCoord2xvOES = (Delegates.MultiTexCoord2xvOES)GetExtensionDelegate("glMultiTexCoord2xvOES", typeof(Delegates.MultiTexCoord2xvOES));
            Delegates.glMultiTexCoord3bOES = (Delegates.MultiTexCoord3bOES)GetExtensionDelegate("glMultiTexCoord3bOES", typeof(Delegates.MultiTexCoord3bOES));
            Delegates.glMultiTexCoord3bvOES = (Delegates.MultiTexCoord3bvOES)GetExtensionDelegate("glMultiTexCoord3bvOES", typeof(Delegates.MultiTexCoord3bvOES));
            Delegates.glMultiTexCoord3xOES = (Delegates.MultiTexCoord3xOES)GetExtensionDelegate("glMultiTexCoord3xOES", typeof(Delegates.MultiTexCoord3xOES));
            Delegates.glMultiTexCoord3xvOES = (Delegates.MultiTexCoord3xvOES)GetExtensionDelegate("glMultiTexCoord3xvOES", typeof(Delegates.MultiTexCoord3xvOES));
            Delegates.glMultiTexCoord4bOES = (Delegates.MultiTexCoord4bOES)GetExtensionDelegate("glMultiTexCoord4bOES", typeof(Delegates.MultiTexCoord4bOES));
            Delegates.glMultiTexCoord4bvOES = (Delegates.MultiTexCoord4bvOES)GetExtensionDelegate("glMultiTexCoord4bvOES", typeof(Delegates.MultiTexCoord4bvOES));
            Delegates.glMultiTexCoord4f = (Delegates.MultiTexCoord4f)GetExtensionDelegate("glMultiTexCoord4f", typeof(Delegates.MultiTexCoord4f));
            Delegates.glMultiTexCoord4x = (Delegates.MultiTexCoord4x)GetExtensionDelegate("glMultiTexCoord4x", typeof(Delegates.MultiTexCoord4x));
            Delegates.glMultiTexCoord4xOES = (Delegates.MultiTexCoord4xOES)GetExtensionDelegate("glMultiTexCoord4xOES", typeof(Delegates.MultiTexCoord4xOES));
            Delegates.glMultiTexCoord4xvOES = (Delegates.MultiTexCoord4xvOES)GetExtensionDelegate("glMultiTexCoord4xvOES", typeof(Delegates.MultiTexCoord4xvOES));
            Delegates.glMultMatrixf = (Delegates.MultMatrixf)GetExtensionDelegate("glMultMatrixf", typeof(Delegates.MultMatrixf));
            Delegates.glMultMatrixx = (Delegates.MultMatrixx)GetExtensionDelegate("glMultMatrixx", typeof(Delegates.MultMatrixx));
            Delegates.glMultMatrixxOES = (Delegates.MultMatrixxOES)GetExtensionDelegate("glMultMatrixxOES", typeof(Delegates.MultMatrixxOES));
            Delegates.glMultTransposeMatrixxOES = (Delegates.MultTransposeMatrixxOES)GetExtensionDelegate("glMultTransposeMatrixxOES", typeof(Delegates.MultTransposeMatrixxOES));
            Delegates.glNormal3f = (Delegates.Normal3f)GetExtensionDelegate("glNormal3f", typeof(Delegates.Normal3f));
            Delegates.glNormal3x = (Delegates.Normal3x)GetExtensionDelegate("glNormal3x", typeof(Delegates.Normal3x));
            Delegates.glNormal3xOES = (Delegates.Normal3xOES)GetExtensionDelegate("glNormal3xOES", typeof(Delegates.Normal3xOES));
            Delegates.glNormal3xvOES = (Delegates.Normal3xvOES)GetExtensionDelegate("glNormal3xvOES", typeof(Delegates.Normal3xvOES));
            Delegates.glNormalPointer = (Delegates.NormalPointer)GetExtensionDelegate("glNormalPointer", typeof(Delegates.NormalPointer));
            Delegates.glOrthof = (Delegates.Orthof)GetExtensionDelegate("glOrthof", typeof(Delegates.Orthof));
            Delegates.glOrthofOES = (Delegates.OrthofOES)GetExtensionDelegate("glOrthofOES", typeof(Delegates.OrthofOES));
            Delegates.glOrthox = (Delegates.Orthox)GetExtensionDelegate("glOrthox", typeof(Delegates.Orthox));
            Delegates.glOrthoxOES = (Delegates.OrthoxOES)GetExtensionDelegate("glOrthoxOES", typeof(Delegates.OrthoxOES));
            Delegates.glPassThroughxOES = (Delegates.PassThroughxOES)GetExtensionDelegate("glPassThroughxOES", typeof(Delegates.PassThroughxOES));
            Delegates.glPixelMapx = (Delegates.PixelMapx)GetExtensionDelegate("glPixelMapx", typeof(Delegates.PixelMapx));
            Delegates.glPixelStorei = (Delegates.PixelStorei)GetExtensionDelegate("glPixelStorei", typeof(Delegates.PixelStorei));
            Delegates.glPixelStorex = (Delegates.PixelStorex)GetExtensionDelegate("glPixelStorex", typeof(Delegates.PixelStorex));
            Delegates.glPixelTransferxOES = (Delegates.PixelTransferxOES)GetExtensionDelegate("glPixelTransferxOES", typeof(Delegates.PixelTransferxOES));
            Delegates.glPixelZoomxOES = (Delegates.PixelZoomxOES)GetExtensionDelegate("glPixelZoomxOES", typeof(Delegates.PixelZoomxOES));
            Delegates.glPointParameterf = (Delegates.PointParameterf)GetExtensionDelegate("glPointParameterf", typeof(Delegates.PointParameterf));
            Delegates.glPointParameterfv = (Delegates.PointParameterfv)GetExtensionDelegate("glPointParameterfv", typeof(Delegates.PointParameterfv));
            Delegates.glPointParameterx = (Delegates.PointParameterx)GetExtensionDelegate("glPointParameterx", typeof(Delegates.PointParameterx));
            Delegates.glPointParameterxOES = (Delegates.PointParameterxOES)GetExtensionDelegate("glPointParameterxOES", typeof(Delegates.PointParameterxOES));
            Delegates.glPointParameterxv = (Delegates.PointParameterxv)GetExtensionDelegate("glPointParameterxv", typeof(Delegates.PointParameterxv));
            Delegates.glPointParameterxvOES = (Delegates.PointParameterxvOES)GetExtensionDelegate("glPointParameterxvOES", typeof(Delegates.PointParameterxvOES));
            Delegates.glPointSize = (Delegates.PointSize)GetExtensionDelegate("glPointSize", typeof(Delegates.PointSize));
            Delegates.glPointSizePointerOES = (Delegates.PointSizePointerOES)GetExtensionDelegate("glPointSizePointerOES", typeof(Delegates.PointSizePointerOES));
            Delegates.glPointSizex = (Delegates.PointSizex)GetExtensionDelegate("glPointSizex", typeof(Delegates.PointSizex));
            Delegates.glPointSizexOES = (Delegates.PointSizexOES)GetExtensionDelegate("glPointSizexOES", typeof(Delegates.PointSizexOES));
            Delegates.glPolygonOffset = (Delegates.PolygonOffset)GetExtensionDelegate("glPolygonOffset", typeof(Delegates.PolygonOffset));
            Delegates.glPolygonOffsetx = (Delegates.PolygonOffsetx)GetExtensionDelegate("glPolygonOffsetx", typeof(Delegates.PolygonOffsetx));
            Delegates.glPolygonOffsetxOES = (Delegates.PolygonOffsetxOES)GetExtensionDelegate("glPolygonOffsetxOES", typeof(Delegates.PolygonOffsetxOES));
            Delegates.glPopMatrix = (Delegates.PopMatrix)GetExtensionDelegate("glPopMatrix", typeof(Delegates.PopMatrix));
            Delegates.glPrioritizeTexturesxOES = (Delegates.PrioritizeTexturesxOES)GetExtensionDelegate("glPrioritizeTexturesxOES", typeof(Delegates.PrioritizeTexturesxOES));
            Delegates.glPushMatrix = (Delegates.PushMatrix)GetExtensionDelegate("glPushMatrix", typeof(Delegates.PushMatrix));
            Delegates.glQueryMatrixxOES = (Delegates.QueryMatrixxOES)GetExtensionDelegate("glQueryMatrixxOES", typeof(Delegates.QueryMatrixxOES));
            Delegates.glRasterPos2xOES = (Delegates.RasterPos2xOES)GetExtensionDelegate("glRasterPos2xOES", typeof(Delegates.RasterPos2xOES));
            Delegates.glRasterPos2xvOES = (Delegates.RasterPos2xvOES)GetExtensionDelegate("glRasterPos2xvOES", typeof(Delegates.RasterPos2xvOES));
            Delegates.glRasterPos3xOES = (Delegates.RasterPos3xOES)GetExtensionDelegate("glRasterPos3xOES", typeof(Delegates.RasterPos3xOES));
            Delegates.glRasterPos3xvOES = (Delegates.RasterPos3xvOES)GetExtensionDelegate("glRasterPos3xvOES", typeof(Delegates.RasterPos3xvOES));
            Delegates.glRasterPos4xOES = (Delegates.RasterPos4xOES)GetExtensionDelegate("glRasterPos4xOES", typeof(Delegates.RasterPos4xOES));
            Delegates.glRasterPos4xvOES = (Delegates.RasterPos4xvOES)GetExtensionDelegate("glRasterPos4xvOES", typeof(Delegates.RasterPos4xvOES));
            Delegates.glReadnPixelsEXT = (Delegates.ReadnPixelsEXT)GetExtensionDelegate("glReadnPixelsEXT", typeof(Delegates.ReadnPixelsEXT));
            Delegates.glReadPixels = (Delegates.ReadPixels)GetExtensionDelegate("glReadPixels", typeof(Delegates.ReadPixels));
            Delegates.glRectxOES = (Delegates.RectxOES)GetExtensionDelegate("glRectxOES", typeof(Delegates.RectxOES));
            Delegates.glRectxvOES = (Delegates.RectxvOES)GetExtensionDelegate("glRectxvOES", typeof(Delegates.RectxvOES));
            Delegates.glRenderbufferStorageMultisampleAPPLE = (Delegates.RenderbufferStorageMultisampleAPPLE)GetExtensionDelegate("glRenderbufferStorageMultisampleAPPLE", typeof(Delegates.RenderbufferStorageMultisampleAPPLE));
            Delegates.glRenderbufferStorageMultisampleEXT = (Delegates.RenderbufferStorageMultisampleEXT)GetExtensionDelegate("glRenderbufferStorageMultisampleEXT", typeof(Delegates.RenderbufferStorageMultisampleEXT));
            Delegates.glRenderbufferStorageMultisampleIMG = (Delegates.RenderbufferStorageMultisampleIMG)GetExtensionDelegate("glRenderbufferStorageMultisampleIMG", typeof(Delegates.RenderbufferStorageMultisampleIMG));
            Delegates.glRenderbufferStorageOES = (Delegates.RenderbufferStorageOES)GetExtensionDelegate("glRenderbufferStorageOES", typeof(Delegates.RenderbufferStorageOES));
            Delegates.glResolveMultisampleFramebufferAPPLE = (Delegates.ResolveMultisampleFramebufferAPPLE)GetExtensionDelegate("glResolveMultisampleFramebufferAPPLE", typeof(Delegates.ResolveMultisampleFramebufferAPPLE));
            Delegates.glRotatef = (Delegates.Rotatef)GetExtensionDelegate("glRotatef", typeof(Delegates.Rotatef));
            Delegates.glRotatex = (Delegates.Rotatex)GetExtensionDelegate("glRotatex", typeof(Delegates.Rotatex));
            Delegates.glRotatexOES = (Delegates.RotatexOES)GetExtensionDelegate("glRotatexOES", typeof(Delegates.RotatexOES));
            Delegates.glSampleCoverage = (Delegates.SampleCoverage)GetExtensionDelegate("glSampleCoverage", typeof(Delegates.SampleCoverage));
            Delegates.glSampleCoverageOES = (Delegates.SampleCoverageOES)GetExtensionDelegate("glSampleCoverageOES", typeof(Delegates.SampleCoverageOES));
            Delegates.glSampleCoveragex = (Delegates.SampleCoveragex)GetExtensionDelegate("glSampleCoveragex", typeof(Delegates.SampleCoveragex));
            Delegates.glSampleCoveragexOES = (Delegates.SampleCoveragexOES)GetExtensionDelegate("glSampleCoveragexOES", typeof(Delegates.SampleCoveragexOES));
            Delegates.glScalef = (Delegates.Scalef)GetExtensionDelegate("glScalef", typeof(Delegates.Scalef));
            Delegates.glScalex = (Delegates.Scalex)GetExtensionDelegate("glScalex", typeof(Delegates.Scalex));
            Delegates.glScalexOES = (Delegates.ScalexOES)GetExtensionDelegate("glScalexOES", typeof(Delegates.ScalexOES));
            Delegates.glScissor = (Delegates.Scissor)GetExtensionDelegate("glScissor", typeof(Delegates.Scissor));
            Delegates.glSetFenceNV = (Delegates.SetFenceNV)GetExtensionDelegate("glSetFenceNV", typeof(Delegates.SetFenceNV));
            Delegates.glShadeModel = (Delegates.ShadeModel)GetExtensionDelegate("glShadeModel", typeof(Delegates.ShadeModel));
            Delegates.glStartTilingQCOM = (Delegates.StartTilingQCOM)GetExtensionDelegate("glStartTilingQCOM", typeof(Delegates.StartTilingQCOM));
            Delegates.glStencilFunc = (Delegates.StencilFunc)GetExtensionDelegate("glStencilFunc", typeof(Delegates.StencilFunc));
            Delegates.glStencilMask = (Delegates.StencilMask)GetExtensionDelegate("glStencilMask", typeof(Delegates.StencilMask));
            Delegates.glStencilOp = (Delegates.StencilOp)GetExtensionDelegate("glStencilOp", typeof(Delegates.StencilOp));
            Delegates.glTestFenceNV = (Delegates.TestFenceNV)GetExtensionDelegate("glTestFenceNV", typeof(Delegates.TestFenceNV));
            Delegates.glTexCoord1bOES = (Delegates.TexCoord1bOES)GetExtensionDelegate("glTexCoord1bOES", typeof(Delegates.TexCoord1bOES));
            Delegates.glTexCoord1bvOES = (Delegates.TexCoord1bvOES)GetExtensionDelegate("glTexCoord1bvOES", typeof(Delegates.TexCoord1bvOES));
            Delegates.glTexCoord1xOES = (Delegates.TexCoord1xOES)GetExtensionDelegate("glTexCoord1xOES", typeof(Delegates.TexCoord1xOES));
            Delegates.glTexCoord1xvOES = (Delegates.TexCoord1xvOES)GetExtensionDelegate("glTexCoord1xvOES", typeof(Delegates.TexCoord1xvOES));
            Delegates.glTexCoord2bOES = (Delegates.TexCoord2bOES)GetExtensionDelegate("glTexCoord2bOES", typeof(Delegates.TexCoord2bOES));
            Delegates.glTexCoord2bvOES = (Delegates.TexCoord2bvOES)GetExtensionDelegate("glTexCoord2bvOES", typeof(Delegates.TexCoord2bvOES));
            Delegates.glTexCoord2xOES = (Delegates.TexCoord2xOES)GetExtensionDelegate("glTexCoord2xOES", typeof(Delegates.TexCoord2xOES));
            Delegates.glTexCoord2xvOES = (Delegates.TexCoord2xvOES)GetExtensionDelegate("glTexCoord2xvOES", typeof(Delegates.TexCoord2xvOES));
            Delegates.glTexCoord3bOES = (Delegates.TexCoord3bOES)GetExtensionDelegate("glTexCoord3bOES", typeof(Delegates.TexCoord3bOES));
            Delegates.glTexCoord3bvOES = (Delegates.TexCoord3bvOES)GetExtensionDelegate("glTexCoord3bvOES", typeof(Delegates.TexCoord3bvOES));
            Delegates.glTexCoord3xOES = (Delegates.TexCoord3xOES)GetExtensionDelegate("glTexCoord3xOES", typeof(Delegates.TexCoord3xOES));
            Delegates.glTexCoord3xvOES = (Delegates.TexCoord3xvOES)GetExtensionDelegate("glTexCoord3xvOES", typeof(Delegates.TexCoord3xvOES));
            Delegates.glTexCoord4bOES = (Delegates.TexCoord4bOES)GetExtensionDelegate("glTexCoord4bOES", typeof(Delegates.TexCoord4bOES));
            Delegates.glTexCoord4bvOES = (Delegates.TexCoord4bvOES)GetExtensionDelegate("glTexCoord4bvOES", typeof(Delegates.TexCoord4bvOES));
            Delegates.glTexCoord4xOES = (Delegates.TexCoord4xOES)GetExtensionDelegate("glTexCoord4xOES", typeof(Delegates.TexCoord4xOES));
            Delegates.glTexCoord4xvOES = (Delegates.TexCoord4xvOES)GetExtensionDelegate("glTexCoord4xvOES", typeof(Delegates.TexCoord4xvOES));
            Delegates.glTexCoordPointer = (Delegates.TexCoordPointer)GetExtensionDelegate("glTexCoordPointer", typeof(Delegates.TexCoordPointer));
            Delegates.glTexEnvf = (Delegates.TexEnvf)GetExtensionDelegate("glTexEnvf", typeof(Delegates.TexEnvf));
            Delegates.glTexEnvfv = (Delegates.TexEnvfv)GetExtensionDelegate("glTexEnvfv", typeof(Delegates.TexEnvfv));
            Delegates.glTexEnvi = (Delegates.TexEnvi)GetExtensionDelegate("glTexEnvi", typeof(Delegates.TexEnvi));
            Delegates.glTexEnviv = (Delegates.TexEnviv)GetExtensionDelegate("glTexEnviv", typeof(Delegates.TexEnviv));
            Delegates.glTexEnvx = (Delegates.TexEnvx)GetExtensionDelegate("glTexEnvx", typeof(Delegates.TexEnvx));
            Delegates.glTexEnvxOES = (Delegates.TexEnvxOES)GetExtensionDelegate("glTexEnvxOES", typeof(Delegates.TexEnvxOES));
            Delegates.glTexEnvxv = (Delegates.TexEnvxv)GetExtensionDelegate("glTexEnvxv", typeof(Delegates.TexEnvxv));
            Delegates.glTexEnvxvOES = (Delegates.TexEnvxvOES)GetExtensionDelegate("glTexEnvxvOES", typeof(Delegates.TexEnvxvOES));
            Delegates.glTexGenfOES = (Delegates.TexGenfOES)GetExtensionDelegate("glTexGenfOES", typeof(Delegates.TexGenfOES));
            Delegates.glTexGenfvOES = (Delegates.TexGenfvOES)GetExtensionDelegate("glTexGenfvOES", typeof(Delegates.TexGenfvOES));
            Delegates.glTexGeniOES = (Delegates.TexGeniOES)GetExtensionDelegate("glTexGeniOES", typeof(Delegates.TexGeniOES));
            Delegates.glTexGenivOES = (Delegates.TexGenivOES)GetExtensionDelegate("glTexGenivOES", typeof(Delegates.TexGenivOES));
            Delegates.glTexGenxOES = (Delegates.TexGenxOES)GetExtensionDelegate("glTexGenxOES", typeof(Delegates.TexGenxOES));
            Delegates.glTexGenxvOES = (Delegates.TexGenxvOES)GetExtensionDelegate("glTexGenxvOES", typeof(Delegates.TexGenxvOES));
            Delegates.glTexImage2D = (Delegates.TexImage2D)GetExtensionDelegate("glTexImage2D", typeof(Delegates.TexImage2D));
            Delegates.glTexParameterf = (Delegates.TexParameterf)GetExtensionDelegate("glTexParameterf", typeof(Delegates.TexParameterf));
            Delegates.glTexParameterfv = (Delegates.TexParameterfv)GetExtensionDelegate("glTexParameterfv", typeof(Delegates.TexParameterfv));
            Delegates.glTexParameteri = (Delegates.TexParameteri)GetExtensionDelegate("glTexParameteri", typeof(Delegates.TexParameteri));
            Delegates.glTexParameteriv = (Delegates.TexParameteriv)GetExtensionDelegate("glTexParameteriv", typeof(Delegates.TexParameteriv));
            Delegates.glTexParameterx = (Delegates.TexParameterx)GetExtensionDelegate("glTexParameterx", typeof(Delegates.TexParameterx));
            Delegates.glTexParameterxOES = (Delegates.TexParameterxOES)GetExtensionDelegate("glTexParameterxOES", typeof(Delegates.TexParameterxOES));
            Delegates.glTexParameterxv = (Delegates.TexParameterxv)GetExtensionDelegate("glTexParameterxv", typeof(Delegates.TexParameterxv));
            Delegates.glTexParameterxvOES = (Delegates.TexParameterxvOES)GetExtensionDelegate("glTexParameterxvOES", typeof(Delegates.TexParameterxvOES));
            Delegates.glTexStorage1DEXT = (Delegates.TexStorage1DEXT)GetExtensionDelegate("glTexStorage1DEXT", typeof(Delegates.TexStorage1DEXT));
            Delegates.glTexStorage2DEXT = (Delegates.TexStorage2DEXT)GetExtensionDelegate("glTexStorage2DEXT", typeof(Delegates.TexStorage2DEXT));
            Delegates.glTexStorage3DEXT = (Delegates.TexStorage3DEXT)GetExtensionDelegate("glTexStorage3DEXT", typeof(Delegates.TexStorage3DEXT));
            Delegates.glTexSubImage2D = (Delegates.TexSubImage2D)GetExtensionDelegate("glTexSubImage2D", typeof(Delegates.TexSubImage2D));
            Delegates.glTextureStorage1DEXT = (Delegates.TextureStorage1DEXT)GetExtensionDelegate("glTextureStorage1DEXT", typeof(Delegates.TextureStorage1DEXT));
            Delegates.glTextureStorage2DEXT = (Delegates.TextureStorage2DEXT)GetExtensionDelegate("glTextureStorage2DEXT", typeof(Delegates.TextureStorage2DEXT));
            Delegates.glTextureStorage3DEXT = (Delegates.TextureStorage3DEXT)GetExtensionDelegate("glTextureStorage3DEXT", typeof(Delegates.TextureStorage3DEXT));
            Delegates.glTranslatef = (Delegates.Translatef)GetExtensionDelegate("glTranslatef", typeof(Delegates.Translatef));
            Delegates.glTranslatex = (Delegates.Translatex)GetExtensionDelegate("glTranslatex", typeof(Delegates.Translatex));
            Delegates.glTranslatexOES = (Delegates.TranslatexOES)GetExtensionDelegate("glTranslatexOES", typeof(Delegates.TranslatexOES));
            Delegates.glUnmapBufferOES = (Delegates.UnmapBufferOES)GetExtensionDelegate("glUnmapBufferOES", typeof(Delegates.UnmapBufferOES));
            Delegates.glVertex2bOES = (Delegates.Vertex2bOES)GetExtensionDelegate("glVertex2bOES", typeof(Delegates.Vertex2bOES));
            Delegates.glVertex2bvOES = (Delegates.Vertex2bvOES)GetExtensionDelegate("glVertex2bvOES", typeof(Delegates.Vertex2bvOES));
            Delegates.glVertex2xOES = (Delegates.Vertex2xOES)GetExtensionDelegate("glVertex2xOES", typeof(Delegates.Vertex2xOES));
            Delegates.glVertex2xvOES = (Delegates.Vertex2xvOES)GetExtensionDelegate("glVertex2xvOES", typeof(Delegates.Vertex2xvOES));
            Delegates.glVertex3bOES = (Delegates.Vertex3bOES)GetExtensionDelegate("glVertex3bOES", typeof(Delegates.Vertex3bOES));
            Delegates.glVertex3bvOES = (Delegates.Vertex3bvOES)GetExtensionDelegate("glVertex3bvOES", typeof(Delegates.Vertex3bvOES));
            Delegates.glVertex3xOES = (Delegates.Vertex3xOES)GetExtensionDelegate("glVertex3xOES", typeof(Delegates.Vertex3xOES));
            Delegates.glVertex3xvOES = (Delegates.Vertex3xvOES)GetExtensionDelegate("glVertex3xvOES", typeof(Delegates.Vertex3xvOES));
            Delegates.glVertex4bOES = (Delegates.Vertex4bOES)GetExtensionDelegate("glVertex4bOES", typeof(Delegates.Vertex4bOES));
            Delegates.glVertex4bvOES = (Delegates.Vertex4bvOES)GetExtensionDelegate("glVertex4bvOES", typeof(Delegates.Vertex4bvOES));
            Delegates.glVertex4xOES = (Delegates.Vertex4xOES)GetExtensionDelegate("glVertex4xOES", typeof(Delegates.Vertex4xOES));
            Delegates.glVertex4xvOES = (Delegates.Vertex4xvOES)GetExtensionDelegate("glVertex4xvOES", typeof(Delegates.Vertex4xvOES));
            Delegates.glVertexPointer = (Delegates.VertexPointer)GetExtensionDelegate("glVertexPointer", typeof(Delegates.VertexPointer));
            Delegates.glViewport = (Delegates.Viewport)GetExtensionDelegate("glViewport", typeof(Delegates.Viewport));
            Delegates.glWaitSyncAPPLE = (Delegates.WaitSyncAPPLE)GetExtensionDelegate("glWaitSyncAPPLE", typeof(Delegates.WaitSyncAPPLE));
            Delegates.glWeightPointerOES = (Delegates.WeightPointerOES)GetExtensionDelegate("glWeightPointerOES", typeof(Delegates.WeightPointerOES));
        }

        internal static partial class Delegates
        {
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AccumxOES(OpenTK.Graphics.ES11.All op, int value);
            internal static AccumxOES glAccumxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref);
            internal static AlphaFunc glAlphaFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref);
            internal static AlphaFuncx glAlphaFuncx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AlphaFuncxOES(OpenTK.Graphics.ES11.All func, int @ref);
            internal static AlphaFuncxOES glAlphaFuncxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFramebufferOES(OpenTK.Graphics.ES11.All target, UInt32 framebuffer);
            internal static BindFramebufferOES glBindFramebufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindRenderbufferOES(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer);
            internal static BindRenderbufferOES glBindRenderbufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexArrayOES(UInt32 array);
            internal static BindVertexArrayOES glBindVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BitmapxOES(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap);
            internal unsafe static BitmapxOES glBitmapxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendColorxOES(int red, int green, int blue, int alpha);
            internal static BlendColorxOES glBlendColorxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationEXT(OpenTK.Graphics.ES11.All mode);
            internal static BlendEquationEXT glBlendEquationEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationOES(OpenTK.Graphics.ES11.All mode);
            internal static BlendEquationOES glBlendEquationOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparateOES(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha);
            internal static BlendEquationSeparateOES glBlendEquationSeparateOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparateOES(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha);
            internal static BlendFuncSeparateOES glBlendFuncSeparateOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage);
            internal static BufferData glBufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.All CheckFramebufferStatusOES(OpenTK.Graphics.ES11.All target);
            internal static CheckFramebufferStatusOES glCheckFramebufferStatusOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask);
            internal static Clear glClear;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearAccumxOES(int red, int green, int blue, int alpha);
            internal static ClearAccumxOES glClearAccumxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColorx(int red, int green, int blue, int alpha);
            internal static ClearColorx glClearColorx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColorxOES(int red, int green, int blue, int alpha);
            internal static ClearColorxOES glClearColorxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthfOES(Single depth);
            internal static ClearDepthfOES glClearDepthfOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthx(int depth);
            internal static ClearDepthx glClearDepthx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthxOES(int depth);
            internal static ClearDepthxOES glClearDepthxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
            internal static ClientActiveTexture glClientActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.All ClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static ClientWaitSyncAPPLE glClientWaitSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanef(OpenTK.Graphics.ES11.All p, Single* eqn);
            internal unsafe static ClipPlanef glClipPlanef;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanefIMG(OpenTK.Graphics.ES11.All p, Single* eqn);
            internal unsafe static ClipPlanefIMG glClipPlanefIMG;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanefOES(OpenTK.Graphics.ES11.All plane, Single* equation);
            internal unsafe static ClipPlanefOES glClipPlanefOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation);
            internal unsafe static ClipPlanex glClipPlanex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanexIMG(OpenTK.Graphics.ES11.All p, int* eqn);
            internal unsafe static ClipPlanexIMG glClipPlanexIMG;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClipPlanexOES(OpenTK.Graphics.ES11.All plane, int* equation);
            internal unsafe static ClipPlanexOES glClipPlanexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color3xOES(int red, int green, int blue);
            internal static Color3xOES glColor3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Color3xvOES(int* components);
            internal unsafe static Color3xvOES glColor3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4f(Single red, Single green, Single blue, Single alpha);
            internal static Color4f glColor4f;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            internal static Color4ub glColor4ub;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4x(int red, int green, int blue, int alpha);
            internal static Color4x glColor4x;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Color4xOES(int red, int green, int blue, int alpha);
            internal static Color4xOES glColor4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Color4xvOES(int* components);
            internal unsafe static Color4xvOES glColor4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer);
            internal static ColorPointer glColorPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static ConvolutionParameterxOES glConvolutionParameterxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static ConvolutionParameterxvOES glConvolutionParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
            internal static CopyTextureLevelsAPPLE glCopyTextureLevelsAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode);
            internal static CullFace glCullFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex);
            internal static CurrentPaletteMatrixOES glCurrentPaletteMatrixOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFencesNV(Int32 n, UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFramebuffersOES(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffersOES glDeleteFramebuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffersOES glDeleteRenderbuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteSyncAPPLE(IntPtr sync);
            internal static DeleteSyncAPPLE glDeleteSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteVertexArraysOES(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArraysOES glDeleteVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangefOES(Single n, Single f);
            internal static DepthRangefOES glDepthRangefOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangex(int n, int f);
            internal static DepthRangex glDepthRangex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangexOES(int n, int f);
            internal static DepthRangexOES glDepthRangexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disable(OpenTK.Graphics.ES11.EnableCap cap);
            internal static Disable glDisable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableClientState(OpenTK.Graphics.ES11.EnableCap array);
            internal static DisableClientState glDisableClientState;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableDriverControlQCOM(UInt32 driverControl);
            internal static DisableDriverControlQCOM glDisableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DiscardFramebufferEXT(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments);
            internal unsafe static DiscardFramebufferEXT glDiscardFramebufferEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexfOES(Single x, Single y, Single z, Single width, Single height);
            internal static DrawTexfOES glDrawTexfOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexfvOES(Single* coords);
            internal unsafe static DrawTexfvOES glDrawTexfvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);
            internal static DrawTexiOES glDrawTexiOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexivOES(Int32* coords);
            internal unsafe static DrawTexivOES glDrawTexivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);
            internal static DrawTexsOES glDrawTexsOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexsvOES(Int16* coords);
            internal unsafe static DrawTexsvOES glDrawTexsvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTexxOES(int x, int y, int z, int width, int height);
            internal static DrawTexxOES glDrawTexxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawTexxvOES(int* coords);
            internal unsafe static DrawTexxvOES glDrawTexxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES11.All target, IntPtr image);
            internal static EGLImageTargetRenderbufferStorageOES glEGLImageTargetRenderbufferStorageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EGLImageTargetTexture2DOES(OpenTK.Graphics.ES11.All target, IntPtr image);
            internal static EGLImageTargetTexture2DOES glEGLImageTargetTexture2DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enable(OpenTK.Graphics.ES11.EnableCap cap);
            internal static Enable glEnable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableClientState(OpenTK.Graphics.ES11.EnableCap array);
            internal static EnableClientState glEnableClientState;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableDriverControlQCOM(UInt32 driverControl);
            internal static EnableDriverControlQCOM glEnableDriverControlQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndTilingQCOM(UInt32 preserveMask);
            internal static EndTilingQCOM glEndTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EvalCoord1xOES(int u);
            internal static EvalCoord1xOES glEvalCoord1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void EvalCoord1xvOES(int* coords);
            internal unsafe static EvalCoord1xvOES glEvalCoord1xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EvalCoord2xOES(int u, int v);
            internal static EvalCoord2xOES glEvalCoord2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void EvalCoord2xvOES(int* coords);
            internal unsafe static EvalCoord2xvOES glEvalCoord2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params);
            internal static ExtGetBufferPointervQCOM glExtGetBufferPointervQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
            internal unsafe static ExtGetBuffersQCOM glExtGetBuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
            internal unsafe static ExtGetFramebuffersQCOM glExtGetFramebuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
            internal unsafe static ExtGetProgramBinarySourceQCOM glExtGetProgramBinarySourceQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
            internal unsafe static ExtGetProgramsQCOM glExtGetProgramsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
            internal unsafe static ExtGetRenderbuffersQCOM glExtGetRenderbuffersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
            internal unsafe static ExtGetShadersQCOM glExtGetShadersQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static ExtGetTexLevelParameterivQCOM glExtGetTexLevelParameterivQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels);
            internal static ExtGetTexSubImageQCOM glExtGetTexSubImageQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
            internal unsafe static ExtGetTexturesQCOM glExtGetTexturesQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool ExtIsProgramBinaryQCOM(UInt32 program);
            internal static ExtIsProgramBinaryQCOM glExtIsProgramBinaryQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param);
            internal static ExtTexObjectStateOverrideiQCOM glExtTexObjectStateOverrideiQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void FeedbackBufferxOES(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer);
            internal unsafe static FeedbackBufferxOES glFeedbackBufferxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr FenceSyncAPPLE(OpenTK.Graphics.ES11.All condition, UInt32 flags);
            internal static FenceSyncAPPLE glFenceSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Finish();
            internal static Finish glFinish;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Flush();
            internal static Flush glFlush;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FlushMappedBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRangeEXT glFlushMappedBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Fogf(OpenTK.Graphics.ES11.FogParameter pname, Single param);
            internal static Fogf glFogf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Fogfv(OpenTK.Graphics.ES11.FogParameter pname, Single* @params);
            internal unsafe static Fogfv glFogfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Fogx(OpenTK.Graphics.ES11.All pname, int param);
            internal static Fogx glFogx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FogxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static FogxOES glFogxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Fogxv(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static Fogxv glFogxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void FogxvOES(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static FogxvOES glFogxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferRenderbufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbufferOES glFramebufferRenderbufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleEXT glFramebufferTexture2DMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
            internal static FramebufferTexture2DMultisampleIMG glFramebufferTexture2DMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2DOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2DOES glFramebufferTexture2DOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Frustumf(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static Frustumf glFrustumf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrustumfOES(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static FrustumfOES glFrustumfOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Frustumx(int l, int r, int b, int t, int n, int f);
            internal static Frustumx glFrustumx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrustumxOES(int l, int r, int b, int t, int n, int f);
            internal static FrustumxOES glFrustumxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GenerateMipmapOES(OpenTK.Graphics.ES11.All target);
            internal static GenerateMipmapOES glGenerateMipmapOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFramebuffersOES(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffersOES glGenFramebuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenRenderbuffersOES(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffersOES glGenRenderbuffersOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysOES glGenVertexArraysOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferPointervOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointervOES glGetBufferPointervOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanef(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
            internal unsafe static GetClipPlanef glGetClipPlanef;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanefOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
            internal unsafe static GetClipPlanefOES glGetClipPlanefOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
            internal unsafe static GetClipPlanex glGetClipPlanex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetClipPlanexOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
            internal unsafe static GetClipPlanexOES glGetClipPlanexOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetConvolutionParameterxvOES glGetConvolutionParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
            internal unsafe static GetDriverControlsQCOM glGetDriverControlsQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
            internal unsafe static GetDriverControlStringQCOM glGetDriverControlStringQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.ErrorCode GetError();
            internal static GetError glGetError;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFenceivNV(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFixedv(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetFixedv glGetFixedv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFixedvOES(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetFixedvOES glGetFixedvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferAttachmentParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameterivOES glGetFramebufferAttachmentParameterivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.ES11.All GetGraphicsResetStatusEXT();
            internal static GetGraphicsResetStatusEXT glGetGraphicsResetStatusEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetHistogramParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetHistogramParameterxvOES glGetHistogramParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64vAPPLE(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params);
            internal unsafe static GetInteger64vAPPLE glGetInteger64vAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetLightfv glGetLightfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxOES glGetLightxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxv glGetLightxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetLightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetLightxvOES glGetLightxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMapxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v);
            internal unsafe static GetMapxvOES glGetMapxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMaterialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetMaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static GetMaterialxOES glGetMaterialxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMaterialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetMaterialxv glGetMaterialxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetMaterialxvOES glGetMaterialxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvEXT glGetnUniformfvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivEXT glGetnUniformivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetPixelMapxv(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values);
            internal unsafe static GetPixelMapxv glGetPixelMapxv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointerv(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetRenderbufferParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameterivOES glGetRenderbufferParameterivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetString(OpenTK.Graphics.ES11.StringName name);
            internal static GetString glGetString;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSyncivAPPLE glGetSyncivAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexEnvxv glGetTexEnvxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexEnvxvOES glGetTexEnvxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexGenfvOES glGetTexGenfvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexGenivOES glGetTexGenivOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexGenxvOES glGetTexGenxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexLevelParameterxvOES(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexLevelParameterxvOES glGetTexLevelParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexParameterxv glGetTexParameterxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
            internal unsafe static GetTexParameterxvOES glGetTexParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode);
            internal static Hint glHint;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void IndexxOES(int component);
            internal static IndexxOES glIndexxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void IndexxvOES(int* component);
            internal unsafe static IndexxvOES glIndexxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFramebufferOES(UInt32 framebuffer);
            internal static IsFramebufferOES glIsFramebufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsRenderbufferOES(UInt32 renderbuffer);
            internal static IsRenderbufferOES glIsRenderbufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSyncAPPLE(IntPtr sync);
            internal static IsSyncAPPLE glIsSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsVertexArrayOES(UInt32 array);
            internal static IsVertexArrayOES glIsVertexArrayOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Lightf(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param);
            internal static Lightf glLightf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Lightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params);
            internal unsafe static Lightfv glLightfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightModelf(OpenTK.Graphics.ES11.LightModelParameter pname, Single param);
            internal static LightModelf glLightModelf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightModelfv(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params);
            internal unsafe static LightModelfv glLightModelfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightModelx(OpenTK.Graphics.ES11.All pname, int param);
            internal static LightModelx glLightModelx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightModelxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static LightModelxOES glLightModelxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightModelxv(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static LightModelxv glLightModelxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightModelxvOES(OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static LightModelxvOES glLightModelxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
            internal static Lightx glLightx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
            internal static LightxOES glLightxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Lightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static Lightxv glLightxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static LightxvOES glLightxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidthx(int width);
            internal static LineWidthx glLineWidthx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidthxOES(int width);
            internal static LineWidthxOES glLineWidthxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadMatrixf(Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadMatrixx(int* m);
            internal unsafe static LoadMatrixx glLoadMatrixx;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadMatrixxOES(int* m);
            internal unsafe static LoadMatrixxOES glLoadMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LoadPaletteFromModelViewMatrixOES();
            internal static LoadPaletteFromModelViewMatrixOES glLoadPaletteFromModelViewMatrixOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void LoadTransposeMatrixxOES(int* m);
            internal unsafe static LoadTransposeMatrixxOES glLoadTransposeMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode);
            internal static LogicOp glLogicOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Map1xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points);
            internal static Map1xOES glMap1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Map2xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points);
            internal static Map2xOES glMap2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access);
            internal static MapBufferOES glMapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access);
            internal static MapBufferRangeEXT glMapBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MapGrid1xOES(Int32 n, int u1, int u2);
            internal static MapGrid1xOES glMapGrid1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MapGrid2xOES(Int32 n, int u1, int u2, int v1, int v2);
            internal static MapGrid2xOES glMapGrid2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Materialf(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param);
            internal static Materialf glMaterialf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Materialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params);
            internal unsafe static Materialfv glMaterialfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static Materialx glMaterialx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
            internal static MaterialxOES glMaterialxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Materialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static Materialxv glMaterialxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
            internal unsafe static MaterialxvOES glMaterialxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MatrixIndexPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static MatrixIndexPointerOES glMatrixIndexPointerOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode);
            internal static MatrixMode glMatrixMode;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawArraysEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElementsEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord1bOES(OpenTK.Graphics.ES11.All texture, SByte s);
            internal static MultiTexCoord1bOES glMultiTexCoord1bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord1bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord1bvOES glMultiTexCoord1bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord1xOES(OpenTK.Graphics.ES11.All texture, int s);
            internal static MultiTexCoord1xOES glMultiTexCoord1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord1xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord1xvOES glMultiTexCoord1xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord2bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t);
            internal static MultiTexCoord2bOES glMultiTexCoord2bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord2bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord2bvOES glMultiTexCoord2bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord2xOES(OpenTK.Graphics.ES11.All texture, int s, int t);
            internal static MultiTexCoord2xOES glMultiTexCoord2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord2xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord2xvOES glMultiTexCoord2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord3bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r);
            internal static MultiTexCoord3bOES glMultiTexCoord3bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord3bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord3bvOES glMultiTexCoord3bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord3xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r);
            internal static MultiTexCoord3xOES glMultiTexCoord3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord3xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord3xvOES glMultiTexCoord3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q);
            internal static MultiTexCoord4bOES glMultiTexCoord4bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord4bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
            internal unsafe static MultiTexCoord4bvOES glMultiTexCoord4bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4f(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
            internal static MultiTexCoord4x glMultiTexCoord4x;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoord4xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
            internal static MultiTexCoord4xOES glMultiTexCoord4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoord4xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
            internal unsafe static MultiTexCoord4xvOES glMultiTexCoord4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultMatrixf(Single* m);
            internal unsafe static MultMatrixf glMultMatrixf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultMatrixx(int* m);
            internal unsafe static MultMatrixx glMultMatrixx;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultMatrixxOES(int* m);
            internal unsafe static MultMatrixxOES glMultMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultTransposeMatrixxOES(int* m);
            internal unsafe static MultTransposeMatrixxOES glMultTransposeMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Normal3f(Single nx, Single ny, Single nz);
            internal static Normal3f glNormal3f;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Normal3x(int nx, int ny, int nz);
            internal static Normal3x glNormal3x;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Normal3xOES(int nx, int ny, int nz);
            internal static Normal3xOES glNormal3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Normal3xvOES(int* coords);
            internal unsafe static Normal3xvOES glNormal3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer);
            internal static NormalPointer glNormalPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Orthof(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static Orthof glOrthof;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void OrthofOES(Single l, Single r, Single b, Single t, Single n, Single f);
            internal static OrthofOES glOrthofOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Orthox(int l, int r, int b, int t, int n, int f);
            internal static Orthox glOrthox;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void OrthoxOES(int l, int r, int b, int t, int n, int f);
            internal static OrthoxOES glOrthoxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PassThroughxOES(int token);
            internal static PassThroughxOES glPassThroughxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values);
            internal unsafe static PixelMapx glPixelMapx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorei(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorex(OpenTK.Graphics.ES11.All pname, int param);
            internal static PixelStorex glPixelStorex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelTransferxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static PixelTransferxOES glPixelTransferxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelZoomxOES(int xfactor, int yfactor);
            internal static PixelZoomxOES glPixelZoomxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterf(OpenTK.Graphics.ES11.All pname, Single param);
            internal static PointParameterf glPointParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterfv(OpenTK.Graphics.ES11.All pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterx(OpenTK.Graphics.ES11.All pname, int param);
            internal static PointParameterx glPointParameterx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterxOES(OpenTK.Graphics.ES11.All pname, int param);
            internal static PointParameterxOES glPointParameterxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterxv(OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static PointParameterxv glPointParameterxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterxvOES(OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static PointParameterxvOES glPointParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSizePointerOES(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static PointSizePointerOES glPointSizePointerOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSizex(int size);
            internal static PointSizex glPointSizex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSizexOES(int size);
            internal static PointSizexOES glPointSizexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffsetx(int factor, int units);
            internal static PolygonOffsetx glPolygonOffsetx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffsetxOES(int factor, int units);
            internal static PolygonOffsetxOES glPolygonOffsetxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PrioritizeTexturesxOES(Int32 n, UInt32* textures, int* priorities);
            internal unsafe static PrioritizeTexturesxOES glPrioritizeTexturesxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 QueryMatrixxOES([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent);
            internal unsafe static QueryMatrixxOES glQueryMatrixxOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RasterPos2xOES(int x, int y);
            internal static RasterPos2xOES glRasterPos2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RasterPos2xvOES(int* coords);
            internal unsafe static RasterPos2xvOES glRasterPos2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RasterPos3xOES(int x, int y, int z);
            internal static RasterPos3xOES glRasterPos3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RasterPos3xvOES(int* coords);
            internal unsafe static RasterPos3xvOES glRasterPos3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RasterPos4xOES(int x, int y, int z, int w);
            internal static RasterPos4xOES glRasterPos4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RasterPos4xvOES(int* coords);
            internal unsafe static RasterPos4xvOES glRasterPos4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsEXT glReadnPixelsEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RectxOES(int x1, int y1, int x2, int y2);
            internal static RectxOES glRectxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void RectxvOES(int* v1, int* v2);
            internal unsafe static RectxvOES glRectxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleAPPLE glRenderbufferStorageMultisampleAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisampleIMG glRenderbufferStorageMultisampleIMG;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageOES glRenderbufferStorageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResolveMultisampleFramebufferAPPLE();
            internal static ResolveMultisampleFramebufferAPPLE glResolveMultisampleFramebufferAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Rotatef(Single angle, Single x, Single y, Single z);
            internal static Rotatef glRotatef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Rotatex(int angle, int x, int y, int z);
            internal static Rotatex glRotatex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RotatexOES(int angle, int x, int y, int z);
            internal static RotatexOES glRotatexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverageOES(int value, bool invert);
            internal static SampleCoverageOES glSampleCoverageOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoveragex(int value, bool invert);
            internal static SampleCoveragex glSampleCoveragex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoveragexOES(int value, bool invert);
            internal static SampleCoveragexOES glSampleCoveragexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scalef(Single x, Single y, Single z);
            internal static Scalef glScalef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scalex(int x, int y, int z);
            internal static Scalex glScalex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ScalexOES(int x, int y, int z);
            internal static ScalexOES glScalexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SetFenceNV(UInt32 fence, OpenTK.Graphics.ES11.All condition);
            internal static SetFenceNV glSetFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode);
            internal static ShadeModel glShadeModel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
            internal static StartTilingQCOM glStartTilingQCOM;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord1bOES(SByte s);
            internal static TexCoord1bOES glTexCoord1bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord1bvOES(SByte* coords);
            internal unsafe static TexCoord1bvOES glTexCoord1bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord1xOES(int s);
            internal static TexCoord1xOES glTexCoord1xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord1xvOES(int* coords);
            internal unsafe static TexCoord1xvOES glTexCoord1xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord2bOES(SByte s, SByte t);
            internal static TexCoord2bOES glTexCoord2bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord2bvOES(SByte* coords);
            internal unsafe static TexCoord2bvOES glTexCoord2bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord2xOES(int s, int t);
            internal static TexCoord2xOES glTexCoord2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord2xvOES(int* coords);
            internal unsafe static TexCoord2xvOES glTexCoord2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord3bOES(SByte s, SByte t, SByte r);
            internal static TexCoord3bOES glTexCoord3bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord3bvOES(SByte* coords);
            internal unsafe static TexCoord3bvOES glTexCoord3bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord3xOES(int s, int t, int r);
            internal static TexCoord3xOES glTexCoord3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord3xvOES(int* coords);
            internal unsafe static TexCoord3xvOES glTexCoord3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord4bOES(SByte s, SByte t, SByte r, SByte q);
            internal static TexCoord4bOES glTexCoord4bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord4bvOES(SByte* coords);
            internal unsafe static TexCoord4bvOES glTexCoord4bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoord4xOES(int s, int t, int r, int q);
            internal static TexCoord4xOES glTexCoord4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoord4xvOES(int* coords);
            internal unsafe static TexCoord4xvOES glTexCoord4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            internal static TexCoordPointer glTexCoordPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvf(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param);
            internal static TexEnvf glTexEnvf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvi(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param);
            internal static TexEnvi glTexEnvi;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params);
            internal unsafe static TexEnviv glTexEnviv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexEnvx glTexEnvx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexEnvxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexEnvxOES glTexEnvxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexEnvxv glTexEnvxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexEnvxvOES glTexEnvxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexGenfOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param);
            internal static TexGenfOES glTexGenfOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params);
            internal unsafe static TexGenfvOES glTexGenfvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexGeniOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param);
            internal static TexGeniOES glTexGeniOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params);
            internal unsafe static TexGenivOES glTexGenivOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexGenxOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexGenxOES glTexGenxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexGenxvOES glTexGenxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterf(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameteri(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexParameterx glTexParameterx;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
            internal static TexParameterxOES glTexParameterxOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexParameterxv glTexParameterxv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
            internal unsafe static TexParameterxvOES glTexParameterxvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage1DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
            internal static TexStorage1DEXT glTexStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static TexStorage2DEXT glTexStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3DEXT glTexStorage3DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
            internal static TextureStorage1DEXT glTextureStorage1DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
            internal static TextureStorage2DEXT glTextureStorage2DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TextureStorage3DEXT glTextureStorage3DEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Translatef(Single x, Single y, Single z);
            internal static Translatef glTranslatef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Translatex(int x, int y, int z);
            internal static Translatex glTranslatex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TranslatexOES(int x, int y, int z);
            internal static TranslatexOES glTranslatexOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool UnmapBufferOES(OpenTK.Graphics.ES11.All target);
            internal static UnmapBufferOES glUnmapBufferOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex2bOES(SByte x);
            internal static Vertex2bOES glVertex2bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex2bvOES(SByte* coords);
            internal unsafe static Vertex2bvOES glVertex2bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex2xOES(int x);
            internal static Vertex2xOES glVertex2xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex2xvOES(int* coords);
            internal unsafe static Vertex2xvOES glVertex2xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex3bOES(SByte x, SByte y);
            internal static Vertex3bOES glVertex3bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex3bvOES(SByte* coords);
            internal unsafe static Vertex3bvOES glVertex3bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex3xOES(int x, int y);
            internal static Vertex3xOES glVertex3xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex3xvOES(int* coords);
            internal unsafe static Vertex3xvOES glVertex3xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex4bOES(SByte x, SByte y, SByte z);
            internal static Vertex4bOES glVertex4bOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex4bvOES(SByte* coords);
            internal unsafe static Vertex4bvOES glVertex4bvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Vertex4xOES(int x, int y, int z);
            internal static Vertex4xOES glVertex4xOES;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Vertex4xvOES(int* coords);
            internal unsafe static Vertex4xvOES glVertex4xvOES;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer);
            internal static VertexPointer glVertexPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void WaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
            internal static WaitSyncAPPLE glWaitSyncAPPLE;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void WeightPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
            internal static WeightPointerOES glWeightPointerOES;
        }
    }
}
