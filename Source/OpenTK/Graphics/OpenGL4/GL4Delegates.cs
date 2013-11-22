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



namespace OpenTK.Graphics.OpenGL4
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

            Delegates.glActiveShaderProgram = (Delegates.ActiveShaderProgram)GetExtensionDelegate("glActiveShaderProgram", typeof(Delegates.ActiveShaderProgram));
            Delegates.glActiveTexture = (Delegates.ActiveTexture)GetExtensionDelegate("glActiveTexture", typeof(Delegates.ActiveTexture));
            Delegates.glAttachShader = (Delegates.AttachShader)GetExtensionDelegate("glAttachShader", typeof(Delegates.AttachShader));
            Delegates.glBeginConditionalRender = (Delegates.BeginConditionalRender)GetExtensionDelegate("glBeginConditionalRender", typeof(Delegates.BeginConditionalRender));
            Delegates.glBeginQuery = (Delegates.BeginQuery)GetExtensionDelegate("glBeginQuery", typeof(Delegates.BeginQuery));
            Delegates.glBeginQueryIndexed = (Delegates.BeginQueryIndexed)GetExtensionDelegate("glBeginQueryIndexed", typeof(Delegates.BeginQueryIndexed));
            Delegates.glBeginTransformFeedback = (Delegates.BeginTransformFeedback)GetExtensionDelegate("glBeginTransformFeedback", typeof(Delegates.BeginTransformFeedback));
            Delegates.glBindAttribLocation = (Delegates.BindAttribLocation)GetExtensionDelegate("glBindAttribLocation", typeof(Delegates.BindAttribLocation));
            Delegates.glBindBuffer = (Delegates.BindBuffer)GetExtensionDelegate("glBindBuffer", typeof(Delegates.BindBuffer));
            Delegates.glBindBufferBase = (Delegates.BindBufferBase)GetExtensionDelegate("glBindBufferBase", typeof(Delegates.BindBufferBase));
            Delegates.glBindBufferRange = (Delegates.BindBufferRange)GetExtensionDelegate("glBindBufferRange", typeof(Delegates.BindBufferRange));
            Delegates.glBindBuffersBase = (Delegates.BindBuffersBase)GetExtensionDelegate("glBindBuffersBase", typeof(Delegates.BindBuffersBase));
            Delegates.glBindBuffersRange = (Delegates.BindBuffersRange)GetExtensionDelegate("glBindBuffersRange", typeof(Delegates.BindBuffersRange));
            Delegates.glBindFragDataLocation = (Delegates.BindFragDataLocation)GetExtensionDelegate("glBindFragDataLocation", typeof(Delegates.BindFragDataLocation));
            Delegates.glBindFragDataLocationIndexed = (Delegates.BindFragDataLocationIndexed)GetExtensionDelegate("glBindFragDataLocationIndexed", typeof(Delegates.BindFragDataLocationIndexed));
            Delegates.glBindFramebuffer = (Delegates.BindFramebuffer)GetExtensionDelegate("glBindFramebuffer", typeof(Delegates.BindFramebuffer));
            Delegates.glBindImageTexture = (Delegates.BindImageTexture)GetExtensionDelegate("glBindImageTexture", typeof(Delegates.BindImageTexture));
            Delegates.glBindImageTextures = (Delegates.BindImageTextures)GetExtensionDelegate("glBindImageTextures", typeof(Delegates.BindImageTextures));
            Delegates.glBindProgramPipeline = (Delegates.BindProgramPipeline)GetExtensionDelegate("glBindProgramPipeline", typeof(Delegates.BindProgramPipeline));
            Delegates.glBindRenderbuffer = (Delegates.BindRenderbuffer)GetExtensionDelegate("glBindRenderbuffer", typeof(Delegates.BindRenderbuffer));
            Delegates.glBindSampler = (Delegates.BindSampler)GetExtensionDelegate("glBindSampler", typeof(Delegates.BindSampler));
            Delegates.glBindSamplers = (Delegates.BindSamplers)GetExtensionDelegate("glBindSamplers", typeof(Delegates.BindSamplers));
            Delegates.glBindTexture = (Delegates.BindTexture)GetExtensionDelegate("glBindTexture", typeof(Delegates.BindTexture));
            Delegates.glBindTextures = (Delegates.BindTextures)GetExtensionDelegate("glBindTextures", typeof(Delegates.BindTextures));
            Delegates.glBindTransformFeedback = (Delegates.BindTransformFeedback)GetExtensionDelegate("glBindTransformFeedback", typeof(Delegates.BindTransformFeedback));
            Delegates.glBindVertexArray = (Delegates.BindVertexArray)GetExtensionDelegate("glBindVertexArray", typeof(Delegates.BindVertexArray));
            Delegates.glBindVertexBuffer = (Delegates.BindVertexBuffer)GetExtensionDelegate("glBindVertexBuffer", typeof(Delegates.BindVertexBuffer));
            Delegates.glBindVertexBuffers = (Delegates.BindVertexBuffers)GetExtensionDelegate("glBindVertexBuffers", typeof(Delegates.BindVertexBuffers));
            Delegates.glBlendColor = (Delegates.BlendColor)GetExtensionDelegate("glBlendColor", typeof(Delegates.BlendColor));
            Delegates.glBlendEquation = (Delegates.BlendEquation)GetExtensionDelegate("glBlendEquation", typeof(Delegates.BlendEquation));
            Delegates.glBlendEquationi = (Delegates.BlendEquationi)GetExtensionDelegate("glBlendEquationi", typeof(Delegates.BlendEquationi));
            Delegates.glBlendEquationiARB = (Delegates.BlendEquationiARB)GetExtensionDelegate("glBlendEquationiARB", typeof(Delegates.BlendEquationiARB));
            Delegates.glBlendEquationSeparate = (Delegates.BlendEquationSeparate)GetExtensionDelegate("glBlendEquationSeparate", typeof(Delegates.BlendEquationSeparate));
            Delegates.glBlendEquationSeparatei = (Delegates.BlendEquationSeparatei)GetExtensionDelegate("glBlendEquationSeparatei", typeof(Delegates.BlendEquationSeparatei));
            Delegates.glBlendEquationSeparateiARB = (Delegates.BlendEquationSeparateiARB)GetExtensionDelegate("glBlendEquationSeparateiARB", typeof(Delegates.BlendEquationSeparateiARB));
            Delegates.glBlendFunc = (Delegates.BlendFunc)GetExtensionDelegate("glBlendFunc", typeof(Delegates.BlendFunc));
            Delegates.glBlendFunci = (Delegates.BlendFunci)GetExtensionDelegate("glBlendFunci", typeof(Delegates.BlendFunci));
            Delegates.glBlendFunciARB = (Delegates.BlendFunciARB)GetExtensionDelegate("glBlendFunciARB", typeof(Delegates.BlendFunciARB));
            Delegates.glBlendFuncSeparate = (Delegates.BlendFuncSeparate)GetExtensionDelegate("glBlendFuncSeparate", typeof(Delegates.BlendFuncSeparate));
            Delegates.glBlendFuncSeparatei = (Delegates.BlendFuncSeparatei)GetExtensionDelegate("glBlendFuncSeparatei", typeof(Delegates.BlendFuncSeparatei));
            Delegates.glBlendFuncSeparateiARB = (Delegates.BlendFuncSeparateiARB)GetExtensionDelegate("glBlendFuncSeparateiARB", typeof(Delegates.BlendFuncSeparateiARB));
            Delegates.glBlitFramebuffer = (Delegates.BlitFramebuffer)GetExtensionDelegate("glBlitFramebuffer", typeof(Delegates.BlitFramebuffer));
            Delegates.glBufferData = (Delegates.BufferData)GetExtensionDelegate("glBufferData", typeof(Delegates.BufferData));
            Delegates.glBufferStorage = (Delegates.BufferStorage)GetExtensionDelegate("glBufferStorage", typeof(Delegates.BufferStorage));
            Delegates.glBufferSubData = (Delegates.BufferSubData)GetExtensionDelegate("glBufferSubData", typeof(Delegates.BufferSubData));
            Delegates.glCheckFramebufferStatus = (Delegates.CheckFramebufferStatus)GetExtensionDelegate("glCheckFramebufferStatus", typeof(Delegates.CheckFramebufferStatus));
            Delegates.glClampColor = (Delegates.ClampColor)GetExtensionDelegate("glClampColor", typeof(Delegates.ClampColor));
            Delegates.glClear = (Delegates.Clear)GetExtensionDelegate("glClear", typeof(Delegates.Clear));
            Delegates.glClearBufferData = (Delegates.ClearBufferData)GetExtensionDelegate("glClearBufferData", typeof(Delegates.ClearBufferData));
            Delegates.glClearBufferfi = (Delegates.ClearBufferfi)GetExtensionDelegate("glClearBufferfi", typeof(Delegates.ClearBufferfi));
            Delegates.glClearBufferfv = (Delegates.ClearBufferfv)GetExtensionDelegate("glClearBufferfv", typeof(Delegates.ClearBufferfv));
            Delegates.glClearBufferiv = (Delegates.ClearBufferiv)GetExtensionDelegate("glClearBufferiv", typeof(Delegates.ClearBufferiv));
            Delegates.glClearBufferSubData = (Delegates.ClearBufferSubData)GetExtensionDelegate("glClearBufferSubData", typeof(Delegates.ClearBufferSubData));
            Delegates.glClearBufferuiv = (Delegates.ClearBufferuiv)GetExtensionDelegate("glClearBufferuiv", typeof(Delegates.ClearBufferuiv));
            Delegates.glClearColor = (Delegates.ClearColor)GetExtensionDelegate("glClearColor", typeof(Delegates.ClearColor));
            Delegates.glClearDepth = (Delegates.ClearDepth)GetExtensionDelegate("glClearDepth", typeof(Delegates.ClearDepth));
            Delegates.glClearDepthf = (Delegates.ClearDepthf)GetExtensionDelegate("glClearDepthf", typeof(Delegates.ClearDepthf));
            Delegates.glClearStencil = (Delegates.ClearStencil)GetExtensionDelegate("glClearStencil", typeof(Delegates.ClearStencil));
            Delegates.glClearTexImage = (Delegates.ClearTexImage)GetExtensionDelegate("glClearTexImage", typeof(Delegates.ClearTexImage));
            Delegates.glClearTexSubImage = (Delegates.ClearTexSubImage)GetExtensionDelegate("glClearTexSubImage", typeof(Delegates.ClearTexSubImage));
            Delegates.glClientWaitSync = (Delegates.ClientWaitSync)GetExtensionDelegate("glClientWaitSync", typeof(Delegates.ClientWaitSync));
            Delegates.glColorMask = (Delegates.ColorMask)GetExtensionDelegate("glColorMask", typeof(Delegates.ColorMask));
            Delegates.glColorMaski = (Delegates.ColorMaski)GetExtensionDelegate("glColorMaski", typeof(Delegates.ColorMaski));
            Delegates.glColorP3ui = (Delegates.ColorP3ui)GetExtensionDelegate("glColorP3ui", typeof(Delegates.ColorP3ui));
            Delegates.glColorP3uiv = (Delegates.ColorP3uiv)GetExtensionDelegate("glColorP3uiv", typeof(Delegates.ColorP3uiv));
            Delegates.glColorP4ui = (Delegates.ColorP4ui)GetExtensionDelegate("glColorP4ui", typeof(Delegates.ColorP4ui));
            Delegates.glColorP4uiv = (Delegates.ColorP4uiv)GetExtensionDelegate("glColorP4uiv", typeof(Delegates.ColorP4uiv));
            Delegates.glColorSubTable = (Delegates.ColorSubTable)GetExtensionDelegate("glColorSubTable", typeof(Delegates.ColorSubTable));
            Delegates.glColorTable = (Delegates.ColorTable)GetExtensionDelegate("glColorTable", typeof(Delegates.ColorTable));
            Delegates.glColorTableParameterfv = (Delegates.ColorTableParameterfv)GetExtensionDelegate("glColorTableParameterfv", typeof(Delegates.ColorTableParameterfv));
            Delegates.glColorTableParameteriv = (Delegates.ColorTableParameteriv)GetExtensionDelegate("glColorTableParameteriv", typeof(Delegates.ColorTableParameteriv));
            Delegates.glCompileShader = (Delegates.CompileShader)GetExtensionDelegate("glCompileShader", typeof(Delegates.CompileShader));
            Delegates.glCompileShaderIncludeARB = (Delegates.CompileShaderIncludeARB)GetExtensionDelegate("glCompileShaderIncludeARB", typeof(Delegates.CompileShaderIncludeARB));
            Delegates.glCompressedTexImage1D = (Delegates.CompressedTexImage1D)GetExtensionDelegate("glCompressedTexImage1D", typeof(Delegates.CompressedTexImage1D));
            Delegates.glCompressedTexImage2D = (Delegates.CompressedTexImage2D)GetExtensionDelegate("glCompressedTexImage2D", typeof(Delegates.CompressedTexImage2D));
            Delegates.glCompressedTexImage3D = (Delegates.CompressedTexImage3D)GetExtensionDelegate("glCompressedTexImage3D", typeof(Delegates.CompressedTexImage3D));
            Delegates.glCompressedTexSubImage1D = (Delegates.CompressedTexSubImage1D)GetExtensionDelegate("glCompressedTexSubImage1D", typeof(Delegates.CompressedTexSubImage1D));
            Delegates.glCompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)GetExtensionDelegate("glCompressedTexSubImage2D", typeof(Delegates.CompressedTexSubImage2D));
            Delegates.glCompressedTexSubImage3D = (Delegates.CompressedTexSubImage3D)GetExtensionDelegate("glCompressedTexSubImage3D", typeof(Delegates.CompressedTexSubImage3D));
            Delegates.glConvolutionFilter1D = (Delegates.ConvolutionFilter1D)GetExtensionDelegate("glConvolutionFilter1D", typeof(Delegates.ConvolutionFilter1D));
            Delegates.glConvolutionFilter2D = (Delegates.ConvolutionFilter2D)GetExtensionDelegate("glConvolutionFilter2D", typeof(Delegates.ConvolutionFilter2D));
            Delegates.glConvolutionParameterf = (Delegates.ConvolutionParameterf)GetExtensionDelegate("glConvolutionParameterf", typeof(Delegates.ConvolutionParameterf));
            Delegates.glConvolutionParameterfv = (Delegates.ConvolutionParameterfv)GetExtensionDelegate("glConvolutionParameterfv", typeof(Delegates.ConvolutionParameterfv));
            Delegates.glConvolutionParameteri = (Delegates.ConvolutionParameteri)GetExtensionDelegate("glConvolutionParameteri", typeof(Delegates.ConvolutionParameteri));
            Delegates.glConvolutionParameteriv = (Delegates.ConvolutionParameteriv)GetExtensionDelegate("glConvolutionParameteriv", typeof(Delegates.ConvolutionParameteriv));
            Delegates.glCopyBufferSubData = (Delegates.CopyBufferSubData)GetExtensionDelegate("glCopyBufferSubData", typeof(Delegates.CopyBufferSubData));
            Delegates.glCopyColorSubTable = (Delegates.CopyColorSubTable)GetExtensionDelegate("glCopyColorSubTable", typeof(Delegates.CopyColorSubTable));
            Delegates.glCopyColorTable = (Delegates.CopyColorTable)GetExtensionDelegate("glCopyColorTable", typeof(Delegates.CopyColorTable));
            Delegates.glCopyConvolutionFilter1D = (Delegates.CopyConvolutionFilter1D)GetExtensionDelegate("glCopyConvolutionFilter1D", typeof(Delegates.CopyConvolutionFilter1D));
            Delegates.glCopyConvolutionFilter2D = (Delegates.CopyConvolutionFilter2D)GetExtensionDelegate("glCopyConvolutionFilter2D", typeof(Delegates.CopyConvolutionFilter2D));
            Delegates.glCopyImageSubData = (Delegates.CopyImageSubData)GetExtensionDelegate("glCopyImageSubData", typeof(Delegates.CopyImageSubData));
            Delegates.glCopyTexImage1D = (Delegates.CopyTexImage1D)GetExtensionDelegate("glCopyTexImage1D", typeof(Delegates.CopyTexImage1D));
            Delegates.glCopyTexImage2D = (Delegates.CopyTexImage2D)GetExtensionDelegate("glCopyTexImage2D", typeof(Delegates.CopyTexImage2D));
            Delegates.glCopyTexSubImage1D = (Delegates.CopyTexSubImage1D)GetExtensionDelegate("glCopyTexSubImage1D", typeof(Delegates.CopyTexSubImage1D));
            Delegates.glCopyTexSubImage2D = (Delegates.CopyTexSubImage2D)GetExtensionDelegate("glCopyTexSubImage2D", typeof(Delegates.CopyTexSubImage2D));
            Delegates.glCopyTexSubImage3D = (Delegates.CopyTexSubImage3D)GetExtensionDelegate("glCopyTexSubImage3D", typeof(Delegates.CopyTexSubImage3D));
            Delegates.glCreateProgram = (Delegates.CreateProgram)GetExtensionDelegate("glCreateProgram", typeof(Delegates.CreateProgram));
            Delegates.glCreateShader = (Delegates.CreateShader)GetExtensionDelegate("glCreateShader", typeof(Delegates.CreateShader));
            Delegates.glCreateShaderProgramv = (Delegates.CreateShaderProgramv)GetExtensionDelegate("glCreateShaderProgramv", typeof(Delegates.CreateShaderProgramv));
            Delegates.glCreateSyncFromCLeventARB = (Delegates.CreateSyncFromCLeventARB)GetExtensionDelegate("glCreateSyncFromCLeventARB", typeof(Delegates.CreateSyncFromCLeventARB));
            Delegates.glCullFace = (Delegates.CullFace)GetExtensionDelegate("glCullFace", typeof(Delegates.CullFace));
            Delegates.glDebugMessageCallback = (Delegates.DebugMessageCallback)GetExtensionDelegate("glDebugMessageCallback", typeof(Delegates.DebugMessageCallback));
            Delegates.glDebugMessageCallbackARB = (Delegates.DebugMessageCallbackARB)GetExtensionDelegate("glDebugMessageCallbackARB", typeof(Delegates.DebugMessageCallbackARB));
            Delegates.glDebugMessageCallbackKHR = (Delegates.DebugMessageCallbackKHR)GetExtensionDelegate("glDebugMessageCallbackKHR", typeof(Delegates.DebugMessageCallbackKHR));
            Delegates.glDebugMessageControl = (Delegates.DebugMessageControl)GetExtensionDelegate("glDebugMessageControl", typeof(Delegates.DebugMessageControl));
            Delegates.glDebugMessageControlARB = (Delegates.DebugMessageControlARB)GetExtensionDelegate("glDebugMessageControlARB", typeof(Delegates.DebugMessageControlARB));
            Delegates.glDebugMessageControlKHR = (Delegates.DebugMessageControlKHR)GetExtensionDelegate("glDebugMessageControlKHR", typeof(Delegates.DebugMessageControlKHR));
            Delegates.glDebugMessageInsert = (Delegates.DebugMessageInsert)GetExtensionDelegate("glDebugMessageInsert", typeof(Delegates.DebugMessageInsert));
            Delegates.glDebugMessageInsertARB = (Delegates.DebugMessageInsertARB)GetExtensionDelegate("glDebugMessageInsertARB", typeof(Delegates.DebugMessageInsertARB));
            Delegates.glDebugMessageInsertKHR = (Delegates.DebugMessageInsertKHR)GetExtensionDelegate("glDebugMessageInsertKHR", typeof(Delegates.DebugMessageInsertKHR));
            Delegates.glDeleteBuffers = (Delegates.DeleteBuffers)GetExtensionDelegate("glDeleteBuffers", typeof(Delegates.DeleteBuffers));
            Delegates.glDeleteFramebuffers = (Delegates.DeleteFramebuffers)GetExtensionDelegate("glDeleteFramebuffers", typeof(Delegates.DeleteFramebuffers));
            Delegates.glDeleteNamedStringARB = (Delegates.DeleteNamedStringARB)GetExtensionDelegate("glDeleteNamedStringARB", typeof(Delegates.DeleteNamedStringARB));
            Delegates.glDeleteProgram = (Delegates.DeleteProgram)GetExtensionDelegate("glDeleteProgram", typeof(Delegates.DeleteProgram));
            Delegates.glDeleteProgramPipelines = (Delegates.DeleteProgramPipelines)GetExtensionDelegate("glDeleteProgramPipelines", typeof(Delegates.DeleteProgramPipelines));
            Delegates.glDeleteQueries = (Delegates.DeleteQueries)GetExtensionDelegate("glDeleteQueries", typeof(Delegates.DeleteQueries));
            Delegates.glDeleteRenderbuffers = (Delegates.DeleteRenderbuffers)GetExtensionDelegate("glDeleteRenderbuffers", typeof(Delegates.DeleteRenderbuffers));
            Delegates.glDeleteSamplers = (Delegates.DeleteSamplers)GetExtensionDelegate("glDeleteSamplers", typeof(Delegates.DeleteSamplers));
            Delegates.glDeleteShader = (Delegates.DeleteShader)GetExtensionDelegate("glDeleteShader", typeof(Delegates.DeleteShader));
            Delegates.glDeleteSync = (Delegates.DeleteSync)GetExtensionDelegate("glDeleteSync", typeof(Delegates.DeleteSync));
            Delegates.glDeleteTextures = (Delegates.DeleteTextures)GetExtensionDelegate("glDeleteTextures", typeof(Delegates.DeleteTextures));
            Delegates.glDeleteTransformFeedbacks = (Delegates.DeleteTransformFeedbacks)GetExtensionDelegate("glDeleteTransformFeedbacks", typeof(Delegates.DeleteTransformFeedbacks));
            Delegates.glDeleteVertexArrays = (Delegates.DeleteVertexArrays)GetExtensionDelegate("glDeleteVertexArrays", typeof(Delegates.DeleteVertexArrays));
            Delegates.glDepthFunc = (Delegates.DepthFunc)GetExtensionDelegate("glDepthFunc", typeof(Delegates.DepthFunc));
            Delegates.glDepthMask = (Delegates.DepthMask)GetExtensionDelegate("glDepthMask", typeof(Delegates.DepthMask));
            Delegates.glDepthRange = (Delegates.DepthRange)GetExtensionDelegate("glDepthRange", typeof(Delegates.DepthRange));
            Delegates.glDepthRangeArrayv = (Delegates.DepthRangeArrayv)GetExtensionDelegate("glDepthRangeArrayv", typeof(Delegates.DepthRangeArrayv));
            Delegates.glDepthRangef = (Delegates.DepthRangef)GetExtensionDelegate("glDepthRangef", typeof(Delegates.DepthRangef));
            Delegates.glDepthRangeIndexed = (Delegates.DepthRangeIndexed)GetExtensionDelegate("glDepthRangeIndexed", typeof(Delegates.DepthRangeIndexed));
            Delegates.glDetachShader = (Delegates.DetachShader)GetExtensionDelegate("glDetachShader", typeof(Delegates.DetachShader));
            Delegates.glDisable = (Delegates.Disable)GetExtensionDelegate("glDisable", typeof(Delegates.Disable));
            Delegates.glDisablei = (Delegates.Disablei)GetExtensionDelegate("glDisablei", typeof(Delegates.Disablei));
            Delegates.glDisableVertexAttribArray = (Delegates.DisableVertexAttribArray)GetExtensionDelegate("glDisableVertexAttribArray", typeof(Delegates.DisableVertexAttribArray));
            Delegates.glDispatchCompute = (Delegates.DispatchCompute)GetExtensionDelegate("glDispatchCompute", typeof(Delegates.DispatchCompute));
            Delegates.glDispatchComputeGroupSizeARB = (Delegates.DispatchComputeGroupSizeARB)GetExtensionDelegate("glDispatchComputeGroupSizeARB", typeof(Delegates.DispatchComputeGroupSizeARB));
            Delegates.glDispatchComputeIndirect = (Delegates.DispatchComputeIndirect)GetExtensionDelegate("glDispatchComputeIndirect", typeof(Delegates.DispatchComputeIndirect));
            Delegates.glDrawArrays = (Delegates.DrawArrays)GetExtensionDelegate("glDrawArrays", typeof(Delegates.DrawArrays));
            Delegates.glDrawArraysIndirect = (Delegates.DrawArraysIndirect)GetExtensionDelegate("glDrawArraysIndirect", typeof(Delegates.DrawArraysIndirect));
            Delegates.glDrawArraysInstanced = (Delegates.DrawArraysInstanced)GetExtensionDelegate("glDrawArraysInstanced", typeof(Delegates.DrawArraysInstanced));
            Delegates.glDrawArraysInstancedBaseInstance = (Delegates.DrawArraysInstancedBaseInstance)GetExtensionDelegate("glDrawArraysInstancedBaseInstance", typeof(Delegates.DrawArraysInstancedBaseInstance));
            Delegates.glDrawBuffer = (Delegates.DrawBuffer)GetExtensionDelegate("glDrawBuffer", typeof(Delegates.DrawBuffer));
            Delegates.glDrawBuffers = (Delegates.DrawBuffers)GetExtensionDelegate("glDrawBuffers", typeof(Delegates.DrawBuffers));
            Delegates.glDrawElements = (Delegates.DrawElements)GetExtensionDelegate("glDrawElements", typeof(Delegates.DrawElements));
            Delegates.glDrawElementsBaseVertex = (Delegates.DrawElementsBaseVertex)GetExtensionDelegate("glDrawElementsBaseVertex", typeof(Delegates.DrawElementsBaseVertex));
            Delegates.glDrawElementsIndirect = (Delegates.DrawElementsIndirect)GetExtensionDelegate("glDrawElementsIndirect", typeof(Delegates.DrawElementsIndirect));
            Delegates.glDrawElementsInstanced = (Delegates.DrawElementsInstanced)GetExtensionDelegate("glDrawElementsInstanced", typeof(Delegates.DrawElementsInstanced));
            Delegates.glDrawElementsInstancedBaseInstance = (Delegates.DrawElementsInstancedBaseInstance)GetExtensionDelegate("glDrawElementsInstancedBaseInstance", typeof(Delegates.DrawElementsInstancedBaseInstance));
            Delegates.glDrawElementsInstancedBaseVertex = (Delegates.DrawElementsInstancedBaseVertex)GetExtensionDelegate("glDrawElementsInstancedBaseVertex", typeof(Delegates.DrawElementsInstancedBaseVertex));
            Delegates.glDrawElementsInstancedBaseVertexBaseInstance = (Delegates.DrawElementsInstancedBaseVertexBaseInstance)GetExtensionDelegate("glDrawElementsInstancedBaseVertexBaseInstance", typeof(Delegates.DrawElementsInstancedBaseVertexBaseInstance));
            Delegates.glDrawRangeElements = (Delegates.DrawRangeElements)GetExtensionDelegate("glDrawRangeElements", typeof(Delegates.DrawRangeElements));
            Delegates.glDrawRangeElementsBaseVertex = (Delegates.DrawRangeElementsBaseVertex)GetExtensionDelegate("glDrawRangeElementsBaseVertex", typeof(Delegates.DrawRangeElementsBaseVertex));
            Delegates.glDrawTransformFeedback = (Delegates.DrawTransformFeedback)GetExtensionDelegate("glDrawTransformFeedback", typeof(Delegates.DrawTransformFeedback));
            Delegates.glDrawTransformFeedbackInstanced = (Delegates.DrawTransformFeedbackInstanced)GetExtensionDelegate("glDrawTransformFeedbackInstanced", typeof(Delegates.DrawTransformFeedbackInstanced));
            Delegates.glDrawTransformFeedbackStream = (Delegates.DrawTransformFeedbackStream)GetExtensionDelegate("glDrawTransformFeedbackStream", typeof(Delegates.DrawTransformFeedbackStream));
            Delegates.glDrawTransformFeedbackStreamInstanced = (Delegates.DrawTransformFeedbackStreamInstanced)GetExtensionDelegate("glDrawTransformFeedbackStreamInstanced", typeof(Delegates.DrawTransformFeedbackStreamInstanced));
            Delegates.glEnable = (Delegates.Enable)GetExtensionDelegate("glEnable", typeof(Delegates.Enable));
            Delegates.glEnablei = (Delegates.Enablei)GetExtensionDelegate("glEnablei", typeof(Delegates.Enablei));
            Delegates.glEnableVertexAttribArray = (Delegates.EnableVertexAttribArray)GetExtensionDelegate("glEnableVertexAttribArray", typeof(Delegates.EnableVertexAttribArray));
            Delegates.glEndConditionalRender = (Delegates.EndConditionalRender)GetExtensionDelegate("glEndConditionalRender", typeof(Delegates.EndConditionalRender));
            Delegates.glEndQuery = (Delegates.EndQuery)GetExtensionDelegate("glEndQuery", typeof(Delegates.EndQuery));
            Delegates.glEndQueryIndexed = (Delegates.EndQueryIndexed)GetExtensionDelegate("glEndQueryIndexed", typeof(Delegates.EndQueryIndexed));
            Delegates.glEndTransformFeedback = (Delegates.EndTransformFeedback)GetExtensionDelegate("glEndTransformFeedback", typeof(Delegates.EndTransformFeedback));
            Delegates.glFenceSync = (Delegates.FenceSync)GetExtensionDelegate("glFenceSync", typeof(Delegates.FenceSync));
            Delegates.glFinish = (Delegates.Finish)GetExtensionDelegate("glFinish", typeof(Delegates.Finish));
            Delegates.glFlush = (Delegates.Flush)GetExtensionDelegate("glFlush", typeof(Delegates.Flush));
            Delegates.glFlushMappedBufferRange = (Delegates.FlushMappedBufferRange)GetExtensionDelegate("glFlushMappedBufferRange", typeof(Delegates.FlushMappedBufferRange));
            Delegates.glFramebufferParameteri = (Delegates.FramebufferParameteri)GetExtensionDelegate("glFramebufferParameteri", typeof(Delegates.FramebufferParameteri));
            Delegates.glFramebufferRenderbuffer = (Delegates.FramebufferRenderbuffer)GetExtensionDelegate("glFramebufferRenderbuffer", typeof(Delegates.FramebufferRenderbuffer));
            Delegates.glFramebufferTexture = (Delegates.FramebufferTexture)GetExtensionDelegate("glFramebufferTexture", typeof(Delegates.FramebufferTexture));
            Delegates.glFramebufferTexture1D = (Delegates.FramebufferTexture1D)GetExtensionDelegate("glFramebufferTexture1D", typeof(Delegates.FramebufferTexture1D));
            Delegates.glFramebufferTexture2D = (Delegates.FramebufferTexture2D)GetExtensionDelegate("glFramebufferTexture2D", typeof(Delegates.FramebufferTexture2D));
            Delegates.glFramebufferTexture3D = (Delegates.FramebufferTexture3D)GetExtensionDelegate("glFramebufferTexture3D", typeof(Delegates.FramebufferTexture3D));
            Delegates.glFramebufferTextureLayer = (Delegates.FramebufferTextureLayer)GetExtensionDelegate("glFramebufferTextureLayer", typeof(Delegates.FramebufferTextureLayer));
            Delegates.glFrontFace = (Delegates.FrontFace)GetExtensionDelegate("glFrontFace", typeof(Delegates.FrontFace));
            Delegates.glGenBuffers = (Delegates.GenBuffers)GetExtensionDelegate("glGenBuffers", typeof(Delegates.GenBuffers));
            Delegates.glGenerateMipmap = (Delegates.GenerateMipmap)GetExtensionDelegate("glGenerateMipmap", typeof(Delegates.GenerateMipmap));
            Delegates.glGenFramebuffers = (Delegates.GenFramebuffers)GetExtensionDelegate("glGenFramebuffers", typeof(Delegates.GenFramebuffers));
            Delegates.glGenProgramPipelines = (Delegates.GenProgramPipelines)GetExtensionDelegate("glGenProgramPipelines", typeof(Delegates.GenProgramPipelines));
            Delegates.glGenQueries = (Delegates.GenQueries)GetExtensionDelegate("glGenQueries", typeof(Delegates.GenQueries));
            Delegates.glGenRenderbuffers = (Delegates.GenRenderbuffers)GetExtensionDelegate("glGenRenderbuffers", typeof(Delegates.GenRenderbuffers));
            Delegates.glGenSamplers = (Delegates.GenSamplers)GetExtensionDelegate("glGenSamplers", typeof(Delegates.GenSamplers));
            Delegates.glGenTextures = (Delegates.GenTextures)GetExtensionDelegate("glGenTextures", typeof(Delegates.GenTextures));
            Delegates.glGenTransformFeedbacks = (Delegates.GenTransformFeedbacks)GetExtensionDelegate("glGenTransformFeedbacks", typeof(Delegates.GenTransformFeedbacks));
            Delegates.glGenVertexArrays = (Delegates.GenVertexArrays)GetExtensionDelegate("glGenVertexArrays", typeof(Delegates.GenVertexArrays));
            Delegates.glGetActiveAtomicCounterBufferiv = (Delegates.GetActiveAtomicCounterBufferiv)GetExtensionDelegate("glGetActiveAtomicCounterBufferiv", typeof(Delegates.GetActiveAtomicCounterBufferiv));
            Delegates.glGetActiveAttrib = (Delegates.GetActiveAttrib)GetExtensionDelegate("glGetActiveAttrib", typeof(Delegates.GetActiveAttrib));
            Delegates.glGetActiveSubroutineName = (Delegates.GetActiveSubroutineName)GetExtensionDelegate("glGetActiveSubroutineName", typeof(Delegates.GetActiveSubroutineName));
            Delegates.glGetActiveSubroutineUniformiv = (Delegates.GetActiveSubroutineUniformiv)GetExtensionDelegate("glGetActiveSubroutineUniformiv", typeof(Delegates.GetActiveSubroutineUniformiv));
            Delegates.glGetActiveSubroutineUniformName = (Delegates.GetActiveSubroutineUniformName)GetExtensionDelegate("glGetActiveSubroutineUniformName", typeof(Delegates.GetActiveSubroutineUniformName));
            Delegates.glGetActiveUniform = (Delegates.GetActiveUniform)GetExtensionDelegate("glGetActiveUniform", typeof(Delegates.GetActiveUniform));
            Delegates.glGetActiveUniformBlockiv = (Delegates.GetActiveUniformBlockiv)GetExtensionDelegate("glGetActiveUniformBlockiv", typeof(Delegates.GetActiveUniformBlockiv));
            Delegates.glGetActiveUniformBlockName = (Delegates.GetActiveUniformBlockName)GetExtensionDelegate("glGetActiveUniformBlockName", typeof(Delegates.GetActiveUniformBlockName));
            Delegates.glGetActiveUniformName = (Delegates.GetActiveUniformName)GetExtensionDelegate("glGetActiveUniformName", typeof(Delegates.GetActiveUniformName));
            Delegates.glGetActiveUniformsiv = (Delegates.GetActiveUniformsiv)GetExtensionDelegate("glGetActiveUniformsiv", typeof(Delegates.GetActiveUniformsiv));
            Delegates.glGetAttachedShaders = (Delegates.GetAttachedShaders)GetExtensionDelegate("glGetAttachedShaders", typeof(Delegates.GetAttachedShaders));
            Delegates.glGetAttribLocation = (Delegates.GetAttribLocation)GetExtensionDelegate("glGetAttribLocation", typeof(Delegates.GetAttribLocation));
            Delegates.glGetBooleani_v = (Delegates.GetBooleani_v)GetExtensionDelegate("glGetBooleani_v", typeof(Delegates.GetBooleani_v));
            Delegates.glGetBooleanv = (Delegates.GetBooleanv)GetExtensionDelegate("glGetBooleanv", typeof(Delegates.GetBooleanv));
            Delegates.glGetBufferParameteri64v = (Delegates.GetBufferParameteri64v)GetExtensionDelegate("glGetBufferParameteri64v", typeof(Delegates.GetBufferParameteri64v));
            Delegates.glGetBufferParameteriv = (Delegates.GetBufferParameteriv)GetExtensionDelegate("glGetBufferParameteriv", typeof(Delegates.GetBufferParameteriv));
            Delegates.glGetBufferPointerv = (Delegates.GetBufferPointerv)GetExtensionDelegate("glGetBufferPointerv", typeof(Delegates.GetBufferPointerv));
            Delegates.glGetBufferSubData = (Delegates.GetBufferSubData)GetExtensionDelegate("glGetBufferSubData", typeof(Delegates.GetBufferSubData));
            Delegates.glGetColorTable = (Delegates.GetColorTable)GetExtensionDelegate("glGetColorTable", typeof(Delegates.GetColorTable));
            Delegates.glGetColorTableParameterfv = (Delegates.GetColorTableParameterfv)GetExtensionDelegate("glGetColorTableParameterfv", typeof(Delegates.GetColorTableParameterfv));
            Delegates.glGetColorTableParameteriv = (Delegates.GetColorTableParameteriv)GetExtensionDelegate("glGetColorTableParameteriv", typeof(Delegates.GetColorTableParameteriv));
            Delegates.glGetCompressedTexImage = (Delegates.GetCompressedTexImage)GetExtensionDelegate("glGetCompressedTexImage", typeof(Delegates.GetCompressedTexImage));
            Delegates.glGetConvolutionFilter = (Delegates.GetConvolutionFilter)GetExtensionDelegate("glGetConvolutionFilter", typeof(Delegates.GetConvolutionFilter));
            Delegates.glGetConvolutionParameterfv = (Delegates.GetConvolutionParameterfv)GetExtensionDelegate("glGetConvolutionParameterfv", typeof(Delegates.GetConvolutionParameterfv));
            Delegates.glGetConvolutionParameteriv = (Delegates.GetConvolutionParameteriv)GetExtensionDelegate("glGetConvolutionParameteriv", typeof(Delegates.GetConvolutionParameteriv));
            Delegates.glGetDebugMessageLog = (Delegates.GetDebugMessageLog)GetExtensionDelegate("glGetDebugMessageLog", typeof(Delegates.GetDebugMessageLog));
            Delegates.glGetDebugMessageLogARB = (Delegates.GetDebugMessageLogARB)GetExtensionDelegate("glGetDebugMessageLogARB", typeof(Delegates.GetDebugMessageLogARB));
            Delegates.glGetDebugMessageLogKHR = (Delegates.GetDebugMessageLogKHR)GetExtensionDelegate("glGetDebugMessageLogKHR", typeof(Delegates.GetDebugMessageLogKHR));
            Delegates.glGetDoublei_v = (Delegates.GetDoublei_v)GetExtensionDelegate("glGetDoublei_v", typeof(Delegates.GetDoublei_v));
            Delegates.glGetDoublev = (Delegates.GetDoublev)GetExtensionDelegate("glGetDoublev", typeof(Delegates.GetDoublev));
            Delegates.glGetError = (Delegates.GetError)GetExtensionDelegate("glGetError", typeof(Delegates.GetError));
            Delegates.glGetFloati_v = (Delegates.GetFloati_v)GetExtensionDelegate("glGetFloati_v", typeof(Delegates.GetFloati_v));
            Delegates.glGetFloatv = (Delegates.GetFloatv)GetExtensionDelegate("glGetFloatv", typeof(Delegates.GetFloatv));
            Delegates.glGetFragDataIndex = (Delegates.GetFragDataIndex)GetExtensionDelegate("glGetFragDataIndex", typeof(Delegates.GetFragDataIndex));
            Delegates.glGetFragDataLocation = (Delegates.GetFragDataLocation)GetExtensionDelegate("glGetFragDataLocation", typeof(Delegates.GetFragDataLocation));
            Delegates.glGetFramebufferAttachmentParameteriv = (Delegates.GetFramebufferAttachmentParameteriv)GetExtensionDelegate("glGetFramebufferAttachmentParameteriv", typeof(Delegates.GetFramebufferAttachmentParameteriv));
            Delegates.glGetFramebufferParameteriv = (Delegates.GetFramebufferParameteriv)GetExtensionDelegate("glGetFramebufferParameteriv", typeof(Delegates.GetFramebufferParameteriv));
            Delegates.glGetGraphicsResetStatusARB = (Delegates.GetGraphicsResetStatusARB)GetExtensionDelegate("glGetGraphicsResetStatusARB", typeof(Delegates.GetGraphicsResetStatusARB));
            Delegates.glGetHistogram = (Delegates.GetHistogram)GetExtensionDelegate("glGetHistogram", typeof(Delegates.GetHistogram));
            Delegates.glGetHistogramParameterfv = (Delegates.GetHistogramParameterfv)GetExtensionDelegate("glGetHistogramParameterfv", typeof(Delegates.GetHistogramParameterfv));
            Delegates.glGetHistogramParameteriv = (Delegates.GetHistogramParameteriv)GetExtensionDelegate("glGetHistogramParameteriv", typeof(Delegates.GetHistogramParameteriv));
            Delegates.glGetImageHandleARB = (Delegates.GetImageHandleARB)GetExtensionDelegate("glGetImageHandleARB", typeof(Delegates.GetImageHandleARB));
            Delegates.glGetInteger64i_v = (Delegates.GetInteger64i_v)GetExtensionDelegate("glGetInteger64i_v", typeof(Delegates.GetInteger64i_v));
            Delegates.glGetInteger64v = (Delegates.GetInteger64v)GetExtensionDelegate("glGetInteger64v", typeof(Delegates.GetInteger64v));
            Delegates.glGetIntegeri_v = (Delegates.GetIntegeri_v)GetExtensionDelegate("glGetIntegeri_v", typeof(Delegates.GetIntegeri_v));
            Delegates.glGetIntegerv = (Delegates.GetIntegerv)GetExtensionDelegate("glGetIntegerv", typeof(Delegates.GetIntegerv));
            Delegates.glGetInternalformati64v = (Delegates.GetInternalformati64v)GetExtensionDelegate("glGetInternalformati64v", typeof(Delegates.GetInternalformati64v));
            Delegates.glGetInternalformativ = (Delegates.GetInternalformativ)GetExtensionDelegate("glGetInternalformativ", typeof(Delegates.GetInternalformativ));
            Delegates.glGetMinmax = (Delegates.GetMinmax)GetExtensionDelegate("glGetMinmax", typeof(Delegates.GetMinmax));
            Delegates.glGetMinmaxParameterfv = (Delegates.GetMinmaxParameterfv)GetExtensionDelegate("glGetMinmaxParameterfv", typeof(Delegates.GetMinmaxParameterfv));
            Delegates.glGetMinmaxParameteriv = (Delegates.GetMinmaxParameteriv)GetExtensionDelegate("glGetMinmaxParameteriv", typeof(Delegates.GetMinmaxParameteriv));
            Delegates.glGetMultisamplefv = (Delegates.GetMultisamplefv)GetExtensionDelegate("glGetMultisamplefv", typeof(Delegates.GetMultisamplefv));
            Delegates.glGetNamedStringARB = (Delegates.GetNamedStringARB)GetExtensionDelegate("glGetNamedStringARB", typeof(Delegates.GetNamedStringARB));
            Delegates.glGetNamedStringivARB = (Delegates.GetNamedStringivARB)GetExtensionDelegate("glGetNamedStringivARB", typeof(Delegates.GetNamedStringivARB));
            Delegates.glGetnColorTableARB = (Delegates.GetnColorTableARB)GetExtensionDelegate("glGetnColorTableARB", typeof(Delegates.GetnColorTableARB));
            Delegates.glGetnCompressedTexImageARB = (Delegates.GetnCompressedTexImageARB)GetExtensionDelegate("glGetnCompressedTexImageARB", typeof(Delegates.GetnCompressedTexImageARB));
            Delegates.glGetnConvolutionFilterARB = (Delegates.GetnConvolutionFilterARB)GetExtensionDelegate("glGetnConvolutionFilterARB", typeof(Delegates.GetnConvolutionFilterARB));
            Delegates.glGetnHistogramARB = (Delegates.GetnHistogramARB)GetExtensionDelegate("glGetnHistogramARB", typeof(Delegates.GetnHistogramARB));
            Delegates.glGetnMapdvARB = (Delegates.GetnMapdvARB)GetExtensionDelegate("glGetnMapdvARB", typeof(Delegates.GetnMapdvARB));
            Delegates.glGetnMapfvARB = (Delegates.GetnMapfvARB)GetExtensionDelegate("glGetnMapfvARB", typeof(Delegates.GetnMapfvARB));
            Delegates.glGetnMapivARB = (Delegates.GetnMapivARB)GetExtensionDelegate("glGetnMapivARB", typeof(Delegates.GetnMapivARB));
            Delegates.glGetnMinmaxARB = (Delegates.GetnMinmaxARB)GetExtensionDelegate("glGetnMinmaxARB", typeof(Delegates.GetnMinmaxARB));
            Delegates.glGetnPixelMapfvARB = (Delegates.GetnPixelMapfvARB)GetExtensionDelegate("glGetnPixelMapfvARB", typeof(Delegates.GetnPixelMapfvARB));
            Delegates.glGetnPixelMapuivARB = (Delegates.GetnPixelMapuivARB)GetExtensionDelegate("glGetnPixelMapuivARB", typeof(Delegates.GetnPixelMapuivARB));
            Delegates.glGetnPixelMapusvARB = (Delegates.GetnPixelMapusvARB)GetExtensionDelegate("glGetnPixelMapusvARB", typeof(Delegates.GetnPixelMapusvARB));
            Delegates.glGetnPolygonStippleARB = (Delegates.GetnPolygonStippleARB)GetExtensionDelegate("glGetnPolygonStippleARB", typeof(Delegates.GetnPolygonStippleARB));
            Delegates.glGetnSeparableFilterARB = (Delegates.GetnSeparableFilterARB)GetExtensionDelegate("glGetnSeparableFilterARB", typeof(Delegates.GetnSeparableFilterARB));
            Delegates.glGetnTexImageARB = (Delegates.GetnTexImageARB)GetExtensionDelegate("glGetnTexImageARB", typeof(Delegates.GetnTexImageARB));
            Delegates.glGetnUniformdvARB = (Delegates.GetnUniformdvARB)GetExtensionDelegate("glGetnUniformdvARB", typeof(Delegates.GetnUniformdvARB));
            Delegates.glGetnUniformfvARB = (Delegates.GetnUniformfvARB)GetExtensionDelegate("glGetnUniformfvARB", typeof(Delegates.GetnUniformfvARB));
            Delegates.glGetnUniformivARB = (Delegates.GetnUniformivARB)GetExtensionDelegate("glGetnUniformivARB", typeof(Delegates.GetnUniformivARB));
            Delegates.glGetnUniformuivARB = (Delegates.GetnUniformuivARB)GetExtensionDelegate("glGetnUniformuivARB", typeof(Delegates.GetnUniformuivARB));
            Delegates.glGetObjectLabel = (Delegates.GetObjectLabel)GetExtensionDelegate("glGetObjectLabel", typeof(Delegates.GetObjectLabel));
            Delegates.glGetObjectLabelKHR = (Delegates.GetObjectLabelKHR)GetExtensionDelegate("glGetObjectLabelKHR", typeof(Delegates.GetObjectLabelKHR));
            Delegates.glGetObjectPtrLabel = (Delegates.GetObjectPtrLabel)GetExtensionDelegate("glGetObjectPtrLabel", typeof(Delegates.GetObjectPtrLabel));
            Delegates.glGetObjectPtrLabelKHR = (Delegates.GetObjectPtrLabelKHR)GetExtensionDelegate("glGetObjectPtrLabelKHR", typeof(Delegates.GetObjectPtrLabelKHR));
            Delegates.glGetPointerv = (Delegates.GetPointerv)GetExtensionDelegate("glGetPointerv", typeof(Delegates.GetPointerv));
            Delegates.glGetPointervKHR = (Delegates.GetPointervKHR)GetExtensionDelegate("glGetPointervKHR", typeof(Delegates.GetPointervKHR));
            Delegates.glGetProgramBinary = (Delegates.GetProgramBinary)GetExtensionDelegate("glGetProgramBinary", typeof(Delegates.GetProgramBinary));
            Delegates.glGetProgramInfoLog = (Delegates.GetProgramInfoLog)GetExtensionDelegate("glGetProgramInfoLog", typeof(Delegates.GetProgramInfoLog));
            Delegates.glGetProgramInterfaceiv = (Delegates.GetProgramInterfaceiv)GetExtensionDelegate("glGetProgramInterfaceiv", typeof(Delegates.GetProgramInterfaceiv));
            Delegates.glGetProgramiv = (Delegates.GetProgramiv)GetExtensionDelegate("glGetProgramiv", typeof(Delegates.GetProgramiv));
            Delegates.glGetProgramPipelineInfoLog = (Delegates.GetProgramPipelineInfoLog)GetExtensionDelegate("glGetProgramPipelineInfoLog", typeof(Delegates.GetProgramPipelineInfoLog));
            Delegates.glGetProgramPipelineiv = (Delegates.GetProgramPipelineiv)GetExtensionDelegate("glGetProgramPipelineiv", typeof(Delegates.GetProgramPipelineiv));
            Delegates.glGetProgramResourceIndex = (Delegates.GetProgramResourceIndex)GetExtensionDelegate("glGetProgramResourceIndex", typeof(Delegates.GetProgramResourceIndex));
            Delegates.glGetProgramResourceiv = (Delegates.GetProgramResourceiv)GetExtensionDelegate("glGetProgramResourceiv", typeof(Delegates.GetProgramResourceiv));
            Delegates.glGetProgramResourceLocation = (Delegates.GetProgramResourceLocation)GetExtensionDelegate("glGetProgramResourceLocation", typeof(Delegates.GetProgramResourceLocation));
            Delegates.glGetProgramResourceLocationIndex = (Delegates.GetProgramResourceLocationIndex)GetExtensionDelegate("glGetProgramResourceLocationIndex", typeof(Delegates.GetProgramResourceLocationIndex));
            Delegates.glGetProgramResourceName = (Delegates.GetProgramResourceName)GetExtensionDelegate("glGetProgramResourceName", typeof(Delegates.GetProgramResourceName));
            Delegates.glGetProgramStageiv = (Delegates.GetProgramStageiv)GetExtensionDelegate("glGetProgramStageiv", typeof(Delegates.GetProgramStageiv));
            Delegates.glGetQueryIndexediv = (Delegates.GetQueryIndexediv)GetExtensionDelegate("glGetQueryIndexediv", typeof(Delegates.GetQueryIndexediv));
            Delegates.glGetQueryiv = (Delegates.GetQueryiv)GetExtensionDelegate("glGetQueryiv", typeof(Delegates.GetQueryiv));
            Delegates.glGetQueryObjecti64v = (Delegates.GetQueryObjecti64v)GetExtensionDelegate("glGetQueryObjecti64v", typeof(Delegates.GetQueryObjecti64v));
            Delegates.glGetQueryObjectiv = (Delegates.GetQueryObjectiv)GetExtensionDelegate("glGetQueryObjectiv", typeof(Delegates.GetQueryObjectiv));
            Delegates.glGetQueryObjectui64v = (Delegates.GetQueryObjectui64v)GetExtensionDelegate("glGetQueryObjectui64v", typeof(Delegates.GetQueryObjectui64v));
            Delegates.glGetQueryObjectuiv = (Delegates.GetQueryObjectuiv)GetExtensionDelegate("glGetQueryObjectuiv", typeof(Delegates.GetQueryObjectuiv));
            Delegates.glGetRenderbufferParameteriv = (Delegates.GetRenderbufferParameteriv)GetExtensionDelegate("glGetRenderbufferParameteriv", typeof(Delegates.GetRenderbufferParameteriv));
            Delegates.glGetSamplerParameterfv = (Delegates.GetSamplerParameterfv)GetExtensionDelegate("glGetSamplerParameterfv", typeof(Delegates.GetSamplerParameterfv));
            Delegates.glGetSamplerParameterIiv = (Delegates.GetSamplerParameterIiv)GetExtensionDelegate("glGetSamplerParameterIiv", typeof(Delegates.GetSamplerParameterIiv));
            Delegates.glGetSamplerParameterIuiv = (Delegates.GetSamplerParameterIuiv)GetExtensionDelegate("glGetSamplerParameterIuiv", typeof(Delegates.GetSamplerParameterIuiv));
            Delegates.glGetSamplerParameteriv = (Delegates.GetSamplerParameteriv)GetExtensionDelegate("glGetSamplerParameteriv", typeof(Delegates.GetSamplerParameteriv));
            Delegates.glGetSeparableFilter = (Delegates.GetSeparableFilter)GetExtensionDelegate("glGetSeparableFilter", typeof(Delegates.GetSeparableFilter));
            Delegates.glGetShaderInfoLog = (Delegates.GetShaderInfoLog)GetExtensionDelegate("glGetShaderInfoLog", typeof(Delegates.GetShaderInfoLog));
            Delegates.glGetShaderiv = (Delegates.GetShaderiv)GetExtensionDelegate("glGetShaderiv", typeof(Delegates.GetShaderiv));
            Delegates.glGetShaderPrecisionFormat = (Delegates.GetShaderPrecisionFormat)GetExtensionDelegate("glGetShaderPrecisionFormat", typeof(Delegates.GetShaderPrecisionFormat));
            Delegates.glGetShaderSource = (Delegates.GetShaderSource)GetExtensionDelegate("glGetShaderSource", typeof(Delegates.GetShaderSource));
            Delegates.glGetString = (Delegates.GetString)GetExtensionDelegate("glGetString", typeof(Delegates.GetString));
            Delegates.glGetStringi = (Delegates.GetStringi)GetExtensionDelegate("glGetStringi", typeof(Delegates.GetStringi));
            Delegates.glGetSubroutineIndex = (Delegates.GetSubroutineIndex)GetExtensionDelegate("glGetSubroutineIndex", typeof(Delegates.GetSubroutineIndex));
            Delegates.glGetSubroutineUniformLocation = (Delegates.GetSubroutineUniformLocation)GetExtensionDelegate("glGetSubroutineUniformLocation", typeof(Delegates.GetSubroutineUniformLocation));
            Delegates.glGetSynciv = (Delegates.GetSynciv)GetExtensionDelegate("glGetSynciv", typeof(Delegates.GetSynciv));
            Delegates.glGetTexImage = (Delegates.GetTexImage)GetExtensionDelegate("glGetTexImage", typeof(Delegates.GetTexImage));
            Delegates.glGetTexLevelParameterfv = (Delegates.GetTexLevelParameterfv)GetExtensionDelegate("glGetTexLevelParameterfv", typeof(Delegates.GetTexLevelParameterfv));
            Delegates.glGetTexLevelParameteriv = (Delegates.GetTexLevelParameteriv)GetExtensionDelegate("glGetTexLevelParameteriv", typeof(Delegates.GetTexLevelParameteriv));
            Delegates.glGetTexParameterfv = (Delegates.GetTexParameterfv)GetExtensionDelegate("glGetTexParameterfv", typeof(Delegates.GetTexParameterfv));
            Delegates.glGetTexParameterIiv = (Delegates.GetTexParameterIiv)GetExtensionDelegate("glGetTexParameterIiv", typeof(Delegates.GetTexParameterIiv));
            Delegates.glGetTexParameterIuiv = (Delegates.GetTexParameterIuiv)GetExtensionDelegate("glGetTexParameterIuiv", typeof(Delegates.GetTexParameterIuiv));
            Delegates.glGetTexParameteriv = (Delegates.GetTexParameteriv)GetExtensionDelegate("glGetTexParameteriv", typeof(Delegates.GetTexParameteriv));
            Delegates.glGetTextureHandleARB = (Delegates.GetTextureHandleARB)GetExtensionDelegate("glGetTextureHandleARB", typeof(Delegates.GetTextureHandleARB));
            Delegates.glGetTextureSamplerHandleARB = (Delegates.GetTextureSamplerHandleARB)GetExtensionDelegate("glGetTextureSamplerHandleARB", typeof(Delegates.GetTextureSamplerHandleARB));
            Delegates.glGetTransformFeedbackVarying = (Delegates.GetTransformFeedbackVarying)GetExtensionDelegate("glGetTransformFeedbackVarying", typeof(Delegates.GetTransformFeedbackVarying));
            Delegates.glGetUniformBlockIndex = (Delegates.GetUniformBlockIndex)GetExtensionDelegate("glGetUniformBlockIndex", typeof(Delegates.GetUniformBlockIndex));
            Delegates.glGetUniformdv = (Delegates.GetUniformdv)GetExtensionDelegate("glGetUniformdv", typeof(Delegates.GetUniformdv));
            Delegates.glGetUniformfv = (Delegates.GetUniformfv)GetExtensionDelegate("glGetUniformfv", typeof(Delegates.GetUniformfv));
            Delegates.glGetUniformIndices = (Delegates.GetUniformIndices)GetExtensionDelegate("glGetUniformIndices", typeof(Delegates.GetUniformIndices));
            Delegates.glGetUniformiv = (Delegates.GetUniformiv)GetExtensionDelegate("glGetUniformiv", typeof(Delegates.GetUniformiv));
            Delegates.glGetUniformLocation = (Delegates.GetUniformLocation)GetExtensionDelegate("glGetUniformLocation", typeof(Delegates.GetUniformLocation));
            Delegates.glGetUniformSubroutineuiv = (Delegates.GetUniformSubroutineuiv)GetExtensionDelegate("glGetUniformSubroutineuiv", typeof(Delegates.GetUniformSubroutineuiv));
            Delegates.glGetUniformuiv = (Delegates.GetUniformuiv)GetExtensionDelegate("glGetUniformuiv", typeof(Delegates.GetUniformuiv));
            Delegates.glGetVertexAttribdv = (Delegates.GetVertexAttribdv)GetExtensionDelegate("glGetVertexAttribdv", typeof(Delegates.GetVertexAttribdv));
            Delegates.glGetVertexAttribfv = (Delegates.GetVertexAttribfv)GetExtensionDelegate("glGetVertexAttribfv", typeof(Delegates.GetVertexAttribfv));
            Delegates.glGetVertexAttribIiv = (Delegates.GetVertexAttribIiv)GetExtensionDelegate("glGetVertexAttribIiv", typeof(Delegates.GetVertexAttribIiv));
            Delegates.glGetVertexAttribIuiv = (Delegates.GetVertexAttribIuiv)GetExtensionDelegate("glGetVertexAttribIuiv", typeof(Delegates.GetVertexAttribIuiv));
            Delegates.glGetVertexAttribiv = (Delegates.GetVertexAttribiv)GetExtensionDelegate("glGetVertexAttribiv", typeof(Delegates.GetVertexAttribiv));
            Delegates.glGetVertexAttribLdv = (Delegates.GetVertexAttribLdv)GetExtensionDelegate("glGetVertexAttribLdv", typeof(Delegates.GetVertexAttribLdv));
            Delegates.glGetVertexAttribLui64vARB = (Delegates.GetVertexAttribLui64vARB)GetExtensionDelegate("glGetVertexAttribLui64vARB", typeof(Delegates.GetVertexAttribLui64vARB));
            Delegates.glGetVertexAttribPointerv = (Delegates.GetVertexAttribPointerv)GetExtensionDelegate("glGetVertexAttribPointerv", typeof(Delegates.GetVertexAttribPointerv));
            Delegates.glHint = (Delegates.Hint)GetExtensionDelegate("glHint", typeof(Delegates.Hint));
            Delegates.glHistogram = (Delegates.Histogram)GetExtensionDelegate("glHistogram", typeof(Delegates.Histogram));
            Delegates.glInvalidateBufferData = (Delegates.InvalidateBufferData)GetExtensionDelegate("glInvalidateBufferData", typeof(Delegates.InvalidateBufferData));
            Delegates.glInvalidateBufferSubData = (Delegates.InvalidateBufferSubData)GetExtensionDelegate("glInvalidateBufferSubData", typeof(Delegates.InvalidateBufferSubData));
            Delegates.glInvalidateFramebuffer = (Delegates.InvalidateFramebuffer)GetExtensionDelegate("glInvalidateFramebuffer", typeof(Delegates.InvalidateFramebuffer));
            Delegates.glInvalidateSubFramebuffer = (Delegates.InvalidateSubFramebuffer)GetExtensionDelegate("glInvalidateSubFramebuffer", typeof(Delegates.InvalidateSubFramebuffer));
            Delegates.glInvalidateTexImage = (Delegates.InvalidateTexImage)GetExtensionDelegate("glInvalidateTexImage", typeof(Delegates.InvalidateTexImage));
            Delegates.glInvalidateTexSubImage = (Delegates.InvalidateTexSubImage)GetExtensionDelegate("glInvalidateTexSubImage", typeof(Delegates.InvalidateTexSubImage));
            Delegates.glIsBuffer = (Delegates.IsBuffer)GetExtensionDelegate("glIsBuffer", typeof(Delegates.IsBuffer));
            Delegates.glIsEnabled = (Delegates.IsEnabled)GetExtensionDelegate("glIsEnabled", typeof(Delegates.IsEnabled));
            Delegates.glIsEnabledi = (Delegates.IsEnabledi)GetExtensionDelegate("glIsEnabledi", typeof(Delegates.IsEnabledi));
            Delegates.glIsFramebuffer = (Delegates.IsFramebuffer)GetExtensionDelegate("glIsFramebuffer", typeof(Delegates.IsFramebuffer));
            Delegates.glIsImageHandleResidentARB = (Delegates.IsImageHandleResidentARB)GetExtensionDelegate("glIsImageHandleResidentARB", typeof(Delegates.IsImageHandleResidentARB));
            Delegates.glIsNamedStringARB = (Delegates.IsNamedStringARB)GetExtensionDelegate("glIsNamedStringARB", typeof(Delegates.IsNamedStringARB));
            Delegates.glIsProgram = (Delegates.IsProgram)GetExtensionDelegate("glIsProgram", typeof(Delegates.IsProgram));
            Delegates.glIsProgramPipeline = (Delegates.IsProgramPipeline)GetExtensionDelegate("glIsProgramPipeline", typeof(Delegates.IsProgramPipeline));
            Delegates.glIsQuery = (Delegates.IsQuery)GetExtensionDelegate("glIsQuery", typeof(Delegates.IsQuery));
            Delegates.glIsRenderbuffer = (Delegates.IsRenderbuffer)GetExtensionDelegate("glIsRenderbuffer", typeof(Delegates.IsRenderbuffer));
            Delegates.glIsSampler = (Delegates.IsSampler)GetExtensionDelegate("glIsSampler", typeof(Delegates.IsSampler));
            Delegates.glIsShader = (Delegates.IsShader)GetExtensionDelegate("glIsShader", typeof(Delegates.IsShader));
            Delegates.glIsSync = (Delegates.IsSync)GetExtensionDelegate("glIsSync", typeof(Delegates.IsSync));
            Delegates.glIsTexture = (Delegates.IsTexture)GetExtensionDelegate("glIsTexture", typeof(Delegates.IsTexture));
            Delegates.glIsTextureHandleResidentARB = (Delegates.IsTextureHandleResidentARB)GetExtensionDelegate("glIsTextureHandleResidentARB", typeof(Delegates.IsTextureHandleResidentARB));
            Delegates.glIsTransformFeedback = (Delegates.IsTransformFeedback)GetExtensionDelegate("glIsTransformFeedback", typeof(Delegates.IsTransformFeedback));
            Delegates.glIsVertexArray = (Delegates.IsVertexArray)GetExtensionDelegate("glIsVertexArray", typeof(Delegates.IsVertexArray));
            Delegates.glLineWidth = (Delegates.LineWidth)GetExtensionDelegate("glLineWidth", typeof(Delegates.LineWidth));
            Delegates.glLinkProgram = (Delegates.LinkProgram)GetExtensionDelegate("glLinkProgram", typeof(Delegates.LinkProgram));
            Delegates.glLogicOp = (Delegates.LogicOp)GetExtensionDelegate("glLogicOp", typeof(Delegates.LogicOp));
            Delegates.glMakeImageHandleNonResidentARB = (Delegates.MakeImageHandleNonResidentARB)GetExtensionDelegate("glMakeImageHandleNonResidentARB", typeof(Delegates.MakeImageHandleNonResidentARB));
            Delegates.glMakeImageHandleResidentARB = (Delegates.MakeImageHandleResidentARB)GetExtensionDelegate("glMakeImageHandleResidentARB", typeof(Delegates.MakeImageHandleResidentARB));
            Delegates.glMakeTextureHandleNonResidentARB = (Delegates.MakeTextureHandleNonResidentARB)GetExtensionDelegate("glMakeTextureHandleNonResidentARB", typeof(Delegates.MakeTextureHandleNonResidentARB));
            Delegates.glMakeTextureHandleResidentARB = (Delegates.MakeTextureHandleResidentARB)GetExtensionDelegate("glMakeTextureHandleResidentARB", typeof(Delegates.MakeTextureHandleResidentARB));
            Delegates.glMapBuffer = (Delegates.MapBuffer)GetExtensionDelegate("glMapBuffer", typeof(Delegates.MapBuffer));
            Delegates.glMapBufferRange = (Delegates.MapBufferRange)GetExtensionDelegate("glMapBufferRange", typeof(Delegates.MapBufferRange));
            Delegates.glMemoryBarrier = (Delegates.MemoryBarrier)GetExtensionDelegate("glMemoryBarrier", typeof(Delegates.MemoryBarrier));
            Delegates.glMinmax = (Delegates.Minmax)GetExtensionDelegate("glMinmax", typeof(Delegates.Minmax));
            Delegates.glMinSampleShading = (Delegates.MinSampleShading)GetExtensionDelegate("glMinSampleShading", typeof(Delegates.MinSampleShading));
            Delegates.glMinSampleShadingARB = (Delegates.MinSampleShadingARB)GetExtensionDelegate("glMinSampleShadingARB", typeof(Delegates.MinSampleShadingARB));
            Delegates.glMultiDrawArrays = (Delegates.MultiDrawArrays)GetExtensionDelegate("glMultiDrawArrays", typeof(Delegates.MultiDrawArrays));
            Delegates.glMultiDrawArraysIndirect = (Delegates.MultiDrawArraysIndirect)GetExtensionDelegate("glMultiDrawArraysIndirect", typeof(Delegates.MultiDrawArraysIndirect));
            Delegates.glMultiDrawArraysIndirectCountARB = (Delegates.MultiDrawArraysIndirectCountARB)GetExtensionDelegate("glMultiDrawArraysIndirectCountARB", typeof(Delegates.MultiDrawArraysIndirectCountARB));
            Delegates.glMultiDrawElements = (Delegates.MultiDrawElements)GetExtensionDelegate("glMultiDrawElements", typeof(Delegates.MultiDrawElements));
            Delegates.glMultiDrawElementsBaseVertex = (Delegates.MultiDrawElementsBaseVertex)GetExtensionDelegate("glMultiDrawElementsBaseVertex", typeof(Delegates.MultiDrawElementsBaseVertex));
            Delegates.glMultiDrawElementsIndirect = (Delegates.MultiDrawElementsIndirect)GetExtensionDelegate("glMultiDrawElementsIndirect", typeof(Delegates.MultiDrawElementsIndirect));
            Delegates.glMultiDrawElementsIndirectCountARB = (Delegates.MultiDrawElementsIndirectCountARB)GetExtensionDelegate("glMultiDrawElementsIndirectCountARB", typeof(Delegates.MultiDrawElementsIndirectCountARB));
            Delegates.glMultiTexCoordP1ui = (Delegates.MultiTexCoordP1ui)GetExtensionDelegate("glMultiTexCoordP1ui", typeof(Delegates.MultiTexCoordP1ui));
            Delegates.glMultiTexCoordP1uiv = (Delegates.MultiTexCoordP1uiv)GetExtensionDelegate("glMultiTexCoordP1uiv", typeof(Delegates.MultiTexCoordP1uiv));
            Delegates.glMultiTexCoordP2ui = (Delegates.MultiTexCoordP2ui)GetExtensionDelegate("glMultiTexCoordP2ui", typeof(Delegates.MultiTexCoordP2ui));
            Delegates.glMultiTexCoordP2uiv = (Delegates.MultiTexCoordP2uiv)GetExtensionDelegate("glMultiTexCoordP2uiv", typeof(Delegates.MultiTexCoordP2uiv));
            Delegates.glMultiTexCoordP3ui = (Delegates.MultiTexCoordP3ui)GetExtensionDelegate("glMultiTexCoordP3ui", typeof(Delegates.MultiTexCoordP3ui));
            Delegates.glMultiTexCoordP3uiv = (Delegates.MultiTexCoordP3uiv)GetExtensionDelegate("glMultiTexCoordP3uiv", typeof(Delegates.MultiTexCoordP3uiv));
            Delegates.glMultiTexCoordP4ui = (Delegates.MultiTexCoordP4ui)GetExtensionDelegate("glMultiTexCoordP4ui", typeof(Delegates.MultiTexCoordP4ui));
            Delegates.glMultiTexCoordP4uiv = (Delegates.MultiTexCoordP4uiv)GetExtensionDelegate("glMultiTexCoordP4uiv", typeof(Delegates.MultiTexCoordP4uiv));
            Delegates.glNamedStringARB = (Delegates.NamedStringARB)GetExtensionDelegate("glNamedStringARB", typeof(Delegates.NamedStringARB));
            Delegates.glNormalP3ui = (Delegates.NormalP3ui)GetExtensionDelegate("glNormalP3ui", typeof(Delegates.NormalP3ui));
            Delegates.glNormalP3uiv = (Delegates.NormalP3uiv)GetExtensionDelegate("glNormalP3uiv", typeof(Delegates.NormalP3uiv));
            Delegates.glObjectLabel = (Delegates.ObjectLabel)GetExtensionDelegate("glObjectLabel", typeof(Delegates.ObjectLabel));
            Delegates.glObjectLabelKHR = (Delegates.ObjectLabelKHR)GetExtensionDelegate("glObjectLabelKHR", typeof(Delegates.ObjectLabelKHR));
            Delegates.glObjectPtrLabel = (Delegates.ObjectPtrLabel)GetExtensionDelegate("glObjectPtrLabel", typeof(Delegates.ObjectPtrLabel));
            Delegates.glObjectPtrLabelKHR = (Delegates.ObjectPtrLabelKHR)GetExtensionDelegate("glObjectPtrLabelKHR", typeof(Delegates.ObjectPtrLabelKHR));
            Delegates.glPatchParameterfv = (Delegates.PatchParameterfv)GetExtensionDelegate("glPatchParameterfv", typeof(Delegates.PatchParameterfv));
            Delegates.glPatchParameteri = (Delegates.PatchParameteri)GetExtensionDelegate("glPatchParameteri", typeof(Delegates.PatchParameteri));
            Delegates.glPauseTransformFeedback = (Delegates.PauseTransformFeedback)GetExtensionDelegate("glPauseTransformFeedback", typeof(Delegates.PauseTransformFeedback));
            Delegates.glPixelStoref = (Delegates.PixelStoref)GetExtensionDelegate("glPixelStoref", typeof(Delegates.PixelStoref));
            Delegates.glPixelStorei = (Delegates.PixelStorei)GetExtensionDelegate("glPixelStorei", typeof(Delegates.PixelStorei));
            Delegates.glPointParameterf = (Delegates.PointParameterf)GetExtensionDelegate("glPointParameterf", typeof(Delegates.PointParameterf));
            Delegates.glPointParameterfv = (Delegates.PointParameterfv)GetExtensionDelegate("glPointParameterfv", typeof(Delegates.PointParameterfv));
            Delegates.glPointParameteri = (Delegates.PointParameteri)GetExtensionDelegate("glPointParameteri", typeof(Delegates.PointParameteri));
            Delegates.glPointParameteriv = (Delegates.PointParameteriv)GetExtensionDelegate("glPointParameteriv", typeof(Delegates.PointParameteriv));
            Delegates.glPointSize = (Delegates.PointSize)GetExtensionDelegate("glPointSize", typeof(Delegates.PointSize));
            Delegates.glPolygonMode = (Delegates.PolygonMode)GetExtensionDelegate("glPolygonMode", typeof(Delegates.PolygonMode));
            Delegates.glPolygonOffset = (Delegates.PolygonOffset)GetExtensionDelegate("glPolygonOffset", typeof(Delegates.PolygonOffset));
            Delegates.glPopDebugGroup = (Delegates.PopDebugGroup)GetExtensionDelegate("glPopDebugGroup", typeof(Delegates.PopDebugGroup));
            Delegates.glPopDebugGroupKHR = (Delegates.PopDebugGroupKHR)GetExtensionDelegate("glPopDebugGroupKHR", typeof(Delegates.PopDebugGroupKHR));
            Delegates.glPrimitiveRestartIndex = (Delegates.PrimitiveRestartIndex)GetExtensionDelegate("glPrimitiveRestartIndex", typeof(Delegates.PrimitiveRestartIndex));
            Delegates.glProgramBinary = (Delegates.ProgramBinary)GetExtensionDelegate("glProgramBinary", typeof(Delegates.ProgramBinary));
            Delegates.glProgramParameteri = (Delegates.ProgramParameteri)GetExtensionDelegate("glProgramParameteri", typeof(Delegates.ProgramParameteri));
            Delegates.glProgramUniform1d = (Delegates.ProgramUniform1d)GetExtensionDelegate("glProgramUniform1d", typeof(Delegates.ProgramUniform1d));
            Delegates.glProgramUniform1dv = (Delegates.ProgramUniform1dv)GetExtensionDelegate("glProgramUniform1dv", typeof(Delegates.ProgramUniform1dv));
            Delegates.glProgramUniform1f = (Delegates.ProgramUniform1f)GetExtensionDelegate("glProgramUniform1f", typeof(Delegates.ProgramUniform1f));
            Delegates.glProgramUniform1fv = (Delegates.ProgramUniform1fv)GetExtensionDelegate("glProgramUniform1fv", typeof(Delegates.ProgramUniform1fv));
            Delegates.glProgramUniform1i = (Delegates.ProgramUniform1i)GetExtensionDelegate("glProgramUniform1i", typeof(Delegates.ProgramUniform1i));
            Delegates.glProgramUniform1iv = (Delegates.ProgramUniform1iv)GetExtensionDelegate("glProgramUniform1iv", typeof(Delegates.ProgramUniform1iv));
            Delegates.glProgramUniform1ui = (Delegates.ProgramUniform1ui)GetExtensionDelegate("glProgramUniform1ui", typeof(Delegates.ProgramUniform1ui));
            Delegates.glProgramUniform1uiv = (Delegates.ProgramUniform1uiv)GetExtensionDelegate("glProgramUniform1uiv", typeof(Delegates.ProgramUniform1uiv));
            Delegates.glProgramUniform2d = (Delegates.ProgramUniform2d)GetExtensionDelegate("glProgramUniform2d", typeof(Delegates.ProgramUniform2d));
            Delegates.glProgramUniform2dv = (Delegates.ProgramUniform2dv)GetExtensionDelegate("glProgramUniform2dv", typeof(Delegates.ProgramUniform2dv));
            Delegates.glProgramUniform2f = (Delegates.ProgramUniform2f)GetExtensionDelegate("glProgramUniform2f", typeof(Delegates.ProgramUniform2f));
            Delegates.glProgramUniform2fv = (Delegates.ProgramUniform2fv)GetExtensionDelegate("glProgramUniform2fv", typeof(Delegates.ProgramUniform2fv));
            Delegates.glProgramUniform2i = (Delegates.ProgramUniform2i)GetExtensionDelegate("glProgramUniform2i", typeof(Delegates.ProgramUniform2i));
            Delegates.glProgramUniform2iv = (Delegates.ProgramUniform2iv)GetExtensionDelegate("glProgramUniform2iv", typeof(Delegates.ProgramUniform2iv));
            Delegates.glProgramUniform2ui = (Delegates.ProgramUniform2ui)GetExtensionDelegate("glProgramUniform2ui", typeof(Delegates.ProgramUniform2ui));
            Delegates.glProgramUniform2uiv = (Delegates.ProgramUniform2uiv)GetExtensionDelegate("glProgramUniform2uiv", typeof(Delegates.ProgramUniform2uiv));
            Delegates.glProgramUniform3d = (Delegates.ProgramUniform3d)GetExtensionDelegate("glProgramUniform3d", typeof(Delegates.ProgramUniform3d));
            Delegates.glProgramUniform3dv = (Delegates.ProgramUniform3dv)GetExtensionDelegate("glProgramUniform3dv", typeof(Delegates.ProgramUniform3dv));
            Delegates.glProgramUniform3f = (Delegates.ProgramUniform3f)GetExtensionDelegate("glProgramUniform3f", typeof(Delegates.ProgramUniform3f));
            Delegates.glProgramUniform3fv = (Delegates.ProgramUniform3fv)GetExtensionDelegate("glProgramUniform3fv", typeof(Delegates.ProgramUniform3fv));
            Delegates.glProgramUniform3i = (Delegates.ProgramUniform3i)GetExtensionDelegate("glProgramUniform3i", typeof(Delegates.ProgramUniform3i));
            Delegates.glProgramUniform3iv = (Delegates.ProgramUniform3iv)GetExtensionDelegate("glProgramUniform3iv", typeof(Delegates.ProgramUniform3iv));
            Delegates.glProgramUniform3ui = (Delegates.ProgramUniform3ui)GetExtensionDelegate("glProgramUniform3ui", typeof(Delegates.ProgramUniform3ui));
            Delegates.glProgramUniform3uiv = (Delegates.ProgramUniform3uiv)GetExtensionDelegate("glProgramUniform3uiv", typeof(Delegates.ProgramUniform3uiv));
            Delegates.glProgramUniform4d = (Delegates.ProgramUniform4d)GetExtensionDelegate("glProgramUniform4d", typeof(Delegates.ProgramUniform4d));
            Delegates.glProgramUniform4dv = (Delegates.ProgramUniform4dv)GetExtensionDelegate("glProgramUniform4dv", typeof(Delegates.ProgramUniform4dv));
            Delegates.glProgramUniform4f = (Delegates.ProgramUniform4f)GetExtensionDelegate("glProgramUniform4f", typeof(Delegates.ProgramUniform4f));
            Delegates.glProgramUniform4fv = (Delegates.ProgramUniform4fv)GetExtensionDelegate("glProgramUniform4fv", typeof(Delegates.ProgramUniform4fv));
            Delegates.glProgramUniform4i = (Delegates.ProgramUniform4i)GetExtensionDelegate("glProgramUniform4i", typeof(Delegates.ProgramUniform4i));
            Delegates.glProgramUniform4iv = (Delegates.ProgramUniform4iv)GetExtensionDelegate("glProgramUniform4iv", typeof(Delegates.ProgramUniform4iv));
            Delegates.glProgramUniform4ui = (Delegates.ProgramUniform4ui)GetExtensionDelegate("glProgramUniform4ui", typeof(Delegates.ProgramUniform4ui));
            Delegates.glProgramUniform4uiv = (Delegates.ProgramUniform4uiv)GetExtensionDelegate("glProgramUniform4uiv", typeof(Delegates.ProgramUniform4uiv));
            Delegates.glProgramUniformHandleui64ARB = (Delegates.ProgramUniformHandleui64ARB)GetExtensionDelegate("glProgramUniformHandleui64ARB", typeof(Delegates.ProgramUniformHandleui64ARB));
            Delegates.glProgramUniformHandleui64vARB = (Delegates.ProgramUniformHandleui64vARB)GetExtensionDelegate("glProgramUniformHandleui64vARB", typeof(Delegates.ProgramUniformHandleui64vARB));
            Delegates.glProgramUniformMatrix2dv = (Delegates.ProgramUniformMatrix2dv)GetExtensionDelegate("glProgramUniformMatrix2dv", typeof(Delegates.ProgramUniformMatrix2dv));
            Delegates.glProgramUniformMatrix2fv = (Delegates.ProgramUniformMatrix2fv)GetExtensionDelegate("glProgramUniformMatrix2fv", typeof(Delegates.ProgramUniformMatrix2fv));
            Delegates.glProgramUniformMatrix2x3dv = (Delegates.ProgramUniformMatrix2x3dv)GetExtensionDelegate("glProgramUniformMatrix2x3dv", typeof(Delegates.ProgramUniformMatrix2x3dv));
            Delegates.glProgramUniformMatrix2x3fv = (Delegates.ProgramUniformMatrix2x3fv)GetExtensionDelegate("glProgramUniformMatrix2x3fv", typeof(Delegates.ProgramUniformMatrix2x3fv));
            Delegates.glProgramUniformMatrix2x4dv = (Delegates.ProgramUniformMatrix2x4dv)GetExtensionDelegate("glProgramUniformMatrix2x4dv", typeof(Delegates.ProgramUniformMatrix2x4dv));
            Delegates.glProgramUniformMatrix2x4fv = (Delegates.ProgramUniformMatrix2x4fv)GetExtensionDelegate("glProgramUniformMatrix2x4fv", typeof(Delegates.ProgramUniformMatrix2x4fv));
            Delegates.glProgramUniformMatrix3dv = (Delegates.ProgramUniformMatrix3dv)GetExtensionDelegate("glProgramUniformMatrix3dv", typeof(Delegates.ProgramUniformMatrix3dv));
            Delegates.glProgramUniformMatrix3fv = (Delegates.ProgramUniformMatrix3fv)GetExtensionDelegate("glProgramUniformMatrix3fv", typeof(Delegates.ProgramUniformMatrix3fv));
            Delegates.glProgramUniformMatrix3x2dv = (Delegates.ProgramUniformMatrix3x2dv)GetExtensionDelegate("glProgramUniformMatrix3x2dv", typeof(Delegates.ProgramUniformMatrix3x2dv));
            Delegates.glProgramUniformMatrix3x2fv = (Delegates.ProgramUniformMatrix3x2fv)GetExtensionDelegate("glProgramUniformMatrix3x2fv", typeof(Delegates.ProgramUniformMatrix3x2fv));
            Delegates.glProgramUniformMatrix3x4dv = (Delegates.ProgramUniformMatrix3x4dv)GetExtensionDelegate("glProgramUniformMatrix3x4dv", typeof(Delegates.ProgramUniformMatrix3x4dv));
            Delegates.glProgramUniformMatrix3x4fv = (Delegates.ProgramUniformMatrix3x4fv)GetExtensionDelegate("glProgramUniformMatrix3x4fv", typeof(Delegates.ProgramUniformMatrix3x4fv));
            Delegates.glProgramUniformMatrix4dv = (Delegates.ProgramUniformMatrix4dv)GetExtensionDelegate("glProgramUniformMatrix4dv", typeof(Delegates.ProgramUniformMatrix4dv));
            Delegates.glProgramUniformMatrix4fv = (Delegates.ProgramUniformMatrix4fv)GetExtensionDelegate("glProgramUniformMatrix4fv", typeof(Delegates.ProgramUniformMatrix4fv));
            Delegates.glProgramUniformMatrix4x2dv = (Delegates.ProgramUniformMatrix4x2dv)GetExtensionDelegate("glProgramUniformMatrix4x2dv", typeof(Delegates.ProgramUniformMatrix4x2dv));
            Delegates.glProgramUniformMatrix4x2fv = (Delegates.ProgramUniformMatrix4x2fv)GetExtensionDelegate("glProgramUniformMatrix4x2fv", typeof(Delegates.ProgramUniformMatrix4x2fv));
            Delegates.glProgramUniformMatrix4x3dv = (Delegates.ProgramUniformMatrix4x3dv)GetExtensionDelegate("glProgramUniformMatrix4x3dv", typeof(Delegates.ProgramUniformMatrix4x3dv));
            Delegates.glProgramUniformMatrix4x3fv = (Delegates.ProgramUniformMatrix4x3fv)GetExtensionDelegate("glProgramUniformMatrix4x3fv", typeof(Delegates.ProgramUniformMatrix4x3fv));
            Delegates.glProvokingVertex = (Delegates.ProvokingVertex)GetExtensionDelegate("glProvokingVertex", typeof(Delegates.ProvokingVertex));
            Delegates.glPushDebugGroup = (Delegates.PushDebugGroup)GetExtensionDelegate("glPushDebugGroup", typeof(Delegates.PushDebugGroup));
            Delegates.glPushDebugGroupKHR = (Delegates.PushDebugGroupKHR)GetExtensionDelegate("glPushDebugGroupKHR", typeof(Delegates.PushDebugGroupKHR));
            Delegates.glQueryCounter = (Delegates.QueryCounter)GetExtensionDelegate("glQueryCounter", typeof(Delegates.QueryCounter));
            Delegates.glReadBuffer = (Delegates.ReadBuffer)GetExtensionDelegate("glReadBuffer", typeof(Delegates.ReadBuffer));
            Delegates.glReadnPixelsARB = (Delegates.ReadnPixelsARB)GetExtensionDelegate("glReadnPixelsARB", typeof(Delegates.ReadnPixelsARB));
            Delegates.glReadPixels = (Delegates.ReadPixels)GetExtensionDelegate("glReadPixels", typeof(Delegates.ReadPixels));
            Delegates.glReleaseShaderCompiler = (Delegates.ReleaseShaderCompiler)GetExtensionDelegate("glReleaseShaderCompiler", typeof(Delegates.ReleaseShaderCompiler));
            Delegates.glRenderbufferStorage = (Delegates.RenderbufferStorage)GetExtensionDelegate("glRenderbufferStorage", typeof(Delegates.RenderbufferStorage));
            Delegates.glRenderbufferStorageMultisample = (Delegates.RenderbufferStorageMultisample)GetExtensionDelegate("glRenderbufferStorageMultisample", typeof(Delegates.RenderbufferStorageMultisample));
            Delegates.glResetHistogram = (Delegates.ResetHistogram)GetExtensionDelegate("glResetHistogram", typeof(Delegates.ResetHistogram));
            Delegates.glResetMinmax = (Delegates.ResetMinmax)GetExtensionDelegate("glResetMinmax", typeof(Delegates.ResetMinmax));
            Delegates.glResumeTransformFeedback = (Delegates.ResumeTransformFeedback)GetExtensionDelegate("glResumeTransformFeedback", typeof(Delegates.ResumeTransformFeedback));
            Delegates.glSampleCoverage = (Delegates.SampleCoverage)GetExtensionDelegate("glSampleCoverage", typeof(Delegates.SampleCoverage));
            Delegates.glSampleMaski = (Delegates.SampleMaski)GetExtensionDelegate("glSampleMaski", typeof(Delegates.SampleMaski));
            Delegates.glSamplerParameterf = (Delegates.SamplerParameterf)GetExtensionDelegate("glSamplerParameterf", typeof(Delegates.SamplerParameterf));
            Delegates.glSamplerParameterfv = (Delegates.SamplerParameterfv)GetExtensionDelegate("glSamplerParameterfv", typeof(Delegates.SamplerParameterfv));
            Delegates.glSamplerParameteri = (Delegates.SamplerParameteri)GetExtensionDelegate("glSamplerParameteri", typeof(Delegates.SamplerParameteri));
            Delegates.glSamplerParameterIiv = (Delegates.SamplerParameterIiv)GetExtensionDelegate("glSamplerParameterIiv", typeof(Delegates.SamplerParameterIiv));
            Delegates.glSamplerParameterIuiv = (Delegates.SamplerParameterIuiv)GetExtensionDelegate("glSamplerParameterIuiv", typeof(Delegates.SamplerParameterIuiv));
            Delegates.glSamplerParameteriv = (Delegates.SamplerParameteriv)GetExtensionDelegate("glSamplerParameteriv", typeof(Delegates.SamplerParameteriv));
            Delegates.glScissor = (Delegates.Scissor)GetExtensionDelegate("glScissor", typeof(Delegates.Scissor));
            Delegates.glScissorArrayv = (Delegates.ScissorArrayv)GetExtensionDelegate("glScissorArrayv", typeof(Delegates.ScissorArrayv));
            Delegates.glScissorIndexed = (Delegates.ScissorIndexed)GetExtensionDelegate("glScissorIndexed", typeof(Delegates.ScissorIndexed));
            Delegates.glScissorIndexedv = (Delegates.ScissorIndexedv)GetExtensionDelegate("glScissorIndexedv", typeof(Delegates.ScissorIndexedv));
            Delegates.glSecondaryColorP3ui = (Delegates.SecondaryColorP3ui)GetExtensionDelegate("glSecondaryColorP3ui", typeof(Delegates.SecondaryColorP3ui));
            Delegates.glSecondaryColorP3uiv = (Delegates.SecondaryColorP3uiv)GetExtensionDelegate("glSecondaryColorP3uiv", typeof(Delegates.SecondaryColorP3uiv));
            Delegates.glSeparableFilter2D = (Delegates.SeparableFilter2D)GetExtensionDelegate("glSeparableFilter2D", typeof(Delegates.SeparableFilter2D));
            Delegates.glShaderBinary = (Delegates.ShaderBinary)GetExtensionDelegate("glShaderBinary", typeof(Delegates.ShaderBinary));
            Delegates.glShaderSource = (Delegates.ShaderSource)GetExtensionDelegate("glShaderSource", typeof(Delegates.ShaderSource));
            Delegates.glShaderStorageBlockBinding = (Delegates.ShaderStorageBlockBinding)GetExtensionDelegate("glShaderStorageBlockBinding", typeof(Delegates.ShaderStorageBlockBinding));
            Delegates.glStencilFunc = (Delegates.StencilFunc)GetExtensionDelegate("glStencilFunc", typeof(Delegates.StencilFunc));
            Delegates.glStencilFuncSeparate = (Delegates.StencilFuncSeparate)GetExtensionDelegate("glStencilFuncSeparate", typeof(Delegates.StencilFuncSeparate));
            Delegates.glStencilMask = (Delegates.StencilMask)GetExtensionDelegate("glStencilMask", typeof(Delegates.StencilMask));
            Delegates.glStencilMaskSeparate = (Delegates.StencilMaskSeparate)GetExtensionDelegate("glStencilMaskSeparate", typeof(Delegates.StencilMaskSeparate));
            Delegates.glStencilOp = (Delegates.StencilOp)GetExtensionDelegate("glStencilOp", typeof(Delegates.StencilOp));
            Delegates.glStencilOpSeparate = (Delegates.StencilOpSeparate)GetExtensionDelegate("glStencilOpSeparate", typeof(Delegates.StencilOpSeparate));
            Delegates.glTexBuffer = (Delegates.TexBuffer)GetExtensionDelegate("glTexBuffer", typeof(Delegates.TexBuffer));
            Delegates.glTexBufferRange = (Delegates.TexBufferRange)GetExtensionDelegate("glTexBufferRange", typeof(Delegates.TexBufferRange));
            Delegates.glTexCoordP1ui = (Delegates.TexCoordP1ui)GetExtensionDelegate("glTexCoordP1ui", typeof(Delegates.TexCoordP1ui));
            Delegates.glTexCoordP1uiv = (Delegates.TexCoordP1uiv)GetExtensionDelegate("glTexCoordP1uiv", typeof(Delegates.TexCoordP1uiv));
            Delegates.glTexCoordP2ui = (Delegates.TexCoordP2ui)GetExtensionDelegate("glTexCoordP2ui", typeof(Delegates.TexCoordP2ui));
            Delegates.glTexCoordP2uiv = (Delegates.TexCoordP2uiv)GetExtensionDelegate("glTexCoordP2uiv", typeof(Delegates.TexCoordP2uiv));
            Delegates.glTexCoordP3ui = (Delegates.TexCoordP3ui)GetExtensionDelegate("glTexCoordP3ui", typeof(Delegates.TexCoordP3ui));
            Delegates.glTexCoordP3uiv = (Delegates.TexCoordP3uiv)GetExtensionDelegate("glTexCoordP3uiv", typeof(Delegates.TexCoordP3uiv));
            Delegates.glTexCoordP4ui = (Delegates.TexCoordP4ui)GetExtensionDelegate("glTexCoordP4ui", typeof(Delegates.TexCoordP4ui));
            Delegates.glTexCoordP4uiv = (Delegates.TexCoordP4uiv)GetExtensionDelegate("glTexCoordP4uiv", typeof(Delegates.TexCoordP4uiv));
            Delegates.glTexImage1D = (Delegates.TexImage1D)GetExtensionDelegate("glTexImage1D", typeof(Delegates.TexImage1D));
            Delegates.glTexImage2D = (Delegates.TexImage2D)GetExtensionDelegate("glTexImage2D", typeof(Delegates.TexImage2D));
            Delegates.glTexImage2DMultisample = (Delegates.TexImage2DMultisample)GetExtensionDelegate("glTexImage2DMultisample", typeof(Delegates.TexImage2DMultisample));
            Delegates.glTexImage3D = (Delegates.TexImage3D)GetExtensionDelegate("glTexImage3D", typeof(Delegates.TexImage3D));
            Delegates.glTexImage3DMultisample = (Delegates.TexImage3DMultisample)GetExtensionDelegate("glTexImage3DMultisample", typeof(Delegates.TexImage3DMultisample));
            Delegates.glTexPageCommitmentARB = (Delegates.TexPageCommitmentARB)GetExtensionDelegate("glTexPageCommitmentARB", typeof(Delegates.TexPageCommitmentARB));
            Delegates.glTexParameterf = (Delegates.TexParameterf)GetExtensionDelegate("glTexParameterf", typeof(Delegates.TexParameterf));
            Delegates.glTexParameterfv = (Delegates.TexParameterfv)GetExtensionDelegate("glTexParameterfv", typeof(Delegates.TexParameterfv));
            Delegates.glTexParameteri = (Delegates.TexParameteri)GetExtensionDelegate("glTexParameteri", typeof(Delegates.TexParameteri));
            Delegates.glTexParameterIiv = (Delegates.TexParameterIiv)GetExtensionDelegate("glTexParameterIiv", typeof(Delegates.TexParameterIiv));
            Delegates.glTexParameterIuiv = (Delegates.TexParameterIuiv)GetExtensionDelegate("glTexParameterIuiv", typeof(Delegates.TexParameterIuiv));
            Delegates.glTexParameteriv = (Delegates.TexParameteriv)GetExtensionDelegate("glTexParameteriv", typeof(Delegates.TexParameteriv));
            Delegates.glTexStorage1D = (Delegates.TexStorage1D)GetExtensionDelegate("glTexStorage1D", typeof(Delegates.TexStorage1D));
            Delegates.glTexStorage2D = (Delegates.TexStorage2D)GetExtensionDelegate("glTexStorage2D", typeof(Delegates.TexStorage2D));
            Delegates.glTexStorage2DMultisample = (Delegates.TexStorage2DMultisample)GetExtensionDelegate("glTexStorage2DMultisample", typeof(Delegates.TexStorage2DMultisample));
            Delegates.glTexStorage3D = (Delegates.TexStorage3D)GetExtensionDelegate("glTexStorage3D", typeof(Delegates.TexStorage3D));
            Delegates.glTexStorage3DMultisample = (Delegates.TexStorage3DMultisample)GetExtensionDelegate("glTexStorage3DMultisample", typeof(Delegates.TexStorage3DMultisample));
            Delegates.glTexSubImage1D = (Delegates.TexSubImage1D)GetExtensionDelegate("glTexSubImage1D", typeof(Delegates.TexSubImage1D));
            Delegates.glTexSubImage2D = (Delegates.TexSubImage2D)GetExtensionDelegate("glTexSubImage2D", typeof(Delegates.TexSubImage2D));
            Delegates.glTexSubImage3D = (Delegates.TexSubImage3D)GetExtensionDelegate("glTexSubImage3D", typeof(Delegates.TexSubImage3D));
            Delegates.glTextureView = (Delegates.TextureView)GetExtensionDelegate("glTextureView", typeof(Delegates.TextureView));
            Delegates.glTransformFeedbackVaryings = (Delegates.TransformFeedbackVaryings)GetExtensionDelegate("glTransformFeedbackVaryings", typeof(Delegates.TransformFeedbackVaryings));
            Delegates.glUniform1d = (Delegates.Uniform1d)GetExtensionDelegate("glUniform1d", typeof(Delegates.Uniform1d));
            Delegates.glUniform1dv = (Delegates.Uniform1dv)GetExtensionDelegate("glUniform1dv", typeof(Delegates.Uniform1dv));
            Delegates.glUniform1f = (Delegates.Uniform1f)GetExtensionDelegate("glUniform1f", typeof(Delegates.Uniform1f));
            Delegates.glUniform1fv = (Delegates.Uniform1fv)GetExtensionDelegate("glUniform1fv", typeof(Delegates.Uniform1fv));
            Delegates.glUniform1i = (Delegates.Uniform1i)GetExtensionDelegate("glUniform1i", typeof(Delegates.Uniform1i));
            Delegates.glUniform1iv = (Delegates.Uniform1iv)GetExtensionDelegate("glUniform1iv", typeof(Delegates.Uniform1iv));
            Delegates.glUniform1ui = (Delegates.Uniform1ui)GetExtensionDelegate("glUniform1ui", typeof(Delegates.Uniform1ui));
            Delegates.glUniform1uiv = (Delegates.Uniform1uiv)GetExtensionDelegate("glUniform1uiv", typeof(Delegates.Uniform1uiv));
            Delegates.glUniform2d = (Delegates.Uniform2d)GetExtensionDelegate("glUniform2d", typeof(Delegates.Uniform2d));
            Delegates.glUniform2dv = (Delegates.Uniform2dv)GetExtensionDelegate("glUniform2dv", typeof(Delegates.Uniform2dv));
            Delegates.glUniform2f = (Delegates.Uniform2f)GetExtensionDelegate("glUniform2f", typeof(Delegates.Uniform2f));
            Delegates.glUniform2fv = (Delegates.Uniform2fv)GetExtensionDelegate("glUniform2fv", typeof(Delegates.Uniform2fv));
            Delegates.glUniform2i = (Delegates.Uniform2i)GetExtensionDelegate("glUniform2i", typeof(Delegates.Uniform2i));
            Delegates.glUniform2iv = (Delegates.Uniform2iv)GetExtensionDelegate("glUniform2iv", typeof(Delegates.Uniform2iv));
            Delegates.glUniform2ui = (Delegates.Uniform2ui)GetExtensionDelegate("glUniform2ui", typeof(Delegates.Uniform2ui));
            Delegates.glUniform2uiv = (Delegates.Uniform2uiv)GetExtensionDelegate("glUniform2uiv", typeof(Delegates.Uniform2uiv));
            Delegates.glUniform3d = (Delegates.Uniform3d)GetExtensionDelegate("glUniform3d", typeof(Delegates.Uniform3d));
            Delegates.glUniform3dv = (Delegates.Uniform3dv)GetExtensionDelegate("glUniform3dv", typeof(Delegates.Uniform3dv));
            Delegates.glUniform3f = (Delegates.Uniform3f)GetExtensionDelegate("glUniform3f", typeof(Delegates.Uniform3f));
            Delegates.glUniform3fv = (Delegates.Uniform3fv)GetExtensionDelegate("glUniform3fv", typeof(Delegates.Uniform3fv));
            Delegates.glUniform3i = (Delegates.Uniform3i)GetExtensionDelegate("glUniform3i", typeof(Delegates.Uniform3i));
            Delegates.glUniform3iv = (Delegates.Uniform3iv)GetExtensionDelegate("glUniform3iv", typeof(Delegates.Uniform3iv));
            Delegates.glUniform3ui = (Delegates.Uniform3ui)GetExtensionDelegate("glUniform3ui", typeof(Delegates.Uniform3ui));
            Delegates.glUniform3uiv = (Delegates.Uniform3uiv)GetExtensionDelegate("glUniform3uiv", typeof(Delegates.Uniform3uiv));
            Delegates.glUniform4d = (Delegates.Uniform4d)GetExtensionDelegate("glUniform4d", typeof(Delegates.Uniform4d));
            Delegates.glUniform4dv = (Delegates.Uniform4dv)GetExtensionDelegate("glUniform4dv", typeof(Delegates.Uniform4dv));
            Delegates.glUniform4f = (Delegates.Uniform4f)GetExtensionDelegate("glUniform4f", typeof(Delegates.Uniform4f));
            Delegates.glUniform4fv = (Delegates.Uniform4fv)GetExtensionDelegate("glUniform4fv", typeof(Delegates.Uniform4fv));
            Delegates.glUniform4i = (Delegates.Uniform4i)GetExtensionDelegate("glUniform4i", typeof(Delegates.Uniform4i));
            Delegates.glUniform4iv = (Delegates.Uniform4iv)GetExtensionDelegate("glUniform4iv", typeof(Delegates.Uniform4iv));
            Delegates.glUniform4ui = (Delegates.Uniform4ui)GetExtensionDelegate("glUniform4ui", typeof(Delegates.Uniform4ui));
            Delegates.glUniform4uiv = (Delegates.Uniform4uiv)GetExtensionDelegate("glUniform4uiv", typeof(Delegates.Uniform4uiv));
            Delegates.glUniformBlockBinding = (Delegates.UniformBlockBinding)GetExtensionDelegate("glUniformBlockBinding", typeof(Delegates.UniformBlockBinding));
            Delegates.glUniformHandleui64ARB = (Delegates.UniformHandleui64ARB)GetExtensionDelegate("glUniformHandleui64ARB", typeof(Delegates.UniformHandleui64ARB));
            Delegates.glUniformHandleui64vARB = (Delegates.UniformHandleui64vARB)GetExtensionDelegate("glUniformHandleui64vARB", typeof(Delegates.UniformHandleui64vARB));
            Delegates.glUniformMatrix2dv = (Delegates.UniformMatrix2dv)GetExtensionDelegate("glUniformMatrix2dv", typeof(Delegates.UniformMatrix2dv));
            Delegates.glUniformMatrix2fv = (Delegates.UniformMatrix2fv)GetExtensionDelegate("glUniformMatrix2fv", typeof(Delegates.UniformMatrix2fv));
            Delegates.glUniformMatrix2x3dv = (Delegates.UniformMatrix2x3dv)GetExtensionDelegate("glUniformMatrix2x3dv", typeof(Delegates.UniformMatrix2x3dv));
            Delegates.glUniformMatrix2x3fv = (Delegates.UniformMatrix2x3fv)GetExtensionDelegate("glUniformMatrix2x3fv", typeof(Delegates.UniformMatrix2x3fv));
            Delegates.glUniformMatrix2x4dv = (Delegates.UniformMatrix2x4dv)GetExtensionDelegate("glUniformMatrix2x4dv", typeof(Delegates.UniformMatrix2x4dv));
            Delegates.glUniformMatrix2x4fv = (Delegates.UniformMatrix2x4fv)GetExtensionDelegate("glUniformMatrix2x4fv", typeof(Delegates.UniformMatrix2x4fv));
            Delegates.glUniformMatrix3dv = (Delegates.UniformMatrix3dv)GetExtensionDelegate("glUniformMatrix3dv", typeof(Delegates.UniformMatrix3dv));
            Delegates.glUniformMatrix3fv = (Delegates.UniformMatrix3fv)GetExtensionDelegate("glUniformMatrix3fv", typeof(Delegates.UniformMatrix3fv));
            Delegates.glUniformMatrix3x2dv = (Delegates.UniformMatrix3x2dv)GetExtensionDelegate("glUniformMatrix3x2dv", typeof(Delegates.UniformMatrix3x2dv));
            Delegates.glUniformMatrix3x2fv = (Delegates.UniformMatrix3x2fv)GetExtensionDelegate("glUniformMatrix3x2fv", typeof(Delegates.UniformMatrix3x2fv));
            Delegates.glUniformMatrix3x4dv = (Delegates.UniformMatrix3x4dv)GetExtensionDelegate("glUniformMatrix3x4dv", typeof(Delegates.UniformMatrix3x4dv));
            Delegates.glUniformMatrix3x4fv = (Delegates.UniformMatrix3x4fv)GetExtensionDelegate("glUniformMatrix3x4fv", typeof(Delegates.UniformMatrix3x4fv));
            Delegates.glUniformMatrix4dv = (Delegates.UniformMatrix4dv)GetExtensionDelegate("glUniformMatrix4dv", typeof(Delegates.UniformMatrix4dv));
            Delegates.glUniformMatrix4fv = (Delegates.UniformMatrix4fv)GetExtensionDelegate("glUniformMatrix4fv", typeof(Delegates.UniformMatrix4fv));
            Delegates.glUniformMatrix4x2dv = (Delegates.UniformMatrix4x2dv)GetExtensionDelegate("glUniformMatrix4x2dv", typeof(Delegates.UniformMatrix4x2dv));
            Delegates.glUniformMatrix4x2fv = (Delegates.UniformMatrix4x2fv)GetExtensionDelegate("glUniformMatrix4x2fv", typeof(Delegates.UniformMatrix4x2fv));
            Delegates.glUniformMatrix4x3dv = (Delegates.UniformMatrix4x3dv)GetExtensionDelegate("glUniformMatrix4x3dv", typeof(Delegates.UniformMatrix4x3dv));
            Delegates.glUniformMatrix4x3fv = (Delegates.UniformMatrix4x3fv)GetExtensionDelegate("glUniformMatrix4x3fv", typeof(Delegates.UniformMatrix4x3fv));
            Delegates.glUniformSubroutinesuiv = (Delegates.UniformSubroutinesuiv)GetExtensionDelegate("glUniformSubroutinesuiv", typeof(Delegates.UniformSubroutinesuiv));
            Delegates.glUnmapBuffer = (Delegates.UnmapBuffer)GetExtensionDelegate("glUnmapBuffer", typeof(Delegates.UnmapBuffer));
            Delegates.glUseProgram = (Delegates.UseProgram)GetExtensionDelegate("glUseProgram", typeof(Delegates.UseProgram));
            Delegates.glUseProgramStages = (Delegates.UseProgramStages)GetExtensionDelegate("glUseProgramStages", typeof(Delegates.UseProgramStages));
            Delegates.glValidateProgram = (Delegates.ValidateProgram)GetExtensionDelegate("glValidateProgram", typeof(Delegates.ValidateProgram));
            Delegates.glValidateProgramPipeline = (Delegates.ValidateProgramPipeline)GetExtensionDelegate("glValidateProgramPipeline", typeof(Delegates.ValidateProgramPipeline));
            Delegates.glVertexAttrib1d = (Delegates.VertexAttrib1d)GetExtensionDelegate("glVertexAttrib1d", typeof(Delegates.VertexAttrib1d));
            Delegates.glVertexAttrib1dv = (Delegates.VertexAttrib1dv)GetExtensionDelegate("glVertexAttrib1dv", typeof(Delegates.VertexAttrib1dv));
            Delegates.glVertexAttrib1f = (Delegates.VertexAttrib1f)GetExtensionDelegate("glVertexAttrib1f", typeof(Delegates.VertexAttrib1f));
            Delegates.glVertexAttrib1fv = (Delegates.VertexAttrib1fv)GetExtensionDelegate("glVertexAttrib1fv", typeof(Delegates.VertexAttrib1fv));
            Delegates.glVertexAttrib1s = (Delegates.VertexAttrib1s)GetExtensionDelegate("glVertexAttrib1s", typeof(Delegates.VertexAttrib1s));
            Delegates.glVertexAttrib1sv = (Delegates.VertexAttrib1sv)GetExtensionDelegate("glVertexAttrib1sv", typeof(Delegates.VertexAttrib1sv));
            Delegates.glVertexAttrib2d = (Delegates.VertexAttrib2d)GetExtensionDelegate("glVertexAttrib2d", typeof(Delegates.VertexAttrib2d));
            Delegates.glVertexAttrib2dv = (Delegates.VertexAttrib2dv)GetExtensionDelegate("glVertexAttrib2dv", typeof(Delegates.VertexAttrib2dv));
            Delegates.glVertexAttrib2f = (Delegates.VertexAttrib2f)GetExtensionDelegate("glVertexAttrib2f", typeof(Delegates.VertexAttrib2f));
            Delegates.glVertexAttrib2fv = (Delegates.VertexAttrib2fv)GetExtensionDelegate("glVertexAttrib2fv", typeof(Delegates.VertexAttrib2fv));
            Delegates.glVertexAttrib2s = (Delegates.VertexAttrib2s)GetExtensionDelegate("glVertexAttrib2s", typeof(Delegates.VertexAttrib2s));
            Delegates.glVertexAttrib2sv = (Delegates.VertexAttrib2sv)GetExtensionDelegate("glVertexAttrib2sv", typeof(Delegates.VertexAttrib2sv));
            Delegates.glVertexAttrib3d = (Delegates.VertexAttrib3d)GetExtensionDelegate("glVertexAttrib3d", typeof(Delegates.VertexAttrib3d));
            Delegates.glVertexAttrib3dv = (Delegates.VertexAttrib3dv)GetExtensionDelegate("glVertexAttrib3dv", typeof(Delegates.VertexAttrib3dv));
            Delegates.glVertexAttrib3f = (Delegates.VertexAttrib3f)GetExtensionDelegate("glVertexAttrib3f", typeof(Delegates.VertexAttrib3f));
            Delegates.glVertexAttrib3fv = (Delegates.VertexAttrib3fv)GetExtensionDelegate("glVertexAttrib3fv", typeof(Delegates.VertexAttrib3fv));
            Delegates.glVertexAttrib3s = (Delegates.VertexAttrib3s)GetExtensionDelegate("glVertexAttrib3s", typeof(Delegates.VertexAttrib3s));
            Delegates.glVertexAttrib3sv = (Delegates.VertexAttrib3sv)GetExtensionDelegate("glVertexAttrib3sv", typeof(Delegates.VertexAttrib3sv));
            Delegates.glVertexAttrib4bv = (Delegates.VertexAttrib4bv)GetExtensionDelegate("glVertexAttrib4bv", typeof(Delegates.VertexAttrib4bv));
            Delegates.glVertexAttrib4d = (Delegates.VertexAttrib4d)GetExtensionDelegate("glVertexAttrib4d", typeof(Delegates.VertexAttrib4d));
            Delegates.glVertexAttrib4dv = (Delegates.VertexAttrib4dv)GetExtensionDelegate("glVertexAttrib4dv", typeof(Delegates.VertexAttrib4dv));
            Delegates.glVertexAttrib4f = (Delegates.VertexAttrib4f)GetExtensionDelegate("glVertexAttrib4f", typeof(Delegates.VertexAttrib4f));
            Delegates.glVertexAttrib4fv = (Delegates.VertexAttrib4fv)GetExtensionDelegate("glVertexAttrib4fv", typeof(Delegates.VertexAttrib4fv));
            Delegates.glVertexAttrib4iv = (Delegates.VertexAttrib4iv)GetExtensionDelegate("glVertexAttrib4iv", typeof(Delegates.VertexAttrib4iv));
            Delegates.glVertexAttrib4Nbv = (Delegates.VertexAttrib4Nbv)GetExtensionDelegate("glVertexAttrib4Nbv", typeof(Delegates.VertexAttrib4Nbv));
            Delegates.glVertexAttrib4Niv = (Delegates.VertexAttrib4Niv)GetExtensionDelegate("glVertexAttrib4Niv", typeof(Delegates.VertexAttrib4Niv));
            Delegates.glVertexAttrib4Nsv = (Delegates.VertexAttrib4Nsv)GetExtensionDelegate("glVertexAttrib4Nsv", typeof(Delegates.VertexAttrib4Nsv));
            Delegates.glVertexAttrib4Nub = (Delegates.VertexAttrib4Nub)GetExtensionDelegate("glVertexAttrib4Nub", typeof(Delegates.VertexAttrib4Nub));
            Delegates.glVertexAttrib4Nubv = (Delegates.VertexAttrib4Nubv)GetExtensionDelegate("glVertexAttrib4Nubv", typeof(Delegates.VertexAttrib4Nubv));
            Delegates.glVertexAttrib4Nuiv = (Delegates.VertexAttrib4Nuiv)GetExtensionDelegate("glVertexAttrib4Nuiv", typeof(Delegates.VertexAttrib4Nuiv));
            Delegates.glVertexAttrib4Nusv = (Delegates.VertexAttrib4Nusv)GetExtensionDelegate("glVertexAttrib4Nusv", typeof(Delegates.VertexAttrib4Nusv));
            Delegates.glVertexAttrib4s = (Delegates.VertexAttrib4s)GetExtensionDelegate("glVertexAttrib4s", typeof(Delegates.VertexAttrib4s));
            Delegates.glVertexAttrib4sv = (Delegates.VertexAttrib4sv)GetExtensionDelegate("glVertexAttrib4sv", typeof(Delegates.VertexAttrib4sv));
            Delegates.glVertexAttrib4ubv = (Delegates.VertexAttrib4ubv)GetExtensionDelegate("glVertexAttrib4ubv", typeof(Delegates.VertexAttrib4ubv));
            Delegates.glVertexAttrib4uiv = (Delegates.VertexAttrib4uiv)GetExtensionDelegate("glVertexAttrib4uiv", typeof(Delegates.VertexAttrib4uiv));
            Delegates.glVertexAttrib4usv = (Delegates.VertexAttrib4usv)GetExtensionDelegate("glVertexAttrib4usv", typeof(Delegates.VertexAttrib4usv));
            Delegates.glVertexAttribBinding = (Delegates.VertexAttribBinding)GetExtensionDelegate("glVertexAttribBinding", typeof(Delegates.VertexAttribBinding));
            Delegates.glVertexAttribDivisor = (Delegates.VertexAttribDivisor)GetExtensionDelegate("glVertexAttribDivisor", typeof(Delegates.VertexAttribDivisor));
            Delegates.glVertexAttribFormat = (Delegates.VertexAttribFormat)GetExtensionDelegate("glVertexAttribFormat", typeof(Delegates.VertexAttribFormat));
            Delegates.glVertexAttribI1i = (Delegates.VertexAttribI1i)GetExtensionDelegate("glVertexAttribI1i", typeof(Delegates.VertexAttribI1i));
            Delegates.glVertexAttribI1iv = (Delegates.VertexAttribI1iv)GetExtensionDelegate("glVertexAttribI1iv", typeof(Delegates.VertexAttribI1iv));
            Delegates.glVertexAttribI1ui = (Delegates.VertexAttribI1ui)GetExtensionDelegate("glVertexAttribI1ui", typeof(Delegates.VertexAttribI1ui));
            Delegates.glVertexAttribI1uiv = (Delegates.VertexAttribI1uiv)GetExtensionDelegate("glVertexAttribI1uiv", typeof(Delegates.VertexAttribI1uiv));
            Delegates.glVertexAttribI2i = (Delegates.VertexAttribI2i)GetExtensionDelegate("glVertexAttribI2i", typeof(Delegates.VertexAttribI2i));
            Delegates.glVertexAttribI2iv = (Delegates.VertexAttribI2iv)GetExtensionDelegate("glVertexAttribI2iv", typeof(Delegates.VertexAttribI2iv));
            Delegates.glVertexAttribI2ui = (Delegates.VertexAttribI2ui)GetExtensionDelegate("glVertexAttribI2ui", typeof(Delegates.VertexAttribI2ui));
            Delegates.glVertexAttribI2uiv = (Delegates.VertexAttribI2uiv)GetExtensionDelegate("glVertexAttribI2uiv", typeof(Delegates.VertexAttribI2uiv));
            Delegates.glVertexAttribI3i = (Delegates.VertexAttribI3i)GetExtensionDelegate("glVertexAttribI3i", typeof(Delegates.VertexAttribI3i));
            Delegates.glVertexAttribI3iv = (Delegates.VertexAttribI3iv)GetExtensionDelegate("glVertexAttribI3iv", typeof(Delegates.VertexAttribI3iv));
            Delegates.glVertexAttribI3ui = (Delegates.VertexAttribI3ui)GetExtensionDelegate("glVertexAttribI3ui", typeof(Delegates.VertexAttribI3ui));
            Delegates.glVertexAttribI3uiv = (Delegates.VertexAttribI3uiv)GetExtensionDelegate("glVertexAttribI3uiv", typeof(Delegates.VertexAttribI3uiv));
            Delegates.glVertexAttribI4bv = (Delegates.VertexAttribI4bv)GetExtensionDelegate("glVertexAttribI4bv", typeof(Delegates.VertexAttribI4bv));
            Delegates.glVertexAttribI4i = (Delegates.VertexAttribI4i)GetExtensionDelegate("glVertexAttribI4i", typeof(Delegates.VertexAttribI4i));
            Delegates.glVertexAttribI4iv = (Delegates.VertexAttribI4iv)GetExtensionDelegate("glVertexAttribI4iv", typeof(Delegates.VertexAttribI4iv));
            Delegates.glVertexAttribI4sv = (Delegates.VertexAttribI4sv)GetExtensionDelegate("glVertexAttribI4sv", typeof(Delegates.VertexAttribI4sv));
            Delegates.glVertexAttribI4ubv = (Delegates.VertexAttribI4ubv)GetExtensionDelegate("glVertexAttribI4ubv", typeof(Delegates.VertexAttribI4ubv));
            Delegates.glVertexAttribI4ui = (Delegates.VertexAttribI4ui)GetExtensionDelegate("glVertexAttribI4ui", typeof(Delegates.VertexAttribI4ui));
            Delegates.glVertexAttribI4uiv = (Delegates.VertexAttribI4uiv)GetExtensionDelegate("glVertexAttribI4uiv", typeof(Delegates.VertexAttribI4uiv));
            Delegates.glVertexAttribI4usv = (Delegates.VertexAttribI4usv)GetExtensionDelegate("glVertexAttribI4usv", typeof(Delegates.VertexAttribI4usv));
            Delegates.glVertexAttribIFormat = (Delegates.VertexAttribIFormat)GetExtensionDelegate("glVertexAttribIFormat", typeof(Delegates.VertexAttribIFormat));
            Delegates.glVertexAttribIPointer = (Delegates.VertexAttribIPointer)GetExtensionDelegate("glVertexAttribIPointer", typeof(Delegates.VertexAttribIPointer));
            Delegates.glVertexAttribL1d = (Delegates.VertexAttribL1d)GetExtensionDelegate("glVertexAttribL1d", typeof(Delegates.VertexAttribL1d));
            Delegates.glVertexAttribL1dv = (Delegates.VertexAttribL1dv)GetExtensionDelegate("glVertexAttribL1dv", typeof(Delegates.VertexAttribL1dv));
            Delegates.glVertexAttribL1ui64ARB = (Delegates.VertexAttribL1ui64ARB)GetExtensionDelegate("glVertexAttribL1ui64ARB", typeof(Delegates.VertexAttribL1ui64ARB));
            Delegates.glVertexAttribL1ui64vARB = (Delegates.VertexAttribL1ui64vARB)GetExtensionDelegate("glVertexAttribL1ui64vARB", typeof(Delegates.VertexAttribL1ui64vARB));
            Delegates.glVertexAttribL2d = (Delegates.VertexAttribL2d)GetExtensionDelegate("glVertexAttribL2d", typeof(Delegates.VertexAttribL2d));
            Delegates.glVertexAttribL2dv = (Delegates.VertexAttribL2dv)GetExtensionDelegate("glVertexAttribL2dv", typeof(Delegates.VertexAttribL2dv));
            Delegates.glVertexAttribL3d = (Delegates.VertexAttribL3d)GetExtensionDelegate("glVertexAttribL3d", typeof(Delegates.VertexAttribL3d));
            Delegates.glVertexAttribL3dv = (Delegates.VertexAttribL3dv)GetExtensionDelegate("glVertexAttribL3dv", typeof(Delegates.VertexAttribL3dv));
            Delegates.glVertexAttribL4d = (Delegates.VertexAttribL4d)GetExtensionDelegate("glVertexAttribL4d", typeof(Delegates.VertexAttribL4d));
            Delegates.glVertexAttribL4dv = (Delegates.VertexAttribL4dv)GetExtensionDelegate("glVertexAttribL4dv", typeof(Delegates.VertexAttribL4dv));
            Delegates.glVertexAttribLFormat = (Delegates.VertexAttribLFormat)GetExtensionDelegate("glVertexAttribLFormat", typeof(Delegates.VertexAttribLFormat));
            Delegates.glVertexAttribLPointer = (Delegates.VertexAttribLPointer)GetExtensionDelegate("glVertexAttribLPointer", typeof(Delegates.VertexAttribLPointer));
            Delegates.glVertexAttribP1ui = (Delegates.VertexAttribP1ui)GetExtensionDelegate("glVertexAttribP1ui", typeof(Delegates.VertexAttribP1ui));
            Delegates.glVertexAttribP1uiv = (Delegates.VertexAttribP1uiv)GetExtensionDelegate("glVertexAttribP1uiv", typeof(Delegates.VertexAttribP1uiv));
            Delegates.glVertexAttribP2ui = (Delegates.VertexAttribP2ui)GetExtensionDelegate("glVertexAttribP2ui", typeof(Delegates.VertexAttribP2ui));
            Delegates.glVertexAttribP2uiv = (Delegates.VertexAttribP2uiv)GetExtensionDelegate("glVertexAttribP2uiv", typeof(Delegates.VertexAttribP2uiv));
            Delegates.glVertexAttribP3ui = (Delegates.VertexAttribP3ui)GetExtensionDelegate("glVertexAttribP3ui", typeof(Delegates.VertexAttribP3ui));
            Delegates.glVertexAttribP3uiv = (Delegates.VertexAttribP3uiv)GetExtensionDelegate("glVertexAttribP3uiv", typeof(Delegates.VertexAttribP3uiv));
            Delegates.glVertexAttribP4ui = (Delegates.VertexAttribP4ui)GetExtensionDelegate("glVertexAttribP4ui", typeof(Delegates.VertexAttribP4ui));
            Delegates.glVertexAttribP4uiv = (Delegates.VertexAttribP4uiv)GetExtensionDelegate("glVertexAttribP4uiv", typeof(Delegates.VertexAttribP4uiv));
            Delegates.glVertexAttribPointer = (Delegates.VertexAttribPointer)GetExtensionDelegate("glVertexAttribPointer", typeof(Delegates.VertexAttribPointer));
            Delegates.glVertexBindingDivisor = (Delegates.VertexBindingDivisor)GetExtensionDelegate("glVertexBindingDivisor", typeof(Delegates.VertexBindingDivisor));
            Delegates.glVertexP2ui = (Delegates.VertexP2ui)GetExtensionDelegate("glVertexP2ui", typeof(Delegates.VertexP2ui));
            Delegates.glVertexP2uiv = (Delegates.VertexP2uiv)GetExtensionDelegate("glVertexP2uiv", typeof(Delegates.VertexP2uiv));
            Delegates.glVertexP3ui = (Delegates.VertexP3ui)GetExtensionDelegate("glVertexP3ui", typeof(Delegates.VertexP3ui));
            Delegates.glVertexP3uiv = (Delegates.VertexP3uiv)GetExtensionDelegate("glVertexP3uiv", typeof(Delegates.VertexP3uiv));
            Delegates.glVertexP4ui = (Delegates.VertexP4ui)GetExtensionDelegate("glVertexP4ui", typeof(Delegates.VertexP4ui));
            Delegates.glVertexP4uiv = (Delegates.VertexP4uiv)GetExtensionDelegate("glVertexP4uiv", typeof(Delegates.VertexP4uiv));
            Delegates.glViewport = (Delegates.Viewport)GetExtensionDelegate("glViewport", typeof(Delegates.Viewport));
            Delegates.glViewportArrayv = (Delegates.ViewportArrayv)GetExtensionDelegate("glViewportArrayv", typeof(Delegates.ViewportArrayv));
            Delegates.glViewportIndexedf = (Delegates.ViewportIndexedf)GetExtensionDelegate("glViewportIndexedf", typeof(Delegates.ViewportIndexedf));
            Delegates.glViewportIndexedfv = (Delegates.ViewportIndexedfv)GetExtensionDelegate("glViewportIndexedfv", typeof(Delegates.ViewportIndexedfv));
            Delegates.glWaitSync = (Delegates.WaitSync)GetExtensionDelegate("glWaitSync", typeof(Delegates.WaitSync));
        }

        internal static partial class Delegates
        {
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            internal static ActiveShaderProgram glActiveShaderProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ActiveTexture(OpenTK.Graphics.OpenGL4.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void AttachShader(UInt32 program, UInt32 shader);
            internal static AttachShader glAttachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginConditionalRender(UInt32 id, OpenTK.Graphics.OpenGL4.ConditionalRenderType mode);
            internal static BeginConditionalRender glBeginConditionalRender;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginQuery(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 id);
            internal static BeginQuery glBeginQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, UInt32 id);
            internal static BeginQueryIndexed glBeginQueryIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BeginTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackPrimitiveType primitiveMode);
            internal static BeginTransformFeedback glBeginTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindAttribLocation(UInt32 program, UInt32 index, String name);
            internal static BindAttribLocation glBindAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBufferBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer);
            internal static BindBufferBase glBindBufferBase;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindBufferRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static BindBufferRange glBindBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindBuffersBase(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers);
            internal unsafe static BindBuffersBase glBindBuffersBase;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindBuffersRange(OpenTK.Graphics.OpenGL4.BufferRangeTarget target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, IntPtr* sizes);
            internal unsafe static BindBuffersRange glBindBuffersRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFragDataLocation(UInt32 program, UInt32 color, String name);
            internal static BindFragDataLocation glBindFragDataLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            internal static BindFragDataLocationIndexed glBindFragDataLocationIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.TextureAccess access, OpenTK.Graphics.OpenGL4.SizedInternalFormat format);
            internal static BindImageTexture glBindImageTexture;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindImageTextures(UInt32 first, Int32 count, UInt32* textures);
            internal unsafe static BindImageTextures glBindImageTextures;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindProgramPipeline(UInt32 pipeline);
            internal static BindProgramPipeline glBindProgramPipeline;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindRenderbuffer(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindSampler(UInt32 unit, UInt32 sampler);
            internal static BindSampler glBindSampler;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindSamplers(UInt32 first, Int32 count, UInt32* samplers);
            internal unsafe static BindSamplers glBindSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTexture(OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 texture);
            internal static BindTexture glBindTexture;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindTextures(UInt32 first, Int32 count, UInt32* textures);
            internal unsafe static BindTextures glBindTextures;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackTarget target, UInt32 id);
            internal static BindTransformFeedback glBindTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexArray(UInt32 array);
            internal static BindVertexArray glBindVertexArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
            internal static BindVertexBuffer glBindVertexBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void BindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);
            internal unsafe static BindVertexBuffers glBindVertexBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendColor(Single red, Single green, Single blue, Single alpha);
            internal static BlendColor glBlendColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquation(OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationi(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            internal static BlendEquationi glBlendEquationi;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
            internal static BlendEquationiARB glBlendEquationiARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparate(OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL4.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparatei glBlendEquationSeparatei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendEquationSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All modeRGB, OpenTK.Graphics.OpenGL4.All modeAlpha);
            internal static BlendEquationSeparateiARB glBlendEquationSeparateiARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunc(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactor, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunci(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendingFactorSrc src, OpenTK.Graphics.OpenGL4.BlendingFactorDest dst);
            internal static BlendFunci glBlendFunci;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFunciARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All src, OpenTK.Graphics.OpenGL4.All dst);
            internal static BlendFunciARB glBlendFunciARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparate(OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparatei(UInt32 buf, OpenTK.Graphics.OpenGL4.BlendingFactorSrc srcRGB, OpenTK.Graphics.OpenGL4.BlendingFactorDest dstRGB, OpenTK.Graphics.OpenGL4.BlendingFactorSrc srcAlpha, OpenTK.Graphics.OpenGL4.BlendingFactorDest dstAlpha);
            internal static BlendFuncSeparatei glBlendFuncSeparatei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlendFuncSeparateiARB(UInt32 buf, OpenTK.Graphics.OpenGL4.All srcRGB, OpenTK.Graphics.OpenGL4.All dstRGB, OpenTK.Graphics.OpenGL4.All srcAlpha, OpenTK.Graphics.OpenGL4.All dstAlpha);
            internal static BlendFuncSeparateiARB glBlendFuncSeparateiARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenTK.Graphics.OpenGL4.ClearBufferMask mask, OpenTK.Graphics.OpenGL4.BlitFramebufferFilter filter);
            internal static BlitFramebuffer glBlitFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferUsageHint usage);
            internal static BufferData glBufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferStorage(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.OpenGL4.BufferStorageFlags flags);
            internal static BufferStorage glBufferStorage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void BufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            internal static BufferSubData glBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.OpenGL4.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClampColor(OpenTK.Graphics.OpenGL4.ClampColorTarget target, OpenTK.Graphics.OpenGL4.ClampColorMode clamp);
            internal static ClampColor glClampColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Clear(OpenTK.Graphics.OpenGL4.ClearBufferMask mask);
            internal static Clear glClear;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearBufferData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            internal static ClearBufferData glClearBufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearBufferfi(OpenTK.Graphics.OpenGL4.ClearBufferCombined buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            internal static ClearBufferfi glClearBufferfi;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferfv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Single* value);
            internal unsafe static ClearBufferfv glClearBufferfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, Int32* value);
            internal unsafe static ClearBufferiv glClearBufferiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, IntPtr offset, IntPtr size, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.All type, IntPtr data);
            internal static ClearBufferSubData glClearBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ClearBufferuiv(OpenTK.Graphics.OpenGL4.ClearBuffer buffer, Int32 drawbuffer, UInt32* value);
            internal unsafe static ClearBufferuiv glClearBufferuiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearColor(Single red, Single green, Single blue, Single alpha);
            internal static ClearColor glClearColor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepth(Double depth);
            internal static ClearDepth glClearDepth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearTexImage(UInt32 texture, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ClearTexImage glClearTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ClearTexSubImage glClearTexSubImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.WaitSyncStatus ClientWaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.ClientWaitSyncFlags flags, UInt64 timeout);
            internal static ClientWaitSync glClientWaitSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
            internal static ColorMask glColorMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorMaski(UInt32 index, bool r, bool g, bool b, bool a);
            internal static ColorMaski glColorMaski;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static ColorP3ui glColorP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP3uiv glColorP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static ColorP4ui glColorP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static ColorP4uiv glColorP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 count, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr data);
            internal static ColorSubTable glColorSubTable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr table);
            internal static ColorTable glColorTable;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Single* @params);
            internal unsafe static ColorTableParameterfv glColorTableParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.ColorTableParameterPName pname, Int32* @params);
            internal unsafe static ColorTableParameteriv glColorTableParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void CompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);
            internal unsafe static CompileShaderIncludeARB glCompileShaderIncludeARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage1D glCompressedTexImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage1D glCompressedTexSubImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CompressedTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, Int32 imageSize, IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            internal static ConvolutionFilter1D glConvolutionFilter1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr image);
            internal static ConvolutionFilter2D glConvolutionFilter2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionParameterf(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single @params);
            internal static ConvolutionParameterf glConvolutionParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Single* @params);
            internal unsafe static ConvolutionParameterfv glConvolutionParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ConvolutionParameteri(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32 @params);
            internal static ConvolutionParameteri glConvolutionParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.ConvolutionParameter pname, Int32* @params);
            internal unsafe static ConvolutionParameteriv glConvolutionParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            internal static CopyBufferSubData glCopyBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyColorSubTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            internal static CopyColorSubTable glCopyColorSubTable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyColorTable glCopyColorTable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyConvolutionFilter1D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyConvolutionFilter2D(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyImageSubData(UInt32 srcName, OpenTK.Graphics.OpenGL4.ImageTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenTK.Graphics.OpenGL4.ImageTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
            internal static CopyImageSubData glCopyImageSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            internal static CopyTexImage1D glCopyTexImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            internal static CopyTexSubImage1D glCopyTexSubImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CopyTexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShader(OpenTK.Graphics.OpenGL4.ShaderType type);
            internal static CreateShader glCreateShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 CreateShaderProgramv(OpenTK.Graphics.OpenGL4.ShaderType type, Int32 count, String[] strings);
            internal static CreateShaderProgramv glCreateShaderProgramv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate IntPtr CreateSyncFromCLeventARB([OutAttribute] IntPtr* context, [OutAttribute] IntPtr* @event, UInt32 flags);
            internal unsafe static CreateSyncFromCLeventARB glCreateSyncFromCLeventARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void CullFace(OpenTK.Graphics.OpenGL4.CullFaceMode mode);
            internal static CullFace glCullFace;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallback(DebugProc callback, IntPtr userParam);
            internal static DebugMessageCallback glDebugMessageCallback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallbackARB(DebugProcArb callback, IntPtr userParam);
            internal static DebugMessageCallbackARB glDebugMessageCallbackARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageCallbackKHR(DebugProcKhr callback, IntPtr userParam);
            internal static DebugMessageCallbackKHR glDebugMessageCallbackKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControl(OpenTK.Graphics.OpenGL4.DebugSourceControl source, OpenTK.Graphics.OpenGL4.DebugTypeControl type, OpenTK.Graphics.OpenGL4.DebugSeverityControl severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControl glDebugMessageControl;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControlARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlARB glDebugMessageControlARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DebugMessageControlKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, OpenTK.Graphics.OpenGL4.All severity, Int32 count, UInt32* ids, bool enabled);
            internal unsafe static DebugMessageControlKHR glDebugMessageControlKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsert(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, OpenTK.Graphics.OpenGL4.DebugType type, UInt32 id, OpenTK.Graphics.OpenGL4.DebugSeverity severity, Int32 length, String buf);
            internal static DebugMessageInsert glDebugMessageInsert;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsertARB(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf);
            internal static DebugMessageInsertARB glDebugMessageInsertARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DebugMessageInsertKHR(OpenTK.Graphics.OpenGL4.All source, OpenTK.Graphics.OpenGL4.All type, UInt32 id, OpenTK.Graphics.OpenGL4.All severity, Int32 length, String buf);
            internal static DebugMessageInsertKHR glDebugMessageInsertKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteBuffers(Int32 n, UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteNamedStringARB(Int32 namelen, String name);
            internal static DeleteNamedStringARB glDeleteNamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteProgramPipelines(Int32 n, UInt32* pipelines);
            internal unsafe static DeleteProgramPipelines glDeleteProgramPipelines;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteQueries(Int32 n, UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteSamplers(Int32 count, UInt32* samplers);
            internal unsafe static DeleteSamplers glDeleteSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteSync(IntPtr sync);
            internal static DeleteSync glDeleteSync;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTextures(Int32 n, UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteTransformFeedbacks(Int32 n, UInt32* ids);
            internal unsafe static DeleteTransformFeedbacks glDeleteTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DeleteVertexArrays(Int32 n, UInt32* arrays);
            internal unsafe static DeleteVertexArrays glDeleteVertexArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthFunc(OpenTK.Graphics.OpenGL4.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRange(Double near, Double far);
            internal static DepthRange glDepthRange;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DepthRangeArrayv(UInt32 first, Int32 count, Double* v);
            internal unsafe static DepthRangeArrayv glDepthRangeArrayv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangef(Single n, Single f);
            internal static DepthRangef glDepthRangef;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DepthRangeIndexed(UInt32 index, Double n, Double f);
            internal static DepthRangeIndexed glDepthRangeIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DetachShader(UInt32 program, UInt32 shader);
            internal static DetachShader glDetachShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static Disable glDisable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Disablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static Disablei glDisablei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
            internal static DispatchCompute glDispatchCompute;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);
            internal static DispatchComputeGroupSizeARB glDispatchComputeGroupSizeARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DispatchComputeIndirect(IntPtr indirect);
            internal static DispatchComputeIndirect glDispatchComputeIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count);
            internal static DrawArrays glDrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect);
            internal static DrawArraysIndirect glDrawArraysIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount);
            internal static DrawArraysInstanced glDrawArraysInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawArraysInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);
            internal static DrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawBuffer(OpenTK.Graphics.OpenGL4.DrawBufferMode mode);
            internal static DrawBuffer glDrawBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void DrawBuffers(Int32 n, OpenTK.Graphics.OpenGL4.DrawBuffersEnum* bufs);
            internal unsafe static DrawBuffers glDrawBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            internal static DrawElements glDrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawElementsBaseVertex glDrawElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect);
            internal static DrawElementsIndirect glDrawElementsIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount);
            internal static DrawElementsInstanced glDrawElementsInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);
            internal static DrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex);
            internal static DrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);
            internal static DrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawRangeElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 basevertex);
            internal static DrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedback(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id);
            internal static DrawTransformFeedback glDrawTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedbackInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, Int32 instancecount);
            internal static DrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedbackStream(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream);
            internal static DrawTransformFeedbackStream glDrawTransformFeedbackStream;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DrawTransformFeedbackStreamInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, UInt32 id, UInt32 stream, Int32 instancecount);
            internal static DrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enable(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static Enable glEnable;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Enablei(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static Enablei glEnablei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndConditionalRender();
            internal static EndConditionalRender glEndConditionalRender;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndQuery(OpenTK.Graphics.OpenGL4.QueryTarget target);
            internal static EndQuery glEndQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndQueryIndexed(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index);
            internal static EndQueryIndexed glEndQueryIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void EndTransformFeedback();
            internal static EndTransformFeedback glEndTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr FenceSync(OpenTK.Graphics.OpenGL4.SyncCondition condition, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags);
            internal static FenceSync glFenceSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Finish();
            internal static Finish glFinish;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Flush();
            internal static Flush glFlush;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FlushMappedBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length);
            internal static FlushMappedBufferRange glFlushMappedBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferParameteri(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, Int32 param);
            internal static FramebufferParameteri glFramebufferParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            internal static FramebufferTexture glFramebufferTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture1D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture1D glFramebufferTexture1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture2D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTexture3D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            internal static FramebufferTexture3D glFramebufferTexture3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            internal static FramebufferTextureLayer glFramebufferTextureLayer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void FrontFace(OpenTK.Graphics.OpenGL4.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GenerateMipmap(OpenTK.Graphics.OpenGL4.GenerateMipmapTarget target);
            internal static GenerateMipmap glGenerateMipmap;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenProgramPipelines(Int32 n, [OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelines glGenProgramPipelines;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenQueries glGenQueries;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenSamplers(Int32 count, [OutAttribute] UInt32* samplers);
            internal unsafe static GenSamplers glGenSamplers;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacks glGenTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArrays glGenVertexArrays;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenTK.Graphics.OpenGL4.AtomicCounterBufferParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveSubroutineName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineName glGetActiveSubroutineName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveSubroutineUniformiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveSubroutineUniformName(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineUniformName glGetActiveSubroutineUniformName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL4.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName);
            internal unsafe static GetActiveUniformName glGetActiveUniformName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, OpenTK.Graphics.OpenGL4.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetAttribLocation(UInt32 program, String name);
            internal static GetAttribLocation glGetAttribLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleani_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] bool* data);
            internal unsafe static GetBooleani_v glGetBooleani_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBooleanv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] bool* data);
            internal unsafe static GetBooleanv glGetBooleanv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteri64v(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int64* @params);
            internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetBufferParameteriv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferPointerv(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferPointer pname, [OutAttribute] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            internal static GetBufferSubData glGetBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetColorTable(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr table);
            internal static GetColorTable glGetColorTable;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetColorTableParameterfv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetColorTableParameteriv(OpenTK.Graphics.OpenGL4.ColorTableTarget target, OpenTK.Graphics.OpenGL4.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetCompressedTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            internal static GetCompressedTexImage glGetCompressedTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetConvolutionFilter(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr image);
            internal static GetConvolutionFilter glGetConvolutionFilter;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetConvolutionParameterfv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetConvolutionParameteriv(OpenTK.Graphics.OpenGL4.ConvolutionTarget target, OpenTK.Graphics.OpenGL4.GetConvolutionParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLog(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugSource* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugType* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.DebugSeverity* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLog glGetDebugMessageLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLogARB(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogARB glGetDebugMessageLogARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Int32 GetDebugMessageLogKHR(UInt32 count, Int32 bufSize, [OutAttribute] OpenTK.Graphics.OpenGL4.All* sources, [OutAttribute] OpenTK.Graphics.OpenGL4.All* types, [OutAttribute] UInt32* ids, [OutAttribute] OpenTK.Graphics.OpenGL4.All* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogKHR glGetDebugMessageLogKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDoublei_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Double* data);
            internal unsafe static GetDoublei_v glGetDoublei_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetDoublev(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Double* data);
            internal unsafe static GetDoublev glGetDoublev;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.ErrorCode GetError();
            internal static GetError glGetError;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloati_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Single* data);
            internal unsafe static GetFloati_v glGetFloati_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFloatv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Single* data);
            internal unsafe static GetFloatv glGetFloatv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetFragDataIndex(UInt32 program, String name);
            internal static GetFragDataIndex glGetFragDataIndex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetFragDataLocation(UInt32 program, String name);
            internal static GetFragDataLocation glGetFragDataLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetFramebufferParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferDefaultParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferParameteriv glGetFramebufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.All GetGraphicsResetStatusARB();
            internal static GetGraphicsResetStatusARB glGetGraphicsResetStatusARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            internal static GetHistogram glGetHistogram;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetHistogramParameterfv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetHistogramParameteriv(OpenTK.Graphics.OpenGL4.HistogramTarget target, OpenTK.Graphics.OpenGL4.GetHistogramParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 GetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, OpenTK.Graphics.OpenGL4.All format);
            internal static GetImageHandleARB glGetImageHandleARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64i_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64i_v glGetInteger64i_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInteger64v(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int64* data);
            internal unsafe static GetInteger64v glGetInteger64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegeri_v(OpenTK.Graphics.OpenGL4.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_v glGetIntegeri_v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetIntegerv(OpenTK.Graphics.OpenGL4.GetPName pname, [OutAttribute] Int32* data);
            internal unsafe static GetIntegerv glGetIntegerv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInternalformati64v(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int64* @params);
            internal unsafe static GetInternalformati64v glGetInternalformati64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetInternalformativ(OpenTK.Graphics.OpenGL4.ImageTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, OpenTK.Graphics.OpenGL4.InternalFormatParameter pname, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetInternalformativ glGetInternalformativ;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, bool reset, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr values);
            internal static GetMinmax glGetMinmax;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMinmaxParameterfv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Single* @params);
            internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMinmaxParameteriv(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.GetMinmaxParameterPName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetMultisamplefv(OpenTK.Graphics.OpenGL4.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single* val);
            internal unsafe static GetMultisamplefv glGetMultisamplefv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, [OutAttribute] Int32* stringlen, [OutAttribute] StringBuilder @string);
            internal unsafe static GetNamedStringARB glGetNamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetNamedStringivARB(Int32 namelen, String name, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetNamedStringivARB glGetNamedStringivARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnColorTableARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr table);
            internal static GetnColorTableARB glGetnColorTableARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnCompressedTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 lod, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnCompressedTexImageARB glGetnCompressedTexImageARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnConvolutionFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr image);
            internal static GetnConvolutionFilterARB glGetnConvolutionFilterARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnHistogramARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnHistogramARB glGetnHistogramARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnMapdvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Double* v);
            internal unsafe static GetnMapdvARB glGetnMapdvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnMapfvARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Single* v);
            internal unsafe static GetnMapfvARB glGetnMapfvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnMapivARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All query, Int32 bufSize, [OutAttribute] Int32* v);
            internal unsafe static GetnMapivARB glGetnMapivARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnMinmaxARB(OpenTK.Graphics.OpenGL4.All target, bool reset, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr values);
            internal static GetnMinmaxARB glGetnMinmaxARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPixelMapfvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] Single* values);
            internal unsafe static GetnPixelMapfvARB glGetnPixelMapfvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPixelMapuivARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt32* values);
            internal unsafe static GetnPixelMapuivARB glGetnPixelMapuivARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPixelMapusvARB(OpenTK.Graphics.OpenGL4.All map, Int32 bufSize, [OutAttribute] UInt16* values);
            internal unsafe static GetnPixelMapusvARB glGetnPixelMapusvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnPolygonStippleARB(Int32 bufSize, [OutAttribute] Byte* pattern);
            internal unsafe static GetnPolygonStippleARB glGetnPolygonStippleARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnSeparableFilterARB(OpenTK.Graphics.OpenGL4.All target, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 rowBufSize, [OutAttribute] IntPtr row, Int32 columnBufSize, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetnSeparableFilterARB glGetnSeparableFilterARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetnTexImageARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr img);
            internal static GetnTexImageARB glGetnTexImageARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double* @params);
            internal unsafe static GetnUniformdvARB glGetnUniformdvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvARB glGetnUniformfvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivARB glGetnUniformivARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32* @params);
            internal unsafe static GetnUniformuivARB glGetnUniformuivARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabel glGetObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectLabelKHR glGetObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabel(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabel glGetObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetObjectPtrLabelKHR(IntPtr ptr, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder label);
            internal unsafe static GetObjectPtrLabelKHR glGetObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointerv(OpenTK.Graphics.OpenGL4.GetPointervPName pname, [OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetPointervKHR(OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] IntPtr @params);
            internal static GetPointervKHR glGetPointervKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinary glGetProgramBinary;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramInterfaceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, OpenTK.Graphics.OpenGL4.ProgramInterfaceParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramInterfaceiv glGetProgramInterfaceiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramiv(UInt32 program, OpenTK.Graphics.OpenGL4.GetProgramParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLog glGetProgramPipelineInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramPipelineiv(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramPipelineParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineiv glGetProgramPipelineiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetProgramResourceIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceIndex glGetProgramResourceIndex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramResourceiv(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 propCount, OpenTK.Graphics.OpenGL4.ProgramProperty* props, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* @params);
            internal unsafe static GetProgramResourceiv glGetProgramResourceiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetProgramResourceLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceLocation glGetProgramResourceLocation;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetProgramResourceLocationIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, String name);
            internal static GetProgramResourceLocationIndex glGetProgramResourceLocationIndex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramResourceName(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            internal unsafe static GetProgramResourceName glGetProgramResourceName;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetProgramStageiv(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute] Int32* values);
            internal unsafe static GetProgramStageiv glGetProgramStageiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryIndexediv(OpenTK.Graphics.OpenGL4.QueryTarget target, UInt32 index, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryIndexediv glGetQueryIndexediv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryiv(OpenTK.Graphics.OpenGL4.QueryTarget target, OpenTK.Graphics.OpenGL4.GetQueryParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjecti64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64v glGetQueryObjecti64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectiv glGetQueryObjectiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectui64v(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64v glGetQueryObjectui64v;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetRenderbufferParameteriv(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, [OutAttribute] Single* @params);
            internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameterIiv glGetSamplerParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.All pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetSamplerParameterIuiv glGetSamplerParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, [OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetSeparableFilter(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            internal static GetSeparableFilter glGetSeparableFilter;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderiv(UInt32 shader, OpenTK.Graphics.OpenGL4.ShaderParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderPrecisionFormat(OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ShaderPrecision precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetString(OpenTK.Graphics.OpenGL4.StringName name);
            internal static GetString glGetString;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetStringi(OpenTK.Graphics.OpenGL4.StringNameIndexed name, UInt32 index);
            internal static GetStringi glGetStringi;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetSubroutineIndex(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            internal static GetSubroutineIndex glGetSubroutineIndex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetSubroutineUniformLocation(UInt32 program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, String name);
            internal static GetSubroutineUniformLocation glGetSubroutineUniformLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetSynciv(IntPtr sync, OpenTK.Graphics.OpenGL4.SyncParameterName pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            internal unsafe static GetSynciv glGetSynciv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetTexImage(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            internal static GetTexImage glGetTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexLevelParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexLevelParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameterIiv glGetTexParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetTexParameterIuiv glGetTexParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.GetTextureParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 GetTextureHandleARB(UInt32 texture);
            internal static GetTextureHandleARB glGetTextureHandleARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 GetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);
            internal static GetTextureSamplerHandleARB glGetTextureSamplerHandleARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] OpenTK.Graphics.OpenGL4.TransformFeedbackType* type, [OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            internal static GetUniformBlockIndex glGetUniformBlockIndex;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double* @params);
            internal unsafe static GetUniformdv glGetUniformdv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
            internal unsafe static GetUniformIndices glGetUniformIndices;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int32 GetUniformLocation(UInt32 program, String name);
            internal static GetUniformLocation glGetUniformLocation;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformSubroutineuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformSubroutineuiv glGetUniformSubroutineuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuiv glGetUniformuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdv glGetVertexAttribdv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribIiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribIuiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribLdv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameter pname, [OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribLdv glGetVertexAttribLdv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void GetVertexAttribLui64vARB(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribParameterArb pname, [OutAttribute] UInt64* @params);
            internal unsafe static GetVertexAttribLui64vARB glGetVertexAttribLui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void GetVertexAttribPointerv(UInt32 index, OpenTK.Graphics.OpenGL4.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Hint(OpenTK.Graphics.OpenGL4.HintTarget target, OpenTK.Graphics.OpenGL4.HintMode mode);
            internal static Hint glHint;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Histogram(OpenTK.Graphics.OpenGL4.HistogramTarget target, Int32 width, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            internal static Histogram glHistogram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateBufferData(UInt32 buffer);
            internal static InvalidateBufferData glInvalidateBufferData;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);
            internal static InvalidateBufferSubData glInvalidateBufferSubData;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void InvalidateFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments);
            internal unsafe static InvalidateFramebuffer glInvalidateFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void InvalidateSubFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, Int32 numAttachments, OpenTK.Graphics.OpenGL4.FramebufferAttachment* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            internal unsafe static InvalidateSubFramebuffer glInvalidateSubFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateTexImage(UInt32 texture, Int32 level);
            internal static InvalidateTexImage glInvalidateTexImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
            internal static InvalidateTexSubImage glInvalidateTexSubImage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabled(OpenTK.Graphics.OpenGL4.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsEnabledi(OpenTK.Graphics.OpenGL4.IndexedEnableCap target, UInt32 index);
            internal static IsEnabledi glIsEnabledi;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsImageHandleResidentARB(UInt64 handle);
            internal static IsImageHandleResidentARB glIsImageHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsNamedStringARB(Int32 namelen, String name);
            internal static IsNamedStringARB glIsNamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsProgramPipeline(UInt32 pipeline);
            internal static IsProgramPipeline glIsProgramPipeline;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsQuery(UInt32 id);
            internal static IsQuery glIsQuery;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSampler(UInt32 sampler);
            internal static IsSampler glIsSampler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsSync(IntPtr sync);
            internal static IsSync glIsSync;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTextureHandleResidentARB(UInt64 handle);
            internal static IsTextureHandleResidentARB glIsTextureHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsTransformFeedback(UInt32 id);
            internal static IsTransformFeedback glIsTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool IsVertexArray(UInt32 array);
            internal static IsVertexArray glIsVertexArray;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void LogicOp(OpenTK.Graphics.OpenGL4.LogicOp opcode);
            internal static LogicOp glLogicOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeImageHandleNonResidentARB(UInt64 handle);
            internal static MakeImageHandleNonResidentARB glMakeImageHandleNonResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeImageHandleResidentARB(UInt64 handle, OpenTK.Graphics.OpenGL4.All access);
            internal static MakeImageHandleResidentARB glMakeImageHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeTextureHandleNonResidentARB(UInt64 handle);
            internal static MakeTextureHandleNonResidentARB glMakeTextureHandleNonResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MakeTextureHandleResidentARB(UInt64 handle);
            internal static MakeTextureHandleResidentARB glMakeTextureHandleResidentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target, OpenTK.Graphics.OpenGL4.BufferAccess access);
            internal static MapBuffer glMapBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr MapBufferRange(OpenTK.Graphics.OpenGL4.BufferTarget target, IntPtr offset, IntPtr length, OpenTK.Graphics.OpenGL4.BufferAccessMask access);
            internal static MapBufferRange glMapBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MemoryBarrier(OpenTK.Graphics.OpenGL4.MemoryBarrierFlags barriers);
            internal static MemoryBarrier glMemoryBarrier;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Minmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, bool sink);
            internal static Minmax glMinmax;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MinSampleShading(Single value);
            internal static MinSampleShading glMinSampleShading;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MinSampleShadingARB(Single value);
            internal static MinSampleShadingARB glMinSampleShadingARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawArrays(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* first, Int32* count, Int32 drawcount);
            internal unsafe static MultiDrawArrays glMultiDrawArrays;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect, Int32 drawcount, Int32 stride);
            internal static MultiDrawArraysIndirect glMultiDrawArraysIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawArraysIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            internal static MultiDrawArraysIndirectCountARB glMultiDrawArraysIndirectCountARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElements(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount);
            internal unsafe static MultiDrawElements glMultiDrawElements;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL4.PrimitiveType mode, Int32* count, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32* basevertex);
            internal unsafe static MultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawElementsIndirect(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, Int32 drawcount, Int32 stride);
            internal static MultiDrawElementsIndirect glMultiDrawElementsIndirect;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiDrawElementsIndirectCountARB(OpenTK.Graphics.OpenGL4.All mode, OpenTK.Graphics.OpenGL4.All type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
            internal static MultiDrawElementsIndirectCountARB glMultiDrawElementsIndirectCountARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP1ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP1ui glMultiTexCoordP1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP1uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP1uiv glMultiTexCoordP1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP2ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP2ui glMultiTexCoordP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP2uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP2uiv glMultiTexCoordP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP3ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP3ui glMultiTexCoordP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP3uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP3uiv glMultiTexCoordP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void MultiTexCoordP4ui(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static MultiTexCoordP4ui glMultiTexCoordP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void MultiTexCoordP4uiv(OpenTK.Graphics.OpenGL4.TextureUnit texture, OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static MultiTexCoordP4uiv glMultiTexCoordP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void NamedStringARB(OpenTK.Graphics.OpenGL4.All type, Int32 namelen, String name, Int32 stringlen, String @string);
            internal static NamedStringARB glNamedStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void NormalP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static NormalP3ui glNormalP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void NormalP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static NormalP3uiv glNormalP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabel(OpenTK.Graphics.OpenGL4.ObjectLabelIdentifier identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabel glObjectLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectLabelKHR(OpenTK.Graphics.OpenGL4.All identifier, UInt32 name, Int32 length, String label);
            internal static ObjectLabelKHR glObjectLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabel glObjectPtrLabel;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ObjectPtrLabelKHR(IntPtr ptr, Int32 length, String label);
            internal static ObjectPtrLabelKHR glObjectPtrLabelKHR;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PatchParameterfv(OpenTK.Graphics.OpenGL4.PatchParameterFloat pname, Single* values);
            internal unsafe static PatchParameterfv glPatchParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PatchParameteri(OpenTK.Graphics.OpenGL4.PatchParameterInt pname, Int32 value);
            internal static PatchParameteri glPatchParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PauseTransformFeedback();
            internal static PauseTransformFeedback glPauseTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStoref(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Single param);
            internal static PixelStoref glPixelStoref;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PixelStorei(OpenTK.Graphics.OpenGL4.PixelStoreParameter pname, Int32 param);
            internal static PixelStorei glPixelStorei;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameterf(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single param);
            internal static PointParameterf glPointParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameterfv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointParameteri(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32 param);
            internal static PointParameteri glPointParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void PointParameteriv(OpenTK.Graphics.OpenGL4.PointParameterName pname, Int32* @params);
            internal unsafe static PointParameteriv glPointParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonMode(OpenTK.Graphics.OpenGL4.MaterialFace face, OpenTK.Graphics.OpenGL4.PolygonMode mode);
            internal static PolygonMode glPolygonMode;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PolygonOffset(Single factor, Single units);
            internal static PolygonOffset glPolygonOffset;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopDebugGroup();
            internal static PopDebugGroup glPopDebugGroup;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PopDebugGroupKHR();
            internal static PopDebugGroupKHR glPopDebugGroupKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PrimitiveRestartIndex(UInt32 index);
            internal static PrimitiveRestartIndex glPrimitiveRestartIndex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramBinary(UInt32 program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, IntPtr binary, Int32 length);
            internal static ProgramBinary glProgramBinary;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramParameteri(UInt32 program, OpenTK.Graphics.OpenGL4.ProgramParameterName pname, Int32 value);
            internal static ProgramParameteri glProgramParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1d(UInt32 program, Int32 location, Double v0);
            internal static ProgramUniform1d glProgramUniform1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform1dv glProgramUniform1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            internal static ProgramUniform1f glProgramUniform1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform1fv glProgramUniform1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            internal static ProgramUniform1i glProgramUniform1i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform1iv glProgramUniform1iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            internal static ProgramUniform1ui glProgramUniform1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform1uiv glProgramUniform1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1);
            internal static ProgramUniform2d glProgramUniform2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform2dv glProgramUniform2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            internal static ProgramUniform2f glProgramUniform2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform2fv glProgramUniform2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            internal static ProgramUniform2i glProgramUniform2i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform2iv glProgramUniform2iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            internal static ProgramUniform2ui glProgramUniform2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform2uiv glProgramUniform2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2);
            internal static ProgramUniform3d glProgramUniform3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform3dv glProgramUniform3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            internal static ProgramUniform3f glProgramUniform3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform3fv glProgramUniform3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static ProgramUniform3i glProgramUniform3i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform3iv glProgramUniform3iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static ProgramUniform3ui glProgramUniform3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform3uiv glProgramUniform3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3);
            internal static ProgramUniform4d glProgramUniform4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4dv(UInt32 program, Int32 location, Int32 count, Double* value);
            internal unsafe static ProgramUniform4dv glProgramUniform4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static ProgramUniform4f glProgramUniform4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single* value);
            internal unsafe static ProgramUniform4fv glProgramUniform4fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static ProgramUniform4i glProgramUniform4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            internal unsafe static ProgramUniform4iv glProgramUniform4iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static ProgramUniform4ui glProgramUniform4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            internal unsafe static ProgramUniform4uiv glProgramUniform4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);
            internal static ProgramUniformHandleui64ARB glProgramUniformHandleui64ARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);
            internal unsafe static ProgramUniformHandleui64vARB glProgramUniformHandleui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2dv glProgramUniformMatrix2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2fv glProgramUniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3dv glProgramUniformMatrix3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3fv glProgramUniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4dv glProgramUniformMatrix4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4fv glProgramUniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static ProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static ProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ProvokingVertex(OpenTK.Graphics.OpenGL4.ProvokingVertexMode mode);
            internal static ProvokingVertex glProvokingVertex;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroup(OpenTK.Graphics.OpenGL4.DebugSourceExternal source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroup glPushDebugGroup;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void PushDebugGroupKHR(OpenTK.Graphics.OpenGL4.All source, UInt32 id, Int32 length, String message);
            internal static PushDebugGroupKHR glPushDebugGroupKHR;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void QueryCounter(UInt32 id, OpenTK.Graphics.OpenGL4.QueryCounterTarget target);
            internal static QueryCounter glQueryCounter;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadBuffer(OpenTK.Graphics.OpenGL4.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.All format, OpenTK.Graphics.OpenGL4.All type, Int32 bufSize, [OutAttribute] IntPtr data);
            internal static ReadnPixelsARB glReadnPixelsARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, [OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorage(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, Int32 samples, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, Int32 width, Int32 height);
            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResetHistogram(OpenTK.Graphics.OpenGL4.HistogramTarget target);
            internal static ResetHistogram glResetHistogram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResetMinmax(OpenTK.Graphics.OpenGL4.MinmaxTarget target);
            internal static ResetMinmax glResetMinmax;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ResumeTransformFeedback();
            internal static ResumeTransformFeedback glResumeTransformFeedback;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleCoverage(Single value, bool invert);
            internal static SampleCoverage glSampleCoverage;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SampleMaski(UInt32 index, UInt32 mask);
            internal static SampleMaski glSampleMaski;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SamplerParameterf(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Single param);
            internal static SamplerParameterf glSamplerParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameterfv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Single* param);
            internal unsafe static SamplerParameterfv glSamplerParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SamplerParameteri(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32 param);
            internal static SamplerParameteri glSamplerParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameterIiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32* param);
            internal unsafe static SamplerParameterIiv glSamplerParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameterIuiv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, UInt32* param);
            internal unsafe static SamplerParameterIuiv glSamplerParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SamplerParameteriv(UInt32 sampler, OpenTK.Graphics.OpenGL4.SamplerParameterName pname, Int32* param);
            internal unsafe static SamplerParameteriv glSamplerParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Scissor glScissor;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ScissorArrayv(UInt32 first, Int32 count, Int32* v);
            internal unsafe static ScissorArrayv glScissorArrayv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            internal static ScissorIndexed glScissorIndexed;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ScissorIndexedv(UInt32 index, Int32* v);
            internal unsafe static ScissorIndexedv glScissorIndexedv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SecondaryColorP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 color);
            internal static SecondaryColorP3ui glSecondaryColorP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void SecondaryColorP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* color);
            internal unsafe static SecondaryColorP3uiv glSecondaryColorP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void SeparableFilter2D(OpenTK.Graphics.OpenGL4.SeparableTarget target, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr row, IntPtr column);
            internal static SeparableFilter2D glSeparableFilter2D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderBinary(Int32 count, UInt32* shaders, OpenTK.Graphics.OpenGL4.BinaryFormat binaryformat, IntPtr binary, Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
            internal static ShaderStorageBlockBinding glShaderStorageBlockBinding;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFunc(OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilFuncSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilFunction func, Int32 @ref, UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilMaskSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOp(OpenTK.Graphics.OpenGL4.StencilOp fail, OpenTK.Graphics.OpenGL4.StencilOp zfail, OpenTK.Graphics.OpenGL4.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void StencilOpSeparate(OpenTK.Graphics.OpenGL4.StencilFace face, OpenTK.Graphics.OpenGL4.StencilOp sfail, OpenTK.Graphics.OpenGL4.StencilOp dpfail, OpenTK.Graphics.OpenGL4.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexBuffer(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer);
            internal static TexBuffer glTexBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexBufferRange(OpenTK.Graphics.OpenGL4.TextureBufferTarget target, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, UInt32 buffer, IntPtr offset, IntPtr size);
            internal static TexBufferRange glTexBufferRange;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP1ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP1ui glTexCoordP1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP1uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP1uiv glTexCoordP1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP2ui glTexCoordP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP2uiv glTexCoordP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP3ui glTexCoordP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP3uiv glTexCoordP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexCoordP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 coords);
            internal static TexCoordP4ui glTexCoordP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexCoordP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* coords);
            internal unsafe static TexCoordP4uiv glTexCoordP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage1D glTexImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            internal static TexImage2DMultisample glTexImage2DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexImage3D glTexImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexImage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample target, Int32 samples, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            internal static TexImage3DMultisample glTexImage3DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexPageCommitmentARB(OpenTK.Graphics.OpenGL4.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident);
            internal static TexPageCommitmentARB glTexPageCommitmentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameterf(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single param);
            internal static TexParameterf glTexParameterf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterfv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexParameteri(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32 param);
            internal static TexParameteri glTexParameteri;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterIiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameterIiv glTexParameterIiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameterIuiv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, UInt32* @params);
            internal unsafe static TexParameterIuiv glTexParameterIuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void TexParameteriv(OpenTK.Graphics.OpenGL4.TextureTarget target, OpenTK.Graphics.OpenGL4.TextureParameterName pname, Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage1D(OpenTK.Graphics.OpenGL4.TextureTarget1d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width);
            internal static TexStorage1D glTexStorage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2D(OpenTK.Graphics.OpenGL4.TextureTarget2d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height);
            internal static TexStorage2D glTexStorage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage2DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample2d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            internal static TexStorage2DMultisample glTexStorage2DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3D(OpenTK.Graphics.OpenGL4.TextureTarget3d target, Int32 levels, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth);
            internal static TexStorage3D glTexStorage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexStorage3DMultisample(OpenTK.Graphics.OpenGL4.TextureTargetMultisample3d target, Int32 samples, OpenTK.Graphics.OpenGL4.SizedInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            internal static TexStorage3DMultisample glTexStorage3DMultisample;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage1D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage1D glTexSubImage1D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage2D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TexSubImage3D(OpenTK.Graphics.OpenGL4.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.OpenGL4.PixelFormat format, OpenTK.Graphics.OpenGL4.PixelType type, IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TextureView(UInt32 texture, OpenTK.Graphics.OpenGL4.TextureTarget target, UInt32 origtexture, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
            internal static TextureView glTextureView;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenTK.Graphics.OpenGL4.TransformFeedbackMode bufferMode);
            internal static TransformFeedbackVaryings glTransformFeedbackVaryings;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1d(Int32 location, Double x);
            internal static Uniform1d glUniform1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform1dv glUniform1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1f(Int32 location, Single v0);
            internal static Uniform1f glUniform1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform1fv glUniform1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1i(Int32 location, Int32 v0);
            internal static Uniform1i glUniform1i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform1iv glUniform1iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform1ui(Int32 location, UInt32 v0);
            internal static Uniform1ui glUniform1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform1uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform1uiv glUniform1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2d(Int32 location, Double x, Double y);
            internal static Uniform2d glUniform2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform2dv glUniform2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2f(Int32 location, Single v0, Single v1);
            internal static Uniform2f glUniform2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform2fv glUniform2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            internal static Uniform2i glUniform2i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform2iv glUniform2iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            internal static Uniform2ui glUniform2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform2uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform2uiv glUniform2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3d(Int32 location, Double x, Double y, Double z);
            internal static Uniform3d glUniform3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform3dv glUniform3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            internal static Uniform3f glUniform3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform3fv glUniform3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            internal static Uniform3i glUniform3i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform3iv glUniform3iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            internal static Uniform3ui glUniform3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform3uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform3uiv glUniform3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4d(Int32 location, Double x, Double y, Double z, Double w);
            internal static Uniform4d glUniform4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4dv(Int32 location, Int32 count, Double* value);
            internal unsafe static Uniform4dv glUniform4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            internal static Uniform4f glUniform4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4fv(Int32 location, Int32 count, Single* value);
            internal unsafe static Uniform4fv glUniform4fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            internal static Uniform4i glUniform4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4iv(Int32 location, Int32 count, Int32* value);
            internal unsafe static Uniform4iv glUniform4iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            internal static Uniform4ui glUniform4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void Uniform4uiv(Int32 location, Int32 count, UInt32* value);
            internal unsafe static Uniform4uiv glUniform4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            internal static UniformBlockBinding glUniformBlockBinding;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UniformHandleui64ARB(Int32 location, UInt64 value);
            internal static UniformHandleui64ARB glUniformHandleui64ARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);
            internal unsafe static UniformHandleui64vARB glUniformHandleui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2dv glUniformMatrix2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x3dv glUniformMatrix2x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix2x4dv glUniformMatrix2x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3dv glUniformMatrix3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x2dv glUniformMatrix3x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix3x4dv glUniformMatrix3x4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4dv glUniformMatrix4dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x2dv glUniformMatrix4x2dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            internal unsafe static UniformMatrix4x3dv glUniformMatrix4x3dv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void UniformSubroutinesuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, Int32 count, UInt32* indices);
            internal unsafe static UniformSubroutinesuiv glUniformSubroutinesuiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool UnmapBuffer(OpenTK.Graphics.OpenGL4.BufferTarget target);
            internal static UnmapBuffer glUnmapBuffer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void UseProgramStages(UInt32 pipeline, OpenTK.Graphics.OpenGL4.ProgramStageMask stages, UInt32 program);
            internal static UseProgramStages glUseProgramStages;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ValidateProgramPipeline(UInt32 pipeline);
            internal static ValidateProgramPipeline glValidateProgramPipeline;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1d(UInt32 index, Double x);
            internal static VertexAttrib1d glVertexAttrib1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib1dv glVertexAttrib1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1f(UInt32 index, Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib1s(UInt32 index, Int16 x);
            internal static VertexAttrib1s glVertexAttrib1s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib1sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib1sv glVertexAttrib1sv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2d(UInt32 index, Double x, Double y);
            internal static VertexAttrib2d glVertexAttrib2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib2dv glVertexAttrib2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2f(UInt32 index, Single x, Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            internal static VertexAttrib2s glVertexAttrib2s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib2sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib2sv glVertexAttrib2sv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttrib3d glVertexAttrib3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib3dv glVertexAttrib3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            internal static VertexAttrib3s glVertexAttrib3s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib3sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib3sv glVertexAttrib3sv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4bv glVertexAttrib4bv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttrib4d glVertexAttrib4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttrib4dv glVertexAttrib4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index, Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4iv glVertexAttrib4iv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nbv(UInt32 index, SByte* v);
            internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Niv(UInt32 index, Int32* v);
            internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nsv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            internal static VertexAttrib4Nub glVertexAttrib4Nub;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            internal static VertexAttrib4s glVertexAttrib4s;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttrib4sv glVertexAttrib4sv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttrib4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttrib4usv glVertexAttrib4usv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
            internal static VertexAttribBinding glVertexAttribBinding;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            internal static VertexAttribDivisor glVertexAttribDivisor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribType type, bool normalized, UInt32 relativeoffset);
            internal static VertexAttribFormat glVertexAttribFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI1i(UInt32 index, Int32 x);
            internal static VertexAttribI1i glVertexAttribI1i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI1iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI1iv glVertexAttribI1iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI1ui(UInt32 index, UInt32 x);
            internal static VertexAttribI1ui glVertexAttribI1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI1uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI1uiv glVertexAttribI1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI2i(UInt32 index, Int32 x, Int32 y);
            internal static VertexAttribI2i glVertexAttribI2i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI2iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI2iv glVertexAttribI2iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);
            internal static VertexAttribI2ui glVertexAttribI2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI2uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI2uiv glVertexAttribI2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);
            internal static VertexAttribI3i glVertexAttribI3i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI3iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI3iv glVertexAttribI3iv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            internal static VertexAttribI3ui glVertexAttribI3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI3uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI3uiv glVertexAttribI3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4bv(UInt32 index, SByte* v);
            internal unsafe static VertexAttribI4bv glVertexAttribI4bv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            internal static VertexAttribI4i glVertexAttribI4i;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4iv(UInt32 index, Int32* v);
            internal unsafe static VertexAttribI4iv glVertexAttribI4iv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4sv(UInt32 index, Int16* v);
            internal unsafe static VertexAttribI4sv glVertexAttribI4sv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4ubv(UInt32 index, Byte* v);
            internal unsafe static VertexAttribI4ubv glVertexAttribI4ubv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            internal static VertexAttribI4ui glVertexAttribI4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4uiv(UInt32 index, UInt32* v);
            internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribI4usv(UInt32 index, UInt16* v);
            internal unsafe static VertexAttribI4usv glVertexAttribI4usv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, UInt32 relativeoffset);
            internal static VertexAttribIFormat glVertexAttribIFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribIPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribIntegerType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribIPointer glVertexAttribIPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL1d(UInt32 index, Double x);
            internal static VertexAttribL1d glVertexAttribL1d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL1dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL1dv glVertexAttribL1dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL1ui64ARB(UInt32 index, UInt64 x);
            internal static VertexAttribL1ui64ARB glVertexAttribL1ui64ARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL1ui64vARB(UInt32 index, UInt64* v);
            internal unsafe static VertexAttribL1ui64vARB glVertexAttribL1ui64vARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL2d(UInt32 index, Double x, Double y);
            internal static VertexAttribL2d glVertexAttribL2d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL2dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL2dv glVertexAttribL2dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL3d(UInt32 index, Double x, Double y, Double z);
            internal static VertexAttribL3d glVertexAttribL3d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL3dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL3dv glVertexAttribL3dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w);
            internal static VertexAttribL4d glVertexAttribL4d;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribL4dv(UInt32 index, Double* v);
            internal unsafe static VertexAttribL4dv glVertexAttribL4dv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, UInt32 relativeoffset);
            internal static VertexAttribLFormat glVertexAttribLFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribLPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribDoubleType type, Int32 stride, IntPtr pointer);
            internal static VertexAttribLPointer glVertexAttribLPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP1ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP1ui glVertexAttribP1ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP1uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP1uiv glVertexAttribP1uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP2ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP2ui glVertexAttribP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP2uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP2uiv glVertexAttribP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP3ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP3ui glVertexAttribP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP3uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP3uiv glVertexAttribP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribP4ui(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32 value);
            internal static VertexAttribP4ui glVertexAttribP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexAttribP4uiv(UInt32 index, OpenTK.Graphics.OpenGL4.PackedPointerType type, bool normalized, UInt32* value);
            internal unsafe static VertexAttribP4uiv glVertexAttribP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexAttribPointer(UInt32 index, Int32 size, OpenTK.Graphics.OpenGL4.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
            internal static VertexBindingDivisor glVertexBindingDivisor;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexP2ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP2ui glVertexP2ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexP2uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP2uiv glVertexP2uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexP3ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP3ui glVertexP3ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexP3uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP3uiv glVertexP3uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void VertexP4ui(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32 value);
            internal static VertexP4ui glVertexP4ui;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void VertexP4uiv(OpenTK.Graphics.OpenGL4.PackedPointerType type, UInt32* value);
            internal unsafe static VertexP4uiv glVertexP4uiv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            internal static Viewport glViewport;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ViewportArrayv(UInt32 first, Int32 count, Single* v);
            internal unsafe static ViewportArrayv glViewportArrayv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            internal static ViewportIndexedf glViewportIndexedf;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void ViewportIndexedfv(UInt32 index, Single* v);
            internal unsafe static ViewportIndexedfv glViewportIndexedfv;
            [SuppressUnmanagedCodeSecurity]
            internal delegate OpenTK.Graphics.OpenGL4.WaitSyncStatus WaitSync(IntPtr sync, OpenTK.Graphics.OpenGL4.WaitSyncFlags flags, UInt64 timeout);
            internal static WaitSync glWaitSync;
        }
    }
}
